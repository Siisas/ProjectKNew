Public Class liberarasiggestionvoz
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                objdatos.idusuario = lblusuario.Text
                objdatos.consultacod()
                lblgrupo.Text = objdatos.dpto

                With drlusuario
                    .DataSource = objdatos.consultaagentegrupo
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
                    .DataBind()
                End With
                With drlJefe
                    objdatos.Validacion = "2"
                    .DataSource = objdatos.Consulta_Perfiles()
                    .DataTextField = "nombreu"
                    .DataValueField = "Supervisor"
                    .DataBind()
                End With
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
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            Dim actualizar As New clsvoz
            If lblcantidad.Text = "" Or dtggeneral.Rows.Count = 0 Then
                lblmsg.Text = "Antes de realizar una liberacion consulte los casos, ya que se liberaran los que se visualizan"
                Exit Sub
            End If
            For Each row As GridViewRow In dtggeneral.Rows
                actualizar.caso = Int64.Parse(row.Cells(0).Text)
                actualizar.liberaasiggestionvoz()
            Next
            lblmsg.Text = "Liberación realizada con éxito"
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            lblcantidad.Text = ""
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            busca()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Private Sub busca()
        Try
            Dim objdatos As New clsvoz
            If drlusuario.SelectedItem.Text = "- Seleccione -" And drlJefe.SelectedItem.Text = "- Seleccione -" And CheckBoxLiberacion.Checked = False Then
                lblmsg.Text = "Seleccione una de las opciones antes de realizar la consulta"
                Exit Sub
            End If
            If drlusuario.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.idusuario = drlusuario.SelectedItem.Value
            End If
            If drlJefe.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.Superv = drlJefe.SelectedValue
                dtgAgentes.DataSource = objdatos.Jefe_A_Cargo
                dtgAgentes.DataBind()
                If dtgAgentes.Rows.Count > 0 Then
                    Dim Agente As String
                    Dim Agente2 As String
                    Dim Contador As Integer
                    Dim Contador2 As Integer
                    Contador = dtgAgentes.Rows.Count
                    Contador2 = Contador - 1
                    For Each row As GridViewRow In dtgAgentes.Rows
                        Agente2 = row.Cells(0).Text
                        If Contador2 = 0 Then
                            Agente = Agente + "idusuarioasig=" + "'" + Agente2 + "'"
                        Else
                            Agente = Agente + "idusuarioasig=" + "'" + Agente2 + "' or "
                        End If
                        Contador2 = Contador2 - 1
                    Next
                    objdatos.idusuario = Agente
                    dtggeneral.DataSource = objdatos.consultaasignadogestionvoz
                    dtggeneral.DataBind()
                    lblcantidad.Text = objdatos.cantidad
                End If
                Exit Sub
            End If
            dtggeneral.DataSource = objdatos.consultaasignadogestionvoz
            dtggeneral.DataBind()
            lblcantidad.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub drlJefe_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlJefe.SelectedIndexChanged
        Try
            If drlJefe.SelectedItem.Text <> "- Seleccione -" Then
                Dim ObjDatos As New clscrmdatos
                ObjDatos.Superv = drlJefe.SelectedValue
                ObjDatos.Validacion = drlJefe.SelectedValue
                With drlusuario
                    .DataSource = ObjDatos.Jefe_A_Cargo
                    .DataValueField = "idusuario"
                    .DataTextField = "nombreu"
                    .DataBind()
                End With
            Else
                Dim ObjDatos As New clsgeneral
                ObjDatos.idusuario = lblusuario.Text
                With drlusuario
                    .DataSource = ObjDatos.consultaagentegrupo
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            dtggeneral.PageIndex = e.NewPageIndex
            busca()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class