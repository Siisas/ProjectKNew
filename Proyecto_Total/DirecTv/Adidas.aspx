<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Adidas.aspx.vb" Inherits="digitacion.Adidas" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP Kamilion - Directv</title>
        <link rel="icon" href="../Directv.ico" type="image/x-icon"/>
        <link rel="shortcut icon" href="../Directv.ico" type="image/x-icon"/>
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
        
        .auto-style1 {
            height: 22px;
        }
        
         .auto-style2 {
             width: 9%;
             height: 31px;
         }
         .auto-style3 {
             width: 25%;
             height: 31px;
         }
         .auto-style4 {
             width: 5%;
             height: 31px;
         }
        
        </style>
</head>
<body>
    <form id="form1" runat="server">
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
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Consulta General DirecTv</em></h4></asp:Label>
                </td>
                <td class="auto-style4"></td>
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
                <td class="celdasder">&nbsp;</td>
                <td class="textotittabla">
                    <table cellpadding="1" cellspacing="1" width="100%">
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    Registro de Tarjetas Adidas
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
                                           N° Tarjeta  
                                             <asp:CompareValidator ID="CompareValidator4" runat="server"
                                                ControlToValidate="Txt_Tarjeta" 
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>                                       
                                        </div>
                                        <asp:TextBox ID="Txt_Tarjeta" runat="server" MaxLength="10" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Telefono &nbsp;&nbsp;
                                            <asp:CompareValidator ID="CompareValidator2" runat="server"
                                                ControlToValidate="Txt_telefono" ErrorMessage="El telefono 1 debe ser numérico"
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="Txt_telefono" runat="server" MaxLength="10" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2"></td>
                            <td class="auto-style3">
                              
                                  <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Fecha Nacimiento
                                            <asp:CompareValidator ID="CompareValidator1" runat="server"
                                                ControlToValidate="TxtFechaInicio" ErrorMessage="Revise fecha inicio"
                                                Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="TxtFechaInicio" runat="server" MaxLength="10" Enabled ="false"  placeholder="DD/MM/YYYY" CssClass="form-control"></asp:TextBox>
                                    </div>

                                </div>
                            </td>
                            <td class="auto-style4"></td>
                            <td class="auto-style3">
                               
                                   <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tipificacion</div>
                                       <asp:DropDownList ID="drltipificación" runat="server" CssClass="form-control" AutoPostBack="True">
                                           
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </td>
                            <td class="auto-style2"></td>
                        </tr>                   
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">

                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                      <tr>
                            <td style="width: 9%">&nbsp;</td>
                                 <td style="width: 25%">                           
                                       <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                    Observacion
                                      
                                        </div>
                                        <asp:TextBox ID="Txt_Observacion" runat="server" TextMode="MultiLine" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">

                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                         <tr>
                            <td colspan="5">&nbsp;</td>
                        </tr>
                          <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" CssClass="btn btn-primary" />
                               
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="5">&nbsp;</td>
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