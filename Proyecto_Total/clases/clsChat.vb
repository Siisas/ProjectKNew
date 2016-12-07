Public Class clsChat
    ''Chat_Notas
    Protected _Cod_Chat_Notas As Integer
    Protected _Fecha_Creacion As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Aletar As Boolean
    ''Detalle_Chat_Notas
    Protected _Cod_Detalle_Chat_Notas As Integer
    Protected _Fecha_Reg As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Obs As String
    Protected _Fk_Idusuario As String
    Protected _Fk_Cod_Chat_Notas As Integer
    Protected _Id_Usuarios As String
    Protected _Cantidad As Integer

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property
    Public Property Id_Usuarios As String
        Get
            Return _Id_Usuarios
        End Get
        Set(ByVal value As String)
            _Id_Usuarios = value
        End Set
    End Property
    Public Property Fk_Cod_Chat_Notas As Integer
        Get
            Return _Fk_Cod_Chat_Notas
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Chat_Notas = value
        End Set
    End Property
    Public Property Fk_idusuario As String
        Get
            Return _Fk_idusuario
        End Get
        Set(ByVal value As String)
            _Fk_idusuario = value
        End Set
    End Property
    Public Property Obs As String
        Get
            Return _Obs
        End Get
        Set(ByVal value As String)
            _Obs = value
        End Set
    End Property
    Public Property Fecha_Reg As String
        Get
            Return _Fecha_Reg
        End Get
        Set(ByVal value As String)
            _Fecha_Reg = value
        End Set
    End Property
    Public Property Cod_Detalle_Chat_Notas As Integer
        Get
            Return _Cod_Detalle_Chat_Notas
        End Get
        Set(ByVal value As Integer)
            _Cod_Detalle_Chat_Notas = value
        End Set
    End Property
    Public Property Aletar As Boolean
        Get
            Return _Aletar
        End Get
        Set(ByVal value As Boolean)
            _Aletar = value
        End Set
    End Property
    Public Property Fecha_Creacion As String
        Get
            Return _Fecha_Creacion
        End Get
        Set(ByVal value As String)
            _Fecha_Creacion = value
        End Set
    End Property
    Public Property Cod_Chat_Notas As Integer
        Get
            Return _Cod_Chat_Notas
        End Get
        Set(ByVal value As Integer)
            _Cod_Chat_Notas = value
        End Set
    End Property

    Public Function Consulta_Grupos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand()
        Try
            cn.Open()
            cms.CommandText = "select cargo from usuarios where cargo like 'N%' or cargo like 'Q%' or cargo like 'B%' or nombreu='- Seleccione -' group by cargo order by cargo"
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
    Public Function Consulta_Agentes_Grupo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand()
        Try
            cn.Open()
            cms.CommandText = "select * from usuarios where cargo = @Grupo or nombreu='- Seleccione -' order by cargo"
            cms.Parameters.Add("@Grupo", SqlDbType.VarChar, 50).Value = _Fecha_Creacion
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
    Public Function Consulta_Registro_Chat() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand()
        Try
            cn.Open()
            cms.CommandText = "select CN.Cod_Chat_Notas,CN.fecha_Creacion,DCN.Cod_Detalle_Chat_Notas,DCN.Idusuario as Usuario,DCN.Fecha_Reg,DCN.Obs,DCN.Fk_idusuario,DCN.Fk_Cod_Chat_Notas,U.nombreu,U.cargo,U.perfil,U.codnom from Chat_Notas CN inner join Detalle_Chat_Notas DCN on CN.Cod_Chat_Notas = DCN.Fk_Cod_Chat_Notas inner join UsuariosVoz U on DCN.Fk_idusuario = U.idusuario where (DCN.Idusuario=@_Id_Usuarios and DCN.Fk_idusuario=@_Fk_idusuario) or (DCN.Idusuario=@_Fk_idusuario and DCN.Fk_idusuario=@_Id_Usuarios) order by Fecha_Reg desc"
            cms.Parameters.Add("@_Id_Usuarios", SqlDbType.VarChar, 50).Value = _Id_Usuarios
            cms.Parameters.Add("@_Fk_idusuario", SqlDbType.VarChar, 50).Value = _Fk_Idusuario
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If _Cod_Chat_Notas = dts.Tables(0).Rows(0).Item("Cod_Chat_Notas") Is DBNull.Value Then
                    _Cod_Chat_Notas = ""
                Else
                    _Cod_Chat_Notas = dts.Tables(0).Rows(0).Item("Cod_Chat_Notas")
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
    Public Function Consulta_Ultimo_Registro_Chat() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand()
        Try
            cn.Open()
            cms.CommandText = "select MAX(Cod_Chat_Notas) as Cod_Chat_Notas from Chat_Notas"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If _Cod_Chat_Notas = dts.Tables(0).Rows(0).Item("Cod_Chat_Notas") Is DBNull.Value Then
                    _Cod_Chat_Notas = ""
                Else
                    _Cod_Chat_Notas = dts.Tables(0).Rows(0).Item("Cod_Chat_Notas")
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
    Public Sub Ingresar_Mensaje()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "insert into Chat_Notas values (@_fecha_Creacion)"
            cms.Parameters.Add("@_Fecha_Creacion", SqlDbType.DateTime).Value = _Fecha_Creacion
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
    Public Sub Ingresar_Detalle_Mensaje()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Detalle_Chat_Notas values (@_Id_Usuarios,@_Fecha_Reg,@_Obs,@_Fk_idusuario,@_Alerta,@_Fk_Cod_Chat_Notas)"
            cms.Parameters.Add("@_Id_Usuarios", SqlDbType.VarChar, 50).Value = _Id_Usuarios
            cms.Parameters.Add("@_Fecha_Reg", SqlDbType.DateTime).Value = _Fecha_Reg
            cms.Parameters.Add("@_Obs", SqlDbType.VarChar, 1000).Value = _Obs
            cms.Parameters.Add("@_Fk_idusuario", SqlDbType.VarChar, 50).Value = _Fk_Idusuario
            cms.Parameters.Add("@_Alerta", SqlDbType.Bit).Value = _Aletar
            cms.Parameters.Add("@_Fk_Cod_Chat_Notas", SqlDbType.BigInt).Value = _Fk_Cod_Chat_Notas
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
    Public Function Consulta_Bandeja() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand()
        Try
            cn.Open()
            cms.CommandText = "select MAX(DCN.Cod_Detalle_Chat_Notas) as Cod_Detalle_Chat_Notas,U.idusuario,U.cargo,U.nombreu,DCN.Fk_idusuario,DCN.Fk_Cod_Chat_Notas,DCN.Fecha_Reg from clarovoz.dbo.Detalle_Chat_Notas DCN inner join datosclaro.dbo.usuarios U on DCN.Idusuario=U.idusuario where DCN.Fk_idusuario = @_Fk_Idusuario and DCN.Alerta=1 group by DCN.Fk_Cod_Chat_Notas,U.Idusuario,U.cargo,U.nombreu,DCN.Fk_Idusuario,DCN.Fecha_Reg"
            cms.Parameters.Add("@_Fk_Idusuario", SqlDbType.VarChar, 50).Value = _Fk_Idusuario
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
    Public Sub Actualizar_Alerta_Bandeja()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "update Detalle_Chat_Notas set  Alerta=0 where Fk_Cod_Chat_Notas = @_Fk_Cod_Chat_Notas"
            cms.Parameters.Add("@_Fk_Cod_Chat_Notas", SqlDbType.BigInt).Value = _Fk_Cod_Chat_Notas
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
End Class
