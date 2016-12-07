Public Class Clsretroalimentacion


    Protected _Nombre_Usu As String
    Protected _Nombre_Retro As String
    Protected _Id_Usuario As String
    Protected _Observacion As String
    Protected _Fecha_Actual As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Todo As String
    Protected _Cantidad As Integer
    Protected _Compromiso_Usu As String
    Protected _Conclusion As String
    Protected _Area As String
    Protected _Cod_Usuario As String
    Protected _Causas As String
    Protected _Fecha_Retro As DateTime
    Protected _Descripcion_Causa As String
    Protected _Fk_Cod_Retroalimentacion As Integer
    Protected _Cod_Retroalimentacion As Integer
    Protected _Cod_Retro As String
    Protected _Id_Auditoria As String
    Protected _Seguimiento As String
    Protected _Tipo_Retro As String
    Protected _Grupo As String
    Protected _Campania As String
    Protected _Agente As String
    Protected _Auditor As String
    Protected _Fc_Llamada As Date
    Protected _Estado_Caso As String
    Protected _Parametro As String
    Protected _Parametro0 As String
    Protected _Parametro1 As String
    Protected _Parametro2 As String
    Protected _Parametro3 As String
    Protected _Observacion0 As String
    Protected _Observacion1 As String
    Protected _Observacion2 As String
    Protected _Observacion3 As String
    Protected _Fc_Audit As Date
    Protected _Id_Caso As Int64
    Protected _Fc_Reg As Date
    Protected _Fc_Reg_CR As Date
    Protected _Fc_Reg_Actualiza As Date
    Protected _Fc_Retro As Date
    Protected _Validacion As String
    Protected _ObservacionP As String
    Protected _Fc_Inicial As Date
    Protected _Fc_Final As Date
    Protected _Calificacion As String
    Protected _Tiempo_Retroalimentacion As String
    Protected _Validacion_Version As String
    '----Retroalimentacion-----'
    Protected _Item_1 As Integer
    Protected _Item_2 As Integer
    Protected _Item_3 As Integer
    Protected _Item_4 As Integer
    Protected _Item_5 As Integer
    Protected _Resultado As Decimal

    Public Property Item_1 As Integer
        Get
            Return _Item_1
        End Get
        Set(value As Integer)
            _Item_1 = value
        End Set
    End Property
    Public Property Item_2 As Integer
        Get
            Return _Item_2
        End Get
        Set(value As Integer)
            _Item_2 = value
        End Set
    End Property
    Public Property Item_3 As Integer
        Get
            Return _Item_3
        End Get
        Set(value As Integer)
            _Item_3 = value
        End Set
    End Property
    Public Property Item_4 As Integer
        Get
            Return _Item_4
        End Get
        Set(value As Integer)
            _Item_4 = value
        End Set
    End Property
    Public Property Item_5 As Integer
        Get
            Return _Item_5
        End Get
        Set(value As Integer)
            _Item_5 = value
        End Set
    End Property
    Public Property Resultado As Decimal
        Get
            Return _Resultado
        End Get
        Set(value As Decimal)
            _Resultado = value
        End Set
    End Property


    Public Property Validacion_Version() As String
        Get
            Return _Validacion_Version
        End Get
        Set(ByVal value As String)
            _Validacion_Version = value
        End Set
    End Property
    Public Property Tiempo_Retroalimentacion As String
        Get
            Return _Tiempo_Retroalimentacion
        End Get
        Set(ByVal value As String)
            _Tiempo_Retroalimentacion = value
        End Set
    End Property
    Public Property Calificacion As String
        Get
            Return _Calificacion

        End Get
        Set(ByVal value As String)
            _Calificacion = value
        End Set
    End Property


    Public Property ObservacionP As String
        Get
            Return _ObservacionP

        End Get
        Set(ByVal value As String)
            _ObservacionP = value
        End Set
    End Property


    Public Property Validacion() As String
        Get
            Return _Validacion
        End Get
        Set(ByVal value As String)
            _Validacion = value
        End Set
    End Property
    Public Property Id_Caso As Int64
        Get
            Return _Id_Caso
        End Get
        Set(ByVal value As Int64)
            _Id_Caso = value
        End Set
    End Property

    Public Property Fc_Inicial As Date
        Get
            Return _Fc_Inicial
        End Get
        Set(ByVal value As Date)
            _Fc_Inicial = value
        End Set
    End Property

    Public Property Fc_Final As Date
        Get
            Return _Fc_Final
        End Get
        Set(ByVal value As Date)
            _Fc_Final = value
        End Set
    End Property

    Public Property Fc_Retro As Date
        Get
            Return _Fc_Retro
        End Get
        Set(ByVal value As Date)
            _Fc_Retro = value
        End Set
    End Property

    Public Property Fc_Reg As Date
        Get
            Return _Fc_Reg
        End Get
        Set(ByVal value As Date)
            _Fc_Reg = value
        End Set
    End Property

    Public Property Fc_Reg_Actualiza As Date
        Get
            Return _Fc_Reg_Actualiza
        End Get
        Set(ByVal value As Date)
            _Fc_Reg_Actualiza = value
        End Set
    End Property

    Public Property Fc_Reg_CR As Date
        Get
            Return _Fc_Reg_CR
        End Get
        Set(ByVal value As Date)
            _Fc_Reg_CR = value
        End Set
    End Property

    Public Property Fc_Audit As Date
        Get
            Return _Fc_Audit
        End Get
        Set(ByVal value As Date)
            _Fc_Audit = value
        End Set
    End Property

    Public Property Grupo As String
        Get
            Return _Grupo
        End Get
        Set(ByVal value As String)
            _Grupo = value
        End Set
    End Property

    Public Property Seguimiento As String
        Get
            Return _Seguimiento
        End Get
        Set(ByVal value As String)
            _Seguimiento = value
        End Set
    End Property

    Public Property Tipo_Retro As String
        Get
            Return _Tipo_Retro
        End Get
        Set(ByVal value As String)
            _Tipo_Retro = value
        End Set
    End Property

    Public Property Campania As String
        Get
            Return _Campania
        End Get
        Set(ByVal value As String)
            _Campania = value
        End Set
    End Property

    Public Property Agente As String
        Get
            Return _Agente
        End Get
        Set(ByVal value As String)
            _Agente = value
        End Set
    End Property

    Public Property Auditor As String
        Get
            Return _Auditor
        End Get
        Set(ByVal value As String)
            _Auditor = value
        End Set
    End Property

    Public Property Fc_Llamada As String
        Get
            Return _Fc_Llamada
        End Get
        Set(ByVal value As String)
            _Fc_Llamada = value
        End Set
    End Property

    Public Property Estado_Caso As String
        Get
            Return _Estado_Caso
        End Get
        Set(ByVal value As String)
            _Estado_Caso = value
        End Set
    End Property


    Public Property Id_Auditoria As String
        Get
            Return _Id_Auditoria
        End Get
        Set(ByVal value As String)
            _Id_Auditoria = value
        End Set
    End Property

    Public Property Parametro As String
        Get
            Return _Parametro
        End Get
        Set(ByVal value As String)
            _Parametro = value
        End Set
    End Property

    Public Property Parametro0 As String
        Get
            Return _Parametro0
        End Get
        Set(ByVal value As String)
            _Parametro0 = value
        End Set
    End Property
    Public Property Parametro1 As String
        Get
            Return _Parametro1
        End Get
        Set(ByVal value As String)
            _Parametro1 = value
        End Set
    End Property
    Public Property Parametro2 As String
        Get
            Return _Parametro2
        End Get
        Set(ByVal value As String)
            _Parametro2 = value
        End Set
    End Property
    Public Property Parametro3 As String
        Get
            Return _Parametro3
        End Get
        Set(ByVal value As String)
            _Parametro3 = value
        End Set
    End Property

    Public Property Observacion0 As String
        Get
            Return _Observacion0
        End Get
        Set(ByVal value As String)
            _Observacion0 = value
        End Set
    End Property
    Public Property Observacion1 As String
        Get
            Return _Observacion1
        End Get
        Set(ByVal value As String)
            _Observacion1 = value
        End Set
    End Property
    Public Property Observacion2 As String
        Get
            Return _Observacion2
        End Get
        Set(ByVal value As String)
            _Observacion2 = value
        End Set
    End Property
    Public Property Observacion3 As String
        Get
            Return _Observacion3
        End Get
        Set(ByVal value As String)
            _Observacion3 = value
        End Set
    End Property
    ''''''''''''''Variable creada sin metodo de encapsulamiento
    Public Property Cantidad As Integer
        Get
            Return _Cantidad

        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property


    Public Property Fk_Cod_Retroalimentacion As Integer
        Get
            Return _Fk_Cod_Retroalimentacion

        End Get
        Set(value As Integer)
            _Fk_Cod_Retroalimentacion = value
        End Set
    End Property
    Public Property Cod_Retroalimentacion As Integer
        Get
            Return _Cod_Retroalimentacion

        End Get
        Set(value As Integer)
            _Cod_Retroalimentacion = value
        End Set
    End Property

    Public Property Cod_Usuario As String
        Get
            Return _Cod_Usuario

        End Get
        Set(value As String)
            _Cod_Usuario = value
        End Set
    End Property
    Public Property Cod_Retro As String
        Get
            Return _Cod_Retro

        End Get
        Set(value As String)
            _Cod_Retro = value
        End Set
    End Property
    Public Property Descripcion_Causa() As String
        Get
            Return _Descripcion_Causa
        End Get
        Set(value As String)
            _Descripcion_Causa = value
        End Set
    End Property

    Public Property Todo() As String
        Get
            Return _Todo

        End Get
        Set(value As String)
            _Todo = value
        End Set
    End Property
    Public Property Fecha_Actual() As DateTime
        Get
            Return _Fecha_Actual
        End Get
        Set(value As DateTime)
            _Fecha_Actual = value
        End Set
    End Property
    Public Property Observacion() As String
        Get
            Return _Observacion

        End Get
        Set(value As String)
            _Observacion = value
        End Set
    End Property
    Public Property Id_Usuario() As String
        Get
            Return _Id_Usuario
        End Get
        Set(ByVal value As String)
            _Id_Usuario = value
        End Set
    End Property
    Public Property Nombre_Usu() As String
        Get
            Return _Nombre_Usu
        End Get
        Set(value As String)
            _Nombre_Usu = value

        End Set
    End Property

    Public Property Nombre_Retro As String
        Get
            Return _Nombre_Retro
        End Get
        Set(value As String)
            _Nombre_Retro = value
        End Set
    End Property

    Public Property Compromiso_Usu As String
        Get
            Return _Compromiso_Usu

        End Get
        Set(value As String)
            _Compromiso_Usu = value
        End Set
    End Property

    Public Property Conclusion As String
        Get
            Return _Conclusion
        End Get
        Set(value As String)
            _Conclusion = value
        End Set
    End Property

    Public Property Area As String
        Get
            Return _Area
        End Get
        Set(value As String)
            _Area = value
        End Set
    End Property

    Public Property Causas As String
        Get
            Return _Causas
        End Get
        Set(value As String)
            _Causas = value
        End Set
    End Property

    Public Property Fecha_Retro() As DateTime
        Get
            Return _Fecha_Retro
        End Get
        Set(value As DateTime)
            _Fecha_Retro = value
        End Set
    End Property

    Public Sub PrintDocument1()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim MyPrintDocument As New Drawing.Printing.PrintDocument

        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub

    Public Sub Ingresar()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Retroalimentacion (Fc_Reg,Fc_Retro,Nombre_Usu,Id_Usuario,Area,Nombre_Retro,Observacion,Compromiso_Usu,Conclusion,Cod_Usuario,Cod_Retro)values(@_Fc_Reg,@_Fc_Retro,@_Nombre_Usu,@_Id_Usuario,@_Area,@_Nombre_Retro,@_Observacion,@_Compromiso_Usu,@_Conclusion,@_Cod_Usuario,@_Cod_Retro)"
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.DateTime).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fc_Retro", SqlDbType.DateTime).Value = _Fecha_Retro
            cms.Parameters.Add("@_Nombre_Usu", SqlDbType.VarChar, 120).Value = _Nombre_Usu
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_Area", SqlDbType.VarChar, 50).Value = _Area
            cms.Parameters.Add("@_Nombre_Retro", SqlDbType.VarChar, 50).Value = _Nombre_Retro
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 750).Value = _Observacion
            cms.Parameters.Add("@_Compromiso_Usu", SqlDbType.VarChar, 750).Value = _Compromiso_Usu
            cms.Parameters.Add("@_Conclusion", SqlDbType.VarChar, 750).Value = _Conclusion
            cms.Parameters.Add("@_Cod_Usuario", SqlDbType.VarChar, 50).Value = _Cod_Usuario
            cms.Parameters.Add("@_Cod_Retro", SqlDbType.VarChar, 50).Value = _Cod_Retro

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
    Public Sub Ingresar2()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Retroalimentacion_Causa (Causas,Descripcion,Fk_Cod_Retroalimentacion)values(@_Causas,@_Descripcion,@_Fk_Cod_Retroalimentacion)"
            cms.Parameters.Add("@_Causas", SqlDbType.VarChar, 50).Value = _Causas
            cms.Parameters.Add("@_Descripcion", SqlDbType.VarChar, 750).Value = _Descripcion_Causa
            cms.Parameters.Add("@_Fk_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Fk_Cod_Retroalimentacion
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
    Public Function Consulta_Retro_Usu() As DataSet
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
    Public Function Consulta_Area() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select * from Area where pertenece='Retroalimentacion' or pertenece is null"
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
    Public Function Consulta_Cod() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select MAX(Cod_Retroalimentacion)+1 as Cod_Retroalimentacion from Retroalimentacion"
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
    Public Function Consulta_Cod_3() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "select MAX(Cod_Retroalimentacion)+1 as Cod_Retroalimentacion from Retroalimentacion"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad = 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion") Is DBNull.Value Then
                    _Cod_Retroalimentacion = 1
                Else
                    _Cod_Retroalimentacion = dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion")
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
    Public Function Consulta_Cod2() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select MAX(Cod_Retroalimentacion_Causa)+1 as Cod_Retroalimentacion_Causa from Retroalimentacion_Causa"
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


    Public Function consultausu1() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Retroalimentacion R  join Retroalimentacion_Causa RC  on R.Cod_Retroalimentacion=RC.Fk_Cod_Retroalimentacion where R.Cod_Usuario=@_Cod_Usuario and R.Cod_Retro=@_Cod_Retro and R.Fc_Retro=@_Fc_Retro and R.Area=@_Area"
            cms.Parameters.Add("@_Cod_Usuario", SqlDbType.VarChar, 50).Value = _Cod_Usuario
            cms.Parameters.Add("@_Cod_Retro", SqlDbType.VarChar, 50).Value = _Cod_Retro
            cms.Parameters.Add("@_Fc_Retro", SqlDbType.DateTime).Value = _Fecha_Retro
            cms.Parameters.Add("@_Area", SqlDbType.VarChar, 50).Value = _Area
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad < 0 Then
            End If
          
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Usuario") Is System.DBNull.Value Then
                    _Cod_Usuario = ""
                Else
                    _Cod_Usuario = dts.Tables(0).Rows(0).Item("Cod_Usuario")
                End If
                If dts.Tables(0).Rows(0).Item("Fc_Retro") Is System.DBNull.Value Then
                    _Fecha_Retro = ""
                Else
                    _Fecha_Retro = dts.Tables(0).Rows(0).Item("Fc_Retro")
                End If
                If dts.Tables(0).Rows(0).Item("Cod_Retro") Is System.DBNull.Value Then
                    _Cod_Retro = ""
                Else
                    _Cod_Retro = dts.Tables(0).Rows(0).Item("Cod_Retro")
                End If
                If dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion") Is System.DBNull.Value Then
                    _Cod_Retroalimentacion = ""
                Else
                    _Cod_Retroalimentacion = dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre_Usu") Is System.DBNull.Value Then
                    _Nombre_Usu = ""
                Else
                    _Nombre_Usu = dts.Tables(0).Rows(0).Item("Nombre_Usu")
                End If
                If dts.Tables(0).Rows(0).Item("Area") Is System.DBNull.Value Then
                    _Area = ""
                Else
                    _Area = dts.Tables(0).Rows(0).Item("Area")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre_Retro") Is System.DBNull.Value Then
                    _Nombre_Retro = ""
                Else
                    _Nombre_Retro = dts.Tables(0).Rows(0).Item("Nombre_Retro")
                End If
                If dts.Tables(0).Rows(0).Item("Observacion") Is System.DBNull.Value Then
                    _Observacion = 0
                Else
                    _Observacion = dts.Tables(0).Rows(0).Item("Observacion")
                End If
                If dts.Tables(0).Rows(0).Item("Compromiso_Usu") Is System.DBNull.Value Then
                    _Compromiso_Usu = ""
                Else
                    _Compromiso_Usu = dts.Tables(0).Rows(0).Item("Compromiso_Usu")
                End If

                If dts.Tables(0).Rows(0).Item("Conclusion") Is System.DBNull.Value Then
                    _Conclusion = ""
                Else
                    _Conclusion = dts.Tables(0).Rows(0).Item("Conclusion")
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

    Public Function consultausu2() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts2 As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Retroalimentacion R full join Retroalimentacion_Causa RC  on R.Cod_Retroalimentacion=RC.Fk_Cod_Retroalimentacion where R.Cod_Retroalimentacion=@_Cod_Retroalimentacion "
            cms.Parameters.Add("@_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Cod_Retroalimentacion
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts2)
            _Cantidad = dts2.Tables(0).Rows.Count

            If _Cantidad > 0 And _Cod_Retroalimentacion <> Nothing Then
                If dts2.Tables(0).Rows(0).Item("Fc_Retro") Is System.DBNull.Value Then
                    _Fecha_Retro = ""
                Else
                    _Fecha_Retro = dts2.Tables(0).Rows(0).Item("Fc_Retro")
                End If
                If dts2.Tables(0).Rows(0).Item("Cod_Usuario") Is System.DBNull.Value Then
                    _Cod_Usuario = ""
                Else
                    _Cod_Usuario = dts2.Tables(0).Rows(0).Item("Cod_Usuario")
                End If
                If dts2.Tables(0).Rows(0).Item("Cod_Retro") Is System.DBNull.Value Then
                    _Cod_Retro = ""
                Else
                    _Cod_Retro = dts2.Tables(0).Rows(0).Item("Cod_Retro")
                End If
                If dts2.Tables(0).Rows(0).Item("Cod_Retroalimentacion") Is System.DBNull.Value Then
                    _Cod_Retroalimentacion = ""
                Else
                    _Cod_Retroalimentacion = dts2.Tables(0).Rows(0).Item("Cod_Retroalimentacion")
                End If
                If dts2.Tables(0).Rows(0).Item("Nombre_Usu") Is System.DBNull.Value Then
                    _Nombre_Usu = ""
                Else
                    _Nombre_Usu = dts2.Tables(0).Rows(0).Item("Nombre_Usu")
                End If
                If dts2.Tables(0).Rows(0).Item("Area") Is System.DBNull.Value Then
                    _Area = ""
                Else
                    _Area = dts2.Tables(0).Rows(0).Item("Area")
                End If
                If dts2.Tables(0).Rows(0).Item("Nombre_Retro") Is System.DBNull.Value Then
                    _Nombre_Retro = ""
                Else
                    _Nombre_Retro = dts2.Tables(0).Rows(0).Item("Nombre_Retro")
                End If
                If dts2.Tables(0).Rows(0).Item("Observacion") Is System.DBNull.Value Then
                    _Observacion = 0
                Else
                    _Observacion = dts2.Tables(0).Rows(0).Item("Observacion")
                End If
                If dts2.Tables(0).Rows(0).Item("Compromiso_Usu") Is System.DBNull.Value Then
                    _Compromiso_Usu = ""
                Else
                    _Compromiso_Usu = dts2.Tables(0).Rows(0).Item("Compromiso_Usu")
                End If

                If dts2.Tables(0).Rows(0).Item("Conclusion") Is System.DBNull.Value Then
                    _Conclusion = ""
                Else
                    _Conclusion = dts2.Tables(0).Rows(0).Item("Conclusion")
                End If
            Else
                If _Cantidad = 0 And Cod_Retroalimentacion <> Nothing Then
                    _Cod_Usuario = ""
                    _Cod_Retro = ""
                    _Cod_Retroalimentacion = Nothing
                    _Nombre_Usu = ""
                    _Area = ""
                    _Nombre_Retro = ""
                    _Observacion = ""
                    _Compromiso_Usu = ""
                    _Conclusion = ""

                End If
             End If
            Return dts2
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Function
    Public Function consultausu() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts2 As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Retroalimentacion R full join Retroalimentacion_Causa RC  on R.Cod_Retroalimentacion=RC.Fk_Cod_Retroalimentacion where R.Cod_Retroalimentacion=@_Cod_Retroalimentacion "
            cms.Parameters.Add("@_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Cod_Retroalimentacion
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts2)
            _Cantidad = dts2.Tables(0).Rows.Count
            If _Cantidad < 0 Then

            End If
            If _Cantidad > 0 Then
                If dts2.Tables(0).Rows(0).Item("Cod_Usuario") Is System.DBNull.Value Then
                    _Cod_Usuario = ""
                Else
                    _Cod_Usuario = dts2.Tables(0).Rows(0).Item("Cod_Usuario")
                End If
                If dts2.Tables(0).Rows(0).Item("Cod_Retroalimentacion") Is System.DBNull.Value Then
                    _Cod_Retroalimentacion = ""
                Else
                    _Cod_Retroalimentacion = dts2.Tables(0).Rows(0).Item("Cod_Retroalimentacion")
                End If
                If dts2.Tables(0).Rows(0).Item("Nombre_Usu") Is System.DBNull.Value Then
                    _Nombre_Usu = ""
                Else
                    _Nombre_Usu = dts2.Tables(0).Rows(0).Item("Nombre_Usu")
                End If
                If dts2.Tables(0).Rows(0).Item("Area") Is System.DBNull.Value Then
                    _Area = ""
                Else
                    _Area = dts2.Tables(0).Rows(0).Item("Area")
                End If
                If dts2.Tables(0).Rows(0).Item("Nombre_Retro") Is System.DBNull.Value Then
                    _Nombre_Retro = ""
                Else
                    _Nombre_Retro = dts2.Tables(0).Rows(0).Item("Nombre_Retro")
                End If
                If dts2.Tables(0).Rows(0).Item("Observacion") Is System.DBNull.Value Then
                    _Observacion = 0
                Else
                    _Observacion = dts2.Tables(0).Rows(0).Item("Observacion")
                End If
                If dts2.Tables(0).Rows(0).Item("Compromiso_Usu") Is System.DBNull.Value Then
                    _Compromiso_Usu = ""
                Else
                    _Compromiso_Usu = dts2.Tables(0).Rows(0).Item("Compromiso_Usu")
                End If

                If dts2.Tables(0).Rows(0).Item("Conclusion") Is System.DBNull.Value Then
                    _Conclusion = ""
                Else
                    _Conclusion = dts2.Tables(0).Rows(0).Item("Conclusion")
                End If

            End If
            Return dts2
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Function

    Protected Sub Limpiar_cajas()

        Throw New NotImplementedException
    End Sub
    Public Function ObtenerParametros() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand

        Try
            cn.Open()
            cms.CommandText = "Select Cod_Calidad_Registro_Complemento, Nombre from Calidad_Registro_Complemento Where Pertenece=@version_lista or Pertenece='- Seleccione -' Order by Nombre"
            If Validacion = "Versiones_Retro" Then
                cms.CommandText = "Select Nombre from Calidad_Registro_Complemento Where Pertenece='Version_Retro' Order by Nombre Desc"
            End If
            If Validacion_Version = "V2" Then
                cms.Parameters.Add("@version_lista", SqlDbType.VarChar).Value = "RETROCALPAR"
            End If
            If Validacion_Version = "V3" Then
                cms.Parameters.Add("@version_lista", SqlDbType.VarChar).Value = "RETROCALIDAD_V3"
            End If
            If Validacion_Version = "V4" Then
                cms.Parameters.Add("@version_lista", SqlDbType.VarChar).Value = "RETROCALIDAD_V4"
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
    Public Function Inserta_Retro_Calidad() As DataSet
        Dim dta As New SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Fc_Retro = Now
            Fc_Reg = Now
            cn.Open()
            cms.CommandText = "INSERT INTO Retroalimentacion_Calidad (Id_Auditoria,Id_Usuario,Fc_Reg,Fc_Retro,Seguimiento,Tipo_Retro,Observacion,Compromiso_Usu,Conclusion,Id_Usuario_Actualiza,Fc_Reg_Actualiza,Tiempo_Retroalimentacion,Version_Retro,Item_1,Item_2,Item_3,Item_4,Item_5,Resultado) VALUES (@_Id_Auditoria,@_Id_Usuario,@_Fc_Audit,@_Fc_Retro,@_Seguimiento,@_Tipo_Retro,@_Observacion,@_Compromiso_Usu,@_Conclusion,@_Id_Usuario,@_Fc_Retro,@_Tiempo_Retroalimentacion,@_Validacion_Version,@_Item_1,@_Item_2,@_Item_3,@_Item_4,@_Item_5,@_Resultado) SELECT @@IDENTITY AS Cod_Retroalimentacion"
            cms.Parameters.AddWithValue("@_Id_Auditoria", _Id_Auditoria)
            cms.Parameters.AddWithValue("@_Id_Usuario", _Id_Usuario)
            cms.Parameters.AddWithValue("@_Fc_Audit", _Fc_Audit)
            cms.Parameters.AddWithValue("@_Fc_Retro", Fc_Retro)
            cms.Parameters.AddWithValue("@_Seguimiento", Seguimiento)
            cms.Parameters.AddWithValue("@_Tipo_Retro", Tipo_Retro)
            cms.Parameters.AddWithValue("@_Observacion", ObservacionP)
            cms.Parameters.AddWithValue("@_Compromiso_Usu", Compromiso_Usu)
            cms.Parameters.AddWithValue("@_Conclusion", Conclusion)
            cms.Parameters.AddWithValue("@_Tiempo_Retroalimentacion", Tiempo_Retroalimentacion)
            cms.Parameters.AddWithValue("@_Validacion_Version", Validacion_Version)
            cms.Parameters.AddWithValue("@_Item_1", _Item_1)
            cms.Parameters.AddWithValue("@_Item_2", _Item_2)
            cms.Parameters.AddWithValue("@_Item_3", _Item_3)
            cms.Parameters.AddWithValue("@_Item_4", _Item_4)
            cms.Parameters.AddWithValue("@_Item_5", _Item_5)
            cms.Parameters.AddWithValue("@_Resultado", _Resultado)
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion") Is DBNull.Value Then
                    _Cod_Retroalimentacion = ""
                Else
                    _Cod_Retroalimentacion = dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion")
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

    Public Function Buscar_ID() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario where CR.Cod_Calidad_Registro = @_Id_Auditoria"
            cms.Parameters.Add("@_Id_Auditoria", SqlDbType.BigInt).Value = Id_Auditoria
            If _Validacion_Version = "V3" Then
                cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor from Calidad_Registro_V3 CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario where CR.Cod_Calidad_Registro_V3 = @_Id_Auditoria"
            End If
            If _Validacion_Version = "V4" Then
                cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor from Calidad_Registro_V4 CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario where CR.Cod_Calidad_Registro_V4 = @_Id_Auditoria"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)

            If dts.Tables(0).Rows.Count > 0 Then
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Fc_Reg") Is DBNull.Value Then
                    _Fc_Audit = ""
                Else
                    _Fc_Audit = dts.Tables(0).Rows(0).Item("Fc_Reg")
                End If
                '---------------------------------------------------------------'

                If dts.Tables(0).Rows(0).Item("Campania") Is DBNull.Value Then
                    _Campania = ""
                Else
                    _Campania = dts.Tables(0).Rows(0).Item("Campania")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("NAgente") Is DBNull.Value Then
                    _Agente = ""
                Else
                    _Agente = dts.Tables(0).Rows(0).Item("NAgente")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Proceso") Is DBNull.Value Then
                    _Area = ""
                Else
                    _Area = dts.Tables(0).Rows(0).Item("Proceso")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("NAuditor") Is DBNull.Value Then
                    _Auditor = ""
                Else
                    _Auditor = dts.Tables(0).Rows(0).Item("NAuditor")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Fc_Llamada") Is DBNull.Value Then
                    _Fc_Llamada = ""
                Else
                    _Fc_Llamada = dts.Tables(0).Rows(0).Item("Fc_Llamada")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Id_Caso") Is DBNull.Value Then
                    _Id_Caso = ""
                Else
                    _Id_Caso = dts.Tables(0).Rows(0).Item("Id_Caso")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Estado_Caso") Is DBNull.Value Then
                    _Estado_Caso = ""
                Else
                    _Estado_Caso = dts.Tables(0).Rows(0).Item("Estado_Caso")
                End If
                '---------------------------------------------------------------'
            End If

            'Calculo calificacion
            dts = New DataSet

            cms.Parameters.Add("@_Cod_Calidad", SqlDbType.Int).Value = Id_Auditoria
            If _Validacion_Version = "V3" Then
                cms.CommandText = "Select Total_Atencion+Total_Gestion+Total_Solucion+Total_Cierre as Resultado_Kamilion from Calidad_Registro_V3 Calidad_Registro where Cod_Calidad_Registro_v3 = @_Cod_Calidad"
            ElseIf _Validacion_Version = "V4" Then
                cms.CommandText = "Select Total_General as Resultado_Kamilion from Calidad_Registro_V4 Calidad_Registro where Cod_Calidad_Registro_v4 =  @_Cod_Calidad"
            Else
                cms.CommandText = "Select Cod_Calidad, Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,CASE WHEN(Error_Critico < 100) THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select ((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo)*100)/25)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam, CR.Cod_Calidad_Registro as Cod_Calidad from Calidad_Registro CR)  as innerquery where Cod_Calidad<=108173 and Cod_Calidad = @_Cod_Calidad union Select Cod_Calidad, Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,CASE WHEN(Error_Critico < 100) THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select ((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo+Cordialidad+Contacto_Activo)*100)/35)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam, CR.Cod_Calidad_Registro as Cod_Calidad from Calidad_Registro CR)  as innerquery where Cod_Calidad>=108183 and Cod_Calidad = @_Cod_Calidad"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)

            If dts.Tables(0).Rows.Count > 0 Then
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Resultado_Kamilion") Is DBNull.Value Then
                    _Calificacion = ""
                Else
                    _Calificacion = dts.Tables(0).Rows(0).Item("Resultado_Kamilion")
                End If
                '---------------------------------------------------------------'
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

    Public Function ObtenerCodigo() As DataSet
        Dim dts As New DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Dim dta As New SqlClient.SqlDataAdapter
        Try
            cn.Open()
            cms.CommandText = "Select MAX((Cod_Retroalimentacion)+1) as COD from Retroalimentacion_Calidad"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)

            If dts.Tables(0).Rows(0).Item("COD") Is DBNull.Value Then
                _Cod_Retroalimentacion = 1
            Else
                _Cod_Retroalimentacion = dts.Tables(0).Rows(0).Item("COD")
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
    Public Sub Ingresar_Causas()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Retroalimentacion_Causa_Calidad (Parametro,Observacion,Fk_Cod_Retroalimentacion)values(@_Parametro,@_Observacion,@_Fk_Cod_Retroalimentacion)"
            cms.Parameters.Add("@_Fk_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Fk_Cod_Retroalimentacion
            cms.Parameters.Add("@_Parametro", SqlDbType.VarChar, 100).Value = _Parametro
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 500).Value = _Observacion
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
    Public Function Llenar_Campos() As DataSet
        Dim dts As New DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Dim dta As New SqlClient.SqlDataAdapter
        Try
            cn.Open()
            If Validacion = "1" Then
                cms.CommandText = "select * from Retroalimentacion_Calidad Where Cod_Retroalimentacion = @_Cod_Retroalimentacion and Version_Retro = @_Version"
                cms.Parameters.Add("@_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Cod_Retroalimentacion
                cms.Parameters.Add("@_Version", SqlDbType.VarChar).Value = _Validacion_Version
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                If dts.Tables(0).Rows.Count > 0 Then
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Id_Auditoria") Is DBNull.Value Then
                        _Id_Auditoria = ""
                    Else
                        _Id_Auditoria = dts.Tables(0).Rows(0).Item("Id_Auditoria")
                    End If
                    '---------------------------------------------------------------'

                    If dts.Tables(0).Rows(0).Item("Fc_Reg") Is DBNull.Value Then
                        _Fc_Reg = ""
                    Else
                        _Fc_Reg = dts.Tables(0).Rows(0).Item("Fc_Reg")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Fc_Retro") Is DBNull.Value Then
                        _Fc_Retro = ""
                    Else
                        _Fc_Retro = dts.Tables(0).Rows(0).Item("Fc_Retro")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Seguimiento") Is DBNull.Value Then
                        _Seguimiento = ""
                    Else
                        _Seguimiento = dts.Tables(0).Rows(0).Item("Seguimiento")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Tipo_Retro") Is DBNull.Value Then
                        _Tipo_Retro = ""
                    Else
                        _Tipo_Retro = dts.Tables(0).Rows(0).Item("Tipo_Retro")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Observacion") Is DBNull.Value Then
                        _ObservacionP = ""
                    Else
                        _ObservacionP = dts.Tables(0).Rows(0).Item("Observacion")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Compromiso_Usu") Is DBNull.Value Then
                        _Compromiso_Usu = ""
                    Else
                        _Compromiso_Usu = dts.Tables(0).Rows(0).Item("Compromiso_Usu")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Conclusion") Is DBNull.Value Then
                        _Conclusion = ""
                    Else
                        _Conclusion = dts.Tables(0).Rows(0).Item("Conclusion")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Fc_Reg_Actualiza") Is DBNull.Value Then
                        _Fc_Reg_Actualiza = Nothing
                    Else
                        _Fc_Reg_Actualiza = dts.Tables(0).Rows(0).Item("Fc_Reg_Actualiza")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Tiempo_Retroalimentacion") Is DBNull.Value Then
                        _Tiempo_Retroalimentacion = ""
                    Else
                        _Tiempo_Retroalimentacion = dts.Tables(0).Rows(0).Item("Tiempo_Retroalimentacion")
                    End If
                    If dts.Tables(0).Rows(0).Item("Version_Retro") Is DBNull.Value Then
                        _Todo = ""
                    Else
                        _Todo = dts.Tables(0).Rows(0).Item("Version_Retro")
                    End If

                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Resultado") Is DBNull.Value Then
                        _Item_1 = 0
                        _Item_2 = 0
                        _Item_3 = 0
                        _Item_4 = 0
                        _Item_5 = 0
                        _Resultado = 0
                    Else
                        _Item_1 = dts.Tables(0).Rows(0).Item("Item_1")
                        _Item_2 = dts.Tables(0).Rows(0).Item("Item_2")
                        _Item_3 = dts.Tables(0).Rows(0).Item("Item_3")
                        _Item_4 = dts.Tables(0).Rows(0).Item("Item_4")
                        _Item_5 = dts.Tables(0).Rows(0).Item("Item_5")
                        _Resultado = dts.Tables(0).Rows(0).Item("Resultado")
                    End If
                    '---------------------------------------------------------------'


                End If
            End If
            If Validacion = "2" Then
                cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario where CR.Cod_Calidad_Registro = @_Id_Auditoria"
                cms.Parameters.Add("@_Id_Auditoria", SqlDbType.BigInt).Value = Id_Auditoria
                If _Todo = "V3" Then
                    cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor from Calidad_Registro_V3 CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario where CR.Cod_Calidad_Registro_V3 = @_Id_Auditoria"
                End If
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                If dts.Tables(0).Rows.Count > 0 Then

                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Fc_Reg") Is DBNull.Value Then
                        _Fc_Reg_CR = ""
                    Else
                        _Fc_Reg_CR = dts.Tables(0).Rows(0).Item("Fc_Reg")
                    End If

                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Campania") Is DBNull.Value Then
                        _Campania = ""
                    Else
                        _Campania = dts.Tables(0).Rows(0).Item("Campania")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("NAgente") Is DBNull.Value Then
                        _Agente = ""
                    Else
                        _Agente = dts.Tables(0).Rows(0).Item("NAgente")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Proceso") Is DBNull.Value Then
                        _Area = ""
                    Else
                        _Area = dts.Tables(0).Rows(0).Item("Proceso")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("NAuditor") Is DBNull.Value Then
                        _Auditor = ""
                    Else
                        _Auditor = dts.Tables(0).Rows(0).Item("NAuditor")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Grupo") Is DBNull.Value Then
                        _Grupo = ""
                    Else
                        _Grupo = dts.Tables(0).Rows(0).Item("Grupo")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Fc_Llamada") Is DBNull.Value Then
                        _Fc_Llamada = ""
                    Else
                        _Fc_Llamada = dts.Tables(0).Rows(0).Item("Fc_Llamada")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Id_Caso") Is DBNull.Value Then
                        _Id_Caso = ""
                    Else
                        _Id_Caso = dts.Tables(0).Rows(0).Item("Id_Caso")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Estado_Caso") Is DBNull.Value Then
                        _Estado_Caso = ""
                    Else
                        _Estado_Caso = dts.Tables(0).Rows(0).Item("Estado_Caso")
                    End If


                    'Calculo de la calificacion
                    dts = New DataSet
                    cms.CommandText = "Select Cod_Calidad, Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,CASE WHEN(Error_Critico < 100) THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select ((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo)*100)/25)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam, CR.Cod_Calidad_Registro as Cod_Calidad from Calidad_Registro CR)  as innerquery where Cod_Calidad = @_Cod_Calidad"
                    cms.Parameters.Add("@_Cod_Calidad", SqlDbType.Int).Value = Id_Auditoria
                    If _Todo = "V3" Then
                        cms.CommandText = "Select Total_Atencion+Total_Gestion+Total_Solucion+Total_Cierre as Resultado_Kamilion from Calidad_Registro_V3 Calidad_Registro where Cod_Calidad_Registro_v3 = @_Cod_Calidad"
                    End If
                    cms.Connection = cn
                    dta = New SqlClient.SqlDataAdapter(cms)
                    dta.Fill(dts)

                    If dts.Tables(0).Rows.Count > 0 Then

                        '---------------------------------------------------------------'
                        If dts.Tables(0).Rows(0).Item("Resultado_Kamilion") Is DBNull.Value Then
                            _Calificacion = ""
                        Else
                            _Calificacion = dts.Tables(0).Rows(0).Item("Resultado_Kamilion")
                        End If
                        '---------------------------------------------------------------'

                    End If

                End If
            End If
            If Validacion = "3" Then
                cms.CommandText = "Select * from Retroalimentacion_Causa_Calidad where Fk_Cod_Retroalimentacion = @_Cod_Retroalimentacion"
                cms.Parameters.Add("@_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Cod_Retroalimentacion
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                If dts.Tables(0).Rows.Count > 0 Then

                    'PARAMETROS
                    If dts.Tables(0).Rows.Count >= 1 Then
                        _Parametro = dts.Tables(0).Rows(0).Item("Parametro")
                    Else
                        _Parametro = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 2 Then
                        _Parametro0 = dts.Tables(0).Rows(1).Item("Parametro")
                    Else
                        _Parametro0 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 3 Then
                        _Parametro1 = dts.Tables(0).Rows(2).Item("Parametro")
                    Else
                        _Parametro1 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 4 Then
                        _Parametro2 = dts.Tables(0).Rows(3).Item("Parametro")
                    Else
                        _Parametro2 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 5 Then
                        _Parametro3 = dts.Tables(0).Rows(4).Item("Parametro")
                    Else
                        _Parametro3 = ""
                    End If

                    'OBSERVACION

                    If dts.Tables(0).Rows.Count >= 1 Then
                        _Observacion = dts.Tables(0).Rows(0).Item("Observacion")
                    Else
                        _Observacion = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 2 Then
                        _Observacion0 = dts.Tables(0).Rows(1).Item("Observacion")
                    Else
                        _Observacion0 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 3 Then
                        _Observacion1 = dts.Tables(0).Rows(2).Item("Observacion")
                    Else
                        _Observacion1 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 4 Then
                        _Observacion2 = dts.Tables(0).Rows(3).Item("Observacion")
                    Else
                        _Observacion2 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 5 Then
                        _Observacion3 = dts.Tables(0).Rows(4).Item("Observacion")
                    Else
                        _Observacion3 = ""
                    End If
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
    Public Sub Actualiza_Retro_Calidad()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Update Retroalimentacion_Calidad SET Fc_Retro=@_Fc_Retro, Compromiso_Usu=@_Compromiso_Usu, Conclusion=@_Conclusion, Id_Usuario_Actualiza=@_Id_Usuario_Actualiza, Fc_Reg_Actualiza=@_Fc_Reg_Actualiza,Tiempo_Retroalimentacion=@_Tiempo_Retroalimentacion,Item_1 = @_Item_1, Item_2 = @_Item_2, Item_3 = @_Item_3, Item_4 = @_Item_4, Item_5 = @_Item_5, Resultado = @_Resultado Where Cod_Retroalimentacion=@_Cod_Retroalimentacion "

            cms.Parameters.Add("@_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Cod_Retroalimentacion
            cms.Parameters.Add("@_Fc_Retro", SqlDbType.DateTime).Value = _Fecha_Retro
            cms.Parameters.Add("@_Compromiso_Usu", SqlDbType.VarChar, 500).Value = _Compromiso_Usu
            cms.Parameters.Add("@_Conclusion", SqlDbType.VarChar, 500).Value = _Conclusion
            cms.Parameters.Add("@_Id_Usuario_Actualiza", SqlDbType.VarChar, 20).Value = _Id_Usuario
            cms.Parameters.Add("@_Fc_Reg_Actualiza", SqlDbType.DateTime).Value = Now
            cms.Parameters.Add("@_Tiempo_Retroalimentacion", SqlDbType.VarChar, 20).Value = _Tiempo_Retroalimentacion
            cms.Parameters.Add("@_Item_1", SqlDbType.Int).Value = _Item_1
            cms.Parameters.Add("@_Item_2", SqlDbType.Int).Value = _Item_2
            cms.Parameters.Add("@_Item_3", SqlDbType.Int).Value = _Item_3
            cms.Parameters.Add("@_Item_4", SqlDbType.Int).Value = _Item_4
            cms.Parameters.Add("@_Item_5", SqlDbType.Int).Value = _Item_5
            cms.Parameters.Add("@_Resultado", SqlDbType.Decimal, 50).Value = _Resultado
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

    Public Function BuscarGrupos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select cargo from usuarios where cargo like 'BO%' or cargo like 'N%' or cargo like 'Voz%' or cargo like 'Q%'  or cargo = '- Seleccione -'  group by cargo order by cargo"
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
    Public Function Busqueda_Avanzada() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim script As String
        Try
            cn.Open()
            If _Id_Usuario <> Nothing Then
                cms.Parameters.AddWithValue("@_Id_Usuario", _Id_Usuario)
                script = script & "  AND UI.idusuario=@_Id_Usuario"
            End If
            If _Fc_Final <> Nothing And _Fc_Inicial <> Nothing Then
                script = script & " AND CONVERT(DATE,RC.Fc_Retro)>= @_Fc_Inicial AND CONVERT(DATE,RC.Fc_Retro)<=@_Fc_Final"
                cms.Parameters.AddWithValue("@_Fc_Inicial", _Fc_Inicial)
                cms.Parameters.AddWithValue("@_Fc_Final", _Fc_Final)
            End If
            If _Tipo_Retro <> Nothing Then
                script = script & " AND RC.Tipo_Retro=@_Tipo_Retro"
                cms.Parameters.AddWithValue("@_Tipo_Retro", _Tipo_Retro)
            End If
            If _Cod_Usuario <> Nothing Then
                script = script & " AND UI.codnom=@_Cod_Usuario"
                cms.Parameters.AddWithValue("@_Cod_Usuario", _Cod_Usuario)
            End If

            cms.CommandText = " SELECT Cod_Retroalimentacion AS Id_Retro,Id_Auditoria,UA.nombreu AS Auditor,UI.nombreu AS Ingeniero,UI.codnom AS Cod_Ingeniero,Fc_Retro,RC.Fc_Reg AS Fc_Auditoria,Tipo_Retro,Tiempo_Retroalimentacion,Version_Retro,CASE WHEN Resultado >=7 then 'Retro Aceptada' WHEN Resultado > 4.5 and Resultado < 7 then 'Se requiere Refuerzo' WHEN Resultado > 0 and Resultado < 4.5 THEN 'Rechazada' ELSE null END AS Resultado FROM Retroalimentacion_Calidad RC LEFT JOIN Calidad_Registro CR2 ON RC.Id_Auditoria=CR2.Cod_Calidad_Registro AND RC.Version_Retro = 'V2' LEFT JOIN Calidad_Registro_V3 CR3 ON RC.Id_Auditoria=CR3.Cod_Calidad_Registro_V3 AND RC.Version_Retro = 'V3' LEFT JOIN Calidad_Registro_V4 CR4 ON RC.Id_Auditoria=CR4.Cod_Calidad_Registro_V4 AND RC.Version_Retro = 'V4' LEFT JOIN usuarios UI ON UI.idusuario=CR2.Agente OR UI.idusuario=CR3.Agente OR UI.idusuario=CR4.Agente LEFT JOIN usuarios UA ON UA.idusuario=RC.Id_Usuario WHERE RC.Cod_Retroalimentacion IS NOT NULL" & script & " ORDER BY Id_Retro DESC"
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

    Public Function ValidacionId() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from Retroalimentacion_Calidad Where Id_Auditoria = @_Id_Auditoria and Version_Retro = @Version"
            cms.Parameters.Add("@Version", SqlDbType.VarChar).Value = _Validacion_Version
            cms.Parameters.Add("@_Id_Auditoria", SqlDbType.BigInt).Value = _Id_Auditoria
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion") Is System.DBNull.Value Then
                    _Cod_Retroalimentacion = ""
                Else
                    _Cod_Retroalimentacion = dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion")
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
    Public Function consultaidusuario() As DataSet
        Dim dts As New DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Dim dta As New SqlClient.SqlDataAdapter
        Try
            cn.Open()
            cms.CommandText = "select * from Retroalimentacion_Calidad where Id_Usuario=@_Id_Usuario and Fc_Reg=@_Fc_Reg and Fc_retro=@_Fc_Retro and Seguimiento=@_Seguimiento and Tipo_Retro=@_Tipo_Retro and Observacion=@_Observacion and Compromiso_Usu=@_Compromiso_Usu and Conclusion=@_Conclusion"
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 20).Value = _Id_Usuario
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.DateTime).Value = _Fecha_Actual
            cms.Parameters.Add("@_Fc_Retro", SqlDbType.DateTime).Value = _Fecha_Actual
            cms.Parameters.Add("@_Seguimiento", SqlDbType.Int).Value = _Seguimiento
            cms.Parameters.Add("@_Tipo_Retro", SqlDbType.VarChar, 20).Value = _Tipo_Retro
            cms.Parameters.Add("@_Observacion", SqlDbType.VarChar, 500).Value = _ObservacionP
            cms.Parameters.Add("@_Compromiso_Usu", SqlDbType.VarChar, 500).Value = _Compromiso_Usu
            cms.Parameters.Add("@_Conclusion", SqlDbType.VarChar, 500).Value = _Conclusion

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion") Is DBNull.Value Then
                    _Cod_Retroalimentacion = ""
                Else
                    _Cod_Retroalimentacion = dts.Tables(0).Rows(0).Item("Cod_Retroalimentacion")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Id_Auditoria") Is DBNull.Value Then
                    _Id_Auditoria = ""
                Else
                    _Id_Auditoria = dts.Tables(0).Rows(0).Item("Id_Auditoria")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Fc_Reg") Is DBNull.Value Then
                    _Fc_Reg = ""
                Else
                    _Fc_Reg = dts.Tables(0).Rows(0).Item("Fc_Reg")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Fc_Retro") Is DBNull.Value Then
                    _Fc_Retro = ""
                Else
                    _Fc_Retro = dts.Tables(0).Rows(0).Item("Fc_Retro")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Seguimiento") Is DBNull.Value Then
                    _Seguimiento = ""
                Else
                    _Seguimiento = dts.Tables(0).Rows(0).Item("Seguimiento")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Tipo_Retro") Is DBNull.Value Then
                    _Tipo_Retro = ""
                Else
                    _Tipo_Retro = dts.Tables(0).Rows(0).Item("Tipo_Retro")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Observacion") Is DBNull.Value Then
                    _ObservacionP = ""
                Else
                    _ObservacionP = dts.Tables(0).Rows(0).Item("Observacion")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Compromiso_Usu") Is DBNull.Value Then
                    _Compromiso_Usu = ""
                Else
                    _Compromiso_Usu = dts.Tables(0).Rows(0).Item("Compromiso_Usu")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Conclusion") Is DBNull.Value Then
                    _Conclusion = ""
                Else
                    _Conclusion = dts.Tables(0).Rows(0).Item("Conclusion")
                End If
                '---------------------------------------------------------------'
                If dts.Tables(0).Rows(0).Item("Fc_Reg_Actualiza") Is DBNull.Value Then
                    _Fc_Reg_Actualiza = Nothing
                Else
                    _Fc_Reg_Actualiza = dts.Tables(0).Rows(0).Item("Fc_Reg_Actualiza")
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

    Public Function Consulta_Retro_Complemento() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = "Tipo_retro" Then
                cms.CommandText = "Select distinct Tipo_Retro from Retroalimentacion_Calidad"
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

    Public Function Llenar_CamposV2() As DataSet
        Dim dts As New DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Dim dta As New SqlClient.SqlDataAdapter
        Dim tabla, codigo, resultado As String

        Try
            cn.Open()
            If Validacion = "1" Then
                If _Validacion_Version = "V2" Then
                    tabla = "Calidad_Registro"
                    codigo = "CR.Cod_Calidad_Registro"
                    resultado = ",CASE WHEN (((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 )<100 THEN 0 ELSE Convert(int,(((((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo)*100)/25)*0.6)+ ((((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 )+(((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 )  )/2) end as Resultado_Kamilion"
                ElseIf _Validacion_Version = "V3" Then
                    tabla = "Calidad_Registro_V3"
                    codigo = "CR.Cod_Calidad_Registro_V3"
                    resultado = ",Total_Atencion+Total_Gestion+Total_Solucion+Total_Cierre as Resultado_Kamilion"
                ElseIf _Validacion_Version = "V4" Then
                    tabla = "Calidad_Registro_V4"
                    codigo = "CR.Cod_Calidad_Registro_V4"
                    resultado = ",Total_General as Resultado_Kamilion"
                End If
                cms.CommandText = "Select RC.*,CR.Fc_Reg as Fc_RegA,CR.Campania,CR.Agente,CR.Proceso,CR.Auditor,CR.Fc_Llamada,CR.Id_Caso,CR.Estado_Caso,U.nombreu as NAgente,UU.nombreu as NAuditor " & resultado & " from " & tabla & " CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario inner join Retroalimentacion_Calidad RC on " & codigo & "= RC.Id_Auditoria Where Cod_Retroalimentacion = @_Cod_Retroalimentacion and Version_Retro = @_Version"
                cms.Parameters.Add("@_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Cod_Retroalimentacion
                cms.Parameters.Add("@_Version", SqlDbType.VarChar).Value = _Validacion_Version
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                If dts.Tables(0).Rows.Count > 0 Then
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Id_Auditoria") Is DBNull.Value Then
                        _Id_Auditoria = ""
                    Else
                        _Id_Auditoria = dts.Tables(0).Rows(0).Item("Id_Auditoria")
                    End If
                    '---------------------------------------------------------------'

                    If dts.Tables(0).Rows(0).Item("Fc_Reg") Is DBNull.Value Then
                        _Fc_Reg = ""
                    Else
                        _Fc_Reg = dts.Tables(0).Rows(0).Item("Fc_Reg")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Fc_Retro") Is DBNull.Value Then
                        _Fc_Retro = ""
                    Else
                        _Fc_Retro = dts.Tables(0).Rows(0).Item("Fc_Retro")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Seguimiento") Is DBNull.Value Then
                        _Seguimiento = ""
                    Else
                        _Seguimiento = dts.Tables(0).Rows(0).Item("Seguimiento")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Tipo_Retro") Is DBNull.Value Then
                        _Tipo_Retro = ""
                    Else
                        _Tipo_Retro = dts.Tables(0).Rows(0).Item("Tipo_Retro")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Observacion") Is DBNull.Value Then
                        _ObservacionP = ""
                    Else
                        _ObservacionP = dts.Tables(0).Rows(0).Item("Observacion")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Compromiso_Usu") Is DBNull.Value Then
                        _Compromiso_Usu = ""
                    Else
                        _Compromiso_Usu = dts.Tables(0).Rows(0).Item("Compromiso_Usu")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Conclusion") Is DBNull.Value Then
                        _Conclusion = ""
                    Else
                        _Conclusion = dts.Tables(0).Rows(0).Item("Conclusion")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Fc_Reg_Actualiza") Is DBNull.Value Then
                        _Fc_Reg_Actualiza = Nothing
                    Else
                        _Fc_Reg_Actualiza = dts.Tables(0).Rows(0).Item("Fc_Reg_Actualiza")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Tiempo_Retroalimentacion") Is DBNull.Value Then
                        _Tiempo_Retroalimentacion = ""
                    Else
                        _Tiempo_Retroalimentacion = dts.Tables(0).Rows(0).Item("Tiempo_Retroalimentacion")
                    End If
                    If dts.Tables(0).Rows(0).Item("Version_Retro") Is DBNull.Value Then
                        _Todo = ""
                    Else
                        _Todo = dts.Tables(0).Rows(0).Item("Version_Retro")
                    End If

                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Resultado") Is DBNull.Value Then
                        _Item_1 = 0
                        _Item_2 = 0
                        _Item_3 = 0
                        _Item_4 = 0
                        _Item_5 = 0
                        _Resultado = 0
                    Else
                        _Item_1 = dts.Tables(0).Rows(0).Item("Item_1")
                        _Item_2 = dts.Tables(0).Rows(0).Item("Item_2")
                        _Item_3 = dts.Tables(0).Rows(0).Item("Item_3")
                        _Item_4 = dts.Tables(0).Rows(0).Item("Item_4")
                        _Item_5 = dts.Tables(0).Rows(0).Item("Item_5")
                        _Resultado = dts.Tables(0).Rows(0).Item("Resultado")
                    End If
                    '---------------------------------------------------------------'

                    If dts.Tables(0).Rows(0).Item("Fc_Reg") Is DBNull.Value Then
                        _Fc_Reg_CR = ""
                    Else
                        _Fc_Reg_CR = dts.Tables(0).Rows(0).Item("Fc_Reg")
                    End If

                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Campania") Is DBNull.Value Then
                        _Campania = ""
                    Else
                        _Campania = dts.Tables(0).Rows(0).Item("Campania")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("NAgente") Is DBNull.Value Then
                        _Agente = ""
                    Else
                        _Agente = dts.Tables(0).Rows(0).Item("NAgente")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Proceso") Is DBNull.Value Then
                        _Area = ""
                    Else
                        _Area = dts.Tables(0).Rows(0).Item("Proceso")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("NAuditor") Is DBNull.Value Then
                        _Auditor = ""
                    Else
                        _Auditor = dts.Tables(0).Rows(0).Item("NAuditor")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Fc_Llamada") Is DBNull.Value Then
                        _Fc_Llamada = ""
                    Else
                        _Fc_Llamada = dts.Tables(0).Rows(0).Item("Fc_Llamada")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Id_Caso") Is DBNull.Value Then
                        _Id_Caso = ""
                    Else
                        _Id_Caso = dts.Tables(0).Rows(0).Item("Id_Caso")
                    End If
                    '---------------------------------------------------------------'
                    If dts.Tables(0).Rows(0).Item("Estado_Caso") Is DBNull.Value Then
                        _Estado_Caso = ""
                    Else
                        _Estado_Caso = dts.Tables(0).Rows(0).Item("Estado_Caso")
                    End If
                    If dts.Tables(0).Rows(0).Item("Resultado_Kamilion") Is DBNull.Value Then
                        _Calificacion = ""
                    Else
                        _Calificacion = dts.Tables(0).Rows(0).Item("Resultado_Kamilion")
                    End If

                End If
            End If
            If Validacion = "2" Then
                cms.CommandText = "Select Version_Retro from Retroalimentacion_Calidad where Cod_Retroalimentacion=@_Cod_Retroalimentacion"
                cms.Parameters.Add("@_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Cod_Retroalimentacion
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                If dts.Tables(0).Rows.Count > 0 Then
                    If dts.Tables(0).Rows(0).Item("Version_Retro") Is DBNull.Value Then
                        _Validacion_Version = ""
                    Else
                        _Validacion_Version = dts.Tables(0).Rows(0).Item("Version_Retro")
                    End If
                End If
            End If


            If Validacion = "3" Then
                cms.CommandText = "Select * from Retroalimentacion_Causa_Calidad where Fk_Cod_Retroalimentacion = @_Cod_Retroalimentacion"
                cms.Parameters.Add("@_Cod_Retroalimentacion", SqlDbType.BigInt).Value = _Cod_Retroalimentacion
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                If dts.Tables(0).Rows.Count > 0 Then

                    'PARAMETROS
                    If dts.Tables(0).Rows.Count >= 1 Then
                        _Parametro = dts.Tables(0).Rows(0).Item("Parametro")
                    Else
                        _Parametro = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 2 Then
                        _Parametro0 = dts.Tables(0).Rows(1).Item("Parametro")
                    Else
                        _Parametro0 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 3 Then
                        _Parametro1 = dts.Tables(0).Rows(2).Item("Parametro")
                    Else
                        _Parametro1 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 4 Then
                        _Parametro2 = dts.Tables(0).Rows(3).Item("Parametro")
                    Else
                        _Parametro2 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 5 Then
                        _Parametro3 = dts.Tables(0).Rows(4).Item("Parametro")
                    Else
                        _Parametro3 = ""
                    End If

                    'OBSERVACION

                    If dts.Tables(0).Rows.Count >= 1 Then
                        _Observacion = dts.Tables(0).Rows(0).Item("Observacion")
                    Else
                        _Observacion = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 2 Then
                        _Observacion0 = dts.Tables(0).Rows(1).Item("Observacion")
                    Else
                        _Observacion0 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 3 Then
                        _Observacion1 = dts.Tables(0).Rows(2).Item("Observacion")
                    Else
                        _Observacion1 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 4 Then
                        _Observacion2 = dts.Tables(0).Rows(3).Item("Observacion")
                    Else
                        _Observacion2 = ""
                    End If
                    If dts.Tables(0).Rows.Count >= 5 Then
                        _Observacion3 = dts.Tables(0).Rows(4).Item("Observacion")
                    Else
                        _Observacion3 = ""
                    End If
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


