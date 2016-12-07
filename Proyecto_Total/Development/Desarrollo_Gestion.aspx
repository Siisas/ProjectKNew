<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Desarrollo_Gestion.aspx.vb" Inherits="digitacion.Desarrollo_Gestion" %>
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
                    <section class="profile" style="text-shadow: 1px 1px 10px rgba(0,0,0,0.50)">
                        <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Gestion de Desarrollos</em></h4></asp:Label>
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
                        <div class="alert alert-danger" aria-hidden="true" id="Alert_error" runat="server">
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </div>
                        <div class="alert alert-success" aria-hidden="true" id="Alert_correcto" runat="server">
                            <asp:Label ID="lblmsgg" runat="server"></asp:Label>
                        </div>
                    </section>
                </article>
                <article>
                    <%-- Seccion de consulta --%>
                    <%-------------------------%>
                    <asp:Panel ID="Pnl_Filtros" Visible="true" runat="server">
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
                                            <asp:TextBox ID="Txt_Cons_Cod" CssClass="form-control" MaxLength="7" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Prioridad</div>
                                            <asp:DropDownList ID="Drl_Cons_Pri" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Inicio</div>
                                            <asp:TextBox ID="Txt_Cons_FcIni" CssClass="form-control Fecha" Placeholder="DD/MM/YYYY" MaxLength="10" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Fin</div>
                                            <asp:TextBox ID="Txt_Cons_FcFin" CssClass="form-control Fecha" Placeholder="DD/MM/YYYY" MaxLength="10" runat="server" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado</div>
                                            <asp:DropDownList ID="Drl_Cons_Est" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%"></td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%; text-align: left;">
                                        <asp:LinkButton ID="Btn_Filtrar" Font-Strikeout="false" class="btn btn-primary" runat="server">
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
                    <%-- Seccion de registro --%>
                    <%-------------------------%>
                    <asp:Panel ID="Pnl_Gestion" Visible="false" runat="server">
                        <section>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>   
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo_Desarrollo">
                                            <strong>Registro de Gestion del Desarrollo</strong>
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
                                            <asp:TextBox ID="Txt_Codigo" CssClass="form-control" Enabled="false" MaxLength="7"  runat ="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Prioridad</div>
                                            <asp:TextBox ID="Txt_Prioridad" CssClass="form-control" Enabled="false"  runat ="server" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Persona Solicita</div>
                                            <asp:TextBox ID="Txt_Solicitante" CssClass="form-control" Enabled="false" runat ="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Area</div>
                                            <asp:TextBox ID="Txt_Area" CssClass="form-control" Enabled="false" runat ="server" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Registro</div>
                                            <asp:TextBox ID="Txt_Fc_Reg" CssClass="form-control Fecha" Enabled="false" Placeholder="DD/MM/YYYY"  runat ="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Tema</div>
                                            <asp:TextBox ID="Txt_Tema" CssClass="form-control" Enabled="false" runat ="server" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Requerimientos</div>
                                            <asp:TextBox ID="Txt_Requerimientos" CssClass="form-control" TextMode="MultiLine" ReadOnly="True" runat ="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%"></td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Complejidad</div>
                                            <asp:DropDownList ID="Drl_Complejidad" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Operatividad</div>
                                            <asp:DropDownList ID="Drl_Operatividad" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Observacion</div>
                                            <asp:TextBox ID="Txt_Observacion" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado</div>
                                            <asp:DropDownList ID="Drl_Estado" CssClass="form-control" AutoPostBack="true" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                </tr>
                                <asp:Panel ID="Pnl_Usu_Esc" Visible="false" runat="server">
                                    <tr>
                                        <td style="width: 45%">
                                            <div class="input-group">
                                                <div class="input-group-addon">Desarrollador</div>
                                                <asp:DropDownList ID="Drl_Usu_Asig" CssClass="form-control" runat="server"></asp:DropDownList>
                                            </div>
                                        </td>
                                        <td style="width: 55%" colspan="2"></td>
                                    </tr>
                                </asp:Panel>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%; text-align: left;">
                                        <asp:LinkButton ID="Btn_Guardar" Font-Strikeout="false" class="btn btn-primary" runat="server">
                                            <span class="glyphicon glyphicon-floppy-disk" aria-hidden="true"></span> Guardar
                                        </asp:LinkButton>&nbsp;&nbsp;&nbsp; 
                                        <asp:LinkButton ID="Btn_Volver" Font-Strikeout="false" class="btn btn-primary" runat="server">
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
                    <%-- Seccion de DataGridViews --%>
                    <%------------------------------%>
                    <section class="DataGrids">
                       <asp:Panel ID="Pnl_Dtg_Desarrollos" Visible="false" runat="server">
                                <h4 style="color: #8F9E45; text-shadow: 1px 1px 10px rgba(0,0,0,0.50); text-align:left;"><em>
                                    <asp:Label runat="server">Desarrollos Asignados:&nbsp;</asp:Label>
                                    <asp:Label ID="Lbl_Cantidad" runat="server"></asp:Label>
                                </em></h4>
                           <div class="bordes_Desarrollo">
                                <asp:GridView ID="Dtg_Desarrollos" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small" EnableModelValidation="True">                           
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="Reg_Cod" HeaderText="Codigo" />
                                            <asp:BoundField DataField="Reg_Fch" HeaderText="Fecha Registro" />
                                            <asp:BoundField DataField="Reg_Usu_Reg" HeaderText="Usuario Registra" />
                                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                            <asp:BoundField DataField="Reg_Tem" HeaderText="Tema" />
                                            <asp:BoundField DataField="Reg_Pri" HeaderText="Prioridad" />
                                            <asp:BoundField DataField="Area" HeaderText="Area" />
                                            <asp:BoundField DataField="Reg_Usu_Sol" HeaderText="Usuario Solicita" />
                                            <asp:BoundField DataField="Reg_Req" HeaderText="Requerimientos" />
                                            <asp:BoundField DataField="Reg_Usu_Asi" HeaderText="Usuario Asigna" />
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
                        </asp:Panel><br />
                        <%--******* PANEL DE DATAGRID GESTIONES *******--%>
                        <asp:Panel ID="Pnl_Dtg_Gestiones" Visible="false" runat="server">
                                <h4 style="color: #8F9E45; text-shadow: 1px 1px 10px rgba(0,0,0,0.50); text-align:left;"><em>
                                    <asp:Label runat="server">Gestiones Realizadas:&nbsp;</asp:Label>
                                    <asp:Label ID="Lbl_Cantidad2" runat="server"></asp:Label>
                                </em></h4>
                                <div class="bordes_Desarrollo">
                                <asp:GridView ID="Dtg_Gestiones" runat="server" AllowPaging="True"
                                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                        GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                        EnableModelValidation="True">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="Codigo" HeaderText="Desarrollo" />
                                            <asp:BoundField DataField="Fecha" HeaderText="Fecha Registro" />
                                            <asp:BoundField DataField="Usuario_Reg" HeaderText="Usuario Registra" />
                                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                            <asp:BoundField DataField="Observ" HeaderText="Observacion" />
                                            <asp:BoundField DataField="Compl" HeaderText="Complejidad" />
                                            <asp:BoundField DataField="Opera" HeaderText="Operatividad" />
                                        </Columns>
                                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                                </div>
                        </asp:Panel><br />
                    </section>
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>

