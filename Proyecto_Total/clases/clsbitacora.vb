Public Class clsbitacora
    Protected strlfcbitacora As String
    Protected strlhhinicio As String
    Protected strlproyecto As String
    Protected strltiempo As String
    Protected strldescripcion As String
    Protected strlidusuario As String
    Protected strlfcregistro As String
    Protected strlcantidad As String
    Public Property cantidad() As String
        Get
            Return strlcantidad
        End Get
        Set(ByVal value As String)
            strlcantidad = value
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
    Public Property descripcion() As String
        Get
            Return strldescripcion
        End Get
        Set(ByVal value As String)
            strldescripcion = value
        End Set
    End Property
    Public Property tiempo() As String
        Get
            Return strltiempo
        End Get
        Set(ByVal value As String)
            strltiempo = value
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
    Public Property hhinicio() As String
        Get
            Return strlhhinicio
        End Get
        Set(ByVal value As String)
            strlhhinicio = value
        End Set
    End Property
    Public Property fcbitacora() As String
        Get
            Return strlfcbitacora
        End Get
        Set(ByVal value As String)
            strlfcbitacora = value
        End Set
    End Property
    Public Sub registrobitac()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcregistro = Now
            cms.CommandText = "INSERT INTO bitacora(fcbitacora,hhinicio,tiempo,idproyecto,descripcion,idusuario,fcregistro) values(@strlfcbitacora,@strlhhinicio,@strltiempo,@strlproyecto,@strldescripcion,@strlidusuario,@strlfcregistro)"
            cms.Parameters.Add("@strlfcbitacora", SqlDbType.VarChar, 50).Value = strlfcbitacora
            cms.Parameters.Add("@strlhhinicio", SqlDbType.VarChar, 50).Value = strlhhinicio
            cms.Parameters.Add("@strltiempo", SqlDbType.Decimal).Value = strltiempo
            cms.Parameters.Add("@strlproyecto", SqlDbType.Int).Value = strlproyecto
            cms.Parameters.Add("@strldescripcion", SqlDbType.VarChar).Value = strldescripcion
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
    Public Function consultabitacora() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT * from Cons_bitacora where idusuario=@strlidusuario ORDER BY idbitacora DESC"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            If strlfcbitacora <> Nothing Then
                cms.CommandText = "SELECT * from Cons_bitacora where fcbitacora like '%'+@strlfcbitacora+'%' ORDER BY idbitacora DESC"
                cms.Parameters.Add("@strlfcbitacora", SqlDbType.VarChar, 50).Value = Me.strlfcbitacora
            End If
            If strlidusuario <> Nothing And strlfcbitacora <> Nothing Then
                cms.CommandText = "SELECT * from Cons_bitacora where idusuario=@strlidusuario and fcbitacora like '%'+@strlfcbitacora+'%' ORDER BY idbitacora DESC"
            End If
            If strlproyecto <> Nothing Then
                cms.CommandText = "SELECT * from Cons_bitacora where idproyecto=@strlproyecto ORDER BY idbitacora DESC"
                cms.Parameters.Add("@strlproyecto", SqlDbType.Int).Value = Me.strlproyecto
            End If
            If strlfcregistro <> Nothing Then
                cms.CommandText = "SELECT * from Cons_bitacora where fcregistro like '%'+@strlfcregistro+'%' ORDER BY idbitacora DESC"
                cms.Parameters.Add("@strlfcregistro", SqlDbType.VarChar, 50).Value = Me.strlfcregistro
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
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
