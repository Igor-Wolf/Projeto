@ModelType RegisterViewModel
@Code
    ViewBag.Title = "CADASTRAR"
End Code
<head>

    <link href="@Url.Content("~/Content/register.css")" rel="stylesheet" />

</head>

<video autoplay muted loop>
    <source src="~/Content/Assets/quarto.mp4" type="video/mp4">
    Seu navegador não suporta vídeo HTML5.
</video>
<div class="filtro">

</div>

<h2>MYGAMES</h2>

<div class="externo">
    <h3>Cadastrar</h3>
    @Using Html.BeginForm("Register", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})

        @Html.AntiForgeryToken()

        @<text>
            <h4>Preencha os dados para criar uma nova conta</h4>
            <hr />
            @Html.ValidationSummary("", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-6 control-label"})
                <div class="col-md-6">
                    @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group lateral">
                @Html.LabelFor(Function(m) m.Nome, New With {.class = "col-md-6 control-label"})
                <div class="col-md-6">
                    @Html.TextBoxFor(Function(m) m.Nome, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group lateral">
                @Html.LabelFor(Function(m) m.Usuario, New With {.class = "col-md-6 control-label"})
                <div class="col-md-6">
                    @Html.TextBoxFor(Function(m) m.Usuario, New With {.class = "form-control"})
                </div>
            </div>
    <div class="form-group lateral">
        @Html.LabelFor(Function(m) m.DataNasc, New With {.class = "col-md-6 control-label"})
        <div class="col-md-6">
            @Html.EditorFor(Function(m) m.DataNasc, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(m) m.DataNasc, "", New With {.class = "text-danger"})
        </div>
    </div>

            <div class="form-group lateral">
                @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-6 control-label"})
                <div class="col-md-6">
                    @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                </div>
            </div>
            <div class="form-group lateral">
                @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-6 control-label"})
                <div class="col-md-6">
                    @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
                </div>
            </div>
    <div class="loginBtn">
        <div class="form-group">
            <div class="col-md-10">
                <input type="submit" class="btn btnLogin" value="Cadastrar" />
            </div>
        </div>
        <p>
            @Html.ActionLink("Retornar ao Login", "Login")
        </p>
    </div>
        </text>

    End Using
</div>
   @section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    <script src="~/Scripts/globalize/globalize.js"></script>
    <script src="~/Scripts/globalize/cultures/globalize.culture.@(System.Threading.Thread.CurrentThread.CurrentCulture.Name).js"></script>
    <script>
        $.validator.methods.number = function (value, element) {
            return this.optional(element) ||
                !isNaN(Globalize.parseFloat(value));
        }
        $(document).ready(function () {
            Globalize.culture('@(System.Threading.Thread.CurrentThread.CurrentCulture.Name)');
        });
    </script>
    <script>
        jQuery.extend(jQuery.validator.methods, {
            range: function (value, element, param) {
                //Use the Globalization plugin to parse the value
                var val = Globalize.parseFloat(value);
                return this.optional(element) || (
                    val >= param[0] && val <= param[1]);
            }
        });
        $.validator.methods.date = function (value, element) {
            return this.optional(element) ||
                Globalize.parseDate(value) ||
                Globalize.parseDate(value, "yyyy-MM-dd");
        }
    </script>
End Section