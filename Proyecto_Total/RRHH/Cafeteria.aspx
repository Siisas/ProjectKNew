<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Cafeteria.aspx.vb" Inherits="digitacion.Cafeteria" %>

<%@ Register Src="../menu.ascx" TagPrefix="uc1" TagName="menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Kamilion - ERP</title>
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
 font-family:Arial, Helvetica, sans-serif;
   font-size:xx-large;
   color:navy
   }
   
    
        .style2
        {
            width: 100%;
        }
 
        
      .style1
        {
            width: 100%; height:100%;
        }
 
        .textotittabla
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #E2E8FA;
	width: 15%;
}
   
        .textotittabla
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
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
     
        .style3
        {
            color: #000099;
            width: 80%;
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }
        .style5
        {
            width: 80%;
        }
        .style6
        {
            width: 624px;
        }
        .style7
        {
            width: 411px;
        }
        .style8
        {
            width: 864px;
        }
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 7%;
            background: #E2E8FA;
        }
        .auto-style2 {
            height: 31px;
            }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 274px;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 274px;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 17px;
            background: #E2E8FA;
        }
        .auto-style6 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 31px;
        }
        .auto-style9 {
            width: 20%;
        }
        .auto-style11 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            background: #E2E8FA;
            height: 18px;
        }
        .auto-style12 {
            height: 18px;
        }
        .auto-style13 {
            height: 9px;
        }
        .auto-style15 {
            height: 18px;
            width: 153px;
        }
        .auto-style16 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 106px;
        }
        .auto-style17 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 106px;
        }
        .auto-style18 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 25px;
            background: #E2E8FA;
        }
        .auto-style19 {
            width: 35%;
            height: 25px;
        }
        .auto-style20 {
            width: 100%;
            border-collapse: collapse;
            border: 2px solid #5D7B9D;
        }
        .auto-style21 {
            background-color: #FFFFFF;
        }
        .auto-style22 {
            height: 24px;
            background-color: #FFFFFF;
        }
        .auto-style23 {
            height: 18px;
            width: 173px;
        }
        .auto-style24 {
            background-color: #FFFFFF;
            width: 173px;
        }
        .auto-style25 {
            height: 24px;
            background-color: #FFFFFF;
            width: 173px;
        }
        .auto-style26 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            background: #E2E8FA;
            height: 1px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td class="auto-style9">
                                &nbsp;</td>
                            <td align="left" class="titulo">
                                Kamilion Comunicaciones - ERP</td>
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
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>                    
                <td class="style4">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Cafeteria</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td valign="top" class="style5">
                    <table class="style2">
                        <tr>
                            <td style="width: 30%">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td style="width: 70%">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Registro</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="auto-style16">
                </td>
                <td class="auto-style17">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Codigo o Documento</td>
                            <td class="celdascons">                                
                                
                                <asp:TextBox ID="TxtCodoDoc" runat="server"></asp:TextBox>
                                
                            </td>                            
                            <td class="textotittabla">
                                Codigo</td>
                            <td class="celdascons">                                
                                <asp:Label ID="LblCodigo" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Documento</td>
                            <td class="celdascons">                                
                                
                                <asp:Label ID="LblDocumento" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">                                
                                <asp:Label ID="LblNombre" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style18">
                                Cargo</td>
                            <td class="auto-style19">                                
                                
                                <asp:Label ID="LblCargo" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style18">
                                Fecha ingreso</td>
                            <td class="auto-style19">                                
                                <asp:Label ID="LblFechaIng" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estado</td>
                            <td class="celdascons">                                
                                
                                <asp:Label ID="LblEstado" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">
                                Fecha Compra</td>
                            <td class="celdascons">                                
                                <asp:Label ID="LblFechaActual" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                </td>
                <td class="auto-style16">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="0">
                    <tr>
                    <td class="style6">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" UseSubmitBehavior="False" />
                            &nbsp;&nbsp;
                                &nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;</td>
                    <td class="style7">                               
                            &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                &nbsp;&nbsp;
                                </td>
                    </tr>
                    </table>
                                
                                
                            </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                </td>
                <td class="auto-style4">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="auto-style5" colspan="4"><center style="font-size: x-large">
                                Compra</center></td>
                        </tr>
                        <tr>
                            <td class="auto-style11" colspan="2">
                                Nombre Producto</td>
                            <td class="auto-style12" colspan="2">
                                <asp:TextBox ID="TxtProducto" runat="server" Width="213px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13" colspan="4">
                    <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" style="height: 26px" />
                                <asp:Label ID="lblcodigoventa" runat="server" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>                            
                            <td class="auto-style26" colspan="4">
                                <table class="auto-style20">
                                    <tr>
                                        <td class="auto-style12">CODIGO</td>
                                        <td class="auto-style12">PRODUCTO</td>
                                        <td class="auto-style23">CANTIDAD</td>
                                        <td class="auto-style12">PRECIO UNITARIO</td>
                                        <td class="auto-style12">SUBTOTAL</td>
                                        <td class="auto-style12"></td>
                                    </tr>                                    
                                    <asp:Panel ID="Panel1" runat="server" width="874px" Height="16px" Visible="false">
                                    <tr>
                                        
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProCod1" runat="server" ReadOnly="True"></asp:TextBox>                                                      
                                        </td>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProNom1" runat="server" ReadOnly="True"></asp:TextBox>                   
                                        </td>
                                        <td class="auto-style24">
                                            <asp:TextBox ID="Can1" runat="server" AutoPostBack="True" MaxLength="2"></asp:TextBox>
                                             <asp:CompareValidator ID="CVCan1" runat="server" ErrorMessage="Revise cantidad 1" ControlToValidate="Can1" Operator="DataTypeCheck"  Type="Integer" >*</asp:CompareValidator>
                                             </td>
                                        
                                        <td class="auto-style21">
                                            <asp:Label ID="pre1" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:Label ID="presub1" runat="server"></asp:Label>
                                        </td>
                                      <td class="auto-style21">
                                            <asp:Button ID="btnp1" runat="server" Text="Eliminar" Visible="False" />
                                        </td>
                                    </tr>
                                      </asp:Panel>
                                    <asp:Panel ID="Panel2" runat="server" width="874px" Height="16px" Visible="False">
                                    <tr>
                                         <td class="auto-style21">
                                            <asp:TextBox ID="Procod2" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProNom2" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style24">
                                            <asp:TextBox ID="Can2" runat="server" MaxLength="2" AutoPostBack="True"></asp:TextBox>
                                             <asp:CompareValidator ID="CVCan2" runat="server" ErrorMessage="Revise cantidad 2" ControlToValidate="Can2" Operator="DataTypeCheck"  Type="Integer" >*</asp:CompareValidator>
                                        </td>
                                       
                                        <td class="auto-style21">
                                            <asp:Label ID="pre2" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:Label ID="presub2" runat="server"></asp:Label>
                                        </td>
                                             <td class="auto-style21">
                                            <asp:Button ID="btnp2" runat="server" Text="Eliminar" Visible="False" />
                                        </td>
                                    </tr>
                                       </asp:Panel>
                                        <asp:Panel ID="Panel3" runat="server" width="874px" Height="16px" Visible="False">
                                    <tr>
                                        <td class="auto-style22">
                                            <asp:TextBox ID="ProCod3" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style22">
                                            <asp:TextBox ID="ProNom3" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style25">
                                            <asp:TextBox ID="Can3" runat="server" MaxLength="2" AutoPostBack="True"></asp:TextBox>
                                             <asp:CompareValidator ID="CVCan3" runat="server" ErrorMessage="Revise cantidad 3" ControlToValidate="Can3" Operator="DataTypeCheck"  Type="Integer" >*</asp:CompareValidator>
                                        </td>
                                       
                                        <td class="auto-style22">
                                            <asp:Label ID="pre3" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style22">
                                            <asp:Label ID="presub3" runat="server"></asp:Label>
                                        </td>
                                         <td class="auto-style22">
                                            <asp:Button ID="btnp3" runat="server" Text="Eliminar" Visible="False" />
                                        </td>
                                    </tr>
                                        </asp:Panel>
                                        <asp:Panel ID="Panel4" runat="server" width="874px" Height="16px" Visible="False">
                                    <tr>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProCod4" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProNom4" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style24">
                                            <asp:TextBox ID="Can4" runat="server" MaxLength="2" AutoPostBack="True"></asp:TextBox>
                                             <asp:CompareValidator ID="CVCan4" runat="server" ErrorMessage="Revise cantidad 4" ControlToValidate="Can4" Operator="DataTypeCheck"  Type="Integer" >*</asp:CompareValidator>
                                        </td>
                                        
                                        <td class="auto-style21">
                                            <asp:Label ID="pre4" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:Label ID="presub4" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:Button ID="btnp4" runat="server" Text="Eliminar" Visible="False" />
                                        </td>
                                    </tr>
                                            </asp:Panel>
                                        <asp:Panel ID="Panel5" runat="server" width="874px" Height="16px" Visible="False">
                                    <tr>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProCod5" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProNom5" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style24">
                                            <asp:TextBox ID="Can5" runat="server" MaxLength="2" AutoPostBack="True"></asp:TextBox>
                                             <asp:CompareValidator ID="CVCan5" runat="server" ErrorMessage="Revise cantidad 5" ControlToValidate="Can5" Operator="DataTypeCheck"  Type="Integer" >*</asp:CompareValidator>
                                        </td>

                                        <td class="auto-style21">
                                            <asp:Label ID="pre5" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:Label ID="presub5" runat="server"></asp:Label>
                                        </td>
                                         <td class="auto-style21">
                                            <asp:Button ID="btnp5" runat="server" Text="Eliminar" Visible="False" />
                                        </td>
                                    </tr>
                                        </asp:Panel>
                                        <asp:Panel ID="Panel6" runat="server" width="874px" Height="16px" Visible="False">
                                    <tr>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProCod6" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProNom6" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style24">
                                            <asp:TextBox ID="Can6" runat="server" MaxLength="2" AutoPostBack="True"></asp:TextBox>
                                             <asp:CompareValidator ID="CVCan6" runat="server" ErrorMessage="Revise cantidad 6" ControlToValidate="Can6" Operator="DataTypeCheck"  Type="Integer" >*</asp:CompareValidator>
                                        </td>
                                        
                                        <td class="auto-style21">
                                            <asp:Label ID="pre6" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:Label ID="presub6" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:Button ID="btnp6" runat="server" Text="Eliminar" Visible="False" />
                                        </td>
                                    </tr>
                                             </asp:Panel>
                                        <asp:Panel ID="Panel7" runat="server" width="874px" Height="16px" Visible="False">
                                    <tr>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProCod7" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:TextBox ID="ProNom7" runat="server" ReadOnly="True"></asp:TextBox>
                                        </td>
                                        <td class="auto-style24">
                                            <asp:TextBox ID="Can7" runat="server" MaxLength="2" AutoPostBack="True"></asp:TextBox>
                                             <asp:CompareValidator ID="CVCan7" runat="server" ErrorMessage="Revise cantidad 7" ControlToValidate="Can7" Operator="DataTypeCheck"  Type="Integer" >*</asp:CompareValidator>
                                        </td>
                                       
                                        <td class="auto-style21">
                                            <asp:Label ID="pre7" runat="server"></asp:Label>
                                        </td>
                                        <td class="auto-style21">
                                            <asp:Label ID="presub7" runat="server"></asp:Label>
                                        </td>
                                         <td class="auto-style21">
                                            <asp:Button ID="btnp7" runat="server" Text="Eliminar" Visible="False" />
                                        </td>
                                    </tr>
                                             </asp:Panel>
                                </table>
                            </td>
                        </tr>                                           
                        <tr>                            
                            <td class="auto-style11">
                                Total a pagar</td>
                            <td class="auto-style15" colspan="2">
                                <asp:Label ID="LblTotal" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style12">
                                <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" />
                            </td>
                        </tr>                                           
                        </table>
                </td>
                <td class="auto-style3">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        </table>
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    </form>
</body>
</html>
