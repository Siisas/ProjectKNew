Imports System.IO

Public Class CaidaSistema
    Inherits System.Web.UI.Page

    Dim ObjCaidaSistema As New clsCaidaSistema
    Dim FechaActual As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Caidas del Sistema"
                CargardrlCausa()
                ConsultarFallas()
            End If
            FechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    Public Sub CargardrlCausa()
        With drlCausa_Caida
            .DataSource = ObjCaidaSistema.consfallasist
            .DataTextField = "Nombre"
            .DataValueField = "Cod_CausaCS"
            .DataBind()
        End With
        With drlCausa_Caida_Consulta
            .DataSource = ObjCaidaSistema.consfallasist
            .DataTextField = "Nombre"
            .DataValueField = "Cod_CausaCS"
            .DataBind()
        End With
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If ((txtFechaInicio.Text = "") Or (txtFechaInicio_Tiempo.Text = "") Or (drlCausa_Caida.Text = "Seleccione") Or (txtFechasolucion.Text = "") Or (txtFechasolucion_Tiempo.Text = "") Or
                (TxtpuestosAfectados.Text = "") Or (txtaDetalle.Text = "") Or (txtSolucionbrindada.Text = "")) Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor llene todos los campos"
            Else
                ValidarFechaHora()
                If Validacion = False Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor verifique los campos de Fecha y Hora"
                Else
                    ObjCaidaSistema.Fecha_Inicio = Fecha_Inicio
                    ObjCaidaSistema.Causa_Caida = drlCausa_Caida.Text
                    ObjCaidaSistema.Detalle = txtaDetalle.Text
                    ObjCaidaSistema.Fecha_Solucion = Fecha_Solucion
                    ObjCaidaSistema.Duracion_Falla = TxtDuracionFalla.Text
                    ObjCaidaSistema.Puestos_Afectados = TxtpuestosAfectados.Text
                    ObjCaidaSistema.Solucion_Brindada = txtSolucionbrindada.Text
                    ObjCaidaSistema.Fecha_Registro = FechaActual
                    ObjCaidaSistema.Usuario = CType(Session("permisos"), clsusuario).usuario
                    ObjCaidaSistema.Estado = True
                    ObjCaidaSistema.IngresarCaidaSistema()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> La falla se a ingresado correctamente"
                    txtFechaInicio.Text = ""
                    txtFechaInicio_Tiempo.Text = ""
                    txtFechasolucion.Text = ""
                    txtFechasolucion_Tiempo.Text = ""
                    TxtpuestosAfectados.Text = ""
                    txtaDetalle.Text = ""
                    TxtDuracionFalla.Text = ""
                    txtSolucionbrindada.Text = ""
                    CargardrlCausa()
                    ConsultarFallas()
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Verifique los datos Error: " & ex.Message
        End Try
    End Sub

    Dim Validacion = False
    Dim Fecha_Inicio As New Date
    Dim Fecha_Solucion As New Date

    Public Sub ValidarFechaHora()
        Try
            If ((txtFechaInicio.Text = "") Or (txtFechaInicio_Tiempo.Text = "") Or
            (txtFechasolucion.Text = "") Or (txtFechasolucion_Tiempo.Text = "")) Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor llene todos los campos de fecha, para porder calcular la duracion de la falla"
            Else
                'Fecha Inicio
                Dim fchInicio_DD As Integer
                Dim fchInicio_MM As Integer
                Dim fchInicio_YYYY As Integer
                Dim fchInicio_HH As Integer
                Dim fchInicio_minu As Integer

                fchInicio_DD = Day(txtFechaInicio.Text)
                fchInicio_MM = Month(txtFechaInicio.Text)
                fchInicio_YYYY = Year(txtFechaInicio.Text)
                fchInicio_HH = Hour(txtFechaInicio_Tiempo.Text)
                fchInicio_minu = Minute(txtFechaInicio_Tiempo.Text)

                'concateno las fechas para poder obtener el registro de la fecha en la que inicio el problema
                Fecha_Inicio = fchInicio_DD & "/" & fchInicio_MM & "/" & fchInicio_YYYY & " " & fchInicio_HH & ":" & fchInicio_minu

                'Fecha Solucion
                Dim fchSolucion_DD As Integer
                Dim fchSolucion_MM As Integer
                Dim fchSolucion_YYYY As Integer
                Dim fchSolucion_HH As Integer
                Dim fchSolucion_minu As Integer

                fchSolucion_DD = Day(txtFechasolucion.Text)
                fchSolucion_MM = Month(txtFechasolucion.Text)
                fchSolucion_YYYY = Year(txtFechasolucion.Text)
                fchSolucion_HH = Hour(txtFechasolucion_Tiempo.Text)
                fchSolucion_minu = Minute(txtFechasolucion_Tiempo.Text)

                'concateno las fechas para poder obtener el registro de la fecha en la que se soluciono el problema
                Fecha_Solucion = fchSolucion_DD & "/" & fchSolucion_MM & "/" & fchSolucion_YYYY & " " & fchSolucion_HH & ":" & fchSolucion_minu

                'Fecha Duracion
                Dim fchDuracion_DD As Integer
                Dim fchDuracion_MM As Integer
                Dim fchDuracion_YYYY As Integer
                Dim fchDuracion_HH As Integer
                Dim fchDuracion_minu As Integer

                fchDuracion_YYYY = DateDiff("YYYY", Fecha_Inicio, Fecha_Solucion)
                fchDuracion_MM = DateDiff("m", Fecha_Inicio, Fecha_Solucion)
                fchDuracion_DD = fchSolucion_DD - fchInicio_DD
                fchDuracion_HH = DateDiff("h", Fecha_Inicio, Fecha_Solucion)
                fchDuracion_minu = DateDiff("n", Fecha_Inicio, Fecha_Solucion)
                'Valido años y meses
                If (fchDuracion_YYYY > 0) Then
                    If (fchDuracion_MM > 11) Then
                        fchDuracion_MM = fchDuracion_MM Mod 12
                    Else
                        fchDuracion_YYYY = fchDuracion_YYYY - 1
                    End If
                End If
                'Validar meses
                If ((fchDuracion_MM > 0) And ((fchSolucion_DD = fchInicio_DD) Or (fchSolucion_DD > fchInicio_DD))) Then
                Else
                    If (fchDuracion_MM = 0) Then
                    Else
                        fchDuracion_MM = fchDuracion_MM - 1
                    End If
                End If
                'valido dias
                If (fchDuracion_DD < 0) Then
                    fchDuracion_DD = fchSolucion_DD Mod fchInicio_DD
                End If
                'Valido horas
                If (fchDuracion_HH > 23) Then
                    fchDuracion_HH = fchDuracion_HH Mod 24
                End If
                'Valido minutos
                If (fchDuracion_minu > 59) Then
                    fchDuracion_minu = fchDuracion_minu Mod 60
                End If
                'Valido los dias de la fecha
                If (fchDuracion_DD > 0) Then
                    If (fchInicio_HH > fchSolucion_HH) Then
                        fchDuracion_DD = fchDuracion_DD - 1
                    ElseIf ((fchInicio_HH = fchSolucion_HH) And (fchInicio_minu > fchSolucion_minu)) Then
                        fchDuracion_DD = fchDuracion_DD - 1
                    End If
                End If
                If ((Fecha_Solucion < Fecha_Inicio) Or (Fecha_Solucion = Fecha_Inicio)) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor verifique la fecha en la que inicio el problema ya que no puede ser la misma o mayor a la fecha en que se soluciono"
                    TxtDuracionFalla.Text = ""
                Else
                    If (fchDuracion_YYYY >= 1 & fchDuracion_MM >= 1) Or (fchDuracion_YYYY >= 1) Then
                        TxtDuracionFalla.Text = fchDuracion_YYYY & " Año/s " & fchDuracion_MM & " meces/s " & fchDuracion_DD & " dia/s " & fchDuracion_HH & " hora/s y " & fchDuracion_minu & " minuto/s"
                        Validacion = True
                    Else
                        If (fchDuracion_MM >= 1 & fchDuracion_DD >= 1) Or (fchDuracion_MM >= 1) Then
                            TxtDuracionFalla.Text = fchDuracion_MM & " meces/s " & fchDuracion_DD & " dia/s " & fchDuracion_HH & " hora/s y " & fchDuracion_minu & " minuto/s"
                            Validacion = True
                        Else
                            If ((fchDuracion_DD >= 1 & fchDuracion_HH >= 1) Or (fchDuracion_DD >= 1)) Then
                                TxtDuracionFalla.Text = fchDuracion_DD & " dia/s " & fchDuracion_HH & " hora/s y " & fchDuracion_minu & " minuto/s "
                                Validacion = True
                            Else
                                TxtDuracionFalla.Text = fchDuracion_HH & " hora/s y " & fchDuracion_minu & " minuto/s"
                                Validacion = True
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Error en la fecha " & ex.Message
        End Try
    End Sub

    Dim Tabla As DataSet
    Dim Cantidad As Integer

    Sub ConsultaActualizar()
        Try
            If TxtCod_Falla.Text <> "" Then
                ObjCaidaSistema.Cod_CS = TxtCod_Falla.Text
                Tabla = ObjCaidaSistema.ConsultaActualizar()
                Cantidad = Tabla.Tables.Count.ToString()
                If Cantidad > 0 Then
                    Dim fecha_Inicio_Total As String
                    Dim fecha_Ini_D As String
                    Dim fecha_Ini_M As String
                    Dim fecha_Ini_Y As String
                    Dim fecha_Ini_H As String
                    Dim fecha_Ini_min As String
                    Dim fecha_Solucion_Total As String
                    Dim fecha_Sol_D As String
                    Dim fecha_Sol_M As String
                    Dim fecha_Sol_Y As String
                    Dim fecha_Sol_H As String
                    Dim fecha_Sol_min As String
                    fecha_Inicio_Total = ObjCaidaSistema.Fecha_Inicio
                    fecha_Solucion_Total = ObjCaidaSistema.Fecha_Solucion
                    fecha_Ini_D = Day(fecha_Inicio_Total)
                    fecha_Ini_M = Month(fecha_Inicio_Total)
                    fecha_Ini_Y = Year(fecha_Inicio_Total)
                    fecha_Ini_H = Hour(fecha_Inicio_Total)
                    fecha_Ini_min = Minute(fecha_Inicio_Total)
                    fecha_Inicio_Total = fecha_Ini_D & "/" & fecha_Ini_M & "/" & fecha_Ini_Y
                    fecha_Ini_Y = fecha_Ini_H & ":" & fecha_Ini_min
                    fecha_Sol_D = Day(fecha_Solucion_Total)
                    fecha_Sol_M = Month(fecha_Solucion_Total)
                    fecha_Sol_Y = Year(fecha_Solucion_Total)
                    fecha_Sol_H = Hour(fecha_Solucion_Total)
                    fecha_Sol_min = Minute(fecha_Solucion_Total)
                    fecha_Solucion_Total = fecha_Sol_D & "/" & fecha_Sol_M & "/" & fecha_Sol_Y
                    fecha_Sol_Y = fecha_Sol_H & ":" & fecha_Sol_min
                    txtFechaInicio.Text = fecha_Inicio_Total
                    txtFechaInicio_Tiempo.Text = fecha_Ini_Y
                    txtFechasolucion.Text = fecha_Solucion_Total
                    txtFechasolucion_Tiempo.Text = fecha_Sol_Y
                    drlCausa_Caida.Text = ObjCaidaSistema.Causa_Caida
                    TxtpuestosAfectados.Text = ObjCaidaSistema.Puestos_Afectados
                    txtaDetalle.Text = ObjCaidaSistema.Detalle
                    TxtDuracionFalla.Text = ObjCaidaSistema.Duracion_Falla
                    txtSolucionbrindada.Text = ObjCaidaSistema.Solucion_Brindada
                    btnguardar.Visible = False
                    btnactualiza.Visible = True
                    TxtCod_Falla.Enabled = False
                    btnconsultar.Visible = False
                    btnelimina.Visible = True
                    BtnValidacion.Visible = True
                Else
                    Pnl_Message.CssClass = "alert alert-info"
                    lblmsg.Text = "<span class='glyphicon glyphicon-info-sign'></span> No hay ningun registro con este codigo: " & TxtCod_Falla.Text
                    TxtCod_Falla.Text = ""
                    btnguardar.Visible = True
                    btnactualiza.Visible = False
                    TxtCod_Falla.Enabled = True
                    btnconsultar.Visible = True
                    btnelimina.Visible = False
                    BtnValidacion.Visible = False
                End If
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor digite el codigo de la falla a solucionar"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> " & ex.Message
        End Try
    End Sub

    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnconsultar.Click
        If (TxtCod_Falla.Text = "") Then
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Por favor ingrese el codigo de la falla que desea actualizar"
        Else
            ConsultaActualizar()
        End If
    End Sub

    Public Sub ConsultarFallas()
        If (TxtConsultaEspecificas.Text <> "") Then
            ObjCaidaSistema.Cod_CS = TxtConsultaEspecificas.Text
        End If
        If (drlCausa_Caida_Consulta.Text <> "0") Then
            ObjCaidaSistema.Causa_Caida = drlCausa_Caida_Consulta.Text
        End If
        If (((TxtFechaConsulta1.Text <> "") And (TxtFechaConsulta2.Text <> ""))) Then
            Dim Fecha2 As String
            Fecha2 = TxtFechaConsulta2.Text
            Fecha2 = Fecha2 & " 23:59:59.000"
            ObjCaidaSistema.Fecha_Inicio = TxtFechaConsulta1.Text
            ObjCaidaSistema.Fecha_Solucion = Fecha2
        End If
        dtgConsultas.DataSource = ObjCaidaSistema.consultaCSTodo
        dtgConsultas.DataBind()
        lblcantgral.Text = ObjCaidaSistema.Cantidad
    End Sub

    Protected Sub btnactualiza_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnactualiza.Click
        Try
            If ((txtFechaInicio.Text = "") Or (txtFechaInicio_Tiempo.Text = "") Or (drlCausa_Caida.Text = "Seleccione") Or (txtFechasolucion.Text = "") Or (txtFechasolucion_Tiempo.Text = "") Or
                (TxtpuestosAfectados.Text = "") Or (txtaDetalle.Text = "") Or (txtSolucionbrindada.Text = "")) Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor llene todos los campos"
            Else
                ValidarFechaHora()
                If Validacion = False Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor Corriga la hora"
                Else
                    ObjCaidaSistema.Cod_CS = TxtCod_Falla.Text
                    ObjCaidaSistema.Fecha_Inicio = Fecha_Inicio
                    ObjCaidaSistema.Causa_Caida = drlCausa_Caida.Text
                    ObjCaidaSistema.Detalle = txtaDetalle.Text
                    ObjCaidaSistema.Fecha_Solucion = Fecha_Solucion
                    ObjCaidaSistema.Duracion_Falla = TxtDuracionFalla.Text
                    ObjCaidaSistema.Puestos_Afectados = TxtpuestosAfectados.Text
                    ObjCaidaSistema.Solucion_Brindada = txtSolucionbrindada.Text
                    ObjCaidaSistema.Fecha_Registro = FechaActual
                    ObjCaidaSistema.Usuario = CType(Session("permisos"), clsusuario).usuario
                    ObjCaidaSistema.ActualizarCaidaSistema()
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> La falla se actualizo correctamente"
                    btnguardar.Visible = True
                    btnactualiza.Visible = False
                    TxtCod_Falla.Enabled = True
                    btnconsultar.Visible = True
                    btnelimina.Visible = False
                    BtnValidacion.Visible = False
                    TxtCod_Falla.Enabled = True
                    TxtCod_Falla.Text = ""
                    txtFechaInicio.Text = ""
                    txtFechaInicio_Tiempo.Text = ""
                    txtFechasolucion.Text = ""
                    txtFechasolucion_Tiempo.Text = ""
                    TxtpuestosAfectados.Text = ""
                    txtaDetalle.Text = ""
                    TxtDuracionFalla.Text = ""
                    txtSolucionbrindada.Text = ""
                    CargardrlCausa()
                    ConsultarFallas()
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Verifique los datos Error: " & ex.Message
        End Try
    End Sub

    Protected Sub BtnValidacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnValidacion.Click
        TxtCod_Falla.Text = ""
        btnguardar.Visible = True
        btnactualiza.Visible = False
        TxtCod_Falla.Enabled = True
        btnconsultar.Visible = True
        btnelimina.Visible = False
        BtnValidacion.Visible = False
        txtFechaInicio.Text = ""
        txtFechaInicio_Tiempo.Text = ""
        txtFechasolucion.Text = ""
        txtFechasolucion_Tiempo.Text = ""
        TxtpuestosAfectados.Text = ""
        TxtDuracionFalla.Text = ""
        txtaDetalle.Text = ""
        txtSolucionbrindada.Text = ""
        CargardrlCausa()
    End Sub

    Protected Sub btnelimina_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnelimina.Click
        Try
            If (TxtCod_Falla.Text = "") Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor Ingrese el codigo de la falla que desea eliminar"
            Else
                ObjCaidaSistema.Cod_CS = TxtCod_Falla.Text
                ObjCaidaSistema.Estado = False
                ObjCaidaSistema.EliminarCaidaSistema()
                Pnl_Message.CssClass = "alert alert-success"
                lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> La falla se a eliminado correctamente"
                btnguardar.Visible = True
                btnactualiza.Visible = False
                TxtCod_Falla.Enabled = True
                btnconsultar.Visible = True
                btnelimina.Visible = False
                BtnValidacion.Visible = False
                TxtCod_Falla.Text = ""
                txtFechaInicio.Text = ""
                txtFechaInicio_Tiempo.Text = ""
                txtFechasolucion.Text = ""
                txtFechasolucion_Tiempo.Text = ""
                TxtpuestosAfectados.Text = ""
                txtaDetalle.Text = ""
                TxtDuracionFalla.Text = ""
                txtSolucionbrindada.Text = ""
                CargardrlCausa()
                ConsultarFallas()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Verifique los datos Error: " & ex.Message
        End Try
    End Sub

    Sub crearexcel()
        Dim sw As New StringWriter()
        Dim hw As New HtmlTextWriter(sw)
        Dim tabla As New Table()
        Dim tr1 As New TableRow()
        Dim tr2 As New TableRow()
        Dim cell1 As New TableCell()
        Dim cell2 As New TableCell()
        Dim r As New clsCaidaSistema
        Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
        If dtgConsultas.Rows.Count() > 0 Then
            cell1.Controls.Add(tblHeader)
            tr1.Cells.Add(cell1)
            cell2.Controls.Add(dtgConsultas)
            tr2.Cells.Add(cell2)
            tabla.Rows.Add(tr1)
            tabla.Rows.Add(tr2)
            tabla.RenderControl(hw)
            Response.Clear()
            Response.Buffer = True
            Response.AddHeader("Content-Disposition", "attachment;filename=Reporte Caidas del Sistema.xls")
            Response.Charset = "UTF-8"
            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.Write(style)
            Response.Output.Write(sw.ToString())
            Response.Flush()
            Response.End()
        Else
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Primero haga una consulta e intente Exportarla!!"
        End If
    End Sub

    Protected Sub BtnConsultaespe_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultaespe.Click
        If (TxtConsultaEspecificas.Text = "" And drlCausa_Caida_Consulta.Text = "0" And (TxtFechaConsulta1.Text = "" Or TxtFechaConsulta2.Text = "")) Then
            Pnl_Message.CssClass = "alert alert-warning"
            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Por favor elija una opcion"
        Else
            ConsultarFallas()
        End If
    End Sub

    Protected Sub BtnTodos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTodos.Click
        dtgConsultas.DataSource = ObjCaidaSistema.consultaCSTodo
        dtgConsultas.DataBind()
        lblcantgral.Text = ObjCaidaSistema.Cantidad
    End Sub

    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            crearexcel()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

End Class