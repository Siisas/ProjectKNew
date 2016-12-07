<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="procesosolicdoc.aspx.vb" Inherits="digitacion.procesosolicdoc" %>

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
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Pnl_Message" runat="server">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </asp:Panel>
                    <article>
                        <section>
                            <div class="text-center Subtitulos">
                                Proceso Solicitud y Consulta de Documentos
                            </div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">ID Procesado<asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtid" ErrorMessage="El ID debe ser numérico" Operator="DataTypeCheck" Display="Dynamic" Type="Integer">*</asp:CompareValidator></div>
                                        <asp:TextBox ID="txtid" MaxLength="80" CssClass="form-control" runat="server" TabIndex="1" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado de Solicitud</div>
                                        <asp:DropDownList ID="drltipo" runat="server" Class="form-control" TabIndex="3">
                                            <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                            <asp:ListItem>Finalizado</asp:ListItem>
                                            <asp:ListItem>Devuelto</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <br />
                                    <asp:Button ID="btnguardar" runat="server" Text="Guardar" CssClass="btn btn-primary" TabIndex="4" />
                                    <asp:Button ID="btnguardar0" runat="server" Text="Consultar" CssClass="btn btn-primary" TabIndex="5" />
                                    <asp:Button ID="btnguardar1" runat="server" Text="Exportar" CssClass="btn btn-primary" TabIndex="6" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Observación:</div>
                                        <asp:TextBox ID="txtobs" runat="server" CssClass="form-control" TextMode="MultiLine" TabIndex="2"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </section>
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label ID="Label1" runat="server">Solicitudes de documentos:&nbsp;&nbsp;</asp:Label>
                            <asp:Label ID="Lblcuenta" runat="server"></asp:Label>
                        </em></h4>
                        <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 600px; width: 100%">
                            <asp:GridView ID="dtggeneral" runat="server"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="iddoc" HeaderText="ID" />
                                    <asp:BoundField DataField="codigod" HeaderText="Código" />
                                    <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                    <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                                    <asp:BoundField DataField="documento" HeaderText="Identificación" />
                                    <asp:BoundField DataField="area" HeaderText="area" />
                                    <asp:BoundField DataField="fcreg" HeaderText="Fecha Solicitud" />
                                    <asp:BoundField DataField="tipodoc" HeaderText="Tipo Solicitud" />
                                    <asp:BoundField DataField="obs" HeaderText="Observación" />
                                    <asp:BoundField DataField="estado" HeaderText="Estado Solicitud" />
                                    <asp:BoundField DataField="fcemision" HeaderText="Fecha Respuesta" />
                                    <asp:BoundField DataField="obsemision" HeaderText="Observación Respuesta" />
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
                <Triggers>
                    <asp:PostBackTrigger ControlID="btnguardar1" />
                </Triggers>
            </asp:UpdatePanel>
        </form>
    </body>
</html>
