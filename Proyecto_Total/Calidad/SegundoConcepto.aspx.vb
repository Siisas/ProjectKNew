Public Class SegundoConcepto
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                cargar()
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
    Sub cargar()
        Try
            objdatos.Validacion = 8
            objdatos.Id_Usuario = lblusuario.Text
            Session("dtsDtgAuditoria") = objdatos.segundoconceptocaso()
            Solicitados.DataSource = Session("dtsDtgAuditoria")
            Solicitados.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Sub Volver()
        Try
            DtgAuditoria1.DataSource = Nothing

            DtgAuditoria1.DataSource = Nothing
            DtgAuditoria1.DataBind()
            RbtNo.Checked = False
            RbtRafectacion.Checked = False
            RbtRparametro.Checked = False
            RbtSi.Checked = False
            txtObservacion.Text = ""
            Pnl2.Visible = True
            Pnl1.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Dim objdatos As New clscalidad
    Sub buscarinfgral()
        Try
            If TxtCod_Auditoria.Text = "" Then
                lblmsg.Text = "Digite la auditoria que desea consultar"
            Else
                lblmsg.Text = ""
                objdatos.Auditoria = TxtCod_Auditoria.Text
                DtgAuditoria.DataSource = objdatos.segundoconceptocaso()
                DtgAuditoria.DataBind()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub DtgAuditoria_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles DtgAuditoria.RowCommand
        Try
            If e.CommandName = "Solicitar" Then
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Dim Valor As String = DtgAuditoria.Rows(index).Cells(1).Text
                objdatos.Codigo_reg = DtgAuditoria.Rows(index).Cells(0).Text
                objdatos.Validacion = 7
                objdatos.segundoconceptocaso()
                If objdatos.cantidad > 0 Then
                    If objdatos.Estado = "Pendiente" Or objdatos.Estado = "Asignado" Then
                        lblmsg.Text = "Segundo concepto en proceso"
                        Exit Sub
                    End If
                    If objdatos.Estado = "Ratifica" Or objdatos.Estado = "No Ratifica" Or objdatos.Estado = "No Aplica" Then
                        lblmsg.Text = "Segundo concepto realizado"
                        Exit Sub
                    End If
                End If
                Dim dt As New DataTable
                dt.Columns.Add("id_auditoria")
                dt.Columns.Add("id_retro")
                dt.Columns.Add("caso")
                dt.Columns.Add("Fecha_Auditoria")
                Dim filadt As DataRow = dt.NewRow
                Session("Valor1") = DtgAuditoria.Rows(index).Cells(0).Text
                filadt(0) = DtgAuditoria.Rows(index).Cells(0).Text
                filadt(1) = DtgAuditoria.Rows(index).Cells(1).Text
                filadt(2) = DtgAuditoria.Rows(index).Cells(2).Text
                filadt(3) = DtgAuditoria.Rows(index).Cells(3).Text
                dt.Rows.Add(filadt)
                dt.Rows.Add()
                Dim listaux As New List(Of DataRow)
                For Each dr As DataRow In dt.Rows
                    If dr("id_auditoria").ToString = "" Then
                        listaux.Add(dr)
                    End If
                Next


                For Each dr As DataRow In listaux
                    dt.Rows.Remove(dr)
                Next
                If Valor = "No Tiene" Then
                    lblmsg.Text = "No existe retroalimentacion para la auditoria"
                    Exit Sub
                End If
                If Valor <> "No Tiene " Then
                    Pnl2.Visible = False
                    Pnl1.Visible = True
                    DtgAuditoria1.DataSource = dt
                    DtgAuditoria1.DataBind()
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            buscarinfgral()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub BtnEnvia_Click(sender As Object, e As EventArgs) Handles BtnEnvia.Click
        Try
            objdatos.Id_Usuario = lblusuario.Text
            If RbtNo.Checked = True Then
                objdatos.asistio = RbtNo.Text
            ElseIf RbtSi.Checked = True Then
                objdatos.asistio = RbtSi.Text
            Else
                lblmsg.Text = "Seleccione asistencia del lider"
                Exit Sub
            End If

            If RbtRparametro.Checked = True Then
                objdatos.razon = RbtRparametro.Text

            ElseIf RbtRafectacion.Checked = True Then
                objdatos.razon = RbtRafectacion.Text
            Else
                lblmsg.Text = "Seleccione razon"
                Exit Sub
            End If
            If txtObservacion.Text = "" Then
                lblmsg.Text = "ingrese una observacion"
                Exit Sub
            Else
                objdatos.Observacion = txtObservacion.Text
            End If
            objdatos.Auditoria = Session("Valor1")
            objdatos.Validacion = 2
            objdatos.Auditoria = Session("Valor1")
            objdatos.segundoconceptocaso()
            objdatos.Estado = "Pendiente"
            objdatos.registrosegundoconcepto()
            DtgAuditoria1.DataSource = Nothing
            DtgAuditoria1.DataBind()
            RbtNo.Checked = False
            RbtRafectacion.Checked = False
            RbtRparametro.Checked = False
            RbtSi.Checked = False
            txtObservacion.Text = ""
            lblmsg.Text = "Registro Exitoso"
            Volver()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Try
            Volver()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class