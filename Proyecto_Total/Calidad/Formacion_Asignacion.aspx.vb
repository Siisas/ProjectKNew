Imports System.Web.Services.Description
Imports System.Net.Mail
Imports System.Net
Imports System.Net.Mime
Imports System.IO
Imports System.Web
Imports System.Data.SqlClient
Imports System.Data
Imports System.Text
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class Formacion_Asignacion

    Inherits System.Web.UI.Page
    Dim ObjFormacion As New clsFormacion
    Dim table As New DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario  ' obtengo los datos del usuario logueado
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv

                cargar_drl() 'llamo el metodo cargar drl - para cargar las listas desplegables
                Btn_buscar_todos_Click(1, Nothing)
                Detalle()
                Session("LISTA") = table
            End If
            ''''' INICIO SEGURIDAD ACCESO URL '''''
            Dim objGeneral As New clsgeneral
            objGeneral.DtsSeguridad = Session("dtsSeguridad")
            objGeneral.Consulta_Proyecto_Seguridad()
            objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
            objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
            objGeneral.PermisosUrl()
            ''''' FIN SEGURIDAD ACCESO URL '''''  
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(control As UI.Control)
        ' MyBase.VerifyRenderingInServerForm(control)
    End Sub

    Sub cargar_drl()
        With Drl_Prioridad
            ObjFormacion.validacion = "4"
            .DataSource = ObjFormacion.cargar_drl
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_Auditor_Asignar
            .DataSource = ObjFormacion.Consulta_Usuario()
            .DataTextField = "nombreu"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_Formador_Consulta
            .DataSource = ObjFormacion.Consulta_Usuario()
            .DataTextField = "nombreu"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_Lugar
            ObjFormacion.validacion = "6"
            .DataSource = ObjFormacion.cargar_drl
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
        With Drl_Estado
            ObjFormacion.validacion = "5"
            .DataSource = ObjFormacion.cargar_drl
            .DataTextField = "Nombre"
            .DataValueField = "Nombre"
            .DataBind()
        End With
    End Sub

    Protected Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        Try
            If txtcaso.Text <> "" And Drl_Prioridad.SelectedValue = "- Seleccione -" And Txt_fc_inicio.Text <> "" And Txt_fc_fin.Text <> "" And CheckBox_casos.Checked = False And Drl_Formador_Consulta.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Ingrese minimo un filtro para realizar la consulta"
                Exit Sub
            End If
            If txtcaso.Text <> "" Then
                ObjFormacion.id = txtcaso.Text
            Else
                If CheckBox_casos.Checked = True Then
                    ObjFormacion.Usuario = lblusuario.Text
                Else
                    If Drl_Estado.SelectedValue <> "- Seleccione -" Then
                        ObjFormacion.observacion = Drl_Estado.SelectedValue
                    End If
                    If Drl_Prioridad.SelectedValue <> "- Seleccione -" Then
                        ObjFormacion.prioridad = Drl_Prioridad.SelectedValue
                    End If
                    If Txt_fc_inicio.Text <> "" And Txt_fc_fin.Text <> "" Then
                        If Date.Parse(ObjFormacion.Fecha_Actual) > Date.Parse(Txt_fc_fin.Text) Then
                            lblmsg.Text = "Verifique el rango de fechas ya que la fecha inicio no puede ser mayor a la fecha fin"
                            Exit Sub
                        End If
                    End If
                    If Txt_fc_inicio.Text <> "" Then
                        ObjFormacion.fecha = Txt_fc_inicio.Text
                    End If
                    If Txt_fc_fin.Text <> "" Then
                        ObjFormacion.fecha2 = Txt_fc_fin.Text
                    End If
                End If
                End If
            ObjFormacion.validacion = "Filtros"
            Session("dtsB") = ObjFormacion.consultas()
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
            lblcuenta.Text = ObjFormacion.area
            If dtggeneral.Rows.Count > 0 Then
                Pnl_cabecera_2.Visible = True
            Else
                Pnl_cabecera_2.Visible = False
            End If
            lblmsg.Text = ""
            If ObjFormacion.validacion = "1" Then
                lblmsg.Text = "No se encontraron Registros"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_buscar_todos_Click(sender As Object, e As EventArgs) Handles Btn_buscar_todos.Click
        Try
            ObjFormacion.validacion = "Buscar_Todos2"
            Session("dtsB") = ObjFormacion.consultas()
            dtggeneral.DataSource = Session("dtsB")
            dtggeneral.DataBind()
            lblcuenta.Text = ObjFormacion.area
            dtg_seguim.DataSource = Nothing
            dtg_seguim.DataBind()
            Pnl_cabecera_1.Visible = False
            If dtggeneral.Rows.Count > 0 Then
                Pnl_cabecera_2.Visible = True
            Else
                Pnl_cabecera_2.Visible = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles dtggeneral.RowCommand
        Try
            'Mediante este codigo envio la identificacion del aspirante, indicanto el Rows(Fila) y Cells(Celda)
            If e.CommandName = "Seleccion" Then
                dtggeneral.Visible = True
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                'aqui selecciono la columna y la muestro en una herramienta
                Dim x As String
                Lbl_Nombre_Solicita.Text = dtggeneral.Rows(index).Cells(2).Text
                Txt_id_cargue.Text = dtggeneral.Rows(index).Cells(0).Text
                x = dtggeneral.Rows(index).Cells(10).Text
                If x = "Operaci&#243;n" Then
                    Drl_Lugar.SelectedValue = "Operación"
                Else
                    Drl_Lugar.SelectedValue = x
                End If
                txtfcingn3.Text = dtggeneral.Rows(index).Cells(4).Text
                Txt_estado.Text = dtggeneral.Rows(index).Cells(9).Text
                Txt_npersonas.Text = dtggeneral.Rows(index).Cells(11).Text
                lbl_N_personas2.Text = dtggeneral.Rows(index).Cells(11).Text
                Lbl_N_Personas.Text = Txt_npersonas.Text
                Btn_guardar_N_Personas.Visible = True
                Btn_Agregar.Visible = True
                lblmsg.Text = ""
                ObjFormacion.id = Txt_id_cargue.Text
                ObjFormacion.validacion = "Respuesta_Asignacion"
                dtg_seguim.DataSource = ObjFormacion.consultas()
                dtg_seguim.DataBind()
                lblcuenta2.Text = ObjFormacion.area
                If dtg_seguim.Rows.Count > 0 Then
                    Pnl_cabecera_1.Visible = True
                Else
                    Pnl_cabecera_1.Visible = False
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub btn_crear_Click(sender As Object, e As ImageClickEventArgs) Handles btn_crear.Click
        Try
            If Txt_estado.Text = "Cerrado" Then
                lblmsg.Text = "Este caso ya se encuentra cerrado por lo tanto no se puede asignar"
                Exit Sub
            End If
            If Txt_id_cargue.Text = "" Then
                lblmsg.Text = "Seleccione la formacion a Asignar"
                Exit Sub
            End If
            If Drl_Lugar.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un lugar"
                Exit Sub
            End If
            If txtfcingn3.Text = "" Then
                lblmsg.Text = "Seleccione una fecha"
                Exit Sub
            End If
            If Date.Parse(Date.Now.ToString("dd/MM/yyyy")) > Date.Parse(txtfcingn3.Text) Then
                lblmsg.Text = "La fecha para la ejecucion no puede ser anterior a la actual"
                Exit Sub
            End If
            If Txt_Observacion.Text = "" Then
                lblmsg.Text = "Digite una Observacion"
                Exit Sub
            End If
            ObjFormacion.Usuario = lblusuario.Text
            'Dim cadena As String
            'cadena = Txt_Grupos.Text
            'cadena = Regex.Replace(cadena, "[<br/>]", "")  'este codigo se utiliza para encontrar un caracter en una cadena y eliminarlo
            'cadena = Regex.Replace(cadena, "[➤\→]", "--") 'este codigo se utiliza para encontrar un caracter en una cadena y eliminarlo
            'If Txt_Grupos.Text <> "" Then
            '    ObjFormacion.Numero_Personas = cadena
            'Else
            '    ObjFormacion.Numero_Personas = "0"
            'End If
            ObjFormacion.tema = Drl_Auditor_Asignar.SelectedValue
            ObjFormacion.observacion = Txt_Observacion.Text
            ObjFormacion.id = Txt_id_cargue.Text
            ObjFormacion.prioridad = Drl_Lugar.SelectedValue
            ObjFormacion.fecha = txtfcingn3.Text & " "

            If Lbl_N_Personas.Text <> "0" Then
                lblmsg.Text = "Aun tiene personas por asignar a un modulo"
                Exit Sub
            End If

            ObjFormacion.validacion = "Registro_Asignacion"
            ObjFormacion.Ingreso_Solicitud_Formacion()
            ObjFormacion.validacion = "Actualizacion_Estado"
            ObjFormacion.Ingreso_Solicitud_Formacion()

            ObjFormacion.validacion = "Insertar Formacion"
            For Each row As GridViewRow In Dtg_Asignar.Rows
                ObjFormacion.id = Int64.Parse(row.Cells(0).Text)
                ObjFormacion.tema = CStr(row.Cells(1).Text)
                ObjFormacion.Lugar = CStr(row.Cells(2).Text)
                ObjFormacion.Numero_Personas = CStr(row.Cells(3).Text)
                ObjFormacion.fecha = DateTime.Parse(row.Cells(4).Text)
                ObjFormacion.Formador = CStr(row.Cells(5).Text)

                ObjFormacion.Actualizacion_Solicitud_Formacion()
            Next
            Dtg_Asignar.Columns(6).Visible = False
            enviar_correo()
            Dtg_Asignar.Columns(6).Visible = True
            lblusuario.Text = ""
            Txt_Observacion.Text = ""
            Txt_id_cargue.Text = ""
            Drl_Lugar.SelectedValue = "- Seleccione -"
            txtfcingn3.Text = ""
            'Txt_Grupos.Text = ""
            Drl_Auditor_Asignar.SelectedValue = "- Seleccione -"
            Txt_estado.Text = ""
            Txt_Fecha_modulo.Text = ""
            'lblmsg.BackColor = System.Drawing.ColorTranslator.FromHtml("#B3C556")
            ObjFormacion.validacion = "Respuesta_Asignacion"
            dtg_seguim.DataSource = ObjFormacion.consultas()
            dtg_seguim.DataBind()
            lblcuenta2.Text = ObjFormacion.area
            If dtg_seguim.Rows.Count > 0 Then
                Pnl_cabecera_1.Visible = True
            Else
                Pnl_cabecera_1.Visible = False
            End If
            lblcuenta2.Text = ""
            'Session("LISTA").clear()
            Dtg_Asignar.DataSource = Nothing
            Dtg_Asignar.DataBind()
            lbl_Contador.Text = "0"
            lblmsg2.Text = ""
            txt_grupo.Text = ""
            txt_modulo.Text = ""
            Txt_Personas_asignar.Text = ""
            Lbl_N_Personas.Text = ""
            Txt_Fecha_modulo.Text = ""
            Drl_Auditor_Asignar.SelectedValue = "- Seleccione -"
            lbl_Contador.Text = ""
            Txt_npersonas.Text = ""
            Btn_guardar_N_Personas.Visible = False
            Btn_buscar_todos_Click(1, Nothing)
            lblmsg.Text = "Asignacion Exitosa"
            ' Btn_Limpiar_Click(1, Nothing)
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Public Sub enviar_correo()
        Try
            Dim Correo As String = "formacion@kamilion.co"
            Dim pass As String = "Kamilion2015*"
            Dim Cr As New clscorreos(Correo, pass)
            Cr.Correo = "formacion@kamilion.co"
            Dim mnsj As New MailMessage()
            Dim oMailMessage As New System.Net.Mail.MailMessage()
            ObjFormacion.validacion = "7"
            ObjFormacion.observacion = Lbl_Nombre_Solicita.Text
            ObjFormacion.cargar_drl()
            Dim html As String = " Buen Dia, " & " <br>" &
                "Reciba un cordial saludo, La siguiente tiene por motivo, dar respuesta a su solicitud al área de formación:  " & " <br><br>" &
                 "<b> Numero Solicitud:  </b> " & Txt_id_cargue.Text & " <br>" &
                "<b> Fecha formacion: </b> " & txtfcingn3.Text & " <br>" &
                "<b> Lugar: </b> " & Drl_Lugar.SelectedValue & " <br>" &
                "<b> Grupos y Modulos: </b> " & " <br>" & GetGridviewData(Dtg_Asignar) &
                " <br><br><br>" &
                "Cordialmente: " & "<br> <br>" &
                "<img src='cid:imagen' />"
            Dim htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html)
            Dim img As New LinkedResource("C:\firma de correo.jpeg", MediaTypeNames.Image.Jpeg)
            img.ContentId = "imagen"
            'Lo incrustamos en la vista HTML...
            htmlView.LinkedResources.Add(img)
            mnsj.Subject = "Solicitud de Formacion" 'Asunto
            mnsj.To.Add(New MailAddress(ObjFormacion.observacion)) 'correo destinado
            mnsj.From = New MailAddress("formacion@kamilion.co", "Formacion Kamilion") 'dan es el nombre de la persona
            '    mnsj.Body = "realizo pruebas de envio de crm a gmail " & vbLf & "" & vbLf & "prueba" & "Pic1" & vbLf & " <img src='cid:imagen' />"
            mnsj.AlternateViews.Add(htmlView)
            'Por último, vinculamos ambas vistas al mensaje...
            Cr.MandarCorreo(mnsj)
        Catch ex As Exception
            lblmsg.Text = "Se presento error: NO SE PUDO ENVIAR EL CORREO ELECTRONICO " & ex.Message
        End Try
    End Sub

    ' This Method is used to render gridview control
    Public Function GetGridviewData(gv As GridView) As String
        Dim strBuilder As New StringBuilder()
        Dim strWriter As New StringWriter(strBuilder)
        Dim htw As New HtmlTextWriter(strWriter)
        gv.RenderControl(htw)
        Return strBuilder.ToString()
    End Function

    Protected Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try
            If lblcuenta.Text = "" Then
                lblmsg.Text = "Realice una consulta y luego exportela "
                Exit Sub
            End If
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim r As New clscalidad
        Dim objdtsconsultaxls As New DataSet
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
        If lblcuenta.Text <> Nothing Then
            If lblcuenta.Text < 20001 Then
                pagina.EnableEventValidation = False
                pagina.DesignerInitialize()
                dtggeneral.ShowHeader = True
                dtggeneral.DataSource = Session("dtsB")
                dtggeneral.DataBind()
                pagina.Controls.Add(form)
                form.Controls.Add(dtggeneral)
                pagina.RenderControl(htw)
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.AddHeader("Content-Disposition", "attachment;filename=Formacion.xls")
                Response.Charset = "UTF-8"
                Response.Write(strStyle)
                Response.Write(sb.ToString())
                Response.End()
            Else
                lblmsg.Text = "No se puede generar archivo en xls, realice un filtro adicional o solicite la consulta al administrador de la base de datos"
            End If
        Else
            lblmsg.Text = "Realice una consulta y luego intente exportarla"
        End If
    End Sub

    'Dim x As String
    'Dim n As Int32
    'Dim n2 As Int32
    'Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Try
    '        n = CInt(lbl_n.Text)
    '        x = "➤ GRUPO " & n
    '        lbl_cad.Text = lbl_cad.Text & vbCrLf & "----------------" & vbCrLf & x & " <br />"
    '        Txt_Grupos.Text = lbl_cad.Text & vbLf
    '        n = n + 1
    '        Button1.Text = "Agregar Grupo " & n
    '        lbl_n.Text = CStr(n)
    '        lbl_n2.Text = "1"
    '    Catch ex As Exception
    '        lblmsg.Text = "Se presento error " & ex.Message
    '    End Try
    'End Sub
    'Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Try
    '        If Txt_Fecha_modulo.Text = "" Then
    '            lblmsg.Text = "Seleccione una Fecha"
    '            Exit Sub
    '        End If
    '        If Txt_Personas_asignar.Text = "" Then
    '            lblmsg.Text = "Seleccione un Numero de personas para este modulo"
    '            Exit Sub
    '        End If
    '        If Date.Parse(Date.Now.ToString("dd/MM/yyyy")) > Date.Parse(Txt_Fecha_modulo.Text) Then
    '            lblmsg.Text = "La fecha para un modulo no puede ser anterior a la actual"
    '            Exit Sub
    '        End If
    '        n2 = CInt(lbl_n2.Text)
    '        x = "Modulo " & n2 & " → " & Txt_Fecha_modulo.Text & " -  N. Personas " & Txt_Personas_asignar.Text & " <br />"
    '        lbl_cad.Text = lbl_cad.Text & vbCrLf & x
    '        Txt_Grupos.Text = lbl_cad.Text & vbLf
    '        n2 = n2 + 1
    '        lbl_n2.Text = CStr(n2)
    '        lbl_N_Personas.Text = CStr(CInt(lbl_N_Personas.Text) - CInt(Txt_Personas_asignar.Text))
    '        lblmsg.Text = " "
    '    Catch ex As Exception
    '        lblmsg.Text = "Se presento error " & ex.Message
    '    End Try
    'End Sub
    'Protected Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
    '    Try
    '        'Txt_Grupos.Text = ""
    '        'lbl_cad.Text = ""
    '        'lbl_n.Text = "1"
    '        'lbl_n2.Text = "1"
    '        Txt_Fecha_modulo.Text = ""
    '        Txt_Personas_asignar.Text = ""
    '        'lbl_N_Personas.Text = lbl_N_personas2.Text
    '    Catch ex As Exception
    '        lblmsg.Text = "Se presento error " & ex.Message
    '    End Try
    'End Sub

    Protected Sub Btn_guardar_N_Personas_Click(sender As Object, e As EventArgs) Handles Btn_guardar_N_Personas.Click
        Try
            If Txt_npersonas.Text = "" Then
                lblmsg.Text = "Digite El nuevo numero de personas a capacitar"
            End If
            ObjFormacion.tema = Txt_npersonas.Text
            ObjFormacion.id = Txt_id_cargue.Text
            ObjFormacion.Actualizacion_Solicitud_Formacion()
            Btn_buscar_todos_Click(1, Nothing)

            If CInt(Txt_npersonas.Text) > (CInt(lbl_N_personas2.Text)) Then
                Dim x As Int16 = (CInt(Txt_npersonas.Text) - CInt(lbl_Contador.Text)) - CInt(Lbl_N_Personas.Text)
                Lbl_N_Personas.Text = x + CInt(Lbl_N_Personas.Text)
            End If
            If CInt(Txt_npersonas.Text) < (CInt(lbl_N_personas2.Text)) Then
                Lbl_N_Personas.Text = Txt_npersonas.Text
                Session("LISTA").clear()
                Dtg_Asignar.DataSource = Nothing
                Dtg_Asignar.DataBind()
                lbl_Contador.Text = "0"
            End If
            lbl_N_personas2.Text = Txt_npersonas.Text
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Try
            If Txt_Personas_asignar.Text = "" Or Txt_Personas_asignar.Text = "0" Then
                lblmsg2.Text = "Seleccione el numero de personas a asignar por favor"
                Exit Sub
            End If

            If CInt(Lbl_N_Personas.Text) = 0 Or (CInt(Lbl_N_Personas.Text) - CInt(Txt_Personas_asignar.Text)) < 0 Then
                lblmsg2.Text = "No hay mas personas para agregar a un modulo"
                Exit Sub
            End If
            If txt_grupo.Text = "" Then
                lblmsg2.Text = "Seleccione un grupo por favor"
                Exit Sub
            End If
            If txt_modulo.Text = "" Then
                lblmsg2.Text = "Seleccione un modulo por favor"
                Exit Sub
            End If

            If Txt_Fecha_modulo.Text = "" Then
                lblmsg2.Text = "Seleccione una fecha para el modulo por favor"
                Exit Sub
            End If
            If Drl_Auditor_Asignar.SelectedValue = "- Seleccione -" Then
                lblmsg2.Text = "Seleccione un Formador por favor"
                Exit Sub
            End If
            For Each row As GridViewRow In Dtg_Asignar.Rows
                If row.Cells(0).Text = txt_grupo.Text Then
                End If
            Next
            Lbl_N_Personas.Text = CStr(CInt(Lbl_N_Personas.Text) - CInt(Txt_Personas_asignar.Text))
            lbl_Contador.Text = CStr(CInt(lbl_Contador.Text) + CInt(Txt_Personas_asignar.Text))
            Dim Val As Boolean = False
            table = Session("LISTA")
            table.Rows.Add(Txt_id_cargue.Text, txt_grupo.Text, txt_modulo.Text, Txt_Personas_asignar.Text, Txt_Fecha_modulo.Text, Drl_Auditor_Asignar.SelectedValue)
            table.AcceptChanges()
            Dtg_Asignar.DataSource = table
            Dtg_Asignar.DataBind()
            lblmsg2.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub Detalle()
        table.Columns.Add(New DataColumn("ID_Formacion", GetType(String)))
        table.Columns.Add(New DataColumn("Grupo", GetType(String)))
        table.Columns.Add(New DataColumn("Modulo", GetType(String)))
        table.Columns.Add(New DataColumn("N_Personas", GetType(String)))
        table.Columns.Add(New DataColumn("Fecha", GetType(String)))
        table.Columns.Add(New DataColumn("Formador", GetType(String)))
    End Sub

    Protected Sub Dtg_Asignar_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Dtg_Asignar.RowCommand
        Dim table As DataTable
        table = Session("LISTA")
        Dim Index As Integer
        Try
            Select Case e.CommandName
                Case "Delete"
                    Lbl_N_Personas.Text = CStr(CStr(Dtg_Asignar.Rows(Index).Cells(3).Text) + CInt(Lbl_N_Personas.Text))
                    Index = Convert.ToInt32(e.CommandArgument)
                    table.Rows.RemoveAt(Index)
                    Session("LISTA") = table
                    Dtg_Asignar.DataSource = table
                    Dtg_Asignar.DataBind()
            End Select
        Catch ex As Exception
            lblmsg.Text = Index & ex.Message
        End Try
    End Sub

    Protected Sub Dtg_Asignar_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles Dtg_Asignar.RowDeleting
        Try
            'lblmsg.Text = "Ingreso"
        Catch ex As Exception
            lblmsg.Text = "Se presento error" + ex.Message
        End Try
    End Sub

    Protected Sub Btn_Buscar_Formador_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Formador.Click
        Try
            ObjFormacion.Formador = Drl_Formador_Consulta.SelectedValue
            ObjFormacion.validacion = "Filtros"
            Dtg_Formador.DataSource = ObjFormacion.consultas()
            Dtg_Formador.DataBind()
            If ObjFormacion.validacion = "1" Then
                Panel1.Visible = False
                Dtg_Formador.DataSource = Nothing
                Dtg_Formador.DataBind()
                lblmsg.Text = "No se encontraron Registros con este Formador"
            Else
                Panel1.Visible = True
            End If
            lblcuenta3.Text = ObjFormacion.area
        Catch ex As Exception
            lblmsg.Text = "Se presento error" + ex.Message
        End Try
    End Sub

  


    Protected Sub Dtg_Formador_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dtg_Formador.RowDataBound
        Try
            If (e.Row.RowType = DataControlRowType.DataRow) Then
                Dim x As Date = DataBinder.Eval(e.Row.DataItem, "Fecha")
                If FormatDateTime(x, DateFormat.ShortDate) = Date.Parse(DateTime.Now.Date) Then
                    e.Row.ForeColor = Drawing.Color.Blue
                End If
                If FormatDateTime(x, DateFormat.ShortDate) > Date.Parse(DateTime.Now.Date) Then
                    e.Row.ForeColor = Drawing.Color.Red
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub




End Class