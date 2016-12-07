<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="conscentinela.aspx.vb"
    Inherits="digitacion.conscentinela" %>

<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>
<!DOCTYPE html>
<html  xmlns="http://www.w3.org/1999/xhtml">
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
            <asp:UpdatePanel runat="server" ID ="panel3">
                <ContentTemplate>
                    <asp:Panel id="Pnl_Message" runat="server">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
            <article>
                <asp:Panel ID="PnlFiltros" Visible="true" runat="server">
                    <section>
                        <div class="text-center Subtitulos">
                            Control Asistencia
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Inicio
                                            <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtfechaini" ErrorMessage="La fecha no es válida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txtfechaini" CssClass="form-control Fecha" Placeholder="DD/MM/YYYY" MaxLength="10" runat="server" Style="left: 0px; top: 0px" TabIndex="10" />
                                </div><br />
                                <asp:Button ID="BtnBusca" runat="server" CssClass="btn btn-primary" Text="Consultar" TabIndex="12" />
                                <asp:Button ID="Btnexportar" runat="server" Text="Exportar Excel" CssClass="btn btn-primary" TabIndex="13" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Cargo
                                    </div>
                                    <asp:DropDownList ID="drlcargocontrol" runat="server" CssClass="form-control" TabIndex="11">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <asp:Panel ID="Panel2" Visible="true" runat="server">
                            <div class="bordes">
                                <asp:GridView ID="DtgControl" runat="server"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True" PageSize="100" AllowPaging="true">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <Columns>
                                        <asp:BoundField DataField="fecha" HeaderText="Horario" runat="server" />
                                        <asp:ButtonField DataTextField="programado" HeaderText="Programados" CommandName="Programados" runat="server" />
                                        <asp:ButtonField DataTextField="presente" HeaderText="Presentes" CommandName="Presentes" runat="server" />
                                        <asp:ButtonField DataTextField="retardo" HeaderText="Retardos" CommandName="Retardos" runat="server" />
                                        <asp:ButtonField DataTextField="Aus. Just" HeaderText="Aus. Just" CommandName="Aus. Just" runat="server" />
                                        <asp:ButtonField DataTextField="Aus. Injus" HeaderText="Aus. Injus" CommandName="Aus. Injus" runat="server" />
                                        <asp:ButtonField DataTextField="Vacaciones" HeaderText="Vacaciones" CommandName="Vacaciones" runat="server" />
                                        <asp:ButtonField DataTextField="Total" HeaderText="Total" CommandName="Total" runat="server" />
                                    </Columns>
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </asp:Panel>
                    </section>
                </asp:Panel>
                <section>
                    <div class="text-center Subtitulos">
                        Filtros de Consulta
                    </div>
                    <div class="Form">
                        <div class="Cell-Form">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Codigo                                    
                                </div>
                                <asp:TextBox ID="txtcod" CssClass="form-control" MaxLength="7" runat="server" TabIndex="20"/>
                            </div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Fecha Inicio
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtfcini"
                                                ErrorMessage="La fecha no es válida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                </div>
                                <asp:TextBox ID="txtfcini" CssClass="form-control Fecha" Placeholder="DD/MM/YYYY" MaxLength="10" runat="server" TabIndex ="22" />
                            </div>
                            <div class="input-group">
                                <div class="input-group-addon">Horario</div>
                                <asp:DropDownList ID="drlHorario" runat="server" CssClass="form-control" TabIndex ="24">
                                </asp:DropDownList>
                            </div><br />
                              <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Consultar" TabIndex ="26"/>                                
                             <asp:Button ID="btnxls" runat="server" Text="Exportar Excel" CssClass="btn btn-primary" TabIndex ="27" />
                           </div>
                        <div class="Space-Form"></div>
                        <div class="Cell-Form">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Cargo                                    
                                </div>
                                <asp:DropDownList ID="drlcargo" runat="server" CssClass="form-control" TabIndex ="21">
                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Fecha Fin
                                     <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtfcfin"
                                         ErrorMessage="La fecha no es válida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                </div>
                                <asp:TextBox ID="txtfcfin" CssClass="form-control Fecha" Placeholder="DD/MM/YYYY" MaxLength="10" runat="server" TabIndex ="23"/>
                            </div>                             
                        </div>
                    </div>
                </section>
                <asp:Panel ID="Pnl_busqueda" Visible="true" runat="server">
                    <h4 style="color: #8F9E45; text-align: left;"><em>
                        <asp:Label ID="Label1" runat="server">Registros:&nbsp;</asp:Label>
                        <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                    </em></h4>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True" PageSize="100">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />

                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div>
                </asp:Panel>
                <br />
            </article>
        </form>
    </body>
</html>
