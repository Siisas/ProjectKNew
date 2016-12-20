<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CafeteriaComprarProducto.aspx.vb" Inherits="digitacion.CafeteriaComprarProducto" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>
<!DOCTYPE html>
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
    <script src="../Css2/jquery.min.js"></script>
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
                        <%--Aqui hago una columna --%>

                        <div class="text-center Subtitulos">Datos Basicos</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Categoría</div>
                                    <asp:Label ID="Lbl_Catego" CssClass="form-control" readonly="true" runat="server"></asp:Label>                                   
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre del Empleado</div>
                                    <asp:DropDownList ID="Drl_NombreEmpleado" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre del Cliente</div>
                                    <asp:DropDownList ID="Drl_NombreCliente" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha de Venta</div>
                                    <asp:TextBox ID="TxtFechaComprar" CssClass="form-control Fecha" MaxLength="10" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </section>
                    <section>
                        <%--Aqui hago una columna --%>
                        <div class="text-center Subtitulos">Comprar Productos</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Producto</div>
                                    <asp:DropDownList ID="Drl_Productos" CssClass="form-control" AutoPostBack="true" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Cantidad</div>
                                    <asp:TextBox ID="TxtCantidadProducto" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Codigo Producto</div>
                                    <asp:Label ID="Lbl_IdProducto" CssClass="form-control" readonly="true" runat="server"></asp:Label>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Valor</div>
                                    <asp:Label ID="Lbl_Valor" CssClass="form-control" readonly="true" runat="server"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Cantidad Disponible</div>
                                    <asp:Label ID="Lbl_CantidadDisponible" CssClass="form-control" readonly="true" runat="server"></asp:Label>
                                </div>                    
                            </div>
                        </div>
                        <asp:Button ID="btn_Comprar" CssClass="btn btn-primary" ValidationGroup="Registro" runat="server" Text="Comprar" />
                        <asp:Button ID="btn_Agregar" CssClass="btn btn-primary" ValidationGroup="Registro" runat="server" Text="Agregar" />
                        <asp:Button ID="btn_NuevaCompra" CssClass="btn btn-primary" runat="server" Text="Realizar nueva compra" />
                    </section>
                    <section>
                        <div class="text-center Subtitulos">Descripciòn Compra</div>
                        <div class="Cell-Form">
                            <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
                                <asp:GridView ID="Gtg_TotalCompras" runat="server" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <Columns>
                                        <asp:ButtonField CommandName="Delete" ControlStyle-BackColor="#B3C556" Text="Eliminar" ButtonType="Button" />
                                    </Columns>
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                                <asp:Label CssClass="form-control" Style="color: #B3C556;" ID="Lbl_ValorTotal" runat="server" Text=""></asp:Label>
                                <asp:Label CssClass="form-control" Style="color: #B3C556;" ID="Lbl_String" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
    </form>
</body>
</html>
<%--  --%><%--  --%>