<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AsignacionHorariosMalla.aspx.vb" Inherits="digitacion.AsignacionHorariosMalla" %>

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
                        <div class="text-center Subtitulos">Cargar malla en excel</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Seleccion archivo </div>
                                    <asp:FileUpload ID="FileArchivo" runat="server" OnClick="btnUpload_Click" Width="100%" CssClass="btn btn-primary" />
                                </div>                                    
                                <h4>
                                    <asp:Button ID="BtnVer2" runat="server" Text="Visualizar" Visible="true" CssClass="btn btn-primary" />                                    
                                    <asp:Button ID="BtnImportar" runat="server" Text="Guardar" Visible="true" CssClass="btn btn-primary" />
                                </h4>
                                
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Registros ingresados</div>
                                    <asp:Label Style="background-color: inherit" ID="lblcantidad" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                            </div>
                        </div><br />
                        <asp:Panel ID="Pnl_Dtg_Desarrollos" Visible="false" runat="server">
                            <h4 style="color: #8F9E45;"><em>
                                Registros encontrados:  <asp:Label ID="LblCantidad2" runat="server"></asp:Label>
                            </em></h4>
                            <div class="bordes">
                                <asp:GridView ID="DtgVisualizar" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True" AutoGenerateColumns="False">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                    <Columns>
                                        <asp:BoundField DataField="Cod_Agente" HeaderText="Agente" />
                                        <asp:BoundField DataField="Fc_Ingreso" HeaderText="Fecha Ingreso" />
                                        <asp:BoundField DataField="Fc_Salida" HeaderText="Fecha Salida" />
                                        <asp:BoundField DataField="Tipo_Horario" HeaderText="Horario" />
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
                    </section>
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="BtnVer2" />
                    <asp:PostBackTrigger ControlID="BtnImportar" />
                </Triggers>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
