Public Class DesprendibleCafeteUsu
    Inherits System.Web.UI.Page
    Dim ObjCafeteria As New clsCafeteria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
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

    Public Sub Consulta_Usu()
        Try
            If documento.Text = "" Then
                lblmsg.Text = "Ingrese codigo o documento"
                Exit Sub
            End If
            If drlperiodo.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione algun mes"
                Exit Sub
            End If
            If Año.Text = "" Then
                lblmsg.Text = "Ingrese el Año"
                Exit Sub
            ElseIf Año.Text > 2050 Or Año.Text < 2010 Then
                lblmsg.Text = "Verifique rango de fecha"
                Exit Sub
            End If
            lblmsg.Text = ""
            Dim dts As New DataSet
            ObjCafeteria.Documento = documento.Text
            dts = ObjCafeteria.consultausu()
            If dts.Tables(0).Rows.Count > 0 Then
                lblcod.Text = ObjCafeteria.Codigo
                Lbldoc.Text = ObjCafeteria.Documento
                lblnombre.Text = ObjCafeteria.Nombre + " " + ObjCafeteria.Apellido
                lblcargo.Text = ObjCafeteria.Cargo
                lblgrupo.Text = ObjCafeteria.Grupo
            Else
                lblcod.Text = ""
                Lbldoc.Text = ""
                lblnombre.Text = ""
                lblcargo.Text = ""
                lblestado.Text = ""
                lblgrupo.Text = ""
            End If

            If ObjCafeteria.Estado = "A" Then
                lblestado.Text = "Activo"
                lblestado.ForeColor = Drawing.Color.DarkBlue

            Else
                If ObjCafeteria.Estado = "I" Then
                    lblestado.Text = "Inactivo"
                    lblestado.ForeColor = Drawing.Color.Red
                End If
            End If
            ObjCafeteria.Mes = drlperiodo.Text
            ObjCafeteria.Año = Año.Text
            ObjCafeteria.Codigo = documento.Text
            dtgConsultas.DataSource = ObjCafeteria.ConsultaMesCompra
            dtgConsultas.DataBind()

            dts = ObjCafeteria.ConsultaVltMes
            If dts.Tables(0).Rows.Count > 0 Then
                LblVtotal.Text = ObjCafeteria.Total
            Else
                LblVtotal.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error:" + ex.Message
        End Try
    End Sub


    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            Consulta_Usu()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub dtgConsultas_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles dtgConsultas.PageIndexChanging
        Try
            dtgConsultas.PageIndex = e.NewPageIndex
            Consulta_Usu()
        Catch ex As Exception
            lblmsg.Text = ex.Message
        End Try
    End Sub
End Class