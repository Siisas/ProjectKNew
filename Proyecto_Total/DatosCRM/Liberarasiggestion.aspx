<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Liberarasiggestion.aspx.vb"
    Inherits="digitacion.Liberarasiggestion" %>

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
                        <asp:Label ID="Label1" runat="server" Text="*Recuerde que se van a liberar los casos que se muestren en la tabla inferior*" Font-Size="Small" ForeColor="#B3C556"></asp:Label>
                        <div class="btn-group btn-group-justified">
                            <div class="btn-group">
                                <asp:Button ID="Btn_Panel_Datos" CssClass="btn btn-primary" Text="DATOS" runat="server" />
                            </div>
                            <div class="btn-group">
                                <asp:Button ID="Btn_Panel_BSCS" CssClass="btn btn-primary" Text="BSCS" runat="server" />
                            </div>
                            <div class="btn-group">
                                <asp:Button ID="Btn_Panel_Dilo" CssClass="btn btn-primary" Text="DILO" runat="server" />
                            </div>
                            <div class="btn-group">
                                <asp:Button ID="Btn_Panel_Desact" CssClass="btn btn-primary" Text="DESACTIVACION" runat="server" />
                            </div>
                            <div class="btn-group">
                                <asp:Button ID="Btn_Panel_Inbound" CssClass="btn btn-primary" Text="INBOUND" runat="server" />
                            </div>
                        </div>
                        <div class="text-center Subtitulos">
                            <asp:Label ID="lblcampaña" runat="server" Text="FILTROS PARA LIBERACION - DATOS"></asp:Label>
                        </div>
                        <div class="Form">
                            <div class="input-group">
                                <asp:Label ID="Label2" runat="server" Text="Liberacion Masiva" Font-Size="Large" ForeColor="#B3C556"></asp:Label>
                            </div>
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Campaña</div>
                                    <asp:DropDownList ID="drl_Campaña" runat="server" AutoPostBack="True" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione -" />
                                        <asp:ListItem Value="1" Text="Datos" />
                                        <asp:ListItem Value="2" Text="PQR" />
                                        <asp:ListItem Value="3" Text="Sin Formato" />
                                        <asp:ListItem Value="4" Text="BSCS" />
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:DropDownList ID="drlestadomas" runat="server" AutoPostBack="True" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione -" />
                                        <asp:ListItem Value="1" Text="Manual" />
                                        <asp:ListItem Value="2" Text="Seguimiento" />
                                        <asp:ListItem Value="3" Text="Reincidente" />
                                    </asp:DropDownList>
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnbuscarmas" runat="server" CssClass="btn btn-primary" Text="Buscar" />
                                    </span>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Marcacion</div>
                                    <asp:DropDownList ID="drl_Marcacion" runat="server" AutoPostBack="True" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione -" />
                                        <asp:ListItem Value="1" Text="Manual" />
                                        <asp:ListItem Value="2" Text="Seguimiento" />
                                        <asp:ListItem Value="3" Text="Reincidente" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="Separator "></div>
                        <div class="Form">
                            <div class="input-group">
                                <asp:Label ID="Label3" runat="server" Text="Liberacion individual" Font-Size="Large" ForeColor="#B3C556"></asp:Label>
                            </div>
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Campaña</div>
                                    <asp:DropDownList ID="drl_campaña_indivi" runat="server" AutoPostBack="True" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione -" />
                                        <asp:ListItem Value="1" Text="Datos" />
                                        <asp:ListItem Value="2" Text="PQR" />
                                        <asp:ListItem Value="3" Text="Sin Formato" />
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Ingeniero</div>
                                    <asp:DropDownList ID="drlusuario" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Caso individual</div>
                                    <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <br />
                                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Buscar" Style="border-right: 50px" />&nbsp;&nbsp;
                                <asp:Button ID="btnLiberaMasiva" runat="server" CssClass="btn btn-primary" Text="Liberacion Masiva" />
                                <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" Visible="false" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Marcacion</div>
                                    <asp:DropDownList ID="Drl_Marcacion_individual" runat="server" AutoPostBack="True" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione -" />
                                        <asp:ListItem Value="1" Text="Manual" />
                                        <asp:ListItem Value="2" Text="Seguimiento" />
                                        <asp:ListItem Value="3" Text="Reincidente" />
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:DropDownList ID="drlEstado" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Cantidad casos a liberar</div>
                                    <asp:TextBox ID="txtcantidadcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <asp:Panel ID="Panel_Tabla" runat="server" Visible="false">
                            <br />
                            <h4><em style="color: #8F9E45">Asignados: </em>
                                <asp:Label ID="lblcantidad" runat="server" ForeColor="#8F9E45"></asp:Label>
                            </h4>
                            <div class="bordes">
                                <div class="Grid-All-Sub-Container">
                                    <div class="Grid-Container">
                                        <asp:GridView ID="dtggeneral" runat="server" Width="100%" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" Style="font-size: x-small" EnableModelValidation="True">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>