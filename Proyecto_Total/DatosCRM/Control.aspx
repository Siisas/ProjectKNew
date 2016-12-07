<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Control.aspx.vb" Inherits="digitacion.Control" %>


<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Julian castañeda c1595	--%>
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
                        <div class="text-center Subtitulos">Consultas CRM Control</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <asp:CompareValidator ID="CompareValidator1" runat="server" Display="Dynamic" ControlToValidate="txtcaso" Operator="DataTypeCheck" Type="Double">El caso debe ser numérico</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-btn">
                                        <asp:Button ID="Button1" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                                    </span>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                            </div>
                        </div>
                        <div class="Separator"></div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">MIN</div>
                                    <asp:Label ID="lblmin" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre</div>
                                    <asp:Label ID="lblcliente" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha SAP</div>
                                    <asp:Label ID="lblfcsap" runat="server" CssClass="form-control" />
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:Label ID="lblcaso" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tickler</div>
                                    <asp:Label ID="lbltickler" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:Label ID="lblestado" runat="server" CssClass="form-control" />
                                </div>
                            </div>
                        </div>
                        <div class="text-center Subtitulos">Registro de Seguimiento</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Tipificación Llamada</div>
                                    <asp:DropDownList ID="drltipificacionll" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Mesa Escalada</div>
                                    <asp:DropDownList ID="drlmesa" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione -"></asp:ListItem>
                                        <asp:ListItem Text="Voz"></asp:ListItem>
                                        <asp:ListItem Text="Datos"></asp:ListItem>
                                        <asp:ListItem Value="FallasRed" Text="Fallas de Red"></asp:ListItem>
                                        <asp:ListItem Text="Otra"></asp:ListItem>
                                        <asp:ListItem Value="VozDatos" Text="Voz y Datos"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo Línea</div>
                                    <asp:DropDownList ID="drltlinea" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione -"></asp:ListItem>
                                        <asp:ListItem Text="Prepago"></asp:ListItem>
                                        <asp:ListItem Text="Pospago"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <asp:CompareValidator ID="CompareValidator4" Display="Dynamic" runat="server" ControlToValidate="txtfcrestab" Operator="DataTypeCheck" Type="Date">La fecha de reestablecimiento es incorrecta</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Restablecido</div>
                                    <asp:TextBox ID="txtfcrestab" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Solicita Ajuste</div>
                                    <asp:DropDownList ID="drlsolicajuste" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione" />
                                        <asp:ListItem Text="si" />
                                        <asp:ListItem Text="No" />
                                    </asp:DropDownList>
                                </div>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtvlrpaq" Display="Dynamic" Operator="DataTypeCheck" Type="Double">El valor del paquete debe ser numérico</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Valor Plan - Paquete</div>
                                    <asp:TextBox ID="txtvlrpaq" runat="server" CssClass=" form-control"></asp:TextBox>
                                </div><h4></h4>
                                <asp:Button ID="btnguardar" runat="server" CssClass="btn btn-primary" Text="Guardar" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">¿Se realizó Soporte?</div>
                                    <asp:DropDownList ID="drltsoporte" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Si</asp:ListItem>
                                        <asp:ListItem>No</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Observación</div>
                                    <asp:TextBox ID="txtobs" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Servicio Reestablecido</div>
                                    <asp:DropDownList ID="drlservreest" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione -" />
                                        <asp:ListItem Text="Si"></asp:ListItem>
                                        <asp:ListItem Text="No"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Aplica Ajuste
                                    </div>
                                    <asp:DropDownList ID="drlajuste" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0" Text="- Seleccione -"></asp:ListItem>
                                        <asp:ListItem Text="Si"></asp:ListItem>
                                        <asp:ListItem Text="No"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre Plan - Paquete</div>
                                    <asp:TextBox ID="txtnombrepaq" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <asp:CompareValidator ID="CompareValidator3" Display="Dynamic" runat="server" ControlToValidate="txtdias" Operator="DataTypeCheck" Type="Integer">Los dias debe ser un dato numérico</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Dias sin Servicio</div>
                                    <asp:TextBox ID="txtdias" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                          <div class="Leyendas">
                                <asp:Label runat="server">Consulta Seguimientos</asp:Label>&nbsp;
                                <asp:Label ID="lblcuenta"
                                    runat="server"></asp:Label>
                            </div>
                        <div class ="bordes">
                        <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" PageSize="80" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                            <Columns>
                                <asp:BoundField DataField="idcrmcontrol" HeaderText="ID" />
                                <asp:BoundField DataField="id" HeaderText="Caso" />
                                <asp:BoundField DataField="mintel" HeaderText="Min" />
                                <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                                <asp:BoundField DataField="obs" HeaderText="Observación" />
                                <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                                <asp:BoundField DataField="soporte" HeaderText="Soporte" />
                                <asp:BoundField DataField="mesaesc" HeaderText="Mesa Escalada" />
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