Public Class clsdatos
    Protected decid As Decimal
    Protected strbarrio As String
    Protected strsector As String
    Protected strnombre As String
    Protected strtipomarc1 As String
    Protected strtipomarc2 As String
    Protected strtipomarc3 As String
    Protected strtelefono1 As String
    Protected strtelefono2 As String
    Protected strtelefono3 As String
    Protected strlexpendio As String
    Protected strfcagendamiento As String
    Protected strdireccion As String
    Protected intcantreg As Integer
    Protected stremail As String
    Protected stremail1 As String
    Protected strnombrecont As String
    Protected strfecha As String
    Protected strhora As String
    Protected stragente As String
    Protected strutlimagest As String
    Protected strresultado As String
    Protected strObservacion As String
    Protected strfcrellamada As String
    Protected strhorarellamada As String
    Protected strestado As String
    Protected stridreferido As String
    Protected straccion As String
    Protected strfcpreventa As String
    Protected strhoraprev As String
    Protected strhoraagendamiento As String
    Protected strdireccioncit As String
    Protected strbarriocit As String
    Protected strplanventa As String
    Protected strequipo As String
    Protected straprobado As String
    Protected strfcventa As String
    Protected strhoraventa As String
    Protected strcodvendedor As String
    Protected strcodasesor As String
    Protected strusuarioventaefec As String
    Protected decvalortotalventa As Decimal
    Protected decidventas As Decimal
    Protected _Cantidad As Int64

    Public Property Cantidad As Int64
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Int64)
            _Cantidad = value
        End Set
    End Property
    Public Property idventas() As Decimal
        Get
            Return decidventas
        End Get
        Set(ByVal value As Decimal)
            decidventas = value
        End Set
    End Property

    Public Property valortotalventa() As Decimal
        Get
            Return decvalortotalventa
        End Get
        Set(ByVal value As Decimal)
            decvalortotalventa = value
        End Set
    End Property
    Public Property fcventa() As String
        Get
            Return strfcventa
        End Get
        Set(ByVal value As String)
            strfcventa = value
        End Set
    End Property
    Public Property usuarioventaefec() As String
        Get
            Return strusuarioventaefec
        End Get
        Set(ByVal value As String)
            strusuarioventaefec = value
        End Set
    End Property
    Public Property horaventa() As String
        Get
            Return strhoraventa
        End Get
        Set(ByVal value As String)
            strhoraventa = value
        End Set
    End Property
    Public Property codvendedor() As String
        Get
            Return strcodvendedor
        End Get
        Set(ByVal value As String)
            strcodvendedor = value
        End Set
    End Property
    Public Property codasesor() As String
        Get
            Return strcodasesor
        End Get
        Set(ByVal value As String)
            strcodasesor = value
        End Set
    End Property


    Public Property planventa() As String
        Get
            Return strplanventa
        End Get
        Set(ByVal value As String)
            strplanventa = value
        End Set
    End Property

    Public Property equipo() As String
        Get
            Return strequipo
        End Get
        Set(ByVal value As String)
            strequipo = value
        End Set
    End Property

    Public Property aprobado() As String
        Get
            Return straprobado
        End Get
        Set(ByVal value As String)
            straprobado = value
        End Set
    End Property

    Public Property fcpreventa() As String
        Get
            Return strfcpreventa
        End Get
        Set(ByVal value As String)
            strfcpreventa = value
        End Set
    End Property

    Public Property horaprev() As String
        Get
            Return strhoraprev
        End Get
        Set(ByVal value As String)
            strhoraprev = value
        End Set
    End Property

    Public Property horaagendamiento() As String
        Get
            Return strhoraagendamiento
        End Get
        Set(ByVal value As String)
            strhoraagendamiento = value
        End Set
    End Property

    Public Property direccioncit() As String
        Get
            Return strdireccioncit
        End Get
        Set(ByVal value As String)
            strdireccioncit = value
        End Set
    End Property

    Public Property barriocit() As String
        Get
            Return strbarriocit
        End Get
        Set(ByVal value As String)
            strbarriocit = value
        End Set
    End Property


    Public Property accion() As String
        Get
            Return straccion
        End Get
        Set(ByVal value As String)
            straccion = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return stremail
        End Get
        Set(ByVal value As String)
            stremail = value
        End Set
    End Property
    Public Property email1() As String
        Get
            Return stremail1
        End Get
        Set(ByVal value As String)
            stremail1 = value
        End Set
    End Property
    Public Property nombrecont() As String
        Get
            Return strnombrecont
        End Get
        Set(ByVal value As String)
            strnombrecont = value
        End Set
    End Property
    Public Property fecha() As String
        Get
            Return strfecha
        End Get
        Set(ByVal value As String)
            strfecha = value
        End Set
    End Property
    Public Property hora() As String
        Get
            Return strhora
        End Get
        Set(ByVal value As String)
            strhora = value
        End Set
    End Property
    Public Property agente() As String
        Get
            Return stragente
        End Get
        Set(ByVal value As String)
            stragente = value
        End Set
    End Property
    Public Property utlimagest() As String
        Get
            Return strutlimagest
        End Get
        Set(ByVal value As String)
            strutlimagest = value
        End Set
    End Property
    Public Property resultado() As String
        Get
            Return strresultado
        End Get
        Set(ByVal value As String)
            strresultado = value
        End Set
    End Property
    Public Property Observacion() As String
        Get
            Return strObservacion
        End Get
        Set(ByVal value As String)
            strObservacion = value
        End Set
    End Property
    Public Property fcrellamada() As String
        Get
            Return strfcrellamada
        End Get
        Set(ByVal value As String)
            strfcrellamada = value
        End Set
    End Property
    Public Property horarellamada() As String
        Get
            Return strhorarellamada
        End Get
        Set(ByVal value As String)
            strhorarellamada = value
        End Set
    End Property
    Public Property idreferido() As String
        Get
            Return stridreferido
        End Get
        Set(ByVal value As String)
            stridreferido = value
        End Set
    End Property

    Public Property estado() As String
        Get
            Return strestado
        End Get
        Set(ByVal value As String)
            strestado = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return strdireccion
        End Get
        Set(ByVal value As String)
            strdireccion = value
        End Set
    End Property
    Public Property expendio() As String
        Get
            Return strlexpendio
        End Get
        Set(ByVal value As String)
            strlexpendio = value
        End Set
    End Property
    Public Property telefono1() As String
        Get
            Return strtelefono1
        End Get
        Set(ByVal value As String)
            strtelefono1 = value
        End Set
    End Property
    Public Property telefono2() As String
        Get
            Return strtelefono2
        End Get
        Set(ByVal value As String)
            strtelefono2 = value
        End Set
    End Property
    Public Property telefono3() As String
        Get
            Return strtelefono3
        End Get
        Set(ByVal value As String)
            strtelefono3 = value
        End Set
    End Property

    Public Property fcagendamiento() As String
        Get
            Return strfcagendamiento
        End Get
        Set(ByVal value As String)
            strfcagendamiento = value
        End Set
    End Property
    Public Property cantreg() As Integer
        Get
            Return intcantreg
        End Get
        Set(ByVal value As Integer)
            intcantreg = value
        End Set
    End Property
    Public Property id() As Decimal
        Get
            Return decid
        End Get
        Set(ByVal value As Decimal)
            decid = value
        End Set
    End Property
    Public Property barrio() As String
        Get
            Return strbarrio
        End Get
        Set(ByVal value As String)
            strbarrio = value
        End Set
    End Property
    Public Property sector() As String
        Get
            Return strsector
        End Get
        Set(ByVal value As String)
            strsector = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return strnombre
        End Get
        Set(ByVal value As String)
            strnombre = value
        End Set
    End Property
    Public Property tipomarc1() As String
        Get
            Return strtipomarc1
        End Get
        Set(ByVal value As String)
            strtipomarc1 = value
        End Set
    End Property
    Public Property tipomarc2() As String
        Get
            Return strtipomarc2
        End Get
        Set(ByVal value As String)
            strtipomarc2 = value
        End Set
    End Property
    Public Property tipomarc3() As String
        Get
            Return strtipomarc3
        End Get
        Set(ByVal value As String)
            strtipomarc3 = value
        End Set
    End Property


    Public Function consultadatosini() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dt As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "consultaregistros"
            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.Add("@id", SqlDbType.Decimal).Value = decid
            cms.Parameters.Add("@barrio", SqlDbType.NVarChar, 150).Value = strbarrio
            cms.Parameters.Add("@sector", SqlDbType.NVarChar, 150).Value = strsector
            cms.Parameters.Add("@nombre", SqlDbType.NVarChar, 250).Value = strnombre
            cms.Parameters.Add("@tipomarc1", SqlDbType.NVarChar, 250).Value = strtipomarc1
            cms.Parameters.Add("@tipomarc2", SqlDbType.NVarChar, 250).Value = strtipomarc2
            cms.Parameters.Add("@tipomarc3", SqlDbType.NVarChar, 250).Value = strtipomarc3
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dt)

            intcantreg = dt.Tables(0).Rows.Count
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultagenda() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dt As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from ventaefec where fcagendamiento=@fcagendamiento order by horaagendamiento"
            cms.Parameters.Add("@fcagendamiento", SqlDbType.NVarChar, 50).Value = strfcagendamiento
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dt)
            intcantreg = dt.Tables(0).Rows.Count
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaplab() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dt As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from temporalventa where iddatosini=@id"
            cms.Parameters.Add("@id", SqlDbType.Decimal).Value = decid
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dt)
            intcantreg = dt.Tables(0).Rows.Count
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultadatos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dt As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from datosinicial where id=@id"
            cms.Parameters.Add("@id", SqlDbType.Decimal).Value = decid
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dt)
            intcantreg = dt.Tables(0).Rows.Count
            If intcantreg > 0 Then
                estado = True

                If dt.Tables(0).Rows(0).Item("id") Is DBNull.Value Then
                    decid = ""
                Else
                    decid = dt.Tables(0).Rows(0).Item("id")
                End If
                If dt.Tables(0).Rows(0).Item("expendio") Is DBNull.Value Then
                    strlexpendio = ""
                Else
                    strlexpendio = dt.Tables(0).Rows(0).Item("expendio")
                End If
                If dt.Tables(0).Rows(0).Item("barrio") Is DBNull.Value Then
                    strbarrio = ""
                Else
                    strbarrio = dt.Tables(0).Rows(0).Item("barrio")
                End If
                If dt.Tables(0).Rows(0).Item("sector") Is DBNull.Value Then
                    strsector = ""
                Else
                    strsector = dt.Tables(0).Rows(0).Item("sector")
                End If
                If dt.Tables(0).Rows(0).Item("direccion") Is DBNull.Value Then
                    strdireccion = ""
                Else
                    strdireccion = dt.Tables(0).Rows(0).Item("direccion")
                End If
                If dt.Tables(0).Rows(0).Item("nombre") Is DBNull.Value Then
                    strnombre = ""
                Else
                    strnombre = dt.Tables(0).Rows(0).Item("nombre")
                End If
                If dt.Tables(0).Rows(0).Item("telefono1") Is DBNull.Value Then
                    strtelefono1 = ""
                Else
                    strtelefono1 = dt.Tables(0).Rows(0).Item("telefono1")
                End If
                If dt.Tables(0).Rows(0).Item("telefono2") Is DBNull.Value Then
                    strtelefono2 = ""
                Else
                    strtelefono2 = dt.Tables(0).Rows(0).Item("telefono2")
                End If
                If dt.Tables(0).Rows(0).Item("telefono3") Is DBNull.Value Then
                    strtelefono3 = ""
                Else
                    strtelefono3 = dt.Tables(0).Rows(0).Item("telefono3")
                End If
                If dt.Tables(0).Rows(0).Item("tipomarc1") Is DBNull.Value Then
                    strtipomarc1 = ""
                Else
                    strtipomarc1 = dt.Tables(0).Rows(0).Item("tipomarc1")
                End If
                If dt.Tables(0).Rows(0).Item("tipomarc2") Is DBNull.Value Then
                    strtipomarc2 = ""
                Else
                    strtipomarc2 = dt.Tables(0).Rows(0).Item("tipomarc2")
                End If
                If dt.Tables(0).Rows(0).Item("tipomarc3") Is DBNull.Value Then
                    strtipomarc3 = ""
                Else
                    strtipomarc3 = dt.Tables(0).Rows(0).Item("tipomarc3")
                End If
            Else
                estado = False
            End If
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaventas() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dt As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            If decid <> 0 Then
                cms.CommandText = "select * from ventaefec inner join datosequipo on ventaefec.idventa=datosequipo.idventa  where id=@id order by ventaefec.idventa"
                cms.Parameters.Add("@id", SqlDbType.Decimal).Value = decid
            End If
            If decidventas <> 0 Then
                cms.CommandText = "select * from ventaefec inner join datosequipo on ventaefec.idventa=datosequipo.idventa  where ventaefec.idventa=@idventas order by ventaefec.idventa"
                cms.Parameters.Add("@idventas", SqlDbType.Decimal).Value = decidventas

            End If
            If decid <> 0 And decidventas <> 0 Then
                cms.CommandText = "select * from ventaefec inner join datosequipo on ventaefec.idventa=datosequipo.idventa  where id=@id and ventaefec.idventa=@idventas order by ventaefec.idventa"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dt)

            intcantreg = dt.Tables(0).Rows.Count
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultainformacion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dt As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select * from digitacion"
            If decid <> 0 Then
                cms.CommandText = "select * from digitacion where utp = @utp"
                cms.Parameters.Add("@utp", SqlDbType.Decimal).Value = decid
            End If
            If decid <> 0 And decidventas <> 0 Then
                cms.CommandText = "select * from digitacion where utp between @decutpdesde and  @decutphasta"
                cms.Parameters.Add("@decutpdesde", SqlDbType.Decimal).Value = decid
                cms.Parameters.Add("@decutphasta", SqlDbType.Decimal).Value = decidventas
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dt)
            intcantreg = dt.Tables(0).Rows.Count
            If intcantreg > 0 Then
                If dt.Tables(0).Rows(0).Item("utp") Is DBNull.Value Then
                    decid = ""
                Else
                    decid = dt.Tables(0).Rows(0).Item("utp")
                End If
                If dt.Tables(0).Rows(0).Item("consecutivo") Is DBNull.Value Then
                    stridreferido = ""
                Else
                    stridreferido = dt.Tables(0).Rows(0).Item("consecutivo")
                End If
                If dt.Tables(0).Rows(0).Item("unidadadmin") Is DBNull.Value Then
                    strbarrio = ""
                Else
                    strbarrio = dt.Tables(0).Rows(0).Item("unidadadmin")
                End If
                If dt.Tables(0).Rows(0).Item("valor") Is DBNull.Value Then
                    decidventas = ""
                Else
                    decidventas = dt.Tables(0).Rows(0).Item("valor")
                End If
                
            End If
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultahist() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dt As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "consultadatos"
            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.Add("@id", SqlDbType.Decimal).Value = decid
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dt)
            intcantreg = dt.Tables(0).Rows.Count
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Sub datosiniciales()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "datosini"
            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.Add("@id", SqlDbType.Decimal).Value = decid
            cms.Parameters.Add("@expendio", SqlDbType.NVarChar, 150).Value = strlexpendio
            cms.Parameters.Add("@barrio", SqlDbType.NVarChar, 150).Value = strbarrio
            cms.Parameters.Add("@sector", SqlDbType.NVarChar, 150).Value = strsector
            cms.Parameters.Add("@direccion", SqlDbType.NVarChar, 250).Value = strdireccion
            cms.Parameters.Add("@nombre", SqlDbType.NVarChar, 250).Value = strnombre
            cms.Parameters.Add("@telefono1", SqlDbType.NVarChar, 15).Value = strtelefono1
            cms.Parameters.Add("@telefono2", SqlDbType.NVarChar, 15).Value = strtelefono2
            cms.Parameters.Add("@telefono3", SqlDbType.NVarChar, 15).Value = strtelefono3
            cms.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = stremail
            cms.Parameters.Add("@email1", SqlDbType.NVarChar, 100).Value = stremail1
            cms.Parameters.Add("@nombrecont", SqlDbType.NVarChar, 150).Value = strnombrecont
            cms.Parameters.Add("@fecha", SqlDbType.NVarChar, 50).Value = strfecha
            cms.Parameters.Add("@hora", SqlDbType.NVarChar, 50).Value = strhora
            cms.Parameters.Add("@agente", SqlDbType.NVarChar, 50).Value = stragente
            cms.Parameters.Add("@utlimagest", SqlDbType.NVarChar, 3).Value = strutlimagest
            cms.Parameters.Add("@resultado", SqlDbType.NVarChar, 3).Value = strresultado
            cms.Parameters.Add("@Observacion", SqlDbType.NVarChar, 2000).Value = strObservacion
            cms.Parameters.Add("@fcrellamada", SqlDbType.NVarChar, 50).Value = strfcrellamada
            cms.Parameters.Add("@horarellamada", SqlDbType.NVarChar, 50).Value = strhorarellamada
            cms.Parameters.Add("@estado", SqlDbType.NVarChar, 50).Value = strestado
            cms.Parameters.Add("@idreferido", SqlDbType.Decimal).Value = stridreferido
            cms.Parameters.Add("@accion", SqlDbType.NVarChar, 50).Value = straccion
            cms.Parameters.Add("@idres", SqlDbType.Decimal).Direction = ParameterDirection.Output
            cms.Connection = cn
            cms.ExecuteNonQuery()
            If cms.Parameters("@idres").Value Is DBNull.Value Then
                idreferido = 0
            Else

                idreferido = cms.Parameters("@idres").Value
            End If

        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub registrodeventas()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "registradigitacion"
            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.Add("@utp", SqlDbType.Decimal).Value = decid
            cms.Parameters.Add("@consecutivo", SqlDbType.VarChar, 6).Value = stridreferido
            cms.Parameters.Add("@unidadadmin", SqlDbType.VarChar, 70).Value = strbarrio
            cms.Parameters.Add("@año", SqlDbType.VarChar, 4).Value = 1
            cms.Parameters.Add("@valor", SqlDbType.Decimal, 10, 2).Value = decidventas
            cms.Parameters.Add("@usuarioreg", SqlDbType.NVarChar, 50).Value = stragente
            cms.Parameters.Add("@fechareg", SqlDbType.NVarChar, 50).Value = strfecha
            cms.Parameters.Add("@accion", SqlDbType.NVarChar, 50).Value = strlexpendio
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

    Public Sub datosequipogest()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "[datosequipogest]"
            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.Add("@IDDETALLE", SqlDbType.Decimal).Value = stridreferido
            cms.Parameters.Add("@idventa", SqlDbType.Decimal).Value = decid
            cms.Parameters.Add("@planventa", SqlDbType.NVarChar, 150).Value = strplanventa
            cms.Parameters.Add("@equipo", SqlDbType.NVarChar, 150).Value = strequipo
            cms.Parameters.Add("@aprobado", SqlDbType.NVarChar, 150).Value = straprobado
            cms.Parameters.Add("@accion", SqlDbType.NVarChar, 50).Value = straccion
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

    Public Sub actualizaventaefect()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "[actualizaventaef]"
            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.Add("@idventa", SqlDbType.Decimal).Value = decidventas
            cms.Parameters.Add("@fcpreventa", SqlDbType.NVarChar, 50).Value = strfcpreventa
            cms.Parameters.Add("@horaprev", SqlDbType.NVarChar, 50).Value = strhoraprev
            cms.Parameters.Add("@usuario", SqlDbType.NVarChar, 50).Value = stragente
            cms.Parameters.Add("@fcventa", SqlDbType.NVarChar, 50).Value = strfcventa
            cms.Parameters.Add("@horaventa", SqlDbType.NVarChar, 50).Value = strhoraventa
            cms.Parameters.Add("@codvendedor", SqlDbType.NVarChar, 150).Value = strcodvendedor
            cms.Parameters.Add("@codasesor", SqlDbType.NVarChar, 150).Value = strcodasesor
            cms.Parameters.Add("@valortotalventa", SqlDbType.Decimal).Value = decvalortotalventa
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

    Public Sub registrahist()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "registrahist"
            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.Add("@id", SqlDbType.Decimal).Value = decid
            cms.Parameters.Add("@fecha", SqlDbType.NVarChar, 50).Value = strfecha
            cms.Parameters.Add("@hora", SqlDbType.NVarChar, 50).Value = strhora
            cms.Parameters.Add("@agente", SqlDbType.NVarChar, 50).Value = stragente
            cms.Parameters.Add("@tipificacion", SqlDbType.NVarChar, 3).Value = strutlimagest
            cms.Parameters.Add("@resultado", SqlDbType.NVarChar, 3).Value = strresultado
            cms.Parameters.Add("@Observacion", SqlDbType.NVarChar, 2000).Value = strObservacion
            cms.Parameters.Add("@fcrellamada", SqlDbType.NVarChar, 50).Value = strfcrellamada
            cms.Parameters.Add("@horarellamada", SqlDbType.NVarChar, 50).Value = strhorarellamada
            cms.Parameters.Add("@nombrecont", SqlDbType.NVarChar, 150).Value = strnombrecont
            cms.Parameters.Add("@contacto", SqlDbType.NVarChar, 150).Value = ""
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


    Public Function consultainformaciongestion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dt As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "[consultagestion]"

            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.Add("@id", SqlDbType.Decimal).Value = decid
            cms.Parameters.Add("@ultimagest", SqlDbType.NVarChar, 50).Value = strutlimagest
            cms.Parameters.Add("@agente", SqlDbType.NVarChar, 50).Value = stragente
            cms.Parameters.Add("@fechadesde", SqlDbType.VarChar, 50).Value = strfcpreventa
            cms.Parameters.Add("@fechahasta", SqlDbType.VarChar, 50).Value = strfcrellamada
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dt)
            intcantreg = dt.Tables(0).Rows.Count
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultaventasfinal() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dt As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "[consultaventas]"

            cms.CommandType = CommandType.StoredProcedure
            cms.Parameters.Add("@id", SqlDbType.Decimal).Value = decid
            cms.Parameters.Add("@ultimagest", SqlDbType.NVarChar, 50).Value = strutlimagest
            cms.Parameters.Add("@agente", SqlDbType.NVarChar, 50).Value = stragente
            cms.Parameters.Add("@fechadesde", SqlDbType.VarChar, 50).Value = strfcpreventa
            cms.Parameters.Add("@fechahasta", SqlDbType.VarChar, 50).Value = strfcrellamada
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function ConsultaAmdocs()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT cas_id, cas_fecha_registro, min_ac,estado, Bandeja FROM Bandeja WHERE (estado='abierto' Or estado='gestionado' Or estado='rellamada' Or estado='programado') AND (Bandeja='Datos - Smartphone' Or Bandeja='Datos - Otros Servicios')"
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
End Class
