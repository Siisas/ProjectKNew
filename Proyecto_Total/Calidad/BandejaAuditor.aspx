<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BandejaAuditor.aspx.vb" Inherits="digitacion.BandejaAuditor" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP Kamilion - Auditorias</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/jscript">
        $(function () {
            $("#TxtFc_Llamada").datepicker({ dateFormat: 'dd/mm/yy' }).val();
        });
    </script>

    <!-- Fin Script jQuery Datepicker --->
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
    <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />    
<link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
    <%------------------------------------------------------------------%>
     <script type="text/javascript">
         window.onload = function () {
             document.onkeydown = muestraInformacion;
         }
         function muestraInformacion(elEvento) {
             var evento = window.event || elEvento;
             if (evento.keyCode == 116) {
                 window.event.keyCode = 0;
                 return false;
             }
         }
    </script>

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
            src: url(../Css2/Boot/fonts/NEUROPOL.ttf);
        }
        body {
            background-color: #eee;
        }
                .titulo {
            transition: 2s ease;
            color: #B3C556;
            text-shadow: -2px -2px 1px #000;
        }
            .titulo:hover {
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
        .celdasder {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
        }
        .celdascent {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }
                .style2 {
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
        .celdascons {
            width: 35%;
        }
        .celdascons {
            width: 35%;
        }
        .style3 {
            color: #000099;
            width: 80%;
        }
        .style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }
        .style5 {
            width: 80%;
        }
       .auto-style1 {
            width: 9%;
            height: 25px;
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
                    <asp:Label ID="Label2" runat="server" ForeColor="#8F9E45"><h4><em>Bandeja Asignacion y Gestion Auditorias</em></h4></asp:Label>
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
                <td class="celdasder">
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
                    <table cellpadding="1" cellspacing="1" width="100%" style="height: 355px">
                   <tr>    
                            <td class="auto-style1">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                  Estados disponobles para consultar </div>
                            </td>
                            <td class="auto-style1">&nbsp;</td>
                        </tr>
                         <tr>
                             <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                             <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%">
                                <%--<div id="div2" style="background-color: White; border-color:Black;border-width:1px;border-style:solid;height:250px;width:50%;overflow-y:scroll; font-size: 11px;  padding: 4px 4px 4px 4px;" align="left">                               
                               --%>
                                    <div class="input-group">
                                    <div class="bordes">
                                    <asp:Panel ID="Pnl_cabecera_2"  Visible="true" runat="server">
                                        <div style="background-color: #B3C556; height: 30px; width: 100%; margin: 0; padding: 0">
                                            <table id="tblHeader"
                                                style="font-family: Arial; font-size: 10pt; width: 100%; color: white; height: 100%;">
                                                <tr>
                                                    <td style="width: 50%; text-align: left">Codigo</td>
                                                    <td style="width: 50%; text-align: left"></td>
                                                   
                                                </tr>
                                            </table>
                                        </div>
                                    </asp:Panel>
                                    
                                     <div style="overflow: auto; width: 100%; height: 250px;"> 
                                     <asp:GridView ID="DtgEstados" runat="server"  CellPadding="4" ForeColor="#333333"
                                            GridLines="None"  Width="100%" Style="font-size: x-small" ShowHeader="false"
                                            EnableModelValidation="True" AutoGenerateColumns="False">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                            <Columns>
                                              <asp:BoundField ItemStyle-Width="50%" DataField="Nombre" HeaderText="Codigo" />
                                               <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ItemStyle-Width="50%" ID="chkCtrl" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White"  HorizontalAlign="Left"   Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                    </div>     
                                   </div>
                                </div>
                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"></td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%"></td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>                         
                            <td class="auto-style1">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    Bandeja casos para auditar hoy</div>
                            </td>
                            <td class="auto-style1">&nbsp;</td>
                        </tr>
                         <tr>
                             <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                         <tr>
                             <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%"><asp:Button ID="BtnConsulta" runat="server" Text="Buscar" CssClass="btn btn-primary" Visible="False" />                                
                                <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-primary" />
                            </td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%"></td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                         <tr>
                             <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                           <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                
                                <div class="bordes">
                               <div id="div1" style="background-color: White; height:250px;width:100%;overflow-y:scroll; font-size: 11px;  padding: 4px 4px 4px 4px;" align="left">
                                        <asp:GridView ID="DtgCasosAuditar" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
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
                                            </Columns>
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White"  HorizontalAlign="Left"   Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                </div>
                                    </div> 
                            </td>

                            <td class="auto-style1">&nbsp;</td>
                        </tr>
                        <tr>
                             <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                         <tr>
                           
                            <td class="auto-style1">
                                <br />
                                &nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    Bandeja auditorias por ingeniero del mes </div>
                            </td>
                            <td class="auto-style1">&nbsp;</td>
                        </tr>
                        <tr>
                             <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                      
                        
                      
                         <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%">
                                <div>
                                <div class="input-group" >
                                    <div class="input-group-addon">
                                 Estabilidad a lograr</div>
                                    <asp:Label style="background-color: inherit" ID="Lblmax" Text="0" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                </div>
                                    </div></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">
                                 <div>
                                <div class="input-group" >
                                    <div class="input-group-addon">
                              Meta Establecida 

                                    </div>
                                    <asp:Label style="background-color: inherit; top: 0px; left: 0px;" ID="LblMeta" Text="0" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                </div>
                                    </div>
                            </td>
                       <td style="width: 9%">&nbsp;</td>
                        </tr> 
                         <tr>
                        <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%">
                                <div>
                                <div class="input-group" >
                                    <div class="input-group-addon">
                               Casos manuales</div>
                                    <asp:Label style="background-color: inherit" ID="lblCasosM" Text="0" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                </div>
                                    </div></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">
                                 <div>
                                <div class="input-group" >
                                    <div class="input-group-addon">
                          Casos Automaticos

                                    </div>
                                    <asp:Label style="background-color: inherit; top: 0px; left: 0px;" ID="LblCasosAutomaticos" Text="0" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                </div>
                                    </div>
                            </td>
                            <td class="auto-style1">&nbsp;</td>
                        </tr>  
                        <tr>
                             <td style="width: 9%">&nbsp;</td>
                            <td style="width:25%"></td>
                            <td style="width:5%">&nbsp;</td>
                            <td style="width:25%">&nbsp;</td>
                         <td style="width: 9%">&nbsp;</td>
                        </tr>
                          
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                   <div class="bordes">
                               <div id="divUsers" style=" height:250px;width:100%;overflow-y:scroll; font-size: 11px; " align="left">
                                        <asp:GridView ID="DtgUsuarios" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="40" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True" AutoGenerateColumns="False">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                            <Columns>
                                                <asp:BoundField DataField="mes" HeaderText="Mes" />
                                                <asp:BoundField DataField="nombreu" HeaderText="Nombre" />
                                                <asp:BoundField DataField="idusuario" HeaderText="Usuario" />
                                                <asp:BoundField DataField="auditorias" HeaderText="Total Auditorias" />
                                                <asp:BoundField DataField="auditor_asignado" HeaderText="Auditor" />
                                               <asp:BoundField DataField="Codnom" HeaderText="Codigo" />
                                              
                                            </Columns>
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White"  HorizontalAlign="Left"   Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                </div>
                               </div> 
                            </td>

                            <td class="auto-style1">&nbsp;</td>
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
