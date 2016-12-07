<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultaCompletaCentinela.aspx.vb" Inherits="digitacion.ConsultaCompletaCentinela" %>

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
                                    <div class="input-group-addon">Codigo</div>
                                    <asp:TextBox ID="txtcod" runat="server" CssClass="form-control" TabIndex="10"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Inicio<asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TxtFechaInicio" ErrorMessage="Revise hora" Operator="DataTypeCheck" Display="Dynamic" Type="Date">*</asp:CompareValidator></div>
                                    <asp:TextBox ID="TxtFechaInicio" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" TabIndex="12"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo Horario</div>
                                    <asp:DropDownList ID="Drltipohorario" AutoPostBack="True" runat="server" CssClass="form-control" TabIndex="14" />
                                </div>
                                <br />
                                <asp:Button ID="Btnconsultar" runat="server" Text="Consultar" CssClass="btn btn-primary" TabIndex="15" />
                                <asp:Button ID="btnexportarexcel" runat="server" Text="Exportar" CssClass="btn btn-primary" TabIndex="16" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Grupo</div>
                                    <asp:DropDownList ID="drlGrupo" runat="server" CssClass="form-control" TabIndex="11"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Fin<asp:CompareValidator ID="CVFecha_Fin" runat="server" ControlToValidate="TxtFechaFin" ErrorMessage="Error en la fecha" Operator="DataTypeCheck" Display="Dynamic" Type="Date">*</asp:CompareValidator></div>
                                    <asp:TextBox ID="TxtFechaFin" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" TabIndex="13"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </section>
                    <asp:Panel ID="Pngeneral" runat="server" Visible="true">
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label ID="Label1" runat="server">Registros encontrados:&nbsp;&nbsp;</asp:Label>
                            <asp:Label ID="Lblcuenta" runat="server"></asp:Label>
                        </em></h4>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="true" PageSize="100" 
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="idcent" HeaderText="ID" />
                                    <asp:BoundField DataField="codigo" HeaderText="Código" />
                                    <asp:BoundField DataField="nombres" HeaderText="Nombre" />
                                    <asp:BoundField DataField="apellidos" HeaderText="Apellido" />
                                    <asp:BoundField DataField="grupo" HeaderText="Grupo" />
                                    <asp:BoundField DataField="FcIngreso Centinela" HeaderText="Fecha Ingreso" />
                                    <asp:BoundField DataField="FcSalida Centinela" HeaderText="Fecha Salida" />
                                    <asp:BoundField DataField="FcSalida Break 1" HeaderText="Salida Break 1" />
                                    <asp:BoundField DataField="FcIngreso Break 1" HeaderText="Entrada Break 1" />
                                    <asp:BoundField DataField="FcSalida Break 2" HeaderText="Salida Break 2" />
                                    <asp:BoundField DataField="FcIngreso Break 2" HeaderText="Entrada Break 2" />
                                    <asp:BoundField DataField="FcSalida Almuerzo" HeaderText="Salida Almuerzo" />
                                    <asp:BoundField DataField="FcIngreso Almuerzo" HeaderText="Entrada Almuerzo" />
                                    <asp:BoundField DataField="FcIngreso Capacitacion" HeaderText="Entrada Capacitación" />
                                    <asp:BoundField DataField="FcSalida Capacitacion" HeaderText="Salida Capacitación" />
                                    <asp:BoundField DataField="FcIngreso Pre-Turno" HeaderText="Entrada Pre-Turno" />
                                    <asp:BoundField DataField="FcSalida Pre-Turno" HeaderText="Salida Pre-Turno" />
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
                    <asp:Panel ID="Pntipohorario" runat="server" Visible="false">
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label ID="Lblcuentatipohorario" runat="server"></asp:Label>
                        </em></h4>
                        <div class="bordes">
                            <asp:GridView ID="Dtgtipohorario" runat="server" AllowPaging="true" PageSize="40" 
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="idcent" HeaderText="ID" />
                                    <asp:BoundField DataField="Codigo" HeaderText="Código" />
                                    <asp:BoundField DataField="nombres" HeaderText="Nombre" />
                                    <asp:BoundField DataField="apellidos" HeaderText="Apellido" />
                                    <asp:BoundField DataField="grupo" HeaderText="Grupo" />
                                    <asp:BoundField DataField="fcingreso" HeaderText="Fecha Entrada" />
                                    <asp:BoundField DataField="fcsalida" HeaderText="Fecha Salida" />
                                    <asp:BoundField DataField="FcIngreso Programada" HeaderText="Fecha Entrada Programada" />
                                    <asp:BoundField DataField="FcSalida Programada" HeaderText="Fecha Salida Programada" />
                                    <asp:BoundField DataField="IPEntrada" HeaderText="IP Entrada" />
                                    <asp:BoundField DataField="IPSalida" HeaderText="IP Salida" />
                                    <asp:BoundField DataField="nombre" HeaderText="Tipo Horario" />
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
                <asp:PostBackTrigger ControlID="btnexportarexcel" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
