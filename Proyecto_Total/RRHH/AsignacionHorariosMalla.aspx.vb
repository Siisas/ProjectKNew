Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO

Public Class AsignacionHorariosMalla
    Inherits System.Web.UI.Page
    Dim ObjRRHH As New clsrrhh
    Dim dt As DataTable
    Dim valor As Int16
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Registro de Entrada y Salida"
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
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
   
    Protected Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Try

            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            lblcantidad.Text = ""
            If Session("valor") = 1 Then
                dt = Session("dtsB")
            End If
            If dt Is Nothing And Path.GetExtension(FileArchivo.FileName).ToLower() <> ".xlsx" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El formato no es correcto"
                Exit Sub
            End If
            If dt Is Nothing Then
                FileArchivo.SaveAs(Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName)))
                Session("Ruta") = Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName))
                ObjRRHH.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName)) & ";Extended Properties=Excel 12.0;"
                ObjRRHH.idusuario = CType(Session("permisos"), clsusuario).usuario
                ObjRRHH.Validacion = 2
                ObjRRHH.Malla()
                lblcantidad.Text = ObjRRHH.cantidad
            Else
                ObjRRHH.Fc_Dtecxel = dt
                ObjRRHH.Malla()
                lblcantidad.Text = ObjRRHH.cantidad
                LblCantidad2.Text = ""

            End If
            dt = Nothing
            Session("dtsB") = dt
            Pnl_Message.CssClass = "alert alert-success"
            lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Registro de malla masivo realizado con exito "
            DtgVisualizar.DataSource = Nothing
            DtgVisualizar.DataBind()
            File.Delete(Session("Ruta"))
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try

    End Sub
    Protected Sub BtnVer2_Click(sender As Object, e As EventArgs) Handles BtnVer2.Click
        Try

            If dt Is Nothing And Path.GetExtension(FileArchivo.FileName).ToLower() <> ".xlsx" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El formato no es correcto"
                Exit Sub
            End If


            If Path.GetExtension(FileArchivo.FileName).ToLower() <> ".xlsx" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El formato no es correcto"
                Exit Sub
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            lblcantidad.Text = ""
            FileArchivo.SaveAs(Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName)))
            Session("Ruta") = Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName))
            ObjRRHH.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Documento/" & Path.GetFileName(FileArchivo.FileName)) & ";Extended Properties=Excel 12.0;"
            ObjRRHH.idusuario = CType(Session("permisos"), clsusuario).usuario
            ObjRRHH.Validacion = 1
            dt = ObjRRHH.Malla()
            Session("dtsB") = dt
            Pnl_Dtg_Desarrollos.Visible = True
            DtgVisualizar.DataSource = Session("dtsB")
            DtgVisualizar.DataBind()
            'dt = Session("dtsB")
            LblCantidad2.Text = ObjRRHH.cantidad
            Session("valor") = 1
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub

    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DtgVisualizar.PageIndexChanging
        Try
            DtgVisualizar.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            DtgVisualizar.DataSource = Session("dtsB")
            DtgVisualizar.DataBind()
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span> Se presento error: " & ex.Message
        End Try
    End Sub
End Class