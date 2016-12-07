Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Public Class RegDatosUsuCarga
    Inherits System.Web.UI.Page
    Dim ObjRRHH As New clsrrhh
    Dim dt As DataTable
    Dim dt2 As DataTable
    Dim dt3 As DataTable
    Dim valor As Int16
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
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

    Protected Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Try

            lblmsg.Text = ""
            lblcantidad.Text = ""
            If Session("valor") = 1 Then
                dt = Session("dtsB")
                dt2 = Session("dtsA")
            End If
            If dt Is Nothing And Path.GetExtension(FileArchivo.FileName).ToLower() <> ".xlsx" Then
                lblmsg.Text = "El formato no es correcto"
                Exit Sub
            End If
            lblmsg.Text = ""
            If dt Is Nothing Then
                FileArchivo.SaveAs(Server.MapPath("~/Usuarios/" & Path.GetFileName(FileArchivo.FileName)))
                Session("Ruta") = Server.MapPath("~/Usuarios/" & Path.GetFileName(FileArchivo.FileName))
                ObjRRHH.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Usuarios/" & Path.GetFileName(FileArchivo.FileName)) & ";Extended Properties=Excel 12.0;"
                ObjRRHH.idusuario = lblusuario.Text
                ObjRRHH.Validacion = 2
                ObjRRHH.CargaUsuarios()
                ObjRRHH.Validacion = 2
                ObjRRHH.CargaUsuarios1()
                ObjRRHH.Validacion = 2
                ObjRRHH.CargaUsuariosFormato()
                lblcantidad.Text = ObjRRHH.cantidad
            Else
                ObjRRHH.idusuario = lblusuario.Text
                ObjRRHH.eDtUsuariosEcxel = dt2
                ObjRRHH.CargaUsuarios()
                ObjRRHH.DtPlatafroma = dt
                ObjRRHH.CargaUsuarios1()
                ObjRRHH.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Session("Ruta") + ";Extended Properties=Excel 12.0;"
                ObjRRHH.Validacion = 1
                dt3 = ObjRRHH.CargaUsuariosFormato()
                ObjRRHH.dtformatoU = dt3
                ObjRRHH.Validacion = Nothing
                ObjRRHH.CargaUsuariosFormato()
                lblcantidad.Text = ObjRRHH.cantidad
                LblCantidad2.Text = ""
            End If
            dt = Nothing
            Session("dtsB") = dt
            dt3 = dt
            Session("dtsA") = dt
            lblmsg.Text = "Registro de credenciales masivo realizado con exito "
            DtgVisualizar.DataSource = Nothing
            DtgVisualizar.DataBind()
            File.Delete(Session("Ruta"))
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub
    Protected Sub BtnVer2_Click(sender As Object, e As EventArgs) Handles BtnVer2.Click
        Try

            If dt Is Nothing And Path.GetExtension(FileArchivo.FileName).ToLower() <> ".xlsx" Then
                lblmsg.Text = "El formato no es correcto"
                Exit Sub
            End If


            If Path.GetExtension(FileArchivo.FileName).ToLower() <> ".xlsx" Then
                lblmsg.Text = "El formato no es correcto"
                LblCantidad2.Text = ""
                DtgVisualizar.DataSource = Nothing
                DtgVisualizar.DataBind()
                Exit Sub
            End If
            lblmsg.Text = ""
            lblcantidad.Text = ""
            FileArchivo.SaveAs(Server.MapPath("~/Usuarios/" & Path.GetFileName(FileArchivo.FileName)))
            Session("Ruta") = Server.MapPath("~/Usuarios/" & Path.GetFileName(FileArchivo.FileName))
            ObjRRHH.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Usuarios/" & Path.GetFileName(FileArchivo.FileName)) & ";Extended Properties=Excel 12.0;"
            ObjRRHH.idusuario = lblusuario.Text
            ObjRRHH.Validacion = 1
            dt2 = ObjRRHH.CargaUsuarios()
            ObjRRHH.Validacion = 1
            dt = ObjRRHH.CargaUsuarios1()

            Session("dtsB") = dt
            Session("dtsA") = dt2

            If CheckBoxActualizacion.Checked = True Then
                ObjRRHH.Validacion = 1
                BtnImportar.Visible = False
                BtnActualizar.Visible = True
            End If
            Session("dtsPaginacion") = ObjRRHH.CargaExcel()
            DtgVisualizar.DataSource = Session("dtsPaginacion")
            DtgVisualizar.DataBind()
            LblCantidad2.Text = ObjRRHH.cantidad
            Session("valor") = 1
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles DtgVisualizar.PageIndexChanging
        Try
            DtgVisualizar.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            DtgVisualizar.DataSource = Session("dtsPaginacion")
            DtgVisualizar.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click


        For Each row As GridViewRow In DtgVisualizar.Rows
            ObjRRHH.Codigo_Atuliza = CInt(row.Cells(0).Text)
            ObjRRHH.codigo = row.Cells(1).Text
            ObjRRHH.Plataforma = row.Cells(2).Text
            ObjRRHH.Usuario_Plataforma = row.Cells(3).Text
            ObjRRHH.Password_Plataforma = row.Cells(4).Text
            ObjRRHH.Estado_Plataforma = row.Cells(5).Text
            If row.Cells(6).Text <> "&nbsp;" Then
                ObjRRHH.Formato = row.Cells(6).Text
            Else
                ObjRRHH.Formato = Nothing
            End If
            ObjRRHH.idusuario = lblusuario.Text
            ObjRRHH.Validacion = 2
            ObjRRHH.Actualizar_Plataforma()
        Next

        DtgVisualizar.DataSource = Nothing
        DtgVisualizar.DataBind()
        CheckBoxActualizacion.Checked = False
        LblCantidad2.Text = ""
        lblmsg.Text = "Actualizacion de credenciales masivo realizado con exito "
    End Sub
End Class