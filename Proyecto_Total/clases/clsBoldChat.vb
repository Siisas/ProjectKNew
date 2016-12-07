Public Class clsBoldChat
    'Bandeja Bolchat'
    Protected _Idcaso As Int64
    Protected _Ing_Remite As String
    Protected _Idusuario As String
    Protected _Cas_Fecha_Registro As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Cas_Fecha_Recepcion As String
    Protected _Recomen_Prioridad As String
    Protected _Tipo As Integer
    Protected _Tipo_Soporte As Integer
    Protected _Segmento As Integer
    Protected _Min_Ac As Int64
    Protected _Nom_Cliente As String
    Protected _Equipo_Ac As String
    Protected _Bandeja As String
    Protected _Cantidad As Integer
    Protected strlestado As String
    Protected strlidtipo As Integer
    Protected _Fecha_Inicio As String
    Protected _Fecha_Fin As String
    Protected _Fecha_Inicio_Gestion As String
    Protected _Fecha_Fin_Gestion As String

    Public Property Fecha_Inicio_Gestion As String
        Get
            Return _Fecha_Inicio_Gestion
        End Get
        Set(ByVal value As String)
            _Fecha_Inicio_Gestion = value
        End Set
    End Property
    Public Property Fecha_Fin_Gestion As String
        Get
            Return _Fecha_Fin_Gestion
        End Get
        Set(ByVal value As String)
            _Fecha_Fin_Gestion = value
        End Set
    End Property


    Public Property Idcaso As Int64
        Get
            Return _Idcaso
        End Get
        Set(ByVal value As Int64)
            _Idcaso = value
        End Set
    End Property
    Public Property Ing_Remite As String
        Get
            Return _Ing_Remite
        End Get
        Set(ByVal value As String)
            _Ing_Remite = value
        End Set
    End Property
    Public Property Idusuario As String
        Get
            Return _Idusuario
        End Get
        Set(ByVal value As String)
            _Idusuario = value
        End Set
    End Property
    Public Property Cas_Fecha_Registro As String
        Get
            Return _Cas_Fecha_Registro
        End Get
        Set(ByVal value As String)
            _Cas_Fecha_Registro = value
        End Set
    End Property
    Public Property Cas_Fecha_Recepcion As String
        Get
            Return _Cas_Fecha_Recepcion
        End Get
        Set(ByVal value As String)
            _Cas_Fecha_Recepcion = value
        End Set
    End Property
    Public Property Recomen_Prioridad As String
        Get
            Return _Recomen_Prioridad
        End Get
        Set(ByVal value As String)
            _Recomen_Prioridad = value
        End Set
    End Property
    Public Property Tipo As Integer
        Get
            Return _Tipo
        End Get
        Set(ByVal value As Integer)
            _Tipo = value
        End Set
    End Property
    Public Property Tipo_Soporte As Integer
        Get
            Return _Tipo_Soporte
        End Get
        Set(ByVal value As Integer)
            _Tipo_Soporte = value
        End Set
    End Property
    Public Property Segmento As Integer
        Get
            Return _Segmento
        End Get
        Set(ByVal value As Integer)
            _Segmento = value
        End Set
    End Property
    Public Property Min_Ac As Int64
        Get
            Return _Min_Ac
        End Get
        Set(ByVal value As Int64)
            _Min_Ac = value
        End Set
    End Property
    Public Property Nom_Cliente As String
        Get
            Return _Nom_Cliente
        End Get
        Set(ByVal value As String)
            _Nom_Cliente = value
        End Set
    End Property
    Public Property Equipo_Ac As String
        Get
            Return _Equipo_Ac
        End Get
        Set(ByVal value As String)
            _Equipo_Ac = value
        End Set
    End Property
    Public Property Bandeja As String
        Get
            Return _Bandeja
        End Get
        Set(ByVal value As String)
            _Bandeja = value
        End Set
    End Property
    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return strlestado
        End Get
        Set(ByVal value As String)
            strlestado = value
        End Set
    End Property
    Public Property idtip As String
        Get
            Return strlidtipo
        End Get
        Set(ByVal value As String)
            strlidtipo = value
        End Set
    End Property
    Public Property Fecha_Inicio As String
        Get
            Return _Fecha_Inicio
        End Get
        Set(ByVal value As String)
            _Fecha_Inicio = value
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

    Public Sub IngresarCasoBandeja_Bolt()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "insert into Bandeja_Bolt (Idcaso,Ing_Remite,idusuario,Cas_Fecha_Registro,Cas_Fecha_Recepcion,Recomen_Prioridad,Tipo,Segmento,Tipo_Soporte,Min_Ac,Nom_Cliente,Equipo_Ac,Bandeja) values (@_Idcaso,@_Ing_Remite,@_Idusuario,@_Cas_Fecha_registro,@_Cas_Fecha_Recepcion,@_Recomen_Prioridad,@_Tipo,@_Segmento,@_Tipo_Soporte,@_Min_Ac,@_Nom_Cliente,@_Equipo_Ac,@_Bandeja)"
            cms.Parameters.Add("@_Idcaso", SqlDbType.BigInt).Value = _Idcaso
            cms.Parameters.Add("@_Ing_Remite", SqlDbType.VarChar, 255).Value = _Ing_Remite
            cms.Parameters.Add("@_Idusuario", SqlDbType.VarChar, 50).Value = _Idusuario
            cms.Parameters.Add("@_Cas_Fecha_registro", SqlDbType.DateTime).Value = _Cas_Fecha_Registro
            cms.Parameters.Add("@_Cas_Fecha_Recepcion", SqlDbType.DateTime).Value = _Cas_Fecha_Recepcion
            cms.Parameters.Add("@_Recomen_Prioridad", SqlDbType.VarChar, 10).Value = _Recomen_Prioridad
            cms.Parameters.Add("@_Tipo", SqlDbType.Int).Value = _Tipo
            cms.Parameters.Add("@_Segmento", SqlDbType.Int).Value = _Segmento
            cms.Parameters.Add("@_Tipo_Soporte", SqlDbType.Int).Value = _Tipo_Soporte
            cms.Parameters.Add("@_Min_Ac", SqlDbType.BigInt).Value = _Min_Ac
            cms.Parameters.Add("@_Nom_Cliente", SqlDbType.VarChar, 255).Value = _Nom_Cliente
            cms.Parameters.Add("@_Equipo_Ac", SqlDbType.VarChar, 100).Value = _Equipo_Ac
            cms.Parameters.Add("@_Bandeja", SqlDbType.VarChar, 50).Value = _Bandeja
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
    Public Function Consultacasos_Bolchat() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cnDatos.Open()
            cms.CommandText = "select BB.Cod_Bandeja_Bolt, BB.Idcaso, BB.Ing_Remite, BB.Idusuario, BB.Cas_Fecha_Registro, BB.Cas_Fecha_Recepcion, BB.Recomen_Prioridad, BT.Nombre as Tipo, BS.Nombre as Segmento, BB.Min_Ac, BB.Nom_Cliente, BB.Equipo_Ac, BTS.Nombre as Tipo_Soporte, BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo = BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join Bol_TS BTS on BB.Tipo_Soporte = BTS.Cod_Bol_TS where Idcaso=@_Caso Order by BB.Cod_Bandeja_Bolt Desc"
            cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = _Idcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cnDatos.State = ConnectionState.Open Then
                cnDatos.Close()
            End If
        End Try
    End Function
    Public Function ConsultaBandeja_Bolt_Numero_NomCliente() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            'Consulta min
            If _Min_Ac <> Nothing Then
                cms.CommandText = "select BB.Idcaso as 'Caso',BB.Ing_Remite as 'Ing Remite',BB.Cas_Fecha_Registro as 'Fecha registro',BB.Min_Ac,BB.Nom_Cliente as 'Cliente',BB.Equipo_Ac,BB.Idusuario as 'Agente',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',BB.Recomen_Prioridad as 'Prioridad',BT.Nombre as' Tipo',BS.Nombre as 'Segmento',BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where BB.Min_Ac=@_Min_Ac"
                cms.Parameters.Add("@_Min_Ac", SqlDbType.BigInt).Value = _Min_Ac
            End If
            'Consulta Nombre
            If _Nom_Cliente <> Nothing Then
                cms.CommandText = "select BB.Idcaso as 'Caso',BB.Ing_Remite as 'Ing Remite',BB.Cas_Fecha_Registro as 'Fecha registro',BB.Min_Ac,BB.Nom_Cliente as 'Cliente',BB.Equipo_Ac,BB.Idusuario as 'Agente',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',BB.Recomen_Prioridad as 'Prioridad',BT.Nombre as' Tipo',BS.Nombre as 'Segmento',BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where BB.Nom_Cliente like '%'+@_Nom_Cliente+'%'"
                cms.Parameters.Add("@_Nom_Cliente", SqlDbType.VarChar, 100).Value = _Nom_Cliente
            End If
            'Consulta por Fecha inicio
            If _Fecha_Inicio <> Nothing Then
                cms.CommandText = "select BB.Idcaso as 'Caso',BB.Ing_Remite as 'Ing Remite',BB.Cas_Fecha_Registro as 'Fecha registro',BB.Min_Ac,BB.Nom_Cliente as 'Cliente',BB.Equipo_Ac,BB.Idusuario as 'Agente',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',BB.Recomen_Prioridad as 'Prioridad',BT.Nombre as 'Tipo',BS.Nombre as 'Segmento',BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where Cas_Fecha_Registro >= @_Fecha_Inicio"
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.Date).Value = _Fecha_Inicio
            End If
            'Consulta por Fecha Fin
            If _Fecha_Fin <> Nothing Then
                cms.CommandText = "select BB.Idcaso as 'Caso',BB.Ing_Remite as 'Ing Remite',BB.Cas_Fecha_Registro  as 'Fecha registro',BB.Min_Ac,BB.Nom_Cliente as 'Cliente',BB.Equipo_Ac,BB.Idusuario as 'Agente',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',BB.Recomen_Prioridad as 'Prioridad',BT.Nombre as 'Tipo',BS.Nombre as 'Segmento',BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where Cas_Fecha_Registro <= @_Fecha_Fin"
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.Date).Value = _Fecha_Fin
            End If
            'Nombre y min
            If _Min_Ac <> Nothing And _Nom_Cliente <> Nothing Then
                cms.CommandText = "select BB.Idcaso as 'Caso',BB.Ing_Remite as 'Ing Remite',BB.Cas_Fecha_Registro  'Fecha registro',BB.Min_Ac,BB.Nom_Cliente as 'Cliente',BB.Equipo_Ac,BB.Idusuario as 'Agente',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',BB.Recomen_Prioridad as 'Prioridad',BT.Nombre as 'Tipo',BS.Nombre as 'Segmento',BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' or BB.Min_Ac=@_Min_Ac"
            End If
            'Min, nombre y fecha inicio
            If _Min_Ac <> Nothing And _Nom_Cliente <> Nothing And _Fecha_Inicio <> Nothing Then
                cms.CommandText = "select BB.Idcaso as 'Caso',BB.Ing_Remite as 'Ing Remite',BB.Cas_Fecha_Registro as  'Fecha registro',BB.Min_Ac,BB.Nom_Cliente as 'Cliente',BB.Equipo_Ac,BB.Idusuario as 'Agente',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',,BB.Recomen_Prioridad as 'Prioridad',BT.Nombre as 'Tipo',BS.Nombre as 'Segmento',BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' or BB.Min_Ac=@_Min_Ac and Cas_Fecha_Registro >= @_Fecha_Inicio"
            End If
            'Consulta entre Fecha inicio y fecha fin
            If _Fecha_Inicio <> Nothing And _Fecha_Fin <> Nothing Then
                cms.CommandText = "select BB.Idcaso as 'Caso',BB.Ing_Remite as 'Ing Remite',BB.Cas_Fecha_Registro as 'Fecha registro',BB.Min_Ac,BB.Nom_Cliente as 'Cliente',BB.Equipo_Ac,BB.Idusuario as 'Agente',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',BB.Recomen_Prioridad as 'Prioridad',BT.Nombre as 'Tipo',BS.Nombre as 'Segmento',BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where Cas_Fecha_Registro between  @_Fecha_Inicio and @_Fecha_Fin"
            End If
            'Min, Nombre, entre Fecha inicio y fecha fin
            If _Min_Ac <> Nothing And _Nom_Cliente <> Nothing And _Fecha_Inicio <> Nothing And _Fecha_Fin <> Nothing Then
                cms.CommandText = "select BB.Idcaso as 'Caso',BB.Ing_Remite as 'Ing Remite',BB.Cas_Fecha_Registro as 'Fecha registro',BB.Min_Ac,BB.Nom_Cliente as 'Cliente',BB.Equipo_Ac,BB.Idusuario as 'Agente',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',BB.Recomen_Prioridad as 'Prioridad',BT.Nombre as 'Tipo',BS.Nombre as 'Segmento',BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' or BB.Min_Ac=@_Min_Ac and Cas_Fecha_Registro between  @_Fecha_Inicio and @_Fecha_Fin"
            End If
            'Consulta por caso
            If _Idcaso <> Nothing Then
                cms.CommandText = "select BB.Idcaso as 'Caso',BB.Ing_Remite as 'Ing Remite',BB.Cas_Fecha_Registro as 'Fecha registro',BB.Min_Ac,BB.Nom_Cliente as 'Cliente',BB.Equipo_Ac,BB.Idusuario as 'Agente',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',BB.Recomen_Prioridad as 'Prioridad',BT.Nombre as 'Tipo',BS.Nombre as 'Segmento',BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where BB.Idcaso=@_Idcaso"
                cms.Parameters.Add("@_Idcaso", SqlDbType.BigInt).Value = _Idcaso
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
    Public Function Consulta_seguimiento() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim cnVoz As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cnDatos.Open()
            cms.CommandText = "select fallared,idcaso, min_ac, fcreg, idusuario, obs, Tipificacion, numalt from CRMDetalle inner join Bandeja on CRMDetalle.idcaso=Bandeja.cas_id where idcaso=@_Idcaso order by fcreg"
            cms.Parameters.Add("@_Idcaso", SqlDbType.Int).Value = _Idcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If (_Cantidad > 0) Then

            Else
                cnVoz.Open()
                cms.CommandText = "select B.idcaso,min_ac,fcreg,idusuario,obs,VT.estagogest,numalt,fallared from VCRMDetalle VCRM inner join Bandeja_uni B on B.idcaso=VCRM.idcaso inner join VTiposoporte VT on VCRM.tiposoporte = VT.idtipo where B.idcaso=@_Idcaso ORDER BY idcrm DESC"
                'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = _Idcaso
                cms.Connection = cnVoz
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                _Cantidad = dts.Tables(0).Rows.Count
            End If
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cnDatos.State = ConnectionState.Open Then
                cnDatos.Close()
            End If
            If cnVoz.State = ConnectionState.Open Then
                cnVoz.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Marcacion() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim cnVoz As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cnDatos.Open()
            cms.CommandText = "select call.estado, agente, duracion, contrato, Lista, min_ac, fcregistro from call inner join Bandeja on call.contrato=Bandeja.cas_id where contrato=@_Idcaso"
            cms.Parameters.Add("@_Idcaso", SqlDbType.Int).Value = _Idcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
            Else
                cnVoz.Open()
                cms.CommandText = "select call.estado, agente, duracion, contrato, Lista, min_ac, fcregistro from call inner join Bandeja_uni on call.contrato=Bandeja_uni.idcaso where contrato=@_Idcaso"
                'cms.Parameters.Add("@_Idcaso", SqlDbType.Int).Value = _Idcaso
                cms.Connection = cnVoz
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                _Cantidad = dts.Tables(0).Rows.Count
            End If
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cnDatos.State = ConnectionState.Open Then
                cnDatos.Close()
            End If
            If cnVoz.State = ConnectionState.Open Then
                cnVoz.Close()
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
    Public Function BolTipoSoporte() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select * from Bol_TS"
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

    Public Function Datos_Consulta_Bandeja() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Nom_Cliente <> Nothing Then
                cms.CommandText = "Select * from bandeja where nom_cliente like '%'+@_Nom_Cliente+'%' "
                cms.Parameters.Add("@_Nom_Cliente", SqlDbType.VarChar, 50).Value = _Nom_Cliente
            End If
            If _Min_Ac <> Nothing Then
                cms.CommandText = "Select * from bandeja where min_ac = @_Min_Ac"
                cms.Parameters.Add("@_Min_Ac", SqlDbType.BigInt).Value = _Min_Ac
            End If
            If _Nom_Cliente <> Nothing And _Min_Ac <> Nothing Then
                cms.CommandText = "Select * from bandeja where nom_cliente like '%'+@_Nom_Cliente+'%' or min_ac = @_Min_Ac"
            End If
            If _Idcaso <> Nothing Then
                cms.CommandText = "Select * from bandeja where cas_id = @caso "
                cms.Parameters.Add("@caso", SqlDbType.VarChar, 50).Value = _Idcaso
            End If
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
    Public Function Voz_Consulta_Bandeja() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Nom_Cliente <> Nothing Then
                cms.CommandText = "Select * from bandeja_uni where nom_cliente like '%'+@_Nom_Cliente+'%' "
                cms.Parameters.Add("@_Nom_Cliente", SqlDbType.VarChar, 50).Value = _Nom_Cliente
            End If
            If _Min_Ac <> Nothing Then
                cms.CommandText = "Select * from bandeja_uni where min_ac = @_Min_Ac"
                cms.Parameters.Add("@_Min_Ac", SqlDbType.BigInt).Value = _Min_Ac
            End If
            If _Nom_Cliente <> Nothing And _Min_Ac <> Nothing Then
                cms.CommandText = "Select * from bandeja_uni where nom_cliente like '%'+@_Nom_Cliente+'%' or min_ac = @_Min_Ac"
            End If
            If _Idcaso <> Nothing Then
                cms.CommandText = "Select * from bandeja_uni where idcaso = @caso "
                cms.Parameters.Add("@caso", SqlDbType.VarChar, 50).Value = _Idcaso
            End If
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
    Public Function Dilo_Consulta_Bandeja() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Nom_Cliente <> Nothing Then
                cms.CommandText = "Select * from Bandeja_alt where cliente like '%'+@_Nom_Cliente+'%' "
                cms.Parameters.Add("@_Nom_Cliente", SqlDbType.VarChar, 50).Value = _Nom_Cliente
            End If
            If _Min_Ac <> Nothing Then
                cms.CommandText = "Select * from bandeja_alt where min = @_Min_Ac"
                cms.Parameters.Add("@_Min_Ac", SqlDbType.BigInt).Value = _Min_Ac
            End If
            If _Nom_Cliente <> Nothing And _Min_Ac <> Nothing Then
                cms.CommandText = "Select * from bandeja_alt where cliente like '%'+@_Nom_Cliente+'%' or min = @_Min_Ac"
            End If
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
    Public Function Control_Consulta_Bandeja() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Nom_Cliente <> Nothing Then
                cms.CommandText = "Select * from bandeja_control where nombrecliente like '%'+@_Nom_Cliente+'%' "
                cms.Parameters.Add("@_Nom_Cliente", SqlDbType.VarChar, 50).Value = _Nom_Cliente
            End If
            If _Min_Ac <> Nothing Then
                cms.CommandText = "Select * from bandeja_control where mintel = @_Min_Ac"
                cms.Parameters.Add("@_Min_Ac", SqlDbType.BigInt).Value = _Min_Ac
            End If
            If _Nom_Cliente <> Nothing And _Min_Ac <> Nothing Then
                cms.CommandText = "Select * from bandeja_control where nombrecliente like '%'+@_Nom_Cliente+'%' or mintel = @_Min_Ac"
            End If
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

    Public Function Consulta_Gestion_Datos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Fecha_Inicio_Gestion <> Nothing Then
                cms.CommandText = "Select (CRM.idcaso) as idcaso,((CRM.fcreg)) as fcreg,BB.Min_Ac ,CRM.idusuario,CRM.obs,CRM.tipificacion,CRM.numalt,CRM.fallared from CRMDetalle CRM inner join Bandeja_Bolt BB on (CRM.idcaso = BB.Idcaso) and (CRM.idusuario = BB.Idusuario) inner join (select max(CR.fcreg)as fecha,CR.idcaso  from CRMDetalle CR inner join Bandeja_Bolt B on  CR.idcaso=B.idcaso and (CR.idusuario = B.Idusuario) group by CR.idcaso) as m on m.fecha=CRM.fcreg where CRM.fcreg >= @_Fecha_Inicio group by CRM.idcaso,BB.Min_Ac ,CRM.idusuario,CRM.obs,CRM.tipificacion,CRM.numalt,CRM.fallared ,CRM.fcreg order by CRM.idcaso,CRM.fcreg"
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.DateTime).Value = _Fecha_Inicio_Gestion
            End If
            If _Fecha_Fin_Gestion <> Nothing Then
                cms.CommandText = "Select (CRM.idcaso) as idcaso,((CRM.fcreg)) as fcreg,BB.Min_Ac ,CRM.idusuario,CRM.obs,CRM.tipificacion,CRM.numalt,CRM.fallared from CRMDetalle CRM inner join Bandeja_Bolt BB on (CRM.idcaso = BB.Idcaso) and (CRM.idusuario = BB.Idusuario) inner join (select max(CR.fcreg)as fecha,CR.idcaso  from CRMDetalle CR inner join Bandeja_Bolt B on  CR.idcaso=B.idcaso and (CR.idusuario = B.Idusuario) group by CR.idcaso) as m on m.fecha=CRM.fcreg where CRM.fcreg <= @_Fecha_Fin group by CRM.idcaso,BB.Min_Ac ,CRM.idusuario,CRM.obs,CRM.tipificacion,CRM.numalt,CRM.fallared ,CRM.fcreg order by CRM.idcaso,CRM.fcreg"
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.DateTime).Value = _Fecha_Fin_Gestion
            End If
            If _Fecha_Inicio_Gestion <> Nothing Or _Fecha_Fin_Gestion <> Nothing Then
                cms.CommandText = " Select  (CRM.idcaso)as Caso,BB.Min_Ac as 'Min_Ac' ,BB.Ing_Remite as 'Ingeniero',BB.Nom_Cliente as 'Nombre empresa C&G usuario vip',u.nombreu as 'Usuario',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',CRM.obs as 'Observaciones',BB.Recomen_Prioridad as 'Urgente' ,CRM.tipificacion ,max(CRM.fcreg) as 'Fecha Gestion',(BB.Cas_Fecha_Registro) as 'Fecha Boldchat',BB.Equipo_Ac,BT.Nombre as Tipo,BS.Nombre as 'Segmento',BB.Bandeja, 'DATOS' AS Mesa from CRMDetalle CRM inner join Bandeja_Bolt BB on (CRM.idcaso = BB.Idcaso) and (CRM.idusuario = BB.Idusuario) inner join Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join usuarios u on u.idusuario=crm.idusuario inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join (select max(CR.fcreg)as fecha,CR.idcaso  from CRMDetalle CR inner join Bandeja_Bolt B on  CR.idcaso=B.idcaso and (CR.idusuario = B.Idusuario) group by CR.idcaso) as m on m.fecha=CRM.fcreg where  CRM.fcreg >= @_Fecha_Inicio and CRM.fcreg <= @_Fecha_Fin group by CRM.idcaso,BB.Min_Ac,BB.Ing_Remite,BB.Nom_Cliente,u.nombreu,BB.Cas_Fecha_Recepcion,CRM.obs,BB.Recomen_Prioridad,CRM.tipificacion,BB.Cas_Fecha_Registro,BB.Equipo_Ac,BT.Nombre,BT.Nombre,BS.Nombre,BB.Bandeja  order by CRM.idcaso"
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
    Public Function Consulta_Gestion_Voz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Fecha_Inicio_Gestion <> Nothing Then
                cms.CommandText = "Select (CRM.idcaso) as idcaso,max(CRM.fcreg) as fcreg,BB.Min_Ac ,CRM.idusuario,CRM.obs,CRM.tipificacion,VT.estagogest,CRM.fallared from clarovoz.dbo.VCRMDetalle CRM inner join datosclaro.dbo.Bandeja_Bolt BB on (CRM.idcaso = BB.Idcaso) and (CRM.idusuario = BB.Idusuario) inner join clarovoz.dbo.VTiposoporte VT on CRM.tipificacion=VT.tipifcrm inner join(select max(CR.fcreg) as fecha,cr.idcaso from clarovoz.dbo.VCRMDetalle CR inner join datosclaro.dbo.Bandeja_Bolt BB on (CR.idcaso = BB.Idcaso) and (CR.idusuario = BB.Idusuario) inner join clarovoz.dbo.VTiposoporte VT on CR.tipificacion=VT.tipifcrm group by CR.idcaso) as m on m.fecha=CRM.fcreg where CRM.fcreg >= @_Fecha_Inicio group by CRM.idcaso,CRM.fcreg,BB.Min_Ac ,CRM.idusuario,CRM.obs,CRM.tipificacion,CRM.numalt,CRM.fallared,VT.estagogest"
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.DateTime).Value = _Fecha_Inicio_Gestion
            End If
            If _Fecha_Fin_Gestion <> Nothing Then
                cms.CommandText = "Select (CRM.idcaso) as idcaso,max(CRM.fcreg) as fcreg,BB.Min_Ac ,CRM.idusuario,CRM.obs,CRM.tipificacion,VT.estagogest,CRM.fallared from clarovoz.dbo.VCRMDetalle CRM inner join datosclaro.dbo.Bandeja_Bolt BB on (CRM.idcaso = BB.Idcaso) and (CRM.idusuario = BB.Idusuario) inner join clarovoz.dbo.VTiposoporte VT on CRM.tipificacion=VT.tipifcrm inner join(select max(CR.fcreg) as fecha,cr.idcaso from clarovoz.dbo.VCRMDetalle CR inner join datosclaro.dbo.Bandeja_Bolt BB on (CR.idcaso = BB.Idcaso) and (CR.idusuario = BB.Idusuario) inner join clarovoz.dbo.VTiposoporte VT on CR.tipificacion=VT.tipifcrm group by CR.idcaso) as m on m.fecha=CRM.fcreg where CRM.fcreg <= @_Fecha_Fin group by CRM.idcaso,CRM.fcreg,BB.Min_Ac ,CRM.idusuario,CRM.obs,CRM.tipificacion,CRM.numalt,CRM.fallared,VT.estagogest"
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.DateTime).Value = _Fecha_Fin_Gestion
            End If
            If _Fecha_Inicio_Gestion <> Nothing And _Fecha_Fin_Gestion <> Nothing Then
                cms.CommandText = "Select (CRM.idcaso)as 'Caso',BB.Min_Ac,BB.Ing_Remite as 'Ingeniero' ,BB.Nom_Cliente as 'Nombre empresa C&G usuario vip',U.nombreu as 'Usuario',BB.Cas_Fecha_Recepcion as 'Fecha recepcion',CRM.obs as 'Observaciones',BB.Recomen_Prioridad as 'Urgente',CRM.tipificacion,max(CRM.fcreg) as 'Fecha Gestion',(BB.Cas_Fecha_Registro) as 'Fecha Boldchat',BB.Equipo_Ac,BT.Nombre as Tipo,BS.Nombre as Segmento,BB.Bandeja,'VOZ' AS Mesa  from clarovoz.dbo.VCRMDetalle CRM inner join datosclaro.dbo.Bandeja_Bolt BB on (CRM.idcaso = BB.Idcaso) and (CRM.idusuario = BB.Idusuario)inner join datosclaro.dbo.usuarios U on u.idusuario =CRM.idusuario inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo  inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.VTiposoporte VT on CRM.tipificacion=VT.tipifcrm inner join(select max(CR.fcreg) as fecha,cr.idcaso from clarovoz.dbo.VCRMDetalle CR inner join datosclaro.dbo.Bandeja_Bolt BB on (CR.idcaso = BB.Idcaso) and (CR.idusuario = BB.Idusuario) inner join clarovoz.dbo.VTiposoporte VT on CR.tipificacion=VT.tipifcrm group by CR.idcaso) as m on m.fecha=CRM.fcreg where CRM.fcreg >= @_Fecha_Inicio and CRM.fcreg <= @_Fecha_Fin group by  CRM.idcaso,BB.Min_Ac,BB.Ing_Remite,BB.Nom_Cliente,U.nombreu,BB.Cas_Fecha_Recepcion,CRM.obs,BB.Recomen_Prioridad,CRM.tipificacion, BB.Cas_Fecha_Registro,BB.Equipo_Ac,bb.segmento,BT.Nombre,BS.Nombre,BB.Bandeja"
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
    Public Function Consulta_Estado_Casos_BoldChat() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado"
            cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 20).Value = strlestado
            ''Numero Min
            If _Min_Ac <> Nothing Then
                cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado and BB.Min_Ac=@_Min_Ac union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado and BB.Min_Ac=@_Min_Ac union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado and BB.Min_Ac=@_Min_Ac"
                cms.Parameters.Add("@_Min_Ac", SqlDbType.BigInt).Value = _Min_Ac
            End If
            ''Nombre del cliente
            If _Nom_Cliente <> Nothing Then
                cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%'"
                cms.Parameters.Add("@_Nom_Cliente", SqlDbType.VarChar, 50).Value = _Nom_Cliente
            End If
            ''Fecha inicio recepcion
            If _Fecha_Inicio <> Nothing Then
                cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado and BB.Cas_Fecha_Recepcion>@_Fecha_Inicio union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado and BB.Cas_Fecha_Recepcion>@_Fecha_Inicio union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado and BB.Cas_Fecha_Recepcion>@_Fecha_Inicio"
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.Date).Value = _Fecha_Inicio
            End If
            ''Fecha fin recepcion
            If _Fecha_Fin <> Nothing Then
                cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado and BB.Cas_Fecha_Recepcion<@_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado and BB.Cas_Fecha_Recepcion<@_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado and BB.Cas_Fecha_Recepcion<@_Fecha_Fin"
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.Date).Value = _Fecha_Fin
            End If
            ''Numero Min y Nombre del cliente
            If _Min_Ac <> Nothing And _Nom_Cliente <> Nothing Then
                cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado and BB.Min_Ac=@_Min_Ac and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado and BB.Min_Ac=@_Min_Ac and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado and BB.Min_Ac=@_Min_Ac and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%'"
            End If
            ''Fecha inicio recepcion y Fecha fin recepcion
            If _Fecha_Inicio <> Nothing And _Fecha_Fin <> Nothing Then
                cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin"
            End If
            ''Numero Min, Fecha inicio recepcion y Fecha fin recepcion
            If _Min_Ac <> Nothing And _Fecha_Inicio <> Nothing And _Fecha_Fin <> Nothing Then
                cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado and BB.Min_Ac=@_Min_Ac and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado and BB.Min_Ac=@_Min_Ac and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado and BB.Min_Ac=@_Min_Ac and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin"
            End If
            ''Nombre del cliente, Fecha inicio recepcion y Fecha fin recepcion
            If _Nom_Cliente <> Nothing And _Fecha_Inicio <> Nothing And _Fecha_Fin <> Nothing Then
                cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin"
            End If
            ''Numero Min,Nombre del cliente, Fecha inicio recepcion y Fecha fin recepcion
            If _Min_Ac <> Nothing And _Nom_Cliente <> Nothing And _Fecha_Inicio <> Nothing And _Fecha_Fin <> Nothing Then
                cms.CommandText = "select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,B.estado,'Datos' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja B on BB.Idcaso = B.cas_id and BB.Bandeja = B.Bandeja where B.estado=@strlestado and BB.Min_Ac=@_Min_Ac and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BA.estado,'Alt' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join datosclaro.dbo.Bandeja_alt BA on BB.Idcaso = BA.idcaso and BB.Bandeja = BA.mesa where BA.estado=@strlestado and BB.Min_Ac=@_Min_Ac and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin union select BB.Idcaso,BB.Ing_Remite,BB.Cas_Fecha_Registro,BB.Min_Ac,BB.Nom_Cliente,BB.Equipo_Ac,BB.Idusuario,BB.Cas_Fecha_Recepcion,BB.Recomen_Prioridad,BT.Nombre as Tipo,BS.Nombre as Segmeto,BB.Bandeja,BU.estado,'Voz' as 'Bandeja Global' from datosclaro.dbo.Bandeja_Bolt BB inner join datosclaro.dbo.Bol_Tipo BT on BB.Tipo=BT.Cod_Bol_Tipo inner join datosclaro.dbo.Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento inner join clarovoz.dbo.Bandeja_uni BU on BB.Idcaso = BU.idcaso and BB.Bandeja = BU.Bandeja where BU.estado=@strlestado and BB.Min_Ac=@_Min_Ac and BB.Nom_Cliente like '%'+@_Nom_Cliente+'%' and BB.Cas_Fecha_Recepcion between @_Fecha_Inicio and @_Fecha_Fin"
            End If
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
    Public Function consultatipificacion() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT tipificacion FROM tipificacion where uso='datos' or uso='Dilo' or uso='VozBoldChat' group by tipificacion order by tipificacion "
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
End Class
