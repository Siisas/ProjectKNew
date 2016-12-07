Public Class clssolicitud
    Protected strlarchivo As String
    Protected strlidsolic As String
    Protected strltiposolic As String
    Protected strlprioridad As String
    Protected strlobs As String
    Protected strlidusuario As String
    Protected strlfcreg As String
    Protected strlcantidad As String
    Protected strlidreg As String
    Protected strlestado As String
    Protected strlfcprobable As String
    Protected strlidasignado As String
    Public Property idasignado() As String
        Get
            Return strlidasignado
        End Get
        Set(ByVal Value As String)
            strlidasignado = Value
        End Set
    End Property
    Public Property fcprobable() As String
        Get
            Return strlfcprobable
        End Get
        Set(ByVal Value As String)
            strlfcprobable = Value
        End Set
    End Property
    Public Property estado() As String
        Get
            Return strlestado
        End Get
        Set(ByVal Value As String)
            strlestado = Value
        End Set
    End Property
    Public Property idreg() As String
        Get
            Return strlidreg
        End Get
        Set(ByVal Value As String)
            strlidreg = Value
        End Set
    End Property
    Public Property cantidad() As String
        Get
            Return strlcantidad
        End Get
        Set(ByVal Value As String)
            strlcantidad = Value
        End Set
    End Property
    Public Property fcreg() As String
        Get
            Return strlfcreg
        End Get
        Set(ByVal Value As String)
            strlfcreg = Value
        End Set
    End Property
    Public Property idusuario() As String
        Get
            Return strlidusuario
        End Get
        Set(ByVal Value As String)
            strlidusuario = Value
        End Set
    End Property
    Public Property obs() As String
        Get
            Return strlobs
        End Get
        Set(ByVal Value As String)
            strlobs = Value
        End Set
    End Property
    Public Property prioridad() As String
        Get
            Return strlprioridad
        End Get
        Set(ByVal Value As String)
            strlprioridad = Value
        End Set
    End Property
    Public Property tiposolic() As String
        Get
            Return strltiposolic
        End Get
        Set(ByVal Value As String)
            strltiposolic = Value
        End Set
    End Property
    Public Property idsolic() As String
        Get
            Return strlidsolic
        End Get
        Set(ByVal Value As String)
            strlidsolic = Value
        End Set
    End Property
    Public Property archivo() As String
        Get
            Return strlarchivo
        End Get
        Set(ByVal Value As String)
            strlarchivo = Value
        End Set
    End Property
    Public Sub registrosolic()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO MC_Detallesolicitud(idtipo,idprioridad,obssolicitud,arc_solicitud,idusuario_solic,fcreg_solic,estado) values(@strltiposolic,@strlprioridad,@strlobs,@strlarchivo,@strlidusuario,@strlfcreg,'1')"
            cms.Parameters.Add("@strltiposolic", SqlDbType.Int).Value = strltiposolic
            cms.Parameters.Add("@strlprioridad", SqlDbType.Int).Value = strlprioridad
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlarchivo", SqlDbType.VarChar, 255).Value = strlarchivo
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
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
    Public Function traeconsecutivo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idsolicitud FROM MC_Detallesolicitud where idtipo=@strltiposolic and idprioridad=@strlprioridad and idusuario_solic=@strlidusuario order by idsolicitud desc"
            cms.Parameters.Add("@strlprioridad", SqlDbType.Int).Value = Me.strlprioridad
            cms.Parameters.Add("@strltiposolic", SqlDbType.Int).Value = Me.strltiposolic
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            cantidad = dtsrecepcion.Tables(0).Rows.Count
            If cantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("idsolicitud") Is System.DBNull.Value Then
                    idreg = " "
                Else
                    idreg = dtsrecepcion.Tables(0).Rows(0).Item("idsolicitud")
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
    Public Function consultasolic() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idasignado,idsolicitud, MC_Detallesolicitud.idtipo,descsolicitud, MC_Detallesolicitud.idprioridad, descprioridad, obssolicitud, arc_solicitud, idusuario_solic, fcreg_solic, estado, descestado, fcprobable FROM MC_Detallesolicitud INNER JOIN MC_Prioridad ON MC_Detallesolicitud.idprioridad = MC_Prioridad.idprioridad INNER JOIN MC_Tiposolicitud ON MC_Detallesolicitud.idtipo = MC_Tiposolicitud.idtipo INNER JOIN MC_Estado ON MC_Detallesolicitud.estado = MC_Estado.idestado where idsolicitud=@strlidreg"
            cms.Parameters.Add("@strlidreg", SqlDbType.Int).Value = Me.strlidreg
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            cantidad = dtsrecepcion.Tables(0).Rows.Count
            If cantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("idasignado") Is System.DBNull.Value Then
                    strlidasignado = "- Seleccione -"
                Else
                    strlidasignado = dtsrecepcion.Tables(0).Rows(0).Item("idasignado")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("idsolicitud") Is System.DBNull.Value Then
                    idreg = " "
                Else
                    idreg = dtsrecepcion.Tables(0).Rows(0).Item("idsolicitud")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("descsolicitud") Is System.DBNull.Value Then
                    strltiposolic = " "
                Else
                    strltiposolic = dtsrecepcion.Tables(0).Rows(0).Item("descsolicitud")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("descprioridad") Is System.DBNull.Value Then
                    strlprioridad = " "
                Else
                    strlprioridad = dtsrecepcion.Tables(0).Rows(0).Item("descprioridad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("obssolicitud") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obssolicitud")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("arc_solicitud") Is System.DBNull.Value Then
                    strlarchivo = " "
                Else
                    strlarchivo = dtsrecepcion.Tables(0).Rows(0).Item("arc_solicitud")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strlestado = " "
                Else
                    strlestado = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("descestado") Is System.DBNull.Value Then
                    strlestado = " "
                Else
                    strlestado = dtsrecepcion.Tables(0).Rows(0).Item("descestado")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fcprobable") Is System.DBNull.Value Then
                    strlfcprobable = " "
                Else
                    strlfcprobable = dtsrecepcion.Tables(0).Rows(0).Item("fcprobable")
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
    Public Sub registroseguimiento()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO MC_CRMSolicitudes(idsolicitud,estado,obsrespuesta,idusuario,fcreg,Fuente,archivoseg) values(@strlidreg,'2',@strlobs,@strlidusuario,@strlfcreg,'Claro',@strlarchivo)"
            cms.Parameters.Add("@strlidreg", SqlDbType.Int).Value = strlidreg
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlarchivo", SqlDbType.VarChar, 255).Value = strlarchivo
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
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
    Public Function consultaseguimientos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from MC_CRMSolicitudes inner join MC_Estado on MC_Estado.idestado=MC_CRMSolicitudes.estado where idsolicitud=@strlidreg"
            cms.Parameters.Add("@strlidreg", SqlDbType.Int).Value = Me.strlidreg
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaseguimientosclaro() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from MC_CRMSolicitudes inner join MC_Estado on MC_Estado.idestado=MC_CRMSolicitudes.estado where idsolicitud=@strlidreg and interno is null"
            cms.Parameters.Add("@strlidreg", SqlDbType.Int).Value = Me.strlidreg
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultasolicitudes() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select idasignado, fcasig,fcreal,idsolicitud, MC_Tiposolicitud.idtipo, descsolicitud, MC_Prioridad.idprioridad, descprioridad, obssolicitud, arc_solicitud,idusuario_solic,fcreg_solic,estado, descestado, fcprobable from MC_Detallesolicitud inner join MC_Tiposolicitud on MC_Tiposolicitud.idtipo=MC_Detallesolicitud.idtipo inner join MC_Prioridad on MC_Prioridad.idprioridad=MC_Detallesolicitud.idprioridad inner join MC_Estado on MC_Estado.idestado=MC_Detallesolicitud.estado"
            If strlidreg <> Nothing Then
                cms.CommandText = "select idasignado, fcasig,fcreal,idsolicitud, MC_Tiposolicitud.idtipo, descsolicitud, MC_Prioridad.idprioridad, descprioridad, obssolicitud, arc_solicitud,idusuario_solic,fcreg_solic,estado, descestado, fcprobable from MC_Detallesolicitud inner join MC_Tiposolicitud on MC_Tiposolicitud.idtipo=MC_Detallesolicitud.idtipo inner join MC_Prioridad on MC_Prioridad.idprioridad=MC_Detallesolicitud.idprioridad inner join MC_Estado on MC_Estado.idestado=MC_Detallesolicitud.estado where idsolicitud=@strlidreg"
                cms.Parameters.Add("@strlidreg", SqlDbType.Decimal).Value = Me.strlidreg
            End If
            If strltiposolic <> Nothing Then
                cms.CommandText = "select idasignado, fcasig,fcreal,idsolicitud, MC_Tiposolicitud.idtipo, descsolicitud, MC_Prioridad.idprioridad, descprioridad, obssolicitud, arc_solicitud,idusuario_solic,fcreg_solic,estado, descestado, fcprobable from MC_Detallesolicitud inner join MC_Tiposolicitud on MC_Tiposolicitud.idtipo=MC_Detallesolicitud.idtipo inner join MC_Prioridad on MC_Prioridad.idprioridad=MC_Detallesolicitud.idprioridad inner join MC_Estado on MC_Estado.idestado=MC_Detallesolicitud.estado where MC_Tiposolicitud.idtipo=@strltiposolic"
                cms.Parameters.Add("@strltiposolic", SqlDbType.Int).Value = Me.strltiposolic
            End If
            If strlprioridad <> Nothing Then
                cms.CommandText = "select idasignado, fcasig,fcreal,idsolicitud, MC_Tiposolicitud.idtipo, descsolicitud, MC_Prioridad.idprioridad, descprioridad, obssolicitud, arc_solicitud,idusuario_solic,fcreg_solic,estado, descestado, fcprobable from MC_Detallesolicitud inner join MC_Tiposolicitud on MC_Tiposolicitud.idtipo=MC_Detallesolicitud.idtipo inner join MC_Prioridad on MC_Prioridad.idprioridad=MC_Detallesolicitud.idprioridad inner join MC_Estado on MC_Estado.idestado=MC_Detallesolicitud.estado where MC_Prioridad.idprioridad=@strlprioridad"
                cms.Parameters.Add("@strlprioridad", SqlDbType.Int).Value = Me.strlprioridad
            End If
            If strlestado <> Nothing Then
                cms.CommandText = "select idasignado, fcasig,fcreal,idsolicitud, MC_Tiposolicitud.idtipo, descsolicitud, MC_Prioridad.idprioridad, descprioridad, obssolicitud, arc_solicitud,idusuario_solic,fcreg_solic,estado, descestado, fcprobable from MC_Detallesolicitud inner join MC_Tiposolicitud on MC_Tiposolicitud.idtipo=MC_Detallesolicitud.idtipo inner join MC_Prioridad on MC_Prioridad.idprioridad=MC_Detallesolicitud.idprioridad inner join MC_Estado on MC_Estado.idestado=MC_Detallesolicitud.estado where estado=@strlestado"
                cms.Parameters.Add("@strlestado", SqlDbType.Int).Value = Me.strlestado
            End If
            If strlidusuario <> Nothing Then
                cms.CommandText = "select idasignado, fcasig,idasignado,fcreal,idsolicitud, MC_Tiposolicitud.idtipo, descsolicitud, MC_Prioridad.idprioridad, descprioridad, obssolicitud, arc_solicitud,idusuario_solic,fcreg_solic,estado, descestado, fcprobable from MC_Detallesolicitud inner join MC_Tiposolicitud on MC_Tiposolicitud.idtipo=MC_Detallesolicitud.idtipo inner join MC_Prioridad on MC_Prioridad.idprioridad=MC_Detallesolicitud.idprioridad inner join MC_Estado on MC_Estado.idestado=MC_Detallesolicitud.estado where estado<>4 and idasignado=@strlidusuario"
                cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = Me.strlidusuario
            End If
            If strlidusuario <> Nothing And strlidreg <> Nothing Then
                cms.CommandText = "select idasignado,fcreal,idsolicitud, MC_Tiposolicitud.idtipo, descsolicitud, MC_Prioridad.idprioridad, descprioridad, obssolicitud, arc_solicitud,idusuario_solic,fcreg_solic,estado, descestado, fcprobable from MC_Detallesolicitud inner join MC_Tiposolicitud on MC_Tiposolicitud.idtipo=MC_Detallesolicitud.idtipo inner join MC_Prioridad on MC_Prioridad.idprioridad=MC_Detallesolicitud.idprioridad inner join MC_Estado on MC_Estado.idestado=MC_Detallesolicitud.estado where estado<>4 and idasignado=@strlidusuario and idsolicitud=@strlidreg"
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub Actualizaestado()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If strlestado = 2 Then
                cms.CommandText = "Update MC_Detallesolicitud set estado=@strlestado where (estado=1 or estado=2) and idsolicitud=@strlidreg"
                If strlfcprobable <> "" Then
                    cms.CommandText = "Update MC_Detallesolicitud set estado=@strlestado, fcprobable=@strlfcprobable where (estado=1 or estado=2) and idsolicitud=@strlidreg"
                    cms.Parameters.Add("@strlfcprobable", SqlDbType.Date).Value = Me.strlfcprobable
                End If
            End If
            If strlestado = 3 Then
                cms.CommandText = "Update MC_Detallesolicitud set estado=@strlestado where (estado=1 or estado=2) and idsolicitud=@strlidreg"
                If strlfcprobable <> "" Then
                    cms.CommandText = "Update MC_Detallesolicitud set estado=@strlestado, fcprobable=@strlfcprobable where (estado=1 or estado=2) and idsolicitud=@strlidreg"
                    cms.Parameters.Add("@strlfcprobable", SqlDbType.Date).Value = Me.strlfcprobable
                End If
            End If
            If strlestado = 4 Then
                cms.CommandText = "Update MC_Detallesolicitud set estado=@strlestado, fcreal=@strlfcreg where (estado=1 or estado=2 or estado=3) and idsolicitud=@strlidreg"
                cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = Me.strlfcreg
                If strlfcprobable <> "" Then
                    cms.CommandText = "Update MC_Detallesolicitud set estado=@strlestado, fcprobable=@strlfcprobable, fcreal=@strlfcreg where (estado=1 or estado=2 or estado=3) and idsolicitud=@strlidreg"
                    cms.Parameters.Add("@strlfcprobable", SqlDbType.Date).Value = Me.strlfcprobable
                End If
            End If
            cms.Parameters.Add("@strlestado", SqlDbType.Int).Value = Me.strlestado
            cms.Parameters.Add("@strlidreg", SqlDbType.Decimal).Value = Me.strlidreg
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
    Public Sub registroseguimientokam()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO MC_CRMSolicitudes(idsolicitud,estado,obsrespuesta,idusuario,fcreg,Fuente,archivoseg) values(@strlidreg,@strlestado,@strlobs,@strlidusuario,@strlfcreg,'Kamilion',@strlarchivo)"
            cms.Parameters.Add("@strlidreg", SqlDbType.Int).Value = strlidreg
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlarchivo", SqlDbType.VarChar, 255).Value = strlarchivo
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlestado", SqlDbType.Int).Value = strlestado
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
    Public Sub registroseguimientokamasig()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO MC_CRMSolicitudes(idsolicitud,estado,obsrespuesta,idusuario,fcreg,Fuente,archivoseg,interno) values(@strlidreg,@strlestado,@strlobs,@strlidusuario,@strlfcreg,'Kamilion',@strlarchivo,'Int')"
            cms.Parameters.Add("@strlidreg", SqlDbType.Int).Value = strlidreg
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlarchivo", SqlDbType.VarChar, 255).Value = strlarchivo
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlestado", SqlDbType.Int).Value = strlestado
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
