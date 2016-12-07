Public Class clscalidad
    Protected strltipo As String
    Protected strlnivel As String
    Protected strlitem As String
    Protected strlpartic As String
    Protected strlcantidad As String
    Protected strlidreg As String
    Protected strlagente As String
    Protected strlcaso As String
    Protected strlfcllamada As String
    Protected strltiempoacum As String
    Protected strlllamadas As String
    Protected strlidusuario As String
    Protected strlfcreg As String
    Protected strliditem As String
    Protected strlnota As String
    Protected strlobs As String
    Protected strlfcini As String
    Protected strlfcfin As String
    Protected strlgrupo As String
    Protected strlfcinill As String
    Protected strlfcfinll As String
    Protected strlpondera As String
    Protected strlCodigoAgente As String
    Protected strlsatisfaccion As String

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''' Calidad V2 ''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Protected _Cod_Calidad_Registro As Int64
    Protected _Fc_Reg As Date = Now
    Protected _Id_Usuario As String
    Protected _Id_Caso As Int64
    'Protected _Agente As String
    Protected _Auditor As String
    Protected _Campania As String
    Protected _Proceso As String
    Protected _Fc_Llamada As String
    Protected _Tiempo_Acum_Llamada As String
    Protected _N_Llamadas_Min As Integer
    Protected _Estado_Caso As String
    Protected _Tipo_Auditoria As String
    Protected _Amabilidad_Empatia As Integer
    Protected _Colgada_Llamada As Integer
    Protected _Real_filtros_adecuados As Integer
    Protected _Corona_Abierta As Integer
    Protected _Documentacion As Integer
    Protected _Procedimiento_PQR As Integer
    Protected _Procedimiento_prueba_tramite_incompleto_incorrecto As Integer
    Protected _Presenta_objetivo_llamada As Integer
    Protected _Cordialidad_Comunicacion As Integer
    Protected _Claridad_transmitir_informacion As Integer
    Protected _Seguridad As Integer
    Protected _Util_guion_saludo As Integer
    Protected _Gestion_Llamada As Integer
    Protected _Gestion_Soporte As Integer
    Protected _Gestion_Asignacion As Integer
    Protected _Gestion_Cierre As Integer
    Protected _Solucion As String
    Protected _Interes_escuchar As String
    Protected _Obs_General As String
    Protected _Reincide As String
    Protected _obs_Reincide As String

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''' Calibracion '''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'CalibracionSesion
    Protected _Cod_CalibracionSesion As Integer
    Protected _Fc_Creacion As String
    Protected _Fc_Cierre As String
    Protected _Administrador As String
    'CalibracionSesionCaso
    Protected _Cod_CalibracionSesionCaso As Integer
    Protected _Nombre As String
    'CalibracionSesionIncluido
    Protected _Cod_CalibracionSesionIncluido As Integer
    Protected _Respuesta As String
    'CalibracionSesionInvita
    Protected _Cod_CalibracionSesionInvita As Integer
    Protected _Invita As String
    Protected _Invitado As String
    Protected _Fk_Cod_CalibracionSesion As Integer
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''' Calidad Directv''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _tipo_llamada As String
    Protected _tipificacion As String
    Protected _Documentación_toma_datos As Integer
    Protected _Obs_Documentación_toma_datos As String
    Protected _Brindar_información_errada_cerrar_venta As Integer
    Protected _obs_Brindar_información_errada_cerrar_venta As String
    Protected _Inicia_llamada_horario_saludo_identidad_motivo_llamada As String
    Protected _obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada As String
    Protected _Realiza_preguntas_concretas_perfilar_cliente As String
    Protected _obs_Realiza_preguntas_concretas_perfilar_cliente As String
    Protected _Uso_información As String
    Protected _obs_Uso_información As String
    Protected _Tiene_conocimiento_completo_producto As String
    Protected _obs_Tiene_conocimiento_completo_producto As String
    Protected _Indica_beneficios_producto As String
    Protected _obs_Indica_beneficios_producto As String
    Protected _Aclara_dudas_tiene_cliente_acerca_servicio As String
    Protected _obs_Aclara_dudas_tiene_cliente_acerca_servicio As String
    Protected _Realiza_precierre_ofrece_beneficio_producto As String
    Protected _obs_Realiza_precierre_ofrece_beneficio_producto As String
    Protected _Cierra_venta_tiempo_oportuno As String
    Protected _obs_Cierra_venta_tiempo_oportuno As String
    Protected _Informacion_cierre As String
    Protected _obs_Informacion_cierre As String
    Protected _Rebate_minimo_objecione_negativa_cliente As String
    Protected _obs_Rebate_minimo_objecione_negativa_cliente As String
    Protected _manejo_objeciones_coherente As String
    Protected _obs_manejo_objeciones_coherente As String
    Protected _Retoma_llamada_tiempos_establecidos As String
    Protected _obs_Retoma_llamada_tiempos_establecidos As String
    Protected _evidencia_ambiente_laboral As String
    Protected _obs_evidencia_ambiente_laboral As String
    Protected _Tono_Voz As String
    Protected _obs_Tono_voz_Fluidez_verbal As String
    Protected _Personaliza_llamada As String
    Protected _obs_Personaliza_llamada As String
    Protected _Habilidad_escucha As String
    Protected _obs_Habilidad_escucha As String
    Protected _Cordialidad_empatia As String
    Protected _obs_Cordialidad_empatia As String
    Protected _Tipifica_apropiadamente_gestió_llamada_aplicativos As String
    Protected _obs_Tipifica_apropiadamente_gestió_llamada_aplicativos As String
    Protected _Cordialidad As String
    Protected _obs_Cordialidad As String
    Protected _Contacto_Activo As String
    Protected _Obs_Contacto_Activo As String
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''' Segundo Concepto '''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Codigo_reg As Integer
    Protected _Auditoria As Integer
    Protected _razon As String
    Protected _asistio As String
    Protected _Observacion As String
    Protected _Estado As String
    Protected _Fc_Asignacion As String
    Protected _Fc_Respuesta As String
    Protected _Observacion_Auditor As String
    Protected _Reporta_Inc As String
    Public Property Reporta_Inc As String
        Get
            Return _Reporta_Inc
        End Get
        Set(ByVal value As String)
            _Reporta_Inc = value
        End Set
    End Property


    Public Property obs_Reincide As String
        Get
            Return _obs_Reincide
        End Get
        Set(ByVal value As String)
            _obs_Reincide = value
        End Set
    End Property
    Public Property Reincide As String
        Get
            Return _Reincide
        End Get
        Set(ByVal value As String)
            _Reincide = value
        End Set
    End Property
    ''Segundo Concepto 
    Public Property Observacion_Auditor As String
        Get
            Return _Observacion_Auditor
        End Get
        Set(ByVal value As String)
            _Observacion_Auditor = value
        End Set
    End Property

    Public Property Codigo_reg As Integer
        Get
            Return _Codigo_reg
        End Get
        Set(ByVal value As Integer)
            _Codigo_reg = value
        End Set
    End Property
    Public Property razon As String
        Get
            Return _razon
        End Get
        Set(ByVal value As String)
            _razon = value
        End Set
    End Property
    Public Property asistio As String
        Get
            Return _asistio
        End Get
        Set(ByVal value As String)
            _asistio = value
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
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property
    Public Property Fc_Asignacion As String
        Get
            Return _Fc_Asignacion
        End Get
        Set(ByVal value As String)
            _Fc_Asignacion = value
        End Set
    End Property
    Public Property Fc_Respuesta As String
        Get
            Return _Fc_Respuesta
        End Get
        Set(ByVal value As String)
            _Fc_Respuesta = value
        End Set
    End Property

    Public Property Auditoria As String
        Get
            Return _Auditoria
        End Get
        Set(ByVal value As String)
            _Auditoria = value
        End Set
    End Property
    Public Property Obs_Contacto_Activo As String
        Get
            Return _Obs_Contacto_Activo
        End Get
        Set(ByVal value As String)
            _Obs_Contacto_Activo = value
        End Set
    End Property
    Public Property Contacto_Activo As String
        Get
            Return _Contacto_Activo
        End Get
        Set(ByVal value As String)
            _Contacto_Activo = value
        End Set
    End Property
    Public Property Obs_Cordialidad As String
        Get
            Return _obs_Cordialidad
        End Get
        Set(ByVal value As String)
            _obs_Cordialidad = value
        End Set
    End Property
    Public Property Cordialidad As String
        Get
            Return _Cordialidad
        End Get
        Set(ByVal value As String)
            _Cordialidad = value
        End Set
    End Property
    Public Property tipo_llamada As String
        Get
            Return _tipo_llamada
        End Get
        Set(ByVal value As String)
            _tipo_llamada = value
        End Set
    End Property
    Public Property tipificacion As String
        Get
            Return _tipificacion
        End Get
        Set(ByVal value As String)
            _tipificacion = value
        End Set
    End Property
    Public Property Documentación_toma_datos As Integer
        Get
            Return _Documentación_toma_datos
        End Get
        Set(ByVal value As Integer)
            _Documentación_toma_datos = value
        End Set
    End Property
    Public Property Obs_Documentación_toma_datos As String
        Get
            Return _Obs_Documentación_toma_datos
        End Get
        Set(ByVal value As String)
            _Obs_Documentación_toma_datos = value
        End Set
    End Property
    Public Property Brindar_información_errada_cerrar_venta As Integer
        Get
            Return _Brindar_información_errada_cerrar_venta
        End Get
        Set(ByVal value As Integer)
            _Brindar_información_errada_cerrar_venta = value
        End Set
    End Property
    Public Property obs_Brindar_información_errada_cerrar_venta As String
        Get
            Return _obs_Brindar_información_errada_cerrar_venta
        End Get
        Set(ByVal value As String)
            _obs_Brindar_información_errada_cerrar_venta = value
        End Set
    End Property
    Public Property Inicia_llamada_horario_saludo_identidad_motivo_llamada As String
        Get
            Return _Inicia_llamada_horario_saludo_identidad_motivo_llamada
        End Get
        Set(ByVal value As String)
            _Inicia_llamada_horario_saludo_identidad_motivo_llamada = value
        End Set
    End Property
    Public Property obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada As String
        Get
            Return _obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada
        End Get
        Set(ByVal value As String)
            _obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada = value
        End Set
    End Property
    Public Property Realiza_preguntas_concretas_perfilar_cliente As String
        Get
            Return _Realiza_preguntas_concretas_perfilar_cliente
        End Get
        Set(ByVal value As String)
            _Realiza_preguntas_concretas_perfilar_cliente = value
        End Set
    End Property
    Public Property obs_Realiza_preguntas_concretas_perfilar_cliente As String
        Get
            Return _obs_Realiza_preguntas_concretas_perfilar_cliente
        End Get
        Set(ByVal value As String)
            _obs_Realiza_preguntas_concretas_perfilar_cliente = value
        End Set
    End Property
    Public Property Uso_información As String
        Get
            Return _Uso_información
        End Get
        Set(ByVal value As String)
            _Uso_información = value
        End Set
    End Property
    Public Property obs_Uso_información As String
        Get
            Return _obs_Uso_información
        End Get
        Set(ByVal value As String)
            _obs_Uso_información = value
        End Set
    End Property
    Public Property Tiene_conocimiento_completo_producto As String
        Get
            Return _Tiene_conocimiento_completo_producto
        End Get
        Set(ByVal value As String)
            _Tiene_conocimiento_completo_producto = value
        End Set
    End Property
    Public Property obs_Tiene_conocimiento_completo_producto As String
        Get
            Return _obs_Tiene_conocimiento_completo_producto
        End Get
        Set(ByVal value As String)
            _obs_Tiene_conocimiento_completo_producto = value
        End Set
    End Property
    Public Property Indica_beneficios_producto As String
        Get
            Return _Indica_beneficios_producto
        End Get
        Set(ByVal value As String)
            _Indica_beneficios_producto = value
        End Set
    End Property
    Public Property obs_Indica_beneficios_producto As String
        Get
            Return _obs_Indica_beneficios_producto
        End Get
        Set(ByVal value As String)
            _obs_Indica_beneficios_producto = value
        End Set
    End Property
    Public Property Aclara_dudas_tiene_cliente_acerca_servicio As String
        Get
            Return _Aclara_dudas_tiene_cliente_acerca_servicio
        End Get
        Set(ByVal value As String)
            _Aclara_dudas_tiene_cliente_acerca_servicio = value
        End Set
    End Property
    Public Property obs_Aclara_dudas_tiene_cliente_acerca_servicio As String
        Get
            Return _obs_Aclara_dudas_tiene_cliente_acerca_servicio
        End Get
        Set(ByVal value As String)
            _obs_Aclara_dudas_tiene_cliente_acerca_servicio = value
        End Set
    End Property
    Public Property Realiza_precierre_ofrece_beneficio_producto As String
        Get
            Return _Realiza_precierre_ofrece_beneficio_producto
        End Get
        Set(ByVal value As String)
            _Realiza_precierre_ofrece_beneficio_producto = value
        End Set
    End Property
    Public Property obs_Realiza_precierre_ofrece_beneficio_producto As String
        Get
            Return _obs_Realiza_precierre_ofrece_beneficio_producto
        End Get
        Set(ByVal value As String)
            _obs_Realiza_precierre_ofrece_beneficio_producto = value
        End Set
    End Property
    Public Property Cierra_venta_tiempo_oportuno As String
        Get
            Return _Cierra_venta_tiempo_oportuno
        End Get
        Set(ByVal value As String)
            _Cierra_venta_tiempo_oportuno = value
        End Set
    End Property
    Public Property obs_Cierra_venta_tiempo_oportuno As String
        Get
            Return _obs_Cierra_venta_tiempo_oportuno
        End Get
        Set(ByVal value As String)
            _obs_Cierra_venta_tiempo_oportuno = value
        End Set
    End Property
    Public Property Informacion_cierre As String
        Get
            Return _Informacion_cierre
        End Get
        Set(ByVal value As String)
            _Informacion_cierre = value
        End Set
    End Property
    Public Property obs_Informacion_cierre As String
        Get
            Return _obs_Informacion_cierre
        End Get
        Set(ByVal value As String)
            _obs_Informacion_cierre = value
        End Set
    End Property
    Public Property Rebate_minimo_objecione_negativa_cliente As String
        Get
            Return _Rebate_minimo_objecione_negativa_cliente
        End Get
        Set(ByVal value As String)
            _Rebate_minimo_objecione_negativa_cliente = value
        End Set
    End Property
    Public Property obs_Rebate_minimo_objecione_negativa_cliente As String
        Get
            Return _obs_Rebate_minimo_objecione_negativa_cliente
        End Get
        Set(ByVal value As String)
            _obs_Rebate_minimo_objecione_negativa_cliente = value
        End Set
    End Property
    Public Property manejo_objeciones_coherente As String
        Get
            Return _manejo_objeciones_coherente
        End Get
        Set(ByVal value As String)
            _manejo_objeciones_coherente = value
        End Set
    End Property
    Public Property obs_manejo_objeciones_coherente As String
        Get
            Return _obs_manejo_objeciones_coherente
        End Get
        Set(ByVal value As String)
            _obs_manejo_objeciones_coherente = value
        End Set
    End Property
    Public Property Retoma_llamada_tiempos_establecidos As String
        Get
            Return _Retoma_llamada_tiempos_establecidos
        End Get
        Set(ByVal value As String)
            _Retoma_llamada_tiempos_establecidos = value
        End Set
    End Property
    Public Property obs_Retoma_llamada_tiempos_establecidos As String
        Get
            Return _obs_Retoma_llamada_tiempos_establecidos
        End Get
        Set(ByVal value As String)
            _obs_Retoma_llamada_tiempos_establecidos = value
        End Set
    End Property
    Public Property evidencia_ambiente_laboral As String
        Get
            Return _evidencia_ambiente_laboral
        End Get
        Set(ByVal value As String)
            _evidencia_ambiente_laboral = value
        End Set
    End Property
    Public Property obs_evidencia_ambiente_laboral As String
        Get
            Return _obs_evidencia_ambiente_laboral
        End Get
        Set(ByVal value As String)
            _obs_evidencia_ambiente_laboral = value
        End Set
    End Property
    Public Property Tono_voz As String
        Get
            Return _Tono_Voz
        End Get
        Set(ByVal value As String)
            _Tono_Voz = value
        End Set
    End Property
    Public Property obs_Tono_voz_Fluidez_verbal As String
        Get
            Return _obs_Tono_voz_Fluidez_verbal
        End Get
        Set(ByVal value As String)
            _obs_Tono_voz_Fluidez_verbal = value
        End Set
    End Property
    Public Property Personaliza_llamada As String
        Get
            Return _Personaliza_llamada
        End Get
        Set(ByVal value As String)
            _Personaliza_llamada = value
        End Set
    End Property
    Public Property obs_Personaliza_llamada As String
        Get
            Return _obs_Personaliza_llamada
        End Get
        Set(ByVal value As String)
            _obs_Personaliza_llamada = value
        End Set
    End Property
    Public Property Habilidad_escucha As String
        Get
            Return _Habilidad_escucha
        End Get
        Set(ByVal value As String)
            _Habilidad_escucha = value
        End Set
    End Property
    Public Property obs_Habilidad_escucha As String
        Get
            Return _obs_Habilidad_escucha
        End Get
        Set(ByVal value As String)
            _obs_Habilidad_escucha = value
        End Set
    End Property
    Public Property Cordialidad_empatia As String
        Get
            Return _Cordialidad_empatia
        End Get
        Set(ByVal value As String)
            _Cordialidad_empatia = value
        End Set
    End Property
    Public Property obs_Cordialidad_empatia As String
        Get
            Return _obs_Cordialidad_empatia
        End Get
        Set(ByVal value As String)
            _obs_Cordialidad_empatia = value
        End Set
    End Property
    Public Property Tipifica_apropiadamente_gestió_llamada_aplicativos As String
        Get
            Return _Tipifica_apropiadamente_gestió_llamada_aplicativos
        End Get
        Set(ByVal value As String)
            _Tipifica_apropiadamente_gestió_llamada_aplicativos = value
        End Set
    End Property
    Public Property obs_Tipifica_apropiadamente_gestió_llamada_aplicativos As String
        Get
            Return _obs_Tipifica_apropiadamente_gestió_llamada_aplicativos
        End Get
        Set(ByVal value As String)
            _obs_Tipifica_apropiadamente_gestió_llamada_aplicativos = value
        End Set
    End Property
    Public Property Fk_Cod_CalibracionSesion As Integer
        Get
            Return _Fk_Cod_CalibracionSesion
        End Get
        Set(ByVal value As Integer)
            _Fk_Cod_CalibracionSesion = value
        End Set
    End Property
    Public Property Invitado As String
        Get
            Return _Invitado
        End Get
        Set(ByVal value As String)
            _Invitado = value
        End Set
    End Property
    Public Property Invita As String
        Get
            Return _Invita
        End Get
        Set(ByVal value As String)
            _Invita = value
        End Set
    End Property
    Public Property Cod_CalibracionSesionInvita As Integer
        Get
            Return _Cod_CalibracionSesionInvita
        End Get
        Set(ByVal value As Integer)
            _Cod_CalibracionSesionInvita = value
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
    Public Property Cod_CalibracionSesionIncluido As Integer
        Get
            Return _Cod_CalibracionSesionIncluido
        End Get
        Set(ByVal value As Integer)
            _Cod_CalibracionSesionIncluido = value
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
    Public Property Cod_CalibracionSesionCaso As Integer
        Get
            Return _Cod_CalibracionSesionCaso
        End Get
        Set(ByVal value As Integer)
            _Cod_CalibracionSesionCaso = value
        End Set
    End Property
    Public Property Administrador As String
        Get
            Return _Administrador
        End Get
        Set(ByVal value As String)
            _Administrador = value
        End Set
    End Property
    Public Property Fc_Cierre As String
        Get
            Return _Fc_Cierre
        End Get
        Set(ByVal value As String)
            _Fc_Cierre = value
        End Set
    End Property
    Public Property Fc_Creacion As String
        Get
            Return _Fc_Creacion
        End Get
        Set(ByVal value As String)
            _Fc_Creacion = value
        End Set
    End Property
    Public Property Cod_CalibracionSesion As Integer
        Get
            Return _Cod_CalibracionSesion
        End Get
        Set(ByVal value As Integer)
            _Cod_CalibracionSesion = value
        End Set
    End Property


    Public Property Obs_General As String
        Get
            Return _Obs_General
        End Get
        Set(ByVal value As String)
            _Obs_General = value
        End Set
    End Property
    Public Property Interes_escuchar As String
        Get
            Return _Interes_escuchar
        End Get
        Set(ByVal value As String)
            _Interes_escuchar = value
        End Set
    End Property
    Public Property Solucion As String
        Get
            Return _Solucion
        End Get
        Set(ByVal value As String)
            _Solucion = value
        End Set
    End Property
    Public Property Gestion_Cierre As Integer
        Get
            Return _Gestion_Cierre
        End Get
        Set(ByVal value As Integer)
            _Gestion_Cierre = value
        End Set
    End Property
    Public Property Gestion_Asignacion As Integer
        Get
            Return _Gestion_Asignacion
        End Get
        Set(ByVal value As Integer)
            _Gestion_Asignacion = value
        End Set
    End Property
    Public Property Gestion_Soporte As Integer
        Get
            Return _Gestion_Soporte
        End Get
        Set(ByVal value As Integer)
            _Gestion_Soporte = value
        End Set
    End Property
    Public Property Gestion_Llamada As Integer
        Get
            Return _Gestion_Llamada
        End Get
        Set(ByVal value As Integer)
            _Gestion_Llamada = value
        End Set
    End Property
    Public Property Util_guion_saludo As Integer
        Get
            Return _Util_guion_saludo
        End Get
        Set(ByVal value As Integer)
            _Util_guion_saludo = value
        End Set
    End Property
    Public Property Seguridad As Integer
        Get
            Return _Seguridad
        End Get
        Set(ByVal value As Integer)
            _Seguridad = value
        End Set
    End Property
    Public Property Claridad_transmitir_informacion As Integer
        Get
            Return _Claridad_transmitir_informacion
        End Get
        Set(ByVal value As Integer)
            _Claridad_transmitir_informacion = value
        End Set
    End Property
    Public Property Cordialidad_Comunicacion As Integer
        Get
            Return _Cordialidad_Comunicacion
        End Get
        Set(ByVal value As Integer)
            _Cordialidad_Comunicacion = value
        End Set
    End Property
    Public Property Presenta_objetivo_llamada As Integer
        Get
            Return _Presenta_objetivo_llamada
        End Get
        Set(ByVal value As Integer)
            _Presenta_objetivo_llamada = value
        End Set
    End Property
    Public Property Procedimiento_prueba_tramite_incompleto_incorrecto As Integer
        Get
            Return _Procedimiento_prueba_tramite_incompleto_incorrecto
        End Get
        Set(ByVal value As Integer)
            _Procedimiento_prueba_tramite_incompleto_incorrecto = value
        End Set
    End Property
    Public Property Procedimiento_PQR As Integer
        Get
            Return _Procedimiento_PQR
        End Get
        Set(ByVal value As Integer)
            _Procedimiento_PQR = value
        End Set
    End Property
    Public Property Documentacion As Integer
        Get
            Return _Documentacion
        End Get
        Set(ByVal value As Integer)
            _Documentacion = value
        End Set
    End Property
    Public Property Corona_Abierta As Integer
        Get
            Return _Corona_Abierta
        End Get
        Set(ByVal value As Integer)
            _Corona_Abierta = value
        End Set
    End Property
    Public Property Real_filtros_adecuados As Integer
        Get
            Return _Real_filtros_adecuados
        End Get
        Set(ByVal value As Integer)
            _Real_filtros_adecuados = value
        End Set
    End Property
    Public Property Colgada_Llamada As Integer
        Get
            Return _Colgada_Llamada
        End Get
        Set(ByVal value As Integer)
            _Colgada_Llamada = value
        End Set
    End Property
    Public Property Amabilidad_Empatia As Integer
        Get
            Return _Amabilidad_Empatia
        End Get
        Set(ByVal value As Integer)
            _Amabilidad_Empatia = value
        End Set
    End Property
    Public Property Tipo_Auditoria As String
        Get
            Return _Tipo_Auditoria
        End Get
        Set(ByVal value As String)
            _Tipo_Auditoria = value
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
    Public Property N_Llamadas_Min As Integer
        Get
            Return _N_Llamadas_Min
        End Get
        Set(ByVal value As Integer)
            _N_Llamadas_Min = value
        End Set
    End Property
    Public Property Tiempo_Acum_Llamada As String
        Get
            Return _Tiempo_Acum_Llamada
        End Get
        Set(ByVal value As String)
            _Tiempo_Acum_Llamada = value
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
    Public Property Proceso As String
        Get
            Return _Proceso
        End Get
        Set(ByVal value As String)
            _Proceso = value
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
    Public Property Auditor As String
        Get
            Return _Auditor
        End Get
        Set(ByVal value As String)
            _Auditor = value
        End Set
    End Property
    'Public Property Agente As String
    '    Get
    '        Return _Agente
    '    End Get
    '    Set(ByVal value As String)
    '        _Agente = value
    '    End Set
    'End Property
    Public Property Id_Caso As Int64
        Get
            Return _Id_Caso
        End Get
        Set(ByVal value As Int64)
            _Id_Caso = value
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
    Public Property Fc_Reg As Date
        Get
            Return _Fc_Reg
        End Get
        Set(ByVal value As Date)
            _Fc_Reg = value
        End Set
    End Property
    Public Property Cod_Calidad_Registro As Int64
        Get
            Return _Cod_Calidad_Registro
        End Get
        Set(ByVal value As Int64)
            _Cod_Calidad_Registro = value
        End Set
    End Property

    '''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''' Variables Obs '''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''

    Protected _Obs_Amabilidad_Empatia As String
    Protected _Obs_Colgada_Llamada As String
    Protected _Obs_Real_filtros_adecuados As String
    Protected _Obs_Corona_Abierta As String
    Protected _Obs_Documentacion As String
    Protected _Obs_Procedimiento_PQR As String
    Protected _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto As String

    Protected _Obs_Presenta_objetivo_llamada As String
    Protected _Obs_Cordialidad_Comunicacion As String
    Protected _Obs_Claridad_transmitir_informacion As String
    Protected _Obs_Seguridad As String
    Protected _Obs_Util_guion_saludo As String

    Protected _Obs_Gestion_Llamada As String
    Protected _Obs_Gestion_Soporte As String
    Protected _Obs_Gestion_Asignacion As String
    Protected _Obs_Gestion_Cierre As String

    Protected _Obs_Solucion As String
    Protected _Obs_Interes_escuchar As String
    Protected _Validacion As String

    Public Property Validacion As String
        Get
            Return _Validacion
        End Get
        Set(ByVal value As String)
            _Validacion = value
        End Set
    End Property
    Public Property Obs_Interes_escuchar As String
        Get
            Return _Obs_Interes_escuchar
        End Get
        Set(ByVal value As String)
            _Obs_Interes_escuchar = value
        End Set
    End Property
    Public Property Obs_Solucion As String
        Get
            Return _Obs_Solucion
        End Get
        Set(ByVal value As String)
            _Obs_Solucion = value
        End Set
    End Property
    Public Property Obs_Gestion_Cierre As String
        Get
            Return _Obs_Gestion_Cierre
        End Get
        Set(ByVal value As String)
            _Obs_Gestion_Cierre = value
        End Set
    End Property
    Public Property Obs_Gestion_Asignacion As String
        Get
            Return _Obs_Gestion_Asignacion
        End Get
        Set(ByVal value As String)
            _Obs_Gestion_Asignacion = value
        End Set
    End Property
    Public Property Obs_Gestion_Soporte As String
        Get
            Return _Obs_Gestion_Soporte
        End Get
        Set(ByVal value As String)
            _Obs_Gestion_Soporte = value
        End Set
    End Property
    Public Property Obs_Gestion_Llamada As String
        Get
            Return _Obs_Gestion_Llamada
        End Get
        Set(ByVal value As String)
            _Obs_Gestion_Llamada = value
        End Set
    End Property
    Public Property Obs_Util_guion_saludo As String
        Get
            Return _Obs_Util_guion_saludo
        End Get
        Set(ByVal value As String)
            _Obs_Util_guion_saludo = value
        End Set
    End Property
    Public Property Obs_Seguridad As String
        Get
            Return _Obs_Seguridad
        End Get
        Set(ByVal value As String)
            _Obs_Seguridad = value
        End Set
    End Property
    Public Property Obs_Claridad_transmitir_informacion As String
        Get
            Return _Obs_Claridad_transmitir_informacion
        End Get
        Set(ByVal value As String)
            _Obs_Claridad_transmitir_informacion = value
        End Set
    End Property
    Public Property Obs_Cordialidad_Comunicacion As String
        Get
            Return _Obs_Cordialidad_Comunicacion
        End Get
        Set(ByVal value As String)
            _Obs_Cordialidad_Comunicacion = value
        End Set
    End Property
    Public Property Obs_Presenta_objetivo_llamada As String
        Get
            Return _Obs_Presenta_objetivo_llamada
        End Get
        Set(ByVal value As String)
            _Obs_Presenta_objetivo_llamada = value
        End Set
    End Property
    Public Property Obs_Procedimiento_prueba_tramite_incompleto_incorrecto As String
        Get
            Return _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto
        End Get
        Set(ByVal value As String)
            _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto = value
        End Set
    End Property
    Public Property Obs_Procedimiento_PQR As String
        Get
            Return _Obs_Procedimiento_PQR
        End Get
        Set(ByVal value As String)
            _Obs_Procedimiento_PQR = value
        End Set
    End Property
    Public Property Obs_Documentacion As String
        Get
            Return _Obs_Documentacion
        End Get
        Set(ByVal value As String)
            _Obs_Documentacion = value
        End Set
    End Property
    Public Property Obs_Corona_Abierta As String
        Get
            Return _Obs_Corona_Abierta
        End Get
        Set(ByVal value As String)
            _Obs_Corona_Abierta = value
        End Set
    End Property
    Public Property Obs_Real_filtros_adecuados As String
        Get
            Return _Obs_Real_filtros_adecuados
        End Get
        Set(ByVal value As String)
            _Obs_Real_filtros_adecuados = value
        End Set
    End Property
    Public Property Obs_Colgada_Llamada As String
        Get
            Return _Obs_Colgada_Llamada
        End Get
        Set(ByVal value As String)
            _Obs_Colgada_Llamada = value
        End Set
    End Property
    Public Property Obs_Amabilidad_Empatia As String
        Get
            Return _Obs_Amabilidad_Empatia
        End Get
        Set(ByVal value As String)
            _Obs_Amabilidad_Empatia = value
        End Set
    End Property

    Public Property CodigoAgente() As String
        Get
            Return strlCodigoAgente
        End Get
        Set(ByVal value As String)
            strlCodigoAgente = value
        End Set
    End Property
    Public Property pondera() As String
        Get
            Return strlpondera
        End Get
        Set(ByVal value As String)
            strlpondera = value
        End Set
    End Property
    Public Property fcfinll() As String
        Get
            Return strlfcfinll
        End Get
        Set(ByVal value As String)
            strlfcfinll = value
        End Set
    End Property
    Public Property fcinill() As String
        Get
            Return strlfcinill
        End Get
        Set(ByVal value As String)
            strlfcinill = value
        End Set
    End Property
    Public Property grupo() As String
        Get
            Return strlgrupo
        End Get
        Set(ByVal value As String)
            strlgrupo = value
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
    Public Property obs() As String
        Get
            Return strlobs
        End Get
        Set(ByVal value As String)
            strlobs = value
        End Set
    End Property
    Public Property nota() As String
        Get
            Return strlnota
        End Get
        Set(ByVal value As String)
            strlnota = value
        End Set
    End Property
    Public Property iditem() As String
        Get
            Return strliditem
        End Get
        Set(ByVal value As String)
            strliditem = value
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
    Public Property idusuario() As String
        Get
            Return strlidusuario
        End Get
        Set(ByVal value As String)
            strlidusuario = value
        End Set
    End Property
    Public Property llamadas() As String
        Get
            Return strlllamadas
        End Get
        Set(ByVal value As String)
            strlllamadas = value
        End Set
    End Property
    Public Property tiempoacum() As String
        Get
            Return strltiempoacum
        End Get
        Set(ByVal value As String)
            strltiempoacum = value
        End Set
    End Property
    Public Property fcllamada() As String
        Get
            Return strlfcllamada
        End Get
        Set(ByVal value As String)
            strlfcllamada = value
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
    Public Property agente() As String
        Get
            Return strlagente
        End Get
        Set(ByVal value As String)
            strlagente = value
        End Set
    End Property
    Public Property idreg() As String
        Get
            Return strlidreg
        End Get
        Set(ByVal value As String)
            strlidreg = value
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
    Public Property partic() As String
        Get
            Return strlpartic
        End Get
        Set(ByVal value As String)
            strlpartic = value
        End Set
    End Property
    Public Property item() As String
        Get
            Return strlitem
        End Get
        Set(ByVal value As String)
            strlitem = value
        End Set
    End Property
    Public Property nivel() As String
        Get
            Return strlnivel
        End Get
        Set(ByVal value As String)
            strlnivel = value
        End Set
    End Property
    Public Property tipo() As String
        Get
            Return strltipo
        End Get
        Set(ByVal value As String)
            strltipo = value
        End Set
    End Property
    Public Property satisfaccion() As String
        Get
            Return strlsatisfaccion
        End Get
        Set(ByVal value As String)
            strlsatisfaccion = value
        End Set
    End Property

    Protected _Supervisor As String
    Public Property Supervisor As String
        Get
            Return _Supervisor
        End Get
        Set(ByVal value As String)
            _Supervisor = value
        End Set
    End Property

    Protected _Id_Tipo_Cliente As Integer
    Public Property Id_Tipo_Cliente As Integer
        Get
            Return _Id_Tipo_Cliente
        End Get
        Set(ByVal value As Integer)
            _Id_Tipo_Cliente = value
        End Set
    End Property
    Protected _Id_Tipo_PQR As Integer
    Public Property Id_Tipo_PQR As Integer
        Get
            Return _Id_Tipo_PQR
        End Get
        Set(ByVal value As Integer)
            _Id_Tipo_PQR = value
        End Set
    End Property
    Protected _Tipo_Cliente As String
    Public Property Tipo_Cliente As String
        Get
            Return _Tipo_Cliente
        End Get
        Set(ByVal value As String)
            _Tipo_Cliente = value
        End Set
    End Property
    Protected _Tipo_PQR As String
    Public Property Tipo_PQR As String
        Get
            Return _Tipo_PQR
        End Get
        Set(ByVal value As String)
            _Tipo_PQR = value
        End Set
    End Property



    Public Function itemevaluacion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Calificacion_audit where Tipo=@strltipo and Nivel=@strlnivel"
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 20).Value = Me.strltipo
            cms.Parameters.Add("@strlnivel", SqlDbType.VarChar, 10).Value = Me.strlnivel
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
    Public Sub registroauditoria()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO detalle_auditoria(codagente,tipo,nivel,caso,fcllamada,tiempoacum,llamadas,idusuarioaudita,fcauditoria,obs,grupo) values(@strlagente,@strltipo,@strlnivel,@strlcaso,@strlfcllamada,@strltiempoacum,@strlllamadas,@strlidusuario,@strlfcreg,@strlobs,@strlgrupo)"
            cms.Parameters.Add("@strlagente", SqlDbType.VarChar, 50).Value = strlagente
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 20).Value = strltipo
            cms.Parameters.Add("@strlnivel", SqlDbType.VarChar, 10).Value = strlnivel
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcllamada", SqlDbType.VarChar, 50).Value = strlfcllamada
            cms.Parameters.Add("@strltiempoacum", SqlDbType.VarChar,10).Value = strltiempoacum
            cms.Parameters.Add("@strlllamadas", SqlDbType.Int).Value = strlllamadas
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlgrupo", SqlDbType.NVarChar, 50).Value = strlgrupo
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
    Public Function traeconsecut() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select idaudit from detalle_auditoria where Tipo=@strltipo and Nivel=@strlnivel and codagente=@strlagente order by idaudit desc"
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 20).Value = Me.strltipo
            cms.Parameters.Add("@strlnivel", SqlDbType.VarChar, 10).Value = Me.strlnivel
            cms.Parameters.Add("@strlagente", SqlDbType.VarChar, 50).Value = Me.strlagente
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            If dtsrecepcion.Tables(0).Rows.Count > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("idaudit") Is System.DBNull.Value Then
                    strlidreg = " "
                Else
                    strlidreg = dtsrecepcion.Tables(0).Rows(0).Item("idaudit")
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
    Public Sub registrocalif()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If strlitem = Nothing Then
                cms.CommandText = "INSERT INTO detalle_calif(idaudit,iditem,nota,obs) values(@strlidreg,@strliditem,@strlnota,@strlobs)"
            Else
                cms.CommandText = "INSERT INTO detalle_calif(idaudit,iditem,nota,obs,pondera) values(@strlidreg,@strliditem,@strlnota,@strlobs,@strlpondera)"
                cms.Parameters.Add("@strlpondera", SqlDbType.Decimal, 2).Value = strlpondera
            End If
            cms.Parameters.Add("@strlidreg", SqlDbType.Decimal).Value = strlidreg
            cms.Parameters.Add("@strliditem", SqlDbType.Int).Value = strliditem
            cms.Parameters.Add("@strlnota", SqlDbType.Decimal).Value = strlnota
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs

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
    Public Function consultaaudit() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE iditem = 98 OR iditem = 99"
            If strlfcini <> "" Then
                cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcauditoria>=@strlfcini"
                cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = Me.strlfcini
                If strlfcfin <> "" Then
                    cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcauditoria>=@strlfcini and fcauditoria<=@strlfcfin"
                    cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = Me.strlfcfin
                End If
            End If
            If strlfcinill <> "" Then
                cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcllamada>=@strlfcinill"
                cms.Parameters.Add("@strlfcinill", SqlDbType.VarChar, 50).Value = Me.strlfcinill
                If strlfcfinll <> "" Then
                    cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcllamada>=@strlfcinill and fcllamada<=@strlfcfinll"
                    cms.Parameters.Add("@strlfcfinll", SqlDbType.VarChar, 50).Value = Me.strlfcfinll
                End If
            End If
            If strlagente <> "" Then
                cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and codagente=@strlagente"
                cms.Parameters.Add("@strlagente", SqlDbType.VarChar, 50).Value = Me.strlagente
                If strlfcini <> "" Then
                    cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcauditoria>=@strlfcini and codagente=@strlagente"
                    If strlfcfin <> "" Then
                        cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcauditoria>=@strlfcini and fcauditoria<=@strlfcfin and codagente=@strlagente"
                    End If
                End If
                If strlfcinill <> "" Then
                    cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcllamada>=@strlfcinill and codagente=@strlagente"
                    If strlfcfinll <> "" Then
                        cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcllamada>=@strlfcinill and fcllamada<=@strlfcfinll and codagente=@strlagente"
                    End If
                End If
            End If
            If strltipo <> "" Then
                cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and Detalle_auditoria.tipo=@strltipo"
                cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 20).Value = Me.strltipo
                If strlnivel <> "" Then
                    cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and Detalle_auditoria.tipo=@strltipo and Detalle_auditoria.nivel=@strlnivel"
                    cms.Parameters.Add("@strlnivel", SqlDbType.VarChar, 10).Value = Me.strlnivel
                End If
                If strlfcini <> "" Then
                    cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcauditoria>=@strlfcini and Detalle_auditoria.tipo=@strltipo"
                    If strlfcfin <> "" Then
                        cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and fcauditoria>=@strlfcini and fcauditoria<=@strlfcfin and Detalle_auditoria.tipo=@strltipo"
                    End If
                End If
            End If
            If strlidreg <> "" Then
                cms.CommandText = "SELECT pondera,grupo,Detalle_auditoria.obs,Detalle_auditoria.idaudit, codagente, nombreu, Detalle_auditoria.tipo, Detalle_auditoria.nivel, caso, fcllamada, tiempoacum, llamadas, fcauditoria, idusuarioaudita, iditem, nota FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit INNER JOIN Calificacion_audit ON Detalle_calif.iditem = Calificacion_audit.id inner join usuarios on Detalle_auditoria.codagente=usuarios.idusuario WHERE (iditem = 98 OR iditem = 99) and Detalle_auditoria.idaudit=@strlidreg"
                cms.Parameters.Add("@strlidreg", SqlDbType.VarChar, 50).Value = Me.strlidreg
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
    Public Function consultaauditdetalle() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlidreg <> "" Then
                cms.CommandText = "select * from detalle_calif INNER join Calificacion_audit on Detalle_calif.iditem=Calificacion_audit.id where idaudit=@strlidreg"
                cms.Parameters.Add("@strlidreg", SqlDbType.VarChar, 50).Value = Me.strlidreg
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
    Public Function itemevaluacionfg() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Calificacion_audit where Tipo=@strltipo order by tipo"
            cms.Parameters.Add("@strltipo", SqlDbType.VarChar, 20).Value = Me.strltipo
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
    Public Function consultanotafin() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            If strlagente <> "" Then
                cn.Open()
                cms.CommandText = "SELECT codagente, SUM(pondera) AS notaaud FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit WHERE (iditem = 98 OR iditem = 99) and codagente=@strlagente GROUP BY codagente"
                cms.Parameters.Add("@strlagente", SqlDbType.VarChar, 50).Value = Me.strlagente
                If strlfcinill <> "" Then
                    cms.CommandText = "SELECT codagente, SUM(pondera) AS notaaud FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit WHERE (iditem = 98 OR iditem = 99) and codagente=@strlagente and fcllamada>=@strlfcinill GROUP BY codagente"
                    cms.Parameters.Add("@strlfcinill", SqlDbType.VarChar, 50).Value = Me.strlfcinill
                    If strlfcfinll <> "" Then
                        cms.CommandText = "SELECT codagente, SUM(pondera) AS notaaud FROM Detalle_calif INNER JOIN Detalle_auditoria ON Detalle_calif.idaudit = Detalle_auditoria.idaudit WHERE (iditem = 98 OR iditem = 99) and codagente=@strlagente and fcllamada>=@strlfcinill and fcllamada<=@strlfcfinll GROUP BY codagente"
                        cms.Parameters.Add("@strlfcfinll", SqlDbType.VarChar, 50).Value = Me.strlfcfinll
                    End If
                End If
                cms.Connection = cn
                dtarecepcion = New SqlClient.SqlDataAdapter(cms)
                dtarecepcion.Fill(dtsrecepcion)
                strlcantidad = dtsrecepcion.Tables(0).Rows.Count
                If strlcantidad > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("notaaud") Is System.DBNull.Value Then
                        strlnota = " "
                    Else
                        strlnota = dtsrecepcion.Tables(0).Rows(0).Item("notaaud")
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
    Public Function Consulta_Total_Auditoria_Agente() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            ''Consulta fecha Inicio Auditoria
            If strlfcini <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcauditoria > @strlfcini) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
                cms.Parameters.Add("@strlfcini", SqlDbType.Date).Value = strlfcini
            End If
            ''Consulta fecha Fin Auditoria
            If strlfcfin <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcauditoria < @strlfcfin) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
                cms.Parameters.Add("@strlfcfin", SqlDbType.Date).Value = strlfcfin
            End If
            ''Consulta dos fechas Auditoria
            If strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcauditoria between @strlfcini and @strlfcfin) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
            End If

            ''Consulta fecha Inicio Llamada
            If strlfcinill <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcllamada > @strlfcinill) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
                cms.Parameters.Add("@strlfcinill", SqlDbType.VarChar).Value = strlfcinill
            End If
            ''Consulta fecha Fin Llamada
            If strlfcfinll <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcllamada < @strlfcfinll) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
                cms.Parameters.Add("@strlfcfinll", SqlDbType.VarChar).Value = strlfcfinll
            End If
            ''Consulta dos fechas Llamada
            If strlfcinill <> Nothing And strlfcfinll <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcllamada between @strlfcinill and @strlfcfinll) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
            End If
            ''Consulta Operacion
            If strlobs <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (Cargo like '" + strlobs + "%') AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
                cms.Parameters.Add("@Operacion", SqlDbType.VarChar, 20).Value = strlobs
            End If
            ''Consulta Operacion y dos fechas Auditoria
            If strlfcini <> Nothing And strlfcfin <> Nothing And strlobs <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcauditoria between @strlfcini and @strlfcfin) AND (Cargo like '" + strlobs + "%') AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
            End If
            ''Consulta Operacion y dos fechas Llamada
            If strlfcinill <> Nothing And strlfcfinll <> Nothing And strlobs <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcllamada between @strlfcinill and @strlfcfinll) AND (Cargo like '" + strlobs + "%') AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
            End If
            ''Consulta Grupo
            If strlgrupo <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (Cargo = @Grupo) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
                cms.Parameters.Add("@Grupo", SqlDbType.VarChar, 20).Value = strlgrupo
            End If
            ''Consulta Grupo y dos fechas Auditoria
            If strlfcini <> Nothing And strlfcfin <> Nothing And strlgrupo <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcauditoria between @strlfcini and @strlfcfin) AND (Cargo = @Grupo) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
            End If
            ''Consulta Grupo y dos fechas Llamada
            If strlfcinill <> Nothing And strlfcfinll <> Nothing And strlgrupo <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcllamada between @strlfcinill and @strlfcfinll) AND (Cargo = @Grupo) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
            End If

            ''Consulta Supervisor
            If strlagente <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (Supervisor = @strlagente) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
                cms.Parameters.Add("@strlagente", SqlDbType.VarChar, 120).Value = strlagente
            End If
            ''Consulta Supervisor y dos fechas Auditoria
            If strlfcini <> Nothing And strlfcfin <> Nothing And strlagente <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcauditoria between @strlfcini and @strlfcfin) AND (Supervisor = @strlagente) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
            End If
            ''Consulta Supervisor y dos fechas Llamada
            If strlfcinill <> Nothing And strlfcfinll <> Nothing And strlagente <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcllamada between @strlfcinill and @strlfcfinll) AND (Supervisor = @strlagente) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
            End If
            ''Codigo del Agente
            If strlCodigoAgente <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (codnom = @Codigo) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
                cms.Parameters.Add("@Codigo", SqlDbType.VarChar, 20).Value = strlCodigoAgente
            End If
            ''Consulta Codigo del Agente y dos fechas Auditoria
            If strlfcini <> Nothing And strlfcfin <> Nothing And strlCodigoAgente <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcauditoria between @strlfcini and @strlfcfin) AND (codnom = @Codigo) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
            End If
            ''Consulta Codigo del Agente y dos fechas Llamada
            If strlfcinill <> Nothing And strlfcfinll <> Nothing And strlCodigoAgente <> Nothing Then
                cms.CommandText = "SELECT U.cargo,U.codnom, U.nombreu,((SUM(DC.pondera)*2)/Count(DC.pondera)) as Total FROM Detalle_calif DC INNER JOIN  Detalle_auditoria DA ON DA.idaudit = DC.idaudit INNER JOIN usuarios U ON U.idusuario = DA.codagente WHERE (DA.fcllamada between @strlfcinill and @strlfcfinll) AND (codnom = @Codigo) AND ((DC.iditem=99) Or (DC.iditem=98)) group by U.cargo, U.codnom, U.nombreu order by U.cargo"
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

    Public Function Consulta_Grupo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select cargo from usuarios where cargo like 'N%' or cargo like 'V%' or idusuario='0' group by cargo"
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

    Public Function Consulta_Supervisor() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select supervisor from usuarios where supervisor is not null group by supervisor"
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
    Public Function Consulta_Caso_Agente() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select u.nombreu as nombreu,B.Usuario as idusuario,B.Bandeja from usuarios u right join (Select Da.idusuario as Usuario,B.Bandeja from CRMDetalle Da inner join Bandeja B on Da.idcaso = B.cas_id where Da.idcaso = @strlcaso union Select Da.idusuario as Usuario,'DILO' as Bandeja from CRMDilo Da inner join Bandeja_alt B on Da.idcasodilo = B.idcaso where Da.idcasodilo = @strlcaso union Select Da.Id_Usuario as Usuario,'DESACTIVACION' as Bandeja from CRM_Falla_Desactivacion_D_V Da inner join Bandeja_Falla_Desactivacion_D_V B on Da.Fk_Id_Bandeja = B.Id_Bandeja_Falla_Desactivacion_D_V where b.Id_Caso = @strlcaso union Select Da.Id_Usuario as Usuario,'INBOUND' as Bandeja from CRM_inbound Da inner join Bandeja_inbound B on Da.Fk_Id_caso = B.Id_caso where Da.Fk_Id_caso = @strlcaso) B on u.idusuario= B.Usuario"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Bandeja") Is DBNull.Value Then
                    Campania = ""
                Else
                    Campania = dts.Tables(0).Rows(0).Item("Bandeja")
                End If
            End If

            If strlCodigoAgente <> Nothing Then
                cms.CommandText = "select idusuario,nombreu,codnom from usuarios where codnom=@strlCodigoAgente order by nombreu"
                cms.Parameters.Add("@strlCodigoAgente", SqlDbType.VarChar, 10).Value = strlCodigoAgente
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
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

       Public Function Consulta_Calidad_Registro_Complemento() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = "1" Then
                cms.CommandText = "select * from Calidad_Registro_Complemento where Pertenece='- Seleccione -' or Pertenece='PROCESO' order by Nombre"
            ElseIf Validacion = "2" Then
                cms.CommandText = "select * from Calidad_Registro_Complemento where Pertenece='- Seleccione -' or Pertenece='ESTADO' order by Nombre"
            ElseIf Validacion = "3" Then
                cms.CommandText = "select * from Calidad_Registro_Complemento where Pertenece='- Seleccione -' or Pertenece='TAUDITORIA' order by Nombre"
            ElseIf Validacion = "4" Then
                cms.CommandText = "select nombreu,idusuario from usuarios where cargo like 'Q%' or nombreu='- Seleccione -' group by idusuario,nombreu order by nombreu"
            ElseIf Validacion = "5" Then
                cms.CommandText = "select cargo from usuarios where cargo like 'BO%' or cargo like 'N%' or cargo like 'Voz%' or cargo like 'Q%'  or cargo = '- Seleccione -'  group by cargo order by cargo"
            ElseIf Validacion = "6" Then
                cms.CommandText = "select * from Calidad_Registro_Complemento where Pertenece='- Seleccione -' or Pertenece='DIRECTV' order by Nombre"
            ElseIf Validacion = "7" Then
                cms.CommandText = "select * from Calidad_Registro_Complemento where Pertenece='Rechaza_retro' order by Nombre"
            ElseIf Validacion <> Nothing Then
                cms.Parameters.AddWithValue("@_Pertenece", Validacion)
                cms.CommandText = "select * from Calidad_Registro_Complemento where Pertenece = @_Pertenece order by Nombre"
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

    Public Sub Registro_Auditoria_Calidad()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            _Fc_Reg = Now
            cms.CommandText = "insert into Calidad_Registro (Fc_Reg,Id_Usuario,Id_Caso,Agente,grupo,Auditor,Campania,Proceso,Fc_Llamada,Tiempo_Acum_Llamada,N_Llamadas_Min,Estado_Caso,Tipo_Auditoria,Amabilidad_Empatia,Obs_Amabilidad_Empatia,Colgada_Llamada,Obs_Colgada_Llamada,Real_filtros_adecuados,Obs_Real_filtros_adecuados,Corona_Abierta,Obs_Corona_Abierta,Documentacion,Obs_Documentacion,Procedimiento_PQR,Obs_Procedimiento_PQR,Procedimiento_prueba_tramite_incompleto_incorrecto,Obs_Procedimiento_prueba_tramite_incompleto_incorrecto,Presenta_objetivo_llamada,Obs_Presenta_objetivo_llamada,Cordialidad_Comunicacion,Obs_Cordialidad_Comunicacion,Cordialidad,Obs_Cordialidad,Contacto_Activo,Obs_Contacto_Activo,Claridad_transmitir_informacion,Obs_Claridad_transmitir_informacion,Seguridad,Obs_Seguridad,Util_guion_saludo,Obs_Util_guion_saludo,Gestion_Llamada,Obs_Gestion_Llamada,Gestion_Soporte,Obs_Gestion_Soporte,Gestion_Asignacion,Obs_Gestion_Asignacion,Gestion_Cierre,Obs_Gestion_Cierre,Solucion,Obs_Solucion,Interes_escuchar,Obs_Interes_escuchar,Obs_General,reincide,obsreincide) values (@_Fc_Reg,@_Id_Usuario,@_caso,@_agente,@_grupo,@_Auditor,@_Campania,@_Proceso,@_Fc_Llamada,@_Tiempo_Acum_Llamada,@_N_Llamadas_Min,@_Estado_Caso,@_Tipo_Auditoria,@_Amabilidad_Empatia,@_Obs_Amabilidad_Empatia,@_Colgada_Llamada,@_Obs_Colgada_Llamada,@_Real_filtros_adecuados,@_Obs_Real_filtros_adecuados,@_Corona_Abierta,@_Obs_Corona_Abierta,@_Documentacion,@_Obs_Documentacion,@_Procedimiento_PQR,@_Obs_Procedimiento_PQR,@_Procedimiento_prueba_tramite_incompleto_incorrecto,@_Obs_Procedimiento_prueba_tramite_incompleto_incorrecto,@_Presenta_objetivo_llamada,@_Obs_Presenta_objetivo_llamada,@_Cordialidad_Comunicacion,@_Obs_Cordialidad_Comunicacion,@_Cordialidad,@_Obs_Cordialidad,@_Contacto_Activo,@_Obs_Contacto_Activo,@_Claridad_transmitir_informacion,@_Obs_Claridad_transmitir_informacion,@_Seguridad,@_Obs_Seguridad,@_Util_guion_saludo,@_Obs_Util_guion_saludo,@_Gestion_Llamada,@_Obs_Gestion_Llamada,@_Gestion_Soporte,@_Obs_Gestion_Soporte,@_Gestion_Asignacion,@_Obs_Gestion_Asignacion,@_Gestion_Cierre,@_Obs_Gestion_Cierre,@_Solucion,@_Obs_Solucion,@_Interes_escuchar,@_Obs_Interes_escuchar,@_Obs_General,@_Reincide,@_Obs_Reincide)"
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.DateTime).Value = _Fc_Reg
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_caso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@_agente", SqlDbType.VarChar, 50).Value = strlagente
            cms.Parameters.Add("@_grupo", SqlDbType.VarChar, 50).Value = strlgrupo
            cms.Parameters.Add("@_Auditor", SqlDbType.VarChar, 50).Value = _Auditor
            cms.Parameters.Add("@_Campania", SqlDbType.VarChar, 50).Value = _Campania
            cms.Parameters.Add("@_Proceso", SqlDbType.VarChar, 50).Value = _Proceso
            cms.Parameters.Add("@_Fc_Llamada", SqlDbType.DateTime).Value = _Fc_Llamada
            cms.Parameters.Add("@_Tiempo_Acum_Llamada", SqlDbType.VarChar, 50).Value = _Tiempo_Acum_Llamada
            cms.Parameters.Add("@_N_Llamadas_Min", SqlDbType.Int).Value = _N_Llamadas_Min
            cms.Parameters.Add("@_Estado_Caso", SqlDbType.VarChar, 50).Value = _Estado_Caso
            cms.Parameters.Add("@_Tipo_Auditoria", SqlDbType.VarChar, 50).Value = _Tipo_Auditoria
            cms.Parameters.Add("@_Amabilidad_Empatia", SqlDbType.Int).Value = _Amabilidad_Empatia
            cms.Parameters.Add("@_Obs_Amabilidad_Empatia", SqlDbType.VarChar, 750).Value = _Obs_Amabilidad_Empatia
            cms.Parameters.Add("@_Colgada_Llamada", SqlDbType.Int).Value = _Colgada_Llamada
            cms.Parameters.Add("@_Obs_Colgada_Llamada", SqlDbType.VarChar, 750).Value = _Obs_Colgada_Llamada
            cms.Parameters.Add("@_Real_filtros_adecuados", SqlDbType.Int).Value = _Real_filtros_adecuados
            cms.Parameters.Add("@_Obs_Real_filtros_adecuados", SqlDbType.VarChar, 750).Value = _Obs_Real_filtros_adecuados
            cms.Parameters.Add("@_Corona_Abierta", SqlDbType.Int).Value = _Corona_Abierta
            cms.Parameters.Add("@_Obs_Corona_Abierta", SqlDbType.VarChar, 750).Value = _Obs_Corona_Abierta
            cms.Parameters.Add("@_Documentacion", SqlDbType.Int).Value = _Documentacion
            cms.Parameters.Add("@_Obs_Documentacion", SqlDbType.VarChar, 750).Value = _Obs_Documentacion
            cms.Parameters.Add("@_Procedimiento_PQR", SqlDbType.Int).Value = _Procedimiento_PQR
            cms.Parameters.Add("@_Obs_Procedimiento_PQR", SqlDbType.VarChar, 750).Value = _Obs_Procedimiento_PQR
            cms.Parameters.Add("@_Procedimiento_prueba_tramite_incompleto_incorrecto", SqlDbType.Int).Value = _Procedimiento_prueba_tramite_incompleto_incorrecto
            cms.Parameters.Add("@_Obs_Procedimiento_prueba_tramite_incompleto_incorrecto", SqlDbType.VarChar, 750).Value = _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto
            cms.Parameters.Add("@_Presenta_objetivo_llamada", SqlDbType.Int).Value = _Presenta_objetivo_llamada
            cms.Parameters.Add("@_Obs_Presenta_objetivo_llamada", SqlDbType.VarChar, 750).Value = _Obs_Presenta_objetivo_llamada
            cms.Parameters.Add("@_Cordialidad_Comunicacion", SqlDbType.Int).Value = _Cordialidad_Comunicacion
            cms.Parameters.Add("@_Obs_Cordialidad_Comunicacion", SqlDbType.VarChar, 750).Value = _Obs_Cordialidad_Comunicacion
            cms.Parameters.Add("@_Cordialidad", SqlDbType.Int).Value = _Cordialidad
            cms.Parameters.Add("@_obs_Cordialidad", SqlDbType.VarChar, 750).Value = _obs_Cordialidad
            cms.Parameters.Add("@_Contacto_Activo", SqlDbType.Int).Value = _Contacto_Activo
            cms.Parameters.Add("@_Obs_Contacto_Activo", SqlDbType.VarChar, 750).Value = _Obs_Contacto_Activo
            cms.Parameters.Add("@_Claridad_transmitir_informacion", SqlDbType.Int).Value = _Claridad_transmitir_informacion
            cms.Parameters.Add("@_Obs_Claridad_transmitir_informacion", SqlDbType.VarChar, 750).Value = _Obs_Claridad_transmitir_informacion
            cms.Parameters.Add("@_Seguridad", SqlDbType.Int).Value = _Seguridad
            cms.Parameters.Add("@_Obs_Seguridad", SqlDbType.VarChar, 750).Value = _Obs_Seguridad
            cms.Parameters.Add("@_Util_guion_saludo", SqlDbType.Int).Value = _Util_guion_saludo
            cms.Parameters.Add("@_Obs_Util_guion_saludo", SqlDbType.VarChar, 750).Value = _Obs_Util_guion_saludo
            cms.Parameters.Add("@_Gestion_Llamada", SqlDbType.Int).Value = _Gestion_Llamada
            cms.Parameters.Add("@_Obs_Gestion_Llamada", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Llamada
            cms.Parameters.Add("@_Gestion_Soporte", SqlDbType.Int).Value = _Gestion_Soporte
            cms.Parameters.Add("@_Obs_Gestion_Soporte", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Soporte
            cms.Parameters.Add("@_Gestion_Asignacion", SqlDbType.Int).Value = _Gestion_Asignacion
            cms.Parameters.Add("@_Obs_Gestion_Asignacion", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Asignacion
            cms.Parameters.Add("@_Gestion_Cierre", SqlDbType.Int).Value = _Gestion_Cierre
            cms.Parameters.Add("@_Obs_Gestion_Cierre", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Cierre
            cms.Parameters.Add("@_Solucion", SqlDbType.VarChar, 2).Value = _Solucion
            cms.Parameters.Add("@_Obs_Solucion", SqlDbType.VarChar, 750).Value = _Obs_Solucion
            cms.Parameters.Add("@_Interes_escuchar", SqlDbType.VarChar, 2).Value = _Interes_escuchar
            cms.Parameters.Add("@_Obs_Interes_escuchar", SqlDbType.VarChar, 750).Value = _Obs_Interes_escuchar
            cms.Parameters.Add("@_Obs_General", SqlDbType.VarChar, 800).Value = _Obs_General
            cms.Parameters.Add("@_Reincide", SqlDbType.VarChar, 5).Value = _Reincide
            cms.Parameters.Add("@_Obs_Reincide", SqlDbType.VarChar, 800).Value = _obs_Reincide
            cms.Connection = cn
            cms.ExecuteNonQuery()
            cms.CommandText = "update AA  set auditado='Si' from AsignacionAuditorias as AA inner join CRMDetalle Crm on crm.idcrm = AA.idcrm  where Crm.idcrm=aa.idcrm   and crm.idcaso =@_caso and crm.idusuario =@_agente"
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
    Public Function Llenar_TextBox() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario  where Cod_Calidad_Registro = @_Cod_Calidad"
            cms.Parameters.Add("@_Cod_Calidad", SqlDbType.Int).Value = Cod_Calidad_Registro
            If _Validacion = "1" Then
                cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario  where UU.cargo like '%Q%' and Cod_Calidad_Registro = @_Cod_Calidad and CR.Agente = @_Id_Usuario"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            End If

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Id_Caso") Is DBNull.Value Then
                    strlcaso = ""
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("Id_Caso")
                End If
                If dts.Tables(0).Rows(0).Item("Nagente") Is DBNull.Value Then
                    strlagente = ""
                Else
                    strlagente = dts.Tables(0).Rows(0).Item("Nagente")
                End If
                If dts.Tables(0).Rows(0).Item("Grupo") Is DBNull.Value Then
                    strlgrupo = ""
                Else
                    strlgrupo = dts.Tables(0).Rows(0).Item("Grupo")
                End If
                If dts.Tables(0).Rows(0).Item("NAuditor") Is DBNull.Value Then
                    _Auditor = ""
                Else
                    _Auditor = dts.Tables(0).Rows(0).Item("NAuditor")
                End If
                If dts.Tables(0).Rows(0).Item("Campania") Is DBNull.Value Then
                    _Campania = ""
                Else
                    _Campania = dts.Tables(0).Rows(0).Item("Campania")
                End If
                If dts.Tables(0).Rows(0).Item("Proceso") Is DBNull.Value Then
                    _Proceso = ""
                Else
                    _Proceso = dts.Tables(0).Rows(0).Item("Proceso")
                End If
                If dts.Tables(0).Rows(0).Item("Tiempo_Acum_Llamada") Is DBNull.Value Then
                    _Tiempo_Acum_Llamada = ""
                Else
                    _Tiempo_Acum_Llamada = dts.Tables(0).Rows(0).Item("Tiempo_Acum_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Fc_Llamada") Is DBNull.Value Then
                    _Fc_Llamada = ""
                Else
                    _Fc_Llamada = dts.Tables(0).Rows(0).Item("Fc_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("N_Llamadas_Min") Is DBNull.Value Then
                    _N_Llamadas_Min = ""
                Else
                    _N_Llamadas_Min = dts.Tables(0).Rows(0).Item("N_Llamadas_Min")
                End If
                If dts.Tables(0).Rows(0).Item("Estado_Caso") Is DBNull.Value Then
                    _Estado_Caso = ""
                Else
                    _Estado_Caso = dts.Tables(0).Rows(0).Item("Estado_Caso")
                End If
                If dts.Tables(0).Rows(0).Item("Tipo_Auditoria") Is DBNull.Value Then
                    _Tipo_Auditoria = ""
                Else
                    _Tipo_Auditoria = dts.Tables(0).Rows(0).Item("Tipo_Auditoria")
                End If
                If dts.Tables(0).Rows(0).Item("Amabilidad_Empatia") Is DBNull.Value Then
                    _Amabilidad_Empatia = ""
                Else
                    _Amabilidad_Empatia = dts.Tables(0).Rows(0).Item("Amabilidad_Empatia")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Amabilidad_Empatia") Is DBNull.Value Then
                    _Obs_Amabilidad_Empatia = ""
                Else
                    _Obs_Amabilidad_Empatia = dts.Tables(0).Rows(0).Item("Obs_Amabilidad_Empatia")
                End If
                If dts.Tables(0).Rows(0).Item("Colgada_Llamada") Is DBNull.Value Then
                    _Colgada_Llamada = ""
                Else
                    _Colgada_Llamada = dts.Tables(0).Rows(0).Item("Colgada_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Colgada_Llamada") Is DBNull.Value Then
                    _Obs_Colgada_Llamada = ""
                Else
                    _Obs_Colgada_Llamada = dts.Tables(0).Rows(0).Item("Obs_Colgada_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Real_filtros_adecuados") Is DBNull.Value Then
                    _Real_filtros_adecuados = ""
                Else
                    _Real_filtros_adecuados = dts.Tables(0).Rows(0).Item("Real_filtros_adecuados")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Real_filtros_adecuados") Is DBNull.Value Then
                    _Obs_Real_filtros_adecuados = ""
                Else
                    _Obs_Real_filtros_adecuados = dts.Tables(0).Rows(0).Item("Obs_Real_filtros_adecuados")
                End If
                If dts.Tables(0).Rows(0).Item("Corona_Abierta") Is DBNull.Value Then
                    _Corona_Abierta = ""
                Else
                    _Corona_Abierta = dts.Tables(0).Rows(0).Item("Corona_Abierta")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Corona_Abierta") Is DBNull.Value Then
                    _Obs_Corona_Abierta = ""
                Else
                    _Obs_Corona_Abierta = dts.Tables(0).Rows(0).Item("Obs_Corona_Abierta")
                End If
                If dts.Tables(0).Rows(0).Item("Documentacion") Is DBNull.Value Then
                    _Documentacion = ""
                Else
                    _Documentacion = dts.Tables(0).Rows(0).Item("Documentacion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Documentacion") Is DBNull.Value Then
                    _Obs_Documentacion = ""
                Else
                    _Obs_Documentacion = dts.Tables(0).Rows(0).Item("Obs_Documentacion")
                End If
                If dts.Tables(0).Rows(0).Item("Procedimiento_PQR") Is DBNull.Value Then
                    _Procedimiento_PQR = ""
                Else
                    _Procedimiento_PQR = dts.Tables(0).Rows(0).Item("Procedimiento_PQR")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Procedimiento_PQR") Is DBNull.Value Then
                    _Obs_Procedimiento_PQR = ""
                Else
                    _Obs_Procedimiento_PQR = dts.Tables(0).Rows(0).Item("Obs_Procedimiento_PQR")
                End If
                If dts.Tables(0).Rows(0).Item("Procedimiento_prueba_tramite_incompleto_incorrecto") Is DBNull.Value Then
                    _Procedimiento_prueba_tramite_incompleto_incorrecto = ""
                Else
                    _Procedimiento_prueba_tramite_incompleto_incorrecto = dts.Tables(0).Rows(0).Item("Procedimiento_prueba_tramite_incompleto_incorrecto")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Procedimiento_prueba_tramite_incompleto_incorrecto") Is DBNull.Value Then
                    _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto = ""
                Else
                    _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto = dts.Tables(0).Rows(0).Item("Obs_Procedimiento_prueba_tramite_incompleto_incorrecto")
                End If
                If dts.Tables(0).Rows(0).Item("Presenta_objetivo_llamada") Is DBNull.Value Then
                    _Presenta_objetivo_llamada = ""
                Else
                    _Presenta_objetivo_llamada = dts.Tables(0).Rows(0).Item("Presenta_objetivo_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Presenta_objetivo_llamada") Is DBNull.Value Then
                    _Obs_Presenta_objetivo_llamada = ""
                Else
                    _Obs_Presenta_objetivo_llamada = dts.Tables(0).Rows(0).Item("Obs_Presenta_objetivo_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Cordialidad_Comunicacion") Is DBNull.Value Then
                    _Cordialidad_Comunicacion = ""
                Else
                    _Cordialidad_Comunicacion = dts.Tables(0).Rows(0).Item("Cordialidad_Comunicacion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Cordialidad_Comunicacion") Is DBNull.Value Then
                    _Obs_Cordialidad_Comunicacion = ""
                Else
                    _Obs_Cordialidad_Comunicacion = dts.Tables(0).Rows(0).Item("Obs_Cordialidad_Comunicacion")
                End If
                If dts.Tables(0).Rows(0).Item("Cordialidad") Is DBNull.Value Then
                    _Cordialidad = ""
                Else
                    _Cordialidad = dts.Tables(0).Rows(0).Item("Cordialidad")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Cordialidad") Is DBNull.Value Then
                    _obs_Cordialidad = ""
                Else
                    _obs_Cordialidad = dts.Tables(0).Rows(0).Item("Obs_Cordialidad")
                End If
                If dts.Tables(0).Rows(0).Item("Contacto_Activo") Is DBNull.Value Then
                    _Contacto_Activo = ""
                Else
                    _Contacto_Activo = dts.Tables(0).Rows(0).Item("Contacto_Activo")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Contacto_Activo") Is DBNull.Value Then
                    _Obs_Contacto_Activo = ""
                Else
                    _Obs_Contacto_Activo = dts.Tables(0).Rows(0).Item("Obs_Contacto_Activo")
                End If
                If dts.Tables(0).Rows(0).Item("Claridad_transmitir_informacion") Is DBNull.Value Then
                    _Claridad_transmitir_informacion = ""
                Else
                    _Claridad_transmitir_informacion = dts.Tables(0).Rows(0).Item("Claridad_transmitir_informacion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Claridad_transmitir_informacion") Is DBNull.Value Then
                    _Obs_Claridad_transmitir_informacion = ""
                Else
                    _Obs_Claridad_transmitir_informacion = dts.Tables(0).Rows(0).Item("Obs_Claridad_transmitir_informacion")
                End If
                If dts.Tables(0).Rows(0).Item("Seguridad") Is DBNull.Value Then
                    _Seguridad = ""
                Else
                    _Seguridad = dts.Tables(0).Rows(0).Item("Seguridad")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Seguridad") Is DBNull.Value Then
                    _Obs_Seguridad = ""
                Else
                    _Obs_Seguridad = dts.Tables(0).Rows(0).Item("Obs_Seguridad")
                End If
                If dts.Tables(0).Rows(0).Item("Util_guion_saludo") Is DBNull.Value Then
                    _Util_guion_saludo = ""
                Else
                    _Util_guion_saludo = dts.Tables(0).Rows(0).Item("Util_guion_saludo")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Util_guion_saludo") Is DBNull.Value Then
                    _Obs_Util_guion_saludo = ""
                Else
                    _Obs_Util_guion_saludo = dts.Tables(0).Rows(0).Item("Obs_Util_guion_saludo")
                End If
                If dts.Tables(0).Rows(0).Item("Gestion_Llamada") Is DBNull.Value Then
                    _Gestion_Llamada = ""
                Else
                    _Gestion_Llamada = dts.Tables(0).Rows(0).Item("Gestion_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Gestion_Llamada") Is DBNull.Value Then
                    _Obs_Gestion_Llamada = ""
                Else
                    _Obs_Gestion_Llamada = dts.Tables(0).Rows(0).Item("Obs_Gestion_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Gestion_Soporte") Is DBNull.Value Then
                    _Gestion_Soporte = ""
                Else
                    _Gestion_Soporte = dts.Tables(0).Rows(0).Item("Gestion_Soporte")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Gestion_Soporte") Is DBNull.Value Then
                    _Obs_Gestion_Soporte = ""
                Else
                    _Obs_Gestion_Soporte = dts.Tables(0).Rows(0).Item("Obs_Gestion_Soporte")
                End If
                If dts.Tables(0).Rows(0).Item("Gestion_Asignacion") Is DBNull.Value Then
                    _Gestion_Asignacion = ""
                Else
                    _Gestion_Asignacion = dts.Tables(0).Rows(0).Item("Gestion_Asignacion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Gestion_Asignacion") Is DBNull.Value Then
                    _Obs_Gestion_Asignacion = ""
                Else
                    _Obs_Gestion_Asignacion = dts.Tables(0).Rows(0).Item("Obs_Gestion_Asignacion")
                End If
                If dts.Tables(0).Rows(0).Item("Gestion_Cierre") Is DBNull.Value Then
                    _Gestion_Cierre = ""
                Else
                    _Gestion_Cierre = dts.Tables(0).Rows(0).Item("Gestion_Cierre")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Gestion_Cierre") Is DBNull.Value Then
                    _Obs_Gestion_Cierre = ""
                Else
                    _Obs_Gestion_Cierre = dts.Tables(0).Rows(0).Item("Obs_Gestion_Cierre")
                End If
                If dts.Tables(0).Rows(0).Item("Solucion") Is DBNull.Value Then
                    _Solucion = ""
                Else
                    _Solucion = dts.Tables(0).Rows(0).Item("Solucion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Solucion") Is DBNull.Value Then
                    _Obs_Solucion = ""
                Else
                    _Obs_Solucion = dts.Tables(0).Rows(0).Item("Obs_Solucion")
                End If
                If dts.Tables(0).Rows(0).Item("Interes_escuchar") Is DBNull.Value Then
                    _Interes_escuchar = ""
                Else
                    _Interes_escuchar = dts.Tables(0).Rows(0).Item("Interes_escuchar")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Interes_escuchar") Is DBNull.Value Then
                    _Obs_Interes_escuchar = ""
                Else
                    _Obs_Interes_escuchar = dts.Tables(0).Rows(0).Item("Obs_Interes_escuchar")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_General") Is DBNull.Value Then
                    _Obs_General = ""
                Else
                    _Obs_General = dts.Tables(0).Rows(0).Item("Obs_General")
                End If
                If dts.Tables(0).Rows(0).Item("reincide") Is DBNull.Value Then
                    _Reincide = "No aplica"
                Else
                    _Reincide = dts.Tables(0).Rows(0).Item("reincide")
                End If
                If dts.Tables(0).Rows(0).Item("ObsReincide") Is DBNull.Value Then
                    _obs_Reincide = "No aplica"
                Else
                    _obs_Reincide = dts.Tables(0).Rows(0).Item("ObsReincide")
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
    Public Function Consulta_Registro() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Calidad_Registro where Fc_Reg=@_Fc_Reg and Id_Usuario=@_Id_Usuario and Id_Caso=@_caso and Agente=@_agente and Grupo=@_grupo and Auditor=@_Auditor"
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.DateTime).Value = _Fc_Reg
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_caso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@_agente", SqlDbType.VarChar, 50).Value = strlagente
            cms.Parameters.Add("@_grupo", SqlDbType.VarChar, 50).Value = strlgrupo
            cms.Parameters.Add("@_Auditor", SqlDbType.VarChar, 50).Value = _Auditor
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Calidad_Registro") Is DBNull.Value Then
                    _Cod_Calidad_Registro = 0
                Else
                    _Cod_Calidad_Registro = dts.Tables(0).Rows(0).Item("Cod_Calidad_Registro")
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
    Public Function Consulta_Auditorias_Agente() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "(Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo)*100)/25)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario) as innerquery where Cod_Calidad_Registro<=108173 union Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo+Cordialidad+Contacto_Activo)*100)/35)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario) as innerquery where Cod_Calidad_Registro>=108183) order by Fc_Reg desc"
            If _Id_Usuario <> Nothing Then
                cms.CommandText = "(Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo)*100)/25)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario where UU.cargo like '%Q%') as innerquery  where idusuario=@_Id_Usuario and Cod_Calidad_Registro<=108173 union Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo+Cordialidad+Contacto_Activo)*100)/35)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario where UU.cargo like '%Q%') as innerquery  where idusuario=@_Id_Usuario and Cod_Calidad_Registro>=108183) order by Fc_Reg desc"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            End If

            If strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "(Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo)*100)/25)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario) as innerquery where Fc_Reg Between @strlfcini and @strlfcfin and Cod_Calidad_Registro<=108173 union Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo+Cordialidad+Contacto_Activo)*100)/35)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario) as innerquery where Fc_Reg Between @strlfcini and @strlfcfin and Cod_Calidad_Registro>=108183) order by Fc_Reg desc"
                cms.Parameters.Add("@strlfcini", SqlDbType.Date).Value = strlfcini
                cms.Parameters.Add("@strlfcfin", SqlDbType.Date).Value = strlfcfin
                If strlgrupo <> Nothing Then
                    cms.CommandText = "(Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo)*100)/25)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario) as innerquery where Fc_Reg Between @strlfcini and @strlfcfin and cargo=@strlgrupo and Cod_Calidad_Registro<=108173 union Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo+Cordialidad+Contacto_Activo)*100)/35)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario) as innerquery where Fc_Reg Between @strlfcini and @strlfcfin and cargo=@strlgrupo and Cod_Calidad_Registro>=108183) order by Fc_Reg desc"
                    cms.Parameters.Add("@strlgrupo", SqlDbType.VarChar, 10).Value = strlgrupo
                End If
                If strlCodigoAgente <> Nothing Then
                    cms.CommandText = "(Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo)*100)/25)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario) as innerquery where Fc_Reg Between @strlfcini and @strlfcfin and codnom=@strlCodigoAgente and Cod_Calidad_Registro<=108173 union Select Fc_Reg,Cod_Calidad_Registro,Id_Caso,Grupo,codnom,NAgente,idusuario,cargo,NAuditor,Estado_Caso,Tipo_Auditoria,Error_Critico,SAC_Claro,Variable_Kam,(Convert(varchar,(Error_Critico))+' - '+Convert(varchar,(SAC_Claro))) as Resultado_Claro,Solucion,Interes_escuchar,CASE WHEN(Error_Critico < 100) THEN 0 WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Resultado_Kamilion from (Select Reincide,CR.Cod_Calidad_Registro,CR.Fc_Reg,CR.Id_Caso,CR.Grupo,U.codnom,U.nombreu as NAgente,U.idusuario,U.cargo,UU.nombreu as NAuditor,Cr.Estado_Caso,Cr.Tipo_Auditoria,CR.Solucion,Cr.Interes_escuchar,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo+Cordialidad+Contacto_Activo)*100)/35)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calidad_Registro CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario) as innerquery where Fc_Reg Between @strlfcini and @strlfcfin and codnom=@strlCodigoAgente and Cod_Calidad_Registro>=108183) order by Fc_Reg desc"
                    cms.Parameters.Add("@strlCodigoAgente", SqlDbType.VarChar, 10).Value = strlCodigoAgente
                End If
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
    Public Sub CrearSesion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            _Fc_Creacion = Now
            cms.CommandText = "insert into CalibracionSesion (Fc_Creacion,Administrador,Estado) values (@_Fc_Creacion,@_Adminitrador,'Abierto')"
            cms.Parameters.Add("@_Fc_Creacion", SqlDbType.DateTime).Value = _Fc_Creacion
            cms.Parameters.Add("@_Adminitrador", SqlDbType.VarChar, 50).Value = _Administrador
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
    Public Sub IncluirEnSesion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            _Fc_Creacion = Now
            cms.CommandText = "insert into CalibracionSesionIncluido (Fc_Reg,Id_Usuario,Fk_Cod_CalibracionSesion) values (@_Fc_Creacion,@_Adminitrador,@_Cod_CalibracionSesion)"
            cms.Parameters.Add("@_Fc_Creacion", SqlDbType.DateTime).Value = _Fc_Creacion
            cms.Parameters.Add("@_Adminitrador", SqlDbType.VarChar, 50).Value = _Administrador
            cms.Parameters.Add("@_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Cod_CalibracionSesion
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
    Public Sub EnviarInvitacion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            _Fc_Creacion = Now
            cms.CommandText = "insert into CalibracionSesionInvita (Fc_Reg,Invita,Invitado,Fk_Cod_CalibracionSesion) values (@_Fc_Creacion,@_Adminitrador,@_Id_Usuario,@_Fk_Cod_CalibracionSesion)"
            cms.Parameters.Add("@_Fc_Creacion", SqlDbType.DateTime).Value = _Fc_Creacion
            cms.Parameters.Add("@_Adminitrador", SqlDbType.VarChar, 50).Value = _Administrador
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 10).Value = _Id_Usuario
            cms.Parameters.Add("@_Fk_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Fk_Cod_CalibracionSesion
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
    Public Sub AgregaCasos()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            _Fc_Reg = Now
            cms.CommandText = "insert into CalibracionSesionCaso (Fc_Reg,Id_Usuario,Caso,Nombre,Grupo,Campania,Fk_Cod_CalibracionSesion) values (@_Fc_Reg,@_Id_Usuario,@strlcaso,@_Nombre,@strlgrupo,@_Campania,@_Fk_Cod_CalibracionSesion)"
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.DateTime).Value = _Fc_Reg
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@_Nombre", SqlDbType.VarChar, 50).Value = _Nombre
            cms.Parameters.Add("@strlgrupo", SqlDbType.VarChar, 50).Value = strlgrupo
            cms.Parameters.Add("@_Campania", SqlDbType.VarChar, 50).Value = _Campania
            cms.Parameters.Add("@_Fk_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Fk_Cod_CalibracionSesion
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
    Public Function ConsultaSesionCalidadParte1()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "1" Then
                cms.CommandText = "select * from CalibracionSesion CS inner join CalibracionSesionIncluido CSI on CS.Cod_CalibracionSesion = CSI.Fk_Cod_CalibracionSesion where CSI.Id_Usuario=@_Id_Usuario order by Cod_CalibracionSesion desc"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            End If
            If _Validacion = "2" Then
                cms.CommandText = "select *,'Aceptar' as Aceptar,'Rechazar' as Rechazar from CalibracionSesion CS inner join CalibracionSesionInvita CSI on CS.Cod_CalibracionSesion = CSI.Fk_Cod_CalibracionSesion where Invitado=@_Id_Usuario and (Respuesta is null or Respuesta='') and (Fc_Reg_Respuesta is null or Fc_Reg_Respuesta='') order by Cod_CalibracionSesion desc"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            End If
            If _Validacion = "3" Then
                cms.CommandText = "select * from CalibracionSesion order by Cod_CalibracionSesion desc"
            End If
            If _Fc_Creacion <> Nothing Then
                cms.CommandText = "select * from CalibracionSesion where Fc_Creacion=@_Fc_Creacion and Administrador=@_Adminitrador"
                cms.Parameters.Add("@_Fc_Creacion", SqlDbType.DateTime).Value = _Fc_Creacion
                cms.Parameters.Add("@_Adminitrador", SqlDbType.VarChar, 50).Value = _Administrador
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_CalibracionSesion") Is DBNull.Value Then
                    _Cod_CalibracionSesion = Nothing
                Else
                    _Cod_CalibracionSesion = dts.Tables(0).Rows(0).Item("Cod_CalibracionSesion")
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
    Public Function ConsultaSesionCalidadParte2()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "1" Then
                cms.CommandText = "select codnom as Integrante,nombreu as Nombre, cargo from CalibracionSesionIncluido CSI inner join usuarios U on CSI.Id_Usuario = U.idusuario where Fk_Cod_CalibracionSesion=@_Fk_Cod_CalibracionSesion"
                cms.Parameters.Add("@_Fk_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Fk_Cod_CalibracionSesion
            End If
            If _Validacion = "4" Then
                cms.CommandText = "select * from CalibracionSesionCaso CS inner join Bandeja B on CS.Caso = B.cas_id where CS.Fk_Cod_CalibracionSesion = @_Fk_Cod_CalibracionSesion"
                cms.Parameters.Add("@_Fk_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Fk_Cod_CalibracionSesion
            End If
            If _Validacion = "5" Then
                cms.CommandText = "select * from CalibracionSesionCaso CS inner join Bandeja B on CS.Caso = B.cas_id where CS.Fk_Cod_CalibracionSesion = @_Fk_Cod_CalibracionSesion"
                cms.Parameters.Add("@_Fk_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Fk_Cod_CalibracionSesion
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
    Public Function ConsultaCasosSesion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "2" Then
                cms.CommandText = "select *,0 as N_Registro  from datosclaro.dbo.CalibracionSesionCaso CS inner join datosclaro.dbo.Bandeja B on CS.Caso = B.cas_id where CS.Fk_Cod_CalibracionSesion = @_Fk_Cod_CalibracionSesion"
                cms.Parameters.Add("@_Fk_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Fk_Cod_CalibracionSesion
            End If
            If _Validacion = "3" Then
                cms.CommandText = "select *,0 as N_Registro  from datosclaro.dbo.CalibracionSesionCaso CS inner join clarovoz.dbo.Bandeja_uni B on CS.Caso = B.idcaso where CS.Fk_Cod_CalibracionSesion = @_Fk_Cod_CalibracionSesion"
                cms.Parameters.Add("@_Fk_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Fk_Cod_CalibracionSesion
            End If
            If _Validacion = "4" Then
                cms.CommandText = "select * from datosclaro.dbo.calibracion where Id_Caso=@_Id_Caso and Agente=@strlagente and grupo=@strlgrupo and Campania=@_Campania"
                cms.Parameters.Add("@_Id_Caso", SqlDbType.Decimal).Value = _Id_Caso
                cms.Parameters.Add("@strlagente", SqlDbType.VarChar, 150).Value = strlagente
                cms.Parameters.Add("@strlgrupo", SqlDbType.VarChar, 50).Value = strlgrupo
                cms.Parameters.Add("@_Campania", SqlDbType.VarChar, 50).Value = _Campania
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
    Public Function ConsultaCodigoAgenteSesion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from usuarios where codnom=@CodigoAgente"
            cms.Parameters.Add("@CodigoAgente", SqlDbType.VarChar, 10).Value = CodigoAgente
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("idusuario") Is DBNull.Value Then
                    Id_Usuario = ""
                Else
                    Id_Usuario = dts.Tables(0).Rows(0).Item("idusuario")
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
    Public Sub ActualizaInvitacion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            _Fc_Reg = Now
            cms.CommandText = "update CalibracionSesionInvita set Respuesta=@_Respuesta,Fc_Reg_Respuesta=@_Fc_Reg where Cod_CalibracionSesionInvita = @_Cod_CalibracionSesionInvita"
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.DateTime).Value = _Fc_Reg
            cms.Parameters.Add("@_Respuesta", SqlDbType.VarChar, 50).Value = _Respuesta
            cms.Parameters.Add("@_Cod_CalibracionSesionInvita", SqlDbType.Decimal).Value = _Cod_CalibracionSesionInvita
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
    Public Sub CerrarSesion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            _Fc_Reg = Now
            cms.CommandText = "update CalibracionSesion set Fc_Cierre=@_Fc_Reg,Estado='Cerrado' where Cod_CalibracionSesion = @_Cod_CalibracionSesion"
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.DateTime).Value = _Fc_Reg
            cms.Parameters.Add("@_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Cod_CalibracionSesion
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
    Public Sub Registro_Calibracion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            _Fc_Reg = Now
            cms.CommandText = "insert into Calibracion (Fc_Reg,Id_Usuario,Id_Caso,Agente,grupo,Auditor,Campania,Amabilidad_Empatia,Obs_Amabilidad_Empatia,Colgada_Llamada,Obs_Colgada_Llamada,Real_filtros_adecuados,Obs_Real_filtros_adecuados,Corona_Abierta,Obs_Corona_Abierta,Documentacion,Obs_Documentacion,Procedimiento_PQR,Obs_Procedimiento_PQR,Procedimiento_prueba_tramite_incompleto_incorrecto,Obs_Procedimiento_prueba_tramite_incompleto_incorrecto,Presenta_objetivo_llamada,Obs_Presenta_objetivo_llamada,Cordialidad_Comunicacion,Obs_Cordialidad_Comunicacion,Claridad_transmitir_informacion,Obs_Claridad_transmitir_informacion,Seguridad,Obs_Seguridad,Util_guion_saludo,Obs_Util_guion_saludo,Gestion_Llamada,Obs_Gestion_Llamada,Gestion_Soporte,Obs_Gestion_Soporte,Gestion_Asignacion,Obs_Gestion_Asignacion,Gestion_Cierre,Obs_Gestion_Cierre,Solucion,Obs_Solucion,Interes_escuchar,Obs_Interes_escuchar,Obs_General,reincide,obsreincide) values (@_Fc_Reg,@_Id_Usuario,@_caso,@_agente,@_grupo,@_Auditor,@_Campania,@_Amabilidad_Empatia,@_Obs_Amabilidad_Empatia,@_Colgada_Llamada,@_Obs_Colgada_Llamada,@_Real_filtros_adecuados,@_Obs_Real_filtros_adecuados,@_Corona_Abierta,@_Obs_Corona_Abierta,@_Documentacion,@_Obs_Documentacion,@_Procedimiento_PQR,@_Obs_Procedimiento_PQR,@_Procedimiento_prueba_tramite_incompleto_incorrecto,@_Obs_Procedimiento_prueba_tramite_incompleto_incorrecto,@_Presenta_objetivo_llamada,@_Obs_Presenta_objetivo_llamada,@_Cordialidad_Comunicacion,@_Obs_Cordialidad_Comunicacion,@_Claridad_transmitir_informacion,@_Obs_Claridad_transmitir_informacion,@_Seguridad,@_Obs_Seguridad,@_Util_guion_saludo,@_Obs_Util_guion_saludo,@_Gestion_Llamada,@_Obs_Gestion_Llamada,@_Gestion_Soporte,@_Obs_Gestion_Soporte,@_Gestion_Asignacion,@_Obs_Gestion_Asignacion,@_Gestion_Cierre,@_Obs_Gestion_Cierre,@_Solucion,@_Obs_Solucion,@_Interes_escuchar,@_Obs_Interes_escuchar,@_Obs_General,@_Reincide,@_Obs_Reincide)"
            cms.Parameters.Add("@_Fc_Reg", SqlDbType.DateTime).Value = _Fc_Reg
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_caso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@_agente", SqlDbType.VarChar, 50).Value = strlagente
            cms.Parameters.Add("@_grupo", SqlDbType.VarChar, 50).Value = strlgrupo
            cms.Parameters.Add("@_Auditor", SqlDbType.VarChar, 50).Value = _Auditor
            cms.Parameters.Add("@_Campania", SqlDbType.VarChar, 50).Value = _Campania
            cms.Parameters.Add("@_Amabilidad_Empatia", SqlDbType.Int).Value = _Amabilidad_Empatia
            cms.Parameters.Add("@_Obs_Amabilidad_Empatia", SqlDbType.VarChar, 750).Value = _Obs_Amabilidad_Empatia
            cms.Parameters.Add("@_Colgada_Llamada", SqlDbType.Int).Value = _Colgada_Llamada
            cms.Parameters.Add("@_Obs_Colgada_Llamada", SqlDbType.VarChar, 750).Value = _Obs_Colgada_Llamada
            cms.Parameters.Add("@_Real_filtros_adecuados", SqlDbType.Int).Value = _Real_filtros_adecuados
            cms.Parameters.Add("@_Obs_Real_filtros_adecuados", SqlDbType.VarChar, 750).Value = _Obs_Real_filtros_adecuados
            cms.Parameters.Add("@_Corona_Abierta", SqlDbType.Int).Value = _Corona_Abierta
            cms.Parameters.Add("@_Obs_Corona_Abierta", SqlDbType.VarChar, 750).Value = _Obs_Corona_Abierta
            cms.Parameters.Add("@_Documentacion", SqlDbType.Int).Value = _Documentacion
            cms.Parameters.Add("@_Obs_Documentacion", SqlDbType.VarChar, 750).Value = _Obs_Documentacion
            cms.Parameters.Add("@_Procedimiento_PQR", SqlDbType.Int).Value = _Procedimiento_PQR
            cms.Parameters.Add("@_Obs_Procedimiento_PQR", SqlDbType.VarChar, 750).Value = _Obs_Procedimiento_PQR
            cms.Parameters.Add("@_Procedimiento_prueba_tramite_incompleto_incorrecto", SqlDbType.Int).Value = _Procedimiento_prueba_tramite_incompleto_incorrecto
            cms.Parameters.Add("@_Obs_Procedimiento_prueba_tramite_incompleto_incorrecto", SqlDbType.VarChar, 750).Value = _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto
            cms.Parameters.Add("@_Presenta_objetivo_llamada", SqlDbType.Int).Value = _Presenta_objetivo_llamada
            cms.Parameters.Add("@_Obs_Presenta_objetivo_llamada", SqlDbType.VarChar, 750).Value = _Obs_Presenta_objetivo_llamada
            cms.Parameters.Add("@_Cordialidad_Comunicacion", SqlDbType.Int).Value = _Cordialidad_Comunicacion
            cms.Parameters.Add("@_Obs_Cordialidad_Comunicacion", SqlDbType.VarChar, 750).Value = _Obs_Cordialidad_Comunicacion
            cms.Parameters.Add("@_Cordialidad", SqlDbType.Int).Value = _Cordialidad
            cms.Parameters.Add("@_obs_Cordialidad", SqlDbType.VarChar, 750).Value = _obs_Cordialidad
            cms.Parameters.Add("@_Contacto_Activo", SqlDbType.Int).Value = _Contacto_Activo
            cms.Parameters.Add("@_Obs_Contacto_Activo", SqlDbType.VarChar, 750).Value = _Obs_Contacto_Activo
            cms.Parameters.Add("@_Claridad_transmitir_informacion", SqlDbType.Int).Value = _Claridad_transmitir_informacion
            cms.Parameters.Add("@_Obs_Claridad_transmitir_informacion", SqlDbType.VarChar, 750).Value = _Obs_Claridad_transmitir_informacion
            cms.Parameters.Add("@_Seguridad", SqlDbType.Int).Value = _Seguridad
            cms.Parameters.Add("@_Obs_Seguridad", SqlDbType.VarChar, 750).Value = _Obs_Seguridad
            cms.Parameters.Add("@_Util_guion_saludo", SqlDbType.Int).Value = _Util_guion_saludo
            cms.Parameters.Add("@_Obs_Util_guion_saludo", SqlDbType.VarChar, 750).Value = _Obs_Util_guion_saludo
            cms.Parameters.Add("@_Gestion_Llamada", SqlDbType.Int).Value = _Gestion_Llamada
            cms.Parameters.Add("@_Obs_Gestion_Llamada", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Llamada
            cms.Parameters.Add("@_Gestion_Soporte", SqlDbType.Int).Value = _Gestion_Soporte
            cms.Parameters.Add("@_Obs_Gestion_Soporte", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Soporte
            cms.Parameters.Add("@_Gestion_Asignacion", SqlDbType.Int).Value = _Gestion_Asignacion
            cms.Parameters.Add("@_Obs_Gestion_Asignacion", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Asignacion
            cms.Parameters.Add("@_Gestion_Cierre", SqlDbType.Int).Value = _Gestion_Cierre
            cms.Parameters.Add("@_Obs_Gestion_Cierre", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Cierre
            cms.Parameters.Add("@_Solucion", SqlDbType.VarChar, 2).Value = _Solucion
            cms.Parameters.Add("@_Obs_Solucion", SqlDbType.VarChar, 750).Value = _Obs_Solucion
            cms.Parameters.Add("@_Interes_escuchar", SqlDbType.VarChar, 2).Value = _Interes_escuchar
            cms.Parameters.Add("@_Obs_Interes_escuchar", SqlDbType.VarChar, 750).Value = _Obs_Interes_escuchar
            cms.Parameters.Add("@_Obs_General", SqlDbType.VarChar, 800).Value = _Obs_General
            cms.Parameters.Add("@_Reincide", SqlDbType.VarChar, 5).Value = _Reincide
            cms.Parameters.Add("@_Obs_Reincide", SqlDbType.VarChar, 800).Value = _obs_Reincide
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
    Public Function Consulta_Calibracion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select CR.*,UU.nombreu as NAuditor from Calibracion CR inner join usuarios UU on CR.Auditor = UU.idusuario where Id_Caso = @_Cod_Calibracion and Auditor = @_Auditor and Agente=@strlagente and Grupo=@strlgrupo"
            If _Auditor = "CONSENSO" Then
                cms.CommandText = "Select * from Calibracion where Id_Caso = @_Cod_Calibracion and Auditor = @_Auditor and Agente=@strlagente and Grupo=@strlgrupo"
            End If
            cms.Parameters.Add("@_Cod_Calibracion", SqlDbType.VarChar, 20).Value = _Cod_Calidad_Registro
            cms.Parameters.Add("@_Auditor", SqlDbType.VarChar, 20).Value = _Auditor
            cms.Parameters.Add("@strlagente", SqlDbType.VarChar, 150).Value = strlagente
            cms.Parameters.Add("@strlgrupo", SqlDbType.VarChar, 20).Value = strlgrupo

            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Id_Caso") Is DBNull.Value Then
                    strlcaso = ""
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("Id_Caso")
                End If
                If dts.Tables(0).Rows(0).Item("Grupo") Is DBNull.Value Then
                    strlgrupo = ""
                Else
                    strlgrupo = dts.Tables(0).Rows(0).Item("Grupo")
                End If
                If _Auditor <> "CONSENSO" Then
                    If dts.Tables(0).Rows(0).Item("NAuditor") Is DBNull.Value Then
                        _Auditor = ""
                    Else
                        _Auditor = dts.Tables(0).Rows(0).Item("NAuditor")
                    End If
                End If
                If dts.Tables(0).Rows(0).Item("Campania") Is DBNull.Value Then
                    _Campania = ""
                Else
                    _Campania = dts.Tables(0).Rows(0).Item("Campania")
                End If
                If dts.Tables(0).Rows(0).Item("Amabilidad_Empatia") Is DBNull.Value Then
                    _Amabilidad_Empatia = ""
                Else
                    _Amabilidad_Empatia = dts.Tables(0).Rows(0).Item("Amabilidad_Empatia")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Amabilidad_Empatia") Is DBNull.Value Then
                    _Obs_Amabilidad_Empatia = ""
                Else
                    _Obs_Amabilidad_Empatia = dts.Tables(0).Rows(0).Item("Obs_Amabilidad_Empatia")
                End If
                If dts.Tables(0).Rows(0).Item("Colgada_Llamada") Is DBNull.Value Then
                    _Colgada_Llamada = ""
                Else
                    _Colgada_Llamada = dts.Tables(0).Rows(0).Item("Colgada_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Colgada_Llamada") Is DBNull.Value Then
                    _Obs_Colgada_Llamada = ""
                Else
                    _Obs_Colgada_Llamada = dts.Tables(0).Rows(0).Item("Obs_Colgada_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Real_filtros_adecuados") Is DBNull.Value Then
                    _Real_filtros_adecuados = ""
                Else
                    _Real_filtros_adecuados = dts.Tables(0).Rows(0).Item("Real_filtros_adecuados")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Real_filtros_adecuados") Is DBNull.Value Then
                    _Obs_Real_filtros_adecuados = ""
                Else
                    _Obs_Real_filtros_adecuados = dts.Tables(0).Rows(0).Item("Obs_Real_filtros_adecuados")
                End If
                If dts.Tables(0).Rows(0).Item("Corona_Abierta") Is DBNull.Value Then
                    _Corona_Abierta = ""
                Else
                    _Corona_Abierta = dts.Tables(0).Rows(0).Item("Corona_Abierta")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Corona_Abierta") Is DBNull.Value Then
                    _Obs_Corona_Abierta = ""
                Else
                    _Obs_Corona_Abierta = dts.Tables(0).Rows(0).Item("Obs_Corona_Abierta")
                End If
                If dts.Tables(0).Rows(0).Item("Documentacion") Is DBNull.Value Then
                    _Documentacion = ""
                Else
                    _Documentacion = dts.Tables(0).Rows(0).Item("Documentacion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Documentacion") Is DBNull.Value Then
                    _Obs_Documentacion = ""
                Else
                    _Obs_Documentacion = dts.Tables(0).Rows(0).Item("Obs_Documentacion")
                End If
                If dts.Tables(0).Rows(0).Item("Procedimiento_PQR") Is DBNull.Value Then
                    _Procedimiento_PQR = ""
                Else
                    _Procedimiento_PQR = dts.Tables(0).Rows(0).Item("Procedimiento_PQR")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Procedimiento_PQR") Is DBNull.Value Then
                    _Obs_Procedimiento_PQR = ""
                Else
                    _Obs_Procedimiento_PQR = dts.Tables(0).Rows(0).Item("Obs_Procedimiento_PQR")
                End If
                If dts.Tables(0).Rows(0).Item("Procedimiento_prueba_tramite_incompleto_incorrecto") Is DBNull.Value Then
                    _Procedimiento_prueba_tramite_incompleto_incorrecto = ""
                Else
                    _Procedimiento_prueba_tramite_incompleto_incorrecto = dts.Tables(0).Rows(0).Item("Procedimiento_prueba_tramite_incompleto_incorrecto")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Procedimiento_prueba_tramite_incompleto_incorrecto") Is DBNull.Value Then
                    _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto = ""
                Else
                    _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto = dts.Tables(0).Rows(0).Item("Obs_Procedimiento_prueba_tramite_incompleto_incorrecto")
                End If
                If dts.Tables(0).Rows(0).Item("Presenta_objetivo_llamada") Is DBNull.Value Then
                    _Presenta_objetivo_llamada = ""
                Else
                    _Presenta_objetivo_llamada = dts.Tables(0).Rows(0).Item("Presenta_objetivo_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Presenta_objetivo_llamada") Is DBNull.Value Then
                    _Obs_Presenta_objetivo_llamada = ""
                Else
                    _Obs_Presenta_objetivo_llamada = dts.Tables(0).Rows(0).Item("Obs_Presenta_objetivo_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Cordialidad_Comunicacion") Is DBNull.Value Then
                    _Cordialidad_Comunicacion = ""
                Else
                    _Cordialidad_Comunicacion = dts.Tables(0).Rows(0).Item("Cordialidad_Comunicacion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Cordialidad_Comunicacion") Is DBNull.Value Then
                    _Obs_Cordialidad_Comunicacion = ""
                Else
                    _Obs_Cordialidad_Comunicacion = dts.Tables(0).Rows(0).Item("Obs_Cordialidad_Comunicacion")
                End If
                If dts.Tables(0).Rows(0).Item("Claridad_transmitir_informacion") Is DBNull.Value Then
                    _Claridad_transmitir_informacion = ""
                Else
                    _Claridad_transmitir_informacion = dts.Tables(0).Rows(0).Item("Claridad_transmitir_informacion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Claridad_transmitir_informacion") Is DBNull.Value Then
                    _Obs_Claridad_transmitir_informacion = ""
                Else
                    _Obs_Claridad_transmitir_informacion = dts.Tables(0).Rows(0).Item("Obs_Claridad_transmitir_informacion")
                End If
                If dts.Tables(0).Rows(0).Item("Seguridad") Is DBNull.Value Then
                    _Seguridad = ""
                Else
                    _Seguridad = dts.Tables(0).Rows(0).Item("Seguridad")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Seguridad") Is DBNull.Value Then
                    _Obs_Seguridad = ""
                Else
                    _Obs_Seguridad = dts.Tables(0).Rows(0).Item("Obs_Seguridad")
                End If
                If dts.Tables(0).Rows(0).Item("Util_guion_saludo") Is DBNull.Value Then
                    _Util_guion_saludo = ""
                Else
                    _Util_guion_saludo = dts.Tables(0).Rows(0).Item("Util_guion_saludo")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Util_guion_saludo") Is DBNull.Value Then
                    _Obs_Util_guion_saludo = ""
                Else
                    _Obs_Util_guion_saludo = dts.Tables(0).Rows(0).Item("Obs_Util_guion_saludo")
                End If
                If dts.Tables(0).Rows(0).Item("Gestion_Llamada") Is DBNull.Value Then
                    _Gestion_Llamada = ""
                Else
                    _Gestion_Llamada = dts.Tables(0).Rows(0).Item("Gestion_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Gestion_Llamada") Is DBNull.Value Then
                    _Obs_Gestion_Llamada = ""
                Else
                    _Obs_Gestion_Llamada = dts.Tables(0).Rows(0).Item("Obs_Gestion_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Gestion_Soporte") Is DBNull.Value Then
                    _Gestion_Soporte = ""
                Else
                    _Gestion_Soporte = dts.Tables(0).Rows(0).Item("Gestion_Soporte")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Gestion_Soporte") Is DBNull.Value Then
                    _Obs_Gestion_Soporte = ""
                Else
                    _Obs_Gestion_Soporte = dts.Tables(0).Rows(0).Item("Obs_Gestion_Soporte")
                End If
                If dts.Tables(0).Rows(0).Item("Gestion_Asignacion") Is DBNull.Value Then
                    _Gestion_Asignacion = ""
                Else
                    _Gestion_Asignacion = dts.Tables(0).Rows(0).Item("Gestion_Asignacion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Gestion_Asignacion") Is DBNull.Value Then
                    _Obs_Gestion_Asignacion = ""
                Else
                    _Obs_Gestion_Asignacion = dts.Tables(0).Rows(0).Item("Obs_Gestion_Asignacion")
                End If
                If dts.Tables(0).Rows(0).Item("Gestion_Cierre") Is DBNull.Value Then
                    _Gestion_Cierre = ""
                Else
                    _Gestion_Cierre = dts.Tables(0).Rows(0).Item("Gestion_Cierre")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Gestion_Cierre") Is DBNull.Value Then
                    _Obs_Gestion_Cierre = ""
                Else
                    _Obs_Gestion_Cierre = dts.Tables(0).Rows(0).Item("Obs_Gestion_Cierre")
                End If
                If dts.Tables(0).Rows(0).Item("Solucion") Is DBNull.Value Then
                    _Solucion = ""
                Else
                    _Solucion = dts.Tables(0).Rows(0).Item("Solucion")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Solucion") Is DBNull.Value Then
                    _Obs_Solucion = ""
                Else
                    _Obs_Solucion = dts.Tables(0).Rows(0).Item("Obs_Solucion")
                End If
                If dts.Tables(0).Rows(0).Item("Interes_escuchar") Is DBNull.Value Then
                    _Interes_escuchar = ""
                Else
                    _Interes_escuchar = dts.Tables(0).Rows(0).Item("Interes_escuchar")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Interes_escuchar") Is DBNull.Value Then
                    _Obs_Interes_escuchar = ""
                Else
                    _Obs_Interes_escuchar = dts.Tables(0).Rows(0).Item("Obs_Interes_escuchar")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_General") Is DBNull.Value Then
                    _Obs_General = ""
                Else
                    _Obs_General = dts.Tables(0).Rows(0).Item("Obs_General")
                End If
                If dts.Tables(0).Rows(0).Item("reincide") Is DBNull.Value Then
                    _Reincide = "No aplica"
                Else
                    _Reincide = dts.Tables(0).Rows(0).Item("reincide")
                End If
                If dts.Tables(0).Rows(0).Item("ObsReincide") Is DBNull.Value Then
                    _obs_Reincide = "No aplica"
                Else
                    _obs_Reincide = dts.Tables(0).Rows(0).Item("ObsReincide")
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
    Public Function ConsultaAntesDeIncluir()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "1" Then
                cms.CommandText = "select * from CalibracionSesionIncluido where Id_Usuario=@_Administrador and Fk_Cod_CalibracionSesion=@_Cod_CalibracionSesion"
                cms.Parameters.Add("@_Administrador", SqlDbType.VarChar, 10).Value = _Administrador
            End If
            If _Validacion = "2" Then
                cms.CommandText = "select * from CalibracionSesion where (Fc_Cierre is null or Fc_Cierre='') and Cod_CalibracionSesion=@_Cod_CalibracionSesion"
            End If
            cms.Parameters.Add("@_Cod_CalibracionSesion", SqlDbType.Decimal).Value = _Cod_CalibracionSesion
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
    Public Function ConsultaMacro()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select Auditor,Amabilidad_Empatia as '1',Colgada_Llamada as '2',Real_filtros_adecuados as '3',Corona_Abierta as '4',Documentacion as '5',Procedimiento_PQR as '6',Procedimiento_prueba_tramite_incompleto_incorrecto as '7',Presenta_objetivo_llamada as '8',Cordialidad_Comunicacion as '9',Claridad_transmitir_informacion as '10',Seguridad as '11',Util_guion_saludo as '12',Gestion_Llamada as '13',Gestion_Soporte as '14',Gestion_Asignacion       as '15',Gestion_Cierre     as '16', CASE WHEN(Error_Critico < 100) THEN '0' WHEN(Reincide = 'No') THEN 0 ELSE Convert(int,(Error_Critico+(SAC_Claro+Variable_Kam))/2) END as Reproducibilidad, 'Precision' as Precision from (Select *,((Amabilidad_Empatia+Colgada_Llamada+Real_filtros_adecuados+Corona_Abierta+Documentacion+Procedimiento_PQR+Procedimiento_prueba_tramite_incompleto_incorrecto)*100)/700 as Error_Critico,(((Presenta_objetivo_llamada+Cordialidad_Comunicacion+Claridad_transmitir_informacion+Seguridad+Util_guion_saludo)*100)/25)*0.6 as SAC_Claro, (((Gestion_Llamada+Gestion_Soporte+Gestion_Asignacion+Gestion_Cierre)*100)/400)*0.4 as Variable_Kam from Calibracion) as innerquery where Id_Caso=@_Id_Caso and Agente=@strlagente and Grupo=@strlgrupo"
            cms.Parameters.Add("@_Id_Caso", SqlDbType.VarChar, 10).Value = _Id_Caso
            cms.Parameters.Add("@strlagente", SqlDbType.VarChar, 150).Value = strlagente
            cms.Parameters.Add("@strlgrupo", SqlDbType.VarChar, 20).Value = strlgrupo
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
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''' Auditoria DirecTv ''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Llenar_informacionDirectv() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor from clarovoz.dbo.Directv_Calidad_Reg CR inner join datosclaro.dbo.usuarios U on CR.asesor = U.idusuario inner join datosclaro.dbo.usuarios UU on CR.Auditor = UU.idusuario   where Cod_Directv_Calidad_Reg=  @_Cod_Calidad"
            cms.Parameters.Add("@_Cod_Calidad", SqlDbType.Int).Value = Cod_Calidad_Registro
            If Validacion = 1 Then
                cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor from clarovoz.dbo.Directv_Calidad_Reg CR inner join datosclaro.dbo.usuarios U on CR.asesor = U.idusuario inner join datosclaro.dbo.usuarios UU on CR.Auditor = UU.idusuario   where Cod_Directv_Calidad_Reg=  @_Cod_Calidad and cr.asesor=@Usuario"
                cms.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = strlCodigoAgente
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Id_Caso") Is DBNull.Value Then
                    strlcaso = ""
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("Id_Caso")
                End If
                If dts.Tables(0).Rows(0).Item("NAgente") Is DBNull.Value Then
                    strlagente = ""
                Else
                    strlagente = dts.Tables(0).Rows(0).Item("NAgente")
                End If
                If dts.Tables(0).Rows(0).Item("Grupo") Is DBNull.Value Then
                    strlgrupo = ""
                Else
                    strlgrupo = dts.Tables(0).Rows(0).Item("Grupo")
                End If
                If dts.Tables(0).Rows(0).Item("Proceso") Is DBNull.Value Then
                    _Proceso = ""
                Else
                    _Proceso = dts.Tables(0).Rows(0).Item("Proceso")
                End If
                If dts.Tables(0).Rows(0).Item("NAuditor") Is DBNull.Value Then
                    _Auditor = ""
                Else
                    _Auditor = dts.Tables(0).Rows(0).Item("NAuditor")
                End If
                If dts.Tables(0).Rows(0).Item("Campania") Is DBNull.Value Then
                    _Campania = ""
                Else
                    _Campania = dts.Tables(0).Rows(0).Item("Campania")
                End If
                If dts.Tables(0).Rows(0).Item("tipificacion") Is DBNull.Value Then
                    _tipificacion = ""
                Else
                    _tipificacion = dts.Tables(0).Rows(0).Item("tipificacion")
                End If

                If dts.Tables(0).Rows(0).Item("Proceso") Is DBNull.Value Then
                    _Proceso = ""
                Else
                    _Proceso = dts.Tables(0).Rows(0).Item("Proceso")
                End If
                If dts.Tables(0).Rows(0).Item("Tiempo_Acum_Llamada") Is DBNull.Value Then
                    _Tiempo_Acum_Llamada = ""
                Else
                    _Tiempo_Acum_Llamada = dts.Tables(0).Rows(0).Item("Tiempo_Acum_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Fc_Llamada") Is DBNull.Value Then
                    _Fc_Llamada = ""
                Else
                    _Fc_Llamada = dts.Tables(0).Rows(0).Item("Fc_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("N_Llamadas_Min") Is DBNull.Value Then
                    _N_Llamadas_Min = ""
                Else
                    _N_Llamadas_Min = dts.Tables(0).Rows(0).Item("N_Llamadas_Min")
                End If
                If dts.Tables(0).Rows(0).Item("tipo_llamada") Is DBNull.Value Then
                    _tipo_llamada = ""
                Else
                    _tipo_llamada = dts.Tables(0).Rows(0).Item("tipo_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("N_Llamadas_Min") Is DBNull.Value Then
                    _N_Llamadas_Min = ""
                Else
                    _N_Llamadas_Min = dts.Tables(0).Rows(0).Item("N_Llamadas_Min")
                End If
                If dts.Tables(0).Rows(0).Item("Tipo_Auditoria") Is DBNull.Value Then
                    _Tipo_Auditoria = ""
                Else
                    _Tipo_Auditoria = dts.Tables(0).Rows(0).Item("Tipo_Auditoria")
                End If
                If dts.Tables(0).Rows(0).Item("Amabilidad_Empatia") Is DBNull.Value Then
                    _Amabilidad_Empatia = ""
                Else
                    _Amabilidad_Empatia = dts.Tables(0).Rows(0).Item("Amabilidad_Empatia")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Amabilidad_Empatia") Is DBNull.Value Then
                    _Obs_Amabilidad_Empatia = ""
                Else
                    _Obs_Amabilidad_Empatia = dts.Tables(0).Rows(0).Item("Obs_Amabilidad_Empatia")
                End If
                If dts.Tables(0).Rows(0).Item("Colgada_Llamada") Is DBNull.Value Then
                    _Colgada_Llamada = ""
                Else
                    _Colgada_Llamada = dts.Tables(0).Rows(0).Item("Colgada_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Colgada_Llamada") Is DBNull.Value Then
                    _Obs_Colgada_Llamada = ""
                Else
                    _Obs_Colgada_Llamada = dts.Tables(0).Rows(0).Item("Obs_Colgada_Llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Documentacion_toma_datos") Is DBNull.Value Then
                    _Documentación_toma_datos = ""
                Else
                    _Documentación_toma_datos = dts.Tables(0).Rows(0).Item("Documentacion_toma_datos")
                End If

                If dts.Tables(0).Rows(0).Item("Obs_Documentacion_toma_datos") Is DBNull.Value Then
                    _Obs_Documentación_toma_datos = ""
                Else
                    _Obs_Documentación_toma_datos = dts.Tables(0).Rows(0).Item("Obs_Documentacion_toma_datos")
                End If
                If dts.Tables(0).Rows(0).Item("Brindar_informacion_errada_cerrar_venta") Is DBNull.Value Then
                    _Brindar_información_errada_cerrar_venta = ""
                Else
                    _Brindar_información_errada_cerrar_venta = dts.Tables(0).Rows(0).Item("Brindar_informacion_errada_cerrar_venta")
                End If
                If dts.Tables(0).Rows(0).Item("Obs_Brindar_informacion_errada_cerrar_venta") Is DBNull.Value Then
                    _obs_Brindar_información_errada_cerrar_venta = ""
                Else
                    _obs_Brindar_información_errada_cerrar_venta = dts.Tables(0).Rows(0).Item("Obs_Brindar_informacion_errada_cerrar_venta")
                End If
                If dts.Tables(0).Rows(0).Item("Inicia_llamada_horario_saludo_identidad_motivo_llamada") Is DBNull.Value Then
                    _Inicia_llamada_horario_saludo_identidad_motivo_llamada = ""
                Else
                    _Inicia_llamada_horario_saludo_identidad_motivo_llamada = dts.Tables(0).Rows(0).Item("Inicia_llamada_horario_saludo_identidad_motivo_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada") Is DBNull.Value Then
                    _obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada = ""
                Else
                    _obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada = dts.Tables(0).Rows(0).Item("obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Realiza_preguntas_concretas_perfilar_cliente") Is DBNull.Value Then
                    _Realiza_preguntas_concretas_perfilar_cliente = ""
                Else
                    _Realiza_preguntas_concretas_perfilar_cliente = dts.Tables(0).Rows(0).Item("Realiza_preguntas_concretas_perfilar_cliente")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Realiza_preguntas_concretas_perfilar_cliente") Is DBNull.Value Then
                    _obs_Realiza_preguntas_concretas_perfilar_cliente = ""
                Else
                    _obs_Realiza_preguntas_concretas_perfilar_cliente = dts.Tables(0).Rows(0).Item("obs_Realiza_preguntas_concretas_perfilar_cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Uso_informacion") Is DBNull.Value Then
                    _Uso_información = ""
                Else
                    _Uso_información = dts.Tables(0).Rows(0).Item("Uso_informacion")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Uso_informacion") Is DBNull.Value Then
                    _obs_Uso_información = ""
                Else
                    _obs_Uso_información = dts.Tables(0).Rows(0).Item("obs_Uso_informacion")
                End If
                If dts.Tables(0).Rows(0).Item("Tiene_conocimiento_completo_producto") Is DBNull.Value Then
                    _Tiene_conocimiento_completo_producto = ""
                Else
                    _Tiene_conocimiento_completo_producto = dts.Tables(0).Rows(0).Item("Tiene_conocimiento_completo_producto")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Tiene_conocimiento_completo_producto") Is DBNull.Value Then
                    _obs_Tiene_conocimiento_completo_producto = ""
                Else
                    _obs_Tiene_conocimiento_completo_producto = dts.Tables(0).Rows(0).Item("obs_Tiene_conocimiento_completo_producto")
                End If
                If dts.Tables(0).Rows(0).Item("Aclara_dudas_tiene_cliente_acerca_servicio") Is DBNull.Value Then
                    _Aclara_dudas_tiene_cliente_acerca_servicio = ""
                Else
                    _Aclara_dudas_tiene_cliente_acerca_servicio = dts.Tables(0).Rows(0).Item("Aclara_dudas_tiene_cliente_acerca_servicio")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Aclara_dudas_tiene_cliente_acerca_servicio") Is DBNull.Value Then
                    _obs_Aclara_dudas_tiene_cliente_acerca_servicio = ""
                Else
                    _obs_Aclara_dudas_tiene_cliente_acerca_servicio = dts.Tables(0).Rows(0).Item("obs_Aclara_dudas_tiene_cliente_acerca_servicio")
                End If
                If dts.Tables(0).Rows(0).Item("Realiza_precierre_ofrece_beneficio_producto") Is DBNull.Value Then
                    _Realiza_precierre_ofrece_beneficio_producto = ""
                Else
                    _Realiza_precierre_ofrece_beneficio_producto = dts.Tables(0).Rows(0).Item("Realiza_precierre_ofrece_beneficio_producto")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Realiza_precierre_ofrece_beneficio_producto") Is DBNull.Value Then
                    _obs_Realiza_precierre_ofrece_beneficio_producto = ""
                Else
                    _obs_Realiza_precierre_ofrece_beneficio_producto = dts.Tables(0).Rows(0).Item("obs_Realiza_precierre_ofrece_beneficio_producto")
                End If
                If dts.Tables(0).Rows(0).Item("Indica_beneficios_producto") Is DBNull.Value Then
                    _Indica_beneficios_producto = ""
                Else
                    _Indica_beneficios_producto = dts.Tables(0).Rows(0).Item("Indica_beneficios_producto")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Indica_beneficios_producto") Is DBNull.Value Then
                    _obs_Indica_beneficios_producto = ""
                Else
                    _obs_Indica_beneficios_producto = dts.Tables(0).Rows(0).Item("obs_Indica_beneficios_producto")
                End If
                If dts.Tables(0).Rows(0).Item("obs_ObservacionGeneral") Is DBNull.Value Then
                    _Obs_General = ""
                Else
                    _Obs_General = dts.Tables(0).Rows(0).Item("obs_ObservacionGeneral")
                End If
                If dts.Tables(0).Rows(0).Item("Cierra_venta_tiempo_oportuno") Is DBNull.Value Then
                    _Cierra_venta_tiempo_oportuno = ""
                Else
                    _Cierra_venta_tiempo_oportuno = dts.Tables(0).Rows(0).Item("Cierra_venta_tiempo_oportuno")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Cierra_venta_tiempo_oportuno") Is DBNull.Value Then
                    _obs_Cierra_venta_tiempo_oportuno = ""
                Else
                    _obs_Cierra_venta_tiempo_oportuno = dts.Tables(0).Rows(0).Item("obs_Cierra_venta_tiempo_oportuno")
                End If
                If dts.Tables(0).Rows(0).Item("Informacion_cierre") Is DBNull.Value Then
                    _Informacion_cierre = ""
                Else
                    _Informacion_cierre = dts.Tables(0).Rows(0).Item("Informacion_cierre")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Informacion_cierre") Is DBNull.Value Then
                    _obs_Informacion_cierre = ""
                Else
                    _obs_Informacion_cierre = dts.Tables(0).Rows(0).Item("obs_Informacion_cierre")
                End If
                If dts.Tables(0).Rows(0).Item("Rebate_minimo_objeciones_negativa_cliente") Is DBNull.Value Then
                    _Rebate_minimo_objecione_negativa_cliente = ""
                Else
                    _Rebate_minimo_objecione_negativa_cliente = dts.Tables(0).Rows(0).Item("Rebate_minimo_objeciones_negativa_cliente")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Rebate_minimo_objeciones_negativa_cliente") Is DBNull.Value Then
                    _obs_Rebate_minimo_objecione_negativa_cliente = ""
                Else
                    _obs_Rebate_minimo_objecione_negativa_cliente = dts.Tables(0).Rows(0).Item("obs_Rebate_minimo_objeciones_negativa_cliente")
                End If
                If dts.Tables(0).Rows(0).Item("manejo_objeciones_coherente") Is DBNull.Value Then
                    _manejo_objeciones_coherente = ""
                Else
                    _manejo_objeciones_coherente = dts.Tables(0).Rows(0).Item("manejo_objeciones_coherente")
                End If
                If dts.Tables(0).Rows(0).Item("obs_manejo_objeciones_coherente") Is DBNull.Value Then
                    _obs_manejo_objeciones_coherente = ""
                Else
                    _obs_manejo_objeciones_coherente = dts.Tables(0).Rows(0).Item("obs_manejo_objeciones_coherente")
                End If
                If dts.Tables(0).Rows(0).Item("Retoma_llamada_tiempos_establecidos") Is DBNull.Value Then
                    _Retoma_llamada_tiempos_establecidos = ""
                Else
                    _Retoma_llamada_tiempos_establecidos = dts.Tables(0).Rows(0).Item("Retoma_llamada_tiempos_establecidos")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Retoma_llamada_tiempos_establecidos") Is DBNull.Value Then
                    _obs_Retoma_llamada_tiempos_establecidos = ""
                Else
                    _obs_Retoma_llamada_tiempos_establecidos = dts.Tables(0).Rows(0).Item("obs_Retoma_llamada_tiempos_establecidos")
                End If
                If dts.Tables(0).Rows(0).Item("evidencia_ambiente_laboral") Is DBNull.Value Then
                    _evidencia_ambiente_laboral = ""
                Else
                    _evidencia_ambiente_laboral = dts.Tables(0).Rows(0).Item("evidencia_ambiente_laboral")
                End If
                If dts.Tables(0).Rows(0).Item("obs_evidencia_ambiente_laboral") Is DBNull.Value Then
                    _obs_evidencia_ambiente_laboral = ""
                Else
                    _obs_evidencia_ambiente_laboral = dts.Tables(0).Rows(0).Item("obs_evidencia_ambiente_laboral")
                End If
                If dts.Tables(0).Rows(0).Item("Tono_voz_Fluidez_verbal") Is DBNull.Value Then
                    _Tono_Voz = ""
                Else
                    _Tono_Voz = dts.Tables(0).Rows(0).Item("Tono_voz_Fluidez_verbal")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Tono_voz_Fluidez_verbal") Is DBNull.Value Then
                    _obs_Tono_voz_Fluidez_verbal = ""
                Else
                    _obs_Tono_voz_Fluidez_verbal = dts.Tables(0).Rows(0).Item("obs_Tono_voz_Fluidez_verbal")
                End If
                If dts.Tables(0).Rows(0).Item("Personaliza_llamada") Is DBNull.Value Then
                    _Personaliza_llamada = ""
                Else
                    _Personaliza_llamada = dts.Tables(0).Rows(0).Item("Personaliza_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Personaliza_llamada") Is DBNull.Value Then
                    _obs_Personaliza_llamada = ""
                Else
                    _obs_Personaliza_llamada = dts.Tables(0).Rows(0).Item("obs_Personaliza_llamada")
                End If
                If dts.Tables(0).Rows(0).Item("Habilidad_escucha") Is DBNull.Value Then
                    _Habilidad_escucha = ""
                Else
                    _Habilidad_escucha = dts.Tables(0).Rows(0).Item("Habilidad_escucha")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Habilidad_escucha") Is DBNull.Value Then
                    _obs_Habilidad_escucha = ""
                Else
                    _obs_Habilidad_escucha = dts.Tables(0).Rows(0).Item("obs_Habilidad_escucha")
                End If
                If dts.Tables(0).Rows(0).Item("Cordialidad_empatia") Is DBNull.Value Then
                    _Cordialidad_empatia = ""
                Else
                    _Cordialidad_empatia = dts.Tables(0).Rows(0).Item("Cordialidad_empatia")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Cordialidad_empatia") Is DBNull.Value Then
                    _obs_Cordialidad_empatia = ""
                Else
                    _obs_Cordialidad_empatia = dts.Tables(0).Rows(0).Item("obs_Cordialidad_empatia")
                End If
                If dts.Tables(0).Rows(0).Item("Tipifica_apropiadamente_gestió_llamada_aplicativos") Is DBNull.Value Then
                    _Tipifica_apropiadamente_gestió_llamada_aplicativos = ""
                Else
                    _Tipifica_apropiadamente_gestió_llamada_aplicativos = dts.Tables(0).Rows(0).Item("Tipifica_apropiadamente_gestió_llamada_aplicativos")
                End If
                If dts.Tables(0).Rows(0).Item("obs_Tipifica_apropiadamente_gestió_llamada_aplicativos") Is DBNull.Value Then
                    _obs_Tipifica_apropiadamente_gestió_llamada_aplicativos = ""
                Else
                    _obs_Tipifica_apropiadamente_gestió_llamada_aplicativos = dts.Tables(0).Rows(0).Item("obs_Tipifica_apropiadamente_gestió_llamada_aplicativos")
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

    'Llena el drl de Tipificaciones
    Public Function ObtenerTipificaciones() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "select nombre from BD_Voz_Complemento where Pertenece='TipiDTV' or Pertenece= '- Seleccione -'"
            If Validacion = 1 Then 'INBOUND
                cms.CommandText = "select nombre from BD_Voz_Complemento where Pertenece='TipiDTVIN' or Pertenece= '- Seleccione -'"
            ElseIf Validacion = 2 Then 'OUTBOUND
                cms.CommandText = "select nombre from BD_Voz_Complemento where Pertenece='TipiDTVOUT' or Pertenece= '- Seleccione -'"
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
    Public Function Consulta_Caso_AgenteD() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> "" Or strlcaso <> Nothing Then
                cms.CommandText = "select u.nombreu,U.idusuario from clarovoz.dbo.Direct_TV_Caso CRM inner join datosclaro.dbo.usuarios U on CRM.Id_Agente = U.idusuario where FK_Id_Cliente=@strlcaso or U.nombreu = '- Seleccione -' group by U.idusuario,U.nombreu order by U.nombreu"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            End If

            If strlCodigoAgente <> Nothing And strlCodigoAgente <> "1" Then
                cms.CommandText = "select * from datosclaro.dbo.usuarios where codnom=@strlCodigoAgente order by nombreu"
                cms.Parameters.Add("@strlCodigoAgente", SqlDbType.VarChar, 10).Value = strlCodigoAgente
            End If
            If strlCodigoAgente = "1" Then
                cms.CommandText = "select * from datosclaro.dbo.usuarios where idusuario=@CodigoAgente order by nombreu"
                cms.Parameters.Add("@CodigoAgente", SqlDbType.VarChar, 10).Value = "fch"
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
    Public Sub Registro_Calidad_directv()
        ' Dim cn As New SqlClient.SqlConnection("Data Source=OBOG148C7093E\SQLEXPRESS;Initial Catalog=clarovoz;User ID=sa;Password=desarrollo14*")
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            _Fc_Reg = Now
            cms.CommandText = "insert into Directv_Calidad_Reg  (Fc_Reg,Id_Usuario,Id_Caso,asesor,Grupo,Auditor,Campania,Proceso,Fc_Llamada,Tiempo_Acum_Llamada,N_Llamadas_Min,tipo_llamada,tipificacion,tipo_auditoria,Amabilidad_Empatia,Obs_Amabilidad_Empatia,Colgada_Llamada,Obs_Colgada_Llamada,Documentacion_toma_datos,Obs_Documentacion_toma_datos,Brindar_informacion_errada_cerrar_venta,obs_Brindar_informacion_errada_cerrar_venta,Inicia_llamada_horario_saludo_identidad_motivo_llamada,obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada,Realiza_preguntas_concretas_perfilar_cliente,obs_Realiza_preguntas_concretas_perfilar_cliente,Uso_informacion,obs_Uso_informacion,Tiene_conocimiento_completo_producto,obs_Tiene_conocimiento_completo_producto,Indica_beneficios_producto,obs_Indica_beneficios_producto,Aclara_dudas_tiene_cliente_acerca_servicio,obs_Aclara_dudas_tiene_cliente_acerca_servicio,Realiza_precierre_ofrece_beneficio_producto,obs_Realiza_precierre_ofrece_beneficio_producto,Cierra_venta_tiempo_oportuno,obs_Cierra_venta_tiempo_oportuno,Informacion_cierre,obs_Informacion_cierre,Rebate_minimo_objeciones_negativa_cliente,obs_Rebate_minimo_objeciones_negativa_cliente,manejo_objeciones_coherente,obs_manejo_objeciones_coherente,Retoma_llamada_tiempos_establecidos,obs_Retoma_llamada_tiempos_establecidos,evidencia_ambiente_laboral,obs_evidencia_ambiente_laboral,Tono_voz_Fluidez_verbal,obs_Tono_voz_Fluidez_verbal,Personaliza_llamada,obs_Personaliza_llamada,Habilidad_escucha,obs_Habilidad_escucha,Cordialidad_empatia,obs_Cordialidad_empatia,Tipifica_apropiadamente_gestió_llamada_aplicativos,obs_Tipifica_apropiadamente_gestió_llamada_aplicativos,obs_ObservacionGeneral) values (@Fc_Reg,@Id_Usuario,@Id_Caso,@asesor,@Grupo,@Auditor,@Campania,@Proceso,@Fc_Llamada,@Tiempo_Acum_Llamada,@N_Llamadas_Min,@tipo_llamada,@tipificacion,@tipo_auditoria,@Amabilidad_Empatia,@Obs_Amabilidad_Empatia,@Colgada_Llamada,@Obs_Colgada_Llamada,@Documentacion_toma_datos,@Obs_Documentacion_toma_datos,@Brindar_informacion_errada_cerrar_venta,@obs_Brindar_informacion_errada_cerrar_venta,@Inicia_llamada_horario_saludo_identidad_motivo_llamada,@obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada,@Realiza_preguntas_concretas_perfilar_cliente,@obs_Realiza_preguntas_concretas_perfilar_cliente,@Uso_informacion,@obs_Uso_informacion,@Tiene_conocimiento_completo_producto,@obs_Tiene_conocimiento_completo_producto,@Indica_beneficios_producto,@obs_Indica_beneficios_producto,@Aclara_dudas_tiene_cliente_acerca_servicio,@obs_Aclara_dudas_tiene_cliente_acerca_servicio,@Realiza_precierre_ofrece_beneficio_producto,@obs_Realiza_precierre_ofrece_beneficio_producto,@Cierra_venta_tiempo_oportuno,@obs_Cierra_venta_tiempo_oportuno,@Informacion_cierre,@obs_Informacion_cierre,@Rebate_minimo_objeciones_negativa_cliente,@obs_Rebate_minimo_objeciones_negativa_cliente,@manejo_objeciones_coherente,@obs_manejo_objeciones_coherente,@Retoma_llamada_tiempos_establecidos,@obs_Retoma_llamada_tiempos_establecidos,@evidencia_ambiente_laboral,@obs_evidencia_ambiente_laboral,@Tono_voz_Fluidez_verbal,@obs_Tono_voz_Fluidez_verbal,@Personaliza_llamada,@obs_Personaliza_llamada,@Habilidad_escucha,@obs_Habilidad_escucha,@Cordialidad_empatia,@obs_Cordialidad_empatia,@Tipifica_apropiadamente_gestió_llamada_aplicativos,@obs_Tipifica_apropiadamente_gestió_llamada_aplicativos,@obs_ObservacionGeneral)"
            cms.Parameters.Add("@Cod_Calidad_Registro", SqlDbType.Int).Value = _Cod_Calidad_Registro
            cms.Parameters.Add("@Fc_Reg", SqlDbType.DateTime).Value = _Fc_Reg
            cms.Parameters.Add("@Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@Id_Caso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@asesor", SqlDbType.VarChar, 50).Value = strlagente
            cms.Parameters.Add("@Grupo", SqlDbType.VarChar, 50).Value = strlgrupo
            cms.Parameters.Add("@Auditor", SqlDbType.VarChar, 50).Value = _Auditor
            cms.Parameters.Add("@Campania", SqlDbType.VarChar, 50).Value = _Campania
            cms.Parameters.Add("@Proceso", SqlDbType.VarChar, 50).Value = _Proceso
            cms.Parameters.Add("@Fc_Llamada", SqlDbType.DateTime).Value = _Fc_Llamada
            cms.Parameters.Add("@Tiempo_Acum_Llamada", SqlDbType.VarChar, 50).Value = _Tiempo_Acum_Llamada
            cms.Parameters.Add("@N_Llamadas_Min", SqlDbType.Int).Value = _N_Llamadas_Min
            cms.Parameters.Add("@tipo_llamada", SqlDbType.VarChar, 50).Value = _tipo_llamada
            cms.Parameters.Add("@tipificacion", SqlDbType.VarChar, 50).Value = _tipificacion
            cms.Parameters.Add("@tipo_auditoria", SqlDbType.VarChar, 50).Value = _Tipo_Auditoria
            cms.Parameters.Add("@Amabilidad_Empatia", SqlDbType.VarChar, 50).Value = _Amabilidad_Empatia
            cms.Parameters.Add("@Obs_Amabilidad_Empatia", SqlDbType.VarChar, 50).Value = _Obs_Amabilidad_Empatia
            cms.Parameters.Add("@Colgada_Llamada", SqlDbType.Int).Value = _Colgada_Llamada
            cms.Parameters.Add("@Obs_Colgada_Llamada", SqlDbType.VarChar, 750).Value = _Obs_Colgada_Llamada
            cms.Parameters.Add("@Documentacion_toma_datos", SqlDbType.Int).Value = _Documentación_toma_datos
            cms.Parameters.Add("@Obs_Documentacion_toma_datos", SqlDbType.VarChar, 750).Value = _Obs_Documentación_toma_datos
            cms.Parameters.Add("@Brindar_informacion_errada_cerrar_venta", SqlDbType.VarChar, 10).Value = _Brindar_información_errada_cerrar_venta
            cms.Parameters.Add("@obs_Brindar_informacion_errada_cerrar_venta", SqlDbType.VarChar, 750).Value = _obs_Brindar_información_errada_cerrar_venta
            cms.Parameters.Add("@Inicia_llamada_horario_saludo_identidad_motivo_llamada", SqlDbType.VarChar, 10).Value = _Inicia_llamada_horario_saludo_identidad_motivo_llamada
            cms.Parameters.Add("@obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada", SqlDbType.VarChar, 750).Value = _obs_Inicia_llamada_horario_saludo_identidad_motivo_llamada
            cms.Parameters.Add("@Realiza_preguntas_concretas_perfilar_cliente", SqlDbType.VarChar, 10).Value = _Realiza_preguntas_concretas_perfilar_cliente
            cms.Parameters.Add("@obs_Realiza_preguntas_concretas_perfilar_cliente", SqlDbType.VarChar, 750).Value = _obs_Realiza_preguntas_concretas_perfilar_cliente
            cms.Parameters.Add("@Uso_informacion", SqlDbType.VarChar, 10).Value = _Uso_información
            cms.Parameters.Add("@obs_Uso_informacion", SqlDbType.VarChar, 750).Value = _obs_Uso_información
            cms.Parameters.Add("@Tiene_conocimiento_completo_producto", SqlDbType.VarChar, 10).Value = _Tiene_conocimiento_completo_producto
            cms.Parameters.Add("@obs_Tiene_conocimiento_completo_producto", SqlDbType.VarChar, 750).Value = _obs_Tiene_conocimiento_completo_producto
            cms.Parameters.Add("@Indica_beneficios_producto", SqlDbType.VarChar, 10).Value = _Indica_beneficios_producto
            cms.Parameters.Add("@obs_Indica_beneficios_producto", SqlDbType.VarChar, 750).Value = _obs_Indica_beneficios_producto
            cms.Parameters.Add("@Aclara_dudas_tiene_cliente_acerca_servicio", SqlDbType.VarChar, 10).Value = _Aclara_dudas_tiene_cliente_acerca_servicio
            cms.Parameters.Add("@obs_Aclara_dudas_tiene_cliente_acerca_servicio", SqlDbType.VarChar, 750).Value = _obs_Aclara_dudas_tiene_cliente_acerca_servicio
            cms.Parameters.Add("@Realiza_precierre_ofrece_beneficio_producto", SqlDbType.VarChar, 10).Value = _Realiza_precierre_ofrece_beneficio_producto
            cms.Parameters.Add("@obs_Realiza_precierre_ofrece_beneficio_producto", SqlDbType.VarChar, 750).Value = _obs_Realiza_precierre_ofrece_beneficio_producto
            cms.Parameters.Add("@Cierra_venta_tiempo_oportuno", SqlDbType.VarChar, 10).Value = _Cierra_venta_tiempo_oportuno
            cms.Parameters.Add("@obs_Cierra_venta_tiempo_oportuno", SqlDbType.VarChar, 750).Value = _obs_Cierra_venta_tiempo_oportuno
            cms.Parameters.Add("@Informacion_cierre", SqlDbType.VarChar, 10).Value = _Informacion_cierre
            cms.Parameters.Add("@obs_Informacion_cierre", SqlDbType.VarChar, 750).Value = _obs_Informacion_cierre
            cms.Parameters.Add("@Rebate_minimo_objeciones_negativa_cliente", SqlDbType.VarChar, 10).Value = _Rebate_minimo_objecione_negativa_cliente
            cms.Parameters.Add("@obs_Rebate_minimo_objeciones_negativa_cliente", SqlDbType.VarChar, 750).Value = _obs_Rebate_minimo_objecione_negativa_cliente
            cms.Parameters.Add("@manejo_objeciones_coherente", SqlDbType.VarChar, 10).Value = _manejo_objeciones_coherente
            cms.Parameters.Add("@obs_manejo_objeciones_coherente", SqlDbType.VarChar, 750).Value = _obs_manejo_objeciones_coherente
            cms.Parameters.Add("@Retoma_llamada_tiempos_establecidos", SqlDbType.VarChar, 10).Value = _Retoma_llamada_tiempos_establecidos
            cms.Parameters.Add("@obs_Retoma_llamada_tiempos_establecidos", SqlDbType.VarChar, 750).Value = _obs_Retoma_llamada_tiempos_establecidos
            cms.Parameters.Add("@evidencia_ambiente_laboral", SqlDbType.VarChar, 10).Value = _evidencia_ambiente_laboral
            cms.Parameters.Add("@obs_evidencia_ambiente_laboral", SqlDbType.VarChar, 750).Value = _obs_evidencia_ambiente_laboral
            cms.Parameters.Add("@Tono_voz_Fluidez_verbal", SqlDbType.VarChar, 10).Value = _Tono_Voz
            cms.Parameters.Add("@obs_Tono_voz_Fluidez_verbal", SqlDbType.VarChar, 750).Value = _obs_Tono_voz_Fluidez_verbal
            cms.Parameters.Add("@Personaliza_llamada", SqlDbType.VarChar, 10).Value = _Personaliza_llamada
            cms.Parameters.Add("@obs_Personaliza_llamada", SqlDbType.VarChar, 750).Value = _obs_Personaliza_llamada
            cms.Parameters.Add("@Habilidad_escucha", SqlDbType.VarChar, 10).Value = _Habilidad_escucha
            cms.Parameters.Add("@obs_Habilidad_escucha", SqlDbType.VarChar, 750).Value = _obs_Habilidad_escucha
            cms.Parameters.Add("@Cordialidad_empatia", SqlDbType.VarChar, 10).Value = _Cordialidad_empatia
            cms.Parameters.Add("@obs_Cordialidad_empatia", SqlDbType.VarChar, 750).Value = _obs_Cordialidad_empatia
            cms.Parameters.Add("@Tipifica_apropiadamente_gestió_llamada_aplicativos", SqlDbType.VarChar, 10).Value = _Tipifica_apropiadamente_gestió_llamada_aplicativos
            cms.Parameters.Add("@obs_Tipifica_apropiadamente_gestió_llamada_aplicativos", SqlDbType.VarChar, 750).Value = _obs_Tipifica_apropiadamente_gestió_llamada_aplicativos
            cms.Parameters.Add("@obs_ObservacionGeneral", SqlDbType.VarChar, 750).Value = _Obs_General
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

    'Realiza el calculo para obtener resultado de calidad sobredirectv 
    Public Function Consulta_Auditorias_De() As DataTable
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Id_Usuario <> Nothing Then
                cms.CommandText = "Select DC.*,u.codnom,U.nombreu,(DC.Amabilidad_Empatia+DC.Colgada_Llamada+DC.Documentacion_toma_datos+DC.Brindar_informacion_errada_cerrar_venta)/4 as Error_Critico from clarovoz.dbo.Directv_Calidad_Reg DC inner join datosclaro.dbo.usuarios u on u.idusuario=DC.asesor where codnom= @_Id_Usuario"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
                If Validacion = 1 Then
                    cms.CommandText = "Select DC.*,u.codnom,U.nombreu,(DC.Amabilidad_Empatia+DC.Colgada_Llamada+DC.Documentacion_toma_datos+DC.Brindar_informacion_errada_cerrar_venta)/4 as Error_Critico from clarovoz.dbo.Directv_Calidad_Reg DC inner join datosclaro.dbo.usuarios u on u.idusuario=DC.asesor where dc.asesor=@_Id_Usuario order by Cod_DirecTv_Calidad_Reg desc"
                    cms.Parameters.Add("@uusuario", SqlDbType.VarChar, 10).Value = strlCodigoAgente
                End If
            End If
            If _Id_Usuario = Nothing Then
                cms.CommandText = "Select DC.*,u.codnom,U.nombreu,(DC.Amabilidad_Empatia+DC.Colgada_Llamada+DC.Documentacion_toma_datos+DC.Brindar_informacion_errada_cerrar_venta)/4 as Error_Critico from clarovoz.dbo.Directv_Calidad_Reg DC inner join datosclaro.dbo.usuarios u on u.idusuario=DC.asesor where Fc_Reg Between @strlfcini and @strlfcfin"
                cms.Parameters.Add("@strlfcini", SqlDbType.Date).Value = strlfcini
                cms.Parameters.Add("@strlfcfin", SqlDbType.Date).Value = strlfcfin
            End If
            If _Id_Usuario <> "" And _Id_Usuario <> "0" And strlfcini <> Nothing And strlfcfin <> Nothing Then
                cms.CommandText = "Select DC.*,u.codnom,U.nombreu,(DC.Amabilidad_Empatia+DC.Colgada_Llamada+DC.Documentacion_toma_datos+DC.Brindar_informacion_errada_cerrar_venta)/4 as Error_Critico from clarovoz.dbo.Directv_Calidad_Reg DC inner join datosclaro.dbo.usuarios u on u.idusuario=DC.asesor where Fc_Reg Between @strlfcini and @strlfcfin and codnom= @_Id_Usuario"
                cms.Parameters.Add("@strlfcini", SqlDbType.Date).Value = strlfcini
                cms.Parameters.Add("@strlfcfin", SqlDbType.Date).Value = strlfcfin
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            Dim dt As DataTable = dts.Tables(0)
            Dim dt2 As New DataTable
            Dim column As DataColumn
            Dim row As DataRow
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Cod Calidad"
            dt2.Columns.Add(column)
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Fecha Auditoria"
            dt2.Columns.Add(column)
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Asesor"
            dt2.Columns.Add(column)
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Codigo"
            dt2.Columns.Add(column)
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Tipo Llamada"
            dt2.Columns.Add(column)

            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "No Criticos"
            dt2.Columns.Add(column)
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Criticos"
            dt2.Columns.Add(column)
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Total"
            dt2.Columns.Add(column)

            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Tipo Auditoria"
            dt2.Columns.Add(column)

            For Each dr As DataRow In dt.Rows
                Dim resultado1Na As Double
                Dim Contador As Integer
                Dim resultado As Double
                Dim resultado2 As Double
                For i = 0 To 1 Step 1
                    If dr("Inicia_llamada_horario_saludo_identidad_motivo_llamada").ToString = "NA" And i = 0 Then
                        resultado1Na = 10
                    ElseIf dr("Inicia_llamada_horario_saludo_identidad_motivo_llamada").ToString = "100" Then
                        Contador = Contador + 1
                        If i = 1 Then
                            resultado = 10 + resultado2
                        End If
                    ElseIf dr("Inicia_llamada_horario_saludo_identidad_motivo_llamada").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Realiza_preguntas_concretas_perfilar_cliente").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 8
                    ElseIf dr("Realiza_preguntas_concretas_perfilar_cliente").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (8 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Realiza_preguntas_concretas_perfilar_cliente").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Uso_informacion").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 7
                    ElseIf dr("Uso_informacion").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (7 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Uso_informacion").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Tiene_conocimiento_completo_producto").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 7
                    ElseIf dr("Tiene_conocimiento_completo_producto").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (7 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Tiene_conocimiento_completo_producto").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Indica_beneficios_producto").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 5
                    ElseIf dr("Indica_beneficios_producto").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (5 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Indica_beneficios_producto").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Aclara_dudas_tiene_cliente_acerca_servicio").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 5
                    ElseIf dr("Aclara_dudas_tiene_cliente_acerca_servicio").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (5 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Aclara_dudas_tiene_cliente_acerca_servicio").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Realiza_precierre_ofrece_beneficio_producto").ToString = "NA" And i = 0 Then

                        resultado1Na = resultado1Na + 5
                    ElseIf dr("Realiza_precierre_ofrece_beneficio_producto").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (5 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Realiza_precierre_ofrece_beneficio_producto").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Cierra_venta_tiempo_oportuno").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 5
                    ElseIf dr("Cierra_venta_tiempo_oportuno").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (5 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Cierra_venta_tiempo_oportuno").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Informacion_cierre").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 5
                    ElseIf dr("Informacion_cierre").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (5 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Informacion_cierre").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Rebate_minimo_objeciones_negativa_cliente").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 7
                    ElseIf dr("Rebate_minimo_objeciones_negativa_cliente").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (7 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Rebate_minimo_objeciones_negativa_cliente").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("manejo_objeciones_coherente").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 6
                    ElseIf dr("manejo_objeciones_coherente").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (6 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("manejo_objeciones_coherente").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Retoma_llamada_tiempos_establecidos").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 2
                    ElseIf dr("Retoma_llamada_tiempos_establecidos").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (2 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Retoma_llamada_tiempos_establecidos").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("evidencia_ambiente_laboral").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 3
                    ElseIf dr("evidencia_ambiente_laboral").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (3 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("evidencia_ambiente_laboral").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Tono_voz_Fluidez_verbal").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 7
                    ElseIf dr("Tono_voz_Fluidez_verbal").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (7 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Tono_voz_Fluidez_verbal").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Personaliza_llamada").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 3
                    ElseIf dr("Personaliza_llamada").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (3 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Personaliza_llamada").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Habilidad_escucha").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 5
                    ElseIf dr("Habilidad_escucha").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (5 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Habilidad_escucha").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Cordialidad_empatia").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 5
                    ElseIf dr("Cordialidad_empatia").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + (5 + resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Cordialidad_empatia").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    If dr("Tipifica_apropiadamente_gestió_llamada_aplicativos").ToString = "NA" And i = 0 Then
                        resultado1Na = resultado1Na + 5
                    ElseIf dr("Tipifica_apropiadamente_gestió_llamada_aplicativos").ToString = "100" Then
                        If i = 1 Then
                            resultado = resultado + 5 + (resultado2)
                        End If
                        Contador = Contador + 1
                    ElseIf dr("Tipifica_apropiadamente_gestió_llamada_aplicativos").ToString = "0" Then
                        Contador = Contador + 1
                    End If
                    resultado2 = resultado1Na / Contador
                    Contador = 0
                Next
                row = dt2.NewRow()
                row("Cod Calidad") = dr("Cod_Directv_Calidad_Reg").ToString
                row("Fecha Auditoria") = dr("Fc_reg").ToString
                row("Codigo") = dr("codnom").ToString
                row("tipo llamada") = dr("tipo_llamada").ToString
                row("Asesor") = dr("nombreu").ToString
                row("No Criticos") = resultado.ToString("##,##0.00")
                row("Criticos") = dr("Error_Critico").ToString
                If dr("Error_Critico").ToString = 100 Then
                    row("Total") = resultado.ToString("##,##0.00")
                Else
                    row("Total") = 0
                End If
                row("Tipo Auditoria") = dr("tipo_auditoria").ToString
                dt2.Rows.Add(row)
                resultado = 0
                resultado1Na = 0
                Contador = 0

            Next
            strlcantidad = dt2.Rows.Count
            Return dt2
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consulta_RegistroDirectv() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Directv_Calidad_Reg where Fc_Reg=@Fc_Reg and Id_Usuario=@_Id_Usuario and Id_Caso=@_caso and asesor=@_agente and Grupo=@_grupo and Auditor=@_Auditor"
            cms.Parameters.Add("@Fc_Reg", SqlDbType.DateTime).Value = _Fc_Reg
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_caso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@_agente", SqlDbType.VarChar, 50).Value = strlagente
            cms.Parameters.Add("@_grupo", SqlDbType.VarChar, 50).Value = strlgrupo
            cms.Parameters.Add("@_Auditor", SqlDbType.VarChar, 50).Value = _Auditor
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Directv_Calidad_Reg") Is DBNull.Value Then
                    _Cod_Calidad_Registro = 0
                Else
                    _Cod_Calidad_Registro = dts.Tables(0).Rows(0).Item("Cod_Directv_Calidad_Reg")
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
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''' Segundo Concepto '''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function segundoconceptocaso() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Auditoria <> Nothing Then
                cms.CommandText = "SELECT a.Proceso,a.Cod_Calidad_Registro,isnull(convert(varchar(10),c.Cod_Retroalimentacion),'No Tiene') as Retro,a.Agente,Id_Caso,a.fc_Reg FROM   Calidad_Registro a full JOIN(select * from Retroalimentacion_Calidad d where d.fc_reg=(select  max(Fc_Reg) as fecha from Retroalimentacion_Calidad p where p.Id_Auditoria=d.Id_Auditoria)) b ON a.Cod_Calidad_Registro = b.Id_Auditoria left JOIN Retroalimentacion_Calidad c ON c.Cod_Retroalimentacion = b.Cod_Retroalimentacion AND c.Fc_Reg = b.Fc_Reg where a.Cod_Calidad_Registro=@strlId_Auditoria"
                cms.Parameters.Add("@strlId_Auditoria", SqlDbType.VarChar, 50).Value = Me.Auditoria
            End If
            If Validacion = 1 Then
                cms.CommandText = "SELECT * FROM segundo_concepto WHERE Estado = 'pendiente'  UNION ALL SELECT * FROM segundo_concepto WHERE Estado <> 'pendiente'"

            End If
            If Validacion = 5 Then
                cms.CommandText = "SELECT * FROM segundo_concepto WHERE Estado = 'pendiente'  and Auditor=@Id_Usuario UNION ALL SELECT * FROM segundo_concepto WHERE Estado <> 'pendiente' and Estado <> 'No Aplica'  and Auditor=@Id_Usuario"
                cms.Parameters.Add("@Id_Usuario", SqlDbType.VarChar, 50).Value = Me.Id_Usuario
            End If
            If Validacion = 6 Then
                cms.CommandText = "select * from usuarios where cargo like  'QA%' order by nombreu  asc"
            End If
            If Validacion = 7 Then
                cms.CommandText = "select * from segundo_concepto where id_auditoria=@Codigo"
                cms.Parameters.Add("@Codigo", SqlDbType.BigInt).Value = _Codigo_reg
            End If
            If Validacion = 8 Then
                cms.CommandText = "SELECT * FROM segundo_concepto WHERE Estado = 'pendiente'  and Id_Usuario=@idusuario  UNION ALL SELECT * FROM segundo_concepto WHERE Estado <> 'pendiente' and Id_Usuario=@idusuario"
                cms.Parameters.Add("@idusuario", SqlDbType.VarChar, 20).Value = _Id_Usuario
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            If Validacion = 2 Then
                If dtsrecepcion.Tables(0).Rows.Count > 0 Then
                    Proceso = dtsrecepcion.Tables(0).Rows(0).Item("Proceso")
                End If
            End If
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If Validacion = 7 Then
                If dtsrecepcion.Tables(0).Rows.Count > 0 Then
                    Estado = dtsrecepcion.Tables(0).Rows(0).Item("Estado")
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
    Public Sub registrosegundoconcepto()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If Validacion = 3 Then
                cms.CommandText = "update Segundo_Concepto set auditor=@auditor,estado='Asignado',Fc_Asignacion=@fechaA where codigo_reg=@codigo_reg"
                cms.Parameters.Add("@codigo_reg", SqlDbType.BigInt).Value = _Codigo_reg
                cms.Parameters.Add("@auditor", SqlDbType.VarChar, 50).Value = _Auditor
                cms.Parameters.Add("@fechaA", SqlDbType.DateTime).Value = Now
            ElseIf Validacion = 4 Then
                cms.CommandText = "update Segundo_Concepto set Estado='No Aplica', auditor=@auditor,Fc_Respuesta=@fechaR,Fc_Asignacion=@fechaA where codigo_reg=@codigo_reg"
                cms.Parameters.Add("@fechaA", SqlDbType.DateTime).Value = Now
                cms.Parameters.Add("@fechaR", SqlDbType.DateTime).Value = Now
                cms.Parameters.Add("@codigo_reg", SqlDbType.BigInt).Value = _Codigo_reg
                cms.Parameters.Add("@auditor", SqlDbType.VarChar, 50).Value = _razon
            ElseIf Validacion = 6 Then
                cms.CommandText = "update Segundo_Concepto set Estado='Ratifica',ObservacionAuditor=@ObservacionAudi,Fc_Respuesta=@fechaA  where codigo_reg=@codigo_reg "
                cms.Parameters.Add("@codigo_reg", SqlDbType.BigInt).Value = _Codigo_reg
                cms.Parameters.Add("@ObservacionAudi", SqlDbType.VarChar, 750).Value = Observacion_Auditor
                cms.Parameters.Add("@fechaA", SqlDbType.DateTime).Value = Now
            ElseIf Validacion = 7 Then
                cms.CommandText = "update Segundo_Concepto set Estado='No Ratifica',ObservacionAuditor=@ObservacionAudi,Fc_Respuesta=@fechaA where codigo_reg=@codigo_reg"
                cms.Parameters.Add("@codigo_reg", SqlDbType.BigInt).Value = _Codigo_reg
                cms.Parameters.Add("@ObservacionAudi", SqlDbType.VarChar, 750).Value = Observacion_Auditor
                cms.Parameters.Add("@fechaA", SqlDbType.DateTime).Value = Now
            Else
                cms.CommandText = "INSERT INTO Segundo_Concepto(Fc_Reg,Id_Usuario,Razon,Asistio,Observacion,Estado,Id_Auditoria,Proceso) values(@fc_reg,@id_usuario,@razon,@asistio,@observacion,@estado,@Id_Auditoria,@Proceso)"
                cms.Parameters.Add("@fc_reg", SqlDbType.DateTime).Value = _Fc_Reg
                cms.Parameters.Add("@id_usuario", SqlDbType.VarChar, 40).Value = _Id_Usuario
                cms.Parameters.Add("@razon", SqlDbType.VarChar, 40).Value = _razon
                cms.Parameters.Add("@asistio", SqlDbType.VarChar, 30).Value = _asistio
                cms.Parameters.Add("@observacion", SqlDbType.VarChar, 750).Value = _Observacion
                cms.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = _Estado
                cms.Parameters.Add("@Id_Auditoria", SqlDbType.BigInt).Value = _Auditoria
                cms.Parameters.Add("@Proceso", SqlDbType.VarChar, 50).Value = Proceso
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
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''' Bandeja Auditorias ''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''Realizo una función con multiples consultas a las bases de datos 
    Public Function UsuariosBandeja() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dts As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            cn.Open()

            If Validacion = 1 And strlnivel = "" And cantidad = 0 Then
                cms.CommandText = "select p.turno,U.idusuario,U.codnom,U.nombreu,supervisor from datosclaro.dbo.usuarios U inner join admin_cham.dbo.Personal P on p.codigo=u.codnom where supervisor =@Coordinador  and u.cargo <>'Retirado' and codnom like 'c%' and auditor_Asignado is null"
                cms.Parameters.Add("@Coordinador", SqlDbType.VarChar, 20).Value = _Nombre
            End If
            If Validacion = 1 And cantidad <> 0 Then
                If cantidad < 0 Then
                    cantidad = 0
                End If
                cms.CommandText = "select top " + cantidad + "p.turno,U.idusuario,U.codnom,U.nombreu,supervisor from datosclaro.dbo.usuarios U inner join admin_cham.dbo.Personal P on p.codigo=u.codnom where supervisor =@Coordinador  and u.cargo <>'Retirado' and codnom like 'c%' and auditor_Asignado is null"
                cms.Parameters.Add("@Coordinador", SqlDbType.VarChar, 20).Value = _Nombre
            End If
            If Validacion = 1 And strlnivel <> "" And cantidad = 0 Then
                cms.CommandText = "select  p.turno,U.idusuario,U.codnom,U.nombreu,supervisor from datosclaro.dbo.usuarios U inner join admin_cham.dbo.Personal P on p.codigo=u.codnom where supervisor =@Coordinador and turno=@turno  and u.cargo <>'Retirado' and codnom like 'c%' and auditor_Asignado is null"
                cms.Parameters.Add("@Turno", SqlDbType.VarChar, 20).Value = strlnivel
                cms.Parameters.Add("@Coordinador", SqlDbType.VarChar, 20).Value = _Nombre
            End If
            If Validacion = 1 And strlnivel <> "" And cantidad <> 0 Then
                cms.CommandText = "select  top " + cantidad + " p.turno,U.idusuario,U.codnom,U.nombreu,supervisor from datosclaro.dbo.usuarios U inner join admin_cham.dbo.Personal P on p.codigo=u.codnom where supervisor =@Coordinador1 and turno=@turno  and u.cargo <>'Retirado' and codnom like 'c%' and auditor_Asignado is null"
                cms.Parameters.Add("@Turno", SqlDbType.VarChar, 20).Value = strlnivel
                cms.Parameters.Add("@Coordinador1", SqlDbType.VarChar, 20).Value = _Nombre
            End If
            If Validacion = 3 Then
                cms.CommandText = "select turno from admin_cham.dbo.personal group by turno order by turno"
            End If
            If Validacion = 4 Then
                cms.CommandText = "select nombreu,idusuario from datosclaro.dbo.usuarios where cargo like '%QA%' or idusuario ='fch' order by nombreu"
            End If
            If Validacion = 5 Then
                cms.CommandText = "select turno from admin_cham.dbo.personal where turno <>'null' group by turno order by turno"
            End If
            If Validacion = 6 Then
                cms.CommandText = "select codnom,nombreu,idusuario,auditor_asignado  from datosclaro.dbo.usuarios where auditor_Asignado=@auditor order by auditor_Asignado"
                cms.Parameters.Add("@Auditor", SqlDbType.VarChar, 20).Value = _Auditor
            End If
            If Validacion = 7 Then
                cms.CommandText = "select * from datosclaro.dbo.usuarios where auditor_Asignado is not null order by auditor_Asignado"
            End If
            If Validacion = 8 Then
                cms.CommandText = "select u.*,isnull(c.auditorias,0) as auditorias  from (Select DATENAME(month,getdate()) as mes,u.codnom,u.nombreu,u.idusuario,u.auditor_Asignado  from datosclaro.dbo.usuarios U  where U.auditor_Asignado=@Auditor1  group by u.idusuario,u.auditor_Asignado,u.nombreu,u.codnom) as u left join (select count(fc_reg) as auditorias,Agente,Auditor from datosclaro.dbo.Calidad_Registro where  (month(fc_reg) =datepart(month,getdate())  and year(fc_reg)=datepart(YEAR,getdate())) group by agente ,auditor) as C  on U.idusuario = C.Agente order by auditorias asc"
                cms.Parameters.Add("@Auditor1", SqlDbType.VarChar, 20).Value = _Auditor
            End If
            If Validacion = 9 Then
                cms.CommandText = "select nombre from clarovoz.dbo.BD_Voz_Complemento where Pertenece='CalidadAsigAuditorias'"
            End If
            If Validacion = 10 Then
                cms.CommandText = "select top 1  a.idcrm as idcrm1,c.idcrm,c.idusuario,c.idcaso,c.bandeja from (select idusuario,idcaso,Tipificacion,idcrm,fcreg,'Datos' as Bandeja from datosclaro.dbo.CRMDetalle union select  idusuario,VCRM.idcaso,BU.estado,idcrm,fcreg,'Voz'as Bandeja  from clarovoz.dbo.vCRMDetalle VCRM LEFT join clarovoz.dbo.Bandeja_uni Bu on Bu.idcaso=VCRM.idcaso union select Id_Usuario,Fk_Id_Bandeja,Tipificacion , Id_CRM_Falla_Desactivacion_D_V,Fc_Reg_Ges,'Fidelizacion'as Bandeja from datosclaro.dbo.CRM_Falla_Desactivacion_D_V union select idusuario,idcasodilo,Tipificacion,idcrmdilo,fcregistro,'Dilo' as Bandeja from datosclaro.dbo.CRMdilo union select idusuario,idcaso, tipificacion,idcrm,fcreg,'Bienvenida' AS Bandeja from datosclaro.dbo.CRM_Bienvenida ) c inner join datosclaro.dbo.usuarios u on u.idusuario=c.idusuario left join datosclaro.dbo.Calidad_Registro  cr on cr.Id_Caso=c.idcrm  and cr.Agente=c.idusuario left join datosclaro.dbo.AsignacionAuditorias A on a.idcrm =c.idcrm  where c.idusuario=@Agente and u.auditor_Asignado=@Auditor3 and CONVERT(date,fcreg)=CONVERT(date,DATEADD(day, -1, getdate())) and tipificacion in(" + tipificacion + ") and cr.Id_Caso is null and a.idcrm is null group by c.idusuario,c.idcrm,a.idcrm,c.idcaso,c.bandeja order by  NEWID()"
                cms.Parameters.Add("@Auditor3", SqlDbType.VarChar, 20).Value = _Auditor
                cms.Parameters.Add("@Agente", SqlDbType.VarChar, 20).Value = agente
            End If
            If Validacion = 11 Then
                cms.CommandText = "select * from datosclaro.dbo.AsignacionAuditorias where auditado='no' and Auditor=@Auditor2 and (convert(date,fechaAsignacion) = convert(date,getdate())  or (asigna<>@Auditor2 and auditado='no')) order by ingeniero "
                cms.Parameters.Add("@Auditor2", SqlDbType.VarChar, 20).Value = _Auditor
            End If
            If Validacion = 12 Then
                cms.CommandText = " select  max(n1.cantidad)as  Mayor,n1.auditor_Asignado  from ( Select isnull(convert(varchar(10),DATENAME(month,Fc_Reg)),DATENAME(month,getdate())) as mes,u.codnom,u.nombreu,u.idusuario,count(Cod_Calidad_Registro) cantidad,u.auditor_Asignado  from datosclaro.dbo.usuarios U left  join datosclaro.dbo.Calidad_Registro C on U.auditor_Asignado = C.Auditor and U.idusuario = C.Agente  where U.auditor_Asignado=@auditor3 and (month(fc_reg) =datepart(month,getdate()) and year(fc_reg)=datepart(YEAR,getdate()) or Fc_Reg is null) group by u.idusuario,u.auditor_Asignado,Fc_Reg,u.nombreu,u.codnom) as n1 group by n1.auditor_asignado"
                cms.Parameters.Add("@Auditor3", SqlDbType.VarChar, 20).Value = _Auditor
            End If
            If Validacion = 13 Then
                cms.CommandText = "select count(codigoasignacion) as asignados from datosclaro.dbo.AsignacionAuditorias where asigna<>@Auditor4  and auditado='no'"
                cms.Parameters.Add("@Auditor4", SqlDbType.VarChar, 20).Value = _Auditor
            End If
            If Validacion = 14 Then
                cms.CommandText = "  select * from datosclaro.dbo.AsignacionAuditorias where  auditado='No' and Auditor=@Auditor5 and  asigna<>@Auditor5"
                cms.Parameters.Add("@Auditor5", SqlDbType.VarChar, 20).Value = _Auditor
            End If
            If Validacion = 15 Then
                cms.CommandText = "select * from datosclaro.dbo.AsignacionAuditorias  where Auditor=@Auditor6 and Asigna=@Auditor6 and (convert(date,fechaAsignacion) = convert(date,getdate()))"
                cms.Parameters.Add("@Auditor6", SqlDbType.VarChar, 20).Value = _Auditor
            End If
            If Validacion = 17 Then
                cms.CommandText = "select * from (select idcrm,idcaso,idusuario,'Datos' as Bandeja from datosclaro.dbo.CRMDetalle union select idcrm, idcaso,idusuario,'Voz' as Bandeja from clarovoz.dbo.vCRMDetalle VCRM union select Id_CRM_Falla_Desactivacion_D_V,Fk_Id_Bandeja,Id_Usuario,'Fidelizacion'as Bandeja from datosclaro.dbo.CRM_Falla_Desactivacion_D_V union select idcrmdilo,idcasodilo,idusuario,'Dilo' as Bandeja from datosclaro.dbo.CRMdilo union select idcrm,idcaso,idusuario,'Bienvenida' AS Bandeja  from datosclaro.dbo.CRM_Bienvenida) as c where idcaso =@Caso"
                cms.Parameters.Add("@Caso", SqlDbType.VarChar, 20).Value = strlcaso
            End If
            If Validacion = 18 Then
                cms.CommandText = "select * from datosclaro.dbo.crmdetalle where idcrm=@Caso1"
                cms.Parameters.Add("@Caso1", SqlDbType.BigInt).Value = caso
            End If
            If Validacion = 19 Then
                cms.CommandText = "SELECT * from datosclaro.dbo.asignacionAuditorias where idcrm =@Caso2 and auditado = 'No' and caso=@CasoAuditar"
                cms.Parameters.Add("@Caso2", SqlDbType.BigInt).Value = caso
                cms.Parameters.Add("@CasoAuditar", SqlDbType.BigInt).Value = Id_Caso
            End If
            If Validacion = 20 Then
                cms.CommandText = "SELECT * from datosclaro.dbo.bd_datos_complemento where pertenece= 'EstadoCalidadAuditorias'"
            End If
            If Validacion = 21 Then
                cms.CommandText = "select top 1  a.idcrm as idcrm1,c.idcrm,c.idusuario,c.idcaso,c.bandeja from (select idusuario,idcaso,Tipificacion,idcrm,fcreg,'Datos' as Bandeja from datosclaro.dbo.CRMDetalle union select  idusuario,VCRM.idcaso,BU.estado,idcrm,fcreg,'Voz'as Bandeja  from clarovoz.dbo.vCRMDetalle VCRM LEFT join clarovoz.dbo.Bandeja_uni Bu on Bu.idcaso=VCRM.idcaso union select Id_Usuario,Fk_Id_Bandeja,Tipificacion , Id_CRM_Falla_Desactivacion_D_V,Fc_Reg_Ges,'Fidelizacion'as Bandeja from datosclaro.dbo.CRM_Falla_Desactivacion_D_V union select idusuario,idcasodilo,Tipificacion,idcrmdilo,fcregistro,'Dilo' as Bandeja from datosclaro.dbo.CRMdilo union select idusuario,idcaso, tipificacion,idcrm,fcreg,'Bienvenida' AS Bandeja from datosclaro.dbo.CRM_Bienvenida ) c inner join datosclaro.dbo.usuarios u on u.idusuario=c.idusuario left join datosclaro.dbo.Calidad_Registro  cr on cr.Id_Caso=c.idcrm  and cr.Agente=c.idusuario left join datosclaro.dbo.AsignacionAuditorias A on a.idcrm =c.idcrm  where c.idusuario=@Agente21 and u.auditor_Asignado=@Auditor21 and CONVERT(date,fcreg)=CONVERT(date,getdate()) and tipificacion in(" + tipificacion + ") and cr.Id_Caso is null and a.idcrm is null group by c.idusuario,c.idcrm,a.idcrm,c.idcaso,c.bandeja order by  NEWID()"
                cms.Parameters.Add("@Auditor21", SqlDbType.VarChar, 20).Value = _Auditor
                cms.Parameters.Add("@Agente21", SqlDbType.VarChar, 20).Value = agente
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If Validacion = 9 Then
                strlcantidad = dts.Tables(0).Rows(0).Item("nombre")
            End If
            If Validacion = 12 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    strlcantidad = dts.Tables(0).Rows(0).Item("mayor")
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


    ''Se realizo el siguiente método para asignar el auditor a un grupo de ingenieros 
    Public Sub AsignarAuditor()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "update usuarios set auditor_Asignado=@auditor where idusuario=@idusuario and codnom=@CodigoC"
            cms.Parameters.Add("@auditor", SqlDbType.VarChar, 20).Value = _Auditor
            cms.Parameters.Add("@idusuario", SqlDbType.VarChar, 20).Value = _Id_Usuario
            cms.Parameters.Add("@CodigoC", SqlDbType.VarChar, 20).Value = strlCodigoAgente
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
    ''Se realizo una function para liberar ingenieros al auditor seleccionado 
    Public Sub LiberarAuditor()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "update usuarios set auditor_Asignado=null where idusuario =@idUsuario and codnom=@CodigoC"
            cms.Parameters.Add("@idUsuario", SqlDbType.VarChar, 20).Value = _Id_Usuario
            cms.Parameters.Add("@CodigoC", SqlDbType.VarChar, 20).Value = strlCodigoAgente
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
    ''Se realizo el siguiente método para insertar las auditorias 
    Public Sub IngresarAuditoria()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If Validacion = 1 Then
                cms.CommandText = "UPDATE AsignacionAuditorias SET auditor ='Liberado Por',asigna=@Asigna where codigoasignacion=@Caso "
            Else
                cms.CommandText = "insert into AsignacionAuditorias (auditor,idcrm,asigna,bandeja,ingeniero,caso) values(@idUsuario,@Caso,@Asigna,@Bandeja,@Ingeniero,@idcaso)"
                cms.Parameters.Add("@idUsuario", SqlDbType.VarChar, 20).Value = Auditor
                cms.Parameters.Add("@Bandeja", SqlDbType.VarChar, 50).Value = Campania
                cms.Parameters.Add("@idcaso", SqlDbType.NVarChar, 18).Value = Id_Caso
                cms.Parameters.Add("@Ingeniero", SqlDbType.VarChar, 50).Value = agente
            End If
            cms.Parameters.Add("@Asigna", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@Caso", SqlDbType.BigInt).Value = strlcaso
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

    ''Se realizo el siguiente metodo para actualizar y fijar la meta de auditorias 
    Public Sub ActualizarMeta()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "update BD_Voz_Complemento set nombre=@Cantidad where pertenece='CalidadAsigAuditorias'"
            cms.Parameters.Add("@Cantidad", SqlDbType.VarChar, 30).Value = cantidad
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
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''' Calidad V3 ''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim _Total_Atencion As Integer
    Dim _Total_Gestion As Integer
    Dim _Total_Solucion As Integer
    Dim _Total_Cierre As Integer

    Public Property Total_Cierre As Integer
        Get
            Return _Total_Cierre
        End Get
        Set(ByVal value As Integer)
            _Total_Cierre = value
        End Set
    End Property
    Public Property Total_Solucion As Integer
        Get
            Return _Total_Solucion
        End Get
        Set(ByVal value As Integer)
            _Total_Solucion = value
        End Set
    End Property
    Public Property Total_Gestion As Integer
        Get
            Return _Total_Gestion
        End Get
        Set(ByVal value As Integer)
            _Total_Gestion = value
        End Set
    End Property
    Public Property Total_Atencion As Integer
        Get
            Return _Total_Atencion
        End Get
        Set(ByVal value As Integer)
            _Total_Atencion = value
        End Set
    End Property
    Public Sub Registro_Auditoria_Calidad_V3()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "insert into Calidad_Registro_V3(Tipo_Cliente_Fk_Id_Calidad_Complementos, Tipo_PQR_Fk_Id_Calidad_Complementos, id_Usuario,Id_Caso,Agente ,Grupo ,Auditor ,Campania ,Proceso ,Fc_Llamada ,Tiempo_Acum_Llamada ,N_Llamadas_Min ,Estado_Caso ,Tipo_Auditoria ,Manejo_Guion , Obs_Manejo_Guion ,Disponibilidad_Atender_Llamada ,Obs_Disponibilidad_Atender_Llamada , Cordialidad_Comunicacion ,Obs_Cordialidad_Comunicacion ,Claridad_Transmitir_Informacion ,Obs_Claridad_Transmitir_Informacion , Contacto_Activo ,Obs_Contacto_Activo ,Corona_Abierta ,Obs_Corona_Abierta ,Amabilidad_Empatia ,Obs_Amabilidad_Empatia ,Filtros_Eficiencia_Gestion ,Obs_Filtros_Eficiencia_Gestion ,Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones ,Obs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones ,Escucha_Activa ,Obs_Escucha_Activa ,Documentacion_Sistema ,Obs_Documentacion_Sistema ,Cuelgue_Llamada ,Obs_Cuelgue_Llamada ,Aplicacion_Manejo_Incompleto_Procedmientos_Tramites,Obs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites ,Aplicacion_Manejo_Correcto_Procedimientos_Tramites ,Obs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites ,Resolucion_Necesidad_Cliente ,Obs_Resolucion_Necesidad_Cliente ,Procedimiento_Pqr ,Obs_Procedimiento_Pqr ,Escalamientos_Requeridos ,Obs_Escalamientos_Requeridos ,Solucion_Primer_Contacto,Obs_Solucion_Primer_Contacto ,Solucion_Parcial,Obs_Solucion_Parcial,Obs_General,Total_Atencion,Total_Gestion,Total_Solucion,Total_Cierre,Cliente_Satisfecho,Reporta_Inconsistencia ) values (@_Id_Tipo_Cliente, @_Id_Tipo_PQR, @_Id_Usuario, @strlcaso,@strlagente,@strlgrupo,@_Auditor,@_Campania,@_Proceso,@_Fc_Llamada,@_Tiempo_Acum_Llamada,@_N_Llamadas_Min,@_Estado_Caso,@_Tipo_Auditoria,@_Manejo_Guion , @_Obs_Manejo_Guion,  @_Disponibilidad_Atender_Llamada ,@_Obs_Disponibilidad_Atender_Llamada ,@_Cordialidad_Comunicacion ,@_Obs_Cordialidad_Comunicacion ,@_Claridad_Transmitir_Informacion ,@_Obs_Claridad_Transmitir_Informacion ,@_Contacto_Activo ,@_Obs_Contacto_Activo ,@_Corona_Abierta ,@_Obs_Corona_Abierta ,@_Amabilidad_Empatia ,@_Obs_Amabilidad_Empatia ,@_Filtros_Eficiencia_Gestion ,@_Obs_Filtros_Eficiencia_Gestion ,@_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones ,@_Obs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones ,@_Escucha_Activa ,@_Obs_Escucha_Activa ,@_Documentacion_Sistema ,@_Obs_Documentacion_Sistema ,@_Cuelgue_Llamada ,@_Obs_Cuelgue_Llamada , @_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites,@_Obs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites ,@_Aplicacion_Manejo_Correcto_Procedimientos_Tramites ,@_Obs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites ,@_Resolucion_Necesidad_Cliente ,@_Obs_Resolucion_Necesidad_Cliente ,@_Procedimiento_Pqr ,@_Obs_Procedimiento_Pqr , @_Escalamientos_Requeridos ,@_Obs_Escalamientos_Requeridos ,@_Solucion_Primer_Contacto , @_Obs_Solucion_Primer_Contacto,@_Solucion_Parcial, @_Obs_Solucion_Parcial, @_Obs_General,@_Total_Atencion,@_Total_Gestion,@_Total_Solucion,@_Total_Cierre,@_Satisfaccion,'" & _Reporta_Inc & "')"
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlagente", SqlDbType.VarChar, 50).Value = strlagente
            cms.Parameters.Add("@strlgrupo", SqlDbType.VarChar, 50).Value = strlgrupo
            cms.Parameters.Add("@_Auditor", SqlDbType.VarChar, 50).Value = _Auditor
            cms.Parameters.Add("@_Campania", SqlDbType.VarChar, 50).Value = _Campania
            cms.Parameters.Add("@_Proceso", SqlDbType.VarChar, 50).Value = _Proceso
            cms.Parameters.Add("@_Fc_Llamada", SqlDbType.DateTime).Value = _Fc_Llamada
            cms.Parameters.Add("@_Tiempo_Acum_Llamada", SqlDbType.VarChar, 50).Value = _Tiempo_Acum_Llamada
            cms.Parameters.Add("@_N_Llamadas_Min", SqlDbType.Int).Value = _N_Llamadas_Min
            cms.Parameters.Add("@_Estado_Caso", SqlDbType.VarChar, 50).Value = _Estado_Caso
            cms.Parameters.Add("@_Tipo_Auditoria", SqlDbType.VarChar, 50).Value = _Tipo_Auditoria
            cms.Parameters.Add("@_Manejo_Guion", SqlDbType.Int).Value = _Procedimiento_prueba_tramite_incompleto_incorrecto
            cms.Parameters.Add("@_Obs_Manejo_Guion", SqlDbType.VarChar, 750).Value = _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto
            cms.Parameters.Add("@_Disponibilidad_Atender_Llamada", SqlDbType.Int).Value = _Amabilidad_Empatia
            cms.Parameters.Add("@_Obs_Disponibilidad_Atender_Llamada", SqlDbType.VarChar, 750).Value = _Obs_Amabilidad_Empatia
            cms.Parameters.Add("@_Cordialidad_Comunicacion", SqlDbType.Int).Value = _Colgada_Llamada
            cms.Parameters.Add("@_Obs_Cordialidad_Comunicacion", SqlDbType.VarChar, 750).Value = _Obs_Colgada_Llamada
            cms.Parameters.Add("@_Claridad_Transmitir_Informacion", SqlDbType.Int).Value = _Real_filtros_adecuados
            cms.Parameters.Add("@_Obs_Claridad_Transmitir_Informacion", SqlDbType.VarChar, 750).Value = _Obs_Real_filtros_adecuados
            cms.Parameters.Add("@_Contacto_Activo", SqlDbType.Int).Value = _Seguridad
            cms.Parameters.Add("@_Obs_Contacto_Activo", SqlDbType.VarChar, 750).Value = _Obs_Seguridad
            cms.Parameters.Add("@_Corona_Abierta", SqlDbType.Int).Value = _Corona_Abierta
            cms.Parameters.Add("@_Obs_Corona_Abierta", SqlDbType.VarChar, 750).Value = _Obs_Corona_Abierta
            cms.Parameters.Add("@_Amabilidad_Empatia", SqlDbType.Int).Value = _Procedimiento_PQR
            cms.Parameters.Add("@_Obs_Amabilidad_Empatia", SqlDbType.VarChar, 750).Value = _Obs_Procedimiento_PQR
            cms.Parameters.Add("@_Filtros_Eficiencia_Gestion", SqlDbType.Int).Value = _Presenta_objetivo_llamada
            cms.Parameters.Add("@_Obs_Filtros_Eficiencia_Gestion", SqlDbType.VarChar, 750).Value = _Obs_Presenta_objetivo_llamada
            cms.Parameters.Add("@_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones", SqlDbType.Int).Value = _Cordialidad_Comunicacion
            cms.Parameters.Add("@_Obs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones", SqlDbType.VarChar, 750).Value = _Obs_Cordialidad_Comunicacion
            cms.Parameters.Add("@_Escucha_Activa", SqlDbType.Int).Value = _Cordialidad
            cms.Parameters.Add("@_obs_Escucha_Activa", SqlDbType.VarChar, 750).Value = _obs_Cordialidad
            cms.Parameters.Add("@_Documentacion_Sistema", SqlDbType.Int).Value = _Documentacion
            cms.Parameters.Add("@_Obs_Documentacion_Sistema", SqlDbType.VarChar, 750).Value = _Obs_Documentacion
            cms.Parameters.Add("@_Cuelgue_Llamada", SqlDbType.Int).Value = _Claridad_transmitir_informacion
            cms.Parameters.Add("@_Obs_Cuelgue_Llamada", SqlDbType.VarChar, 750).Value = _Obs_Claridad_transmitir_informacion
            cms.Parameters.Add("@_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites", SqlDbType.Int).Value = _Gestion_Asignacion
            cms.Parameters.Add("@_Obs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Asignacion
            cms.Parameters.Add("@_Aplicacion_Manejo_Correcto_Procedimientos_Tramites", SqlDbType.Int).Value = _Gestion_Llamada
            cms.Parameters.Add("@_Obs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Llamada
            cms.Parameters.Add("@_Resolucion_Necesidad_Cliente", SqlDbType.Int).Value = _Gestion_Soporte
            cms.Parameters.Add("@_Obs_Resolucion_Necesidad_Cliente", SqlDbType.VarChar, 750).Value = _Obs_Gestion_Soporte
            cms.Parameters.Add("@_Procedimiento_Pqr", SqlDbType.VarChar, 3).Value = _Solucion
            cms.Parameters.Add("@_Obs_Procedimiento_Pqr", SqlDbType.VarChar, 750).Value = _Obs_Solucion
            cms.Parameters.Add("@_Escalamientos_Requeridos", SqlDbType.VarChar, 3).Value = _Interes_escuchar
            cms.Parameters.Add("@_Obs_Escalamientos_Requeridos", SqlDbType.VarChar, 750).Value = _Obs_Interes_escuchar
            cms.Parameters.Add("@_Solucion_Primer_Contacto", SqlDbType.VarChar, 5).Value = _Contacto_Activo
            cms.Parameters.Add("@_Obs_Solucion_Primer_Contacto", SqlDbType.VarChar, 750).Value = _Obs_Contacto_Activo
            cms.Parameters.Add("@_Solucion_Parcial", SqlDbType.VarChar, 5).Value = _Reincide
            cms.Parameters.Add("@_Obs_Solucion_Parcial", SqlDbType.VarChar, 800).Value = _obs_Reincide
            cms.Parameters.Add("@_Obs_General", SqlDbType.VarChar, 800).Value = _Obs_General
            cms.Parameters.Add("@_Total_Atencion", SqlDbType.Int).Value = _Total_Atencion
            cms.Parameters.Add("@_Total_Gestion", SqlDbType.Int).Value = _Total_Gestion
            cms.Parameters.Add("@_Total_Solucion", SqlDbType.Int).Value = _Total_Solucion
            cms.Parameters.Add("@_Total_Cierre", SqlDbType.Int).Value = _Total_Cierre
            cms.Parameters.Add("@_Satisfaccion", SqlDbType.VarChar, 2).Value = strlsatisfaccion
            cms.Parameters.AddWithValue("@_Id_Tipo_PQR", _Id_Tipo_PQR)
            cms.Parameters.AddWithValue("@_Id_Tipo_Cliente", _Id_Tipo_Cliente)

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
    Public Function Consulta_Registro_V3() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Calidad_Registro_V3 where Id_Usuario=@_Id_Usuario and Id_Caso=@_caso and Agente=@_agente and Grupo=@_grupo and Auditor=@_Auditor order by Cod_Calidad_Registro_V3 desc"
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            cms.Parameters.Add("@_caso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@_agente", SqlDbType.VarChar, 50).Value = strlagente
            cms.Parameters.Add("@_grupo", SqlDbType.VarChar, 50).Value = strlgrupo
            cms.Parameters.Add("@_Auditor", SqlDbType.VarChar, 50).Value = _Auditor
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                If dts.Tables(0).Rows(0).Item("Cod_Calidad_Registro_V3") Is DBNull.Value Then
                    _Cod_Calidad_Registro = 0
                Else
                    _Cod_Calidad_Registro = dts.Tables(0).Rows(0).Item("Cod_Calidad_Registro_V3")
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
     Public Function Consulta_Auditorias_Agente_V3() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()

            If _Id_Usuario <> Nothing Then
                _Id_Usuario = " and U.idusuario='" & _Id_Usuario & "'"
            End If
            If strlfcini <> Nothing And strlfcfin <> Nothing Then
                strlfcini = " and Fc_Reg >='" & strlfcini & "'"
                strlfcfin = " and Fc_Reg <= '" & strlfcfin & "'"
            End If
            If _Campania <> Nothing Then
                _Campania = " and Proceso='" & _Campania & "'"
            End If
            If strlCodigoAgente <> Nothing Then
                strlCodigoAgente = " and codnom='" & strlCodigoAgente & "' "
            End If
            cms.CommandText = "SELECT Cod_Calidad_Registro_V3 as [Cod_Aud],Fc_Reg,codnom as [Cod],nombreu as [Nombre],Id_Caso as [Caso], Estado_Caso as [Estado],C.Proceso,Manejo_Guion as [MG],Disponibilidad_Atender_Llamada as [DLL],Cordialidad_Comunicacion as [C&B],Claridad_Transmitir_Informacion as [CTI],Contacto_Activo as [Cac],Corona_Abierta as [Cab],Amabilidad_Empatia as [A&E],Filtros_Eficiencia_Gestion as [F&EG],Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones as [INT&S],Escucha_Activa as [EA],Documentacion_Sistema as [DocS],Cuelgue_Llamada as [CLL],Aplicacion_Manejo_Incompleto_Procedmientos_Tramites as [Pinc],Aplicacion_Manejo_Correcto_Procedimientos_Tramites as [PCorr],Resolucion_Necesidad_Cliente as [Res],Procedimiento_Pqr as [Ppqr],Escalamientos_Requeridos as [Ereq],Convert(Decimal(18,0),(Convert(Decimal(18,2),(Total_Atencion*100))/22)) as T_Aten,Convert(Decimal(18,0),(Convert(Decimal(18,2),(Total_Gestion*100))/29))  as T_Ges,Convert(Decimal(18,0),(Convert(Decimal(18,2),(Total_Solucion*100))/29))  as T_Sol,Convert(Decimal(18,0),(Convert(Decimal(18,2),(Total_Cierre*100))/20))  as T_Cie,(Total_Atencion+Total_Gestion+Total_Solucion+Total_Cierre) as Tot_Gen  FROM Calidad_Registro_V3 C inner join usuarios U on C.Agente=U.idusuario where Cod_Calidad_Registro_V3 is not null " & strlfcini & strlfcfin & _Id_Usuario & _Campania & strlCodigoAgente & " order by Fc_Reg desc"
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

        Public Function Llenar_TextBox_V3() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            cn.Open()
            cms.Parameters.Add("@_Cod_Calidad", SqlDbType.Int).Value = Cod_Calidad_Registro
            cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor, Cc.Nombre As Tipo_Cliente, Cp.Nombre As Tipo_PQR from Calidad_Registro_V3 CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario Left Join Calidad_Registro_Complemento Cc On Cc.Cod_Calidad_Registro_Complemento = Cr.Tipo_Cliente_Fk_Id_Calidad_Complementos Left Join Calidad_Registro_Complemento Cp On Cp.Cod_Calidad_Registro_Complemento = Cr.Tipo_PQR_Fk_Id_Calidad_Complementos where Cod_Calidad_Registro_V3 = @_Cod_Calidad"
            If _Validacion = "1" Then
                cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor, Cc.Nombre As Tipo_Cliente, Cp.Nombre As Tipo_PQR from Calidad_Registro_V3 CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario Left Join Calidad_Registro_Complemento Cc On Cc.Cod_Calidad_Registro_Complemento = Cr.Tipo_Cliente_Fk_Id_Calidad_Complementos Left Join Calidad_Registro_Complemento Cp On Cp.Cod_Calidad_Registro_Complemento = Cr.Tipo_PQR_Fk_Id_Calidad_Complementos where UU.cargo like '%Q%' and Cod_Calidad_Registro_V3 = @_Cod_Calidad and CR.Agente = @_Id_Usuario"
                cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = _Id_Usuario
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows.Count > 0 Then
                _Tipo_PQR = dts.Tables(0).Rows(0).Item("Tipo_PQR").ToString
                _Tipo_Cliente = dts.Tables(0).Rows(0).Item("Tipo_Cliente").ToString
                strlcaso = dts.Tables(0).Rows(0).Item("Id_Caso").ToString
                strlagente = dts.Tables(0).Rows(0).Item("Nagente").ToString
                strlgrupo = dts.Tables(0).Rows(0).Item("Grupo").ToString
                _Auditor = dts.Tables(0).Rows(0).Item("NAuditor").ToString
                _Campania = dts.Tables(0).Rows(0).Item("Campania").ToString
                _Proceso = dts.Tables(0).Rows(0).Item("Proceso").ToString
                _Tiempo_Acum_Llamada = dts.Tables(0).Rows(0).Item("Tiempo_Acum_Llamada").ToString
                _Fc_Llamada = dts.Tables(0).Rows(0).Item("Fc_Llamada").ToString
                _N_Llamadas_Min = dts.Tables(0).Rows(0).Item("N_Llamadas_Min").ToString
                _Estado_Caso = dts.Tables(0).Rows(0).Item("Estado_Caso").ToString
                _Tipo_Auditoria = dts.Tables(0).Rows(0).Item("Tipo_Auditoria").ToString
                _Amabilidad_Empatia = dts.Tables(0).Rows(0).Item("Manejo_Guion").ToString
                _Obs_Amabilidad_Empatia = dts.Tables(0).Rows(0).Item("Obs_Manejo_Guion").ToString
                _Colgada_Llamada = dts.Tables(0).Rows(0).Item("Disponibilidad_Atender_Llamada").ToString
                _Obs_Colgada_Llamada = dts.Tables(0).Rows(0).Item("Obs_Disponibilidad_Atender_Llamada").ToString
                _Real_filtros_adecuados = dts.Tables(0).Rows(0).Item("Cordialidad_Comunicacion").ToString
                _Obs_Real_filtros_adecuados = dts.Tables(0).Rows(0).Item("Obs_Cordialidad_Comunicacion").ToString
                _Corona_Abierta = dts.Tables(0).Rows(0).Item("Claridad_Transmitir_Informacion").ToString
                _Obs_Corona_Abierta = dts.Tables(0).Rows(0).Item("Obs_Claridad_Transmitir_Informacion").ToString
                _Documentacion = dts.Tables(0).Rows(0).Item("Contacto_Activo").ToString
                _Obs_Documentacion = dts.Tables(0).Rows(0).Item("Obs_Contacto_Activo").ToString
                _Procedimiento_PQR = dts.Tables(0).Rows(0).Item("Corona_Abierta").ToString
                _Obs_Procedimiento_PQR = dts.Tables(0).Rows(0).Item("Obs_Corona_Abierta").ToString
                _Procedimiento_prueba_tramite_incompleto_incorrecto = dts.Tables(0).Rows(0).Item("Amabilidad_Empatia").ToString
                _Obs_Procedimiento_prueba_tramite_incompleto_incorrecto = dts.Tables(0).Rows(0).Item("Obs_Amabilidad_Empatia").ToString
                _Presenta_objetivo_llamada = dts.Tables(0).Rows(0).Item("Filtros_Eficiencia_Gestion").ToString
                _Obs_Presenta_objetivo_llamada = dts.Tables(0).Rows(0).Item("Obs_Filtros_Eficiencia_Gestion").ToString
                _Cordialidad_Comunicacion = dts.Tables(0).Rows(0).Item("Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones").ToString
                _Obs_Cordialidad_Comunicacion = dts.Tables(0).Rows(0).Item("Obs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones").ToString
                _Cordialidad = dts.Tables(0).Rows(0).Item("Escucha_Activa").ToString
                _obs_Cordialidad = dts.Tables(0).Rows(0).Item("Obs_Escucha_Activa").ToString
                _Contacto_Activo = dts.Tables(0).Rows(0).Item("Documentacion_Sistema").ToString
                _Obs_Contacto_Activo = dts.Tables(0).Rows(0).Item("Obs_Documentacion_Sistema").ToString
                _Claridad_transmitir_informacion = dts.Tables(0).Rows(0).Item("Cuelgue_Llamada").ToString
                _Obs_Claridad_transmitir_informacion = dts.Tables(0).Rows(0).Item("Obs_Cuelgue_Llamada").ToString
                _Gestion_Llamada = dts.Tables(0).Rows(0).Item("Aplicacion_Manejo_Incompleto_Procedmientos_Tramites").ToString
                _Obs_Gestion_Llamada = dts.Tables(0).Rows(0).Item("Obs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites").ToString
                _Gestion_Soporte = dts.Tables(0).Rows(0).Item("Aplicacion_Manejo_Correcto_Procedimientos_Tramites").ToString
                _Obs_Gestion_Soporte = dts.Tables(0).Rows(0).Item("Obs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites").ToString
                _Gestion_Asignacion = dts.Tables(0).Rows(0).Item("Resolucion_Necesidad_Cliente").ToString
                _Obs_Gestion_Asignacion = dts.Tables(0).Rows(0).Item("Obs_Resolucion_Necesidad_Cliente").ToString
                _Solucion = dts.Tables(0).Rows(0).Item("Procedimiento_PQR").ToString
                _Obs_Solucion = dts.Tables(0).Rows(0).Item("Obs_Procedimiento_PQR").ToString
                _Interes_escuchar = dts.Tables(0).Rows(0).Item("Escalamientos_Requeridos").ToString
                _Obs_Interes_escuchar = dts.Tables(0).Rows(0).Item("Obs_Escalamientos_Requeridos").ToString
                _Obs_General = dts.Tables(0).Rows(0).Item("Obs_General").ToString
                _Tono_Voz = dts.Tables(0).Rows(0).Item("Solucion_Primer_contacto").ToString
                _obs_Tono_voz_Fluidez_verbal = dts.Tables(0).Rows(0).Item("Obs_Solucion_Primer_contacto").ToString
                _Reincide = dts.Tables(0).Rows(0).Item("Solucion_Parcial").ToString
                _obs_Reincide = dts.Tables(0).Rows(0).Item("Obs_Solucion_Parcial").ToString
                strlsatisfaccion = dts.Tables(0).Rows(0).Item("Cliente_Satisfecho").ToString
                _Reporta_Inc = dts.Tables(0).Rows(0).Item("Reporta_Inconsistencia").ToString
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


    'Gestion de PQR
    Public Function Consulta_Archivo_Tipo_Solicitud() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "Respuesta" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece='Respuesta_PQR' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If _Validacion = "tip_solicitud" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece='Calidad_justificacion' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If _Validacion = "estado_registro" Then
                cms.CommandText = "select * from Archivo_Complemento where Nombre <> 'Abierto' and Pertenece='Calidad_estado' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If _Validacion = "estado_consulta" Then
                cms.CommandText = "select * from Archivo_Complemento where Pertenece='Calidad_estado' or Pertenece = '- Seleccione -' order by Nombre"
            End If
            If _Validacion = "buscar_id" Then
                cms.CommandText = "SELECT MAX(Id_Caso) AS id  from  Justificacion"
            End If
            If _Validacion = "mis_casos" Then
                cms.CommandText = "SELECT * from Justificacion where Usuario = @usuario order by Id_Caso"
                cms.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = _Nombre
            End If
            '-----------------------------------------filtros de consulta-------------------------------------------------
            If _Validacion = "buscar_todos" Then
                cms.CommandText = "SELECT * from Justificacion order by Id_Caso"
            End If
            If _Validacion = "filtros" Then
                If _Estado <> Nothing Then 'consulta por estado
                    cms.CommandText = "SELECT * from Justificacion where Estado=@estado order by Id_Caso"
                    cms.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = _Estado
                End If
                If _Fc_Creacion <> Nothing Then 'consulta por fecha inicio
                    cms.CommandText = "SELECT * from Justificacion where CONVERT(date,Fc_Reg) = @fc_registra order by Id_Caso"
                    cms.Parameters.Add("@fc_registra", SqlDbType.VarChar, 10).Value = _Fc_Creacion
                End If
                If _Nombre <> Nothing Then 'consulta por ing
                    cms.CommandText = "SELECT * from Justificacion where Ing_Claro=@ing order by Id_Caso"
                    cms.Parameters.Add("@ing", SqlDbType.VarChar, 50).Value = _Nombre
                End If
                If _Fc_Cierre <> Nothing Then ' consulta por fecha fin 
                    cms.CommandText = "SELECT * from Justificacion where CONVERT(date,Fc_Reg) <=@fc_cierre order by Id_Caso"
                    cms.Parameters.Add("@fc_cierre", SqlDbType.VarChar, 10).Value = _Fc_Cierre
                End If
                If _Fc_Cierre <> Nothing And _Fc_Creacion <> Nothing Then ' consulta por fechas 
                    cms.CommandText = "SELECT * from Justificacion where CONVERT(date,Fc_Reg) >= @fc_registra and  CONVERT(date,Fc_Reg) <= @fc_cierre order by Id_Caso"
                    If _Nombre <> Nothing And _Fc_Cierre <> Nothing And _Fc_Creacion <> Nothing And _Estado <> Nothing Then
                        cms.CommandText = "SELECT * from Justificacion where CONVERT(date,Fc_Reg) >= @fc_registra and  CONVERT(date,Fc_Reg) <= @fc_cierre and Ing_Claro=@ing order by Id_Caso"
                    End If
                End If
                cms.CommandText = "SELECT * from Justificacion where CONVERT(date,Fc_Reg) >= @fc_registro and  CONVERT(date,Fc_Reg) <= @fc_cierre and Ing_Claro=@ing and Estado=@estado order by Id_Caso"
            Else
                If _Nombre <> Nothing And _Fc_Cierre <> Nothing And _Fc_Creacion <> Nothing Then 'consulta por ing y fechas
                End If
                If _Nombre <> Nothing And _Estado <> Nothing Then 'consulta por ing y estados
                    cms.CommandText = "SELECT * from Justificacion where Estado=@estado and Ing_Claro=@ing order by Id_Caso"
                End If
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Codigo_reg = dts.Tables(0).Rows.Count
            If _Validacion = "buscar_id" Then
                _Codigo_reg = dts.Tables(0).Rows(0).Item("id")
            End If
            If dts.Tables(0).Rows.Count = 0 Then
                Validacion = "1"
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

    Public Function Consulta_Caso() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Justificacion where Id_Caso  = @id_caso "
            If _Validacion = "consulta seguimiento" Then
                cms.CommandText = "select * from Historial_Justificacion where Id_Caso  = @id_caso "
            End If
            cms.Parameters.Add("@id_caso", SqlDbType.VarChar, 40).Value = _Id_Caso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            _Codigo_reg = dts.Tables(0).Rows.Count
            If dts.Tables(0).Rows.Count <= 0 Then
                Validacion = "No hay caso"
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

    Public Sub registro_caso()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO Justificacion (Fc_Ingreso_Caso,Estado,Usuario,Ing_Claro,Tipo_Solicitud,Observacion) values(@fc_registro,'Abierto',@usuario,@ing,@tipo_solicitud,@observaciones)"
            cms.Parameters.Add("@fc_registro", SqlDbType.VarChar, 10).Value = _Fc_Llamada
            cms.Parameters.Add("@ing", SqlDbType.VarChar, 50).Value = _Nombre
            cms.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = _Obs_General
            cms.Parameters.Add("@tipo_solicitud", SqlDbType.VarChar, 50).Value = strltipo
            cms.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = _asistio
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

    Public Sub registro_historial()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "insert into Historial_Justificacion (Id_Caso,Id_Usuario,Estado,Observacion,Respuesta) values (@id,@usuario,@estado,@observaciones,@respuesta)"
            If Validacion = "Actualiza" Then
                cms.CommandText = "update Justificacion set Estado=@estado, Numero_Solicitudes=@numero_solicitudes , N_Grabaciones = @numero_grabaciones ,Respuesta = @Respuesta where Id_Caso=@id "
            End If
            If Validacion = "Actualiza1" Then
                cms.CommandText = "update Justificacion set Estado=@estado,Fc_Envio = @fc_registro ,Respuesta = @Respuesta where Id_Caso=@id "
            End If
            If Validacion = "Actualiza2" Then
                cms.CommandText = "update Justificacion set Estado=@estado ,Fc_Entrega= @fc_registro ,Numero_Solicitudes=@numero_solicitudes , N_Grabaciones = @numero_grabaciones ,Respuesta = @Respuesta where Id_Caso=@id "
            End If
            cms.Parameters.Add("@id", SqlDbType.BigInt).Value = _Codigo_reg
            If Fc_Llamada <> Nothing Then
                cms.Parameters.Add("@fc_registro", SqlDbType.DateTime).Value = _Fc_Llamada
            End If
            cms.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = _asistio
            cms.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = _Estado
            If Obs_General <> Nothing Then
                cms.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = _Obs_General
            End If
            If _Invita <> Nothing Then
                cms.Parameters.Add("@numero_solicitudes", SqlDbType.VarChar, 6).Value = _Invita
            End If
            If _Invitado <> Nothing Then
                cms.Parameters.Add("@numero_grabaciones", SqlDbType.VarChar, 6).Value = _Invitado
            End If
            If _razon <> Nothing Then
                cms.Parameters.Add("@Respuesta", SqlDbType.VarChar, 50).Value = _razon
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

    Public Function Seguimiento_Retro() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Auditor <> "" Then
                _Auditor = " and C.Auditor='" + _Auditor + "'"
            Else
                _Auditor = ""
            End If
            If strlagente <> "" Then
                strlagente = " and C.Agente='" + strlagente + "'"
            Else
                strlagente = ""
            End If
            If _Proceso <> "" Then
                _Proceso = " and C.Proceso='" + _Proceso + "'"
            Else
                _Proceso = ""
            End If
            If _Estado <> "" Then
                Select Case _Estado
                    Case "Caducado"
                        _Estado = " and (DATEDIFF(hour,C.fc_reg,getdate())>=24 and (total_Atencion+total_gestion+total_solucion+total_cierre)<=85 OR DATEDIFF(hour,C.fc_reg,getdate())>=48 and (total_Atencion+total_gestion+total_solucion+total_cierre)>85 ) and RC.Id_Auditoria is null and RCR.id_aud is null"
                    Case "Vigente"
                        _Estado = " and (DATEDIFF(hour,C.fc_reg,getdate())<=24 and (total_Atencion+total_gestion+total_solucion+total_cierre)<=85 OR DATEDIFF(hour,C.fc_reg,getdate())<=48 and (total_Atencion+total_gestion+total_solucion+total_cierre)>85 ) and RC.Id_Auditoria is null and RCR.id_aud is null"
                    Case "Realizado"
                        _Estado = " and RC.Id_Auditoria is not null and RCR.id_aud is null"
                    Case "HOMOLOGADA"
                        _Estado = " and RCR.id_aud is not null and RC.Id_Auditoria is null"
                End Select
            Else
                _Estado = " and RCR.id_aud is null and RC.Id_Auditoria is null"
            End If
            If strlgrupo <> "" Then
                strlgrupo = " and (total_Atencion+total_gestion+total_solucion+total_cierre) " + strlgrupo
            Else
                strlgrupo = ""
            End If
            If strlfcini <> "" Then
                strlfcini = " and convert(date,C.Fc_Reg)>='" + strlfcini + "'"
            Else
                strlfcini = ""
            End If
            If strlfcfin <> "" Then
                strlfcfin = " and convert(date,C.Fc_Reg)<='" + strlfcfin + "'"
            Else
                strlfcfin = ""
            End If
            cms.CommandText = "select Cod_Calidad_Registro_V4 as [Id Aud],C.Fc_Reg as [Fecha Aud],Fc_Llamada as [Fecha Llamada],ua.nombreu as [Auditor],u.codnom as [Codigo Ing], u.nombreu as [Ingeniero],Id_Caso as [Caso], Proceso as [Campaña],(Total_General) as [Calificacion],case when (Total_General)<=85 then 'Critico' when (Total_General)>85 then 'Urgente' end as [Criticidad],DATEDIFF(hour,C.fc_reg,getdate()) as [Tiempo], case when RCR.id_aud is not null then 'HOMOLOGADA' when RC.Id_Auditoria is not null then 'Realizado' when DATEDIFF(hour,C.fc_reg,getdate())<=24 and (Total_General)<=85 then 'Vigente' when DATEDIFF(hour,C.fc_reg,getdate())>=24 and (Total_General)<=85 then 'Caducado' when DATEDIFF(hour,C.fc_reg,getdate())<=48 and (Total_General)>85 then 'Vigente' when DATEDIFF(hour,C.fc_reg,getdate())>=48 and (Total_General)>85 then 'Caducado' end as [Estado] from Calidad_Registro_V4 C inner join usuarios U on C.Agente = U.idusuario inner join usuarios UA on C.Auditor=UA.idusuario left join Retroalimentacion_Calidad RC on C.Cod_Calidad_Registro_V4 = RC.Id_Auditoria left join Retroalimentacion_Calidad_Homologadas RCR on RCR.Id_aud = C.Cod_Calidad_Registro_V4 where (Total_General)<90 " + _Auditor + strlagente + _Proceso + _Estado + strlgrupo + strlfcini + strlfcfin

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

    Public Sub registro_retro_rechazada()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Retroalimentacion_Calidad_Homologadas(Id_aud,Obs,Tipo,id_usuario) VALUES(@_Auditoria,@strlobs,@_Tipo_Auditoria,@strlidusuario)"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@_Auditoria", SqlDbType.VarChar).Value = _Auditoria
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@_Tipo_Auditoria", SqlDbType.VarChar).Value = _Tipo_Auditoria
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
    Public Function Consulta_Retro_Homologada() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select obs,tipo from Retroalimentacion_Calidad_Homologadas where id_aud = @_Auditoria"
            cms.Parameters.Add("@_Auditoria", SqlDbType.VarChar).Value = _Auditoria
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If dtsrecepcion.Tables(0).Rows(0).Item("obs") Is DBNull.Value Then
                strlobs = ""
            Else
                strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obs")
            End If
            If dtsrecepcion.Tables(0).Rows(0).Item("tipo") Is DBNull.Value Then
                _Tipo_Auditoria = ""
            Else
                _Tipo_Auditoria = dtsrecepcion.Tables(0).Rows(0).Item("tipo")
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

    Public Function Consulta_REporte_diario_auditoria() As Object
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "Diario" Then
                strlfcini = "and Convert(date,Fc_Reg)=Convert(date,getdate()) "
                strlfcfin = ""
                _Proceso = ""
                _Supervisor = ""
                strlagente = ""
            Else
                'FECHAS
                If strlfcini <> "" Then
                    strlfcini = " and Convert(date,Fc_Reg)>='" + strlfcini + "'"
                Else
                    strlfcini = ""
                End If
                If strlfcfin <> "" Then
                    strlfcfin = " and Convert(date,Fc_Reg)<='" + strlfcfin + "'"
                Else
                    strlfcfin = ""
                End If
                'PROCESO
                If _Proceso <> "" Then
                    _Proceso = " and Proceso='" + _Proceso + "'"
                Else
                    _Proceso = ""
                End If
                '-----HAVING------
                'SUPERVISOR
                If _Supervisor <> "" Then
                    _Supervisor = " and AVH.Jefe_Inmediato='" + _Supervisor + "'"
                Else
                    _Supervisor = ""
                End If

                'AGENTE
                If strlagente <> "" Then
                    strlagente = " and codnom='" + strlagente + "'"
                Else
                    strlagente = ""
                End If
            End If
            cms.CommandText = "Select VR.aud as [Id_Aud] ,CR.Fc_Reg,U.codnom as [Cod],U.nombreu as [Agente],CR.Id_Caso as [Caso],AVH.Jefe_Inmediato as [Supervisor],CR.Proceso,case CV.vari when 'MG' then 'Manejo Guion' when 'DLL' then 'Disponibilidad_Atender_Llamada' when 'C&B' then 'Cordialidad_Comunicacion' when 'CTI' then 'Claridad_Transmitir_Informacion' when 'Cac' then 'Contacto_Activo' when 'Cab' then 'Corona_Abierta' when 'A&E' then 'Amabilidad_Empatia' when 'F&EG' then 'Filtros_Eficiencia_Gestion' when 'INT&S' then 'Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones' when 'EA' then 'Escucha_Activa' when 'DocS' then 'Documentacion_Sistema' when 'CLL' then 'Cuelgue_Llamada' when 'Pinc' then 'Aplicacion_Manejo_Incompleto_Procedmientos_Tramites' when 'PCorr' then 'Aplicacion_Manejo_Correcto_Procedimientos_Tramites' when 'Res' then 'Resolucion_Necesidad_Cliente' when 'Ppqr' then 'Procedimiento_Pqr'when 'Ereq' then 'Escalamientos_Requeridos' end as [Variable mas afectada], CV.obs as [Obs_variable],CR.Obs_General,count(Calif) as [No_Afectaciones],(Total_Atencion+Total_Gestion+Total_Solucion+Total_Cierre) as Nota,case when RC.Cod_Retroalimentacion is not null then Convert(Nvarchar,RC.Cod_Retroalimentacion) when RH.Id_aud is not null then 'HOMOLOGADA' else '-' end Retro,case when RC.Fc_Retro is not null then Convert(Nvarchar,RC.Fc_Retro) when RH.Fc_registro is not null then Convert(Nvarchar,RH.Fc_registro) else '-' end [Fecha Retro] From (SELECT  aud, Variable, Calif FROM (select Cod_Calidad_Registro_V3 as [aud],Manejo_Guion*0.02 as [MG],Disponibilidad_Atender_Llamada*0.02 as [DLL],Cordialidad_Comunicacion*0.05 as [C&B],Claridad_Transmitir_Informacion*0.02 as [CTI],Contacto_Activo * 0.02 as [Cac],Corona_Abierta *0.02 as [Cab],Amabilidad_Empatia*0.07 as [A&E],Filtros_Eficiencia_Gestion*0.03 as [F&EG],Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones* 0.03 as [INT&S],Escucha_Activa*0.03 as [EA],Documentacion_Sistema* 0.10 as [DocS],Cuelgue_Llamada*0.10 as [CLL], Aplicacion_Manejo_Incompleto_Procedmientos_Tramites*0.07 as [Pinc],Aplicacion_Manejo_Correcto_Procedimientos_Tramites*0.09 as [PCorr],Resolucion_Necesidad_Cliente*0.13 as [Res],Procedimiento_Pqr *0.12 as [Ppqr],Escalamientos_Requeridos *0.08 as [Ereq] from datosclaro.dbo.Calidad_Registro_V3 where (Total_Atencion+Total_Gestion+Total_Solucion+Total_Cierre) < 100  and Fc_Reg>='19/07/2016'  " & strlfcini & strlfcfin & _Proceso & " ) p UNPIVOT ( Calif FOR Variable IN ([MG],[DLL],[C&B],[CTI], [Cac],[Cab],[A&E],[F&EG],[INT&S],[EA],[DocS],[CLL],[Pinc],[PCorr],[Res],[Ppqr],[Ereq]))AS unpvt   group by aud,Variable,Calif Having Calif=0 ) as VR inner join datosclaro.dbo.Calidad_Registro_V3  CR on VR.aud=CR.Cod_Calidad_Registro_V3 inner join datosclaro.dbo.Usuarios U on CR.Agente = U.idusuario left join Retroalimentacion_Calidad RC on VR.aud = RC.Id_Auditoria left join (Select * from ( Select ROW_NUMBER()Over(Partition by aud order by peso) as Orden, aud,vari,peso,obs  From (  SELECT Cal_Afec.aud, case Variable when 'Res' then Variable when 'Ppqr' then Variable when 'DocS' then Variable when 'CLL' then Variable when 'PCorr' then Variable when 'Ereq' then Variable when 'Pinc' then Variable when 'A&E' then Variable when 'C&B' then Variable when 'F&EG' then Variable when 'INT&S' then Variable when 'EA' then Variable when 'MG' then Variable when 'DLL' then Variable when 'CTI' then Variable   when 'Cac' then Variable   when 'Cab' then Variable end as Vari, case Variable when 'Res' then 1  when 'Ppqr' then 2 when 'DocS' then 3 when 'CLL' then 4 when 'PCorr' then 5 when 'Ereq' then 6 when 'Pinc' then 7 when 'A&E' then 8 when 'C&B' then 9 when 'F&EG' then 10 when 'INT&S' then 11 when 'EA' then 12 when 'MG' then 13 when 'DLL' then 14 when 'CTI' then 15   when 'Cac' then 16   when 'Cab' then 17 end as peso, OBS.Obs FROM (  select Cod_Calidad_Registro_V3 as [aud],Manejo_Guion*0.02 as [MG],Disponibilidad_Atender_Llamada*0.02 as [DLL],Cordialidad_Comunicacion*0.05 as [C&B],Claridad_Transmitir_Informacion*0.02 as [CTI],Contacto_Activo * 0.02 as [Cac],Corona_Abierta *0.02 as [Cab],Amabilidad_Empatia*0.07 as [A&E],Filtros_Eficiencia_Gestion*0.03 as [F&EG],Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones* 0.03 as [INT&S],Escucha_Activa*0.03 as [EA],Documentacion_Sistema* 0.10 as [DocS],Cuelgue_Llamada*0.10 as [CLL],Aplicacion_Manejo_Incompleto_Procedmientos_Tramites*0.07 as [Pinc],Aplicacion_Manejo_Correcto_Procedimientos_Tramites*0.09 as [PCorr],Resolucion_Necesidad_Cliente*0.13 as [Res],Procedimiento_Pqr *0.12 as [Ppqr],Escalamientos_Requeridos *0.08 as [Ereq] from datosclaro.dbo.Calidad_Registro_V3 where (Total_Atencion+Total_Gestion+Total_Solucion+Total_Cierre) < 100  " & strlfcini & strlfcfin & ") p   UNPIVOT ( Calif FOR Variable IN ([MG],[DLL],[C&B],[CTI], [Cac],[Cab],[A&E],[F&EG],[INT&S],[EA],[DocS],[CLL],[Pinc],[PCorr],[Res],[Ppqr],[Ereq]) )AS Cal_Afec left join ( SELECT  aud, Variable_obs, obs,CASE Variable_obs WHEN 'OBS_MG' THEN 'MG' WHEN 'OBS_DLL'THEN 'DLL' WHEN 'OBS_C&B'THEN 'C&B' WHEN 'OBS_CTI'THEN 'CTI' WHEN  'OBS_Cac'THEN 'Cac' WHEN 'OBS_Cab'THEN 'Cab' WHEN 'OBS_A&E'THEN 'A&E' WHEN 'OBS_F&EG'THEN 'F&EG' WHEN 'OBS_INT&S'THEN 'INT&S' WHEN 'OBS_EA'THEN 'EA' WHEN 'OBS_DocS'THEN 'DocS' WHEN 'OBS_CLL'THEN 'CLL' WHEN 'OBS_Pinc'THEN 'Pinc' WHEN 'OBS_PCorr'THEN 'PCorr' WHEN 'OBS_Res'THEN 'Res' WHEN 'OBS_Ppqr'THEN 'Ppqr' WHEN 'OBS_Ereq' THEN 'Ereq' END AS [Vari] FROM (select Cod_Calidad_Registro_V3 as [aud],Obs_Manejo_Guion as [OBS_MG],Obs_Disponibilidad_Atender_Llamada as [OBS_DLL],Obs_Cordialidad_Comunicacion as [OBS_C&B],Obs_Claridad_Transmitir_Informacion as [OBS_CTI],Obs_Contacto_Activo  as [OBS_Cac],Obs_Corona_Abierta  as [OBS_Cab],Obs_Amabilidad_Empatia as [OBS_A&E],Obs_Filtros_Eficiencia_Gestion as [OBS_F&EG],Obs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones as [OBS_INT&S],Obs_Escucha_Activa as [OBS_EA],Obs_Documentacion_Sistema as [OBS_DocS],Obs_Cuelgue_Llamada as [OBS_CLL],Obs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites as [OBS_Pinc],Obs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites as [OBS_PCorr],Obs_Resolucion_Necesidad_Cliente as [OBS_Res],Obs_Procedimiento_Pqr  as [OBS_Ppqr],Obs_Escalamientos_Requeridos  as [OBS_Ereq],Manejo_Guion from datosclaro.dbo.Calidad_Registro_V3 where (Total_Atencion+Total_Gestion+Total_Solucion+Total_Cierre) < 100  " & strlfcini & strlfcfin & ") p UNPIVOT ( obs FOR Variable_obs IN ([OBS_MG],[OBS_DLL],[OBS_C&B],[OBS_CTI], [OBS_Cac],[OBS_Cab],[OBS_A&E],[OBS_F&EG],[OBS_INT&S],[OBS_EA],[OBS_DocS],[OBS_CLL],[OBS_Pinc],[OBS_PCorr],[OBS_Res],[OBS_Ppqr],[OBS_Ereq]) ) AS unpvt   group by aud,Variable_obs,obs ) as OBS on Cal_Afec.aud=OBS.aud and Cal_Afec.Variable=OBS.Vari	group by Cal_Afec.aud,Variable,Calif,OBS.obs Having Calif=0 ) as J ) as MA where Orden=1) CV on CV.aud = VR.aud left join datosclaro.dbo.Retroalimentacion_Calidad_Homologadas  RH on VR.aud=RH.Id_aud left JOin admin_cham.dbo.Validacion_Horario AVH on AVH.Cod_Agente = U.codnom and COnvert(date,avh.Fc_Ingreso) = convert(date,getdate()) group by VR.aud,CR.Fc_Reg,U.codnom,U.nombreu,CR.Id_Caso,CR.Obs_General,(Total_Atencion+Total_Gestion+Total_Solucion+Total_Cierre),RC.Cod_Retroalimentacion,RC.Fc_Retro,CV.Vari,RH.Id_aud,RH.Fc_registro,AVH.Jefe_Inmediato,CR.Proceso,CV.obs Having VR.aud is not null " & strlagente & _Supervisor & "  order by VR.aud desc"
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

    '-----------------------------------------------------------------------
    '--------------Calidad Registro Auditoria V4-----------------
    '-----------------------------------------------------------------------
    Protected _Disponibilidad_Atender_Llamada As String
    Public Property Disponibilidad_Atender_Llamada As String
        Get
            Return _Disponibilidad_Atender_Llamada
        End Get
        Set(ByVal value As String)
            _Disponibilidad_Atender_Llamada = value
        End Set
    End Property
    Protected _Obs_disponibilidad_Atender_Llamada As String
    Public Property Obs_disponibilidad_Atender_Llamada As String
        Get
            Return _Obs_disponibilidad_Atender_Llamada
        End Get
        Set(ByVal value As String)
            _Obs_disponibilidad_Atender_Llamada = value
        End Set
    End Property

    Protected _Amabilidad_lenguaje_apropiado As String
    Public Property Amabilidad_lenguaje_apropiado As String
        Get
            Return _Amabilidad_lenguaje_apropiado
        End Get
        Set(ByVal value As String)
            _Amabilidad_lenguaje_apropiado = value
        End Set
    End Property
    Protected _Obs_Amabilidad_lenguaje_apropiado As String
    Public Property Obs_Amabilidad_lenguaje_apropiado As String
        Get
            Return _Obs_Amabilidad_lenguaje_apropiado
        End Get
        Set(ByVal value As String)
            _Obs_Amabilidad_lenguaje_apropiado = value
        End Set
    End Property

    Protected _Manejo_Tiempo As String
    Public Property Manejo_Tiempo As String
        Get
            Return _Manejo_Tiempo
        End Get
        Set(ByVal value As String)
            _Manejo_Tiempo = value
        End Set
    End Property
    Protected _Obs_Manejo_Tiempo As String
    Public Property Obs_Manejo_Tiempo As String
        Get
            Return _Obs_Manejo_Tiempo
        End Get
        Set(ByVal value As String)
            _Obs_Manejo_Tiempo = value
        End Set
    End Property

    Protected _Concentracion_durante_llamada As String
    Public Property Concentracion_durante_llamada As String
        Get
            Return _Concentracion_durante_llamada
        End Get
        Set(ByVal value As String)
            _Concentracion_durante_llamada = value
        End Set
    End Property
    Protected _Obs_Concentracion_durante_llamada As String
    Public Property Obs_Concentracion_durante_llamada As String
        Get
            Return _Obs_Concentracion_durante_llamada
        End Get
        Set(ByVal value As String)
            _Obs_Concentracion_durante_llamada = value
        End Set
    End Property


    Protected _Procedimientos_conocimientos As String
    Public Property Procedimientos_conocimientos As String
        Get
            Return _Procedimientos_conocimientos
        End Get
        Set(ByVal value As String)
            _Procedimientos_conocimientos = value
        End Set
    End Property
    Protected _Obs_Procedimientos_conocimientos As String
    Public Property Obs_Procedimientos_conocimientos As String
        Get
            Return _Obs_Procedimientos_conocimientos
        End Get
        Set(ByVal value As String)
            _Obs_Procedimientos_conocimientos = value
        End Set
    End Property

    Protected _Cuelgue_llamada As String
    Public Property Cuelgue_llamada As String
        Get
            Return _Cuelgue_llamada
        End Get
        Set(ByVal value As String)
            _Cuelgue_llamada = value
        End Set
    End Property
    Protected _Obs_Cuelgue_llamada As String
    Public Property Obs_Cuelgue_llamada As String
        Get
            Return _Obs_Cuelgue_llamada
        End Get
        Set(ByVal value As String)
            _Obs_Cuelgue_llamada = value
        End Set
    End Property

    Protected _Finalizacion_despedida_llamada As String
    Public Property Finalizacion_despedida_llamada As String
        Get
            Return _Finalizacion_despedida_llamada
        End Get
        Set(ByVal value As String)
            _Finalizacion_despedida_llamada = value
        End Set
    End Property
    Protected _Obs_Finalizacion_despedida_llamada As String
    Public Property Obs_Finalizacion_despedida_llamada As String
        Get
            Return _Obs_Finalizacion_despedida_llamada
        End Get
        Set(ByVal value As String)
            _Obs_Finalizacion_despedida_llamada = value
        End Set
    End Property


    Public Function Registro_Auditoria_Calidad_V4() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Dim dats As New DataSet
        Dim dta As New SqlClient.SqlDataAdapter
        Try
            cn.Open()
            cms.CommandText = "INSERT INTO Calidad_Registro_V4 (Id_Usuario,Id_Caso,Agente,Auditor,Campania,Proceso,Fk_Tipo_PQR,Fk_Tipo_Cliente,Fc_Llamada,Tiempo_Acum_Llamada,N_Llamadas_Min,Estado_Caso,Tipo_Auditoria,Disponibilidad_Atender_Llamada,Obs_disponibilidad_Atender_Llamada,Amabilidad_lenguaje_apropiado,Obs_Amabilidad_lenguaje_apropiado,Manejo_Tiempo,Obs_Manejo_Tiempo,Contacto_Activo,Obs_Contacto_Activo,Concentracion_durante_llamada,Obs_Concentracion_durante_llamada,Procedimientos_conocimientos,Obs_Procedimientos_conocimientos,Interes_escuchar,Obs_Interes_escuchar,Cuelgue_llamada,Obs_Cuelgue_llamada,Documentacion_Sistema,Obs_Documentacion_Sistema,Finalizacion_despedida_llamada,Obs_Finalizacion_despedida_llamada,Solucion,Obs_Solucion,Reporta_Inconsistencia,Cliente_Satisfecho,Obs_General,Total_Atencion,Total_Gestion,Total_Solucion,Total_Cierre) VALUES (@_Id_Usuario,@strlcaso,@strlagente,@_Auditor,@_Campania,@_Proceso,@_Id_Tipo_PQR,@_Id_Tipo_Cliente,@_Fc_Llamada,@_Tiempo_Acum_Llamada,@_N_Llamadas_Min,@_Estado_Caso,@_Tipo_Auditoria,@_Disponibilidad_Atender_Llamada,@_Obs_disponibilidad_Atender_Llamada,@_Amabilidad_lenguaje_apropiado,@_Obs_Amabilidad_lenguaje_apropiado,@_Manejo_Tiempo,@_Obs_Manejo_Tiempo,@_Contacto_Activo,@_Obs_Contacto_Activo,@_Concentracion_durante_llamada,@_Obs_Concentracion_durante_llamada,@_Procedimientos_conocimientos,@_Obs_Procedimientos_conocimientos,@_Interes_escuchar,@_Obs_Interes_escuchar,@_Cuelgue_llamada,@_Obs_Cuelgue_llamada,@_Documentacion,@_Obs_Documentacion,@_Finalizacion_despedida_llamada,@_Obs_Finalizacion_despedida_llamada,@_Solucion,@_Obs_Solucion,@_Reporta_Inc,@strlsatisfaccion,@_Obs_General,@_Total_Atencion,@_Total_Gestion,@_Total_Solucion,@_Total_Cierre) select @@IDENTITY AS 'Identity'"

            cms.Parameters.AddWithValue("@_Id_Usuario", _Id_Usuario)
            cms.Parameters.AddWithValue("@strlcaso", strlcaso)
            cms.Parameters.AddWithValue("@strlagente", strlagente)
            cms.Parameters.AddWithValue("@_Auditor", _Auditor)
            cms.Parameters.AddWithValue("@_Campania", _Campania)
            cms.Parameters.AddWithValue("@_Proceso", _Proceso)
            cms.Parameters.AddWithValue("@_Id_Tipo_PQR", _Id_Tipo_PQR)
            cms.Parameters.AddWithValue("@_Id_Tipo_Cliente", _Id_Tipo_Cliente)
            cms.Parameters.AddWithValue("@_Fc_Llamada", _Fc_Llamada)
            cms.Parameters.AddWithValue("@_Tiempo_Acum_Llamada", _Tiempo_Acum_Llamada)
            cms.Parameters.AddWithValue("@_N_Llamadas_Min", _N_Llamadas_Min)
            cms.Parameters.AddWithValue("@_Estado_Caso", _Estado_Caso)
            cms.Parameters.AddWithValue("@_Tipo_Auditoria", _Tipo_Auditoria)
            cms.Parameters.AddWithValue("@_Disponibilidad_Atender_Llamada", _Disponibilidad_Atender_Llamada)
            cms.Parameters.AddWithValue("@_Obs_disponibilidad_Atender_Llamada", _Obs_disponibilidad_Atender_Llamada)
            cms.Parameters.AddWithValue("@_Amabilidad_lenguaje_apropiado", _Amabilidad_lenguaje_apropiado)
            cms.Parameters.AddWithValue("@_Obs_Amabilidad_lenguaje_apropiado", _Obs_Amabilidad_lenguaje_apropiado)
            cms.Parameters.AddWithValue("@_Manejo_Tiempo", _Manejo_Tiempo)
            cms.Parameters.AddWithValue("@_Obs_Manejo_Tiempo", _Obs_Manejo_Tiempo)
            cms.Parameters.AddWithValue("@_Contacto_Activo", _Contacto_Activo)
            cms.Parameters.AddWithValue("@_Obs_Contacto_Activo", _Obs_Contacto_Activo)
            cms.Parameters.AddWithValue("@_Concentracion_durante_llamada", _Concentracion_durante_llamada)
            cms.Parameters.AddWithValue("@_Obs_Concentracion_durante_llamada", _Obs_Concentracion_durante_llamada)
            cms.Parameters.AddWithValue("@_Procedimientos_conocimientos", _Procedimientos_conocimientos)
            cms.Parameters.AddWithValue("@_Obs_Procedimientos_conocimientos", _Obs_Procedimientos_conocimientos)
            cms.Parameters.AddWithValue("@_Interes_escuchar", _Interes_escuchar)
            cms.Parameters.AddWithValue("@_Obs_Interes_escuchar", _Obs_Interes_escuchar)
            cms.Parameters.AddWithValue("@_Cuelgue_llamada", _Cuelgue_llamada)
            cms.Parameters.AddWithValue("@_Obs_Cuelgue_llamada", _Obs_Cuelgue_llamada)
            cms.Parameters.AddWithValue("@_Documentacion", _Documentacion)
            cms.Parameters.AddWithValue("@_Obs_Documentacion", _Obs_Documentacion)
            cms.Parameters.AddWithValue("@_Finalizacion_despedida_llamada", _Finalizacion_despedida_llamada)
            cms.Parameters.AddWithValue("@_Obs_Finalizacion_despedida_llamada", _Obs_Finalizacion_despedida_llamada)
            cms.Parameters.AddWithValue("@_Solucion", _Solucion)
            cms.Parameters.AddWithValue("@_Obs_Solucion", _Obs_Solucion)
            cms.Parameters.AddWithValue("@_Reporta_Inc", _Reporta_Inc)
            cms.Parameters.AddWithValue("@strlsatisfaccion", strlsatisfaccion)
            cms.Parameters.AddWithValue("@_Obs_General", _Obs_General)
            cms.Parameters.AddWithValue("@_Total_Atencion", _Total_Atencion)
            cms.Parameters.AddWithValue("@_Total_Gestion", _Total_Gestion)
            cms.Parameters.AddWithValue("@_Total_Solucion", _Total_Solucion)
            cms.Parameters.AddWithValue("@_Total_Cierre", _Total_Cierre)
            cms.Connection = cn
            'cms.ExecuteNonQuery()
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dats)
            strlcantidad = dats.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dats.Tables(0).Rows(0).Item("Identity") Is System.DBNull.Value Then
                    strlidreg = " "
                Else
                    strlidreg = dats.Tables(0).Rows(0).Item("Identity")
                End If
            End If
            Return dats
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Function Llenar_TextBox_V4() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            cn.Open()
            cms.Parameters.AddWithValue("@_Cod_Calidad", Cod_Calidad_Registro)
            cms.CommandText = "Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor, Cc.Nombre As Tipo_Cliente, Cp.Nombre As Tipo_PQR from Calidad_Registro_V4 CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario Left Join Calidad_Registro_Complemento Cc On Cc.Cod_Calidad_Registro_Complemento = Cr.Fk_Tipo_Cliente Left Join Calidad_Registro_Complemento Cp On Cp.Cod_Calidad_Registro_Complemento = Cr.Fk_Tipo_PQR where Cod_Calidad_Registro_V4 = @_Cod_Calidad"
            If _Validacion = "1" Then
                cms.CommandText = "	Select CR.*,U.nombreu as NAgente,UU.nombreu as NAuditor, Cc.Nombre As Tipo_Cliente, Cp.Nombre As Tipo_PQR from Calidad_Registro_V4 CR inner join usuarios U on CR.Agente = U.idusuario inner join usuarios UU on CR.Auditor = UU.idusuario Left Join Calidad_Registro_Complemento Cc On Cc.Cod_Calidad_Registro_Complemento = Cr.Fk_Tipo_Cliente Left Join Calidad_Registro_Complemento Cp On Cp.Cod_Calidad_Registro_Complemento = Cr.Fk_Tipo_PQR where UU.cargo like '%Q%' and Cod_Calidad_Registro_V4 = @_Cod_Calidad and CR.Agente = @_Id_Usuario"
                cms.Parameters.AddWithValue("@_Id_Usuario", _Id_Usuario)
            End If
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then

                _Id_Usuario = dts.Tables(0).Rows(0).Item("Id_Usuario").ToString
                strlcaso = dts.Tables(0).Rows(0).Item("Id_Caso").ToString
                strlagente = dts.Tables(0).Rows(0).Item("NAgente").ToString
                _Auditor = dts.Tables(0).Rows(0).Item("NAuditor").ToString
                _Campania = dts.Tables(0).Rows(0).Item("Campania").ToString
                _Proceso = dts.Tables(0).Rows(0).Item("Proceso").ToString
                _Tipo_PQR = dts.Tables(0).Rows(0).Item("Tipo_PQR").ToString
                _Tipo_Cliente = dts.Tables(0).Rows(0).Item("Tipo_Cliente").ToString
                _Fc_Llamada = dts.Tables(0).Rows(0).Item("Fc_Llamada").ToString
                _Tiempo_Acum_Llamada = dts.Tables(0).Rows(0).Item("Tiempo_Acum_Llamada").ToString
                _N_Llamadas_Min = dts.Tables(0).Rows(0).Item("N_Llamadas_Min").ToString
                _Estado_Caso = dts.Tables(0).Rows(0).Item("Estado_Caso").ToString
                _Tipo_Auditoria = dts.Tables(0).Rows(0).Item("Tipo_Auditoria").ToString
                _Disponibilidad_Atender_Llamada = dts.Tables(0).Rows(0).Item("Disponibilidad_Atender_Llamada").ToString
                _Obs_disponibilidad_Atender_Llamada = dts.Tables(0).Rows(0).Item("Obs_disponibilidad_Atender_Llamada").ToString
                _Amabilidad_lenguaje_apropiado = dts.Tables(0).Rows(0).Item("Amabilidad_lenguaje_apropiado").ToString
                _Obs_Amabilidad_lenguaje_apropiado = dts.Tables(0).Rows(0).Item("Obs_Amabilidad_lenguaje_apropiado").ToString
                _Manejo_Tiempo = dts.Tables(0).Rows(0).Item("Manejo_Tiempo").ToString
                _Obs_Manejo_Tiempo = dts.Tables(0).Rows(0).Item("Obs_Manejo_Tiempo").ToString
                _Contacto_Activo = dts.Tables(0).Rows(0).Item("Contacto_Activo").ToString
                _Obs_Contacto_Activo = dts.Tables(0).Rows(0).Item("Obs_Contacto_Activo").ToString
                _Concentracion_durante_llamada = dts.Tables(0).Rows(0).Item("Concentracion_durante_llamada").ToString
                _Obs_Concentracion_durante_llamada = dts.Tables(0).Rows(0).Item("Obs_Concentracion_durante_llamada").ToString
                _Procedimientos_conocimientos = dts.Tables(0).Rows(0).Item("Procedimientos_conocimientos").ToString
                _Obs_Procedimientos_conocimientos = dts.Tables(0).Rows(0).Item("Obs_Procedimientos_conocimientos").ToString
                _Interes_escuchar = dts.Tables(0).Rows(0).Item("Interes_escuchar").ToString
                _Obs_Interes_escuchar = dts.Tables(0).Rows(0).Item("Obs_Interes_escuchar").ToString
                _Cuelgue_llamada = dts.Tables(0).Rows(0).Item("Cuelgue_llamada").ToString
                _Obs_Cuelgue_llamada = dts.Tables(0).Rows(0).Item("Obs_Cuelgue_llamada").ToString
                _Documentacion = dts.Tables(0).Rows(0).Item("Documentacion_Sistema").ToString
                _Obs_Documentacion = dts.Tables(0).Rows(0).Item("Obs_Documentacion_Sistema").ToString
                _Finalizacion_despedida_llamada = dts.Tables(0).Rows(0).Item("Finalizacion_despedida_llamada").ToString
                _Obs_Finalizacion_despedida_llamada = dts.Tables(0).Rows(0).Item("Obs_Finalizacion_despedida_llamada").ToString
                _Solucion = dts.Tables(0).Rows(0).Item("Solucion").ToString
                _Obs_Solucion = dts.Tables(0).Rows(0).Item("Obs_Solucion").ToString
                _Reporta_Inc = dts.Tables(0).Rows(0).Item("Reporta_Inconsistencia").ToString
                strlsatisfaccion = dts.Tables(0).Rows(0).Item("Cliente_Satisfecho").ToString
                _Obs_General = dts.Tables(0).Rows(0).Item("Obs_General").ToString
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


    Public Function Consulta_Auditorias_Agente_V4() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim script As String
        Try
            cn.Open()

            If _Id_Usuario <> Nothing Then
                cms.Parameters.AddWithValue("@_Id_Usuario", _Id_Usuario)
                script = script & " and U.idusuario=@_Id_Usuario"
            End If
            If strlfcini <> Nothing And strlfcfin <> Nothing Then
                script = script & " and Convert(date,Fc_Reg) >=@strlfcini and Convert(date,Fc_Reg) <=@strlfcfin"
                cms.Parameters.AddWithValue("@strlfcini", strlfcini)
                cms.Parameters.AddWithValue("@strlfcfin", strlfcfin)
            End If
            If _Campania <> Nothing Then
                script = script & " and Proceso=@_Campania"
                cms.Parameters.AddWithValue("@_Campania", _Campania)
            End If
            If strlCodigoAgente <> Nothing Then
                script = script & " and codnom=@strlCodigoAgente "
                cms.Parameters.AddWithValue("@strlCodigoAgente", strlCodigoAgente)
            End If
            cms.CommandText = "SELECT Cod_Calidad_Registro_V4 as [Cod_Aud],Fc_Reg,codnom as [Cod],nombreu as [Nombre],Id_Caso as [Caso], Estado_Caso as [Estado],C.Proceso,Disponibilidad_Atender_Llamada as [DALL],Amabilidad_lenguaje_apropiado as [A&LA],Manejo_Tiempo as [MT],Contacto_Activo as [CA],Concentracion_durante_llamada as [CDLL],Procedimientos_conocimientos as [PROC&C],Interes_escuchar as [EN&PS],Cuelgue_llamada as [CLl],Documentacion_Sistema as [DS],Finalizacion_despedida_llamada as [F&DLl],Convert(Decimal(18,0),(Convert(Decimal(18,2),(Total_Atencion*100))/27)) as Atencion,Convert(Decimal(18,0),(Convert(Decimal(18,2),(Total_Gestion*100))/27))  as Gestion,Convert(Decimal(18,0),(Convert(Decimal(18,2),(Total_Solucion*100))/31))  as Solucion,Convert(Decimal(18,0),(Convert(Decimal(18,2),(Total_Cierre*100))/15))  as Cierre,Total_General as Tot_General FROM Calidad_Registro_V4 C inner join usuarios U on C.Agente=U.idusuario where Cod_Calidad_Registro_V4 is not null" & script & " order by Fc_Reg desc"
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





End Class
