Imports System.Web.Mvc
Imports Projeto.TesteViewModel ' Importe o namespace onde está sua classe TesteViewModel
Imports System.Data.SqlClient ' Importe o namespace necessário para trabalhar com SQL Server
Imports System.Web.Script.Serialization

Public Class TesteController
    Inherits Controller

    Function Index() As ActionResult
        If User.Identity.IsAuthenticated Then
            ' Lista para armazenar os jogos do banco de dados
            Dim jogos As New List(Of TesteViewModel)()

            ' Configura a conexão com o banco de dados
            Dim connectionString As String = "Data Source=localhost\sqlexpress01;Initial Catalog=Usuarios;Integrated Security=True;"
            Using connection As New SqlConnection(connectionString)
                ' Abre a conexão
                connection.Open()

                ' Comando SQL para selecionar todos os jogos da tabela Games
                Dim sqlQuery As String = "SELECT * FROM Games"

                ' Cria um comando para executar a consulta SQL
                Using command As New SqlCommand(sqlQuery, connection)
                    ' Executa a consulta e obtém um leitor de dados
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Itera sobre os resultados e adiciona cada jogo à lista de jogos
                        While reader.Read()
                            Dim jogo As New TesteViewModel With {
                                .GameID = DirectCast(reader("GameID"), Integer),
                                .Title = reader("Title").ToString(),
                                .Genre = reader("Genre").ToString(),
                                .ReleaseDate = DirectCast(reader("ReleaseDate"), DateTime),
                                .Rating = DirectCast(reader("Rating"), Decimal),
                                .Description = reader("Description").ToString(),
                                .Store = reader("Store").ToString(),
                                .LinkImage = reader("LinkImage").ToString()
                            }

                            jogos.Add(jogo)
                        End While
                    End Using
                End Using
            End Using

            ' Ordena os jogos por ordem alfabética pelo atributo Title
            jogos.Sort(Function(x, y) x.Title.CompareTo(y.Title))

            ' Serializa os dados dos jogos para JSON
            Dim serializer As New JavaScriptSerializer()
            Dim jsonJogos As String = serializer.Serialize(jogos)

            ' Armazena os dados dos jogos na ViewBag
            ViewBag.JogosJson = jsonJogos

            ' Recupera o valor da busca de jogos
            Dim buscaJogo As String = DirectCast(Session("buscaJogo"), String)
            ViewBag.BuscaJogo = buscaJogo

            Return View()
        Else
            Return RedirectToAction("Login", "Account")
        End If
    End Function

    <HttpPost>
    Function FiltrarJogos(buscaJogo As String) As ActionResult
        ' Armazena o valor da busca de jogos na sessão
        Session("buscaJogo") = buscaJogo

        ' Redireciona de volta para a página inicial
        Return RedirectToAction("Index")
    End Function
End Class
