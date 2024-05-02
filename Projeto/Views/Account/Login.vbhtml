@ModelType LoginViewModel
@Code
    ViewBag.Title = "LOGIN"
End Code

<head>
    
    <link href="@Url.Content("~/Content/login.css")" rel="stylesheet" />
    <link rel="shortcut icon" type="image/x-icon" href="@Url.Content("~/favicon.ico")" />

</head>
<video autoplay muted loop>
    <source src="~/Content/Assets/quarto.mp4" type="video/mp4">
    Seu navegador não suporta vídeo HTML5.
</video>
<div class="filtro">

</div>
<h2>MYGAMES</h2>

<div class="row">
    <div class="externo">
        
        <h3>Login</h3>
        <section id="loginForm">
            @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                @Html.AntiForgeryToken()
                @<text>
                <h4>Use um email para realizar o login</h4>
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-3 control-label"})
                    <div class="col-md-9">
                        @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                    </div>
                </div>
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-3 control-label"})
                    <div class="col-md-9">
                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-10">
                        <div class="checkbox">
                            @Html.CheckBoxFor(Function(m) m.RememberMe)
                            @Html.LabelFor(Function(m) m.RememberMe)
                        </div>
                    </div>
                </div>
            <div class="loginBtn">
                <div class="form-group">
                    <div class="col-md-10">
                        <input type="submit" value="Log in" class="btn btnLogin" />
                    </div>
                </div>
                <p>
                    @Html.ActionLink("Cadastrar novo usuário", "Register")
                </p>
            </div>

                @* Enable this once you have account confirmation enabled for password reset functionality
                    <p>
                        @Html.ActionLink("Forgot your password?", "ForgotPassword")
                    </p>*@
                </text>
            End Using
        </section>
    </div>
   
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
