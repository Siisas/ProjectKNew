Imports System.IO

Public Class InformeBarriosVoz
    Inherits System.Web.UI.Page
    Dim ObjInforme As New clsInformes

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
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
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub ConsultarBarrioVozPaso1()
        Try

            Dim dts As New DataSet
            ObjInforme.Fcini = txtFecha_Inicio.Text
            ObjInforme.Fcfin = txtFecha_Fin.Text
            lblFcini.Text = ObjInforme.Fcini
            lblFcfin.Text = ObjInforme.Fcfin
            EliminarRegistros()
            GridView1.DataSource = Nothing
            GridView1.DataBind()
            lbltotal.Text = Nothing
            ObjInforme.Cunsulta_Informe_Barrios_Voz()

            txtFecha_Inicio.Text = ""
            txtFecha_Fin.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    Public Sub ConsultarBarrioVozPaso2()
        Try
            txtFecha_Inicio.Text = lblFcini.Text
            txtFecha_Fin.Text = lblFcfin.Text

            Dim dts As New DataSet
            ObjInforme.Fcini = txtFecha_Inicio.Text
            ObjInforme.Fcfin = txtFecha_Fin.Text
            ObjInforme.Validacionn = 1
            ObjInforme.Inserta_Informe_Barrios_Voz()
            txtFecha_Inicio.Text = ""
            txtFecha_Fin.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    Public Sub GenerarBarrioVozGenerar()
        Try
            Dim dts As New DataSet
            txtFecha_Inicio.Text = lblFcini.Text
            txtFecha_Fin.Text = lblFcfin.Text
            ObjInforme.Fcini = txtFecha_Inicio.Text
            ObjInforme.Fcfin = txtFecha_Fin.Text
            For i = 2 To 5
                If i = i Then
                    ObjInforme.Validacionn = i
                    ObjInforme.Inserta_Informe_Barrios_Voz()
                End If
            Next
            txtFecha_Inicio.Text = ""
            txtFecha_Fin.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    'CARGAR DATA GRIDVIEW
    Public Sub Cargardatagrid()
        Try
            GridView1.DataSource = ObjInforme.CuentaRegistros()
            GridView1.DataBind()
            lbltotal.Text = ObjInforme.Cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub

    Public Sub EliminarRegistros()
        Try
            Dim dts As New DataSet
            ObjInforme.Validacionn = 6
            ObjInforme.Inserta_Informe_Barrios_Voz()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub
    Protected Sub Paso1_Click(sender As Object, e As EventArgs) Handles Paso1.Click
        Try
            If txtFecha_Inicio.Text = Nothing Then
                lblmsg.Text = "Ingrese una fecha inicial para consultar"
                Exit Sub
            End If
            If txtFecha_Fin.Text = Nothing Then
                lblmsg.Text = "Ingrese una fecha final para consultar"
                Exit Sub
            End If
            If CDate(txtFecha_Inicio.Text) > CDate(txtFecha_Fin.Text) Then
                lblmsg.Text = "La fecha inicial es mayor que la fecha final del período"
                txtFecha_Inicio.Text = ""
                txtFecha_Fin.Text = ""
                Exit Sub
            End If
            lblmsg.Text = ""

            ConsultarBarrioVozPaso1()
            Paso1.Visible = False
            Exportar.Visible = False
            Paso2.Visible = True

        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    Protected Sub Paso2_Click(sender As Object, e As EventArgs) Handles Paso2.Click
        Try
            ConsultarBarrioVozPaso2()
            Paso2.Visible = False
            Generar.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub

    Protected Sub Generar_Click(sender As Object, e As EventArgs) Handles Generar.Click
        Try
            GenerarBarrioVozGenerar()
            Generar.Visible = False
            Consultar.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    Protected Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        Try
            Cargardatagrid()
            Consultar.Visible = False
            Paso1.Visible = True
            Exportar.Visible = True
        Catch ex As Exception
            lblmsg.Text = "Se presento error; " + ex.Message
        End Try
    End Sub
    'EXPORTAR A EXCEL
    Sub crearexcel()
        Try

            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"


            pagina.EnableEventValidation = False
            pagina.DesignerInitialize()
            pagina.Controls.Add(form)
            GridView2.Visible = True
            form.Controls.Add(GridView2)
            pagina.RenderControl(htw)
            Response.Clear()
            Response.Buffer = True

            Response.ContentType = "application/vnd.ms-excel"
            Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
            Response.AddHeader("Content-Disposition", "attachment;filename=Informe_Barrios_Voz.xls")
            Response.Charset = "UTF-8"
            Response.Write(strStyle)
            Response.Write(sb.ToString())
            Response.End()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub Exportar_Click(sender As Object, e As EventArgs) Handles Exportar.Click
        Try
            ObjInforme.Fcini = txtFecha_Inicio.Text
            ObjInforme.Fcfin = txtFecha_Fin.Text
            GridView2.DataSource = ObjInforme.CuentaRegistros
            GridView2.DataBind()
            lblFcini.Text = ""
            lblFcfin.Text = ""
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
            lblmsg.ForeColor = Drawing.Color.Red
        End Try
    End Sub

    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        Try

            GridView1.PageIndex = e.NewPageIndex
            Cargardatagrid()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

End Class