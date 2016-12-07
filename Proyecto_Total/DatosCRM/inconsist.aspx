<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="inconsist.aspx.vb" Inherits="digitacion.inconsist" %>

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
                        <div class="text-center Subtitulos">Envio de Casos a Claro</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Casos para Enviar a Claro</div>
                                    <asp:Label ID="lblcuentaaprob" CssClass="form-control" runat="server"></asp:Label>
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnguardar0" runat="server" CssClass="btn btn-primary" Text="Enviar" />
                                    </span>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form"></div>
                        </div>
                        <br />
                        <div class="Form">
                            <div class="bordes">
                                <asp:GridView ID="dtgaprobado" runat="server" AllowPaging="True" PageSize="80" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                    <Columns>
                                        <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                                        <asp:BoundField DataField="custcode_ac" HeaderText="Cust Code" />
                                        <asp:BoundField DataField="usuario_registra" HeaderText="Agente Genera Inconsistencia" />
                                        <asp:BoundField DataField="inconsistencia" HeaderText="Tipo Inconsistencia" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </div><br />
                        <div class="text-center Subtitulos">Revision de Casos</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <asp:CompareValidator runat="server" ControlToValidate="txtcaso" Display="Dynamic" Operator="DataTypeCheck" Type="Double">El caso debe ser numérico</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:TextBox ID="txtcaso" MaxLength="18" CssClass="form-control" runat="server" />
                                </div>
                                <h4></h4>
                                <asp:Button ID="btnguardar" CssClass="btn btn-primary" Text="Guardar" runat="server" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Tipificación de Revisión</div>
                                    <asp:DropDownList ID="drlestado" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="0" Text="- Seleccione -" />
                                        <asp:ListItem Text="Aprobado" />
                                        <asp:ListItem Text="Anulado" />
                                        <asp:ListItem Text="Anulado Operacion" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="Leyendas" style="font-size: 18px">
                            Casos pendientes:
                                <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                        </div>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" PageSize="80" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                <Columns>
                                    <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                                    <asp:BoundField DataField="min_ac" HeaderText="Min" />
                                    <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="obsinc" HeaderText="Observación de Inconsistencia" />
                                    <asp:BoundField DataField="inconsistencia" HeaderText="Tipo Inconsistencia" />
                                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="usuario_registra" HeaderText="Agente Genera Inconsistencia" />
                                    <asp:BoundField DataField="idusuariorep" HeaderText="Agente Reporta" />
                                    <asp:BoundField DataField="custcode_ac" HeaderText="Cust Code" />
                                    <asp:BoundField DataField="Nivel" HeaderText="Nivel" />
                                    <asp:BoundField DataField="Registro_Numerico" HeaderText="Cuenta Financiera" />
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
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>