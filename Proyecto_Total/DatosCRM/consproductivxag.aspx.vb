Public Class consproductivxag
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                With drlestado
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultatipificacion
                    .DataTextField = "tipificacion"
                    .DataValueField = "idtipificacion"
                    .DataBind()
                End With
                ''''' INICIO SEGURIDAD ACCESO URL '''''
                Dim objGeneral As New clsgeneral
                objGeneral.DtsSeguridad = Session("dtsSeguridad")
                objGeneral.Consulta_Proyecto_Seguridad()
                objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
                objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                objGeneral.PermisosUrl()
                ''''' FIN SEGURIDAD ACCESO URL '''''    
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If drlestado.SelectedItem.Value <> 0 Then
                objdatos.tipificacion = drlestado.SelectedItem.Text
            End If
            If txtfcdesden3.Text <> Nothing Then
                objdatos.fcini3 = txtfcdesden3.Text
                lblmsg.Text = ""
            Else
                lblmsg.Text = "Debe seleccionar un rango de fechas para realizar la consulta"
                Exit Sub
            End If
            If txtfchastan3.Text <> Nothing Then
                If Convert.ToDateTime(txtfcdesden3.Text) > Convert.ToDateTime(txtfchastan3.Text) Then
                    lblmsg.Text = "La fecha desde no puede ser mayor que la fecha hasta"
                    Exit Sub
                End If
                objdatos.fcfin3 = txtfchastan3.Text
            End If

            'Dim num1 As New Decimal
            'Dim num2 As New Decimal
            'Dim num3 As New Decimal
            'num1 = txtfcdesden3.Text
            'num2 = txtfchastan3.Text
            'num3 = num2 - num1
            'Label1.Text = num3
            'Exit Sub
            objdatos.idusuario = lblusuario.Text
            dtggeneral.DataSource = objdatos.consultaprodind
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(sender As Object, e As ImageClickEventArgs) Handles Button1.Click
        buscarinf()
    End Sub

End Class