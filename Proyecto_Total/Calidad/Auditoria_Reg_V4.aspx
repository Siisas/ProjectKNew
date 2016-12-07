<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Auditoria_Reg_V4.aspx.vb" Inherits="digitacion.Auditoria_Reg_V4" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
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
        }

        .Sub_Tabla_td {
            border-color: Black;
            border-style: solid;
        }

        .Sub_Tabla_Encabezado {
            width: 100%;
            color: Black;
        }

        .Centrar {
            text-align: center;
        }
    </style>
</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:Panel ID="PanelGeneral" runat="server">
            <Control:Header ID="Header" runat="server" />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Pnl_Message" runat="server">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </asp:Panel>

        <asp:Panel ID="Pnl_Article" Style="width: 80%; height: 100%; margin: 0px auto;" runat="server">
            <asp:Panel ID="Pnl_Section" Style="width: 75%; margin: 0px auto;" runat="server">
                <asp:UpdatePanel runat="server" ID="Panel_registro">
                    <ContentTemplate>
                        <%--/************* Ini Antigüo  ***************/--%>
                        <asp:Panel ID="Panel_registro2" runat="server">
                            <table class="Sub_Tabla" border="1">
                                <tr>
                                    <td>
                                        <table class="Sub_Tabla" border="2">
                                            <tr>
                                                <td width="65%">
                                                    <table class="Sub_Tabla_Encabezado">
                                                        <tr>
                                                            <td width="40%">
                                                                <table class="Sub_Tabla" border="0">
                                                                    <tr>
                                                                        <td width="40%">
                                                                            <center><asp:Image ID="Image1" runat="server" ImageUrl="~/Css2/Imagenes/LOGO.png" Height="70px" /></center>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                            <td width="40%">
                                                                <table class="Sub_Tabla" border="2">
                                                                    <tr>
                                                                        <td width="40%">
                                                                            <center><asp:Label ID="LblTitulo" runat="server" Text="SISTEMA DE GESTION DE CALIDAD"></asp:Label></center>
                                                                        </td>
                                                                        <td width="50%" class="Sub_Tabla_td" colspan="2">
                                                                            <center>GCM-F-24</center>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td width="40%">
                                                                            <center><asp:Label ID="LblTitulo1" runat="server" Text="GESTION DE CALIDAD Y MEJORA"></asp:Label></center>
                                                                        </td>
                                                                        <td class="Sub_Tabla_td">
                                                                            <center>FECHA</center>
                                                                            <center><asp:Label ID="LblFecha" runat="server" Visible="True"></asp:Label></center>
                                                                        </td>
                                                                        <td class="Sub_Tabla_td">
                                                                            <center>VERSION</center>
                                                                            <center>1.1</center>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td width="40%">
                                                                            <center><asp:Label ID="LblTitulo2" runat="server" Text="AUDITORIA"></asp:Label></center>
                                                                        </td>
                                                                        <td class="Sub_Tabla_td" colspan="2">
                                                                            <center>Página 1 DE 1</center>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>

                                        <table class="Sub_Tabla" border="2">
                                            <tr>
                                                <td style="width: 50%;" class="Sub_Tabla_td">NUMERO DE CONSECUTIVO
                                                <asp:RegularExpressionValidator runat="server" ValidationExpression="^[0-9]{0,17}$" ControlToValidate="txtcaso" ValidationGroup="validar">*</asp:RegularExpressionValidator>
                                                </td>
                                                <td style="width: 50%;" class="Sub_Tabla_td">
                                                    <asp:TextBox ID="txtcaso" runat="server" Width="138px" MaxLength="18"/>
                                                    <asp:Button ID="BtnValidar" runat="server" Width="77px" Text="Validar" ValidationGroup="validar" />
                                                    <asp:Label ID="Lblcaso" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">NOMBRE DE INGENIERO/AGENTE DE SOPORTE</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:DropDownList ID="drlNomAgente" Height="27px" runat="server" AutoPostBack="true"></asp:DropDownList>
                                                    <asp:Label ID="LblNomAgente" runat="server"></asp:Label>
                                                    <asp:TextBox ID="TxtConsultaCod_Agente" Width="107px" runat="server"></asp:TextBox>
                                                    <asp:Button ID="BtnConsultaAgente" runat="server" Text="Consultar" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">AUDITOR</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:Label ID="drlAuditor" runat="server" Visible="False"></asp:Label>
                                                    <asp:Label ID="drlAuditorNombre" runat="server"></asp:Label>
                                                    <asp:Label ID="LblAuditorConsulta" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">CAMPAÑA</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:Label ID="LblCampaña" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">PROCESO</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:DropDownList ID="drlProceso" Height="27px" Width="200px" runat="server"></asp:DropDownList>
                                                    <asp:Label ID="LblProceso" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">TIPO PQR</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:DropDownList ID="Drl_Tipo_PQR" Height="27px" Width="200px" runat="server">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="Drl_Tipo_PQR" ValidationGroup="VG_Guardar" InitialValue="0">*</asp:RequiredFieldValidator>
                                                    <asp:Label ID="Lbl_Tipo_PQR" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">TIPO CLIENTE</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:DropDownList ID="Drl_Tipo_Cliente" Height="27px" Width="200px" runat="server">
                                                    </asp:DropDownList>
                                                    <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="Drl_Tipo_Cliente" ValidationGroup="VG_Guardar" InitialValue="0">*</asp:RequiredFieldValidator>
                                                    <asp:Label ID="Lbl_Tipo_Cliente" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">FECHA Y HORA DE LA LLAMADA</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:TextBox ID="TxtFc_Llamada" CssClass="HoraFecha" runat="server" placeholder="DD/MM/YYYY HH:MM" Width="150px" MaxLength="10"></asp:TextBox>
                                                    <asp:RegularExpressionValidator ID="REV_Txt_Fecha_Hora_Reg" runat="server" ControlToValidate="TxtFc_Llamada" Display="Dynamic" ValidationExpression="^(0?[1-9]|[12][0-9]|3[0-1])[/](0?[1-9]|1[0-2])[/]\d\d\d\d ((0?[0-9]|1[0-9]|2[0-3]):(0?[1-9]|[1-5][0-9])|(0?[1-9]|1[0-9]|2[0-3]):(0?[0-9]|[1-5][0-9]))$">*</asp:RegularExpressionValidator>
                                                    <asp:Label ID="LblFc_Llamada" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">TIEMPO ACUMULADO DE LA LLAMADA</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:TextBox ID="TxtHora" runat="server" placeholder="HH:MM:SS" Width="150px" MaxLength="10" CssClass="HoraSegundo"></asp:TextBox>
                                                    <asp:Label ID="LblTiempoAcumulado" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">CANTIDAD DE LLAMADAS AL MIN
                                                    <asp:CompareValidator ID="CompareValidator9" Display="Dynamic" runat="server" ControlToValidate="TxtCantidad_Llamadas" ErrorMessage="Verifique el formato de la cantidad de llamadas" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator></td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:TextBox ID="TxtCantidad_Llamadas" runat="server" MaxLength="2" Width="28px"></asp:TextBox>
                                                    <asp:Label ID="LblCantidad_Llamadas" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">ESTADO CASO</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:DropDownList ID="drlEstado" Height="27px" Width="200px" runat="server"></asp:DropDownList>
                                                    <asp:Label ID="LblEstado" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">TIPO DE AUDITORIA</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:DropDownList ID="drlTipo_Auditoria" Height="27px" Width="200px" runat="server"></asp:DropDownList>
                                                    <asp:Label ID="LblTipo_Auditoria" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="Sub_Tabla" border="2">
                                            <tr style="border: solid">
                                                <td class="Color Centrar">ATENCION
                                                </td>
                                            </tr>
                                        </table>
                                        <table class="Sub_Tabla" border="2">
                                            <tr>
                                                <td width="30%" class="Color">
                                                    <center>Item</center>
                                                </td>
                                                <td width="20%" class="Color">
                                                    <center>Calificacion</center>
                                                </td>
                                                <td width="50%" class="Color">
                                                    <center>Observacion</center>
                                                </td>
                                            </tr>
                                            <%--Disponobilidad para atender la llamada--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem1" runat="server" Text="Disponibilidad para Atender la Llamada " ToolTip="Se afecta en los siguientes escenarios:
- La llamada no es atendida inmediatamente por el Ingeniero de soporte
- Después de haber resuelto las consultas y validar si fueron solucionadas sus inquietudes, continua reteniendo la llamada evitando dar paso inmediato al siguiente cliente. "></asp:Label>&nbsp;(DALL)
                                                </td>
                                                <td class="Sub_Tabla_td">
                                                    <center>
                                                    <asp:DropDownList ID="drldisponibilidad_Atender_Llamada" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="Lbldisponibilidad_Atender_Llamada" runat="server"></asp:Label>
                                                </center>
                                                </td>
                                                <td class="Sub_Tabla_td  Centrar">
                                                    <asp:TextBox ID="TxtObs_disponibilidad_Atender_Llamada" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_disponibilidad_Atender_Llamada" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Amabilidad y lenguaje apropiado--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem2" runat="server" Text="Amabilidad y lenguaje apropiado" ToolTip="Se afecta en los escenarios donde se encuentre lo siguiente: 
- Ingeniero no es cordial, le falta calidez, no muestra entusiasmo por atender o robotizado al hablarle al cliente.
- Demuestra intolerancia e impaciencia durante la conversación.
- Utiliza Tecnicismos o palabras que no son comprensibles para el cliente.
- Interrupciones  de manera continua durante la llamada sin dejar expresar o realizar preguntas al cliente.
- Cuando hay expresiones de ironía, burla y falta de respecto.
- Enfrentamientos con el cliente."></asp:Label>
                                                    &nbsp;(A&amp;LA)
                                                </td>
                                                <td class="Sub_Tabla_td  Centrar">
                                                    <asp:DropDownList ID="drlAmabilidad_lenguaje_apropiado" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblAmabilidad_lenguaje_apropiado" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td">
                                                    <center>
                                                    <asp:TextBox ID="TxtObs_Amabilidad_lenguaje_apropiado" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Amabilidad_lenguaje_apropiado" runat="server"></asp:Label>
                                                </center>
                                                </td>
                                            </tr>
                                            <%--Manejo del tiempo--%>
                                            <tr>
                                                <td class="Sub_Tabla_td  Centrar">
                                                    <asp:Label ID="LblItem3" runat="server" Text="Manejo del Tiempo" ToolTip="Se afecta cuando:
- Se ausenta de la línea de manera injustificada.
- No realiza preguntas necesarias (filtros) que lo lleva a identificar el requerimiento exacto del cliente.
- Según la falla presentada o la solicitud del cliente, en caso de requerir consulta de algún procedimiento no revisa las herramientas disponibles para obtener la información. "></asp:Label>&nbsp;(MT)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="drlManejo_Tiempo" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblManejo_Tiempo" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:TextBox ID="TxtObs_Manejo_Tiempo" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Manejo_Tiempo" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Contacto activo--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem4" runat="server" Text="Contacto Activo" ToolTip="Ingeniero de soporte retoma el contacto máximo cada 50 segundos, generando sensación de abandono y despreocupación."></asp:Label>&nbsp;(CA)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="drlContacto_Activo" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblContacto_Activo" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:TextBox ID="TxtObs_Contacto_Activo" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Contacto_Activo" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr style="border: solid">
                                                <td class="Color Centrar" colspan="3">GESTION
                                                </td>
                                            </tr>
                                            <%--Concentracion durante la llamada--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem8" runat="server" Text="Concentración Durante la Llamada" ToolTip="Escucha con atención los requerimientos del cliente, evitando duplicidad de preguntas o información ya comunicadas por el mismo. Evita distraerse y mantiene el enfoque de la llamada."></asp:Label>
                                                    &nbsp;(CDLL)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="drlConcentracion_durante_llamada" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblConcentracion_durante_llamada" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:TextBox ID="TxtObs_Concentracion_durante_llamada" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Concentracion_durante_llamada" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Procedimiento y conocimiento--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem9" runat="server" Text="Procedimientos y Conocimientos" ToolTip="•Ingeniero debe informar y aplicar de forma completa y/o correcta los procesos y pruebas establecidas para el tipo de falla reportada por el cliente, evitando escalamientos innecesarios a tercer nivel.
• En caso de requerirse debe  generar el escalamiento correspondiente al área resolutora con toda la información requerida. (CHEK LIST).
• Ingeniero de soporte debe dar cumplimiento a las políticas de seguridad de la compañía (realiza cambios o gestiona solicitudes previa confirmando de titularidad o autorizaciones respectivas).
•Si detecta alguna inconsistencia de otro canal en gestiones o escalamientos, debe reportarla."></asp:Label>
                                                    &nbsp;(PROC&amp;C)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="drlProcedimientos_conocimientos" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblProcedimientos_conocimientos" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:TextBox ID="TxtObs_Procedimientos_conocimientos" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Procedimientos_conocimientos" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr style="border: solid">
                                                <td class="Color Centrar" colspan="3">
                                                    <center>SOLUCION</center>
                                                </td>
                                            </tr>
                                            <%--Interes escuchar,entender necesidades y plantear solucion--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem13" runat="server" Text="Interés en escuchar, entender sus necesidades y plantear soluciones"
                                                        ToolTip="Se afecta cuando: 
- Ingeniero de soporte no se apersona del requerimiento, no ofrece alternativas para dar solución sobre la línea, aplicaciones o equipo celular.
- Remite a otros canales de servicio teniendo lo recursos para brindar la solución.
- No soluciona el requerimiento del clientes contando con las herramientas y procedimientos establecidos para hacerlo."></asp:Label>&nbsp;(EN&amp;PS)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">

                                                    <asp:DropDownList ID="drlInteres_Escuchar_entender_plantear_soluciones" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblInteres_Escuchar_entender_plantear_soluciones" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:TextBox ID="TxtObs_Interes_Escuchar_entender_plantear_soluciones" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Interes_Escuchar_entender_plantear_soluciones" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Cuelgue llamada--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem14" runat="server" Text="Cuelgue de Llamada"
                                                        ToolTip="Se afecta cuando:
-Ingeniero de soporte finaliza la llamada sin atender el requerimiento del cliente o permite que el cliente finalice la llamada por falta de atención (Hold o espera prolongada sin retomar la llamada).
-Llamada se cae y no se genera la devolución en máximo 20 minutos."></asp:Label>
                                                    &nbsp;(CLl)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="drlCuelgue_llamada" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblCuelgue_llamada" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:TextBox ID="TxtObs_Cuelgue_llamada" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Cuelgue_llamada" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr style="border: solid">
                                                <td class="Color Centrar" colspan="3">
                                                    <center>CIERRE</center>
                                                </td>
                                            </tr>
                                            <%--Documentacion sistema--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem16" runat="server" Text="Documentación en el Sistema" ToolTip="Se afecta cuando:
• No ingresa a las cuentas para registrar las acciones o información brindada al cliente (debe usar los criterios de búsqueda necesarios)
• Cuando utiliza plantillas para dejar comentarios que no corresponden a la realidad.
• Registra comentarios confusos usando terminología Técnica que no es comprensible para otros canales.
• Cuando  registran comentarios sobre la actitud molesta del cliente (usuario grita, insulta, utiliza palabras soeces.) o documenta el nombre del ingeniero que tiene asignado el caso.
• Tipifica de manera errada la Favorabilidad del caso dentro del aplicativo 'Gestión PQR'."></asp:Label>
                                                    &nbsp;(DS)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="drlDocumentacion_sistema" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblDocumentacion_sistema" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:TextBox ID="TxtObs_Documentacion_sistema" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Documentacion_sistema" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Finalizacion y despedida llamada--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem17" runat="server" Text="Finalización y despedida en la llamada" ToolTip="Se afecta cuando:
- Al final de la llamada, el consultor no sigue la instrucción de recordarle al cliente los cambios o las acciones que se acaban de realizar sobre la línea, las fechas a partir de las     cuales inician nuevas condiciones en caso de darse el escenario, la información brindada, petición o queja radicada según corresponda, etc.
- Cierra el caso sin garantizar la funcionalidad del servicio reportado por el cliente.
-  Codifica erradamente el motivo de llamada en la planta AVAYA y categorización errada de la SIC."></asp:Label>&nbsp;(F&amp;DLl)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="drlFinalizacion_despedida_llamada" AutoPostBack="true" Width="60%" runat="server">
                                                        <asp:ListItem>100</asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblFinalizacion_despedida_llamada" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:TextBox ID="TxtObs_Finalizacion_despedida_llamada" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Finalizacion_despedida_llamada" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr style="border: solid">
                                                <td class="Color Centrar" colspan="3">
                                                    <center>ESTADISTICAS</center>
                                                </td>
                                            </tr>
                                            <%--sOLUCION--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem18" runat="server" Text="Solución" ToolTip="Logró resolver las inquietudes y peticiones del cliente de acuerdo a los procedimientos establecidos por la compañía. Incluye escalamientos al área que corresponda, de acuerdo a diagnostico realizado."></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="DrlSolucion" Width="60%" runat="server">
                                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                                        <asp:ListItem>SI</asp:ListItem>
                                                        <asp:ListItem>NO</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblSolucion" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:TextBox ID="TxtObs_Solucion" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Solucion" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar" colspan="2">
                                                    <asp:Label ID="LblItem20" runat="server" Text="Reporta Inconsistencia" ToolTip="Realiza reporte de inconsistencia por medio de la herramienta CRM, y para los casos según corresponda también en AC.">
                                                    </asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="drlReporta_Inc" Width="60%" runat="server">
                                                        <asp:ListItem Text="- Seleccione -" />
                                                        <asp:ListItem Text="SI" />
                                                        <asp:ListItem Text="NO" />
                                                        <asp:ListItem Text="N/A" />
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblReporta_Inc" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar" colspan="2">
                                                    <asp:Label ID="Label1" runat="server" Text="Cliente Satisfecho" ToolTip="Reporte de satisfacion del cliente."></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:DropDownList ID="DrlSatisfaccion" Width="60%" runat="server">
                                                        <asp:ListItem Text="- Seleccione -" />
                                                        <asp:ListItem Text="SI" />
                                                        <asp:ListItem Text="NO" />
                                                    </asp:DropDownList>
                                                    <asp:Label ID="LblSatisfaccion" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr style="border: solid">
                                                <td class="Sub_Tabla_td Centrar" colspan="3">
                                                    <asp:Label ID="Label23" runat="server" Text="OBSERVACIONES GENERALES:"></asp:Label>
                                                    <br />
                                                    <asp:TextBox ID="TxtObs_Generales" runat="server" TextMode="MultiLine" Width="98%"></asp:TextBox>
                                                    <asp:Label ID="LblObs_Generales" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar" colspan="2">
                                                    <asp:Label ID="Label24" runat="server" Text="FIRMA DEL AUDITOR"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="Label25" runat="server" Text="FIRMA DEL CONSULTOR"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar" colspan="2">
                                                    <br />
                                                    <br />
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">&nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <%--/******************************************/--%>
                        <h3></h3>
                        <asp:Panel ID="Panel1" runat="server" Visible="False">
                            <a id="letrapeque" class="Leyendas" onclick="document.body.style.fontSize='10px';document.getElementById('Pnl_Article').style.width = '100%'; document.getElementById('Pnl_Section').style.width = '100%'; document.getElementById('letrapeque').style.display = 'none';$('.celdasder').css('width', '1%');">Presione antes de imprimir</a>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
            <asp:Panel ID="PanelConsulta" runat="server">
                <section>
                    <div class="Form">
                        <div class="Cell-Form">
                            <div class="input-group">
                                <span class="input-group-btn">
                                    <asp:Button ID="btnguardar" runat="server" Text="Guardar" CssClass="btn btn-primary" />
                                    <asp:Button ID="BtnVista" runat="server" Text="Vista para imprimir" Visible="False" />
                                </span>
                                <asp:TextBox ID="TxtCod_Consulta" CssClass="form-control" runat="server" />
                                <span class="input-group-btn">
                                    <asp:Button ID="BtnConsulta" runat="server" CssClass="btn btn-primary" Text="Consulta" />
                                </span>
                            </div>
                        </div>
                        <div class="Space-Form"></div>
                        <div class="Cell-Form"></div>
                    </div>
                    <div class="text-center Subtitulos">Consulta registros de Auditoria</div>
                    <div class="Form">
                        <div class="Cell-Form">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Codigo agente
                                    <asp:RegularExpressionValidator runat="server" ValidationExpression="^([cC]){1}([0-9]){4}$" ControlToValidate="TxtCod_Agente" ValidationGroup="Consultar">*</asp:RegularExpressionValidator>
                                </div>
                                <asp:TextBox ID="TxtCod_Agente" CssClass="form-control" runat="server" MaxLength="5" placeholder="C0001" />
                            </div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Fecha Inicio
                                    <asp:RequiredFieldValidator ControlToValidate="TxtFechaInicio" runat="server" Display="Dynamic" ValidationGroup="Consultar">*</asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="CVFechaIni" runat="server" ControlToValidate="TxtFechaInicio" Display="Dynamic" Operator="DataTypeCheck" Type="Date">Revise la fecha inicio!</asp:CompareValidator>
                                </div>
                                <asp:TextBox ID="TxtFechaInicio" CssClass="form-control Fecha" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" />
                            </div>
                            <h3></h3>
                            <asp:Button ID="BtnConsultaAditorias" CssClass="btn btn-primary" runat="server" Text="Consulta" ValidationGroup="Consultar" />
                            <asp:Button ID="BtnExporta" runat="server" CssClass="btn btn-primary" Text="Exportar" Visible="false" />
                        </div>
                        <div class="Space-Form"></div>
                        <div class="Cell-Form">
                            <div class="input-group">
                                <div class="input-group-addon">Proceso</div>
                                <asp:DropDownList ID="drlCampaña_Consulta" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Fecha Fin
                                    <asp:CompareValidator ID="CVFechaFin" runat="server" ControlToValidate="TxtFechaFin" Display="Dynamic" Operator="DataTypeCheck" Type="Date">Revise la fecha fin!</asp:CompareValidator>
                                    <asp:RequiredFieldValidator ControlToValidate="TxtFechaFin" runat="server" Display="Dynamic" ValidationGroup="Consultar">*</asp:RequiredFieldValidator>
                                </div>
                                <asp:TextBox ID="TxtFechaFin" CssClass="form-control Fecha" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" />
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="Leyendas">
                        <asp:Label ID="LblCantidad" runat="server"></asp:Label>
                    </div>
                </section>
                <div class="bordes" style="overflow: auto; min-height: 0px; width: 100%;">
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
            </asp:Panel>
        </asp:Panel>
        <footer></footer>
    </form>
</body>
</html>
