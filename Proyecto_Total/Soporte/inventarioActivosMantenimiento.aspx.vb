Imports System.IO
Public Class inventarioActivosMantenimiento
    Inherits System.Web.UI.Page
    Dim Objeto As New clsInventario
    Dim cod
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                cargardrl()
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
            lblmsg.Text = "Se produjo error" & ex.Message
        End Try
    End Sub

    Sub cargardrl()
        Try
            With drlTipo
                .DataSource = Objeto.Consdrl
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            With drlsolucionhs
                .DataSource = Objeto.Consdrl
                .DataTextField = "Nombre"
                .DataValueField = "Nombre"
                .DataBind()
            End With
            Objeto.Validacion = 1
            If Objeto.Validacion = 1 Then
                With drlTipomantenimiento
                    .DataSource = Objeto.Consdrl
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
                With drlTpMantenimiento
                    .DataSource = Objeto.Consdrl
                    .DataTextField = "Nombre"
                    .DataValueField = "Nombre"
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnGuardarMnto_Click(sender As Object, e As EventArgs) Handles BtnGuardarDispositivo.Click
        Try
            lblmsg.Text = ""
            If TxtCodigoInventario.Text = "" Then
                lblmsg.Text = "Debe Ingresar el codigo del equipo en inventario"
                Exit Sub
            End If
            Txtnombreequipo.Text = Trim(Replace(Txtnombreequipo.Text, " ", " "))
            If Txtnombreequipo.Text = "" Then
                lblmsg.Text = "Debe llenar el campo nombre equipo"
                Exit Sub
            End If
            If drlTipomantenimiento.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un  mantenimiento"
                Exit Sub
            End If
            If TxtFc_Mto.Text = "" Then
                lblmsg.Text = "Ingrese la fecha de realizacion mantenimiento"
                Exit Sub
            End If
            If drlTipo.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un tipo "
                Exit Sub
            End If
            TxtObservacion.Text = Trim(Replace(TxtObservacion.Text, " ", " "))
            If TxtObservacion.Text = "" Then
                lblmsg.Text = "Debe llenar el campo de observacion"
                Exit Sub
            End If
            Txtnombreequipo.Text = UCase(Txtnombreequipo.Text)
            Objeto.Observacion = TxtObservacion.Text
            Objeto.fc_mto = TxtFc_Mto.Text
            If Date.Parse(Objeto.FcReg_Invent) < Date.Parse(Objeto.fc_mto) Then
                lblmsg.Text = "No puede registrar un mantenimiento que aun no  ha realizado"
                Exit Sub
            End If
            Objeto.Cod_Inventario = TxtCodigoInventario.Text
            Objeto.Validacion = 2
            Objeto.Consdrl()
            If Objeto.Cantidad = 0 Then
                lblmsg.Text = "El codigo de inventario ingresado no existe"
                Exit Sub
            End If
            Objeto.Mto = drlTipomantenimiento.SelectedValue
            Objeto.Tipo = drlTipo.SelectedValue
            Objeto.Cod_Agente = lblusuario.Text

            Objeto.NombreE = Txtnombreequipo.Text
            Objeto.Ingresar_Mantenimiento()
            Lblcantidad.Text = Objeto.Cantidad
            lblmsg.Text = "Registro mantenimiento realizado con exito"
            TxtCodigoInventario.Text = ""
            TxtObservacion.Text = ""
            drlTipomantenimiento.SelectedIndex = 0
            drlTipo.SelectedIndex = 0
            TxtFc_Mto.Text = ""
            Txtnombreequipo.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error" & ex.Message
        End Try
    End Sub

    Private Sub CargarData()
        Try
            dtgConsultamantenimientos.Visible = True
            'dtgConsultamantenimientos.DataSource = Objeto.consultaMantenimientos()
            'dtgConsultamantenimientos.DataBind()


            Session("dtsB") = Objeto.consultaMantenimientos()
            dtgConsultamantenimientos.DataSource = Session("dtsB")
            dtgConsultamantenimientos.DataBind()


        Catch ex As Exception
            lblmsg.Text = "Se presento error: " & ex.Message
        End Try
    End Sub

    Protected Sub BtnBuscarMantenimientos_Click(sender As Object, e As EventArgs) Handles BtnBuscarMantenimientos.Click
        Try
            lblmsg.Text = ""
            If Rdbtnmnto.Checked = False And RdbtnSeriale.Checked = False And RdbtnSolucion.Checked = False And RdbtnSerialk.Checked = False And RdbtnNombre.Checked = False And RdbtnCodInventario.Checked = False Then
                lblmsg.Text = "expecifique un filtro de busqueda"
                Exit Sub
            End If
            If Rdbtnmnto.Checked = True And drlTpMantenimiento.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Expecifique un tipo de manteniento"
                Exit Sub
            End If
            If RdbtnSeriale.Checked = True And TxtSerial.Text = "" Then
                lblmsg.Text = "Expecifique el  serial del equipo "
                Exit Sub
            End If
            If RdbtnSolucion.Checked = True And drlsolucionhs.SelectedValue = "- Seleccione -" Then
                lblmsg.Text = "Expecifique un tipo"
                Exit Sub
            End If
            If RdbtnSerialk.Checked = True And TxtSerial1.Text = "" Then
                lblmsg.Text = "Expecifique serial kamilion "
                Exit Sub
            End If
            If RdbtnCodInventario.Checked = True And TxtCodInventario.Text = "" Then
                lblmsg.Text = "Expecifique codigo de inventario "
                Exit Sub
            End If
           
            If RdbtnNombre.Checked = True And Txtnombreequipo1.Text = "" Then
                lblmsg.Text = "Expecifique un nombre de equipo "
                Exit Sub
            End If
            Txtnombreequipo1.Text = UCase(Txtnombreequipo1.Text)
            If Rdbtnmnto.Checked = True And drlTpMantenimiento.SelectedItem.Text <> "- Seleccione -" Then
                Objeto.Mto = drlTpMantenimiento.SelectedValue
                CargarData()
            End If

            If RdbtnCodInventario.Checked = True And TxtCodInventario.Text <> Nothing Then
                Objeto.Cod_Inventario = TxtCodInventario.Text
                CargarData()
            End If
            If RdbtnSeriale.Checked = True And TxtSerial.Text <> Nothing Then
                Objeto.Serial = TxtSerial.Text
                CargarData()
            End If
            If RdbtnSolucion.Checked = True And drlsolucionhs.SelectedItem.Text <> "- Seleccione -" Then
                Objeto.Tipo = drlsolucionhs.SelectedValue
                CargarData()
            End If
            If RdbtnSerialk.Checked = True And TxtSerial1.Text <> "" Then
                Objeto.Serial_Kamilion = TxtSerial1.Text
                CargarData()
            End If
           
            If RdbtnNombre.Checked = True And Txtnombreequipo1.Text <> "" Then
                Objeto.NombreE = Txtnombreequipo1.Text
                CargarData()
            End If
            lblcantidad.Text = Objeto.Cantidad
            If Lblcantidad.Text <= 0 Then
                lblmsg.Text = "No Se encontraron registros con el criterio de busqueda expecificado"
                dtgConsultamantenimientos.Visible = False
                BtnExportar.Visible = False
                Lblcantidad.Text = ""
            Else
                BtnExportar.Visible = True
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " & ex.Message
        End Try
    End Sub

    Protected Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Try
            lblmsg.Text = ""
            crearexcel()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " & ex.Message
        End Try
    End Sub

    Sub crearexcel()
        Try
            Dim sb As New StringBuilder
            Dim sw As New StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            Dim pagina As Page = New Page
            Dim form = New HtmlForm
            Dim r As New clsInventario
            Dim objdtsconsultaxls As New DataSet
            Dim strStyle As String = "<style>.text { mso-number-format:\@; } </style>"
            Dim Validar As Boolean
            If drlTpMantenimiento.SelectedValue <> "- Seleccione -" Then
                r.Mto = drlTpMantenimiento.SelectedValue
                Validar = True
          
            End If
          
            If TxtSerial.Text <> Nothing Then
                r.Serial = TxtSerial.Text
                Validar = True
            End If
            If Txtnombreequipo1.Text <> Nothing Then
                r.NombreE = Txtnombreequipo1.Text
                Validar = True
           
            End If
            If TxtSerial1.Text <> Nothing Then
                r.Serial_Kamilion = TxtSerial1.Text
                Validar = True
          
            End If
            If drlsolucionhs.SelectedValue <> "- Seleccione -" Then
                r.Tipo = drlsolucionhs.SelectedValue
                Validar = True
           
            End If
            If TxtCodInventario.Text <> Nothing Then
                r.Cod_Inventario = TxtCodInventario.Text
                Validar = True
            
            End If
           
            If Lblcantidad.Text <> "0" Or Lblcantidad.Text <> "" And Validar = True Then
                dtgxls.DataSource = r.consultaMantenimientos
                dtgxls.DataBind()
                dtgxls.Visible = True
                dtgxls.EnableViewState = False
                pagina.EnableEventValidation = False
                pagina.DesignerInitialize()
                pagina.Controls.Add(form)
                form.Controls.Add(dtgxls)
                pagina.RenderControl(htw)
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/vnd.ms-excel"
                Response.ContentEncoding = System.Text.ASCIIEncoding.UTF8
                Response.AddHeader("Content-Disposition", "attachment;filename=Inventario Mantenimientos.xls")
                Response.Charset = "UTF-8"
                Response.Write(strStyle)
                Response.Write(sb.ToString())
                Response.End()
            Else
                lblmsg.Text = "Debe hacer primero un filtro de consulta"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Private Sub dtgConsultamantenimientos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dtgConsultamantenimientos.PageIndexChanging
        Try
            dtgConsultamantenimientos.PageIndex = e.NewPageIndex
            dtgConsultamantenimientos.DataSource = Session("dtsB")
            dtgConsultamantenimientos.DataBind()



            cambioindicedtg1()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub cambioindicedtg1()
        Try
            If Rdbtnmnto.Checked = True And drlTpMantenimiento.SelectedItem.Text <> "- Seleccione -" Then
                Objeto.Mto = drlTpMantenimiento.SelectedValue
                CargarData()
            End If
            If RdbtnSeriale.Checked = True And TxtSerial.Text <> Nothing Then
                Objeto.Serial = TxtSerial.Text
                CargarData()
            End If
            If RdbtnSolucion.Checked = True And drlsolucionhs.SelectedItem.Text <> "- Seleccione -" Then
                Objeto.Tipo = drlsolucionhs.SelectedValue
                CargarData()
            End If
            If RdbtnSerialk.Checked = True And TxtSerial1.Text <> "" Then
                Objeto.Serial_Kamilion = TxtSerial1.Text
                CargarData()
            End If
          
            If RdbtnNombre.Checked = True And Txtnombreequipo1.Text <> "" Then
                Objeto.NombreE = Txtnombreequipo1.Text
                CargarData()
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

  

    Protected Sub btn_Buscar_Todos_Click(sender As Object, e As EventArgs) Handles btn_Buscar_Todos.Click
        Try
            CargarData()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
End Class


