@Imports Microsoft.AspNet.Identity


@If Request.IsAuthenticated Then
    @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav navbar-right">
            <li>
                @Html.ActionLink("Minha Conta", "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.title = "Minha Conta"})
            </li>
            <li><a href="javascript:document.getElementById('logoutForm').submit()">Log off</a></li>
        </ul>
    End Using
Else
    @<ul class="nav navbar-nav navbar-right">
        <li>@Html.ActionLink("Cadastrar", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink"})</li>
        <li>@Html.ActionLink("Log in", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink"})</li>
    </ul>
End If

