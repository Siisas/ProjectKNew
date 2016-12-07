Public Class clsCaidaSistema
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''' CausaCS '''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Tabla dbo.CausaCS
    Protected _Cod_Causa As Int64
    Protected _Nombre As String

    Public Property Cod_Causa() As Int64
        Get
            Return _Cod_Causa
        End Get
        Set(ByVal value As Int64)
            _Cod_Causa = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''CaidaSistema'''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Tabla dbo.CaidaSistema
    Protected _Cod_CS As Int64
    Protected _Fecha_Inicio As String
    Protected _Causa_Caida As Int64
    Protected _Detalle As String
    Protected _Fecha_Solucion As String
    Protected _Duracion_Falla As String
    Protected _Puestos_Afectados As String
    Protected _Solucion_Brindada As String
    Protected _Fecha_Registro As String
    Protected _Usuario As String
    Protected _Estado As String
    Protected _Cantidad As Integer
    Protected _Validacion As String
    Protected _Agente_1 As String
    Protected _Agente_2 As String
    Protected _Agente_3 As String
    Protected _Agente_4 As String
    Protected _Agente_5 As String
    Protected _Agente_6 As String
    Protected _Agente_7 As String
    Protected _Agente_8 As String
    Protected _Agente_9 As String
    Protected _Agente_10 As String

    Public Property Agente_10 As String
        Get
            Return _Agente_10
        End Get
        Set(ByVal value As String)
            _Agente_10 = value
        End Set
    End Property
    Public Property Agente_9 As String
        Get
            Return _Agente_9
        End Get
        Set(ByVal value As String)
            _Agente_9 = value
        End Set
    End Property
    Public Property Agente_8 As String
        Get
            Return _Agente_8
        End Get
        Set(ByVal value As String)
            _Agente_8 = value
        End Set
    End Property
    Public Property Agente_7 As String
        Get
            Return _Agente_7
        End Get
        Set(ByVal value As String)
            _Agente_7 = value
        End Set
    End Property
    Public Property Agente_6 As String
        Get
            Return _Agente_6
        End Get
        Set(ByVal value As String)
            _Agente_6 = value
        End Set
    End Property
    Public Property Agente_5 As String
        Get
            Return _Agente_5
        End Get
        Set(ByVal value As String)
            _Agente_5 = value
        End Set
    End Property
    Public Property Agente_4 As String
        Get
            Return _Agente_4
        End Get
        Set(ByVal value As String)
            _Agente_4 = value
        End Set
    End Property
    Public Property Agente_3 As String
        Get
            Return _Agente_3
        End Get
        Set(ByVal value As String)
            _Agente_3 = value
        End Set
    End Property
    Public Property Agente_2 As String
        Get
            Return _Agente_2
        End Get
        Set(ByVal value As String)
            _Agente_2 = value
        End Set
    End Property
    Public Property Agente_1 As String
        Get
            Return _Agente_1
        End Get
        Set(ByVal value As String)
            _Agente_1 = value
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

    Public Property Cod_CS() As Int64
        Get
            Return _Cod_CS
        End Get
        Set(ByVal value As Int64)
            _Cod_CS = value
        End Set
    End Property
    Public Property Fecha_Inicio() As String
        Get
            Return _Fecha_Inicio
        End Get
        Set(ByVal value As String)
            _Fecha_Inicio = value
        End Set
    End Property
    Public Property Causa_Caida() As Int64
        Get
            Return _Causa_Caida
        End Get
        Set(ByVal value As Int64)
            _Causa_Caida = value
        End Set
    End Property
    Public Property Detalle() As String
        Get
            Return _Detalle
        End Get
        Set(ByVal value As String)
            _Detalle = value
        End Set
    End Property
    Public Property Fecha_Solucion() As String
        Get
            Return _Fecha_Solucion
        End Get
        Set(ByVal value As String)
            _Fecha_Solucion = value
        End Set
    End Property
    Public Property Duracion_Falla() As String
        Get
            Return _Duracion_Falla
        End Get
        Set(ByVal value As String)
            _Duracion_Falla = value
        End Set
    End Property
    Public Property Puestos_Afectados() As String
        Get
            Return _Puestos_Afectados
        End Get
        Set(ByVal value As String)
            _Puestos_Afectados = value
        End Set
    End Property
    Public Property Solucion_Brindada() As String
        Get
            Return _Solucion_Brindada
        End Get
        Set(ByVal value As String)
            _Solucion_Brindada = value
        End Set
    End Property
    Public Property Fecha_Registro() As String
        Get
            Return _Fecha_Registro
        End Get
        Set(ByVal value As String)
            _Fecha_Registro = value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Sub IngresarCaidaSistema()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO CaidaSistema(Fecha_Inicio,Fk_Causa_Caida,Detalle,fecha_Solucion,Duracion_Falla,Puestos_Afectados,Solucion_Brindada,Fecha_Registro,Fk_Usuario,Estado) values(@_Fecha_Inicio,@_Causa_Caida,@_Detalle,@_Fecha_Solucion,@_Duracion_Falla,@_Puestos_Afectados,@_Solucion_Brindada,@_Fecha_Registro,@_Usuario,@_Estado)"
            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 50).Value = _Fecha_Inicio
            cms.Parameters.Add("@_Causa_Caida", SqlDbType.Int).Value = _Causa_Caida
            cms.Parameters.Add("@_Detalle", SqlDbType.VarChar, 250).Value = _Detalle
            cms.Parameters.Add("@_Fecha_Solucion", SqlDbType.VarChar, 50).Value = _Fecha_Solucion
            cms.Parameters.Add("@_Duracion_Falla", SqlDbType.VarChar, 70).Value = _Duracion_Falla
            cms.Parameters.Add("@_Puestos_Afectados", SqlDbType.VarChar, 50).Value = _Puestos_Afectados
            cms.Parameters.Add("@_Solucion_Brindada", SqlDbType.VarChar).Value = _Solucion_Brindada
            cms.Parameters.Add("@_Fecha_Registro", SqlDbType.VarChar, 50).Value = _Fecha_Registro
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 50).Value = _Usuario
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
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


    Public Function consfallasist() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * FROM CausaCS order by Cod_causaCS asc"
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


    Public Function consultaCSTodo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select CS.Cod_CS,CS.Fecha_Inicio,CCS.Nombre,CS.Detalle,CS.fecha_Solucion,CS.Duracion_Falla,CS.Puestos_Afectados,CS.Solucion_Brindada,CS.Fecha_Registro,CS.Fk_Usuario from CaidaSistema CS inner join CausaCS CCS on CS.Fk_Causa_Caida=CCS.Cod_CausaCS where Estado=1 order by CS.Cod_CS desc"
            If Cod_CS <> Nothing Then
                cms.CommandText = "select CS.Cod_CS,CS.Fecha_Inicio,CCS.Nombre,CS.Detalle,CS.fecha_Solucion,CS.Duracion_Falla,CS.Puestos_Afectados,CS.Solucion_Brindada,CS.Fecha_Registro,CS.Fk_Usuario from CaidaSistema CS inner join CausaCS CCS on CS.Fk_Causa_Caida=CCS.Cod_CausaCS where  Estado=1 and CS.Cod_CS=@_Cod_CS order by CS.Cod_CS desc"
                cms.Parameters.Add("@_Cod_CS", SqlDbType.Int).Value = _Cod_CS
            End If
            If Causa_Caida <> Nothing Then
                cms.CommandText = "select CS.Cod_CS,CS.Fecha_Inicio,CCS.Nombre,CS.Detalle,CS.fecha_Solucion,CS.Duracion_Falla,CS.Puestos_Afectados,CS.Solucion_Brindada,CS.Fecha_Registro,CS.Fk_Usuario from CaidaSistema CS inner join CausaCS CCS on CS.Fk_Causa_Caida=CCS.Cod_CausaCS where  Estado=1 and CS.Fk_Causa_Caida=@_Causa_Caida order by CS.Cod_CS desc"
                cms.Parameters.Add("@_Causa_Caida", SqlDbType.VarChar, 50).Value = _Causa_Caida
            End If
            If (Fecha_Inicio <> Nothing) And (Fecha_Solucion <> Nothing) Then
                cms.CommandText = "select CS.Cod_CS,CS.Fecha_Inicio,CCS.Nombre,CS.Detalle,CS.fecha_Solucion,CS.Duracion_Falla,CS.Puestos_Afectados,CS.Solucion_Brindada,CS.Fecha_Registro,CS.Fk_Usuario from CaidaSistema CS inner join CausaCS CCS on CS.Fk_Causa_Caida=CCS.Cod_CausaCS where  Estado=1 and CS.Fecha_Inicio BETWEEN @_Fecha_Inicio and @_Fecha_Solucion order by CS.Cod_CS desc"
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 50).Value = _Fecha_Inicio
                cms.Parameters.Add("@_Fecha_Solucion", SqlDbType.VarChar, 50).Value = _Fecha_Solucion
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me._Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Function ConsultaActualizar() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If Cod_CS <> Nothing Then
                cms.CommandText = "SELECT * FROM CaidaSistema where Cod_CS=@_Cod_CS"
                cms.Parameters.Add("@_Cod_CS", SqlDbType.Int).Value = _Cod_CS
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Fecha_Inicio") Is System.DBNull.Value Then
                    _Fecha_Inicio = " "
                Else
                    _Fecha_Inicio = dts.Tables(0).Rows(0).Item("Fecha_Inicio")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Causa_Caida") Is System.DBNull.Value Then
                    _Causa_Caida = " "
                Else
                    _Causa_Caida = dts.Tables(0).Rows(0).Item("Fk_Causa_Caida")
                End If
                If dts.Tables(0).Rows(0).Item("Detalle") Is System.DBNull.Value Then
                    _Detalle = " "
                Else
                    _Detalle = dts.Tables(0).Rows(0).Item("Detalle")
                End If
                If dts.Tables(0).Rows(0).Item("Fecha_Solucion") Is System.DBNull.Value Then
                    _Fecha_Solucion = " "
                Else
                    _Fecha_Solucion = dts.Tables(0).Rows(0).Item("Fecha_Solucion")
                End If
                If dts.Tables(0).Rows(0).Item("Duracion_Falla") Is System.DBNull.Value Then
                    _Duracion_Falla = " "
                Else
                    _Duracion_Falla = dts.Tables(0).Rows(0).Item("Duracion_Falla")
                End If
                If dts.Tables(0).Rows(0).Item("Puestos_Afectados") Is System.DBNull.Value Then
                    _Puestos_Afectados = " "
                Else
                    _Puestos_Afectados = dts.Tables(0).Rows(0).Item("Puestos_Afectados")
                End If
                If dts.Tables(0).Rows(0).Item("Solucion_Brindada") Is System.DBNull.Value Then
                    _Solucion_Brindada = " "
                Else
                    _Solucion_Brindada = dts.Tables(0).Rows(0).Item("Solucion_Brindada")
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



    Public Sub ActualizarCaidaSistema()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Update CaidaSistema set Fecha_Inicio=@_Fecha_Inicio,Fk_Causa_Caida=@_Causa_Caida,Detalle=@_Detalle,Fecha_Solucion=@_Fecha_Solucion,Duracion_Falla=@_Duracion_Falla,Puestos_Afectados=@_Puestos_Afectados,Solucion_Brindada=@_Solucion_Brindada,Fecha_Registro=@_Fecha_Registro,Fk_Usuario=@_Usuario where Cod_CS=@_Cod_CS"
            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 50).Value = _Fecha_Inicio
            cms.Parameters.Add("@_Causa_Caida", SqlDbType.Int).Value = _Causa_Caida
            cms.Parameters.Add("@_Detalle", SqlDbType.VarChar, 250).Value = _Detalle
            cms.Parameters.Add("@_Fecha_Solucion", SqlDbType.VarChar, 50).Value = _Fecha_Solucion
            cms.Parameters.Add("@_Duracion_Falla", SqlDbType.VarChar, 70).Value = _Duracion_Falla
            cms.Parameters.Add("@_Puestos_Afectados", SqlDbType.VarChar, 50).Value = _Puestos_Afectados
            cms.Parameters.Add("@_Solucion_Brindada", SqlDbType.VarChar).Value = _Solucion_Brindada
            cms.Parameters.Add("@_Fecha_Registro", SqlDbType.VarChar, 50).Value = _Fecha_Registro
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 50).Value = _Usuario
            cms.Parameters.Add("@_Cod_CS", SqlDbType.Int).Value = _Cod_CS
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



    Public Sub EliminarCaidaSistema()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Update CaidaSistema set Estado=@_Estado where Cod_CS=@_Cod_CS"
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Cod_CS", SqlDbType.Int).Value = _Cod_CS
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

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''Productividad''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Fecha_Actual As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Fecha_Turno As String
    Protected _Gestionado As Integer
    Protected _Rechazado As Integer
    Protected _Asignado As Integer
    Protected _Reportado As Integer
    Protected _Cerrado As Integer
    Protected _Escalado As Integer
    Protected _CantidadH As Integer
    Protected _CantidadMinu As Integer
    Protected _Dia As String
    Protected _Grupo As String

    Public Property Fecha_Actual() As String
        Get
            Return _Fecha_Actual
        End Get
        Set(ByVal value As String)
            _Fecha_Actual = value
        End Set
    End Property

    Public Property Fecha_Turno() As String
        Get
            Return _Fecha_Turno
        End Get
        Set(ByVal value As String)
            _Fecha_Turno = value
        End Set
    End Property
    Public Property Gestionado() As Integer
        Get
            Return _Gestionado
        End Get
        Set(ByVal value As Integer)
            _Gestionado = value
        End Set
    End Property
    Public Property Rechazado() As Integer
        Get
            Return _Rechazado
        End Get
        Set(ByVal value As Integer)
            _Rechazado = value
        End Set
    End Property
    Public Property Asignado() As Integer
        Get
            Return _Asignado
        End Get
        Set(ByVal value As Integer)
            _Asignado = value
        End Set
    End Property
    Public Property Reportado() As Integer
        Get
            Return _Reportado
        End Get
        Set(ByVal value As Integer)
            _Reportado = value
        End Set
    End Property
    Public Property Cerrado() As Integer
        Get
            Return _Cerrado
        End Get
        Set(ByVal value As Integer)
            _Cerrado = value
        End Set
    End Property

    Public Property Escalado() As Integer
        Get
            Return _Escalado
        End Get
        Set(ByVal value As Integer)
            _Escalado = value
        End Set
    End Property

    Public Property CantidadH() As Integer
        Get
            Return _CantidadH
        End Get
        Set(ByVal value As Integer)
            _CantidadH = value
        End Set
    End Property

    Public Property CantidadMinu() As Integer
        Get
            Return _CantidadMinu
        End Get
        Set(ByVal value As Integer)
            _CantidadMinu = value
        End Set
    End Property

    Public Property Dia() As String
        Get
            Return _Dia
        End Get
        Set(ByVal value As String)
            _Dia = value
        End Set
    End Property

    Public Property Grupo() As String
        Get
            Return _Grupo
        End Get
        Set(ByVal value As String)
            _Grupo = value
        End Set
    End Property

    Public Function ProductividadGestionados() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT COUNT(tipificacion)as Gestionado from Productividad where idusuario=@_Usuario and tipificacion='Gestionado' and fcreg>=@_Fecha_Turno and fcreg<=@_Fecha_Actual"
            cms.Parameters.Add("@_Fecha_Actual", SqlDbType.VarChar, 50).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fecha_Turno", SqlDbType.VarChar, 50).Value = _Fecha_Turno
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 50).Value = _Usuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Gestionado") Is System.DBNull.Value Then
                    _Gestionado = " "
                Else
                    _Gestionado = dts.Tables(0).Rows(0).Item("Gestionado")
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

    Public Function ProductividadCerrados() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim cn2 As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn2 = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cn2.Open()
            cms.CommandText = "SELECT COUNT(tipificacion)as Cerrados from Productividad where idusuario=@_Usuario and tipificacion='Cerrado' and fcreg>=@_Fecha_Turno and fcreg<=@_Fecha_Actual"
            cms.Parameters.Add("@_Fecha_Actual", SqlDbType.VarChar, 50).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fecha_Turno", SqlDbType.VarChar, 50).Value = _Fecha_Turno
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 50).Value = _Usuario
            cms.Connection = cn
            If Cod_CS = 3 Then
                cms.CommandText = "SELECT COUNT(tipificacion)as Cerrados from Productividad where idusuario=@_Usuario and tipificacion='Cerrado' and fcreg>=@_Fecha_Turno and fcreg<=@_Fecha_Actual"
                cms.Connection = cn2
            End If
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Cerrados") Is System.DBNull.Value Then
                    _Cerrado = " "
                Else
                    _Cerrado = dts.Tables(0).Rows(0).Item("Cerrados")
                End If
            End If
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

    Public Function ProductividadEscalados() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim cn2 As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn2 = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cn2.Open()
            cms.CommandText = "SELECT COUNT(tipificacion)as Escalado from Productividad where idusuario=@_Usuario and tipificacion='Escalado' and fcreg>=@_Fecha_Turno and fcreg<=@_Fecha_Actual"
            cms.Parameters.Add("@_Fecha_Actual", SqlDbType.VarChar, 50).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fecha_Turno", SqlDbType.VarChar, 50).Value = _Fecha_Turno
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 50).Value = _Usuario
            cms.Connection = cn
            If Cod_CS = 3 Then
                cms.CommandText = "SELECT COUNT(tipificacion)as Escalado from Productividad where idusuario=@_Usuario and tipificacion='Escalado' and fcreg>=@_Fecha_Turno and fcreg<=@_Fecha_Actual"
                cms.Connection = cn2
            End If
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Escalado") Is System.DBNull.Value Then
                    _Escalado = " "
                Else
                    _Escalado = dts.Tables(0).Rows(0).Item("Escalado")
                End If
            End If
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

    Public Function ProductividadRechazados() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT COUNT(tipificacion)as Rechazado from Productividad where idusuario=@_Usuario and tipificacion='Rechazado' and fcreg>=@_Fecha_Turno and fcreg<=@_Fecha_Actual"
            cms.Parameters.Add("@_Fecha_Actual", SqlDbType.VarChar, 50).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fecha_Turno", SqlDbType.VarChar, 50).Value = _Fecha_Turno
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 50).Value = _Usuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Rechazado") Is System.DBNull.Value Then
                    _Rechazado = " "
                Else
                    _Rechazado = dts.Tables(0).Rows(0).Item("Rechazado")
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

    Public Function ProductividadCerrados_Esca_Falla() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT COUNT(tipificacion)as Cerrado from Productividad_Esca_Falla where idusuario=@_Usuario and tipificacion='Cerrado' and fcreg>=@_Fecha_Turno and fcreg<=@_Fecha_Actual"
            cms.Parameters.Add("@_Fecha_Actual", SqlDbType.VarChar, 50).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fecha_Turno", SqlDbType.VarChar, 50).Value = _Fecha_Turno
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 50).Value = _Usuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Cerrado") Is System.DBNull.Value Then
                    _Cerrado = " "
                Else
                    _Cerrado = dts.Tables(0).Rows(0).Item("Cerrado")
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


    Public Function ProductividadReportado() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT COUNT(tipificacion)as Reportado from Productividad_Esca_Falla where idusuario=@_Usuario and tipificacion='Reportado' and fcreg>=@_Fecha_Turno and fcreg<=@_Fecha_Actual"
            cms.Parameters.Add("@_Fecha_Actual", SqlDbType.VarChar, 50).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fecha_Turno", SqlDbType.VarChar, 50).Value = _Fecha_Turno
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 50).Value = _Usuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Reportado") Is System.DBNull.Value Then
                    _Reportado = " "
                Else
                    _Reportado = dts.Tables(0).Rows(0).Item("Reportado")
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

    Public Function ProductividadAsignado() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT COUNT(tipificacion)as Asignado from Productividad_Esca_Falla where idusuario=@_Usuario and tipificacion='Asignado' and fcreg>=@_Fecha_Turno and fcreg<=@_Fecha_Actual "
            cms.Parameters.Add("@_Fecha_Actual", SqlDbType.VarChar, 50).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fecha_Turno", SqlDbType.VarChar, 50).Value = _Fecha_Turno
            cms.Parameters.Add("@_Usuario", SqlDbType.VarChar, 50).Value = _Usuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Asignado") Is System.DBNull.Value Then
                    _Asignado = " "
                Else
                    _Asignado = dts.Tables(0).Rows(0).Item("Asignado")
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

    Public Function consultarProductividadAgentes() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT  Idusu,nombre,cargou,COUNT ([Gestionado]) AS Gestionado, COUNT ([Escalado]) AS Escalado, COUNT ([Cerrado]) AS Cerrado, (COUNT(Cerrado)+COUNT(Gestionado)+COUNT(Escalado)) as total FROM (SELECT     idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (tipificacion) FOR tipificacion IN( [Gestionado] ,[Escalado], [Cerrado])) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Turno and CRMDetalle.fcreg <=@_Fecha_Actual GROUP BY Idusu,nombre,cargou ORDER BY total desc"
            cms.Parameters.Add("@_Fecha_Actual", SqlDbType.VarChar, 50).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fecha_Turno", SqlDbType.VarChar, 50).Value = _Fecha_Turno
            If _Grupo <> Nothing Then
                cms.CommandText = "SELECT  Idusu,nombre,cargou,COUNT ([Gestionado]) AS Gestionado, COUNT ([Escalado]) AS Escalado, COUNT ([Cerrado]) AS Cerrado, (COUNT(Cerrado)+COUNT(Gestionado)+COUNT(Escalado)) as total FROM (SELECT     idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (tipificacion) FOR tipificacion IN( [Gestionado] ,[Escalado], [Cerrado])) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Turno and CRMDetalle.fcreg <=@_Fecha_Actual and cargo=@_Grupo GROUP BY Idusu,nombre,cargou ORDER BY total desc"
                cms.Parameters.Add("@_Grupo", SqlDbType.VarChar, 10).Value = _Grupo
            End If
            If Cod_CS = 2 Then
                cms.CommandText = "SELECT  Idusu,nombre,cargou, COUNT ([Escalado]) AS Escalado, COUNT ([Cerrado]) AS Cerrado, (COUNT(Cerrado)+COUNT(Escalado)) as total FROM (SELECT     idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (tipificacion) FOR tipificacion IN( [Escalado], [Cerrado])) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >='@_Fecha_Turno' and CRMDetalle.fcreg <=@_Fecha_Actual GROUP BY Idusu,nombre,cargou ORDER BY total desc"
            End If
            If Cod_CS = 2 And _Grupo <> Nothing Then
                cms.CommandText = "SELECT  Idusu,nombre,cargou, COUNT ([Escalado]) AS Escalado, COUNT ([Cerrado]) AS Cerrado, (COUNT(Cerrado)+COUNT(Escalado)) as total FROM (SELECT     idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (tipificacion) FOR tipificacion IN( [Escalado], [Cerrado])) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >='@_Fecha_Turno' and CRMDetalle.fcreg <=@_Fecha_Actual and cargo=@_Grupo GROUP BY Idusu,nombre,cargou ORDER BY total desc"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me._Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultarProductividadAgentesVOZ() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT  Idusu,nombre,cargou,COUNT ([Rechazado]) AS Rechazado, COUNT ([Escalado]) AS Escalado, COUNT ([Cerrado]) AS Cerrado, (COUNT(Cerrado)+COUNT(Rechazado)+COUNT(Escalado)) as total FROM (SELECT     idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(VT.estagogest) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.UsuariosVoz U on CRM.idusuario = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRM.tipificacion = VT.tipifcrm GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (tipificacion)FOR tipificacion IN( [Rechazado] ,[Escalado], [Cerrado])) AS VCRMDetalle inner join dbo.UsuariosVoz U on VCRMDetalle.Idusu = U.idusuario where VCRMDetalle.fcreg >=@_Fecha_Turno and VCRMDetalle.fcreg <=@_Fecha_Actual GROUP BY Idusu,nombre,cargou ORDER BY total desc"
            cms.Parameters.Add("@_Fecha_Actual", SqlDbType.VarChar, 50).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fecha_Turno", SqlDbType.VarChar, 50).Value = _Fecha_Turno
            If _Grupo <> Nothing Then
                cms.CommandText = "SELECT  Idusu,nombre,cargou,COUNT ([Rechazado]) AS Rechazado, COUNT ([Escalado]) AS Escalado, COUNT ([Cerrado]) AS Cerrado, (COUNT(Cerrado)+COUNT(Rechazado)+COUNT(Escalado)) as total FROM (SELECT     idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(VT.estagogest) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.UsuariosVoz U on CRM.idusuario = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRM.tipificacion = VT.tipifcrm GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (tipificacion)FOR tipificacion IN( [Rechazado] ,[Escalado], [Cerrado])) AS VCRMDetalle inner join dbo.UsuariosVoz U on VCRMDetalle.Idusu = U.idusuario where VCRMDetalle.fcreg >=@_Fecha_Turno and VCRMDetalle.fcreg <=@_Fecha_Actual and cargo=@_Grupo GROUP BY Idusu,nombre,cargou ORDER BY total desc"
                cms.Parameters.Add("@_Grupo", SqlDbType.VarChar, 10).Value = _Grupo
            End If
            If Cod_CS = 2 Then
                cms.CommandText = "SELECT  Idusu,nombre,cargou,COUNT ([Reportado]) AS Reportado, COUNT ([Asignado]) AS Asignado, COUNT ([Cerrado]) AS Cerrado, (COUNT(Cerrado)+COUNT(Reportado)+COUNT(Asignado)) as total FROM (SELECT     idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(CRM.tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.UsuariosVoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (tipificacion)FOR tipificacion IN( [Reportado] ,[Asignado], [Cerrado])) AS VCRMDetalle inner join dbo.UsuariosVoz U on VCRMDetalle.Idusu = U.idusuario where VCRMDetalle.fcreg >=@_Fecha_Turno and VCRMDetalle.fcreg <=@_Fecha_Actual GROUP BY Idusu,nombre,cargou ORDER BY total desc"
            End If
            If Cod_CS = 2 And _Grupo <> Nothing Then
                cms.CommandText = "SELECT  Idusu,nombre,cargou,COUNT ([Reportado]) AS Reportado, COUNT ([Asignado]) AS Asignado, COUNT ([Cerrado]) AS Cerrado, (COUNT(Cerrado)+COUNT(Reportado)+COUNT(Asignado)) as total FROM (SELECT     idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(CRM.tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.UsuariosVoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (tipificacion)FOR tipificacion IN( [Reportado] ,[Asignado], [Cerrado])) AS VCRMDetalle inner join dbo.UsuariosVoz U on VCRMDetalle.Idusu = U.idusuario where VCRMDetalle.fcreg >=@_Fecha_Turno and VCRMDetalle.fcreg <=@_Fecha_Actual and cargo=@_Grupo GROUP BY Idusu,nombre,cargou ORDER BY total desc"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me._Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function ConsultarMetasHorasMinutos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select Dia,Nv1Hora,Nv1Minu from MetaCaso where Cod_MetaCaso = 1"
            If Cod_CS = 2 Then
                cms.CommandText = "select Dia,Nv2Hora,Nv2Minu from MetaCaso where Cod_MetaCaso = 1"
            End If
            If Cod_CS = 3 Then
                cms.CommandText = "select Dia,VOZHora,VOZMinu from MetaCaso where Cod_MetaCaso = 1"
            End If
            If Cod_CS = 4 Then
                cms.CommandText = "select Dia,OtroSerHora,OtroSerMinu from MetaCaso where Cod_MetaCaso = 1"
            End If
            If Cod_CS = 5 Then
                cms.CommandText = "select Dia,EscalamientoHora,EscalamientoMinu from MetaCaso where Cod_MetaCaso = 1"
            End If
            If Cod_CS = 6 Then
                cms.CommandText = "select Dia,FallatecHora,FallatecMinu from MetaCaso where Cod_MetaCaso = 1"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Dia") Is System.DBNull.Value Then
                    _Dia = " "
                Else
                    _Dia = dts.Tables(0).Rows(0).Item("Dia")
                End If
                If Cod_CS = 2 Then
                    If dts.Tables(0).Rows(0).Item("Nv2Hora") Is System.DBNull.Value Then
                        _CantidadH = " "
                    Else
                        _CantidadH = dts.Tables(0).Rows(0).Item("Nv2Hora")
                    End If
                    If dts.Tables(0).Rows(0).Item("Nv2Minu") Is System.DBNull.Value Then
                        _CantidadMinu = " "
                    Else
                        _CantidadMinu = dts.Tables(0).Rows(0).Item("Nv2Minu")
                    End If
                Else
                    If Cod_CS = 3 Then
                        If dts.Tables(0).Rows(0).Item("VOZHora") Is System.DBNull.Value Then
                            _CantidadH = " "
                        Else
                            _CantidadH = dts.Tables(0).Rows(0).Item("VOZHora")
                        End If
                        If dts.Tables(0).Rows(0).Item("VOZMinu") Is System.DBNull.Value Then
                            _CantidadMinu = " "
                        Else
                            _CantidadMinu = dts.Tables(0).Rows(0).Item("VOZMinu")
                        End If
                    Else
                        If Cod_CS = 4 Then
                            If dts.Tables(0).Rows(0).Item("OtroSerHora") Is System.DBNull.Value Then
                                _CantidadH = " "
                            Else
                                _CantidadH = dts.Tables(0).Rows(0).Item("OtroSerHora")
                            End If
                            If dts.Tables(0).Rows(0).Item("OtroSerMinu") Is System.DBNull.Value Then
                                _CantidadMinu = " "
                            Else
                                _CantidadMinu = dts.Tables(0).Rows(0).Item("OtroSerMinu")
                            End If
                        Else

                            If Cod_CS = 5 Then
                                If dts.Tables(0).Rows(0).Item("EscalamientoHora") Is System.DBNull.Value Then
                                    _CantidadH = " "
                                Else
                                    _CantidadH = dts.Tables(0).Rows(0).Item("EscalamientoHora")
                                End If
                                If dts.Tables(0).Rows(0).Item("EscalamientoMinu") Is System.DBNull.Value Then
                                    _CantidadMinu = " "
                                Else
                                    _CantidadMinu = dts.Tables(0).Rows(0).Item("EscalamientoMinu")
                                End If
                            Else
                                If Cod_CS = 6 Then
                                    If dts.Tables(0).Rows(0).Item("FallatecHora") Is System.DBNull.Value Then
                                        _CantidadH = " "
                                    Else
                                        _CantidadH = dts.Tables(0).Rows(0).Item("FallatecHora")
                                    End If
                                    If dts.Tables(0).Rows(0).Item("FallatecMinu") Is System.DBNull.Value Then
                                        _CantidadMinu = " "
                                    Else
                                        _CantidadMinu = dts.Tables(0).Rows(0).Item("FallatecMinu")
                                    End If
                                Else
                                    If dts.Tables(0).Rows(0).Item("Nv1Hora") Is System.DBNull.Value Then
                                        _CantidadH = " "
                                    Else
                                        _CantidadH = dts.Tables(0).Rows(0).Item("Nv1Hora")
                                    End If
                                    If dts.Tables(0).Rows(0).Item("Nv1Minu") Is System.DBNull.Value Then
                                        _CantidadMinu = " "
                                    Else
                                        _CantidadMinu = dts.Tables(0).Rows(0).Item("Nv1Minu")
                                    End If
                                End If
                            End If
                        End If
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

    Public Function ConsultaGrupoDatos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select cargo from usuarios where (cargo like 'N1%' or cargo like 'N2%' or cargo like 'N3%') and cargo like '%G%' group by cargo"
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

    Public Function ConsultaGrupoVoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select cargo from UsuariosVoz where (cargo like 'Voz%') and cargo like '%G%' group by cargo"
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

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''' Registro Aspirante ''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Id_Aspirante As Int64
    Protected _Id_Aspirante_Update As Int64
    Protected _Nombre_Aspirante As String
    Protected _Apellido As String
    Protected _Telefono As Int64
    Protected _Celular As Int64
    Protected _Correo As String
    Protected _Cod_Proceso_Seleccion As Integer

    Public Property Id_Aspirante() As Int64
        Get
            Return _Id_Aspirante
        End Get
        Set(ByVal value As Int64)
            _Id_Aspirante = value
        End Set
    End Property

    Public Property Id_Aspirante_Update() As Int64
        Get
            Return _Id_Aspirante_Update
        End Get
        Set(ByVal value As Int64)
            _Id_Aspirante_Update = value
        End Set
    End Property

    Public Property Nombre_Aspirante() As String
        Get
            Return _Nombre_Aspirante
        End Get
        Set(ByVal value As String)
            _Nombre_Aspirante = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property

    Public Property Telefono() As Int64
        Get
            Return _Telefono
        End Get
        Set(ByVal value As Int64)
            _Telefono = value
        End Set
    End Property

    Public Property Celular() As Int64
        Get
            Return _Celular
        End Get
        Set(ByVal value As Int64)
            _Celular = value
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return _Correo
        End Get
        Set(ByVal value As String)
            _Correo = value
        End Set
    End Property

    Public Property Cod_Proceso_Seleccion() As Integer
        Get
            Return _Cod_Proceso_Seleccion
        End Get
        Set(ByVal value As Integer)
            _Cod_Proceso_Seleccion = value
        End Set
    End Property

    Public Sub IngresarAspirante()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Aspirante (Id_Aspirante,Nombre,Apellido,Telefono,Celular,Correo,Estado,Cod_Proceso_Seleccion)values(@_Id_Aspirante,@_Nombre_Aspirante,@_Apellido,@_Telefono,@_Celular,@_Correo,@_Estado,@_Cod_Proceso_Seleccion)"
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.BigInt).Value = _Id_Aspirante
            cms.Parameters.Add("@_Nombre_Aspirante", SqlDbType.VarChar, 50).Value = _Nombre_Aspirante
            cms.Parameters.Add("@_Apellido", SqlDbType.VarChar, 250).Value = _Apellido
            cms.Parameters.Add("@_Telefono", SqlDbType.BigInt).Value = _Telefono
            cms.Parameters.Add("@_Celular", SqlDbType.BigInt).Value = _Celular
            cms.Parameters.Add("@_Correo", SqlDbType.VarChar, 50).Value = _Correo
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Cod_Proceso_Seleccion", SqlDbType.VarChar, 50).Value = _Cod_Proceso_Seleccion
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


    Public Function Consultar_Todos_Aspirantes() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select Id_Aspirante,Nombre,Apellido,Telefono,Celular,Correo,Cargo,Cod_Proceso_Seleccion from Aspirante where Estado=1 order by Cod_Aspirante desc"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me._Cantidad = dts.Tables(0).Rows.Count
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

    Public Function Consultar_Aspirantes() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select * from Aspirante where Id_Aspirante=@_Id_Aspirante and Estado=1"
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.Int).Value = _Id_Aspirante
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Id_Aspirante") Is System.DBNull.Value Then
                    _Id_Aspirante = ""
                Else
                    _Id_Aspirante = dts.Tables(0).Rows(0).Item("Id_Aspirante")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre") Is System.DBNull.Value Then
                    _Nombre_Aspirante = ""
                Else
                    _Nombre_Aspirante = dts.Tables(0).Rows(0).Item("Nombre")
                End If
                If dts.Tables(0).Rows(0).Item("Apellido") Is System.DBNull.Value Then
                    _Apellido = ""
                Else
                    _Apellido = dts.Tables(0).Rows(0).Item("Apellido")
                End If
                If dts.Tables(0).Rows(0).Item("Telefono") Is System.DBNull.Value Then
                    _Telefono = ""
                Else
                    _Telefono = dts.Tables(0).Rows(0).Item("Telefono")
                End If
                If dts.Tables(0).Rows(0).Item("Celular") Is System.DBNull.Value Then
                    _Celular = ""
                Else
                    _Celular = dts.Tables(0).Rows(0).Item("Celular")
                End If
                If dts.Tables(0).Rows(0).Item("Correo") Is System.DBNull.Value Then
                    _Correo = ""
                Else
                    _Correo = dts.Tables(0).Rows(0).Item("Correo")
                End If
            Else
                dts = New DataSet
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


    Public Function Consultar_Aspirantes_Validacion() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select * from Aspirante where Id_Aspirante=@_Id_Aspirante and Estado=1"
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.Int).Value = _Id_Aspirante
            If (Nombre_Aspirante = "Validacion") Then
                cms.CommandText = "Select * from Aspirante where Id_Aspirante=@_Id_Aspirante"
                'cms.Parameters.Add("@_Id_Aspirante", SqlDbType.Int).Value = _Id_Aspirante
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Id_Aspirante") Is System.DBNull.Value Then
                    _Id_Aspirante = ""
                Else
                    _Id_Aspirante = dts.Tables(0).Rows(0).Item("Id_Aspirante")
                End If
                If dts.Tables(0).Rows(0).Item("Estado") Is System.DBNull.Value Then
                    _Estado = ""
                Else
                    _Estado = dts.Tables(0).Rows(0).Item("Estado")
                End If
            Else
                dts = New DataSet
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

    Public Sub ActualizarAspirante()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "update Aspirante set Id_Aspirante=@_Id_Aspirante2,Nombre=@_Nombre,Apellido=@_Apellido,Telefono=@_Telefono,Celular=@_Celular,Correo=@_Correo where Id_Aspirante=@_Id_Aspirante"
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.BigInt).Value = _Id_Aspirante
            cms.Parameters.Add("@_Id_Aspirante2", SqlDbType.BigInt).Value = _Id_Aspirante_Update
            cms.Parameters.Add("@_Nombre", SqlDbType.VarChar, 40).Value = _Nombre_Aspirante
            cms.Parameters.Add("@_Apellido", SqlDbType.VarChar, 50).Value = _Apellido
            cms.Parameters.Add("@_Telefono", SqlDbType.BigInt).Value = _Telefono
            cms.Parameters.Add("@_Celular", SqlDbType.BigInt).Value = _Celular
            cms.Parameters.Add("@_Correo", SqlDbType.VarChar, 50).Value = _Correo
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

    Public Sub EliminarAspirante()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Update Aspirante set Estado=@_Estado where Id_Aspirante=@_Id_Aspirante"
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.BigInt).Value = _Id_Aspirante
            cms.Parameters.Add("@_Estado", SqlDbType.Bit).Value = _Estado
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''Nivel_Academico'''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Cod_Nivel_Academico As Int64
    Protected _Fk_Cod_Estudio As Int64
    Protected _Descripcion As String
    Protected _Fk_Id_Aspirante_Estu As Int64
    Protected _CantidadE As Integer

    Public Property Cod_Nivel_Academico() As Int64
        Get
            Return _Cod_Nivel_Academico
        End Get
        Set(ByVal value As Int64)
            _Cod_Nivel_Academico = value
        End Set
    End Property

    Public Property Fk_Cod_Estudio() As Int64
        Get
            Return _Fk_Cod_Estudio
        End Get
        Set(ByVal value As Int64)
            _Fk_Cod_Estudio = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Fk_Id_Aspirante_Estu() As Int64
        Get
            Return _Fk_Id_Aspirante_Estu
        End Get
        Set(ByVal value As Int64)
            _Fk_Id_Aspirante_Estu = value
        End Set
    End Property

    Public Property CantidadE() As Integer
        Get
            Return _CantidadE
        End Get
        Set(ByVal value As Integer)
            _CantidadE = value
        End Set
    End Property

    Public Sub IngresarEstudios()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Nivel_Academico (Fk_Cod_Estudio,Descripcion,Fk_Id_Aspirante)values(@_Fk_Cod_Estudio,@_Descripcion,@_Fk_Id_Aspirante_Estu)"
            cms.Parameters.Add("@_Fk_Cod_Estudio", SqlDbType.BigInt).Value = _Fk_Cod_Estudio
            cms.Parameters.Add("@_Descripcion", SqlDbType.VarChar, 50).Value = _Descripcion
            cms.Parameters.Add("@_Fk_Id_Aspirante_Estu", SqlDbType.BigInt).Value = _Fk_Id_Aspirante_Estu
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

    Public Function Consulta_Todos_Estudios() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Integer
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select NA.Cod_Nivel_Academico as Codigo,E.Nombre ,NA.Descripcion,NA.Fk_Id_Aspirante as Identificacion from Nivel_Academico NA inner join Estudio E on Na.Fk_Cod_Estudio = E.Cod_Estudio"
            If Id_Aspirante <> Nothing Then
                cms.CommandText = "select NA.Cod_Nivel_Academico as Codigo,E.Nombre ,NA.Descripcion,NA.Fk_Id_Aspirante as Identificacion from Nivel_Academico NA inner join Estudio E on Na.Fk_Cod_Estudio = E.Cod_Estudio where NA.Fk_Id_Aspirante=@_Id_Aspirante "
                cms.Parameters.Add("@_Id_Aspirante", SqlDbType.BigInt).Value = _Id_Aspirante
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me._CantidadE = dts.Tables(0).Rows.Count
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


    Public Function Consultar_Estudio() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select * from Nivel_Academico where Cod_Nivel_Academico=@_Cod_Nivel_Academico"
            cms.Parameters.Add("@_Cod_Nivel_Academico", SqlDbType.Int).Value = _Cod_Nivel_Academico
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Fk_Cod_Estudio") Is System.DBNull.Value Then
                    _Fk_Cod_Estudio = ""
                Else
                    _Fk_Cod_Estudio = dts.Tables(0).Rows(0).Item("Fk_Cod_Estudio")
                End If
                If dts.Tables(0).Rows(0).Item("Descripcion") Is System.DBNull.Value Then
                    _Descripcion = ""
                Else
                    _Descripcion = dts.Tables(0).Rows(0).Item("Descripcion")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Id_Aspirante") Is System.DBNull.Value Then
                    _Fk_Id_Aspirante_Estu = ""
                Else
                    _Fk_Id_Aspirante_Estu = dts.Tables(0).Rows(0).Item("Fk_Id_Aspirante")
                End If
            Else
                dts = New DataSet
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

    Public Sub ActualizarEstudio()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "update Nivel_Academico set Fk_Cod_Estudio=@_Fk_Cod_Estudio,Descripcion=@_Descripcion,Fk_Id_Aspirante=@_Fk_Id_Aspirante_Estu where Cod_Nivel_Academico=@_Cod_Nivel_Academico"
            cms.Parameters.Add("@_Cod_Nivel_Academico", SqlDbType.BigInt).Value = _Cod_Nivel_Academico
            cms.Parameters.Add("@_Fk_Cod_Estudio", SqlDbType.BigInt).Value = _Fk_Cod_Estudio
            cms.Parameters.Add("@_Descripcion", SqlDbType.VarChar, 50).Value = _Descripcion
            cms.Parameters.Add("@_Fk_Id_Aspirante_Estu", SqlDbType.BigInt).Value = _Fk_Id_Aspirante_Estu
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

    Public Sub EliminarEstudio()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "delete Nivel_Academico where Cod_Nivel_Academico=@_Cod_Nivel_Academico"
            cms.Parameters.Add("@_Cod_Nivel_Academico", SqlDbType.BigInt).Value = _Cod_Nivel_Academico
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub

    Public Function ConsultarNivel() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try

            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT * from Estudio"
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

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''Experiencia'''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Cod_Experiencialab As Int64
    Protected _Cargo_Explab As String
    Protected _Tiempo As String
    Protected _Tiempo_Consul As String
    Protected _Fk_Id_Aspirante_Explab As Int64
    Protected _CantidadExplab As Integer

    Public Property Cod_Experiencialab() As Int64
        Get
            Return _Cod_Experiencialab
        End Get
        Set(ByVal value As Int64)
            _Cod_Experiencialab = value
        End Set
    End Property

    Public Property Cargo_Explab() As String
        Get
            Return _Cargo_Explab
        End Get
        Set(ByVal value As String)
            _Cargo_Explab = value
        End Set
    End Property

    Public Property Tiempo() As String
        Get
            Return _Tiempo
        End Get
        Set(ByVal value As String)
            _Tiempo = value
        End Set
    End Property

    Public Property Tiempo_Consul() As String
        Get
            Return _Tiempo_Consul
        End Get
        Set(ByVal value As String)
            _Tiempo_Consul = value
        End Set
    End Property

    Public Property Fk_Id_Aspirante_Explab() As Int64
        Get
            Return _Fk_Id_Aspirante_Explab
        End Get
        Set(ByVal value As Int64)
            _Fk_Id_Aspirante_Explab = value
        End Set
    End Property

    Public Property CantidadExplab() As Integer
        Get
            Return _CantidadExplab
        End Get
        Set(ByVal value As Integer)
            _CantidadExplab = value
        End Set
    End Property

    Public Sub IngresarExperiencialab()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Experiencialab (Cargo,Tiempo,Fk_Id_Aspirante)values(@_Cargo_Explab,@_Tiempo,@_Fk_Id_Aspirante_Explab)"
            cms.Parameters.Add("@_Cargo_Explab", SqlDbType.VarChar, 50).Value = _Cargo_Explab
            cms.Parameters.Add("@_Tiempo", SqlDbType.VarChar, 50).Value = _Tiempo
            cms.Parameters.Add("@_Fk_Id_Aspirante_Explab", SqlDbType.BigInt).Value = _Fk_Id_Aspirante_Explab
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

    Public Function Consulta_Todas_Experiencialab() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Integer
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select Cod_ExperienciaLab as Codigo,Cargo,Tiempo as duracion,Fk_Id_Aspirante as Identificacion from ExperienciaLab"
            If Id_Aspirante <> Nothing Then
                cms.CommandText = "select Cod_ExperienciaLab as Codigo,Cargo,Tiempo as duracion,Fk_Id_Aspirante as Identificacion from ExperienciaLab where Fk_Id_Aspirante=@_Id_Aspirante "
                cms.Parameters.Add("@_Id_Aspirante", SqlDbType.BigInt).Value = _Id_Aspirante
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me._CantidadE = dts.Tables(0).Rows.Count
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


    Public Function Consultar_ExperienciaLab() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select * from ExperienciaLab where Cod_ExperienciaLab=@_Cod_ExperienciaLab"
            cms.Parameters.Add("@_Cod_ExperienciaLab", SqlDbType.Int).Value = _Cod_Experiencialab
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Cargo") Is System.DBNull.Value Then
                    _Cargo_Explab = ""
                Else
                    _Cargo_Explab = dts.Tables(0).Rows(0).Item("Cargo")
                End If
                If dts.Tables(0).Rows(0).Item("Tiempo") Is System.DBNull.Value Then
                    _Tiempo = ""
                Else
                    _Tiempo = dts.Tables(0).Rows(0).Item("Tiempo")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Id_Aspirante") Is System.DBNull.Value Then
                    _Fk_Id_Aspirante_Explab = ""
                Else
                    _Fk_Id_Aspirante_Explab = dts.Tables(0).Rows(0).Item("Fk_Id_Aspirante")
                End If
            Else
                dts = New DataSet
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

    Public Sub ActualizarExperienciaLab()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "update ExperienciaLab set Cargo=@_Cargo_Explab,Tiempo=@_Tiempo,Fk_Id_Aspirante=@_Fk_Id_Aspirante_Explab where Cod_ExperienciaLab=@_Cod_ExperienciaLab"
            cms.Parameters.Add("@_Cod_ExperienciaLab", SqlDbType.BigInt).Value = _Cod_Experiencialab
            cms.Parameters.Add("@_Cargo_Explab", SqlDbType.VarChar, 50).Value = _Cargo_Explab
            cms.Parameters.Add("@_Tiempo", SqlDbType.VarChar, 50).Value = _Tiempo
            cms.Parameters.Add("@_Fk_Id_Aspirante_Explab", SqlDbType.BigInt).Value = _Fk_Id_Aspirante_Explab
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

    Public Sub EliminarExperienciaLab()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "delete ExperienciaLab where Cod_ExperienciaLab=@_Cod_ExperienciaLab"
            cms.Parameters.Add("@_Cod_ExperienciaLab", SqlDbType.BigInt).Value = _Cod_Experiencialab
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''Proceso_Seleccion''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Ya declarado en los atributos de aspirante'Protected _Cod_Proceso_Seleccion As Integer
    Protected _Cargo As String
    Protected _Observacion As String
    'Ya declarado en los atributos de caida del sistema'Protected _Estado As String
    Protected _Cantidad_Requerida As Integer
    Protected _Cantidad_Obtenida As Integer
    'Ya declarado en los atributos de caida del sistema'Protected _Fecha_Inicio As String
    Protected _Fecha_Fin As String

    Public Property Cargo As String
        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = value
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

    Public Property Cantidad_Requerida As Integer
        Get
            Return _Cantidad_Requerida
        End Get
        Set(ByVal value As Integer)
            _Cantidad_Requerida = value
        End Set
    End Property

    Public Property Cantidad_Obtenida As Integer
        Get
            Return _Cantidad_Obtenida
        End Get
        Set(ByVal value As Integer)
            _Cantidad_Obtenida = value
        End Set
    End Property

    Public Property Fecha_Fin As String
        Get
            Return _Fecha_Fin
        End Get
        Set(ByVal value As String)
            _Fecha_Fin = value
        End Set
    End Property

    Public Sub InsertarProceso_Seleccion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into Proceso_Seleccion (Cargo,Observacion,Estado,Cantidad_Requerida,Cantidad_Obtenida,Fecha_Inicio,Fecha_Fin) values (@_Cargo,@_Observacion,@_Estado,@_Cantidad_Requerida,@_Cantidad_Obtenida,@_Fecha_Inicio,@_Fecha_Fin)"
            cms.Parameters.Add("@_Cargo", SqlDbType.VarChar, 50).Value = _Cargo
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 500).Value = _Observacion
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Cantidad_Requerida", SqlDbType.Int).Value = _Cantidad_Requerida
            cms.Parameters.Add("@_Cantidad_Obtenida", SqlDbType.Int).Value = _Cantidad_Obtenida
            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.DateTime).Value = _Fecha_Inicio
            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.DateTime).Value = _Fecha_Fin
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

    Public Function consultar_Todos_Procesos_Seleccion()
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
            cn.Open()
            cms.CommandText = "Select * from Proceso_Seleccion"
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

    Public Function Consultar_Proceso_Seleccion()
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Integer
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
            cn.Open()
            cms.CommandText = "Select * from Proceso_Seleccion where Cod_Proceso_Seleccion=@_Cod_Proceso_Seleccion"
            cms.Parameters.Add("@_Cod_Proceso_Seleccion", SqlDbType.Int).Value = _Cod_Proceso_Seleccion
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Cargo") Is System.DBNull.Value Then
                    _Cargo = ""
                Else
                    _Cargo = dts.Tables(0).Rows(0).Item("Cargo")
                End If
                If dts.Tables(0).Rows(0).Item("Observacion") Is System.DBNull.Value Then
                    _Observacion = ""
                Else
                    _Observacion = dts.Tables(0).Rows(0).Item("Observacion")
                End If
                If dts.Tables(0).Rows(0).Item("Estado") Is System.DBNull.Value Then
                    _Estado = ""
                Else
                    _Estado = dts.Tables(0).Rows(0).Item("Estado")
                End If
                If dts.Tables(0).Rows(0).Item("Cantidad_Requerida") Is System.DBNull.Value Then
                    _Cantidad_Requerida = ""
                Else
                    _Cantidad_Requerida = dts.Tables(0).Rows(0).Item("Cantidad_Requerida")
                End If
                If dts.Tables(0).Rows(0).Item("Cantidad_Obtenida") Is System.DBNull.Value Then
                    _Cantidad_Obtenida = ""
                Else
                    _Cantidad_Obtenida = dts.Tables(0).Rows(0).Item("Cantidad_Obtenida")
                End If
                If dts.Tables(0).Rows(0).Item("Fecha_Inicio") Is System.DBNull.Value Then
                    _Fecha_Inicio = ""
                Else
                    _Fecha_Inicio = dts.Tables(0).Rows(0).Item("Fecha_Inicio")
                End If
                If dts.Tables(0).Rows(0).Item("Fecha_Fin") Is System.DBNull.Value Then
                    _Fecha_Fin = ""
                Else
                    _Fecha_Fin = dts.Tables(0).Rows(0).Item("Fecha_Fin")
                End If
            Else
                dts = New DataSet
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

    Public Sub Actualizar_Proceso_Seleccion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Update Proceso_Seleccion set Cargo=@_Cargo,Observacion=@_Observacion,Estado=@_Estado,Cantidad_Requerida=@_Cantidad_Requerida,Cantidad_Obtenida=@_Cantidad_Obtenida,Fecha_Inicio=@_Fecha_Inicio,Fecha_Fin=@_Fecha_Fin where Cod_Proceso_Seleccion=@_Cod_Proceso_Seleccion"
            cms.Parameters.Add("@_Cod_Proceso_Seleccion", SqlDbType.Int).Value = _Cod_Proceso_Seleccion
            cms.Parameters.Add("@_Cargo", SqlDbType.VarChar, 50).Value = _Cargo
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 500).Value = _Observacion
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Cantidad_Requerida", SqlDbType.Int).Value = _Cantidad_Requerida
            cms.Parameters.Add("@_Cantidad_Obtenida", SqlDbType.Int).Value = _Cantidad_Obtenida
            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.DateTime).Value = _Fecha_Inicio
            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.DateTime).Value = _Fecha_Fin
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

    Public Sub Eliminar_Proceso_Seleccion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Delete Proceso_Seleccion where Cod_Proceso_Seleccion = @_Cod_Proceso_Seleccion"
            cms.Parameters.Add("@_Cod_Proceso_Seleccion", SqlDbType.Int).Value = _Cod_Proceso_Seleccion
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

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''Estado_Seleccion'''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Cod_Estado_Seleccion As Integer
    'Ya declarado en los atributos de aspirante'Protected _Nombre As String
    'Ya declarado en los atributos de Nivel_Academico'Protected _Descripcion As String

    Public Property Cod_Estado_Seleccion As Integer
        Get
            Return _Cod_Proceso_Seleccion
        End Get
        Set(ByVal value As Integer)
            _Cod_Proceso_Seleccion = value
        End Set
    End Property




    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''Detalle_PS_A'''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Cod_Detalle_PS_A As Integer
    Protected _Fk_Cod_Filtro_Seleccion As Integer
    'Ya declarado en los atributos de Proceso de seleccion'Protected _Observacion As String
    Protected _Fecha As String
    Protected _Fk_Id_Aspirante As Int64
    Protected _Fk_Cod_Proceso_Seleccion As Integer
    Protected _Fk_Cod_Estado_Seleccion As Integer

    Public Property Cod_Detalle_PS_A As Integer
        Get
            Return _Cod_Detalle_PS_A
        End Get
        Set(ByVal value As Integer)
            _Cod_Detalle_PS_A = value
        End Set
    End Property

    Public Property Fk_Cod_Filtro_Seleccion As Integer
        Get
            Return _Fk_Cod_Filtro_Seleccion
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Filtro_Seleccion = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Fk_Id_Aspirante As Int64
        Get
            Return _Fk_Id_Aspirante
        End Get
        Set(ByVal value As Int64)
            _Fk_Id_Aspirante = value
        End Set
    End Property

    Public Property Fk_Cod_Proceso_Seleccion As Integer
        Get
            Return _Fk_Cod_Proceso_Seleccion
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Proceso_Seleccion = value
        End Set
    End Property

    Public Property Fk_Cod_Estado_Seleccion As Integer
        Get
            Return _Fk_Cod_Estado_Seleccion
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Estado_Seleccion = value
        End Set
    End Property

    Public Sub Ingresar_Detalle_PS_A()
        Dim cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into Detalle_PS_A (Fk_Cod_Filtro_Seleccion,Observacion,Fecha,Fk_Id_Aspirante,Fk_Cod_Proceso_Seleccion,Fk_Cod_Estado_Seleccion) values (@_Fk_Cod_Filtro_Seleccion,@_Observacion,@_Fecha,@_Fk_Id_Aspirante,@_Fk_Cod_Proceso_Seleccion,@_Fk_Cod_Estado_Seleccion)"
            cms.Parameters.Add("@_Fk_Cod_Filtro_Seleccion", SqlDbType.Int).Value = _Fk_Cod_Filtro_Seleccion
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 500).Value = _Observacion
            cms.Parameters.Add("@_Fecha", SqlDbType.DateTime).Value = _Fecha
            cms.Parameters.Add("@_Fk_Id_Aspirante", SqlDbType.Int).Value = _Fk_Id_Aspirante
            cms.Parameters.Add("@_Fk_Cod_Proceso_Seleccion", SqlDbType.Int).Value = _Fk_Cod_Proceso_Seleccion
            cms.Parameters.Add("@_Fk_Cod_Estado_Seleccion", SqlDbType.Int).Value = _Fk_Cod_Estado_Seleccion
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function Consultar_Todos_Detalle_PS_A()
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Integer
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
            cms.CommandText = "Select * from Detalle_PS_A"
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

    Public Function Consultar_Detalle_PS_A()
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Integer
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
            cms.CommandText = "Select * from Detalle_PS_A where Cod_Detalle_PS_A = @_Cod_Detalle_PS_A"
            cms.Parameters.Add("@_Cod_Detalle_PS_A", SqlDbType.Int).Value = _Cod_Detalle_PS_A
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Fk_Cod_Filtro_Seleccion") Is DBNull.Value Then
                    _Fk_Cod_Filtro_Seleccion = ""
                Else
                    _Fk_Cod_Filtro_Seleccion = dts.Tables(0).Rows(0).Item("Fk_Cod_Filtro_Seleccion")
                End If
                If dts.Tables(0).Rows(0).Item("Observacion") Is DBNull.Value Then
                    _Observacion = ""
                Else
                    _Observacion = dts.Tables(0).Rows(0).Item("Observacion")
                End If
                If dts.Tables(0).Rows(0).Item("Fecha") Is DBNull.Value Then
                    _Fecha = ""
                Else
                    _Fecha = dts.Tables(0).Rows(0).Item("Fecha")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Id_Aspirante") Is DBNull.Value Then
                    _Fk_Id_Aspirante = ""
                Else
                    _Fk_Id_Aspirante = dts.Tables(0).Rows(0).Item("Fk_Id_Aspirante")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Cod_Proceso_Seleccion") Is DBNull.Value Then
                    _Fk_Cod_Proceso_Seleccion = ""
                Else
                    _Fk_Cod_Proceso_Seleccion = dts.Tables(0).Rows(0).Item("Fk_Cod_Proceso_Seleccion")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Cod_Estado_Selecion") Is DBNull.Value Then
                    _Fk_Cod_Estado_Seleccion = ""
                Else
                    _Fk_Cod_Estado_Seleccion = dts.Tables(0).Rows(0).Item("Fk_Cod_Estado_Seleccion")
                End If
            Else
                dts = New DataSet
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

    Public Sub Acrualizar_Detalle_PS_A()
        Dim cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Update Detalle_PS_A Set Fk_Cod_Filtro_Seleccion=@_Fk_Cod_Filtro_Seleccion,Observacion=@_Observacion,Fecha=@_Fecha,Fk_Id_Aspirante=@_Fk_Id_Aspirate,Fk_Cod_Proceso_Seleccion=@_Fk_Cod_Proceso_Seleccion,Fk_Cod_Estado_Seleccion=@_Fk_Cod_Estado_Seleccion where Cod_Detalle_PS_A = @_Cod_Detalle_PS_A"
            cms.Parameters.Add("@_Cod_Detalle_PS_A", SqlDbType.Int).Value = _Cod_Detalle_PS_A
            cms.Parameters.Add("@_Fk_Cod_Filtro_Seleccion", SqlDbType.Int).Value = _Fk_Cod_Filtro_Seleccion
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 500).Value = _Observacion
            cms.Parameters.Add("@_Fecha", SqlDbType.DateTime).Value = _Fecha
            cms.Parameters.Add("@_Fk_Id_Aspirante", SqlDbType.BigInt).Value = _Fk_Id_Aspirante
            cms.Parameters.Add("@_Fk_Cod_Proceso_Seleccion", SqlDbType.Int).Value = _Fk_Cod_Proceso_Seleccion
            cms.Parameters.Add("@_Fk_Cod_Estado_Seleccion", SqlDbType.Int).Value = _Fk_Cod_Estado_Seleccion
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

    Public Sub Eliminar_Detalle_PS_A()
        Dim cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Delete Detalle_PS_A where Cod_Detalle_PS_A  =@_Cod_Detalle_PS_A"
            cms.Parameters.Add("@_Cod_Detalle_PS_A", SqlDbType.Int).Value = _Cod_Detalle_PS_A
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

    Public Function Consulta_Filtro() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Integer
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select top (@_Cantidad_Requerida) A.Id_Aspirante,A.Nombre,A.Apellido,EXPE.Cargo as CargoEjercio,EXPE.Tiempo from Aspirante A inner join Nivel_Academico NA on A.Id_Aspirante = NA.Fk_Id_Aspirante inner join Estudio E on NA.Fk_Cod_Estudio = E.Cod_Estudio inner join ExperienciaLab EXPE on EXPE.Fk_Id_Aspirante = A.Id_Aspirante where E.Cod_Estudio = @_Fk_Cod_Estudio and EXPE.Cargo like '%" + _Cargo_Explab + "%' and ((EXPE.Tiempo like '%[@_Tiempo]%' and EXPE.Tiempo like '%[@_Tiempo_Consul]%')or(EXPE.Tiempo like '%[@_Tiempo_Consul]%'))and a.Cod_Proceso_Seleccion=0"
            cms.Parameters.Add("@_Cantidad_Requerida", SqlDbType.Int).Value = _Cantidad_Requerida
            cms.Parameters.Add("@_Fk_Cod_Estudio", SqlDbType.Int).Value = _Fk_Cod_Estudio
            cms.Parameters.Add("@_CargoLab", SqlDbType.VarChar, 50).Value = _Cargo_Explab
            cms.Parameters.Add("@_Tiempo", SqlDbType.Int).Value = _Tiempo
            cms.Parameters.Add("@_Tiempo_Consul", SqlDbType.VarChar, 10).Value = _Tiempo_Consul
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            Me._CantidadE = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Sub Actualizar_Cod_PS_Aspirante()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Update Aspirante set Cod_Proceso_Seleccion=@_Cod_Proceso_Seleccion where Id_Aspirante=@_Id_Aspirante"
            cms.Parameters.Add("@_Cod_Proceso_Seleccion", SqlDbType.Int).Value = _Cod_Proceso_Seleccion
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.BigInt).Value = _Id_Aspirante_Update
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function Consulta_UltimoR_Proceso_Seleccion()
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cms.CommandText = "select MAX(Cod_Proceso_Seleccion) as Max_Registro from Proceso_Seleccion"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows(0).Item("Max_Registro") Is DBNull.Value Then
                _Cod_Proceso_Seleccion = ""
            Else
                _Cod_Proceso_Seleccion = dts.Tables(0).Rows(0).Item("Max_Registro")
            End If
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Function ConsultaProceso_Seleccion()
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cms.CommandText = "select cod_proceso_seleccion,(Cargo+' '+ (convert(varchar,Fecha_Inicio))) as Proceso from Proceso_Seleccion order by Cod_Proceso_Seleccion desc"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    ''' Polla Mundialista
    Protected _Cod_Polla_Mundialista_Equipo As Integer
    Protected _Nombre_Equipo_Polla As String
    Protected _Letra_Grupo As String
    Protected _Partido_N1 As Integer
    Protected _Partido_N2 As Integer
    Protected _Partido_N3 As Integer
    ''Registro
    Protected _Fc_Reg As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Id_Usuario As String
    Protected _Equipo1 As String
    Protected _Resultado1 As Integer
    Protected _Equipo2 As String
    Protected _Resultado2 As Integer
    Protected _EquipoGana As String

    Public Property EquipoGana As String
        Get
            Return _EquipoGana
        End Get
        Set(ByVal value As String)
            _EquipoGana = value
        End Set
    End Property
    Public Property Fc_Reg As String
        Get
            Return _Fc_Reg
        End Get
        Set(ByVal value As String)
            _Fc_Reg = value
        End Set
    End Property
    Public Property Id_Usuario As String
        Get
            Return _Id_Usuario
        End Get
        Set(ByVal value As String)
            _Id_Usuario = value
        End Set
    End Property
    Public Property Equipo1 As String
        Get
            Return _Equipo1
        End Get
        Set(ByVal value As String)
            _Equipo1 = value
        End Set
    End Property
    Public Property Resultado1 As Integer
        Get
            Return _Resultado1
        End Get
        Set(ByVal value As Integer)
            _Resultado1 = value
        End Set
    End Property
    Public Property Equipo2 As String
        Get
            Return _Equipo2
        End Get
        Set(ByVal value As String)
            _Equipo2 = value
        End Set
    End Property
    Public Property Resultado2 As Integer
        Get
            Return _Resultado2
        End Get
        Set(ByVal value As Integer)
            _Resultado2 = value
        End Set
    End Property
    Public Property Partido_N3 As Integer
        Get
            Return _Partido_N3
        End Get
        Set(ByVal value As Integer)
            _Partido_N3 = value
        End Set
    End Property
    Public Property Partido_N2 As Integer
        Get
            Return _Partido_N2
        End Get
        Set(ByVal value As Integer)
            _Partido_N2 = value
        End Set
    End Property
    Public Property Partido_N1 As Integer
        Get
            Return _Partido_N1
        End Get
        Set(ByVal value As Integer)
            _Partido_N1 = value
        End Set
    End Property
    Public Property Letra_Grupo As String
        Get
            Return _Letra_Grupo
        End Get
        Set(ByVal value As String)
            _Letra_Grupo = value
        End Set
    End Property
    Public Property Nombre_Equipo_Polla As String
        Get
            Return _Nombre_Equipo_Polla
        End Get
        Set(ByVal value As String)
            _Nombre_Equipo_Polla = value
        End Set
    End Property
    Public Property Cod_Polla_Mundialista_Equipo As Integer
        Get
            Return _Cod_Polla_Mundialista_Equipo
        End Get
        Set(ByVal value As Integer)
            _Cod_Polla_Mundialista_Equipo = value
        End Set
    End Property

    Public Function Consulta_Polla_Mundialista_Grupo_Partido() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cms.CommandText = "select * from Polla_Mundialista_Equipo where Grupo=@_Letra_Grupo and (Partido_N1=@_Partido_N1 or Partido_N2=@_Partido_N1 or Partido_N3=@_Partido_N1)"
            cms.Parameters.Add("@_Letra_Grupo", SqlDbType.VarChar, 15).Value = _Letra_Grupo
            cms.Parameters.Add("@_Partido_N1", SqlDbType.Int).Value = _Partido_N1
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Polla_Mundialista_Un_Registro() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cms.CommandText = "select * from Polla_Mundialista where Id_Usuario = @_Id_Usuario and Grupo=@_Grupo and Partido = @_Partido"
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 70).Value = _Id_Usuario
            cms.Parameters.Add("@_Grupo", SqlDbType.VarChar, 14).Value = _Letra_Grupo
            cms.Parameters.Add("@_Partido", SqlDbType.Int).Value = _Partido_N1
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub Ingresar_Resultado_Partido()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert Into Polla_Mundialista (Fc_Reg,Id_Usuario,Grupo,Partido,Equipo1,Resultado1,Equipo2,Resultado2) values (@_Fc_Reg,@_Id_Usuario,@_Grupo,@_Partido,@_Equipo1,@_Resultado1,@_Equipo2,@_Resultado2)"
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.VarChar, 20).Value = _Fc_Reg
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 70).Value = _Id_Usuario
            cms.Parameters.Add("@_Grupo", SqlDbType.VarChar, 14).Value = _Letra_Grupo
            cms.Parameters.Add("@_Partido", SqlDbType.Int).Value = _Partido_N1
            cms.Parameters.Add("@_Equipo1", SqlDbType.VarChar, 70).Value = _Equipo1
            cms.Parameters.Add("@_Resultado1", SqlDbType.Int).Value = Resultado1
            cms.Parameters.Add("@_Equipo2", SqlDbType.VarChar, 70).Value = _Equipo2
            cms.Parameters.Add("@_Resultado2", SqlDbType.Int).Value = _Resultado2
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function Consulta_Polla_Mundialista_Fecha_Actual() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cms.CommandText = "select * from Polla_Mundialista_Equipo where Fecha_N1 = (SELECT CONVERT (date, GETDATE())as Fecha) or Fecha_N2 = (SELECT CONVERT (date, GETDATE()) as Fecha) or Fecha_N3 = (SELECT CONVERT (date, GETDATE()) as Fecha)"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Polla_Mundialista_Mi_Resultado() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cms.CommandText = "select * from Polla_Mundialista where Id_Usuario = @_Id_Usuario order by Grupo,Partido"
            If _Letra_Grupo <> Nothing Then
                cms.CommandText = "select * from Polla_Mundialista where Id_Usuario = @_Id_Usuario and Grupo=@_Letra_Grupo order by Grupo,Partido"
                cms.Parameters.Add("@_Letra_Grupo", SqlDbType.VarChar, 50).Value = _Letra_Grupo
            End If
            If _Partido_N1 <> Nothing Then
                cms.CommandText = "select * from Polla_Mundialista where Id_Usuario = @_Id_Usuario and Partido=@_Partido_N1 order by Grupo,Partido"
                cms.Parameters.Add("@_Partido_N1", SqlDbType.Int).Value = _Partido_N1
            End If
            If _Letra_Grupo <> Nothing And _Partido_N1 <> Nothing Then
                cms.CommandText = "select * from Polla_Mundialista where Id_Usuario = @_Id_Usuario and Grupo=@_Letra_Grupo and Partido=@_Partido_N1 order by Grupo,Partido"
            End If
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Polla_Mundialista_Fecha_Encuentros() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cms.CommandText = "select * from Polla_Mundialista_Equipo_SegundaParte"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Polla_Mundialista_Raiking() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cms.CommandText = "select PMP.Id_Usuario,U.nombreu,U.cargo,PMP.Pts from Polla_Mundialista_Pts PMP inner join usuarios U on PMP.Id_Usuario = U.idusuario  order by PMP.Pts desc "
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub Ingresar_Resultado_Partido_FaseDos()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert Into Polla_Mundialista values (@_Fc_Reg,@_Id_Usuario,@_Grupo,@_Partido,@_Equipo1,@_Resultado1,@_Equipo2,@_Resultado2,@_EquipoGana)"
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.VarChar, 20).Value = _Fc_Reg
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 70).Value = _Id_Usuario
            cms.Parameters.Add("@_Grupo", SqlDbType.VarChar, 14).Value = _Letra_Grupo
            cms.Parameters.Add("@_Partido", SqlDbType.Int).Value = _Partido_N1
            cms.Parameters.Add("@_Equipo1", SqlDbType.VarChar, 70).Value = _Equipo1
            cms.Parameters.Add("@_Resultado1", SqlDbType.Int).Value = Resultado1
            cms.Parameters.Add("@_Equipo2", SqlDbType.VarChar, 70).Value = _Equipo2
            cms.Parameters.Add("@_Resultado2", SqlDbType.Int).Value = _Resultado2
            cms.Parameters.Add("@_EquipoGana", SqlDbType.VarChar, 70).Value = _EquipoGana
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function Productivdad_Consulta_Agentes() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from usuarios where cargo = @_Grupo or cargo='- Seleccione -'"
            cms.Parameters.Add("@_Grupo", SqlDbType.VarChar, 20).Value = _Grupo
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Productividad_Consulta_Agentes_Columna() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Agente_1 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_1", SqlDbType.VarChar, 200).Value = _Agente_1
            End If
            If Agente_2 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_2", SqlDbType.VarChar, 200).Value = _Agente_2
            End If
            If Agente_3 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_3", SqlDbType.VarChar, 200).Value = _Agente_3
            End If
            If Agente_4 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_4", SqlDbType.VarChar, 200).Value = _Agente_4
            End If
            If Agente_5 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_5", SqlDbType.VarChar, 200).Value = _Agente_5
            End If
            If Agente_6 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_6", SqlDbType.VarChar, 200).Value = _Agente_6
            End If
            If Agente_7 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + ",COUNT(" + _Agente_7 + ") as " + _Agente_7 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + "," + _Agente_7 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_7", SqlDbType.VarChar, 200).Value = _Agente_7
            End If
            If Agente_8 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + ",COUNT(" + _Agente_7 + ") as " + _Agente_7 + ",COUNT(" + _Agente_8 + ") as " + _Agente_8 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + "," + _Agente_7 + "," + _Agente_8 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_8", SqlDbType.VarChar, 200).Value = _Agente_8
            End If
            If Agente_9 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + ",COUNT(" + _Agente_7 + ") as " + _Agente_7 + ",COUNT(" + _Agente_8 + ") as " + _Agente_8 + ",COUNT(" + _Agente_9 + ") as " + _Agente_9 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + "," + _Agente_7 + "," + _Agente_8 + "," + _Agente_9 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_9", SqlDbType.VarChar, 200).Value = _Agente_9
            End If
            If Agente_10 <> Nothing Then
                cms.CommandText = "SELECT tipificacion,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + ",COUNT(" + _Agente_7 + ") as " + _Agente_7 + ",COUNT(" + _Agente_8 + ") as " + _Agente_8 + ",COUNT(" + _Agente_9 + ") as " + _Agente_9 + ",COUNT(" + _Agente_10 + ") as " + _Agente_10 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.CRMDetalle CRM inner join dbo.usuarios U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + "," + _Agente_7 + "," + _Agente_8 + "," + _Agente_9 + "," + _Agente_10 + ")) AS CRMDetalle inner join dbo.usuarios U on CRMDetalle.Idusu = U.idusuario where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY tipificacion"
                cms.Parameters.Add("@_Agente_10", SqlDbType.VarChar, 200).Value = _Agente_10
            End If
            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.DateTime).Value = _Fecha_Turno
            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.DateTime).Value = _Fecha_Actual
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Productividad_Consulta_Agentes_Columna_Voz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Agente_1 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_1", SqlDbType.VarChar, 200).Value = _Agente_1
            End If
            If Agente_2 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_2", SqlDbType.VarChar, 200).Value = _Agente_2
            End If
            If Agente_3 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_3", SqlDbType.VarChar, 200).Value = _Agente_3
            End If
            If Agente_4 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_4", SqlDbType.VarChar, 200).Value = _Agente_4
            End If
            If Agente_5 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_5", SqlDbType.VarChar, 200).Value = _Agente_5
            End If
            If Agente_6 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_6", SqlDbType.VarChar, 200).Value = _Agente_6
            End If
            If Agente_7 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + ",COUNT(" + _Agente_7 + ") as " + _Agente_7 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + "," + _Agente_7 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_7", SqlDbType.VarChar, 200).Value = _Agente_7
            End If
            If Agente_8 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + ",COUNT(" + _Agente_7 + ") as " + _Agente_7 + ",COUNT(" + _Agente_8 + ") as " + _Agente_8 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + "," + _Agente_7 + "," + _Agente_8 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_8", SqlDbType.VarChar, 200).Value = _Agente_8
            End If
            If Agente_9 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + ",COUNT(" + _Agente_7 + ") as " + _Agente_7 + ",COUNT(" + _Agente_8 + ") as " + _Agente_8 + ",COUNT(" + _Agente_9 + ") as " + _Agente_9 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + "," + _Agente_7 + "," + _Agente_8 + "," + _Agente_9 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_9", SqlDbType.VarChar, 200).Value = _Agente_9
            End If
            If Agente_10 <> Nothing Then
                cms.CommandText = "SELECT VT.estagogest,COUNT(" + _Agente_1 + ") as " + _Agente_1 + ",COUNT(" + _Agente_2 + ") as " + _Agente_2 + ",COUNT(" + _Agente_3 + ") as " + _Agente_3 + ",COUNT(" + _Agente_4 + ") as " + _Agente_4 + ",COUNT(" + _Agente_5 + ") as " + _Agente_5 + ",COUNT(" + _Agente_6 + ") as " + _Agente_6 + ",COUNT(" + _Agente_7 + ") as " + _Agente_7 + ",COUNT(" + _Agente_8 + ") as " + _Agente_8 + ",COUNT(" + _Agente_9 + ") as " + _Agente_9 + ",COUNT(" + _Agente_10 + ") as " + _Agente_10 + " FROM (SELECT idcaso, MAX(fcreg) AS fcreg, CRM.idusuario as Idusu,U.nombreu as nombre,U.cargo as cargou, MAX(tipificacion) AS tipificacion FROM dbo.VCRMDetalle CRM inner join dbo.usuariosvoz U on CRM.idusuario = U.idusuario GROUP BY idcaso, CRM.idusuario,U.nombreu,U.cargo) p PIVOT(max (nombre) FOR nombre IN(" + _Agente_1 + "," + _Agente_2 + "," + _Agente_3 + "," + _Agente_4 + "," + _Agente_5 + "," + _Agente_6 + "," + _Agente_7 + "," + _Agente_8 + "," + _Agente_9 + "," + _Agente_10 + ")) AS CRMDetalle inner join usuariosvoz U on CRMDetalle.Idusu = U.idusuario INNER JOIN dbo.VTiposoporte VT ON CRMDetalle.tipificacion = VT.tipifcrm where CRMDetalle.fcreg >=@_Fecha_Inicio and CRMDetalle.fcreg <=@_Fecha_Fin GROUP BY VT.estagogest"
                cms.Parameters.Add("@_Agente_10", SqlDbType.VarChar, 200).Value = _Agente_10
            End If
            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.DateTime).Value = _Fecha_Turno
            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.DateTime).Value = _Fecha_Actual
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

End Class
