<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AsigSegundoConcepto.aspx.vb" Inherits="digitacion.AsigsSegundoConcepto" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

    <script type="text/javascript" language="javascript">
function Reload() {
            window.opener.document.location.reload()
        }
</script> 
    <title>ERP Kamilion</title>
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
                    <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Asignacion De Segundo Concepto</em></h4></asp:Label>
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
                       <asp:Panel ID="Pnl2" runat="server" Visible="false">
                         <tr>
                           
                            <td style="width:9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong> Solicitud Segundo Concepto</strong>
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
                            <td style="width:25%">
                                 <h4><asp:Button ID="BtnExportar" runat="server" Text="Exportar" Visible="False" CssClass="btn btn-primary" />
                   <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" Visible="False" CssClass="btn btn-primary" /></h4>
                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>
                         <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style=" color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                     <asp:GridView ID="DtgAuditoria" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True" AutoGenerateColumns="False">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                              <Columns>
                                                <asp:BoundField DataField="Codigo_Reg" HeaderText="Codigo" />
                                                <asp:BoundField DataField="Id_Auditoria" HeaderText="id Auditoria" />
                                                 <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Registro" />
                                                <asp:BoundField DataField="Id_Usuario" HeaderText="Reporta" />
                                                <asp:BoundField DataField="Razon" HeaderText="Razon" />
                                                <asp:BoundField DataField="Asistio" HeaderText="Asistio" />
                                                <asp:BoundField DataField="Observacion" HeaderText="Observacion Lider" />
                                                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                                <asp:BoundField DataField="Auditor" HeaderText="Auditor" />
                                                      <asp:BoundField DataField="observacionauditor" HeaderText="Observacion Auditor" />
                                                <asp:BoundField DataField="Fc_Asignacion" HeaderText="Fecha Asignacion"/>
                                                <asp:BoundField DataField="Fc_Respuesta" HeaderText="Fecha Respuesta" />
                                             <asp:BoundField DataField="Proceso" HeaderText="Proceso" />
                                                <asp:ButtonField CommandName="Solicitar" HeaderText="Revisar" Text="Solicitar" />
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

                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                     </asp:Panel>
                          <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>
                          <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>
                          <asp:Panel ID="Pnl1" runat="server" Visible="false">
                        <tr>

                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Revision Segundo Concepto CA</strong>
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
                            <td style="width:9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                       Asignar
                                    </div>
                                    <asp:DropDownList ID="drlAuditor" runat="server" CssClass="form-control"  >
                                 </asp:DropDownList>
                                </div>
                                    </div>
                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width: 25%">
                            <div class="form-group" >
                                <div class="input-group" >
                                    <div class="input-group-addon">
                                Codigo segundo concepto
                                    </div>
                                    <asp:Label style="background-color: inherit" ID="LblCod_SegCocepto" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                </div>
                                    </div>
                                
                            </td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>    <tr>
                            <td style="width: 9%">&nbsp;</td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                      <tr>
                            <td style="width:9%">&nbsp;</td>
                            <td style="width: 25%">
                             <asp:Button ID="BtnAsignar" runat="server" Text="Asignar" CssClass="btn btn-primary" />
                             <asp:Button ID="BtnVolver" runat="server" Text="Volver" CssClass="btn btn-primary" />   
                             <asp:Button ID="BtnDevolver" runat="server" Text="Devolver" CssClass="btn btn-primary" />         
                           </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width: 25%">
                            </td>
                            <td style="width:9%">&nbsp;</td>
                        </tr>
                         <tr>
                            <td style="width: 9%">&nbsp;</td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                    
 </asp:Panel>
                    </table>
                </td>
               
                <td class="celdasder">&nbsp;</td>
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
    
    
    </form>
</body>
</html>
