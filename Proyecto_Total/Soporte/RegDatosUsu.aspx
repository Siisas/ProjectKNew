<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegDatosUsu.aspx.vb" Inherits="digitacion.RegDatosUsu" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kamilion CRM</title>
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
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <article>
                    <section>
                        <div class="text-center Subtitulos">Registro Credenciales de Usuarios</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Codigo</div>
                                    <asp:TextBox ID="Txt_Codigo" CssClass="form-control" MaxLength="10" runat="server" />
                                    <div class="input-group-btn">
                                        <asp:Button ID="Btn_Consultar" Text="Consultar" CssClass="btn btn-primary" runat="server" />
                                    </div>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre</div>
                                    <asp:TextBox ID="Txt_Nombre" MaxLength="50" ReadOnly="true" TabIndex="1" CssClass="form-control" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Area</div>
                                    <asp:TextBox ID="Txt_Area" CssClass="form-control" MaxLength="50" ReadOnly="true" runat="server" />
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Cedula</div>
                                    <asp:TextBox ID="Txt_Cedula" CssClass="form-control" TabIndex="2" runat="server" ReadOnly="true" MaxLength="11"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Grupo</div>
                                    <asp:TextBox ID="Txt_Grupo" CssClass="form-control" MaxLength="50" ReadOnly="true" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Entrega Acta</div>
                                    <asp:TextBox ID="Txt_Fehca_Acta" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" Enabled="false" />
                                    <Asp:Panel runat="server" ID="Pnl_Fecha_Acta" cssclass="input-group-btn" Visible="false" >
                                        <asp:Button ID="Btn_Reg_Acta" Text="Registrar" CssClass="btn btn-primary" runat="server" />
                                    </Asp:Panel>
                                </div>
                            </div>
                        </div>
                        <div class="Separator"></div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <asp:Panel ID="Pnl_Drl_PlataformaRed" runat="server">
                                    <div class="input-group">
                                        <div class="input-group-addon">Plataforma Red</div>
                                        <asp:DropDownList ID="Drl_PlataformaRed" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
                                    </div>
                                </asp:Panel>
                                <asp:Panel ID="Pnl_Drl_Plataforma" runat="server">
                                    <div class="input-group">
                                        <div class="input-group-addon">Plataforma Usuarios</div>
                                        <asp:DropDownList ID="Drl_Plataforma" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
                                    </div>
                                </asp:Panel>
                                <div class="input-group">
                                    <div class="input-group-addon">Usuario de Plataforma</div>
                                    <asp:TextBox ID="Txt_Usu_Plataforma" CssClass="form-control" MaxLength="50" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Formato Solicitud</div>
                                    <asp:TextBox ID="Txt_Formato" CssClass="form-control" MaxLength="50" runat="server" />
                                </div>
                                <asp:Button ID="Btn_guardar" Text="Guardar" CssClass="btn btn-primary" runat="server" />
                                <asp:Button ID="Btn_Actualizacion" Visible="false" Text="Actualizar" CssClass="btn btn-primary" runat="server" />
                                <asp:Button ID="Btn_Cancelar" runat="server" Text="Cancelar" Visible="false" CssClass="btn btn-primary" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Codigo Asignacion</div>
                                    <asp:TextBox ID="Txt_Cod_Asignacion" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado Plataforma</div>
                                    <asp:DropDownList ID="Drl_EstadoP" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Password de Plataforma</div>
                                    <asp:TextBox ID="Txt_Pass_Plataforma" CssClass="form-control" MaxLength="50" runat="server" />
                                </div>
                            </div>
                        </div>
                        <div class="text-center Subtitulos">Filtros de Consultas</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Codigo</div>
                                    <asp:TextBox ID="Txt_ConsultaCodigo" MaxLength="10" CssClass="form-control" runat="server" />
                                </div>
                                <asp:Panel ID="Pnl_Drl_PlataformaRed2" runat="server">
                                    <div class="input-group">
                                        <div class="input-group-addon">Plataforma Red</div>
                                        <asp:DropDownList ID="Drl_PlataformaRed2" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
                                    </div>
                                </asp:Panel>
                                <asp:Panel ID="Pnl_Drl_Plataforma2" runat="server">
                                    <div class="input-group">
                                        <div class="input-group-addon">Plataforma Usuarios</div>
                                        <asp:DropDownList ID="Drl_Plataforma2" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
                                    </div>
                                </asp:Panel>
                                <asp:Button ID="Btn_ConsultaGeneral" Text="Consultar" CssClass="btn btn-primary" runat="server" />
                                <asp:Button ID="Btn_xls" Text="Exportar" CssClass="btn btn-primary" runat="server" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Cambios de estado.<br />
                                        Rango de Fechas</div>
                                    <asp:TextBox ID="Txt_Inicio" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" Height="45px" Style="left: 0px; top: 0px" />
                                    <div class="input-group-addon">-</div>
                                    <asp:TextBox ID="Txt_Fin" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" Height="45px" Style="left: 0px; top: 0px" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado Plataforma</div>
                                    <asp:DropDownList ID="Drl_PlataformaE2" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </section>
                    <h4 style="color: #8F9E45;"><em>
                        <asp:Label runat="server">Consulta Credenciales:&nbsp;&nbsp;</asp:Label>
                        <asp:Label ID="lblcuentaCredenciales" runat="server"></asp:Label>
                    </em></h4>
                    <div class="bordes">
                        <asp:GridView ID="DtgCredenciales" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="Codigo_asignacion" HeaderText="Codigo" />
                                <asp:BoundField DataField="Codigo" HeaderText="Codigo Crm" />
                                <asp:BoundField DataField="Estado_plataforma" HeaderText="Estado Plataforma" />
                                <asp:BoundField DataField="Plataforma" HeaderText="Nombre Plataforma" />
                                <asp:BoundField DataField="Usuario_plataforma" HeaderText="Usuario" />
                                <asp:BoundField DataField="password_plataforma" HeaderText="Plataforma" />
                                <asp:BoundField DataField="Usuario_Actualiza" HeaderText="Usuario Actualiza" />
                                <asp:BoundField DataField="Fc_Actualiza" HeaderText="Fecha Actualiza" />
                                <asp:BoundField DataField="Formato" HeaderText="Formato Solicitud" />
                                <asp:BoundField DataField="fcreg" HeaderText="Fecha formato" />
                                <asp:ButtonField CommandName="Seleccion" HeaderText="Seleccion un Caso"
                                    Text="Seleccion" />
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
                    <div class="bordes">
                        <asp:GridView ID="DtgSolicitudes" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="fcreg" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="usuarioregistra" HeaderText="Registra" />
                                <asp:BoundField DataField="Formato" HeaderText="Formato Solicitud" />
                                <asp:BoundField DataField="Password_plataforma" HeaderText="Password de Plataforma" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                    </div>
                    <asp:Panel runat ="server" ID="Detalle" Visible ="false" >
                    <div class="Leyendas ">
                        <asp:Label runat="server">Consulta Detalles:</asp:Label>
                        <asp:label ID="LblCuentaDet" runat="server" Text="Exportar" Visible="False"  />
                    </div>
                    <div class="bordes">
                            <asp:GridView ID="DtgDetalle" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Id_Detalle_Plataforma" HeaderText="Id Detalle" />
                                    <asp:BoundField DataField="Usuario_Actualiza" HeaderText="Usu Actualiza" />
                                    <asp:BoundField DataField="Fc_actualiza" HeaderText="Fecha Actualiza" />
                                    <asp:BoundField DataField="Estado_Plataforma" HeaderText="Estado Plataforma" />
                                    <asp:BoundField DataField="Fk_Plataforma" HeaderText="Codigo Asignacion" />                                   
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

                </article>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="Btn_xls" />
                <asp:PostBackTrigger ControlID="Btn_guardar" />
            </Triggers>
        </asp:UpdatePanel>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>