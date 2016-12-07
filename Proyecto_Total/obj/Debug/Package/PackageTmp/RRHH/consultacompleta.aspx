<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consultacompleta.aspx.vb" Inherits="digitacion.consultacompleta" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
	font-size: xx-small;
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
 
        
        .style3
        {
            color: #000099;
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
 
        .style4
        {
            width: 495px;
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
    <div>
    
    </div>
    
        <table style="width: 100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    <table style="border-style: outset; border-width: 1px; width:100%">
                        <tr>
                            <td style="width:20%">
                                &nbsp;</td>
                            <td align="left" class="titulo">
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
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
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
                        style="font-size: medium; font-style: italic">Consulta Recursos Humanos</asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td style="width:15%" valign="top">
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
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Datos Personales</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="width:15%; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                &nbsp;<table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Código</td>
                            <td class="style4">
                                <asp:TextBox ID="txtcodigo" runat="server" Width="59%" Height="22px"></asp:TextBox>
                                </td>
                            <td class="textotittabla">
                                Documento</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtdocumento" runat="server" Width="59%" Height="22px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="style4">
                                <asp:TextBox ID="txtnombre" runat="server" Width="59%" Height="22px"></asp:TextBox>
                                </td>
                            <td class="textotittabla">
                                Apellido</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtapellido" runat="server" Width="59%" Height="22px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estado</td>
                            <td class="style4">
                                <asp:DropDownList ID="drlestado" runat="server">
                                    <asp:ListItem Value="0">- Elija una opción -</asp:ListItem>
                                    <asp:ListItem Value="A">Activo</asp:ListItem>
                                    <asp:ListItem Value="I">Inactivo</asp:ListItem>
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Área</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlarea" runat="server" Height="26px" 
                                    style="margin-bottom: 0px" Width="333px">
                                </asp:DropDownList>
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
                                <asp:Button ID="btnconsultar" runat="server" Text="Consultar" Width="91px" />
                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnxls" runat="server" Text="Exportar Excel" Width="91px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton ID="lnkgneral" runat="server">Ver General</asp:LinkButton>
&nbsp;&nbsp;<asp:Label ID="lblcantgral" runat="server"></asp:Label>
                            &nbsp;
                                <asp:LinkButton ID="lnkhistorico" runat="server">Ver Histórico</asp:LinkButton>
                &nbsp;<asp:Label ID="lblcanthist" runat="server"></asp:Label>
                                &nbsp;
                                <asp:LinkButton ID="lnkcheck" runat="server">Ver Check</asp:LinkButton>
                &nbsp;&nbsp;
                                <asp:Label ID="lblcantcheck" runat="server"></asp:Label>
                            &nbsp;&nbsp;
                                <asp:LinkButton ID="lnkcheck0" runat="server">Ver Novedades</asp:LinkButton>
                &nbsp;
                                <asp:Label ID="lblcantnov" runat="server"></asp:Label>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                                &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtgcheck" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" Visible="False">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                          <asp:TemplateField HeaderText="Documento">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink2" runat="server" 
                                            text='<%#Databinder.Eval(container, "DataItem.rutadoc")%>' 
                                            NavigateUrl='<%#Databinder.Eval(container, "DataItem.rutadoc","~/RRHH/data_check/{0}")%>' 
                                            Target='_blank'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                               
                            <asp:BoundField DataField="iddetallchek" HeaderText="ID" />
                            <asp:BoundField DataField="descripciontipodoc" HeaderText="Tipo Documento" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtghistorico" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="68%" 
            style="font-size: x-small" Visible="False">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                          <asp:BoundField DataField="idactualizacion" HeaderText="ID" />
                            <asp:BoundField DataField="tipoactualizacion" HeaderText="Actualización" />
                            <asp:BoundField DataField="descripcionact" HeaderText="Descripción" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
    
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                          <asp:TemplateField HeaderText="Foto">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" text='<%#Databinder.Eval(container, "DataItem.rutafoto")%>' NavigateUrl='<%#Databinder.Eval(container, "DataItem.rutafoto","~/RRHH/data_fotos/{0}")%>' Target='_blank'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Hoja de Vida">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink3" runat="server" 
                                            text='<%#Databinder.Eval(container, "DataItem.rutahv")%>' 
                                            NavigateUrl='<%#Databinder.Eval(container, "DataItem.rutahv","~/RRHH/data_hv/{0}")%>' 
                                            Target='_blank'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            <asp:BoundField DataField="documento" HeaderText="Documento" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="codigo" HeaderText="Código" />
                            <asp:BoundField DataField="epsdes" HeaderText="EPS" />
                            <asp:BoundField DataField="pensiondes" HeaderText="FPS" />
                            <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                            <asp:BoundField DataField="telefono" HeaderText="Télefono" />
                            <asp:BoundField DataField="fcnac" HeaderText="Fecha Nacimiento" />
                            <asp:BoundField DataField="email" HeaderText="E-mail" />
                            <asp:BoundField DataField="genero" HeaderText="Género" />
                            <asp:BoundField DataField="estadocivil" HeaderText="Estado Civil" />
                            <asp:BoundField DataField="hijos" HeaderText="No. Hijos" />
                            <asp:BoundField DataField="cuenta" HeaderText="Cuenta" />
                            <asp:BoundField DataField="rh" HeaderText="RH" />
                            <asp:BoundField DataField="deporte" HeaderText="Deporte" />
                            <asp:BoundField DataField="escolaridad" HeaderText="Escolaridad" />
                            <asp:BoundField DataField="profesion" HeaderText="Profesion" />
                            <asp:BoundField DataField="estudia" HeaderText="Estudia?" />
                            <asp:BoundField DataField="obs" HeaderText="Observaciones" />
                            <asp:BoundField DataField="empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Turno" HeaderText="Turno" />
                            <asp:BoundField DataField="cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="salario" HeaderText="Salario" />
                            <asp:BoundField DataField="auxtransp" HeaderText="Aux. Transporte" />
                            <asp:BoundField DataField="bonificacion" HeaderText="Bonificacion" />
                            <asp:BoundField DataField="nombreproyecto" HeaderText="Proyecto" />
                            <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="area" HeaderText="Área" />
                            <asp:BoundField DataField="tipocontrato" HeaderText="Tipo Contrato" />
                            <asp:BoundField DataField="fcing" HeaderText="Fecha Ingreso" />
                            <asp:BoundField DataField="fcretiro" HeaderText="Fecha Retiro" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="carne" HeaderText="Carné" />
                            <asp:BoundField DataField="chaleco" HeaderText="chaleco" />
                            <asp:BoundField DataField="diadema" HeaderText="diadema" />
                            <asp:BoundField DataField="locker" HeaderText="locker" />
                            <asp:BoundField DataField="uniforme" HeaderText="Uniforme" />

                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <asp:GridView ID="dtgxls" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" ForeColor="#333333" GridLines="None">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="documento" HeaderText="Documento" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="codigo" HeaderText="Código" />
                            <asp:BoundField DataField="epsdes" HeaderText="EPS" />
                            <asp:BoundField DataField="pensiondes" HeaderText="FPS" />
                            <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                            <asp:BoundField DataField="telefono" HeaderText="Télefono" />
                            <asp:BoundField DataField="fcnac" HeaderText="Fecha Nacimiento" />
                            <asp:BoundField DataField="email" HeaderText="E-mail" />
                            <asp:BoundField DataField="genero" HeaderText="Género" />
                            <asp:BoundField DataField="estadocivil" HeaderText="Estado Civil" />
                            <asp:BoundField DataField="hijos" HeaderText="No. Hijos" />
                            <asp:BoundField DataField="cuenta" HeaderText="Cuenta" />
                            <asp:BoundField DataField="rh" HeaderText="RH" />
                            <asp:BoundField DataField="deporte" HeaderText="Deporte" />
                            <asp:BoundField DataField="escolaridad" HeaderText="Escolaridad" />
                            <asp:BoundField DataField="profesion" HeaderText="Profesion" />
                            <asp:BoundField DataField="estudia" HeaderText="Estudia?" />
                            <asp:BoundField DataField="obs" HeaderText="Observaciones" />
                            <asp:BoundField DataField="empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Turno" HeaderText="Turno" />
                            <asp:BoundField DataField="cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="salario" HeaderText="Salario" />
                            <asp:BoundField DataField="auxtransp" HeaderText="Aux. Transporte" />
                            <asp:BoundField DataField="bonificacion" HeaderText="Bonificacion" />
                            <asp:BoundField DataField="nombreproyecto" HeaderText="Proyecto" />
                            <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="area" HeaderText="Área" />
                            <asp:BoundField DataField="tipocontrato" HeaderText="Tipo Contrato" />
                            <asp:BoundField DataField="fcing" HeaderText="Fecha Ingreso" />
                            <asp:BoundField DataField="fcretiro" HeaderText="Fecha Retiro" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="carne" HeaderText="Carné" />
                            <asp:BoundField DataField="chaleco" HeaderText="chaleco" />
                            <asp:BoundField DataField="diadema" HeaderText="diadema" />
                            <asp:BoundField DataField="locker" HeaderText="locker" />
                            <asp:BoundField DataField="uniforme" HeaderText="Uniforme" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
                    <asp:GridView ID="dtgnovedad" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        Visible="False">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idreg" HeaderText="ID" />
                            <asp:BoundField DataField="cod" HeaderText="Código" />
                            <asp:BoundField DataField="fcnovedad" HeaderText="Fecha Novedad" />
                            <asp:BoundField DataField="descripcioninasistencia" HeaderText="Tipo Novedad" />
                            <asp:BoundField DataField="dias" HeaderText="Dias Nov" />
                            <asp:BoundField DataField="horas" HeaderText="Horas Nov" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="repone" HeaderText="Repone" />
                            <asp:BoundField DataField="reportanom" HeaderText="Reporta Nom" />
                            <asp:BoundField DataField="desctipo" HeaderText="Tipificación" />
                            <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuarioreg" HeaderText="Usuario Reg" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            </table>
    
    </form>
</body>
</html>
