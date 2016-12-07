Public Class procescalav2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                casosptes()
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
    Protected Sub casosptes()
        Try
            Dim objdatos As New clsvoz
            objdatos.idusuario = lblusuario.Text
            If txtcaso.Text <> Nothing Then
                objdatos.caso = txtcaso.Text
            End If
            dtggeneral.DataSource = objdatos.consultaescaladosv2serv
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
            If objdatos.cantidad > 0 Then
                lblmin.Text = objdatos.min
                lblcliente.Text = objdatos.cliente
            Else
                lblmin.Text = ""
                lblcliente.Text = ""
            End If
            
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsvoz
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If txtcpd.Text = "" And chkanula.Checked = False Then
                lblmsg.Text = "Digite el consecutivo asignado para el escalamiento o anulelo"
                Exit Sub
            Else
                If chkanula.Checked = True Then
                    objdatos.fechafin = 1
                    If txtobs.Text = "" Then
                        lblmsg.Text = "Digite una observación si desea anular el escalamiento"
                        Exit Sub
                    Else
                        objdatos.obs = txtobs.Text
                    End If
                    objdatos.estadoinc = "Anulado"
                    objdatos.actualizaestadodevueltoservvoz()
                Else
                    objdatos.estadoinc = "Escalado"
                End If

                objdatos.tickler = txtcpd.Text
            End If
            If txtobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtobs.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.actualizaescaladosv2serv()
            guardacrm()
            lblmsg.Text = "Seguimiento ingresado con éxito"
            txtcpd.Text = ""
            txtcaso.Text = ""
            txtobs.Text = ""
            chkanula.Checked = False
            casosptes()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub guardacrm()
        Dim objdatos As New clsvoz
        Try
            objdatos.caso = txtcaso.Text
            If txtobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = txtobs.Text
            End If
            If chkanula.Checked = True Then
                objdatos.tipificacion = "Anulado"
            Else
                objdatos.tipificacion = "Reportado"
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registrocrmfallared()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnbusca_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnbusca.Click
        casosptes()
    End Sub

    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            casosptes()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dtggeneral_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            Dim objdatos As New clsvoz
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                txtcaso.Text = dtggeneral.Rows(index).Cells(1).Text
                If txtcaso.Text <> Nothing Then
                    objdatos.caso = txtcaso.Text
                End If
                casosptes()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
End Class