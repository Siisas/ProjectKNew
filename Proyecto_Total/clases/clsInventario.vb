Imports System.Data.OleDb

Public Class clsInventario
    ''Inventario
    Protected _Cod_Inventario As Integer
    Protected _Fk_Cod_Invent_Dispositivo As Integer
    Protected _FcReg_Invent As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Id_Usuario As String
    Protected _Marca As String
    Protected _Modelo As String
    Protected _Serial As String
    Protected _Empresa As String
    Protected _Fk_ID_Modulo As String
    Protected _Sede As String
    Protected _Estado As String
    Protected _Cod_Agente As String
    Protected _Descripcion As String
    Protected _Dispositivoconsulta As String
    ''Modulo
    Protected _Cod_Invent_Modulo As Integer
    Protected _Letra As String
    Protected _Numero As Integer
    Protected _ID_Modulo As String
    ''Dispositivo
    Protected _Cantidad As Int64
    Protected _Cod_Invent_Dispositivo As Integer
    Protected _Nombre_Dispositivo As String
    Protected _Tipo_Dispositivo As String
    Protected _Observacion As String
    Protected _Letra_Categoria As String
    ''Invetario detalle
    Protected _Cod_Inventario_Detalle As Integer
    Protected _FecReg_InventD As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Fk_Cod_Inventario As Integer
    Protected _Serial_Kamilion As String
    Protected _Todo As String
    Protected _Validacion As String

    '''Inventario Activos Fijo'''
    Public Nombre As String
    Protected Pertenece As String
    Protected clasificacion As String
    Protected Sigla As String
    Protected _Zona As String
    Protected _Nombre_Activo As String
    Protected _Responsable As String
    Protected sub_Responsable As String
    Protected No_Acta_Baja As String
    Protected Observacion_Cambio As String
    Protected _valida As Integer
    Protected _Cantidad1 As Integer
    Protected ruta As String
    Protected Dtactivos As Object
    Protected documento As Integer
    Protected cargo As String
    Protected area As String
    Protected _cod_Acta As String
    Protected strlfc_mto As String
    Dim DteXCEL As New DataTable ''Registro Masivo
    Protected strlMto As String
    Protected strltipo As String
    Protected strlNombreEquipo As String
    Dim fecha As DateTime = Now ''Registro Masivo
    Protected _Fc_ruta As String ''Registro Masivo

    Dim Con_Admin As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
    Protected _Cod_Tipo As Integer
    Public Property Cod_Tipo As Integer
        Get
            Return _Cod_Tipo
        End Get
        Set(ByVal value As Integer)
            _Cod_Tipo = value
        End Set
    End Property
    Protected _Cod_Componente As Integer
    Public Property Cod_Componente As Integer
        Get
            Return _Cod_Componente
        End Get
        Set(ByVal value As Integer)
            _Cod_Componente = value
        End Set
    End Property
    Protected _Cod_Estado As Integer
    Public Property Cod_Estado As Integer
        Get
            Return _Cod_Estado
        End Get
        Set(ByVal value As Integer)
            _Cod_Estado = value
        End Set
    End Property
    Protected _Cod_Fabricante As Integer
    Public Property Cod_Fabricante As Integer
        Get
            Return _Cod_Fabricante
        End Get
        Set(ByVal value As Integer)
            _Cod_Fabricante = value
        End Set
    End Property
    Protected _Referencia As String
    Public Property Referencia As String
        Get
            Return _Referencia
        End Get
        Set(ByVal value As String)
            _Referencia = value
        End Set
    End Property
    Protected _Capacidad As String
    Public Property Capacidad As String
        Get
            Return _Capacidad
        End Get
        Set(ByVal value As String)
            _Capacidad = value
        End Set
    End Property
    Protected _Cod_Equipo As Integer
    Public Property Cod_Equipo As Integer
        Get
            Return _Cod_Equipo
        End Get
        Set(ByVal value As Integer)
            _Cod_Equipo = value
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


    Public Property Mto As String
        Get
            Return strlMto
        End Get
        Set(ByVal value As String)
            strlMto = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return strltipo
        End Get
        Set(ByVal value As String)
            strltipo = value
        End Set
    End Property

    Public Property NombreE As String
        Get
            Return strlNombreEquipo
        End Get
        Set(ByVal value As String)
            strlNombreEquipo = value
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

    Public Property fc_mto As String
        Get
            Return strlfc_mto
        End Get
        Set(ByVal value As String)
            strlfc_mto = value
        End Set
    End Property

    Public Property valida As Integer
        Get
            Return _valida
        End Get
        Set(ByVal value As Integer)
            _valida = value
        End Set
    End Property

    Public Property Cantidad1 As Integer
        Get
            Return _Cantidad1
        End Get
        Set(ByVal value As Integer)
            _Cantidad1 = value
        End Set
    End Property

    Public Property cod_Acta As String
        Get
            Return _cod_Acta
        End Get
        Set(ByVal Value As String)
            _cod_Acta = Value
        End Set
    End Property

    Public Property _area As String
        Get
            Return area
        End Get
        Set(ByVal Value As String)
            area = Value
        End Set
    End Property

    Public Property _cargo As String
        Get
            Return cargo
        End Get
        Set(ByVal Value As String)
            cargo = Value
        End Set
    End Property

    Public Property _documento As String
        Get
            Return documento
        End Get
        Set(ByVal Value As String)
            documento = Value
        End Set
    End Property

    Public Property _Observacion_Cambio As String
        Get
            Return Observacion_Cambio
        End Get
        Set(ByVal Value As String)
            Observacion_Cambio = Value
        End Set
    End Property

    Public Property _Nombre As String
        Get
            Return Nombre
        End Get
        Set(ByVal Value As String)
            Nombre = Value
        End Set
    End Property

    Public Property _Pertenece As String
        Get
            Return Pertenece
        End Get
        Set(ByVal Value As String)
            Pertenece = Value
        End Set
    End Property

    Public Property _Sigla As String
        Get
            Return Sigla
        End Get
        Set(ByVal Value As String)
            Sigla = Value
        End Set
    End Property

    Public Property Zona As String
        Get
            Return _Zona
        End Get
        Set(ByVal Value As String)
            _Zona = Value
        End Set
    End Property

    Public Property Responsable As String
        Get
            Return _Responsable
        End Get
        Set(ByVal Value As String)
            _Responsable = Value
        End Set
    End Property

    Public Property Nombre_Activo As String
        Get
            Return _Nombre_Activo
        End Get
        Set(ByVal Value As String)
            _Nombre_Activo = Value
        End Set
    End Property

    Public Property _clasificacion As String
        Get
            Return clasificacion
        End Get
        Set(ByVal Value As String)
            clasificacion = Value
        End Set
    End Property

    Public Property subResponsable As String
        Get
            Return sub_Responsable
        End Get
        Set(ByVal Value As String)
            sub_Responsable = Value
        End Set
    End Property

    Public Property No_Acta As String
        Get
            Return No_Acta_Baja
        End Get
        Set(ByVal Value As String)
            No_Acta_Baja = Value
        End Set
    End Property

    Public Property _Ruta_Excel As String
        Get
            Return ruta
        End Get
        Set(ByVal Value As String)
            ruta = Value
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
    Public Property Cod_Agente As String
        Get
            Return _Cod_Agente
        End Get
        Set(ByVal value As String)
            _Cod_Agente = value
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property Dispositivoconsulta As String
        Get
            Return _Dispositivoconsulta
        End Get
        Set(ByVal value As String)
            _Dispositivoconsulta = value
        End Set
    End Property
    Public Property Todo As String
        Get
            Return _Todo
        End Get
        Set(ByVal value As String)
            _Todo = value
        End Set
    End Property
    Public Property Serial_Kamilion As String
        Get
            Return _Serial_Kamilion
        End Get
        Set(ByVal value As String)
            _Serial_Kamilion = value
        End Set
    End Property
    Public Property Fk_Cod_Inventario As Integer
        Get
            Return _Fk_Cod_Inventario
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Inventario = value
        End Set
    End Property
    Public Property FecReg_InvenD As String
        Get
            Return _FecReg_InventD
        End Get
        Set(ByVal value As String)
            _FecReg_InventD = value
        End Set
    End Property
    Public Property Cod_Inventario_Detalle As Integer
        Get
            Return _Cod_Inventario_Detalle
        End Get
        Set(ByVal value As Integer)
            _Cod_Inventario_Detalle = value
        End Set
    End Property
    Public Property Letra_Categoria As String
        Get
            Return _Letra_Categoria
        End Get
        Set(ByVal value As String)
            _Letra_Categoria = value
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
    Public Property Tipo_Dispositivo As String
        Get
            Return _Tipo_Dispositivo
        End Get
        Set(ByVal value As String)
            _Tipo_Dispositivo = value
        End Set
    End Property
    Public Property Nombre_Dispositivo As String
        Get
            Return _Nombre_Dispositivo
        End Get
        Set(ByVal value As String)
            _Nombre_Dispositivo = value
        End Set
    End Property
    Public Property Cod_Invent_Dispositivo As Integer
        Get
            Return _Cod_Invent_Dispositivo
        End Get
        Set(ByVal value As Integer)
            _Cod_Invent_Dispositivo = value
        End Set
    End Property
    Public Property Cantidad As Int64
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Int64)
            _Cantidad = value
        End Set
    End Property
    Public Property ID_Modulo As String
        Get
            Return _ID_Modulo
        End Get
        Set(ByVal value As String)
            _ID_Modulo = value
        End Set
    End Property
    Public Property Numero As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
        End Set
    End Property
    Public Property Letra As String
        Get
            Return _Letra
        End Get
        Set(ByVal value As String)
            _Letra = value
        End Set
    End Property
    Public Property Cod_Invent_Modulo As Integer
        Get
            Return _Cod_Invent_Modulo
        End Get
        Set(ByVal value As Integer)
            _Cod_Invent_Modulo = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property
    Public Property Sede As String
        Get
            Return _Sede
        End Get
        Set(ByVal value As String)
            _Sede = value
        End Set
    End Property
    Public Property Fk_ID_Modulo As String
        Get
            Return _Fk_ID_Modulo
        End Get
        Set(ByVal value As String)
            _Fk_ID_Modulo = value
        End Set
    End Property
    Public Property Empresa As String
        Get
            Return _Empresa
        End Get
        Set(ByVal value As String)
            _Empresa = value
        End Set
    End Property

    Public Property Serial As String
        Get
            Return _Serial
        End Get
        Set(ByVal value As String)
            _Serial = value
        End Set
    End Property
    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set(ByVal value As String)
            _Modelo = value
        End Set
    End Property
    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(ByVal value As String)
            _Marca = value
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
    Public Property FcReg_Invent As String
        Get
            Return _FcReg_Invent
        End Get
        Set(ByVal value As String)
            _FcReg_Invent = value
        End Set
    End Property
    Public Property FK_Cod_Invent_Dispositivo As Integer
        Get
            Return _Fk_Cod_Invent_Dispositivo
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Invent_Dispositivo = value
        End Set
    End Property
    Public Property Cod_Inventario As Integer
        Get
            Return _Cod_Inventario
        End Get
        Set(ByVal value As Integer)
            _Cod_Inventario = value
        End Set
    End Property

    Public Sub Ingresar_Modulo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Invent_Modulo values(@_Letra,@_Numero,@_ID_Modulo,@_Estado,@_Adquisicion)"
            cms.Parameters.Add("@_Letra", SqlDbType.VarChar, 3).Value = _Letra
            cms.Parameters.Add("@_Numero", SqlDbType.Int).Value = _Numero
            cms.Parameters.Add("@_ID_Modulo", SqlDbType.VarChar, 50).Value = _ID_Modulo
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Adquisicion", SqlDbType.VarChar, 50).Value = _FcReg_Invent
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

    Public Function Validacion_Modulo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Invent_Modulo where ID_Modulo=@_ID_Modulo"
            cms.Parameters.Add("@_ID_Modulo", SqlDbType.VarChar, 50).Value = _ID_Modulo
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Letra") Is DBNull.Value Then
                    _ID_Modulo = Nothing
                Else
                    _ID_Modulo = dts.Tables(0).Rows(0).Item("Letra")
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


    Public Sub Ingresar_Inventario()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Inventario (FcReg_Invent,Id_Usuario,Fk_Cod_Invent_Dispositivo,Marca,Modelo,Serial,Serial_Kamilion,Empresa,Fk_ID_Modulo,Estado)values(@_FcReg_Invent,@_Id_Usuario,@_FK_Cod_Invent_Dispositivo,@_Marca,@_Modelo,@_Serial,@_Serial_Kamilion,@_Empresa,@_Fk_ID_Modulo,@_Estado)"
            cms.Parameters.Add("@_FcReg_Invent", SqlDbType.VarChar, 50).Value = _FcReg_Invent
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
            cms.Parameters.Add("@_Fk_ID_Modulo", SqlDbType.VarChar, 50).Value = _Fk_ID_Modulo
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
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
    Public Function Validacion_Modulo_Un_Registro()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario where Fk_ID_Modulo=@_ID_Modulo and Fk_Cod_Invent_Dispositivo=@_Fk_Cod_Invent_Dispositivo"
            cms.Parameters.Add("@_ID_Modulo", SqlDbType.VarChar, 50).Value = _ID_Modulo
            cms.Parameters.Add("@_Fk_Cod_Invent_Dispositivo", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
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
    Public Function Validacion_Modulo_Un_Registro_Asigancion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario I inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo= ID.Cod_Invent_Dispositivo where Fk_ID_Modulo=@_ID_Modulo and Nombre_Dispositivo=@_Nombre_Dispositivo"
            cms.Parameters.Add("@_ID_Modulo", SqlDbType.VarChar, 50).Value = _ID_Modulo
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
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
    Public Function Consulta_Modulos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select * from Invent_modulo order by Estado,ID_Modulo"
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

    Public Function Consulta_Moduloslib() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select Nombre_Dispositivo,Cod_Invent_Dispositivo from Invent_Dispositivo where Letra_Categoria='Soporte' or  Nombre_Dispositivo='diademas' group by Nombre_Dispositivo,Cod_Invent_Dispositivo order by Nombre_Dispositivo,Cod_Invent_Dispositivo"
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
    Public Function Consulta_Dispositivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Invent_Dispositivo where Letra_Categoria = 'Soporte' order by Nombre_Dispositivo"
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


    Public Function Consulta_Inventario_Filtros()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Empresa <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Fk_ID_Modulo,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,i.Fc_Adquisicion from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Empresa like '%" + _Empresa + "%' ORDER BY I.Fk_ID_Modulo"
                cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
            End If
            If _Serial_Kamilion <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Fk_ID_Modulo,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,i.Fc_Adquisicion from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Serial_Kamilion like '%" + _Serial_Kamilion + "%' ORDER BY I.Fk_ID_Modulo"
                cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
            End If
            If _Serial <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Fk_ID_Modulo,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,i.Fc_Adquisicion from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Serial like '%" + _Serial + "%' ORDER BY I.Fk_ID_Modulo"
                cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
            End If
            If _Modelo <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Fk_ID_Modulo,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,i.Fc_Adquisicion from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Modelo like '%" + _Modelo + "%' ORDER BY I.Fk_ID_Modulo"
                cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            End If
            If _Marca <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Fk_ID_Modulo,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,i.Fc_Adquisicion from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Marca like '%" + _Marca + "%' ORDER BY I.Fk_ID_Modulo"
                cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
            End If
            If _ID_Modulo <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Fk_ID_Modulo,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,i.Fc_Adquisicion from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Fk_ID_Modulo=@_ID_Modulo"
                cms.Parameters.Add("@_ID_Modulo", SqlDbType.VarChar, 50).Value = _ID_Modulo
            End If
            If _Fc_ruta <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Fk_ID_Modulo,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Fc_Adquisicion from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where  I.Fc_Adquisicion = @_FcAdquisicion ORDER BY I.Fk_ID_Modulo"
                cms.Parameters.Add("@_FcAdquisicion", SqlDbType.VarChar, 50).Value = _Fc_ruta
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''' Cambios ''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Consulta_Liberar_Dispositivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select FK_ID_Modulo from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where FK_ID_Modulo<>'' and  ID.Letra_Categoria='Soporte' and FK_Cod_Invent_Dispositivo = @_Cod_Invent_Dispositivo  group by FK_ID_Modulo union select nombre_dispositivo from Invent_Dispositivo where  nombre_dispositivo='- Seleccione -'"
            cms.Parameters.Add("@_Cod_Invent_Dispositivo", SqlDbType.BigInt).Value = _Cod_Invent_Dispositivo
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
    Public Function Consulta_Liberar() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Empresa from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Empresa<>'' and  FK_Cod_Invent_Dispositivo=@_FK_Cod_Invent_Dispositivo and Fk_ID_Modulo=@_Fk_ID_Modulo union select nombre_dispositivo from  Invent_Dispositivo where  nombre_dispositivo='- Seleccione -' "
            cms.Parameters.Add("@_Fk_ID_Modulo", SqlDbType.VarChar, 50).Value = _Fk_ID_Modulo
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
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
    Public Function Consulta_Liberar2() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select nombre_dispositivo as 'marca',nombre_dispositivo as 'serial',nombre_dispositivo as'serial_kamilion' from  Invent_Dispositivo f where  nombre_dispositivo='- Seleccione -' union select marca,Serial,Serial_Kamilion from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Empresa=@_Empresa and FK_Cod_Invent_Dispositivo=@_FK_Cod_Invent_Dispositivo and Fk_ID_Modulo=@_Fk_ID_Modulo order by marca"
            cms.Parameters.Add("@_Fk_ID_Modulo", SqlDbType.VarChar, 50).Value = _Fk_ID_Modulo
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
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
  
    Public Function Asignar_Dispositivo() As Boolean
        Dim Con = Con_Admin
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_ID_Modulo", _ID_Modulo)
            Scm.Parameters.AddWithValue("@_Cod_Inventario", _Cod_Inventario)
            Scm.Parameters.AddWithValue("@_Estado", _Estado.Trim)
            Scm.CommandText = " update Inventario set Fk_ID_Modulo = @_ID_Modulo, Estado = @_Estado where Cod_Inventario = @_Cod_Inventario;"
            Scm.ExecuteNonQuery()
            If Scm.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function


    Public Sub Registro_Liberacion_Dispositivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Invent_Detalle (FecReg_InventD,Id_Usuario,Observacion,Fk_Cod_Inventario,Fk_ID_Modulo,Estado)values(@_FecReg_InventD,@_Id_Usuario,@_Observacion,@_Fk_Cod_Inventario,@_Fk_ID_Modulo,@_Estado)"
            cms.Parameters.Add("@_FecReg_InventD", SqlDbType.VarChar, 50).Value = _FecReg_InventD
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 750).Value = _Observacion
            cms.Parameters.Add("@_Fk_Cod_Inventario", SqlDbType.BigInt).Value = _Fk_Cod_Inventario
            cms.Parameters.Add("@_Fk_ID_Modulo", SqlDbType.VarChar, 50).Value = _Fk_ID_Modulo
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
    Public Function Consulta_Asignar_Dispositivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select ID.Nombre_Dispositivo from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Fk_ID_Modulo='BODEGA' and Estado <> 'Baja' and Estado <> 'Entregado' or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Soporte') group by ID.Nombre_Dispositivo order by ID.Nombre_Dispositivo"
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
    Public Function Consulta_Filtro_Marca_Asignar_Dispositivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select I.Marca from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Fk_ID_Modulo='BODEGA' and Estado <> 'Baja' and Estado <> 'Entregado' and Fk_Cod_Invent_Dispositivo=@_Cod_Invent_Dispositivo  group by I.Marca union select nombre_dispositivo from  Invent_Dispositivo where  nombre_dispositivo='- Seleccione -'"
            cms.Parameters.Add("@_Cod_Invent_Dispositivo", SqlDbType.VarChar, 80).Value = _Cod_Invent_Dispositivo
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
    Public Function Consulta_Filtro_Modelo_Asignar_Dispositivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select I.Modelo from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Fk_ID_Modulo='BODEGA' and Estado <> 'Baja' and Estado <> 'Entregado' and Marca=@_Marca and Fk_Cod_Invent_Dispositivo = @_Cod_Invent_Dispositivo  group by I.Modelo union select nombre_dispositivo from  Invent_Dispositivo where  nombre_dispositivo='- Seleccione -'"
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
            cms.Parameters.Add("@_Cod_Invent_Dispositivo", SqlDbType.BigInt).Value = _Cod_Invent_Dispositivo
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
    Public Function Consulta_Filtro_Serial_Asignar_Dispositivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Empresa from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Fk_ID_Modulo='BODEGA' and Estado <> 'Baja' and Estado <> 'Entregado' and Modelo=@_Modelo  or Empresa='- Seleccione -' Group by Empresa"
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
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
    Public Function Consulta_Filtro_Serial() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select convert(bigint,'') as 'Cod_Inventario',nombre_dispositivo as 'marca',nombre_dispositivo as 'serial',nombre_dispositivo as 'serial_kamilion' from  Invent_Dispositivo where  nombre_dispositivo='- Seleccione -' union select Cod_Inventario,marca,serial,serial_kamilion from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Fk_ID_Modulo='BODEGA' and Estado <> 'Baja' and Estado <> 'Entregado' and Modelo=@_Modelo and Empresa=@_Empresa order by marca "
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
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
    Public Function Consulta_Inventario_Registros()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
       Try
            cn.Open()
            Dim strlConsulta As String = Nothing
            If _Cod_Inventario <> Nothing Then
                cms.Parameters.Add("@_Cod_Inventario", SqlDbType.VarChar, 50).Value = _Cod_Inventario
                strlConsulta = strlConsulta & " and n3.Cod_Inventario=@_Cod_Inventario "
            Else
                If _Estado <> Nothing Then
                    cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
                    strlConsulta = strlConsulta & " and n3.estado=@_Estado "
                End If

                If _ID_Modulo <> Nothing Then
                    strlConsulta = strlConsulta & " and n3.Fk_ID_Modulo=@_ID_Modulo "
                    cms.Parameters.Add("@_ID_Modulo", SqlDbType.VarChar, 50).Value = _ID_Modulo
                End If
                If _Dispositivoconsulta <> Nothing Then
                    strlConsulta = strlConsulta & " and n4.Cod_Invent_Dispositivo=@_Cod_Dispositivo "
                    cms.Parameters.Add("@_Cod_Dispositivo", SqlDbType.BigInt).Value = _Cod_Invent_Dispositivo
                End If
            End If

            cms.CommandText = "SELECT n1.FecReg_InventD,n4.Nombre_Dispositivo as Dispositivo,n3.Marca,n3.Modelo,n3.Serial,n3.Serial_Kamilion,n3.Empresa,n3.Fk_ID_Modulo,n3.Sede,n3.Estado,n3.Id_Usuario,n3.FcReg_Invent,n3.Cod_Inventario,N1.Cod_Inventario_Detalle,isnull(convert(varchar(max),n1.Observacion),'Sin Observación') as Observacion FROM (SELECT Cod_Inventario_Detalle,Observacion,Fk_Cod_Inventario,FecReg_InventD  FROM Invent_Detalle) as N1 INNER JOIN (SELECT MAX(Cod_Inventario_Detalle) AS Cod_Inventario_Detalle FROM Invent_Detalle GROUP BY Fk_Cod_Inventario) as N2 ON N1.Cod_Inventario_Detalle=N2.Cod_Inventario_Detalle right join (select * from Inventario) as n3 on n1.Fk_Cod_Inventario=n3.Cod_Inventario inner join (select * from Invent_Dispositivo) as n4 on n3.Fk_Cod_Invent_Dispositivo = n4.Cod_Invent_Dispositivo WHERE 1=1 " & strlConsulta
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
    Public Function Consulta_Inventario_Registros_Detalle()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Cod_Inventario <> Nothing Then
                cms.CommandText = "select * from Invent_Detalle where Fk_Cod_Inventario=@_Cod_Inventario"
                cms.Parameters.Add("@_Cod_Inventario", SqlDbType.VarChar, 50).Value = _Cod_Inventario
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Estado_Libera() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Invent_Dispositivo where Letra_Categoria = 'Estado' order by Nombre_Dispositivo"
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
    
  
    Public Function Consulta_Filtro_Marca_Estado_Dispositivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select I.Marca from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Fk_ID_Modulo=@_Fk_ID_Modulo and Estado <> 'Baja' and Estado <> 'Entregado' and Fk_Cod_Invent_Dispositivo=@_Cod_Invent_Dispositivo  group by I.Marca union  select nombre_dispositivo from Invent_Dispositivo where  nombre_dispositivo='- Seleccione -'"
            cms.Parameters.Add("@_Fk_ID_Modulo", SqlDbType.VarChar, 50).Value = _Fk_ID_Modulo
            cms.Parameters.Add("@_Cod_Invent_Dispositivo", SqlDbType.BigInt).Value = _Cod_Invent_Dispositivo
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
    Public Function Consulta_Filtro_Modelo_Estado_Dispositivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select I.Modelo from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where  I.Fk_Cod_Invent_Dispositivo=@_Dispositivo and Fk_ID_Modulo=@_Fk_ID_Modulo and Estado <> 'Baja' and Estado <> 'Entregado' and Marca=@_Marca  group by I.Modelo union  select nombre_dispositivo from  Invent_Dispositivo where  nombre_dispositivo='- Seleccione -'"
            cms.Parameters.Add("@_Fk_ID_Modulo", SqlDbType.VarChar, 50).Value = _Fk_ID_Modulo
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
            cms.Parameters.Add("@_Dispositivo", SqlDbType.VarChar, 50).Value = _Cod_Invent_Dispositivo
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
    Public Function Consulta_Filtro_Serial_Estado_Dispositivos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select empresa,serial,serial_kamilion from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where  I.Fk_Cod_Invent_Dispositivo=@_Dispositivo and  Fk_ID_Modulo=@_Fk_ID_Modulo and Estado <> 'Baja' and Estado <> 'Entregado' and Modelo=@_Modelo group by empresa,serial,serial_kamilion union  select nombre_dispositivo, nombre_dispositivo,nombre_dispositivo from  Invent_Dispositivo where  nombre_dispositivo='- Seleccione -'"
            If _Validacion = 1 Then
                cms.CommandText = "select empresa from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where  I.Fk_Cod_Invent_Dispositivo=@_Dispositivo and  Fk_ID_Modulo=@_Fk_ID_Modulo and Estado <> 'Baja' and Estado <> 'Entregado' and Modelo=@_Modelo   group by empresa union  select nombre_dispositivo from  Invent_Dispositivo where  nombre_dispositivo='- Seleccione -'"
            End If
            cms.Parameters.Add("@_Fk_ID_Modulo", SqlDbType.VarChar, 50).Value = _Fk_ID_Modulo
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_dispositivo", SqlDbType.VarChar, 50).Value = _Cod_Invent_Dispositivo
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
    Public Function Consulta_Validacion_Serial_Kamilion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario where Serial_Kamilion = @_Serial_Kamilion"
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
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
    Public Function Consulta_Validacion_Serial() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario where Serial = @_Serial"
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
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
    Public Function Consulta_Modul() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select ID_Modulo from Invent_Modulo group by ID_Modulo order by ID_Modulo"
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
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''' INVENTARIO ACTIVO '''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Validacion_ModuloActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario where Sede=@_Sede"
            cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 50).Value = _Sede
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
    Public Sub Ingresar_InventarioActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Inventario (FcReg_Invent,Id_Usuario,Fk_Cod_Invent_Dispositivo,Marca,Modelo,Descripcion,Serial,Serial_Kamilion,Empresa,Sede,Estado)values(@_FcReg_Invent,@_Id_Usuario,@_FK_Cod_Invent_Dispositivo,@_Marca,@_Modelo,@_Descripcion,@_Serial,@_Serial_Kamilion,@_Empresa,@_Sede,@_Estado)"
            cms.Parameters.Add("@_FcReg_Invent", SqlDbType.VarChar, 50).Value = _FcReg_Invent
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_Descripcion", SqlDbType.VarChar, 100).Value = _Descripcion
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
            cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 50).Value = _Sede
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
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
    Public Sub Ingresar_Inventario2Activo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Inventario (FcReg_Invent,Id_Usuario,Fk_Cod_Invent_Dispositivo,Marca,Modelo,Descripcion,Serial,Serial_Kamilion,Empresa,Estado,Cod_Agente)values(@_FcReg_Invent,@_Id_Usuario,@_FK_Cod_Invent_Dispositivo,@_Marca,@_Modelo,@_Descripcion,@_Serial,@_Serial_Kamilion,@_Empresa,@_Estado,@_Cod_Agente)"
            cms.Parameters.Add("@_FcReg_Invent", SqlDbType.VarChar, 50).Value = _FcReg_Invent
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_Descripcion", SqlDbType.VarChar, 100).Value = _Descripcion
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
            cms.Parameters.Add("@_Cod_Agente", SqlDbType.VarChar, 50).Value = _Cod_Agente
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
    Public Sub Ingresar_Inventario3Activo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Inventario (FcReg_Invent,Id_Usuario,Fk_Cod_Invent_Dispositivo,Marca,Modelo,Descripcion,Serial,Serial_Kamilion,Empresa,Estado,Sede)values(@_FcReg_Invent,@_Id_Usuario,@_FK_Cod_Invent_Dispositivo,@_Marca,@_Modelo,@_Descripcion,@_Serial,@_Serial_Kamilion,@_Empresa,@_Estado,@_Sede)"
            cms.Parameters.Add("@_FcReg_Invent", SqlDbType.VarChar, 50).Value = _FcReg_Invent
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_Descripcion", SqlDbType.VarChar, 100).Value = _Descripcion
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
            cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 50).Value = _Sede
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
    Public Function Validacion_Doble_Un_RegistroActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Serial_Kamilion,Serial from Inventario where Serial_Kamilion=@_Serial_Kamilion and Serial=@_Serial"
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
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
    Public Function Validacion_Modulo_Un_RegistroActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Serial_Kamilion from Inventario where Serial_Kamilion=@_Serial_Kamilion"
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
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
    Public Function Validacion_Serial_Un_RegistroActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Serial from Inventario where Serial=@_Serial"
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
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
    Public Function Validacion_Modulo_Un_Registro2Activo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Serial from Inventario where Serial=@_Serial"
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
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
    Public Function Cambio_Nombre_CodigoActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Cod_Invent_Dispositivo from Invent_Dispositivo where Nombre_Dispositivo=@_Nombre_Dispositivo"
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cod_Invent_Dispositivo = dts.Tables(0).Rows.Count
            If _Cod_Invent_Dispositivo > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Invent_Dispositivo") Is DBNull.Value Then
                    _Cod_Invent_Dispositivo = Nothing
                Else
                    _Cod_Invent_Dispositivo = dts.Tables(0).Rows(0).Item("Cod_Invent_Dispositivo")
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
    Public Function Validacion_Agente_Un_RegistroActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario I inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo= ID.Cod_Invent_Dispositivo where Cod_Agente=@_Cod_Agente and Nombre_Dispositivo=@_Nombre_Dispositivo"
            cms.Parameters.Add("@_Cod_Agente", SqlDbType.VarChar, 50).Value = _Cod_Agente
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
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
    Public Function Validacion_Modulo_Un_Registro_AsigancionActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario I inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo= ID.Cod_Invent_Dispositivo where I.Sede=@_Sede and Serial_Kamilion=@_Serial_Kamilion and Letra_Categoria='Activo'"
            cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 50).Value = _Sede
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
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
    Public Function Validacion_Modulo_Un_Registro_Asigancion1Activo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario I inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo= ID.Cod_Invent_Dispositivo where I.Sede=@_Sede and Serial=@_Serial and Letra_Categoria='Activo'"
            cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 50).Value = _Sede
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
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
    Public Function Validacion_Agente_Un_Registro_AsigancionActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario I inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo= ID.Cod_Invent_Dispositivo where I.Cod_Agente=@_Cod_Agente and I.FK_Cod_Invent_Dispositivo =@_FK_Cod_Invent_Dispositivo  and Letra_Categoria='Activo'"
            cms.Parameters.Add("@_Cod_Agente", SqlDbType.VarChar, 50).Value = _Cod_Agente
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo ", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
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
    Public Function Consulta_ModulosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select * from Inventario order by Sede"
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
    Public Function Consulta_MarcaActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select Marca from Inventario I right join Invent_Dispositivo D on I.Fk_Cod_Invent_Dispositivo=D.Cod_Invent_Dispositivo where D.Letra_Categoria = 'Activo' GROUP BY Marca order by Marca"
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
    Public Function Consulta_AgentesActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select * from usuarios ORDER BY nombreu"
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
    Public Function Consulta_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Nombre_Dispositivo from Inventario I right join Invent_Dispositivo D on I.Fk_Cod_Invent_Dispositivo=D.Cod_Invent_Dispositivo where Letra_Categoria = 'Activo' group by Nombre_Dispositivo order by Nombre_Dispositivo"
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

    Public Function Consulta_Inventario_FiltrosActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Nombre_Dispositivo <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where ID.Nombre_Dispositivo=@_Nombre_Dispositivo  and ID.Letra_Categoria = 'Activo' ORDER BY I.Sede"
                cms.Parameters.Add("@_Nombre_Dispositivo ", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
            End If
            If _Empresa <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Empresa like '%" + _Empresa + "%' and ID.Letra_Categoria = 'Activo' ORDER BY I.Sede"
                cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
            End If
            If _Dispositivoconsulta <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where ID.Cod_Invent_Dispositivo = @_Dispositivoconsulta and ID.Letra_Categoria = 'Activo'"
                cms.Parameters.Add("@_Dispositivoconsulta", SqlDbType.VarChar, 50).Value = _Dispositivoconsulta
            End If
            If _Serial_Kamilion <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Serial_Kamilion like '%" + _Serial_Kamilion + "%' and ID.Letra_Categoria = 'Activo' ORDER BY I.Sede"
                cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
            End If
            If _Serial <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Serial like '%" + _Serial + "%' and ID.Letra_Categoria = 'Activo' ORDER BY I.Sede"
                cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
            End If
            If _Modelo <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Modelo like '%" + _Modelo + "%' and ID.Letra_Categoria = 'Activo' ORDER BY I.Sede"
                cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            End If
            If _Marca <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Marca like '%" + _Marca + "%' and ID.Letra_Categoria = 'Activo' ORDER BY I.Sede"
                cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
            End If
            If _Sede <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Sede=@_Sede and ID.Letra_Categoria = 'Activo'"
                cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 50).Value = _Sede
            End If
            If _Todo <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.FcReg_Invent is not null and ID.Letra_Categoria = 'Activo' ORDER BY Cod_Inventario"
                cms.Parameters.Add("", SqlDbType.VarChar, 50).Value = _Todo
            End If
            If _Cod_Agente <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Descripcion,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Cod_Agente from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Cod_Agente=@_Cod_Agente and ID.Letra_Categoria = 'Activo' ORDER BY I.Cod_Agente"
                cms.Parameters.Add("@_Cod_Agente ", SqlDbType.VarChar, 50).Value = _Cod_Agente
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''' CAMBIOS ACTIVOS ''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Consulta_Liberar_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Serial_Kamilion from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where (I.Cod_Agente=@_Cod_Agente or I.Sede=@_Sede) and I.Empresa=@_Empresa and ID.Nombre_Dispositivo=@_Nombre_Dispositivo or (ID.Nombre_Dispositivo like '- Seleccione -%' and ID.Letra_Categoria='Activo') group by Serial_Kamilion order by Serial_Kamilion"
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
            cms.Parameters.Add("@_Cod_Agente", SqlDbType.VarChar, 50).Value = _Cod_Agente
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
            cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 50).Value = _Sede
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
    Public Function Consulta_Liberar_Dispositivos1Activo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Serial from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where (I.Cod_Agente=@_Cod_Agente or I.Sede=@_Sede) and I.Empresa=@_Empresa and ID.Nombre_Dispositivo=@_Nombre_Dispositivo or (ID.Nombre_Dispositivo like '- Seleccione -%' and ID.Letra_Categoria='Activo') group by Serial  order by Serial"
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
            cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 50).Value = _Sede
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
            cms.Parameters.Add("@_Cod_Agente", SqlDbType.VarChar, 50).Value = _Cod_Agente
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
    Public Function Consulta_Liberar_AgenteActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Cod_Agente from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Nombre_Dispositivo=@_Nombre_Dispositivo or (ID.Nombre_Dispositivo like '- Seleccione -%' and ID.Letra_Categoria='Activo') group by Cod_Agente  order by Cod_Agente"
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
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
    Public Function Consulta_LiberarActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Cod_Inventario from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Nombre_Dispositivo=@_Nombre_Dispositivo or (ID.Nombre_Dispositivo like '- Seleccione -%' and ID.Letra_Categoria='Activo') group by Cod_Inventario  order by Cod_Inventario"
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
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
    Public Function Consulta_Liberar_ModuloActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Sede from Inventario I Full join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Nombre_Dispositivo=@_Nombre_Dispositivo or (ID.Nombre_Dispositivo like '- Seleccione -%' and ID.Letra_Categoria='Activo')  group by Sede order by Sede"
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
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
    Public Function Consulta_Liberar_EmpresaActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Empresa from Inventario I Full join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Nombre_Dispositivo=@_Nombre_Dispositivo or (ID.Nombre_Dispositivo like '- Seleccione -%' and ID.Letra_Categoria='Activo')  group by Empresa order by Empresa"
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
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
    Public Function Consulta_Liberar_SerialActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Serial_Kamilion from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Cod_Agente=@_Cod_Agente and Nombre_Dispositivo=@_Nombre_Dispositivo or (ID.Nombre_Dispositivo like '- Seleccione -%' and ID.Letra_Categoria='Activo')  order by Serial_Kamilion"
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
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
    Public Sub Liberar_DispositivoActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "update Inventario set Sede='BOD',Estado=@_Estado,Cod_Agente = Null where Serial_Kamilion=@_Serial_Kamilion "
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
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
    Public Sub Liberar_Dispositivo1Activo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "update Inventario set Sede='BOD',Estado=@_Estado,Cod_Agente = Null where Serial=@_Serial "
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
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
    Public Sub Asignar_DispositivoActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "update Inventario set Sede=@_Sede,Estado=@_Estado,Cod_Agente='' from Inventario I Inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo   where FK_Cod_Invent_Dispositivo=@_FK_Cod_Invent_Dispositivo and Serial_Kamilion=@_Serial_Kamilion"
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
            cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 50).Value = _Sede
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
    Public Sub Asignar_Dispositivo2Activo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "update Inventario set Cod_Agente=@_Cod_Agente,Estado=@_Estado,Sede='' from Inventario I Inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo  where FK_Cod_Invent_Dispositivo=@_FK_Cod_Invent_Dispositivo and Serial_Kamilion=@_Serial_Kamilion"
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
            cms.Parameters.Add("@_Cod_Agente", SqlDbType.VarChar, 50).Value = _Cod_Agente
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
    Public Sub Registro_Liberacion_DispositivoActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Sede <> Nothing And _Cod_Agente <> Nothing Then
                cms.CommandText = "Insert into Invent_Detalle (FecReg_InventD,Id_Usuario,Observacion,Fk_Cod_Inventario,Sede,Estado,Cod_Agente)values(@_FecReg_InventD,@_Id_Usuario,@_Observacion,@_Fk_Cod_Inventario,@_Sede,@_Estado,@_Cod_Agente)"
                cms.Parameters.Add("@_FecReg_InventD", SqlDbType.VarChar, 50).Value = _FecReg_InventD
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
                cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 750).Value = _Observacion
                cms.Parameters.Add("@_Fk_Cod_Inventario", SqlDbType.BigInt).Value = _Fk_Cod_Inventario
                cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 10).Value = _Sede
                cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
                cms.Parameters.Add("@_Cod_Agente", SqlDbType.VarChar, 50).Value = _Cod_Agente
                cms.Connection = cn
            Else
                If _Sede <> Nothing Then
                    cms.CommandText = "Insert into Invent_Detalle (FecReg_InventD,Id_Usuario,Observacion,Fk_Cod_Inventario,Sede,Estado)values(@_FecReg_InventD,@_Id_Usuario,@_Observacion,@_Fk_Cod_Inventario,@_Sede,@_Estado)"
                    cms.Parameters.Add("@_FecReg_InventD", SqlDbType.VarChar, 50).Value = _FecReg_InventD
                    cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
                    cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 750).Value = _Observacion
                    cms.Parameters.Add("@_Fk_Cod_Inventario", SqlDbType.BigInt).Value = _Fk_Cod_Inventario
                    cms.Parameters.Add("@_Sede", SqlDbType.VarChar, 10).Value = _Sede
                    cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
                    cms.Connection = cn
                End If
                If _Cod_Agente <> Nothing Then
                    cms.CommandText = "Insert into Invent_Detalle (FecReg_InventD,Id_Usuario,Observacion,Fk_Cod_Inventario,Estado,Cod_Agente)values(@_FecReg_InventD,@_Id_Usuario,@_Observacion,@_Fk_Cod_Inventario,@_Estado,@_Cod_Agente)"
                    cms.Parameters.Add("@_FecReg_InventD", SqlDbType.VarChar, 50).Value = _FecReg_InventD
                    cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
                    cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 750).Value = _Observacion
                    cms.Parameters.Add("@_Fk_Cod_Inventario", SqlDbType.BigInt).Value = _Fk_Cod_Inventario
                    cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
                    cms.Parameters.Add("@_Cod_Agente", SqlDbType.VarChar, 50).Value = _Cod_Agente
                    cms.Connection = cn
                End If
                If _Sede = Nothing And _Cod_Agente = Nothing Then
                    cms.CommandText = "Insert into Invent_Detalle (FecReg_InventD,Id_Usuario,Observacion,Fk_Cod_Inventario,Estado)values(@_FecReg_InventD,@_Id_Usuario,@_Observacion,@_Fk_Cod_Inventario,@_Estado)"
                    cms.Parameters.Add("@_FecReg_InventD", SqlDbType.VarChar, 50).Value = _FecReg_InventD
                    cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
                    cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 750).Value = _Observacion
                    cms.Parameters.Add("@_Fk_Cod_Inventario", SqlDbType.BigInt).Value = _Fk_Cod_Inventario
                    cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
                    cms.Connection = cn
                End If
            End If
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Function Consulta_Asignar_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Fk_Cod_Invent_Dispositivo,Nombre_Dispositivo from Inventario I inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo Where Sede='BOD' or Nombre_Dispositivo='- Seleccione -' and Estado = 'Activo' and Letra_Categoria='Activo' group by I.Fk_Cod_Invent_Dispositivo,ID.Nombre_Dispositivo order by ID.Nombre_Dispositivo"
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
    Public Function Consulta_Asignar_DisposActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select I.Cod_Inventario from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Nombre_Dispositivo=@_Nombre_Dispositivo and Estado <> 'Baja' and Estado <> 'Entregado' or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') group by ID.Nombre_Dispositivo,I.Cod_Inventario order by ID.Nombre_Dispositivo,I.Cod_Inventario"
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
    Public Function Consulta_Filtro_Marca_Asignar_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select I.Marca from Inventario I Full join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Sede='BOD' and I.Estado <> 'Baja' and I.Estado <> 'Entregado' and Nombre_Dispositivo=@_Nombre_Dispositivo or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') group by I.Marca order by I.Marca"
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 80).Value = _Nombre_Dispositivo
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
    Public Function Consulta_Filtro_Modelo_Asignar_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select I.Modelo from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Sede='BOD' and I.Estado <> 'Baja' and I.Estado <> 'Entregado' and I.Marca=@_Marca or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') group by I.Modelo order by I.Modelo"
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
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
    Public Function Consulta_Filtro_Serial_Asignar_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Empresa from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Sede='BOD' and I.Estado <> 'Baja' and I.Estado <> 'Entregado' and I.Modelo=@_Modelo or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') group by Empresa order by Empresa"
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
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
    Public Function Consulta_Filtro_Serial_Asignar_SerialActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Serial_Kamilion from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Sede='BOD' and Empresa=@_Empresa and I.Estado <> 'Baja' and I.Estado <> 'Entregado' and I.Modelo=@_Modelo or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') group by Serial_Kamilion order by Serial_Kamilion"
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
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
    Public Function Consulta_Filtro_Serial_Asignar_Serial1Activo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Serial from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Sede='BOD' and Empresa=@_Empresa and I.Estado <> 'Baja' and I.Estado <> 'Entregado' and I.Modelo=@_Modelo or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') group by Serial order by Serial"
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 50).Value = _Empresa
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
    Public Function Consulta_Inventario_RegistrosActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Estado <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Descripcion,I.Cod_Agente from Inventario I Full join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.FcReg_Invent is not null and I.Estado=@_Estado and ID.Letra_Categoria = 'Activo'"
                cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            End If
            If _Serial_Kamilion <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Descripcion,I.Cod_Agente from Inventario I Full join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Serial_Kamilion like '%" + _Serial_Kamilion + "%' and ID.Letra_Categoria = 'Activo'"
                cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 10).Value = _Serial_Kamilion
            End If
            If _Cod_Inventario <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo as Dispositivo,I.Marca,I.Modelo,I.Serial,I.Serial_Kamilion,I.Empresa,I.Sede,I.Estado,I.Id_Usuario,I.FcReg_Invent,I.Descripcion,I.Cod_Agente from Inventario I Full join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Cod_Inventario=@_Cod_Inventario and ID.Letra_Categoria = 'Activo'"
                cms.Parameters.Add("@_Cod_Inventario", SqlDbType.VarChar, 10).Value = _Cod_Inventario
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Inventario_Registros_DetalleActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Cod_Inventario <> Nothing Then
                cms.CommandText = "select I.Cod_Inventario,ID.Fk_Cod_Inventario,ID.Fk_ID_Modulo,ID.Observacion,ID.Estado,ID.Id_Usuario,ID.Sede,ID.Cod_Agente,ID.FecReg_InventD,ID.Cod_Inventario_Detalle from Inventario I Inner Join Invent_Detalle ID on I.Cod_Inventario=ID.Fk_Cod_Inventario where Fk_Cod_Inventario=@_Cod_Inventario"
                cms.Parameters.Add("@_Cod_Inventario", SqlDbType.VarChar, 50).Value = _Cod_Inventario
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Estado_LiberaActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Nombre_Dispositivo from Invent_Dispositivo where Letra_Categoria = 'Estado' group by Nombre_Dispositivo order by Nombre_Dispositivo"
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
    Public Function Consulta_Dispo_LiberaActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Fk_Cod_Invent_Dispositivo,Nombre_dispositivo from Inventario I Inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo Where Letra_Categoria='Activo'  group by I.Fk_Cod_Invent_Dispositivo,ID.Nombre_Dispositivo order by ID.Nombre_Dispositivo"
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
    Public Function Consulta_Dispo_EstadoActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Fk_Cod_Invent_Dispositivo,Nombre_dispositivo from Inventario I Inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo Where Letra_Categoria='Activo' group by I.Fk_Cod_Invent_Dispositivo,ID.Nombre_Dispositivo order by ID.Nombre_Dispositivo"
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
    Public Function Consulta_Agente_LiberaActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select nombreu,codnom from usuarios where cargo <> 'retirado' and codnom like 'C%' or nombreu='- Seleccione -' ORDER BY nombreu"
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
    Public Function Consulta_Agente_EstadoActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from usuarios where cargo = 'N0_G2' ORDER BY nombreu"
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
    Public Sub Cambio_EstadoActivo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "update Inventario set Estado=@_Estado from Inventario I Inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Marca=@_Marca and Modelo=@_Modelo and Serial_Kamilion=@_Serial_Kamilion "
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 120).Value = _Marca
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 120).Value = _Modelo
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 120).Value = _Serial_Kamilion
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
    Public Sub Cambio_Estado2Activo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "update Inventario set Estado=@_Estado from Inventario I Inner join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo  where FK_Cod_Invent_Dispositivo=@_FK_Cod_Invent_Dispositivo  and Marca=@_Marca and Modelo=@_Modelo and Serial_Kamilion=@_Serial_Kamilion "
            cms.Parameters.Add("@_FK_Cod_Invent_Dispositivo ", SqlDbType.VarChar, 50).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 120).Value = _Marca
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 120).Value = _Modelo
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 120).Value = _Serial_Kamilion
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
    Public Function Consulta_Filtro_Marca_Estado_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select I.Marca from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Letra_Categoria='Activo' and Nombre_Dispositivo=@_Nombre_Dispositivo or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') group by I.Marca"
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 80).Value = _Nombre_Dispositivo
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
    Public Function Consulta_Filtro_Modelo_Estado_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select I.Modelo from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Letra_Categoria='Activo' and Marca=@_Marca or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') group by I.Modelo"
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
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

    Public Function Consulta_Filtro_empresa_Estado_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select isnull(convert(varchar(15),i.Empresa),'- Seleccione -') as Empresa,ID.Nombre_Dispositivo from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Modelo=@_Modelo and Nombre_Dispositivo=@_Nombre_Dispositivo and Marca=@_Marca or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') group by empresa,ID.Nombre_Dispositivo"
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
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
    Public Function Consulta_Filtro_Serial_Estado_DispositivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Inventario I right join Invent_Dispositivo ID on I.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where Modelo=@_Modelo and Nombre_Dispositivo=@_Nombre_Dispositivo and Marca=@_Marca or (ID.Nombre_Dispositivo = '- Seleccione -' and ID.Letra_Categoria='Activo') order by ID.Nombre_Dispositivo"
            cms.Parameters.Add("@_Modelo", SqlDbType.VarChar, 50).Value = _Modelo
            cms.Parameters.Add("@_Nombre_Dispositivo", SqlDbType.VarChar, 50).Value = _Nombre_Dispositivo
            cms.Parameters.Add("@_Marca", SqlDbType.VarChar, 50).Value = _Marca
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
    Public Function Validacion_Codigo_Iventario_ActivosActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) '' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Cod_Agente <> Nothing And _Sede <> Nothing Then
                cms.CommandText = "Select Cod_Inventario from inventario where Fk_Cod_Invent_Dispositivo=@_Fk_Cod_Invent_Dispositivo and Serial_Kamilion=@_Serial_Kamilion"
                cms.Parameters.Add("@_Fk_Cod_Invent_Dispositivo", SqlDbType.Int).Value = _Fk_Cod_Invent_Dispositivo
                cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
                cms.Connection = cn
            Else
                If _Cod_Agente <> Nothing Then
                    cms.CommandText = "Select Cod_Inventario from inventario where Fk_Cod_Invent_Dispositivo=@_Fk_Cod_Invent_Dispositivo and Serial_Kamilion=@_Serial_Kamilion"
                    cms.Parameters.Add("@_Fk_Cod_Invent_Dispositivo", SqlDbType.Int).Value = _Fk_Cod_Invent_Dispositivo
                    cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
                    cms.Connection = cn
                End If
                If _Sede <> Nothing Then
                    cms.CommandText = "Select Cod_Inventario from inventario where Fk_Cod_Invent_Dispositivo=@_Fk_Cod_Invent_Dispositivo and Serial_Kamilion=@_Serial_Kamilion"
                    cms.Parameters.Add("@_Fk_Cod_Invent_Dispositivo", SqlDbType.Int).Value = _Fk_Cod_Invent_Dispositivo
                    cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
                    cms.Connection = cn
                End If
            End If
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cod_Inventario = dts.Tables(0).Rows.Count
            If _Cod_Inventario > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Inventario") Is DBNull.Value Then
                    _Cod_Inventario = Nothing
                Else
                    _Cod_Inventario = dts.Tables(0).Rows(0).Item("Cod_Inventario")
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
    Public Function Validacion_Codigo_Iventario_Activos1Activo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) '' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Cod_Agente <> Nothing And _Sede <> Nothing Then
                cms.CommandText = "Select Cod_Inventario from inventario where Fk_Cod_Invent_Dispositivo=@_Fk_Cod_Invent_Dispositivo and Serial=@_Serial"
                cms.Parameters.Add("@_Fk_Cod_Invent_Dispositivo", SqlDbType.Int).Value = _Fk_Cod_Invent_Dispositivo
                cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
                cms.Connection = cn
            Else
                If _Cod_Agente <> Nothing Then
                    cms.CommandText = "Select Cod_Inventario from inventario where Fk_Cod_Invent_Dispositivo=@_Fk_Cod_Invent_Dispositivo and Serial=@_Serial"
                    cms.Parameters.Add("@_Fk_Cod_Invent_Dispositivo", SqlDbType.Int).Value = _Fk_Cod_Invent_Dispositivo
                    cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
                    cms.Connection = cn
                End If
                If _Sede <> Nothing Then
                    cms.CommandText = "Select Cod_Inventario from inventario where Fk_Cod_Invent_Dispositivo=@_Fk_Cod_Invent_Dispositivo and Serial=@_Serial"
                    cms.Parameters.Add("@_Fk_Cod_Invent_Dispositivo", SqlDbType.Int).Value = _Fk_Cod_Invent_Dispositivo
                    cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
                    cms.Connection = cn
                End If
            End If
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cod_Inventario = dts.Tables(0).Rows.Count
            If _Cod_Inventario > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Inventario") Is DBNull.Value Then
                    _Cod_Inventario = Nothing
                Else
                    _Cod_Inventario = dts.Tables(0).Rows(0).Item("Cod_Inventario")
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
    Public Function Validacion_Codigo_Iventario_Activos2Activo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) '' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select Cod_Inventario from inventario where Fk_Cod_Invent_Dispositivo=@_Fk_Cod_Invent_Dispositivo and Serial_Kamilion=@_Serial_Kamilion"
            cms.Parameters.Add("@_Fk_Cod_Invent_Dispositivo", SqlDbType.Int).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Serial_Kamilion", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cod_Inventario = dts.Tables(0).Rows.Count
            If _Cod_Inventario > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Inventario") Is DBNull.Value Then
                    _Cod_Inventario = Nothing
                Else
                    _Cod_Inventario = dts.Tables(0).Rows(0).Item("Cod_Inventario")
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
    Public Function Validacion_Codigo_Iventario_Activos3Activo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) '' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select Cod_Inventario from inventario where Fk_Cod_Invent_Dispositivo=@_Fk_Cod_Invent_Dispositivo and Serial=@_Serial"
            cms.Parameters.Add("@_Fk_Cod_Invent_Dispositivo", SqlDbType.Int).Value = _Fk_Cod_Invent_Dispositivo
            cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cod_Inventario = dts.Tables(0).Rows.Count
            If _Cod_Inventario > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Inventario") Is DBNull.Value Then
                    _Cod_Inventario = Nothing
                Else
                    _Cod_Inventario = dts.Tables(0).Rows(0).Item("Cod_Inventario")
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
    Public Function ConsultaCodigoAgentesActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select codnom from usuarios where codnom is not null and codnom <> '0'  union select '- Seleccione -' as codnom from usuarios ORDER BY codnom"
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
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''Asignacion modulos - Control de Malla Mesas de Soporte'''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Turno As String

    Public Property Turno As String
        Get
            Return _Turno
        End Get
        Set(ByVal value As String)
            _Turno = value
        End Set
    End Property
    'La función realizar múltiples consultas 
    Public Function Consulta_Modulo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = 1 Then
                cms.CommandText = "select * from BD_Admin_Complemento where pertenece='TurnoMesa' order by nombre"
            End If
            If Turno <> Nothing Then
                cms.CommandText = "SELECT n1.ID_Modulo   from  (SELECT IM.ID_Modulo,AM.turno FROM Invent_Modulo IM left join Asignacion_Modulo AM on IM.ID_Modulo = AM.Fk_Modulo) as n1 LEFT JOIN (SELECT a.* FROM Asignacion_Modulo A RIGHT join Invent_Modulo i on i.ID_Modulo =a.Fk_Modulo WHERE turno =@TURNO OR turno='OFICINA') AS N2 ON N2.Fk_Modulo =N1.ID_Modulo  WHERE  N2.turno IS NULL"
                cms.Parameters.Add("@Turno", SqlDbType.VarChar, 30).Value = Turno
            End If
            If Turno = "OFICINA" Then
                cms.CommandText = "SELECT n1.ID_Modulo   from  (SELECT IM.ID_Modulo,AM.turno FROM Invent_Modulo IM left join Asignacion_Modulo AM on IM.ID_Modulo = AM.Fk_Modulo) as n1 LEFT JOIN (SELECT a.* FROM Asignacion_Modulo A RIGHT join Invent_Modulo i on i.ID_Modulo =a.Fk_Modulo WHERE turno ='AM' OR turno='OFICINA' or turno ='PM') AS N2 ON N2.Fk_Modulo =N1.ID_Modulo  WHERE  N2.turno IS NULL "
            End If

            If Validacion = 2 Then
                cms.CommandText = "select nombres+' '+ apellidos as nombreu,p.codigo,a.Fk_Codigo  from personal p  left join Asignacion_Modulo a on p.codigo=a.Fk_Codigo  where a.Fk_Codigo is null and p.codigo like 'C%' and estado ='A' union select '- Seleccione -' as nombres,p.codigo,a.Fk_Codigo  from  personal p  left join Asignacion_Modulo a on p.codigo=a.Fk_Codigo  where p.nombres='- Seleccione -'"
            End If
            If Validacion = 3 Or Turno = "- Seleccione -" Then
                cms.CommandText = "select '- Seleccione -'  as ID_Modulo,'- Seleccione -' as CodAsigna"
            End If
            If Validacion = 5 Then
                cms.CommandText = "select Fk_Modulo from Asignacion_Modulo where fk_codigo <>'null'   union select '- Seleccione -'  as Fk_Modulo"
            End If
            If Validacion = 6 Then
                cms.CommandText = "select TURNO from Asignacion_Modulo where fk_modulo=@Modulo1 and turno<>'null' union select '- Seleccione -'  as TURNO"
                cms.Parameters.Add("@Modulo1", SqlDbType.VarChar, 10).Value = Fk_ID_Modulo
            End If
            If Validacion = 7 Then
                cms.CommandText = "select fk_codigo,nombres+' '+apellidos as 'Nombre'  from Asignacion_Modulo AM inner join personal P on AM.FK_codigo=p.codigo where am.fk_modulo=@Modulo2 and am.turno=@Turno2   union select '- Seleccione -'  as fk_codigo, '- Seleccione -'  as Nombre"
                cms.Parameters.Add("@Modulo2", SqlDbType.VarChar, 10).Value = Fk_ID_Modulo
                cms.Parameters.Add("@Turno2", SqlDbType.VarChar, 10).Value = Turno
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
    'El siguiente método es para asignar los módulos
    Public Sub AsignarModulo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "insert into Asignacion_Modulo(Fk_Modulo,turno,Id_usuario,Fk_Codigo) values (@Modulo,@Turno,@Usuario,@Codigo)"
            cms.Parameters.Add("@Modulo", SqlDbType.VarChar, 10).Value = Fk_ID_Modulo
            cms.Parameters.Add("@Turno", SqlDbType.VarChar, 10).Value = Turno
            cms.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = Cod_Agente
            cms.Parameters.Add("@Usuario", SqlDbType.VarChar, 10).Value = Id_Usuario
            cms.Connection = cn
            cms.ExecuteNonQuery()
            cms.CommandText = "Insert into control_asignacion (observacion,turno,codigo,Fk_Modulo,Id_usuario) values('Registro Asignacion',@Turno,@Codigo,@Modulo,@Usuario)"
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
    'El siguiente método es para actualizar la asignación de módulos 
    Public Sub ActualizaModulo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into control_asignacion (observacion,turno,codigo,Fk_Modulo,id_usuario) values(@Observacion,@Turno,@Codigo,@Modulo,@usuario)"
            cms.Parameters.Add("@Modulo", SqlDbType.VarChar, 10).Value = Fk_ID_Modulo
            cms.Parameters.Add("@Observacion", SqlDbType.VarChar, 300).Value = _Observacion
            cms.Parameters.Add("@Turno", SqlDbType.VarChar, 10).Value = Turno
            cms.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = Cod_Agente
            cms.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = Id_Usuario
            cms.Connection = cn
            cms.ExecuteNonQuery()
            cms.CommandText = "delete Asignacion_Modulo where fk_modulo=@Modulo AND FK_CODIGO=@Codigo and turno =@Turno "
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
    'La siguiente función realiza las consultas de información de historial y modulos
    Public Function Consulta_Modulo1() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            If Validacion = 1 Then
                cms.CommandText = "select nombres+' '+ apellidos as nombreu,codigo  from personal where estado='A' union select '- Seleccione -' as nombreu, '- Seleccione -' as codigo order by nombreu"
            End If
            If Validacion = 2 Then
                cms.CommandText = "select ID_Modulo  from Invent_Modulo"
            End If
            If Turno <> Nothing Then
                cms.CommandText = "select am.*,p.nombres+''+ p.apellidos as Nombre from Asignacion_Modulo am  inner join personal p on p.codigo =am.Fk_Codigo where am.turno=@Turno"
                cms.Parameters.Add("@Turno", SqlDbType.VarChar, 10).Value = Turno
            End If
            If Id_Usuario <> Nothing Then
                cms.CommandText = "select am.*,p.nombres+''+ p.apellidos as Nombre from Asignacion_Modulo am  inner join personal p on p.codigo =am.Fk_Codigo where Codigo=@Codigo"
                cms.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = Id_Usuario
            End If
            If ID_Modulo <> Nothing Then
                cms.CommandText = "select am.*,p.nombres+''+ p.apellidos as Nombre from Asignacion_Modulo am  inner join personal p on p.codigo =am.Fk_Codigo where Fk_Modulo=@Modulo"
                cms.Parameters.Add("@Modulo", SqlDbType.VarChar, 10).Value = ID_Modulo
            End If
            If Validacion = 1 Then
                If Id_Usuario <> Nothing Then
                    cms.CommandText = "select ca.*,p.nombres+''+ p.apellidos as Nombre from Control_Asignacion ca inner join personal p on p.codigo =ca.Codigo where ca.Codigo=@Codigo"

                End If
                If ID_Modulo <> Nothing Then
                    cms.CommandText = "select ca.*,p.nombres+''+ p.apellidos as Nombre from Control_Asignacion ca inner join personal p on p.codigo =ca.Codigo where ca.Fk_Modulo=@Modulo"
                End If
            End If
            If Validacion = "3" Then
                cms.CommandText = "select am.*,p.nombres+''+ p.apellidos as Nombre from Asignacion_Modulo am  inner join personal p on p.codigo =am.Fk_Codigo"
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    '''''Inventario Activos Fijos''''

    Public Function consultasdrl() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
            cn.Open()
            cms.CommandText = "select Nombre from Activo_Inventario_Complemento where pertenece='Sede' or Nombre='- Seleccione -' order by Nombre"
            If Validacion = 1 Then
                cms.CommandText = "select * from Activo_Inventario_Complemento where pertenece='Estado' or Nombre='- Seleccione -'or nombre='Activo' order by Nombre"
            End If
            If Validacion = 2 Then
                cms.CommandText = "select * from Activo_Inventario_Complemento where pertenece='Zona' or Nombre='- Seleccione -' order by Nombre"
            End If
            If Validacion = 3 Then
                cms.CommandText = "SELECT DISTINCT Pertenece FROM Activo_Inventario_Complemento WHERE pertenece='Muebles y enseres'  or pertenece='Planta y Equipo'  or pertenece='Otros' or pertenece='- Seleccione -'order by pertenece"
            End If
            If Validacion = 4 Then
                cms.CommandText = "select *  from Activo_Inventario_Complemento where pertenece='Marca'or Nombre='- Seleccione -' order by Nombre"
            End If
            If Validacion = 5 Then
                cms.CommandText = "SELECT DISTINCT referencia from Activo_Inventario union select nombre from Activo_Inventario_Complemento where Nombre='- Seleccione -'"
            End If
            If Validacion = 6 Then
                cms.CommandText = "SELECT DISTINCT Pertenece FROM Activo_Inventario_Complemento where pertenece<>'Muebles y Enseres'and pertenece<>'Planta y Equipo' and pertenece<>'Otros' and  pertenece<>'Estado' and pertenece<>'Mantenimiento' and pertenece<>'Tipo' or  Nombre='Activo' order by pertenece"
            End If
            If Validacion = 7 Then
                cms.CommandText = "select * from Activo_Inventario_Complemento where  pertenece='Muebles y enseres'  or pertenece='Planta y Equipo'  or pertenece='Otros' or nombre='- Seleccione -' order by Nombre"
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

    Public Function consultaresponsable() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            cn.Open()
            cms.CommandText = "select *  from usuarios where cargo <>'Retirado' and perfil=10 or perfil=9 or perfil=22 or perfil=32 or perfil=1 and codnom is not null or nombreu='- Seleccione -'  order by nombreu"
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

    Public Function consultarUsuario() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
            cn.Open()
            cms.CommandText = "select *  from datosclaro.dbo.usuarios where codnom is not null or nombreu='- Seleccione -'  order by nombreu"
            If subResponsable <> Nothing Then
                cms.CommandText = "select  U.*,P.documento,p.codigo  from datosclaro.dbo.usuarios U inner join   admin_cham.dbo.personal P  on p.codigo =u.codnom  where u.idusuario=@nom "
                cms.Parameters.Add("@nom", SqlDbType.VarChar, 25).Value = subResponsable
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                _Cod_Agente = Convert.ToString(dts.Tables(0).Rows(0).Item("codigo"))
                _documento = Convert.ToString(dts.Tables(0).Rows(0).Item("documento"))
                _cargo = Convert.ToString(dts.Tables(0).Rows(0).Item("cargo"))
                Return dts
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


    Public Function consulta_lista_area() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
            cn.Open()
            cms.CommandText = "select * from Archivo_Complemento where  pertenece = 'Area_Inventario_Acta' or nombre='- Seleccione -' order by Nombre"
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

    Public Function consultaActivo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
            cn.Open()
            cms.CommandText = "select * from Activo_Inventario_Complemento where  pertenece=@pertenece or nombre='- Seleccione -' order by Nombre"
            cms.Parameters.Add("@pertenece", SqlDbType.VarChar, 25).Value = _Pertenece
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

    Public Sub registrarActivo()
        Dim cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "insert into Activo_Inventario (Serial,Sigla,Fc_Reg,Usu_Registra,Zona,Sede,Estado,Nombre_Activo,Marca,Referencia,Descripcion,Responsable,sub_responsable,No_Acta_baja)values(@Serial,@Sigla,@fecha,@Usu_registro,@Zona,@Sede,@estado,@Nombre_Activo,@marca,@Referencia,@Descripcion,@Responsable,@Sub_Responsable,@No_Acta)"
            cms.Parameters.Add("@Serial", SqlDbType.VarChar, 24).Value = _Serial
            cms.Parameters.Add("@Sigla", SqlDbType.VarChar, 24).Value = _Sigla
            cms.Parameters.Add("@fecha", SqlDbType.DateTime).Value = _FcReg_Invent
            cms.Parameters.Add("@Usu_registro", SqlDbType.NVarChar, 24).Value = _Id_Usuario
            cms.Parameters.Add("@Zona", SqlDbType.VarChar, 24).Value = Zona
            cms.Parameters.Add("@Sede", SqlDbType.VarChar, 24).Value = Sede
            cms.Parameters.Add("@estado", SqlDbType.VarChar, 24).Value = _Estado
            cms.Parameters.Add("@Nombre_Activo", SqlDbType.VarChar, 24).Value = Nombre_Activo
            cms.Parameters.Add("@marca", SqlDbType.VarChar, 24).Value = Marca
            cms.Parameters.Add("@Referencia", SqlDbType.VarChar, 24).Value = Modelo
            cms.Parameters.Add("@Descripcion", SqlDbType.VarChar, 79).Value = _Descripcion
            cms.Parameters.Add("@Responsable", SqlDbType.NVarChar, 25).Value = Responsable
            cms.Parameters.Add("@Sub_Responsable", SqlDbType.NVarChar, 25).Value = sub_Responsable
            cms.Parameters.Add("@No_Acta", SqlDbType.NVarChar, 25).Value = No_Acta
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            valida = 1
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub registrarActivocambio()
        Dim cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "insert into Activo_Inventario_Cambio (Cod_inventario_Activos,Fecha_Cambio,Id_Usuario,Observacion_Cambio,Estado,SedeCambio,Responsable,sub_responsable) values (@Cod,@fecha,@Usu_registro,@Obs,@estado,@sede,@Responsable,@subresponsable)"
            cms.Parameters.Add("@cod", SqlDbType.VarChar, 24).Value = Cod_Inventario
            cms.Parameters.Add("@fecha", SqlDbType.DateTime).Value = _FcReg_Invent
            cms.Parameters.Add("@Usu_registro", SqlDbType.NVarChar, 24).Value = Id_Usuario
            cms.Parameters.Add("@Obs", SqlDbType.VarChar, 500).Value = _Observacion_Cambio
            cms.Parameters.Add("@estado", SqlDbType.VarChar, 24).Value = _Estado
            cms.Parameters.Add("@Sede", SqlDbType.VarChar, 24).Value = Sede
            cms.Parameters.Add("@Responsable", SqlDbType.NVarChar, 20).Value = Responsable
            cms.Parameters.Add("@subresponsable", SqlDbType.NVarChar, 20).Value = subResponsable
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            valida = 1
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub CambiarActivo()
        Dim cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Update Activo_Inventario set Estado=@estado,sede=@sede,Zona=@zona,responsable=@responsable ,descripcion=@des,sub_responsable=@subresponsable,no_acta_baja=@n_acta  WHERE Cod_Inventario_Activos=@cod"
            cms.Parameters.Add("@cod", SqlDbType.VarChar, 25).Value = Cod_Inventario
            cms.Parameters.Add("@estado", SqlDbType.VarChar, 25).Value = _Estado
            cms.Parameters.Add("@sede", SqlDbType.VarChar, 25).Value = Sede
            cms.Parameters.Add("@zona", SqlDbType.VarChar, 25).Value = Zona
            cms.Parameters.Add("@responsable", SqlDbType.VarChar, 25).Value = Responsable
            cms.Parameters.Add("@des", SqlDbType.VarChar, 79).Value = _Descripcion
            cms.Parameters.Add("@subresponsable", SqlDbType.VarChar, 25).Value = subResponsable
            cms.Parameters.Add("@N_acta", SqlDbType.VarChar, 25).Value = No_Acta
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            valida = 1
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function UpdateExcel()
        Try
            Using ConexionE As New OleDbConnection(_Ruta_Excel)
                Dim Comando As New OleDbCommand
                Comando.CommandText = "SELECT  Cod_Inventario_Activos,'" + _FcReg_Invent + " ' as Fecha_cambio,'" + Id_Usuario + "' as Id_Usuario,Zona,Sede,Estado,Responsable,Sub_responsable,No_Acta_baja,Observacion ,Descripcion FROM [Cambios_Inventario$]"
                Comando.Connection = ConexionE
                Dim Adaptador As New OleDbDataAdapter
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(DteXCEL)
                Dim listaux As New List(Of DataRow)
                For Each dr As DataRow In DteXCEL.Rows
                    If dr("Cod_Inventario_Activos").ToString = "" Then
                        listaux.Add(dr)
                    End If
                Next
                For Each dr As DataRow In listaux
                    DteXCEL.Rows.Remove(dr)
                Next
            End Using
        Catch ex As Exception
        End Try
        Return DteXCEL
    End Function

    Public Function consultaAcTodo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
            cn.Open()
            If Nombre_Activo <> Nothing And Nombre_Activo <> "- Seleccione -" Then
                cms.CommandText = "select * from Activo_Inventario where  Nombre_Activo =@nombre"
                cms.Parameters.Add("@nombre", SqlDbType.VarChar, 25).Value = Nombre_Activo
            End If
            If Sede <> Nothing Then
                cms.CommandText = " select * from Activo_inventario where sede=@sede"
                cms.Parameters.Add("@sede", SqlDbType.VarChar, 24).Value = Sede
            End If
            If Sede <> Nothing And Nombre_Activo <> Nothing Then
                cms.CommandText = " select * from Activo_inventario where sede=@sede1 and nombre_activo=@nom2"
                cms.Parameters.Add("@sede1", SqlDbType.VarChar, 24).Value = Sede
                cms.Parameters.Add("@nom2", SqlDbType.VarChar, 24).Value = Nombre_Activo
            End If
            If _Estado <> Nothing Then
                cms.CommandText = " select* from Activo_inventario where Estado=@estado  "
                cms.Parameters.Add("@estado", SqlDbType.VarChar, 24).Value = _Estado
            End If
            If _Estado <> Nothing And Nombre_Activo <> Nothing Then
                cms.CommandText = " select * from Activo_inventario where Estado=@estado1 and Nombre_Activo=@nom1"
                cms.Parameters.Add("@estado1", SqlDbType.VarChar, 24).Value = _Estado
                cms.Parameters.Add("@nom1", SqlDbType.VarChar, 24).Value = Nombre_Activo
            End If
            If _Serial <> Nothing Then
                cms.CommandText = "select * from Activo_inventario  where  serial=@serial "
                cms.Parameters.Add("@serial", SqlDbType.VarChar, 25).Value = _Serial
            End If
            If Cod_Inventario <> Nothing Then
                cms.CommandText = "select * from Activo_inventario where  cod_inventario_activos=@codigo"
                cms.Parameters.Add("@codigo", SqlDbType.VarChar, 24).Value = _Cod_Inventario
            End If
            If Responsable <> Nothing Then
                cms.CommandText = "select * from admin_cham.dbo.Activo_Inventario   where Responsable=@responsable"
                cms.Parameters.Add("@responsable", SqlDbType.VarChar, 24).Value = Responsable
                cms.Connection = cn
            End If
            If _clasificacion <> Nothing Then
                cms.CommandText = "select cod_inventario_activos,serial,fc_reg,responsable, usu_registra ,sigla,Referencia,descripcion,Nombre_Activo,Sede,zona, estado, Marca ,Sub_responsable,No_Acta_baja from Activo_Inventario inner join Activo_Inventario_Complemento b  on Nombre_Activo=b.nombre   where b.pertenece =@clasificacion"
                cms.Parameters.Add("@clasificacion", SqlDbType.VarChar, 24).Value = _clasificacion
            End If
            If No_Acta <> Nothing Then
                cms.CommandText = "select cod_inventario_activos,serial,fc_reg,responsable, usu_registra ,sigla,Referencia,descripcion,Nombre_Activo,Sede,zona, estado, Marca ,Sub_responsable,No_Acta_baja from Activo_Inventario inner join Activo_Inventario_Complemento b  on Nombre_Activo=b.nombre   where No_Acta_Baja =@No_Acta"
                cms.Parameters.Add("@No_Acta", SqlDbType.VarChar, 24).Value = No_Acta_Baja
            End If
            If Marca <> Nothing And Marca <> "- Seleccione -" Then
                cms.CommandText = "select * from Activo_Inventario where Marca=@marca "
                cms.Parameters.Add("@marca", SqlDbType.VarChar, 50).Value = Marca
            End If
            If Nombre_Activo <> Nothing And Nombre_Activo <> "- Seleccione -" And Modelo <> Nothing Then
                cms.CommandText = "select * from Activo_Inventario where Referencia=@ref and Nombre_Activo =@nomb"
                cms.Parameters.Add("@ref", SqlDbType.VarChar, 30).Value = Modelo
                cms.Parameters.Add("@nomb", SqlDbType.VarChar, 25).Value = Nombre_Activo
            End If
            If subResponsable <> Nothing And subResponsable <> "- Seleccione -" Then
                cms.CommandText = "select * from Activo_Inventario where Sub_responsable=@Sresponsable"
                cms.Parameters.Add("@Sresponsable", SqlDbType.VarChar, 50).Value = subResponsable
            End If
            If Zona <> Nothing And Zona <> "- Seleccione -" Then
                cms.CommandText = "select * from Activo_Inventario where zona=@zona"
                cms.Parameters.Add("@zona", SqlDbType.VarChar, 50).Value = Zona
            End If
            If Validacion = 2 Then
                If Cod_Inventario <> Nothing Then
                    cms.CommandText = "select fecha_cambio,g.Id_Usuario,observacion_cambio,Nombre_Activo,g.Estado ,g.responsable,g.Sub_responsable,sedecambio,g.Cod_inventario_Activos ,serial from admin_cham.dbo.Activo_Inventario_Cambio g  inner join admin_cham.dbo.Activo_Inventario t on t.Cod_Inventario_Activos=g.Cod_inventario_Activos    where  g.Cod_inventario_Activos=@cod order by Fecha_Cambio"
                    cms.Parameters.Add("@cod", SqlDbType.VarChar, 24).Value = _Cod_Inventario
                End If
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                Me._Cantidad1 = dts.Tables(0).Rows.Count
                Return dts
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


    'REGISTRO MASIVO ACTIVOS
    Public Function consulta() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
            cn.Open()
            cms.CommandText = "select * from Activo_inventario"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me._Cantidad1 = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Sub Excel2()
        Try
            Using ConexionE As New OleDbConnection(_Ruta_Excel)
                Dim Comando As New OleDbCommand
                Comando.CommandText = "SELECT  Serial , Sigla ,'" + _FcReg_Invent + " ' as Fc_Reg,'" + Id_Usuario + "' as Usu_Registra,Zona,Sede,Estado, Nombre_Activo,Marca,Referencia,Descripcion,Responsable,Sub_responsable,No_Acta_baja  FROM [Registros_Inventario$]"
                Comando.Connection = ConexionE
                Dim Adaptador As New OleDbDataAdapter
                Adaptador.SelectCommand = Comando
                Adaptador.Fill(DteXCEL)
                Dim listaux As New List(Of DataRow)
                Dim MyView As DataView
                Dim dtSinDuplicados As DataTable
                Dim valor1 As String
                Dim valor2 As String
                Validacion = 10
                If Validacion = 10 Then
                    Dtactivos = consulta()
                    MyView = New DataView(DteXCEL)
                    dtSinDuplicados = MyView.ToTable(True, "Serial", "Sigla", "Fc_Reg", "Usu_Registra", "Zona", "Sede", "Estado", "Nombre_Activo", "Marca", "Referencia", "Descripcion", "Responsable", "Sub_responsable", "No_Acta_baja")
                    DteXCEL = dtSinDuplicados
                    For Each row As DataRow In Dtactivos.Tables(0).Rows
                        valor2 = row("Serial").ToString
                        For Each dr As DataRow In DteXCEL.Rows
                            valor1 = dr("Serial").ToString
                            If valor1 = valor2 Then
                                listaux.Add(dr)
                            End If
                        Next
                    Next
                    For Each row As DataRow In Dtactivos.Tables(0).Rows
                        valor2 = row("Serial").ToString
                        For Each dr As DataRow In DteXCEL.Rows
                            valor1 = dr("Serial").ToString
                            If valor1 = valor2 Then
                                listaux.Add(dr)
                            End If
                        Next
                    Next
                    For Each dr As DataRow In listaux
                        DteXCEL.Rows.Remove(dr)
                    Next
                End If
                For Each dr As DataRow In DteXCEL.Rows
                    If dr("Nombre_Activo").ToString = "" Then
                        listaux.Add(dr)
                    End If
                Next
                For Each dr As DataRow In listaux
                    DteXCEL.Rows.Remove(dr)
                Next
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub AExcel()
        Try
            If Validacion = 2 Then
                Excel2()
            End If
            _Cantidad = DteXCEL.Rows.Count
            Dim cms As New SqlClient.SqlCommand
            Dim dta As New SqlClient.SqlDataAdapter
            Dim listaux As New List(Of DataRow)
            Using Conexion As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                cms.Connection = Conexion
                Conexion.Open()
                Using bulkCopy As New SqlClient.SqlBulkCopy((System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString))
                    bulkCopy.DestinationTableName = "Activo_inventario"
                    For Each col As DataColumn In DteXCEL.Columns
                        bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName)
                    Next
                    bulkCopy.WriteToServer(DteXCEL)
                End Using
                Conexion.Close()
            End Using
        Catch ex As Exception
            valida = 1
        End Try
    End Sub

    'EN ESTE METODO se realizan registros como son: marcas, activos, sedes y zonas.
    Public Sub Registrar()
        Dim cn As New SqlClient.SqlConnection
        cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into Activo_Inventario_Complemento(Nombre, Pertenece) values (@Nom,@Pert)"
            cms.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nombre
            cms.Parameters.Add("@Pert", SqlDbType.VarChar).Value = Pertenece
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            valida = 1
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function consultadtgcodigos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
            cn.Open()
            cms.CommandText = "select * from Activo_Inventario  where Cod_inventario_activos=@cod"
            cms.Parameters.Add("@cod", SqlDbType.Int).Value = _Cod_Inventario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Serial = Convert.ToString(dts.Tables(0).Rows(0).Item("Serial"))
            _Descripcion = Convert.ToString(dts.Tables(0).Rows(0).Item("descripcion"))
            _Estado = Convert.ToString(dts.Tables(0).Rows(0).Item("estado"))
            Sede = Convert.ToString(dts.Tables(0).Rows(0).Item("sede"))
            Zona = Convert.ToString(dts.Tables(0).Rows(0).Item("zona"))
            _Responsable = Convert.ToString(dts.Tables(0).Rows(0).Item("responsable"))
            subResponsable = Convert.ToString(dts.Tables(0).Rows(0).Item("sub_responsable"))
            No_Acta = Convert.ToString(dts.Tables(0).Rows(0).Item("No_Acta_baja"))
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    '-------------------_registros Actas_------------------------
    Public Sub RegistrarActa()
        Dim cn As New SqlClient.SqlConnection
        cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into Activo_Inventario_Acta(Usu_Reg , Fc_Reg, trabajador, Codigo_usu , Area , cedula , cargo , Fc_Asignacion) values (@usu,@fecha,@trabaj,@cod,@area,@cedula,@cargo,@fc_asig)"
            cms.Parameters.Add("@usu", SqlDbType.VarChar).Value = Id_Usuario
            cms.Parameters.Add("@fecha", SqlDbType.VarChar).Value = _FcReg_Invent
            cms.Parameters.Add("@trabaj", SqlDbType.VarChar).Value = subResponsable
            cms.Parameters.Add("@cod", SqlDbType.VarChar).Value = Cod_Agente
            cms.Parameters.Add("@area", SqlDbType.VarChar).Value = _area
            cms.Parameters.Add("@cedula", SqlDbType.VarChar).Value = documento
            cms.Parameters.Add("@cargo", SqlDbType.VarChar).Value = cargo
            cms.Parameters.Add("@fc_asig", SqlDbType.VarChar).Value = fc_mto
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            valida = 1
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function ConsultarActa()
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            If Cod_Agente <> Nothing Then
                cms.CommandText = "select * from Activo_Inventario_Acta Where Codigo_usu=@cod"
                cms.Parameters.Add("@cod", SqlDbType.VarChar).Value = Cod_Agente
            End If
            If cod_Acta <> Nothing Then
                cms.CommandText = "select * from Activo_Inventario_Acta Where Cod_Activo_Inventario_Acta=@cod_acta"
                cms.Parameters.Add("@cod_acta", SqlDbType.VarChar).Value = cod_Acta
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)

            If dts.Tables(0).Rows.Count > 0 Then
                cod_Acta = Convert.ToString(dts.Tables(0).Rows(0).Item("Cod_Activo_Inventario_Acta"))
                subResponsable = Convert.ToString(dts.Tables(0).Rows(0).Item("Trabajador"))
                fc_mto = Convert.ToString(dts.Tables(0).Rows(0).Item("Fc_asignacion"))
                area = Convert.ToString(dts.Tables(0).Rows(0).Item("area"))
            Else
                Validacion = "1"
            End If
            Return dts
        Catch ex As Exception
            valida = 1
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Cod() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select MAX(Cod_Activo_Inventario_Acta)+1 as Cod_Activo_Inventario_Acta from Activo_Inventario_Acta"
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
    'INVENTARIO MANTENIMIENTO'
    Public Sub Ingresar_Mantenimiento()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "insert into Mantenimiento_Inventario(Fk_Cod_Inventario,Mantenimiento,Tipo , Fc_Mantenimiento ,fc_reg, Obs, Usu_Reg, Nombre_Equipo)values(@cod,@mant,@tipo,@Fc_Mto,@fc_reg,@obs,@usu_reg,@nombreE)"
            cms.Parameters.Add("@cod", SqlDbType.VarChar, 50).Value = Cod_Inventario
            cms.Parameters.Add("@mant", SqlDbType.VarChar, 50).Value = Mto
            cms.Parameters.Add("@tipo", SqlDbType.VarChar, 50).Value = Tipo
            cms.Parameters.Add("@fc_mto", SqlDbType.VarChar, 50).Value = fc_mto
            cms.Parameters.Add("@fc_reg", SqlDbType.VarChar, 50).Value = FcReg_Invent
            cms.Parameters.Add("@obs", SqlDbType.VarChar, 499).Value = Observacion
            cms.Parameters.Add("@usu_reg", SqlDbType.VarChar, 50).Value = Cod_Agente
            cms.Parameters.Add("@nombreE", SqlDbType.VarChar, 50).Value = NombreE
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

    Public Function consultaMantenimientos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
            cn.Open()

            cms.CommandText = "select Fk_Cod_Inventario,Mantenimiento,MI.Tipo , Fc_Mantenimiento ,fc_reg, Obs, Usu_Reg, Nombre_Equipo,marca,serial,serial_kamilion,modelo,ID.Nombre_dispositivo from Mantenimiento_Inventario MI inner join Inventario IV on Fk_Cod_Inventario=Cod_Inventario inner join Invent_Dispositivo ID  on Fk_cod_invent_dispositivo=cod_invent_dispositivo"

            If Serial <> Nothing Then
                cms.CommandText = "select Fk_Cod_Inventario,Mantenimiento,MI.Tipo , Fc_Mantenimiento ,fc_reg, Obs, Usu_Reg, Nombre_Equipo,marca,serial,serial_kamilion,modelo,ID.Nombre_dispositivo from Mantenimiento_Inventario MI inner join Inventario IV on Fk_Cod_Inventario=Cod_Inventario inner join Invent_Dispositivo ID  on Fk_cod_invent_dispositivo=cod_invent_dispositivo where serial=@serialeq"
                cms.Parameters.Add("@serialeq", SqlDbType.VarChar, 24).Value = _Serial
            End If
            If Mto <> Nothing Then
                cms.CommandText = "select Fk_Cod_Inventario,Mantenimiento,MI.Tipo , Fc_Mantenimiento ,fc_reg, Obs, Usu_Reg, Nombre_Equipo,marca,serial,serial_kamilion,modelo,ID.Nombre_dispositivo from Mantenimiento_Inventario MI inner join Inventario IV on Fk_Cod_Inventario=Cod_Inventario inner join Invent_Dispositivo ID  on Fk_cod_invent_dispositivo=cod_invent_dispositivo where mantenimiento=@Mto"
                cms.Parameters.Add("@mto", SqlDbType.VarChar, 24).Value = strlMto
            End If
            If Tipo <> Nothing Then
                cms.CommandText = "select Fk_Cod_Inventario,Mantenimiento,MI.Tipo , Fc_Mantenimiento ,fc_reg, Obs, Usu_Reg, Nombre_Equipo,marca,serial,serial_kamilion,modelo,ID.Nombre_dispositivo from Mantenimiento_Inventario MI inner join Inventario IV on Fk_Cod_Inventario=Cod_Inventario inner join Invent_Dispositivo ID  on Fk_cod_invent_dispositivo=cod_invent_dispositivo where MI.tipo=@tipo"
                cms.Parameters.Add("@tipo", SqlDbType.VarChar, 24).Value = strltipo
            End If
            If Serial_Kamilion <> Nothing Then
                cms.CommandText = "select Fk_Cod_Inventario,Mantenimiento,MI.Tipo , Fc_Mantenimiento ,fc_reg, Obs, Usu_Reg, Nombre_Equipo,marca,serial,serial_kamilion,modelo,ID.Nombre_dispositivo from Mantenimiento_Inventario MI inner join Inventario IV on Fk_Cod_Inventario=Cod_Inventario inner join Invent_Dispositivo ID  on Fk_cod_invent_dispositivo=cod_invent_dispositivo where serial_kamilion=@serialk"
                cms.Parameters.Add("@serialk", SqlDbType.VarChar, 24).Value = _Serial_Kamilion
            End If
            If Cod_Inventario <> Nothing Then
                cms.CommandText = "select Fk_Cod_Inventario,Mantenimiento,MI.Tipo , Fc_Mantenimiento ,fc_reg, Obs, Usu_Reg, Nombre_Equipo,marca,serial,serial_kamilion,modelo,ID.Nombre_dispositivo from Mantenimiento_Inventario MI inner join Inventario IV on Fk_Cod_Inventario=Cod_Inventario inner join Invent_Dispositivo ID  on Fk_cod_invent_dispositivo=cod_invent_dispositivo where Fk_Cod_Inventario=@Cod"
                cms.Parameters.Add("@Cod", SqlDbType.VarChar, 24).Value = _Cod_Inventario
            End If
            If NombreE <> Nothing Then
                cms.CommandText = " select Fk_Cod_Inventario,Mantenimiento,MI.Tipo , Fc_Mantenimiento ,fc_reg, Obs, Usu_Reg, Nombre_Equipo,marca,serial,serial_kamilion,modelo,ID.Nombre_dispositivo from Mantenimiento_Inventario MI inner join Inventario IV on Fk_Cod_Inventario=Cod_Inventario inner join Invent_Dispositivo ID  on Fk_cod_invent_dispositivo=cod_invent_dispositivo where Nombre_Equipo=@nombre"
                cms.Parameters.Add("@nombre", SqlDbType.VarChar, 24).Value = strlNombreEquipo
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me.Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consdrl() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = " select   nombre from activo_inventario_complemento where pertenece='Tipo'or nombre='- Seleccione -'or nombre='Mto. General'order by nombre"
            If _Validacion = 1 Then
                cms.CommandText = " select   nombre from activo_inventario_complemento where pertenece='Mantenimiento'or nombre='- Seleccione -' or nombre='General'order by nombre"
            End If
            If Validacion = 2 Then
                cms.CommandText = " select * from inventario where cod_inventario=@cod"
                cms.Parameters.Add("@Cod", SqlDbType.VarChar, 24).Value = _Cod_Inventario
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Me.Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Licencias() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Archivo_Complemento where Pertenece = '- Seleccione -' or Pertenece = 'Licencia' order by Nombre"
            If Validacion = "Modulos" Then
                cms.CommandText = "Select * from Invent_modulo where Letra <> 'RAC' order by Estado,ID_Modulo"
            End If
            If Validacion = "Filtros" Then
                If Todo <> "" Then
                    cms.CommandText = "Select s.*, i.Fk_ID_Modulo  From Inventario_Software s left join Inventario i on i.Serial = s.Serial_Torre where s.Estado = 'Instalado' and s.Tipo_Licencia = @Tipo_Licencia"
                    cms.Parameters.Add("@Tipo_Licencia", SqlDbType.VarChar, 30).Value = Todo
                End If
                If ID_Modulo <> "" Then
                    cms.CommandText = "Select s.Cod_Registro_Inventario_Software,s.Cod_Inventario,s.Usuario,s.Fc_Reg,s.Producto,s.Version_P,s.Tipo_Licencia,s.Serial_Producto,s.Fecha_Instalacion,s.Observacion,s.Serial_Torre,i.Fk_ID_Modulo From Inventario_Software s inner join Inventario I on s.Cod_Inventario = I.Cod_Inventario where s.Estado = 'Instalado' and  I.Fk_ID_Modulo = @_ID_Modulo"
                    cms.Parameters.Add("@_ID_Modulo", SqlDbType.VarChar, 50).Value = ID_Modulo
                End If
                If Serial_Kamilion <> "" Then
                    cms.CommandText = "Select s.*, i.Fk_ID_Modulo  From Inventario_Software s left join Inventario i on i.Serial = s.Serial_Torre where s.Estado = 'Instalado' and  s.Serial_Torre = @_Serial"
                    cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
                End If
                If Empresa <> "" Then
                    cms.CommandText = "Select s.*, i.Fk_ID_Modulo  From Inventario_Software s left join Inventario i on i.Serial = s.Serial_Torre where s.Estado = 'Instalado' and  s.Producto = @Producto"
                    cms.Parameters.Add("@Producto", SqlDbType.VarChar).Value = Empresa
                End If
            End If
            If Validacion = "Buscar_Todos" Then
                cms.CommandText = "Select s.*, i.Fk_ID_Modulo  From Inventario_Software s left join Inventario i on i.Serial = s.Serial_Torre where s.Estado = 'Instalado'"
            End If
            If Validacion = "Programas" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece = '- Seleccione -' or substring(Pertenece,1,9)  = 'Programas' order by Nombre"
            End If
            If Validacion = "validar_producto" Then

                cms.CommandText = "Select s.*, i.Fk_ID_Modulo  From Inventario_Software s left join Inventario i on i.Serial = s.Serial_Torre where s.Estado = 'Instalado' and Tipo_Licencia = @Tipo_Licencia and Producto = @Producto  and Serial_Torre = @Serial "


                cms.Parameters.Add("@Serial", SqlDbType.VarChar, 50).Value = Letra
                cms.Parameters.Add("@Producto", SqlDbType.VarChar, 300).Value = Descripcion
                cms.Parameters.Add("@Tipo_Licencia", SqlDbType.VarChar, 30).Value = Todo
            End If
            If Validacion = "validar" Then
                cms.CommandText = "select Nombre from Archivo_complemento where Nombre = @Nombre "
                cms.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = Empresa
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cod_Inventario = dts.Tables(0).Rows.Count
            If _Cod_Inventario <= 0 Then
                _Validacion = "1"
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


    Public Function Consulta_Inventario()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _ID_Modulo <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo,I.Modelo,I.Serial,I.Empresa,I.Fk_ID_Modulo,I.Sede,I.Estado from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where I.Fk_ID_Modulo=@_ID_Modulo and id.Nombre_Dispositivo = 'Torre'"
                cms.Parameters.Add("@_ID_Modulo", SqlDbType.VarChar, 50).Value = _ID_Modulo
            End If
            If _Serial_Kamilion <> Nothing Then
                cms.CommandText = "select Cod_Inventario,ID.Nombre_Dispositivo,I.Modelo,I.Serial,I.Empresa,I.Fk_ID_Modulo,I.Sede,I.Estado from Inventario I inner join Invent_Dispositivo ID on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo where id.Nombre_Dispositivo = 'Torre' and I.Serial = @_Serial ORDER BY I.Fk_ID_Modulo"
                cms.Parameters.Add("@_Serial", SqlDbType.VarChar, 50).Value = _Serial_Kamilion
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Inventario") Is DBNull.Value Then
                    _Cod_Inventario = Nothing
                Else
                    _Cod_Inventario = dts.Tables(0).Rows(0).Item("Cod_Inventario")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre_Dispositivo") Is DBNull.Value Then
                    _Nombre_Dispositivo = Nothing
                Else
                    _Nombre_Dispositivo = dts.Tables(0).Rows(0).Item("Nombre_Dispositivo")
                End If
                If dts.Tables(0).Rows(0).Item("Modelo") Is DBNull.Value Then
                    _Modelo = Nothing
                Else
                    _Modelo = dts.Tables(0).Rows(0).Item("Modelo")
                End If
                If dts.Tables(0).Rows(0).Item("Serial") Is DBNull.Value Then
                    _Serial_Kamilion = Nothing
                Else
                    _Serial_Kamilion = dts.Tables(0).Rows(0).Item("Serial")
                End If
                If dts.Tables(0).Rows(0).Item("Empresa") Is DBNull.Value Then
                    _Empresa = Nothing
                Else
                    _Empresa = dts.Tables(0).Rows(0).Item("Empresa")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_ID_Modulo") Is DBNull.Value Then
                    _Sede = Nothing
                Else
                    _Sede = dts.Tables(0).Rows(0).Item("Fk_ID_Modulo")
                End If
                If dts.Tables(0).Rows(0).Item("Estado") Is DBNull.Value Then
                    _Estado = Nothing
                Else
                    _Estado = dts.Tables(0).Rows(0).Item("Estado")
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
    Public Sub Registro_Inventario_Software()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            If Validacion = "Registro_programa" Then
                cms.CommandText = "insert into Archivo_Complemento (Nombre,Pertenece) values (@Programa,@Usuario)"
                cms.Parameters.Add("@Programa", SqlDbType.VarChar, 100).Value = _Empresa
                cms.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = "Programas - " & Id_Usuario & " - " & _FcReg_Invent
            Else
                If Validacion = "Desinstalar" Then
                    cms.CommandText = "Update Inventario_Software set Estado='Desinstalado', Usuario_Desinstalo=@Usuario,Fecha_Desinstalo= @Fecha_desinstalo where Cod_Registro_Inventario_Software = @Cod_Inventario"
                    cms.Parameters.Add("@Fecha_desinstalo", SqlDbType.DateTime).Value = FcReg_Invent
                Else
                    cms.CommandText = "Insert into Inventario_Software (Cod_Inventario,Usuario,Producto,Version_P,Tipo_Licencia,Serial_Producto,Fecha_Instalacion,Observacion,Serial_Torre,Estado) values(  @Cod_Inventario,@Usuario,@Producto,@Version,@Tipo_Licencia,@Serial,@Fecha_Instalacion,@Observacion,@Serial_Torre,'Instalado')"
                    If Validacion = "Actualizacion_Inventario_Software" Then
                        cms.CommandText = "Update Inventario_Software set Producto=@Producto, Version_P=@Version, Tipo_Licencia=@Tipo_Licencia , Serial_Producto = @Serial,Fecha_Instalacion= @Fecha_Instalacion ,Observacion= @Observacion WHERE Cod_Registro_Inventario_Software = @Cod_Inventario"
                    End If
                    cms.Parameters.Add("@Version", SqlDbType.VarChar, 20).Value = Marca
                    cms.Parameters.Add("@Tipo_Licencia", SqlDbType.VarChar, 30).Value = Todo
                    cms.Parameters.Add("@Serial", SqlDbType.VarChar, 30).Value = Serial
                    cms.Parameters.Add("@Fecha_Instalacion", SqlDbType.Date).Value = Dispositivoconsulta
                    cms.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = Observacion
                    cms.Parameters.Add("@Serial_Torre", SqlDbType.VarChar, 50).Value = Letra
                    cms.Parameters.Add("@Producto", SqlDbType.VarChar, 300).Value = Descripcion
                End If
                cms.Parameters.Add("@Cod_Inventario", SqlDbType.BigInt).Value = Cod_Inventario
                If Id_Usuario <> "" Then
                    cms.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Id_Usuario
                End If
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


    Sub excel()
        Using ConexionE As New OleDbConnection(_Fc_ruta)
            Dim Comando As New OleDbCommand
            Comando.CommandText = "Select Cod_Inventario,'" + _Id_Usuario + "' as Usuario,Producto,Version_P,Tipo_Licencia,Serial_Producto,Fecha_Instalacion,Observacion,Serial_Torre, 'Instalado' as Estado from [Hoja1$]"
            Comando.Connection = ConexionE
            Dim Adaptador As New OleDbDataAdapter
            Adaptador.SelectCommand = Comando
            Adaptador.Fill(DteXCEL)
            Dim listaux As New List(Of DataRow)
            For Each dr As DataRow In DteXCEL.Rows
                If dr("Cod_Inventario").ToString = "" Then
                    listaux.Add(dr)
                End If
            Next
            For Each dr As DataRow In listaux
                DteXCEL.Rows.Remove(dr)
            Next
            Cantidad = DteXCEL.Rows.Count
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
        Cantidad = DteXCEL.Rows.Count
        Using Conexion As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
            Conexion.Open()
            Using bulkCopy As New SqlClient.SqlBulkCopy(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
                bulkCopy.DestinationTableName = "Inventario_Software"
                For Each col As DataColumn In DteXCEL.Columns
                    bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName)
                Next
                bulkCopy.WriteToServer(DteXCEL)
            End Using
            Conexion.Close()
        End Using
        Return False
    End Function


    'gestión de componentes
    Public Sub Registrar_Componente()
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim Scm As New SqlClient.SqlCommand
            Dim Sql_Calificacion As String = Nothing
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_Cod_Tipo", _Cod_Tipo)
            Scm.Parameters.AddWithValue("@_Cod_Fabricante", _Cod_Fabricante)
            Scm.Parameters.AddWithValue("@_Referencia", _Referencia)
            Scm.Parameters.AddWithValue("@_Capacidad", _Capacidad)
            Scm.Parameters.AddWithValue("@_Serial", _Serial)
            Scm.Parameters.AddWithValue("@_Descripcion", _Descripcion)
            Scm.Parameters.AddWithValue("@_Id_Usuario", _Id_Usuario)
            Scm.Parameters.AddWithValue("@_Fecha", _FcReg_Invent)
            Scm.CommandText = "Insert Into Invent_Componentes (Tipo_Fk_Cod_Inv_Comp, Fabricante_Fk_Cod_Inv_Comp, Referencia, Capacidad, Serial, Descripcion, Estado_Fk_Cod_Inv_Comp, Fecha_Registro, Usuario_Registra) Values (@_Cod_Tipo, @_Cod_Fabricante, @_Referencia, @_Capacidad, @_Serial, @_Descripcion, (Select Cod From Invent_Complementos Where Categoria_Fk_Cod_Inv_Comp = (Select Cod From Invent_Complementos Where Descripcion Like 'Estados_Componentes') And Descripcion Like 'Activo'), @_Fecha, @_Id_Usuario)"
            Scm.ExecuteNonQuery()
            Scm.Parameters.Clear()
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub
    Public Function Val_Asign_Componente()
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Dts As New DataSet
            Dim Scm As New SqlClient.SqlCommand
            Dim Sql_Calificacion As String = Nothing
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_Serial", _Serial)
            Scm.CommandText = " Select AC.Cod_Comp_Fk_Cod_Inv_Comp From  Invent_Asignacion_Componentes AC Inner Join Invent_Componentes C On C.Cod = AC.Cod_Comp_Fk_Cod_Inv_Comp  Where C.Serial  = @_Serial And (AC.Fecha_Retiro Is Null Or C.Estado_Fk_Cod_Inv_Comp In (Select Cod From Invent_Complementos Where Categoria_Fk_Cod_Inv_Comp = (Select Cod From Invent_Complementos Where Descripcion Like 'Estados_Componentes' And Categoria_Fk_Cod_Inv_Comp Is Null) And (Descripcion Like 'Dañado'))) "
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Scm.Parameters.Clear()
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Sub Asignar_Componente()
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim Scm As New SqlClient.SqlCommand
            Dim Sql_Calificacion As String = Nothing
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_Cod_Equipo", _Cod_Equipo)
            Scm.Parameters.AddWithValue("@_Serial", _Serial)
            Scm.Parameters.AddWithValue("@_Id_Usuario", _Id_Usuario)
            Scm.Parameters.AddWithValue("@_Fecha", _FcReg_Invent)
            Scm.Parameters.AddWithValue("@_Descripcion", _Descripcion)
            Scm.CommandText = "Insert Into Invent_Asignacion_Componentes (Cod_Equipo_Fk_Cod_Inv, Cod_Comp_Fk_Cod_Inv_Comp, Fecha_Asignacion, Usuario_Asigna, Observacion_Aigna) Values (@_Cod_Equipo, (Select Cod From Invent_Componentes Where Serial Like @_Serial), @_Fecha, @_Id_Usuario, @_Descripcion)"
            Scm.ExecuteNonQuery()
            Scm.Parameters.Clear()
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub
    Public Function Liberar_Componente()
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim Scm As New SqlClient.SqlCommand
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_DateTime", _FcReg_Invent)
            Scm.Parameters.AddWithValue("@_Usuario", _Id_Usuario)
            Scm.Parameters.AddWithValue("@_Cod_Com", _Cod_Componente)
            Scm.Parameters.AddWithValue("@_Observacion", _Observacion)
            Scm.CommandText = "Update Top(1) Invent_Asignacion_Componentes Set Fecha_Retiro = @_DateTime, Usuario_Retira = @_Usuario, Observacion_Retira = @_Observacion Where Cod_Comp_Fk_Cod_Inv_Comp = @_Cod_Com And Fecha_Retiro Is Null"
            Return Scm.ExecuteNonQuery()
            Scm.Parameters.Clear()
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Actualizar_Componente()
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Try
            Dim Scm As New SqlClient.SqlCommand
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_Cod_Com", _Cod_Componente)
            Scm.Parameters.AddWithValue("@_Cod_Estado", _Cod_Estado)
            Scm.CommandText = "Update Top(1) Invent_Componentes Set Estado_Fk_Cod_Inv_Comp = @_Cod_Estado Where Cod = @_Cod_Com And @_Cod_Estado In (select Cod From Invent_Complementos where Descripcion not Like 'Asignado' And Categoria_Fk_Cod_Inv_Comp = (Select top 1 Cod From Invent_Complementos where Descripcion Like 'Estados_Componentes' and Categoria_Fk_Cod_Inv_Comp Is Null))"
            Return Scm.ExecuteNonQuery()
            Scm.Parameters.Clear()
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Consultar_Componentes(ByVal Asign As Boolean)
        Try
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Dts As New DataSet
            Dim Scm As New SqlClient.SqlCommand
            Con_Admin.Open()
            Dim Frag As String = ""
            Dim FragSub As String = ""
            If _Cod_Tipo <> Nothing Then
                Scm.Parameters.AddWithValue("@_Cod_Tipo", _Cod_Tipo)
                Frag = Frag & " And C.Tipo_Fk_Cod_Inv_Comp = @_Cod_Tipo "
            End If
            If _Cod_Fabricante <> Nothing Then
                Scm.Parameters.AddWithValue("@_Cod_Fabricante", _Cod_Fabricante)
                Frag = Frag & " And C.Fabricante_Fk_Cod_Inv_Comp = @_Cod_Fabricante "
            End If
            If _Referencia <> Nothing Then
                Scm.Parameters.AddWithValue("@_Referencia", _Referencia)
                Frag = Frag & " And C.Referencia Like @_Referencia "
            End If
            If _Capacidad <> Nothing Then
                Scm.Parameters.AddWithValue("@_Capacidad", _Capacidad)
                Frag = Frag & " And C.Capacidad Like @_Capacidad "
            End If
            If _Serial <> Nothing Then
                Scm.Parameters.AddWithValue("@_Serial", _Serial)
                Frag = Frag & " And C.Serial Like @_Serial "
            End If
            If _Cod_Estado <> Nothing Then
                Scm.Parameters.AddWithValue("@_Cod_Estado", _Cod_Estado)
                Frag = Frag & " And C.Estado_Fk_Cod_Inv_Comp = @_Cod_Estado "
            End If
            If Asign = False Then
                Frag = Frag & " And C.Estado_Fk_Cod_Inv_Comp Not In (select Cod From Invent_Complementos where (Descripcion Like 'Asignado' Or Descripcion Like 'Dañado' Or Descripcion Like 'Baja') And Categoria_Fk_Cod_Inv_Comp = (select Cod From Invent_Complementos where Descripcion Like 'Estados_Componentes')) "
            Else
                FragSub = " Select Com.Cod_Comp_Fk_Cod_Inv_Comp As Cod_Com, Convert(Varchar,Com.Fecha_Asignacion) As Fecha_Asignacion, Com.Usuario_Asigna, Convert(Varchar,Com.Fecha_Retiro) As Fecha_Retiro, Com.Usuario_Retira, Com.Observacion_Aigna, Com.Observacion_Retira, Dis.Serial As Serial_Equi, Dis.Serial_Kamilion As Serial_K_Equi, TD.Nombre_Dispositivo As Tipo_Equi From Invent_Asignacion_Componentes Com Inner Join  Inventario Dis On Dis.Cod_Inventario = Com.Cod_Equipo_Fk_Cod_Inv Inner Join Invent_Dispositivo TD On TD.Cod_Invent_Dispositivo = Dis.Fk_Cod_Invent_Dispositivo Where Com.Cod_Comp_Fk_Cod_Inv_Comp In (Select Cod From @_Componentes) Order By Com.Cod_Comp_Fk_Cod_Inv_Comp Desc , Com.Fecha_Asignacion Desc "
            End If
            Scm.Connection = Con_Admin
            Scm.CommandText = " Declare @_Componentes Table (Cod Int, Cod_Ac Int, Tipo Varchar(40), Fabricante Varchar(40), Capacidad Varchar(50), Referencia Varchar(50), Serial Varchar(50), Descripcion Varchar(50), Estado Varchar(40)) Insert Into @_Componentes Select C.Cod, C.Cod As Cod_Ac, CT.Descripcion As Tipo, CF.Descripcion AS Fabricante, C.Capacidad, C.Referencia, Serial, C.Descripcion, CE.Descripcion As Estado From ( Select Cod, Tipo_Fk_Cod_Inv_Comp, Fabricante_Fk_Cod_Inv_Comp, Referencia, Capacidad, Serial, Descripcion, Case When (Select Count(Cod_Comp_Fk_Cod_Inv_Comp) From Invent_Asignacion_Componentes Where Fecha_Retiro Is Null And Cod_Comp_Fk_Cod_Inv_Comp = Cod)>0 Then ( Select Cod From Invent_Complementos Where Descripcion Like 'Asignado' And Categoria_Fk_Cod_Inv_Comp = (Select Cod From Invent_Complementos Where Descripcion Like 'Estados_Componentes' And Categoria_Fk_Cod_Inv_Comp Is Null) ) Else Estado_Fk_Cod_Inv_Comp End As Estado_Fk_Cod_Inv_Comp From Invent_Componentes) C Inner Join Invent_Complementos CE On C.Estado_Fk_Cod_Inv_Comp = CE.Cod Inner Join Invent_Complementos CT On C.Tipo_Fk_Cod_Inv_Comp = CT.Cod Inner Join Invent_Complementos CF On C.Fabricante_Fk_Cod_Inv_Comp = CF.Cod Where 1=1 " & Frag & " Select * From @_Componentes " & FragSub
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Scm.Parameters.Clear()
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            If Con_Admin.State = ConnectionState.Open Then
                Con_Admin.Close()
            End If
        End Try
    End Function
    Public Function Cons_Drl_HIstorial_Equipo()
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim Dta As SqlClient.SqlDataAdapter
        Dim Dts As New DataSet
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con.Open()
            Scm.Connection = Con
            Scm.CommandText = "Select Cod, Descripcion From Invent_Complementos Where Categoria_Fk_Cod_Inv_Comp = (Select Cod From Invent_Complementos Where Descripcion Like 'Estados_Componentes') Or Cod = 0 Select Cod, Descripcion From Invent_Complementos Where Categoria_Fk_Cod_Inv_Comp = (Select Cod From Invent_Complementos Where Descripcion Like 'Tipos_Componentes') Or Cod = 0 Select Cod, Descripcion From Invent_Complementos Where Categoria_Fk_Cod_Inv_Comp = (Select Cod From Invent_Complementos Where Descripcion Like 'Fabricantes_Componentes') Or Cod = 0 Select Distinct Capacidad As Cod, Capacidad As Descripcion From Invent_Componentes Union Select null, '-Seleccione-' order by cod Select DISTINCT Estado As Cod, Estado As Descripcion From Inventario Where Estado Is Not Null Union Select null, '-Seleccione-' order by cod Select Cod_Invent_Dispositivo As Cod, Nombre_Dispositivo As Descripcion from Invent_Dispositivo where Tipo like 'Electronico' and( Nombre_Dispositivo Like 'Torre' or Nombre_Dispositivo Like 'portatil' or Nombre_Dispositivo Like 'PATCH PANEL' or Nombre_Dispositivo Like 'servidor'or Nombre_Dispositivo Like 'nas') union select 0, '-Seleccione-' order by Cod Select DISTINCT Marca As Cod, Marca As Descripcion From Inventario Where Marca Is Not Null Union Select null, '-Seleccione-' order by cod"

            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Cons_Equipos_Componentes_Historial()
        Try
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Dts As New DataSet
            Dim Scm As New SqlClient.SqlCommand

            Dim Frag As String = ""
            If _Cod_Tipo <> Nothing Then
                Scm.Parameters.AddWithValue("@_Cod_Tipo", _Cod_Tipo)
                Frag = Frag & " And Fk_Cod_Invent_Dispositivo = @_Cod_Tipo "
            End If
            If _Marca <> Nothing Then
                Scm.Parameters.AddWithValue("@_Fabricante", _Marca)
                Frag = Frag & " And I.Marca Like @_Fabricante "
            End If
            If _Referencia <> Nothing Then
                Scm.Parameters.AddWithValue("@_Referencia", _Referencia)
                Frag = Frag & " And I.Modelo Like @_Referencia "
            End If
            If _Serial <> Nothing Then
                Scm.Parameters.AddWithValue("@_Serial", _Serial)
                Frag = Frag & " And I.Serial Like  @_Serial "
            End If
            If _Serial_Kamilion <> Nothing Then
                Scm.Parameters.AddWithValue("@_Serial_K", _Serial_Kamilion)
                Frag = Frag & " And I.Serial_Kamilion Like  @_Serial_K "
            End If
            If _Estado <> Nothing Then
                Scm.Parameters.AddWithValue("@_Estado", _Estado)
                Frag = Frag & " And I.Estado Like @_Estado "
            End If
            Con_Admin.Open()
            Scm.Connection = Con_Admin
            Scm.CommandText = "Declare @Equipos Table (Cod Int, Tipo varchar(20), Fabricante Varchar(50), Referencia Varchar(50), Serial Varchar(50), Serial_Kamilion Varchar(50), Estado Varchar(50)) Insert Into @Equipos select Cod_Inventario As Cod, ID.Nombre_Dispositivo as Tipo, I.Marca As Fabricante, I.Modelo As Referencia, I.Serial, I.Serial_Kamilion, I.Estado from Inventario I inner join Invent_Dispositivo Id on i.Fk_Cod_Invent_Dispositivo = ID.Cod_Invent_Dispositivo And Id.Tipo like 'Electronico' and (Id.Nombre_Dispositivo Like 'Torre' or Id.Nombre_Dispositivo Like 'portatil' or Id.Nombre_Dispositivo Like 'PATCH PANEL' or Id.Nombre_Dispositivo Like 'servidor'or Id.Nombre_Dispositivo Like 'nas') where 1=1 " & Frag & " Select * From @Equipos " &
                " Select C.Cod, EC.Cod_Equipo_Fk_Cod_Inv, CT.Descripcion As Tipo, CF.Descripcion As Fabricante, C.Referencia, C.Capacidad, C.Serial, C.Descripcion, CE.Descripcion As Estado From Invent_Componentes C Inner Join Invent_Complementos CE On C.Estado_Fk_Cod_Inv_Comp = CE.Cod Inner Join Invent_Complementos CT On C.Tipo_Fk_Cod_Inv_Comp = CT.Cod Inner Join Invent_Complementos CF On C.Fabricante_Fk_Cod_Inv_Comp = CF.Cod Inner Join Invent_Asignacion_Componentes EC On C.Cod = EC.Cod_Comp_Fk_Cod_Inv_Comp Where EC.Fecha_Retiro Is Null And EC.Cod_Equipo_Fk_Cod_Inv In (Select Cod From @Equipos)"
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            If Con_Admin.State = ConnectionState.Open Then
                Con_Admin.Close()
            End If
        End Try
    End Function
    Sub Xls_To_Datatable_Com()
        Try
            Using Con As New OleDbConnection(_Fc_ruta)
                Dim Ocm As New OleDbCommand
                Ocm.Parameters.AddWithValue("@_Usuario", _FcReg_Invent)
                Ocm.Parameters.AddWithValue("@_Fecha", _Id_Usuario)
                Ocm.CommandText = "select Tipo,Fabricante,Referencia,Capacidad,Serial,Descripcion,Estado, @_Fecha As Fecha, @_Usuario As Usuario  from [Hoja1$]"
                Ocm.Connection = Con
                Dim ODta As New OleDbDataAdapter
                ODta.SelectCommand = Ocm
                ODta.Fill(DteXCEL)
                Con.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function Xls_Componentes_To_Sql()
        Xls_To_Datatable_Com()
        Dim Val = Validar_Xls_Componentes()
        If Val = Nothing Then
            Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
            Try
                Dim Scm As New SqlClient.SqlCommand
                Dim Sql_Calificacion As String = Nothing
                Con.Open()
                Scm.Connection = Con
                Scm.CommandText = "Insert Into Invent_Componentes (Tipo_Fk_Cod_Inv_Comp,Fabricante_Fk_Cod_Inv_Comp,Referencia,Capacidad,Serial,Descripcion,Estado_Fk_Cod_Inv_Comp,Fecha_Registro,Usuario_Registra) Values (@_Tipo, @_Fabricante, @_Referencia, @_Capacidad, @_Serial, @_Descripcion, @_Estado, @_Fecha, @_Usuario)"
                For Each Row As DataRow In DteXCEL.Rows
                    Scm.Parameters.AddWithValue("@_Tipo", Row("Tipo").trim)
                    Scm.Parameters.AddWithValue("@_Fabricante", Row("Fabricante").ToString.Trim)
                    Scm.Parameters.AddWithValue("@_Referencia", Row("Referencia").ToString.Trim)
                    Scm.Parameters.AddWithValue("@_Capacidad", Row("Capacidad").ToString.Trim)
                    Scm.Parameters.AddWithValue("@_Serial", Row("Serial").ToString.Trim)
                    Scm.Parameters.AddWithValue("@_Descripcion", Row("Descripcion").ToString.Trim)
                    Scm.Parameters.AddWithValue("@_Estado", Row("Estado").trim)
                    Scm.Parameters.AddWithValue("@_Fecha", Row("Fecha").trim)
                    Scm.Parameters.AddWithValue("@_Usuario", Row("Usuario").ToString.Trim)
                    Scm.ExecuteNonQuery()
                    Scm.Parameters.Clear()
                Next
            Catch ex As Exception
                Throw ex
            Finally
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
            End Try
        End If
        Return Val
    End Function
    Public Function Validar_Xls_Componentes()
        Dim Dts As New DataSet
        Try
            Dim Text As String = Nothing
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Scm As New SqlClient.SqlCommand
            Con_Admin.Open()
            Scm.Connection = Con_Admin
            Scm.CommandText = "SELECT Cod ,Descripcion ,Valor ,Categoria_Fk_Cod_Inv_Comp FROM Invent_Complementos; Select Serial From Invent_Componentes"
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Dim Count As Integer = 0
            For Each Row As DataRow In DteXCEL.Rows
                'evaluar columnas de caracter obligatorio
                For Each Column As DataColumn In DteXCEL.Columns
                    If Row(Column).ToString.Trim = Nothing Then
                        Return "Error En la Fila " & Count + 1 & ": la columna " & Column.ColumnName & " es de caracter obligatorio"
                        Exit Function
                    End If
                Next
                'validar seriales
                For Each Row_Comp As DataRow In Dts.Tables(1).Rows
                    If Row_Comp("Serial").ToString.Trim = Row("Serial").ToString.Trim Then
                        Return "¡Error! en la fila " & Count + 1 & ": ya se encuentra registrado un componentes con el serial " & Chr(34) & Row("Serial") & Chr(34)
                        Exit Function
                    End If
                Next
                'validar y convertir tipos
                Try
                    DteXCEL.Rows(Count).Item("Tipo") = Dts.Tables(0).Select("Descripcion Like '" & Row("Tipo").ToString.Trim & "' And Categoria_Fk_Cod_Inv_Comp = '" & Dts.Tables(0).Select("Descripcion Like 'Tipos_Componentes' And Categoria_Fk_Cod_Inv_Comp Is Null")(0)("Cod") & "' ")(0)("Cod")
                Catch ex As Exception
                    Return "¡Error! No es posible convertir texto " & Chr(34) & DteXCEL.Rows(Count).Item("Tipo") & Chr(34) & " de la columna Tipo en la fila " & Count + 1
                    Exit Function
                End Try
                'validar y convertir fabricantes
                Try
                    DteXCEL.Rows(Count).Item("Fabricante") = Dts.Tables(0).Select("Descripcion Like '" & Row("Fabricante").ToString.Trim & "' And Categoria_Fk_Cod_Inv_Comp = '" & Dts.Tables(0).Select("Descripcion Like 'Fabricantes_Componentes' And Categoria_Fk_Cod_Inv_Comp Is Null")(0)("Cod") & "' ")(0)("Cod")
                Catch ex As Exception
                    Return "¡Error! No es posible convertir texto " & Chr(34) & DteXCEL.Rows(Count).Item("Fabricante") & Chr(34) & " de la columna Fabricante en la Fila " & Count + 1
                    Exit Function
                End Try
                'validar y convertir estados
                Try
                    DteXCEL.Rows(Count).Item("Estado") = Dts.Tables(0).Select("Descripcion Like '" & Row("Estado").ToString.Trim & "' And Descripcion Not Like 'Asignado' And Categoria_Fk_Cod_Inv_Comp = '" & Dts.Tables(0).Select("Descripcion Like 'Estados_Componentes' And Categoria_Fk_Cod_Inv_Comp Is Null")(0)("Cod") &
                        "' ")(0)("Cod")
                Catch ex As Exception
                    Return "¡Error! No es posible convertir texto " & Chr(34) & DteXCEL.Rows(Count).Item("Estado") & Chr(34) & " de la columna Estado en la fila " & Count + 1
                    Exit Function
                End Try
                'validar cracteres de capacidad
                If Row("Capacidad").ToString.Trim.Length > 50 Then
                    Return "¡Error! en la fila " & Count + 1 & "; El texto " & Chr(34) & Row("Capacidad").ToString.Trim & Chr(34) & " de la coluna Capacidad exede el número de caracteres permitidos"
                    Exit Function
                End If
                'Validar caracteres de Referencia
                If Row("Referencia").ToString.Trim.Length > 50 Then
                    Return "¡Error! en la fila " & Count + 1 & "; El texto " & Chr(34) & Row("Referencia").ToString.Trim & Chr(34) & " de la coluna Referencia exede el número de caracteres permitidos"
                    Exit Function
                End If
                'Validar caracteres de Seriales
                If Row("Serial").ToString.Trim.Length > 50 Then
                    Return "¡Error! en la fila " & Count + 1 & "; El texto " & Chr(34) & Row("Serial").ToString.Trim & Chr(34) & " de la coluna Serial exede el número de caracteres permitidos"
                    Exit Function
                End If

                Count = Count + 1
            Next
            Return Nothing
        Catch ex As Exception
            Throw ex
        Finally
            If Con_Admin.State = ConnectionState.Open Then
                Con_Admin.Close()
            End If
        End Try
    End Function

    Public Function Consultar_Inventario()
        Dim Con = Con_Admin
        Dim Dta As SqlClient.SqlDataAdapter
        Dim Dts As New DataSet
        Dim Scm As New SqlClient.SqlCommand
        Dim Sql_Frag As String = Nothing

        If _Cod_Inventario <> Nothing Then
            Scm.Parameters.AddWithValue("@_Cod_Inventario", _Cod_Inventario)
            Sql_Frag = "And Cod_Inventario = @_Cod_Inventario"
        Else
            If _Serial_Kamilion <> Nothing Then
                Scm.Parameters.AddWithValue("@_Serial_Kamilion", _Serial_Kamilion)
                Sql_Frag = Sql_Frag & "And Serial_Kamilion = @_Serial_Kamilion "
            End If
            If _Serial <> Nothing Then
                Scm.Parameters.AddWithValue("@_Serial", _Serial)
                Sql_Frag = Sql_Frag & "And Serial = @_Serial "
            End If
            If _Fk_Cod_Invent_Dispositivo <> Nothing Then
                Scm.Parameters.AddWithValue("@_Fk_Cod_Invent_Dispositivo", _Fk_Cod_Invent_Dispositivo)
                Sql_Frag = Sql_Frag & "And Fk_Cod_Invent_Dispositivo = @_Fk_Cod_Invent_Dispositivo "
            End If
        End If
        Try
            Con.Open()
            Scm.Connection = Con
            Scm.CommandText = "Select I.Cod_Inventario, I.Fk_Cod_Invent_Dispositivo, I.FcReg_Invent, I.Id_Usuario, I.Marca, I.Modelo, I.Serial, I.Empresa, I.Fk_ID_Modulo, I.Sede, I.Estado, I.Serial_Kamilion, I.Cod_Agente, I.Descripcion, I.Fc_Adquisicion From Inventario I Where 1 = 1 " & Sql_Frag
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Cambiar_Estado()
        Dim Con = Con_Admin
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_Cod_Inventario", _Cod_Inventario)
            Scm.Parameters.AddWithValue("@_Estado", _Estado)
            Scm.CommandText = "update Inventario set Estado=@_Estado where Cod_Inventario = @_Cod_Inventario"
            If Scm.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Registrar_Gestion_Dispositivo() As Boolean
        Dim Con = Con_Admin
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con.Open()
            Scm.Connection = Con
            Scm.Parameters.AddWithValue("@_FecReg_InventD", _FecReg_InventD)
            Scm.Parameters.AddWithValue("@_Id_Usuario", _Id_Usuario)
            Scm.Parameters.AddWithValue("@_Observacion", _Observacion)
            Scm.Parameters.AddWithValue("@_Cod_Inventario", _Cod_Inventario)
            Scm.Parameters.AddWithValue("@_ID_Modulo", _ID_Modulo)
            Scm.Parameters.AddWithValue("@_Estado", _Estado)
            Scm.CommandText = "Insert into Invent_Detalle (FecReg_InventD, Id_Usuario, Observacion, Fk_Cod_Inventario, Fk_ID_Modulo, Estado) values (@_FecReg_InventD, @_Id_Usuario, @_Observacion, @_Cod_Inventario, @_ID_Modulo, @_Estado)"

            If Scm.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
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
