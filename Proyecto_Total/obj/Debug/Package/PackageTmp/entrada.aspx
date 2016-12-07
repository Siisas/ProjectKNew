<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="entrada.aspx.vb" Inherits="digitacion.entrada" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
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
	font-size: small;
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
   
           .style1
           {
               width: 100%;
           }
           
.textotit
{ 
 font-family:Arial, Helvetica, sans-serif;
   font-size:medium;
   color:Navy;
   font-weight:bold
   }
   
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td style="width: 10%">
                                &nbsp;<asp:Image ID="Image1" runat="server" Height="39px" ImageUrl="~/LOGO.jpg" Width="163px" />
                            </td>
                            <td align="left" class="titulo" style="width:90%">
                                Kamilion Comunicaciones ERP</td>
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
                    <table style="width:100%; height:100%">
                        <tr>
                            <td style="width:20%; height:20%">
                            </td>
                            <td style="width:40%; height:20%">
                            </td>
                            <td style="width:40%; height:20%">
                            </td>
                        </tr>
                        <tr>
                            <td style="width:20%; height:60%">
                            </td>
                            <td style="width:40%; height:60%">
                                <table class="style1" frame="border" 
                                    style=" height:100%;  width:100%; border-style: groove; border-width: thin; background-color:#EEEEEE">
                                    <tr>
                                        <td class="textotit" style="width:30%; height:30%">
                                            Usuario</td>
                                        <td style="width:70%; height:30%">
                                            <asp:TextBox ID="Txtusuario" runat="server" Height="100%"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="textotit" style="width:30%; height:30%">
                                            Contraseña</td>
                                        <td style="width:70%; height:30%">
                                            <asp:TextBox ID="txtpassword" runat="server" Height="100%" TextMode="Password"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width:30%; height:35%">
                                            &nbsp;</td>
                                        <td style="width:70%; height:35%">
                                            <asp:Button ID="btnentrar" runat="server" Text="Ingresar" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width:40%; height:60%">
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="width:100%; height:20%">
                                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                </td>
                <td class="celdasder">
                </td>
            </tr>
        </table>
    </div>
</form>
   
</body>
</html>
