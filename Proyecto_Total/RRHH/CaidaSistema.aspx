<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CaidaSistema.aspx.vb" Inherits="digitacion.CaidaSistema" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kamilion ERP</title>
    <link rel="icon" href="~/favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="~/favicon.ico" type="image/x-icon" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/javascript" src="../Css2/scripts.js"></script>
    <!--#########Estilos############-->
    <link type="text/css" rel="Stylesheet" href="~/Css2/Boot/css/bootstrap.min.css" />
    <link type="text/css" rel="Stylesheet" href="~/Css2/jquery-ui.css" />
    <link type="text/css" rel="Stylesheet" href="~/Css2/Kamilion.css" />
</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <Control:Header ID="Header" runat="server" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Panel ID="Pnl_Message" runat="server">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <article>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <section>
                        <asp:Panel ID="PnlRepCaidaSistema" Visible="true" runat="server">
                            <div class="text-center Subtitulos">Registro Caidas del Sistema</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="Registro" runat="server" ShowMessageBox="false" DisplayMode="List" />
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Inicio<asp:RangeValidator ID="RangeValidator1" runat="server" ValidationGroup="Registro" ControlToValidate="txtFechaInicio" ErrorMessage="Formato de Fecha Inicio Incorrecto!!" SetFocusOnError="False" Type="Date" MaximumValue="01/01/2020" MinimumValue="01/01/2000">*</asp:RangeValidator></div>
                                        <asp:TextBox ID="txtFechaInicio" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" TabIndex="1"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Inicio<asp:RegularExpressionValidator ID="RegularExpressionValidator1" ErrorMessage="Formato de hora inicio incorrecto" ValidationGroup="Registro" SetFocusOnError="True" ValidationExpression="([0-9]{1,2}):([0-9]{2,2})" ControlToValidate="txtFechaInicio_Tiempo" runat="server">*</asp:RegularExpressionValidator></div>
                                        <asp:TextBox ID="txtFechaInicio_Tiempo" runat="server" MaxLength="5" placeholder="HH:mm" CssClass="form-control Hora" TabIndex="3"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Causa caida</div>
                                        <asp:DropDownList ID="drlCausa_Caida" runat="server" CssClass="form-control" TabIndex="5">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Duracion falla</div>
                                        <asp:TextBox ID="TxtDuracionFalla" runat="server" CssClass="form-control" Enabled="False" TabIndex="7"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Solucion brindada</div>
                                        <asp:TextBox ID="txtSolucionbrindada" runat="server" CssClass="form-control" TextMode="MultiLine" TabIndex="9"></asp:TextBox>
                                    </div>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat='server' ControlToValidate='TxtCod_Falla' ErrorMessage='Solo valores numericos' ValidationGroup="Consul" SetFocusOnError='True' ValidationExpression='([0-9]{0,7})'></asp:RegularExpressionValidator>&nbsp;
                                
                                <div class="input-group">
                                    <span id="Span3" runat="server" class="input-group-btn">
                                        <asp:Button ID="btnguardar" runat="server" ValidationGroup="Registro" Text="Guardar" Visible="true" CssClass="btn btn-primary" TabIndex="10" />
                                        <asp:Button ID="btnactualiza" runat="server" ValidationGroup="Registro" Text="Actualizar" Visible="false" CssClass="btn btn-primary" TabIndex="11" />
                                        <asp:Button ID="btnelimina" runat="server" Text="Eliminar" Visible="false" CssClass="btn btn-primary" TabIndex="12" />
                                    </span>
                                    <asp:TextBox ID="TxtCod_Falla" runat="server" MaxLength="7" CssClass="form-control" TabIndex="13"></asp:TextBox>
                                    <span id="Span4" runat="server" class="input-group-btn">
                                        <asp:Button ID="btnconsultar" runat="server" Text="Consultar" ValidationGroup="Consul" Visible="True" CssClass="btn btn-primary" TabIndex="14" />
                                        <asp:Button ID="BtnValidacion" runat="server" Text="Cancelar" Visible="false" CssClass="btn btn-primary" TabIndex="15" />
                                    </span>
                                </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Solucion<asp:RangeValidator ID="RangeValidator2" runat="server" ValidationGroup="Registro" ControlToValidate="txtFechasolucion" ErrorMessage="Formato de Fecha Solucion Incorrecto!!" SetFocusOnError="False" Type="Date" MaximumValue="01/01/2020" MinimumValue="01/01/2000">*</asp:RangeValidator></div>
                                        <asp:TextBox ID="txtFechasolucion" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" TabIndex="2"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Solucion<asp:RegularExpressionValidator ID="RegularExpressionValidator2" ErrorMessage="Formato de hora solucion incorrecto" ValidationGroup="Registro" SetFocusOnError="True" ValidationExpression="([0-9]{1,2}):([0-9]{2,2})" ControlToValidate="txtFechasolucion_Tiempo" runat="server">*</asp:RegularExpressionValidator></div>
                                        <asp:TextBox ID="txtFechasolucion_Tiempo" runat="server" MaxLength="5" placeholder="HH:mm" CssClass="form-control Hora" TabIndex="4"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Detalle</div>
                                        <asp:TextBox ID="txtaDetalle" runat="server" MaxLength="50" CssClass="form-control" TextMode="MultiLine" TabIndex="6"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Puestos afectados</div>
                                        <asp:TextBox ID="TxtpuestosAfectados" runat="server" CssClass="form-control" TabIndex="8"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                        <div class="text-center Subtitulos">Consulta Caidas del Sistema</div>
                        <div class="Form">
                            <asp:ValidationSummary ID="ValidationSummary2" ValidationGroup="Consulta" runat="server" ShowMessageBox="false" DisplayMode="List" />
                            &nbsp;
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Codigo<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TxtConsultaEspecificas" ErrorMessage="El codigo solo admite valores numericos!!" ValidationGroup="Consulta" SetFocusOnError="True" ValidationExpression="[0-9]{0,7}">*</asp:RegularExpressionValidator>
                                    </div>
                                    <asp:TextBox ID="TxtConsultaEspecificas" MaxLength="7" runat="server" CssClass="form-control" TabIndex="16"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Inicio<asp:RangeValidator ID="RangeValidator3" runat="server" ValidationGroup="Consulta" ControlToValidate="TxtFechaConsulta1" ErrorMessage="Formato de Fecha Inicio Incorrecto!!" SetFocusOnError="False" Type="Date" MaximumValue="01/01/2020" MinimumValue="01/01/2000">*</asp:RangeValidator></div>
                                    <asp:TextBox ID="TxtFechaConsulta1" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" TabIndex="18"></asp:TextBox>
                                </div>
                                <br />
                                <asp:Button ID="BtnConsultaespe" ValidationGroup="Consulta" runat="server" Text="Consultar" CssClass="btn btn-primary" TabIndex="20" />&nbsp;
                                <asp:Button ID="BtnTodos" runat="server" Text="Ver todos" CssClass="btn btn-primary" TabIndex="21" />&nbsp;
                                <asp:Button ID="btnxls" runat="server" Text="Exportar" CssClass="btn btn-primary" TabIndex="22" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo de Caida
                                    </div>
                                    <asp:DropDownList ID="drlCausa_Caida_Consulta" runat="server" CssClass="form-control" TabIndex="17"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Fin<asp:RangeValidator ID="RangeValidator4" runat="server" ValidationGroup="Consulta" ControlToValidate="TxtFechaConsulta2" ErrorMessage="Formato de Fecha Fin Incorrecto!!" SetFocusOnError="False" Type="Date" MaximumValue="01/01/2020" MinimumValue="01/01/2000">*</asp:RangeValidator></div>
                                    <asp:TextBox ID="TxtFechaConsulta2" runat="server" CssClass="form-control" MaxLength="10" placeholder="DD/MM/YYYY" TabIndex="18"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </section>
                    <div class="Leyendas ">
                        <asp:Label ID="Label7" runat="server">Numero de registros: </asp:Label>
                        <asp:Label ID="lblcantgral" runat="server">0</asp:Label>
                    </div>
                    <div class="bordes">
                        <td colspan="5" style="width: 100%">
                            <div class="bordes">
                                <div class="input-group">
                                    <div style="background-color: #B3C556; height: 37px; width: 100%; margin: 0; padding: 0">
                                        <table id="tblHeader" runat="server" style="background-color: #B3C556; color: White; font-size: Small; width: 100%; height: 100%;">
                                            <tr>
                                                <td style="width: 4%; text-align: center">Codigo</td>
                                                <td style="width: 5%; text-align: left">Fecha Inicio</td>
                                                <td style="width: 6%; text-align: left">Nombre</td>
                                                <td style="width: 16%; text-align: center">Detalle</td>
                                                <td style="width: 5%; text-align: left">Fecha Solucion</td>
                                                <td style="width: 5%; text-align: left">Duracion Falla</td>
                                                <td style="width: 5%; text-align: left">Puestos Afectados</td>
                                                <td style="width: 41%; text-align: center">Solucion Brindada</td>
                                                <td style="width: 6%; text-align: left">Fecha Registro</td>
                                                <td style="width: 8%; text-align: left">Usuario</td>
                                            </tr>
                                        </table>
                                    </div>
                                    <div style="overflow: auto; width: 100%; height: 400px;">
                                        <asp:GridView ID="dtgConsultas" runat="server" AllowPaging="False"
                                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" Width="100%" Style="font-size: x-small"
                                            EnableModelValidation="True" ShowHeader="false">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                            <Columns>
                                                <asp:BoundField ItemStyle-Width="4%" DataField="Cod_CS" HeaderText="Codigo" />
                                                <asp:BoundField ItemStyle-Width="5%" DataField="Fecha_Inicio" HeaderText="Fecha Inicio" />
                                                <asp:BoundField ItemStyle-Width="6%" DataField="Nombre" HeaderText="Nombre" />
                                                <asp:BoundField ItemStyle-Width="16%" DataField="Detalle" HeaderText="Detalle" />
                                                <asp:BoundField ItemStyle-Width="5%" DataField="Fecha_Solucion" HeaderText="Fecha Solucion" />
                                                <asp:BoundField ItemStyle-Width="5%" DataField="Duracion_Falla" HeaderText="Duracion Falla" />
                                                <asp:BoundField ItemStyle-Width="5%" DataField="Puestos_Afectados" HeaderText="Puestos Afectados" />
                                                <asp:BoundField ItemStyle-Width="42%" DataField="Solucion_Brindada" HeaderText="Solucion Brindada" />
                                                <asp:BoundField ItemStyle-Width="6%" DataField="Fecha_Registro" HeaderText="Fecha Registro" />
                                                <asp:BoundField ItemStyle-Width="6%" DataField="Fk_Usuario" HeaderText="Usuario" />
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
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="btnxls" />
                </Triggers>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>