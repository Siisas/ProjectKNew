Imports System.IO
Public Class Revisionmodulo
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

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click, CompareValidator1.DataBinding
        Try
            Dim Objrevicion As New clsvoz
            If txtcaso.Text = Nothing Then
                lblmsg.Text = "Ingrese un caso para la consulta"
                lblmin.Text = ""
                lblcaso.Text = ""
                lblcliente.Text = ""
                lbldocumento.Text = ""
                lblequipo.Text = ""
                lblplan.Text = ""
                lblestado.Text = ""
                lblobs611.Text = ""
            Else
                Objrevicion.caso = txtcaso.Text
                Objrevicion.Consultacasos_Datos_Voz()

                lblcliente.Text = Objrevicion.cliente
                lbldocumento.Text = Objrevicion.documento
                lblmin.Text = Objrevicion.min
                lblplan.Text = Objrevicion.plan
                lblequipo.Text = Objrevicion.equipo
                lblcaso.Text = Objrevicion.caso
                lblobs611.Text = Objrevicion.obsini
                lblestado.Text = Objrevicion.estadoinc
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            Dim Objrevicion As New clsvoz
            If lblcaso.Text = Nothing Then
                lblmsg.Text = "Realizar la consulta primero"
                Exit Sub
            End If
            If drlEstado.Text = "- Seleccione -" Then
                lblmsg.Text = "Ingrese un estado para guardar"
                Exit Sub
            End If
            If chkRevision.Checked = False Then
                lblmsg.Text = "Es necesario dar revisión"
                Exit Sub
            End If
            Objrevicion.idusuario = lblusuario.Text
            Objrevicion.caso = lblcaso.Text
            Objrevicion.estadoinc = drlEstado.Text
            Objrevicion.Ingresar_Datos_Voz()
            txtcaso.Text = ""
            lblmin.Text = ""
            lblcaso.Text = ""
            lblcliente.Text = ""
            lbldocumento.Text = ""
            lblequipo.Text = ""
            lblplan.Text = ""
            lblestado.Text = ""
            lblobs611.Text = ""
            drlEstado.Text = "- Seleccione -"
            chkRevision.Checked = False
            lblmsg.Text = "Se guardo la revisión con exito"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class