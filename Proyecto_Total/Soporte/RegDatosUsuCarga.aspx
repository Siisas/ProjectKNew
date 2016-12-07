<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegDatosUsuCarga.aspx.vb" Inherits="digitacion.RegDatosUsuCarga" %>

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
                    <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Credenciales</em></h4></asp:Label>
                </td>
                <td class="celdasder">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2">
                        
                    <span class="alert alert-danger">
                                
                                <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
                           
                    </span>
                          
                </td>
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
                    &nbsp;</td>
                <td class="celdasder">
                    &nbsp;</td>
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
                                    <strong>Carga y Consulta Credenciales</strong>
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
                            <td colspan="3">
                                <asp:FileUpload ID="FileArchivo" runat="server" OnClick="btnUpload_Click" CssClass="btn btn-primary" />
                            </td>
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
                            <td style="width: 25%">
                               <div class="input-group">
                                                <div class="input-group-addon">
                                                    Registros encontrados<br/> <br/> 
                                                    <asp:CheckBox ID="CheckBoxActualizacion" runat="server" Text=" Actualizacion"  />
                                                </div>
                                                <asp:Button ID="BtnVer2" runat="server" Text="Visualizar" Visible="true" CssClass="btn btn-primary" style="width:50%" />
                                                <asp:Button ID="BtnImportar" runat="server" Text="Guardar" Visible="true" CssClass="btn btn-primary" style="width:50%" />
                                   <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" Visible="false" CssClass="btn btn-primary" style="width:50%" />
                                                <asp:Label Style="background-color: inherit" ID="LblCantidad2" runat="server" CssClass="form-control"></asp:Label>
                                            </div>
                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div class="form-group">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Registros ingresados
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="lblcantidad" runat="server" CssClass="form-control"></asp:Label>
                                    </div>
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
                            <td colspan="3">
<asp:GridView ID="DtgVisualizar" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True" AutoGenerateColumns="False">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                            <Columns>
                                                 <asp:BoundField DataField="codigo" HeaderText="Codigo Asignacion" />
                                                <asp:BoundField DataField="Fk_codnom" HeaderText="Usuario Crm" />
                                                <asp:BoundField DataField="Fk_plataforma" HeaderText="Codigo Plataforma" />
                                                <asp:BoundField DataField="Usuario_Plataforma" HeaderText="Usuario Plataforma" />
                                                <asp:BoundField DataField="Password_plataforma" HeaderText="Password Plataforma" />
                                            <asp:BoundField DataField="Estado_Plataforma" HeaderText="Estado Plataforma" />
                                      <asp:BoundField DataField="formato" HeaderText="Formato Solicitud" />
                                            </Columns>
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                            </td>
                            <td style="width:9%">&nbsp;</td>
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
                    <div class="bordes">
                    
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
    
    
    </form>
</body>
</html>