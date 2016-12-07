<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="modificaop.aspx.vb" Inherits="digitacion.modificaop" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Julian Castañeda  C1595--%>
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
                        <div class="text-center Subtitulos">Consultas</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Código</div>
                                    <asp:TextBox ID="txtcod" runat="server" MaxLength="5" CssClass="form-control" TabIndex="1"></asp:TextBox>
                                    <span class="input-group-btn " id="span">
                                        <asp:Button ID="btnvalidar" runat="server" Text="Validar" TabIndex="2" CssClass="btn btn-primary" />
                                    </span>
                                </div>

                                <div class="input-group">
                                    <div class="input-group-addon">Nombre</div>
                                    <asp:Label ID="lblnombre" runat="server" CssClass="form-control" TabIndex="4"></asp:Label>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Identificación</div>
                                    <asp:Label ID="lblidentif" runat="server" CssClass="form-control" TabIndex="3"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="text-center Subtitulos">Registro</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Turno
                                    </div>
                                    <asp:DropDownList ID="drlturno" runat="server" CssClass="form-control" TabIndex="5">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Mañana</asp:ListItem>
                                        <asp:ListItem>Tarde</asp:ListItem>
                                        <asp:ListItem>Noche</asp:ListItem>
                                        <asp:ListItem>Oficina</asp:ListItem>
                                        <asp:ListItem>Rota</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Observación
                                    </div>
                                    <asp:TextBox ID="txtobs" runat="server" CssClass="form-control"  TabIndex="7" TextMode="MultiLine" />

                                </div>
                                <asp:Button ID="btnguardar" runat="server" Text="Guardar" CssClass="btn btn-primary"  TabIndex="8" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Grupo
                                    </div>
                                    <asp:TextBox ID="txtgrupo" runat="server" CssClass="form-control" TabIndex="6"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="Separator "></div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo Actualización
                                    </div>
                                    <asp:DropDownList ID="drlactualizacion" runat="server" CssClass="form-control" TabIndex="9">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Compromiso de Mejora
                                    </div>
                                    <asp:TextBox ID="TxtCompromisoMejora" Enabled="False" runat="server"  TabIndex="11" CssClass="form-control" TextMode="MultiLine" />
                                </div>
                                <asp:Button ID="btnactualiza0" runat="server" Text="Registrar Histórico" CssClass="btn btn-primary" TabIndex="12" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Descripción Actualización
                                    </div>
                                    <asp:TextBox ID="txtdescripcion" TextMode="MultiLine" runat="server" CssClass="form-control" TabIndex="10"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <asp:Panel ID="dtg" runat="server" Visible="false">

                            <div class="Leyendas">
                                <asp:Label runat="server">Detalle Documental</asp:Label>&nbsp;<asp:Label ID="lblcuenta"
                                    runat="server"></asp:Label>
                            </div>
                            <div class="border">
                                <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Documento" HeaderText="Documento" />
                                        <asp:BoundField DataField="codigo" HeaderText="Código" />
                                        <asp:BoundField DataField="nombres" HeaderText="Nombre" />
                                        <asp:BoundField DataField="apellidos" HeaderText="Apellido" />
                                        <asp:BoundField DataField="nombreproyecto" HeaderText="Proyecto" />
                                        <asp:BoundField DataField="area" HeaderText="Área" />
                                        <asp:BoundField DataField="turno" HeaderText="Turno" />
                                        <asp:BoundField DataField="grupo" HeaderText="Grupo" />
                                        <asp:BoundField DataField="obs" HeaderText="Observación" />
                                    </Columns>
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </asp:Panel>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
            <%--tabla grande--%>
        </article>
        <footer></footer>
    </form>
</body>
</html>
