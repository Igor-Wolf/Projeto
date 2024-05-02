Imports Microsoft.AspNet.Identity

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        If User.Identity.IsAuthenticated Then
            Return View()
        Else
            Return RedirectToAction("Login", "Account")
        End If
    End Function

    Function About() As ActionResult
        If User.Identity.IsAuthenticated Then
            ViewData("Message") = "Your application description page."
            Return View()
        Else
            Return RedirectToAction("Login", "Account")
        End If
    End Function

    Function Contact() As ActionResult
        If User.Identity.IsAuthenticated Then
            ViewData("Message") = "Your contact page."
            Return View()
        Else
            Return RedirectToAction("Login", "Account")
        End If
    End Function
End Class
