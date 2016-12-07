Public Class Auditoria
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                With drlagente
                    .DataSource = objdatos.consultaagente
                    .DataTextField = "nombreu"
                    .DataValueField = "idusuario"
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

    Protected Sub traetipificacion()
        Try
            Dim objdatos As New clscalidad
            objdatos.tipo = drltipo.SelectedItem.Value
            objdatos.nivel = drlnivel.SelectedItem.Value
            dtggeneral.DataSource = objdatos.itemevaluacion()
            dtggeneral.DataBind()
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try

    End Sub

    Protected Sub drlnivel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlnivel.SelectedIndexChanged
        Try
            Dim objdatos As New clscalidad
            traetipificacion()
            asigna()
            If drltipo.SelectedItem.Text = "Protocolo" Then
                objdatos.tipo = "FGProtocolo"
            Else
                objdatos.tipo = "FGConocimiento"
            End If
            With drlfaltaGR
                .DataSource = objdatos.itemevaluacionfg
                .DataTextField = "item"
                .DataValueField = "id"
                .DataBind()
            End With
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub
    Protected Sub asigna()
        Try
            Dim celda As Integer
            Dim valor As String
            'asigna el peso por item
            celda = 1
            For Each row As GridViewRow In dtggeneral.Rows
                valor = CStr(row.Cells(3).Text)
                If celda = 1 Then
                    lblpeso1.Text = valor
                End If
                If celda = 2 Then
                    lblpeso2.Text = valor
                End If
                If celda = 3 Then
                    lblpeso3.Text = valor
                End If
                If celda = 4 Then
                    lblpeso4.Text = valor
                End If
                If celda = 5 Then
                    lblpeso5.Text = valor
                End If
                If celda = 6 Then
                    lblpeso6.Text = valor
                End If
                If celda = 7 Then
                    lblpeso7.Text = valor
                End If
                If celda = 8 Then
                    lblpeso8.Text = valor
                End If
                If celda = 9 Then
                    lblpeso9.Text = valor
                End If
                If celda = 10 Then
                    lblpeso10.Text = valor
                End If
                celda = celda + 1
            Next
            'asigna valores a los item a evaluar
            celda = 1
            For Each row As GridViewRow In dtggeneral.Rows
                valor = CStr(row.Cells(2).Text)
                If celda = 1 Then
                    lblitem1.Text = valor
                End If
                If celda = 2 Then
                    lblitem2.Text = valor
                End If
                If celda = 3 Then
                    lblitem3.Text = valor
                End If
                If celda = 4 Then
                    lblitem4.Text = valor
                End If
                If celda = 5 Then
                    lblitem5.Text = valor
                End If
                If celda = 6 Then
                    lblitem6.Text = valor
                End If
                If celda = 7 Then
                    lblitem7.Text = valor
                End If
                If celda = 8 Then
                    lblitem8.Text = valor
                End If
                If celda = 9 Then
                    lblitem9.Text = valor
                End If
                If celda = 10 Then
                    lblitem10.Text = valor
                End If
                celda = celda + 1
            Next
            'asigna id de item
            celda = 1
            For Each row As GridViewRow In dtggeneral.Rows
                valor = CStr(row.Cells(4).Text)
                If celda = 1 Then
                    lblid1.Text = valor
                End If
                If celda = 2 Then
                    lblid2.Text = valor
                End If
                If celda = 3 Then
                    lblid3.Text = valor
                End If
                If celda = 4 Then
                    lblid4.Text = valor
                End If
                If celda = 5 Then
                    lblid5.Text = valor
                End If
                If celda = 6 Then
                    lblid6.Text = valor
                End If
                If celda = 7 Then
                    lblid7.Text = valor
                End If
                If celda = 8 Then
                    lblid8.Text = valor
                End If
                If celda = 9 Then
                    lblid9.Text = valor
                End If
                If celda = 10 Then
                    lblid10.Text = valor
                End If
                celda = celda + 1
            Next
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click1(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Dim objdatos As New clscalidad
        Try
            If lblmesa.Text = "" Then
                lblmsg.Text = "Consulte el caso antes de guardar el registro"
                Exit Sub
            End If
            If lbltot11.Text = "" Then
                lblmsg.Text = "Calcule la nota antes de guardar el registro"
                Exit Sub
            End If
            If drlagente.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el agente auditado"
                Exit Sub
            Else
                objdatos.agente = drlagente.SelectedItem.Value
            End If
            If txtgrupo.Text = "" Then
                lblmsg.Text = "- Digite el grupo del agente antes de guardar el registro"
                Exit Sub
            Else
                objdatos.grupo = txtgrupo.Text
            End If
            If drltipo.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el tipo de auditoría realizada"
                Exit Sub
            Else
                objdatos.tipo = drltipo.SelectedItem.Value
            End If
            If drlnivel.SelectedItem.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione el nivel aplicado de auditoría"
                Exit Sub
            Else
                objdatos.nivel = drlnivel.SelectedItem.Value
            End If
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el caso auditado"
                Exit Sub
            Else
                objdatos.caso = txtcaso.Text
            End If
            If txtfchora.Text = "" And txtfchora2.Text = "" Then
                lblmsg.Text = "Digite la fecha y hora de la llamada auditada"
                Exit Sub
            Else
                objdatos.fcllamada = txtfchora.Text + " " + txtfchora2.Text
            End If
            If txttiempo.Text = "" Then
                lblmsg.Text = "Digite el tiempo acumulado de las llamadas auditadas"
                Exit Sub
            Else
                objdatos.tiempoacum = txttiempo.Text
            End If
            If txtllamadas.Text = "" Then
                lblmsg.Text = "Digite la cantidad de llamadas realizadas para el caso"
                Exit Sub
            Else
                objdatos.llamadas = txtllamadas.Text
            End If
            If txtobs11.Text = "" Then
                lblmsg.Text = "Digite la observación general de la auditoría"
                Exit Sub
            Else
                objdatos.obs = txtobs11.Text
            End If
            objdatos.idusuario = lblusuario.Text
            objdatos.registroauditoria()
            traeconsec()
            guardacalif()
            lblmsg.Text = "Registro ingresado con éxito"
            'limpia
            drlagente.SelectedValue = "0"
            drltipo.SelectedValue = "- Seleccione -"
            drlnivel.SelectedValue = "- Seleccione -"
            txtcaso.Text = ""
            txtfchora.Text = ""
            txttiempo.Text = ""
            txtllamadas.Text = ""
            txtobs11.Text = ""
            lblmin.Text = ""
            lblmesa.Text = ""
            lblsolic.Text = ""
            lblestado.Text = ""
            txtgrupo.Text = ""
            txtfchora2.Text = ""
            'limpia registros
            limpiadetalle()
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub
    Protected Sub limpiadetalle()
        Try
            lblid1.Text = ""
            lblid2.Text = ""
            lblid3.Text = ""
            lblid4.Text = ""
            lblid5.Text = ""
            lblid6.Text = ""
            lblid7.Text = ""
            lblid8.Text = ""
            lblid9.Text = ""
            lblid10.Text = ""

            lblpeso1.Text = ""
            lblpeso2.Text = ""
            lblpeso3.Text = ""
            lblpeso4.Text = ""
            lblpeso5.Text = ""
            lblpeso6.Text = ""
            lblpeso7.Text = ""
            lblpeso8.Text = ""
            lblpeso9.Text = ""
            lblpeso10.Text = ""
            lblpeso11.Text = ""

            lblitem1.Text = ""
            lblitem2.Text = ""
            lblitem3.Text = ""
            lblitem4.Text = ""
            lblitem5.Text = ""
            lblitem6.Text = ""
            lblitem7.Text = ""
            lblitem8.Text = ""
            lblitem9.Text = ""
            lblitem10.Text = ""

            chk1.Checked = False
            chk2.Checked = False
            chk3.Checked = False
            chk4.Checked = False
            chk5.Checked = False
            chk6.Checked = False
            chk7.Checked = False
            chk8.Checked = False
            chk9.Checked = False
            chk10.Checked = False

            txtcalif1.Text = ""
            txtcalif2.Text = ""
            txtcalif3.Text = ""
            txtcalif4.Text = ""
            txtcalif5.Text = ""
            txtcalif6.Text = ""
            txtcalif7.Text = ""
            txtcalif8.Text = ""
            txtcalif9.Text = ""
            txtcalif10.Text = ""

            lbltot1.Text = ""
            lbltot2.Text = ""
            lbltot3.Text = ""
            lbltot4.Text = ""
            lbltot5.Text = ""
            lbltot6.Text = ""
            lbltot7.Text = ""
            lbltot8.Text = ""
            lbltot9.Text = ""
            lbltot10.Text = ""
            lbltot11.Text = ""

            txtobs1.Text = ""
            txtobs2.Text = ""
            txtobs3.Text = ""
            txtobs4.Text = ""
            txtobs5.Text = ""
            txtobs6.Text = ""
            txtobs7.Text = ""
            txtobs8.Text = ""
            txtobs9.Text = ""
            txtobs10.Text = ""

            lblidtabla.Text = ""
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub
   
    Protected Sub traeconsec()
        Try
            Dim objdatos As New clscalidad
            objdatos.agente = drlagente.SelectedItem.Value
            objdatos.tipo = drltipo.SelectedItem.Value
            objdatos.nivel = drlnivel.SelectedItem.Value
            objdatos.traeconsecut()
            lblidtabla.Text = objdatos.idreg
        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub
    Protected Sub guardacalif()
        Try
            Dim objdatos As New clscalidad
            If chk1.Checked = False Then
                objdatos.nota = lbltot1.Text
                If txtobs1.Text <> "" Then
                    objdatos.obs = txtobs1.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid1.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If

            If chk2.Checked = False Then
                objdatos.nota = lbltot2.Text
                If txtobs2.Text <> "" Then
                    objdatos.obs = txtobs2.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid2.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If
            If chk3.Checked = False Then
                objdatos.nota = lbltot3.Text
                If txtobs3.Text <> "" Then
                    objdatos.obs = txtobs3.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid3.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If
            If chk4.Checked = False Then
                objdatos.nota = lbltot4.Text
                If txtobs4.Text <> "" Then
                    objdatos.obs = txtobs4.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid4.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If

            If chk5.Checked = False Then
                objdatos.nota = lbltot5.Text
                If txtobs5.Text <> "" Then
                    objdatos.obs = txtobs5.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid5.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If

            If chk6.Checked = False Then
                objdatos.nota = lbltot6.Text
                If txtobs6.Text <> "" Then
                    objdatos.obs = txtobs6.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid6.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If

            If chk7.Checked = False Then
                objdatos.nota = lbltot7.Text
                If txtobs7.Text <> "" Then
                    objdatos.obs = txtobs7.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid7.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If

            If chk8.Checked = False Then
                objdatos.nota = lbltot8.Text
                If txtobs8.Text <> "" Then
                    objdatos.obs = txtobs8.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid8.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If

            If chk9.Checked = False Then
                objdatos.nota = lbltot9.Text
                If txtobs9.Text <> "" Then
                    objdatos.obs = txtobs9.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid9.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If

            If chk10.Checked = False Then
                objdatos.nota = lbltot10.Text
                If txtobs10.Text <> "" Then
                    objdatos.obs = txtobs10.Text
                Else
                    objdatos.obs = ""
                End If
                objdatos.iditem = lblid10.Text
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If

            If drlfaltaGR.SelectedItem.Text <> "- Seleccione -" Then
                objdatos.nota = "0"
                objdatos.obs = drlfaltaGR.SelectedItem.Text
                objdatos.iditem = drlfaltaGR.SelectedItem.Value
                objdatos.idreg = lblidtabla.Text
                objdatos.registrocalif()
            End If

            'guarda el total
            objdatos.item = 1
            objdatos.nota = lbltot11.Text
            objdatos.obs = ""
            If drltipo.SelectedItem.Value = "Protocolo" Then
                objdatos.iditem = "98"
                objdatos.pondera = lbltot11.Text * 0.40000000000000002
            Else
                objdatos.iditem = "99"
                objdatos.pondera = lbltot11.Text * 0.59999999999999998
            End If
            objdatos.idreg = lblidtabla.Text
            objdatos.registrocalif()

        Catch ex As Exception
            Me.lblmsg.Text = "se ha producido un error:" & ex.Message
        End Try
    End Sub
    Protected Sub calcular()
        Try
            Dim objdatos As New clscalidad
            If chk1.Checked = False Then
                If txtcalif1.Text <> "" Then
                    If lblpeso1.Text <> "" Then
                        lbltot1.Text = txtcalif1.Text * lblpeso1.Text
                    End If
                End If
            Else
                lblpeso1.Text = 0
                lbltot1.Text = 0
            End If
            If chk2.Checked = False Then
                If txtcalif2.Text <> "" Then
                    If lblpeso2.Text <> "" Then
                        lbltot2.Text = txtcalif2.Text * lblpeso2.Text
                    End If
                End If
            Else
                lblpeso2.Text = 0
                lbltot2.Text = 0
            End If
            If chk3.Checked = False Then
                If txtcalif3.Text <> "" Then
                    If lblpeso3.Text <> "" Then
                        lbltot3.Text = txtcalif3.Text * lblpeso3.Text
                    End If
                End If
            Else
                lblpeso3.Text = 0
                lbltot3.Text = 0
            End If
            If chk4.Checked = False Then
                If txtcalif4.Text <> "" Then
                    If lblpeso4.Text <> "" Then
                        lbltot4.Text = txtcalif4.Text * lblpeso4.Text
                    End If
                End If
            Else
                lblpeso4.Text = 0
                lbltot4.Text = 0
            End If
            If chk5.Checked = False Then
                If txtcalif5.Text <> "" Then
                    If lblpeso5.Text <> "" Then
                        lbltot5.Text = txtcalif5.Text * lblpeso5.Text
                    End If
                End If
            Else
                lblpeso5.Text = 0
                lbltot5.Text = 0
            End If
            If chk6.Checked = False Then
                If txtcalif6.Text <> "" Then
                    If lblpeso6.Text <> "" Then
                        lbltot6.Text = txtcalif6.Text * lblpeso6.Text
                    End If
                End If
            Else
                lblpeso6.Text = 0
                lbltot6.Text = 0
            End If
            If chk7.Checked = False Then
                If txtcalif7.Text <> "" Then
                    If lblpeso7.Text <> "" Then
                        lbltot7.Text = txtcalif7.Text * lblpeso7.Text
                    End If
                End If
            Else
                lblpeso7.Text = 0
                lbltot7.Text = 0
            End If
            If chk8.Checked = False Then
                If txtcalif8.Text <> "" Then
                    If lblpeso8.Text <> "" Then
                        lbltot8.Text = txtcalif8.Text * lblpeso8.Text
                    End If
                End If
            Else
                lblpeso8.Text = 0
                lbltot8.Text = 0
            End If

            If chk9.Checked = False Then
                If txtcalif9.Text <> "" Then
                    If lblpeso9.Text <> "" Then
                        lbltot9.Text = txtcalif9.Text * lblpeso9.Text
                    End If
                End If
            Else
                lblpeso9.Text = 0
                lbltot9.Text = 0
            End If
            If chk10.Checked = False Then
                If txtcalif10.Text <> "" Then
                    If lblpeso10.Text <> "" Then
                        lbltot10.Text = txtcalif10.Text * lblpeso10.Text
                    End If
                End If
            Else
                lblpeso10.Text = 0
                lbltot10.Text = 0
            End If
            lblpeso11.Text = Convert.ToDecimal(lblpeso1.Text) + Convert.ToDecimal(lblpeso2.Text) + Convert.ToDecimal(lblpeso3.Text) + Convert.ToDecimal(lblpeso4.Text) + Convert.ToDecimal(lblpeso5.Text) + Convert.ToDecimal(lblpeso6.Text) + Convert.ToDecimal(lblpeso7.Text) + Convert.ToDecimal(lblpeso8.Text) + Convert.ToDecimal(lblpeso9.Text) + Convert.ToDecimal(lblpeso10.Text)
            If drlfaltaGR.SelectedItem.Text = "- Seleccione -" Then
                lbltot11.Text = ((Convert.ToDecimal(lbltot1.Text) + Convert.ToDecimal(lbltot2.Text) + Convert.ToDecimal(lbltot3.Text) + Convert.ToDecimal(lbltot4.Text) + Convert.ToDecimal(lbltot5.Text) + Convert.ToDecimal(lbltot6.Text) + Convert.ToDecimal(lbltot7.Text) + Convert.ToDecimal(lbltot8.Text) + Convert.ToDecimal(lbltot9.Text) + Convert.ToDecimal(lbltot10.Text)) * 2) / lblpeso11.Text
            Else
                lbltot11.Text = 0
            End If

            lbltot11.Text = FormatNumber(lbltot11.Text, 2)
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub
    Protected Sub btncalcular_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btncalcular.Click
        calcular()
    End Sub

    Protected Sub btnreestab_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnreestab.Click
        Try
            lbltot1.Text = ""
            lbltot2.Text = ""
            lbltot3.Text = ""
            lbltot4.Text = ""
            lbltot5.Text = ""
            lbltot6.Text = ""
            lbltot7.Text = ""
            lbltot8.Text = ""
            lbltot9.Text = ""
            lbltot10.Text = ""
            lbltot11.Text = ""
            asigna()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try

    End Sub

    Sub buscarinfgral()
        Try
            Dim objdatos As New clscrmdatos
            If txtcaso.Text = "" Then
                lblmsg.Text = "Digite el Caso que desea consultar"
            Else
                objdatos.caso = txtcaso.Text
                objdatos.consultacaso()
                If objdatos.cantidad > 0 Then
                    lblmin.Text = objdatos.min
                    lblsolic.Text = objdatos.obsini
                    lblestado.Text = objdatos.tipificacion
                    lblmesa.Text = "Datos"
                    If txtcaso.Text = "" Then
                        txtcaso.Text = objdatos.caso
                    End If
                Else
                    'si no está en datos busca en voz
                    Dim objconsultavoz As New clsvoz
                    objconsultavoz.caso = txtcaso.Text
                    objconsultavoz.consultacasovoz()
                    If objconsultavoz.cantidad > 0 Then
                        lblmin.Text = objconsultavoz.min
                        lblsolic.Text = objconsultavoz.obsini
                        lblestado.Text = objconsultavoz.tipificacion
                        lblmesa.Text = objconsultavoz.mesa
                        lblmsg.Text = ""
                    Else
                        lblmin.Text = ""
                        lblsolic.Text = ""
                        lblestado.Text = ""
                        lblmesa.Text = ""
                        lblmsg.Text = "No se han encontrado registros coincidentes para el caso digitado, verifique"
                        btnguardar.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnvalida_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnvalida.Click
        buscarinfgral()
    End Sub

    Protected Sub drlfaltaGR_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlfaltaGR.SelectedIndexChanged
        calcular()
    End Sub

    Protected Sub drlagente_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlagente.SelectedIndexChanged
        Try
            Dim objdatos As New clsgeneral
            Dim objdrrhh As New clsrrhh
            objdatos.idusuario = drlagente.SelectedItem.Value
            objdatos.consultacod()
            objdrrhh.codigo = objdatos.cargo
            objdrrhh.consultagrupo()
            If objdrrhh.cantidad > 0 Then
                txtgrupo.Text = objdrrhh.grupo
            Else
                txtgrupo.Text = ""
            End If
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

End Class