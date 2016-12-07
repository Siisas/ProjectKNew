<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Productividad.aspx.vb" Inherits="digitacion.Productividad1" %>
<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link rel="icon" href="../favicon.ico" type="image/x-icon"/>
    <title>ERP Kamilion</title>
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/jscript">
        var $_$ = jQuery.noConflict();
        function pageLoad() {
            $_$(".Fecha").datepicker({}).val();
            $_$('.Desplegar').click(function () { Desplegar() });
            $_$().bind('keydown', function (e) {
                if (e.which == 27) {
                    if ($_$("#Desplegable").is(":visible")) {
                        $_$("#Desplegable").hide("puff", 500, "swing")
                    }
                }
            });
        }
        function Plegar() {
            $_$("#Desplegable").hide("puff", 500, "swing")
        };
        function Desplegar() {
            $_$("#Desplegable").show("puff", 500, "swing")
        };
    </script>
    <!-- Fin Script jQuery Datepicker --->
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
     <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="../Css2/Maquetacion.css" />
    <style type="text/css">
             #Desplegable {
            display: none;
            background-color : rgba(0, 0, 0, 0.50);
            background-size: 10px, 10px;
            width: 100%;
            height: 100%;
            position: fixed;
            left: 0px;
            top: 0px;
            right: 0px;
            bottom: 0px;
            z-index: 10;
        }
    </style>
</head>
<body>
    <div id="Desplegable">
            <div style="margin:auto; position:relative; padding-top:20%; width:50px; height:50px;">
                <asp:Image ID="GIF" runat="server" ImageUrl="../Css2/Imagenes/Loading_6.gif" />
            </div>
    </div>
    <script type="text/javascript">
        $_$("#Desplegable").show("puff", 500, "swing");
    </script>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
                <ContentTemplate>                
                <header>
                    <h1 class="text-center" style="font-family: FuenteKamilion">
                        <span style="font-size: 110%">Kamilion Comunicaciones ERP</span>
                    </h1>
                </header>
                <nav>
                    <center>
                        <uc1:menu ID="menu" runat="server" />
                    </center>
                </nav>
                <article>
                    <section class="profile">
                        <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Productividad Diaria</em></h4></asp:Label>
                    </section>
                    <section class="profile">
                        <asp:Label ID="lblusuario" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblcod" Style="margin-right: 3%" runat="server"></asp:Label>
                        <asp:Label ID="lblnombreusu" Style="margin-right: 6%" runat="server"></asp:Label>
                        <asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#8F9E45"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label>&nbsp;&nbsp;
                        <asp:Label ID="LblSupervisor" runat="server"></asp:Label>
                    </section>
                    <section class="profile" style="width:60%">
                        <span class="alert alert-danger">
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </span>
                        <span class="alert alert-success">
                            <asp:Label ID="lblmsgg" runat="server"></asp:Label>
                        </span>
                    </section>
                </article>
              <%--  </ContentTemplate>
                </asp:UpdatePanel>--%>
                <article>
                    <%-- Seccion de Filtros --%>
                    <%-------------------------%>
                   <%-- <asp:UpdatePanel runat="server">
                    <ContentTemplate>--%>
                    <asp:Panel ID="Pnl_Filtros" Visible="true" runat="server">
                    <section>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo">
                                            <strong>Filtros de Consulta</strong>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width: 45%; text-align:left">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha</div>
                                            <asp:TextBox ID="Txt_Fecha" CssClass="form-control Fecha" Placeholder="DD/MM/YYYY" MaxLength="10" runat="server"></asp:TextBox>
                                        </div>
                                    </td>
                                    <td style="width:10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Jefe Inmediato</div>
                                            <asp:DropDownList ID="Drl_JefeInmediato" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%; text-align:left">
                                        <div class="input-group">
                                            <div class="input-group-addon">Campaña</div>
                                            <asp:DropDownList ID="Drl_Campaña" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                    <td style="width:10%"></td>
                                    <td style="width: 45%"><%--AQUI--%>
                                        <div class="input-group">
                                            <div class="input-group-addon">Codigo Agente</div>
                                            <asp:TextBox ID="Txt_Cod_Agente" MaxLength="5" CssClass="form-control" runat="server"/> 
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%; text-align:left;">
                                        <div class="input-group">
                                            <div class="input-group-addon">Turno</div>
                                            <asp:DropDownList ID="Drl_Turno" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                    <td style="width:10%"></td>
                                    <td style="width: 45%; text-align:left;">
                                        <div class="input-group">
                                            <div class="input-group-addon">Contar Asignados</div>
                                            <asp:CheckBox ID="Chk_Asig" Text="SI" Checked="true" AutoPostBack="true" CssClass="form-control" runat="server" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%; text-align:left;">
                                        <asp:Button ID="Btn_Filtrar" Text="Filtrar" CssClass="btn btn-primary Desplegar" runat="server" />&nbsp;
                                        <asp:Button ID="Btn_Exportar1" Text="Exportar" CssClass="btn btn-primary" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                            </table>
                    </section>
                    </asp:Panel>
                    <asp:Panel ID="Pnl_Info" Visible="false" runat="server">
                    <section>
                            <table style="width:100%; text-align:left">
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo" style="text-align:center;">
                                            <strong>Informacion del Agente</strong>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Codigo</div>
                                            <asp:Label ID="Lbl_Cod" CssClass="form-control" runat="server"></asp:Label>
                                        </div>
                                    </td>
                                    <td style="width:10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Nombre</div>
                                            <asp:Label ID="Lbl_Nombre" CssClass="form-control" runat="server"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Turno</div>
                                            <asp:Label ID="Lbl_Turno" CssClass="form-control" runat="server"></asp:Label>
                                        </div>
                                    </td>
                                    <td style="width:10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Jefe Inmediato</div>
                                            <asp:Label ID="Lbl_Jefe" CssClass="form-control" runat="server"></asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Campaña</div>
                                            <asp:Label ID="Lbl_Campaña" CssClass="form-control" runat="server"></asp:Label>
                                        </div>
                                    </td>
                                    <td style="width:10%"></td>
                                    <td style="width: 45%"></td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%; text-align:left;">
                                        <asp:Button ID="Btn_Volver" Text="Volver" CssClass="btn btn-primary" runat="server" />&nbsp;
                                        <asp:Button ID="Btn_Exportar2" Text="Exportar" CssClass="btn btn-primary" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                            </table>
                    </section>
                    </asp:Panel>
                    <%--- Seccion de Grids ---%>
                    <%---------------------------%>
                    <section class="DataGrids">
                        <asp:Panel ID="Pnl_Dtg_Productividad" Visible="false" runat="server">  
                            <table style="width:100%; text-align:left">
                                <tr>
                                    <td style="width: 45%">
                                        <h4><em>
                                            <asp:Label ID="Lbl_Cantidad" runat="server" ForeColor="#8F9E45"></asp:Label>
                                        </em></h4>
                                    </td>
                                    <td colspan="2" style="width: 55%">
                                        <div class="bordes">
                                            <asp:GridView ID="Dtg_Total_Horas" runat="server" AllowPaging="False"
                                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                                GridLines="None" Width="100%" Style="font-size: x-small"
                                                EnableModelValidation="True">
                                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                                <Columns>
                                                    <asp:BoundField DataField="6" HeaderText="6" />
                                                    <asp:BoundField DataField="7" HeaderText="7" />
                                                    <asp:BoundField DataField="8" HeaderText="8" />
                                                    <asp:BoundField DataField="9" HeaderText="9" />
                                                    <asp:BoundField DataField="10" HeaderText="10" />
                                                    <asp:BoundField DataField="11" HeaderText="11" />
                                                    <asp:BoundField DataField="12" HeaderText="12" />
                                                    <asp:BoundField DataField="13" HeaderText="13" />
                                                    <asp:BoundField DataField="14" HeaderText="14" />
                                                    <asp:BoundField DataField="15" HeaderText="15" />
                                                    <asp:BoundField DataField="16" HeaderText="16" />
                                                    <asp:BoundField DataField="17" HeaderText="17" />
                                                    <asp:BoundField DataField="18" HeaderText="18" />
                                                    <asp:BoundField DataField="19" HeaderText="19" />
                                                    <asp:BoundField DataField="20" HeaderText="20" />
                                                    <asp:BoundField DataField="21" HeaderText="21" />
                                                    <asp:BoundField DataField="TOTAL" HeaderText="TOTAL" />
                                                </Columns>
                                                <FooterStyle BackColor="#B3C556" Font-Size="10px" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                                <EditRowStyle BackColor="#999999" />
                                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                            </asp:GridView>
                                        </div>
                                    </td>
                                </tr>
                        </table><br/>
                        <div class="bordes">
                                <div class="input-group">                                      
                                    <div style="background-color: #B3C556; height: 37px; width: 100%; margin: 0; padding: 0">
                                        <table  id="tblHeader" runat="server" style="background-color:#B3C556; Color:White; Font-Size:11px; width: 100%; height: 100%;">
                                            <tr>
                                                <td style="width: 4%; text-align:left">Turno</td>
                                                <td style="width: 4%; text-align:left">Codigo</td>
                                                <td style="width: 17%; text-align:center">Agente</td>
                                                <td style="width: 11.5%; text-align:left">Jefe Inmediato</td>
                                                <td style="width: 8.5%; text-align:left">Campaña</td>
                                                <td style="width: 2%; text-align:left">6</td>
                                                <td style="width: 2%; text-align:left">7</td>
                                                <td style="width: 1.6%; text-align:left">8</td>
                                                <td style="width: 1.6%; text-align:left">9</td>
                                                <td style="width: 2%; text-align:left">10</td>
                                                <td style="width: 2%; text-align:left">11</td>
                                                <td style="width: 2%; text-align:left">12</td>
                                                <td style="width: 2%; text-align:left">13</td>
                                                <td style="width: 2%; text-align:left">14</td>
                                                <td style="width: 2%; text-align:left">15</td>
                                                <td style="width: 1.6%; text-align:left">16</td>
                                                <td style="width: 2%; text-align:left">17</td>
                                                <td style="width: 2%; text-align:left">18</td>
                                                <td style="width: 2%; text-align:left">19</td>
                                                <td style="width: 2%; text-align:left">20</td>
                                                <td style="width: 2%; text-align:left">21</td>
                                                <td style="width: 4%; text-align:left">TOTAL</td>
                                                <td style="width: 6%; text-align:left">NO EFEC</td>
                                                <td style="width: 6%; text-align:left">  </td>
                                            </tr>
                                        </table>
                                    </div>
                                    <div style="overflow: auto; width: 100%; min-height:0px; max-height: 400px;">                                            
                                        <asp:GridView ID="Dtg_Productividad" runat="server" AllowPaging="False" 
                                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                                        GridLines="None" Width="100%" style="font-size: x-small" 
                                        EnableModelValidation="True" ShowHeader="false" ShowFooter="false" >                                           
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                            <Columns>                            
                                                <asp:BoundField ItemStyle-Width="4%" DataField="Horario" HeaderText="Turno"/>
                                                <asp:BoundField ItemStyle-Width="6%" DataField="Codigo" HeaderText="Codigo"/>
                                                <asp:BoundField ItemStyle-Width="17%" DataField="Nombre" HeaderText="Agente"/>
                                                <asp:BoundField ItemStyle-Width="11%" DataField="Jefe" HeaderText="Jefe Inmediato"/>
                                                <asp:BoundField ItemStyle-Width="8.5%" DataField="Campaña" HeaderText="Campaña"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="6" HeaderText="6"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="7" HeaderText="7"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="8" HeaderText="8"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="9" HeaderText="9"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="10" HeaderText="10"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="11" HeaderText="11"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="12" HeaderText="12"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="13" HeaderText="13"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="14" HeaderText="14"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="15" HeaderText="15"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="16" HeaderText="16"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="17" HeaderText="17"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="18" HeaderText="18"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="19" HeaderText="19"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="20" HeaderText="20"/>
                                                <asp:BoundField ItemStyle-Width="2%" DataField="21" HeaderText="21"/>
                                                <asp:BoundField ItemStyle-Width="4%" DataField="TOTAL" HeaderText="TOTAL"/>
                                                <asp:BoundField ItemStyle-Width="6%" DataField="NO EFECTIVOS" HeaderText="NO EFEC"/>
                                                <asp:ButtonField ItemStyle-Width="6%" ButtonType="Link" ControlStyle-CssClass="btn btn-primary  glyphicon glyphicon-eye-open Desplegar"  ControlStyle-Height="25px" ControlStyle-Font-Size="12px" ControlStyle-ForeColor="White" CommandName="Seleccionar" />
                                            </Columns>
                                            <FooterStyle BackColor="#B3C556"  Font-Size="10px" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>                                     
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>                            
                        <div class="bordes">
                                <asp:GridView ID="Dtg_Campañas" runat="server" CellPadding="4" AllowPaging="false" ForeColor="#333333" AutoGenerateColumns="True" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        <br />
                        <div class="bordes">
                                <asp:GridView ID="Dtg_Detalle" runat="server" CellPadding="4" AllowPaging="false" ForeColor="#333333" AutoGenerateColumns="True" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        <br />
                    </section>
                </article>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="Btn_Exportar1" />
                <asp:PostBackTrigger ControlID="Btn_Exportar2" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>