Public Partial Class checkdoc
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Pnl_Message.CssClass = Nothing
            lblmsg.Text = Nothing
            If Not IsPostBack Then
                Session("Formulario") = "Check Documental"
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                'lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                'lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                With drltipodoc
                    .DataSource = objdatos.consultatipodoc
                    .DataTextField = "descripciontipodoc"
                    .DataValueField = "idtipodoc"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objconsulta As New clsrrhh
        Try
            If txtdocumento.Text = "" Then
                Pnl_Message.CssClass = "alert alert-warning"
                lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el documento del empleado que desea consultar"
            Else
                objconsulta.documento = txtdocumento.Text
                Dim Dtt As DataTable = objconsulta.Consulta_Personal(False)
                If Dtt.Rows.Count >= 1 Then
                    Dim objdatos As New clsrrhh
                    Dim Fn As String
                    Dim SaveLocation As String
                    If Not File1.PostedFile Is Nothing Then
                        If File1.PostedFile.ContentLength > 0 Then
                            Fn = System.IO.Path.GetFileName(File1.PostedFile.FileName)
                            SaveLocation = Server.MapPath("data_check") & "\\" & Fn
                            File1.PostedFile.SaveAs(SaveLocation)
                            objdatos.rutafoto = Fn
                        Else
                            Pnl_Message.CssClass = "alert alert-warning"
                            lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el archivo digital del tipo de documento a ingresar"
                            Exit Sub
                        End If
                    Else
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el archivo digital del tipo de documento a ingresar"
                        Exit Sub
                    End If

                    If txtdocumento.Text = "" Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el documento de identificación"
                        Exit Sub
                    Else
                        objdatos.documento = txtdocumento.Text
                    End If
                    If drltipodoc.SelectedItem.Value = 0 Then
                        Pnl_Message.CssClass = "alert alert-warning"
                        lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Seleccione el tipo de documento a archivar"
                        Exit Sub
                    Else
                        objdatos.tipodoc = drltipodoc.SelectedItem.Value
                    End If
                    If txtobs.Text = "" Then
                        objdatos.obs = ""
                    Else
                        objdatos.obs = txtobs.Text
                    End If
                    objdatos.idusuario = CType(Session("permisos"), clsusuario).usuario
                    objdatos.registrocheck()
                    buscarinf()
                    txtobs.Text = ""
                    txtdocumento.Text = ""
                    drltipodoc.SelectedValue = 0
                    Pnl_Message.CssClass = "alert alert-success"
                    lblmsg.Text = "<span class='glyphicon glyphicon-ok-sign'></span> Check documental ingresado con éxito"
                Else
                    Pnl_Message.CssClass = "alert alert-warning"
                    lblmsg.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El documento digitado no corresponde a un empleado, verifique la información"
                End If
            End If
        Catch ex As Exception
            Pnl_Message.CssClass = "alert alert-danger"
            lblmsg.Text = "<span class='glyphicon glyphicon-remove-sign'></span>" & ex.Message
        End Try
    End Sub
    Sub buscarinf()
        Dim objdatos As New clsrrhh
        If txtdocumento.Text <> "" Then
            objdatos.documento = txtdocumento.Text
            dtggeneral.DataSource = objdatos.consultacheck
            dtggeneral.DataBind()
            CType(Session("permisos"), clsusuario).usuario = objdatos.cuenta
        End If
        Pnl_Message.CssClass = Nothing
        lblmsg.Text = Nothing
    End Sub
End Class