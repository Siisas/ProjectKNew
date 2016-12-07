Public Class PerfilamientoCasos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                objdatos.idusuario = lblusuario.Text
                objdatos.consultacod()

                ''''' INICIO SEGURIDAD ACCESO URL '''''
                Dim objGeneral As New clsgeneral
                objGeneral.DtsSeguridad = Session("dtsSeguridad")
                objGeneral.Consulta_Proyecto_Seguridad()
                objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
                objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                objGeneral.PermisosUrl()
                ''''' FIN SEGURIDAD ACCESO URL '''''   
                MostrarCasos()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub

    Protected Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text <> "" Then
                objdatos.caso = txtcaso.Text
                objdatos.Validacion = "1"
                dtgcasos.DataSource = objdatos.consultaperfilamiento()
                dtgcasos.DataBind()
                If objdatos.cantidad <> 0 Then
                    txtestado.Text = objdatos.tipificacion
                    If txtestado.Text = "Cerrado" Then
                        lblmsg.Text = "Esta caso ya se encuentra cerrado"
                        txtcasoasig.Text = ""
                        txtmin.Text = ""
                        txtnombre.Text = ""
                        txtdocumen.Text = ""
                        txtequipo.Text = ""
                        txtplan.Text = ""
                        txtdepar.Text = ""
                        txtcorreo.Text = ""
                        txtobservacion.Text = ""
                        txtfechareg.Text = ""
                        txtestado.Text = ""
                        lblcuentacasos.Text = ""
                        dtgcasos.DataSource = Nothing
                        dtgcasos.DataBind()
                        Exit Sub
                    Else
                        txtcasoasig.Text = objdatos.caso
                        txtmin.Text = objdatos.min
                        txtnombre.Text = objdatos.cliente
                        txtdocumen.Text = objdatos.documento
                        txtequipo.Text = objdatos.equipo
                        txtplan.Text = objdatos.plan
                        txtdepar.Text = objdatos.lugar
                        txtcorreo.Text = objdatos.email
                        txtobservacion.Text = objdatos.obsini
                        txtfechareg.Text = objdatos.casfcregistro
                        lblcuentacasos.Text = objdatos.cantidad
                    End If

                ElseIf objdatos.cantidad < 1 Then
                    lblmsg.Text = "No se encontraron datos"
                    txtcasoasig.Text = ""
                    txtmin.Text = ""
                    txtnombre.Text = ""
                    txtdocumen.Text = ""
                    txtequipo.Text = ""
                    txtplan.Text = ""
                    txtdepar.Text = ""
                    txtcorreo.Text = ""
                    txtobservacion.Text = ""
                    txtfechareg.Text = ""
                    txtestado.Text = ""
                    lblcuentacasos.Text = ""
                    dtgcasos.DataSource = Nothing
                    dtgcasos.DataBind()
                    Exit Sub
                End If

                lblmsg.Text = ""
            Else
                lblmsg.Text = "Digite el caso que desea consultar"
                Exit Sub
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub

    Protected Sub MostrarCasos()
        Try
            Dim objdatos As New clscrmdatos
            objdatos.Validacion = "2"
            objdatos.idusuario = lblusuario.Text
            dtgCasosApro.DataSource = objdatos.consultaperfilamiento()
            dtgCasosApro.DataBind()
            lblcasosApro.Text = objdatos.cantidad

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message

        End Try

    End Sub

    Protected Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            Quitar()

            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub

    Protected Sub Quitar()
        Try
            If txtcasoasig.Text <> "" Then
                txtcasoasig.Text = ""
                txtmin.Text = ""
                txtnombre.Text = ""
                txtdocumen.Text = ""
                txtequipo.Text = ""
                txtplan.Text = ""
                txtdepar.Text = ""
                txtcorreo.Text = ""
                txtobservacion.Text = ""
                txtfechareg.Text = ""
                txtestado.Text = ""
                lblcuentacasos.Text = ""
                txtarea.Text = ""
                dtgcasos.DataSource = Nothing
                dtgcasos.DataBind()

            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Try
            Dim objdatos As New clscrmdatos
            If txtcasoasig.Text = Nothing Then
                lblmsg.Text = "Consulte primero un caso"
                Exit Sub
            End If
            If lblusuario.Text = "" Then
                lblmsg.Text = "Error a cargar la pagina"
                Exit Sub
            End If
            If txtarea.Text = "" Then
                lblmsg.Text = "Ingrese un comentario"
                Exit Sub
            End If
            objdatos.obs = txtarea.Text
            objdatos.caso = txtcasoasig.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.inserta_Perfilamiento()

            Quitar()
            MostrarCasos()

            lblmsg.Text = "Caso guardado con exito"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            If lblmsg.Text.Contains("Se produjo error Infracción de la restricción UNIQUE KEY 'UQ__Perfilam__21BED0BFEBBFA9E8'") Then
                lblmsg.Text = "Este caso ya se encuentra aprobado"

            End If
        End Try

    End Sub
End Class