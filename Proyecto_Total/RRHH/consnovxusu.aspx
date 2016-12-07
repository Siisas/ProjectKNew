<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consnovxusu.aspx.vb" Inherits="digitacion.consnovxusu" %>

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
            </ContentTemplate>
        </asp:UpdatePanel>
        <article>
            <section>
                <div class="text-center Subtitulos">
                    Filtros de Consulta
                </div>
                <div class="Form">
                    <div class="Cell-Form">
                        <div class="input-group">
                            <div class="input-group-addon">Fecha Inicio<asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtfcini" ErrorMessage="La fecha no es válida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator></div>
                            <asp:TextBox ID="txtfcini" TabIndex="1" runat="server" CssClass="form-control Fecha" placeholder="DD/MM/YYYY"></asp:TextBox>
                        </div>
                        <br />
                        <asp:Button ID="btnconsultar" TabIndex="3" Text="Consultar" CssClass="btn btn-primary" runat="server" />
                    </div>
                    <div class="Space-Form"></div>
                    <div class="Cell-Form">
                        <div class="input-group">
                            <div class="input-group-addon">Fecha Fin<asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="txtfcfin" ErrorMessage="La fecha no es válida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator></div>
                            <asp:TextBox ID="txtfcfin" TabIndex="2" runat="server" CssClass="form-control Fecha" placeholder="DD/MM/YYYY"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </section>
            <br />
            <asp:Panel ID="Pnl_dtggeneral" Visible="false" runat="server">
                <h4 style="color: #8F9E45;"><em>
                    <asp:Label ID="Label2" runat="server">Novedades Reportadas:</asp:Label>
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                </em></h4>
                <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 600px; width: 100%">
                    <asp:GridView ID="dtggeneral" runat="server"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idreg" HeaderText="ID" />
                            <asp:BoundField DataField="cod" HeaderText="Código" />
                            <asp:BoundField DataField="fcnovedad" HeaderText="Fecha Novedad" />
                            <asp:BoundField DataField="descripcioninasistencia" HeaderText="Tipo Novedad" />
                            <asp:BoundField DataField="dias" HeaderText="Dias Nov" />
                            <asp:BoundField DataField="horas" HeaderText="Horas Nov" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="repone" HeaderText="Repone" />
                            <asp:BoundField DataField="reportanom" HeaderText="Reporta Nom" />
                            <asp:BoundField DataField="desctipo" HeaderText="Tipificación" />
                            <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuarioreg" HeaderText="Usuario Reg" />
                            <asp:BoundField DataField="mesreporte" HeaderText="Mes Reportado" />
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
        </article>
        <footer></footer>
    </form>
</body>
</html>
