Public Class Asignaciongestion
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
                'cambio
                With drlusuario
                    .DataSource = objdatos.consultaagentegrupo
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
                    .DataBind()
                End With
                'fin cambio
                Cargar_drl()
                Cargar_lbl()
                asignado()
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
            
            dtgestad.DataSource = objdatos.consultaenprocgestion
            dtgestad.DataBind()
            objdatos.Validacion = "inicio"
            objdatos.cantidad = lblcantidadtot.Text
            dtggeneral.DataSource = objdatos.consultapteasignargestion
            dtggeneral.DataBind()
            lblcantidad.Text = objdatos.cantidad
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Public Sub Cargar_drl()
        Try
            Dim objdatos As New clsgeneral
            Dim objdatosban As New clscrmdatos
            objdatosban.Validacion = "Asignacion"
            With drlEstado
                .DataSource = objdatosban.Consulta_drlestado
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            objdatos.nombre = "AgisnacionManual_Bandeja_nueva"
            With drlBandeja
                .DataSource = objdatos.Consulta_drl_Asignacion_Lib_Manual
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Dim Contador As Integer
    Dim Contador2 As Integer
    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim actualizar As New clscrmdatos
        Try
            If lblcantidad.Text = "" Or dtgBusqueda.Rows.Count = 0 Then
                lblmsg.Text = "Antes de realizar la asignacion digite y consulte la cantidad de casos, ya que se asignaran los que se visualicen en la tabla"
                Exit Sub
            End If
            If ((drlusuario.SelectedItem.Text = "- Seleccione -" And drlusuario.SelectedValue = "")) Then
                lblmsg.Text = "Seleccione a un usuario de la lista para realizar la asignacion"
                Exit Sub
            End If
            If drlusuario.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione a un usuario de la lista para realizar la asignacion"
                Exit Sub
            End If
            If lblusuario.Text <> "" Then
                actualizar.Superv = lblusuario.Text
                ' dtgAgentes.DataSource = actualizar.Jefe_A_Cargo
                'dtgAgentes.DataBind()
            End If
            If drlusuario.SelectedItem.Text <> "- Seleccione -" And drlusuario.SelectedItem.Text <> "" Then
                actualizar.idusuario = drlusuario.SelectedItem.Value
            End If
            If txtcaso.Text <> Nothing Then
                For Each row As GridViewRow In dtgBusqueda0.Rows
                    actualizar.caso = Int64.Parse(row.Cells(0).Text)

                    actualizar.asignaescalaxcasogestion()
                Next
                txtcaso.Text = ""
                lblmsg.Text = "Asignación individual realizada con éxito"
            Else
                For Each row As GridViewRow In dtgBusqueda0.Rows
                    actualizar.caso = Int64.Parse(row.Cells(0).Text)
                    actualizar.asignaescalaxcasogestion()
                Next
                lblmsg.Text = "Asignación masiva realizada con éxito"
            End If

            dtgBusqueda.DataSource = Nothing
            dtgBusqueda.DataBind()
            dtgBusqueda0.DataSource = Nothing
            dtgBusqueda0.DataBind()
            lblbusqueda.Text = ""

            txtfcfin.Text = ""
            txtfcinicio.Text = ""
            asignado()
            Cargar_lbl()
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Cargar_lbl()
            If txtcaso.Text <> Nothing Then
                busca()
            ElseIf txtcantidad.Text = "" Then
                lblmsg.Text = "Digite la cantidad de casos que desea asignar"
                Exit Sub
            Else
                busca()
            End If

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub busca()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text <> "" Then
                objdatos.Validacion = "Individual"
                objdatos.caso = txtcaso.Text
                dtgBusqueda.DataSource = objdatos.consultapteasignargestion
                dtgBusqueda.DataBind()
                dtgBusqueda0.DataSource = objdatos.consultapteasignargestion
                dtgBusqueda0.DataBind()
                If objdatos.cantidad = 0 Then
                    lblmsg.Text = "Este caso se encuentra cerrado o asignado o tiene un estado que no corresponde"
                    dtgBusqueda.DataSource = Nothing
                    dtgBusqueda.DataBind()
                    dtgBusqueda0.DataSource = Nothing
                    dtgBusqueda0.DataBind()

                Else
                    lblbusqueda.Text = objdatos.cantidad
                    lblmsg.Text = ""
                End If
                
            ElseIf txtcantidad.Text = "" Then
                lblmsg.Text = "Digite la cantidad de casos que desea asignar"
                Exit Sub
            Else
                If drlBandeja.Text <> "- Seleccione -" Then
                    objdatos.Bandeja = drlBandeja.Text
                End If
                If drlEstado.Text <> "- Seleccione -" Then
                    objdatos.estadoinc = drlEstado.Text
                End If
                objdatos.cantidad = txtcantidad.Text
                If lblusuario.Text <> "" Then
                    objdatos.idusuario = lblusuario.Text
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

                dtgBusqueda.DataSource = objdatos.consultapteasignargestion
                dtgBusqueda.DataBind()
                dtgBusqueda0.DataSource = objdatos.consultapteasignargestion
                dtgBusqueda0.DataBind()
                If objdatos.cantidad = 0 Then
                    lblmsg.Text = "No se encontraron casos"
                    dtgBusqueda.DataSource = Nothing
                    dtgBusqueda.DataBind()
                    dtgBusqueda0.DataSource = Nothing
                    dtgBusqueda0.DataBind()
                    lblbusqueda.Text = ""
                    Exit Sub
                End If
                lblbusqueda.Text = objdatos.cantidad
                lblmsg.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub dtgestad_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgestad.PageIndexChanging
        Try
            Dim objdatos As New clscrmdatos
            dtgestad.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            dtgestad.DataSource = objdatos.consultaenprocgestion
            dtgestad.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    'Sub dtgAgentesCarga()
    '    Dim actualizar As New clscrmdatos
    '    If lblusuario.Text <> "- Seleccione -" Then
    '        actualizar.Superv = lblusuario.Text
    '        dtgAgentes.DataSource = actualizar.Jefe_A_Cargo
    '        dtgAgentes.DataBind()
    '    Else
    '        lblmsg.Text = "Seleccione Jefe a cargo"
    '        dtgAgentes.DataSource = Nothing
    '        dtgAgentes.DataBind()
    '    End If
    'End Sub


    'Protected Sub dtgAgentes_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgAgentes.PageIndexChanging
    '    Try
    '        dtgAgentes.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
    '        dtgAgentesCarga()
    '    Catch ex As Exception
    '        lblmsg.Text = "Se produjo error " & ex.Message
    '    End Try
    'End Sub

    Protected Sub dtggeneral_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtggeneral.PageIndexChanging
        Try
            Dim objdatos As New clscrmdatos
            dtggeneral.PageIndex = e.NewPageIndex 'asigna la consulta a la grilla por paginas
            objdatos.Validacion = "inicio"
            objdatos.cantidad = lblcantidadtot.Text
            dtggeneral.DataSource = objdatos.consultapteasignargestion
            dtggeneral.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Cargar_lbl()
        Dim objdatos As New clscrmdatos

        objdatos.idusuario = lblusuario.Text
        objdatos.consultapteasignartotalgestion()
        lblcantidadtot.Text = objdatos.cantidad

        objdatos.Validacion = "1"
        objdatos.consultapteasignartotalgestion()
        lbldatos.Text = " " + objdatos.cantidad

        objdatos.Validacion = "3"
        objdatos.consultapteasignartotalgestion()
        LblPQR.Text = objdatos.cantidad

        objdatos.Validacion = "4"
        objdatos.consultapteasignartotalgestion()
        LblSinForm.Text = objdatos.cantidad

    End Sub
   

    Protected Sub dtgBusqueda_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgBusqueda.PageIndexChanging
        Try
            Dim objdatos As New clscrmdatos
            dtgBusqueda.PageIndex = e.NewPageIndex
            If drlBandeja.Text <> "- Seleccione -" Then
                objdatos.Bandeja = drlBandeja.Text
            End If
            If drlEstado.Text <> "- Seleccione -" Then
                objdatos.estadoinc = drlEstado.Text
            End If
            objdatos.cantidad = txtcantidad.Text
            If lblusuario.Text <> "" Then
                objdatos.idusuario = lblusuario.Text
            End If
            dtgBusqueda.DataSource = objdatos.consultapteasignargestion
            dtgBusqueda.DataBind()
        Catch ex As Exception

        End Try
    End Sub
End Class