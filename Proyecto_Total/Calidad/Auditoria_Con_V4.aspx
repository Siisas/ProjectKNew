<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Auditoria_Con_V4.aspx.vb" Inherits="digitacion.Auditoria_Con_V4" %>

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
                                                </td>
                                                <td style="width: 50%;" class="Sub_Tabla_td">
                                                    <asp:Label ID="Lblcaso" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">NOMBRE DE INGENIERO/AGENTE DE SOPORTE</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:Label ID="LblNomAgente" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">AUDITOR</td>
                                                <td class="Sub_Tabla_td">
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
                                                    <asp:Label ID="LblProceso" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">TIPO PQR</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:Label ID="Lbl_Tipo_PQR" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">TIPO CLIENTE</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:Label ID="Lbl_Tipo_Cliente" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">FECHA Y HORA DE LA LLAMADA</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:Label ID="LblFc_Llamada" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">TIEMPO ACUMULADO DE LA LLAMADA</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:Label ID="LblTiempoAcumulado" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">CANTIDAD DE LLAMADAS AL MIN</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:Label ID="LblCantidad_Llamadas" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">ESTADO CASO</td>
                                                <td class="Sub_Tabla_td">
                                                    <asp:Label ID="LblEstado" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td">TIPO DE AUDITORIA</td>
                                                <td class="Sub_Tabla_td">
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
                                                    <asp:Label ID="Lbldisponibilidad_Atender_Llamada" runat="server"></asp:Label>
                                                </center>
                                                </td>
                                                <td class="Sub_Tabla_td  Centrar">
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
                                                    <asp:Label ID="LblAmabilidad_lenguaje_apropiado" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td">
                                                    <center>
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
                                                    <asp:Label ID="LblManejo_Tiempo" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblObs_Manejo_Tiempo" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Contacto activo--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem4" runat="server" Text="Contacto Activo" ToolTip="Ingeniero de soporte retoma el contacto máximo cada 50 segundos, generando sensación de abandono y despreocupación."></asp:Label>&nbsp;(CA)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblContacto_Activo" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
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
                                                    <asp:Label ID="LblConcentracion_durante_llamada" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblObs_Concentracion_durante_llamada" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Procedimiento y conocimiento--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem9" runat="server" Text="Procedimientos y Conocimientos" ToolTip="•Ingeniero debe informar y aplicar de forma completa y/o correcta los procesos y pruebas establecidas para el tipo de falla reportada por el cliente, evitando escalamientos innecesarios a tercer nivel.
• En caso de requerirse debe  generar el escalamiento correspondiente al área resolutora con toda la información requerida. (CHEK LIST).
• Ingeniero de soporte debe dar cumplimiento a las políticas de seguridad de la compañía (realiza cambios o gestiona solicitudes previa confirmando de titularidad o autorizaciones respectivas).
• Si detecta alguna inconsistencia de otro canal en gestiones o escalamientos, debe reportarla."></asp:Label>
                                                    &nbsp;(PROC&amp;C)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblProcedimientos_conocimientos" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
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
                                                    <asp:Label ID="LblInteres_Escuchar_entender_plantear_soluciones" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
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
                                                    <asp:Label ID="LblCuelgue_llamada" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
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
                                                    <asp:Label ID="LblDocumentacion_sistema" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblObs_Documentacion_sistema" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Finalizacion y despedida llamada--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblItem17" runat="server" Text="Finalización y despedida en la llamada" ToolTip="Se afecta cuando:
- Al final de la llamada, el consultor no sigue la instrucción de recordarle al cliente los cambios o las acciones que se acaban de realizar sobre la línea, las fechas a partir de las     cuales inician nuevas condiciones en caso de darse el escenario, la información brindada, petición o queja radicada según corresponda, etc.
- Cierra el caso sin garantizar la funcionalidad del servicio reportado por el cliente.
- Codifica erradamente el motivo de llamada en la planta AVAYA y categorización errada de la SIC."></asp:Label>&nbsp;(F&amp;DLl)
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblFinalizacion_despedida_llamada" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
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
                                                    <asp:Label ID="LblSolucion" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblObs_Solucion" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar" colspan="2">
                                                    <asp:Label ID="LblItem20" runat="server" Text="Reporta Inconsistencia" ToolTip="Realiza reporte de inconsistencia por medio de la herramienta CRM, y para los casos según corresponda también en AC.">
                                                    </asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblReporta_Inc" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar" colspan="2">
                                                    <asp:Label ID="Label1" runat="server" Text="Cliente Satisfecho" ToolTip="Reporte de satisfacion del cliente."></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblSatisfaccion" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr style="border: solid">
                                                <td class="Sub_Tabla_td Centrar" colspan="3">
                                                    <asp:Label ID="Label23" runat="server" Text="OBSERVACIONES GENERALES:"></asp:Label>
                                                    <br />
                                                    <asp:Label ID="LblObs_Generales" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <%--/******************************************/--%>
                        <h3></h3>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
            <asp:Panel ID="PanelConsulta" runat="server">
                <section>
                    <br />
                    <div class="Leyendas">
                        <asp:Label ID="LblCantidad" runat="server"></asp:Label>
                    </div>
                </section>
                <div class="bordes" style="overflow: auto; min-height: 0px; width: 100%;">
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="500" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccione" ShowHeader="True" HeaderText="Buscar" ></asp:ButtonField>
                        </Columns>

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