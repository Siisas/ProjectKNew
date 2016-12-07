<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Desarrollo_Asignacion.aspx.vb" Inherits="digitacion.Desarrollo_Asignacion" %>
<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link rel="icon" href="favicon.ico" type="image/x-icon" />
    <title>ERP Kamilion</title>
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/javascript" src="../Css2/scripts.js"></script>
    <!-- Fin Script jQuery Datepicker --->
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
     <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="StyleDesarrollo.css" />
</head>
<body>
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
                    <section class="profile" style="text-shadow: 1px 1px 10px rgba(0,0,0,0.50);">
                        <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Asignacion de Desarrollos</em></h4></asp:Label>
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
                        <div class="alert alert-danger" id="Alert_error" runat="server">
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </div>
                        <div class="alert alert-success" id="Alert_correcto" runat="server">
                            <asp:Label ID="lblmsgg" runat="server"></asp:Label>
                        </div>
                    </section>
                </article>
                <article>
                    <%-- Seccion de consulta --%>
                    <%-------------------------%>
                    <asp:Panel ID="PnlFiltros" Visible="true" runat="server">
                        <section>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo_Desarrollo">
                                            <strong>Filtros de Consulta</strong>
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
                                            <asp:TextBox ID="Txt_Cons_Codigo" MaxLength="7" CssClass="form-control" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Prioridad</div>
                                            <asp:DropDownList ID="Drl_Cons_Prioridad" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Inicio</div>
                                            <asp:TextBox ID="Txt_Fc_Inicio" CssClass="form-control Fecha" MaxLength="10" Placeholder="DD/MM/YYYY" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Fin</div>
                                            <asp:TextBox ID="Txt_Fc_Fin" CssClass="form-control Fecha" MaxLength="10" Placeholder="DD/MM/YYYY" runat="server" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%; text-align:left;">
                                        <asp:LinkButton ID="Btn_Filtrar" Font-Strikeout="false" CssClass="btn btn-primary" runat="server">
                                            <span class="glyphicon glyphicon-search"></span> Filtrar
                                        </asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                            </table>
                        </section>
                    </asp:Panel>
                    <%-- Seccion de asignacion --%>
                    <%---------------------------%>
                    <asp:Panel ID="PnlAsignar" Visible="false" runat="server">
                        <section>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo_Desarrollo">
                                            <strong>Asignar Desarrollos</strong>
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
                                            <asp:TextBox id="Txt_Codigo" CssClass="form-control" Enabled="false" MaxLength="7" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Tema</div>
                                            <asp:TextBox ID="Txt_Tema" CssClass="form-control" Enabled="false" runat="server" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Requerimientos</div>
                                            <asp:TextBox ID="Txt_Requerimientos" CssClass="form-control" ReadOnly="true" TextMode="MultiLine" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Desarrollador</div>
                                            <asp:DropDownList ID="Drl_Desarrollador" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width:100%; text-align:left">
                                        <asp:LinkButton ID = "Btn_Asignar" Font-Strikeout="false" CssClass="btn btn-primary" runat="server">
                                            <span class="glyphicon glyphicon-share"></span> Asignar
                                        </asp:LinkButton>&nbsp;&nbsp;&nbsp;
                                        <asp:LinkButton ID = "Btn_Cancelar" Font-Strikeout="false" CssClass="btn btn-primary" runat="server">
                                            <span class="glyphicon glyphicon-arrow-left"></span> Volver
                                        </asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                            </table>
                        </section>
                    </asp:Panel>
                    <section class="DataGrids">
                        <asp:Panel ID="Pnl_Dtg_Desarrollos" Visible="false" runat="server">
                            <h4 style="color: #8F9E45; text-shadow: 1px 1px 10px rgba(0,0,0,0.50)"><em>
                                <asp:Label runat="server">Desarrollos Sin Asignar:&nbsp;&nbsp;</asp:Label>
                                <asp:Label ID="Lbl_Cantidad" runat="server"></asp:Label>
                            </em></h4>
                            <div class="bordes_Desarrollo">
                                <asp:GridView ID="Dtg_Desarrollos" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Reg_Cod" HeaderText="Codigo" />
                                        <asp:BoundField DataField="Reg_Fch" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Reg_Usu_Reg" HeaderText="Usuario Registra" />
                                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                        <asp:BoundField DataField="Reg_Tem" HeaderText="Tema" />
                                        <asp:BoundField DataField="Reg_Pri" HeaderText="Prioridad" />
                                        <asp:BoundField DataField="Area" HeaderText="Area" />
                                        <asp:BoundField DataField="Reg_Req" HeaderText="Requerimientos" />
                                        <asp:ButtonField ButtonType="Link" ControlStyle-CssClass="btn btn-primary  glyphicon glyphicon-eye-open"  ControlStyle-Height="25px" ControlStyle-Font-Size="12px" ControlStyle-ForeColor="White" CommandName="Seleccionar" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </asp:Panel>
                        <br />
                    </section>
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>