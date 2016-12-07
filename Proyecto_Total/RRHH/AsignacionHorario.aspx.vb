Public Class AsignacionHorario
    Inherits System.Web.UI.Page
    Dim ObjAdmin As New clsrrhh
    Dim Fecha As DateTime = Now
    Dim table As New DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos del usuario'
        Try
            lblmsg.Text = ""
            lblmsgg.Text = ""
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
                objdatos.idusuario = lblusuario.Text
                objdatos.consultacod()
                lblcod.Text = objdatos.cargo
                Cargar_Drl()
                ''''' INICIO SEGURIDAD ACCESO URL '''''
                Dim objGeneral As New clsgeneral
                objGeneral.DtsSeguridad = Session("dtsSeguridad")
                objGeneral.Consulta_Proyecto_Seguridad()
                objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
                objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
                objGeneral.PermisosUrl()
                ''''' FIN SEGURIDAD ACCESO URL '''''
                Detalle()
                Session("LISTA") = table
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Private Sub Detalle()
        table.Columns.Add(New DataColumn("Codigo", GetType(String)))
        table.Columns.Add(New DataColumn("Nombre", GetType(String)))
        table.Columns.Add(New DataColumn("Grupo", GetType(String)))
    End Sub
    Protected Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtCod_Agente.Text <> "" And TxtCod_Agente.Text <> " " And LblNombre.Text <> "" Then
            Dim table As DataTable
            Dim Val As Boolean = False
            table = Session("LISTA")
            For Each row As GridViewRow In Dtg_Agentes.Rows
                If row.Cells(0).Text = TxtCod_Agente.Text Then
                    Val = True
                End If
            Next
            If Val = False Then
                table.Rows.Add(TxtCod_Agente.Text, LblNombre.Text, LblGrupo.Text)
                table.AcceptChanges()
                Session("LISTA") = table
                Dtg_Agentes.DataSource = table
                Dtg_Agentes.DataBind()
                Pnl_Dtg_Agentes.Visible = True
            Else
                lblmsg.Text = "El Agente que selecciono ya fue agregado antes!!"
                Exit Sub
            End If
        ElseIf drlPersonalACargo.Text <> "- Seleccione -" And drlPersonalACargo.Text <> "" Then
            ObjAdmin.Jefe_Inmediato = drlPersonalACargo.Text
            table = ObjAdmin.Consulta_Personal_A_Cargo()
            table.AcceptChanges()
            Session("LISTA") = table
            Dtg_Agentes.DataSource = table
            Dtg_Agentes.DataBind()
            Pnl_Dtg_Agentes.Visible = True
        Else
            lblmsg.Text = "Seleccione un Agente para agregar"
        End If
        Lbl_Cantidad.Text = Dtg_Agentes.Rows.Count
        TxtCod_Agente.Text = ""
        LblNombre.Text = ""
        LblGrupo.Text = ""
        TxtCod_Agente.Enabled = True
        BtnValidar.Visible = True
        BtnCancelar.Visible = False
    End Sub
    Protected Sub Dtg_Agentes_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Dtg_Agentes.RowCommand
        Dim table As DataTable
        table = Session("LISTA")
        Dim Index As Integer
        Try
            Select Case e.CommandName
                Case "Delete"
                    Index = Convert.ToInt32(e.CommandArgument)
                    table.Rows.RemoveAt(Index)
                    Session("LISTA") = table
                    Dtg_Agentes.DataSource = table
                    Dtg_Agentes.DataBind()
                    Lbl_Cantidad.Text = Dtg_Agentes.Rows.Count
                    If Lbl_Cantidad.Text <= 0 Then
                        Pnl_Dtg_Agentes.Visible = False
                    End If
            End Select
        Catch ex As Exception
            lblmsg.Text = Index & ex.Message
        End Try
    End Sub
    Protected Sub Dtg_Agentes_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles Dtg_Agentes.RowDeleting
        Try
            'lblmsg.Text = "Ingreso"
        Catch ex As Exception
            lblmsg.Text = "Se presento error" + ex.Message
        End Try
    End Sub
    Public Sub Cargar_Drl()
        Try
            With drlPersonalACargo
                .DataSource = ObjAdmin.Consulta_Personal_Cargo
                .DataTextField = "Jefe_Inmediato"
                .DataValueField = "Jefe_Inmediato"
                .DataBind()
                .Items.RemoveAt(0)
                .Items.Insert(0, "- Seleccione -")
            End With
            ObjAdmin.tipocont = "1"
            With drlTipoHorario
                drlTipoHorario.DataSource = ObjAdmin.Consulta_Personal_Cargo
                drlTipoHorario.DataTextField = "Nombre"
                drlTipoHorario.DataValueField = "Cod_Validacion_Horario_Complemento"
                drlTipoHorario.DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Public Sub Validar_Codigo()
        Try
            If TxtCod_Agente.Text = "" Then
                lblmsg.Text = "Ingrese el codigo del agente"
                ValidaIngreso = 2
                Exit Sub
            End If
            ObjAdmin.codigo = TxtCod_Agente.Text
            ObjAdmin.Consulta_Personal_AsigHoras()

            If ObjAdmin.cantidad > 0 Then
                LblNombre.Text = ObjAdmin.nombres & " " & ObjAdmin.apellidos
                LblGrupo.Text = ObjAdmin.cargo
                TxtCod_Agente.Enabled = False
                BtnValidar.Visible = False
                BtnCancelar.Visible = True
                lblmsg.Text = ""
            Else
                lblmsg.Text = "No hay registros del codigo: " + TxtCod_Agente.Text
                LblNombre.Text = ""
                LblGrupo.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub BtnValidar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidar.Click
        Try
            Validar_Codigo()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Dim ValidaIngreso As Integer = 0
    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGuardar.Click
        Try
            If Dtg_Agentes.Rows.Count < 1 Then
                lblmsg.Text = "Antes de realizar el registro primero agrege un agente"
                Exit Sub
            End If
            If TxtFecha_Ingreso.Text = "" Then
                lblmsg.Text = "Digite una fecha de ingreso para el o los agentes"
                Exit Sub
            End If
            If TxtFecha_Ingreso.Text <= Fecha.Date Then
                lblmsg.Text = "Solo puede realizar registros con fechas iguales o mayores a las de: " + Fecha.Date
                Exit Sub
            End If
            If drlTipoHorario.SelectedItem.Text = "- Seleccione -" Or drlTipoHorario.SelectedItem.Text = "" Then
                lblmsg.Text = "Seleccione un tipo de horario"
                Exit Sub
            End If

            If drlTipoHorario.SelectedItem.Text <> "Laboral" Then

            Else
                If TxtHora_Ingreso.Text = "" Then
                    lblmsg.Text = "Digite una hora de ingreso para el o los agentes"
                    Exit Sub
                End If
                If TxtHora_Salida.Text = "" Then
                    lblmsg.Text = "Digite una hora de salida para el o los agentes"
                    Exit Sub
                Else
                    If (Integer.Parse(TxtHora_Ingreso.Text.Substring(0, 2)) > Integer.Parse(TxtHora_Salida.Text.Substring(0, 2))) Or ((Integer.Parse(TxtHora_Ingreso.Text.Substring(0, 2)) >= Integer.Parse(TxtHora_Salida.Text.Substring(0, 2))) And (Integer.Parse(TxtHora_Ingreso.Text.Substring(3, 2)) > Integer.Parse(TxtHora_Salida.Text.Substring(3, 2)))) Then
                        lblmsg.Text = "Verifique la hora de salida para el o los agentes, ya que tiene que estar en un fromato de 24 horas"
                        Exit Sub
                    End If
                End If
            End If
            If TxtNdias.Text = "" Or TxtNdias.Text = "0" Then
                lblmsg.Text = "Ingrese la cantidad de dias que el o los agente tendran este horario"
                Exit Sub
            End If

            ObjAdmin.idusuario = lblusuario.Text
            Dim dia As Integer
            dia = TxtNdias.Text

            Dim Fecha_Ingreso As Date
            Dim Fecha_Salida As Date
            If drlTipoHorario.SelectedItem.Text <> "Laboral" Then
                Fecha_Ingreso = TxtFecha_Ingreso.Text + " 00:00:00"
                Fecha_Salida = TxtFecha_Ingreso.Text + " 00:00:00"
            Else
                Fecha_Ingreso = TxtFecha_Ingreso.Text + " " + TxtHora_Ingreso.Text
                Fecha_Salida = TxtFecha_Ingreso.Text + " " + TxtHora_Salida.Text
            End If
            Fecha_Ingreso = TxtFecha_Ingreso.Text + " " + TxtHora_Ingreso.Text
            Fecha_Salida = TxtFecha_Ingreso.Text + " " + TxtHora_Salida.Text

            Dim Fecha_Ingreso_Sum As Date
            Dim Fecha_Salida_Sum As Date

            For i = 0 To dia - 1
                Fecha_Ingreso_Sum = Fecha_Ingreso.AddDays(i)
                Fecha_Salida_Sum = Fecha_Salida.AddDays(i)
                For Each Row As GridViewRow In Dtg_Agentes.Rows
                    ObjAdmin.codigo = Row.Cells(0).Text
                    ObjAdmin.fcing = Fecha_Ingreso.Date.AddDays(i)
                    ObjAdmin.fcretiro = Fecha_Ingreso.Date.AddDays(i)
                    ObjAdmin.Aclaracion = "Registro"
                    ObjAdmin.Consulta_ValidaUn_Registro_Horarios()
                    If ObjAdmin.cantidad > 0 Then
                        lblmsg.Text = "Ya existe un horario registrado para el usuario: " + ObjAdmin.codigo + " con la fecha: " + TxtFecha_Ingreso.Text
                        Exit Sub
                    End If
                    ObjAdmin.fcing = Fecha_Ingreso_Sum
                    ObjAdmin.fcretiro = Fecha_Salida_Sum
                    ObjAdmin.tipocont = drlTipoHorario.Text
                    ObjAdmin.Registro_Horario()
                Next
            Next
            lblmsgg.Text = "Asignacion de Horarios Realizados"
            Dtg_Agentes.DataSource = Nothing
            Dtg_Agentes.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCancelar.Click
        Try
            LblNombre.Text = ""
            LblGrupo.Text = ""
            TxtCod_Agente.Text = ""
            TxtCod_Agente.Enabled = True
            BtnValidar.Visible = True
            BtnCancelar.Visible = False
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Protected Sub drlTipoHorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drlTipoHorario.SelectedIndexChanged
        If drlTipoHorario.SelectedItem.Text <> "Laboral" Then
            TxtHora_Ingreso.Text = ""
            TxtHora_Ingreso.Enabled = False
            TxtHora_Salida.Text = ""
            TxtHora_Salida.Enabled = False
        Else
            TxtHora_Ingreso.Enabled = True
            TxtHora_Salida.Enabled = True
        End If
    End Sub
End Class