Imports System.IO
Public Class Historial_Equipos
    Inherits System.Web.UI.Page
    Dim Obj_Inv As New clsInventario
    Dim Obj_G_Data As New Cls_Gestion_Datos
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Pnl_Message.CssClass = Nothing
        lblmsg.Text = Nothing
        Pnl_Alert_Asign.CssClass = Nothing
        Lbl_Alert_Asign.Text = Nothing
        If Not IsPostBack Then
            ''''' INICIO SEGURIDAD ACCESO URL '''''
            Dim objGeneral As New clsgeneral
            objGeneral.DtsSeguridad = Session("dtsSeguridad")
            objGeneral.Consulta_Proyecto_Seguridad()
            objGeneral.PaginaAcceso = "~" + Mid(Request.RawUrl, Integer.Parse(objGeneral.nombreentidad))
            objGeneral.idusuario = CType(Session("permisos"), clsusuario).usuario
            objGeneral.PermisosUrl()
            ''''' FIN SEGURIDAD ACCESO URL '''''    
            Session("Formulario") = "Historial Equipos"
            Session("Dts_Drl") = Obj_Inv.Cons_Drl_HIstorial_Equipo
            Cargar_Drl_Tipo_Com_R()
            Cargar_Drl_Fabricante_Com_R()
            Cargar_Drl_Estado_Com_C()
            Cargar_Drl_Tipo_Com_C()
            Cargar_Drl_Fabricante_Com_C()
            Cargar_Drl_Capacidad_Com_C()
            Cargar_Drl_Estado_Com_Asig()
            Cargar_Drl_Tipo_Com_Asig()
            Cargar_Drl_Fabricante_Com_Asig()
            Cargar_Drl_Capacidad_Com_Asig()
            Cargar_Drl_Estado_Equ_C()
            Cargar_Drl_Tipo_Equ_C()
            Cargar_Drl_Fabricante_Equ_C()
            Cargar_Drl_Estado_Com_Ac()
        End If
    End Sub
    'DRL Componentes
    Protected Sub Cargar_Drl_Estado_Com_C()
        With Drl_Estado_Com_C()
            .DataSource = Session("Dts_Drl").tables(0)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Estado_Com_Ac()
        Dim Dt As DataTable = Session("Dts_Drl").tables(0)
        Dt = Dt.Select("Descripcion Not Like 'Asignado'").CopyToDataTable()
        With Drl_Estado_Com_Ac()
            .DataSource = Dt
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Tipo_Com_R()
        With Drl_Tipo_Com_R()
            .DataSource = Session("Dts_Drl").tables(1)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Tipo_Com_C()
        With Drl_Tipo_Com_C()
            .DataSource = Session("Dts_Drl").tables(1)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Fabricante_Com_R()
        With Drl_Fabricante_Com_R()
            .DataSource = Session("Dts_Drl").tables(2)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Fabricante_Com_C()
        With Drl_Fabricante_Com_C()
            .DataSource = Session("Dts_Drl").tables(2)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Capacidad_Com_C()
        With Drl_Capacidad_Com_C()
            .DataSource = Session("Dts_Drl").tables(3)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Estado_Com_Asig()
        Dim Dt As DataTable = Session("Dts_Drl").tables(0)
        Dt = Dt.Select("Descripcion Not Like 'Asignado' And Descripcion Not Like 'Dañado' And Descripcion Not Like 'Baja'").CopyToDataTable()
        With Drl_Estado_Com_Asig()
            .DataSource = Dt
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Tipo_Com_Asig()
        With Drl_Tipo_Com_Asig()
            .DataSource = Session("Dts_Drl").tables(1)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Fabricante_Com_Asig()
        With Drl_Fabricante_Com_Asig()
            .DataSource = Session("Dts_Drl").tables(2)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Capacidad_Com_Asig()
        With Drl_Capacidad_Com_Asig()
            .DataSource = Session("Dts_Drl").tables(3)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Estado_Equ_C()
        With Drl_Estado_Equ_C()
            .DataSource = Session("Dts_Drl").tables(4)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Tipo_Equ_C()
        With Drl_Tipo_Equ_C()
            .DataSource = Session("Dts_Drl").tables(5)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    Protected Sub Cargar_Drl_Fabricante_Equ_C()
        With Drl_Fabricante_Equ_C()
            .DataSource = Session("Dts_Drl").tables(6)
            .DataTextField = "Descripcion"
            .DataValueField = "Cod"
            .DataBind()
        End With
    End Sub
    '########consulta de equipos###########
    Protected Sub Btn_Consultar_Equ_Click(sender As Object, e As EventArgs) Handles Btn_Consultar_Equ.Click
        Try
            Obj_Inv.Marca = Drl_Fabricante_Equ_C.SelectedValue
            Obj_Inv.Cod_Tipo = Drl_Tipo_Equ_C.SelectedValue
            Obj_Inv.Estado = Drl_Estado_Equ_C.SelectedValue
            Obj_Inv.Referencia = Txb_Referencia_Equ_C.Text
            Obj_Inv.Serial = Txb_Serial_Equ_C.Text
            Obj_Inv.Serial_Kamilion = Txb_SerialK_Equ_C.Text

            Session("Filtro_Equipos") = Obj_Inv
            Dim Data = Consultar_Equipos()
            If TypeOf Data Is Object Then
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Grid", "Data_Grid(" & Obj_G_Data.Object_To_JSON(Data) & ");", True)
            Else
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> No se encontraron equipos que coincidan con su criterio de búsqueda"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Destroy", "$_$('#Grid_Equ_C').hide();", True)
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "show_loding", "PlegDes_Dinamico('#Desp_Loading', 'show', 'puff', 500, '');", True)
        End Try
    End Sub
    <System.Web.Services.WebMethod()> _
    Public Shared Function Consultar_Equipos()
        Try
            System.Threading.Thread.Sleep(500)
            Dim Obj_G_Data As New Cls_Gestion_Datos
            Dim Obj_Inv As New clsInventario
            Dim Current As HttpContext = HttpContext.Current
            Obj_Inv = Current.Session("Filtro_Equipos")
            Obj_G_Data.DataSet = Obj_Inv.Cons_Equipos_Componentes_Historial()
            If Obj_G_Data.DataSet.Tables(0).Rows.Count > 0 Then
                Obj_G_Data.Grid_Config = "{ShowFilter:true,Editable:false,Filterable:true,MaxHeigth:400,Container:'#Grid_Equ_C'}"
                Obj_G_Data.Grid_Keys = "{'Primary':'Cod'}"
                Obj_G_Data.Grid_Datafields = "[{name:'Cod', type:'string'},{name:'Tipo',type:'string' },{name:'Fabricante', type:'string'},{name:'Referencia', type:'string'},{name:'Serial', type:'string'},{name:'Serial_Kamilion', type:'string'}, {name:'Estado', type:'string'}]"
                Obj_G_Data.Grid_Columns = "[{text:'Tipo', datafield:'Tipo', filtertype:'checkedlist', width:100}, {text:'Fabricante', datafield:'Fabricante', filtertype:'checkedlist'}, {text:'Referencia', datafield:'Referencia', filtertype:'input'}, {text:'Serial', datafield:'Serial', filtertype:'input'}, {text:'Serial Kamilion', datafield:'Serial_Kamilion', filtertype:'input'}, {text:'Estado', datafield:'Estado', filtertype:'checkedlist', width:100}, {text:'Asignar Componentes', datafield:'Cod', filterable:false, width:80, type:'button', onclick:'Desp_Asignar_Com', textool:'Asignar'}]"

                Obj_G_Data.SubGrid_Config = "{Filterable:true, ShowFilter:true, Editable:false}"
                Obj_G_Data.SubGrid_Keys = "{Primary:'Cod', Foreign:'Cod_Equipo_Fk_Cod_Inv'}"
                Obj_G_Data.SubGrid_Datafields = "[{name:'Cod'}, {name:'Cod_Equipo_Fk_Cod_Inv', type:'string'}, {name:'Tipo', type:'string'}, {name:'Fabricante', type:'string'}, {name:'Referencia', type:'string'}, {name:'Capacidad', type:'string'}, {name:'Serial', type:'string'}, {name:'Descripcion', type:'string'}, {name:'Estado', type:'string'}]"
                Obj_G_Data.SubGrid_Columns = "[{text:'Tipo', datafield:'Tipo', filtertype:'checkedlist'}, {text:'Fabricante', datafield:'Fabricante', filtertype:'checkedlist'}, {text:'Referencia', datafield:'Referencia', filtertype:'checkedlist'}, {text:'Capacidad', datafield:'Capacidad', filtertype:'input', filtertype:'checkedlist'}, {text:'Serial', datafield:'Serial', filtertype:'input'}, {text:'Descripcion', datafield:'Descripcion', filterable:false}, {text:'Estado', datafield:'Estado', filtertype:'checkedlist'}, {text:'Liberar', datafield:'Cod', filterable:false, width:80, type:'button', onclick:'Liberar_Com', textool:'Liberar'}]"

                Return Obj_G_Data.Generate_Data_Grid()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    '#########registrar componente############
    Protected Sub Btn_Registrar_Click(sender As Object, e As EventArgs) Handles Btn_Registrar.Click
        Try
            System.Threading.Thread.Sleep(500)
            Obj_Inv.Cod_Fabricante = Drl_Fabricante_Com_R.SelectedValue
            Obj_Inv.Cod_Tipo = Drl_Tipo_Com_R.SelectedValue
            Obj_Inv.Capacidad = Txb_Capacidad_Com_R.Text
            Obj_Inv.Referencia = Txb_Referencia_Com_R.Text
            Obj_Inv.Serial = Txb_Serial_Com_R.Text
            Obj_Inv.Descripcion = Txb_Descripcion_Com_R.Text
            Obj_Inv.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
            Obj_Inv.Registrar_Componente()
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-ok-circle'></span></strong> El componente se ha registrado exitosamente"
            Pnl_Message.CssClass = "alert alert-success"
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            If ex.Message.Contains("UNIQUE KEY") Then
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> El serial del componente ya se encuentra registrado!"
            Else
                lblmsg.Text = ex.Message
            End If
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "show_loding", "PlegDes_Dinamico('#Desp_Loading', 'show', 'puff', 500, '');", True)
        End Try

    End Sub
    'carga masiva de componentes
    Protected Sub Btn_Carga_File_Com_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Carga_File_Com.Click
        Try
            Dim dt As New DataTable
            Dim ObjExcel As New clsInventario
            If dt Is Nothing And Path.GetExtension(File_Excel_Com.FileName).ToLower() <> ".xlsx" Then
            Else
                File_Excel_Com.SaveAs(Server.MapPath("~/Documento/" & Path.GetFileName(File_Excel_Com.FileName)))
                ObjExcel.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Documento/" & Path.GetFileName(File_Excel_Com.FileName)) & ";Extended Properties=Excel 12.0;"
                ObjExcel.Id_Usuario = CType(Session("permisos"), clsusuario).usuario
                Dim Val = ObjExcel.Xls_Componentes_To_Sql()
                If Val = Nothing Then
                    lblmsg.Text = "<strong><span class='glyphicon glyphicon-ok-circle'></span></strong> El registro masivo se completó exitosamente"
                    Pnl_Message.CssClass = "alert alert-success"
                Else
                    Pnl_Message.CssClass = "alert alert-danger"
                    lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> " & Val
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> " & ex.Message
        End Try
    End Sub
    'consulta de componentes
    Protected Sub Btn_Consultar_Com_Click(sender As Object, e As EventArgs) Handles Btn_Consultar_Com.Click
        Try
            System.Threading.Thread.Sleep(500)
            Obj_Inv.Cod_Fabricante = Drl_Fabricante_Com_C.SelectedValue
            Obj_Inv.Cod_Tipo = Drl_Tipo_Com_C.SelectedValue
            Obj_Inv.Cod_Estado = Drl_Estado_Com_C.SelectedValue
            Obj_Inv.Capacidad = Drl_Capacidad_Com_C.SelectedValue
            Obj_Inv.Referencia = Txb_Referencia_Com_C.Text
            Obj_Inv.Serial = Txb_Serial_Com_C.Text
            Session("Filtro_Componentes") = Obj_Inv
            Dim Data = Consultar_Componentes()
            If TypeOf Data Is Object Then
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Grid", "Data_Grid(" & Obj_G_Data.Object_To_JSON(Data) & ");", True)
            Else
                Pnl_Message.CssClass = "alert alert-danger"
                lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> No se encontraron componentes que coincidan con su criterio de búsqueda"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Destroy", "$_$('#Grid_Com_C').hide();", True)
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "show_loding", "PlegDes_Dinamico('#Desp_Loading', 'show', 'puff', 500, '');", True)
        End Try
    End Sub
    <System.Web.Services.WebMethod()> _
    Public Shared Function Consultar_Componentes()
        Try
            Dim Obj_G_Data As New Cls_Gestion_Datos
            Dim Obj_Inv As New clsInventario
            Dim Current As HttpContext = HttpContext.Current
            Obj_Inv = Current.Session("Filtro_Componentes")
            Obj_G_Data.DataSet = Obj_Inv.Consultar_Componentes(True)
            If Obj_G_Data.DataSet.Tables(0).Rows.Count > 0 Then
                Obj_G_Data.Grid_Config = "{ShowFilter:true,Editable:false,Filterable:true,MaxHeigth:400,Container:'#Grid_Com_C'}"
                Obj_G_Data.Grid_Keys = "{Primary:'Cod'}"
                Obj_G_Data.Grid_Datafields = "[{name:'Cod'}, {name:'Cod_Ac', type:'string'}, {name:'Tipo', type:'string'}, {name:'Fabricante', type:'string'}, {name:'Referencia', type:'string'}, {name:'Capacidad', type:'string'}, {name:'Serial', type:'string'}, {name:'Descripcion', type:'string'}, {name:'Estado', type:'string'}]"
                Obj_G_Data.Grid_Columns = "[{text:'Tipo', datafield:'Tipo', filtertype:'checkedlist'}, {text:'Fabricante', datafield:'Fabricante',  filtertype:'checkedlist'}, {text:'Referencia', datafield:'Referencia', filtertype:'input'}, {text:'Capacidad', datafield:'Capacidad', filtertype:'input'}, {text:'Serial', datafield:'Serial', filtertype:'input'}, {text:'Descripcion', datafield:'Descripcion', filterable:false}, {text:'Estado', datafield:'Estado', filtertype:'checkedlist'}, {text:'Actualizar Componente', datafield:'Cod_Ac', width:80, type:'button', onclick:'Actualizar_Com', textool:'Actualizar', filterable:false}, {text:'Liberar Componente', datafield:'Cod', width:80, type:'button', filterable:false, onclick:'Liberar_Com', textool:'Liberar'}]"

                Obj_G_Data.SubGrid_Config = "{ShowFilter:true, Editable:false, Filterable:true}"
                Obj_G_Data.SubGrid_Keys = "{Primary:'Cod_Com', Foreign:'Cod_Com'}"

                Obj_G_Data.SubGrid_Datafields = "[{name:'Cod_Com'}, {name:'Fecha_Asignacion'}, {name:'Usuario_Asigna', type:'string'}, {name:'Fecha_Retiro'}, {name:'Usuario_Retira', type:'string'}, {name:'Observacion_Aigna', type:'string'}, {name:'Observacion_Retira', type:'string'}, {name:'Serial_Equi', type:'string'}, {name:'Serial_K_Equi', type:'string'}, {name:'Tipo_Equi', type:'string'}]"
                Obj_G_Data.SubGrid_Columns = "[{text:'Asigna', datafield:'Usuario_Asigna',filtertype:'input'}, {text:'Fecha de Asignacion', datafield:'Fecha_Asignacion', cellsformat:'yyyy/MM/dd HH: mm: ss', filtertype:'range'}, {text:'Observación de Asignacion', datafield:'Observacion_Aigna', filterable:false}, {text:'Equipo', datafield:'Tipo_Equi',filtertype:'checkedlist'}, {text:'Serial Equipo', datafield:'Serial_Equi',filtertype:'input'}, {text:'Serial K Equipo', datafield:'Serial_K_Equi',filtertype:'input'}, {text:'Usuario Libera', datafield:'Usuario_Retira',filtertype:'input'}, {text:'Fecha de liberación', datafield:'Fecha_Retiro', cellsformat:'yyyy/MM/dd HH: mm: ss', filtertype:'range'}, {text:'Observación de Liberación', datafield:'Observacion_Retira', filterable:false}]"

                Return Obj_G_Data.Generate_Data_Grid()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Protected Sub Btn_Consultar_Com_Asig_Click(sender As Object, e As EventArgs) Handles Btn_Consultar_Com_Asig.Click
        Try
            System.Threading.Thread.Sleep(500)
            Obj_Inv.Cod_Fabricante = Drl_Fabricante_Com_Asig.SelectedValue
            Obj_Inv.Cod_Tipo = Drl_Tipo_Com_Asig.SelectedValue
            Obj_Inv.Cod_Estado = Drl_Estado_Com_Asig.SelectedValue
            Obj_Inv.Capacidad = Drl_Capacidad_Com_Asig.SelectedValue
            Obj_Inv.Referencia = Txb_Referencia_Com_Asig.Text
            Obj_Inv.Serial = Txb_Serial_Com_Asig.Text
            Session("Cons_Com_Asig") = Obj_Inv
            Dim Data = Consultar_Componentes_Asign()
            If TypeOf Data Is Object Then
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Grid", "Data_Grid(" & Obj_G_Data.Object_To_JSON(Data) & ");", True)
            Else
                Pnl_Alert_Asign.CssClass = "alert alert-danger"
                Lbl_Alert_Asign.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> No se encontraron componentes que coincidan con su criterio de búsqueda"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "Destroy", "$_$('#Grid_Com_Asig').hide();", True)
            End If
        Catch ex As Exception
            Pnl_Alert_Asign.CssClass = "Message alert alert-danger"
            Lbl_Alert_Asign.Text = "<strong><span class='glyphicon glyphicon-warning-sign'></span></strong> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "show_loding", "PlegDes_Dinamico('#Desp_Loading', 'show', 'puff', 500, '');", True)
        End Try
    End Sub
    <System.Web.Services.WebMethod()> _
    Public Shared Function Consultar_Componentes_Asign()
        Try
            Dim Obj_G_Data As New Cls_Gestion_Datos
            Dim Obj_Inv As New clsInventario
            Dim Current As HttpContext = HttpContext.Current
            Obj_Inv = Current.Session("Cons_Com_Asig")
            Obj_G_Data.DataSet = Obj_Inv.Consultar_Componentes(False)
            If Obj_G_Data.DataSet.Tables(0).Rows.Count > 0 Then
                Obj_G_Data.DataSet.Tables(0).Columns.Add("Check", Type.GetType("System.Boolean"))
                For I As Integer = 0 To Obj_G_Data.DataSet.Tables(0).Rows.Count - 1
                    Obj_G_Data.DataSet.Tables(0).Rows(I).Item("Check") = False
                Next
                Obj_G_Data.Grid_Config = "{'ShowFilter':true,'Editable':true,'Filterable':true,'MaxHeigth':350,'Container':'#Grid_Com_Asig'}"
                Obj_G_Data.Grid_Keys = "{'Primary':'Cod'}"
                Obj_G_Data.Grid_Datafields = "[{name:'Cod', type:'number'}, {name:'Tipo', type:'string'}, {name:'Fabricante', type:'string'}, {name:'Referencia', type:'string'}, {name:'Capacidad', type:'string'}, {name:'Serial', type:'string'}, {name:'Descripcion', type:'string'}, {name:'Estado', type:'string'}, {name:'Check', type:'bool'}]"
                Obj_G_Data.Grid_Columns = "[{text:'Tipo', datafield:'Tipo', filtertype:'checkedlist', editable:false}, {text:'Fabricante', datafield:'Fabricante', filtertype:'checkedlist', editable:false}, {text:'Referencia', datafield:'Referencia', filtertype:'input', editable:false}, {text:'Capacidad', datafield:'Capacidad', filtertype:'input', editable:false}, {text:'Serial', datafield:'Serial', filtertype:'input', editable:false}, {text:'Descripcion', datafield:'Descripcion', filterable:false, editable:false}, {text:'Estado', datafield:'Estado', filtertype:'checkedlist', editable:false}, {text:'Seleccionar', datafield:'Check', threestatecheckbox:true, columntype:'checkbox', width:100, filtertype:'checkedlist'}]"
                Return Obj_G_Data.Generate_Data_Grid()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <System.Web.Services.WebMethod()> _
    Public Shared Function Asignar_Componentes(ByVal Equipo As Integer, ByVal Componentes As Object, ByVal Observacion As String)
        Try
            Dim Current As HttpContext = HttpContext.Current
            Dim Obj_Inv As New clsInventario
            Obj_Inv.Id_Usuario = CType(Current.Session("permisos"), clsusuario).usuario
            Obj_Inv.Cod_Equipo = Equipo
            Obj_Inv.Descripcion = Observacion
            Dim Val = Nothing
            For Each Serial As String In Componentes
                If Val = Nothing Then
                    Obj_Inv.Serial = Serial
                    If Obj_Inv.Val_Asign_Componente().Tables(0).Rows.Count > 0 Then
                        Val = Serial
                    End If
                End If
            Next
            If Val = Nothing Then
                For Each Serial As String In Componentes
                    Obj_Inv.Serial = Serial
                    Obj_Inv.Asignar_Componente()
                Next
                Return Nothing
            Else
                Return "Asegurese de que el componente con el serial " & Chr(34) & Val & Chr(34) & " está libre y en buenas condiciones!"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Liberar componentes
    <System.Web.Services.WebMethod()> _
    Public Shared Function Liberar_Componente(ByVal Cod As Integer, ByVal Observacion As String)
        Try
            Dim Obj_Inv As New clsInventario
            Obj_Inv.Cod_Componente = Cod
            Obj_Inv.Observacion = Observacion
            Dim Current As HttpContext = HttpContext.Current
            Obj_Inv.Id_Usuario = CType(Current.Session("Permisos"), clsusuario).usuario
            If Obj_Inv.Liberar_Componente() > 0 Then
                Return Nothing
            Else
                Return "No es posible liberar el componente, es probable que no se encuentre asignado a ningún equipo"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <System.Web.Services.WebMethod()> _
    Public Shared Function Actualizar_Componente(ByVal Cod As Integer, ByVal Cod_Estado As Integer)
        Try
            Dim Obj_Inv As New clsInventario
            Obj_Inv.Cod_Componente = Cod
            Obj_Inv.Cod_Estado = Cod_Estado
            Dim int = Obj_Inv.Actualizar_Componente()
            If int > 0 Then
                Return Nothing
            Else
                Return "No se logró actualizar el componente"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Protected Sub Btn_Clear_Com_Reg_Click(sender As Object, e As EventArgs) Handles Btn_Clear_Com_Reg.Click
        Cargar_Drl_Tipo_Com_R()
        Txb_Referencia_Com_R.Text = Nothing
        Txb_Serial_Com_R = Nothing
        Cargar_Drl_Fabricante_Com_R()
        Txb_Capacidad_Com_R.Text = Nothing
        Txb_Descripcion_Com_R.Text = Nothing
    End Sub
    Protected Sub Btn_Clear_Com_Con_Click(sender As Object, e As EventArgs) Handles Btn_Clear_Com_Con.Click
        Cargar_Drl_Tipo_Com_C()
        Txb_Referencia_Com_C.Text = Nothing
        Txb_Serial_Com_C.Text = Nothing
        Cargar_Drl_Fabricante_Com_C()
        Cargar_Drl_Capacidad_Com_C()
        Cargar_Drl_Estado_Com_C()
    End Sub
    Protected Sub Btn_Clear_Equ_Con_Click(sender As Object, e As EventArgs) Handles Btn_Clear_Equ_Con.Click
        Cargar_Drl_Tipo_Equ_C()
        Txb_Referencia_Equ_C.Text = Nothing
        Txb_Serial_Equ_C.Text = Nothing
        Cargar_Drl_Fabricante_Equ_C()
        Txb_SerialK_Equ_C.Text = Nothing
        Txb_Empresa_Equ_C.Text = Nothing
        Cargar_Drl_Estado_Equ_C()
    End Sub
    Protected Sub Btn_Clear_Com_Con_Asig_Click(sender As Object, e As EventArgs) Handles Btn_Clear_Com_Con_Asig.Click
        Cargar_Drl_Tipo_Com_Asig()
        Txb_Referencia_Com_Asig.Text = Nothing
        Txb_Serial_Com_Asig.Text = Nothing
        Cargar_Drl_Fabricante_Com_Asig()
        Cargar_Drl_Capacidad_Com_Asig()
        Cargar_Drl_Estado_Com_Asig()
    End Sub
End Class
