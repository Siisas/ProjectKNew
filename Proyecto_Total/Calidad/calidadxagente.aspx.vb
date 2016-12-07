Public Class calidadxagente
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
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

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            buscarinf()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub buscarinf()
        Try
            Dim objdatos As New clscalidad
            objdatos.agente = lblusuario.Text
            Panel3.Visible = True
            If txtid.Text <> "" Then
                objdatos.idreg = txtid.Text
            End If
            If txtfcinill.Text <> "" Then
                objdatos.fcinill = txtfcinill.Text
            End If
            If txtfcfinll.Text <> "" Then
                objdatos.fcfinll = txtfcfinll.Text
            End If
            dtggeneral.DataSource = objdatos.consultaaudit
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
            'consulta nota final
            objdatos.consultanotafin()
            lblnota.Text = FormatNumber(objdatos.nota / (lblcuenta.Text / 2), 2)


            If txtid.Text <> "" Then
                objdatos.idreg = txtid.Text
                dtgdetalle.DataSource = objdatos.consultaauditdetalle
                dtgdetalle.DataBind()
                lblcuentaaud.Text = objdatos.cantidad
            Else
                dtgdetalle.DataSource = Nothing
                dtgdetalle.DataBind()
                lblcuentaaud.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            buscarinf()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class