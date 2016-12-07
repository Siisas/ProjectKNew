Public Class PollaMundialista2
    Inherits System.Web.UI.Page
    Dim ObjMundial As New clsCaidaSistema
    Dim Validacion As Boolean = False

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Consulta_Encuentros()
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

    Public Sub Consulta_Raiking()
        Try
            If drlPartidoConsulta.Text <> "- Seleccione -" Then
                ObjMundial.Partido_N1 = drlPartidoConsulta.Text
            End If
            ObjMundial.Id_Usuario = lblusuario.Text
            dtgRaiking.DataSource = ObjMundial.Consulta_Polla_Mundialista_Raiking()
            dtgRaiking.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Consulta_Encuentros()
        Try
            Dim dts As New DataSet
            dts = ObjMundial.Consulta_Polla_Mundialista_Fecha_Encuentros()
            
            ' ''Partido N49
            'If dts.Tables(0).Rows.Count >= 3 Then
            '    If dts.Tables(0).Rows(0).Item("Nombre") Is DBNull.Value Then
            '        LblFecha49_1.Text = ""
            '    Else
            '        LblFecha49_1.Text = dts.Tables(0).Rows(0).Item("Nombre")
            '    End If
            '    ImgFecha49_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha49_1.Text + ".png"
            '    If dts.Tables(0).Rows(3).Item("Nombre") Is DBNull.Value Then
            '        LblFecha49_2.Text = ""
            '    Else
            '        LblFecha49_2.Text = dts.Tables(0).Rows(3).Item("Nombre")
            '    End If
            '    ImgFecha49_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha49_2.Text + ".png"
            'End If

            ' ''Partido N50
            'If dts.Tables(0).Rows.Count >= 7 Then
            '    If dts.Tables(0).Rows(4).Item("Nombre") Is DBNull.Value Then
            '        LblFecha50_1.Text = ""
            '    Else
            '        LblFecha50_1.Text = dts.Tables(0).Rows(4).Item("Nombre")
            '    End If
            '    ImgFecha50_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha50_1.Text + ".png"
            '    If dts.Tables(0).Rows(7).Item("Nombre") Is DBNull.Value Then
            '        LblFecha50_2.Text = ""
            '    Else
            '        LblFecha50_2.Text = dts.Tables(0).Rows(7).Item("Nombre")
            '    End If
            '    ImgFecha50_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha50_2.Text + ".png"
            'End If

            ' ''Partido N51
            'If dts.Tables(0).Rows.Count >= 2 Then
            '    If dts.Tables(0).Rows(2).Item("Nombre") Is DBNull.Value Then
            '        LblFecha51_1.Text = ""
            '    Else
            '        LblFecha51_1.Text = dts.Tables(0).Rows(2).Item("Nombre")
            '    End If
            '    ImgFecha51_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha51_1.Text + ".png"
            '    If dts.Tables(0).Rows(1).Item("Nombre") Is DBNull.Value Then
            '        LblFecha51_2.Text = ""
            '    Else
            '        LblFecha51_2.Text = dts.Tables(0).Rows(1).Item("Nombre")
            '    End If
            '    ImgFecha51_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha51_2.Text + ".png"
            'End If

            ' ''Partido N52
            'If dts.Tables(0).Rows.Count >= 6 Then
            '    If dts.Tables(0).Rows(6).Item("Nombre") Is DBNull.Value Then
            '        LblFecha52_1.Text = ""
            '    Else
            '        LblFecha52_1.Text = dts.Tables(0).Rows(6).Item("Nombre")
            '    End If
            '    ImgFecha52_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha52_1.Text + ".png"
            '    If dts.Tables(0).Rows(5).Item("Nombre") Is DBNull.Value Then
            '        LblFecha52_2.Text = ""
            '    Else
            '        LblFecha52_2.Text = dts.Tables(0).Rows(5).Item("Nombre")
            '    End If
            '    ImgFecha52_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha52_2.Text + ".png"
            'End If

            ' ''Partido N53
            'If dts.Tables(0).Rows.Count >= 11 Then
            '    If dts.Tables(0).Rows(8).Item("Nombre") Is DBNull.Value Then
            '        LblFecha53_1.Text = ""
            '    Else
            '        LblFecha53_1.Text = dts.Tables(0).Rows(8).Item("Nombre")
            '    End If
            '    ImgFecha53_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha53_1.Text + ".png"
            '    If dts.Tables(0).Rows(11).Item("Nombre") Is DBNull.Value Then
            '        LblFecha53_2.Text = ""
            '    Else
            '        LblFecha53_2.Text = dts.Tables(0).Rows(11).Item("Nombre")
            '    End If
            '    ImgFecha53_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha53_2.Text + ".png"
            'End If

            ' ''Partido N54
            'If dts.Tables(0).Rows.Count >= 15 Then
            '    If dts.Tables(0).Rows(12).Item("Nombre") Is DBNull.Value Then
            '        LblFecha54_1.Text = ""
            '    Else
            '        LblFecha54_1.Text = dts.Tables(0).Rows(12).Item("Nombre")
            '    End If
            '    ImgFecha54_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha54_1.Text + ".png"
            '    If dts.Tables(0).Rows(15).Item("Nombre") Is DBNull.Value Then
            '        LblFecha54_2.Text = ""
            '    Else
            '        LblFecha54_2.Text = dts.Tables(0).Rows(15).Item("Nombre")
            '    End If
            '    ImgFecha54_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha54_2.Text + ".png"
            'End If

            ' ''Partido N55
            'If dts.Tables(0).Rows.Count >= 10 Then
            '    If dts.Tables(0).Rows(10).Item("Nombre") Is DBNull.Value Then
            '        LblFecha55_1.Text = ""
            '    Else
            '        LblFecha55_1.Text = dts.Tables(0).Rows(10).Item("Nombre")
            '    End If
            '    ImgFecha55_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha55_1.Text + ".png"
            '    If dts.Tables(0).Rows(9).Item("Nombre") Is DBNull.Value Then
            '        LblFecha55_2.Text = ""
            '    Else
            '        LblFecha55_2.Text = dts.Tables(0).Rows(9).Item("Nombre")
            '    End If
            '    ImgFecha55_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha55_2.Text + ".png"
            'End If

            ' ''Partido N56
            'If dts.Tables(0).Rows.Count >= 14 Then
            '    If dts.Tables(0).Rows(14).Item("Nombre") Is DBNull.Value Then
            '        LblFecha56_1.Text = ""
            '    Else
            '        LblFecha56_1.Text = dts.Tables(0).Rows(14).Item("Nombre")
            '    End If
            '    ImgFecha56_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha56_1.Text + ".png"
            '    If dts.Tables(0).Rows(13).Item("Nombre") Is DBNull.Value Then
            '        LblFecha56_2.Text = ""
            '    Else
            '        LblFecha56_2.Text = dts.Tables(0).Rows(13).Item("Nombre")
            '    End If
            '    ImgFecha56_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha56_2.Text + ".png"
            'End If

            ''Partido N57
            If dts.Tables(0).Rows.Count >= 17 Then
                If dts.Tables(0).Rows(16).Item("Nombre") Is DBNull.Value Then
                    LblFecha57_1.Text = ""
                Else
                    LblFecha57_1.Text = dts.Tables(0).Rows(16).Item("Nombre")
                End If
                ImgFecha57_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha57_1.Text + ".png"
                If dts.Tables(0).Rows(17).Item("Nombre") Is DBNull.Value Then
                    LblFecha57_2.Text = ""
                Else
                    LblFecha57_2.Text = dts.Tables(0).Rows(17).Item("Nombre")
                End If
                ImgFecha57_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha57_2.Text + ".png"
            End If

            ''Partido N58
            If dts.Tables(0).Rows.Count >= 19 Then
                If dts.Tables(0).Rows(18).Item("Nombre") Is DBNull.Value Then
                    LblFecha58_1.Text = ""
                Else
                    LblFecha58_1.Text = dts.Tables(0).Rows(18).Item("Nombre")
                End If
                ImgFecha58_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha58_1.Text + ".png"
                If dts.Tables(0).Rows(19).Item("Nombre") Is DBNull.Value Then
                    LblFecha58_2.Text = ""
                Else
                    LblFecha58_2.Text = dts.Tables(0).Rows(19).Item("Nombre")
                End If
                ImgFecha58_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha58_2.Text + ".png"
            End If

            ''Partido N59
            If dts.Tables(0).Rows.Count >= 21 Then
                If dts.Tables(0).Rows(20).Item("Nombre") Is DBNull.Value Then
                    LblFecha59_1.Text = ""
                Else
                    LblFecha59_1.Text = dts.Tables(0).Rows(20).Item("Nombre")
                End If
                ImgFecha59_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha59_1.Text + ".png"
                If dts.Tables(0).Rows(21).Item("Nombre") Is DBNull.Value Then
                    LblFecha59_2.Text = ""
                Else
                    LblFecha59_2.Text = dts.Tables(0).Rows(21).Item("Nombre")
                End If
                ImgFecha59_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha59_2.Text + ".png"
            End If

            ''Partido N60
            If dts.Tables(0).Rows.Count >= 23 Then
                If dts.Tables(0).Rows(22).Item("Nombre") Is DBNull.Value Then
                    LblFecha60_1.Text = ""
                Else
                    LblFecha60_1.Text = dts.Tables(0).Rows(22).Item("Nombre")
                End If
                ImgFecha60_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha60_1.Text + ".png"
                If dts.Tables(0).Rows(23).Item("Nombre") Is DBNull.Value Then
                    LblFecha60_2.Text = ""
                Else
                    LblFecha60_2.Text = dts.Tables(0).Rows(23).Item("Nombre")
                End If
                ImgFecha60_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha60_2.Text + ".png"
            End If

            ''Partido N61
            If dts.Tables(0).Rows.Count >= 25 Then
                If dts.Tables(0).Rows(24).Item("Nombre") Is DBNull.Value Then
                    LblFecha61_1.Text = ""
                Else
                    LblFecha61_1.Text = dts.Tables(0).Rows(24).Item("Nombre")
                End If
                ImgFecha61_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha61_1.Text + ".png"
                If dts.Tables(0).Rows(25).Item("Nombre") Is DBNull.Value Then
                    LblFecha61_2.Text = ""
                Else
                    LblFecha61_2.Text = dts.Tables(0).Rows(25).Item("Nombre")
                End If
                ImgFecha61_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha61_2.Text + ".png"
            End If

            ''Partido N62
            If dts.Tables(0).Rows.Count >= 27 Then
                If dts.Tables(0).Rows(26).Item("Nombre") Is DBNull.Value Then
                    LblFecha62_1.Text = ""
                Else
                    LblFecha62_1.Text = dts.Tables(0).Rows(26).Item("Nombre")
                End If
                ImgFecha62_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha62_1.Text + ".png"
                If dts.Tables(0).Rows(27).Item("Nombre") Is DBNull.Value Then
                    LblFecha62_2.Text = ""
                Else
                    LblFecha62_2.Text = dts.Tables(0).Rows(27).Item("Nombre")
                End If
                ImgFecha62_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha62_2.Text + ".png"
            End If

            ''Partido N63
            If dts.Tables(0).Rows.Count >= 29 Then
                If dts.Tables(0).Rows(28).Item("Nombre") Is DBNull.Value Then
                    LblFecha63_1.Text = ""
                Else
                    LblFecha63_1.Text = dts.Tables(0).Rows(28).Item("Nombre")
                End If
                ImgFecha63_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha63_1.Text + ".png"
                If dts.Tables(0).Rows(29).Item("Nombre") Is DBNull.Value Then
                    LblFecha63_2.Text = ""
                Else
                    LblFecha63_2.Text = dts.Tables(0).Rows(29).Item("Nombre")
                End If
                ImgFecha63_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha63_2.Text + ".png"
            End If

            ''Partido N64
            If dts.Tables(0).Rows.Count >= 31 Then
                If dts.Tables(0).Rows(30).Item("Nombre") Is DBNull.Value Then
                    LblFecha64_1.Text = ""
                Else
                    LblFecha64_1.Text = dts.Tables(0).Rows(30).Item("Nombre")
                End If
                ImgFecha64_1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha64_1.Text + ".png"
                If dts.Tables(0).Rows(31).Item("Nombre") Is DBNull.Value Then
                    LblFecha64_2.Text = ""
                Else
                    LblFecha64_2.Text = dts.Tables(0).Rows(31).Item("Nombre")
                End If
                ImgFecha64_2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha64_2.Text + ".png"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Validacion_Envia_Datos()
        Try
            ''Partido 49
            If drlPartido.Text = 49 Then
                If LblFecha49_1.Text = "" Or LblFecha49_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado49_1.Text = "" Or TxtResultado49_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha49_1.Text
                ObjMundial.Equipo2 = LblFecha49_2.Text
                ObjMundial.Resultado1 = TxtResultado49_1.Text
                ObjMundial.Resultado2 = TxtResultado49_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado49_1.Text = TxtResultado49_2.Text Then
                    If RadioBtnResultado49_1.Checked = False And RadioBtnResultado49_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha49_1.Text + " o " + LblFecha49_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado49_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha49_1.Text
                    End If
                    If RadioBtnResultado49_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha49_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado49_1.Text > TxtResultado49_2.Text Then
                    ObjMundial.EquipoGana = LblFecha49_1.Text
                Else
                    If TxtResultado49_1.Text < TxtResultado49_2.Text Then
                        ObjMundial.EquipoGana = LblFecha49_2.Text
                    End If
                End If
            End If
            ''Partido 50
            If drlPartido.Text = 50 Then
                If LblFecha50_1.Text = "" Or LblFecha50_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado50_1.Text = "" Or TxtResultado50_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha50_1.Text
                ObjMundial.Equipo2 = LblFecha50_2.Text
                ObjMundial.Resultado1 = TxtResultado50_1.Text
                ObjMundial.Resultado2 = TxtResultado50_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado50_1.Text = TxtResultado50_2.Text Then
                    If RadioBtnResultado50_1.Checked = False And RadioBtnResultado50_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha50_1.Text + " o " + LblFecha50_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado50_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha50_1.Text
                    End If
                    If RadioBtnResultado50_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha50_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado50_1.Text > TxtResultado50_2.Text Then
                    ObjMundial.EquipoGana = LblFecha50_1.Text
                Else
                    If TxtResultado50_1.Text < TxtResultado50_2.Text Then
                        ObjMundial.EquipoGana = LblFecha50_2.Text
                    End If
                End If
            End If
            ''Partido 51
            If drlPartido.Text = 51 Then
                If LblFecha51_1.Text = "" Or LblFecha51_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado51_1.Text = "" Or TxtResultado51_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha51_1.Text
                ObjMundial.Equipo2 = LblFecha51_2.Text
                ObjMundial.Resultado1 = TxtResultado51_1.Text
                ObjMundial.Resultado2 = TxtResultado51_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado51_1.Text = TxtResultado51_2.Text Then
                    If RadioBtnResultado51_1.Checked = False And RadioBtnResultado51_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha51_1.Text + " o " + LblFecha51_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado51_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha51_1.Text
                    End If
                    If RadioBtnResultado51_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha51_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado51_1.Text > TxtResultado51_2.Text Then
                    ObjMundial.EquipoGana = LblFecha51_1.Text
                Else
                    If TxtResultado51_1.Text < TxtResultado51_2.Text Then
                        ObjMundial.EquipoGana = LblFecha51_2.Text
                    End If
                End If
            End If
            ''Partido 52
            If drlPartido.Text = 52 Then
                If LblFecha52_1.Text = "" Or LblFecha52_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado52_1.Text = "" Or TxtResultado52_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha52_1.Text
                ObjMundial.Equipo2 = LblFecha52_2.Text
                ObjMundial.Resultado1 = TxtResultado52_1.Text
                ObjMundial.Resultado2 = TxtResultado52_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado52_1.Text = TxtResultado52_2.Text Then
                    If RadioBtnResultado52_1.Checked = False And RadioBtnResultado52_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha52_1.Text + " o " + LblFecha52_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado52_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha52_1.Text
                    End If
                    If RadioBtnResultado52_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha52_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado52_1.Text > TxtResultado52_2.Text Then
                    ObjMundial.EquipoGana = LblFecha52_1.Text
                Else
                    If TxtResultado52_1.Text < TxtResultado52_2.Text Then
                        ObjMundial.EquipoGana = LblFecha52_2.Text
                    End If
                End If
            End If
            ''Partido 53
            If drlPartido.Text = 53 Then
                If LblFecha53_1.Text = "" Or LblFecha53_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado53_1.Text = "" Or TxtResultado53_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha53_1.Text
                ObjMundial.Equipo2 = LblFecha53_2.Text
                ObjMundial.Resultado1 = TxtResultado53_1.Text
                ObjMundial.Resultado2 = TxtResultado53_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado53_1.Text = TxtResultado53_2.Text Then
                    If RadioBtnResultado53_1.Checked = False And RadioBtnResultado53_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha53_1.Text + " o " + LblFecha53_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado53_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha53_1.Text
                    End If
                    If RadioBtnResultado53_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha53_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado53_1.Text > TxtResultado53_2.Text Then
                    ObjMundial.EquipoGana = LblFecha53_1.Text
                Else
                    If TxtResultado53_1.Text < TxtResultado53_2.Text Then
                        ObjMundial.EquipoGana = LblFecha53_2.Text
                    End If
                End If
            End If
            ''Partido 54
            If drlPartido.Text = 54 Then
                If LblFecha54_1.Text = "" Or LblFecha54_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado54_1.Text = "" Or TxtResultado54_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha54_1.Text
                ObjMundial.Equipo2 = LblFecha54_2.Text
                ObjMundial.Resultado1 = TxtResultado54_1.Text
                ObjMundial.Resultado2 = TxtResultado54_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado54_1.Text = TxtResultado54_2.Text Then
                    If RadioBtnResultado54_1.Checked = False And RadioBtnResultado54_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha54_1.Text + " o " + LblFecha54_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado54_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha54_1.Text
                    End If
                    If RadioBtnResultado54_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha54_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado54_1.Text > TxtResultado54_2.Text Then
                    ObjMundial.EquipoGana = LblFecha54_1.Text
                Else
                    If TxtResultado54_1.Text < TxtResultado54_2.Text Then
                        ObjMundial.EquipoGana = LblFecha54_2.Text
                    End If
                End If
            End If
            ''Partido 55
            If drlPartido.Text = 55 Then
                If LblFecha55_1.Text = "" Or LblFecha55_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado55_1.Text = "" Or TxtResultado55_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha55_1.Text
                ObjMundial.Equipo2 = LblFecha55_2.Text
                ObjMundial.Resultado1 = TxtResultado55_1.Text
                ObjMundial.Resultado2 = TxtResultado55_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado55_1.Text = TxtResultado55_2.Text Then
                    If RadioBtnResultado55_1.Checked = False And RadioBtnResultado55_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha55_1.Text + " o " + LblFecha55_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado55_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha55_1.Text
                    End If
                    If RadioBtnResultado55_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha55_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado55_1.Text > TxtResultado55_2.Text Then
                    ObjMundial.EquipoGana = LblFecha55_1.Text
                Else
                    If TxtResultado55_1.Text < TxtResultado55_2.Text Then
                        ObjMundial.EquipoGana = LblFecha55_2.Text
                    End If
                End If
            End If
            ''Partido 56
            If drlPartido.Text = 56 Then
                If LblFecha56_1.Text = "" Or LblFecha56_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado56_1.Text = "" Or TxtResultado56_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha56_1.Text
                ObjMundial.Equipo2 = LblFecha56_2.Text
                ObjMundial.Resultado1 = TxtResultado56_1.Text
                ObjMundial.Resultado2 = TxtResultado56_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado56_1.Text = TxtResultado56_2.Text Then
                    If RadioBtnResultado56_1.Checked = False And RadioBtnResultado56_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha56_1.Text + " o " + LblFecha56_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado56_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha56_1.Text
                    End If
                    If RadioBtnResultado56_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha56_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado56_1.Text > TxtResultado56_2.Text Then
                    ObjMundial.EquipoGana = LblFecha56_1.Text
                Else
                    If TxtResultado56_1.Text < TxtResultado56_2.Text Then
                        ObjMundial.EquipoGana = LblFecha56_2.Text
                    End If
                End If
            End If
            ''Partido 57
            If drlPartido.Text = 57 Then
                If LblFecha57_1.Text = "" Or LblFecha57_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado57_1.Text = "" Or TxtResultado57_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha57_1.Text
                ObjMundial.Equipo2 = LblFecha57_2.Text
                ObjMundial.Resultado1 = TxtResultado57_1.Text
                ObjMundial.Resultado2 = TxtResultado57_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado57_1.Text = TxtResultado57_2.Text Then
                    If RadioBtnResultado57_1.Checked = False And RadioBtnResultado57_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha57_1.Text + " o " + LblFecha57_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado57_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha57_1.Text
                    End If
                    If RadioBtnResultado57_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha57_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado57_1.Text > TxtResultado57_2.Text Then
                    ObjMundial.EquipoGana = LblFecha57_1.Text
                Else
                    If TxtResultado57_1.Text < TxtResultado57_2.Text Then
                        ObjMundial.EquipoGana = LblFecha57_2.Text
                    End If
                End If
            End If
            ''Partido 58
            If drlPartido.Text = 58 Then
                If LblFecha58_1.Text = "" Or LblFecha58_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado58_1.Text = "" Or TxtResultado58_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha58_1.Text
                ObjMundial.Equipo2 = LblFecha58_2.Text
                ObjMundial.Resultado1 = TxtResultado58_1.Text
                ObjMundial.Resultado2 = TxtResultado58_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado58_1.Text = TxtResultado58_2.Text Then
                    If RadioBtnResultado58_1.Checked = False And RadioBtnResultado58_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha58_1.Text + " o " + LblFecha58_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado58_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha58_1.Text
                    End If
                    If RadioBtnResultado58_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha58_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado58_1.Text > TxtResultado58_2.Text Then
                    ObjMundial.EquipoGana = LblFecha58_1.Text
                Else
                    If TxtResultado58_1.Text < TxtResultado58_2.Text Then
                        ObjMundial.EquipoGana = LblFecha58_2.Text
                    End If
                End If
            End If
            ''Partido 59
            If drlPartido.Text = 59 Then
                If LblFecha59_1.Text = "" Or LblFecha59_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado59_1.Text = "" Or TxtResultado59_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha59_1.Text
                ObjMundial.Equipo2 = LblFecha59_2.Text
                ObjMundial.Resultado1 = TxtResultado59_1.Text
                ObjMundial.Resultado2 = TxtResultado59_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado59_1.Text = TxtResultado59_2.Text Then
                    If RadioBtnResultado59_1.Checked = False And RadioBtnResultado59_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha59_1.Text + " o " + LblFecha59_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado59_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha59_1.Text
                    End If
                    If RadioBtnResultado59_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha59_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado59_1.Text > TxtResultado59_2.Text Then
                    ObjMundial.EquipoGana = LblFecha59_1.Text
                Else
                    If TxtResultado59_1.Text < TxtResultado59_2.Text Then
                        ObjMundial.EquipoGana = LblFecha59_2.Text
                    End If
                End If
            End If
            ''Partido 60
            If drlPartido.Text = 60 Then
                If LblFecha60_1.Text = "" Or LblFecha60_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado60_1.Text = "" Or TxtResultado60_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha60_1.Text
                ObjMundial.Equipo2 = LblFecha60_2.Text
                ObjMundial.Resultado1 = TxtResultado60_1.Text
                ObjMundial.Resultado2 = TxtResultado60_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado60_1.Text = TxtResultado60_2.Text Then
                    If RadioBtnResultado60_1.Checked = False And RadioBtnResultado60_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha60_1.Text + " o " + LblFecha60_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado60_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha60_1.Text
                    End If
                    If RadioBtnResultado60_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha60_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado60_1.Text > TxtResultado60_2.Text Then
                    ObjMundial.EquipoGana = LblFecha60_1.Text
                Else
                    If TxtResultado60_1.Text < TxtResultado60_2.Text Then
                        ObjMundial.EquipoGana = LblFecha60_2.Text
                    End If
                End If
            End If
            ''Partido 61
            If drlPartido.Text = 61 Then
                If LblFecha61_1.Text = "" Or LblFecha61_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado61_1.Text = "" Or TxtResultado61_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha61_1.Text
                ObjMundial.Equipo2 = LblFecha61_2.Text
                ObjMundial.Resultado1 = TxtResultado61_1.Text
                ObjMundial.Resultado2 = TxtResultado61_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado61_1.Text = TxtResultado61_2.Text Then
                    If RadioBtnResultado61_1.Checked = False And RadioBtnResultado61_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha61_1.Text + " o " + LblFecha61_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado61_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha61_1.Text
                    End If
                    If RadioBtnResultado61_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha61_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado61_1.Text > TxtResultado61_2.Text Then
                    ObjMundial.EquipoGana = LblFecha61_1.Text
                Else
                    If TxtResultado61_1.Text < TxtResultado61_2.Text Then
                        ObjMundial.EquipoGana = LblFecha61_2.Text
                    End If
                End If
            End If
            ''Partido 62
            If drlPartido.Text = 62 Then
                If LblFecha62_1.Text = "" Or LblFecha62_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado62_1.Text = "" Or TxtResultado62_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha62_1.Text
                ObjMundial.Equipo2 = LblFecha62_2.Text
                ObjMundial.Resultado1 = TxtResultado62_1.Text
                ObjMundial.Resultado2 = TxtResultado62_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado62_1.Text = TxtResultado62_2.Text Then
                    If RadioBtnResultado62_1.Checked = False And RadioBtnResultado62_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha62_1.Text + " o " + LblFecha62_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado62_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha62_1.Text
                    End If
                    If RadioBtnResultado62_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha62_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado62_1.Text > TxtResultado62_2.Text Then
                    ObjMundial.EquipoGana = LblFecha62_1.Text
                Else
                    If TxtResultado62_1.Text < TxtResultado62_2.Text Then
                        ObjMundial.EquipoGana = LblFecha62_2.Text
                    End If
                End If
            End If
            ''Partido 63
            If drlPartido.Text = 63 Then
                If LblFecha63_1.Text = "" Or LblFecha63_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado63_1.Text = "" Or TxtResultado63_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha63_1.Text
                ObjMundial.Equipo2 = LblFecha63_2.Text
                ObjMundial.Resultado1 = TxtResultado63_1.Text
                ObjMundial.Resultado2 = TxtResultado63_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado63_1.Text = TxtResultado63_2.Text Then
                    If RadioBtnResultado63_1.Checked = False And RadioBtnResultado63_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha63_1.Text + " o " + LblFecha63_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado63_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha63_1.Text
                    End If
                    If RadioBtnResultado63_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha63_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado63_1.Text > TxtResultado63_2.Text Then
                    ObjMundial.EquipoGana = LblFecha63_1.Text
                Else
                    If TxtResultado63_1.Text < TxtResultado63_2.Text Then
                        ObjMundial.EquipoGana = LblFecha63_2.Text
                    End If
                End If
            End If
            ''Partido 64
            If drlPartido.Text = 64 Then
                If LblFecha64_1.Text = "" Or LblFecha64_2.Text = "" Then
                    lblmsg.Text = "Aun no se han cargado o no se sabe quienes jugaran este partido"
                    Validacion = True
                    Exit Sub
                End If
                If TxtResultado64_1.Text = "" Or TxtResultado64_2.Text = "" Then
                    lblmsg.Text = "Ingrese los marcadores para el partido: " + drlPartido.Text
                    Validacion = True
                    Exit Sub
                End If
                ObjMundial.Partido_N1 = drlPartido.Text
                ObjMundial.Equipo1 = LblFecha64_1.Text
                ObjMundial.Equipo2 = LblFecha64_2.Text
                ObjMundial.Resultado1 = TxtResultado64_1.Text
                ObjMundial.Resultado2 = TxtResultado64_2.Text
                ''Envio de Equipo que gana
                ''Empate
                If TxtResultado64_1.Text = TxtResultado64_2.Text Then
                    If RadioBtnResultado64_1.Checked = False And RadioBtnResultado64_2.Checked = False Then
                        lblmsg.Text = "Seleccione un equipo que pasaria a la siguiente ronda ya sea " + LblFecha64_1.Text + " o " + LblFecha64_2.Text
                        Validacion = True
                        Exit Sub
                    End If
                    If RadioBtnResultado64_1.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha64_1.Text
                    End If
                    If RadioBtnResultado64_2.Checked = True Then
                        ObjMundial.EquipoGana = LblFecha64_2.Text
                    End If
                End If
                ''Gana alguno
                If TxtResultado64_1.Text > TxtResultado64_2.Text Then
                    ObjMundial.EquipoGana = LblFecha64_1.Text
                Else
                    If TxtResultado64_1.Text < TxtResultado64_2.Text Then
                        ObjMundial.EquipoGana = LblFecha64_2.Text
                    End If
                End If
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Validacion_Limpa_Cajas()
        Try
            ''Partido 49
            If drlPartido.Text = 49 Then
                TxtResultado49_1.Text = ""
                TxtResultado49_2.Text = ""
                RadioBtnResultado49_1.Checked = False
                RadioBtnResultado49_2.Checked = False
            End If
            ''Partido 50
            If drlPartido.Text = 50 Then
                TxtResultado50_1.Text = ""
                TxtResultado50_2.Text = ""
                RadioBtnResultado50_1.Checked = False
                RadioBtnResultado50_2.Checked = False
            End If
            ''Partido 51
            If drlPartido.Text = 51 Then
                TxtResultado51_1.Text = ""
                TxtResultado51_2.Text = ""
                RadioBtnResultado51_1.Checked = False
                RadioBtnResultado51_2.Checked = False
            End If
            ''Partido 52
            If drlPartido.Text = 52 Then
                TxtResultado52_1.Text = ""
                TxtResultado52_2.Text = ""
                RadioBtnResultado52_1.Checked = False
                RadioBtnResultado52_2.Checked = False
            End If
            ''Partido 53
            If drlPartido.Text = 53 Then
                TxtResultado53_1.Text = ""
                TxtResultado53_2.Text = ""
                RadioBtnResultado53_1.Checked = False
                RadioBtnResultado53_2.Checked = False
            End If
            ''Partido 54
            If drlPartido.Text = 54 Then
                TxtResultado54_1.Text = ""
                TxtResultado54_2.Text = ""
                RadioBtnResultado54_1.Checked = False
                RadioBtnResultado54_2.Checked = False
            End If
            ''Partido 55
            If drlPartido.Text = 55 Then
                TxtResultado55_1.Text = ""
                TxtResultado55_2.Text = ""
                RadioBtnResultado55_1.Checked = False
                RadioBtnResultado55_2.Checked = False
            End If
            ''Partido 56
            If drlPartido.Text = 56 Then
                TxtResultado56_1.Text = ""
                TxtResultado56_2.Text = ""
                RadioBtnResultado56_1.Checked = False
                RadioBtnResultado56_2.Checked = False
            End If
            ''Partido 57
            If drlPartido.Text = 57 Then
                TxtResultado57_1.Text = ""
                TxtResultado57_2.Text = ""
                RadioBtnResultado57_1.Checked = False
                RadioBtnResultado57_2.Checked = False
            End If
            ''Partido 58
            If drlPartido.Text = 58 Then
                TxtResultado58_1.Text = ""
                TxtResultado58_2.Text = ""
                RadioBtnResultado58_1.Checked = False
                RadioBtnResultado58_2.Checked = False
            End If
            ''Partido 59
            If drlPartido.Text = 59 Then
                TxtResultado59_1.Text = ""
                TxtResultado59_2.Text = ""
                RadioBtnResultado59_1.Checked = False
                RadioBtnResultado59_2.Checked = False
            End If
            ''Partido 60
            If drlPartido.Text = 60 Then
                TxtResultado60_1.Text = ""
                TxtResultado60_2.Text = ""
                RadioBtnResultado60_1.Checked = False
                RadioBtnResultado60_2.Checked = False
            End If
            ''Partido 61
            If drlPartido.Text = 61 Then
                TxtResultado61_1.Text = ""
                TxtResultado61_2.Text = ""
                RadioBtnResultado61_1.Checked = False
                RadioBtnResultado61_2.Checked = False
            End If
            ''Partido 62
            If drlPartido.Text = 62 Then
                TxtResultado62_1.Text = ""
                TxtResultado62_2.Text = ""
                RadioBtnResultado62_1.Checked = False
                RadioBtnResultado62_2.Checked = False
            End If
            ''Partido 63
            If drlPartido.Text = 63 Then
                TxtResultado63_1.Text = ""
                TxtResultado63_2.Text = ""
                RadioBtnResultado63_1.Checked = False
                RadioBtnResultado63_2.Checked = False
            End If
            ''Partido 64
            If drlPartido.Text = 64 Then
                TxtResultado64_1.Text = ""
                TxtResultado64_2.Text = ""
                RadioBtnResultado64_1.Checked = False
                RadioBtnResultado64_2.Checked = False
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If drlPartido.Text = "- Seleccione -" Then
                lblmsg.Text = "Seleccione un partido y luego si realice el registro"
                Exit Sub
            End If
            ObjMundial.Id_Usuario = lblusuario.Text
            ObjMundial.Letra_Grupo = "S"
            Validacion_Envia_Datos()

            If Validacion = False Then
                ObjMundial.Consulta_Polla_Mundialista_Un_Registro()
                If ObjMundial.Cantidad > 0 Then
                    lblmsg.Text = "Usted ya realizo un registro respecto a este partido " + drlPartido.Text
                    Exit Sub
                End If

                ObjMundial.Ingresar_Resultado_Partido_FaseDos()

                lblmsg.Text = "Resultado ingresado"
                Validacion_Limpa_Cajas()
                drlPartido.Text = "- Seleccione -"
            End If

        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultar_Resultados_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultar_Resultados.Click
        Try
            If drlPartidoConsulta.Text <> "- Seleccione -" Then
                ObjMundial.Partido_N1 = drlPartidoConsulta.Text
            End If
            ObjMundial.Id_Usuario = lblusuario.Text
            dtggeneral.DataSource = ObjMundial.Consulta_Polla_Mundialista_Mi_Resultado()
            dtggeneral.DataBind()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultar_Raiking_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultar_Raiking.Click
        Try
            Consulta_Raiking()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub
End Class