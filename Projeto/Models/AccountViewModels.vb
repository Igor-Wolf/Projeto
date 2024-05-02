Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="Email")>
    Public Property Email As String
    Public Property Nome As String
    Public Property Usuario As String
    Public Property DataNasc As DateTime

End Class

Public Class ExternalLoginListViewModel
    Public Property ReturnUrl As String
End Class

Public Class SendCodeViewModel
    Public Property SelectedProvider As String
    Public Property Providers As ICollection(Of System.Web.Mvc.SelectListItem)
    Public Property ReturnUrl As String
    Public Property RememberMe As Boolean
End Class

Public Class VerifyCodeViewModel
    <Required>
    Public Property Provider As String
    
    <Required>
    <Display(Name:="Code")>
    Public Property Code As String
    
    Public Property ReturnUrl As String
    
    <Display(Name:="Remember this browser?")>
    Public Property RememberBrowser As Boolean

    Public Property RememberMe As Boolean
End Class

Public Class ForgotViewModel
    <Required>
    <Display(Name:="Email")>
    Public Property Email As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="Email")>
    <EmailAddress>
    Public Property Email As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password As String

    <Display(Name:="Lembrar Conta?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <Display(Name:="Nome Completo")>
    Public Property Nome As String

    <Required>
    <Display(Name:="Nome de Usuario")>
    Public Property Usuario As String

    <Display(Name:="Data de Nascimento")>
    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:dd-MM-yyyy}", ApplyFormatInEditMode:=True)>
    Public Property DataNasc As DateTime

    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email As String

    <Required>
    <StringLength(100, ErrorMessage:="A {0} dve ter ao menos {2} caracteres", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmar Senha")>
    <Compare("Password", ErrorMessage:="A senha e a confirmação da senha não coincidem.")>
    Public Property ConfirmPassword As String
End Class

Public Class ResetPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email() As String

    <Required>
    <StringLength(100, ErrorMessage:="A {0} dve ter ao menos {2} caracteres", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password() As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmar Senha")>
    <Compare("Password", ErrorMessage:="A senha e a confirmação da senha não coincidem.")>
    Public Property ConfirmPassword() As String

    Public Property Code() As String
End Class

Public Class ForgotPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email() As String
End Class
