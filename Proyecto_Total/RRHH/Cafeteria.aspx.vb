Imports System.IO
Imports System
Imports System.Data.DataTable
Imports System.Data.DataSet

Public Class Cafeteria
    Inherits System.Web.UI.Page

    Dim ObjCaidaSistema As New clsCaidaSistema
    Dim ObjCafeteria As New clsCafeteria
    Dim FechaActual As String
    Dim Producto1 As Integer
  

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
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

    Dim ingreso As Integer = 0
    Dim s As Integer
    Dim d As Integer = 0
    Dim dtsP As New DataSet

    Protected Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            lblmsg.Text = ""
            If TxtProducto.Text = "" Then
                lblmsg.Text = "Consulte un producto primero"
            Else
                ObjCafeteria.Producto = TxtProducto.Text
                dtsP = ObjCafeteria.consulta()
                btnp1.Visible = True
                Panel1.Visible = True
                If ProCod1.Text <> "" Then
                    btnp2.Visible = True
                    Panel2.Visible = True

                    If Procod2.Text <> "" Then
                        btnp3.Visible = True
                        Panel3.Visible = True
                        If ProCod3.Text <> "" Then
                            btnp4.Visible = True
                            Panel4.Visible = True
                            If ProCod4.Text <> "" Then
                                btnp5.Visible = True
                                Panel5.Visible = True
                                If ProCod5.Text <> "" Then
                                    btnp6.Visible = True
                                    Panel6.Visible = True
                                    If ProCod6.Text <> "" Then
                                        btnp7.Visible = True
                                        Panel7.Visible = True
                                        If ProCod7.Text <> "" Then
                                            lblmsg.Text = "Solo es permitido guardar 7 productos"

                                        Else
                                            If (ProCod1.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (Procod2.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod3.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod4.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod5.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod6.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Then
                                                lblmsg.Text = "Este producto ya fue registrado por favor cambie la cantidad"
                                                TxtProducto.Text = ""
                                                TxtProducto.Focus()
                                                Panel7.Visible = False
                                                Exit Sub
                                            End If
                                            If dtsP.Tables(0).Rows.Count > 0 Then
                                                ProCod7.Text = ObjCafeteria.Codigo_Cafeteria_Producto
                                                ProNom7.Text = ObjCafeteria.Producto
                                                pre7.Text = ObjCafeteria.Valor_Unitario
                                                Can7.Text = 1
                                                presub7.Text = pre7.Text
                                            Else
                                                ProCod7.Text = ""
                                                ProNom7.Text = ""
                                                pre7.Text = ""
                                                Panel7.Visible = False
                                                lblmsg.Text = "No se encontro producto"
                                            End If
                                        End If

                                    Else
                                        If (ProCod1.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (Procod2.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod3.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod4.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod5.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Then
                                            lblmsg.Text = "Este producto ya fue registrado por favor cambie la cantidad"
                                            TxtProducto.Text = ""
                                            TxtProducto.Focus()
                                            Panel6.Visible = False
                                            Exit Sub
                                        End If
                                        If dtsP.Tables(0).Rows.Count > 0 Then

                                            ProCod6.Text = ObjCafeteria.Codigo_Cafeteria_Producto
                                            ProNom6.Text = ObjCafeteria.Producto
                                            pre6.Text = ObjCafeteria.Valor_Unitario
                                            Can6.Text = 1
                                            presub6.Text = pre6.Text
                                        Else
                                            ProCod6.Text = ""
                                            ProNom6.Text = ""
                                            pre6.Text = ""
                                            Panel6.Visible = False
                                            lblmsg.Text = "No se encontro producto"
                                        End If
                                    End If

                                Else
                                    If (ProCod1.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (Procod2.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod3.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod4.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Then
                                        lblmsg.Text = "Este producto ya fue registrado por favor cambie la cantidad"
                                        TxtProducto.Text = ""
                                        TxtProducto.Focus()
                                        Panel5.Visible = False
                                        Exit Sub
                                    End If
                                    If dtsP.Tables(0).Rows.Count > 0 Then
                                        ProCod5.Text = ObjCafeteria.Codigo_Cafeteria_Producto
                                        ProNom5.Text = ObjCafeteria.Producto
                                        pre5.Text = ObjCafeteria.Valor_Unitario
                                        Can5.Text = 1
                                        presub5.Text = pre5.Text
                                    Else
                                        ProCod5.Text = ""
                                        ProNom5.Text = ""
                                        pre5.Text = ""
                                        Panel5.Visible = False
                                        lblmsg.Text = "No se encontro producto"
                                    End If
                                End If

                            Else
                                If (ProCod1.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (Procod2.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (ProCod3.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Then
                                    lblmsg.Text = "Este producto ya fue registrado por favor cambie la cantidad"
                                    TxtProducto.Text = ""
                                    TxtProducto.Focus()
                                    Panel4.Visible = False
                                    Exit Sub
                                End If
                                If dtsP.Tables(0).Rows.Count > 0 Then

                                    ProCod4.Text = ObjCafeteria.Codigo_Cafeteria_Producto
                                    ProNom4.Text = ObjCafeteria.Producto
                                    pre4.Text = ObjCafeteria.Valor_Unitario
                                    Can4.Text = 1
                                    presub4.Text = pre4.Text
                                Else
                                    ProCod4.Text = ""
                                    ProNom4.Text = ""
                                    pre4.Text = ""
                                    Panel4.Visible = False
                                    lblmsg.Text = "No se encontro producto"
                                End If
                            End If
                        Else
                            If (ProCod1.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Or (Procod2.Text = ObjCafeteria.Codigo_Cafeteria_Producto) Then
                                lblmsg.Text = "Este producto ya fue registrado por favor cambie la cantidad"
                                TxtProducto.Text = ""
                                TxtProducto.Focus()
                                Panel3.Visible = False
                                Exit Sub
                            End If
                            If dtsP.Tables(0).Rows.Count > 0 Then
                                ProCod3.Text = ObjCafeteria.Codigo_Cafeteria_Producto
                                ProNom3.Text = ObjCafeteria.Producto
                                pre3.Text = ObjCafeteria.Valor_Unitario
                                Can3.Text = 1
                                presub3.Text = pre3.Text
                            Else
                                ProCod3.Text = ""
                                ProNom3.Text = ""
                                pre3.Text = ""
                                Panel3.Visible = False
                                lblmsg.Text = "No se encontro producto"
                            End If

                        End If


                    Else
                        If ProCod1.Text = ObjCafeteria.Codigo_Cafeteria_Producto Then
                            lblmsg.Text = "Este producto ya fue registrado por favor cambie la cantidad"
                            TxtProducto.Text = ""
                            TxtProducto.Focus()
                            Panel2.Visible = False
                            Exit Sub
                        End If
                        If dtsP.Tables(0).Rows.Count > 0 Then
                            Procod2.Text = ObjCafeteria.Codigo_Cafeteria_Producto
                            ProNom2.Text = ObjCafeteria.Producto
                            pre2.Text = ObjCafeteria.Valor_Unitario
                            Can2.Text = 1
                            presub2.Text = pre2.Text
                        Else
                            Procod2.Text = ""
                            ProNom2.Text = ""
                            pre2.Text = ""
                            Panel2.Visible = False
                            lblmsg.Text = "No se encontro producto"
                        End If
                    End If
                Else
                    If dtsP.Tables(0).Rows.Count > 0 Then
                        ProCod1.Text = ObjCafeteria.Codigo_Cafeteria_Producto
                        ProNom1.Text = ObjCafeteria.Producto
                        Can1.Text = 1
                        pre1.Text = ObjCafeteria.Valor_Unitario
                        presub1.Text = pre1.Text
                        'PanelProducto1.Visible = True

                    Else
                        ProCod1.Text = ""
                        ProNom1.Text = ""
                        pre1.Text = ""
                        Panel1.Visible = False
                        lblmsg.Text = "No se encontro producto"
                    End If

                End If
                TxtProducto.Text = ""

                Total()
            End If
            TxtProducto.Focus()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error:" + ex.Message
        End Try
    End Sub


    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim dts As New DataSet
            ObjCafeteria.Documento = TxtCodoDoc.Text
            dts = ObjCafeteria.consultausu()
            LblFechaActual.Text = DateTime.Now()
            If dts.Tables(0).Rows.Count > 0 Then
                LblCodigo.Text = ObjCafeteria.Codigo
                LblDocumento.Text = ObjCafeteria.Documento
                LblNombre.Text = ObjCafeteria.Nombre + " " + ObjCafeteria.Apellido
                LblCargo.Text = ObjCafeteria.Cargo
                LblFechaIng.Text = ObjCafeteria.FechaIng
            Else
                LblCodigo.Text = ""
                LblDocumento.Text = ""
                LblNombre.Text = ""
                LblCargo.Text = ""
                LblFechaIng.Text = ""
                LblEstado.Text = ""
                LblFechaActual.Text = ""
                lblmsg.Text = "No se encontro usuario"
            End If

            If ObjCafeteria.Estado = "A" Then
                LblEstado.Text = "Activo"
                LblEstado.ForeColor = Drawing.Color.DarkBlue

            Else
                If ObjCafeteria.Estado = "I" Then
                    LblEstado.Text = "Inactivo"
                    LblEstado.ForeColor = Drawing.Color.Red
                End If
            End If


        Catch ex As Exception
            lblmsg.Text = "Se produjo error:" + ex.Message
        End Try
    End Sub
    Protected Sub btnp1_Click(sender As Object, e As EventArgs) Handles btnp1.Click
        If ProCod1.Text <> "" Then
            ProCod1.Text = ""
            ProNom1.Text = ""
            Can1.Text = ""
            pre1.Text = ""
            presub1.Text = ""
            btnp1.Visible = False
            Panel1.Visible = False
            Total()
        End If
    End Sub

    Public Sub Total()
        LblTotal.Text = Val(presub1.Text) + Val(presub2.Text) + Val(presub3.Text) + Val(presub4.Text) + Val(presub5.Text) + Val(presub6.Text) + Val(presub7.Text)
    End Sub

    Protected Sub Can1_TextChanged(sender As Object, e As EventArgs) Handles Can1.TextChanged
        Try
            presub1.Text = Val(Can1.Text) * Val(pre1.Text)
            Total()

        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Can2_TextChanged(sender As Object, e As EventArgs) Handles Can2.TextChanged
        Try
            presub2.Text = Val(Can2.Text) * Val(pre2.Text)
            Total()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub btnp2_Click(sender As Object, e As EventArgs) Handles btnp2.Click
        If Procod2.Text <> "" Then
            Procod2.Text = ""
            ProNom2.Text = ""
            Can2.Text = ""
            pre2.Text = ""
            presub2.Text = ""
            btnp2.Visible = False
            Total()
            Panel2.Visible = False
        End If

    End Sub

    Protected Sub btnp3_Click(sender As Object, e As EventArgs) Handles btnp3.Click
        If ProCod3.Text <> "" Then
            ProCod3.Text = ""
            ProNom3.Text = ""
            Can3.Text = ""
            pre3.Text = ""
            presub3.Text = ""
            btnp3.Visible = False
            Total()
            Panel3.Visible = False
        End If
    End Sub

    Protected Sub btnp4_Click(sender As Object, e As EventArgs) Handles btnp4.Click
        If ProCod4.Text <> "" Then
            ProCod4.Text = ""
            ProNom4.Text = ""
            Can4.Text = ""
            pre4.Text = ""
            presub4.Text = ""
            btnp4.Visible = False
            Total()
            Panel4.Visible = False
        End If
    End Sub

    Protected Sub btnp5_Click(sender As Object, e As EventArgs) Handles btnp5.Click
        If ProCod5.Text <> "" Then
            ProCod5.Text = ""
            ProNom5.Text = ""
            Can5.Text = ""
            pre5.Text = ""
            presub5.Text = ""
            btnp5.Visible = False
            Total()
            Panel5.Visible = False
        End If
    End Sub

    Protected Sub btnp6_Click(sender As Object, e As EventArgs) Handles btnp6.Click
        If ProCod6.Text <> "" Then
            ProCod6.Text = ""
            ProNom6.Text = ""
            Can6.Text = ""
            pre6.Text = ""
            presub6.Text = ""
            btnp6.Visible = False
            Total()
            Panel6.Visible = False
        End If
    End Sub

    Protected Sub btnp7_Click(sender As Object, e As EventArgs) Handles btnp7.Click
        If ProCod7.Text <> "" Then
            ProCod7.Text = ""
            ProNom7.Text = ""
            Can7.Text = ""
            pre7.Text = ""
            presub7.Text = ""
            btnp7.Visible = False
            Total()
            Panel7.Visible = False
        End If
    End Sub

    Protected Sub Can3_TextChanged(sender As Object, e As EventArgs) Handles Can3.TextChanged
        Try
            presub3.Text = Val(Can3.Text) * Val(pre3.Text)
            Total()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Can4_TextChanged(sender As Object, e As EventArgs) Handles Can4.TextChanged
        Try
            presub4.Text = Val(Can4.Text) * Val(pre4.Text)
            Total()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Can5_TextChanged(sender As Object, e As EventArgs) Handles Can5.TextChanged
        Try
            presub5.Text = Val(Can5.Text) * Val(pre5.Text)
            Total()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Can6_TextChanged(sender As Object, e As EventArgs) Handles Can6.TextChanged
        Try
            presub6.Text = Val(Can6.Text) * Val(pre6.Text)
            Total()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Can7_TextChanged(sender As Object, e As EventArgs) Handles Can7.TextChanged
        Try
            presub7.Text = Val(Can7.Text) * Val(pre7.Text)
            Total()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        Try
            If LblTotal.Text = "" Or LblTotal.Text = 0 Then
                lblmsg.Text = "Registre algun producto"
                Exit Sub
            ElseIf LblCodigo.Text = "" Then
                lblmsg.Text = "Seleccione un cliente"
                Exit Sub
            Else
                ObjCafeteria.Fecha_Venta = LblFechaActual.Text
                ObjCafeteria.Id_Usuario = lblusuario.Text
                ObjCafeteria.Codigo = LblCodigo.Text
                ObjCafeteria.Documento_Cliente = LblDocumento.Text
                ObjCafeteria.Total = LblTotal.Text
                ObjCafeteria.RegistroVenta()
                ''Menasaje ingreso

                ''Limpia cajas

                Dim codigoven As New DataSet
                codigoven = ObjCafeteria.ConsultaId()
                ObjCafeteria.Documento_Cliente = LblDocumento.Text
                ObjCafeteria.Fecha_Venta = LblFechaActual.Text
                ObjCafeteria.Id_Usuario = lblusuario.Text
                ObjCafeteria.Codigo = LblCodigo.Text
                ObjCafeteria.Total = LblTotal.Text

                If codigoven.Tables(0).Rows.Count > 0 Then
                    lblcodigoventa.Text = ObjCafeteria.Codigo_Cafeteria_Venta
                Else
                    lblcodigoventa.Text = "No se encontro"
                End If

                lblmsg.Text = "Se ha registrado la venta con el ticket: " & lblcodigoventa.Text

                If ProCod1.Text = "" And Procod2.Text = "" And ProCod3.Text = "" And ProCod4.Text = "" And ProCod5.Text = "" And ProCod6.Text = "" And ProCod7.Text = "" Then
                    lblmsg.Text = "Registre un producto Primero"
                Else

                    If Can1.Text <> "" Then
                        ObjCafeteria.Codigo_Cafeteria_Producto = ProCod1.Text
                        ObjCafeteria.Cantidad_Compra = Can1.Text
                        ObjCafeteria.Codigo_Cafeteria_Venta = lblcodigoventa.Text
                        ObjCafeteria.RegistroDetalleVenta()

                        ProCod1.Text = ""
                        Can1.Text = ""
                        ProNom1.Text = ""
                        pre1.Text = ""
                        presub1.Text = ""
                        btnp1.Visible = False

                    End If

                    If Can2.Text <> "" Then
                        ObjCafeteria.Codigo_Cafeteria_Producto = Procod2.Text
                        ObjCafeteria.Cantidad_Compra = Can2.Text
                        ObjCafeteria.Codigo_Cafeteria_Venta = lblcodigoventa.Text
                        ObjCafeteria.RegistroDetalleVenta()

                        ProCod1.Text = ""
                        Procod2.Text = ""

                        Can1.Text = ""
                        Can2.Text = ""

                        ProNom1.Text = ""
                        ProNom2.Text = ""

                        pre1.Text = ""
                        pre2.Text = ""

                        presub1.Text = ""
                        presub2.Text = ""

                        btnp1.Visible = False
                        btnp2.Visible = False
                    End If
                    If Can3.Text <> "" Then
                        ObjCafeteria.Codigo_Cafeteria_Producto = ProCod3.Text
                        ObjCafeteria.Cantidad_Compra = Can3.Text
                        ObjCafeteria.Codigo_Cafeteria_Venta = lblcodigoventa.Text
                        ObjCafeteria.RegistroDetalleVenta()

                        ProCod1.Text = ""
                        Procod2.Text = ""
                        ProCod3.Text = ""

                        Can1.Text = ""
                        Can2.Text = ""
                        Can3.Text = ""

                        ProNom1.Text = ""
                        ProNom2.Text = ""
                        ProNom3.Text = ""

                        pre1.Text = ""
                        pre2.Text = ""
                        pre3.Text = ""

                        presub1.Text = ""
                        presub2.Text = ""
                        presub3.Text = ""

                        btnp1.Visible = False
                        btnp2.Visible = False
                        btnp3.Visible = False
                    End If
                    If Can4.Text <> "" Then
                        ObjCafeteria.Codigo_Cafeteria_Producto = ProCod4.Text
                        ObjCafeteria.Cantidad_Compra = Can4.Text
                        ObjCafeteria.Codigo_Cafeteria_Venta = lblcodigoventa.Text
                        ObjCafeteria.RegistroDetalleVenta()

                        ProCod1.Text = ""
                        Procod2.Text = ""
                        ProCod3.Text = ""
                        ProCod4.Text = ""

                        Can1.Text = ""
                        Can2.Text = ""
                        Can3.Text = ""
                        Can4.Text = ""

                        ProNom1.Text = ""
                        ProNom2.Text = ""
                        ProNom3.Text = ""
                        ProNom4.Text = ""

                        pre1.Text = ""
                        pre2.Text = ""
                        pre3.Text = ""
                        pre4.Text = ""

                        presub1.Text = ""
                        presub2.Text = ""
                        presub3.Text = ""
                        presub4.Text = ""

                        btnp1.Visible = False
                        btnp2.Visible = False
                        btnp3.Visible = False
                        btnp4.Visible = False
                    End If
                    If Can5.Text <> "" Then
                        ObjCafeteria.Codigo_Cafeteria_Producto = ProCod5.Text
                        ObjCafeteria.Cantidad_Compra = Can5.Text
                        ObjCafeteria.Codigo_Cafeteria_Venta = lblcodigoventa.Text
                        ObjCafeteria.RegistroDetalleVenta()

                        ProCod1.Text = ""
                        Procod2.Text = ""
                        ProCod3.Text = ""
                        ProCod4.Text = ""
                        ProCod5.Text = ""

                        Can1.Text = ""
                        Can2.Text = ""
                        Can3.Text = ""
                        Can4.Text = ""
                        Can5.Text = ""

                        ProNom1.Text = ""
                        ProNom2.Text = ""
                        ProNom3.Text = ""
                        ProNom4.Text = ""
                        ProNom5.Text = ""

                        pre1.Text = ""
                        pre2.Text = ""
                        pre3.Text = ""
                        pre4.Text = ""
                        pre5.Text = ""

                        presub1.Text = ""
                        presub2.Text = ""
                        presub3.Text = ""
                        presub4.Text = ""
                        presub5.Text = ""

                        btnp1.Visible = False
                        btnp2.Visible = False
                        btnp3.Visible = False
                        btnp4.Visible = False
                        btnp5.Visible = False
                    End If
                    If Can6.Text <> "" Then
                        ObjCafeteria.Codigo_Cafeteria_Producto = ProCod6.Text
                        ObjCafeteria.Cantidad_Compra = Can6.Text
                        ObjCafeteria.Codigo_Cafeteria_Venta = lblcodigoventa.Text
                        ObjCafeteria.RegistroDetalleVenta()

                        ProCod1.Text = ""
                        Procod2.Text = ""
                        ProCod3.Text = ""
                        ProCod4.Text = ""
                        ProCod5.Text = ""
                        ProCod6.Text = ""

                        Can1.Text = ""
                        Can2.Text = ""
                        Can3.Text = ""
                        Can4.Text = ""
                        Can5.Text = ""
                        Can6.Text = ""

                        ProNom1.Text = ""
                        ProNom2.Text = ""
                        ProNom3.Text = ""
                        ProNom4.Text = ""
                        ProNom5.Text = ""
                        ProNom6.Text = ""

                        pre1.Text = ""
                        pre2.Text = ""
                        pre3.Text = ""
                        pre4.Text = ""
                        pre5.Text = ""
                        pre6.Text = ""

                        presub1.Text = ""
                        presub2.Text = ""
                        presub3.Text = ""
                        presub4.Text = ""
                        presub5.Text = ""
                        presub6.Text = ""

                        btnp1.Visible = False
                        btnp2.Visible = False
                        btnp3.Visible = False
                        btnp4.Visible = False
                        btnp5.Visible = False
                        btnp6.Visible = False
                    End If
                    If Can7.Text <> "" Then
                        ObjCafeteria.Codigo_Cafeteria_Producto = ProCod7.Text
                        ObjCafeteria.Cantidad_Compra = Can7.Text
                        ObjCafeteria.Codigo_Cafeteria_Venta = lblcodigoventa.Text
                        ObjCafeteria.RegistroDetalleVenta()

                        ProCod1.Text = ""
                        Procod2.Text = ""
                        ProCod3.Text = ""
                        ProCod4.Text = ""
                        ProCod5.Text = ""
                        ProCod6.Text = ""
                        ProCod7.Text = ""

                        Can1.Text = ""
                        Can2.Text = ""
                        Can3.Text = ""
                        Can4.Text = ""
                        Can5.Text = ""
                        Can6.Text = ""
                        Can7.Text = ""

                        ProNom1.Text = ""
                        ProNom2.Text = ""
                        ProNom3.Text = ""
                        ProNom4.Text = ""
                        ProNom5.Text = ""
                        ProNom6.Text = ""
                        ProNom7.Text = ""

                        pre1.Text = ""
                        pre2.Text = ""
                        pre3.Text = ""
                        pre4.Text = ""
                        pre5.Text = ""
                        pre6.Text = ""
                        pre7.Text = ""

                        presub1.Text = ""
                        presub2.Text = ""
                        presub3.Text = ""
                        presub4.Text = ""
                        presub5.Text = ""
                        presub6.Text = ""
                        presub7.Text = ""

                        btnp1.Visible = False
                        btnp2.Visible = False
                        btnp3.Visible = False
                        btnp4.Visible = False
                        btnp5.Visible = False
                        btnp6.Visible = False
                        btnp7.Visible = False

                    End If

                End If
                TxtCodoDoc.Text = ""
                LblFechaActual.Text = ""
                LblCodigo.Text = ""
                LblDocumento.Text = ""
                LblNombre.Text = ""
                LblCargo.Text = ""
                LblFechaIng.Text = ""
                LblEstado.Text = ""
                LblTotal.Text = ""
            End If
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

 
    Protected Sub TxtProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtProducto.TextChanged
     
    End Sub
End Class
