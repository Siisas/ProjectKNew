<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Consulta_inbound.aspx.vb" Inherits="digitacion.Consulta_inbound" %>

<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>

<!DOCTYPE html>
<html>
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Kamilion CRM</title>
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
                        <div class="text-center Subtitulos">Consulta General</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                    <%--Caso--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Caso
                                        <asp:CompareValidator runat="server" ControlToValidate="txtcaso" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" />
                                    </div>
                                    <asp:TextBox ID="txtcaso" MaxLength="25" CssClass="form-control" runat="server" />
                                </div>
                                      <%--Id avaya--%>
                                <div class="input-group">
                                    <div class="input-group-addon">ID Avaya
                                        <asp:CompareValidator runat="server" ControlToValidate="txt_idavaya" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" />
                                    </div>
                                    <asp:TextBox ID="txt_idavaya" MaxLength="25" CssClass="form-control" runat="server" />
                                </div>
                                 <%--Campaña--%>
                                  <div class="input-group">
                                    <div class="input-group-addon">Campaña</div>
                                    <asp:DropDownList ID="drlcampaña" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                              

                               <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass=" btn btn-primary" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                    <%--MIN--%>
                                <div class="input-group">
                                    <div class="input-group-addon">MIN
                                        <asp:CompareValidator runat="server" ControlToValidate="txt_min" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" />
                                    </div>
                                    <asp:TextBox ID="txt_min" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                </div>
                                       <%--Estado--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:DropDownList ID="drl_estado" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                                 <%--Fechas--%>
                                 <div class="input-group">
                                    <div class="input-group-addon">Fecha Ingreso</div>
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
                        <asp:Panel ID="PanelGeneral" runat="server">
                            <asp:UpdatePanel ID="UpdatePanelCasosProgramados" runat="server">
                                <ContentTemplate>
                                    <h4 style="color: #8F9E45;"><em> 
                                        <asp:Label ID="LblCuentaAsignados" runat="server"></asp:Label>
                                    </em></h4>
                                    <div class="bordes" style="overflow:auto; min-height:0px; width:100%;">
                                        <asp:GridView ID="dtgbandeja" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="500" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True">
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
                            </asp:UpdatePanel>
                        </asp:Panel>
                        <br />
                <section class="DataGrids">
                    </section>
                        <asp:Panel ID="PanelGestiones" runat="server">
                            <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                <ContentTemplate>        
                                       <h4 style="color: #8F9E45;"><em> 
                                        <asp:Label ID="Lbl_seguimiento" runat="server"></asp:Label>
                                    </em></h4>                    
                                    <div class="bordes">
                                        <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                            CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="500" Width="100%"
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
                            </asp:UpdatePanel>
                        </asp:Panel>
                        <br />
            </article>
            <footer></footer>
        </form>
    </body>
</html>