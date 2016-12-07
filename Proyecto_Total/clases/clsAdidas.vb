
Public Class clsAdidas

    Protected _Tarjeta As String
    Protected _Telefono As String
    Protected _Fc_Nacimiento As String
    Protected _Tipificacion As String
    Protected _Observacion As String
    Protected _Usuario As String

    Public Property Tarjeta() As String
        Get
            Return _Tarjeta
        End Get
        Set(ByVal value As String)
            _Tarjeta = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Fc_Nacimiento() As String
        Get
            Return _Fc_Nacimiento
        End Get
        Set(ByVal value As String)
            _Fc_Nacimiento = value
        End Set
    End Property
    Public Property Tipificacion() As String
        Get
            Return _Tipificacion
        End Get
        Set(ByVal value As String)
            _Tipificacion = value
        End Set
    End Property
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
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

    Public Sub registro_tarjeta()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Adidas (Id_Usuario,Tarjeta,Tipificacion,Telefono,Observacion) values(@usu,@tar,@tip,@tel,@obs)"
            If _Fc_Nacimiento <> Nothing Then
                cms.CommandText = "INSERT INTO Adidas (Id_Usuario,Tarjeta,Fc_Nacimiento,Tipificacion,Telefono,Observacion) values(@usu,@tar,@fc_n,@tip,@tel,@obs)"
                cms.Parameters.Add("@fc_n", SqlDbType.VarChar, 10).Value = _Fc_Nacimiento
            End If
            cms.Parameters.Add("@tar", SqlDbType.VarChar, 10).Value = _Tarjeta
            cms.Parameters.Add("@tel", SqlDbType.VarChar, 10).Value = _Telefono
            cms.Parameters.Add("@tip", SqlDbType.VarChar, 15).Value = _Tipificacion
            cms.Parameters.Add("@obs", SqlDbType.VarChar, 200).Value = _Observacion
            cms.Parameters.Add("@usu", SqlDbType.VarChar, 30).Value = _Usuario
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

    Public Function Consulta_tip() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select * from BD_Voz_Complemento where Pertenece = 'Adidas' or Pertenece = '- Seleccione -'  Order by Nombre"
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
