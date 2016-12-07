Imports System.Data.SqlClient

Public Class clsCafeteria
    'PERSONAL
    Private _prueba1 As Integer
    Protected _Codigo As String
    Protected _Documento As String
    Protected _Nombre As String
    Protected _Apellido As String
    Protected _Cantidad As Integer
    Protected _Cargo As String
    Protected _FechaIng As String
    Protected _Estado As String
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
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
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Documento() As String
        Get
            Return _Documento
        End Get
        Set(ByVal value As String)
            _Documento = value
        End Set
    End Property
    Public Property Cargo() As String
        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = value
        End Set
    End Property
    Public Property FechaIng() As String
        Get
            Return _FechaIng
        End Get
        Set(ByVal value As String)
            _FechaIng = value
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
    'PRODUCTO
    Protected _Codigo_Cafeteria_Producto As Int64
    Protected _Producto As String
    Protected _Valor_Unitario As Integer
    Public Property Codigo_Cafeteria_Producto() As Int64
        Get
            Return _Codigo_Cafeteria_Producto
        End Get
        Set(value As Int64)
            _Codigo_Cafeteria_Producto = value
        End Set
    End Property
    Public Property Producto() As String
        Get
            Return _Producto
        End Get
        Set(value As String)
            _Producto = value
        End Set
    End Property
    Public Property Valor_Unitario() As Integer
        Get
            Return _Valor_Unitario
        End Get
        Set(value As Integer)
            _Valor_Unitario = value
        End Set
    End Property
    'VENTA DETALLE
    Protected _Codigo_Cafeteria_VD As Int64
    Protected _Cantidad_Compra As Int64
    Public Property Codigo_Cafeteria_VD() As Int64
        Get
            Return _Codigo_Cafeteria_VD
        End Get
        Set(value As Int64)
            _Codigo_Cafeteria_VD = value
        End Set
    End Property
    Public Property Cantidad_Compra() As Int64
        Get
            Return _Cantidad_Compra
        End Get
        Set(value As Int64)
            _Cantidad_Compra = value
        End Set
    End Property
    'VENTA
    Protected _Codigo_Cafeteria_Venta As Int64
    Protected _Fecha_Venta As DateTime
    Protected _Id_Usuario As String
    Protected _Documento_Cliente As String
    Protected _Total As Integer
    Public Property Codigo_Cafeteria_Venta() As Int64
        Get
            Return _Codigo_Cafeteria_Venta
        End Get
        Set(value As Int64)
            _Codigo_Cafeteria_Venta = value
        End Set
    End Property
    Public Property Fecha_Venta() As DateTime
        Get
            Return _Fecha_Venta
        End Get
        Set(value As DateTime)
            _Fecha_Venta = value
        End Set
    End Property
    Public Property Id_Usuario() As String
        Get
            Return _Id_Usuario
        End Get
        Set(value As String)
            _Id_Usuario = value
        End Set
    End Property
    Public Property Documento_Cliente As String
        Get
            Return _Documento_Cliente
        End Get
        Set(value As String)
            _Documento_Cliente = value
        End Set
    End Property
    Public Property Total As String
        Get
            Return _Total
        End Get
        Set(value As String)
            _Total = value
        End Set
    End Property
    'REGISTRO PRODUCTOS
    Protected _NombreProNuevo As String
    Protected _ValorUnitProNuevo As Integer
    Public Property NombreProNuevo As String
        Get
            Return _NombreProNuevo
        End Get
        Set(value As String)
            _NombreProNuevo = value
        End Set
    End Property
    Public Property ValorUnitProNuevo As Integer
        Get
            Return _ValorUnitProNuevo
        End Get
        Set(value As Integer)
            _ValorUnitProNuevo = value
        End Set
    End Property
    Protected _Contador As Integer
    Public Property Contador As Integer
        Get
            Return _Contador
        End Get
        Set(value As Integer)
            _Contador = value
        End Set
    End Property
    'MES
    Protected _Grupo As String
    Public Property Grupo() As String
        Get
            Return _Grupo
        End Get
        Set(ByVal value As String)
            _Grupo = value
        End Set
    End Property
    Protected _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Public Function consultau() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from usuarios where idusuario=@_usuario"
            cms.Parameters.Add("@_usuario", SqlDbType.VarChar, 50).Value = _usuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Codnom") Is System.DBNull.Value Then
                    _Codigo = ""
                Else
                    _Codigo = dts.Tables(0).Rows(0).Item("Codnom")
                End If
                If dts.Tables(0).Rows(0).Item("nombreu") Is System.DBNull.Value Then
                    _Nombre = ""
                Else
                    _Nombre = dts.Tables(0).Rows(0).Item("nombreu")
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
    'CONSULTA DE CLIENTES
    Public Function consultausu() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from personal where documento=@_documento or codigo=@_documento"
            cms.Parameters.Add("@_documento", SqlDbType.VarChar, 11).Value = _Documento
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("documento") Is System.DBNull.Value Then
                    _Documento = ""
                Else
                    _Documento = dts.Tables(0).Rows(0).Item("documento")
                End If
                If dts.Tables(0).Rows(0).Item("Codigo") Is System.DBNull.Value Then
                    _Codigo = ""
                Else
                    _Codigo = dts.Tables(0).Rows(0).Item("Codigo")
                End If
                If dts.Tables(0).Rows(0).Item("nombres") Is System.DBNull.Value Then
                    _Nombre = ""
                Else
                    _Nombre = dts.Tables(0).Rows(0).Item("nombres")
                End If
                If dts.Tables(0).Rows(0).Item("apellidos") Is System.DBNull.Value Then
                    _Apellido = ""
                Else
                    _Apellido = dts.Tables(0).Rows(0).Item("apellidos")
                End If
                If dts.Tables(0).Rows(0).Item("cargo") Is System.DBNull.Value Then
                    _Cargo = ""
                Else
                    _Cargo = dts.Tables(0).Rows(0).Item("cargo")
                End If
                If dts.Tables(0).Rows(0).Item("fcing") Is System.DBNull.Value Then
                    _FechaIng = ""
                Else
                    _FechaIng = dts.Tables(0).Rows(0).Item("fcing")
                End If
                If dts.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    _Estado = ""
                Else
                    _Estado = dts.Tables(0).Rows(0).Item("estado")
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
    'CONSULTA USUARIOS 2
    Public Function consulusu2() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from personal where codigo=@_Codigo"
            cms.Parameters.Add("@_Codigo", SqlDbType.VarChar, 50).Value = _Codigo
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Documento") Is System.DBNull.Value Then
                    _Documento = ""
                Else
                    _Documento = dts.Tables(0).Rows(0).Item("Documento")
                End If
                If dts.Tables(0).Rows(0).Item("cargo") Is System.DBNull.Value Then
                    _Cargo = ""
                Else
                    _Cargo = dts.Tables(0).Rows(0).Item("cargo")
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

    'CONSULTA DE PRODUCTOS
    Public Function consultapro() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Cafeteria_Producto where Nombre= @_Producto "
            cms.Parameters.Add("@_producto", SqlDbType.VarChar, 100).Value = _Producto
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Contador = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    'CONSULTA TOTAL VENTAS
    Public Function consultaVentas() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Cafeteria_Venta "
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Contador = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Function
    Protected _ConsultaVen As String
    Public Property ConsultaVen() As String
        Get
            Return _ConsultaVen
        End Get
        Set(value As String)
            _ConsultaVen = value
        End Set
    End Property
    Protected _ConsultaFechaini As String
    Public Property ConsultaFechaini() As String
        Get
            Return _ConsultaFechaini
        End Get
        Set(value As String)
            _ConsultaFechaini = value
        End Set
    End Property
    Protected _ConsultaFechafin As String
    Public Property ConsultaFechafin() As String
        Get
            Return _ConsultaFechafin
        End Get
        Set(value As String)
            _ConsultaFechafin = value
        End Set
    End Property
    'CONSULTA venta ticket
    Public Function ConsultaVentaTicket() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Cafeteria_Venta"
            If _ConsultaVen <> Nothing Then
                cms.CommandText = "select * from Cafeteria_Venta where Cod_Cafeteria_Venta= @_ConsultaVen "
                cms.Parameters.Add("@_ConsultaVen", SqlDbType.VarChar, 100).Value = _ConsultaVen
            End If
            If _Documento_Cliente <> Nothing Then
                cms.CommandText = "select * from Cafeteria_Venta where Documento_Cliente= @_Documento_Cliente "
                cms.Parameters.Add("@_Documento_Cliente", SqlDbType.VarChar, 100).Value = _Documento_Cliente
            End If
            If _Id_Usuario <> Nothing Then
                cms.CommandText = "select * from Cafeteria_Venta where Id_Usuario= @_Id_Usuario "
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 100).Value = _Id_Usuario
            End If

            If _ConsultaFechaini <> Nothing Then
                cms.CommandText = "select * from Cafeteria_Venta CV where CV.Fecha_Venta >= @_ConsultaFechaini "
                cms.Parameters.Add("@_ConsultaFechaini", SqlDbType.DateTime).Value = _ConsultaFechaini
            End If
            If _ConsultaFechafin <> Nothing Then
                cms.CommandText = "select * from Cafeteria_Venta CV where CV.Fecha_Venta <= @_ConsultaFechafin "
                cms.Parameters.Add("@_ConsultaFechafin", SqlDbType.DateTime).Value = _ConsultaFechafin
            End If
            If _ConsultaFechafin <> "" And _ConsultaFechaini <> "" Then
                cms.CommandText = "select * from Cafeteria_Venta CV where CV.Fecha_Venta between @_ConsultaFechaini and @_ConsultaFechafin "
                'cms.Parameters.Add("@_ConsultaFechaini", SqlDbType.DateTime).Value = _ConsultaFechaini
                'cms.Parameters.Add("@_ConsultaFechafin", SqlDbType.DateTime).Value = _ConsultaFechafin
            End If

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Contador = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    'CONSULTA venta documento
    Public Function ConsultaVentaTotal() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select sum(Total) as total from Cafeteria_Venta"
            If _ConsultaVen <> Nothing Then
                cms.CommandText = "select Sum(Total) as Total from Cafeteria_Venta where Cod_Cafeteria_Venta= @_ConsultaVen "
                cms.Parameters.Add("@_ConsultaVen", SqlDbType.VarChar, 100).Value = _ConsultaVen
            End If
            If _Documento_Cliente <> Nothing Then
                cms.CommandText = "select Sum(Total) as Total from Cafeteria_Venta where Documento_Cliente= @_Documento_Cliente "
                cms.Parameters.Add("@_Documento_Cliente", SqlDbType.VarChar, 100).Value = _Documento_Cliente
            End If
            If _Id_Usuario <> Nothing Then
                cms.CommandText = "select Sum(Total) as Total from Cafeteria_Venta where Id_Usuario= @_Id_Usuario "
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 100).Value = _Id_Usuario
            End If
            If _ConsultaFechaini <> Nothing Then
                cms.CommandText = "select Sum(Total) as Total from Cafeteria_Venta CV where CV.Fecha_Venta >= @_ConsultaFechaini "
                cms.Parameters.Add("@_ConsultaFechaini", SqlDbType.DateTime).Value = _ConsultaFechaini
            End If
            If _ConsultaFechafin <> Nothing Then
                cms.CommandText = "select Sum(Total) as Total from Cafeteria_Venta CV where CV.Fecha_Venta <= @_ConsultaFechafin "
                cms.Parameters.Add("@_ConsultaFechafin", SqlDbType.DateTime).Value = _ConsultaFechafin
            End If
            If _ConsultaFechafin <> "" And _ConsultaFechaini <> "" Then
                cms.CommandText = "select Sum(Total) as Total from Cafeteria_Venta CV where CV.Fecha_Venta between @_ConsultaFechaini and @_ConsultaFechafin "
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Contador = dts.Tables(0).Rows.Count
            If _Contador > 0 Then
                If dts.Tables(0).Rows(0).Item("Total") Is System.DBNull.Value Then
                    _Total = ""
                Else
                    _Total = dts.Tables(0).Rows(0).Item("Total")
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




    'CONSULTA DE PRODUCTOS 
    Public Function consulta() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Cafeteria_Producto where Nombre= @_Producto "
            cms.Parameters.Add("@_producto", SqlDbType.VarChar, 100).Value = _Producto
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Cafeteria_Producto") Is System.DBNull.Value Then
                    _Codigo_Cafeteria_Producto = ""
                Else
                    _Codigo_Cafeteria_Producto = dts.Tables(0).Rows(0).Item("Cod_Cafeteria_Producto")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre") Is System.DBNull.Value Then
                    _Producto = ""
                Else
                    _Producto = dts.Tables(0).Rows(0).Item("Nombre")
                End If
                If dts.Tables(0).Rows(0).Item("Valor_Unitario") Is System.DBNull.Value Then
                    _Valor_Unitario = ""
                Else
                    _Valor_Unitario = dts.Tables(0).Rows(0).Item("Valor_Unitario")
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

    'REGISTRAR PRODUCTOS NUEVOS
    Public Sub RegistroPro()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into  Cafeteria_Producto (Nombre,Valor_Unitario) values (@_Nombre,@_Valor_Unitario) "
            cms.Parameters.Add("@_Nombre", SqlDbType.VarChar, 100).Value = _NombreProNuevo
            cms.Parameters.Add("@_Valor_Unitario", SqlDbType.Int).Value = _ValorUnitProNuevo
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


    'REGISTO DE VENTAS
    Public Sub RegistroVenta()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into  Cafeteria_Venta(Fecha_Venta,Id_Usuario,Codigo,Documento_Cliente,Total) values(@_Fecha_Venta,@_Id_Usuario,@_Codigo,@_Documento_Cliente,@_Total) "
            cms.Parameters.Add("@_Fecha_Venta", SqlDbType.DateTime, 20).Value = _Fecha_Venta
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_Codigo", SqlDbType.VarChar, 20).Value = _Codigo
            cms.Parameters.Add("@_Documento_Cliente", SqlDbType.VarChar, 50).Value = _Documento_Cliente
            cms.Parameters.Add("@_Total", SqlDbType.Int).Value = _Total
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


    'CONSULTA ID
    Public Function ConsultaId() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Cafeteria_Venta where Codigo=@_Codigo and Documento_Cliente=@_Documento_Cliente and Total=@_Total and Fecha_Venta =@_Fecha_Venta "
            cms.Parameters.Add("@_Fecha_Venta", SqlDbType.DateTime, 20).Value = _Fecha_Venta
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_Codigo", SqlDbType.VarChar, 20).Value = _Codigo
            cms.Parameters.Add("@_Documento_Cliente", SqlDbType.VarChar, 50).Value = _Documento_Cliente
            cms.Parameters.Add("@_Total", SqlDbType.Int).Value = _Total
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Cafeteria_Venta") Is System.DBNull.Value Then
                    _Codigo_Cafeteria_Venta = ""
                Else
                    _Codigo_Cafeteria_Venta = dts.Tables(0).Rows(0).Item("Cod_Cafeteria_Venta")
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



    'REGISTRO DETALLE VENTA
    Public Sub RegistroDetalleVenta()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "insert into Cafeteria_Venta_Detalle(Fk_Cod_Cafeteria_Producto,Cantidad,Fk_Cod_Cafeteria_Venta) values (@_Codigo_Cafeteria_Producto,@_Cantidad_Compra,@_Codigo_Cafeteria_Venta)"
            cms.Parameters.Add("@_Codigo_Cafeteria_Producto", SqlDbType.Int).Value = _Codigo_Cafeteria_Producto
            cms.Parameters.Add("@_Cantidad_Compra", SqlDbType.Int).Value = _Cantidad_Compra
            cms.Parameters.Add("@_Codigo_Cafeteria_Venta ", SqlDbType.Int).Value = _Codigo_Cafeteria_Venta
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

    'CONSULTA DE PRODUCTOS
    Public Function ConsultaRegPro() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Cafeteria_Producto  "
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Contador = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    'CONSULTA DESPRENDIBLE MES
    Public Function consultames() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from personal where documento=@_documento or codigo=@_documento "
            cms.Parameters.Add("@_documento", SqlDbType.VarChar, 11).Value = _Documento
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("documento") Is System.DBNull.Value Then
                    _Documento = ""
                Else
                    _Documento = dts.Tables(0).Rows(0).Item("documento")
                End If
                If dts.Tables(0).Rows(0).Item("Codigo") Is System.DBNull.Value Then
                    _Codigo = ""
                Else
                    _Codigo = dts.Tables(0).Rows(0).Item("Codigo")
                End If
                If dts.Tables(0).Rows(0).Item("nombres") Is System.DBNull.Value Then
                    _Nombre = ""
                Else
                    _Nombre = dts.Tables(0).Rows(0).Item("nombres")
                End If
                If dts.Tables(0).Rows(0).Item("apellidos") Is System.DBNull.Value Then
                    _Apellido = ""
                Else
                    _Apellido = dts.Tables(0).Rows(0).Item("apellidos")
                End If
                If dts.Tables(0).Rows(0).Item("cargo") Is System.DBNull.Value Then
                    _Cargo = ""
                Else
                    _Cargo = dts.Tables(0).Rows(0).Item("cargo")
                End If
                If dts.Tables(0).Rows(0).Item("fcing") Is System.DBNull.Value Then
                    _FechaIng = ""
                Else
                    _FechaIng = dts.Tables(0).Rows(0).Item("fcing")
                End If
                If dts.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    _Estado = ""
                Else
                    _Estado = dts.Tables(0).Rows(0).Item("estado")
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

    'CONSULTA TOTAL PRODUCTOS Y TOTAL POR MES
    Protected _Mes As Integer
    Protected _Año As Integer
    Public Property Mes As Integer
        Get
            Return _Mes
        End Get
        Set(value As Integer)
            _Mes = value
        End Set
    End Property
    Public Property Año As Integer
        Get
            Return _Año
        End Get
        Set(value As Integer)
            _Año = value
        End Set
    End Property

    Protected Property Prueba As Integer
        Get
            Return _prueba1
        End Get
        Set(value As Integer)
            _prueba1 = value
        End Set
    End Property

    Public Function ConsultaMesCompra() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select CV.Id_Usuario,CV.Fecha_Venta,CP.Nombre,CVD.Cantidad,CP.Valor_Unitario,(CVD.Cantidad * CP.Valor_Unitario) as Sub_Total from Cafeteria_Venta CV inner join Cafeteria_Venta_Detalle CVD on CV.Cod_Cafeteria_Venta = CVD.Fk_Cod_Cafeteria_Venta inner join Cafeteria_Producto CP on CVD.Fk_Cod_Cafeteria_Producto = CP.Cod_Cafeteria_Producto inner join personal P on CV.Codigo = P.codigo where convert(varchar,MONTH(Fecha_Venta))=@_Mes and  convert(varchar,YEAR(Fecha_Venta))=@_Año and (CV.Codigo=@_Codigo or P.documento=@_Codigo) order by CV.Fecha_Venta asc"
            cms.Parameters.Add("@_Mes", SqlDbType.Int).Value = _Mes
            cms.Parameters.Add("@_Año", SqlDbType.Int).Value = _Año
            cms.Parameters.Add("@_Codigo", SqlDbType.VarChar, 20).Value = _Codigo
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
    'CONSULTA VALOR TOTAL DESPRENDIBLE POR MES
    Public Function ConsultaVltMes() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select SUM(CV.Total) as Total from Cafeteria_Venta CV inner join personal P on CV.Codigo = P.codigo where convert(varchar,MONTH(CV.Fecha_Venta))=@_Mes and  convert(varchar,YEAR(CV.Fecha_Venta))=@_Año and (CV.Codigo=@_Codigo or P.documento=@_Codigo)"
            cms.Parameters.Add("@_Mes", SqlDbType.Int).Value = _Mes
            cms.Parameters.Add("@_Año", SqlDbType.Int).Value = _Año
            cms.Parameters.Add("@_Codigo", SqlDbType.VarChar, 11).Value = _Codigo
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Total") Is System.DBNull.Value Then
                    _Total = Nothing
                Else
                    _Total = dts.Tables(0).Rows(0).Item("Total")
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
End Class
