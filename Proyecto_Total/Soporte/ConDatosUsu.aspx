<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConDatosUsu.aspx.vb" Inherits="digitacion.ConDatosUsu" %>
<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP Kamilion - Credenciales</title>
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
                <td class="celdasder">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Consulta Credenciales</em></h4></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder"></td>
                <td class="auto-style2">
                        
                    <span class="alert alert-danger">
                                
                                <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
                           
                    </span>
                          
                </td>
                <td class="celdasder"></td>
            
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

                <td class="textotittabla">
                    <table cellpadding="1" cellspacing="1" width="100%">
                       <%--<asp:Panel ID="Panel1" runat="server">--%>

                       
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                  <strong>  Solicitar  Usuarios y Credenciales</strong></div> 
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
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                          Nombre</div>
                                <asp:TextBox ID="TxtNombre" CssClass="form-control"  runat="server" Enabled="False" MaxLength="50"></asp:TextBox>
    
                                    </div>
                                </div></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                          Cedula</div>
                                <asp:TextBox ID="TxtCedula" CssClass="form-control"  runat="server" Enabled="False" MaxLength="11"></asp:TextBox>
    
                                    </div>
                                </div></td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>  
                       <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%"> <div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                          Codigo</div>
                                <asp:TextBox ID="TxtCodigo" CssClass="form-control"  runat="server" MaxLength="10" Enabled="False"></asp:TextBox>
    
                                    </div>
                                </div></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                          Grupo</div>
                                <asp:TextBox ID="TxtGrupo" CssClass="form-control"  runat="server" Enabled="False" MaxLength="50"></asp:TextBox>
    
                                    </div>
                                </div></td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>  
                       
                       <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                          Area</div>
                                <asp:TextBox ID="TxtArea" CssClass="form-control"  runat="server" Enabled="False" MaxLength="50"></asp:TextBox>
    
                                    </div>
                                </div></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                          Estado General</div>
                                <asp:TextBox ID="TxtEstado" CssClass="form-control"  runat="server" Enabled="False" MaxLength="50"></asp:TextBox>
    
                                    </div>
                                </div></td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>  
                       <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>  
                        
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                           Plataforma Red</div>
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                              <asp:DropDownList ID="DrlPlataformaRed" CssClass="form-control" runat="server" AutoPostBack="True">
                                </asp:DropDownList>

                                            </ContentTemplate> 
                                                </asp:UpdatePanel> 
                                    </div>
                                </div></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                          Codigo Asignacion</div>
                                <asp:TextBox ID="TxtCod_Asignacion" CssClass="form-control"  runat="server" Enabled="False"></asp:TextBox>
    
                                    </div>
                                </div></td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>  
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                           Plataforma Usuarios</div>
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                        <asp:DropDownList ID="drlPlataforma" CssClass="form-control" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                    </div>
                                </div></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                           Estado Plataforma</div>
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                              <asp:DropDownList ID="DrlEstadoP" CssClass="form-control" runat="server">
                                </asp:DropDownList>
                                                </ContentTemplate> 
                                            </asp:UpdatePanel>
                                    </div>
                                </div></td>
                            <td style="width:9%">&nbsp;</td>
                        </tr> 
                        
                          <tr>
                            <td style="width:9%">&nbsp;</td>
                          
                            
                            <td style="width:25%">
                                  </td>
                              <td style="width:5%">&nbsp;</td>
                                <td style="width:25%"></td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>   
                           

                        <tr>
                            <td style="width:9%">&nbsp;</td>
                             <td style="width:25%">
                                 <asp:Button ID="BtnActualizacion" runat="server" Text="Actualizar" CssClass="btn btn-primary" />

                            </td>
                           
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"> 
                                
                               
                            </td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%">  
                                 

                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:9%">&nbsp;</td>
                        </tr> 

                       <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:9%">&nbsp;</td>
                        </tr> 
                       <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                  <strong> Filtros de consulta</strong></div>
                            </td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>  
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                               <div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                         Codigo </div>
                                <asp:TextBox ID="TxtConsultaCodigo" CssClass="form-control"  runat="server" Columns="10" MaxLength="10"></asp:TextBox>
    
                                    </div>
                                </div></td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                           Estado Plataforma</div>
                                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                            <ContentTemplate>
                              <asp:DropDownList ID="DrlPlataformaE2" CssClass="form-control" runat="server">
                                </asp:DropDownList>
                                                </ContentTemplate> 
                                            </asp:UpdatePanel>
                                    </div>
                                </div></td>
                            <td style="width: 9%"></td>
                        </tr> 
                       <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%"><div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                           Plataforma Red</div>
                                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                            <ContentTemplate>
                              <asp:DropDownList ID="DrlPlataformaRed2" CssClass="form-control" runat="server" AutoPostBack="True">
                                </asp:DropDownList>

                                            </ContentTemplate> 
                                                </asp:UpdatePanel> 
                                    </div>
                                </div></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"> <div>
                                    <div class="input-group">
                                <div class="input-group-addon">
                                           Plataforma Usuarios</div>
                                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                            <ContentTemplate>
                                        <asp:DropDownList ID="DrlPlataforma2" CssClass="form-control" runat="server" AutoPostBack="True">
                                </asp:DropDownList>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                    </div>
                                </div></td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>  
<tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:9%">&nbsp;</td>
                        </tr> 
                      
                        <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%">   <asp:Button ID="BtnConsultaGeneral" runat="server" Text="Consultar" CssClass="btn btn-primary" /> 
                                

                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:9%">&nbsp;</td>
                        </tr> 
                        
                         
 <tr>
                            <td colspan="5">
                                &nbsp;</td>
                            
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
                    <h4><em style="color:#8F9E45">Consulta Credenciales</em>
                    <asp:Label ID="lblcuentaCredenciales" runat="server" ForeColor="#8F9E45"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;</h4>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">
                    &nbsp;</td>
                <td class="celdascent">
                    <div class="bordes">
                        <asp:GridView ID="DtgCredenciales" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" PageSize="80" Width="100%" style="font-size: x-small" 
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                           <Columns>
                            <asp:BoundField DataField="Codigo_asignacion" HeaderText="Codigo" />
                               <asp:BoundField DataField="Codigo" HeaderText="Codigo Crm" />
                            <asp:BoundField DataField="Estado_plataforma" HeaderText="Estado Plataforma" />
                            <asp:BoundField DataField="Plataforma" HeaderText="Nombre Plataforma" />
                             <asp:BoundField DataField="Formato" HeaderText="Formato Solicitud" />
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