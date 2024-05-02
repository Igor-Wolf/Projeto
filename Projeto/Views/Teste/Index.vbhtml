@Code
            ViewBag.Title = "Index"
End Code
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="@Url.Content("~/Content/jogos.css")" rel="stylesheet" />
</head>
<div class="carroselMaior">
    <div class="owl-one owl-carousel owl-theme">
        <div class="item">
            <div class="jogo-principal j1">
                <div class="caixa">
                    <h3 class="nomejogo">Baldurs Gate III</h3>
                    <p class="descricao">
                        Um antigo mal retornou a Baldur's Gate, determinado a devorá-la de dentro para fora. O destino de Faerun está em suas mãos. Sozinho, você pode resistir. Mas juntos, vocês podem vencer. Reúna seu grupo e retorne aos Reinos Esquecidos em uma história de companheirismo e traição, sacrifício e sobrevivência, e o atrativo do poder absoluto.
                    </p>
                </div>
            </div>
        </div>

        <div class="item">
            <div class="jogo-principal j2">
                <div class="caixa">
                    <h3 class="nomejogo">Hogwarts Legacy</h3>
                    <p class="descricao">
                        Agora você pode assumir o controle da ação e estar no centro da sua própria aventura no mundo da magia. Embarque em uma jornada por lugares familiares e novos enquanto explora e descobre criaturas fantásticas, personaliza seu personagem e cria poções, domina o lançamento de feitiços, aprimora talentos e se torna o bruxo que deseja ser.
                    </p>
                </div>
            </div>
        </div>
        <div class="item">
            <div class="jogo-principal j3">
                <div class="caixa">
                    <h3 class="nomejogo">Elden Ring</h3>
                    <p class="descricao">
                        Levante-se, Maculado, e seja guiado pela graça para portar o poder do Anel Prístino e se tornar um Lorde Prístino nas Terras Intermédias.
                    </p>
                </div>
            </div>
        </div>

        <div class="item">
            <div class="jogo-principal j4">
                <div class="caixa">
                    <h3 class="nomejogo">Dragon's Dogma II</h3>
                    <p class="descricao">
                        Embarque em uma jornada épica repleta de mistério, escolhas e batalhas intensas em Dragon's Dogma 2! Escolha o seu próprio caminho, monte seu grupo de Pawns e mergulhe em um mundo de fantasia como nenhum outro. Prepare-se para enfrentar desafios épicos e descobrir segredos ancestrais. O destino de um reino está em suas mãos - você está pronto para aceitar o desafio?
                    </p>
                </div>
            </div>
        </div>
    </div>

</div>

<div id="lancamentos" class="lancamentos">
    <div>
        <h3>Busca</h3>
    </div>
    <div class="divisor"></div>
</div>
<div class="realizarBusca">
    <form class="formBuscar" action="@Url.Action("FiltrarJogos", "Teste")" method="post">
        <input class="textoChecar" type="text" name="buscaJogo" maxlength="50" placeholder="Digite o nome do Jogo">
        <button type="submit" class="btn btnLogin">Checar</button>
    </form>
</div>
<div id="jogosContainer">
    <!-- Aqui será adicionada a div para cada jogo -->
</div>
<script type="text/javascript">
    // Recupera os dados dos jogos da ViewBag
    var jogosJson = @Html.Raw(ViewBag.JogosJson);

    // Verifica se há dados de jogos
    if (jogosJson && jogosJson.length > 0) {
        // Filtra os jogos com base na busca
        function filtrarJogos(busca) {
            if (!busca || busca.trim() === '') {
                return jogosJson; // Retorna todos os jogos se a busca estiver vazia
            } else {
                // Filtra os jogos cujo título contenha o texto da busca
                return jogosJson.filter(function(jogo) {
                    return jogo.Title.toLowerCase().indexOf(busca.toLowerCase()) !== -1;
                });
            }
        }

        // Função para renderizar os jogos na página
        function renderizarJogos(jogos) {
            // Seleciona o container onde adicionar as divs
            var jogosContainer = document.getElementById('jogosContainer');
            jogosContainer.innerHTML = ''; // Limpa o conteúdo atual

            // Itera sobre os dados dos jogos filtrados
            for (var i = 0; i < jogos.length; i++) {
                // Cria uma div para cada jogo
                var divJogo = document.createElement('div');
                divJogo.className = 'jogo';

                // Cria uma imagem para o jogo
                var imgJogo = document.createElement('img');
                imgJogo.src = jogos[i].LinkImage; // Define o src da imagem como o LinkImage do jogo
                imgJogo.alt = jogos[i].Title; // Define o texto alternativo da imagem como o título do jogo

                // Adiciona a imagem à div do jogo
                divJogo.appendChild(imgJogo);

                // Adiciona a div do jogo ao container
                jogosContainer.appendChild(divJogo);
            }
        }

        // Função para executar a busca ao carregar a página
        window.onload = function() {
            var buscaJogo = '@Html.Raw(ViewBag.BuscaJogo)'; // Obtém o valor da variável buscaJogo
            var jogosFiltrados = filtrarJogos(buscaJogo); // Filtra os jogos com base na busca
            renderizarJogos(jogosFiltrados); // Renderiza os jogos filtrados na página
        };
    }
</script>
