Public Class regdotacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
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
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Sub buscarinf()
        Dim objdatos As New clsrrhh
        If txtcod.Text <> "" Then
            objdatos.codigo = txtcod.Text
            dtggeneral.DataSource = objdatos.consultapersonal
            dtggeneral.DataBind()
            lblcuenta.Text = objdatos.cantidad
        End If
        lblmsg.Text = ""
    End Sub

    Protected Sub btnvalidar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnvalidar.Click
        Try
            Dim objdatos As New clsrrhh
            If txtcod.Text = "" Then
                lblmsg.Text = "Digite el código de usuario al que desea registrar la novedad"
            Else
                objdatos.codigo = txtcod.Text
                objdatos.consultadotac()
                If objdatos.cantidad > 0 Then
                    lblnombre.Text = objdatos.nombres & " " & objdatos.apellidos
                    rdbcarne.SelectedValue = objdatos.carne
                    rdbchaleco.SelectedValue = objdatos.chaleco
                    rdbdiadema.SelectedValue = objdatos.diadema
                    rdbuniforme.SelectedValue = objdatos.uniforme
                    If objdatos.locker = "NA" Then
                        chklocker.Checked = True
                    Else
                        txtlocker.Text = objdatos.locker
                    End If
                    buscarinf()
                Else
                    lblmsg.Text = "El código no se encuentran creado en la base de datos, revise la información"
                    lblnombre.Text = ""
                    rdbcarne.SelectedValue = Nothing
                    rdbchaleco.SelectedValue = Nothing
                    rdbdiadema.SelectedValue = Nothing
                    rdbuniforme.SelectedValue = Nothing
                    chklocker.Checked = False
                    txtlocker.Text = ""
                    dtggeneral.DataSource = Nothing
                    dtggeneral.DataBind()
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clsrrhh
        Try
            If lblnombre.Text = "" Then
                lblmsg.Text = "Digite el código del empleado que desea consultar junto con el ID del registro que desea modificar"
            Else
                objdatos.codigo = txtcod.Text
                If rdbcarne.SelectedValue = Nothing Then
                    lblmsg.Text = "Elija si cuenta con carné o no"
                    Exit Sub
                Else
                    objdatos.carne = rdbcarne.SelectedItem.Value
                End If
                If rdbchaleco.SelectedValue = Nothing Then
                    lblmsg.Text = "Elija si cuenta con chaleco o no"
                    Exit Sub
                Else
                    objdatos.chaleco = rdbchaleco.SelectedItem.Value
                End If
                If rdbdiadema.SelectedValue = Nothing Then
                    lblmsg.Text = "Elija si cuenta con diadema o no"
                    Exit Sub
                Else
                    objdatos.diadema = rdbdiadema.SelectedItem.Value
                End If
                If txtlocker.Text = "" And chklocker.Checked = False Then
                    lblmsg.Text = "Digite el número de locker asignado o elija la opción de no aplica"
                    Exit Sub
                Else
                    If chklocker.Checked = True Then
                        objdatos.locker = "NA"
                    Else
                        objdatos.locker = txtlocker.Text
                    End If
                End If
                If rdbuniforme.SelectedValue = Nothing Then
                    lblmsg.Text = "Elija si cuenta con uniforme o no"
                    Exit Sub
                Else
                    objdatos.uniforme = rdbuniforme.SelectedItem.Value
                End If
                objdatos.idusuario = lblusuario.Text
                objdatos.modificadotac()
                buscarinf()
                rdbuniforme.Enabled = True
                txtcod.Text = ""
                rdbuniforme.SelectedValue = Nothing
                rdbcarne.SelectedValue = Nothing
                rdbchaleco.SelectedValue = Nothing
                rdbdiadema.SelectedValue = Nothing
                txtlocker.Text = ""
                chklocker.Checked = False
                lblnombre.Text = ""
                lblmsg.Text = "Novedad ingresada con éxito"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
End Class