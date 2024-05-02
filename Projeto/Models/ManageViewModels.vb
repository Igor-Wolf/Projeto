Imports System.ComponentModel.DataAnnotations
Imports Microsoft.AspNet.Identity
Imports Microsoft.Owin.Security

Public Class IndexViewModel
    Public Property HasPassword As Boolean
    Public Property Logins As IList(Of UserLoginInfo)
    Public Property PhoneNumber As String
    Public Property TwoFactor As Boolean
    Public Property BrowserRemembered As Boolean
    Public Property DataNasc As Date
    Public Property Usuario As String
    Public Property Nome As String
End Class

Public Class ManageLoginsViewModel
    Public Property CurrentLogins As IList(Of UserLoginInfo)
    Public Property OtherLogins As IList(Of AuthenticationDescription)
End Class

Public Class FactorViewModel
    Public Property Purpose As String
End Class

Public Class SetPasswordViewModel
    <Required>
    <StringLength(100, ErrorMessage:="A {0} deve ter ao menos {2} caracteres.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nova Senha")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirme a Nova Senha")>
    <Compare("NewPassword", ErrorMessage:="A nova senha e sua confirmação não coincidem")>
    Public Property ConfirmPassword As String
End Class

Public Class ChangePasswordViewModel

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
    <DataType(DataType.Password)>
    <Display(Name:="Senha Atual")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="A {0} deve ter ao menos {2} caracteres.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nova Senha")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirme a Nova Senha")>
    <Compare("NewPassword", ErrorMessage:="A nova senha e sua confirmação não coincidem.")>
    Public Property ConfirmPassword As String
End Class

Public Class AddPhoneNumberViewModel
    <Required>
    <Phone>
    <Display(Name:="Phone Number")>
    Public Property Number As String
End Class

Public Class VerifyPhoneNumberViewModel
    <Required>
    <Display(Name:="Code")>
    Public Property Code As String

    <Required>
    <Phone>
    <Display(Name:="Phone Number")>
    Public Property PhoneNumber As String
End Class

Public Class ConfigureTwoFactorViewModel
    Public Property SelectedProvider As String
    Public Property Providers As ICollection(Of System.Web.Mvc.SelectListItem)
End Class