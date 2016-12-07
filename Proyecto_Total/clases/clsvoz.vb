Public Class clsvoz
    Protected strlcaso As String
    Protected strlcantidad As String
    Protected strlidcrm As String
    Protected strlfcreg As String
    Protected strlidusuario As String
    Protected strlobs As String
    Protected strltiposoporte As String
    Protected strltipificacion As String
    Protected strlcasfcregistro As String
    Protected strlmin As String
    Protected strlcliente As String
    Protected strldocumento As String
    Protected strlplan As String
    Protected strlequipo As String
    Protected strllugar As String
    Protected strlemail As String
    Protected strlpreg1 As String
    Protected strlobsini As String
    Protected strlfcini As String
    Protected strlfcfin As String
    Protected strltelcontacto As String
    Protected strltecnologia As String
    Protected strlincidente As String
    Protected strlestadoinc As String
    Protected strlmesa As String
    Protected strlfcingn3 As String
    Protected strlingn3 As String
    Protected strlpqr As String
    Protected strlfcini3 As String
    Protected strlfcfin3 As String
    Protected strlchk1 As String
    Protected strlchk2 As String
    Protected strlbarrio As String
    Protected strltelalt As String
    Protected strlmesaesc As String
    Protected strlzona As String
    Protected strldpto As String
    Protected strlmun As String
    Protected strldir As String
    Protected strlareafalla As String
    Protected strltipofalla As String
    Protected strlfcsap As String
    Protected strltickler As String
    Protected strltiempo As String
    Protected strlcaracter As String
    Protected strlportada As String
    Protected strlvereda As String
    Protected strlmaslineas As String
    Protected strlcpd As String
    Protected strldevolver As String
    Protected strlescala As String
    Protected strlsolucion As String
    Protected strlresolucion As String
    Protected strlfallatec As String
    Protected strlcampana As String
    Protected strlapn As String
    Protected strlqos As String
    Protected strldiagservicio As String
    Protected strldiagcaractfalla As String
    Protected strldiagperep As String
    Protected strldiagtecnolog As String
    Protected strldiagcondic As String
    Protected strldiagvariable As String
    Protected strldiagtcierre As String
    Protected strlajuste As String
    Protected strlvlrajuste As String
    Protected strlpreg2 As String
    Protected strlpreg3 As String
    Protected strlAño As String
    Protected strlMes As String
    Protected strlBandeja As String
    Protected strlfcultimac As String
    Protected strlfranjaultimac As String
    Protected strlnit As String
    Protected strlfechainicial As String
    Protected strlfechafin As String
    Protected strlDesactivacion As String
    Protected strlidusuarioasignado As String
    Protected strlsolicitud As String

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''' Campaña MTI Chile ''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Cod_Bandeja_MTI As Int64
    Protected _Empresa As String
    Protected _Nombre As String
    Protected _Apellido As String
    Protected _Cargo As String
    Protected _Correo As String
    Protected _Telefono As String
    Protected _Celular As Int64
    Protected _Asiste As String
    Protected _Contacto_CLO As String
    Protected _Envio_Invitacion As String
    Protected _Realizo_llamada As String
    Protected _Contacto_Adicional As String
    Protected _Comentario As String
    Protected _Estado_Llamada As String
    Protected _Fc_Programado As String
    Protected _Validacion As String
    Protected _Recepcion_Invitacion As String
    Protected _Persona_Interesada As String

    Protected _Nombre1 As String
    Protected _Cargo1 As String
    Protected _Correo1 As String
    Protected _Telefono1 As String
    Protected _Nombre2 As String
    Protected _Cargo2 As String
    Protected _Correo2 As String
    Protected _Telefono2 As String
    Protected _Nombre3 As String
    Protected _Cargo3 As String
    Protected _Correo3 As String
    Protected _Telefono3 As String
    Protected strlSuperv As String
    Protected strlNum_Intento As String
    Protected _Tipo_PQR As String
    Protected _Tipo_Cliente As String
    Protected _Modalidad As String
    Protected _Causa_Raiz As String
    Protected _Categoria_Cierre As String
    Protected StrlCanal As String
    Protected strlmarca As String
    Protected strllocalidad As String



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''INICIO SERVICIO CLIETE'''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Falla_Presenta_Luego_Construyera_Edificacion_Aledania As String
    Protected _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio As String
    Protected _Tipo_Edificacion_Donde_Presenta_Falla As String
    Protected _Validaciones_Falla_Masiva As String
    Protected _Tecnologia_Presenta_Falla_Luegodepruebas As String
    Protected _Validacion_Coordenadas As String
    Protected _Linea_No_Cuenta_Bloqueos_Internet As String
    Protected _Linea_No_Superado_Limite_Consumos As String
    Protected _Linea_No_Encuentra_Enrutada_PorPagos As String
    Protected _HLR_HSS As String
    Protected _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra As String
    Protected _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla As String
    Protected _Forza_Red_Dispositivo As String
    Protected _Verifica_Realiza_Configuración_APN As String
    Protected _Equipo_Encuentra_Homologado_Operador As String
    Protected _Realiza_Conciliacion_Sobre_linea As String

    ''' Cierre CPD
    Dim _Respuesta As String
    Dim _Falla_solucionada As String
    Dim _Estado_Cliente As String
    Dim _Cliente_Misma_Ubicacion_Falla As String
    Dim _CPD_Mismo_Min_Zona As String
    Dim _CPD_Mismo_Min_Zona_Can As String


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''' POLL PERCEPTION OF SERVICE '''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Poll Short
    Dim _Tipo_Poll As String
    Dim _Genero As String
    Dim _Titular_Linea As String
    Dim _Internet_Redes_sociales As String
    Dim _Dificultad_Usar_Servicio_Datos As String
    Dim _Dificultad_Usar_Servicio_Voz As String
    Dim _Ha_Tenido_Dificultad_Datos As String
    Dim _Ha_Tenido_Dificultad_Voz As String
    Dim _Cual_Es_Mas_Molesta_Datos As String
    Dim _Cual_Es_Mas_Molesta_Voz As String
    Dim _Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos As String
    Dim _Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz As String
    'Poll Long
    Dim _Recomienda_Contratar_Servicios_Claro_AmigaConocida As String
    Dim _Que_Tan_Satisfecho_Con_Servicio_Voz As String
    Dim _Establecimiento_Llamadas As String
    Dim _Continuidad_Llamadas As String
    Dim _Claridad_Llamadas As String
    Dim _Que_Tan_Satisfecho_Con_Servicio_Datos As String
    Dim _Accesibilidad_Servicio_Datos As String
    Dim _Capacidad_Retencion_Servicio_Datos As String
    Dim _Velocidad_Navegacion_Servicio_Datos As String
    Dim _Envio_Recepcion_Correos_Electronicos As String
    Dim _Envio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line As String
    Dim _Subir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales As String
    Dim _Tiempo_Espera_Para_Abrir_Pagina_Favorita_Internet As String
    'Poll multiples respuestas
    Dim _Fk_Cod_CRM_Poll_Perception_Service_S_L As String
    Dim _Fk_Cod_Poll_P_S_Des_Option As String

    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''Configuracion Cambio Red''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim _Consecutivo As String
    Dim _Gestiones As String
    Dim _Tipo_linea As String
    Dim _Respuesta_Config As String
    Dim _Estado_linea As String
    Dim _Corporativo As String
    Dim _Dual As String
    Dim _ICCID As String

    Public Property Consecutivo As String
        Get
            Return _Consecutivo
        End Get
        Set(ByVal value As String)
            _Consecutivo = value
        End Set
    End Property
    Public Property Gestiones As String
        Get
            Return _Gestiones
        End Get
        Set(ByVal value As String)
            _Gestiones = value
        End Set
    End Property
    Public Property Tipo_linea As String
        Get
            Return _Tipo_linea
        End Get
        Set(ByVal value As String)
            _Tipo_linea = value
        End Set
    End Property

    Public Property Respuesta_Config As String
        Get
            Return _Respuesta_Config
        End Get
        Set(ByVal value As String)
            _Respuesta_Config = value
        End Set
    End Property
    Public Property Estado_linea As String
        Get
            Return _Estado_linea
        End Get
        Set(ByVal value As String)
            _Estado_linea = value
        End Set
    End Property

    Public Property Corporativo As String
        Get
            Return _Corporativo
        End Get
        Set(ByVal value As String)
            _Corporativo = value
        End Set
    End Property
    Public Property Dual As String
        Get
            Return _Dual
        End Get
        Set(ByVal value As String)
            _Dual = value
        End Set
    End Property
    Public Property ICCID As String
        Get
            Return _ICCID
        End Get
        Set(ByVal value As String)
            _ICCID = value
        End Set
    End Property



    Public Property Fk_Cod_Poll_P_S_Des_Option As String
        Get
            Return _Fk_Cod_Poll_P_S_Des_Option
        End Get
        Set(ByVal value As String)
            _Fk_Cod_Poll_P_S_Des_Option = value
        End Set
    End Property
    Public Property Fk_Cod_CRM_Poll_Perception_Service_S_L As String
        Get
            Return _Fk_Cod_CRM_Poll_Perception_Service_S_L
        End Get
        Set(ByVal value As String)
            _Fk_Cod_CRM_Poll_Perception_Service_S_L = value
        End Set
    End Property
    Public Property Tiempo_Espera_Para_Abrir_Pagina_Favorita_Internet As String
        Get
            Return _Tiempo_Espera_Para_Abrir_Pagina_Favorita_Internet
        End Get
        Set(ByVal value As String)
            _Tiempo_Espera_Para_Abrir_Pagina_Favorita_Internet = value
        End Set
    End Property
    Public Property Subir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales As String
        Get
            Return _Subir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales
        End Get
        Set(ByVal value As String)
            _Subir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales = value
        End Set
    End Property
    Public Property Envio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line As String
        Get
            Return _Envio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line
        End Get
        Set(ByVal value As String)
            _Envio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line = value
        End Set
    End Property
    Public Property Envio_Recepcion_Correos_Electronicos As String
        Get
            Return _Envio_Recepcion_Correos_Electronicos
        End Get
        Set(ByVal value As String)
            _Envio_Recepcion_Correos_Electronicos = value
        End Set
    End Property
    Public Property Velocidad_Navegacion_Servicio_Datos As String
        Get
            Return _Velocidad_Navegacion_Servicio_Datos
        End Get
        Set(ByVal value As String)
            _Velocidad_Navegacion_Servicio_Datos = value
        End Set
    End Property
    Public Property Capacidad_Retencion_Servicio_Datos As String
        Get
            Return _Capacidad_Retencion_Servicio_Datos
        End Get
        Set(ByVal value As String)
            _Capacidad_Retencion_Servicio_Datos = value
        End Set
    End Property
    Public Property Accesibilidad_Servicio_Datos As String
        Get
            Return _Accesibilidad_Servicio_Datos
        End Get
        Set(ByVal value As String)
            _Accesibilidad_Servicio_Datos = value
        End Set
    End Property
    Public Property Que_Tan_Satisfecho_Con_Servicio_Datos As String
        Get
            Return _Que_Tan_Satisfecho_Con_Servicio_Datos
        End Get
        Set(ByVal value As String)
            _Que_Tan_Satisfecho_Con_Servicio_Datos = value
        End Set
    End Property
    Public Property Claridad_Llamadas As String
        Get
            Return _Claridad_Llamadas
        End Get
        Set(ByVal value As String)
            _Claridad_Llamadas = value
        End Set
    End Property
    Public Property Continuidad_Llamadas As String
        Get
            Return _Continuidad_Llamadas
        End Get
        Set(ByVal value As String)
            _Continuidad_Llamadas = value
        End Set
    End Property
    Public Property Establecimiento_Llamadas As String
        Get
            Return _Establecimiento_Llamadas
        End Get
        Set(ByVal value As String)
            _Establecimiento_Llamadas = value
        End Set
    End Property
    Public Property Que_Tan_Satisfecho_Con_Servicio_Voz As String
        Get
            Return _Que_Tan_Satisfecho_Con_Servicio_Voz
        End Get
        Set(ByVal value As String)
            _Que_Tan_Satisfecho_Con_Servicio_Voz = value
        End Set
    End Property
    Public Property Recomienda_Contratar_Servicios_Claro_AmigaConocida As String
        Get
            Return _Recomienda_Contratar_Servicios_Claro_AmigaConocida
        End Get
        Set(ByVal value As String)
            _Recomienda_Contratar_Servicios_Claro_AmigaConocida = value
        End Set
    End Property
    Public Property Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz As String
        Get
            Return _Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz
        End Get
        Set(ByVal value As String)
            _Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz = value
        End Set
    End Property
    Public Property Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos As String
        Get
            Return _Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos
        End Get
        Set(ByVal value As String)
            _Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos = value
        End Set
    End Property
    Public Property Cual_Es_Mas_Molesta_Voz As String
        Get
            Return _Cual_Es_Mas_Molesta_Voz
        End Get
        Set(ByVal value As String)
            _Cual_Es_Mas_Molesta_Voz = value
        End Set
    End Property
    Public Property Cual_Es_Mas_Molesta_Datos As String
        Get
            Return _Cual_Es_Mas_Molesta_Datos
        End Get
        Set(ByVal value As String)
            _Cual_Es_Mas_Molesta_Datos = value
        End Set
    End Property
    Public Property Ha_Tenido_Dificultad_Voz As String
        Get
            Return _Ha_Tenido_Dificultad_Voz
        End Get
        Set(ByVal value As String)
            _Ha_Tenido_Dificultad_Voz = value
        End Set
    End Property
    Public Property Ha_Tenido_Dificultad_Datos As String
        Get
            Return _Ha_Tenido_Dificultad_Datos
        End Get
        Set(ByVal value As String)
            _Ha_Tenido_Dificultad_Datos = value
        End Set
    End Property
    Public Property Dificultad_Usar_Servicio_Voz As String
        Get
            Return _Dificultad_Usar_Servicio_Voz
        End Get
        Set(ByVal value As String)
            _Dificultad_Usar_Servicio_Voz = value
        End Set
    End Property
    Public Property Dificultad_Usar_Servicio_Datos As String
        Get
            Return _Dificultad_Usar_Servicio_Datos
        End Get
        Set(ByVal value As String)
            _Dificultad_Usar_Servicio_Datos = value
        End Set
    End Property
    Public Property Internet_Redes_sociales As String
        Get
            Return _Internet_Redes_sociales
        End Get
        Set(ByVal value As String)
            _Internet_Redes_sociales = value
        End Set
    End Property
    Public Property Titular_Linea As String
        Get
            Return _Titular_Linea
        End Get
        Set(ByVal value As String)
            _Titular_Linea = value
        End Set
    End Property
    Public Property Genero As String
        Get
            Return _Genero
        End Get
        Set(ByVal value As String)
            _Genero = value
        End Set
    End Property
    Public Property Tipo_Poll As String
        Get
            Return _Tipo_Poll
        End Get
        Set(ByVal value As String)
            _Tipo_Poll = value
        End Set
    End Property



    Public Property Respuesta As String
        Get
            Return _Respuesta
        End Get
        Set(ByVal value As String)
            _Respuesta = value
        End Set
    End Property

    Public Property Falla_solucionada As String
        Get
            Return _Falla_solucionada
        End Get
        Set(ByVal value As String)
            _Falla_solucionada = value
        End Set
    End Property

    Public Property Estado_Cliente As String
        Get
            Return _Estado_Cliente
        End Get
        Set(ByVal value As String)
            _Estado_Cliente = value
        End Set
    End Property

    Public Property Cliente_Misma_Ubicacion_Falla As String
        Get
            Return _Cliente_Misma_Ubicacion_Falla
        End Get
        Set(ByVal value As String)
            _Cliente_Misma_Ubicacion_Falla = value
        End Set
    End Property

    Public Property CPD_Mismo_Min_Zona As String
        Get
            Return _CPD_Mismo_Min_Zona
        End Get
        Set(ByVal value As String)
            _CPD_Mismo_Min_Zona = value
        End Set
    End Property

    Public Property CPD_Mismo_Min_Zona_Can As String
        Get
            Return _CPD_Mismo_Min_Zona_Can
        End Get
        Set(ByVal value As String)
            _CPD_Mismo_Min_Zona_Can = value
        End Set
    End Property


    Public Property Realiza_Conciliacion_Sobre_linea As String
        Get
            Return _Realiza_Conciliacion_Sobre_linea
        End Get
        Set(ByVal value As String)
            _Realiza_Conciliacion_Sobre_linea = value
        End Set
    End Property
    Public Property Equipo_Encuentra_Homologado_Operador As String
        Get
            Return _Equipo_Encuentra_Homologado_Operador
        End Get
        Set(ByVal value As String)
            _Equipo_Encuentra_Homologado_Operador = value
        End Set
    End Property
    Public Property Verifica_Realiza_Configuración_APN As String
        Get
            Return _Verifica_Realiza_Configuración_APN
        End Get
        Set(ByVal value As String)
            _Verifica_Realiza_Configuración_APN = value
        End Set
    End Property
    Public Property Forza_Red_Dispositivo As String
        Get
            Return _Forza_Red_Dispositivo
        End Get
        Set(ByVal value As String)
            _Forza_Red_Dispositivo = value
        End Set
    End Property
    Public Property Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla As String
        Get
            Return _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla
        End Get
        Set(ByVal value As String)
            _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = value
        End Set
    End Property
    Public Property No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra As String
        Get
            Return _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra
        End Get
        Set(ByVal value As String)
            _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = value
        End Set
    End Property
    Public Property HLR_HSS As String
        Get
            Return _HLR_HSS
        End Get
        Set(ByVal value As String)
            _HLR_HSS = value
        End Set
    End Property
    Public Property Linea_No_Encuentra_Enrutada_PorPagos As String
        Get
            Return _Linea_No_Encuentra_Enrutada_PorPagos
        End Get
        Set(ByVal value As String)
            _Linea_No_Encuentra_Enrutada_PorPagos = value
        End Set
    End Property
    Public Property Linea_No_Superado_Limite_Consumos As String
        Get
            Return _Linea_No_Superado_Limite_Consumos
        End Get
        Set(ByVal value As String)
            _Linea_No_Superado_Limite_Consumos = value
        End Set
    End Property
    Public Property Linea_No_Cuenta_Bloqueos_Internet As String
        Get
            Return _Linea_No_Cuenta_Bloqueos_Internet
        End Get
        Set(ByVal value As String)
            _Linea_No_Cuenta_Bloqueos_Internet = value
        End Set
    End Property
    Public Property Validacion_Coordenadas As String
        Get
            Return _Validacion_Coordenadas
        End Get
        Set(ByVal value As String)
            _Validacion_Coordenadas = value
        End Set
    End Property
    Public Property Tecnologia_Presenta_Falla_Luegodepruebas As String
        Get
            Return _Tecnologia_Presenta_Falla_Luegodepruebas
        End Get
        Set(ByVal value As String)
            _Tecnologia_Presenta_Falla_Luegodepruebas = value
        End Set
    End Property
    Public Property Validaciones_Falla_Masiva As String
        Get
            Return _Validaciones_Falla_Masiva
        End Get
        Set(ByVal value As String)
            _Validaciones_Falla_Masiva = value
        End Set
    End Property
    Public Property Tipo_Edificacion_Donde_Presenta_Falla As String
        Get
            Return _Tipo_Edificacion_Donde_Presenta_Falla
        End Get
        Set(ByVal value As String)
            _Tipo_Edificacion_Donde_Presenta_Falla = value
        End Set
    End Property
    Public Property Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio As String
        Get
            Return _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio
        End Get
        Set(ByVal value As String)
            _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = value
        End Set
    End Property
    Public Property Falla_Presenta_Luego_Construyera_Edificacion_Aledania As String
        Get
            Return _Falla_Presenta_Luego_Construyera_Edificacion_Aledania
        End Get
        Set(ByVal value As String)
            _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = value
        End Set
    End Property
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''FIN SERVICIO CLIENTE'''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''





    Public Property Marca As String
        Get
            Return strlmarca
        End Get
        Set(ByVal value As String)
            strlmarca = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return strllocalidad
        End Get
        Set(ByVal value As String)
            strllocalidad = value
        End Set
    End Property
    Public Property CanalDilo As String
        Get
            Return StrlCanal
        End Get
        Set(ByVal value As String)
            StrlCanal = value
        End Set
    End Property
    Public Property Categoria_Cierre As String
        Get
            Return _Categoria_Cierre
        End Get
        Set(ByVal value As String)
            _Categoria_Cierre = value
        End Set
    End Property
    Public Property Causa_Raiz As String
        Get
            Return _Causa_Raiz
        End Get
        Set(ByVal value As String)
            _Causa_Raiz = value
        End Set
    End Property
    Public Property Modalidad As String
        Get
            Return _Modalidad
        End Get
        Set(ByVal value As String)
            _Modalidad = value
        End Set
    End Property
    Public Property Tipo_Cliente As String
        Get
            Return _Tipo_Cliente
        End Get
        Set(ByVal value As String)
            _Tipo_Cliente = value
        End Set
    End Property
    Public Property Tipo_PQR As String
        Get
            Return _Tipo_PQR
        End Get
        Set(ByVal value As String)
            _Tipo_PQR = value
        End Set
    End Property
    Public Property Num_Intento As String
        Get
            Return strlNum_Intento
        End Get
        Set(ByVal value As String)
            strlNum_Intento = value
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
    Public Property Nombre1 As String
        Get
            Return _Nombre1
        End Get
        Set(ByVal value As String)
            _Nombre1 = value
        End Set
    End Property
    Public Property Nombre2 As String
        Get
            Return _Nombre2
        End Get
        Set(ByVal value As String)
            _Nombre2 = value
        End Set
    End Property
    Public Property Nombre3 As String
        Get
            Return _Nombre3
        End Get
        Set(ByVal value As String)
            _Nombre3 = value
        End Set
    End Property
    Public Property Cargo1 As String
        Get
            Return _Cargo1
        End Get
        Set(ByVal value As String)
            _Cargo1 = value
        End Set
    End Property
    Public Property Cargo2 As String
        Get
            Return _Cargo2
        End Get
        Set(ByVal value As String)
            _Cargo2 = value
        End Set
    End Property
    Public Property Cargo3 As String
        Get
            Return _Cargo3
        End Get
        Set(ByVal value As String)
            _Cargo3 = value
        End Set
    End Property
    Public Property Correo1 As String
        Get
            Return _Correo1
        End Get
        Set(ByVal value As String)
            _Correo1 = value
        End Set
    End Property
    Public Property Correo2 As String
        Get
            Return _Correo2
        End Get
        Set(ByVal value As String)
            _Correo2 = value
        End Set
    End Property
    Public Property Correo3 As String
        Get
            Return _Correo3
        End Get
        Set(ByVal value As String)
            _Correo3 = value
        End Set
    End Property
    Public Property Telefono1 As String
        Get
            Return _Telefono1
        End Get
        Set(ByVal value As String)
            _Telefono1 = value
        End Set
    End Property
    Public Property Telefono2 As String
        Get
            Return _Telefono2
        End Get
        Set(ByVal value As String)
            _Telefono2 = value
        End Set
    End Property
    Public Property Telefono3 As String
        Get
            Return _Telefono3
        End Get
        Set(ByVal value As String)
            _Telefono3 = value
        End Set
    End Property

    Public Property Persona_Interesada As String
        Get
            Return _Persona_Interesada
        End Get
        Set(ByVal value As String)
            _Persona_Interesada = value
        End Set
    End Property
    Public Property Recepcion_Invitacion As String
        Get
            Return _Recepcion_Invitacion
        End Get
        Set(ByVal value As String)
            _Recepcion_Invitacion = value
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
    Public Property Fc_Programado As String
        Get
            Return _Fc_Programado
        End Get
        Set(ByVal value As String)
            _Fc_Programado = value
        End Set
    End Property
    Public Property Estado_Llamada As String
        Get
            Return _Estado_Llamada
        End Get
        Set(ByVal value As String)
            _Estado_Llamada = value
        End Set
    End Property
    Public Property Comentario As String
        Get
            Return _Comentario
        End Get
        Set(ByVal value As String)
            _Comentario = value
        End Set
    End Property
    Public Property Contacto_Adicional As String
        Get
            Return _Contacto_Adicional
        End Get
        Set(ByVal value As String)
            _Contacto_Adicional = value
        End Set
    End Property
    Public Property Realizo_llamada As String
        Get
            Return _Realizo_llamada
        End Get
        Set(ByVal value As String)
            _Realizo_llamada = value
        End Set
    End Property
    Public Property Envio_Invitacion As String
        Get
            Return _Envio_Invitacion
        End Get
        Set(ByVal value As String)
            _Envio_Invitacion = value
        End Set
    End Property
    Public Property Contacto_CLO As String
        Get
            Return _Contacto_CLO
        End Get
        Set(ByVal value As String)
            _Contacto_CLO = value
        End Set
    End Property
    Public Property Asiste As String
        Get
            Return _Asiste
        End Get
        Set(ByVal value As String)
            _Asiste = value
        End Set
    End Property
    Public Property Celular As Int64
        Get
            Return _Celular
        End Get
        Set(ByVal value As Int64)
            _Celular = value
        End Set
    End Property
    Public Property Telefono As Int64
        Get
            Return _Telefono
        End Get
        Set(ByVal value As Int64)
            _Telefono = value
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(ByVal value As String)
            _Correo = value
        End Set
    End Property
    Public Property Cargo As String
        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = value
        End Set
    End Property
    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
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
    Public Property Empresa As String
        Get
            Return _Empresa
        End Get
        Set(ByVal value As String)
            _Empresa = value
        End Set
    End Property
    Public Property Cod_Bandeja_MTI As Int64
        Get
            Return _Cod_Bandeja_MTI
        End Get
        Set(ByVal value As Int64)
            _Cod_Bandeja_MTI = value
        End Set
    End Property

    Public Property solicitud() As String
        Get
            Return strlsolicitud
        End Get
        Set(ByVal value As String)
            strlsolicitud = value
        End Set
    End Property
    Public Property idusuarioasignado As String
        Get
            Return strlidusuarioasignado
        End Get
        Set(ByVal value As String)
            strlidusuarioasignado = value
        End Set
    End Property
    Public Property Desactivacion As String
        Get
            Return strlDesactivacion
        End Get
        Set(ByVal value As String)
            strlDesactivacion = value
        End Set
    End Property


    Public Property nit() As String
        Get
            Return strlnit
        End Get
        Set(ByVal value As String)
            strlnit = value
        End Set
    End Property
    Public Property fechainicial() As String
        Get
            Return strlnit
        End Get
        Set(ByVal value As String)
            strlfechainicial = value
        End Set
    End Property
    Public Property fechafin() As String
        Get
            Return strlnit
        End Get
        Set(ByVal value As String)
            strlfechafin = value
        End Set
    End Property
    Public Property franjaultimac() As String
        Get
            Return strlfranjaultimac
        End Get
        Set(ByVal value As String)
            strlfranjaultimac = value
        End Set
    End Property
    Public Property fcultimac() As String
        Get
            Return strlfcultimac
        End Get
        Set(ByVal value As String)
            strlfcultimac = value
        End Set
    End Property
    Public Property Bandeja() As String
        Get
            Return strlBandeja
        End Get
        Set(ByVal value As String)
            strlBandeja = value
        End Set
    End Property
    Public Property Mes() As String
        Get
            Return strlMes
        End Get
        Set(ByVal value As String)
            strlMes = value
        End Set
    End Property
    Public Property Año() As String
        Get
            Return strlAño
        End Get
        Set(ByVal value As String)
            strlAño = value
        End Set
    End Property
    Public Property preg3() As String
        Get
            Return strlpreg3
        End Get
        Set(ByVal value As String)
            strlpreg3 = value
        End Set
    End Property
    Public Property preg2() As String
        Get
            Return strlpreg2
        End Get
        Set(ByVal value As String)
            strlpreg2 = value
        End Set
    End Property
    Public Property vlrajuste() As String
        Get
            Return strlvlrajuste
        End Get
        Set(ByVal value As String)
            strlvlrajuste = value
        End Set
    End Property
    Public Property ajuste() As String
        Get
            Return strlajuste
        End Get
        Set(ByVal value As String)
            strlajuste = value
        End Set
    End Property
    Public Property diagtcierre() As String
        Get
            Return strldiagtcierre
        End Get
        Set(ByVal value As String)
            strldiagtcierre = value
        End Set
    End Property
    Public Property diagvariable() As String
        Get
            Return strldiagvariable
        End Get
        Set(ByVal value As String)
            strldiagvariable = value
        End Set
    End Property
    Public Property diagcondic() As String
        Get
            Return strldiagcondic
        End Get
        Set(ByVal value As String)
            strldiagcondic = value
        End Set
    End Property
    Public Property diagtecnolog() As String
        Get
            Return strldiagtecnolog
        End Get
        Set(ByVal value As String)
            strldiagtecnolog = value
        End Set
    End Property
    Public Property diagperep() As String
        Get
            Return strldiagperep
        End Get
        Set(ByVal value As String)
            strldiagperep = value
        End Set
    End Property
    Public Property diagcaractfalla() As String
        Get
            Return strldiagcaractfalla
        End Get
        Set(ByVal value As String)
            strldiagcaractfalla = value
        End Set
    End Property
    Public Property diagservicio() As String
        Get
            Return strldiagservicio
        End Get
        Set(ByVal value As String)
            strldiagservicio = value
        End Set
    End Property
    Public Property qos() As String
        Get
            Return strlqos
        End Get
        Set(ByVal value As String)
            strlqos = value
        End Set
    End Property
    Public Property apn() As String
        Get
            Return strlapn
        End Get
        Set(ByVal value As String)
            strlapn = value
        End Set
    End Property
    Public Property campana() As String
        Get
            Return strlcampana
        End Get
        Set(ByVal value As String)
            strlcampana = value
        End Set
    End Property
    Public Property fallatec() As String
        Get
            Return strlfallatec
        End Get
        Set(ByVal value As String)
            strlfallatec = value
        End Set
    End Property
    Public Property resolucion() As String
        Get
            Return strlresolucion
        End Get
        Set(ByVal value As String)
            strlresolucion = value
        End Set
    End Property
    Public Property solucion() As String
        Get
            Return strlsolucion
        End Get
        Set(ByVal value As String)
            strlsolucion = value
        End Set
    End Property
    Public Property escala() As String
        Get
            Return strlescala
        End Get
        Set(ByVal value As String)
            strlescala = value
        End Set
    End Property
    Public Property devolver() As String
        Get
            Return strldevolver
        End Get
        Set(ByVal value As String)
            strldevolver = value
        End Set
    End Property
    Public Property cpd() As String
        Get
            Return strlcpd
        End Get
        Set(ByVal value As String)
            strlcpd = value
        End Set
    End Property
    Public Property maslineas() As String
        Get
            Return strlmaslineas
        End Get
        Set(ByVal value As String)
            strlmaslineas = value
        End Set
    End Property
    Public Property vereda() As String
        Get
            Return strlvereda
        End Get
        Set(ByVal value As String)
            strlvereda = value
        End Set
    End Property
    Public Property portada() As String
        Get
            Return strlportada
        End Get
        Set(ByVal value As String)
            strlportada = value
        End Set
    End Property
    Public Property caracter() As String
        Get
            Return strlcaracter
        End Get
        Set(ByVal value As String)
            strlcaracter = value
        End Set
    End Property
    Public Property tiempo() As String
        Get
            Return strltiempo
        End Get
        Set(ByVal value As String)
            strltiempo = value
        End Set
    End Property
    Public Property tickler() As String
        Get
            Return strltickler
        End Get
        Set(ByVal value As String)
            strltickler = value
        End Set
    End Property
    Public Property fcsap() As String
        Get
            Return strlfcsap
        End Get
        Set(ByVal value As String)
            strlfcsap = value
        End Set
    End Property
    Public Property tipofalla() As String
        Get
            Return strltipofalla
        End Get
        Set(ByVal value As String)
            strltipofalla = value
        End Set
    End Property
    Public Property areafalla() As String
        Get
            Return strlareafalla
        End Get
        Set(ByVal value As String)
            strlareafalla = value
        End Set
    End Property
    Public Property dir() As String
        Get
            Return strldir
        End Get
        Set(ByVal value As String)
            strldir = value
        End Set
    End Property
    Public Property mun() As String
        Get
            Return strlmun
        End Get
        Set(ByVal value As String)
            strlmun = value
        End Set
    End Property
    Public Property dpto() As String
        Get
            Return strldpto
        End Get
        Set(ByVal value As String)
            strldpto = value
        End Set
    End Property
    Public Property zona() As String
        Get
            Return strlzona
        End Get
        Set(ByVal value As String)
            strlzona = value
        End Set
    End Property
    Public Property mesaesc() As String
        Get
            Return strlmesaesc
        End Get
        Set(ByVal value As String)
            strlmesaesc = value
        End Set
    End Property
    Public Property telalt() As String
        Get
            Return strltelalt
        End Get
        Set(ByVal value As String)
            strltelalt = value
        End Set
    End Property
    Public Property barrio() As String
        Get
            Return strlbarrio
        End Get
        Set(ByVal value As String)
            strlbarrio = value
        End Set
    End Property
    Public Property chk2() As String
        Get
            Return strlchk2
        End Get
        Set(ByVal value As String)
            strlchk2 = value
        End Set
    End Property
    Public Property chk1() As String
        Get
            Return strlchk1
        End Get
        Set(ByVal value As String)
            strlchk1 = value
        End Set
    End Property
    Public Property fcfin3() As String
        Get
            Return strlfcfin3
        End Get
        Set(ByVal value As String)
            strlfcfin3 = value
        End Set
    End Property
    Public Property fcini3() As String
        Get
            Return strlfcini3
        End Get
        Set(ByVal value As String)
            strlfcini3 = value
        End Set
    End Property
    Public Property pqr() As String
        Get
            Return strlpqr
        End Get
        Set(ByVal value As String)
            strlpqr = value
        End Set
    End Property
    Public Property ingn3() As String
        Get
            Return strlingn3
        End Get
        Set(ByVal value As String)
            strlingn3 = value
        End Set
    End Property
    Public Property fcingn3() As String
        Get
            Return strlfcingn3
        End Get
        Set(ByVal value As String)
            strlfcingn3 = value
        End Set
    End Property
    Public Property mesa() As String
        Get
            Return strlmesa
        End Get
        Set(ByVal value As String)
            strlmesa = value
        End Set
    End Property
    Public Property estadoinc() As String
        Get
            Return strlestadoinc
        End Get
        Set(ByVal value As String)
            strlestadoinc = value
        End Set
    End Property
    Public Property incidente() As String
        Get
            Return strlincidente
        End Get
        Set(ByVal value As String)
            strlincidente = value
        End Set
    End Property
    Public Property tecnologia() As String
        Get
            Return strltecnologia
        End Get
        Set(ByVal value As String)
            strltecnologia = value
        End Set
    End Property
    Public Property telcontacto() As String
        Get
            Return strltelcontacto
        End Get
        Set(ByVal value As String)
            strltelcontacto = value
        End Set
    End Property
    Public Property fcfin() As String
        Get
            Return strlfcfin
        End Get
        Set(ByVal value As String)
            strlfcfin = value
        End Set
    End Property
    Public Property fcini() As String
        Get
            Return strlfcini
        End Get
        Set(ByVal value As String)
            strlfcini = value
        End Set
    End Property
    Public Property obsini() As String
        Get
            Return strlobsini
        End Get
        Set(ByVal value As String)
            strlobsini = value
        End Set
    End Property
    Public Property preg1() As String
        Get
            Return strlpreg1
        End Get
        Set(ByVal value As String)
            strlpreg1 = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return strlemail
        End Get
        Set(ByVal value As String)
            strlemail = value
        End Set
    End Property
    Public Property lugar() As String
        Get
            Return strllugar
        End Get
        Set(ByVal value As String)
            strllugar = value
        End Set
    End Property
    Public Property equipo() As String
        Get
            Return strlequipo
        End Get
        Set(ByVal value As String)
            strlequipo = value
        End Set
    End Property
    Public Property plan() As String
        Get
            Return strlplan
        End Get
        Set(ByVal value As String)
            strlplan = value
        End Set
    End Property
    Public Property documento() As String
        Get
            Return strldocumento
        End Get
        Set(ByVal value As String)
            strldocumento = value
        End Set
    End Property
    Public Property cliente() As String
        Get
            Return strlcliente
        End Get
        Set(ByVal value As String)
            strlcliente = value
        End Set
    End Property
    Public Property min() As String
        Get
            Return strlmin
        End Get
        Set(ByVal value As String)
            strlmin = value
        End Set
    End Property
    Public Property casfcregistro() As String
        Get
            Return strlcasfcregistro
        End Get
        Set(ByVal value As String)
            strlcasfcregistro = value
        End Set
    End Property
    Public Property tipificacion() As String
        Get
            Return strltipificacion
        End Get
        Set(ByVal value As String)
            strltipificacion = value
        End Set
    End Property
    Public Property tiposoporte() As String
        Get
            Return strltiposoporte
        End Get
        Set(ByVal value As String)
            strltiposoporte = value
        End Set
    End Property
    Public Property obs() As String
        Get
            Return strlobs
        End Get
        Set(ByVal value As String)
            strlobs = value
        End Set
    End Property
    Public Property idusuario() As String
        Get
            Return strlidusuario
        End Get
        Set(ByVal value As String)
            strlidusuario = value
        End Set
    End Property
    Public Property fcreg() As String
        Get
            Return strlfcreg
        End Get
        Set(ByVal value As String)
            strlfcreg = value
        End Set
    End Property
    Public Property idcrm() As String
        Get
            Return strlidcrm
        End Get
        Set(ByVal value As String)
            strlidcrm = value
        End Set
    End Property
    Public Property caso() As String
        Get
            Return strlcaso
        End Get
        Set(ByVal value As String)
            strlcaso = value
        End Set
    End Property
    Public Property cantidad() As String
        Get
            Return strlcantidad
        End Get
        Set(ByVal value As String)
            strlcantidad = value
        End Set
    End Property
    'Declaración de variable
    Protected _Grupo_Asignado As String
    'Encapsulación de variable
    Public Property Grupo_Asignado As String
        Get
            Return _Grupo_Asignado
        End Get
        Set(ByVal value As String)
            _Grupo_Asignado = value
        End Set
    End Property

    Protected _N_Doc_Id As String
    Public Property N_Doc_Id As String
        Get
            Return _N_Doc_Id
        End Get
        Set(value As String)
            _N_Doc_Id = value
        End Set
    End Property



    Public Function consultacasovoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT fallatec,bandeja_uni.idcaso, cas_fecha_registro, tipoinc, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, bandeja, estado, idcrm, fcreg, idusuario, obs, VCRMDetalle.tipificacion, tiposoporte, destiposoporte, numalt, VCRMDetalle.Fc_Program  FROM VCRMDetalle Left JOIN VSoporte ON VCRMDetalle.tiposoporte = VSoporte.idsoporte RIGHT OUTER JOIN Bandeja_uni ON VCRMDetalle.idcaso = Bandeja_uni.idcaso where bandeja_uni.idcaso=@strlcaso order by idcrm desc"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("documento") Is System.DBNull.Value Then
                    strldocumento = " "
                Else
                    strldocumento = dtsrecepcion.Tables(0).Rows(0).Item("documento")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("min_ac") Is System.DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dtsrecepcion.Tables(0).Rows(0).Item("min_ac")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("equipo_ac") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("equipo_ac")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("idcaso") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("idcaso")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipoinc") Is System.DBNull.Value Then
                    strlobsini = " "
                Else
                    strlobsini = dtsrecepcion.Tables(0).Rows(0).Item("tipoinc")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("bandeja") Is System.DBNull.Value Then
                    strlmesa = " "
                Else
                    strlmesa = dtsrecepcion.Tables(0).Rows(0).Item("bandeja")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fallatec") Is System.DBNull.Value Then
                    strlfallatec = " "
                Else
                    strlfallatec = dtsrecepcion.Tables(0).Rows(0).Item("fallatec")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cas_fecha_registro") Is System.DBNull.Value Then
                    strlcasfcregistro = " "
                Else
                    strlcasfcregistro = dtsrecepcion.Tables(0).Rows(0).Item("cas_fecha_registro")
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
    Public Function casosasociados() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlmin <> Nothing Then
                cms.CommandText = "SELECT idcaso, min_ac, estado, bandeja FROM  Bandeja_uni where estado <>'cerrado' and estado<>'ilocalizable' and min_ac=@strlmin"
                cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 50).Value = Me.strlmin
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub registrocrmvoz()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If strlpreg2 <> Nothing Then
                cms.CommandText = "INSERT INTO Vcrmdetalle(idbarrio,idcaso,fcreg,idusuario,obs,tipificacion,tiposoporte,preg1,preg2,preg3,numalt,PQR,Fc_Program) values(@strlbarrio,@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,@strltiposoporte,@strlpreg1,@strlpreg2,@strlpreg3,@strltelalt,@strlpqr,@FcProgramado)"
                cms.Parameters.Add("@strlpreg2", SqlDbType.VarChar, 255).Value = strlpreg2
                cms.Parameters.Add("@strlpreg3", SqlDbType.VarChar, 255).Value = strlpreg3
            Else
                cms.CommandText = "INSERT INTO Vcrmdetalle(idbarrio,idcaso,fcreg,idusuario,obs,tipificacion,tiposoporte,preg1,numalt,PQR,Fc_Program) values(@strlbarrio,@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,@strltiposoporte,@strlpreg1,@strltelalt,@strlpqr,@FcProgramado)"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltiposoporte", SqlDbType.VarChar, 255).Value = strltiposoporte
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            cms.Parameters.Add("@strlpqr", SqlDbType.BigInt).Value = strlpqr
            If strlpreg1 <> Nothing Then
                cms.Parameters.Add("@strlpreg1", SqlDbType.VarChar, 255).Value = strlpreg1
            Else
                cms.Parameters.AddWithValue("@strlpreg1", DBNull.Value)
            End If
            If strltelalt <> Nothing Then
                cms.Parameters.Add("@strltelalt", SqlDbType.VarChar, 100).Value = strltelalt
            Else
                cms.Parameters.AddWithValue("@strltelalt", DBNull.Value)
            End If
            If strlbarrio <> Nothing Then
                cms.Parameters.Add("@strlbarrio", SqlDbType.Int).Value = strlbarrio
            Else
                cms.Parameters.AddWithValue("@strlbarrio", DBNull.Value)
            End If
            If fcfin <> Nothing Then
                cms.Parameters.AddWithValue("@FcProgramado", SqlDbType.DateTime).Value = fcfin
            Else
                cms.Parameters.AddWithValue("@FcProgramado", DBNull.Value)
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
    Public Sub modificarbandeja()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If strltipificacion = "CERRADO" Or strltipificacion = "Previamente Cerrado" Then
                cms.CommandText = "UPDATE bandeja_uni SET estadofallatec=@strlfallatec,escalam=@strlescala,munic=@strlmun, equipo_ac=@strlequipo, estado= 'CERRADO' WHERE idcaso= @strlcaso and estado <> 'cerrado'"
            End If
            If strltipificacion = "ESCALADO" Then
                cms.CommandText = "UPDATE bandeja_uni SET estadofallatec=@strlfallatec,escalam=@strlescala,munic=@strlmun,equipo_ac=@strlequipo, estado= 'ESCALADO' WHERE idcaso= @strlcaso and estado <> 'cerrado' and estado <> 'escalado' and estado <> 'RECHAZADO'"
            End If
            If strltipificacion = "RECHAZADO" Then
                cms.CommandText = "UPDATE bandeja_uni SET estadofallatec=@strlfallatec,escalam=@strlescala,munic=@strlmun,equipo_ac=@strlequipo, estado= 'RECHAZADO' WHERE idcaso= @strlcaso and estado <> 'cerrado' and estado <> 'RECHAZADO'"
            End If
            If strltipificacion = "GESTIONADO" Or strltipificacion = "Programado" Then
                cms.CommandText = "UPDATE bandeja_uni SET estadofallatec=@strlfallatec,escalam=@strlescala,munic=@strlmun,equipo_ac=@strlequipo, estado= 'GESTIONADO' WHERE idcaso= @strlcaso and estado <> 'cerrado' and estado <> 'escalado' and estado <> 'ilocalizable' and estado <> 'RECHAZADO'"
            End If
            If strltipificacion = "PROGRAMADO" Then
                cms.CommandText = "UPDATE bandeja_uni SET estadofallatec=@strlfallatec,escalam=@strlescala,munic=@strlmun,equipo_ac=@strlequipo, estado= 'PROGRAMADO' WHERE idcaso= @strlcaso and estado <> 'cerrado' and estado <> 'escalado' and estado <> 'ilocalizable' and estado <> 'RECHAZADO'"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 10).Value = strlmun
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = strltipificacion
            cms.Parameters.Add("@strlequipo", SqlDbType.VarChar, 100).Value = strlequipo
            cms.Parameters.Add("@strlescala", SqlDbType.VarChar, 2).Value = strlescala
            cms.Parameters.Add("@strlfallatec", SqlDbType.VarChar, 50).Value = strlfallatec
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
    Public Sub registrofallasred()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO VFallared(N_Doc_Id,idcaso,personacontacto,numcontacto,tiempofalla,tipofalla,caractfalla,portada,munfalla,ciudad,direccion,barrio,tecnologia,equipo,maslineas,obscliente,fcregistro,idusuario,campana,apn,qos,fc_ingreso,Falla_Presenta_Luego_Construyera_Edificacion_Aledania,Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,Tipo_Edificacion_Donde_Presenta_Falla,Validaciones_Falla_Masiva,Tecnologia_Presenta_Falla_Luegodepruebas,Validacion_Coordenadas,Linea_No_Cuenta_Bloqueos_Internet,Linea_No_Superado_Limite_Consumos,Linea_No_Encuentra_Enrutada_PorPagos,HLR_HSS,No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,Forza_Red_Dispositivo,Verifica_Realiza_Configuración_APN,Equipo_Encuentra_Homologado_Operador,Realiza_Conciliacion_Sobre_linea) values (@_N_Doc_Id,@strlcaso,@strlcliente,@strltelcontacto,@strltiempo,@strltipofalla,@strlcaracter,@strlportada,@strlmun,@strlvereda,@strldir,@strlbarrio,@strltecnologia,@strlequipo,@strlmaslineas,@strlobs,@strlfcreg,@strlidusuario,@strlcampana,@strlapn,@strlqos,@strlfcini,@_Falla_Presenta_Luego_Construyera_Edificacion_Aledania,@_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,@_Tipo_Edificacion_Donde_Presenta_Falla,@_Validaciones_Falla_Masiva,@_Tecnologia_Presenta_Falla_Luegodepruebas,@_Validacion_Coordenadas,@_Linea_No_Cuenta_Bloqueos_Internet,@_Linea_No_Superado_Limite_Consumos,@_Linea_No_Encuentra_Enrutada_PorPagos,@_HLR_HSS,@_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,@_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,@_Forza_Red_Dispositivo,@_Verifica_Realiza_Configuración_APN,@_Equipo_Encuentra_Homologado_Operador,@_Realiza_Conciliacion_Sobre_linea)"
            If StrlCanal <> Nothing Then
                cms.CommandText = "INSERT INTO VFallared(N_Doc_Id,Canal_Dilo,idcaso,personacontacto,numcontacto,tiempofalla,tipofalla,caractfalla,portada,munfalla,ciudad,direccion,barrio,tecnologia,equipo,maslineas,obscliente,fcregistro,idusuario,campana,apn,qos,fc_ingreso,Falla_Presenta_Luego_Construyera_Edificacion_Aledania,Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,Tipo_Edificacion_Donde_Presenta_Falla,Validaciones_Falla_Masiva,Tecnologia_Presenta_Falla_Luegodepruebas,Validacion_Coordenadas,Linea_No_Cuenta_Bloqueos_Internet,Linea_No_Superado_Limite_Consumos,Linea_No_Encuentra_Enrutada_PorPagos,HLR_HSS,No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,Forza_Red_Dispositivo,Verifica_Realiza_Configuración_APN,Equipo_Encuentra_Homologado_Operador,Realiza_Conciliacion_Sobre_linea) values (@_N_Doc_Id,@CanalDilo,@strlcaso,@strlcliente,@strltelcontacto,@strltiempo,@strltipofalla,@strlcaracter,@strlportada,@strlmun,@strlvereda,@strldir,@strlbarrio,@strltecnologia,@strlequipo,@strlmaslineas,@strlobs,@strlfcreg,@strlidusuario,@strlcampana,@strlapn,@strlqos,@strlfcini,@_Falla_Presenta_Luego_Construyera_Edificacion_Aledania,@_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,@_Tipo_Edificacion_Donde_Presenta_Falla,@_Validaciones_Falla_Masiva,@_Tecnologia_Presenta_Falla_Luegodepruebas,@_Validacion_Coordenadas,@_Linea_No_Cuenta_Bloqueos_Internet,@_Linea_No_Superado_Limite_Consumos,@_Linea_No_Encuentra_Enrutada_PorPagos,@_HLR_HSS,@_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,@_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,@_Forza_Red_Dispositivo,@_Verifica_Realiza_Configuración_APN,@_Equipo_Encuentra_Homologado_Operador,@_Realiza_Conciliacion_Sobre_linea)"
                cms.Parameters.Add("@CanalDilo", SqlDbType.VarChar, 50).Value = StrlCanal
            End If

            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlcliente", SqlDbType.NVarChar, 255).Value = strlcliente
            cms.Parameters.Add("@strltelcontacto", SqlDbType.NVarChar, 20).Value = strltelcontacto
            cms.Parameters.Add("@strltiempo", SqlDbType.NVarChar, 20).Value = strltiempo
            cms.Parameters.Add("@strltipofalla", SqlDbType.NVarChar, 255).Value = strltipofalla
            cms.Parameters.Add("@strlcaracter", SqlDbType.VarChar).Value = strlcaracter
            cms.Parameters.Add("@strlportada", SqlDbType.VarChar, 50).Value = strlportada
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 20).Value = strlmun
            cms.Parameters.Add("@strlvereda", SqlDbType.NVarChar, 255).Value = strlvereda
            cms.Parameters.Add("@strldir", SqlDbType.NVarChar, 255).Value = strldir
            cms.Parameters.Add("@strlbarrio", SqlDbType.NVarChar, 255).Value = strlbarrio
            cms.Parameters.Add("@strltecnologia", SqlDbType.NVarChar, 50).Value = strltecnologia
            cms.Parameters.Add("@strlequipo", SqlDbType.NVarChar, 100).Value = strlequipo
            cms.Parameters.Add("@strlmaslineas", SqlDbType.NVarChar, 20).Value = strlmaslineas
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlcampana", SqlDbType.VarChar, 50).Value = strlcampana
            cms.Parameters.Add("@strlapn", SqlDbType.VarChar, 50).Value = strlapn
            cms.Parameters.Add("@strlqos", SqlDbType.VarChar, 50).Value = strlqos
            cms.Parameters.Add("@strlfcini", SqlDbType.DateTime).Value = strlfcini
            cms.Parameters.AddWithValue("@_N_Doc_Id", _N_Doc_Id)
            If _Falla_Presenta_Luego_Construyera_Edificacion_Aledania <> Nothing Then
                cms.Parameters.Add("@_Falla_Presenta_Luego_Construyera_Edificacion_Aledania", SqlDbType.VarChar, 10).Value = _Falla_Presenta_Luego_Construyera_Edificacion_Aledania
            Else
                cms.Parameters.AddWithValue("@_Falla_Presenta_Luego_Construyera_Edificacion_Aledania", DBNull.Value)
            End If
            If _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio <> Nothing Then
                cms.Parameters.Add("@_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio", SqlDbType.VarChar, 10).Value = _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio
            Else
                cms.Parameters.AddWithValue("@_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio", DBNull.Value)
            End If
            If _Tipo_Edificacion_Donde_Presenta_Falla <> Nothing Then
                cms.Parameters.Add("@_Tipo_Edificacion_Donde_Presenta_Falla", SqlDbType.VarChar, 50).Value = _Tipo_Edificacion_Donde_Presenta_Falla
            Else
                cms.Parameters.AddWithValue("@_Tipo_Edificacion_Donde_Presenta_Falla", DBNull.Value)
            End If
            If _Validaciones_Falla_Masiva <> Nothing Then
                cms.Parameters.Add("@_Validaciones_Falla_Masiva", SqlDbType.VarChar, 10).Value = _Validaciones_Falla_Masiva
            Else
                cms.Parameters.AddWithValue("@_Validaciones_Falla_Masiva", DBNull.Value)
            End If
            If _Tecnologia_Presenta_Falla_Luegodepruebas <> Nothing Then
                cms.Parameters.Add("@_Tecnologia_Presenta_Falla_Luegodepruebas", SqlDbType.VarChar, 50).Value = _Tecnologia_Presenta_Falla_Luegodepruebas
            Else
                cms.Parameters.AddWithValue("@_Tecnologia_Presenta_Falla_Luegodepruebas", DBNull.Value)
            End If
            If _Validacion_Coordenadas <> Nothing Then
                cms.Parameters.Add("@_Validacion_Coordenadas", SqlDbType.VarChar, 20).Value = _Validacion_Coordenadas
            Else
                cms.Parameters.AddWithValue("@_Validacion_Coordenadas", DBNull.Value)
            End If
            If _Linea_No_Cuenta_Bloqueos_Internet <> Nothing Then
                cms.Parameters.Add("@_Linea_No_Cuenta_Bloqueos_Internet", SqlDbType.VarChar, 10).Value = _Linea_No_Cuenta_Bloqueos_Internet
            Else
                cms.Parameters.AddWithValue("@_Linea_No_Cuenta_Bloqueos_Internet", DBNull.Value)
            End If
            If _Linea_No_Superado_Limite_Consumos <> Nothing Then
                cms.Parameters.Add("@_Linea_No_Superado_Limite_Consumos", SqlDbType.VarChar, 10).Value = _Linea_No_Superado_Limite_Consumos
            Else
                cms.Parameters.AddWithValue("@_Linea_No_Superado_Limite_Consumos", DBNull.Value)
            End If
            If _Linea_No_Encuentra_Enrutada_PorPagos <> Nothing Then
                cms.Parameters.Add("@_Linea_No_Encuentra_Enrutada_PorPagos", SqlDbType.VarChar, 10).Value = _Linea_No_Encuentra_Enrutada_PorPagos
            Else
                cms.Parameters.AddWithValue("@_Linea_No_Encuentra_Enrutada_PorPagos", DBNull.Value)
            End If
            If _HLR_HSS <> Nothing Then
                cms.Parameters.Add("@_HLR_HSS", SqlDbType.VarChar, 50).Value = _HLR_HSS
            Else
                cms.Parameters.AddWithValue("@_HLR_HSS", DBNull.Value)
            End If
            If _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra <> Nothing Then
                cms.Parameters.Add("@_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra", SqlDbType.VarChar, 100).Value = _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra
            Else
                cms.Parameters.AddWithValue("@_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra", DBNull.Value)
            End If
            If _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla <> Nothing Then
                cms.Parameters.Add("@_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla", SqlDbType.VarChar, 10).Value = _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla
            Else
                cms.Parameters.AddWithValue("@_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla", DBNull.Value)
            End If
            If _Forza_Red_Dispositivo <> Nothing Then
                cms.Parameters.Add("@_Forza_Red_Dispositivo", SqlDbType.VarChar, 50).Value = _Forza_Red_Dispositivo
            Else
                cms.Parameters.AddWithValue("@_Forza_Red_Dispositivo", DBNull.Value)
            End If
            If _Verifica_Realiza_Configuración_APN <> Nothing Then
                cms.Parameters.Add("@_Verifica_Realiza_Configuración_APN", SqlDbType.VarChar, 50).Value = _Verifica_Realiza_Configuración_APN
            Else
                cms.Parameters.AddWithValue("@_Verifica_Realiza_Configuración_APN", DBNull.Value)
            End If
            If _Equipo_Encuentra_Homologado_Operador <> Nothing Then
                cms.Parameters.Add("@_Equipo_Encuentra_Homologado_Operador", SqlDbType.VarChar, 10).Value = _Equipo_Encuentra_Homologado_Operador
            Else
                cms.Parameters.AddWithValue("@_Equipo_Encuentra_Homologado_Operador", DBNull.Value)
            End If
            If _Realiza_Conciliacion_Sobre_linea <> Nothing Then
                cms.Parameters.Add("@_Realiza_Conciliacion_Sobre_linea", SqlDbType.VarChar, 10).Value = _Realiza_Conciliacion_Sobre_linea
            Else
                cms.Parameters.AddWithValue("@_Realiza_Conciliacion_Sobre_linea", DBNull.Value)
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
  
    
    Public Function consultaasigxusu() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idcaso,campana,idusuario,fc_ingreso,fcregistro,fcasignado FROM VFallared where asignado is not null and cpd is null and idusuriocpd=@strlidusuario order by idcaso"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultacasoescalado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT canal_dilo,apn,qos,campana,resolucion,solucion,idcaso,personacontacto,N_Doc_Id,numcontacto,tiempofalla,tipofalla,caractfalla,portada,nombredpto, nombremun,ciudad,direccion,barrio,tecnologia,equipo,maslineas,obscliente,fcregistro,idusuario,idusuriocpd,fcasignado,asignado,Falla_Presenta_Luego_Construyera_Edificacion_Aledania,Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,Tipo_Edificacion_Donde_Presenta_Falla,Validaciones_Falla_Masiva,Tecnologia_Presenta_Falla_Luegodepruebas,Validacion_Coordenadas,Linea_No_Cuenta_Bloqueos_Internet,Linea_No_Superado_Limite_Consumos,Linea_No_Encuentra_Enrutada_PorPagos,HLR_HSS,No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,Forza_Red_Dispositivo,Verifica_Realiza_Configuración_APN,Equipo_Encuentra_Homologado_Operador,Realiza_Conciliacion_Sobre_linea from vfallared  LEFT OUTER JOIN Divipola on vfallared.munfalla = Divipola.coddiv where idcaso=@strlcaso and cpd is null and idusuriocpd=@strlidusuario and asignado='-1'"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                N_Doc_Id = dtsrecepcion.Tables(0).Rows(0).Item("N_Doc_Id").ToString
                If dtsrecepcion.Tables(0).Rows(0).Item("personacontacto") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("personacontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("numcontacto") Is System.DBNull.Value Then
                    strltelcontacto = " "
                Else
                    strltelcontacto = dtsrecepcion.Tables(0).Rows(0).Item("numcontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla") Is System.DBNull.Value Then
                    strltiempo = " "
                Else
                    strltiempo = dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipofalla") Is System.DBNull.Value Then
                    strltipofalla = " "
                Else
                    strltipofalla = dtsrecepcion.Tables(0).Rows(0).Item("tipofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("caractfalla") Is System.DBNull.Value Then
                    strlcaracter = " "
                Else
                    strlcaracter = dtsrecepcion.Tables(0).Rows(0).Item("caractfalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("portada") Is System.DBNull.Value Then
                    strlportada = " "
                Else
                    strlportada = dtsrecepcion.Tables(0).Rows(0).Item("portada")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombredpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("nombredpto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombremun") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("nombremun")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("ciudad") Is System.DBNull.Value Then
                    strlvereda = " "
                Else
                    strlvereda = dtsrecepcion.Tables(0).Rows(0).Item("ciudad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("direccion") Is System.DBNull.Value Then
                    strldir = " "
                Else
                    strldir = dtsrecepcion.Tables(0).Rows(0).Item("direccion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dtsrecepcion.Tables(0).Rows(0).Item("barrio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tecnologia") Is System.DBNull.Value Then
                    strltecnologia = " "
                Else
                    strltecnologia = dtsrecepcion.Tables(0).Rows(0).Item("tecnologia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("equipo") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("equipo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("maslineas") Is System.DBNull.Value Then
                    strlmaslineas = " "
                Else
                    strlmaslineas = dtsrecepcion.Tables(0).Rows(0).Item("maslineas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("obscliente") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obscliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("resolucion") Is System.DBNull.Value Then
                    strlresolucion = " "
                Else
                    strlresolucion = dtsrecepcion.Tables(0).Rows(0).Item("resolucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("solucion") Is System.DBNull.Value Then
                    strlsolucion = " "
                Else
                    strlsolucion = dtsrecepcion.Tables(0).Rows(0).Item("solucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("campana") Is System.DBNull.Value Then
                    strlcampana = " "
                Else
                    strlcampana = dtsrecepcion.Tables(0).Rows(0).Item("campana")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apn") Is System.DBNull.Value Then
                    strlapn = " "
                Else
                    strlapn = dtsrecepcion.Tables(0).Rows(0).Item("apn")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("qos") Is System.DBNull.Value Then
                    strlqos = " "
                Else
                    strlqos = dtsrecepcion.Tables(0).Rows(0).Item("qos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("canal_dilo") Is System.DBNull.Value Then
                    StrlCanal = " "
                Else
                    StrlCanal = dtsrecepcion.Tables(0).Rows(0).Item("canal_dilo")
                End If
                ''''Validaciones servicio al cliente'''''
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = " "
                Else
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = " "
                Else
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla") Is System.DBNull.Value Then
                    _Tipo_Edificacion_Donde_Presenta_Falla = " "
                Else
                    _Tipo_Edificacion_Donde_Presenta_Falla = dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva") Is System.DBNull.Value Then
                    _Validaciones_Falla_Masiva = " "
                Else
                    _Validaciones_Falla_Masiva = dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas") Is System.DBNull.Value Then
                    _Tecnologia_Presenta_Falla_Luegodepruebas = " "
                Else
                    _Tecnologia_Presenta_Falla_Luegodepruebas = dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas") Is System.DBNull.Value Then
                    _Validacion_Coordenadas = " "
                Else
                    _Validacion_Coordenadas = dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet") Is System.DBNull.Value Then
                    _Linea_No_Cuenta_Bloqueos_Internet = " "
                Else
                    _Linea_No_Cuenta_Bloqueos_Internet = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos") Is System.DBNull.Value Then
                    _Linea_No_Superado_Limite_Consumos = " "
                Else
                    _Linea_No_Superado_Limite_Consumos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos") Is System.DBNull.Value Then
                    _Linea_No_Encuentra_Enrutada_PorPagos = " "
                Else
                    _Linea_No_Encuentra_Enrutada_PorPagos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS") Is System.DBNull.Value Then
                    _HLR_HSS = " "
                Else
                    _HLR_HSS = dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra") Is System.DBNull.Value Then
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = " "
                Else
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla") Is System.DBNull.Value Then
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = " "
                Else
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo") Is System.DBNull.Value Then
                    _Forza_Red_Dispositivo = " "
                Else
                    _Forza_Red_Dispositivo = dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN") Is System.DBNull.Value Then
                    _Verifica_Realiza_Configuración_APN = " "
                Else
                    _Verifica_Realiza_Configuración_APN = dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador") Is System.DBNull.Value Then
                    _Equipo_Encuentra_Homologado_Operador = " "
                Else
                    _Equipo_Encuentra_Homologado_Operador = dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea") Is System.DBNull.Value Then
                    _Realiza_Conciliacion_Sobre_linea = " "
                Else
                    _Realiza_Conciliacion_Sobre_linea = dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea")
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
    '***************    MODIFICADO  **************
    Public Sub actualizacpd()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE VFallared SET Grupo_asignado = @_Grupo_Asignado, devuelto=@strldevolver,cpd=@strlcpd, estadocpd=@strlEstado,obscpd=@strlobs, fcregcpd=@strlfcreg WHERE idcaso= @strlcaso"
            If strlareafalla <> Nothing Then
                cms.CommandText = "UPDATE VFallared SET Grupo_asignado = @_Grupo_Asignado, devuelto=@strldevolver,cpd=@strlcpd, estadocpd='ANULADO',obscpd=@strlobs, fcregcpd=@strlfcreg WHERE idcaso= @strlcaso"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlcpd", SqlDbType.VarChar, 20).Value = strlcpd
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strldevolver", SqlDbType.VarChar, 2).Value = strldevolver
            cms.Parameters.Add("@_Grupo_Asignado", SqlDbType.VarChar, 50).Value = _Grupo_Asignado
            cms.Parameters.Add("@strlEstado", SqlDbType.VarChar, 50).Value = _Estado_Llamada
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
    '**********************************************

    Public Sub Actualiza_Estado_Bandeja_Voz()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja_uni SET estado=@strltipificacion WHERE idcaso=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar).Value = strltipificacion
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
    Public Function consultagralvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where bu.idcaso=@strlcaso order by idcaso desc"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            If strlmin <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where min_ac=@strlmin order by idcaso desc"
                cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 50).Value = Me.strlmin
            End If
            If strlcliente <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where nom_cliente like '%'+@strlcliente+'%' order by idcaso desc"
                cms.Parameters.Add("@strlcliente", SqlDbType.VarChar, 100).Value = Me.strlcliente
            End If
            If strlmesa <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where bandeja=@strlmesa order by idcaso desc"
                cms.Parameters.Add("@strlmesa", SqlDbType.VarChar, 100).Value = Me.strlmesa
            End If
            If strlfallatec <> Nothing Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where fallatec is not null and (estadofallatec is null or estadofallatec='' or estadofallatec='0') order by idcaso desc"
            End If
            If strlfcsap <> Nothing Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where fcsap=@strlfcsap order by idcaso desc"
                cms.Parameters.Add("@strlfcsap", SqlDbType.VarChar, 100).Value = Me.strlfcsap
                If strlfallatec <> Nothing Then
                    cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where fallatec is not null and (estadofallatec is null or estadofallatec='' or estadofallatec='0') and fcsap=@strlfcsap order by idcaso desc"
                End If
            End If
            'nuevos
            If strlnit <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where documento=@strlnit"
                cms.Parameters.Add("@strlnit", SqlDbType.VarChar, 50).Value = Me.strlnit
            End If
            If strlfechainicial <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where cas_fecha_registro >= @fechainicial"
                cms.Parameters.Add("@fechainicial", SqlDbType.VarChar, 50).Value = Me.strlfechainicial
            End If
            If strlfechafin <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where cas_fecha_registro <= @fechafin"
                cms.Parameters.Add("@fechafin", SqlDbType.VarChar, 50).Value = Me.strlfechafin
            End If
            If strlfechainicial <> "" And strlfechafin <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where cas_fecha_registro >= @fechainicial  and cas_fecha_registro <= @fechafin"
            End If
            If strlfechainicial <> "" And strlnit <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where documento=@strlnit and cas_fecha_registro >= @fechainicial"
            End If
            If strlfechafin <> "" And strlnit <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where documento=@strlnit and cas_fecha_registro <= @fechafin"
            End If
            If strlfechainicial <> "" And strlfechafin <> "" And strlnit <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where documento=@strlnit and cas_fecha_registro >= @fechainicial  and cas_fecha_registro <= @fechafin"
            End If
            If strlfechainicial <> "" And strlcliente <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where nom_cliente like '%'+@strlcliente+'%' and cas_fecha_registro >= @fechainicial"
            End If
            If strlfechafin <> "" And strlcliente <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where nom_cliente like '%'+@strlcliente+'%' and cas_fecha_registro <= @fechafin"
            End If
            If strlfechainicial <> "" And strlfechafin <> "" And strlcliente <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where nom_cliente like '%'+@strlcliente+'%' and cas_fecha_registro >= @fechainicial  and cas_fecha_registro <= @fechafin"
            End If
            If strlfechainicial <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where min_ac=@strlmin and cas_fecha_registro >= @fechainicial"
            End If
            If strlfechafin <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where min_ac=@strlmin and cas_fecha_registro <= @fechafin"
            End If
            If strlfechainicial <> "" And strlfechafin <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT fcsap,fallatec,estadofallatec,bu.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja,bu.estado ,cpd,estadocpd,s.tickler from bandeja_uni bu left join vfallared f on bu.idcaso= f.idcaso left join servicedetalle  s on bu.idcaso=s.idcaso where min_ac=@strlmin and cas_fecha_registro >= @fechainicial  and cas_fecha_registro <= @fechafin"
            End If
            ' Filtros por tipificacion:
            If strltipificacion <> Nothing Then
                cms.CommandText = "SELECT VCRMD.idcaso, Bu.cas_fecha_registro, VCRMD.fcreg, Bu.min_ac, VCRMD.obs, VCRMD.tipificacion FROM VCRMDetalle VCRMD INNER JOIN Bandeja_uni Bu ON VCRMD.idcaso = Bu.idcaso WHERE VCRMD.tipificacion Like '%" + strltipificacion + "%'"
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 100).Value = Me.strltipificacion
            End If
            If strlfechainicial <> "" And strltipificacion <> "" Then
                cms.CommandText = "SELECT VCRMD.idcaso, Bu.cas_fecha_registro, VCRMD.fcreg, Bu.min_ac, VCRMD.obs, VCRMD.tipificacion FROM VCRMDetalle VCRMD INNER JOIN Bandeja_uni Bu ON VCRMD.idcaso = Bu.idcaso WHERE VCRMD.fcreg>=@fechainicial AND VCRMD.tipificacion Like '%" + strltipificacion + "%'"
            End If
            If strlfechafin <> "" And strltipificacion <> "" Then
                cms.CommandText = "SELECT VCRMD.idcaso, Bu.cas_fecha_registro, VCRMD.fcreg, Bu.min_ac, VCRMD.obs, VCRMD.tipificacion FROM VCRMDetalle VCRMD INNER JOIN Bandeja_uni Bu ON VCRMD.idcaso = Bu.idcaso WHERE VCRMD.fcreg<=@fechafin AND VCRMD.tipificacion Like '%" + strltipificacion + "%'"
            End If
            If strlfechainicial <> "" And strlfechafin <> "" And strltipificacion <> "" Then
                cms.CommandText = "SELECT VCRMD.idcaso, Bu.cas_fecha_registro, VCRMD.fcreg, Bu.min_ac, VCRMD.obs, VCRMD.tipificacion FROM VCRMDetalle VCRMD INNER JOIN Bandeja_uni Bu ON VCRMD.idcaso = Bu.idcaso WHERE VCRMD.fcreg>=@fechainicial And VCRMD.fcreg<=@fechafin AND VCRMD.tipificacion Like '%" + strltipificacion + "%'"
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultasegvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> "" Then
                cms.CommandText = "SELECT fallared,vcrmdetalle.idcaso, fcreg, idusuario, obs, vcrmdetalle.tipificacion, numalt, min_ac FROM VCRMDetalle INNER JOIN Bandeja_uni ON VCRMDetalle.idcaso = Bandeja_uni.idcaso where vcrmdetalle.idcaso=@strlcaso order by fcreg"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            If strlmin <> "" Then
                cms.CommandText = "SELECT fallared,vcrmdetalle.idcaso, fcreg, idusuario, obs, vcrmdetalle.tipificacion, numalt, min_ac FROM VCRMDetalle INNER JOIN Bandeja_uni ON VCRMDetalle.idcaso = Bandeja_uni.idcaso where min_ac=@strlmin order by fcreg"
                cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 50).Value = Me.strlmin
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultamarcvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> "" Then
                cms.CommandText = "SELECT  call.estado, agente, duracion, contrato, lista, fcregistro, min_ac FROM Call INNER JOIN Bandeja_uni ON Call.contrato = Bandeja_uni.idcaso where contrato=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            If strlmin <> "" Then
                cms.CommandText = "SELECT  call.estado, agente, duracion, contrato, lista, fcregistro, min_ac FROM Call INNER JOIN Bandeja_uni ON Call.contrato = Bandeja_uni.idcaso where min_ac=@strlmin order by contrato desc"
                cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 50).Value = Me.strlmin
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultadevueltos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM VFallared where asignado='-1' and devuelto='1' and cpd='' and estadocpd <> 'Escalado' and estadocpd <> 'Cerrado' order by idcaso "
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultacasodevuelto() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT campana,apn,qos,coddiv,idcaso,personacontacto,numcontacto,tiempofalla,tipofalla,caractfalla,portada,nombredpto, nombremun,ciudad,direccion,barrio,tecnologia,equipo,maslineas,obscliente,fcregistro,idusuario,idusuriocpd,fcasignado,asignado from vfallared  LEFT OUTER JOIN Divipola on vfallared.munfalla = Divipola.coddiv where idcaso=@strlcaso and asignado='-1' and devuelto='1'"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("personacontacto") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("personacontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("numcontacto") Is System.DBNull.Value Then
                    strltelcontacto = " "
                Else
                    strltelcontacto = dtsrecepcion.Tables(0).Rows(0).Item("numcontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla") Is System.DBNull.Value Then
                    strltiempo = " "
                Else
                    strltiempo = dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipofalla") Is System.DBNull.Value Then
                    strltipofalla = " "
                Else
                    strltipofalla = dtsrecepcion.Tables(0).Rows(0).Item("tipofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("caractfalla") Is System.DBNull.Value Then
                    strlcaracter = " "
                Else
                    strlcaracter = dtsrecepcion.Tables(0).Rows(0).Item("caractfalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("portada") Is System.DBNull.Value Then
                    strlportada = " "
                Else
                    strlportada = dtsrecepcion.Tables(0).Rows(0).Item("portada")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("coddiv") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("coddiv")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("ciudad") Is System.DBNull.Value Then
                    strlvereda = " "
                Else
                    strlvereda = dtsrecepcion.Tables(0).Rows(0).Item("ciudad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("direccion") Is System.DBNull.Value Then
                    strldir = " "
                Else
                    strldir = dtsrecepcion.Tables(0).Rows(0).Item("direccion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dtsrecepcion.Tables(0).Rows(0).Item("barrio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tecnologia") Is System.DBNull.Value Then
                    strltecnologia = " "
                Else
                    strltecnologia = dtsrecepcion.Tables(0).Rows(0).Item("tecnologia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("equipo") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("equipo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("maslineas") Is System.DBNull.Value Then
                    strlmaslineas = " "
                Else
                    strlmaslineas = dtsrecepcion.Tables(0).Rows(0).Item("maslineas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("obscliente") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obscliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("campana") Is System.DBNull.Value Then
                    strlcampana = " "
                Else
                    strlcampana = dtsrecepcion.Tables(0).Rows(0).Item("campana")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apn") Is System.DBNull.Value Then
                    strlapn = " "
                Else
                    strlapn = dtsrecepcion.Tables(0).Rows(0).Item("apn")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("qos") Is System.DBNull.Value Then
                    strlqos = " "
                Else
                    strlqos = dtsrecepcion.Tables(0).Rows(0).Item("qos")
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
    Public Sub modificafallasred()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE VFallared SET personacontacto=@strlcliente,numcontacto=@strltelcontacto,tiempofalla=@strltiempo,tipofalla=@strltipofalla,caractfalla=@strlcaracter,portada=@strlportada,munfalla=@strlmun,ciudad=@strlvereda,direccion=@strldir,barrio=@strlbarrio,tecnologia=@strltecnologia,equipo=@strlequipo,maslineas=@strlmaslineas,obscliente=@strlobs, asignado=null, cpd=null, apn=@strlapn, qos=@strlqos WHERE idcaso=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlcliente", SqlDbType.NVarChar, 255).Value = strlcliente
            cms.Parameters.Add("@strltelcontacto", SqlDbType.NVarChar, 20).Value = strltelcontacto
            cms.Parameters.Add("@strltiempo", SqlDbType.NVarChar, 20).Value = strltiempo
            cms.Parameters.Add("@strltipofalla", SqlDbType.NVarChar, 255).Value = strltipofalla
            cms.Parameters.Add("@strlcaracter", SqlDbType.VarChar).Value = strlcaracter
            cms.Parameters.Add("@strlportada", SqlDbType.VarChar, 50).Value = strlportada
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 20).Value = strlmun
            cms.Parameters.Add("@strlvereda", SqlDbType.NVarChar, 255).Value = strlvereda
            cms.Parameters.Add("@strldir", SqlDbType.NVarChar, 255).Value = strldir
            cms.Parameters.Add("@strlbarrio", SqlDbType.NVarChar, 255).Value = strlbarrio
            cms.Parameters.Add("@strltecnologia", SqlDbType.NVarChar, 50).Value = strltecnologia
            cms.Parameters.Add("@strlequipo", SqlDbType.NVarChar, 100).Value = strlequipo
            cms.Parameters.Add("@strlmaslineas", SqlDbType.NVarChar, 20).Value = strlmaslineas
            cms.Parameters.Add("@strlapn", SqlDbType.NVarChar, 20).Value = strlapn
            cms.Parameters.Add("@strlqos", SqlDbType.NVarChar, 20).Value = strlqos
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
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
    Public Function consultaescaladosv2() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT Bandeja_uni.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja, munic, nombredpto, nombremun, escalam, tickler, fcreg, idusuario, obs, vcrmdetalle.tipificacion, numalt, VCRMDetalle.idbarrio, localidad, barrio FROM Bandeja_uni INNER JOIN VCRMDetalle ON Bandeja_uni.idcaso = VCRMDetalle.idcaso LEFT OUTER JOIN Barrio ON VCRMDetalle.idbarrio = Barrio.idbarrio LEFT OUTER JOIN Divipola ON Bandeja_uni.munic = Divipola.coddiv where escalam='1' and tickler is null and (VCRMDetalle.tipificacion = '10_Escalado_Service_Desk' OR VCRMDetalle.tipificacion = '17_Portabilidad_Campana_Voz') order by idcaso"
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT Bandeja_uni.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja, munic, nombredpto, nombremun, escalam, tickler, fcreg, idusuario, obs, vcrmdetalle.tipificacion, numalt, VCRMDetalle.idbarrio, localidad, barrio FROM Bandeja_uni INNER JOIN VCRMDetalle ON Bandeja_uni.idcaso = VCRMDetalle.idcaso LEFT OUTER JOIN Barrio ON VCRMDetalle.idbarrio = Barrio.idbarrio LEFT OUTER JOIN Divipola ON Bandeja_uni.munic = Divipola.coddiv where escalam='1' and tickler is null and Bandeja_uni.idcaso=@strlcaso order by idcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcaso <> Nothing Then
                If strlcantidad > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("min_ac") Is System.DBNull.Value Then
                        strlmin = " "
                    Else
                        strlmin = dtsrecepcion.Tables(0).Rows(0).Item("min_ac")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente") Is System.DBNull.Value Then
                        strlcliente = " "
                    Else
                        strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente")
                    End If
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
    Public Sub actualizaescaladosv2()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Bandeja_uni SET tickler=@strltickler,obsescal=@strlobs,idusuarioserv=@strlidusuario,fcregserv=@strlfcreg WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strltickler", SqlDbType.VarChar, 50).Value = strltickler
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.NVarChar, 50).Value = strlfcreg
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
    Public Function consultaresolved() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM VFallared where estadocpd = 'cancelado' OR estadocpd = 'resuelto' order by idcaso"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaresolveduxu() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT campana,apn,qos,estadocpd,fallatec,resolucion,solucion,vfallared.idcaso,personacontacto,B.min_ac As numcontacto,tiempofalla,tipofalla,caractfalla,portada,nombredpto, nombremun,ciudad, direccion,barrio,tecnologia,equipo,maslineas,obscliente,fcregistro,idusuario,idusuriocpd,VFallared.fcasignado,asignado,Falla_Presenta_Luego_Construyera_Edificacion_Aledania, Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,Tipo_Edificacion_Donde_Presenta_Falla,Validaciones_Falla_Masiva,Tecnologia_Presenta_Falla_Luegodepruebas, Validacion_Coordenadas,Linea_No_Cuenta_Bloqueos_Internet,Linea_No_Superado_Limite_Consumos,Linea_No_Encuentra_Enrutada_PorPagos,HLR_HSS, No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,Forza_Red_Dispositivo,Verifica_Realiza_Configuración_APN, Equipo_Encuentra_Homologado_Operador,Realiza_Conciliacion_Sobre_linea, N_Doc_Id from vfallared LEFT OUTER JOIN Divipola on vfallared.munfalla = Divipola.coddiv INNER JOIN Bandeja_uni B on VFallared.idcaso=B.idcaso  where vfallared.idcaso=@strlcaso and cpd is not null"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                _N_Doc_Id = dtsrecepcion.Tables(0).Rows(0).Item("N_Doc_Id").ToString
                If dtsrecepcion.Tables(0).Rows(0).Item("estadocpd") Is System.DBNull.Value Then
                    strlestadoinc = " "
                Else
                    strlestadoinc = dtsrecepcion.Tables(0).Rows(0).Item("estadocpd")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("personacontacto") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("personacontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("numcontacto") Is System.DBNull.Value Then
                    strltelcontacto = " "
                Else
                    strltelcontacto = dtsrecepcion.Tables(0).Rows(0).Item("numcontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla") Is System.DBNull.Value Then
                    strltiempo = " "
                Else
                    strltiempo = dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipofalla") Is System.DBNull.Value Then
                    strltipofalla = " "
                Else
                    strltipofalla = dtsrecepcion.Tables(0).Rows(0).Item("tipofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("caractfalla") Is System.DBNull.Value Then
                    strlcaracter = " "
                Else
                    strlcaracter = dtsrecepcion.Tables(0).Rows(0).Item("caractfalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("portada") Is System.DBNull.Value Then
                    strlportada = " "
                Else
                    strlportada = dtsrecepcion.Tables(0).Rows(0).Item("portada")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombredpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("nombredpto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombremun") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("nombremun")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("ciudad") Is System.DBNull.Value Then
                    strlvereda = " "
                Else
                    strlvereda = dtsrecepcion.Tables(0).Rows(0).Item("ciudad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("direccion") Is System.DBNull.Value Then
                    strldir = " "
                Else
                    strldir = dtsrecepcion.Tables(0).Rows(0).Item("direccion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dtsrecepcion.Tables(0).Rows(0).Item("barrio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tecnologia") Is System.DBNull.Value Then
                    strltecnologia = " "
                Else
                    strltecnologia = dtsrecepcion.Tables(0).Rows(0).Item("tecnologia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("equipo") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("equipo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("maslineas") Is System.DBNull.Value Then
                    strlmaslineas = " "
                Else
                    strlmaslineas = dtsrecepcion.Tables(0).Rows(0).Item("maslineas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("obscliente") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obscliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("resolucion") Is System.DBNull.Value Then
                    strlresolucion = " "
                Else
                    strlresolucion = dtsrecepcion.Tables(0).Rows(0).Item("resolucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("solucion") Is System.DBNull.Value Then
                    strlsolucion = " "
                Else
                    strlsolucion = dtsrecepcion.Tables(0).Rows(0).Item("solucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fallatec") Is System.DBNull.Value Then
                    strlfallatec = " "
                Else
                    strlfallatec = dtsrecepcion.Tables(0).Rows(0).Item("fallatec")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("campana") Is System.DBNull.Value Then
                    strlcampana = " "
                Else
                    strlcampana = dtsrecepcion.Tables(0).Rows(0).Item("campana")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apn") Is System.DBNull.Value Then
                    strlapn = " "
                Else
                    strlapn = dtsrecepcion.Tables(0).Rows(0).Item("apn")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("qos") Is System.DBNull.Value Then
                    strlqos = " "
                Else
                    strlqos = dtsrecepcion.Tables(0).Rows(0).Item("qos")
                End If

                ''''Validaciones servicio al cliente
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = " "
                Else
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = " "
                Else
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla") Is System.DBNull.Value Then
                    _Tipo_Edificacion_Donde_Presenta_Falla = " "
                Else
                    _Tipo_Edificacion_Donde_Presenta_Falla = dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva") Is System.DBNull.Value Then
                    _Validaciones_Falla_Masiva = " "
                Else
                    _Validaciones_Falla_Masiva = dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas") Is System.DBNull.Value Then
                    _Tecnologia_Presenta_Falla_Luegodepruebas = " "
                Else
                    _Tecnologia_Presenta_Falla_Luegodepruebas = dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas") Is System.DBNull.Value Then
                    _Validacion_Coordenadas = " "
                Else
                    _Validacion_Coordenadas = dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet") Is System.DBNull.Value Then
                    _Linea_No_Cuenta_Bloqueos_Internet = " "
                Else
                    _Linea_No_Cuenta_Bloqueos_Internet = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos") Is System.DBNull.Value Then
                    _Linea_No_Superado_Limite_Consumos = " "
                Else
                    _Linea_No_Superado_Limite_Consumos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos") Is System.DBNull.Value Then
                    _Linea_No_Encuentra_Enrutada_PorPagos = " "
                Else
                    _Linea_No_Encuentra_Enrutada_PorPagos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS") Is System.DBNull.Value Then
                    _HLR_HSS = " "
                Else
                    _HLR_HSS = dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra") Is System.DBNull.Value Then
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = " "
                Else
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla") Is System.DBNull.Value Then
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = " "
                Else
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo") Is System.DBNull.Value Then
                    _Forza_Red_Dispositivo = " "
                Else
                    _Forza_Red_Dispositivo = dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN") Is System.DBNull.Value Then
                    _Verifica_Realiza_Configuración_APN = " "
                Else
                    _Verifica_Realiza_Configuración_APN = dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador") Is System.DBNull.Value Then
                    _Equipo_Encuentra_Homologado_Operador = " "
                Else
                    _Equipo_Encuentra_Homologado_Operador = dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea") Is System.DBNull.Value Then
                    _Realiza_Conciliacion_Sobre_linea = " "
                Else
                    _Realiza_Conciliacion_Sobre_linea = dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea")
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
    Public Sub actualizaestadocpd()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE VFallared SET estadocpd=@strlestadoinc,Respuesta=@_Respuesta,Falla_solucionada=@_Falla_solucionada, Estado_Cliente=@_Estado_Cliente,Cliente_Misma_Ubicacion_Falla=@_Cliente_Misma_Ubicacion_Falla,CPD_Mismo_Min_Zona=@_CPD_Mismo_Min_Zona,CPD_Mismo_Min_Zona_Can=@_CPD_Mismo_Min_Zona_Can,Estado_Remedy=@_Estado_linea  WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlestadoinc", SqlDbType.VarChar, 50).Value = strlestadoinc
            cms.Parameters.Add("@_Respuesta", SqlDbType.VarChar, 50).Value = _Respuesta
            cms.Parameters.Add("@_Falla_solucionada", SqlDbType.VarChar, 50).Value = _Falla_solucionada
            cms.Parameters.Add("@_Estado_Cliente", SqlDbType.VarChar, 50).Value = _Estado_Cliente
            cms.Parameters.Add("@_Cliente_Misma_Ubicacion_Falla", SqlDbType.VarChar, 50).Value = _Cliente_Misma_Ubicacion_Falla
            cms.Parameters.Add("@_CPD_Mismo_Min_Zona", SqlDbType.VarChar, 50).Value = _CPD_Mismo_Min_Zona
            cms.Parameters.Add("@_CPD_Mismo_Min_Zona_Can", SqlDbType.VarChar, 50).Value = _CPD_Mismo_Min_Zona_Can
            cms.Parameters.Add("@_Estado_linea", SqlDbType.VarChar, 50).Value = _Estado_linea
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


    Public Sub registrocrmfallared()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO Vcrmdetalle(idcaso,fcreg,idusuario,obs,tipificacion,fallared) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,'Si')"
            If _Validacion = "Gestion_De_Resolved_SD" Then
                cms.CommandText = "INSERT INTO Vcrmdetalle(idcaso,fcreg,idusuario,obs,tipificacion,fallared) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,'SD')"
            End If

            If _Validacion = "Diagnostico" Then
                cms.CommandText = "insert into Detalle_diagnostico ([idcaso],[servicio],[caractfalla],[perecep],[tecnologia],[condic],[variable],[tcierre],[nunicipio],[barrio],[solucion],[ajuste],[vlrajuste],[fcreg],[Equipo],[fcultimac],[franjaultimac],[Desactivacion],[idsolicitud],[Tipo_PQR],[Tipo_Cliente],[Modalidad],[Causa_Raiz],[Categoria_Cierre] ) SELECT top 1 [idcaso],[servicio],[caractfalla],[perecep],[tecnologia],[condic],[variable],[tcierre],[nunicipio],[barrio],[solucion],[ajuste],[vlrajuste],@strlfcreg,[Equipo],[fcultimac],[franjaultimac],[Desactivacion],[idsolicitud],[Tipo_PQR],[Tipo_Cliente],[Modalidad],[Causa_Raiz],'302' FROM Detalle_diagnostico  WHERE idcaso = @strlcaso order by fcreg desc"
                cms.Parameters.Add("@Categoria_cierre", SqlDbType.VarChar).Value = _Categoria_Cierre
            Else
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
                cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg

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

    Public Sub modificarbandejafalla()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja_uni SET estado='Cerrado Tecnica' WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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

    Public Function consultagralfallas() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> "" Then
                cms.CommandText = "SELECT campana,cas_fecha_registro,devuelto,bandeja,vfallared.idcaso, personacontacto, numcontacto, tipofalla, caractfalla, fcregistro, idusuario, cpd, estadocpd, obscpd, idusuriocpd, VFallared.fcasignado, fcregcpd, asignado FROM VFallared LEFT OUTER JOIN Bandeja_uni ON VFallared.idcaso = Bandeja_uni.idcaso where vfallared.idcaso=@strlcaso order by idcaso desc"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            If strlmin <> "" Then
                cms.CommandText = "SELECT campana,cas_fecha_registro,devuelto,bandeja,vfallared.idcaso, personacontacto, numcontacto, tipofalla, caractfalla, fcregistro, idusuario, cpd, estadocpd, obscpd, idusuriocpd, VFallared.fcasignado, fcregcpd, asignado FROM VFallared LEFT OUTER JOIN Bandeja_uni ON VFallared.idcaso = Bandeja_uni.idcaso where numcontacto=@strlmin order by idcaso desc"
                cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 50).Value = Me.strlmin
            End If
            If strlcliente <> "" Then
                cms.CommandText = "SELECT campana,cas_fecha_registro,devuelto,bandeja,vfallared.idcaso, personacontacto, numcontacto, tipofalla, caractfalla, fcregistro, idusuario, cpd, estadocpd, obscpd, idusuriocpd, VFallared.fcasignado, fcregcpd, asignado FROM VFallared LEFT OUTER JOIN Bandeja_uni ON VFallared.idcaso = Bandeja_uni.idcaso where personacontacto like '%'+@strlcliente+'%' order by idcaso desc"
                cms.Parameters.Add("@strlcliente", SqlDbType.VarChar, 100).Value = Me.strlcliente
            End If
            If strlmesa <> "" Then
                cms.CommandText = "SELECT campana,cas_fecha_registro,devuelto,bandeja,vfallared.idcaso, personacontacto, numcontacto, tipofalla, caractfalla, fcregistro, idusuario, cpd, estadocpd, obscpd, idusuriocpd, VFallared.fcasignado, fcregcpd, asignado FROM VFallared LEFT OUTER JOIN Bandeja_uni ON VFallared.idcaso = Bandeja_uni.idcaso where bandeja=@strlmesa order by idcaso desc"
                cms.Parameters.Add("@strlmesa", SqlDbType.VarChar, 100).Value = Me.strlmesa
            End If
            If strlescala <> Nothing Then
                cms.CommandText = "SELECT campana,cas_fecha_registro,devuelto,bandeja,vfallared.idcaso, personacontacto, numcontacto, tipofalla, caractfalla, fcregistro, idusuario, cpd, estadocpd, obscpd, idusuriocpd, VFallared.fcasignado, fcregcpd, asignado FROM VFallared LEFT OUTER JOIN Bandeja_uni ON VFallared.idcaso = Bandeja_uni.idcaso where cpd is null order by idcaso desc"
            End If
            If strlestadoinc <> Nothing Then
                cms.CommandText = "SELECT campana,cas_fecha_registro,devuelto,bandeja,vfallared.idcaso, personacontacto, numcontacto, tipofalla, caractfalla, fcregistro, idusuario, cpd, estadocpd, obscpd, idusuriocpd, VFallared.fcasignado, fcregcpd, asignado FROM VFallared LEFT OUTER JOIN Bandeja_uni ON VFallared.idcaso = Bandeja_uni.idcaso where estadocpd=@strlestadoinc order by idcaso desc"
                cms.Parameters.Add("@strlestadoinc", SqlDbType.VarChar, 100).Value = Me.strlestadoinc
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub modificarfallatecfr()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja_uni SET estadofallatec=@strlestadoinc WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlestadoinc", SqlDbType.NVarChar, 50).Value = strlestadoinc
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
   
    Public Sub actualizaestadocpdbandeja()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Bandeja_uni SET estado='No Disponible' WHERE idcaso= @strlcaso and estado <> 'CERRADO' and estado <> 'RECHAZADO'"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Function estadisticagralvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT estado, COUNT(idcaso) AS Casos FROM Bandeja_uni WHERE (cas_fecha_registro > @strlfcini) AND (cas_fecha_registro < @strlfcfin) GROUP BY estado ORDER BY estado"
            cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = Me.strlfcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = Me.strlfcfin
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function estadisticaptesvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT COUNT(idcaso) AS Casos FROM Bandeja_uni WHERE (cas_fecha_registro > @strlfcini) AND (cas_fecha_registro < @strlfcfin) AND (estado <> N'cerrado') AND (estado <> N'escalado') AND (estado <> N'ilocalizable') and (estado <> N'rechazado')"
            cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = Me.strlfcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = Me.strlfcfin
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("casos") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("casos")
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
    Public Function estadisticailocvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT COUNT(idcaso) AS Casos FROM Bandeja_uni WHERE (cas_fecha_registro > @strlfcini) AND (cas_fecha_registro < @strlfcfin) AND (estado <> N'cerrado') AND (estado <> N'escalado') AND (estado <> N'rechazado')"
            cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = Me.strlfcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = Me.strlfcfin
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("casos") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("casos")
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
    Public Function estadisticagestionvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT COUNT(idcaso) AS Casos FROM Bandeja_uni WHERE (cas_fecha_registro > @strlfcini) AND (cas_fecha_registro < @strlfcfin) AND (estado <> N'abierto')"
            cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = Me.strlfcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = Me.strlfcfin
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("casos") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("casos")
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
    Public Function consultapteasignartotal() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM VFallared where asignado is null and fcregistro>='01/08/2016' order by idreg"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaenprocdigita() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT iddigitador, COUNT(idcaso) AS casos FROM Bandeja_uni WHERE estado='Solicitud ilocalizar' AND fcdigitado IS NULL AND fcasignado is not null GROUP BY iddigitador"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultapteasignartotaldigitac() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM bandeja_uni where estado='Solicitud ilocalizar' and fcasignado is null"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function consultapteasignardigita() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "idcaso ,cas_fecha_registro,min_ac,estado,digitado,fcsap FROM Bandeja_uni where estado=''Solicitud ilocalizar’ and fcasignado is null"
            cms.Parameters.Add("@strlcantidad", SqlDbType.Int).Value = Me.strlcantidad
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub asignaescalaxcasodig()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja_uni SET iddigitador=@strlidusuario, fcasignado=@strlfcreg, idusuarioasigna=@strlidcrm WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidcrm", SqlDbType.VarChar, 50).Value = strlidcrm
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
    Public Function consultaasigxusudigi() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT bandeja_uni.idcaso,cas_fecha_registro,min_ac,nom_cliente,bandeja_uni.fcasignado,idusuarioasigna, estadocpd,solucion,resolucion,fcsap FROM bandeja_uni left join VFallared on Bandeja_uni.idcaso=VFallared.idcaso where bandeja_uni.fcasignado is not null and digitado is null and iddigitador=@strlidusuario order by bandeja_uni.idcaso "
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub actualizadigit()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja_uni SET digitado='1',tipocierre=@strldir, fcdigitado=@strlfcreg,estadofallatec='Ilocalizable' WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strldir", SqlDbType.Int).Value = strldir
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
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
    Public Function consultaasignado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT idcaso ,numcontacto,fcasignado FROM VFallared where idusuriocpd=@strlidusuario and cpd is null"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub liberaasigecalam()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE VFallared SET idusuriocpd=null, fcasignado=null, asignado=null WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Function consultaTM() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM CRM_TM where caso = @strlcaso order by id desc"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub nuevoformato()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO CreaFormato(idcaso,mesa,fcreg,idusuario) values(@strlcaso,@strlmesa,@strlfcreg,@strlidusuario)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlmesa", SqlDbType.NVarChar, 50).Value = strlmesa
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
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
    Public Function consultanuevoformato() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT creaformato.idcaso,mesa,fcreg,idusuario,casonuevo,obscrea,fcregcrea,idusuariocrea, min_ac FROM CreaFormato inner join Bandeja_uni on Bandeja_uni.idcaso=CreaFormato.idcaso where casonuevo is null order by idcaso"
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT creaformato.idcaso,mesa,fcreg,idusuario,casonuevo,obscrea,fcregcrea,idusuariocrea, min_ac FROM CreaFormato inner join Bandeja_uni on Bandeja_uni.idcaso=CreaFormato.idcaso where creaformato.idcaso=@strlcaso and casonuevo is null order by idcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcaso <> Nothing Then
                If strlcantidad > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("idcaso") Is System.DBNull.Value Then
                        strlcaso = " "
                    Else
                        strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("idcaso")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("mesa") Is System.DBNull.Value Then
                        strlmesa = " "
                    Else
                        strlmesa = dtsrecepcion.Tables(0).Rows(0).Item("mesa")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("idusuario") Is System.DBNull.Value Then
                        strlidusuario = " "
                    Else
                        strlidusuario = dtsrecepcion.Tables(0).Rows(0).Item("idusuario")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("fcreg") Is System.DBNull.Value Then
                        strlfcreg = " "
                    Else
                        strlfcreg = dtsrecepcion.Tables(0).Rows(0).Item("fcreg")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("min_ac") Is System.DBNull.Value Then
                        strlmin = " "
                    Else
                        strlmin = dtsrecepcion.Tables(0).Rows(0).Item("min_ac")
                    End If
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
    Public Sub actualizanuevocaso()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE CreaFormato SET casonuevo=@strltickler,obscrea=@strlobs,fcregcrea=@strlfcreg,idusuariocrea=@strlidusuario WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strltickler", SqlDbType.VarChar, 50).Value = strltickler
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.NVarChar, 50).Value = strlfcreg
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
    Public Function consultaasignadodigitac() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT min_ac,idcaso,digitado,iddigitador,fcasignado,idusuarioasigna FROM Bandeja_uni where iddigitador=@strlidusuario and digitado is null"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub liberaasigdigitac()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja_uni SET iddigitador=null, fcasignado=null, idusuarioasigna=null WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Sub registrocrmfallareddatos()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO crmdetalle(idcaso,fcreg,idusuario,obs,tipificacion,fallared) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,'Si')"
            If _Validacion = "Gestion_De_Resolved_SD" Then
                cms.CommandText = "INSERT INTO crmdetalle(idcaso,fcreg,idusuario,obs,tipificacion,fallared) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,'SD')"
            End If

            '------Nuevo------'
            If _Validacion = "Diagnostico" Then
                cms.CommandText = "Insert into Detalle_diagnostico ([idcaso],[servicio],[caractfalla],[perecep],[tecnologia],[condic],[variable],[tcierre],[nunicipio],[barrio],[solucion],[ajuste],[vlrajuste],[fcreg],[Equipo],[fcultimac],[franjaultimac],[reclamppal],[tipofalla],[fcpqr],[Desactivacion],[idsolicitud],[CicloFactura],[Tipo_PQR],[Tipo_Cliente],[Modalidad],[Causa_Raiz],[Categoria_Cierre],[Version_S_O_Equipo],[Version_Facebook],[Tipificacion_Interna],[WTF]) SELECT top 1 [idcaso],[servicio],[caractfalla],[perecep],[tecnologia],[condic],[variable],[tcierre],[nunicipio],[barrio],[solucion],[ajuste],[vlrajuste],@strlfcreg,[Equipo],[fcultimac],[franjaultimac],[reclamppal],[tipofalla],[fcpqr],[Desactivacion],[idsolicitud],[CicloFactura],[Tipo_PQR],[Tipo_Cliente],[Modalidad],[Causa_Raiz],@Categoria_cierre,[Version_S_O_Equipo],[Version_Facebook],@strltipificacion,[WTF]  FROM Detalle_diagnostico WHERE idcaso = @strlcaso order by fcreg desc"
                cms.Parameters.Add("@Categoria_cierre", SqlDbType.VarChar).Value = _Categoria_Cierre
            Else
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
                cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
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


    Public Sub Registro_Gestion_CRM_de_SERVICES()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If Bandeja = "DATOS" Then
                cms.CommandText = "INSERT INTO crmdetalle(idcaso,fcreg,idusuario,obs,tipificacion) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion)"
            End If
            If Bandeja = "DILO" Then
                cms.CommandText = "INSERT INTO CRMdilo(idcasodilo,fcregistro,idusuario,obs,tipificacion) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion)"
            End If
            If Bandeja = "FALLA DES" Then
                cms.CommandText = "INSERT INTO CRM_Falla_Desactivacion_D_V(Fk_Id_Bandeja,Fc_Reg_Ges,Id_Usuario,obs,tipificacion,Equipo,Segmentacion_Linea,Correo_Electronico) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,'Reportado/Services','Reportado/Services','Reportado/Services')"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
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
    Public Sub actualizaestadocpdbandejadatos()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Bandeja SET estado='No Disponible' WHERE cas_id= @strlcaso and estado <> 'CERRADO'"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Sub modificarbandejafalladatos()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja SET estado='Cerrado Tecnica' WHERE cas_id= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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

    Public Function consultacamapana() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "DILO" Then
                cms.CommandText = "SELECT Canal_Dilo FROM vFALLARED where idcaso=@strlcaso and cpd is not null"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
                cms.Connection = cn
                dtarecepcion = New SqlClient.SqlDataAdapter(cms)
                dtarecepcion.Fill(dtsrecepcion)
                If dtsrecepcion.Tables(0).Rows.Count > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("Canal_Dilo") Is System.DBNull.Value Then
                        strlcantidad = " "
                    Else
                        strlcantidad = dtsrecepcion.Tables(0).Rows(0).Item("Canal_Dilo")
                    End If
                End If

            ElseIf strlcaso <> Nothing Then
                cms.CommandText = "SELECT campana from vfallared where idcaso=@strlcaso and cpd is not null"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
                cms.Connection = cn
                dtarecepcion = New SqlClient.SqlDataAdapter(cms)
                dtarecepcion.Fill(dtsrecepcion)
                strlcantidad = dtsrecepcion.Tables(0).Rows.Count
                If strlcantidad > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("campana") Is System.DBNull.Value Then
                        strlcampana = " "
                    Else
                        strlcampana = dtsrecepcion.Tables(0).Rows(0).Item("campana")
                    End If
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

    Public Function consultaresolveddatos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT VF.cpd,Estado_remedy,campana,apn,qos,estadocpd,resolucion,solucion,VF.idcaso,personacontacto,VF.N_Doc_Id,B.Min as numcontacto,tiempofalla,tipofalla,caractfalla,portada,nombredpto, nombremun,ciudad,direccion,barrio,tecnologia,equipo,maslineas,obscliente,fcregistro,idusuario,idusuriocpd,VF.fcasignado,asignado, Falla_Presenta_Luego_Construyera_Edificacion_Aledania,Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,Tipo_Edificacion_Donde_Presenta_Falla, Validaciones_Falla_Masiva,Tecnologia_Presenta_Falla_Luegodepruebas,Validacion_Coordenadas,Linea_No_Cuenta_Bloqueos_Internet,Linea_No_Superado_Limite_Consumos, Linea_No_Encuentra_Enrutada_PorPagos,HLR_HSS,No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla, Forza_Red_Dispositivo,Verifica_Realiza_Configuración_APN,Equipo_Encuentra_Homologado_Operador,Realiza_Conciliacion_Sobre_linea  from clarovoz.dbo.vfallared  VF LEFT OUTER JOIN datosclaro.dbo.Divipola on VF.munfalla = datosclaro.dbo.Divipola.coddiv  LEFT JOIN ( SELECT idcaso, MIN FROM datosclaro.dbo.Bandeja_alt UNION SELECT cas_id, min_ac As MIN FROM datosclaro.dbo.Bandeja UNION SELECT Id_Caso, MIN FROM datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V ) As B ON B.idcaso = VF.idcaso where VF.idcaso=@strlcaso and cpd is not null"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso

            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                _N_Doc_Id = dtsrecepcion.Tables(0).Rows(0).Item("N_Doc_Id").ToString
                If dtsrecepcion.Tables(0).Rows(0).Item("estadocpd") Is System.DBNull.Value Then
                    strlestadoinc = " "
                Else
                    strlestadoinc = dtsrecepcion.Tables(0).Rows(0).Item("estadocpd")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Estado_remedy") Is System.DBNull.Value Then
                    _Estado_linea = " "
                Else
                    _Estado_linea = dtsrecepcion.Tables(0).Rows(0).Item("Estado_remedy")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("personacontacto") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("personacontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("numcontacto") Is System.DBNull.Value Then
                    strltelcontacto = " "
                Else
                    strltelcontacto = dtsrecepcion.Tables(0).Rows(0).Item("numcontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla") Is System.DBNull.Value Then
                    strltiempo = " "
                Else
                    strltiempo = dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipofalla") Is System.DBNull.Value Then
                    strltipofalla = " "
                Else
                    strltipofalla = dtsrecepcion.Tables(0).Rows(0).Item("tipofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("caractfalla") Is System.DBNull.Value Then
                    strlcaracter = " "
                Else
                    strlcaracter = dtsrecepcion.Tables(0).Rows(0).Item("caractfalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("portada") Is System.DBNull.Value Then
                    strlportada = " "
                Else
                    strlportada = dtsrecepcion.Tables(0).Rows(0).Item("portada")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombredpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("nombredpto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombremun") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("nombremun")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("ciudad") Is System.DBNull.Value Then
                    strlvereda = " "
                Else
                    strlvereda = dtsrecepcion.Tables(0).Rows(0).Item("ciudad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("direccion") Is System.DBNull.Value Then
                    strldir = " "
                Else
                    strldir = dtsrecepcion.Tables(0).Rows(0).Item("direccion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dtsrecepcion.Tables(0).Rows(0).Item("barrio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tecnologia") Is System.DBNull.Value Then
                    strltecnologia = " "
                Else
                    strltecnologia = dtsrecepcion.Tables(0).Rows(0).Item("tecnologia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("equipo") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("equipo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("maslineas") Is System.DBNull.Value Then
                    strlmaslineas = " "
                Else
                    strlmaslineas = dtsrecepcion.Tables(0).Rows(0).Item("maslineas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("obscliente") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obscliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("resolucion") Is System.DBNull.Value Then
                    strlresolucion = " "
                Else
                    strlresolucion = dtsrecepcion.Tables(0).Rows(0).Item("resolucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("solucion") Is System.DBNull.Value Then
                    strlsolucion = " "
                Else
                    strlsolucion = dtsrecepcion.Tables(0).Rows(0).Item("solucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("campana") Is System.DBNull.Value Then
                    strlcampana = " "
                Else
                    strlcampana = dtsrecepcion.Tables(0).Rows(0).Item("campana")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apn") Is System.DBNull.Value Then
                    strlapn = " "
                Else
                    strlapn = dtsrecepcion.Tables(0).Rows(0).Item("apn")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("qos") Is System.DBNull.Value Then
                    strlqos = " "
                Else
                    strlqos = dtsrecepcion.Tables(0).Rows(0).Item("qos")
                End If

                ''''Validaciones servicio al cliente
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = " "
                Else
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = " "
                Else
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla") Is System.DBNull.Value Then
                    _Tipo_Edificacion_Donde_Presenta_Falla = " "
                Else
                    _Tipo_Edificacion_Donde_Presenta_Falla = dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva") Is System.DBNull.Value Then
                    _Validaciones_Falla_Masiva = " "
                Else
                    _Validaciones_Falla_Masiva = dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas") Is System.DBNull.Value Then
                    _Tecnologia_Presenta_Falla_Luegodepruebas = " "
                Else
                    _Tecnologia_Presenta_Falla_Luegodepruebas = dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas") Is System.DBNull.Value Then
                    _Validacion_Coordenadas = " "
                Else
                    _Validacion_Coordenadas = dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet") Is System.DBNull.Value Then
                    _Linea_No_Cuenta_Bloqueos_Internet = " "
                Else
                    _Linea_No_Cuenta_Bloqueos_Internet = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos") Is System.DBNull.Value Then
                    _Linea_No_Superado_Limite_Consumos = " "
                Else
                    _Linea_No_Superado_Limite_Consumos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos") Is System.DBNull.Value Then
                    _Linea_No_Encuentra_Enrutada_PorPagos = " "
                Else
                    _Linea_No_Encuentra_Enrutada_PorPagos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS") Is System.DBNull.Value Then
                    _HLR_HSS = " "
                Else
                    _HLR_HSS = dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra") Is System.DBNull.Value Then
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = " "
                Else
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla") Is System.DBNull.Value Then
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = " "
                Else
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo") Is System.DBNull.Value Then
                    _Forza_Red_Dispositivo = " "
                Else
                    _Forza_Red_Dispositivo = dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN") Is System.DBNull.Value Then
                    _Verifica_Realiza_Configuración_APN = " "
                Else
                    _Verifica_Realiza_Configuración_APN = dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador") Is System.DBNull.Value Then
                    _Equipo_Encuentra_Homologado_Operador = " "
                Else
                    _Equipo_Encuentra_Homologado_Operador = dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea") Is System.DBNull.Value Then
                    _Realiza_Conciliacion_Sobre_linea = " "
                Else
                    _Realiza_Conciliacion_Sobre_linea = dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cpd") Is System.DBNull.Value Then
                    strlcpd = " "
                Else
                    strlcpd = dtsrecepcion.Tables(0).Rows(0).Item("cpd")
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
    Public Sub registrodiag()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO detalle_diagnostico(idsolicitud,fcultimac,franjaultimac,fcreg,solucion,ajuste,vlrajuste,idcaso,servicio,perecep,tecnologia,variable,nunicipio,barrio,Desactivacion,Equipo,Tipo_PQR,Tipo_Cliente,Modalidad,Causa_Raiz, Categoria_Cierre) values(@strlsolicitud,@strlfcultimac,@strlfranjaultimac,@strlfcreg,@strlsolucion,@strlajuste,@strlvlrajuste,@strlcaso,@strldiagservicio,@strldiagperep,@strldiagtecnolog,@strldiagvariable,@strlmun,@strlbarrio,@strlDesactivacion,@strlequipo,@_Tipo_PQR,@_Tipo_Cliente,@_Modalidad,@_Causa_Raiz,@_Categoria_Cierre)"
            cms.Parameters.Add("@strlequipo", SqlDbType.VarChar, 50).Value = strlequipo
            cms.Parameters.Add("@strlsolicitud", SqlDbType.Int).Value = strlsolicitud
            cms.Parameters.Add("@strlcaso", SqlDbType.NVarChar, 20).Value = strlcaso
            cms.Parameters.Add("@strldiagservicio", SqlDbType.Int).Value = strldiagservicio
            cms.Parameters.Add("@strldiagperep", SqlDbType.Int).Value = strldiagperep
            cms.Parameters.Add("@strldiagtecnolog", SqlDbType.Int).Value = strldiagtecnolog
            cms.Parameters.Add("@strldiagvariable", SqlDbType.Int).Value = strldiagvariable
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 10).Value = strlmun
            cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar, 255).Value = strlbarrio
            cms.Parameters.Add("@strlsolucion", SqlDbType.VarChar, 2).Value = strlsolucion
            cms.Parameters.Add("@strlajuste", SqlDbType.VarChar, 2).Value = strlajuste
            cms.Parameters.Add("@strlvlrajuste", SqlDbType.Decimal).Value = strlvlrajuste
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlfranjaultimac", SqlDbType.NVarChar, 10).Value = strlfranjaultimac
            cms.Parameters.Add("@strlfcultimac", SqlDbType.Date).Value = strlfcultimac
            cms.Parameters.Add("@strlDesactivacion", SqlDbType.VarChar, 50).Value = strlDesactivacion
            cms.Parameters.Add("@_Tipo_PQR", SqlDbType.VarChar, 100).Value = _Tipo_PQR
            cms.Parameters.Add("@_Tipo_Cliente", SqlDbType.VarChar, 100).Value = _Tipo_Cliente
            cms.Parameters.Add("@_Modalidad", SqlDbType.VarChar, 100).Value = _Modalidad
            cms.Parameters.Add("@_Causa_Raiz", SqlDbType.Int).Value = _Causa_Raiz
            cms.Parameters.Add("@_Categoria_Cierre", SqlDbType.Int).Value = _Categoria_Cierre

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
    Public Sub registroincvoz()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO detalleinc(nivel,idcaso,obsinc,idtipoinc,estado,fcreg,idusuariorep,Registro_Numerico) values(@strlbarrio,@strlcaso,@strlobs,@strlincidente,'Reportado',@strlfcreg,@strlidusuario,@registro_numerico)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlincidente", SqlDbType.Int).Value = strlincidente
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar, 50).Value = strlbarrio
            If strlNum_Intento <> Nothing Then
                cms.Parameters.Add("@registro_numerico", SqlDbType.BigInt).Value = strlNum_Intento
            Else
                cms.Parameters.AddWithValue("@registro_numerico", DBNull.Value)
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
    Public Function consultainconsvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT nivel,DI.idcaso, min_ac, cas_fecha_registro,obsinc,DI.idtipoinc,inconsistencia,BU.estado,idusuariorep,Registro_Numerico  FROM clarovoz.dbo.Detalleinc DI INNER JOIN clarovoz.dbo.Bandeja_uni BU ON DI.idcaso = BU.idcaso INNER JOIN datosclaro.dbo.Inconsistencia I ON I.idtipoinc = DI.idtipoinc where DI.estado='Reportado'"
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT nivel,DI.idcaso, min_ac, cas_fecha_registro, obsinc, DI.idtipoinc, inconsistencia, BU.estado, idusuariorep FROM clarovoz.dbo.Detalleinc DI INNER JOIN clarovoz.dbo.Bandeja_uni BU ON DI.idcaso = BU.idcaso INNER JOIN datosclaro.dbo.Inconsistencia I ON DI.idtipoinc = I.idtipoinc where DI.estado='Reportado' and DI.idcaso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaaprobadovoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT custcode_ac,usuario_asignado,nivel,detalleinc.idcaso, min_ac, cas_fecha_registro, obsinc, Detalleinc.idtipoinc, inconsistencia, Bandeja_uni.estado, idusuariorep FROM Detalleinc INNER JOIN Bandeja_uni ON Detalleinc.idcaso = Bandeja_uni.idcaso INNER JOIN Inconsistencia ON Detalleinc.idtipoinc = Inconsistencia.idtipoinc where detalleinc.estado='Aprobado'"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub actualizaincvoz()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Detalleinc SET estado=@strltipificacion,fcrev=@strlfcreg, idusuariorev=@strlidusuario WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 10).Value = strltipificacion
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
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
    Public Sub envioincvoz()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Detalleinc SET estado='Enviado',fcenvio=@strlfcreg, idusuarioenv=@strlidusuario WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
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
    Public Function consultaincvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT nivel,Detalleinc.idcaso, min_ac, cas_fecha_registro, obsinc, Detalleinc.idtipoinc, inconsistencia, Bandeja_uni.estado, idusuariorep, Detalleinc.estado as estadoinc, fcreg, fcrev, idusuariorev, fcenvio, idusuarioenv FROM clarovoz.dbo.Detalleinc INNER JOIN clarovoz.dbo.Bandeja_uni ON Detalleinc.idcaso = Bandeja_uni.idcaso INNER JOIN datosclaro.dbo.Inconsistencia  I ON Detalleinc.idtipoinc = i.idtipoinc"
            If strltipificacion <> "" Then
                cms.CommandText = "SELECT nivel,Detalleinc.idcaso, min_ac, cas_fecha_registro, obsinc, Detalleinc.idtipoinc, inconsistencia, Bandeja_uni.estado, idusuariorep, Detalleinc.estado as estadoinc, fcreg, fcrev, idusuariorev, fcenvio, idusuarioenv FROM clarovoz.dbo.Detalleinc INNER JOIN clarovoz.dbo.Bandeja_uni ON Detalleinc.idcaso = Bandeja_uni.idcaso INNER JOIN datosclaro.dbo.Inconsistencia  I ON Detalleinc.idtipoinc = i.idtipoinc where Detalleinc.estado=@strltipificacion"
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = Me.strltipificacion
            End If
            If strlcaso <> "" Then
                cms.CommandText = "SELECT nivel,Detalleinc.idcaso, min_ac, cas_fecha_registro, obsinc, Detalleinc.idtipoinc, inconsistencia, Bandeja_uni.estado, idusuariorep, Detalleinc.estado as estadoinc, fcreg, fcrev, idusuariorev, fcenvio, idusuarioenv FROM clarovoz.dbo.Detalleinc INNER JOIN clarovoz.dbo.Bandeja_uni ON Detalleinc.idcaso = Bandeja_uni.idcaso INNER JOIN datosclaro.dbo.Inconsistencia  I ON Detalleinc.idtipoinc = i.idtipoinc where Detalleinc.idcaso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            If strlfcini <> "" Then
                cms.CommandText = "SELECT nivel,Detalleinc.idcaso, min_ac, cas_fecha_registro, obsinc, Detalleinc.idtipoinc, inconsistencia, Bandeja_uni.estado, idusuariorep, Detalleinc.estado as estadoinc, fcreg, fcrev, idusuariorev, fcenvio, idusuarioenv FROM clarovoz.dbo.Detalleinc INNER JOIN clarovoz.dbo.Bandeja_uni ON Detalleinc.idcaso = Bandeja_uni.idcaso INNER JOIN datosclaro.dbo.Inconsistencia  I ON Detalleinc.idtipoinc = i.idtipoinc WHERE cas_fecha_registro >= @strlfcini"
                cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = Me.strlfcini
                If strlfcfin <> "" Then
                    cms.CommandText = "SELECT nivel,Detalleinc.idcaso, min_ac, cas_fecha_registro, obsinc, Detalleinc.idtipoinc, inconsistencia, Bandeja_uni.estado, idusuariorep, Detalleinc.estado as estadoinc, fcreg, fcrev, idusuariorev, fcenvio, idusuarioenv FROM clarovoz.dbo.Detalleinc INNER JOIN clarovoz.dbo.Bandeja_uni ON Detalleinc.idcaso = Bandeja_uni.idcaso INNER JOIN datosclaro.dbo.Inconsistencia  I ON Detalleinc.idtipoinc = i.idtipoinc WHERE cas_fecha_registro >= @strlfcini and cas_fecha_registro <= @strlfcfin"
                    cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = Me.strlfcfin
                End If
            End If
            If strlbarrio <> "" Then
                cms.CommandText = "SELECT nivel,Detalleinc.idcaso, min_ac, cas_fecha_registro, obsinc, Detalleinc.idtipoinc, inconsistencia, Bandeja_uni.estado, idusuariorep, Detalleinc.estado as estadoinc, fcreg, fcrev, idusuariorev, fcenvio, idusuarioenv FROM clarovoz.dbo.Detalleinc INNER JOIN clarovoz.dbo.Bandeja_uni ON Detalleinc.idcaso = Bandeja_uni.idcaso INNER JOIN datosclaro.dbo.Inconsistencia  I ON Detalleinc.idtipoinc = i.idtipoinc where nivel=@strlbarrio"
                cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar, 50).Value = Me.strlbarrio
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub modificarfallatecfrdatos()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja SET estadofallatec=@strlestadoinc WHERE cas_id= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlestadoinc", SqlDbType.NVarChar, 50).Value = strlestadoinc
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
    Public Function casosmesvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Month(Now) - 1
            strlfcini = Year(Now)
            If strlfcreg = 0 Then
                strlfcreg = 12
                strlfcini = strlfcini - 1
            End If
            cms.CommandText = "SELECT MONTH(cas_fecha_registro) AS mes, YEAR(cas_fecha_registro) AS año, COUNT(idcaso) AS casos FROM Bandeja_uni GROUP BY MONTH(cas_fecha_registro), YEAR(cas_fecha_registro) HAVING (MONTH(cas_fecha_registro) = @strlfcreg) AND (YEAR(cas_fecha_registro) = @strlfcini)"
            cms.Parameters.Add("@strlfcreg", SqlDbType.Int).Value = Me.strlfcreg
            cms.Parameters.Add("@strlfcini", SqlDbType.Int).Value = Me.strlfcini
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("casos") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("casos")
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
    Public Function casosmescierrevoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Month(Now) - 1
            strlfcini = Year(Now)
            If strlfcreg = 0 Then
                strlfcreg = 12
                strlfcini = strlfcini - 1
            End If
            cms.CommandText = "SELECT MONTH(cas_fecha_registro) AS mes, YEAR(cas_fecha_registro) AS año, COUNT(idcaso) AS casos FROM Bandeja_uni GROUP BY MONTH(cas_fecha_registro), YEAR(cas_fecha_registro), estado  HAVING (MONTH(cas_fecha_registro) = @strlfcreg) AND (YEAR(cas_fecha_registro) = @strlfcini) AND (estado = N'cerrado')"
            cms.Parameters.Add("@strlfcreg", SqlDbType.Int).Value = Me.strlfcreg
            cms.Parameters.Add("@strlfcini", SqlDbType.Int).Value = Me.strlfcini
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("casos") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("casos")
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
    Public Function casosmescierreactvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Month(Now)
            strlfcini = Year(Now)
            cms.CommandText = "SELECT MONTH(cas_fecha_registro) AS mes, YEAR(cas_fecha_registro) AS año, COUNT(idcaso) AS casos FROM Bandeja_uni GROUP BY MONTH(cas_fecha_registro), YEAR(cas_fecha_registro), estado  HAVING (MONTH(cas_fecha_registro) = @strlfcreg) AND (YEAR(cas_fecha_registro) = @strlfcini) AND (estado = N'cerrado')"
            cms.Parameters.Add("@strlfcreg", SqlDbType.Int).Value = Me.strlfcreg
            cms.Parameters.Add("@strlfcini", SqlDbType.Int).Value = Me.strlfcini
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("casos") Is System.DBNull.Value Then
                    strlcaso = "0"
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("casos")
                End If
            Else
                strlcaso = "0"
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
    Public Function personaldispvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Month(Now)
            strlfcini = Year(Now)
            'If strlfcreg = 0 Then
            '    strlfcreg = 12
            '    strlfcini = strlfcini - 1
            'End If
            cms.CommandText = "SELECT idusuario, MONTH(fcreg) AS mes, YEAR(fcreg) AS año, COUNT(idcaso) AS casos FROM VCRMDetalle GROUP BY MONTH(fcreg), YEAR(fcreg) , idusuario, fallared HAVING (MONTH(fcreg) = @strlfcreg) AND (YEAR(fcreg) = @strlfcini) and COUNT(idcaso)>100 and fallared is null"
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 20).Value = Me.strlfcreg
            cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 20).Value = Me.strlfcini
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaprocesovoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT tipificacion FROM diagnostico where idreg=@strldiagservicio "
            cms.Parameters.Add("@strldiagservicio", SqlDbType.Int).Value = Me.strldiagservicio
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("tipificacion") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("tipificacion")
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
    Public Function consultadigitarilocvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT idcaso, cas_fecha_registro, min_ac, nom_cliente, Bandeja_uni.fcasignado, Bandeja_uni.idusuarioasigna, fcsap,  fcregistro, Call.estado  FROM Bandeja_uni LEFT OUTER JOIN Call ON Bandeja_uni.idcaso = Call.contrato  WHERE  Bandeja_uni.fcasignado IS NOT NULL AND digitado IS NULL AND iddigitador = @strlidusuario AND idcaso = @strlcaso AND (Call.estado = 'failure' OR Call.estado = 'abandoned' OR Call.estado = 'shortcall') ORDER BY fcregistro DESC"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("fcregistro") Is System.DBNull.Value Then
                    strlfcreg = " "
                Else
                    strlfcreg = dtsrecepcion.Tables(0).Rows(0).Item("fcregistro")
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
    Public Sub asignasolicitud()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE MC_Detallesolicitud SET idasignado=@strlareafalla, fcasig=@strlfcreg WHERE idsolicitud= @strlidcrm"
            cms.Parameters.Add("@strlidcrm", SqlDbType.Decimal).Value = strlidcrm
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlareafalla", SqlDbType.NVarChar, 50).Value = strlareafalla
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
    Public Function ConsultaNxMonitor()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from VCRMDetalle where idcaso=@strlcaso and preg2='SI' order by fcreg desc"
            cms.Parameters.Add("@strlcaso", SqlDbType.BigInt).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("preg2") Is DBNull.Value Then
                    strlpreg2 = ""
                Else
                    strlpreg2 = dts.Tables(0).Rows(0).Item("preg2")
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
    Public Function Consulta_Cuadro_Mando()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select CT.Cod_Cuadro_Mando_Total,CT.Año,CT.Mes,CT.Campaña,CT.Ingreso,CE.Efectividad,CE.Menor_24_H as Menor_24_H_Efe,CE.Entre_24_48_H  as Entre_24_48_H_Efe,CE.Mayor_48_H as Mayor_48_H_Efe,CT.Contactabilidad,CM.TMO_Min,CM.Menor_24_H,CM.Entre_24_48_H,CM.Mayor_48_H from Cuadro_Mando_Total CT inner join Cuadro_Mando_Efectividad CE on CT.Fk_Cod_Cuadro_Mando_Efectividad= CE.Cod_Cuadro_Mando_Efectividad inner join Cuadro_Mando_TMO_Min CM on CT.Fk_Cod_Cuadro_Mando_TMO_Min = CM.Cod_Cuadro_Mando_TMO_Min"
            cms.Parameters.Add("@strlAño", SqlDbType.Int).Value = strlAño
            cms.Parameters.Add("@strlMes", SqlDbType.Int).Value = strlMes
            If strlBandeja <> Nothing Then
                cms.CommandText = "select CT.Cod_Cuadro_Mando_Total,CT.Año,CT.Mes,CT.Campaña,CT.Ingreso,CE.Efectividad,CE.Menor_24_H as Menor_24_H_Efe,CE.Entre_24_48_H  as Entre_24_48_H_Efe,CE.Mayor_48_H as Mayor_48_H_Efe,CT.Contactabilidad,CM.TMO_Min,CM.Menor_24_H,CM.Entre_24_48_H,CM.Mayor_48_H from Cuadro_Mando_Total CT inner join Cuadro_Mando_Efectividad CE on CT.Fk_Cod_Cuadro_Mando_Efectividad= CE.Cod_Cuadro_Mando_Efectividad inner join Cuadro_Mando_TMO_Min CM on CT.Fk_Cod_Cuadro_Mando_TMO_Min = CM.Cod_Cuadro_Mando_TMO_Min where CT.Año=@strlAño and CT.Mes=@strlMes and CT.Campaña=@strlBandeja"
                cms.Parameters.Add("@strlBandeja", SqlDbType.VarChar, 50).Value = strlBandeja
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
    Public Function Consulta_Vip_Seg_Gran()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlfcini <> Nothing Then
                cms.CommandText = "SELECT VCRMDetalle.idcaso, Bandeja_uni.min_ac, VCRMDetalle.fcreg, VCRMDetalle.obs, VCRMDetalle.tipificacion, VCRMDetalle.idusuario FROM VCRMDetalle INNER JOIN Bandeja_uni ON VCRMDetalle.idcaso = Bandeja_uni.idcaso WHERE (VCRMDetalle.fcreg>=@strlfcini AND (VCRMDetalle.obs Like '%VIP%' Or VCRMDetalle.obs Like '%SEGMEN%')) and Bandeja_uni.bandeja='Voz' ORDER BY VCRMDetalle.fcreg"
                cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 20).Value = strlfcini
            End If
            If strlfcfin <> Nothing Then
                cms.CommandText = "SELECT VCRMDetalle.idcaso, Bandeja_uni.min_ac, VCRMDetalle.fcreg, VCRMDetalle.obs, VCRMDetalle.tipificacion, VCRMDetalle.idusuario FROM VCRMDetalle INNER JOIN Bandeja_uni ON VCRMDetalle.idcaso = Bandeja_uni.idcaso WHERE (VCRMDetalle.fcreg<=@strlfcfin AND (VCRMDetalle.obs Like '%VIP%' Or VCRMDetalle.obs Like '%SEGMEN%')) and Bandeja_uni.bandeja='Voz' ORDER BY VCRMDetalle.fcreg"
                cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 20).Value = strlfcfin
            End If
            If strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "SELECT VCRMDetalle.idcaso, Bandeja_uni.min_ac, VCRMDetalle.fcreg, VCRMDetalle.obs, VCRMDetalle.tipificacion, VCRMDetalle.idusuario FROM VCRMDetalle INNER JOIN Bandeja_uni ON VCRMDetalle.idcaso = Bandeja_uni.idcaso WHERE ((VCRMDetalle.fcreg>=@strlfcini And VCRMDetalle.fcreg<=@strlfcfin) AND (VCRMDetalle.obs Like '%VIP%' Or VCRMDetalle.obs Like '%SEGMEN%')) and Bandeja_uni.bandeja='Voz' ORDER BY VCRMDetalle.fcreg"
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
    Public Function consultaenprocdigitasegvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idusuariodigita, COUNT(idcall) AS casos FROM Call WHERE fcdigitado IS NULL AND fcasignado is not null GROUP BY idusuariodigita"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultapteasignartotaldigitacsegvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT contrato FROM Call where (estado='Failure' or estado='Shortcall' or estado='Abandoned' or estado='Abandoned') and fcasignado is null"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub asignaescalaxcasodigdtseguimvoz()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Call SET idusuariodigita=@strlidusuario, fcasignado=@strlfcreg, idusuarioasigna=@strlidcrm WHERE idcall= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidcrm", SqlDbType.VarChar, 50).Value = strlidcrm
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
    Public Function consultapteasignardigitadtseguimvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "idcall,contrato,fcregistro,Call.estado,Call.fcdigitado, Bandeja_uni.estado FROM Call INNER JOIN Bandeja_uni ON dbo.Call.contrato = dbo.Bandeja_uni.idcaso where (Call.estado='Failure' or Call.estado='Shortcall' or Call.estado='Abandoned') and Call.fcasignado is null AND (Bandeja_uni.estado <> N'cerrado') AND (Bandeja_uni.estado <> N'escalado') and (Bandeja_uni.estado <> N'rechazado') order by fcregistro"
            cms.Parameters.Add("@strlcantidad", SqlDbType.Int).Value = Me.strlcantidad
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub liberaasigdigitacseguimvoz()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE Call SET idusuariodigita=null, fcasignado=null, idusuarioasigna=null WHERE idcall=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Function consultaasignadodigitacdatosseguimvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT estado,fcregistro,idcall,contrato,idusuariodigita,fcasignado,idusuarioasigna,fcdigitado FROM Call where idusuariodigita=@strlidusuario and fcdigitado is null"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub actualizadigitdtseguimvoz()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Call SET fcdigitado=@strlfcreg WHERE idcall= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
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
    Public Function consultadigitarseguimvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT idcall, contrato, fcregistro, fcasignado, idusuarioasigna, estado FROM Call WHERE  fcasignado IS NOT NULL AND fcdigitado IS NULL AND idusuariodigita = @strlidusuario AND idcall = @strlcaso AND (estado = 'failure' OR estado = 'abandoned' or estado = 'shortcall') ORDER BY fcregistro DESC"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("fcregistro") Is System.DBNull.Value Then
                    strlfcreg = " "
                Else
                    strlfcreg = dtsrecepcion.Tables(0).Rows(0).Item("fcregistro")
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
    Public Function consultaenprocgestionvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idusuarioasig, COUNT(idcaso) AS casos FROM Bandeja_uni WHERE fcasignadoseg is not null and estado<>'CERRADO' and estado<>'escalado' and estado<>'rechazado' GROUP BY idusuarioasig"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultapteasignartotalgestionvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select COUNT(*) as cantidad from Bandeja_uni where fcasignadoseg is null and idusuarioasigsup is not null and fcasignadoseg is null"
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("cantidad") Is System.DBNull.Value Then
                    strlcantidad = " "
                Else
                    strlcantidad = dtsrecepcion.Tables(0).Rows(0).Item("cantidad")
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
    Public Sub asignaescalaxcasogestionvoz()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja_uni SET idusuarioasig=@strlidusuario, fcasignadoseg=@strlfcreg WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
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
    Public Function consultapteasignargestionvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap FROM Bandeja_uni B where B.fcasignadoseg is null and B.idusuarioasigsup is not null order by B.idcaso"
            '''''' Consulta por id usuario
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap FROM Bandeja_uni B where B.fcasignadoseg is null and B.idusuarioasigsup=@strlidusuario order by B.idcaso"
                cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = strlidusuario
            End If
            '''''' Consulta por numero de intentos
            If strlNum_Intento <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap,N.Intento FROM Bandeja_uni B inner join (select casi_id,COUNT(*) as Intento,MAX(Fc_Reg) as Fc_Reg from Num_Intento group by casi_id) N on B.idcaso = N.casi_id where B.fcasignadoseg is null and B.idusuarioasigsup is not null and N.Intento " & " " & strlNum_Intento & " " & " order by B.idcaso"
                cms.Parameters.Add("@strlNum_Intento", SqlDbType.VarChar, 50).Value = strlNum_Intento
            End If
            '''''' Consulta por Bandeja
            If strlBandeja <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap FROM Bandeja_uni B where B.fcasignadoseg is null and B.idusuarioasigsup is not null and B.Bandeja=@_Bandeja order by B.idcaso"
                cms.Parameters.Add("@_Bandeja", SqlDbType.VarChar, 50).Value = strlBandeja
            End If
            '''''' Consulta por Estado
            If strlestadoinc <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap FROM Bandeja_uni B where B.fcasignadoseg is null and B.idusuarioasigsup is not null and B.estado=@strlestadoinc order by B.idcaso"
                cms.Parameters.Add("@strlestadoinc", SqlDbType.VarChar, 50).Value = strlestadoinc
            End If
            '''''' Consulta por numero de Intentos y Bandeja
            If strlNum_Intento <> Nothing And strlBandeja <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap,N.Intento FROM Bandeja_uni B inner join (select casi_id,COUNT(*) as Intento,MAX(Fc_Reg) as Fc_Reg from Num_Intento group by casi_id) N on B.idcaso = N.casi_id where B.fcasignadoseg is null and B.idusuarioasigsup is not null and N.Intento " & " " & strlNum_Intento & " " & " and B.Bandeja=@_Bandeja order by B.idcaso"
            End If
            '''''' Consulta por numero de Intentos y Estado
            If strlNum_Intento <> Nothing And strlestadoinc <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap,N.Intento FROM Bandeja_uni B inner join (select casi_id,COUNT(*) as Intento,MAX(Fc_Reg) as Fc_Reg from Num_Intento group by casi_id) N on B.idcaso = N.casi_id where B.fcasignadoseg is null and B.idusuarioasigsup is not null and N.Intento " & " " & strlNum_Intento & " " & " and B.estado=@strlestadoinc order by B.idcaso"
            End If
            '''''' Consulta por Bandeja y Estado
            If strlBandeja <> Nothing And strlestadoinc <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap FROM Bandeja_uni B where B.fcasignadoseg is null and B.idusuarioasigsup is not null and B.Bandeja=@_Bandeja and B.estado=@strlestadoinc order by B.idcaso"
            End If
            '''''' Consulta por numero de Intentos, Bandeja y Estado
            If strlNum_Intento <> Nothing And strlBandeja <> Nothing And strlestadoinc <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap,N.Intento FROM Bandeja_uni B inner join (select casi_id,COUNT(*) as Intento,MAX(Fc_Reg) as Fc_Reg from Num_Intento group by casi_id) N on B.idcaso = N.casi_id where B.fcasignadoseg is null and B.idusuarioasigsup is not null and N.Intento " & " " & strlNum_Intento & " " & " and B.Bandeja=@_Bandeja and B.estado=@strlestadoinc order by B.idcaso"
            End If
            '''''' Consulta por numero de Intentos, Usuario y Estado
            If strlNum_Intento <> Nothing And strlidusuario <> Nothing And strlBandeja <> Nothing And strlestadoinc <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap,N.Intento FROM Bandeja_uni B inner join (select casi_id,COUNT(*) as Intento,MAX(Fc_Reg) as Fc_Reg from Num_Intento group by casi_id) N on B.idcaso = N.casi_id where B.fcasignadoseg is null and B.idusuarioasigsup=@strlidusuario and N.Intento " & " " & strlNum_Intento & " " & " and B.estado=@strlestadoinc order by B.idcaso"
            End If
            '''''' Consulta por Usuario, Bandeja y Estado
            If strlidusuario <> Nothing And strlBandeja <> Nothing And strlestadoinc <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap FROM Bandeja_uni B where B.fcasignadoseg is null and B.idusuarioasigsup is not null and B.Bandeja=@_Bandeja and B.estado=@strlestadoinc order by B.idcaso"
            End If
            '''''' Consulta por numero de Intentos, Usuario y Bandeja
            If strlNum_Intento <> Nothing And strlidusuario <> Nothing And strlBandeja <> Nothing And strlestadoinc <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap,N.Intento FROM Bandeja_uni B inner join (select casi_id,COUNT(*) as Intento,MAX(Fc_Reg) as Fc_Reg from Num_Intento group by casi_id) N on B.idcaso = N.casi_id where B.fcasignadoseg is null and B.idusuarioasigsup=@strlidusuario and N.Intento " & " " & strlNum_Intento & " " & " and B.Bandeja=@_Bandeja order by B.idcaso"
            End If
            '''''' Consulta por numero de Intentos, Usuario, Bandeja y Estado
            If strlNum_Intento <> Nothing And strlidusuario <> Nothing And strlBandeja <> Nothing And strlestadoinc <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "B.idcaso,B.cas_fecha_registro,B.min_ac,B.estado,B.digitado,B.fcsap,N.Intento FROM Bandeja_uni B inner join (select casi_id,COUNT(*) as Intento,MAX(Fc_Reg) as Fc_Reg from Num_Intento group by casi_id) N on B.idcaso = N.casi_id where B.fcasignadoseg is null and B.idusuarioasigsup=@strlidusuario and N.Intento " & " " & strlNum_Intento & " " & " and B.Bandeja=@_Bandeja and B.estado=@strlestadoinc order by B.idcaso"
            End If
            cms.Parameters.Add("@strlcantidad", SqlDbType.Int).Value = Me.strlcantidad
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub registrofallaservice()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO ServiceDetalle(idcaso,estado,fcregserv,idusuarioescala,obsescal) values(@strlcaso,'Reportado',@strlfcreg,@strlidusuario,@strlobs)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
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
    Public Function consultaenprocescalaserv() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idusuarioserv, COUNT(idcaso) AS casos FROM clarovoz.dbo.servicedetalle INNER JOIN datosclaro.dbo.usuarios u ON idusuarioserv = u.idusuario WHERE tickler IS NULL AND fcasignado is not null AND idusuarioserv IS NOT NULL AND u.cargo <> 'Retirado' GROUP BY idusuarioserv"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultapteasignartotalserv() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM serviceDetalle where fcasignado is null order by idcaso"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub asignaescalaxcasoserv()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE ServiceDetalle SET estado='Asignado', fcasignado=@strlfcreg, idusuarioasigna=@strlidusuario,idusuarioserv=@strlidusuarioasignado WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlidusuarioasignado", SqlDbType.VarChar, 50).Value = strlidusuarioasignado
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
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
    Public Function consultapteasignarserv() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT top " & " " & strlcantidad & " " & " * FROM ServiceDetalle where fcasignado is null order by idcaso"
            cms.Parameters.Add("@strlcantidad", SqlDbType.Int).Value = Me.strlcantidad
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaescaladosv2serv() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT Bandeja_uni.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja, munic, nombredpto, nombremun, escalam, fcreg, servicedetalle.tickler,idusuario, obs, vcrmdetalle.tipificacion, numalt, VCRMDetalle.idbarrio, localidad, barrio FROM Bandeja_uni INNER JOIN VCRMDetalle ON Bandeja_uni.idcaso = VCRMDetalle.idcaso LEFT OUTER JOIN Barrio ON VCRMDetalle.idbarrio = Barrio.idbarrio LEFT OUTER JOIN Divipola ON Bandeja_uni.munic = Divipola.coddiv inner join servicedetalle on bandeja_uni.idcaso=servicedetalle.idcaso where servicedetalle.fcasignado is not null and servicedetalle.tickler is null and servicedetalle.idusuarioserv=@strlidusuario order by idcaso"
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = strlidusuario
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT Bandeja_uni.idcaso, cas_fecha_registro, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, tipoinc, bandeja, munic, nombredpto, nombremun, escalam, fcreg, servicedetalle.tickler,idusuario, obs, vcrmdetalle.tipificacion, numalt, VCRMDetalle.idbarrio, localidad, barrio FROM Bandeja_uni INNER JOIN VCRMDetalle ON Bandeja_uni.idcaso = VCRMDetalle.idcaso LEFT OUTER JOIN Barrio ON VCRMDetalle.idbarrio = Barrio.idbarrio LEFT OUTER JOIN Divipola ON Bandeja_uni.munic = Divipola.coddiv inner join servicedetalle on bandeja_uni.idcaso=servicedetalle.idcaso where servicedetalle.fcasignado is not null and servicedetalle.tickler is null and servicedetalle.idusuarioserv=@strlidusuario and Bandeja_uni.idcaso=@strlcaso order by idcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcaso <> Nothing Then
                If strlcantidad > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("min_ac") Is System.DBNull.Value Then
                        strlmin = " "
                    Else
                        strlmin = dtsrecepcion.Tables(0).Rows(0).Item("min_ac")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente") Is System.DBNull.Value Then
                        strlcliente = " "
                    Else
                        strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente")
                    End If
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
    Public Sub actualizaescaladosv2serv()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE ServiceDetalle SET estado=@strlestadoinc,tickler=@strltickler,obsescalamiento=@strlobs,fcprocesado=@strlfcreg WHERE idcaso= @strlcaso"
            If strlfechafin <> "" Then
                cms.CommandText = "UPDATE ServiceDetalle SET estado=@strlestadoinc,tickler=@strltickler,obsescalamiento=@strlobs,fcprocesado=@strlfcreg,dev='1' WHERE idcaso= @strlcaso"
            End If
            cms.Parameters.Add("@strltickler", SqlDbType.VarChar, 50).Value = strltickler
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlfcreg", SqlDbType.NVarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlestadoinc", SqlDbType.NVarChar, 50).Value = strlestadoinc
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
    Public Sub actualizaestadodevueltoservvoz()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja_uni SET estado='No Disponible' WHERE idcaso= @strlcaso and estado<>'Cerrado'"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Sub liberaasigescalamservice()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE ServiceDetalle SET estado='Reportado', fcasignado=null, idusuarioserv=null WHERE idcaso=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Function consultaasignadoservicevoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT idcaso,fcregserv,idusuarioescala,fcasignado,idusuarioasigna FROM ServiceDetalle where idusuarioserv=@strlidusuario and fcprocesado is null"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function ConsultaAmdocs()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idcaso, cas_fecha_registro, min_ac, bandeja, estado FROM Bandeja_uni WHERE (((bandeja)<>'voz' And (bandeja)<>'otros serv' And (bandeja)<>'buzon' And (bandeja)<>'mensajes' And (bandeja)<>'bmf1' And (bandeja)<>'bmf2' And (bandeja)<>'bmf3' And (bandeja)<>'ldi') AND ((estado)='abierto' Or (estado)='gestionado' Or (estado)='rellamada' Or (estado)='programado')) order by cas_fecha_registro asc"
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Campaña_Report_Falla()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = " Select campana from VFallared  Where campana not like '' Group by campana order by campana "
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
    Public Function Consulta_Casosinforme_LDI()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT Bandeja_LDI.cas_id,Bandeja_uni.cas_fecha_registro,Bandeja_uni.fccorta,(select top 1 VCRMDetalle.fcreg from VCRMDetalle order by VCRMDetalle.fcreg desc) AS ÚltimoDefcreg,Bandeja_uni.estado,Bandeja_LDI.Usuario_Registra,Bandeja_LDI.Usuario_Asignado,Bandeja_LDI.cas_observaciones,(select top 1 VCRMDetalle.obs from VCRMDetalle order by VCRMDetalle.obs desc) AS ÚltimoDeobs,Bandeja_LDI.zona,Bandeja_LDI.nom_cliente,Bandeja_LDI.ciudad,Bandeja_LDI.min,Bandeja_LDI.destino_inter,Bandeja_LDI.numero_marco,Bandeja_LDI.grabacion,Bandeja_LDI.incon_destino,Bandeja_LDI.pais_destino,Bandeja_LDI.fecha_llamada_1,Bandeja_LDI.hora_llamada,Bandeja_LDI.hora_am_pm,Bandeja_LDI.tipo_clientesito FROM Bandeja_LDI INNER JOIN (Bandeja_uni LEFT JOIN VCRMDetalle ON Bandeja_uni.idcaso = VCRMDetalle.idcaso) ON Bandeja_LDI.cas_id = Bandeja_uni.idcaso GROUP BY Bandeja_LDI.cas_id,Bandeja_uni.cas_fecha_registro,Bandeja_uni.fccorta,Bandeja_uni.estado,Bandeja_LDI.Usuario_Registra,Bandeja_LDI.Usuario_Asignado,Bandeja_LDI.Usuario_Asignado,Bandeja_LDI.cas_observaciones,Bandeja_LDI.zona,Bandeja_LDI.nom_cliente,Bandeja_LDI.ciudad,Bandeja_LDI.min,Bandeja_LDI.destino_inter,Bandeja_LDI.numero_marco,Bandeja_LDI.grabacion,Bandeja_LDI.incon_destino,Bandeja_LDI.pais_destino,Bandeja_LDI.fecha_llamada_1,Bandeja_LDI.hora_llamada,Bandeja_LDI.hora_am_pm,Bandeja_LDI.tipo_clientesito HAVING (((Bandeja_uni.cas_fecha_registro)>@strlfechainicial And (Bandeja_uni.cas_fecha_registro)<@strlfechafin))"
            cms.Parameters.Add("@strlfechainicial", SqlDbType.DateTime).Value = strlfechainicial
            cms.Parameters.Add("@strlfechafin", SqlDbType.DateTime).Value = strlfechafin
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consultacasos_Datos_Voz() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim cnVoz As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cnDatos.Open()
            cms.CommandText = "select min_ac,cas_id,nom_cliente,no_documento,equipo_ac,plan_acual_ac,estado,cas_observaciones from Bandeja where cas_id=@_Caso"
            cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If (strlcantidad > 0) Then
                If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                End If
                If dts.Tables(0).Rows(0).Item("cas_id") Is DBNull.Value Then
                    strlcaso = ""
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("cas_id")
                End If
                If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                    strlcliente = ""
                Else
                    strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                End If
                If dts.Tables(0).Rows(0).Item("no_documento") Is DBNull.Value Then
                    strldocumento = ""
                Else
                    strldocumento = dts.Tables(0).Rows(0).Item("no_documento")
                End If
                If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                    strlequipo = ""
                Else
                    strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                End If
                If dts.Tables(0).Rows(0).Item("plan_acual_ac") Is DBNull.Value Then
                    strlplan = ""
                Else
                    strlplan = dts.Tables(0).Rows(0).Item("plan_acual_ac")
                End If
                If dts.Tables(0).Rows(0).Item("estado") Is DBNull.Value Then
                    strlestadoinc = ""
                Else
                    strlestadoinc = dts.Tables(0).Rows(0).Item("estado")
                End If
                If dts.Tables(0).Rows(0).Item("cas_observaciones") Is DBNull.Value Then
                    strlobsini = ""
                Else
                    strlobsini = dts.Tables(0).Rows(0).Item("cas_observaciones")
                End If
            Else
                cnVoz.Open()
                cms.CommandText = "select min_ac,idcaso,nom_cliente,documento,equipo_ac,estado from Bandeja_uni where idcaso=@_Caso"
                'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
                cms.Connection = cnVoz
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                strlcantidad = dts.Tables(0).Rows.Count
                If (strlcantidad > 0) Then
                    If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                        strlmin = ""
                    Else
                        strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                    End If
                    If dts.Tables(0).Rows(0).Item("idcaso") Is DBNull.Value Then
                        strlcaso = ""
                    Else
                        strlcaso = dts.Tables(0).Rows(0).Item("idcaso")
                    End If
                    If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                        strlcliente = ""
                    Else
                        strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                    End If
                    If dts.Tables(0).Rows(0).Item("documento") Is DBNull.Value Then
                        strldocumento = ""
                    Else
                        strldocumento = dts.Tables(0).Rows(0).Item("documento")
                    End If
                    If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                        strlequipo = ""
                    Else
                        strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                    End If
                    strlplan = ""
                    If dts.Tables(0).Rows(0).Item("estado") Is DBNull.Value Then
                        strlestadoinc = ""
                    Else
                        strlestadoinc = dts.Tables(0).Rows(0).Item("estado")
                    End If
                    strlobsini = ""
                End If
            End If
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cnDatos.State = ConnectionState.Open Then
                cnDatos.Close()
            End If
            If cnVoz.State = ConnectionState.Open Then
                cnVoz.Close()
            End If
        End Try
    End Function
    Public Sub Ingresar_Datos_Voz()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfechafin = Now
            cms.CommandText = "Insert into Modulo_Revision (fecreg,idusuario,idcaso,estado) values (@strlfechafin,@strlidusuario,@strlcaso,@strlestadoinc)"
            cms.Parameters.Add("@strlfechafin", SqlDbType.DateTime).Value = strlfechafin
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlestadoinc", SqlDbType.VarChar, 50).Value = strlestadoinc
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
    Public Function Consulta_Adicionales_MTI() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            If Validacion = "1" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'Empresa' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If Validacion = "2" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'Estado_Llamada' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If Validacion = "3" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'PREGUNTA' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If Validacion = "4" Then
                cms.CommandText = "select * from Bandeja_MTI where Convert(date,Fc_Programado) = (select Convert(date,GETDATE())) order by Nombre"
            End If
            If Validacion = "5" Then
                cms.CommandText = "select * from Bandeja_MTI where Convert(date,Fc_Programado) > (select Convert(date,GETDATE())) order by Nombre"
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Registro_MTI() As DataSet

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base

        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter

        Dim cms As New SqlClient.SqlCommand

        Dim ingreso As Integer = 0

        'Dim tmp As New Integer

        Try

            cn.Open()

            cms.CommandText = "select * from Bandeja_MTI where Cod_Bandeja_MTI= @_Cod_Bandeja_MTI"

            cms.Parameters.Add("@_Cod_Bandeja_MTI", SqlDbType.BigInt).Value = _Cod_Bandeja_MTI

            If _Empresa <> Nothing And _Nombre <> Nothing And _Telefono <> Nothing Then

                cms.CommandText = "select MAX(Cod_Bandeja_MTI) as Cod_Bandeja_MTI from Bandeja_MTI where Empresa=@_Empresa and Nombre=@_Nombre and Telefono=@_Telefono"

                cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 500).Value = _Empresa

                cms.Parameters.Add("@_Nombre", SqlDbType.VarChar, 60).Value = _Nombre

                cms.Parameters.Add("@_Telefono", SqlDbType.VarChar, 60).Value = _Telefono

                ingreso = 1

            End If

            cms.Connection = cn

            dta = New SqlClient.SqlDataAdapter(cms)

            dta.Fill(dts)

            strlcantidad = dts.Tables(0).Rows.Count

            If strlcantidad > 0 Then

                If dts.Tables(0).Rows(0).Item("Cod_Bandeja_MTI") Is System.DBNull.Value Then

                    _Cod_Bandeja_MTI = ""

                Else

                    _Cod_Bandeja_MTI = dts.Tables(0).Rows(0).Item("Cod_Bandeja_MTI")

                End If

                If ingreso = 0 Then

                    If dts.Tables(0).Rows(0).Item("Empresa") Is System.DBNull.Value Then

                        _Empresa = ""

                    Else

                        _Empresa = dts.Tables(0).Rows(0).Item("Empresa")

                    End If

                    If dts.Tables(0).Rows(0).Item("Nombre") Is System.DBNull.Value Then

                        _Nombre = ""

                    Else

                        _Nombre = dts.Tables(0).Rows(0).Item("Nombre")

                    End If

                    If dts.Tables(0).Rows(0).Item("Nombre1") Is System.DBNull.Value Then

                        _Nombre1 = ""

                    Else

                        _Nombre1 = dts.Tables(0).Rows(0).Item("Nombre1")

                    End If

                    If dts.Tables(0).Rows(0).Item("Nombre2") Is System.DBNull.Value Then

                        _Nombre2 = ""

                    Else

                        _Nombre2 = dts.Tables(0).Rows(0).Item("Nombre2")

                    End If

                    If dts.Tables(0).Rows(0).Item("Nombre3") Is System.DBNull.Value Then

                        _Nombre3 = ""

                    Else

                        _Nombre3 = dts.Tables(0).Rows(0).Item("Nombre3")

                    End If

                    If dts.Tables(0).Rows(0).Item("Cargo") Is System.DBNull.Value Then

                        _Cargo = ""

                    Else

                        _Cargo = dts.Tables(0).Rows(0).Item("Cargo")

                    End If

                    '--------------------Cargos---------------'



                    If dts.Tables(0).Rows(0).Item("Cargo1") Is System.DBNull.Value Then

                        _Cargo1 = ""

                    Else

                        _Cargo1 = dts.Tables(0).Rows(0).Item("Cargo1")

                    End If

                    If dts.Tables(0).Rows(0).Item("Cargo2") Is System.DBNull.Value Then

                        _Cargo2 = ""

                    Else

                        _Cargo2 = dts.Tables(0).Rows(0).Item("Cargo2")

                    End If

                    If dts.Tables(0).Rows(0).Item("Cargo3") Is System.DBNull.Value Then

                        _Cargo3 = ""

                    Else

                        _Cargo3 = dts.Tables(0).Rows(0).Item("Cargo3")

                    End If



                    If dts.Tables(0).Rows(0).Item("Correo") Is System.DBNull.Value Then

                        _Correo = ""

                    Else

                        _Correo = dts.Tables(0).Rows(0).Item("Correo")

                    End If

                    If dts.Tables(0).Rows(0).Item("Correo1") Is System.DBNull.Value Then

                        _Correo1 = ""

                    Else

                        _Correo1 = dts.Tables(0).Rows(0).Item("Correo1")

                    End If

                    If dts.Tables(0).Rows(0).Item("Correo2") Is System.DBNull.Value Then

                        _Correo2 = ""

                    Else

                        _Correo2 = dts.Tables(0).Rows(0).Item("Correo2")

                    End If

                    If dts.Tables(0).Rows(0).Item("Correo3") Is System.DBNull.Value Then

                        _Correo3 = ""

                    Else

                        _Correo3 = dts.Tables(0).Rows(0).Item("Correo3")

                    End If

                    If dts.Tables(0).Rows(0).Item("Telefono") Is System.DBNull.Value Then

                        _Telefono = Nothing

                    Else

                        _Telefono = dts.Tables(0).Rows(0).Item("Telefono")

                    End If

                    If dts.Tables(0).Rows(0).Item("Telefono") Is System.DBNull.Value Then

                        _Telefono = Nothing

                    Else

                        _Telefono = dts.Tables(0).Rows(0).Item("Telefono")

                    End If

                    If dts.Tables(0).Rows(0).Item("Telefono2") Is System.DBNull.Value Then

                        _Telefono2 = Nothing

                    Else

                        _Telefono2 = dts.Tables(0).Rows(0).Item("Telefono2")

                    End If

                    If dts.Tables(0).Rows(0).Item("Telefono3") Is System.DBNull.Value Then

                        _Telefono3 = Nothing

                    Else

                        _Telefono3 = dts.Tables(0).Rows(0).Item("Telefono3")

                    End If

                    If dts.Tables(0).Rows(0).Item("Realizo_llamada") Is System.DBNull.Value Then

                        _Realizo_llamada = ""

                    Else

                        _Realizo_llamada = dts.Tables(0).Rows(0).Item("Realizo_llamada")

                    End If

                    If dts.Tables(0).Rows(0).Item("Contacto_Adicional") Is System.DBNull.Value Then

                        _Contacto_Adicional = ""

                    Else

                        _Contacto_Adicional = dts.Tables(0).Rows(0).Item("Contacto_Adicional")

                    End If

                    If dts.Tables(0).Rows(0).Item("Comentario") Is System.DBNull.Value Then

                        _Comentario = ""

                    Else

                        _Comentario = dts.Tables(0).Rows(0).Item("Comentario")

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
    Public Sub Actualizacion_MTI()

        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)

        Dim cms As New SqlClient.SqlCommand

        Try

            cn.Open()

            If Validacion = "1" Then

                cms.CommandText = "update Bandeja_MTI set Id_Usuario=@strlidusuario,Fc_Reg=@strlfcreg,Empresa=@_Empresa,Nombre=@_Nombre,Nombre1=@_Nombre1,Nombre2=@_Nombre2,Nombre3=@_Nombre3,Cargo=@_Cargo,Cargo1=@_Cargo1,Cargo2=@_Cargo2,Cargo3=@_Cargo3,Correo=@_Correo,Correo1=@_Correo1,Correo2=@_Correo2,Correo3=@_Correo3,Telefono=@_Telefono,Telefono1=@_Telefono1,Telefono2=@_Telefono2,Telefono3=@_Telefono3,Realizo_llamada=@_Realizo_llamada,Contacto_Adicional=@_Contacto_Adicional,Comentario=@_Comentario where Cod_Bandeja_MTI=@_Cod_Bandeja_MTI"

                cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 500).Value = _Empresa

                cms.Parameters.Add("@_Nombre", SqlDbType.VarChar, 150).Value = _Nombre

                cms.Parameters.Add("@_Nombre1", SqlDbType.VarChar, 150).Value = _Nombre1

                cms.Parameters.Add("@_Nombre2", SqlDbType.VarChar, 150).Value = _Nombre2

                cms.Parameters.Add("@_Nombre3", SqlDbType.VarChar, 150).Value = _Nombre3

                cms.Parameters.Add("@_Cargo", SqlDbType.VarChar, 255).Value = _Cargo

                cms.Parameters.Add("@_Cargo1", SqlDbType.VarChar, 255).Value = _Cargo1

                cms.Parameters.Add("@_Cargo2", SqlDbType.VarChar, 255).Value = _Cargo2

                cms.Parameters.Add("@_Cargo3", SqlDbType.VarChar, 255).Value = _Cargo3

                cms.Parameters.Add("@_Correo", SqlDbType.VarChar, 80).Value = _Correo

                cms.Parameters.Add("@_Correo1", SqlDbType.VarChar, 80).Value = _Correo1

                cms.Parameters.Add("@_Correo2", SqlDbType.VarChar, 80).Value = _Correo2

                cms.Parameters.Add("@_Correo3", SqlDbType.VarChar, 80).Value = _Correo3

                cms.Parameters.Add("@_Telefono", SqlDbType.VarChar, 60).Value = _Telefono

                cms.Parameters.Add("@_Telefono1", SqlDbType.VarChar, 60).Value = _Telefono1

                cms.Parameters.Add("@_Telefono2", SqlDbType.VarChar, 60).Value = _Telefono2

                cms.Parameters.Add("@_Telefono3", SqlDbType.VarChar, 60).Value = _Telefono3

                cms.Parameters.Add("@_Celular", SqlDbType.BigInt).Value = _Celular

                cms.Parameters.Add("@_Realizo_llamada", SqlDbType.VarChar, 255).Value = _Realizo_llamada

                cms.Parameters.Add("@_Contacto_Adicional", SqlDbType.VarChar, 255).Value = _Contacto_Adicional

                cms.Parameters.Add("@_Comentario", SqlDbType.VarChar, 500).Value = _Comentario

            End If

            If Validacion = "2" Then

                If _Fc_Programado = "01/01/0001" Then

                    cms.CommandText = "update Bandeja_MTI set Id_Usuario=@strlidusuario,Fc_Reg=@strlfcreg,Estado_Llamada=@_Estado_Llamada,Fc_Programado=null where Cod_Bandeja_MTI=@_Cod_Bandeja_MTI"

                Else

                    cms.CommandText = "update Bandeja_MTI set Id_Usuario=@strlidusuario,Fc_Reg=@strlfcreg,Estado_Llamada=@_Estado_Llamada,Fc_Programado=@_Fc_Programado where Cod_Bandeja_MTI=@_Cod_Bandeja_MTI"

                End If

                cms.Parameters.Add("@_Estado_Llamada", SqlDbType.VarChar, 50).Value = _Estado_Llamada

                cms.Parameters.Add("@_Fc_Programado", SqlDbType.VarChar, 50).Value = _Fc_Programado

            End If

            If Validacion = "3" Then

                cms.CommandText = "update Bandeja_MTI set Id_Usuario=@strlidusuario,Fc_Reg=@strlfcreg,Recepcion_Invitacion=@_Recepcion_Invitacion,Persona_Interesada=@_Persona_Interesada,Asiste=@_Asiste where Cod_Bandeja_MTI=@_Cod_Bandeja_MTI"

                cms.Parameters.Add("@_Recepcion_Invitacion", SqlDbType.VarChar, 2).Value = _Recepcion_Invitacion

                cms.Parameters.Add("@_Persona_Interesada", SqlDbType.VarChar, 2).Value = _Persona_Interesada

                cms.Parameters.Add("@_Asiste", SqlDbType.VarChar, 2).Value = _Asiste

            End If

            strlfcreg = Now

            cms.Parameters.Add("@_Cod_Bandeja_MTI", SqlDbType.BigInt).Value = _Cod_Bandeja_MTI

            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario

            cms.Parameters.Add("@strlfcreg", SqlDbType.Date).Value = strlfcreg

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
    Public Sub Registro_MTI()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "insert into Bandeja_MTI (Id_Usuario,Fc_Reg,Empresa,Nombre,Nombre1,Nombre2,Nombre3,Cargo,Cargo1,Cargo2,Cargo3,Correo,Correo1,Correo2,Correo3,Telefono,Telefono1,Telefono2,Telefono3,Realizo_llamada,Contacto_Adicional,Comentario) values (@strlidusuario,@strlfcreg,@_Empresa,@_Nombre,@_Nombre1,@_Nombre2,@_Nombre3,@_Cargo,@_Cargo1,@_Cargo2,@_Cargo3,@_Correo,@_Correo1,@_Correo2,@_Correo3,@_Telefono,@_Telefono1,@_Telefono2,@_Telefono3,@_Realizo_llamada,@_Contacto_Adicional,@_Comentario)"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.Date).Value = strlfcreg
            cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 500).Value = _Empresa
            cms.Parameters.Add("@_Nombre", SqlDbType.VarChar, 150).Value = _Nombre
            cms.Parameters.Add("@_Nombre1", SqlDbType.VarChar, 150).Value = _Nombre1
            cms.Parameters.Add("@_Nombre2", SqlDbType.VarChar, 150).Value = _Nombre2
            cms.Parameters.Add("@_Nombre3", SqlDbType.VarChar, 150).Value = _Nombre3
            cms.Parameters.Add("@_Cargo", SqlDbType.VarChar, 255).Value = _Cargo
            cms.Parameters.Add("@_Cargo1", SqlDbType.VarChar, 255).Value = _Cargo1
            cms.Parameters.Add("@_Cargo2", SqlDbType.VarChar, 255).Value = _Cargo2
            cms.Parameters.Add("@_Cargo3", SqlDbType.VarChar, 255).Value = _Cargo3
            cms.Parameters.Add("@_Correo", SqlDbType.VarChar, 80).Value = _Correo
            cms.Parameters.Add("@_Correo1", SqlDbType.VarChar, 80).Value = _Correo1
            cms.Parameters.Add("@_Correo2", SqlDbType.VarChar, 80).Value = _Correo2
            cms.Parameters.Add("@_Correo3", SqlDbType.VarChar, 80).Value = _Correo3
            cms.Parameters.Add("@_Telefono", SqlDbType.VarChar, 60).Value = _Telefono
            cms.Parameters.Add("@_Telefono1", SqlDbType.VarChar, 60).Value = _Telefono1
            cms.Parameters.Add("@_Telefono2", SqlDbType.VarChar, 60).Value = _Telefono2
            cms.Parameters.Add("@_Telefono3", SqlDbType.VarChar, 60).Value = _Telefono3
            cms.Parameters.Add("@_Celular", SqlDbType.BigInt).Value = _Celular
            cms.Parameters.Add("@_Realizo_llamada", SqlDbType.VarChar, 255).Value = _Realizo_llamada
            cms.Parameters.Add("@_Contacto_Adicional", SqlDbType.VarChar, 255).Value = _Contacto_Adicional
            cms.Parameters.Add("@_Comentario", SqlDbType.VarChar, 500).Value = _Comentario
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
    Public Function Consulta_Bandeja_MTI() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from Bandeja_MTI order by Cod_Bandeja_MTI desc"
            If _Estado_Llamada <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Estado_Llamada=@_Estado_Llamada order by Cod_Bandeja_MTI desc"
                cms.Parameters.Add("@_Estado_Llamada", SqlDbType.VarChar, 50).Value = _Estado_Llamada
            End If
            If _Persona_Interesada <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Persona_Interesada=@_Persona_Interesada order by Cod_Bandeja_MTI desc"
                cms.Parameters.Add("@_Persona_Interesada", SqlDbType.VarChar, 2).Value = _Persona_Interesada
            End If
            If _Asiste <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Asiste=@_Asiste order by Cod_Bandeja_MTI desc"
                cms.Parameters.Add("@_Asiste", SqlDbType.VarChar, 2).Value = _Asiste
            End If
            If _Fc_Programado <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Convert(date,Fc_Programado)>=@_Fc_Programado order by Cod_Bandeja_MTI desc"
                cms.Parameters.Add("@_Fc_Programado", SqlDbType.Date).Value = _Fc_Programado
            End If
            If _Estado_Llamada <> Nothing And _Fc_Programado <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Estado_Llamada=@_Estado_Llamada and Convert(date,Fc_Programado)>=@_Fc_Programado order by Cod_Bandeja_MTI desc"
            End If
            If _Estado_Llamada <> Nothing And _Persona_Interesada <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Estado_Llamada=@_Estado_Llamada and Persona_Interesada=@_Persona_Interesada order by Cod_Bandeja_MTI desc"
            End If
            If _Estado_Llamada <> Nothing And _Asiste <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Estado_Llamada=@_Estado_Llamada and Asiste=@_Asiste order by Cod_Bandeja_MTI desc"
            End If
            If _Persona_Interesada <> Nothing And _Asiste <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Persona_Interesada=@_Persona_Interesada and Asiste=@_Asiste order by Cod_Bandeja_MTI desc"
            End If
            If _Persona_Interesada <> Nothing And _Fc_Programado <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Persona_Interesada=@_Persona_Interesada and Convert(date,Fc_Programado)>=@_Fc_Programado order by Cod_Bandeja_MTI desc"
            End If
            If _Asiste <> Nothing And _Fc_Programado <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where  Asiste=@_Asiste and Convert(date,Fc_Programado)>=@_Fc_Programado order by Cod_Bandeja_MTI desc"
            End If
            If _Estado_Llamada <> Nothing And _Persona_Interesada <> Nothing And _Asiste <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Estado_Llamada=@_Estado_Llamada and Persona_Interesada=@_Persona_Interesada and Asiste=@_Asiste order by Cod_Bandeja_MTI desc"
            End If
            If _Estado_Llamada <> Nothing And _Persona_Interesada <> Nothing And _Asiste <> Nothing And _Fc_Programado <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Estado_Llamada=@_Estado_Llamada and Persona_Interesada=@_Persona_Interesada and Asiste=@_Asiste and Convert(date,Fc_Programado)>=@_Fc_Programado order by Cod_Bandeja_MTI desc"
            End If
            If _Empresa <> Nothing Then
                cms.CommandText = "Select * from Bandeja_MTI where Empresa=@_Empresa order by Cod_Bandeja_MTI desc"
                cms.Parameters.Add("@_Empresa", SqlDbType.VarChar, 500).Value = _Empresa
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function ConsultadrlBienvenidaDatos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = "1" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'BienvenidaD1' or Pertenece='- Seleccione -'"
            End If
            If Validacion = "Llamada Rechazada" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'BienvenidaD2' or Pertenece='- Seleccione -'"
            End If
            If Validacion = "3" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'BienvenidaD3' or Pertenece='- Seleccione -'"
            End If
            If Validacion = "Llamada Buzon" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'BienvenidaD4' or Pertenece='- Seleccione -'"
            End If
            If Validacion = "Llamada Programada" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'BienvenidaD5' or Pertenece='- Seleccione -'"
            End If
            If Validacion = "Estado_Encuesta" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'Tipificaciones_Encuesta' or Pertenece='- Seleccione -'"
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
    'Public Function consultaprogramado() As DataSet
    '    Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
    '    Dim dtsrecepcion As New DataSet
    '    Dim dtarecepcion As SqlClient.SqlDataAdapter
    '    Dim cms As New SqlClient.SqlCommand
    '    Try
    '        cn.Open()
    '        cms.CommandText = "SELECT idcaso, MAX(dbo.CRMDetalle.fcprogram) AS Fcprog, estado, correo_electronico FROM CRMDetalle INNER JOIN Bandeja ON CRMDetalle.idcaso = Bandeja.cas_id GROUP BY idcaso, estado, correo_electronico HAVING estado = N'Programado' and correo_electronico=@strlidusuario order by fcprog"
    '        cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = Me.strlidusuario
    '        cms.Connection = cn
    '        dtarecepcion = New SqlClient.SqlDataAdapter(cms)
    '        dtarecepcion.Fill(dtsrecepcion)
    '        strlcantidad = dtsrecepcion.Tables(0).Rows.Count
    '        Return dtsrecepcion
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Function
    Public Function consultaasignadoseg() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idcaso,fcasignadoseg,idusuarioasig,estado,min_ac FROM Bandeja_uni where estado<>'cerrado' and estado<>'escalado' and estado<>'rechazado' and idusuarioasig=@strlidusuario order by idcaso"
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function validacasoasignadovoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT min_ac,idcaso,fcasignado,idusuarioasig FROM Bandeja_uni where idusuarioasig=@strlidusuario and idcaso=@strlcaso"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = Me.strlcaso
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaasignadogestionvoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT idusuarioasigsup,min_ac,idcaso,fcasignadoseg,idusuarioasig FROM Bandeja_uni where idusuarioasig is not null and idusuarioasigsup is not null"
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT min_ac,idcaso,fcasignadoseg,idusuarioasig FROM Bandeja_uni where idusuarioasig=@strlidusuario"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            End If
            If strlSuperv <> Nothing Then
                cms.CommandText = "SELECT min_ac,idcaso,fcasignadoseg,idusuarioasig FROM Bandeja_uni where " + strlidusuario + ""
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub liberaasiggestionvoz()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja_uni SET idusuarioasig=null, fcasignadoseg=null WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Function enprocesofallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idusuarioasignado, COUNT(idcaso) AS casos FROM ctrlfallatec WHERE fcproceso is null and idusuarioasignado is not null GROUP BY idusuarioasignado"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function pteasignacionfallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT COUNT(idcaso) AS cantidad FROM Ctrlfallatec WHERE fcasignacion IS NULL"
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("cantidad") Is System.DBNull.Value Then
                    strlcantidad = " "
                Else
                    strlcantidad = dtsrecepcion.Tables(0).Rows(0).Item("cantidad")
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
    Public Sub asignacasofallatec()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE ctrlfallatec SET idusuarioasignado=@strlidusuario, fcasignacion=@strlfcreg, idusuarioasigna=@strlidusuarioasignado WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuarioasignado", SqlDbType.VarChar, 50).Value = strlidusuarioasignado
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
    Public Function consultapteasignarfallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "idcaso,min,tickler,fcsap FROM ctrlfallatec where fcasignacion is null order by idcaso"
            cms.Parameters.Add("@strlcantidad", SqlDbType.Int).Value = Me.strlcantidad
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub liberaasigfallatec()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE ctrlfallatec SET idusuarioasignado=null, fcasignacion=null, idusuarioasigna=null WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Function consultaasignadofallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT min,idcaso,idusuarioasignado,fcasignacion,idusuarioasigna FROM ctrlfallatec where idusuarioasignado=@strlidusuario and fcproceso is null"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function consultaasigxusufallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idcaso,fcsap,min,tickler,fcasignacion,idusuarioasigna,idusuarioasignado FROM ctrlfallatec where fcproceso is null and idusuarioasignado=@strlidusuario order by idcaso"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub actualizafallatec()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE ctrlfallatec SET fcproceso=@strlfcreg,estado=@strldir WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strldir", SqlDbType.NVarChar, 50).Value = strldir
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
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
    Public Function Consulta_Tipificacion_TiendaVirtual() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from BD_Voz_Complemento where Pertenece = 'TiendaVirtual' or Pertenece = '- Seleccione -'"
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
    Public Function Consulta_Bandeja_TiendaVirtual() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from Tienda_Virtual where Id_Tienda_Virtual = @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Id_Tienda_Virtual") Is DBNull.Value Then
                    strlcaso = ""
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("Id_Tienda_Virtual")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre") Is DBNull.Value Then
                    _Nombre = ""
                Else
                    _Nombre = dts.Tables(0).Rows(0).Item("Nombre")
                End If
                If dts.Tables(0).Rows(0).Item("Fecha_Formato_Tickler") Is DBNull.Value Then
                    strlfcini3 = ""
                Else
                    strlfcini3 = dts.Tables(0).Rows(0).Item("Fecha_Formato_Tickler")
                End If
                If dts.Tables(0).Rows(0).Item("Fecha_Ini_Gestion") Is DBNull.Value Then
                    strlfcini = ""
                Else
                    strlfcini = dts.Tables(0).Rows(0).Item("Fecha_Ini_Gestion")
                End If
                If dts.Tables(0).Rows(0).Item("Fecha_Fin_Gestion") Is DBNull.Value Then
                    strlfcfin = ""
                Else
                    strlfcfin = dts.Tables(0).Rows(0).Item("Fecha_Fin_Gestion")
                End If
                If dts.Tables(0).Rows(0).Item("Estado") Is DBNull.Value Then
                    _Estado_Llamada = ""
                Else
                    _Estado_Llamada = dts.Tables(0).Rows(0).Item("Estado")
                End If
                If dts.Tables(0).Rows(0).Item("Observacion") Is DBNull.Value Then
                    strlobs = ""
                Else
                    strlobs = dts.Tables(0).Rows(0).Item("Observacion")
                End If
            End If
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub Ingresar_Tienda_Virtual()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "insert into Tienda_Virtual (Fc_Reg,Id_Usuario,Nombre,Fecha_Formato_Tickler,Fecha_Ini_Gestion,Fecha_Fin_Gestion,Estado,Observacion) values (@strlfcreg,@strlidusuario,@_Nombre,@strlfcini3,@strlfcini,@strlfcfin,@_Estado_Llamada,@strlobs)"
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@_Nombre", SqlDbType.VarChar, 120).Value = _Nombre
            cms.Parameters.Add("@strlfcini3", SqlDbType.VarChar, 50).Value = strlfcini3
            cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = strlfcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = strlfcfin
            cms.Parameters.Add("@_Estado_Llamada", SqlDbType.VarChar, 50).Value = _Estado_Llamada
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar, 800).Value = strlobs
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub Actualiza_Tienda_Virtual()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Now
            If _Estado_Llamada = "1" Then
                cms.CommandText = "update Tienda_Virtual set Fc_Reg=@strlfcreg,Id_Usuario=@strlidusuario,Nombre=@_Nombre,Fecha_Formato_Tickler=@strlfcini3,Fecha_Ini_Gestion=@strlfcini,Fecha_Fin_Gestion=@strlfcfin,Observacion=@strlobs where Id_Tienda_Virtual = @strlcaso"
            Else
                cms.CommandText = "update Tienda_Virtual set Fc_Reg=@strlfcreg,Id_Usuario=@strlidusuario,Nombre=@_Nombre,Fecha_Formato_Tickler=@strlfcini3,Fecha_Ini_Gestion=@strlfcini,Fecha_Fin_Gestion=@strlfcfin,Estado=@_Estado_Llamada,Observacion=@strlobs where Id_Tienda_Virtual = @strlcaso"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@_Nombre", SqlDbType.VarChar, 120).Value = _Nombre
            cms.Parameters.Add("@strlfcini3", SqlDbType.VarChar, 50).Value = strlfcini3
            cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = strlfcini
            cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = strlfcfin
            cms.Parameters.Add("@_Estado_Llamada", SqlDbType.VarChar, 50).Value = _Estado_Llamada
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar, 800).Value = strlobs
            cms.Connection = cn
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''' Fallas Voz Y Datos - Clientes con Intención de Desactivación '''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub RegistroCRM_Falla_Red_Falla_Desactivacion_D_V()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO CRM_Falla_Desactivacion_D_V(Fk_Id_Bandeja,Id_Usuario,Obs,Tipificacion,Falla_Red,Equipo,Segmentacion_Linea,Correo_Electronico) values (@strlcaso,@strlidusuario,@strlobs,@strltipificacion,'Si','Creado Falla Red','Creado Falla Red','Creado Falla Red')"
            If _Validacion = "Service" Then
                cms.CommandText = "INSERT INTO CRM_Falla_Desactivacion_D_V(Fk_Id_Bandeja,Id_Usuario,Obs,Tipificacion,Falla_Red,Equipo,Segmentacion_Linea,Correo_Electronico) values (@strlcaso,@strlidusuario,@strlobs,@strltipificacion,'Si','Creado Service','Creado Service','Creado Service')"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
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

    Public Function Jefe_A_Cargo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from usuarios where Supervisor=@strlSuperv and idusuario <> Supervisor order by nombreu"
            If _Validacion <> Nothing Then
                cms.CommandText = "select * from usuarios where Supervisor=@strlSuperv and idusuario <> Supervisor or nombreu='- Seleccione -' order by nombreu"
            End If
            cms.Parameters.Add("@strlSuperv", SqlDbType.VarChar, 50).Value = strlSuperv
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function ConsultaEscalarService() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from BD_Voz_Complemento where Nombre=@Nombre and Pertenece='EscalamientoVoz'"
            cms.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = Nombre
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consultar_InconsistenciaVoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from detalleinc where idcaso=@caso"
            cms.Parameters.Add("@caso", SqlDbType.BigInt).Value = caso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_Diganostico_Carga_Voz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select TOP 1  DD.idreg,DD.fcreg,DD.tecnologia,DD.nunicipio,DD.Equipo,DD.barrio,Loca.localidad,DD.fcultimac,DD.franjaultimac,DD.Tipo_PQR,DD.Tipo_Cliente,DD.Modalidad,CRM.PQR,CRM.preg1 ,Marc.marca,Divp.coddpto from clarovoz.dbo.Bandeja_uni B inner join clarovoz.dbo.Detalle_diagnostico DD on B.idcaso=DD.idcaso left join (Select top 1 idcrm,idcaso,preg1,PQR from clarovoz.dbo.vCRMDetalle where idcaso=@strlcaso order by idcrm desc) CRM on DD.idcaso=CRM.idcaso left join (select ES.marca,Eq.Equipo from(Select top 1 idreg,Equipo from clarovoz.dbo.detalle_diagnostico where idcaso=@strlcaso order by idreg desc) Eq inner join datosclaro.dbo.EquipoStandar ES on Eq.Equipo=ES.equipo) Marc on DD.Equipo = Marc.Equipo left join (select ES.localidad,Eq.barrio from(Select top 1 idreg,Barrio from clarovoz.dbo.detalle_diagnostico where idcaso=@strlcaso order by idreg desc) Eq inner join clarovoz.dbo.Barrio ES on Eq.barrio=ES.barrio) as Loca on loca.barrio =dd.barrio  left join (select Div.coddpto,Nun.nunicipio from(Select top 1 idreg,nunicipio from clarovoz.dbo.detalle_diagnostico where idcaso=@strlcaso order by idreg desc) Nun inner join datosclaro.dbo.Divipola Div on Nun.nunicipio=Div.coddiv) Divp on DD.nunicipio=Divp.nunicipio where B.idcaso=@strlcaso order by DD.idreg desc"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("tecnologia") Is System.DBNull.Value Then
                    strltecnologia = " "
                Else
                    strltecnologia = dts.Tables(0).Rows(0).Item("tecnologia")
                End If
                If dts.Tables(0).Rows(0).Item("Marca") Is System.DBNull.Value Then
                    strlmarca = " "
                Else
                    strlmarca = dts.Tables(0).Rows(0).Item("Marca")
                End If
                If dts.Tables(0).Rows(0).Item("Equipo") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dts.Tables(0).Rows(0).Item("Equipo")
                End If
                If dts.Tables(0).Rows(0).Item("coddpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dts.Tables(0).Rows(0).Item("coddpto")
                End If
                If dts.Tables(0).Rows(0).Item("nunicipio") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dts.Tables(0).Rows(0).Item("nunicipio")
                End If
                If dts.Tables(0).Rows(0).Item("Localidad") Is System.DBNull.Value Then
                    strllocalidad = " "
                Else
                    strllocalidad = dts.Tables(0).Rows(0).Item("Localidad")
                End If
                If dts.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dts.Tables(0).Rows(0).Item("barrio")
                End If
                If dts.Tables(0).Rows(0).Item("fcultimac") Is System.DBNull.Value Then
                    strlfcultimac = " "
                Else
                    strlfcultimac = dts.Tables(0).Rows(0).Item("fcultimac")
                End If
                If dts.Tables(0).Rows(0).Item("franjaultimac") Is System.DBNull.Value Then
                    strlfranjaultimac = " "
                Else
                    strlfranjaultimac = dts.Tables(0).Rows(0).Item("franjaultimac")
                End If
                If dts.Tables(0).Rows(0).Item("Tipo_PQR") Is System.DBNull.Value Then
                    _Tipo_PQR = " "
                Else
                    _Tipo_PQR = dts.Tables(0).Rows(0).Item("Tipo_PQR")
                End If
                If dts.Tables(0).Rows(0).Item("Tipo_Cliente") Is System.DBNull.Value Then
                    _Tipo_Cliente = " "
                Else
                    _Tipo_Cliente = dts.Tables(0).Rows(0).Item("Tipo_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Modalidad") Is System.DBNull.Value Then
                    _Modalidad = " "
                Else
                    _Modalidad = dts.Tables(0).Rows(0).Item("Modalidad")
                End If

                If dts.Tables(0).Rows(0).Item("PQR") Is System.DBNull.Value Then
                    strlpqr = " "
                Else
                    strlpqr = dts.Tables(0).Rows(0).Item("PQR")
                End If
                If dts.Tables(0).Rows(0).Item("preg1") Is System.DBNull.Value Then
                    strlpreg1 = " "
                Else
                    strlpreg1 = dts.Tables(0).Rows(0).Item("preg1")
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
    Public Function Consulta_VFallared_Bandeja_Fideliza() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base de datos
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from clarovoz.dbo.VFallared VF inner join datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V BFD on VF.idcaso=BFD.Id_Caso LEFT OUTER JOIN clarovoz.dbo.Divipola D on VF.munfalla = D.coddiv where VF.idcaso=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Call_Remite") Is System.DBNull.Value Then
                    strllugar = " "
                Else
                    strllugar = dts.Tables(0).Rows(0).Item("Call_Remite")
                End If
                If dts.Tables(0).Rows(0).Item("min") Is System.DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dts.Tables(0).Rows(0).Item("min")
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
    Public Sub RegistroCrm_FallaRed_Fidelizacion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO CRM_Falla_Desactivacion_D_V (Fk_Id_Bandeja,Id_Usuario,Obs,Tipificacion,Falla_Red,Equipo,Segmentacion_Linea,Correo_Electronico) values (@strlcaso,@strlidusuario,@strlobs,@strltipificacion,'Si','Seguimiento Falla Red','Seguimiento Falla Red','Seguimiento Falla Red')"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
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


    '''''''''''Encuesta de percepcion''''''''''
    Public Function Consulta_Listas_Poll_Perception_Service() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from Poll_P_S_Des_Option where Pertenece=@_Validacion or Pertenece='- Seleccione -' order by Nombre_Poll_P_S_Des_Option"
            cms.Parameters.Add("@_Validacion", SqlDbType.VarChar).Value = _Validacion
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

    Public Function Consulta_Bandeja_Poll_Perception_Service() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from Bandeja_Poll_Perception_Service where Id_Caso=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then

                If dts.Tables(0).Rows(0).Item("Fecha_reg") Is DBNull.Value Then
                    _Recomienda_Contratar_Servicios_Claro_AmigaConocida = ""
                Else
                    _Recomienda_Contratar_Servicios_Claro_AmigaConocida = dts.Tables(0).Rows(0).Item("Fecha_reg")
                End If

                If dts.Tables(0).Rows(0).Item("Grupo") Is DBNull.Value Then
                    _Titular_Linea = ""
                Else
                    _Titular_Linea = dts.Tables(0).Rows(0).Item("Grupo")
                End If

                If dts.Tables(0).Rows(0).Item("Min_Ac") Is DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dts.Tables(0).Rows(0).Item("Min_Ac")
                End If

                If dts.Tables(0).Rows(0).Item("Departamento") Is DBNull.Value Then
                    _Que_Tan_Satisfecho_Con_Servicio_Voz = ""
                Else
                    _Que_Tan_Satisfecho_Con_Servicio_Voz = dts.Tables(0).Rows(0).Item("Departamento")
                End If

                If dts.Tables(0).Rows(0).Item("Municipio") Is DBNull.Value Then
                    _Establecimiento_Llamadas = ""
                Else
                    _Establecimiento_Llamadas = dts.Tables(0).Rows(0).Item("Municipio")
                End If

                If dts.Tables(0).Rows(0).Item("Tipo_Linea") Is DBNull.Value Then
                    _Continuidad_Llamadas = ""
                Else
                    _Continuidad_Llamadas = dts.Tables(0).Rows(0).Item("Tipo_Linea")
                End If

                If dts.Tables(0).Rows(0).Item("Name_Custumer") Is DBNull.Value Then
                    strlcliente = ""
                Else
                    strlcliente = dts.Tables(0).Rows(0).Item("Name_Custumer")
                End If

                If dts.Tables(0).Rows(0).Item("Estado") Is DBNull.Value Then
                    strltipificacion = ""
                Else
                    strltipificacion = dts.Tables(0).Rows(0).Item("Estado")
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
    Public Sub RegistroCRM_Poll_Perception_Service_Short()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If Validacion = "encuesta_satisfecha" Then
                cms.CommandText = "Insert into CRM_Poll_Perception_Service_Short (Fk_Id_Caso,Tipo_Poll,Id_Usuario,Genero,Titular_Linea,Tipo_Cliente,Internet_Redes_sociales,Dificultad_Usar_Servicio_Datos,Dificultad_Usar_Servicio_Voz,Ha_Tenido_Dificultad_Datos,Ha_Tenido_Dificultad_Voz,Cual_Es_Mas_Molesta_Datos,Cual_Es_Mas_Molesta_Voz,Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos,Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz,Estado,Observaciones,Intension_Del_Usuario) values (@strlcaso,@_Tipo_Poll,@strlidusuario,@_Genero,@_Titular_Linea,@_Tipo_Cliente,@_Internet_Redes_sociales,@_Dificultad_Usar_Servicio_Datos,@_Dificultad_Usar_Servicio_Voz,@_Ha_Tenido_Dificultad_Datos,@_Ha_Tenido_Dificultad_Voz,@_Cual_Es_Mas_Molesta_Datos,@_Cual_Es_Mas_Molesta_Voz,@_Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos,@_Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz,@strltipificacion,@Observaciones,@_Intencion_Del_Usuario)"
                cms.Parameters.Add("@_Tipo_Poll", SqlDbType.VarChar, 50).Value = _Tipo_Poll
                cms.Parameters.Add("@_Genero", SqlDbType.VarChar, 20).Value = _Genero
                cms.Parameters.Add("@_Titular_Linea", SqlDbType.VarChar, 20).Value = _Titular_Linea
                cms.Parameters.Add("@_Tipo_Cliente", SqlDbType.VarChar, 20).Value = _Tipo_Cliente
                cms.Parameters.Add("@_Internet_Redes_sociales", SqlDbType.VarChar, 20).Value = _Internet_Redes_sociales
                cms.Parameters.Add("@_Dificultad_Usar_Servicio_Datos", SqlDbType.VarChar, 20).Value = _Dificultad_Usar_Servicio_Datos
                cms.Parameters.Add("@_Dificultad_Usar_Servicio_Voz", SqlDbType.VarChar, 20).Value = _Dificultad_Usar_Servicio_Voz
                cms.Parameters.Add("@_Ha_Tenido_Dificultad_Datos", SqlDbType.VarChar, 120).Value = _Ha_Tenido_Dificultad_Datos
                cms.Parameters.Add("@_Ha_Tenido_Dificultad_Voz", SqlDbType.VarChar, 120).Value = _Ha_Tenido_Dificultad_Voz
                cms.Parameters.Add("@_Cual_Es_Mas_Molesta_Datos", SqlDbType.VarChar, 120).Value = _Cual_Es_Mas_Molesta_Datos
                cms.Parameters.Add("@_Cual_Es_Mas_Molesta_Voz", SqlDbType.VarChar, 120).Value = _Cual_Es_Mas_Molesta_Voz
                cms.Parameters.Add("@_Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos", SqlDbType.VarChar, 100).Value = _Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos
                cms.Parameters.Add("@_Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz", SqlDbType.VarChar, 100).Value = _Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz
                cms.Parameters.Add("@_Intencion_Del_Usuario", SqlDbType.VarChar, 50).Value = _Persona_Interesada
            End If
            If Validacion = "encuesta_rechazada" Then
                cms.CommandText = "Insert into CRM_Poll_Perception_Service_Short (Fk_Id_Caso,Id_Usuario,Motivo_LLamada_Culminada,Tipo_Poll,Genero, Titular_Linea, Tipo_Cliente, Internet_Redes_sociales, Dificultad_Usar_Servicio_Datos, Dificultad_Usar_Servicio_Voz, Ha_Tenido_Dificultad_Datos, Ha_Tenido_Dificultad_Voz, Cual_Es_Mas_Molesta_Datos, Cual_Es_Mas_Molesta_Voz, Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos, Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz, Estado, Observaciones) values (@strlcaso,@strlidusuario,@_motivo_culminado,'','','','','','','','','','','','','',@strltipificacion,@Observaciones)"
                cms.Parameters.Add("@_motivo_culminado", SqlDbType.VarChar, 50).Value = Claridad_Llamadas
            End If
            If Validacion = "encuesta_programada" Then
                cms.CommandText = "Insert into CRM_Poll_Perception_Service_Short (Fk_Id_Caso,Id_Usuario,Motivo_LLamada_Culminada,Tipo_Poll,Genero, Titular_Linea, Tipo_Cliente, Internet_Redes_sociales, Dificultad_Usar_Servicio_Datos, Dificultad_Usar_Servicio_Voz, Ha_Tenido_Dificultad_Datos, Ha_Tenido_Dificultad_Voz, Cual_Es_Mas_Molesta_Datos, Cual_Es_Mas_Molesta_Voz, Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos, Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz, Estado, Observaciones,Fecha_Programado) values (@strlcaso,@strlidusuario,'','','','','','','','','','','','','','',@strltipificacion,@Observaciones,@fecha_programado)"
                cms.Parameters.Add("@fecha_programado", SqlDbType.VarChar, 50).Value = strlfcreg
            End If
            If Validacion = "encuesta_buzon" Then
                cms.CommandText = "Insert into CRM_Poll_Perception_Service_Short (Fk_Id_Caso,Id_Usuario,Motivo_LLamada_Culminada,Tipo_Poll,Genero, Titular_Linea, Tipo_Cliente, Internet_Redes_sociales, Dificultad_Usar_Servicio_Datos, Dificultad_Usar_Servicio_Voz, Ha_Tenido_Dificultad_Datos, Ha_Tenido_Dificultad_Voz, Cual_Es_Mas_Molesta_Datos, Cual_Es_Mas_Molesta_Voz, Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos, Como_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz, Estado, Observaciones) values (@strlcaso,@strlidusuario,'','','','','','','','','','','','','','',@strltipificacion,@Observaciones)"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@Observaciones", SqlDbType.VarChar, 1000).Value = obs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = strltipificacion
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


    Public Sub RegistroCRM_Poll_Perception_Service_Long()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            Dim Datos As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "Insert into CRM_Poll_Perception_Service_Long (Fk_Id_Caso,Tipo_Poll,Id_Usuario,Recomienda_Contratar_Servicios_Claro_AmigaConocida,Que_Tan_Satisfecho_Con_Servicio_Voz,Establecimiento_Llamadas,Continuidad_Llamadas,Claridad_Llamadas,Que_Tan_Satisfecho_Con_Servicio_Datos,Accesibilidad_Servicio_Datos,Capacidad_Retencion_Servicio_Datos,Velocidad_Navegacion_Servicio_Datos,Envio_Recepcion_Correos_Electronicos,Envio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line,Subir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Otras,Tiempo_Espera_Para_Abrir_Pagina_Favorita_Internet,Estado) values (@strlcaso,@_Tipo_Poll,@strlidusuario,@_Recomienda_Contratar_Servicios_Claro_AmigaConocida,@_Que_Tan_Satisfecho_Con_Servicio_Voz,@_Establecimiento_Llamadas,@_Continuidad_Llamadas,@_Claridad_Llamadas,@_Que_Tan_Satisfecho_Con_Servicio_Datos,@_Accesibilidad_Servicio_Datos,@_Capacidad_Retencion_Servicio_Datos,@_Velocidad_Navegacion_Servicio_Datos,@_Envio_Recepcion_Correos_Electronicos,@_Envio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line,@_Subir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales,@_Tiempo_Espera_Para_Abrir_Pagina_Favorita_Internet,@strltipificacion) SELECT SCOPE_IDENTITY() as Cod"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@_Tipo_Poll", SqlDbType.VarChar, 50).Value = _Tipo_Poll
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@_Recomienda_Contratar_Servicios_Claro_AmigaConocida", SqlDbType.Int).Value = _Recomienda_Contratar_Servicios_Claro_AmigaConocida
            cms.Parameters.Add("@_Que_Tan_Satisfecho_Con_Servicio_Voz", SqlDbType.Int).Value = _Que_Tan_Satisfecho_Con_Servicio_Voz
            cms.Parameters.Add("@_Establecimiento_Llamadas", SqlDbType.Int).Value = _Establecimiento_Llamadas
            cms.Parameters.Add("@_Continuidad_Llamadas", SqlDbType.Int).Value = _Continuidad_Llamadas
            cms.Parameters.Add("@_Claridad_Llamadas", SqlDbType.Int).Value = _Claridad_Llamadas
            cms.Parameters.Add("@_Que_Tan_Satisfecho_Con_Servicio_Datos", SqlDbType.Int).Value = _Que_Tan_Satisfecho_Con_Servicio_Datos
            cms.Parameters.Add("@_Accesibilidad_Servicio_Datos", SqlDbType.Int).Value = _Accesibilidad_Servicio_Datos
            cms.Parameters.Add("@_Capacidad_Retencion_Servicio_Datos", SqlDbType.Int).Value = _Capacidad_Retencion_Servicio_Datos
            cms.Parameters.Add("@_Velocidad_Navegacion_Servicio_Datos", SqlDbType.Int).Value = _Velocidad_Navegacion_Servicio_Datos
            cms.Parameters.Add("@_Envio_Recepcion_Correos_Electronicos", SqlDbType.Int).Value = _Envio_Recepcion_Correos_Electronicos
            cms.Parameters.Add("@_Envio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line", SqlDbType.Int).Value = _Envio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line
            cms.Parameters.Add("@_Subir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales", SqlDbType.Int).Value = _Subir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales
            cms.Parameters.Add("@_Tiempo_Espera_Para_Abrir_Pagina_Favorita_Internet", SqlDbType.Int).Value = _Tiempo_Espera_Para_Abrir_Pagina_Favorita_Internet
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = strltipificacion
            cms.Connection = cn
            Datos = New SqlClient.SqlDataAdapter(cms)
            Datos.Fill(dts)
            'cms.ExecuteNonQuery()
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod") Is DBNull.Value Then
                    _Fk_Cod_CRM_Poll_Perception_Service_S_L = ""
                Else
                    _Fk_Cod_CRM_Poll_Perception_Service_S_L = dts.Tables(0).Rows(0).Item("Cod")
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub RegistroPoll_P_S_RTA_Multiple()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "Insert into Poll_P_S_RTA_Multiple (Id_Usuario,Tipo_Poll,Fk_Cod_CRM_Poll_Perception_Service_S_L,Fk_Cod_Poll_P_S_Des_Option,Fk_Id_Caso) values (@strlidusuario,@_Tipo_Poll,@_Fk_Cod_CRM_Poll_Perception_Service_S_L,@_Fk_Cod_Poll_P_S_Des_Option,@strlcaso)"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@_Tipo_Poll", SqlDbType.VarChar, 50).Value = _Tipo_Poll
            cms.Parameters.Add("@_Fk_Cod_CRM_Poll_Perception_Service_S_L", SqlDbType.Decimal).Value = _Fk_Cod_CRM_Poll_Perception_Service_S_L
            cms.Parameters.Add("@_Fk_Cod_Poll_P_S_Des_Option", SqlDbType.Int).Value = _Fk_Cod_Poll_P_S_Des_Option
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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

    Public Sub Actualizar_Bandeja_Poll()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "Update Bandeja_Poll_Perception_Service set Estado=@strltipificacion where Id_Caso = @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = strltipificacion
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


    Public Function ConsultaGrupo_Asignado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT Cod_BD_Voz_Complemento, Nombre, Pertenece FROM BD_Voz_Complemento WHERE Pertenece = '- Seleccione -'  OR Pertenece = 'Grupo_Asignado'"
            If _Validacion = "Dilo" Then
                cms.CommandText = "SELECT Cod_BD_Voz_Complemento, Nombre, Pertenece FROM BD_Voz_Complemento WHERE Pertenece = '- Seleccione -'  OR Pertenece = 'Grupo_Asignado_Dilo'"
            End If

            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function ConsultaConfiguracionRed() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from Bandeja_Configuracion_Red where id_Bandeja=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then

                If dtsrecepcion.Tables(0).Rows(0).Item("id_Bandeja") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("id_Bandeja")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Nombre_Cliente") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("Nombre_Cliente")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Min") Is System.DBNull.Value Then
                    strlmin = " "
                Else
                    strlmin = dtsrecepcion.Tables(0).Rows(0).Item("Min")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Departamento_Origen") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("Departamento_Origen")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Municipio_Origen") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("Municipio_Origen")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Linea") Is System.DBNull.Value Then
                    _Tipo_linea = " "
                Else
                    _Tipo_linea = dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Linea")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Estado_Linea") Is System.DBNull.Value Then
                    _Estado_Cliente = " "
                Else
                    _Estado_Cliente = dtsrecepcion.Tables(0).Rows(0).Item("Estado_Linea")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Resultado") Is System.DBNull.Value Then
                    _Respuesta = " "
                Else
                    _Respuesta = dtsrecepcion.Tables(0).Rows(0).Item("Resultado")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Fc_recepcion") Is System.DBNull.Value Then
                    strlfcini = " "
                Else
                    strlfcini = dtsrecepcion.Tables(0).Rows(0).Item("Fc_recepcion")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Dispositivo") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("Dispositivo")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Campaña") Is System.DBNull.Value Then
                    strlcampana = " "
                Else
                    strlcampana = dtsrecepcion.Tables(0).Rows(0).Item("Campaña")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Corporativo") Is System.DBNull.Value Then
                    _Corporativo = " "
                Else
                    _Corporativo = dtsrecepcion.Tables(0).Rows(0).Item("Corporativo")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Min_Alterno") Is System.DBNull.Value Then
                    strlNum_Intento = " "
                Else
                    strlNum_Intento = dtsrecepcion.Tables(0).Rows(0).Item("Min_Alterno")
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


    Public Sub Modificar_Bandeja_Config_Red()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            strlfcreg = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If strldpto <> Nothing Then
                strldpto = ",Departamento_Actual='" & strldpto & "'"
            Else
                strldpto = " "
            End If
            If strlmun <> Nothing Then
                strlmun = ",Municipio_Actual='" & strlmun & "'"
            Else
                strlmun = " "
            End If
            If strldir <> Nothing Then
                strldir = ",Direccion='" & strldir & "'"
            Else
                strldir = " "
            End If
            If strlbarrio <> Nothing Then
                strlbarrio = ",Barrio='" & strlbarrio & "'"
            Else
                strlbarrio = " "
            End If
            If strlequipo <> Nothing Then
                strlequipo = ",Dispositivo_Actual='" & strlequipo & "'"
            Else
                strlequipo = " "
            End If

            If _Estado_linea <> Nothing Then
                _Estado_linea = ",Estado_Linea='" & _Estado_linea & "'"
            Else
                _Estado_linea = " "
            End If
            If _Corporativo <> Nothing Then
                _Corporativo = ",Corporativo='" & _Corporativo & "'"
            Else
                _Corporativo = " "
            End If
            If _Dual <> Nothing Then
                _Dual = ",Dual_Sim='" & _Dual & "'"
            Else
                _Dual = " "
            End If
            If strlmin <> Nothing Then
                strlmin = ",Min_Alterno='" & strlmin & "'"
            Else
                strlmin = " "
            End If
            If _ICCID <> Nothing Then
                _ICCID = ",ICCID='" & _ICCID & "'"
            Else
                _ICCID = " "
            End If

            cms.CommandText = "Update Bandeja_Configuracion_Red set Resultado=@_Respuesta, Resultado_Config=@_Respuesta_Config, Fc_Contacto=@strlfcreg " & strldpto & strlmun & strldir & strlbarrio & strlequipo & _Estado_linea & _Corporativo & _Dual & strlmin & _ICCID & " where id_Bandeja=@strlcaso"
            cms.Parameters.Add("@_Respuesta", SqlDbType.VarChar, 255).Value = _Respuesta
            cms.Parameters.Add("@_Respuesta_Config", SqlDbType.VarChar, 255).Value = _Respuesta_Config
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 255).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
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


    Public Sub Insertar_CRMBandeja_Config_Red()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "INSERT INTO CRM_Configuracion_Red([Id_Bandeja],[Id_usuario],[Observacion],[Resultado],[Resultado_Config],[Fc_Programada]) VALUES(@strlcaso,@strlidusuario,@strlobs,@_Respuesta,@_Respuesta_Config,@_Fc_Programado)"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 255).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 255).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@_Respuesta", SqlDbType.VarChar, 255).Value = _Respuesta
            cms.Parameters.Add("@_Respuesta_Config", SqlDbType.VarChar, 255).Value = _Respuesta_Config


            If _Fc_Programado <> Nothing Then
                cms.Parameters.Add("@_Fc_Programado", SqlDbType.VarChar, 255).Value = _Fc_Programado
            Else
                cms.Parameters.AddWithValue("@_Fc_Programado", DBNull.Value)
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

    Public Function cargar_gestiones() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select CC.id_configuracion_red as Id,BC.id_Bandeja as Caso,CC.fc_reg as [Fecha Registro],CC.id_usuario as Usuario,CC.observacion,CC.resultado_config as Configuracion,CC.resultado from Bandeja_Configuracion_Red BC left join CRM_Configuracion_Red CC on BC.id_bandeja = CC.id_Bandeja where BC.id_Bandeja=  @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 255).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    '----------CRM Falla Red Dilo----------'
    Public Sub registrocrmfallareddilo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now

            cms.CommandText = "INSERT INTO CRMdilo(idcasodilo,fcregistro,idusuario,obs,tipificacion) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion)"
            '------Nuevo------'
            If _Validacion = "Diagnostico" Then
                cms.CommandText = "INSERT INTO Detalle_Diagnostico_Otros ([Fc_Reg],[Id_Caso],[Tipo_PQR],[Tipo_Cliente],[Modalidad],[Causa_Raiz],[Categoria_Cierre],[Bandeja],[Id_Solicitud],[Tipo_Falla],[Variable],[Tipo_PQR_Adicional],[Intension_Des_Falla],[Tipo_Proceso_Linea],[nunicipio],[Aplica_Fidelizacion]) SELECT top 1 @strlfcreg,[Id_Caso],[Tipo_PQR],[Tipo_Cliente],[Modalidad],[Causa_Raiz],@Categoria_cierre,[Bandeja],[Id_Solicitud],[Tipo_Falla],[Variable],[Tipo_PQR_Adicional],[Intension_Des_Falla],[Tipo_Proceso_Linea],[nunicipio],[Aplica_Fidelizacion] FROM Detalle_Diagnostico_Otros where id_caso = @strlcaso order by Fc_Reg desc"
                cms.Parameters.Add("@Categoria_cierre", SqlDbType.VarChar).Value = _Categoria_Cierre
            Else
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
                cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            End If

            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
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

    ''''RESOLVED DESACTIVACION''''''''
    Public Function consultaresolveddesactivacion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT campana,cpd, Estado_remedy,apn,qos,estadocpd,resolucion,solucion,N_Doc_Id,vfallared.idcaso,personacontacto,B.Min As numcontacto,tiempofalla,tipofalla,caractfalla,portada,nombredpto, nombremun,ciudad, vfallared.Direccion,barrio,tecnologia,equipo,maslineas,obscliente,fcregistro,idusuario,idusuriocpd,VFallared.fcasignado,asignado,Falla_Presenta_Luego_Construyera_Edificacion_Aledania, Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,Tipo_Edificacion_Donde_Presenta_Falla, Validaciones_Falla_Masiva, Tecnologia_Presenta_Falla_Luegodepruebas, Validacion_Coordenadas, Linea_No_Cuenta_Bloqueos_Internet, Linea_No_Superado_Limite_Consumos, Linea_No_Encuentra_Enrutada_PorPagos,HLR_HSS, No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,  Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,Forza_Red_Dispositivo, Verifica_Realiza_Configuración_APN, Equipo_Encuentra_Homologado_Operador,  Realiza_Conciliacion_Sobre_linea  from clarovoz.dbo.VFallared    LEFT OUTER JOIN datosclaro.dbo.Divipola on vfallared.munfalla = Divipola.coddiv  INNER JOIN datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V B on VFallared.idcaso=Id_Caso  where vfallared.idcaso=@strlcaso and cpd is not null"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso

            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                _N_Doc_Id = dtsrecepcion.Tables(0).Rows(0).Item("N_Doc_Id").ToString
                If dtsrecepcion.Tables(0).Rows(0).Item("estadocpd") Is System.DBNull.Value Then
                    strlestadoinc = " "
                Else
                    strlestadoinc = dtsrecepcion.Tables(0).Rows(0).Item("estadocpd")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cpd") Is System.DBNull.Value Then
                    strlcpd = " "
                Else
                    strlcpd = dtsrecepcion.Tables(0).Rows(0).Item("cpd")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Estado_remedy") Is System.DBNull.Value Then
                    _Estado_linea = " "
                Else
                    _Estado_linea = dtsrecepcion.Tables(0).Rows(0).Item("Estado_remedy")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("personacontacto") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("personacontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("numcontacto") Is System.DBNull.Value Then
                    strltelcontacto = " "
                Else
                    strltelcontacto = dtsrecepcion.Tables(0).Rows(0).Item("numcontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla") Is System.DBNull.Value Then
                    strltiempo = " "
                Else
                    strltiempo = dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipofalla") Is System.DBNull.Value Then
                    strltipofalla = " "
                Else
                    strltipofalla = dtsrecepcion.Tables(0).Rows(0).Item("tipofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("caractfalla") Is System.DBNull.Value Then
                    strlcaracter = " "
                Else
                    strlcaracter = dtsrecepcion.Tables(0).Rows(0).Item("caractfalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("portada") Is System.DBNull.Value Then
                    strlportada = " "
                Else
                    strlportada = dtsrecepcion.Tables(0).Rows(0).Item("portada")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombredpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("nombredpto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombremun") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("nombremun")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("ciudad") Is System.DBNull.Value Then
                    strlvereda = " "
                Else
                    strlvereda = dtsrecepcion.Tables(0).Rows(0).Item("ciudad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("direccion") Is System.DBNull.Value Then
                    strldir = " "
                Else
                    strldir = dtsrecepcion.Tables(0).Rows(0).Item("direccion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dtsrecepcion.Tables(0).Rows(0).Item("barrio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tecnologia") Is System.DBNull.Value Then
                    strltecnologia = " "
                Else
                    strltecnologia = dtsrecepcion.Tables(0).Rows(0).Item("tecnologia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("equipo") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("equipo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("maslineas") Is System.DBNull.Value Then
                    strlmaslineas = " "
                Else
                    strlmaslineas = dtsrecepcion.Tables(0).Rows(0).Item("maslineas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("obscliente") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obscliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("resolucion") Is System.DBNull.Value Then
                    strlresolucion = " "
                Else
                    strlresolucion = dtsrecepcion.Tables(0).Rows(0).Item("resolucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("solucion") Is System.DBNull.Value Then
                    strlsolucion = " "
                Else
                    strlsolucion = dtsrecepcion.Tables(0).Rows(0).Item("solucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("campana") Is System.DBNull.Value Then
                    strlcampana = " "
                Else
                    strlcampana = dtsrecepcion.Tables(0).Rows(0).Item("campana")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apn") Is System.DBNull.Value Then
                    strlapn = " "
                Else
                    strlapn = dtsrecepcion.Tables(0).Rows(0).Item("apn")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("qos") Is System.DBNull.Value Then
                    strlqos = " "
                Else
                    strlqos = dtsrecepcion.Tables(0).Rows(0).Item("qos")
                End If

                ''''Validaciones servicio al cliente
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = " "
                Else
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = " "
                Else
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla") Is System.DBNull.Value Then
                    _Tipo_Edificacion_Donde_Presenta_Falla = " "
                Else
                    _Tipo_Edificacion_Donde_Presenta_Falla = dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva") Is System.DBNull.Value Then
                    _Validaciones_Falla_Masiva = " "
                Else
                    _Validaciones_Falla_Masiva = dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas") Is System.DBNull.Value Then
                    _Tecnologia_Presenta_Falla_Luegodepruebas = " "
                Else
                    _Tecnologia_Presenta_Falla_Luegodepruebas = dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas") Is System.DBNull.Value Then
                    _Validacion_Coordenadas = " "
                Else
                    _Validacion_Coordenadas = dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet") Is System.DBNull.Value Then
                    _Linea_No_Cuenta_Bloqueos_Internet = " "
                Else
                    _Linea_No_Cuenta_Bloqueos_Internet = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos") Is System.DBNull.Value Then
                    _Linea_No_Superado_Limite_Consumos = " "
                Else
                    _Linea_No_Superado_Limite_Consumos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos") Is System.DBNull.Value Then
                    _Linea_No_Encuentra_Enrutada_PorPagos = " "
                Else
                    _Linea_No_Encuentra_Enrutada_PorPagos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS") Is System.DBNull.Value Then
                    _HLR_HSS = " "
                Else
                    _HLR_HSS = dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra") Is System.DBNull.Value Then
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = " "
                Else
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla") Is System.DBNull.Value Then
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = " "
                Else
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo") Is System.DBNull.Value Then
                    _Forza_Red_Dispositivo = " "
                Else
                    _Forza_Red_Dispositivo = dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN") Is System.DBNull.Value Then
                    _Verifica_Realiza_Configuración_APN = " "
                Else
                    _Verifica_Realiza_Configuración_APN = dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador") Is System.DBNull.Value Then
                    _Equipo_Encuentra_Homologado_Operador = " "
                Else
                    _Equipo_Encuentra_Homologado_Operador = dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea") Is System.DBNull.Value Then
                    _Realiza_Conciliacion_Sobre_linea = " "
                Else
                    _Realiza_Conciliacion_Sobre_linea = dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea")
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

    Public Sub registrocrmfallaredFideiza()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO crm_falla_desactivacion_D_V (Fk_Id_Bandeja,Fc_Reg_Ges,Id_Usuario,obs,tipificacion,Falla_Red,Equipo,Segmentacion_Linea,Correo_Electronico) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,'Si','Cierre Falla red','Cierre Falla red','Cierre Falla red')"
            If _Validacion = "Gestion_De_Resolved_SD" Then
                cms.CommandText = "INSERT INTO crm_falla_desactivacion_D_V (Fk_Id_Bandeja,Fc_Reg_Ges,Id_Usuario,obs,tipificacion,Falla_Red,Equipo,Segmentacion_Linea,Correo_Electronico) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,'SD','Cierre SD','Cierre SD','Cierre SD')"
            End If
            If _Validacion = "Diagnostico" Then
                cms.CommandText = "INSERT INTO Detalle_Diagnostico_Otros ([Fc_Reg],[Id_Caso],[Tipo_PQR],[Tipo_Cliente],[Modalidad],[Causa_Raiz],[Categoria_Cierre],[Bandeja],[Id_Solicitud],[Tipo_Falla],[Variable],[Tipo_PQR_Adicional],[Intension_Des_Falla],[Tipo_Proceso_Linea],[nunicipio],[Aplica_Fidelizacion]) SELECT top 1 @strlfcreg,[Id_Caso],[Tipo_PQR],[Tipo_Cliente],[Modalidad],[Causa_Raiz],@Categoria_cierre,[Bandeja],[Id_Solicitud],[Tipo_Falla],[Variable],[Tipo_PQR_Adicional],[Intension_Des_Falla],[Tipo_Proceso_Linea],[nunicipio],[Aplica_Fidelizacion] FROM Detalle_Diagnostico_Otros where id_caso = @strlcaso order by Fc_Reg desc"
                cms.Parameters.Add("@Categoria_cierre", SqlDbType.VarChar).Value = _Categoria_Cierre
            Else
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
                cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg

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

    Public Sub modificarbandejafallaDilo()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE Bandeja_alt SET estado=@strltipificacion WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
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

    Public Sub modificarbandejafallaFideliza()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE Bandeja_falla_desactivacion_D_V SET estado=@strltipificacion WHERE id_Caso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
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

    Public Sub Modificar_Bandejas_Estado_Escalado()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Validacion = "DILO" Then
                cms.CommandText = "UPDATE datosclaro.dbo.Bandeja_alt SET estado='" & Nombre & "' WHERE idcaso= @strlcaso"
            End If
            If _Validacion = "DATOS" Or Validacion = "BSCS" Then
                cms.CommandText = "UPDATE datosclaro.dbo.bandeja SET estado='" & Nombre & "' WHERE cas_id= @strlcaso"
            End If
            If _Validacion = "FALLA DES" Then
                cms.CommandText = "UPDATE datosclaro.dbo.Bandeja_falla_desactivacion_D_V SET estado='" & Nombre & "' WHERE id_Caso= @strlcaso"
            End If
            If _Validacion = "VOZ" Then
                cms.CommandText = "UPDATE clarovoz.dbo.bandeja_uni SET estado='" & Nombre & "' WHERE idcaso= @strlcaso"
            End If
            If _Validacion = "INBOUND" Then
                cms.CommandText = "UPDATE datosclaro.dbo.bandeja_inbound SET estado='" & Nombre & "' WHERE id_caso= @strlcaso"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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



    Public Function consultacasodilo() As DataTable
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataTable
        Try
            cn.Open()
            cms.CommandText = "select caso,min from datosclaro.dbo.Bandeja_alt B inner join clarovoz.dbo.VFallared V on B.idcaso=V.idcaso where B.idcaso = @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 255).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Rows.Count
            If strlcantidad > 0 Then
                If dts.Rows(0).Item("min") Is System.DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dts.Rows(0).Item("min")
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

    Public Sub ActualizarFallaRed()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If Validacion = "VFALLA" Then
                cms.CommandText = "UPDATE clarovoz.dbo.Vfallared SET munfalla=(select coddiv from datosclaro.dbo.divipola where nombremun=@mun and nombredpto=@strldpto),barrio=@barrio,direccion=@dir,ciudad=@vereda WHERE idcaso= @strlcaso"
                cms.Parameters.Add("@barrio", SqlDbType.NVarChar).Value = strlbarrio
                cms.Parameters.Add("@dir", SqlDbType.NVarChar).Value = strldir
                cms.Parameters.Add("@vereda", SqlDbType.NVarChar).Value = strlvereda
            Else
                If Validacion = "DATOS" Or Validacion = "BSCS" Then
                    cms.CommandText = "UPDATE datosclaro.dbo.detalle_diagnostico SET Barrio=@barrio, nunicipio=(select coddiv from datosclaro.dbo.divipola where nombremun=@mun and nombredpto=@strldpto) WHERE idcaso= @strlcaso and (nunicipio <> 0 and nunicipio is not null)"
                    cms.Parameters.Add("@barrio", SqlDbType.NVarChar).Value = strlbarrio
                End If
                If Validacion = "FALLA DES" Or Validacion = "DILO" Then
                    cms.CommandText = "UPDATE datosclaro.dbo.detalle_diagnostico_otros SET nunicipio=(select coddiv from datosclaro.dbo.divipola where nombremun=@mun and nombredpto=@strldpto ) WHERE id_Caso= @strlcaso and (nunicipio <> 0 and nunicipio is not null)"
                End If
            End If

            cms.Parameters.Add("@mun", SqlDbType.NVarChar).Value = strlmun
            cms.Parameters.Add("@strldpto", SqlDbType.NVarChar).Value = strldpto
            cms.Parameters.Add("@strlcaso", SqlDbType.NVarChar).Value = strlcaso
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

    Public Sub Actualizar_Estado_Vfallared()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand

        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE clarovoz.dbo.Vfallared SET Estado_remedy=@_Estado_linea,Fc_CierreRemedy=@fc,Usuario_Remedy=@usuario WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.NVarChar).Value = strlcaso
            cms.Parameters.Add("@_Estado_linea", SqlDbType.NVarChar).Value = _Estado_linea
            cms.Parameters.Add("@fc", SqlDbType.NVarChar).Value = fcfin
            cms.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = idusuario
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




    '--------------------------------------------INBOUND------------------------------------------------------'
    Public Sub registrofallasred_inbound()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            If strlfcreg = Nothing Then
                strlfcreg = Now
            End If
            cms.CommandText = "INSERT INTO VFallared(N_Doc_Id,idcaso,personacontacto,numcontacto,tiempofalla,tipofalla,caractfalla,portada,munfalla,ciudad,direccion,barrio,tecnologia,equipo,maslineas,obscliente,fcregistro,idusuario,campana,apn,qos,fc_ingreso,Falla_Presenta_Luego_Construyera_Edificacion_Aledania,Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,Tipo_Edificacion_Donde_Presenta_Falla,Validaciones_Falla_Masiva,Tecnologia_Presenta_Falla_Luegodepruebas,Validacion_Coordenadas,Linea_No_Cuenta_Bloqueos_Internet,Linea_No_Superado_Limite_Consumos,Linea_No_Encuentra_Enrutada_PorPagos,HLR_HSS,No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,Forza_Red_Dispositivo,Verifica_Realiza_Configuración_APN,Equipo_Encuentra_Homologado_Operador,Realiza_Conciliacion_Sobre_linea)values(@_N_Doc_Id,@strlcaso,@strlcliente,@strltelcontacto,@strltiempo,@strltipofalla,@strlcaracter,@strlportada,@strlmun,@strlvereda,@strldir,@strlbarrio,@strltecnologia,@strlequipo,@strlmaslineas,@strlobs,@strlfcreg,@strlidusuario,@strlcampana,@strlapn,@strlqos,@strlfcini,@_Falla_Presenta_Luego_Construyera_Edificacion_Aledania,@_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,@_Tipo_Edificacion_Donde_Presenta_Falla,@_Validaciones_Falla_Masiva,@_Tecnologia_Presenta_Falla_Luegodepruebas,@_Validacion_Coordenadas,@_Linea_No_Cuenta_Bloqueos_Internet,@_Linea_No_Superado_Limite_Consumos,@_Linea_No_Encuentra_Enrutada_PorPagos,@_HLR_HSS,@_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,@_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,@_Forza_Red_Dispositivo,@_Verifica_Realiza_Configuración_APN,@_Equipo_Encuentra_Homologado_Operador,@_Realiza_Conciliacion_Sobre_linea)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlcliente", SqlDbType.NVarChar, 255).Value = strlcliente
            cms.Parameters.Add("@strltelcontacto", SqlDbType.NVarChar, 20).Value = strltelcontacto
            cms.Parameters.Add("@strltiempo", SqlDbType.NVarChar, 20).Value = strltiempo
            cms.Parameters.Add("@strltipofalla", SqlDbType.NVarChar, 255).Value = strltipofalla
            cms.Parameters.Add("@strlcaracter", SqlDbType.VarChar).Value = strlcaracter
            cms.Parameters.Add("@strlportada", SqlDbType.VarChar, 50).Value = strlportada
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 20).Value = strlmun
            cms.Parameters.Add("@strlvereda", SqlDbType.NVarChar, 255).Value = strlvereda
            cms.Parameters.Add("@strldir", SqlDbType.NVarChar, 255).Value = strldir
            cms.Parameters.Add("@strlbarrio", SqlDbType.NVarChar, 255).Value = strlbarrio
            cms.Parameters.Add("@strltecnologia", SqlDbType.NVarChar, 50).Value = strltecnologia
            cms.Parameters.Add("@strlequipo", SqlDbType.NVarChar, 100).Value = strlequipo
            cms.Parameters.Add("@strlmaslineas", SqlDbType.NVarChar, 20).Value = strlmaslineas
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlcampana", SqlDbType.VarChar, 50).Value = strlcampana
            cms.Parameters.Add("@strlapn", SqlDbType.VarChar, 50).Value = strlapn
            cms.Parameters.Add("@strlqos", SqlDbType.VarChar, 50).Value = strlqos
            cms.Parameters.Add("@strlfcini", SqlDbType.DateTime).Value = strlfcini
            cms.Parameters.AddWithValue("@_N_Doc_Id", _N_Doc_Id)
            If _Falla_Presenta_Luego_Construyera_Edificacion_Aledania <> Nothing Then
                cms.Parameters.Add("@_Falla_Presenta_Luego_Construyera_Edificacion_Aledania", SqlDbType.VarChar, 10).Value = _Falla_Presenta_Luego_Construyera_Edificacion_Aledania
            Else
                cms.Parameters.AddWithValue("@_Falla_Presenta_Luego_Construyera_Edificacion_Aledania", DBNull.Value)
            End If
            If _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio <> Nothing Then
                cms.Parameters.Add("@_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio", SqlDbType.VarChar, 10).Value = _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio
            Else
                cms.Parameters.AddWithValue("@_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio", DBNull.Value)
            End If
            If _Tipo_Edificacion_Donde_Presenta_Falla <> Nothing Then
                cms.Parameters.Add("@_Tipo_Edificacion_Donde_Presenta_Falla", SqlDbType.VarChar, 50).Value = _Tipo_Edificacion_Donde_Presenta_Falla
            Else
                cms.Parameters.AddWithValue("@_Tipo_Edificacion_Donde_Presenta_Falla", DBNull.Value)
            End If
            If _Validaciones_Falla_Masiva <> Nothing Then
                cms.Parameters.Add("@_Validaciones_Falla_Masiva", SqlDbType.VarChar, 10).Value = _Validaciones_Falla_Masiva
            Else
                cms.Parameters.AddWithValue("@_Validaciones_Falla_Masiva", DBNull.Value)
            End If
            If _Tecnologia_Presenta_Falla_Luegodepruebas <> Nothing Then
                cms.Parameters.Add("@_Tecnologia_Presenta_Falla_Luegodepruebas", SqlDbType.VarChar, 50).Value = _Tecnologia_Presenta_Falla_Luegodepruebas
            Else
                cms.Parameters.AddWithValue("@_Tecnologia_Presenta_Falla_Luegodepruebas", DBNull.Value)
            End If
            If _Validacion_Coordenadas <> Nothing Then
                cms.Parameters.Add("@_Validacion_Coordenadas", SqlDbType.VarChar, 20).Value = _Validacion_Coordenadas
            Else
                cms.Parameters.AddWithValue("@_Validacion_Coordenadas", DBNull.Value)
            End If
            If _Linea_No_Cuenta_Bloqueos_Internet <> Nothing Then
                cms.Parameters.Add("@_Linea_No_Cuenta_Bloqueos_Internet", SqlDbType.VarChar, 10).Value = _Linea_No_Cuenta_Bloqueos_Internet
            Else
                cms.Parameters.AddWithValue("@_Linea_No_Cuenta_Bloqueos_Internet", DBNull.Value)
            End If
            If _Linea_No_Superado_Limite_Consumos <> Nothing Then
                cms.Parameters.Add("@_Linea_No_Superado_Limite_Consumos", SqlDbType.VarChar, 10).Value = _Linea_No_Superado_Limite_Consumos
            Else
                cms.Parameters.AddWithValue("@_Linea_No_Superado_Limite_Consumos", DBNull.Value)
            End If
            If _Linea_No_Encuentra_Enrutada_PorPagos <> Nothing Then
                cms.Parameters.Add("@_Linea_No_Encuentra_Enrutada_PorPagos", SqlDbType.VarChar, 10).Value = _Linea_No_Encuentra_Enrutada_PorPagos
            Else
                cms.Parameters.AddWithValue("@_Linea_No_Encuentra_Enrutada_PorPagos", DBNull.Value)
            End If
            If _HLR_HSS <> Nothing Then
                cms.Parameters.Add("@_HLR_HSS", SqlDbType.VarChar, 50).Value = _HLR_HSS
            Else
                cms.Parameters.AddWithValue("@_HLR_HSS", DBNull.Value)
            End If
            If _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra <> Nothing Then
                cms.Parameters.Add("@_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra", SqlDbType.VarChar, 100).Value = _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra
            Else
                cms.Parameters.AddWithValue("@_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra", DBNull.Value)
            End If
            If _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla <> Nothing Then
                cms.Parameters.Add("@_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla", SqlDbType.VarChar, 10).Value = _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla
            Else
                cms.Parameters.AddWithValue("@_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla", DBNull.Value)
            End If
            If _Forza_Red_Dispositivo <> Nothing Then
                cms.Parameters.Add("@_Forza_Red_Dispositivo", SqlDbType.VarChar, 50).Value = _Forza_Red_Dispositivo
            Else
                cms.Parameters.AddWithValue("@_Forza_Red_Dispositivo", DBNull.Value)
            End If
            If _Verifica_Realiza_Configuración_APN <> Nothing Then
                cms.Parameters.Add("@_Verifica_Realiza_Configuración_APN", SqlDbType.VarChar, 50).Value = _Verifica_Realiza_Configuración_APN
            Else
                cms.Parameters.AddWithValue("@_Verifica_Realiza_Configuración_APN", DBNull.Value)
            End If
            If _Equipo_Encuentra_Homologado_Operador <> Nothing Then
                cms.Parameters.Add("@_Equipo_Encuentra_Homologado_Operador", SqlDbType.VarChar, 10).Value = _Equipo_Encuentra_Homologado_Operador
            Else
                cms.Parameters.AddWithValue("@_Equipo_Encuentra_Homologado_Operador", DBNull.Value)
            End If
            If _Realiza_Conciliacion_Sobre_linea <> Nothing Then
                cms.Parameters.Add("@_Realiza_Conciliacion_Sobre_linea", SqlDbType.VarChar, 10).Value = _Realiza_Conciliacion_Sobre_linea
            Else
                cms.Parameters.AddWithValue("@_Realiza_Conciliacion_Sobre_linea", DBNull.Value)
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

    Public Function Consultacaso_Inb() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM Bandeja_inbound WHERE Id_caso=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("min") Is System.DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dtsrecepcion.Tables(0).Rows(0).Item("min")
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

    Public Function Asignar_Caso()
        Dim Con As New SqlClient.SqlConnection 'conexión a la base de datos
        Try
            Dim Scm As New SqlClient.SqlCommand
            Con = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) 'Conexión directa con la creada en Web.config
            Con.Open()
            strlfcreg = Now
            Scm.CommandText = "UPDATE VFallared SET asignado='-1', idusuriocpd=@_Id_Agent, fcasignado=@_fecha, Usuario_Asigna=@_Id_Usuario WHERE idcaso= @_Id_Caso"
            Scm.Parameters.Add("@_Id_Caso", SqlDbType.Decimal).Value = strlcaso
            Scm.Parameters.Add("@_Id_Agent", SqlDbType.VarChar, 50).Value = strlidusuarioasignado
            Scm.Parameters.Add("@_fecha", SqlDbType.VarChar, 50).Value = strlfcreg
            Scm.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = strlidusuario
            Scm.Connection = Con
            Return Scm.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function

 

    Public Function Consultar_Casos_Sin_Asignar() As DataSet
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base
        Try
            Dim Dts As New DataSet
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Scm As New SqlClient.SqlCommand
            Dim Sql_Frag_Where As String = Nothing
            Dim Sql_Frag_Top As String = Nothing
            If strlfcini <> Nothing Then
                Scm.Parameters.AddWithValue("@_Fecha_Ini", strlfcini)
                Sql_Frag_Where = " And convert(date, fcregistro ) >= @_Fecha_Ini "
            End If
            If strlfcfin <> Nothing Then
                Scm.Parameters.AddWithValue("@_Fecha_Fin", strlfcfin)
                Sql_Frag_Where = Sql_Frag_Where & " And convert(date, fcregistro ) <= @_Fecha_Fin "
            End If
            If strlcampana <> Nothing Then
                Scm.Parameters.AddWithValue("@_Camp", strlcampana)
                Sql_Frag_Where = Sql_Frag_Where & "And campana Like @_Camp"
            End If
            If strlcantidad <> Nothing Then
                Scm.Parameters.Add("@_Top", SqlDbType.Int).Value = strlcantidad
                Sql_Frag_Top = " Top(@_Top) "
            End If
            Con.Open()
            Scm.CommandText = "select " & Sql_Frag_Top & " * from clarovoz.dbo.VFallared VF inner join datosclaro.dbo.Usuarios U on VF.idusuario = U.idusuario  where  fcregistro>='01/08/2016' and  asignado is null " & Sql_Frag_Where & " order by fc_ingreso asc "
            Scm.Connection = Con
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            Scm.Parameters.Clear()
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    
    Public Function Consultar_Agentes_En_Escalamiento()
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim Dts As New DataSet
        Dim Sda As SqlClient.SqlDataAdapter
        Dim Scm As New SqlClient.SqlCommand
        Try
            Con.Open()
            Scm.CommandText = "SELECT idusuriocpd, COUNT(idcaso) AS casos FROM VFallared WHERE cpd IS NULL AND asignado = '-1' GROUP BY idusuriocpd"
            Scm.Connection = Con
            Sda = New SqlClient.SqlDataAdapter(Scm)
            Sda.Fill(Dts)
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function

    Public Function Consulta_Resolved_Inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT campana,cpd, Estado_remedy,apn,qos,estadocpd,resolucion,solucion,vfallared.idcaso,personacontacto,N_Doc_Id,B.Min As numcontacto,tiempofalla,tipofalla,caractfalla,portada,nombredpto, nombremun,ciudad, vfallared.Direccion,barrio,tecnologia,equipo,maslineas,obscliente,fcregistro,idusuario,idusuriocpd,VFallared.fcasignado,asignado,Falla_Presenta_Luego_Construyera_Edificacion_Aledania, Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio,Tipo_Edificacion_Donde_Presenta_Falla, Validaciones_Falla_Masiva, Tecnologia_Presenta_Falla_Luegodepruebas, Validacion_Coordenadas, Linea_No_Cuenta_Bloqueos_Internet, Linea_No_Superado_Limite_Consumos, Linea_No_Encuentra_Enrutada_PorPagos,HLR_HSS, No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra,  Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla,Forza_Red_Dispositivo, Verifica_Realiza_Configuración_APN, Equipo_Encuentra_Homologado_Operador,  Realiza_Conciliacion_Sobre_linea  from clarovoz.dbo.VFallared    LEFT OUTER JOIN datosclaro.dbo.Divipola on vfallared.munfalla = Divipola.coddiv  INNER JOIN datosclaro.dbo.Bandeja_inbound B on VFallared.idcaso=Id_Caso  where vfallared.idcaso=@strlcaso and cpd is not null"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso

            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                _N_Doc_Id = dtsrecepcion.Tables(0).Rows(0).Item("N_Doc_Id").ToString
                If dtsrecepcion.Tables(0).Rows(0).Item("estadocpd") Is System.DBNull.Value Then
                    strlestadoinc = " "
                Else
                    strlestadoinc = dtsrecepcion.Tables(0).Rows(0).Item("estadocpd")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("cpd") Is System.DBNull.Value Then
                    strlcpd = " "
                Else
                    strlcpd = dtsrecepcion.Tables(0).Rows(0).Item("cpd")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Estado_remedy") Is System.DBNull.Value Then
                    _Estado_linea = " "
                Else
                    _Estado_linea = dtsrecepcion.Tables(0).Rows(0).Item("Estado_remedy")
                End If


                If dtsrecepcion.Tables(0).Rows(0).Item("personacontacto") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("personacontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("numcontacto") Is System.DBNull.Value Then
                    strltelcontacto = " "
                Else
                    strltelcontacto = dtsrecepcion.Tables(0).Rows(0).Item("numcontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla") Is System.DBNull.Value Then
                    strltiempo = " "
                Else
                    strltiempo = dtsrecepcion.Tables(0).Rows(0).Item("tiempofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipofalla") Is System.DBNull.Value Then
                    strltipofalla = " "
                Else
                    strltipofalla = dtsrecepcion.Tables(0).Rows(0).Item("tipofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("caractfalla") Is System.DBNull.Value Then
                    strlcaracter = " "
                Else
                    strlcaracter = dtsrecepcion.Tables(0).Rows(0).Item("caractfalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("portada") Is System.DBNull.Value Then
                    strlportada = " "
                Else
                    strlportada = dtsrecepcion.Tables(0).Rows(0).Item("portada")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombredpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("nombredpto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombremun") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("nombremun")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("ciudad") Is System.DBNull.Value Then
                    strlvereda = " "
                Else
                    strlvereda = dtsrecepcion.Tables(0).Rows(0).Item("ciudad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("direccion") Is System.DBNull.Value Then
                    strldir = " "
                Else
                    strldir = dtsrecepcion.Tables(0).Rows(0).Item("direccion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dtsrecepcion.Tables(0).Rows(0).Item("barrio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tecnologia") Is System.DBNull.Value Then
                    strltecnologia = " "
                Else
                    strltecnologia = dtsrecepcion.Tables(0).Rows(0).Item("tecnologia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("equipo") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("equipo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("maslineas") Is System.DBNull.Value Then
                    strlmaslineas = " "
                Else
                    strlmaslineas = dtsrecepcion.Tables(0).Rows(0).Item("maslineas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("obscliente") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obscliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("resolucion") Is System.DBNull.Value Then
                    strlresolucion = " "
                Else
                    strlresolucion = dtsrecepcion.Tables(0).Rows(0).Item("resolucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("solucion") Is System.DBNull.Value Then
                    strlsolucion = " "
                Else
                    strlsolucion = dtsrecepcion.Tables(0).Rows(0).Item("solucion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("campana") Is System.DBNull.Value Then
                    strlcampana = " "
                Else
                    strlcampana = dtsrecepcion.Tables(0).Rows(0).Item("campana")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("apn") Is System.DBNull.Value Then
                    strlapn = " "
                Else
                    strlapn = dtsrecepcion.Tables(0).Rows(0).Item("apn")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("qos") Is System.DBNull.Value Then
                    strlqos = " "
                Else
                    strlqos = dtsrecepcion.Tables(0).Rows(0).Item("qos")
                End If

                ''''Validaciones servicio al cliente
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = " "
                Else
                    _Falla_Presenta_Luego_Construyera_Edificacion_Aledania = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Construyera_Edificacion_Aledania")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio") Is System.DBNull.Value Then
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = " "
                Else
                    _Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio = dtsrecepcion.Tables(0).Rows(0).Item("Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla") Is System.DBNull.Value Then
                    _Tipo_Edificacion_Donde_Presenta_Falla = " "
                Else
                    _Tipo_Edificacion_Donde_Presenta_Falla = dtsrecepcion.Tables(0).Rows(0).Item("Tipo_Edificacion_Donde_Presenta_Falla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva") Is System.DBNull.Value Then
                    _Validaciones_Falla_Masiva = " "
                Else
                    _Validaciones_Falla_Masiva = dtsrecepcion.Tables(0).Rows(0).Item("Validaciones_Falla_Masiva")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas") Is System.DBNull.Value Then
                    _Tecnologia_Presenta_Falla_Luegodepruebas = " "
                Else
                    _Tecnologia_Presenta_Falla_Luegodepruebas = dtsrecepcion.Tables(0).Rows(0).Item("Tecnologia_Presenta_Falla_Luegodepruebas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas") Is System.DBNull.Value Then
                    _Validacion_Coordenadas = " "
                Else
                    _Validacion_Coordenadas = dtsrecepcion.Tables(0).Rows(0).Item("Validacion_Coordenadas")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet") Is System.DBNull.Value Then
                    _Linea_No_Cuenta_Bloqueos_Internet = " "
                Else
                    _Linea_No_Cuenta_Bloqueos_Internet = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Cuenta_Bloqueos_Internet")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos") Is System.DBNull.Value Then
                    _Linea_No_Superado_Limite_Consumos = " "
                Else
                    _Linea_No_Superado_Limite_Consumos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Superado_Limite_Consumos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos") Is System.DBNull.Value Then
                    _Linea_No_Encuentra_Enrutada_PorPagos = " "
                Else
                    _Linea_No_Encuentra_Enrutada_PorPagos = dtsrecepcion.Tables(0).Rows(0).Item("Linea_No_Encuentra_Enrutada_PorPagos")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS") Is System.DBNull.Value Then
                    _HLR_HSS = " "
                Else
                    _HLR_HSS = dtsrecepcion.Tables(0).Rows(0).Item("HLR_HSS")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra") Is System.DBNull.Value Then
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = " "
                Else
                    _No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra = dtsrecepcion.Tables(0).Rows(0).Item("No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla") Is System.DBNull.Value Then
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = " "
                Else
                    _Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla = dtsrecepcion.Tables(0).Rows(0).Item("Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo") Is System.DBNull.Value Then
                    _Forza_Red_Dispositivo = " "
                Else
                    _Forza_Red_Dispositivo = dtsrecepcion.Tables(0).Rows(0).Item("Forza_Red_Dispositivo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN") Is System.DBNull.Value Then
                    _Verifica_Realiza_Configuración_APN = " "
                Else
                    _Verifica_Realiza_Configuración_APN = dtsrecepcion.Tables(0).Rows(0).Item("Verifica_Realiza_Configuración_APN")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador") Is System.DBNull.Value Then
                    _Equipo_Encuentra_Homologado_Operador = " "
                Else
                    _Equipo_Encuentra_Homologado_Operador = dtsrecepcion.Tables(0).Rows(0).Item("Equipo_Encuentra_Homologado_Operador")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea") Is System.DBNull.Value Then
                    _Realiza_Conciliacion_Sobre_linea = " "
                Else
                    _Realiza_Conciliacion_Sobre_linea = dtsrecepcion.Tables(0).Rows(0).Item("Realiza_Conciliacion_Sobre_linea")
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

    Public Function Consulta_Resolved_Inbound_SD() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT SD.idcaso, SD.tickler,B.Campaña,SD.estado,RES.Respuesta  from datosclaro.dbo.ServiceDetalle  SD INNER JOIN (SELECT cas_id, 'DATOS' As Campaña FROM datosclaro.dbo.Bandeja UNION SELECT idcaso, 'DILO' As Campaña FROM datosclaro.dbo.Bandeja_alt UNION SELECT Id_Caso, 'FALLA DES' As Campaña FROM datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V UNION SELECT Id_Caso, 'INBOUND' As Campaña FROM datosclaro.dbo.Bandeja_inbound) B ON B.cas_id = SD.idcaso LEFT JOIN clarovoz.dbo.SD_Con_Respuesta RES ON RES.Caso = SD.idcaso where idcaso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("idcaso") Is System.DBNull.Value Then
                    strlcaso = ""
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("idcaso")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tickler") Is System.DBNull.Value Then
                    strltickler = ""
                Else
                    strltickler = dtsrecepcion.Tables(0).Rows(0).Item("tickler")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Campaña") Is System.DBNull.Value Then
                    strlcampana = ""
                Else
                    strlcampana = dtsrecepcion.Tables(0).Rows(0).Item("Campaña")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Respuesta") Is System.DBNull.Value Then
                    strlresolucion = ""
                Else
                    strlresolucion = dtsrecepcion.Tables(0).Rows(0).Item("Respuesta")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strlestadoinc = ""
                Else
                    strlestadoinc = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                End If
            Else
                strlcaso = ""
                strltickler = ""
                strlcampana = ""
                strlresolucion = ""
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

    Public Function CategoriacierreCPD_inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet

        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT tipificacion1,cod_tipificacion FROM Tipificaciones2 WHERE tipificacion2 = '1' and pertenece='Categoria cierre' union select '- Seleccione -',0"
            If Validacion = "Service" Then
                cms.CommandText = "SELECT tipificacion1,cod_tipificacion FROM Tipificaciones2 WHERE tipificacion2 = '2' and pertenece='Categoria cierre' union select '- Seleccione -',0"
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

    Public Sub registro_CRM_inbound_escalamiento()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            If Validacion = "Diagnostico" Then
                cms.CommandText = "INSERT INTO CRM_inbound(Fk_Id_caso,Id_usuario,Obs,Tipificacion,Numero_alterno ,escalamiento,Fec_programado,PQR,Tecnologia,Error_registro,Municipio,Barrio,fec_ult_caida,franja_utl_caida,Id_servicio,Id_solicitud,Equipo,Tipo_PQR,Modalidad,Causa_raiz,Categoria_cierre,Inconsistencia_611) select top 1 Fk_Id_caso,@strlidusuario,@strlobs,@strltipificacion,Numero_alterno ,escalamiento,Fec_programado,PQR,Tecnologia,Error_registro,Municipio,Barrio,fec_ult_caida,franja_utl_caida,Id_servicio,Id_solicitud,Equipo,Tipo_PQR,Modalidad,Causa_raiz,@_Categoria_Cierre,Inconsistencia_611 from CRM_inbound WHERE Fk_Id_caso = @strlcaso And Tipificacion like '%Solicitud%' ORDER BY id_crm DESC"
                cms.Parameters.Add("@_Categoria_Cierre", SqlDbType.VarChar).Value = _Categoria_Cierre
            Else
                cms.CommandText = "INSERT INTO CRM_inbound (Fk_Id_caso,Id_usuario,Obs,Tipificacion,escalamiento) VALUES(@strlcaso,@strlidusuario,@strlobs,@strltipificacion,@strlpreg2)"
                cms.Parameters.Add("@strlpreg2", SqlDbType.VarChar).Value = strlpreg2
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar).Value = strltipificacion
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

    Public Function Asignar_Caso_Devuelto()
        Dim Con As New SqlClient.SqlConnection 'conexión a la base de datos
        Try
            Con = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) 'Conexión directa con la creada en Web.config
            Dim Scm As New SqlClient.SqlCommand
            Con.Open()
            Dim Fecha As String = Now
            Scm.Parameters.AddWithValue("@_Id_Caso", strlcaso)
            Scm.Parameters.AddWithValue("@_Id_Agente", strlidusuarioasignado)
            Scm.Parameters.AddWithValue("@_fecha", Fecha)
            Scm.Parameters.AddWithValue("@_Id_Usuario", strlidusuario)
            Scm.CommandText = "Declare @_Val smallint Begin Update datosclaro.dbo.Bandeja set correo_electronico = @_Id_Agente, st_bb_call= @_fecha, idusuarioasigna = @_Id_Usuario Where cas_id = @_Id_Caso; Set @_Val = @@rowcount If @_Val <= 0 Begin UPDATE datosclaro.dbo.Bandeja_alt SET Usuario_Asignado = @_Id_Agente, Fc_Asignado = @_fecha, usuario_designa=@_Id_Usuario WHERE idcaso = @_Id_Caso; Set @_Val = @@rowcount If @_Val <= 0 Begin UPDATE datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V SET Usuario_Asignado = @_Id_Agente, Fc_Asignado = @_fecha, usuario_designa=@_Id_Usuario WHERE Id_Caso = @_Id_Caso; Set @_Val = @@rowcount; End End End IF @_Val >= 1 Update clarovoz.dbo.VFallared Set devuelto = 0 Where idcaso = @_Id_Caso And (select count(Id_caso) From datosclaro.dbo.Bandeja_inbound where Id_caso = @_Id_Caso) <= 0; "
            Scm.Connection = Con
            Dim X = Scm.ExecuteNonQuery()
            Scm.Parameters.Clear()
            Return X
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Consultar_Casos_Tecnica_Devueltos()
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base
        Try
            Dim Dts As New DataSet
            Dim Scm As New SqlClient.SqlCommand
            Dim Sql_Frag_Where As String = Nothing
            Dim Sql_Frag_Top As String = Nothing
            If strlcaso <> Nothing Then
                Scm.Parameters.AddWithValue("@_Id_Caso", strlcaso)
                Sql_Frag_Where = Sql_Frag_Where & "And V.idcaso = @_Id_Caso "
            Else
                If strlcampana <> Nothing Then
                    Scm.Parameters.AddWithValue("@_Camp", strlcampana)
                    Sql_Frag_Where = Sql_Frag_Where & "And V.campana Like @_Camp"
                End If
                If strlfcini <> Nothing Then
                    Scm.Parameters.AddWithValue("@_Fecha_Ini", strlfcini)
                    Sql_Frag_Where = Sql_Frag_Where & " And Convert(Date,SUBSTRING(((v.fcregcpd)),1,19)) >= @_Fecha_Ini "
                End If
                If strlfcfin <> Nothing Then
                    Scm.Parameters.AddWithValue("@_Fecha_Fin", strlfcfin)
                    Sql_Frag_Where = Sql_Frag_Where & " And Convert(Date,SUBSTRING(((v.fcregcpd)),1,19)) <= @_Fecha_Fin "
                End If
                If strlcantidad <> Nothing Then
                    Scm.Parameters.Add("@_Max", SqlDbType.Int).Value = strlcantidad
                    Sql_Frag_Top = " Top(@_Max) "
                End If
            End If
            Con.Open()
            Scm.Connection = Con
            Scm.CommandText = "Declare @_Casos table ( Id_Caso numeric(18), Fecha_Reg DateTime, Fecha_Reg_V DateTime, Fecha_Asignado DateTime, Fecha_Proc_Dev DateTime, Id_Usuario_Dev Varchar(20), Campaña Varchar(20) ); Insert Into @_Casos Select V.idcaso , B.cas_fecha_registro , V.fcregistro , V.fcasignado , V.fcregcpd , V.idusuriocpd , V.campana From clarovoz.dbo.VFallared V Inner Join ( Select cas_id, cas_fecha_registro From datosclaro.dbo.Bandeja Where estado Like 'No Contactado' Union Select idcaso, fcreporte From datosclaro.dbo.Bandeja_alt Where estado Like 'No Contactado' Union Select Id_Caso, Fc_Reg From datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V Where estado Like 'No Contactado' ) B On B.cas_id=V.idcaso Inner Join ( Select C.idcaso From ( Select Max(idcrm) As idcrm, idcaso From datosclaro.dbo.CRMDetalle Group By idcaso ) C Inner Join datosclaro.dbo.CRMDetalle C2 On C.idcrm = C2.idcrm And C2.tipificacion Like 'Devuelto' Union Select C.idcasodilo From ( Select Max(idcrmdilo) As idcrmdilo, idcasodilo From datosclaro.dbo.CRMdilo Group By idcasodilo ) C Inner Join datosclaro.dbo.CRMdilo C2 On C.idcrmdilo = C2.idcrmdilo And C2.tipificacion Like 'Devuelto' Union Select CC.Id_Caso From ( select C1.Id_Caso, C1.Fk_Id_Bandeja from ( SELECT Max(C.Id_CRM_Falla_Desactivacion_D_V) As Id_CRM_Falla_Desactivacion_D_V, B.Id_Caso, C.Fk_Id_Bandeja FROM datosclaro.dbo.CRM_Falla_Desactivacion_D_V C Inner Join datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V B On B.Id_Bandeja_Falla_Desactivacion_D_V = C.Fk_Id_Bandeja Group By B.Id_Caso, C.Fk_Id_Bandeja ) C1 Inner Join datosclaro.dbo.CRM_Falla_Desactivacion_D_V C2 On C1.Id_CRM_Falla_Desactivacion_D_V = C2.Id_CRM_Falla_Desactivacion_D_V And C2.tipificacion Like 'Devuelto' ) CC ) C On C.idcaso = V.idcaso Where V.estadocpd Like 'Devuelto' And V.devuelto = 1 " & Sql_Frag_Where & " Order by Convert(Date,V.fcregcpd) Desc; Select " & Sql_Frag_Top & " Id_Caso, Fecha_Reg, Fecha_Reg_V, Fecha_Asignado, Fecha_Proc_Dev, Id_Usuario_Dev, Campaña From @_Casos; Select Id_Caso, Fc_Reg_Ges As Fecha, Id_Usuario, Obs As Observacion, Id_Crm, Tipificacion From ( SELECT B.Id_Caso, Fc_Reg_Ges, Id_Usuario, Obs, Id_CRM_Falla_Desactivacion_D_V As Id_Crm, Tipificacion From datosclaro.dbo.CRM_Falla_Desactivacion_D_V C Inner Join datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V B On B.Id_Bandeja_Falla_Desactivacion_D_V = C.Fk_Id_Bandeja Where B.Id_Caso In (Select " & Sql_Frag_Top & " Id_Caso From @_Casos) Union Select idcaso, fcreg, idusuario, obs, idcrm, Tipificacion From datosclaro.dbo.CRMDetalle Where idcaso In (Select " & Sql_Frag_Top & " Id_Caso From @_Casos) Union Select idcasodilo, fcregistro, idusuario, obs, idcrmdilo, Tipificacion From datosclaro.dbo.CRMdilo Where idcasodilo In (Select " & Sql_Frag_Top & " Id_Caso From @_Casos) ) C Order By Id_Caso, Fc_Reg_Ges Desc"
            Dim Sdta = New SqlClient.SqlDataAdapter(Scm)
            Sdta.Fill(Dts)
            Scm.Parameters.Clear()
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function



End Class