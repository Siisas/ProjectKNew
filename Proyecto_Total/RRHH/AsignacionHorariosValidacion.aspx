<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AsignacionHorariosValidacion.aspx.vb" Inherits="digitacion.AsignacionHorariosValidacion" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Solucion Help Desk</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon"/>
<link rel="shortcut icon" href="../favicon.ico" type="image/x-icon"/>
  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>

    <script type="text/jscript">
        $(function () {
            $("#TxtFechaInicio").datepicker({ dateFormat: 'dd/mm/yy' }).val();
            $("#TxtFechaFin").datepicker({ dateFormat: 'dd/mm/yy' }).val();

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
                <td class="celdasder"></td>
                <td class="celdascent">
                    <table style="width: 100%">
                        <tr>
                            <td align="left" style="width: 100%">
                                <h1 class="text-center" style="font-family: FuenteKamilion"><span class="titulo" style="font-size: 110%">Kamilion Comunicaciones ERP</span></h1>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder"></td>
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
                    <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Consulta/Validacion de horarios</em></h4></asp:Label>
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
                                &nbsp;&nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#009933"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label><asp:Label ID="LblSupervisor" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                </td>
            </tr>            
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                <span class="alert alert-danger" ><asp:Label ID="lblmsg" runat="server" style="color: #843534"></asp:Label></span><br />&nbsp;
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>

                <td class="textotittabla">
                    <table cellpadding="1" cellspacing="1" width="100%">
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Filtros de consulta</strong>
                                </div>
                            </td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>    
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>    
                       <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div class="form-group">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Codigo
                                        </div>
                                         <asp:TextBox ID="TxtCod_Agente" runat="server"  CssClass="form-control"  ></asp:TextBox> 


                                    </div>
                                </div>
                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Jefe Inmediato
                                    </div>
                                    <asp:DropDownList ID="drlPersonalACargo" runat="server" CssClass="form-control">
                              
                                </asp:DropDownList>
                                </div>
                                    </div>
                            </td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>    
                        
                         <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Inicio  <asp:CompareValidator ID="CompareValidator2" runat="server" 
                                    ControlToValidate="TxtFechaInicio" ErrorMessage="Revise hora" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                    </div>
                             <asp:TextBox ID="TxtFechaInicio" runat="server" CssClass="form-control" MaxLength="10"  placeholder="DD/MM/YYYY"></asp:TextBox>
                                </div></div>
                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Fin <asp:CompareValidator ID="CVFecha_Fin" runat="server" 
                                                ControlToValidate="TxtFechaFin" ErrorMessage="Error en la fecha" 
                                                Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="TxtFechaFin" runat="server" CssClass="form-control" MaxLength="10"   placeholder="DD/MM/YYYY"></asp:TextBox>
                                
                                </div></div>
                            </td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>
                         <tr>
                            <td style="width:9%">&nbsp;</td>
                                   <td style="width: 25%">
                                    <div class="form-group"  >
                                        <div class="input-group">
                                            <div " style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Tipo de Consulta</strong>
                                </div>
                                           <asp:RadioButtonList ID="RadBtnTipoConsulta"  runat="server" AutoPostBack="True">
                                            <asp:ListItem >General</asp:ListItem>
                                            <asp:ListItem>Descanso</asp:ListItem>
                                            <asp:ListItem>Validacion</asp:ListItem>
                                            <asp:ListItem>No Programadas</asp:ListItem>
                                            <asp:ListItem>Inf. Novedad</asp:ListItem>
                                            <asp:ListItem>Ingreso</asp:ListItem>
                                        </asp:RadioButtonList>
                                        </div>
                                    </div>
                                </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width: 25%">                                
                            </td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>      
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width: 25%">
                                            <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" CssClass="btn btn-primary" />
                                            <asp:Button ID="BtnExporExc" runat="server" Text="Exportar" CssClass="btn btn-primary" />
                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width: 25%">
                                
                                &nbsp;</td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width:9%">
                            </td>
                            <td style="width: 25%">
                            </td>
                            <td style="width:5%">
                            </td>
                            <td style="width: 25%">
                            </td>
                            <td style="width:9%">
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
                <td class="celdascent">
                    <h4><em style="color:#8F9E45"> Registros encontrados:</em>
                    <asp:Label ID="LblCuenta" runat="server" ForeColor="#8F9E45"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;</h4>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
           <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <div class="bordes">
                    <asp:GridView ID="dtgGeneral" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                          <Columns>
                            <asp:BoundField DataField="cod_agente" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres"  HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="fcingreso" HeaderText="Ingreso Centinela" />
                            <asp:BoundField DataField="Fc_Ingreso" HeaderText="Ingreso Programado" />
                            <asp:BoundField DataField="fcsalida" HeaderText="Salida Centinela" />
                            <asp:BoundField DataField="Fc_Salida" HeaderText="Salida Programada"></asp:BoundField>
                            <asp:BoundField DataField="jefe_inmediato" HeaderText="Jefe Inmediato" />
                            <asp:BoundField DataField="Tipo_Horario" HeaderText="Tipo Horario" />
                            <asp:BoundField DataField="Segmento" HeaderText="Operacion" />
                           <asp:ButtonField CommandName="Seleccion" HeaderText="Alerta" Text="Seleccion" AccessibleHeaderText="Seleccione" />
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
                    <div class="bordes">
                    <asp:GridView ID="dtgGeneralExcel" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                           <Columns>
                            <asp:BoundField DataField="cod_agente" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres"  HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="fcingreso" HeaderText="Ingreso Centinela" />
                            <asp:BoundField DataField="Fc_Ingreso" HeaderText="Ingreso Programado" />
                            <asp:BoundField DataField="fcsalida" HeaderText="Salida Centinela" />
                            <asp:BoundField DataField="Fc_Salida" HeaderText="Salida Programada"></asp:BoundField>
                            <asp:BoundField DataField="jefe_inmediato" HeaderText="Jefe Inmediato" />
                            <asp:BoundField DataField="Tipo_Horario" HeaderText="Tipo Horario" />
                            <asp:BoundField DataField="Segmento" HeaderText="Operacion" />
                           <asp:ButtonField CommandName="Seleccion" HeaderText="Alerta" Text="Seleccion" AccessibleHeaderText="Seleccione" />
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
                    <div class="bordes">
                    <asp:GridView ID="Dtgbusquedaseleccion" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                          <Columns>
                            <asp:BoundField DataField="idreg" HeaderText="ID" />
                            <asp:BoundField DataField="cod" HeaderText="Código" />
                            <asp:BoundField DataField="documento" HeaderText="Identificación" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
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
                            <asp:BoundField DataField="mesreporte" HeaderText="Mes Reporte" />
                            
                            <asp:BoundField DataField="Aprobacion" HeaderText="Estado Revision" />
                            <asp:ButtonField CommandName="Aprobado" HeaderText="" Text="Aprobado" AccessibleHeaderText="Aprobado" />
                            <asp:ButtonField CommandName="Anulado" HeaderText="" Text="Anulado" AccessibleHeaderText="Anulado" /> 
 
                               
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
                    <div class="bordes">
                    <asp:GridView ID="Dtgbusquedaseleccion1" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idreg" HeaderText="ID" />
                            <asp:BoundField DataField="cod" HeaderText="Código" />
                            <asp:BoundField DataField="documento" HeaderText="Identificación" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
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
                            <asp:BoundField DataField="mesreporte" HeaderText="Mes Reporte" />

                             <asp:BoundField DataField="Aprobacion" HeaderText="Estado Revision" />
                                                         
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
                    <div class="bordes">
                    <asp:GridView ID="dtgValidacion" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                         <Columns>
                            <asp:BoundField DataField="Cod_Agente" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="Fc_Ingreso" HeaderText="Ingreso Programado" />
<asp:BoundField DataField="Fc_Salida" HeaderText="Salida Programada"></asp:BoundField>
                            <asp:BoundField DataField="Jefe_Inmediato" HeaderText="Jefe Inmediato" />
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
                    <div class="bordes">
                    <asp:GridView ID="dtgValidacionExcel" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                       <Columns>
                            <asp:BoundField DataField="Cod_Agente" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="Fc_Ingreso" HeaderText="Ingreso Programado" />
<asp:BoundField DataField="Fc_Salida" HeaderText="Salida Programada"></asp:BoundField>
                            <asp:BoundField DataField="Jefe_Inmediato" HeaderText="Jefe Inmediato" />
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
                    <div class="bordes">
                    <asp:GridView ID="dtgnoprogramados" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="codigo" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Jefe" HeaderText="Jefe Inmediato" />
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
                    <div class="bordes">
                    <asp:GridView ID="dtgnoprogramadosExcel" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                            <asp:BoundField DataField="codigo" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Jefe" HeaderText="Jefe Inmediato" />
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
                    <div class="bordes">
                    <asp:GridView ID="dtginformacionovedad" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                   <Columns>
                            <asp:BoundField DataField="codigo" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="area" HeaderText="Área" />
                            <asp:BoundField DataField="jefe_inmediato" HeaderText="Jefe Inmediato" />
                            <asp:BoundField DataField="Laboro" HeaderText="Laboró" />
                            <asp:BoundField DataField="descripcioninasistencia" HeaderText="Novedad"/>
                            <asp:BoundField DataField="Fcnovedad" HeaderText="Fecha Novedad"/>
                            
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
                    <div class="bordes">
                    <asp:GridView ID="dtginformacionovedadexcel" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                  <Columns>
                           <asp:BoundField DataField="codigo" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="area" HeaderText="Área" />
                            <asp:BoundField DataField="jefe_inmediato" HeaderText="Jefe Inmediato" />
                            <asp:BoundField DataField="Laboro" HeaderText="Laboró" />
                            <asp:BoundField DataField="descripcioninasistencia" HeaderText="Novedad"/>
                            <asp:BoundField DataField="Fcnovedad" HeaderText="Fecha Novedad"/>
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
                    <div class="bordes">
                    <asp:GridView ID="dtgdescanso" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                <Columns>
                            <asp:BoundField DataField="Cod_Agente" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="Fc_Ingreso" HeaderText="Ingreso Programado" />
                            <asp:BoundField DataField="Fc_Salida" HeaderText="Salida Programada"></asp:BoundField>
                            <asp:BoundField DataField="jefe_inmediato" HeaderText="Jefe Inmediato" />
                            <asp:BoundField DataField="Nombre" HeaderText="Descanso" />
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
                    <div class="bordes">
                    <asp:GridView ID="dtgdescansoexcel" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="20000" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                <Columns>
                            <asp:BoundField DataField="Cod_Agente" HeaderText="Agente" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="Fc_Ingreso" HeaderText="Ingreso Programado" />
                            <asp:BoundField DataField="Fc_Salida" HeaderText="Salida Programada"></asp:BoundField>
                            <asp:BoundField DataField="jefe_inmediato" HeaderText="Jefe Inmediato" />
                            <asp:BoundField DataField="Nombre" HeaderText="Descanso" />
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