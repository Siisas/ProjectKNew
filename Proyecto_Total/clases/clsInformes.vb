Public Class clsInformes
    'INFORME INCONSISTENCIAS
    Protected _Fcini As String
    Protected _Fcfin As String
    Protected _Cantidad As Integer
    Protected _Mes As Integer
    Protected _Año As Integer
    Protected _Validacion As String

    Protected _ConSopDia As Integer
    Protected _OfrecNxmonitor As Integer
    Protected _Inst_Nxmonitorllamada As Integer
    Protected _Total_Ofrecimientos As Integer


    Protected _Ciudad As String
    Protected _Fecha_Inicio As String
    Protected _Fecha_Fin As String
    Protected _Cola As String

    Protected _F1 As String
    Protected _F2 As String
    Protected _F3 As String
    Protected _F4 As String
    Protected _F5 As String
    Protected _Otro As String
    Protected _Depar As String

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''' Campañas Voz - Datos ''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Protected _Fsap As String
    Protected _Fcorta As String
    Protected _Cliente As String
    Protected _Campa As String

    Protected _codigo As String
    Protected _Documento As String
    Protected _Experiencia As Int64
    Protected _Nivel As Int64
    Protected _AñoApla As Int64
    Protected _SemApla As String
    Protected _Area As Int64
    Protected _Categoria As Int64
    Protected _semestre As Int64
    Protected _institucion As String
    Protected _Practica As String
    Protected _Id As String
    Protected _Nombre As String

    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    Public Property Documento As String
        Get
            Return _Documento
        End Get
        Set(ByVal value As String)
            _Documento = value
        End Set
    End Property
    Public Property Experiencia As Int64
        Get
            Return _Experiencia
        End Get
        Set(ByVal value As Int64)
            _Experiencia = value
        End Set
    End Property
    Public Property Nivel As Int64
        Get
            Return _Nivel
        End Get
        Set(ByVal value As Int64)
            _Nivel = value
        End Set
    End Property
    Public Property AñoApla As Int64
        Get
            Return _AñoApla
        End Get
        Set(ByVal value As Int64)
            _AñoApla = value
        End Set
    End Property
    Public Property SemApla As String
        Get
            Return _SemApla
        End Get
        Set(ByVal value As String)
            _SemApla = value
        End Set
    End Property

    Public Property Area As Int64
        Get
            Return _Area
        End Get
        Set(ByVal value As Int64)
            _Area = value
        End Set
    End Property
    Public Property Categoria As Int64
        Get
            Return _Categoria
        End Get
        Set(ByVal value As Int64)
            _Categoria = value
        End Set
    End Property
    Public Property semestre As Int64
        Get
            Return _semestre
        End Get
        Set(ByVal value As Int64)
            _semestre = value
        End Set
    End Property
    Public Property institucion As String
        Get
            Return _institucion
        End Get
        Set(ByVal value As String)
            _institucion = value
        End Set
    End Property
    Public Property Practica As String
        Get
            Return _Practica
        End Get
        Set(ByVal value As String)
            _Practica = value
        End Set
    End Property
    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Fsap As String
        Get
            Return _Fsap
        End Get
        Set(ByVal value As String)
            _Fsap = value
        End Set
    End Property
    Public Property Fcorta As String
        Get
            Return _Fcorta
        End Get
        Set(ByVal value As String)
            _Fcorta = value
        End Set
    End Property
    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property
    Public Property Campa As String
        Get
            Return _Campa
        End Get
        Set(ByVal value As String)
            _Campa = value
        End Set
    End Property
    Public Property Otro As String
        Get
            Return _Otro
        End Get
        Set(ByVal value As String)
            _Otro = value
        End Set
    End Property
    Public Property Depar As String
        Get
            Return _Depar
        End Get
        Set(ByVal value As String)
            _Depar = value
        End Set
    End Property

    Public Property F1 As String
        Get
            Return _F1
        End Get
        Set(ByVal value As String)
            _F1 = value
        End Set
    End Property
    Public Property F2 As String
        Get
            Return _F2
        End Get
        Set(ByVal value As String)
            _F2 = value
        End Set
    End Property
    Public Property F3 As String
        Get
            Return _F3
        End Get
        Set(ByVal value As String)
            _F3 = value
        End Set
    End Property
    Public Property F4 As String
        Get
            Return _F4
        End Get
        Set(ByVal value As String)
            _F4 = value
        End Set
    End Property
    Public Property F5 As String
        Get
            Return _F5
        End Get
        Set(ByVal value As String)
            _F5 = value
        End Set
    End Property

    Public Property Cola As Integer
        Get
            Return _Cola
        End Get
        Set(ByVal value As Integer)
            _Cola = value
        End Set
    End Property


    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(ByVal value As String)
            _Ciudad = value
        End Set
    End Property
    Public Property Fecha_inicio As String
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


    Public Property OfrecNxmonitor As Integer
        Get
            Return _OfrecNxmonitor
        End Get
        Set(ByVal value As Integer)
            _OfrecNxmonitor = value
        End Set
    End Property
    Public Property Total_Ofrecimientos As Integer
        Get
            Return _Total_Ofrecimientos
        End Get
        Set(ByVal value As Integer)
            _Total_Ofrecimientos = value
        End Set
    End Property

    Public Property Inst_Nxmonitorllamada As Integer
        Get
            Return _Inst_Nxmonitorllamada
        End Get
        Set(ByVal value As Integer)
            _Inst_Nxmonitorllamada = value
        End Set
    End Property
    Public Property ConSopDia As Integer
        Get
            Return _ConSopDia
        End Get
        Set(ByVal value As Integer)
            _ConSopDia = value
        End Set
    End Property


    Public Property Validacionn As String
        Get
            Return _Validacion
        End Get
        Set(ByVal value As String)
            _Validacion = value
        End Set
    End Property

    Public Property Mes() As String
        Get
            Return _Mes
        End Get
        Set(value As String)
            _Mes = value
        End Set
    End Property
    Public Property Año() As String
        Get
            Return _Año
        End Get
        Set(value As String)
            _Año = value
        End Set
    End Property
    Public Property Fcini() As String
        Get
            Return _Fcini
        End Get
        Set(value As String)
            _Fcini = value
        End Set
    End Property
    Public Property Fcfin() As String
        Get
            Return _Fcfin
        End Get
        Set(value As String)
            _Fcfin = value
        End Set
    End Property
    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Protected strlestadoinc As String
    Public Property estadoinc() As String
        Get
            Return strlestadoinc
        End Get
        Set(ByVal value As String)
            strlestadoinc = value
        End Set
    End Property


    'CONSULTAS INFORME INCONSISTENCIAS DATOS
    Public Function ConsultaDia() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT Convert(date,Detalleinc.fcreg) as fcreg,Count(Convert(date,Detalleinc.fcreg)) as Cantidad FROM Detalleinc WHERE (Detalleinc.fcreg>=@_Fcini And Detalleinc.fcreg<@_Fcfin) group by Convert(date,Detalleinc.fcreg)"
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.Date).Value = _Fcfin
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
    Public Function ConsultaInconsis() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT Bandeja.fc_corta, Count(Bandeja.cas_id) AS 'Total de cas_id' FROM Bandeja WHERE (Bandeja.fc_corta>=@_Fcini And Bandeja.fc_corta<@_Fcfin) and Bandeja='Datos' GROUP BY Bandeja.fc_corta"
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.Date).Value = _Fcfin
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

    'CONSULTAS INFORME INCONSISTENCIAS VOZ
    Public Function ConsultaDiaVoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT Convert(date,Detalleinc.fcreg) as fcreg,Count(Convert(date,Detalleinc.fcreg)) as Cantidad FROM Detalleinc WHERE (Detalleinc.fcreg>=@_Fcini And Detalleinc.fcreg<@_Fcfin) group by Convert(date,Detalleinc.fcreg)"
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.Date).Value = _Fcfin
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
    Public Function ConsultaInconsisVoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT Bandeja_uni.fccorta, Count(Bandeja_uni.idcaso) AS 'Total de idcaso' FROM Bandeja_uni WHERE (Bandeja_uni.fccorta>=@_Fcini And Bandeja_uni.fccorta<@_Fcfin) and Bandeja='Voz' GROUP BY Bandeja_uni.fccorta;"
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.Date).Value = _Fcfin
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

    'CONSULTAS TIPO CLIENTE DATOS
    Public Function Consulta_Tipo_cliente_Dia_Datos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT fc_corta,COUNT ([Prepago]) AS Prepago, COUNT ([Pospago]) AS Pospago, COUNT ([Empresarial]) AS Empresarial, (COUNT(Prepago)+COUNT(Pospago)+COUNT(Empresarial)) as Total FROM(SELECT * FROM Bandeja) p PIVOT( Max(tipo_clientesito) FOR tipo_clientesito IN ( [Prepago] ,[Pospago], [Empresarial])) AS Bandeja where fc_corta=@_Fecha GROUP BY fc_corta ORDER BY Total desc;"
            cms.Parameters.Add("@_Fecha", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Tipo_cliente_Mes_Datos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select (select COUNT(tipo_clientesito)as Prepago from Bandeja where tipo_clientesito='Prepago' and datepart(YEAR,fc_corta)=@_Año and datepart(MONTH,fc_corta)=@_Mes GROUP BY datepart(MONTH,fc_corta)) as Prepago,(select COUNT(tipo_clientesito)as Pospago from Bandeja where tipo_clientesito='Pospago' and datepart(YEAR,fc_corta)=@_Año and datepart(MONTH,fc_corta)=@_Mes GROUP BY datepart(MONTH,fc_corta))as Pospago,(select COUNT(tipo_clientesito)as Empresarial from Bandeja where tipo_clientesito='Empresarial' and datepart(YEAR,fc_corta)=@_Año and datepart(MONTH,fc_corta)=@_Mes GROUP BY datepart(MONTH,fc_corta))as Empresarial from Bandeja where datepart(YEAR,fc_corta)=@_Año and datepart(MONTH,fc_corta)=@_Mes GROUP BY datepart(MONTH,fc_corta)"
            cms.Parameters.Add("@_Año", SqlDbType.Int).Value = _Año
            cms.Parameters.Add("@_Mes", SqlDbType.Int).Value = _Mes
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

    'CONSULTAS TIPO CLIENTE VOZ
    Public Function Consulta_Tipo_cliente_Dia_Voz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT fccorta,COUNT ([Prepago]) AS Prepago, COUNT ([Pospago]) AS Pospago, COUNT ([Empresarial]) AS Empresarial, (COUNT(Prepago)+COUNT(Pospago)+COUNT(Empresarial)) as Total FROM(SELECT * FROM Bandeja_uni) p PIVOT( Max(tipo_clientesito) FOR tipo_clientesito IN ( [Prepago] ,[Pospago], [Empresarial])) AS Bandeja_uni where fccorta=@_Fecha GROUP BY fccorta ORDER BY Total desc;"
            cms.Parameters.Add("@_Fecha", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Tipo_cliente_Mes_Voz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select (select COUNT(tipo_clientesito)as Prepago from Bandeja_uni where tipo_clientesito='Prepago' and datepart(YEAR,fccorta)=@_Año and datepart(MONTH,fccorta)=@_Mes GROUP BY datepart(MONTH,fccorta)) as Prepago,(select COUNT(tipo_clientesito)as Pospago from Bandeja_uni where tipo_clientesito='Pospago' and datepart(YEAR,fccorta)=@_Año and datepart(MONTH,fccorta)=@_Mes GROUP BY datepart(MONTH,fccorta))as Pospago,(select COUNT(tipo_clientesito)as Empresarial from Bandeja_uni where tipo_clientesito='Empresarial' and datepart(YEAR,fccorta)=@_Año and datepart(MONTH,fccorta)=@_Mes GROUP BY datepart(MONTH,fccorta))as Empresarial from Bandeja_uni where datepart(YEAR,fccorta)=@_Año and datepart(MONTH,fccorta)=@_Mes GROUP BY datepart(MONTH,fccorta)"
            cms.Parameters.Add("@_Año", SqlDbType.Int).Value = _Año
            cms.Parameters.Add("@_Mes", SqlDbType.Int).Value = _Mes
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
    Public Function Consulta_Remision_Equipos_cav() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT CRM.idcaso, CRM.fcreg, TCRM2.HOMOLOGACION_SIC FROM CRMDetalle CRM INNER JOIN Tipificacion_CRM_2 TCRM2 ON CRM.tipo_soporte = TCRM2.ESCENARIO WHERE (CRM.fcreg>=@_Fcini AND CRM.fcreg<=@_Fcfin) AND TCRM2.HOMOLOGACION_SIC Like '%Remision a CAV - Servicio Tecnico para verificacion de equipo%'"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.VarChar, 20).Value = _Fcfin
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
    Public Function Consulta_Total_Voz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Validacion = "Voz" Then
                cms.CommandText = "Select Count(B.idcaso) as Cantidad from bandeja_uni B where B.Bandeja='Voz' AND (B.cas_fecha_registro>=@_Fcini And B.cas_fecha_registro<=@_Fcfin)"
            End If
            If _Validacion = "Otros" Then
                cms.CommandText = " SELECT Count(B.idcaso) AS Cantidad FROM bandeja_uni B WHERE (B.Bandeja='Mensajes' Or B.Bandeja='Buzon' Or B.Bandeja='Otros Serv') AND (B.cas_fecha_registro>=@_Fcini And B.cas_fecha_registro<=@_Fcfin)"
            End If
            If _Validacion = "Vozred" Then
                cms.CommandText = "SELECT Count(Bandeja_uni.idcaso) as Cantidad FROM (Bandeja_uni INNER JOIN VCRMDetalle ON Bandeja_uni.idcaso = VCRMDetalle.idcaso) INNER JOIN VTiposoporte ON VCRMDetalle.tipificacion = VTiposoporte.tipifcrm WHERE Bandeja_uni.bandeja='VOZ' AND (Bandeja_uni.cas_fecha_registro>=@_Fcini And Bandeja_uni.cas_fecha_registro<=@_Fcfin) and VTiposoporte.idtipo > 0 and VTiposoporte.idtipo < 10"
            End If
            If _Validacion = "Otrosred" Then
                cms.CommandText = "SELECT Count(Bandeja_uni.idcaso) as Cantidad FROM (Bandeja_uni INNER JOIN VCRMDetalle ON Bandeja_uni.idcaso = VCRMDetalle.idcaso) INNER JOIN VTiposoporte ON VCRMDetalle.tipificacion = VTiposoporte.tipifcrm WHERE (Bandeja_uni.Bandeja='Mensajes' Or Bandeja_uni.Bandeja='Buzon' Or Bandeja_uni.Bandeja='Otros Serv') AND (Bandeja_uni.cas_fecha_registro>=@_Fcini And Bandeja_uni.cas_fecha_registro<=@_Fcfin) and (VTiposoporte.idtipo = 20)"
            End If
            If _Validacion = "2G" Then
                cms.CommandText = "SELECT count(Bandeja_uni.idcaso) as Cantidad FROM Bandeja_uni INNER JOIN Bandeja_voz ON Bandeja_uni.idcaso = Bandeja_voz.cas_id WHERE (((Bandeja_uni.bandeja)='voz') AND ((Bandeja_voz.Tecnologia_Voz_01)='2G GSM - EDGE') AND ((Bandeja_uni.cas_fecha_registro)>=@_Fcini And (Bandeja_uni.cas_fecha_registro)<=@_Fcfin))"
            End If
            If _Validacion = "3G" Then
                cms.CommandText = "SELECT count(Bandeja_uni.idcaso) as Cantidad FROM Bandeja_uni INNER JOIN Bandeja_voz ON Bandeja_uni.idcaso = Bandeja_voz.cas_id WHERE (((Bandeja_uni.bandeja)='voz') AND ((Bandeja_voz.Tecnologia_Voz_01) Is Null) AND ((Bandeja_uni.cas_fecha_registro)>=@_Fcini And (Bandeja_uni.cas_fecha_registro)<=@_Fcfin)) OR (((Bandeja_voz.Tecnologia_Voz_01)='UMTS 3G') AND ((Bandeja_uni.cas_fecha_registro)>=@_Fcini And (Bandeja_uni.cas_fecha_registro)<=@_Fcfin))"
            End If
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.VarChar, 20).Value = _Fcfin
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
    Public Function Consulta_611() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT V.preg1 as 'Etiquetas de fila', COUNT (V.preg1) as Respuestas,(Convert(real,((SELECT COUNT (V.preg1) as SI FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')*100))/(((SELECT COUNT (V.preg1) as SI FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')+ (SELECT COUNT (V.preg1) as NO FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')+(SELECT COUNT (V.preg1) as 'N/R' FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR')))) as Porcentaje_SI,(Convert(real,((SELECT COUNT (V.preg1) as SI FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR')*100))/(((SELECT COUNT (V.preg1) as SI FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')+(SELECT COUNT (V.preg1) as NO FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')+(SELECT COUNT (V.preg1) as 'N/R' FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR')))) as 'Porcentaje_N/R',(Convert(real,((SELECT COUNT (V.preg1) as SI FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')*100))/(((SELECT COUNT (V.preg1) as SI FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')+(SELECT COUNT (V.preg1) as NO FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')+(SELECT COUNT (V.preg1) as 'N/R' FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR')))) as Porcentaje_NO,((SELECT COUNT (V.preg1) as SI FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')+(SELECT COUNT (V.preg1) as NO FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')+(SELECT COUNT (V.preg1) as 'N/R' FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR'))As Total,'100,00%' As Porcentaje_Total FROM Bandeja_uni B INNER JOIN VCRMDetalle V ON B.idcaso = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' AND V.preg1 is not null AND V.preg1<>'null' group by preg1 order by V.preg1"
            cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 20).Value = _fcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 20).Value = _fcfin
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
    Public Function Consulta_611Datos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT V.preg1 as 'Etiquetas de fila', COUNT (V.preg1) as Respuestas,(Convert(real,((SELECT COUNT (V.preg1) as SI FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')*100))/(((SELECT COUNT (V.preg1) as SI FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')+ (SELECT COUNT (V.preg1) as NO FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')+(SELECT COUNT (V.preg1) as 'N/R' FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR')))) as Porcentaje_SI,(Convert(real,((SELECT COUNT (V.preg1) as SI FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR')*100))/(((SELECT COUNT (V.preg1) as SI FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')+(SELECT COUNT (V.preg1) as NO FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')+(SELECT COUNT (V.preg1) as 'N/R' FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR')))) as 'Porcentaje_N/R',(Convert(real,((SELECT COUNT (V.preg1) as SI FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')*100))/(((SELECT COUNT (V.preg1) as SI FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')+(SELECT COUNT (V.preg1) as NO FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')+(SELECT COUNT (V.preg1) as 'N/R' FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR')))) as Porcentaje_NO,((SELECT COUNT (V.preg1) as SI FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='SI')+(SELECT COUNT (V.preg1) as NO FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NO')+(SELECT COUNT (V.preg1) as 'N/R' FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' and preg1='NS/NR'))As Total,'100,00%' As Porcentaje_Total FROM Bandeja B INNER JOIN CRMDetalle V ON B.cas_id = V.idcaso WHERE V.fcreg>@strlfcini And V.fcreg<@strlfcfin AND V.preg1<>'0' AND V.preg1 is not null AND V.preg1<>'null' group by preg1 order by V.preg1"
            cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 20).Value = _fcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 20).Value = _fcfin
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

    Public Function Consulta_Nxmonitor_1() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where fcreg>'05/05/2014' and fcreg<'30/05/2014' group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg)"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Cantidad", SqlDbType.VarChar, 20).Value = _Cantidad
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

    Public Function Consulta_Nxmonitor_2() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)=@_Fcini and preg2 is not null group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg)"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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

    Public Function Inst_Nxmonitor_llamada() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)>=@_Fcini and preg2 is not null and preg3='OK' group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg) "
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
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

    Public Function Inst_Nx_Mon_otro_Momen() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)=@_Fcini and preg2 is not null and preg3='Informa  Instalar Nx Monitor en otro Momento' group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg) "
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
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

    Public Function No_le_interesa_instalar() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)=@_Fcini and preg2 is not null and preg3='No le interesa instalar' group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg) "
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
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

    Public Function Prefiere_qlo_llamen_despues() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)=@_Fcini and preg2 is not null and preg3='Prefiere que lo llamen despues para asesoria de instalacion' group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg) "
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
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

    Public Function Inst_Nxmonitor_otromomento() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)=@_Fcini and preg2 is not null and preg3='Informa  Instalar Nx Monitor en otro Momento' group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg) "
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
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

    Public Function ConsultaDianx() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)= @_Fcini group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg)"
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
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

    Public Function Otras_Causas() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)=@_Fcini and preg2 is not null and (preg3='Dispositivo Windows Phone' or preg3='Indica no verle utilidad'or preg3='Otras causas' or preg3='Indica que no le parece seguro el uso de herramientas de monitoreo' or preg3='No dispone de tiempo y no lo hará en otro momento' or preg3='No suministra información del correo por motivos de seguridad' or preg3='Rechaza el ofrecimiento sin dar explicación especifica' or preg3='Usuario no responde luego del envío del correo' or preg3='Usuario no tiene cuenta de correo configurada')  group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg) "
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Nx_Mon_Potenciales() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)=@_Fcini and preg2 is not null and (preg3='Informa  Instalar Nx Monitor en otro Momento' or preg3='Prefiere que lo llamen despues para asesoria de instalacion')  group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg) "
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dta.Fill(dts)
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Desviacion_meta_acumulada() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select top 2 Convert(date,fcreg) as fcreg,DATEPART(day,fcreg) as dia,COUNT(idcaso) as Cantidad from CRMDetalle where Convert(date,fcreg)>=@_Fcini and preg2 is not null and preg3='OK' group by Convert(date,fcreg),DATEPART(day,fcreg) order by DATEPART(day,fcreg)"
            cms.Parameters.Add("@_Fcini", SqlDbType.Date).Value = _Fcini
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
    Public Function ServicioCliente() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT B.cas_id, CR.fcreg, CR.obs, CR.tipificacion, B.ciudad, CR.tipo_soporte FROM Bandeja AS B INNER JOIN CRMDetalle AS CR ON B.cas_id = CR.idcaso WHERE (((B.ciudad) like '%" + _Ciudad + "%') AND ((CR.tipo_soporte)='Remision a Servicio Tecnico para verificacion fisica del equipo'))"
            cms.Parameters.Add("@_Ciudad", SqlDbType.VarChar, 20).Value = _Ciudad
            If _Fecha_Inicio <> Nothing Then
                cms.CommandText = "SELECT B.cas_id, CR.fcreg, CR.obs, CR.tipificacion, B.ciudad, CR.tipo_soporte FROM Bandeja AS B INNER JOIN CRMDetalle AS CR ON B.cas_id = CR.idcaso WHERE (((B.ciudad) like '%" + _Ciudad + "%') AND ((CR.tipo_soporte)='Remision a Servicio Tecnico para verificacion fisica del equipo')) and Convert(date,CR.fcreg)>= @_Fecha_Inicio"
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio
            End If
            If _Fecha_Fin <> Nothing Then
                cms.CommandText = "SELECT B.cas_id, CR.fcreg, CR.obs, CR.tipificacion, B.ciudad, CR.tipo_soporte FROM Bandeja AS B INNER JOIN CRMDetalle AS CR ON B.cas_id = CR.idcaso WHERE (((B.ciudad) like '%" + _Ciudad + "%') AND ((CR.tipo_soporte)='Remision a Servicio Tecnico para verificacion fisica del equipo')) and Convert(date,CR.fcreg)<= @_Fecha_Fin"
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin
            End If
            If _Fecha_Fin <> Nothing And _Fecha_Inicio <> Nothing Then
                cms.CommandText = "SELECT B.cas_id, CR.fcreg, CR.obs, CR.tipificacion, B.ciudad, CR.tipo_soporte FROM Bandeja AS B INNER JOIN CRMDetalle AS CR ON B.cas_id = CR.idcaso WHERE (((B.ciudad) like '%" + _Ciudad + "%') AND ((CR.tipo_soporte)='Remision a Servicio Tecnico para verificacion fisica del equipo')) and Convert(date,CR.fcreg)between @_Fecha_Inicio and @_Fecha_Fin"

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
    Public Function Consulta_InformeDatosBandeja() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select bandeja,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31]," +
"sum(isnull([1],0)+isnull([2],0)+isnull([3],0)+isnull([4],0)+isnull([5],0)+isnull([6],0)+isnull([7],0)+isnull([8],0)+isnull([9],0)+isnull([10],0)+isnull([11],0)+isnull([12],0)+" +
"isnull([13],0)+isnull([14],0)+isnull([15],0)+isnull([16],0)+isnull([17],0)+isnull([18],0)+isnull([19],0)+isnull([20],0)+isnull([21],0)+isnull([22],0)+isnull([23],0)+isnull([24],0)+" +
"isnull([25],0)+isnull([26],0)+isnull([27],0)+isnull([28],0)+isnull([29],0)+isnull([30],0)+isnull([31],0)) as total " +
"from (select DATEPART(DAY,fc_corta) as dia,bandeja,count(isnull(bandeja,0)) as total from bandeja where (fc_corta>=@_Fcini) and (fc_corta<=@_Fcfin) group by bandeja,fc_corta) as pvt " +
"pivot (max(total) for dia in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31])) " +
"as child group by bandeja,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31]"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.VarChar, 20).Value = _Fcfin
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
    Public Function Consulta_InformeDatosEstado() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select estado,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31] " +
"from (select DATEPART(DAY,fc_corta) as dia,estado,count(isnull(estado,0)) as total from bandeja where (fc_corta>=@_Fcini) and (fc_corta<=@_Fcfin) group by estado,fc_corta) as pvt " +
"pivot (max(total) for dia in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31])) " +
"as child group by estado,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31]"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.VarChar, 20).Value = _Fcfin
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
    Public Function Consulta_InformeVozBandeja() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select bandeja,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31]," +
"sum(isnull([1],0)+isnull([2],0)+isnull([3],0)+isnull([4],0)+isnull([5],0)+isnull([6],0)+isnull([7],0)+isnull([8],0)+isnull([9],0)+isnull([10],0)+isnull([11],0)+isnull([12],0)+" +
"isnull([13],0)+isnull([14],0)+isnull([15],0)+isnull([16],0)+isnull([17],0)+isnull([18],0)+isnull([19],0)+isnull([20],0)+isnull([21],0)+isnull([22],0)+isnull([23],0)+isnull([24],0)+" +
"isnull([25],0)+isnull([26],0)+isnull([27],0)+isnull([28],0)+isnull([29],0)+isnull([30],0)+isnull([31],0)) as total " +
"from (select DATEPART(DAY,fccorta) as dia,bandeja,count(isnull(bandeja,0)) as total from bandeja_uni where (fccorta>=@_Fcini) and (fccorta<=@_Fcfin) group by bandeja,fccorta) as pvt " +
"pivot (max(total) for dia in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31])) " +
"as child group by bandeja,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31]"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.VarChar, 20).Value = _Fcfin
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
    Public Function Consulta_InformeVozEstado() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select estado,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31] " +
"from (select DATEPART(DAY,fccorta) as dia,estado,count(isnull(estado,0)) as total from bandeja_uni where (fccorta>=@_Fcini) and (fccorta<=@_Fcfin) group by estado,fccorta) as pvt " +
"pivot (max(total) for dia in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31])) " +
"as child group by estado,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31]"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.VarChar, 20).Value = _Fcfin
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
    Public Sub Cunsulta_Informe_Barrios_Voz()
        Dim cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexion directa con la creada en la web.config
        Dim cms As New SqlClient.SqlCommand
        cn.Open()
        Try
            cms.CommandText = "insert into Data_Barrios_Semanal (Bandeja_uni.idcaso, Bandeja_uni.min_ac, ÚltimoDetipificacion, ÚltimoDeobs, ÚltimoDeidtipo, ÚltimoDeestado, ÚltimoDetipificacion1, ÚltimoDefcreg, VCRMDetalle.fallared, ÚltimoDecpd, ÚltimoDemunic, ÚltimoDeidbarrio) SELECT Bandeja_uni.idcaso, Bandeja_uni.min_ac, MAX(VCRMDetalle.tipificacion) AS ÚltimoDetipificacion, MAX(VCRMDetalle.obs) AS ÚltimoDeobs, MAX(VTiposoporte.idtipo) AS ÚltimoDeidtipo, MAX(Bandeja_uni.estado) AS ÚltimoDeestado, MAX(VTiposoporte.tipificacion) AS ÚltimoDetipificacion1, MAX(VCRMDetalle.fcreg) AS ÚltimoDefcreg, VCRMDetalle.fallared, MAX(VFallared.cpd) AS ÚltimoDecpd, MAX(Bandeja_uni.munic) AS ÚltimoDemunic, MAX(VCRMDetalle.idbarrio) AS ÚltimoDeidbarrio FROM ((Bandeja_uni INNER JOIN VCRMDetalle ON Bandeja_uni.idcaso = VCRMDetalle.idcaso) INNER JOIN VTiposoporte ON VCRMDetalle.tipificacion = VTiposoporte.tipifcrm) LEFT JOIN VFallared ON Bandeja_uni.idcaso = VFallared.idcaso WHERE (((Bandeja_uni.bandeja)='voz')) AND VTiposoporte.idtipo<>10 And VTiposoporte.idtipo<>17 AND Bandeja_uni.estado<>'RECHAZADO' And Bandeja_uni.estado<>'ILOCALIZABLE' AND Bandeja_uni.estado<>'GESTIONADO' AND VCRMDetalle.fcreg>=@_Fcini And VCRMDetalle.fcreg<=@_Fcfin AND VCRMDetalle.fallared Is Null GROUP BY Bandeja_uni.idcaso, Bandeja_uni.min_ac, VCRMDetalle.fallared ORDER BY Bandeja_uni.idcaso DESC"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.VarChar, 20).Value = _Fcfin
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

    Public Sub Inserta_Informe_Barrios_Voz()
        Dim cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexion directa con la creada en la web.config
        Dim cms As New SqlClient.SqlCommand
        cn.Open()
        Try
            If _Validacion = 1 Then
                cms.CommandText = "insert into Inf_barrios (DBS.idcaso, DBS.min_ac, DBS.ÚltimoDetipificacion, DBS.ÚltimoDeobs, DBS.ÚltimoDeidtipo, DBS.ÚltimoDeestado, DBS.ÚltimoDetipificacion1, DBS.ÚltimoDefcreg, DBS.fallared, DBS.ÚltimoDecpd, Divipola.nombremun, Barrio.barrio, Bandeja_voz.Tecnologia_Voz_01) select DBS.idcaso,DBS.min_ac, DBS.ÚltimoDetipificacion, DBS.ÚltimoDeobs, DBS.ÚltimoDeidtipo, DBS.ÚltimoDeestado, DBS.ÚltimoDetipificacion1, DBS.ÚltimoDefcreg, DBS.fallared, DBS.ÚltimoDecpd, Divipola.nombremun, Barrio.barrio, Bandeja_voz.Tecnologia_Voz_01 from Data_Barrios_Semanal DBS INNER JOIN Divipola ON DBS.ÚltimoDemunic = Divipola.coddiv INNER JOIN Barrio ON DBS.ÚltimoDeidbarrio = Barrio.idbarrio LEFT JOIN Bandeja_voz ON DBS.idcaso = Bandeja_voz.cas_id WHERE DBS.ÚltimoDefcreg>=@_Fcini And DBS.ÚltimoDefcreg<=@_Fcfin AND Divipola.nombremun='BOGOTÁ, D.C.'"
            End If
            If _Validacion = 2 Then
                cms.CommandText = "insert into Inf_Barrios_Final (Bandeja_voz.cas_fecha_registro, Inf_Barrios.idcaso, Inf_Barrios.nombremun, Inf_Barrios.barrio, Bandeja_voz.Tecnologia_Voz_01, Inf_Barrios.min_ac, Inf_Barrios.ÚltimoDetipificacion1, Inf_Barrios.ÚltimoDecpd) select Bandeja_voz.cas_fecha_registro, Inf_Barrios.idcaso, Inf_Barrios.nombremun, Inf_Barrios.barrio, Bandeja_voz.Tecnologia_Voz_01, Inf_Barrios.min_ac, Inf_Barrios.ÚltimoDetipificacion1, Inf_Barrios.ÚltimoDecpd from Bandeja_voz INNER JOIN Inf_Barrios ON Bandeja_voz.cas_id = Inf_Barrios.idcaso WHERE Inf_Barrios.barrio<>'centro internacional' And Inf_Barrios.barrio<>'can' And Inf_Barrios.barrio<>'mosquera' And Inf_Barrios.barrio<>'madrid' And Inf_Barrios.barrio<>'centro' And Inf_Barrios.barrio<>'ninguno' And Inf_Barrios.barrio<>'bogota' And Inf_Barrios.barrio<>'usaquen' And Inf_Barrios.barrio<>'santa fe' And Inf_Barrios.barrio<>'san cristobal' And Inf_Barrios.barrio<>'usme' And Inf_Barrios.barrio<>'tunjuelito' And Inf_Barrios.barrio<>'bosa' And Inf_Barrios.barrio<>'ciudad kennedy' And Inf_Barrios.barrio<>'kennedy' And Inf_Barrios.barrio<>'fontibon' And Inf_Barrios.barrio<>'engativa' And Inf_Barrios.barrio<>'suba' And Inf_Barrios.barrio<>'barrios unidos' And Inf_Barrios.barrio<>'teusaquillo' And Inf_Barrios.barrio<>'los martires' And Inf_Barrios.barrio<>'los mártires' And Inf_Barrios.barrio<>'antonio nariño' And Inf_Barrios.barrio<>'puente aranda' And Inf_Barrios.barrio<>'candelaria' And Inf_Barrios.barrio<>'rafael uribe' And Inf_Barrios.barrio<>'ciudad bolivar' And Inf_Barrios.barrio<>'sumapáz' And Inf_Barrios.barrio<>'sumapaz' And Inf_Barrios.barrio<>'sumapas' And Inf_Barrios.barrio<>'chia' And Inf_Barrios.barrio<>'bogotá' And Inf_Barrios.barrio<>'cajica' And Inf_Barrios.barrio<>'la calera' And Inf_Barrios.barrio<>'calera' And Inf_Barrios.barrio<>'colombia' And Inf_Barrios.barrio<>'no sabe' And Inf_Barrios.barrio<>'en cualquier lugar' And Inf_Barrios.barrio<>'en todas partes' And Inf_Barrios.barrio<>'gran america' And Inf_Barrios.barrio<>'llanogrande' And Inf_Barrios.barrio<>'cota' And Inf_Barrios.barrio<>'funza' And Inf_Barrios.barrio<>'funsa' And Inf_Barrios.barrio<>'fusa' And Inf_Barrios.barrio<>'fuza' And Inf_Barrios.barrio<>'fusagasuga' And Inf_Barrios.barrio<>'bello' And Inf_Barrios.barrio<>'- Seleccione -'"
            End If
            If _Validacion = 3 Then
                cms.CommandText = "UPDATE Inf_Barrios_Final SET Inf_Barrios_Final.Tecnologia_Voz_01 = '3G' WHERE Inf_Barrios_Final.Tecnologia_Voz_01 Like '%UMTS%' or Inf_Barrios_Final.Tecnologia_Voz_01 is null"
            End If
            If _Validacion = 4 Then
                cms.CommandText = "UPDATE Inf_Barrios_Final SET Inf_Barrios_Final.nombremun = 'Bogotá' WHERE Inf_Barrios_Final.nombremun='BOGOTÁ, D.C.'"
            End If
            If _Validacion = 5 Then
                cms.CommandText = "UPDATE Inf_Barrios_Final SET Inf_Barrios_Final.Tecnologia_Voz_01 = 'GSM' WHERE Inf_Barrios_Final.Tecnologia_Voz_01='2G GSM - EDGE'"
            End If
            If _Validacion = 6 Then
                cms.CommandText = "delete Data_Barrios_Semanal delete Inf_Barrios delete Inf_Barrios_Final"
            End If
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Fcfin", SqlDbType.VarChar, 20).Value = _Fcfin
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

    Public Function CuentaRegistros() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexion directa con la creada en la web.config
        cn.Open()
        Try
            cms.CommandText = "select * from Inf_Barrios_Final"
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
    Public Function Consulta_Cierre() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,Rellamada,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull(Rellamada,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull(Rellamada,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull(Rellamada,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull(Rellamada,0))))) as [Por] from (SELECT cas_id,fsap,fc_corta,b.estado,count(b.estado) as [total] FROM Bandeja b INNER JOIN Call c ON b.cas_id = c.contrato full join fecha_sap f on b.fc_corta = f.fcorta  " +
            "GROUP BY cas_id,fsap,fc_corta,b.estado, fc_corta, cas_fecha_registro, Bandeja, ingremite HAVING (((b.estado)<>'gestionado' And (b.estado)<>'seguimiento') AND ((cas_fecha_registro)>@_Fcini) " +
            "AND ((Bandeja)='datos') AND ((ingremite) Is Null) AND ((Count(contrato))>2))) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[Rellamada])) " +
            "as child group by fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,Rellamada"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Datos() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select  fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],programado,Rellamada,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0))))) as [Por] from (select fsap,fc_corta,estado,count(estado) as [total] from Bandeja b full join fecha_sap f on b.fc_corta = f.fcorta " +
            "where fc_corta>@_Fcini AND (Not (b.Bandeja) Is Null) group by fsap,fc_corta,estado) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No Disponible],[Programado]," +
            "[Rellamada])) as child group by fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],programado,Rellamada"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_4glte() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select  fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],programado,Rellamada,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0))))) as [Por] from (select fsap,fc_corta,estado,count(estado) as [total] from Bandeja b full join fecha_sap f on b.fc_corta = f.fcorta " +
            "where ((b.Bandeja)='4G LTE VOZ' Or (b.Bandeja)='4G LTE DATOS') AND ((b.ingremite) Is Null) AND fc_corta>@_Fcini group by fsap,fc_corta,estado) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado]," +
            "[Escalado],[Gestionado],[Ilocalizable],[No Disponible],[Programado],[Rellamada])) as child group by fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],programado,Rellamada"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_N3() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],programado,Seguimiento,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+ isnull([No Disponible],0)+isnull(programado,0)+isnull(Seguimiento,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(programado,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(programado,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+ isnull([No Disponible],0)+isnull(programado,0)+isnull(Seguimiento,0))))) as [Por] from (SELECT Fsap,fc_corta, Count(estado) AS [Total], estado FROM Bandeja b inner join Fecha_SAP f on b.fc_corta=f.Fcorta WHERE (((fc_corta)>@_Fcini) AND (Not (ingremite) Is Null))" +
            "GROUP BY Fsap,fc_corta, estado) as pvt PIVOT (max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No disponible],[programado],[Seguimiento])) as child group by fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],programado,Seguimiento"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Java() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],programado,Seguimiento,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+ isnull([No Disponible],0)+isnull(programado,0)+isnull(Seguimiento,0)) as [Tol]," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(programado,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2),(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(programado,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+" +
            "isnull(Gestionado,0)+isnull(Ilocalizable,0)+isnull([No Disponible],0)+isnull(programado,0)+isnull(Seguimiento,0))))) as [Por] from (SELECT Fsap,fc_corta, Count(estado) AS [Total],estado FROM Bandeja b inner join Fecha_SAP f on b.fc_corta=f.Fcorta WHERE (((Bandeja)='java' Or (Bandeja)='messenger') AND ((fc_corta)>@_Fcini))" +
            "GROUP BY Fsap,fc_corta,estado) as pvt PIVOT (max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No disponible],[programado],[Seguimiento])) as child group by fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],programado,Seguimiento"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Pqr() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],Rellamada,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Rellamada,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(Rellamada,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(Rellamada,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Rellamada,0))))) as [Por] from (select fsap,fc_corta,estado,count(estado) as [total] from Bandeja b full join fecha_sap f on b.fc_corta = f.fcorta " +
            "where ((b.Bandeja) like 'Datos -%') AND fc_corta>@_Fcini group by fsap,fc_corta,estado) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado]," +
            "[Ilocalizable],[No Disponible],[Rellamada])) as child group by fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],Rellamada"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_DPrepa() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select fsap,fc_corta,Abierto,cerrado,escalado,ilocalizable,[No Disponible],Programado,Rellamada,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)) as [Tol],(isnull(Abierto,0)+isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0))))) as [Por] from (select fsap,fc_corta,estado,count(estado) as [total] from Bandeja b full join fecha_sap f on b.fc_corta = f.fcorta " +
            "where b.tipo_clientesito='Prepago' and ((b.Bandeja)='Datos' or (b.estado)<>'Gestionado')  AND ((b.ingremite) Is Null) AND fc_corta>@_Fcini group by fsap,fc_corta,estado) as pvt pivot(max(total) for estado " +
            "in ([Abierto],[Cerrado],[Escalado],[Ilocalizable],[No Disponible],[Programado],[Rellamada])) as child group by fsap,fc_corta,Abierto,cerrado,escalado,ilocalizable,[No Disponible],Programado,Rellamada"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_DPospa() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select fsap,fc_corta,Abierto,cerrado,escalado,ilocalizable,[No Disponible],Programado,Rellamada,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)) as [Tol],(isnull(Abierto,0)+isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0)+isnull(Rellamada,0))))) as [Por] from (select fsap,fc_corta,estado,count(estado) as [total] from Bandeja b full join fecha_sap f on b.fc_corta = f.fcorta " +
            "where b.tipo_clientesito='Pospago' and ((b.Bandeja)='Datos' or (b.estado)<>'Gestionado') AND ((b.ingremite) Is Null) AND fc_corta>@_Fcini group by fsap,fc_corta,estado) as pvt pivot(max(total) for estado " +
            "in ([Abierto],[Cerrado],[Escalado],[Ilocalizable],[No Disponible],[Programado],[Rellamada])) as child group by fsap,fc_corta,Abierto,cerrado,escalado,ilocalizable,[No Disponible],Programado,Rellamada"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Empresa() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],Programado,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(Programado,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No Disponible],0)+isnull(Programado,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No Disponible],0)+isnull(Programado,0))))) as [Por] from (select fsap,fc_corta,estado,count(estado) as [total] from Bandeja b full join fecha_sap f on b.fc_corta = f.fcorta " +
            "where b.tipo_clientesito='Empresarial' and ((b.Bandeja)='Datos' or (b.estado)<>'Gestionado') AND ((b.ingremite) Is Null) AND fc_corta>@_Fcini group by fsap,fc_corta,estado) as pvt pivot(max(total) for estado " +
            "in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No Disponible],[Programado])) as child group by fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No Disponible],Programado"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_In() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,Rellamada,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull(Rellamada,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull(Rellamada,0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull(Rellamada,0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull(Rellamada,0))))) as [Por] from (select fsap,fc_corta,estado,count(estado) as [total] from Bandeja b full join fecha_sap f on b.fc_corta = f.fcorta where ((b.Bandeja)='inbound') " +
            "AND fc_corta>@_Fcini group by fsap,fc_corta,estado) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[Rellamada])) as child " +
            "group by fsap,fc_corta,Abierto,cerrado,escalado,gestionado,ilocalizable,Rellamada "
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_CosVoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0))))) as [Por] from (select f_sap,fccorta,estado,count(estado) as [total] from Bandeja_uni B FULL JOIN f_sap_v f on b.fccorta = f.f_corta " +
            "where fccorta>@_Fcini group by f_sap,fccorta,estado) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No disponible],[Rechazado])) " +
            "as child group by f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Voz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select f_sap,fccorta,bandeja,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0))))) as [Por] from (select f_sap,fccorta,estado,count(estado) as [total],bandeja from Bandeja_uni B FULL JOIN f_sap_v f on b.fccorta = f.f_corta " +
            "where fccorta>@_Fcini group by f_sap,fccorta,estado,bandeja) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No disponible],[Rechazado])) " +
            "as child group by f_sap,fccorta,bandeja,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Mensaje() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0))))) as [Por] from (select f_sap,fccorta,estado,count(estado) as [total] from Bandeja_uni B FULL JOIN f_sap_v f on b.fccorta = f.f_corta " +
            "where fccorta>@_Fcini and bandeja='Mensajes' group by f_sap,fccorta,estado) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable]," +
            "[No disponible],[Rechazado])) as child group by f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Buzon() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0))))) as [Por] from (select f_sap,fccorta,estado,count(estado) as [total] from Bandeja_uni B FULL JOIN f_sap_v f on b.fccorta = f.f_corta " +
            "where fccorta>@_Fcini and bandeja='Buzon' group by f_sap,fccorta,estado) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No disponible]," +
            "[Rechazado])) as child group by f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Otroserv() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0))))) as [Por] from (select f_sap,fccorta,estado,count(estado) as [total] from Bandeja_uni B FULL JOIN f_sap_v f on b.fccorta = f.f_corta " +
            "where fccorta>@_Fcini and bandeja='Otros Serv' group by f_sap,fccorta,estado) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable]," +
            "[No disponible],[Rechazado])) as child group by f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_LDIvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0))))) as [Por] from (select f_sap,fccorta,estado,count(estado) as [total] from Bandeja_uni B FULL JOIN f_sap_v f on b.fccorta = f.f_corta " +
            "where fccorta>@_Fcini and bandeja='Ldi' group by f_sap,fccorta,estado ) as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No disponible]," +
            "[Rechazado])) as child group by f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_BancaMovil() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0))))) as [Por] from (select f_sap,fccorta,estado,count(estado) as [total] from Bandeja_uni B FULL JOIN f_sap_v f on b.fccorta = f.f_corta " +
            "where fccorta>@_Fcini and ((bandeja)='BMF1' or (bandeja)='BMF2' or (bandeja)='BMF3') group by f_sap,fccorta,estado ) as pvt pivot(max(total) for estado in ([Abierto]," +
            "[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No disponible],[Rechazado])) as child group by f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Pqrvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select f_sap,fccorta,Abierto,cerrado,escalado,gestionado,ilocalizable,[No disponible],rechazado,(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0)) as [Tol],(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)) as [Pend],convert(decimal(30,2),(convert(decimal(30,2)," +
            "(isnull(Abierto,0)+isnull(Gestionado,0)+isnull([No disponible],0)))/convert(decimal(30,2),(isnull(Abierto,0)+isnull(Cerrado,0)+isnull(Escalado,0)+isnull(Gestionado,0)+isnull(Ilocalizable,0)+" +
            "isnull([No disponible],0)+isnull(Rechazado,0))))) as [Por] from (select f_sap,fccorta,estado, count(estado) as [total] from Bandeja_uni B FULL JOIN f_sap_v f on b.fccorta = f.f_corta " +
            "where fccorta>@_Fcini and ((bandeja)='Ldi-Error' or (bandeja)='Mensajeria' or (bandeja)='Voz-Buzon' or (bandeja)='Voz-Llama' or (bandeja)='Voz-Otros') group by f_sap,fccorta,estado) " +
            "as pvt pivot(max(total) for estado in ([Abierto],[Cerrado],[Escalado],[Gestionado],[Ilocalizable],[No disponible],[Rechazado])) as child group by f_sap,fccorta,Abierto,cerrado,escalado," +
            "gestionado,ilocalizable,[No disponible],rechazado"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Casges() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT CONVERT(date,c.fcregistro) as fecha,r.nombre,r.registros,count(c.lista) as llamadas FROM Resumen_lista r full join call c on r.lista=c.lista where CONVERT(date,c.fcregistro)>= @_Fcini and c.estado = 'Success' group by CONVERT(date,c.fcregistro),r.nombre,r.registros order by CONVERT(date,c.fcregistro)"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Casres() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select CONVERT(date,c.fcregistro) as fecha,r.nombre,r.registros,count(c.lista) as llamadas from Bandeja b full join call c on b.cas_fecha_registro=c.fcregistro full join Resumen_lista r on c.lista = r.lista where CONVERT(date,c.fcregistro)>=@_Fcini group by CONVERT(date,c.fcregistro),r.nombre,r.registros having count(min_ac)>=2"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Cas4g() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select CONVERT(date,c.fcregistro) as fecha,r.nombre,r.registros,count(c.lista) as llamadas from Bandeja b full join call c on b.cas_fecha_registro=c.fcregistro full join Resumen_lista r on c.lista = r.lista where Bandeja like '4G%' and CONVERT(date,c.fcregistro)>=@_Fcini group by CONVERT(date,c.fcregistro),r.nombre,r.registros having count(min_ac)>=2"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Casda() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select r.lista,r.nombre,r.registros,r.campana,Cola,CONVERT(date,c.fcregistro) as fecha,RIGHT(CONVERT(VARCHAR(30), c.fcregistro, 9), 2) as horario, count(c.lista) as llamadas from Bandeja b full join call c on b.cas_fecha_registro=c.fcregistro full join Resumen_lista r on c.lista = r.lista where CONVERT(date,c.fcregistro)>=@_Fcini and Cola=@_Cola and CONVERT(VARCHAR, c.fcregistro,108)<='14:00:00' group by r.lista,r.nombre,r.registros,r.campana,Cola,CONVERT(date,c.fcregistro),RIGHT(CONVERT(VARCHAR(30), c.fcregistro, 9), 2)"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Cola", SqlDbType.VarChar, 20).Value = _Cola
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
    Public Function Consulta_Casda2() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select r.lista,r.nombre,r.registros,r.campana,Cola,CONVERT(date,c.fcregistro) as fecha,RIGHT(CONVERT(VARCHAR(30), c.fcregistro, 9), 2) as horario, count(c.lista) as llamadas from Bandeja b full join call c on b.cas_fecha_registro=c.fcregistro full join Resumen_lista r on c.lista = r.lista where CONVERT(date,c.fcregistro)>=@_Fcini  and Cola=@_Cola and CONVERT(VARCHAR, c.fcregistro,108)>='14:00:00' group by r.lista,r.nombre,r.registros,r.campana,Cola,CONVERT(date,c.fcregistro),RIGHT(CONVERT(VARCHAR(30), c.fcregistro, 9), 2)"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Cola", SqlDbType.VarChar, 20).Value = _Cola
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
    Public Function Consulta_Casgesvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT CONVERT(date,c.fcregistro) as fecha,r.nombre,r.registros,count(c.lista) as llamadas FROM Resumen_listavoz r full join call c on r.lista=c.lista where CONVERT(date,c.fcregistro)>=@_Fcini and c.estado = 'Success' group by CONVERT(date,c.fcregistro),r.nombre,r.registros order by CONVERT(date,c.fcregistro)"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Casresvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select CONVERT(date,c.fcregistro) as fecha,r.nombre,r.registros,count(c.lista) as llamadas from Bandeja_uni b full join call c on b.cas_fecha_registro=c.fcregistro full join Resumen_listavoz r on c.lista = r.lista where CONVERT(date,c.fcregistro)>=@_Fcini group by CONVERT(date,c.fcregistro),r.nombre,r.registros having count(min_ac)>=2"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
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
    Public Function Consulta_Casdavoz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select r.lista,r.nombre,r.registros,r.campana,Cola,CONVERT(date,c.fcregistro) as fecha,RIGHT(CONVERT(VARCHAR(30), c.fcregistro, 9), 2) as horario, count(c.lista) as llamadas from Bandeja_uni b full join call c on b.cas_fecha_registro=c.fcregistro full join Resumen_listavoz r on c.lista = r.lista where CONVERT(date,c.fcregistro)>=@_Fcini and Cola=@_Cola and CONVERT(VARCHAR, c.fcregistro,108)<='14:00:00' group by r.lista,r.nombre,r.registros,r.campana,Cola,CONVERT(date,c.fcregistro),RIGHT(CONVERT(VARCHAR(30), c.fcregistro, 9), 2)"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Cola", SqlDbType.VarChar, 20).Value = _Cola
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
    Public Function Consulta_Casda2voz() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "select r.lista,r.nombre,r.registros,r.campana,Cola,CONVERT(date,c.fcregistro) as fecha,RIGHT(CONVERT(VARCHAR(30), c.fcregistro, 9), 2) as horario, count(c.lista) as llamadas from Bandeja_uni b full join call c on b.cas_fecha_registro=c.fcregistro full join Resumen_listavoz r on c.lista = r.lista where CONVERT(date,c.fcregistro)>=@_Fcini and Cola=@_Cola and CONVERT(VARCHAR, c.fcregistro,108)>='14:00:00' group by r.lista,r.nombre,r.registros,r.campana,Cola,CONVERT(date,c.fcregistro),RIGHT(CONVERT(VARCHAR(30), c.fcregistro, 9), 2)"
            cms.Parameters.Add("@_Fcini", SqlDbType.VarChar, 20).Value = _Fcini
            cms.Parameters.Add("@_Cola", SqlDbType.VarChar, 20).Value = _Cola
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
    Public Function FallaVozN() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Validacion = 1 Then
                cms.CommandText = "select top 5 tipoinc,count(tipoinc) as total from bandeja_uni where convert(date,cas_fecha_registro) between  @_Fecha_Inicio and @_Fecha_Fin group by tipoinc order by total  desc"
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin
            End If
            If _Validacion = 2 Then
                cms.CommandText = "Select fecha  as Semana,[" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "] from ( Select count(tipoinc) as Cantidad,tipoinc,Convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),0))) ))+' - '+convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),6))) )) as fecha from Bandeja_uni  where Convert(date,cas_fecha_registro) between @_fcini and @_fcfin and tipoinc is not null group by  tipoinc,Convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),0))) )),convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),6))) ))) as DataSource pivot(MAX(Cantidad) for tipoinc in ([" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "] )) as DataPivot order by semana"
                cms.Parameters.Add("@_fcini", SqlDbType.VarChar, 20).Value = _fcini
                cms.Parameters.Add("@_fcfin", SqlDbType.VarChar, 20).Value = _fcfin
                cms.Parameters.Add("@F1", SqlDbType.VarChar, 200).Value = _F1
                cms.Parameters.Add("@F2", SqlDbType.VarChar, 200).Value = _F2
                cms.Parameters.Add("@F3", SqlDbType.VarChar, 200).Value = _F3
                cms.Parameters.Add("@F4", SqlDbType.VarChar, 200).Value = _F4
                cms.Parameters.Add("@F5", SqlDbType.VarChar, 200).Value = _F5
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
    Public Function FallaVozNi() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _fcini <> Nothing Then
                cms.CommandText = "select top 5 tipoinc,count(tipoinc) as total from bandeja_uni where convert(date,cas_fecha_registro)>= @_fcini  group by tipoinc order by total  desc"
                cms.Parameters.Add("@_fcini", SqlDbType.Date).Value = _fcini
            End If
            If _fcfin <> Nothing Then
                cms.CommandText = "select top 5 tipoinc,count(tipoinc) as total from bandeja_uni where convert(date,cas_fecha_registro)<=@_fcfin group by tipoinc order by total  desc"
                cms.Parameters.Add("@_fcfin", SqlDbType.Date).Value = _fcfin
            End If
            If _fcini <> Nothing And _fcfin <> Nothing Then
                cms.CommandText = "select top 5 tipoinc,count(tipoinc) as total from bandeja_uni where convert(date,cas_fecha_registro) between  @_fcini and @_fcfin group by tipoinc order by total  desc"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("tipoinc") Is DBNull.Value Then
                    _F1 = ""
                Else
                    _F1 = dts.Tables(0).Rows(0).Item("tipoinc")
                End If
                If dts.Tables(0).Rows(1).Item("tipoinc") Is DBNull.Value Then
                    _F2 = ""
                Else
                    _F2 = dts.Tables(0).Rows(1).Item("tipoinc")
                End If
                If dts.Tables(0).Rows(2).Item("tipoinc") Is DBNull.Value Then
                    _F3 = ""
                Else
                    _F3 = dts.Tables(0).Rows(2).Item("tipoinc")
                End If
                If dts.Tables(0).Rows(3).Item("tipoinc") Is DBNull.Value Then
                    _F4 = ""
                Else
                    _F4 = dts.Tables(0).Rows(3).Item("tipoinc")
                End If
                If dts.Tables(0).Rows(4).Item("tipoinc") Is DBNull.Value Then
                    _F5 = ""
                Else
                    _F5 = dts.Tables(0).Rows(4).Item("tipoinc")
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
    Public Function FallaVozNu() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = 1 Then
                If _fcini <> Nothing Then
                    cms.CommandText = "Select fecha  as Semana,[" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "] from ( Select count(tipoinc) as Cantidad,tipoinc,Convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),0))) ))+' - '+convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),6))) )) as fecha from Bandeja_uni  where Convert(date,cas_fecha_registro) >= @_fcini and tipoinc is not null group by  tipoinc,Convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),0))) )),convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),6))) ))) as DataSource pivot(MAX(Cantidad) for tipoinc in ([" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "] )) as DataPivot order by semana"
                    cms.Parameters.Add("@_fcini", SqlDbType.VarChar, 20).Value = _fcini
                End If
                If _fcfin <> Nothing Then
                    cms.CommandText = "Select fecha  as Semana,[" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "] from ( Select count(tipoinc) as Cantidad,tipoinc,Convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),0))) ))+' - '+convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),6))) )) as fecha from Bandeja_uni  where Convert(date,cas_fecha_registro) <= @_fcfin and tipoinc is not null group by  tipoinc,Convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),0))) )),convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),6))) ))) as DataSource pivot(MAX(Cantidad) for tipoinc in ([" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "] )) as DataPivot order by semana"
                    cms.Parameters.Add("@_fcfin", SqlDbType.VarChar, 20).Value = _fcfin
                End If
                If _fcini <> Nothing And _fcfin <> Nothing Then
                    cms.CommandText = "Select fecha  as Semana,[" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "] from ( Select count(tipoinc) as Cantidad,tipoinc,Convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),0))) ))+' - '+convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),6))) )) as fecha from Bandeja_uni  where Convert(date,cas_fecha_registro) between @_fcini and @_fcfin and tipoinc is not null group by  tipoinc,Convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),0))) )),convert(varchar(20),(convert(date,(DATEADD(wk,DATEDIFF(wk,0,cas_fecha_registro),6))) ))) as DataSource pivot(MAX(Cantidad) for tipoinc in ([" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "] )) as DataPivot order by semana"
                End If
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
    Public Function FallaMasiva() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = 1 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso  where  B.otro_cual like '%" + _Otro + "%'"
                cms.Parameters.Add("@_Otro", SqlDbType.VarChar, 50).Value = _Otro
            End If
            If _Validacion = 2 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso  where  B.departamento_falla like '%" + _Depar + "%' "
                cms.Parameters.Add("@_Depar", SqlDbType.VarChar, 50).Value = _Depar
            End If
            If _Validacion = 3 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso  where  B.departamento_falla like '%" + _Depar + "%' and B.otro_cual like '%" + _Otro + "%'"
                cms.Parameters.Add("@_Otro", SqlDbType.VarChar, 50).Value = _Otro
                cms.Parameters.Add("@_Depar", SqlDbType.VarChar, 50).Value = _Depar
            End If
            If _Validacion = 4 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso where Convert(date,B.cas_fecha_registro) <= @_Fecha_Fin  and  B.departamento_falla like '%" + _Depar + "%' and B.otro_cual like '%" + _Otro + "%'"
                cms.Parameters.Add("@_Otro", SqlDbType.VarChar, 50).Value = _Otro
                cms.Parameters.Add("@_Depar", SqlDbType.VarChar, 50).Value = _Depar
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin
            End If
            If _Validacion = 5 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso where Convert(date,B.cas_fecha_registro) >= @_Fecha_Inicio  and  B.departamento_falla like '%" + _Depar + "%' and B.otro_cual like '%" + _Otro + "%'"
                cms.Parameters.Add("@_Otro", SqlDbType.VarChar, 50).Value = _Otro
                cms.Parameters.Add("@_Depar", SqlDbType.VarChar, 50).Value = _Depar
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio
            End If
            If _Validacion = 6 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso where B.cas_fecha_registro between @_Fecha_Inicio and @_Fecha_Fin and  B.departamento_falla like '%" + _Depar + "%' and B.otro_cual like '%" + _Otro + "%'"
                cms.Parameters.Add("@_Otro", SqlDbType.VarChar, 50).Value = _Otro
                cms.Parameters.Add("@_Depar", SqlDbType.VarChar, 50).Value = _Depar
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin
            End If
            If _Validacion = 7 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso where Convert(date,B.cas_fecha_registro) <= @_Fecha_Fin  and  B.departamento_falla like '%" + _Depar + "%' "
                cms.Parameters.Add("@_Depar", SqlDbType.VarChar, 50).Value = _Depar
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin
            End If
            If _Validacion = 8 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso  where Convert(date,B.cas_fecha_registro) >= @_Fecha_Inicio  and  B.departamento_falla like '%" + _Depar + "%' "
                cms.Parameters.Add("@_Depar", SqlDbType.VarChar, 50).Value = _Depar
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio
            End If
            If _Validacion = 9 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso where B.cas_fecha_registro between @_Fecha_Inicio and @_Fecha_Fin and  B.departamento_falla like '%" + _Depar + "%' "
                cms.Parameters.Add("@_Depar", SqlDbType.VarChar, 50).Value = _Depar
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin
            End If
            If _Validacion = 10 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso where Convert(date,B.cas_fecha_registro) <= @_Fecha_Fin  and  B.otro_cual like '%" + _Otro + "%' "
                cms.Parameters.Add("@_Otro", SqlDbType.VarChar, 50).Value = _Otro
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin
            End If
            If _Validacion = 11 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso where Convert(date,B.cas_fecha_registro) >= @_Fecha_Inicio  and  B.otro_cual like '%" + _Otro + "%' "
                cms.Parameters.Add("@_Otro", SqlDbType.VarChar, 50).Value = _Otro
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio
            End If
            If _Validacion = 12 Then
                cms.CommandText = "select B.cas_id,Convert(date,B.cas_fecha_registro) as cas_fecha_registro,B.cas_observaciones,B.min_ac,B.nom_cliente,B.no_documento,B.equipo_ac,B.otro_cual,B.departamento_falla,B.ciudad,B.estado,B.falla_desde_cuando,VF.CPD,VF.estadocpd,VF.obscpd  from Bandeja B inner join clarovoz.dbo.VFallared VF on B.cas_id = VF.idcaso where B.cas_fecha_registro between @_Fecha_Inicio and @_Fecha_Fin and  B.otro_cual like '%" + _Otro + "%' "
                cms.Parameters.Add("@_Otro", SqlDbType.VarChar, 50).Value = _Otro
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin
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
    Public Function Campañadatos() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            If _Validacion = 0 Then

                cms.CommandText = "select convert(date,Fecha_Sap) as Fecha_Sap,convert(date,Fecha_Corta) as Fecha_Corta,isnull([Abierto],0) as [Abierto],isnull([Cerrado],0) as [Cerrado],isnull([Escalado],0) as [Escalado],isnull([Gestionado],0) as [Gestionado],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([No Contactado],0) as [No Contactado],isnull([Programado],0) as [Programado],isnull([Rechazado],0) as [Rechazado],isnull([No Corresponde],0) as [No Corresponde],isnull([Reasignación],0) as [Reasignación],isnull([Seguimiento],0) as [Seguimiento],isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Rechazado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([No Corresponde],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Contactado],0)+isnull([Seguimiento],0) as Total,isnull([abierto],0)+isnull([No Contactado],0)+isnull([Rechazado],0)+isnull([Programado],0) as Pendientes,convert(nvarchar,convert(decimal,(convert(decimal(10,2),isnull([abierto],0)+isnull([Rechazado],0)+isnull([No Contactado],0)+isnull([Programado],0)+isnull([No Corresponde],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([No Corresponde],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Contactado],0)+isnull([Seguimiento],0))) * 100)) as Porcentaje from(SELECT convert(date,F.Fsap) as Fecha_Sap, convert(date,B.fc_corta) as Fecha_Corta, Count(B.cas_id) AS [Total],B.estado as estados FROM Bandeja B INNER JOIN Fecha_SAP F ON B.fc_corta = F.Fcorta WHERE convert(date,B.fc_corta)BETWEEN @_Fcorta AND @_Fsap GROUP BY F.Fsap, B.fc_corta,B.estado)as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[Escalado],[Abierto],[Cerrado],[No Corresponde],[Programado],[Rechazado],[Reasignación],[No Contactado],[Seguimiento],[Gestionado])) as datapivot order by Fecha_Sap"

                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap

                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta

            End If

            If _Validacion = 1 Then

                cms.CommandText = "select Fecha_Sap,Fecha_Corta,isnull([Abierto],0) as [Abierto],isnull([Cerrado],0) as [Cerrado],isnull([Escalado],0) as [Escalado],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([No Disponible],0) as [No Disponible],isnull([Programado],0) as [Programado],isnull([Rechazado],0) as [Rechazado],isnull([Rellamada],0) as [Rellamada],isnull([Reasignación],0) as [Reasignación],isnull([Seguimiento],0) as [Seguimiento], isnull([ILOCALIZABLE],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Rechazado],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0) as Total, isnull([abierto],0) +isnull([No Disponible],0)+isnull([Programado],0)+isnull([Rellamada],0)+isnull([Rechazado],0) as Pendientes, convert(nvarchar,convert(decimal,(convert(decimal(10,2),isnull([abierto],0) +isnull([No Disponible],0)+isnull([Programado],0)+isnull([Rellamada],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0))) * 100))  as Porcentaje from( SELECT F.Fsap as Fecha_Sap, B.fc_corta as Fecha_Corta, Count(B.cas_id) AS [Total],B.estado as estados FROM Bandeja B INNER JOIN Fecha_SAP F ON B.fc_corta = F.Fcorta WHERE ((B.Bandeja)='DATOS') AND (B.estado)<>'gestionado' AND ((B.tipo_clientesito)=@_Cliente) AND B.ingremite Is Null AND convert(date,B.fc_corta)BETWEEN @_Fcorta AND @_Fsap GROUP BY F.Fsap, B.fc_corta,B.estado )as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[Escalado],[Abierto],[Cerrado],[Rellamada],[Rechazado],[Programado],[Reasignación],[No Disponible],[Seguimiento])) as datapivot order by Fecha_Sap "

                cms.Parameters.Add("@_Cliente", SqlDbType.VarChar, 20).Value = _Cliente

                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap

                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta

            End If

            If _Validacion = 2 Then

                cms.CommandText = "select Fecha_Sap,Fecha_Corta,isnull([Abierto],0) as [Abierto],isnull([Cerrado],0) as [Cerrado],isnull([Escalado],0) as [Escalado],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([No Disponible],0) as [No Disponible],isnull([Programado],0) as [Programado],isnull([Rechazado],0) as [Rechazado],isnull([Rellamada],0) as [Rellamada],isnull([Reasignación],0) as [Reasignación],isnull([Seguimiento],0) as [Seguimiento],isnull([ILOCALIZABLE],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Rechazado],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0) as Total,isnull([abierto],0) +isnull([No Disponible],0)+isnull([Programado],0)+isnull([Rellamada],0)+isnull([Rechazado],0) as Pendientes,convert(nvarchar,convert(decimal,(convert(decimal(10,2),isnull([abierto],0) +isnull([No Disponible],0)+isnull([Programado],0)+isnull([Rellamada],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0))) * 100)) as Porcentaje from( SELECT F.Fsap as Fecha_Sap, B.fc_corta as Fecha_Corta, Count(B.cas_id) AS [Total],estado as estados FROM Bandeja B INNER JOIN Fecha_SAP F ON B.fc_corta = F.Fcorta WHERE (((B.Bandeja)='datos') AND (convert(date,B.fc_corta)BETWEEN @_Fcorta AND @_Fsap) AND ((B.tipo_clientesito)=@_Cliente Or (B.tipo_clientesito)='corporativo') AND ((B.ingremite) Is Null)) GROUP BY F.Fsap, B.fc_corta, B.tipo_clientesito, B.ingremite,B.estado)as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[Escalado],[Abierto],[Cerrado],[Rellamada],[Rechazado],[Programado],[Reasignación],[No Disponible],[Seguimiento])) as datapivot order by Fecha_Corta"

                cms.Parameters.Add("@_Cliente", SqlDbType.VarChar, 20).Value = _Cliente

                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap

                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta

            End If

            If _Validacion = 3 Then

                cms.CommandText = "select Fecha_Sap,Fecha_Corta,isnull([Cerrado],0) as [Cerrado],isnull([Escalado],0) as [Escalado],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([No Disponible],0) as [No Disponible],isnull([Programado],0) as [Programado],isnull([Rechazado],0) as [Rechazado],isnull([Rellamada],0) as [Rellamada],isnull([Reasignación],0) as [Reasignación], isnull([ILOCALIZABLE],0)+isnull([Escalado],0)+isnull([Rechazado],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0) as Total, (isnull([Rellamada],0)+isnull([Programado],0)+isnull([No Disponible],0)+isnull([Rechazado],0)) as Pendientes, convert(nvarchar,convert(decimal,(convert(decimal(10,2),isnull([Rechazado],0) +isnull([No Disponible],0)+isnull([Programado],0)+isnull([Rellamada],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([Escalado],0)+isnull([Rechazado],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0))) * 100)) as Porcentaje from( SELECT F.Fsap as Fecha_Sap, B.fc_corta as Fecha_Corta, B.estado as estados from Bandeja B inner join call C  on B.cas_id = C.contrato inner join Fecha_SAP F on B.fc_corta = F.Fcorta Group by B.estado,B.cas_fecha_registro,b.ingremite,B.Bandeja,B.cas_id,B.fc_corta,f.Fsap Having (B.estado <> 'gestionado' and B.estado <> 'seguimiento') and convert(date,B.cas_fecha_registro)BETWEEN @_Fcorta AND @_Fsap and B.Bandeja='datos' and B.ingremite is null and count(C.contrato)>'2')as dataSource pivot (count(estados) for estados in ([ILOCALIZABLE],[Escalado],[Cerrado],[Rellamada],[Rechazado],[Programado],[Reasignación],[No Disponible])) as datapivot order by Fecha_Corta"

                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta

                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap

            End If

            If _Validacion = 4 Then

                cms.CommandText = "select convert(date,Fecha_Sap) as Fecha_Sap,convert(date,Fecha_Corta) as Fecha_Corta,isnull([Abierto],0) as [Abierto],isnull([Cerrado],0) as [Cerrado],isnull([Escalado],0) as [Escalado],isnull([Gestionado],0) as [Gestionado],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([No Disponible],0) as [No Disponible],isnull([Programado],0) as [Programado],isnull([Rechazado],0) as [Rechazado],isnull([Rellamada],0) as [Rellamada],isnull([Reasignación],0) as [Reasignación],isnull([Seguimiento],0) as [Seguimiento],isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Rechazado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0) as Total,isnull([abierto],0) +isnull([No Disponible],0)+isnull([Rechazado],0)+isnull([Programado],0)+isnull([Rellamada],0) as Pendientes, convert(nvarchar,convert(decimal,(convert(decimal(10,2),isnull([abierto],0) +isnull([Rechazado],0)+isnull([No Disponible],0)+isnull([Programado],0)+isnull([Rellamada],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0))) * 100)) as Porcentaje from( SELECT F.Fsap as Fecha_Sap, B.fc_corta as Fecha_Corta, Count(B.cas_id) AS [Total],estado as estados FROM Bandeja B INNER JOIN Fecha_SAP F ON B.fc_corta = F.Fcorta  WHERE (((B.Bandeja)='4G LTE VOZ' Or (B.Bandeja)='4G LTE DATOS') AND (convert(date,B.fc_corta)BETWEEN @_Fcorta AND @_Fsap) AND ((B.ingremite) Is Null)) GROUP BY F.Fsap, B.fc_corta,estado )as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[Escalado],[Abierto],[Cerrado],[Rellamada],[Programado],[Rechazado],[Reasignación],[No Disponible],[Seguimiento],[Gestionado])) as datapivot order by Fecha_Corta"

                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta

                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap

            End If

            If _Validacion = 5 Then

                cms.CommandText = "Select * from nivel3"

            End If

            If _Validacion = 6 Then

                cms.CommandText = "select convert(date,Fecha_Sap) as Fecha_Sap,convert(date,Fecha_Corta) as Fecha_Corta,isnull([Abierto],0) as [Abierto],isnull([Cerrado],0) as [Cerrado],isnull([Escalado],0) as [Escalado],isnull([Gestionado],0) as [Gestionado],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([No Disponible],0) as [No Disponible],isnull([Programado],0) as [Programado],isnull([Rechazado],0) as [Rechazado],isnull([Rellamada],0) as [Rellamada],isnull([Reasignación],0) as [Reasignación],isnull([Seguimiento],0) as [Seguimiento],isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Rechazado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0) as Total, isnull([abierto],0) +isnull([No Disponible],0)+isnull([Rechazado],0)+isnull([Programado],0)+isnull([Rellamada],0) as Pendientes, convert(decimal,(convert(decimal(10,2),isnull([abierto],0) +isnull([Rechazado],0)+isnull([No Disponible],0)+isnull([Programado],0)+isnull([Rellamada],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0))) * 100) as Porcentaje from( SELECT F.Fsap as Fecha_Sap, B.fc_corta as Fecha_Corta, Count(B.cas_id) AS [Total], estado as estados FROM Bandeja B INNER JOIN Fecha_SAP F ON B.fc_corta = F.Fcorta WHERE ((convert(date,B.fc_corta)BETWEEN @_Fcorta AND @_Fsap) AND ((B.Bandeja) Like '%datos -%')) GROUP BY F.Fsap, B.fc_corta,estado )as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[Escalado],[Abierto],[Cerrado],[Rellamada],[Programado],[Rechazado],[Reasignación],[No Disponible],[Seguimiento],[Gestionado])) as datapivot order by Fecha_Sap "

                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta

                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap

            End If

            If _Validacion = 7 Then

                cms.CommandText = "select convert(date,Fecha_Sap) as Fecha_Sap,convert(date,Fecha_Corta) as Fecha_Corta,isnull([Abierto],0) as [Abierto],isnull([Cerrado],0) as [Cerrado],isnull([Escalado],0) as [Escalado],isnull([Gestionado],0) as [Gestionado],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([No Disponible],0) as [No Disponible],isnull([Programado],0) as [Programado],isnull([Rechazado],0) as [Rechazado],isnull([Rellamada],0) as [Rellamada],isnull([Reasignación],0) as [Reasignación],isnull([Seguimiento],0) as [Seguimiento],isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Rechazado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0) as Total,isnull([abierto],0) +isnull([No Disponible],0)+isnull([Rechazado],0)+isnull([Programado],0)+isnull([Rellamada],0) as Pendientes,convert(decimal,(convert(decimal(10,2),isnull([abierto],0) +isnull([Rechazado],0)+isnull([No Disponible],0)+isnull([Programado],0)+isnull([Rellamada],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0))) * 100) as Porcentaje from(SELECT F.Fsap as Fecha_Sap, B.fc_corta as Fecha_Corta, Count(B.cas_id) AS [Total], B.estado as estados FROM Bandeja B INNER JOIN Fecha_SAP F ON B.fc_corta = F.Fcorta WHERE ((convert(date,B.fc_corta)BETWEEN @_Fcorta AND @_Fsap) AND ((B.Bandeja)='inbound' Or (B.Bandeja) Is Null))GROUP BY F.Fsap, B.fc_corta, estado)as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[Escalado],[Abierto],[Cerrado],[Rellamada],[Programado],[Rechazado],[Reasignación],[No Disponible],[Seguimiento],[Gestionado])) as datapivot order by Fecha_Sap "

                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta

                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap

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

    Public Sub ActualizarNivel3()

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim cms As New SqlClient.SqlCommand

        cn.Open()

        Try

            If _Validacion = 0 Then

                cms.CommandText = "insert into Nivel3 select Fecha_Sap,Fecha_Corta,isnull([Abierto],0) as [Abierto],isnull([Cerrado],0) as [Cerrado],isnull([Escalado],0) as [Escalado],isnull([Gestionado],0) as [Gestionado],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([No Disponible],0)+isnull([Rellamada],0)+isnull([Rechazado],0) as [No Disponible],isnull([Programado],0) as [Programado],isnull([Reasignación],0) as [Reasignación],isnull([Seguimiento],0) as [Seguimiento],isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0) as Total ,isnull([abierto],0) +isnull([No Disponible],0)+isnull([Rechazado],0)+isnull([Programado],0)+isnull([Rellamada],0)+isnull([Gestionado],0) as Pendientes,convert(nvarchar,convert(decimal,(convert(decimal(10,2),isnull([abierto],0) +isnull([No Disponible],0)+isnull([Rechazado],0)+isnull([Programado],0)+isnull([Rellamada],0)+isnull([Gestionado],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([Gestionado],0)+isnull([Escalado],0)+isnull([Abierto],0)+isnull([Cerrado],0)+isnull([Rellamada],0)+isnull([Programado],0)+isnull([Reasignación],0)+isnull([No Disponible],0)+isnull([Seguimiento],0))) * 100)) as Porcentaje from(SELECT F.Fsap as Fecha_Sap,B.fc_corta as Fecha_Corta, Count(B.cas_id) AS [Total],estado as estados FROM Bandeja B INNER JOIN Fecha_SAP F ON B.fc_corta = F.Fcorta WHERE ((convert(date,B.fc_corta)BETWEEN @_Fcorta AND @_Fsap) AND (Not (B.ingremite) Is Null))      GROUP BY F.Fsap, B.fc_corta, B.estado )as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[Escalado],[Abierto],[Cerrado],[Rellamada],[Rechazado],[Programado],[Reasignación],[No Disponible],[Seguimiento],[Gestionado])) as datapivot order by Fecha_Sap "

                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta

                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap

            End If

            If _Validacion = 1 Then

                cms.CommandText = "delete Nivel3"

            End If

            If _Validacion = 2 Then

                cms.CommandText = "update nivel3 set Abierto =(Select count(B.cas_id) as casos from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Abierto' and nivel3.Fecha_Corta = B.fc_corta )+Abierto where Convert(date,Fecha_Corta) in (Select convert(date,fc_corta)   from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Abierto' )"

            End If

            If _Validacion = 3 Then

                cms.CommandText = "update nivel3 set Cerrado =(Select count(B.cas_id) as casos from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Cerrado' and nivel3.Fecha_Corta = B.fc_corta )+Cerrado where Convert(date,Fecha_Corta) in (Select convert(date,fc_corta)   from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Cerrado' )"

            End If

            If _Validacion = 4 Then

                cms.CommandText = "update nivel3 set Escalado =(Select count(B.cas_id) as casos from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Escalado' and convert(date,nivel3.Fecha_Corta) = convert(date,B.fc_corta ))+Escalado where Convert(date,Fecha_Corta) in (Select convert(date,fc_corta)   from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Escalado' )"
            End If

            If _Validacion = 5 Then

                cms.CommandText = "update nivel3 set Gestionado =(Select count(B.cas_id) as casos from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Gestionado' and nivel3.Fecha_Corta = B.fc_corta )+Gestionado where Convert(date,Fecha_Corta) in (Select convert(date,fc_corta)   from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Gestionado' )"
            End If

            If _Validacion = 6 Then

                cms.CommandText = "update nivel3 set ILOCALIZABLE =(Select count(B.cas_id) as casos from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'ILOCALIZABLE' and nivel3.Fecha_Corta = B.fc_corta )+ILOCALIZABLE where Convert(date,Fecha_Corta) in (Select convert(date,fc_corta) from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'ILOCALIZABLE' )"
            End If

            If _Validacion = 7 Then

                cms.CommandText = "update nivel3 set [No Disponible] =(Select count(B.cas_id) as casos from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'No Disponible' and nivel3.Fecha_Corta = B.fc_corta )+[No Disponible] where Convert(date,Fecha_Corta) in (Select convert(date,fc_corta)   from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'No Disponible' )"
            End If

            If _Validacion = 8 Then

                cms.CommandText = "update nivel3 set Programado =(Select count(B.cas_id) as casos from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Programado' and nivel3.Fecha_Corta = B.fc_corta )+Programado where Convert(date,Fecha_Corta) in (Select convert(date,fc_corta) from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Programado' )"
            End If

            If _Validacion = 9 Then

                cms.CommandText = "update nivel3 set Reasignación =(Select count(B.cas_id) as casos from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Reasignación' and nivel3.Fecha_Corta = B.fc_corta )+Reasignación where Convert(date,Fecha_Corta) in (Select convert(date,fc_corta)   from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Reasignación' )"
            End If

            If _Validacion = 10 Then

                cms.CommandText = "update nivel3 set Seguimiento =(Select count(B.cas_id) as casos from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Seguimiento' and nivel3.Fecha_Corta = B.fc_corta )+Seguimiento where Convert(date,Fecha_Corta) in (Select convert(date,fc_corta)   from bandeja B where ((B.Bandeja)='java' Or (B.Bandeja)='messenger') and estado= 'Seguimiento' )"

            End If

            If _Validacion = 11 Then

                cms.CommandText = "update nivel3 set Total=Abierto+Cerrado+Escalado+Gestionado+ILOCALIZABLE+[No Disponible]+Programado+Reasignación+Seguimiento"

            End If

            If _Validacion = 12 Then

                cms.CommandText = "update nivel3 set Pendientes = [abierto] +[No Disponible]+[Programado]+[Gestionado]"

            End If

            If _Validacion = 13 Then

                cms.CommandText = "update nivel3 set Porcentaje = convert(decimal(10,2),convert(decimal(10,2),Pendientes)/convert(decimal(10,2),Total)*100)"

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

    Public Function CampañaVoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = 0 Then
                cms.CommandText = "select Fecha_Sap,Fecha_Corta,isnull([ABIERTO],0) as [ABIERTO],isnull([CERRADO],0) as [CERRADO],isnull([ESCALADO],0) as [ESCALADO],isnull([GESTIONADO],0) as [GESTIONADO],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([NO DISPONIBLE],0) as [NO DISPONIBLE],isnull([RECHAZADO],0) as [RECHAZADO],isnull([ILOCALIZABLE],0)+isnull([GESTIONADO],0)+isnull([ESCALADO],0)+isnull([ABIERTO],0)+isnull([CERRADO],0)+isnull([RECHAZADO],0)+isnull([NO DISPONIBLE],0) as Total, ISNULL([Abierto],0)+isnull([GESTIONADO],0)+isnull([NO DISPONIBLE],0) as Pendientes, convert(decimal,(convert(decimal(10,2),ISNULL([Abierto],0)+isnull([GESTIONADO],0)+isnull([NO DISPONIBLE],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([GESTIONADO],0)+isnull([ESCALADO],0)+isnull([ABIERTO],0)+isnull([CERRADO],0)+isnull([RECHAZADO],0)+isnull([NO DISPONIBLE],0))) * 100) as Porcentaje from( SELECT  F.F_sap as fecha_Sap, B.fccorta as Fecha_Corta,count(idcaso) as total,estado as estados FROM Bandeja_uni B INNER JOIN F_SAP_V F ON B.fccorta = F.F_corta WHERE ((convert(date,B.fccorta)BETWEEN @_Fcorta AND @_Fsap) ) GROUP BY F.F_sap, B.fccorta,estado )as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[ESCALADO],[ABIERTO],[CERRADO],[RECHAZADO],[NO DISPONIBLE],[GESTIONADO])) as datapivot order by Fecha_Sap "
                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap
                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta
            End If
            If _Validacion = 1 Then
                cms.CommandText = "select bandeja,Fecha_Sap,Fecha_Corta,isnull([ABIERTO],0) as [ABIERTO],isnull([CERRADO],0) as [CERRADO],isnull([ESCALADO],0) as [ESCALADO],isnull([GESTIONADO],0) as [GESTIONADO],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([NO DISPONIBLE],0) as [NO DISPONIBLE],isnull([RECHAZADO],0) as [RECHAZADO],isnull([ILOCALIZABLE],0)+isnull([GESTIONADO],0)+isnull([ESCALADO],0)+isnull([ABIERTO],0)+isnull([CERRADO],0)+isnull([RECHAZADO],0)+isnull([NO DISPONIBLE],0) as Total, ISNULL([Abierto],0)+isnull([GESTIONADO],0)+isnull([NO DISPONIBLE],0) as Pendientes, convert(decimal,(convert(decimal(10,2),ISNULL([Abierto],0)+isnull([GESTIONADO],0)+isnull([NO DISPONIBLE],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([GESTIONADO],0)+isnull([ESCALADO],0)+isnull([ABIERTO],0)+isnull([CERRADO],0)+isnull([RECHAZADO],0)+isnull([NO DISPONIBLE],0))) * 100) as Porcentaje from( SELECT B.bandeja, B.fccorta as Fecha_Corta, F.F_sap as Fecha_Sap, Count(B.idcaso) AS [Total],estado as estados FROM Bandeja_uni B INNER JOIN F_SAP_V F ON B.fccorta = F.F_corta WHERE ((convert(date,B.fccorta)BETWEEN @_Fcorta AND @_Fsap )) and bandeja =@_Campa GROUP BY B.bandeja, F.F_sap, B.fccorta, F.F_sap,estado )as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[ESCALADO],[ABIERTO],[CERRADO],[RECHAZADO],[NO DISPONIBLE],[GESTIONADO])) as datapivot order by Fecha_Corta "
                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta
                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap
                cms.Parameters.Add("@_Campa", SqlDbType.VarChar, 50).Value = _Campa
            End If
            If _Validacion = 2 Then
                cms.CommandText = "select Bandeja,Fecha_Sap,Fecha_Corta,isnull([ABIERTO],0) as [ABIERTO],isnull([CERRADO],0) as [CERRADO],isnull([ESCALADO],0) as [ESCALADO],isnull([GESTIONADO],0) as [GESTIONADO],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([NO DISPONIBLE],0) as [NO DISPONIBLE],isnull([RECHAZADO],0) as [RECHAZADO],isnull([ILOCALIZABLE],0)+isnull([GESTIONADO],0)+isnull([ESCALADO],0)+isnull([ABIERTO],0)+isnull([CERRADO],0)+isnull([RECHAZADO],0)+isnull([NO DISPONIBLE],0) as Total, ISNULL([Abierto],0)+isnull([GESTIONADO],0)+isnull([NO DISPONIBLE],0) as Pendientes, convert(decimal,(convert(decimal(10,2),ISNULL([Abierto],0)+isnull([GESTIONADO],0)+isnull([NO DISPONIBLE],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([GESTIONADO],0)+isnull([ESCALADO],0)+isnull([ABIERTO],0)+isnull([CERRADO],0)+isnull([RECHAZADO],0)+isnull([NO DISPONIBLE],0))) * 100) as Porcentaje from( SELECT  'Banca Movil' as Bandeja,B.fccorta as Fecha_Corta, F.F_sap as Fecha_Sap, Count(B.idcaso) AS [Total],estado as estados FROM Bandeja_uni B INNER JOIN F_SAP_V F ON B.fccorta = F.F_corta WHERE ((convert(date,B.fccorta)BETWEEN @_Fcorta AND @_Fsap)) and (bandeja LIKE 'BMF%' ) GROUP BY F.F_sap, B.fccorta, F.F_sap,estado )as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[ESCALADO],[ABIERTO],[CERRADO],[RECHAZADO],[NO DISPONIBLE],[GESTIONADO])) as datapivot order by Fecha_Corta "
                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta
                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap
            End If
            If _Validacion = 3 Then
                cms.CommandText = "select Bandeja,Fecha_Sap,Fecha_Corta,isnull([ABIERTO],0) as [ABIERTO],isnull([CERRADO],0) as [CERRADO],isnull([ESCALADO],0) as [ESCALADO],isnull([GESTIONADO],0) as [GESTIONADO],isnull([ILOCALIZABLE],0) as [ILOCALIZABLE],isnull([NO DISPONIBLE],0) as [NO DISPONIBLE],isnull([RECHAZADO],0) as [RECHAZADO],isnull([ILOCALIZABLE],0)+isnull([GESTIONADO],0)+isnull([ESCALADO],0)+isnull([ABIERTO],0)+isnull([CERRADO],0)+isnull([RECHAZADO],0)+isnull([NO DISPONIBLE],0) as Total, ISNULL([Abierto],0)+isnull([GESTIONADO],0)+isnull([NO DISPONIBLE],0) as Pendientes, convert(decimal,(convert(decimal(10,2),ISNULL([Abierto],0)+isnull([GESTIONADO],0)+isnull([NO DISPONIBLE],0))/convert(decimal(10,2),isnull([ILOCALIZABLE],0)+isnull([GESTIONADO],0)+isnull([ESCALADO],0)+isnull([ABIERTO],0)+isnull([CERRADO],0)+isnull([RECHAZADO],0)+isnull([NO DISPONIBLE],0))) * 100) as Porcentaje from( SELECT 'PQR' as Bandeja, B.fccorta as Fecha_Corta, F.F_sap as Fecha_Sap, Count(B.idcaso) AS [Total],estado as estados FROM Bandeja_uni B INNER JOIN F_SAP_V F ON B.fccorta = F.F_corta WHERE ((convert(date,B.fccorta)BETWEEN @_Fcorta AND @_Fsap)) and (bandeja LIKE 'voz-%' or bandeja like 'ldi-%' or bandeja = 'Mensajeria' or bandeja = 'VozLlama') GROUP BY F.F_sap, B.fccorta, F.F_sap,estado )as dataSource pivot (Max(total) for estados in ([ILOCALIZABLE],[ESCALADO],[ABIERTO],[CERRADO],[RECHAZADO],[NO DISPONIBLE],[GESTIONADO])) as datapivot order by Fecha_Corta"
                cms.Parameters.Add("@_Fcorta", SqlDbType.VarChar, 20).Value = _Fcorta
                cms.Parameters.Add("@_Fsap", SqlDbType.VarChar, 20).Value = _Fsap
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
    Public Function CasosHora() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()

            If _Validacion = 1 Then
                cms.CommandText = "select Hora,isnull([" + _F1 + "],0) as [" + _F1 + "],isnull([" + _F2 + "],0) as [" + _F2 + "],isnull([" + _F3 + "],0) as [" + _F3 + "],isnull([" + _F4 + "],0) as [" + _F4 + "],isnull([" + _F5 + "],0) as [" + _F5 + "] from(select datepart(hour,cas_fecha_registro) as hora, count(cas_id) casos, convert(date,cas_fecha_registro) as dia from bandeja where cas_fecha_registro is not null and convert(date,cas_fecha_registro)between @_fcini and @_fcfin group by datepart(hour,cas_fecha_registro) ,convert(date,cas_fecha_registro)) as DataSource pivot(max(casos)for dia in ([" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "])) as DataPivot order by hora"
                cms.Parameters.Add("@_fcini", SqlDbType.VarChar, 20).Value = _fcini
                cms.Parameters.Add("@_fcfin", SqlDbType.VarChar, 20).Value = _fcfin
                cms.Parameters.Add("@F1", SqlDbType.VarChar, 200).Value = _F1
                cms.Parameters.Add("@F2", SqlDbType.VarChar, 200).Value = _F2
                cms.Parameters.Add("@F3", SqlDbType.VarChar, 200).Value = _F3
                cms.Parameters.Add("@F4", SqlDbType.VarChar, 200).Value = _F4
                cms.Parameters.Add("@F5", SqlDbType.VarChar, 200).Value = _F5
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
    Public Function CasosHoraV() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()

            If _Validacion = 1 Then
                cms.CommandText = "select Hora,isnull([" + _F1 + "],0) as [" + _F1 + "],isnull([" + _F2 + "],0) as [" + _F2 + "],isnull([" + _F3 + "],0) as [" + _F3 + "],isnull([" + _F4 + "],0) as [" + _F4 + "],isnull([" + _F5 + "],0) as [" + _F5 + "] from(select datepart(hour,cas_fecha_registro) as hora, count(idcaso) casos, convert(date,cas_fecha_registro) as dia from bandeja_uni where cas_fecha_registro is not null and convert(date,cas_fecha_registro)between @_fcini and @_fcfin group by datepart(hour,cas_fecha_registro) ,convert(date,cas_fecha_registro)) as DataSource pivot(max(casos)for dia in ([" + _F1 + "],[" + _F2 + "],[" + _F3 + "],[" + _F4 + "],[" + _F5 + "])) as DataPivot order by hora"
                cms.Parameters.Add("@_fcini", SqlDbType.VarChar, 20).Value = _fcini
                cms.Parameters.Add("@_fcfin", SqlDbType.VarChar, 20).Value = _fcfin
                cms.Parameters.Add("@F1", SqlDbType.VarChar, 200).Value = _F1
                cms.Parameters.Add("@F2", SqlDbType.VarChar, 200).Value = _F2
                cms.Parameters.Add("@F3", SqlDbType.VarChar, 200).Value = _F3
                cms.Parameters.Add("@F4", SqlDbType.VarChar, 200).Value = _F4
                cms.Parameters.Add("@F5", SqlDbType.VarChar, 200).Value = _F5
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
    Public Sub Escalamientoinbound()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        cn.Open()
        Try
            If _Validacion = 0 Then
                cms.CommandText = "Delete datosclaro.dbo.Escalamiento_inbound"
            End If
            If _Validacion = 1 Then
                cms.CommandText = "insert INTO datosclaro.dbo.Escalamiento_inbound SELECT B.cas_id,B.estado, Convert(date,B.cas_fecha_registro) as F_escalamiento, B.cas_observaciones,  B.Bandeja,'aaaaaaaaaaaaaaaaaaaaaaaaaa' as Segmento ,'aaaaaaaaaaaaaaaaaaaaa' as Area_escalamiento, V.cpd, V.estadocpd  FROM datosclaro.dbo.Bandeja B INNER JOIN clarovoz.dbo.VFallared V ON B.cas_id = V.idcaso WHERE Convert(date,B.cas_fecha_registro) between @_Fecha_Inicio And @_Fecha_Fin AND B.estado='Escalado' AND (B.Bandeja='inbound' Or B.Bandeja Is Null) and B.cas_id > '60000'"
                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio
                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin
            End If
            If _Validacion = 2 Then
                cms.CommandText = "Update datosclaro.dbo.Escalamiento_inbound set Area_Escalamiento = 'Tecnica' where cpd like '%inc0%' "
            End If
            If _Validacion = 3 Then
                cms.CommandText = "Update datosclaro.dbo.Escalamiento_inbound set Area_escalamiento = 'informatica' where cpd like '%sd%'"
            End If
            If _Validacion = 4 Then
                cms.CommandText = "Update datosclaro.dbo.Escalamiento_inbound set Area_escalamiento = 'Tecnica-informatica' where cpd like '%sd%' and cpd like '%inc0%'"
            End If
            If _Validacion = 5 Then
                cms.CommandText = "update datosclaro.dbo.Escalamiento_inbound set Bandeja='Inbound'"
            End If
            If _Validacion = 6 Then
                cms.CommandText = "Update datosclaro.dbo.Escalamiento_inbound set Segmento = 'Fidelización' where cas_observaciones like '%fideliza%'"
            End If
            If _Validacion = 7 Then
                cms.CommandText = "Update datosclaro.dbo.Escalamiento_inbound set Segmento = 'Corporativo' where cas_observaciones like '%corporati%'"
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
    Public Function Finalinbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT E.cas_id,E.estado,E.F_escalamiento,E.Bandeja,E.Segmento,E.Area_escalamiento, E.cpd FROM Escalamiento_inbound E INNER JOIN CRMDetalle C ON E.cas_id = C.idcaso WHERE (C.obs Like '%Inc%' Or C.obs Like '%sd%') Group by E.cas_id,E.estado,E.F_escalamiento,E.Bandeja,E.Segmento,E.Area_escalamiento, E.cpd"
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

    ''' Fallatec DATOS '''

    Public Function FallatecDatos() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select  dateadd(d,-15,F_Sap) as fechas,count (cas_id) as total from Fallatec_Final F inner join (select max(cas_id) as caso, max(Tickler) as Tickle from Fallatec_Final where (estado='ESCALADO') and (CONVERT(date,fcierre)<convert(date,DATEADD(d,-1,GETDATE())) or fcierre is null) and (CONVERT(date,fcdigitado)<convert(date,DATEADD(d,-1,GETDATE())) or fcdigitado is null) group by cas_id) L on F.cas_id=L.caso and F.Tickler = L.Tickle where (estado='ESCALADO') and (CONVERT(date,fcierre)<convert(date,DATEADD(d,-1,GETDATE())) or fcierre is null) and (CONVERT(date,fcdigitado)<convert(date,DATEADD(d,-1,GETDATE())) or fcdigitado is null) group by F_Sap,FcActual Having DateAdd(d, -15, F_Sap) <= DateAdd(d, -1, GETDATE()) And FcActual = max(fcActual)"

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

    ''' Fallatec VOZ '''

    Public Function FallatecVoz() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select  dateadd(d,-15,F_Sap) as fechas,count (idcaso) as total from Fallatec_Final F inner join (select max(idcaso) as caso, max(Tickler) as Tickle from Fallatec_Final where (estado='ESCALADO') and (CONVERT(date,cas_fecha_registro)<convert(date,DATEADD(d,-1,GETDATE())) or cas_fecha_registro is null) and (CONVERT(date,fcdigitado)<convert(date,DATEADD(d,-1,GETDATE())) or fcdigitado is null) group by idcaso ) L on F.idcaso=L.caso and F.Tickler = L.Tickle where (estado='ESCALADO') and (CONVERT(date,cas_fecha_registro)<convert(date,DATEADD(d,-1,GETDATE())) or cas_fecha_registro is null) and (CONVERT(date,fcdigitado)<convert(date,DATEADD(d,-1,GETDATE())) or fcdigitado is null)  group by F_Sap,FcActual Having dateadd(d,-15,F_Sap)<=DATEADD(d,-1,GETDATE()) and FcActual=max(FcActual)"

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

    ''' Revision DATOS '''

    Public Function RevisionDatos() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select  dateadd(d,-15,F_Sap) as fechas,count (cas_id) as total from Fallatec_Final F inner join (select max(cas_id) as caso, max(Tickler) as Tickle from Fallatec_Final where (estado='CERRADO' or estado='ILOCALIZABLE') and (CONVERT(date,fcierre)<convert(date,DATEADD(d,-1,GETDATE())) or fcierre is null) and (CONVERT(date,fcdigitado)<convert(date,DATEADD(d,-1,GETDATE())) or fcdigitado is null) group by cas_id,FcActual) L on F.cas_id=L.caso and F.Tickler = L.Tickle where (estado='CERRADO' or estado='ILOCALIZABLE') and (CONVERT(date,fcierre)<convert(date,DATEADD(d,-1,GETDATE())) or fcierre is null) and (CONVERT(date,fcdigitado)<convert(date,DATEADD(d,-1,GETDATE())) or fcdigitado is null) group by F_Sap,FcActual Having dateadd(d,-15,F_Sap)<=DATEADD(d,-1,GETDATE()) and FcActual=max(FcActual)"

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

    ''' Revision VOZ '''

    Public Function RevisionVoz() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select  dateadd(d,-15,F_Sap) as fechas,count (idcaso) as total from Fallatec_Final F inner join (select max(idcaso) as caso, max(Tickler) as Tickle from Fallatec_Final where (estado='CERRADO' or estado='ILOCALIZABLE') and (CONVERT(date,cas_fecha_registro)<convert(date,DATEADD(d,-1,GETDATE())) or cas_fecha_registro is null) and (CONVERT(date,fcdigitado)<convert(date,DATEADD(d,-1,GETDATE())) or fcdigitado is null)  group by idcaso ) L on F.idcaso=L.caso and F.Tickler = L.Tickle where (estado='CERRADO' or estado='ILOCALIZABLE') and (CONVERT(date,cas_fecha_registro)<convert(date,DATEADD(d,-1,GETDATE())) or cas_fecha_registro is null) and (CONVERT(date,fcdigitado)<convert(date,DATEADD(d,-1,GETDATE())) or fcdigitado is null)  group by F_Sap,FcActual Having DateAdd(d, -15, F_Sap) <= DateAdd(d, -1, GETDATE()) And FcActual = max(FcActual)"

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

    ''' Dimensionamiento '''

    Public Function Dimensio() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select count(*) as total from usuarios where cargo like 'BO_G%' "

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

    ''' Escalamiento datos '''

    Public Function EscalamientoDatos() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "SELECT Convert(date,B.cas_fecha_registro) as Fecha, Count(B.cas_id) as total FROM datosclaro.dbo.Bandeja B INNER JOIN clarovoz.dbo.VFallared V ON B.cas_id = V.idcaso WHERE (((B.cas_fecha_registro)between @_Fecha_Fin and @_Fecha_Inicio) AND ((V.estadocpd) Is Null)) and V.campana ='Datos' and (B.cas_id < '9999999999') Group by Convert(date,B.cas_fecha_registro), V.estadocpd, V.campana ORDER BY Count(B.cas_id) DESC"

            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

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

    ''' Escalamiento Voz '''

    Public Function EscalamientoVoz() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "SELECT  Convert(date,BU.cas_fecha_registro) as Fecha,Count(BU.idcaso) as total FROM Bandeja_uni BU INNER JOIN VFallared V ON BU.idcaso = V.idcaso WHERE V.estadocpd Is Null AND Convert(date,BU.cas_fecha_registro) between @_Fecha_Fin and @_Fecha_Inicio and (BU.idcaso not like '%__________') group by Convert(date,BU.cas_fecha_registro) Order by Convert(date,BU.cas_fecha_registro) DESC"

            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

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

    ''' Ilocalizables Voz '''

    Public Function IlocalizablesVoz() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "SELECT Convert(date,B.cas_fecha_registro) as fechas,Count(B.idcaso) as total FROM Bandeja_uni B WHERE B.bandeja Is Not Null AND B.digitado Is Null AND B.estado='ilocalizable' and Convert(date,B.cas_fecha_registro)between @_Fecha_Fin and @_Fecha_Inicio  and (B.idcaso not like '%__________') Group By Convert(date,B.cas_fecha_registro) Order by  Convert(date,B.cas_fecha_registro) DESC"

            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

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

    ''' Ilocalizables Datos '''

    Public Function IlocalizablesDatos() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "SELECT Convert(date,B.cas_fecha_registro) as fechas,Count(B.cas_id) as total FROM Bandeja B WHERE ((Convert(date,B.cas_fecha_registro)between @_Fecha_Fin and @_Fecha_Inicio) AND ((B.estado)='ilocalizable') AND ((B.digitado) Is Null) AND ((B.Bandeja) Is Not Null)) and (cas_id not like '%__________') Group by Convert(date,B.cas_fecha_registro) order by Convert(date,B.cas_fecha_registro),Count(B.cas_id) DESC"

            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

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

    ''' Service Voz '''

    Public Function ServiceVoz() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select CONVERT(date,FECHA) as Fecha,count(idcaso) as Total from Service_Voz where (tickler is null or tickler ='0' OR tickler = 0) and FECHA between @_Fecha_Fin and @_Fecha_Inicio group by Fecha"

            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

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

    Public Sub ServiceVozAct()

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim cms As New SqlClient.SqlCommand

        cn.Open()

        Try

            If _Validacion = 0 Then

                cms.CommandText = "delete Service_Voz"

            End If

            If _Validacion = 1 Then

                cms.CommandText = "delete TIKET_SERVICE_Voz"

            End If

            If _Validacion = 2 Then

                cms.CommandText = "insert INTO Service_Voz SELECT estado, idcaso, convert(date,fcregserv) AS FECHA, tickler, obsescalamiento FROM ServiceDetalle WHERE ((estado)='reportado' Or (estado)='asignado') AND (idcaso) Not Like '%4000%' AND convert(date,fcregserv)between @_Fecha_Fin and @_Fecha_Inicio "

                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

            End If

            If _Validacion = 3 Then

                cms.CommandText = "insert INTO TIKET_SERVICE_VOZ SELECT S.idcaso, substring (C.obs,patindex('%sd%',obs),8) AS incidencias, convert(date,S.fcregserv)as Fecha  FROM ServiceDetalle S INNER JOIN VCRMDetalle C ON S.idcaso = C.idcaso group by s.idcaso,substring (C.obs,patindex('%sd%',obs),8),s.fcregserv"

            End If

            If _Validacion = 4 Then

                cms.CommandText = "UPDATE S SET S.tickler = T.incidencias from Service_Voz S inner JOIN  TIKET_SERVICE_VOZ T ON (T.idcaso = S.idcaso)  where (T.incidencias like '%sd4%') or (T.incidencias like '%sd5%')"

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

    ''' Service Datos '''

    Public Function ServiceDatos() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select CONVERT(date,FECHA) as fechas,count(idcaso) as total from Service_Datos where (tickler is null or tickler ='0' OR tickler = 0) and FECHA between @_Fecha_Fin and @_Fecha_Inicio group by Fecha"

            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

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

    Public Sub ServiceDatosAct()

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim cms As New SqlClient.SqlCommand

        cn.Open()

        Try

            If _Validacion = 0 Then

                cms.CommandText = "delete Service_Datos"

            End If

            If _Validacion = 1 Then

                cms.CommandText = "delete TIKET_SERVICE_DATOS"

            End If

            If _Validacion = 2 Then

                cms.CommandText = "insert INTO Service_Datos SELECT estado, idcaso, convert(date,fcregserv) AS FECHA, tickler, obsescalamiento  FROM ServiceDetalle WHERE ((estado)='reportado' Or (estado)='asignado') AND (idcaso) Not Like '%4000%' AND convert(date,fcregserv)between @_Fecha_Fin and @_Fecha_Inicio"

                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

            End If

            If _Validacion = 3 Then

                cms.CommandText = "insert INTO TIKET_SERVICE_DATOS SELECT S.idcaso, substring (C.obs,patindex('%sd%',obs),8) AS incidencias, convert(date,S.fcregserv)as Fecha  FROM ServiceDetalle S INNER JOIN CRMDetalle C ON S.idcaso = C.idcaso group by s.idcaso,substring (C.obs,patindex('%sd%',obs),8),s.fcregserv"

            End If

            If _Validacion = 4 Then

                cms.CommandText = "UPDATE S SET S.tickler = T.incidencias from Service_Datos S inner JOIN  TIKET_SERVICE_DATOS T ON (T.idcaso = S.idcaso)  where (T.incidencias like '%sd4%') or (T.incidencias like '%sd5%')"

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

    ''' Seguimiento Datos '''

    Public Function SeguimientoDatos() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select cas_fecha_registro as fechas,count(id_caso) as total from Seguimiento_Datos group by cas_fecha_registro order by cas_fecha_registro desc"

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

    Public Sub SeguimientoDatosIns()

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base

        Dim cms As New SqlClient.SqlCommand

        cn.Open()

        Try

            If _Validacion = 0 Then

                cms.CommandText = "delete Seguimiento_Datos"

            End If

            If _Validacion = 1 Then

                cms.CommandText = "insert into Seguimiento_Datos select min_ac,min(consecutivo) as id_caso,convert(date,cas_fecha_registro) as cas_fecha_registro ,nombre from Seguimiento_iloc_final_D where convert(date,cas_fecha_registro)between  @_Fecha_Fin and @_Fecha_Inicio group by min_ac,consecutivo,cas_fecha_registro,nombre order by consecutivo ,cas_fecha_registro desc"

                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

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

    ''' Seguimiento VOZ '''

    Public Function SeguimientoVoz() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "select cas_fecha_registro as fechas,count(id_caso) as total from Seguimiento_Voz group by cas_fecha_registro order by cas_fecha_registro desc"

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

    Public Sub SeguimientoVozIns()

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim cms As New SqlClient.SqlCommand

        cn.Open()

        Try

            If _Validacion = 0 Then

                cms.CommandText = "delete Seguimiento_Voz"

            End If

            If _Validacion = 1 Then

                cms.CommandText = "insert into Seguimiento_Voz select min_ac,min(consecutivo) as id_caso,convert(date,cas_fecha_registro) as cas_fecha_registro ,nombre from Seguimiento_iloc_final_V where convert(date,cas_fecha_registro)between @_Fecha_Inicio and @_Fecha_Fin group by min_ac,consecutivo,cas_fecha_registro,nombre order by consecutivo ,cas_fecha_registro desc"

                cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

                cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

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

    ''' FORMATOS '''

    Public Function OtrosFormatos() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim dta As SqlClient.SqlDataAdapter

        Dim dts As New DataSet

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            cms.CommandText = "SELECT convert(date,fcreg) AS fechas ,count(idcaso) as total FROM CreaFormato WHERE convert(date,fcreg)Between @_Fecha_Fin And @_Fecha_Inicio AND ((idcaso) Not Like '%4000%') AND ((fcregcrea) Is Null) group by convert(date,fcreg)"

            cms.Parameters.Add("@_Fecha_Inicio", SqlDbType.VarChar, 20).Value = _Fecha_Inicio

            cms.Parameters.Add("@_Fecha_Fin", SqlDbType.VarChar, 20).Value = _Fecha_Fin

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

    Public Function ValidacionEstudio() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _codigo <> Nothing And _Documento <> Nothing Then
                cms.CommandText = "select nombres + ' ' + apellidos as Nombre,codigo,documento from personal where documento=@_Documento and codigo=@_codigo"
                cms.Parameters.Add("@_codigo", SqlDbType.VarChar, 20).Value = _codigo
                cms.Parameters.Add("@_Documento", SqlDbType.VarChar, 20).Value = _Documento
            ElseIf _codigo <> Nothing Then
                cms.CommandText = "Select nombres + ' ' + apellidos as Nombre,documento,codigo from personal where codigo=@_codigo"
                cms.Parameters.Add("@_codigo", SqlDbType.VarChar, 20).Value = _codigo
            ElseIf _Documento <> Nothing Then
                cms.CommandText = "Select nombres + ' ' + apellidos as Nombre,documento,codigo from personal where documento=@_Documento"
                cms.Parameters.Add("@_Documento", SqlDbType.VarChar, 20).Value = _Documento
            End If
            If _Validacion = 1 Then
                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where e.Codigo = @_codigo"
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
    Public Function Listas() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Validacion = 1 Then
                cms.CommandText = "select Cod_Estudio_complemento,nombre from Estudio_complemento where pertenece='Experiencia' or Pertenece = '0'"
            End If
            If _Validacion = 2 Then
                cms.CommandText = "select Cod_Estudio_complemento,nombre from Estudio_complemento where pertenece='NIVEL ACADÉMICO' or Pertenece = '0'"
            End If
            If _Validacion = 3 Then
                cms.CommandText = "select Cod_Estudio_complemento,nombre from Estudio_complemento where pertenece='ÁREA DE CONOCIMIENTO' or Pertenece = '0'"
            End If
            If _Validacion = 4 Then
                cms.CommandText = "select Cod_Estudio_complemento,nombre from Estudio_complemento where (pertenece='CATEGORÍA ACADÉMICA' and [Global] = @_codigo) or Pertenece = '0'"
                cms.Parameters.Add("@_codigo", SqlDbType.BigInt).Value = _codigo
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

    Public Function SeleccionEstudio() As DataSet

        Dim cn As New SqlClient.SqlConnection

        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter

        Dim cms As New SqlClient.SqlCommand

        Try

            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config

            cn.Open()

            cms.CommandText = "select  E.Id_Estudio,P.nombres + ' ' + P.apellidos as Nombre, E.Codigo,E.Documento,Fk_Experiencia_Acad as Experiencia_Academica,Fk_Nivel_Acad as Nivel_Academico,Anio_Aplaza,Semestre_Aplaza,Fk_Area_Conocimiento as Area_Conocimiento,Fk_Categoria as Categoria, Semestre_Cer,Institucion,Practica from estudio E inner join personal P on E.Codigo = P.codigo where  E.Id_Estudio = @_Id"

            cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

            cms.Connection = cn

            dta = New SqlClient.SqlDataAdapter(cms)

            dta.Fill(dts)

            _Cantidad = dts.Tables(0).Rows.Count

            If _Cantidad > 0 Then

                If dts.Tables(0).Rows(0).Item("Id_Estudio") Is DBNull.Value Then

                    _Id = ""

                Else

                    _Id = dts.Tables(0).Rows(0).Item("Id_Estudio")

                End If

                If dts.Tables(0).Rows(0).Item("Codigo") Is DBNull.Value Then

                    _codigo = ""

                Else

                    _codigo = dts.Tables(0).Rows(0).Item("Codigo")

                End If

                If dts.Tables(0).Rows(0).Item("Documento") Is DBNull.Value Then

                    _Documento = ""

                Else

                    _Documento = dts.Tables(0).Rows(0).Item("Documento")

                End If

                If dts.Tables(0).Rows(0).Item("Nombre") Is DBNull.Value Then

                    _Nombre = ""

                Else

                    _Nombre = dts.Tables(0).Rows(0).Item("Nombre")

                End If

                If dts.Tables(0).Rows(0).Item("Experiencia_Academica") Is DBNull.Value Then

                    _Experiencia = 0

                Else

                    _Experiencia = dts.Tables(0).Rows(0).Item("Experiencia_Academica")

                End If

                If dts.Tables(0).Rows(0).Item("Nivel_Academico") Is DBNull.Value Then

                    _Nivel = 0

                Else

                    _Nivel = dts.Tables(0).Rows(0).Item("Nivel_Academico")

                End If

                If dts.Tables(0).Rows(0).Item("Anio_Aplaza") Is DBNull.Value Then

                    _AñoApla = ""

                Else

                    _AñoApla = dts.Tables(0).Rows(0).Item("Anio_Aplaza")

                End If

                If dts.Tables(0).Rows(0).Item("Semestre_Aplaza") Is DBNull.Value Then

                    _SemApla = ""

                Else

                    _SemApla = dts.Tables(0).Rows(0).Item("Semestre_Aplaza")

                End If

                If dts.Tables(0).Rows(0).Item("Area_Conocimiento") Is DBNull.Value Then

                    _Area = ""

                Else

                    _Area = dts.Tables(0).Rows(0).Item("Area_Conocimiento")

                End If

                If dts.Tables(0).Rows(0).Item("Categoria") Is DBNull.Value Then

                    _Categoria = 0

                Else

                    _Categoria = dts.Tables(0).Rows(0).Item("Categoria")

                End If

                If dts.Tables(0).Rows(0).Item("Semestre_Cer") Is DBNull.Value Then

                    _semestre = 0

                Else

                    _semestre = dts.Tables(0).Rows(0).Item("Semestre_Cer")

                End If

                If dts.Tables(0).Rows(0).Item("Institucion") Is DBNull.Value Then

                    _institucion = ""

                Else

                    _institucion = dts.Tables(0).Rows(0).Item("Institucion")

                End If

                If dts.Tables(0).Rows(0).Item("Practica") Is DBNull.Value Then

                    _Practica = ""

                Else

                    _Practica = dts.Tables(0).Rows(0).Item("Practica")

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

    Public Sub InsertarEstudio()

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base

        Dim cms As New SqlClient.SqlCommand

        cn.Open()

        Try

            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexion directa con la creada en la web.config

            cn.Open()

            cms.CommandText = "insert into Estudio (Codigo,Documento,fK_Experiencia_Acad,FK_Nivel_Acad,Anio_Aplaza,Semestre_Aplaza,Fk_Area_Conocimiento,Fk_Categoria,Semestre_Cer,Institucion,Practica) values(@_codigo,@_Documento,@_Experiencia,@_Nivel,@_AñoApla,@_SemApla,@_Area,@_Categoria,@_semestre,@_institucion,@_Practica)"

            cms.Parameters.Add("@_codigo", SqlDbType.VarChar, 20).Value = _codigo

            cms.Parameters.Add("@_Documento", SqlDbType.VarChar, 20).Value = _Documento

            cms.Parameters.Add("@_Experiencia", SqlDbType.BigInt).Value = _Experiencia

            cms.Parameters.Add("@_Nivel", SqlDbType.BigInt).Value = _Nivel

            cms.Parameters.Add("@_AñoApla", SqlDbType.BigInt).Value = _AñoApla

            cms.Parameters.Add("@_SemApla", SqlDbType.VarChar, 20).Value = _SemApla

            cms.Parameters.Add("@_Area", SqlDbType.BigInt).Value = _Area

            cms.Parameters.Add("@_Categoria", SqlDbType.BigInt).Value = _Categoria

            cms.Parameters.Add("@_semestre", SqlDbType.BigInt).Value = _semestre

            cms.Parameters.Add("@_institucion", SqlDbType.VarChar, 300).Value = _institucion

            cms.Parameters.Add("@_Practica", SqlDbType.VarChar, 20).Value = _Practica

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

    Public Sub ActualizarEstudio()

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base

        Dim cms As New SqlClient.SqlCommand

        cn.Open()

        Try

            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexion directa con la creada en la web.config

            cn.Open()

            If _Validacion = 1 Then

                cms.CommandText = "Update Estudio set Fk_Experiencia_Acad = @_Experiencia WHERE Id_Estudio = @_id"

                cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

                cms.Parameters.Add("@_Experiencia", SqlDbType.BigInt).Value = _Experiencia

            End If

            If _Validacion = 2 Then

                cms.CommandText = "Update Estudio set Fk_Nivel_Acad = @_Nivel WHERE Id_Estudio = @_id"

                cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

                cms.Parameters.Add("@_Nivel", SqlDbType.BigInt).Value = _Nivel

            End If

            If _Validacion = 3 Then

                cms.CommandText = "Update Estudio set Anio_Aplaza = @_AñoApla WHERE Id_Estudio = @_id"

                cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

                cms.Parameters.Add("@_AñoApla", SqlDbType.BigInt).Value = _AñoApla

            End If

            If _Validacion = 4 Then

                cms.CommandText = "Update Estudio set Semestre_Aplaza = @_SemApla WHERE Id_Estudio = @_id"

                cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

                cms.Parameters.Add("@_SemApla", SqlDbType.VarChar, 20).Value = _SemApla

            End If

            If _Validacion = 5 Then

                cms.CommandText = "Update Estudio set Fk_Area_Conocimiento = @_Area WHERE Id_Estudio = @_id"

                cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

                cms.Parameters.Add("@_Area", SqlDbType.BigInt).Value = _Area

            End If

            If _Validacion = 6 Then

                cms.CommandText = "Update Estudio set Fk_Categoria = @_Categoria WHERE Id_Estudio = @_id"

                cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

                cms.Parameters.Add("@_Categoria", SqlDbType.BigInt).Value = _Categoria

            End If

            If _Validacion = 7 Then

                cms.CommandText = "Update Estudio set Semestre_Cer = @_semestre WHERE Id_Estudio = @_id"

                cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

                cms.Parameters.Add("@_semestre", SqlDbType.BigInt).Value = _semestre

            End If

            If _Validacion = 8 Then

                cms.CommandText = "Update Estudio set Institucion = @_institucion WHERE Id_Estudio = @_id"

                cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

                cms.Parameters.Add("@_institucion", SqlDbType.VarChar, 300).Value = _institucion

            End If

            If _Validacion = 9 Then

                cms.CommandText = "Update Estudio set Practica = @_Practica WHERE Id_Estudio = @_id"

                cms.Parameters.Add("@_Id", SqlDbType.VarChar, 20).Value = _Id

                cms.Parameters.Add("@_Practica", SqlDbType.VarChar, 20).Value = _Practica

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

    Public Function Consulta_Especifica() As DataSet

        Dim cn As New SqlClient.SqlConnection

        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter

        Dim cms As New SqlClient.SqlCommand



        Try

            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) 'Conexión directa con la creada en Web.config

            cn.Open()

            '/*SOLO EXPERIENCIA ACADEMICA*/'

            If _Experiencia <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia "

                cms.Parameters.Add("@_Experiencia", SqlDbType.BigInt).Value = _Experiencia

            End If

            '/*SOLO NIVEL ACADEMICO*/'

            If _Nivel <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Nivel_Acad= @_Nivel"

                cms.Parameters.Add("@_Nivel", SqlDbType.BigInt).Value = _Nivel

            End If

            '/*SOLO AREA DE CONOCIMIENTO*/'

            If _Area <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Area_Conocimiento = @_Area"

                cms.Parameters.Add("@_Area", SqlDbType.BigInt).Value = _Area

            End If

            '/*SOLO CATEGORIA*/'

            If _Categoria <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Categoria = @_Categoria"

                cms.Parameters.Add("@_Categoria", SqlDbType.BigInt).Value = _Categoria

            End If

            '/*SOLO PRACTICA*/'

            If _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Practica =@_Practica"

                cms.Parameters.Add("@_Practica", SqlDbType.VarChar, 20).Value = _Practica

            End If

            'TODO'

            If _Experiencia <> Nothing And _Nivel <> Nothing And _Area <> Nothing And _Categoria <> Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Nivel_Acad= @_Nivel and Fk_Area_Conocimiento = @_Area and Fk_Categoria = @_Categoria and Practica = @_Practica"

            End If

            'EXPERIENCIA ACADEMICA + NIVEL ACADEMICO + AREA CONOCIMIENTO + PRACTICA'

            If _Experiencia <> Nothing And _Nivel <> Nothing And _Area <> Nothing And _Categoria = Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Nivel_Acad= @_Nivel and Fk_Area_Conocimiento = @_Area and Practica = @_Practica"

            End If

            'EXPERIENCIA ACADEMICA + AREA CONOCIMIENTO + CATEGORIA + PRACTICA'

            If _Experiencia <> Nothing And _Nivel = Nothing And _Area <> Nothing And _Categoria <> Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Area_Conocimiento = @_Area and Fk_Categoria = @_Categoria and Practica = @_Practica"

            End If

            'NIVEL + AREA CONOCIMIENTO + CATEGORIA + PRACTICA'

            If _Experiencia = Nothing And _Nivel <> Nothing And _Area <> Nothing And _Categoria <> Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Nivel_Acad= @_Nivel and Fk_Area_Conocimiento = @_Area and Fk_Categoria = @_Categoria and Practica = @_Practica"

            End If

            'EXPERIENCIA ACADEMICA + NIVEL ACADEMICO + AREA CONOCIMIENTO + CATEGORIA'

            If _Experiencia <> Nothing And _Nivel <> Nothing And _Area <> Nothing And _Categoria <> Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Nivel_Acad= @_Nivel and Fk_Area_Conocimiento = @_Area and Fk_Categoria = @_Categoria"

            End If

            '/*EXPERIENCIA ACADEMICA + NIVEL ACADEMICO*/'

            If _Experiencia <> Nothing And _Nivel <> Nothing And _Area = Nothing And _Categoria = Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Nivel_Acad= @_Nivel"

            End If

            '/*EXPERIENCIA ACADEMICA + AREA CONOCIMIENTO*/'

            If _Experiencia <> Nothing And _Nivel = Nothing And _Area <> Nothing And _Categoria = Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Area_Conocimiento = @_Area"

            End If

            '/*EXPERIENCIA ACADEMICA + CATEGORIA*/'

            If _Experiencia <> Nothing And _Nivel = Nothing And _Area = Nothing And _Categoria <> Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Categoria = @_Categoria"

            End If

            '/*EXPERIENCIA ACADEMICA + PRACTICA*/'

            If _Experiencia <> Nothing And _Nivel = Nothing And _Area = Nothing And _Categoria = Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Practica =@_Practica"

            End If

            '/*EXPERIENCIA ACADEMICA + NIVEL ACADEMICO + AREA CONOCIMIENTO*/'

            If _Experiencia <> Nothing And _Nivel <> Nothing And _Area <> Nothing And _Categoria = Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Nivel_Acad= @_Nivel and Fk_Area_Conocimiento = @_Area"

            End If

            '/*EXPERIENCIA ACADEMICA + NIVEL ACADEMICO + CATEGORIA*/'

            If _Experiencia <> Nothing And _Nivel <> Nothing And _Area = Nothing And _Categoria <> Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Nivel_Acad= @_Nivel and Fk_Categoria = @_Categoria"

            End If

            '/*EXPERIENCIA ACADEMICA + NIVEL ACADEMICO + PRACTICA*/'

            If _Experiencia <> Nothing And _Nivel <> Nothing And _Area = Nothing And _Categoria = Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Nivel_Acad= @_Nivel and Practica =@_Practica"

            End If

            '/*EXPERIENCIA ACADEMICA + AREA CONOCIMIENTO + CATEGORIA*/'

            If _Experiencia <> Nothing And _Nivel = Nothing And _Area <> Nothing And _Categoria <> Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Area_Conocimiento = @_Area and Fk_Categoria = @_Categoria"

            End If

            '/*EXPERIENCIA ACADEMICA + AREA CONOCIMIENTO + PRACTICA*/'

            If _Experiencia <> Nothing And _Nivel = Nothing And _Area <> Nothing And _Categoria = Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Area_Conocimiento = @_Area and Practica =@_Practica"

            End If

            '/*EXPERIENCIA ACADEMICA + CATEGORIA + PRACTICA*/'

            If _Experiencia <> Nothing And _Nivel <> Nothing And _Area = Nothing And _Categoria <> Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Experiencia_Acad= @_Experiencia and Fk_Categoria = @_Categoria and Practica =@_Practica"

            End If

            '/*NIVEL ACADEMICO + AREA CONOCIMIENTO*/'

            If _Experiencia = Nothing And _Nivel <> Nothing And _Area <> Nothing And _Categoria = Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Nivel_Acad= @_Nivel and Fk_Area_Conocimiento = @_Area"

            End If

            '/*NIVEL ACADEMICO + CATEGORIA*/'

            If _Experiencia = Nothing And _Nivel <> Nothing And _Area = Nothing And _Categoria <> Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Nivel_Acad= @_Nivel and Fk_Categoria = @_Categoria"

            End If

            '/*NIVEL ACADEMICO + PRACTICA*/'

            If _Experiencia = Nothing And _Nivel <> Nothing And _Area = Nothing And _Categoria = Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Nivel_Acad= @_Nivel and Practica =@_Practica"

            End If

            '/*NIVEL ACADEMICO + AREA DE CONOCIMIENTO + CATEGORIA*/'

            If _Experiencia = Nothing And _Nivel <> Nothing And _Area <> Nothing And _Categoria <> Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Nivel_Acad= @_Nivel and Fk_Area_Conocimiento = @_Area and Fk_Categoria = @_Categoria"

            End If

            '/*NIVEL ACADEMICO + AREA CONOCIMIENTO + PRACTICA*/'

            If _Experiencia = Nothing And _Nivel <> Nothing And _Area <> Nothing And _Categoria = Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Nivel_Acad= @_Nivel and Fk_Area_Conocimiento = @_Area and Practica =@_Practica"

            End If

            '/*NIVEL ACADEMICO + CATEGORIA + PRACTICA*/'

            If _Experiencia = Nothing And _Nivel <> Nothing And _Area = Nothing And _Categoria <> Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Nivel_Acad= @_Nivel and Fk_Categoria = @_Categoria and Practica =@_Practica"

            End If

            '/*AREA CONOCIMIENTO + CATEGORIA*/'

            If _Experiencia = Nothing And _Nivel = Nothing And _Area <> Nothing And _Categoria <> Nothing And _Practica = Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Area_Conocimiento = @_Area and Fk_Categoria = @_Categoria"

            End If

            '/*AREA CONOCIMIENTO + PRACTICA*/'

            If _Experiencia = Nothing And _Nivel = Nothing And _Area <> Nothing And _Categoria = Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Area_Conocimiento = @_Area and Practica =@_Practica"

            End If

            '/*AREA CONOCIMIENTO + CATEGORIA + PRACTICA*/'

            If _Experiencia = Nothing And _Nivel = Nothing And _Area <> Nothing And _Categoria <> Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Area_Conocimiento = @_Area and Fk_Categoria = @_Categoria and Practica =@_Practica"

            End If

            '/*CATEGORIA + PRACTICA*/'

            If _Experiencia = Nothing And _Nivel = Nothing And _Area = Nothing And _Categoria <> Nothing And _Practica <> Nothing Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Fk_Categoria = @_Categoria and Practica =@_Practica"

            End If

            '/*CODIGO AGENTE*/'

            If _codigo <> "" Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento where Codigo = @_Codigo"

                cms.Parameters.Add("@_Codigo", SqlDbType.VarChar, 20).Value = _codigo

            End If

            If _Validacion = 1 Then

                cms.CommandText = "select E.Id_Estudio,E.Codigo,E.Documento,EC.Nombre as Experiencia_Academica,EC2.Nombre as Nivel_Academico,E.Anio_Aplaza,E.Semestre_Aplaza,EC3.Nombre as Area_Conocimiento,EC4.Nombre as Categoria, E.Semestre_Cer,E.Institucion,E.Practica from Estudio E inner join Estudio_complemento EC on E.Fk_Experiencia_Acad = EC.Cod_Estudio_complemento inner join Estudio_complemento EC2 on E.FK_Nivel_Acad = EC2.Cod_Estudio_complemento inner join Estudio_complemento EC3 on E.Fk_Area_Conocimiento = EC3.Cod_Estudio_complemento inner join Estudio_complemento EC4 on E.Fk_Categoria = EC4.Cod_Estudio_complemento"

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


    Public Function Consulta_solicitados() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            Dim Datos As String
            If _Validacion = "Solicitado" Then
                If _Campa = "Datos" Then 'DATOS
                    Datos = " and (Bandeja = 'Datos' or Bandeja like '%Bold%')"
                ElseIf _Campa = "BSCS" Then 'BSCS
                    Datos = " and (Bandeja = 'BSCS')"
                ElseIf _Campa = "TSF - PQR" Then 'TSF y PQR
                    Datos = " and (B.Bandeja like '%smart%' or B.Bandeja like '%Control%' or B.Bandeja like '%NOFORMA%')"
                ElseIf _Campa = "Desactivacion" Then
                    _Campa = "SELECT  Case when grouping(convert(date,B.Fc_Reg))=1 then 'total' else convert(varchar,convert(date,B.Fc_Reg)) end  as Fecha_Corta, Count(B.Id_Bandeja_Falla_Desactivacion_D_V) AS [Total],B.estado as estados FROM datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V B WHERE convert(date,B.Fc_Reg)BETWEEN  '" & _Fecha_Inicio & "' AND '" & _Fecha_Fin & "' GROUP BY rollup  (estado,  convert(date,B.Fc_Reg) )"
                ElseIf _Campa = "Dilo" Then
                    _Campa = "SELECT Case when grouping(convert(date,B.fcreporte))=1 then 'total' else convert(varchar,convert(date,B.fcreporte)) end  as Fecha_Corta, Count(B.fcreporte) AS [Total],B.estado as estados FROM datosclaro.dbo.Bandeja_alt B WHERE convert(date,B.fcreporte)BETWEEN  '" & _Fecha_Inicio & "' AND '" & _Fecha_Fin & "' GROUP BY rollup  (estado, CONVERT(date, B.fcreporte ))"
                End If
                If _Campa = "Datos" Or _Campa = "BSCS" Or _Campa = "TSF - PQR" Then
                    _Campa = "SELECT  Case when grouping(convert(date,B.fc_corta))=1 then 'total' else convert(varchar,convert(date,B.fc_corta)) end  as Fecha_Corta, Count(B.cas_id) AS [Total],B.estado as estados FROM datosclaro.dbo.Bandeja B WHERE convert(date,B.fc_corta)BETWEEN '" & _Fecha_Inicio & "' AND '" & _Fecha_Fin & "' " & Datos & " GROUP BY rollup  (estado, CONVERT(date, B.fc_corta ))"
                End If
                cms.CommandText = "select convert(varchar,Fecha_Corta) as [Fecha Corta],isnull([Abierto],0) as [Abierto],isnull([No Contactado],0) as [No Contactado],isnull([Programado],0) as [Programado],isnull([Gestionado],0) as [Gestionado],isnull([Seguimiento],0) as [Seguimiento],isnull([Cerrado],0) as [Cerrado],isnull([Cerrado informatica],0) as [Cerrado informatica],isnull([Cerrado tecnica],0) as [Cerrado tecnica],isnull([Escalado],0) as [Escalado],isnull([Solicitud escalar CPD],0) as [Solicitud escalar CPD],isnull([Solicitud escalar SD],0) as [Solicitud escalar SD],isnull([Solicitud ilocalizar],0) as [Solicitud ilocalizar],isnull([ilocalizado],0) as [ilocalizado],isnull([Buzon],0) as [Buzon],isnull([Abierto],0) + isnull([No Contactado],0)+ isnull([Programado],0) + isnull([Gestionado],0) + isnull([Seguimiento],0) + isnull([Cerrado],0) + isnull([Cerrado informatica],0) + isnull([Cerrado tecnica],0) + isnull([Escalado],0) + isnull([Solicitud escalar CPD],0) + isnull([Solicitud escalar SD],0) + isnull([Solicitud ilocalizar],0) + isnull([ilocalizado],0) + isnull([Buzon],0) as Total,isnull([Abierto],0) + isnull([No Contactado],0)+ isnull([Programado],0) + isnull([Gestionado],0) + isnull([Seguimiento],0) as Pendientes,convert(nvarchar,convert(decimal,(convert(decimal(10,2),isnull([Abierto],0) + isnull([No Contactado],0)+ isnull([Programado],0) + isnull([Gestionado],0) + isnull([Seguimiento],0))/ convert(decimal(10,2),isnull([Abierto],0) + isnull([No Contactado],0)+ isnull([Programado],0) + isnull([Gestionado],0) + isnull([Seguimiento],0) + isnull([Cerrado],0) + isnull([Cerrado informatica],0) + isnull([Cerrado tecnica],0) + isnull([Escalado],0) + isnull([Solicitud escalar CPD],0) + isnull([Solicitud escalar SD],0) + isnull([Solicitud ilocalizar],0) + isnull([ilocalizado],0) + isnull([Buzon],0))) * 100)) as Porcentaje from(" & _Campa & ")as dataSource pivot  (sum(total) for estados in ([Abierto],[No Contactado],[Programado],[Gestionado],[Seguimiento],[Cerrado],[Cerrado informatica],[Cerrado tecnica],[Escalado],[Solicitud escalar CPD],[Solicitud escalar SD],[Solicitud ilocalizar],[ilocalizado],[Buzon])) as datapivot order by [Fecha Corta]"
                '------PENDIENTES---------
            ElseIf _Validacion = "Pendiente" Then

                If _Fecha_Fin <> Nothing Then
                    _Fecha_Fin = " and Convert(date,fcreporte)<='" & _Fecha_Fin & "'"
                    _Fecha_Inicio = ">='" & _Fecha_Inicio & "'"
                ElseIf _Fecha_Inicio <> Nothing Then
                    _Fecha_Inicio = "='" & _Fecha_Inicio & "'"
                    _Fecha_Fin = ""
                End If
                If strlestadoinc = "Pendientes" Then
                    strlestadoinc = " and (estado= 'Abierto' OR estado='No Contactado' OR estado='Programado' OR estado='Gestionado' OR estado='Seguimiento')"
                ElseIf strlestadoinc = "Total" Then
                    strlestadoinc = ""
                Else
                    strlestadoinc = " and estado= '" & strlestadoinc & "' "
                End If

                If _Campa = "Datos" Then 'DATOS
                    Datos = " and (Bandeja = 'Datos' or Bandeja like '%Bold%')"
                ElseIf _Campa = "BSCS" Then 'BSCS
                    Datos = " and (Bandeja = 'BSCS')"
                ElseIf _Campa = "TSF - PQR" Then 'TSF y PQR
                    Datos = " and (Bandeja like '%smart%' or Bandeja like '%Control%' or Bandeja like '%NOFORMA%')"

                ElseIf _Campa = "Desactivacion" Then
                    cms.CommandText = "Select id_Bandeja_Falla_Desactivacion_D_V as Caso,fc_Reg as [Fecha Resgistro],Min,Estado,Usuario_Asigna as Asignacion,'Desactivacion' as Bandeja from Bandeja_Falla_Desactivacion_D_V where Convert(date,fc_reg) " & _Fecha_Inicio & _Fecha_Fin.Replace("fcreporte", "fc_reg") & "" & strlestadoinc
                ElseIf _Campa = "Dilo" Then
                    cms.CommandText = "select idcaso as Caso,fcreporte as[Fecha registro],telcontacto as Min,Estado,Usuario_Asigna as Asignacion,'Dilo' as Bandeja from Bandeja_alt where Convert(date,fcreporte)" & _Fecha_Inicio & _Fecha_Fin & "" & strlestadoinc
                End If

                If _Campa = "Datos" Or _Campa = "BSCS" Or _Campa = "TSF - PQR" Then
                    cms.CommandText = "select cas_id as Caso,cas_fecha_registro as [Fecha registro],min_ac as min,Estado,lapso as Asignacion, Bandeja from Bandeja where Convert(date,cas_fecha_registro)" & _Fecha_Inicio & _Fecha_Fin.Replace("fcreporte", "cas_fecha_registro") & "" & strlestadoinc & Datos
                End If

            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Cantidad = dts.Tables(0).Columns.Count
            _Area = dts.Tables(0).Rows.Count
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

