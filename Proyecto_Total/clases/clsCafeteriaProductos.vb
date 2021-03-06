﻿Public Class clsCafeteriaProductos
    Protected valorVenta As Integer
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

    Public Property PublicValorVenta As Integer
        Get
            Return valorVenta
        End Get
        Set(value As Integer)
            valorVenta = value
        End Set
    End Property
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
            Dim cms As New SqlClient.SqlCommand("Insert into REmpleadoCafeteria values (@NombreEmpleado,@CedulaEmpleado)", cn)
            cn.Open()

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
            Dim cms As New SqlClient.SqlCommand("Insert into RCLienteCafeteria values (@NombreCliente,@CedulaCliente)", cn)
            cn.Open()
            cms.Parameters.AddWithValue("@NombreCliente", PublicNombreCliente)
            cms.Parameters.AddWithValue("@CedulaCliente", PublicicCedulaCliente)
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

    Public Sub CrearProducto()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cmd As New SqlClient.SqlCommand("Insert into RCrearProducto values (@NombreProducto,@ValorProducto,@Proveedor,@FechaCreacion,@IdCategoria,@CodigoEmpleado)", cn) 'ok  
            cn.Open()
            'cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@NombreProducto", PublicNombreProducto)
            cmd.Parameters.AddWithValue("@ValorProducto", PublicValorProducto)
            cmd.Parameters.AddWithValue("@Proveedor", PublicProveedor)
            cmd.Parameters.AddWithValue("@FechaCreacion", PublicFechaRegistroProducto)
            cmd.Parameters.AddWithValue("@IdCategoria", PublicIdCategoria)
            cmd.Parameters.AddWithValue("@CodigoEmpleado", PublicCodigoEmpleado)
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
    Public Sub IngProductos()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cmd As New SqlClient.SqlCommand("update  RIngresoProducto set Cantidad = Cantidad + @Cantidad where IdCreacionProducto = @IdCreacionProducto", cn) 'ok  
            cn.Open()
            cmd.Parameters.AddWithValue("@IdCreacionProducto", PublicNombreProducto)
            cmd.Parameters.AddWithValue("@Cantidad", PublicCantidadProducto)
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
    Public Function CargarDatosDDlProductosNmbreP1()
        Dim cx As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeData As SqlClient.SqlDataAdapter
        Try
            cx.Open()
            Dim cmd As New SqlClient.SqlCommand("select * from RLProductos ", cx)
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
    Public Function CargarDatosDDlProductosNmbreP()
        Dim cx As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeData As SqlClient.SqlDataAdapter
        Try
            cx.Open()
            Dim cmd As New SqlClient.SqlCommand("select NombreProducto from RLProductos  group by NombreProducto", cx)
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
            Dim cmd As New SqlClient.SqlCommand("select * from RProductosCategoria", cx)
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
            Dim cmd As New SqlClient.SqlCommand(
            "select RC.IdCreacionProducto, NombreProducto,Cantidad 
            from RCrearProducto RC
			left join RIngresoProducto RI
            on RC.IdCreacionProducto = RI.IdCreacionProducto
            where Cantidad > 0", cn) 'OK
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
            Dim cmd As New SqlClient.SqlCommand("select * from REmpleadoCafeteria", cn) 'ok
            'cmd.CommandType = CommandType.StoredProcedure
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

    Public Function CargarDatosDDlrCrearProducto()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            cn.Open()
            Dim cmd As New SqlClient.SqlCommand("select * from RCrearProducto", cn) 'ok
            'cmd.CommandType = CommandType.StoredProcedure
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
            cmd.CommandText = "select ValorProducto from RCrearProducto where IdCreacionProducto = @IdCreacionProducto"
            cmd.Parameters.Add("@IdCreacionProducto", SqlDbType.BigInt).Value = PublicidProducto

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
    Public Function CargarDatosIndeProducto()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "select ValorProducto from RCrearProductos where IdCreacionProducto = @IdCreacionProducto"
            cmd.Parameters.Add("@IdCreacionProducto", SqlDbType.BigInt).Value = idProducto
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
            cmd.CommandText = "select SUM(Cantidad) as Cantidad from RIngresoProducto where IdCreacionProducto = @IdCreacionProducto"
            cmd.Parameters.Add("@IdCreacionProducto", SqlDbType.BigInt).Value = idProducto
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)

            If datos.Tables(0).Rows(0).Item("Cantidad") Is System.DBNull.Value Then
                cantidadProducto = 0
            Else

                cantidadProducto = datos.Tables(0).Rows(0).Item("Cantidad")
            End If
            Return cantidadProducto
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CargarDatosIndexProductoXIdProducto()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "select IdCreacionProducto from RCrearProducto where IdCreacionProducto = @IdCreacionProducto"
            cmd.Parameters.Add("@IdCreacionProducto", SqlDbType.BigInt).Value = idProducto
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)
            If datos.Tables(0).Rows(0).Item("IdCreacionProducto") Is System.DBNull.Value Then
                idProducto = " "
            Else
                idProducto = datos.Tables(0).Rows(0).Item("IdCreacionProducto")
            End If
            Return idProducto
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function CargarDatosIndexProductoXCategoria()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "
                        select Categoria 
                            from RCrearProducto RP
                            join RProductosCategoria RC
                            on RP.CodigoEmpleado= RC.IdCategoria
                            where IdCreacionProducto = @IdCreacionProducto"
            cmd.Parameters.Add("@IdCreacionProducto", SqlDbType.BigInt).Value = idProducto
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)
            If datos.Tables(0).Rows(0).Item("Categoria") Is System.DBNull.Value Then
                categoria = " "
            Else
                categoria = datos.Tables(0).Rows(0).Item("Categoria")
            End If
            Return categoria
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
            Dim cmd As New SqlClient.SqlCommand("select * from RClienteCafeteria", cn) 'ók
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
    Public Function CargarDatosCliente()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Try
            cn.Open()
            Dim cmd As New SqlClient.SqlCommand("select * from RClienteCafeteria", cn) 'ók

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
            Dim cmd As New SqlClient.SqlCommand("update RIngresoProducto set Cantidad= Cantidad - @Cantidad where IdCreacionProducto = @IdCreacionProducto", cn) 'ok  
            cn.Open()
            cmd.Parameters.AddWithValue("@IdCreacionProducto", PublicidProducto)
            cmd.Parameters.AddWithValue("@Cantidad", PublicCantidadProducto)

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
    Public Sub DatoTblVentas()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cmd As New SqlClient.SqlCommand("insert into RProductoVentas values (@IdCreacionProducto,@CodigoEmpleado,@ValorVenta,@CantidadProducto,@FechaVenta,@CodigoCliente)", cn) 'ok  
            cn.Open()

            cmd.Parameters.Add("@IdCreacionProducto", SqlDbType.BigInt).Value = PublicidProducto
            cmd.Parameters.Add("@CodigoEmpleado", SqlDbType.BigInt).Value = PublicCodigoEmpleado
            cmd.Parameters.Add("@ValorVenta", SqlDbType.BigInt).Value = PublicValorVenta
            cmd.Parameters.Add("@CantidadProducto", SqlDbType.BigInt).Value = PublicCantidadProducto
            cmd.Parameters.Add("@FechaVenta", SqlDbType.Date).Value = Date.Now.Date
            cmd.Parameters.Add("@CodigoCliente", SqlDbType.BigInt).Value = PublicCodigoCliente
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
                select Categoria,NombreProducto,ValorProducto,Proveedor,FechaCreacion,Cantidad
                from RCrearProducto RCP 
                join RProductosCategoria RCategoria
                on RCP.IdCategoria = RCategoria.IdCategoria
                join RIngresoProducto RIn
                on RCP.IdCreacionProducto = RIn.IdCreacionProducto where NombreProducto = @NombreProducto
                or Categoria = @Categoria
                or FechaIngreso = @FechaIngresoPro"
            If PublicNombreProducto = "-Seleccione-" Then
                PublicNombreProducto = 0
                cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = PublicNombreProducto
            Else
                cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = PublicNombreProducto
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
            cmd.CommandText =
                "select  NombreEmpleado,sum(CantidadProducto)as total_Cantidad_Productos, sum(ValorVenta) as total_Ventas 
                from RProductoVentas RPVentas
                join REmpleadoCafeteria Rcafeteria
                on RPVentas.IdCreacionProducto = Rcafeteria.CodigoEmpleado
                where FechaVenta Between @FechaVenta and @FechaVent group by NombreEmpleado"
            cmd.Parameters.Add("@FechaVenta", SqlDbType.Date).Value = Convert.ToDateTime(PublicFechaRegistroProducto)
            cmd.Parameters.Add("@FechaVent", SqlDbType.Date).Value = Convert.ToDateTime(PublicFechaFinal)
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)
            Return datos
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ConsultarDisponibilidad()
        Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim datos As New DataSet
        Dim RecibeDatos As SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand
        Try
            cn.Open()
            cmd.CommandText = "
            select NombreProducto, Cantidad,Proveedor,ValorProducto 
            from RCrearProducto RP
            join RIngresoProducto RI
            on RP.IdCreacionProducto = RI.IdCreacionProducto
            where NombreProducto = @NombreProducto"
            cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = PublicNombreProducto
            RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
            cmd.Connection = cn
            RecibeDatos.Fill(datos)
            Return datos
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Public Function ConsultarDisponibilidadProductos()
    '    Dim cn As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
    '    Dim datos As New DataSet
    '    Dim RecibeDatos As SqlClient.SqlDataAdapter
    '    Dim cmd As New SqlClient.SqlCommand
    '    Try
    '        cn.Open()
    '        cmd.CommandText = "select NombreProducto = @NombreProducto, sum as Total_Disponible(CantidadProducto)as totalDisponible from RLProductos"
    '        cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = PublicNombreProducto
    '        RecibeDatos = New SqlClient.SqlDataAdapter(cmd)
    '        cmd.Connection = cn
    '        RecibeDatos.Fill(datos)
    '        Return datos
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
End Class

