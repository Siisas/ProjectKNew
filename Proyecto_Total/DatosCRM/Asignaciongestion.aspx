<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Asignaciongestion.aspx.vb"
    Inherits="digitacion.Asignaciongestion" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">

    <title>Asignacion Gestion</title>
     <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  
 <script type="text/jscript">
     var $_$ = jQuery.noConflict();
     function pageLoad() {

         $_$("#txtfcinicio").datepicker({ dateFormat: 'dd/mm/yy' }).val();
         $_$("#txtfcfin").datepicker({ dateFormat: 'dd/mm/yy' }).val();
     }
    </script>

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
        
        
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 5px;
        }
        .style5
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 5px;
        }
        
        
        .style2
        {
            width: 100%;
        }
        
        
        .style6
        {
            width: 30%;
            height: 22px;
        }
        .style7
        {
            width: 70%;
            height: 22px;
        }
        
        
        .style3
        {
            color: #000099;
        }
        
        
        .style1
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
        
        .celdascons
        {
            width: 35%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                    <ContentTemplate>
    <div>
    </div>
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
              <%--  <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>--%>
                        <asp:Label ID="lblmsg" runat="server" Style="color: #FF3300"></asp:Label>
                <%--    </ContentTemplate>
                </asp:UpdatePanel>--%>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td class="style5">
                <uc1:menu ID="menu1" runat="server" />
            </td>
            <td class="style4">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Label ID="lblmsg0" runat="server" Style="font-size: medium; font-style: italic">Asignación Gestión Casos Claro Datos</asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
            </td>
            <td style="width: 15%" valign="top">
                <table class="style2">
                    <tr>
                        <td class="style6">
                            <asp:Label ID="lblusuario" runat="server"></asp:Label>
                        </td>
                        <td class="style7">
                            <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 30%" rowspan="1">
                            &nbsp;
                        </td>
                        <td style="width: 70%" rowspan="1">
                            <asp:Label ID="lblgrupo" runat="server"></asp:Label>
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
            <td style="width: 15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif;
                font-size: medium;" valign="top" class="style3">
                <asp:Button ID="btnguardar" runat="server" Text="Guardar" />
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                <%-- <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" />--%>
            </td>
            <td style="width: 15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif;
                font-size: medium;" valign="top" class="style3">
                <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                        <td class="textotittabla" colspan="2">
                            <center>
                                Filtros para realizar asignacion</center>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Ingeniero de Soporte
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlusuario" runat="server" Height="22px" Width="322px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Asignar Caso Individual
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="txtcaso" runat="server"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtcaso"
                                ErrorMessage="El caso debe ser un valor       numérico" Operator="DataTypeCheck"
                                Type="Double">*</asp:CompareValidator>
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
            <td style="width: 15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif;
                font-size: medium;" valign="top" class="style3">
                <%--<asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>--%>
                        <asp:Button ID="Button1" runat="server" Style="height: 26px" Text="Buscar" />
                 <%--   </ContentTemplate>
                </asp:UpdatePanel>--%>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td style="width: 15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif;
                font-size: medium;" valign="top" class="style3">
                <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                        <td class="textotittabla" colspan="4">
                            <center>
                                Filtros para realizar busqueda</center>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Casos Pendientes por Asignar
                        </td>
                        <td class="auto-style7" colspan="3" 
                            style="font-family: Arial; font-size: small; color: #000080;">
                            Datos:<asp:Label ID="lbldatos" runat="server" ForeColor="#000090"></asp:Label>
                            <br />
                            PQR:<asp:Label ID="LblPQR" runat="server" ForeColor="#000094"></asp:Label>
                            <br />
                            Sin formato:<asp:Label ID="LblSinForm" runat="server" ForeColor="#0000A5"></asp:Label>
                            <br />
                            Total:<asp:Label ID="lblcantidadtot" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Cantidad de Casos a Asignar
                        </td>
                        <td class="celdascons" colspan="3">
                            <asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcantidad"
                                ErrorMessage="Digite un valor entre 1 y 1000" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="⇐ Digite la cantidad a asignar"
                                ControlToValidate="txtcantidad" ValidationGroup="Button1"> </asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Bandeja
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlBandeja" runat="server" Width="322px">
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            Estado
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="drlEstado" runat="server" Width="322px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                   <tr>
                        <td class="textotittabla">
                            Fecha Inicio
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="txtfcinicio" runat="server" MaxLength="10"  placeholder="DD/MM/YYYY" ></asp:TextBox>
                            <asp:CompareValidator ID="CVFecha_Inicio" runat="server"
                                        ControlToValidate="txtfcinicio" ErrorMessage="Error en la fecha"
                                        Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                        </td>
                        <td class="textotittabla">
                            Fecha Fin
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="txtfcfin" runat="server" MaxLength="10"   placeholder="DD/MM/YYYY"></asp:TextBox>
                            <asp:CompareValidator ID="CVFecha_Fin" runat="server" 
                                                ControlToValidate="txtfcfin" ErrorMessage="Error en la fecha" 
                                                Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td style="width: 15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif;
                font-size: medium;" valign="top" class="style3">
                <table width="100%">
                    <tr>
                        <td style="width: 50%; vertical-align:super;" >
                        Casos Encontrados:<asp:Label 
                                ID="lblbusqueda" runat="server"></asp:Label>
<%--&nbsp;<asp:UpdatePanel ID="UpdatePanel6" runat="server">
                        <ContentTemplate>--%>
                        
                            <asp:GridView ID="dtgBusqueda" runat="server" AllowPaging="True" CellPadding="4"
                                ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                <%--            </ContentTemplate>
                        </asp:UpdatePanel>--%>
                        </td>
                        <td style="width: 50%; vertical-align:super;">
                            Ingenieros
                        <%--    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                <ContentTemplate>--%>
                                    <asp:GridView ID="dtgestad" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                        GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                          <%--      </ContentTemplate>
                            </asp:UpdatePanel>--%>
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
            <td style="width: 15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif;
                font-size: medium;" valign="top" class="style3">
               <%-- <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>--%>
                        Casos sin asignar:
                        <asp:Label ID="lblcantidad" runat="server"></asp:Label>
                    <%--</ContentTemplate>
                </asp:UpdatePanel>--%>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td class="celdascent">
             <div style=";width:100%; height:20px;">
          <table style="width: 100%; height: 100%; background-color:#5D7B9D; font-size:x-small;  "  >
          <tr>
              <td style="color: #FFFFFF; width:15%">
                  Caso
              </td>
              <td style="color: #FFFFFF; width:15%">
                  Fecha Registra
              </td>
              <td style="color: #FFFFFF; width:15%">
                  Min
              </td>
              <td style="color: #FFFFFF; width:15%">
                  Estado
              </td>
              <td style="color: #FFFFFF; width:15%">
                  Fecha sap
              </td>
              <td style="color: #FFFFFF; width:15%">
                  Campaña
              </td>
              </table>
              </div>
                <div style="overflow: auto; width: 100%; height: 500px;">
                  <%--  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>--%>
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="1000" Width="100%"
                                Style="font-size: x-small" EnableModelValidation="True" ShowHeader="False">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="Caso" HeaderText="Caso">
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Fecha registro" HeaderText="Fecha Registro">
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Min" HeaderText="Min">
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Estado" HeaderText="Estado">
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Fecha sap" HeaderText="Fecha sap">
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Bandeja" HeaderText="Bandeja">
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                       <%-- </ContentTemplate>
                    </asp:UpdatePanel>--%>
                    </div>
                    <asp:GridView ID="dtgBusqueda0" runat="server" AllowPaging="True" CellPadding="4"
                                ForeColor="#333333" GridLines="None" Width="100%" 
                    Style="font-size: x-small" EnableModelValidation="True" Visible="false" 
                    PageSize="100">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
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
        </ContentTemplate>
        </asp:UpdatePanel>
    
    </form>
</body>
</html>
