Imports System.Drawing

Public Class Retroalimentacion
    Inherits System.Web.UI.Page
    Dim objretro As New Clsretroalimentacion
    Dim Registrorep As Boolean = False
    Dim dts As New DataSet
    Dim Validacioncausa As Boolean = False
    Dim _Cantidad As New Clsretroalimentacion

    Property PrintAction As Object

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Obtengo los datos del usuario'
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Lblfechareg.Text = DateTime.Now.ToLongDateString()
                drlDatos()
                Consulta_Codigor()
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
    Public Sub drlDatos()
        With drlnomaretro
            .DataSource = objretro.Consulta_Retro_Usu
            .DataTextField = "nombreu"
            .DataValueField = "codnom"
            .DataBind()
        End With
        With drlnomaretrobus
            .DataSource = objretro.Consulta_Retro_Usu
            .DataTextField = "nombreu"
            .DataValueField = "codnom"
            .DataBind()
        End With
        With drlnomqretro
            .DataSource = objretro.Consulta_Retro_Usu
            .DataTextField = "nombreu"
            .DataValueField = "codnom"
            .DataBind()
        End With
        With drlnomqretrobus
            .DataSource = objretro.Consulta_Retro_Usu
            .DataTextField = "nombreu"
            .DataValueField = "codnom"
            .DataBind()
        End With
        With drlAreabus
            .DataSource = objretro.Consulta_Area
            .DataTextField = "area"
            .DataValueField = "area"
            .DataBind()
        End With
        With drlArea
            .DataSource = objretro.Consulta_Area
            .DataTextField = "area"
            .DataValueField = "area"
            .DataBind()
        End With
       
    End Sub
    Public Sub Consulta_Codigor()
        Try
            dts = objretro.Consulta_Cod
            Lblcodretro.Text = Convert.ToString(dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion"))
            If Lblcodretro.Text = "" Or Lblcodretro.Text = Nothing Then
                Lblcodretro.Text = "1"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
    Public Sub Validar_Causas()
        Try
            If txtcausa.Text = "" Then
                lblmsg.Text = "Ingrese la Causa de la Retroalimentacion"
                Exit Sub
            End If
            If txtdescausa.Text = "" Then
                lblmsg.Text = "Ingrese o complete la descripcion de la causa"
                Validacioncausa = True
                Exit Sub
            End If
            If txtcausa0.Text = "" Then
                lblmsg.Text = "Ingrese o complete la la causa"
                Validacioncausa = True
                Exit Sub
            End If
            If txtdescausa0.Text = "" Then
                lblmsg.Text = "Ingrese o complete la descripcion la causa"
                Validacioncausa = True
                Exit Sub
            End If

            If txtcausa1.Text = "" Then
                lblmsg.Text = "Ingrese o complete la causa"
                Validacioncausa = True
                Exit Sub
            End If
            If txtdescausa1.Text = "" Then
                lblmsg.Text = "Ingrese o complete la descripcion la causa"
                Validacioncausa = True
                Exit Sub
            End If
            If txtcausa2.Text = "" Then
                lblmsg.Text = "Ingrese o complete la causa"
                Validacioncausa = True
                Exit Sub
            End If
            If txtdescausa2.Text = "" Then
                lblmsg.Text = "Ingrese o complete la descripcion la causa"
                Validacioncausa = True
                Exit Sub
            End If
            If txtcausa3.Text = "" Then
                lblmsg.Text = "Ingrese o complete la causa"
                Validacioncausa = True
                Exit Sub
            End If
            If txtdescausa3.Text = "" Then
                lblmsg.Text = "Ingrese o complete la descripcion la causa"
                Validacioncausa = True
                Exit Sub
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub Limpiar_cajas()
        Try
            txtfcreg.Text = ""
            drlnomaretro.Text = ""
            drlnomqretro.Text = ""
            txtcausa.Text = ""
            txtcausa0.Text = ""
            txtcausa1.Text = ""
            txtcausa2.Text = ""
            txtcausa3.Text = ""
            txtdescausa.Text = ""
            txtdescausa0.Text = ""
            txtdescausa1.Text = ""
            txtdescausa2.Text = ""
            txtdescausa3.Text = ""
            txtobsper.Text = ""
            txtcomre.Text = ""
            txtconfin.Text = ""
            drlDatos()
            Consulta_Codigor()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try

    End Sub
    Public Sub Limpiar_cajas_2()
        Try
            txtfcregbus.Text = ""
            drlnomaretrobus.Text = ""
            drlnomqretrobus.Text = ""
            drlAreabus.Text = ""
            txtcodbus.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try

    End Sub
   

    Protected Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Try

            If txtfcreg.Text = "" Then
                lblmsg.Text = "Ingrese una Fecha de Retroalimentacion"
                Exit Sub
            End If

            If drlArea.Text = "- Elija una Opción -" Then
                lblmsg.Text = "Seleccione un Area O Nivel de Gestion"
                Exit Sub
            End If
            If drlnomaretro.Text = "" Then
                lblmsg.Text = "Ingrese el Nombre de la Persona A retroalimentar"
                Exit Sub
            End If
            If drlnomqretro.Text = "" Then
                lblmsg.Text = "Ingrese el Nombre de la Persona que retroalimenta"
                Exit Sub
            End If

            If txtcausa.Text = "" Then
                lblmsg.Text = "Ingrese    la causa  de la Retroalimentacion"
                Exit Sub
            End If
            If txtdescausa.Text = "" Then
                lblmsg.Text = "Ingrese la descripcion de la causa"
                Exit Sub
            End If

            If txtcausa0.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True

            ElseIf txtdescausa0.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
                Exit Sub
            End If
            If txtdescausa0.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True

            ElseIf txtcausa0.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
                Exit Sub
            End If
            If txtcausa1.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
            ElseIf txtdescausa1.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
                Exit Sub
            End If
            If txtdescausa1.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
            ElseIf txtcausa1.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
                Exit Sub
            End If
            If txtcausa2.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
            ElseIf txtdescausa2.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
                Exit Sub
            End If
            If txtdescausa2.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
            ElseIf txtcausa2.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
                Exit Sub
            End If

            If txtcausa3.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
            ElseIf txtdescausa3.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
                Exit Sub
            End If

            If txtdescausa3.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
            ElseIf txtcausa3.Text = "" Then
                lblmsg.Text = "Ingrese   el nombre la causa o complete la descripcion"
                Validacioncausa = True
                Exit Sub
            End If

            If txtobsper.Text = "" Then
                lblmsg.Text = "Ingrese La observacion de la Retroalimentacion "
                Exit Sub
            End If

            If txtcomre.Text = "" Then
                lblmsg.Text = "Ingrese el Compromiso del Retroalimentado "
                Exit Sub
            End If

            If txtconfin.Text = "" Then
                lblmsg.Text = "Ingrese La conclusion final o plan de Accion a ejecutar "
                Exit Sub
            End If
         
            objretro.Fecha_Retro = txtfcreg.Text
            objretro.Cod_Usuario = drlnomaretro.Text
            objretro.Nombre_Usu = drlnomaretro.SelectedItem.Text
            objretro.Id_Usuario = lblusuario.Text
            objretro.Area = drlArea.Text
            objretro.Cod_Retro = drlnomqretro.Text
            objretro.Nombre_Retro = drlnomqretro.SelectedItem.Text
            objretro.Observacion = txtobsper.Text
            objretro.Compromiso_Usu = txtcomre.Text
            objretro.Conclusion = txtconfin.Text
            objretro.Ingresar()

            If txtcausa.Text > "" Then
                objretro.Descripcion_Causa = txtdescausa.Text
                objretro.Causas = txtcausa.Text
                objretro.Fk_Cod_Retroalimentacion = Lblcodretro.Text
                objretro.Ingresar2()
            End If

            If txtcausa0.Text > "" Then
                objretro.Fk_Cod_Retroalimentacion = Lblcodretro.Text
                objretro.Descripcion_Causa = txtdescausa0.Text
                objretro.Causas = txtcausa0.Text
                objretro.Ingresar2()
            End If

            If txtcausa1.Text > "" Then
                objretro.Fk_Cod_Retroalimentacion = Lblcodretro.Text
                objretro.Descripcion_Causa = txtdescausa1.Text
                objretro.Causas = txtcausa1.Text
                objretro.Ingresar2()
            End If

            If txtcausa2.Text > "" Then
                objretro.Fk_Cod_Retroalimentacion = Lblcodretro.Text
                objretro.Descripcion_Causa = txtdescausa2.Text
                objretro.Causas = txtcausa2.Text
                objretro.Ingresar2()
            End If

            If txtcausa3.Text > "" Then
                objretro.Fk_Cod_Retroalimentacion = Lblcodretro.Text
                objretro.Descripcion_Causa = txtdescausa3.Text
                objretro.Causas = txtcausa3.Text
                objretro.Ingresar2()
            End If
          

            lblmsg.Text = "Retroalimentacion  registrada "

            Limpiar_cajas()

        Catch ex As Exception
            lblmsg.Text = "Verifique los datos Error: " & ex.Message
            lblmsg.Text = ""
        End Try

    End Sub


    Protected Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            Limpiar_cajas()
            drlArea.SelectedItem.Text = "- Elija una Opción -"

        Catch ex As Exception
            lblmsg.Text = "Verifique los datos Error: " & ex.Message
        End Try
    End Sub

    Protected Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Try
            Plcons.Visible = False
            Panelkam.Visible = False

            Lblfcreg.Text = txtfcreg.Text
            txtfcreg.Visible = False

            Lblarea.Text = drlArea.Text
            drlArea.Visible = False

            Lblnoma.Text = drlnomaretro.SelectedItem.Text
            drlnomaretro.Visible = False

            Lblnomq.Text = drlnomqretro.SelectedItem.Text
            drlnomqretro.Visible = False

            Lblcau.Text = txtcausa.Text
            txtcausa.Visible = False

            Lbldcau.Text = txtdescausa.Text
            txtdescausa.Visible = False


            Lblcau0.Text = txtcausa0.Text
            txtcausa0.Visible = False

            Lbldcau0.Text = txtdescausa0.Text
            txtdescausa0.Visible = False

            lblcau1.Text = txtcausa1.Text
            txtcausa1.Visible = False

            Lbldcau1.Text = txtdescausa1.Text
            txtdescausa1.Visible = False

            Lblcau2.Text = txtcausa2.Text
            txtcausa2.Visible = False

            Lbldcau2.Text = txtdescausa2.Text
            txtdescausa2.Visible = False

            Lblcau3.Text = txtcausa3.Text
            txtcausa3.Visible = False

            Lbldcau3.Text = txtdescausa3.Text
            txtdescausa3.Visible = False

            Lblobs.Text = txtobsper.Text
            txtobsper.Visible = False

            Lblcom.Text = txtcomre.Text
            txtcomre.Visible = False

            Lblconf.Text = txtconfin.Text
            txtconfin.Visible = False


        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub



    '        menu.Visible = True
    '    End If
    'End If
    'If BtnNuevo.Visible = True Then
    '    BtnNuevo.Visible = False
    'End If
    'If menu.Visible = True Then
    '    menu.Visible = False
    'End If
    'If btnimprimir.Visible = True Then
    '    btnimprimir.Visible = False




    'Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    If btnguardar.Visible = False Then
    '        btnguardar.Visible = True
    '    End If
    '    If BtnNuevo.Visible = False Then
    '        BtnNuevo.Visible = True
    '    End If
    '    If menu.Visible = False Then
    '        menu.Visible = True
    '    End If
    '    If btnimprimir.Visible = False Then
    '        btnimprimir.Visible = True
    '    End If
    'End Sub

    Protected Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        If txtcodbus.Text = "" Then

            Try
                If txtfcregbus.Text = "" Then
                    lblmsg.Text = "Ingrese una Fecha de Busqueda o codigo de retroalimentacion"
                    Exit Sub
                    txtfcregbus.Text = ""
                Else
                    If drlAreabus.Text = "- Elija una Opción -" Then
                        lblmsg.Text = "Ingrese una Area para la Busqueda"
                        Exit Sub
                    Else
                        If drlnomaretrobus.Text = "" Then
                            lblmsg.Text = "Ingrese el Nombre de la persona retroalimentada para la Busqueda"
                            Exit Sub
                        Else
                            If drlnomqretrobus.Text = "" Then
                                lblmsg.Text = "Ingrese el Nombre de la persona que realizo la  retroalimentacion  para la Busqueda"

                                Exit Sub

                            End If
                            Dim dts As DataSet
                            objretro.Cod_Usuario = drlnomaretrobus.Text
                            objretro.Cod_Retro = drlnomqretrobus.Text
                            objretro.Fecha_Retro = txtfcregbus.Text
                            objretro.Area = drlAreabus.Text
                            dts = objretro.consultausu1
                            If dts.Tables(0).Rows.Count > 0 Then
                                lblmsg.Text = ""
                                drlnomaretro.Text = objretro.Cod_Usuario
                                drlArea.Text = objretro.Area
                                drlnomqretro.Text = objretro.Cod_Retro
                                txtfcreg.Text = objretro.Fecha_Retro
                                Lblcodretro.Text = objretro.Cod_Retroalimentacion

                                'CAUSAS
                                If dts.Tables(0).Rows.Count >= 1 Then
                                    txtcausa.Text = Convert.ToString(dts.Tables(0).Rows(0).Item("Causas"))
                                Else
                                    txtcausa.Text = ""
                                End If
                                If dts.Tables(0).Rows.Count >= 2 Then
                                    txtcausa0.Text = Convert.ToString(dts.Tables(0).Rows(1).Item("Causas"))
                                Else
                                    txtcausa0.Text = ""
                                End If
                                If dts.Tables(0).Rows.Count >= 3 Then
                                    txtcausa1.Text = Convert.ToString(dts.Tables(0).Rows(2).Item("Causas"))
                                Else
                                    txtcausa1.Text = ""
                                End If
                                If dts.Tables(0).Rows.Count >= 4 Then
                                    txtcausa2.Text = Convert.ToString(dts.Tables(0).Rows(3).Item("Causas"))
                                Else
                                    txtcausa2.Text = ""
                                End If
                                If dts.Tables(0).Rows.Count >= 5 Then
                                    txtcausa3.Text = Convert.ToString(dts.Tables(0).Rows(4).Item("Causas"))
                                Else
                                    txtcausa3.Text = ""
                                End If
                                'DESCAUSA
                                If dts.Tables(0).Rows.Count >= 1 Then
                                    txtdescausa.Text = Convert.ToString(dts.Tables(0).Rows(0).Item("Descripcion"))
                                Else
                                    txtdescausa.Text = ""
                                End If
                                If dts.Tables(0).Rows.Count >= 2 Then
                                    txtdescausa0.Text = Convert.ToString(dts.Tables(0).Rows(1).Item("Descripcion"))
                                Else
                                    txtdescausa0.Text = ""
                                End If
                                If dts.Tables(0).Rows.Count >= 3 Then
                                    txtdescausa1.Text = Convert.ToString(dts.Tables(0).Rows(2).Item("Descripcion"))
                                Else
                                    txtdescausa1.Text = ""
                                End If
                                If dts.Tables(0).Rows.Count >= 4 Then
                                    txtdescausa2.Text = Convert.ToString(dts.Tables(0).Rows(3).Item("Descripcion"))
                                Else
                                    txtdescausa2.Text = ""
                                End If
                                If dts.Tables(0).Rows.Count >= 5 Then
                                    txtdescausa3.Text = Convert.ToString(dts.Tables(0).Rows(4).Item("Descripcion"))
                                Else
                                    txtdescausa3.Text = ""
                                End If
                                'OBSERVSACION
                                txtobsper.Text = objretro.Observacion
                                txtcomre.Text = objretro.Compromiso_Usu
                                txtconfin.Text = objretro.Conclusion

                            Else
                                lblmsg.Text = "no existen coincidencias para la busqueda con esos parametros"
                                Exit Sub

                            End If
                        End If
                    End If
                End If

            Catch ex As Exception
                lblmsg.Text = "Se produjo error:" + ex.Message
            End Try
        Else
            Try
                Consulta_codigo()
            Catch ex As Exception
                lblmsg.Text = "Se produjo error:" + ex.Message
            End Try
        End If
    End Sub

    Public Sub Consulta_codigo()
        Try
            Dim dts2 As DataSet
            objretro.Cod_Retroalimentacion = txtcodbus.Text
            If objretro.Cod_Retroalimentacion <> Nothing Then
                Limpiar_cajas()
            End If
            dts2 = objretro.consultausu2
            If dts2.Tables(0).Rows.Count > 0 Then
                drlnomaretro.Text = objretro.Cod_Usuario
                drlArea.Text = objretro.Area
                drlnomqretro.Text = objretro.Cod_Retro
                txtfcreg.Text = objretro.Fecha_Retro
                Lblcodretro.Text = objretro.Cod_Retroalimentacion

                'CAUSAS
                If dts2.Tables(0).Rows.Count >= 1 Then
                    txtcausa.Text = dts2.Tables(0).Rows(0).Item("Causas")
                Else
                    txtcausa.Text = ""
                End If
                If dts2.Tables(0).Rows.Count >= 2 Then
                    txtcausa0.Text = dts2.Tables(0).Rows(1).Item("Causas")
                Else
                    txtcausa0.Text = ""
                End If
                If dts2.Tables(0).Rows.Count >= 3 Then
                    txtcausa1.Text = dts2.Tables(0).Rows(2).Item("Causas")
                Else
                    txtcausa1.Text = ""
                End If
                If dts2.Tables(0).Rows.Count >= 4 Then
                    txtcausa2.Text = dts2.Tables(0).Rows(3).Item("Causas")
                Else
                    txtcausa2.Text = ""
                End If
                If dts2.Tables(0).Rows.Count >= 5 Then
                    txtcausa3.Text = dts2.Tables(0).Rows(4).Item("Causas")
                Else
                    txtcausa3.Text = ""
                End If

                'DESCAUSA

                If dts2.Tables(0).Rows.Count >= 1 Then
                    txtdescausa.Text = dts2.Tables(0).Rows(0).Item("Descripcion")
                Else
                    txtdescausa.Text = ""
                End If
                If dts2.Tables(0).Rows.Count >= 2 Then
                    txtdescausa0.Text = dts2.Tables(0).Rows(1).Item("Descripcion")
                Else
                    txtdescausa0.Text = ""
                End If
                If dts2.Tables(0).Rows.Count >= 3 Then
                    txtdescausa1.Text = dts2.Tables(0).Rows(2).Item("Descripcion")
                Else
                    txtdescausa1.Text = ""
                End If
                If dts2.Tables(0).Rows.Count >= 4 Then
                    txtdescausa2.Text = dts2.Tables(0).Rows(3).Item("Descripcion")
                Else
                    txtdescausa2.Text = ""
                End If
                If dts2.Tables(0).Rows.Count >= 5 Then
                    txtdescausa3.Text = dts2.Tables(0).Rows(4).Item("Descripcion")
                Else
                    txtdescausa3.Text = ""
                End If

                'OBSERVSACION
                txtobsper.Text = objretro.Observacion
                txtcomre.Text = objretro.Compromiso_Usu
                txtconfin.Text = objretro.Conclusion

            Else
                lblmsg.Text = "no existe ninguna retroalimentacion con el codigo"
            End If
            txtcodbus.Text = ""

        Catch ex As Exception
            lblmsg.Text = "Se produjo error:" + ex.Message
        End Try

    End Sub

End Class