Imports System.IO

Public Class UbicacionModulo
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
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub cargadrl()
        Try
            Dim ObjModulo As New clsInventario
            With drlTipoHorario
                ObjModulo.Validacion = 1
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With DrlUsuario
                ObjModulo.Validacion = 2
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "nombreu"
                .DataValueField = "Codigo"
                .DataBind()
            End With
            With DrlModulos
                ObjModulo.Validacion = 3
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            With DrlModuloLib
                ObjModulo.Validacion = 5
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "Fk_Modulo"
                .DataValueField = "Fk_Modulo"
                .DataBind()
            End With
            With DrlTurnoLib
                ObjModulo.Validacion = 3
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            With DrlUsuarioLib
                ObjModulo.Validacion = 3
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            With DrlModuloConsulta
                ObjModulo.Validacion = 2
                .DataSource = ObjModulo.Consulta_Modulo1
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
            With DrlTurnoConsulta
                ObjModulo.Validacion = 1
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With DrlUsuarioConsulta
                ObjModulo.Validacion = 1
                .DataSource = ObjModulo.Consulta_Modulo1
                .DataTextField = "nombreu"
                .DataValueField = "Codigo"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub drlTipoHorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlTipoHorario.SelectedIndexChanged
        Try
            Dim ObjModulo As New clsInventario
            ObjModulo.Turno = drlTipoHorario.SelectedItem.Text
            With DrlModulos
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "ID_Modulo"
                .DataValueField = "ID_Modulo"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub BtnAsignar_Click(sender As Object, e As EventArgs) Handles BtnAsignar.Click
        Try
            If drlTipoHorario.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un turno de trabajo para asignar"
                Exit Sub
            End If
            If DrlModulos.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el modulo que asignara"
                Exit Sub
            End If
            If DrlUsuario.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el usuario que asignara al modulo"
                Exit Sub
            End If
            Dim ObjModulo As New clsInventario
            ObjModulo.Fk_ID_Modulo = DrlModulos.SelectedItem.Text
            ObjModulo.Cod_Agente = DrlUsuario.SelectedValue
            ObjModulo.Turno = drlTipoHorario.SelectedItem.Text
            ObjModulo.Id_Usuario = lblusuario.Text
            ObjModulo.AsignarModulo()
            lblmsg.Text = "Asignacion realizada con exito"
            cargadrl()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub DrlModuloLib_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrlModuloLib.SelectedIndexChanged
        Try
            Dim ObjModulo As New clsInventario
            With DrlTurnoLib
                ObjModulo.Fk_ID_Modulo = DrlModuloLib.SelectedItem.Text
                ObjModulo.Validacion = 6
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "TURNO"
                .DataValueField = "TURNO"
                .DataBind()
            End With
            DrlTurnoLib_SelectedIndexChanged(1, Nothing)
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub DrlTurnoLib_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrlTurnoLib.SelectedIndexChanged
        Try
            Dim ObjModulo As New clsInventario
            ObjModulo.Fk_ID_Modulo = DrlModuloLib.SelectedItem.Text
            ObjModulo.Turno = DrlTurnoLib.SelectedItem.Text
            With DrlUsuarioLib
                ObjModulo.Validacion = 7
                .DataSource = ObjModulo.Consulta_Modulo
                .DataTextField = "Nombre"
                .DataValueField = "fk_codigo"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub limpiarHerramientas()
        Try
            txtObservacion.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Try
            If DrlModuloLib.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el modulo para realizar la liberacion"
                Exit Sub
            End If
            If DrlTurnoLib.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el turno para realizar la liberacion"
                Exit Sub
            End If
            If DrlUsuarioLib.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el usuario para realizar la liberacion"
                Exit Sub
            End If
            If txtObservacion.Text = "" Then
                lblmsg.Text = "Ingrese una observacion de la liberacion"
                Exit Sub
            End If
            Dim ObjModulo As New clsInventario
            ObjModulo.Fk_ID_Modulo = DrlModuloLib.SelectedItem.Text
            ObjModulo.Cod_Agente = DrlUsuarioLib.SelectedValue
            ObjModulo.Turno = DrlTurnoLib.SelectedItem.Text
            ObjModulo.Id_Usuario = lblusuario.Text
            ObjModulo.Observacion = txtObservacion.Text
            ObjModulo.ActualizaModulo()
            lblmsg.Text = "Liberacion realizada con exito"
            cargadrl()
            limpiarHerramientas()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnCosnultar_Click(sender As Object, e As EventArgs) Handles BtnCosnultar.Click
        Try
            Dim ObjModulo As New clsInventario
            If DrlTurnoConsulta.SelectedItem.Text = "- Seleccione -" And DrlUsuarioConsulta.SelectedItem.Text = "- Seleccione -" And DrlModuloConsulta.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un filtro de consulta"
                Exit Sub
            End If
            If DrlTurnoConsulta.SelectedItem.Text <> "- Seleccione -" Then
                ObjModulo.Turno = DrlTurnoConsulta.SelectedItem.Text
            End If
            If DrlUsuarioConsulta.SelectedItem.Text <> "- Seleccione -" Then
                ObjModulo.Id_Usuario = DrlUsuarioConsulta.SelectedValue
            End If
            If DrlModuloConsulta.SelectedItem.Text <> "- Seleccione -" Then
                ObjModulo.ID_Modulo = DrlModuloConsulta.SelectedItem.Text
            End If
            Dim DtConsulta As DataSet
            Dim DtConsulta1 As DataSet
            DtConsulta = ObjModulo.Consulta_Modulo1()
            If DtConsulta.Tables(0).Rows.Count > 0 Then
                lblmsg.Text = ""
                dtggeneral.DataSource = DtConsulta
                dtggeneral.DataBind()
                lblcuenta.Text = ObjModulo.Cantidad
            Else
                dtggeneral.DataSource = Nothing
                dtggeneral.DataBind()
                lblcuenta.Text = ObjModulo.Cantidad
            End If
            If CbHistorial.Checked = True Then
                ObjModulo.Validacion = 1
                DtConsulta1 = ObjModulo.Consulta_Modulo1()
                If DtConsulta1.Tables(0).Rows.Count > 0 Then
                    dtggeneral1.DataSource = ObjModulo.Consulta_Modulo1()
                    dtggeneral1.DataBind()
                    LblCantidad2.Text = ObjModulo.Cantidad
                    lblmsg.Text = ""
                Else
                    dtggeneral1.DataSource = Nothing
                    dtggeneral1.DataBind()
                    LblCantidad2.Text = "0"
                End If
            Else
                dtggeneral1.DataSource = Nothing
                dtggeneral1.DataBind()
                LblCantidad2.Text = "0"
            End If
            If LblCantidad2.Text = "0" And lblcuenta.Text = "0" Then
                lblmsg.Text = "No existen registros con este filtro"
            End If


        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub Btnxls_Click(sender As Object, e As EventArgs) Handles Btnxls.Click
        Try

            If lblcuenta.Text <> "0" Or LblCantidad2.Text <> "0" Then
                Dim sb As New StringBuilder
                Dim sw As New StringWriter(sb)
                Dim htw As New HtmlTextWriter(sw)
                Dim pagina As Page = New Page
                Dim form = New HtmlForm
                Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
                pagina.EnableEventValidation = False
                pagina.DesignerInitialize()
                pagina.Controls.Add(form)
                If dtggeneral.Visible = True Then
                    form.Controls.Add(dtggeneral)
                End If
                If dtggeneral1.Visible = True Then
                    form.Controls.Add(dtggeneral1)
                End If
                pagina.RenderControl(htw)
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.AddHeader("Content-Disposition", "attachment;filename=Control Malla Mesas Soporte.xls")
                Response.Charset = "UTF-8"
                Response.Write(strStyle)
                Response.Write(sb.ToString())
                Response.End()
            Else
                lblmsg.Text = "Realice un filtro de busqueda y consulte"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnVerTodos_Click(sender As Object, e As EventArgs) Handles BtnVerTodos.Click
        Try
            lblmsg.Text = ""
            Dim ObjModulo As New clsInventario
            ObjModulo.Validacion = "3"
            dtggeneral.DataSource = ObjModulo.Consulta_Modulo1()
            dtggeneral.DataBind()
            dtggeneral1.DataSource = Nothing
            dtggeneral1.DataBind()
            lblcuenta.Text = ObjModulo.Cantidad
            LblCantidad2.Text = "0"
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
End Class