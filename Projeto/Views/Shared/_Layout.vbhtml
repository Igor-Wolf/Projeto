<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - MYGAMES</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" />
    <link href="@Url.Content("~/Content/owl/owl.carousel.min.css")" rel="stylesheet" />
    <link href="@Url.Content("~/Content/owl/owl.theme.default.min.css")" rel="stylesheet" />
    

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        
            <div class="navbar-header titulo">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("MYGAMES", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li>@Html.ActionLink("Busca", "Index", "Teste")</li>
                    <li>@Html.ActionLink("Sobre", "About", "Home")</li>
                    @*<li>@Html.ActionLink("Contato", "Contact", "Home")</li>*@
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    
    <div class="render">
          
            @RenderBody()
        
            <footer>
                
                <div class="divisor2"></div>
                <p>&copy; @DateTime.Now.Year - Todos os direitos reservados à Igor Barbosa. Desenvolvido por <a style="text-decoration:none; color:inherit; font-weight:600" href="https://github.com/Igor-Wolf">IB</a></p>
            </footer>
        </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    <script src="~/Scripts/owl/jquery.min.js"></script>
    <script src="~/Scripts/owl/owl.carousel.min.js"></script>
    <script>

        $('.owl-two').owlCarousel({

            loop: false,
            margin:10,
            nav: false,
            responsive: {


                0: {
                    items: 1
                },
                400: {
                    items: 2
                },
                600: {
                    items: 3
                },
                1000: {
                    items: 5
                },
                1400: {
                    items: 6
                },
                1800:{
                    items: 7
                }
            }
        })

        $('.owl-one').owlCarousel({

            loop: true,
            margin: 0,
            nav: false,
            responsive: {


                0: {
                    items: 1
                }
            }
        })
        function mudarBaner() {


            $('.owl-one').trigger('next.owl.carousel');

        }
        setInterval(mudarBaner, 8000);


    </script>
    @RenderSection("scripts", required:=False)
</body>
</html>
