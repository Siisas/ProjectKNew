﻿Public Class Asignafallatec
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                asignado()
                objdatos.nombre = 1
                With drlusuario
                    .DataSource = objdatos.consultadigitador
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
                With drlTipo
                    .DataSource = objdatos.Consulta_Tipo_Asigna_FallaTec()
                    .DataTextField = "nombre"
                    .DataValueField = "nombre"
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
    Protected Sub asignado()
        Try
            Dim objdatos As New clscrmdatos
            dtgestad.DataSource = objdatos.enprocesofallatec
            dtgestad.DataBind()
            objdatos.pteasignacionfallatec()
            lblcantidadtot.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Dim Contador As Integer
    Dim Contador2 As Integer
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim actualizar As New clscrmdatos
        Try
            If lblcantidad.Text = "" Or dtggeneral.Rows.Count = 0 Then
                lblmsg.Text = "Antes de realizar la asignacion digite y consulte la cantidad de casos, ya que se asignaran los que se visualicen en la tabla"
                Exit Sub
            End If
            If ((drlusuario.SelectedItem.Text <> "- Seleccione -" And drlusuario.SelectedValue <> "") And (drlJefe.SelectedItem.Text <> "- Seleccione -")) Then
                lblmsg.Text = "Seleccione solo una(1) opcion de las dos listas desplegables Ingeniero de Soporte o Jefe Inmediato antes de realizar la asignacion"
                Exit Sub
            End If
            If drlusuario.SelectedItem.Text = "- Seleccione -" And drlJefe.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione una opcion de las dos listas desplegables Ingeniero de Soporte o Jefe Inmediato antes de realizar la asignacion"
                Exit Sub
            End If
            actualizar.idusuarioasignado = lblusuario.Text
            If drlJefe.SelectedItem.Text <> "- Seleccione -" Then
                actualizar.Superv = drlJefe.SelectedValue
                dtgAgentes.DataSource = actualizar.Jefe_A_Cargo
                dtgAgentes.DataBind()
            End If
            If drlusuario.SelectedItem.Text <> "- Seleccione -" And drlusuario.SelectedItem.Text <> "" Then
                actualizar.idusuario = drlusuario.SelectedItem.Value
            End If

            If txtcaso.Text <> Nothing Then
                actualizar.caso = txtcaso.Text
                actualizar.asignacasofallatec()
                txtcaso.Text = ""
                lblmsg.Text = "Asignación individual realizada con éxito"
            Else
                If drlJefe.SelectedItem.Text <> "- Seleccione -" Then
                    Contador = dtgAgentes.Rows.Count - 1
                    Contador2 = Contador
                End If

                For Each row As GridViewRow In dtggeneral.Rows
                    actualizar.caso = Int64.Parse(row.Cells(0).Text)
                    If drlJefe.SelectedItem.Text <> "- Seleccione -" Then
                        actualizar.idusuario = dtgAgentes.Rows(Contador).Cells(0).Text
                        Contador = Contador - 1
                        If Contador < 0 Then
                            Contador = Contador2
                        End If
                    End If
                    actualizar.asignacasofallatec()
                Next
                lblmsg.Text = "Asignación masiva realizada con éxito"
            End If
            dtggeneral.DataSource = Nothing
            dtggeneral.DataBind()
            lblcantidad.Text = ""
            asignado()
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim objdatos As New clscrmdatos
            If txtcantidad.Text = "" Then
                lblmsg.Text = "Digite la cantidad de casos que desea asignar"
                Exit Sub
            Else
                objdatos.cantidad = txtcantidad.Text
                'objdatos.idusuario = lblusuario.Text
                If drlJefe.SelectedItem.Text <> "- Seleccione -" Then
                    objdatos.idusuario = drlJefe.SelectedValue
                End If
                If drlTipo.Text <> "- Seleccione -" Then
                    objdatos.Bandeja = drlTipo.SelectedValue
                End If
                dtggeneral.DataSource = objdatos.consultapteasignarfallatec
                'dtggeneral.DataSource = objdatos.consultapteasignargestion
                dtggeneral.DataBind()
                lblcantidad.Text = objdatos.cantidad
                lblmsg.Text = ""

            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub dtgestad_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgestad.PageIndexChanging
        Try
            dtgestad.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            asignado()
        Catch ex As Exception
            Throw ex
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
                ObjDatos.nombre = 1
                With drlusuario
                    .DataSource = ObjDatos.consultadigitador
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class