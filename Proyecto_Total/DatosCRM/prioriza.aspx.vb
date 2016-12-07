Public Class prioriza
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

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscrmdatos
        Try
            If lblcaso.Text = "" Then
                lblmsg.Text = "Digite el caso que desea registrar y de clic en Buscar, antes de guardar"
                Exit Sub
            Else
                objdatos.caso = lblcaso.Text
            End If
            If txtnumalt.Text = "" Then
                objdatos.telalt = ""
            Else
                objdatos.telalt = txtnumalt.Text
            End If
            If txtobs.Text <> "" Then
                objdatos.obs = txtobs.Text
            Else
                objdatos.obs = ""
            End If
            objdatos.mesa = lblmesa.Text
            objdatos.idusuario = lblusuario.Text
            objdatos.regpriorizacion()
            buscarinf()
            lblmsg.Text = "Solicitud registrada con éxito, en próximos minutos estaremos priorizando el contacto"
            lblcliente.Text = ""
            lbldocumento.Text = ""
            lblmin.Text = ""
            lblplan.Text = ""
            lblequipo.Text = ""
            lbllugar.Text = ""
            lblemail.Text = ""
            lblcaso.Text = ""
            lblobs611.Text = ""
            lblestado.Text = ""
            txtcaso.Text = ""
            txtobs.Text = ""
            txtnumalt.Text = ""
            lblmesa.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso que desea consultar"
            Else
                objdatos.caso = txtcaso.Text
                objdatos.consultacaso()
                If objdatos.cantidad > 0 Then
                    lblcliente.Text = objdatos.cliente
                    lbldocumento.Text = objdatos.documento
                    lblmin.Text = objdatos.min
                    lblplan.Text = objdatos.plan
                    lblequipo.Text = objdatos.equipo
                    lbllugar.Text = objdatos.lugar
                    lblemail.Text = objdatos.email
                    lblcaso.Text = objdatos.caso
                    lblobs611.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    lblmesa.Text = "Datos"
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                    objdatos.consultaprioridad()
                    If objdatos.cantidad > 0 Then
                        lblmsg.Text = "El caso ya fue reportado anteriormente para priorizar, nos encontramos atendiendo la solicitud"
                        btnguardar.Enabled = False
                    Else
                        lblmsg.Text = ""
                        btnguardar.Enabled = True
                    End If
                Else
                    'si no está en datos busca en voz
                    Dim objconsultavoz As New clsvoz
                    objconsultavoz.caso = txtcaso.Text
                    objconsultavoz.consultacasovoz()
                    If objconsultavoz.cantidad > 0 Then
                        lblcliente.Text = objconsultavoz.cliente
                        lbldocumento.Text = objconsultavoz.documento
                        lblmin.Text = objconsultavoz.min
                        lblplan.Text = ""
                        lblequipo.Text = objconsultavoz.equipo
                        lbllugar.Text = ""
                        lblemail.Text = ""
                        lblcaso.Text = objconsultavoz.caso
                        lblobs611.Text = objconsultavoz.obsini
                        lblestado.Text = objconsultavoz.tipificacion
                        lblmesa.Text = objconsultavoz.mesa
                        lblmsg.Text = ""
                        btnguardar.Enabled = True
                    Else
                        lblcliente.Text = ""
                        lbldocumento.Text = ""
                        lblmin.Text = ""
                        lblplan.Text = ""
                        lblequipo.Text = ""
                        lbllugar.Text = ""
                        lblemail.Text = ""
                        lblcaso.Text = ""
                        lblobs611.Text = ""
                        lblestado.Text = ""
                        lblmesa.Text = ""
                        lblmsg.Text = "No se han encontrado registros coincidentes almacenados en la mesa de Soporte de Datos de Smartphone o soporte de Voz. Revise si se ha escrito de manera correcta o si este pertenece a otra mesa de soporte"
                        btnguardar.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
    End Sub
End Class