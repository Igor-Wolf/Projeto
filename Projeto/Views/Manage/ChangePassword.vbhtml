@ModelType ChangePasswordViewModel
@Code
    ViewBag.Title = "ALTERAR"
End Code

<head>

    <link href="@Url.Content("~/Content/changePassword.css")" rel="stylesheet" />

</head>
<video autoplay muted loop>
    <source src="~/Content/Assets/hogwarts.mp4" type="video/mp4">
    Seu navegador não suporta vídeo HTML5.
</video>
<div class="filtro">

</div>

<div class="conteudo">
    <h2>Alterar dados da Conta</h2>
    <div class="passworBox">
        @Using Html.BeginForm("ChangePassword", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()

    @<text>

        @Html.ValidationSummary("", New With {.class = "text-danger"})
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
        <div class="form-group">
            @Html.LabelFor(Function(m) m.OldPassword, New With {.class = "col-md-6 control-label"})
            <div class="col-md-6">
                @Html.PasswordFor(Function(m) m.OldPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "col-md-6 control-label"})
            <div class="col-md-6">
                @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-6 control-label"})
            <div class="col-md-6">
                @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="loginBtn">
            <div class="form-group ">
                <div class="col-md-10">
                    <input type="submit" value="Confirmar" class="btn btnLogin" />
                </div>
            </div>
        </div>
    </text>
        End Using
    </div>
    </div>  
    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section
