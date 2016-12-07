<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Reporte_Diario_Auditorias.aspx.vb" Inherits="digitacion.Reporte_Diario_Auditorias" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kamilion CRM</title>
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
</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>

        <Control:Header ID="Header" runat="server" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Panel ID="Pnl_Message" runat="server">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <article>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <section>
                        <div class="text-center Subtitulos">CONSULTA AUDITORIA</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--COdigo agente--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Codigo Agente</div>
                                    <asp:TextBox ID="txt_cod_agente" runat="server" MaxLength="5" CssClass="form-control" />
                                </div>
                                <%--Campaña--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Proceso</div>
                                    <asp:DropDownList ID="drl_campaña" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                      
                                <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass=" btn btn-primary" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <%--ING--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Supervisor</div>
                                    <asp:DropDownList ID="Drl_Supervisor" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>                          
                                <%--Fechas--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Fechas</div>
                                    <asp:TextBox ID="Txt_Fc_Ini" runat="server" MaxLength="10" Placeholder="DD/MM/YYYY" CssClass="form-control Fecha" />
                                    <div class="input-group-addon">-</div>
                                    <asp:TextBox ID="Txt_Fc_Fin" runat="server" MaxLength="10" Placeholder="DD/MM/YYYY" CssClass="form-control Fecha" />
                                </div>
                            </div>
                        </div>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
            <section class="DataGrids">
            </section>
            <asp:Panel ID="PanelGestiones" runat="server">
                <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                    <ContentTemplate>
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label ID="Lbl_seguimiento" runat="server"></asp:Label>&nbsp;&nbsp;
                            <asp:Button ID="btn_exportar" runat="server" Text="Exportar" CssClass=" btn btn-primary" Visible="false" />
                        </em></h4>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="100" Width="100%"
                                Style="font-size: x-small" EnableModelValidation="True">

                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="btn_exportar" />
                    </Triggers>
                </asp:UpdatePanel>
            </asp:Panel>
            <br />
        </article>
        <footer></footer>
    </form>
</body>
</html>
