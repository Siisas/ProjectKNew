<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CafeteriaVenta.aspx.vb" Inherits="digitacion.Plantilla" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>
<!DOCTYPE html>
<%--	Ricar	--%>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kamilion Caféteria</title>
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
                        <div class="text-center Subtitulos">Ingreso Productos</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--En este div se encierran las filas de esta columna--%>
                                <asp:RegularExpressionValidator ControlToValidate="TxtProducto" ValidationGroup="Registro" Display="Dynamic" ValidationExpression="^[a-zA-Z'.\s]{1,40}$" runat="server">Incorrecto!</asp:RegularExpressionValidator>
                                <asp:RegularExpressionValidator ControlToValidate="TxtProveedor" ValidationGroup="Registro" Display="Dynamic" ValidationExpression="^[a-zA-Z'.\s]{1,40}$" runat="server">Incorrecto!</asp:RegularExpressionValidator>
                                <asp:RegularExpressionValidator ControlToValidate="TxtCantidad" ValidationGroup="Registro" Display="Dynamic" ValidationExpression="^[0-9]{1,40}$" runat="server">Incorrecto!</asp:RegularExpressionValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        <asp:RequiredFieldValidator ControlToValidate="TxtProducto" ValidationGroup="Registro" runat="server">*</asp:RequiredFieldValidator>Nombre Producto                                   
                                    </div>
                                    <asp:TextBox ID="TxtProducto" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Categoría</div>
                                    <asp:DropDownList ID="Drl_Categoria" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        <asp:RequiredFieldValidator ControlToValidate="TxtValorProducto" ValidationGroup="Registro" runat="server">*</asp:RequiredFieldValidator>Valor del Producto                                   
                                    </div>
                                    <asp:TextBox ID="TxtValorProducto" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Cantidad</div>
                                    <asp:TextBox ID="TxtCantidad" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <asp:Button ID="Btn_RegistrarProducto" ValidationGroup="Registro" CssClass="btn btn-primary" runat="server" Text="Registrar" />
                                <asp:Label ID="Lbl_MensajePlantilla" runat="server" Text=""></asp:Label>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha de Ingreso</div>
                                    <asp:TextBox ID="TxtFecha" CssClass="form-control Fecha" MaxLength="10" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Codigo del Empleado</div>
                                    <asp:DropDownList ID="Drl_CodigoEmpleado" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Proveedor del Producto</div>
                                    <asp:TextBox ID="TxtProveedor" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </section>
                    <section>
                        <div class="text-center Subtitulos">Consulta de Productos desde el Ingreso a la cafeterìa</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre del Producto</div>
                                    <asp:DropDownList ID="Drl_NombreProducto" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha de Ingreso</div>
                                    <asp:TextBox ID="TxtBuscarFecha" CssClass="form-control Fecha" MaxLength="10" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Categoria</div>
                                    <asp:DropDownList ID="Drl_CategoriaBuscar" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <asp:Button ID="btn_Consultar" CssClass="btn btn-primary" runat="server" Text="Consultar" />
                        </div>                               
                    </section>
                    <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
                        <asp:GridView ID="Gtg_Productos" runat="server" CellPadding="4" ForeColor="#333333"
                            GridLines="None" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                        <%--<asp:Label CssClass="form-control" style="color:#B3C556;"  ID="Lbl_ValorTotal" runat="server" Text=""></asp:Label>--%>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>