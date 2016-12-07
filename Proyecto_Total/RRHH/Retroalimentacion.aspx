<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Retroalimentacion.aspx.vb" Inherits="digitacion.Retroalimentacion" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    
  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Recepcion").datepicker();
          $('#TxtFecha_Recepcion').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <!-- Fin Script jQuery Datepicker --->
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
        

</style>
</head>
<body>
    <form id="form1" runat="server">    
        <table style="width:100%; height: 100%">
        <asp:Panel ID="Panelkam" runat="server">
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td style="width:20%">
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
                <td class="style4">
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
                <td class="style4">
                    <asp:Label ID="lblmsg0" runat="server" 
                        style="font-size: medium; font-style: italic">Registro Recursos Humanos</asp:Label>
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
            </asp:Panel>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <table style="width:100%; height: 100%">
                        <tr>
                        <td class="celdascons">                            
                              <table border="1" style="width:100%; height: 100%">
                              <tr>
                              <td class="celdascons">
                                <center><asp:Image ID="Image1" runat="server" Height="87px" ImageUrl="~/LOGO.jpg" BorderStyle="Dashed"/></center>
                              </td>
                              </tr>
                               </table>
                          </td>
                            <td class="celdascons">
                              <table border="1" style="width:100%; height: 100%">
                                <tr>
                                <td class="celdascons" style="color: #000000">
                                    <center style="color: #000000; font-size: small;">SISTEMA DE GESTION DE CALIDAD</center></td>
                                <td class="auto-style79" colspan="2">
                                    <center style="color: #000000; font-size: small;">GOP-F-19</center></td>
                                </tr>
                                <tr>
                                    <td class="celdascons" style="color: #000000">
                                        <center style="color: #000000; font-size: small;">GESTION DE OPERACIONES</center>
                                    </td>
                                    <td class="celdascons" style="color: #000000">
                                        <center style="color: #000000; font-size: small;">Fecha Registro</center></td>
                                    <td class="celdascons" style="color: #000000">
                                        <center style="color: #000000; font-size: small;">Codigo</center></td>
                                </tr>
                                <tr>
                                    <td class="celdascons" style="color: #000000">
                                        <center style="color: #000000; font-size: small;">FORMATO DE RETROALIMENTACION</center></td>
                                    <td class="auto-style66" rowspan="2">
                                        <center><asp:Label ID="Lblfechareg" runat="server" ForeColor="Black" 
                                                Font-Size="Small"></asp:Label></center>
                                    </td>
                                    <td class="auto-style63" rowspan="2">
                                        <center><asp:Label ID="Lblcodretro" runat="server" ForeColor="Black" 
                                                Font-Size="Small"></asp:Label></center>
                                    </td>
                                </tr>
                            </table>
                          </td>
                        </tr>
                  </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <table border="3" style="width:100%; height: 100%">
                        <tr>
                            <td colspan="2">
                                <center style="color: #000000">INFORMACION GENERAL</center>
                            </td>                           
                        </tr> 
                        <tr>                           
                                 <td class="celdascons" style="color: #000000; font-size: small;">
                                Fecha de Retroalimentacion
                                </td>
                                <td class="celdascons">
                                    <asp:Label ID="Lblfcreg" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                    <asp:TextBox ID="txtfcreg" runat="server" Width="42%"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtfcreg" ErrorMessage="Verifique la fecha" Type="Date" Operator="DataTypeCheck">*</asp:CompareValidator>
                                </td>
                            
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;">
                                Nombre de la Persona A Retroalimentar</td>
                            <td class="celdascons">
                                  <asp:Label ID="Lblnoma" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                      <asp:DropDownList ID="drlnomaretro" runat="server" Height="23px" Width="271px">
                               </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>                            
                            <td  class="celdascons" style="color: #000000; font-size: small;">
                                Area o Nivel de Gestion</td>
                              <td class="celdascons">
                                    <asp:Label ID="Lblarea" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                          <asp:DropDownList ID="drlArea" runat="server" Height="23px" Width="271px">
                           </asp:DropDownList>
                            
                            </td>
                        </tr>
                        <tr>
                            <td class="celdascons" style="color: #000000; font-size: small;">
                               Nombre de la Persona que Retroalimenta</td>
                            <td class="celdascons">
                                <asp:Label ID="Lblnomq" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                <asp:DropDownList ID="drlnomqretro" runat="server" Height="23px" Width="271px">
                               </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" class="celdascons">
                                <center style="color: #000000">CAUSAS DE RETROALIMENTACION</center>
                            </td>                           
                        </tr> 
                        <tr>
                            <td class="celdascons">
                                <center style="color: #000000">Causa</center>
                            </td>
                            <td class="celdascons">
                                <center style="color: #000000">Descripcion de la Causa</center>
                            </td>                            
                        </tr> 
                        <tr>   
                            <td class="celdascons">
                             <asp:Label ID="Lblcau" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label> 
                                <center><asp:TextBox ID="txtcausa" runat="server" Height="23px" Width="271px"></asp:TextBox></center>
                            </td>
                            <td class="celdascons">
                                   <asp:Label ID="Lbldcau" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label> 
                                    <center><asp:TextBox ID="txtdescausa" runat="server" Width="90%" Height="100%" TextMode="MultiLine" style="margin-left: 0px"></asp:TextBox></center>
                            </td>                            
                        </tr>                        
                        <tr>
                             <td class="celdascons">
                                  <asp:Label ID="Lblcau0" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label> 
                                    <center><asp:TextBox ID="txtcausa0" runat="server" Height="23px" Width="271px"></asp:TextBox></center>
                             </td>
                             <td class="celdascons">
                                  <asp:Label ID="Lbldcau0" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label> 
                                    <center><asp:TextBox ID="txtdescausa0" runat="server" Width="90%" Height="10%" TextMode="MultiLine"></asp:TextBox></center>
                             </td>
                        </tr>
                        <tr>
                            <td class="celdascons">
                                 <asp:Label ID="lblcau1" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                 <center><asp:TextBox ID="txtcausa1" runat="server" Height="23px" Width="271px"></asp:TextBox></center>
                            </td>
                            <td class="celdascons">
                                <asp:Label ID="Lbldcau1" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label> 
                                <center><asp:TextBox ID="txtdescausa1" runat="server" Width="90%" Height="100%" TextMode="MultiLine"></asp:TextBox></center>
                            </td>
                        </tr>
                        <tr>
                             <td class="celdascons">
                                 <asp:Label ID="Lblcau2" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label> 
                                 <center><asp:TextBox ID="txtcausa2" runat="server" Height="23px" Width="271px"></asp:TextBox></center>
                                 </td>
                            <td class="celdascons">
                                     <asp:Label ID="Lbldcau2" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label> 
                                     <center><asp:TextBox ID="txtdescausa2" runat="server" Width="90%" Height="100%" TextMode="MultiLine"></asp:TextBox></center>
                             </td>
                        </tr>
                        <tr>
                            <td class="celdascons">
                                    <asp:Label ID="Lblcau3" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                    <center><asp:TextBox ID="txtcausa3" runat="server" Height="23px" Width="271px"></asp:TextBox></center>
                            </td>                              
                              <td class="celdascons">
                                    <asp:Label ID="Lbldcau3" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label> 
                                    <center><asp:TextBox ID="txtdescausa3" runat="server" Width="90%" Height="100%" TextMode="MultiLine"></asp:TextBox></center>
                            </td>
                       </tr>
                       <tr>
                       <td colspan="2" class="celdascons">             
                               <center style="color: #000000; font-size: small;"> Observacion de la persona que realiza la Retroalimentacion</center>
                               <asp:Label ID="Lblobs" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                               <center><asp:TextBox ID="txtobsper" runat="server" Height="40%" TextMode="MultiLine" Width="80%" style="margin-left: 0px"></asp:TextBox></center>
                             </td>  
                             </tr>  
                                 <tr>
                       <td colspan="2" class="celdascons">             
                                 <center style="color: #000000; font-size: small;">Compromiso del Retroalimentado</center>
                                 <asp:Label ID="Lblcom" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label> 
                                 <center><asp:TextBox ID="txtcomre" runat="server" Height="40%" TextMode="MultiLine" Width="80%"></asp:TextBox></center>
                        </td>
                        </tr> 
                        <tr>
                       <td colspan="2" class="celdascons">             
                               <center style="color: #000000; font-size: small;">Conclusion final y/o Plan de Accion a ejecutar</center>
                               <asp:Label ID="Lblconf" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                               <center><asp:TextBox ID="txtconfin" runat="server" Height="40%" TextMode="MultiLine" Width="80%"></asp:TextBox></center>
                               </td>  
                             </tr>  
                        <tr>
                            <td class="celdascons">
                                <center style="color: #000000; font-size: small;">FIRMA DEL RETROALIMENTADO</center>
                            </td>
                            <td class="celdascons">
                                <center style="color: #000000; font-size: small;">FIRMA DE LA PERSONA QUE REALIZA LA RETROALIMENTACION</center>
                            </td>
                            </tr> 
                            <tr>
           <td>
                                &nbsp;
                                <br />
                                &nbsp;
                               </td>
                             <td>
                                 &nbsp;
                                 <br />
                                 &nbsp;</td>
                            </tr>
                </table>
                <br/>
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Panel ID="Plcons" runat="server" style="width:100%; height: 100%">
                <center>CONSULTAS</center>                    
                    <table border="3" style="width:100%; height: 100%">
                        <tr>
                            <td class="textotittabla">
                                Fecha de Retroalimentacion</td>
                            <td class="celdascons">
                                
                                <asp:TextBox ID="txtfcregbus" runat="server" Width="30%" ></asp:TextBox>
                                 <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtfcregbus" ErrorMessage="Verifique la fecha" Type="Date" Operator="DataTypeCheck">*</asp:CompareValidator>
                                   
                                                            </td>
                            <td class="textotittabla">
                                Area o Nivel de Gestionn</td>
                              <td class="celdascons">
                                <asp:DropDownList ID="drlAreabus" runat="server" Height="23px" Width="271px">
                           </asp:DropDownList>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre de la Persona A Retroalimentar</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlnomaretrobus" runat="server" Height="23px" Width="271px">
                               </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                               Nombre de la Persona que Retroalimenta</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlnomqretrobus" runat="server" Height="23px" Width="271px">
                               </asp:DropDownList>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Codigo Retroalimentacion</td>
                            <td class="celdascons">
                                
                                <asp:TextBox ID="txtcodbus" runat="server" Width="30%" ></asp:TextBox>
                                
                            </td>
                            <td class="textotittabla">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
                        </tr>
                        </table>
                        <br/>
                        <asp:Button ID="BtnConsultar" runat="server" style="height: 26px" Text="Consultar" />
                        &nbsp;
                        <asp:Button ID="btnguardar" runat="server" style="height: 26px" Text="Guardar" Visible="true" />
                        &nbsp;
                        <asp:Button ID="btnimprimir" runat="server" OnClientClick="javascript:window.print" style="height: 26px" Text="Imprimir" />
                        &nbsp;
                        <asp:Button ID="BtnNuevo" runat="server" Text="Nuevo" Width="68px" />
                 </asp:Panel>                    
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
