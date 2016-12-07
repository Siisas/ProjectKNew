Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class clscrmdatos
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
    Protected strlabierto As String
    Protected strlcerrado As String
    Protected strldiagservicio As String
    Protected strldiagcaractfalla As String
    Protected strldiagperep As String
    Protected strldiagtecnolog As String
    Protected strldiagcondic As String
    Protected strldiagvariable As String
    Protected strldiagtcierre As String
    Protected strlfallatec As String
    Protected strlsolucion As String
    Protected strlajuste As String
    Protected strlvlrajuste As String

    Protected strltlinea As String
    Protected strlservreest As String
    Protected strlfcrest As String
    Protected strlaplicaajuste As String
    Protected strlsolicajuste As String
    Protected strlnompaquete As String
    Protected strlvlrpaquete As String
    Protected strldias As String
    Protected strlhoraprog As String
    Protected strlidentificacion As String
    Protected strlpreg2 As String
    Protected strlpreg3 As String
    Protected strlfcultimac As String
    Protected strlfranjaultimac As String
    Protected strlgrupo As String
    Protected strlmarca As String
    Protected strlidservicio As String
    Protected strlreclamoppal As String
    Protected strlfcpqr As String
    Protected strlnit As String
    Protected strlfechainicial As String
    Protected strlfechafin As String
    Protected strlDesactivacion As String
    Protected strlapn As String
    Protected strlqos As String
    Protected strlidusuarioasignado As String
    Protected strlarchivo As String
    Protected strlsolicitud As String

    Protected Fecha_Actual As String = DateTime.Now.ToString("dd/MM/yyyy")
    Protected Fecha_Actual_Hora As String = DateTime.Now.ToString("HH:mm:ss")
    Protected _CicloFactura As Integer
    Protected strlidclient As String
    Protected strlCampanaLogin As String
    Protected strlSuperv As String
    Protected strlNum_Intento As String
    Protected _Bandeja As String
    Protected _Validacion As String
    Protected strlObsNivel3 As String
    Protected _Caso_Claro As String
    Protected _Escalamiento_CPD_SD As String
    Protected _Segmentacion_Linea As String
    Protected _Tipo_PQR As String
    Protected _Tipo_Cliente As String
    Protected _Modalidad As String
    Protected _Causa_Raiz As String
    Protected _Categoria_Cierre As String
    Protected _Version_S_O_Equipo As String
    Protected _Version_Facebook As String
    Protected _Tipificacion_Interna As String
    Property _WTF As String
    Protected _Tipo_PQR_Adicional As String
    Protected _Intension_Des_Por_Falla As String
    Protected _Tipo_Proceso_Linea As String
    Protected strlcustcode As String
    Protected strlusuarioreporta As String
    Protected _Tipo_Falla As String
    Protected _Percep_serv As String
    Protected _inconsistencia_encuesta As String
    Protected _Linea_CMC As String
    Protected _Causa_CMC As String
    Protected _Novedad_CMC As String
    Protected _Id_Novedad As String


    Public Property Novedad_CMC As String
        Get
            Return _Novedad_CMC
        End Get
        Set(ByVal value As String)
            _Novedad_CMC = value
        End Set
    End Property
    Public Property Id_Novedad As String
        Get
            Return _Id_Novedad
        End Get
        Set(ByVal value As String)
            _Id_Novedad = value
        End Set
    End Property


    Public Property Linea_CMC As String
        Get
            Return _Linea_CMC
        End Get
        Set(ByVal value As String)
            _Linea_CMC = value
        End Set
    End Property
    Public Property Causa_CMC As String
        Get
            Return _Causa_CMC
        End Get
        Set(ByVal value As String)
            _Causa_CMC = value
        End Set
    End Property

    Public Property inconsistencia_encuesta As String
        Get
            Return _inconsistencia_encuesta
        End Get
        Set(ByVal value As String)
            _inconsistencia_encuesta = value
        End Set
    End Property

    Public Property Percep_serv As String
        Get
            Return _Percep_serv
        End Get
        Set(ByVal value As String)
            _Percep_serv = value
        End Set
    End Property



    Public Property Tipo_Falla As String
        Get
            Return _Tipo_Falla
        End Get
        Set(ByVal value As String)
            _Tipo_Falla = value
        End Set
    End Property

    Public Property custcode() As String
        Get
            Return strlcustcode
        End Get
        Set(ByVal value As String)
            strlcustcode = value
        End Set
    End Property
    Public Property usuarioreporta() As String
        Get
            Return strlusuarioreporta
        End Get
        Set(ByVal value As String)
            strlusuarioreporta = value
        End Set
    End Property


    Public Property Tipo_Proceso_Linea As String
        Get
            Return _Tipo_Proceso_Linea
        End Get
        Set(ByVal value As String)
            _Tipo_Proceso_Linea = value
        End Set
    End Property
    Public Property Intension_Des_Por_Falla As String
        Get
            Return _Intension_Des_Por_Falla
        End Get
        Set(ByVal value As String)
            _Intension_Des_Por_Falla = value
        End Set
    End Property
    Public Property Tipo_PQR_Adicional As String
        Get
            Return _Tipo_PQR_Adicional
        End Get
        Set(ByVal value As String)
            _Tipo_PQR_Adicional = value
        End Set
    End Property
    Public Property WTF As String
        Get
            Return _WTF
        End Get
        Set(ByVal value As String)
            _WTF = value
        End Set
    End Property
    Public Property Tipificacion_Interna As String
        Get
            Return _Tipificacion_Interna
        End Get
        Set(ByVal value As String)
            _Tipificacion_Interna = value
        End Set
    End Property
    Public Property Version_Facebook As String
        Get
            Return _Version_Facebook
        End Get
        Set(ByVal value As String)
            _Version_Facebook = value
        End Set
    End Property
    Public Property Version_S_O_Equipo() As String
        Get
            Return _Version_S_O_Equipo
        End Get
        Set(ByVal value As String)
            _Version_S_O_Equipo = value
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
    Public Property Segmentacion_Linea As String
        Get
            Return _Segmentacion_Linea
        End Get
        Set(ByVal value As String)
            _Segmentacion_Linea = value
        End Set
    End Property
    Public Property Escalamiento_CPD_SD As String
        Get
            Return _Escalamiento_CPD_SD
        End Get
        Set(ByVal value As String)
            _Escalamiento_CPD_SD = value
        End Set
    End Property
    Public Property Caso_Claro As String
        Get
            Return _Caso_Claro
        End Get
        Set(ByVal value As String)
            _Caso_Claro = value
        End Set
    End Property
    Public Property ObsNivel3 As String
        Get
            Return strlObsNivel3
        End Get
        Set(ByVal value As String)
            strlObsNivel3 = value
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
    Public Property Bandeja As String
        Get
            Return _Bandeja
        End Get
        Set(ByVal value As String)
            _Bandeja = value
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
    Public Property CampanaLogin As String
        Get
            Return strlCampanaLogin
        End Get
        Set(ByVal value As String)
            strlCampanaLogin = value
        End Set
    End Property
    Public Property idclient() As String
        Get
            Return strlidclient
        End Get
        Set(ByVal value As String)
            strlidclient = value
        End Set
    End Property

    Public Property CicloFactura As Integer
        Get
            Return _CicloFactura
        End Get
        Set(ByVal value As Integer)
            _CicloFactura = value
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
    Public Property Fecha_Actuals() As String
        Get
            Return Fecha_Actual
        End Get
        Set(ByVal value As String)
            Fecha_Actual = value
        End Set
    End Property
    Public Property Fecha_Actual_Horas() As String
        Get
            Return Fecha_Actual_Hora
        End Get
        Set(ByVal value As String)
            Fecha_Actual_Hora = value
        End Set
    End Property

    Public Property archivo As String
        Get
            Return strlarchivo
        End Get
        Set(ByVal value As String)
            strlarchivo = value
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
    Public Property qos As String
        Get
            Return strlqos
        End Get
        Set(ByVal value As String)
            strlqos = value
        End Set
    End Property
    Public Property apn As String
        Get
            Return strlapn
        End Get
        Set(ByVal value As String)
            strlapn = value
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
    Public Property fcpqr() As String
        Get
            Return strlfcpqr
        End Get
        Set(ByVal value As String)
            strlfcpqr = value
        End Set
    End Property
    Public Property reclamoppal() As String
        Get
            Return strlreclamoppal
        End Get
        Set(ByVal value As String)
            strlreclamoppal = value
        End Set
    End Property
    Public Property idservicio() As String
        Get
            Return strlidservicio
        End Get
        Set(ByVal value As String)
            strlidservicio = value
        End Set
    End Property
    Public Property marca() As String
        Get
            Return strlmarca
        End Get
        Set(ByVal value As String)
            strlmarca = value
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
    Public Property identificacion() As String
        Get
            Return strlidentificacion
        End Get
        Set(ByVal value As String)
            strlidentificacion = value
        End Set
    End Property

    Public Property horaprog() As String
        Get
            Return strlhoraprog
        End Get
        Set(ByVal value As String)
            strlhoraprog = value
        End Set
    End Property
    Public Property dias() As String
        Get
            Return strldias
        End Get
        Set(ByVal value As String)
            strldias = value
        End Set
    End Property
    Public Property vlrpaquete() As String
        Get
            Return strlvlrpaquete
        End Get
        Set(ByVal value As String)
            strlvlrpaquete = value
        End Set
    End Property
    Public Property nompaquete() As String
        Get
            Return strlnompaquete
        End Get
        Set(ByVal value As String)
            strlnompaquete = value
        End Set
    End Property
    Public Property solicajuste() As String
        Get
            Return strlsolicajuste
        End Get
        Set(ByVal value As String)
            strlsolicajuste = value
        End Set
    End Property
    Public Property aplicaajuste() As String
        Get
            Return strlaplicaajuste
        End Get
        Set(ByVal value As String)
            strlaplicaajuste = value
        End Set
    End Property
    Public Property fcrest() As String
        Get
            Return strlfcrest
        End Get
        Set(ByVal value As String)
            strlfcrest = value
        End Set
    End Property
    Public Property servreest() As String
        Get
            Return strlservreest
        End Get
        Set(ByVal value As String)
            strlservreest = value
        End Set
    End Property
    Public Property tlinea() As String
        Get
            Return strltlinea
        End Get
        Set(ByVal value As String)
            strltlinea = value
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
    Public Property solucion() As String
        Get
            Return strlsolucion
        End Get
        Set(ByVal value As String)
            strlsolucion = value
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

    Public Property cerrado() As String
        Get
            Return strlcerrado
        End Get
        Set(ByVal value As String)
            strlcerrado = value
        End Set
    End Property
    Public Property abierto() As String
        Get
            Return strlabierto
        End Get
        Set(ByVal value As String)
            strlabierto = value
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

    Protected _Contacto_cliente As String
    Public Property Contacto_cliente As String
        Get
            Return _Contacto_cliente
        End Get
        Set(ByVal value As String)
            _Contacto_cliente = value
        End Set
    End Property

    Protected _Fecha_Ini As Date
    Public Property Fecha_Ini As Date
        Get
            Return _Fecha_Ini
        End Get
        Set(ByVal value As Date)
            _Fecha_Ini = value
        End Set
    End Property
    Protected _Fecha_Fin As Date
    Public Property Fecha_Fin As Date
        Get
            Return _Fecha_Fin
        End Get
        Set(ByVal value As Date)
            _Fecha_Fin = value
        End Set
    End Property
    Protected _Max As Integer
    Public Property Max As Integer
        Get
            Return _Max
        End Get
        Set(ByVal value As Integer)
            _Max = value
        End Set
    End Property

    Protected _Tipo_Canal As String
    Public Property Tipo_Canal() As String
        Get
            Return _Tipo_Canal
        End Get
        Set(ByVal value As String)
            _Tipo_Canal = value
        End Set
    End Property
    Protected _Estacion_base As String
    Public Property Estacion_base() As String
        Get
            Return _Estacion_base
        End Get
        Set(ByVal value As String)
            _Estacion_base = value
        End Set
    End Property
    Protected _Causal_escalam As String
    Public Property Causal_escalam() As String
        Get
            Return _Causal_escalam
        End Get
        Set(ByVal value As String)
            _Causal_escalam = value
        End Set
    End Property

    Protected _Fecha_ciclo As Date
    Public Property Fecha_ciclo() As Date
        Get
            Return _Fecha_ciclo
        End Get
        Set(ByVal value As Date)
            _Fecha_ciclo = value
        End Set
    End Property

    Protected _ruta As String
    Public Property ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
        End Set
    End Property
    Protected _Caso_rechazado As String
    Public Property Caso_rechazado As String
        Get
            Return _Caso_rechazado
        End Get
        Set(ByVal value As String)
            _Caso_rechazado = value
        End Set
    End Property




    Public Function consultacaso() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT fcprogram,fallatec,fallared,pqrcamp, estadon3, fcingn3, cas_observaciones, estado,idcrm, cas_id, fcreg, idusuario,obs, tipo_soporte, tipificacion, cas_fecha_registro, min_ac, nom_cliente, no_documento, plan_acual_ac, equipo_ac, departamento_falla, correo_electronico,otro_telefono,Bandeja FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@strlcaso and Bandeja not like '%BSCS%' ORDER BY idcrm DESC"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            If strlmin <> Nothing Then
                cms.CommandText = "SELECT fcprogram,fallatec,fallared,pqrcamp, estadon3, fcingn3, cas_observaciones, estado,idcrm, cas_id, fcreg, idusuario,obs, tipo_soporte, tipificacion, cas_fecha_registro, min_ac, nom_cliente, no_documento, plan_acual_ac, equipo_ac, departamento_falla, correo_electronico,otro_telefono,Bandeja FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where min_ac=@strlmin and Bandeja not like '%BSCS%' ORDER BY idcrm DESC"
                cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 50).Value = Me.strlmin
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("estadon3") Is System.DBNull.Value Then
                    strlestadoinc = " "
                Else
                    strlestadoinc = dtsrecepcion.Tables(0).Rows(0).Item("estadon3")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fcingn3") Is System.DBNull.Value Then
                    strlfcingn3 = " "
                Else
                    strlfcingn3 = dtsrecepcion.Tables(0).Rows(0).Item("fcingn3")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("no_documento") Is System.DBNull.Value Then
                    strldocumento = " "
                Else
                    strldocumento = dtsrecepcion.Tables(0).Rows(0).Item("no_documento")
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
                If dtsrecepcion.Tables(0).Rows(0).Item("plan_acual_ac") Is System.DBNull.Value Then
                    strlplan = " "
                Else
                    strlplan = dtsrecepcion.Tables(0).Rows(0).Item("plan_acual_ac")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("departamento_falla") Is System.DBNull.Value Then
                    strllugar = " "
                Else
                    strllugar = dtsrecepcion.Tables(0).Rows(0).Item("departamento_falla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("correo_electronico") Is System.DBNull.Value Then
                    strlemail = " "
                Else
                    strlemail = dtsrecepcion.Tables(0).Rows(0).Item("correo_electronico")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cas_id") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("cas_id")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cas_observaciones") Is System.DBNull.Value Then
                    strlobsini = " "
                Else
                    strlobsini = dtsrecepcion.Tables(0).Rows(0).Item("cas_observaciones")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("pqrcamp") Is System.DBNull.Value Then
                    strlpqr = " "
                Else
                    strlpqr = dtsrecepcion.Tables(0).Rows(0).Item("pqrcamp")
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
                If dtsrecepcion.Tables(0).Rows(0).Item("otro_telefono") Is System.DBNull.Value Then
                    strltelalt = " "
                Else
                    strltelalt = dtsrecepcion.Tables(0).Rows(0).Item("otro_telefono")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Bandeja") Is System.DBNull.Value Then
                    _Bandeja = " "
                Else
                    _Bandeja = dtsrecepcion.Tables(0).Rows(0).Item("Bandeja")
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


    Public Sub registrocrm()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If strlajuste = Nothing Then
                strlajuste = " "
            End If
            cms.Parameters.Add("@Actualizacion_CMC", SqlDbType.VarChar, 2).Value = strlajuste 'parametro de actualizacion de CMC SOLO ES PARA BSCS

            If _Linea_CMC = Nothing Then
                cms.Parameters.Add("@_Linea_CMC", SqlDbType.VarChar).Value = DBNull.Value
            Else
                cms.Parameters.Add("@_Linea_CMC", SqlDbType.VarChar, 100).Value = _Linea_CMC
            End If
            If _Causa_CMC = Nothing Then
                cms.Parameters.Add("@_Causa_CMC", SqlDbType.VarChar).Value = DBNull.Value
            Else
                cms.Parameters.Add("@_Causa_CMC", SqlDbType.VarChar, 100).Value = _Causa_CMC
            End If
            If strlhoraprog <> Nothing Then
                cms.CommandText = "INSERT INTO crmdetalle(fcprogram,numalt,idcaso,fcreg,idusuario,obs,tipo_soporte,tipificacion,preg1,Percep_serv,PQR,preg2,estado_CMC,Causa_CMC) values(@strlhoraprog,@strltelalt,@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strlpreg1,@_Percep_serv,@strlpqr,@Actualizacion_CMC,@_Linea_CMC,@_Causa_CMC)"
                cms.Parameters.Add("@strlhoraprog", SqlDbType.NVarChar, 50).Value = strlhoraprog
            Else
                cms.CommandText = "INSERT INTO crmdetalle(numalt,idcaso,fcreg,idusuario,obs,tipo_soporte,tipificacion,preg1,Percep_serv,PQR,preg2,estado_CMC,Causa_CMC) values(@strltelalt,@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strlpreg1,@_Percep_serv,@strlpqr,@Actualizacion_CMC,@_Linea_CMC,@_Causa_CMC)"
            End If
            If strlpreg2 <> Nothing Then
                cms.CommandText = "INSERT INTO crmdetalle(numalt,idcaso,fcreg,idusuario,obs,tipo_soporte,tipificacion,preg1,Percep_serv,preg2,preg3,IdClient,PQR,preg2,estado_CMC,Causa_CMC) values(@strltelalt,@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strlpreg1,@_Percep_serv,@strlpreg2,@strlpreg3,@strlidclient,@strlpqr,@Actualizacion_CMC,@_Linea_CMC,@_Causa_CMC)"
                cms.Parameters.Add("@strlpreg2", SqlDbType.VarChar, 255).Value = strlpreg2
                cms.Parameters.Add("@strlpreg3", SqlDbType.VarChar, 255).Value = strlpreg3
                cms.Parameters.Add("@strlidclient", SqlDbType.VarChar, 50).Value = strlidclient
                If strlpreg2 <> Nothing And strlhoraprog <> Nothing Then
                    cms.CommandText = "INSERT INTO crmdetalle(fcprogram,numalt,idcaso,fcreg,idusuario,obs,tipo_soporte,tipificacion,preg1,Percep_serv,preg2,preg3,PQR,preg2,estado_CMC,Causa_CMC) values(@strlhoraprog,@strltelalt,@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strlpreg1,@_Percep_serv,@strlpreg2,@strlpreg3,@strlpqr,@Actualizacion_CMC,@_Linea_CMC,@_Causa_CMC)"
                End If
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            cms.Parameters.Add("@strlpqr", SqlDbType.BigInt).Value = strlpqr
            If strltiposoporte = Nothing Then
                cms.Parameters.Add("@strltiposoporte", SqlDbType.VarChar, 255).Value = DBNull.Value
            Else
                cms.Parameters.Add("@strltiposoporte", SqlDbType.VarChar, 255).Value = strltiposoporte
            End If
            If strltipificacion = "No Contactado" Then
                cms.CommandText = "INSERT INTO crmdetalle(idcaso,fcreg,idusuario,obs,tipo_soporte,tipificacion,PQR,preg2,estado_CMC,Causa_CMC) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strlpqr,@Actualizacion_CMC,@_Linea_CMC,@_Causa_CMC)"
                cms.Connection = cn
                cms.ExecuteNonQuery()
                Exit Sub
            End If

            If _Percep_serv = Nothing Then
                cms.Parameters.Add("@_Percep_serv", SqlDbType.VarChar).Value = DBNull.Value
            Else
                cms.Parameters.Add("@_Percep_serv", SqlDbType.VarChar, 255).Value = _Percep_serv
            End If

            If strlpreg1 = Nothing Then
                cms.Parameters.Add("@strlpreg1", SqlDbType.VarChar).Value = DBNull.Value
            Else
                cms.Parameters.Add("@strlpreg1", SqlDbType.VarChar, 255).Value = strlpreg1
            End If

            If strltelalt = Nothing Then
                cms.Parameters.Add("@strltelalt", SqlDbType.VarChar).Value = DBNull.Value
            Else
                cms.Parameters.Add("@strltelalt", SqlDbType.VarChar, 100).Value = strltelalt
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
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja SET equipook=@strlequipo, estado= @strltipificacion WHERE cas_id= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = strltipificacion
            If strlequipo = Nothing Then
                cms.Parameters.AddWithValue("@strlequipo", DBNull.Value)
            Else
                cms.Parameters.Add("@strlequipo", SqlDbType.VarChar, 255).Value = strlequipo
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





    Public Sub modificarbandejan3()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja SET estado= @strltipificacion, estadon3=@strltipificacion,estadofallatec=@strlfallatec WHERE cas_id= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = strltipificacion
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

    Public Function consultadilo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM bandeja_alt ORDER BY idcaso DESC"
            If strltipificacion <> "" Then
                cms.CommandText = "SELECT * FROM bandeja_alt WHERE estado=@strltipificacion ORDER BY idcaso DESC"
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = Me.strltipificacion
            End If
            If strlmesa <> "" Then
                cms.CommandText = "SELECT * FROM bandeja_alt WHERE mesa=@strlmesa ORDER BY idcaso DESC"
                cms.Parameters.Add("@strlmesa", SqlDbType.VarChar, 50).Value = Me.strlmesa
            End If
            If strlfcini <> "" Then
                cms.CommandText = "SELECT * FROM bandeja_alt WHERE fcreporte >= @strlfcini ORDER BY idcaso DESC"
                cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = Me.strlfcini
                If strlfcfin <> "" Then
                    cms.CommandText = "SELECT * FROM bandeja_alt WHERE fcreporte >= @strlfcini and fcreporte <= @strlfcfin ORDER BY idcaso DESC"
                    cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = Me.strlfcfin
                End If
            End If
            If strlfcini <> "" And strltipificacion <> "" Then
                cms.CommandText = "SELECT * FROM bandeja_alt WHERE fcreporte >= @strlfcini and estado=@strltipificacion ORDER BY idcaso DESC"
                If strlfcfin <> "" Then
                    cms.CommandText = "SELECT * FROM bandeja_alt WHERE fcreporte >= @strlfcini and fcreporte <= @strlfcfin and estado=@strltipificacion ORDER BY idcaso DESC"
                End If
            End If
            If strlcaso <> "" Then
                cms.CommandText = "SELECT * FROM Bandeja_alt LEFT OUTER JOIN CRMdilo ON Bandeja_alt.idcaso = CRMdilo.idcasodilo WHERE idcaso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = Me.strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("fcreporte") Is System.DBNull.Value Then
                    strlfcreg = " "
                Else
                    strlfcreg = dtsrecepcion.Tables(0).Rows(0).Item("fcreporte")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("min") Is System.DBNull.Value Then
                    strlmin = " "
                Else
                    strlmin = dtsrecepcion.Tables(0).Rows(0).Item("min")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("telcontacto") Is System.DBNull.Value Then
                    strltelcontacto = " "
                Else
                    strltelcontacto = dtsrecepcion.Tables(0).Rows(0).Item("telcontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cliente") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("cliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("equipo") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("equipo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tecnologia") Is System.DBNull.Value Then
                    strltecnologia = " "
                Else
                    strltecnologia = dtsrecepcion.Tables(0).Rows(0).Item("tecnologia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipofalla") Is System.DBNull.Value Then
                    strltiposoporte = " "
                Else
                    strltiposoporte = dtsrecepcion.Tables(0).Rows(0).Item("tipofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("ciudad") Is System.DBNull.Value Then
                    strllugar = " "
                Else
                    strllugar = dtsrecepcion.Tables(0).Rows(0).Item("ciudad")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("solicitud") Is System.DBNull.Value Then
                    strlobsini = " "
                Else
                    strlobsini = dtsrecepcion.Tables(0).Rows(0).Item("solicitud")
                End If
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
                If dtsrecepcion.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dtsrecepcion.Tables(0).Rows(0).Item("barrio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fcreporte") Is System.DBNull.Value Then
                    strlcasfcregistro = " "
                Else
                    strlcasfcregistro = dtsrecepcion.Tables(0).Rows(0).Item("fcreporte")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("telcontacto") Is System.DBNull.Value Then
                    strltelalt = " "
                Else
                    strltelalt = dtsrecepcion.Tables(0).Rows(0).Item("telcontacto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("canal") Is System.DBNull.Value Then
                    _Bandeja = " "
                Else
                    _Bandeja = dtsrecepcion.Tables(0).Rows(0).Item("canal")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("distribuidor") Is System.DBNull.Value Then
                    strlpreg3 = " "
                Else
                    strlpreg3 = dtsrecepcion.Tables(0).Rows(0).Item("distribuidor")
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

    Public Function Consulta_Municipio_Distribuidores() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select coddiv,coddpto,codmun from Bandeja_alt BA inner join Divipola DP on BA.Municipio_inc=DP.coddiv where BA.idcaso = @strlcaso "
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("coddiv") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dts.Tables(0).Rows(0).Item("coddiv")
                End If
                If dts.Tables(0).Rows(0).Item("coddpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dts.Tables(0).Rows(0).Item("coddpto")
                End If
            Else
                strldpto = " "
                strlmun = " "
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


    Public Sub registrodilo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If strlpreg2 <> Nothing Then
                cms.CommandText = "INSERT INTO crmdilo(mesaesc,idcasodilo,fcregistro,idusuario,obs,tipo_soporte,tipificacion,incidente,estadoinc,mun,barrio,preg2,preg3,PQR,Fc_programado,Numero_alt) values(@strlmesaesc,@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strlincidente,@strlestadoinc,@strlmun,@strlbarrio,@strlpreg2,@strlpreg3,@strlpqr,@strlhoraprog,@strltelalt)"
                cms.Parameters.Add("@strlpreg2", SqlDbType.VarChar, 255).Value = strlpreg2
                cms.Parameters.Add("@strlpreg3", SqlDbType.VarChar, 255).Value = strlpreg3
            Else
                cms.CommandText = "INSERT INTO crmdilo(mesaesc,idcasodilo,fcregistro,idusuario,obs,tipo_soporte,tipificacion,incidente,estadoinc,mun,barrio,PQR,Fc_programado,Numero_alt) values(@strlmesaesc,@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strlincidente,@strlestadoinc,@strlmun,@strlbarrio,@strlpqr,@strlhoraprog,@strltelalt)"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            cms.Parameters.Add("@strlincidente", SqlDbType.VarChar, 100).Value = strlincidente
            cms.Parameters.Add("@strlestadoinc", SqlDbType.VarChar, 100).Value = strlestadoinc
            cms.Parameters.Add("@strlmesaesc", SqlDbType.VarChar, 100).Value = strlmesaesc
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 100).Value = strlmun
            cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar, 255).Value = strlbarrio
            cms.Parameters.Add("@strltiposoporte", SqlDbType.VarChar, 255).Value = strltiposoporte
            cms.Parameters.Add("@strlpqr", SqlDbType.BigInt).Value = strlpqr

            If strlhoraprog = Nothing Then
                cms.Parameters.AddWithValue("@strlhoraprog", DBNull.Value)
            Else
                cms.Parameters.Add("@strlhoraprog", SqlDbType.VarChar, 255).Value = strlhoraprog
            End If
            If strltelalt = Nothing Then
                cms.Parameters.AddWithValue("@strltelalt", DBNull.Value)
            Else
                cms.Parameters.Add("@strltelalt", SqlDbType.VarChar).Value = strltelalt
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

    Public Sub modificarbandejadilo()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja_alt SET estado= @strltipificacion, Tipo_canal=@_Tipo_Canal, Estacion_Base=@_Estacion_base,Municipio_inc=@strllugar,distribuidor =@strlpreg3 WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = strltipificacion
            cms.Parameters.Add("@_Tipo_Canal", SqlDbType.VarChar, 50).Value = _Tipo_Canal
            cms.Parameters.Add("@_Estacion_base", SqlDbType.VarChar, 50).Value = _Estacion_base
            cms.Parameters.Add("@strllugar", SqlDbType.VarChar, 50).Value = strllugar
            cms.Parameters.Add("@strlpreg3", SqlDbType.VarChar, 50).Value = strlpreg3
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



    Public Function consultaN3() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT estadon3,cas_id,cas_fecha_registro,cas_observaciones,min_ac,custcode_ac,nom_cliente,no_documento,plan_acual_ac,equipo_ac,telefono_contac,correo_electronico,estado,tipo_asunto,fcingn3,pqr,ingremite FROM Bandeja where fcingn3 is not null order by cas_id desc"
            If strltipificacion <> "" Then
                cms.CommandText = "SELECT estadon3,cas_id,cas_fecha_registro,cas_observaciones,min_ac,custcode_ac,nom_cliente,no_documento,plan_acual_ac,equipo_ac,telefono_contac,correo_electronico,estado,tipo_asunto,fcingn3,pqr,ingremite FROM Bandeja where fcingn3 is not null and estadon3=@strltipificacion order by cas_id desc"
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = Me.strltipificacion
            End If
            If strlfcini <> "" Then
                cms.CommandText = "SELECT estadon3,cas_id,cas_fecha_registro,cas_observaciones,min_ac,custcode_ac,nom_cliente,no_documento,plan_acual_ac,equipo_ac,telefono_contac,correo_electronico,estado,tipo_asunto,fcingn3,pqr,ingremite FROM Bandeja where fcingn3 is not null and cas_fecha_registro >= @strlfcini order by cas_id desc"
                cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = Me.strlfcini
                If strlfcfin <> "" Then
                    cms.CommandText = "SELECT estadon3,cas_id,cas_fecha_registro,cas_observaciones,min_ac,custcode_ac,nom_cliente,no_documento,plan_acual_ac,equipo_ac,telefono_contac,correo_electronico,estado,tipo_asunto,fcingn3,pqr,ingremite FROM Bandeja where fcingn3 is not null and cas_fecha_registro >= @strlfcini and cas_fecha_registro <= @strlfcfin order by cas_id desc"
                    cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = Me.strlfcfin
                End If
            End If
            If strlfcini3 <> "" Then
                cms.CommandText = "SELECT estadon3,cas_id,cas_fecha_registro,cas_observaciones,min_ac,custcode_ac,nom_cliente,no_documento,plan_acual_ac,equipo_ac,telefono_contac,correo_electronico,estado,tipo_asunto,fcingn3,pqr,ingremite FROM Bandeja where fcingn3 is not null and fcingn3 >= @strlfcini3 order by cas_id desc"
                cms.Parameters.Add("@strlfcini3", SqlDbType.VarChar, 50).Value = Me.strlfcini3
                If strlfcfin3 <> "" Then
                    cms.CommandText = "SELECT estadon3,cas_id,cas_fecha_registro,cas_observaciones,min_ac,custcode_ac,nom_cliente,no_documento,plan_acual_ac,equipo_ac,telefono_contac,correo_electronico,estado,tipo_asunto,fcingn3,pqr,ingremite FROM Bandeja where fcingn3 is not null and fcingn3 >= @strlfcini3 and fcingn3 <= @strlfcfin3 order by cas_id desc"
                    cms.Parameters.Add("@strlfcfin3", SqlDbType.VarChar, 50).Value = Me.strlfcfin3
                End If
            End If
            If strlingn3 <> "" Then
                cms.CommandText = "SELECT estadon3,cas_id,cas_fecha_registro,cas_observaciones,min_ac,custcode_ac,nom_cliente,no_documento,plan_acual_ac,equipo_ac,telefono_contac,correo_electronico,estado,tipo_asunto,fcingn3,pqr,ingremite FROM Bandeja where fcingn3 is not null and ingremite like '%'+@strlingn3+'%' order by cas_id desc"
                cms.Parameters.Add("@strlingn3", SqlDbType.VarChar, 50).Value = Me.strlingn3
                If strltipificacion <> "" Then
                    cms.CommandText = "SELECT estadon3,cas_id,cas_fecha_registro,cas_observaciones,min_ac,custcode_ac,nom_cliente,no_documento,plan_acual_ac,equipo_ac,telefono_contac,correo_electronico,estado,tipo_asunto,fcingn3,pqr,ingremite FROM Bandeja where fcingn3 is not null and estadon3=@strltipificacion and ingremite like '%'+@strlingn3+'%' order by cas_id desc"
                End If
            End If
            If strlcaso <> "" Then
                cms.CommandText = "SELECT * FROM Bandeja_alt LEFT OUTER JOIN CRMdilo ON Bandeja_alt.idcaso = CRMdilo.idcasodilo WHERE idcaso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = Me.strlcaso
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
    Public Sub modificaN3()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja SET fcingn3=@strlfcingn3, pqr=@strlpqr, ingremite=@strlingn3, estadon3='Abierto' WHERE cas_id= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcingn3", SqlDbType.VarChar, 50).Value = strlfcingn3
            cms.Parameters.Add("@strlpqr", SqlDbType.VarChar, 5).Value = strlpqr
            cms.Parameters.Add("@strlingn3", SqlDbType.VarChar, 255).Value = strlingn3
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
    Public Sub registroingclaro()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO ingenieroclaro(ingclaro) values(@strlingn3)"
            cms.Parameters.Add("@strlingn3", SqlDbType.NVarChar, 255).Value = strlingn3
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
    Public Function consultaprodind() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * from crmdetalle where idusuario=@strlidusuario order by fcreg desc"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            If strlfcini3 <> "" Then
                cms.CommandText = "SELECT * from crmdetalle where idusuario=@strlidusuario and fcreg>=@strlfcini3 order by fcreg desc"
                cms.Parameters.Add("@strlfcini3", SqlDbType.VarChar, 50).Value = Me.strlfcini3
                If strlfcfin3 <> "" Then
                    cms.CommandText = "SELECT * from crmdetalle where idusuario=@strlidusuario and fcreg>=@strlfcini3 and fcreg<=@strlfcfin3 order by fcreg desc"
                    cms.Parameters.Add("@strlfcfin3", SqlDbType.VarChar, 50).Value = Me.strlfcfin3
                End If
            End If
            If strltipificacion <> "" And strlfcini3 <> "" Then
                cms.CommandText = "SELECT * from crmdetalle where idusuario=@strlidusuario and tipificacion=@strltipificacion and fcreg>=@strlfcini3 order by fcreg desc"
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = Me.strltipificacion
            End If
            If strltipificacion <> "" And strlfcini3 <> "" And strlfcfin3 <> "" Then
                cms.CommandText = "SELECT * from crmdetalle where idusuario=@strlidusuario and tipificacion=@strltipificacion and fcreg>=@strlfcini3 and fcreg<=@strlfcfin3 order by fcreg desc"
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
    Public Function consultaprodgral() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT cargo, CRMDetalle.idusuario, nombreu, COUNT(*) AS Casos FROM CRMDetalle INNER JOIN usuarios ON CRMDetalle.idusuario = usuarios.idusuario WHERE MONTH(fcreg)=@strlfcini3 AND (tipificacion = N'cerrado' OR tipificacion = N'escalado') GROUP BY dbo.CRMDetalle.idusuario, dbo.usuarios.nombreu, dbo.usuarios.cargo"
            cms.Parameters.Add("@strlfcini3", SqlDbType.Int).Value = Me.strlfcini3
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
    Public Sub registroconexred()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion1").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO registroinb(id,solicitud,tipificacion,idusuario,fcregistro) values(@strlcaso,@strlobs,@strltipificacion,@strlidusuario,@strlfcreg)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
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
    Public Function consultacasoconexred() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion1").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT * from registroinb where id=@strlcaso ORDER BY idreg DESC"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
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
    Public Sub regpriorizacion()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO prioridad(caso,telalt,obs,fcreg,idusuario,mesa) values(@strlcaso,@strltelalt,@strlobs,@strlfcreg,@strlidusuario,@strlmesa)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strltelalt", SqlDbType.VarChar, 100).Value = strltelalt
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlmesa", SqlDbType.VarChar, 50).Value = strlmesa
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
    Public Function casosasociados() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlmin <> Nothing Then
                cms.CommandText = "select cas_id, min_ac, estado from Bandeja where estado <>'cerrado' and estado<>'escalado' and estado<>'ilocalizable' and min_ac=@strlmin"
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
    Public Function consultagral() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim strlwhere As String = ""
        Try
            cn.Open()
            If strlmin <> "" Then
                strlwhere = "where min_ac=@strlmin order by cas_id desc"
                cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 50).Value = Me.strlmin
            End If
            If strlcliente <> "" Then
                strlwhere = "where nom_cliente like '%'+@strlcliente+'%' order by cas_id desc"
                cms.Parameters.Add("@strlcliente", SqlDbType.VarChar, 100).Value = Me.strlcliente
            End If
            If strltelalt <> "" Then
                strlwhere = "where telefono_contac like '%'+@strltelalt+'%' order by cas_id desc"
                cms.Parameters.Add("@strltelalt", SqlDbType.VarChar, 100).Value = Me.strltelalt
            End If
            If strlfallatec <> "" Then
                strlwhere = "where fallatec is not null and (estadofallatec is null or estadofallatec='' or estadofallatec='0') order by cas_id"
            End If
            If strlfcsap <> "" Then
                strlwhere = "where fcsap=@strlfcsap  order by cas_id"
                cms.Parameters.Add("@strlfcsap", SqlDbType.VarChar, 50).Value = Me.strlfcsap
                If strlfallatec <> "" Then
                    strlwhere = "where fallatec is not null and (estadofallatec is null or estadofallatec='' or estadofallatec='0') and fcsap=@strlfcsap order by cas_id"
                End If
            End If
            If mesa <> "" Then
                strlwhere = "where bandeja=@strlmesa  order by cas_fecha_registro DESC"
                cms.Parameters.Add("@strlmesa", SqlDbType.VarChar, 50).Value = Me.strlmesa
                If strltipificacion <> "" Then
                    strlwhere = "where bandeja=@strlmesa and b.estado=@strltipificacion order by cas_fecha_registro DESC"
                    cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = Me.strltipificacion
                End If
            End If
            If strlnit <> "" Then
                strlwhere = "where no_documento=@strlnit"
                cms.Parameters.Add("@strlnit", SqlDbType.VarChar, 50).Value = Me.strlnit
            End If
            If strlfechainicial <> "" Then
                strlwhere = "where cas_fecha_registro >= @fechainicial"
                cms.Parameters.Add("@fechainicial", SqlDbType.VarChar, 50).Value = Me.strlfechainicial
            End If
            If strlfechafin <> "" Then
                strlwhere = "where cas_fecha_registro <= @fechafin"
                cms.Parameters.Add("@fechafin", SqlDbType.VarChar, 50).Value = Me.strlfechafin
            End If
            If strlfechainicial <> "" And strlfechafin <> "" Then
                strlwhere = "where cas_fecha_registro between @fechainicial and @fechafin"
            End If
            If strlfechainicial <> "" And strlnit <> "" Then
                strlwhere = "where no_documento=@strlnit and cas_fecha_registro >= @fechainicial"
            End If
            If strlfechafin <> "" And strlnit <> "" Then
                strlwhere = "where no_documento=@strlnit and cas_fecha_registro <= @fechafin"
            End If
            If strlfechainicial <> "" And strlfechafin <> "" And strlnit <> "" Then
                strlwhere = "where no_documento=@strlnit and cas_fecha_registro between @fechainicial and @fechafin"
            End If
            If strlfechainicial <> "" And strlcliente <> "" Then
                strlwhere = "where nom_cliente like '%'+@strlcliente+'%' and cas_fecha_registro >= @fechainicial"
            End If
            If strlfechafin <> "" And strlcliente <> "" Then
                strlwhere = "where nom_cliente like '%'+@strlcliente+'%' and cas_fecha_registro <= @fechafin"
            End If
            If strlfechainicial <> "" And strlfechafin <> "" And strlcliente <> "" Then
                strlwhere = "where nom_cliente like '%'+@strlcliente+'%' and cas_fecha_registro between @fechainicial and @fechafin"
            End If

            '/**************** CONSULTA ****************/
            If strlcaso <> "" Then
                Dim cms2 As New SqlClient.SqlCommand
                Dim dtsrecepcion2 As New DataSet
                cms2.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
                cms2.CommandText = "select top 1 idcaso, fcreg from datosclaro.dbo.Detalle_diagnostico WHERE idcaso = @strlcaso order by fcreg desc"
                cms2.Connection = cn
                Dim dtarecepcion2 = New SqlClient.SqlDataAdapter(cms2)
                dtarecepcion2.Fill(dtsrecepcion2)
                Dim Fecha As DateTime = dtsrecepcion2.Tables(0).Rows(0).Item("fcreg")
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
                If Fecha >= "02/12/2015 16:00:00" Then
                    cms.CommandText = "select top 1 bandeja,cas_id, cas_fecha_registro, min_ac, nom_cliente, plan_acual_ac,equipo_ac, telefono_contac, b.ciudad, b.estado, fcingn3, ingremite, estadon3,fallatec,fcsap, estadofallatec,f.cpd,f.estadocpd,s.tickler As SD ,dq.tipo2 As Servicio ,dd.tipofalla,d.tipificacion3 As Elemento ,d.tipificacion1 As Causa_Raiz ,t.tipificacion1 As Categoria_de_Cierre from datosclaro.dbo.Bandeja b left join clarovoz.dbo.vfallared f ON b.cas_id = f.idcaso left join datosclaro.dbo.servicedetalle s on b.cas_id=s.idcaso left join datosclaro.dbo.Detalle_diagnostico dd on b.cas_id = dd.idcaso left join datosclaro.dbo.Diagnostico dq on dq.idreg = dd.idsolicitud Left join datosclaro.dbo.Tipificaciones d on d.cod_tipificacion = dd.Causa_Raiz left join datosclaro.dbo.Tipificaciones t on t.cod_tipificacion = dd.Categoria_Cierre and t.pertenece = 'Categoria Cierre' WHERE dd.idcaso = @strlcaso order by dd.idreg desc"
                Else
                    cms.CommandText = "select top 1 bandeja,cas_id, cas_fecha_registro, min_ac, nom_cliente, plan_acual_ac, equipo_ac, telefono_contac, b.ciudad, b.estado, fcingn3, ingremite, estadon3,fallatec, fcsap, estadofallatec,f.cpd,f.estadocpd,s.tickler AS SD ,dq.tipo2 AS Servicio ,dd.tipofalla, d.tipo2 As Elemento ,d.detalle As Causa_Raiz ,dx.tipificacion As Categoria_de_Cierre from datosclaro.dbo.Bandeja b left join clarovoz.dbo.vfallared f ON b.cas_id = f.idcaso left join datosclaro.dbo.servicedetalle s on b.cas_id=s.idcaso left join datosclaro.dbo.Detalle_diagnostico dd on b.cas_id = dd.idcaso left join datosclaro.dbo.Diagnostico dq on dq.idreg = dd.idsolicitud Left join datosclaro.dbo.Diagnostico d on d.idreg = dd.Causa_Raiz Left join datosclaro.dbo.Diagnostico dx on dx.idreg = dd.Categoria_Cierre WHERE dd.idcaso = @strlcaso order by dd.idreg desc"
                End If
            Else
                cms.CommandText = "select top 5000 bandeja,fallatec, estadofallatec, fcsap,cas_id, cas_fecha_registro, min_ac, nom_cliente, plan_acual_ac, equipo_ac, telefono_contac, b.ciudad, b.estado, fcingn3, ingremite, estadon3,f.cpd,f.estadocpd,s.tickler from datosclaro.dbo.Bandeja b left join clarovoz.dbo.vfallared f ON b.cas_id = f.idcaso left join datosclaro.dbo.servicedetalle s on b.cas_id=s.idcaso " & strlwhere & ""
            End If
            '*****************************************

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


    Public Function consultaseg() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> "" Then
                cms.CommandText = "select fcprogram,fallared,idcaso, min_ac, fcreg, idusuario, obs, Tipificacion, numalt from CRMDetalle inner join Bandeja on CRMDetalle.idcaso=Bandeja.cas_id where idcaso=@strlcaso order by fcreg"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            If strlmin <> "" Then
                cms.CommandText = "select fcprogram,fallared,idcaso, min_ac, fcreg, idusuario, obs, Tipificacion, numalt from CRMDetalle inner join Bandeja on CRMDetalle.idcaso=Bandeja.cas_id where min_ac=@strlmin  order by fcreg"
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
    Public Function consultamarc() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> "" Then
                cms.CommandText = "select call.estado, agente, duracion, contrato, Lista, min_ac, fcregistro from call inner join Bandeja on call.contrato=Bandeja.cas_id where contrato=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            ElseIf strlmin <> "" Then
                cms.CommandText = "select call.estado, agente, duracion, contrato, Lista, min_ac, fcregistro from call inner join Bandeja on call.contrato=Bandeja.cas_id where min_ac=@strlmin order by contrato desc"
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


    Public Function consultaprioridad() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT caso FROM prioridad where caso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
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
    Public Sub registroconsultacaso()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO regconsulta(idcaso,fcconsulta,idusuario) values(@strlcaso,@strlfcreg,@strlidusuario)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Sub registrocrmcontrol()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO crmcontrol(tlinea,servreest,fcreestab,aplicaajuste,solicajuste,nompaquete,vlrpaquete,diasserv,idcasoctrl,fcregistro,idusuario,obs,tipificacion,soporte,mesaesc) values(@strltlinea,@strlservreest,@strlfcrest,@strlaplicaajuste,@strlsolicajuste,@strlnompaquete,@strlvlrpaquete,@strldias,@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltipificacion,@strltiposoporte,@strlmesa)"

            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = strltipificacion
            cms.Parameters.Add("@strltiposoporte", SqlDbType.VarChar, 5).Value = strltiposoporte
            cms.Parameters.Add("@strlmesa", SqlDbType.VarChar, 50).Value = strlmesa

            cms.Parameters.Add("@strltlinea", SqlDbType.VarChar, 50).Value = strltlinea
            cms.Parameters.Add("@strlservreest", SqlDbType.VarChar, 5).Value = strlservreest
            cms.Parameters.Add("@strlfcrest", SqlDbType.Date).Value = strlfcrest
            cms.Parameters.Add("@strlaplicaajuste", SqlDbType.VarChar, 5).Value = strlaplicaajuste
            cms.Parameters.Add("@strlsolicajuste", SqlDbType.VarChar, 5).Value = strlsolicajuste
            cms.Parameters.Add("@strlnompaquete", SqlDbType.VarChar, 255).Value = strlnompaquete
            cms.Parameters.Add("@strlvlrpaquete", SqlDbType.Decimal).Value = strlvlrpaquete
            cms.Parameters.Add("@strldias", SqlDbType.Int).Value = strldias
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
    Public Sub modificarbandejacontrol()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja_control SET estado= @strltipificacion WHERE id= @strlcaso"
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
    Public Function consultacasocontrol() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT  idcrmcontrol,id,fcsap,mintel,nombrecliente,tickler,estado,fcregistro,idusuario,obs,tipificacion,soporte,mesaesc FROM Bandeja_control LEFT OUTER JOIN CRMcontrol ON Bandeja_control.id = CRMcontrol.idcasoctrl where id=@strlcaso ORDER BY idcrmcontrol DESC"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("id") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("id")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fcsap") Is System.DBNull.Value Then
                    strlfcsap = " "
                Else
                    strlfcsap = dtsrecepcion.Tables(0).Rows(0).Item("fcsap")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("mintel") Is System.DBNull.Value Then
                    strlmin = " "
                Else
                    strlmin = dtsrecepcion.Tables(0).Rows(0).Item("mintel")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nombrecliente") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("nombrecliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tickler") Is System.DBNull.Value Then
                    strltickler = " "
                Else
                    strltickler = dtsrecepcion.Tables(0).Rows(0).Item("tickler")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("estado")
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
    Public Function estadisticagral() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT estado, COUNT(cas_id) AS Casos FROM Bandeja WHERE (cas_fecha_registro > @strlfcini) AND (cas_fecha_registro < @strlfcfin) GROUP BY estado ORDER BY estado"
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
    Public Function estadisticaptes() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT COUNT(cas_id) AS Casos FROM Bandeja WHERE (cas_fecha_registro > @strlfcini) AND (cas_fecha_registro < @strlfcfin) AND (estado <> N'cerrado') AND (estado <> N'escalado') AND (estado <> N'ilocalizable')"
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
    Public Function estadisticailoc() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT COUNT(cas_id) AS Casos FROM Bandeja WHERE (cas_fecha_registro > @strlfcini) AND (cas_fecha_registro < @strlfcfin) AND (estado <> N'cerrado') AND (estado <> N'escalado')"
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
    Public Function estadisticagestion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT COUNT(cas_id) AS Casos FROM Bandeja WHERE (cas_fecha_registro > @strlfcini) AND (cas_fecha_registro < @strlfcfin) AND (estado <> N'abierto')"
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
    Public Function consultaenprocdigitadt() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT iddigitador, COUNT(cas_id) AS casos FROM Bandeja WHERE estado='Solicitud ilocalizar' AND fcdigitado IS NULL AND fcasignado is not null GROUP BY iddigitador"
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
    Public Function consultapteasignartotaldigitacdt() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT cas_id FROM bandeja where estado='Solicitud ilocalizar' and fcasignado is null"
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
    Public Function consultapteasignardigitadt() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "cas_id,cas_fecha_registro,min_ac,estado,digitado,fcsap FROM Bandeja where estado='Solicitud ilocalizar' and fcasignado is null"
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
    Public Sub asignaescalaxcasodigdt()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja SET iddigitador=@strlidusuario, fcasignado=@strlfcreg, idusuarioasigna=@strlidcrm WHERE cas_id= @strlcaso"
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
    Public Function consultaasigxusudigidt() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT cas_id,cas_fecha_registro,min_ac,nom_cliente,fcasignado,idusuarioasigna,fcsap FROM bandeja where fcasignado is not null and digitado is null and iddigitador=@strlidusuario order by cas_id"
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
    Public Sub actualizadigitdt()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja SET digitado='1',tipocierre=@strldir, fcdigitado=@strlfcreg,estadofallatec='Ilocalizable' WHERE cas_id= @strlcaso"
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
    Public Sub registroinc()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            Dim Frag_Col As String = Nothing
            Dim Frag_Val As String = Nothing

            If strlestadoinc <> Nothing Then
                cms.Parameters.AddWithValue("@strlestadoinc", strlestadoinc)
                Frag_Val = Frag_Val & ",@strlestadoinc"
            Else
                Frag_Val = ",'Reportado'"
            End If
            If strlfcreg = Nothing Then
                strlfcreg = Now
            End If

            cms.CommandText = "INSERT INTO detalleinc(nivel,idcaso,obsinc,idtipoinc,fcreg,idusuariorep,Registro_Numerico,custcode,usuario_reporta,Ubicacion_call,estado" & Frag_Col & ") values (@strlbarrio,@strlcaso,@strlobs,@strlincidente,@strlfcreg,@strlidusuario,@registro_numerico,@strlcustcode,@strlusuarioreporta,@strllugar " & Frag_Val & ")"
            'If strlestadoinc <> Nothing Then
            cms.Parameters.AddWithValue("@strlusuarioreporta", strlusuarioreporta)
            cms.Parameters.AddWithValue("@strlcustcode", strlcustcode)
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlincidente", SqlDbType.Int).Value = strlincidente
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar, 50).Value = strlbarrio
            cms.Parameters.Add("@strllugar", SqlDbType.VarChar, 50).Value = strllugar
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


    Public Function Consulta_Sin_Restriccion_Envio_Inconsistencia() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.open()
            cms.CommandText = "Select * from usuarios where idusuario=@strlidusuario and cargo like '%QA_%'"
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 20).Value = strlidusuario
            cms.connection = cn
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
    Public Function consultaincons() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT nivel,cas_id, min_ac, cas_fecha_registro, obsinc, DI.idtipoinc, inconsistencia, Bandeja.estado, usuario_registra, idusuariorep, custcode_ac,Bandeja, Registro_Numerico FROM Detalleinc DI INNER JOIN (select cas_id, min_ac, cas_fecha_registro,bandeja.estado, usuario_registra,custcode_ac,'Datos' as Bandeja  from Bandeja union select idcaso, min, fcreporte, estado ,' ' ,' ','Dilo' from Bandeja_alt union select id_caso,min,fc_reg,Estado,' ',' ','Fidelizacion' from Bandeja_Falla_Desactivacion_D_V UNION select Id_Caso,Min,Fecha_registro,Estado,' ',' ','Inbound' from Bandeja_inbound) as Bandeja ON DI.idcaso = Bandeja.cas_id  inner join Inconsistencia I ON DI.idtipoinc = I.idtipoinc where DI.estado='Reportado'"
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT nivel,cas_id, min_ac, cas_fecha_registro, obsinc, DI.idtipoinc, inconsistencia, Bandeja.estado, usuario_registra, idusuariorep, custcode_ac,Bandeja, Registro_Numerico FROM Detalleinc DI INNER JOIN (select cas_id, min_ac, cas_fecha_registro,bandeja.estado, usuario_registra,custcode_ac,'Datos' as Bandeja  from Bandeja union select idcaso, min, fcreporte, estado ,' ' ,' ','Dilo' from Bandeja_alt union select id_caso,min,fc_reg,Estado,' ',' ','Fidelizacion' from Bandeja_Falla_Desactivacion_D_V UNION select Id_Caso,Min,Fecha_registro,Estado,' ',' ','Inbound' from Bandeja_inbound) as Bandeja ON DI.idcaso = Bandeja.cas_id  inner join Inconsistencia I ON DI.idtipoinc = I.idtipoinc where DI.estado='Reportado' and di.idcaso=@strlcaso"
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

    Public Sub actualizainc()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
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
    Public Function consultaaprobado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT nivel,cas_id, min_ac, cas_fecha_registro, obsinc, Detalleinc.idtipoinc, inconsistencia, Bandejas.estado, usuario_registra, idusuariorep, custcode_ac, Bandejas.bandeja FROM Detalleinc INNER JOIN (	select cas_id, min_ac, cas_fecha_registro,estado,usuario_registra,custcode_ac,'Datos' as bandeja  from bandeja 	Union 	select idcaso,min, fcreporte,estado, usuario_registra,' ','Dilo' as bandeja   from Bandeja_alt 	union 	select Id_Caso,Min,fc_reg, Estado,' ',' ' ,'Fidelizacion' as bandeja from Bandeja_Falla_Desactivacion_D_V union select Id_Caso,Min,Fecha_registro, Estado,' ',' ' ,'Inbound' as bandeja from Bandeja_inbound) AS  Bandejas ON Detalleinc.idcaso = Bandejas.cas_id INNER JOIN Inconsistencia ON Detalleinc.idtipoinc = Inconsistencia.idtipoinc where detalleinc.estado='Aprobado'"
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
    Public Sub envioinc()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
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
    Public Function consultainc() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = ""
        Try
            If strltipificacion <> "" Then
                WHERE = WHERE & " And DI.estado=@strltipificacion "
            End If
            If strlcaso <> "" Then
                WHERE = WHERE & " And Bandejas.cas_id=@strlcaso "
            End If
            If strlfcini <> "" Then
                WHERE = WHERE & " And cas_fecha_registro >= @strlfcini "
                If strlfcfin <> "" Then
                    WHERE = WHERE & " And cas_fecha_registro >= @strlfcini and cas_fecha_registro <= @strlfcfin "
                End If
            End If
            If strlbarrio <> "" Then
                WHERE = WHERE & " And nivel =@strlbarrio "
            End If
            cn.Open()
            cms.CommandText = "SELECT nivel,cas_id,min_ac,cas_fecha_registro,obsinc,DI.idtipoinc,inconsistencia,Bandejas.estado,usuario_registra,idusuariorep,custcode_ac,DI.estado as estadoinc,fcreg,fcrev,idusuariorev,fcenvio,idusuarioenv,bandeja FROM Detalleinc DI inner join (select cas_id, min_ac, cas_fecha_registro,estado,usuario_registra,custcode_ac,'Datos' as bandeja  from bandeja Union select idcaso,min, fcreporte,estado, usuario_registra,' ','Dilo' as bandeja   from Bandeja_alt union select Id_Caso,Min,fc_reg, Estado,' ',' ' ,'Fidelizacion' as bandeja from Bandeja_Falla_Desactivacion_D_V union select Id_Caso,Min,Fecha_registro, Estado,' ',' ' ,'Inbound' as bandeja from Bandeja_inbound) AS  Bandejas  ON DI.idcaso = Bandejas.cas_id inner join Inconsistencia I ON DI.idtipoinc = I.idtipoinc WHERE 1=1 " & WHERE & " "
            If strlcaso = Nothing Then
                cms.Parameters.AddWithValue("@strlcaso", DBNull.Value)
            Else
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            End If
            If strltipificacion = Nothing Then
                cms.Parameters.AddWithValue("@strltipificacion", DBNull.Value)
            Else
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = strltipificacion
            End If
            If strlfcini = Nothing Then
                cms.Parameters.AddWithValue("@strlfcini", DBNull.Value)
            Else
                cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = strlfcini
            End If
            If strlfcfin = Nothing Then
                cms.Parameters.AddWithValue("@strlfcfin", DBNull.Value)
            Else
                cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = strlfcfin
            End If
            If strlbarrio = Nothing Then
                cms.Parameters.AddWithValue("@strlbarrio", DBNull.Value)
            Else
                cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar, 50).Value = strlbarrio
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


    Public Function casosmes() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
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
            cms.CommandText = "SELECT MONTH(cas_fecha_registro) AS mes, YEAR(cas_fecha_registro) AS año, COUNT(cas_id) AS casos FROM Bandeja GROUP BY MONTH(cas_fecha_registro), YEAR(cas_fecha_registro) HAVING (MONTH(cas_fecha_registro) = @strlfcreg) AND (YEAR(cas_fecha_registro) = @strlfcini)"
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
    Public Function casosmescierre() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
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
            cms.CommandText = "SELECT MONTH(cas_fecha_registro) AS mes, YEAR(cas_fecha_registro) AS año, COUNT(cas_id) AS casos FROM Bandeja GROUP BY MONTH(cas_fecha_registro), YEAR(cas_fecha_registro), estado  HAVING (MONTH(cas_fecha_registro) = @strlfcreg) AND (YEAR(cas_fecha_registro) = @strlfcini) AND (estado = N'cerrado')"
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
    Public Function casosmescierreact() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Month(Now)
            strlfcini = Year(Now)
            cms.CommandText = "SELECT MONTH(cas_fecha_registro) AS mes, YEAR(cas_fecha_registro) AS año, COUNT(cas_id) AS casos FROM Bandeja GROUP BY MONTH(cas_fecha_registro), YEAR(cas_fecha_registro), estado  HAVING (MONTH(cas_fecha_registro) = @strlfcreg) AND (YEAR(cas_fecha_registro) = @strlfcini) AND (estado = N'cerrado')"
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
    Public Function personaldisp() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Month(Now)
            strlfcini = Year(Now)
            cms.CommandText = "SELECT idusuario, MONTH(fcreg) AS mes, YEAR(fcreg) AS año, COUNT(idcaso) AS casos FROM CRMDetalle GROUP BY MONTH(fcreg), YEAR(fcreg) , idusuario, fallared HAVING (MONTH(fcreg) = @strlfcreg) AND (YEAR(fcreg) = @strlfcini) and COUNT(idcaso)>100 and fallared is null"
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
    Public Function consultacasopqr() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT  idcrmpqr, min, nombrecli, tickler, fcsap, Bandeja_pqr.cun, estado, fcreg, idusuario, obs, tiposorporte, afecta, tiposoporte, tipofallacrm, tipif, tipofalla, tipo FROM Bandeja_pqr LEFT OUTER JOIN TipoFallaPQR INNER JOIN TipoSoporte_PQR INNER JOIN CRMpqr ON TipoSoporte_PQR.id = CRMpqr.tiposorporte ON TipoFallaPQR.id = CRMpqr.tipofallacrm ON Bandeja_pqr.cun = CRMpqr.cun where Bandeja_pqr.cun=@strlcaso order by idcrmpqr"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("nombrecli") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("nombrecli")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("min") Is System.DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dtsrecepcion.Tables(0).Rows(0).Item("min")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cun") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("cun")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tickler") Is System.DBNull.Value Then
                    strltickler = " "
                Else
                    strltickler = dtsrecepcion.Tables(0).Rows(0).Item("tickler")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fcsap") Is System.DBNull.Value Then
                    strlfcsap = " "
                Else
                    strlfcsap = dtsrecepcion.Tables(0).Rows(0).Item("fcsap")
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
    Public Function casosasociadospqr() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlmin <> Nothing Then
                cms.CommandText = "select cun, min, estado from Bandeja_pqr where estado <>'cerrado' and estado<>'ilocalizable' and estado<>'rechazado' and min=@strlmin"
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
    Public Sub registrocrmpqr()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO CRMpqr(cun,fcreg,idusuario,obs,tiposorporte,tipofallacrm,direcc,munic) values(@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strldir,@strlmun)"
            cms.Parameters.Add("@strlcaso", SqlDbType.NVarChar, 20).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltiposoporte", SqlDbType.Int).Value = strltiposoporte
            cms.Parameters.Add("@strltipificacion", SqlDbType.Int).Value = strltipificacion
            cms.Parameters.Add("@strldir", SqlDbType.VarChar, 255).Value = strldir
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 100).Value = strlmun
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
    Public Sub modificarbandejapqr()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If strltipificacion = "Cerrado" Then
                cms.CommandText = "UPDATE bandeja_pqr SET estado= 'CERRADO' WHERE cun= @strlcaso and estado <> 'cerrado'"
            End If
            If strltipificacion = "Rechazado" Then
                cms.CommandText = "UPDATE bandeja_pqr SET estado= 'RECHAZADO' WHERE cun= @strlcaso and estado <> 'cerrado' and estado <> 'RECHAZADO'"
            End If
            If strltipificacion = "Gestionado" Then
                cms.CommandText = "UPDATE bandeja_pqr SET estado= 'GESTIONADO' WHERE cun= @strlcaso and estado <> 'cerrado' and estado <> 'ilocalizable' and estado <> 'RECHAZADO'"
            End If
            If strltipificacion = "Ilocalizable" Then
                cms.CommandText = "UPDATE bandeja_pqr SET estado= 'ILOCALIZABLE' WHERE cun= @strlcaso and estado <> 'cerrado' and estado <> 'ilocalizable' and estado <> 'RECHAZADO'"
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
    Public Function consultaasignadodigitacdatos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT min_ac,cas_id,digitado,iddigitador,fcasignado,idusuarioasigna FROM Bandeja where iddigitador=@strlidusuario and digitado is null"
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
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja SET iddigitador=null, fcasignado=null, idusuarioasigna=null WHERE cas_id= @strlcaso"
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
    Public Sub registrodiag()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If Validacion = "Diagnostico Dilo y Fidelizacion" Then
                cms.CommandText = "INSERT INTO Detalle_Diagnostico_Otros(id_solicitud,Tipo_Falla,Variable,Id_Caso,Tipo_PQR,Tipo_Cliente,Modalidad,Causa_Raiz,Categoria_Cierre,Bandeja,Aplica_Fidelizacion,Inconsistencia_611,idservicio) values(@strlsolicitud,@strltipofalla,@strldiagvariable,@strlcaso,@_Tipo_PQR,@_Tipo_Cliente,@_Modalidad,@_Causa_Raiz,@_Categoria_Cierre,@_Bandeja,@_Aplica_Fidelizacion,@_inconsistencia_encuesta,@strlservicio)"
                If strlmun <> Nothing Then
                    cms.CommandText = "INSERT INTO Detalle_Diagnostico_Otros(id_solicitud,Tipo_Falla,Variable,Id_Caso,Tipo_PQR,Tipo_Cliente,Modalidad,Causa_Raiz,Categoria_Cierre,Bandeja,nunicipio,Aplica_Fidelizacion,Inconsistencia_611,idservicio) values(@strlsolicitud,@strltipofalla,@strldiagvariable,@strlcaso,@_Tipo_PQR,@_Tipo_Cliente,@_Modalidad,@_Causa_Raiz,@_Categoria_Cierre,@_Bandeja,@strlmun,@_Aplica_Fidelizacion,@_inconsistencia_encuesta,@strlservicio)"
                    cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 10).Value = strlmun
                End If
                If _Tipo_PQR_Adicional <> Nothing Or _Intension_Des_Por_Falla <> Nothing Or _Tipo_Proceso_Linea <> Nothing Then
                    cms.CommandText = "INSERT INTO Detalle_Diagnostico_Otros(id_solicitud,Tipo_Falla,Variable,Id_Caso,Tipo_PQR,Tipo_Cliente,Modalidad,Causa_Raiz,Categoria_Cierre,Bandeja,Tipo_PQR_Adicional,Intension_Des_Falla,Tipo_Proceso_Linea,Aplica_Fidelizacion,Inconsistencia_611,idservicio) values(@strlsolicitud,@strltipofalla,@strldiagvariable,@strlcaso,@_Tipo_PQR,@_Tipo_Cliente,@_Modalidad,@_Causa_Raiz,@_Categoria_Cierre,@_Bandeja,@_Tipo_PQR_Adicional,@_Intension_Des_Por_Falla,@_Tipo_Proceso_Linea,@_Aplica_Fidelizacion,@_inconsistencia_encuesta,@strlservicio)"
                    cms.Parameters.Add("@_Tipo_PQR_Adicional", SqlDbType.VarChar, 100).Value = _Tipo_PQR_Adicional
                    cms.Parameters.Add("@_Intension_Des_Por_Falla", SqlDbType.VarChar, 100).Value = _Intension_Des_Por_Falla
                    cms.Parameters.Add("@_Tipo_Proceso_Linea", SqlDbType.VarChar, 100).Value = _Tipo_Proceso_Linea
                End If
                If (_Tipo_PQR_Adicional <> Nothing Or _Intension_Des_Por_Falla <> Nothing Or _Tipo_Proceso_Linea <> Nothing) And strlmun <> Nothing Then
                    cms.CommandText = "INSERT INTO Detalle_Diagnostico_Otros(id_solicitud,Tipo_Falla,Variable,Id_Caso,Tipo_PQR,Tipo_Cliente,Modalidad,Causa_Raiz,Categoria_Cierre,Bandeja,nunicipio,Tipo_PQR_Adicional,Intension_Des_Falla,Tipo_Proceso_Linea,Aplica_Fidelizacion,Inconsistencia_611,idservicio) values(@strlsolicitud,@strltipofalla,@strldiagvariable,@strlcaso,@_Tipo_PQR,@_Tipo_Cliente,@_Modalidad,@_Causa_Raiz,@_Categoria_Cierre,@_Bandeja,@strlmun,@_Tipo_PQR_Adicional,@_Intension_Des_Por_Falla,@_Tipo_Proceso_Linea,@_Aplica_Fidelizacion,@_inconsistencia_encuesta,@strlservicio)"
                End If
                cms.Parameters.Add("@_Tipo_PQR", SqlDbType.VarChar, 100).Value = _Tipo_PQR
                cms.Parameters.Add("@_Tipo_Cliente", SqlDbType.VarChar, 100).Value = _Tipo_Cliente
                cms.Parameters.Add("@_Modalidad", SqlDbType.VarChar, 100).Value = _Modalidad
                cms.Parameters.Add("@_Causa_Raiz", SqlDbType.Int).Value = _Causa_Raiz
                cms.Parameters.Add("@_Categoria_Cierre", SqlDbType.Int).Value = _Categoria_Cierre
                cms.Parameters.Add("@strlcaso", SqlDbType.NVarChar, 20).Value = strlcaso
                cms.Parameters.Add("@_Bandeja", SqlDbType.VarChar, 100).Value = _Bandeja
                cms.Parameters.Add("@strldiagvariable", SqlDbType.Int).Value = strldiagvariable
                cms.Parameters.Add("@strlsolicitud", SqlDbType.Int).Value = strlsolicitud
                cms.Parameters.Add("@strltipofalla", SqlDbType.NVarChar, 255).Value = strltipofalla
                '------Inconsistencia------'
                cms.Parameters.Add("@_inconsistencia_encuesta", SqlDbType.NVarChar, 255).Value = _inconsistencia_encuesta
                If strlaplicaajuste <> Nothing Then
                    cms.Parameters.Add("@_Aplica_Fidelizacion", SqlDbType.VarChar, 5).Value = strlaplicaajuste
                Else
                    cms.Parameters.AddWithValue("@_Aplica_Fidelizacion", DBNull.Value)
                End If
                '''''Servicio''''
                If strlservreest <> Nothing Then
                    cms.Parameters.Add("@strlservicio", SqlDbType.VarChar, 5).Value = strlservreest
                Else
                    cms.Parameters.AddWithValue("@strlservicio", DBNull.Value)
                End If
                ''''''''''''''
                cms.Connection = cn
                cms.ExecuteNonQuery()
                Exit Sub
            End If

            cms.CommandText = "INSERT INTO detalle_diagnostico(WTF,idsolicitud,reclamppal,tipofalla,fcultimac,franjaultimac,tcierre,fcreg,idcaso,tecnologia,variable,nunicipio,barrio,CicloFactura,Equipo,Tipo_PQR,Tipo_Cliente,Modalidad,Causa_Raiz, Categoria_Cierre,Version_S_O_Equipo,Version_Facebook,Tipificacion_Interna,Inconsistencia_611,servicio) values(@_WTF,@strlsolicitud,@strlreclamoppal,@strltipofalla,@strlfcultimac,@strlfranjaultimac,@strldiagtcierre,@strlfcreg,@strlcaso,@strldiagtecnolog,@strldiagvariable,@strlmun,@strlbarrio,@_CicloFactura,@strlequipo,@_Tipo_PQR,@_Tipo_Cliente,@_Modalidad,@_Causa_Raiz, @_Categoria_Cierre,@_Version_S_O_Equipo,@_Version_Facebook,@_Tipificacion_Interna,@_inconsistencia_encuesta,@strlservreest)"
            cms.Parameters.Add("@strlcaso", SqlDbType.NVarChar, 20).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlequipo", SqlDbType.VarChar, 50).Value = strlequipo
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 10).Value = strlmun
            cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar, 255).Value = strlbarrio
            cms.Parameters.Add("@strldiagtecnolog", SqlDbType.VarChar, 100).Value = strldiagtecnolog
            cms.Parameters.Add("@strlfcultimac", SqlDbType.Date).Value = strlfcultimac
            cms.Parameters.Add("@strlfranjaultimac", SqlDbType.NVarChar, 10).Value = strlfranjaultimac
            cms.Parameters.Add("@strlsolicitud", SqlDbType.VarChar, 100).Value = strlsolicitud
            cms.Parameters.Add("@_Causa_Raiz", SqlDbType.VarChar, 100).Value = _Causa_Raiz
            cms.Parameters.Add("@_Categoria_Cierre", SqlDbType.VarChar, 100).Value = _Categoria_Cierre
            cms.Parameters.Add("@_Modalidad", SqlDbType.VarChar, 100).Value = _Modalidad
            cms.Parameters.Add("@_Tipo_PQR", SqlDbType.VarChar, 100).Value = _Tipo_PQR
            cms.Parameters.Add("@_inconsistencia_encuesta", SqlDbType.NVarChar, 255).Value = _inconsistencia_encuesta
            cms.Parameters.Add("@strldiagvariable", SqlDbType.VarChar, 100).Value = strldiagvariable
            '-NO SE USAN
            cms.Parameters.Add("@_WTF", SqlDbType.VarChar, 100).Value = _WTF
            cms.Parameters.Add("@_CicloFactura", SqlDbType.Int).Value = _CicloFactura
            cms.Parameters.Add("@strldiagtcierre", SqlDbType.VarChar, 100).Value = strldiagtcierre
            cms.Parameters.Add("@strlreclamoppal", SqlDbType.NVarChar, 255).Value = strlreclamoppal
            cms.Parameters.Add("@strltipofalla", SqlDbType.NVarChar, 255).Value = strltipofalla
            cms.Parameters.Add("@_Tipo_Cliente", SqlDbType.VarChar, 100).Value = _Tipo_Cliente
            cms.Parameters.Add("@_Version_S_O_Equipo", SqlDbType.VarChar, 100).Value = _Version_S_O_Equipo
            cms.Parameters.Add("@_Version_Facebook", SqlDbType.VarChar, 100).Value = _Version_Facebook
            If strlservreest = Nothing Then
                cms.Parameters.AddWithValue("@strlservreest", DBNull.Value)
            Else
                cms.Parameters.Add("@strlservreest", SqlDbType.VarChar, 100).Value = strlservreest
            End If
            If _Tipificacion_Interna = Nothing Then
                cms.Parameters.AddWithValue("@_Tipificacion_Interna", DBNull.Value)
            Else
                cms.Parameters.Add("@_Tipificacion_Interna", SqlDbType.VarChar, 100).Value = _Tipificacion_Interna
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





    Public Sub modificarbandejasup()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja SET estado= @strltipificacion WHERE cas_id= @strlcaso"
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
    Public Function Consultacasos_Datos_Voz_Bolchat() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim cnVoz As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cnDatos.Open()
            cms.CommandText = "select * from Bandeja_Bolt where Idcaso=@_Caso"
            cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If (strlcantidad > 0) Then
                If dts.Tables(0).Rows(0).Item("idcaso") Is DBNull.Value Then
                    strlcaso = ""
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("idcaso")
                End If
                If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                End If
                If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                    strlcliente = ""
                Else
                    strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                End If
                If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                    strlequipo = ""
                Else
                    strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                End If
                If dts.Tables(0).Rows(0).Item("Bandeja") Is DBNull.Value Then
                    strlmesa = ""
                Else
                    strlmesa = dts.Tables(0).Rows(0).Item("Bandeja")
                End If
                If dts.Tables(0).Rows(0).Item("Cas_Fecha_Registro") Is DBNull.Value Then
                    strlfcreg = ""
                Else
                    strlfcreg = dts.Tables(0).Rows(0).Item("Cas_Fecha_Registro")
                End If
                If dts.Tables(0).Rows(0).Item("Estado") Is DBNull.Value Then
                    strlestadoinc = ""
                Else
                    strlestadoinc = dts.Tables(0).Rows(0).Item("Estado")
                End If
            Else
                cnDatos.Open()
                cms.CommandText = "SELECT idcrm,cas_id, fcreg, obs, tipo_soporte, tipificacion, idusuario, min_ac, nom_cliente, equipo_ac, fallared, bandeja FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@_Caso ORDER BY idcrm DESC"
                'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
                cms.Connection = cnDatos
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                strlcantidad = dts.Tables(0).Rows.Count
                If (strlcantidad > 0) Then
                    If dts.Tables(0).Rows(0).Item("cas_id") Is DBNull.Value Then
                        strlcaso = ""
                    Else
                        strlcaso = dts.Tables(0).Rows(0).Item("cas_id")
                    End If
                    If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                        strlmin = ""
                    Else
                        strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                    End If
                    If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                        strlcliente = ""
                    Else
                        strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                    End If
                    If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                        strlequipo = ""
                    Else
                        strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                    End If
                    If dts.Tables(0).Rows(0).Item("Bandeja") Is DBNull.Value Then
                        strlmesa = ""
                    Else
                        strlmesa = dts.Tables(0).Rows(0).Item("Bandeja")
                    End If
                Else
                    cnVoz.Open()
                    cms.CommandText = "SELECT BU.idcaso,fcreg, obs, tiposoporte, BU.tipificacion, idusuario,min_ac, nom_cliente, equipo_ac, fallared, bandeja FROM VCRMDetalle RIGHT OUTER join Bandeja_uni BU on VCRMDetalle.idcaso=BU.idcaso where BU.idcaso=@_Caso ORDER BY idcrm DESC"
                    'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
                    cms.Connection = cnVoz
                    dta = New SqlClient.SqlDataAdapter(cms)
                    dta.Fill(dts)
                    strlcantidad = dts.Tables(0).Rows.Count
                    If (strlcantidad > 0) Then
                        If dts.Tables(0).Rows(0).Item("idcaso") Is DBNull.Value Then
                            strlcaso = ""
                        Else
                            strlcaso = dts.Tables(0).Rows(0).Item("idcaso")
                        End If
                        If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                            strlmin = ""
                        Else
                            strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                        End If
                        If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                            strlcliente = ""
                        Else
                            strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                        End If
                        If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                            strlequipo = ""
                        Else
                            strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                        End If
                        If dts.Tables(0).Rows(0).Item("Bandeja") Is DBNull.Value Then
                            strlmesa = ""
                        Else
                            strlmesa = dts.Tables(0).Rows(0).Item("Bandeja")
                        End If
                    End If
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
    Public Function ConsultaGestion_Casos_Bolchat() As DataSet
        Dim cnAdmin As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cnAdmin.Open()
            cms.CommandText = "select BCRM.IdBoltCRM,BCRM.Idcaso,BCRM.Fcreg,BCRM.Idusuario,BCRM.Recomen_Prioridad,BCRM.Obs,BT.Nombre as Tipo,BS.Nombre as Segmento,BCRM.Tipificacion from BoltCRMDetalle BCRM inner join Bol_Tipo BT on BCRM.Tipo=BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BCRM.Segmento = BS.Cod_Bol_Segmento where Idcaso=@_Caso"
            cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
            cms.Connection = cnAdmin
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cnAdmin.State = ConnectionState.Open Then
                cnAdmin.Close()
            End If
        End Try
    End Function
    Public Function ConsultaGestion_Casos_Datos_Voz() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim cnVoz As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cnDatos.Open()
            cms.CommandText = "SELECT idcrm,cas_id, fcreg, obs, tipo_soporte, tipificacion, idusuario, min_ac, nom_cliente, equipo_ac, fallared, bandeja FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@_Caso ORDER BY idcrm DESC"
            cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If (strlcantidad > 0) Then
            Else
                cnVoz.Open()
                cms.CommandText = "SELECT fallatec,bandeja_uni.idcaso, cas_fecha_registro, tipoinc, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, bandeja, estado, idcrm, fcreg, idusuario, obs, VCRMDetalle.tipificacion, tiposoporte, destiposoporte  as tipo_soporte, numalt FROM VCRMDetalle INNER JOIN VSoporte ON VCRMDetalle.tiposoporte = VSoporte.idsoporte RIGHT OUTER JOIN Bandeja_uni ON VCRMDetalle.idcaso = Bandeja_uni.idcaso where bandeja_uni.idcaso=@_Caso ORDER BY idcrm DESC"
                'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
                cms.Connection = cnVoz
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                strlcantidad = dts.Tables(0).Rows.Count
                If (strlcantidad > 0) Then
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
    Public Function Consultacasos_Datos_Voz() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim cnVoz As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cnDatos.Open()
            cms.CommandText = "SELECT idcrm,cas_id, fcreg, obs, tipo_soporte, tipificacion, idusuario, min_ac, nom_cliente, equipo_ac, fallared, bandeja FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@_Caso ORDER BY idcrm DESC"
            cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If (strlcantidad > 0) Then
                If dts.Tables(0).Rows(0).Item("cas_id") Is DBNull.Value Then
                    strlcaso = ""
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("cas_id")
                End If
                If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                End If
                If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                    strlcliente = ""
                Else
                    strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                End If
                If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                    strlequipo = ""
                Else
                    strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                End If
                If dts.Tables(0).Rows(0).Item("Bandeja") Is DBNull.Value Then
                    strlmesa = ""
                Else
                    strlmesa = dts.Tables(0).Rows(0).Item("Bandeja")
                End If
            Else
                cnVoz.Open()
                cms.CommandText = "SELECT BU.idcaso,fcreg, obs, tiposoporte, BU.tipificacion, idusuario,min_ac, nom_cliente, equipo_ac, fallared, bandeja FROM VCRMDetalle RIGHT OUTER join Bandeja_uni BU on VCRMDetalle.idcaso=BU.idcaso where BU.idcaso=@_Caso ORDER BY idcrm DESC"
                'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
                cms.Connection = cnVoz
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                strlcantidad = dts.Tables(0).Rows.Count
                If (strlcantidad > 0) Then
                    If dts.Tables(0).Rows(0).Item("idcaso") Is DBNull.Value Then
                        strlcaso = ""
                    Else
                        strlcaso = dts.Tables(0).Rows(0).Item("idcaso")
                    End If
                    If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                        strlmin = ""
                    Else
                        strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                    End If
                    If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                        strlcliente = ""
                    Else
                        strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                    End If
                    If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                        strlequipo = ""
                    Else
                        strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                    End If
                    If dts.Tables(0).Rows(0).Item("Bandeja") Is DBNull.Value Then
                        strlmesa = ""
                    Else
                        strlmesa = dts.Tables(0).Rows(0).Item("Bandeja")
                    End If
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
    Public Function Consultacasos_Bolchat() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cnDatos.Open()
            cms.CommandText = "select BB.Cod_Bandeja_Bolt, BB.Idcaso, BB.Ing_Remite, BB.Idusuario, BB.Cas_Fecha_Registro, BB.Cas_Fecha_Recepcion, BB.Recomen_Prioridad, BT.Nombre as Tipo, BS.Nombre as Segmento, BB.Min_Ac, BB.Nom_Cliente, BB.Equipo_Ac, BB.Bandeja from Bandeja_Bolt BB inner join Bol_Tipo BT on BB.Tipo = BT.Cod_Bol_Tipo inner join Bol_Segmento BS on BB.Segmento = BS.Cod_Bol_Segmento where Idcaso=@_Caso Order by BB.Cod_Bandeja_Bolt Desc"
            cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cnDatos.State = ConnectionState.Open Then
                cnDatos.Close()
            End If
        End Try
    End Function
    Public Function consultaproceso() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
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
    Public Function consultacierre() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT ESCENARIO,HOMOLOGACION_SIC FROM Tipificacion_CRM_2 where ESCENARIO=@strltiposoporte "
            cms.Parameters.Add("@strltiposoporte", SqlDbType.NVarChar).Value = Me.strltiposoporte
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("HOMOLOGACION_SIC") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("HOMOLOGACION_SIC")
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
    Public Function consultacierrevoz() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT ESCENARIO,HOMOLOGACION_SIC FROM Tipificacion_CRM_2 where id=@strltiposoporte "
            cms.Parameters.Add("@strltiposoporte", SqlDbType.Int).Value = Me.strltiposoporte
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("HOMOLOGACION_SIC") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("HOMOLOGACION_SIC")
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
    Public Function consultapteasignargestion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Dim concateno, esta, fechaini, fechaffin As String
        Select Case _Bandeja
            Case "Datos"
                concateno = "and Bandeja = 'datos'"
            Case "PQR"
                concateno = "and Bandeja like '%Smartphone%'"
            Case "Sin Formato"
                concateno = "and Bandeja like '%CONTROL%'"
            Case Nothing
                concateno = "and (bandeja = 'Datos' or bandeja like '%CONTROL%' or Bandeja like '%Smartphone%')"
        End Select

        Select Case strlestadoinc
            Case "Abierto"
                esta = "and estado = 'Abierto'"
            Case "Gestionado"
                esta = "and estado = 'Gestionado'"
            Case "No Contactado"
                esta = "and estado = 'No Contactado'"
            Case Nothing
                esta = "and (estado = 'ABIERTO' OR estado = 'Gestionado' OR estado = 'No Contactado')"
        End Select

        Select Case strlfcini
            Case Nothing
                fechaini = ""
            Case Is <> Nothing
                fechaini = " and cast(cas_fecha_registro as date ) >=  '" & strlfcini & "'"
        End Select
        Select Case strlfcfin
            Case Nothing
                fechaffin = ""
            Case Is <> Nothing
                fechaffin = " and cast(cas_fecha_registro as date ) <= '" & strlfcfin & "'"
        End Select
        Try
            cn.Open()
            cms.CommandText = "SELECT top" & " " & strlcantidad & " " & " cas_id as Caso,cas_fecha_registro as [Fecha registro],min_ac as Min,fcsap as [Fecha sap],estado as Estado, Bandeja as Bandeja FROM Bandeja where st_bb_call is null and lapso= 'Manual' " & concateno & " " & esta & " " & fechaini & " " & fechaffin & " order by cas_fecha_registro"
            If _Validacion = "inicio" Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & " cas_id as Caso,cas_fecha_registro as [Fecha registro],min_ac as Min,fcsap as [Fecha sap],estado as Estado, Bandeja as Bandeja FROM Bandeja where st_bb_call is null and lapso= 'Manual' and (estado = 'ABIERTO' OR estado = 'Gestionado' OR estado = 'No Contactado') and (bandeja = 'Datos' or bandeja like '%CONTROL%' or Bandeja like '%Smartphone%') order by cas_fecha_registro"
            End If
            If _Validacion = "Individual" Then
                cms.CommandText = "SELECT  cas_id as Caso,cas_fecha_registro as [Fecha registro],min_ac as Min,estado as Estado,fcsap as [Fecha sap], Bandeja as Bandeja FROM Bandeja where st_bb_call is null and lapso is not null and  (estado = 'ABIERTO' OR estado = 'Gestionado' OR estado = 'No Contactado') and (bandeja = 'Datos' or bandeja like '%CONTROL%' or Bandeja like '%Smartphone%') and cas_id=@strlcaso"
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

    Public Function consultaenprocgestion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT B.correo_electronico as Ingeniero, COUNT(B.cas_id) AS casos FROM Bandeja B inner join usuarios U on B.correo_electronico = U.idusuario WHERE (st_bb_call is not null and lapso= 'Manual' and ((estado = 'ABIERTO' OR estado = 'Gestionado' OR estado = 'No Contactado'))) and ((red=99 or red=88) and cargo like 'N%' and cargo <>'retirado') GROUP BY correo_electronico order by casos desc"
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
    Public Sub asignaescalaxcasogestion()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja SET correo_electronico=@strlidusuario, st_bb_call=@strlfcreg WHERE cas_id= @strlcaso"
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
    Public Sub liberaasiggestion()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            '---DATOS---'
            If _Bandeja = "DATOS" Then
                cms.CommandText = "UPDATE bandeja SET correo_electronico=null, st_bb_call=null WHERE Bandeja NOT LIKE '%BSCS%' and cas_id= @strlcaso"
                '---DILO---'
            ElseIf _Bandeja = "DILO" Then
                cms.CommandText = "Update Bandeja_alt set Fc_Asignado = NULL, Usuario_Asignado = NULL where idcaso = @strlcaso"
                '---DESACTIVACION---'
            ElseIf _Bandeja = "DESACTIVACION" Then
                cms.CommandText = "Update Bandeja_Falla_Desactivacion_D_V set Fc_Asignado=NULL, Usuario_Asignado = NULL where Id_Bandeja_Falla_Desactivacion_D_V = @strlcaso"
                '---INBOUND---'
            ElseIf _Bandeja = "INBOUND" Then
                cms.CommandText = "UPDATE Asignacion_Casos SET Usuario_Asignado=null WHERE Campaña = 'Inbound' and ID_Caso = @strlcaso"
                '---BSCS---'
            ElseIf _Bandeja = "BSCS" Then
                cms.CommandText = "UPDATE bandeja SET correo_electronico=null, st_bb_call=null WHERE Bandeja LIKE '%BSCS%' and cas_id= @strlcaso   UPDATE Asignacion_Casos SET Usuario_Asignado=null WHERE Campaña = 'BSCS' and ID_Caso = @strlcaso"
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

    Public Function consultaasignadogestion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            If strlcantidad <> "" Then
                strlcantidad = "top " & strlcantidad
            End If
            '---Datos---'
            If _Bandeja = "DATOS" Then
                '---estado---'
                Select Case strlestadoinc ''ESTADO
                    Case "Auto-Asignacion"
                        strlestadoinc = "and lapso is NULL and  (estado not like '%Cerrado%' and estado not like '%escala%')"
                    Case "Todos los anteriores"
                        strlestadoinc = "and lapso is not null and estado not like '%Cerrado%' and estado not like '%Escala%' and estado not like '%iloca%' "
                    Case Is <> Nothing
                        strlestadoinc = "and estado = '" & strlestadoinc & "' and lapso is not null"
                End Select
                If strlcaso <> "" Then ''CASO
                    strlcaso = "and cas_id =" & strlcaso & ""
                End If
                If strlidusuario <> "" Then ''USUARIO
                    strlidusuario = "correo_electronico='" & strlidusuario & "' and"
                End If
                If strlCampanaLogin <> "" Then ''CAMPAÑA
                    If strlCampanaLogin = "Datos" Then
                        strlCampanaLogin = " AND Bandeja = 'Datos'  "
                    ElseIf strlCampanaLogin = "PQR" Then
                        strlCampanaLogin = " AND Bandeja like '%Smartphone%'  "
                    ElseIf strlCampanaLogin = "Sin Formato" Then
                        strlCampanaLogin = " AND Bandeja like '%CONTROL%'  "
                    End If
                Else
                    strlCampanaLogin = ""
                End If
                If strlmarca <> "" Then
                    If strlmarca = "Manual" Then
                        strlmarca = " AND Lapso = 'Manual' "
                    ElseIf strlmarca = "Reincidente" Then
                        strlmarca = " AND Lapso = 'Reincide' "
                    ElseIf strlmarca = "Seguimiento" Then
                        strlmarca = " AND Lapso = 'Segui' "
                    End If
                Else
                    strlmarca = " "
                End If
                cms.CommandText = "select " & strlcantidad & "cas_id as Caso, cas_fecha_registro as [Fecha Registro],estado,correo_electronico as [Ingeniero Asignado],lapso as Marcacion,Bandeja as Bandeja from Bandeja where Bandeja NOT LIKE '%BSCS%' And " & strlidusuario & " (estado not like '%Cerrado%' and estado not like '%escala%')" & strlestadoinc & strlmarca & strlCampanaLogin & strlcaso & " order by cas_fecha_registro"
                If _Validacion = "Masiva" Then
                    cms.CommandText = "select cas_id as Caso, cas_fecha_registro as [Fecha Registro],estado,correo_electronico as [Ingeniero Asignado],lapso as Marcacion,Bandeja as Bandeja from Bandeja where Bandeja NOT LIKE '%BSCS%' And correo_electronico is not null and st_bb_call is not null " & strlestadoinc & strlmarca & strlCampanaLogin & " order by cas_fecha_registro"
                End If
                '---DILO---'
            ElseIf _Bandeja = "DILO" Then
                '---estado---'
                Select Case strlestadoinc
                    Case "Auto-Asignacion"
                        strlestadoinc = "and Usuario_asigna is NULL and  (estado not like '%Cerrado%' and estado not like '%escala%')"
                    Case "Todos los anteriores"
                        strlestadoinc = "and Usuario_asigna is not null and estado not like '%Cerrado%' and estado not like '%Escala%' and estado not like '%iloca%' "
                    Case Is <> Nothing
                        strlestadoinc = "and estado = '" & strlestadoinc & "' and Usuario_asigna is not NULL"
                End Select
                If strlcaso <> "" Then
                    strlcaso = "and idcaso =" & strlcaso & ""
                End If
                If strlidusuario <> "" Then
                    strlidusuario = "Usuario_Asignado='" & strlidusuario & "' and"
                End If
                cms.CommandText = "select " & strlcantidad & "idcaso as Caso, fcreporte as [Fecha Registro],estado,Usuario_Asignado as [Ingeniero Asignado],usuario_asigna as Marcacion,'Dilo' as Bandeja from Bandeja_alt where " & strlidusuario & " (estado not like '%Cerrado%' and estado not like '%escala%') " & strlestadoinc & strlcaso & " order by fcreporte"
                'cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
                If _Validacion = "Masiva" Then
                    cms.CommandText = "select idcaso as Caso, fcreporte as [Fecha Registro],estado,Usuario_Asignado as [Ingeniero Asignado],usuario_asigna as Marcacion,'Dilo' as Bandeja from Bandeja_alt where Usuario_Asignado is not null  " & strlestadoinc & " order by [Fecha Registro]"
                End If
                '---DESACTIVACION---'
            ElseIf _Bandeja = "DESACTIVACION" Then
                '---estado---'
                Select Case strlestadoinc
                    Case "Auto-Asignacion"
                        strlestadoinc = "and Usuario_asigna is NULL and  (estado not like '%Cerrado%' and estado not like '%escala%')"
                    Case "Todos los anteriores"
                        strlestadoinc = "and Usuario_asigna is not null and estado not like '%Cerrado%' and estado not like '%Escala%' and estado not like '%iloca%' "
                    Case Is <> Nothing
                        strlestadoinc = "and estado = '" & strlestadoinc & "' and Usuario_asigna is not NULL"
                End Select
                If strlcaso <> "" Then
                    strlcaso = "and Id_Bandeja_Falla_Desactivacion_D_V =" & strlcaso & ""
                End If
                If strlidusuario <> "" Then
                    strlidusuario = "Usuario_Asignado='" & strlidusuario & "' and"
                End If
                cms.CommandText = "select " & strlcantidad & "Id_Bandeja_Falla_Desactivacion_D_V as Caso, Fc_Reg as [Fecha Registro],estado,Usuario_Asignado as [Ingeniero Asignado],usuario_asigna as Marcacion,'DESAC' as Bandeja from Bandeja_Falla_Desactivacion_D_V where " & strlidusuario & " (estado not like '%Cerrado%' and estado not like '%escala%') " & strlestadoinc & strlcaso & " order by Fc_Reg"
                If _Validacion = "Masiva" Then
                    cms.CommandText = "select Id_Bandeja_Falla_Desactivacion_D_V as Caso, Fc_Reg as [Fecha Registro],estado,Usuario_Asignado as [Ingeniero Asignado],usuario_asigna as Marcacion,'DESAC' as Bandeja from Bandeja_Falla_Desactivacion_D_V where Usuario_Asignado is not null " & strlestadoinc & " order by Fc_Reg"
                End If
                '---BSCS---'
            ElseIf _Bandeja = "BSCS" Then
                '---estado---'
                Select Case strlestadoinc
                    Case "Auto-Asignacion"
                        strlestadoinc = "and lapso is NULL and  (estado not like '%Cerrado%' and estado not like '%escala%')"
                    Case "Todos los anteriores"
                        strlestadoinc = "and lapso is not null and estado not like '%Cerrado%' and estado not like '%Escala%' and estado not like '%iloca%' "
                    Case Is <> Nothing
                        strlestadoinc = "and estado = '" & strlestadoinc & "' and lapso is not null"
                End Select
                If strlcaso <> "" Then ''CASO
                    strlcaso = "and cas_id =" & strlcaso & ""
                End If
                If strlidusuario <> "" Then ''USUARIO
                    strlidusuario = "A.Usuario_Asignado = '" & strlidusuario & "' and"
                End If
                If strlmarca <> "" Then
                    If strlmarca = "Manual" Then
                        strlmarca = " AND Lapso = 'Manual' "
                    ElseIf strlmarca = "Reincidente" Then
                        strlmarca = " AND Lapso = 'Reincide' "
                    ElseIf strlmarca = "Seguimiento" Then
                        strlmarca = " AND Lapso = 'Segui' "
                    End If
                Else
                    strlmarca = " "
                End If
                cms.CommandText = "select " & strlcantidad & " cas_id as Caso, cas_fecha_registro as [Fecha Registro],estado,A.Usuario_Asignado as [Ingeniero Asignado],lapso as Marcacion, 'BSCS' As Bandeja from Bandeja INNER JOIN Asignacion_Casos A ON A.ID_Caso=cas_id And A.Campaña = 'BSCS' where Bandeja LIKE '%BSCS%' and  " & strlidusuario & " (estado not like '%Cerrado%' and estado not like '%escala%')" & strlestadoinc & strlmarca & strlcaso & " order by cas_fecha_registro"
                If _Validacion = "Masiva" Then
                    cms.CommandText = "select cas_id as Caso, cas_fecha_registro as [Fecha Registro],estado,A.Usuario_Asignado as [Ingeniero Asignado],lapso as Marcacion,'BSCS' as Bandeja from Bandeja INNER JOIN Asignacion_Casos A ON A.ID_Caso=cas_id And A.Campaña = 'BSCS' where Bandeja like '%BSCS%' And A.Usuario_Asignado is not null " & strlestadoinc & strlmarca & " order by cas_fecha_registro"
                End If
                '---INBOUND---'
            ElseIf _Bandeja = "INBOUND" Then
                '---estado---'
                Select Case strlestadoinc
                    Case "Todos los anteriores"
                        strlestadoinc = "and estado not like '%Cerrado%' and estado not like '%Escala%' and estado not like '%iloca%' "
                    Case Is <> Nothing
                        strlestadoinc = "and estado = '" & strlestadoinc & "' "
                End Select
                If strlcaso <> "" Then
                    strlcaso = "and Id_caso =" & strlcaso & ""
                End If
                If strlidusuario <> "" Then
                    strlidusuario = "A.Usuario_Asignado = '" & strlidusuario & "' and"
                End If
                cms.CommandText = "select " & strlcantidad & " B.Id_caso as Caso, B.Fecha_registro as [Fecha Registro],estado,A.Usuario_Asignado as [Ingeniero Asignado],'N/A' as Marcacion,'Inbound' as Bandeja from Bandeja_inbound B INNER JOIN Asignacion_Casos A ON A.ID_Caso = B.Id_caso And A.Campaña = 'Inbound' where " & strlidusuario & " (estado not like '%Cerrado%' and estado not like '%escala%') " & strlestadoinc & strlcaso & " order by B.Fecha_registro"
                If _Validacion = "Masiva" Then
                    cms.CommandText = "select B.Id_caso as Caso, B.Fecha_registro as [Fecha Registro],estado,A.Usuario_Asignado as [Ingeniero Asignado],'N/A' as Marcacion,'Inbound' as Bandeja from Bandeja_inbound B INNER JOIN Asignacion_Casos A ON A.ID_Caso = B.Id_caso And A.Campaña = 'Inbound' where A.Usuario_Asignado is not null " & strlestadoinc & " order by B.Fecha_registro"
                End If
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



    Public Function validacasoasignado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT min_ac,cas_id,correo_electronico,st_bb_call,lapso FROM Bandeja where correo_electronico=@strlidusuario and cas_id=@strlcaso"
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
    Public Function consultaprogramado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idcaso, MAX(dbo.CRMDetalle.fcprogram) AS Fcprog, estado, correo_electronico FROM CRMDetalle INNER JOIN Bandeja ON CRMDetalle.idcaso = Bandeja.cas_id GROUP BY idcaso, estado, correo_electronico,Bandeja HAVING estado = N'Programado' and correo_electronico=@strlidusuario and bandeja <> 'BSCS' order by fcprog"
            If _Validacion = "BSCS" Then
                cms.CommandText = "SELECT idcaso, MAX(dbo.CRMDetalle.fcprogram) AS Fcprog, estado, correo_electronico FROM CRMDetalle INNER JOIN Bandeja ON CRMDetalle.idcaso = Bandeja.cas_id GROUP BY idcaso, estado, correo_electronico, Bandeja HAVING estado = N'Programado' and correo_electronico=@strlidusuario and bandeja='BSCS' order by fcprog"
            End If
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

    Public Function consultaasignado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select distinct B.cas_id as caso,B.Min_ac,B.cas_fecha_registro as [Fecha Registro],B.st_bb_call as [Fecha Asignado],B.estado as Estado,max(C.fcprogram) as [Fecha programada] from Bandeja B left join CRMDetalle C on B.cas_id = (idcaso ) and Estado=Tipificacion where correo_electronico=@strlidusuario AND st_bb_call is not null and estado not like '%cerrado%' and estado not like '%solicitud%' and estado not like '%escala%'  and estado not like '%ilo%' and bandeja not like '%BSCS%' group by B.cas_id,B.Min_ac,B.st_bb_call,B.Estado,B.cas_fecha_registro"
            If _Validacion = "BSCS" Then
                cms.CommandText = "SELECT DISTINCT B.cas_id as caso,B.Min_ac,B.cas_fecha_registro as [Fecha Registro],A.FC_Asignacion as [Fecha Asignado],B.estado as Estado,max(C.fcprogram) as [Fecha programada] FROM Bandeja B INNER JOIN Asignacion_Casos A ON A.ID_Caso = B.cas_id LEFT JOIN CRMDetalle C on B.cas_id = C.idcaso and B.Estado=C.Tipificacion  WHERE A.Usuario_Asignado=@strlidusuario and estado not like '%cerrado%' and estado not like '%solicitud%' and estado not like '%escala%'  and estado not like '%ilo%' and bandeja like '%BSCS%' GROUP BY B.cas_id,B.Min_ac,A.FC_Asignacion,B.Estado,B.cas_fecha_registro"
            End If
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

    Public Function consultapteasignartotalgestion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select count(cas_id) as Cantidad from Bandeja where st_bb_call is null and lapso= 'Manual' and (estado = 'ABIERTO' OR estado = 'Gestionado' OR estado = 'No Contactado') and (bandeja = 'Datos' or bandeja like '%CONTROL%' or Bandeja like '%Smartphone%')"
            If _Validacion = "1" Then
                cms.CommandText = "select count(B.cas_id) as cantidad from Bandeja B where B.st_bb_call is null and lapso= 'Manual' and Bandeja='datos' and (estado = 'ABIERTO' OR estado = 'Gestionado' OR estado = 'No Contactado')"
            End If
            If _Validacion = "3" Then
                cms.CommandText = "select  count(B.cas_id) as cantidad from Bandeja B where B.st_bb_call is null and lapso= 'Manual' and (Bandeja like '%Smartphone%')and (estado = 'ABIERTO' OR estado = 'Gestionado' OR estado = 'No Contactado')"
            End If
            If _Validacion = "4" Then
                cms.CommandText = "select  count(B.cas_id) as Cantidad from Bandeja B where B.st_bb_call is null and lapso= 'Manual' and (Bandeja like '%CONTROL%')and (estado = 'ABIERTO' OR estado = 'Gestionado' OR estado = 'No Contactado')"
            End If
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

    Public Function consultadigitariloc() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT cas_id, cas_fecha_registro, min_ac, nom_cliente, Bandeja.fcasignado, Bandeja.idusuarioasigna, fcsap, fcregistro, Call.estado FROM Bandeja LEFT OUTER JOIN Call ON Bandeja.cas_id = Call.contrato WHERE  Bandeja.fcasignado IS NOT NULL AND digitado IS NULL AND iddigitador = @strlidusuario AND cas_id = @strlcaso AND (Call.estado = 'failure' OR Call.estado = 'abandoned' OR Call.estado = 'shortcall') ORDER BY fcregistro DESC"
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
    Public Sub registroinb()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO bandeja(cas_id,cas_fecha_registro,usuario_registra,cas_observaciones,min_ac,nom_cliente,no_documento,plan_acual_ac,inb,estado,Bandeja) values(@strlcaso,@strlfcreg,@strlidusuario,@strltipofalla,@strlmin,@strlnompaquete,@strlidentificacion,@strlplan,'1','Abierto','Inbound')"
            If strlingn3 <> Nothing Then
                cms.CommandText = "INSERT INTO bandeja(cas_id,cas_fecha_registro,usuario_registra,cas_observaciones,min_ac,nom_cliente,no_documento,plan_acual_ac,inb,estado,ingremite,Bandeja) values(@strlcaso,@strlfcreg,@strlidusuario,@strltipofalla,@strlmin,@strlnompaquete,@strlidentificacion,@strlplan,'1','Abierto',@strlingn3,'Inbound')"
                cms.Parameters.Add("@strlingn3", SqlDbType.VarChar, 200).Value = strlingn3
            End If
            If _Validacion = "Fidelizacion" Then
                cms.CommandText = "INSERT INTO Bandeja_Falla_Desactivacion_D_V(id_caso,Fc_Reg,Cas_Observaciones,Min,Nombre_Cliente,Cedula,Plan_Actual_Ac,Ingremite,bandeja) values(@strlcaso,@strlfcreg,@strltipofalla,@strlmin,@strlnompaquete,@strlidentificacion,@strlplan,@strlingn3,'Inbound')"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 15).Value = strlmin
            cms.Parameters.Add("@strlnompaquete", SqlDbType.VarChar, 255).Value = strlnompaquete
            cms.Parameters.Add("@strlidentificacion", SqlDbType.VarChar, 50).Value = strlidentificacion
            cms.Parameters.Add("@strlplan", SqlDbType.VarChar, 100).Value = strlplan
            cms.Parameters.Add("@strltipofalla", SqlDbType.VarChar, 100).Value = strltipofalla
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
    Public Function asignaconsec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT cas_id,inb FROM Bandeja where inb is not null and cas_id<60000 order by cas_id desc"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("cas_id") Is System.DBNull.Value Then
                    strlabierto = " "
                Else
                    strlabierto = dtsrecepcion.Tables(0).Rows(0).Item("cas_id") + 1
                End If
            Else
                strlabierto = "50001"
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
    Public Function ConsultaNxMonitor()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from CRMDetalle where idcaso=@strlcaso and preg2='SI' order by fcreg desc"
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
    Public Function ConsultaNxMonitorDILO()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from CRMdilo where idcasodilo=@strlcaso and preg2='SI' order by fcregistro desc"
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
    Public Function Consulta_Campo_NxMonitor() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from NxMonitor order by Nombre_NxMonitor"
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
    Public Function consultaenprocdigitaseg() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
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
    Public Function consultapteasignartotaldigitacseg() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
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
    Public Sub asignaescalaxcasodigdtseguim()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
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
    Public Function consultapteasignardigitadtseguim() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "idcall,contrato,fcregistro,Call.estado,Call.fcdigitado, Bandeja.estado as estadobandeja FROM Call INNER JOIN Bandeja ON Call.contrato = Bandeja.cas_id where (Call.estado='Failure' or Call.estado='Shortcall' or Call.estado='Abandoned') and Call.fcasignado is null AND (Bandeja.estado <> N'cerrado') AND (Bandeja.estado <> N'escalado') order by fcregistro"
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
    Public Sub liberaasigdigitacseguim()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
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
    Public Function consultaasignadodigitacdatosseguim() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
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
    Public Sub actualizadigitdtseguim()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
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
    Public Function consultadigitarseguim() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
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
    Public Sub registrofmasivadatos()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO FallaMasiva (fcreacion,idusuariocrea,obs,estadof,tipo_soporte,tipificacion,servicio,perecep,tecnologia,variable,nunicipio,barrio,equipook) values(@strlfcreg,@strlidusuario,@strlobs,'Activa',@strltiposoporte,@strltipificacion,@strldiagservicio,@strldiagperep,@strldiagtecnolog,@strldiagvariable,@strlmun,@strlbarrio,@strlequipo)"

            cms.Parameters.Add("@strldiagservicio", SqlDbType.Int).Value = strldiagservicio
            cms.Parameters.Add("@strldiagperep", SqlDbType.Int).Value = strldiagperep
            cms.Parameters.Add("@strldiagtecnolog", SqlDbType.Int).Value = strldiagtecnolog
            cms.Parameters.Add("@strlequipo", SqlDbType.NVarChar, 100).Value = strlequipo
            cms.Parameters.Add("@strldiagvariable", SqlDbType.Int).Value = strldiagvariable
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar, 10).Value = strlmun
            cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar, 255).Value = strlbarrio
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            cms.Parameters.Add("@strltiposoporte", SqlDbType.VarChar, 255).Value = strltiposoporte
            cms.Parameters.Add("@strlobs", SqlDbType.NVarChar).Value = strlobs
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = strlidusuario
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
    Public Function consultafallamasiva() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM Cons_fallamasiva where estadof='Activa'"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("obs") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obs")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("grupo") Is System.DBNull.Value Then
                    strlgrupo = " "
                Else
                    strlgrupo = dtsrecepcion.Tables(0).Rows(0).Item("grupo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipo_soporte") Is System.DBNull.Value Then
                    strltiposoporte = " "
                Else
                    strltiposoporte = dtsrecepcion.Tables(0).Rows(0).Item("tipo_soporte")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipificacion") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("tipificacion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("idgrupo") Is System.DBNull.Value Then
                    strlidservicio = " "
                Else
                    strlidservicio = dtsrecepcion.Tables(0).Rows(0).Item("idgrupo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("servicio") Is System.DBNull.Value Then
                    strldiagservicio = " "
                Else
                    strldiagservicio = dtsrecepcion.Tables(0).Rows(0).Item("servicio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("perecep") Is System.DBNull.Value Then
                    strldiagperep = " "
                Else
                    strldiagperep = dtsrecepcion.Tables(0).Rows(0).Item("perecep")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tecnologia") Is System.DBNull.Value Then
                    strldiagtecnolog = " "
                Else
                    strldiagtecnolog = dtsrecepcion.Tables(0).Rows(0).Item("tecnologia")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("variable") Is System.DBNull.Value Then
                    strldiagvariable = " "
                Else
                    strldiagvariable = dtsrecepcion.Tables(0).Rows(0).Item("variable")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("coddpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("coddpto")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nunicipio") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("nunicipio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dtsrecepcion.Tables(0).Rows(0).Item("barrio")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("marca") Is System.DBNull.Value Then
                    strlmarca = " "
                Else
                    strlmarca = dtsrecepcion.Tables(0).Rows(0).Item("marca")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("equipook") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dtsrecepcion.Tables(0).Rows(0).Item("equipook")
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
    Public Sub inactivafallamasiva()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Fallamasiva SET estadof='Inactiva', fcinactiv=@strlfcreg WHERE estadof='Activa'"
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
    Public Function Consulta_Casos_Inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where B.cas_fecha_registro>='01/01/2014' and ((B.Bandeja is null) or (B.Bandeja='Inbound')) and B.cas_observaciones is not null group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(CRM.fcprogram) DESC"

            If strlfcini <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and cas_fecha_registro>=@strlfcini group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
                cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = Me.strlfcini
            End If

            If strlfcfin <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) cas_fecha_registro>=@strlfcfin group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
                cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = Me.strlfcfin
            End If

            If strltipificacion <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where B.cas_fecha_registro>='01/01/2014' and ((B.Bandeja is null) or (B.Bandeja='Inbound')) and B.estado=@strltipificacion and B.cas_observaciones is not null group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(CRM.fcprogram) DESC"
                cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 50).Value = Me.strltipificacion
            End If

            If strlmesa <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.cas_observaciones like '%" + strlmesa + "%' group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
                cms.Parameters.Add("@strlmesa", SqlDbType.VarChar, 50).Value = Me.strlmesa
            End If

            If strlfcini <> "" And strlfcfin <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and cas_fecha_registro>=@strlfcini and cas_fecha_registro<=@strlfcfin group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
            End If

            ''''''''''''' N°1 '''''''''''''

            If strltipificacion <> "" And strlfcini <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.estado=@strltipificacion AND cas_fecha_registro>=@strlfcini group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
            End If
            If strltipificacion <> "" And strlfcfin <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.estado=@strltipificacion AND cas_fecha_registro<= @strlfcfin group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
            End If
            If strltipificacion <> "" And strlfcini <> "" And strlfcfin <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.estado=@strltipificacion AND cas_fecha_registro>=@strlfcini and cas_fecha_registro <= @strlfcfin group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
            End If

            ''''''''''''' N°2 '''''''''''''

            If strlmesa <> "" And strlfcini <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.cas_observaciones like '%" + strlmesa + "%' AND cas_fecha_registro>=@strlfcini group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
            End If
            If strlmesa <> "" And strlfcfin <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.cas_observaciones like '%" + strlmesa + "%' AND cas_fecha_registro<=@strlfcfin group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
            End If
            If strlmesa <> "" And strlfcini <> "" And strlfcfin <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.cas_observaciones like '%" + strlmesa + "%' AND cas_fecha_registro>=@strlfcini and cas_fecha_registro<=@strlfcfin group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
            End If

            ''''''''''''' N°3 '''''''''''''

            If strltipificacion <> "" And strlmesa <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.estado=@strltipificacion and B.cas_observaciones like '%" + strlmesa + "%' group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
            End If
            If strltipificacion <> "" And strlmesa <> "" And strlfcini <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.estado=@strltipificacion and B.cas_observaciones like '%" + strlmesa + "%' AND cas_fecha_registro>=@strlfcini group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
            End If
            If strltipificacion <> "" And strlmesa <> "" And strlfcini <> "" And strlfcfin <> "" Then
                cms.CommandText = "select B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, MAX(CRM.fcreg) as fcreg, CRM.IdUsuario, MAX(CRM.obs) as obs, MAX(CRM.fcprogram) as fcprogram, MAX(CRM.tipificacion) as tipificacion, B.estado from Bandeja B left join CRMDetalle CRM on B.cas_id = CRM.idcaso where ((B.Bandeja is null) or (B.Bandeja='inbound')) and B.estado=@strltipificacion and B.cas_observaciones like '%" + strlmesa + "%' AND cas_fecha_registro>=@strlfcini and cas_fecha_registro <= @strlfcfin group by B.cas_id, B.Bandeja, B.cas_fecha_registro, B.cas_observaciones, B.min_ac, B.telefono_contac, B.nom_cliente, B.plan_acual_ac, B.equipo_ac, CRM.IdUsuario, B.estado ORDER BY MAX(fcprogram),cas_id DESC"
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

    Public Function AsignaConsecDilo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idcaso FROM Bandeja_alt order by idcaso desc"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("idcaso") Is System.DBNull.Value Then
                    strlabierto = " "
                Else
                    strlabierto = dtsrecepcion.Tables(0).Rows(0).Item("idcaso") + 1
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

    Public Sub RegistroDiloNuevo()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO bandeja_alt(caso,fcreporte,usuario_registra,min,cliente,estado,canal) values(@strlcaso,@strlfcreg,@strlidusuario,@strlmin,@strlcliente,'Abierto',@strlmesa)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 15).Value = strlmin
            cms.Parameters.Add("@strlcliente", SqlDbType.VarChar, 50).Value = strlcliente
            cms.Parameters.Add("@strlmesa", SqlDbType.VarChar, 50).Value = strlmesa
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
    Public Function Validacion_Registro_Inboun() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Bandeja where cas_id=@strlcaso"
            If _Validacion = "Fidelizacion" Then
                cms.CommandText = "select * from Bandeja_Falla_Desactivacion_D_V where id_caso=@strlcaso"
            End If
            If _Validacion = "Fidelizacion2" Then
                cms.CommandText = "select * from Bandeja_Falla_Desactivacion_D_V where id_Bandeja_Falla_Desactivacion_D_V=@strlcaso"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Int).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If _Validacion = "Fidelizacion2" Or _Validacion = "Fidelizacion" Then
                If dts.Tables(0).Rows.Count > 0 Then
                    If dts.Tables(0).Rows(0).Item("id_Bandeja_Falla_Desactivacion_D_V") Is DBNull.Value Then
                        strlmin = " "
                    Else
                        strlmin = dts.Tables(0).Rows(0).Item("id_Bandeja_Falla_Desactivacion_D_V")
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
    Public Sub Actualizacion_Identifica_Caso_Inbound()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Update bandeja set cas_observaciones=@strltipofalla,inb=1,Bandeja='Inbound' where cas_id=@strlcaso"
            If strlingn3 <> Nothing Then
                cms.CommandText = "Update bandeja set ingremite=@strlingn3,cas_observaciones=@strltipofalla,inb=1,Bandeja='Inbound' where cas_id=@strlcaso"
                cms.Parameters.Add("@strlingn3", SqlDbType.VarChar, 200).Value = strlingn3
            End If
            If _Validacion = "Fidelizacion" Then
                cms.CommandText = "Update bandeja_falla_desactivacion_d_v set Bandeja='Inbound',ingremite=@strlingn3,cas_observaciones=@strltipofalla where id_bandeja_falla_Desactivacion_d_v=@strlcaso"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Int).Value = strlcaso
            cms.Parameters.Add("@strltipofalla", SqlDbType.VarChar, 100).Value = strltipofalla
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
    Public Sub Registroservice()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO ServiceDetalle(idcaso,estado,obsescal,fcregserv,tipofalla,apn,qos,fcactivacion,idusuarioescala,archivo,Causal_Escalam,Fecha_Ciclo) values(@strlcaso,'Reportado',@strlobs,@strlfcreg,@strldiagvariable,@strlapn,@strlqos,@strlfcini,@strlidusuario,@strlarchivo,@_Causal_escalam,@_Fecha_ciclo)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strldiagvariable", SqlDbType.Int).Value = strldiagvariable
            cms.Parameters.Add("@strlapn", SqlDbType.VarChar, 50).Value = strlapn
            cms.Parameters.Add("@strlqos", SqlDbType.VarChar, 50).Value = strlqos
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlarchivo", SqlDbType.VarChar, 255).Value = strlarchivo
            If strlfcini = Nothing Then
                cms.Parameters.AddWithValue("@strlfcini", DBNull.Value)
            Else
                cms.Parameters.Add("@strlfcini", SqlDbType.Date).Value = strlfcini
            End If
            If _Causal_escalam = Nothing Then
                cms.Parameters.AddWithValue("@_Causal_escalam", DBNull.Value)
            Else
                cms.Parameters.Add("@_Causal_escalam", SqlDbType.VarChar).Value = _Causal_escalam
            End If
            If _Fecha_ciclo = Nothing Then
                cms.Parameters.AddWithValue("@_Fecha_ciclo", DBNull.Value)
            Else
                cms.Parameters.Add("@_Fecha_ciclo", SqlDbType.Date).Value = _Fecha_ciclo
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

    Public Function consultaenprocescalaservdatos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idusuarioserv, COUNT(idcaso) AS casos FROM servicedetalle INNER JOIN usuarios u ON idusuarioserv = u.idusuario WHERE tickler IS NULL AND fcasignado is not null AND idusuarioserv IS NOT NULL AND u.cargo <> 'Retirado' GROUP BY idusuarioserv"
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
    Public Function consultapteasignartotalservdatos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
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
    Public Function asignaescalaxcasoservdatos()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now.Date
            cms.CommandText = "UPDATE ServiceDetalle SET estado='Asignado', fcasignado=@strlfcreg, idusuarioasigna=@strlidusuario,idusuarioserv=@strlidusuarioasignado WHERE idcaso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.BigInt).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlidusuarioasignado", SqlDbType.VarChar, 50).Value = strlidusuarioasignado
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Connection = cn
            Return cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

 
    Public Function consultaescaladosv2servdatos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT equipo_ac,cas_fecha_registro,idcaso, obsescal, ServiceDetalle.tipofalla, detalle, apn,qos, fcactivacion, idusuarioescala, min_ac, nom_cliente, departamento_falla,ciudad, archivo, Bandeja FROM ServiceDetalle INNER JOIN (select cas_id,equipo_ac,cas_fecha_registro,min_ac, nom_cliente, departamento_falla,ciudad,'Datos' as Bandeja from bandeja union select idcaso,equipo,fcreporte,min,cliente, depto,ciudad,'Dilo' as Bandeja from bandeja_alt union select Id_Caso,'' as equipo_ac,Fc_Reg,Min,Nombre_Cliente,'' as departamento_falla,'' as ciudad,'Fidelizacion' as Bandeja from Bandeja_Falla_Desactivacion_D_V UNION select Id_Caso,'' as equipo_ac,Fecha_registro,Min,Nombre_Cliente,Departamento,Municipio,'Inbound' as Bandeja from Bandeja_inbound) as bandejas ON ServiceDetalle.idcaso = bandejas.cas_id  Left JOIN Diagnostico ON ServiceDetalle.tipofalla = Diagnostico.idreg where idusuarioserv =@strlidusuario and (fcprocesado is null OR ServiceDetalle.estado='corregido') order by idcaso"
            cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = strlidusuario
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT equipo_ac,cas_fecha_registro,idcaso, obsescal, ServiceDetalle.tipofalla, detalle, apn,qos, fcactivacion, idusuarioescala, min_ac, nom_cliente, departamento_falla,ciudad, archivo, Bandeja FROM ServiceDetalle INNER JOIN (select cas_id,equipo_ac,cas_fecha_registro,min_ac, nom_cliente, departamento_falla,ciudad,'Datos' as Bandeja from bandeja union select idcaso,equipo,fcreporte,min,cliente, depto,ciudad,'Dilo' as Bandeja from bandeja_alt union select Id_Caso,'' as equipo_ac,Fc_Reg,Min,Nombre_Cliente,'' as departamento_falla,'' as ciudad,'Fidelizacion' as Bandeja from Bandeja_Falla_Desactivacion_D_V UNION select Id_Caso,'' as equipo_ac,Fecha_registro,Min,Nombre_Cliente,Departamento,Municipio,'Inbound' as Bandeja from Bandeja_inbound) as bandejas ON ServiceDetalle.idcaso = bandejas.cas_id  Left JOIN Diagnostico ON ServiceDetalle.tipofalla = Diagnostico.idreg where idcaso =@strlcaso and (fcprocesado is null OR ServiceDetalle.estado='corregido') order by idcaso"
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
                    If dtsrecepcion.Tables(0).Rows(0).Item("Bandeja") Is System.DBNull.Value Then
                        _Bandeja = " "
                    Else
                        _Bandeja = dtsrecepcion.Tables(0).Rows(0).Item("Bandeja")
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


    Public Sub actualizaescaladosv2servdatos()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
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
    Public Sub Actualiza_Estado_Bandeja_Datos()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja SET estado=@strltipificacion WHERE cas_id=@strlcaso"
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
    Public Sub actualizaestadodevueltoserv()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE bandeja SET estado='No Disponible' WHERE cas_id= @strlcaso and estado<>'Cerrado'"
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
    Public Function consultadevueltosservice() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select tipo,idcaso,obsescal,fcregserv,apn,qos,fcactivacion,tipofalla,idusuarioescala,fcasignado,fcprocesado,idusuarioserv,obsescalamiento, archivo,detalle from ServiceDetalle inner join Diagnostico on ServiceDetalle.tipofalla=Diagnostico.idreg where estado='Devuelto'"
            If strlcaso <> "" Then
                cms.CommandText = "select tipo,idcaso,obsescal,fcregserv,apn,qos,fcactivacion,tipofalla,idusuarioescala,fcasignado,fcprocesado,idusuarioserv,obsescalamiento, archivo,detalle from ServiceDetalle inner join Diagnostico on ServiceDetalle.tipofalla=Diagnostico.idreg where estado='Devuelto' and idcaso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("tipo") Is System.DBNull.Value Then
                    strltipofalla = " "
                Else
                    strltipofalla = dtsrecepcion.Tables(0).Rows(0).Item("tipo")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("idcaso") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("idcaso")
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
                If dtsrecepcion.Tables(0).Rows(0).Item("fcactivacion") Is System.DBNull.Value Then
                    strlfcini = " "
                Else
                    strlfcini = dtsrecepcion.Tables(0).Rows(0).Item("fcactivacion")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("tipofalla") Is System.DBNull.Value Then
                    strldiagvariable = " "
                Else
                    strldiagvariable = dtsrecepcion.Tables(0).Rows(0).Item("tipofalla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("obsescal") Is System.DBNull.Value Then
                    strlobs = " "
                Else
                    strlobs = dtsrecepcion.Tables(0).Rows(0).Item("obsescal")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("archivo") Is System.DBNull.Value Then
                    strlarchivo = " "
                Else
                    strlarchivo = dtsrecepcion.Tables(0).Rows(0).Item("archivo")
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
    Public Function consultacasodevueltoservice() As DataSet
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
    Public Sub actualizaescalaserv()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE ServiceDetalle SET estado='Anulado',tickler=0 WHERE idcaso= @strlcaso"
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
    Public Sub actservice()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If strlarchivo = "" Then
                cms.CommandText = "UPDATE ServiceDetalle set fcasignado=null,fcprocesado=null,obsescal=@strlobs,estado='Corregido',tipofalla=@strldiagvariable,apn=@strlapn,qos=@strlqos,fcactivacion=@strlfcini where idcaso=@strlcaso"
            Else
                cms.CommandText = "UPDATE ServiceDetalle set fcasignado=null,obsescal=@strlobs,estado='Corregido',tipofalla=@strldiagvariable,apn=@strlapn,qos=@strlqos,fcactivacion=@strlfcini,archivo=@strlarchivo where idcaso=@strlcaso"
                cms.Parameters.Add("@strlarchivo", SqlDbType.VarChar, 255).Value = strlarchivo
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strldiagvariable", SqlDbType.Int).Value = strldiagvariable
            cms.Parameters.Add("@strlapn", SqlDbType.VarChar, 50).Value = strlapn
            cms.Parameters.Add("@strlqos", SqlDbType.VarChar, 50).Value = strlqos
            cms.Parameters.Add("@strlfcini", SqlDbType.DateTime).Value = strlfcini
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
    Public Function consultacontrolescalados() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionctrl").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM Cns_controlescalam"
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
    Public Sub liberaasigescalamservicedatos()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
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
    Public Function consultaasignadoservicedatos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
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
    Public Function ConsultaCasosAm1()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT Bandeja.cas_id,Bandeja.min_ac,Bandeja.cas_fecha_registro,Bandeja.estado,CRMDetalle.idusuario,usuarios.codnom,usuarios.cargo,CRMDetalle.fcprogram FROM (Bandeja full JOIN CRMDetalle ON Bandeja.cas_id = CRMDetalle.idcaso) full JOIN usuarios ON CRMDetalle.idusuario = usuarios.idusuario WHERE Bandeja.estado='Programado' and usuarios.cargo like 'N1%' AND Convert(date,CRMDetalle.fcprogram) =@Fecha_Actuals  and @Fecha_Actual_Horas<'14:00:00'"
            cms.Parameters.Add("@Fecha_Actuals", SqlDbType.VarChar, 50).Value = Fecha_Actuals
            cms.Parameters.Add("@Fecha_Actual_Horas", SqlDbType.VarChar, 50).Value = Fecha_Actual_Horas
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function ConsultaCasosPm1()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT Bandeja.cas_id,Bandeja.min_ac,Bandeja.cas_fecha_registro,Bandeja.estado,CRMDetalle.idusuario,usuarios.codnom,usuarios.cargo,CRMDetalle.fcprogram FROM (Bandeja full JOIN CRMDetalle ON Bandeja.cas_id = CRMDetalle.idcaso) full JOIN usuarios ON CRMDetalle.idusuario = usuarios.idusuario WHERE Bandeja.estado='Programado' and usuarios.cargo like 'N1%' AND Convert(date,CRMDetalle.fcprogram) =@Fecha_Actuals  and @Fecha_Actual_Horas>'14:00:00'"
            cms.Parameters.Add("@Fecha_Actuals", SqlDbType.VarChar, 50).Value = Fecha_Actuals
            cms.Parameters.Add("@Fecha_Actual_Horas", SqlDbType.VarChar, 50).Value = Fecha_Actual_Horas
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function ConsultaCasosAm2()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT Bandeja.cas_id,Bandeja.min_ac,Bandeja.cas_fecha_registro,Bandeja.estado,CRMDetalle.idusuario,usuarios.codnom,usuarios.cargo,CRMDetalle.fcprogram FROM (Bandeja full JOIN CRMDetalle ON Bandeja.cas_id = CRMDetalle.idcaso) full JOIN usuarios ON CRMDetalle.idusuario = usuarios.idusuario WHERE Bandeja.estado='Programado' and usuarios.cargo like 'N2%' AND Convert(date,CRMDetalle.fcprogram) =@Fecha_Actuals  and @Fecha_Actual_Horas<'14:00:00'"
            cms.Parameters.Add("@Fecha_Actuals", SqlDbType.VarChar, 50).Value = Fecha_Actuals
            cms.Parameters.Add("@Fecha_Actual_Horas", SqlDbType.VarChar, 50).Value = Fecha_Actual_Horas
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function ConsultaCasosPm2()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT Bandeja.cas_id,Bandeja.min_ac,Bandeja.cas_fecha_registro,Bandeja.estado,CRMDetalle.idusuario,usuarios.codnom,usuarios.cargo,CRMDetalle.fcprogram FROM (Bandeja full JOIN CRMDetalle ON Bandeja.cas_id = CRMDetalle.idcaso) full JOIN usuarios ON CRMDetalle.idusuario = usuarios.idusuario WHERE Bandeja.estado='Programado' and usuarios.cargo like 'N2%' AND Convert(date,CRMDetalle.fcprogram) =@Fecha_Actuals  and @Fecha_Actual_Horas>'14:00:00'"
            cms.Parameters.Add("@Fecha_Actuals", SqlDbType.VarChar, 50).Value = Fecha_Actuals
            cms.Parameters.Add("@Fecha_Actual_Horas", SqlDbType.VarChar, 50).Value = Fecha_Actual_Horas
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            cantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Sub RegistroBoldChat()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim cn2 As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            strlfcreg = Now
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 15).Value = strlmin
            cms.Parameters.Add("@strlnompaquete", SqlDbType.VarChar, 255).Value = strlnompaquete
            cms.Parameters.Add("@strlequipo", SqlDbType.VarChar, 255).Value = strlequipo
            '**********  MODIFICADO   ************
            If _Tipo_Falla <> Nothing Then
                cms.Parameters.Add("@_Tipo_Falla", SqlDbType.VarChar, 100).Value = _Tipo_Falla
            Else
                cms.Parameters.AddWithValue("@_Tipo_Falla", DBNull.Value)
            End If
            If strlmesa = "Datos" Then
                cn.Open()
                cms.CommandText = "INSERT INTO bandeja(tipofalla,cas_id,cas_fecha_registro,usuario_registra,min_ac,nom_cliente,equipo_ac,estado,Bandeja) values (@_Tipo_Falla,@strlcaso,@strlfcreg,@strlidusuario,@strlmin,@strlnompaquete,@strlequipo,'Abierto','Bold Chat')"
                cms.Connection = cn
            End If
            '********************************
            If strlmesa = "Voz" Then
                cn2.Open()
                cms.CommandText = "INSERT INTO Bandeja_uni(idcaso,cas_fecha_registro,usuario_asignado,min_ac,nom_cliente,equipo_ac,estado,bandeja) values (@strlcaso,@strlfcreg,@strlidusuario,@strlmin,@strlnompaquete,@strlequipo,'Abierto','Bold Chat')"
                cms.Connection = cn2
            End If
            cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Function Consulta_No_Gestion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Sin_gestion where min_ac=@strlmin"
            cms.Parameters.Add("@strlmin", SqlDbType.Decimal).Value = strlmin
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
    Public Function Consultacasos_Datos_Dilo_Voz() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim cnVoz As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cnDatos.Open()
            cms.CommandText = "SELECT idcrm,cas_id, fcreg, obs, tipo_soporte, tipificacion, idusuario, min_ac, nom_cliente, equipo_ac, fallared, bandeja FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@_Caso ORDER BY idcrm DESC"
            cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If (strlcantidad > 0) Then
                If dts.Tables(0).Rows(0).Item("cas_id") Is DBNull.Value Then
                    strlcaso = ""
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("cas_id")
                End If
                If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                End If
                If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                    strlcliente = ""
                Else
                    strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                End If
                If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                    strlequipo = ""
                Else
                    strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                End If
                If dts.Tables(0).Rows(0).Item("Bandeja") Is DBNull.Value Then
                    strlmesa = ""
                Else
                    strlmesa = dts.Tables(0).Rows(0).Item("Bandeja")
                End If
            Else
                cms.CommandText = "SELECT CRM.idcrmdilo as idcrm,B.idcaso as idcaso,CRM.fcregistro as fcreg,CRM.obs, CRM.tipificacion, CRM.idusuario,B.min as min_ac,B.telcontacto as min_acc,B.cliente as nom_cliente,B.equipo as equipo_ac, B.mesa as bandeja FROM CRMdilo CRM RIGHT OUTER join Bandeja_alt B on CRM.idcasodilo=B.idcaso where B.idcaso=@_Caso ORDER BY CRM.idcrmdilo DESC"
                'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
                cms.Connection = cnDatos
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                strlcantidad = dts.Tables(0).Rows.Count
                If (strlcantidad > 0) Then
                    If dts.Tables(0).Rows(0).Item("idcaso") Is DBNull.Value Then
                        strlcaso = ""
                    Else
                        strlcaso = dts.Tables(0).Rows(0).Item("idcaso")
                    End If
                    If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                        strlmin = ""
                        If dts.Tables(0).Rows(0).Item("min_acc") Is DBNull.Value Then
                            strlmin = ""
                        Else
                            strlmin = dts.Tables(0).Rows(0).Item("min_acc")
                        End If
                    Else
                        strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                    End If
                    If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                        strlcliente = ""
                    Else
                        strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                    End If
                    If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                        strlequipo = ""
                    Else
                        strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                    End If
                    If dts.Tables(0).Rows(0).Item("Bandeja") Is DBNull.Value Then
                        strlmesa = ""
                    Else
                        strlmesa = dts.Tables(0).Rows(0).Item("Bandeja")
                    End If
                Else
                    cnVoz.Open()
                    cms.CommandText = "SELECT BU.idcaso,fcreg, obs, tiposoporte, BU.tipificacion, idusuario,min_ac, nom_cliente, equipo_ac, fallared, bandeja FROM VCRMDetalle RIGHT OUTER join Bandeja_uni BU on VCRMDetalle.idcaso=BU.idcaso where BU.idcaso=@_Caso ORDER BY idcrm DESC"
                    'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
                    cms.Connection = cnVoz
                    dta = New SqlClient.SqlDataAdapter(cms)
                    dta.Fill(dts)
                    strlcantidad = dts.Tables(0).Rows.Count
                    If (strlcantidad > 0) Then
                        If dts.Tables(0).Rows(0).Item("idcaso") Is DBNull.Value Then
                            strlcaso = ""
                        Else
                            strlcaso = dts.Tables(0).Rows(0).Item("idcaso")
                        End If
                        If dts.Tables(0).Rows(0).Item("min_ac") Is DBNull.Value Then
                            strlmin = ""
                        Else
                            strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                        End If
                        If dts.Tables(0).Rows(0).Item("nom_cliente") Is DBNull.Value Then
                            strlcliente = ""
                        Else
                            strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                        End If
                        If dts.Tables(0).Rows(0).Item("equipo_ac") Is DBNull.Value Then
                            strlequipo = ""
                        Else
                            strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                        End If
                        If dts.Tables(0).Rows(0).Item("Bandeja") Is DBNull.Value Then
                            strlmesa = ""
                        Else
                            strlmesa = dts.Tables(0).Rows(0).Item("Bandeja")
                        End If
                    End If
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
    Public Function ConsultaGestion_Casos_Datos_Dilo_Voz() As DataSet
        Dim cnDatos As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim cnVoz As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString) ' Conexion con la base
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Dim dta As SqlClient.SqlDataAdapter
        Try
            cnDatos.Open()
            cms.CommandText = "SELECT idcrm,cas_id, fcreg, obs, tipo_soporte, tipificacion, idusuario, min_ac, nom_cliente, equipo_ac, fallared, bandeja FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@_Caso ORDER BY idcrm DESC"
            cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
            cms.Connection = cnDatos
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If (strlcantidad > 0) Then
            Else
                cms.CommandText = "SELECT CRM.idcrmdilo as idcrm,B.idcaso as cas_id,CRM.fcregistro as fcreg,CRM.obs, CRM.tipificacion, CRM.idusuario,B.telcontacto as min_ac,B.cliente as nom_cliente,B.equipo as equipo_ac, B.mesa as bandeja FROM CRMdilo CRM RIGHT OUTER join Bandeja_alt B on CRM.idcasodilo=B.idcaso where B.idcaso=@_Caso ORDER BY CRM.idcrmdilo DESC"
                'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
                cms.Connection = cnDatos
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                strlcantidad = dts.Tables(0).Rows.Count
                If (strlcantidad > 0) Then
                Else
                    cnVoz.Open()
                    cms.CommandText = "SELECT fallatec,bandeja_uni.idcaso, cas_fecha_registro, tipoinc, min_ac, nom_cliente, documento, equipo_ac, usuario_asignado, bandeja, estado, idcrm, fcreg, idusuario, obs, VCRMDetalle.tipificacion, tiposoporte, destiposoporte  as tipo_soporte, numalt FROM VCRMDetalle INNER JOIN VSoporte ON VCRMDetalle.tiposoporte = VSoporte.idsoporte RIGHT OUTER JOIN Bandeja_uni ON VCRMDetalle.idcaso = Bandeja_uni.idcaso where bandeja_uni.idcaso=@_Caso ORDER BY idcrm DESC"
                    'cms.Parameters.Add("@_Caso", SqlDbType.Int).Value = strlcaso
                    cms.Connection = cnVoz
                    dta = New SqlClient.SqlDataAdapter(cms)
                    dta.Fill(dts)
                    strlcantidad = dts.Tables(0).Rows.Count
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
    Public Function infdinamicos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * from Infdinamicos"
            If strlfcini3 <> "" Then
                cms.CommandText = "SELECT * from Infdinamicos where fechacreacion>=@strlfcini3"
                cms.Parameters.Add("@strlfcini3", SqlDbType.Date).Value = strlfcini3
                If strlfcfin3 <> "" Then
                    cms.CommandText = "SELECT * from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    cms.Parameters.Add("@strlfcfin3", SqlDbType.Date).Value = strlfcfin3
                End If
            End If
            If strlcaso <> "" Then
                cms.CommandText = "SELECT caso from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlmin <> "" Then
                cms.CommandText = "SELECT min from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT min from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT min from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlfcreg <> "" Then
                cms.CommandText = "SELECT fechacreacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcaso <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT caso,min from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,min from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,min from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcaso <> "" And strlfcreg <> "" Then
                cms.CommandText = "SELECT caso,fechacreacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlmin <> "" And strlfcreg <> "" Then
                cms.CommandText = "SELECT min,fechacreacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT min,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT min,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcaso <> "" And strlmin <> "" And strlfcreg <> "" Then
                cms.CommandText = "SELECT caso,min,fechacreacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,min,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,min,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcliente <> "" Then
                cms.CommandText = "SELECT cliente from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT cliente from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT cliente from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcliente <> "" And strlcaso <> "" Then
                cms.CommandText = "SELECT caso,cliente from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,cliente from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,cliente from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcliente <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT cliente,min from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT cliente,min from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT cliente,min from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcliente <> "" And strlfcreg <> "" Then
                cms.CommandText = "SELECT cliente,fechacreacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT cliente,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT cliente,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcliente <> "" And strlfcreg <> "" And strlcaso <> "" Then
                cms.CommandText = "SELECT caso,cliente,fechacreacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,cliente,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,cliente,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcliente <> "" And strlmin <> "" And strlcaso <> "" Then
                cms.CommandText = "SELECT caso,cliente,min from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,cliente,min from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,cliente,min from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlcliente <> "" And strlmin <> "" And strlcaso <> "" And strlfcreg <> "" Then
                cms.CommandText = "SELECT caso,cliente,min,fechacreacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,cliente,min,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,cliente,min,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If

            'identificacion
            If strlidentificacion <> "" Then
                cms.CommandText = "SELECT identificacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT identificacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT identificacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlidentificacion <> "" And strlcaso <> "" Then
                cms.CommandText = "SELECT caso,identificacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,identificacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,identificacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlidentificacion <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT min,identificacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT min,identificacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT min,identificacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlidentificacion <> "" And strlfcreg <> "" Then
                cms.CommandText = "SELECT identificacion,fechacreacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT identificacion,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT identificacion,fechacreacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlidentificacion <> "" And strlcliente <> "" Then
                cms.CommandText = "SELECT identificacion,cliente from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlidentificacion <> "" And strlcliente <> "" And strlcaso <> "" Then
                cms.CommandText = "SELECT caso,identificacion,cliente from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlidentificacion <> "" And strlcliente <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT min,identificacion,cliente from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT min,identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT min,identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlidentificacion <> "" And strlcaso <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT caso,min,identificacion from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,min,identificacion from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,min,identificacion from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlidentificacion <> "" And strlcaso <> "" And strlmin <> "" And strlcliente <> "" Then
                cms.CommandText = "SELECT caso,min,identificacion,cliente from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,min,identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,min,identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlidentificacion <> "" And strlcaso <> "" And strlmin <> "" And strlcliente <> "" And strlfcreg <> "" Then
                cms.CommandText = "SELECT caso,min,fechacreacion,identificacion,cliente from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,min,fechacreacion,identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,min,fechacreacion,identificacion,cliente from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            'estado
            If strlestadoinc <> "" Then
                cms.CommandText = "SELECT caso,estado from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,estado from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,estado from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlestadoinc <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT min,estado from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT min,estado from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT min,estado from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlestadoinc <> "" And fcreg <> "" Then
                cms.CommandText = "SELECT fechacreacion,estado from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT fechacreacion,estado from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT fechacreacion,estado from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlestadoinc <> "" And strlidentificacion <> "" Then
                cms.CommandText = "SELECT identificacion,estado from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT identificacion,estado from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT identificacion,estado from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlestadoinc <> "" And strlcliente <> "" Then
                cms.CommandText = "SELECT cliente,estado from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT cliente,estado from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT cliente,estado from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlestadoinc <> "" And strlcaso <> "" And strlmin <> "" Then
                cms.CommandText = "SELECT caso,min,estado from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,min,estado from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,min,estado from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlestadoinc <> "" And strlcaso <> "" And strlmin <> "" And strlcliente <> "" Then
                cms.CommandText = "SELECT caso,min,cliente,estado from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,min,cliente,estado from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,min,cliente,estado from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlestadoinc <> "" And strlcaso <> "" And strlmin <> "" And strlcliente <> "" And strlidentificacion <> "" Then
                cms.CommandText = "SELECT caso,min,cliente,identificacion,estado from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,min,cliente,identificacion,estado from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,min,cliente,identificacion,estado from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If
            If strlestadoinc <> "" And strlcaso <> "" And strlmin <> "" And strlcliente <> "" And strlidentificacion <> "" And strlfcreg <> "" Then
                cms.CommandText = "SELECT caso,min,fechacreacion,cliente,identificacion,estado from Infdinamicos"
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT caso,min,fechacreacion,cliente,identificacion,estado from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT caso,min,fechacreacion,cliente,identificacion,estado from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
            End If

            'todos
            If strltlinea <> "" Then
                If strlfcini3 <> "" Then
                    cms.CommandText = "SELECT * from Infdinamicos where fechacreacion>=@strlfcini3"
                    If strlfcfin3 <> "" Then
                        cms.CommandText = "SELECT * from Infdinamicos where fechacreacion>=@strlfcini3 and fechacreacion<=@strlfcfin3"
                    End If
                End If
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
    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''' Campaña Bienvenida '''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Consulta_Caso_Bienvenida() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Bandeja_Bienvenida BB left join CRM_Bienvenida C on BB.Cas_Id = C.idcaso where BB.min_ac = @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("cas_id") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("cas_id")
                End If
                If dts.Tables(0).Rows(0).Item("nom_cliente") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dts.Tables(0).Rows(0).Item("nom_cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Documento") Is System.DBNull.Value Then
                    strldocumento = " "
                Else
                    strldocumento = dts.Tables(0).Rows(0).Item("Documento")
                End If
                If dts.Tables(0).Rows(0).Item("min_ac") Is System.DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dts.Tables(0).Rows(0).Item("min_ac")
                End If
                If dts.Tables(0).Rows(0).Item("equipo_ac") Is System.DBNull.Value Then
                    strlequipo = " "
                Else
                    strlequipo = dts.Tables(0).Rows(0).Item("equipo_ac")
                End If
                If dts.Tables(0).Rows(0).Item("Plan_Actual") Is System.DBNull.Value Then
                    strlplan = " "
                Else
                    strlplan = dts.Tables(0).Rows(0).Item("Plan_Actual")
                End If
                If dts.Tables(0).Rows(0).Item("Ciudad") Is System.DBNull.Value Then
                    strllugar = " "
                Else
                    strllugar = dts.Tables(0).Rows(0).Item("Ciudad")
                End If
                If dts.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dts.Tables(0).Rows(0).Item("estado")
                End If
                If dts.Tables(0).Rows(0).Item("Fc_Compra") Is System.DBNull.Value Then
                    strlfcingn3 = " "
                Else
                    strlfcingn3 = dts.Tables(0).Rows(0).Item("Fc_Compra")
                End If
                If dts.Tables(0).Rows(0).Item("Paquete_Datos") Is System.DBNull.Value Then
                    strlajuste = " "
                Else
                    strlajuste = dts.Tables(0).Rows(0).Item("Paquete_Datos")
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
    Public Sub ActualizaBandejaBienvenida()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE Bandeja_Bienvenida SET estado= @strltipificacion WHERE cas_id= @strlcaso and estado <> 'Llamada Satisfecha'"
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
    Public Sub Registro_CRM_Bienvenida()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            If strlhoraprog <> Nothing Then
                cms.CommandText = "insert into CRM_Bienvenida (idcaso,fcreg,idusuario,obs,tipo_soporte,tipificacion,preg1,preg2,preg3,preg4,numalt,fcprogram) values (@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strlpreg1,@strlpreg2,@strlpreg3,@strlchk1,@strltelalt,@strlhoraprog)"
                cms.Parameters.Add("@strlhoraprog", SqlDbType.NVarChar, 50).Value = strlhoraprog
            Else
                cms.CommandText = "insert into CRM_Bienvenida (idcaso,fcreg,idusuario,obs,tipo_soporte,tipificacion,preg1,preg2,preg3,preg4,numalt) values (@strlcaso,@strlfcreg,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,@strlpreg1,@strlpreg2,@strlpreg3,@strlchk1,@strltelalt)"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltiposoporte", SqlDbType.VarChar, 255).Value = strltiposoporte
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            cms.Parameters.Add("@strlpreg1", SqlDbType.VarChar, 255).Value = strlpreg1
            cms.Parameters.Add("@strlpreg2", SqlDbType.VarChar, 255).Value = strlpreg2
            cms.Parameters.Add("@strlpreg3", SqlDbType.VarChar, 255).Value = strlpreg3
            cms.Parameters.Add("@strlchk1", SqlDbType.VarChar, 255).Value = strlchk1
            cms.Parameters.Add("@strltelalt", SqlDbType.VarChar, 100).Value = strltelalt
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
    Public Function ConsultaNxMonitorBienvenida()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from CRM_Bienvenida where idcaso=@strlcaso and preg2='SI' order by fcreg desc"
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
    Public Sub asignacasofallatec()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
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
    Public Sub registroincbienvenidad()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO Detalleinc_Bienvenida(nivel,idcaso,obsinc,idtipoinc,estado,fcreg,idusuariorep) values(@strlbarrio,@strlcaso,@strlobs,@strlincidente,'Reportado',@strlfcreg,@strlidusuario)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlincidente", SqlDbType.Int).Value = strlincidente
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar, 50).Value = strlbarrio
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
    Public Function consultageneral() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM BD_Datos_Complemento where pertenece='FallaTec_Estado_Cons_D' or pertenece='- Seleccione -' order by Nombre"
            If tickler <> "" Then
                cms.CommandText = "Select * from Ctrlfallatec  where tickler=@Tikler"
                cms.Parameters.Add("@Tikler", SqlDbType.VarChar, 50).Value = strltickler
            End If
            If caso <> "" Then
                cms.CommandText = "Select * from Ctrlfallatec  where Idcaso=@Idcaso"
                cms.Parameters.Add("@Idcaso", SqlDbType.Int).Value = strlcaso
            End If
            If dir <> "- Seleccione -" And dir <> "" Then
                cms.CommandText = "Select * from Ctrlfallatec  where estado=@estado"
                cms.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = strldir
            End If
            If min <> "" Then
                cms.CommandText = "Select * from Ctrlfallatec  where min=@min"
                cms.Parameters.Add("@min", SqlDbType.VarChar, 50).Value = strlmin
            End If
            If idcrm <> "" Then
                cms.CommandText = "Select * from Ctrlfallatec  where id_Ctrlfallatec=@codfallatec"
                cms.Parameters.Add("@codfallatec", SqlDbType.VarChar, 50).Value = strlidcrm
            End If
            If fcini <> "" And fcfin <> "" Then
                cms.CommandText = "SELECT *  FROM Ctrlfallatec  WHERE fcsap BETWEEN @fechainicio AND @fechafin"
                cms.Parameters.Add("@fechainicio", SqlDbType.VarChar, 50).Value = strlfcini
                cms.Parameters.Add("@fechafin", SqlDbType.VarChar, 50).Value = strlfcfin
            End If
            If dir <> "- Seleccione -" And dir <> Nothing And fcini <> "" And fcfin <> "" Then
                cms.CommandText = "Select * from Ctrlfallatec  where estado=@estado1 and fcsap BETWEEN @fechainici AND @fechaf"
                cms.Parameters.Add("@estado1", SqlDbType.VarChar, 50).Value = strldir
                cms.Parameters.Add("@fechainici", SqlDbType.VarChar, 50).Value = strlfcini
                cms.Parameters.Add("@fechaf", SqlDbType.VarChar, 50).Value = strlfcfin
            End If
            If Validacion = 1 Then
                cms.CommandText = "select Id_Ctrlfallatec,  idcaso,min,tickler,fcsap, Ct.estado,Tipo,Pertenece,obs,fc_reg from gestion_fallatec Ct inner join Ctrlfallatec on id_Ctrlfallatec= fk_id_Ctrlfallatec  where id_Ctrlfallatec=@codfallatec"
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
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''' Validación Inconsistencia CrmBienvenidad '''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function validainconsistenciaasignada() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM Detalleinc_Bienvenida where idcaso=@strlcaso"
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
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''' GESTION POR CAMPAÑA - LOGIN '''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Consulta_Gestion_Campaña() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from Meta_Gestion where Campaña = @strlCampanaLogin and Estado=@strlestadoinc"
            cms.Parameters.Add("@strlCampanaLogin", SqlDbType.VarChar, 50).Value = strlCampanaLogin
            cms.Parameters.Add("@strlestadoinc", SqlDbType.VarChar, 50).Value = strlestadoinc
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
    Public Sub Ingreso_Gestion()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "insert into Gestion (id_caso,Fc_Reg,Id_Usuario,Estado,CampanaLogin,Supervisor) values (@strlcaso,@strlfcreg,@strlidusuario,@strlestadoinc,@strlCampanaLogin,@strlSuperv)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlestadoinc", SqlDbType.NVarChar, 50).Value = strlestadoinc
            cms.Parameters.Add("@strlCampanaLogin", SqlDbType.NVarChar, 50).Value = strlCampanaLogin
            cms.Parameters.Add("@strlSuperv", SqlDbType.VarChar, 50).Value = strlSuperv
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
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''' Ingresa Numero de Intentos ''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub Ingresa_N_Intentos()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Num_Intento (casi_id,Id_Usuario) values (@strlcaso,@strlidusuario)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = Me.strlcaso
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
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''' Escalamiento Nivel 3 ''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub RegistroNivel3()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Escalado_N3 (Id_Caso,Id_Usuario,Fc_Activacion,Obs ) values (@strlcaso,@strlidusuario,@strlfcini,@strlObsNivel3)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = Me.strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlfcini", SqlDbType.DateTime).Value = strlfcini
            cms.Parameters.Add("@strlObsNivel3", SqlDbType.VarChar).Value = strlObsNivel3
            cms.Connection = cn
            cms.ExecuteNonQuery()
            If Validacion = 1 Then
                cms.CommandText = "UPDATE bandeja SET estadon3='Abierto' where cas_id=@caso "
                cms.Parameters.Add("@caso", SqlDbType.VarChar).Value = Me.strlcaso
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
    Public Function Consulta_NIvel3() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = 1 Then
                cms.CommandText = "SELECT idusuario,nombreu FROM usuarios where cargo like  'N3%'"
            End If
            If Validacion = 2 Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & "EN.Id_Caso, EN.Fc_Reg, EN.Id_Usuario,b.cas_fecha_registro,b.bandeja from Escalado_N3 EN inner join bandeja b on b.cas_id=EN.Id_Caso where  en.id_usuario_asignado is null"
            End If
            If Validacion = 3 Then
                cms.CommandText = "SELECT id_caso FROM Escalado_N3 where id_caso =@caso"
                cms.Parameters.Add("@caso", SqlDbType.BigInt).Value = caso
            End If

            If Validacion = 4 Then
                cms.CommandText = "SELECT ID_USUARIO_ASIGNADO, COUNT(id_caso) AS casos FROM Escalado_N3 WHERE ID_USUARIO_ASIGNADO IS not NULL AND Fc_Reg is not null GROUP BY ID_USUARIO_ASIGNADO"
            End If
            If Validacion = 5 Then
                cms.CommandText = "SELECT E.id_caso,b.min_ac,E.FC_REG_ASIGNA  FROM Escalado_N3 E inner join bandeja b on  b.cas_id=E.Id_Caso where Id_Usuario_Asignado=@usuario  and b.estadon3='Abierto'"
                cms.Parameters.Add("@usuario", SqlDbType.VarChar).Value = idusuarioasignado
            End If
            If Validacion = 6 Then
                cms.CommandText = "SELECT E.id_caso,b.min_ac,E.FC_REG_ASIGNA  FROM Escalado_N3 E inner join bandeja b on  b.cas_id=E.Id_Caso where Id_Usuario_Asignado=@usuario  and b.estadon3<>'Cerrado'"
                cms.Parameters.Add("@usuario", SqlDbType.VarChar).Value = idusuarioasignado
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
    Public Sub asignaescalanivel3()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Escalado_N3 SET  fc_reg_asigna=@strlfcreg, id_usuario_asigna=@strlidusuario,id_usuario_asignado=@strlidusuarioasignado WHERE id_caso= @strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlidusuarioasignado", SqlDbType.VarChar, 50).Value = strlidusuarioasignado
            cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = Now
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
    Public Sub Liberaescalanivel3()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "UPDATE Escalado_N3 SET id_Usuario_Asigna=null,Id_Usuario_Asignado=null,Fc_Reg_Asigna=null FROM  Escalado_N3 E JOIN BANDEJA B ON   B.cas_id = E.id_caso where b.estado<>'Abierto' and E.id_caso = @caso"
            cms.Parameters.Add("@caso", SqlDbType.VarChar, 50).Value = caso
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
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''' Fallas Voz Y Datos - Clientes con Intención de Desactivación '''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Consulta_Inf_Caso_Falla_Desactivacion_D_V() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            'Modificado
            cms.CommandText = "select * from Bandeja_Falla_Desactivacion_D_V B  left join CRM_Falla_Desactivacion_D_V C on B.Id_Bandeja_Falla_Desactivacion_D_V = C.Fk_Id_Bandeja where B.Id_Bandeja_Falla_Desactivacion_D_V=@strlcaso or  Id_Caso= @strlcaso order by Fc_Reg_Ges desc"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            'cms.Parameters.Add("@_Caso_Claro", SqlDbType.Decimal).Value = _Caso_Claro 'Modificado 23/12/2015
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Estado_N3") Is System.DBNull.Value Then
                    strlestadoinc = " "
                Else
                    strlestadoinc = dts.Tables(0).Rows(0).Item("Estado_N3")
                End If
                If dts.Tables(0).Rows(0).Item("Fc_Reg_N3") Is System.DBNull.Value Then
                    strlfcingn3 = " "
                Else
                    strlfcingn3 = dts.Tables(0).Rows(0).Item("Fc_Reg_N3")
                End If
                If dts.Tables(0).Rows(0).Item("Nombre_Cliente") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dts.Tables(0).Rows(0).Item("Nombre_Cliente")
                End If
                If dts.Tables(0).Rows(0).Item("Cedula") Is System.DBNull.Value Then
                    strldocumento = " "
                Else
                    strldocumento = dts.Tables(0).Rows(0).Item("Cedula")
                End If
                If dts.Tables(0).Rows(0).Item("Min") Is System.DBNull.Value Then
                    strlmin = ""
                Else
                    strlmin = dts.Tables(0).Rows(0).Item("Min")
                End If
                If dts.Tables(0).Rows(0).Item("Plan_Actual_Ac") Is System.DBNull.Value Then
                    strlplan = " "
                Else
                    strlplan = dts.Tables(0).Rows(0).Item("Plan_Actual_Ac")
                End If
                If dts.Tables(0).Rows(0).Item("Direccion") Is System.DBNull.Value Then
                    strllugar = " "
                Else
                    strllugar = dts.Tables(0).Rows(0).Item("Direccion")
                End If
                If dts.Tables(0).Rows(0).Item("Id_Bandeja_Falla_Desactivacion_D_V") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dts.Tables(0).Rows(0).Item("Id_Bandeja_Falla_Desactivacion_D_V")
                End If
                If dts.Tables(0).Rows(0).Item("Id_Caso") Is System.DBNull.Value Then
                    _Caso_Claro = ""
                Else
                    _Caso_Claro = dts.Tables(0).Rows(0).Item("Id_Caso")
                End If
                If dts.Tables(0).Rows(0).Item("Observaciones") Is System.DBNull.Value Then
                    strlobsini = " "
                Else
                    strlobsini = dts.Tables(0).Rows(0).Item("Observaciones")
                End If
                If dts.Tables(0).Rows(0).Item("Estado") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dts.Tables(0).Rows(0).Item("Estado")
                End If
                If dts.Tables(0).Rows(0).Item("Bandeja") Is System.DBNull.Value Then
                    _Bandeja = ""
                Else
                    _Bandeja = dts.Tables(0).Rows(0).Item("Bandeja")
                End If
                If dts.Tables(0).Rows(0).Item("Fc_Reg") Is System.DBNull.Value Then
                    strlcasfcregistro = " "
                Else
                    strlcasfcregistro = dts.Tables(0).Rows(0).Item("Fc_Reg")
                End If
                If dts.Tables(0).Rows(0).Item("Call_Remite") Is System.DBNull.Value Then
                    strlarchivo = " "
                Else
                    strlarchivo = dts.Tables(0).Rows(0).Item("Call_Remite")
                End If
                If dts.Tables(0).Rows(0).Item("Otro_Contacto") Is System.DBNull.Value Then
                    strltelalt = " "
                Else
                    strltelalt = dts.Tables(0).Rows(0).Item("Otro_Contacto")
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

    Public Sub Modificacion_Caso_N3_Falla_Desactivacion_D_V()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE Bandeja_Falla_Desactivacion_D_V SET Fc_Reg_N3=@strlfcingn3, Pqr=@strlpqr, Consultor_N3=@strlingn3, Estado_N3='ABIERTO' WHERE Id_Bandeja_Falla_Desactivacion_D_V=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlfcingn3", SqlDbType.VarChar, 50).Value = strlfcingn3
            cms.Parameters.Add("@strlpqr", SqlDbType.VarChar, 5).Value = strlpqr
            cms.Parameters.Add("@strlingn3", SqlDbType.VarChar, 255).Value = strlingn3
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
    Public Sub RegistroCrm_Falla_Desactivacion_D_V()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO CRM_Falla_Desactivacion_D_V(Fk_Id_Bandeja,Id_Usuario,Obs,Telefono_Alt,Tipo_Soporte,Tipo_Linea,Tipificacion,Equipo,Escalamiento_CPD_SD,Segmentacion_Linea,Correo_Electronico,PQR,Fc_Programado,Contacto)  values(@strlcaso,@strlidusuario,@strlobs,@strltelalt,@strltiposoporte,@strltlinea,@strltipificacion,@strlequipo,@_Escalamiento_CPD_SD,@_Segmentacion_Linea,@strlemail,@strlpqr,@strlhoraprog,@_Contacto_cliente)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            If strltelalt = Nothing Then
                cms.Parameters.AddWithValue("@strltelalt", DBNull.Value)
            Else
                cms.Parameters.Add("@strltelalt", SqlDbType.VarChar, 100).Value = strltelalt
            End If
            cms.Parameters.Add("@strltiposoporte", SqlDbType.VarChar, 255).Value = strltiposoporte
            If strltlinea = Nothing Then
                cms.Parameters.AddWithValue("@strltlinea", DBNull.Value)
            Else
                cms.Parameters.Add("@strltlinea", SqlDbType.VarChar, 50).Value = strltlinea
            End If
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar, 255).Value = strltipificacion
            If strlequipo = Nothing Then
                cms.Parameters.AddWithValue("@strlequipo", DBNull.Value)
            Else
                cms.Parameters.Add("@strlequipo", SqlDbType.VarChar, 255).Value = strlequipo
            End If
            If _Escalamiento_CPD_SD = Nothing Then
                cms.Parameters.AddWithValue("@_Escalamiento_CPD_SD", DBNull.Value)
            Else
                cms.Parameters.Add("@_Escalamiento_CPD_SD", SqlDbType.VarChar, 255).Value = _Escalamiento_CPD_SD
            End If
            If _Segmentacion_Linea = Nothing Then
                cms.Parameters.AddWithValue("@_Segmentacion_Linea", DBNull.Value)
            Else
                cms.Parameters.Add("@_Segmentacion_Linea", SqlDbType.VarChar, 255).Value = _Segmentacion_Linea
            End If
            If strlemail = Nothing Then
                cms.Parameters.AddWithValue("@strlemail", DBNull.Value)
            Else
                cms.Parameters.Add("@strlemail", SqlDbType.VarChar, 255).Value = strlemail
            End If
            If strlhoraprog = Nothing Then
                cms.Parameters.AddWithValue("@strlhoraprog", DBNull.Value)
            Else
                cms.Parameters.Add("@strlhoraprog", SqlDbType.VarChar, 255).Value = strlhoraprog
            End If
            If _Contacto_cliente = Nothing Then
                cms.Parameters.AddWithValue("@_Contacto_cliente", DBNull.Value)
            Else
                cms.Parameters.Add("@_Contacto_cliente", SqlDbType.VarChar, 255).Value = _Contacto_cliente
            End If


            cms.Parameters.Add("@strlpqr", SqlDbType.BigInt).Value = strlpqr
            If strltipificacion = "No contactado" Then
                cms.CommandText = "INSERT INTO CRM_Falla_Desactivacion_D_V(Fk_Id_Bandeja,Id_Usuario,Obs,Tipo_Soporte,Tipificacion,Equipo,Segmentacion_Linea,Correo_Electronico,PQR) values (@strlcaso,@strlidusuario,@strlobs,@strltiposoporte,@strltipificacion,'No Contactado','No Contactado','No Contactado',@strlpqr)"
                cms.Connection = cn
                cms.ExecuteNonQuery()
                Exit Sub
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
    Public Sub Actualiza_Bandejan_Falla_Desactivacion_D_V()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "UPDATE Bandeja_Falla_Desactivacion_D_V SET Estado=@strltipificacion, Estado_N3=@strltipificacion WHERE Id_Bandeja_Falla_Desactivacion_D_V=@strlcaso and Estado<>'Cerrado' and Estado<>'Escalado Informatica' and Estado<>'Escalado Tecnica'"
            If strltipificacion = "Cerrado" Or strltipificacion = "Previamente Cerrado" Then
                cms.CommandText = "UPDATE Bandeja_Falla_Desactivacion_D_V SET Estado=@strltipificacion, Estado_N3=@strltipificacion WHERE Id_Bandeja_Falla_Desactivacion_D_V=@strlcaso"
            End If
            If strltipificacion = "Solicitud Escalar CPD" Or strltipificacion = "Solicitud Escalar SD" Then
                cms.CommandText = "UPDATE Bandeja_Falla_Desactivacion_D_V SET Estado=@strltipificacion, Estado_N3=@strltipificacion WHERE Id_Bandeja_Falla_Desactivacion_D_V=@strlcaso and Estado<>'Cerrado'"
            End If
            If strltipificacion = "No corresponde" Or strltipificacion = "No contactado" Then
                cms.CommandText = "UPDATE Bandeja_Falla_Desactivacion_D_V SET estado=@strltipificacion WHERE Id_Bandeja_Falla_Desactivacion_D_V= @strlcaso and estado <> 'Cerrado' and estado <> 'Previamente Cerrado' and estado <> 'Escalado Informatica' and estado <> 'Escalado Tecnica'"
            End If
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

    Public Function Consulta_Registro_Falla_Red_Incinsistencia_Otro() As DataSet
        Dim cnD As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cnV As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Try
            Dim dta As SqlClient.SqlDataAdapter
            Dim dts As New DataSet
            Dim cms As New SqlClient.SqlCommand
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            If Validacion = "Falla Red" Then
                cnV.Open()
                cms.CommandText = "Select * from VFallared where idcaso=@strlcaso"
                cms.Connection = cnV
            End If
            If Validacion = "Inconsistencia" Then
                cnD.Open()
                cms.CommandText = "Select * from Detalleinc where idcaso=@strlcaso"
                cms.Connection = cnD
            End If
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cnD.State = ConnectionState.Open Then
                cnD.Close()
            End If
            If cnV.State = ConnectionState.Open Then
                cnV.Close()
            End If
        End Try
    End Function
    ''''Consulta General Bandeja_Falla_Desactivacion_D_V
 Public Function Consulta_General_Bandeja_Falla_Desactivacion_D_V() As DataSet 'Copyright © 2016 ICDDC
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = ""
        Dim CASO_CLARO As String = ""
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                If strlcantidad = "CASO_CLARO" Then
                    CASO_CLARO = " INNER JOIN Bandeja_Falla_Desactivacion_D_V B On B.Id_Caso = @caso where C.Id_Caso = B.Id_Bandeja_Falla_Desactivacion_D_V "
                    WHERE = " B.Id_Caso = @caso "
                Else
                    CASO_CLARO = " where C.Id_Caso= @caso "
                    WHERE = " B.Id_Bandeja_Falla_Desactivacion_D_V = @caso "
                End If
                If _Validacion = "Seguimiento" Then
                    cms.CommandText = "SELECT C.Id_CRM_Falla_Desactivacion_D_V As ID,C.Fk_Id_Bandeja As Caso,B.Id_Caso As [Caso Claro],Min ,C.Fc_Reg_Ges As [Fc Registro],C.Id_Usuario,C.obs As Observacion,C.Tipificacion, C.Falla_Red As Escalamiento, C.Estado FROM Bandeja_Falla_Desactivacion_D_V B INNER JOIN (SELECT Id_CRM_Falla_Desactivacion_D_V,Fk_Id_Bandeja,Fc_Reg_Ges,Id_Usuario,obs,tipificacion,Falla_Red,'Actual' As Estado FROM datosclaro.dbo.CRM_Falla_Desactivacion_D_V UNION	SELECT Id_CRM_Falla_Desactivacion_D_V,Fk_Id_Bandeja,Fc_Reg_Ges,Id_Usuario,obs,tipificacion,Falla_Red,'Eliminado' as Estado FROM datosclaro.dbo.Historia_CRM_Desactivacion ) As C ON C.Fk_Id_Bandeja = B.Id_Bandeja_Falla_Desactivacion_D_V WHERE " & WHERE & " ORDER BY C.Id_CRM_Falla_Desactivacion_D_V DESC"
                ElseIf _Validacion = "General" Then
                    cms.CommandText = "Select B.Id_Bandeja_Falla_Desactivacion_D_V As Caso, B.Id_Caso As [Caso Claro], B.Fc_Reg As [Fecha Registro], Min, B.Nombre_Cliente As Cliente, B.Plan_Actual_AC As [Plan], B.Otro_Contacto As [Telefono Alterno], B.Observaciones, B.Estado,B.Bandeja, CPD,Estadocpd,tickler As SD, S.estado As [Estado SD],TS.tipificacion1 As [Linea Servicio],TS.tipificacion2 As Servicio,TR.tipificacion1 As Segmento, TR.tipificacion2 As [Causa Raiz], TC.tipificacion1 As [Categoria Cierre] from datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V B LEFT JOIN (	Select top 1 C.Cod_Detalle_Diagnostico_Otros,C.Id_Caso,C.idservicio,Causa_raiz,Categoria_cierre 	from datosclaro.dbo.Detalle_Diagnostico_Otros C " & CASO_CLARO & " And idservicio Is Not null And Categoria_cierre Is Not null 	order by Cod_Detalle_Diagnostico_Otros desc) C On B.Id_Bandeja_Falla_Desactivacion_D_V=C.Id_Caso LEFT JOIN datosclaro.dbo.Tipificaciones2 TS On C.Idservicio = TS.cod_tipificacion And TS.pertenece='Servicio1' LEFT JOIN datosclaro.dbo.Tipificaciones2 TR on C.Causa_raiz = TR.cod_tipificacion and TR.pertenece='Catalogo_diagnostico' LEFT JOIN datosclaro.dbo.Tipificaciones2 TC on C.Categoria_cierre = TC.cod_tipificacion and TC.pertenece = 'Categoria cierre' LEFT JOIN clarovoz.dbo.VFallared V on B.Id_Caso = V.idcaso LEFT JOIN datosclaro.dbo.ServiceDetalle S on B.Id_Caso = S.idcaso WHERE " & WHERE & " "
                End If
            ElseIf _Validacion = "General" Then
                If strltipificacion <> Nothing Then
                    WHERE = WHERE & " And B.Estado = '" & strltipificacion & "' "
                End If
                If _Bandeja <> Nothing Then
                    WHERE = WHERE & " And B.Bandeja = '" & _Bandeja & "' "
                End If
                If strlmin <> Nothing Then
                    WHERE = WHERE & " And Min = '" & strlmin & "' "
                End If
                If strlfechainicial <> Nothing And strlfechafin <> Nothing Then
                    WHERE = WHERE & " And B.Fc_Reg Between '" & strlfechainicial & "' And  '" & strlfechafin & "' "
                End If
                cms.CommandText = "Select B.Id_Bandeja_Falla_Desactivacion_D_V As Caso, B.Id_Caso As [Caso Claro], B.Fc_Reg As [Fecha Registro], Min, B.Nombre_Cliente As Cliente, B.Plan_Actual_AC As [Plan], B.Otro_Contacto As [Telefono Alterno], B.Observaciones, B.Estado,B.Bandeja from datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V B where 1 = 1 " & WHERE & ""
            End If
            If strlcaso <> Nothing Then
                cms.Parameters.Add("@caso", SqlDbType.VarChar, 50).Value = strlcaso
            Else
                cms.Parameters.AddWithValue("@caso", DBNull.Value)
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


    Public Function Consulta_Diganostico_Carga() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select top 1 DD.idreg,DD.fcreg,DD.tecnologia,DD.CicloFactura,Marc.marca,DD.Equipo,Divp.coddpto,DD.nunicipio,DD.barrio,DD.fcultimac,DD.franjaultimac,DD.Tipo_PQR,DD.Tipo_Cliente,DD.Modalidad,DD.reclamppal,DD.tipofalla,DD.Version_S_O_Equipo,CRM.PQR,CRM.preg1,CRM.Percep_serv,crm.estado_CMC,crm.Causa_CMC from Bandeja B inner join Detalle_diagnostico DD on B.cas_id=DD.idcaso left join (Select top 1 idcrm,idcaso,preg1,Percep_serv,PQR,estado_CMC,Causa_CMC from CRMDetalle where idcaso=@strlcaso order by idcrm desc) CRM on DD.idcaso=CRM.idcaso left join (select ES.marca,Eq.Equipo from(Select top 1 idreg,Equipo from detalle_diagnostico where idcaso=@strlcaso order by idreg desc) Eq inner join EquipoStandar ES on Eq.Equipo=ES.equipo) Marc on DD.Equipo = Marc.Equipo left join (select Div.coddpto,Nun.nunicipio from(Select top 1 idreg,nunicipio from detalle_diagnostico where idcaso=@strlcaso order by idreg desc) Nun inner join Divipola Div on Nun.nunicipio=Div.coddiv) Divp on DD.nunicipio=Divp.nunicipio where B.cas_id=@strlcaso order by DD.idreg desc"
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
                If dts.Tables(0).Rows(0).Item("CicloFactura") Is System.DBNull.Value Then
                    _CicloFactura = " "
                Else
                    _CicloFactura = dts.Tables(0).Rows(0).Item("CicloFactura")
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
                If dts.Tables(0).Rows(0).Item("reclamppal") Is System.DBNull.Value Then
                    strlreclamoppal = " "
                Else
                    strlreclamoppal = dts.Tables(0).Rows(0).Item("reclamppal")
                End If
                If dts.Tables(0).Rows(0).Item("tipofalla") Is System.DBNull.Value Then
                    strltipofalla = " "
                Else
                    strltipofalla = dts.Tables(0).Rows(0).Item("tipofalla")
                End If
                If dts.Tables(0).Rows(0).Item("Version_S_O_Equipo") Is System.DBNull.Value Then
                    _Version_S_O_Equipo = ""
                Else
                    _Version_S_O_Equipo = dts.Tables(0).Rows(0).Item("Version_S_O_Equipo")
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
                If dts.Tables(0).Rows(0).Item("Percep_serv") Is System.DBNull.Value Then
                    _Percep_serv = ""
                Else
                    _Percep_serv = dts.Tables(0).Rows(0).Item("Percep_serv")
                End If
                If dts.Tables(0).Rows(0).Item("Causa_CMC") Is System.DBNull.Value Then
                    _Causa_CMC = ""
                Else
                    _Causa_CMC = dts.Tables(0).Rows(0).Item("Causa_CMC")
                End If
                If dts.Tables(0).Rows(0).Item("estado_CMC") Is System.DBNull.Value Then
                    _Linea_CMC = ""
                Else
                    _Linea_CMC = dts.Tables(0).Rows(0).Item("estado_CMC")
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

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''' VARIABLES DE MEDICION - BIENVENIDA ''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Protected _Des_Caracteristica_Plan As String
    Protected _Canal_Consulta_Control_Consumo As String
    Protected _Asesoria_Reg_Tienda_Des_App As String
    Protected _Config_Cuenta_Correo As String
    Protected _Caracte_Basica_Equipo As String
    Protected _Condiciones_Cobertura_Red As String
    Protected _Tips_Auto_Atencion As String
    Protected _Info_Roaming_Internacional As String
    Protected _Remision_Canal_Atencion As String

    Public Property Remision_Canal_Atencion As String
        Get
            Return _Remision_Canal_Atencion
        End Get
        Set(ByVal value As String)
            _Remision_Canal_Atencion = value
        End Set
    End Property
    Public Property Info_Roaming_Internacional As String
        Get
            Return _Info_Roaming_Internacional
        End Get
        Set(ByVal value As String)
            _Info_Roaming_Internacional = value
        End Set
    End Property
    Public Property Tips_Auto_Atencion As String
        Get
            Return _Tips_Auto_Atencion
        End Get
        Set(ByVal value As String)
            _Tips_Auto_Atencion = value
        End Set
    End Property
    Public Property Condiciones_Cobertura_Red As String
        Get
            Return _Condiciones_Cobertura_Red
        End Get
        Set(ByVal value As String)
            _Condiciones_Cobertura_Red = value
        End Set
    End Property
    Public Property Caracte_Basica_Equipo As String
        Get
            Return _Caracte_Basica_Equipo
        End Get
        Set(ByVal value As String)
            _Caracte_Basica_Equipo = value
        End Set
    End Property
    Public Property Config_Cuenta_Correo As String
        Get
            Return _Config_Cuenta_Correo
        End Get
        Set(ByVal value As String)
            _Config_Cuenta_Correo = value
        End Set
    End Property
    Public Property Asesoria_Reg_Tienda_Des_App As String
        Get
            Return _Asesoria_Reg_Tienda_Des_App
        End Get
        Set(ByVal value As String)
            _Asesoria_Reg_Tienda_Des_App = value
        End Set
    End Property
    Public Property Canal_Consulta_Control_Consumo As String
        Get
            Return _Canal_Consulta_Control_Consumo
        End Get
        Set(ByVal value As String)
            _Canal_Consulta_Control_Consumo = value
        End Set
    End Property
    Public Property Des_Caracteristica_Plan As String
        Get
            Return _Des_Caracteristica_Plan
        End Get
        Set(ByVal value As String)
            _Des_Caracteristica_Plan = value
        End Set
    End Property
    Public Sub Insercion_Variable_Medicion_Bienvenida()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "insert into Variable_Medicion_Bienvenida (Id_Caso,Id_Usuario,Des_Caracteristica_Plan,Canal_Consulta_Control_Consumo,Asesoria_Reg_Tienda_Des_App,Config_Cuenta_Correo,Caracte_Basica_Equipo,Condiciones_Cobertura_Red,Tips_Auto_Atencion,Info_Roaming_Internacional,Remision_Canal_Atencion) values (@strlcaso,@strlidusuario,@_Des_Caracteristica_Plan,@_Canal_Consulta_Control_Consumo,@_Asesoria_Reg_Tienda_Des_App,@_Config_Cuenta_Correo,@_Caracte_Basica_Equipo,@_Condiciones_Cobertura_Red,@_Tips_Auto_Atencion,@_Info_Roaming_Internacional,@_Remision_Canal_Atencion)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@_Des_Caracteristica_Plan", SqlDbType.VarChar, 20).Value = _Des_Caracteristica_Plan
            cms.Parameters.Add("@_Canal_Consulta_Control_Consumo", SqlDbType.VarChar, 20).Value = _Canal_Consulta_Control_Consumo
            cms.Parameters.Add("@_Asesoria_Reg_Tienda_Des_App", SqlDbType.VarChar, 20).Value = _Asesoria_Reg_Tienda_Des_App
            cms.Parameters.Add("@_Config_Cuenta_Correo", SqlDbType.VarChar, 20).Value = _Config_Cuenta_Correo
            cms.Parameters.Add("@_Caracte_Basica_Equipo", SqlDbType.VarChar, 20).Value = _Caracte_Basica_Equipo
            cms.Parameters.Add("@_Condiciones_Cobertura_Red", SqlDbType.VarChar, 20).Value = _Condiciones_Cobertura_Red
            cms.Parameters.Add("@_Tips_Auto_Atencion", SqlDbType.VarChar, 20).Value = _Tips_Auto_Atencion
            cms.Parameters.Add("@_Info_Roaming_Internacional", SqlDbType.VarChar, 20).Value = _Info_Roaming_Internacional
            cms.Parameters.Add("@_Remision_Canal_Atencion", SqlDbType.VarChar, 20).Value = _Remision_Canal_Atencion
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
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''' Modulo FallaTec '''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub Gestion_Fallatec()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Insert into Gestion_FallaTec (Fk_Id_Ctrlfallatec,Fk_Id_Caso,Id_Usuario,Obs,Estado) values (@strlidcrm,@strlcaso,@strlidusuario,@strlobs,@Estado)"
            cms.Parameters.Add("@strlidcrm", SqlDbType.Decimal).Value = strlidcrm
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@Estado", SqlDbType.VarChar, 50).Value = strldir
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
    Public Function Consulta_Gestion_Falla_Tec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM Gestion_FallaTec where Fk_Id_Caso=@strlcaso order by Fc_Reg desc"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
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
    Public Function enprocesofallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT idusuarioasignado, COUNT(idcaso) AS casos FROM ctrlfallatec WHERE idusuarioasignado is not null and estado<>'Cerrado' and estado<>'Revisado' GROUP BY idusuarioasignado"
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
    Public Sub actualizafallatec()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE ctrlfallatec SET estado=@strldir WHERE Id_Ctrlfallatec=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlidcrm
            cms.Parameters.Add("@strldir", SqlDbType.NVarChar, 50).Value = strldir
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
    Public Function pteasignacionfallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM Ctrlfallatec WHERE idusuarioasignado is null and Estado<>'Cerrado' and estado<>'Revisado'"
            If _Validacion = "FallaTec_Estado_Ges_D" Then
                cms.CommandText = "SELECT * FROM BD_Datos_Complemento where pertenece='FallaTec_Estado_Ges_D' or pertenece='- Seleccione -' order by Nombre"
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
    Public Sub liberaasigfallatec()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE ctrlfallatec SET idusuarioasignado=null WHERE idcaso= @strlcaso"
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
    Public Function consultapteasignarfallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT top" & " " & strlcantidad & " " & " * FROM ctrlfallatec where idusuarioasignado is null and estado<>'Cerrado' and estado<>'Revisado' order by fcsap"
            cms.Parameters.Add("@strlcantidad", SqlDbType.Int).Value = strlcantidad
            If _Bandeja <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & " * FROM ctrlfallatec where idusuarioasignado is null and estado<>'Cerrado' and estado<>'Revisado' and Tipo=@_Bandeja order by fcsap"
                cms.Parameters.Add("@_Bandeja", SqlDbType.VarChar, 50).Value = _Bandeja
            End If
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & " * FROM ctrlfallatec where idusuarioasignado is null and estado<>'Cerrado' and estado<>'Revisado' and Pertenece=@strlidusuario order by fcsap"
                cms.Parameters.Add("@strlidusuario", SqlDbType.NVarChar, 50).Value = strlidusuario
            End If
            If _Bandeja <> Nothing And strlidusuario <> Nothing Then
                cms.CommandText = "SELECT top" & " " & strlcantidad & " " & " * FROM ctrlfallatec where idusuarioasignado is null and estado<>'Cerrado' and estado<>'Revisado' and Pertenece=@strlidusuario and Tipo=@_Bandeja order by fcsap"
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
    Public Function consultaasigxusufallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM ctrlfallatec where idusuarioasignado=@strlidusuario and estado<>'Cerrado' and estado<>'Revisado' order by idcaso"
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
    Public Function consultaasignadofallatec() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        'Dim tmp As New Integer
        Try
            cn.Open()
            cms.CommandText = "SELECT min,idcaso,idusuarioasignado,fcasignacion,idusuarioasigna FROM ctrlfallatec where idusuarioasignado is not null"
            If strlidusuario <> Nothing Then
                cms.CommandText = "SELECT min,idcaso,idusuarioasignado,fcasignacion,idusuarioasigna FROM ctrlfallatec where idusuarioasignado=@strlidusuario"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
            End If
            If strlSuperv <> Nothing Then
                cms.CommandText = "SELECT min,idcaso,idusuarioasignado,fcasignacion,idusuarioasigna FROM ctrlfallatec where " + strlidusuario + ""
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
    Public Function Consultar_Inconsistencia() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
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
    Public Function Consulta_Diganostico_Carga_Fidelizacion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select top 1 * from Detalle_Diagnostico_Otros where Id_Caso=@strlcaso order by Cod_Detalle_Diagnostico_Otros desc"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Tipo_PQR_Adicional") Is System.DBNull.Value Then
                    _Tipo_PQR_Adicional = ""
                Else
                    _Tipo_PQR_Adicional = dts.Tables(0).Rows(0).Item("Tipo_PQR_Adicional")
                End If
                If dts.Tables(0).Rows(0).Item("Intension_Des_Falla") Is System.DBNull.Value Then
                    _Intension_Des_Por_Falla = ""
                Else
                    _Intension_Des_Por_Falla = dts.Tables(0).Rows(0).Item("Intension_Des_Falla")
                End If
                If dts.Tables(0).Rows(0).Item("Tipo_Proceso_Linea") Is System.DBNull.Value Then
                    _Tipo_Proceso_Linea = ""
                Else
                    _Tipo_Proceso_Linea = dts.Tables(0).Rows(0).Item("Tipo_Proceso_Linea")
                End If
                If dts.Tables(0).Rows(0).Item("Aplica_Fidelizacion") Is System.DBNull.Value Then
                    strlaplicaajuste = ""
                Else
                    strlaplicaajuste = dts.Tables(0).Rows(0).Item("Aplica_Fidelizacion")
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
    Public Function Consulta_Diganostico_Carga_Fidelizacion_y_Dilo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select top 1 CRM.PQR,'' As barrio,CRM.Tipo_Linea As Modalidad, D.* from Detalle_Diagnostico_Otros D INNER JOIN ( SELECT top 1 * FROM CRM_Falla_Desactivacion_D_V WHERE Fk_Id_Bandeja=@strlcaso order by Id_CRM_Falla_Desactivacion_D_V DESC) CRM ON Id_Caso = CRM.Fk_Id_Bandeja where Id_Caso=@strlcaso order by Cod_Detalle_Diagnostico_Otros desc"
            If _Validacion = "DILO" Then
                cms.CommandText = "Select top 1 CRM.PQR,CRM.barrio, D.* from Detalle_Diagnostico_Otros D INNER JOIN ( SELECT top 1 * FROM CRMdilo WHERE idcasodilo=@strlcaso order by idcrmdilo DESC) CRM ON Id_Caso = CRM.idcasodilo where Id_Caso=@strlcaso order by Cod_Detalle_Diagnostico_Otros desc"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dts.Tables(0).Rows(0).Item("Tipo_PQR_Adicional") Is System.DBNull.Value Then
                    _Tipo_PQR_Adicional = ""
                Else
                    _Tipo_PQR_Adicional = dts.Tables(0).Rows(0).Item("Tipo_PQR_Adicional")
                End If
                If dts.Tables(0).Rows(0).Item("Intension_Des_Falla") Is System.DBNull.Value Then
                    _Intension_Des_Por_Falla = ""
                Else
                    _Intension_Des_Por_Falla = dts.Tables(0).Rows(0).Item("Intension_Des_Falla")
                End If
                If dts.Tables(0).Rows(0).Item("Tipo_Proceso_Linea") Is System.DBNull.Value Then
                    _Tipo_Proceso_Linea = ""
                Else
                    _Tipo_Proceso_Linea = dts.Tables(0).Rows(0).Item("Tipo_Proceso_Linea")
                End If
                If dts.Tables(0).Rows(0).Item("Aplica_Fidelizacion") Is System.DBNull.Value Then
                    strlaplicaajuste = ""
                Else
                    strlaplicaajuste = dts.Tables(0).Rows(0).Item("Aplica_Fidelizacion")
                End If
                If dts.Tables(0).Rows(0).Item("Tipo_PQR") Is System.DBNull.Value Then
                    _Tipo_PQR = ""
                Else
                    _Tipo_PQR = dts.Tables(0).Rows(0).Item("Tipo_PQR")
                End If
                If dts.Tables(0).Rows(0).Item("PQR") Is System.DBNull.Value Then
                    strlpqr = ""
                Else
                    strlpqr = dts.Tables(0).Rows(0).Item("PQR")
                End If
                If dts.Tables(0).Rows(0).Item("Modalidad") Is System.DBNull.Value Then
                    _Tipo_Cliente = ""
                Else
                    _Tipo_Cliente = dts.Tables(0).Rows(0).Item("Modalidad")
                End If
                If dts.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = ""
                Else
                    strlbarrio = dts.Tables(0).Rows(0).Item("barrio")
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


    Public Function Consultar_Estados_Escalar_Falla_Fideliza() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from bd_datos_complemento where pertenece='Escalar_Fallas_Fidelizacion'"
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
    Public Sub registrofallaservice()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "INSERT INTO ServiceDetalle(idcaso,estado,fcregserv,idusuarioescala,obsescal,tipofalla) values(@strlcaso,'Reportado',@strlfcreg,@strlidusuario,@strlobs,220)"
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
    Public Function ConsultaEscalarService() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select * from BD_Datos_Complemento where Nombre=@Nombre and Pertenece='EscalamientoDatosServices'"
            cms.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = strlnompaquete
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
    '''''' PERFILAMIENTO CASO''''''''''''
    Public Function consultaperfilamiento() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "1" Then
                If strlcaso <> Nothing Then
                    cms.CommandText = "SELECT fcprogram,fallatec,fallared,pqrcamp, estadon3, fcingn3, cas_observaciones, estado,idcrm, cas_id, fcreg, idusuario,obs, tipo_soporte, tipificacion, cas_fecha_registro, min_ac, nom_cliente, no_documento, plan_acual_ac, equipo_ac, departamento_falla, correo_electronico  FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@strlcaso ORDER BY idcrm DESC"
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
                    If dtsrecepcion.Tables(0).Rows(0).Item("no_documento") Is System.DBNull.Value Then
                        strldocumento = " "
                    Else
                        strldocumento = dtsrecepcion.Tables(0).Rows(0).Item("no_documento")
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
                    If dtsrecepcion.Tables(0).Rows(0).Item("plan_acual_ac") Is System.DBNull.Value Then
                        strlplan = " "
                    Else
                        strlplan = dtsrecepcion.Tables(0).Rows(0).Item("plan_acual_ac")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("departamento_falla") Is System.DBNull.Value Then
                        strllugar = " "
                    Else
                        strllugar = dtsrecepcion.Tables(0).Rows(0).Item("departamento_falla")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("correo_electronico") Is System.DBNull.Value Then
                        strlemail = " "
                    Else
                        strlemail = dtsrecepcion.Tables(0).Rows(0).Item("correo_electronico")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("cas_id") Is System.DBNull.Value Then
                        strlcaso = " "
                    Else
                        strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("cas_id")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("cas_observaciones") Is System.DBNull.Value Then
                        strlobsini = " "
                    Else
                        strlobsini = dtsrecepcion.Tables(0).Rows(0).Item("cas_observaciones")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                        strltipificacion = " "
                    Else
                        strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                    End If

                    If dtsrecepcion.Tables(0).Rows(0).Item("cas_fecha_registro") Is System.DBNull.Value Then
                        strlcasfcregistro = " "
                    Else
                        strlcasfcregistro = dtsrecepcion.Tables(0).Rows(0).Item("cas_fecha_registro")
                    End If
                End If
            ElseIf _Validacion = "2" Then
                If strlidusuario <> Nothing Then
                    cms.CommandText = "select * from Perfilamiento_Caso where idusuario_aut = @strlidusuario"
                    cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = Me.strlidusuario
                End If


            ElseIf _Validacion = "3" Then
                cms.CommandText = "select cas_id from bandeja  inner join Perfilamiento_Caso on cas_id= caso where cas_id=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
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

    Public Sub inserta_Perfilamiento()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert  Perfilamiento_Caso(idusuario_aut,caso,observacion) values (@strlidusuario,@strlcaso,@strlobs)"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar, 300).Value = strlobs
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

    ''''''''Asignacion casos'''''''''''
    Public Function Consulta_drlestado() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionvoz").ConnectionString)
        Dim dta As SqlClient.SqlDataAdapter
        Dim dts As New DataSet
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select * from BD_Voz_Complemento where Nombre <> 'Cerrado' and Nombre <> 'Escalado' and Pertenece='AgisnacionManual_Estado_Actual' or Nombre='- Seleccione -' order by Nombre"
            If _Validacion = "Control" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Nombre <> 'Cerrado' and Nombre <> 'Escalado' and Pertenece='AgisnacionManual_Estado_Actual' and Nombre not like 'Auto%' or Nombre='- Seleccione -' order by Nombre"
            End If
            If _Validacion = "Asignacion" Then
                cms.CommandText = "select * from BD_Voz_Complemento where (Nombre = 'Abierto' OR Nombre = 'Gestionado' OR Nombre = 'No Contactado') and Pertenece='AgisnacionManual_Estado_Actual' or Nombre='- Seleccione -' order by Nombre"
            End If
            If _Validacion = "Masiva" Then
                cms.CommandText = "select * from BD_Voz_Complemento where Nombre <> 'Cerrado' and Nombre <> 'Escalado' and Pertenece='AgisnacionManual_Estado_Actual' or Nombre='- Seleccione -'"
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



    Public Sub asignaprogramados()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            If _Validacion = "Inserta" Then
                cms.CommandText = "Update Bandeja set correo_electronico=@strlidusuario,lapso=@strlSuperv,st_bb_call=@strlfcreg where cas_id=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
                cms.Parameters.Add("@strlSuperv", SqlDbType.VarChar, 50).Value = strlSuperv
                cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            End If
            If _Validacion = "Libera" Then
                cms.CommandText = "Update Bandeja set correo_electronico=null, st_bb_call=null where cas_id=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            End If
            If _Validacion = "Autoasigna" Then
                cms.CommandText = "Update Bandeja set correo_electronico=@strlidusuario, st_bb_call=@st_bb_call where cas_id=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
                cms.Parameters.Add("@st_bb_call", SqlDbType.VarChar, 50).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
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


    Public Function AsignacionProgramados() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim concateno, esta, fechaini, fechaffin As String

        Select Case _Bandeja
            Case "Datos"
                concateno = "and Bandeja = 'datos'"
            Case "PQR"
                concateno = "and Bandeja like '%Smartphone%'"
            Case "Sin Formato"
                concateno = "and Bandeja like '%CONTROL%'"
            Case "Otros Servicios"
                concateno = "and Bandeja like 'BM%' or Bandeja like 'LDI%'"
            Case Nothing
                concateno = ""
        End Select

        Select Case strlestadoinc
            Case "CADUCADO"
                esta = " having C.fcprogram < getdate() "
            Case "VIGENTE"
                esta = " having C.fcprogram > getdate() "
            Case Nothing
                esta = ""
        End Select

        Select Case strlfcini
            Case Nothing
                fechaini = ""
            Case Is <> Nothing
                fechaini = " and cast(fcreg as date ) >=  '" & strlfcini & "'"
        End Select
        Select Case strlfcfin
            Case Nothing
                fechaffin = ""
            Case Is <> Nothing
                fechaffin = " and cast(fcreg as date ) <= '" & strlfcfin & "'"
        End Select

        Try
            cn.Open()
            cms.CommandText = "select  (C.idcaso) ,(C.idusuario),(C.fcreg),(C.fcprogram) ,SUM(cuenta) as cuenta, B.bandeja from CRMDetalle C inner join (select idcaso,COUNT(idcaso) as cuenta,max(fcprogram)as fecha, Bandeja from CRMDetalle inner join Bandeja on idcaso= cas_id where tipificacion='Programado' and fcprogram is not null and estado = 'Programado' and correo_electronico is null group by idcaso,Bandeja) B on C.idcaso=B.idcaso  and C.fcprogram=B.fecha group by C.idcaso,c.idusuario,C.fcprogram,B.Bandeja,fcreg  order by C.fcprogram"

            If strlcantidad <> Nothing Then
                cms.CommandText = "select top " & " " & strlcantidad & " " & "  (C.idcaso) ,(C.idusuario),(C.fcreg),(C.fcprogram) ,SUM(cuenta) as cuenta , B.bandeja from CRMDetalle C inner join (select idcaso,COUNT(idcaso) as cuenta,max(fcprogram)as fecha, Bandeja from CRMDetalle inner join Bandeja on idcaso= cas_id where tipificacion='Programado' and fcprogram is not null and estado = 'Programado' and correo_electronico is null " & concateno & " " & fechaini & " " & fechaffin & " group by idcaso,Bandeja) B on C.idcaso=B.idcaso  and C.fcprogram=B.fecha group by C.idcaso,c.idusuario,C.fcprogram,B.Bandeja,fcreg " & esta & " order by C.fcprogram"
            End If
            If _Validacion = "Usuario" Then
                cms.CommandText = "select correo_electronico as Ingeniero,[Vigentes],[Caducado],[Vigentes]+[Caducado] as [Total] from( select  correo_electronico,idcaso,max(CASE WHEN fcprogram > GETDATE() THEN 'Vigentes' ELSE 'Caducado' END) as estado from CRMDetalle inner join Bandeja on idcaso=cas_id where estado = 'Programado' and correo_electronico is not null  group by idcaso,correo_electronico) as source pivot(    count(idcaso)    for estado in ([Vigentes],[Caducado])) as pvt"
            End If
            If strlcaso <> "" Then
                cms.CommandText = "select  (C.idcaso) ,(C.idusuario),(C.fcreg),(C.fcprogram) ,SUM(cuenta) as cuenta , B.bandeja from CRMDetalle C inner join (select idcaso,COUNT(idcaso) as cuenta,max(fcprogram)as fecha, Bandeja from CRMDetalle inner join Bandeja on idcaso= cas_id where tipificacion='Programado' and fcprogram is not null and estado = 'Programado' and correo_electronico is null and idcaso=" & strlcaso & " group by idcaso,Bandeja) B on C.idcaso=B.idcaso  and C.fcprogram=B.fecha group by C.idcaso,c.idusuario,C.fcprogram,B.Bandeja,fcreg  order by C.fcprogram"
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

    'Consulta Fideliza
    Public Function Consulta_Campos_Fideliza() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select TOP 1 D.Id_Caso, C.equipo, E.marca, D.nunicipio, DP.coddpto " +
"from Detalle_Diagnostico_otros D " +
"INNER JOIN CRM_Falla_Desactivacion_D_V C ON D.Id_caso = C.Fk_Id_Bandeja " +
"INNER JOIN EquipoStandar E ON E.equipo = C.Equipo " +
"INNER JOIN Divipola DP ON DP.coddiv = D.nunicipio " +
"WHERE Id_Caso = @strlcaso " +
"ORDER BY D.Cod_Detalle_Diagnostico_otros DESC, C.Id_CRM_Falla_Desactivacion_D_V DESC"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then

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
                If dts.Tables(0).Rows(0).Item("nunicipio") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dts.Tables(0).Rows(0).Item("nunicipio")
                End If
                If dts.Tables(0).Rows(0).Item("coddpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dts.Tables(0).Rows(0).Item("coddpto")
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

    Public Function Consulta_Campos_Fideliza_y_Dilo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select TOP 1 D.Id_Caso, C.equipo, E.marca, D.nunicipio, DP.coddpto from Detalle_Diagnostico_otros D INNER JOIN CRM_Falla_Desactivacion_D_V C ON D.Id_caso = C.Fk_Id_Bandeja INNER JOIN EquipoStandar E On E.equipo = C.Equipo INNER JOIN Divipola DP ON DP.coddiv = D.nunicipio WHERE Id_Caso = @strlcaso ORDER BY D.Cod_Detalle_Diagnostico_otros DESC, C.Id_CRM_Falla_Desactivacion_D_V DESC"
            If _Validacion = "DILO" Then
                cms.CommandText = "Select TOP 1 D.Id_Caso, '' as equipo, '' as marca, D.nunicipio, DP.coddpto from Detalle_Diagnostico_otros D INNER JOIN CRMdilo C ON D.Id_caso = C.idcasodilo INNER JOIN Divipola DP ON DP.coddiv = D.nunicipio WHERE Id_Caso = @strlcaso ORDER BY D.Cod_Detalle_Diagnostico_otros DESC, C.idcrmdilo DESC"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count
            If strlcantidad > 0 Then
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
                If dts.Tables(0).Rows(0).Item("nunicipio") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dts.Tables(0).Rows(0).Item("nunicipio")
                End If
                If dts.Tables(0).Rows(0).Item("coddpto") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dts.Tables(0).Rows(0).Item("coddpto")
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

    Public Function Consulta_Tipo_Falla() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT id_tipificacion, tipificacion1 FROM Tipificaciones WHERE pertenece = 'TipoFalla_BoldChat' OR id_tipificacion = 1"
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

    Public Function Consulta_Correo_Bandeja() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "SELECT correo_electronico FROM Bandeja WHERE cas_id=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dts)
            If dts.Tables(0).Rows(0).Item("correo_electronico") Is System.DBNull.Value Then
                strlcantidad = ""
            Else
                strlcantidad = dts.Tables(0).Rows(0).Item("correo_electronico")
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

    Public Sub asignacionFideliza()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            If _Validacion = "Asigna" Then
                cms.CommandText = "Update Bandeja_Falla_Desactivacion_D_V set Usuario_asignado=@strlidusuario,Usuario_asigna=@strlSuperv,fc_Asignado=@strlfcreg where Id_Bandeja_Falla_Desactivacion_D_V=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
                cms.Parameters.Add("@strlSuperv", SqlDbType.VarChar, 50).Value = strlSuperv
                cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            End If
            If _Validacion = "Libera" Then
                cms.CommandText = "Update Bandeja_Falla_Desactivacion_D_V set Usuario_asignado=null,fc_Asignado=null where Id_Bandeja_Falla_Desactivacion_D_V=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            End If
            If _Validacion = "Autoasigna" Then
                cms.CommandText = "Update Bandeja_Falla_Desactivacion_D_V set Usuario_asignado=@strlidusuario,fc_Asignado=@fc_Asigna,Usuario_Asigna=NULL where Id_Bandeja_Falla_Desactivacion_D_V=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
                cms.Parameters.Add("@fc_Asigna", SqlDbType.VarChar, 50).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
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
    Public Function Consulta_Asignado_Fideliza() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Validacion = "libera" Then
                cms.CommandText = "Select usuario_asignado from Bandeja_Falla_Desactivacion_D_V where Id_Bandeja_Falla_Desactivacion_D_V = @strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                If dts.Tables(0).Rows(0).Item("usuario_asignado") Is System.DBNull.Value Then
                    strlcantidad = ""
                Else
                    strlcantidad = dts.Tables(0).Rows(0).Item("usuario_asignado")
                End If
            ElseIf _Validacion = "Asignados" Then
                cms.CommandText = "select distinct B.Id_Bandeja_Falla_Desactivacion_D_V as caso,B.Min,B.Fc_Reg as [Fecha Registro],B.Fc_Asignado as [Fecha Asignado],B.estado as Estado,max(Fc_Programado) as [Fecha programada] from Bandeja_Falla_Desactivacion_D_V B left join CRM_Falla_Desactivacion_D_V C on Id_Bandeja_Falla_Desactivacion_D_V = (Fk_Id_Bandeja ) and Estado=Tipificacion where Usuario_Asignado=@strlidusuario AND Fc_Asignado is not null and estado not like '%cerrado%' and estado not like '%solicitud%' and estado not like '%escala%'  and estado not like '%ilo%' group by B.Id_Bandeja_Falla_Desactivacion_D_V,B.Min,B.Fc_Asignado,B.Estado,B.Fc_Reg"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                strlcantidad = dts.Tables(0).Rows.Count
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

    Public Sub asignacionDilo()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            If _Validacion = "Asigna" Then
                cms.CommandText = "Update Bandeja_alt set Usuario_asignado=@strlidusuario,Usuario_asigna=@strlSuperv,fc_Asignado=@strlfcreg where idcaso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
                cms.Parameters.Add("@strlSuperv", SqlDbType.VarChar, 50).Value = strlSuperv
                cms.Parameters.Add("@strlfcreg", SqlDbType.VarChar, 50).Value = strlfcreg
            End If
            If _Validacion = "Libera" Then
                cms.CommandText = "Update Bandeja_alt set Usuario_asignado=null,fc_Asignado=null where idcaso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            End If
            If _Validacion = "Autoasigna" Then
                cms.CommandText = "Update Bandeja_alt set Usuario_asignado=@strlidusuario,fc_Asignado=@fc_Asigna,Usuario_Asigna=NULL where idcaso=@strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
                cms.Parameters.Add("@fc_Asigna", SqlDbType.VarChar, 50).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
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

    Public Function Consulta_Asignado_Dilo() As DataSet
        Dim cn As New SqlClient.SqlConnection
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            If _Validacion = "libera" Then
                cms.CommandText = "Select usuario_asignado from Bandeja_alt where idcaso = @strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                If dts.Tables(0).Rows(0).Item("usuario_asignado") Is System.DBNull.Value Then
                    strlcantidad = ""
                Else
                    strlcantidad = dts.Tables(0).Rows(0).Item("usuario_asignado")
                End If
            ElseIf _Validacion = "Asignados" Then
                cms.CommandText = "select B.idcaso as caso,B.Min,B.Fc_Asignado as [Fecha Asignado],B.estado as Estado,Max(Fc_Programado) as [Fecha programada] from Bandeja_alt B left join CRMDilo C on B.Idcaso = C.idcasodilo and estado = tipificacion where Usuario_Asignado=@strlidusuario AND Fc_Asignado is not null and estado not like '%cerrado%' and estado not like '%solicitud%' and estado not like '%escala%'  and estado not like '%ilo%' group by B.Idcaso,B.Min,B.Fc_Asignado,B.Estado"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
                cms.Connection = cn
                dta = New SqlClient.SqlDataAdapter(cms)
                dta.Fill(dts)
                strlcantidad = dts.Tables(0).Rows.Count
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

    Public Function Consulta_Datos_Asignados() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If Validacion = "Datos" Then
                cms.CommandText = "select nombreu as Ingeniero,[asignado] as Pendiente,[Gestion] as [Gestiones],[Cerrado]  as [Cierres] from( Select distinct cas_id, correo_electronico,'asignado' as estado,nombreu  from Bandeja B left join CRMDetalle C on B.cas_id = C.idcaso and correo_electronico=idusuario left JOIN  usuarios  U on u.idusuario=correo_electronico where estado not like '%cerrado%' and estado not like '%escala%' and correo_electronico is not null and (lapso ='Manual' or lapso='reincide')  And Bandeja not  like '%BSCS%' group by cas_id,correo_electronico,estado,nombreu union Select distinct cas_id, correo_electronico, max(CASE  WHEN (estado like 'Cerrado' or estado like '%escala%') THEN 'Cerrado'  WHEN (estado not like '%Cerrado%' and estado not like '%escalar%') THEN 'Gestion' END ) as estado,nombreu from Bandeja B left join CRMDetalle C on B.cas_id = C.idcaso and correo_electronico=idusuario left JOIN  usuarios  U on u.idusuario=correo_electronico where ( correo_electronico is not null and (lapso ='Manual' or lapso='reincide') ) and convert(date,C.fcreg)=convert(date,GETDATE()) And Bandeja not like '%BSCS%' group by cas_id,correo_electronico,nombreu,estado having max(CASE  WHEN ( estado='Cerrado') THEN 'Cerrado'  WHEN (estado <>'Cerrado') THEN 'Gestion' END ) = 'Cerrado' or max(CASE  WHEN (estado='Cerrado') THEN 'Cerrado'  WHEN (estado <>'Cerrado') THEN 'Gestion' END ) = 'Gestion') as source pivot  (count(cas_id)for estado in ([asignado],[Gestion],[Cerrado]))as pvt  where ([asignado]) <> 0 order by Pendiente desc"
                If strlajuste = "Programados" Then
                    cms.CommandText = "select nombreu as Ingeniero,[Vigentes],[Caducado],[Vigentes]+[Caducado] as [Total] from( select  correo_electronico,idcaso,nombreu,max(CASE WHEN fcprogram > GETDATE() THEN 'Vigentes' ELSE 'Caducado' END) as estado from CRMDetalle inner join Bandeja on idcaso=cas_id left JOIN  usuarios  U on u.idusuario=correo_electronico  where estado = 'Programado' and correo_electronico is not null  And Bandeja not like '%BSCS%' group by idcaso,correo_electronico,nombreu) as source pivot(    count(idcaso)  for estado in ([Vigentes],[Caducado])) as pvt  order by Total desc"
                End If
                If strlajuste = "Seguimiento" Then
                    cms.CommandText = "select nombreu AS Ingeniero, COUNT(cas_id) as Casos from Bandeja left join usuarios  U on u.idusuario=correo_electronico where lapso = 'Segui'and estado = 'No contactado' and  correo_electronico is not null And Bandeja Not like '%BSCS%' group by nombreu"
                End If
            ElseIf Validacion = "Dilo" Then
                cms.CommandText = "select nombreu as Ingeniero,[asignado] as Pendiente ,[Gestion] as Gestiones,[Cerrado] as Cierres from( Select distinct idcaso, usuario_asignado,nombreu ,'asignado' as estado from Bandeja_alt B left join CRMdilo C on B.idcaso = C.idcasodilo and Usuario_Asignado=idusuario  left JOIN  usuarios  U on u.idusuario=Usuario_Asignado  where estado not like '%cerrado%' and estado not like '%escala%' and usuario_asignado is not null and (Usuario_Asigna = 'Manual' or Usuario_Asigna = 'reincide') group by idcaso,usuario_asignado,estado,nombreu    union     Select distinct idcaso,nombreu, usuario_asignado ,  max(CASE WHEN ( estado='Cerrado' or estado like '%escala%') THEN 'Cerrado' WHEN (estado not like '%escala%' and Estado not like '%Cerrado%') THEN 'Gestion' ELSE estado END) as estado   from Bandeja_alt B left join CRMdilo C on B.idcaso = C.idcasodilo and Usuario_Asignado=idusuario  left JOIN  usuarios  U on u.idusuario=Usuario_Asignado  where  usuario_asignado is not null and convert(date,C.fcregistro)=convert(date,GETDATE())  and (Usuario_Asigna = 'Manual' or Usuario_Asigna = 'reincide') group by idcaso,usuario_asignado,estado,nombreu Having         max(CASE WHEN (estado='Cerrado') THEN 'Cerrado' WHEN ( Estado <> 'Cerrado') THEN 'Gestion' ELSE estado END) = 'Cerrado' or         max(CASE WHEN ( estado='Cerrado') THEN 'Cerrado' WHEN (Estado <> 'Cerrado') THEN 'Gestion' ELSE estado END) = 'Gestion'        ) as source pivot (count(idcaso)for estado in ([asignado],[Gestion],[Cerrado])) as pvt where [asignado] <> 0 order by Pendiente desc"
                If strlajuste = "Programados" Then
                    cms.CommandText = "select nombreu as Ingeniero,[Vigentes],[Caducado],[Vigentes]+[Caducado] as [Total] from( select  Usuario_Asignado,idcasodilo,nombreu,max(CASE WHEN Fc_Programado > GETDATE() THEN 'Vigentes' ELSE 'Caducado' END) as estado from CRMdilo inner join Bandeja_alt on idcasodilo=idcaso left JOIN  usuarios  U on u.idusuario=Usuario_Asignado where estado = 'Programado' and Usuario_Asignado is not null  group by idcasodilo,Usuario_Asignado,nombreu) as source pivot( count(idcasodilo)  for estado in ([Vigentes],[Caducado])) as pvt  order by Total desc"
                End If
            ElseIf Validacion = "Desactivacion" Then
                cms.CommandText = "select nombreu as Ingeniero,[asignado] as Pendiente,[Gestion] as Gestiones,[Cerrado] as Cierres from( Select distinct Id_Bandeja_Falla_Desactivacion_D_V, usuario_asignado ,'asignado' as estado,nombreu from Bandeja_Falla_Desactivacion_D_V B left join CRM_Falla_Desactivacion_D_V C on Id_Bandeja_Falla_Desactivacion_D_V=Fk_Id_Bandeja and Usuario_Asignado=Id_Usuario  left JOIN  usuarios  U on u.idusuario=Usuario_Asignado where estado not like '%cerrado%' and estado not like '%escala%' and usuario_asignado is not null and (Usuario_Asigna = 'Manual' or Usuario_Asigna = 'reincide') group by Id_Bandeja_Falla_Desactivacion_D_V,usuario_asignado,estado,nombreu  union Select distinct Id_Bandeja_Falla_Desactivacion_D_V, usuario_asignado, nombreu, max(CASE WHEN ( estado like '%escala%' or estado='Cerrado') THEN 'Cerrado' WHEN ( estado not like '%escala%' and Estado not like '%Cerrado%') THEN 'Gestion' ELSE estado END) as estado from Bandeja_Falla_Desactivacion_D_V B left join CRM_Falla_Desactivacion_D_V C on Id_Bandeja_Falla_Desactivacion_D_V=Fk_Id_Bandeja and Usuario_Asignado=Id_Usuario   left JOIN  usuarios  U on u.idusuario=Usuario_Asignado where  usuario_asignado is not null and convert(date,C.Fc_Reg_Ges)=convert(date,GETDATE()) and (Usuario_Asigna = 'Manual' or Usuario_Asigna = 'reincide')  group by Id_Bandeja_Falla_Desactivacion_D_V,usuario_asignado,estado,nombreu Having         max(CASE WHEN (estado='Cerrado') THEN 'Cerrado' WHEN ( Estado <> 'Cerrado') THEN 'Gestion' ELSE estado END) = 'Cerrado' or            max(CASE WHEN ( estado='Cerrado') THEN 'Cerrado' WHEN (Estado <> 'Cerrado') THEN 'Gestion' ELSE estado END) = 'Gestion'    ) as source pivot (count(Id_Bandeja_Falla_Desactivacion_D_V)for estado in ([asignado],[Gestion],[Cerrado])) as pvt     where [asignado] <> 0 order by Pendiente desc"
                If strlajuste = "Programados" Then
                    cms.CommandText = "select nombreu as Ingeniero,[Vigentes],[Caducado],[Vigentes]+[Caducado] as [Total] from( select  Usuario_Asignado,Fk_Id_Bandeja,nombreu,max(CASE WHEN Fc_Programado > GETDATE() THEN 'Vigentes' ELSE 'Caducado' END) as estado  from CRM_falla_desactivacion_D_V inner join Bandeja_Falla_Desactivacion_D_V on Fk_Id_Bandeja=Id_Bandeja_Falla_Desactivacion_D_V left JOIN  usuarios  U on u.idusuario=Usuario_Asignado where estado = 'Programado' and Usuario_Asignado is not null  group by Fk_Id_Bandeja,Usuario_Asignado,nombreu) as source pivot( count(Fk_Id_Bandeja)  for estado in ([Vigentes],[Caducado])) as pvt  order by Total desc"
                End If
                If strlajuste = "Seguimiento" Then
                    cms.CommandText = "select nombreu AS Ingeniero, COUNT(Id_Bandeja_Falla_Desactivacion_D_V) as Casos from Bandeja_Falla_Desactivacion_D_V left join usuarios  U on u.idusuario=Usuario_Asignado where Usuario_Asigna = 'Segui' and estado = 'No contactado' and Usuario_Asignado is not null group by nombreu"
                End If
            ElseIf Validacion = "Inbound" Then
                cms.CommandText = "select nombreu as Ingeniero,[asignado] as Pendiente ,[Gestion] as Gestiones,[Cerrado] as Cierres from( 	Select distinct B.Id_caso, A.Usuario_Asignado,nombreu ,'asignado' as estado from Bandeja_inbound B 	left JOIN  Asignacion_Casos A on A.ID_caso = B.Id_caso	left join CRM_inbound C on B.id_caso = C.Fk_Id_caso and A.Usuario_Asignado=C.Id_usuario  	left JOIN  usuarios  U on u.idusuario=A.Usuario_Asignado  	where estado not like '%cerrado%' and estado not like '%escala%' and A.Usuario_asignado is not null and Usuario_Asigna is not null And A.Campaña = 'Inbound'	group by B.Id_caso,Usuario_Asignado,estado,nombreu    	union     	Select distinct B.Id_caso,nombreu, A.Usuario_Asignado ,  max(CASE WHEN ( estado='Cerrado' or estado like '%escala%') THEN 'Cerrado' WHEN (estado not like '%escala%' and Estado not like '%Cerrado%') THEN 'Gestion' ELSE estado END) as estado   from Bandeja_inbound B 	left JOIN  Asignacion_Casos A on A.ID_caso = B.Id_caso	left join CRM_inbound C on B.id_caso = C.Fk_Id_caso and A.Usuario_Asignado=C.Id_usuario  	left JOIN  usuarios  U on u.idusuario=A.Usuario_Asignado  	where  A.Usuario_asignado is not null and convert(date,C.Fec_registro)=convert(date,GETDATE())  and Usuario_Asigna is not null And A.Campaña = 'Inbound'	group by B.Id_caso,A.usuario_asignado,estado,nombreu Having         max(CASE WHEN (estado='Cerrado') THEN 'Cerrado' WHEN ( Estado <> 'Cerrado') THEN 'Gestion' ELSE estado END) = 'Cerrado' or         max(CASE WHEN ( estado='Cerrado') THEN 'Cerrado' WHEN (Estado <> 'Cerrado') THEN 'Gestion' ELSE estado END) = 'Gestion' ) as source pivot (count(Id_caso)for estado in ([asignado],[Gestion],[Cerrado])) as pvt where [asignado] <> 0 order by Pendiente desc"
                If strlajuste = "Programados" Then
                    cms.CommandText = "select nombreu as Ingeniero,[Vigentes],[Caducado],[Vigentes]+[Caducado] as [Total] 	from( select  Usuario_Asignado,FK_Id_caso,nombreu,max(CASE WHEN Fec_Programado > GETDATE() THEN 'Vigentes' ELSE 'Caducado' END) as estado from CRM_inbound 		left JOIN  Asignacion_Casos A on A.ID_caso = FK_Id_caso	inner join Bandeja_inbound B on FK_Id_caso=B.Id_caso 	left JOIN  usuarios  U on u.idusuario=Usuario_Asignado 	where estado = 'Programado' and Usuario_Asignado is not null  	group by FK_Id_caso,Usuario_Asignado,nombreu) as source pivot( count(FK_Id_caso)  for estado in ([Vigentes],[Caducado])) as pvt  order by Total desc"
                End If
            ElseIf Validacion = "BSCS" Then
                cms.CommandText = "select nombreu as Ingeniero,[asignado] as Pendiente,[Gestion] as [Gestiones],[Cerrado]  as [Cierres] from( Select distinct cas_id, A.Usuario_Asignado,'asignado' as estado,nombreu  from Asignacion_Casos A INNER JOIN Bandeja B ON B.cas_id = A.ID_Caso left join CRMDetalle C on B.cas_id = C.idcaso and A.Usuario_Asignado=idusuario left JOIN  usuarios  U on u.idusuario=A.Usuario_Asignado where estado not like '%cerrado%' and estado not like '%escala%' and A.Usuario_Asignado is not null and (lapso ='Manual' or lapso='reincide')  And B.Bandeja like '%BSCS%' And A.Campaña = 'BSCS' group by cas_id,A.Usuario_Asignado,estado,nombreu union Select distinct cas_id, A.Usuario_Asignado, max(CASE  WHEN (estado like 'Cerrado' or estado like '%escala%') THEN 'Cerrado'  WHEN (estado not like '%Cerrado%' and estado not like '%escalar%') THEN 'Gestion' END ) as estado,nombreu from Asignacion_Casos A INNER JOIN Bandeja B ON B.cas_id = A.ID_Caso left join CRMDetalle C on B.cas_id = C.idcaso and A.Usuario_Asignado=idusuario left JOIN  usuarios  U on u.idusuario=A.Usuario_Asignado where ( A.Usuario_Asignado is not null and (lapso ='Manual' or lapso='reincide') ) and convert(date,C.fcreg)=convert(date,GETDATE()) And B.Bandeja like '%BSCS%' And A.Campaña = 'BSCS' group by cas_id,A.Usuario_Asignado,nombreu,estado having max(CASE  WHEN ( estado='Cerrado') THEN 'Cerrado'  WHEN (estado <>'Cerrado') THEN 'Gestion' END ) = 'Cerrado' or max(CASE  WHEN (estado='Cerrado') THEN 'Cerrado'  WHEN (estado <>'Cerrado') THEN 'Gestion' END ) = 'Gestion') as source pivot  (count(cas_id)for estado in ([asignado],[Gestion],[Cerrado]))as pvt  where ([asignado]) <> 0 order by Pendiente desc"
                If strlajuste = "Programados" Then
                    cms.CommandText = "select nombreu as Ingeniero,[Vigentes],[Caducado],[Vigentes]+[Caducado] as [Total] from( select  A.Usuario_Asignado,idcaso,nombreu,max(CASE WHEN fcprogram > GETDATE() THEN 'Vigentes' ELSE 'Caducado' END) as estado from CRMDetalle inner join Bandeja B on idcaso=cas_id And B.Bandeja Like '%BSCS%'	INNER Join Asignacion_Casos A ON B.cas_id = A.ID_Caso	left JOIN  usuarios  U on u.idusuario=A.Usuario_Asignado  where estado = 'Programado' and A.Usuario_Asignado is not null And A.Campaña = 'BSCS'	group by idcaso,A.Usuario_Asignado,nombreu) as source pivot(count(idcaso)  for estado in ([Vigentes],[Caducado])) as pvt  order by Total desc"
                End If
                If strlajuste = "Seguimiento" Then
                    cms.CommandText = "select nombreu AS Ingeniero, COUNT(cas_id) as Casos from Bandeja B INNER JOIN Asignacion_Casos A ON B.cas_id = A.ID_Caso left join usuarios  U on u.idusuario=A.Usuario_Asignado where lapso = 'Segui'and estado = 'No contactado' and  A.Usuario_Asignado is not null And A.Campaña = 'BSCS' And B.Bandeja Like '%BSCS%'group by nombreu"
                End If
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

    Public Function Consulta_Datos_Sin_Asignar() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = " "
        Dim HAVING As String = " "
        Dim Top As String = " "
        Dim val As Boolean = False
        Try
            If cantidad = "0000" And caso <> Nothing Then
                Top = "TOP " & caso
            Else
                Top = ""
            End If
            If strlestadoinc <> "Programado" Then
                If Validacion = "Datos" Or Validacion = "BSCS" Then
                    If strlobs = "Man" Then
                        WHERE = WHERE & "AND Lapso = 'Manual' "
                    ElseIf strlobs = "Rein" Then
                        WHERE = WHERE & "AND Lapso = 'Reincide' "
                    ElseIf strlobs = "Segui" Then
                        WHERE = WHERE & "AND Lapso = 'Segui' "
                        strlestadoinc = "No contactado"
                    End If
                ElseIf Validacion = "Inbound" Then
                    WHERE = WHERE & ""
                Else
                    If strlobs = "Man" Then
                        WHERE = WHERE & "AND Usuario_Asigna = 'Manual' "
                    ElseIf strlobs = "Rein" Then
                        WHERE = WHERE & "AND Usuario_Asigna = 'Reincide' "
                    ElseIf strlobs = "Segui" Then
                        WHERE = WHERE & "AND Usuario_Asigna = 'Segui' "
                        strlestadoinc = "No contactado"
                    End If
                End If
            End If
            If caso <> Nothing And cantidad = "" Then
                If Validacion = "Datos" Or Validacion = "Manual" Or Validacion = "BSCS" Then
                    WHERE = WHERE & "AND cas_id = " & caso & "  "
                ElseIf Validacion = "Dilo" Then
                    WHERE = WHERE & "AND idcasodilo = " & caso & "  "
                ElseIf Validacion = "Desactivacion" Then
                    WHERE = WHERE & "AND Id_Bandeja_Falla_Desactivacion_D_V = " & caso & "  "
                ElseIf Validacion = "Inbound" Then
                    WHERE = WHERE & "AND Id_caso = " & caso & "  "
                End If
            Else
                'Filtro por Bandeja
                If _Bandeja <> Nothing Then
                    If _Bandeja = "Datos" Then
                        WHERE = WHERE & "AND Bandeja = 'Datos'  "
                    ElseIf _Bandeja = "PQR" Then
                        WHERE = WHERE & "AND Bandeja like '%Datos-Smartphone%'  "
                    ElseIf _Bandeja = "Sin Formato" Then
                        WHERE = WHERE & "AND Bandeja like '%CONTROL%'  "
                    ElseIf _Bandeja = "BSCS" Then
                        WHERE = WHERE & "AND Bandeja like '%BSCS%'  "
                    End If
                End If

                'Filtro por Estado
                If strlestadoinc <> Nothing Then
                    If strlestadoinc = "Programado" Then
                        val = True
                        If strlarchivo = "Caducado" Then
                            If Validacion = "Datos" Or Validacion = "BSCS" Then
                                HAVING = HAVING & "having C.fcprogram < getdate() "
                            ElseIf Validacion = "Inbound" Then
                                HAVING = HAVING & "having C.Fec_Programado < getdate() "
                            Else
                                HAVING = HAVING & "having C.Fc_Programado < getdate() "
                            End If
                        ElseIf strlarchivo = "Vigente" Then
                            If Validacion = "Datos" Or Validacion = "BSCS" Then
                                HAVING = HAVING & "having C.fcprogram > getdate() "
                            ElseIf Validacion = "Inbound" Then
                                HAVING = HAVING & "having C.Fec_Programado > getdate() "
                            Else
                                HAVING = HAVING & "having C.Fc_Programado > getdate() "
                            End If
                        Else
                            HAVING = HAVING & ""
                        End If
                    Else
                        val = False
                        WHERE = WHERE & "AND Estado = '" & strlestadoinc & "'  "
                    End If
                End If
                'Filtro por Fechas
                If fcini <> "" And fcfin <> "" Then
                    If val = False Then
                        If Validacion = "Datos" Or Validacion = "BSCS" Then
                            WHERE = WHERE & "AND cas_fecha_registro BETWEEN '" & fcini & "' AND '" & fcfin & "'"
                        ElseIf Validacion = "Dilo" Then
                            WHERE = WHERE & "AND fcreporte BETWEEN '" & fcini & "' AND '" & fcfin & "'"
                        ElseIf Validacion = "Desactivacion" Then
                            WHERE = WHERE & "AND Fc_Reg BETWEEN '" & fcini & "' AND '" & fcfin & "'"
                        ElseIf Validacion = "Inbound" Then
                            WHERE = WHERE & "AND Fecha_registro BETWEEN '" & fcini & "' AND '" & fcfin & "'"
                        End If
                    ElseIf val = True Then
                        If Validacion = "Datos" Or Validacion = "BSCS" Then
                            WHERE = WHERE & "AND fcreg BETWEEN '" & fcini & "' AND '" & fcfin & "'"
                        ElseIf Validacion = "Dilo" Then
                            WHERE = WHERE & "AND fcregistro BETWEEN '" & fcini & "' AND '" & fcfin & "'"
                        ElseIf Validacion = "Desactivacion" Then
                            WHERE = WHERE & "AND Fc_Reg_Ges BETWEEN '" & fcini & "' AND '" & fcfin & "'"
                        ElseIf Validacion = "Inbound" Then
                            WHERE = WHERE & "AND Fec_registro BETWEEN '" & fcini & "' AND '" & fcfin & "'"
                        End If
                    End If
                End If
            End If
            cn.Open()
            If Validacion = "Datos" Then
                If val = True Then
                    cms.CommandText = "SELECT " & Top & " (C.idcaso) As Caso ,(C.idusuario) As 'Usuario Programa',(C.fcreg) As 'Fecha Registro',(C.fcprogram) As 'Fecha Programado' ,SUM(cuenta) As 'No.Programado' , B.bandeja As 'Campaña', '' As Estado from CRMDetalle C inner join (select idcaso,COUNT(idcaso) as cuenta,max(fcprogram)as fecha, Bandeja from CRMDetalle inner join Bandeja on idcaso= cas_id where tipificacion='Programado' and fcprogram is not null and estado = 'Programado' and Bandeja not like '%BSCS%' and correo_electronico is null " & WHERE & "  group by idcaso,Bandeja) B on C.idcaso=B.idcaso  and C.fcprogram=B.fecha group by C.idcaso,c.idusuario,C.fcprogram,B.Bandeja,fcreg " & HAVING & " order by C.fcprogram "
                    _Validacion = "Programado"
                Else
                    cms.CommandText = "SELECT " & Top & " cas_id As Caso, cas_fecha_registro As 'Fecha Registro', min_ac As Min, estado As Estado, fcsap As 'Fecha sap', bandeja As Campaña FROM Bandeja B WHERE (estado = 'Abierto' OR estado = 'Gestionado' OR estado = 'Seguimiento' OR estado = 'No Contactado' OR estado= 'Programado' OR estado= 'Buzon') AND correo_electronico is null AND st_bb_call is null AND (bandeja = 'Datos' or bandeja like '%CONTROL%' or Bandeja like '%Smartphone%') " & WHERE
                End If
            ElseIf Validacion = "Dilo" Then
                If val = True Then
                    cms.CommandText = "SELECT " & Top & " (C.idcasodilo) As Caso ,(C.idusuario) As 'Usuario Programa',(C.fcregistro) As 'Fecha Registro',(C.Fc_Programado) As 'Fecha Programado' ,SUM(cuenta) As 'No.Programado' , B.mesa As 'Campaña', '' As Estado from CRMDilo C inner join (select idcasodilo,COUNT(idcasodilo) as cuenta,max(Fc_Programado)as fecha, mesa from CRMDilo inner join Bandeja_alt on idcasodilo= idcaso where tipificacion='Programado' and Fc_Programado is not null and estado = 'Programado' and Usuario_Asignado is null  " & WHERE & " group by idcasodilo,mesa) B on C.idcasodilo=B.idcasodilo  and C.Fc_Programado=B.fecha group by C.idcasodilo,c.idusuario,C.Fc_Programado,B.mesa,fcregistro " & HAVING & "  order by C.Fc_Programado "
                    _Validacion = "Programado"
                Else
                    cms.CommandText = "SELECT " & Top & " idcaso As Caso,fcreporte As 'Fecha Registro', min As Min,estado As Estado FROM Bandeja_alt where Fc_Asignado is null and Usuario_Asignado is null and (estado='Gestionado' or estado='Abierto' or estado = 'Seguimiento' or estado='No contactado' OR estado= 'Programado'  OR estado= 'Buzon') " & WHERE
                End If
            ElseIf Validacion = "Desactivacion" Then
                If val = True Then
                    cms.CommandText = "SELECT " & Top & " (C.Fk_Id_Bandeja) As Caso ,(C.Id_Usuario) As 'Usuario Programa',(C.Fc_Reg_Ges) As 'Fecha Registro',(C.Fc_Programado) As 'Fecha Programado' ,SUM(cuenta) As 'No.Programado' , B.bandeja As 'Campaña', '' As Estado from CRM_Falla_Desactivacion_D_V C inner join (select Fk_Id_Bandeja,COUNT(Fk_Id_Bandeja) as cuenta,max(Fc_Programado)as fecha, Bandeja from CRM_Falla_Desactivacion_D_V inner join Bandeja_Falla_Desactivacion_D_V on Fk_Id_Bandeja= Id_Bandeja_Falla_Desactivacion_D_V where tipificacion='Programado' and Fc_Programado is not null and estado = 'Programado' and Usuario_Asignado is null " & WHERE & "  group by Fk_Id_Bandeja,Bandeja) B on C.Fk_Id_Bandeja=B.Fk_Id_Bandeja  and C.Fc_Programado=B.fecha group by C.Fk_Id_Bandeja,c.Id_Usuario,C.Fc_Programado,B.Bandeja,Fc_Reg_Ges " & HAVING & " order by C.Fc_Programado "
                    _Validacion = "Programado"
                Else
                    cms.CommandText = "SELECT " & Top & " Id_Bandeja_Falla_Desactivacion_D_V As Caso,Fc_Reg As 'Fecha Registro',MIN As Min,Estado As Estado from Bandeja_Falla_Desactivacion_D_V where Fc_Asignado is null and Usuario_Asignado is null and (estado='Gestionado' or estado='Abierto' or estado= 'Seguimiento' or estado='No contactado' OR estado= 'Programado' OR estado= 'Buzon') " & WHERE
                End If
            ElseIf Validacion = "Inbound" Then
                If val = True Then
                    cms.CommandText = "SELECT distinct " & Top & " (C.Fk_Id_caso) As Caso ,(C.Id_usuario) As 'Usuario Programa',(C.Fec_registro) As 'Fecha Registro',(C.Fec_Programado) As 'Fecha Programado' ,SUM(cuenta) As 'No.Programado' , 'Inbound' As 'Campaña', '' As Estado from CRM_inbound C inner join (select Fk_Id_caso,COUNT(Fk_Id_caso) as cuenta,max(Fec_registro)as fecha from CRM_inbound 	inner join Bandeja_inbound B on Fk_Id_caso= Id_caso where tipificacion='Programado' and Fec_Programado is not null and estado = 'Programado' and Fk_Id_caso NOT IN (SELECT ID_Caso FROM Asignacion_Casos WHERE Usuario_Asignado IS NOT NULL AND Campaña = 'Inbound') " & WHERE & " group by Fk_Id_caso) B on C.Fk_Id_caso=B.Fk_Id_caso  and C.Fec_registro=B.fecha group by C.Fk_Id_caso,c.Id_usuario,C.Fec_Programado,Fec_registro  " & HAVING & " order by C.Fec_registro "
                    _Validacion = "Programado"
                Else
                    cms.CommandText = "SELECT " & Top & " Id_caso As Caso,Fecha_registro As 'Fecha Registro',MIN As Min,Estado As Estado from Bandeja_inbound where Id_caso NOT IN (SELECT ID_Caso FROM Asignacion_Casos WHERE Usuario_Asignado IS NOT NULL AND Campaña = 'Inbound') And (estado='Gestionado' or estado='Abierto' or estado= 'Seguimiento' or estado='No contactado' OR estado= 'Programado' OR estado= 'Buzon') " & WHERE
                End If
            ElseIf Validacion = "BSCS" Then
                If val = True Then
                    cms.CommandText = "SELECT " & Top & " (C.idcaso) As Caso ,(C.idusuario) As 'Usuario Programa',(C.fcreg) As 'Fecha Registro',(C.fcprogram) As 'Fecha Programado' ,SUM(cuenta) As 'No.Programado' , B.bandeja As 'Campaña', '' As Estado from CRMDetalle C inner join (select idcaso,COUNT(idcaso) as cuenta,max(fcprogram)as fecha, Bandeja from CRMDetalle inner join Bandeja on idcaso= cas_id LEFT join Asignacion_Casos A on A.ID_Caso= cas_id  And A.Campaña = 'BSCS' where tipificacion='Programado' and fcprogram is not null and estado = 'Programado' and Bandeja like '%BSCS%' and A.Usuario_Asignado is null " & WHERE & "  group by idcaso,Bandeja) B on C.idcaso=B.idcaso  and C.fcprogram=B.fecha group by C.idcaso,c.idusuario,C.fcprogram,B.Bandeja,fcreg " & HAVING & " order by C.fcprogram "
                    _Validacion = "Programado"
                Else
                    cms.CommandText = "SELECT " & Top & " cas_id As Caso, cas_fecha_registro As 'Fecha Registro', min_ac As Min, estado As Estado, fcsap As 'Fecha sap', bandeja As Campaña FROM Bandeja B LEFT join Asignacion_Casos A on A.ID_Caso= cas_id  And A.Campaña = 'BSCS' WHERE (estado = 'Abierto' OR estado = 'Gestionado' OR estado = 'Seguimiento' OR estado = 'No Contactado' OR estado= 'Programado' OR estado= 'Buzon') AND A.Usuario_Asignado is null AND (Bandeja like '%BSCS%') " & WHERE
                End If
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

    Public Function Consulta_Total_Sin_Asignar() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim OK As Boolean = False
        Try
            cn.Open()
            If Validacion = "Datos" Then
                cms.CommandText = "Select Cantidad As CANTIDAD ,[Reincide] As REINCIDENTE,[Manual] As [MANUAL],[Segui] As [Seguimiento],[Reincide]+[Manual]+[Segui] As TOTAL from( Select 'cantidad' as cantidad,cas_id,lapso 	from Bandeja where (estado not like '%cerrado%' and estado not like '%escala%' and estado not like '%iloc%') and correo_electronico is null and (lapso ='Manual' or lapso='reincide' or lapso='Segui') and (bandeja = 'Datos' or bandeja like '%CONTROL%' or Bandeja like '%Smartphone%')) as source pivot (count(cas_id) for lapso in ([Reincide],[Manual],[Segui]) ) as pvt  "
                If strlajuste = "Programados" Then
                    cms.CommandText = "select estado,[VIGENTE],[CADUCADO],[VIGENTE]+[CADUCADO]TOTAL from(Select distinct (cas_id),estado,case when max(fcprogram)> GETDATE() then 'VIGENTE' else 'CADUCADO' end as Esta from Bandeja inner join CRMDetalle on cas_id= idcaso and estado = tipificacion where estado = 'Programado' and fcprogram is not null and correo_electronico is null And Bandeja not Like '%BSCS%' group by cas_id,estado) as source pivot (count(cas_id) for esta in ([VIGENTE],[CADUCADO]) ) as pvt"
                    OK = True
                End If
            ElseIf Validacion = "Dilo" Then
                cms.CommandText = "SELECT COUNT(idcaso) AS MANUAL FROM Bandeja_alt where Fc_Asignado is null and Usuario_Asignado is null and (estado='Gestionado' OR estado='Seguimiento' OR estado = 'Programado' or estado='Abierto' or estado='No contactado') AND Usuario_Asigna='Manual'"
                If strlajuste = "Programados" Then
                    cms.CommandText = "select estado,[VIGENTE],[CADUCADO],[VIGENTE]+[CADUCADO]TOTAL from(Select distinct (idcaso),estado,case when max(Fc_Programado)> GETDATE() then 'VIGENTE' else 'CADUCADO' end as Esta from Bandeja_alt inner join CRMDilo on idcaso= idcasodilo and estado = tipificacion where estado = 'Programado' and Fc_Programado is not null and Usuario_Asignado is null group by idcaso,estado) as source pivot (count(idcaso) for esta in ([VIGENTE],[CADUCADO]) ) as pvt"
                    OK = True
                End If
            ElseIf Validacion = "Desactivacion" Then
                cms.CommandText = "select Cantidad as CANTIDAD ,[Reincide] as REINCIDENTE,[Manual] as [MANUAL],[Segui] as [Seguimiento],[Reincide]+[Manual]+[Segui] as TOTAL from( Select 'cantidad' as cantidad,Id_Bandeja_Falla_Desactivacion_D_V,Usuario_Asigna from Bandeja_Falla_Desactivacion_D_V where (estado not like '%cerrado%' and estado not like '%escala%' and estado not like '%iloc%') and Usuario_Asignado is null and (Usuario_Asigna ='Manual' or Usuario_Asigna='reincide' or Usuario_Asigna='segui') ) as source pivot (count(Id_Bandeja_Falla_Desactivacion_D_V) for Usuario_Asigna in ([Reincide],[Manual],[Segui]) ) as pvt  "
                If strlajuste = "Programados" Then
                    cms.CommandText = "select estado,[VIGENTE],[CADUCADO],[VIGENTE]+[CADUCADO]TOTAL from(Select distinct (Id_Bandeja_Falla_Desactivacion_D_V),estado,case when max(Fc_Programado)> GETDATE() then 'VIGENTE' else 'CADUCADO' end as Esta from Bandeja_Falla_Desactivacion_D_V inner join CRM_Falla_Desactivacion_D_V on Id_Bandeja_Falla_Desactivacion_D_V= Fk_Id_Bandeja and estado = tipificacion where estado = 'Programado' and Fc_Programado is not null and Usuario_Asignado is null group by Id_Bandeja_Falla_Desactivacion_D_V,estado) as source pivot (count(Id_Bandeja_Falla_Desactivacion_D_V) for esta in ([VIGENTE],[CADUCADO]) ) as pvt"
                    OK = True
                End If
            ElseIf Validacion = "Inbound" Then
                cms.CommandText = "SELECT COUNT(B.Id_caso) AS MANUAL FROM Bandeja_inbound B Left Join Asignacion_Casos A On A.ID_Caso = B.Id_caso where  (estado='Gestionado' OR estado='Seguimiento' OR estado = 'Programado' or estado='Abierto' or estado='No contactado') And B.Id_caso NOT IN (SELECT ID_Caso FROM Asignacion_Casos WHERE Usuario_Asignado is not null And Campaña = 'Inbound')"
                If strlajuste = "Programados" Then
                    cms.CommandText = "SELECT estado,[VIGENTE],[CADUCADO],[VIGENTE]+[CADUCADO]TOTAL from(	Select distinct (B.Id_caso),estado,case when max(Fec_programado)> GETDATE() then 'VIGENTE' else 'CADUCADO' end as Esta from Bandeja_inbound B inner join CRM_inbound C on C.Fk_Id_caso= B.Id_caso and estado = tipificacion 	where estado = 'Programado' and Fec_Programado is not null and B.Id_caso NOT IN(SELECT ID_Caso FROM Asignacion_Casos WHERE Usuario_Asignado is not null And Campaña = 'Inbound') group by B.Id_caso,estado) as source pivot (count(Id_caso) for esta in ([VIGENTE],[CADUCADO]) ) as pvt"
                    OK = True
                End If
            ElseIf Validacion = "BSCS" Then
                cms.CommandText = "Select Cantidad As CANTIDAD ,[Reincide] As REINCIDENTE,[Manual] As [MANUAL],[Segui] As [Seguimiento],[Reincide]+[Manual]+[Segui] As TOTAL from( Select 'cantidad' as cantidad,cas_id,lapso 	from Bandeja B LEFT JOIN Asignacion_Casos A ON A.ID_Caso = B.cas_id And A.Campaña = 'BSCS' where (estado not like '%cerrado%' and estado not like '%escala%' and estado not like '%iloc%') and A.Usuario_Asignado is null and (lapso ='Manual' or lapso='reincide' or lapso='Segui') and (Bandeja Like '%BSCS%')) as source pivot (count(cas_id) for lapso in ([Reincide],[Manual],[Segui]) ) as pvt  "
                If strlajuste = "Programados" Then
                    cms.CommandText = "select estado,[VIGENTE],[CADUCADO],[VIGENTE]+[CADUCADO]TOTAL from(Select distinct (cas_id),estado,case when max(fcprogram)> GETDATE() then 'VIGENTE' else 'CADUCADO' end as Esta from Bandeja B	LEFT JOIN Asignacion_Casos A ON A.ID_Caso = B.cas_id And A.Campaña = 'BSCS'	inner join CRMDetalle on cas_id= idcaso and estado = tipificacion where estado = 'Programado' and fcprogram is not null and A.Usuario_Asignado is null And B.Bandeja Like '%BSCS%' group by cas_id,estado) as source pivot (count(cas_id) for esta in ([VIGENTE],[CADUCADO]) ) as pvt"
                    OK = True
                End If
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            If OK = False Then
                If dtsrecepcion.Tables(0).Rows.Count > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("MANUAL") Is System.DBNull.Value Then
                        strlcantidad = " "
                    Else
                        strlcantidad = dtsrecepcion.Tables(0).Rows(0).Item("MANUAL")
                    End If
                    If Validacion <> "Dilo" And Validacion <> "Inbound" Then
                        If dtsrecepcion.Tables(0).Rows(0).Item("REINCIDENTE") Is System.DBNull.Value Then
                            strlmin = " "
                        Else
                            strlmin = dtsrecepcion.Tables(0).Rows(0).Item("REINCIDENTE")
                        End If
                        If dtsrecepcion.Tables(0).Rows(0).Item("Seguimiento") Is System.DBNull.Value Then
                            strlbarrio = " "
                        Else
                            strlbarrio = dtsrecepcion.Tables(0).Rows(0).Item("Seguimiento")
                        End If
                    End If

                Else
                    strlcantidad = 0
                    strlmin = 0
                    strlbarrio = 0
                End If

            End If

            If OK = True Then
                If dtsrecepcion.Tables(0).Rows.Count > 0 Then
                    If dtsrecepcion.Tables(0).Rows(0).Item("VIGENTE") Is System.DBNull.Value Then
                        strlarchivo = "0"
                    Else
                        strlarchivo = dtsrecepcion.Tables(0).Rows(0).Item("VIGENTE")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("CADUCADO") Is System.DBNull.Value Then
                        strlapn = "0"
                    Else
                        strlapn = dtsrecepcion.Tables(0).Rows(0).Item("CADUCADO")
                    End If
                    If dtsrecepcion.Tables(0).Rows(0).Item("TOTAL") Is System.DBNull.Value Then
                        strlabierto = "0"
                    Else
                        strlabierto = dtsrecepcion.Tables(0).Rows(0).Item("TOTAL")
                    End If
                Else
                    strlarchivo = 0
                    strlapn = 0
                    strlabierto = 0
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



      Public Sub Asignacion_Casos_General()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            strlfcreg = Now
            If Validacion = "Datos" Then
                cms.CommandText = "UPDATE bandeja SET correo_electronico= '" & strlidusuario & "', st_bb_call= '" & strlfcreg & "',idusuarioasigna='" & strlSuperv & "' WHERE cas_id= " & strlcaso & ""
            ElseIf Validacion = "Dilo" Then
                cms.CommandText = "UPDATE Bandeja_alt SET Usuario_Asignado = '" & strlidusuario & "', Fc_Asignado = '" & strlfcreg & "',usuario_designa='" & strlSuperv & "' WHERE idcaso = " & strlcaso & ""
            ElseIf Validacion = "Desactivacion" Then
                cms.CommandText = "UPDATE Bandeja_Falla_Desactivacion_D_V SET Usuario_Asignado = '" & strlidusuario & "', Fc_Asignado = '" & strlfcreg & "',usuario_designa='" & strlSuperv & "' WHERE Id_Bandeja_Falla_Desactivacion_D_V = " & strlcaso & ""
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
    Public Sub Asignacion_Casos_General_Inbound_y_BSCS()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Dim Result As Integer = 0
        Try
            cn.Open()
            strlfcreg = Now
            cms.Connection = cn
            If Validacion = "Inbound" Or Validacion = "BSCS" Then
                cms.CommandText = "UPDATE Asignacion_Casos SET Usuario_Asignado = '" & strlidusuario & "', Fc_Asignacion = '" & strlfcreg & "',Usuario_Asigna='" & strlSuperv & "' WHERE ID_Caso = " & strlcaso & " And Campaña = '" & _Validacion & "'"
                Result = cms.ExecuteNonQuery()
                If Result < 1 Then
                    cms.CommandText = "INSERT INTO Asignacion_Casos(ID_Caso,Usuario_Asigna,Usuario_Asignado,Campaña) VALUES(" & strlcaso & ",'" & strlSuperv & "','" & strlidusuario & "','" & _Validacion & "')"
                    Result = cms.ExecuteNonQuery()
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
    Public Function Casos_Asginados_Inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim Cms As New SqlClient.SqlCommand
        Dim dts As New DataSet
        Dim dta As New SqlClient.SqlDataAdapter
        Try
            cn.Open()
            Cms.Connection = cn
            Cms.CommandText = "SELECT DISTINCT B.Id_caso As Caso, B.Min, B.Fecha_registro, A.FC_Asignacion As [Fecha Asignado], B.Estado, C.Fec_programado As [Fecha Programada]  FROM Asignacion_Casos A INNER JOIN Bandeja_inbound B ON B.Id_caso = A.ID_Caso LEFT JOIN CRM_inbound C ON C.Fk_Id_caso = B.Id_caso and B.Estado=C.Tipificacion WHERE (estado='Gestionado' OR estado='Seguimiento' OR estado = 'Programado' or estado='Abierto' or estado='No contactado') And A.Usuario_Asignado = @IdUsuario And A.Campaña = 'Inbound'"
            Cms.Parameters.Add("@IdUsuario", SqlDbType.VarChar, 50).Value = strlidusuarioasignado
            dta = New SqlClient.SqlDataAdapter(Cms)
            dta.Fill(dts)
            strlcantidad = dts.Tables(0).Rows.Count()
            Return dts
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function





    Public Function consultacasoBSCS() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "SELECT fcprogram,fallatec,fallared,pqrcamp, estadon3, fcingn3, cas_observaciones, estado,idcrm, cas_id, fcreg, idusuario,obs, tipo_soporte, tipificacion, cas_fecha_registro, min_ac, nom_cliente, no_documento, plan_acual_ac, equipo_ac, departamento_falla, correo_electronico,otro_telefono,preg2  FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@strlcaso and Bandeja like 'BSCS%' ORDER BY idcrm DESC"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            If strlmin <> Nothing Then
                cms.CommandText = "SELECT fcprogram,fallatec,fallared,pqrcamp, estadon3, fcingn3, cas_observaciones, estado,idcrm, cas_id, fcreg, idusuario,obs, tipo_soporte, tipificacion, cas_fecha_registro, min_ac, nom_cliente, no_documento, plan_acual_ac, equipo_ac, departamento_falla, correo_electronico,otro_telefono,preg2  FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where min_ac=@strlmin and and Bandeja like 'BSCS%' ORDER BY cas_id DESC"
                cms.Parameters.Add("@strlmin", SqlDbType.VarChar, 50).Value = Me.strlmin
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("estadon3") Is System.DBNull.Value Then
                    strlestadoinc = " "
                Else
                    strlestadoinc = dtsrecepcion.Tables(0).Rows(0).Item("estadon3")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("fcingn3") Is System.DBNull.Value Then
                    strlfcingn3 = " "
                Else
                    strlfcingn3 = dtsrecepcion.Tables(0).Rows(0).Item("fcingn3")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente") Is System.DBNull.Value Then
                    strlcliente = " "
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("nom_cliente")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("no_documento") Is System.DBNull.Value Then
                    strldocumento = " "
                Else
                    strldocumento = dtsrecepcion.Tables(0).Rows(0).Item("no_documento")
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
                If dtsrecepcion.Tables(0).Rows(0).Item("plan_acual_ac") Is System.DBNull.Value Then
                    strlplan = " "
                Else
                    strlplan = dtsrecepcion.Tables(0).Rows(0).Item("plan_acual_ac")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("departamento_falla") Is System.DBNull.Value Then
                    strllugar = " "
                Else
                    strllugar = dtsrecepcion.Tables(0).Rows(0).Item("departamento_falla")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("correo_electronico") Is System.DBNull.Value Then
                    strlemail = " "
                Else
                    strlemail = dtsrecepcion.Tables(0).Rows(0).Item("correo_electronico")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cas_id") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dtsrecepcion.Tables(0).Rows(0).Item("cas_id")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("cas_observaciones") Is System.DBNull.Value Then
                    strlobsini = " "
                Else
                    strlobsini = dtsrecepcion.Tables(0).Rows(0).Item("cas_observaciones")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dtsrecepcion.Tables(0).Rows(0).Item("estado")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("pqrcamp") Is System.DBNull.Value Then
                    strlpqr = " "
                Else
                    strlpqr = dtsrecepcion.Tables(0).Rows(0).Item("pqrcamp")
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

                If dtsrecepcion.Tables(0).Rows(0).Item("otro_telefono") Is System.DBNull.Value Then
                    strltelalt = " "
                Else
                    strltelalt = dtsrecepcion.Tables(0).Rows(0).Item("otro_telefono")
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


    Public Sub ActualizaBSCS()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            strlfcreg = Now
            cms.CommandText = "Update Bandeja set cas_estado=@strldiagservicio where cas_id=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.NVarChar, 20).Value = strlcaso
            cms.Parameters.Add("@strldiagservicio", SqlDbType.VarChar, 255).Value = strldiagservicio
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


    '/************************* PRODUCTIVIDAD *************************/
    '/****************************************************************/
    Public Function Consultar_Productividad_Hora() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = ""
        Dim WHERE1 As String = strlobs
        Dim WHERE2 As String = strlobsini
        Dim pr As String = WHERE2.Replace("Tipificacion", "Estadocpd")
        Dim Order As String = ""
        Try
            If strlidusuario <> "" Then
                WHERE = WHERE & " WHERE CODNOM = '" & strlidusuario & "' "
                Order = ""
            Else
                If strlhoraprog <> "" Then
                    WHERE = WHERE & " WHERE (SUBSTRING(Convert(varchar,convert(Time,H.Fc_Ingreso)),1,5)+ ' - ' + SUBSTRING(Convert(varchar,convert(Time,H.Fc_Salida)),1,5) ) = '" & strlhoraprog & "' "
                Else
                    WHERE = WHERE & ""
                End If
                If strlSuperv <> "" And WHERE <> "" Then
                    WHERE = WHERE & " AND H.Jefe_Inmediato = '" & strlSuperv & "' "
                ElseIf strlSuperv <> "" And WHERE = "" Then
                    WHERE = WHERE & " WHERE H.Jefe_Inmediato = '" & strlSuperv & "' "
                Else
                    WHERE = WHERE & ""
                End If
                If strlCampanaLogin <> "" And WHERE <> "" Then
                    WHERE = WHERE & " AND H.Segmento = '" & strlCampanaLogin & "' "
                ElseIf strlCampanaLogin <> "" And WHERE = "" Then
                    WHERE = WHERE & " WHERE H.Segmento = '" & strlCampanaLogin & "' "
                Else
                    WHERE = WHERE & ""
                End If
                Order = " ORDER BY [TOTAL] DESC  "
            End If
            cn.Open()
            cms.CommandText = "SELECT (SUBSTRING(Convert(varchar,convert(Time,H.Fc_Ingreso)),1,5)+ ' - ' + SUBSTRING(Convert(varchar,convert(Time,H.Fc_Salida)),1,5) ) AS Horario, CODNOM As Codigo,((Pers.nombres +' ' + Pers.apellidos)) AS Nombre ,H.Jefe_Inmediato As 'Jefe', H.Segmento As Campaña ,[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],  sum([6]+[7]+[8]+[9]+[10]+[11]+[12]+[13]+[14]+[15]+[16]+[17]+[18]+[19]+[20]+[21]) As [TOTAL],[30] as [NO EFECTIVOS]  " &
                "FROM ( " &
                "/*Datos*/ " &
                "SELECT Convert(varchar,CRM.idcaso) As Caso, U.codnom, DATEPART(HOUR,CRM.fcreg ) as Hora   " &
                "FROM CRMDetalle CRM INNER JOIN usuarios U ON CRM.idusuario = U.idusuario inner join Bandeja B on cas_id = idcaso  " &
                "WHERE CRM.fcreg BETWEEN @_Fecha_ini AND @_Fecha_fin    " & WHERE1 & "  " &
                "GROUP BY idcaso, codnom,DATEPART(HOUR,CRM.fcreg )     " &
                "UNION   " &
                "/*Dilo*/    " &
                "SELECT Convert(varchar,CRM.idcasodilo) As Caso, U.codnom, DATEPART(HOUR,CRM.fcregistro ) As Hora   " &
                "FROM CRMdilo CRM INNER JOIN usuarios U ON CRM.idusuario = U.idusuario     " &
                "WHERE CRM.fcregistro BETWEEN @_Fecha_ini AND @_Fecha_fin    " & WHERE1 & "  " &
                "GROUP BY idcasodilo, codnom,DATEPART(HOUR,CRM.fcregistro )     " &
                "UNION      " &
                "/*Desactivacion*/ " &
                "SELECT Convert(varchar,B.Id_Caso) As Caso, U.codnom , DATEPART(HOUR,CRM.fc_reg_ges ) as Hora     " &
                "FROM Bandeja_Falla_Desactivacion_D_V B  " &
                "INNER JOIN CRM_Falla_Desactivacion_D_V CRM  ON B.Id_Bandeja_Falla_Desactivacion_D_V = CRM.Fk_Id_Bandeja   " &
                "INNER JOIN usuarios U ON CRM.Id_Usuario = U.idusuario    " &
                "WHERE CRM.fc_reg_ges BETWEEN @_Fecha_ini AND @_Fecha_fin  " & WHERE1 & "  " &
                "GROUP BY Id_Caso, codnom,DATEPART(HOUR,CRM.fc_reg_ges )   " &
                "UNION     " &
                "/*Inbound*/    " &
                "SELECT Convert(varchar,CRM.Fk_Id_caso) As Caso, U.codnom, DATEPART(HOUR,CRM.Fec_registro ) As Hora   " &
                "FROM CRM_inbound CRM INNER JOIN usuarios U ON CRM.Id_usuario = U.idusuario    " &
                "WHERE CRM.Fec_registro BETWEEN @_Fecha_ini AND @_Fecha_fin  " & WHERE1 & "  " &
                "GROUP BY Fk_Id_caso, codnom,DATEPART(HOUR,CRM.Fec_registro )     " &
                "UNION      " &
                "/*Configuracion*/ " &
                "SELECT Convert(varchar,CRM.Id_Bandeja) As Caso, U.codnom, DATEPART(HOUR,CRM.Fc_reg ) As Hora   " &
                "FROM usuarios U INNER JOIN clarovoz.dbo.CRM_Configuracion_Red CRM ON U.idusuario = CRM.Id_usuario     " &
                "WHERE CRM.Fc_reg BETWEEN @_Fecha_ini AND @_Fecha_fin   AND crm.resultado = 'Efectivo' " &
                "GROUP BY CRM.Id_Bandeja, U.codnom, DATEPART(HOUR,CRM.Fc_reg )         " &
                "UNION  " &
                "/*Escalamiento     */ " &
                "SELECT CRM.idcaso As Caso, U.codnom, DATEPART(HOUR,(CONVERT(DATETIME,SUBSTRING(((CRM.fcregcpd)),1,19)))) As Hora    " &
                "FROM clarovoz.dbo.VFallared CRM INNER JOIN usuarios U ON CRM.idusuriocpd = U.idusuario     " &
                "WHERE ((CRM.cpd) Is Not Null And (CRM.cpd)<>' ') AND (CONVERT(DATETIME,SUBSTRING(((CRM.fcregcpd)),1,19))) BETWEEN @_Fecha_ini AND @_Fecha_fin   " & WHERE1.Replace("Tipificacion", "Estadocpd") & "  " &
                "GROUP BY idcaso, u.codnom, DATEPART(HOUR,(CONVERT(DATETIME,SUBSTRING(((CRM.fcregcpd)),1,19))))   " &
                "UNION     " &
                "/*EscalamientoServ*/ " &
                "SELECT CRM.idcaso As Caso, U.codnom, DATEPART(HOUR,CRM.fcprocesado ) As Hora     " &
                "FROM ServiceDetalle CRM INNER JOIN usuarios U ON CRM.idusuarioserv = U.idusuario     " &
                "WHERE ((CRM.tickler) Is Not Null And (CRM.tickler)<>' ') AND CRM.fcprocesado BETWEEN @_Fecha_ini AND @_Fecha_fin " & WHERE1.Replace("Tipificacion", "Estado") & " " &
                "GROUP BY idcaso, u.codnom, DATEPART(HOUR,CRM.fcprocesado )   " &
                "UNION     " &
                "/**********NO EFECTIVOS**********/ " &
                "/********************************/ " &
                "/*Datos*/ " &
                "SELECT Convert(varchar,CRM.idcaso) As Caso, U.codnom, 30 as Hora   " &
                "FROM CRMDetalle CRM INNER JOIN usuarios U ON CRM.idusuario = U.idusuario inner join Bandeja B on cas_id = idcaso  " &
                "WHERE CRM.fcreg BETWEEN @_Fecha_ini AND @_Fecha_fin   " & WHERE2 & "  " &
                "GROUP BY idcaso, codnom     " &
                "UNION " &
                "/*Dilo   */ " &
                "SELECT Convert(varchar,CRM.idcasodilo) As Caso, U.codnom, 30 As Hora   " &
                "FROM CRMdilo CRM INNER JOIN usuarios U ON CRM.idusuario = U.idusuario     " &
                "WHERE CRM.fcregistro BETWEEN @_Fecha_ini AND @_Fecha_fin    " & WHERE2 & "  " &
                "GROUP BY idcasodilo, codnom " &
                "UNION      " &
                "/*Desactivacion*/ " &
                "SELECT Convert(varchar,B.Id_Caso) As Caso, U.codnom , 30 as Hora     " &
                "FROM Bandeja_Falla_Desactivacion_D_V B " &
                "INNER JOIN CRM_Falla_Desactivacion_D_V CRM ON B.Id_Bandeja_Falla_Desactivacion_D_V = CRM.Fk_Id_Bandeja " &
                "INNER JOIN usuarios U ON CRM.Id_Usuario = U.idusuario   " &
                "WHERE CRM.fc_reg_ges BETWEEN @_Fecha_ini AND @_Fecha_fin  " & WHERE2 & "  " &
                "GROUP BY Id_Caso, codnom " &
                "UNION     " &
                "/*INBOUND   */ " &
                "SELECT Convert(varchar,CRM.Fk_Id_caso) As Caso, U.codnom, 30 As Hora   " &
                "FROM CRM_inbound CRM INNER JOIN usuarios U ON CRM.Id_usuario = U.idusuario     " &
                "WHERE CRM.Fec_registro BETWEEN @_Fecha_ini AND @_Fecha_fin  " & WHERE2 & "  " &
                "GROUP BY Fk_Id_caso, codnom  " &
                "UNION " &
                "/*Configuracion */ " &
                "SELECT Convert(varchar,CRM.Id_Bandeja) As Caso, U.codnom, 30 As Hora   " &
                "FROM usuarios U INNER JOIN clarovoz.dbo.CRM_Configuracion_Red CRM ON U.idusuario = CRM.Id_usuario     " &
                "WHERE CRM.Fc_reg BETWEEN @_Fecha_ini AND @_Fecha_fin   AND crm.resultado = 'No Efectivo' " &
                "GROUP BY CRM.Id_Bandeja, U.codnom         " &
                "UNION  " &
                "/*Escalamiento     */ " &
                "SELECT CRM.idcaso As Caso, U.codnom, 30 As Hora    " &
                "FROM clarovoz.dbo.VFallared CRM INNER JOIN usuarios U ON CRM.idusuriocpd = U.idusuario     " &
                "WHERE ((CRM.cpd) Is Not Null And (CRM.cpd)<>' ') AND (CONVERT(DATETIME,SUBSTRING(((CRM.fcregcpd)),1,19))) BETWEEN @_Fecha_ini AND @_Fecha_fin   " & pr & "  " &
                "GROUP BY idcaso, u.codnom " &
                "UNION     " &
                "/*EscalamientoServ*/ " &
                "SELECT CRM.idcaso As Caso, U.codnom, 30 As Hora     " &
                "FROM ServiceDetalle CRM INNER JOIN usuarios U ON CRM.idusuarioserv = U.idusuario     " &
                "WHERE ((CRM.tickler) Is Not Null And (CRM.tickler)<>' ') AND CRM.fcprocesado BETWEEN @_Fecha_ini AND @_Fecha_fin " & WHERE2.Replace("Tipificacion", "Estado") & "  " &
                "GROUP BY idcaso, u.codnom " &
                ") as prueba   " &
                "PIVOT (count(Caso) FOR Hora in ([6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[30])) as pvt   " &
                "LEFT JOIN admin_cham.dbo.personal Pers ON CODNOM = Pers.codigo LEFT JOIN admin_cham.dbo.Validacion_Horario H  ON H.Cod_Agente =  codnom AND H.Tipo_Horario = 3 AND convert(DATE,convert(varchar,H.Fc_Ingreso)) = @_Fecha  " &
                "" & WHERE & "  " &
                "GROUP BY H.Fc_Ingreso,H.Fc_Salida,CODNOM,Pers.nombres , Pers.apellidos, H.Jefe_Inmediato,H.Segmento,[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[30] " &
                "" & Order & ""

            cms.Parameters.Add("@_Fecha_ini", SqlDbType.VarChar, 50).Value = strlfcini
            cms.Parameters.Add("@_Fecha_fin", SqlDbType.VarChar, 50).Value = strlfcfin
            cms.Parameters.Add("@_Fecha", SqlDbType.VarChar, 50).Value = strlfcreg
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            strlajuste = ""
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function



    Public Function Consultar_Productividad_Hora_y_Campañas() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE1 As String = strlobs
        Try
            cn.Open()
            cms.CommandText = "SELECT Hora,[DATOS],[TSF],[DILO],[INBOUND],[DESACTIVACION],[CONFIGURACION],[BSCS],[PQR], SUM([DATOS]+[TSF]+[DILO]+[INBOUND]+[DESACTIVACION]+[CONFIGURACION]+[BSCS]+[PQR]) As TOTAL  " &
                "FROM ( " &
                "SELECT Convert(varchar,CRM.idcaso) As Caso, U.codnom, CAST(DATEPART(HOUR,CRM.fcreg ) as nvarchar) as Hora, (CASE WHEN B.Bandeja like '%Control%' THEN 'TSF'  WHEN B.Bandeja = 'BSCS' THEN 'BSCS' WHEN B.Bandeja like '%smartphone%' THEN 'PQR' WHEN B.Bandeja = 'FIDELIZA' THEN 'DESACTIVACION' ELSE 'DATOS' END)  As Tipificacion " &
                "FROM CRMDetalle CRM INNER JOIN usuarios U ON CRM.idusuario = U.idusuario inner join Bandeja B on cas_id = idcaso     " &
                "WHERE CRM.fcreg BETWEEN @_Fecha_ini AND @_Fecha_fin  " & WHERE1 & "   " &
                "GROUP BY idcaso, codnom,DATEPART(HOUR,CRM.fcreg ), Bandeja         " &
                "UNION      " &
                "SELECT Convert(varchar,CRM.idcasodilo) As Caso, U.codnom, CAST(DATEPART(HOUR,CRM.fcregistro ) as nvarchar) As Hora,'DILO' As Tipificacion     " &
                "FROM CRMdilo CRM INNER JOIN usuarios U ON CRM.idusuario = U.idusuario     " &
                "WHERE CRM.fcregistro BETWEEN @_Fecha_ini AND @_Fecha_fin     " & WHERE1 & " " &
                "GROUP BY idcasodilo, codnom,DATEPART(HOUR,CRM.fcregistro )       " &
                "UNION    " &
                "SELECT Convert(varchar,B.Id_Caso) As Caso, U.codnom , CAST(DATEPART(HOUR,CRM.fc_reg_ges ) as nvarchar) As Hora, 'DESACTIVACION' As Tipificacion     " &
                "FROM Bandeja_Falla_Desactivacion_D_V B  " &
                "INNER JOIN CRM_Falla_Desactivacion_D_V CRM ON B.Id_Bandeja_Falla_Desactivacion_D_V = CRM.Fk_Id_Bandeja         " &
                "INNER JOIN usuarios U ON CRM.Id_Usuario = U.idusuario  " &
                "WHERE CRM.fc_reg_ges BETWEEN @_Fecha_ini AND @_Fecha_fin   " & WHERE1 & "    " &
                "GROUP BY Id_Caso, codnom,DATEPART(HOUR,CRM.fc_reg_ges )         " &
                "UNION           " &
                "SELECT Convert(varchar,CRM.Fk_Id_caso) As Caso, U.codnom, CAST(DATEPART(HOUR,CRM.Fec_registro ) as nvarchar) As Hora,'INBOUND' As Tipificacion   " &
                "FROM CRM_inbound CRM INNER JOIN usuarios U ON CRM.Id_usuario = U.idusuario     " &
                "WHERE CRM.Fec_registro BETWEEN @_Fecha_ini AND @_Fecha_fin  " & WHERE1 & "    " &
                "GROUP BY Fk_Id_caso, codnom,DATEPART(HOUR,CRM.Fec_registro )  " &
                "UNION " &
                "SELECT Convert(varchar,CRM.Id_Bandeja) As Caso, U.codnom, CAST(DATEPART(HOUR,CRM.Fc_reg ) as nvarchar) As Hora, 'CONFIGURACION' As Tipificacion     " &
                "FROM usuarios U INNER JOIN clarovoz.dbo.CRM_Configuracion_Red CRM ON U.idusuario = CRM.Id_usuario     " &
                "WHERE CRM.Fc_reg BETWEEN @_Fecha_ini AND @_Fecha_fin AND (Resultado = 'Efectivo')     " &
                "GROUP BY Id_Bandeja, codnom, DATEPART(HOUR,CRM.Fc_reg )        " &
                "/*UNION          " &
                "SELECT CRM.cpd As Caso, U.codnom, CAST(DATEPART(HOUR,(CONVERT(DATETIME,SUBSTRING(((CRM.fcregcpd)),1,19))) ) as nvarchar) As Hora, 'Escalamiento' As Tipificacion     " &
                "FROM clarovoz.dbo.VFallared CRM INNER JOIN usuarios U ON CRM.idusuriocpd = U.idusuario     " &
                "WHERE ((CRM.[cpd]) Is Not Null And (CRM.[cpd])<>' ') AND (CONVERT(DATETIME,SUBSTRING(((CRM.fcregcpd)),1,19))) BETWEEN @_Fecha_ini AND @_Fecha_fin      " &
                "GROUP BY cpd, codnom, CAST(DATEPART(HOUR,(CONVERT(DATETIME,SUBSTRING(((CRM.fcregcpd)),1,19))) ) as nvarchar)      " &
                "UNION       " &
                "SELECT CRM.tickler As Caso, U.codnom, CAST(DATEPART(HOUR,CRM.fcprocesado ) as nvarchar) As Hora, 'EscalamientoServ' As Tipificacion     " &
                "FROM ServiceDetalle CRM INNER JOIN usuarios U ON CRM.idusuarioserv = U.idusuario     " &
                "WHERE ((CRM.[tickler]) Is Not Null And (CRM.[tickler])<>' ') AND CRM.fcprocesado BETWEEN @_Fecha_ini AND @_Fecha_fin       " &
                "GROUP BY tickler, codnom, DATEPART(HOUR,CRM.fcprocesado )  */ " &
                ") as prueba  PIVOT (count(Caso) FOR Tipificacion in ([DATOS],[TSF],[DILO],[INBOUND],[DESACTIVACION],[CONFIGURACION],[BSCS],[PQR])) as pvt    " &
                "WHERE codnom = @_Idusuario            " &
                "GROUP BY Hora,[DATOS],[TSF],[DILO],[INBOUND],[DESACTIVACION],[CONFIGURACION],[BSCS],[PQR]    " &
                "ORDER BY hora DESC    "
            cms.Parameters.Add("@_Idusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@_Fecha_ini", SqlDbType.VarChar, 50).Value = strlfcini
            cms.Parameters.Add("@_Fecha_fin", SqlDbType.VarChar, 50).Value = strlfcfin
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            strlajuste = "Detalle"
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function



    Public Function Consultar_Jefes() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select distinct Jefe_Inmediato from personal where codigo in (select codigo from personal where estado='A') and Jefe_Inmediato <>''"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            strlajuste = ""
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Public Function Consultar_Segmentos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT DISTINCT Segmento FROM Validacion_Horario  WHERE Segmento <> ''"
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            strlajuste = ""
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Function Consulta_Control_Operacion() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim Fc_Programado, fcprogram, usuario1, usuario2, datos As String

        Try
            '------Estados-------'
            If strlestadoinc <> Nothing Then
                If Validacion = "Programado" Then
                    strlestadoinc = " and tipificacion = 'Programado' and estado = 'Programado' "
                Else
                    strlestadoinc = "and estado = '" + strlestadoinc + "'"
                End If
            Else
                strlestadoinc = " and (estado not like '%cerrado%' and estado not like '%ilo%' and estado not like '%escal%')"
            End If
            '------Programados-------'
            If strltipificacion <> Nothing Then
                If strltipificacion = "CADUCADO" Then
                    strltipificacion = "< Getdate()"
                End If
                If strltipificacion = "VIGENTE" Then
                    strltipificacion = "> Getdate()"
                End If
                Fc_Programado = " and Fc_Programado " + strltipificacion
                fcprogram = " and fcprogram " + strltipificacion
            End If

            '------Campaña--------'
            If _Bandeja <> Nothing Then
                If _Bandeja = "DATOS" Then
                    datos = " AND (Bandeja = 'DATOS' or Bandeja like 'Bold%')"
                End If
                If _Bandeja = "BSCS" Then
                    datos = " AND Bandeja like 'BSCS%'"
                End If
                If _Bandeja = "TSF" Then
                    datos = " AND (Bandeja like '%Control%' or Bandeja like '%Smart%') "
                End If
            End If
            '-------Usuario--------'
            If strlidusuario <> Nothing Then
                usuario1 = "and correo_electronico = '" + strlidusuario + "'"
                usuario2 = "and Usuario_Asignado = '" + strlidusuario + "'"
            End If
            cn.Open()
            If Validacion = "Control" Then
                cms.CommandText = "Select correo_electronico as Ingeniero,isnull([DATOS],0) as [DATOS],isnull([DESACTIVACION],0) as [DESACTIVACION],isnull([DILO],0) as [DILO],isnull([BSCS],0) as [BSCS], isnull([TSF - PQR],0)  as [TSF - PQR]," +
                            "(isnull([DATOS],0)+isnull([DESACTIVACION],0) +isnull([DILO],0) +isnull([BSCS],0)+ISNULL([TSF - PQR],0)) as TOTAL from  ( " +
                            "Select correo_electronico,COUNT(distinct cas_id) AS CASOS ,'DATOS' AS BANDEJA from Bandeja inner join  usuarios on correo_electronico = idusuario  " +
                            "where  st_bb_call is not null and  (Bandeja = 'DATOS' or Bandeja like 'Bold%') " + strlestadoinc + " " +
                            "group by correo_electronico " +
                                           "UNION " +
                            "Select Usuario_Asignado,COUNT(distinct Id_Bandeja_Falla_Desactivacion_D_V) AS CASOS ,'DESACTIVACION' AS BANDEJA from Bandeja_Falla_Desactivacion_D_V inner join  usuarios on Usuario_Asignado = idusuario  " +
                            "where  Fc_Asignado is not null  " + strlestadoinc + " " +
                            "group by Usuario_Asignado " +
                                            "UNION " +
                            "Select Usuario_Asignado,COUNT(distinct idcaso) AS CASOS ,'DILO' AS BANDEJA from Bandeja_alt inner join  usuarios on Usuario_Asignado = idusuario  " +
                            "where  Fc_Asignado is not null  " + strlestadoinc + " " +
                            "group by Usuario_Asignado " +
                                            "UNION " +
                            "Select correo_electronico,COUNT(distinct cas_id) AS CASOS ,'BSCS' AS BANDEJA from Bandeja inner join  usuarios on correo_electronico = idusuario  " +
                            "where  st_bb_call is not null  AND Bandeja like 'BSCS%' " + strlestadoinc + " " +
                            "group by correo_electronico " +
                             "UNION " +
                            "Select correo_electronico,COUNT(distinct cas_id) AS CASOS ,'TSF - PQR' AS BANDEJA from Bandeja inner join  usuarios on correo_electronico = idusuario  " +
                            "where  st_bb_call is not null  AND (Bandeja like '%Control%' or Bandeja like '%Smart%') " + strlestadoinc + " " +
                            "group by correo_electronico " +
                            ") as source pivot (sum(casos) for BANDEJA in ([DATOS],[DESACTIVACION],[DILO],[BSCS],[TSF - PQR])) As pvt order by Ingeniero  "

            End If
            If Validacion = "Programado" Then
                cms.CommandText = "Select correo_electronico as Ingeniero,isnull([DATOS],0) as [DATOS],isnull([DESACTIVACION],0) as [DESACTIVACION],isnull([DILO],0) as [DILO],isnull([BSCS],0) as [BSCS], isnull([TSF - PQR],0)  as [TSF - PQR]," +
                    "(isnull([DATOS],0)+isnull([DESACTIVACION],0) +isnull([DILO],0) +isnull([BSCS],0)+ISNULL([TSF - PQR],0)) as TOTAL from ( " +
                    "Select correo_electronico,COUNT(distinct cas_id) AS CASOS ,'DATOS' AS BANDEJA from Bandeja inner join  usuarios on correo_electronico = idusuario  " +
                    "inner join (select idcaso,MAX(fcprogram) as fcprogram,tipificacion  from CRMDetalle where tipificacion ='Programado' group by idcaso,tipificacion) B on idcaso = cas_id " +
                    "where  st_bb_call is not null  AND (Bandeja = 'DATOS' or Bandeja like 'Bold%') " & strlestadoinc & fcprogram & " " +
                    "group by correo_electronico " +
                    "UNION " +
                    "Select Usuario_Asignado,COUNT(distinct Id_Bandeja_Falla_Desactivacion_D_V) AS CASOS ,'DESACTIVACION' AS BANDEJA from Bandeja_Falla_Desactivacion_D_V inner join  usuarios on Usuario_Asignado = idusuario  " +
                    "inner join (select Fk_Id_Bandeja,MAX(Fc_Programado) as Fc_Programado, Tipificacion from CRM_Falla_Desactivacion_D_V where Tipificacion = 'Programado' group by Fk_Id_Bandeja,Tipificacion " +
                    ")B on Id_Bandeja_Falla_Desactivacion_D_V = Fk_Id_Bandeja  " +
                    "where  Fc_Asignado is not null " & strlestadoinc & Fc_Programado & "  " +
                    "group by Usuario_Asignado " +
                    "UNION " +
                    "Select Usuario_Asignado,COUNT(distinct idcaso) AS CASOS ,'DILO' AS BANDEJA from Bandeja_alt inner join  usuarios on Usuario_Asignado = idusuario  " +
                    "inner join ( " +
                    "select idcasodilo as idcasodilo,MAX(Fc_Programado)as Fc_Programado,tipificacion from CRMdilo where tipificacion='Programado' group by idcasodilo,tipificacion) C on idcaso =  idcasodilo " +
                    "where  Fc_Asignado is not null " & strlestadoinc & Fc_Programado & "  " +
                    "group by Usuario_Asignado " +
                    "UNION " +
                    "Select correo_electronico,COUNT(distinct cas_id) AS CASOS ,'BSCS' AS BANDEJA from Bandeja inner join  usuarios on correo_electronico = idusuario inner join " +
                    "(select idcaso,MAX(fcprogram) as fcprogram,tipificacion  from CRMDetalle where tipificacion ='Programado' group by idcaso,tipificacion) C on cas_id = idcaso " +
                    "where  st_bb_call is not null AND Bandeja like 'BSCS%'" & strlestadoinc & fcprogram & " " +
                    "group by correo_electronico " +
                    "UNION " +
                    "Select correo_electronico,COUNT(distinct cas_id) AS CASOS ,'TSF - PQR' AS BANDEJA from Bandeja inner join  usuarios on correo_electronico = idusuario  " +
                    "inner join (select idcaso,MAX(fcprogram) as fcprogram,tipificacion  from CRMDetalle where tipificacion ='Programado' group by idcaso,tipificacion) B on idcaso = cas_id " +
                    "where  st_bb_call is not null  AND (Bandeja like '%Control%' or Bandeja like '%Smart%') " & strlestadoinc & fcprogram & " " +
                    "group by correo_electronico " +
                    ") as source pivot (sum(casos) for BANDEJA in ([DATOS],[DESACTIVACION],[DILO],[BSCS],[TSF - PQR])) As pvt order by Ingeniero   "
            End If

            If Validacion = "Individual" Then
                If strltipificacion = Nothing Then
                    If _Bandeja = "DATOS" Or _Bandeja = "BSCS" Or _Bandeja = "TSF" Then
                        cms.CommandText = "select  cas_id as Caso,cas_fecha_registro as [Fecha Caso],idusuarioasigna as Asigna, correo_electronico as [Ingeniero Asignado],[estado_Asigna] as [Estado Inicial],st_bb_call as [Fecha Asignado],idusuario as [Ultimo usuario],Estado as [Estado Actual],(fcreg) as [Ultima Gestion],Bandeja from Bandeja LEFT join (select CA.caso,fc_asigna,estado_Asigna from Control_Asignacion CA inner join (Select caso,max(fc_asigna) as fcasig from Control_Asignacion group by caso) C on CA.caso=C.caso and Ca.fc_asigna=C.fcasig) CC on cas_id = CC.caso left join (select distinct A.idcaso,A.idusuario,A.fcreg from CRMDetalle A inner join (select idcaso,max(fcreg) as fcreg from CRMDetalle group by idcaso) B on A.idcaso = B.idcaso and A.fcreg=B.fcreg  )C on cas_id = idcaso where st_bb_call is not null  " & datos & usuario1 & strlestadoinc & " group by cas_id ,cas_fecha_registro , correo_electronico ,idusuarioasigna,estado,estado_Asigna,st_bb_call ,Bandeja, fcreg ,idusuario"
                    End If
                    If _Bandeja = "DESAC" Then
                        cms.CommandText = "select  Id_Bandeja_Falla_Desactivacion_D_V as Caso,Fc_Reg as [Fecha Caso],usuario_designa as Asigna, Usuario_Asignado as [Ingeniero Asignado],[estado_Asigna] as [Estado Inicial],Fc_Asignado as [Fecha Asignado],id_usuario as [Ultimo usuario],Estado as [Estado Actual],(Fc_Reg_Ges) as [Ultima Gestion],'DESAC' as Bandeja from Bandeja_Falla_Desactivacion_D_V LEFT join (select CA.caso,fc_asigna,estado_Asigna from Control_Asignacion CA inner join (Select caso,max(fc_asigna) as fcasig from Control_Asignacion group by caso) C on CA.caso=C.caso and Ca.fc_asigna=C.fcasig) CC on Id_Bandeja_Falla_Desactivacion_D_V = CC.caso left join (select distinct A.Fk_Id_Bandeja,A.id_usuario,A.Fc_reg_ges from CRM_Falla_Desactivacion_D_V A inner join (select Fk_Id_Bandeja,max(Fc_reg_ges) as fcreg from CRM_Falla_Desactivacion_D_V group by Fk_Id_Bandeja) B on A.Fk_Id_Bandeja = B.Fk_Id_Bandeja and A.fc_reg_ges=B.fcreg  )C on Fk_Id_Bandeja = Id_Bandeja_Falla_Desactivacion_D_V where fc_Asignado is not null  " & usuario2 & strlestadoinc
                    End If
                    If _Bandeja = "DILO" Then
                        cms.CommandText = "select  idcaso as Caso,fcreporte as [Fecha Caso],usuario_designa as Asigna, Usuario_Asignado as [Ingeniero Asignado],[estado_Asigna] as [Estado Inicial],Fc_Asignado as [Fecha Asignado],idusuario as [Ultimo usuario],Estado as [Estado Actual],(fcregistro) as [Ultima Gestion],'DILO' as Bandeja from Bandeja_alt LEFT join (select CA.caso,fc_asigna,estado_Asigna from Control_Asignacion CA inner join (Select caso,max(fc_asigna) as fcasig from Control_Asignacion group by caso) C on CA.caso=C.caso and Ca.fc_asigna=C.fcasig ) CC on idcaso = CC.caso left join (select distinct A.idcasodilo,A.idusuario,A.fcregistro from CRMDilo A inner join (select idcasodilo,max(fcregistro) as fcreg from CRMDilo group by idcasodilo)B on A.idcasodilo = B.idcasodilo and A.fcregistro=B.fcreg  )C on idcasodilo = idcaso where fc_asignado is not null " & usuario2 & strlestadoinc
                    End If
                    If _Bandeja = "TOTAL" Then
                        cms.CommandText = "select  cas_id as Caso,cas_fecha_registro as [Fecha Caso],idusuarioasigna as Asigna, correo_electronico as [Ingeniero Asignado],[estado_Asigna] as [Estado Inicial],st_bb_call as [Fecha Asignado],idusuario as [Ultimo usuario],Estado as [Estado Actual],(fcreg) as [Ultima Gestion],Bandeja from Bandeja LEFT join (select CA.caso,fc_asigna,estado_Asigna from Control_Asignacion CA inner join (Select caso,max(fc_asigna) as fcasig from Control_Asignacion group by caso) C on CA.caso=C.caso and Ca.fc_asigna=C.fcasig) CC on cas_id = CC.caso left join (select distinct A.idcaso,A.idusuario,A.fcreg from CRMDetalle A inner join (select idcaso,max(fcreg) as fcreg from CRMDetalle group by idcaso) B on A.idcaso = B.idcaso and A.fcreg=B.fcreg  )C on cas_id = idcaso where st_bb_call is not null  " & datos & usuario1 & strlestadoinc & " group by cas_id ,cas_fecha_registro , correo_electronico ,idusuarioasigna,estado,estado_Asigna,st_bb_call ,Bandeja, fcreg ,idusuario " +
                            "union " +
                            "select  Id_Bandeja_Falla_Desactivacion_D_V as Caso,Fc_Reg as [Fecha Caso],usuario_designa as Asigna, Usuario_Asignado as [Ingeniero Asignado],[estado_Asigna] as [Estado Inicial],Fc_Asignado as [Fecha Asignado],id_usuario as [Ultimo usuario],Estado as [Estado Actual],(Fc_Reg_Ges) as [Ultima Gestion],'DESAC' as Bandeja from Bandeja_Falla_Desactivacion_D_V LEFT join (select CA.caso,fc_asigna,estado_Asigna from Control_Asignacion CA inner join (Select caso,max(fc_asigna) as fcasig from Control_Asignacion group by caso) C on CA.caso=C.caso and Ca.fc_asigna=C.fcasig) CC on Id_Bandeja_Falla_Desactivacion_D_V = CC.caso left join (select distinct A.Fk_Id_Bandeja,A.id_usuario,A.Fc_reg_ges from CRM_Falla_Desactivacion_D_V A inner join (select Fk_Id_Bandeja,max(Fc_reg_ges) as fcreg from CRM_Falla_Desactivacion_D_V group by Fk_Id_Bandeja) B on A.Fk_Id_Bandeja = B.Fk_Id_Bandeja and A.fc_reg_ges=B.fcreg  )C on Fk_Id_Bandeja = Id_Bandeja_Falla_Desactivacion_D_V where fc_Asignado is not null  " & usuario2 & strlestadoinc +
                            "union " +
                            "select  idcaso as Caso,fcreporte as [Fecha Caso],usuario_designa as Asigna, Usuario_Asignado as [Ingeniero Asignado],[estado_Asigna] as [Estado Inicial],Fc_Asignado as [Fecha Asignado],idusuario as [Ultimo usuario],Estado as [Estado Actual],(fcregistro) as [Ultima Gestion],'DILO' as Bandeja from Bandeja_alt LEFT join (select CA.caso,fc_asigna,estado_Asigna from Control_Asignacion CA inner join (Select caso,max(fc_asigna) as fcasig from Control_Asignacion group by caso) C on CA.caso=C.caso and Ca.fc_asigna=C.fcasig ) CC on idcaso = CC.caso left join (select distinct A.idcasodilo,A.idusuario,A.fcregistro from CRMDilo A inner join (select idcasodilo,max(fcregistro) as fcreg from CRMDilo group by idcasodilo)B on A.idcasodilo = B.idcasodilo and A.fcregistro=B.fcreg  )C on idcasodilo = idcaso where fc_asignado is not null " & usuario2 & strlestadoinc

                    End If
                Else
                    If _Bandeja = "DATOS" Or _Bandeja = "BSCS" Or _Bandeja = "TSF" Then
                        cms.CommandText = "Select ( cas_id) AS CASOS,cas_fecha_registro ,idusuarioasigna as Asigna,correo_electronico as Ingeniero, estado,st_bb_call as [Fecha Asignado],fcprogram as [Fecha Programada],'DATOS' AS BANDEJA from Bandeja inner join  usuarios on correo_electronico = idusuario inner join (select idcaso,MAX(fcprogram) as fcprogram,tipificacion   from CRMDetalle where tipificacion ='Programado' group by idcaso,tipificacion) B on idcaso = cas_id where  st_bb_call is not null and tipificacion = 'Programado' and estado = 'Programado' " & datos & usuario1 & fcprogram
                    End If
                    If _Bandeja = "DESAC" Then
                        cms.CommandText = "Select Id_Bandeja_Falla_Desactivacion_D_V as Caso,Fc_Reg as [Fecha Caso],usuario_designa as Asigna,Usuario_Asignado  as Ingeniero ,Estado,Fc_Asignado as [Fecha Asignado],Fc_Programado as [Fecha Programada],'DESACTIVACION' as Banedja from Bandeja_Falla_Desactivacion_D_V inner join  usuarios on Usuario_Asignado = idusuario inner join (select Fk_Id_Bandeja,MAX(Fc_Programado) as Fc_Programado, Tipificacion from CRM_Falla_Desactivacion_D_V where Tipificacion = 'Programado' group by Fk_Id_Bandeja,Tipificacion)B on Id_Bandeja_Falla_Desactivacion_D_V = Fk_Id_Bandeja where  Fc_Asignado is not null and  Tipificacion='Programado' and estado = 'Programado' " & usuario2 & Fc_Programado
                    End If
                    If _Bandeja = "DILO" Then
                        cms.CommandText = "Select idcaso as Caso,fcreporte as [Fecha Caso] ,usuario_designa as Asigna,Usuario_Asignado as Ingeniero,Estado,Fc_Asignado as [Fecha Asignado],Fc_Programado as [Fecha Programada],'DILO' as Banedja from Bandeja_alt inner join  usuarios on Usuario_Asignado = idusuario inner join (select idcasodilo as idcasodilo,MAX(Fc_Programado)as Fc_Programado,tipificacion from CRMdilo where tipificacion='Programado' group by idcasodilo,tipificacion) C on idcaso =  idcasodilo where  Fc_Asignado is not null and  tipificacion = 'Programado' and estado = 'Programado' " & usuario2 & Fc_Programado
                    End If
                    If _Bandeja = "TOTAL" Then
                        cms.CommandText = "Select ( cas_id) AS CASOS,cas_fecha_registro ,idusuarioasigna as Asigna,correo_electronico as Ingeniero, estado,st_bb_call as [Fecha Asignado],fcprogram as [Fecha Programada],'DATOS' AS BANDEJA from Bandeja inner join  usuarios on correo_electronico = idusuario inner join (select idcaso,MAX(fcprogram) as fcprogram,tipificacion  from CRMDetalle where tipificacion ='Programado' group by idcaso,tipificacion) B on idcaso = cas_id where  st_bb_call is not null and tipificacion = 'Programado' and estado = 'Programado' AND (Bandeja = 'DATOS' or Bandeja like 'Bold%' or Bandeja like '%Control%' or Bandeja like '%Smart%' or Bandeja like 'BSCS%')  " & usuario1 & fcprogram &
                                "union " +
                                "Select Id_Bandeja_Falla_Desactivacion_D_V as Caso,Fc_Reg as [Fecha Caso],usuario_designa as Asigna,Usuario_Asignado  as Ingeniero ,Estado,Fc_Asignado as [Fecha Asignado],Fc_Programado as [Fecha Programada],'DESACTIVACION' as Banedja from Bandeja_Falla_Desactivacion_D_V inner join  usuarios on Usuario_Asignado = idusuario inner join (select Fk_Id_Bandeja,MAX(Fc_Programado) as Fc_Programado, Tipificacion from CRM_Falla_Desactivacion_D_V where Tipificacion = 'Programado' group by Fk_Id_Bandeja,Tipificacion)B on Id_Bandeja_Falla_Desactivacion_D_V = Fk_Id_Bandeja where  Fc_Asignado is not null and  Tipificacion='Programado' and estado = 'Programado' " & usuario2 & Fc_Programado +
                                "union  " +
                                "Select idcaso as Caso,fcreporte as [Fecha Caso] ,usuario_designa as Asigna,Usuario_Asignado as Ingeniero,Estado,Fc_Asignado as [Fecha Asignado],Fc_Programado as [Fecha Programada],'DILO' as Banedja from Bandeja_alt inner join  usuarios on Usuario_Asignado = idusuario inner join (select idcasodilo as idcasodilo,MAX(Fc_Programado)as Fc_Programado,tipificacion from CRMdilo where tipificacion='Programado' group by idcasodilo,tipificacion) C on idcaso =  idcasodilo where  Fc_Asignado is not null and  tipificacion = 'Programado' and estado = 'Programado' " & usuario2 & Fc_Programado

                    End If
                End If
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


    Public Sub Registro_Control_Asignacion()
        Dim cn As New SqlClient.SqlConnection
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            cn.Open()
            cms.CommandText = "Insert into Control_Asignacion(caso,usuario_asigna,usuario_Asignado,estado_Asigna,campaña) values(@strlcaso,@strlSuperv,@strlidusuario,@strlestadoinc,@_Bandeja)"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@strlSuperv", SqlDbType.VarChar).Value = strlSuperv
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlestadoinc", SqlDbType.VarChar).Value = strlestadoinc
            cms.Parameters.Add("@_Bandeja", SqlDbType.VarChar).Value = _Validacion
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

 Public Function Consultar_Productividad_Detalle() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE1 As String = strlobs
        Try
            cn.Open()
            cms.CommandText = "SELECT * FROM (  " &
            "SELECT entre.Caso As Caso, Hora, codnom As Agente, P.nombres + ' ' + P.apellidos As Nombre, (CASE WHEN (H.Segmento = 'Escalamiento' AND entre.Tipificacion = 'Asignado') OR (H.Segmento = 'BSCS' AND entre.Tipificacion like '%Solicitud esc%') THEN 'Escalado' ELSE entre.Tipificacion  end ) As Tipificacion, B.Bandeja As Campaña, H.Jefe_Inmediato as 'Jefe Inmediato', H.Segmento AS   Segmento  from (      " &
            "/*Datos*/      " &
            "SELECT CRM.idcaso As Caso, U.codnom, DATEPART(HOUR,CRM.fcreg ) as Hora  ,(CASE WHEN crm.Tipificacion = 'Reportado' THEN 'Escalado'  ELSE crm.Tipificacion END) As Tipificacion   " &
            "FROM CRMDetalle CRM INNER JOIN usuarios U ON CRM.idusuario = U.idusuario inner join Bandeja B on cas_id = idcaso       " &
            "WHERE CRM.fcreg BETWEEN @_Fecha_ini AND @_Fecha_fin   " & WHERE1 & "  " &
            "GROUP BY idcaso, codnom,DATEPART(HOUR,CRM.fcreg )    ,crm.Tipificacion      " &
            "UNION        " &
            "/*Dilo*/      " &
            "SELECT CRM.idcasodilo As Caso, U.codnom, DATEPART(HOUR,CRM.fcregistro ) As Hora  ,(CASE WHEN crm.Tipificacion = 'Reportado' THEN 'Escalado'  ELSE crm.Tipificacion END) As Tipificacion    " &
            "FROM CRMdilo CRM INNER JOIN usuarios U ON CRM.idusuario = U.idusuario          " &
            "WHERE CRM.fcregistro BETWEEN @_Fecha_ini AND @_Fecha_fin   " & WHERE1 & "  " &
            "GROUP BY idcasodilo, codnom,DATEPART(HOUR,CRM.fcregistro )    ,crm.Tipificacion      " &
            "UNION           " &
            "/*Desactivacion*/      " &
            "SELECT B.Id_Caso As Caso, U.codnom , DATEPART(HOUR,CRM.fc_reg_ges ) as Hora    ,(CASE WHEN crm.Tipificacion = 'Reportado' THEN 'Escalado'  ELSE crm.Tipificacion END) As Tipificacion    " &
            "FROM Bandeja_Falla_Desactivacion_D_V B INNER JOIN (CRM_Falla_Desactivacion_D_V CRM       " &
            "INNER JOIN usuarios U ON CRM.Id_Usuario = U.idusuario) ON B.Id_Bandeja_Falla_Desactivacion_D_V = CRM.Fk_Id_Bandeja          " &
            "WHERE CRM.fc_reg_ges BETWEEN @_Fecha_ini AND @_Fecha_fin   " & WHERE1 & "   " &
            "GROUP BY Id_Caso, codnom,DATEPART(HOUR,CRM.fc_reg_ges )  ,crm.Tipificacion      " &
            "UNION       " &
            "/*Inbound*/     " &
            "SELECT CRM.Fk_Id_caso As Caso, U.codnom, DATEPART(HOUR,CRM.Fec_registro ) As Hora  ,(CASE WHEN crm.Tipificacion = 'Reportado' THEN 'Escalado'  ELSE crm.Tipificacion END) As Tipificacion     " &
            "FROM CRM_inbound CRM INNER JOIN usuarios U ON CRM.Id_usuario = U.idusuario           " &
            "WHERE CRM.Fec_registro BETWEEN @_Fecha_ini AND @_Fecha_fin   AND  (crm.Tipificacion Like '%Cerrado%' OR crm.Tipificacion Like '%Solicitud esc%' OR crm.Tipificacion = 'Escalado' OR crm.Tipificacion = 'Asignado' OR crm.Tipificacion = 'Reportado' )    " &
            "GROUP BY Fk_Id_caso, codnom,DATEPART(HOUR,CRM.Fec_registro )    ,crm.Tipificacion       " &
            "UNION          " &
            "/*Configuracion*/      " &
            "SELECT CRM.Id_Bandeja As Caso, U.codnom, DATEPART(HOUR,CRM.Fc_reg ) As Hora  ,crm.Resultado  as Tipificacion    " &
            "FROM usuarios U INNER JOIN clarovoz.dbo.CRM_Configuracion_Red CRM ON U.idusuario = CRM.Id_usuario          " &
            "WHERE CRM.Fc_reg BETWEEN @_Fecha_ini AND @_Fecha_fin    AND crm.resultado = 'Efectivo'      " &
            "GROUP BY CRM.Id_Bandeja, U.codnom, DATEPART(HOUR,CRM.Fc_reg )        ,crm.Resultado      " &
            ") AS ENTRE       " &
            "LEFT JOIN (   " &
            "SELECT * from (   " &
            "SELECT convert(varchar,cas_id) as caso,  (CASE WHEN Bandeja like '%Control%' THEN 'TSF'  WHEN Bandeja = 'BSCS' THEN 'BSCS' WHEN Bandeja like '%smartphone%' THEN 'CIERRE PQR' WHEN Bandeja = 'FIDELIZA' THEN 'DESACTIVACION' ELSE 'DATOS' END)  As Bandeja from Bandeja c      " &
            "UNION       " &
            "SELECT convert(varchar,idcaso) as caso , 'DILO' as Bandeja  from Bandeja_alt      " &
            "UNION       " &
            "SELECT convert(varchar,Id_Caso ) as caso , 'DESACTIVACION' as Bandeja  from Bandeja_Falla_Desactivacion_D_V      " &
            "UNION      " &
            "SELECT convert(varchar,id_Bandeja ) as caso , 'CONFIGURACION RED' as Bandeja  from clarovoz.dbo.Bandeja_Configuracion_Red      " &
            "UNION    " &
            "SELECT Convert(varchar, Id_caso) As caso , 'INBOUND' as Bandeja  from Bandeja_inbound   " &
            ") as Bandejas   " &
            ") B  ON  B.caso = Entre.Caso  " &
            "LEFT JOIN admin_cham.dbo.personal P on ENTRE.codnom = P.codigo      " &
            "LEFT JOIN admin_cham.dbo.Validacion_Horario H  ON H.Cod_Agente =  codnom AND H.Tipo_Horario = 3 AND convert(DATE,convert(varchar,H.Fc_Ingreso)) = convert(DATE,convert(varchar,@_Fecha_ini  ))      " &
            "WHERE ENTRE.codnom = @_Idusuario  " &
            "GROUP BY   entre.Caso, Hora, codnom, P.nombres , P.apellidos , entre.Tipificacion, B.Bandeja, H.Jefe_Inmediato, H.Segmento  " &
            ") As PROD  " &
            "GROUP BY   Caso, Hora, Agente, nombre , Tipificacion, Campaña, [Jefe Inmediato], Segmento  " &
            "ORDER BY caso DESC    "
            cms.Parameters.Add("@_Idusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@_Fecha_ini", SqlDbType.VarChar, 50).Value = strlfcini
            cms.Parameters.Add("@_Fecha_fin", SqlDbType.VarChar, 50).Value = strlfcfin
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            strlajuste = "Detalle"
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function


    Public Sub registro_Control_BSCS()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "Insert into Control_BSCS (Ticket,Usuario,Fecha_Registro,Min,Contrato,Novedad,Nombre) values ((select COUNT(ticket)+1 from Control_BSCS),@strlidusuarioasignado,GETDATE(),@strlmin,@strlcaso,@_Id_Novedad,@_Novedad_CMC)"
            cms.Parameters.Add("@strlidusuarioasignado", SqlDbType.VarChar).Value = strlidusuarioasignado
            cms.Parameters.Add("@strlmin", SqlDbType.VarChar).Value = strlmin
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@_Id_Novedad", SqlDbType.VarChar).Value = _Id_Novedad
            cms.Parameters.Add("@_Novedad_CMC", SqlDbType.VarChar).Value = _Novedad_CMC
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

    Public Function Consultar_Turnos() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT Cod_BD_Datos_Complemento As Codigo, Nombre FROM BD_Datos_Complemento WHERE Pertenece = 'TURNOS_OPERACION'"
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

    Public Sub Asignacion_solicitado()
        Dim cn As New SqlClient.SqlConnection
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            cn.Open()
            If _Validacion = "Datos" Or _Validacion = "TSF - PQR" Or _Validacion = "BSCS" Then
                cms.CommandText = "UPDATE Bandeja SET lapso = CASE  WHEN tipo_clientesito = 'REINCIDENTE'  THEN 'Reincide' ELSE 'Manual'  END WHERE lapso is null and cas_id=@strlcaso"
            ElseIf _Validacion = "Dilo" Then
                cms.CommandText = "Update Bandeja_alt Set Usuario_Asigna = @strltipificacion where Usuario_Asigna Is null And idcaso=@strlcaso"
            ElseIf _Validacion = "Desactivacion" Then
                cms.CommandText = "UPDATE Bandeja_Falla_Desactivacion_D_V SET Usuario_Asigna = CASE WHEN ingremite = 'REINCIDENTE'  THEN 'Reincide'  ELSE 'Manual' END WHERE [Usuario_Asigna] is null and Id_Bandeja_Falla_Desactivacion_D_V =@strlcaso"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
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

    Public Function ConsultarEstados() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' conexion con la base
        Dim dats As New DataSet
        Dim dta As New SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = 1 Then
                cms.CommandText = "SELECT estado FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@strlcaso" ''Datos
            End If
            If _Validacion = 2 Then
                cms.CommandText = "select Estado  from Bandeja_Falla_Desactivacion_D_V B  left join CRM_Falla_Desactivacion_D_V C on B.Id_Bandeja_Falla_Desactivacion_D_V = C.Fk_Id_Bandeja  where B.Id_Bandeja_Falla_Desactivacion_D_V=@strlcaso or  Id_Caso=@strlcaso" ''Desactivación
            End If
            If _Validacion = 3 Then
                cms.CommandText = "SELECT estado FROM Bandeja_alt LEFT OUTER JOIN CRMdilo ON Bandeja_alt.idcaso = CRMdilo.idcasodilo WHERE idcaso=@strlcaso" ''Dilo
            End If
            If _Validacion = 4 Then
                cms.CommandText = "select estado FROM CRMDetalle RIGHT OUTER join Bandeja on crmdetalle.idcaso=bandeja.cas_id where cas_id=@strlcaso and Bandeja like 'BSCS%'" ''BSCS
            End If
            If _Validacion = 5 Then
                cms.CommandText = "SELECT estado FROM Bandeja_inbound LEFT OUTER JOIN CRM_inbound ON Bandeja_inbound.Id_caso = CRM_inbound.Fk_Id_caso WHERE Fk_Id_caso=@strlcaso" ''INBOUND
            End If

            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            cms.Connection = cn
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dats)
            strlcantidad = dats.Tables(0).Rows.Count
            If strlcantidad > 0 Then

                If dats.Tables(0).Rows(0).Item("estado") Is System.DBNull.Value Then
                    strltipificacion = " "
                Else
                    strltipificacion = dats.Tables(0).Rows(0).Item("estado")
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



    '--------------------------------------------INBOUND------------------------------------------------------'
    Public Function crear_caso_inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim dats As New DataSet
            Dim dta As New SqlClient.SqlDataAdapter
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO Bandeja_inbound(id_caso,Id_avaya,Estado,Nombre_cliente,Min,Min_alterno,Departamento,Municipio,Id_Usuario,Usu_reporta,Campaña,SD,caso_rechazado,Fc_caso_rechazado,Fc_ult_gestion) values(@strlcaso,@_Caso_Claro,'ABIERTO',@strlcliente,@strlmin,@_Contacto_cliente,@strldpto,@strlzona,@strlidusuario,@strlusuarioreporta,@_Bandeja,@strltickler,@_Caso_rechazado,@strlfcini3,@strlfcfin3) SELECT @@IDENTITY AS 'Identity'"
            If strlfcreg <> Nothing Then
                cms.Parameters.AddWithValue("@strlfcreg", strlfcreg)
                cms.CommandText = "INSERT INTO Bandeja_inbound(Fecha_registro, id_caso,Id_avaya,Estado,Nombre_cliente,Min,Min_alterno,Departamento,Municipio,Id_Usuario,Usu_reporta,Campaña,SD,caso_rechazado,Fc_caso_rechazado,Fc_ult_gestion) values(@strlfcreg, @strlcaso,@_Caso_Claro,'ABIERTO',@strlcliente,@strlmin,@_Contacto_cliente,@strldpto,@strlzona,@strlidusuario,@strlusuarioreporta,@_Bandeja,@strltickler,@_Caso_rechazado,@strlfcini3,@strlfcfin3) SELECT @@IDENTITY AS 'Identity'"
            End If

            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@_Caso_Claro", SqlDbType.VarChar).Value = _Caso_Claro
            cms.Parameters.Add("@strlcliente", SqlDbType.VarChar).Value = strlcliente
            cms.Parameters.Add("@strlmin", SqlDbType.VarChar).Value = strlmin
            cms.Parameters.Add("@_Contacto_cliente", SqlDbType.VarChar).Value = _Contacto_cliente
            cms.Parameters.Add("@strldpto", SqlDbType.VarChar).Value = strldpto
            cms.Parameters.Add("@strlzona", SqlDbType.VarChar, 50).Value = strlzona
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlusuarioreporta", SqlDbType.VarChar).Value = strlusuarioreporta
            cms.Parameters.Add("@_Bandeja", SqlDbType.VarChar).Value = _Bandeja
            cms.Parameters.Add("@strltickler", SqlDbType.VarChar).Value = strltickler

            If _Caso_rechazado = Nothing Then 'escalamiento
                cms.Parameters.AddWithValue("@_Caso_rechazado", DBNull.Value)
            Else
                cms.Parameters.Add("@_Caso_rechazado", SqlDbType.VarChar).Value = _Caso_rechazado
            End If
            If strlfcini3 = Nothing Then 'escalamiento
                cms.Parameters.AddWithValue("@strlfcini3", DBNull.Value)
            Else
                cms.Parameters.Add("@strlfcini3", SqlDbType.VarChar).Value = strlfcini3
            End If
            If strlfcfin3 = Nothing Then 'escalamiento
                cms.Parameters.AddWithValue("@strlfcfin3", DBNull.Value)
            Else
                cms.Parameters.Add("@strlfcfin3", SqlDbType.VarChar).Value = strlfcfin3
            End If

            cms.Connection = cn
            'cms.ExecuteNonQuery()
            dta = New SqlClient.SqlDataAdapter(cms)
            dta.Fill(dats)
            strlcantidad = dats.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dats.Tables(0).Rows(0).Item("Identity") Is System.DBNull.Value Then
                    strlcaso = " "
                Else
                    strlcaso = dats.Tables(0).Rows(0).Item("Identity")
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



    Public Function Busca_Bandeja_Inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                cms.CommandText = "Select B.*,id_crm,fk_id_caso as Caso,Fec_registro,C.id_usuario as usuario,Obs as Observacion,Tipificacion,fec_programado from Bandeja_inbound B left join CRM_inbound C on B.id_caso=C.fk_id_caso where id_caso=@strlcaso order by id_crm desc"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
            End If
            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            If strlcantidad > 0 Then
                If dtsrecepcion.Tables(0).Rows(0).Item("Id_caso") Is System.DBNull.Value Then
                    strlidcrm = " "
                Else
                    strlidcrm = dtsrecepcion.Tables(0).Rows(0).Item("Id_caso")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Id_avaya") Is System.DBNull.Value Then
                    _Caso_Claro = " "
                Else
                    _Caso_Claro = dtsrecepcion.Tables(0).Rows(0).Item("Id_avaya")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Fecha_registro") Is System.DBNull.Value Then
                    strlfcreg = " "
                Else
                    strlfcreg = dtsrecepcion.Tables(0).Rows(0).Item("Fecha_registro")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Estado") Is System.DBNull.Value Then
                    strlestadoinc = " "
                Else
                    strlestadoinc = dtsrecepcion.Tables(0).Rows(0).Item("Estado")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Nombre_cliente") Is System.DBNull.Value Then
                    strlcliente = ""
                Else
                    strlcliente = dtsrecepcion.Tables(0).Rows(0).Item("Nombre_cliente")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Min") Is System.DBNull.Value Then
                    strlmin = " "
                Else
                    strlmin = dtsrecepcion.Tables(0).Rows(0).Item("Min")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Min_alterno") Is System.DBNull.Value Then
                    _Contacto_cliente = " "
                Else
                    _Contacto_cliente = dtsrecepcion.Tables(0).Rows(0).Item("Min_alterno")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Departamento") Is System.DBNull.Value Then
                    strldpto = " "
                Else
                    strldpto = dtsrecepcion.Tables(0).Rows(0).Item("Departamento")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Municipio") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dtsrecepcion.Tables(0).Rows(0).Item("Municipio")
                End If

                If dtsrecepcion.Tables(0).Rows(0).Item("Id_Usuario") Is System.DBNull.Value Then
                    strlidusuario = " "
                Else
                    strlidusuario = dtsrecepcion.Tables(0).Rows(0).Item("Id_Usuario")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Usu_reporta") Is System.DBNull.Value Then
                    strlusuarioreporta = " "
                Else
                    strlusuarioreporta = dtsrecepcion.Tables(0).Rows(0).Item("Usu_reporta")
                End If
                If dtsrecepcion.Tables(0).Rows(0).Item("Campaña") Is System.DBNull.Value Then
                    _Bandeja = " "
                Else
                    _Bandeja = dtsrecepcion.Tables(0).Rows(0).Item("Campaña")
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


   Public Sub registro_CRM_inbound()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO CRM_inbound (Fk_Id_caso,Id_usuario,Obs,Tipificacion,Numero_alterno ,escalamiento,Fec_programado,PQR,Tecnologia,Error_registro,Municipio,Barrio,fec_ult_caida,franja_utl_caida,Id_servicio,Id_solicitud,Equipo,Tipo_PQR,Modalidad,Causa_raiz,Categoria_cierre,Inconsistencia_611,Justificacion_segui,Falla) VALUES(@strlcaso,@strlidusuario,@strlobs,@strltipificacion,@strltelalt,@strlpreg2,@strlhoraprog,@strlpqr,@strldiagtecnolog,@strldiagvariable,@strlmun,@strlbarrio,@strlfcultimac,@strlfranjaultimac,@strlidservicio,@strlsolicitud,@strlequipo,@_Tipo_PQR,@_Modalidad,@_Causa_Raiz,@_Categoria_Cierre,@_inconsistencia_encuesta,@strlpreg3,@_Tipo_Falla)"
            If strlfcreg <> Nothing Then
                cms.Parameters.AddWithValue("@strlfcreg", strlfcreg)
                cms.CommandText = "INSERT INTO CRM_inbound (Fec_registro, Fk_Id_caso,Id_usuario,Obs,Tipificacion,Numero_alterno ,escalamiento,Fec_programado,PQR,Tecnologia,Error_registro,Municipio,Barrio,fec_ult_caida,franja_utl_caida,Id_servicio,Id_solicitud,Equipo,Tipo_PQR,Modalidad,Causa_raiz,Categoria_cierre,Inconsistencia_611,Justificacion_segui,Falla) VALUES (@strlfcreg, @strlcaso,@strlidusuario,@strlobs,@strltipificacion,@strltelalt,@strlpreg2,@strlhoraprog,@strlpqr,@strldiagtecnolog,@strldiagvariable,@strlmun,@strlbarrio,@strlfcultimac,@strlfranjaultimac,@strlidservicio,@strlsolicitud,@strlequipo,@_Tipo_PQR,@_Modalidad,@_Causa_Raiz,@_Categoria_Cierre,@_inconsistencia_encuesta,@strlpreg3,@_Tipo_Falla)"
            End If

            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar).Value = strltipificacion
            cms.Parameters.Add("@strltelalt", SqlDbType.VarChar).Value = strltelalt
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar).Value = strlmun
            cms.Parameters.Add("@strlidservicio", SqlDbType.VarChar).Value = strlidservicio
            cms.Parameters.Add("@strlsolicitud", SqlDbType.VarChar).Value = strlsolicitud
            cms.Parameters.Add("@_Causa_Raiz", SqlDbType.VarChar).Value = _Causa_Raiz
            cms.Parameters.Add("@_Categoria_Cierre", SqlDbType.VarChar).Value = _Categoria_Cierre

            If strlpreg2 = Nothing Then 'escalamiento
                cms.Parameters.AddWithValue("@strlpreg2", DBNull.Value)
            Else
                cms.Parameters.Add("@strlpreg2", SqlDbType.VarChar).Value = strlpreg2
            End If
            If strlhoraprog = Nothing Then 'fc programada
                cms.Parameters.AddWithValue("@strlhoraprog", DBNull.Value)
            Else
                cms.Parameters.Add("@strlhoraprog", SqlDbType.VarChar).Value = strlhoraprog
            End If
            If strlpqr = Nothing Then 'pqr
                cms.Parameters.AddWithValue("@strlpqr", DBNull.Value)
            Else
                cms.Parameters.Add("@strlpqr", SqlDbType.VarChar).Value = strlpqr
            End If
            If strldiagtecnolog = Nothing Then 'tecnologoa-condicion de uso
                cms.Parameters.AddWithValue("@strldiagtecnolog", DBNull.Value)
            Else
                cms.Parameters.Add("@strldiagtecnolog", SqlDbType.VarChar).Value = strldiagtecnolog
            End If
            If strldiagvariable = Nothing Then 'error en registro
                cms.Parameters.AddWithValue("@strldiagvariable", DBNull.Value)
            Else
                cms.Parameters.Add("@strldiagvariable", SqlDbType.VarChar).Value = strldiagvariable
            End If
            If strlbarrio = Nothing Then 'barrio
                cms.Parameters.AddWithValue("@strlbarrio", DBNull.Value)
            Else
                cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar).Value = strlbarrio
            End If
            If strlfcultimac = Nothing Then 'fc ult caida
                cms.Parameters.AddWithValue("@strlfcultimac", DBNull.Value)
            Else
                cms.Parameters.Add("@strlfcultimac", SqlDbType.VarChar).Value = strlfcultimac
            End If
            If strlfranjaultimac = Nothing Then 'franja caida
                cms.Parameters.AddWithValue("@strlfranjaultimac", DBNull.Value)
            Else
                cms.Parameters.Add("@strlfranjaultimac", SqlDbType.VarChar).Value = strlfranjaultimac
            End If
            If strlequipo = Nothing Then 'equipo
                cms.Parameters.AddWithValue("@strlequipo", DBNull.Value)
            Else
                cms.Parameters.Add("@strlequipo", SqlDbType.VarChar).Value = strlequipo
            End If

            If _Tipo_PQR = Nothing Then 'tipo PQR
                cms.Parameters.AddWithValue("@_Tipo_PQR", DBNull.Value)
            Else
                cms.Parameters.Add("@_Tipo_PQR", SqlDbType.VarChar).Value = _Tipo_PQR
            End If
            If _Modalidad = Nothing Then 'Modalidad
                cms.Parameters.AddWithValue("@_Modalidad", DBNull.Value)
            Else
                cms.Parameters.Add("@_Modalidad", SqlDbType.VarChar).Value = _Modalidad
            End If
            If _inconsistencia_encuesta = Nothing Then 'tipo PQR
                cms.Parameters.AddWithValue("@_inconsistencia_encuesta", DBNull.Value)
            Else
                cms.Parameters.Add("@_inconsistencia_encuesta", SqlDbType.VarChar).Value = _inconsistencia_encuesta
            End If
            If strlpreg3 = Nothing Then 'justificacion seguimiento
                cms.Parameters.AddWithValue("@strlpreg3", DBNull.Value)
            Else
                cms.Parameters.Add("@strlpreg3", SqlDbType.VarChar).Value = strlpreg3
            End If
            If _Tipo_Falla = Nothing Then 'Tipo_falla
                cms.Parameters.AddWithValue("@_Tipo_Falla", DBNull.Value)
            Else
                cms.Parameters.Add("@_Tipo_Falla", SqlDbType.VarChar).Value = _Tipo_Falla
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
    Public Function Busca_escalamiento_inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "informatica" Then
                cms.CommandText = "Select idcaso from datosclaro.dbo.ServiceDetalle where idcaso=@strlcaso"
            End If
            If _Validacion = "tecnica" Then
                cms.CommandText = "Select idcaso from clarovoz.dbo.VFallared where idcaso=@strlcaso"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = Me.strlcaso
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




    Public Sub actualiozar_Bandeja_inbound()
        Dim cn As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            cn = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            cn.Open()
            cms.CommandText = "UPDATE bandeja_inbound SET estado= @strltipificacion WHERE id_caso= @strlcaso "
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

    Public Sub Registroservice_inbound()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Try
            Dim fecha As New DateTime
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            If strlfcreg = Nothing Then
                strlfcreg = Now
            End If

            cms.CommandText = "INSERT INTO ServiceDetalle(idcaso,estado,obsescal,fcregserv,tipofalla,apn,qos,fcactivacion,idusuarioescala,archivo) values(@strlcaso,'Reportado',@strlobs,@strlfcreg,@strldiagvariable,@strlapn,@strlqos,@strlfcini,@strlidusuario,@strlarchivo)"
            cms.Parameters.Add("@strlcaso", SqlDbType.Decimal).Value = strlcaso
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strlfcreg", SqlDbType.DateTime).Value = strlfcreg
            cms.Parameters.Add("@strldiagvariable", SqlDbType.Int).Value = strldiagvariable
            cms.Parameters.Add("@strlapn", SqlDbType.VarChar, 50).Value = strlapn
            cms.Parameters.Add("@strlqos", SqlDbType.VarChar, 50).Value = strlqos
            cms.Parameters.Add("@strlfcini", SqlDbType.DateTime).Value = strlfcini
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@strlarchivo", SqlDbType.VarChar, 255).Value = strlarchivo
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


    Public Sub registro_CRM_inbound_escalamiento()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Try
            Dim cms As New SqlClient.SqlCommand
            cn.Open()
            cms.CommandText = "INSERT INTO CRM_inbound (Fk_Id_caso,Id_usuario,Obs,Tipificacion,escalamiento) VALUES(@strlcaso,@strlidusuario,@strlobs,@strltipificacion,@strlpreg2)"
            If strlfcreg <> Nothing Then
                cms.Parameters.AddWithValue("@strlfcreg", strlfcreg)
                cms.CommandText = "INSERT INTO CRM_inbound (Fec_registro, Fk_Id_caso,Id_usuario,Obs,Tipificacion,escalamiento) VALUES(@strlfcreg, @strlcaso,@strlidusuario,@strlobs,@strltipificacion,@strlpreg2)"
            End If

            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltipificacion", SqlDbType.VarChar).Value = strltipificacion
            cms.Parameters.Add("@strlpreg2", SqlDbType.VarChar).Value = strlpreg2

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

    Public Function Consulta_Diganostico_inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base 
        Dim dts As New DataSet
        Dim dta As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select top 1 id_crm,fk_id_caso,Fec_registro,tecnologia,ES.Marca,ES.Equipo,DI.Coddpto,DI.coddiv as municipio,barrio,fec_ult_caida,franja_utl_caida,Tipo_PQR,Modalidad,PQR from Bandeja_inbound B left join CRM_inbound C on B.id_caso=C.fk_id_caso  inner join EquipoStandar ES on C.Equipo=ES.equipo left join Divipola DI on C.Municipio = DI.coddiv where id_caso=@strlcaso order by id_crm desc"
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
                If dts.Tables(0).Rows(0).Item("municipio") Is System.DBNull.Value Then
                    strlmun = " "
                Else
                    strlmun = dts.Tables(0).Rows(0).Item("municipio")
                End If
                If dts.Tables(0).Rows(0).Item("barrio") Is System.DBNull.Value Then
                    strlbarrio = " "
                Else
                    strlbarrio = dts.Tables(0).Rows(0).Item("barrio")
                End If
                If dts.Tables(0).Rows(0).Item("fec_ult_caida") Is System.DBNull.Value Then
                    strlfcultimac = " "
                Else
                    strlfcultimac = dts.Tables(0).Rows(0).Item("fec_ult_caida")
                End If
                If dts.Tables(0).Rows(0).Item("franja_utl_caida") Is System.DBNull.Value Then
                    strlfranjaultimac = " "
                Else
                    strlfranjaultimac = dts.Tables(0).Rows(0).Item("franja_utl_caida")
                End If
                If dts.Tables(0).Rows(0).Item("Tipo_PQR") Is System.DBNull.Value Then
                    _Tipo_PQR = " "
                Else
                    _Tipo_PQR = dts.Tables(0).Rows(0).Item("Tipo_PQR")
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


    '/*CONTROL - ICDDC*/
    Public Function Cargar_DRLS_Control() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "Agentes" Then
                cms.CommandText = "SELECT nombreu,idusuario from datosclaro.dbo.usuarios where (red=99 or red=88) and (cargo like 'N%' or cargo like 'Q%' ) and pwd <>'0' and pwd <> 'R' and cargo <>'retirado' order by nombreu"
            ElseIf _Validacion = "Estado_Caso" Then
                cms.CommandText = "SELECT Cod_BD_Voz_Complemento As Codigo, Nombre FROM clarovoz.dbo.BD_Voz_Complemento WHERE Pertenece = 'Estado_Caso'"
            ElseIf _Validacion = "Estado_Caso_SD" Then
                cms.CommandText = "SELECT Cod_BD_Voz_Complemento As Codigo, Nombre FROM clarovoz.dbo.BD_Voz_Complemento WHERE Pertenece = 'Estado_SD'"
            ElseIf _Validacion = "Estado_Remedy" Then
                cms.CommandText = "SELECT Cod_BD_Voz_Complemento As Codigo, Nombre FROM clarovoz.dbo.BD_Voz_Complemento WHERE Pertenece = 'Estado_Remedy'"
            ElseIf _Validacion = "Bandejas" Then
                cms.CommandText = "SELECT Cod_BD_Voz_Complemento As Codigo, Nombre FROM clarovoz.dbo.BD_Voz_Complemento WHERE Pertenece = 'Bandejas'"
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


    Public Function Casos_Asginados_Control() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "SD" Then
                cms.CommandText = "SELECT nombreu As Nombre, COUNT(Caso) As Casos FROM clarovoz.dbo.Control_Escalados_SD_CPD CE INNER JOIN datosclaro.dbo.Usuarios U On Id_Usuario_Asignado =  U.idusuario WHERE U.pwd <> 'R' And cargo <> 'Retirado' And (CE.Estado <> 'Liberado' and CE.Estado <> 'Llamada realizada') And Tipo_Escalado = 'Service' GROUP BY nombreu"
            Else
                cms.CommandText = "SELECT nombreu As Nombre, COUNT(Caso) As Casos FROM clarovoz.dbo.Control_Escalados_SD_CPD CE INNER JOIN datosclaro.dbo.Usuarios U On Id_Usuario_Asignado =  U.idusuario  INNER JOIN  clarovoz.dbo.VFallared VF ON CE.Caso = VF.idcaso  WHERE U.pwd <> 'R' And cargo <> 'Retirado' And (CE.Estado <> 'Liberado' and CE.Estado <> 'Llamada realizada')  and(Estado_remedy <> 'Cerrado' or Estado_remedy is null ) And Tipo_Escalado = 'Tecnica' GROUP BY nombreu"
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


    Public Function Control_Escalamiento_CPD() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim TOP As String = ""
        Dim WHERE As String = ""
        Try
            cn.Open()
            If strlcantidad <> "" Then
                TOP = "TOP " & strlcantidad
            End If
            If strlcaso <> Nothing And strlcaso <> "" Then
                WHERE = "And VF.idcaso = " & strlcaso
            Else
                If strlestadoinc <> Nothing And strlestadoinc <> "" Then
                    WHERE = "And VF.estadocpd = '" & strlestadoinc & "' "
                End If
                If strlqos <> Nothing And strlqos <> "" Then
                    WHERE = WHERE & "And VF.Estado_remedy = '" & strlqos & "' "
                End If
                If strlabierto <> Nothing And strlabierto <> "" Then
                    WHERE = WHERE & "And B.Bandeja = '" & strlabierto & "' "
                End If
                If strlobs <> Nothing And strlobs <> "" And strlobs <> "NO" Then
                    WHERE = WHERE & "And CPD.Respuesta = '" & strlobs & "' "
                End If
                If strlfcini <> Nothing And strlfcini <> "" And strlfcfin <> Nothing And strlfcfin <> "" Then
                    WHERE = WHERE & "And B.Fc_Reg > '" & strlfcini & " 00:00:00' And B.Fc_Reg < '" & strlfcfin & " 23:59:59' "
                ElseIf strlfcini <> Nothing And strlfcini <> "" Then
                    WHERE = WHERE & "And B.Fc_Reg > '" & strlfcini & " 00:00:00' "
                ElseIf strlfcfin <> Nothing And strlfcfin <> "" Then
                    WHERE = WHERE & "And B.Fc_Reg < '" & strlfcfin & " 23:59:59' "
                End If
            End If
            cms.CommandText = "SELECT " & TOP & " VF.idcaso As Caso, Min, VF.cpd, VF.estadocpd ,VF.Estado_remedy, B.Fc_Reg, VF.idusuriocpd, B.Bandeja, CPD.Respuesta FROM clarovoz.dbo.VFallared VF INNER JOIN ( SELECT cas_id,min_ac as min, estado, cas_fecha_registro As Fc_Reg, CASE Bandeja WHEN 'BSCS' THEN 'BSCS' ELSE 'DATOS' END As Bandeja FROM datosclaro.dbo.Bandeja UNION SELECT idcaso,min, estado, fcreporte As Fc_Reg, 'DILO' As Bandeja FROM datosclaro.dbo.Bandeja_alt UNION SELECT Id_Caso,Min, estado, Fc_Reg, 'FALLA DES' As Bandeja FROM datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V UNION SELECT Id_Caso,Min, estado, Fecha_registro, 'INBOUND' As Bandeja FROM datosclaro.dbo.Bandeja_inbound ) B ON VF.idcaso = B.cas_id LEFT JOIN (SELECT CPD, 'SI' As Respuesta FROM clarovoz.dbo.CPD_Con_Respuesta WHERE Respuesta is not null) CPD ON VF.cpd = CPD.CPD WHERE VF.idcaso NOT IN (SELECT caso FROM clarovoz.dbo.Control_Escalados_SD_CPD WHERE Estado <> 'Liberado') AND B.Fc_Reg > '01/01/2016 00:00:00' AND VF.cpd Is Not Null AND VF.cpd <> '' " & WHERE & " Order By Fc_Reg"
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


    Public Function Control_Escalamiento_SD() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim TOP As String = ""
        Dim WHERE As String = ""
        Try
            cn.Open()
            If strlcantidad <> "" Then
                TOP = "TOP " & strlcantidad
            End If
            If strlcaso <> Nothing And strlcaso <> "" Then
                WHERE = "And SD.idcaso = " & strlcaso
            Else
                If strlestadoinc <> Nothing And strlestadoinc <> "" Then
                    WHERE = "And SD.estado = '" & strlestadoinc & "' "
                End If
                If strlabierto <> Nothing And strlabierto <> "" Then
                    WHERE = WHERE & "And B.Bandeja = '" & strlabierto & "' "
                End If
                If strlobs <> Nothing And strlobs <> "" And strlobs <> "NO" Then
                    WHERE = WHERE & "And Serv.Respuesta = '" & strlobs & "' "
                End If
                If strlfcini <> Nothing And strlfcini <> "" And strlfcfin <> Nothing And strlfcfin <> "" Then
                    WHERE = WHERE & "And B.Fc_Reg > '" & strlfcini & " 00:00:00' And B.Fc_Reg < '" & strlfcfin & " 23:59:59' "
                ElseIf strlfcini <> Nothing And strlfcini <> "" Then
                    WHERE = WHERE & "And B.Fc_Reg > '" & strlfcini & " 00:00:00' "
                ElseIf strlfcfin <> Nothing And strlfcfin <> "" Then
                    WHERE = WHERE & "And B.Fc_Reg < '" & strlfcfin & " 23:59:59' "
                End If
            End If
            cms.CommandText = "SELECT " & TOP & " SD.idcaso As Caso, Min, SD.tickler, SD.estado, B.Fc_Reg, SD.idusuarioserv, B.Bandeja, Serv.Respuesta FROM datosclaro.dbo.ServiceDetalle SD INNER JOIN ( 	SELECT cas_id,min_ac as min, estado, cas_fecha_registro As Fc_Reg, CASE Bandeja WHEN 'BSCS' THEN 'BSCS' ELSE 'DATOS' END As Bandeja FROM datosclaro.dbo.Bandeja 	UNION 	SELECT idcaso,min, estado, fcreporte As Fc_Reg, 'DILO' As Bandeja FROM datosclaro.dbo.Bandeja_alt 	UNION 	SELECT Id_Caso,Min, estado, Fc_Reg, 'FALLA DES' As Bandeja FROM datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V 	UNION 	SELECT Id_Caso,Min, estado, Fecha_registro, 'INBOUND' As Bandeja FROM datosclaro.dbo.Bandeja_inbound ) B ON SD.idcaso = B.cas_id LEFT JOIN (	SELECT SD, 'SI' As Respuesta FROM clarovoz.dbo.SD_Con_Respuesta WHERE Respuesta is not null) Serv ON SD.tickler = Serv.SD WHERE SD.idcaso NOT IN (SELECT caso FROM clarovoz.dbo.Control_Escalados_SD_CPD WHERE Estado <> 'Liberado') AND B.Fc_Reg > '01/01/2016 00:00:00' AND SD.tickler Is Not Null AND SD.estado <> 'Cerrado' AND SD.tickler <> '' " & WHERE & " Order By Fc_Reg"
            If strlcaso <> Nothing And strlcaso <> "" Then
                cms.CommandText = "SELECT SD.idcaso As Caso, Min, SD.tickler, SD.estado, B.Fc_Reg, SD.idusuarioserv, B.Bandeja, Serv.Respuesta FROM datosclaro.dbo.ServiceDetalle SD INNER JOIN ( 	SELECT cas_id,min_ac as min, estado, cas_fecha_registro As Fc_Reg, CASE Bandeja WHEN 'BSCS' THEN 'BSCS' ELSE 'DATOS' END As Bandeja FROM datosclaro.dbo.Bandeja 	UNION 	SELECT idcaso,min, estado, fcreporte As Fc_Reg, 'DILO' As Bandeja FROM datosclaro.dbo.Bandeja_alt 	UNION 	SELECT Id_Caso,Min, estado, Fc_Reg, 'FALLA DES' As Bandeja FROM datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V 	UNION 	SELECT Id_Caso,Min, estado, Fecha_registro, 'INBOUND' As Bandeja FROM datosclaro.dbo.Bandeja_inbound ) B ON SD.idcaso = B.cas_id LEFT JOIN (	SELECT SD, 'SI' As Respuesta FROM clarovoz.dbo.SD_Con_Respuesta WHERE Respuesta is not null) Serv ON SD.tickler = Serv.SD WHERE B.Fc_Reg > '01/01/2016 00:00:00' AND SD.tickler Is Not Null AND SD.tickler <> '' " & WHERE & " "
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


    Public Function Liberacion_Control()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            If _Validacion = "TODO_CPD" Then
                cms.CommandText = "UPDATE clarovoz.dbo.Control_Escalados_SD_CPD SET Estado='Liberado', id_Usuario_Asignado='' WHERE Tipo_Escalado = 'Tecnica' And Estado <> 'Liberado'"
            End If
            If _Validacion = "AGENTE_CPD" Then
                cms.CommandText = "UPDATE clarovoz.dbo.Control_Escalados_SD_CPD SET Estado='Liberado', id_Usuario_Asignado='' WHERE Tipo_Escalado = 'Tecnica' And id_Usuario_Asignado = @strlidusuarioasignado"
                cms.Parameters.Add("@strlidusuarioasignado", SqlDbType.VarChar).Value = strlidusuarioasignado
            End If
            If _Validacion = "TODO_SD" Then
                cms.CommandText = "UPDATE clarovoz.dbo.Control_Escalados_SD_CPD SET Estado='Liberado', id_Usuario_Asignado='' WHERE Tipo_Escalado = 'Service' And Estado ='Asignado' and Estado <> 'Liberado' and estado<>'Llamada Realizada' "
            End If
            If _Validacion = "AGENTE_SD" Then
                cms.CommandText = "UPDATE clarovoz.dbo.Control_Escalados_SD_CPD SET Estado='Liberado', id_Usuario_Asignado='' WHERE Tipo_Escalado = 'Service' and estado<>'Llamada Realizada' and Estado <> 'Liberado'  And id_Usuario_Asignado = @strlidusuarioasignado"
                cms.Parameters.Add("@strlidusuarioasignado", SqlDbType.VarChar).Value = strlidusuarioasignado
            End If
            cms.Connection = cn
            Return cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function



    Public Sub Asignacion_Control()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim cms As New SqlClient.SqlCommand
        Dim num As Integer = 0
        Try
            cn.Open()
            If _Validacion = "CPD" Then
                cms.CommandText = "UPDATE clarovoz.dbo.Control_Escalados_SD_CPD SET Estado='Asignado', id_Usuario_Asignado=@strlidusuarioasignado, id_Usuario=@strlidusuario WHERE Tipo_Escalado = 'Tecnica' And Caso = @strlcaso"
            ElseIf _Validacion = "SD" Then
                cms.CommandText = "UPDATE clarovoz.dbo.Control_Escalados_SD_CPD SET Estado='Asignado', id_Usuario_Asignado=@strlidusuarioasignado, id_Usuario=@strlidusuario WHERE Tipo_Escalado = 'Service' And Caso = @strlcaso"
            End If
            cms.Parameters.Add("@strlidusuarioasignado", SqlDbType.VarChar).Value = strlidusuarioasignado
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
            cms.Connection = cn
            num = cms.ExecuteNonQuery()
            If num < 1 Then
                If _Validacion = "CPD" Then
                    cms.CommandText = "INSERT INTO clarovoz.dbo.Control_Escalados_SD_CPD(Tipo_Escalado, id_Usuario, id_Usuario_Asignado, Estado, Campaña, Caso) VALUES ('Tecnica',@strlidusuario,@strlidusuarioasignado,'Asignado',@Campaña,@strlcaso)"
                ElseIf _Validacion = "SD" Then
                    cms.CommandText = "INSERT INTO clarovoz.dbo.Control_Escalados_SD_CPD(Tipo_Escalado, id_Usuario, id_Usuario_Asignado, Estado, Campaña, Caso) VALUES ('Service',@strlidusuario,@strlidusuarioasignado,'Asignado',@Campaña,@strlcaso)"
                End If
                If strlCampanaLogin <> Nothing And strlCampanaLogin <> "" Then
                    cms.Parameters.Add("@Campaña", SqlDbType.VarChar).Value = strlCampanaLogin
                Else
                    cms.Parameters.AddWithValue("@Campaña", DBNull.Value)
                End If
                cms.Connection = cn
                num = cms.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    '/****************/

    Public Function Consulta_General_inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim TOP As String = ""
        Dim WHERE As String = ""
        Try
            cn.Open()
            Dim cons As String
            If strlcaso <> "" Or strlidcrm <> "" Then
                If strlcaso <> "" Then
                    cons = "Id_caso= '" + strlcaso + "'"
                ElseIf strlidcrm <> "" Then
                    cons = "id_avaya='" + strlidcrm + "'"
                End If
                cms.CommandText = "Select Id_caso as Caso,Fecha_registro,MIN,Id_avaya,Usu_reporta as [Usuario reporta],Caso_rechazado ,Fc_caso_rechazado ,Fc_ult_gestion ,Campaña,B.Estado,Min_alterno,B.Municipio,cpd,estadocpd as [Estado CPD],tickler as SD, S.estado as [Estado SD],TS.tipificacion1 as [linea de servicio],TS.tipificacion2 as Servicio,TR.tipificacion1 as [Segmento], TR.tipificacion2 as [Causa raiz], TC.tipificacion1 as [Categoria Cierre] from datosclaro.dbo.Bandeja_inbound B Inner join (Select top 1 id_crm,fk_id_caso,Id_servicio,Causa_raiz,Categoria_cierre from (SELECT id_crm,fk_id_caso,Id_servicio,Causa_raiz,Categoria_cierre FROM datosclaro.dbo.CRM_inbound UNION SELECT id_crm,fk_id_caso,Id_servicio,Causa_raiz,Categoria_cierre FROM datosclaro.dbo.Historial_Crm_inbound) As C Inner join datosclaro.dbo.Bandeja_inbound B on C.Fk_Id_caso = B.Id_caso where " + cons + " and Id_servicio is not null and Categoria_cierre is not null order by id_crm desc) C on Id_caso=Fk_Id_caso inner join datosclaro.dbo.Tipificaciones2 TS on C.Id_servicio = TS.cod_tipificacion and TS.pertenece='Servicio1' inner join datosclaro.dbo.Tipificaciones2 TR on C.Causa_raiz = TR.cod_tipificacion and TR.pertenece='Catalogo_diagnostico' inner join datosclaro.dbo.Tipificaciones2 TC on C.Categoria_cierre = TC.cod_tipificacion and TC.pertenece = 'Categoria cierre' left join clarovoz.dbo.VFallared V on B.Id_caso = V.idcaso left join datosclaro.dbo.ServiceDetalle S on B.Id_caso = S.idcaso where " + cons + " Select Fk_Id_caso as Caso,Numero_alterno as [Min Alterno],Fec_registro as [Fecha Registro], C.Id_usuario, Obs as Observacion,Tipificacion,Escalamiento, Fec_programado,C.Estado from (SELECT Fk_Id_caso,Fec_registro,Numero_alterno,Id_Usuario,obs,tipificacion,Escalamiento,Fec_programado,'Actual' As Estado FROM datosclaro.dbo.CRM_inbound UNION SELECT Fk_Id_caso,Fec_registro,Numero_alterno,Id_Usuario,obs,tipificacion,Escalamiento,Fec_programado,'Eliminado' as Estado FROM datosclaro.dbo.Historial_Crm_inbound ) As C inner join datosclaro.dbo.Bandeja_inbound B on C.Fk_Id_caso = B.Id_caso where " + cons + " order by [Fecha Registro]"
            ElseIf strlmin <> "" Then
                cms.CommandText = "Select Id_caso as Caso,Fecha_registro,MIN,Id_avaya,Usu_reporta as [Usuario reporta],Caso_rechazado ,Fc_caso_rechazado ,Fc_ult_gestion ,Campaña,B.Estado,Min_alterno,B.Municipio,cpd,estadocpd as [Estado CPD],tickler as SD, S.estado as [Estado SD] from datosclaro.dbo.Bandeja_inbound B left join clarovoz.dbo.VFallared V on B.Id_caso = V.idcaso left join datosclaro.dbo.ServiceDetalle S on B.Id_caso = S.idcaso where min='" + strlmin + "' order by B.Id_caso Select Fk_Id_caso as Caso,min,Numero_alterno as [Min Alterno],Fec_registro as [Fecha Registro], C.Id_usuario, Obs as Observacion,Tipificacion,Escalamiento, Fec_programado,C.Estado from (SELECT Fk_Id_caso,Fec_registro,Numero_alterno,Id_Usuario,obs,tipificacion,Escalamiento,Fec_programado,'Actual' As Estado FROM datosclaro.dbo.CRM_inbound UNION SELECT Fk_Id_caso,Fec_registro,Numero_alterno,Id_Usuario,obs,tipificacion,Escalamiento,Fec_programado,'Eliminado' as Estado FROM datosclaro.dbo.Historial_Crm_inbound ) As C inner join datosclaro.dbo.Bandeja_inbound B on B.Id_caso = Fk_Id_caso where min='" + strlmin + "' order by Fk_Id_caso,[Fecha Registro]"
            ElseIf strltipificacion <> "" Or _Bandeja <> "" Or strlfcini <> "" Or strlfcfin <> "" Then
                If strltipificacion <> "" Then
                    strltipificacion = " and estado='" + strltipificacion + "'"
                Else
                    strltipificacion = ""
                End If
                If _Bandeja <> "" Then
                    _Bandeja = " and campaña ='" + _Bandeja + "'"
                Else
                    _Bandeja = ""
                End If
                If strlfcini <> "" Then
                    strlfcini = " and convert(date,Fecha_registro)>='" + strlfcini + "'"
                Else
                    strlfcini = ""
                End If
                If strlfcfin <> "" Then
                    strlfcfin = " and convert(date,Fecha_registro)<='" + strlfcfin + "'"
                Else
                    strlfcfin = ""
                End If
                cms.CommandText = "Select Id_caso as Caso, id_avaya,Fecha_registro,Estado,Nombre_cliente as Cliente,Min,Min_alterno,Departamento,Municipio,id_usuario,usu_reporta as [Usuario reporta], Campaña,Caso_rechazado ,Fc_caso_rechazado ,Fc_ult_gestion  from datosclaro.dbo.Bandeja_inbound where Id_caso is not null " + strlfcini + strlfcfin + strltipificacion + _Bandeja + "order by id_caso"
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
    Public Function Consultar_Jefes_Productividad() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion2").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "select distinct Jefe_Inmediato from Validacion_Horario where Jefe_Inmediato IS NOT NULL And Jefe_Inmediato <> '' "
            If _Validacion = "1" Then
                cms.CommandText = "Select distinct Jefe_Inmediato from Validacion_Horario where convert(date,Fc_Ingreso)>='01/08/2016' and Jefe_Inmediato is not null"
            End If

            cms.Connection = cn
            dtarecepcion = New SqlClient.SqlDataAdapter(cms)
            dtarecepcion.Fill(dtsrecepcion)
            strlcantidad = dtsrecepcion.Tables(0).Rows.Count
            strlajuste = ""
            Return dtsrecepcion
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Public Function Consulta_general_datos_BSCS() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontroldatos").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim TOP As String = ""
        Dim WHERE As String = ""
        Try
            cn.Open()
            If strlcaso <> "" Then
                cms.CommandText = "SELECT cas_id as [Caso],cas_fecha_registro as [Fecha Registro],min_ac as [Min],Bandeja,B.Estado,V.CPD,V.estadocpd as [estado CPD],S.tickler as [SD],S.estado as [Estado SD],TS.tipificacion1 as [Linea],TS.tipificacion2 as [Servicio],TF.tipificacion1 as [Solicitud / Falla],TR.tipificacion2 as [Causa Falla],TC.tipificacion1 as [Categoria Cierre] FROM datosclaro.dbo.Bandeja B left join (Select top 1 idcaso,servicio,idsolicitud,Causa_raiz,Categoria_Cierre from datosclaro.dbo.Detalle_diagnostico where idcaso=@strlcaso and servicio is not null and Categoria_Cierre is not null order by idreg desc) DD on B.cas_id=DD.Idcaso left join datosclaro.dbo.Tipificaciones2 TS on DD.servicio = TS.cod_tipificacion and pertenece='servicio1' left join datosclaro.dbo.Tipificaciones2 TF on DD.idsolicitud = TF.cod_tipificacion and TF.pertenece='servicio2' left join datosclaro.dbo.Tipificaciones2 TR on DD.Causa_Raiz = TR.cod_tipificacion and TR.pertenece='Catalogo_diagnostico' left join datosclaro.dbo.Tipificaciones2 TC on DD.Categoria_Cierre = TC.cod_tipificacion and TC.pertenece='Categoria cierre' left join clarovoz.dbo.VFallared V on B.cas_id = V.idcaso left join datosclaro.dbo.ServiceDetalle S on B.cas_id = S.idcaso where cas_id=@strlcaso  SELECT idcaso,fcreg,idusuario,obs,tipificacion,numalt,fcprogram,B.Bandeja, C.Estado FROM (SELECT idcaso,fcreg,idusuario,obs,tipificacion,numalt,fcprogram,'Actual' As Estado FROM datosclaro.dbo.CRMDetalle UNION SELECT idcaso,fcreg,idusuario,obs,tipificacion,numalt,fcprogram,'Eliminado' as Estado FROM datosclaro.dbo.Historial_CRM_Datos_BSCS ) As C inner join datosclaro.dbo.Bandeja B on C.idcaso=B.cas_id where cas_id=@strlcaso ORDER BY C.idcaso,C.fcreg"
                cms.Parameters.Add("@strlcaso", SqlDbType.BigInt).Value = strlcaso
            ElseIf strlmin <> "" Then
                cms.CommandText = "Select cas_id as [Caso],cas_fecha_registro as [Fecha Registro],min_ac as [Min],Bandeja,B.Estado,V.CPD,V.estadocpd as [estado CPD],S.tickler as [SD],S.estado as [Estado SD] from datosclaro.dbo.Bandeja B left join clarovoz.dbo.VFallared V on B.cas_id = V.idcaso left join datosclaro.dbo.ServiceDetalle S on B.cas_id = S.idcaso where min_ac =" + strlmin + " SELECT idcaso,fcreg,idusuario,obs,tipificacion,numalt,fcprogram,B.Bandeja, C.Estado FROM (SELECT idcaso,fcreg,idusuario,obs,tipificacion,numalt,fcprogram,'Actual' As Estado FROM datosclaro.dbo.CRMDetalle UNION SELECT idcaso,fcreg,idusuario,obs,tipificacion,numalt,fcprogram,'Eliminado' as Estado FROM datosclaro.dbo.Historial_CRM_Datos_BSCS ) As C inner join datosclaro.dbo.Bandeja B on C.idcaso=B.cas_id where min_ac=" + strlmin + " ORDER BY C.idcaso,C.fcreg"
            ElseIf strltipificacion <> "" Or _Bandeja <> "" Or strlfcini <> "" Or strlfcfin <> "" Then
                If strltipificacion <> "" Then
                    strltipificacion = " and B.estado='" + strltipificacion + "'"
                Else
                    strltipificacion = ""
                End If
                If _Bandeja <> "" Then
                    If _Bandeja = "Datos" Then
                        _Bandeja = "AND Bandeja = 'Datos'"
                    ElseIf _Bandeja = "PQR" Then
                        _Bandeja = "AND Bandeja like '%Datos-Smartphone%'  "
                    ElseIf _Bandeja = "Sin Formato" Then
                        _Bandeja = "AND Bandeja like '%CONTROL%'  "
                    ElseIf _Bandeja = "BSCS" Then
                        _Bandeja = "AND Bandeja like '%BSCS%'  "
                    End If
                Else
                    _Bandeja = ""
                End If
                If strlfcini <> "" Then
                    strlfcini = " AND convert(date,cas_fecha_registro)>='" + strlfcini + "'"
                Else
                    strlfcini = ""
                End If
                If strlfcfin <> "" Then
                    strlfcfin = " AND convert(date,cas_fecha_registro)<='" + strlfcfin + "'"
                Else
                    strlfcfin = ""
                End If
                cms.CommandText = "Select cas_id as Caso,cas_fecha_registro as [Fecha ingreso],min_ac as Min,B.Estado,Bandeja,V.CPD,V.estadocpd as [estado CPD],S.tickler as [SD],S.estado as [Estado SD] from datosclaro.dbo.bandeja B left join clarovoz.dbo.VFallared V on B.cas_id = V.idcaso left join datosclaro.dbo.ServiceDetalle S on B.cas_id = S.idcaso where cas_id is not null " + strlfcini + strlfcfin + strltipificacion + _Bandeja + "order by cas_id"
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

    Public Function Consulta_Casos_Dilo() As DataSet 'Copyright © 2016 ICDDC
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = ""
        Dim REPORTADO As String = ""
        Try
            cn.Open()
            If strlcaso <> Nothing Then
                If strlcantidad = "REPORTADO" Then
                    REPORTADO = " INNER JOIN Bandeja_alt B On B.caso = @caso where C.Id_Caso = B.idcaso "
                    WHERE = " B.caso = @caso "
                Else
                    REPORTADO = " where C.Id_Caso= @caso "
                    WHERE = " B.idcaso = @caso "
                End If
                If _Validacion = "Seguimiento" Then
                    cms.CommandText = "SELECT C.idcrmdilo As ID,C.idcasodilo As Caso,C.Numero_alt As [Min Alterno],C.fcregistro As [Fc Registro],C.Idusuario,C.obs As Observacion,C.Tipificacion, C.Fc_Programado As [Fc Programado], C.Estado FROM Bandeja_alt B INNER JOIN (SELECT idcrmdilo,idcasodilo,fcregistro,idusuario,obs,tipificacion,Numero_alt,Fc_Programado,'Actual' As Estado FROM datosclaro.dbo.CRMDilo UNION SELECT idcrmdilo,idcasodilo,fcregistro,idusuario,obs,tipificacion,Numero_alt,Fc_Programado,'Eliminado' as Estado FROM datosclaro.dbo.Historial_CRM_dilo ) As C ON C.idcasodilo = B.idcaso WHERE " & WHERE & ""
                ElseIf _Validacion = "General" Then
                    cms.CommandText = "Select B.idcaso As Caso, Mesa, fcreporte As [Fc Reporte], caso As [Caso Reportado], Solicitud, Min, Telcontacto, Cliente, depto As Departamento, B.Ciudad, B.Barrio, Zona, B.Direccion, B.Equipo, B.Tecnologia, Canal, B.Estado,CPD,Estadocpd,tickler As SD, S.estado As [Estado SD],TS.tipificacion1 As [Linea Servicio],TS.tipificacion2 As Servicio,TR.tipificacion1 As Segmento, TR.tipificacion2 As [Causa Raiz], TC.tipificacion1 As [Categoria Cierre] from datosclaro.dbo.Bandeja_alt B LEFT JOIN (Select top 1 C.Cod_Detalle_Diagnostico_Otros,C.Id_Caso,C.idservicio,Causa_raiz,Categoria_cierre from datosclaro.dbo.Detalle_Diagnostico_Otros C " & REPORTADO & " And idservicio Is Not null And Categoria_cierre Is Not null order by Cod_Detalle_Diagnostico_Otros desc) C On B.idcaso=C.Id_Caso LEFT JOIN datosclaro.dbo.Tipificaciones2 TS On C.Idservicio = TS.cod_tipificacion And TS.pertenece='Servicio1' LEFT JOIN datosclaro.dbo.Tipificaciones2 TR on C.Causa_raiz = TR.cod_tipificacion and TR.pertenece='Catalogo_diagnostico' LEFT JOIN datosclaro.dbo.Tipificaciones2 TC on C.Categoria_cierre = TC.cod_tipificacion and TC.pertenece = 'Categoria cierre' LEFT JOIN clarovoz.dbo.VFallared V on B.idcaso = V.idcaso LEFT JOIN datosclaro.dbo.ServiceDetalle S on B.idcaso = S.idcaso WHERE " & WHERE & ""
                End If
            ElseIf _Validacion = "General" Then
                If strltipificacion <> Nothing Then
                    WHERE = WHERE & " And Estado = '" & strltipificacion & "' "
                End If
                If strlmesa <> Nothing Then
                    WHERE = WHERE & " And Canal = '" & strlmesa & "' "
                End If
                If strlmin <> Nothing Then
                    WHERE = WHERE & " And Min = '" & strlmin & "' "
                End If
                If strlfcini <> Nothing And strlfcfin <> Nothing Then
                    WHERE = WHERE & " And fcreporte Between '" & strlfcini & "' And  '" & strlfcfin & "' "
                End If
                cms.CommandText = "Select B.idcaso As Caso, Mesa, fcreporte As [Fc Reporte], caso As [Caso Reportado], Solicitud, Min, Telcontacto, Cliente, depto As Departamento, B.Ciudad, B.Barrio, Zona, B.Direccion, B.Equipo, B.Tecnologia, Canal, B.Estado from datosclaro.dbo.Bandeja_alt B where 1 = 1 " & WHERE & ""
            End If
            If strlcaso <> Nothing Then
                cms.Parameters.Add("@caso", SqlDbType.VarChar, 50).Value = strlcaso
            Else
                cms.Parameters.AddWithValue("@caso", DBNull.Value)
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

    Public Function Validacion_caso_inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select id_caso from Bandeja_inbound where id_caso=@strlcaso"
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
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

    Friend Function registro_inconsistencia_inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dtsrecepcion As New DataSet
            Dim dtarecepcion As SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "insert into Inconsistencia_inbound(id_avaya,min,usuario_reporta,id_usuario,estado,obs,Ubicacion_call) values (@strlidcrm,@strlmin,@strlusuarioreporta,@strlidusuario,@strlestadoinc,@strlobs,@strllugar) select @@IDENTITY as id"
            cms.Parameters.Add("@strlidcrm", SqlDbType.VarChar).Value = strlidcrm
            cms.Parameters.Add("@strlmin", SqlDbType.VarChar).Value = strlmin
            cms.Parameters.Add("@strlusuarioreporta", SqlDbType.VarChar).Value = strlusuarioreporta
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlestadoinc", SqlDbType.VarChar).Value = strlestadoinc
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strllugar", SqlDbType.VarChar).Value = strllugar
            cms.Connection = cn
            'cms.ExecuteNonQuery()
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

    Public Function Asignar_Caso_Devuelto()
        Dim Con As New SqlClient.SqlConnection 'conexión a la base de datos
        Dim cms As New SqlClient.SqlCommand
        Try
            Dim Fecha As String = Now
            Con = New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) 'Conexión directa con la creada en Web.config
            Con.Open()
            cms.CommandText = "Declare @_Val smallint Begin Update datosclaro.dbo.Bandeja set correo_electronico = @_Id_Agente, st_bb_call= @_fecha, idusuarioasigna = @_Id_Usuario Where cas_id = @_Id_Caso Set @_Val = @@rowcount IF @_Val <= 0 Begin Update datosclaro.dbo.Bandeja_alt SET Usuario_Asignado=@_Id_Agente, Fc_Asignado=@_fecha, usuario_designa = @_Id_Usuario WHERE idcaso = @_Id_Caso Set @_Val = @@rowcount IF @_Val <= 0 Begin Update datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V SET Usuario_Asignado = @_Id_Agente, Fc_Asignado = @_fecha, usuario_designa=@_Id_Usuario WHERE Id_Caso = @_Id_Caso; Set @_Val = @@rowcount End End end IF @_Val >=1 Update datosclaro.dbo.ServiceDetalle Set dev = 0 Where idcaso = @_Id_Caso And (select count(Id_caso) From datosclaro.dbo.Bandeja_inbound where Id_caso = @_Id_Caso) <= 0;"
            cms.Parameters.Add("@_Id_Caso", SqlDbType.BigInt).Value = strlcaso
            cms.Parameters.Add("@_Id_Usuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@_Id_Agente", SqlDbType.VarChar, 50).Value = strlidusuarioasignado
            cms.Parameters.Add("@_Fecha", SqlDbType.VarChar, 50).Value = Fecha
            cms.Connection = Con
            Return cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cms.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Cons_Cas_Servis_Datos() As DataSet
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim Scm As New SqlClient.SqlCommand
        Try
            Dim Dts As New DataSet
            Dim Dta As SqlClient.SqlDataAdapter
            Dim Sql_Frag_Top As String = Nothing
            Dim Sql_Frag_Where As String = Nothing
            If strlcantidad <> Nothing Then
                Scm.Parameters.Add("@_Top", SqlDbType.Int).Value = strlcantidad
                Sql_Frag_Top = " Top(@_Top) "
            End If
            If strlfcini <> Nothing Then
                Scm.Parameters.AddWithValue("@_Fecha_Ini", strlfcini)
                Sql_Frag_Where = " And Convert(Date,S.fcregserv) >= @_Fecha_Ini "
            End If
            If strlfcfin <> Nothing Then
                Scm.Parameters.AddWithValue("@_Fecha_Fin", strlfcfin)
                Sql_Frag_Where = Sql_Frag_Where & " And Convert(Date,S.fcregserv) <= @_Fecha_Fin "
            End If
            If _Causal_escalam <> Nothing Then
                Scm.Parameters.AddWithValue("@_Causal_escalam", _Causal_escalam)
                Sql_Frag_Where = Sql_Frag_Where & " And Causal_Escalam = @_Causal_escalam "
            End If

            Con.Open()
            Scm.CommandText = "SELECT " & Sql_Frag_Top & " S.idcaso As Id_Caso, B.Fecha_reg, S.fcregserv As Fecha_Solicitur_Esc, S.idusuarioescala As Usuario_Esc ,S.fcasignado FROM datosclaro.dbo.ServiceDetalle S Inner Join ( select cas_id As Id_Caso, cas_fecha_registro As Fecha_reg, estado As Estado From datosclaro.dbo.Bandeja union select idcaso, fcreporte, estado From Bandeja_alt union select Id_Caso, Fc_Reg, estado From Bandeja_Falla_Desactivacion_D_V Union select Id_Caso, Fecha_registro, Estado From Bandeja_inbound ) B On B.Id_Caso=S.idcaso where S.fcasignado Is Null " & Sql_Frag_Where & " order by idcaso"
            Scm.Connection = Con
            Dta = New SqlClient.SqlDataAdapter(Scm)
            Dta.Fill(Dts)
            strlcantidad = Dts.Tables(0).Rows.Count
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function
    Public Function Cons_Cas_Servis_Datos_Dev()
        Dim Con As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString) ' Conexion con la base
        Dim Scm As New SqlClient.SqlCommand
        Try
            Dim Dts As New DataSet
            Dim Sql_Frag_Where As String = Nothing
            Dim Sql_Frag_Top As String = Nothing
            If _Fecha_Ini <> Nothing Then
                Scm.Parameters.AddWithValue("@_Fecha_Ini", _Fecha_Ini)
                Sql_Frag_Where = Sql_Frag_Where & " And Convert(Date,S.fcprocesado) >= @_Fecha_Ini "
            End If
            If _Fecha_Fin <> Nothing Then
                Scm.Parameters.AddWithValue("@_Fecha_Fin", _Fecha_Fin)
                Sql_Frag_Where = Sql_Frag_Where & " And Convert(Date,S.fcprocesado) <= @_Fecha_Fin "
            End If
            If _Max <> Nothing Then
                Scm.Parameters.AddWithValue("@_Max", _Max)
                Sql_Frag_Top = " Top(@_Max) "
            End If
            Con.Open()
            Scm.Connection = Con
            Scm.CommandText = "Declare @_Casos table ( Id_Caso decimal(18,0), Fecha_Reg DateTime, Fecha_Reg_Service DateTime, Fecha_Asignado DateTime, Fecha_Proc_Dev DateTime, Id_Usuario_Dev Varchar(20) ) Insert Into @_Casos Select S.idcaso , B.cas_fecha_registro , S.fcregserv , S.fcasignado , S.fcprocesado , S.idusuarioescala From datosclaro.dbo.ServiceDetalle S Inner Join ( select cas_id, cas_fecha_registro From datosclaro.dbo.Bandeja Where estado Like 'No Contactado' union select idcaso, fcreporte From datosclaro.dbo.Bandeja_alt Where estado Like 'No Contactado' union select Id_Caso, Fc_Reg From datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V Where estado Like 'No Contactado' ) B On B.cas_id=s.idcaso Inner Join ( select C1.idcaso from ( SELECT Max(idcrm) As idcrm, idcaso FROM datosclaro.dbo.CRMDetalle Group By idcaso ) C1 Inner Join datosclaro.dbo.CRMDetalle C2 On C1.idcrm = C2.idcrm And C2.tipificacion Like 'Devuelto' Union select C1.idcasodilo from ( SELECT Max(idcrmdilo) As idcrm, idcasodilo FROM datosclaro.dbo.CRMdilo Group By idcasodilo ) C1 Inner Join datosclaro.dbo.CRMdilo C2 On C1.idcrm = C2.idcrmdilo And C2.tipificacion Like 'Devuelto' Union Select CC.Id_Caso From ( select C1.Id_Caso, C1.Fk_Id_Bandeja from ( SELECT Max(C.Id_CRM_Falla_Desactivacion_D_V) As Id_CRM_Falla_Desactivacion_D_V, B.Id_Caso, C.Fk_Id_Bandeja FROM datosclaro.dbo.CRM_Falla_Desactivacion_D_V C Inner Join datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V B On B.Id_Bandeja_Falla_Desactivacion_D_V = C.Fk_Id_Bandeja Group By B.Id_Caso, C.Fk_Id_Bandeja ) C1 Inner Join datosclaro.dbo.CRM_Falla_Desactivacion_D_V C2 On C1.Id_CRM_Falla_Desactivacion_D_V = C2.Id_CRM_Falla_Desactivacion_D_V And C2.tipificacion Like 'Devuelto' ) CC ) C On C.idcaso = S.idcaso Where S.estado Like 'Devuelto' And S.dev = 1 " & Sql_Frag_Where & " Order by Convert(Date,S.fcprocesado) Desc Select " & Sql_Frag_Top & " Id_Caso, Fecha_Reg, Fecha_Reg_Service, Fecha_Asignado, Fecha_Proc_Dev, Id_Usuario_Dev From @_Casos Select Id_Caso , Fc_Reg_Ges As Fecha , Id_Usuario , Obs As Observacion , Id_Crm , Tipificacion From ( SELECT B.Id_Caso As Id_Caso, Fc_Reg_Ges, Id_Usuario, Obs, Id_CRM_Falla_Desactivacion_D_V As Id_Crm, Tipificacion From datosclaro.dbo.CRM_Falla_Desactivacion_D_V C Inner Join datosclaro.dbo.Bandeja_Falla_Desactivacion_D_V B On B.Id_Bandeja_Falla_Desactivacion_D_V = C.Fk_Id_Bandeja Where B.Id_Caso In (Select " & Sql_Frag_Top & " Id_Caso From @_Casos) union select idcaso, fcreg, idusuario, obs, idcrm, Tipificacion from datosclaro.dbo.CRMDetalle Where idcaso In (Select " & Sql_Frag_Top & " Id_Caso From @_Casos) union select idcasodilo, fcregistro, idusuario, obs, idcrmdilo, Tipificacion from datosclaro.dbo.CRMdilo Where idcasodilo In (Select " & Sql_Frag_Top & " Id_Caso From @_Casos) ) C Order By Id_Caso, Fc_Reg_Ges Desc;"
            Dim Sda = New SqlClient.SqlDataAdapter(Scm)
            Sda.Fill(Dts)
            Return Dts
        Catch ex As Exception
            Throw ex
        Finally
            Scm.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Function

    Public Function Registrar_Dilo_inbound() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Try
            Dim cms As New SqlClient.SqlCommand
            Dim dtsrecepcion As New DataSet
            Dim dtarecepcion As SqlClient.SqlDataAdapter
            cn.Open()
            cms.CommandText = "INSERT INTO Bandeja_alt (fcreporte, caso, solicitud, min, telcontacto, cliente, depto, ciudad, barrio, zona, direccion, distribuidor, gruporep, equipo, tecnologia, canal, estado, mesa, Usuario_registra, ID_AVAYA, SD_SGSC) VALUES(getdate(),@strlcaso,@strlobs,@strlmin,@strltelalt,@strlcliente,@strldpto,@strlmun,@strlbarrio,@strlzona,@strldir,@strlareafalla,'DISTRIBUIDOR',@strlequipo,@strltecnologia,@_Bandeja, 'ABIERTO',@strlmesa,@strlidusuario,@strlidcrm,@strltickler) select @@IDENTITY as Caso"
            cms.Parameters.Add("@strlidcrm", SqlDbType.VarChar).Value = strlidcrm
            cms.Parameters.Add("@strlcliente", SqlDbType.VarChar).Value = strlcliente
            cms.Parameters.Add("@strlmin", SqlDbType.VarChar).Value = strlmin
            cms.Parameters.Add("@strlareafalla", SqlDbType.VarChar).Value = strlareafalla
            cms.Parameters.Add("@strlequipo", SqlDbType.VarChar).Value = strlequipo
            cms.Parameters.Add("@strldpto", SqlDbType.VarChar).Value = strldpto
            cms.Parameters.Add("@strlmun", SqlDbType.VarChar).Value = strlmun
            cms.Parameters.Add("@strlbarrio", SqlDbType.VarChar).Value = strlbarrio
            cms.Parameters.Add("@strldir", SqlDbType.VarChar).Value = strldir
            cms.Parameters.Add("@strlzona", SqlDbType.VarChar).Value = strlzona
            cms.Parameters.Add("@strltecnologia", SqlDbType.VarChar).Value = strltecnologia
            cms.Parameters.Add("@strltickler", SqlDbType.VarChar).Value = strltickler
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@strlmesa", SqlDbType.VarChar).Value = strlmesa
            cms.Parameters.Add("@_Bandeja", SqlDbType.VarChar).Value = _Bandeja
            cms.Parameters.Add("@strlobs", SqlDbType.VarChar).Value = strlobs
            cms.Parameters.Add("@strltelalt", SqlDbType.VarChar).Value = strltelalt
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
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

    Public Function Validacion_caso_inbound_dilo() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "Select caso from Bandeja_alt where caso=@strlcaso"
            If _Validacion = "Consulta" Then
                cms.CommandText = "Select idcaso As Caso,caso as [Caso Claro],Mesa,fcreporte As [Fc Creado],Solicitud,Min,Telcontacto,Cliente,depto As Departamento,Ciudad,Barrio,Zona,Direccion,Equipo,Tecnologia,Canal,Estado,usuario_registra as [Usuario Crea] from Bandeja_alt where caso=@strlcaso or idcaso=@strlcaso"
            End If
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
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


    Public Sub Reg_Llamada_Corta_Inb()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "INSERT INTO Llamada_Corta_Inb(Id_Usuario,ID_AVAYA,Tipo_Llamada,Ubicacion_Call,Observacion,Caso) VALUES(@Id_Usuario,@ID_AVAYA,@Tipo_Llamada,@Ubicacion_Call,@Observacion,@Caso)"
            cms.Parameters.Add("@Id_Usuario", SqlDbType.VarChar, 50).Value = strlidusuario
            cms.Parameters.Add("@ID_AVAYA", SqlDbType.VarChar, 50).Value = strlidcrm
            If strlcaso = Nothing Then
                cms.Parameters.AddWithValue("@Caso", DBNull.Value)
            Else
                cms.Parameters.AddWithValue("@Caso", strlcaso.ToString)
            End If
            cms.Parameters.Add("@Tipo_Llamada", SqlDbType.VarChar, 50).Value = strltipofalla
            cms.Parameters.Add("@Ubicacion_Call", SqlDbType.VarChar, 50).Value = strllugar
            cms.Parameters.Add("@Observacion", SqlDbType.VarChar, 50).Value = strlobs.ToString
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


    ''''''''''''''''''''''CONTROL PQR'''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Consulta_Control_PQR() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Dim WHERE As String = ""
        Dim TOP As String = ""
        Try
            If strlcantidad <> "" Then
                TOP = " TOP " & strlcantidad & ""
            End If
            If strlcaso <> Nothing And strlcaso <> "" Then
                WHERE = " And C.CASO = @strlcaso "
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar, 50).Value = strlcaso
            Else
                If _Bandeja <> Nothing And _Bandeja <> "" Then
                    WHERE = WHERE & " And B.Bandeja = @_Bandeja "
                    cms.Parameters.Add("@_Bandeja", SqlDbType.VarChar, 50).Value = _Bandeja
                End If
                If strlestadoinc <> Nothing Then
                    WHERE = WHERE & " And B.ESTADO = @strlestado "
                    cms.Parameters.Add("@strlestado", SqlDbType.VarChar, 50).Value = strlestadoinc
                End If
                If _Escalamiento_CPD_SD = "SD" Then
                    WHERE = WHERE & " And E.Escalamiento = 'SD'"
                ElseIf _Escalamiento_CPD_SD = "CPD" Then
                    WHERE = WHERE & " And E.Escalamiento = 'CPD'"
                End If
                If strlfcini <> Nothing And strlfcini <> "" And strlfcfin <> Nothing And strlfcfin <> "" Then
                    WHERE = WHERE & " And C.FECHA_INGRESO >= @strlfcini And C.FECHA_INGRESO <= @strlfcfin"
                    cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = strlfcini & " 00:00:00"
                    cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = strlfcfin & " 23:59:59"
                ElseIf strlfcini <> Nothing And strlfcini <> "" Then
                    WHERE = WHERE & " And C.FECHA_INGRESO >= @strlfcini"
                    cms.Parameters.Add("@strlfcini", SqlDbType.VarChar, 50).Value = strlfcini & " 00:00:00"
                ElseIf strlfcfin <> Nothing And strlfcfin <> "" Then
                    WHERE = WHERE & " And C.FECHA_INGRESO <= @strlfcfin"
                    cms.Parameters.Add("@strlfcfin", SqlDbType.VarChar, 50).Value = strlfcfin & " 23:59:59"
                End If
            End If
            cn.Open()
            cms.CommandText = "SELECT " & TOP & " C.CASO, C.PQR, C.FECHA_INGRESO, C.FECHA_SAP, C.TITULAR, C.MIN, B.ESTADO, B.BANDEJA, (CASE WHEN E.ESCALAMIENTO LIKE '%D%' THEN  E.ESCALAMIENTO ELSE 'N/A' END) As ESCALAMIENTO FROM Control_PQR C INNER JOIN (SELECT cas_id As Id_caso, Estado, (CASE WHEN Bandeja like '%Control%' THEN 'TSF'  WHEN Bandeja LIKE 'BSCS' THEN 'BSCS' WHEN Bandeja = 'FIDELIZA' THEN 'DESACTIVACION' ELSE 'DATOS' END)  As Bandeja FROM Bandeja UNION SELECT idcaso As Id_caso, Estado, 'DILO' As Bandeja FROM Bandeja_alt UNION SELECT Id_Caso As Id_caso, Estado, 'DESACTIVACION' As Bandeja FROM Bandeja_Falla_Desactivacion_D_V UNION SELECT Id_caso As Id_caso, Estado, 'INBOUND' Bandeja FROM Bandeja_inbound) B ON C.caso = B.Id_caso LEFT JOIN (SELECT idcaso, 'CPD' As Escalamiento FROM clarovoz.dbo.VFallared UNION SELECT idcaso, 'SD' As Escalamiento FROM ServiceDetalle) E ON C.caso = E.idcaso WHERE ((C.Estado_Asignacion <> 'Cerrado' And C.Estado_Asignacion <> 'Asignado') OR C.Estado_Asignacion is null) And C.Usuario_Asignado IS NULL " & WHERE & ""
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
    Public Function Mis_Asignados_Control_PQR() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT CASO, PQR, CONVERT(VARCHAR(10), FECHA_INGRESO, 103) As FECHA_INGRESO, CONVERT(VARCHAR(10),FECHA_SAP, 103) As FECHA_SAP, TITULAR, MIN, B.ESTADO, B.BANDEJA FROM Control_PQR C INNER JOIN (SELECT cas_id As Id_caso, Estado, (CASE WHEN Bandeja like '%Control%' THEN 'TSF'  WHEN Bandeja LIKE 'BSCS' THEN 'BSCS' WHEN Bandeja = 'FIDELIZA' THEN 'DESACTIVACION' ELSE 'DATOS' END)  As Bandeja FROM Bandeja UNION SELECT idcaso As Id_caso, Estado, 'DILO' As Bandeja FROM Bandeja_alt UNION SELECT Id_Caso As Id_caso, Estado, 'DESACTIVACION' As Bandeja FROM Bandeja_Falla_Desactivacion_D_V UNION SELECT Id_caso As Id_caso, Estado, 'INBOUND' Bandeja FROM Bandeja_inbound) B ON C.caso = B.Id_caso WHERE C.Estado_Asignacion = 'Asignado' And C.Usuario_Asignado = @idusuario"
            cms.Parameters.Add("@idusuario", SqlDbType.VarChar, 50).Value = strlidusuario
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
    Public Function Casos_Asignados_Control_PQR() As DataSet
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) ' Conexion con la base 
        Dim dtsrecepcion As New DataSet
        Dim dtarecepcion As SqlClient.SqlDataAdapter
        Dim cms As New SqlClient.SqlCommand
        Try
            cn.Open()
            cms.CommandText = "SELECT U.nombreu As AGENTE, [CPD],[SD],[N/A], [N/A]+[CPD]+[SD] As [TOTAL] FROM (SELECT caso, Usuario_Asignado, Escalamiento FROM Control_PQR WHERE Usuario_Asignado is not null And Estado_Asignacion = 'Asignado' GROUP BY caso, Usuario_Asignado, Escalamiento) as A PIVOT (count(Caso) FOR Escalamiento in ([SD],[CPD],[N/A])) as pvt INNER JOIN usuarios U ON Usuario_Asignado = U.idusuario GROUP BY U.nombreu, [CPD],[SD],[N/A]"
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
    Public Sub Asignacion_Control_PQR()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString) ' Conexion con la base 
        Dim cms As New SqlClient.SqlCommand
        Dim num As Integer = 0
        Try
            cn.Open()
            cms.CommandText = "UPDATE Control_PQR SET Usuario_Asigna = @strlidusuario, Usuario_Asignado = @strlidusuarioasignado, Fc_Asignado = GETDATE(), Escalamiento = @Escalamiento, Estado_Asignacion = 'Asignado' WHERE CASO = @strlcaso"
            cms.Parameters.Add("@strlidusuarioasignado", SqlDbType.VarChar).Value = strlidusuarioasignado
            cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
            cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
            cms.Parameters.Add("@Escalamiento", SqlDbType.VarChar).Value = _Escalamiento_CPD_SD
            cms.Connection = cn
            num = cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cms.Parameters.Clear()
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub Liberacion_Control_PQR()
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Dim cms As New SqlClient.SqlCommand
        Dim num As Integer = 0
        Dim WHERE As String
        Try
            cn.Open()
            If strlidusuario <> Nothing Then
                WHERE = " And Usuario_Asignado = @strlidusuario"
                cms.Parameters.Add("@strlidusuario", SqlDbType.VarChar).Value = strlidusuario
                cms.Parameters.Add("@Estado", SqlDbType.VarChar).Value = "Liberado"
            ElseIf strlcaso <> Nothing Then
                WHERE = " And Caso = @strlcaso"
                cms.Parameters.Add("@strlcaso", SqlDbType.VarChar).Value = strlcaso
                cms.Parameters.Add("@Estado", SqlDbType.VarChar).Value = strlestadoinc
            Else
                WHERE = Nothing
                cms.Parameters.AddWithValue("@strlidusuario", DBNull.Value)
                cms.Parameters.AddWithValue("@Estado", DBNull.Value)
            End If
            If strlcaso <> Nothing Then
                cms.CommandText = "UPDATE Control_PQR SET Estado_Asignacion = @Estado WHERE Estado_Asignacion = 'Asignado' " & WHERE & ""
            Else
                cms.CommandText = "UPDATE Control_PQR SET Usuario_Asigna = null, Usuario_Asignado = null, Fc_Asignado = null, Escalamiento = null, Estado_Asignacion = @Estado WHERE Estado_Asignacion = 'Asignado' " & WHERE & ""
            End If
            cms.Connection = cn
            cantidad = cms.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cms.Parameters.Clear()
            If cn.State = ConnectionState.Open Then
                cn.Close()
                cms.Parameters.Clear()
            End If
        End Try
    End Sub
    Public Function Xlsx_Base_PQR_To_Datatable()
        Try
            Dim Dtt As New DataTable
            Using Con As New OleDbConnection(_ruta)
                Dim Ocm As New OleDbCommand
                Ocm.CommandText = "SELECT NRO_RADICADO,FECHA_RECIBIDO_COMCEL,FECHA_CLIENTE,TITULAR,MIN,VALOR,FORMATO FROM [Hoja1$] As Excel"
                Ocm.Connection = Con
                Dim ODta As New OleDbDataAdapter
                ODta.SelectCommand = Ocm
                ODta.Fill(Dtt)
                strlcantidad = Dtt.Rows.Count()
                Con.Close()
            End Using
            Return Dtt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Registro_Masivo_Base_PQR()
        Dim Val As String = Nothing
        Dim cn As New SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexioncontrol").ConnectionString)
        Try
            Dim Dtt As DataTable = Xlsx_Base_PQR_To_Datatable()
            Using bcp As New SqlBulkCopy(cn, SqlBulkCopyOptions.TableLock, Nothing)
                cn.Open()
                bcp.DestinationTableName = "Control_PQR"
                bcp.ColumnMappings.Add("VALOR", "CASO")
                bcp.ColumnMappings.Add("NRO_RADICADO", "PQR")
                bcp.ColumnMappings.Add("FECHA_RECIBIDO_COMCEL", "FECHA_INGRESO")
                bcp.ColumnMappings.Add("FECHA_CLIENTE", "FECHA_SAP")
                bcp.ColumnMappings.Add("TITULAR", "TITULAR")
                bcp.ColumnMappings.Add("MIN", "MIN")
                bcp.ColumnMappings.Add("FORMATO", "FORMATO")
                bcp.WriteToServer(Dtt)
            End Using
            Return Val
        Catch ex As Exception
            Throw ex
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''


End Class
