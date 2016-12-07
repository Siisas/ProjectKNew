Public Class clsDirectTv

    Protected _ComoSeEntero As String
    Protected _Descripcion_Plan As String
    Protected _Tipo_Plan As String
    Protected _Id_Direct_TV As Int64
    Protected _Direccion As String
    Protected _Ciudad As String
    Protected _Tipificacion As String
    Protected _FechaProg As Date
    Protected _Observacion As String
    Protected _Id_Agente As String
    Protected _Nombre_Referente As String
    Protected _Nombre_Referido As String
    Protected _Nombre_Referido0 As String
    Protected _Nombre_Referido1 As String
    Protected _Telefono_Cliente As String
    Protected _Telefono_Cliente0 As String
    Protected _Celular_Cliente As String
    Protected _Telefono_Referido As String
    Protected _Telefono_Referido0 As String
    Protected _Telefono_Referido1 As String
    Protected _Id_Cliente As String
    Protected _Id_Direct_TV_Cliente As Int64
    Protected _Id_Direct_TV_Caso As Int64
    Protected _Nombre_Cliente As String
    Protected _Validacion As Integer
    Protected _Documento As Int64
    Protected _Id_Referente As String
    Protected _Cedula_Cliente As Int64
    Protected _Expedicion_Cedula As String
    Protected _Fc_Nacimiento As Date
    Protected _Nombre_Contacto As String
    Protected _Telefono_Contacto As String
    Protected _Numero_Contrato As Int64
    Protected _IBS As Int64
    Protected _Cod_Factura_Codensa As Int64
    Protected _Correo_Cliente As String
    Protected _Id_Busq_Num As Int64
    Protected _Id_Busq_Char As String
    Protected _TipoLlamada As String
    Protected _Fcini As String
    Protected _Fcfin As String
    Protected _Cantidad As Integer
    Protected _Localidad As String
    Protected _Estrato As String
    Protected _Operador As String
    Protected _Ilocalizado_Por As String

    Public Property Ilocalizado_Por() As String
        Get
            Return _Ilocalizado_Por
        End Get
        Set(ByVal value As String)
            _Ilocalizado_Por = value
        End Set
    End Property
    Public Property Operador() As String
        Get
            Return _Operador
        End Get
        Set(ByVal value As String)
            _Operador = value
        End Set
    End Property
    Public Property Estrato() As String
        Get
            Return _Estrato
        End Get
        Set(ByVal value As String)
            _Estrato = value
        End Set
    End Property
    Public Property Localidad() As String
        Get
            Return _Localidad
        End Get
        Set(ByVal value As String)
            _Localidad = value
        End Set
    End Property
    Public Property cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property
    Public Property fcfin() As String
        Get
            Return _Fcfin
        End Get
        Set(ByVal value As String)
            _Fcfin = value
        End Set
    End Property
    Public Property fcini() As String
        Get
            Return _Fcini
        End Get
        Set(ByVal value As String)
            _Fcini = value
        End Set
    End Property
    Public Property ComoSeEntero As String
        Get
            Return _ComoSeEntero
        End Get
        Set(value As String)
            _ComoSeEntero = value
        End Set
    End Property

    Public Property Descripcion_Plan As String
        Get
            Return _Descripcion_Plan
        End Get
        Set(value As String)
            _Descripcion_Plan = value
        End Set
    End Property

    Public Property Tipo_Plan As String
        Get
            Return _Tipo_Plan
        End Get
        Set(value As String)
            _Tipo_Plan = value
        End Set
    End Property

    Public Property Id_Direct_TV As Int64
        Get
            Return _Id_Direct_TV
        End Get
        Set(value As Int64)
            _Id_Direct_TV = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(value As String)
            _Ciudad = value
        End Set
    End Property

    Public Property Tipificacion As String
        Get
            Return _Tipificacion
        End Get
        Set(value As String)
            _Tipificacion = value
        End Set
    End Property

    Public Property FechaProg As Date
        Get
            Return _FechaProg
        End Get
        Set(value As Date)
            _FechaProg = value
        End Set
    End Property

    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(value As String)
            _Observacion = value
        End Set
    End Property

    Public Property Id_Agente As String
        Get
            Return _Id_Agente
        End Get
        Set(value As String)
            _Id_Agente = value
        End Set
    End Property

    Public Property Nombre_Referente As String
        Get
            Return _Nombre_Referente
        End Get
        Set(value As String)
            _Nombre_Referente = value
        End Set
    End Property

    Public Property Nombre_Referido As String
        Get
            Return _Nombre_Referido
        End Get
        Set(value As String)
            _Nombre_Referido = value
        End Set
    End Property

    Public Property Nombre_Referido0 As String
        Get
            Return _Nombre_Referido0
        End Get
        Set(value As String)
            _Nombre_Referido0 = value
        End Set
    End Property

    Public Property Nombre_Referido1 As String
        Get
            Return _Nombre_Referido1
        End Get
        Set(value As String)
            _Nombre_Referido1 = value
        End Set
    End Property

    Public Property Telefono_Cliente As String
        Get
            Return _Telefono_Cliente
        End Get
        Set(value As String)
            _Telefono_Cliente = value
        End Set
    End Property

    Public Property Telefono_Cliente0 As String
        Get
            Return _Telefono_Cliente0
        End Get
        Set(value As String)
            _Telefono_Cliente0 = value
        End Set
    End Property

    Public Property Celular_Cliente As String
        Get
            Return _Celular_Cliente
        End Get
        Set(value As String)
            _Celular_Cliente = value
        End Set
    End Property

    Public Property Telefono_Referido As String
        Get
            Return _Telefono_Referido
        End Get
        Set(value As String)
            _Telefono_Referido = value
        End Set
    End Property

    Public Property Telefono_Referido0 As String
        Get
            Return _Telefono_Referido0
        End Get
        Set(value As String)
            _Telefono_Referido0 = value
        End Set
    End Property

    Public Property Telefono_Referido1 As String
        Get
            Return _Telefono_Referido1
        End Get
        Set(value As String)
            _Telefono_Referido1 = value
        End Set
    End Property

    Public Property Id_Cliente As String
        Get
            Return _Id_Cliente
        End Get
        Set(value As String)
            _Id_Cliente = value
        End Set
    End Property

    Public Property Id_Direct_TV_Cliente As Int64
        Get
            Return _Id_Direct_TV_Cliente
        End Get
        Set(value As Int64)
            _Id_Direct_TV_Cliente = value
        End Set
    End Property

    Public Property Id_Direct_TV_Caso As Int64
        Get
            Return _Id_Direct_TV_Caso
        End Get
        Set(value As Int64)
            _Id_Direct_TV_Caso = value
        End Set
    End Property

    Public Property Nombre_Cliente As String
        Get
            Return _Nombre_Cliente
        End Get
        Set(value As String)
            _Nombre_Cliente = value
        End Set
    End Property

    Public Property Validacion As Integer
        Get
            Return _Validacion
        End Get
        Set(value As Integer)
            _Validacion = value
        End Set
    End Property

    Public Property Documento As Int64
        Get
            Return _Documento
        End Get
        Set(value As Int64)
            _Documento = value
        End Set
    End Property

    Public Property Id_Referente As String
        Get
            Return _Id_Referente
        End Get
        Set(value As String)
            _Id_Referente = value
        End Set
    End Property

    Public Property Cedula_Cliente As Int64
        Get
            Return _Cedula_Cliente
        End Get
        Set(value As Int64)
            _Cedula_Cliente = value
        End Set
    End Property

    Public Property Expedicion_Cedula As String
        Get
            Return _Expedicion_Cedula
        End Get
        Set(value As String)
            _Expedicion_Cedula = value
        End Set
    End Property

    Public Property Fc_Nacimiento As Date
        Get
            Return _Fc_Nacimiento
        End Get
        Set(value As Date)
            _Fc_Nacimiento = value
        End Set
    End Property

    Public Property Nombre_Contacto As String
        Get
            Return _Nombre_Contacto
        End Get
        Set(value As String)
            _Nombre_Contacto = value
        End Set
    End Property

    Public Property Telefono_Contacto As String
        Get
            Return _Telefono_Contacto
        End Get
        Set(value As String)
            _Telefono_Contacto = value
        End Set
    End Property

    Public Property Numero_Contrato As Int64
        Get
            Return _Numero_Contrato
        End Get
        Set(value As Int64)
            _Numero_Contrato=value
        End Set
    End Property

    Public Property Cod_Factura_Codensa As Int64
        Get
            Return _Cod_Factura_Codensa
        End Get
        Set(value As Int64)
            _Cod_Factura_Codensa = value
        End Set
    End Property

    Public Property IBS As Int64
        Get
            Return _IBS
        End Get
        Set(value As Int64)
            _IBS = value
        End Set
    End Property

    Public Property Correo_Cliente As String
        Get
            Return _Correo_Cliente
        End Get
        Set(value As String)
            _Correo_Cliente = value
        End Set
    End Property

    Public Property Id_Busq_Num As Int64
        Get
            Return _Id_Busq_Num
        End Get
        Set(value As Int64)
            _Id_Busq_Num = value
        End Set
    End Property

    Public Property Id_Busq_Char As String
        Get
            Return _Id_Busq_Char
        End Get
        Set(value As String)
            _Id_Busq_Char = value
        End Set
    End Property

    Public Property TipoLlamada As String
        Get
            Return _TipoLlamada
        End Get
        Set(value As String)
            _TipoLlamada = value
        End Set
    End Property
    

    'Llena el drl de ciudades
    Public Function ObtenerCiudades() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select nombremun from Divipola group by nombremun"
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



    'Llena el drl de Tipificaciones
    Public Function ObtenerTipificaciones() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select nombre from BD_Voz_Complemento where Pertenece='TipiDTV' or Pertenece= '- Seleccione -' order by nombre"
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

    'Llena drl de tipos de plan
    Public Function ObtenerTiposPlan() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select nombre, Cod_BD_Voz_Complemento from BD_Voz_Complemento where Pertenece='PlanDTV' or Pertenece= '- Seleccione -'"
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

    'obtiene los datos del cliente
    Public Function Obtener_Cliente() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()

            If Validacion = 1 Then
                cms.CommandText = "select * from Direct_TV_Cliente DTVCliente full join Direct_TV_Caso DTVCaso on DTVCaso.Fk_Id_Cliente = DTVCliente.Id_Cliente full join Direct_TV_Referidos DTVReferid on DTVCliente.Id_Cliente=DTVReferid.Id_Referido where DTVCliente.Id_Cliente = @_Id_Char order by Id_Direct_TV_Caso DESC "
                cms.Parameters.Add("@_Id_Char", SqlDbType.VarChar, 20).Value = _Id_Busq_Char
            Else
                cms.CommandText = "select * from Direct_TV_Cliente DTC full join Direct_TV_Caso DTCas on DTCas.Fk_Id_Cliente = Convert(varchar(50),DTC.Id_Direct_TV_Cliente) full join Direct_TV_Referidos DTVReferid on DTC.Id_Cliente=DTVReferid.Id_Referido where DTC.Id_Direct_Tv_Cliente = @_Id_Num order by Id_Direct_TV_Caso DESC "
                cms.Parameters.Add("@_Id_Num", SqlDbType.BigInt).Value = _Id_Busq_Num
            End If

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            '_Id_Cliente = ""
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Id_Direct_Tv_Cliente") Is DBNull.Value Then
                    _Id_Direct_TV_Cliente = Nothing
                Else
                    _Id_Direct_TV_Cliente = dts.Tables(0).Rows(0).Item("Id_Direct_Tv_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Id_Cliente") Is DBNull.Value Then
                    _Id_Cliente = Nothing
                Else
                    _Id_Cliente = dts.Tables(0).Rows(0).Item("Id_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre_Cliente") Is DBNull.Value Then
                    _Nombre_Cliente = ""
                Else
                    _Nombre_Cliente = dts.Tables(0).Rows(0).Item("Nombre_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Direccion") Is DBNull.Value Then
                    _Direccion = ""
                Else
                    _Direccion = dts.Tables(0).Rows(0).Item("Direccion")
                End If
                If dts.Tables(0).Rows(0).Item("Telefono_Cliente") Is DBNull.Value Then
                    _Telefono_Cliente = ""
                Else
                    _Telefono_Cliente = dts.Tables(0).Rows(0).Item("Telefono_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Telefono_Cliente0") Is DBNull.Value Then
                    _Telefono_Cliente0 = ""
                Else
                    _Telefono_Cliente0 = dts.Tables(0).Rows(0).Item("Telefono_Cliente0")
                End If
                If dts.Tables(0).Rows(0).Item("Celular_Cliente") Is DBNull.Value Then
                    _Celular_Cliente = ""
                Else
                    _Celular_Cliente = dts.Tables(0).Rows(0).Item("Celular_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Ciudad") Is DBNull.Value Then
                    _Ciudad = ""
                Else
                    _Ciudad = dts.Tables(0).Rows(0).Item("Ciudad")
                End If
                If dts.Tables(0).Rows(0).Item("Id_Direct_TV_Caso") Is DBNull.Value Then
                    _Id_Direct_TV_Caso = 0
                Else
                    _Id_Direct_TV_Caso = dts.Tables(0).Rows(0).Item("Id_Direct_TV_Caso")
                End If
                If dts.Tables(0).Rows(0).Item("Tipificacion") Is DBNull.Value Then
                    _Tipificacion = ""
                Else
                    _Tipificacion = dts.Tables(0).Rows(0).Item("Tipificacion")
                End If

                If dts.Tables(0).Rows(0).Item("Fc_Hr_Programacion") Is DBNull.Value Then
                    _FechaProg = "01/01/2000 12:00:00"
                Else
                    _FechaProg = dts.Tables(0).Rows(0).Item("Fc_Hr_Programacion")
                End If
                If dts.Tables(0).Rows(0).Item("Observacion") Is DBNull.Value Then
                    _Observacion = ""
                Else
                    _Observacion = dts.Tables(0).Rows(0).Item("Observacion")
                End If
                If dts.Tables(0).Rows(0).Item("Cedula_Cliente") Is DBNull.Value Then
                    _Cedula_Cliente = 0
                Else
                    _Cedula_Cliente = dts.Tables(0).Rows(0).Item("Cedula_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Expedicion_Cedula") Is DBNull.Value Then
                    _Expedicion_Cedula = ""
                Else
                    _Expedicion_Cedula = dts.Tables(0).Rows(0).Item("Expedicion_Cedula")
                End If
                If dts.Tables(0).Rows(0).Item("Fc_Nacimiento") Is DBNull.Value Then
                    _Fc_Nacimiento = Nothing
                Else
                    _Fc_Nacimiento = dts.Tables(0).Rows(0).Item("Fc_Nacimiento")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre_Contacto") Is DBNull.Value Then
                    _Nombre_Contacto = ""
                Else
                    _Nombre_Contacto = dts.Tables(0).Rows(0).Item("Nombre_Contacto")
                End If
                If dts.Tables(0).Rows(0).Item("Telefono_Contacto") Is DBNull.Value Then
                    _Telefono_Contacto = ""
                Else
                    _Telefono_Contacto = dts.Tables(0).Rows(0).Item("Telefono_Contacto")
                End If
                If dts.Tables(0).Rows(0).Item("Correo_Cliente") Is DBNull.Value Then
                    _Correo_Cliente = Nothing
                Else
                    _Correo_Cliente = dts.Tables(0).Rows(0).Item("Correo_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Numero_Contrato") Is DBNull.Value Then
                    _Numero_Contrato = Nothing
                Else
                    _Numero_Contrato = dts.Tables(0).Rows(0).Item("Numero_Contrato")
                End If
                If dts.Tables(0).Rows(0).Item("Cod_Factura_Codensa") Is DBNull.Value Then
                    _Cod_Factura_Codensa = Nothing
                Else
                    _Cod_Factura_Codensa = dts.Tables(0).Rows(0).Item("Cod_Factura_Codensa")
                End If
                If dts.Tables(0).Rows(0).Item("IBS") Is DBNull.Value Then
                    _IBS = Nothing
                Else
                    _IBS = dts.Tables(0).Rows(0).Item("IBS")
                End If
                If dts.Tables(0).Rows(0).Item("TipoLlamada") Is DBNull.Value Then
                    _TipoLlamada = Nothing
                Else
                    _TipoLlamada = dts.Tables(0).Rows(0).Item("TipoLlamada")
                End If
                If dts.Tables(0).Rows(0).Item("Localidad") Is DBNull.Value Then
                    _Localidad = Nothing
                Else
                    _Localidad = dts.Tables(0).Rows(0).Item("Localidad")
                End If
                If dts.Tables(0).Rows(0).Item("Estrato") Is DBNull.Value Then
                    _Estrato = Nothing
                Else
                    _Estrato = dts.Tables(0).Rows(0).Item("Estrato")
                End If
                If dts.Tables(0).Rows(0).Item("Operador") Is DBNull.Value Then
                    _Operador = Nothing
                Else
                    _Operador = dts.Tables(0).Rows(0).Item("Operador")
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

    'Obtener Ventas realizadas
    Public Function Obtener_Ventas() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from Direct_TV_Ventas where FK_Id_Direct_TV_Caso = @_Id_Caso"
            cms.Parameters.Add("@_Id_Caso", SqlDbType.BigInt).Value = _Id_Direct_TV_Caso
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

    'obtener referencias
    Public Function Obtener_Referencias() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from Direct_TV_Referidos where Id_Referente = @_Id_Referente"
            cms.Parameters.Add("@_Id_Referente", SqlDbType.VarChar, 20).Value = _Id_Cliente
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

    'Obtiene las descripciones de los planes
    Public Function ObtenerTiposPlanDescripcion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select nombre from BD_Voz_Complemento where Pertenece = @_Descripcion_Plan"
            cms.Parameters.Add("@_Descripcion_Plan", SqlDbType.VarChar, 100).Value = _Descripcion_Plan
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)

            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("nombre") Is DBNull.Value Then
                    _Descripcion_Plan = ""
                Else
                    _Descripcion_Plan = dts.Tables(0).Rows(0).Item("nombre")
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


    'Guarda la informacion de los clientes
    Public Sub Guardar_Informacion_Clientes()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()

            If Validacion = 1 Then
                cms.CommandText = "Update Direct_TV_Cliente set Localidad=@_Localidad ,Estrato=@_Estrato , Operador=@_Operador, Direccion = @_Direccion, Telefono_Cliente = @_Telefono_Cliente, Telefono_Cliente0 = @_Telefono_Cliente0, Celular_Cliente = @_Celular_Cliente, Ciudad = @_Ciudad, Cedula_Cliente = @_Cedula_Cliente, Expedicion_Cedula = @_Expedicion_Cedula, Nombre_Contacto = @_Nombre_Contacto, Telefono_Contacto = @_Telefono_Contacto, Correo_Cliente = @_Correo_Cliente where Id_Cliente = @_Id_Cliente"

                If _Fc_Nacimiento <> Nothing Then
                    cms.CommandText = "Update Direct_TV_Cliente set Localidad=@_Localidad ,Estrato=@_Estrato , Operador=@_Operador, Direccion = @_Direccion, Telefono_Cliente = @_Telefono_Cliente, Telefono_Cliente0 = @_Telefono_Cliente0, Celular_Cliente = @_Celular_Cliente, Ciudad = @_Ciudad, Cedula_Cliente = @_Cedula_Cliente, Expedicion_Cedula = @_Expedicion_Cedula, Fc_Nacimiento = @_Fc_Nacimiento, Nombre_Contacto = @_Nombre_Contacto, Telefono_Contacto = @_Telefono_Contacto, Correo_Cliente = @_Correo_Cliente where Id_Cliente = @_Id_Cliente"
                    cms.Parameters.Add("@_Fc_Nacimiento", SqlDbType.Date).Value = _Fc_Nacimiento
                End If
            Else
                cms.CommandText = "Update Direct_TV_Cliente set Localidad=@_Localidad ,Estrato=@_Estrato , Operador=@_Operador, Direccion = @_Direccion, Telefono_Cliente = @_Telefono_Cliente, Telefono_Cliente0 = @_Telefono_Cliente0, Celular_Cliente = @_Celular_Cliente, Ciudad = @_Ciudad, Cedula_Cliente = @_Cedula_Cliente, Expedicion_Cedula = @_Expedicion_Cedula, Nombre_Contacto = @_Nombre_Contacto, Telefono_Contacto = @_Telefono_Contacto, Correo_Cliente = @_Correo_Cliente where Id_Direct_Tv_Cliente = @_Id_Cliente"
                If _Fc_Nacimiento <> Nothing Then
                    cms.CommandText = "Update Direct_TV_Cliente set Localidad=@_Localidad ,Estrato=@_Estrato , Operador=@_Operador, Direccion = @_Direccion, Telefono_Cliente = @_Telefono_Cliente, Telefono_Cliente0 = @_Telefono_Cliente0, Celular_Cliente = @_Celular_Cliente, Ciudad = @_Ciudad, Cedula_Cliente = @_Cedula_Cliente, Expedicion_Cedula = @_Expedicion_Cedula, Fc_Nacimiento = @_Fc_Nacimiento, Nombre_Contacto = @_Nombre_Contacto, Telefono_Contacto = @_Telefono_Contacto, Correo_Cliente = @_Correo_Cliente where Id_Direct_Tv_Cliente = @_Id_Cliente"
                    cms.Parameters.Add("@_Fc_Nacimiento", SqlDbType.Date).Value = _Fc_Nacimiento
                End If

            End If


            cms.Parameters.Add("@_Id_Cliente", SqlDbType.VarChar, 20).Value = _Id_Cliente
            cms.Parameters.Add("@_Direccion", SqlDbType.VarChar, 200).Value = _Direccion
            cms.Parameters.Add("@_Telefono_Cliente", SqlDbType.VarChar, 70).Value = _Telefono_Cliente
            cms.Parameters.Add("@_Telefono_Cliente0", SqlDbType.VarChar, 70).Value = _Telefono_Cliente0
            cms.Parameters.Add("@_Celular_Cliente", SqlDbType.VarChar, 70).Value = _Celular_Cliente
            cms.Parameters.Add("@_Ciudad", SqlDbType.VarChar, 70).Value = _Ciudad
            cms.Parameters.Add("@_Cedula_Cliente", SqlDbType.BigInt).Value = _Cedula_Cliente
            cms.Parameters.Add("@_Expedicion_Cedula", SqlDbType.VarChar, 70).Value = _Expedicion_Cedula

            cms.Parameters.Add("@_Nombre_Contacto", SqlDbType.VarChar, 100).Value = _Nombre_Contacto
            cms.Parameters.Add("@_Telefono_Contacto", SqlDbType.VarChar, 70).Value = _Telefono_Contacto
            cms.Parameters.Add("@_Correo_Cliente", SqlDbType.VarChar, 70).Value = _Correo_Cliente

            cms.Parameters.Add("@_Localidad", SqlDbType.VarChar, 100).Value = _Localidad
            cms.Parameters.Add("@_Estrato", SqlDbType.VarChar, 2L).Value = _Estrato
            cms.Parameters.Add("@_Operador", SqlDbType.VarChar, 50).Value = _Operador

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


    'Guarda los datos referentes al caso
    Public Sub Guardar_Caso()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try

            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            Dim FechaActual As DateTime = DateTime.Now

            cms.CommandText = "INSERT INTO Direct_TV_Caso(FK_Id_Cliente, Id_Agente, Fc_Registro, Tipificacion, Observacion, Numero_Contrato, Cod_Factura_Codensa, IBS, TipoLlamada, ComoSeEntero) values (@_FK_Id_Cliente, @_Id_Agente, @_Fc_Registro, @_Tipificacion, @_Observacion, @_Numero_Contrato, @_Cod_Factura_Codensa, @_IBS, @_TipoLlamada, @_ComoSeEntero)"

            If _FechaProg <> Nothing Then
                cms.CommandText = "INSERT INTO Direct_TV_Caso(FK_Id_Cliente, Id_Agente, Fc_Registro, Tipificacion, Fc_Hr_Programacion, Observacion, Numero_Contrato, Cod_Factura_Codensa, IBS, TipoLlamada, ComoSeEntero) values (@_FK_Id_Cliente, @_Id_Agente, @_Fc_Registro, @_Tipificacion, @_Fc_Hr_Programacion, @_Observacion, @_Numero_Contrato, @_Cod_Factura_Codensa, @_IBS, @_TipoLlamada, @_ComoSeEntero)"
                cms.Parameters.Add("@_Fc_Hr_Programacion", SqlDbType.DateTime).Value = _FechaProg
            End If
            If _Ilocalizado_Por <> Nothing Then
                cms.CommandText = "INSERT INTO Direct_TV_Caso(Ilocalizado_Por, FK_Id_Cliente, Id_Agente, Fc_Registro, Tipificacion, Observacion, Numero_Contrato, Cod_Factura_Codensa, IBS, TipoLlamada, ComoSeEntero) values (@_Ilocalizado_Por, @_FK_Id_Cliente, @_Id_Agente, @_Fc_Registro, @_Tipificacion, @_Observacion, @_Numero_Contrato, @_Cod_Factura_Codensa, @_IBS, @_TipoLlamada, @_ComoSeEntero)"
                cms.Parameters.Add("@_Ilocalizado_Por", SqlDbType.VarChar, 100).Value = _Ilocalizado_Por
            End If
            If _FechaProg <> Nothing And _Ilocalizado_Por <> Nothing Then
                cms.CommandText = "INSERT INTO Direct_TV_Caso(Ilocalizado_Por, FK_Id_Cliente, Id_Agente, Fc_Registro, Tipificacion, Fc_Hr_Programacion, Observacion, Numero_Contrato, Cod_Factura_Codensa, IBS, TipoLlamada, ComoSeEntero) values (@_Ilocalizado_Por, @_FK_Id_Cliente, @_Id_Agente, @_Fc_Registro, @_Tipificacion, @_Fc_Hr_Programacion, @_Observacion, @_Numero_Contrato, @_Cod_Factura_Codensa, @_IBS, @_TipoLlamada, @_ComoSeEntero)"
            End If

            cms.Parameters.Add("@_FK_Id_Cliente", SqlDbType.VarChar, 20).Value = _Id_Cliente
            cms.Parameters.Add("@_Id_Direct_TV_Caso", SqlDbType.VarChar, 20).Value = _Id_Direct_TV_Caso
            cms.Parameters.Add("@_Id_Agente", SqlDbType.VarChar, 20).Value = _Id_Agente
            cms.Parameters.Add("@_Fc_Registro", SqlDbType.DateTime).Value = Now
            cms.Parameters.Add("@_Tipificacion", SqlDbType.VarChar, 200).Value = _Tipificacion
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 500).Value = _Observacion
            cms.Parameters.Add("@_Numero_Contrato", SqlDbType.BigInt).Value = _Numero_Contrato
            cms.Parameters.Add("@_Cod_Factura_Codensa", SqlDbType.BigInt).Value = _Cod_Factura_Codensa
            cms.Parameters.Add("@_IBS", SqlDbType.BigInt).Value = _IBS
            cms.Parameters.Add("@_TipoLlamada", SqlDbType.VarChar, 50).Value = _TipoLlamada
            cms.Parameters.Add("@_ComoSeEntero", SqlDbType.VarChar, 50).Value = _ComoSeEntero
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

    'Guarda la informacion de las ventas
    Public Sub Guardar_Ventas()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Direct_TV_Ventas(Fk_Id_Direct_TV_Cliente, Fk_Id_Direct_TV_Caso, Tipo_Plan, Desc_Plan) values (@_Fk_Id_Direct_TV_Cliente, @_Fk_Id_Direct_TV_Caso, @_Tipo_Plan, @_Desc_Plan)"
            cms.Parameters.Add("@_Fk_Id_Direct_TV_Cliente", SqlDbType.BigInt).Value = _Id_Direct_TV_Cliente
            cms.Parameters.Add("@_Fk_Id_Direct_TV_Caso", SqlDbType.BigInt).Value = _Id_Direct_TV_Caso
            cms.Parameters.Add("@_Tipo_Plan", SqlDbType.VarChar, 20).Value = _Tipo_Plan
            cms.Parameters.Add("@_Desc_Plan", SqlDbType.VarChar, 200).Value = _Descripcion_Plan
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


    'Guarda la informacion de los referidos
    Public Sub Guardar_Referidos()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Direct_TV_Referidos(Id_Referido, Nom_Referido, Id_Referente) values (@_Id_Referido, @_Nom_Referido, @_Id_Referente)"
            cms.Parameters.Add("@_Id_Referido", SqlDbType.VarChar, 20).Value = _Telefono_Referido
            cms.Parameters.Add("@_Nom_Referido", SqlDbType.VarChar, 100).Value = _Nombre_Referido
            cms.Parameters.Add("@_Id_Referente", SqlDbType.VarChar, 20).Value = _Id_Cliente
            cms.Connection = cn
            cms.ExecuteNonQuery()
            cms.CommandText = "INSERT INTO Direct_TV_Cliente(Nombre_Cliente, Id_Cliente) values (@_Nom_Referido, @_Id_Referido)"
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

    'obtiene el id del caso para ser guardado en ventas
    Public Function Obtener_Id_Caso() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select MAX(Id_Direct_TV_Caso) as Id_Direct_TV_Caso from Direct_TV_Caso where FK_Id_Cliente = @_FK_Id_Cliente"
            cms.Parameters.Add("@_FK_Id_Cliente", SqlDbType.VarChar, 20).Value = _Id_Cliente
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)

            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Id_Direct_TV_Caso") Is DBNull.Value Then
                    _Id_Direct_TV_Caso = ""
                Else
                    _Id_Direct_TV_Caso = dts.Tables(0).Rows(0).Item("Id_Direct_TV_Caso")
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
    'obtiene los datos ligados a un caso
    Public Function Obtener_Datos_Caso() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()

            If _Tipificacion <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where tipificacion=@_Tipificacion"
                cms.Parameters.Add("@_Tipificacion", SqlDbType.VarChar).Value = _Tipificacion
            End If
            If _Telefono_Cliente <> Nothing Then
                cms.CommandText = "select *,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Cliente where telefono_cliente=@_Telefono_Cliente"
                cms.Parameters.Add("@_Telefono_Cliente", SqlDbType.VarChar, 70).Value = _Telefono_Cliente
            End If
            If _Fcini <> Nothing And _Fcfin <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where Cas_Fc_Reg Between @_FechaIni AND @_Fechafin"
                cms.Parameters.Add("@_FechaIni", SqlDbType.VarChar, 100).Value = _Fcini
                cms.Parameters.Add("@_FechaFin", SqlDbType.VarChar, 100).Value = _Fcfin
            End If
            If InStr(1, _Id_Cliente, "R") <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= DTVCliente.Id_cliente  where DTVCliente.Id_Cliente = @_Id_Cliente"
                cms.Parameters.Add("@_Id_Cliente", SqlDbType.VarChar).Value = _Id_Cliente
            End If
            If _Id_Agente <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where id_agente=@_idusuario"
                cms.Parameters.Add("@_idusuario", SqlDbType.VarChar, 30).Value = _Id_Agente
            End If
            If _Id_Direct_TV_Cliente <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where DTVCliente.Id_Direct_TV_Cliente = @_Id_Direct_TV_Cliente"
                cms.Parameters.Add("@_Id_Direct_TV_Cliente", SqlDbType.BigInt).Value = _Id_Direct_TV_Cliente
            End If
            If _TipoLlamada <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where DTVCaso.TipoLlamada = @_TipoLlamada"
                cms.Parameters.Add("@_TipoLlamada", SqlDbType.VarChar, 50).Value = _TipoLlamada
            End If
            If _Tipificacion <> Nothing And _Id_Agente <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where id_agente=@_idusuario and tipificacion=@_Tipificacion "
            End If
            If _Id_Agente <> Nothing And _Fcini <> Nothing And _Fcfin <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where id_agente=@_idusuario and Cas_Fc_Reg Between @_FechaIni AND @_Fechafin"
            End If
            If _Tipificacion <> Nothing And _Fcini <> Nothing And _Fcfin <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where tipificacion=@_Tipificacion and Cas_Fc_Reg Between @_FechaIni AND @_Fechafin"
            End If
            If _Tipificacion <> Nothing And _Id_Agente <> Nothing And _Fcini <> Nothing And _Fcfin <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where tipificacion=@_Tipificacion and id_agente=@_idusuario and Cas_Fc_Reg Between @_FechaIni AND @_Fechafin"
            End If
            If _TipoLlamada <> Nothing And _Id_Agente <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where DTVCaso.TipoLlamada = @_TipoLlamada and id_agente=@_idusuario"
            End If
            If _TipoLlamada <> Nothing And _Fcini <> Nothing And _Fcfin <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where DTVCaso.TipoLlamada = @_TipoLlamada and Cas_Fc_Reg Between @_FechaIni AND @_Fechafin"
            End If
            If _TipoLlamada <> Nothing And _Tipificacion <> Nothing Then
                cms.CommandText = "select *,DTVCliente.Cod_Factura_Codensa as codensa,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Caso as DTVCaso left join Direct_TV_Cliente as DTVCliente on DTVCaso.FK_Id_Cliente= cast(DTVCliente.Id_Direct_TV_Cliente as varchar) where DTVCaso.TipoLlamada = @_TipoLlamada and tipificacion=@_Tipificacion"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Id_Direct_TV_Caso = 0
            'If dts.Tables(0).Rows.Count > 0 Then
            '    If dts.Tables(0).Rows(0).Item("Id_Direct_Tv_Cliente") Is DBNull.Value Then
            '        _Id_Direct_TV_Cliente = Nothing
            '    Else
            '        _Id_Direct_TV_Cliente = dts.Tables(0).Rows(0).Item("Id_Direct_Tv_Cliente")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Id_Direct_TV_Caso") Is DBNull.Value Then
            '        _Id_Direct_TV_Caso = ""
            '    Else
            '        _Id_Direct_TV_Caso = dts.Tables(0).Rows(0).Item("Id_Direct_TV_Caso")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Nombre_Cliente") Is DBNull.Value Then
            '        _Nombre_Cliente = ""
            '    Else
            '        _Nombre_Cliente = dts.Tables(0).Rows(0).Item("Nombre_Cliente")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Id_Cliente") Is DBNull.Value Then
            '        _Id_Cliente = ""
            '    Else
            '        _Id_Cliente = dts.Tables(0).Rows(0).Item("Id_Cliente")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Direccion") Is DBNull.Value Then
            '        _Direccion = ""
            '    Else
            '        _Direccion = dts.Tables(0).Rows(0).Item("Direccion")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Telefono_Cliente") Is DBNull.Value Then
            '        _Telefono_Cliente = ""
            '    Else
            '        _Telefono_Cliente = dts.Tables(0).Rows(0).Item("Telefono_Cliente")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Telefono_Cliente0") Is DBNull.Value Then
            '        _Telefono_Cliente0 = ""
            '    Else
            '        _Telefono_Cliente0 = dts.Tables(0).Rows(0).Item("Telefono_Cliente0")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Celular_Cliente") Is DBNull.Value Then
            '        _Celular_Cliente = ""
            '    Else
            '        _Celular_Cliente = dts.Tables(0).Rows(0).Item("Celular_Cliente")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Ciudad") Is DBNull.Value Then
            '        _Ciudad = ""
            '    Else
            '        _Ciudad = dts.Tables(0).Rows(0).Item("Ciudad")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Tipificacion") Is DBNull.Value Then
            '        _Tipificacion = ""
            '    Else
            '        _Tipificacion = dts.Tables(0).Rows(0).Item("Tipificacion")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Fc_Hr_Programacion") Is DBNull.Value Then
            '        _FechaProg = "01/01/2000 12:00:00"
            '    Else
            '        _FechaProg = dts.Tables(0).Rows(0).Item("Fc_Hr_Programacion")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Observacion") Is DBNull.Value Then
            '        _Observacion = ""
            '    Else
            '        _Observacion = dts.Tables(0).Rows(0).Item("Observacion")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Cedula_Cliente") Is DBNull.Value Then
            '        _Cedula_Cliente = Nothing
            '    Else
            '        _Cedula_Cliente = dts.Tables(0).Rows(0).Item("Cedula_Cliente")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Expedicion_Cedula") Is DBNull.Value Then
            '        _Expedicion_Cedula = ""
            '    Else
            '        _Expedicion_Cedula = dts.Tables(0).Rows(0).Item("Expedicion_Cedula")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Fc_Nacimiento") Is DBNull.Value Then
            '        _Fc_Nacimiento = Nothing
            '    Else
            '        _Fc_Nacimiento = dts.Tables(0).Rows(0).Item("Fc_Nacimiento")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Nombre_Contacto") Is DBNull.Value Then
            '        _Nombre_Contacto = ""
            '    Else
            '        _Nombre_Contacto = dts.Tables(0).Rows(0).Item("Nombre_Contacto")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Telefono_Contacto") Is DBNull.Value Then
            '        _Telefono_Contacto = Nothing
            '    Else
            '        _Telefono_Contacto = dts.Tables(0).Rows(0).Item("Telefono_Contacto")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Correo_Cliente") Is DBNull.Value Then
            '        _Correo_Cliente = Nothing
            '    Else
            '        _Correo_Cliente = dts.Tables(0).Rows(0).Item("Correo_Cliente")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Numero_Contrato") Is DBNull.Value Then
            '        _Numero_Contrato = Nothing
            '    Else
            '        _Numero_Contrato = dts.Tables(0).Rows(0).Item("Numero_Contrato")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("Cod_Factura_Codensa") Is DBNull.Value Then
            '        _Cod_Factura_Codensa = Nothing
            '    Else
            '        _Cod_Factura_Codensa = dts.Tables(0).Rows(0).Item("Cod_Factura_Codensa")
            '    End If
            '    If dts.Tables(0).Rows(0).Item("IBS") Is DBNull.Value Then
            '        _IBS = Nothing
            '    Else
            '        _IBS = dts.Tables(0).Rows(0).Item("IBS")
            '    End If
            'End If
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
    Public Function Obtener_Referentes() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()

            cms.CommandText = "select * from Direct_TV_Referidos DTVR inner join Direct_TV_Cliente DTVC on DTVR.Id_Referente= Convert(varchar(50),DTVC.Id_Direct_TV_Cliente) or DTVR.Id_Referente= Convert(varchar(50),DTVC.Id_Cliente) where Id_Referido = @_Id_Referido"



            cms.Parameters.Add("@_Id_Referido", SqlDbType.VarChar, 20).Value = _Id_Cliente
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)

            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Nombre_Cliente") Is DBNull.Value Then
                    _Nombre_Referente = ""
                Else
                    _Nombre_Referente = dts.Tables(0).Rows(0).Item("Nombre_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Id_Referente") Is DBNull.Value Then
                    _Id_Referente = ""
                Else
                    _Id_Referente = dts.Tables(0).Rows(0).Item("Id_Referente")
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

    Public Sub Guardar_Cliente_Nuevo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Direct_TV_Cliente(Nombre_Cliente, Telefono_Cliente, idusuario, fcreg) values (@_Nom_Cliente, @_Telefono_Cliente, @_idusuario, @_fcreg)"
            cms.Parameters.Add("@_Nom_Cliente", SqlDbType.VarChar, 100).Value = _Nombre_Cliente
            cms.Parameters.Add("@_Telefono_Cliente", SqlDbType.VarChar, 20).Value = _Telefono_Cliente
            cms.Parameters.Add("@_idusuario", SqlDbType.VarChar, 30).Value = _Id_Agente
            cms.Parameters.Add("@_fcreg", SqlDbType.DateTime).Value = Now
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

    Public Function Obtener_Ultimo_Cliente()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select Id_Direct_Tv_Cliente as ID from Direct_TV_Cliente where Nombre_Cliente= @_Nombre_Cliente AND Telefono_Cliente=@_Telefono_Cliente"
            cms.Parameters.Add("@_Nombre_Cliente", SqlDbType.VarChar, 100).Value = _Nombre_Cliente
            cms.Parameters.Add("@_Telefono_Cliente", SqlDbType.VarChar, 20).Value = _Telefono_Cliente
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)

            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("ID") Is DBNull.Value Then
                    _Id_Cliente = ""
                Else
                    _Id_Cliente = dts.Tables(0).Rows(0).Item("ID")
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

    'Obtener casos realizadas
    Public Function Obtener_Casos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "Select * from Direct_TV_Caso where FK_Id_Cliente = @_Id_Cliente order by Id_Direct_TV_Caso desc"
            cms.Parameters.Add("@_Id_Cliente", SqlDbType.VarChar, 20).Value = _Id_Cliente
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

    'Obtener cliente duplicado
    Public Function Cliente_Duplicado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from Direct_TV_Cliente where Nombre_Cliente= @_Nombre_Cliente AND Telefono_Cliente=@_Telefono_Cliente"
            cms.Parameters.Add("@_Nombre_Cliente", SqlDbType.VarChar, 100).Value = _Nombre_Cliente
            cms.Parameters.Add("@_Telefono_Cliente", SqlDbType.VarChar, 20).Value = _Telefono_Cliente
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function

    'Llena el drl de Como se entero
    Public Function ObtenerEntero() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from BD_Voz_Complemento where Pertenece='EnteroDTV' or Pertenece= '- Seleccione -' order by Nombre"
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
    'Llena el drl de Operador
    Public Function ObtenerOperador() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from BD_Voz_Complemento where Pertenece='OperadorDTV' or Pertenece= '- Seleccione -' order by Nombre"
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
    'Llena el drl de Ilocalizado Por
    Public Function ObtenerIlocalizado_Por() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from BD_Voz_Complemento where Pertenece='IlocalizableDTV' or Pertenece= '- Seleccione -' order by Nombre"
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
    '╔═══════════════════════════════════════╗'
    '║           Consulta Direct TV          ║'
    '╚═══════════════════════════════════════╝'

    'Llena el drl de Tipificaciones de consulta Direct - Tv
    Public Function ObtenerTipificacionconsulta() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select nombre from BD_Voz_Complemento where Pertenece='TipiDTVOUT' or Pertenece='TipiDTVIN' or Pertenece= '- Seleccione -' or Pertenece='TipiDTVINCONSULTA' group by nombre order by nombre"
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
    'Llena el drlagentes de Direct - Tv
    Public Function Agentesconsulta() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select idusuario,nombreu from usuarios where cargo='Directv' or cargo='- Seleccione -' order by nombreu"
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
    'consultar si el id cliente o referido ingresado a es el correcto:
    Public Function validarcliente() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            If _Validacion = "5" Then
                cms.CommandText = "SELECT id_cliente FROM Direct_Tv_Cliente where Id_Cliente = @_Id_Cliente"
                cms.Parameters.Add("@_Id_Cliente", SqlDbType.VarChar, 20).Value = _Id_Cliente
            End If
            If _Validacion = "6" Then
                cms.CommandText = "SELECT id_direct_tv_cliente FROM Direct_Tv_Cliente where Id_Direct_Tv_Cliente = @_Id_Cliente"
                cms.Parameters.Add("@_Id_Cliente", SqlDbType.VarChar, 20).Value = _Id_Direct_TV_Cliente
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    'consultar el id cliente para la primer grilla
    Public Function Consultageneralidcliente() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            If InStr(1, _Id_Cliente, "R") <> Nothing Then
                cms.CommandText = "select *,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Cliente where Id_Cliente = @_Id_Cliente"
                cms.Parameters.Add("@_Id_Cliente", SqlDbType.VarChar, 20).Value = _Id_Cliente
            Else
                cms.CommandText = "select *,Telefono_Cliente+' - '+Telefono_Cliente0 as Numeros_Asociados from Direct_TV_Cliente where Id_Direct_TV_Cliente = @_Id_Cliente"
                cms.Parameters.Add("@_Id_Cliente", SqlDbType.VarChar, 20).Value = _Id_Direct_TV_Cliente
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    'Consulta para enviar idusuario por codigo asesor
    Public Function Consultacodigoasesor() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idusuario,codnom FROM usuarios where codnom = @_idusuario"
            cms.Parameters.Add("@_idusuario", SqlDbType.VarChar, 30).Value = _Id_Agente
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count

            If Validacion = 1 Then
                If dtsrecepcion.Tables(0).Rows.Count > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("idusuario") Is DBNull.Value Then
                        _Id_Agente = ""
                    Else
                        _Id_Agente = dtsrecepcion.Tables(0).Rows(0).Item("idusuario")
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
End Class
