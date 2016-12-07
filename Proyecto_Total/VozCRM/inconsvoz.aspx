<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="inconsvoz.aspx.vb" Inherits="digitacion.inconsvoz" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="icon" href="../favicon.ico" type="image/x-icon"/>
   <title>ERP Kamilion</title>
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
                        <td align="center" class="titulo">
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
                <asp:Label ID="Label1" runat="server" Style="font-size: medium; font-style: italic">Revisión y Envío de Inconsistencias Datos</asp:Label>
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
                                    <td class="auto-style1">
                                        <asp:TextBox ID="txtcaso" runat="server" Width="138px" MaxLength="15"></asp:TextBox>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                ControlToValidate="txtcaso" ErrorMessage="El caso debe ser numérico" 
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                              <asp:Button ID="btnguardar" runat="server" Style="height: 26px" Text="Guardar"/>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td style="width: 50%">
                           
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
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:LinkButton ID="LinkButton3" runat="server">Revisar</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server">Enviar</asp:LinkButton>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                                <asp:Panel ID="Pnrev" runat="server">
                                    <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                                        <tr>
                                            <td class="textotittabla">
                                                Tipificación de Revisión</td>
                                            <td class="celdascons">
                                                <asp:DropDownList ID="drlestado" runat="server" Height="22px" Width="323px">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Aprobado</asp:ListItem>
                                                    <asp:ListItem>Anulado</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />
                </td>
                <td class="celdascent">
                    <asp:Panel ID="Pnenvio" runat="server" Visible="False">
                        <table border="1" cellpadding="1" cellspacing="1" 
    class="style1">
                            <tr>
                                <td class="textotittabla">
                                    Enviar Casos Revisados a Claro</td>
                                <td class="celdascons">
                                    &nbsp;<asp:Label ID="lblcuentaaprob" runat="server"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnguardar0" runat="server" style="height: 26px" 
                                        Text="Enviar" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    Casos pendientes&nbsp;Revisar&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                    &nbsp; 
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="obsinc" HeaderText="Observación de Inconsistencia" />
                            <asp:BoundField DataField="inconsistencia" HeaderText="Tipo Inconsistencia" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="idusuariorep" HeaderText="Agente Reporta" />
                            <asp:BoundField DataField="Nivel" HeaderText="Nivel" />
                            <asp:BoundField DataField="Registro_Numerico" HeaderText="Cuenta Financiera"/>
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
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtgaprobado" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="custcode_ac" HeaderText="Cust Code" />
                            <asp:BoundField DataField="usuario_asignado" HeaderText="Usuario Genera Inconsistencia" />
                            <asp:BoundField DataField="inconsistencia" HeaderText="Tipo Inconsistencia" />
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
