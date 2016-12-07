Public Class BandejaAuditor
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim objBandeja As New clscalidad
            Dim objvalida As New clsgeneral
            If Not IsPostBack Then
                lblusuario.Text = CType(Session("permisos"), clsusuario).usuario
                lblnombreusu.Text = CType(Session("permisos"), clsusuario).nombre
                LblPerfil.Text = CType(Session("permisos"), clsusuario).NomPerfil
                LblSupervisor.Text = CType(Session("permisos"), clsusuario).Superv
                If LblSupervisor.Text = "" Then
                    LblSuperVisorTitulo.Visible = False
                End If
                Consultar()
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
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
    Sub Consultar()
        Dim objBandeja As New clscalidad
        objBandeja.Auditor = lblusuario.Text
        objBandeja.Validacion = "8"
        DtgUsuarios.DataSource = objBandeja.UsuariosBandeja
        DtgUsuarios.DataBind()
        objBandeja.Validacion = "9"
        objBandeja.UsuariosBandeja()
        LblMeta.Text = objBandeja.cantidad
        objBandeja.Validacion = "14"
        objBandeja.UsuariosBandeja()
        lblCasosM.Text = objBandeja.cantidad
        objBandeja.Validacion = "15"
        objBandeja.UsuariosBandeja()
        LblCasosAutomaticos.Text = objBandeja.cantidad
        objBandeja.Validacion = "11"
        DtgCasosAuditar.DataSource = objBandeja.UsuariosBandeja
        DtgCasosAuditar.DataBind()
        objBandeja.Validacion = "12"
        objBandeja.UsuariosBandeja()
        Lblmax.Text = objBandeja.cantidad
        objBandeja.Validacion = "20"
        DtgEstados.DataSource = objBandeja.UsuariosBandeja()
        DtgEstados.DataBind()
        If Integer.Parse(LblMeta.Text) = Integer.Parse(lblCasosM.Text) + Integer.Parse(LblCasosAutomaticos.Text) Then
            BtnConsulta.Visible = False
        Else
            BtnConsulta.Visible = True
        End If
    End Sub
    Dim Total As Integer = 0
    Dim Contador As Integer
    Dim Validacion As Boolean = False
    Dim Valor As Integer
    Protected Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            Dim objBandeja As New clscalidad 'Estancia la clase que contiene variables, funciones y metodos a utilizar
            Dim dts As New DataSet
            Dim Estado As String
            If DtgUsuarios.Rows.Count < 10 Then 'Verifica que hay suficientes ingenieros asignados al auditor 
                lblmsg.Text = "No tiene asignados suficientes ingenieros"
                Exit Sub
            End If
            For Each row As GridViewRow In DtgEstados.Rows   'permite seleccionar filtro de estados 
                Dim isChecked As Boolean = (CType(row.FindControl("chkCtrl"), CheckBox)).Checked
                If isChecked = True Then
                    Validacion = True
                    Estado = row.Cells(0).Text()
                    objBandeja.tipificacion = objBandeja.tipificacion + "'" + Estado + "',"
                End If
            Next
            If Validacion = False Then  'Envia mensaje si no se seleccionaron estados
                lblmsg.Text = "Seleccione almenos un estado para consultar"
                Exit Sub
            End If
            objBandeja.tipificacion = (Left(objBandeja.tipificacion, Len(objBandeja.tipificacion) - 1)) ' quita la ultima coma para que la cadena quede perfecta para consultar
            objBandeja.Auditor = lblusuario.Text ' asigna el usuario el cual es un "auditor"


            objBandeja.Validacion = "11" ' Consulta a ejecutarse
            objBandeja.UsuariosBandeja() ' consulta la cantidad de auditorias asignadas al auditor 

            If objBandeja.cantidad < Integer.Parse(LblMeta.Text) / 3 Then
                Valor = Integer.Parse(LblMeta.Text) / 3 + 1
            Else
                Valor = Integer.Parse(LblMeta.Text)
            End If
            For fila As Integer = 0 To Valor
                If Contador = 3 Then   'condicion del contador 
                    objBandeja.Validacion = "11"  ' consulta a ejecutar
                    objBandeja.UsuariosBandeja() ' consulta la cantidad de auditorias asignadas hoy 

                    If objBandeja.cantidad = 0 Then   'Envia mensaje al usuarios en caso que no hay gestion 
                        lblmsg.Text = "No se encontraron casos para auditar del dia anterior"
                        Exit For
                    End If
                    lblmsg.Text = "Se han asignado " + objBandeja.cantidad + " auditorias"
                    Exit For
                End If
                If fila = DtgUsuarios.Rows.Count Then 'Cuando llega al ultimo ingeniero ingresa a este condicional y aumenta el contador el cual tiene un limite de 3
                    Contador = Contador + 1 'Contador aumenta
                    fila = 0 'Asigna el valor 0 para permitir recorrer nuevamente el dtgusuarios en caso que no se ayan alcanzado la meta en cada barrido 
                End If
                objBandeja.Validacion = "11" ' Consulta a ejecutarse
                objBandeja.UsuariosBandeja() ' consulta la cantidad de auditorias asignadas al auditor 

                If objBandeja.cantidad < Integer.Parse(LblMeta.Text) / 3 Then
                    objBandeja.Validacion = "10"
                Else
                    objBandeja.Validacion = "21"
                End If
                objBandeja.agente = DtgUsuarios.Rows(fila).Cells(2).Text
                dts = objBandeja.UsuariosBandeja()
                For Each row2 As DataRow In dts.Tables(0).Rows
                    objBandeja.caso = row2("idcrm").ToString
                    objBandeja.Id_Caso = row2("idcaso").ToString
                    objBandeja.Campania = row2("bandeja").ToString
                    objBandeja.agente = row2("idusuario").ToString
                    objBandeja.Id_Usuario = lblusuario.Text
                    objBandeja.IngresarAuditoria()
                Next
            Next
            Consultar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub

    Protected Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            Consultar()
        Catch ex As Exception
            lblmsg.Text = "Se produjo error " + ex.Message
        End Try
    End Sub
End Class