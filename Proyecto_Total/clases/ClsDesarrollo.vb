Public Class ClsDesarrollo
    '/****DECLARACION DE VARIABLES****/'
    Protected _Cantidad As Integer
    Protected _Validacion As String
    Protected _Tema As String
    Protected _Prioridad As String
    Protected _Area As String
    Protected _Solicitante As String
    Protected _Requerimientos As String
    Protected _IdUsuario As String
    Protected _Estado As String
    Protected _Codigo As String
    Protected _Fecha_Inicio As String
    Protected _Fecha_Fin As String
    Protected _Desarrollador As String
    Protected _Complejidad As String
    Protected _Operatividad As String
    Protected _Gestion As String
    '/****ENCAPSULACION DE VARIABLES****/'
    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property
    Public Property Validacion As String
        Get
            Return _Validacion
        End Get
        Set(ByVal value As String)
            _Validacion = value
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
    Public Property Area As String
        Get
            Return _Area
        End Get
        Set(ByVal value As String)
            _Area = value
        End Set
    End Property
    Public Property Solicitante As String
        Get
            Return _Solicitante
        End Get
        Set(ByVal value As String)
            _Solicitante = value
        End Set
    End Property
    Public Property Requerimientos As String
        Get
            Return _Requerimientos
        End Get
        Set(ByVal value As String)
            _Requerimientos = value
        End Set
    End Property
    Public Property IdUsuario As String
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As String)
            _IdUsuario = value
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
    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
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
    Public Property Fecha_Fin As String
        Get
            Return _Fecha_Fin
        End Get
        Set(ByVal value As String)
            _Fecha_Fin = value
        End Set
    End Property
    Public Property Desarrollador As String
        Get
            Return _Desarrollador
        End Get
        Set(ByVal value As String)
            _Desarrollador = value
        End Set
    End Property
    Public Property Complejidad As String
        Get
            Return _Complejidad
        End Get
        Set(ByVal value As String)
            _Complejidad = value
        End Set
    End Property
    Public Property Operatividad As String
        Get
            Return _Operatividad
        End Get
        Set(ByVal value As String)
            _Operatividad = value
        End Set
    End Property
    Public Property Gestion As String
        Get
            Return _Gestion
        End Get
        Set(ByVal value As String)
            _Gestion = value
        End Set
    End Property
    '/********************************************************************/'
    '/******************************METODOS******************************/'
    '/******************************************************************/'
    Public Sub Reg_Solicitud_Desarrollo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "INSERT INTO Desarrollo_Registro(Reg_Usu_Reg, Fk_Com_Est, Reg_Tem, Reg_Pri, Fk_Com_Are, Reg_Usu_Sol, Reg_Req) VALUES (@_IdUsuario,10,@_Tema,@_Prioridad,@_Area,@_Solicitante,@_Requerimientos)"
            cms.Parameters.Add("@_IdUsuario", SqlDbType.VarChar, 80).Value = _IdUsuario
            cms.Parameters.Add("@_Tema", SqlDbType.VarChar, 100).Value = _Tema
            cms.Parameters.Add("@_Prioridad", SqlDbType.VarChar, 80).Value = _Prioridad
            cms.Parameters.Add("@_Area", SqlDbType.VarChar, 100).Value = _Area
            cms.Parameters.Add("@_Solicitante", SqlDbType.VarChar, 200).Value = _Solicitante
            cms.Parameters.Add("@_Requerimientos", SqlDbType.VarChar, 1000).Value = _Requerimientos
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
    Public Sub Actualizar_Estado_Desarrollo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            '/*ASIGNACION*/
            cms.CommandText = "UPDATE Desarrollo_Registro SET Reg_Usu_Asi = @_IdUsuario , Reg_Usu_Des = @_Desarrollador, Fk_Com_Est = 9 WHERE Reg_cod = @_Codigo"
            If Validacion = "Escalado" Or Validacion = "Devuelto" Or Validacion = "Entregado" Then
                cms.CommandText = "UPDATE Desarrollo_Registro SET Reg_Usu_Des = @_Desarrollador, Fk_Com_Est = @_Estado WHERE Reg_num = @_Codigo"
            ElseIf Validacion <> "Escalado" And Validacion <> "Devuelto" And Validacion <> Nothing Then
                cms.CommandText = "UPDATE Desarrollo_Registro SET Fk_Com_Est = @_Estado WHERE Reg_num = @_Codigo"
            End If
            If _IdUsuario <> Nothing Then
                cms.Parameters.Add("@_IdUsuario", SqlDbType.VarChar, 50).Value = _IdUsuario
            Else
                cms.Parameters.AddWithValue("@_IdUsuario", DBNull.Value)
            End If
            If _Desarrollador <> Nothing Then
                cms.Parameters.Add("@_Desarrollador", SqlDbType.VarChar, 50).Value = _Desarrollador
            Else
                cms.Parameters.AddWithValue("@_Desarrollador", DBNull.Value)
            End If
            If _Estado <> Nothing Then
                cms.Parameters.Add("@_Estado", SqlDbType.VarChar, 50).Value = _Estado
            Else
                cms.Parameters.AddWithValue("@_Estado", DBNull.Value)
            End If
            cms.Parameters.Add("@_Codigo", SqlDbType.VarChar).Value = _Codigo
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
    Public Sub Reg_Gestion_Desarrollo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "INSERT INTO Desarrollo_Gestion(Ges_Usu_Reg, Fk_Reg_num, Fk_Com_Est, Ges_Obs, Fk_Com_Com, Fk_Com_Ope) VALUES (@_IdUsuario,@_Codigo,@_Estado,@_Gestion,@_Complejidad,@_Operatividad)"
            cms.Parameters.Add("@_IdUsuario", SqlDbType.VarChar, 80).Value = _IdUsuario
            cms.Parameters.Add("@_Codigo", SqlDbType.BigInt).Value = _Codigo
            cms.Parameters.Add("@_Estado", SqlDbType.BigInt).Value = _Estado
            cms.Parameters.Add("@_Gestion", SqlDbType.VarChar).Value = _Gestion
            cms.Parameters.Add("@_Complejidad", SqlDbType.BigInt).Value = _Complejidad
            cms.Parameters.Add("@_Operatividad", SqlDbType.BigInt).Value = _Operatividad
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
    '/********************************************************************/'
    '/*****************************FUNCIONES*****************************/'
    '/******************************************************************/'
    Public Function Consulta_Carga_Drls() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "Cargar_Area" Then '/*AREA*/
                cms.CommandText = "Select * from Desarrollo_Complemento WHERE Com_Per = 'AREA' OR Com_Cod = 0"
            ElseIf _Validacion = "Cargar_Prioridad" Then '/*PRIORIDAD*/
                cms.CommandText = "SELECT * from Desarrollo_Complemento WHERE Com_Per = 'PRIORIDAD' OR Com_Cod = 0"
            ElseIf _Validacion = "Cargar_Estado" Then '/*ESTADO*/
                cms.CommandText = "SELECT * from Desarrollo_Complemento WHERE Com_Per = 'ESTADO' OR Com_Cod = 0"
            ElseIf _Validacion = "Cargar_Complejidad" Then '/*COMPLEJIDAD*/
                cms.CommandText = "SELECT * from Desarrollo_Complemento WHERE Com_Per = 'COMPLEJIDAD' OR Com_Cod = 0"
            ElseIf _Validacion = "Cargar_Operatividad" Then '/*OPERATIVIDAD*/
                cms.CommandText = "SELECT * from Desarrollo_Complemento WHERE Com_Per = 'OPERATIVIDAD' OR Com_Cod = 0"
            ElseIf _Validacion = "Cargar_Desarrollador" Then '/*DESARROLLADOR*/
                cms.CommandText = "SELECT DC.*, U.nombreu  from Desarrollo_Complemento DC INNER JOIN datosclaro.dbo.usuarios U ON U.idusuario = DC.Com_Nom WHERE Com_Per = 'DEVELOPER' OR Com_Cod = 0"
            ElseIf _Validacion = "Cargar_Solicitante" Then '/*SOLICITANTE*/
                cms.CommandText = "SELECT idusuario, nombreu FROM datosclaro.dbo.usuarios WHERE (perfil = 1 OR perfil = 3 OR perfil = 38 OR perfil = 4 OR perfil = 40 OR perfil = 46 OR perfil = 91) and pwd <> 'R'"
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consultar_Codigo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT TOP 1 Reg_num, Reg_Cod from Desarrollo_Registro ORDER BY Reg_num DESC"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count
            If _Cantidad > 0 Then
                _Codigo = dtsrecepcion.Tables(0).Rows(0).Item("Reg_Cod")
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
    Public Function Consulta_Desarrollos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = ""
        If _Codigo <> "" Then
            WHERE = WHERE & " AND Reg_Cod = '" & _Codigo & "' "
        End If
        If _Prioridad <> "" Then
            WHERE = WHERE & " AND Reg_Pri = '" & _Prioridad & "' "
        End If
        If _Fecha_Inicio <> "" And _Fecha_Fin <> "" Then
            WHERE = WHERE & " AND Reg_Fch BETWEEN '" & _Fecha_Inicio & "' AND '" & _Fecha_Fin & "' "
        End If
        Try
            cn.Open()
            cms.CommandText = "SELECT Reg_Cod AS CODIGO, Reg_Fch AS FECHA, Reg_Usu_Reg, Reg_Tem AS TEMA, Reg_Pri AS PRIORIDAD, Reg_Req AS REQ, DC.Com_Nom AS ESTADO, Reg_Usu_Sol AS SOLICITA FROM Desarrollo_Registro INNER JOIN Desarrollo_Complemento DC ON DC.Com_Cod = Fk_Com_Est AND DC.Com_Per = 'ESTADO' WHERE (Reg_Usu_Sol = @_IdUsuario OR Reg_Usu_Reg = @_IdUsuario) " & WHERE & " ORDER BY Reg_Cod DESC "
            cms.Parameters.Add("@_IdUsuario", SqlDbType.VarChar, 50).Value = _IdUsuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Desarrollos_Sin_Asignar() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = ""
        If _Codigo <> "" Then
            WHERE = WHERE & " AND Reg_Cod = '" & _Codigo & "' "
        End If
        If _Prioridad <> "" Then
            WHERE = WHERE & " AND Reg_Pri = '" & _Prioridad & "' "
        End If
        If _Fecha_Inicio <> "" And _Fecha_Fin <> "" Then
            WHERE = WHERE & " AND Reg_Fch BETWEEN '" & _Fecha_Inicio & "' AND '" & _Fecha_Fin & "' "
        End If
        Try
            cn.Open()
            cms.CommandText = "SELECT DR.*, DE.Com_Nom As Estado, DA.Com_Nom AS Area FROM Desarrollo_Registro DR LEFT JOIN Desarrollo_Complemento DE ON DE.Com_Cod = Fk_Com_Est AND DE.Com_Per = 'ESTADO' LEFT JOIN Desarrollo_Complemento DA ON DA.Com_Cod = Fk_Com_Are AND DA.Com_Per = 'AREA' WHERE Fk_Com_Est = 10 AND (Reg_Usu_Asi IS NULL AND Reg_Usu_Des IS NULL) " & WHERE & " ORDER BY Reg_Cod DESC "
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Desarrollos_Asignados() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = ""
        If _Codigo <> "" Then
            WHERE = WHERE & " AND Reg_Cod = '" & _Codigo & "' "
        Else
            If _Prioridad <> "" Then
                WHERE = WHERE & " AND Reg_Pri = '" & _Prioridad & "' "
            End If
            If _Estado <> "" Then
                WHERE = WHERE & " AND Fk_Com_Est = '" & _Estado & "' "
            End If
            If _Fecha_Inicio <> "" And _Fecha_Fin <> "" Then
                WHERE = WHERE & " AND Reg_Fch BETWEEN '" & _Fecha_Inicio & "' AND '" & _Fecha_Fin & "' "
            End If
        End If
        Try
            cn.Open()
            cms.CommandText = "SELECT DR.*, DE.Com_Nom As Estado, DA.Com_Nom AS Area FROM Desarrollo_Registro DR LEFT JOIN Desarrollo_Complemento DE ON DE.Com_Cod = Fk_Com_Est AND DE.Com_Per = 'ESTADO' LEFT JOIN Desarrollo_Complemento DA ON DA.Com_Cod = Fk_Com_Are AND DA.Com_Per = 'AREA' WHERE Fk_Com_Est <> 14 AND Fk_Com_Est <> 15 AND (Reg_Usu_Asi IS NOT NULL AND Reg_Usu_Des IS NOT NULL) AND Reg_Usu_Des = '" & _IdUsuario & "' " & WHERE & " ORDER BY Reg_Cod DESC "
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Desarrollos_Gestion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT DR.Reg_cod  AS Codigo, DG.Ges_Fch AS Fecha, DG.Ges_Usu_Reg Usuario_Reg, DC.Com_Nom AS Estado, DG.Ges_Obs AS Observ, DG.Fk_Com_Com AS Compl, DG.Fk_Com_Ope AS Opera FROM Desarrollo_Gestion DG INNER JOIN Desarrollo_Registro DR ON DG.Fk_Reg_num = DR.Reg_num INNER JOIN Desarrollo_Complemento DC ON DG.Fk_Com_Est = DC.Com_Cod AND DC.Com_Per = 'ESTADO' WHERE DR.Reg_cod = '" & _Codigo & "' ORDER BY Reg_Cod DESC "
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Desarrollos_General() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim Where As String = ""
        Try
            'Filtros
            If _Codigo <> "" Then
                Where = Where & " And Reg_Cod = '" & _Codigo & "'"
            Else
                If _Prioridad <> "" Then
                    Where = Where & " And Reg_Pri = '" & _Prioridad & "'"
                End If
                If _Estado <> "" Then
                    Where = Where & " And Fk_com_Est = " & _Estado
                End If
                If _Area <> "" Then
                    Where = Where & " And Fk_com_Are = " & _Area
                End If
                If _Desarrollador <> "" Then
                    Where = Where & " And Reg_Usu_Des = '" & _Desarrollador & "'"
                End If
                If _Fecha_Inicio <> "" And _Fecha_Fin <> "" Then
                    Where = Where & " And Reg_Fch BETWEEN '" & _Fecha_Inicio & "' AND '" & _Fecha_Fin & "' "
                End If
            End If
            cn.Open()
            If Validacion = "Desarrollo_Registro" Then
                cms.CommandText = "SELECT DR.*, DC.Com_Nom As Estado, DCA.Com_Nom As Area FROM Desarrollo_Registro DR LEFT JOIN Desarrollo_Complemento DC ON DR.Fk_Com_Est = DC.Com_Cod AND DC.Com_Per = 'ESTADO' LEFT JOIN Desarrollo_Complemento DCA ON DR.Fk_Com_Are = DCA.Com_Cod AND DCA.Com_Per = 'AREA' WHERE Reg_Cod <> '' " & Where & " ORDER BY Reg_Cod DESC "
            ElseIf Validacion = "Desarrollo_Gestion" Then
                cms.CommandText = "SELECT DR.Reg_cod As Codigo, DC.Com_Nom As Estado, DG.* FROM Desarrollo_Gestion DG INNER JOIN Desarrollo_Registro DR ON DG.Fk_Reg_num = DR.Reg_num LEFT JOIN Desarrollo_Complemento DC ON DG.Fk_Com_Est = DC.Com_Cod AND DC.Com_Per = 'ESTADO' WHERE DR.Reg_cod = '" & _Codigo & "' ORDER BY DG.Ges_Fch"
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            _Cantidad = dtsrecepcion.Tables(0).Rows.Count
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