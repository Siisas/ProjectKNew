''''''''''''''''''''''''''''''''''''''tecnica



Imports System.IO
Public Class escalamiento
    Inherits System.Web.UI.Page
    Dim Obj_General As New clsgeneral
    Dim Obj_Voz As New clsvoz
    Dim Obj_Gestion_Datos As New Cls_Gestion_Datos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If

            Lbl_Mensage.Text = Nothing
            Pnl_Message.CssClass = Nothing

            If Not IsPostBack Then
                Session("Formulario") = "Asignación Escalamiento Voz"
                Obj_General.idusuario = CType(Session("permisos"), clsusuario).usuario
                Obj_General.consultared()
                Consultar_Agentes_Asignados()
                Cargar_Drl_Agent()
                Cargar_Drl_Campaña()
                'Consultar_Agentes_Asignados_Dev()
                Cargar_Drl_Agent_Dev()
                Cargar_Drl_Campaña_Dev()
                Contar_Casos_Devuelos()
            End If
            Lbl_Cas_Dev.Text = Session("Count_Cas_Tec_Dev")

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    'Cargar DropDownLists
    Private Sub Cargar_Drl_Agent()
        With Drl_Agent
            .DataSource = Obj_General.consultaagenteescala()
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
            .Items(0).Value = ""
        End With
    End Sub
    Private Sub Cargar_Drl_Campaña()
        With Drl_Camp
            .DataSource = Obj_Voz.Consulta_Campaña_Report_Falla()
            .DataTextField = "campana"
            .DataValueField = "campana"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
            .Items(0).Value = ""
        End With
    End Sub
    'Consulta Agentes Asignados
    Private Sub Consultar_Agentes_Asignados()
        Try
            Session("Dts_Cons_Agent_Asig") = Obj_Voz.Consultar_Agentes_En_Escalamiento()
            dtgestad.DataSource = Session("Dts_Cons_Agent_Asig")
            dtgestad.DataBind()
            Obj_Voz.consultapteasignartotal()
            lblcantidadtot.Text = Obj_Voz.cantidad
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Asig_Cas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Asig_Cas.Click
        Dim actualizar As New clsvoz
        Try
            actualizar.idusuario = CType(Session("permisos"), clsusuario).usuario
            actualizar.idusuarioasignado = Drl_Agent.SelectedItem.Value
            If txtcaso.Text <> Nothing Then
                actualizar.caso = txtcaso.Text
                If actualizar.Asignar_Caso() > 0 Then
                    txtcaso.Text = Nothing
                    Pnl_Message.CssClass = "alert alert-success"
                    Lbl_Mensage.Text = "<span class='glyphicon glyphicon-ok-circle'></span> Asignación individual realizada con éxito"
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> La asignación individual no se pudo realizar"
                End If
            Else
                Dim Warning As String = Nothing
                For Each row As GridViewRow In dtggeneral.Rows
                    actualizar.caso = row.Cells(1).Text
                    If actualizar.Asignar_Caso() <= 0 Then
                        If Warning = Nothing Then
                            Warning = "No han podido asignar los caso: " & row.Cells(1).Text
                        Else
                            Warning = Warning & ", " & CInt(row.Cells(0).Text)
                        End If
                    End If
                Next
                If Warning <> Nothing Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> " & Warning
                Else
                    Pnl_Message.CssClass = "alert alert-success"
                    Lbl_Mensage.Text = "<span class='glyphicon glyphicon-ok-circle'></span> Asignación masiva realizada con éxito"
                End If
            End If
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            lblcantidad.Text = Nothing
            Txb_Num_Cas.Text = Nothing
            Consultar_Agentes_Asignados()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Cons_Cas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Cons_Cas.Click
        Try
            Dim objdatos As New clsvoz
            If Txb_Num_Cas.Text = Nothing Then
                Pnl_Message.CssClass = "alert alert-warning"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite la cantidad de casos que desea asignar"
                Exit Sub
            End If
            If Txb_Fech_Ini.Text <> Nothing And Txb_Fech_Fin.Text <> Nothing Then
                If ((Date.Parse(Txb_Fech_Ini.Text)) > (Date.Parse(Txb_Fech_Fin.Text))) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique que el rango de fecha sea correcto!"
                    Exit Sub
                End If
            End If
            objdatos.cantidad = Txb_Num_Cas.Text
            objdatos.campana = Drl_Camp.SelectedValue
            objdatos.fcfin = Txb_Fech_Fin.Text
            objdatos.fcini = Txb_Fech_Ini.Text
            Session("Dts_Cons_Cas") = objdatos.Consultar_Casos_Sin_Asignar()
            If Session("Dts_Cons_Cas").Tables(0).Rows.Count > 0 Then
                Pnl_Grid_Cas.Visible = True
                dtggeneral.DataSource = Session("Dts_Cons_Cas")
                dtggeneral.DataBind()
                lblcantidad.Text = Session("Dts_Cons_Cas").Tables(0).Rows.Count
            Else
                Lbl_Mensage.Text = Nothing
                Pnl_Message.CssClass = "alert alert-warning"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> No se encontraron registros entre el rango de fechas designado"
                Pnl_Grid_Cas.Visible = False
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    'Paginado de datagrids
    Private Sub dtgestad_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgestad.PageIndexChanging
        Try
            dtgestad.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgestad.DataSource = Session("Dts_Cons_Agent_Asig")
            dtgestad.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtggeneral.DataSource = Session("Dts_Cons_Cas")
            dtggeneral.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Btn_Export_Cas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Export_Cas.Click
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim Val As Boolean = False
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If dtggeneral.Rows.Count > 0 Then
                dtggeneral.AllowPaging = False
                dtggeneral.DataSource = Session("Dts_Cons_Cas")
                dtggeneral.DataBind()
                cell1.Controls.Add(dtggeneral)
                tr1.Cells.Add(cell1)
                tabla.Rows.Add(tr1)
                tabla.RenderControl(hw)
                dtggeneral.AllowPaging = True
                Response.Clear()
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", "attachment;filename=Reporte de casos.xls")
                Response.Charset = "UTF-8"
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.Write(style)
                Response.Output.Write(sw.ToString())
                Response.Flush()
                Response.End()
            Else
                Lbl_Mensage.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> ¡No se encontraron registros para realizar la exportacion! "
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    '#############################Devueltos#########################
    Private Sub Cargar_Drl_Agent_Dev()
        With Drl_Agent_Dev
            .DataSource = Obj_General.consultaagenteescala()
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
            .Items(0).Value = ""
        End With
    End Sub
    Private Sub Cargar_Drl_Campaña_Dev()
        With Drl_Camp_Dev
            .DataSource = Obj_Voz.Consulta_Campaña_Report_Falla()
            .DataTextField = "campana"
            .DataValueField = "campana"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
            .Items(0).Value = ""
        End With
    End Sub
    Protected Sub Btn_Consultar_Casos_Devueltos_Click(sender As Object, e As EventArgs) Handles Btn_Consultar_Casos_Devueltos.Click
        Try
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "hide", "$_$('#Div_Count_Cas_Dev').hide();", True)
            If Txb_Cod_Cas_Dev.Text <> Nothing Then
                Obj_Voz.caso = Txb_Cod_Cas_Dev.Text
            Else
                If Txb_Fech_Ini_Dev.Text <> Nothing And Txb_Fech_Fin_Dev.Text <> Nothing Then
                    If ((Date.Parse(Txb_Fech_Ini_Dev.Text)) > (Date.Parse(Txb_Fech_Fin_Dev.Text))) Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique que el rango de fecha sea correcto!"
                        Exit Sub
                    End If
                End If
                Obj_Voz.cantidad = Txb_Num_Cas_Dev.Text
                Obj_Voz.campana = Drl_Camp_Dev.SelectedValue
                Obj_Voz.fcfin = Txb_Fech_Fin_Dev.Text
                Obj_Voz.fcini = Txb_Fech_Ini_Dev.Text
            End If
            Session("Filtro_Cons_Cas_Es_Dev") = Obj_Voz
            Dim Data = Json_Consulta_Casos_Devueltos()
            If TypeOf Data Is Object Then
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Grid", "Data_Grid(" & Obj_Gestion_Datos.Object_To_JSON(Data) & ");", True)
                Dim I As Integer = 0
                For Each GData In Data("Grid")("Data")
                    I = I + 1
                Next
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "show", "$_$('#Span_Count_Cas_Dev').html('" & I & "');$_$('#Div_Count_Cas_Dev').show();", True)
            Else
                If Data <> Nothing Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    Lbl_Mensage.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> " & Data
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    Lbl_Mensage.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> No se encontraron registros que coincidan con su criterio de búsqueda"
                End If
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Destroy", "$_$('#Grid_Cas_Dev').hide();", True)
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "setTimeout('Pleg_Loading()', 250);", True)
        End Try
    End Sub
    <System.Web.Services.WebMethod()>
    Public Shared Function Json_Consulta_Casos_Devueltos()
        Try
            Dim Current As HttpContext = HttpContext.Current
            If TypeOf Current.Session("Filtro_Cons_Cas_Es_Dev") Is Object Then
                Dim Obj_Voz As New clsvoz
                Dim Obj_G_Data As New Cls_Gestion_Datos
                Obj_Voz = Current.Session("Filtro_Cons_Cas_Es_Dev")
                Obj_G_Data.DataSet = Obj_Voz.Consultar_Casos_Tecnica_Devueltos()
                If Obj_G_Data.DataSet.Tables(0).Rows.Count > 0 Then
                    Obj_G_Data.DataSet.Tables(0).Columns.Add("Check", Type.GetType("System.Boolean"))
                    For I As Integer = 0 To Obj_G_Data.DataSet.Tables(0).Rows.Count - 1
                        Obj_G_Data.DataSet.Tables(0).Rows(I).Item("Check") = False
                    Next
                    Obj_G_Data.Grid_Config = "{'ShowFilter':true, 'Editable':true, 'Filterable':true, 'MaxHeigth':400, 'Container':'#Grid_Cas_Dev'}"
                    Obj_G_Data.Grid_Keys = "{'Primary':'Id_Caso'}"
                    Obj_G_Data.Grid_Datafields = "[{name: 'Id_Caso', type: 'string'}, {name: 'Fecha_Reg'}, {name: 'Fecha_Reg_V'}, {name: 'Fecha_Asignado'}, {name: 'Fecha_Proc_Dev'}, {name: 'Id_Usuario_Dev', type: 'string'}, {name: 'Campaña', type: 'string'}, {name: 'Check', type: 'bool'}]"
                    Obj_G_Data.Grid_Columns = "[{text: 'Id Caso', datafield: 'Id_Caso', editable: false, filtertype: 'input'}, {text: 'Fecha Registro', datafield: 'Fecha_Reg', editable: false, cellsformat: 'yyyy/MM/dd HH: mm: ss', filtertype: 'range'}, {text: 'Fecha Ingreso', datafield: 'Fecha_Reg_V', editable: false, cellsformat: 'yyyy/MM/dd HH: mm: ss', filtertype: 'range'}, {text: 'Fecha Asignado', datafield: 'Fecha_Asignado', editable: false, cellsformat: 'yyyy/MM/dd HH: mm: ss', filtertype: 'range'}, {text: 'Fecha Devuelto', datafield: 'Fecha_Proc_Dev', editable: false, cellsformat: 'yyyy/MM/dd HH: mm: ss', filtertype: 'range'}, {text: 'Usuario', datafield: 'Id_Usuario_Dev', editable: false, filtertype: 'input'}, {text: 'Campaña', datafield: 'Campaña', editable: false, filtertype: 'checkedlist'}, {text: 'Check',  datafield: 'Check',  threestatecheckbox: true,  editable: true,  columntype: 'checkbox', filtertype: 'checkedlist'}]"
                    Obj_G_Data.SubGrid_Config = "{'ShowFilter': false, Editable: false, 'Filterable': true}"
                    Obj_G_Data.SubGrid_Keys = "{'Primary': 'Id_Crm', 'Foreign': 'Id_Caso'}"
                    Obj_G_Data.SubGrid_Datafields = "[{name: 'Id_Caso', type: 'number'}, {name: 'Id_Crm', type: 'number'}, {name: 'Fecha'}, {name: 'Id_Usuario', type: 'string'}, {name: 'Observacion', type: 'string'}, {name: 'Tipificacion', type: 'string'}]"
                    Obj_G_Data.SubGrid_Columns = "[{text: 'Id Crm', datafield: 'Id_Crm', editable: 'false', filtertype: 'number'}, {text: 'Fecha', datafield: 'Fecha', 'cellsformat': 'yyyy/MM/dd HH: mm: ss', filtertype: 'date', editable: false}, {text: 'Usuario', datafield: 'Id_Usuario', editable: false, filtertype: 'input'}, {text: 'Observación', datafield: 'Observacion', 'filterable': false, editable: false}, {text: 'Tipificación', datafield: 'Tipificacion', editable: false, filtertype: 'checkedlist'}]"
                    Return Obj_G_Data.Generate_Data_Grid()
                Else
                    Return Nothing
                End If
            Else
                Return "La seción a caducado"
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function Contar_Casos_Devuelos()
        Try
            Dim Obj_Voz As New clsvoz
            Dim Current As HttpContext = HttpContext.Current
            Current.Session("Count_Cas_Tec_Dev") = Obj_Voz.Consultar_Casos_Tecnica_Devueltos.Tables(0).rows.count
            Return Current.Session("Count_Cas_Tec_Dev")
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function Asignar_Casos_Devueltos(ByVal Id_Usuario As String, ByVal Casos As Object)
        Try
            Dim Current As HttpContext = HttpContext.Current
            Dim Obj_Voz As New clsvoz
            Obj_Voz.idusuarioasignado = Id_Usuario
            Obj_Voz.idusuario = CType(Current.Session("permisos"), clsusuario).usuario
            Dim Warning As String = Nothing
            For Each Cod As String In Casos
                Obj_Voz.caso = Cod.Trim
                If Obj_Voz.Asignar_Caso_Devuelto() <= 0 Then
                    If Warning = Nothing Then
                        Warning = "No han podido asignar los caso: " & Cod.Trim
                    Else
                        Warning = ", " & Cod.Trim
                    End If
                End If
            Next
            Return Warning
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Protected Sub Consultar_Agentes_Asignados_Dev()
    '    Try
    '        Dim Data = Json_Consulta_Agentes_Asignados_Dev()
    '        If TypeOf Data Is Object Then
    '            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Grid_Agent_Dev", "Data_Grid(" & Obj_Gestion_Datos.Object_To_JSON(Data) & ");", True)
    '        Else
    '            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Destroy", "$_$('#Grid_Agen_Dev').hide();", True)
    '        End If
    '    Catch ex As Exception
    '        Pnl_Message.CssClass = "alert alert-danger"
    '        Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
    '    End Try
    'End Sub
    '<System.Web.Services.WebMethod()>
    'Public Shared Function Json_Consulta_Agentes_Asignados_Dev()
    '    Try
    '        Dim Obj_Voz As New clsvoz
    '        Dim Obj_G_Data As New Cls_Gestion_Datos
    '        Obj_G_Data.DataSet = Obj_Voz.Consultar_Agentes_En_Escalamiento_Devueltos
    '        If Obj_G_Data.DataSet.Tables(0).Rows.Count > 0 Then
    '            Obj_G_Data.Grid_Config = "{'ShowFilter':false,'Editable':false,'Filterable':true,'MaxHeigth':150,'Container':'#Grid_Agen_Dev'}"
    '            Obj_G_Data.Grid_Keys = "{'Primary':'Id_Usuario'}"
    '            Obj_G_Data.Grid_Datafields = "[{'name':'Id_Usuario','type': 'string'},{'name':'Casos','type': 'number'}]"
    '            Obj_G_Data.Grid_Columns = "[{text: 'Usuario', datafield: 'Id_Usuario', filtertype: 'input'}, {text: 'Casos',  datafield: 'Casos', filtertype: 'number'}]"
    '            Return Obj_G_Data.Generate_Data_Grid()
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

End Class