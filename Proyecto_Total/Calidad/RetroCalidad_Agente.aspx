<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RetroCalidad_Agente.aspx.vb" Inherits="digitacion.RetroCalidad_Agente" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--    © 2016 Crisitan Duarte C1477    --%>
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

        .Alinear {
            color: #000000;
            padding-left: 20px;
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
                            <table class="Sub_Tabla" border="2">
                                <tr>
                                    <td colspan="2">
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
                                                                            <center>SISTEMA DE GESTION DE CALIDAD</center>
                                                                        </td>
                                                                        <td width="50%" class="Sub_Tabla_td" colspan="2">
                                                                            <center>GCM-F-18</center>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td width="40%">
                                                                            <center>GESTION DE CALIDAD Y MEJORA</center>
                                                                        </td>
                                                                        <td class="Sub_Tabla_td">
                                                                            <center>FECHA</center>
                                                                            <center>26-05-2014</center>
                                                                        </td>
                                                                        <td class="Sub_Tabla_td">
                                                                            <center>VERSION</center>
                                                                            <center><asp:Label ID="Lbl_Version" runat="server" Visible="True">1.1</asp:Label></center>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td width="40%">
                                                                            <center>FORMATO DE RETROALIMENTACION</center>
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
                                        <tr style="border: 3px">
                                            <td class="Color Centrar" colspan="2">INFORMACION GENERAL</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 50%;" class="Sub_Tabla_td">ID Auditoria
                                                    
                                                &nbsp;
                                                
                                                &nbsp;
                                                    <asp:Label ID="lblidaud" runat="server"></asp:Label>
                                                <asp:Label ID="Lbl_Version_Retro" Text="Version" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 50%;" class="Sub_Tabla_td">Codigo de Retroalimentación :
                                                    <asp:Label ID="Lblcodretro" runat="server" Font-Size="Small"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Fecha de Retroalimentacion</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="Lblfcretro" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Fecha de Auditoria (s)</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="Lblfcaud" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Nombre del Ingeniero / Agente de soporte</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblNomAgte" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Auditor</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblNomaud" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Campaña</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblCampa" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Area o Nivel de Gestion</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblArea" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Fecha y Hora de la llamada</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblFc_Hora_llam" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Numero de caso - MIN</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblCaso" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Estado Caso</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblEstado_Caso" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Calificacion</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblCalificacion" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Seguimiento o historico auditoria                                                    
                                            </td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblSeguimiento" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Tipo de Retroalimentación</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="LblTipoRetro" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td">Tiempo de Retroalimentación</td>
                                            <td class="Sub_Tabla_td">
                                                <asp:Label ID="Lbltiemporetroalimentacion" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="Color Centrar" colspan="2">CAUSAS DE RETROALIMENTACION</td>
                                        </tr>
                                        <tr>
                                            <td width="50%" class="Color">
                                                <center>Parametro</center>
                                            </td>
                                            <td width="50%" class="Color">
                                                <center>Observacion</center>
                                            </td>
                                        </tr>
                                        <asp:Panel ID="PnlParametros" runat="server">
                                            <%--Parametro 1--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblParametro" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblObservacion" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Parametro 2--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblParametro0" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td  Centrar">
                                                    <asp:Label ID="LblObservacion0" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Parametro 3--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblParametro1" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td  Centrar">
                                                    <asp:Label ID="LblObservacion1" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Parametro 4--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblParametro2" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblObservacion2" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <%--Parametro 5--%>
                                            <tr>
                                                <td class="Sub_Tabla_td Centrar">
                                                    <asp:Label ID="LblParametro3" runat="server"></asp:Label>
                                                </td>
                                                <td class="Sub_Tabla_td  Centrar">
                                                    <asp:Label ID="LblObservacion3" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </asp:Panel>
                                        <asp:Panel ID="PnlItems" runat="server">
                                            <%--NIVEL DE PERCEPCION--%>
                                            <tr>
                                                <td class="Color Centrar" colspan="2">NIVEL DE PERCEPCION</td>
                                            </tr>
                                            <tr>
                                                <%--Item 1--%>
                                                <td class="Sub_Tabla_td Alinear">1. Presta atención a la información suministrada:       
                                                    <asp:Label ID="lblitem1" runat="server" />
                                                </td>
                                                <%--Item 2--%>
                                                <td class="Sub_Tabla_td Alinear">2. Entiende claramente los parámetros a mejorar:     
                                                    <asp:Label ID="lblitem2" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <%--Item 3--%>
                                                <td class="Sub_Tabla_td Alinear">3. El compromiso es coherente con las observaciones realizada:        
                                                    <asp:Label ID="lblitem3" runat="server" />
                                                </td>
                                                <%--Item 4--%>
                                                <td class="Sub_Tabla_td Alinear">4. Es receptivo al cambio y la mejora continua: 
                                                    <asp:Label ID="lblitem4" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <%--Item 5--%>
                                                <td class="Sub_Tabla_td Alinear">5. Ingeniero escucha grabacion:                                              
                                                    <asp:Label ID="lblitem5" runat="server" />
                                                </td>
                                                <%--Resultado--%>
                                                <td class="Sub_Tabla_td Alinear">Resultado:      
                                                    <asp:Label ID="lblresultado" runat="server" />
                                                </td>
                                            </tr>
                                        </asp:Panel>
                                        <%--Observacion de la persona que realiza la Retroalimentacion--%>
                                        <tr>
                                            <td class="Color Centrar" colspan="2">OBSERVACION DE LA PERSONA QUE REALIZA LA RETROALIMENTACION</td>
                                       </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td Centrar" colspan="2">
                                                <asp:Label ID="LblObservacionP" runat="server"></asp:Label>
                                                <br />
                                            </td>
                                        </tr>
                                        <%--Compromiso del Agente/Ingeniero--%>
                                        <tr>
                                            <td class="Color Centrar" colspan="2">COMPROMISO DEL AGENTE/INGENIERO</td>                                          
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td Centrar" colspan="2">
                                                <asp:Label ID="LblCompromiso" runat="server"></asp:Label>
                                                <br />
                                            </td>
                                        </tr>
                                        <%--Conclusion final y/o Plan de Accion a ejecutar--%>
                                        <tr>
                                            <td class="Color Centrar" colspan="2">
                                            CONCLUSION FINAL Y/O PLAN DE ACCION A EJECUTAR
                                        </tr>
                                        <tr>
                                            <td class="Sub_Tabla_td Centrar" colspan="2">
                                                <asp:Label ID="LblConclusionF" runat="server"></asp:Label>
                                                <br />
                                            </td>
                                        </tr>
                                    </td>
                                </tr>                           
                            </table>
                        </asp:Panel>
                        <%--/******************************************/--%>
                        <h3></h3>
                        <asp:Panel ID="Panel1" runat="server" Visible="false">
                            <a id="letrapeque" class="Leyendas" onclick="document.body.style.fontSize='10px';document.getElementById('Pnl_Article').style.width = '100%'; document.getElementById('Pnl_Section').style.width = '100%'; document.getElementById('letrapeque').style.display = 'none';$('.celdasder').css('width', '1%');">Presione antes de imprimir</a>
                        </asp:Panel>
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
                    <asp:GridView ID="dtgConsultas" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                        <Columns>
                            <asp:ButtonField ButtonType="Link" ControlStyle-CssClass="btn btn-primary  glyphicon glyphicon-eye-open" ControlStyle-Height="25px" ControlStyle-Font-Size="12px" ControlStyle-ForeColor="White" CommandName="Seleccionar" />
                        </Columns>
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
