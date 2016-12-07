<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AsignacionHorario.aspx.vb" Inherits="digitacion.AsignacionHorario" %>
<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
            $_$(".Hora").timepicker({
                timeFormat: 'hh:mm'
            });
        }
    </script>
    <!-- Fin Script jQuery Datepicker --->
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
     <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="../Css2/Maquetacion.css" />
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
                        <uc1:menu ID="menu" class="btn btn-primary" runat="server" />
                    </center>
                </nav>
                <article>
                    <section class="profile"">
                        <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Registro Horarios</em></h4></asp:Label>
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
                <article>
                    <%-- Seccion de Agregar --%>
                    <%------------------------%>
                    <section>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo">
                                            <strong>Agregar Agentes</strong>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <asp:RegularExpressionValidator ControlToValidate="TxtCod_Agente" style="float:left; text-align:left; width:100%" ValidationExpression="C([0-9]{4,4})*" Display="Dynamic" runat="server">¡Verifique el codigo! Ej: C0000</asp:RegularExpressionValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Codigo</div>
                                            <asp:TextBox ID="TxtCod_Agente" MaxLength="5" CssClass="form-control" runat="server" />
                                            <span class="input-group-btn">
                                                <asp:Button ID="BtnValidar" Text="Validar" CssClass="btn btn-primary" runat="server" />
                                                <asp:Button ID="BtnCancelar" Text="Cancelar" Visible="false" CssClass="btn btn-primary" runat="server" />
                                            </span>
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Nombre</div>
                                            <asp:TextBox Enabled="false" ID="LblNombre" CssClass="form-control" runat="server" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Grupo</div>
                                            <asp:TextBox Enabled="false" ID="LblGrupo" CssClass="form-control" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <asp:Label runat="server" style="float:left;" ForeColor="#8F9E45"><h4><em>Agregar Personal Masivo</em></h4></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Persona a cargo</div>
                                            <asp:DropDownList ID="drlPersonalACargo" CssClass="form-control" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 52.5%" colspan ="2"></td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%; text-align:left;">
                                        <asp:Button ID="BtnAgregar" Text="Agregar" CssClass="btn btn-primary" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                            </table>
                    </section>
                    <%--- Seccion de Grids ---%>
                    <%------------------------%>
                    <section class="DataGrids" style="width:60%;">
                        <asp:Panel ID="Pnl_Dtg_Agentes" Visible="false" runat="server">
                        <h4 style="color: #8F9E45;"><em>
                                <asp:Label runat="server">Agentes Agregados:&nbsp;&nbsp;</asp:Label>
                                <asp:Label ID="Lbl_Cantidad" runat="server"></asp:Label>
                            </em></h4>
                            <div class="bordes">
                                <asp:GridView ID="Dtg_Agentes" runat="server"
                                    AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                        <asp:BoundField DataField="grupo" HeaderText="Grupo" />
                                        <asp:ButtonField ButtonType="Link" ControlStyle-CssClass="btn btn-primary  glyphicon glyphicon-remove" ControlStyle-Font-Strikeout="false" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right"  ControlStyle-Height="25px" ControlStyle-Font-Size="12px" ControlStyle-ForeColor="White" CommandName="Delete" >
                                        <ControlStyle CssClass="btn btn-primary  glyphicon glyphicon-remove"  Font-Size="12px" ForeColor="White" Height="25px" />
                                        </asp:ButtonField>
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
                            </asp:Panel>
                    </section>
                    <%-- Seccion de Asignar --%>
                    <%------------------------%>
                    <section>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo">
                                            <strong>Asiganar Horarios</strong>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <asp:CompareValidator style="float:left; width:100%" runat="server" Display="Dynamic" ControlToValidate="TxtFecha_Ingreso" Operator="DataTypeCheck" Type="Date">¡Revise la fecha de ingreso!</asp:CompareValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Ingreso</div>
                                            <asp:TextBox ID="TxtFecha_Ingreso" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY"></asp:TextBox>
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipo Horario</div>
                                            <asp:DropDownList ID="drlTipoHorario" AutoPostBack="true" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <asp:RangeValidator MaximumValue="23:59" MinimumValue="01:00" style="float:left;   text-align:left; width:100%" ValidationExpression="([0-9]{2,2}):([0-9]{2,2})*" Display="Dynamic"  ControlToValidate="TxtHora_Ingreso" runat="server">Validar Hora de Ingreso!</asp:RangeValidator>
                                        <asp:RegularExpressionValidator ControlToValidate="TxtHora_Ingreso" style="float:left; text-align:left; width:100%" ValidationExpression="([0-9]{2,2}):([0-9]{2,2})*" Display="Dynamic" runat="server">Validar Hora de Ingreso!</asp:RegularExpressionValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Hora Ingreso</div>
                                            <asp:TextBox ID="TxtHora_Ingreso" MaxLength="5" placeholder="HH:mm" CssClass="form-control Hora" runat="server" />
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                        <asp:RangeValidator MaximumValue="23:59" MinimumValue="01:00" style="float:left;   text-align:left; width:100%" ValidationExpression="([0-9]{2,2}):([0-9]{2,2})*" Display="Dynamic"  ControlToValidate="TxtHora_Salida" runat="server">Validar Hora de Salida!</asp:RangeValidator>
                                        <asp:RegularExpressionValidator ControlToValidate="TxtHora_Salida" style="float:left; text-align:left; width:100%" ValidationExpression="([0-9]{2,2}):([0-9]{2,2})*" Display="Dynamic" runat="server">Validar Hora de Salida!</asp:RegularExpressionValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Hora Salida</div>
                                            <asp:TextBox ID="TxtHora_Salida" MaxLength="5" placeholder="HH:mm" CssClass="form-control Hora" runat="server" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 45%">
                                        <asp:CompareValidator style="float:left; width:100%" Display="Dynamic" ID="CompareValidator8" runat="server" ControlToValidate="TxtNdias" Operator="DataTypeCheck" Type="Integer">¡Revisar la cantidad de horas!</asp:CompareValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Cantidad de Dias</div>
                                            <asp:TextBox ID="TxtNdias" runat="server" CssClass="form-control" MaxLength="1" ToolTip="Cantidad de Dias que el agente tendra el turno"></asp:TextBox>
                                        </div>
                                    </td>
                                    <td style="width: 10%"></td>
                                    <td style="width: 45%">
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%; text-align:left;">
                                        <asp:Button ID="BtnGuardar" Text="Guardar" CssClass="btn btn-primary" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                            </table>
                    </section>
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
