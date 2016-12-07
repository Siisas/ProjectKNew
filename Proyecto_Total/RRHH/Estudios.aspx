<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Estudios.aspx.vb" Inherits="digitacion.Estudios" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  
      <title>Kamilion - ERP</title>

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
	}
   
        .textotittabla
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #E2E8FA;
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
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            height: 27px;
            background: #E2E8FA;
        }
        .auto-style2 {
            width: 35%;
            height: 27px;
        }
        .auto-style3 {
            color: #000099;
            width: 45%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 100%">
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4" colspan="2">
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
                <td class="style4" colspan="2">
                    <asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4" colspan="2">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4" colspan="2">
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td valign="top" class="style5" colspan="2">
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
                    valign="top" class="style3" colspan="2">
                    Informacion Academica</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4" colspan="2">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center><asp:Label ID="Label1" runat="server" Text="Registros" 
                                        Font-Size="Larger"></asp:Label></center></td>                           
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Codigo</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                                </td>
                            <td class="textotittabla">
                                Documento</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtDocumento" runat="server" MaxLength="11"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtDocumento" ErrorMessage="Verifique el campo Documento" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="Lblnombre" runat="server" Font-Names="Arial" Font-Overline="False" Font-Underline="False" ForeColor="Black"></asp:Label>
                                </td>
                            <td class="textotittabla" colspan="2">
                                 <asp:Button ID="BtnValidar" runat="server" Text="Validar" />
                            </td>
                            <tr>
                            <td class="textotittabla">
                                Experiencia Academica</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="DrpExpe" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                 Nivel academico</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="DrpNivel" runat="server">
                                </asp:DropDownList>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Año aplazado</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtAñoAplaza" runat="server" Enabled="False" MaxLength="4"></asp:TextBox>
                                 <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="txtAñoAplaza" ErrorMessage="Verifique el campo Año aplazado" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                </td>
                            <td class="textotittabla">
                                 Semestre del año aplazado</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="DrlSemApla" runat="server" Enabled="False">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem Value="1">I</asp:ListItem>
                                    <asp:ListItem Value="2">II</asp:ListItem>
                                </asp:DropDownList>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Area Conocimiento</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="DrpAreaC" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                 Categoria</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="DrpCatego" runat="server">
                                    
                                </asp:DropDownList>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Semestre Certificado</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtSemCertificado" runat="server" MaxLength="2"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtSemCertificado" ErrorMessage="Verifique el campo  Semestre Certificado" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                </td>
                            <td class="textotittabla">
                                 Institucion</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="txtInstitucion" runat="server"></asp:TextBox>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                Practica</td>
                            <td class="auto-style2">
                                <asp:DropDownList ID="DrpPractica" runat="server">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem>Si</asp:ListItem>
                                    <asp:ListItem Value="No"></asp:ListItem>
                                </asp:DropDownList>
                                </td>
                            </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="auto-style3">
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" />
                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BtnConsultar" runat="server" Text="Consultar" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtBusqueda" runat="server"></asp:TextBox>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                                ControlToValidate="TxtBusqueda" ErrorMessage="El Codigo debe ser numérico" 
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                            &nbsp;&nbsp;
                
                </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <asp:Button ID="BtnActualizar" runat="server" Enabled="False" Text="Actualizar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnCancelar" runat="server" Enabled="False" Text="Cancelar" />
                
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4" colspan="2">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center><asp:Label ID="Label2" runat="server" Text="Consultar" 
                                        Font-Size="Larger"></asp:Label></center></td>                           
                        </tr>
                            <tr>
                            <td class="textotittabla">
                                Experiencia Academica</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="DrpExpe0" runat="server">
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                 Nivel academico</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="DrpNivel0" runat="server">
                                </asp:DropDownList>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Area Conocimiento</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="DrpAreaC0" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                 Categoria</td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="DrpCatego0" runat="server">
                                    
                                </asp:DropDownList>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Practica</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="DrpPractica0" runat="server">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem>Si</asp:ListItem>
                                    <asp:ListItem Value="No"></asp:ListItem>
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                 Consulta Codigo</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="txtCodAgente" runat="server"></asp:TextBox>
                        </tr>
                            </table>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Buscar" />
                    <asp:Button ID="Button2" runat="server" Text="Ver todos" />
                    <asp:Button ID="btnExpXls" runat="server" Text="Exportar Excel" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3" colspan="2">
                    <asp:Label ID="lblcantidad" runat="server" ForeColor="Black"></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent" colspan="2">
                    <asp:GridView ID="dtgConsulta" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Id_Estudio" HeaderText="Id" />
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="Documento" HeaderText="Documento" />
                            <asp:BoundField DataField="Experiencia_Academica" HeaderText="Experiencia_Academica" />
                            <asp:BoundField DataField="Nivel_Academico" HeaderText="Nivel Academico" />
                            <asp:BoundField DataField="Anio_Aplaza" HeaderText="Año Aplaza" />
                            <asp:BoundField DataField="Semestre_aplaza" HeaderText="Semestre  del año Aplazado" />
                            <asp:BoundField DataField="Area_Conocimiento" HeaderText="Area Conocimiento" />
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                            <asp:BoundField DataField="Semestre_Cer" HeaderText="Semestre certificado" />
                            <asp:BoundField DataField="Institucion" HeaderText="Institucion" />
                            <asp:BoundField DataField="Practica" HeaderText="Practica" />
                                                      </Columns>
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
                <td class="celdascent" colspan="2">
    
                    <asp:GridView ID="dtgXls" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="2000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Id_Estudio" HeaderText="Id" />
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="Documento" HeaderText="Documento" />
                            <asp:BoundField DataField="Experiencia_Academica" HeaderText="Experiencia_Academica" />
                            <asp:BoundField DataField="Nivel_Academico" HeaderText="Nivel Academico" />
                            <asp:BoundField DataField="Anio_Aplaza" HeaderText="Año Aplaza" />
                            <asp:BoundField DataField="Semestre_aplaza" HeaderText="Semestre  del año Aplazado" />
                            <asp:BoundField DataField="Area_Conocimiento" HeaderText="Area Conocimiento" />
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                            <asp:BoundField DataField="Semestre_Cer" HeaderText="Semestre certificado" />
                            <asp:BoundField DataField="Institucion" HeaderText="Institucion" />
                            <asp:BoundField DataField="Practica" HeaderText="Practica" />
                                                      </Columns>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3" colspan="2">
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr> 
        </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    </form>
</body>
</html>