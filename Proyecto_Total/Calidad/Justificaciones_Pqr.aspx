<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Justificaciones_Pqr.aspx.vb" Inherits="digitacion.Prueba001" %>
<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%--© CDRR--%>
    <title>ERP Kamilion - Justificacion PQR</title>
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
    <script type="text/jscript">
        $(function () {
            $("#txtfcingn3").datepicker({ dateFormat: 'dd/mm/yy' }).val();
            $("#Txt_fc_inicio").datepicker({ dateFormat: 'dd/mm/yy' }).val();
            $("#Txt_fc_fin").datepicker({ dateFormat: 'dd/mm/yy' }).val();
        });
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

        .linkbutton {
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
                        <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Justificacion PQR</em></h4></asp:Label>
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
                    <td class="celdasder">
                        &nbsp;</td>
                    <td class="textotittabla">
                        <table cellpadding="1" cellspacing="1" width="100%">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>Crear Nuevo Caso</strong>
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
                                                Fecha Ingreso Caso
                                             <asp:CompareValidator ID="CompareValidator2" runat="server"
                                                 ControlToValidate="txtfcingn3" ErrorMessage="La fecha de ingreso no es válida"
                                                 Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                            </div>
                                            <asp:TextBox ID="txtfcingn3" runat="server" CssClass="form-control"
                                                placeholder="DD/MM/YYYY" MaxLength="10"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipo De Solicitud                                
                                            </div>
                                            <asp:DropDownList ID="Drl_Tipo_Solicitud" runat="server" CssClass="form-control"></asp:DropDownList>
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
                                                Ingeniero Claro Solicita
                                            </div>
                                            <asp:DropDownList ID="drlingclaro" runat="server" CssClass="form-control"></asp:DropDownList>
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
                                    <h4>&nbsp;<asp:Button ID="btn_crear" runat="server" Text="Guardar" CssClass="btn btn-primary" /></h4>
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
                                                Nuevo Ingeniero
                                            </div>
                                            <asp:TextBox ID="txt_nuevo_ing" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">

                                            <asp:Button ID="btn_nuevo_ing" runat="server" Text="Guardar Ing" CssClass="btn btn-primary" />
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
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>Registro de Seguimiento</strong>
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
                                                Fecha Registro Caso
                                            </div>
                                            <%-- <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                <ContentTemplate>--%>
                                            <asp:Label Style="background-color: inherit" ID="Lbl_fc_ingreso" runat="server" Text="" CssClass="form-control" Enable="False"></asp:Label>
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
                                               Estado
                                            </div>
                                            <%--    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>--%>
                                            <asp:Label Style="background-color: inherit; top: 0px; left: 0px;" ID="lbl_estado" runat="server" CssClass="form-control" Enable="False"></asp:Label>
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
                                                Ingeniero Claro Solicita
                                            </div>
                                            <%--         <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                <ContentTemplate>--%>
                                            <asp:Label Style="background-color: inherit" ID="lbl_ing_r" runat="server" Text="" CssClass="form-control" Enable="False"></asp:Label>
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
                                                Caso
                                            </div>
                                            <%--    <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                <ContentTemplate>--%>
                                            <asp:Label Style="background-color: inherit" ID="Lbl_Caso" runat="server" CssClass="form-control" Enable="False"></asp:Label>
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
                                                Estado Caso
                                            </div>
                                                <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                                <ContentTemplate>
                                            <asp:DropDownList ID="Drl_estado_reg" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
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
                                            <%--  <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                                <ContentTemplate>--%>
                                            <asp:TextBox ID="Txt_obs_reg" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                            <%--  </ContentTemplate>
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
                                                Numero De Solicitudes
                                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txt_Numero_Solic"
                                     ErrorMessage="el numero debe ser mayor a cero" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
                                            </div>

                                                          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                <ContentTemplate>
                                     <asp:TextBox ID="txt_Numero_Solic" runat="server" CssClass="form-control" Style="width: 97%; top: 0px; left: 0px;" MaxLength="6" Enabled="False"></asp:TextBox>&nbsp;
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
                                            Numero De Grabaciones
                                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txt_Numero_grabaciones"
                                                    ErrorMessage="el numero debe ser mayor a cero" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
                                            </div>

                                               <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>

                                      <asp:TextBox ID="txt_Numero_grabaciones" runat="server" CssClass="form-control" Style="width: 97%; top: 0px; left: 0px;" MaxLength="6" Enabled="False"></asp:TextBox>&nbsp;
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
                                                Resultado
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="Drl_Respuesta" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
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
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <h4>
                                        <%--<asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                            <ContentTemplate>--%>
                                        <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" Visible="False"
                                            CssClass="btn btn-primary" />
                                        <%-- </ContentTemplate>
                                        </asp:UpdatePanel>--%>                                        <%--     <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                            <ContentTemplate>--%>
                                       <%-- <asp:Label ID="lbl_estado" runat="server" Visible="False"></asp:Label>--%>
                                        <%--     </ContentTemplate>
                                        </asp:UpdatePanel>--%>
                                    </h4>
                                </td>
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
                                                Caso
										
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
                                                Ingeniero Claro Solicita
                                            </div>
                                            <asp:DropDownList ID="Drl_ing_busca" runat="server" CssClass="form-control"></asp:DropDownList>
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
                                                 ControlToValidate="txtfcingn3" ErrorMessage="La fecha de ingreso no es válida"
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
                                                 ControlToValidate="txtfcingn3" ErrorMessage="La fecha de ingreso no es válida"
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
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Estado Caso
                                            </div>
                                            <asp:DropDownList ID="Drl_Estado_Busca" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Mis Casos
                                            </div>
                                            <%--<asp:Panel ID="Panel1" runat="server" CssClass="form-control">--%>
                                            <asp:CheckBox ID="CheckBox_casos" runat="server" CssClass="form-control" />

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
                                        <asp:Button ID="btn_Exportar" runat="server" Text="Exportar Excel"
                                            CssClass="btn btn-primary" />
                                    </h4>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <asp:Label ID="Lbl_Exportar" runat="server" Visible="False"></asp:Label>
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
                            <%--<tr>
                            <td colspan="5" class="auto-style2"></td>
                        </tr>--%>
                        </table>
                    </td>
                    <td class="celdasder">
                        &nbsp;</td>
                </tr>

                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent">

                        <%-- <h4><em style="color: #8F9E45">Consulta Seguimientos :</em> </h4>--%>                        <%--   <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                            <ContentTemplate>--%>
                        <asp:Label ID="Lbl_consulta_seguimientos" runat="server" Text="Consulta Seguimientos :" ForeColor="#8F9E45"></asp:Label>

                        <asp:Label ID="lblcuenta2" runat="server" ForeColor="#8F9E45"></asp:Label>
                        <%--     </ContentTemplate>
                        </asp:UpdatePanel>--%>

                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent">
                        <div class="bordes">

                            <%--    <asp:UpdatePanel ID="UpdatePanel_drl1" runat="server">
                                <ContentTemplate>--%>

                            <asp:GridView ID="dtg_seguim" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="6" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Id_Historial_Justificacion" HeaderText="Id" />
                                    <asp:BoundField DataField="Id_Caso" HeaderText="Caso" />
                                    <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Registro" />
                                    <%--        <asp:BoundField DataField="Fc_Entrega" HeaderText="Fecha Entrega" />
                                            <asp:BoundField DataField="Fc_Envio" HeaderText="Fecha Envio" />--%>
                                    <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Respuesta" HeaderText="Respuesta" />
                                </Columns>
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>

                            <%--        <asp:BoundField DataField="Fc_Entrega" HeaderText="Fecha Entrega" />
                                            <asp:BoundField DataField="Fc_Envio" HeaderText="Fecha Envio" />--%>
                        </div>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>

                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent">
                        <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
                        <asp:Label ID="Lbl_casos" runat="server" ForeColor="#8F9E45" Text="Casos :"></asp:Label>
                        <asp:Label ID="lblcuenta" runat="server" ForeColor="#8F9E45"></asp:Label>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent">
                        <div class="bordes">

                            <%--<h4><em style="color: #8F9E45">Casos :</em>--%>

                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="15" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Id_Caso" HeaderText="Caso" />
                                    <asp:BoundField DataField="Fc_Ingreso_Caso" HeaderText="Fecha Ingreso Caso" />
                                    <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Registro Caso" />
                                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="Ing_Claro" HeaderText="Ingeniero Claro" />
                                    <asp:BoundField DataField="Tipo_Solicitud" HeaderText="Tipo Solicitud" />
                                    <asp:BoundField DataField="Numero_Solicitudes" HeaderText="N. Solicitudes" />
                                    <asp:BoundField DataField="N_Grabaciones" HeaderText="N. Grabaciones" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Fc_Entrega" HeaderText="Fecha Entrega" />
                                    <asp:BoundField DataField="Fc_Envio" HeaderText="Fecha Envio" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="Respuesta" HeaderText="Respuesta"/>
                                   <%-- <asp:BoundField DataField="Id_Caso" HeaderText="Caso" />
                                    <asp:BoundField DataField="Fecha Registro Caso" HeaderText="Fecha Registro Caso" />
                                    <asp:BoundField DataField="Fecha Ingreso Caso" HeaderText="Fecha Ingreso Caso" />
                                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="Ingeniero Claro" HeaderText="Ingeniero Claro" />
                                    <asp:BoundField DataField="Tipo Solicitud" HeaderText="Tipo Solicitud" />
                                    <asp:BoundField DataField="N. Solicitudes" HeaderText="N. Solicitudes" />
                                    <asp:BoundField DataField="N. Grabaciones" HeaderText="N. Grabaciones" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Fecha Registro Estado" HeaderText="Fecha Registro Estado" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" />--%>
                                <%--    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />--%>
                                    <asp:ButtonField CommandName="Seleccion" HeaderText="Seleccionar" ShowHeader="True" Text="Seleccionar" />
       
                                </Columns>
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>


                            <%--    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>--%>
                        </div>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <%--</ContentTemplate>
                            </asp:UpdatePanel>--%>


                 <asp:Panel ID="Pn_Grid_Exportar" visible ="false" runat="server">
                 <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent">
                        <div class="bordes">

                            <%--<h4><em style="color: #8F9E45">Casos :</em>--%>
                           
                            <asp:GridView ID="dtg_exportar" runat="server" 
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None"  Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                               <%--     <asp:BoundField DataField="Id_Caso" HeaderText="Caso" />
                                    <asp:BoundField DataField="Fecha Registro Caso" HeaderText="Fecha Registro Caso" />
                                    <asp:BoundField DataField="Fecha Ingreso Caso" HeaderText="Fecha Ingreso Caso" />
                                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="Ingeniero Claro" HeaderText="Ingeniero Claro" />
                                    <asp:BoundField DataField="Tipo Solicitud" HeaderText="Tipo Solicitud" />
                                    <asp:BoundField DataField="N. Solicitudes" HeaderText="N. Solicitudes" />
                                    <asp:BoundField DataField="N. Grabaciones" HeaderText="N. Grabaciones" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Fecha Registro Estado" HeaderText="Fecha Registro Estado" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                    --%>
                                    <asp:BoundField DataField="Id_Caso" HeaderText="Caso" />
                                    <asp:BoundField DataField="Fc_Ingreso_Caso" HeaderText="Fecha Ingreso Caso" />
                                    <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Registro Caso" />
                                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="Ing_Claro" HeaderText="Ingeniero Claro" />
                                    <asp:BoundField DataField="Tipo_Solicitud" HeaderText="Tipo Solicitud" />
                                    <asp:BoundField DataField="Numero_Solicitudes" HeaderText="N. Solicitudes" />
                                    <asp:BoundField DataField="N_Grabaciones" HeaderText="N. Grabaciones" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Fc_Entrega" HeaderText="Fecha Entrega" />
                                    <asp:BoundField DataField="Fc_Envio" HeaderText="Fecha Envio" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="Respuesta" HeaderText="Respuesta"/>
       
                                </Columns>
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>

                            

                            <%--    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>--%>
                        </div>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
</asp:Panel>
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
