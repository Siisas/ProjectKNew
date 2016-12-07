<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultaBoldChat.aspx.vb" Inherits="digitacion.ConsultaBoldChat" %>

<%@ Register Src="~/controles/header.ascx" TagName="header" TagPrefix="control" %>

<!doctype html>
<%--    © 2016 Julian Casteleda c1595    --%>
<html>
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <title>Kamilion ERP</title>
    <link rel="icon" href="~/favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="~/favicon.ico" type="image/x-icon" />
    <script type="text/javascript" src="../css2/jquery.min.js"></script>
    <script type="text/javascript" src="../css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../css2/jquery-ui-timepiker.js"></script>
    <script type="text/javascript" src="../css2/scripts.js"></script>
    <!--#########estilos############-->
    <link type="text/css" rel="stylesheet" href="~/css2/boot/css/bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="~/css2/jquery-ui.css" />
    <link type="text/css" rel="stylesheet" href="~/css2/kamilion.css" />
</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <control:header ID="header" runat="server" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Panel ID="pnl_message" runat="server">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <article>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <section>
                        <div class="text-center Subtitulos">Consulta Casos De Bold Chat</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Min</div>
                                    <asp:TextBox ID="txtmin" runat="server" CssClass="form-control" TabIndex="1"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Cliente</div>
                                    <asp:TextBox ID="txtcliente" runat="server" CssClass="form-control" TabIndex="3"></asp:TextBox>
                                </div>
                                <asp:CompareValidator ID="comparevalidator1" runat="server" Display="Dynamic" ControlToValidate="txtfecha_inicio_recepcion" Operator="datatypecheck" Type="date">Verifique que la fecha inicio sea correcta</asp:CompareValidator>
                                <asp:CompareValidator ID="comparevalidator2" runat="server" Display="Dynamic" ControlToValidate="txtfecha_fin_recepcion" Operator="datatypecheck" Type="date">Verifique que la fecha inicio sea correcta</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Recepcion</div>
                                    <asp:TextBox ID="txtfecha_inicio_recepcion" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" TabIndex="5"></asp:TextBox>
                                    <div class="input-group-addon">-</div>
                                    <asp:TextBox ID="TxtFecha_Fin_Recepcion" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" TabIndex="6"></asp:TextBox>
                                </div>
                                <h4>
                                    <asp:Button ID="Button1" runat="server" Text="Buscar" CssClass="btn btn-primary" TabIndex="9" />
                                    <asp:Button ID="btnxls" runat="server" Text="Exportar Excel" CssClass="btn btn-primary" TabIndex="10" />
                                </h4>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:TextBox ID="txtcaso" runat="server" MaxLength="15" CssClass="form-control" TabIndex="2"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:DropDownList ID="drltipificacionll" runat="server" CssClass="form-control" TabIndex="4"></asp:DropDownList>
                                </div>
                                <asp:CompareValidator ID="CompareValidator5" runat="server" Display="Dynamic" ControlToValidate="txtfecha_inicio_gestion" Operator="DataTypeCheck" Type="Date">Verifique que la fecha inicio sea correcta</asp:CompareValidator>
                                <asp:CompareValidator ID="CompareValidator4" runat="server" Display="Dynamic" ControlToValidate="TxtFecha_Fin_Gestion" Operator="DataTypeCheck" Type="Date">Verifique que la fecha fin sea correcta</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Gestion</div>
                                    <asp:TextBox ID="txtfecha_inicio_gestion" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" TabIndex="7"></asp:TextBox>
                                    <div class="input-group-addon">-</div>
                                    <asp:TextBox ID="TxtFecha_Fin_Gestion" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" TabIndex="8"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="Leyendas" style="font-size: 16px;">
                            <asp:Panel ID="PanelDatos" runat="server" Visible="false">
                                <asp:LinkButton ID="LinkBtnDatos" CssClass="linkbutton" ForeColor="#8F9E45" runat="server">Casos Datos</asp:LinkButton>&nbsp;
                                    <asp:Label ID="lblCuentaDatos" runat="server" ForeColor="#B3C556"></asp:Label>
                            </asp:Panel>
                            <asp:Panel ID="PanelVoz" runat="server" Visible="false">
                                <asp:LinkButton ID="LinkBtnVoz" CssClass="linkbutton" ForeColor="#8F9E45" runat="server">Casos Voz</asp:LinkButton>&nbsp;
                                <asp:Label ID="lblCuentaVoz" runat="server"></asp:Label>
                            </asp:Panel>
                            <asp:Panel ID="PanelGeneral" runat="server" Visible="false">
                                <asp:LinkButton ID="LinkBtnInfBoldChat" CssClass="linkbutton" ForeColor="#8F9E45" runat="server" Text="Casos Bold Chat" />&nbsp;
                                <asp:Label ID="lblcuenta" CssClass="linkbutton" ForeColor="#8F9E45" runat="server"></asp:Label>&nbsp;&nbsp;
                                <asp:LinkButton ID="LinkBtnSeguimientoDatos" CssClass="linkbutton" ForeColor="#8F9E45" runat="server" Text="Seguimientos Datos"></asp:LinkButton>&nbsp;
                                <asp:Label ID="lblcuenta0" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:LinkButton ID="LinkBtnSeguimiento0" CssClass="linkbutton" ForeColor="#8F9E45" runat="server">Seguimientos Voz</asp:LinkButton>&nbsp;
                                <asp:Label ID="lblcuenta1" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:LinkButton ID="LinkBtnSeguimiento1" CssClass="linkbutton" ForeColor="#8F9E45" runat="server">Seguimientos General</asp:LinkButton>&nbsp;
                                <asp:Label ID="lblcuenta2" runat="server"></asp:Label>
                            </asp:Panel>
                        </div>
                    </section>
                    <div class="bordes ">
                        <asp:Panel ID="PnlBoldchat" runat="server" Visible="False">
                            <asp:GridView ID="dtgBoldChat" runat="server" AllowPaging="True"
                                AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </asp:Panel>
                        <asp:Panel ID="PnlSegumientoDatos" runat="server" Visible="false">
                            <asp:GridView ID="dtgSeguimientoDatos" runat="server" AllowPaging="True"
                                AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </asp:Panel>
                        <asp:Panel ID="PnlSeguimientoVoz" runat="server" Visible="false">
                            <asp:GridView ID="dtgSeguimientoVoz" runat="server" AllowPaging="True"
                                AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </asp:Panel>
                        <asp:Panel ID="PnlDtgInforme" runat="server" Visible="false">
                            <asp:GridView ID="DtgInforme" runat="server" AllowPaging="True"
                                AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True" Visible="False">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </asp:Panel>
                        <asp:Panel ID="PnlDatos" runat="server" Visible="false">
                            <asp:GridView ID="dtgDatos" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                Visible="False">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                                    <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha de Registro" />
                                    <asp:BoundField DataField="min_ac" HeaderText="Min" />
                                    <asp:BoundField DataField="nom_cliente" HeaderText="Cliente" />
                                    <asp:BoundField DataField="plan_acual_ac" HeaderText="Plan" />
                                    <asp:BoundField DataField="equipo_ac" HeaderText="Equipo" />
                                    <asp:BoundField DataField="telefono_contac" HeaderText="Tel Alterno" />
                                    <asp:BoundField DataField="ciudad" HeaderText="Ciudad" />
                                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="fcingn3" HeaderText="Fecha N3" />
                                    <asp:BoundField DataField="ingremite" HeaderText="Ing Remite N3" />
                                    <asp:BoundField DataField="estadon3" HeaderText="Estado N3" />
                                    <asp:BoundField DataField="fallatec" HeaderText="Fallatec" />
                                    <asp:BoundField DataField="fcsap" HeaderText="Fecha Sap" />
                                    <asp:BoundField DataField="estadofallatec" HeaderText="Estado Fallatec" />
                                </Columns>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </asp:Panel>
                        <asp:Panel ID="PnlVoz" runat="server" Visible="false">
                            <asp:GridView ID="dtgVoz" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                Visible="False">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                                    <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha de Registro" />
                                    <asp:BoundField DataField="min_ac" HeaderText="Min" />
                                    <asp:BoundField DataField="nom_cliente" HeaderText="Cliente" />
                                    <asp:BoundField DataField="equipo_ac" HeaderText="Equipo" />
                                    <asp:BoundField DataField="tipoinc" HeaderText="Tipo Inconsistencia" />
                                    <asp:BoundField DataField="bandeja" HeaderText="Bandeja" />
                                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="fallatec" HeaderText="Fallatec" />
                                    <asp:BoundField DataField="fcsap" HeaderText="Fecha Sap" />
                                    <asp:BoundField DataField="estadofallatec" HeaderText="Estado Fallatec" />
                                </Columns>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </asp:Panel>
                       </div>
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="btnxls" />
                </Triggers>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
