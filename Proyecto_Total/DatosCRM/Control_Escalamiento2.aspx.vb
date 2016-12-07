Imports System.ComponentModel

Public Class Control_Escalamiento2
    Inherits System.Web.UI.Page
    Dim objGeneral As New clsgeneral
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                Consultas()
                Dim objGeneral As New clsgeneral
                cargar_drl()
                ''''' INICIO SEGURIDAD ACCESO URL '''''
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

    Sub cargar_drl()
        With drlingclaro
            .DataSource = objGeneral.consultaagentes()
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
        End With
        With drl_Estado_Claro
            .DataSource = objGeneral.consultaestadocpd
            .DataTextField = "estadocpd"
            .DataValueField = "estadocpd"
            .DataBind()
        End With
        With Drl_ing_consulta
            .DataSource = objGeneral.consultaagentes()
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
        End With

    End Sub

    Sub Consultas()
        Try

       
        Dim objGeneral As New clsgeneral
        objGeneral.Validacion = "CPD"
        dtggeneral.DataSource = objGeneral.Consulta_Escalados()
        dtggeneral.DataBind()
        lblcuenta.Text = objGeneral.cantreg
        objGeneral.Validacion = "SD"
        dtggeneral2.DataSource = objGeneral.Consulta_Asignados_Sd()
        dtggeneral2.DataBind()
        lblcuenta1.Text = objGeneral.cantreg
        objGeneral.Validacion = "Consulta_Asignados"
        dtg_Asignados.DataSource = objGeneral.Consulta_Escalados()
        dtg_Asignados.DataBind()
        dtg_asignados_sd.DataSource = objGeneral.Consulta_Asignados_Sd()
            dtg_asignados_sd.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Protected Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Try
            If Drl_tipo_escalamiento.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el tipo de escalamiento que va a Asignar"
                Exit Sub
            End If

            If Txt_Numero_casos.Text = "" And Chk_caso.Checked = False And Chk_Ing.Checked = False Then
                lblmsg.Text = "Ingrese el numero de casos a Asignar"
                Exit Sub
            Else
                If Txt_Numero_casos.Text <> "" And Chk_caso.Checked = False And Chk_Ing.Checked = False Then
                    objGeneral.ut = Txt_Numero_casos.Text
                End If
            End If

            If Chk_Ing.Checked = True Then 'consulta por ingeniero
                If Drl_ing_consulta.SelectedValue = "- Seleccione -" Then
                    lblmsg.Text = "Seleccione al Ingeniero a consultar"
                    Exit Sub
                Else
                    objGeneral.nombre = Drl_ing_consulta.SelectedValue
                End If
            End If

            If Chk_caso.Checked = True Then 'consulta por idcaso
                If Txt_Caso.Text = "" Then
                    lblmsg.Text = "Ingrese el caso que va a Asignar"
                    Exit Sub
                End If
                objGeneral.Cod_Diagnostico = Txt_Caso.Text
            End If

            If Chk_fecha_desde.Checked = True Then
                If Txt_fc_inicio.Text = "" Then
                    lblmsg.Text = "Ingrese la fecha Desde"
                    Exit Sub
                End If
                If Date.Parse(Txt_fc_inicio.Text) < "01/01/2015" Then
                    lblmsg.Text = "La fecha no puede ser inferior a 01/01/2015 "
                    Exit Sub
                End If
                objGeneral.dpto = Txt_fc_inicio.Text
            End If

            If Chk_fecha_hasta.Checked = True Then
                If Txt_fc_fin.Text = "" Then
                    lblmsg.Text = "Ingrese la fecha Hasta"
                    Exit Sub
                End If
                objGeneral.mun = Txt_fc_fin.Text
            End If

            If Chk_fecha_desde.Checked = True And Chk_fecha_hasta.Checked = True Then
                If Date.Parse(Txt_fc_inicio.Text) > Date.Parse(Txt_fc_fin.Text) Then
                    lblmsg.Text = "Verifique el rango de fechas ya que la fecha inicio no puede ser mayor a la fecha fin"
                    Exit Sub
                End If
            End If

            If Chk_estado.Checked = True Then
                If drl_Estado_Claro.SelectedValue = "- Seleccione -" Then
                    lblmsg.Text = "Selecione el estado a consultar"
                    Exit Sub
                End If
                objGeneral.tipo = drl_Estado_Claro.SelectedValue
            End If
            '********************************************************
            objGeneral.Validacion = "Filtros"
            If Drl_tipo_escalamiento.SelectedValue = "Tecnica" Then
                dtg_Asignar.DataSource = objGeneral.Consulta_Escalados()
            Else
                dtg_Asignar.DataSource = objGeneral.Consulta_Asignados_Sd()
            End If
            dtg_Asignar.DataBind()
            If objGeneral.cantreg = 0 Then
                lblmsg.Text = "No se encontraron registros"
                Lbl_cuenta_3.Text = ""
                Exit Sub
            End If
            lbl_control.Text = ""
            lblmsg.Text = ""
            Lbl_cuenta_3.Text = objGeneral.cantreg
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    Protected Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            If dtg_Asignar.Rows.Count = 0 Then
                lblmsg.Text = "Realice una Consulta"
                Exit Sub
            End If
            If drlingclaro.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Seleccione a un Ingeniero De Soporte"
                Exit Sub
            End If
            If Drl_tipo_escalamiento.SelectedValue = "Informatica" Then
                objGeneral.tipo = "Informatica"
            Else
                objGeneral.tipo = "Tecnica"
            End If
            objGeneral.idusuario = lblusuario.Text
            objGeneral.nombre = drlingclaro.SelectedValue
            objGeneral.idusuario = lblusuario.Text
            If dtg_Asignar.Rows.Count > 0 Then
                For Each row As GridViewRow In dtg_Asignar.Rows
                    objGeneral.identidad = CInt(row.Cells(0).Text)
                    objGeneral.Actualizacion_Escalado()
                Next
            End If
            lblmsg.Text = "Asignación masiva de " & Drl_tipo_escalamiento.SelectedValue & " realizada con éxito"
            dtg_Asignar.DataSource = Nothing
            dtg_Asignar.DataBind()
            Consultas()
            Lbl_cuenta_3.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub

    'Private Sub dtggeneral_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtggeneral.RowDataBound
    '    Try
    '        Dim FcIngreso As Date = Date.Now.ToString("dd/MM/yyyy")
    '        If (e.Row.RowType = DataControlRowType.DataRow) Then
    '            FcIngreso = Date.Now
    '            If DataBinder.Eval(e.Row.DataItem, "Fecha SAP") < FcIngreso Then
    '                e.Row.ForeColor = Drawing.Color.Red
    '            End If
    '        End If
    '    Catch ex As Exception
    '        lblmsg.Text = "Se presento error " & ex.Message
    '    End Try
    'End Sub

    'Private Sub dtggeneral2_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtggeneral.RowDataBound
    '    Try
    '        Dim FcIngreso As Date = Date.Now.ToString("dd/MM/yyyy")
    '        If (e.Row.RowType = DataControlRowType.DataRow) Then
    '            FcIngreso = Date.Now
    '            If DataBinder.Eval(e.Row.DataItem, "Fecha SAP") < FcIngreso Then
    '                e.Row.ForeColor = Drawing.Color.Red
    '            End If
    '        End If
    '    Catch ex As Exception
    '        lblmsg.Text = "Se presento error " & ex.Message
    '    End Try
    'End Sub

    Protected Sub Chk_Ing_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Ing.CheckedChanged
        Chk_caso.Checked = False
        Chk_fecha_desde.Checked = False
        Chk_fecha_hasta.Checked = False
        Chk_estado.Checked = False
    End Sub

    Protected Sub Chk_caso_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_caso.CheckedChanged
        Chk_fecha_desde.Checked = False
        Chk_fecha_hasta.Checked = False
        Chk_estado.Checked = False
        Chk_Ing.Checked = False
    End Sub

    Protected Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_fecha_desde.CheckedChanged, Chk_fecha_hasta.CheckedChanged, Chk_estado.CheckedChanged
        Chk_caso.Checked = False
        Chk_Ing.Checked = False
    End Sub

    Protected Sub btn_liberar_Click(sender As Object, e As EventArgs) Handles btn_liberar.Click
        Try
            If Lbl_cuenta_3.Text = "" Then
                lblmsg.Text = "Realice una consulta antes de liberar"
                Exit Sub
            End If
            If Drl_tipo_escalamiento.SelectedValue = "Informatica" Then
                objGeneral.tipo = "Informatica"
            Else
                objGeneral.tipo = "Tecnica"
            End If
            objGeneral.Validacion = "Liberacion"
            objGeneral.idusuario = lblusuario.Text
            objGeneral.nombre = drlingclaro.SelectedValue
            objGeneral.idusuario = lblusuario.Text
            If dtg_Asignar.Rows.Count > 0 Then
                For Each row As GridViewRow In dtg_Asignar.Rows
                    objGeneral.identidad = CInt(row.Cells(0).Text)
                    objGeneral.Actualizacion_Escalado()
                Next
            End If
            lblmsg.Text = "Liberacion Completada Exitosamente"
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
End Class