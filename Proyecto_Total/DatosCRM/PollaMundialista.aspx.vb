Public Class PollaMundialista
    Inherits System.Web.UI.Page
    Dim ObjMundial As New clsCaidaSistema

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                Consulta_Encuentros_Fecha()
                LblFecha_Actual.Text = DateTime.Now.ToString("dd/MM/yyyy")
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

    Public Sub Consulta_Encuentros_Fecha()
        Try
            Dim dts As New DataSet
            dts = ObjMundial.Consulta_Polla_Mundialista_Fecha_Actual()
            ''Partido N1
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Grupo") Is DBNull.Value Then
                    LblGrupo1.Text = ""
                Else
                    LblGrupo1.Text = dts.Tables(0).Rows(0).Item("Grupo")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre") Is DBNull.Value Then
                    LblFecha1.Text = ""
                Else
                    LblFecha1.Text = dts.Tables(0).Rows(0).Item("Nombre")
                End If
                If dts.Tables(0).Rows(1).Item("Nombre") Is DBNull.Value Then
                    LblFecha11.Text = ""
                Else
                    LblFecha11.Text = dts.Tables(0).Rows(1).Item("Nombre")
                End If
                ImgFecha1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha1.Text + ".png"
                ImgFecha11.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha11.Text + ".png"
            End If
            ''Partido N2
            If dts.Tables(0).Rows.Count > 2 Then
                If dts.Tables(0).Rows(2).Item("Grupo") Is DBNull.Value Then
                    LblGrupo2.Text = ""
                Else
                    LblGrupo2.Text = dts.Tables(0).Rows(2).Item("Grupo")
                End If
                If dts.Tables(0).Rows(2).Item("Nombre") Is DBNull.Value Then
                    LblFecha2.Text = ""
                Else
                    LblFecha2.Text = dts.Tables(0).Rows(2).Item("Nombre")
                End If
                If dts.Tables(0).Rows(3).Item("Nombre") Is DBNull.Value Then
                    LblFecha22.Text = ""
                Else
                    LblFecha22.Text = dts.Tables(0).Rows(3).Item("Nombre")
                End If
                ImgFecha2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha2.Text + ".png"
                ImgFecha22.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha22.Text + ".png"
            End If
            ''Partido N3
            If dts.Tables(0).Rows.Count > 4 Then
                If dts.Tables(0).Rows(4).Item("Grupo") Is DBNull.Value Then
                    LblGrupo3.Text = ""
                Else
                    LblGrupo3.Text = dts.Tables(0).Rows(4).Item("Grupo")
                End If
                If dts.Tables(0).Rows(4).Item("Nombre") Is DBNull.Value Then
                    LblFecha3.Text = ""
                Else
                    LblFecha3.Text = dts.Tables(0).Rows(4).Item("Nombre")
                End If
                If dts.Tables(0).Rows(5).Item("Nombre") Is DBNull.Value Then
                    LblFecha33.Text = ""
                Else
                    LblFecha33.Text = dts.Tables(0).Rows(5).Item("Nombre")
                End If
                ImgFecha3.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha3.Text + ".png"
                ImgFecha33.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha33.Text + ".png"
            End If
            ''Partido N4
            If dts.Tables(0).Rows.Count > 6 Then
                If dts.Tables(0).Rows(6).Item("Grupo") Is DBNull.Value Then
                    LblGrupo4.Text = ""
                Else
                    LblGrupo4.Text = dts.Tables(0).Rows(6).Item("Grupo")
                End If
                If dts.Tables(0).Rows(6).Item("Nombre") Is DBNull.Value Then
                    LblFecha4.Text = ""
                Else
                    LblFecha4.Text = dts.Tables(0).Rows(6).Item("Nombre")
                End If
                If dts.Tables(0).Rows(7).Item("Nombre") Is DBNull.Value Then
                    LblFecha4.Text = ""
                Else
                    LblFecha44.Text = dts.Tables(0).Rows(7).Item("Nombre")
                End If
                ImgFecha4.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha4.Text + ".png"
                ImgFecha44.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblFecha44.Text + ".png"
            End If
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnguardar.Click
        Try
            If LblEquipo1.Text = "" Or LblEquipo2.Text = "" Then
                lblmsg.Text = "Consulte un grupo y un partido"
                Exit Sub
            End If
            If TxtResultado1.Text = "" Or TxtResultado2.Text = "" Then
                lblmsg.Text = "Ingrese el resultado del partido"
                Exit Sub
            End If

            ObjMundial.Id_Usuario = lblusuario.Text
            ObjMundial.Letra_Grupo = drlGrupo.Text
            ObjMundial.Partido_N1 = drlPartido.Text
            ObjMundial.Equipo1 = LblEquipo1.Text
            ObjMundial.Equipo2 = LblEquipo2.Text
            ObjMundial.Resultado1 = TxtResultado1.Text
            ObjMundial.Resultado2 = TxtResultado2.Text

            ObjMundial.Consulta_Polla_Mundialista_Un_Registro()
            If ObjMundial.Cantidad > 0 Then
                lblmsg.Text = "Usted ya realizo un registro respecto a este partido"
                Exit Sub
            End If

            ObjMundial.Ingresar_Resultado_Partido()

            lblmsg.Text = "Resultado ingresado"

            drlGrupo.Text = "- Seleccione -"
            drlPartido.Text = "- Seleccione -"
            LblEquipo1.Text = ""
            LblEquipo2.Text = ""
            TxtResultado1.Text = ""
            TxtResultado2.Text = ""
            ImgEquipo1.ImageUrl = Nothing
            ImgEquipo2.ImageUrl = Nothing
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Public Sub Consulta_Grupo_partido()
        Try
            If drlGrupo.Text <> "- Seleccione -" Then
                ObjMundial.Letra_Grupo = drlGrupo.Text
            Else
                lblmsg.Text = "Seleccione un grupo"
                Exit Sub
            End If
            If drlPartido.Text <> "- Seleccione -" Then
                ObjMundial.Partido_N1 = drlPartido.Text
            Else
                lblmsg.Text = "Seleccione un partido"
                Exit Sub
            End If
            Dim dts As New DataSet
            dts = ObjMundial.Consulta_Polla_Mundialista_Grupo_Partido()

            If dts.Tables(0).Rows(0).Item("Nombre") Is DBNull.Value Then
                LblEquipo1.Text = ""
            Else
                LblEquipo1.Text = dts.Tables(0).Rows(0).Item("Nombre")
                If drlPartido.Text = "4" Or drlPartido.Text = "5" Then
                    LblEquipo1.Text = dts.Tables(0).Rows(1).Item("Nombre")
                End If
            End If
            If dts.Tables(0).Rows(1).Item("Nombre") Is DBNull.Value Then
                LblEquipo2.Text = ""
            Else
                LblEquipo2.Text = dts.Tables(0).Rows(1).Item("Nombre")
                If drlPartido.Text = "4" Or drlPartido.Text = "5" Then
                    LblEquipo2.Text = dts.Tables(0).Rows(0).Item("Nombre")
                End If
            End If
            ImgEquipo1.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblEquipo1.Text + ".png"
            ImgEquipo2.ImageUrl = "~/Css2/Imagenes_Mundial/" + LblEquipo2.Text + ".png"
            lblmsg.Text = ""
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub drlPartido_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles drlPartido.SelectedIndexChanged
        Try
            Consulta_Grupo_partido()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsulta.Click
        Try
            Consulta_Grupo_partido()
        Catch ex As Exception
            lblmsg.Text = "Se presento error: " + ex.Message
        End Try
    End Sub

    Protected Sub BtnConsultar_Resultados_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnConsultar_Resultados.Click
        Try
            If drlGrupoConsulta.Text <> "- Seleccione -" Then
                ObjMundial.Letra_Grupo = drlGrupoConsulta.Text
            End If
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
End Class