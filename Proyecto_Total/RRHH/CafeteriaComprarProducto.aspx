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
    <script>
        //$(document).ready(function () {
        //    dato = $("#Drl_Categoria option:selected").val()
        //    datos = $("#Drl_Categoria").val()

        //    $("#Drl_Categoria").change(function (e) {
        //        alert($("#Drl_Categoria").val())

        //        switch ($("#Drl_Categoria").val()) {
        //            case "1":
        //                alert(($("#Drl_Categoria").val()))
        //                $("#Drl_Valor").val(1800) //= //($("#Drl_Categoria").val())
        //                break;
        //            case 2:
        //                $("#Drl_Valor").val(2)
        //                break;
        //        }
        //    });
        //});
        //$(document).ready(function () {
        //    //dato = $("#Drl_Categoria option:selected").val()
        //    //datos = $("#Drl_Productos").val()

        //    $("#Drl_Productos").change(function (e) {


        //        switch ($("#Drl_Productos").val()) {
        //            case "1":

        //                $("#Drl_Valor").val(($("#Drl_Productos").val()))
        //                break;
        //            case "2":
        //                $("#Drl_Valor").val(($("#Drl_Productos").val()))
        //                break;
        //            case "3":
        //                $("#Drl_Valor").val(($("#Drl_Productos").val()))
        //                break;
        //            case "4":
        //                $("#Drl_Valor").val(($("#Drl_Productos").val()))
        //                break;
        //        }
        //    });
        //});

    </script>

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
                        <div class="text-center Subtitulos">Comprar Productos</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Producto</div>
                                    <asp:DropDownList ID="Drl_Productos" CssClass="form-control" AutoPostBack="true" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Categoría</div>
                                    <asp:DropDownList ID="Drl_Categoria" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre del Empleado</div>
                                    <asp:DropDownList ID="Drl_NombreEmpleado" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Venta</div>
                                   <asp:TextBox ID="TxtFechaVenta" CssClass="form-control Fecha" MaxLength="10" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="Space-Form"></div>

                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Valor</div>
                                    <%--<asp:DropDownList ID="Drl_Valor" CssClass="form-control" Enabled="true" runat="server"></asp:DropDownList>--%>
                                    <asp:Label ID="Lbl_Valor" CssClass="form-control" readonly="true" runat="server"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Cantidad</div>
                                    <asp:TextBox ID="TxtCantidadProducto" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre del Cliente</div>
                                    <asp:DropDownList ID="Drl_NombreCliente" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <asp:Button ID="btn_Comprar" CssClass="btn btn-primary" runat="server" Text="Comprar" />
                        <asp:Button ID="btn_Agregar" CssClass="btn btn-primary" runat="server" Text="Agregar" />
                    </section>
                    <section>
                        <div class="text-center Subtitulos">Total a pagar</div>
                        <div class="Cell-Form">
                            <%--  <div class="input-group">
                                <div class="input-group-addon">Total a pagar</div>
                                <asp:TextBox ID="TxtValorTotal" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>--%>
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
                                        <asp:ButtonField CommandName="Delete" Text="Eliminar" ButtonType="Button" />
                                    </Columns>
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>

                                <asp:Label CssClass="form-control" ID="Lbl_ValorTotal" runat="server" Text="Label"></asp:Label>
                            </div>

                        </div>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
    </form>
</body>
</html>
