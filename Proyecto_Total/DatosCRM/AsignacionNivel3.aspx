<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AsignacionNivel3.aspx.vb" Inherits="digitacion.AsignacionNivel3" %>
<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link rel="icon" href="../favicon.ico" type="image/x-icon"/>
    <title>ERP Kamilion</title>
    <link href="../Css2/jquery-ui.css" rel="stylesheet" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
    <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
<style type="text/css">
        @font-face {
            font-family: FuenteKamilion;
            src: url(../Css2/Boot/fonts/NEUROPOL.ttf);
        }

       .bordes {
            /*border: 1px solid black;*/
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            overflow: hidden;
        }

        .zoom {
            transition: 2s ease;
            -moz-transition: 2s ease; /* Firefox */
            -webkit-transition: 2s ease; /* Chrome - Safari */
            -o-transition: 2s ease; /* Opera */
        }

            .zoom:hover {
                transform: scale(2) rotate(20deg);
                -moz-transform: scale(2) rotate(20deg); /* Firefox */
                -webkit-transform: scale(2) rotate(20deg); /* Chrome - Safari */
                -o-transform: scale(2) rotate(20deg); /* Opera */
                -ms-transform: scale(2) rotate(20deg); /* IE9 */
            }


        body {
            background-color: #eee;
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

        .titulo {
            transition: 2s ease;
            color: #B3C556;
            text-shadow: -2px -2px 1px #000;
        }

            .titulo:hover {
                color: #B3C556;
                text-shadow: -2px -2px 1px #fff;
            }


        .style2 {
            width: 100%;
        }


        .celdascons {
            width: 35%;
        }



        .style3 {
            /*color: #000099;*/
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

        .file_input_textbox {
            float: left;
        }

        .file_input_div {
            position: relative;
            width: 100px;
            height: 23px;
            overflow: hidden;
        }

        .file_input_button {
            width: 100px;
            position: absolute;
            top: 0px;
            background-color: #33BB00;
            color: #FFFFFF;
            border-style: solid;
        }

        .file_input_hidden {
            font-size: 45px;
            position: absolute;
            right: 0px;
            top: 0px;
            opacity: 0;
            filter: alpha(opacity=0);
            -ms-filter: "alpha(opacity=0)";
            -khtml-opacity: 0;
            -moz-opacity: 0;
        }

        .auto-style1 {
            width: 9%;
            height: 27px;
        }

        .auto-style2 {
            height: 27px;
        }

        .auto-style3 {
            width: 9%;
            height: 25px;
        }

        .auto-style4 {
            width: 25%;
            height: 25px;
        }

        .auto-style5 {
            width: 5%;
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
                    <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Asignacion Casos Nivel 3</em></h4></asp:Label>
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
                <span class="alert alert-danger" ><asp:Label ID="lblmsg" runat="server" style="color: #843534"></asp:Label></span><br />&nbsp;
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <div>
                </div>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;" valign="top" class="style3">
                    <table cellpadding="1" cellspacing="1" width="100%">
                        <tr>
                            <td class="auto-style1"></td>
                            <td colspan="3" class="auto-style2">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>Asignacion Casos Nivel 3</strong>
                                </div>
                            </td>
                            <td class="auto-style1"></td>
                        </tr>
                        <tr>
                                        <td class="auto-style3"></td>
                                        <td class="auto-style4"></td>
                                        <td class="auto-style5"></td>
                                        <td class="auto-style4"></td>
                                        <td class="auto-style3"></td>
                                    </tr>
                        <tr>
                                        <td class="auto-style3"></td>
                                        <td class="auto-style4">
                                              <asp:Button ID="BtnBuscar" runat="server" Text="Buscar"  CssClass="btn btn-primary"/>
                                              <asp:Button ID="BtnGuardar" runat="server" Text="Guardar"  CssClass="btn btn-primary"/>
                                        </td>
                                        <td class="auto-style5"></td>
                                        <td class="auto-style4"></td>
                                        <td class="auto-style3"></td>
                                    </tr>

                        <tr>
                            <td class="auto-style3"></td>
                            <td class="auto-style4"> 
                                <div class="form-group">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                           Ingeniero Nivel 3
                                        </div>
                                       <asp:DropDownList ID="drlIngeniero" runat="server" CssClass="form-control" AutoPostBack="True">
                                    
                                </asp:DropDownList>
                                    </div>
                                </div>

                            </td>
                            <td class="auto-style5"></td>
                            <td class="auto-style4"></td>
                            <td class="auto-style3"></td>
                        </tr>
                         <tr>
                            <td class="auto-style3"></td>
                            <td class="auto-style4">
                           <div class="form-group">
                             <div class="input-group">
                                        <div class="input-group-addon">
                                        Asignar caso individual 
                                        </div>
                                       <asp:TextBox ID="txtcaso" CssClass="form-control" runat="server"></asp:TextBox>
                                                
                                    </div>
                                </div>


                            </td>
                            <td class="auto-style5"></td>
                            <td class="auto-style4"></td>
                            <td class="auto-style3"></td>
                        </tr>
                         <tr>
                            <td class="auto-style3"></td>
                            <td class="auto-style4">
                                <div class="form-group">
                                  <div class="form-group">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                   Casos pendientes a asignar
                                    </div>
                                    <asp:Label style="background-color: inherit" ID="lblCantidad" runat="server" CssClass="form-control"></asp:Label>
                                </div></div>


                            </td>
                            <td class="auto-style5"></td>
                            <td class="auto-style4"></td>
                            <td class="auto-style3"></td>
                             </tr>

                         <tr>
                            <td class="auto-style3"></td>
                            <td class="auto-style4">
                           <div class="form-group">
                             <div class="input-group">
                                        <div class="input-group-addon">
                                       Cantidad de casos a asignar 
                                        </div>
                                       <asp:TextBox ID="TxtCantidad" CssClass="form-control" runat="server"></asp:TextBox>
                                                
                                    </div>
                                </div>


                            </td>
                            <td class="auto-style5"></td>
                            <td class="auto-style4"></td>
                            <td class="auto-style3"></td>
                        </tr>
                        
                         <tr>
                                        <td class="auto-style3"></td>
                                        <td class="auto-style4">
                                            <asp:GridView ID="DtgAsigado" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True" AutoGenerateColumns="False">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                            <Columns>
                                                <asp:BoundField DataField="ID_USUARIO_ASIGNADO" HeaderText="Ing. Nivel 3" />
                                                <asp:BoundField DataField="casos" HeaderText="casos" />
                                             </Columns>
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>

                                        </td>
                                        <td class="auto-style5"></td>
                                        <td class="auto-style4"></td>
                                        <td class="auto-style3"></td>
                                    </tr>
                       
                        <tr>
                            <td style="width: 9%">&nbsp;</td>
                            <td colspan="3">

                                <table cellpadding="1" cellspacing="1" width="100%">
                                    <tr>
                                        <td class="auto-style3"></td>
                                        <td class="auto-style4"></td>
                                        <td class="auto-style5"></td>
                                        <td class="auto-style4"></td>
                                        <td class="auto-style3"></td>
                                    </tr>

                                   
                                    <tr>
                                        <asp:GridView ID="DtgVisualizar" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True" AutoGenerateColumns="False">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                            <Columns>
                                                <asp:BoundField DataField="Id_Caso" HeaderText="Caso" />
                                                  <asp:BoundField DataField="cas_fecha_registro" HeaderText="Fecha Ingreso" />
                                                <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Reporte" />
                                                <asp:BoundField DataField="Id_Usuario" HeaderText="Agente Reporta" />

                                                <asp:BoundField DataField="bandeja" HeaderText="Campaña" />

                                            </Columns>
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>

                                    </tr>
                                </table>
                            </td>
                            <td style="width: 9%">&nbsp;</td>

                        </tr>
                    </table>
                </td>
                <td style="width: 9%">&nbsp;</td>

            </tr>

        </table>


        
      

    </form>
</body>
</html>



