<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CafeteriaCrearEmpClie.aspx.vb" Inherits="digitacion.CafeteriaCrearEmpClie" %>

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
                        <div class="text-center Subtitulos">Crear Empleado</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <asp:RegularExpressionValidator Display="Dynamic" ValidationGroup="Nombre" ControlToValidate="TxtNombreEmpleado" ValidationExpression="^[a-zA-Z'.\s]{1,40}$" runat="server">Por favor ingrese solo letras</asp:RegularExpressionValidator>
                                   <div class="input-group">
                                    <div class="input-group-addon"> <asp:RequiredFieldValidator ControlToValidate="TxtNombreEmpleado" ValidationGroup="Nombre" runat="server"  >*</asp:RequiredFieldValidator> Nombres del Empleado</div>
                                    <asp:TextBox ID="TxtNombreEmpleado" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <asp:RegularExpressionValidator Display="Dynamic" ValidationGroup="Nombre" ControlToValidate="TxtNumeroCedulaEmp" ValidationExpression="^[0-9]{1,40}$" runat="server">Por favor ingrese solo Numeros</asp:RegularExpressionValidator>
                                   <div class="input-group">
                                    <div class="input-group-addon"> <asp:RequiredFieldValidator ControlToValidate="TxtNumeroCedulaEmp" ValidationGroup="Nombre" runat="server"  >*</asp:RequiredFieldValidator> Numero cedula del Empleado</div>
                                    <asp:TextBox ID="TxtNumeroCedulaEmp" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>                            
                        </div>
                        <asp:Button ID="btn_AgregarEmpleado" ValidationGroup="Nombre" CssClass="btn btn-primary" runat="server" Text="Guardar"/>
                    </section>
                    <section>
                        <%--Aqui hago una columna --%>
                        <%--ok--%>
                        <div class="text-center Subtitulos">Crear Cliente</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <asp:RegularExpressionValidator Display="Dynamic" ValidationGroup="Empleado" ControlToValidate="TxtNombreCliente" ValidationExpression="^[a-zA-Z'.\s]{1,30}$"  runat="server" >Por favor digite solo caracteres</asp:RegularExpressionValidator>
                                <div class="input-group">
                                    <div class="input-group-addon"> <asp:RequiredFieldValidator ControlToValidate="TxtNombreCliente" ValidationGroup="Empleado" runat="server" Display="Dynamic" >*</asp:RequiredFieldValidator> Nombres del Cliente</div>
                                    <asp:TextBox ID="TxtNombreCliente" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
              <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <asp:RegularExpressionValidator Display="Dynamic" ValidationGroup="Empleado" ControlToValidate="TxtNumeroCedulaCli" ValidationExpression="^[0-9]{1,40}$" runat="server">Por favor ingrese solo Numeros</asp:RegularExpressionValidator>
                                   <div class="input-group">
                                    <div class="input-group-addon"> <asp:RequiredFieldValidator ControlToValidate="TxtNumeroCedulaCli" ValidationGroup="Empleado" runat="server"  >*</asp:RequiredFieldValidator> Numero Cedula del Empleado</div>
                                    <asp:TextBox ID="TxtNumeroCedulaCli" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>                            
                        </div>
                        <asp:Button ID="btn_AgregarCliente" ValidationGroup="Empleado" CssClass="btn btn-primary" runat="server" Text="Guardar" />
                    </section>
                     <asp:Panel runat="server" ID="Panel1">
                <asp:Label ID="Mensaje" runat="server"></asp:Label>
            </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
    </form>
</body>
</html>
