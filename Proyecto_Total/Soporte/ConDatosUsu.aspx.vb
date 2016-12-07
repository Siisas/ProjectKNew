Imports System.IO
Public Class ConDatosUsu
    Inherits System.Web.UI.Page
    Dim ObjRRHH As New clsrrhh
    Dim ValidacionExit As Boolean = False
    Dim ValidacionCodigo As Boolean = False
    Dim ValidacionUsuRed As Boolean = False
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                Cargardrl()
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
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Public Sub Cargardrl()
        Try

           
            With DrlPlataformaRed2
                ObjRRHH.Validacion = 5
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
            With DrlPlataformaRed
                ObjRRHH.Validacion = 5
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
            With DrlPlataformaE2
                ObjRRHH.Validacion = 4
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With DrlEstadoP
                ObjRRHH.Validacion = 4
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With DrlPlataforma2
                ObjRRHH.Validacion = 1
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
            With drlPlataforma
                ObjRRHH.Validacion = 1
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
            ObjRRHH.nombres = "CRM"
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

  


    Protected Sub drlPlataforma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlPlataforma.SelectedIndexChanged
        Try
            If drlPlataforma.SelectedItem.Text <> "- Seleccione -" Then
                DrlPlataformaRed.Visible = False
            Else
                DrlPlataformaRed.Visible = True
            End If
            ObjRRHH.Plataforma = drlPlataforma.SelectedItem.Text
            With DrlEstadoP
                ObjRRHH.Validacion = 4
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Protected Sub DrlPlataformaRed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrlPlataformaRed.SelectedIndexChanged
        Try
            If DrlPlataformaRed.SelectedItem.Text <> "- Seleccione -" Then
                drlPlataforma.Visible = False
                With DrlEstadoP
                    ObjRRHH.Validacion = 6
                    .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
            Else
                drlPlataforma.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultaGeneral_Click(sender As Object, e As EventArgs) Handles BtnConsultaGeneral.Click
        Try
          
            If TxtConsultaCodigo.Text = "" And DrlPlataforma2.SelectedItem.Text = "- Seleccione -" And DrlPlataformaRed2.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un filtro de consulta"
                Exit Sub
            End If
            If (DrlPlataformaRed2.SelectedItem.Text <> "- Seleccione -" Or DrlPlataforma2.SelectedItem.Text <> "- Seleccione -") And DrlPlataformaE2.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un estado para la plataforma"
                Exit Sub
            End If

            If TxtConsultaCodigo.Text <> "" Then
                ObjRRHH.codigo = TxtConsultaCodigo.Text
                ObjRRHH.Validacion = "7"
                DtgCredenciales.DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                If ObjRRHH.cantidad = 0 Then
                    lblmsg.Text = "No existen registros con este filtro"
                    DtgCredenciales.DataSource = Nothing
                    DtgCredenciales.DataBind()
                    lblcuentaCredenciales.Text = ""


                Else
                    lblmsg.Text = ""
                    DtgCredenciales.DataBind()
                    lblcuentaCredenciales.Text = ObjRRHH.cantidad
                End If

            ElseIf DrlPlataforma2.SelectedItem.Text <> "- Seleccione -" Then
                ObjRRHH.Plataforma = DrlPlataforma2.SelectedValue
                ObjRRHH.Estado_Plataforma = DrlPlataformaE2.SelectedItem.Text
                ObjRRHH.Validacion = "8"

                DtgCredenciales.DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                If ObjRRHH.cantidad = 0 Then
                    lblmsg.Text = "No existen registros con este filtro"
                    DtgCredenciales.DataSource = Nothing
                    DtgCredenciales.DataBind()
                    lblcuentaCredenciales.Text = ""
                Else
                    DtgCredenciales.DataBind()
                    lblmsg.Text = ""
                    lblcuentaCredenciales.Text = ObjRRHH.cantidad
                End If
            ElseIf DrlPlataformaRed2.SelectedItem.Text <> "- Seleccione -" Then
                ObjRRHH.Plataforma = DrlPlataformaRed2.SelectedValue
                ObjRRHH.Estado_Plataforma = DrlPlataformaE2.SelectedItem.Text
                ObjRRHH.Validacion = "8"
                DtgCredenciales.DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                If ObjRRHH.cantidad = 0 Then
                    lblmsg.Text = "No existen registros con este filtro"
                    DtgCredenciales.DataSource = Nothing
                    DtgCredenciales.DataBind()
                    lblcuentaCredenciales.Text = ""
                Else
                    DtgCredenciales.DataBind()
                    lblmsg.Text = ""
                    lblcuentaCredenciales.Text = ObjRRHH.cantidad
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub DrlPlataforma2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrlPlataforma2.SelectedIndexChanged
        Try
            If DrlPlataforma2.SelectedItem.Text <> "- Seleccione -" Then
                DrlPlataformaRed2.Visible = False
            Else
                DrlPlataformaRed2.Visible = True
            End If
            ObjRRHH.Plataforma = DrlPlataforma2.SelectedItem.Text
            With DrlPlataformaE2
                ObjRRHH.Validacion = 4
                .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                .DataTextField = "Nombre"
                .DataValueField = "cod_estado_usu"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub DrlPlataformaRed2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DrlPlataformaRed2.SelectedIndexChanged
        Try
            If DrlPlataformaRed2.SelectedItem.Text <> "- Seleccione -" Then
                DrlPlataforma2.Visible = False
                With DrlPlataformaE2
                    ObjRRHH.Validacion = 6
                    .DataSource = ObjRRHH.Consulta_Estados_Usu_Pass
                    .DataTextField = "Nombre"
                    .DataValueField = "cod_estado_usu"
                    .DataBind()
                End With
            Else
                DrlPlataforma2.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False

        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function
    Protected Sub DtgCredenciales_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles DtgCredenciales.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ACTIVO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#B3C556")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If

                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ACTIVO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#B3C556")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "ELIMINADO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#81BEF7")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "INACTIVADO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#81BEF7")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. CREAR" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F78181")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. ELIMINAR" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F78181")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "PDT. HABILITAR" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F78181")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
                If DataBinder.Eval(e.Row.DataItem, "Estado_plataforma") = "HABILITANDO" Then
                    e.Row.Cells(2).BackColor = Drawing.Color.FromName("#F2F5A9")
                    e.Row.Cells(2).ForeColor = Drawing.Color.Black
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub


    Protected Sub DtgCredenciales_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles DtgCredenciales.RowCommand

        Try

            If e.CommandName = "Seleccion" Then
                'DtgCredenciales_RowDataBound(1, Nothing)
                drlPlataforma.Visible = True
                drlPlataforma.Enabled = True
                DrlPlataformaRed.Visible = True
                DrlPlataformaRed.Enabled = True
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                ObjRRHH.Codigo_Atuliza = DtgCredenciales.Rows(index).Cells(0).Text
                ObjRRHH.Validacion = 9
                If ObjRRHH.Consulta_Estados_Usu_Pass().Tables(0).Rows.Count > 0 Then
                    TxtArea.Text = ObjRRHH.area
                    TxtCedula.Text = ObjRRHH.documento
                    TxtCodigo.Text = ObjRRHH.codigo
                    TxtEstado.Text = ObjRRHH.estado
                    TxtGrupo.Text = ObjRRHH.grupo
                    TxtNombre.Text = ObjRRHH.nombres
                    If ObjRRHH.apellidos = "Credenciales" Then
                        drlPlataforma.SelectedValue = ObjRRHH.Plataforma
                        drlPlataforma_SelectedIndexChanged(1, Nothing)
                        drlPlataforma.Enabled = False
                    ElseIf ObjRRHH.apellidos = "Plataforma_Red" Then
                        DrlPlataformaRed.SelectedValue = ObjRRHH.Plataforma
                        DrlPlataformaRed.Enabled = False
                        DrlPlataformaRed_SelectedIndexChanged(1, Nothing)
                    End If
                    DrlEstadoP.SelectedValue = ObjRRHH.Estado_Plataforma
                    TxtCod_Asignacion.Text = ObjRRHH.Codigo_Atuliza
                    DtgCredenciales.DataSource = Nothing
                    DtgCredenciales.DataBind()
                    lblcuentaCredenciales.Text = ""
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Public Sub Limpiar_herramientas()

        TxtArea.Text = ""
        TxtCedula.Text = ""
        TxtCodigo.Text = ""
        TxtEstado.Text = ""
        TxtGrupo.Text = ""
        TxtNombre.Text = ""
        Cargardrl()
        TxtCod_Asignacion.Text = ""
        drlPlataforma.Visible = True
        DrlPlataformaRed.Visible = True
        drlPlataforma.Enabled = True
        DrlPlataformaRed.Enabled = True
    End Sub


    Protected Sub BtnActualizacion_Click(sender As Object, e As EventArgs) Handles BtnActualizacion.Click
        Try
            If TxtCodigo.Text = "" Then
                lblmsg.Text = "Ingrese el codigo del usuario y  consultelo"
                Exit Sub
            End If
            If TxtCod_Asignacion.Text = "" Then
                lblmsg.Text = "Realice un filtro de consulta y seleccione un plataforma"
                Exit Sub
            End If
            If DrlEstadoP.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un estado para la plataforma"
                Exit Sub
            End If
            ObjRRHH.Codigo_Atuliza = TxtCod_Asignacion.Text
            ObjRRHH.Estado_Plataforma = DrlEstadoP.SelectedItem.Text
            If drlPlataforma.SelectedItem.Text = "- Seleccione -" Then
                ObjRRHH.Plataforma = DrlPlataformaRed.SelectedValue
            ElseIf DrlPlataformaRed.SelectedItem.Text = "- Seleccione -" Then
                ObjRRHH.Plataforma = drlPlataforma.SelectedValue
            End If
            ObjRRHH.idusuario = lblusuario.Text
            ObjRRHH.codigo = TxtCodigo.Text
            ObjRRHH.Validacion = 1
            ObjRRHH.Actualizar_Plataforma2()
            lblmsg.Text = "La plataforma ha sido actualizada"
            Limpiar_herramientas()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
End Class