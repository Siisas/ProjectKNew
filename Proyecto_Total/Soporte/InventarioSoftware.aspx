<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InventarioSoftware.aspx.vb" Inherits="digitacion.InventarioSoftware" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%--© CDRR--%>
    <title>ERP Kamilion - Inventario Sofware</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
    <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
    <%------------------------------------------------------------------%>
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
   


<script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/jscript">
        var $_$ = jQuery.noConflict();
        function pageLoad() {
            $_$("#Txt_fecha_instalacion").datepicker({}).val();/*Fecha*/
            $_$("#txt_fecha_actualizar").datepicker({}).val();/*Fecha*/
        }
</script>


    <!-- Fin Script jQuery Datepicker --->

    <!-- Fin Script jQuery Datepicker --->


    <style type="text/css">
        ::-webkit-scrollbar {
            width: 14px;
        }

        ::-webkit-scrollbar-button {
            background-color: #B3C556;
            border-radius: 5px;
            background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%, transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%, transparent 75%, /*SD*/ transparent);
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
            background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%, transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%, transparent 75%, /*SD*/ transparent);
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

        ::-moz-selection {
            background: #B3C556;
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

            color: #B3C556;
            text-decoration: none;
        }

            .linkbutton:hover {
                color: #555555;
                text-decoration: solid;
                text-decoration-color: #fff;
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
                        <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Inventario de Software</em></h4></asp:Label>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <%--  <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent">&nbsp;</td>
                    <td class="celdasder">&nbsp;</td>
                </tr>--%>
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
                    <td class="celdasder"></td>
                    <td class="celdascent">&nbsp;</td>

                    <td class="celdasder"></td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="textotittabla">
                        <table cellpadding="1" cellspacing="1" width="100%">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>Buscar Equipo</strong>
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
                                                <asp:RadioButton ID="RdbtnModulo" GroupName="Seleccion" runat="server" Text="Modulo" />

                                            </div>
                                            <asp:DropDownList ID="Drl_modulo" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                <asp:RadioButton ID="RdbtnSerial" GroupName="Seleccion" runat="server" Text="Serial" />
                                            </div>
                                            <asp:TextBox ID="Txt_serial" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
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
                                            <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                       <%--     <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Nombre Dispositivo
                                            </div>
                                            <asp:Label Style="background-color: inherit" ID="Lbl_dispositivo" runat="server" Text="" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Estado
                                            </div>
                                            <asp:Label Style="background-color: inherit" ID="Lbl_estado" runat="server" Text="" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>--%>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Serial 
                                            </div>
                                            <asp:Label Style="background-color: inherit" ID="Lbl_serial" runat="server" Text="" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Modulo                                             
                                            </div>
                                            <asp:Label Style="background-color: inherit" ID="lbl_sede" runat="server" Text="" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Empresa 
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="Lbl_empresa" runat="server" Text="" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                </td>
                                <td style="width: 5%"></td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Modelo 
                                        </div>
                                        <asp:Label Style="background-color: inherit" ID="Lbl_modelo" runat="server" Text="" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                </td>

                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                      <div class="input-group">
                                        <div class="input-group-addon">
                                          Codigo Inventario
                                        </div>
                                    <asp:Label Style="background-color: inherit" ID="Lbl_Codigo_inventario" runat="server" Text="" CssClass="form-control" Visible="true"></asp:Label>
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
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>Registro de Software</strong>
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
                                                Producto
                                            </div>
                                            <%-- <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                <ContentTemplate>--%>

                                            <asp:DropDownList ID="Drl_Programas" runat="server" CssClass="form-control"></asp:DropDownList>
                                            <%-- </ContentTemplate>
                                            </asp:UpdatePanel>--%>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Version
                                  <%-- <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_Version"
                                       ErrorMessage="el numero debe ser mayor a cero" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>--%>

                                                <asp:CompareValidator ID="CompareValidator1" runat="server"
                                                    ControlToValidate="txt_Version" ErrorMessage=""
                                                    Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                            </div>
                                            <%--    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>--%>

                                            <asp:TextBox ID="txt_Version" runat="server" Text="" CssClass="form-control" MaxLength="20"></asp:TextBox>

                                            <%--   </ContentTemplate>
                                            </asp:UpdatePanel>--%>
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
                                                Tipo De Licencia
                                            </div>
                                            <%--         <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                <ContentTemplate>--%>

                                            <asp:DropDownList ID="Drl_tipo_licencia" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem>EL</asp:ListItem>
                                                <asp:ListItem>SL</asp:ListItem>
                                                <asp:ListItem>EU</asp:ListItem>
                                            </asp:DropDownList>
                                            <%--      </ContentTemplate>
                                            </asp:UpdatePanel>--%>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Serial Del Producto
                                            </div>
                                            <%--    <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                <ContentTemplate>--%>

                                            <asp:TextBox ID="Txt_codigo_licencia" runat="server" Text="" MaxLength="50" CssClass="form-control"></asp:TextBox>
                                            <%--       </ContentTemplate>
                                            </asp:UpdatePanel>--%>
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
                                                Fecha De Instalacion
                                                   <asp:CompareValidator ID="CompareValidator2" runat="server"
                                                       ControlToValidate="Txt_fecha_instalacion" ErrorMessage="La fecha de ingreso no es válida"
                                                       Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </div>
                                            <%--    <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                                <ContentTemplate>--%>


                                            <asp:TextBox ID="Txt_fecha_instalacion" runat="server" CssClass="form-control"
                                                placeholder="DD/MM/YYYY" MaxLength="10"></asp:TextBox>

                                            <%--   </ContentTemplate>
                                            </asp:UpdatePanel>--%>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Observación
                                            </div>

                                            <asp:TextBox ID="Txt_obs_reg" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>

                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <h4>

                                        <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" Visible="False"
                                            CssClass="btn btn-primary" />

                                    </h4>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>



                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>Registro De Productos</strong></div>
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
                                               Nuevo Software

                                            </div>
                                            <asp:TextBox ID="Txt_nuevo_programa" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                           <asp:Button ID="btn_guardar_programa" runat="server" Text="Guardar Software"
                                            CssClass="btn btn-primary" />
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
                                <td style="width: 9%"></td>
                                <td colspan="3" class="auto-style4">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>Filtros de Consulta</strong>
                                    </div>
                                </td>
                                <td style="width: 9%"></td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%"></td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                <asp:RadioButton ID="RdbtnModulo2" GroupName="Seleccion2" runat="server" Text="Modulo" />

                                            </div>
                                            <asp:DropDownList ID="Drl_modulo_2" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnSerial2" GroupName="Seleccion2" runat="server" Text="Serial" />
                                        </div>
                                        <asp:TextBox ID="Txt_serial_Kamilion2" runat="server" CssClass="form-control"></asp:TextBox>
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
                                                <asp:RadioButton ID="RdbtnTipo_Licencia" GroupName="Seleccion2" runat="server" Text="Tipo De Licencia" />

                                            </div>
                                            <asp:DropDownList ID="Drl_tipo_licencia2" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                <asp:RadioButton ID="RdbtnProgramas2" GroupName="Seleccion2" runat="server" Text="Producto" />

                                            </div>
                                            <asp:DropDownList ID="Drl_Programas2" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <h4>
                                        <asp:Button ID="Btn_Buscar1" runat="server" Text="Buscar"
                                            CssClass="btn btn-primary" />
                                        <asp:Button ID="Btn_buscar_todos" runat="server" Text="Buscar Todos"
                                            CssClass="btn btn-primary" />

                                    </h4>
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
                            
                            <tr>
                                <td style="width: 9%"></td>
                                <td colspan="3" class="auto-style4">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                      <strong>  Cargar Excel</strong>

                                    </div>
                                </td>
                                <td style="width: 9%"></td>
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
                                     <div class="form-group">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Adjuntar
                                        </div>
                                        <asp:FileUpload ID="FileArchivo" runat="server" OnClick="btnUpload_Click" width="100%" CssClass="btn btn-primary"/>
                                    </div>
                                </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
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
                                <td style="width: 9%">&nbsp;</td>
                            </tr>


                             <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                             <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">



                                    <div class="input-group">
                                                <div class="input-group-addon">
                                                    Registros encontrados
                                                </div>
                                                <asp:Button ID="BtnVer2" runat="server" Text="Visualizar" CssClass="btn btn-primary"  Visible="true"  />
                                                <asp:Button ID="BtnImportar" runat="server" CssClass="btn btn-primary" Text="Guardar" Visible="true"  />

                                                <asp:Label Style="background-color: inherit" ID="LblCantidad2" runat="server" CssClass="form-control"></asp:Label>
                                            </div>
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
                                <td style="width: 25%"></td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>


                              <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong> Actualizacion de Registros </strong></div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <span class="alert alert-danger">
                                    <asp:Label ID="lblmsg1" runat="server" Style="color: #843534"></asp:Label>
                                </span>
                                <br />
                            </ContentTemplate>
                        </asp:UpdatePanel>
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
                                               Numero de Registro
                                                  <asp:CompareValidator ID="CompareValidator3" runat="server"
                                                    ControlToValidate="Txt_numero_registro" ErrorMessage=""
                                                    Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                            </div>
                                             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                             <ContentTemplate>
                                            <asp:TextBox ID="Txt_numero_registro" enabled ="false"  runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox>
                                            </ContentTemplate>
                                            </asp:UpdatePanel>
                                                    </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                                <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                                <ContentTemplate>
                                         
                                          <asp:Button ID="btn_Actualizar" runat="server"  Text="Actualizar"
                                            CssClass="btn btn-primary" />
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
                                                Producto
                                            </div>
                                                        <asp:UpdatePanel ID="UpdatePane11" runat="server">
                                                <ContentTemplate>
                                            <asp:DropDownList ID="Drl_producto_actualizar"   runat="server" CssClass="form-control"></asp:DropDownList>
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
                                                Version
                                                <asp:CompareValidator ID="CompareValidator4" runat="server"
                                                    ControlToValidate="txt_Version" ErrorMessage=""
                                                    Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                            </div>
                                                        <asp:UpdatePanel ID="UpdatePanel111" runat="server">
                                                <ContentTemplate>
                                            <asp:TextBox ID="Txt_version_actualizar" runat="server" Text=""  CssClass="form-control" MaxLength="20"></asp:TextBox>
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
                                                Tipo De Licencia
                                            </div>
                                                        <asp:UpdatePanel ID="UpdatePanel112" runat="server">
                                                <ContentTemplate>
                                            <asp:DropDownList ID="Drl_tipo_licencia_actualizar"  runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem>EL</asp:ListItem>
                                                <asp:ListItem>SL</asp:ListItem>
                                                <asp:ListItem>EU</asp:ListItem>
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
                                                Serial Del Producto
                                            </div>
                                                        <asp:UpdatePanel ID="UpdatePanel113" runat="server">
                                                <ContentTemplate>
                                            <asp:TextBox ID="Txt_Serial_actualizar" runat="server" Text ="" MaxLength="50" CssClass="form-control"></asp:TextBox>
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
                                                Fecha De Instalacion
                                                   <asp:CompareValidator ID="CompareValidator5" runat="server"
                                                       ControlToValidate="Txt_fecha_actualizar" ErrorMessage="La fecha de ingreso no es válida"
                                                       Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </div>
                                                        <asp:UpdatePanel ID="UpdatePanel114" runat="server">
                                                <ContentTemplate>
                                            <asp:TextBox ID="txt_fecha_actualizar"  runat="server" CssClass="form-control"
                                                placeholder="DD/MM/YYYY" MaxLength="10"></asp:TextBox>
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
                                                Observación
                                            </div>
                                                        <asp:UpdatePanel ID="UpdatePanel115" runat="server">
                                                <ContentTemplate>
                                            <asp:TextBox ID="Txt_Observacion_Actualizar" runat="server"  TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                                        </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
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



                        </table>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>


                  <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent">
                        <div class="bordes">
                         


                           <asp:GridView ID="DtgVisualizar" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                            <Columns>
                                              <%--  <asp:BoundField DataField="Cod_Agente" HeaderText="Agente" />
                                                <asp:BoundField DataField="Fc_Ingreso" HeaderText="Fecha Ingreso" />
                                                <asp:BoundField DataField="Fc_Salida" HeaderText="Fecha Salida" />
                                                <asp:BoundField DataField="Tipo_Horario" HeaderText="Horario" />--%>
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
                    <td class="celdascent">
                        <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
                        <asp:Label ID="Lbl_casos" runat="server" ForeColor="#8F9E45" Text="Productos :"></asp:Label>
                        <asp:Label ID="lblcuenta" runat="server" ForeColor="#8F9E45"></asp:Label>
                        <asp:Label ID="Lbl_Consulta_grid" runat="server" ForeColor="#8F9E45" Visible="false"></asp:Label>
                    &nbsp;&nbsp;
                      <h4>   <asp:Button ID="btn_Exportar" runat="server" CssClass="btn btn-primary" Text="Exportar Excel" />  </h4>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                
               


                    <tr>
                       <td class="celdasder">&nbsp;</td>
                          <td class="celdascent">
                                  
                    
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="10" ForeColor="#333333"
                                GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_Registro_Inventario_Software" HeaderText="No. Registro" />
                                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="Producto" HeaderText="Producto" />
                                    <asp:BoundField DataField="Version_P" HeaderText="Version" />
                                    <asp:BoundField DataField="Tipo_Licencia" HeaderText="Tipo De Licencia" />
                                    <asp:BoundField DataField="Serial_Producto" HeaderText="Serial Del Producto" />
                                    <asp:BoundField DataField="Fecha_Instalacion" HeaderText="Fecha de Instalacion" HtmlEncode="False" DataFormatString="{0:dd/MM/yyyy}" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Serial_Torre" HeaderText="Serial Torre" />
                                    <asp:BoundField DataField="Fk_ID_Modulo" HeaderText="Modulo" />
                                    <asp:ButtonField CommandName="Desinstalar" HeaderText="Desinstalar" ShowHeader="True" Text="Desinstalar" />
                                    <asp:ButtonField CommandName="Editar" HeaderText="Editar" ShowHeader="True" Text="Editar" ButtonType="Button" />
                                </Columns>
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                     
                        </td> 
                         </tr>


                   <tr>
                       <td class="celdasder">&nbsp;</td>
                          <td class="celdascent">
                                  
                       <div class="bordes">
                            <asp:GridView ID="dtggeneral2" runat="server" Visible ="false"
                                AutoGenerateColumns="False" CellPadding="10" ForeColor="#333333"
                                GridLines="None"  Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_Registro_Inventario_Software" HeaderText="No. Registro" />
                                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="Producto" HeaderText="Producto" />
                                    <asp:BoundField DataField="Version_P" HeaderText="Version" />
                                    <asp:BoundField DataField="Tipo_Licencia" HeaderText="Tipo De Licencia" />
                                    <asp:BoundField DataField="Serial_Producto" HeaderText="Serial Del Producto" />
                                    <asp:BoundField DataField="Fecha_Instalacion" HeaderText="Fecha de Instalacion" HtmlEncode="False" DataFormatString="{0:dd/MM/yyyy}" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Serial_Torre" HeaderText="Serial Torre" />
                                    <asp:BoundField DataField="Fk_ID_Modulo" HeaderText="Modulo" />
                               
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
                         </tr>


            </table>
        </div>
    </form>
</body>
</html>
