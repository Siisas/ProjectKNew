Public Class clsFormacion

    Protected _validacion As String
    Protected _Fecha_Actual As String = DateTime.Now.ToString("dd/MM/yyyy")
    Protected Fecha_Actual_Hora As String = DateTime.Now.ToString("HH:mm:ss")
    Protected _id As String
    Protected _usuario As String
    Protected _Tipo_Formacion As String
    Protected _Area As String
    Protected _fecha As String
    Protected _fecha2 As String
    Protected _tema As String
    Protected _Observacion As String
    Protected _Prioridad As String
    Protected _Numero_Personas As String
    Protected _Lugar As String
    Protected _Formador As String

    Public Property Fecha_Actual As String
        Get
            Return _Fecha_Actual
        End Get
        Set(ByVal value As String)
            _Fecha_Actual = value
        End Set
    End Property
    Public Property validacion As String
        Get
            Return _validacion
        End Get
        Set(ByVal value As String)
            _validacion = value
        End Set
    End Property
    Public Property id As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property
    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Public Property Tipo_Formacion As String
        Get
            Return _Tipo_Formacion
        End Get
        Set(ByVal value As String)
            _Tipo_Formacion = value
        End Set
    End Property
    Public Property fecha As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property
    Public Property fecha2 As String
        Get
            Return _fecha2
        End Get
        Set(ByVal value As String)
            _fecha2 = value
        End Set
    End Property
    Public Property tema As String
        Get
            Return _tema
        End Get
        Set(ByVal value As String)
            _tema = value
        End Set
    End Property
    Public Property observacion As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property
    Public Property area As String
        Get
            Return _Area
        End Get
        Set(ByVal value As String)
            _Area = value
        End Set
    End Property
    Public Property prioridad As String
        Get
            Return _Prioridad
        End Get
        Set(ByVal value As String)
            _Prioridad = value
        End Set
    End Property
    Public Property Numero_Personas As String
        Get
            Return _Numero_Personas
        End Get
        Set(ByVal value As String)
            _Numero_Personas = value
        End Set
    End Property
    Public Property Lugar As String
        Get
            Return _Lugar
        End Get
        Set(ByVal value As String)
            _Lugar = value
        End Set
    End Property
    Public Property Formador As String
        Get
            Return _Formador
        End Get
        Set(ByVal value As String)
            _Formador = value
        End Set
    End Property

    Public Function cargar_drl() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If validacion = "1" Then
                cms.CommandText = "SELECT * FROM Archivo_Complemento where pertenece='Formacion_Tipos' or pertenece='- Seleccione -' order by Nombre"
            End If
            If validacion = "2" Then
                cms.CommandText = "SELECT * FROM Archivo_Complemento where pertenece='Formacion_Area' or pertenece='- Seleccione -' order by Nombre"
            End If
            If validacion = "3" Then
                cms.CommandText = "SELECT * FROM Archivo_Complemento where pertenece='Formacion_Estado' or pertenece='- Seleccione -' order by Nombre"
            End If
            If validacion = "4" Then
                cms.CommandText = "SELECT * FROM Archivo_Complemento where pertenece='Prioridad' or pertenece='- Seleccione -' order by Nombre"
            End If
            If validacion = "5" Then
                cms.CommandText = "SELECT * FROM Archivo_Complemento where pertenece='Formacion_Estado' and Nombre <> 'Asignado' or pertenece='- Seleccione -' order by Nombre"
            End If
            If validacion = "6" Then
                cms.CommandText = "SELECT * FROM Archivo_Complemento where pertenece='Formacion_Lugar' or pertenece='- Seleccione -' order by Nombre"
            End If
            If validacion = "7" Then
                cms.CommandText = "select P.Usuario_Plataforma from Plataforma P  where  Usuario_Plataforma like '%@%' AND Fk_codnom = (select codigo from personal where idusuario  = '" & observacion & "')"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If validacion = "7" Then
                If dts.Tables(0).Rows.Count > 0 Then
                    If dts.Tables(0).Rows(0).Item("Usuario_Plataforma") Is DBNull.Value Then
                        observacion = ""
                    Else
                        observacion = dts.Tables(0).Rows(0).Item("Usuario_Plataforma")
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

    Public Sub Ingreso_Solicitud_Formacion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If validacion = "Registro_Formacion" Then
                cms.CommandText = "insert into  Solicitud_Formacion (Id_Usuario,Fc_Ejecucion,Tipo_Formacion,Prioridad,Tema,Area_Solicita,Observacion,Estado,Numero_Personas,Lugar) values (@usuario,@fecha,@tipo_formacion,@prioridad,@tema,@area,@observacion,'Sin Asignar',@n_personas,@lugar)"
                cms.Parameters.Add("@tipo_formacion", SqlDbType.VarChar, 50).Value = Tipo_Formacion
                cms.Parameters.Add("@prioridad", SqlDbType.NVarChar, 50).Value = prioridad
                cms.Parameters.Add("@area", SqlDbType.VarChar, 50).Value = area
                cms.Parameters.Add("@tema", SqlDbType.NVarChar, 50).Value = tema
                cms.Parameters.Add("@n_personas", SqlDbType.VarChar, 4).Value = _Numero_Personas
                cms.Parameters.Add("@lugar", SqlDbType.VarChar, 50).Value = Lugar
            End If
            If validacion = "Registro_Asignacion" Then
                cms.CommandText = "insert into  Asignacion_Formacion (Id_Solicitud_Formacion,Id_Usuario,Formador_Asignado,Fecha_Ejecucion,Lugar,Observacion) values (@Id,@usuario,@Formador_Asignado,@fecha,@Lugar,@observacion)"
                cms.Parameters.Add("@Id", SqlDbType.Int).Value = id
                cms.Parameters.Add("@Formador_Asignado", SqlDbType.NVarChar, 50).Value = tema
                cms.Parameters.Add("@Lugar", SqlDbType.NVarChar, 50).Value = prioridad  
            End If
            If validacion = "Actualizacion_Estado" Then
                cms.CommandText = "Update  Solicitud_Formacion set Estado = 'Asignado', Lugar = '" & prioridad & "' , Fc_Ejecucion = '" & fecha & "' where Id_Solicitud_Formacion = " & id
            End If
            If validacion = "Registro_Respuesta" Then
                cms.CommandText = "Insert into Respuesta_formacion (Id_Solicitud_Formacion,Id_Usuario,Estado,Observacion,Grupo,Modulo) values (@Id,@usuario,@Estado,@observacion,@Grupo,@Modulo)"
                cms.Parameters.Add("@Id", SqlDbType.Int).Value = id
                cms.Parameters.Add("@Estado", SqlDbType.VarChar).Value = tema
                cms.Parameters.Add("@Grupo", SqlDbType.VarChar).Value = prioridad
                cms.Parameters.Add("@Modulo", SqlDbType.VarChar).Value = Numero_Personas
            End If
            If fecha <> "" Then
                cms.Parameters.Add("@fecha", SqlDbType.VarChar, 50).Value = fecha
            End If
            cms.Parameters.Add("@usuario", SqlDbType.VarChar, 30).Value = Usuario
            cms.Parameters.Add("@observacion", SqlDbType.NVarChar).Value = observacion
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

    Public Function consultas() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If validacion = "Validar_Cerrar" Then
                cms.CommandText = "select Id_Formacion,estado from Formaciones where estado <> 'cerrado' or estado is null and Id_Formacion = " & id
            End If
            If validacion = "Buscar_Id" Then
                cms.CommandText = "SELECT MAX(Id_Solicitud_Formacion) AS id  from  Solicitud_Formacion"
            End If
            If validacion = "Buscar_Todos" Then
                cms.CommandText = "Select * from Solicitud_Formacion"
            End If
            If validacion = "Buscar_Todos2" Then
                cms.CommandText = "Select * from Solicitud_Formacion where Estado = 'Sin Asignar'"
            End If
            If validacion = "Buscar_Todos3" Then
                cms.CommandText = " Select F.ID_Formaciones,F.ID_Formacion,F.Grupo,F.Modulo,F.N_Personas,F.Fecha,F.formador,F.Estado,SF.Tipo_Formacion, SF.Prioridad,SF.Tema, SF.Area_Solicita, SF.Lugar,SF.Estado as 'Estado_SF' from Solicitud_Formacion SF inner join Formaciones F on F.ID_Formacion = SF.Id_Solicitud_Formacion where (F.estado <> 'Cerrado' and  sf.estado <> 'Cerrado' or F.estado is null) and F.Formador = '" & Usuario & "'"
            End If
            If validacion = "Respuesta" Then
                cms.CommandText = "select * from Respuesta_formacion where id_Solicitud_Formacion = " & id
            End If
            If validacion = "Respuesta_Asignacion" Then
                cms.CommandText = "select * from Asignacion_formacion where id_Solicitud_Formacion = " & id
            End If
            If validacion = "Buscar_Solicitudes_Id" Then
                cms.CommandText = "Select * from Solicitud_Formacion where  estado <> 'Cerrado' and  Id_Usuario = " & "'" & Usuario & "'"
            End If
            If validacion = "Buscar_Id_Por_Usuario" Then
                cms.CommandText = "Select * from Solicitud_Formacion where Id_Solicitud_Formacion = " & id & " and  Id_Usuario = " & "'" & Usuario & "'"
            End If
            If validacion = "Filtros" Then
                If id <> "" Then 'consulta por id
                    cms.CommandText = "Select * from Solicitud_Formacion where Id_Solicitud_Formacion = " & id
                End If
                If prioridad <> "" Then 'consulta por prioridad
                    cms.CommandText = "Select * from Solicitud_Formacion where Prioridad = " & "'" & prioridad & "'"
                End If
                If fecha <> "" Then 'consulta por fecha inicio
                    cms.CommandText = "Select * from Solicitud_Formacion where Convert(Date, Fc_Reg) = " & "'" & fecha & "'"
                End If
                If fecha2 <> "" Then 'consulta por fecha fin
                    cms.CommandText = "Select * from Solicitud_Formacion where Convert( Date, Fc_Reg) <= '" & fecha2 & "'"
                End If
                If fecha <> "" And fecha2 <> "" Then ' consulta por fechas
                    cms.CommandText = "Select * from Solicitud_Formacion where  Convert( Date, Fc_Reg) >= '" & fecha & "' and Convert ( Date, Fc_Reg) <= '" & fecha2 & "'"
                End If
                If fecha <> "" And fecha2 <> "" And Usuario <> "" Then ' consulta por fechas y mis casos
                    cms.CommandText = "Select * from Solicitud_Formacion where  Convert( Date, Fc_Reg) >= '" & fecha & "' Convert ( Date, Fc_Reg) <= '" & fecha2 & "' and Id_Usuario = " & "'" & Usuario & "'"
                End If
                If observacion <> "" Then 'consulta por estado
                    cms.CommandText = "Select * from Solicitud_Formacion where Estado = '" & observacion & "'"
                End If
                If fecha <> "" And fecha2 <> "" And observacion <> "" Then ' consulta por fechas y estado
                    cms.CommandText = "Select * from Solicitud_Formacion where  Convert( Date, Fc_Reg) >= '" & fecha & "' Convert ( Date, Fc_Reg) <= '" & fecha2 & "' and Estado = '" & observacion & "'"
                End If
                If Usuario <> "" Then 'consulta por usuario
                    cms.CommandText = "Select * from Solicitud_Formacion where  estado <> 'Cerrado' and Id_Usuario = '" & Usuario & "'"
                End If

                If Formador <> "" Then ' consulta por formador
                    cms.CommandText = "Select F.ID_Formaciones,F.ID_Formacion,F.Grupo,F.Modulo,F.N_Personas,F.Fecha,F.formador,F.Estado,SF.Tipo_Formacion, SF.Prioridad,SF.Tema, SF.Area_Solicita, SF.Lugar,SF.Estado from Solicitud_Formacion SF inner join Formaciones F on F.ID_Formacion = SF.Id_Solicitud_Formacion where  (F.estado <> 'Cerrado' and  sf.estado <> 'Cerrado' or F.estado is null) and F.Formador  =  '" & Formador & "'"
                End If
            End If
            If validacion = "Filtros_2" Then
                If id <> "" Then 'consulta por id
                    cms.CommandText = "Select * from Solicitud_Formacion where estado <> 'Cerrado' and  Id_Solicitud_Formacion = " & id & " and Id_Usuario = " & "'" & Usuario & "'"
                End If
                If prioridad <> "" Then 'consulta por prioridad
                    cms.CommandText = "Select * from Solicitud_Formacion where estado <> 'Cerrado' and Prioridad = " & "'" & prioridad & "'" & " and Id_Usuario = " & "'" & Usuario & "'"
                End If
                If Usuario <> "" Then 'consulta por usuario
                    cms.CommandText = "Select * from Solicitud_Formacion where estado <> 'Cerrado' and Id_Usuario = " & "'" & Usuario & "'"
                End If
                If fecha <> "" Then 'consulta por fecha inicio
                    cms.CommandText = "Select * from Solicitud_Formacion where estado <> 'Cerrado' and Convert(Date, Fc_Reg) = " & "'" & fecha & "'" & " and Id_Usuario = " & "'" & Usuario & "'"
                End If
                If fecha2 <> "" Then 'consulta por fecha fin
                    cms.CommandText = "Select * from Solicitud_Formacion where  estado <> 'Cerrado' and Convert( Date, Fc_Reg) <= '" & fecha2 & "' and Id_Usuario = " & "'" & Usuario & "'"
                End If
                If fecha <> "" And fecha2 <> "" Then ' consulta por fechas
                    cms.CommandText = "Select * from Solicitud_Formacion where estado <> 'Cerrado' and Convert( Date, Fc_Reg) >= '" & fecha & "' Convert ( Date, Fc_Reg) <= '" & fecha2 & "' and Id_Usuario = " & "'" & Usuario & "'"
                End If
                If fecha <> "" And fecha2 <> "" And Usuario <> "" Then ' consulta por fechas y mis casos
                    cms.CommandText = "Select * from Solicitud_Formacion where  Convert( Date, Fc_Reg) >= '" & fecha & "' Convert ( Date, Fc_Reg) <= '" & fecha2 & "' and Id_Usuario = " & "'" & Usuario & "'"
                End If
            End If
            If validacion = "Filtros_3" Then
                If id <> "" Then 'consulta por id
                    cms.CommandText = "Select SF.Estado as 'Estado_SF', SF.*,F.* from Solicitud_Formacion SF inner join Formaciones f on SF.Id_Solicitud_Formacion = F.ID_Formacion  where SF.Id_Solicitud_Formacion =  " & id & " and F.Formador = " & "'" & Usuario & "'"
                End If
                If prioridad <> "" Then 'consulta por prioridad
                    cms.CommandText = "Select SF.Estado as 'Estado_SF', SF.*,F.* from Solicitud_Formacion SF inner join Formaciones f on SF.Id_Solicitud_Formacion = F.ID_Formacion where SF.Prioridad = " & "'" & prioridad & "'" & " and F.Formador = " & "'" & Usuario & "'"
                End If
                If Usuario <> "" Then 'consulta por usuario
                    cms.CommandText = "Select SF.Estado as 'Estado_SF',SF.*,F.* from Solicitud_Formacion SF inner join Formaciones f on SF.Id_Solicitud_Formacion = F.ID_Formacion where SF.Id_Usuario = " & "'" & Usuario & "'"
                End If
                If fecha <> "" Then 'consulta por fecha inicio
                    cms.CommandText = "Select SF.Estado as 'Estado_SF',SF.*,F.* from Solicitud_Formacion SF inner join Formaciones f on SF.Id_Solicitud_Formacion = F.ID_Formacion where Convert(Date, SF.Fc_Reg) = " & "'" & fecha & "'" & " and F.Formador = " & "'" & Usuario & "'"
                End If
                If fecha2 <> "" Then 'consulta por fecha fin
                    cms.CommandText = "Select SF.Estado as 'Estado_SF',SF.*,F.* from Solicitud_Formacion SF inner join Formaciones f on SF.Id_Solicitud_Formacion = F.ID_Formacion where Convert( Date, SF.Fc_Reg) <= '" & fecha2 & "' and F.Formador = " & "'" & Usuario & "'"
                End If
                If fecha <> "" And fecha2 <> "" Then ' consulta por fechas
                    cms.CommandText = "Select SF.Estado as 'Estado_SF',SF.*,F.* from Solicitud_Formacion SF inner join Formaciones f on SF.Id_Solicitud_Formacion = F.ID_Formacion where  Convert( Date, SF.Fc_Reg) >= '" & fecha & "' Convert ( Date, SF.Fc_Reg) <= '" & fecha2 & "' and F.Formador = " & "'" & Usuario & "'"
                End If
                If fecha <> "" And fecha2 <> "" And Usuario <> "" Then ' consulta por fechas y mis casos
                    cms.CommandText = "Select SF.Estado as 'Estado_SF',SF.*,F.* from Solicitud_Formacion SF inner join Formaciones f on SF.Id_Solicitud_Formacion = F.ID_Formacion where  Convert( Date, SF.Fc_Reg) >= '" & fecha & "' Convert ( Date, SF.Fc_Reg) <= '" & fecha2 & "' and F.Formador = " & "'" & Usuario & "'"
                End If
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If validacion = "Buscar_Grupo" Then
                If dts.Tables(0).Rows.Count > 0 Then
                    If dts.Tables(0).Rows(0).Item("Grupo") Is DBNull.Value Then
                        observacion = ""
                    Else
                        observacion = dts.Tables(0).Rows(0).Item("Grupo")
                    End If
                End If
            End If
            If _validacion = "Buscar_Id" Then
                id = dts.Tables(0).Rows(0).Item("id")
            End If
            area = dts.Tables(0).Rows.Count
            If dts.Tables(0).Rows.Count = 0 Then
                validacion = "1"
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

    Public Function Consulta_Usuario() As DataSet
        Dim cn2 As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn2.Open()
            cms.CommandText = "Select ac.Nombre, u.nombreu from  admin_cham.dbo.Archivo_Complemento ac inner join datosclaro.dbo.usuarios u on ac.nombre = u.idusuario    where ac.Pertenece = 'Formacion_Formadores' union Select '- Seleccione -' as nombreu, '- Seleccione -' as nombre "
            cms.Connection = cn2
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Return dts
            Exit Try
        Catch ex As Exception
            Throw ex
        Finally
            cn2.Close()
        End Try
    End Function

    Public Sub Actualizacion_Solicitud_Formacion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Update  Solicitud_Formacion set Numero_Personas = '" & tema & "' where Id_Solicitud_Formacion = " & id
            If validacion = "Cerrar Formacion" Then
                cms.CommandText = "Update Solicitud_Formacion set Estado = 'Cerrado' where Id_Solicitud_Formacion = " & id
            End If
            If validacion = "Estado Modulo" Then
                cms.CommandText = "Update Formaciones set Estado = '" & tema & "' where Id_Formacion = " & id & " and ID_Formaciones = " & Formador
            End If
            If validacion = "Insertar Formacion" Then
                cms.CommandText = "Insert Formaciones (Id_Usuario,ID_Formacion,Grupo,Modulo,N_Personas,Fecha,Formador) values (@Id_Usuario,@ID_Formacion,@Grupo,@Modulo,@N_Personas,@Fecha,@Formador) "
                cms.Parameters.Add("@Id_Usuario", SqlDbType.VarChar, 30).Value = Usuario
                cms.Parameters.Add("@ID_Formacion", SqlDbType.VarChar, 30).Value = id
                cms.Parameters.Add("@Grupo", SqlDbType.VarChar, 30).Value = tema
                cms.Parameters.Add("@Modulo", SqlDbType.VarChar, 30).Value = Lugar
                cms.Parameters.Add("@N_Personas", SqlDbType.VarChar, 30).Value = Numero_Personas
                cms.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fecha
                cms.Parameters.Add("@Formador", SqlDbType.VarChar, 30).Value = Formador
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

End Class
