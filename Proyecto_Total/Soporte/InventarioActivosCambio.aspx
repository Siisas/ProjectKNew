<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InventarioActivosCambio.aspx.vb" Inherits="digitacion.InventarioActivosCambio" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>ERP Kamilion - Cambio del Inventario Activo</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
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
         *::selection {
            background: #B3C556;
            color: #fff;
                    }
       ::-moz-selection {background: #B3C556;
        color: #fff;

       }
        
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
                    <uc1:menu ID="menu" runat="server" />
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Inventario</em></h4></asp:Label>
                </td>
                <td class="celdasder">&nbsp;</td>
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
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" ForeColor="#8F9E45"><h4><em>Cambio del Inventario Activo</em></h4></asp:Label>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2">
                    <span class="alert alert-danger">
                        <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label></span>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="celdasder"></td>
                <td class="textotittabla">
                    <table cellpadding="1" cellspacing="1" width="100%">
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Liberar Dispositivo</strong>
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
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Dispositivo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlDispositivoLib" runat="server" AutoPostBack="True" Width="50%" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:Label ID="LblCod_Inventario_Activos" runat="server" Visible="False" Width="50%" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Estado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:DropDownList ID="drlEstadoLib" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem>Activo</asp:ListItem>
                                            <asp:ListItem>Inactivo</asp:ListItem>
                                            <asp:ListItem>Daño</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Sede&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlModuloLib" runat="server" AutoPostBack="true" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>A</asp:ListItem>
                                                    <asp:ListItem>B</asp:ListItem>
                                                    <asp:ListItem>C</asp:ListItem>
                                                    <asp:ListItem>D</asp:ListItem>
                                                    <asp:ListItem>BOD</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Usuario/Agente                                         
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlAgenLib" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Empresa&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                               
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlEmpresaLib" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlSerial1Lib" runat="server" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial Kamilion&nbsp;&nbsp;                              
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlSerialLib" runat="server" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Observación<asp:CompareValidator ID="CompareValidator6" runat="server" ControlToValidate="TxtObservacionLib" 
                                                ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="String">*</asp:CompareValidator>&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:TextBox ID="TxtObservacionLib" runat="server" MaxLength="50"
                                            TextMode="MultiLine" CssClass="form-control"></asp:TextBox>                                
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <asp:Button ID="BtnLiberar" runat="server" Text="Liberar" CssClass="btn btn-primary" />
                            </td>
                            <td style="width: 9%">&nbsp;</td>

                        </tr>
                        <tr>
                            <td colspan="5">
                                            &nbsp;</td>
                            
                        </tr>  
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Ingresar Dispositivo</strong>
                                </div>
                            </td>
                            <td class="auto-style1"></td>
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
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Dispositivo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlDispositivoIng" runat="server" AutoPostBack="True" Width="50%" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:Label ID="LblCod_Inventario_Activos1" runat="server" Visible="False" Width="50%" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Marca&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlMarca" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Modelo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlModelo" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Empresa&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlEmpresa" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlSerial1" runat="server" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial Kamilion&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlSerial" runat="server" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Sede&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlModuloIng" runat="server" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>A</asp:ListItem>
                                                    <asp:ListItem>B</asp:ListItem>
                                                    <asp:ListItem>C</asp:ListItem>
                                                    <asp:ListItem>D</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Usuario/Agente
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlAgenIng" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
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
                                            Observación<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtObservacionIng" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="String">*</asp:CompareValidator>&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:TextBox ID="TxtObservacionIng" runat="server" MaxLength="50"
                                            TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%"></td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <asp:Button ID="BtnAsignar" runat="server" Text="Asignar" CssClass="btn btn-primary" />
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="5">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Cambiar Estado Dispositivo</strong>
                                </div>
                            </td>
                            <td class="auto-style1"></td>
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
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Dispositivo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlDispositivoEstado" runat="server" AutoPostBack="True" Width="50%" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                        <asp:Label ID="LblCod_Inventario_Activos0" runat="server" Visible="False" Width="50%" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Marca&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlMarcaEstado" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Modelo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlModeloEstado" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Empresa&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlEmpresaEstado" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlSerial1Estado" runat="server" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial Kamilion&nbsp;
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlSerialEstado" runat="server" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Estado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:DropDownList ID="drlCambioEstado" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem>Activo</asp:ListItem>
                                            <asp:ListItem>Inactivo</asp:ListItem>
                                            <asp:ListItem>Daño</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Observación&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:TextBox ID="TxtObservacionEstado" runat="server" MaxLength="50"
                                            TextMode="MultiLine" CssClass="form-control"></asp:TextBox>                                       
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>               
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <asp:Button ID="BtnEstado" runat="server" Text="Cambiar Estado" CssClass="btn btn-primary" />
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="5">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1"></td>
                            <td class="auto-style2">
                                <span class="alert alert-danger">
                                    <asp:Label ID="LblmsgConsultas" runat="server" Style="color: #843534"></asp:Label></span>
                            </td>
                            <td class="auto-style2"></td>
                            <td class="auto-style2"></td>
                            <td class="auto-style1"></td>
                        </tr>
                                                <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Consultas</strong>
                                </div>
                            </td>
                            <td class="auto-style1"></td>
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
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnEstado" GroupName="Seleccion" runat="server" Text="Estado del dispositivo"/>
                                        </div>
                                        <asp:DropDownList ID="drlCambioEstadoConsulta" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%"></td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnSerial" GroupName="Seleccion" runat="server" Text="Serial"/>
                                        </div>
                                        <asp:TextBox ID="TxtSerialConsulta" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%"></td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnCodigo" GroupName="Seleccion" runat="server" Text="Codigo" />
                                        </div>
                                        <asp:TextBox ID="TxtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%"></td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <asp:Button ID="BtnConsultaespe" runat="server" Text="Consultar"
                                    Style="height: 26px" Visible="False" />
                                <asp:ImageButton ID="BtnConsultaInventario" runat="server"
                                    ImageUrl="~/Css2/Imagenes/Consulta.png" Height="70px" Width="72px" />
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="5">&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder"></td>
            </tr>  
<%--AAAAAAAAAAAAAAAAAAAAAAAAAA  --%>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <h4><em style="color:#8F9E45">CONSULTAS INVENTARIO</em></h4>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <h4><em style="color:#8F9E45">Número de registros:</em>
                    <asp:Label ID="lblcantidad" runat="server" ForeColor="#8F9E45"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
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
                        <asp:GridView ID="dtggeneral1" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="90" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="Cod_Inventario" HeaderText="Código" />
                                <asp:BoundField DataField="Dispositivo" HeaderText="Dispositivo" />
                                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                                <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                                <asp:BoundField DataField="Serial" HeaderText="Serial" />
                                <asp:BoundField DataField="Serial_Kamilion" HeaderText="Serial Kamilion" />
                                <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                                <asp:BoundField DataField="Sede" HeaderText="Sede" />
                                <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario Registra" />
                                <asp:BoundField DataField="FcReg_Invent" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="Cod_Agente" HeaderText="Usuario" />
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
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <h4><em style="color: #8F9E45">CONSULTAS DETALLE</em></h4>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <h4><em style="color: #8F9E45">Número de registros:</em>
                        <asp:Label ID="LblCantidad2" runat="server" ForeColor="#8F9E45"></asp:Label></h4>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <div class="bordes">
                        <asp:GridView ID="dtggeneral2" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="90" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="Cod_Inventario_detalle" HeaderText="Código Detalle" />
                                <asp:BoundField DataField="Fk_Cod_Inventario" HeaderText="Codigo Inevntario" />
                                <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                <asp:BoundField DataField="Fk_ID_Modulo" HeaderText="Modulo" />
                                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                <asp:BoundField DataField="Cod_Agente" HeaderText="Usuario" />
                                <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario Registra" />
                                <asp:BoundField DataField="FecReg_InventD" HeaderText="Fecha Registro" />
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
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">&nbsp;</td>
                <td class="celdasder">&nbsp;</td>
            </tr>
        </table>    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    </form>
</body>
</html>
