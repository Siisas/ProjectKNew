<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consinc.aspx.vb" Inherits="digitacion.consinc" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
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
                        <div class="text-center Subtitulos">Consulta</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Estado Inconsistencia
                                    </div>
                                    <asp:DropDownList ID="drlestado" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Reportado</asp:ListItem>
                                        <asp:ListItem>Aprobado</asp:ListItem>
                                        <asp:ListItem>Anulado</asp:ListItem>
                                        <asp:ListItem>Enviado</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha de Registro Desde
                                    </div>
                                    <asp:TextBox ID="txtfcdesde" runat="server" CssClass="form-control Fecha" />

                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Nivel
                                    </div>
                                    <asp:DropDownList ID="drlnivel" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Call</asp:ListItem>
                                        <asp:ListItem>Operacion</asp:ListItem>
                                        <asp:ListItem>Call/Operac</asp:ListItem>
                                    </asp:DropDownList>
                                </div><h4></h4>
                                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Buscar" />
                                <asp:Button ID="btnxls" runat="server" CssClass="btn btn-primary" Text="Exportar Excel" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Caso
                                    </div>
                                    <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha de Registro Hasta
                                    </div>
                                    <asp:TextBox ID="txtfchasta" runat="server" CssClass="form-control Fecha"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <asp:GridView ID="dtgxls" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="1000" Width="100%" Style="font-size: x-small"
                            Visible="False">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                                <asp:BoundField DataField="min_ac" HeaderText="Min" />
                                <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="obsinc" HeaderText="Observación de Inconsistencia" />
                                <asp:BoundField DataField="inconsistencia" HeaderText="Tipo Inconsistencia" />
                                <asp:BoundField DataField="custcode_ac" HeaderText="Cust Code" />
                                <asp:BoundField DataField="estado" HeaderText="Estado" />
                                <asp:BoundField DataField="usuario_registra" HeaderText="Agente Genera Inconsistencia" />
                                <asp:BoundField DataField="estadoinc" HeaderText="Estado Inconsistencia" />
                                <asp:BoundField DataField="idusuariorep" HeaderText="Agente Reporta" />
                                <asp:BoundField DataField="fcreg" HeaderText="Fecha Reporte" />
                                <asp:BoundField DataField="idusuariorev" HeaderText="Usuario Revisa" />
                                <asp:BoundField DataField="fcrev" HeaderText="Fecha Revisión" />
                                <asp:BoundField DataField="idusuarioenv" HeaderText="Usuario Envia" />
                                <asp:BoundField DataField="fcenvio" HeaderText="Fecha Envío" />
                                <asp:BoundField DataField="nivel" HeaderText="Nivel" />
                                <asp:BoundField DataField="Bandeja" HeaderText="Bandeja" />
                            </Columns>
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                    </section>
                    <asp:Panel ID="PnlGeneral" runat="server" Visible="false">
                        <div class="Leyendas">
                            <asp:Label runat="server">Detalle Documental</asp:Label>&nbsp;
                            <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                        </div>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" PageSize="100" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                <Columns>
                                    <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                                    <asp:BoundField DataField="min_ac" HeaderText="Min" />
                                    <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="obsinc" HeaderText="Observación de Inconsistencia" />
                                    <asp:BoundField DataField="inconsistencia" HeaderText="Tipo Inconsistencia" />
                                    <asp:BoundField DataField="custcode_ac" HeaderText="Cust Code" />
                                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="usuario_registra" HeaderText="Agente Genera Inconsistencia" />
                                    <asp:BoundField DataField="estadoinc" HeaderText="Estado Inconsistencia" />
                                    <asp:BoundField DataField="idusuariorep" HeaderText="Agente Reporta" />
                                    <asp:BoundField DataField="fcreg" HeaderText="Fecha Reporte" />
                                    <asp:BoundField DataField="idusuariorev" HeaderText="Usuario Revisa" />
                                    <asp:BoundField DataField="fcrev" HeaderText="Fecha Revisión" />
                                    <asp:BoundField DataField="idusuarioenv" HeaderText="Usuario Envia" />
                                    <asp:BoundField DataField="fcenvio" HeaderText="Fecha Envío" />
                                    <asp:BoundField DataField="nivel" HeaderText="Nivel" />
                                    <asp:BoundField DataField="Bandeja" HeaderText="Bandeja" />
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