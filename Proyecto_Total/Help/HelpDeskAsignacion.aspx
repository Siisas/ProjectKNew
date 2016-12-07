<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HelpDeskAsignacion.aspx.vb" Inherits="digitacion.HelpDeskAsignacion" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Asignacion Help Desk</title>

    <link rel="icon" href="../favicon.ico" type="image/x-icon"/>
<link rel="shortcut icon" href="../favicon.ico" type="image/x-icon"/>

  <!-- Inicio Script jQuery Datepicker ---> 
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Inicio").datepicker();
          $('#TxtFecha_Inicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
          $("#TxtFecha_Fin").datepicker();
          $('#TxtFecha_Fin').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
  <!-- Fin Script jQuery Datepicker --->
    <%--Colocar como comentario para ver correctamente la vista diseño--%>       
        <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />  
        <link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />  
    <%------------------------------------------------------------------%>  
 <style type="text/css">
     
        @font-face {
    font-family: FuenteKamilion;
    src:url(../Css2/Boot/fonts/NEUROPOL.ttf);
    }
        body {
    
     background-color: #eee;
     }

        .titulo
    { 
        transition: 2s ease;
    color: #B3C556;
    text-shadow: -2px -2px 1px #000;
   }

.titulo:hover
{ 
    color: #B3C556;
    text-shadow: -2px -2px 1px #fff;
   }

 .bordes {
  /*border: 1px solid black;*/
  -webkit-border-radius: 5px;
  -moz-border-radius: 5px;
  border-radius: 5px;
  overflow: hidden;
}


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

   
    
        .style2
        {
            width: 100%;
        }
 
        
      .style1
        {
            width: 100%; height:100%;
        }
 

   
       
/* .textotittabla
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #E2E8FA;
	width: 9%;
}*/
 
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
            <tr>
                <td class="celdasder">
                </td>
                <td class="celdascent">
                    <table style="width: 100%">
                        <tr>
                            <td align="left" style="width: 100%">
                                <h1 class="text-center" style="font-family:FuenteKamilion"><span class="titulo" style="font-size:110%">Kamilion Comunicaciones ERP</span></h1>
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
                    <uc1:menu ID="menu" runat="server" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Asignacion casos Help Desk</em></h4></asp:Label>
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
                <td valign="top" class="style3">
                    <table cellpadding="1" cellspacing="1" class="style1">
                        <tr>
                            <td colspan="4">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <table cellpadding="1" cellspacing="1" width="100%">
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td colspan="3">
                                            <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                                <strong>Consulta Casos</strong>
                                            </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Codigo Ticket   
                                                    </div>
                                                    <asp:TextBox ID="TxtCod_Ticket_Consulta" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                          <div>
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Codigo Usuario 
                                                    </div>
                                                    <asp:TextBox ID="txt_cod_usu" runat="server" CssClass="form-control" MaxLength="5"></asp:TextBox>
                                                </div>
                                            </div>

                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Estado   
                                                    </div>
                                                    <asp:DropDownList ID="drlEstados" runat="server" CssClass="form-control">
                                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                        <asp:ListItem>Abierto</asp:ListItem>
                                                        <asp:ListItem>Gestionado</asp:ListItem>
                                                        <asp:ListItem>Solucionado</asp:ListItem>
                                                        <asp:ListItem>Escalado</asp:ListItem>
                                                        <asp:ListItem>Rechazado</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Prioridad
                                                    </div>
                                                    <asp:DropDownList ID="drlPrioridad" runat="server" CssClass="form-control">
                                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                        <asp:ListItem>Bajo</asp:ListItem>
                                                        <asp:ListItem>Medio</asp:ListItem>
                                                        <asp:ListItem>Alto</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Fecha Inicio <asp:CompareValidator ID="CVFechaInicio" runat="server"
                                                        ControlToValidate="TxtFecha_Inicio" ErrorMessage="Error en la fecha"
                                                        Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>     
                                                    </div>
                                                    <asp:TextBox ID="TxtFecha_Inicio" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" CssClass="form-control"></asp:TextBox>
                                                    
                                                </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Fecha Fin
                                                        <asp:CompareValidator ID="CVFechaFin" runat="server"
                                                            ControlToValidate="TxtFecha_Fin" ErrorMessage="Error en la fecha"
                                                            Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                                    </div>
                                                    <asp:TextBox ID="TxtFecha_Fin" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" CssClass="form-control"></asp:TextBox>
                                
                                                </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                             <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>

                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                    <asp:Button ID="BtnConsulta" runat="server" Text="Consulta" CssClass="btn btn-primary"/>
                    <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-primary"/>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td colspan="3">
                                            <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                                <strong>Asignacion Casos</strong>
                                            </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Asignar a    
                                                    </div>
                                                    <asp:DropDownList ID="drlTecnico" runat="server" CssClass="form-control">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Comentario    
                                                    </div>
                                                    <asp:TextBox ID="TxtObservacionAsigna" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        <asp:CheckBox ID="CheckBoxTipificacion" runat="server" />Cambio Tipificacion Categoria    
                                                    </div>
                                                    <asp:DropDownList ID="drlCategoria" runat="server" AutoPostBack="True" CssClass="form-control">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Tipo    
                                                    </div>
                                                    <asp:DropDownList ID="drlTipo" runat="server" CssClass="form-control">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        <asp:CheckBox ID="CheckBoxPrioridad" runat="server"/> Cambia Prioridad
                                                    </div>
                                                    <asp:DropDownList ID="drlPrioridadUpdate" runat="server" CssClass="form-control">
                                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                        <asp:ListItem>Bajo</asp:ListItem>
                                                        <asp:ListItem>Medio</asp:ListItem>
                                                        <asp:ListItem>Alto</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        <asp:CheckBox ID="CheckBoxArea" runat="server" />
                                                        Area 
                                                    </div>
                                                    <asp:DropDownList ID="drlAreaUpdate" runat="server" CssClass="form-control">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                            &nbsp;</td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                            &nbsp;</td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Codigo HelpDesk    
                                                    </div>
                                                    <asp:Label style="background-color: inherit" ID="LblCod_HeplDeks" runat="server" CssClass="form-control"></asp:Label>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Fecha Registro    
                                                    </div>
                                                    <asp:Label style="background-color: inherit" ID="LblFecha_Registro" runat="server" CssClass="form-control"></asp:Label>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Usuario Reporta    
                                                    </div>
                                                    <asp:Label style="background-color: inherit" ID="LblUsuarioReporta" runat="server" CssClass="form-control"></asp:Label>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Prioridad    
                                                    </div>
                                                    <asp:Label style="background-color: inherit" ID="LblPrioridad" runat="server" CssClass="form-control"></asp:Label>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Tema    
                                                    </div>
                                                    <asp:Label  style="background-color: inherit" ID="LblTema" runat="server" CssClass="form-control"></asp:Label>
                                                    <asp:TextBox ID="LblTema1" runat="server" CssClass="form-control" 
                                                        Enabled="false" TextMode="MultiLine" Visible="False"></asp:TextBox>
                                                </div>
                                                
                                            </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Observacion    
                                                    </div>
                                                    <asp:Label  style="background-color: inherit" ID="LblObservacion" runat="server" CssClass="form-control"></asp:Label>
                                                    <asp:TextBox ID="LblObservacion1" runat="server" CssClass="form-control" 
                                                        TextMode="MultiLine" Enabled="false" Visible="False"></asp:TextBox>   
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Realiza Registro    
                                                    </div>
                                                    <asp:Label style="background-color: inherit" ID="LblUsuarioReg" runat="server" CssClass="form-control"></asp:Label>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        Estado    
                                                    </div>
                                                    <asp:Label style="background-color: inherit" ID="LblEstado" runat="server" CssClass="form-control"></asp:Label>
                                                </div>
                                            </div>
                                        </td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">
                                            <asp:Button ID="BtnAsignarCaso" runat="server" Text="Asignar" Enabled="False" 
                                                CssClass="btn btn-primary"/>
                                        </td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 9%">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="width: 9%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 5%">&nbsp;</td>
                                        <td style="width: 25%">&nbsp;</td>
                                        <td style="width: 9%">&nbsp;</td>
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
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                                            &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" 
                    valign="top" class="style3">
                    </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <h4 style="color:#8F9E45"><em >Consulta Help Desk</em>
                    <asp:Label ID="lblcuentaHelpDesk" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                        ID="Btnxls" runat="server" Text="Exportar" Visible="False" CssClass="btn btn-primary" /></h4>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <div class="bordes">
                    <asp:GridView ID="dtggeneralHelpDesk" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_HelpDesk_Registro" HeaderText="Codigo" />
                            <asp:BoundField DataField="Fecha_Registro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario" />
                            <asp:BoundField DataField="codnom" HeaderText="Cod" />
                            <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" />
                            <asp:BoundField DataField="Tema" 
                                HeaderText="Tema" />
                            <asp:BoundField DataField="Observacion" HeaderText="Observación" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Canal" HeaderText="Canal" />
                            <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                            <asp:BoundField DataField="Persona_Reporta" HeaderText="Reporta" />
                            <asp:BoundField DataField="Modulo" HeaderText="Modulo" />
                            <asp:BoundField DataField="Area" HeaderText="Area" />
                            <asp:BoundField DataField="Asignado" HeaderText="Asignado" />
                            <asp:BoundField DataField="Asigna" HeaderText="Asigna" />
                            <asp:BoundField DataField="Fecha_Asigna" HeaderText="Fecha Asigna" />
                            <asp:ButtonField CommandName="Seleccion" HeaderText="Seleccion un Caso" 
                                Text="Seleccion" />
                        </Columns>
                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                        </div>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
    
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
