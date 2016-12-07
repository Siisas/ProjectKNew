Public Class clsgeneral
    Protected strlidusuario As String
    Protected strlnombre As String
    Protected strlcargo As String
    Protected strlut As String
    Protected strlpwd As String
    Protected strlnombreut As String
    Protected intidentidad As Int64
    Protected intidtip As Integer
    Protected intcantreg As Integer
    Protected strlnombreentidad As String
    Protected strlestado As String
    Protected strldpto As String
    Protected strlmun As String
    Protected strltipo As String
    Protected strllocalidad As String
    Protected strlCod_Diagnostico As String
    Protected _Validacion As String

    Public Property Validacion As String
        Get
            Return _Validacion
        End Get
        Set(ByVal value As String)
            _Validacion = value
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

    Public Property localidad() As String
        Get
            Return strllocalidad
        End Get
        Set(ByVal Value As String)
            strllocalidad = Value
        End Set
    End Property
    Public Property tipo() As String
        Get
            Return strltipo
        End Get
        Set(ByVal Value As String)
            strltipo = Value
        End Set
    End Property
    Public Property mun() As String
        Get
            Return strlmun
        End Get
        Set(ByVal Value As String)
            strlmun = Value
        End Set
    End Property
    Public Property dpto() As String
        Get
            Return strldpto
        End Get
        Set(ByVal Value As String)
            strldpto = Value
        End Set
    End Property
    Public Property cantreg() As Integer
        Get
            Return intcantreg
        End Get
        Set(ByVal Value As Integer)
            intcantreg = Value
        End Set
    End Property
    Public Property idtip() As Integer
        Get
            Return intidtip
        End Get
        Set(ByVal Value As Integer)
            intidtip = Value
        End Set
    End Property
    Public Property identidad() As Int64
        Get
            Return intidentidad
        End Get
        Set(ByVal Value As Int64)
            intidentidad = Value
        End Set
    End Property
    Public Property estado() As String
        Get
            Return strlestado
        End Get
        Set(ByVal Value As String)
            strlestado = Value
        End Set
    End Property
    Public Property nombreentidad() As String
        Get
            Return strlnombreentidad
        End Get
        Set(ByVal Value As String)
            strlnombreentidad = Value
        End Set
    End Property

    Public Property idusuario() As String
        Get
            Return strlidusuario
        End Get
        Set(ByVal Value As String)
            strlidusuario = Value
        End Set
    End Property
    Public Property nombreut() As String
        Get
            Return strlnombreut
        End Get
        Set(ByVal Value As String)
            strlnombreut = Value
        End Set
    End Property
    Public Property pwd() As String
        Get
            Return strlpwd
        End Get
        Set(ByVal Value As String)
            strlpwd = Value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return strlnombre
        End Get
        Set(ByVal Value As String)
            strlnombre = Value
        End Set
    End Property
    Public Property cargo() As String
        Get
            Return strlcargo
        End Get
        Set(ByVal Value As String)
            strlcargo = Value
        End Set
    End Property
    Public Property ut() As String
        Get
            Return strlut
        End Get
        Set(ByVal Value As String)
            strlut = Value
        End Set
    End Property
    Protected _PaginaAcceso As String
    Public Property PaginaAcceso() As String
        Get
            Return _PaginaAcceso
        End Get
        Set(ByVal Value As String)
            _PaginaAcceso = Value
        End Set
    End Property
    Protected _DtsSeguridad As DataSet
    Public Property DtsSeguridad() As DataSet
        Get
            Return _DtsSeguridad
        End Get
        Set(ByVal Value As DataSet)
            _DtsSeguridad = Value
        End Set
    End Property

    Protected _DivPol_Id_Ciudad As Integer
    Protected _DivPol_Id_Estado As Integer
    Protected _DivPol_Id_Pais As Integer
    Public Property DivPol_Id_Ciudad As Integer
        Get
            Return _DivPol_Id_Ciudad
        End Get
        Set(ByVal Value As Integer)
            _DivPol_Id_Ciudad = Value
        End Set
    End Property
    Public Property DivPol_Id_Estado As Integer
        Get
            Return _DivPol_Id_Estado
        End Get
        Set(ByVal Value As Integer)
            _DivPol_Id_Estado = Value
        End Set
    End Property
    Public Property DivPol_Id_Pais As Integer
        Get
            Return _DivPol_Id_Pais
        End Get
        Set(ByVal Value As Integer)
            _DivPol_Id_Pais = Value
        End Set
    End Property

    Protected _Cod_Causa_Raiz As Integer
    Public Property Cod_Causa_Raiz() As Integer
        Get
            Return _Cod_Causa_Raiz
        End Get
        Set(ByVal Value As Integer)
            _Cod_Causa_Raiz = Value
        End Set
    End Property


    Protected Conexion_ERP As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function consultar() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dtsusuario As New DataSet
        Dim sql As String
        Dim dtausuario As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If strlut = Nothing Then
                sql = "SELECT * FROM usuarios INNER JOIN UT ON usuarios.ut=ut.idut ORDER BY usuarios.nombreu"
            Else
                sql = "SELECT * FROM usuarios INNER JOIN UT ON usuarios.ut=ut.idut WHERE ut= @strlut ORDER BY usuarios.nombreu"
                cms.Parameters.Add("@strlut", SqlDbType.NVarChar, 50)
                cms.Parameters("@strlut").Value = strlut
            End If
            cms.Connection = cn
            dtausuario = New SqlClient.SqlDataAdapter(cms)
            dtausuario.Fill(dtsusuario)
            Return dtsusuario
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Function consultaagentes() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dtsusuario As New DataSet
        Dim sql As String
        Dim dtausuario As SqlClient.SqlDataAdapter
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            sql = "SELECT * FROM usuarios ORDER BY usuarios.nombreu"
            dtausuario = New SqlClient.SqlDataAdapter(sql, cn)
            dtausuario.Fill(dtsusuario) 'Ir a la base de datos con la conexión y el select, el sql queda almacenado en esta variable
            Return dtsusuario
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultarusuario() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM usuarios INNER JOIN UT ON usuarios.ut=ut.idut WHERE idusuario = @strlidusuario"
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50)
            cms.Parameters("@strlidusuario").Value = strlidusuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlnombre = dts.Tables(0).Rows(0).Item("nombreu") 'Guarda en la variable strldpto el item de la tabla0, fila0
            strlcargo = dts.Tables(0).Rows(0).Item("cargo")
            strlut = dts.Tables(0).Rows(0).Item("ut")
            strlnombreut = dts.Tables(0).Rows(0).Item("nombreut")
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultarmenu() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT dbo.menus.menuid, dbo.menus.descripcion, dbo.menus.padreid, dbo.menus.posicion, dbo.menus.url FROM dbo.Perfil INNER JOIN dbo.menus INNER JOIN dbo.permisos ON dbo.menus.menuid = dbo.permisos.menuid ON dbo.Perfil.idperfil = dbo.permisos.perfil where permisos.perfil=@perfil and permisos.visible='S' order by posicion"
            cms.Parameters.Add("@perfil", SqlDbType.NVarChar, 3).Value = strlestado
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultartipificacion() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT Tipificacion1 FROM tipificaciones2 where pertenece='Estado' order by cod_tipificacion"
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


    Public Function consultartipificacionventa() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion where venta='S' order by orden"
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

    Public Function consultardatosagentes() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM usuarios  where perfil=3 order by nombreu"
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

    Public Function consultarHoras() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM Horas where agenda like '%' + @strlagenda + '%'"
            cms.Parameters.Add("@strlagenda", SqlDbType.NVarChar, 3).Value = strlestado
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
    Public Function consultarresultado() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM resultado where idtip=@idtip"
            cms.Parameters.Add("@idtip", SqlDbType.Int).Value = intidtip
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
    

    Public Function consultaproyecto() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM proyecto order by nombreproyecto"
            If idtip <> Nothing Then
                cms.CommandText = "SELECT * FROM proyecto where estado ='A' order by nombreproyecto "
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
    Public Function consultatsoporte() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tiposoporte order by tipo_soporte"
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
    Public Function consultatipificacion() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion where uso='datos' order by tipificacion "
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
    Public Function consultaing() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM ingenieroclaro order by ingclaro"
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
    Public Function consultatipdilo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion where uso='dilo' order by tipificacion "
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
    Public Function consultatipinc() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion where uso='incid' order by tipificacion "
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
    Public Function consultaarea() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM Area where pertenece='Personal' or pertenece is null order by area"
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

    Public Function consultatipoactualizacion() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipoactualizacion order by tipoactualizacion"
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

    Public Function consultatipodoc() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipodoc order by descripciontipodoc"
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
    Public Function consultausuario() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM usuarios where activo is null order by nombreu"
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
    Public Function consultatipificacionconexred() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion1").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion order by tipificacion "
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
    Public Function consultamarca() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT marca FROM EquipoStandar GROUP BY marca order by marca"
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
    Public Function consultaequipo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If strlestado <> Nothing Then
                cms.CommandText = "SELECT marca, equipo FROM EquipoStandar WHERe marca = @strlestado ORDER BY marca"
                cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 100).Value = strlestado
            Else
                cms.CommandText = "SELECT marca, equipo FROM EquipoStandar ORDER BY marca"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            cms.Parameters.Clear()
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultadpto() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT coddpto, nombredpto FROM Divipola GROUP BY coddpto, nombredpto order by nombredpto"
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
    Public Function consultamun() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Validacion = "Resolved" And strldpto <> Nothing Then
                cms.CommandText = "SELECT coddiv, nombremun FROM divipola WHERe NOMBREDPTO = @strldpto ORDER BY nombredpto"
                cms.Parameters.Add("@strldpto", SqlDbType.VarChar).Value = strldpto
            ElseIf strldpto <> Nothing Then
                cms.CommandText = "SELECT coddiv, nombremun FROM divipola WHERe coddpto = @strldpto ORDER BY nombredpto"
                cms.Parameters.Add("@strldpto", SqlDbType.VarChar).Value = strldpto
            Else
                cms.CommandText = "SELECT coddiv, nombremun FROM divipola ORDER BY nombredpto"
            End If

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            cms.Parameters.Clear()
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaperiodo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM periodo order by id"
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
    Public Function consultacod() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT idusuario, gruposup, perfil, codnom FROM usuarios where idusuario=@strlidusuario"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            intcantreg = dtsrecepcion.Tables(0).Rows.Count
            If intcantreg > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("codnom") Is System.DBNull.Value Then
                    strlcargo = " "
                Else
                    strlcargo = dtsrecepcion.Tables(0).Rows(0).Item("codnom")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("gruposup") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("gruposup")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("perfil") Is System.DBNull.Value Then
                    strlestado = " "
                Else
                    strlestado = dtsrecepcion.Tables(0).Rows(0).Item("perfil")
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
    Public Function consultared() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT activo,asigc,red, xasig,creac FROM usuarios where idusuario=@strlidusuario"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            intcantreg = dtsrecepcion.Tables(0).Rows.Count
            If intcantreg > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("activo") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("activo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("red") Is System.DBNull.Value Then
                    strlcargo = " "
                Else
                    strlcargo = dtsrecepcion.Tables(0).Rows(0).Item("red")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("xasig") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("xasig")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("creac") Is System.DBNull.Value Then
                    strlestado = " "
                Else
                    strlestado = dtsrecepcion.Tables(0).Rows(0).Item("creac")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("asigc") Is System.DBNull.Value Then
                    strllocalidad = " "
                Else
                    strllocalidad = dtsrecepcion.Tables(0).Rows(0).Item("asigc")
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
    Public Function consultatipoact() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipoinasistencia where estado = 1 order by descripcioninasistencia"
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
    Public Function consultatiponoved() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tiponovedad where novedad=@strltipo or novedad='0' order by desctipo"
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 100).Value = Me.strltipo
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
    Public Function consultatipctrl() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion where uso='control' order by tipificacion "
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
    Public Function consultatsoportevoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If strlcargo = 1 Then
                cms.CommandText = "SELECT * FROM VTiposoporte Where estagogest=@strltipo AND estadobandeja='V' order by tipifcrm"
            Else
                cms.CommandText = "SELECT * FROM VTiposoporte Where estagogest=@strltipo AND estadobandeja='B' order by tipifcrm"
            End If

            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 50).Value = Me.strltipo
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
    Public Function consultatipificacionvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If strlcargo = 1 Then
                cms.CommandText = "SELECT estagogest FROM VTiposoporte GROUP BY estagogest, estadobandeja having estadobandeja='v' order by estagogest"
            Else
                cms.CommandText = "SELECT estagogest FROM VTiposoporte GROUP BY estagogest, estadobandeja having estadobandeja='b' order by estagogest"
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
    Public Function consultasoportevoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If strlcargo = 1 Then
                cms.CommandText = "SELECT * FROM Vsoporte where mesa='V' order by destiposoporte"
            Else
                cms.CommandText = "SELECT * FROM Vsoporte where mesa='B' order by destiposoporte"
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
    Public Function consultalocalidad() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT localidad FROM Barrio GROUP BY localidad order by localidad"
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
    Public Function consultabarrio() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM barrio WHERe localidad = @strllocalidad ORDER BY barrio"
            cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 20).Value = strllocalidad
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
    Public Function consultaagenteescala() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT idusuario, nombreu FROM usuarios where (red=88 or red=99) and pwd <> 'R'  and (cargo like 'N%' or cargo like 'Q%') order by nombreu"
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
    Public Function consultacaract() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM caracteristica  where campana='Voz' order by idcarac"
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
    Public Function consultacaractdat() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM caracteristica  where campana='Datos' order by idcarac"
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
    Public Function consultaestadocpd() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM estadocpd where estadocaso <> 'No_Aplica' order by estadocpd"
            If _Validacion = "Estados_SD" Then
                cms.CommandText = "Select Nombre from BD_Voz_Complemento where Pertenece='Estado_SD' Union Select'- Seleccione -'"
            End If

            If _Validacion = "CARGAR_BANDEJAS" Then
                cms.CommandText = "Select Nombre from BD_Voz_Complemento where Pertenece='BANDEJAS' Union Select'- Seleccione -'"
            End If
            If _Validacion = "Estado_Cliente" Then
                cms.CommandText = "Select Cod_BD_Voz_Complemento,Nombre from BD_Voz_Complemento where Pertenece='Estado_Cliente' Union Select 0,'- Seleccione -'"
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
    Public Function consultatipocert() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM documento order by tipodoc "
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
    Public Function consultadigitador() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            '99 cod red para identificar digitadores
            cms.CommandText = "SELECT idusuario, nombreu FROM usuarios where red=99 order by nombreu"
            If strlnombre = 1 Then
                cms.CommandText = "SELECT idusuario, nombreu FROM usuarios where red=99 or red=88 order by nombreu"
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
    Public Function consultagrupo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT GRUPO FROM Tipificacion_CRM_2 WHERE GRUPO IS NOT NULL AND activo IS NULL GROUP BY GRUPO ORDER BY GRUPO"
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
    Public Function consultatsoportegrupo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select id,escenario, grupo from Tipificacion_CRM_2 where GRUPO=@strltipo group by ESCENARIO, grupo, id order by escenario"
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 255).Value = strltipo
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcargo = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaincvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select * from inconsistencia where mesa='Voz' order by inconsistencia "
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcargo = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaincdatos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select * from inconsistencia where mesa='Datos' order by inconsistencia "
            If strlcargo = "Global" Then
                cms.CommandText = "select idtipoinc,inconsistencia from Inconsistencia where mesa='GLOBAL_GEN' OR idtipoinc = 0"
            End If
            If strlcargo = "Global2" Then
                cms.CommandText = "select * from Inconsistencia where (mesa='Datos' and inconsistencia='- Seleccione -' ) "
            End If
            If strlcargo = "Inconsistencia" Then
                cms.CommandText = "Select idtipoinc,inconsistencia from Inconsistencia where Pertenece=@strlestado OR idtipoinc = 0"
                cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 10).Value = strlestado
            End If
            If strlcargo = "Inconsistencia_BSCS" Then
                cms.CommandText = "Select * from inconsistencia where (mesa='Datos' and inconsistencia='- Seleccione -' ) or Pertenece=@strlestado order by inconsistencia asc"
                cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 10).Value = strlestado
            End If
            If strlcargo = "GlobalBienv" Then
                cms.CommandText = "select * from Inconsistencia where (mesa='Datos' and inconsistencia='- Seleccione -') or (mesa='Global' and Pertenece='Bienv')"
            End If
            If strlcargo = "InconsistenciaBienv" Then
                cms.CommandText = "Select top 4 * from inconsistencia where (mesa='Datos' and inconsistencia='- Seleccione -') or Pertenece=@strlestado order by inconsistencia asc"
                cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 10).Value = strlestado
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcargo = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Function consulta_campaña_inb() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT nombre FROM BD_Datos_Complemento WHERe Pertenece = 'Campaña_Inbound' ORDER BY nombre"
            If _Validacion = "Ubicacion_call" Then
                cms.CommandText = "SELECT nombre FROM BD_Datos_Complemento WHERe Pertenece = 'Ubicación_call' ORDER BY nombre"
            ElseIf _Validacion = "Justificacion" Then
                cms.CommandText = "SELECT nombre FROM BD_Datos_Complemento WHERe Pertenece = 'Justificacion_segui' ORDER BY nombre"
            ElseIf _Validacion = "Canal_Dilo" Then
                cms.CommandText = "SELECT nombre FROM BD_Datos_Complemento WHERe Pertenece = 'Canal_Dilo' ORDER BY nombre"
            ElseIf _Validacion = "Tipo_Canal_Dilo" Then
                cms.CommandText = "SELECT nombre FROM BD_Datos_Complemento WHERe Pertenece = '" & strltipo & "' ORDER BY nombre"
            ElseIf _Validacion = "Tipo_Llamada" Then
                cms.CommandText = "SELECT nombre FROM BD_Datos_Complemento WHERe Pertenece = 'Tipo_Llamada' ORDER BY nombre"
            ElseIf _Validacion = "Ubicacion_call2" Then
                cms.CommandText = "Select tipificacion1 as nombre,tipificacion2 as valor from Tipificaciones where pertenece='Ubicación_call'"
            ElseIf _Validacion = "Falla_Masiva" Then
                cms.CommandText = "SELECT nombre FROM BD_Datos_Complemento WHERe Pertenece = 'Falla_Masiva' ORDER BY nombre"

            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function



    Public Function consultatipificapqr() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion where uso='pqr' order by tipificacion "
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
    Public Function tipofallapqr() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM TipoFallaPQR Where tipif=@strltipo order by tipofalla"
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 50).Value = Me.strltipo
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
    Public Function constiposoporte() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM TipoSoporte_PQR where afecta=@strltipo order by tiposoporte"
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 50).Value = Me.strltipo
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
    Public Function consultaagente() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            '99 cod red para identificar digitadores
            cms.CommandText = "SELECT idusuario, nombreu FROM usuarios order by nombreu"
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
    Public Function consultadiagnostico() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM diagnostico where idgrupo=@strlidusuario order by detalle"
            cms.Parameters.Add("@strlidusuario", SqlDbType.Int).Value = Me.strlidusuario
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
    Public Sub ingcentinela()
        Dim cn As New SqlClient.SqlConnection
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            cn.Open()
            strlnombreut = Now
            cms.CommandText = "insert into centinela(idusuario,fcingreso)values(@strlcargo,@strlnombreut)"
            cms.Parameters.Add("@strlcargo", SqlDbType.NVarChar).Value = Me.strlcargo
            cms.Parameters.Add("@strlnombreut", SqlDbType.DateTime).Value = Me.strlnombreut
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
    Public Function consultabandejadatos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT Bandeja FROM Bandeja group by bandeja order by bandeja"
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
    Public Function BolTipo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM Bol_Tipo order by Cod_Bol_Tipo asc"
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
    Public Function BolSegmento() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If strlestado <> Nothing Then
                cms.CommandText = "SELECT * FROM Bol_Segmento Where Fk_Cod_Bol_Tipo = @strlestado ORDER BY Cod_Bol_Segmento"
                cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 100).Value = strlestado
            Else
                cms.CommandText = "SELECT * FROM Bol_Segmento order by Cod_Bol_Segmento asc"
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
    Public Function traeusuario() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT idusuario, codnom FROM usuarios where codnom=@strlidusuario"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            intcantreg = dtsrecepcion.Tables(0).Rows.Count
            If intcantreg > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("idusuario") Is System.DBNull.Value Then
                    strlcargo = " "
                Else
                    strlcargo = dtsrecepcion.Tables(0).Rows(0).Item("idusuario")
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
    Public Function consultatipificaciongral() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion where uso='gral' order by tipificacion "
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
    Public Function consultadiagnosticovoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM diagnostico where idgrupo=@strlidusuario order by detalle"
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = Me.strlidusuario
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
    Public Function consultadiagnosticovoztipif() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM diagnostico where tipo=@strlidusuario order by detalle"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 255).Value = Me.strlidusuario
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
    Public Function consultatiposolic() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM MC_Tiposolicitud order by descsolicitud"
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
    Public Function consultaprioridad() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM MC_Prioridad order by descprioridad"
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
    Public Function consultaestado() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM MC_Estado order by descestado"
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
    Public Function consultaagentegrupo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select nombreu,idusuario from usuarios where nombreu='- Seleccione -' union select nombreu,idusuario from usuarios where (red=99 or red=88) and (cargo like 'N%' or cargo like 'Q%' ) and pwd <>'0' and pwd <> 'R' and cargo <>'retirado' order by nombreu"
            If _Validacion = "Calidad" Then
                cms.CommandText = "select idusuario,nombreu from usuarios where perfil=40 and pwd<>'R' and cargo like 'Q%'"
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

    Public Function consultatipificacionn3() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion where uso='datos3' order by tipificacion "
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
    Public Function consultaareaasigna() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM MC_Asigna order by descarea"
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
  
    Public Function consultareclamo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM Reclamoppal order by descreclamo"
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
    Public Function consultatipofalla() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM TipoFalla where recppal=@strltipo order by desctipofalla"
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 255).Value = Me.strltipo
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
    Public Function consultaapn() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM apn order by apn"
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
    Public Function consultaqos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM qos order by qos"
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
    Public Function consultalineadt() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select tipo from diagnostico where idgrupo=@identidad group by tipo order by tipo"
            cms.Parameters.Add("@identidad", SqlDbType.Int).Value = Me.identidad
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

    Public Function consultalineavoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select tipo from diagnostico where idgrupo=20 group by tipo order by tipo"
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
    Public Function consultaservicio() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select tipo,tipo2 from diagnostico where tipo=@strllocalidad and idgrupo=@identidad group by tipo,tipo2 order by tipo2"
            cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = Me.strllocalidad
            cms.Parameters.Add("@identidad", SqlDbType.Int).Value = Me.identidad
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
    Public Function consultasubservicio() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select tipo,tipo2,tipificacion from diagnostico where tipo=@strllocalidad and tipo2=@strlmun and idgrupo=@identidad group by tipo,tipo2,tipificacion order by tipificacion"
            cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = Me.strllocalidad
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 255).Value = Me.strlmun
            cms.Parameters.Add("@identidad", SqlDbType.Int).Value = Me.identidad
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
    Public Function consultasolicitud() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select tipo,tipo2,tipificacion,detalle,idreg from diagnostico where tipo=@strllocalidad and tipo2=@strlmun and tipificacion=@strlnombre and idgrupo=@identidad group by tipo,tipo2,tipificacion,detalle,idreg order by detalle"
            cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = Me.strllocalidad
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 255).Value = Me.strlmun
            cms.Parameters.Add("@strlnombre", SqlDbType.VarChar, 255).Value = Me.strlnombre
            cms.Parameters.Add("@identidad", SqlDbType.Int).Value = Me.identidad
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
    Public Function Consulta_Diagnostico() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from informacion_Medica where cod_Informacion_Medica = @strlCod_Diagnostico"
            cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 50).Value = Me.strlCod_Diagnostico
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultagrupoResticcion() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If Validacion = 1 Then
                cms.CommandText = "SELECT GRUPO FROM Tipificacion_CRM_2 TC inner join Tipificacion_CRM_2_Restriccion TCR on TC.id = TCR.Fk_Id_Tipificacion_CRM_2 WHERE TCR.Tipificacion='No Contactado' GROUP BY GRUPO ORDER BY GRUPO"
            Else
                cms.CommandText = "SELECT GRUPO FROM Tipificacion_CRM_2 TC inner join Tipificacion_CRM_2_Restriccion TCR on TC.id = TCR.Fk_Id_Tipificacion_CRM_2 WHERE TCR.Tipificacion=@strlestado GROUP BY GRUPO ORDER BY GRUPO"
                cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 50).Value = strlestado
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
    Public Function consultatsoportegrupoRestriccion() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select id,escenario, grupo from Tipificacion_CRM_2 TC inner join Tipificacion_CRM_2_Restriccion TCR on TC.id = TCR.Fk_Id_Tipificacion_CRM_2 WHERE TCR.Tipificacion=@strlestado and TC.GRUPO=@strltipo group by ESCENARIO, grupo, id order by escenario"
            cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 50).Value = strlestado
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 255).Value = strltipo
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcargo = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function ConsultaSinRestriccion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from SinResctriccion where idusuario=@strlidusuario"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Perfiles() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = "1" Then
                cms.CommandText = "select * from perfil where agente='C' order by descriperfil"
            End If
            If Validacion = "2" Then
                cms.CommandText = "select * from usuarios where idusuario=Supervisor or nombreu='- Seleccione -' order by nombreu"
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
    Public Sub Actualiza_Perfil()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = "1" Then
                cms.CommandText = "update usuarios set perfil=@intidtip where idusuario=@strlidusuario"
                cms.Parameters.Add("@intidtip", SqlDbType.Int).Value = intidtip
            End If
            If Validacion = "2" Then
                cms.CommandText = "update usuarios set Supervisor=@strlnombre where idusuario=@strlidusuario"
                cms.Parameters.Add("@strlnombre", SqlDbType.VarChar, 50).Value = strlnombre
            End If
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
    Public Function Consulta_drl_Asignacion_Lib_Manual() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from BD_Voz_Complemento where Pertenece=@strlnombre or Nombre='- Seleccione -' order by Nombre"
            cms.Parameters.Add("@strlnombre", SqlDbType.VarChar).Value = strlnombre
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
    Public Function Consulta_Tipificacion_General() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM tipificacion where uso=@strlnombre order by tipificacion "
            cms.Parameters.Add("@strlnombre", SqlDbType.VarChar).Value = strlnombre
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
    Public Function Consulta_Complemento_General() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Select * from BD_Datos_Complemento where pertenece=@_Validacion or nombre='- Seleccione -' order by nombre"
            cms.Parameters.Add("@_Validacion", SqlDbType.VarChar, 50).Value = _Validacion
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
    Public Function Consulta_Cargue_Catalogo_Servicio_V2() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ''Conexion a la base de datos
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            '''''''''Catalogo de Servicio 3 drl
            If _Validacion = "Tipo PQR Adicional" Then
                cms.CommandText = "select tipo,tipo2 from Diagnostico where idgrupo=15 or tipo='- Seleccione -' group by tipo,tipo2 order by tipo"
            End If
            If _Validacion = "Intencion Des Por Falla" Then
                cms.CommandText = "select tipo,tipo2 from Diagnostico where idgrupo=16 or tipo='- Seleccione -' group by tipo,tipo2 order by tipo"
            End If
            If _Validacion = "Tipo Proceso Linea" Then
                cms.CommandText = "select tipo,tipo2 from Diagnostico where idgrupo=17 or tipo='- Seleccione -' group by tipo,tipo2 order by tipo"
            End If
            If _Validacion = "Tipo PQR" Then
                cms.CommandText = "select tipo,tipo2 from Diagnostico where idgrupo=11 or tipo='- Seleccione -' group by tipo,tipo2 order by tipo"
            End If
            If _Validacion = "Tipo Cliente" Then
                cms.CommandText = "select tipo,tipo2 from Diagnostico where idgrupo=12 or tipo='- Seleccione -' group by tipo,tipo2 order by tipo"
            End If
            If _Validacion = "Modalidad" Then
                cms.CommandText = "select tipo,tipo2 from Diagnostico where idgrupo=13 or tipo='- Seleccione -' group by tipo,tipo2 order by tipo"
            End If
            '''''''''CATALOGO DE DIAGNOSTICO
            If _Validacion = "Segmento" Then
                cms.CommandText = "select tipo from diagnostico where (idgrupo=10 or tipo='- Seleccione -') group by tipo order by tipo"
            End If
            If _Validacion = "Elemento" Then
                cms.CommandText = "select tipo,tipo2 from diagnostico where idgrupo=10 and (tipo='- Seleccione -' or tipo=@strllocalidad) group by tipo,tipo2 order by tipo2"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
            End If
            If _Validacion = "Tipo de falla" Then
                cms.CommandText = "select tipo,tipo2,tipificacion from diagnostico where idgrupo=10 and tipo='- Seleccione -' or tipo=@strllocalidad and tipo2=@strlmun group by tipo,tipo2,tipificacion order by tipificacion"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
                cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 255).Value = strlmun
            End If
            If _Validacion = "Causa raiz Inicial" Then
                cms.CommandText = "select tipo,tipo2,tipificacion,detalle,Max(idreg) as idreg from diagnostico where idgrupo=10 and tipo='- Seleccione -' or tipo=@strllocalidad and tipo2=@strlmun and tipificacion=@strlnombre group by tipo,tipo2,tipificacion,detalle order by detalle"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
                cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 255).Value = strlmun
                cms.Parameters.Add("@strlnombre", SqlDbType.VarChar, 255).Value = strlnombre
            End If
            If _Validacion = "Causa raiz" Then
                cms.CommandText = "select tipo,tipo2,tipificacion,detalle,idreg from diagnostico where idgrupo=10 and tipo='- Seleccione -' or tipo=@strllocalidad and tipo2=@strlmun and tipificacion=@strlnombre group by tipo,tipo2,tipificacion,detalle,idreg order by detalle"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
                cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 255).Value = strlmun
                cms.Parameters.Add("@strlnombre", SqlDbType.VarChar, 255).Value = strlnombre
            End If
            '''''''''CATEGORIA DE CIERRE
            If _Validacion = "Categoria de cierre" Then
                cms.CommandText = "select tipificacion,Max(idreg) as idreg from diagnostico where (idgrupo=14 or tipificacion='- Seleccione -') group by tipificacion order by tipificacion"
            End If
            If _Validacion = "Categoria de cierre lbl" Then
                cms.CommandText = "select detalle from diagnostico where tipificacion=@strlnombre"
                cms.Parameters.Add("@strlnombre", SqlDbType.VarChar, 255).Value = strlnombre
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
    Public Function Consulta_Numero_PQR() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "select Nombre from BD_Datos_Complemento where Pertenece='Numero_PQR'"
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
    Public Function Consulta_Tipo_Asigna_FallaTec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Select * from BD_Datos_Complemento where Pertenece='Tipo_FallaTec' or Pertenece='- Seleccione -'"
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
    Public Function Consulta_Complemento_CanalDilo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "select * from BD_Voz_Complemento where Pertenece ='CanalDiloFallared' or nombre ='- Seleccione -' order by Nombre"
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
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''' PERMISOS SEGURIDAD ''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Function Consulta_Proyecto_Seguridad() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "select Nombre from BD_admin_Complemento where Pertenece='SeguridadPerfil'"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Nombre") Is DBNull.Value Then
                    strlnombreentidad = "1"
                Else
                    strlnombreentidad = dts.Tables(0).Rows(0).Item("Nombre")
                End If
            Else
                strlnombreentidad = "1"
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
    ''''''''''Servicio Cliente''''''''''''
    Public Function Carga_Drl_Servicio_Cliente_SAC() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select Nombre from BD_Datos_Complemento where Pertenece=@_Validacion or Pertenece='- Seleccione -' order by Nombre"
            cms.Parameters.Add("@_Validacion", SqlDbType.VarChar, 500).Value = _Validacion
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
    '''MODIFICACION CRM'''
    Public Function Consulta_Cargue_Catalogo_Diagnostico() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ''Conexion a la base de datos
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            '''''''''Catalogo de Servicio 3 drl

            '''''''''CATALOGO DE DIAGNOSTICO
            If _Validacion = "Causa raiz" Then 'TIPIFICACION 1
                cms.CommandText = "Select  tipificacion1 from Tipificaciones where pertenece='Catalogo diagnostico' group by tipificacion1"
            End If
            If _Validacion = "Causa raiz 2" Then 'TIPIFICACION 1
                cms.CommandText = "Select  tipificacion1 from Tipificaciones where pertenece='Catalogo diagnostico' and cod_tipificacion <> '16' group by tipificacion1"

            End If
            If _Validacion = "Segmento" Then 'TIPIFICACION 4
                cms.CommandText = "select  tipificacion4 from Tipificaciones where tipificacion1=@strllocalidad and pertenece='Catalogo diagnostico' group by tipificacion4 union select '- Seleccione -'"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad

            End If
            If _Validacion = "Elemento" Then 'TIPIFICACION 3
                cms.CommandText = "select  id_tipificacion,tipificacion3 from Tipificaciones where tipificacion4 = @strlnombre and tipificacion1=@strllocalidad and pertenece='Catalogo diagnostico' group by tipificacion3,id_tipificacion union select 03,'- Seleccione -'"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
                cms.Parameters.Add("@strlnombre", SqlDbType.VarChar, 255).Value = strlnombre
            End If
            If _Validacion = "Tipo de falla" Then 'TIPIFICACION 2
                cms.CommandText = "select tipificacion2,cod_tipificacion from Tipificaciones where id_tipificacion=@strllocalidad union select '- Seleccione -',03"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
            End If
            If _Validacion = "Tipo Soporte" Then 'TIPIFICACION 2
                cms.CommandText = "select cod_tipificacion,tipificacion2 from Tipificaciones  where Contains(tipificacion4,@strllocalidad) and pertenece = 'Cierre llamada' group by tipificacion2,cod_tipificacion union select 03,'- Seleccione -'"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
            End If
            If _Validacion = "Grupo" Then 'TIPIFICACION 2
                cms.CommandText = "select tipificacion1 from Tipificaciones  where Contains(tipificacion4,@strllocalidad) and tipificacion2=@strlnombre and pertenece = 'Cierre llamada'  group by tipificacion1"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
                cms.Parameters.Add("@strlnombre", SqlDbType.VarChar, 255).Value = strlnombre
            End If
            '''''''''CATEGORIA DE CIERRE
            If _Validacion = "Categoria de cierre" Then 'TIPIFICACION 1
                'cms.CommandText = "select T.tipificacion1,T.cod_tipificacion  from Tipificaciones T inner join ( select cod_tipificacion from Tipificaciones where Contains(tipificacion4,@strllocalidad) and tipificacion3=@strlnombre and pertenece = 'Cierre llamada'  group by cod_tipificacion) B on T.cod_tipificacion = B.cod_tipificacion where pertenece = 'Categoria Cierre' "
                cms.CommandText = "Select cod_tipificacion,tipificacion1 from Tipificaciones where pertenece= 'Categoria Cierre' and contains(tipificacion4,@strllocalidad) union select 03,'- Seleccione -'"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
            End If
            If _Validacion = "Estado" Then 'TIPIFICACION1
                cms.CommandText = "select cod_tipificacion,tipificacion2 from Tipificaciones where Pertenece='Estado' and tipificacion1 = @strllocalidad and contains(tipificacion4,@strlnombre) union select 03,'- Seleccione -'"
                cms.Parameters.Add("@strllocalidad", SqlDbType.VarChar, 255).Value = strllocalidad
                cms.Parameters.Add("@strlnombre", SqlDbType.VarChar, 255).Value = strlnombre
            End If

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)

            intcantreg = dts.Tables(0).Rows.Count
            If intcantreg > 0 Then
                If _Validacion = "Elemento" Then
                    If dts.Tables(0).Rows(0).Item("id_tipificacion") Is System.DBNull.Value Then
                        strltipo = " "
                    Else
                        strltipo = dts.Tables(0).Rows(dts.Tables(0).Rows.Count - 1).Item("id_tipificacion")
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


    Public Function Consulta_inconsistencia_encuesta() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select Cod_BD_Datos_Complemento,Nombre from BD_Datos_Complemento where Pertenece = 'encuesta_inconsistencia' union Select 0,'- Seleccione -'"
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


    Public Function Consulta_Configuracion_Red() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select tipificacion1,cod_tipificacion from Tipificaciones where pertenece = 'Respuesta_Config' union select '- Seleccione -', '0'"
            If _Validacion = "Config" Then
                cms.CommandText = "Select tipificacion1,cod_tipificacion from Tipificaciones where tipificacion4=@strlCod_Diagnostico and pertenece = 'Configuracion'  union select '- Seleccione -', '0' "
                cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.Decimal).Value = strlCod_Diagnostico
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

    '''Categoria cpd'''
    Public Function CategoriacierreCPD() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT tipificacion1,cod_tipificacion FROM Tipificaciones WHERE tipificacion1 LIKE '%tecnica%' and pertenece='Categoria cierre' union select '- Seleccione -',0"
            If Validacion = "Informatica" Then
                cms.CommandText = "SELECT tipificacion1,cod_tipificacion FROM Tipificaciones WHERE tipificacion1 LIKE '%informatica%' and pertenece='Categoria cierre' union select '- Seleccione -',0"
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

    Public Function Consulta_Campaña()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select  " &
                                  " idcaso,tickler,estado,Bandeja from (" &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'VOZ'" &
                                   " from clarovoz.dbo.ServiceDetalle S " &
                                   " INNER JOIN clarovoz.dbo.Bandeja_uni BU" &
                                   " ON S.idcaso = BU.idcaso)  " &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'VOZ'" &
                                   " from datosclaro.dbo.ServiceDetalle S " &
                                   " INNER JOIN clarovoz.dbo.Bandeja_uni BU " &
                                   " ON S.idcaso = BU.idcaso)" &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'DATOS'" &
                                   " from clarovoz.dbo.ServiceDetalle S " &
                                   " INNER JOIN datosclaro.dbo.Bandeja B" &
                                   " ON S.idcaso = B.cas_id)  " &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'DATOS'" &
                                   " from datosclaro.dbo.ServiceDetalle S " &
                                   " INNER JOIN datosclaro.dbo.Bandeja B" &
                                   " ON S.idcaso = B.cas_id)" &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'FALLA DES'  " &
                                   " from clarovoz.dbo.ServiceDetalle S" &
                                   " INNER JOIN  datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V FD ON S.idcaso = FD.Id_Caso  " &
                                   " left join datosclaro.dbo.Fecha_SAP FS on  convert (date,FD.Fc_Reg) = FS.Fcorta ) " &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'FALLA DES' " &
                                   " from datosclaro.dbo.ServiceDetalle S " &
                                   " INNER JOIN  datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V FD ON S.idcaso = FD.Id_Caso" &
                                   " left join datosclaro.dbo.Fecha_SAP FS on  convert (date,FD.Fc_Reg) = FS.Fcorta ) " &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'DILO'" &
                                   " from clarovoz.dbo.ServiceDetalle S" &
                                   " INNER JOIN datosclaro.dbo.Bandeja_alt BA  ON S.idcaso = BA.idcaso " &
                                   " left join datosclaro.dbo.Fecha_SAP FS on  convert (date,BA.fcreporte) = FS.Fcorta) " &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'DILO' " &
                                   " from datosclaro.dbo.ServiceDetalle S " &
                                   " INNER JOIN datosclaro.dbo.Bandeja_alt BA ON S.idcaso = BA.Idcaso" &
                                   " left join datosclaro.dbo.Fecha_SAP FS on  convert (date,BA.fcreporte) = FS.Fcorta) " &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'DATOS' " &
                                   " from clarovoz.dbo.ServiceDetalle S " &
                                   " INNER JOIN datosclaro.dbo.Bandeja B" &
                                   " ON S.idcaso = B.cas_id)  " &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'BSCS'" &
                                   " from datosclaro.dbo.ServiceDetalle S " &
                                   " INNER JOIN datosclaro.dbo.Bandeja B" &
                                   " ON S.idcaso = B.cas_id where B.Bandeja = 'BSCS' )" &
                                   " UNION " &
                                   " (Select S.idcaso,S.tickler,S.estado,bandeja = 'INBOUND'" &
                                   " from datosclaro.dbo.ServiceDetalle S " &
                                   " INNER JOIN datosclaro.dbo.Bandeja_inbound B" &
                                   " ON S.idcaso = B.Id_caso )" &
                                   " )BASE" &
                                   " WHERE  idcaso =  " & strlcargo

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count

            If intcantreg > 0 Then
                If dts.Tables(0).Rows(0).Item("Bandeja") Is System.DBNull.Value Then
                    strlcargo = ""
                Else
                    strlcargo = dts.Tables(0).Rows(0).Item("Bandeja")
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

    '------------------------actualizacion de estado a casos con CPD y SD
    Public Sub Actualizacion_Escalado()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Try
            cn.Open()
            Dim cms As New SqlClient.SqlCommand
            Dim X As Integer = 0
            If Validacion <> "Liberacion" Then
                If tipo = "Tecnica" Then
                    cms.CommandText = "UPDATE clarovoz.dbo.VFallared SET idusuriocpd=@usuario WHERE idcaso= @caso"
                End If
                cms.Parameters.Add("@caso", SqlDbType.BigInt).Value = intidentidad
                If nombre <> Nothing Then
                    cms.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = nombre
                End If
                cms.Parameters.Add("@fcreg", SqlDbType.VarChar, 20).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                If tipo = "Informatica_Asignar" Or tipo = "Informatica" Then
                    cms.Parameters.Add("@usuario_asigna", SqlDbType.VarChar, 50).Value = strlidusuario
                End If
                If tipo = "Informatica" Then
                    Try
                        cms.CommandText = "UPDATE datosclaro.dbo.ServiceDetalle SET estado='Asignado', fcasignado=@fcreg, idusuarioasigna=@usuario_asigna,idusuarioserv=@usuario  WHERE idcaso= @caso  "
                        cms.Connection = cn
                        cms.ExecuteNonQuery()
                    Catch ex As Exception
                        X = 1
                    End Try
                    If X = 1 Then
                        cms.CommandText = "UPDATE clarovoz.dbo.ServiceDetalle SET estado='Asignado', fcasignado=@fcreg, idusuarioasigna=@usuario_asigna,idusuarioserv=@usuario WHERE idcaso= @caso"
                    End If
                End If
            End If
            If Validacion = "Liberacion" Then ' liberacion de casos
                If tipo = "Tecnica" Then
                    cms.CommandText = "UPDATE clarovoz.dbo.VFallared SET estadocpd = 'Escalado', idusuriocpd='' WHERE idcaso= @caso"
                End If
                cms.Parameters.Add("@caso", SqlDbType.BigInt).Value = intidentidad
                Try
                    If tipo = "Informatica" Then
                        cms.CommandText = "UPDATE datosclaro.dbo.ServiceDetalle SET estado='Escalado', fcasignado='', idusuarioasigna='',idusuarioserv=''  WHERE idcaso= @caso  "
                    End If
                    cms.Connection = cn
                    cms.ExecuteNonQuery()
                Catch ex As Exception
                    X = 1
                End Try
                If X = 1 Then
                    If tipo = "Informatica" Then
                        cms.CommandText = "UPDATE clarovoz.dbo.ServiceDetalle SET estado='Escalado', fcasignado='', idusuarioasigna='',idusuarioserv='' WHERE idcaso= @caso"
                    End If
                End If
            End If
            If Validacion = "Libera_Control" Then
                cms.CommandText = "UPDATE clarovoz.dbo.Control_Escalados_SD_CPD SET estado='Liberado' WHERE estado = 'Asignado' and caso= @caso"
            End If
            If Validacion = "Control_Llamada" Then
                cms.CommandText = "UPDATE clarovoz.dbo.Control_Escalados_SD_CPD SET estado='Llamada Realizada'  WHERE caso= @caso"
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

    Public Sub Registro_Control_Escala()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            cn.Open()
            Dim cms As New SqlClient.SqlCommand
            cms.CommandText = "Insert into  Control_Escalados_SD_CPD (caso,Tipo_Escalado,Id_Usuario,Id_Usuario_Asignado,Estado,Campaña) values (@caso,@Tipo_Escalado,@usuario,@Usuario_Asignado,'Asignado',@campaña)"
            cms.Parameters.Add("@caso", SqlDbType.BigInt).Value = intidentidad
            cms.Parameters.Add("@Tipo_Escalado", SqlDbType.VarChar).Value = tipo
            cms.Parameters.Add("@Usuario_Asignado", SqlDbType.VarChar, 50).Value = nombre
            cms.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = idusuario
            cms.Parameters.Add("@campaña", SqlDbType.VarChar, 20).Value = localidad
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

    Protected X As String

    Public Function Consulta_Control() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "select * from  clarovoz.dbo.Control_Escalados_SD_CPD CE  INNER JOIN Clarovoz.dbo.VFallared VF ON CE.Caso = VF.idcaso where  (Estado = 'Asignado' Or VF.Estadocpd = 'Pendiente') and Tipo_Escalado = '" & nombre & "' and  Id_Usuario_Asignado = '" & idusuario & "' and (Estado_remedy <> 'Cerrado' or Estado_remedy is null )"
            If Validacion = "Resolved_SD" Then
                cms.CommandText = "select S.tickler,S.Estado as EstadoSD,C.* from clarovoz.dbo.Control_Escalados_SD_CPD C left join datosclaro.dbo.ServiceDetalle S on s.idcaso = C.Caso   where (C.Estado = 'Asignado' Or S.Estado = 'Pendiente') and C.Tipo_Escalado =  '" & nombre & "' and  C.Id_Usuario_Asignado = '" & idusuario & "'"
            End If
            If Validacion = "Buscar_Respuesta" Then
                cms.CommandText = "select * from clarovoz.dbo.SD_Con_Respuesta where caso = " & identidad
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count
            If Validacion = "Buscar_Respuesta" Then
                If intcantreg > 0 Then
                    If dts.Tables(0).Rows(0).Item("Respuesta") Is System.DBNull.Value Then
                        strlcargo = "Sin Respuesta"
                    Else
                        strlcargo = dts.Tables(0).Rows(0).Item("Respuesta")
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


    Public Sub Actualizacion_Estado_SD()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Try
            cn.Open()
            Dim cms As New SqlClient.SqlCommand
            Dim X As Integer = 0
            cms.Parameters.Add("@caso", SqlDbType.BigInt).Value = intidentidad
            cms.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado
            Try
                cms.CommandText = "UPDATE datosclaro.dbo.ServiceDetalle SET estado=@estado  WHERE idcaso= @caso  "
                cms.Connection = cn
                cms.ExecuteNonQuery()
            Catch ex As Exception
                X = 1
            End Try
            If X = 1 Then
                cms.CommandText = "UPDATE clarovoz.dbo.ServiceDetalle SET estado=@estado WHERE idcaso= @caso"
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



    Public Function Consulta_Por_Campañas() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            'campañas de service
            If Validacion = "SD" Then
                If cargo = "VOZ" Then
                    cms.CommandText = "select " &
                                      "idcaso,tickler,estado, cas_fecha_registro AS 'Fecha Registro', fcsap AS 'Fecha SAP',idusuarioserv,Bandeja,fcregserv as 'Fc Registro SD', BASE2.Respuesta,Base2.fecha_respuesta ,DATEDIFF( hh, fcregserv , GETDATE() )  as Horas from (" &
                                     " (Select S.idcaso,S.tickler,S.estado,S.idusuarioserv,BU.cas_fecha_registro ,BU.fcsap,bandeja = 'VOZ' ,S.fcregserv " &
                                     " from clarovoz.dbo.ServiceDetalle S " &
                                     " INNER JOIN clarovoz.dbo.Bandeja_uni BU " &
                                     " ON S.idcaso = BU.idcaso)  " &
                                     " UNION " &
                                     " (Select S.idcaso,S.tickler,S.estado,S.idusuarioserv,BU.cas_fecha_registro ,BU.fcsap,bandeja = 'VOZ' ,S.fcregserv  " &
                                     " from datosclaro.dbo.ServiceDetalle S " &
                                     " INNER JOIN clarovoz.dbo.Bandeja_uni BU " &
                                     " ON S.idcaso = BU.idcaso)" &
                                     " )BASE " &
                                     " left join (select sd,Respuesta = 'SI',fecha_respuesta from clarovoz.dbo.SD_Con_Respuesta) BASE2 " &
                                     " on BASE2.SD = BASE.tickler " &
                                     " WHERE tickler <> '' and tickler IS NOT NULL and Estado = 'Escalado' and cas_fecha_registro > '2015-01-01 00:00:00.000' order By cas_fecha_registro DESC"
                End If
                If cargo = "DATOS" Then
                    cms.CommandText = "select " &
                            "idcaso,tickler,estado, cas_fecha_registro AS 'Fecha Registro', fcsap AS 'Fecha SAP',idusuarioserv,Bandeja,fcregserv as 'Fc Registro SD', BASE2.Respuesta,Base2.fecha_respuesta ,DATEDIFF( hh, fcregserv , GETDATE() )  as Horas from (" &
                            " (Select S.idcaso,S.tickler,S.estado,S.idusuarioserv,B.cas_fecha_registro ,B.fcsap,bandeja = 'DATOS' ,S.fcregserv  " &
                            " from clarovoz.dbo.ServiceDetalle S " &
                            " INNER JOIN datosclaro.dbo.Bandeja B" &
                            " ON S.idcaso = B.cas_id  where B.Bandeja <> 'BSCS')  " &
                            " UNION " &
                            " (Select S.idcaso,S.tickler,S.estado,S.idusuarioserv,B.cas_fecha_registro ,B.fcsap ,bandeja = 'DATOS' ,S.fcregserv " &
                            " from datosclaro.dbo.ServiceDetalle S " &
                            " INNER JOIN datosclaro.dbo.Bandeja B" &
                            " ON S.idcaso = B.cas_id  where B.Bandeja <> 'BSCS')" &
                            " )BASE " &
                            " left join (select sd,Respuesta = 'SI',fecha_respuesta from clarovoz.dbo.SD_Con_Respuesta) BASE2 " &
                            " on BASE2.SD = BASE.tickler " &
                            " WHERE tickler <> '' and tickler IS NOT NULL and Estado = 'Escalado' and cas_fecha_registro > '2015-01-01 00:00:00.000' order By cas_fecha_registro DESC"
                End If
                If cargo = "FALLA DES" Then
                    cms.CommandText = "select " &
                          "idcaso,tickler,estado, Fc_Reg AS 'Fecha Registro', Fsap AS 'Fecha SAP',idusuarioserv,Bandeja,fcregserv as 'Fc Registro SD', BASE2.Respuesta,Base2.fecha_respuesta ,DATEDIFF( hh, fcregserv , GETDATE() )  as Horas from (" &
                          " (Select S.idcaso,S.tickler,S.estado,S.idusuarioserv,FD.Fc_Reg,FS.Fsap ,bandeja = 'FALLA DES' ,S.fcregserv  " &
                          " from clarovoz.dbo.ServiceDetalle S " &
                          " INNER JOIN  datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V FD ON S.idcaso = FD.Id_Caso  " &
                          " left join datosclaro.dbo.Fecha_SAP FS on  convert (date,FD.Fc_Reg) = FS.Fcorta ) " &
                          " UNION " &
                          " (Select S.idcaso,S.tickler,S.estado,S.idusuarioserv,FD.Fc_Reg,FS.Fsap,bandeja = 'FALLA DES' ,S.fcregserv  " &
                          " from datosclaro.dbo.ServiceDetalle S " &
                          " INNER JOIN  datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V FD ON S.idcaso = FD.Id_Caso" &
                          " left join datosclaro.dbo.Fecha_SAP FS on  convert (date,FD.Fc_Reg) = FS.Fcorta ) " &
                          " )BASE " &
                          " left join (select sd,Respuesta = 'SI',fecha_respuesta from clarovoz.dbo.SD_Con_Respuesta) BASE2 " &
                          " on BASE2.SD = BASE.tickler " &
                          " WHERE tickler <> '' and tickler IS NOT NULL and Estado = 'Escalado' and Fc_Reg > '2015-01-01 00:00:00.000' order By Fc_Reg DESC"
                End If
                If cargo = "DILO" Then
                    cms.CommandText = "select " &
                                      "idcaso,tickler,estado, fcreporte AS 'Fecha Registro', Fsap AS 'Fecha SAP',idusuarioserv,Bandeja,fcregserv as 'Fc Registro SD', BASE2.Respuesta,Base2.fecha_respuesta ,DATEDIFF( hh, fcregserv , GETDATE() )  as Horas from (" &
                                     " (Select S.idcaso,S.tickler,S.estado,S.idusuarioserv,BA.fcreporte,FS.Fsap ,bandeja = 'DILO' ,S.fcregserv  " &
                                     " from clarovoz.dbo.ServiceDetalle S " &
                                     " INNER JOIN datosclaro.dbo.Bandeja_alt BA  ON S.idcaso = BA.idcaso " &
                                     " left join datosclaro.dbo.Fecha_SAP FS on  convert (date,BA.fcreporte) = FS.Fcorta) " &
                                     " UNION " &
                                     " (Select S.idcaso,S.tickler,S.estado,S.idusuarioserv,BA.fcreporte,FS.Fsap,bandeja = 'DILO',S.fcregserv  " &
                                     " from datosclaro.dbo.ServiceDetalle S " &
                                     " INNER JOIN datosclaro.dbo.Bandeja_alt BA ON S.idcaso = BA.Idcaso" &
                                     " left join datosclaro.dbo.Fecha_SAP FS on  convert (date,BA.fcreporte) = FS.Fcorta)  " &
                                     " )BASE " &
                                     " left join (select sd,Respuesta = 'SI',fecha_respuesta from clarovoz.dbo.SD_Con_Respuesta) BASE2 " &
                                     " on BASE2.SD = BASE.tickler " &
                                     " WHERE tickler <> '' and tickler IS NOT NULL and Estado = 'Escalado' and fcreporte > '2015-01-01 00:00:00.000' order By fcreporte DESC"
                End If
                If cargo = "BSCS" Then
                    cms.CommandText = "select " &
                          "idcaso,tickler,estado, cas_fecha_registro AS 'Fecha Registro', fcsap AS 'Fecha SAP',idusuarioserv,Bandeja,fcregserv as 'Fc Registro SD', BASE2.Respuesta,Base2.fecha_respuesta ,DATEDIFF( hh, fcregserv , GETDATE() )  as Horas from (" &
                         " (Select S.idcaso,S.tickler,S.estado,S.idusuarioserv,B.cas_fecha_registro ,B.fcsap ,bandeja = 'BSCS' ,S.fcregserv " &
                         " from datosclaro.dbo.ServiceDetalle S " &
                         " INNER JOIN datosclaro.dbo.Bandeja B " &
                         " ON S.idcaso = B.cas_id where B.Bandeja = 'BSCS' ) " &
                         " )BASE " &
                         " left join (select sd,Respuesta = 'SI',fecha_respuesta from clarovoz.dbo.SD_Con_Respuesta) BASE2 " &
                         " on BASE2.SD = BASE.tickler " &
                         " WHERE tickler <> '' and tickler IS NOT NULL and Estado = 'Escalado' and cas_fecha_registro > '2015-01-01 00:00:00.000' order By cas_fecha_registro DESC"
                End If
            End If
            'campañas tecnica''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Validacion = "CPD" Then
                If cargo = "DATOS" Then
                    cms.CommandText = " select " &
                              "idcaso,min,Base.cpd,estadocpd,Cas_fecha_registro as 'Fecha Registro',fcsap AS 'Fecha SAP',idusuriocpd,Bandeja, BASE2.Respuesta FROM( " &
                              " select VF.idcaso,VF.numcontacto as min,VF.cpd,VF.estadocpd,B.cas_fecha_registro,B.fcsap,VF.idusuriocpd,Bandeja = 'DATOS' " &
                              " from clarovoz.dbo.VFallared VF " &
                              " inner join datosclaro.dbo.bandeja B on VF.idcaso = B.cas_id  " &
                              " )BASE " &
                              " left join (select CPD,Respuesta = 'SI' from clarovoz.dbo.CPD_Con_Respuesta) BASE2  " &
                              " on BASE2.CPD = BASE.cpd " &
                              " where BASE.cpd Is Not NULL And " &
                              " idusuriocpd  IS NOT NULL AND estadocpd = 'Escalado' and BASE.cpd <> '' and Cas_fecha_registro > '2015-01-01 00:00:00.000' order by cas_fecha_registro desc "
                End If
                If cargo = "VOZ" Then
                    cms.CommandText = " select " &
                                      "idcaso,min,Base.cpd,estadocpd,Cas_fecha_registro as 'Fecha Registro',fcsap AS 'Fecha SAP',idusuriocpd,Bandeja, BASE2.Respuesta FROM( " &
                                      " select VF.idcaso,VF.numcontacto as min,VF.cpd,VF.estadocpd,BU.cas_fecha_registro,BU.fcsap,VF.idusuriocpd,Bandeja = 'VOZ'" &
                                      " from clarovoz.dbo.VFallared VF" &
                                      " inner join clarovoz.dbo.Bandeja_uni BU on VF.idcaso = BU.idcaso " &
                                      " )BASE " &
                                      " left join (select CPD,Respuesta = 'SI' from clarovoz.dbo.CPD_Con_Respuesta) BASE2 " &
                                      " on BASE2.CPD = BASE.cpd " &
                                      " where BASE.cpd Is Not NULL And " &
                                      " idusuriocpd  IS NOT NULL AND estadocpd = 'Escalado' and BASE.cpd <> '' and Cas_fecha_registro > '2015-01-01 00:00:00.000' order by cas_fecha_registro desc "
                End If
                If cargo = "FALLA DES" Then
                    cms.CommandText = " select " &
                              "idcaso,min,Base.cpd,estadocpd,Fc_Reg as 'Fecha Registro',Fsap AS 'Fecha SAP',idusuriocpd,Bandeja, BASE2.Respuesta FROM( " &
                              " select VF.idcaso,VF.numcontacto as min,VF.cpd,VF.estadocpd,FD.Fc_Reg,FS.Fsap,VF.idusuriocpd,Bandeja = 'FALLA DES'  " &
                              " from clarovoz.dbo.VFallared VF" &
                              " inner join datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V FD on VF.idcaso = FD.Id_Caso  " &
                              " left join datosclaro.dbo.Fecha_SAP FS on  convert (date,FD.Fc_Reg) = FS.Fcorta" &
                              " )BASE " &
                              " left join (select CPD,Respuesta = 'SI' from clarovoz.dbo.CPD_Con_Respuesta) BASE2 " &
                              " on BASE2.CPD = BASE.cpd " &
                              " where BASE.cpd Is Not NULL And " &
                              " idusuriocpd  IS NOT NULL AND estadocpd = 'Escalado' and BASE.cpd <> '' and Fc_Reg > '2015-01-01 00:00:00.000' order by Fc_Reg desc "
                End If
                If cargo = "DILO" Then
                    cms.CommandText = " select " &
                             "idcaso,min,Base.cpd,estadocpd,fcreporte as 'Fecha Registro',Fsap AS 'Fecha SAP',idusuriocpd,Bandeja, BASE2.Respuesta FROM( " &
                             " SELECT VF.idcaso,VF.numcontacto as min, VF.cpd,VF.estadocpd,BA.fcreporte,FS.Fsap,VF.idusuriocpd , Bandeja = 'DILO'  " &
                             " from clarovoz.dbo.VFallared VF" &
                             " inner join datosclaro.dbo.Bandeja_alt BA on BA.idcaso = VF.idcaso   " &
                             " left join datosclaro.dbo.Fecha_SAP FS on  BA.fcreporte  = FS.Fcorta" &
                             " )BASE " &
                             " left join (select CPD,Respuesta = 'SI' from clarovoz.dbo.CPD_Con_Respuesta) BASE2 " &
                             " on BASE2.CPD = BASE.cpd " &
                             " where BASE.cpd Is Not NULL And " &
                             " idusuriocpd  IS NOT NULL AND estadocpd = 'Escalado' and BASE.cpd <> '' and fcreporte > '2015-01-01 00:00:00.000' order by fcreporte desc "
                End If


                If cargo = "BSCS" Then
                    cms.CommandText = " select " &
                              "idcaso,min,Base.cpd,estadocpd,Cas_fecha_registro as 'Fecha Registro',fcsap AS 'Fecha SAP',idusuriocpd,Bandeja, BASE2.Respuesta FROM( " &
                              " select VF.idcaso,VF.numcontacto as min,VF.cpd,VF.estadocpd,B.cas_fecha_registro,B.fcsap,VF.idusuriocpd,Bandeja = 'BSCS' " &
                              " from clarovoz.dbo.VFallared VF " &
                              " inner join datosclaro.dbo.bandeja B on VF.idcaso = B.cas_id Where VF.campana =  'BSCS'  " &
                              " )BASE " &
                              " left join (select CPD,Respuesta = 'SI' from clarovoz.dbo.CPD_Con_Respuesta) BASE2  " &
                              " on BASE2.CPD = BASE.cpd " &
                              " where BASE.cpd Is Not NULL And " &
                              " idusuriocpd  IS NOT NULL AND estadocpd = 'Escalado' and BASE.cpd <> '' and Cas_fecha_registro > '2015-01-01 00:00:00.000' order by cas_fecha_registro desc "
                End If
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function





    Public Function consultar_Respuesta_CPD() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select Respuesta from CPD_Con_Respuesta  WHERE CPD = '" & nombre & "'"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count
            If intcantreg > 0 Then
                If dts.Tables(0).Rows(0).Item("Respuesta") Is System.DBNull.Value Then
                    strlnombreut = ""
                Else
                    strlnombreut = dts.Tables(0).Rows(0).Item("Respuesta")
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

    Public Function Cargar_CMC() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Validacion = "Estado" Then
                cms.CommandText = "Select Nombre,Pertenece from BD_Datos_Complemento where Pertenece = 'Estado_CMC'"
            End If
            If _Validacion = "Causa" Then
                cms.CommandText = "Select Nombre,Pertenece from BD_Datos_Complemento where Pertenece = 'Causa_CMC'"
            End If
            If _Validacion = "BSCS" Then
                cms.CommandText = "Select Ticket , Usuario,Fecha_Registro,Min as Numero,Contrato as Caso,Novedad,Nombre from Control_BSCS where Contrato = @strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlCod_Diagnostico
            End If
            If _Validacion = "Novedad" Then
                cms.CommandText = "Select cod_tipificacion,tipificacion1 from Tipificaciones where pertenece = 'Novedad_BSCS'"
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

      Public Function Cons_Productividad()
        Try
            Dim Con = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
            Dim Scm As New SqlClient.SqlCommand
            Dim Sdta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim Ayer As Date = FormatDateTime(Date.Now.AddDays(-1), vbShortDate)
            'Dim Ayer As Date = "31/01/2016"

            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_Date", Ayer)
            Scm.Parameters.AddWithValue("@_Id_Usuario", strlidusuario)
            'Scm.Parameters.AddWithValue("@_Id_Usuario", "Ricardo.c")
            Scm.CommandText = "Exec datosclaro.dbo.Cons_Cumplimiento_Usuario_Mes @_Date, @_Id_Usuario"
            Sdta = New SqlClient.SqlDataAdapter(Scm)
            Sdta.Fill(dts)
            Return dts
            Con.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Public Sub Contar_Ingreso()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Try
            cn.Open()
            Dim cms As New SqlClient.SqlCommand
            cms.Parameters.AddWithValue("@_Url", PaginaAcceso)
            cms.CommandText = "update menus set Contador = Contador + 1 where url like @_Url"
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

    Public Function Consulta_Cargue_Catalogo_Diagnostico2() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ''Conexion a la base de datos
        Dim cms As New SqlClient.SqlCommand

        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            cn.Open()

            '''''''''CATALOGO DE DIAGNOSTICO
            'Linea de servicio
            If _Validacion = "linea_serv" Then
                cms.CommandText = "select distinct tipificacion1 from Tipificaciones2 where pertenece='servicio1'"
            End If
            'Servicio
            If _Validacion = "servicio" Then
                cms.CommandText = "Select tipificacion2,cod_tipificacion from Tipificaciones2 where tipificacion1=@strlCod_Diagnostico and pertenece='servicio1'"
                cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 255).Value = strlCod_Diagnostico
            End If
            'subservicio
            If _Validacion = "solictid_falla" Then
                cms.CommandText = "select tipificacion1,cod_tipificacion from tipificaciones2 where Freetext(tipificacion4,@strlCod_Diagnostico) and pertenece='servicio2'"
                cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 255).Value = strlCod_Diagnostico
            End If

            'segmento
            If _Validacion = "segmento" Then
                cms.CommandText = "select distinct tipificacion1 from tipificaciones2 where FREETEXT(tipificacion4,@strlCod_Diagnostico) and pertenece='Catalogo_diagnostico'"
                cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 255).Value = strlCod_Diagnostico
            End If
            'causa falla
            If _Validacion = "causa_falla" Then
                cms.CommandText = "select distinct tipificacion2,cod_tipificacion from tipificaciones2 where tipificacion1=@strlCod_Diagnostico and FREETEXT(tipificacion4,@strlnombre) and pertenece='Catalogo_diagnostico'"
                cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 255).Value = strlCod_Diagnostico
                cms.Parameters.Add("@strlnombre", SqlDbType.VarChar, 255).Value = strlnombre
            End If
            'tipo soporte
            If _Validacion = "tipo_soporte" Then
                cms.CommandText = "select tipificacion1,cod_tipificacion from tipificaciones2 where FREETEXT(tipificacion4,@strlCod_Diagnostico) and pertenece='Cierre llamada'"
                cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 255).Value = strlCod_Diagnostico
            End If
            'tipo grupo
            If _Validacion = "tipo_grupo" Then
                cms.CommandText = "select tipificacion2 from tipificaciones2 where cod_tipificacion=@strlCod_Diagnostico and pertenece='Cierre llamada'"
                cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 255).Value = strlCod_Diagnostico
            End If
            'estado
            If _Validacion = "estado" Then
                cms.CommandText = "select tipificacion1,cod_tipificacion from tipificaciones2 where FREETEXT(tipificacion4,@strlCod_Diagnostico) and pertenece='Estado'"
                cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 255).Value = strlCod_Diagnostico
            End If
            'categoria
            If _Validacion = "categoria" Then
                cms.CommandText = "select tipificacion1,cod_tipificacion from tipificaciones2 where FREETEXT(tipificacion4,@strlCod_Diagnostico) and pertenece='Categoria cierre' And id_tipificacion <> '88'"
                cms.Parameters.Add("@strlCod_Diagnostico", SqlDbType.VarChar, 255).Value = strlCod_Diagnostico
                If (_Cod_Causa_Raiz = 108 Or _Cod_Causa_Raiz = 109 Or _Cod_Causa_Raiz = 128) And strlCod_Diagnostico = 250 Then
                    cms.CommandText = "select tipificacion1,cod_tipificacion from tipificaciones2 where FREETEXT(tipificacion4,@strlCod_Diagnostico) and pertenece='Categoria cierre' And id_tipificacion = '88'"
                End If
            End If



            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count
            If intcantreg > 0 Then
                If _Validacion = "Elemento" Then
                    If dts.Tables(0).Rows(0).Item("id_tipificacion") Is System.DBNull.Value Then
                        strltipo = " "
                    Else
                        strltipo = dts.Tables(0).Rows(dts.Tables(0).Rows.Count - 1).Item("id_tipificacion")
                    End If
                End If
            End If

            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            cms.Parameters.Clear()
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Function Consultar_Gestiones_Resolved() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Validacion = "DATOS" Then
                cms.CommandText = "SELECT  idcrm As CRM,cas_id As Caso,min_ac As Min,fcreg As [Fc Reg],idusuario As [Id Usuario],obs As Observacion,tipo_soporte As [Tipo Soporte],Tipificacion FROM CRMDetalle RIGHT OUTER JOIN Bandeja on crmdetalle.idcaso=bandeja.cas_id  where cas_id=@strlcaso  ORDER BY idcrm DESC"
            ElseIf _Validacion = "DILO" Then
                cms.CommandText = "SELECT  CRM.idcrmdilo As CRM, B.idcaso As Caso, min As Min,CRM.fcregistro As [Fc Reg],CRM.idusuario As [Id Usuario],obs As Observacion,tipo_soporte As [Tipo Soporte],Tipificacion  FROM CRMdilo CRM RIGHT OUTER JOIN Bandeja_alt B on CRM.idcasodilo=B.idcaso where B.IdCaso=@strlcaso  ORDER BY idcrmdilo DESC"
            ElseIf _Validacion = "DESACTIVACION" Then
                cms.CommandText = "SELECT  CRM.Id_CRM_Falla_Desactivacion_D_V As CRM, B.Id_Caso As Caso, min As Min,CRM.Fc_Reg_Ges As [Fc Reg],CRM.Id_Usuario As [Id Usuario],obs As Observacion,tipo_soporte As [Tipo Soporte],Tipificacion  FROM CRM_Falla_Desactivacion_D_V CRM RIGHT OUTER JOIN Bandeja_Falla_Desactivacion_D_V B on CRM.Fk_Id_Bandeja=B.Id_Bandeja_Falla_Desactivacion_D_V where B.Id_Caso=@strlcaso  ORDER BY Id_CRM_Falla_Desactivacion_D_V DESC"
            ElseIf _Validacion = "INBOUND" Then
                cms.CommandText = "Select CRM.id_crm As CRM, B.Id_Caso As Caso, min As Min,CRM.Fec_registro As [Fc Reg],CRM.Id_Usuario As [Id Usuario],obs As Observacion, Tipificacion  FROM CRM_inbound CRM RIGHT OUTER JOIN Bandeja_inbound B On CRM.Fk_Id_caso=B.Id_caso where B.Id_Caso=@strlcaso  ORDER BY id_crm DESC"
            End If
            If strlCod_Diagnostico <> Nothing Then
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlCod_Diagnostico
            Else
                cms.Parameters.AddWithValue("@strlcaso", DBNull.Value)
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantreg = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''NUEVOS PERMISOS'''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub PermisosUrl()
        Try
            Dim Val = False
            For Each drMenuItem As Data.DataRow In _DtsSeguridad.Tables(0).Rows
                If drMenuItem("url").ToString.Trim.ToUpper = _PaginaAcceso.ToString.Trim.ToUpper Then
                    Val = True
                    Exit For
                End If
            Next
            If Val Then
                Contar_Ingreso()
            Else
                Reportar_Acceso()
                HttpContext.Current.Response.Redirect("~/Default.aspx")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Reportar_Acceso()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            cn.Open()
            Dim cms As New SqlClient.SqlCommand
            cms.CommandText = "insert into Acceso_Url (Id_usuario,Url_Pagina) values(@Usuario,@Url)"
            cms.Parameters.Add("@Url", SqlDbType.VarChar, 200).Value = _PaginaAcceso
            cms.Parameters.Add("@Usuario", SqlDbType.VarChar, 20).Value = idusuario
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
    Public Sub Registrar_Ingreso()
        Dim cn As New SqlClient.SqlConnection
        Dim fecha As New DateTime
        Dim fechadia As New Date
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            cn.Open()
            cms.CommandText = "insert into ingreso(idusuario,fcingreso)values(@idusuario,@fcingreso)"
            cms.Parameters.AddWithValue("@idusuario", strlidusuario)
            cms.Parameters.AddWithValue("@fcingreso", Now)
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cms.Parameters.Clear()
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function Consultar_DivPol_Ciudades() As DataTable
        Dim Con As New SqlClient.SqlConnection
        Dim Scm As New SqlClient.SqlCommand
        Try
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Dts As New DataSet
            Dim Sql_Frag As String = Nothing
            If _DivPol_Id_Estado <> Nothing Then
                Scm.Parameters.AddWithValue("@_Id_Estado", _DivPol_Id_Estado)
                Sql_Frag = Sql_Frag & " And Estado_Fk_DivPol_Estados_Id = @_Id_Estado "
            End If
            If _DivPol_Id_Ciudad <> Nothing Then
                Scm.Parameters.AddWithValue("@_Id_Ciudad", _DivPol_Id_Ciudad)
                Sql_Frag = Sql_Frag & " And Id = @_Id_Ciudad "
            End If
            Con = Conexion_ERP
            Con.Open()
            Scm.Connection = Con
            Scm.CommandText = "Select Id, Nombre, Estado_Fk_DivPol_Estados_Id From Kamilion_ERP.dbo.DivPol_Ciudades Where 1=1 " & Sql_Frag
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
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
    Public Function Consultar_DivPol_Estados() As DataTable
        Dim Con As New SqlClient.SqlConnection
        Dim Scm As New SqlClient.SqlCommand
        Try
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Dts As New DataSet
            Dim Sql_Frag As String = Nothing
            If _DivPol_Id_Estado <> Nothing Then
                Scm.Parameters.AddWithValue("@_Id_Estado", _DivPol_Id_Estado)
                Sql_Frag = Sql_Frag & " And Id = @_Id_Estado "
            End If
            If _DivPol_Id_Pais <> Nothing Then
                Scm.Parameters.AddWithValue("@_Id_Pais", _DivPol_Id_Pais)
                Sql_Frag = Sql_Frag & " And Pais_Fk_DivPol_Paises_Id = @_Id_Pais "
            End If
            Con = Conexion_ERP
            Con.Open()
            Scm.Connection = Con
            Scm.CommandText = "Select Id, Nombre, Pais_Fk_DivPol_Paises_Id From Kamilion_ERP.dbo.DivPol_Estados Where 1=1 " & Sql_Frag
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
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
    Public Function Consultar_DivPol_Paises() As DataTable
        Dim Con As New SqlClient.SqlConnection
        Dim Scm As New SqlClient.SqlCommand
        Try
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Dts As New DataSet
            Dim Sql_Frag As String = Nothing
            If _DivPol_Id_Pais <> Nothing Then
                Scm.Parameters.AddWithValue("@_Id_Pais", _DivPol_Id_Pais)
                Sql_Frag = Sql_Frag & " And Id = @_Id_Pais "
            End If
            Con = Conexion_ERP
            Con.Open()
            Scm.Connection = Con
            Scm.CommandText = "Select Id, Nombre From Kamilion_ERP.dbo.DivPol_Paises Where 1=1 " & Sql_Frag
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
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




End Class

