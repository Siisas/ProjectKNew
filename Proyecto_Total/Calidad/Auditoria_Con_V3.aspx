<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Auditoria_Con_V3.aspx.vb" Inherits="digitacion.Auditoria_Con_V3" %>
<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kamilion ERP</title>
    <link rel="icon" href="~/favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="~/favicon.ico" type="image/x-icon" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/javascript" src="../Css2/scripts.js"></script>
    <!--#########Estilos############-->
    <link type="text/css" rel="Stylesheet" href="~/Css2/Boot/css/bootstrap.min.css" />
    <link type="text/css" rel="Stylesheet" href="~/Css2/jquery-ui.css" />
    <link type="text/css" rel="Stylesheet" href="~/Css2/Kamilion.css" />
    <style type="text/css">
        .Color {
            border : 2px solid black;
            background-color: #B3C556;
            color: White;
            border-color: Black;
            border-style: solid;
            font-weight: bold;
        }

        .Sub_Tabla {
            width: 100%;
            border-color: Black;
            border-style: solid;
            text-align:center;
        }

        .td_1 {
            border-color: Black;
            border-style: solid;
            width: 30%;
        }
        .td_2 {
            border-color: Black;
            border-style: solid;
            width: 20%;
        }
        .td_3 {
            border-color: Black;
            border-style: solid;
            width: 50%;
        }
        .Sub_Tabla_td_50 {
            border-color: Black;
            border-style: solid;
            width: 50%;
        }

        .Sub_Tabla_Encabezado {
            width: 100%;
            color: Black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <Control:Header ID="Header" runat="server" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Panel ID="Pnl_Alerta" runat="server">
                    <asp:Label ID="Lbl_Alerta" runat="server"></asp:Label>
                </asp:Panel>
                <br />
                <article>
                    <section>
                        <table class="Sub_Tabla" border="1">
                            <tr>
                                <td>
                                    <table class="Sub_Tabla" border="1">
                                        <tr>
                                            <td width="40%">
                                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Css2/Imagenes/LOGO.png" Height="70px" />
                                            </td>
                                            <td width="40%">
                                                <table class="Sub_Tabla" border="2">
                                                    <tr>
                                                        <td width="40%">
                                                            <asp:Label ID="LblTitulo" runat="server" Text="SISTEMA DE GESTION DE CALIDAD"></asp:Label>
                                                        </td>
                                                        <td width="50%" class="Sub_Tabla_td_50" colspan="2">GCM-F-24
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td width="40%">
                                                            <asp:Label ID="LblTitulo1" runat="server" Text="GESTION DE CALIDAD Y MEJORA"></asp:Label>
                                                        </td>
                                                        <td class="Sub_Tabla_td_50">FECHA
                                                            <asp:Label ID="LblFecha" runat="server" Visible="True"></asp:Label>
                                                        </td>
                                                        <td class="Sub_Tabla_td_50">VERSION
                                                            1.1
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td width="40%">
                                                            <asp:Label ID="LblTitulo2" runat="server" Text="AUDITORIA"></asp:Label>
                                                        </td>
                                                        <td class="Sub_Tabla_td_50" colspan="2">Página 1 DE 1
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                    <table class="Sub_Tabla" border="2">
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">NUMERO DE CONSECUTIVO
                                            </td>
                                            <td class="Sub_Tabla_td_50" >
                                                <asp:Label ID="Lblcaso" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">NOMBRE DE INGENIERO/AGENTE DE SOPORTE
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblNomAgente" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">GRUPO
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblGrupo" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">AUDITOR
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblAuditor" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">CAMPAÑA
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblCampaña" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">PROCESO
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblProceso" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td" colspan="2">Tipo PQR</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="Lbl_Tipo_PQR" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td" colspan="2">Tipo Cliente</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="Lbl_Tipo_Cliente" runat="server"></asp:Label>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">FECHA Y HORA DE LA LLAMADA
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblFc_Llamada" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">TIEMPO ACUMULADO DE LA LLAMADA
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblTiempoAcumulado" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">CANTIDAD DE LLAMADAS AL MIN
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblCantidad_Llamadas" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">ESTADO CASO
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblEstado" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td_50" colspan="2">TIPO DE AUDITORIA
                                            </td>
                                            <td class="Sub_Tabla_td_50">
                                                <asp:Label ID="LblTipo_Auditoria" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    
                                        <tr>
                                            <td class="Color" colspan="3">Atencion
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Color td_1">ITEM
                                            </td>
                                            <td class="Color td_2">CALIFICACION
                                            </td>
                                            <td class="Color td_3">OBSERVACION
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem1" runat="server" Text="Manejo de Guion" ToolTip="Inicia la llamada de acuerdo al Script establecido. Al generar contacto con el cliente informa el motivo de la llamada, se presenta con nombre y apellido, aclarando a que tipo de servicio  se dara el soporte. Utiliza los guiones establecidos por la compañía.(saludo, despedida, captura de datos y demas), Utiliza los guiones para el manejo de etiqueta telefonica."></asp:Label>
                                                &nbsp;(MG)</td>
                                            <td >
                                                <asp:Label ID="LblManejo_Guion" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Manejo_Guion" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem2" runat="server"
                                                    ToolTip="Se afecta en los siguientes escenarios:
                        - La llamada ingresa y no es contestada inmediatamente por el consultor. (5 seg)
                        - Después de haber resuelto las consultas y validar si fueron solucionadas sus inquietudes, continua reteniendo la llamada evitando dar paso inmediato al siguiente cliente. ">Disponibilidad para Atender y Manejo de Llamada</asp:Label>
                                                &nbsp;(DLL)</td>
                                            <td >
                                                <asp:Label ID="LblDisponibilidad_Atender_Llamada" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Disponibilidad_Para_AtenderDisponibilidad_Atender_Llamada" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem3" runat="server" Text="Cordialidad y Comunicación" ToolTip="Los siguientes items se deben a tener en cuenta para la calificación:
                        - Se evidencia correcta vocalización, pronunciación, articulación, entonación e intensidad utilizando un lenguaje apropiado evitando tecnicismos o jergas inadecuadas. 
                        - Tiene fluidez verbal al dirigirse con el cliente, encontrando palabras precisas en el momento indicado.
                        - Su comunicación es grata y armoniosa, con una adecuada entonación y dicción, genera combinación de sucesos de voces y dinamismo al hablar.
                        - En las interlocuciones con el usuario solicita el nombre,  hace uso del mismo mínimo 2 veces y utiliza títulos de respeto.
                        - El trato debe ser cálido y respetuoso en todo momento. 
                        - Ingeniero de soporte debe ser  cordial y mostrar entusiasmo por atender a el cliente.
                        - Agradece los tiempos de espera
                        *Cordialidad tiene prioridad sobre comunicacion, si se afectan 2 items o mas de comunicacion se afecta la variable."></asp:Label>
                                                &nbsp;(C&amp;B)</td>
                                            <td >
                                                <asp:Label ID="lblCordialidad_Comunicacion" runat="server"></asp:Label>

                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Cordialidad_Comunicacion" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem4" runat="server" Text="Claridad al transmitir la informaciòn"
                                                    ToolTip=" - Ingeniero de soporte explica de manera clara y pausada los procedimientos y  evitando conversaciones mecánicas, cortantes y robotizadas. 
                        - Se coloca en el lugar del cliente para brindar una información coherente de principio a fin"></asp:Label>
                                                &nbsp;(CTI)</td>
                                            <td >
                                                <asp:Label ID="LblClaridad_Transmitir_Informacion" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Claridad_Transmitir_Informacion" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem5" runat="server" Text="Contacto Activo" ToolTip="Ingeniero de soporte retoma el contacto maximo cada 50 segundos."></asp:Label>
                                                &nbsp;(Cac)</td>
                                            <td >
                                                <asp:Label ID="LblContacto_Activo" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Contacto_Activo" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem6" runat="server" Text="Corona Abierta" ToolTip="Ingeniero de soporte debe realizar acompañamiento continuo para evitar que el cliente perciba ruido en el ambiente laboral durante el desarrollo de la llamada. Situaciones como: Instrucciones dentro de la operación por parte del personal administrativo, conversaciones entre consultores, digitación del teclado por tiempos extensos y otros escenarios que afecten ante el cliente el buen nombre de la compañía."></asp:Label>
                                                &nbsp;(Cab)</td>
                                            <td >
                                                <asp:Label ID="LblCorona_Abierta" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Corona_Abierta" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem7" runat="server" Text="Amabilidad y Empatia" ToolTip="Se afecta cuando se presentan interrupciones al cliente de manera continua durante la llamada, cuando se expresa con ironia, burla, frases recalcadas y demostraciones de impaciencia e intolerancia."></asp:Label>
                                                &nbsp;(A&amp;E)</td>
                                            <td >
                                                <asp:Label ID="LblAmabilidad_Empatia" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Amabilidad_Empatia" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Color" colspan="3">
                                                Gestion
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem8" runat="server" Text="Filtros y Eficiencia en la Gestion"
                                                    ToolTip="Soluciona en el menor tiempo posible y de manera eficaz la necesidad del cliente evitando ausentarse de la línea de manera injustificada,  es coherente con el tiempo de la llamada;   Indaga y realiza preguntas que lo llevan a identificar el requerimiento exacto del cliente. No consulta las herramientas disponibles para obtener informacion completa y correcta de los procedimientos y tramites."></asp:Label>
                                                &nbsp;(F&amp;EG)</td>
                                            <td >
                                                <asp:Label ID="LblFiltros_Eficiencia_Gestion" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Filtros_Eficiencia_Gestion" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem9" runat="server" Text="Interés en escuchar, entender sus necesidades y plantear soluciones"
                                                    ToolTip="Se afecta cuando el : 
                        - Ingeniero de soporte no se apersona del requerimiento.
                        - No tiene disposicion en atender al cliente.
                        - No ofrece alternativas.
                        - Remite a otra instancia teniento lo recursos para brindar la solucion."></asp:Label>
                                                &nbsp;(INT&amp;S)</td>
                                            <td >
                                                <asp:Label ID="LblInteres_Escuchar_Entender_Necesidades_Plantear_Soluciones" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Interes_Escuchar_Entender_Necesidades_Plantear_Soluciones" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem10" runat="server" Text="Escucha Activa e identidad corporativa" ToolTip="Ingeniero de soporte escucha con atención los requerimientos del cliente, evitando duplicidad de preguntas o información ya comunicadas por el mismo. Evita distraerse y mantiene el enfoque de la llamada. Evita realizar preguntas cuyas respuestas o informaciòn se encuerntra registrada en el sistema. Evita referirse a claro como un tercero."></asp:Label>
                                                &nbsp;(EA)</td>
                                            <td >
                                                <asp:Label ID="LblEscucha_Activa" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Escucha_Activa" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem11" runat="server" Text="Documentación en el sistema" ToolTip="Esta variable se afecta cuando el ingeniero de soporte: 
                        • No ingresa a las cuentas para registrar las acciones o información brindada al cliente teniendo el min o criterio de búsqueda suministrado por el cliente.
                        • Cuando deja comentarios basados en plantillas que no corresponden a la realidad.
                        • Cuando registra comentarios confusos o incompletos Vs la informado por el cliente.
                        • Cuando registra información que no puede ser comprobable.
                        • Cuando se registran comentarios sobre la actitud molesta del cliente (usuario grita, insulta, utiliza palabras soeces.), Documenta el nombre del ingeniero que tiene asignado el caso.
                        • No registra la validación de datos de la cuenta.
                        • Tipifica de manera errada la Favorabilidad del caso
                        • Cuando no tipifica de forma adecuada en los tickler en AC, PQR, Programa Uno y/o categoria SIC.
                        Documenta tecnisismos o frases incompresibles para los demas canales de atencion."></asp:Label>
                                                &nbsp;(DocS)</td>
                                            <td >
                                                <asp:Label ID="LblDocumentacion_Sistema" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Documentacion_Sistema" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem12" runat="server" Text="Cuelgue de llamada" ToolTip="ingeniero de soporte finaliza la llamada sin atender el requerimiento del cliente o permite que el cliente finalice la llamada por falta de atención (Hold o espera prolongada sin retomar la llamada).
                        Llamada se cae y no se genera la devolución en máximo 20 minutos 
                        Se identifica el cuelgue directo por parte del ingeniero de soporte."></asp:Label>
                                                &nbsp;(CLL)</td>
                                            <td >
                                                <asp:Label ID="LblCuelgue_Llamada" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Cuelgue_Llamada" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Color" colspan=" 3">
                                                Solucion
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem13" runat="server" Text="Aplicacion y manejo incompleto de Procedimientos y tramites"
                                                    ToolTip="• Consultor debe informar y aplicar de forma completa los procesos y pruebas establecidas para el tipo de falla reportado por el cliente, evitando escalamientos innecesarios a tercer nivel, procurando una respuesta de acuerdo a los lineamientos y procesos establecidos. 
                        • Cuando no captura o no toma los datos que permitan identificar la falla, dar una solucion optima o en su defecto generar el escalamiento correspondiente a el area resolutora con toda la informacion requerida. (CHEK LIST)."></asp:Label>
                                                &nbsp;(Pinc)</td>
                                            <td >
                                                <asp:Label ID="LblAplicacion_Manejo_Incompleto_Procedmientos_Tramites" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Aplicacion_Manejo_Incompleto_Procedmientos_Tramites" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem14" runat="server" Text="Aplicaciòn y manejo correcto de Procedimientos y trámites" ToolTip="• Ingeniero de soporte aplica erradamente los procesos que se encuentran plenamente definidos.
                        • Ingeniero de soporte cumple las políticas de seguridad de la compañía (realiza cambios, solicitudes, verificando datos y confirmación de titularidad o autorizaciones respectivas).
                        • Consultor debe informar y aplicar de forma correcta los procesos y pruebas establecidas para el tipo de falla reportado por el cliente, evitando escalamientos innecesarios a tercer nivel, procurando una respuesta de acuerdo a los lineamientos y procesos establecidos. 
                        • Consulta todos los aplicativos dados por la compañía para realizar el diagnóstico y suministrar una respuesta a la solicitud del cliente.
                        • No Reporta la inconsistencia identificada o reporta una inconsistencia que no aplica."></asp:Label>
                                                &nbsp;(PCorr)</td>
                                            <td >
                                                <asp:Label ID="LblAplicacion_Manejo_Correcto_Procedimientos_Tramites" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Aplicacion_Manejo_Correcto_Procedimientos_Tramites" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem15" runat="server" Text="Resoluciòn Necesidad del Cliente"
                                                    ToolTip="Ingeniero de soporte posterior al manejo del procedimiento, informaciòn y aclaraciòn, brinda soluciòn final al requerimiento inicial de la llamada.
                        Ingeniero de Soporte finaliza la llamada sin  solucionar el requerimiento del cliente (soporte posventa o fallas tecnicas).
                        Evita inducir  la insatisfacción del cliente por falta de información"></asp:Label>
                                                &nbsp;(RES)</td>
                                            <td >
                                                <asp:Label ID="LblResolucion_Necesidad_Cliente" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Resolucion_Necesidad_Cliente" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Color" colspan="3">
                                                Cierre
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem16" runat="server" Text="Procedimiento de PQR" ToolTip="Ingeniero de soporte aplica correctamente los procedimientos relacionados la radicación y el cierre de fallatec/soportec/SMS queja o tipología pqr según corresponda. informa  al cliente  y realiza lectura de términos en los casos que aplica 
                                                    • No documenta tickler términos
                                                    Cierra PQR en la base de gestión y tickler según corresponda
                                                    cumplimiento de resoluciones establecidas en la gestión por entes regulatorios."></asp:Label>
                                                &nbsp;(Ppqr)</td>
                                            <td >
                                                <asp:Label ID="LblProcedimiento_PQR" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Procedimiento_PQR" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem17" runat="server" Text="Escalamientos Requeridos" ToolTip="Ingeniero de sopote procede a escalar el caso al destino correspondiente en los escenarios que se requiera."></asp:Label>
                                                &nbsp;(Ereq)</td>
                                            <td >
                                                <asp:Label ID="LblEscalamientos_Requeridos" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Escalamientos_Requeridos" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Color" colspan="3">
                                                Estadisticas
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem18" runat="server" Text="Solucion en Primer contacto" ToolTip="Asesor logró resolver las inquietudes y peticiones del cliente de acuerdo a los procedimientos establecidos por la compañía."></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblSolucion_Primer_contacto" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Solucion_Primer_contacto" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="LblItem19" runat="server" Text="Solucion parcial" ToolTip="Ingeniero de sopote escala el caso al area correspondiente tecnica o informatica, de acuerdo a diagnostico realizado."></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblSolucion_Parcial" runat="server"></asp:Label>
                                            </td>
                                            <td >
                                                <asp:Label ID="LblObs_Solucion_Parcial" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td" colspan="3">
                                                <asp:Label ID="Label23" runat="server" Text="OBSERVACIONES GENERALES:"></asp:Label>
                                                <br />
                                                <asp:Label ID="LblObs_Generales" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        <div class="Form">
                            <div class="Cell-Form ">
                                <div class="input-group">
                                    <div class="input-group-addon">ID Registro</div>
                                    <asp:TextBox ID="TxtCod_Consulta" runat="server" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-btn">
                                        <asp:LinkButton runat="server" ID="Btn_Consultar" Font-Strikeout="false" class="btn btn-primary Desplegar_Loading">
                                            <span class="glyphicon glyphicon-search"></span> Consultar
                                        </asp:LinkButton>
                                    </span>
                                </div>
                            </div>
                            <div class=" Space-Form"></div>
                            <div class="Cell-Form "></div>
                        </div>
                        <div class="Leyendas">
                            Auditorias realizadas: <asp:Label ID="LblCuenta" runat="server"></asp:Label>
                        </div>
                    </section>
                    <div class="bordes" style="overflow:auto; min-height:0px; width:100%;">
                        <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="500" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                    </div>
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
