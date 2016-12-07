Imports System.IO

Public Class Consgeneralfallatec
    Inherits System.Web.UI.Page
    Dim objeto As New clscrmdatos
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
                With drlestadofallatec
                    .DataSource = objeto.consultageneral
                    .DataValueField = "Nombre"
                    .DataTextField = "Nombre"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            If txtcaso.Text <> Nothing Or txtmin.Text <> Nothing Or txttikler.Text <> Nothing Or drlestadofallatec.SelectedItem.Text <> "- Seleccione -" Or txtidfallatec.Text <> Nothing Or txtFechainicio.Text <> "" Or txtFechafin.Text <> "" Then
                lblmsg.Text = ""
                LinkButton2.Visible = False
                dtgseguimientos.Visible = False
                lblseguimientos.Visible = False
                objeto.fcini = txtFechainicio.Text
                objeto.fcfin = txtFechafin.Text
                objeto.tickler = txttikler.Text
                objeto.caso = txtcaso.Text
                objeto.dir = drlestadofallatec.SelectedValue
                objeto.idcrm = txtidfallatec.Text
                objeto.min = txtmin.Text

                If txtFechafin.Text = Nothing And txtcaso.Text = Nothing And txtmin.Text = Nothing And txttikler.Text = Nothing And drlestadofallatec.SelectedItem.Text = "- Seleccione -" And txtidfallatec.Text = "" Then
                    lblmsg.Text = "Verifique el rango de fecha"
                    Exit Sub
                End If
                If txtFechainicio.Text = Nothing And txtcaso.Text = Nothing And txtmin.Text = Nothing And txttikler.Text = Nothing And drlestadofallatec.SelectedItem.Text = "- Seleccione -" And txtidfallatec.Text = "" Then
                    lblmsg.Text = "Verifique el rango de fecha"
                    Exit Sub
                End If
               
                If objeto.fcini > objeto.fcfin And txtcaso.Text = Nothing And txtmin.Text = Nothing And txttikler.Text = Nothing And drlestadofallatec.SelectedItem.Text = "- Seleccione -" And txtidfallatec.Text = Nothing Then
                    lblmsg.Text = "Verifique el que fecha inicio no sea mayor a fecha fin "
                    Exit Sub
                End If
                cargardtg()
                If objeto.idcrm <> Nothing Then
                    cargarsegimiento()
                    LinkButton2.Visible = True
                    lblseguimientos.Visible = True
                End If
            Else
                lblmsg.Text = "Especifique un criterio de busqueda"
                dtgseguimiento.DataSource = Nothing
                dtgseguimiento.DataBind()
                dtgseguimientos.DataSource = Nothing
                dtgseguimientos.DataBind()
                lblifogeneral.Text = ""
                lblseguimientos.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Sub cargardtg()
        Try
            dtgseguimiento.Visible = True
            dtgseguimiento.DataSource = objeto.consultageneral
            dtgseguimiento.DataBind()
            lblifogeneral.Text = objeto.cantidad
            If lblifogeneral.Text = "0" Then
                lblmsg.Text = "No se encontraron registros con el criterio de busqueda especificado"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub cargarsegimiento()
        Try
            dtgseguimientos.Visible = True
            objeto.Validacion = 1
            dtgseguimientos.DataSource = objeto.consultageneral()
            dtgseguimientos.DataBind()
            lblseguimientos.Text = objeto.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub dtgseguimiento_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgseguimiento.PageIndexChanging
        Try
            dtgseguimiento.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            cambioindicedtg1()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub cambioindicedtg1()
        Try
            If txtcaso.Text <> Nothing Or txtmin.Text <> Nothing Or txttikler.Text <> Nothing Or drlestadofallatec.SelectedItem.Text <> "- Seleccione -" Or txtidfallatec.Text <> Nothing Or txtFechainicio.Text <> "" Or txtFechafin.Text <> "" Then

                objeto.fcini = txtFechainicio.Text
                objeto.fcfin = txtFechafin.Text
                objeto.tickler = txttikler.Text
                objeto.caso = txtcaso.Text
                objeto.dir = drlestadofallatec.SelectedValue
                objeto.idcrm = txtidfallatec.Text
                objeto.min = txtmin.Text
                cargardtg()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub cambioindicedtg2()
        Try
            If txtcaso.Text <> Nothing Or txtmin.Text <> Nothing Or drlestadofallatec.SelectedItem.Text <> "- Seleccione -" Or txttikler.Text <> Nothing Then
                cargarsegimiento()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub dtgseguimientos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgseguimientos.PageIndexChanging
        Try
            dtgseguimientos.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            cambioindicedtg2()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub btnxls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnxls.Click
        Try
            lblmsg.Text = ""
            crearexcel()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub crearexcel()
        Try
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim r As New clscrmdatos
            Dim objdtsconsultaxls As New DataSet
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
            Dim Validar As Boolean
            If txtcaso.Text <> "" Then
                r.caso = txtcaso.Text
                Validar = True
            End If
            If txtidfallatec.Text <> "" Then
                r.idcrm = txtidfallatec.Text
                Validar = True
            End If
            If txtmin.Text <> "" Then
                r.min = txtmin.Text
                Validar = True
            End If

            If txttikler.Text <> "" Then
                r.tickler = txttikler.Text
                Validar = True
            End If

            If txtFechainicio.Text <> "" Then
                r.fcini = txtFechainicio.Text
                Validar = True
            End If
           
            If txtFechafin.Text <> "" Then
                r.fcfin = txtFechafin.Text
                Validar = True
            End If

            If drlestadofallatec.SelectedItem.Text <> "- Seleccione -" Then
                r.dir = drlestadofallatec.SelectedValue
                Validar = True
            End If
            If lblifogeneral.Text <> "0" Or lblseguimientos.Text <> "0" And Validar = True Then
                If lblifogeneral.Text <> "" Or lblseguimientos.Text <> "" And Validar = True Then
                    If r.idcrm <> "" Then
                        r.Validacion = 1
                        dtgxls2.DataSource = r.consultageneral
                        dtgxls2.DataBind()
                        dtgxls2.Visible = True
                        dtgxls2.EnableViewState = False
                    End If
                    dtgxls1.DataSource = r.consultageneral
                    dtgxls1.DataBind()
                    dtgxls1.Visible = True
                    dtgxls1.EnableViewState = False
                    pagina.EnableEventValidation = False
                    pagina.DesignerInitialize()
                    pagina.Controls.Add(form)
                    form.Controls.Add(dtgxls1)
                    form.Controls.Add(dtgxls2)
                    pagina.RenderControl(htw)
                    Response.Clear()
                    Response.Buffer = True
                    Response.ContentType = "application/vnd.ms-excel"
                    Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                    Response.AddHeader("Content-Disposition", "attachment;filename=Seguimiento Fallatec.xls")
                    Response.Charset = "UTF-8"
                    Response.Write(strStyle)
                    Response.Write(sb.ToString())
                    Response.End()
                Else
                    lblmsg.Text = "Debe hacer primero un filtro de consulta"
                End If
            Else
                lblmsg.Text = "Debe hacer primero un filtro de consulta"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub LinkButton3_Click(sender As Object, e As EventArgs) Handles LinkButton3.Click
        Try
            dtgseguimiento.Visible = True
            dtgseguimientos.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As EventArgs) Handles LinkButton2.Click
        Try
            dtgseguimientos.Visible = True
            dtgseguimiento.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

   
End Class