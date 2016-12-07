<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consfallasred.aspx.vb" Inherits="digitacion.consfallasred" %>
<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
<html>
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Kamilion ERP</title>
        <link rel="icon" href="~/favicon.ico" type="image/x-icon"/>              
        <link rel="shortcut icon" href="~/favicon.ico" type="image/x-icon"/>     
        <script type="text/javascript" src="../Css2/jquery.min.js"></script>
        <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
        <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
        <script type="text/javascript" src="../Css2/scripts.js"></script>
        <!--#########Estilos############-->
        <link type="text/css" rel="Stylesheet" href="~/Css2/Boot/css/bootstrap.min.css"/>   
        <link type="text/css" rel="Stylesheet" href="~/Css2/jquery-ui.css"/>   
        <link type="text/css" rel="Stylesheet" href="~/Css2/Kamilion.css"/>
    </head>
    <body>
        <form runat="server">
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <Control:Header ID="Header" runat="server"/>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Panel id="Pnl_Message" runat="server">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
            <article>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                    <section>
                        <div class="text-center Subtitulos">Filtros de Consulta</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Min</div>
                                    <asp:TextBox ID="txtmin" MaxLength="10" TabIndex="1" CssClass="form-control" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Cliente</div>
                                    <asp:TextBox ID="txtcliente" TabIndex="3" CssClass="form-control" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Pendiente por Escalar </div>
                                    <asp:CheckBox ID="chkpteescala" TabIndex="5" CssClass="form-control" runat="server" />
                                </div><h3></h3>
                                <asp:Button ID="Button1" TabIndex="7" CssClass="btn btn-primary" runat="server" Text="Buscar" />
                                <asp:Button ID="btnxls" TabIndex="8"  CssClass="btn btn-primary" runat="server" Text="Exportar" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:TextBox ID="txtcaso" TabIndex="2" CssClass="form-control" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Bandeja</div>
                                    <asp:DropDownList ID="drlbandeja" TabIndex="4" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Voz</asp:ListItem>
                                        <asp:ListItem>Mensajes</asp:ListItem>
                                        <asp:ListItem>Buzon</asp:ListItem>
                                        <asp:ListItem>Otros</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado CPD</div>
                                    <asp:DropDownList ID="drlestadocpd" TabIndex="6" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </section>
                    <div class="Leyendas">
                        <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                    </div>
                    <div class="bordes">
                        <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" PageSize="20" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                            <Columns>
                                <asp:BoundField DataField="campana" HeaderText="Campaña" />
                                <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                                <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="bandeja" HeaderText="Bandeja" />
                                <asp:BoundField DataField="personacontacto" HeaderText="Contacto" />
                                <asp:BoundField DataField="numcontacto" HeaderText="Tel Contacto" />
                                <asp:BoundField DataField="tipofalla" HeaderText="Tipo Falla" />
                                <asp:BoundField DataField="fcregistro" HeaderText="Fecha Reporte" />
                                <asp:BoundField DataField="idusuario" HeaderText="Agente Reporta Falla" />
                                <asp:BoundField DataField="cpd" HeaderText="CPD" />
                                <asp:BoundField DataField="fcasignado" HeaderText="Fecha Asignado" />
                                <asp:BoundField DataField="fcregcpd" HeaderText="Fecha Registra" />
                                <asp:BoundField DataField="estadocpd" HeaderText="Estado CPD" />
                                <asp:BoundField DataField="obscpd" HeaderText="Observación CPD" />
                                <asp:BoundField DataField="idusuriocpd" HeaderText="Usuario Registra CPD" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                    </div>

                    <div class="Leyendas">
                        <asp:Label ID="lblcuenta0" runat="server"></asp:Label>
                    </div>
                    <div class="bordes">
                        <asp:GridView ID="dtgseguimiento" runat="server" AllowPaging="True" PageSize="20" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                            <Columns>
                                <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                                <asp:BoundField DataField="min_ac" HeaderText="Min" />
                                <asp:BoundField DataField="fcreg" HeaderText="Fecha Seguimiento" />
                                <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                                <asp:BoundField DataField="obs" HeaderText="Observaciones" />
                                <asp:BoundField DataField="Tipificacion" HeaderText="Tipificación" />
                                <asp:BoundField DataField="numalt" HeaderText="Numero alterno" />
                                <asp:BoundField DataField="fallared" HeaderText="Falla de Red" />
                            </Columns>
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
                        <asp:PostBackTrigger ControlID="btnxls" />
                    </Triggers>
                </asp:UpdatePanel>
            </article>
            <footer></footer>
        </form>
    </body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>