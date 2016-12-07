<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CaidaSistema.aspx.vb" Inherits="digitacion.CaidaSistema" %>

<%@ Register src="../menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Página sin título</title>

  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#txtFechaInicio").datepicker();
          $('#txtFechaInicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <script type="text/jscript">
      $(function () {
          $("#txtFechasolucion").datepicker();
          $('#txtFechasolucion').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFechaConsulta1").datepicker();
          $('#TxtFechaConsulta1').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFechaConsulta2").datepicker();
          $('#TxtFechaConsulta2').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <table style="width:100%; height: 100%">
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
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    Caidas del sistema</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla">
                                Fecha inicio
                                <br />
                                hora Inicio</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="txtFechaInicio" runat="server" Width="24%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFechaInicio" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                <br />
                                <asp:TextBox ID="txtFechaInicio_Tiempo" runat="server" Width="13%" MaxLength="5" placeholder="HH:mm"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtFechaInicio_Tiempo" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="String">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">
                                Fecha solucion
                                <br />
                                hora solucion</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="txtFechasolucion" runat="server" Width="24%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtFechasolucion" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                <br />
                                <asp:TextBox ID="txtFechasolucion_Tiempo" runat="server" Width="13%" MaxLength="5" placeholder="HH:mm"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="txtFechasolucion_Tiempo" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="String">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Causa caida</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlCausa_Caida" runat="server" Height="26px" Width="333px">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Detalle</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtaDetalle" runat="server" Width="94%" MaxLength="50" TextMode="MultiLine"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator6" runat="server" ControlToValidate="txtaDetalle" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="String">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Duracion falla</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtDuracionFalla" runat="server" Width="93%" Enabled="False"></asp:TextBox>                            
                            </td>
                            <td class="textotittabla">
                                Puestos afectados</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtpuestosAfectados" runat="server" Width="98%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator5" runat="server" ControlToValidate="TxtpuestosAfectados" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="String">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Solucuion brindada</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtSolucionbrindada" runat="server" Width="93%" TextMode="MultiLine"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator7" runat="server" ControlToValidate="txtSolucionbrindada" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="String">*</asp:CompareValidator>
                                </td>
                            <td class="textotittabla">
                                &nbsp;</td>
                            <td class="celdascons">
                                &nbsp;</td>
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
                    <table border="0">
                    <tr>
                    <td class="style6">
                    <asp:Button ID="btnguardar" runat="server" Text="Guardar" 
                                    style="height: 26px" />
                            &nbsp;&nbsp;
                                <asp:Button ID="btnconsultar" runat="server" Text="Consultar" 
                                    style="height: 26px" />
                            &nbsp;&nbsp;
                    <asp:TextBox ID="TxtCod_Falla" runat="server" Width="20%"></asp:TextBox>
                            &nbsp;&nbsp;<asp:Button ID="BtnValidacion" runat="server" 
                            BorderStyle="None" Text="■ Consulta Otra falla / Cancelar" Visible="False" 
                            Width="202px" />
&nbsp;</td>
                    <td class="style7">                               
                            &nbsp;&nbsp;
                                <asp:Button ID="btnactualiza" runat="server" Text="Actualizar" 
                                    style="height: 26px" Enabled="False" />
                            &nbsp;&nbsp;
                                <asp:Button ID="btnelimina" runat="server" Text="Eliminar" 
                                    style="height: 26px" Enabled="False" />
                            &nbsp;&nbsp;
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
                <td class="style4">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="4"><center style="font-size: x-large">
                                Consultas</center></td>
                        </tr>
                        <tr>
                            <td class="style9">
                        <asp:RadioButton ID="RdbtnCodigo" GroupName="Seleccion" runat="server" Text="Codigo" ForeColor="Black"/>
                            </td>
                            <td class="celdascons">
                    <asp:TextBox ID="TxtConsultaEspecificas" runat="server" Width="22%"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator11" runat="server" 
                                    ControlToValidate="TxtConsultaEspecificas" ErrorMessage="Revise hora" 
                                    Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                        <asp:RadioButton ID="RdbtnTipoCaida" GroupName="Seleccion" runat="server" Text="Tipo de caida" ForeColor="Black" />
                            </td>
                            <td class="celdascons">                                
                                <asp:DropDownList ID="drlCausa_Caida_Consulta" runat="server" Height="26px" Width="193px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style9">
                        <asp:RadioButton ID="RdbtnFechas" GroupName="Seleccion" runat="server" Text="Fechas" ForeColor="Black" />
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtFechaConsulta1" runat="server" Width="10%" MaxLength="10" 
                                    placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator8" runat="server" ControlToValidate="TxtFechaConsulta1" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                <asp:TextBox ID="TxtFechaConsulta2" runat="server" Width="10%" MaxLength="10" 
                                    placeholder="DD/MM/YYYY"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator10" runat="server" ControlToValidate="TxtFechaConsulta2" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                </td>
                        </tr>
                        <tr>                            
                            <td class="celdascons" colspan="4">
                    <asp:Button ID="BtnConsultaespe" runat="server" Text="Consultar" style="height: 26px" />
                            &nbsp;&nbsp;&nbsp;<asp:Button ID="BtnTodos" runat="server" Text="Ver todos" style="height: 26px" />
                            &nbsp;&nbsp;&nbsp;<asp:Button ID="btnxls" runat="server" Text="Exportar Excel" 
                            Width="102px" />
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
                    <table border="0">
                    <tr>
                    <td class="style8">
                     Numero de rgistros: 
                        <asp:Label ID="lblcantgral" runat="server"></asp:Label>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                <asp:GridView ID="dtgConsultas" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_CS" HeaderText="Código" />
                            <asp:BoundField DataField="Fecha_Inicio" HeaderText="Fecha Inicio" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Detalle" HeaderText="Detalle" />
                            <asp:BoundField DataField="Fecha_Solucion" HeaderText="Fecha Solucion" />
                            <asp:BoundField DataField="Duracion_Falla" HeaderText="Duracion Falla" />
                            <asp:BoundField DataField="Puestos_Afectados" HeaderText="Puestos Afectados" />
                            <asp:BoundField DataField="Solucion_Brindada" HeaderText="Solucion Brindada" />
                            <asp:BoundField DataField="Fecha_Registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="Fk_Usuario" HeaderText="Usuario" />
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
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    </form>
</body>
</html>
