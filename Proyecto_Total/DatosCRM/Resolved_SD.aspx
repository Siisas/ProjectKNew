<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Resolved_SD.aspx.vb" Inherits="digitacion.Resolved_SD" %>
<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
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
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <article>
                        <section>
                            <asp:Panel ID="Panel_buscar" runat="server" Visible="true">
                            <div class="text-center Subtitulos">Consulta Casos</div>
                            <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Caso<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcaso" ErrorMessage="El caso debe ser numérico" Operator="DataTypeCheck" Type="Double" Display="Dynamic">*</asp:CompareValidator></div>
                                            <asp:TextBox ID="txtcaso" TabIndex="1" MaxLength="15" CssClass="form-control" runat="server" />
                                            <span runat="server" class="input-group-btn">
                                                <asp:Button ID="Btn_Buscar" TabIndex="2" runat="server" Text="Buscar" CssClass=" btn btn-primary" />
                                            </span>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form"></div>
                                </div>
                                </asp:Panel>
                            <div class="text-center Subtitulos">Resolved SD (INFORMATICA)</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Caso</div>
                                        <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="lbl_caso" runat="server" CssClass="form-control" Text=""></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">SD</div>
                                        <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="lbl_SD" runat="server" CssClass="form-control" Text=""></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado SD</div>
                                        <asp:DropDownList ID="Drl_Estado_Sd" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Observacion</div>
                                        <asp:TextBox ID="Txt_Observaciones" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <h4>
                                        <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" CssClass="btn btn-primary" />
                                    </h4>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Campaña</div>
                                        <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="Lbl_campaña" runat="server" CssClass="form-control" Text=""></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado</div>
                                        <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="Lbl_Estado" runat="server" CssClass="form-control" Text=""></asp:Label>
                                    </div>                             

                                    <div class="input-group">
                                        <div class="input-group-addon">Respuesta</div>
                                        <asp:TextBox ID="Txt_Respuesta" TextMode="MultiLine" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Categoria Cierre</div>
                                        <asp:DropDownList ID="drlCategoria" Enabled="false" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </section>
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label ID="Label3" Text="Casos SD (Informatica) Encontrados: " runat="server"></asp:Label>
                            <asp:Label ID="Lbl_Cuenta2" runat="server"></asp:Label>
                        </em></h4>
                        <div class="bordes">
                            <asp:GridView ID="Dtg_General" runat="server" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" 
                                Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="id_Control_Escalados_SD_CPD" HeaderText="ID" />
                                    <asp:BoundField DataField="caso" HeaderText="Caso" />
                                    <asp:BoundField DataField="tickler" HeaderText="SD" />
                                    <asp:BoundField DataField="Id_Usuario" HeaderText="Supervisor que Asigno" />
                                    <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Asignacion" />
                                    <asp:BoundField DataField="Campaña" HeaderText="Campaña" />
                                    <asp:BoundField DataField="EstadoSD" HeaderText="Estado" />
                                    <asp:ButtonField CommandName="Seleccion" HeaderText="Seleccionar" ShowHeader="True" Text="Seleccionar" />
                                </Columns>
                                <EmptyDataTemplate>
                                </EmptyDataTemplate>
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