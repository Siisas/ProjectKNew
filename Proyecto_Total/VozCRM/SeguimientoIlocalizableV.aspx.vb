Public Class SeguimientoIlocalizableV
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

    Sub buscarinf()
        Try
            Dim objdatos As New clsvoz
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso que desea consultar"
            Else
                objdatos.caso = txtcaso.Text
                dtggeneral.DataSource = objdatos.consultacasovoz
                dtggeneral.DataBind()
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lbldocumento.Text = objdatos.documento
                    lblmin.Text = objdatos.min
                    lblequipo.Text = objdatos.equipo
                    lblcaso.Text = objdatos.caso
                    lblobs611.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    lblmesa.Text = objdatos.mesa
                    lblfallatec.Text = objdatos.fallatec
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    lblmsg.Text = ""
                Else
                    lblcliente.Text = ""
                    lbldocumento.Text = ""
                    lblmin.Text = ""
                    lblequipo.Text = ""
                    lblcaso.Text = ""
                    lblobs611.Text = ""
                    lblestado.Text = ""
                    lblmesa.Text = ""
                    lblfallatec.Text = ""
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim objdatos As New clscrmdatos
            buscarinf()
            If txtcaso.Text <> "" Then
                objdatos.caso = txtcaso.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registroconsultacaso()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsvoz
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Antes de guardar de clic en el botón buscar para verificar que el caso es válido"
                Exit Sub
            End If
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If

            If txtobs.Text = "" Then
                lblmsg.Text = "Digite la observación de atención al caso"
                Exit Sub
            Else
                objdatos.obs = txtobs.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.tipificacion = "No Contactado"
            objdatos.preg1 = "null"
            objdatos.telalt = "null"
            objdatos.tiposoporte = 0
            objdatos.barrio = 0
            objdatos.pqr = 1

            objdatos.registrocrmvoz()

            'If lblestado.Text = "ILOCALIZABLE" Then
            '    objdatos.registrocrmvoz()
            'Else
            '    lblmsg.Text = "Para realizar el registro el caso debe estar ilocalizable"
            '    Exit Sub
            'End If

            buscarinf()
            lblmsg.Text = "Seguimiento ingresado con éxito"
            lblcliente.Text = ""
            lbldocumento.Text = ""
            lblmin.Text = ""
            lblequipo.Text = ""
            lblcaso.Text = ""
            lblobs611.Text = ""
            lblestado.Text = ""
            txtcaso.Text = ""
            txtobs.Text = ""


        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class