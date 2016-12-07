Public Class WebForm1
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


                asignado()
                With drlusuario
                    .DataSource = objdatos.consultaagentegrupo
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
                    .DataBind()
                End With
                objdatos.nombre = "AgisnacionManual_Bandeja_nueva"
                With drlBandeja
                    .DataSource = objdatos.Consulta_drl_Asignacion_Lib_Manual
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
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

            
            dtggeneral.DataSource = objdatos.AsignacionProgramados
            dtggeneral.DataBind()

           
            objdatos.idusuario = lblusuario.Text
            lblcantidadtot.Text = objdatos.cantidad
            lblcantidad.Text = objdatos.cantidad
            objdatos.Validacion = "Usuario"
            dtgUsuarios.DataSource = objdatos.AsignacionProgramados
            dtgUsuarios.DataBind()
            lblingenieros.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            lblmsg.Text = ""
            Dim objdatos As New clscrmdatos
            If drlusuario.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.idusuario = drlusuario.SelectedValue
            Else
                lblmsg.Text = "Seleccione un ingeniero"
                Exit Sub
            End If
            objdatos.Validacion = "Inserta"
            'If txtcaso.Text <> "" Then
            '    objdatos.caso = txtcaso.Text
            '    objdatos.Superv = lblusuario.Text
            '    objdatos.asignaprogramados()
            '    lblmsg.Text = "Asignacion individual correcta"
            '    asignado()
            '    limpiar()
            '    Exit Sub
            'End If

            If dtgbusqueda0.Rows.Count > 0 Then
                objdatos.Superv = lblusuario.Text
                For Each row As GridViewRow In dtgbusqueda0.Rows
                    objdatos.caso = Int64.Parse(row.Cells(0).Text)
                    objdatos.asignaprogramados()
                Next
                lblmsg.Text = "Asignación masiva realizada con éxito"
            Else
                lblmsg.Text = "Por favor consulte los casos que va asignar"
                Exit Sub
            End If
            asignado()
            limpiar()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            lblmsg.Text = ""
            Dim objdatos As New clscrmdatos
            If txtcaso.Text <> "" Then
                objdatos.caso = txtcaso.Text
                dtgbusqueda.DataSource = objdatos.AsignacionProgramados
                dtgbusqueda.DataBind()
                lblprueba.Text = objdatos.cantidad
                If lblprueba.Text = 0 Then
                    lblmsg.Text = "No se encontraron registros"
                Else
                    dtgbusqueda0.DataSource = objdatos.AsignacionProgramados
                    dtgbusqueda0.DataBind()
                End If

                Exit Sub
            End If
            If txtcantidad.Text = "" Then
                lblmsg.Text = "Ingrese la cantidad de casos a asignar"
                dtgbusqueda.DataSource = Nothing
                dtgbusqueda.DataBind()
                dtgbusqueda0.DataSource = Nothing
                dtgbusqueda0.DataBind()
                lblprueba.Text = ""
                Exit Sub
            Else
                objdatos.cantidad = txtcantidad.Text
            End If
            If drlBandeja.SelectedItem.Text = "- Seleccione -" Then
                objdatos.Bandeja = ""
            Else
                objdatos.Bandeja = drlBandeja.SelectedItem.Text
            End If
            If drlEstado.SelectedItem.Text = "- Seleccione -" Then
                objdatos.estadoinc = ""
            Else
                objdatos.estadoinc = drlEstado.SelectedItem.Text
            End If

            If txtfcfin.Text <> "" And txtfcinicio.Text <> "" Then
                If Date.Parse(txtfcinicio.Text) > Date.Parse(txtfcfin.Text) Then
                    lblmsg.Text = "Fecha inicio debe ser menor a Fecha fin"
                    Exit Sub
                End If
            End If

            If txtfcinicio.Text <> "" Then
                objdatos.fcini = txtfcinicio.Text
            End If
            If txtfcfin.Text <> "" Then
                objdatos.fcfin = txtfcfin.Text
            End If


            dtgbusqueda.DataSource = objdatos.AsignacionProgramados
            dtgbusqueda.DataBind()
            dtgbusqueda0.DataSource = objdatos.AsignacionProgramados
            dtgbusqueda0.DataBind()


            If objdatos.cantidad = 0 Then
                lblmsg.Text = "No se encontraron datos"
                lblprueba.Text = ""
            Else

                lblprueba.Text = objdatos.cantidad
            End If


        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Dim caduca As Integer = 0
    Dim vigente As Integer = 0

 

    Protected Sub dtggeneral_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dtggeneral.RowDataBound
        Dim FcIngreso As Date

        If (e.Row.RowType = DataControlRowType.DataRow) Then
            FcIngreso = Date.Now

            If DataBinder.Eval(e.Row.DataItem, "fcprogram") < FcIngreso Then
                e.Row.ForeColor = Drawing.Color.Red
                e.Row.Cells(6).Text = "CADUCADO"
                caduca = caduca + 1

            Else
                e.Row.Cells(6).Text = "VIGENTE"
                vigente = vigente + 1
            End If
            lblcaduca.Text = caduca
            lblvigente.Text = vigente
        End If
    
    End Sub

    Protected Sub limpiar()
        txtcantidad.Text = ""
        txtcaso.Text = ""
        drlBandeja.SelectedItem.Text = "- Seleccione -"
        drlEstado.SelectedItem.Text = "- Seleccione -"
        drlusuario.SelectedItem.Text = "- Seleccione -"
        dtgbusqueda.DataSource = Nothing
        dtgbusqueda.DataBind()
        dtgbusqueda0.DataSource = Nothing
        dtgbusqueda0.DataBind()
        lblprueba.Text = ""
    End Sub

    Protected Sub dtgbusqueda_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgbusqueda.PageIndexChanging
        Try
            Dim objdatos As New clscrmdatos
            If txtcantidad.Text <> "" Then
                objdatos.cantidad = txtcantidad.Text
            End If
            If drlBandeja.SelectedItem.Text = "- Seleccione -" Then
                objdatos.Bandeja = ""
            Else
                objdatos.Bandeja = drlBandeja.SelectedItem.Text
            End If
            If drlEstado.SelectedItem.Text = "- Seleccione -" Then
                objdatos.estadoinc = ""
            Else
                objdatos.estadoinc = drlEstado.SelectedItem.Text
            End If

            dtgbusqueda.PageIndex = e.NewPageIndex
            dtgbusqueda.DataSource = objdatos.AsignacionProgramados
            dtgbusqueda.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub dtggeneral_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            Dim objdatos As New clscrmdatos
            dtggeneral.PageIndex = e.NewPageIndex
            dtggeneral.DataSource = objdatos.AsignacionProgramados
            dtggeneral.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Protected Sub dtgUsuarios_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgUsuarios.PageIndexChanging
        Try
            Dim objdatos As New clscrmdatos
            dtgUsuarios.PageIndex = e.NewPageIndex
            objdatos.Validacion = "Usuario"
            dtgUsuarios.DataSource = objdatos.AsignacionProgramados
            dtgUsuarios.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try

    End Sub
End Class