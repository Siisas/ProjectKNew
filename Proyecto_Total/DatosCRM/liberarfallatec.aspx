<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="liberarfallatec.aspx.vb"
    Inherits="digitacion.liberarfallatec" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ERP Kamilion - Liberacion Falla Tec</title>
    <link rel="icon" href="favicon.ico" type="image/x-icon" />
    <style type="text/css">
        .celdasder
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
        }
        .celdascent
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }
        .titulo
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            color: navy;
        }
        .Tamanio_Tabla
        {
            width: 100%;
            height: 100%;
        }
        .textotittabla
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            background: #E2E8FA;
            width: 15%;
        }
        .celdascons
        {
            width: 35%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width: 100%; height: 100%">
        <tr>
            <td class="celdasder">
            </td>
            <td class="celdascent">
                <table style="border-style: outset; border-width: 1px; width: 100%">
                    <tr>
                        <td style="width: 20%">
                            &nbsp;
                        </td>
                        <td align="left" class="titulo">
                            Kamilion Comunicaciones ERP
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Label ID="lblmsg" runat="server" Style="color: #FF3300"></asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
            </td>
            <td class="celdascent">
                <uc1:menu ID="menu1" runat="server" />
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Label ID="lblmsg0" runat="server" Style="font-size: medium; font-style: italic">Liberar Asignación Fallatec Datos</asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
            </td>
            <td class="celdascent">
                <table style="width: 100%; height: 100%">
                    <tr>
                        <td style="width: 33%">
                            <asp:Label ID="lblusuario" runat="server" Font-Names="Times New Roman" ForeColor="Black"></asp:Label>
                        </td>
                        <td style="width: 33%">
                            <asp:Label ID="lblnombreusu" runat="server" Font-Names="Times New Roman" ForeColor="Black"></asp:Label>
                            &nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#0000CC"
                                Font-Names="Times New Roman"></asp:Label>
                        </td>
                        <td style="width: 34%">
                            <asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: " Font-Names="Times New Roman"
                                ForeColor="Black"></asp:Label>
                            <asp:Label ID="LblSupervisor" runat="server" Font-Names="Times New Roman" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Button ID="Button1" runat="server" Text="Buscar" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnguardar" runat="server" Text="Liberar" />
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
            </td>
            <td class="celdascent">
                <asp:Panel ID="Panel2" runat="server">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Digitador Asignado
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlusuario" runat="server" Height="22px" Width="322px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Jefe Inmediato
                            </td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlJefe" runat="server" Width="322px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Liberacion Masiva
                            </td>
                            <td class="celdascons">
                                <asp:CheckBox ID="CheckBoxLiberacion" runat="server" Text="¡¡Cuidado al seleccionar esta opcion realizara una liberacion masiva!!" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:GridView ID="dtgAgentes" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="20" Width="48%"
                    Style="font-size: x-small" EnableModelValidation="True" Visible="False">
                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="idusuario" HeaderText="Usuario" />
                        <asp:BoundField DataField="nombreu" HeaderText="Nombre" />
                    </Columns>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                </asp:GridView>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                Casos Asignados sin Proceso:
                <asp:Label ID="lblcantidad" runat="server"></asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="1000" Width="100%"
                    Style="font-size: x-small" EnableModelValidation="True">
                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                        <asp:BoundField DataField="min" HeaderText="MIN" />
                        <asp:BoundField DataField="fcasignacion" HeaderText="Fecha Asignado" />
                    </Columns>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                </asp:GridView>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
