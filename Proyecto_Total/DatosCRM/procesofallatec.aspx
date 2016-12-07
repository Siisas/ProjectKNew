<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="procesofallatec.aspx.vb"
    Inherits="digitacion.procesofallatec" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ERP Kamilion - Proceso Falla Tec</title>
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
                <asp:Label ID="lblmsg0" runat="server" Style="font-size: medium; font-style: italic">Revisión Fallatec Datos</asp:Label>
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
                &nbsp;</td>
            <td class="celdascent">
                <table style="width: 100%; height: 100%">
                    <tr>
                        <td style="width: 10%" bgcolor="#CCCCFF">
                            <table style="width: 100%; height: 100%; border-color: White" border="1">
                                <tr>
                                    <td>
                                        Caso:
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td style="width: 40%">
                            <table style="width: 100%; height: 100%; border-style: outset; border-width: 1px">
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtcaso" runat="server" Width="138px" Enabled="False"></asp:TextBox>
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcaso"
                                            ErrorMessage="El caso debe ser numérico" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                        <asp:Button ID="btnguardar" runat="server" Style="height: 26px" Text="Guardar" />
                                        <asp:Label ID="LblCaso_Gestion" runat="server" Visible="False"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td style="width: 50%">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                &nbsp;
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
                <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                    <tr>
                        <td class="textotittabla">
                            Tipo de Cierre
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drltipificacionll" runat="server" Height="22px" Width="322px">
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            Observacion
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtObs" runat="server" Width="90%" Height="60px" TextMode="MultiLine" ></asp:TextBox>
                        </td>
                    </tr>
                </table>
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
                Casos asignados pendientes&nbsp;
                <asp:Label ID="lblcuenta" runat="server"></asp:Label>
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
                    CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="30" Width="100%"
                    Style="font-size: x-small" EnableModelValidation="True">
                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                        <asp:ButtonField CommandName="Seleccion" HeaderText="Selección" Text="Seleccion" />
                        <asp:BoundField DataField="Id_Ctrlfallatec" HeaderText="Id fallatec" />
                        <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                        <asp:BoundField DataField="fcsap" HeaderText="Fecha SAP" />
                        <asp:BoundField DataField="min" HeaderText="Min" />
                        <asp:BoundField DataField="tickler" HeaderText="Tickler" />
                        <asp:BoundField DataField="fcasignacion" HeaderText="Fecha Asignación" />
                        <asp:BoundField DataField="idusuarioasigna" HeaderText="Usuario Asigna" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
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
                &nbsp;</td>
            <td class="celdascent">
                Gestion Fallatec Realizada al caso&nbsp;
                <asp:Label ID="LblCuentaGestion" runat="server"></asp:Label>
                </td>
            <td class="celdasder">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;</td>
            <td class="celdascent">
            <asp:GridView ID="dtg_Gestion_FallaTec" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="30" Width="100%"
                    Style="font-size: x-small">
                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="Fk_Id_Caso" HeaderText="Caso" />
                        <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Reg" />
                        <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario" />
                        <asp:BoundField DataField="Obs" HeaderText="Obs" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
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
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
