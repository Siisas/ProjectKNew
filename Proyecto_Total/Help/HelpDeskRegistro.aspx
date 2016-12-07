<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HelpDeskRegistro.aspx.vb" Inherits="digitacion.HelpDeskRegistro" %>

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
    <script>
        /***********************************/
        /*Esto gestiona los desplegables*/
        /*********************************/
        function Chang_Panel1() {
            if ($_$("#PanelRegistro").is(":visible")) {
            } else {
                PlegDes_Dinamico("#PanelRegistro", "slide", '', '', '');
                PlegDes_Dinamico(".PaneldeConsultas", "slide", '', '', '');
            }
        };
        function Chang_Panel2() {
            if ($_$(".PaneldeConsultas").is(":visible")) {
            } else {
                PlegDes_Dinamico(".PaneldeConsultas", "slide", '', '', '');
                PlegDes_Dinamico("#PanelRegistro", "slide", '', '', '');
            }
        };
        /***************************************/
        /**************************************/
    </script>
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
        <div class="Desplegable" id="Desp_Calif">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="Form-Mini-Desp">
                        <div class="text-center Subtitulos">Calificar desarrollo</div>
                        <div class="input-group">
                            <div class="input-group-addon">Calificación<asp:RequiredFieldValidator ID="RFV_Drl_Calificacion" Display="Dynamic" ValidationGroup="VG_Calificar" InitialValue="0" runat="server" ControlToValidate="Drl_Calificacion">*</asp:RequiredFieldValidator></div>
                            <asp:DropDownList ID="Drl_Calificacion" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">Observación<asp:RegularExpressionValidator ID="REV_Txb_Observacion" ValidationGroup="VG_Calificar" runat="server" Display="Dynamic" ControlToValidate="Txb_Observacion" ValidationExpression="^.{5,100}$">*</asp:RegularExpressionValidator><asp:RequiredFieldValidator ID="RFV_Txb_Observacion" Display="Dynamic" ValidationGroup="VG_Calificar" runat="server" ControlToValidate="Txb_Observacion">*</asp:RequiredFieldValidator></div>
                            <asp:TextBox ID="Txb_Observacion" runat="server" ToolTip="la obervación debe tener de 5 a 100 caracteres" TextMode="MultiLine" CssClass="form-control" MaxLength="5"></asp:TextBox>
                        </div>
                        <asp:Button runat="server" ID="Btn_Calificar" Text="Calificar" ValidationGroup="VG_Calificar" CssClass=" btn btn-primary" />
                        <input value="Cancelar" class="Desplegar btn btn-primary" type="button" id="Plegar_Form_Calif" />
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <br />
        <article>
            <section>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="btn-group btn-group-justified">
                            <div class="btn-group">
                                <asp:Button ID="BtnNuevoTicket" OnClientClick="Chang_Panel1()" runat="server" Text="Registrar Ticket" CssClass="btn btn-primary" />
                            </div>
                            <div class="btn-group">
                                <asp:Button ID="BtnConsultaTicket" OnClientClick="Chang_Panel2()" runat="server" Text="Consultar Ticket" CssClass="btn btn-primary" />
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:Panel ID="PanelRegistro" runat="server">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div class="text-center Subtitulos">Registro</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Tema</div>
                                        <asp:TextBox ID="TxtTema" TabIndex="1" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Prioridad</div>
                                        <asp:DropDownList ID="drlPrioridad" TabIndex="3" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            <asp:ListItem>Bajo</asp:ListItem>
                                            <asp:ListItem>Medio</asp:ListItem>
                                            <asp:ListItem>Alto</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-addon">Letra del Modulo</div>
                                            <asp:DropDownList ID="drlLetraModulo" TabIndex="5" runat="server" CssClass="form-control">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>A</asp:ListItem>
                                                <asp:ListItem>B</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                                <asp:ListItem>D</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Area</div>
                                        <asp:DropDownList ID="drlArea" TabIndex="7" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                    <h4></h4>
                                    <asp:Button ID="BtnEnviar" runat="server" TabIndex="9" CssClass="btn btn-primary Desplegar_Loading" Text="Enviar" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Observación</div>
                                        <asp:TextBox ID="txtObservacion" TabIndex="2" runat="server" CssClass="form-control" Height="45px" MaxLength="250" TextMode="MultiLine" Width="99%"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Canal</div>
                                        <asp:DropDownList ID="drlCanal" TabIndex="4" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Numero del Modulo<asp:RegularExpressionValidator runat="server" Display="Dynamic" ControlToValidate="TxtNumeroModulo" SetFocusOnError="True" ValidationExpression="^[0-9\s]{0,100}$">*</asp:RegularExpressionValidator></div>
                                        <asp:TextBox ID="TxtNumeroModulo" TabIndex="6" runat="server" CssClass="form-control" MaxLength="3"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Persona Reporta</div>
                                        <asp:TextBox ID="TxtPersona_Reporta" TabIndex="8" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
                <asp:Panel ID="PanelConsulta" runat="server" Style="display: none;" CssClass="PaneldeConsultas">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div class="text-center Subtitulos">Tickets Existentes</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Inicio<asp:CompareValidator ID="CV_TxtFecha_Inicio" Display="Dynamic" ValidationGroup="VG_Consultar" runat="server" ControlToValidate="TxtFecha_Inicio" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator></div>
                                        <asp:TextBox ID="TxtFecha_Inicio" TabIndex="10" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Codigo Ticket<asp:CompareValidator ID="CV_TxtCodTicket" Display="Dynamic" ValidationGroup="VG_Consultar" runat="server" ControlToValidate="TxtCodTicket" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator></div>
                                        <asp:TextBox ID="TxtCodTicket" TabIndex="12" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>                                    
                                    <h4></h4>
                                    <asp:Button ID="btnConsultaCaso" TabIndex="13" runat="server" CssClass="btn btn-primary Desplegar_Loading" Text="Buscar" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Fin<asp:CompareValidator ID="CV_TxtFecha_Ini" Display="Dynamic" ValidationGroup="VG_Consultar" runat="server" ControlToValidate="TxtFecha_Fin" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator></div>
                                        <asp:TextBox ID="TxtFecha_Fin" TabIndex="11" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
            </section>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Panel ID="PanelConsulta2" runat="server" Visible="False" CssClass="PaneldeConsultas">
                        <div class="Leyendas ">
                            <asp:Label ID="Label7" runat="server">Numero de Ticket: </asp:Label>
                            <asp:Label ID="lblCuentaTicket" runat="server">0</asp:Label>
                        </div>
                        <div class="bordes">
                            <asp:GridView ID="dtgTicket" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_HelpDesk_Registro" HeaderText="Codigo" />
                                    <asp:BoundField DataField="Fecha_Registro" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" />
                                    <asp:BoundField DataField="Tema" HeaderText="Tema" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observación" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="Canal" HeaderText="Canal" />
                                    <asp:BoundField DataField="Persona_Reporta" HeaderText="Reporta" />
                                    <asp:BoundField DataField="Modulo" HeaderText="Modulo" />
                                    <asp:BoundField DataField="Area" HeaderText="Area" />
                                    <asp:BoundField DataField="Asigna" HeaderText="Asigna" />
                                    <asp:BoundField DataField="Fecha_Asigna" HeaderText="Fecha Asigna" />
                                    <asp:BoundField DataField="ObservacionAsigna" HeaderText="Observacion Asigna" />
                                    <asp:BoundField DataField="Calificacion" HeaderText="Calificación" />
                                    <asp:BoundField DataField="Observacion_Calificador" HeaderText="Observación" />
                                    <asp:ButtonField CommandName="Calificar" HeaderText="Calificar" Text="Calificar" />
                                </Columns>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div>
                        <div class="Leyendas ">
                            <asp:Label ID="Label1" runat="server">Procesos Realizados: </asp:Label>
                            <asp:Label ID="lblCuentaProceso" runat="server">0</asp:Label>
                        </div>
                        <div class="bordes">
                            <asp:GridView ID="dtgProceso" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_HelpDesk_Solucion" HeaderText="Codigo" />
                                    <asp:BoundField DataField="Fecha_Registro" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
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
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>