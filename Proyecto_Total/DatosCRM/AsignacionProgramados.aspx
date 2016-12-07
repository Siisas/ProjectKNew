<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="digitacion.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asignacion Programados</title>


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
                        <asp:Label ID="lblmsg" runat="server" Style="color: #FF3300"></asp:Label>
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
                        <asp:Label ID="lblmsg0" runat="server" Style="font-size: medium; font-style: italic">Asignación Programados Casos Claro Datos</asp:Label>
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
                        <asp:Button ID="Button1" runat="server" Style="height: 26px" Text="Buscar" />
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
                                <td class="auto-style7" colspan="3">
                                    <asp:Label ID="lblcantidadtot" runat="server"></asp:Label>
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
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="CADUCADO">CADUCADO</asp:ListItem>
                                        <asp:ListItem Value="VIGENTE">VIGENTE</asp:ListItem>
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
                                <td style="width: 50%">
                                    Casos encontrados:
                                    <asp:Label ID="lblprueba" runat="server"></asp:Label>
                                </td>
                                <td style="width: 50%">
                                    Numero de ingenieros:
                                    <asp:Label ID="lblingenieros" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 50%">                                    
                                    <asp:GridView ID="dtgbusqueda" runat="server" AllowPaging="True" CellPadding="4"
                                        ForeColor="#333333" GridLines="None" Width="80%" Style="font-size: x-small" EnableModelValidation="True">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <FooterStyle BackColor="#284775" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                                </td>
                                <td style="width: 50%; vertical-align:super;">

                                    <asp:GridView ID="dtgUsuarios" runat="server" AllowPaging="True" CellPadding="4"
                                        ForeColor="#333333" GridLines="None" Width="80%" Style="font-size: x-small; vertical-align:super" EnableModelValidation="True" >
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" 
                                            HorizontalAlign="Left" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                    <td class="celdasder">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="celdasder">
                        &nbsp;
                    </td>
                    <td>
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
                        Casos Programados sin Asignar:
                        <asp:Label ID="lblcantidad" runat="server"></asp:Label>
                        &nbsp;Caducados:
                        <asp:Label ID="lblcaduca" runat="server"></asp:Label>
                        &nbsp; Vigentes:
                        <asp:Label ID="lblvigente" runat="server"></asp:Label>
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
                          <table style="width: 100%; height: 100%; background-color: #5D7B9D; font-size: x-small;">
                              <tr>
                                  <td style="color: #FFFFFF; width: 15%">
                                      Caso
                                  </td>
                                  <td style="color: #FFFFFF; width: 15%">
                                      Usuario Programa
                                  </td>
                                  <td style="color: #FFFFFF; width: 15%">
                                      Fecha Registra
                                  </td>
                                  <td style="color: #FFFFFF; width: 15%">
                                      Fecha Programado
                                  </td>
                                  <td style="color: #FFFFFF; width: 15%">
                                      No.Programado
                                  </td>
                                  <td style="color: #FFFFFF; width: 15%">
                                      Campaña
                                  </td>
                                  <td style="color: #FFFFFF; width: 15%">
                                      Estado
                                  </td>
                          </table>
                      </div>
                        <div style="overflow: auto; width: 100%; height: 500px;">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" 
                                ForeColor="#333333" GridLines="None" HorizontalAlign="Center" PageSize="1000" 
                                showheader="False" Style="font-size: x-small" Width="100%">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" HorizontalAlign="Justify" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" 
                                    HorizontalAlign="Center" VerticalAlign="Top" />
                                <Columns>
                                    <asp:BoundField DataField="idcaso" HeaderText="Caso" >
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>

                                    <asp:BoundField DataField="idusuario" HeaderText="Usuario Programa" >
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>

                                    <asp:BoundField DataField="fcreg" HeaderText="Fecha registra" >
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    

                                    <asp:BoundField DataField="fcprogram" HeaderText="Fecha Programada" >
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    
                                    <asp:BoundField DataField="cuenta" HeaderText="No. Programado" >
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    
                                    <asp:BoundField DataField="bandeja" HeaderText="Campaña" >
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    
                                    <asp:BoundField HeaderText="Estado" >
                                    <ItemStyle Width="15%" />
                                    </asp:BoundField>
                                    
                                </Columns>
                                <EditRowStyle BackColor="#999999" HorizontalAlign="Center" 
                                    VerticalAlign="Top" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333"
                                    HorizontalAlign="Justify" VerticalAlign="Top" />
                            </asp:GridView>
                        </div>
                        <asp:GridView ID="dtgbusqueda0" runat="server" AllowPaging="True" 
                            CellPadding="4" EnableModelValidation="True" ForeColor="#333333" 
                            GridLines="None" PageSize="1000" Style="font-size: x-small" Visible="False" 
                            Width="80%">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <FooterStyle BackColor="#284775" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
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
