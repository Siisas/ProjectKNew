Imports System.IO
Public Class regrrhh
    Inherits System.Web.UI.Page
    Dim Obj_General As New clsgeneral
    Dim Obj_Datos As New clscrmdatos
    Dim Obj_Personal As New clsrrhh
    Dim Obj_G_Datos As New Cls_Gestion_Datos
    'ATENCIÓN las validaciones con perfiles 49 y 35 se deben eliminar luego de terminada la gestión de los permisos llevada a cavo los mese 6 y 7 del año 2016
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("permisos") Is Nothing Then
                Response.Redirect("~/entrada.aspx?ReturnUrl=" & Request.RawUrl)
            End If
            Lbl_Alerta.Text = Nothing
            Pnl_Alerta.CssClass = Nothing
            If Not IsPostBack Then
                Dim Obj_Personal As New clsgeneral
                Dim dt As New DataSet
                Session("Formulario") = "Registro Recursos Humanos"
                Cargar_drl()
                If CType(Session("permisos"), clsusuario).NomPerfil <> "Gerente TH" And CType(Session("permisos"), clsusuario).NomPerfil <> "Aux TH" And CType(Session("permisos"), clsusuario).perfil <> 49 And CType(Session("permisos"), clsusuario).perfil <> 35 And CType(Session("permisos"), clsusuario).perfil <> 3 Then
                    Inha_Cam_Personales_Laboral()
                End If
                If CType(Session("permisos"), clsusuario).NomPerfil <> "Análista SST" And CType(Session("permisos"), clsusuario).NomPerfil <> "Gerente TH" And CType(Session("permisos"), clsusuario).perfil <> 3 Then
                    Inha_Cam_Extra()
                End If
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Public Sub Inha_Cam_Personales_Laboral()
        Try
            Pnl_Datos_Laborales.Visible = False
            txtcodigo.Enabled = False
            txtnombres.Enabled = False
            txtapellidos.Enabled = False
            drleps.Enabled = False
            drlfps.Enabled = False
            drlJefe_Inmediato.Enabled = False
            txtdireccion.Enabled = False
            txttelefono.Enabled = False
            txtfcnac.Enabled = False
            txtemail.Enabled = False
            drlgenero.Enabled = False
            Drl_Estado_Civil.Enabled = False
            Drl_TI.Enabled = False
            txtnhijos.Enabled = False
            txtrh.Enabled = False
            Drl_Nivel_Academico.Enabled = False
            txtprofesion.Enabled = False
            rbtestudia.Enabled = False
            txtobs.Enabled = False
            drlDescanso.Enabled = False
            TxtUbicacion.Enabled = False
            Drl_Nacionalidad.Enabled = False
            Drl_Pais_Nacimiento.Enabled = False
            Drl_Estado_Nacimiento.Enabled = False
            Drl_Ciudad_Nacimiento.Enabled = False
            Txt_Semestre_Actual_U.Enabled = False
            File_Fotografia.Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Inha_Cam_Extra()
        Try
            Txt_Tel_Contac_Emerg.Enabled = False
            Txt_Ant_Salud.Enabled = False
            Txt_Contac_Emerg.Enabled = False
            Drl_Medicamentos.Enabled = False
            Txt_Obs_Medicamentos.Enabled = False
            Btn_Act_Dat_Ext.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Cargar_drl()
        Try
            With drleps
                .DataSource = Obj_Personal.Consultar_EPS
                .DataTextField = "epsdes"
                .DataValueField = "ideps"
                .DataBind()
            End With
            With drlfps
                .DataSource = Obj_Personal.Consultar_FPS
                .DataTextField = "pensiondes"
                .DataValueField = "idpension"
                .DataBind()
            End With
            With Drl_Medicamentos
                .Items.Add("- Seleccione -")
                .Items.Add("SI")
                .Items.Add("NO")
                .Items(0).Value = 0
            End With
            With drlempresa
                .DataSource = Obj_Personal.Consultar_Complementos_Personal("Empresas")
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With drlgenero
                .Items.Add("- Seleccione -")
                .Items.Add("M")
                .Items.Add("F")
                .Items(0).Value = 0
            End With
            With drlproyecto
                .DataSource = Obj_General.consultaproyecto
                .DataTextField = "nombreproyecto"
                .DataValueField = "idproyecto"
                .DataBind()
                .Items(0).Value = 0
            End With
            With drlarea
                .DataSource = Obj_General.consultaarea
                .DataTextField = "area"
                .DataValueField = "idarea"
                .DataBind()
                .Items(0).Text = "- Seleccione -"
                .Items(0).Value = 0
            End With
            With drlJefe_Inmediato
                .DataSource = Obj_Personal.Consultar_Jefes()
                .DataTextField = "Jefe_Inmediato"
                .DataValueField = "Jefe_Inmediato"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Nivel_Academico
                .DataSource = Obj_Personal.Consultar_Complementos_Personal("Niveles Académicos")
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Estado_Civil
                .DataSource = Obj_Personal.Consultar_Complementos_Personal("Estados Civiles")
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Turno
                .DataSource = Obj_Personal.Consultar_Complementos_Personal("Turnos")
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Tipo_Contrato
                .DataSource = Obj_Personal.Consultar_Complementos_Personal("Tipos Contratos")
                .DataTextField = "Nombre"
                .DataValueField = "Id"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With drlDescanso
                .DataSource = Obj_Personal.Consultar_Complementos_Personal("Descansos")
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_TI
                .DataSource = Obj_Personal.Consultar_Complementos_Personal("TI")
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Nacionalidad
                .DataSource = Obj_General.Consultar_DivPol_Paises()
                .DataTextField = "Nombre"
                .DataValueField = "Id"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Pais_Nacimiento
                .DataSource = Obj_General.Consultar_DivPol_Paises()
                .DataTextField = "Nombre"
                .DataValueField = "Id"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Estado_Nacimiento
                .Items.Clear()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Ciudad_Nacimiento
                .Items.Clear()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Cargar_Drl_Estado_Nacimiento(ByVal Id_Pais As Integer)
        Try
            Obj_General.DivPol_Id_Pais = Id_Pais
            With Drl_Estado_Nacimiento
                .DataSource = Obj_General.Consultar_DivPol_Estados()
                .DataTextField = "Nombre"
                .DataValueField = "Id"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
            With Drl_Ciudad_Nacimiento
                .Items.Clear()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Cargar_Drl_Ciudad_Nacimiento(ByVal Id_Estado As Integer)
        Try
            Obj_General.DivPol_Id_Estado = Id_Estado
            With Drl_Ciudad_Nacimiento
                .DataSource = Obj_General.Consultar_DivPol_Ciudades()
                .DataTextField = "Nombre"
                .DataValueField = "Id"
                .DataBind()
                .Items.Insert(0, "- Seleccione -")
                .Items(0).Value = 0
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Drl_Pais_Nacimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Pais_Nacimiento.SelectedIndexChanged
        Try
            Cargar_Drl_Estado_Nacimiento(Drl_Pais_Nacimiento.SelectedValue)
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Estado_Nacimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Estado_Nacimiento.SelectedIndexChanged
        Try
            Cargar_Drl_Ciudad_Nacimiento(Drl_Estado_Nacimiento.SelectedValue)
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Drl_Medicamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Drl_Medicamentos.SelectedIndexChanged
        Try
            If Drl_Medicamentos.SelectedValue = "SI" Then
                Txt_Obs_Medicamentos.Enabled = True
                RFV_Txt_Obs_Medicamentos.Enabled = True
            Else
                Txt_Obs_Medicamentos.Text = Nothing
                Txt_Obs_Medicamentos.Enabled = False
                RFV_Txt_Obs_Medicamentos.Enabled = False
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub rbtestudia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rbtestudia.SelectedIndexChanged
        Try
            If rbtestudia.SelectedItem.Value = "SI" Then
                Txt_Semestre_Actual_U.Enabled = True
                RFV_Txt_Semestre_Actual_U.Enabled = True
            Else
                Txt_Semestre_Actual_U.Text = Nothing
                Txt_Semestre_Actual_U.Enabled = False
                RFV_Txt_Semestre_Actual_U.Enabled = False
            End If

        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Registrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Registrar.Click
        Try
            If Val_RegAc_Personal() Then
                If File_Fotografia.HasFile Then
                    File_Fotografia.PostedFile.SaveAs(Server.MapPath("data_fotos") & "\\" & System.IO.Path.GetFileName(File_Fotografia.PostedFile.FileName))
                    Obj_Personal.rutafoto = System.IO.Path.GetFileName(File_Fotografia.PostedFile.FileName)
                End If
                ''''''''''''''opcionales'''''''''''''''''
                Obj_Personal.bonificacion = txtbonificacion.Text
                Obj_Personal.salario = txtsalario.Text
                Obj_Personal.auxtransp = txtauxtransp.Text
                Obj_Personal.hijos = txtnhijos.Text
                Obj_Personal.Descanso = drlDescanso.Text
                Obj_Personal.Jefe_Inmediato = drlJefe_Inmediato.Text
                Obj_Personal.Ubicacion = TxtUbicacion.Text
                Obj_Personal.direccion = txtdireccion.Text
                Obj_Personal.email = txtemail.Text
                Obj_Personal.rh = txtrh.Text
                Obj_Personal.profesion = txtprofesion.Text
                Obj_Personal.Observacion = txtobs.Text
                Obj_Personal.cargo = txtcargo.Text
                Obj_Personal.Segmento = TxtSegmento.Text
                Obj_Personal.Cargo_Cliente = TxtCargo_Cliente.Text
                ''''''''''''''''''''''''
                Obj_Personal.fcnovedad = TxtFechaIng.Text
                Obj_Personal.fcnac = txtfcnac.Text
                Obj_Personal.fcing = txtfcing.Text
                Obj_Personal.fcretiro = txtfcretiro.Text
                Obj_Personal.documento = txtdocumento.Text
                Obj_Personal.nombres = txtnombres.Text
                Obj_Personal.apellidos = txtapellidos.Text
                Obj_Personal.codigo = txtcodigo.Text
                Obj_Personal.telefono = txttelefono.Text
                Obj_Personal.tipodoc = Drl_TI.Text
                Obj_Personal.eps = drleps.SelectedItem.Value
                Obj_Personal.fps = drlfps.SelectedItem.Value
                Obj_Personal.genero = drlgenero.SelectedItem.Value
                Obj_Personal.estadocivil = Drl_Estado_Civil.SelectedItem.Value
                Obj_Personal.escolaridad = Drl_Nivel_Academico.SelectedItem.Value
                Obj_Personal.estudia = rbtestudia.SelectedItem.Value
                Obj_Personal.proyecto = drlproyecto.SelectedItem.Value
                Obj_Personal.area = drlarea.SelectedItem.Value
                Obj_Personal.tipocont = Drl_Tipo_Contrato.SelectedItem.Value
                Obj_Personal.turno = Drl_Turno.SelectedItem.Value
                Obj_Personal.empresa = drlempresa.SelectedItem.Value
                Obj_Personal.Id_Nacionalidad = Drl_Nacionalidad.SelectedValue
                Obj_Personal.Id_Ciudad_Nacimiento = Drl_Ciudad_Nacimiento.SelectedValue
                Obj_Personal.Semestre_Actual_U = Txt_Semestre_Actual_U.Text
                Obj_Personal.idusuario = CType(Session("permisos"), clsusuario).usuario
                If Obj_Personal.Registro_Personal() = 1 Then
                    Pnl_Alerta.CssClass = "alert alert-success"
                    Lbl_Alerta.Text = "<span class='glyphicon glyphicon-ok-circle'></span> Registro ingresado con éxito"
                    limpiar()
                Else
                    Pnl_Alerta.CssClass = "alert alert-warning"
                    Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ya existe un usuario con el mismo número de documento"
                End If

            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Actualizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Actualizar.Click
        Try
            If Val_RegAc_Personal() Then
                If File_Fotografia.HasFile Then
                    File_Fotografia.PostedFile.SaveAs(Server.MapPath("data_fotos") & "\\" & System.IO.Path.GetFileName(File_Fotografia.PostedFile.FileName))
                    Obj_Personal.rutafoto = System.IO.Path.GetFileName(File_Fotografia.PostedFile.FileName)
                Else
                    Obj_Personal.rutafoto = ""
                End If
                Obj_Personal.Descanso = drlDescanso.Text
                Obj_Personal.Jefe_Inmediato = drlJefe_Inmediato.Text
                Obj_Personal.salario = txtsalario.Text
                Obj_Personal.bonificacion = txtbonificacion.Text
                Obj_Personal.auxtransp = txtauxtransp.Text
                Obj_Personal.fcing = txtfcing.Text
                Obj_Personal.fcretiro = txtfcretiro.Text
                Obj_Personal.Ubicacion = TxtUbicacion.Text
                Obj_Personal.direccion = txtdireccion.Text
                Obj_Personal.fcnac = txtfcnac.Text
                Obj_Personal.email = txtemail.Text
                Obj_Personal.hijos = txtnhijos.Text
                Obj_Personal.rh = txtrh.Text
                Obj_Personal.profesion = txtprofesion.Text
                Obj_Personal.obs = txtobs.Text
                Obj_Personal.cargo = txtcargo.Text
                Obj_Personal.Segmento = TxtSegmento.Text
                Obj_Personal.Cargo_Cliente = TxtCargo_Cliente.Text

                Obj_Personal.fcnovedad = TxtFechaIng.Text
                Obj_Personal.rutahv = ""
                Obj_Personal.cuenta = ""
                Obj_Personal.deporte = ""
                Obj_Personal.Aclaracion = ""
                Obj_Personal.documento = txtdocumento.Text
                Obj_Personal.nombres = txtnombres.Text
                Obj_Personal.apellidos = txtapellidos.Text
                Obj_Personal.codigo = txtcodigo.Text
                Obj_Personal.telefono = txttelefono.Text
                Obj_Personal.tipodoc = Drl_TI.Text
                Obj_Personal.eps = drleps.SelectedItem.Value
                Obj_Personal.fps = drlfps.SelectedItem.Value
                Obj_Personal.genero = drlgenero.SelectedItem.Value
                Obj_Personal.estadocivil = Drl_Estado_Civil.SelectedItem.Value
                Obj_Personal.escolaridad = Drl_Nivel_Academico.SelectedItem.Value
                Obj_Personal.estudia = rbtestudia.SelectedItem.Value
                Obj_Personal.proyecto = drlproyecto.SelectedItem.Value
                Obj_Personal.area = drlarea.SelectedItem.Value
                Obj_Personal.tipocont = Drl_Tipo_Contrato.SelectedItem.Value
                Obj_Personal.turno = Drl_Turno.SelectedItem.Value
                Obj_Personal.empresa = drlempresa.SelectedItem.Value
                Obj_Personal.Id_Nacionalidad = Drl_Nacionalidad.SelectedValue
                Obj_Personal.Id_Ciudad_Nacimiento = Drl_Ciudad_Nacimiento.SelectedValue
                Obj_Personal.Semestre_Actual_U = Txt_Semestre_Actual_U.Text
                Obj_Personal.idusuario = CType(Session("permisos"), clsusuario).usuario
                If Obj_Personal.Actualizar_Personal() >= 1 Then
                    Pnl_Alerta.CssClass = "alert alert-success"
                    Lbl_Alerta.Text = "<span class='glyphicon glyphicon-ok-circle'></span> Registro modificado con éxito"
                    limpiar()
                Else
                    Pnl_Alerta.CssClass = "alert alert-warning"
                    Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> el registro no se ha podido modificar"
                End If
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Consultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Consultar.Click
        Try
            If txtdocumento.Text <> Nothing Then
                Obj_Personal.documento = txtdocumento.Text
                Dim Dtt As DataTable = Obj_Personal.Consulta_Personal(False)
                If Dtt.Rows.Count > 0 Then
                    Dim Dtr As DataRow = Dtt.Rows(0)
                    If Dtr.Item("Fecha_Inicio_Operacion").ToString = Nothing Then
                        TxtFechaIng.Enabled = True
                    Else
                        TxtFechaIng.Enabled = False
                    End If
                    txtnombres.Text = Dtr.Item("nombres").ToString
                    txtapellidos.Text = Dtr.Item("apellidos").ToString
                    txtcodigo.Text = Dtr.Item("codigo").ToString
                    drleps.SelectedValue = Dtr.Item("eps").ToString
                    drlfps.SelectedValue = Dtr.Item("fps").ToString
                    txtdireccion.Text = Dtr.Item("direccion").ToString
                    txttelefono.Text = Dtr.Item("telefono").ToString
                    txtemail.Text = Dtr.Item("email").ToString
                    drlgenero.SelectedValue = Dtr.Item("genero").ToString
                    Drl_Estado_Civil.SelectedValue = Dtr.Item("estadocivil").ToString
                    txtnhijos.Text = Dtr.Item("hijos").ToString
                    txtrh.Text = Dtr.Item("rh").ToString
                    Drl_Nivel_Academico.SelectedValue = Dtr.Item("escolaridad").ToString
                    txtprofesion.Text = Dtr.Item("profesion").ToString
                    txtobs.Text = Dtr.Item("obs").ToString
                    txtcargo.Text = Dtr.Item("cargo").ToString
                    Drl_TI.SelectedValue = Dtr.Item("Tipo_Doc").ToString
                    drlproyecto.SelectedValue = Dtr.Item("idproyecto").ToString
                    TxtSegmento.Text = Dtr.Item("Segmento").ToString
                    TxtCargo_Cliente.Text = Dtr.Item("Cargo_Cliente").ToString
                    drlarea.SelectedValue = Dtr.Item("idarea").ToString
                    Drl_Tipo_Contrato.SelectedValue = Dtr.Item("idtipocont").ToString
                    txtsalario.Text = Dtr.Item("salario").ToString
                    txtbonificacion.Text = Dtr.Item("bonificacion").ToString
                    txtauxtransp.Text = Dtr.Item("auxtransp").ToString
                    Drl_Turno.SelectedValue = Dtr.Item("turno").ToString
                    drlempresa.SelectedValue = Dtr.Item("empresa").ToString
                    TxtUbicacion.Text = Dtr.Item("Ubicacion").ToString
                    rbtestudia.SelectedValue = Dtr.Item("estudia").ToString
                    Txt_Semestre_Actual_U.Text = Dtr.Item("Semestre_Actual_U").ToString

                    If Dtr.Item("estudia").ToString = "SI" Then
                        Txt_Semestre_Actual_U.Enabled = True
                        RFV_Txt_Semestre_Actual_U.Enabled = True
                    Else
                        Txt_Semestre_Actual_U.Enabled = False
                        RFV_Txt_Semestre_Actual_U.Enabled = False
                    End If
                    Txt_Contac_Emerg.Text = Dtr.Item("Pers_Contac_Emerg").ToString
                    Txt_Tel_Contac_Emerg.Text = Dtr.Item("Tel_Contac_Emerg").ToString
                    Txt_Ant_Salud.Text = Dtr.Item("Ant_Pers_Salud").ToString
                    txtfcnac.Text = Dtr.Item("fcnac").ToString
                    txtfcing.Text = Dtr.Item("fcing").ToString
                    txtfcretiro.Text = Dtr.Item("fcretiro").ToString
                    If Dtr.Item("Fecha_Inicio_Operacion") IsNot DBNull.Value Then
                        TxtFechaIng.Text = Dtr.Item("Fecha_Inicio_Operacion")
                    End If
                    If Dtr.Item("Id_Pais_Nacionalidad").ToString <> Nothing Then
                        Drl_Nacionalidad.SelectedValue = Dtr.Item("Id_Pais_Nacionalidad")
                    End If
                    If Dtr.Item("Id_Pais_Nacimiento").ToString <> Nothing And Dtr.Item("Id_Estado_Nacimiento").ToString <> Nothing And Dtr.Item("Id_Ciudad_Nacimiento").ToString <> Nothing Then
                        Drl_Pais_Nacimiento.SelectedValue = Dtr.Item("Id_Pais_Nacimiento")
                        Cargar_Drl_Estado_Nacimiento(Drl_Pais_Nacimiento.SelectedValue)
                        Drl_Estado_Nacimiento.SelectedValue = Dtr.Item("Id_Estado_Nacimiento")
                        Cargar_Drl_Ciudad_Nacimiento(Drl_Estado_Nacimiento.SelectedValue)
                        Drl_Ciudad_Nacimiento.SelectedValue = Dtr.Item("Id_Ciudad_Nacimiento")
                    End If
                    If Dtr.Item("Descanso").ToString <> Nothing Then
                        drlDescanso.SelectedValue = Dtr.Item("Descanso")
                    Else
                        drlDescanso.SelectedIndex = 0
                    End If
                    If Dtr.Item("Jefe_Inmediato").ToString <> Nothing Then
                        drlJefe_Inmediato.SelectedValue = Dtr.Item("Jefe_Inmediato")
                    Else
                        drlJefe_Inmediato.SelectedIndex = 0
                    End If
                    Txt_Obs_Medicamentos.Text = Dtr.Item("Medicamentos").ToString
                    If Dtr.Item("Toma_Medicamentos").ToString <> Nothing Then
                        Drl_Medicamentos.SelectedValue = Dtr.Item("Toma_Medicamentos").ToUpper
                        RFV_Txt_Obs_Medicamentos.Enabled = True
                    Else
                        RFV_Txt_Obs_Medicamentos.Enabled = False
                        Drl_Medicamentos.SelectedIndex = 0
                    End If
                Else
                    Pnl_Alerta.CssClass = "alert alert-warning"
                    Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> El documento digitado no corresponde a un empleado, verifique la información"
                End If

            Else
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Ingrese el número de documento del empleado que desea consultar"
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "show_loding", "PlegDes_Dinamico('#Desp_Loading', 'show', 'puff', 500, '');", True)
        End Try
    End Sub
    Protected Sub limpiar()
        Try
            txtdocumento.Text = Nothing
            txtnombres.Text = Nothing
            txtdireccion.Text = Nothing
            txtfcnac.Text = Nothing
            txtnhijos.Text = Nothing
            TxtUbicacion.Text = Nothing
            txtcodigo.Text = Nothing
            txtapellidos.Text = Nothing
            txttelefono.Text = Nothing
            txtemail.Text = Nothing
            txtrh.Text = Nothing
            txtprofesion.Text = Nothing
            txtobs.Text = Nothing
            txtcargo.Text = Nothing
            TxtSegmento.Text = Nothing
            txtsalario.Text = Nothing
            txtauxtransp.Text = Nothing
            txtfcing.Text = Nothing
            TxtFechaIng.Text = Nothing
            TxtCargo_Cliente.Text = Nothing
            txtbonificacion.Text = Nothing
            txtfcretiro.Text = Nothing
            Txt_Tel_Contac_Emerg.Text = Nothing
            Txt_Obs_Medicamentos.Text = Nothing
            Txt_Ant_Salud.Text = Nothing
            Txt_Contac_Emerg.Text = Nothing
            rbtestudia.SelectedValue = Nothing
            Drl_TI.SelectedIndex = 0
            drleps.SelectedIndex = 0
            drlfps.SelectedIndex = 0
            drlgenero.SelectedIndex = 0
            Drl_Nivel_Academico.SelectedIndex = 0
            drlDescanso.SelectedIndex = 0
            drlJefe_Inmediato.SelectedIndex = 0
            Drl_Nacionalidad.SelectedIndex = 0
            Drl_Pais_Nacimiento.SelectedIndex = 0
            Drl_Estado_Nacimiento.SelectedIndex = 0
            Drl_Ciudad_Nacimiento.SelectedIndex = 0
            Drl_Estado_Civil.SelectedIndex = 0
            drlarea.SelectedIndex = 0
            drlempresa.SelectedIndex = 0
            drlproyecto.SelectedIndex = 0
            Drl_Tipo_Contrato.SelectedIndex = 0
            Drl_Turno.SelectedIndex = 0
            Drl_Medicamentos.SelectedIndex = 0
            Txt_Semestre_Actual_U.Text = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Function Val_RegAc_Personal()
        Try
            If txtdocumento.Text = Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el documento de identificación"
                Return False
            End If
            If txtnombres.Text = Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite los nombres"
                Return False
            End If
            If txtapellidos.Text = Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite los apellidos"
                Return False
            End If
            If txtcodigo.Text = Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el código asignado"
                Return False
            End If
            If drleps.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija la EPS"
                Return False
            End If
            If drlfps.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Elija la FPS"
                Return False
            End If
            If txttelefono.Text = Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Digite el número de teléfono"
                Return False
            End If
            If drlgenero.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Elija el género"
                Return False
            End If
            If Drl_Estado_Civil.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Elija el estado civil"
                Return False
            End If
            If Drl_Nivel_Academico.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Elija el nivel de escolaridad"
                Return False
            End If
            If rbtestudia.SelectedItem Is Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Elija la opción si estudia o no"
                Return False
            End If
            If Drl_TI.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Seleccione el tipo de documento"
                Return False
            End If


            If drlproyecto.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Elija el proyecto al cual se asigna"
                Return False
            End If
            If drlarea.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Digite el área asignada"
                Return False
            End If
            If Drl_Tipo_Contrato.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Elija el tipo de contrato"
                Return False
            End If
            If Drl_Turno.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Elija el turno"
                Return False
            End If
            If drlempresa.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span>Elija la Empresa"
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Protected Sub Btn_Carga_Masiva_File_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Carga_Masiva.Click
        Try
            If Path.GetExtension(File_Carga_Masiva.FileName).ToLower() = ".xlsx" Then
                File_Carga_Masiva.SaveAs(Server.MapPath("~/Documento/" & Path.GetFileName(File_Carga_Masiva.FileName)))
                Obj_Personal.Fc_ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Server.MapPath("~/Documento/" & Path.GetFileName(File_Carga_Masiva.FileName)) & ";Extended Properties=Excel 12.0;"
                Obj_Personal.idusuario = CType(Session("permisos"), clsusuario).usuario
                Dim Val = Obj_Personal.Registro_Masivo_Personal()
                If Val = Nothing Then
                    Pnl_Alerta.CssClass = "alert alert-success"
                    Lbl_Alerta.Text = "<span class='glyphicon glyphicon-ok-circle'></span> El registro masivo se completó exitosamente"
                Else
                    Pnl_Alerta.CssClass = "alert alert-warning"
                    Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> " & Val
                End If
            Else
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> Lo que intenta cargar no esta en formato .xlsx"
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> " & ex.Message
        End Try
    End Sub
    Protected Sub Btn_Act_Dat_Ext_Click(sender As Object, e As EventArgs) Handles Btn_Act_Dat_Ext.Click
        Try
            If txtdocumento.Text Is Nothing And txtnombres.Text Is Nothing Then
                Pnl_Alerta.CssClass = "alert alert-success"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-ok-circle'></span> ¡Para actualizar los datos de una persona antes debe buscarla!"
                Exit Sub
            End If
            Obj_Personal.documento = txtdocumento.Text
            If Txt_Contac_Emerg.Text = Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Diligencie el campo de Persona en caso de emergencia!"
                Exit Sub
            Else
                Obj_Personal.Pers_Contac_Emerg = Txt_Contac_Emerg.Text
            End If
            If Txt_Tel_Contac_Emerg.Text = Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Diligencie el campo Telefono en caso de emergencia!"
                Exit Sub
            Else
                Obj_Personal.Tel_Contac_Emeg = Txt_Tel_Contac_Emerg.Text
            End If

            If Drl_Medicamentos.SelectedIndex = 0 Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Seleccione una opcion ¿Toma medicamentos?!"
                Exit Sub
            ElseIf Drl_Medicamentos.SelectedValue = "Si" And Txt_Obs_Medicamentos.Text = Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Diligencie el campo ¿Cuales medicamentos?!"
                Exit Sub
            Else
                Obj_Personal.Toma_Medicamentos = Drl_Medicamentos.SelectedItem.Text
                Obj_Personal.Obs_Medicamentos = Txt_Obs_Medicamentos.Text
            End If

            If Txt_Ant_Salud.Text = Nothing Then
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Diligencie el campo Antecedentes personales de salud!"
                Exit Sub
            Else
                Obj_Personal.Obs_Ant_Salud = Txt_Ant_Salud.Text
            End If
            If Obj_Personal.Actualizar_Personal_DatosExtras() >= 1 Then
                Pnl_Alerta.CssClass = "alert alert-success"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-ok-circle'></span> ¡Se actualizaron los datos correctamente!"
                limpiar()
            Else
                Pnl_Alerta.CssClass = "alert alert-warning"
                Lbl_Alerta.Text = "<span class='glyphicon glyphicon-warning-sign'></span> ¡Los datos no se han podido actualizar!"
            End If
        Catch ex As Exception
            Pnl_Alerta.CssClass = "alert alert-danger"
            Lbl_Alerta.Text = "<span class='glyphicon glyphicon-remove-sign'></span> " & ex.Message
        Finally
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "show_loding", "PlegDes_Dinamico('#Desp_Loading', 'show', 'puff', 500, '');", True)
        End Try
    End Sub
End Class