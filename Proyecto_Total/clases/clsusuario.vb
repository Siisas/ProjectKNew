
Public Class clsusuario
    Protected strlidusuario As String
    Protected strlnombre As String
    Protected strlperfil As String
    Protected bolpermiso As Boolean
    Protected strlcargo As String
    Protected strlNomPerfil As String
    Protected strlSuperv As String
    Protected strlCodnom As String
    Protected strlJefe As String
    Protected strlSegmento As String


    Public Property Codnom As String
        Get
            Return strlCodnom
        End Get
        Set(ByVal value As String)
            strlCodnom = value
        End Set
    End Property
    Public Property Superv As String
        Get
            Return strlSuperv
        End Get
        Set(ByVal value As String)
            strlSuperv = value
        End Set
    End Property
    Public Property NomPerfil As String
        Get
            Return strlNomPerfil
        End Get
        Set(ByVal value As String)
            strlNomPerfil = value
        End Set
    End Property
    Public Property perfil() As String
        Get
            Return strlperfil
        End Get
        Set(ByVal Value As String)
            strlperfil = Value
        End Set
    End Property

    Public Property usuario() As String
        Get
            Return strlidusuario
        End Get
        Set(ByVal Value As String)
            strlidusuario = Value
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
    Public Property permiso() As Boolean
        Get
            Return bolpermiso
        End Get
        Set(ByVal Value As Boolean)
            bolpermiso = Value
        End Set
    End Property
    Public Property Jefe As String
        Get
            Return strlJefe
        End Get
        Set(ByVal value As String)
            strlJefe = value
        End Set
    End Property
    Public Property Segmento As String
        Get
            Return strlSegmento
        End Get
        Set(ByVal value As String)
            strlSegmento = value
        End Set
    End Property

    Protected _Passwor As String
    Public Property Passwor As String
        Get
            Return _Passwor
        End Get
        Set(ByVal value As String)
            _Passwor = value
        End Set
    End Property

    Protected Conexion_General = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
    Protected Conexion_datosclaro = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)

    Public Function Validar_Usuario()
        Try
            Dim Dts As New DataSet
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Scm As New SqlClient.SqlCommand
            Conexion_datosclaro.Open()
            Scm.CommandText = "SELECT COUNT(idusuario) As Val FROM datosclaro.dbo.usuarios WHERE idusuario = @_Id_Usuario And pwd = @_Password"
            Scm.Parameters.AddWithValue("@_Id_Usuario", strlidusuario)
            Scm.Parameters.AddWithValue("@_Password", _Passwor)
            Scm.Connection = Conexion_datosclaro
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Scm.Parameters.Clear()
            If Dts.Tables(0).Rows(0).Item("Val").ToString = "0" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            _Passwor = Nothing
            If Conexion_datosclaro.State = ConnectionState.Open Then
                Conexion_datosclaro.Close()
            End If
        End Try
    End Function


    Public Function Consultar_Usuario()
        Try
            Dim Dts As New DataSet
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Scm As New SqlClient.SqlCommand
            Conexion_General.Open()
            Scm.Parameters.AddWithValue("@_Id_Usuario", strlidusuario)
            Scm.Connection = Conexion_General
            Scm.CommandText = "SELECT Distinct U.idusuario, U.nombreu, U.perfil,U.cargo, P.descriperfil, U.codnom, U.Supervisor, P.idperfil, P.descriperfil, Av.Jefe_Inmediato, Av.segmento FROM datosclaro.dbo.usuarios U Inner join datosclaro.dbo.Perfil P on U.perfil = P.idperfil Left join admin_cham.dbo.Validacion_Horario Av On Av.Cod_Agente = U.codnom and convert(date,Av.Fc_Ingreso) = convert(date,Getdate()) WHERE U.idusuario Like @_Id_Usuario"
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Scm.Parameters.Clear()

            strlnombre = Dts.Tables(0).Rows(0).Item("nombreu")
            strlperfil = Dts.Tables(0).Rows(0).Item("perfil")
            strlcargo = Dts.Tables(0).Rows(0).Item("cargo")
            strlNomPerfil = Dts.Tables(0).Rows(0).Item("descriperfil")
            strlCodnom = Dts.Tables(0).Rows(0).Item("codnom")
            If Dts.Tables(0).Rows(0).Item("supervisor") Is DBNull.Value Then
                strlSuperv = ""
            Else
                strlSuperv = Dts.Tables(0).Rows(0).Item("supervisor")
            End If
            If Dts.Tables(0).Rows(0).Item("Jefe_Inmediato") Is DBNull.Value Then
                strlJefe = ""
            Else
                strlJefe = Dts.Tables(0).Rows(0).Item("Jefe_Inmediato")
            End If
            If Dts.Tables(0).Rows(0).Item("segmento") Is DBNull.Value Then
                strlSegmento = ""
            Else
                strlSegmento = Dts.Tables(0).Rows(0).Item("segmento")
            End If
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            If Conexion_General.State = ConnectionState.Open Then
                Conexion_General.Close()
            End If
        End Try
    End Function

    Public Function Cambiar_Password()
        Dim Scm As New SqlClient.SqlCommand
        Try
            Conexion_datosclaro.Open()
            Scm.CommandText = "UPDATE datosclaro.dbo.usuarios SET pwd = @strlpwd WHERE idusuario= @strlidusuario"
            Scm.Parameters.AddWithValue("@strlpwd", _Passwor)
            Scm.Parameters.AddWithValue("@strlidusuario", strlidusuario)
            Scm.Connection = Conexion_datosclaro
            Return Scm.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Conexion_datosclaro.State = ConnectionState.Open Then
                Conexion_datosclaro.Close()
            End If
        End Try
    End Function

  
End Class
