<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Escalamservice.aspx.vb"
    Inherits="digitacion.Escalamservice" %>

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
                <article>
                    <section>
                        <div class="text-center Subtitulos">Escalamiento Service</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <asp:CompareValidator runat="server" ValidationGroup="btnguardar" Display="Dynamic" ControlToValidate="txtcaso" Operator="DataTypeCheck" Type="Double">El caso debe ser numérico</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:TextBox ID="txtcaso" Enabled="False" MaxLength="15" CssClass="form-control" runat="server" />
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnguardar" ValidationGroup="btnguardar" runat="server" CssClass="btn btn-primary" Text="Guardar" />
                                    </span>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Cliente</div>
                                    <asp:Label ID="lblcliente" CssClass="form-control" Style="background-color: inherit;" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Ticket</div>
                                    <asp:TextBox ID="txtcpd" CssClass="form-control" MaxLength="15" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Observación</div>
                                    <asp:TextBox ID="txtobs" CssClass="form-control" runat="server" TextMode="MultiLine" />
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Min</div>
                                    <asp:Label ID="lblmin" CssClass="form-control" Style="background-color: inherit;" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Campaña</div>
                                    <asp:Label ID="lblcampaña" CssClass="form-control" Style="background-color: inherit;" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Devolución</div>
                                    <asp:CheckBox ID="chkanula" CssClass="form-control" runat="server" />
                                </div>
                            </div>
                        </div>
                    </section><br />
                    <h4 style="color: #8F9E45;"><em>
                        <asp:Label runat="server">	Casos asignados pendientes:&nbsp;&nbsp;</asp:Label>
                        <asp:Label ID="lblcuenta" runat="server">0</asp:Label>
                    </em></h4>
                    <div class="bordes" style="overflow:auto; min-height:0px; width:100%;">
                        <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="80" Width="100%"
                            Style="font-size: x-small">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
	                            <asp:ButtonField CommandName="Seleccion" HeaderText="Selección" Text="Seleccion" />
	                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
	                            <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro" />
	                            <asp:BoundField DataField="min_ac" HeaderText="MIN" />
	                            <asp:BoundField DataField="nom_cliente" HeaderText="Cliente" />
	                            <asp:BoundField DataField="equipo_ac" HeaderText="Equipo" />
	                            <asp:BoundField DataField="Detalle" HeaderText="Tipo Falla" />
	                            <asp:BoundField DataField="apn" HeaderText="Apn" />
	                            <asp:BoundField DataField="qos" HeaderText="QoS" />
	                            <asp:BoundField DataField="fcactivacion" HeaderText="Fecha de Activación" />
	                            <asp:BoundField DataField="departamento_falla" HeaderText="Departamento" />
	                            <asp:BoundField DataField="ciudad" HeaderText="Ciudad" />
	                            <asp:BoundField DataField="idusuarioescala" HeaderText="Agente Reporte" />
	                            <asp:BoundField DataField="obsescal" HeaderText="Observación" />
	                            <asp:BoundField DataField="Bandeja" HeaderText="Bandeja" />
	                            <asp:TemplateField HeaderText="Documento">
	                                <ItemTemplate>
	                                    <asp:HyperLink ID="HyperLink2" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.archivo")%>'
	                                        NavigateUrl='<%#DataBinder.Eval(Container, "DataItem.archivo", "~/DatosCRM/data_Doc/{0}")%>'
	                                        Target='_blank'></asp:HyperLink>
	                                </ItemTemplate>
	                            </asp:TemplateField>
	                        </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                    </div>
                </article>
                <footer></footer>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>