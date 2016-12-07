Public Class desprendible
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                Dim objdatos As New clsgeneral
                Dim dt As New DataSet
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                objdatos.idusuario = lblusuario.Text
                objdatos.consultacod()
                lblcod.Text = objdatos.cargo
                With drlperiodo
                    objdatos.idtip = 1
                    .DataSource = objdatos.consultaperiodo
                    .DataTextField = "periodo"
                    .DataValueField = "periodo"
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

    Sub buscarinf()
        Try
            Dim objdatos As New clsrrhh
            If lblcod.Text <> "" Then
                objdatos.idusuario = lblcod.Text
                objdatos.periodo = drlperiodo.SelectedItem.Value
                objdatos.consultanom()
                If objdatos.cantidad > 0 Then
                    lblnombre.Text = objdatos.nombres & objdatos.apellidos
                    lblcargo.Text = objdatos.cargo
                    lbldoc.Text = objdatos.documento
                    lblauxtransp.Text = FormatNumber(objdatos.auxtransp)
                    lblsueldob.Text = FormatNumber(objdatos.salario)
                    lblgastosrep.Text = FormatNumber(objdatos.bonificacion)
                    lbldiastr.Text = objdatos.diastr
                    lbldiasinc.Text = Convert.ToInt32(objdatos.diasinc) + Convert.ToInt32(objdatos.diasincant)
                    lblsueldo.Text = FormatNumber(objdatos.sueldo)
                    lblvac.Text = FormatNumber(objdatos.vacvalor)
                    lblhe.Text = FormatNumber(objdatos.he)
                    lblauxtranspp.Text = FormatNumber(objdatos.auxtranspp)
                    lblgastosrepp.Text = FormatNumber(objdatos.gastosr)
                    lblbonifextra.Text = FormatNumber(objdatos.bonextra)
                    lblintcesant.Text = FormatNumber(objdatos.intces)
                    lblprima.Text = FormatNumber(objdatos.prima)
                    lblviaticos.Text = FormatNumber(objdatos.viaticos)
                    lblcontord.Text = FormatNumber(objdatos.contord)
                    lblcontfes.Text = FormatNumber(objdatos.contfes)
                    lblcontnoc.Text = FormatNumber(objdatos.contnoc)
                    lblreint.Text = FormatNumber(objdatos.reint)
                    lbltotaldev.Text = FormatNumber(Convert.ToInt32(objdatos.sueldo) + Convert.ToInt32(objdatos.vacvalor) + Convert.ToInt32(objdatos.he) + Convert.ToInt32(objdatos.auxtranspp) + Convert.ToInt32(objdatos.gastosr) + Convert.ToInt32(objdatos.bonextra) + Convert.ToInt32(objdatos.intces) + Convert.ToInt32(objdatos.prima) + Convert.ToInt32(objdatos.viaticos) + Convert.ToInt32(objdatos.contord) + Convert.ToInt32(objdatos.contfes) + Convert.ToInt32(objdatos.contnoc) + Convert.ToInt32(objdatos.reint))
                    lbleps.Text = FormatNumber(objdatos.eps)
                    lblpension.Text = FormatNumber(objdatos.pencion)
                    lblups.Text = FormatNumber(objdatos.upc)
                    lblfsp.Text = FormatNumber(objdatos.fps)
                    lblretfte.Text = FormatNumber(objdatos.retfte)
                    lblcafeteria.Text = FormatNumber(objdatos.cafeteria)
                    lblanticipo.Text = FormatNumber(objdatos.anticipo)
                    lblretardo.Text = objdatos.retardo
                    lblvlrretardos.Text = FormatNumber(objdatos.vlrretardo)
                    lblinasist.Text = objdatos.inasistencia
                    lblvlrinasist.Text = FormatNumber(objdatos.vlrinasist)
                    lblotrosdesc.Text = FormatNumber(objdatos.otrosdesc)
                    lbltotalded.Text = FormatNumber(Convert.ToInt32(objdatos.eps) + Convert.ToInt32(objdatos.pencion) + Convert.ToInt32(objdatos.upc) + Convert.ToInt32(objdatos.fps) + Convert.ToInt32(objdatos.retfte) + Convert.ToInt32(objdatos.cafeteria) + Convert.ToInt32(objdatos.anticipo) + Convert.ToInt32(objdatos.vlrretardo) + Convert.ToInt32(objdatos.vlrinasist) + Convert.ToInt32(objdatos.otrosdesc))
                    lbltotalpago.Text = FormatNumber(objdatos.totalpago)
                    lblliquidac.Text = FormatNumber(objdatos.liquidac)
                    lblconsignado.Text = FormatNumber(Convert.ToInt32(objdatos.totalpago) + Convert.ToInt32(objdatos.liquidac))

                    lblmsg.Text = ""
                Else
                    lblnombre.Text = ""
                    lblcargo.Text = ""
                    lbldoc.Text = ""
                    lblauxtransp.Text = ""
                    lblsueldob.Text = ""
                    lblgastosrep.Text = ""
                    lbldiastr.Text = ""
                    lbldiasinc.Text = ""
                    lblsueldo.Text = ""
                    lblvac.Text = ""
                    lblhe.Text = ""
                    lblauxtranspp.Text = ""
                    lblgastosrepp.Text = ""
                    lblbonifextra.Text = ""
                    lblintcesant.Text = ""
                    lblprima.Text = ""
                    lblviaticos.Text = ""
                    lblcontord.Text = ""
                    lblcontfes.Text = ""
                    lblcontnoc.Text = ""
                    lblreint.Text = ""
                    lbltotaldev.Text = ""
                    lbleps.Text = ""
                    lblpension.Text = ""
                    lblups.Text = ""
                    lblfsp.Text = ""
                    lblretfte.Text = ""
                    lblcafeteria.Text = ""
                    lblanticipo.Text = ""
                    lblretardo.Text = ""
                    lblvlrretardos.Text = ""
                    lblinasist.Text = ""
                    lblvlrinasist.Text = ""
                    lblotrosdesc.Text = ""
                    lbltotalded.Text = ""
                    lbltotalpago.Text = ""
                    lblliquidac.Text = ""
                    lblconsignado.Text = ""
                    lblmsg.Text = "No se han encontrado registros coincidentes"
                End If
            Else
                lblmsg.Text = "El usuario no corresponde a un colaborador interno"
            End If
            
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " & ex.Message
        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        buscarinf()
    End Sub
End Class