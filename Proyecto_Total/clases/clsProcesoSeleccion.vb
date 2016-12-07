Public Class clsProcesoSeleccion

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''' Aspirantes ''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Cod_Aspirante As Int64
    Protected _Fecha_Actual As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    Protected _Id_Usuario As String
    Protected _Fecha_Filtro As String
    Protected _Fecha_Entrevista As String
    Protected _AM_PM As String
    Protected _FK_Cod_Empresa As Integer
    Protected _Id_Aspirante As Int64
    Protected _Nombre_Aspirante As String
    Protected _Apellido As String
    Protected _Telefono1 As String
    Protected _Telefono2 As String
    Protected _Celular1 As String
    Protected _Celular2 As String
    Protected _Fk_Cod_Perfil_PS As Integer
    Protected _Fk_Cod_Cargo_Aspira As Integer
    Protected _Estado As String
    Protected _Estudia As String
    Protected _Experiencia As String
    Protected _Carrera As String
    Protected _Fk_Cod_Medio_Difucion As Integer
    Protected _Convocado As String
    Protected _Asiste_Entrevista As String
    Protected _Promedio_Entrevista As String
    Protected _Promedio_Optimo As String
    Protected _Promedio_Digitacion As String
    Protected _Promedio_C_Lectura As String
    Protected _Promedio_Ortografia As String
    Protected _Test_Wartegg As String
    Protected _PF_16 As String
    Protected _Assessment_Center As String
    Protected _Diligencias As String
    Protected _Resultado_General As String
    Protected _Preseleccionado As String
    Protected _Cantidad As Integer
    Protected _Id_Aspirante_Update As Int64

    Public Property Id_Aspirante_Update As Int64
        Get
            Return _Id_Aspirante_Update
        End Get
        Set(ByVal value As Int64)
            _Id_Aspirante_Update = value
        End Set
    End Property
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property
    Public Property Preseleccionado As String
        Get
            Return _Preseleccionado
        End Get
        Set(ByVal value As String)
            _Preseleccionado = value
        End Set
    End Property
    Public Property Resultado_General As String
        Get
            Return _Resultado_General
        End Get
        Set(ByVal value As String)
            _Resultado_General = value
        End Set
    End Property
    Public Property Diligencias As String
        Get
            Return _Diligencias
        End Get
        Set(ByVal value As String)
            _Diligencias = value
        End Set
    End Property
    Public Property Assessment_Center As String
        Get
            Return _Assessment_Center
        End Get
        Set(ByVal value As String)
            _Assessment_Center = value
        End Set
    End Property
    Public Property PF_16 As String
        Get
            Return _PF_16
        End Get
        Set(ByVal value As String)
            _PF_16 = value
        End Set
    End Property
    Public Property Test_Wartegg As String
        Get
            Return _Test_Wartegg
        End Get
        Set(ByVal value As String)
            _Test_Wartegg = value
        End Set
    End Property
    Public Property Promedio_Ortografia As String
        Get
            Return _Promedio_Ortografia
        End Get
        Set(ByVal value As String)
            _Promedio_Ortografia = value
        End Set
    End Property
    Public Property Promedio_C_Lectura As String
        Get
            Return _Promedio_C_Lectura
        End Get
        Set(ByVal value As String)
            _Promedio_C_Lectura = value
        End Set
    End Property
    Public Property Promedio_Digitacion As String
        Get
            Return _Promedio_Digitacion
        End Get
        Set(ByVal value As String)
            _Promedio_Digitacion = value
        End Set
    End Property
    Public Property Promedio_Optimo As String
        Get
            Return _Promedio_Optimo
        End Get
        Set(ByVal value As String)
            _Promedio_Optimo = value
        End Set
    End Property
    Public Property Promedio_Entrevista As String
        Get
            Return _Promedio_Entrevista
        End Get
        Set(ByVal value As String)
            _Promedio_Entrevista = value
        End Set
    End Property
    Public Property Asiste_Entrevista As String
        Get
            Return _Asiste_Entrevista
        End Get
        Set(ByVal value As String)
            _Asiste_Entrevista = value
        End Set
    End Property
    Public Property Convocado As String
        Get
            Return _Convocado
        End Get
        Set(ByVal value As String)
            _Convocado = value
        End Set
    End Property
    Public Property Fk_Cod_Medio_Difucion() As Integer
        Get
            Return _Fk_Cod_Medio_Difucion
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Medio_Difucion = value
        End Set
    End Property
    Public Property Carrera As String
        Get
            Return _Carrera
        End Get
        Set(ByVal value As String)
            _Carrera = value
        End Set
    End Property
    Public Property Experiencia As String
        Get
            Return _Experiencia
        End Get
        Set(ByVal value As String)
            _Experiencia = value
        End Set
    End Property
    Public Property Estudia() As String
        Get
            Return _Estudia
        End Get
        Set(ByVal value As String)
            _Estudia = value
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
    Public Property Fk_Cod_Cargo_Aspira() As Integer
        Get
            Return _Fk_Cod_Cargo_Aspira
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Cargo_Aspira = value
        End Set
    End Property
    Public Property Fk_Cod_Perfil_PS As Integer
        Get
            Return _Fk_Cod_Perfil_PS
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Perfil_PS = value
        End Set
    End Property
    Public Property Celular2() As String
        Get
            Return _Celular2
        End Get
        Set(ByVal value As String)
            _Celular2 = value
        End Set
    End Property
    Public Property Celular1() As String
        Get
            Return _Celular1
        End Get
        Set(ByVal value As String)
            _Celular1 = value
        End Set
    End Property
    Public Property Telefono2() As String
        Get
            Return _Telefono2
        End Get
        Set(ByVal value As String)
            _Telefono2 = value
        End Set
    End Property
    Public Property Telefono1() As String
        Get
            Return _Telefono1
        End Get
        Set(ByVal value As String)
            _Telefono1 = value
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
    Public Property Nombre_Aspirante() As String
        Get
            Return _Nombre_Aspirante
        End Get
        Set(ByVal value As String)
            _Nombre_Aspirante = value
        End Set
    End Property
    Public Property Id_Aspirante() As Int64
        Get
            Return _Id_Aspirante
        End Get
        Set(ByVal value As Int64)
            _Id_Aspirante = value
        End Set
    End Property
    Public Property Fk_Cod_Empresa() As Integer
        Get
            Return _Fk_Cod_Empresa
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_Empresa = value
        End Set
    End Property
    Public Property AM_PM As String
        Get
            Return _AM_PM
        End Get
        Set(ByVal value As String)
            _AM_PM = value
        End Set
    End Property
    Public Property Fecha_Entrevista As String
        Get
            Return _Fecha_Entrevista
        End Get
        Set(ByVal value As String)
            _Fecha_Entrevista = value
        End Set
    End Property
    Public Property Fecha_Filtro As String
        Get
            Return _Fecha_Filtro
        End Get
        Set(ByVal value As String)
            _Fecha_Filtro = value
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
    Public Property Fecha_Actual As String
        Get
            Return _Fecha_Actual
        End Get
        Set(ByVal value As String)
            _Fecha_Actual = value
        End Set
    End Property
    Public Property Cod_Aspirante As Int64
        Get
            Return _Cod_Aspirante
        End Get
        Set(ByVal value As Int64)
            _Cod_Aspirante = value
        End Set
    End Property


    Public Sub IngresarAspirante()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "insert into Aspirante (Fecha_Registro,Id_Usuario,Fecha_Filtro,Fecha_Entrevista,AM_PM,Fk_Cod_Empresa,Id_Aspirante,Nombre,Apellido,Telefono1,Telefono2,Celular1,Celular2,Fk_Cod_Perfil_PS,Fk_Cod_Cargo_Aspira,Estado,Estudia,Experiencia,Carrera,Fk_Cod_Medio_Difucion,Convocado,Asiste_Entrevista,Promedio_Entrevista,Promedio_Optimo,Promedio_Digitacion,Promedio_C_Lectura,Promedio_Ortografia,Test_Wartegg,PF_16,Assessment_Center,Diligencias,Resultado_General,Preseleccionado) values (@_Fecha_Registro,@_Id_Usuario,@_Fecha_Filtro,@_Fecha_Entrevista,@_AM_PM,@_Fk_Cod_Empresa,@_Id_Aspirante,@_Nombre_Aspirante,@_Apellido,@_Telefono1,@_Telefono2,@_Celular1,@_Celular2,@_Fk_Cod_Perfil_PS,@_Fk_Cod_Cargo_Aspira,@_Estado,@_Estudia,@_Experiencia,@_Carrera,@_Fk_Cod_Medio_Difucion,@_Convocado,@_Asiste_Entrevista,@_Promedio_Entrevista,@_Promedio_Optimo,@_Promedio_Digitacion,@_Promedio_C_Lectura,@_Promedio_Ortografia,@_Test_Wartegg,@_PF_16,@_Assessment_Center,@_Diligencias,@_Resultado_General,@_Preseleccionado)"
            cms.Parameters.Add("@_Fecha_Registro", SqlDbType.VarChar, 60).Value = _Fecha_Actual
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 60).Value = _Id_Usuario
            cms.Parameters.Add("@_Fecha_Filtro", SqlDbType.VarChar, 60).Value = _Fecha_Filtro
            cms.Parameters.Add("@_Fecha_Entrevista", SqlDbType.VarChar, 60).Value = _Fecha_Entrevista
            cms.Parameters.Add("@_AM_PM", SqlDbType.VarChar, 15).Value = _AM_PM
            cms.Parameters.Add("@_Fk_Cod_Empresa", SqlDbType.Int).Value = _FK_Cod_Empresa
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.BigInt).Value = _Id_Aspirante
            cms.Parameters.Add("@_Nombre_Aspirante", SqlDbType.VarChar, 50).Value = _Nombre_Aspirante
            cms.Parameters.Add("@_Apellido", SqlDbType.VarChar, 60).Value = _Apellido
            cms.Parameters.Add("@_Telefono1", SqlDbType.VarChar, 15).Value = _Telefono1
            cms.Parameters.Add("@_Telefono2", SqlDbType.VarChar, 15).Value = _Telefono2
            cms.Parameters.Add("@_Celular1", SqlDbType.VarChar, 15).Value = _Celular1
            cms.Parameters.Add("@_Celular2", SqlDbType.VarChar, 15).Value = _Celular2
            cms.Parameters.Add("@_Fk_Cod_Perfil_PS", SqlDbType.Int).Value = _Fk_Cod_Perfil_PS
            cms.Parameters.Add("@_Fk_Cod_Cargo_Aspira", SqlDbType.Int).Value = _Fk_Cod_Cargo_Aspira
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 20).Value = _Estado
            cms.Parameters.Add("@_Estudia", SqlDbType.VarChar, 5).Value = _Estudia
            cms.Parameters.Add("@_Experiencia", SqlDbType.VarChar, 5).Value = _Experiencia
            cms.Parameters.Add("@_Carrera", SqlDbType.VarChar, 100).Value = _Carrera
            cms.Parameters.Add("@_Fk_Cod_Medio_Difucion", SqlDbType.Int).Value = _Fk_Cod_Medio_Difucion
            cms.Parameters.Add("@_Convocado", SqlDbType.VarChar, 5).Value = _Convocado
            cms.Parameters.Add("@_Asiste_Entrevista", SqlDbType.VarChar, 5).Value = _Asiste_Entrevista
            cms.Parameters.Add("@_Promedio_Entrevista", SqlDbType.VarChar, 20).Value = _Promedio_Entrevista
            cms.Parameters.Add("@_Promedio_Optimo", SqlDbType.VarChar, 20).Value = _Promedio_Optimo
            cms.Parameters.Add("@_Promedio_Digitacion", SqlDbType.VarChar, 20).Value = _Promedio_Digitacion
            cms.Parameters.Add("@_Promedio_C_Lectura", SqlDbType.VarChar, 20).Value = _Promedio_C_Lectura
            cms.Parameters.Add("@_Promedio_Ortografia", SqlDbType.VarChar, 20).Value = _Promedio_Ortografia
            cms.Parameters.Add("@_Test_Wartegg", SqlDbType.VarChar, 20).Value = _Test_Wartegg
            cms.Parameters.Add("@_PF_16", SqlDbType.VarChar, 20).Value = _PF_16
            cms.Parameters.Add("@_Assessment_Center", SqlDbType.VarChar, 20).Value = _Assessment_Center
            cms.Parameters.Add("@_Diligencias", SqlDbType.VarChar, 20).Value = _Diligencias
            cms.Parameters.Add("@_Resultado_General", SqlDbType.VarChar, 20).Value = _Resultado_General
            cms.Parameters.Add("@_Preseleccionado", SqlDbType.VarChar, 20).Value = _Preseleccionado
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

    Public Sub ActualizarAspirante()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "update Aspirante set Fecha_Registro_Update=@_Fecha_Registro,Id_Usuario_Update=@_Id_Usuario,Fecha_Filtro=@_Fecha_Filtro,Fecha_Entrevista=@_Fecha_Entrevista,AM_PM=@_AM_PM,Fk_Cod_Empresa=@_Fk_Cod_Empresa,Id_Aspirante=@_Id_Aspirante,Nombre=@_Nombre_Aspirante,Apellido=@_Apellido,Telefono1=@_Telefono1,Telefono2=@_Telefono2,Celular1=@_Celular1,Celular2=@_Celular2,Fk_Cod_Perfil_PS=@_Fk_Cod_Perfil_PS,Fk_Cod_Cargo_Aspira=@_Fk_Cod_Cargo_Aspira,Estado=@_Estado,Estudia=@_Estudia,Experiencia=@_Experiencia,Carrera=@_Carrera,Fk_Cod_Medio_Difucion=@_Fk_Cod_Medio_Difucion,Convocado=@_Convocado,Asiste_Entrevista=@_Asiste_Entrevista,Promedio_Entrevista=@_Promedio_Entrevista,Promedio_Optimo=@_Promedio_Optimo,Promedio_Digitacion=@_Promedio_Digitacion,Promedio_C_Lectura=@_Promedio_C_Lectura,Promedio_Ortografia=@_Promedio_Ortografia,Test_Wartegg=@_Test_Wartegg,PF_16=@_PF_16,Assessment_Center=@_Assessment_Center,Diligencias=@_Diligencias,Resultado_General=@_Resultado_General,Preseleccionado=@_Preseleccionado where Id_Aspirante=@_Id_Aspirante_Update"
            cms.Parameters.Add("@_Fecha_Registro", SqlDbType.VarChar, 60).Value = _Fecha_Actual
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 60).Value = _Id_Usuario
            cms.Parameters.Add("@_Fecha_Filtro", SqlDbType.VarChar, 60).Value = _Fecha_Filtro
            cms.Parameters.Add("@_Fecha_Entrevista", SqlDbType.VarChar, 60).Value = _Fecha_Entrevista
            cms.Parameters.Add("@_AM_PM", SqlDbType.VarChar, 15).Value = _AM_PM
            cms.Parameters.Add("@_Fk_Cod_Empresa", SqlDbType.Int).Value = _FK_Cod_Empresa
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.BigInt).Value = _Id_Aspirante
            cms.Parameters.Add("@_Id_Aspirante_Update", SqlDbType.BigInt).Value = _Id_Aspirante_Update
            cms.Parameters.Add("@_Nombre_Aspirante", SqlDbType.VarChar, 50).Value = _Nombre_Aspirante
            cms.Parameters.Add("@_Apellido", SqlDbType.VarChar, 60).Value = _Apellido
            cms.Parameters.Add("@_Telefono1", SqlDbType.VarChar, 15).Value = _Telefono1
            cms.Parameters.Add("@_Telefono2", SqlDbType.VarChar, 15).Value = _Telefono2
            cms.Parameters.Add("@_Celular1", SqlDbType.VarChar, 15).Value = _Celular1
            cms.Parameters.Add("@_Celular2", SqlDbType.VarChar, 15).Value = _Celular2
            cms.Parameters.Add("@_Fk_Cod_Perfil_PS", SqlDbType.Int).Value = _Fk_Cod_Perfil_PS
            cms.Parameters.Add("@_Fk_Cod_Cargo_Aspira", SqlDbType.Int).Value = _Fk_Cod_Cargo_Aspira
            cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 20).Value = _Estado
            cms.Parameters.Add("@_Estudia", SqlDbType.VarChar, 5).Value = _Estudia
            cms.Parameters.Add("@_Experiencia", SqlDbType.VarChar, 5).Value = _Experiencia
            cms.Parameters.Add("@_Carrera", SqlDbType.VarChar, 100).Value = _Carrera
            cms.Parameters.Add("@_Fk_Cod_Medio_Difucion", SqlDbType.Int).Value = _Fk_Cod_Medio_Difucion
            cms.Parameters.Add("@_Convocado", SqlDbType.VarChar, 5).Value = _Convocado
            cms.Parameters.Add("@_Asiste_Entrevista", SqlDbType.VarChar, 5).Value = _Asiste_Entrevista
            cms.Parameters.Add("@_Promedio_Entrevista", SqlDbType.VarChar, 20).Value = _Promedio_Entrevista
            cms.Parameters.Add("@_Promedio_Optimo", SqlDbType.VarChar, 20).Value = _Promedio_Optimo
            cms.Parameters.Add("@_Promedio_Digitacion", SqlDbType.VarChar, 20).Value = _Promedio_Digitacion
            cms.Parameters.Add("@_Promedio_C_Lectura", SqlDbType.VarChar, 20).Value = _Promedio_C_Lectura
            cms.Parameters.Add("@_Promedio_Ortografia", SqlDbType.VarChar, 20).Value = _Promedio_Ortografia
            cms.Parameters.Add("@_Test_Wartegg", SqlDbType.VarChar, 20).Value = _Test_Wartegg
            cms.Parameters.Add("@_PF_16", SqlDbType.VarChar, 20).Value = _PF_16
            cms.Parameters.Add("@_Assessment_Center", SqlDbType.VarChar, 20).Value = _Assessment_Center
            cms.Parameters.Add("@_Diligencias", SqlDbType.VarChar, 20).Value = _Diligencias
            cms.Parameters.Add("@_Resultado_General", SqlDbType.VarChar, 20).Value = _Resultado_General
            cms.Parameters.Add("@_Preseleccionado", SqlDbType.VarChar, 20).Value = _Preseleccionado
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

    Public Function Consultar_Aspirantes_Validacion() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select * from Aspirante where Id_Aspirante=@_Id_Aspirante"
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.Int).Value = _Id_Aspirante
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Id_Aspirante") Is System.DBNull.Value Then
                    _Id_Aspirante = ""
                Else
                    _Id_Aspirante = dts.Tables(0).Rows(0).Item("Id_Aspirante")
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

    Public Function Consultar_Aspirantes() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion order by A.Cod_Aspirante desc"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consultar_Aspirantes_Filtros() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion order by A.Cod_Aspirante desc"
            If _Preseleccionado <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Preseleccionado=@_Preseleccionado order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Preseleccionado", SqlDbType.VarChar, 20).Value = _Preseleccionado
            End If
            If _Asiste_Entrevista <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Asiste_Entrevista=@_Asiste_Entrevista order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Asiste_Entrevista", SqlDbType.VarChar, 5).Value = _Asiste_Entrevista
            End If
            If _Convocado <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Convocado=@_Convocado order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Convocado", SqlDbType.VarChar, 5).Value = _Convocado
            End If
            If _Fk_Cod_Cargo_Aspira <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Fk_Cod_Cargo_Aspira=@_Fk_Cod_Cargo_Aspira order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Fk_Cod_Cargo_Aspira", SqlDbType.Int).Value = _Fk_Cod_Cargo_Aspira
            End If
            If _Fk_Cod_Perfil_PS <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Fk_Cod_Perfil_PS=@_Fk_Cod_Perfil_PS order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Fk_Cod_Perfil_PS", SqlDbType.Int).Value = _Fk_Cod_Perfil_PS
            End If
            If _FK_Cod_Empresa <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.FK_Cod_Empresa=@_FK_Cod_Empresa order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_FK_Cod_Empresa", SqlDbType.Int).Value = _FK_Cod_Empresa
            End If
            If _Fecha_Entrevista <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Fecha_Entrevista=@_Fecha_Entrevista order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Fecha_Entrevista", SqlDbType.Date).Value = _Fecha_Entrevista
            End If
            If _Fecha_Filtro <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Fecha_Filtro=@_Fecha_Filtro order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Fecha_Filtro", SqlDbType.Date).Value = _Fecha_Filtro
            End If
            If _Apellido <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Apellido like '" + _Apellido + "%' order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Apellido", SqlDbType.VarChar, 60).Value = _Apellido
            End If
            If _Nombre_Aspirante <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Nombre like '" + _Nombre_Aspirante + "%' order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Nombre_Aspirante", SqlDbType.VarChar, 50).Value = _Nombre_Aspirante
            End If
            If _Id_Aspirante <> Nothing Then
                cms.CommandText = "select A.Cod_Aspirante,A.Fecha_Registro,A.Id_Usuario,A.Fecha_Registro_Update,A.Id_Usuario_Update,A.Fecha_Filtro,A.Fecha_Entrevista,A.AM_PM,E.Nombre as Nombre_Empresa,A.Id_Aspirante,A.Nombre,A.Apellido,A.Telefono1,A.Telefono2,A.Celular1,A.Celular2,P.Nombre as Nombre_Perfil,CA.Nombre as Nombre_Cargo,A.Estado,A.Estudia,A.Experiencia,A.Carrera,MD.Nombre as Nombre_MD,A.Convocado,A.Asiste_Entrevista,A.Promedio_Entrevista,A.Promedio_Optimo,A.Promedio_Digitacion,A.Promedio_C_Lectura,A.Promedio_Ortografia,A.Test_Wartegg,A.PF_16,A.Assessment_Center,A.Diligencias,A.Resultado_General,A.Preseleccionado from Aspirante A inner join Empresa E on A.Fk_Cod_Empresa = E.Cod_Empresa inner join Perfil_PS P on A.Fk_Cod_Perfil_PS = P.Cod_Perfil_PS inner join Cargo_Aspira CA on A.Fk_Cod_Cargo_Aspira = CA.Cod_Cargo_Aspira inner join Medio_Difucion MD on A.Fk_Cod_Medio_Difucion = MD.Cod_Medio_Difucion where A.Id_Aspirante=@_Id_Aspirante order by A.Cod_Aspirante desc"
                cms.Parameters.Add("@_Id_Aspirante", SqlDbType.BigInt).Value = _Id_Aspirante
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consultar_Aspirantes_Actualizar() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim intcantidad As Int64
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "Select * from Aspirante where Id_Aspirante=@_Id_Aspirante"
            cms.Parameters.Add("@_Id_Aspirante", SqlDbType.Int).Value = _Id_Aspirante
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            intcantidad = dts.Tables(0).Rows.Count
            If intcantidad > 0 And _Id_Aspirante <> Nothing Then
                If dts.Tables(0).Rows(0).Item("Fecha_Filtro") Is System.DBNull.Value Then
                    _Fecha_Filtro = ""
                Else
                    _Fecha_Filtro = dts.Tables(0).Rows(0).Item("Fecha_Filtro")
                End If
                If dts.Tables(0).Rows(0).Item("Fecha_Entrevista") Is System.DBNull.Value Then
                    _Fecha_Entrevista = ""
                Else
                    _Fecha_Entrevista = dts.Tables(0).Rows(0).Item("Fecha_Entrevista")
                End If
                If dts.Tables(0).Rows(0).Item("AM_PM") Is System.DBNull.Value Then
                    _AM_PM = ""
                Else
                    _AM_PM = dts.Tables(0).Rows(0).Item("AM_PM")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Cod_Empresa") Is System.DBNull.Value Then
                    _FK_Cod_Empresa = ""
                Else
                    _FK_Cod_Empresa = dts.Tables(0).Rows(0).Item("Fk_Cod_Empresa")
                End If
                If dts.Tables(0).Rows(0).Item("Id_Aspirante") Is System.DBNull.Value Then
                    _Id_Aspirante = ""
                Else
                    _Id_Aspirante = dts.Tables(0).Rows(0).Item("Id_Aspirante")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre") Is System.DBNull.Value Then
                    _Nombre_Aspirante = ""
                Else
                    _Nombre_Aspirante = dts.Tables(0).Rows(0).Item("Nombre")
                End If
                If dts.Tables(0).Rows(0).Item("Apellido") Is System.DBNull.Value Then
                    _Apellido = ""
                Else
                    _Apellido = dts.Tables(0).Rows(0).Item("Apellido")
                End If
                If dts.Tables(0).Rows(0).Item("Telefono1") Is System.DBNull.Value Then
                    _Telefono1 = ""
                Else
                    _Telefono1 = dts.Tables(0).Rows(0).Item("Telefono1")
                End If
                If dts.Tables(0).Rows(0).Item("Telefono2") Is System.DBNull.Value Then
                    _Telefono2 = ""
                Else
                    _Telefono2 = dts.Tables(0).Rows(0).Item("Telefono2")
                End If
                If dts.Tables(0).Rows(0).Item("Celular1") Is System.DBNull.Value Then
                    _Celular1 = ""
                Else
                    _Celular1 = dts.Tables(0).Rows(0).Item("Celular1")
                End If
                If dts.Tables(0).Rows(0).Item("Celular2") Is System.DBNull.Value Then
                    _Celular2 = ""
                Else
                    _Celular2 = dts.Tables(0).Rows(0).Item("Celular2")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Cod_Perfil_PS") Is System.DBNull.Value Then
                    _Fk_Cod_Perfil_PS = ""
                Else
                    _Fk_Cod_Perfil_PS = dts.Tables(0).Rows(0).Item("Fk_Cod_Perfil_PS")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Cod_Cargo_Aspira") Is System.DBNull.Value Then
                    _Fk_Cod_Cargo_Aspira = ""
                Else
                    _Fk_Cod_Cargo_Aspira = dts.Tables(0).Rows(0).Item("Fk_Cod_Cargo_Aspira")
                End If
                If dts.Tables(0).Rows(0).Item("Estado") Is System.DBNull.Value Then
                    _Estado = ""
                Else
                    _Estado = dts.Tables(0).Rows(0).Item("Estado")
                End If
                If dts.Tables(0).Rows(0).Item("Estudia") Is System.DBNull.Value Then
                    _Estudia = ""
                Else
                    _Estudia = dts.Tables(0).Rows(0).Item("Estudia")
                End If
                If dts.Tables(0).Rows(0).Item("Experiencia") Is System.DBNull.Value Then
                    _Experiencia = ""
                Else
                    _Experiencia = dts.Tables(0).Rows(0).Item("Experiencia")
                End If
                If dts.Tables(0).Rows(0).Item("Carrera") Is System.DBNull.Value Then
                    _Carrera = ""
                Else
                    _Carrera = dts.Tables(0).Rows(0).Item("Carrera")
                End If
                If dts.Tables(0).Rows(0).Item("Fk_Cod_Medio_Difucion") Is System.DBNull.Value Then
                    _Fk_Cod_Medio_Difucion = ""
                Else
                    _Fk_Cod_Medio_Difucion = dts.Tables(0).Rows(0).Item("Fk_Cod_Medio_Difucion")
                End If
                If dts.Tables(0).Rows(0).Item("Convocado") Is System.DBNull.Value Then
                    _Convocado = ""
                Else
                    _Convocado = dts.Tables(0).Rows(0).Item("Convocado")
                End If
                If dts.Tables(0).Rows(0).Item("Asiste_Entrevista") Is System.DBNull.Value Then
                    _Asiste_Entrevista = ""
                Else
                    _Asiste_Entrevista = dts.Tables(0).Rows(0).Item("Asiste_Entrevista")
                End If
                If dts.Tables(0).Rows(0).Item("Promedio_Entrevista") Is System.DBNull.Value Then
                    _Promedio_Entrevista = ""
                Else
                    _Promedio_Entrevista = dts.Tables(0).Rows(0).Item("Promedio_Entrevista")
                End If
                If dts.Tables(0).Rows(0).Item("Promedio_Optimo") Is System.DBNull.Value Then
                    _Promedio_Optimo = ""
                Else
                    _Promedio_Optimo = dts.Tables(0).Rows(0).Item("Promedio_Optimo")
                End If
                If dts.Tables(0).Rows(0).Item("Promedio_Digitacion") Is System.DBNull.Value Then
                    _Promedio_Digitacion = ""
                Else
                    _Promedio_Digitacion = dts.Tables(0).Rows(0).Item("Promedio_Digitacion")
                End If
                If dts.Tables(0).Rows(0).Item("Promedio_C_Lectura") Is System.DBNull.Value Then
                    _Promedio_C_Lectura = ""
                Else
                    _Promedio_C_Lectura = dts.Tables(0).Rows(0).Item("Promedio_C_Lectura")
                End If
                If dts.Tables(0).Rows(0).Item("Promedio_Ortografia") Is System.DBNull.Value Then
                    _Promedio_Ortografia = ""
                Else
                    _Promedio_Ortografia = dts.Tables(0).Rows(0).Item("Promedio_Ortografia")
                End If
                If dts.Tables(0).Rows(0).Item("Test_Wartegg") Is System.DBNull.Value Then
                    _Test_Wartegg = ""
                Else
                    _Test_Wartegg = dts.Tables(0).Rows(0).Item("Test_Wartegg")
                End If
                If dts.Tables(0).Rows(0).Item("PF_16") Is System.DBNull.Value Then
                    _PF_16 = ""
                Else
                    _PF_16 = dts.Tables(0).Rows(0).Item("PF_16")
                End If
                If dts.Tables(0).Rows(0).Item("Assessment_Center") Is System.DBNull.Value Then
                    _Assessment_Center = ""
                Else
                    _Assessment_Center = dts.Tables(0).Rows(0).Item("Assessment_Center")
                End If
                If dts.Tables(0).Rows(0).Item("Diligencias") Is System.DBNull.Value Then
                    _Diligencias = ""
                Else
                    _Diligencias = dts.Tables(0).Rows(0).Item("Diligencias")
                End If
                If dts.Tables(0).Rows(0).Item("Resultado_General") Is System.DBNull.Value Then
                    _Resultado_General = ""
                Else
                    _Resultado_General = dts.Tables(0).Rows(0).Item("Resultado_General")
                End If
                If dts.Tables(0).Rows(0).Item("Preseleccionado") Is System.DBNull.Value Then
                    _Preseleccionado = ""
                Else
                    _Preseleccionado = dts.Tables(0).Rows(0).Item("Preseleccionado")
                End If
            Else
                If intcantidad = 0 And _Id_Aspirante <> Nothing Then
                    _Fecha_Filtro = ""
                    _Fecha_Entrevista = ""
                    _AM_PM = ""
                    _FK_Cod_Empresa = 1
                    _Id_Aspirante = Nothing
                    _Nombre_Aspirante = ""
                    _Apellido = ""
                    _Telefono1 = ""
                    _Telefono2 = ""
                    _Celular1 = ""
                    _Celular2 = ""
                    _Fk_Cod_Perfil_PS = 1
                    _Fk_Cod_Cargo_Aspira = 1
                    _Estado = ""
                    _Estudia = ""
                    _Experiencia = ""
                    _Carrera = ""
                    _Fk_Cod_Medio_Difucion = 1
                    _Convocado = ""
                    _Asiste_Entrevista = ""
                    _Promedio_Entrevista = ""
                    _Promedio_Optimo = ""
                    _Promedio_Digitacion = ""
                    _Promedio_C_Lectura = ""
                    _Promedio_Ortografia = ""
                    _Test_Wartegg = ""
                    _PF_16 = ""
                    _Assessment_Center = ""
                    _Diligencias = ""
                    _Resultado_General = ""
                    _Preseleccionado = ""
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


    Public Function Consulta_Perfil() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Perfil_PS where Estado = 1 order by Nombre asc"
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
    Public Function Consulta_Cargo_Aspira() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Cargo_Aspira where Estado = 1 order by Nombre asc"
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
    Public Function Consulta_Empresa() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Empresa where Estado = 1  order by Nombre asc"
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
    Public Function Consulta_Medio_Difucion() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select * from Medio_Difucion where Estado = 1 order by Nombre asc"
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
    Public Sub Ingresar_Nuevo_Cargo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into Cargo_Aspira values (@_Nombre_Aspirante,1)"
            cms.Parameters.Add("@_Nombre_Aspirante", SqlDbType.VarChar, 100).Value = _Nombre_Aspirante
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub Ingresar_Nueva_Empresa()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into Empresa values (@_Nombre_Aspirante,1)"
            cms.Parameters.Add("@_Nombre_Aspirante", SqlDbType.VarChar, 100).Value = _Nombre_Aspirante
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub Ingresar_Nuevo_Perfil()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into Perfil_PS values (@_Nombre_Aspirante,1)"
            cms.Parameters.Add("@_Nombre_Aspirante", SqlDbType.VarChar, 100).Value = _Nombre_Aspirante
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub Ingresar_Nuevo_MD()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into Medio_Difucion values (@_Nombre_Aspirante,1)"
            cms.Parameters.Add("@_Nombre_Aspirante", SqlDbType.VarChar, 100).Value = _Nombre_Aspirante
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class
