<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Desarrollo_Registro.aspx.vb" Inherits="digitacion.Desarrollo_Registro" %>
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
                        <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Registro Solicitud de Desarrollo</em></h4></asp:Label>
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
                    <%-- Seccion de Registro --%>
                    <%-------------------------%>
                    <section>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo_Desarrollo">
                                            <strong>Registro Desarrollos</strong>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Tema</div>
                                            <asp:TextBox ID="Txt_Tema" MaxLength="80" CssClass="form-control" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Prioridad</div>
                                            <asp:DropDownList ID="Drl_Prioridad" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Area</div>
                                            <asp:DropDownList ID="Drl_Area" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Persona Solicita</div>
                                            <asp:DropDownList ID="Drl_Solicitante" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Requerimientos</div>
                                            <asp:TextBox ID="Txt_Requerimientos" CssClass="form-control" TextMode="MultiLine" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 55%" colspan ="2"></td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%; text-align:left;">
                                        <asp:LinkButton ID="Btn_Guardar" Font-Strikeout="false" CssClass="btn btn-primary" runat="server">
                                            <span class="glyphicon glyphicon-floppy-disk"></span> Guardar
                                        </asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                            </table>
                    </section>
                    <%--- Seccion de Consulta ---%>
                    <%---------------------------%>
                    <section>
                        <table style="width:100%">
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
                                        <asp:RegularExpressionValidator Font-Size="10px" runat="server" ControlToValidate="Txt_Cons_Codigo" Display="Dynamic" SetFocusOnError="True" ValidationExpression="((DES)?(des)?)*([0-9]{4,4})*">Codigo mal escrito, Ejemplo(DES0000)</asp:RegularExpressionValidator>
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
                                        <asp:RangeValidator runat="server" Font-Size="10px" ControlToValidate="Txt_Fc_Inicio" SetFocusOnError="True" Display="Dynamic" Type="Date" MinimumValue="01/01/2016" MaximumValue="31/12/3000">Fecha inicio incorrecta, verifique!!</asp:RangeValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Inicio</div>
                                            <asp:TextBox ID="Txt_Fc_Inicio" CssClass="form-control Fecha" MaxLength="10" Placeholder="DD/MM/YYYY" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <asp:RangeValidator runat="server" Font-Size="10px" ControlToValidate="Txt_Fc_Fin" SetFocusOnError="True" Display="Dynamic" Type="Date" MinimumValue="01/01/2016" MaximumValue="31/12/3000">Fecha fin incorrecta, verifique!!</asp:RangeValidator>
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
                    <%--- Seccion de Grids ---%>
                    <%---------------------------%>
                    <section class="DataGrids">
                            <h4 style="color: #8F9E45; text-shadow: 1px 1px 10px rgba(0,0,0,0.50)"><em>
                                <asp:Label runat="server">Desarrollos Solicitados:&nbsp;&nbsp;</asp:Label>
                                <asp:Label ID="Lbl_Cantidad" runat="server"></asp:Label>
                            </em></h4>
                            <div class="bordes_Desarrollo">
                                <asp:GridView ID="Dtg_Desarrollos" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="CODIGO" HeaderText="Codigo" />
                                        <asp:BoundField DataField="FECHA" HeaderText="Fecha Registro" />
                                        <asp:BoundField DataField="Reg_Usu_Reg" HeaderText="Registra" />
                                        <asp:BoundField DataField="TEMA" HeaderText="Tema" />
                                        <asp:BoundField DataField="PRIORIDAD" HeaderText="Prioridad" />
                                        <asp:BoundField DataField="REQ" HeaderText="Requerimientos" />
                                        <asp:BoundField DataField="ESTADO" HeaderText="Estado" />
                                        <asp:BoundField DataField="SOLICITA" HeaderText="Solicita" />
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
                    </section>
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
