Public Class devolucionservice
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                casosptes()
                cargadrl()
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
    Protected Sub cargadrl()
        Try
            Dim objdatos As New clsgeneral
            With drlvariable
                objdatos.idusuario = 6
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
            With drlapn
                .DataSource = objdatos.consultaapn
                .DataTextField = "apn"
                .DataValueField = "apn"
                .DataBind()
            End With
            With drlqos
                .DataSource = objdatos.consultaqos
                .DataTextField = "qos"
                .DataValueField = "qos"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub casosptes()
        Try
            Dim objdatos As New clscrmdatos
            dtggeneral.DataSource = objdatos.consultadevueltosservice
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub buscar()
        Try
            Dim objdatos As New clscrmdatos
        If txtcaso.Text = "" Then
            lblmsg.Text = "Digite el caso que desea consultar"
            Exit Sub
        Else
            objdatos.caso = txtcaso.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.consultadevueltosservice()
            If objdatos.cantidad > 0 Then
                Dim objtmp As New clsgeneral
                txtcaso.Text = objdatos.caso
                If objdatos.tipofalla = "AJENO A RED CELULAR" Then
                    rdbron.SelectedValue = "Ajeno a Red Celular"
                    objtmp.idusuario = 7
                End If
                If objdatos.tipofalla = "ERROR EN REGISTRO" Then
                    rdbron.SelectedValue = "Error en Registro"
                    objtmp.idusuario = 6
                End If
                If objdatos.tipofalla = "Asociadas a red celular" Then
                    rdbron.SelectedValue = "Asociado Red Celular"
                    objtmp.idusuario = 9
                End If

                With drlvariable
                    .DataSource = objtmp.consultadiagnostico
                    .DataTextField = "detalle"
                    .DataValueField = "idreg"
                    .DataBind()
                End With
                drlvariable.SelectedValue = objdatos.diagvariable
                drlapn.SelectedValue = objdatos.apn
                drlqos.SelectedValue = objdatos.qos
                txtfcactivacion.Text = objdatos.fcini
                Txtobs.Text = objdatos.obs
                hlkarchivo.NavigateUrl = "~/DatosCRM/data_Doc/" & objdatos.archivo
                lblmsg.Text = ""
            Else
                    txtcaso.Text = ""
                casosptes()
                    lblmsg.Text = "El caso no existe o no se encuentra reportado como devuelto, verifique"
            End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            buscar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub habilitaestado()
        Dim objdatos As New clscrmdatos
        Try
            objdatos.caso = txtcaso.Text
            objdatos.actualizaestadodevueltoserv()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btnguardar0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar0.Click
        Try
            Dim objdatos As New clscrmdatos
            objdatos.caso = txtcaso.Text
            If chkanula.Checked = True Then
                habilitaestado()
                objdatos.actualizaescalaserv()
                lblmsg.Text = "Escalamiento Service anulado con éxito"
            Else
                Dim Fn As String
                    Dim SaveLocation As String
                    If Not FileDocumento.PostedFile Is Nothing And FileDocumento.PostedFile.ContentLength > 0 Then
                        Fn = System.IO.Path.GetFileName(FileDocumento.PostedFile.FileName)
                        SaveLocation = Server.MapPath("data_Doc") & "\\" & Fn
                        FileDocumento.PostedFile.SaveAs(SaveLocation)
                        objdatos.archivo = Fn
                End If
                If Txtobs.Text = "" Then
                    lblmsg.Text = "Digite la observación de escalamiento a service"
                    Exit Sub
                Else
                    objdatos.obs = Txtobs.Text
                End If
                    If drlapn.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Elija el APN del caso"
                        Exit Sub
                    Else
                        objdatos.apn = drlapn.SelectedItem.Text
                    End If
                    If drlqos.SelectedItem.Text = "- Seleccione -" Then
                        lblmsg.Text = "Seleccione el QoS del caso"
                        Exit Sub
                    Else
                        objdatos.qos = drlqos.SelectedItem.Text
                    End If
                    If txtfcactivacion.Text = "" Then
                        lblmsg.Text = "Digite la fecha de activación del servicio"
                        Exit Sub
                    Else
                        objdatos.fcini = txtfcactivacion.Text
                    End If
                objdatos.caso = txtcaso.Text
                objdatos.diagvariable = drlvariable.SelectedItem.Value
                objdatos.actservice()
                lblmsg.Text = "Escalamiento service modificado con éxito"
            End If
            guardacrm()
            'limpiar
            drlapn.SelectedValue = "- Seleccione -"
            drlqos.SelectedValue = "- Seleccione -"
            txtfcactivacion.Text = ""
            Txtobs.Text = ""
            chkanula.Checked = False
            txtcaso.Text = ""
            casosptes()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub guardacrm()
        Dim objdatos As New clsvoz
        Try
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If Txtobs.Text = "" Then
                objdatos.obs = ""
            Else
                objdatos.obs = Txtobs.Text
            End If
            If chkanula.Checked = True Then
                objdatos.tipificacion = "Anulado"
            Else
                objdatos.tipificacion = "Corregido"
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registrocrmfallareddatos()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            casosptes()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub rdbron_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdbron.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            If rdbron.SelectedItem.Value = "Error en Registro" Then
                objdatos.idusuario = 6
            End If
            If rdbron.SelectedItem.Value = "Ajeno a Red Celular" Then
                objdatos.idusuario = 7
            End If
            If rdbron.SelectedItem.Value = "Asociado Red Celular" Then
                objdatos.idusuario = 9
            End If
            With drlvariable
                .DataSource = objdatos.consultadiagnostico
                .DataTextField = "detalle"
                .DataValueField = "idreg"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            Dim objdatos As New clsvoz
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                txtcaso.Text = dtggeneral.Rows(index).Cells(1).Text
                If txtcaso.Text <> Nothing Then
                    objdatos.caso = txtcaso.Text
                End If
                buscar()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
End Class