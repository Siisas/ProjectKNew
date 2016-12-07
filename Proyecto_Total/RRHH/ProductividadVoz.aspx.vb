Imports System.IO

Public Class ProductividadVoz
    Inherits System.Web.UI.Page

    Dim ObjCaidaSistema As New clsCaidaSistema
    Dim FechaActual As String
    Dim FechaTurno As String
    Dim FechaMañana As String
    Dim FechaTarde As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Cargo la fecha actual'
        Try
            FechaActual = ObjCaidaSistema.Fecha_Actual
            FechaTurno = DateTime.Now.ToString("dd/MM/yyyy")
            ObjCaidaSistema.ConsultarMetasHorasMinutos()
            If ((ObjCaidaSistema.Dia = "D") Or (ObjCaidaSistema.Dia = "S")) Then
                FechaMañana = DateTime.Now.ToString("dd/MM/yyyy 08:00:00")
                FechaTarde = DateTime.Now.ToString("dd/MM/yyyy 14:01:00")
            Else
                FechaMañana = DateTime.Now.ToString("dd/MM/yyyy 07:00:00")
                FechaTarde = DateTime.Now.ToString("dd/MM/yyyy 14:01:00")
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

        'Obtengo los datos del usuario'
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblCargo.Text = CType(Session("permisos"), clsusuario).cargo
                With drlGrupo
                    .DataSource = ObjCaidaSistema.ConsultaGrupoVoz
                    .DataValueField = "Cargo"
                    .DataTextField = "Cargo"
                    .DataBind()
                End With
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

    Public Sub ProductividadAgentes()
        If (Vali = 1) Then
            EnvioFechas()
        End If
        If (RdbtnGrupo.Checked = True) Then
            ObjCaidaSistema.Grupo = drlGrupo.Text
        End If
        Try
            If ((LblCargo.Text = "N0_G1") Or (LblCargo.Text = "N0_G3")) Then
                If ((drlGrupo.Text = "Voz_G4") Or (drlGrupo.Text = "Voz_G6")) Then
                    'lblmsg.Text = "Nivel 2"
                    ObjCaidaSistema.Cod_CS = 2
                    dtgConsultasN2.DataSource = ObjCaidaSistema.consultarProductividadAgentesVOZ
                    dtgConsultasN2.DataBind()
                    lblcantgralN2.Text = ObjCaidaSistema.Cantidad
                    dtgConsultasN1.Visible = False
                    lblcantgral.Visible = False
                Else
                    'lblmsg.Text = "Nivel 1"
                    dtgConsultasN1.DataSource = ObjCaidaSistema.consultarProductividadAgentesVOZ
                    dtgConsultasN1.DataBind()
                    lblcantgral.Text = ObjCaidaSistema.Cantidad
                    dtgConsultasN2.Visible = False
                    lblcantgralN2.Visible = False
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Public Sub EnvioFechas()
        'Valido el horario que esta haciendo el agente
        If (FechaActual < FechaTarde) Then
            FechaH = DateDiff("h", FechaMañana, FechaActual)
            FechaM = DateDiff("n", FechaMañana, FechaActual)
            ObjCaidaSistema.Fecha_Turno = FechaTurno & " 07:00:00"
        Else
            FechaH = DateDiff("h", FechaTarde, FechaActual)
            FechaM = DateDiff("n", FechaTarde, FechaActual)
            ObjCaidaSistema.Fecha_Turno = FechaTurno & " 14:00:00"
        End If
        'Valido minutos
        If (FechaM > 59) Then
            FechaM = FechaM Mod 60
        End If
        ObjCaidaSistema.Fecha_Actual = FechaActual
    End Sub
    Dim Tabla As DataSet
    Dim FechaH As Integer
    Dim FechaM As Integer
    Public Sub Productividad()
        EnvioFechas()
        ObjCaidaSistema.Usuario = lblusuario.Text
        If ((LblCargo.Text = "Voz_G1") Or (LblCargo.Text = "Voz_G2") Or (LblCargo.Text = "Voz_G3") Or (LblCargo.Text = "Voz_G5") Or (LblCargo.Text = "Voz_G4") Or (LblCargo.Text = "Voz_G6")) Then
            If ((LblCargo.Text = "Voz_G1") Or (LblCargo.Text = "Voz_G2") Or (LblCargo.Text = "Voz_G3") Or (LblCargo.Text = "Voz_G5")) Then
                ObjCaidaSistema.Cod_CS = 3
                'Consulto la cantidad de Rechazados
                Tabla = ObjCaidaSistema.ProductividadRechazados()
                LblRechazadoCantidad.Text = ObjCaidaSistema.Rechazado
                'Consulto la cantidad de Cerrados
                Tabla = ObjCaidaSistema.ProductividadCerrados()
                LblCerradoCantidad.Text = ObjCaidaSistema.Cerrado
                'Consulto la cantidad de Escalados
                Tabla = ObjCaidaSistema.ProductividadEscalados()
                LblEscaladoCantidad.Text = ObjCaidaSistema.Escalado

                LblAsignado.Visible = False
                LblAsignadoCantidad.Visible = False

                LblTotalDia.Text = ObjCaidaSistema.Rechazado + ObjCaidaSistema.Cerrado + ObjCaidaSistema.Escalado
                If ((LblCargo.Text = "Voz_G1") Or (LblCargo.Text = "Voz_G2")) Then
                    ObjCaidaSistema.Cod_CS = 3
                    ObjCaidaSistema.ConsultarMetasHorasMinutos()

                    FechaM = FechaM / ObjCaidaSistema.CantidadMinu
                    FechaH = FechaH * ObjCaidaSistema.CantidadH
                End If
                If ((LblCargo.Text = "Voz_G3") Or (LblCargo.Text = "Voz_G5")) Then
                    ObjCaidaSistema.Cod_CS = 4
                    ObjCaidaSistema.ConsultarMetasHorasMinutos()

                    FechaM = FechaM / ObjCaidaSistema.CantidadMinu
                    FechaH = FechaH * ObjCaidaSistema.CantidadH
                End If

            End If

            If ((LblCargo.Text = "Voz_G4") Or (LblCargo.Text = "Voz_G6")) Then
                'Consulto la cantidad de Rechazados
                Tabla = ObjCaidaSistema.ProductividadCerrados_Esca_Falla()
                LblCerradoCantidad.Text = ObjCaidaSistema.Cerrado
                'Consulto la cantidad de Reportados
                Tabla = ObjCaidaSistema.ProductividadReportado()
                LblRechazadoCantidad.Text = ObjCaidaSistema.Reportado
                'Consulto la cantidad de Asignado
                Tabla = ObjCaidaSistema.ProductividadAsignado()
                LblAsignadoCantidad.Text = ObjCaidaSistema.Asignado

                LblEscalado.Visible = False
                LblEscaladoCantidad.Visible = False

                LblTotalDia.Text = ObjCaidaSistema.Cerrado + ObjCaidaSistema.Reportado + ObjCaidaSistema.Asignado
                If (LblCargo.Text = "Voz_G6") Then
                    ObjCaidaSistema.Cod_CS = 5
                    ObjCaidaSistema.ConsultarMetasHorasMinutos()

                    FechaM = FechaM / ObjCaidaSistema.CantidadMinu
                    FechaH = FechaH * ObjCaidaSistema.CantidadH
                End If
                If (LblCargo.Text = "Voz_G4") Then
                    ObjCaidaSistema.Cod_CS = 6
                    ObjCaidaSistema.ConsultarMetasHorasMinutos()

                    FechaM = FechaM / ObjCaidaSistema.CantidadMinu
                    FechaH = FechaH * ObjCaidaSistema.CantidadH
                End If
            End If
        Else
            LblAsignado.Visible = False
            LblAsignadoCantidad.Visible = False
            LblRechazado.Visible = False
            LblRechazadoCantidad.Visible = False
            LblCerrado.Visible = False
            LblCerradoCantidad.Visible = False
            LblEscalado.Visible = False
            LblEscaladoCantidad.Visible = False
            LblTotal.Visible = False
            LblTotalDia.Visible = False
            LblPorcentaje.Visible = False
            LblPorcentajeDia.Visible = False
            LblSimbolo.Visible = False
            BtnCalcularProductividad.Visible = False
        End If

        LblPorcentajeDia.Text = (LblTotalDia.Text / (FechaH + FechaM)) * 100

        If (LblPorcentajeDia.Text >= 100) Then
            LblPorcentajeDia.ForeColor = Drawing.Color.Green
            LblSimbolo.ForeColor = Drawing.Color.Green
        Else
            If ((LblPorcentajeDia.Text >= 90) And (LblPorcentajeDia.Text < 100)) Then
                LblPorcentajeDia.ForeColor = Drawing.Color.DarkOrange
                LblSimbolo.ForeColor = Drawing.Color.DarkOrange
            Else
                If (LblPorcentajeDia.Text < 90) Then
                    LblPorcentajeDia.ForeColor = Drawing.Color.Red
                    LblSimbolo.ForeColor = Drawing.Color.Red
                Else
                End If
            End If
        End If

    End Sub
    Protected Sub BtnCalcularProductividad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCalcularProductividad.Click
        Productividad()
    End Sub
    Dim Vali As Integer = 1

    Protected Sub BtnTodos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTodos.Click
        Try
            If (RdbtnOnline.Checked = True) Then
                Vali = 1
                ProductividadAgentes()
            Else
                If (RdbtnFechas.Checked = True) Then
                    If ((RdbtnMañana.Checked = True) Or (RdbtnTarde.Checked = True) Or (RdbtnCompleta.Checked = True)) Then
                        If ((TxtFechaConsulta1.Text = "") Or (TxtFechaConsulta2.Text = "")) Then
                            lblmsg.Text = "Por favor ingrese las fechas de consulta"
                        Else
                            Fecha_Inicio = TxtFechaConsulta1.Text
                            Fecha_Fin = TxtFechaConsulta2.Text
                            If (Fecha_Inicio > Fecha_Fin) Then
                                lblmsg.Text = "Verifique que la fecha de inicio no sea mayor a la fecha fin"
                            Else
                                ValidacionRdbtn()
                                ProductividadAgentes()
                                lblmsg.Text = ""
                            End If
                        End If
                    Else
                        lblmsg.Text = "Porfavor elija una opcion de Jornada"
                        Exit Sub
                    End If
                Else
                    lblmsg.Text = "Porfavor elija una opcion de consulta"
                    Exit Sub
                End If
            End If

            If drlAgentes.Text <> "- Seleccione -" And drlAgentes.Text <> "" Then
                ObjCaidaSistema.Agente_1 = "[" + drlAgentes.Text + "]"
                ObjCaidaSistema.Grupo = drlGrupo.Text

                dtgConsultas.DataSource = ObjCaidaSistema.Productividad_Consulta_Agentes_Columna_Voz
                dtgConsultas.DataBind()
            Else
                If (dtgConsultasN1.Rows.Count > 0) Or (dtgConsultasN2.Rows.Count > 0) Then
                    Dim vector(1000) As String
                    Dim Cuenta As Integer = 0
                    If (dtgConsultasN1.Rows.Count > 0) Then
                        For Each Row As GridViewRow In dtgConsultasN1.Rows
                            vector(Row.RowIndex.ToString()) = Row.Cells(1).Text
                            Cuenta = Cuenta + 1
                        Next
                    End If
                    If (dtgConsultasN2.Rows.Count > 0) Then
                        For Each Row As GridViewRow In dtgConsultasN2.Rows
                            vector(Row.RowIndex.ToString()) = Row.Cells(1).Text
                            Cuenta = Cuenta + 1
                        Next
                    End If
                    If Cuenta >= 1 Then
                        ObjCaidaSistema.Agente_1 = "[" + vector(0).ToString() + "]"
                    End If
                    If Cuenta >= 2 Then
                        ObjCaidaSistema.Agente_2 = "[" + vector(1).ToString() + "]"
                    End If
                    If Cuenta >= 3 Then
                        ObjCaidaSistema.Agente_3 = "[" + vector(2).ToString() + "]"
                    End If
                    If Cuenta >= 4 Then
                        ObjCaidaSistema.Agente_4 = "[" + vector(3).ToString() + "]"
                    End If
                    If Cuenta >= 5 Then
                        ObjCaidaSistema.Agente_5 = "[" + vector(4).ToString() + "]"
                    End If
                    If Cuenta >= 6 Then
                        ObjCaidaSistema.Agente_6 = "[" + vector(5).ToString() + "]"
                    End If
                    If Cuenta >= 7 Then
                        ObjCaidaSistema.Agente_7 = "[" + vector(6).ToString() + "]"
                    End If
                    If Cuenta >= 8 Then
                        ObjCaidaSistema.Agente_8 = "[" + vector(7).ToString() + "]"
                    End If
                    If Cuenta >= 9 Then
                        ObjCaidaSistema.Agente_9 = "[" + vector(8).ToString() + "]"
                    End If
                    If Cuenta >= 10 Then
                        ObjCaidaSistema.Agente_10 = "[" + vector(9).ToString() + "]"
                    End If

                    ObjCaidaSistema.Grupo = drlGrupo.Text

                    dtgConsultas.DataSource = ObjCaidaSistema.Productividad_Consulta_Agentes_Columna_Voz
                    dtgConsultas.DataBind()
                End If
            End If

            lblmsg.Text = ""

            TxtFechaConsulta1.Text = ""
            TxtFechaConsulta2.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Verifique los datos Error: " & ex.Message
        End Try
    End Sub

    Public Sub ValidacionRdbtn()
        If (RdbtnMañana.Checked = True) Then
            ObjCaidaSistema.Fecha_Turno = TxtFechaConsulta1.Text + " 07:00:00"
            ObjCaidaSistema.Fecha_Actual = TxtFechaConsulta2.Text + " 14:00:00"
            Vali = 2
        Else
            If (RdbtnTarde.Checked = True) Then
                ObjCaidaSistema.Fecha_Turno = TxtFechaConsulta1.Text + " 14:00:00"
                ObjCaidaSistema.Fecha_Actual = TxtFechaConsulta2.Text + " 23:59:00"
                Vali = 2
            Else
                If (RdbtnCompleta.Checked = True) Then
                    ObjCaidaSistema.Fecha_Turno = TxtFechaConsulta1.Text + " 06:00:00"
                    ObjCaidaSistema.Fecha_Actual = TxtFechaConsulta2.Text + " 23:59:00"
                    Vali = 2
                Else
                End If
            End If
        End If
    End Sub

    Sub crearexcel()
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim form = New HtmlForm
        Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"

        pagina.EnableEventValidation = False
        pagina.DesignerInitialize()
        pagina.Controls.Add(form)
        If dtgConsultasN1.Visible = True Then
            form.Controls.Add(dtgConsultasN1)
        Else
            If dtgConsultasN2.Visible = True Then
                form.Controls.Add(dtgConsultasN2)
            End If
        End If
        pagina.RenderControl(htw)
        Response.Clear()
        Response.Buffer = True

        Response.ContentType = "application/vnd.ms-excel"
        Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
        Response.AddHeader("Content-Disposition", "attachment;filename=Productividad_Voz.xls")
        Response.Charset = "UTF-8"
        Response.Write(strStyle)
        Response.Write(sb.ToString())
        Response.End()
    End Sub
    Dim Fecha_Inicio As New Date
    Dim Fecha_Fin As New Date
    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            If (lblcantgral.Text = "0" Or lblcantgral.Text = "") And (lblcantgralN2.Text = "0" Or lblcantgralN2.Text = "") Then
                lblmsg.Text = "Antes de exportar a excel realice una consulta"
            Else
                crearexcel()
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtgConsultasN1_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgConsultasN1.PageIndexChanging
        dtgConsultasN1.PageIndex = e.NewPageIndex()
        Try
            If (RdbtnOnline.Checked = True) Then
                Vali = 1
                ProductividadAgentes()
            Else
                If (RdbtnFechas.Checked = True) Then
                    If ((RdbtnMañana.Checked = True) Or (RdbtnTarde.Checked = True) Or (RdbtnCompleta.Checked = True)) Then
                        If ((TxtFechaConsulta1.Text = "") Or (TxtFechaConsulta2.Text = "")) Then
                            lblmsg.Text = "Por favor ingrese las fechas de consulta"
                        Else
                            Fecha_Inicio = TxtFechaConsulta1.Text
                            Fecha_Fin = TxtFechaConsulta2.Text
                            If (Fecha_Inicio > Fecha_Fin) Then
                                lblmsg.Text = "Verifique que la fecha de inicio no sea mayor a la fecha fin"
                            Else
                                ValidacionRdbtn()
                                ProductividadAgentes()
                                lblmsg.Text = ""
                            End If
                        End If
                    Else
                        lblmsg.Text = "Porfavor elija una opcion de Jornada"
                    End If
                Else
                    lblmsg.Text = "Porfavor elija una opcion de consulta"
                End If
            End If
            TxtFechaConsulta1.Text = ""
            TxtFechaConsulta2.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Verifique los datos Error: " & ex.Message
        End Try
    End Sub

    Protected Sub dtgConsultasN2_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgConsultasN2.PageIndexChanging
        dtgConsultasN2.PageIndex = e.NewPageIndex()
        Try
            If (RdbtnOnline.Checked = True) Then
                Vali = 1
                ProductividadAgentes()
            Else
                If (RdbtnFechas.Checked = True) Then
                    If ((RdbtnMañana.Checked = True) Or (RdbtnTarde.Checked = True) Or (RdbtnCompleta.Checked = True)) Then
                        If ((TxtFechaConsulta1.Text = "") Or (TxtFechaConsulta2.Text = "")) Then
                            lblmsg.Text = "Por favor ingrese las fechas de consulta"
                        Else
                            Fecha_Inicio = TxtFechaConsulta1.Text
                            Fecha_Fin = TxtFechaConsulta2.Text
                            If (Fecha_Inicio > Fecha_Fin) Then
                                lblmsg.Text = "Verifique que la fecha de inicio no sea mayor a la fecha fin"
                            Else
                                ValidacionRdbtn()
                                ProductividadAgentes()
                                lblmsg.Text = ""
                            End If
                        End If
                    Else
                        lblmsg.Text = "Porfavor elija una opcion de Jornada"
                    End If
                Else
                    lblmsg.Text = "Porfavor elija una opcion de consulta"
                End If
            End If
            TxtFechaConsulta1.Text = ""
            TxtFechaConsulta2.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Verifique los datos Error: " & ex.Message
        End Try
    End Sub

    Protected Sub drlGrupo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlGrupo.SelectedIndexChanged
        Try
            ObjCaidaSistema.Grupo = drlGrupo.Text
            With drlAgentes
                .DataSource = ObjCaidaSistema.Productivdad_Consulta_Agentes
                .DataTextField = "nombreu"
                .DataValueField = "nombreu"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class