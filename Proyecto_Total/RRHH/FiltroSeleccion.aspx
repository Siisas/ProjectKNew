<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FiltroSeleccion.aspx.vb" Inherits="digitacion.FiltroSeleccion" %>

<%@ Register Src="../menu.ascx" tagname="menu" tagprefix="uc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Inicio").datepicker();
          $('#TxtFecha_Inicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
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
        .style8
        {
            width: 864px;
        }
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            color: navy;
            width: 597px;
        }
        .style10
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 23px;
        }
        .style11
        {
            color: #000099;
            width: 80%;
            height: 23px;
        }
        .style12
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 21px;
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
                            <td align="left" class="style9">
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
                <td class="style10">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style11">
                    Filtro de Seleccion</td>
                <td class="style10">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <asp:RadioButton ID="RbtnNuevo" GroupName="Registro" runat="server" Text="Nuevo Registro" />
                        <asp:RadioButton ID="RbtAgregar" GroupName="Registro" runat="server" Text="Agregar mas aspirantes" />
                        <asp:Button ID="BtnActualizarRegistro" runat="server" Text="Actualizar" />
                        <asp:Button ID="BtnRegresar" runat="server" Text="<-- Regresar" 
                        Visible="False" />
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="0">
                    <tr>
                    <td class="style8">                    
                        <asp:Panel ID="Panel_RegistroNuevo" runat="server" Visible="False">
                        <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                            <td class="textotittabla" colspan="4">
                                <center>Proceso de Seleccion</center>
                                </td>
                        <tr>
                            <td class="textotittabla">
                                Cargo
                                </td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtCargo" runat="server" Width="90%" MaxLength="50"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Observacion
                                </td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtObservacion" runat="server" Width="90%" MaxLength="500" 
                                    TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estado</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlEstado" runat="server" Width="60%">
                                        <asp:ListItem Value="0">- Elija una Opción -</asp:ListItem>
                                        <asp:ListItem Value="En proceso">En proceso</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Cantidad Requerida</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtCantidadRequerida" runat="server" Width="20%" 
                                    MaxLength="10"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Fecha Inicio</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtFecha_Inicio" runat="server" Width="29%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>                            
                            </td>
                            <td class="textotittabla">
                                Máximo de candidatos </td>
                            <td class="celdascons">
                                    <asp:TextBox ID="TxtMaxCandidatos" runat="server" Width="20%" 
                                    MaxLength="10"></asp:TextBox></td>
                        </tr>
                      </tr>
                    </table>
                    <asp:Button ID="BtnValidarProcesoSeleccion" runat="server" Text="Validar" />
                        <asp:Button ID="BtnValidacion" runat="server" 
                            BorderStyle="None" Text="■ Modificar proceso de seleccion" Visible="False" 
                            Width="221px" />
                        </asp:Panel>
                        <asp:Panel ID="Panel_AgregarAspirantes" runat="server" Visible="False">
                        <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                        <td width="50%" >
                        <table border="1">
                        <tr>
                            <td class="textotittabla" >
                                Proceso</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlProcesoSeleccion" runat="server" Width="90%">
                                </asp:DropDownList>  
                                    </td>                              
                            <td class="textotittabla">
                                <asp:Button ID="BtnConsultaProcesoSeleccion" runat="server" Text="Consultar" 
                                    style="height: 26px" />
                                    <asp:Button ID="BtnValidacionConsulta" runat="server" 
                            BorderStyle="None" Text="■ Consultar Otro Proceso de Seleccion" Visible="False" 
                            Width="246px" />
                                    </td>
                          </tr>                          
                          </table>
                          </td>
                          <td width="50%" ></td>
                        </tr> 
                        </table>
                        <br />
                        <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                            <td class="style12" colspan="4">
                                <center>Proceso de Seleccion</center>
                                </td>
                        <tr>
                            <td class="textotittabla">
                                Cargo
                                </td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtCargoConsulta" runat="server" Width="90%" MaxLength="50" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Observacion
                                </td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtObservacionConsulta" runat="server" Width="90%" MaxLength="500" 
                                    TextMode="MultiLine" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Estado</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlEstadoConsulta" runat="server" Width="60%" 
                                    Enabled="False">
                                        <asp:ListItem Value="0">- Elija una Opción -</asp:ListItem>
                                        <asp:ListItem Value="En proceso">En proceso</asp:ListItem>
                                        <asp:ListItem Value="Cancelado">Cancelado</asp:ListItem>
                                        <asp:ListItem Value="Finalizado">Finalizado</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
                                Cantidad Requerida</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtCantidadRequeridaConsulta" runat="server" Width="20%" 
                                    MaxLength="10" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Fecha Inicio</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtFecha_Inicio_Consulta" runat="server" Width="60%" 
                                    MaxLength="10" Enabled="False"></asp:TextBox>                            
                            </td>
                            <td class="textotittabla">
                                Cantidad Obtenida</td>
                            <td class="celdascons">
                                    <asp:TextBox ID="TxtCantidadObtenidaConsulta" runat="server" Width="20%" MaxLength="10" 
                                    Enabled="False"></asp:TextBox>
                           </td>
                        </tr> 
                        <tr>
                            <td class="textotittabla">
                                Fecha Fin</td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtFecha_Fin_Consulta" runat="server" Width="60%" MaxLength="50" 
                                    Enabled="False"></asp:TextBox>                            
                            </td>
                            <td class="textotittabla">
                                </td>
                            <td class="celdascons">                                
                            </td>
                        </tr>
                      </tr>
                    </table>
                        </asp:Panel>
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
                    
                </td>
                <td class="celdasder">
                </td>
            </tr>            
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center> Filtros de Seleccion</center>
                                </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Nivel Academico</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlNivel" runat="server" Width="90%" Enabled="False">
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                Cargo</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtCargoLabor" runat="server" Width="90%" MaxLength="11" 
                                    Enabled="False"></asp:TextBox>
                            </td>
                        </tr> 
                        <tr>
                            <td class="textotittabla">
                                Tiempo experiencia</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtTiempo" runat="server" Width="20%" 
                                    MaxLength="11" Enabled="False"></asp:TextBox>
                                    <asp:DropDownList ID="drlTiempo" runat="server" Width="40%" Enabled="False">
                                        <asp:ListItem Value="0">- Elija una Opción -</asp:ListItem>
                                        <asp:ListItem Value="Mes">Mes(es)</asp:ListItem>
                                        <asp:ListItem Value="Año">Año(s)</asp:ListItem>
                                </asp:DropDownList>
                                </td>
                            <td class="textotittabla">
                                   <asp:Button ID="BtnValidarFiltro" runat="server" Text="Validar Filtro" 
                                       style="height: 26px" Enabled="False" />
                            </td>
                            <td class="celdascons">
                                 
                            </td>
                        </tr>
                        </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="celdascons" >
                                <asp:Button ID="BtnGuardarProcesoSeleccion" runat="server" Text="Guardar" Height="26px" 
                                    Visible="False" />                                
                                <br />
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
                     Numero de Aspirantes: 
                        <asp:Label ID="LblNumAspirantes" runat="server"></asp:Label>
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
                <td style="font-weight: 800; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" >
                                <center>Aspirantes</center>
                                </td>
                        </tr>
                        <tr>
                        <td class="celdascons" >
                                <asp:GridView ID="dtgAspirantes" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Id_Aspirante" HeaderText="Identificacion" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                            <asp:BoundField DataField="CargoEjercio" HeaderText="Cargo Laboro" />
                            <asp:BoundField DataField="Tiempo" HeaderText="Tiempo Laboro" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>
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
                <td>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
