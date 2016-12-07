Imports System.Net.Mail

Public Class clscorreos
    Dim server As New SmtpClient("smtp.gmail.com", 587)

    Dim _Correo As String
    Dim _Pass As String

    Public Property Pass As String
        Get
            Return _Pass
        End Get
        Set(ByVal value As String)
            _Pass = value
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(ByVal value As String)
            _Correo = value
        End Set
    End Property

    Public Sub New(ByVal Correo As String, ByVal pass As String)
        server.Credentials = New System.Net.NetworkCredential(Correo, Pass)
        server.EnableSsl = True
    End Sub

    Public Sub MandarCorreo(mensaje As MailMessage)
        server.Send(mensaje)
    End Sub


End Class
