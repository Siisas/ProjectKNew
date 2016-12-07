Public Class clsHelpDesk

    Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
    Dim dta As New SqlClient.SqlDataAdapter
    Dim dts As New DataSet



    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''' Help Desk Registro '''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Protected _Cod_HelpDesk_Registro As Integer
    Protected _Fecha_Registro As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Id_Usuario As String
    Protected _Observacion As String
    Protected _Prioridad As String
    Protected _Tema As String
    Protected _Estado As String
    Protected _Fecha_Inicio As String
    Protected _Fecha_Fin As String
    Protected _Cantidad As Integer
    Protected _Modulo As String
    Protected _Fk_Cod_Canal As Integer
    Protected _Fk_Cod_Categoria As Integer
    Protected _Fk_Cod_Tipo As Integer
    Protected _Persona_Reporta As String
    Protected _Asignado As String
    Protected _Asigna As String
    Protected _ObservacionAsigna As String
    Protected _Fk_Cod_Complemento_Area As Integer
    Protected _Fk_Complejidad As Integer
    Protected _Fk_Operatividad As Integer
    Protected _Validacion As Integer
    Protected _reiteracion As Integer

    Public Property reiteracion As Integer
        Get
            Return _reiteracion
        End Get
        Set(ByVal value As Integer)
            _reiteracion = value
        End Set
    End Property



    '############ © Gerson Brain Sanchez ##############
    Protected _Cod_Ticket As String
    Public Property Cod_Ticket As String
        Get
            Return _Cod_Ticket
        End Get
        Set(ByVal value As String)
            _Cod_Ticket = value
        End Set
    End Property
    Protected _Descripcion As String
    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
    Protected _Cod_Calificacion As String
    Public Property Cod_Calificacion As Integer
        Get
            Return _Cod_Calificacion
        End Get
        Set(ByVal value As Integer)
            _Cod_Calificacion = value
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


    Public Property validacion As Integer
        Get
            Return _Validacion
        End Get
        Set(ByVal value As Integer)
            _Validacion = value
        End Set
    End Property
    Public Property Fk_Complejidad As Integer
        Get
            Return _Fk_Complejidad
        End Get
        Set(ByVal value As Integer)
            _Fk_Complejidad = value
        End Set
    End Property
    Public Property Fk_Operatividad As Integer
        Get
            Return _Fk_Operatividad
        End Get
        Set(ByVal value As Integer)
            _Fk_Operatividad = value
        End Set
    End Property
    Public Property Fk_Cod_Complemento_Area As Integer
        Get
            Return _Fk_Cod_Complemento_Area
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Complemento_Area = value
        End Set
    End Property
    Public Property ObservacionAsigna As String
        Get
            Return _ObservacionAsigna
        End Get
        Set(ByVal value As String)
            _ObservacionAsigna = value
        End Set
    End Property
    Public Property Asigna As String
        Get
            Return _Asigna
        End Get
        Set(ByVal value As String)
            _Asigna = value
        End Set
    End Property
    Public Property Asignado As String
        Get
            Return _Asignado
        End Get
        Set(ByVal value As String)
            _Asignado = value
        End Set
    End Property
    Public Property Persona_Reporta As String
        Get
            Return _Persona_Reporta
        End Get
        Set(ByVal value As String)
            _Persona_Reporta = value
        End Set
    End Property
    Public Property Fk_Cod_Tipo As Integer
        Get
            Return _Fk_Cod_Tipo
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Tipo = value
        End Set
    End Property
    Public Property Fk_Cod_Categoria As Integer
        Get
            Return _Fk_Cod_Categoria
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Categoria = value
        End Set
    End Property
    Public Property Fk_Cod_Canal As Integer
        Get
            Return _Fk_Cod_Canal
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Canal = value
        End Set
    End Property
    Public Property Modulo As String
        Get
            Return _Modulo
        End Get
        Set(ByVal value As String)
            _Modulo = value
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
    Public Property Fecha_Fin As String
        Get
            Return _Fecha_Fin
        End Get
        Set(ByVal value As String)
            _Fecha_Fin = value
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
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property
    Public Property Tema As String
        Get
            Return _Tema
        End Get
        Set(ByVal value As String)
            _Tema = value
        End Set
    End Property
    Public Property Prioridad As String
        Get
            Return _Prioridad
        End Get
        Set(ByVal value As String)
            _Prioridad = value
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
    Public Property Id_Usuario As String
        Get
            Return _Id_Usuario
        End Get
        Set(ByVal value As String)
            _Id_Usuario = value
        End Set
    End Property
    Public Property Fecha_Registro As String
        Get
            Return _Fecha_Registro
        End Get
        Set(ByVal value As String)
            _Fecha_Registro = value
        End Set
    End Property
    Public Property Cod_HelpDesk_Registro As Integer
        Get
            Return _Cod_HelpDesk_Registro
        End Get
        Set(ByVal value As Integer)
            _Cod_HelpDesk_Registro = value
        End Set
    End Property

       Public Sub IngresarTicket()
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "insert into HelpDesk_Registro (Fecha_Registro,Id_Usuario,Prioridad,Tema,Observacion,Estado,Fk_Cod_Canal,Persona_Reporta,Modulo,Fk_Cod_Complemento_Area) values (@_Fecha_Registro,@_Id_Usuario,@_Prioridad,@_Tema,@_Observacion,@_Estado,@_Fk_Cod_Canal,@_Persona_Reporta,@_Modulo,@_Fk_Cod_Complemento_Area)"
            cms.Parameters.Add("@_Fecha_Registro", SqlDbType.DateTime).Value = _Fecha_Registro
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_Prioridad", SqlDbType.VarChar, 50).Value = _Prioridad
            cms.Parameters.Add("@_Tema", SqlDbType.VarChar, 50).Value = _Tema
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 750).Value = _Observacion
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            cms.Parameters.Add("@_Fk_Cod_Canal", SqlDbType.Int).Value = _Fk_Cod_Canal
            cms.Parameters.Add("@_Persona_Reporta", SqlDbType.VarChar, 60).Value = _Persona_Reporta
            cms.Parameters.Add("@_Modulo", SqlDbType.VarChar, 5).Value = _Modulo
            cms.Parameters.Add("@_Fk_Cod_Complemento_Area", SqlDbType.Int).Value = _Fk_Cod_Complemento_Area
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

    Public Function Consulta_Categoria() As DataSet
        Try
            Dim cms As New SqlClient.SqlCommand
            dts = New DataSet
            cn.Open()
            cms.CommandText = "select * from HelpDesk_Categoria"
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
    Public Function Consulta_Tipo() As DataSet
        Try
            Dim cms As New SqlClient.SqlCommand
            dts = New DataSet
            cn.Open()
            cms.CommandText = "select * from HelpDesk_Tipo where FK_HelpDesk_Categoria=@_Cod_HelpDesk_Registro order by Nombre"
            cms.Parameters.Add("@_Cod_HelpDesk_Registro", SqlDbType.Int).Value = _Cod_HelpDesk_Registro
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
    Public Function Consulta_Canal() As DataSet
        Try
            Dim cms As New SqlClient.SqlCommand
            dts = New DataSet
            cn.Open()
            cms.CommandText = "select * from HelpDesk_Canal"
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
    Public Function ConsultaTicket() As DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            dts = New DataSet
            If _Id_Usuario <> Nothing Then
                cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna,ObservacionAsigna,HC.Nombre as Area,Reiteracion from HelpDesk_Registro HD inner join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal  left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento where Id_Usuario= @_Id_Usuario  order by HD.Fecha_Registro asc"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            End If
            If _Id_Usuario <> Nothing And (_Fecha_Inicio <> Nothing Or _Fecha_Fin <> Nothing) Then
                If _Fecha_Inicio <> Nothing And _Fecha_Fin <> Nothing Then
                    cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna,ObservacionAsigna,HC.Nombre as Area,Reiteracion from HelpDesk_Registro HD inner join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal  left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento where Id_Usuario=@_Id_Usuario and HD.Fecha_Registro between @_Fecha_Inicio and @_Fecha_Fin order by HD.Cod_HelpDesk_Registro desc"
                    cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.DateTime).Value = _Fecha_Inicio
                    cms.Parameters.Add("@_Fecha_Fin", SqlDbType.DateTime).Value = _Fecha_Fin
                Else
                    If _Fecha_Inicio <> Nothing Then
                        cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna,ObservacionAsigna,HC.Nombre as Area,Reiteracion from HelpDesk_Registro HD inner join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal  left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento where Id_Usuario=@_Id_Usuario and HD.Fecha_Registro >=@_Fecha_Inicio order by HD.Cod_HelpDesk_Registro desc"
                        cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.DateTime).Value = _Fecha_Inicio
                    End If
                    If _Fecha_Fin <> Nothing Then
                        cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna,ObservacionAsigna,HC.Nombre as Area,Reiteracion from HelpDesk_Registro HD inner join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal  left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento where Id_Usuario=@_Id_Usuario and HD.Fecha_Registro <=@_Fecha_Fin order by HD.Cod_HelpDesk_Registro desc"
                        cms.Parameters.Add("@_Fecha_Fin", SqlDbType.DateTime).Value = _Fecha_Fin
                    End If
                End If
            End If
            If _Cod_HelpDesk_Registro <> Nothing Then
                cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna,ObservacionAsigna,HC.Nombre as Area,Reiteracion from HelpDesk_Registro HD inner join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal  left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento where HD.Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro1 order by HD.Cod_HelpDesk_Registro desc"
                cms.Parameters.Add("@_Cod_HelpDesk_Registro1", SqlDbType.Int).Value = _Cod_HelpDesk_Registro
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dts = New DataSet
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

    Public Function Consulta_Proceso() As DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            dts = New DataSet
            cms.CommandText = "select H.*,C.Nombre As Categoria, T.Nombre As Tipo from HelpDesk_Solucion H LEFT JOIN HelpDesk_Categoria C ON C.Cod_HelpDesk_Categoria = Fk_Cod_Categoria LEFT JOIN HelpDesk_Tipo T ON T.Cod_HelpDesk_Tipo = Fk_Cod_Tipo where Fk_Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
            cms.Parameters.Add("@_Cod_HelpDesk_Registro", SqlDbType.Int).Value = _Cod_HelpDesk_Registro
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(_Cantidad - 1).Item("Fk_Cod_Categoria") Is DBNull.Value Then
                    _Fk_Cod_Categoria = 0
                Else
                    _Fk_Cod_Categoria = dts.Tables(0).Rows(_Cantidad - 1).Item("Fk_Cod_Categoria")
                End If
                If dts.Tables(0).Rows(_Cantidad - 1).Item("Fk_Cod_Tipo") Is DBNull.Value Then
                    _Fk_Cod_Tipo = 0
                Else
                    _Fk_Cod_Tipo = dts.Tables(0).Rows(_Cantidad - 1).Item("Fk_Cod_Tipo")
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


    Public Function Codigo_Registro() As DataSet
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            dts = New DataSet
            cms.CommandText = "select MAX(Cod_HelpDesk_Registro)as Codigo from HelpDesk_Registro"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Codigo") Is DBNull.Value Then
                    _Cod_HelpDesk_Registro = ""
                Else
                    _Cod_HelpDesk_Registro = dts.Tables(0).Rows(0).Item("Codigo")
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


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''' Help Desk Asignacion ''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Protected _Fecha_Asigna As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

    Public Property Fecha_Asigna As String
        Get
            Return _Fecha_Asigna
        End Get
        Set(ByVal value As String)
            _Fecha_Asigna = value
        End Set
    End Property

    Public Sub UpdateTicketAsignado()
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "update HelpDesk_Registro set Asignado = @_Asignado, Asigna=@_Asigna,Fecha_Asigna=@_Fecha_Asigan,ObservacionAsigna=@_ObservacionAsigna where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
            If _Prioridad <> Nothing Then
                cms.CommandText = "update HelpDesk_Registro set Asignado = @_Asignado, Asigna=@_Asigna,Fecha_Asigna=@_Fecha_Asigan,ObservacionAsigna=@_ObservacionAsigna,Prioridad=@_Prioridad where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
                cms.Parameters.Add("@_Prioridad", SqlDbType.VarChar, 50).Value = _Prioridad
            End If
            If _Fk_Cod_Complemento_Area <> Nothing Then
                cms.CommandText = "update HelpDesk_Registro set Asignado = @_Asignado, Asigna=@_Asigna,Fecha_Asigna=@_Fecha_Asigan,ObservacionAsigna=@_ObservacionAsigna,Fk_Cod_Complemento_Area=@_Fk_Cod_Complemento_Area where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
                cms.Parameters.Add("@_Fk_Cod_Complemento_Area", SqlDbType.BigInt).Value = _Fk_Cod_Complemento_Area
            End If
            If _Fk_Cod_Categoria <> Nothing And _Fk_Cod_Tipo <> Nothing Then
                cms.CommandText = "update HelpDesk_Registro set Asignado = @_Asignado, Asigna=@_Asigna,Fecha_Asigna=@_Fecha_Asigan,ObservacionAsigna=@_ObservacionAsigna,Fk_Cod_Categoria=@_Fk_Cod_Categoria,Fk_Cod_Tipo=@_Fk_Cod_Tipo where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
                cms.Parameters.Add("@_Fk_Cod_Categoria", SqlDbType.BigInt).Value = _Fk_Cod_Categoria
                cms.Parameters.Add("@_Fk_Cod_Tipo", SqlDbType.BigInt).Value = _Fk_Cod_Tipo
            End If
            If _Prioridad <> Nothing And _Fk_Cod_Complemento_Area <> Nothing Then
                cms.CommandText = "update HelpDesk_Registro set Asignado = @_Asignado, Asigna=@_Asigna,Fecha_Asigna=@_Fecha_Asigan,ObservacionAsigna=@_ObservacionAsigna,Prioridad=@_Prioridad,Fk_Cod_Complemento_Area=@_Fk_Cod_Complemento_Area where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
            End If
            If _Prioridad <> Nothing And _Fk_Cod_Categoria <> Nothing And _Fk_Cod_Tipo <> Nothing Then
                cms.CommandText = "update HelpDesk_Registro set Asignado = @_Asignado, Asigna=@_Asigna,Fecha_Asigna=@_Fecha_Asigan,ObservacionAsigna=@_ObservacionAsigna,Prioridad=@_Prioridad,Fk_Cod_Categoria=@_Fk_Cod_Categoria,Fk_Cod_Tipo=@_Fk_Cod_Tipo where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
            End If
            If _Fk_Cod_Complemento_Area <> Nothing And _Fk_Cod_Categoria <> Nothing And _Fk_Cod_Tipo <> Nothing Then
                cms.CommandText = "update HelpDesk_Registro set Asignado = @_Asignado, Asigna=@_Asigna,Fecha_Asigna=@_Fecha_Asigan,ObservacionAsigna=@_ObservacionAsigna,Fk_Cod_Complemento_Area=@_Fk_Cod_Complemento_Area,Fk_Cod_Categoria=@_Fk_Cod_Categoria,Fk_Cod_Tipo=@_Fk_Cod_Tipo where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
            End If
            If _Prioridad <> Nothing And _Fk_Cod_Categoria <> Nothing And _Fk_Cod_Tipo <> Nothing And _Fk_Cod_Complemento_Area <> Nothing Then
                cms.CommandText = "update HelpDesk_Registro set Asignado = @_Asignado, Asigna=@_Asigna,Fecha_Asigna=@_Fecha_Asigan,ObservacionAsigna=@_ObservacionAsigna,Prioridad=@_Prioridad,Fk_Cod_Categoria=@_Fk_Cod_Categoria,Fk_Cod_Tipo=@_Fk_Cod_Tipo,Fk_Cod_Complemento_Area=@_Fk_Cod_Complemento_Area where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
            End If
            cms.Parameters.Add("@_Cod_HelpDesk_Registro", SqlDbType.BigInt).Value = _Cod_HelpDesk_Registro
            cms.Parameters.Add("@_Asignado", SqlDbType.VarChar, 60).Value = _Asignado
            cms.Parameters.Add("@_Asigna", SqlDbType.VarChar, 60).Value = _Asigna
            cms.Parameters.Add("@_Fecha_Asigan", SqlDbType.VarChar, 50).Value = _Fecha_Asigna
            cms.Parameters.Add("@_ObservacionAsigna", SqlDbType.VarChar, 750).Value = _ObservacionAsigna
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
    Public Function ConsultaTodosTicketAsigna() As DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
            cn.Open()
            Dim cod As String
            dts = New DataSet
            cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,U.codnom,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,HDPla.Nombre as Categoria, HDCat.Nombre as Tipo,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna,HC.Nombre as Area from HelpDesk_Registro HD inner join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal LEFT join HelpDesk_Categoria HDPla on HD.Fk_Cod_Categoria = HDPla.Cod_HelpDesk_Categoria LEFT join  HelpDesk_Tipo HDCat on HD.Fk_Cod_Tipo = HDCat.Cod_HelpDesk_Tipo left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento LEFT join datosclaro.dbo.usuarios U on HD.Id_Usuario=U.idusuario where Asignado is null and Asigna is null and Fecha_Asigna is null and ObservacionAsigna is null order by HD.Fecha_Registro asc"
            If _Fecha_Inicio <> Nothing Or _Fecha_Fin <> Nothing Or _Prioridad <> Nothing Or _Estado <> Nothing Or _Cod_HelpDesk_Registro <> Nothing Or _Persona_Reporta <> Nothing Then

                ''Fecha Inicio
                If _Fecha_Inicio <> Nothing Then
                    _Fecha_Inicio = " and Fecha_Registro >= '" & _Fecha_Inicio & "'"
                Else
                    _Fecha_Inicio = ""
                End If
                ''Fecha Fin
                If _Fecha_Fin <> Nothing Then
                    _Fecha_Fin = " and Fecha_Registro <= '" & _Fecha_Fin & "'"
                Else
                    _Fecha_Fin = ""
                End If
                ''Prioridad
                If _Prioridad <> Nothing Then
                    _Prioridad = " and Prioridad = '" & _Prioridad & "'"
                Else
                    _Prioridad = ""
                End If
                ''Estado
                If _Estado <> Nothing Then
                    _Estado = " and Estado='" & _Estado & "'"
                Else
                    _Estado = ""
                End If
                'usuario
                If _Persona_Reporta <> Nothing Then
                    _Persona_Reporta = " and U.codnom='" & _Persona_Reporta & "'"
                Else
                    _Persona_Reporta = ""
                End If
                'codigo
                If _Cod_HelpDesk_Registro <> Nothing Then
                    cod = " and HD.Cod_HelpDesk_Registro='" & _Cod_HelpDesk_Registro & "'"
                Else
                    cod = ""
                End If
                cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,U.codnom,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,HDPla.Nombre as Categoria,HDCat.Nombre as Tipo,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna,HC.Nombre as Area from HelpDesk_Registro HD inner join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal LEFT join HelpDesk_Categoria HDPla on HD.Fk_Cod_Categoria = HDPla.Cod_HelpDesk_Categoria LEFT join HelpDesk_Tipo HDCat on HD.Fk_Cod_Tipo = HDCat.Cod_HelpDesk_Tipo left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento LEFT join datosclaro.dbo.usuarios U on HD.Id_Usuario=U.idusuario where Cod_HelpDesk_Registro is not null " & _Fecha_Inicio & _Fecha_Fin & _Prioridad & _Estado & _Persona_Reporta & cod & " order by HD.Fecha_Registro asc"
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

    Public Function ConsultaTicketAsigna() As DataSet
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim intcantidad As Int64
            cn.Open()
            dts = New DataSet
            cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,HDPla.Nombre as Categoria,HDCat.Nombre as Tipo,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna from HelpDesk_Registro HD inner join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal left join HelpDesk_Categoria HDPla on HD.Fk_Cod_Categoria = HDPla.Cod_HelpDesk_Categoria left join HelpDesk_Tipo HDCat on HD.Fk_Cod_Tipo = HDCat.Cod_HelpDesk_Tipo where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro order by HD.Fecha_Registro desc"
            cms.Parameters.Add("@_Cod_HelpDesk_Registro", SqlDbType.BigInt).Value = _Cod_HelpDesk_Registro
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_HelpDesk_Registro") Is System.DBNull.Value Then
                    _Cod_HelpDesk_Registro = ""
                Else
                    _Cod_HelpDesk_Registro = dts.Tables(0).Rows(0).Item("Cod_HelpDesk_Registro")
                End If
                If dts.Tables(0).Rows(0).Item("Fecha_Registro") Is System.DBNull.Value Then
                    _Fecha_Registro = ""
                Else
                    _Fecha_Registro = dts.Tables(0).Rows(0).Item("Fecha_Registro")
                End If
                If dts.Tables(0).Rows(0).Item("Id_Usuario") Is System.DBNull.Value Then
                    _Id_Usuario = ""
                Else
                    _Id_Usuario = dts.Tables(0).Rows(0).Item("Id_Usuario")
                End If
                If dts.Tables(0).Rows(0).Item("Prioridad") Is System.DBNull.Value Then
                    _Prioridad = ""
                Else
                    _Prioridad = dts.Tables(0).Rows(0).Item("Prioridad")
                End If
                If dts.Tables(0).Rows(0).Item("Tema") Is System.DBNull.Value Then
                    _Tema = ""
                Else
                    _Tema = dts.Tables(0).Rows(0).Item("Tema")
                End If
                If dts.Tables(0).Rows(0).Item("Observacion") Is System.DBNull.Value Then
                    _Observacion = ""
                Else
                    _Observacion = dts.Tables(0).Rows(0).Item("Observacion")
                End If
                If dts.Tables(0).Rows(0).Item("Estado") Is System.DBNull.Value Then
                    _Estado = ""
                Else
                    _Estado = dts.Tables(0).Rows(0).Item("Estado")
                End If
                If dts.Tables(0).Rows(0).Item("Estado") Is System.DBNull.Value Then
                    _Estado = ""
                Else
                    _Estado = dts.Tables(0).Rows(0).Item("Estado")
                End If
                If dts.Tables(0).Rows(0).Item("Persona_Reporta") Is System.DBNull.Value Then
                    _Persona_Reporta = ""
                Else
                    _Persona_Reporta = dts.Tables(0).Rows(0).Item("Persona_Reporta")
                End If
            Else
                dts = New DataSet
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

    Public Function Consulta_Tecnico()
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            dts = New DataSet
            cms.CommandText = "select nombreu,idusuario from usuarios where cargo = 'N0_G2' or cargo='- Seleccione -' order by cargo"
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

    Public Function Consulta_Tecnico_AutoAsigna()
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            dts = New DataSet
            cms.CommandText = "select * from usuarios where cargo = 'N0_G2' and idusuario=@_Id_Usuario"
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
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

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''' Help Desk Solucion '''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Protected _Cod_HelpDesk_Solucion As Integer
    'Variable ya declarada en el Registro de Help desk 'Protected _Fecha_Registro As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    'Variable ya declarada en el Registro de Help desk 'Protected _Id_Usuario As String
    'Variable ya declarada en el Registro de Help desk 'Protected _Observacion As String
    'Variable ya declarada en el Registro de Help desk 'Protected _Estado As String
    Protected _Fk_Cod_HelpDesk_Registro As Integer
    Protected _Nombre As String

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Cod_HelpDesk_Solucion() As Integer
        Get
            Return _Cod_HelpDesk_Solucion
        End Get
        Set(ByVal value As Integer)
            _Cod_HelpDesk_Solucion = value
        End Set
    End Property
    Public Property Fk_Cod_HelpDesk_Registro As Integer
        Get
            Return _Fk_Cod_HelpDesk_Registro
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_HelpDesk_Registro = value
        End Set
    End Property
    Public Function ConsultaTicketGestion() As DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
            cn.Open()
            Dim cod As String
            dts = New DataSet
            ''Filtros
            'Fecha Inicio
            If _Fecha_Inicio <> Nothing Then
                _Fecha_Inicio = " and HD.Fecha_Registro >= '" & _Fecha_Inicio & "'"
            Else
                _Fecha_Inicio = ""
            End If
            'Fecha Fin
            If _Fecha_Fin <> Nothing Then
                _Fecha_Fin = " and HD.Fecha_Registro <= '" & _Fecha_Fin & "'"
            Else
                _Fecha_Fin = ""
            End If
            ''''Estado
            If _Estado <> Nothing Then
                _Estado = " and Estado = '" & _Estado & "'"
            Else
                _Estado = " and Estado <> 'Solucionado' and estado <> 'Rechazado' and Estado <> 'Escalado Claro'"
            End If
            '''''Prioridad
            If _Prioridad <> Nothing Then
                _Prioridad = " and Prioridad = '" & _Prioridad & "'"
            Else
                _Prioridad = ""
            End If
            '''''persona reporta
            If _Persona_Reporta <> Nothing Then
                _Persona_Reporta = " and U.codnom='" & _Persona_Reporta & "'"
            Else
                _Persona_Reporta = ""
            End If
            '''''Codigo
            If _Cod_HelpDesk_Solucion <> Nothing Then
                cod = " And Cod_HelpDesk_Registro='" & _Cod_HelpDesk_Solucion & "'"
            Else
                cod = " "
            End If

            cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,Persona_Reporta,Modulo,U.codnom,Asignado,asigna,Fecha_Asigna,ObservacionAsigna,HC.Nombre as Area,reiteracion from HelpDesk_Registro HD Left join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento  left join datosclaro.dbo.usuarios U on HD.Id_Usuario=U.idusuario where Asignado=@_Id_Usuario" & _Fecha_Inicio & _Fecha_Fin & _Estado & _Prioridad & _Persona_Reporta & cod & "  order by HD.Fecha_Registro asc"
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 60).Value = _Id_Usuario
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


    Public Function ConsultaSeleccion_TicketGestion() As DataSet
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            dts = New DataSet
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 60).Value = _Id_Usuario
            If _Cod_HelpDesk_Registro <> Nothing Then
                cms.CommandText = "select Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,Prioridad,Tema,Observacion,Estado,HDCan.Nombre as Canal,HDPla.Nombre as Categoria,HDCat.Nombre as Tipo,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna,ObservacionAsigna,HC.Nombre as Area from HelpDesk_Registro HD inner join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal left join HelpDesk_Categoria HDPla on HD.Fk_Cod_Categoria = HDPla.Cod_HelpDesk_Categoria left join HelpDesk_Tipo HDCat on HD.Fk_Cod_Tipo = HDCat.Cod_HelpDesk_Tipo left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento where Asignado=@_Id_Usuario and Cod_HelpDesk_Registro=@_Cod_HelpDesk_Solucion order by HD.Fecha_Registro asc"
                cms.Parameters.Add("@_Cod_HelpDesk_Solucion", SqlDbType.Int).Value = _Cod_HelpDesk_Registro
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dts = New DataSet
                dta.Fill(dts)
                _Cantidad = dts.Tables(0).Rows.Count
                If _Cantidad > 0 Then
                    If dts.Tables(0).Rows(0).Item("Cod_HelpDesk_Registro") Is DBNull.Value Then
                        _Cod_HelpDesk_Registro = 0
                    Else
                        _Cod_HelpDesk_Registro = dts.Tables(0).Rows(0).Item("Cod_HelpDesk_Registro")
                    End If
                    If dts.Tables(0).Rows(0).Item("Fecha_Registro") Is DBNull.Value Then
                        _Fecha_Registro = ""
                    Else
                        _Fecha_Registro = dts.Tables(0).Rows(0).Item("Fecha_Registro")
                    End If
                    If dts.Tables(0).Rows(0).Item("Asigna") Is DBNull.Value Then
                        _Asigna = ""
                    Else
                        _Asigna = dts.Tables(0).Rows(0).Item("Asigna")
                    End If
                    If dts.Tables(0).Rows(0).Item("Fecha_Asigna") Is DBNull.Value Then
                        _Fecha_Asigna = ""
                    Else
                        _Fecha_Asigna = dts.Tables(0).Rows(0).Item("Fecha_Asigna")
                    End If
                    If dts.Tables(0).Rows(0).Item("ObservacionAsigna") Is DBNull.Value Then
                        _ObservacionAsigna = ""
                    Else
                        _ObservacionAsigna = dts.Tables(0).Rows(0).Item("ObservacionAsigna")
                    End If
                    If dts.Tables(0).Rows(0).Item("Prioridad") Is DBNull.Value Then
                        _Prioridad = ""
                    Else
                        _Prioridad = dts.Tables(0).Rows(0).Item("Prioridad")
                    End If
                    If dts.Tables(0).Rows(0).Item("Tema") Is DBNull.Value Then
                        _Tema = ""
                    Else
                        _Tema = dts.Tables(0).Rows(0).Item("Tema")
                    End If
                    If dts.Tables(0).Rows(0).Item("Observacion") Is DBNull.Value Then
                        _Observacion = ""
                    Else
                        _Observacion = dts.Tables(0).Rows(0).Item("Observacion")
                    End If
                    If dts.Tables(0).Rows(0).Item("Persona_Reporta") Is DBNull.Value Then
                        _Persona_Reporta = ""
                    Else
                        _Persona_Reporta = dts.Tables(0).Rows(0).Item("Persona_Reporta")
                    End If
                    If dts.Tables(0).Rows(0).Item("Modulo") Is DBNull.Value Then
                        _Modulo = ""
                    Else
                        _Modulo = dts.Tables(0).Rows(0).Item("Modulo")
                    End If
                    If dts.Tables(0).Rows(0).Item("Estado") Is DBNull.Value Then
                        _Estado = ""
                    Else
                        _Estado = dts.Tables(0).Rows(0).Item("Estado")
                    End If
                    If dts.Tables(0).Rows(0).Item("Area") Is DBNull.Value Then
                        _Nombre = ""
                    Else
                        _Nombre = dts.Tables(0).Rows(0).Item("Area")
                    End If
                End If
            Else
                dts = New DataSet
                Return dts
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
    Public Sub Ingresar_Solucion_Ticket()
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into HelpDesk_Solucion values (@_Fecha_Registro,@_Id_Usuario,@_Observacion,@_Estado,@_Fk_Cod_HelpDesk_Registro,@_Complejidad,@_Operatividad,@_Reiteracion,@_Fk_Cod_Categoria,@_Fk_Cod_Tipo)"
            cms.Parameters.Add("@_Fecha_Registro", SqlDbType.DateTime).Value = _Fecha_Registro
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 750).Value = _Observacion
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 20).Value = _Estado
            cms.Parameters.Add("@_Fk_Cod_HelpDesk_Registro", SqlDbType.Int).Value = _Fk_Cod_HelpDesk_Registro
            'NUEVOS PARAMETROS
            If _reiteracion <> Nothing And _reiteracion <> 0 Then
                cms.Parameters.Add("@_Reiteracion", SqlDbType.BigInt).Value = _reiteracion
            Else
                cms.Parameters.AddWithValue("@_Reiteracion", DBNull.Value)
            End If
            cms.Parameters.Add("@_Complejidad", SqlDbType.BigInt).Value = _Fk_Complejidad
            cms.Parameters.Add("@_Operatividad", SqlDbType.BigInt).Value = _Fk_Operatividad
            cms.Parameters.Add("@_Fk_Cod_Categoria", SqlDbType.BigInt).Value = _Fk_Cod_Categoria
            cms.Parameters.Add("@_Fk_Cod_Tipo", SqlDbType.BigInt).Value = _Fk_Cod_Tipo
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


    Public Sub Update_Solucion_Ticket()
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "update HelpDesk_Registro set Fk_Cod_Categoria=@_Fk_Cod_Categoria,Fk_Cod_Tipo=@_Fk_Cod_Tipo,Fk_Cod_Complemento_Area=@_Fk_Cod_Complemento_Area where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
            cms.Parameters.Add("@_Fk_Cod_Categoria", SqlDbType.BigInt).Value = _Fk_Cod_Categoria
            cms.Parameters.Add("@_Fk_Cod_Tipo", SqlDbType.BigInt).Value = _Fk_Cod_Tipo
            cms.Parameters.Add("@_Cod_HelpDesk_Registro", SqlDbType.BigInt).Value = _Cod_HelpDesk_Registro
            cms.Parameters.Add("@_Fk_Cod_Complemento_Area", SqlDbType.BigInt).Value = _Fk_Cod_Complemento_Area
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
    Public Sub Actualizar_Estado_Ticket()
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "update HelpDesk_Registro set Estado=@_Estado1 where Cod_HelpDesk_Registro =@_Cod_HelpDesk_Solucion"
            If validacion = 1 Then
                cms.CommandText = "update HelpDesk_Registro set Estado=@_Estado1, Asignado=@Asignado where Cod_HelpDesk_Registro =@_Cod_HelpDesk_Solucion"
                cms.Parameters.Add("@Asignado", SqlDbType.VarChar, 30).Value = _Asignado
            End If
            cms.Parameters.Add("@_Cod_HelpDesk_Solucion", SqlDbType.Int).Value = _Cod_HelpDesk_Solucion
            cms.Parameters.Add("@_Estado1", SqlDbType.VarChar, 20).Value = _Estado
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
    Public Function Consulta_Area() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from HelpDesk_Complemento where Pertenece='Area' or Pertenece='- Seleccione -' order by Nombre"
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
    Public Function Consulta_Complejidad() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from HelpDesk_Complemento where Pertenece = 'Complejidad' or Pertenece = '- Seleccione -' order by Nombre"
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
    Public Function Consulta_Operatividad() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from HelpDesk_Complemento where Pertenece = 'operatividad' or Pertenece = '- Seleccione -' order by Nombre"
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
    Public Sub Update_Solucion_compleyopera()
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            If _Fk_Cod_Tipo <> Nothing Then
                cms.CommandText = "update HelpDesk_Registro set Fk_complejidad=@_Fk_Complejidad, Fk_Operatividad=@_Fk_Operatividad, reiteracion=@_Fk_Cod_Tipo where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
                cms.Parameters.Add("@_Fk_Cod_Tipo", SqlDbType.BigInt).Value = _Fk_Cod_Tipo
            Else
                cms.CommandText = "update HelpDesk_Registro set Fk_complejidad=@_Fk_Complejidad, Fk_Operatividad=@_Fk_Operatividad where Cod_HelpDesk_Registro = @_Cod_HelpDesk_Registro"
            End If
            cms.Parameters.Add("@_Fk_Complejidad", SqlDbType.BigInt).Value = _Fk_Complejidad
            cms.Parameters.Add("@_Fk_Operatividad", SqlDbType.BigInt).Value = _Fk_Operatividad
            cms.Parameters.Add("@_Cod_HelpDesk_Registro", SqlDbType.BigInt).Value = _Cod_HelpDesk_Registro
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
    Public Function Consulta_Estado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from HelpDesk_Complemento where Pertenece = 'EstadoLista' or Pertenece = '- Seleccione -'  order by Nombre"
            If _Observacion = "estado" Then
                cms.CommandText = "select * from HelpDesk_Complemento where  Nombre <> 'Abierto' and Pertenece = 'EstadoLista' or Pertenece = '- Seleccione -' order by Nombre "
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



    Public Function Consultar_Tickets(ByVal Exception As String)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim Sql_Cod As String = Nothing
            Dim Sql_Asignado As String = Nothing
            Dim Sql_Usuario As String = Nothing
            Dim Sql_Estado As String = Nothing
            Dim Sql_Fecha_Ini As String = Nothing
            Dim Sql_Fecha_Fin As String = Nothing
            Dim Sql_Area As String = Nothing
            Dim Sql_Prioridad As String = Nothing
            Dim Sql_Exception As String = Nothing
            If _Id_Usuario <> Nothing Then
                Sql_Usuario = " and Id_Usuario Like @_Usuario "
                cms.Parameters.AddWithValue("@_Usuario", _Id_Usuario)
            End If
            If _Cod_Ticket <> Nothing Then
                Sql_Cod = " and Cod_HelpDesk_Registro = @Cod "
                cms.Parameters.AddWithValue("@Cod", _Cod_Ticket)
            Else
                If _Asignado <> Nothing Then
                    Sql_Asignado = " and Asignado Like @_Asignado "
                    cms.Parameters.AddWithValue("@_Asignado", _Asignado)
                End If
                If _Estado <> Nothing Then
                    Sql_Estado = " and Estado Like @Cod_Estado "
                    cms.Parameters.AddWithValue("@_Estado", _Estado)
                End If
                If _Prioridad <> Nothing Then
                    Sql_Prioridad = " and Prioridad Like @_Prioridad "
                    cms.Parameters.AddWithValue("@_Prioridad", _Prioridad)
                End If
                If _Fk_Cod_Complemento_Area <> Nothing And _Fk_Cod_Complemento_Area > 0 Then
                    Sql_Area = " and Fk_Cod_Complemento_Area  = @_Fk_Cod_Complemento_Area "
                    cms.Parameters.AddWithValue("@_Fk_Cod_Complemento_Area", _Fk_Cod_Complemento_Area)
                End If
                If _Fecha_Inicio <> Nothing Then
                    Sql_Fecha_Ini = " and Fecha_Registro >= @_Fecha_Inicio "
                    cms.Parameters.AddWithValue("@_Fecha_Inicio", _Fecha_Inicio)
                End If
                If _Fecha_Fin <> Nothing Then
                    Sql_Fecha_Fin = " and Fecha_Registro <= @_Fecha_Fin "
                    cms.Parameters.AddWithValue("@_Fecha_Fin", _Fecha_Fin & " 23:59:59")
                End If
            End If

            cn.Open()
            cms.Connection = cn
            cms.CommandText = "select Ca.Nombre As Calificacion, Observacion_Calificador, Cod_HelpDesk_Registro, Fecha_Registro, Id_Usuario, Prioridad, Tema, Observacion,Estado,HDCan.Nombre as Canal,Persona_Reporta,Modulo,Asignado,asigna,Fecha_Asigna,ObservacionAsigna,HC.Nombre as Area,Reiteracion from HelpDesk_Registro HD left join HelpDesk_Canal HDCan on HD.Fk_Cod_Canal = HDCan.Cod_HelpDesk_Canal left join HelpDesk_Complemento HC on HD.Fk_Cod_Complemento_Area = HC.Cod_HelpDesk_Complemento left join HelpDesk_Complemento Ca on HD.Calificacion_Cod_Help_Com = Ca.Cod_HelpDesk_Complemento where 1=1 " & Sql_Usuario & Sql_Fecha_Fin & Sql_Fecha_Ini & Sql_Area & Sql_Cod & Sql_Estado & Sql_Prioridad & " order by HD.Fecha_Registro asc"

            dta = New SqlClient.SqlDataAdapter(cms)
            dts = New DataSet
            dta.Fill(dts)
            cms.Parameters.Clear()
            cn.Close()
            Return dts
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Actualizar_Ticket()
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim Sql_Calificacion As String = Nothing

            If _Cod_Calificacion <> Nothing And _Cod_Calificacion > 0 Then
                Sql_Calificacion = ", Calificacion_Cod_Help_Com =@_Cod_Calificacion, Observacion_Calificador = @_Descripcion "
                cms.Parameters.AddWithValue("@_Descripcion", _Descripcion)
                cms.Parameters.AddWithValue("@_Cod_Calificacion", _Cod_Calificacion)
            End If
            cn.Open()
            cms.Connection = cn
            cms.CommandText = "Update HelpDesk_Registro Set Fecha_Registro = (Select Fecha_Registro From HelpDesk_Registro  where Cod_HelpDesk_Registro = @_Cod_Ticket) " & Sql_Calificacion & " where Cod_HelpDesk_Registro = @_Cod_Ticket"
            cms.Parameters.AddWithValue("@_Cod_Ticket", _Cod_HelpDesk_Registro)
            cms.ExecuteNonQuery()
            cms.Parameters.Clear()
            cn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function Consultar_Gestiones()
        Try
            Dim cms As New SqlClient.SqlCommand
            dts = New DataSet
            cn.Open()
            cms.CommandText = "Select Cod_HelpDesk_Solucion,Fk_Cod_HelpDesk_Registro,Fecha_Registro,Id_Usuario,Observacion,Estado from HelpDesk_Solucion where Fk_Cod_HelpDesk_Registro = @_Cod_Ticket Order By Fecha_Registro Desc"
            cms.Parameters.AddWithValue("@_Cod_Ticket", _Cod_Ticket)
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            cms.Parameters.Clear()
            cn.Close()
            Return dts
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Consultar_Complementos(ByVal exception As String, Cod_Corresponde As Integer, Corresponde As String)
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.Connection = cn
            Dim sql_fragment As String = Nothing

            If Cod_Corresponde <> Nothing Then
                cms.Parameters.AddWithValue("@_Cod_Corresponde", Cod_Corresponde)
                sql_fragment = "and Pertenece = @_Cod_Corresponde "
            End If
            If Corresponde <> Nothing Then
                cms.Parameters.AddWithValue("@_Corresponde", Corresponde)
                sql_fragment = "and Pertenece Like (select Cod_HelpDesk_Complemento from helpdesk_complemento where Nombre like @_Corresponde) "
            End If

            cms.CommandText = "Select Cod_HelpDesk_Complemento, Nombre from helpdesk_complemento Where 1=1 " & sql_fragment & " Or Cod_HelpDesk_Complemento = 0 order by Nombre asc"

            dta = New SqlClient.SqlDataAdapter(cms)
            dts = New DataSet
            dta.Fill(dts)
            cms.Parameters.Clear()
            cn.Close()
            Return dts
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
