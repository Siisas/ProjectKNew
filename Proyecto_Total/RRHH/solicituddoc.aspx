<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="solicituddoc.aspx.vb" Inherits="digitacion.solicituddoc" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
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
                <article>
                    <section>
                        <div class="text-center Subtitulos">
                            Solicitud de documentos
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo Documento: 
                                    </div>
                                    <asp:DropDownList TabIndex="1" ID="drltipo" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <br />
                                <asp:Button ID="btnguardar" TabIndex="3" Text="Guardar" CssClass="btn btn-primary" runat="server" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Observación</div>
                                    <asp:TextBox ID="txtobs" TabIndex="2" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </section>
                    <h4 style="color: #8F9E45;"><em>
                        <asp:Label ID="Label1" runat="server">Solicitudes de docuemntos:&nbsp;&nbsp;</asp:Label>
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
        </asp:UpdatePanel>
    </form>
</body>
</html>
