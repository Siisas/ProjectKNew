<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BandejaAuditoria.aspx.vb" Inherits="digitacion.BandejaAuditoria" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
      <title>ERP Kamilion - Auditorias</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon"/>
<link rel="shortcut icon" href="../favicon.ico" type="image/x-icon"/>
  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <link href="../Css2/Boot/css/ScrollBar.css" rel="stylesheet" />
  <script type="text/jscript">

      $(function () {
          $("#TxtFecha_Inicio").datepicker();
          $('#TxtFecha_Inicio').datepicker('option', { dateFormat: 'dd/mm/yy' });
          $("#TxtFecha_Fin").datepicker()
          $('#TxtFecha_Fin').datepicker('option', { dateFormat: 'dd/mm/yy' });
      });
  </script>
    <link href="../Css2/Boot/css/ScrollBar.css" rel="stylesheet" />
  <!-- Fin Script jQuery Datepicker --->
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
         <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />         
<link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
    <%------------------------------------------------------------------%>   
    <style type="text/css">
        
        ::-webkit-scrollbar {
            width: 14px;    
        }
        ::-webkit-scrollbar-button {
            background-color:#B3C556;
            border-radius: 5px;
	        background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%,
											          transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%,
											          transparent 75%,/*SD*/transparent)
        } 
        ::-webkit-scrollbar-button:hover {
            background-color: #EEEEEE;
        }
        ::-webkit-scrollbar-button:active {
          background: #aeaeb5;
        }
        ::-webkit-scrollbar-thumb {
            background-color: #B3C556;	
            border-radius: 12px;
	        background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%,
											          transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%,
											          transparent 75%,/*SD*/transparent)
        }
        ::-webkit-scrollbar-thumb:hover {
            background-color: #EEEEEE;
        }
        ::-webkit-scrollbar-thumb:active {
          background: #aeaeb5;
        }
        
        *::selection {
            background: #B3C556;
            color: #fff;
                    }
       ::-moz-selection {background: #B3C556;
        color: #fff;

       }
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
       
        
        .auto-style3 {
            width: 9%;
            height: 24px;
        }
               
        
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <table style="width: 100%; height: 100%">
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
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                    <uc1:menu ID="menu" runat="server" />
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label2" runat="server" ForeColor="#8F9E45"><h4><em>Control y administracion Auditorias</em></h4></asp:Label>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder"></td>
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
                <td class="celdasder"></td>
            </tr>

            <tr>
                <td class="celdasder"></td>
                <td class="auto-style2">
                    <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                        <ContentTemplate>
                            <span class="alert alert-danger">
<asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
 </span>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td class="celdasder"></td>
               
            </tr>
            
            <tr>
                <td class="celdasder"></td>

                <td class="textotittabla">
                    <table cellpadding="1" cellspacing="1" width="100%">

                        <tr>

                            <td class="celdasder">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Asignacion de Ingenieros al Auditor</strong>
                                </div>
                            </td>
                            <td class="celdasder">&nbsp;</td>
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
                                            Supervisor
                                        </div>
                                        <asp:DropDownList ID="DrlSupervisor" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Cantidad de Ingenieros
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="LblCantidad" Text="0" ToolTip="Cantida de ingenieros para asignar a un auditor" runat="server" CssClass="form-control" Enable="False"></asp:Label>
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
                                            Turno
                                        </div>
                                        <asp:DropDownList ID="Drlturno" runat="server" CssClass="form-control">
                                        </asp:DropDownList>

                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Auditor
                                        </div>
                                        <asp:DropDownList ID="DrlAuditor" runat="server" CssClass="form-control">
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
                                            Cantidad
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtCantidad"
                                    ErrorMessage="el numero debe ser positivo" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
                                        </div>
                                        <asp:TextBox ID="TxtCantidad" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                    </div>
                                </div>

                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                                          <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                    <ContentTemplate>
                                <asp:CheckBox ID="CheckSeleccionarA" Style="background-color: inherit;" runat="server" AutoPostBack="True"  CssClass="form-control" Text="Seleccionar todos" />
                            </ContentTemplate></asp:UpdatePanel>
                                        </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <asp:Button ID="BtnConsulta" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                                <asp:Button ID="Registrar" runat="server" Text="Registrar" CssClass="btn btn-primary" />

                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">  
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

                        <asp:Panel ID="Pnl1" runat="server" Visible="false">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div id="divUsers" style="background-color: White;  height: 300px; width: 100%; overflow-y: scroll; font-size: 11px; " align="left">
                                                                  <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                    <ContentTemplate>
                                        <asp:GridView ID="DtgUsuarios" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="1000" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True" AutoGenerateColumns="False" Visible="False">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                            <Columns>
                                                <asp:BoundField DataField="idusuario" HeaderText="Ingeniero" />
                                                <asp:BoundField DataField="nombreu" HeaderText="Nombre" />
                                                <asp:BoundField DataField="codnom" HeaderText="Codigo" />
                                                <asp:BoundField DataField="supervisor" HeaderText="Supervisor" />
                                                <asp:BoundField DataField="turno" HeaderText="Turno" />
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkCtrl" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                        </ContentTemplate> </asp:UpdatePanel> 
                                    </div>

                                </td>

                                <td style="width: 9%">&nbsp;</td>

                            </tr>
                        </asp:Panel>



                        <tr>

                            <td class="celdasder2"></td>
                            <td colspan="3" class="auto-style3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Liberacion Ingenieros Asignados Auditor</strong>
                                </div>
                            </td>

                            <td class="celdasder"></td>
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
                                            Auditor
                                        </div>
                                        <asp:DropDownList ID="DrlAuditor1" runat="server" CssClass="form-control" AutoPostBack="True">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Busqueda Masiva
                                        </div>
                                        <asp:Button ID="BtnConsultaMasiva" runat="server" Text="Buscar" CssClass="btn btn-primary" />
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
                                            Cantidad de Ingenieros
                                        </div>
                                        <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="LblCantidad2" Text="0" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                <asp:CheckBox ID="CheckSeleccionar" Style="background-color: inherit;" runat="server" AutoPostBack="True"  CssClass="form-control" Text="Seleccionar todos" />
                                        </ContentTemplate>
                           </asp:UpdatePanel>
                                     </td>
                            <td style="width: 9%">&nbsp;</td>

                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>

                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Liberar Auditores
                                        </div>
                                        <asp:Button ID="BtnLiberarA" runat="server" Text="Liberar" CssClass="btn btn-primary" />
                                    </div>
                                </div>

                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%"></td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 9%">&nbsp;</td>

                        </tr>
                          <asp:Panel ID="Pnl2" runat="server" Visible="false">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    
                                    <div id="div1" style="background-color: White;  height: 300px; width: 100%; overflow-y: scroll; font-size: 11px;" align="left">
                                          <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                        <asp:GridView ID="DtgUsuariosAuditor" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="1000" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True" AutoGenerateColumns="False" Visible="False">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                            <Columns>
                                                <asp:BoundField DataField="idusuario" HeaderText="Ingeniero" />
                                                <asp:BoundField DataField="nombreu" HeaderText="Nombre" />
                                                <asp:BoundField DataField="Auditor_asignado" HeaderText="Auditor Asignado" />
                                                <asp:BoundField DataField="codnom" HeaderText="codigo" />
                                                 <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkCtrlLib" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                        </ContentTemplate> </asp:UpdatePanel> 
                                    </div>

                                </td>

                                <td style="width: 9%">&nbsp;</td>

                            </tr>
                        </asp:Panel>
                        
                      <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 9%">&nbsp;</td>

                        </tr>
                        <tr>

                            <td class="celdasder"></td>
                            <td colspan="3" class="auto-style3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Asignacion Casos Auditoria Manual</strong>
                                </div>
                            </td>

                            <td class="celdasder"></td>
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
                                            Codigo Caso
                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TxtCodigoCaso"
                                     ErrorMessage="el numero debe ser positivo" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
                                      
                                                 </div>
                                        
                                        <asp:TextBox ID="TxtCodigoCaso"  runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                
                                                     </div>
                                </div>

                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Auditor
                                        </div>
                                        <asp:DropDownList ID="DrlAuditor3" runat="server" CssClass="form-control">
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
                                            Consecutivo GestionCrm
                                        </div>
                                        <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="LblIdcrm" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Ingeniero
                                        </div>
                                        <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="LblIngeniero" runat="server" CssClass="form-control" Enable="False"></asp:Label>
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
                                            Bandeja
                                        </div>
                                        <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="LblBandeja" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                       Caso
                                        </div>
                                        <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="LblCaso" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>

                            <td style="width: 25%">
                                <asp:Button ID="BtnConsultar" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                              
                                 <asp:Button ID="BtnRegistrarCaso" runat="server" Text="Registrar" Visible="false"  CssClass="btn btn-primary" />
           
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
                            <td class="celdasder"></td>
                            <td colspan="3" class="auto-style3">
                                     <div class="bordes">
                              <asp:GridView ID="DtgCasosAuditar" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True" AutoGenerateColumns="False">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                    <Columns>
                                        <asp:BoundField DataField="idcrm" HeaderText="Crm" />
                                        <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                                        <asp:BoundField DataField="idusuario" HeaderText="Ingeniero" />
                                        <asp:BoundField DataField="Bandeja" HeaderText="Bandeja" />
                                        <asp:ButtonField CommandName="Seleccion" HeaderText="Seleccion un Caso" Text="Seleccion" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" HorizontalAlign="Left" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                                </div>    
                            </td>
                            <td class="celdasder"></td>
                        </tr>
                         <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 9%">&nbsp;</td>

                        </tr>
                        <tr>

                            <td class="celdasder"></td>
                            <td colspan="3" class="auto-style3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Liberacion Casos Auditoria Manual Auditor</strong>
                                </div>
                            </td>

                            <td class="celdasder"></td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%"><div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Auditor
                                        </div>
                                        <asp:DropDownList ID="DrlAuditorCasosManual" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                </div></td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <asp:Button ID="BtnConsultarCasosAuditor" runat="server" CssClass="btn btn-primary" Text="Buscar" />
                            </td>
                            <td style="width: 9%">&nbsp;</td>

                        </tr>
                         <tr>
                            <td class="celdasder"></td>
                            <td colspan="3" class="celdascent">
                               
                                <asp:UpdatePanel ID="UpdatePanel5" runat="server"><ContentTemplate>
                                         <div class="bordes">        
                                    
                                    <asp:GridView ID="DtgCasosAuditor" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="40" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True" AutoGenerateColumns="False">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                            <Columns>
                                              <asp:BoundField DataField="codigoasignacion" HeaderText="Codigo" />
                                                <asp:BoundField DataField="fechaAsignacion" HeaderText="Fecha Asignado" />
                                                <asp:BoundField DataField="Auditor" HeaderText="Auditor" />
                                                <asp:BoundField DataField="caso" HeaderText="Caso a auditar" />
                                                <asp:BoundField DataField="Ingeniero" HeaderText="Ingeniero" />
                                                <asp:BoundField DataField="Bandeja" HeaderText="Bandeja" />
                                               <asp:ButtonField CommandName="Seleccion" HeaderText="Seleccion un Caso" Text="Liberar" />
                                            </Columns>
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White"  HorizontalAlign="Left"   Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                             </div> 
                                </ContentTemplate> </asp:UpdatePanel>

                                     
                            </td>
                            <td class="celdasder"></td>
                        </tr>
                      
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 9%">&nbsp;</td>

                        </tr>
                        <tr>

                            <td class="celdasder"></td>
                            <td colspan="3" class="auto-style3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    F<strong>Ijar meta para el mes </strong>
                                </div>
                            </td>

                            <td class="celdasder"></td>
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
                                            Cantidad Meta
                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TxtMeta"
                                     ErrorMessage="el numero debe ser positivo" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
                                        </div>
                                        <asp:TextBox ID="TxtMeta" runat="server" CssClass="form-control" MaxLength="5"></asp:TextBox>
                                    </div>
                                </div>

                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <asp:Button ID="BtnActualizarM" runat="server" Text="Actualziar" CssClass="btn btn-primary" /></td>
                            <td style="width: 9%"></td>
                        </tr>
                    </table> 
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">&nbsp;</td>
                <td class="celdasder">&nbsp;</td>
            </tr>
        </table>


    </form>
</body>
</html>
