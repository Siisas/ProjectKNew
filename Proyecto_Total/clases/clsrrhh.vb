Imports System.Data.OleDb
Public Class clsrrhh
    Protected strldocumento As String
    Protected strlnombres As String
    Protected strlapellidos As String
    Protected strlcodigo As String
    Protected strleps As String
    Protected strlfps As String
    Protected strldireccion As String
    Protected strltelefono As String
    Protected strlfcnac As String
    Protected strlemail As String
    Protected strlgenero As String
    Protected strlestadocivil As String
    Protected strlhijos As String
    Protected strlcuenta As String
    Protected strlrh As String
    Protected strldeporte As String
    Protected strlescolaridad As String
    Protected strlprofesion As String
    Protected strlestudia As String
    Protected strlobs As String
    Protected strlcargo As String
    Protected strlproyecto As String
    Protected strlarea As String
    Protected strltipocont As String
    Protected strlsalario As String
    Protected strlbonificacion As String
    Protected strlfcing As String
    Protected strlestado As String
    Protected strlfcretiro As String
    Protected strlidusuario As String
    Protected strlfcregistro As String
    Protected intcantidad As Integer
    Protected strlrutafoto As String
    Protected strlactualizacion As String
    Protected strldescripcionac As String
    Protected strlrutahv As String
    Protected strltipodoc As String
    Protected strlperiodo As String
    Protected strlauxtransp As String
    Protected strldiastr As String
    Protected strldiasinc As String
    Protected strldiasincant As String
    Protected strlsueldo As String
    Protected strlvacvalor As String
    Protected strlhe As String
    Protected strlauxtranspp As String
    Protected strldevengado As String
    Protected strlgastosr As String
    Protected strlbonextra As String
    Protected strlintces As String
    Protected strlprima As String
    Protected strlviaticos As String
    Protected strlcontord As String
    Protected strlcontfes As String
    Protected strlcontnoc As String
    Protected strlreint As String
    Protected strlupc As String
    Protected strlfsp As String
    Protected strlcafeteria As String
    Protected strlretfte As String
    Protected strlanticipo As String
    Protected strlretardo As String
    Protected strlvlrretardo As String
    Protected strlinasistencia As String
    Protected strlvlrinasist As String
    Protected strlotrosdesc As String
    Protected strltotalpago As String
    Protected strlliquidac As String
    Protected strlpencion As String
    Protected strlfcnovedad As String
    Protected strltiponov As String
    Protected strldianov As String
    Protected strlhoranov As String
    Protected strlrepone As String
    Protected strlreporta As String
    Protected strltipificacion As String
    Protected strlid As String
    Protected strlturno As String
    Protected strlempresa As String
    Protected strlcarne As String
    Protected strlchaleco As String
    Protected strldiadema As String
    Protected strllocker As String
    Protected strluniforme As String
    Protected strlgrupo As String
    Protected strlmesreporte As String
    Protected strlfcini As String
    Protected strlfcfin As String
    Protected strlIPEntrada As String
    Protected strlIPSalida As String
    Protected strlComp_Mejora As String
    Protected strlCod_Archivo As Integer
    Protected _Validacion As String
    Protected _Version As String
    Protected _Observacion As String
    Protected strlCod_Diagnostico As String
    Protected strlUbicacion As String
    Protected strlAprobacion As String
    Protected strlFc_Aprueba As String
    Dim DteXCEL As New DataTable ''Malla de turno
    Dim fecha As DateTime = Now ''Malla de turno
    Protected _Fc_ruta As String ''Malla de turno
    Protected _Tipo_Horario As String
    Protected _Cargo_Cliente As String
    Protected _Segmento As String

    Public Property Segmento As String
        Get
            Return _Segmento
        End Get
        Set(ByVal value As String)
            _Segmento = value
        End Set
    End Property
    Public Property Cargo_Cliente As String
        Get
            Return _Cargo_Cliente
        End Get
        Set(ByVal value As String)
            _Cargo_Cliente = value
        End Set
    End Property
    Public Property Tipo_Horario As String
        Get
            Return _Tipo_Horario
        End Get
        Set(ByVal value As String)
            _Tipo_Horario = value
        End Set
    End Property
    Public Property Fc_ruta As String
        Get
            Return _Fc_ruta
        End Get
        Set(ByVal value As String)
            _Fc_ruta = value
        End Set
    End Property
    Public Property Fc_Dtecxel As DataTable
        Get
            Return DteXCEL
        End Get
        Set(ByVal value As DataTable)
            DteXCEL = value
        End Set
    End Property
    Public Property Fc_Aprueba As String
        Get
            Return strlFc_Aprueba
        End Get
        Set(ByVal value As String)
            strlFc_Aprueba = value
        End Set
    End Property

    Public Property Aprobacion As String
        Get
            Return strlAprobacion
        End Get
        Set(ByVal value As String)
            strlAprobacion = value
        End Set
    End Property


    Public Property Ubicacion As String
        Get
            Return strlUbicacion
        End Get
        Set(ByVal value As String)
            strlUbicacion = value
        End Set
    End Property


    Public Property Cod_Diagnostico() As String
        Get
            Return strlCod_Diagnostico
        End Get
        Set(ByVal Value As String)
            strlCod_Diagnostico = Value
        End Set
    End Property


    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property
    Public Property Version As String
        Get
            Return _Version
        End Get
        Set(ByVal value As String)
            _Version = value
        End Set
    End Property
    Public Property Validacion As String
        Get
            Return _Validacion
        End Get
        Set(ByVal value As String)
            _Validacion = value
        End Set
    End Property

    Public Property Cod_Archivo As Integer
        Get
            Return strlCod_Archivo
        End Get
        Set(ByVal value As Integer)
            strlCod_Archivo = value
        End Set
    End Property
    Public Property Comp_Mejora() As String
        Get
            Return strlComp_Mejora
        End Get
        Set(ByVal Value As String)
            strlComp_Mejora = Value
        End Set
    End Property

    Public Property IPSalida As String
        Get
            Return strlIPSalida
        End Get
        Set(ByVal value As String)
            strlIPSalida = value
        End Set
    End Property
    Public Property IPEntrada As String
        Get
            Return strlIPEntrada
        End Get
        Set(ByVal value As String)
            strlIPEntrada = value
        End Set
    End Property
    Public Property fcfin() As String
        Get
            Return strlfcfin
        End Get
        Set(ByVal value As String)
            strlfcfin = value
        End Set
    End Property
    Public Property fcini() As String
        Get
            Return strlfcini
        End Get
        Set(ByVal value As String)
            strlfcini = value
        End Set
    End Property
    Public Property mesreporte() As String
        Get
            Return strlmesreporte
        End Get
        Set(ByVal value As String)
            strlmesreporte = value
        End Set
    End Property
    Public Property grupo() As String
        Get
            Return strlgrupo
        End Get
        Set(ByVal value As String)
            strlgrupo = value
        End Set
    End Property
    Public Property uniforme() As String
        Get
            Return strluniforme
        End Get
        Set(ByVal value As String)
            strluniforme = value
        End Set
    End Property
    Public Property locker() As String
        Get
            Return strllocker
        End Get
        Set(ByVal value As String)
            strllocker = value
        End Set
    End Property
    Public Property diadema() As String
        Get
            Return strldiadema
        End Get
        Set(ByVal value As String)
            strldiadema = value
        End Set
    End Property
    Public Property chaleco() As String
        Get
            Return strlchaleco
        End Get
        Set(ByVal value As String)
            strlchaleco = value
        End Set
    End Property
    Public Property carne() As String
        Get
            Return strlcarne
        End Get
        Set(ByVal value As String)
            strlcarne = value
        End Set
    End Property
    Public Property empresa() As String
        Get
            Return strlempresa
        End Get
        Set(ByVal value As String)
            strlempresa = value
        End Set
    End Property
    Public Property turno() As String
        Get
            Return strlturno
        End Get
        Set(ByVal value As String)
            strlturno = value
        End Set
    End Property
    Public Property id() As String
        Get
            Return strlid
        End Get
        Set(ByVal value As String)
            strlid = value
        End Set
    End Property
    Public Property tipificacion() As String
        Get
            Return strltipificacion
        End Get
        Set(ByVal value As String)
            strltipificacion = value
        End Set
    End Property
    Public Property reporta() As String
        Get
            Return strlreporta
        End Get
        Set(ByVal value As String)
            strlreporta = value
        End Set
    End Property
    Public Property repone() As String
        Get
            Return strlrepone
        End Get
        Set(ByVal value As String)
            strlrepone = value
        End Set
    End Property
    Public Property horanov() As String
        Get
            Return strlhoranov
        End Get
        Set(ByVal value As String)
            strlhoranov = value
        End Set
    End Property
    Public Property dianov() As String
        Get
            Return strldianov
        End Get
        Set(ByVal value As String)
            strldianov = value
        End Set
    End Property
    Public Property tiponov() As String
        Get
            Return strltiponov
        End Get
        Set(ByVal value As String)
            strltiponov = value
        End Set
    End Property
    Public Property fcnovedad() As String
        Get
            Return strlfcnovedad
        End Get
        Set(ByVal value As String)
            strlfcnovedad = value
        End Set
    End Property
    Public Property pencion() As String
        Get
            Return strlpencion
        End Get
        Set(ByVal value As String)
            strlpencion = value
        End Set
    End Property
    Public Property liquidac() As String
        Get
            Return strlliquidac
        End Get
        Set(ByVal value As String)
            strlliquidac = value
        End Set
    End Property
    Public Property totalpago() As String
        Get
            Return strltotalpago
        End Get
        Set(ByVal value As String)
            strltotalpago = value
        End Set
    End Property
    Public Property otrosdesc() As String
        Get
            Return strlotrosdesc
        End Get
        Set(ByVal value As String)
            strlotrosdesc = value
        End Set
    End Property
    Public Property vlrinasist() As String
        Get
            Return strlvlrinasist
        End Get
        Set(ByVal value As String)
            strlvlrinasist = value
        End Set
    End Property
    Public Property inasistencia() As String
        Get
            Return strlinasistencia
        End Get
        Set(ByVal value As String)
            strlinasistencia = value
        End Set
    End Property
    Public Property vlrretardo() As String
        Get
            Return strlvlrretardo
        End Get
        Set(ByVal value As String)
            strlvlrretardo = value
        End Set
    End Property
    Public Property retardo() As String
        Get
            Return strlretardo
        End Get
        Set(ByVal value As String)
            strlretardo = value
        End Set
    End Property
    Public Property anticipo() As String
        Get
            Return strlanticipo
        End Get
        Set(ByVal value As String)
            strlanticipo = value
        End Set
    End Property
    Public Property retfte() As String
        Get
            Return strlretfte
        End Get
        Set(ByVal value As String)
            strlretfte = value
        End Set
    End Property
    Public Property cafeteria() As String
        Get
            Return strlcafeteria
        End Get
        Set(ByVal value As String)
            strlcafeteria = value
        End Set
    End Property
    Public Property upc() As String
        Get
            Return strlupc
        End Get
        Set(ByVal value As String)
            strlupc = value
        End Set
    End Property
    Public Property reint() As String
        Get
            Return strlreint
        End Get
        Set(ByVal value As String)
            strlreint = value
        End Set
    End Property
    Public Property contnoc() As String
        Get
            Return strlcontnoc
        End Get
        Set(ByVal value As String)
            strlcontnoc = value
        End Set
    End Property
    Public Property contfes() As String
        Get
            Return strlcontfes
        End Get
        Set(ByVal value As String)
            strlcontfes = value
        End Set
    End Property
    Public Property contord() As String
        Get
            Return strlcontord
        End Get
        Set(ByVal value As String)
            strlcontord = value
        End Set
    End Property
    Public Property viaticos() As String
        Get
            Return strlviaticos
        End Get
        Set(ByVal value As String)
            strlviaticos = value
        End Set
    End Property
    Public Property prima() As String
        Get
            Return strlprima
        End Get
        Set(ByVal value As String)
            strlprima = value
        End Set
    End Property
    Public Property intces() As String
        Get
            Return strlintces
        End Get
        Set(ByVal value As String)
            strlintces = value
        End Set
    End Property
    Public Property bonextra() As String
        Get
            Return strlbonextra
        End Get
        Set(ByVal value As String)
            strlbonextra = value
        End Set
    End Property
    Public Property gastosr() As String
        Get
            Return strlgastosr
        End Get
        Set(ByVal value As String)
            strlgastosr = value
        End Set
    End Property
    Public Property devengado() As String
        Get
            Return strldevengado
        End Get
        Set(ByVal value As String)
            strldevengado = value
        End Set
    End Property
    Public Property auxtranspp() As String
        Get
            Return strlauxtranspp
        End Get
        Set(ByVal value As String)
            strlauxtranspp = value
        End Set
    End Property
    Public Property he() As String
        Get
            Return strlhe
        End Get
        Set(ByVal value As String)
            strlhe = value
        End Set
    End Property
    Public Property vacvalor() As String
        Get
            Return strlvacvalor
        End Get
        Set(ByVal value As String)
            strlvacvalor = value
        End Set
    End Property
    Public Property sueldo() As String
        Get
            Return strlsueldo
        End Get
        Set(ByVal value As String)
            strlsueldo = value
        End Set
    End Property
    Public Property diasincant() As String
        Get
            Return strldiasincant
        End Get
        Set(ByVal value As String)
            strldiasincant = value
        End Set
    End Property
    Public Property diasinc() As String
        Get
            Return strldiasinc
        End Get
        Set(ByVal value As String)
            strldiasinc = value
        End Set
    End Property
    Public Property diastr() As String
        Get
            Return strldiastr
        End Get
        Set(ByVal value As String)
            strldiastr = value
        End Set
    End Property
    Public Property auxtransp() As String
        Get
            Return strlauxtransp
        End Get
        Set(ByVal value As String)
            strlauxtransp = value
        End Set
    End Property
    Public Property periodo() As String
        Get
            Return strlperiodo
        End Get
        Set(ByVal value As String)
            strlperiodo = value
        End Set
    End Property
    Public Property tipodoc() As String
        Get
            Return strltipodoc
        End Get
        Set(ByVal value As String)
            strltipodoc = value
        End Set
    End Property
    Public Property rutahv() As String
        Get
            Return strlrutahv
        End Get
        Set(ByVal value As String)
            strlrutahv = value
        End Set
    End Property
    Public Property descripcionac() As String
        Get
            Return strldescripcionac
        End Get
        Set(ByVal value As String)
            strldescripcionac = value
        End Set
    End Property
    Public Property actualizacion() As String
        Get
            Return strlactualizacion
        End Get
        Set(ByVal value As String)
            strlactualizacion = value
        End Set
    End Property
    Public Property rutafoto() As String
        Get
            Return strlrutafoto
        End Get
        Set(ByVal value As String)
            strlrutafoto = value
        End Set
    End Property
    Public Property cantidad() As Integer
        Get
            Return intcantidad
        End Get
        Set(ByVal value As Integer)
            intcantidad = value
        End Set
    End Property
    Public Property fcregistro() As String
        Get
            Return strlfcregistro
        End Get
        Set(ByVal value As String)
            strlfcregistro = value
        End Set
    End Property
    Public Property idusuario() As String
        Get
            Return strlidusuario
        End Get
        Set(ByVal value As String)
            strlidusuario = value
        End Set
    End Property
    Public Property fcretiro() As String
        Get
            Return strlfcretiro
        End Get
        Set(ByVal value As String)
            strlfcretiro = value
        End Set
    End Property
    Public Property estado() As String
        Get
            Return strlestado
        End Get
        Set(ByVal value As String)
            strlestado = value
        End Set
    End Property
    Public Property fcing() As String
        Get
            Return strlfcing
        End Get
        Set(ByVal value As String)
            strlfcing = value
        End Set
    End Property
    Public Property bonificacion() As String
        Get
            Return strlbonificacion
        End Get
        Set(ByVal value As String)
            strlbonificacion = value
        End Set
    End Property
    Public Property salario() As String
        Get
            Return strlsalario
        End Get
        Set(ByVal value As String)
            strlsalario = value
        End Set
    End Property
    Public Property tipocont() As String
        Get
            Return strltipocont
        End Get
        Set(ByVal value As String)
            strltipocont = value
        End Set
    End Property
    Public Property area() As String
        Get
            Return strlarea
        End Get
        Set(ByVal value As String)
            strlarea = value
        End Set
    End Property
    Public Property proyecto() As String
        Get
            Return strlproyecto
        End Get
        Set(ByVal value As String)
            strlproyecto = value
        End Set
    End Property
    Public Property cargo() As String
        Get
            Return strlcargo
        End Get
        Set(ByVal value As String)
            strlcargo = value
        End Set
    End Property
    Public Property obs() As String
        Get
            Return strlobs
        End Get
        Set(ByVal value As String)
            strlobs = value
        End Set
    End Property
    Public Property estudia() As String
        Get
            Return strlestudia
        End Get
        Set(ByVal value As String)
            strlestudia = value
        End Set
    End Property
    Public Property profesion() As String
        Get
            Return strlprofesion
        End Get
        Set(ByVal value As String)
            strlprofesion = value
        End Set
    End Property
    Public Property escolaridad() As String
        Get
            Return strlescolaridad
        End Get
        Set(ByVal value As String)
            strlescolaridad = value
        End Set
    End Property
    Public Property deporte() As String
        Get
            Return strldeporte
        End Get
        Set(ByVal value As String)
            strldeporte = value
        End Set
    End Property
    Public Property rh() As String
        Get
            Return strlrh
        End Get
        Set(ByVal value As String)
            strlrh = value
        End Set
    End Property
    Public Property cuenta() As String
        Get
            Return strlcuenta
        End Get
        Set(ByVal value As String)
            strlcuenta = value
        End Set
    End Property
    Public Property hijos() As String
        Get
            Return strlhijos
        End Get
        Set(ByVal value As String)
            strlhijos = value
        End Set
    End Property
    Public Property estadocivil() As String
        Get
            Return strlestadocivil
        End Get
        Set(ByVal value As String)
            strlestadocivil = value
        End Set
    End Property
    Public Property genero() As String
        Get
            Return strlgenero
        End Get
        Set(ByVal value As String)
            strlgenero = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return strlemail
        End Get
        Set(ByVal value As String)
            strlemail = value
        End Set
    End Property
    Public Property fcnac() As String
        Get
            Return strlfcnac
        End Get
        Set(ByVal value As String)
            strlfcnac = value
        End Set
    End Property
    Public Property telefono() As String
        Get
            Return strltelefono
        End Get
        Set(ByVal value As String)
            strltelefono = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return strldireccion
        End Get
        Set(ByVal value As String)
            strldireccion = value
        End Set
    End Property
    Public Property fps() As String
        Get
            Return strlfps
        End Get
        Set(ByVal value As String)
            strlfps = value
        End Set
    End Property
    Public Property eps() As String
        Get
            Return strleps
        End Get
        Set(ByVal value As String)
            strleps = value
        End Set
    End Property
    Public Property codigo() As String
        Get
            Return strlcodigo
        End Get
        Set(ByVal value As String)
            strlcodigo = value
        End Set
    End Property
    Public Property apellidos() As String
        Get
            Return strlapellidos
        End Get
        Set(ByVal value As String)
            strlapellidos = value
        End Set
    End Property
    Public Property nombres() As String
        Get
            Return strlnombres
        End Get
        Set(ByVal value As String)
            strlnombres = value
        End Set
    End Property
    Public Property documento() As String
        Get
            Return strldocumento
        End Get
        Set(ByVal value As String)
            strldocumento = value
        End Set
    End Property
    Protected _Fecha_Acta As Date
    Public Property Fecha_Acta() As Date
        Get
            Return _Fecha_Acta
        End Get
        Set(ByVal value As Date)
            _Fecha_Acta = value
        End Set
    End Property


  
  
    Public Sub registrohistorico()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "INSERT INTO historico(documento,idactualizacion,descripcionact,idusuario,fcregistro) values(@strldocumento,@strlactualizacion,@strldescripcionac,@strlidusuario,@strlfcregistro)"
            If strlComp_Mejora <> Nothing Then
                cms.CommandText = "INSERT INTO historico(documento,idactualizacion,descripcionact,idusuario,fcregistro,Comp_Mejora) values(@strldocumento,@strlactualizacion,@strldescripcionac,@strlidusuario,@strlfcregistro,@strlComp_Mejora)"
                cms.Parameters.Add("@strlComp_Mejora", SqlDbType.VarChar, 100).Value = strlComp_Mejora
            End If
            cms.Parameters.Add("@strldocumento", SqlDbType.VarChar, 50).Value = strldocumento
            cms.Parameters.Add("@strlactualizacion", SqlDbType.Int).Value = strlactualizacion
            cms.Parameters.Add("@strldescripcionac", SqlDbType.VarChar).Value = strldescripcionac
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function consultapersonal() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = ""
        Try
            cn.Open()
            If Me.documento <> Nothing Then
                WHERE = " WHERE documento=@strldocumento "
                cms.Parameters.Add("@strldocumento", SqlDbType.VarChar, 50).Value = Me.strldocumento
            ElseIf Me.strlcodigo <> Nothing And WHERE = "" Then
                WHERE = " WHERE codigo=@strlcodigo "
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            Else
                If Me.strlnombres <> Nothing And WHERE = "" Then
                    WHERE = " WHERE nombres like '%'+@strlnombres+'%' "
                    cms.Parameters.Add("@strlnombres", SqlDbType.VarChar, 50).Value = Me.strlnombres
                End If
                If Me.strlapellidos <> Nothing And WHERE = "" Then
                    WHERE = " WHERE apellidos like '%'+@strlapellidos+'%' "
                    cms.Parameters.Add("@strlapellidos", SqlDbType.VarChar, 50).Value = Me.strlapellidos
                ElseIf Me.strlapellidos <> Nothing Then
                    WHERE = WHERE & " And apellidos like '%'+@strlapellidos+'%' "
                    cms.Parameters.Add("@strlapellidos", SqlDbType.VarChar, 50).Value = Me.strlapellidos
                End If
                If Me.strlestado <> Nothing And WHERE = "" Then
                    WHERE = " WHERE estado=@strlestado "
                    cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 50).Value = Me.strlestado
                ElseIf Me.strlestado <> Nothing Then
                    WHERE = WHERE & " And estado=@strlestado "
                    cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 50).Value = Me.strlestado
                End If
                If Me.strlarea <> Nothing And WHERE = "" Then
                    WHERE = " WHERE idarea=@strlarea "
                    cms.Parameters.Add("@strlarea", SqlDbType.VarChar, 50).Value = Me.strlarea
                ElseIf Me.strlarea <> Nothing Then
                    WHERE = WHERE & " And idarea=@strlarea "
                    cms.Parameters.Add("@strlarea", SqlDbType.VarChar, 50).Value = Me.strlarea
                End If
            End If
            cms.CommandText = "SELECT * from admin_cham.dbo.Cons_personal " & WHERE
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultahistorico() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strldocumento <> Nothing Then
                cms.CommandText = "SELECT * from Cons_historico where documento=@strldocumento"
                cms.Parameters.Add("@strldocumento", SqlDbType.VarChar, 50).Value = Me.strldocumento
            End If
            If strlcodigo <> Nothing Then
                cms.CommandText = "SELECT * from Cons_historico where codigo=@strlcodigo"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub registrocheck()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "INSERT INTO detallecheck(iddocumento,idtipodoc,rutadoc,idusuario,fcregistro) values(@strldocumento,@strltipodoc,@strlrutafoto,@strlidusuario,@strlfcregistro)"
            cms.Parameters.Add("@strldocumento", SqlDbType.VarChar, 50).Value = strldocumento
            cms.Parameters.Add("@strltipodoc", SqlDbType.Int).Value = strltipodoc
            cms.Parameters.Add("@strlrutafoto", SqlDbType.VarChar, 255).Value = strlrutafoto
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function consultacheck() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strldocumento <> Nothing Then
                cms.CommandText = "SELECT * from Cons_check where iddocumento=@strldocumento"
                cms.Parameters.Add("@strldocumento", SqlDbType.VarChar, 50).Value = Me.strldocumento
            End If
            If strlcodigo <> Nothing Then
                cms.CommandText = "SELECT * from Cons_check where codigo=@strlcodigo"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            End If

            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultanom() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT * FROM consnom where codigo=@strlidusuario and periodo=@strlperiodo"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
                cms.Parameters.Add("@strlperiodo", SqlDbType.VarChar, 50).Value = Me.strlperiodo
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            intcantidad = dtsrecepcion.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("codigo") Is System.DBNull.Value Then
                    strlcodigo = " "
                Else
                    strlcodigo = dtsrecepcion.Tables(0).Rows(0).Item("codigo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombres") Is System.DBNull.Value Then
                    strlnombres = " "
                Else
                    strlnombres = dtsrecepcion.Tables(0).Rows(0).Item("nombres")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apellidos") Is System.DBNull.Value Then
                    strlapellidos = " "
                Else
                    strlapellidos = dtsrecepcion.Tables(0).Rows(0).Item("apellidos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cargo") Is System.DBNull.Value Then
                    strlcargo = " "
                Else
                    strlcargo = dtsrecepcion.Tables(0).Rows(0).Item("cargo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("documento") Is System.DBNull.Value Then
                    strldocumento = " "
                Else
                    strldocumento = dtsrecepcion.Tables(0).Rows(0).Item("documento")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("salario") Is System.DBNull.Value Then
                    strlsalario = "0"
                Else
                    strlsalario = dtsrecepcion.Tables(0).Rows(0).Item("salario")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("bonificacion") Is System.DBNull.Value Then
                    strlbonificacion = "0"
                Else
                    strlbonificacion = dtsrecepcion.Tables(0).Rows(0).Item("bonificacion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("auxtransp") Is System.DBNull.Value Then
                    strlauxtransp = "0"
                Else
                    strlauxtransp = dtsrecepcion.Tables(0).Rows(0).Item("auxtransp")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("diasconincap") Is System.DBNull.Value Then
                    strldiastr = "0"
                Else
                    strldiastr = dtsrecepcion.Tables(0).Rows(0).Item("diasconincap")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("incapacmesant") Is System.DBNull.Value Then
                    strldiasincant = "0"
                Else
                    strldiasincant = dtsrecepcion.Tables(0).Rows(0).Item("incapacmesant")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("incapacmes") Is System.DBNull.Value Then
                    strldiasinc = "0"
                Else
                    strldiasinc = dtsrecepcion.Tables(0).Rows(0).Item("incapacmes")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("sueldo") Is System.DBNull.Value Then
                    strlsueldo = "0"
                Else
                    strlsueldo = dtsrecepcion.Tables(0).Rows(0).Item("sueldo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("vacvalor") Is System.DBNull.Value Then
                    strlvacvalor = "0"
                Else
                    strlvacvalor = dtsrecepcion.Tables(0).Rows(0).Item("vacvalor")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("totalrecargoshe") Is System.DBNull.Value Then
                    strlhe = "0"
                Else
                    strlhe = dtsrecepcion.Tables(0).Rows(0).Item("totalrecargoshe")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("auxiliotransp") Is System.DBNull.Value Then
                    strlauxtranspp = "0"
                Else
                    strlauxtranspp = dtsrecepcion.Tables(0).Rows(0).Item("auxiliotransp")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("totalsalario") Is System.DBNull.Value Then
                    strldevengado = "0"
                Else
                    strldevengado = dtsrecepcion.Tables(0).Rows(0).Item("totalsalario")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("gastorepres") Is System.DBNull.Value Then
                    strlgastosr = "0"
                Else
                    strlgastosr = dtsrecepcion.Tables(0).Rows(0).Item("gastorepres")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("bonifextralegal") Is System.DBNull.Value Then
                    strlbonextra = "0"
                Else
                    strlbonextra = dtsrecepcion.Tables(0).Rows(0).Item("bonifextralegal")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("intcesant") Is System.DBNull.Value Then
                    strlintces = "0"
                Else
                    strlintces = dtsrecepcion.Tables(0).Rows(0).Item("intcesant")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("prima") Is System.DBNull.Value Then
                    strlprima = "0"
                Else
                    strlprima = dtsrecepcion.Tables(0).Rows(0).Item("prima")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("vlrviaticos") Is System.DBNull.Value Then
                    strlviaticos = "0"
                Else
                    strlviaticos = dtsrecepcion.Tables(0).Rows(0).Item("vlrviaticos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("viaticosfest") Is System.DBNull.Value Then
                    strlcontfes = "0"
                Else
                    strlcontfes = dtsrecepcion.Tables(0).Rows(0).Item("viaticosfest")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("viaticosord") Is System.DBNull.Value Then
                    strlcontord = "0"
                Else
                    strlcontord = dtsrecepcion.Tables(0).Rows(0).Item("viaticosord")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("viaticosnoct") Is System.DBNull.Value Then
                    strlcontnoc = "0"
                Else
                    strlcontnoc = dtsrecepcion.Tables(0).Rows(0).Item("viaticosnoct")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("bonifyreint") Is System.DBNull.Value Then
                    strlreint = "0"
                Else
                    strlreint = dtsrecepcion.Tables(0).Rows(0).Item("bonifyreint")
                End If
                'descuentos
                If dtsrecepcion.Tables(0).Rows(0).Item("valoreps") Is System.DBNull.Value Then
                    strleps = "0"
                Else
                    strleps = dtsrecepcion.Tables(0).Rows(0).Item("valoreps")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("vlrpension") Is System.DBNull.Value Then
                    strlpencion = "0"
                Else
                    strlpencion = dtsrecepcion.Tables(0).Rows(0).Item("vlrpension")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("upc") Is System.DBNull.Value Then
                    strlupc = "0"
                Else
                    strlupc = dtsrecepcion.Tables(0).Rows(0).Item("upc")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fps") Is System.DBNull.Value Then
                    strlfps = "0"
                Else
                    strlfps = dtsrecepcion.Tables(0).Rows(0).Item("fps")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("desccafet") Is System.DBNull.Value Then
                    strlcafeteria = "0"
                Else
                    strlcafeteria = dtsrecepcion.Tables(0).Rows(0).Item("desccafet")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("retfte") Is System.DBNull.Value Then
                    strlretfte = "0"
                Else
                    strlretfte = dtsrecepcion.Tables(0).Rows(0).Item("retfte")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("anticnom") Is System.DBNull.Value Then
                    strlanticipo = "0"
                Else
                    strlanticipo = dtsrecepcion.Tables(0).Rows(0).Item("anticnom")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("retardos") Is System.DBNull.Value Then
                    strlretardo = "0"
                Else
                    strlretardo = dtsrecepcion.Tables(0).Rows(0).Item("retardos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("otrosretard") Is System.DBNull.Value Then
                    strlvlrretardo = "0"
                Else
                    strlvlrretardo = dtsrecepcion.Tables(0).Rows(0).Item("otrosretard")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("inasistencia") Is System.DBNull.Value Then
                    strlinasistencia = "0"
                Else
                    strlinasistencia = dtsrecepcion.Tables(0).Rows(0).Item("inasistencia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("vlrinasistencia") Is System.DBNull.Value Then
                    strlvlrinasist = "0"
                Else
                    strlvlrinasist = dtsrecepcion.Tables(0).Rows(0).Item("vlrinasistencia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("otrosdescuentos") Is System.DBNull.Value Then
                    strlotrosdesc = "0"
                Else
                    strlotrosdesc = dtsrecepcion.Tables(0).Rows(0).Item("otrosdescuentos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("salariotot") Is System.DBNull.Value Then
                    strltotalpago = "0"
                Else
                    strltotalpago = dtsrecepcion.Tables(0).Rows(0).Item("salariotot")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("liquidacion") Is System.DBNull.Value Then
                    strlliquidac = "0"
                Else
                    strlliquidac = dtsrecepcion.Tables(0).Rows(0).Item("liquidacion")
                End If
            End If
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultanombre() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT nombres, apellidos, documento FROM personal where codigo=@strlidusuario"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            intcantidad = dtsrecepcion.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("nombres") Is System.DBNull.Value Then
                    strlnombres = " "
                Else
                    strlnombres = dtsrecepcion.Tables(0).Rows(0).Item("nombres")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apellidos") Is System.DBNull.Value Then
                    strlapellidos = " "
                Else
                    strlapellidos = dtsrecepcion.Tables(0).Rows(0).Item("apellidos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("documento") Is System.DBNull.Value Then
                    strldocumento = " "
                Else
                    strldocumento = dtsrecepcion.Tables(0).Rows(0).Item("documento")
                End If
            End If
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub registronov()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "INSERT INTO novedad(cod,fcnovedad,idtiponovedad,dias,horas,estado,repone,reportanom,tipificacion,descripcion,fcregistro,idusuarioreg,Cod_Diagnostico,Aprobacion) values(@strlcodigo,@strlfcnovedad,@strltiponov,@strldianov,@strlhoranov,@strlestado,@strlrepone,@strlreporta,@strltipificacion,@strlobs,@strlfcregistro,@strlidusuario,@strlCod_Diagnostico,'Pendiente')"
            If _Validacion = "Retiro" Then
                If _Usu_CRM = "Renuncia Voluntaria" Then
                    cms.CommandText = "INSERT INTO novedad(cod,fcnovedad,idtiponovedad,dias,horas,estado,repone,reportanom,tipificacion,descripcion,fcregistro,idusuarioreg,Aprobacion,Tipo_Retiro) values(@strlcodigo,@strlfcnovedad,@strltiponov,@strldianov,@strlhoranov,@strlestado,@strlrepone,@strlreporta,@strltipificacion,@strlobs,@strlfcregistro,@strlidusuario,'Pendiente','Renuncia Voluntaria')"
                Else
                    cms.CommandText = "INSERT INTO novedad(cod,fcnovedad,idtiponovedad,dias,horas,estado,repone,reportanom,tipificacion,descripcion,fcregistro,idusuarioreg,Aprobacion,Tipo_Retiro) values(@strlcodigo,@strlfcnovedad,@strltiponov,@strldianov,@strlhoranov,@strlestado,@strlrepone,@strlreporta,@strltipificacion,@strlobs,@strlfcregistro,@strlidusuario,'Pendiente','Justa Causa')"
                End If
            End If
            cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 50).Value = strlCod_Diagnostico
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
            cms.Parameters.Add("@strlfcnovedad", SqlDbType.Date).Value = strlfcnovedad
            cms.Parameters.Add("@strltiponov", SqlDbType.Int).Value = strltiponov
            cms.Parameters.Add("@strldianov", SqlDbType.Int).Value = strldianov
            cms.Parameters.Add("@strlhoranov", SqlDbType.Float).Value = strlhoranov
            cms.Parameters.Add("@strlestado", SqlDbType.NVarChar, 100).Value = strlestado
            cms.Parameters.Add("@strlrepone", SqlDbType.VarChar, 2).Value = strlrepone
            cms.Parameters.Add("@strlreporta", SqlDbType.VarChar, 2).Value = strlreporta
            cms.Parameters.Add("@strltipificacion", SqlDbType.Int).Value = strltipificacion
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlfcregistro", SqlDbType.DateTime).Value = strlfcregistro
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Connection = cn
            cms.ExecuteNonQuery()
            If strldocumento <> Nothing Then
                cms.CommandText = "UPDATE personal SET estado='I' WHERE documento=@strldocumento"
                cms.Parameters.Add("@strldocumento", SqlDbType.VarChar, 50).Value = strldocumento
                cms.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function consultanovedad() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * from Cons_novedad order by idreg desc"
            If strlcodigo <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where cod=@strlcodigo order by idreg desc"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            End If
            If strldocumento <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where documento=@strldocumento order by idreg desc"
                cms.Parameters.Add("@strldocumento", SqlDbType.VarChar, 50).Value = Me.strldocumento
            End If
            If strlreporta <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where repone=@strlreporta order by idreg desc"
                cms.Parameters.Add("@strlreporta", SqlDbType.VarChar, 2).Value = Me.strlreporta
            End If
            If strltiponov <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where idtiponovedad=@strltiponov order by idreg desc"
                cms.Parameters.Add("@strltiponov", SqlDbType.Int).Value = Me.strltiponov
            End If
            If strltipificacion <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where tipificacion=@strltipificacion order by idreg desc"
                cms.Parameters.Add("@strltipificacion", SqlDbType.Int).Value = Me.strltipificacion
            End If
            If strlfcnovedad <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where fcnovedad >= @strlfcnovedad order by idreg desc"
                cms.Parameters.Add("@strlfcnovedad", SqlDbType.Date).Value = Me.strlfcnovedad
                If strlfcregistro <> Nothing Then
                    cms.CommandText = "SELECT * from Cons_novedad where fcnovedad >= @strlfcnovedad and fcnovedad <= @strlfcregistro order by idreg desc"
                    cms.Parameters.Add("@strlfcregistro", SqlDbType.Date).Value = Me.strlfcregistro
                End If
            End If
            If strlcodigo <> Nothing And strlfcnovedad <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where cod=@strlcodigo and fcnovedad >= @strlfcnovedad order by idreg desc"
                If strlfcregistro <> Nothing Then
                    cms.CommandText = "SELECT * from Cons_novedad where cod=@strlcodigo and fcnovedad >= @strlfcnovedad and fcnovedad <= @strlfcregistro order by idreg desc"
                End If
            End If
            If strlreporta <> Nothing And strlfcnovedad <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where repone=@strlreporta and fcnovedad >= @strlfcnovedad order by idreg desc"
                If strlfcregistro <> Nothing Then
                    cms.CommandText = "SELECT * from Cons_novedad where repone=@strlreporta and fcnovedad >= @strlfcnovedad and fcnovedad <= @strlfcregistro order by idreg desc"
                End If
            End If
            If strltiponov <> Nothing And strlfcnovedad <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where idtiponovedad=@strltiponov and fcnovedad >= @strlfcnovedad order by idreg desc"
                If strlfcregistro <> Nothing Then
                    cms.CommandText = "SELECT * from Cons_novedad where idtiponovedad=@strltiponov and fcnovedad >= @strlfcnovedad and fcnovedad <= @strlfcregistro order by idreg desc"
                End If
            End If
            If strlid <> Nothing Then
                If Validacion = "verificar" Then
                    cms.CommandText = "select * from Registro_Cambios_Novedades where Id_Novedad =@strlid"
                Else
                    cms.CommandText = "SELECT * from Cons_novedad where cod=@strlcodigo and idreg=@strlid order by idreg desc"
                End If
                cms.Parameters.Add("@strlid", SqlDbType.Decimal).Value = Me.strlid
            End If
            If strlhe <> Nothing Then
                cms.CommandText = "SELECT * from Registro_Cambios_Novedades where  Id_Novedad=@strlid "
            End If

            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlhe = Nothing Then
                If intcantidad > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("fcnovedad") Is System.DBNull.Value Then
                        strlfcnovedad = " "
                    Else
                        strlfcnovedad = dtsrecepcion.Tables(0).Rows(0).Item("fcnovedad")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("idtiponovedad") Is System.DBNull.Value Then
                        strltiponov = " "
                    Else
                        strltiponov = dtsrecepcion.Tables(0).Rows(0).Item("idtiponovedad")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("dias") Is System.DBNull.Value Then
                        strldianov = " "
                    Else
                        strldianov = dtsrecepcion.Tables(0).Rows(0).Item("dias")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("horas") Is System.DBNull.Value Then
                        strlhoranov = " "
                    Else
                        strlhoranov = dtsrecepcion.Tables(0).Rows(0).Item("horas")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                        strlestado = " "
                    Else
                        strlestado = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("repone") Is System.DBNull.Value Then
                        strlrepone = "0"
                    Else
                        strlrepone = dtsrecepcion.Tables(0).Rows(0).Item("repone")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("reportanom") Is System.DBNull.Value Then
                        strlreporta = "0"
                    Else
                        strlreporta = dtsrecepcion.Tables(0).Rows(0).Item("reportanom")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("tipificacion") Is System.DBNull.Value Then
                        strltipificacion = " "
                    Else
                        strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("tipificacion")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("descripcion") Is System.DBNull.Value Then
                        strlobs = " "
                    Else
                        strlobs = dtsrecepcion.Tables(0).Rows(0).Item("descripcion")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("mesreporte") Is System.DBNull.Value Then
                        strlmesreporte = " "
                    Else
                        strlmesreporte = dtsrecepcion.Tables(0).Rows(0).Item("mesreporte")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("Cod_Diagnostico") Is System.DBNull.Value Then
                        strlCod_Diagnostico = " "
                    Else
                        strlCod_Diagnostico = dtsrecepcion.Tables(0).Rows(0).Item("Cod_Diagnostico")
                    End If
                End If
            End If
            Return dtsrecepcion

        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub modificanov()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "UPDATE novedad SET repone=@strlrepone,horas=@strlhoranov, dias=@strldianov,idtiponovedad=@strltiponov, fcnovedad=@strlfcnovedad, estado=@strlestado,reportanom=@strlreporta,tipificacion=@strltipificacion,descripcion=@strlobs WHERE idreg=@strlid"
            cms.Parameters.Add("@strlestado", SqlDbType.NVarChar, 100).Value = strlestado
            cms.Parameters.Add("@strlreporta", SqlDbType.VarChar).Value = strlreporta
            cms.Parameters.Add("@strltipificacion", SqlDbType.Int).Value = strltipificacion
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlid", SqlDbType.VarChar).Value = strlid
            cms.Parameters.Add("@strlfcnovedad", SqlDbType.NVarChar, 50).Value = strlfcnovedad
            cms.Parameters.Add("@strltiponov", SqlDbType.NVarChar, 50).Value = strltiponov
            cms.Parameters.Add("@strldianov", SqlDbType.Int).Value = strldianov
            cms.Parameters.Add("@strlhoranov", SqlDbType.Float).Value = strlhoranov
            cms.Parameters.Add("@strlrepone", SqlDbType.NVarChar).Value = strlrepone
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub modificadotac()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "UPDATE personal SET carne=@strlcarne, chaleco=@strlchaleco, diadema=@strldiadema, locker=@strllocker, uniforme=@strluniforme WHERE codigo=@strlcodigo"
            cms.Parameters.Add("@strlcarne", SqlDbType.NVarChar, 2).Value = strlcarne
            cms.Parameters.Add("@strlchaleco", SqlDbType.VarChar, 2).Value = strlchaleco
            cms.Parameters.Add("@strldiadema", SqlDbType.VarChar, 2).Value = strldiadema
            cms.Parameters.Add("@strllocker", SqlDbType.NVarChar, 3).Value = strllocker
            cms.Parameters.Add("@strluniforme", SqlDbType.VarChar, 2).Value = strluniforme
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function consultadotac() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * from Cons_personal where codigo=@strlcodigo"
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("nombres") Is System.DBNull.Value Then
                    strlnombres = " "
                Else
                    strlnombres = dtsrecepcion.Tables(0).Rows(0).Item("nombres")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apellidos") Is System.DBNull.Value Then
                    strlapellidos = " "
                Else
                    strlapellidos = dtsrecepcion.Tables(0).Rows(0).Item("apellidos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("carne") Is System.DBNull.Value Then
                    strlcarne = " "
                Else
                    strlcarne = dtsrecepcion.Tables(0).Rows(0).Item("carne")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("chaleco") Is System.DBNull.Value Then
                    strlchaleco = " "
                Else
                    strlchaleco = dtsrecepcion.Tables(0).Rows(0).Item("chaleco")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("diadema") Is System.DBNull.Value Then
                    strldiadema = " "
                Else
                    strldiadema = dtsrecepcion.Tables(0).Rows(0).Item("diadema")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("locker") Is System.DBNull.Value Then
                    strllocker = " "
                Else
                    strllocker = dtsrecepcion.Tables(0).Rows(0).Item("locker")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("uniforme") Is System.DBNull.Value Then
                    strluniforme = " "
                Else
                    strluniforme = dtsrecepcion.Tables(0).Rows(0).Item("uniforme")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("obs") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obs")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("turno") Is System.DBNull.Value Then
                    strlturno = " "
                Else
                    strlturno = dtsrecepcion.Tables(0).Rows(0).Item("turno")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("grupo") Is System.DBNull.Value Then
                    strlgrupo = " "
                Else
                    strlgrupo = dtsrecepcion.Tables(0).Rows(0).Item("grupo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("documento") Is System.DBNull.Value Then
                    strldocumento = " "
                Else
                    strldocumento = dtsrecepcion.Tables(0).Rows(0).Item("documento")
                End If
            End If
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub registrosolicdoc()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "INSERT INTO detalledoc(codigod,fcreg,tipos,obs,estado) values(@strlcodigo,@strlfcregistro,@strltipodoc,@strlobs,'En Proceso')"
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
            cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
            cms.Parameters.Add("@strltipodoc", SqlDbType.Int).Value = strltipodoc
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function consultasolicdoc() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT  iddoc, codigod, fcreg,tipos, tipodoc, detalledoc.obs, detalledoc.estado, fcemision, obsemision, nombres, apellidos, documento, personal.idarea, area FROM Detalledoc INNER JOIN Documento ON Detalledoc.tipos = Documento.id INNER JOIN personal ON Detalledoc.codigod = personal.codigo LEFT OUTER JOIN Area ON personal.idarea = Area.idarea order by iddoc desc"
            If strlcodigo <> Nothing Then
                cms.CommandText = "SELECT  iddoc, codigod, fcreg,tipos, tipodoc, detalledoc.obs, detalledoc.estado, fcemision, obsemision, nombres, apellidos, documento, personal.idarea, area FROM Detalledoc INNER JOIN Documento ON Detalledoc.tipos = Documento.id INNER JOIN personal ON Detalledoc.codigod = personal.codigo LEFT OUTER JOIN Area ON personal.idarea = Area.idarea where codigod=@strlcodigo order by iddoc desc"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            End If
            If strlestado <> Nothing Then
                cms.CommandText = "SELECT  iddoc, codigod, fcreg,tipos, tipodoc, detalledoc.obs, detalledoc.estado, fcemision, obsemision, nombres, apellidos, documento, personal.idarea, area FROM Detalledoc INNER JOIN Documento ON Detalledoc.tipos = Documento.id INNER JOIN personal ON Detalledoc.codigod = personal.codigo LEFT OUTER JOIN Area ON personal.idarea = Area.idarea where detalledoc.estado='en proceso' order by iddoc desc"
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub actsolicdoc()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "UPDATE detalledoc SET estado=@strltipodoc, fcemision=@strlfcregistro, obsemision=@strlobs, idusuarioemis=@strlidusuario WHERE iddoc=@strlid"
            cms.Parameters.Add("@strlid", SqlDbType.VarChar, 50).Value = strlid
            cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
            cms.Parameters.Add("@strltipodoc", SqlDbType.VarChar, 50).Value = strltipodoc
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub modificaop()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "UPDATE personal SET turno=@strlturno, grupo=@strlgrupo, obs=@strlobs WHERE codigo=@strlcodigo"
            cms.Parameters.Add("@strlturno", SqlDbType.NVarChar, 50).Value = strlturno
            cms.Parameters.Add("@strlgrupo", SqlDbType.VarChar, 50).Value = strlgrupo
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function consultabonos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * from bono"
            If strlcodigo <> Nothing Then
                cms.CommandText = "SELECT * from bono where cod=@strlcodigo"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultagrupo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT grupo from personal where codigo=@strlcodigo"
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("grupo") Is System.DBNull.Value Then
                    strlgrupo = " "
                Else
                    strlgrupo = dtsrecepcion.Tables(0).Rows(0).Item("grupo")
                End If
            End If
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    'Public Sub ingresocent()
    '    Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
    '    Try
    '        Dim fecha As New DateTime
    '        Dim cms As New SqlClient.SqlCommand
    '        cn.Open()
    '        strlfcregistro = Now
    '        cms.CommandText = "INSERT INTO centinela(idusuario,fcingreso,IPEntrada) values(@strlcodigo,@strlfcregistro,@strlIPEntrada)"
    '        cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
    '        cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
    '        cms.Parameters.Add("@strlIPEntrada", SqlDbType.VarChar, 50).Value = strlIPEntrada
    '        cms.Connection = cn
    '        cms.ExecuteNonQuery()
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub
    'Public Function consultacentinela() As DataSet
    '    Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
    '    Dim dtsrecepcion As New DataSet
    '    Dim dtarecepcion As SqlClient.SqlDataAdapter
    '    Dim cms As New SqlClient.SqlCommand
    '    Try
    '        cn.Open()
    '        cms.CommandText = "SELECT * from centinela where idusuario=@strlcodigo and fcsalida is null"
    '        cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
    '        cms.Connection = cn
    '        dtarecepcion = New SqlClient.SqlDataAdapter(cms)
    '        dtarecepcion.Fill(dtsrecepcion)
    '        Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
    '        Return dtsrecepcion
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Function
    'Public Sub salidacent()
    '    Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
    '    Try
    '        Dim fecha As New DateTime
    '        Dim cms As New SqlClient.SqlCommand
    '        cn.Open()
    '        strlfcregistro = Now
    '        cms.CommandText = "UPDATE centinela SET fcsalida=@strlfcregistro,IPSalida=@strlIPSalida WHERE idusuario=@strlcodigo and fcsalida is null"
    '        cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
    '        cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
    '        cms.Parameters.Add("@strlIPSalida", SqlDbType.VarChar, 50).Value = strlIPSalida
    '        cms.Connection = cn
    '        cms.ExecuteNonQuery()
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub
    'Public Function consultacentinelareg() As DataSet
    '    Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
    '    Dim dtsrecepcion As New DataSet
    '    Dim dtarecepcion As SqlClient.SqlDataAdapter
    '    Dim cms As New SqlClient.SqlCommand
    '    Try
    '        cn.Open()
    '        cms.CommandText = "SELECT top 30 * from centinela where idusuario=@strlcodigo order by idcent desc"
    '        cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
    '        cms.Connection = cn
    '        dtarecepcion = New SqlClient.SqlDataAdapter(cms)
    '        dtarecepcion.Fill(dtsrecepcion)
    '        Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
    '        'If intcantidad > 0 Then
    '        '    If dtsrecepcion.Tables(0).Rows(0).Item("fcnovedad") Is System.DBNull.Value Then
    '        '        strlfcnovedad = " "
    '        '    Else
    '        '        strlfcnovedad = dtsrecepcion.Tables(0).Rows(0).Item("fcnovedad")
    '        '    End If
    '        'End If
    '        Return dtsrecepcion
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Function
    


    Public Function consultacentinelatotal() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            '---Cargo cliente---'
            If _Cargo_Cliente <> Nothing Then
                _Cargo_Cliente = " and Cargo_Cliente='" & _Cargo_Cliente & "'"
            End If
            '---Codigo---'
            If strlcodigo <> Nothing Then
                If _Tipo_Horario = 4 Then
                    strlcodigo = " and c.idusuario='" & strlcodigo & "' "
                Else
                    strlcodigo = " and Vh.Cod_Agente='" & strlcodigo & "' "
                End If
            End If
            '---Tipo Horario---'
            If _Tipo_Horario <> Nothing Then
                If _Tipo_Horario = 4 Then
                    _Validacion = "Centinela"
                Else
                    _Tipo_Horario = "and VH.Tipo_Horario='" & _Tipo_Horario & "'"
                End If
            End If
            If _Validacion = "Individual" Then
                If strlfcini <> Nothing Then
                    strlfcing = "convert(date,fcingreso) >='" & strlfcini & "'"
                    strlfcini = "and convert(date,VH.Fc_Ingreso)>='" & strlfcini & "'"
                    If strlfcfin <> Nothing Then
                        strlfcing = strlfcing & "  and convert(date,fcingreso) <='" & strlfcfin & "'"
                    End If
                End If
                '---Fecha Fin---'
                If strlfcfin <> Nothing Then
                    strlfcfin = " and convert(date,VH.Fc_Ingreso)<='" & strlfcfin & "'"
                End If
                cms.CommandText = "select P.nombres + ' ' + P.apellidos as Nombre,Cod_Agente,Fc_Ingreso as [Ingreso Programado],Fc_Salida as [Salida Programada],C.fcingreso as Ingreso,C.fcsalida As Salida,P.Cargo_Cliente as Cargo,VHC.Nombre as Horario from Validacion_Horario VH left join (select idusuario,fcingreso,fcsalida,case Tipo_Horario when 4 then 3 else Tipo_Horario end as Tipo_Horario,IPEntrada,IPSalida from centinela where " & strlfcing & ") C on (VH.Cod_Agente=C.idusuario  and VH.Tipo_Horario=C.Tipo_Horario and convert(date,VH.Fc_Ingreso)=convert(date,fcingreso)) inner join personal P on VH.Cod_Agente=codigo  left join Validacion_Horario_Complemento VHC on VH.Tipo_Horario=Cod_Validacion_Horario_Complemento where P.estado='A' " & strlfcini & strlfcfin & _Cargo_Cliente & strlcodigo & _Tipo_Horario
            End If


            '-----CENTINELA
            If _Validacion = "Centinela" Then
                If strlfcini <> Nothing Then
                    strlfcini = "and convert(date,fcingreso) >='" & strlfcini & "'"
                End If
                '---Fecha Fin---'
                If strlfcfin <> Nothing Then
                    strlfcfin = " and convert(date,fcingreso) <='" & strlfcfin & "'"
                End If
                cms.CommandText = "Select P.nombres + ' ' + P.apellidos as Nombre,C.idusuario as Cod_Agente,ipEntrada,IpSalida,C.fcingreso as Ingreso,C.fcsalida as Salida,p.cargo_cliente as cargo ,'Centinela' as Horario from centinela C inner join  personal P on C.idusuario=P.codigo " +
                        "where C.tipo_horario=4 " & strlfcini & strlfcfin & _Cargo_Cliente & strlcodigo
            End If


            If _Validacion = "Control" Then
                '---Fecha Inicio---'

                If _Validacion = "Control" Then
                    If strlfcini <> Nothing Then
                        strlfcnovedad = "and fcnovedad='" & strlfcini & "'"
                        strlfcini = "and convert(Date,Fc_Ingreso) ='" & strlfcini & "'"
                    End If
                Else
                    If strlfcini <> Nothing Then
                        strlfcini = "and convert(Date,fcingreso)>='" & strlfcini & "'"
                    End If
                End If
                cms.CommandText = "select substring(Cast (fc_ingreso as nvarchar),1,8) as fecha,[programado],[presente],[retardo],[Aus. Just],[Aus. Injus],[Vacaciones],[presente]+[retardo]+[Aus. Just]+[Aus. Injus]+[Vacaciones] as Total from(" +
                                    "select distinct Cod_Agente,convert(time,fc_ingreso) as fc_ingreso,case when Nombre = 'Laboral' then 'Programado' when (Nombre = 'Aus. Justificada' or Nombre = 'Suspension') then 'Aus. Just' else Nombre end as estado  " +
                                    "from Validacion_Horario  inner join personal on Cod_Agente = codigo inner join Validacion_Horario_Complemento on Tipo_Horario = Cod_Validacion_Horario_Complemento " +
                                    "where  Personal.estado='A' and (Tipo_Horario = 3 or Tipo_Horario = 10 or Tipo_Horario = 11 or Tipo_Horario = 12)" & strlfcini & _Cargo_Cliente & " " +
                                    "union " +
                                    "select distinct Cod_Agente,convert(time,fc_ingreso) as fc_ingreso, (Case  when dateadd(minute,1,Fc_Ingreso) < fcingreso  then 'retardo'  else 'presente' end) as estado " +
                                    "from Validacion_Horario V inner join Centinela C on convert(date,Fc_Ingreso)=CONVERT(date,fcingreso) and Cod_Agente = idusuario inner join personal on Cod_Agente = codigo " +
                                    "where   Personal.estado='A' and C.Tipo_Horario = 4 and V.Tipo_Horario = 3  " & strlfcini & _Cargo_Cliente & " " +
                                    "union " +
                                    "select distinct Cod_Agente,convert(time,Fc_Ingreso) as fc_ingreso,case when idtiponovedad = 36 then 'Aus. Injus'end as estado from Validacion_Horario " +
                                    "inner join novedad on Cod_Agente = cod inner join personal on Cod_Agente = codigo " +
                                    "where  Personal.estado='A' and Tipo_Horario=3 and idtiponovedad=36" & strlfcini & strlfcnovedad & _Cargo_Cliente & " " +
                                    ") as source pivot (count(Cod_agente) for estado in ([programado],[presente],[retardo],[Aus. Just],[Aus. Injus],[Vacaciones])) as pvt " +
                                    "union " +
                                    "select substring(Cast (fc_ingreso as nvarchar),1,8) as fecha,[programado],[presente],[retardo],[Aus. Just],[Aus. Injus],[Vacaciones],[presente]+[retardo]+[Aus. Just]+[Aus. Injus]+[Vacaciones] as Total  from(" +
                                    "select distinct Cod_Agente,'total' as fc_ingreso,case when Nombre = 'Laboral' then 'Programado' when (Nombre = 'Aus. Justificada' or Nombre = 'Suspension') then 'Aus. Just' else Nombre end as estado  " +
                                    "from Validacion_Horario  inner join personal on Cod_Agente = codigo inner join Validacion_Horario_Complemento on Tipo_Horario = Cod_Validacion_Horario_Complemento " +
                                    "where  Personal.estado='A' and (Tipo_Horario = 3 or Tipo_Horario = 10 or Tipo_Horario = 11 or Tipo_Horario = 12)   " & strlfcini & _Cargo_Cliente & " " +
                                    "union " +
                                    "select distinct Cod_Agente,'total 'as fc_ingreso, (Case  when dateadd(minute,1,Fc_Ingreso) < fcingreso  then 'retardo'  else 'presente' end) as estado  " +
                                    "from Validacion_Horario V inner join Centinela C on convert(date,Fc_Ingreso)=CONVERT(date,fcingreso) and Cod_Agente = idusuario  inner join personal on Cod_Agente = codigo " +
                                    "where  Personal.estado='A' and C.Tipo_Horario = 4 and V.Tipo_Horario = 3    " & strlfcini & _Cargo_Cliente & " " +
                                    "union " +
                                    "select distinct Cod_Agente,'total' as fc_ingreso,case when idtiponovedad = 36 then 'Aus. Injus' end as estado from Validacion_Horario inner join novedad on Cod_Agente = cod inner join personal on Cod_Agente = codigo " +
                                    "where  Personal.estado='A' and Tipo_Horario=3  and idtiponovedad=36 " & strlfcini & strlfcnovedad & _Cargo_Cliente & " " +
                                    "group by Cod_Agente,idtiponovedad) as source pivot (count(Cod_agente) for estado in ([programado],[presente],[retardo],[Aus. Just],[Aus. Injus],[Vacaciones])) as pvtt  order by fecha"

            End If

            '------Hora-----'
            If strlhoranov <> Nothing Then
                If strlhoranov = "total " Or strlhoranov = "total" Then
                    strlhoranov = Nothing
                Else
                    strlhoranov = "and convert(time,Fc_Ingreso) = '" & strlhoranov & "'"
                End If

            End If

            '/*Presentes - Retardos*/
            If _Validacion = "Presentes" Then

                If strlfcini <> Nothing Then
                    strlfcnovedad = "and fcnovedad='" & strlfcini & "'"
                    strlfcini = "and convert(Date,Fc_Ingreso) ='" & strlfcini & "'"
                End If

                If strlturno = "Presentes" Then
                    strlturno = "and dateadd(minute,1,Fc_Ingreso) > fcingreso"
                Else
                    strlturno = "and dateadd(minute,1,Fc_Ingreso) < fcingreso"
                End If

                cms.CommandText = "SELECT DISTINCT C.IDUSUARIO, NOMBRES + ' ' + APELLIDOS AS NOMBRE,FCINGRESO,FCSALIDA,FC_INGRESO,FC_SALIDA,Cargo_Cliente as Cargo,case when V.TIPO_HORARIO = 3 then 'Laboral' end as estado " +
               "from Validacion_Horario V inner join Centinela C on convert(date,Fc_Ingreso)=CONVERT(date,fcingreso) and Cod_Agente = idusuario inner join personal on Cod_Agente = codigo " +
               "where Personal.estado='A' and (C.Tipo_Horario = 4 and V.Tipo_Horario = 3)  " & strlfcini & strlhoranov & _Cargo_Cliente & strlturno & "  ORDER BY C.IDUSUARIO "
            End If

            '/*Programados - Vacaciones - Aus. Justificada - Suspension*/
            If _Validacion = "Validacion" Then
                If strlturno <> Nothing Then
                    If strlturno = "Programados" Then
                        strlturno = "AND Tipo_Horario = 3"
                    ElseIf strlturno = "Vacaciones" Then
                        strlturno = "AND Tipo_Horario = 10"
                    ElseIf strlturno = "Aus. Just" Then
                        strlturno = "AND (Tipo_Horario = 11 or Tipo_Horario = 12)"
                    End If
                End If
                If strlfcini <> Nothing Then
                    strlfcnovedad = "and fcnovedad='" & strlfcini & "'"
                    strlfcini = "and convert(Date,Fc_Ingreso) ='" & strlfcini & "'"
                End If
                cms.CommandText = "select DISTINCT Cod_Agente, NOMBRES + ' ' + APELLIDOS AS NOMBRE,fc_ingreso,FC_SALIDA,Cargo_Cliente as Cargo,case when Nombre = 'Laboral' then 'Programado' else Nombre end as estado " +
               "from Validacion_Horario  inner join personal on Cod_Agente = codigo inner join Validacion_Horario_Complemento on Tipo_Horario = Cod_Validacion_Horario_Complemento " +
               "where  Personal.estado='A' and (Tipo_Horario = 3 or Tipo_Horario = 10 or Tipo_Horario = 11 or Tipo_Horario = 12) " & strlfcini & strlhoranov & _Cargo_Cliente & strlturno
            End If

            '/*Aus. Injus*/
            If _Validacion = "Injus" Then

                If strlturno <> Nothing Then
                    strlturno = Nothing
                End If
                If strlfcini <> Nothing Then
                    strlfcnovedad = "and fcnovedad='" & strlfcini & "'"
                    strlfcini = "and convert(Date,Fc_Ingreso) ='" & strlfcini & "'"
                End If

                cms.CommandText = "select distinct Cod_Agente,NOMBRES + ' ' + APELLIDOS AS NOMBRE,(Fc_Ingreso) as fc_ingreso,idusuarioreg,descripcion,Cargo_Cliente as Cargo,case when idtiponovedad = 36 then 'Aus. Injus'end as estado " +
               "from Validacion_Horario inner join novedad on Cod_Agente = cod inner join personal on Cod_Agente = codigo " +
               "where  Personal.estado='A' and Tipo_Horario=3 and idtiponovedad=36 " & strlfcnovedad & strlfcini & strlhoranov & _Cargo_Cliente & strlturno
            End If
            '/*TOTAL*/'
            If _Validacion = "Total" Then
                If strlturno <> Nothing Then
                    strlturno = Nothing
                End If
                If strlfcini <> Nothing Then
                    strlfcnovedad = "and fcnovedad='" & strlfcini & "'"
                    strlfcini = "and convert(Date,Fc_Ingreso) ='" & strlfcini & "'"
                End If
                cms.CommandText = "SELECT DISTINCT C.IDUSUARIO as usuario, NOMBRES + ' ' + APELLIDOS AS NOMBRE,FC_INGRESO,FC_SALIDA,Cargo_Cliente as Cargo,case when V.TIPO_HORARIO = 3 then 'Laboral' end as estado " +
                    "from Validacion_Horario V inner join Centinela C on convert(date,Fc_Ingreso)=CONVERT(date,fcingreso) and Cod_Agente = idusuario inner join personal on Cod_Agente = codigo " +
                    "where  Personal.estado='A' and  (C.Tipo_Horario = 4 and V.Tipo_Horario = 3)  " & strlfcini & strlhoranov & _Cargo_Cliente & strlturno +
                                    "union " +
                    "select DISTINCT Cod_Agente as usuario, NOMBRES + ' ' + APELLIDOS AS NOMBRE,FC_INGRESO,FC_SALIDA,Cargo_Cliente as Cargo,case when Nombre = 'Laboral' then 'Programado' else Nombre end as estado " +
                    "from Validacion_Horario  inner join personal on Cod_Agente = codigo inner join Validacion_Horario_Complemento on Tipo_Horario = Cod_Validacion_Horario_Complemento " +
                    "where  Personal.estado='A' and  ( Tipo_Horario = 10 or Tipo_Horario = 11 or Tipo_Horario = 12) " & strlfcini & strlhoranov & _Cargo_Cliente & strlturno +
                    "union " +
                    "select distinct Cod_Agente as usuario,NOMBRES + ' ' + APELLIDOS AS NOMBRE,FC_INGRESO,FC_SALIDA,Cargo_Cliente as Cargo,case when idtiponovedad = 36 then 'Aus. Injus'end as estado " +
                    "from Validacion_Horario inner join novedad on Cod_Agente = cod inner join personal on Cod_Agente = codigo " +
                    "where  Personal.estado='A' and  Tipo_Horario=3  and idtiponovedad=36 " & strlfcnovedad & strlfcini & strlhoranov & _Cargo_Cliente & strlturno
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function





    Public Function Consulta_Archivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Archivo where Categoria <> '- Seleccione -' or Dependencia <> '- Seleccione -' or Nombre <> '- Seleccione -'"
            ''Nombre Documento
            If strldocumento <> Nothing Then
                cms.CommandText = "select * from Archivo where Nombre like '" + strldocumento + "%' and (Categoria <> '- Seleccione -' or Dependencia <> '- Seleccione -' or Nombre <> '- Seleccione -')"
                cms.Parameters.Add("@strldocumento", SqlDbType.VarChar, 100).Value = strldocumento
            End If
            ''Categoria Documento
            If strlcargo <> Nothing Then
                cms.CommandText = "select * from Archivo where Categoria = @strlcargo"
                cms.Parameters.Add("@strlcargo", SqlDbType.VarChar, 100).Value = strlcargo
            End If
            ''Dependencia Documento
            If strldeporte <> Nothing Then
                cms.CommandText = "select * from Archivo where Dependencia = @strldeporte"
                cms.Parameters.Add("@strldeporte", SqlDbType.VarChar, 100).Value = strldeporte
            End If
            If strlcargo <> Nothing And strldocumento <> Nothing Then
                cms.CommandText = "select * from Archivo where Nombre like '" + strldocumento + "%' and Categoria = @strlcargo"
            End If
            If strldocumento <> Nothing And strldeporte <> Nothing Then
                cms.CommandText = "select * from Archivo where Nombre like '" + strldocumento + "%' and Dependencia = @strldeporte"
            End If
            If strlcargo <> Nothing And strldeporte <> Nothing Then
                cms.CommandText = "select * from Archivo where Categoria = @strlcargo and Dependencia = @strldeporte"
            End If
            If strlcargo <> Nothing And strldeporte <> Nothing And strldocumento <> Nothing Then
                cms.CommandText = "select * from Archivo where Nombre like '" + strldocumento + "%' and Categoria = @strlcargo and Dependencia = @strldeporte"
            End If
            ''Codigo Documento
            If strlCod_Archivo <> Nothing Then
                cms.CommandText = "select * from Archivo where Cod_Archivo = @strlCod_Archivo"
                cms.Parameters.Add("@strlCod_Archivo", SqlDbType.Int).Value = strlCod_Archivo
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me.intcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Archivo_Categoria() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Archivo_Complemento where Pertenece='Categoria' or Pertenece = '- Seleccione -' order by Nombre"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Archivo_Dependencia() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Archivo_Complemento where Pertenece='Dependencia' or Pertenece = '- Seleccione -' order by Nombre"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub Registro_Documento()

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = 1 Then
                If strldeporte <> Nothing Then
                    cms.CommandText = "insert into Archivo (Categoria,Dependencia,Nombre,Url,Version,Observacion,Id_Usuario,FcReg) values (@strlcargo,@strldeporte,@strldocumento,@strlrutahv,@_Version,@_Observacion,@_Usuario,@_Fcreg)"
                    cms.Parameters.Add("@strldeporte", SqlDbType.VarChar, 250).Value = strldeporte
                    'Else
                    '    cms.CommandText = "insert into Archivo (Categoria,Nombre,Url,Version,Observacion,Id_Usuario,FcReg) values (@strlcargo,@strldocumento,@strlrutahv,@_Version,@_Observacion,@_Usuario,@_Fcreg)"
                End If
            End If
            If Validacion = 2 Then
                If strldeporte <> Nothing Then
                    cms.CommandText = "insert into Archivo (Categoria,Dependencia,Nombre,Url,Version,Observacion,Historial,Id_Usuario,FcReg) values (@strlcargo,@strldeporte,@strldocumento,@strlrutahv,@_Version,@_Observacion,@strltipocont,@_Usuario,@_Fcreg)"
                    cms.Parameters.Add("@strldeporte", SqlDbType.VarChar, 250).Value = strldeporte
                Else
                    cms.CommandText = "insert into Archivo (Categoria,Nombre,Url,Version,Observacion,Historial,Id_Usuario,FcReg) values (@strlcargo,@strldocumento,@strlrutahv,@_Version,@_Observacion,@strltipocont,@_Usuario,@_Fcreg)"
                End If
                cms.Parameters.Add("@strltipocont", SqlDbType.VarChar, 250).Value = strltipocont
            End If
            If Validacion = 3 Then
                cms.CommandText = "UPDATE Archivo SET Historial = @strlCod_Archivo where cod_Archivo = @strlCod_Archivo"
            End If
            cms.Parameters.Add("@strlcargo", SqlDbType.VarChar, 100).Value = strlcargo
            cms.Parameters.Add("@strldocumento", SqlDbType.VarChar, 200).Value = strldocumento
            cms.Parameters.Add("@strlrutahv", SqlDbType.VarChar, 100).Value = strlrutahv
            cms.Parameters.Add("@_Version", SqlDbType.VarChar, 100).Value = _Version
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 500).Value = _Observacion
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 500).Value = _Usu_CRM
            cms.Parameters.Add("@_Fcreg", SqlDbType.VarChar, 500).Value = _Fecha_Creacion
            cms.Parameters.Add("@strlCod_Archivo", SqlDbType.VarChar, 250).Value = strlCod_Archivo
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Protected strlDescanso As String
    Protected strlJefe_Inmediato As String
    Protected strlAclaracion As String
    Public Property Aclaracion As String
        Get
            Return strlAclaracion
        End Get
        Set(ByVal value As String)
            strlAclaracion = value
        End Set
    End Property
    Public Property Jefe_Inmediato As String
        Get
            Return strlJefe_Inmediato
        End Get
        Set(ByVal value As String)
            strlJefe_Inmediato = value
        End Set
    End Property
    Public Property Descanso As String
        Get
            Return strlDescanso
        End Get
        Set(ByVal value As String)
            strlDescanso = value
        End Set
    End Property

    '' usuarios
    ''Informacion Usu,Pass
    Protected _Usu_CRM As String
    Protected _Fecha_Creacion As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Codigo_Atuliza As String
    Protected _Plataforma As String
    Protected _Estado_Plataforma As String
    Protected _Usuario_Plataforma As String
    Protected _Password_Plataforma As String
    Protected _Formato As String
    Protected _Estado_General As String

    Public Property Plataforma As String
        Get
            Return _Plataforma
        End Get
        Set(ByVal value As String)
            _Plataforma = value
        End Set
    End Property

    Public Property Estado_Plataforma As String
        Get
            Return _Estado_Plataforma
        End Get
        Set(ByVal value As String)
            _Estado_Plataforma = value
        End Set
    End Property
    Public Property Usuario_Plataforma As String
        Get
            Return _Usuario_Plataforma
        End Get
        Set(ByVal value As String)
            _Usuario_Plataforma = value
        End Set
    End Property
    Public Property Password_Plataforma As String
        Get
            Return _Password_Plataforma
        End Get
        Set(ByVal value As String)
            _Password_Plataforma = value
        End Set
    End Property

    Public Property Formato As String
        Get
            Return _Formato
        End Get
        Set(ByVal value As String)
            _Formato = value
        End Set
    End Property
    Public Property Estado_General As String
        Get
            Return _Estado_General
        End Get
        Set(ByVal value As String)
            _Estado_General = value
        End Set
    End Property
    Public Property Codigo_Atuliza As String
        Get
            Return _Codigo_Atuliza
        End Get
        Set(ByVal value As String)
            _Codigo_Atuliza = value
        End Set
    End Property

    Public Property Fecha_Creacion As String
        Get
            Return _Fecha_Creacion
        End Get
        Set(ByVal value As String)
            _Fecha_Creacion = value
        End Set
    End Property
    Public Property Usu_CRM As String
        Get
            Return _Usu_CRM
        End Get
        Set(ByVal value As String)
            _Usu_CRM = value
        End Set
    End Property

    Protected _Id_Estado_Nacimiento As Integer
    Protected _Id_Pais_Nacimiento As Integer
    Protected _Id_Nacionalidad As Integer
    Protected _Id_Ciudad_Nacimiento As Integer
    Public Property Id_Nacionalidad As Integer
        Get
            Return _Id_Nacionalidad
        End Get
        Set(ByVal value As Integer)
            _Id_Nacionalidad = value
        End Set
    End Property
    Public Property Id_Pais_Nacimiento As Integer
        Get
            Return _Id_Pais_Nacimiento
        End Get
        Set(ByVal value As Integer)
            _Id_Pais_Nacimiento = value
        End Set
    End Property
    Public Property Id_Estado_Nacimiento As Integer
        Get
            Return _Id_Estado_Nacimiento
        End Get
        Set(ByVal value As Integer)
            _Id_Estado_Nacimiento = value
        End Set
    End Property
    Public Property Id_Ciudad_Nacimiento As Integer
        Get
            Return _Id_Ciudad_Nacimiento
        End Get
        Set(ByVal value As Integer)
            _Id_Ciudad_Nacimiento = value
        End Set
    End Property

    Protected _Semestre_Actual_U As String
    Protected _Pers_Contac_Emerg As String
    Protected _Tel_Contac_Emeg As String
    Protected _Toma_Medicamentos As String
    Protected _Obs_Medicamentos As String
    Protected _Obs_Ant_Salud As String
    Public Property Semestre_Actual_U As String
        Get
            Return _Semestre_Actual_U
        End Get
        Set(ByVal value As String)
            _Semestre_Actual_U = value
        End Set
    End Property
    Public Property Pers_Contac_Emerg As String
        Get
            Return _Pers_Contac_Emerg
        End Get
        Set(ByVal value As String)
            _Pers_Contac_Emerg = value
        End Set
    End Property
    Public Property Tel_Contac_Emeg As String
        Get
            Return _Tel_Contac_Emeg
        End Get
        Set(ByVal value As String)
            _Tel_Contac_Emeg = value
        End Set
    End Property
    Public Property Toma_Medicamentos As String
        Get
            Return _Toma_Medicamentos
        End Get
        Set(ByVal value As String)
            _Toma_Medicamentos = value
        End Set
    End Property
    Public Property Obs_Medicamentos As String
        Get
            Return _Obs_Medicamentos
        End Get
        Set(ByVal value As String)
            _Obs_Medicamentos = value
        End Set
    End Property
    Public Property Obs_Ant_Salud As String
        Get
            Return _Obs_Ant_Salud
        End Get
        Set(ByVal value As String)
            _Obs_Ant_Salud = value
        End Set
    End Property


    Protected Con_admin_cham As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion solo con la base de datos admin_cham
    Protected Con_admin_cham_Datos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) ' Conexion con la base de datos admin_cham y otros




    Public Function Consulta_Historico_Disciplinario() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlfcini <> Nothing And strldeporte <> 1 Then
                cms.CommandText = "SELECT H.documento AS Documento, U.cargo AS Grupo, U.codnom AS Código, U.nombreu AS Nombres, Tipoactualizacion.tipoactualizacion AS Disciplinario, H.descripcionact AS Descripción, H.idusuario AS Usuario_Registra, H.fcregistro AS Fecha_Registra FROM Historico H   INNER JOIN Cons_personal CP ON H.documento = CP.documento INNER JOIN UsuariosCham U ON U.codnom = CP.codigo INNER JOIN Tipoactualizacion ON H.idactualizacion = Tipoactualizacion.idactualizacion WHERE H.fcregistro>@strlfcini and Grupo <> 'N0_G1'"
                cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = strlfcini
            End If
            If strlfcini <> Nothing And strldeporte = 1 Then
                cms.CommandText = "SELECT H.documento AS Documento, U.cargo AS Grupo, U.codnom AS Código, U.nombreu AS Nombres, Tipoactualizacion.tipoactualizacion AS Disciplinario, H.descripcionact AS Descripción, H.idusuario AS Usuario_Registra, H.fcregistro AS Fecha_Registra FROM Historico H   INNER JOIN Cons_personal CP ON H.documento = CP.documento INNER JOIN UsuariosCham U ON U.codnom = CP.codigo INNER JOIN Tipoactualizacion ON H.idactualizacion = Tipoactualizacion.idactualizacion WHERE H.fcregistro>@strlfcini"
                cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = strlfcini
            End If
            If strlfcfin <> Nothing And strldeporte <> 1 Then
                cms.CommandText = "SELECT H.documento AS Documento, U.cargo AS Grupo, U.codnom AS Código, U.nombreu AS Nombres, Tipoactualizacion.tipoactualizacion AS Disciplinario, H.descripcionact AS Descripción, H.idusuario AS Usuario_Registra, H.fcregistro AS Fecha_Registra FROM Historico H   INNER JOIN Cons_personal CP ON H.documento = CP.documento INNER JOIN UsuariosCham U ON U.codnom = CP.codigo INNER JOIN Tipoactualizacion ON H.idactualizacion = Tipoactualizacion.idactualizacion WHERE H.fcregistro<@strlfcfin and Grupo <> 'N0_G1'"
                cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = strlfcfin
            End If
            If strlfcfin <> Nothing And strldeporte = 1 Then
                cms.CommandText = "SELECT H.documento AS Documento, U.cargo AS Grupo, U.codnom AS Código, U.nombreu AS Nombres, Tipoactualizacion.tipoactualizacion AS Disciplinario, H.descripcionact AS Descripción, H.idusuario AS Usuario_Registra, H.fcregistro AS Fecha_Registra FROM Historico H   INNER JOIN Cons_personal CP ON H.documento = CP.documento INNER JOIN UsuariosCham U ON U.codnom = CP.codigo INNER JOIN Tipoactualizacion ON H.idactualizacion = Tipoactualizacion.idactualizacion WHERE H.fcregistro<@strlfcfin"
                cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = strlfcfin
            End If
            If strlfcini <> Nothing And strlfcfin <> Nothing And strldeporte <> 1 Then
                cms.CommandText = "SELECT H.documento AS Documento, U.cargo AS Grupo, U.codnom AS Código, U.nombreu AS Nombres, Tipoactualizacion.tipoactualizacion AS Disciplinario, H.descripcionact AS Descripción, H.idusuario AS Usuario_Registra, H.fcregistro AS Fecha_Registra FROM Historico H   INNER JOIN Cons_personal CP ON H.documento = CP.documento INNER JOIN UsuariosCham U ON U.codnom = CP.codigo INNER JOIN Tipoactualizacion ON H.idactualizacion = Tipoactualizacion.idactualizacion WHERE H.fcregistro between @strlfcini and @strlfcfin and Grupo <> 'N0_G1'"
            End If
            If strlfcini <> Nothing And strlfcfin <> Nothing And strldeporte = 1 Then
                cms.CommandText = "SELECT H.documento AS Documento, U.cargo AS Grupo, U.codnom AS Código, U.nombreu AS Nombres, Tipoactualizacion.tipoactualizacion AS Disciplinario, H.descripcionact AS Descripción, H.idusuario AS Usuario_Registra, H.fcregistro AS Fecha_Registra FROM Historico H   INNER JOIN Cons_personal CP ON H.documento = CP.documento INNER JOIN UsuariosCham U ON U.codnom = CP.codigo INNER JOIN Tipoactualizacion ON H.idactualizacion = Tipoactualizacion.idactualizacion WHERE H.fcregistro between @strlfcini and @strlfcfin"
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_grupo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select grupo from Personal where grupo <> 'N0_G2' group by grupo order by grupo"
            If _Validacion = "centinela" Then
                cms.CommandText = " select distinct cargo_cliente from personal where estado='A' group by Cargo_Cliente"
            End If
            If _Validacion = "Horario" Then
                cms.CommandText = "select Cod_Validacion_Horario_Complemento,Nombre from Validacion_Horario_Complemento"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Personal_UsuPass()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select P.codigo,P.documento,P.nombres,P.apellidos,P.email,PUP.Extension,PUP.Usu_CRM,PUP.Usu_Spark from personal P full join Personal_Usu_Pass PUP on P.codigo = PUP.Codigo"
            If strlcodigo <> Nothing Then
                cms.CommandText = "select P.codigo,P.documento,P.nombres,P.apellidos,P.email,PUP.Extension,PUP.Usu_CRM,PUP.Usu_Spark from personal P full join Personal_Usu_Pass PUP on P.codigo = PUP.Codigo where P.Codigo = @strlcodigo"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Archivos_Botones() As DataSet

        Dim cn As New SqlClient.SqlConnection

        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter

        Dim cms As New SqlClient.SqlCommand



        cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexion directa con la creada en la web.config

        cn.Open()

        Try

            If Validacion = 1 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Categoria like '%GESTION GERENCIAL%'"

            End If

            If Validacion = 2 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Categoria like '%GESTION DE CALIDAD Y MEJORA%'"

            End If

            If Validacion = 3 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Categoria like '%GESTION DE OPERACIONES%'"

            End If

            If Validacion = 4 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Categoria like '%GESTION COMERCIAL%'"

            End If

            If Validacion = 5 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Categoria like '%GESTION DE TECNOLOGIA%'"

            End If

            If Validacion = 6 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Categoria like '%GESTION DE COMPRAS%'"

            End If

            If Validacion = 7 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Categoria like '%GESTION FINANCIERA%'"

            End If

            If Validacion = 8 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Categoria like '%GESTION DE TALENTO HUMANO%'"

            End If

            If Validacion = 9 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Dependencia like 'Datos'"

            End If

            If Validacion = 10 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Dependencia like 'Voz'"

            End If

            If Validacion = 11 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Dependencia like 'Voz y Datos'"

            End If

            If Validacion = 12 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Dependencia like 'Formacion'"

            End If

            If Validacion = 13 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Dependencia like 'Informacion'"

            End If

            If Validacion = 14 Then

                cms.CommandText = "select * from Archivo Ar where Ar.Dependencia like 'Otros'"

            End If

            cms.Connection = cn

            dta = New SqlClient.SqlDataAdapter(cms)

            dta.Fill(dts)

            intcantidad = dts.Tables(0).Rows.Count

            Return dts

        Catch ex As Exception

            Throw ex

        Finally

            If cn.State = ConnectionState.Open Then

                cn.Close()

            End If

        End Try

    End Function

    Public Function Consulta_Archivo_Capturavalor() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base

        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select MAX(Cod_Archivo) as Codigo from Archivo "

            cms.Connection = cn

            dta = New SqlClient.SqlDataAdapter(cms)

            dta.Fill(dts)

            strlCod_Archivo = dts.Tables(0).Rows(0).Item("Codigo")

            Return dts

        Catch ex As Exception

            Throw ex

        Finally

            If cn.State = ConnectionState.Open Then

                cn.Close()

            End If

        End Try

    End Function

    Public Function Consulta_Archivo_documentos() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base

        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "SELECT Archivo.Cod_archivo, Archivo.Categoria, Archivo.Dependencia, Archivo.Nombre, Archivo.Version, Archivo.Historial, MIN(Archivo.FcReg) AS FcReg FROM Archivo WHERE Cod_Archivo = @strlCod_Archivo GROUP BY Archivo.Cod_archivo, Archivo.Categoria, Archivo.Dependencia, Archivo.Nombre, Archivo.Version, Archivo.Historial, Archivo.FcReg"

            cms.Parameters.Add("@strlCod_Archivo", SqlDbType.VarChar, 250).Value = strlCod_Archivo

            cms.Connection = cn

            dta = New SqlClient.SqlDataAdapter(cms)

            dta.Fill(dts)

            If dts.Tables(0).Rows.Count > 0 Then

                If dts.Tables(0).Rows(0).Item("Cod_archivo") Is DBNull.Value Then

                    strlCod_Archivo = ""

                Else

                    strlCod_Archivo = dts.Tables(0).Rows(0).Item("Cod_archivo")

                End If

                If dts.Tables(0).Rows(0).Item("FcReg") Is DBNull.Value Then

                    strlfcregistro = ""

                Else

                    strlfcregistro = dts.Tables(0).Rows(0).Item("FcReg")

                End If

                If dts.Tables(0).Rows(0).Item("Nombre") Is DBNull.Value Then

                    strlnombres = ""

                Else

                    strlnombres = dts.Tables(0).Rows(0).Item("Nombre")

                End If

                If dts.Tables(0).Rows(0).Item("Categoria") Is DBNull.Value Then

                    strlcargo = ""

                Else

                    strlcargo = dts.Tables(0).Rows(0).Item("Categoria")

                End If

                If dts.Tables(0).Rows(0).Item("Dependencia") Is DBNull.Value Then

                    strlproyecto = ""

                Else

                    strlproyecto = dts.Tables(0).Rows(0).Item("Dependencia")

                End If

                If dts.Tables(0).Rows(0).Item("Version") Is DBNull.Value Then

                    strlcodigo = ""

                Else

                    strlcodigo = dts.Tables(0).Rows(0).Item("Version")

                End If

                If dts.Tables(0).Rows(0).Item("Historial") Is DBNull.Value Then

                    strltipocont = ""

                Else

                    strltipocont = dts.Tables(0).Rows(0).Item("Historial")

                End If

            End If

            Return dts

        Catch ex As Exception

            Throw ex

        Finally

            If cn.State = ConnectionState.Open Then

                cn.Close()

            End If

        End Try

    End Function

    Public Function Consulta_Archivo_Versiones() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base

        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            If Validacion = 1 Then

                cms.CommandText = "SELECT * FROM Archivo WHERE Cod_Archivo = @strlCod_Archivo"

                cms.Parameters.Add("@strlCod_Archivo", SqlDbType.VarChar, 250).Value = strlCod_Archivo

            End If

            If Validacion = 2 Then

                cms.CommandText = "SELECT * FROM Archivo WHERE Historial = @strltipocont"

                cms.Parameters.Add("@strltipocont", SqlDbType.VarChar, 250).Value = strltipocont

            End If

            cms.Connection = cn

            dta = New SqlClient.SqlDataAdapter(cms)

            dta.Fill(dts)

            If dts.Tables(0).Rows.Count > 0 Then

                If dts.Tables(0).Rows(0).Item("Historial") Is DBNull.Value Then

                    strltipocont = ""

                Else

                    strltipocont = dts.Tables(0).Rows(0).Item("Historial")

                End If

            End If

            Me.intcantidad = dts.Tables(0).Rows.Count

            Return dts

        Catch ex As Exception

            Throw ex

        Finally

            If cn.State = ConnectionState.Open Then

                cn.Close()

            End If

        End Try

    End Function
    Public Function Consulta_ValidaUn_Registro_Horarios()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlAclaracion = "Actualiza" Then
                cms.CommandText = "select * from Validacion_Horario where Cod_Agente=@strlcodigo and Fc_Ingreso=@strlfcing and Fc_Salida=@strlfcretiro and Estado=1"
                cms.Parameters.Add("@strlfcing", SqlDbType.DateTime).Value = strlfcing
                cms.Parameters.Add("@strlfcretiro", SqlDbType.DateTime).Value = strlfcretiro
            End If
            If strlAclaracion = "Registro" Then
                cms.CommandText = "select * from Validacion_Horario where Cod_Agente=@strlcodigo and Convert(date,Fc_Ingreso)=@strlfcing and Convert(date,Fc_Salida)=@strlfcretiro  and Estado=1"
                cms.Parameters.Add("@strlfcing", SqlDbType.Date).Value = strlfcing
                cms.Parameters.Add("@strlfcretiro", SqlDbType.Date).Value = strlfcretiro
            End If
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub Registro_Horario()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "insert into Validacion_Horario (FcReg,Id_Usuario,Cod_Agente,Fc_Ingreso,Fc_Salida,Estado,Tipo_Horario) values (@strlfcregistro,@strlidusuario,@strlcodigo,@strlfcing,@strlfcretiro,1,@strltipocont)"
            cms.Parameters.Add("@strlfcregistro", SqlDbType.DateTime).Value = strlfcregistro
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 20).Value = strlidusuario
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
            cms.Parameters.Add("@strlfcing", SqlDbType.DateTime).Value = strlfcing
            cms.Parameters.Add("@strlfcretiro", SqlDbType.DateTime).Value = strlfcretiro
            cms.Parameters.Add("@strltipocont", SqlDbType.Int).Value = strltipocont
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function Consulta_Personal_Cargo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select Jefe_Inmediato from personal where Jefe_Inmediato is not null group by Jefe_Inmediato order by Jefe_Inmediato"
            If strlJefe_Inmediato <> Nothing Then
                cms.CommandText = "Select * from personal where Jefe_Inmediato=@strlJefe_Inmediato"
                cms.Parameters.Add("@strlJefe_Inmediato", SqlDbType.VarChar, 120).Value = strlJefe_Inmediato
            End If
            If strltipocont = "1" Then
                cms.CommandText = "select * from Validacion_Horario_Complemento where Tipo='Horario' and Estado = 1"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Personal_AsigHoras() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from personal where Codigo=@strlcodigo"
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            intcantidad = dtsrecepcion.Tables(0).Rows.Count
            If dtsrecepcion.Tables(0).Rows.Count > 0 Then
                Me.cantidad = 1
                If dtsrecepcion.Tables(0).Rows(0).Item("nombres") Is System.DBNull.Value Then
                    Me.strlnombres = ""
                Else
                    Me.strlnombres = dtsrecepcion.Tables(0).Rows(0).Item("nombres")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apellidos") Is System.DBNull.Value Then
                    Me.strlapellidos = ""
                Else
                    Me.strlapellidos = dtsrecepcion.Tables(0).Rows(0).Item("apellidos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("codigo") Is System.DBNull.Value Then
                    Me.strlcodigo = ""
                Else
                    Me.strlcodigo = dtsrecepcion.Tables(0).Rows(0).Item("codigo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Grupo") Is System.DBNull.Value Then
                    Me.strlcargo = ""
                Else
                    Me.strlcargo = dtsrecepcion.Tables(0).Rows(0).Item("Grupo")
                End If
            Else
                Me.cantidad = 0
            End If
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Sub Actualizacion_Registro_Horario()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcregistro = Now
            If _Validacion = "Aprobado" Then
                cms.CommandText = "update Validacion_Horario set FcReg=@strlfcregistro,Id_Usuario=@strlidusuario,Cod_Agente=@strlcodigo,Fc_Ingreso=@strlfcing,Fc_Salida=@strlfcretiro,Estado=@strlestado,Tipo_Horario=@strltipocont,segmento=@strlSegmento where Cod_Validacion_Horario=@strlCod_Archivo   " &
                "UPDATE Validacion_Solicitud_Horario SET estado_solicitud = 'Aprobado' WHERE FK_Cod_Validacion_Horario = @strlCod_Archivo "
                If strlestado <> Nothing Then
                    cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 20).Value = strlestado
                Else
                    cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 20).Value = 1
                End If
            ElseIf Validacion = "Solicitud_Cambio_Horario" Then
                cms.CommandText = "insert into Validacion_Solicitud_Horario (FcReg,Id_Usuario,Cod_Agente,Fc_Ingreso,Fc_Salida,Tipo_Horario,Estado_Solicitud,segmento,Fk_Cod_Validacion_Horario) Values (@strlfcregistro,@strlidusuario,@strlcodigo,@strlfcing,@strlfcretiro,@strltipocont,'Abierto',@strlSegmento,@strlCod_Archivo)"

            ElseIf _Validacion = "AprobadoCambioDes" Then
                cms.CommandText = "INSERT INTO Validacion_Horario(FcReg,Id_Usuario,Cod_Agente,Fc_Ingreso,Fc_Salida,Estado,Tipo_Horario,segmento) VALUES " &
                 "(@strlfcregistro,@strlidusuario,@strlcodigo,@strlfcing,@strlfcretiro,1,@strltipocont,@strlSegmento) " &
                 "UPDATE Validacion_Solicitud_Horario SET Estado_Solicitud = 'Aprobado' , Fk_Cod_Validacion_Horario = (SELECT TOP 1 Cod_Validacion_Horario from Validacion_Horario ORDER BY Cod_Validacion_Horario desc) WHERE Cod_Agente =@strlcodigo and Cod_Validacion_Solicitud_Horario =@strlcodigoValidacion"
            Else
                cms.CommandText = "UPDATE Validacion_Solicitud_Horario SET estado_solicitud = 'Rechazado' WHERE FK_Cod_Validacion_Horario = @strlCod_Archivo or Cod_Validacion_Solicitud_Horario=@strlCod_Archivo"
            End If


            If strlCod_Diagnostico <> Nothing Then
                cms.Parameters.Add("@strlcodigoValidacion", SqlDbType.VarChar, 20).Value = strlCod_Diagnostico
            Else
                cms.Parameters.AddWithValue("@strlcodigValidacion", DBNull.Value)
            End If

            If strlUbicacion <> Nothing Then
                cms.Parameters.Add("@strlSegmento", SqlDbType.VarChar, 60).Value = strlUbicacion
            Else
                cms.Parameters.AddWithValue("@strlSegmento", DBNull.Value)
            End If

            If strlfcregistro <> Nothing Then
                cms.Parameters.Add("@strlfcregistro", SqlDbType.DateTime).Value = strlfcregistro
            Else
                cms.Parameters.AddWithValue("@strlfcregistro", DBNull.Value)
            End If
            If strlidusuario <> Nothing Then
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 20).Value = strlidusuario
            Else
                cms.Parameters.AddWithValue("@strlidusuario", DBNull.Value)
            End If
            If strlcodigo <> Nothing Then
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
            Else
                cms.Parameters.AddWithValue("@strlcodigo", DBNull.Value)
            End If
            If strlfcing <> Nothing Then
                cms.Parameters.Add("@strlfcing", SqlDbType.DateTime).Value = strlfcing
            Else
                cms.Parameters.AddWithValue("@strlfcing", DBNull.Value)
            End If
            If strlfcretiro <> Nothing Then
                cms.Parameters.Add("@strlfcretiro", SqlDbType.DateTime).Value = strlfcretiro
            Else
                cms.Parameters.AddWithValue("@strlfcretiro", DBNull.Value)
            End If
            If strltipocont <> Nothing Then
                cms.Parameters.Add("@strltipocont", SqlDbType.Int).Value = strltipocont
            Else
                cms.Parameters.AddWithValue("@strltipocont", DBNull.Value)
            End If
            If strlCod_Archivo <> Nothing And strlCod_Archivo <> 1 Then
                cms.Parameters.Add("@strlCod_Archivo", SqlDbType.Int).Value = strlCod_Archivo
            ElseIf strlCod_Archivo = 1 Then
                cms.Parameters.AddWithValue("@strlCod_Archivo", DBNull.Value)
            End If
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub




    Public Function Consulta_Registro_Horarios()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcodigo <> Nothing Then
                cms.CommandText = "select VH.Cod_Validacion_Horario,VH.FcReg,VH.Id_Usuario,VH.Cod_Agente,VH.Fc_Ingreso,VH.Fc_Salida,VH.Estado,VH.Id_Usuario_Estado,VH.Tipo_Horario,VHC.Nombre  from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where VH.Cod_Agente=@strlcodigo and VH.Estado=1"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
            End If
            If strlcodigo <> Nothing And strlfcing <> Nothing Then
                cms.CommandText = "select VH.Cod_Validacion_Horario,VH.FcReg,VH.Id_Usuario,VH.Cod_Agente,VH.Fc_Ingreso,VH.Fc_Salida,VH.segmento,VH.Estado,VH.Id_Usuario_Estado,VH.Tipo_Horario,VHC.Nombre  from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where VH.Cod_Agente=@strlcodigo and convert(Date,VH.Fc_Ingreso) = convert(Date,@strlfcing) and VH.Estado=1"
                cms.Parameters.Add("@strlfcing", SqlDbType.DateTime).Value = strlfcing
            End If
            If Validacion = "Permitir" Then
                cms.CommandText = "SELECT CONVERT(DATE,FcReg) As [Fecha Registro], CONVERT(DATE,Fc_Ingreso) As [Fecha Turno], Id_Usuario, Cod_Agente, Estado_Solicitud FROM Validacion_Solicitud_Horario GROUP BY CONVERT(DATE,FcReg),CONVERT(DATE,Fc_Ingreso),Id_Usuario,Cod_Agente,Estado_Solicitud HAVING Estado_Solicitud = 'Abierto' "
            End If
            If Validacion = "No_Permitir" Then
                cms.CommandText = "SELECT CONVERT(DATE,FcReg) As [Fecha Registro], CONVERT(DATE,Fc_Ingreso) As [Fecha Turno], Id_Usuario, Cod_Agente, Estado_Solicitud FROM Validacion_Solicitud_Horario GROUP BY CONVERT(DATE,FcReg),CONVERT(DATE,Fc_Ingreso),Id_Usuario,Cod_Agente,Estado_Solicitud HAVING Id_Usuario = @_IdUsuario or Cod_Agente = @_CodAgente"
                cms.Parameters.Add("@_IdUsuario", SqlDbType.VarChar, 50).Value = strlidusuario
                cms.Parameters.Add("@_CodAgente", SqlDbType.VarChar, 20).Value = strlcodigo
            End If
            If Validacion = "No_Permitir_Superv" Then
                cms.CommandText = "SELECT CONVERT(DATE,FcReg) As [Fecha Registro], CONVERT(DATE,Fc_Ingreso) As [Fecha Turno], Id_Usuario, Cod_Agente, Estado_Solicitud FROM Validacion_Solicitud_Horario WHERE Estado_Solicitud <> 'Aprobado' GROUP BY CONVERT(DATE,FcReg),CONVERT(DATE,Fc_Ingreso),Id_Usuario,Cod_Agente,Estado_Solicitud"
            End If
            If Validacion = "Solicitudes_Cambio_Horario" Then
                cms.CommandText = "SELECT VSH.Fk_Cod_Validacion_Horario As ID, VSH.Id_Usuario As [Id Usuario Registro], VSH.Cod_Agente As [Codigo Agente],  VSH.Fc_Ingreso As Ingreso ,  VSH.Fc_Salida As Salida, VHC.Nombre As [Tipo Horario], VSH.Tipo_Horario As [Cod Tipo Horario], VH.Fc_Ingreso,VH.Fc_Salida,VSH.Cod_Validacion_Solicitud_Horario as [Id Validacion Solicitud],VSH.segmento,vh.segmento as [Segmento Anterior]  FROM Validacion_Solicitud_Horario  VSH INNER JOIN Validacion_Horario_Complemento VHC on VSH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento LEFT JOIN Validacion_Horario VH ON VSH.Fk_Cod_Validacion_Horario  = Cod_Validacion_Horario WHERE  Estado_Solicitud = 'Abierto' AND CONVERT(DATE,VSH.FcReg) = @_FcReg AND VSH.Cod_Agente = @_CodAgente AND VSH.Id_Usuario = @_IdUsuario AND CONVERT(DATE,VSH.Fc_Ingreso) = @_Turno"
                cms.Parameters.Add("@_FcReg", SqlDbType.Date).Value = strlfcing
                cms.Parameters.Add("@_CodAgente", SqlDbType.VarChar, 20).Value = strlcodigo
                cms.Parameters.Add("@_IdUsuario", SqlDbType.VarChar, 50).Value = strlidusuario
                cms.Parameters.Add("@_Turno", SqlDbType.Date).Value = strlfcregistro
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad <> 0 Then
                If Validacion = "Solicitudes_Cambio_Horario" Then
                    If dts.Tables(0).Rows(0).Item("segmento") Is System.DBNull.Value Then
                        _Segmento = " "
                    Else
                        _Segmento = dts.Tables(0).Rows(0).Item("segmento")
                    End If
                End If
            End If
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function



    Public Function Validacion_Horarios() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = "1" Then
                cms.CommandText = "select VH.cod_agente,P.nombres,P.apellidos,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre as [Tipo_Horario],P.Jefe_Inmediato,P.Segmento from Validacion_Horario VH  left join (select idusuario, fcingreso,fcsalida,Case when Tipo_Horario=4 then 3 else Tipo_Horario end as Tipo_Horario from Centinela) C on VH.Cod_Agente = C.idusuario and C.Tipo_Horario = VH.Tipo_Horario and convert(Date,C.fcingreso)=CONVERT(date,VH.Fc_Ingreso) and convert(Date,C.fcsalida)=CONVERT(date,VH.Fc_Salida)  inner join personal P on C.idusuario = P.codigo inner join Validacion_Horario_Complemento V on VH.Tipo_Horario = V.Cod_Validacion_Horario_Complemento where  (C.fcingreso Between @strlfcini and @strlfcfin  ) group by P.nombres,P.apellidos,VH.cod_agente,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre ,P.Jefe_Inmediato,P.Segmento order by VH.Cod_Agente"
                If strlcodigo <> Nothing Then
                    cms.CommandText = "select VH.cod_agente,P.nombres,P.apellidos,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre as [Tipo_Horario],P.Jefe_Inmediato,P.Segmento from Validacion_Horario VH  left join (select idusuario, fcingreso,fcsalida,Case when Tipo_Horario=4 then 3 else Tipo_Horario end as Tipo_Horario from Centinela) C on VH.Cod_Agente = C.idusuario and C.Tipo_Horario = VH.Tipo_Horario and convert(Date,C.fcingreso)=CONVERT(date,VH.Fc_Ingreso) and convert(Date,C.fcsalida)=CONVERT(date,VH.Fc_Salida)  inner join personal P on C.idusuario = P.codigo inner join Validacion_Horario_Complemento V on VH.Tipo_Horario = V.Cod_Validacion_Horario_Complemento where  (C.fcingreso Between @strlfcini and @strlfcfin  ) and Cod_Agente=@strlcodigo group by P.nombres,P.apellidos,VH.cod_agente,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre ,P.Jefe_Inmediato,P.Segmento order by VH.Cod_Agente"
                    cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
                End If
                If strlJefe_Inmediato <> Nothing Then
                    cms.CommandText = "select VH.cod_agente,P.nombres,P.apellidos,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre as [Tipo_Horario],P.Jefe_Inmediato,P.Segmento from Validacion_Horario VH  left join (select idusuario, fcingreso,fcsalida,Case when Tipo_Horario=4 then 3 else Tipo_Horario end as Tipo_Horario from Centinela) C on VH.Cod_Agente = C.idusuario and C.Tipo_Horario = VH.Tipo_Horario and convert(Date,C.fcingreso)=CONVERT(date,VH.Fc_Ingreso) and convert(Date,C.fcsalida)=CONVERT(date,VH.Fc_Salida)  inner join personal P on C.idusuario = P.codigo inner join Validacion_Horario_Complemento V on VH.Tipo_Horario = V.Cod_Validacion_Horario_Complemento where  (C.fcingreso Between @strlfcini and @strlfcfin  ) and P.Jefe_Inmediato=@strlJefe_Inmediato group by P.nombres,P.apellidos,VH.cod_agente,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre ,P.Jefe_Inmediato,P.Segmento order by VH.Cod_Agente"
                    cms.Parameters.Add("@strlJefe_Inmediato", SqlDbType.VarChar, 20).Value = strlJefe_Inmediato
                End If
            End If
            If Validacion = "2" Then
                cms.CommandText = "select VH.FcReg,VH.Id_Usuario,VH.Cod_Agente,VH.Fc_Ingreso,VH.Fc_Salida,VH.Estado,VH.Id_Usuario_Estado,VH.Tipo_Horario,VHC.Nombre,P.codigo,P.nombres,P.apellidos,P.Jefe_Inmediato,C.idusuario from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join Centinela C on VH.Cod_Agente = C.idusuario inner join Personal P on P.codigo = VH.Cod_Agente where (CONVERT(date,VH.fc_ingreso) Between @strlfcini and @strlfcfin) and VH.Estado=1 and VH.Tipo_Horario=2 group by VH.FcReg,VH.Id_Usuario,VH.Cod_Agente,VH.Fc_Ingreso,VH.Fc_Salida,VH.Estado,VH.Id_Usuario_Estado,VH.Tipo_Horario,VHC.Nombre,P.codigo,P.nombres,P.apellidos,P.Jefe_Inmediato,C.idusuario"
                If strlcodigo <> Nothing Then
                    cms.CommandText = "select VH.FcReg,VH.Id_Usuario,VH.Cod_Agente,VH.Fc_Ingreso,VH.Fc_Salida,VH.Estado,VH.Id_Usuario_Estado,VH.Tipo_Horario,VHC.Nombre,P.codigo,P.nombres,P.apellidos,P.Jefe_Inmediato,C.idusuario from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join Centinela C on VH.Cod_Agente = C.idusuario inner join Personal P on P.codigo = VH.Cod_Agente where (CONVERT(date,VH.fc_ingreso) Between @strlfcini and @strlfcfin) and C.idusuario=@strlcodigo and VH.Estado=1 and VH.Tipo_Horario=2 group by VH.FcReg,VH.Id_Usuario,VH.Cod_Agente,VH.Fc_Ingreso,VH.Fc_Salida,VH.Estado,VH.Id_Usuario_Estado,VH.Tipo_Horario,VHC.Nombre,P.codigo,P.nombres,P.apellidos,P.Jefe_Inmediato,C.idusuario"
                    cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
                End If
                If strlJefe_Inmediato <> Nothing Then
                    cms.CommandText = "select VH.FcReg,VH.Id_Usuario,VH.Cod_Agente,VH.Fc_Ingreso,VH.Fc_Salida,VH.Estado,VH.Id_Usuario_Estado,VH.Tipo_Horario,VHC.Nombre,P.codigo,P.nombres,P.apellidos,P.Jefe_Inmediato,C.idusuario from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join Centinela C on VH.Cod_Agente = C.idusuario inner join Personal P on P.codigo = VH.Cod_Agente where (CONVERT(date,VH.fc_ingreso) Between @strlfcini and @strlfcfin) and P.Jefe_Inmediato=@strlJefe_Inmediato and VH.Estado=1 and VH.Tipo_Horario=2 group by VH.FcReg,VH.Id_Usuario,VH.Cod_Agente,VH.Fc_Ingreso,VH.Fc_Salida,VH.Estado,VH.Id_Usuario_Estado,VH.Tipo_Horario,VHC.Nombre,P.codigo,P.nombres,P.apellidos,P.Jefe_Inmediato,C.idusuario"
                    cms.Parameters.Add("@strlJefe_Inmediato", SqlDbType.VarChar, 20).Value = strlJefe_Inmediato
                End If
            End If

            If Validacion = "3" Then
                cms.CommandText = "select * from Validacion_Horario VH inner join personal P on P.codigo = VH.Cod_Agente where (CONVERT(date,VH.Fc_Ingreso) Between @strlfcini and @strlfcfin) and VH.Estado=1"
                If strlcodigo <> Nothing Then
                    cms.CommandText = "select * from Validacion_Horario VH inner join personal P on P.codigo = VH.Cod_Agente where (CONVERT(date,VH.Fc_Ingreso) Between @strlfcini and @strlfcfin) and VH.Cod_Agente=@strlcodigo and VH.Estado=1"
                    cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
                End If
                If strlJefe_Inmediato <> Nothing Then
                    cms.CommandText = "select * from Validacion_Horario VH inner join personal P on P.codigo = VH.Cod_Agente where (CONVERT(date,VH.Fc_Ingreso) Between @strlfcini and @strlfcfin) and P.Jefe_Inmediato=@strlJefe_Inmediato and VH.Estado=1"
                    cms.Parameters.Add("@strlJefe_Inmediato", SqlDbType.VarChar, 20).Value = strlJefe_Inmediato
                End If
            End If
            If Validacion = "4" Then
                cms.CommandText = "select Codigo,nombres,apellidos,estado,Jefe_Inmediato as Jefe from Personal where Estado='A' EXCEPT select VH.Cod_Agente as Codigo,P.nombres,P.apellidos,P.estado,P.Jefe_Inmediato as Jefe from Validacion_Horario VH, Personal P where (Convert(date,VH.Fc_Ingreso) = @strlfcini)"
                If strlcodigo <> Nothing Then
                    cms.CommandText = "select Codigo,nombres,apellidos,estado,Jefe_Inmediato as Jefe from Personal where Estado='A' and codigo=@strlcodigo EXCEPT select VH.Cod_Agente as Codigo,P.nombres,P.apellidos,P.estado,P.Jefe_Inmediato as Jefe from Validacion_Horario VH, Personal P where (Convert(date,VH.Fc_Ingreso) = @strlfcini)"
                    cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
                End If
                If strlJefe_Inmediato <> Nothing Then
                    cms.CommandText = "select Codigo,nombres,apellidos,estado,Jefe_Inmediato as Jefe from Personal where Estado='A' and Jefe_Inmediato=@strlJefe_Inmediato EXCEPT select VH.Cod_Agente as Codigo,P.nombres,P.apellidos,P.estado,P.Jefe_Inmediato as Jefe from Validacion_Horario VH, Personal P where (Convert(date,VH.Fc_Ingreso) = @strlfcini)"
                    cms.Parameters.Add("@strlJefe_Inmediato", SqlDbType.VarChar, 20).Value = strlJefe_Inmediato
                End If
            End If

            If Validacion = "5" Then
                cms.CommandText = "select P.codigo,P.nombres,P.apellidos,P.idarea,A.area,P.Jefe_Inmediato,N.fcnovedad,CASE WHEN(descripcioninasistencia = 'Ausencia injustificada') THEN 'NO' ELSE 'SI' END as Laboro ,TI.descripcioninasistencia from Personal P inner join Area A on P.idarea = A.idarea inner join Novedad N on N.cod= P.codigo inner join Tipoinasistencia TI on TI.idinasistencia = N.idtiponovedad where (N.fcnovedad Between @strlfcini and @strlfcfin) and (TI.descripcioninasistencia = 'Ausencia injustificada' or TI.descripcioninasistencia = 'Retardo')"
                If strlcodigo <> Nothing Then
                    cms.CommandText = "select P.codigo,P.nombres,P.apellidos,P.idarea,A.area,P.Jefe_Inmediato,N.fcnovedad,CASE WHEN(descripcioninasistencia = 'Ausencia injustificada') THEN 'NO' ELSE 'SI' END as Laboro ,TI.descripcioninasistencia from Personal P inner join Area A on P.idarea = A.idarea inner join Novedad N on N.cod= P.codigo inner join Tipoinasistencia TI on TI.idinasistencia = N.idtiponovedad where (N.fcnovedad Between @strlfcini and @strlfcfin) and (TI.descripcioninasistencia = 'Ausencia injustificada' or TI.descripcioninasistencia = 'Retardo') and (P.codigo=@strlcodigo) "
                    cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
                End If
                If strlJefe_Inmediato <> Nothing Then
                    cms.CommandText = "select P.codigo,P.nombres,P.apellidos,P.idarea,A.area,P.Jefe_Inmediato,N.fcnovedad,CASE WHEN(descripcioninasistencia = 'Ausencia injustificada') THEN 'NO' ELSE 'SI' END as Laboro ,TI.descripcioninasistencia from Personal P inner join Area A on P.idarea = A.idarea inner join Novedad N on N.cod= P.codigo inner join Tipoinasistencia TI on TI.idinasistencia = N.idtiponovedad where (N.fcnovedad Between @strlfcini and @strlfcfin) and (TI.descripcioninasistencia = 'Ausencia injustificada' or TI.descripcioninasistencia = 'Retardo') and (P.Jefe_Inmediato=@strlJefe_Inmediato)"
                    cms.Parameters.Add("@strlJefe_Inmediato", SqlDbType.VarChar, 20).Value = strlJefe_Inmediato
                End If
            End If

            If Validacion = "6" Then
                cms.CommandText = "select VH.cod_agente,P.nombres,P.apellidos,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre as [Tipo_Horario],P.Jefe_Inmediato,P.Segmento from Validacion_Horario VH  left join (select idusuario, fcingreso,fcsalida,Case when Tipo_Horario=4 then 3 else Tipo_Horario end as Tipo_Horario from Centinela ) C on VH.Cod_Agente = C.idusuario  and C.Tipo_Horario = VH.Tipo_Horario and convert(Date,C.fcingreso)=CONVERT(date,VH.Fc_Ingreso)  inner join personal P on C.idusuario = P.codigo inner join Validacion_Horario_Complemento V on VH.Tipo_Horario = V.Cod_Validacion_Horario_Complemento where  (C.fcingreso Between @strlfcini and @strlfcfin ) group by P.nombres,P.apellidos,VH.cod_agente,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre ,P.Jefe_Inmediato,P.Segmento order by VH.Cod_Agente"
                If strlcodigo <> Nothing Then
                    cms.CommandText = "select VH.cod_agente,P.nombres,P.apellidos,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre as [Tipo_Horario],P.Jefe_Inmediato,P.Segmento from Validacion_Horario VH  left join (select idusuario, fcingreso,fcsalida,Case when Tipo_Horario=4 then 3 else Tipo_Horario end as Tipo_Horario from Centinela ) C on VH.Cod_Agente = C.idusuario and C.Tipo_Horario = VH.Tipo_Horario and convert(Date,C.fcingreso)=CONVERT(date,VH.Fc_Ingreso)  inner join personal P on C.idusuario = P.codigo inner join Validacion_Horario_Complemento V on VH.Tipo_Horario = V.Cod_Validacion_Horario_Complemento where  (C.fcingreso Between @strlfcini and @strlfcfin ) and Cod_Agente=@strlcodigo group by P.nombres,P.apellidos,VH.cod_agente,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre ,P.Jefe_Inmediato,P.Segmento order by VH.Cod_Agente"
                    cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 20).Value = strlcodigo
                End If
                If strlJefe_Inmediato <> Nothing Then
                    cms.CommandText = "select VH.cod_agente,P.nombres,P.apellidos,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre as [Tipo_Horario],P.Jefe_Inmediato,P.Segmento from Validacion_Horario VH  left join (select idusuario, fcingreso,fcsalida,Case when Tipo_Horario=4 then 3 else Tipo_Horario end as Tipo_Horario from Centinela ) C on VH.Cod_Agente = C.idusuario and C.Tipo_Horario = VH.Tipo_Horario and convert(Date,C.fcingreso)=CONVERT(date,VH.Fc_Ingreso)  inner join personal P on C.idusuario = P.codigo inner join Validacion_Horario_Complemento V on VH.Tipo_Horario = V.Cod_Validacion_Horario_Complemento where  (C.fcingreso Between @strlfcini and @strlfcfin ) and P.Jefe_Inmediato=@strlJefe_Inmediato group by P.nombres,P.apellidos,VH.cod_agente,VH.Fc_Ingreso,VH.Fc_Salida,C.fcingreso,C.fcsalida,V.Nombre ,P.Jefe_Inmediato,P.Segmento order by VH.Cod_Agente"
                    cms.Parameters.Add("@strlJefe_Inmediato", SqlDbType.VarChar, 20).Value = strlJefe_Inmediato
                End If
            End If
            cms.Parameters.Add("@strlfcini", SqlDbType.Date).Value = strlfcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.Date).Value = strlfcfin
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function




    'Public Function Consulta_Malla_Turno() As DataSet
    '    Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
    '    Dim dtsrecepcion As New DataSet
    '    Dim dtarecepcion As SqlClient.SqlDataAdapter
    '    Dim cms As New SqlClient.SqlCommand
    '    Try
    '        cn.Open()
    '        cms.CommandText = "select top 30 * from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where VH.Cod_Agente = @strlcodigo and Convert(Date,Fc_Ingreso) >= CONVERT(Date,GETDATE()) and VH.Estado=1 order by VH.Fc_Ingreso"
    '        cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
    '        cms.Connection = cn
    '        dtarecepcion = New SqlClient.SqlDataAdapter(cms)
    '        dtarecepcion.Fill(dtsrecepcion)
    '        Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
    '        Return dtsrecepcion
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Function
    Public Function consultacodigonovedad() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * from Cons_novedad order by idreg desc"
            If strlcodigo <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where cod=@strlcodigo and Convert(date,fcregistro)=@strlfcregistro order by idreg desc"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
                cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = Me.strlfcregistro
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("fcnovedad") Is System.DBNull.Value Then
                    strlfcnovedad = " "
                Else
                    strlfcnovedad = dtsrecepcion.Tables(0).Rows(0).Item("fcnovedad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("idtiponovedad") Is System.DBNull.Value Then
                    strltiponov = " "
                Else
                    strltiponov = dtsrecepcion.Tables(0).Rows(0).Item("idtiponovedad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("dias") Is System.DBNull.Value Then
                    strldianov = " "
                Else
                    strldianov = dtsrecepcion.Tables(0).Rows(0).Item("dias")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("horas") Is System.DBNull.Value Then
                    strlhoranov = " "
                Else
                    strlhoranov = dtsrecepcion.Tables(0).Rows(0).Item("horas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strlestado = " "
                Else
                    strlestado = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("repone") Is System.DBNull.Value Then
                    strlrepone = "0"
                Else
                    strlrepone = dtsrecepcion.Tables(0).Rows(0).Item("repone")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("reportanom") Is System.DBNull.Value Then
                    strlreporta = "0"
                Else
                    strlreporta = dtsrecepcion.Tables(0).Rows(0).Item("reportanom")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipificacion") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("tipificacion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("descripcion") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("descripcion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("mesreporte") Is System.DBNull.Value Then
                    strlmesreporte = " "
                Else
                    strlmesreporte = dtsrecepcion.Tables(0).Rows(0).Item("mesreporte")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Aprobacion") Is System.DBNull.Value Then
                    strlAprobacion = " "
                Else
                    strlAprobacion = dtsrecepcion.Tables(0).Rows(0).Item("Aprobacion")
                End If
            End If
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub agregarnoaprobacion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlFc_Aprueba = Now

            cms.CommandText = "Update novedad set Aprobacion='Anulado',Fc_Aprueba=@strlFc_Aprueba,Id_Usuario_Aprueba=@strlidusuario where idreg=@strlid and Convert(date,fcregistro)=@strlfcregistro"
            cms.Parameters.Add("@strlid", SqlDbType.Decimal).Value = Me.strlid
            cms.Parameters.Add("@strlfcregistro", SqlDbType.Date).Value = Me.strlfcregistro
            cms.Parameters.Add("@strlFc_Aprueba", SqlDbType.Date).Value = Me.strlFc_Aprueba
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.idusuario

            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub agregaraprobacion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlFc_Aprueba = Now

            cms.CommandText = "Update novedad set Aprobacion='Aprobado',Fc_Aprueba=@strlFc_Aprueba,Id_Usuario_Aprueba=@strlidusuario where idreg=@strlid and Convert(date,fcregistro)=@strlfcregistro"
            cms.Parameters.Add("@strlid", SqlDbType.Decimal).Value = Me.strlid
            cms.Parameters.Add("@strlfcregistro", SqlDbType.Date).Value = Me.strlfcregistro
            cms.Parameters.Add("@strlFc_Aprueba", SqlDbType.Date).Value = Me.strlFc_Aprueba
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.idusuario

            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function consultarfechaalerta()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * from Cons_novedad where (CONVERT(date,fcnovedad) Between @strlfcini and @strlfcfin) and order by idreg desc"
            If strlcodigo <> Nothing Then
                cms.CommandText = "SELECT * from Cons_novedad where (CONVERT(date,fcnovedad) Between @strlfcini and @strlfcfin) and cod=@strlcodigo order by idreg desc"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            End If
            cms.Parameters.Add("@strlfcini", SqlDbType.Date).Value = strlfcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.Date).Value = strlfcfin

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me.intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("fcnovedad") Is System.DBNull.Value Then
                    strlfcnovedad = " "
                Else
                    strlfcnovedad = dts.Tables(0).Rows(0).Item("fcnovedad")
                End If
                If dts.Tables(0).Rows(0).Item("idtiponovedad") Is System.DBNull.Value Then
                    strltiponov = " "
                Else
                    strltiponov = dts.Tables(0).Rows(0).Item("idtiponovedad")
                End If
                If dts.Tables(0).Rows(0).Item("dias") Is System.DBNull.Value Then
                    strldianov = " "
                Else
                    strldianov = dts.Tables(0).Rows(0).Item("dias")
                End If
                If dts.Tables(0).Rows(0).Item("horas") Is System.DBNull.Value Then
                    strlhoranov = " "
                Else
                    strlhoranov = dts.Tables(0).Rows(0).Item("horas")
                End If
                If dts.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strlestado = " "
                Else
                    strlestado = dts.Tables(0).Rows(0).Item("estado")
                End If
                If dts.Tables(0).Rows(0).Item("repone") Is System.DBNull.Value Then
                    strlrepone = "0"
                Else
                    strlrepone = dts.Tables(0).Rows(0).Item("repone")
                End If
                If dts.Tables(0).Rows(0).Item("reportanom") Is System.DBNull.Value Then
                    strlreporta = "0"
                Else
                    strlreporta = dts.Tables(0).Rows(0).Item("reportanom")
                End If
                If dts.Tables(0).Rows(0).Item("tipificacion") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dts.Tables(0).Rows(0).Item("tipificacion")
                End If
                If dts.Tables(0).Rows(0).Item("descripcion") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dts.Tables(0).Rows(0).Item("descripcion")
                End If
                If dts.Tables(0).Rows(0).Item("mesreporte") Is System.DBNull.Value Then
                    strlmesreporte = " "
                Else
                    strlmesreporte = dts.Tables(0).Rows(0).Item("mesreporte")
                End If
                If dts.Tables(0).Rows(0).Item("Aprobacion") Is System.DBNull.Value Then
                    strlAprobacion = " "
                Else
                    strlAprobacion = dts.Tables(0).Rows(0).Item("Aprobacion")
                End If
            End If
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Sub excel()
        Using ConexionE As New OleDbConnection(_Fc_ruta)

            Dim Comando As New OleDbCommand
            Comando.CommandText = "SELECT '' as Cod_Validacion_Horario,'" + fecha + "' as FcReg,'" + idusuario + "' as Id_Usuario,Cod_Agente,Fc_Ingreso,Fc_Salida,Estado, '' as Id_Usuario_Estado,Tipo_Horario,Jefe_Inmediato,segmento FROM [Malla$]"
            Comando.Connection = ConexionE
            Dim Adaptador As New OleDbDataAdapter
            Adaptador.SelectCommand = Comando
            Adaptador.Fill(DteXCEL)
            Dim listaux As New List(Of DataRow)

            For Each dr As DataRow In DteXCEL.Rows

                If dr("Cod_Agente").ToString = "" Then
                    listaux.Add(dr)
                End If

            Next

            For Each dr As DataRow In listaux

                DteXCEL.Rows.Remove(dr)

            Next
            intcantidad = DteXCEL.Rows.Count
            ConexionE.Close()
        End Using
    End Sub
    Public Function Malla()
        If _Validacion = 2 Then
            excel()
        End If
        If _Validacion = 1 Then
            excel()
            Return DteXCEL
            Exit Function
        End If
        intcantidad = DteXCEL.Rows.Count
        Using Conexion As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
            Conexion.Open()
            Using bulkCopy As New SqlClient.SqlBulkCopy(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                bulkCopy.DestinationTableName = "Validacion_Horario"


                For Each col As DataColumn In DteXCEL.Columns

                    bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName)

                Next
                bulkCopy.WriteToServer(DteXCEL)
            End Using
            Conexion.Close()
        End Using
        Return False
    End Function

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''' REGISTRO DE PAUSAS '''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''    
    Public Sub Registro_Ingreso_Malla_Turno()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            ''''Centinela
            If _Tipo_Horario = "3" Or _Tipo_Horario = "4" Then
                cms.CommandText = "INSERT INTO centinela(idusuario,fcingreso,IPEntrada,tipo_horario) values(@strlcodigo,@strlfcregistro,@strlIPEntrada,4)"
            End If
            ''''Break - 1
            If _Tipo_Horario = "5" Then
                cms.CommandText = "INSERT INTO centinela(idusuario,fcingreso,IPEntrada,tipo_horario) values(@strlcodigo,@strlfcregistro,@strlIPEntrada,5)"
            End If
            ''''Almuerzo
            If _Tipo_Horario = "6" Then
                cms.CommandText = "INSERT INTO centinela(idusuario,fcingreso,IPEntrada,tipo_horario) values(@strlcodigo,@strlfcregistro,@strlIPEntrada,6)"
            End If
            ''''Break - 2
            If _Tipo_Horario = "7" Then
                cms.CommandText = "INSERT INTO centinela(idusuario,fcingreso,IPEntrada,tipo_horario) values(@strlcodigo,@strlfcregistro,@strlIPEntrada,7)"
            End If
            ''''Capacitacion
            If _Tipo_Horario = "8" Then
                cms.CommandText = "INSERT INTO centinela(idusuario,fcingreso,IPEntrada,tipo_horario) values(@strlcodigo,@strlfcregistro,@strlIPEntrada,8)"
            End If
            ''''Pre-Turno
            If _Tipo_Horario = "9" Then
                cms.CommandText = "INSERT INTO centinela(idusuario,fcingreso,IPEntrada,tipo_horario) values(@strlcodigo,@strlfcregistro,@strlIPEntrada,9)"
            End If
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
            cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
            cms.Parameters.Add("@strlIPEntrada", SqlDbType.VarChar, 50).Value = strlIPEntrada
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub Registro_Salida_Malla_Turno()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            ''''Centinela
            If _Tipo_Horario = "3" Or _Tipo_Horario = "4" Then
                cms.CommandText = "UPDATE centinela SET fcsalida=@strlfcregistro,IPSalida=@strlIPSalida WHERE idusuario=@strlcodigo and fcsalida is null and tipo_horario=4"
            End If
            ''''Break - 1
            If _Tipo_Horario = "5" Then
                cms.CommandText = "UPDATE centinela SET fcsalida=@strlfcregistro,IPSalida=@strlIPSalida WHERE idusuario=@strlcodigo and fcsalida is null and tipo_horario=5"
            End If
            ''''Almuerzo
            If _Tipo_Horario = "6" Then
                cms.CommandText = "UPDATE centinela SET fcsalida=@strlfcregistro,IPSalida=@strlIPSalida WHERE idusuario=@strlcodigo and fcsalida is null and tipo_horario=6"
            End If
            ''''Break - 2
            If _Tipo_Horario = "7" Then
                cms.CommandText = "UPDATE centinela SET fcsalida=@strlfcregistro,IPSalida=@strlIPSalida WHERE idusuario=@strlcodigo and fcsalida is null and tipo_horario=7"
            End If
            ''''Capacitacion
            If _Tipo_Horario = "8" Then
                cms.CommandText = "UPDATE centinela SET fcsalida=@strlfcregistro,IPSalida=@strlIPSalida WHERE idusuario=@strlcodigo and fcsalida is null and tipo_horario=8"
            End If
            ''''Pre-Turno
            If _Tipo_Horario = "9" Then
                cms.CommandText = "UPDATE centinela SET fcsalida=@strlfcregistro,IPSalida=@strlIPSalida WHERE idusuario=@strlcodigo and fcsalida is null and tipo_horario=9"
            End If
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
            cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
            cms.Parameters.Add("@strlIPSalida", SqlDbType.VarChar, 50).Value = strlIPSalida
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function Consulta_Ultimos_Registros_Malla_turno() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Tipo_Horario = "1" Then
                cms.CommandText = "SELECT top 1 MAX(idcent), fcingreso, fcsalida FROM Centinela WHERE idusuario =@strlcodigo AND (CONVERT(date,fcingreso) = convert(date,@strlfcregistro)) GROUP BY idcent, fcingreso, fcsalida ORDeR by idcent desc"
            End If
            If _Tipo_Horario = "2" Then
                cms.CommandText = " SELECT top 1 MAX(idcent), fcingreso, fcsalida   FROM admin_cham.dbo.Centinela WHERE idusuario =@strlcodigo GROUP BY idcent, fcingreso, fcsalida ORDeR by idcent desc"
            End If
            ''''Centinela
            If _Tipo_Horario = "3" Or _Tipo_Horario = "4" Then
                cms.CommandText = "SELECT top 30 * from centinela where idusuario=@strlcodigo and (tipo_horario=4 or tipo_Horario=3) order by idcent desc"
            End If
            ''''Break - 1
            If _Tipo_Horario = "5" Then
                cms.CommandText = "SELECT top 30 * from centinela where idusuario=@strlcodigo and tipo_horario=5 order by idcent desc"
            End If
            ''''Almuerzo
            If _Tipo_Horario = "6" Then
                cms.CommandText = "SELECT top 30 * from centinela where idusuario=@strlcodigo and tipo_horario=6 order by idcent desc"
            End If
            ''''Break - 2
            If _Tipo_Horario = "7" Then
                cms.CommandText = "SELECT top 30 * from centinela where idusuario=@strlcodigo and tipo_horario=7 order by idcent desc"
            End If
            ''''Capacitacion
            If _Tipo_Horario = "8" Then
                cms.CommandText = "SELECT top 30 * from centinela where idusuario=@strlcodigo and tipo_horario=8 order by idcent desc"
            End If
            ''''Pre-Turno
            If _Tipo_Horario = "9" Then
                cms.CommandText = "SELECT top 30 * from centinela where idusuario=@strlcodigo and tipo_horario=9 order by idcent desc"
            End If
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo

            If strlfcregistro = Nothing Then
                cms.Parameters.AddWithValue("@strlfcregistro", DBNull.Value)
            Else
                cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
            End If

            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            intcantidad = dtsrecepcion.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("fcingreso") Is DBNull.Value Then
                    strlfcing = ""
                Else
                    strlfcing = dtsrecepcion.Tables(0).Rows(0).Item("fcingreso")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fcsalida") Is DBNull.Value Then
                    strlfcfin = ""
                Else
                    strlfcfin = dtsrecepcion.Tables(0).Rows(0).Item("fcsalida")
                End If
            End If
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Registros_Ingreso_Salida_Validacion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            ''''Centinela
            If _Tipo_Horario = "3" Or _Tipo_Horario = "4" Then
                cms.CommandText = "SELECT * from centinela where idusuario=@strlcodigo and fcsalida is null and tipo_horario=4"
            End If
            ''''Break - 1
            If _Tipo_Horario = "5" Then
                cms.CommandText = "SELECT * from centinela where idusuario=@strlcodigo and fcsalida is null and tipo_horario=5"
            End If
            ''''Almuerzo
            If _Tipo_Horario = "6" Then
                cms.CommandText = "SELECT * from centinela where idusuario=@strlcodigo and fcsalida is null and tipo_horario=6"
            End If
            ''''Break - 2
            If _Tipo_Horario = "7" Then
                cms.CommandText = "SELECT * from centinela where idusuario=@strlcodigo and fcsalida is null and tipo_horario=7"
            End If
            ''''Capacitacion
            If _Tipo_Horario = "8" Then
                cms.CommandText = "SELECT * from centinela where idusuario=@strlcodigo and fcsalida is null and tipo_horario=8"
            End If
            ''''Pre-Turno
            If _Tipo_Horario = "9" Then
                cms.CommandText = "SELECT * from centinela where idusuario=@strlcodigo and fcsalida is null and tipo_horario=9"
            End If
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            intcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Mallas_Turno()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Tipo_Horario = "1" Then
                cms.CommandText = "select Fc_Salida from Validacion_Horario where Cod_Agente=@strlcodigo and convert(Date,Fc_Salida) = convert(Date,@strlfcregistro)"
            End If
            ''''Centinela
            If _Tipo_Horario = "3" Or _Tipo_Horario = "4" Then
                cms.CommandText = "select top 30 * from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where VH.Cod_Agente = @strlcodigo and Convert(Date,Fc_Ingreso) >= CONVERT(Date,GETDATE()) and VH.Estado=1 and (VH.Tipo_Horario=2 or VH.Tipo_Horario=3 or VH.Tipo_Horario=4 or VH.Tipo_Horario=13 or VH.Tipo_Horario=15) order by VH.Fc_Ingreso"
            End If
            ''''Break - 1
            If _Tipo_Horario = "5" Then
                cms.CommandText = "select top 30 * from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where VH.Cod_Agente = @strlcodigo and Convert(Date,Fc_Ingreso) >= CONVERT(Date,GETDATE()) and VH.Estado=1 and  VH.tipo_horario=5 order by VH.Fc_Ingreso"
            End If
            ''''Almuerzo
            If _Tipo_Horario = "6" Then
                cms.CommandText = "select top 30 * from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where VH.Cod_Agente = @strlcodigo and Convert(Date,Fc_Ingreso) >= CONVERT(Date,GETDATE()) and VH.Estado=1 and  VH.tipo_horario=6 order by VH.Fc_Ingreso"
            End If
            ''''Break - 2
            If _Tipo_Horario = "7" Then
                cms.CommandText = "select top 30 * from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where VH.Cod_Agente = @strlcodigo and Convert(Date,Fc_Ingreso) >= CONVERT(Date,GETDATE()) and VH.Estado=1 and  VH.tipo_horario=7 order by VH.Fc_Ingreso"
            End If
            ''''Capacitacion
            If _Tipo_Horario = "8" Then
                cms.CommandText = "select top 30 * from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where VH.Cod_Agente = @strlcodigo and Convert(Date,Fc_Ingreso) >= CONVERT(Date,GETDATE()) and VH.Estado=1 and  VH.tipo_horario=8 order by VH.Fc_Ingreso"
            End If
            ''''Pre-Turno
            If _Tipo_Horario = "9" Then
                cms.CommandText = "select top 30 * from Validacion_Horario VH inner join Validacion_Horario_Complemento VHC on VH.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where VH.Cod_Agente = @strlcodigo and Convert(Date,Fc_Ingreso) >= CONVERT(Date,GETDATE()) and VH.Estado=1 and  VH.tipo_horario=9 order by VH.Fc_Ingreso"
            End If
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo

            If strlfcregistro = Nothing Then
                cms.Parameters.AddWithValue("@strlfcregistro", DBNull.Value)
            Else
                cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = strlfcregistro
            End If

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Fc_Salida") Is DBNull.Value Then
                    strlfcretiro = ""
                Else
                    strlfcretiro = dts.Tables(0).Rows(0).Item("Fc_Salida")
                End If
            End If
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''' CONSULTA GENERAL TIEMPOS EN PAUSA ''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
    Public Function consultatotalcentinela() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Con.idcent,Con.idusuario as Codigo,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,MAX(Con.fcingreso) as 'FcIngreso', MAX(Con.fcsalida) as 'FcSalida',VH.Fc_Ingreso as 'FcIngreso Programada',VH.Fc_Salida  as 'FcSalida Programada',Con.IPEntrada,Con.IPSalida,Con.Nombre frm (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo) Con inner join Validacion_Horario VH on ((Con.Tipo_Horario = VH.Tipo_Horario)and(Convert(date,Con.fcingreso)=Convert(date,VH.Fc_Ingreso))and(Con.idusuario=VH.Cod_Agente)) group by Con.idcent,Con.idusuario,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,Con.fcingreso,Con.fcsalida,VH.Fc_Ingreso,VH.Fc_Salida,Con.IPEntrada,Con.IPSalida,Con.Nombre"
            If strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "select T4.idcent,T4.idusuario as Codigo,T4.nombres,T4.apellidos,T4.cargo,T4.grupo,MAX(T4.fcingreso) as 'FcIngreso Centinela',MAX(T4.fcsalida) as 'FcSalida Centinela',MAX(T5.fcingreso) as 'FcIngreso Break 1',MAX(T5.fcsalida) as 'FcSalida Break 1',MAX(T6.fcingreso) as 'FcIngreso Almuerzo',MAX(T6.fcsalida) as 'FcSalida Almuerzo',MAX(T7.fcingreso) as 'FcIngreso Break 2',MAX(T7.fcsalida) as 'FcSalida Break 2',MAX(T8.fcingreso) as 'FcIngreso Capacitacion',MAX(T8.fcsalida) as 'FcSalida Capacitacion',MAX(T9.fcingreso) as 'FcIngreso Pre-Turno',MAX(T9.fcsalida) as 'FcSalida Pre-Turno' from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where C.Tipo_Horario=4) T4 left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=5) T5 on ((T4.idusuario=T5.idusuario) and (T4.Fecha=T5.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=6) T6 on ((T4.idusuario=T6.idusuario) and (T4.Fecha=T6.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=7) T7 on ((T4.idusuario=T7.idusuario) and (T4.Fecha=T7.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=8) T8 on ((T4.idusuario=T8.idusuario) and (T4.Fecha=T8.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=9) T9 on ((T4.idusuario=T9.idusuario) and (T4.Fecha=T9.Fecha)) where convert(date,T4.fcingreso) >= @strlfcini and convert(date,T4.fcingreso) <= @strlfcfin group by T4.idcent,T4.idusuario,T4.nombres,T4.apellidos,T4.cargo,T4.grupo,T4.fcingreso,T4.fcsalida,T5.fcingreso,T5.fcsalida,T6.fcingreso,T6.fcsalida,T7.fcingreso,T7.fcsalida,T8.fcingreso,T8.fcsalida,T9.fcingreso,T9.fcsalida"
                cms.Parameters.Add("@strlfcini", SqlDbType.Date).Value = strlfcini
                cms.Parameters.Add("@strlfcfin", SqlDbType.Date).Value = strlfcfin
            End If
            If _Tipo_Horario <> Nothing Then
                cms.CommandText = "select Con.idcent,Con.idusuario as Codigo,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,MAX(Con.fcingreso) as 'FcIngreso', MAX(Con.fcsalida) as 'FcSalida',VH.Fc_Ingreso as 'FcIngreso Programada',VH.Fc_Salida  as 'FcSalida Programada',Con.IPEntrada,Con.IPSalida,Con.Nombre from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where C.tipo_horario=@strltipo_horario) Con inner join Validacion_Horario VH on ((Con.Tipo_Horario = VH.Tipo_Horario)and(Convert(date,Con.fcingreso)=Convert(date,VH.Fc_Ingreso))and(Con.idusuario=VH.Cod_Agente)) group by Con.idcent,Con.idusuario,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,Con.fcingreso,Con.fcsalida,VH.Fc_Ingreso,VH.Fc_Salida,Con.IPEntrada,Con.IPSalida,Con.Nombre"
                cms.Parameters.Add("@strltipo_horario", SqlDbType.VarChar, 50).Value = _Tipo_Horario
            End If
            If _Tipo_Horario <> Nothing And strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "select Con.idcent,Con.idusuario as Codigo,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,MAX(Con.fcingreso) as 'FcIngreso', MAX(Con.fcsalida) as 'FcSalida',VH.Fc_Ingreso as 'FcIngreso Programada',VH.Fc_Salida  as 'FcSalida Programada',Con.IPEntrada,Con.IPSalida,Con.Nombre from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where C.tipo_horario=@strltipo_horario) Con inner join Validacion_Horario VH on ((Con.Tipo_Horario = VH.Tipo_Horario)and(Convert(date,Con.fcingreso)=Convert(date,VH.Fc_Ingreso))and(Con.idusuario=VH.Cod_Agente)) where convert(date,Con.fcingreso) >= @strlfcini  and convert(date,Con.fcingreso) <= @strlfcfin group by Con.idcent,Con.idusuario,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,Con.fcingreso,Con.fcsalida,VH.Fc_Ingreso,VH.Fc_Salida,Con.IPEntrada,Con.IPSalida,Con.Nombre"
            End If
            If strlgrupo <> Nothing Then
                cms.CommandText = "select T4.idcent,T4.idusuario as Codigo,T4.nombres,T4.apellidos,T4.cargo,T4.grupo,MAX(T4.fcingreso) as 'FcIngreso Centinela',MAX(T4.fcsalida) as 'FcSalida Centinela',MAX(T5.fcingreso) as 'FcIngreso Break 1',MAX(T5.fcsalida) as 'FcSalida Break 1',MAX(T6.fcingreso) as 'FcIngreso Almuerzo',MAX(T6.fcsalida) as 'FcSalida Almuerzo',MAX(T7.fcingreso) as 'FcIngreso Break 2',MAX(T7.fcsalida) as 'FcSalida Break 2',MAX(T8.fcingreso) as 'FcIngreso Capacitacion',MAX(T8.fcsalida) as 'FcSalida Capacitacion',MAX(T9.fcingreso) as 'FcIngreso Pre-Turno',MAX(T9.fcsalida) as 'FcSalida Pre-Turno' from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where C.Tipo_Horario=4) T4 left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=5) T5 on ((T4.idusuario=T5.idusuario) and (T4.Fecha=T5.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=6) T6 on ((T4.idusuario=T6.idusuario) and (T4.Fecha=T6.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=7) T7 on ((T4.idusuario=T7.idusuario) and (T4.Fecha=T7.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=8) T8 on ((T4.idusuario=T8.idusuario) and (T4.Fecha=T8.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=9) T9 on ((T4.idusuario=T9.idusuario) and (T4.Fecha=T9.Fecha)) where T4.grupo=@grupo group by T4.idcent,T4.idusuario,T4.nombres,T4.apellidos,T4.cargo,T4.grupo,T4.fcingreso,T4.fcsalida,T5.fcingreso,T5.fcsalida,T6.fcingreso,T6.fcsalida,T7.fcingreso,T7.fcsalida,T8.fcingreso,T8.fcsalida,T9.fcingreso,T9.fcsalida"
                cms.Parameters.Add("@grupo", SqlDbType.VarChar, 50).Value = strlgrupo
            End If
            If strlgrupo <> Nothing And _Tipo_Horario <> Nothing Then
                cms.CommandText = "select Con.idcent,Con.idusuario as Codigo,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,MAX(Con.fcingreso) as 'FcIngreso', MAX(Con.fcsalida) as 'FcSalida',VH.Fc_Ingreso as 'FcIngreso Programada',VH.Fc_Salida  as 'FcSalida Programada',Con.IPEntrada,Con.IPSalida,Con.Nombre from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where P.grupo =@grupo and C.Tipo_Horario=@strltipo_horario) Con inner join Validacion_Horario VH on ((Con.Tipo_Horario = VH.Tipo_Horario)and(Convert(date,Con.fcingreso)=Convert(date,VH.Fc_Ingreso))and(Con.idusuario=VH.Cod_Agente)) group by Con.idcent,Con.idusuario,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,Con.fcingreso,Con.fcsalida,VH.Fc_Ingreso,VH.Fc_Salida,Con.IPEntrada,Con.IPSalida,Con.Nombre"
            End If
            If strlgrupo <> Nothing And strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "select T4.idcent,T4.idusuario as Codigo,T4.nombres,T4.apellidos,T4.Cargo_Cliente,T4.grupo,MAX(T4.fcingreso) as 'FcIngreso Centinela',MAX(T4.fcsalida) as 'FcSalida Centinela',MAX(T5.fcingreso) as 'FcIngreso Break 1',MAX(T5.fcsalida) as 'FcSalida Break 1',MAX(T6.fcingreso) as 'FcIngreso Almuerzo',MAX(T6.fcsalida) as 'FcSalida Almuerzo',MAX(T7.fcingreso) as 'FcIngreso Break 2',MAX(T7.fcsalida) as 'FcSalida Break 2',MAX(T8.fcingreso) as 'FcIngreso Capacitacion',MAX(T8.fcsalida) as 'FcSalida Capacitacion',MAX(T9.fcingreso) as 'FcIngreso Pre-Turno',MAX(T9.fcsalida) as 'FcSalida Pre-Turno' from (select C.*,P.nombres,P.apellidos,P.Cargo_Cliente,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where C.Tipo_Horario=4) T4 left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=5) T5 on ((T4.idusuario=T5.idusuario) and (T4.Fecha=T5.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=6) T6 on ((T4.idusuario=T6.idusuario) and (T4.Fecha=T6.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=7) T7 on ((T4.idusuario=T7.idusuario) and (T4.Fecha=T7.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=8) T8 on ((T4.idusuario=T8.idusuario) and (T4.Fecha=T8.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=9) T9 on ((T4.idusuario=T9.idusuario) and (T4.Fecha=T9.Fecha)) where T4.grupo=@grupo and convert(date,T4.fcingreso) >= @strlfcini and convert(date,T4.fcingreso) <= @strlfcfin group by T4.idcent,T4.idusuario,T4.nombres,T4.apellidos,T4.Cargo_Cliente,T4.grupo,T4.fcingreso,T4.fcsalida,T5.fcingreso,T5.fcsalida,T6.fcingreso,T6.fcsalida,T7.fcingreso,T7.fcsalida,T8.fcingreso,T8.fcsalida,T9.fcingreso,T9.fcsalida"
            End If
            If strlgrupo <> Nothing And _Tipo_Horario <> Nothing And strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "select Con.idcent,Con.idusuario as Codigo,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,MAX(Con.fcingreso) as 'FcIngreso', MAX(Con.fcsalida) as 'FcSalida',VH.Fc_Ingreso as 'FcIngreso Programada',VH.Fc_Salida  as 'FcSalida Programada',Con.IPEntrada,Con.IPSalida,Con.Nombre from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where P.grupo =@grupo and C.Tipo_Horario=@strltipo_horario) Con inner join Validacion_Horario VH on ((Con.Tipo_Horario = VH.Tipo_Horario)and(Convert(date,Con.fcingreso)=Convert(date,VH.Fc_Ingreso))and(Con.idusuario=VH.Cod_Agente)) where convert(date,Con.fcingreso) >= @strlfcini  and convert(date,Con.fcingreso) <= @strlfcfin group by Con.idcent,Con.idusuario,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,Con.fcingreso,Con.fcsalida,VH.Fc_Ingreso,VH.Fc_Salida,Con.IPEntrada,Con.IPSalida,Con.Nombre"
            End If
            If strlcodigo <> Nothing Then
                cms.CommandText = "select T4.idcent,T4.idusuario as Codigo,T4.nombres,T4.apellidos,T4.cargo,T4.grupo,MAX(T4.fcingreso) as 'FcIngreso Centinela',MAX(T4.fcsalida) as 'FcSalida Centinela',MAX(T5.fcingreso) as 'FcIngreso Break 1',MAX(T5.fcsalida) as 'FcSalida Break 1',MAX(T6.fcingreso) as 'FcIngreso Almuerzo',MAX(T6.fcsalida) as 'FcSalida Almuerzo',MAX(T7.fcingreso) as 'FcIngreso Break 2',MAX(T7.fcsalida) as 'FcSalida Break 2',MAX(T8.fcingreso) as 'FcIngreso Capacitacion',MAX(T8.fcsalida) as 'FcSalida Capacitacion',MAX(T9.fcingreso) as 'FcIngreso Pre-Turno',MAX(T9.fcsalida) as 'FcSalida Pre-Turno' from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where C.Tipo_Horario=4) T4 left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=5) T5 on ((T4.idusuario=T5.idusuario) and (T4.Fecha=T5.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=6) T6 on ((T4.idusuario=T6.idusuario) and (T4.Fecha=T6.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=7) T7 on ((T4.idusuario=T7.idusuario) and (T4.Fecha=T7.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=8) T8 on ((T4.idusuario=T8.idusuario) and (T4.Fecha=T8.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=9) T9 on ((T4.idusuario=T9.idusuario) and (T4.Fecha=T9.Fecha)) where T4.idusuario=@strlcodigo group by T4.idcent,T4.idusuario,T4.nombres,T4.apellidos,T4.cargo,T4.grupo,T4.fcingreso,T4.fcsalida,T5.fcingreso,T5.fcsalida,T6.fcingreso,T6.fcsalida,T7.fcingreso,T7.fcsalida,T8.fcingreso,T8.fcsalida,T9.fcingreso,T9.fcsalida"
                cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = strlcodigo
            End If
            If strlcodigo <> Nothing And _Tipo_Horario <> Nothing Then
                cms.CommandText = "select Con.idcent,Con.idusuario as Codigo,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,MAX(Con.fcingreso) as 'FcIngreso', MAX(Con.fcsalida) as 'FcSalida',VH.Fc_Ingreso as 'FcIngreso Programada',VH.Fc_Salida  as 'FcSalida Programada',Con.IPEntrada,Con.IPSalida,Con.Nombre from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where P.codigo=@strlcodigo and C.Tipo_Horario=@strltipo_horario) Con inner join Validacion_Horario VH on ((Con.Tipo_Horario = VH.Tipo_Horario)and(Convert(date,Con.fcingreso)=Convert(date,VH.Fc_Ingreso))and(Con.idusuario=VH.Cod_Agente)) group by Con.idcent,Con.idusuario,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,Con.fcingreso,Con.fcsalida,VH.Fc_Ingreso,VH.Fc_Salida,Con.IPEntrada,Con.IPSalida,Con.Nombre"
            End If
            If strlcodigo <> Nothing And strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "select T4.idcent,T4.idusuario as Codigo,T4.nombres,T4.apellidos,T4.cargo,T4.grupo,MAX(T4.fcingreso) as 'FcIngreso Centinela',MAX(T4.fcsalida) as 'FcSalida Centinela',MAX(T5.fcingreso) as 'FcIngreso Break 1',MAX(T5.fcsalida) as 'FcSalida Break 1',MAX(T6.fcingreso) as 'FcIngreso Almuerzo',MAX(T6.fcsalida) as 'FcSalida Almuerzo',MAX(T7.fcingreso) as 'FcIngreso Break 2',MAX(T7.fcsalida) as 'FcSalida Break 2',MAX(T8.fcingreso) as 'FcIngreso Capacitacion',MAX(T8.fcsalida) as 'FcSalida Capacitacion',MAX(T9.fcingreso) as 'FcIngreso Pre-Turno',MAX(T9.fcsalida) as 'FcSalida Pre-Turno' from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where C.Tipo_Horario=4) T4 left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=5) T5 on ((T4.idusuario=T5.idusuario) and (T4.Fecha=T5.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=6) T6 on ((T4.idusuario=T6.idusuario) and (T4.Fecha=T6.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=7) T7 on ((T4.idusuario=T7.idusuario) and (T4.Fecha=T7.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=8) T8 on ((T4.idusuario=T8.idusuario) and (T4.Fecha=T8.Fecha)) left join (select C.*,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento where C.Tipo_Horario=9) T9 on ((T4.idusuario=T9.idusuario) and (T4.Fecha=T9.Fecha)) where T4.idusuario=@strlcodigo and convert(date,T4.fcingreso) >= @strlfcini and convert(date,T4.fcingreso) <= @strlfcfin group by T4.idcent,T4.idusuario,T4.nombres,T4.apellidos,T4.cargo,T4.grupo,T4.fcingreso,T4.fcsalida,T5.fcingreso,T5.fcsalida,T6.fcingreso,T6.fcsalida,T7.fcingreso,T7.fcsalida,T8.fcingreso,T8.fcsalida,T9.fcingreso,T9.fcsalida"
            End If
            If strlcodigo <> Nothing And _Tipo_Horario <> Nothing And strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "select Con.idcent,Con.idusuario as Codigo,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,MAX(Con.fcingreso) as 'FcIngreso', MAX(Con.fcsalida) as 'FcSalida',VH.Fc_Ingreso as 'FcIngreso Programada',VH.Fc_Salida  as 'FcSalida Programada',Con.IPEntrada,Con.IPSalida,Con.Nombre from (select C.*,P.nombres,P.apellidos,P.cargo,P.grupo,VHC.Nombre,Convert(date,C.fcingreso) as Fecha from Centinela C inner join Validacion_Horario_Complemento VHC on C.Tipo_Horario = VHC.Cod_Validacion_Horario_Complemento inner join personal P on C.idusuario =P.codigo where P.codigo=@strlcodigo and C.Tipo_Horario=@strltipo_horario) Con inner join Validacion_Horario VH on ((Con.Tipo_Horario = VH.Tipo_Horario)and(Convert(date,Con.fcingreso)=Convert(date,VH.Fc_Ingreso))and(Con.idusuario=VH.Cod_Agente)) where convert(date,Con.fcingreso) >= @strlfcini  and convert(date,Con.fcingreso) <= @strlfcfin group by Con.idcent,Con.idusuario,Con.nombres,Con.apellidos,Con.cargo,Con.grupo,Con.fcingreso,Con.fcsalida,VH.Fc_Ingreso,VH.Fc_Salida,Con.IPEntrada,Con.IPSalida,Con.Nombre"
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Me.intcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_tipo_horario() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Cod_Validacion_Horario_Complemento,Nombre from Validacion_Horario_Complemento where nombre <> 'Laboral' group by Cod_Validacion_Horario_Complemento,Nombre order by Nombre,Cod_Validacion_Horario_Complemento"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    'La siguiente función se utiliza para carga de herramientas y consultas del modulo 
        Public Function Consulta_Estados_Usu_Pass() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = 1 Then
                cms.CommandText = "Select nombre,cod_estado_usu from  estado_usu where pertenece='Credenciales' order by nombre"
            End If
            If Validacion = 2 Then
                cms.CommandText = " select a.area,p.codigo,grupo,estado,documento,nombres+' '+apellidos as nombres, pc.Estado_General, Pc.Fecha_Acta from personal P inner join Area A on p.idarea=a.idarea left join Personal_Credenciales PC  on P.codigo=pc.Codigo where p.codigo =@_Id_Usuario"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = strlcodigo
            End If
            If Validacion = 3 Then
                cms.CommandText = "select * from personal_credenciales where codigo =@_Id_Usuario"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = strlcodigo
            End If
            If Validacion = 4 Then
                If Plataforma = "Red" Then
                    cms.CommandText = "select * from Estado_usu where pertenece='Estado_red' order by nombre "
                Else
                    cms.CommandText = "select * from Estado_usu where pertenece='Estado_Recurso' order by nombre "
                End If
            End If
            If Validacion = 5 Then
                cms.CommandText = "select * from Estado_usu where pertenece='Plataforma_Red' order by nombre "
            End If
            If Validacion = 6 Then
                cms.CommandText = "select * from Estado_usu where pertenece='Estado_Plataforma_Claro' order by nombre "
            End If
            If Validacion = 7 Then
                cms.CommandText = "Select Pc.Codigo,p.codigo_asignacion,pc.fc_reg ,pc.Id_Usuario ,e.Nombre as plataforma ,p.Estado_Plataforma,Usuario_Plataforma,Password_plataforma,Fc_Actualiza,Usuario_Actualiza,formato,fcreg from Plataforma P inner join Personal_Credenciales Pc on P.Fk_codnom =PC.Codigo INNER JOIN Estado_Usu E ON e.Cod_Estado_Usu=p.Fk_plataforma left join (select d2.* from Detalle_Plataforma d2 inner join (SELECT MAX(Id_Detalle_Plataforma) as Id_Detalle_Plataforma from Detalle_Plataforma group by Fk_Plataforma) as D1 on d1.Id_Detalle_Plataforma = d2.Id_Detalle_Plataforma) as  DP on dp.Fk_Plataforma=p.Codigo_Asignacion left join (select formato,fk_plataforma,fcreg  from solicitud_credenciales S2 inner join (SELECT MAX(codigo_solicitud) as Credencial from solicitud_credenciales group by fk_plataforma) as S1 on s1.Credencial  = s2.codigo_solicitud) S  on p.Codigo_Asignacion = s.fk_plataforma where pc.codigo=@codigo"
                cms.Parameters.Add("@codigo", SqlDbType.VarChar, 50).Value = strlcodigo
            End If
            If Validacion = 8 Then
                cms.CommandText = "Select Pc.Codigo,p.codigo_asignacion,pc.fc_reg ,pc.Id_Usuario ,e.Nombre as plataforma ,p.Estado_Plataforma,Usuario_Plataforma,Password_plataforma,Fc_Actualiza,Usuario_Actualiza,formato,fcreg from Plataforma P inner join Personal_Credenciales Pc on P.Fk_codnom =PC.Codigo INNER JOIN Estado_Usu E ON e.Cod_Estado_Usu=p.Fk_plataforma left join (select d2.* from Detalle_Plataforma d2 inner join (SELECT MAX(Id_Detalle_Plataforma) as Id_Detalle_Plataforma from Detalle_Plataforma group by Fk_Plataforma) as D1 on d1.Id_Detalle_Plataforma = d2.Id_Detalle_Plataforma) as  DP on dp.Fk_Plataforma=p.Codigo_Asignacion left join (select formato,fk_plataforma,fcreg  from solicitud_credenciales S2 inner join (SELECT MAX(codigo_solicitud) as Credencial from solicitud_credenciales group by fk_plataforma) as S1 on s1.Credencial  = s2.codigo_solicitud) S  on p.Codigo_Asignacion = s.fk_plataforma  where p.Fk_plataforma=@Plataforma and p.Estado_Plataforma=@Estado_P"
                cms.Parameters.Add("@Plataforma", SqlDbType.VarChar, 50).Value = _Plataforma
                cms.Parameters.Add("@Estado_P", SqlDbType.VarChar, 50).Value = _Estado_Plataforma
            End If


            If Validacion = 9 Then
                cms.CommandText = "select eu.Pertenece, p.*, a.area, pe.codigo, grupo, estado, documento, nombres+' '+apellidos as nombres, Pc.Fecha_Acta from plataforma p inner join Personal_Credenciales pc on pc.Codigo =p.Fk_codnom inner join personal pe on pe.codigo=pc.Codigo inner join Area A on pe.idarea=a.idarea inner join Estado_Usu Eu on Eu.Cod_Estado_Usu=p.Fk_plataforma  where p.Codigo_Asignacion =@plataforma"
                cms.Parameters.Add("@Plataforma", SqlDbType.VarChar, 50).Value = _Codigo_Atuliza
            End If
            If Validacion = 10 Then
                cms.CommandText = "select * from Plataforma where Fk_plataforma=@Plataforma and Fk_codnom =@_Id_Usuario"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = strlidusuario
                cms.Parameters.Add("@Plataforma", SqlDbType.VarChar, 50).Value = _Plataforma
            End If
            If Validacion = 11 Then
                If _Plataforma = 75 Then
                    cms.CommandText = "select Sc.*,plataforma.Password_plataforma from Solicitud_Credenciales AS Sc,PLATAFORMA as plataforma  where Sc.fk_plataforma=@_FkPlataforma and plataforma.Codigo_Asignacion=@_FkPlataforma"
                Else
                    cms.CommandText = "select * from Solicitud_Credenciales where fk_plataforma=@_FkPlataforma"
                End If
                cms.Parameters.Add("@_FkPlataforma", SqlDbType.BigInt).Value = _Codigo_Atuliza
            End If


            If Validacion = 12 Then
                cms.CommandText = "select * from Estado_usu where pertenece='Estado_General' order by nombre "
            End If
            If Validacion = 14 Then
                cms.CommandText = "SELECT * FROM Detalle_Plataforma WHERE Fk_Plataforma=@_FkPlataforma"
                cms.Parameters.Add("@_FkPlataforma", SqlDbType.BigInt).Value = _Codigo_Atuliza
            End If

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If Validacion = 2 Then
                    If dts.Tables(0).Rows(0).Item("area") Is DBNull.Value Then
                        strlarea = ""
                    Else
                        strlarea = dts.Tables(0).Rows(0).Item("area")
                    End If
                    If Not dts.Tables(0).Rows(0).Item("Fecha_Acta") Is DBNull.Value Then
                        _Fecha_Acta = dts.Tables(0).Rows(0).Item("Fecha_Acta")
                    End If
                    If dts.Tables(0).Rows(0).Item("codigo") Is DBNull.Value Then
                        strlcodigo = ""
                    Else
                        strlcodigo = dts.Tables(0).Rows(0).Item("codigo")
                    End If
                    If dts.Tables(0).Rows(0).Item("grupo") Is DBNull.Value Then
                        strlgrupo = ""
                    Else
                        strlgrupo = dts.Tables(0).Rows(0).Item("grupo")
                    End If
                    If dts.Tables(0).Rows(0).Item("Estado_General") Is DBNull.Value Then
                        strlestado = ""
                    Else
                        strlestado = dts.Tables(0).Rows(0).Item("Estado_General")
                    End If
                    If dts.Tables(0).Rows(0).Item("nombres") Is DBNull.Value Then
                        strlnombres = ""
                    Else
                        strlnombres = dts.Tables(0).Rows(0).Item("nombres")
                    End If
                    If dts.Tables(0).Rows(0).Item("documento") Is DBNull.Value Then
                        strldocumento = ""
                    Else
                        strldocumento = dts.Tables(0).Rows(0).Item("documento")
                    End If
                End If
                If Validacion = 9 Then
                    If dts.Tables(0).Rows(0).Item("area") Is DBNull.Value Then
                        strlarea = ""
                    Else
                        strlarea = dts.Tables(0).Rows(0).Item("area")
                    End If
                    If Not dts.Tables(0).Rows(0).Item("Fecha_Acta") Is DBNull.Value Then
                        _Fecha_Acta = dts.Tables(0).Rows(0).Item("Fecha_Acta")
                    End If
                    If dts.Tables(0).Rows(0).Item("codigo") Is DBNull.Value Then
                        strlcodigo = ""
                    Else
                        strlcodigo = dts.Tables(0).Rows(0).Item("codigo")
                    End If
                    If dts.Tables(0).Rows(0).Item("grupo") Is DBNull.Value Then
                        strlgrupo = ""
                    Else
                        strlgrupo = dts.Tables(0).Rows(0).Item("grupo")
                    End If
                    If dts.Tables(0).Rows(0).Item("Estado") Is DBNull.Value Then
                        strlestado = ""
                    Else
                        strlestado = dts.Tables(0).Rows(0).Item("Estado")
                    End If
                    If dts.Tables(0).Rows(0).Item("nombres") Is DBNull.Value Then
                        strlnombres = ""
                    Else
                        strlnombres = dts.Tables(0).Rows(0).Item("nombres")
                    End If
                    If dts.Tables(0).Rows(0).Item("documento") Is DBNull.Value Then
                        strldocumento = ""
                    Else
                        strldocumento = dts.Tables(0).Rows(0).Item("documento")
                    End If
                    If dts.Tables(0).Rows(0).Item("codigo_asignacion") Is DBNull.Value Then
                        _Codigo_Atuliza = ""
                    Else
                        _Codigo_Atuliza = dts.Tables(0).Rows(0).Item("codigo_asignacion")
                    End If
                    If dts.Tables(0).Rows(0).Item("fk_plataforma") Is DBNull.Value Then
                        _Plataforma = ""
                    Else
                        _Plataforma = dts.Tables(0).Rows(0).Item("fk_plataforma")
                    End If

                    If dts.Tables(0).Rows(0).Item("usuario_plataforma") Is DBNull.Value Then
                        _Usuario_Plataforma = ""
                    Else
                        _Usuario_Plataforma = dts.Tables(0).Rows(0).Item("usuario_plataforma")
                    End If
                    If dts.Tables(0).Rows(0).Item("password_plataforma") Is DBNull.Value Then
                        _Password_Plataforma = ""
                    Else
                        _Password_Plataforma = dts.Tables(0).Rows(0).Item("password_plataforma")
                    End If
                    If dts.Tables(0).Rows(0).Item("pertenece") Is DBNull.Value Then
                        strlapellidos = ""
                    Else
                        strlapellidos = dts.Tables(0).Rows(0).Item("pertenece")
                    End If
                    If dts.Tables(0).Rows(0).Item("Estado_Plataforma") Is DBNull.Value Then
                        _Estado_Plataforma = ""
                    Else
                        _Estado_Plataforma = dts.Tables(0).Rows(0).Item("Estado_Plataforma")
                    End If

                End If
            End If
            cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    'El siguiente método es para insertar los usuarios 
     Public Sub Ingresar_Datos_Usu_pass()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Dim Datos As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Try
            cn.Open()
            cms.CommandText = "insert into Personal_credenciales (Id_Usuario,fc_reg,codigo) values (@_Id_Usuario,@_Fecha_Creacion,@_Codigo)"
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@_Fecha_Creacion", SqlDbType.VarChar, 50).Value = _Fecha_Creacion
            cms.Parameters.Add("@_Codigo", SqlDbType.VarChar, 20).Value = strlcodigo
            cms.Connection = cn
            Datos = New SqlClient.SqlDataAdapter(cms)
            Datos.Fill(dts)
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    'El siguiente método es para insertar las plataformas y sus credenciales 
        Public Sub Ingresar_Plataforma()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Dim Datos As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Try
            cn.Open()
            cms.CommandText = "insert into Plataforma (Estado_plataforma,Fk_plataforma,usuario_plataforma,password_plataforma,fk_codnom) values (@_EstadoP,@_FkPlataforma,@_uPlataforma,@_pPlataforma,@_Id_Usuario) SELECT SCOPE_IDENTITY() as Cod"
            cms.Parameters.Add("@_EstadoP", SqlDbType.VarChar, 50).Value = Estado_Plataforma
            cms.Parameters.Add("@_FkPlataforma", SqlDbType.VarChar, 20).Value = _Plataforma
            cms.Parameters.Add("@_uPlataforma", SqlDbType.VarChar, 50).Value = _Usuario_Plataforma
            cms.Parameters.Add("@_pPlataforma", SqlDbType.VarChar, 50).Value = _Password_Plataforma
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@_Formato", SqlDbType.VarChar, 50).Value = _Formato
            cms.Connection = cn
            Datos = New SqlClient.SqlDataAdapter(cms)
            Datos.Fill(dts)

            If Formato <> Nothing Then
                cms.CommandText = "insert into Solicitud_Credenciales (usuarioregistra,formato,fk_plataforma) values (@Id_Usuario,@_Formato,@FkPlataforma) "
                cms.Parameters.Add("@fkplataforma", SqlDbType.VarChar, 50).Value = dts.Tables(0).Rows(0).Item("Cod")
                cms.Parameters.Add("@Id_Usuario", SqlDbType.VarChar, 50).Value = Usu_CRM
                cms.Connection = cn
                cms.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    'El siguiente método es para actualizar las plataformas
    'El siguiente método es para actualizar las plataformas
       Public Sub Actualizar_Plataforma()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Dim Datos As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Try
            cn.Open()
            cms.CommandText = "update  Plataforma set Estado_plataforma=@_EstadoP,password_plataforma=@_pPlataforma,Usuario_plataforma=@_uPlataforma where Fk_plataforma=@_FkPlataforma and codigo_asignacion=@_Codigo_A "
            cms.Parameters.Add("@_uPlataforma", SqlDbType.VarChar, 50).Value = _Usuario_Plataforma
            cms.Parameters.Add("@_pPlataforma", SqlDbType.VarChar, 50).Value = _Password_Plataforma
            If Validacion = 2 Then
                cms.CommandText = "update  Plataforma set Estado_plataforma=@_EstadoP,Password_plataforma=@_pPlataforma,Usuario_plataforma=@_uPlataforma where Fk_plataforma=@_FkPlataforma and codigo_asignacion=@_Codigo_A and Fk_codnom=@codnom"
                cms.Parameters.Add("@Codnom", SqlDbType.VarChar, 30).Value = codigo
            End If
            cms.Parameters.Add("@_EstadoP", SqlDbType.VarChar, 50).Value = Estado_Plataforma
            cms.Parameters.Add("@_FkPlataforma", SqlDbType.VarChar, 20).Value = _Plataforma
            cms.Parameters.Add("@_Codigo_A", SqlDbType.VarChar, 50).Value = _Codigo_Atuliza
            cms.Connection = cn
            cms.ExecuteNonQuery()
            Datos = New SqlClient.SqlDataAdapter(cms)
            Datos.Fill(dts)
            cms.CommandText = "Select * from plataforma where codigo_asignacion=@_Codigo_A "
            Datos = New SqlClient.SqlDataAdapter(cms)
            Datos.Fill(dts)
            If Formato <> Nothing And dts.Tables(0).Rows.Count > 0 Then
                cms.CommandText = "insert into Solicitud_Credenciales (usuarioregistra,formato,fk_plataforma) values (@_Id_Usuario,@_Formato,@_Codigo_A)"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = strlidusuario
                cms.Parameters.Add("@_Formato", SqlDbType.VarChar, 50).Value = _Formato
                cms.Connection = cn
                cms.ExecuteNonQuery()
            End If
            cms.CommandText = "insert into Detalle_Plataforma (Usuario_Actualiza,Estado_Plataforma,Fk_Plataforma) values (@UsuarioActualiza,@_EstadoP,@_Codigo_A)"
            cms.Parameters.Add("@UsuarioActualiza", SqlDbType.VarChar, 50).Value = idusuario
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    'Agrego el siguiente método para actualizar la plataforma en el formulario consultas
    Public Sub Actualizar_Plataforma2()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Dim dts As New DataSet
        Try
            cn.Open()
            cms.CommandText = "update  Plataforma set Estado_plataforma=@_EstadoP where Fk_plataforma=@_FkPlataforma and codigo_asignacion=@_Codigo_A "
            cms.Parameters.Add("@_EstadoP", SqlDbType.VarChar, 50).Value = Estado_Plataforma
            cms.Parameters.Add("@_FkPlataforma", SqlDbType.VarChar, 20).Value = _Plataforma
            cms.Parameters.Add("@_Codigo_A", SqlDbType.VarChar, 50).Value = _Codigo_Atuliza
            cms.Connection = cn
            cms.ExecuteNonQuery()
            cms.CommandText = "insert into Detalle_Plataforma (Usuario_Actualiza,Estado_Plataforma,Fk_Plataforma) values (@UsuarioActualiza,@_EstadoP,@_Codigo_A)"
            cms.Parameters.Add("@UsuarioActualiza", SqlDbType.VarChar, 50).Value = idusuario
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''' CARGA ARCHIVO PLANO SOPORTE '''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    'Declaro los siguientes dataset y datatable 
    Dim DtPersonalcredencial As DataSet
    Dim dts_Formato As DataSet
    Dim DtUsuariosEcxel As New DataTable
    Dim DtPlataforma As New DataTable
    Dim DtFormato As New DataTable
    Dim dt2 As New DataTable

    'Realizo el encapsulamiento de DtPlatafroma, dtformatoU y eDtUsuariosEcxel
    Public Property DtPlatafroma As DataTable
        Get
            Return DtPlataforma
        End Get
        Set(ByVal value As DataTable)
            DtPlataforma = value
        End Set
    End Property
    Public Property dtformatoU As DataTable
        Get
            Return DtFormato
        End Get
        Set(ByVal value As DataTable)
            DtFormato = value
        End Set
    End Property
    Public Property eDtUsuariosEcxel As DataTable
        Get
            Return DtUsuariosEcxel
        End Get
        Set(ByVal value As DataTable)
            DtUsuariosEcxel = value
        End Set
    End Property
    'Las funciones permiten la lectura de archivo plano y transferencia de registros a las tablas plataforma, personal_credenciales y solictud_credenciales de la base de datos admin 
    Public Function CargaUsuariosFormato()
        Try
            If _Validacion = 2 Then
                Validacion = 12
                UsuariosExcelTotal()
            End If
            If _Validacion = 1 Then
                Validacion = 12
                UsuariosExcelTotal()
                Return DtFormato
                Exit Function
            End If
            Using Conexion As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                Conexion.Open()
                Using bulkCopy As New SqlClient.SqlBulkCopy(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                    bulkCopy.DestinationTableName = "Solicitud_Credenciales"
                    For Each col As DataColumn In DtFormato.Columns
                        bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName)
                    Next
                    bulkCopy.WriteToServer(DtFormato)
                End Using
                Conexion.Close()
            End Using
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CargaUsuarios1()
        Try
            If _Validacion = 2 Then
                Validacion = 11
                UsuariosExcelTotal()
            End If
            If _Validacion = 1 Then
                Validacion = 11
                UsuariosExcelTotal()
                Return DtPlataforma
                Exit Function
            End If
            intcantidad = DtPlataforma.Rows.Count
            Using Conexion As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                Conexion.Open()
                Using bulkCopy As New SqlClient.SqlBulkCopy(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                    bulkCopy.DestinationTableName = "Plataforma"
                    For Each col As DataColumn In DtPlataforma.Columns
                        bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName)
                    Next
                    bulkCopy.WriteToServer(DtPlataforma)
                End Using
                Conexion.Close()
            End Using
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CargaUsuarios()
        Try
            If _Validacion = 2 Then
                Validacion = 10
                UsuariosExcelTotal()
            End If
            If _Validacion = 1 Then
                Validacion = 10
                UsuariosExcelTotal()
                Return DtUsuariosEcxel
                Exit Function
            End If
            Using Conexion As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                Conexion.Open()
                Using bulkCopy As New SqlClient.SqlBulkCopy(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                    bulkCopy.DestinationTableName = "personal_credenciales"
                    For Each col As DataColumn In DtUsuariosEcxel.Columns
                        bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName)
                    Next
                    bulkCopy.WriteToServer(DtUsuariosEcxel)
                End Using
                Conexion.Close()
            End Using
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function CargaExcel() As DataTable
        Try
            Dim dta As New DataTable
            Using ConexionE As New OleDbConnection(_Fc_ruta)
                Dim Comando As New OleDbCommand
                Comando.CommandText = "SELECT '' as codigo,Fk_plataforma,Estado_Plataforma,Usuario_Plataforma,Password_plataforma,Fk_codnom,formato FROM [Credenciales$]"
                If Validacion = 1 Then
                    Comando.CommandText = "SELECT top 50 codigo,Fk_plataforma,Estado_Plataforma,Usuario_Plataforma,Password_plataforma,Fk_codnom,formato FROM [CredencialesActu$]"
                End If

                Comando.Connection = ConexionE
                Dim Adaptador As New OleDbDataAdapter
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(dta)
                Dim listaux As New List(Of DataRow)
                Dim listaux2 As New List(Of DataRow)
                For Each dr As DataRow In dta.Rows
                    If dr("Fk_codnom").ToString = "" Then
                        listaux2.Add(dr)
                    End If
                Next
                For Each dr As DataRow In listaux2
                    dta.Rows.Remove(dr)
                Next
                ConexionE.Close()
                cantidad = dta.Rows.Count
            End Using
            Return dta
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'El metodo realzia multiples validaciones de informacion para enviar a las bases de datos
    Sub UsuariosExcelTotal()
        Try
            Using ConexionE As New OleDbConnection(_Fc_ruta)
                Dim Comando As New OleDbCommand
                If Validacion = 10 Then
                    Comando.CommandText = "SELECT '" + fecha + "' as fc_reg,'" + idusuario + "' as Id_Usuario,Fk_codnom as Codigo FROM [Credenciales$]"
                End If
                If Validacion = 11 Then
                    Comando.CommandText = "SELECT Fk_plataforma,Estado_Plataforma,Usuario_Plataforma,Password_plataforma,Fk_codnom FROM [Credenciales$]"
                End If
                If Validacion = 12 Then
                    Comando.CommandText = "SELECT Fk_plataforma,Estado_Plataforma,Usuario_Plataforma,Password_plataforma,Fk_codnom,formato FROM [Credenciales$]"
                End If
                Comando.Connection = ConexionE
                Dim Adaptador As New OleDbDataAdapter
                Adaptador.SelectCommand = Comando
                If Validacion = 10 Then
                    Adaptador.Fill(DtUsuariosEcxel)
                End If
                If Validacion = 11 Then
                    Adaptador.Fill(DtPlataforma)
                End If
                If Validacion = 12 Then
                    Adaptador.Fill(DtFormato)
                End If
                Dim listaux1, listaux2, listaux3 As New List(Of DataRow)
                Dim MyView As DataView
                Dim dtSinDuplicados As DataTable
                Dim valor1 As String
                Dim valor2 As String
                If Validacion = 10 Then
                    DtPersonalcredencial = Consulta_Personal_Credenciales()
                    MyView = New DataView(DtUsuariosEcxel)
                    dtSinDuplicados = MyView.ToTable(True, "codigo", "Id_Usuario", "fc_reg")
                    DtUsuariosEcxel = dtSinDuplicados
                    For Each row As DataRow In DtPersonalcredencial.Tables(0).Rows
                        valor2 = row("codigo").ToString
                        For Each dr As DataRow In DtUsuariosEcxel.Rows
                            valor1 = dr("codigo").ToString
                            If valor1 = valor2 Then
                                listaux1.Add(dr)
                            End If
                        Next
                    Next
                    For Each dr As DataRow In listaux1
                        DtUsuariosEcxel.Rows.Remove(dr)
                    Next
                    For Each dr As DataRow In DtUsuariosEcxel.Rows
                        If dr("Codigo").ToString = "" Then
                            listaux2.Add(dr)
                        End If
                    Next
                    For Each dr As DataRow In listaux2
                        DtUsuariosEcxel.Rows.Remove(dr)
                    Next
                End If
                If Validacion = 11 Then
                    For Each dr As DataRow In DtPlataforma.Rows
                        If dr("Fk_codnom").ToString = "" Then
                            listaux2.Add(dr)
                        End If
                    Next
                    For Each dr As DataRow In listaux2
                        DtPlataforma.Rows.Remove(dr)
                    Next
                    For Each dr As DataRow In DtPlataforma.Rows
                        codigo = dr("Fk_codnom").ToString
                        Plataforma = dr("Fk_plataforma").ToString
                        If codigo <> "" And Plataforma <> "" Then
                            Validacion = 5
                            If Consulta_Personal_Credenciales().Tables(0).Rows.Count > 0 Then
                                listaux1.Add(dr)
                            End If
                        End If
                    Next
                    For Each dr As DataRow In listaux1
                        DtPlataforma.Rows.Remove(dr)
                    Next
                End If
                If Validacion = 12 Then
                    Dim column As DataColumn
                    Dim row As DataRow
                    column = New DataColumn()
                    column.DataType = Type.GetType("System.String")
                    column.ColumnName = "fk_plataforma"
                    dt2.Columns.Add(column)
                    column = New DataColumn()
                    column.DataType = Type.GetType("System.String")
                    column.ColumnName = "formato"
                    dt2.Columns.Add(column)
                    column = New DataColumn()
                    column.DataType = Type.GetType("System.String")
                    column.ColumnName = "usuarioregistra"
                    dt2.Columns.Add(column)

                    For Each dr As DataRow In DtFormato.Rows
                        If dr("Fk_codnom").ToString = "" Then
                            listaux2.Add(dr)
                        End If
                    Next
                    For Each dr As DataRow In listaux2
                        DtFormato.Rows.Remove(dr)
                    Next

                    For Each dr As DataRow In DtFormato.Rows
                        codigo = dr("Fk_codnom").ToString
                        Plataforma = dr("Fk_plataforma").ToString
                        Validacion = 5
                        dts_Formato = Consulta_Personal_Credenciales()
                        If dts_Formato.Tables(0).Rows.Count = 0 Then
                            listaux1.Add(dr)
                        Else
                            row = dt2.NewRow()
                            row("fk_plataforma") = dts_Formato.Tables(0).Rows(0).Item("Codigo_Asignacion")
                            row("formato") = dr("formato").ToString
                            row("usuarioregistra") = idusuario
                            dt2.Rows.Add(row)
                        End If
                    Next
                    DtFormato = dt2
                    For Each dr As DataRow In DtFormato.Rows
                        If dr("formato").ToString = "" Then
                            listaux3.Add(dr)
                        End If
                    Next
                    For Each dr As DataRow In listaux3
                        DtFormato.Rows.Remove(dr)
                    Next

                End If
                ConexionE.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'La function o consulta realiza consultas a la base de datos para validar informacion
    Public Function Consulta_Personal_Credenciales() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * from personal_credenciales"
            If Validacion = 5 Then
                cms.CommandText = "SELECT * from Plataforma where fk_plataforma=@plataforma and fk_codnom=@codigo"
                cms.Parameters.Add("@Codigo", SqlDbType.VarChar, 20).Value = codigo
                cms.Parameters.Add("@plataforma", SqlDbType.BigInt).Value = Plataforma
                cms.Connection = cn
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_credenciales_usuario() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select P.*, EU.Nombre from Plataforma P inner join Estado_Usu EU on EU.Cod_Estado_Usu =P.Fk_plataforma where Fk_codnom=@codigo"
            cms.Parameters.Add("@codigo", SqlDbType.VarChar, 30).Value = codigo
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    ''''''''''''''''''''' Solicitud Modulo De Documento '''''''''''''''''''''
    Protected _ticket As Int32
    Protected _tipo_solicitud As String
    Protected _tipo_documento As String
    Protected _persona_solicita As String
    Protected _proceso As String
    Protected _Sub_proceso As String
    Protected _observacionn As String
    Protected _estadoo As String
    Protected _prioridad As String
    Protected _fecha_registro As String
    Protected _asignado As String
    Protected _comentario As String
    Protected _usuario_registra As String
    Protected _asigna As String

    Public Property ticket As Int32
        Get
            Return _ticket
        End Get
        Set(ByVal value As Int32)
            _ticket = value
        End Set
    End Property
    Public Property usuario_registra As String
        Get
            Return _usuario_registra
        End Get
        Set(ByVal value As String)
            _usuario_registra = value
        End Set
    End Property
    Public Property tipo_solicitud As String
        Get
            Return _tipo_solicitud
        End Get
        Set(ByVal value As String)
            _tipo_solicitud = value
        End Set
    End Property
    Public Property tipo_documento As String
        Get
            Return _tipo_documento
        End Get
        Set(ByVal value As String)
            _tipo_documento = value
        End Set
    End Property
    Public Property persona_solicita As String
        Get
            Return _persona_solicita
        End Get
        Set(ByVal value As String)
            _persona_solicita = value
        End Set
    End Property
    Public Property proceso As String
        Get
            Return _proceso
        End Get
        Set(ByVal value As String)
            _proceso = value
        End Set
    End Property
    Public Property Sub_proceso As String
        Get
            Return _Sub_proceso
        End Get
        Set(ByVal value As String)
            _Sub_proceso = value
        End Set
    End Property
    Public Property observacionn As String
        Get
            Return _observacionn
        End Get
        Set(ByVal value As String)
            _observacionn = value
        End Set
    End Property
    Public Property estadoo As String
        Get
            Return _estadoo
        End Get
        Set(ByVal value As String)
            _estadoo = value
        End Set
    End Property
    Public Property prioridad As String
        Get
            Return _prioridad
        End Get
        Set(ByVal value As String)
            _prioridad = value
        End Set
    End Property
    Public Property fecha_registro As String
        Get
            Return _fecha_registro
        End Get
        Set(ByVal value As String)
            _fecha_registro = value
        End Set
    End Property
    Public Property asignado As String
        Get
            Return _asignado
        End Get
        Set(ByVal value As String)
            _asignado = value
        End Set
    End Property
    Public Property asigna As String
        Get
            Return _asigna
        End Get
        Set(ByVal value As String)
            _asigna = value
        End Set
    End Property
    Public Property comentario As String
        Get
            Return _comentario
        End Get
        Set(ByVal value As String)
            _comentario = value
        End Set
    End Property
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''' Solicitud Modulo De Documento ''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub Registro_Solicitud_Documento()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "insert into Solicitud_Documento (Id_Usuario,Tipo_Solicitud,Tipo_Documento,Persona_Solicita,Proceso,Sub_Proceso,Observacion,Prioridad,Estado) values (@usuario,@tipo_solicitud,@tipo_documento,@persona_solicita,@proceso,@sub_proceso,@observacion,@prioridad,'Abierto')"
            cms.Parameters.Add("@usuario", SqlDbType.VarChar, 30).Value = usuario_registra
            cms.Parameters.Add("@tipo_solicitud", SqlDbType.VarChar, 40).Value = tipo_solicitud
            cms.Parameters.Add("@tipo_documento", SqlDbType.VarChar, 30).Value = tipo_documento
            cms.Parameters.Add("@persona_solicita", SqlDbType.VarChar, 80).Value = persona_solicita
            cms.Parameters.Add("@proceso", SqlDbType.VarChar, 30).Value = proceso
            cms.Parameters.Add("@sub_proceso", SqlDbType.VarChar, 30).Value = Sub_proceso
            cms.Parameters.Add("@observacion", SqlDbType.VarChar, 800).Value = observacionn
            cms.Parameters.Add("@prioridad", SqlDbType.VarChar, 10).Value = prioridad
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function Consulta_Todas_Solicitudes() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * from  Solicitud_Documento   where Estado = 'Abierto' order by Id_Solicitud_Documento desc "
            If _Validacion = "buscar_todos" Then
                cms.CommandText = "select * from solicitud_documento where  Estado <> 'Terminado' and id_usuario_asignado is not null"
            End If
            If _Validacion = "consultar_asignado" Then
                cms.CommandText = "select sd.Id_Solicitud_Documento,sd.Fc_Reg ,sd.Prioridad,sd.Observacion,sd.Persona_Solicita,sd.Tipo_Documento,sd.Proceso,sd.Sub_Proceso,sd.Estado,sd.Fc_Fin,ha.Id_Usuario_Asignado from Solicitud_Documento sd inner join Historial_Asignacion ha on sd.Id_Solicitud_Documento = ha.Id_Solicitud_Documento where ha.Id_Usuario_Asignado = @usu"
                cms.Parameters.Add("@usu", SqlDbType.VarChar, 50).Value = strlnombres
            End If
            If _Validacion = "filtros" Then
                If ticket <> Nothing Then 'consulta por el filtro de ticket
                    cms.CommandText = "SELECT * from  Solicitud_Documento where Id_Solicitud_Documento = @tiket"
                    cms.Parameters.Add("@tiket", SqlDbType.BigInt).Value = ticket
                End If
                If strlnombres <> Nothing Then 'consulta por el usuario
                    cms.CommandText = "SELECT * from  Solicitud_Documento where Id_usuario = @usuario"
                    cms.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = strlnombres
                End If
                If fecha_registro <> Nothing Then 'consulta por el filtro de fecha registro
                    cms.CommandText = "SELECT * from  Solicitud_Documento where convert(date,Fc_Reg) = @fecha order by Id_Solicitud_Documento desc"
                    cms.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha_registro
                End If
                If fcfin <> Nothing Then 'consulta por el filtro de fecha registro FIN
                    cms.CommandText = "SELECT * from  Solicitud_Documento where convert(date,Fc_Reg) <= @fecha_fin order by Id_Solicitud_Documento desc"
                    cms.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fcfin
                End If
                If asignado <> Nothing Then 'consulta por el filtro de prioridad
                    cms.CommandText = "SELECT * from  Solicitud_Documento where Prioridad = @prioridad order by Id_Solicitud_Documento desc"
                    cms.Parameters.Add("@prioridad", SqlDbType.VarChar, 50).Value = asignado
                End If
                If tipo_documento <> Nothing Then 'consulta por el filtro de Estado
                    cms.CommandText = "SELECT * from  Solicitud_Documento where Estado = @Estado  order by Id_Solicitud_Documento desc"
                    cms.Parameters.Add("@Estado", SqlDbType.VarChar, 50).Value = tipo_documento
                End If
                If strlfcfin <> Nothing And fecha_registro <> Nothing Then
                    cms.CommandText = "Select * from Solicitud_Documento where convert(date,fc_reg) >= @fecha and convert(date,fc_reg) <= @fecha_fin order by id_solicitud_documento"
                End If
                If strlfcfin <> Nothing And fecha_registro <> Nothing And tipo_documento <> Nothing Then
                    cms.CommandText = "SELECT * from  Solicitud_Documento where convert(date,Fc_Fin) = @fecha_fin and convert(date,Fc_Reg) = @fecha and Estado = @estado order by Id_Solicitud_Documento desc"
                End If
                If strlfcfin <> Nothing And fecha_registro <> Nothing And asigna <> Nothing Then
                    cms.CommandText = "SELECT * from  Solicitud_Documento where convert(date,Fc_Fin) = @fecha_fin and convert(date,Fc_Reg) = @fecha and Prioridad = @prioridad order by Id_Solicitud_Documento desc"
                End If
                If strlfcfin <> Nothing And fecha_registro <> Nothing And asigna <> Nothing And tipo_documento <> Nothing Then
                    cms.CommandText = "SELECT * from  Solicitud_Documento where convert(date,Fc_Fin) = @fecha_fin and convert(date,Fc_Reg) = @fecha and Prioridad = @prioridad and Estado = @estado  order by Id_Solicitud_Documento desc"
                End If
                If tipo_documento <> Nothing And asigna <> Nothing Then
                    cms.CommandText = "SELECT * from  Solicitud_Documento where Estado = @estado and Prioridad = @prioridad  order by Id_Solicitud_Documento desc"
                End If
            End If
            If _Validacion = "filtros2" Then 'Filtros 2 fue creado con las mismas consultas de filtros 1, lo diferente es que esta tienen mas de 1 tabla en la busqueda
                If ticket <> Nothing Then 'consulta por el filtro de ticket
                    cms.CommandText = "select * from  Solicitud_Documento where id_usuario_asignado is not null and Id_Solicitud_Documento = @tiket"
                    cms.Parameters.Add("@tiket", SqlDbType.BigInt).Value = ticket
                End If
                If strlnombres <> Nothing Then 'consulta por el usuario
                    cms.CommandText = "select * from  Solicitud_Documento where id_usuario_asignado is not null and Id_usuario = @usuario"
                    cms.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = strlnombres
                End If
                If fecha_registro <> Nothing Then 'consulta por el filtro de fecha registro
                    cms.CommandText = "select * from  Solicitud_Documento where id_usuario_asignado is not null and convert(date,Fc_Reg) = @fecha order by Id_Solicitud_Documento desc"
                    cms.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha_registro
                End If
                If fcfin <> Nothing Then 'consulta por el filtro de fecha registro FIN
                    cms.CommandText = "select  * from  Solicitud_Documento where id_usuario_asignado is not null and  convert(date,Fc_Reg) <= @fecha_fin order by Id_Solicitud_Documento desc"
                    cms.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fcfin
                End If
                If asignado <> Nothing Then 'consulta por el filtro de prioridad
                    cms.CommandText = "select  * from  Solicitud_Documento where id_usuario_asignado is not null and Prioridad = @asig order by Id_Solicitud_Documento desc"
                    cms.Parameters.Add("@asig", SqlDbType.VarChar, 50).Value = asignado
                End If
                If tipo_documento <> Nothing Then 'consulta por el filtro de Estado
                    cms.CommandText = "select * from  Solicitud_Documento where id_usuario_asignado is not null and Estado = @estado  order by Id_Solicitud_Documento desc"
                    cms.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = tipo_documento
                End If
                If strlfcfin <> Nothing And fecha_registro <> Nothing Then ' consulta por fechas
                    cms.CommandText = "select * from  Solicitud_Documento where id_usuario_asignado is not null and convert(date,fc_reg) >= @fecha and convert(date,fc_reg) <= @fecha_fin order by id_solicitud_documento"
                End If
                If strlfcfin <> Nothing And fecha_registro <> Nothing And tipo_documento <> Nothing Then 'consulta por fechas y estado
                    cms.CommandText = "select  * from  Solicitud_Documento where id_usuario_asignado is not null and convert(date,Fc_Fin) = @fecha_fin and convert(date,Fc_Reg) = @fecha and Estado = @estado order by Id_Solicitud_Documento desc"
                End If
                If strlfcfin <> Nothing And fecha_registro <> Nothing And asigna <> Nothing Then 'consulta por fecha fin/fecha registro/prioridad
                    cms.CommandText = "select * from  Solicitud_Documento where id_usuario_asignado is not null and convert(date,Fc_Fin) = @fecha_fin and convert(date,Fc_Reg) = @fecha and Prioridad = @prioridad order by Id_Solicitud_Documento desc"
                End If
                If strlfcfin <> Nothing And fecha_registro <> Nothing And asigna <> Nothing And tipo_documento <> Nothing Then 'consulta por fecha inicio/fecha fin/prioridad
                    cms.CommandText = "select * from  Solicitud_Documento where id_usuario_asignado is not null and convert(date,Fc_Fin) = @fecha_fin and convert(date,Fc_Reg) = @fecha and Prioridad = @prioridad and Estado = @estado  order by Id_Solicitud_Documento desc"
                End If
                If tipo_documento <> Nothing And asigna <> Nothing Then 'consulta por prioridad y estado
                    cms.CommandText = "select  * from  Solicitud_Documento where id_usuario_asignado is not null and Estado = @estado and Prioridad = @prioridad  order by Id_Solicitud_Documento desc"
                End If
            End If
            If Validacion = "filtros3" Then
                If strlnombres <> Nothing Then 'consulta por el usuario
                    cms.CommandText = "SELECT * from  Solicitud_Documento where Id_usuario = @usuario"
                End If
                If ticket <> Nothing Then 'consulta por el filtro de ticket
                    cms.CommandText = "SELECT * from  Solicitud_Documento where Id_Solicitud_Documento = @tiket"
                    cms.Parameters.Add("@tiket", SqlDbType.BigInt).Value = ticket
                End If
                If fecha_registro <> Nothing Then 'consulta por el filtro de fecha registro
                    cms.CommandText = "SELECT * from  Solicitud_Documento where convert(date,Fc_Reg) = @fecha  and Id_usuario = @usuario order by Id_Solicitud_Documento  desc"
                    cms.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha_registro
                End If
                If fcfin <> Nothing Then 'consulta por el filtro de fecha registro FIN
                    cms.CommandText = "SELECT * from  Solicitud_Documento where convert(date,Fc_Reg) <= @fecha_fin and Id_usuario = @usuario order by Id_Solicitud_Documento desc"
                    cms.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fcfin
                End If
                If strlfcfin <> Nothing And fecha_registro <> Nothing Then 'consulta por ambas fechas
                    cms.CommandText = "Select * from Solicitud_Documento where convert(date,fc_reg) >= @fecha and convert(date,fc_reg) <= @fecha_fin and Id_usuario = @usuario order by id_solicitud_documento"
                End If
                cms.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = strlnombres
            End If
            If _Validacion = "buscar ticket" Then
                cms.CommandText = "SELECT * from   Historial_Respuesta_Solictud_Documento where Id_Solicitud_Documento = @tiket"
                cms.Parameters.Add("@tiket", SqlDbType.BigInt).Value = ticket
            End If
            If _Validacion = "buscar ticket2" Then
                cms.CommandText = "SELECT * from   Historial_Asignacion where Id_Solicitud_Documento = @tiket"
                cms.Parameters.Add("@tiket", SqlDbType.BigInt).Value = ticket
            End If

            If _Validacion = "buscar id" Then
                cms.CommandText = "SELECT MAX(Id_Solicitud_Documento) AS id  from   Solicitud_Documento"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Version = dts.Tables(0).Rows.Count
            If _Validacion = "buscar id" Then
                ticket = dts.Tables(0).Rows(0).Item("id")
            End If
            If dts.Tables(0).Rows.Count = 0 Then
                Validacion = "1"
            End If
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Solicitudes() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT id_Solicitud_Documento , Fc_Reg , Tipo_Solicitud ,Tipo_Documento , Persona_Solicita , Proceso , Sub_Proceso,Observacion,Prioridad from  Solicitud_Documento where persona_solicita = @p_s"
            cms.Parameters.Add("@p_s", SqlDbType.VarChar, 60).Value = persona_solicita
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                Validacion = "1"
            End If
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub Asignacion_Solicitud()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "update Solicitud_Documento set Id_Usuario_Asigna=@usuario, Fc_Reg_Asigna=@fecha,Id_Usuario_Asignado=@asignado,Comentario=@comentario,Tipo_Documento=@tipo_documento, Estado=@estado where Id_Solicitud_Documento = @tiket"
            If Validacion = "actualiza_estado_proceso" Then
                cms.CommandText = "update Solicitud_Documento set Estado = 'En Proceso',Id_Usuario_Asignado = @id_usuario where Id_Solicitud_Documento = @tiket"
            End If
            If _Validacion = "actualiza_estado" Then
                cms.CommandText = "update Solicitud_Documento set Estado=@estado,Tipo_Documento = @tipo_documento where Id_Solicitud_Documento = @tiket"
            End If
            If _Validacion = "actualiza_estado_3" Then
                cms.CommandText = "update Solicitud_Documento set Estado=@estado where Id_Solicitud_Documento = @tiket"
            End If
            If _Validacion = "actualiza_estado_1" Then
                cms.CommandText = "update Solicitud_Documento set Estado=@estado, Fc_Fin =@fecha_fin,Tipo_Documento = @tipo_documento where Id_Solicitud_Documento = @tiket"
            End If
            If _Validacion = "actualiza_estado_2" Then
                cms.CommandText = "update Solicitud_Documento set Estado=@estado, Fc_Fin =@fecha_fin  where Id_Solicitud_Documento = @tiket"
            End If
            If _Validacion = "inserta_seguimiento_respuesta" Then
                cms.CommandText = "insert  Historial_Respuesta_Solictud_Documento (Id_Solicitud_Documento,Id_Usuario,Observacion,Estado,Complejidad,Tipo_Documento) values (@tiket,@usuario,@comentario,@estado,@asignado,@tipo_documento)"
            End If
            If _Validacion = "inserta_seguimiento_asignacion" Then
                cms.CommandText = "insert Historial_Asignacion (Id_Solicitud_Documento,Id_Usuario,Observacion,Id_Usuario_Asignado) values (@tiket,@usuario,@comentario,@id_usuario)"
            End If
            cms.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario_registra
            If asignado <> Nothing Then
                cms.Parameters.Add("@asignado", SqlDbType.VarChar, 50).Value = asignado
            End If
            cms.Parameters.Add("@comentario", SqlDbType.VarChar, 800).Value = comentario
            If tipo_documento <> Nothing Then
                cms.Parameters.Add("@tipo_documento", SqlDbType.VarChar, 50).Value = tipo_documento
            End If
            cms.Parameters.Add("@tiket", SqlDbType.BigInt).Value = ticket
            cms.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha_registro
            If estadoo <> Nothing Then
                cms.Parameters.Add("@estado", SqlDbType.VarChar, 10).Value = estadoo
            End If
            If tipo_solicitud <> Nothing Then
                cms.Parameters.Add("@id_usuario", SqlDbType.VarChar, 50).Value = tipo_solicitud
            End If
            cms.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = fecha_registro
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function Consulta_Archivo_Tipo_Solicitud() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim cn2 As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "tip_solicitud" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece='TipoSolicitud' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If _Validacion = "tip_documento" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece='TipoDocum' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If _Validacion = "tip_prioridad" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece='Prioridad' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If _Validacion = "Estado" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece='Estado_doc' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If _Validacion = "Estado2" Then
                cms.CommandText = "select * from Archivo_Complemento where Nombre <> 'Abierto' and Pertenece='Estado_doc' or Pertenece = '- Seleccione -' "
            End If
            If _Validacion = "Complejidad" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece='Complejidad' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If _Validacion = "Calidad_asignar" Then
                cn2.Open()
                cms.CommandText = "(select u.nombreu,ac.Nombre from datosclaro.dbo.usuarios u inner join admin_cham.dbo.Archivo_Complemento ac on ac.nombre = u.idusuario union Select '- Seleccione -' as nombreu, '- Seleccione -' as nombre)order by nombreu"
                cms.Connection = cn2
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                Return dts
                Exit Try
            End If
            '--------item de La lista de subprocesos
            If _Validacion = "cargar drl_Sub_proceso" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece=@proceso or Pertenece = '- Seleccione -' order by Nombre"
                cms.Parameters.Add("@proceso", SqlDbType.VarChar, 50).Value = tipo_solicitud
            End If
            If _Validacion = "seleccionar" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece='- Seleccione -' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
                cn2.Close()
            End If
        End Try
    End Function
    Public Sub ExcelNovedad()
        Try
            Using ConexionE As New OleDbConnection(_Fc_ruta)
                Dim Comando As New OleDbCommand
                Comando.CommandText = "SELECT DISTINCT cod,fcnovedad,idtiponovedad,dias,horas,estado,repone,reportanom,tipificacion,descripcion,'" + fecha + "' as fcregistro,'" + idusuario + "'as idusuarioreg,Cod_Diagnostico  FROM [Novedades$]"
                Comando.Connection = ConexionE
                Dim Adaptador As New OleDbDataAdapter
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(DteXCEL)
                Dim MyView As DataView
                Dim dtSinDuplicados As DataTable
                Dim listaux As New List(Of DataRow)
                Dim listaux1 As New List(Of DataRow)
                For Each dt As DataRow In DteXCEL.Rows 'toma los registros del excel /() almasena en un datarow
                    If dt("cod").ToString = "" Or dt("repone").ToString = "" Or dt("reportanom").ToString = "" Or dt("idtiponovedad").ToString = "" Or dt("tipificacion").ToString = "" Or dt("horas").ToString = "" Or dt("dias").ToString = "" Or dt("fcnovedad").ToString = "" Then
                        listaux.Add(dt)
                    End If
                Next
                For Each dt As DataRow In listaux 'quita los registros 
                    DteXCEL.Rows.Remove(dt)
                Next
                Validacion = 10
                If Validacion = 10 Then

                    MyView = New DataView(DteXCEL)
                    dtSinDuplicados = MyView.ToTable(True, "cod", "fcnovedad", "idtiponovedad", "dias", "horas", "estado", "repone", "reportanom", "tipificacion", "descripcion", "fcregistro", "idusuarioreg", "Cod_Diagnostico")
                    DteXCEL = dtSinDuplicados

                    For Each dr As DataRow In DteXCEL.Rows
                        idusuario = dr("cod").ToString
                        DtPersonalcredencial = consultanombre()
                        If consultanombre().Tables(0).Rows.Count <= 0 Then ' Valida que la novedad este asociada a un codigo de empleado existente
                            listaux1.Add(dr) ' si el codigo no existe la agrega a una lista aux y luego la quita de la tabla principal
                        End If
                    Next
                    For Each dr As DataRow In listaux1
                        DteXCEL.Rows.Remove(dr)
                    Next
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ExcelNovedades()
        Try
            If Validacion = 2 Then
                ExcelNovedad()
            End If
            cantidad = DteXCEL.Rows.Count
            If cantidad = 0 Then
                Validacion = 3
                Exit Sub
            End If
            Dim cms As New SqlClient.SqlCommand
            Dim dta As New SqlClient.SqlDataAdapter
            Dim listaux As New List(Of DataRow)
            Using Conexion As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                cms.Connection = Conexion
                Conexion.Open()
                Using bulkCopy As New SqlClient.SqlBulkCopy((System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString))
                    bulkCopy.DestinationTableName = "Novedad"
                    For Each col As DataColumn In DteXCEL.Columns
                        bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName)
                    Next
                    bulkCopy.WriteToServer(DteXCEL)
                End Using
                Conexion.Close()
            End Using
        Catch ex As Exception
            Validacion = 4
        End Try
    End Sub   'Hace el registro masivo con  bulkCopy (Programa de copia masiva (BCP))

    '''Inventario Activos Fijos'''
    Public Function Consulta_Activos_usuario() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Activo_Inventario where sub_responsable=@idusuario"
            cms.Parameters.Add("@idusuario", SqlDbType.VarChar, 30).Value = strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Horarios()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            'CORERCTO
            If Validacion = "1" Then
                cms.CommandText = "Select Fc_Entrada from Horarios where Jornada = 'Mañana' or Jornada = 'Oficina' or Jornada = 'Tarde' or  Jornada = 'Noche' or Jornada = 'Descanso' union select '- Seleccione -'"
            End If
            If Validacion = "2" Then
                cms.CommandText = "Select Fc_Salida from Horarios where Jornada = 'Mañana' or Jornada = 'Oficina' or Jornada = 'Tarde' or  Jornada = 'Noche' or Jornada = 'Descanso' union select '- Seleccione -'"
            End If
            '*******
            '***MAÑANA***
            If Validacion = "Mañ_1_In" Then
                cms.CommandText = "Select Fc_Entrada from Horarios where Jornada = 'Break_1_Mañana' union select '- Seleccione -'"
            End If
            If Validacion = "Mañ_1_Out" Then
                cms.CommandText = "Select Fc_Salida from Horarios where Jornada = 'Break_1_Mañana' union select '- Seleccione -'"
            End If
            If Validacion = "Mañ_2_In" Then
                cms.CommandText = "Select Fc_Entrada from Horarios where Jornada = 'Break_2_Mañana'  union select '- Seleccione -'"
            End If
            If Validacion = "Mañ_2_Out" Then
                cms.CommandText = "Select Fc_Salida from Horarios where Jornada = 'Break_2_Mañana'  union select '- Seleccione -'"
            End If
            '***OFICINA***
            If Validacion = "Ofi_1_In" Then
                cms.CommandText = "Select Fc_Entrada from Horarios where Jornada = 'Break_1_Oficina' union select '- Seleccione -' "
            End If
            If Validacion = "Ofi_1_Out" Then
                cms.CommandText = "Select Fc_Salida from Horarios where Jornada = 'Break_1_Oficina' union select '- Seleccione -'"
            End If
            If Validacion = "Ofi_2_In" Then
                cms.CommandText = "Select Fc_Entrada from Horarios where Jornada = 'Break_2_Oficina' union select '- Seleccione -' "
            End If
            If Validacion = "Ofi_2_Out" Then
                cms.CommandText = "Select Fc_Salida from Horarios where Jornada = 'Break_2_Oficina' union select '- Seleccione -'"
            End If
            '***TARDE***
            If Validacion = "Tar_1_In" Then
                cms.CommandText = "Select Fc_Entrada from Horarios where Jornada = 'Break_1_Tarde' union select '- Seleccione -'"
            End If
            If Validacion = "Tar_1_Out" Then
                cms.CommandText = "Select Fc_Salida from Horarios where Jornada = 'Break_1_Tarde' union select '- Seleccione -'"
            End If
            If Validacion = "Tar_2_In" Then
                cms.CommandText = "Select Fc_Entrada from Horarios where Jornada = 'Break_2_Tarde'  union select '- Seleccione -'"
            End If
            If Validacion = "Tar_2_Out" Then
                cms.CommandText = "Select Fc_Salida from Horarios where Jornada = 'Break_2_Tarde'  union select '- Seleccione -'"
            End If
            '***TODOS***
            If Validacion = "Tod_In" Then
                cms.CommandText = "Select Fc_Entrada from Horarios union select '- Seleccione -' "
            End If
            If Validacion = "Tod_Out" Then
                cms.CommandText = "Select Fc_Salida from Horarios union select '- Seleccione -' "
            End If
            '***DESCANSO***
            If Validacion = "Des_In" Then
                cms.CommandText = "Select Fc_Entrada from Horarios where Jornada = 'Descanso' union select '- Seleccione -'"
            End If
            If Validacion = "Des_Out" Then
                cms.CommandText = "Select Fc_Salida from Horarios where Jornada = 'Descanso'  union select '- Seleccione -'"
            End If
            '*****ValidarJornadaEspecial*****'
            If Validacion = "VerificarJornada" Then
                cms.CommandText = "SELECT ID_Horarios, CONCAT(Fc_Entrada,' ',Fc_Salida) As 'Turno', Jornada FROM Horarios WHERE ID_Horarios > 0 or ID_Horarios = 41 AND ID_Horarios < 8 And CONCAT(Fc_Entrada,' ',Fc_Salida) = @horarioactualizar"
                cms.Parameters.Add("@horarioactualizar", SqlDbType.VarChar, 50).Value = strlfcing & " " & strlfcretiro
                'cms.Parameters.Add("@horarioactualizar1", SqlDbType.VarChar, 50).Value = strlfcretiro
            End If
            If Validacion = "AlmuerzoIng" Then
                cms.CommandText = "Select Fc_Entrada from Horarios where Jornada = 'Almuerzo'  union select '- Seleccione -'"
            End If
            If Validacion = "AlmuerzoSal" Then
                cms.CommandText = "Select Fc_Salida from Horarios where Jornada = 'Almuerzo'  union select '- Seleccione -'"
            End If
            If Validacion = "segmento" Then
                cms.CommandText = "Select distinct  segmento from Validacion_Horario where segmento <>  '' union select '- Seleccione -'"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If Validacion = "VerificarJornada" Then
                    If dts.Tables(0).Rows(0).Item("Jornada") Is DBNull.Value Then
                        strlfcnovedad = ""
                    Else
                        strlfcnovedad = dts.Tables(0).Rows(0).Item("Jornada")
                    End If
                End If
            End If
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Function Consulta_Personal_A_Cargo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select codigo, (nombres + ' ' + apellidos) as nombre, grupo from personal where Jefe_Inmediato=@strlJefe_Inmediato and estado='A'"
            cms.Parameters.Add("@strlJefe_Inmediato", SqlDbType.VarChar, 120).Value = strlJefe_Inmediato
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            Return dts.Tables(0)
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Sub Ingresar_Fecha_Operacion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Dim dts As New DataSet
        Try
            cn.Open()
            cms.CommandText = "update  personal set Fecha_Inicio_Operacion=@Fecha where documento=@Documento"
            cms.Parameters.Add("@Fecha", SqlDbType.Date).Value = fcnovedad
            cms.Parameters.Add("@Documento", SqlDbType.VarChar, 30).Value = documento
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function Consulta_FechaIngreso_Operacion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Fecha_Inicio_Operacion from personal where documento=@documento"
            cms.Parameters.Add("@documento", SqlDbType.VarChar, 30).Value = documento
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Sub RegistroActualizacion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            If Validacion = "verificar" Then
                cms.CommandText = "INSERT INTO Registro_Cambios_Novedades  SELECT cod,fcnovedad,descripcioninasistencia,dias,horas,repone,reportanom,tipificacion,descripcion,fcregistro,idusuarioreg,mesreporte,idreg from Cons_novedad where cod=@strlcodigo and idreg =@strlid"
            Else
                cms.CommandText = "INSERT INTO Registro_Cambios_Novedades  SELECT cod,fcnovedad,descripcioninasistencia,dias,horas,repone,reportanom,tipificacion,descripcion,@fcRegistro as fcregistro,@strlRegistra as idusuarioreg,mesreporte,idreg from Cons_novedad where cod=@strlcodigo and idreg =@strlid"
            End If

            cms.Parameters.Add("@strlRegistra", SqlDbType.VarChar, 20).Value = idusuario
            cms.Parameters.Add("@strlcodigo", SqlDbType.VarChar, 50).Value = Me.strlcodigo
            cms.Parameters.Add("@strlid", SqlDbType.VarChar, 50).Value = Me.strlid
            cms.Parameters.Add("@fcRegistro", SqlDbType.VarChar, 50).Value = fcregistro
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function Registro_Personal()
        Dim Con As New SqlClient.SqlConnection
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con = Con_admin_cham
            Con.Open()
            strlfcregistro = Now
            'Parametros Obligatorios
            Scm.Parameters.AddWithValue("@strltipodoc", strltipodoc)
            Scm.Parameters.AddWithValue("@strlturno", strlturno)
            Scm.Parameters.AddWithValue("@strlempresa", strlempresa)
            Scm.Parameters.AddWithValue("@strldocumento", strldocumento)
            Scm.Parameters.AddWithValue("@strlnombres", strlnombres)
            Scm.Parameters.AddWithValue("@strlapellidos", strlapellidos)
            Scm.Parameters.AddWithValue("@strlcodigo", strlcodigo)
            Scm.Parameters.AddWithValue("@strleps", strleps)
            Scm.Parameters.AddWithValue("@strlfps", strlfps)
            Scm.Parameters.AddWithValue("@strltelefono", strltelefono)
            Scm.Parameters.AddWithValue("@strlgenero", strlgenero)
            Scm.Parameters.AddWithValue("@strlestadocivil", strlestadocivil)
            Scm.Parameters.AddWithValue("@strlescolaridad", strlescolaridad)
            Scm.Parameters.AddWithValue("@strlestudia", strlestudia)
            Scm.Parameters.AddWithValue("@strlproyecto", strlproyecto)
            Scm.Parameters.AddWithValue("@strlarea", strlarea)
            Scm.Parameters.AddWithValue("@strltipocont", strltipocont)
            Scm.Parameters.AddWithValue("@strlestado", "A")
            Scm.Parameters.AddWithValue("@strlidusuario", strlidusuario)
            Scm.Parameters.AddWithValue("@strlfcregistro", strlfcregistro)
            Scm.Parameters.AddWithValue("@_Id_Nacionalidad", Id_Nacionalidad)
            Scm.Parameters.AddWithValue("@_Id_Ciudad_Nacimiento", Id_Ciudad_Nacimiento)
            'Parametros opcionales
            Scm.Parameters.AddWithValue("@_Semestre_Actual_U", _Semestre_Actual_U)
            Scm.Parameters.AddWithValue("@strlrutafoto", strlrutafoto)
            Scm.Parameters.AddWithValue("@strlDescanso", strlDescanso)
            Scm.Parameters.AddWithValue("@strlJefe_Inmediato", strlJefe_Inmediato)
            Scm.Parameters.AddWithValue("@strlsalario", strlsalario)
            Scm.Parameters.AddWithValue("@strlbonificacion", strlbonificacion)
            Scm.Parameters.AddWithValue("@strlauxtransp", strlauxtransp)
            Scm.Parameters.AddWithValue("@strlUbicacion", strlUbicacion)
            Scm.Parameters.AddWithValue("@strldireccion", strldireccion)
            Scm.Parameters.AddWithValue("@strlemail", strlemail)
            Scm.Parameters.AddWithValue("@strlhijos", strlhijos)
            Scm.Parameters.AddWithValue("@strlrh", strlrh)
            Scm.Parameters.AddWithValue("@strlprofesion", strlprofesion)
            Scm.Parameters.AddWithValue("@strlobs", Observacion)
            Scm.Parameters.AddWithValue("@strlcargo", strlcargo)
            Scm.Parameters.AddWithValue("@_Cargo_Cliente", _Cargo_Cliente)
            Scm.Parameters.AddWithValue("@_Segmento", _Segmento)
            Scm.Parameters.AddWithValue("@strlrutahv", strlrutahv)
            Scm.Parameters.AddWithValue("@strlcuenta", strlcuenta)
            Scm.Parameters.AddWithValue("@strldeporte", strldeporte)
            Scm.Parameters.AddWithValue("@strlAclaracion", strlAclaracion)
            Scm.Parameters.AddWithValue("@strlfcnac", strlfcnac)
            Scm.Parameters.AddWithValue("@strlfcretiro", strlfcretiro)
            Scm.Parameters.AddWithValue("@strlfcing", strlfcing)
            Scm.Parameters.AddWithValue("@_Fecha_Inicio_Operacion", strlfcnovedad)

            ''''''''''''''''''
            If _Id_Nacionalidad = Nothing Then
                Scm.Parameters("@_Id_Nacionalidad").Value = DBNull.Value
            End If
            If _Id_Ciudad_Nacimiento = Nothing Then
                Scm.Parameters("@_Id_Ciudad_Nacimiento").Value = DBNull.Value
            End If


            If _Semestre_Actual_U = Nothing Then
                Scm.Parameters("@_semestre_actual_u").Value = DBNull.Value
            End If
            If strlrutafoto = Nothing Then
                Scm.Parameters("@strlrutafoto").Value = DBNull.Value
            End If
            If strlDescanso = Nothing Then
                Scm.Parameters("@strldescanso").Value = DBNull.Value
            End If
            If strlJefe_Inmediato = Nothing Then
                Scm.Parameters("@strljefe_inmediato").Value = DBNull.Value
            End If
            If strlUbicacion = Nothing Then
                Scm.Parameters("@strlubicacion").Value = DBNull.Value
            End If
            If strldireccion = Nothing Then
                Scm.Parameters("@strldireccion").Value = DBNull.Value
            End If
            If strlemail = Nothing Then
                Scm.Parameters("@strlemail").Value = DBNull.Value
            End If
            If strlrh = Nothing Then
                Scm.Parameters("@strlrh").Value = DBNull.Value
            End If
            If strlprofesion = Nothing Then
                Scm.Parameters("@strlprofesion").Value = DBNull.Value
            End If
            If Observacion = Nothing Then
                Scm.Parameters("@strlobs").Value = DBNull.Value
            End If
            If strlcargo = Nothing Then
                Scm.Parameters("@strlcargo").Value = DBNull.Value
            End If
            If _Cargo_Cliente = Nothing Then
                Scm.Parameters("@_cargo_cliente").Value = DBNull.Value
            End If
            If _Segmento = Nothing Then
                Scm.Parameters("@_segmento").Value = DBNull.Value
            End If
            If strlrutahv = Nothing Then
                Scm.Parameters("@strlrutahv").Value = DBNull.Value
            End If
            If strlcuenta = Nothing Then
                Scm.Parameters("@strlcuenta").Value = DBNull.Value
            End If
            If strldeporte = Nothing Then
                Scm.Parameters("@strldeporte").Value = DBNull.Value
            End If
            If strlAclaracion = Nothing Then
                Scm.Parameters("@strlaclaracion").Value = DBNull.Value
            End If
            If strlfcnovedad = Nothing Then
                Scm.Parameters("@_fecha_inicio_operacion").Value = DBNull.Value
            End If
            If strlfcing = Nothing Then
                Scm.Parameters("@strlfcing").Value = DBNull.Value
            End If
            If strlfcretiro = Nothing Then
                Scm.Parameters("@strlfcretiro").Value = DBNull.Value
            End If
            If strlfcnac = Nothing Then
                Scm.Parameters("@strlfcnac").Value = DBNull.Value
            End If
            If strlsalario = Nothing Then
                Scm.Parameters("@strlsalario").Value = 0
            End If
            If strlbonificacion = Nothing Then
                Scm.Parameters("@strlbonificacion").Value = 0
            End If
            If strlauxtransp = Nothing Then
                Scm.Parameters("@strlauxtransp").Value = 0
            End If
            If strlhijos = Nothing Then
                Scm.Parameters("@strlhijos").Value = 0
            End If
            Scm.CommandText = "If(Select Count(documento) From admin_cham.dbo.personal Where documento = @strldocumento) = 0 Insert Into admin_cham.dbo.personal ( Nacionalidad_Fk_DivPol_Paises_Id, Ciudad_Nacimiento_Fk_DivPol_Ciudades_Id, Tipo_Doc, documento, nombres, apellidos, codigo, eps, fps, direccion, telefono, fcnac, email, genero, estadocivil, hijos, cuenta, rh, deporte, escolaridad, profesion, estudia, Semestre_Actual_U, obs, cargo, idproyecto, idarea, idtipocont, salario, bonificacion, fcing, fcretiro, estado, rutafoto, rutahv, idusuario, fcregistro, auxtransp, turno, empresa, Descanso, Jefe_Inmediato, Aclaracion, Ubicacion, Segmento, Cargo_Cliente, Fecha_Inicio_Operacion ) values (@_Id_Nacionalidad, @_Id_Ciudad_Nacimiento, @strltipodoc, @strldocumento, @strlnombres, @strlapellidos, @strlcodigo, @strleps, @strlfps, @strldireccion, @strltelefono, @strlfcnac, @strlemail, @strlgenero, @strlestadocivil, @strlhijos, @strlcuenta, @strlrh, @strldeporte, @strlescolaridad, @strlprofesion, @strlestudia, @_Semestre_Actual_U, @strlobs, @strlcargo, @strlproyecto, @strlarea, @strltipocont, @strlsalario, @strlbonificacion, @strlfcing, @strlfcretiro, @strlestado, @strlrutafoto, @strlrutahv, @strlidusuario, @strlfcregistro, @strlauxtransp, @strlturno, @strlempresa, @strlDescanso, @strlJefe_Inmediato, @strlAclaracion, @strlUbicacion, @_Segmento, @_Cargo_Cliente, @_Fecha_Inicio_Operacion)"
            Scm.Connection = Con
            Return Scm.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Personal(ByVal All As Boolean) As DataTable
        Dim Con As New SqlClient.SqlConnection
        Dim Dts As New DataSet
        Dim Sdta As SqlClient.SqlDataAdapter
        Dim Scm As New SqlClient.SqlCommand
        Dim Where As String = Nothing
        Try
            Con = Con_admin_cham_Datos
            If Not All Then
                If strldocumento <> Nothing Then
                    Where = " And documento = @_Documento "
                    Scm.Parameters.AddWithValue("@_Documento", strldocumento)
                ElseIf strlcodigo <> Nothing Then
                    Where = " And codigo = @_Codigo "
                    Scm.Parameters.AddWithValue("@_Codigo", strlcodigo)
                Else
                    If strlnombres <> Nothing Then
                        Where = Where & " And nombres like '%'+@_Nombres+'%' "
                        Scm.Parameters.AddWithValue("@_Nombres", strlnombres)
                    End If
                    If strlapellidos <> Nothing Then
                        Where = Where & " And apellidos like '%'+@_Apellidos+'%' "
                        Scm.Parameters.AddWithValue("@_Apellidos", strlapellidos)
                    End If
                    If strlestado <> Nothing Then
                        Where = Where & " And estado=@_Estado "
                        Scm.Parameters.AddWithValue("@_Estado", strlestado)
                    End If
                    If strlarea <> Nothing Then
                        Where = Where & " And idarea=@_Area "
                        Scm.Parameters.AddWithValue("@_Area", strlarea)
                    End If
                End If
            End If
            Con.Open()
            Scm.CommandText = "Select * From admin_cham.dbo.Cons_personal Where 1=1 " & Where
            Scm.Connection = Con
            Sdta = New SqlClient.SqlDataAdapter(Scm)
            Sdta.Fill(Dts)
            Return Dts.Tables(0)
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function

    Public Function Actualizar_Personal()
        Dim Con As New SqlClient.SqlConnection
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con = Con_admin_cham
            strlfcregistro = Now
            Dim Frag_Sql As String = Nothing
            'Parametros Obligatorios
            Scm.Parameters.AddWithValue("@strltipodoc", strltipodoc)
            Scm.Parameters.AddWithValue("@strldocumento", strldocumento)
            Scm.Parameters.AddWithValue("@strlturno", strlturno)
            Scm.Parameters.AddWithValue("@strlempresa", strlempresa)
            Scm.Parameters.AddWithValue("@strlnombres", strlnombres)
            Scm.Parameters.AddWithValue("@strlapellidos", strlapellidos)
            Scm.Parameters.AddWithValue("@strlcodigo", strlcodigo)
            Scm.Parameters.AddWithValue("@strleps", strleps)
            Scm.Parameters.AddWithValue("@strlfps", strlfps)
            Scm.Parameters.AddWithValue("@strltelefono", strltelefono)
            Scm.Parameters.AddWithValue("@strlgenero", strlgenero)
            Scm.Parameters.AddWithValue("@strlestadocivil", strlestadocivil)
            Scm.Parameters.AddWithValue("@strlescolaridad", strlescolaridad)
            Scm.Parameters.AddWithValue("@strlestudia", strlestudia)
            Scm.Parameters.AddWithValue("@strlproyecto", strlproyecto)
            Scm.Parameters.AddWithValue("@strlarea", strlarea)
            Scm.Parameters.AddWithValue("@strltipocont", strltipocont)
            Scm.Parameters.AddWithValue("@strlidusuario", strlidusuario)
            Scm.Parameters.AddWithValue("@strlfcregistro", strlfcregistro)
            Scm.Parameters.AddWithValue("@_Id_Nacionalidad", Id_Nacionalidad)
            Scm.Parameters.AddWithValue("@_Id_Ciudad_Nacimiento", Id_Ciudad_Nacimiento)
            ''''''''''''''''''''''''''''
            'Parametros opcionales
            Scm.Parameters.AddWithValue("@_Semestre_Actual_U", _Semestre_Actual_U)
            Scm.Parameters.AddWithValue("@strlrutafoto", strlrutafoto)
            Scm.Parameters.AddWithValue("@strlDescanso", strlDescanso)
            Scm.Parameters.AddWithValue("@strlJefe_Inmediato", strlJefe_Inmediato)
            Scm.Parameters.AddWithValue("@strlsalario", strlsalario)
            Scm.Parameters.AddWithValue("@strlbonificacion", strlbonificacion)
            Scm.Parameters.AddWithValue("@strlauxtransp", strlauxtransp)
            Scm.Parameters.AddWithValue("@strlUbicacion", strlUbicacion)
            Scm.Parameters.AddWithValue("@strldireccion", strldireccion)
            Scm.Parameters.AddWithValue("@strlemail", strlemail)
            Scm.Parameters.AddWithValue("@strlhijos", strlhijos)
            Scm.Parameters.AddWithValue("@strlrh", strlrh)
            Scm.Parameters.AddWithValue("@strlprofesion", strlprofesion)
            Scm.Parameters.AddWithValue("@strlobs", Observacion)
            Scm.Parameters.AddWithValue("@strlcargo", strlcargo)
            Scm.Parameters.AddWithValue("@_Cargo_Cliente", _Cargo_Cliente)
            Scm.Parameters.AddWithValue("@_Segmento", _Segmento)
            Scm.Parameters.AddWithValue("@strlrutahv", strlrutahv)
            Scm.Parameters.AddWithValue("@strlcuenta", strlcuenta)
            Scm.Parameters.AddWithValue("@strldeporte", strldeporte)
            Scm.Parameters.AddWithValue("@strlAclaracion", strlAclaracion)
            Scm.Parameters.AddWithValue("@strlfcnac", strlfcnac)
            Scm.Parameters.AddWithValue("@strlfcretiro", strlfcretiro)
            Scm.Parameters.AddWithValue("@strlfcing", strlfcing)
            Scm.Parameters.AddWithValue("@_Fecha_Inicio_Operacion", strlfcnovedad)
            ''''''''''''''''''
            If strlrutahv <> Nothing Then
                Frag_Sql = Frag_Sql & ", rutahv =@strlrutahv "
                Scm.Parameters.AddWithValue("@strlrutahv", strlrutahv)
            End If
            If strlrutafoto <> Nothing Then
                Scm.Parameters.AddWithValue("@strlrutafoto", strlrutafoto)
                Frag_Sql = Frag_Sql & ", rutafoto =@strlrutafoto  "
            End If
            If _Semestre_Actual_U = Nothing Then
                Scm.Parameters("@_Semestre_actual_u").Value = DBNull.Value
            End If
            If strlDescanso = Nothing Then
                Scm.Parameters("@strldescanso").Value = DBNull.Value
            End If
            If strlJefe_Inmediato = Nothing Then
                Scm.Parameters("@strljefe_inmediato").Value = DBNull.Value
            End If
            If strlUbicacion = Nothing Then
                Scm.Parameters("@strlubicacion").Value = DBNull.Value
            End If
            If strldireccion = Nothing Then
                Scm.Parameters("@strldireccion").Value = DBNull.Value
            End If
            If strlemail = Nothing Then
                Scm.Parameters("@strlemail").Value = DBNull.Value
            End If
            If strlrh = Nothing Then
                Scm.Parameters("@strlrh").Value = DBNull.Value
            End If
            If strlprofesion = Nothing Then
                Scm.Parameters("@strlprofesion").Value = DBNull.Value
            End If
            If Observacion = Nothing Then
                Scm.Parameters("@strlobs").Value = DBNull.Value
            End If
            If strlcargo = Nothing Then
                Scm.Parameters("@strlcargo").Value = DBNull.Value
            End If
            If _Cargo_Cliente = Nothing Then
                Scm.Parameters("@_cargo_cliente").Value = DBNull.Value
            End If
            If _Segmento = Nothing Then
                Scm.Parameters("@_segmento").Value = DBNull.Value
            End If
            If strlcuenta = Nothing Then
                Scm.Parameters("@strlcuenta").Value = DBNull.Value
            End If
            If strldeporte = Nothing Then
                Scm.Parameters("@strldeporte").Value = DBNull.Value
            End If
            If strlAclaracion = Nothing Then
                Scm.Parameters("@strlaclaracion").Value = DBNull.Value
            End If
            If strlfcnovedad = Nothing Then
                Scm.Parameters("@_fecha_inicio_operacion").Value = DBNull.Value
            End If
            If strlfcing = Nothing Then
                Scm.Parameters("@strlfcing").Value = DBNull.Value
            End If
            If strlfcretiro = Nothing Then
                Scm.Parameters("@strlfcretiro").Value = DBNull.Value
            End If
            If strlfcnac = Nothing Then
                Scm.Parameters("@strlfcnac").Value = DBNull.Value
            End If
            If strlsalario = Nothing Then
                Scm.Parameters("@strlsalario").Value = 0
            End If
            If strlbonificacion = Nothing Then
                Scm.Parameters("@strlbonificacion").Value = 0
            End If
            If strlauxtransp = Nothing Then
                Scm.Parameters("@strlauxtransp").Value = 0
            End If
            If strlhijos = Nothing Then
                Scm.Parameters("@strlhijos").Value = 0
            End If
            Scm.CommandText = "Update personal Set  documento = @strldocumento, nombres = @strlnombres, apellidos = @strlapellidos, codigo = @strlcodigo, eps = @strleps, fps = @strlfps, direccion = @strldireccion, telefono = @strltelefono, fcnac = @strlfcnac, email = @strlemail, genero = @strlgenero, estadocivil = @strlestadocivil, hijos = @strlhijos, cuenta = @strlcuenta, rh = @strlrh, deporte = @strldeporte, escolaridad = @strlescolaridad, profesion = @strlprofesion, estudia = @strlestudia, obs = @strlobs, cargo = @strlcargo, idproyecto = @strlproyecto, Segmento = @_Segmento, Cargo_Cliente = @_Cargo_Cliente, idarea = @strlarea, idtipocont = @strltipocont, salario = @strlsalario, auxtransp = @strlauxtransp, bonificacion = @strlbonificacion, turno = @strlturno, empresa = @strlempresa, fcing = @strlfcing, fcretiro = @strlfcretiro, idusuario = @strlidusuario, Descanso = @strlDescanso, Jefe_Inmediato = @strlJefe_Inmediato, Aclaracion = @strlAclaracion, Tipo_Doc = @strltipodoc, Ubicacion = @strlUbicacion, Fecha_Inicio_Operacion = @_Fecha_Inicio_Operacion, Nacionalidad_Fk_DivPol_Paises_Id = @_Id_Nacionalidad, Ciudad_Nacimiento_Fk_DivPol_Ciudades_Id = @_Id_Ciudad_Nacimiento, Semestre_actual_u = @_Semestre_actual_u " & Frag_Sql & "  WHERE documento = @strldocumento And Tipo_Doc Like @strltipodoc"
            Con.Open()
            Scm.Connection = Con
            Return Scm.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function

       Public Function Actualizar_Personal_DatosExtras()
        Dim Con As New SqlClient.SqlConnection
        Dim Csm As New SqlClient.SqlCommand
        Try
            Con = Con_admin_cham
            Con.Open()
            Csm.Connection = Con
            Csm.Parameters.AddWithValue("@strldocumento", strldocumento)
            Csm.Parameters.AddWithValue("@_Contacto_Emerg", _Pers_Contac_Emerg)
            Csm.Parameters.AddWithValue("@_Tel_Emeg", _Tel_Contac_Emeg)
            Csm.Parameters.AddWithValue("@_Toma_Medicamentos", _Toma_Medicamentos)
            Csm.Parameters.AddWithValue("@_Obs_Medicamentos", _Obs_Medicamentos)
            Csm.Parameters.AddWithValue("@_Obs_Ant_Salud", _Obs_Ant_Salud)
            If _Obs_Medicamentos = Nothing Then
                Csm.Parameters("@_Obs_Medicamentos").Value = DBNull.Value
            End If
            Csm.CommandText = "UPDATE personal SET Pers_Contac_Emerg = @_Contacto_Emerg, Tel_Contac_Emerg = @_Tel_Emeg, Toma_Medicamentos = @_Toma_Medicamentos, Medicamentos = @_Obs_Medicamentos, Ant_Pers_Salud = @_Obs_Ant_Salud WHERE documento = @strldocumento"
            Return Csm.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            Csm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function



    Public Function Consultar_Complementos_Personal(ByVal Pertenece As String) As DataTable
        Dim Con As New SqlClient.SqlConnection
        Dim Sdta As SqlClient.SqlDataAdapter
        Dim Dts As New DataSet
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con = Con_admin_cham
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_Pertenece", Pertenece)
            Scm.CommandText = "Select * From admin_cham.dbo.Complementos_Personal Where Pertenece = (Select Top 1 Id From admin_cham.dbo.Complementos_Personal Where Nombre =@_Pertenece And Pertenece Is Null) And Activo = 1"
            Sdta = New SqlClient.SqlDataAdapter(Scm)
            Sdta.Fill(Dts)
            Return Dts.Tables(0)
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Consultar_EPS() As DataTable
        Dim Con As New SqlClient.SqlConnection
        Dim Dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con = Con_admin_cham
            Con.Open()
            Scm.CommandText = "SELECT * FROM eps order by EPSDES"
            Scm.Connection = Con
            dta = New SqlClient.SqlDataAdapter(Scm)
            dta.Fill(Dts)
            Return Dts.Tables(0)
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Consultar_FPS() As DataTable
        Dim Con As New SqlClient.SqlConnection
        Dim Dts As New DataSet

        Dim Dta As SqlClient.SqlDataAdapter
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con = Con_admin_cham
            Con.Open()
            Scm.Connection = Con
            Scm.CommandText = "SELECT * FROM fps order by pensiondes"
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Return Dts.Tables(0)
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Consultar_Jefes() As DataTable
        Dim Con As New SqlClient.SqlConnection
        Dim Dts As New DataSet
        Dim Dta As SqlClient.SqlDataAdapter
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con = Con_admin_cham
            Con.Open()
            Scm.CommandText = "select distinct Jefe_Inmediato from personal where codigo in (select codigo from personal where estado='A') and Jefe_Inmediato <>''"
            Scm.Connection = Con
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Return Dts.Tables(0)
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Registro_Masivo_Personal()
        Dim Val As String = Nothing
        Try
            Dim Dtt = Validar_Datatable_Personal(Xlsx_Personal_To_Datatable())
            If TypeOf (Dtt) Is DataTable Then
                Dim I As Integer = 0
                Try
                    For Each Dtr As DataRow In Dtt.Rows
                        strltipodoc = Nothing
                        strlturno = Nothing
                        strlempresa = Nothing
                        strldocumento = Nothing
                        strlnombres = Nothing
                        strlapellidos = Nothing
                        strlcodigo = Nothing
                        strleps = Nothing
                        strlfps = Nothing
                        strltelefono = Nothing
                        strlgenero = Nothing
                        strlestadocivil = Nothing
                        strlescolaridad = Nothing
                        strlestudia = Nothing
                        strlproyecto = Nothing
                        strlarea = Nothing
                        strltipocont = Nothing
                        strlidusuario = Nothing
                        strlfcregistro = Nothing
                        Id_Nacionalidad = Nothing
                        Id_Ciudad_Nacimiento = Nothing
                        _Semestre_Actual_U = Nothing
                        strlrutafoto = Nothing
                        strlDescanso = Nothing
                        strlJefe_Inmediato = Nothing
                        strlsalario = Nothing
                        strlbonificacion = Nothing
                        strlauxtransp = Nothing
                        strlUbicacion = Nothing
                        strldireccion = Nothing
                        strlemail = Nothing
                        strlhijos = Nothing
                        strlprofesion = Nothing
                        Observacion = Nothing
                        strlcargo = Nothing
                        _Cargo_Cliente = Nothing
                        _Segmento = Nothing
                        strlfcnac = Nothing
                        strlfcretiro = Nothing
                        strlfcing = Nothing
                        strlfcnovedad = Nothing



                        strltipodoc = Dtr.Item("TI")
                        strlturno = Dtr.Item("Turno")
                        strlempresa = Dtr.Item("Empresa")
                        strldocumento = Dtr.Item("N° I")
                        strlnombres = Dtr.Item("Nombres")
                        strlapellidos = Dtr.Item("Apellidos")
                        strlcodigo = Dtr.Item("Código")
                        strleps = Dtr.Item("EPS")
                        strlfps = Dtr.Item("FPS")
                        strltelefono = Dtr.Item("Teléfono")
                        strlgenero = Dtr.Item("Género")
                        strlestadocivil = Dtr.Item("Estado Civil")
                        strlescolaridad = Dtr.Item("Nivel Académico")
                        strlestudia = Dtr.Item("Estudia")
                        strlproyecto = Dtr.Item("Proyecto")
                        strlarea = Dtr.Item("Área")
                        strltipocont = Dtr.Item("Tipo Contrato")
                        strlidusuario = Dtr.Item("Usuario")
                        Id_Nacionalidad = Dtr.Item("Nacionalidad")
                        Id_Ciudad_Nacimiento = Dtr.Item("Ciudad de Nacimiento")
                        _Semestre_Actual_U = Dtr.Item("Semestre Actual")
                        strlDescanso = Dtr.Item("Descanso")
                        strlJefe_Inmediato = Dtr.Item("Jefe Inmediato")
                        strlsalario = Dtr.Item("Salario")
                        strlbonificacion = Dtr.Item("Bonificaciones")
                        strlauxtransp = Dtr.Item("Auxilio de Trasnporte")
                        strlUbicacion = Dtr.Item("Ubicación")
                        strldireccion = Dtr.Item("Dirección")
                        strlemail = Dtr.Item("E-Mail")
                        strlhijos = Dtr.Item("N° Hijos")
                        strlrh = Dtr.Item("RH")
                        strlprofesion = Dtr.Item("Profesión")
                        Observacion = Dtr.Item("Observaciones")
                        strlcargo = Dtr.Item("Cargo Interno")
                        _Cargo_Cliente = Dtr.Item("Cargo Cliente")
                        _Segmento = Dtr.Item("Segmento")
                        strlfcnac = Dtr.Item("Fecha de Nacimiento")
                        strlfcretiro = Dtr.Item("Fecha de Retiro")
                        strlfcing = Dtr.Item("Fecha de Ingreso")
                        strlfcnovedad = Dtr.Item("Fecha Inicio Operación")

                        If Registro_Personal() <= 0 Then
                            If Val = Nothing Then
                                Val = "Las siguientes filas no fueron registradas, se desconoce la razon : """ & I + 1 & """"
                            Else
                                Val = Val & ", """ & I + 1 & """"
                            End If
                        End If
                        I = I + 1
                    Next
                Catch ex As Exception
                    Return "Error al registrar la fila """ & I + 1 & """ todas las anteriores fialas fueron registradas correctamente; citando: """ & ex.Message & """ " & Val
                End Try
            Else
                Return Dtt
            End If
            Return Val
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Xlsx_Personal_To_Datatable()
        Try
            Dim Dtt As New DataTable
            Using Con As New OleDbConnection(_Fc_ruta)
                Dim Ocm As New OleDbCommand
                Ocm.Parameters.AddWithValue("@_Usuario", strlidusuario)
                Ocm.CommandText = "Select [TI],[N° I],[Código],[Nombres],[Apellidos],[EPS],[FPS],[Jefe Inmediato],[Dirección],[Teléfono],[Nacionalidad],[Pais de Nacimiento],[Estado de Nacimiento],[Ciudad de Nacimiento],[Fecha de Nacimiento],[E-Mail],[Género],[Estado Civil],[N° Hijos],[RH],[Nivel Académico],[Profesión],[Estudia],[Semestre Actual],[Observaciones],[Descanso],[Ubicación],[Cargo Interno],[Proyecto],[Segmento],[Cargo Cliente],[Área],[Tipo Contrato],[Salario],[Bonificaciones],[Auxilio de Trasnporte],[Turno],[Fecha de Ingreso],[Fecha de Retiro],[Empresa],[Fecha Inicio Operación], @_Usuario As Usuario  from [Hoja1$]"
                Ocm.Connection = Con
                Dim ODta As New OleDbDataAdapter
                ODta.SelectCommand = Ocm
                ODta.Fill(Dtt)
                Con.Close()
            End Using
            Return Dtt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Validar_Datatable_Personal(ByVal Dtt As DataTable)
        Dim Tablas As New Dictionary(Of String, DataTable)
        Try
            Tablas.Add("Dtt_Personal", Consulta_Personal(True))
            Tablas.Add("Dtt_EPS", Consultar_EPS())
            Tablas.Add("Dtt_FPS", Consultar_FPS())
            Tablas.Add("Dtt_Jefes", Consultar_Jefes())
            Dim Obj_General As New clsgeneral
            Tablas.Add("Dtt_DivPol_Paises", Obj_General.Consultar_DivPol_Paises())
            Tablas.Add("Dtt_DivPol_Estados", Obj_General.Consultar_DivPol_Estados())
            Tablas.Add("Dtt_DivPol_Ciudades", Obj_General.Consultar_DivPol_Ciudades())
            Tablas.Add("Dtt_Proyectos", Obj_General.consultaproyecto().Tables(0))
            Tablas.Add("Dtt_Areas", Obj_General.consultaarea().Tables(0))

            Tablas.Add("Dtt_Estados_Civiles", Consultar_Complementos_Personal("Estados Civiles"))
            Tablas.Add("Dtt_Niveles_Academicos", Consultar_Complementos_Personal("Niveles Académicos"))
            Tablas.Add("Dtt_Turnos", Consultar_Complementos_Personal("Turnos"))
            Tablas.Add("Dtt_Tipos_Contratos", Consultar_Complementos_Personal("Tipos Contratos"))
            Tablas.Add("Dtt_Descansos", Consultar_Complementos_Personal("Descansos"))
            Tablas.Add("Dtt_TI", Consultar_Complementos_Personal("TI"))
            Tablas.Add("Dtt_Empresas", Consultar_Complementos_Personal("Empresas"))

            '''''Objeto de campos obligatorios''''
            Dim Required_Columns = New String() {}
            '''''''''''''''''''''''''''''''''''''''
            For I As Integer = 0 To Dtt.Rows.Count - 1
                'eliminar espacios en blanco adelante y atras del texto para eviitar futuras excepciones
                For Each Dtc As DataColumn In Dtt.Columns
                    Dtt.Rows(I).Item(Dtc.ColumnName) = Dtt.Rows(I).Item(Dtc.ColumnName).ToString.Trim
                Next
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'validar campos obligatorios
                Required_Columns = {"TI", "N° I", "Código", "Nombres", "Apellidos", "EPS", "FPS", "Nacionalidad", "Fecha de Nacimiento", "Género", "Estado Civil", "RH", "Nivel Académico", "Estudia", "Proyecto", "Área", "Tipo Contrato", "Turno", "Empresa"}
                'evaluar columnas de caracter obligatorio''
                Dtt.Rows(I).Item("Estudia") = Dtt.Rows(I).Item("Estudia").ToUpper
                If Dtt.Rows(I).Item("Estudia") = "SI" Then
                    ReDim Preserve Required_Columns(Required_Columns.Count)
                    Required_Columns(Required_Columns.Count - 1) = "Semestre Actual"
                End If
                For Each Dtc As DataColumn In Dtt.Columns
                    If Dtt.Rows(I).Item(Dtc.ColumnName) = Nothing Then
                        For Each Required_Column As String In Required_Columns
                            If Dtc.ColumnName = Required_Column Then
                                Return "¡Error En la Fila " & I + 1 & " columna """ & Dtc.ColumnName & """! el campo es de caracter obligatorio"
                            End If
                        Next
                    End If
                Next
                '''''''''''''''''''''''''''''
                'Validar tipo de identificación
                If Dtt.Rows(I).Item("TI") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("TI") = Tablas.Item("Dtt_TI").Select("Nombre Like '" & Dtt.Rows(I).Item("TI") & "'")(0)("Nombre")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """TI""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("TI") & """; No existe, está mal escrito, o no está registrado en base de datos"
                    End Try
                End If
                'validar documento de identidad
                If Dtt.Rows(I).Item("N° I") <> Nothing Then
                    Try
                        Int64.Parse(Dtt.Rows(I).Item("N° I"))
                    Catch ex As Exception
                        Return "¡Error! en la fila " & I + 1 & ": La columna ""N° I"" está mal escrita, puesto que tiene que ser un número"
                    End Try
                    If Tablas.Item("Dtt_Personal").Select("documento Like '" & Dtt.Rows(I).Item("N° I") & "'").Count >= 1 Then
                        Return "¡Error! en la fila " & I + 1 & ": El N° de Identificación """ & Dtt.Rows(I).Item("N° I") & """ ya se encuentra registrado en la base de datos "
                    End If
                End If
                ''''''''''''''''''''''''''''''
                'validar Código
                If Dtt.Rows(I).Item("Código") <> Nothing Then
                    If Tablas.Item("Dtt_Personal").Select("codigo Like '" & Dtt.Rows(I).Item("Código") & "'").Count >= 1 Then
                        Return "¡Error! en la fila " & I + 1 & ": El Código """ & Dtt.Rows(I).Item("Código") & """ ya se encuentra registrado en la base de datos "
                    End If
                End If
                'validar y convertir EPS
                If Dtt.Rows(I).Item("EPS") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("EPS") = Tablas.Item("Dtt_EPS").Select("epsdes Like '" & Dtt.Rows(I).Item("EPS") & "' And ideps <> 0")(0)("ideps")
                    Catch ex As Exception
                        Return "¡Error! No es posible convertir texto """ & Dtt.Rows(I).Item("EPS") & """ de la columna ""EPS"" en la fila """ & I + 1 & """, es posible que esté mal escrito o no exista en base de datos"
                    End Try
                End If
                'validar y convertir FPS
                If Dtt.Rows(I).Item("FPS") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("FPS") = Tablas.Item("Dtt_FPS").Select("pensiondes Like '" & Dtt.Rows(I).Item("FPS") & "' And idpension <> 0")(0)("idpension")
                    Catch ex As Exception
                        Return "¡Error! No es posible convertir texto """ & Dtt.Rows(I).Item("FPS") & """ de la columna ""FPS"" en la fila """ & I + 1 & """, es posible que esté mal escrito o no exista en base de datos"
                    End Try
                End If
                'validar jefe inmediato
                If Dtt.Rows(I).Item("Jefe Inmediato") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Jefe Inmediato") = Tablas.Item("Dtt_Jefes").Select("Jefe_Inmediato Like '" & Dtt.Rows(I).Item("Jefe Inmediato") & "'")(0)("Jefe_Inmediato")
                    Catch ex As Exception
                        Return "¡Error! No se han encontrado coincidencias con el texto """ & Dtt.Rows(I).Item("Jefe Inmediato") & """ de la columna ""Jefe Inmediato"" en la fila """ & I + 1 & """, es posible que esté mal escrito o no exista en base de datos"
                    End Try
                End If
                'validar teléfono
                If Dtt.Rows(I).Item("Teléfono") <> Nothing Then
                    If Not New Regex("^((([0-9]{7,10})-)?[0-9]{7,10})$").Match(Dtt.Rows(I).Item("Teléfono")).Success Then
                        Return "¡Error en la fila " & I + 1 & " columna ""Teléfono""! el texto está mal escrito, puesto que no es un número"
                    End If
                End If                'validar nacionalidad
                If Dtt.Rows(I).Item("Nacionalidad") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Nacionalidad") = Tablas.Item("Dtt_DivPol_Paises").Select("Nombre Like '" & Dtt.Rows(I).Item("Nacionalidad") & "'")(0)("Id")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Nacionalidad""! No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Nacionalidad") & """; No existe, está mal escrito, o no está registrado en base de datos"
                    End Try
                End If
                'validar pais nacimiento
                If Dtt.Rows(I).Item("Pais de Nacimiento") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Pais de Nacimiento") = Tablas.Item("Dtt_DivPol_Paises").Select("Nombre Like '" & Dtt.Rows(I).Item("Pais de Nacimiento") & "'")(0)("Id")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Pais de Nacimiento""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Pais de Nacimiento") & """; No existe, está mal escrito, o no está registrado en base de datos"
                    End Try
                End If
                'validar estado de nacimiento
                If Dtt.Rows(I).Item("Estado de Nacimiento") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Estado de Nacimiento") = Tablas.Item("Dtt_DivPol_Estados").Select("Nombre Like '" & Dtt.Rows(I).Item("Estado de Nacimiento") & "' And Pais_Fk_DivPol_Paises_Id = '" & Dtt.Rows(I).Item("Pais de Nacimiento") & "'")(0)("Id")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Estado de Nacimiento""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Pais de Nacimiento") & """; No existe, está mal escrito, no está registrado en base de datos o es un Estado que no pertenece al pais de nacimiento igresado"
                    End Try
                End If
                'validar ciudad de nacimiento
                If Dtt.Rows(I).Item("Ciudad de Nacimiento") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Ciudad de Nacimiento") = Tablas.Item("Dtt_DivPol_Ciudades").Select("Nombre Like '" & Dtt.Rows(I).Item("Ciudad de Nacimiento") & "' And Estado_Fk_DivPol_Estados_Id = '" & Dtt.Rows(I).Item("Estado de Nacimiento") & "'")(0)("Id")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Ciudad de Nacimiento""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Ciudad de Nacimiento") & """; No existe, está mal escrito, no está registrado en base de datos o es una ciudad que no pertenece al estado de nacimiento igresado"
                    End Try
                End If
                'Validar fecha de nacimiento
                If Dtt.Rows(I).Item("Fecha de Nacimiento") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Fecha de Nacimiento") = CDate(Dtt.Rows(I).Item("Fecha de Nacimiento"))
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Fecha de Nacimiento""!: El texto """ & Dtt.Rows(I).Item("Fecha de Nacimiento") & """ No es una fecha, o no tiene el formato ""dd/MM/yyyy"""
                    End Try
                End If
                'validar email
                If Dtt.Rows(I).Item("E-Mail") <> Nothing Then
                    If Not New Regex("^(?<user>[^@]+)@(?<host>.+)$").Match(Dtt.Rows(I).Item("E-Mail")).Success Then
                        Return "¡Error en la fila """ & I + 1 & """ columna ""E-Mail""!: El texto """ & Dtt.Rows(I).Item("E-Mail") & """ No es un correo electronico válido"
                    End If
                End If
                'validar Género
                If Dtt.Rows(I).Item("Género") <> Nothing Then
                    If Dtt.Rows(I).Item("Género").ToUpper <> "M" And Dtt.Rows(I).Item("Género").ToUpper <> "F" Then
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Género""!: El texto """ & Dtt.Rows(I).Item("Género") & """ los Géneros aceptados Son ""M"" y ""F"""
                    Else
                        Dtt.Rows(I).Item("Género") = Dtt.Rows(I).Item("Género").ToUpper
                    End If
                End If
                'número de hijos
                If Dtt.Rows(I).Item("N° Hijos") <> Nothing Then
                    Try
                        Integer.Parse(Dtt.Rows(I).Item("N° Hijos"))
                    Catch ex As Exception
                        Return "¡Error en la fila " & I + 1 & " columna ""N° Hijos""! el texto está mal escrito, puesto que no es un número"
                    End Try
                End If
                'validar Nivel de Académico
                If Dtt.Rows(I).Item("Nivel Académico") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Nivel Académico") = Tablas.Item("Dtt_Niveles_Academicos").Select("Nombre Like '" & Dtt.Rows(I).Item("Nivel Académico") & "'")(0)("Nombre")

                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Nivel de Escolaridad""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Nivel de Escolaridad") & """; No existe, está mal escrito, o no está registrado en base de datos"
                    End Try
                End If
                'Válidar semestre actual
                If Dtt.Rows(I).Item("Semestre Actual") <> Nothing Then
                    Try
                        Integer.Parse(Dtt.Rows(I).Item("Semestre Actual"))
                    Catch ex As Exception
                        Return "¡Error en la fila " & I + 1 & " columna ""Semestre Actual""! el texto está mal escrito, puesto que no es un número"
                    End Try
                End If
                If Dtt.Rows(I).Item("Descanso") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Descanso") = Tablas.Item("Dtt_Descansos").Select("Nombre Like '" & Dtt.Rows(I).Item("Descanso") & "'")(0)("Nombre")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Descanso""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Descanso") & """; No existe, está mal escrito, o no está registrado en base de datos"
                    End Try
                End If
                'validar Empresa
                If Dtt.Rows(I).Item("Empresa") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Empresa") = Tablas.Item("Dtt_Empresas").Select("Nombre Like '" & Dtt.Rows(I).Item("Empresa") & "'")(0)("Nombre")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Empresa""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Empresa") & """; No existe, está mal escrito, 0 no está registrado en base de datos"
                    End Try
                End If
                'validar Proyecto
                If Dtt.Rows(I).Item("Proyecto") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Proyecto") = Tablas.Item("Dtt_Proyectos").Select("nombreproyecto Like '" & Dtt.Rows(I).Item("Proyecto") & "'")(0)("idproyecto")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Proyecto""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Proyecto") & """; No existe, está mal escrito, 0 no está registrado en base de datos"
                    End Try
                End If
                'validar Área
                If Dtt.Rows(I).Item("Área") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Área") = Tablas.Item("Dtt_Areas").Select("area Like '" & Dtt.Rows(I).Item("Área") & "'")(0)("idarea")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Área""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Área") & """; No existe, está mal escrito, 0 no está registrado en base de datos"
                    End Try
                End If
                'validar tipo contrato
                If Dtt.Rows(I).Item("Tipo Contrato") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Tipo Contrato") = Tablas.Item("Dtt_Tipos_Contratos").Select("Nombre Like '" & Dtt.Rows(I).Item("Tipo Contrato") & "' And Activo = 1")(0)("Id")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Tipo Contrato""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Tipo Contrato") & """; No existe, está mal escrito, 0 no está registrado en base de datos"
                    End Try
                End If
                'Válidar Salario
                If Dtt.Rows(I).Item("Salario") <> Nothing Then
                    Try
                        Double.Parse(Dtt.Rows(I).Item("Salario"))
                    Catch ex As Exception
                        Return "¡Error en la fila " & I + 1 & " columna ""Salario""! el texto está mal escrito, puesto que no es un número"
                    End Try
                End If
                'Válidar Bonificaciones
                If Dtt.Rows(I).Item("Bonificaciones") <> Nothing Then
                    Try
                        Double.Parse(Dtt.Rows(I).Item("Bonificaciones"))
                    Catch ex As Exception
                        Return "¡Error en la fila " & I + 1 & " columna ""Bonificaciones""! el texto está mal escrito, puesto que no es un número"
                    End Try
                End If
                'Válidar Auxilio de Trasnporte
                If Dtt.Rows(I).Item("Auxilio de Trasnporte") <> Nothing Then
                    Try
                        Double.Parse(Dtt.Rows(I).Item("Auxilio de Trasnporte"))
                    Catch ex As Exception
                        Return "¡Error en la fila " & I + 1 & " columna ""Auxilio de Trasnporte""! el texto está mal escrito, puesto que no es un número"
                    End Try
                End If
                'validar turno
                If Dtt.Rows(I).Item("Turno") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Turno") = Tablas.Item("Dtt_Turnos").Select("Nombre Like '" & Dtt.Rows(I).Item("Turno") & "'")(0)("Nombre")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Turno""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Turno") & """; No existe, está mal escrito, o no está registrado en base de datos"
                    End Try
                End If
                'validar estados civiles
                If Dtt.Rows(I).Item("Estado Civil") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Estado Civil") = Tablas.Item("Dtt_Estados_Civiles").Select("Nombre Like '" & Dtt.Rows(I).Item("Estado Civil") & "'")(0)("Nombre")
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Estado Civil""!: No se encontró coincidencia con el texto """ & Dtt.Rows(I).Item("Estado Civil") & """; No existe, está mal escrito, o no está registrado en base de datos"
                    End Try
                End If
                'validar Fecha de Retiro
                If Dtt.Rows(I).Item("Fecha de Retiro") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Fecha de Retiro") = CDate(Dtt.Rows(I).Item("Fecha de Retiro"))
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Fecha de Retiro""!: El texto """ & Dtt.Rows(I).Item("Fecha de Retiro") & """ No es una fecha, o no tiene el formato ""dd/MM/yyyy"""
                    End Try
                End If
                'validar Fecha Inicio Operación
                If Dtt.Rows(I).Item("Fecha Inicio Operación") <> Nothing Then
                    Try
                        Dtt.Rows(I).Item("Fecha Inicio Operación") = CDate(Dtt.Rows(I).Item("Fecha Inicio Operación"))
                    Catch ex As Exception
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Fecha Inicio Operación""!: El texto """ & Dtt.Rows(I).Item("Fecha Inicio Operación") & """ No es una fecha, o no tiene el formato ""dd/MM/yyyy"""
                    End Try
                End If
                'validar si estudia
                If Dtt.Rows(I).Item("Estudia") <> Nothing Then
                    If Dtt.Rows(I).Item("Estudia") <> "SI" And Dtt.Rows(I).Item("Estudia") <> "NO" Then
                        Return "¡Error en la fila """ & I + 1 & """ columna ""Estudia""!: El texto """ & Dtt.Rows(I).Item("Estudia") & """ Es incorrecto, pues solo se acepta ""SI"" o ""NO"""
                    End If
                End If
                '''''''''''''''''''''''''''''''''''''''''''
            Next
            Return Dtt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Registrar_Acta_Credenciales()
        Dim Con = Con_admin_cham
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@strlidusuario", strlidusuario.Trim)
            Scm.Parameters.AddWithValue("@_Fecha_Acta", _Fecha_Acta)
            Scm.Parameters.AddWithValue("@strlcodigo", strlcodigo.Trim)
            Scm.CommandText = "Update Personal_Credenciales Set Fecha_Acta = @_Fecha_Acta, Id_Usuario_Acta = @strlidusuario Where Codigo = @strlcodigo"
            Return Scm.ExecuteNonQuery
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function

    Public Function Consultar_credenciales() As DataTable
        Dim cn = Con_admin_cham
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim Sql_Frag As String = Nothing
        Try
            If strlcodigo <> Nothing Then
                cms.Parameters.AddWithValue("@strlcodigo", strlcodigo)
                Sql_Frag = " And pc.codigo=@strlcodigo "
            End If
            If _Plataforma <> Nothing Then
                cms.Parameters.AddWithValue("@_Plataforma", _Plataforma)
                Sql_Frag = Sql_Frag & " And p.Fk_plataforma=@_Plataforma "
            End If
            If _Estado_Plataforma <> Nothing Then
                cms.Parameters.AddWithValue("@_Estado_Plataforma", _Estado_Plataforma)
                Sql_Frag = Sql_Frag & " And p.Estado_Plataforma=@_Estado_Plataforma "
            End If
            If strlfcini <> Nothing Then
                cms.Parameters.AddWithValue("@strlfcini", strlfcini)
                Sql_Frag = Sql_Frag & " And convert(date,Fc_Actualiza) >= @strlfcini "
            End If
            If strlfcfin <> Nothing Then
                cms.Parameters.AddWithValue("@strlfcfin", strlfcfin)
                Sql_Frag = Sql_Frag & " And convert(date,Fc_Actualiza) <= @strlfcfin "
            End If
            cn.Open()
            cms.Connection = cn
            cms.CommandText = "Select Pc.Codigo,p.codigo_asignacion,pc.fc_reg ,pc.Id_Usuario ,e.Nombre as plataforma ,p.Estado_Plataforma,Usuario_Plataforma,Password_plataforma,Fc_Actualiza,Usuario_Actualiza,formato,fcreg from Plataforma P inner join Personal_Credenciales Pc on P.Fk_codnom =PC.Codigo INNER JOIN Estado_Usu E ON e.Cod_Estado_Usu=p.Fk_plataforma left join (select d2.* from Detalle_Plataforma d2 inner join (SELECT MAX(Id_Detalle_Plataforma) as Id_Detalle_Plataforma from Detalle_Plataforma group by Fk_Plataforma) as D1 on d1.Id_Detalle_Plataforma = d2.Id_Detalle_Plataforma) as  DP on dp.Fk_Plataforma=p.Codigo_Asignacion left join (select formato,fk_plataforma,fcreg  from solicitud_credenciales S2 inner join (SELECT MAX(codigo_solicitud) as Credencial from solicitud_credenciales group by fk_plataforma) as S1 on s1.Credencial  = s2.codigo_solicitud) S  on p.Codigo_Asignacion = s.fk_plataforma where 1=1 " & Sql_Frag
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts.Tables(0)
        Catch ex As Exception
            Throw ex
        Finally
            cms.Parameters.Clear()
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function



End Class