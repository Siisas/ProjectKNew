<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InventarioActivos.aspx.vb" Inherits="digitacion.InventarioActivos" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>ERP Kamilion - Inventario Activos</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <!-- Fin Script jQuery Datepicker --->
<%--Colocar como comentario para ver correctamente la vista diseño--%>
        <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
        <link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
<%------------------------------------------------------------------%>   
    <style type="text/css">
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
        *::selection {
            background: #B3C556;
            color: #fff;
                    }
       ::-moz-selection {
        background: #B3C556;
        color: #fff;

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
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Inventario Activo</em></h4></asp:Label>
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
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" ForeColor="#8F9E45"><h4><em>Registro</em></h4></asp:Label>
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
                <td class="celdasder">&nbsp;</td>
                <td class="textotittabla">
                    <table cellpadding="1" cellspacing="1" width="100%">
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>DISPOSITIVO</strong>                                    
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <span class="alert alert-warning">
                                    <asp:Label ID="LblmsgDispositivo" runat="server"></asp:Label></span>
                            </td>
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
                                            Dispositivo                                           
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlDispositivo" runat="server" AutoPostBack="True" Width="50%" CssClass="form-control">
                                                </asp:DropDownList>
                                                <asp:Label ID="lblCodigo" runat="server" Visible="False" Width="50%" CssClass="form-control"></asp:Label>
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
                                            Marca
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlMarcaDisposivito" runat="server" AutoPostBack="True" Width="50%" CssClass="form-control">
                                                </asp:DropDownList>
                                                <asp:TextBox ID="TxtMarcaDispositivo" runat="server" Enabled="true" Width="50%" CssClass="form-control"></asp:TextBox>
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
                                            Modelo
                                        </div>
                                        <asp:TextBox ID="TxtModeloDispositivo" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Descripción
                                        </div>
                                        <asp:TextBox ID="TxtDescripcion" runat="server" MaxLength="50"
                                            TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
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
                                            Serial                                           
                                        </div>
                                        <asp:TextBox ID="TxtSerialDispositivo" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial Kamilion
                                        </div>
                                        <asp:TextBox ID="TxtSerialKamilionDispositivo" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                                    ShowMessageBox="True" />
                            </td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Empresa
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlEmpresaDispositivo" runat="server" AutoPostBack="True" Width="50%" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>KAMILION</asp:ListItem>
                                                    <asp:ListItem>Otro</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:TextBox ID="TxtEmpresaDispositivo" runat="server" Enabled="False" Width="50%" CssClass="form-control"></asp:TextBox>
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
                                            Sede
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlModuloDispositivo" runat="server" CssClass="form-control">
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
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Agente
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlAgenteDispositivo" runat="server" CssClass="form-control">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%"></td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="5">&nbsp;</td>
                        </tr> 
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <asp:Button ID="BtnGuardarDispositivo" runat="server" Text="Guardar" CssClass="btn btn-primary" />
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">&nbsp;</td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="5">&nbsp;</td>
                        </tr>                     
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Consultas</strong>                                    
                                </div>
                            </td>

                            <td style="width: 9%">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%"><span class="alert alert-warning"><asp:Label ID="LblmsgConsultas" runat="server"></asp:Label></span></td>
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
                                            <asp:RadioButton ID="Rdbtndispositivo" GroupName="Seleccion" runat="server" Text="Dispositivo" />
                                        </div>
                                        <asp:DropDownList ID="drlDispositivoconsulta" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnModulo" GroupName="Seleccion" runat="server" Text="Sede"/>
                                        </div>
                                        <asp:DropDownList ID="drlModuloConsultas" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem>A</asp:ListItem>
                                            <asp:ListItem>B</asp:ListItem>
                                            <asp:ListItem>C</asp:ListItem>
                                            <asp:ListItem>D</asp:ListItem>
                                            <asp:ListItem>BOD</asp:ListItem>
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
                                            <asp:RadioButton ID="RdbtnMarca" GroupName="Seleccion" runat="server" Text="Marca" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlMarcaConsulta" runat="server" AutoPostBack="True" Width="50%" CssClass="form-control">
                                                </asp:DropDownList>
                                                <asp:TextBox ID="TxtMarcaConsulta" runat="server" Enabled="True" Width="50%" CssClass="form-control"></asp:TextBox>
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
                                            <asp:RadioButton ID="RdbtnModelo" GroupName="Seleccion" runat="server" Text="Modelo"/>
                                        </div>
                                        <asp:TextBox ID="TxtModeloConsulta" runat="server" CssClass="form-control"></asp:TextBox>
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
                                            <asp:RadioButton ID="RdbtnSerial" GroupName="Seleccion" runat="server" Text="Serial"/>
                                        </div>
                                        <asp:TextBox ID="TxtSerialConsulta" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnSerialKamilion" GroupName="Seleccion" runat="server" Text="Serial Kamilion"/>
                                        </div>
                                        <asp:TextBox ID="TxtSerialKamilionConsulta" runat="server" CssClass="form-control"></asp:TextBox>
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
                                            <asp:RadioButton ID="RdbtnEmpresa" GroupName="Seleccion" runat="server" Text="Empresa" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlEmpresaConsulta" runat="server" AutoPostBack="True" Width="50%" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>KAMILION</asp:ListItem>
                                                    <asp:ListItem>Otro</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:TextBox ID="TxtEmpresaConsulta" runat="server" Enabled="False" Width="50%" CssClass="form-control"></asp:TextBox>
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
                                            <asp:RadioButton ID="RdbtnAgente" GroupName="Seleccion" runat="server" Text="Usuario \ Agente"/>
                                        </div>
                                        <asp:DropDownList ID="drlAgenteConsulta" runat="server" CssClass="form-control">
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
                                            <asp:RadioButton ID="RdbtnTodo" GroupName="Seleccion" runat="server" Text="Buscar Todo" />
                                        </div>
                                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 5%">&nbsp;</td>
                            <td style="width: 25%">
                                <div>
                                    <div class="input-group">
                                        <div class="input-group-addon">                                           
                                            <asp:RadioButton ID="Rdbtncodigoagente" GroupName="Seleccion" runat="server" text="Codigo Agente"/>
                                        </div>
                                        <asp:DropDownList ID="drlcodigoagente" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </td>
                            <td style="width: 9%">&nbsp;</td>
                        </tr>  
                         <tr>
                            <td colspan="5">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td style="width: 25%">
                                <asp:Button ID="BtnConsultaespe" runat="server" Text="Consultar"
                                    Style="height: 26px" Visible="False" />
                                <asp:ImageButton ID="BtnConsultaInventario" runat="server"
                                    ImageUrl="~/Css2/Imagenes/Consulta.png" Height="70px" Width="72px"/>&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="BtnExel" runat="server" Text="Exportar" Visible="false" CssClass="btn btn-primary" />
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
                    <h4><em style="color: #8F9E45">Consultas</em></h4>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <h4><em style="color: #8F9E45">Numero de registros:</em>
                        <asp:Label ID="lblcantidad" runat="server" ForeColor="#8F9E45"></asp:Label></h4>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <div class="bordes">
                        <asp:GridView ID="dtgConsultaMonitores" runat="server" AllowPaging="True"
                            AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="90" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="false">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="Cod_Inventario" HeaderText="Código" />
                                <asp:BoundField DataField="Dispositivo" HeaderText="Dispositivo" />
                                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                                <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                                <asp:BoundField DataField="Serial" HeaderText="Serial" />
                                <asp:BoundField DataField="Serial_Kamilion" HeaderText="Serial Kamilion" />
                                <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                                <asp:BoundField DataField="Sede" HeaderText="Sede" />
                                <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario Registra" />
                                <asp:BoundField DataField="FcReg_Invent" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="Cod_Agente" HeaderText="Usuario" />
                                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>

                        <asp:GridView ID="dtgConsultaMonitores2" runat="server" AllowPaging="True"
                            AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="8000" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="false" Visible="false">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="Cod_Inventario" HeaderText="Código" />
                                <asp:BoundField DataField="Dispositivo" HeaderText="Dispositivo" />
                                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                                <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
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