Public Class Tipo_Cliente_Datos
    Inherits System.Web.UI.Page
    Dim ObjInforme As New clsInformes

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

    Protected Sub Colsultar_Click(sender As Object, e As EventArgs) Handles Colsultar.Click
        Try
            If TxtFecha_Inicio.Text = "" Then
                lblmsg.Text = "Ingrese Fecha Inicial"
                Exit Sub
            End If
            If RdbDia.Checked = False And RdbMes.Checked = False Then
                lblmsg.Text = "Seleccione Opcion Día o Mes"
                Exit Sub
            End If

            Dim dts As New DataSet
            Dim porcen As Double


            If RdbDia.Checked = True Then
                ObjInforme.Fcini = TxtFecha_Inicio.Text
                dts = ObjInforme.Consulta_Tipo_cliente_Dia_Datos
                lblFecha.Text = "Día : " & ObjInforme.Fcini
                If dts.Tables(0).Rows.Count > 0 Then
                    If dts.Tables(0).Rows(0).Item("Prepago") Is System.DBNull.Value Then
                        lblTlpre.Text = ""
                    Else
                        lblTlpre.Text = dts.Tables(0).Rows(0).Item("Prepago")
                    End If
                    If dts.Tables(0).Rows(0).Item("Pospago") Is System.DBNull.Value Then
                        lblTlpos.Text = ""
                    Else
                        lblTlpos.Text = dts.Tables(0).Rows(0).Item("Pospago")
                    End If
                    If dts.Tables(0).Rows(0).Item("Empresarial") Is System.DBNull.Value Then
                        lblTlemp.Text = ""
                    Else
                        lblTlemp.Text = dts.Tables(0).Rows(0).Item("Empresarial")
                    End If
                    If dts.Tables(0).Rows(0).Item("Total") Is System.DBNull.Value Then
                        lblTlcasos.Text = ""
                    Else
                        lblTlcasos.Text = dts.Tables(0).Rows(0).Item("Total")
                        porcen = (Val(lblTlpre.Text) / Val(lblTlcasos.Text))
                        lblPorpre.Text = Math.Round(porcen, 3) * (100) & " % "
                        porcen = (Val(lblTlpos.Text) / Val(lblTlcasos.Text))
                        lblPorpos.Text = Math.Round(porcen, 3) * (100) & " % "
                        porcen = (Val(lblTlemp.Text) / Val(lblTlcasos.Text))
                        lblPoremp.Text = Math.Round(porcen, 3) * (100) & " % "
                        porcen = (Val(lblTlcasos.Text) / Val(lblTlcasos.Text))
                        lblTlpor.Text = Math.Round(porcen, 3) * (100) & " % "
                    End If
                Else
                    lblTlpre.Text = ""
                    lblTlpos.Text = ""
                    lblTlemp.Text = ""
                    lblTlcasos.Text = ""
                End If

            ElseIf RdbMes.Checked = True Then
                ObjInforme.Mes = Month(TxtFecha_Inicio.Text)
                ObjInforme.Año = Year(TxtFecha_Inicio.Text)
                dts = ObjInforme.Consulta_Tipo_cliente_Mes_Datos
                If ObjInforme.Mes = 1 Then
                    lblFecha.Text = "Mes : Enero"
                End If
                If ObjInforme.Mes = 2 Then
                    lblFecha.Text = "Mes : Febrero"
                End If
                If ObjInforme.Mes = 3 Then
                    lblFecha.Text = "Mes : Marzo"
                End If
                If ObjInforme.Mes = 4 Then
                    lblFecha.Text = "Mes : Abril"
                End If
                If ObjInforme.Mes = 5 Then
                    lblFecha.Text = "Mes : Mayo"
                End If
                If ObjInforme.Mes = 6 Then
                    lblFecha.Text = "Mes : Junio"
                End If
                If ObjInforme.Mes = 7 Then
                    lblFecha.Text = "Mes : Julio"
                End If
                If ObjInforme.Mes = 8 Then
                    lblFecha.Text = "Mes : Agosto"
                End If
                If ObjInforme.Mes = 9 Then
                    lblFecha.Text = "Mes : Septiembre"
                End If
                If ObjInforme.Mes = 10 Then
                    lblFecha.Text = "Mes : Octubre"
                End If
                If ObjInforme.Mes = 11 Then
                    lblFecha.Text = "Mes : Noviembre"
                End If
                If ObjInforme.Mes = 12 Then
                    lblFecha.Text = "Mes : Diciembre"
                End If
                If dts.Tables(0).Rows.Count > 0 Then
                    If dts.Tables(0).Rows(0).Item("Prepago") Is System.DBNull.Value Then
                        lblTlpre.Text = ""
                    Else
                        lblTlpre.Text = dts.Tables(0).Rows(0).Item("Prepago")
                    End If
                    If dts.Tables(0).Rows(0).Item("Pospago") Is System.DBNull.Value Then
                        lblTlpos.Text = ""
                    Else
                        lblTlpos.Text = dts.Tables(0).Rows(0).Item("Pospago")
                    End If
                    If dts.Tables(0).Rows(0).Item("Empresarial") Is System.DBNull.Value Then
                        lblTlemp.Text = ""
                    Else
                        lblTlemp.Text = dts.Tables(0).Rows(0).Item("Empresarial")
                    End If

                    lblTlcasos.Text = Val(lblTlpre.Text) + Val(lblTlpos.Text) + Val(lblTlemp.Text)
                    porcen = (Val(lblTlpre.Text) / Val(lblTlcasos.Text))
                    lblPorpre.Text = Math.Round(porcen, 3) * (100) & " % "
                    porcen = (Val(lblTlpos.Text) / Val(lblTlcasos.Text))
                    lblPorpos.Text = Math.Round(porcen, 3) * (100) & " % "
                    porcen = (Val(lblTlemp.Text) / Val(lblTlcasos.Text))
                    lblPoremp.Text = Math.Round(porcen, 3) * (100) & " % "
                    porcen = (Val(lblTlcasos.Text) / Val(lblTlcasos.Text))
                    lblTlpor.Text = Math.Round(porcen, 3) * (100) & " % "
                End If

            Else
                lblTlpre.Text = ""
                lblTlpos.Text = ""
                lblTlemp.Text = ""
                lblTlcasos.Text = ""
            End If
            TxtFecha_Inicio.Text = ""
        Catch ex As Exception

        End Try
    End Sub
End Class