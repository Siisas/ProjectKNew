<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DirecTv_Consulta.aspx.vb" Inherits="digitacion.Directv_consulta" %>

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
                                    <strong>Consulta</strong>
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
                                            Id Cliente&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                           
                                        </div>
                                        <asp:TextBox ID="Txtid_cliente" runat="server" MaxLength="11" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Telefono 1&nbsp;&nbsp;
                                            <asp:CompareValidator ID="CompareValidator2" runat="server"
                                                ControlToValidate="Txttelefono1" ErrorMessage="El telefono 1 debe ser numérico"
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="Txttelefono1" runat="server" MaxLength="11" CssClass="form-control"></asp:TextBox>
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
                                            Código Asesor 
                                        </div>
                                        <asp:TextBox ID="Txtcodigoasesor" runat="server" MaxLength="6" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tipificación&nbsp;&nbsp;&nbsp;&nbsp;
                                        </div>
                                        <asp:DropDownList ID="drltipificación" runat="server" CssClass="form-control">
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
                                            Tipo Llamada&nbsp;&nbsp;
                                        </div>
                                        <asp:DropDownList ID="Drltipollamada" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem>INBOUND</asp:ListItem>
                                            <asp:ListItem>OUTBOUND</asp:ListItem>
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
                                            Fecha Inicio&nbsp;&nbsp;
                                            <asp:CompareValidator ID="CompareValidator1" runat="server"
                                                ControlToValidate="TxtFechaInicio" ErrorMessage="Revise fecha inicio"
                                                Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="TxtFechaInicio" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Fecha Fin&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:CompareValidator ID="CompareValidator10" runat="server"
                                            ControlToValidate="TxtFechaFin" ErrorMessage="Revise fecha fin"
                                            Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="TxtFechaFin" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" CssClass="btn btn-primary" />
                                <asp:Button ID="BtnExporExc" runat="server" Text="Exportar" CssClass="btn btn-primary" />
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
                <td class="celdascent">
                    <h4><em style="color: #8F9E45">Registros encontrados general:</em>
                        <asp:Label ID="LblCuenta" runat="server" ForeColor="#8F9E45"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button
                            ID="Btnxls" runat="server" Text="Exportar" Visible="False" CssClass="btn btn-primary" /></h4>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <div class="bordes">
                        <asp:GridView ID="dtgGeneral" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" Width="100%" Style="font-size: x-small; text-align: center;"
                            EnableModelValidation="True" PageSize="30">
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Left" />
                            <Columns>
                                <asp:BoundField DataField="Id_Direct_TV_Cliente" HeaderText="Id Cliente" />
                                <asp:BoundField DataField="Cas_Fc_Reg" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="Numeros_Asociados" HeaderText="Números Asociados" />
                                <asp:BoundField DataField="Nombre_Cliente" HeaderText="Cliente" />
                                <asp:BoundField DataField="Cedula_Cliente" HeaderText="Cédula" />
                                <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                                <asp:BoundField DataField="Cod_factura_Codensa" HeaderText="Número Cliente Codensa" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                        </asp:GridView>
                        <asp:GridView ID="dtgGeneralExcel" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True" PageSize="30" Visible="False">
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Left" />
                            <Columns>
                                <asp:BoundField DataField="Id_Direct_TV_Cliente" HeaderText="Id Cliente" />
                                <asp:BoundField DataField="Cas_Fc_Reg" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="Numeros_Asociados" HeaderText="Números Asociados" />
                                <asp:BoundField DataField="Nombre_Cliente" HeaderText="Cliente" />
                                <asp:BoundField DataField="Cedula_Cliente" HeaderText="Cédula" />
                                <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                                <asp:BoundField DataField="Cod_factura_Codensa" HeaderText="Número Cliente Codensa" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Left" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                        </asp:GridView>
                    </div>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <h4><em style="color: #8F9E45">Registros encontrados gestión:</em>
                        <asp:Label ID="Lblcuenta1" runat="server" ForeColor="#8F9E45"></asp:Label></h4>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <div class="bordes">
                        <asp:GridView ID="dtgGeneral1" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" Width="100%" Style="font-size: x-small; text-align: center;"
                            EnableModelValidation="True" PageSize="30">
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Left" />
                            <Columns>
                                <asp:BoundField DataField="Id_Direct_TV_Cliente" HeaderText="Id Cliente" />
                                <asp:BoundField DataField="TipoLlamada" HeaderText="Tipo Llamada" />
                                <asp:BoundField DataField="Telefono_Cliente" HeaderText="Telefono 1" />
                                <asp:BoundField DataField="Fc_Registro" HeaderText="Fecha Seguimiento" />
                                <asp:BoundField DataField="Id_Agente" HeaderText="Asesor" />
                                <asp:BoundField DataField="Observacion" HeaderText="Observación" />
                                <asp:BoundField DataField="Tipificacion" HeaderText="Tipificación" />
                                <asp:BoundField DataField="Fc_Hr_Programacion" HeaderText="Fecha Programacion" />
                                <asp:BoundField DataField="Numero_Contrato" HeaderText="Número Contrato" />

                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                        </asp:GridView>
                        <asp:GridView ID="dtgGeneral1Excel" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" Width="100%" Style="font-size: x-small; text-align: center;"
                            EnableModelValidation="True" PageSize="30" Visible="False">
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Left" />
                            <Columns>
                                <asp:BoundField DataField="Id_Direct_TV_Cliente" HeaderText="Id Cliente" />
                                <asp:BoundField DataField="TipoLlamada" HeaderText="Tipo Llamada" />
                                <asp:BoundField DataField="Telefono_Cliente" HeaderText="Telefono 1" />
                                <asp:BoundField DataField="Fc_Registro" HeaderText="Fecha Seguimiento" />
                                <asp:BoundField DataField="Id_Agente" HeaderText="Asesor" />
                                <asp:BoundField DataField="Observacion" HeaderText="Observación" />
                                <asp:BoundField DataField="Tipificacion" HeaderText="Tipificación" />
                                <asp:BoundField DataField="Fc_Hr_Programacion" HeaderText="Fecha Programacion" />
                                <asp:BoundField DataField="Numero_Contrato" HeaderText="Número Contrato" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
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
    </form>
</body>
</html>