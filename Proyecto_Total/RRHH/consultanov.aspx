<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consultanov.aspx.vb" Inherits="digitacion.consultanov" %>

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
                            Filtros de Consulta
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Codigo                                            
                                    </div>
                                    <asp:TextBox ID="txtcod" runat="server" CssClass="form-control" TabIndex="1"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo Novedad                                    
                                    </div>
                                    <asp:DropDownList ID="drltiponov" CssClass="form-control" runat="server" AutoPostBack="True" TabIndex="3"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Inicio
                                    <asp:CompareValidator ID="CompareValidator1" runat="server"
                                        ControlToValidate="txtfcini" ErrorMessage="La fecha no es válida" Display="Dynamic"
                                        Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txtfcini" CssClass="form-control Fecha" MaxLength="10" Placeholder="DD/MM/YYYY" runat="server" TabIndex="5" />
                                </div>
                                <br />
                                <asp:Button ID="btnvalidar" Text="Buscar" CssClass="btn btn-primary" runat="server" TabIndex="7" />
                                <asp:Button ID="btnxls" Text="Exportar" CssClass="btn btn-primary" runat="server" TabIndex="8" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Reporta Nómina</div>
                                    <asp:Label Style="background-color: inherit" ID="Label3" runat="server" CssClass="form-control" TabIndex="2">
                                        <asp:RadioButtonList ID="rdbreporta" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem>Si&nbsp;&nbsp;</asp:ListItem>
                                            <asp:ListItem>No&nbsp;&nbsp;</asp:ListItem>
                                            <asp:ListItem Selected="True" Value="0">N/A</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipificación                                    
                                    </div>
                                    <asp:DropDownList ID="drltipificacion" runat="server" CssClass="form-control" TabIndex="4"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Fin
                                    <asp:CompareValidator ID="CompareValidator2" runat="server"
                                        ControlToValidate="txtfcfin" ErrorMessage="La fecha no es válida" Display="Dynamic"
                                        Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txtfcfin" CssClass="form-control Fecha" MaxLength="10" Placeholder="DD/MM/YYYY" runat="server" TabIndex="6" />
                                </div>
                            </div>
                        </div>
                    </section>
                    <asp:Panel ID="panel1" Visible="false" runat="server">
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label ID="Label1" runat="server">Novedades:&nbsp;&nbsp;</asp:Label>
                            <asp:Label ID="Lblcuenta" runat="server"></asp:Label>
                        </em></h4>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="true" PageSize="40"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="idreg" HeaderText="ID" />
                                    <asp:BoundField DataField="cod" HeaderText="Código" />
                                    <asp:BoundField DataField="documento" HeaderText="Identificación" />
                                    <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                                    <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
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
                                    <asp:BoundField DataField="mesreporte" HeaderText="Mes Reporte" />
                                    <asp:BoundField DataField="Tipo_Retiro" HeaderText="Tipo Retiro" />
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
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="btnxls" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
