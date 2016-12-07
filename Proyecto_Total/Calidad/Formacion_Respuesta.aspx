<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Formacion_Respuesta.aspx.vb" Inherits="digitacion.Formacion_Respuesta" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <%--© CDRR--%>
    <title>ERP Kamilion - Formacion</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <%-- Colocar como comentario para ver correctamente la vista diseño--%>
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
            $_$("#Txt_fc_inicio").datepicker({ dateFormat: 'dd/mm/yy' }).val();/*Fecha*/
            $_$("#Txt_fc_fin").datepicker({ dateFormat: 'dd/mm/yy' }).val();/*Fecha*/

        }
    </script>

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

        .linkbutton {
            color: #B3C556;
            text-decoration: none;
        }

            .linkbutton:hover {
                color: #555555;
                text-decoration: solid;
                text-decoration-color: #fff;
            }

        .form-control {
            top: 0px;
            left: 0px;
        }

        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
            height: 99px;
        }

        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
            height: 99px;
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
                        <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Respuesta Formacion</em></h4></asp:Label>
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
                                                Numero Solicitud
										
                                   <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtcaso"
                                       ErrorMessage="el numero debe ser mayor a cero" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>

                                            </div>
                                            <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Prioridad
                                            </div>
                                            <asp:DropDownList ID="Drl_Prioridad" runat="server" CssClass="form-control"></asp:DropDownList>
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
                                                Fecha Registro Desde
                                             <asp:CompareValidator ID="CompareValidator3" runat="server"
                                                 ControlToValidate="Txt_fc_inicio" ErrorMessage="La fecha de ingreso no es válida"
                                                 Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </div>
                                            <asp:TextBox ID="Txt_fc_inicio" runat="server" CssClass="form-control"
                                                placeholder="DD/MM/YYYY" MaxLength="10"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Fecha Registro Hasta
                                             <asp:CompareValidator ID="CompareValidator4" runat="server"
                                                 ControlToValidate="Txt_fc_fin" ErrorMessage="La fecha de ingreso no es válida"
                                                 Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </div>
                                            <asp:TextBox ID="Txt_fc_fin" runat="server" CssClass="form-control"
                                                placeholder="DD/MM/YYYY" MaxLength="10"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <h4>
                                        <asp:Button ID="Btn_Buscar" runat="server" Text="Buscar"
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
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>Respuesta Formacion</strong>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <asp:Label ID="Lbl_estado" runat="server" Visible="false" Text=""></asp:Label>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <asp:Label ID="Lbl_Cod_Respuesta" runat="server" Visible="false" Text=""></asp:Label>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%"></td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Numero Solicitud
                                            </div>
                                            <asp:TextBox ID="Txt_id_cargue" runat="server" CssClass="form-control" MaxLength="10" Enabled="False"></asp:TextBox>


                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Area Solicitante
                                            </div>
                                            <asp:TextBox ID="Txt_tipo_Solicitud_Cargue" runat="server" CssClass="form-control" MaxLength="10" Enabled="False"></asp:TextBox>
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
                                                Grupo                        
                                            </div>
                                            <asp:TextBox ID="Txt_Grupo" runat="server" CssClass="form-control" Enabled="False" MaxLength="10"></asp:TextBox>
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
                                            <asp:TextBox ID="Txt_Modulo" runat="server" CssClass="form-control" Enabled="False" MaxLength="10"></asp:TextBox>
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
                                                Estado                                
                                            </div>
                                            <asp:DropDownList ID="Drl_Estado" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Observacion
                                            
                                            </div>
                                            <asp:TextBox ID="Txt_Observacion" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            


                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <h4>
                                        <%--<asp:Button ID="btn_Guardar" runat="server" Text="Guardar" CssClass="btn btn-primary" />--%>

                        <asp:ImageButton ID="btn_Guardar" runat="server" Height="57px"
                        ImageUrl="~/Css2/Imagenes/Nuevo.png" Width="60px"
                        AlternateText="Guardar" title="Guardar"/>

                                    </h4>
                                </td>
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
                    <td class="textotittabla">
                        <table cellpadding="1" cellspacing="1" width="100%">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                     <asp:Label ID="Lbl_consulta_seguimientos" runat="server" Text="Consulta Seguimientos :" ForeColor="#8F9E45"></asp:Label>

                        <asp:Label ID="lblcuenta2" runat="server" ForeColor="#8F9E45"></asp:Label>
                                </td>
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

                        <center>
                            <div class="bordes">
                            <div class="input-group">

                                <asp:Panel ID="Pnl_cabecera_1" Visible="false" runat="server">

                                    <div style="background-color: #B3C556; height: 40px; width: 100%; margin: 0; padding: 0">
                                        <table id="Table1"
                                            style="font-family: Arial; font-size: 10pt; width: 100%; color: white; height: 100%;">
                                            <tr>
                                                <td style="width:  12.5%; text-align: left">ID</td>
                                                <td style="width:  12.5%; text-align: left">Numero Solicitud</td>
                                                <td style="width:  12.5%; text-align: left">Grupo</td>
                                                <td style="width:  12.5%; text-align: left">Modulo</td>
                                                <td style="width:  12.5%; text-align: left">Usuario</td>
                                                <td style="width:  12.5%; text-align: left">Fecha Registro</td>
                                                <td style="width:  12.5%; text-align: left">Estado</td>
                                                <td style="width:  12.5%; text-align: left">Observacion</td>
                                            </tr>
                                        </table>
                                    </div>

                                </asp:Panel>

                                <div style="overflow: auto; width: 100%; height: 110px;">
                                    <asp:GridView ID="dtg_seguim" runat="server"
                                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" ShowHeader="false"
                                        GridLines="None" PageSize="6" Width="100%" Style="font-size: x-small"
                                        EnableModelValidation="True">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField ItemStyle-Width=" 12.5%" DataField="id_Respuesta_Formacion" HeaderText="ID" />
                                            <asp:BoundField ItemStyle-Width=" 12.5%" DataField="Id_Solicitud_Formacion" HeaderText="Caso" />
                                            <asp:BoundField ItemStyle-Width=" 12.5%" DataField="Grupo" HeaderText="Grupo" />
                                            <asp:BoundField ItemStyle-Width=" 12.5%" DataField="Modulo" HeaderText="Modulo" />
                                            <asp:BoundField ItemStyle-Width=" 12.5%" DataField="Id_Usuario" HeaderText="Usuario" />
                                            <asp:BoundField ItemStyle-Width=" 12.5%" DataField="Fc_Reg" HeaderText="Fecha Registro" />
                                            <asp:BoundField ItemStyle-Width=" 12.5%" DataField="Estado" HeaderText="Estado" />
                                            <asp:BoundField ItemStyle-Width=" 12.5%" DataField="Observacion" HeaderText="Observacion" />

                                        </Columns>
                                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>

                                </div>
                            </div>
                                  </div>
                        </center>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent">&nbsp;</td>
                    <td class="celdasder">&nbsp;</td>
                </tr>

                                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="textotittabla">
                        <table cellpadding="1" cellspacing="1" width="100%">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                     <asp:Label ID="Lbl_casos" runat="server" ForeColor="#8F9E45" Text="Solicitudes:"></asp:Label>
                        <asp:Label ID="lblcuenta" runat="server" ForeColor="#8F9E45"></asp:Label>
                                </td>
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
                    <td style="width: 33%">
                      <div class="bordes">
                            <div class="input-group">
                                <asp:Panel ID="Pnl_cabecera_2" Visible="false" runat="server" style="margin-bottom: 0px">
                                    <div style="background-color: #B3C556; height: 50px; width: 100%; margin: 0; padding: 0">
                                        <table id="tblHeader"
                                            style="font-family: Arial; font-size: 10pt; width: 100%; color: white; height: 100%;">
                                            <tr>
                                                <td style="width: 7.14%; text-align: left">ID</td>
                                                <td style="width: 7.14%; text-align: left">ID Formacion</td>
                                                <td style="width: 7.14%; text-align: left">Grupo</td>
                                                <td style="width: 7.14%; text-align: left">Modulo</td>
                                                <td style="width: 7.14%; text-align: left">N Personas a capacitar</td>
                                                <td style="width: 7.14%; text-align: left">Fecha</td>
                                                <td style="width: 7.14%; text-align: left">Formador</td>
                                                <td style="width: 7.14%; text-align: left">Tipo Formacion</td>
                                                <td style="width: 7.14%; text-align: left">Prioridad</td>
                                                <td style="width: 7.14%; text-align: left">Tema</td>
                                                <td style="width: 7.14%; text-align: left">Area Solicita</td>
                                                <td style="width: 7.14%; text-align: left">Lugar</td>
                                                <td style="width: 7.14%; text-align: left">Estado General</td>
                                                <td style="width: 7.14%; text-align: left">Estado Modulo</td>

                                     
                                            
                                         


                                             <%--   <td style="width: 7.6%; text-align: left">Formador</td>--%>
                                                <td style="width: 7.14%; text-align: left">Seleccionar</td>
                                            </tr>
                                        </table>
                                    </div>
                                </asp:Panel>
                                <div style="overflow: auto; width: 100%; height: 400px;">
                                    <asp:GridView ID="dtggeneral" runat="server" ShowHeader="false"
                                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                        GridLines="None" PageSize="15" Width="100%" Style="font-size: x-small"
                                        EnableModelValidation="True">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="ID_Formaciones" HeaderText="ID" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="ID_Formacion" HeaderText="ID_Formacion" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Grupo" HeaderText="Grupo" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Modulo" HeaderText="Modulo" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="N_Personas" HeaderText="N_Personas" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Fecha" HeaderText="Fecha" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="formador" HeaderText="formador" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Tipo_Formacion" HeaderText="Tipo_Formacion" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Prioridad" HeaderText="Prioridad" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Tema" HeaderText="Tema" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Area_Solicita" HeaderText="Area_Solicita" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Lugar" HeaderText="Lugar" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Estado_SF" HeaderText="Estado_SF" />
                                            <asp:BoundField ItemStyle-Width="7.14%" DataField="Estado" HeaderText="Estado" />
                                            <%-- <asp:BoundField ItemStyle-Width="7.6%" DataField="Formador" HeaderText="Formador" />--%>
                                            <asp:ButtonField ItemStyle-Width="7.14%" CommandName="Seleccion" HeaderText="Seleccionar" ShowHeader="True" Text="Seleccionar" />
                                        </Columns>
                                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                                </div>
                            </div>
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
        </div>
    </form>
</body>
</html>
