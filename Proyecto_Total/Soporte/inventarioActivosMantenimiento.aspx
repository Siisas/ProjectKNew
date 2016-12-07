<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="inventarioActivosMantenimiento.aspx.vb" Inherits="digitacion.inventarioActivosMantenimiento" %>


<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP Kamilion -Mantenimientos inventario 
    </title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <%--Colocar como comentario para ver correctamente la vista diseño--%>   
     <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />    <%------------------------------------------------------------------%>
     <link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/jscript">
        $(function () {
            $("#TxtFc_Mto").datepicker({ dateFormat: 'dd/mm/yy' }).val();
        });
    </script>
    <!-- Fin Script jQuery Datepicker --->


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
     
        .celdascons {
            width: 35%;
        }

        .celdascons {
            width: 35%;
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
     
        .linkbutton
        {
          color: #B3C556;
          text-decoration:none ;


        }
        .linkbutton:hover
        {
            color: #555555;
            text-decoration:solid;
            text-decoration-color: #fff; 
        }
        #form1 {
            height: 5px;
        }
       </style>



</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table style="width: 100%; height: 100%">
                <tr>
                    <td class="celdasder"></td>
                    <td class="celdascent">
                        <table style="width: 100%">
                            <tr>
                                <td align="left" style="width: 90%">
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
                    <td class="celdasder"></td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="style4">
                        <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em> Mantenimientos Inventario </em></h4></asp:Label>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder"></td>
                    <td valign="top" class="style5">
                        <table class="style2">
                            <tr>
                                <td class="auto-style2">
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
                    <td class="celdasder">&nbsp;</td>
                    <td class="style4">
                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                            <ContentTemplate>
                                <span class="alert alert-danger">
                                    <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
                                </span>
                                <br />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" Style="color: #8F9E45" />
                    </td>
                    <td class="textotittabla">
                        <table cellpadding="1" cellspacing="1" width="100%">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>
                                            <center>Registro Mantenimiento </center>
                                        </strong>
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
                                                Codigo Inventario
                                            </div>
                                            <asp:TextBox ID="TxtCodigoInventario" runat="server" CssClass="form-control" MaxLength="5"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Nombre Equipo

                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>
                                                    <asp:TextBox ID="Txtnombreequipo" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
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
                                                Mantenimiento
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="drlTipomantenimiento" runat="server" CssClass="form-control">
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
                                                Fecha Mantenimiento
                                                  <asp:CompareValidator ID="CompareValidator1" runat="server"
                                                      ControlToValidate="TxtFc_Mto" ErrorMessage="Revise fecha mantenimiento"
                                                      Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </div>
                                            <asp:TextBox ID="TxtFc_Mto" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%"></td>
                            </tr>
                            <tr>
                                <td style="width: 9%"></td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipo</div>
                                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="drlTipo" runat="server" AutoPostBack="false" CssClass="form-control">
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>



                                </td>
                                <td style="width: 5%"></td>
                                <td style="width: 25%"><div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Observacion
                                            </div>
                                            <asp:TextBox ID="TxtObservacion" runat="server" CssClass="form-control" MaxLength="50" TextMode="MultiLine"></asp:TextBox>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 9%"></td>
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
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>
                                            <center>Consultas</center>
                                        </strong>
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
                        &nbsp;</td>
                    <td style="width: 25%">

                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="Rdbtnmnto" runat="server" GroupName="Seleccion" Text="Mantenimiento" />

                                </div>
                                <asp:DropDownList ID="drlTpMantenimiento" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbtnSolucion" runat="server" GroupName="Seleccion" Text="Tipo" />

                                </div>
                                <asp:DropDownList ID="drlsolucionhs" runat="server" CssClass="form-control">
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
                                    <asp:RadioButton ID="RdbtnSeriale" runat="server" GroupName="Seleccion" Text="Serial Equipo" />

                                </div>
                                <asp:TextBox ID="TxtSerial" runat="server" CssClass="form-control" MaxLength="15"></asp:TextBox>
                            </div>
                        </div>

                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbtnSerialk" runat="server" GroupName="Seleccion" Text="Serial Kamilion" />
                                </div>
                                <asp:TextBox ID="TxtSerial1" runat="server" CssClass="form-control" MaxLength="12"></asp:TextBox>
                            </div>
                        </div>
                    </td>
                    <td style="width: 9%"></td>
                </tr>
                <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbtnNombre" runat="server" GroupName="Seleccion" Text="Nombre Equipo" />


                                </div>
                                <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="Txtnombreequipo1" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
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
                                    <asp:RadioButton ID="RdbtnCodInventario" runat="server" GroupName="Seleccion" Text="Cod Inventario" />

                                </div>
                                <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="TxtCodInventario" runat="server" CssClass="form-control" MaxLength="5"></asp:TextBox>
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

                        <asp:Button ID="BtnBuscarMantenimientos" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                        <asp:Button ID="BtnExportar" runat="server" Text="Exportar" CssClass="btn btn-primary" Visible="False" />

                        <asp:Button ID="btn_Buscar_Todos" runat="server" Text="Buscar Todos" CssClass="btn btn-primary"  />

                    </td>
                    <td style="width: 5%"></td>
                    <td style="width: 25%"></td>
                    <td style="width: 9%"></td>
                </tr>
                <tr>
                    <td style="width: 9%"></td>
                    <td style="width: 25%"></td>
                    <td style="width: 5%"></td>
                    <td style="width: 25%"></td>
                    <td style="width: 9%"></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <h4><em style="color: #8F9E45">Numero registros mantenimiento :</em>
                            <asp:Label ID="Lblcantidad" runat="server" ForeColor="#8F9E45"></asp:Label></h4>
                        <div class="bordes">
                            <asp:GridView ID="dtgConsultamantenimientos" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="fk_cod_inventario" HeaderText="Código inventario" />
                                    <asp:BoundField DataField="Nombre_Equipo" HeaderText="Nombre Equipo" />
                                    <asp:BoundField DataField="nombre_Dispositivo" HeaderText="Dispositivo" />
                                    <asp:BoundField DataField="serial" HeaderText="Serial " />
                                    <asp:BoundField DataField="Serial_Kamilion" HeaderText="Serial Kamilion" />
                                    <asp:BoundField DataField="modelo" HeaderText="Modelo" />
                                    <asp:BoundField DataField="marca" HeaderText="Marca" />
                                    <asp:BoundField DataField="mantenimiento" HeaderText=" Mantenimiento" />
                                    <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                                    <asp:BoundField DataField="fc_mantenimiento" HeaderText="Fecha Mantenimiento" DataFormatString="{0:dd/MM/yyyy}" />
                                    <asp:BoundField DataField="obs" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Usu_Reg" HeaderText="Usuario registra" />
                                    <asp:BoundField DataField="fc_reg" HeaderText="Fecha Registro" />
                                </Columns>
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>

                        </div>
                        <br />
                        <asp:GridView ID="dtgxls" runat="server"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small" EnableModelValidation="True" Visible="False">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="fk_cod_inventario" HeaderText="Código inventario" />
                                <asp:BoundField DataField="Nombre_Equipo" HeaderText="Nombre Equipo" />
                                <asp:BoundField DataField="nombre_Dispositivo" HeaderText="Dispositivo" />
                                <asp:BoundField DataField="serial" HeaderText="Serial " />
                                <asp:BoundField DataField="Serial_Kamilion" HeaderText="Serial Kamilion" />
                                <asp:BoundField DataField="modelo" HeaderText="Modelo" />
                                <asp:BoundField DataField="marca" HeaderText="Marca" />
                                <asp:BoundField DataField="mantenimiento" HeaderText=" Mantenimiento" />
                                <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                                <asp:BoundField DataField="fc_mantenimiento" HeaderText="Fecha Mantenimiento" />
                                <asp:BoundField DataField="obs" HeaderText="Observacion" />
                                <asp:BoundField DataField="Usu_Reg" HeaderText="Usuario registra" />
                                <asp:BoundField DataField="fc_reg" HeaderText="Fecha Registro" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>

                        <br />
                        <br />
                    </td>

                </tr>

                <tr>
                    <td colspan="5"></td>

                </tr>

                <tr>
                    <td colspan="5"></td>
                </tr>

            </table>
        </div>
    </form>
    <br />
    <br />

</body>
</html>
