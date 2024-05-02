@ModelType IndexViewModel
@Code
    ViewBag.Title = "CONTA"
End Code
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link href="@Url.Content("~/Content/indexManeger.css")" rel="stylesheet" />   

</head>

<video autoplay muted loop>
    <source src="~/Content/Assets/hogwarts.mp4" type="video/mp4">
    Seu navegador não suporta vídeo HTML5.
</video>
<div class="filtro">

</div>
<div class="conteudo">

    <h2>Sua Conta</h2>

    <p class="text-success">@ViewBag.StatusMessage</p>
    <div class="passworBox">
        <div class="esquerda">
            <p><strong>Nome Completo:</strong> @Model.Nome</p>
            <p><strong>Nome de Usuário:</strong> @Model.Usuario</p>
            <p><strong>Data de Nascimento:</strong> @Model.DataNasc.ToShortDateString</p>

            <form action="@Url.Action("ChangePassword", "Manage")" method="get">
                <button type="submit" class="btn btnLogin">
                    @If Model.HasPassword Then
                        @Html.Raw("Alterar Dados")
                    Else
                        @Html.Raw("Create")
                    End If
                </button>
            </form>
        </div>
        <div class="direita">
            <p>Lista de jogos:</p>
            <div class="botoes" title="Não implementado">
                <button type="submit" class="btn btnLogin">
                    @If Model.HasPassword Then
                        @Html.Raw("Meu Jogos ")

                    End If
                </button>
                <button type="submit" class="btn btnLogin">
                    @If Model.HasPassword Then
                        @Html.Raw("Lista de Desejos")
                    End If
                </button>

            </div>
        </div>

    </div>

</div>

