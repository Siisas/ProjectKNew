<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PerfilamientoCasos.aspx.vb" Inherits="digitacion.PerfilamientoCasos" %>
<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Perfilamiento Casos</title>

    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />

    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
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


        .style1 {
            width: 100%;
            height: 100%;
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
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanle_Tecnologia" runat="server">
            <ContentTemplate>




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
                            <%--<asp:Label ID="lblmsg" runat="server" style="color: #FF3300"></asp:Label>--%>
                        </td>
                        <td class="celdasder">&nbsp;</td>
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
                            <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Perfilamiento Casos</em></h4></asp:Label>

                            <br />
                            <span class="alert alert-danger">
                                <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label></span>
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
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td class="celdasder"></td>
                    </tr>
                    <tr>
                        <td class="celdasder">&nbsp;</td>
                        <td valign="top" class="style3">
                            <table cellpadding="1" cellspacing="1" class="style1">
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="textotittabla">
                                        <table cellpadding="1" cellspacing="1" width="100%">
                                            <tr>
                                                <td style="width: 9%">&nbsp;</td>
                                                <td colspan="3">
                                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                                        <strong>Consulta Caso</strong>
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

                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Caso   
                                                        <asp:CompareValidator ID="CompareValidator2" runat="server"
                                                            ControlToValidate="txtcaso" ErrorMessage="El caso debe ser un valor numérico"
                                                            Operator="DataTypeCheck" Type="Double" ValidationGroup="">*</asp:CompareValidator>
                                                            </div>
                                                            <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <span class="input-group-btn">
                                                                <asp:Button ID="BtnConsulta" runat="server" Text="Consulta" CssClass="btn btn-primary" />
                                                            </span>
                                                        </div>

                                                    </div>
                                                </td>
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
                                                        <strong>Datos caso</strong>
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
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Caso   
                                                        
                                                            </div>
                                                            <asp:TextBox ID="txtcasoasig" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </td>
                                                <td style="width: 5%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Min 
                                                            
                                                            </div>
                                                            <asp:TextBox ID="txtmin" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </td>
                                                <td style="width: 9%">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="width: 9%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Nombre  
                                                            </div>
                                                            <asp:TextBox ID="txtnombre" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </td>
                                                <td style="width: 5%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Documento  
                                                            </div>
                                                            <asp:TextBox ID="txtdocumen" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </td>
                                                <td style="width: 9%">&nbsp;</td>
                                            </tr>

                                            <tr>
                                                <td style="width: 9%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Equipo  
                                                            </div>
                                                            <asp:TextBox ID="txtequipo" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </td>
                                                <td style="width: 5%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Plan  
                                                            </div>
                                                            <asp:TextBox ID="txtplan" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </td>
                                                <td style="width: 9%">&nbsp;</td>
                                            </tr>

                                            <tr>
                                                <td style="width: 9%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Departamento Falla  
                                                            </div>
                                                            <asp:TextBox ID="txtdepar" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </td>
                                                <td style="width: 5%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Correo Electronico  
                                                            </div>
                                                            <asp:TextBox ID="txtcorreo" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </td>
                                                <td style="width: 9%">&nbsp;</td>
                                            </tr>

                                            <tr>
                                                <td style="width: 9%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Estado  
                                                            </div>
                                                            <asp:TextBox ID="txtestado" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </td>
                                                <td style="width: 5%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Observacion  
                                                            </div>
                                                            <asp:TextBox ID="txtobservacion" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </td>
                                                <td style="width: 9%">&nbsp;</td>
                                            </tr>


                                            <tr>
                                                <td style="width: 9%">&nbsp;</td>
                                                <td style="width: 25%">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Fecha Registro  
                                                            </div>
                                                            <asp:TextBox ID="txtfechareg" runat="server" Enabled=" false" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </td>
                                                <td style="width: 5%">&nbsp;</td>
                                                <td style="width: 25%">
                                                 <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Observacion Supervisor  
                                                            </div>

                                                            <asp:TextBox ID="txtarea" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                                           
                                                        </div>
                                                    </div>
                                                
                                                
                                                </td>
                                                <td style="width: 9%">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="width: 9%">&nbsp;</td>
                                                <td style="width: 25%">

                                                    <asp:Button ID="btnAprobar" runat="server" Text="Aprobar" CssClass="btn btn-primary" />
                                                    <asp:Button ID="btnQuitar" runat="server" Text="Limpiar" CssClass="btn btn-primary" />


                                                </td>
                                                <td style="width: 5%">&nbsp;</td>
                                                <td style="width: 25%">&nbsp;</td>
                                                <td style="width: 9%">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>

                            </table>
                        </td>
                        <td class="celdasder">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="celdasder">&nbsp;</td>
                        <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;"
                            valign="top" class="style3">&nbsp;</td>
                        <td class="celdasder">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="celdasder">&nbsp;</td>
                        <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;"
                            valign="top" class="style3"></td>
                        <td class="celdasder">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="celdasder">&nbsp;</td>
                        <td class="celdascent">
                            <h4 style="color: #8F9E45"><em>Casos Aprobados: </em>
                                &nbsp;<asp:Label ID="lblcasosApro" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;</h4>
                        </td>
                        <td class="celdasder">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="celdasder">&nbsp;</td>
                        <td class="celdascent">
                            <div class="bordes">
                                <asp:GridView ID="dtgCasosApro" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="15" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />

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
                            <h4 style="color: #8F9E45"><em>Gestiones: </em>
                                &nbsp;<asp:Label ID="lblcuentacasos" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;</h4>
                        </td>
                        <td class="celdasder">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="celdasder">&nbsp;</td>
                        <td class="celdascent">
                            <div class="bordes">
                                <asp:GridView ID="dtgcasos" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True" AutoGenerateColumns="False">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="idcrm" HeaderText="ID" />
                                        <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                                        <asp:BoundField DataField="min_ac" HeaderText="Min" />
                                        <asp:BoundField DataField="fcreg" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                                        <asp:BoundField DataField="obs" HeaderText="Observación" />
                                        <asp:BoundField DataField="tipo_soporte" HeaderText="Tipo Soporte" />
                                        <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                                        <asp:BoundField DataField="fcprogram" HeaderText="Fecha Programación" />
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

            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server"
            ShowMessageBox="True" />
    </form>
</body>
</html>



