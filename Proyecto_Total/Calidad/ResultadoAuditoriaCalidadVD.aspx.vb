Public Class ResultadoAuditotiaCalidadVD
    Inherits System.Web.UI.Page
    Dim ObjCalidad As New clscalidad

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                With drlGrupoConsulta
                    .DataSource = ObjCalidad.Consulta_Grupo
                    .DataTextField = "Cargo"
                    .DataValueField = "Cargo"
                    .DataBind()
                End With
                With drlSupervisor
                    .DataSource = ObjCalidad.Consulta_Supervisor
                    .DataTextField = "Supervisor"
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

    Public Sub Consulta()
        If TxtFechaInicio.Text = "" And TxtFechaFin.Text = "" And drlOperacion.Text = "- Seleccione -" And drlSupervisor.Text = "- Seleccione -" And drlGrupoConsulta.Text = "- Seleccione -" And TxtCodigo.Text = "" And TxtFechaInicioLlamada.Text = "" And TxtFechaFinLlamada.Text = "" Then
            lblmsg.Text = "Ingrese alguna filtro de consulta"
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            lblcuenta.Text = ""
            Exit Sub
        End If
        If TxtFechaInicio.Text <> "" Then
            ObjCalidad.fcini = TxtFechaInicio.Text
        End If
        If TxtFechaFin.Text <> "" Then
            ObjCalidad.fcfin = TxtFechaFin.Text
        End If
        If TxtFechaInicioLlamada.Text <> "" Then
            ObjCalidad.fcinill = TxtFechaInicioLlamada.Text
        End If
        If TxtFechaFinLlamada.Text <> "" Then
            ObjCalidad.fcfinll = TxtFechaFinLlamada.Text
        End If
        If drlOperacion.Text <> "- Seleccione -" Then
            ObjCalidad.obs = drlOperacion.Text
        End If
        If drlSupervisor.Text <> "- Seleccione -" Then
            ObjCalidad.agente = drlSupervisor.Text
        End If
        If drlGrupoConsulta.Text <> "- Seleccione -" Then
            ObjCalidad.grupo = drlGrupoConsulta.Text
        End If
        If TxtCodigo.Text <> "" Then
            ObjCalidad.CodigoAgente = TxtCodigo.Text
        End If

        dtggeneral.DataSource = ObjCalidad.Consulta_Total_Auditoria_Agente
        dtggeneral.DataBind()

        lblcuenta.Text = ObjCalidad.cantidad

        lblmsg.Text = ""
        TxtFechaInicio.Text = ""
        TxtFechaFin.Text = ""
        TxtFechaInicioLlamada.Text = ""
        TxtFechaFinLlamada.Text = ""
    End Sub


    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            Consulta()
        Catch ex As Exception
            lblmsg.Text = "Se presento error " + ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        dtggeneral.PageIndex = e.NewPageIndex
        Consulta()
    End Sub
End Class