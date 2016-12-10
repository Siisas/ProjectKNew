Public Class clsCafeteriaProductos
    Protected idProducto As Integer
    Protected nombreProducto As String
    Protected idCategoria As Integer
    Protected categoria As String
    Protected cantidadProducto As Integer
    Protected valorProducto As Integer
    Protected fechaRegistroProducto As Date
    Protected codigoCliente As Integer
    Protected CodigoEmpleado As Integer
    Protected nombreCliente As String
    Protected nombreEmpleado As String
    Protected proveedor As String
    Protected NumeroCedulaEmpleado As Integer
    Protected CedulaCliente As Integer
    Protected FechaVenta As Date
    Protected FechaFinal As Date

    Public Property PublicFechaFinal As Date
        Get
            Return FechaFinal

        End Get
        Set(value As Date)
            FechaFinal = value
        End Set
    End Property
    Public Property PublicFechaVenta As Date
        Get
            Return FechaVenta

        End Get
        Set(value As Date)
            FechaVenta = value
        End Set
    End Property

    Public Property PublicidProducto As Integer
        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
        End Set
    End Property

    Public Property PublicNombreProducto As String
        Get
            Return nombreProducto
        End Get
        Set(value As String)
            nombreProducto = value
        End Set
    End Property

    Public Property PublicIdCategoria As Integer
        Get
            Return idCategoria
        End Get
        Set(value As Integer)
            idCategoria = value
        End Set
    End Property

    Public Property PublicCategoria As String
        Get
            Return categoria
        End Get
        Set(value As String)
            categoria = value
        End Set
    End Property

    Public Property PublicCantidadProducto As Integer
        Get
            Return cantidadProducto
        End Get
        Set(value As Integer)
            cantidadProducto = value
        End Set
    End Property

    Public Property PublicValorProducto As Integer
        Get
            Return valorProducto
        End Get
        Set(value As Integer)
            valorProducto = value
        End Set
    End Property

    Public Property PublicFechaRegistroProducto As Date
        Get
            Return fechaRegistroProducto
        End Get
        Set(value As Date)
            fechaRegistroProducto = value
        End Set
    End Property

    Public Property PublicCodigoCliente As Integer
        Get
            Return codigoCliente
        End Get
        Set(value As Integer)
            codigoCliente = value
        End Set
    End Property

    Public Property PublicCodigoEmpleado As Integer
        Get
            Return CodigoEmpleado
        End Get
        Set(value As Integer)
            CodigoEmpleado = value
        End Set
    End Property

    Public Property PublicNombreCliente As String
        Get
            Return nombreCliente
        End Get
        Set(value As String)
            nombreCliente = value
        End Set
    End Property

    Public Property PublicNombreEmpleado As String
        Get
            Return nombreEmpleado
        End Get
        Set(value As String)
            nombreEmpleado = value
        End Set
    End Property
    Public Property PublicProveedor As String
        Get
            Return proveedor
        End Get
        Set(value As String)
            proveedor = value
        End Set
    End Property

    Public Property PublicicNumeroCedulaEmpleado As Integer
        Get
            Return NumeroCedulaEmpleado
        End Get
        Set(value As Integer)
            NumeroCedulaEmpleado = value
        End Set
    End Property
    Public Property PublicicCedulaCliente As Integer
        Get
            Return CedulaCliente
        End Get
        Set(value As Integer)
            CedulaCliente = value
        End Set
    End Property
    'empiezo a hacer conexion con la base de datos para insertar datos 
    'utilizo stored procedured y una propiedad como parametro que recibe
    Public Sub RegEmpleadosCafeteria()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand("SpRegistrarEmpleado", cn)
            cn.Open()
            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.AddWithValue("@NombreEmpleado", PublicNombreEmpleado)
            cms.Parameters.AddWithValue("@CedulaEmpleado", PublicCodigoEmpleado)
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

    Public Sub RegClienteCafeteria()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand("SpRegistarCliente", cn)
            cn.Open()
            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.AddWithValue("@NombreCliente", nombreCliente)
            cms.Parameters.AddWithValue("@CedulaCliente", CedulaCliente)
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

    Public Sub RegProductos()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cmd As New SqlClient.SqlCommand("SpInsertarProductos", cn) 'ok  
            cn.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@NombreProducto", PublicNombreProducto)
            cmd.Parameters.AddWithValue("@IdCategoria", PublicIdCategoria)
            cmd.Parameters.AddWithValue("@ValorProducto", PublicValorProducto)
            cmd.Parameters.AddWithValue("@FechaIngresoPro", PublicFechaRegistroProducto)
            cmd.Parameters.AddWithValue("@CodigoEmpleado", PublicCodigoEmpleado)
            cmd.Parameters.AddWithValue("@Proveedor", PublicProveedor)
            cmd.Parameters.AddWithValue("@CantidadProducto", PublicCantidadProducto)
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function CargarDatosDDlProductosNmbreP()
        Dim cx As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeData As SqlClient.SqlDataAdapter
        Try
            cx.Open()
            Dim cmd As New SqlClient.SqlCommand("SpDDLConsultaProducNombre", cx)
            RecibeData = New SqlClient.SqlDataAdapter(cmd)
            RecibeData.Fill(datos)
            cmd.ExecuteReader()
            Return datos
        Catch ex As Exception
            Throw ex
        Finally
            If cx.State = ConnectionState.Open Then
                cx.Close()
            End If
        End Try
    End Function


    Public Function CargarDatosDDlProductos()
        Dim cx As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeData As SqlClient.SqlDataAdapter
        Try
            cx.Open()
            Dim cmd As New SqlClient.SqlCommand("SpConsultaJoinCategoriaCafeteriaProductos", cx)
            RecibeData = New SqlClient.SqlDataAdapter(cmd)
            RecibeData.Fill(datos)
            cmd.ExecuteReader()
            Return datos
        Catch ex As Exception
            Throw ex
        Finally
            If cx.State = ConnectionState.Open Then
                cx.Close()
            End If
        End Try
    End Function

    Public Function CargarDatosDDlComprarProductos()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            cn.Open()
            Dim cmd As New SqlClient.SqlCommand("SpLLenarDDLVEntaProductos", cn) 'OK
            cmd.CommandType = CommandType.StoredProcedure
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            RecibeDatos.Fill(datos)
            cmd.ExecuteReader()
            Return datos
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function CargarDatosDDlComprarCategoria()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            cn.Open()
            Dim cmd As New SqlClient.SqlCommand("SpLLenarDDlVentasCategoria", cn) 'OK
            cmd.CommandType = CommandType.StoredProcedure
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            RecibeDatos.Fill(datos)
            cmd.ExecuteReader()
            Return datos
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Function

    Public Function CargarDatosDDlComprarNombreEmpleado()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            cn.Open()
            Dim cmd As New SqlClient.SqlCommand("SpLLenarDDlNombreEmpleado", cn) 'ok
            cmd.CommandType = CommandType.StoredProcedure
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            RecibeDatos.Fill(datos)
            cmd.ExecuteReader()
            Return datos
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Function
    Public Function CargarDatosDDlValorProducto()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            cn.Open()
            Dim cmd As New SqlClient.SqlCommand("SpDdlProductos", cn) 'ok
            cmd.CommandType = CommandType.StoredProcedure
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            RecibeDatos.Fill(datos)
            cmd.ExecuteReader()
            Return datos
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Function

    Public Function CargarDatosIndexProducto()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "select ValorProducto from RLProductos where IdProducto = @IdProductos"
            cmd.Parameters.Add("@IdProductos", SqlDbType.BigInt).Value = idProducto
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)
            If datos.Tables(0).Rows(0).Item("ValorProducto") Is System.DBNull.Value Then
                valorProducto = " "
            Else
                valorProducto = datos.Tables(0).Rows(0).Item("ValorProducto")
            End If
            Return valorProducto
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CargarDatosIndexProductoCantidadProductosDisponibles()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "select CantidadProducto from RLProductos where IdProducto = @IdProductos"
            cmd.Parameters.Add("@IdProductos", SqlDbType.BigInt).Value = idProducto
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)
            If datos.Tables(0).Rows(0).Item("CantidadProducto") Is System.DBNull.Value Then
                cantidadProducto = " "
            Else
                cantidadProducto = datos.Tables(0).Rows(0).Item("CantidadProducto")
            End If
            Return cantidadProducto
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CargarDatosDDlComprarNombreCliente()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            cn.Open()
            Dim cmd As New SqlClient.SqlCommand("SpLLenarDDlNombreCliente", cn) 'ók
            cmd.CommandType = CommandType.StoredProcedure
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            RecibeDatos.Fill(datos)
            cmd.ExecuteReader()
            Return datos
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub Ventas()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cmd As New SqlClient.SqlCommand("SpInsertarVentas", cn) 'ok  
            cn.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdCategoria", PublicIdCategoria)
            cmd.Parameters.AddWithValue("@IdProducto", PublicidProducto)
            cmd.Parameters.AddWithValue("@CodigoEmpleado", PublicCodigoEmpleado)
            cmd.Parameters.AddWithValue("@CodigoCliente", PublicCodigoCliente)
            cmd.Parameters.AddWithValue("@ValorProducto", PublicValorProducto)
            cmd.Parameters.AddWithValue("@CantidadProducto", PublicCantidadProducto)
            cmd.Parameters.AddWithValue("@FechaVenta", PublicFechaVenta)
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function ConsultaProductos()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand
        Try
            cn.Open()
            cmd.CommandText = "
              select NombreProducto, Categoria,FechaIngresoPro,NombreEmpleado,Proveedor,ValorProducto,CantidadProducto 
              From RLProductos P
              left join RLProductosCategoria C
              on P.IdProducto = C.IdCategoria
              left join RLProductosEmpleadoCafeteria E
              on P.IdProducto = E.CodigoEmpleado where IdProducto = @IdProducto
              or Categoria = @Categoria 
	          or FechaIngresoPro = @FechaIngresoPro"
            If PublicNombreProducto = "-Seleccione-" Then
                PublicNombreProducto = 0
                cmd.Parameters.Add("@IdProducto", SqlDbType.BigInt).Value = PublicNombreProducto
            Else
                cmd.Parameters.Add("@IdProducto", SqlDbType.BigInt).Value = PublicNombreProducto
            End If
            cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = categoria
            cmd.Parameters.Add("@FechaIngresoPro", SqlDbType.DateTime).Value = fechaRegistroProducto
            'cmd.Parameters.Add("@Proveedor", SqlDbType.VarChar).Value = proveedor
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)
            Return datos
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ConsultarProductosPorFecha()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand
        Try
            cn.Open()
            cmd.CommandText = "select  sum(ValorProducto) as total_en_dinero_por_productos_vendidos from RlProductosVentas where (@FechaInicial < @FechaFinal)"
            cmd.Parameters.Add("@FechaInicial", SqlDbType.Date).Value = PublicFechaRegistroProducto
            cmd.Parameters.Add("@FechaFinal", SqlDbType.Date).Value = PublicFechaFinal
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)
            Return datos
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ConsultarDisponibilidadProductos()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand
        Try
            cn.Open()
            cmd.CommandText = "select NombreProducto = @NombreProducto, sum(CantidadProducto)as totalDisponible from RLProductos"
            cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = PublicNombreProducto
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)
            Return datos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

