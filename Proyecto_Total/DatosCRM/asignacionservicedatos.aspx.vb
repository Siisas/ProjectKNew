''''''''''''''datos


Imports System.IO
Public Class asignacionservicedatos
    Inherits System.Web.UI.Page
    Dim Obj_General As New clsgeneral
    Dim Obj_Gestion_Datos As New Cls_Gestion_Datos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Lbl_Mensage.Text = Nothing
            Pnl_Message.CssClass = Nothing
            Lbl_Cas_Dev.Text = Session("Count_Cas_Dev")
            If Not IsPostBack Then

                Cargar_Drl_Agent()
                Cargar_Drl_Agent_Dev()
                Session("Formulario") = "Asignación Escalamiento Service Datos"
                Cons_Agent_Asign()
                Lbl_Cas_Dev.Text = Count_Cas_Dev()
                'Agent_Asign_Dev()
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Cargar_Drl_Agent()
        With Drl_Agent
            .DataSource = Obj_General.consultaagenteescala
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
            .Items(0).Value = 0
        End With
        'Causal Escalamiento
        With drl_causal_escalamiento_service
            Obj_General.idusuario = 31
            .DataSource = Obj_General.consultadiagnostico
            .DataTextField = "detalle"
            .DataValueField = "idreg"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
        End With

    End Sub
    Protected Sub Cons_Agent_Asign()
        Try
            Dim objdatos As New clscrmdatos
            Session("Agentes_Asignados") = objdatos.consultaenprocescalaservdatos.Tables(0)
            If Session("Agentes_Asignados").rows.count > 0 Then
                GV_Agen_Casos.DataSource = Session("Agentes_Asignados")
                GV_Agen_Casos.DataBind()
            End If
            'Consultar cantidad de casos por asignar
            objdatos.consultapteasignartotalservdatos()
            lblcantidadtot.Text = objdatos.cantidad
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub GV_Agen_Casos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GV_Agen_Casos.PageIndexChanging
        Try
            If TypeOf Session("Agentes_Asignados") Is DataTable Then
                GV_Agen_Casos.PageIndex = e.NewPageIndex
                GV_Agen_Casos.DataSource = Session("Agentes_Asignados")
                GV_Agen_Casos.DataBind()
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Las seción caducado"
            End If

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Cons_Cas_Click(sender As Object, e As EventArgs) Handles Btn_Cons_Cas.Click
        Try
            Dim objdatos As New clscrmdatos
            If Txb_Num_Cas.Text = Nothing Then
                Pnl_Message.CssClass = "alert alert-warning"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite la cantidad de casos que desea asignar"
                Exit Sub
            End If
            If ((Txb_Fech_Ini.Text <> Nothing Or Txb_Fech_Fin.Text <> Nothing) And (Txb_Fech_Ini.Text = Nothing Or Txb_Fech_Fin.Text = Nothing)) Then
                Pnl_Message.CssClass = "alert alert-warning"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique que el rango de fecha sea correcto!"
                Exit Sub
            Else
                If Txb_Fech_Ini.Text <> Nothing And Txb_Fech_Fin.Text <> Nothing Then
                    If ((Date.Parse(Txb_Fech_Ini.Text)) > (Date.Parse(Txb_Fech_Fin.Text))) Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique que el rango de fecha sea correcto!"
                        Exit Sub
                    End If
                End If

            End If
            If Txb_Fech_Ini.Text <> Nothing And Txb_Fech_Fin.Text <> Nothing Then
                objdatos.fcini = Txb_Fech_Ini.Text
                objdatos.fcfin = Txb_Fech_Fin.Text
            End If
            If drl_causal_escalamiento_service.SelectedIndex <> 0 Then
                objdatos.Causal_escalam = drl_causal_escalamiento_service.SelectedItem.Text
            Else
                objdatos.Causal_escalam = ""
            End If

            objdatos.cantidad = Txb_Num_Cas.Text
            Session("Cons_Asig_Servis_Datos") = objdatos.Cons_Cas_Servis_Datos.Tables(0)
            If Session("Cons_Asig_Servis_Datos").Rows.Count > 0 Then
                Pnl_Grid_Casos.Visible = True
                dtggeneral.DataSource = Session("Cons_Asig_Servis_Datos")
                dtggeneral.DataBind()
                lblcantidad.Text = Session("Cons_Asig_Servis_Datos").Rows.Count
            Else
                Pnl_Message.CssClass = "alert alert-info"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-info-sign'></span> No se encontraron registros que coincidad con su criterio de búsqueda"
            End If

        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "P", "setTimeout('Pleg_Loading()', 250);", True)
        End Try
    End Sub
    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            If TypeOf Session("Cons_Asig_Servis_Datos") Is DataTable Then
                dtggeneral.PageIndex = e.NewPageIndex
                dtggeneral.DataSource = Session("Cons_Asig_Servis_Datos")
                dtggeneral.DataBind()
            Else
                Pnl_Message.CssClass = "alert alert-warning"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-info-warning'></span> Las seción caducado"
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Expor_Cas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Expor_Cas.Click
        Try
            Dim sw As New StringWriter()
            Dim hw As New HtmlTextWriter(sw)
            Dim tabla As New Table()
            Dim tr1 As New TableRow()
            Dim cell1 As New TableCell()
            Dim Val As Boolean = False
            Dim style As String = "<style> .textmode { mso-number-format:\@; } </style>"
            If Session("Cons_Asig_Servis_Datos").Rows.Count > 0 Then
                dtggeneral.AllowPaging = False
                dtggeneral.DataSource = Session("Cons_Asig_Servis_Datos").Tables(0)
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
                Pnl_Message.CssClass = "alert alert-info"
                Lbl_Mensage.Text = "<strong><span class='glyphicon glyphicon-info-sign'></span></strong> ¡No se encontraron registros para realizar la exportacion! "
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Asig_Cas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Asig_Cas.Click
        Dim actualizar As New clscrmdatos
        Try
            If Drl_Agent.SelectedItem.Text = "- Seleccione -" Then
                Pnl_Message.CssClass = "alert alert-warning"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el ingeniero al cual desea realizar la asignacion"
                Exit Sub
            End If
            actualizar.idusuarioasignado = Me.Drl_Agent.SelectedItem.Value
            actualizar.idusuario = CType(Session("permisos"), clsusuario).usuario '19/05/2016
            If Txb_Cod_Cas.Text <> Nothing Then
                actualizar.caso = Txb_Cod_Cas.Text
                actualizar.asignaescalaxcasoservdatos()
                Txb_Cod_Cas.Text = ""
                Pnl_Message.CssClass = "alert alert-success"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Asignación individual realizada con éxito"
            Else
                For Each row As GridViewRow In dtggeneral.Rows
                    actualizar.caso = Int64.Parse(row.Cells(0).Text)
                    actualizar.asignaescalaxcasoservdatos()
                Next
                Pnl_Message.CssClass = "alert alert-success"
                Lbl_Mensage.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Asignación masiva realizada con éxito"
            End If
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            lblcantidad.Text = ""
            Txb_Num_Cas.Text = ""
            Cons_Agent_Asign()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub

    '################################Devueltos####################################
    Protected Sub Cargar_Drl_Agent_Dev()
        With Drl_Agent_Dev
            .DataSource = Obj_General.consultaagenteescala
            .DataTextField = "nombreu"
            .DataValueField = "idusuario"
            .DataBind()
            .Items.Insert(0, "- Seleccione -")
            .Items(0).Value = 0
        End With
    End Sub
    Protected Sub Btn_Cons_Cas_Dev_Click(sender As Object, e As EventArgs) Handles Btn_Cons_Cas_Dev.Click
        Try
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "hide", "$_$('#Span_Count_Cas_Dev').html('');$_$('#Div_Count_Cas_Dev').hide();", True)
            Dim Obj_Datos As New clscrmdatos
            If Txb_Fech_Ini_Dev.Text <> Nothing And Txb_Fech_Fin_Dev.Text <> Nothing Then
                If ((Date.Parse(Txb_Fech_Ini_Dev.Text)) > (Date.Parse(Txb_Fech_Fin_Dev.Text))) Then
                    Pnl_Message.CssClass = "alert alert-warning"
                    Lbl_Mensage.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Verifique que el rango de fecha sea correcto!"
                    Exit Sub
                End If
            End If
            If Txb_Fech_Ini_Dev.Text <> Nothing Then
                Obj_Datos.Fecha_Ini = Date.Parse(Txb_Fech_Ini_Dev.Text)
            End If
            If Txb_Fech_Fin_Dev.Text <> Nothing Then
                Obj_Datos.Fecha_Fin = Date.Parse(Txb_Fech_Fin_Dev.Text)
            End If
            If Txb_Num_Cas_Dev.Text <> Nothing Then
                Obj_Datos.Max = Integer.Parse(Txb_Num_Cas_Dev.Text)
            End If
            Session("Filtro_Cons_Cas_Dev") = Obj_Datos
            Dim Data = Cons_Cas_Dev()
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
    Public Shared Function Cons_Cas_Dev()
        Try
            Dim Current As HttpContext = HttpContext.Current
            If TypeOf Current.Session("Filtro_Cons_Cas_Dev") Is Object Then
                Dim Obj_Datos As New clscrmdatos
                Dim Obj_G_Data As New Cls_Gestion_Datos
                Obj_Datos = Current.Session("Filtro_Cons_Cas_Dev")
                Obj_G_Data.DataSet = Obj_Datos.Cons_Cas_Servis_Datos_Dev
                If Obj_G_Data.DataSet.Tables(0).Rows.Count > 0 Then
                    Obj_G_Data.DataSet.Tables(0).Columns.Add("Check", Type.GetType("System.Boolean"))
                    For I As Integer = 0 To Obj_G_Data.DataSet.Tables(0).Rows.Count - 1
                        Obj_G_Data.DataSet.Tables(0).Rows(I).Item("Check") = False
                    Next
                    Obj_G_Data.Grid_Config = "{ShowFilter:true, Editable:true, Filterable:true, MaxHeigth:400, Container:'#Grid_Cas_Dev'}"
                    Obj_G_Data.Grid_Keys = "{'Primary':'Id_Caso'}"
                    Obj_G_Data.Grid_Datafields = "[{'name':'Check','type': 'bool'},{'name':'Id_Usuario_Dev','type': 'string'},{'name':'Id_Caso','type':'string'},{'name':'Fecha_Proc_Dev'},{'name':'Fecha_Reg_Service'},{'name':'Fecha_Asignado'},{'name':'Fecha_Reg'}]"
                    Obj_G_Data.Grid_Columns = "[{text:'Id Caso', datafield: 'Id_Caso', editable: false, filtertype: 'input'}, {text: 'Fecha Registro', datafield: 'Fecha_Reg', editable: false, cellsformat: 'yyyy/MM/dd HH:mm:ss', filtertype: 'range'}, {text: 'Fecha Registro Service', datafield: 'Fecha_Reg_Service', editable: false, cellsformat: 'yyyy/MM/dd HH:mm:ss', filtertype: 'range'}, {text: 'Fecha Asignacion', datafield: 'Fecha_Asignado', editable: false, cellsformat: 'yyyy/MM/dd HH:mm:ss', filtertype: 'range'}, {text: 'Fecha Devuelto', datafield: 'Fecha_Proc_Dev', editable: false, cellsformat: 'yyyy/MM/dd HH:mm:ss', filtertype: 'range'}, {text: 'Usuario Devuelve', datafield: 'Id_Usuario_Dev', editable: false, filtertype: 'input'}, {text:'Check',  datafield: 'Check',  threestatecheckbox: true,  editable: true,  columntype: 'checkbox', filtertype: 'checkedlist'}]"

                    Obj_G_Data.SubGrid_Config = "{ShowFilter:false, Editable:false, Filterable:true}"
                    Obj_G_Data.SubGrid_Keys = "{'Primary':'Id_Crm', 'Foreign':'Id_Caso'}"
                    Obj_G_Data.SubGrid_Datafields = "[{'name':'Id_Caso','type': 'number'},{'name':'Id_Crm','type': 'number'},{'name':'Fecha'},{'name':'Id_Usuario','type': 'string'},{'name':'Observacion','type': 'string'},{'name':'Tipificacion','type': 'string'}]"
                    Obj_G_Data.SubGrid_Columns = "[{'text':'Id Crm','datafield':'Id_Crm','editable':'false','filtertype':'number'},{'text':'Fecha','datafield':'Fecha','cellsformat':'yyyy/MM/dd HH:mm:ss','filtertype':'date','editable':false},{'text':'Usuario','datafield':'Id_Usuario','editable':false,'filtertype':'input'},{'text':'Observación','datafield':'Observacion','filterable':false,'editable':false},{'text':'Tipificación','datafield':'Tipificacion','editable':false,'filtertype':'checkedlist'}]"
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
    Public Shared Function Count_Cas_Dev()
        Try
            Dim Obj_Datos As New clscrmdatos
            Dim Current As HttpContext = HttpContext.Current
            Current.Session("Count_Cas_Dev") = Obj_Datos.Cons_Cas_Servis_Datos_Dev.Tables(0).rows.count
            Return Current.Session("Count_Cas_Dev")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Protected Sub Agent_Asign_Dev()
    '    Try
    '        Dim Data = Cons_Agent_Asign_Dev()
    '        If TypeOf Data Is Object Then
    '            Lbl_Cas_Dev.Text = Count_Cas_Dev()
    '            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Grid_Agent_Dev", "Data_Grid(" & Obj_Gestion_Datos.Object_To_JSON(Data) & ");", True)
    '        Else
    '            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Destroy", "$_$('#Grid_Cas_Dev').hide();", True)
    '        End If
    '    Catch ex As Exception
    '        Pnl_Message.CssClass = "alert alert-danger"
    '        Lbl_Mensage.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
    '    End Try
    'End Sub
    '<System.Web.Services.WebMethod()>
    'Public Shared Function Cons_Agent_Asign_Dev()
    '    Try
    '        Dim Obj_Datos As New clscrmdatos
    '        Dim Obj_G_Data As New Cls_Gestion_Datos
    '        Obj_G_Data.DataSet = Obj_Datos.Cons_En_Proces_Escala_Serv_Datos_Dev
    '        If Obj_G_Data.DataSet.Tables(0).Rows.Count > 0 Then
    '            Obj_G_Data.Grid_Config = "{'ShowFilter':false,'Editable':false,'Filterable':true,'MaxHeigth':150,'Container':'#Grid_Agent_Dev'}"
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
    <System.Web.Services.WebMethod()>
    Public Shared Function Asig_Cas_Dev(ByVal Id_Usuario As String, ByVal Casos As Object)
        Try
            Dim Current As HttpContext = HttpContext.Current
            Dim Obj_Cls_Datos As New clscrmdatos
            Obj_Cls_Datos.idusuarioasignado = Id_Usuario
            Obj_Cls_Datos.idusuario = CType(Current.Session("permisos"), clsusuario).usuario
            Dim Warning As String = Nothing
            For Each Cod As String In Casos
                Obj_Cls_Datos.caso = Cod.Trim
                If Obj_Cls_Datos.Asignar_Caso_Devuelto() <= 0 Then
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
End Class