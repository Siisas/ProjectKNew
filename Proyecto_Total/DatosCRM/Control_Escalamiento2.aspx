<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Control_Escalamiento2.aspx.vb" Inherits="digitacion.Control_Escalamiento2" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <%--© CDRR--%>
    <title>ERP Kamilion - Control Escalamiento</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <%-- Colocar como comentario para ver correctamente la vista diseño--%>
    <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
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
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            
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
                        <uc1:menu ID="menu1" runat="server" />
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="style4">
                        <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Control Escalamiento</em></h4></asp:Label>
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
                                        <strong>Control Escalamiento</strong>
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
                                               
                                                Tipo Escalamiento 
                                           
                                            </div>
                                            <asp:DropDownList ID="Drl_tipo_escalamiento" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="- Seleccione -"></asp:ListItem>
                                                <asp:ListItem Value="Informatica">Informatica</asp:ListItem>
                                                <%--<asp:ListItem>Informatica - Voz</asp:ListItem>--%>
                                                <asp:ListItem Value="Tecnica"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Casos a Asignar
                                                  <asp:CompareValidator
                                                      ID="CompareValidator1" runat="server"
                                                      ControlToValidate="Txt_Numero_casos" ErrorMessage="El caso debe ser numérico"
                                                      Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>

                                            </div>
                                            <asp:TextBox ID="Txt_Numero_casos" runat="server" CssClass="form-control" MaxLength="5"></asp:TextBox>
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
                                                 <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                    <ContentTemplate>
                                              <asp:CheckBox ID="Chk_estado" AutoPostBack="True" runat="server" /> Estado Escalado            
                                                    </ContentTemplate> 
                                                     </asp:UpdatePanel> 
                                            </div>
                                            <asp:DropDownList ID="drl_Estado_Claro" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>


                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                    <ContentTemplate>
                                                        <asp:CheckBox ID="Chk_caso" AutoPostBack="True" runat="server" />
                                                        Caso 
                                                       <asp:CompareValidator
                                                           ID="CompareValidator5" runat="server"
                                                           ControlToValidate="Txt_Caso" ErrorMessage="El caso debe ser numérico"
                                                           Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>

                                            </div>
                                            <asp:TextBox ID="Txt_Caso" runat="server" CssClass="form-control" MaxLength="15"></asp:TextBox>
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
                                                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                    <ContentTemplate>
                                                        <asp:CheckBox ID="Chk_fecha_desde" AutoPostBack="True" runat="server" />
                                                        Fecha Desde
                                                    <asp:CompareValidator ID="CompareValidator3" runat="server"
                                                        ControlToValidate="Txt_fc_inicio" ErrorMessage="La fecha de ingreso no es válida"
                                                        Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
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
                                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                    <ContentTemplate>
                                                        <asp:CheckBox ID="Chk_fecha_hasta" AutoPostBack="True" runat="server" />
                                                        Fecha Hasta
                                                <asp:CompareValidator ID="CompareValidator4" runat="server"
                                                    ControlToValidate="Txt_fc_fin" ErrorMessage="La fecha de ingreso no es válida"
                                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
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
                                                <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                    <ContentTemplate>
                                                        <asp:CheckBox ID="Chk_Ing" AutoPostBack="True" runat="server" />
                                                      Ingeniero
                                                    
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </div>
                                             <asp:DropDownList ID="Drl_ing_consulta" CssClass="form-control" runat="server">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <h4>
                                        <asp:Button ID="btn_Buscar" runat="server" CssClass="btn btn-primary" Text="Buscar" /></h4>
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
                                                Asignar a
                                            </div>
                                            <asp:DropDownList ID="drlingclaro" CssClass="form-control" runat="server">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">

                                            <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" CssClass="btn btn-primary" />
                                            <asp:Label ID="lbl_control" runat="server" Visible="false" Text=""></asp:Label>
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
                                <td style="width: 9%"></td>
                                <td colspan="3" class="auto-style4">
                                    <div class="text-center" style="background-color: #B3C556; color: #B3C556; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>.</strong>
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

                        </table>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>

                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="textotittabla">
                        <table cellpadding="1" cellspacing="1" width="100%">

                            <tr>
                                <td style="width: 33%">
                                    <asp:Label ID="Label4" Text="Casos encontrados: " ForeColor="#8F9E45" runat="server"></asp:Label>
                                    <asp:Label ID="Lbl_cuenta_3" runat="server" ForeColor="#8F9E45"></asp:Label>
                                    <asp:Button ID="btn_liberar" runat="server" Text="Liberar" CssClass="btn btn-primary" />
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 33%"></td>

                            </tr>
                            <tr>
                                <td style="width: 33%">
                                    <div>
                                        <div class="input-group">

                                            <div style="overflow: auto; width: 600px; height: 227px;">
                                                <asp:GridView ID="dtg_Asignar" runat="server" AllowPaging="false" AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333" GridLines="None" Style="font-size: x-small" Width="100%">
                                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                    <Columns>
                                                    </Columns>
                                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                                    <EditRowStyle BackColor="#999999" />
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                                                </asp:GridView>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 33%">


                                    <table cellpadding="1" cellspacing="1" width="100%">

                                        <tr>

                                            <td style="width: 290px"><%-- division--%>

                                                <div style="width: 290px;">
                                                    <div style="background-color: #B3C556; height: 30px; width: 290px; margin: 0; padding: 0">
                                                        <table id="Table2"
                                                            style="font-family: Arial; font-size: 10pt; width: 290px; color: white; height: 100%;">
                                                            <tr>
                                                                <td style="width: 200px; text-align: left">Ing Soporte</td>
                                                                <td style="width: 90px; text-align: left">Casos CPD</td>

                                                            </tr>
                                                        </table>
                                                    </div>
                                                    <div style="overflow: auto; width: 290px; height: 200px;">
                                                        <asp:GridView ID="dtg_Asignados" runat="server" ShowHeader="false" AllowPaging="false" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" Style="font-size: x-small" Width="100%">
                                                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                            <Columns>
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="Ing Soporte" HeaderText="Ing Soporte" />
                                                                <asp:BoundField ItemStyle-Width="90px" DataField="casos" HeaderText="casos CPD" />
                                                            </Columns>
                                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                                            <EditRowStyle BackColor="#999999" />
                                                            <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                                                        </asp:GridView>
                                                    </div>
                                                </div>
                                            </td>

                                            <td style="width: 20px"></td>


                                            <td style="width: 290px"><%-- division--%>
                                                <div style="width: 250px;">
                                                    <div style="background-color: #B3C556; height: 30px; width: 290px; margin: 0; padding: 0">
                                                        <table id="Table3"
                                                            style="font-family: Arial; font-size: 10pt; width: 290px; color: white; height: 100%;">
                                                            <tr>
                                                                <td style="width: 200px; text-align: left">Ing Soporte</td>
                                                                <td style="width: 90px; text-align: left">Casos SD</td>

                                                            </tr>
                                                        </table>
                                                    </div>
                                                    <div style="overflow: auto; width: 290px; height: 200px;">
                                                        <asp:GridView ID="dtg_asignados_sd" runat="server" ShowHeader="false" AllowPaging="false" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" Style="font-size: x-small" Width="100%">
                                                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                            <Columns>
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="Ing Soporte" HeaderText="Ing Soporte" />
                                                                <asp:BoundField ItemStyle-Width="90px" DataField="casos" HeaderText="casos SD" />
                                                            </Columns>
                                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                                            <EditRowStyle BackColor="#999999" />
                                                            <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                                                        </asp:GridView>
                                                    </div>
                                                </div>
                                            </td>

                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 33%"></td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 33%"></td>
                            </tr>
                            <tr>
                                <td style="width: 33%">
                                    <asp:Label ID="Label5" Text="Casos Con CPD (Tecnica) Encontrados: " ForeColor="#8F9E45" runat="server"></asp:Label>
                                    <asp:Label ID="lblcuenta" runat="server" ForeColor="#8F9E45"></asp:Label>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 33%">
                                    <asp:Label ID="Label3" Text="Casos Con SD (Informatica) Encontrados: " ForeColor="#8F9E45" runat="server"></asp:Label>
                                    <asp:Label ID="lblcuenta1" ForeColor="#8F9E45" runat="server"></asp:Label>
                                </td>
                            </tr>

                            <tr>
                                <td style="width: 33%">
                                    <div>
                                        <div class="input-group">

                                            <div style="background-color: #B3C556; height: 40px; width: 600px; margin: 0; padding: 0">

                                                <table id="tblHeader"
                                                    style="font-family: Arial; font-size: 10pt; width: 600px; color: white; height: 100%;">
                                                    <tr>
                                                        <td style="width: 100px; text-align: left">Caso</td>
                                                        <td style="width: 100px; text-align: left">CPD</td>
                                                        <td style="width: 100px; text-align: left">Estado CPD</td>
                                                        <td style="width: 100px; text-align: left">Fecha Registro</td>
                                                        <td style="width: 80px; text-align: left">Fecha SAP</td>
                                                        <td style="width: 100px; text-align: left">Usuario Asignado</td>
                                                          <td style="width: 80px; text-align: left">Bandeja</td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div style="overflow: auto; width: 600px; height: 400px;">
                                                <asp:GridView ID="dtggeneral" runat="server" AutoGenerateColumns="False"
                                                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" ShowHeader="false"
                                                    Style="font-size: x-small" EnableModelValidation="True">
                                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                    <Columns>
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="idcaso" HeaderText="Caso" />
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="cpd" HeaderText="CPD" />
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="estadocpd" HeaderText="Estado CPD" />
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="Fecha Registro" HeaderText="Fecha Registro" />
                                                        <asp:BoundField ItemStyle-Width="80px" DataField="Fecha SAP" HeaderText="Fecha SAP" DataFormatString="{0:dd/MM/yyyy}" />
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="idusuriocpd" HeaderText="usuario asignado" />
                                                         <asp:BoundField ItemStyle-Width="80px" DataField="Bandeja" HeaderText="Bandeja" />

                                                    </Columns>
                                                    <EmptyDataTemplate>
                                                     
                                                    </EmptyDataTemplate>
                                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                                    <EditRowStyle BackColor="#999999" />
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                                                </asp:GridView>
                                            </div>

                                        </div>
                                    </div>

                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 33%">
                                    <div>
                                        <div class="input-group">

                                            <div style="background-color: #B3C556; height: 40px; width: 600px; margin: 0; padding: 0">
                                                <table id="Table1"
                                                    style="font-family: Arial; font-size: 10pt; width: 600px; color: white; height: 100%;">
                                                    <tr>
                                                        <td style="width: 100px; text-align: left">Caso</td>
                                                        <td style="width: 100px; text-align: left">SD</td>
                                                        <td style="width: 100px; text-align: left">Estado SD</td>
                                                        <td style="width: 100px; text-align: left">Fecha Registro</td>
                                                        <td style="width: 80px; text-align: left">Fecha SAP</td>
                                                        <td style="width: 100px; text-align: left">Usuario Asignado</td>
                                                        <td style="width: 80px; text-align: left">Bandeja</td>
                                                    </tr>
                                                </table>
                                            </div>


                                            <div style="overflow: auto; width: 600px; height: 400px;">
                                                <asp:GridView ID="dtggeneral2" runat="server" AllowPaging="false" AutoGenerateColumns="False" ShowHeader="false"
                                                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%"
                                                    Style="font-size: x-small">
                                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                    <Columns>
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="idcaso" HeaderText="Caso" />
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="tickler" HeaderText="SD" />
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="estado" HeaderText="Estado SD" />
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="Fecha Registro" HeaderText="Fecha Registro" />
                                                        <asp:BoundField ItemStyle-Width="80px" DataField="Fecha SAP" HeaderText="Fecha SAP" DataFormatString="{0:dd/MM/yyyy}" />
                                                        <asp:BoundField ItemStyle-Width="100px" DataField="idusuarioserv" HeaderText="Usuario Asignado" />
                                                               <asp:BoundField ItemStyle-Width="80px" DataField="Bandeja" HeaderText="Bandeja" />
                                                        <%--           <asp:BoundField DataField="idusuarioasigna" HeaderText="Backoffice" />--%>
                                                    </Columns>
                                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                                    <EditRowStyle BackColor="#999999" />
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                                                </asp:GridView>
                                            </div>


                                        </div>
                                    </div>
                                </td>


                            </tr>


                        </table>
                    </td>

                    <td class="celdasder">&nbsp;</td>
                </tr>




            </table>
        </div>
    </form>
</body>
</html>
