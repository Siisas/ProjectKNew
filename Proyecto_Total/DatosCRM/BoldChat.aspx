<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BoldChat.aspx.vb" Inherits="digitacion.BoldChat" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Cristian Duarte C1477	--%>
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
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcaso" Display="Dynamic" Operator="DataTypeCheck" Type="Double">El caso debe ser numérico</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnConsultaCaso" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                                        <asp:Button ID="btncrea" runat="server" Text="Crear Caso" CssClass="btn btn-primary" />
                                    </span>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                            </div>
                        </div>
                        <div class="Separator "></div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">MIN</div>
                                    <asp:Label ID="lblmin" runat="server" CssClass="form-control Label-inherit"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre Empresa C&G / Usuario VIP</div>
                                    <asp:Label ID="lblcliente" runat="server" CssClass="form-control Label-inherit"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Mesa</div>
                                    <asp:Label ID="LblMesa" runat="server" CssClass="form-control Label-inherit"></asp:Label>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:Label ID="lblcaso" runat="server" CssClass="form-control Label-inherit"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Equipo</div>
                                    <asp:Label ID="lblequipo" runat="server" CssClass="form-control Label-inherit"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="text-center Subtitulos">Identificacion Caso Bold Chat</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Ingeniero Claro Remite</div>
                                    <asp:DropDownList ID="drlingclaro" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo</div>
                                    <asp:DropDownList ID="drlTipo" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Recomendado con Prioridad</div>
                                    <asp:DropDownList ID="drlRecomendado" runat="server" CssClass="form-control">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Si</asp:ListItem>
                                        <asp:ListItem>No</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TxtFecha_Recepcion" Display="Dynamic" Operator="DataTypeCheck" Type="Date">Revise Fecha de Recepcion</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Recepcion</div>
                                    <asp:TextBox ID="TxtFecha_Recepcion" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" CssClass="form-control Fecha"></asp:TextBox>
                                </div><h4></h4>
                                <asp:Button ID="btnindentifBol" runat="server" Text="Guardar" CssClass="btn btn-primary" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Nuevo Ing</div>
                                    <asp:TextBox ID="txtingclaro" runat="server" CssClass="form-control" />
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnguardarIngClaro" runat="server" Text="Agregar" CssClass="btn btn-primary" />
                                    </span>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Segmento</div>
                                    <asp:DropDownList ID="drlSegmento" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo de soporte:</div>
                                    <asp:DropDownList ID="drlTS" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <asp:Panel ID="PanelBoldChat" runat="server" Visible="False">
                            <div class="text-center Subtitulos">Creacion Caso Bold Chat</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="TxtCasoReg" Display="Dynamic" Operator="DataTypeCheck" Type="Double">El caso debe ser numérico</asp:CompareValidator>
                                    <div class="input-group">
                                        <div class="input-group-addon">Caso</div>
                                        <asp:TextBox ID="TxtCasoReg" runat="server" Enabled="False" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <asp:CompareValidator runat="server" ControlToValidate="TxtMinReg" Display="Dynamic" Operator="DataTypeCheck" Type="Double">El Min debe ser numérico</asp:CompareValidator>
                                    <div class="input-group">
                                        <div class="input-group-addon">Min</div>
                                        <asp:TextBox ID="TxtMinReg" MaxLength="10" runat="server" CssClass="form-control"/>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Mesa</div>
                                        <asp:DropDownList ID="drlRegMesa" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem>Datos</asp:ListItem>
                                            <asp:ListItem>Voz</asp:ListItem>
                                            <asp:ListItem>Dilo</asp:ListItem>
                                        </asp:DropDownList>
                                    </div><h4></h4>
                                    <asp:Button ID="BtnRegBoldCha" runat="server" Text="Guardar" CssClass="btn btn-primary" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Nombre Empresa C&G / Usuario VIP</div>
                                        <asp:TextBox ID="TxtNombreReg" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Equipo</div>
                                        <asp:TextBox ID="TxtEquipoReg" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo de Falla</div>
                                        <asp:DropDownList ID="Drl_Tipo_Falla" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                        <asp:Panel ID="PnlGeneral" runat="server" Visible="false">
                            <div class="Leyendas">
                                <asp:Label runat="server"> Registros Casos Bolchat</asp:Label>&nbsp;
                                <asp:Label ID="lblcuentaBol" runat="server"></asp:Label>
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="dtggeneralBolchat" runat="server" AllowPaging="True" PageSize="80" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                    <Columns>
                                        <asp:BoundField DataField="Cod_Bandeja_Bolt" HeaderText="Codigo" />
                                        <asp:BoundField DataField="Idcaso" HeaderText="Caso" />
                                        <asp:BoundField DataField="Cas_Fecha_Registro" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Min_Ac" HeaderText="Min_Ac" />
                                        <asp:BoundField DataField="Nom_Cliente" HeaderText="Nom_Cliente" />
                                        <asp:BoundField DataField="Equipo_Ac" HeaderText="Equipo_Ac" />
                                        <asp:BoundField DataField="Ing_Remite" HeaderText="Ingeniero Remite" />
                                        <asp:BoundField DataField="Cas_Fecha_Recepcion" HeaderText="Fecha Recepcion" />
                                        <asp:BoundField DataField="Idusuario" HeaderText="Agente" />
                                        <asp:BoundField DataField="Recomen_Prioridad" HeaderText="Recomendado" />
                                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                                        <asp:BoundField DataField="Segmento" HeaderText="Segmento" />
                                        <asp:BoundField DataField="Tipo_Soporte" HeaderText="Tipo de Soporte" />
                                        <asp:BoundField DataField="Bandeja" HeaderText="Bandeja"></asp:BoundField>
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
                        <asp:Panel ID="Panel1" runat="server" Visible="false">
                            <div class="Leyendas">
                                <asp:Label runat="server"> Consulta Seguimientos</asp:Label>&nbsp;
                                <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" PageSize="80" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                    <Columns>
                                        <asp:BoundField DataField="idcrm" HeaderText="ID" />
                                        <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                                        <asp:BoundField DataField="min_ac" HeaderText="Min" />
                                        <asp:BoundField DataField="fcreg" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                                        <asp:BoundField DataField="obs" HeaderText="Observación" />
                                        <asp:BoundField DataField="tipo_soporte" HeaderText="Tipo Soporte" />
                                        <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                                        <asp:BoundField DataField="fallared" HeaderText="Falla de Red" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                        </asp:Panel>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
<%--    © 2016 Cristian Duarte C1477    --%>