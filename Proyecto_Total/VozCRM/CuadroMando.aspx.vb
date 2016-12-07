Public Class CuadroMando
    Inherits System.Web.UI.Page
    Dim ObjVoz As New clsvoz

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
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
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Public Sub Consulta_Cuadro_Mando()
        Try

        
        If drlAño.Text = "1" Then
            lblmsg.Text = "Seleccione un años de consulta"
            Exit Sub
        End If
        If drlMes.Text = "0" Then
            lblmsg.Text = "Seleccione un mes de consulta"
            Exit Sub
        End If
        If drlBandeja.Text = "1" Then
            lblmsg.Text = "Seleccione una bandeja de consulta"
            Exit Sub
        End If
        ObjVoz.Año = drlAño.Text
        ObjVoz.Mes = drlMes.Text
        ObjVoz.Bandeja = drlBandeja.Text
        Dim FechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim año As String
        Dim mes As String
        año = Year(FechaActual)
        mes = Month(FechaActual)
        If drlAño.Text = año And drlMes.Text = mes Then
            LblMesConsulta.Text = drlMes.SelectedItem.ToString + " del " + drlAño.Text + " Hasta la fecha de corte"
        Else
            LblMesConsulta.Text = drlMes.SelectedItem.ToString + " del " + drlAño.Text
        End If
        Dim dts As New DataSet
        Dim cantidad As Integer
        dts = ObjVoz.Consulta_Cuadro_Mando()
        cantidad = dts.Tables(0).Rows.Count


        If drlBandeja.Text = "VOZ" Or drlBandeja.Text = "TOTAL" Then
            If drlBandeja.Text = "TOTAL" Then
                ObjVoz.Bandeja = "VOZ"
                dts = ObjVoz.Consulta_Cuadro_Mando()
                cantidad = dts.Tables(0).Rows.Count
            End If
            If cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Ingreso") Is System.DBNull.Value Then
                    LblIngreso_VOZ.Text = ""
                Else
                    LblIngreso_VOZ.Text = dts.Tables(0).Rows(0).Item("Ingreso")
                End If
                If dts.Tables(0).Rows(0).Item("Efectividad") Is System.DBNull.Value Then
                    LblEfectividad_VOZ.Text = ""
                Else
                    LblEfectividad_VOZ.Text = dts.Tables(0).Rows(0).Item("Efectividad")
                End If
                If dts.Tables(0).Rows(0).Item("Menor_24_H_Efe") Is System.DBNull.Value Then
                    LblEfectividad_VOZ_2.Text = ""
                Else
                    LblEfectividad_VOZ_2.Text = dts.Tables(0).Rows(0).Item("Menor_24_H_Efe")
                End If
                If dts.Tables(0).Rows(0).Item("Entre_24_48_H_Efe") Is System.DBNull.Value Then
                    LblEfectividad_VOZ_3.Text = ""
                Else
                    LblEfectividad_VOZ_3.Text = dts.Tables(0).Rows(0).Item("Entre_24_48_H_Efe")
                End If
                If dts.Tables(0).Rows(0).Item("Mayor_48_H_Efe") Is System.DBNull.Value Then
                    LblEfectividad_VOZ_4.Text = ""
                Else
                    LblEfectividad_VOZ_4.Text = dts.Tables(0).Rows(0).Item("Mayor_48_H_Efe")
                End If
                If dts.Tables(0).Rows(0).Item("Contactabilidad") Is System.DBNull.Value Then
                    LblContactabilidad_VOZ.Text = ""
                Else
                    LblContactabilidad_VOZ.Text = dts.Tables(0).Rows(0).Item("Contactabilidad")
                End If
                If dts.Tables(0).Rows(0).Item("TMO_Min") Is System.DBNull.Value Then
                    Lbl_TMO_Min_VOZ.Text = ""
                Else
                    Lbl_TMO_Min_VOZ.Text = dts.Tables(0).Rows(0).Item("TMO_Min")
                End If
                If dts.Tables(0).Rows(0).Item("Menor_24_H") Is System.DBNull.Value Then
                    Lbl_TMO_Min_VOZ_2.Text = ""
                Else
                    Lbl_TMO_Min_VOZ_2.Text = dts.Tables(0).Rows(0).Item("Menor_24_H")
                End If
                If dts.Tables(0).Rows(0).Item("Entre_24_48_H") Is System.DBNull.Value Then
                    Lbl_TMO_Min_VOZ_3.Text = ""
                Else
                    Lbl_TMO_Min_VOZ_3.Text = dts.Tables(0).Rows(0).Item("Entre_24_48_H")
                End If
                If dts.Tables(0).Rows(0).Item("Mayor_48_H") Is System.DBNull.Value Then
                    Lbl_TMO_Min_VOZ_4.Text = ""
                Else
                    Lbl_TMO_Min_VOZ_4.Text = dts.Tables(0).Rows(0).Item("Mayor_48_H")
                End If
                PanelVOZ.Visible = True
            Else
                LblIngreso_VOZ.Text = ""
                LblEfectividad_VOZ.Text = ""
                LblEfectividad_VOZ_2.Text = ""
                LblEfectividad_VOZ_3.Text = ""
                LblEfectividad_VOZ_4.Text = ""
                LblContactabilidad_VOZ.Text = ""
                Lbl_TMO_Min_VOZ.Text = ""
                Lbl_TMO_Min_VOZ_2.Text = ""
                Lbl_TMO_Min_VOZ_3.Text = ""
                Lbl_TMO_Min_VOZ_4.Text = ""
            End If
        End If
        If drlBandeja.Text = "DATOS" Or drlBandeja.Text = "TOTAL" Then
            If drlBandeja.Text = "TOTAL" Then
                ObjVoz.Bandeja = "DATOS"
                dts = ObjVoz.Consulta_Cuadro_Mando()
                cantidad = dts.Tables(0).Rows.Count
            End If
            If cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Ingreso") Is System.DBNull.Value Then
                    LblIngreso_DATOS.Text = ""
                Else
                    LblIngreso_DATOS.Text = dts.Tables(0).Rows(0).Item("Ingreso")
                End If
                If dts.Tables(0).Rows(0).Item("Efectividad") Is System.DBNull.Value Then
                    LblEfectividad_DATOS.Text = ""
                Else
                    LblEfectividad_DATOS.Text = dts.Tables(0).Rows(0).Item("Efectividad")
                End If
                If dts.Tables(0).Rows(0).Item("Menor_24_H_Efe") Is System.DBNull.Value Then
                    LblEfectividad_DATOS_2.Text = ""
                Else
                    LblEfectividad_DATOS_2.Text = dts.Tables(0).Rows(0).Item("Menor_24_H_Efe")
                End If
                If dts.Tables(0).Rows(0).Item("Entre_24_48_H_Efe") Is System.DBNull.Value Then
                    LblEfectividad_DATOS_3.Text = ""
                Else
                    LblEfectividad_DATOS_3.Text = dts.Tables(0).Rows(0).Item("Entre_24_48_H_Efe")
                End If
                If dts.Tables(0).Rows(0).Item("Mayor_48_H_Efe") Is System.DBNull.Value Then
                    LblEfectividad_DATOS_4.Text = ""
                Else
                    LblEfectividad_DATOS_4.Text = dts.Tables(0).Rows(0).Item("Mayor_48_H_Efe")
                End If
                If dts.Tables(0).Rows(0).Item("Contactabilidad") Is System.DBNull.Value Then
                    LblContactabilidad_DATOS.Text = ""
                Else
                    LblContactabilidad_DATOS.Text = dts.Tables(0).Rows(0).Item("Contactabilidad")
                End If
                If dts.Tables(0).Rows(0).Item("TMO_Min") Is System.DBNull.Value Then
                    Lbl_TMO_Min_DATOS.Text = ""
                Else
                    Lbl_TMO_Min_DATOS.Text = dts.Tables(0).Rows(0).Item("TMO_Min")
                End If
                If dts.Tables(0).Rows(0).Item("Menor_24_H") Is System.DBNull.Value Then
                    Lbl_TMO_Min_DATOS_2.Text = ""
                Else
                    Lbl_TMO_Min_DATOS_2.Text = dts.Tables(0).Rows(0).Item("Menor_24_H")
                End If
                If dts.Tables(0).Rows(0).Item("Entre_24_48_H") Is System.DBNull.Value Then
                    Lbl_TMO_Min_DATOS_3.Text = ""
                Else
                    Lbl_TMO_Min_DATOS_3.Text = dts.Tables(0).Rows(0).Item("Entre_24_48_H")
                End If
                If dts.Tables(0).Rows(0).Item("Mayor_48_H") Is System.DBNull.Value Then
                    Lbl_TMO_Min_DATOS_4.Text = ""
                Else
                    Lbl_TMO_Min_DATOS_4.Text = dts.Tables(0).Rows(0).Item("Mayor_48_H")
                End If
                PanelDATOS.Visible = True
            Else
                LblIngreso_DATOS.Text = ""
                LblEfectividad_DATOS.Text = ""
                LblEfectividad_DATOS_2.Text = ""
                LblEfectividad_DATOS_3.Text = ""
                LblEfectividad_DATOS_4.Text = ""
                LblContactabilidad_DATOS.Text = ""
                Lbl_TMO_Min_DATOS.Text = ""
                Lbl_TMO_Min_DATOS_2.Text = ""
                Lbl_TMO_Min_DATOS_3.Text = ""
                Lbl_TMO_Min_DATOS_4.Text = ""
            End If
        End If

        If drlBandeja.Text = "DATOS-VOZ" Or drlBandeja.Text = "TOTAL" Then
            If drlBandeja.Text = "TOTAL" Then
                ObjVoz.Bandeja = "DATOS-VOZ"
                dts = ObjVoz.Consulta_Cuadro_Mando()
                cantidad = dts.Tables(0).Rows.Count
            End If
            If cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Ingreso") Is System.DBNull.Value Then
                    LblIngreso_TOTAL.Text = ""
                Else
                    LblIngreso_TOTAL.Text = dts.Tables(0).Rows(0).Item("Ingreso")
                End If
                If dts.Tables(0).Rows(0).Item("Efectividad") Is System.DBNull.Value Then
                    LblEfectividad_TOTAL.Text = ""
                Else
                    LblEfectividad_TOTAL.Text = dts.Tables(0).Rows(0).Item("Efectividad")
                End If
                If dts.Tables(0).Rows(0).Item("Menor_24_H_Efe") Is System.DBNull.Value Then
                    LblEfectividad_TOTAL_2.Text = ""
                Else
                    LblEfectividad_TOTAL_2.Text = dts.Tables(0).Rows(0).Item("Menor_24_H_Efe")
                End If
                If dts.Tables(0).Rows(0).Item("Entre_24_48_H_Efe") Is System.DBNull.Value Then
                    LblEfectividad_TOTAL_3.Text = ""
                Else
                    LblEfectividad_TOTAL_3.Text = dts.Tables(0).Rows(0).Item("Entre_24_48_H_Efe")
                End If
                If dts.Tables(0).Rows(0).Item("Mayor_48_H_Efe") Is System.DBNull.Value Then
                    LblEfectividad_TOTAL_4.Text = ""
                Else
                    LblEfectividad_TOTAL_4.Text = dts.Tables(0).Rows(0).Item("Mayor_48_H_Efe")
                End If
                If dts.Tables(0).Rows(0).Item("Contactabilidad") Is System.DBNull.Value Then
                    LblContactabilidad_TOTAL.Text = ""
                Else
                    LblContactabilidad_TOTAL.Text = dts.Tables(0).Rows(0).Item("Contactabilidad")
                End If
                If dts.Tables(0).Rows(0).Item("TMO_Min") Is System.DBNull.Value Then
                    Lbl_TMO_Min_TOTAL.Text = ""
                Else
                    Lbl_TMO_Min_TOTAL.Text = dts.Tables(0).Rows(0).Item("TMO_Min")
                End If
                If dts.Tables(0).Rows(0).Item("Menor_24_H") Is System.DBNull.Value Then
                    Lbl_TMO_Min_TOTAL_2.Text = ""
                Else
                    Lbl_TMO_Min_TOTAL_2.Text = dts.Tables(0).Rows(0).Item("Menor_24_H")
                End If
                If dts.Tables(0).Rows(0).Item("Entre_24_48_H") Is System.DBNull.Value Then
                    Lbl_TMO_Min_TOTAL_3.Text = ""
                Else
                    Lbl_TMO_Min_TOTAL_3.Text = dts.Tables(0).Rows(0).Item("Entre_24_48_H")
                End If
                If dts.Tables(0).Rows(0).Item("Mayor_48_H") Is System.DBNull.Value Then
                    Lbl_TMO_Min_TOTAL_4.Text = ""
                Else
                    Lbl_TMO_Min_TOTAL_4.Text = dts.Tables(0).Rows(0).Item("Mayor_48_H")
                End If
                PanelTOTAL.Visible = True
            Else
                LblIngreso_TOTAL.Text = ""
                LblEfectividad_TOTAL.Text = ""
                LblEfectividad_TOTAL_2.Text = ""
                LblEfectividad_TOTAL_3.Text = ""
                LblEfectividad_TOTAL_4.Text = ""
                LblContactabilidad_TOTAL.Text = ""
                Lbl_TMO_Min_TOTAL.Text = ""
                Lbl_TMO_Min_TOTAL_2.Text = ""
                Lbl_TMO_Min_TOTAL_3.Text = ""
                Lbl_TMO_Min_TOTAL_4.Text = ""
            End If
        End If
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            Consulta_Cuadro_Mando()
            If CheckBoxOcultar.Checked = True Then
                If drlBandeja.Text = "DATOS-VOZ" Then
                    PanelDATOS.Visible = False
                    PanelVOZ.Visible = False
                End If
                If drlBandeja.Text = "VOZ" Then
                    PanelDATOS.Visible = False
                    PanelTOTAL.Visible = False

                End If
                If drlBandeja.Text = "DATOS" Then
                    PanelTOTAL.Visible = False
                    PanelVOZ.Visible = False
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class