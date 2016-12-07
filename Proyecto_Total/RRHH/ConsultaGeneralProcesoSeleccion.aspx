<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultaGeneralProcesoSeleccion.aspx.vb" Inherits="digitacion.ConsultaGeneralProcesoSeleccion" %>

<%@ Register src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
  <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="Stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/jscript" >
        $(function () {
            $("#TxtFecha_Inicio").datepicker();
            $("#TxtFecha_Inicio").datepicker('option', { dateFormat: 'dd/mm/yy' });
        });
    </script>
    <script type="text/jscript" >
        $(function () {
            $("#TxtFecha_Fin").datepicker();
            $("#TxtFecha_Fin").datepicker('option', { dateFormat: 'dd/mm/yy' });
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
            color: #000042;
            font-weight: bold;
            width: 15%;
            height: 41px;
            background: #E2E8FA;
        }
        .style11
        {
            width: 35%;
            height: 41px;
        }
        .style12
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 23px;
        }
        .style13
        {
            color: #000099;
            width: 80%;
            height: 23px;
        }
                       .style14
                       {
                           font-family: Arial, Helvetica, sans-serif;
                           font-size: small;
                           color: #000042;
                           font-weight: bold;
                           width: 35%;
                           background: #E2E8FA;
                       }
                       .style15
                       {
                           width: 35%;
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
                <td class="style12">
                    </td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style13">
                    Consulta General Proceso De Seleccion</td>
                <td class="style12">
                    </td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                    <tr>
                            <td class="textotittabla" colspan="4">
                                <center>Proceso de Seleccion</center>
                                </td>                            
                        <tr>
                            <td class="textotittabla">
                                Codigo Proceso de seleccion
                                </td>
                            <td class="celdascons">                                
                                <asp:TextBox ID="TxtCod_Proceso_Seleccion" runat="server" Width="90%" MaxLength="1000"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Estado
                                </td>
                            <td class="celdascons">
                            <asp:DropDownList ID="drlEstadoProcesoSeleccion" runat="server" Width="90%">
                                        <asp:ListItem Value="0">- Elija una Opción -</asp:ListItem>
                                        <asp:ListItem Value="En proceso">En proceso</asp:ListItem>
                                        <asp:ListItem Value="Finalizado">Finalizado</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Fecha Inicio</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtFecha_Inicio" runat="server" Width="23%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Fecha Fin</td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtFecha_Fin" runat="server" Width="23%" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
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
                    <asp:Button ID="BtnConsultarProcesoSeleccion" runat="server" Text="Consultar Proceso" Height="26px" />                    
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="celdascons" >
                            Procesos de seleccion: 
                        <asp:Label ID="LblCantidadProcesosSeleccion" runat="server"></asp:Label>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    <asp:GridView ID="dtgGeneral" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_Proceso_Seleccion" HeaderText="Codigo" />
                            <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Cantidad_Requerida" 
                                HeaderText="Cantidad Requerida" />
                            <asp:BoundField DataField="Cantidad_Obtenida" HeaderText="Cantidad Obtenida" />
                            <asp:BoundField DataField="Fecha_Inicio" HeaderText="Fecha Inicio" />
                            <asp:BoundField DataField="Fecha_Fin" HeaderText="Fecha Fin" />
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3"></td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="1" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center> Aspirante</center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                Identificacion</td>
                            <td class="style15">
                                <asp:TextBox ID="TxtId_Aspirante" runat="server" Width="90%">
                                </asp:TextBox>
                            </td>
                            <td class="textotittabla">
                               Estado</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drlEstado" runat="server" Width="90%">
                                        <asp:ListItem Value="Opcion">- Elija una Opción -</asp:ListItem>
                                        <asp:ListItem Value="1">Activo</asp:ListItem>
                                        <asp:ListItem Value="0">Inactivo</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                En Algun Proceso</td>
                            <td class="style15">
                                <asp:DropDownList ID="drlAlgunProceso" runat="server" Width="90%">
                                        <asp:ListItem Value="Opcion">- Elija una Opción -</asp:ListItem>
                                        <asp:ListItem Value="1">Si</asp:ListItem>
                                        <asp:ListItem Value="0">No</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">
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
                    &nbsp;</td>                    
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    <asp:Button ID="BtnConsultaAspirante" runat="server" 
                        Text="Consultar Aspirante" Height="26px" />
                    <asp:Button ID="btnxls" runat="server" Text="Exportar Excel" Visible="False" />
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="celdascons" >
                            Numero de aspirantes: 
                        <asp:Label ID="LblCantidadAspirantes" runat="server"></asp:Label>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    <asp:GridView ID="dtgAspirantes" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>                        
                            <asp:BoundField DataField="Id_Aspirante" HeaderText="Identificacion" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                            <asp:BoundField DataField="Celular" HeaderText="Celular" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo" />
                            <asp:BoundField DataField="Cod_Proceso_Seleccion" HeaderText="Codigo Proceso" />
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
                </td>
                <td class="style4">
                    <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="celdascons" >
                            Registros de Estudios: 
                        <asp:Label ID="LblCantidadEstudios" runat="server"></asp:Label>
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
                    <asp:GridView ID="dtgEstudios" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>                        
                            <asp:BoundField DataField="Cod_Nivel_Academico" HeaderText="Codigo" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nivel" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                            <asp:BoundField DataField="Fk_Id_Aspirante" HeaderText="Aspirante" />
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
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="celdascons" >
                            Registros de Experiencia Laboral: 
                        <asp:Label ID="LblCantidadExpeLaboral" runat="server"></asp:Label>
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
                    <asp:GridView ID="dtgExperienciaLab" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>                        
                            <asp:BoundField DataField="Cod_ExperienciaLab" HeaderText="Codigo" />
                            <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="Tiempo" HeaderText="Tiempo" />
                            <asp:BoundField DataField="Fk_Id_Aspirante" HeaderText="Aspirante" />
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
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                </td>
                <td class="style4">
                    <table border="0" cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td class="celdascons" >
                            Procesos realizados al aspirante: 
                        <asp:Label ID="LblCantidadProcesosAspirante" runat="server"></asp:Label>
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
                    <asp:GridView ID="dtgProcesosAspirante" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20" Width="100%" style="font-size: x-small" 
                                    EnableModelValidation="True">
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <Columns>                        
                            <asp:BoundField DataField="Cod_Detalle_PS_A" HeaderText="Codigo" />
                            <asp:BoundField DataField="Filtro_Seleccion" HeaderText="Filtro" />
                            <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                            <asp:BoundField DataField="Id_Aspirante" HeaderText="Aspirante" />
                            <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                            <asp:BoundField DataField="Estado_Seleccion" HeaderText="Estado" />
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
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>                    
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" 
                    valign="top" class="style3">
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>            
        </table>
    </form>
</body>
</html>
