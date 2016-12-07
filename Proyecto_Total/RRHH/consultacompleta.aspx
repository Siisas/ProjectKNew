<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consultacompleta.aspx.vb" Inherits="digitacion.consultacompleta" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
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
        <article>
            <section>
                <div class="text-center Subtitulos">
                    Datos Personales
                </div>
                <div class="Form">
                    <div class="Cell-Form">
                        <div class="input-group">
                            <div class="input-group-addon">
                                Codigo 
                            </div>
                            <asp:TextBox ID="txtcodigo" TabIndex="1" MaxLength="80" CssClass="form-control" runat="server" />
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">
                                Nombre 
                            </div>
                            <asp:TextBox ID="txtnombre" TabIndex="3" MaxLength="80" CssClass="form-control" runat="server" />
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">
                                Estado
                            </div>
                               <asp:DropDownList ID="drlestado" TabIndex="5" runat="server" CssClass="form-control">
                                    <asp:ListItem Value="0">- Elija una opción -</asp:ListItem>
                                    <asp:ListItem Value="A">Activo</asp:ListItem>
                                    <asp:ListItem Value="I">Inactivo</asp:ListItem>
                                </asp:DropDownList>
                        </div>
                    </div>
                    <div class="Space-Form"></div>
                    <div class="Cell-Form">
                        <div class="input-group">
                            <div class="input-group-addon">Documento</div>
                            <asp:TextBox ID="txtdocumento" TabIndex="2" MaxLength="80" CssClass="form-control" runat="server" />
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">Apellido</div>
                            <asp:TextBox ID="txtapellido" TabIndex="4" MaxLength="80" CssClass="form-control" runat="server" />
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">Area</div>
                          <asp:DropDownList ID="drlarea" TabIndex="6" runat="server" CssClass="form-control">
                                    <asp:ListItem Value="0">- Elija una opción -</asp:ListItem>
                                    <asp:ListItem Value="A">Activo</asp:ListItem>
                                    <asp:ListItem Value="I">Inactivo</asp:ListItem>
                                </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </section>
            <section>
                <div class="Form">
                    <div class="Cell-Form">
                        <br />
                        <asp:Button ID="btnconsultar" TabIndex="7" Text="Consultar" CssClass="btn btn-primary" runat="server" />
                        <asp:Button ID="btnxls" TabIndex="8" Text="Exportar" CssClass="btn btn-primary" runat="server" />
                    </div>
                    <div class="Space-Form"></div>
                    <div class="Cell-Form">
                    </div>
                </div>
                <br />
                <div class="Form" style="text-align: center">
                    <asp:LinkButton ForeColor="#8F9E45" ID="lnkgneral" runat="server">Ver General</asp:LinkButton>
                    &nbsp;<asp:Label ForeColor="#8F9E45" ID="lblcantgral" runat="server"></asp:Label>&nbsp;
                            <asp:LinkButton ForeColor="#8F9E45" ID="lnkhistorico" runat="server">Ver Histórico</asp:LinkButton>
                    &nbsp;<asp:Label ForeColor="#8F9E45" ID="lblcanthist" runat="server"></asp:Label>&nbsp;
                            <asp:LinkButton ForeColor="#8F9E45" ID="lnkcheck" runat="server">Ver Check</asp:LinkButton>
                    &nbsp;<asp:Label ForeColor="#8F9E45" ID="lblcantcheck" runat="server"></asp:Label>&nbsp;
                            <asp:LinkButton ForeColor="#8F9E45" ID="lnkcheck0" runat="server">Ver Novedades</asp:LinkButton>
                    &nbsp;<asp:Label ForeColor="#8F9E45" ID="lblcantnov" runat="server"></asp:Label>&nbsp;
                            <asp:LinkButton ForeColor="#8F9E45" ID="LnkHistoricoDisciplinacrio" runat="server">Ver Histórico Disciplinario</asp:LinkButton>
                    &nbsp;<asp:Label ForeColor="#8F9E45" ID="LblCantHistDis" runat="server"></asp:Label>&nbsp;
                            <asp:LinkButton ForeColor="#8F9E45" ID="LnkUsuPas" runat="server">Ver Usuarios</asp:LinkButton>
                    &nbsp;<asp:Label ForeColor="#8F9E45" ID="LblCantUsuarios" runat="server"></asp:Label>
                </div>
                <br />
            </section>
            <div class="bordes" style="overflow:auto; min-height:0px; max-height: 1000px; width:100%;">
                    <asp:GridView ID="dtgcheck" runat="server" AllowPaging="False"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True" Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:TemplateField HeaderText="Documento">
                                <ItemTemplate>
                                    <asp:HyperLink ID="HyperLink2" runat="server"
                                        Text='<%#DataBinder.Eval(Container, "DataItem.rutadoc")%>'
                                        NavigateUrl='<%#DataBinder.Eval(Container, "DataItem.rutadoc", "~/RRHH/data_check/{0}")%>'
                                        Target='_blank'></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="iddetallchek" HeaderText="ID" />
                            <asp:BoundField DataField="descripciontipodoc" HeaderText="Tipo Documento" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                        </Columns>
                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </div>
                <div class="bordes" style="overflow:auto; min-height:0px; max-height: 1000px; width:100%;">
                    <asp:GridView ID="dtghistorico" runat="server" AllowPaging="False"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True" Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idactualizacion" HeaderText="ID" />
                            <asp:BoundField DataField="tipoactualizacion" HeaderText="Actualización" />
                            <asp:BoundField DataField="descripcionact" HeaderText="Descripción" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                        </Columns>
                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </div>

                <div class="bordes" style="overflow:auto; min-height:0px; max-height: 1000px; width:100%;">
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="False"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:TemplateField HeaderText="Foto">
                                <ItemTemplate>
                                    <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.rutafoto")%>' NavigateUrl='<%#DataBinder.Eval(Container, "DataItem.rutafoto", "~/RRHH/data_fotos/{0}")%>' Target='_blank'></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Hoja de Vida">
                                <ItemTemplate>
                                    <asp:HyperLink ID="HyperLink3" ForeColor="#333333" runat="server"
                                        Text='<%#DataBinder.Eval(Container, "DataItem.rutahv")%>'
                                        NavigateUrl='<%#DataBinder.Eval(Container, "DataItem.rutahv", "~/RRHH/data_hv/{0}")%>'
                                        Target='_blank'></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="documento" HeaderText="Documento" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="Pais_Nacionalidad" HeaderText="Nacionalidad" />
                            <asp:BoundField DataField="Pais_Nacimiento" HeaderText="Pais de Nacimiento" />
                            <asp:BoundField DataField="Estado_Nacimiento" HeaderText="Estado de Nacimiento" />
                            <asp:BoundField DataField="Ciudad_Nacimiento" HeaderText="Ciudad de Nacimiento" />

                            <asp:BoundField DataField="codigo" HeaderText="Código" />
                            <asp:BoundField DataField="epsdes" HeaderText="EPS" />
                            <asp:BoundField DataField="pensiondes" HeaderText="FPS" />
                            <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                            <asp:BoundField DataField="telefono" HeaderText="Télefono" />
                            <asp:BoundField DataField="fcnac" HeaderText="Fecha Nacimiento" />
                            <asp:BoundField DataField="email" HeaderText="E-mail" />
                            <asp:BoundField DataField="genero" HeaderText="Género" />
                            <asp:BoundField DataField="estadocivil" HeaderText="Estado Civil" />
                            <asp:BoundField DataField="hijos" HeaderText="No. Hijos" />
                            <asp:BoundField DataField="cuenta" HeaderText="Cuenta" />
                            <asp:BoundField DataField="rh" HeaderText="RH" />
                            <asp:BoundField DataField="deporte" HeaderText="Deporte" />
                            <asp:BoundField DataField="escolaridad" HeaderText="Escolaridad" />
                            <asp:BoundField DataField="profesion" HeaderText="Profesion" />
                            <asp:BoundField DataField="estudia" HeaderText="Estudia?" />
                            <asp:BoundField DataField="Semestre_Actual_U" HeaderText="Semestre Actual" />
                            <asp:BoundField DataField="obs" HeaderText="Observaciones" />
                            <asp:BoundField DataField="empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Turno" HeaderText="Turno" />
                            <asp:BoundField DataField="cargo" HeaderText="Cargo Interno" />
                            <asp:BoundField DataField="Cargo_Cliente" HeaderText="Cargo Cliente" />
                            <asp:BoundField DataField="Segmento" HeaderText="Segmento" />
                            <asp:BoundField DataField="salario" HeaderText="Salario" />
                            <asp:BoundField DataField="auxtransp" HeaderText="Aux. Transporte" />
                            <asp:BoundField DataField="bonificacion" HeaderText="Bonificacion" />
                            <asp:BoundField DataField="nombreproyecto" HeaderText="Proyecto" />
                            <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="area" HeaderText="Área" />
                            <asp:BoundField DataField="tipocontrato" HeaderText="Tipo Contrato" />
                            <asp:BoundField DataField="fcing" HeaderText="Fecha Ingreso" />
                            <asp:BoundField DataField="fcretiro" HeaderText="Fecha Retiro" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="carne" HeaderText="Carné" />
                            <asp:BoundField DataField="chaleco" HeaderText="chaleco" />
                            <asp:BoundField DataField="diadema" HeaderText="diadema" />
                            <asp:BoundField DataField="locker" HeaderText="locker" />
                            <asp:BoundField DataField="uniforme" HeaderText="Uniforme" />
                        </Columns>
                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </div>

                <div class="bordes" style="overflow:auto; min-height:0px; max-height: 1000px; width:100%;">
                    <asp:GridView ID="dtgxls" runat="server" AllowPaging="False"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True" Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="documento" HeaderText="Documento" />
                            <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                            <asp:BoundField DataField="Pais_Nacionalidad" HeaderText="Nacionalidad" />
                            <asp:BoundField DataField="Pais_Nacimiento" HeaderText="Pais de Nacimiento" />
                            <asp:BoundField DataField="Estado_Nacimiento" HeaderText="Estado de Nacimiento" />
                            <asp:BoundField DataField="Ciudad_Nacimiento" HeaderText="Ciudad de Nacimiento" />

                            <asp:BoundField DataField="codigo" HeaderText="Código" />
                            <asp:BoundField DataField="epsdes" HeaderText="EPS" />
                            <asp:BoundField DataField="pensiondes" HeaderText="FPS" />
                            <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                            <asp:BoundField DataField="telefono" HeaderText="Télefono" />
                            <asp:BoundField DataField="fcnac" HeaderText="Fecha Nacimiento" />
                            <asp:BoundField DataField="email" HeaderText="E-mail" />
                            <asp:BoundField DataField="genero" HeaderText="Género" />
                            <asp:BoundField DataField="estadocivil" HeaderText="Estado Civil" />
                            <asp:BoundField DataField="hijos" HeaderText="No. Hijos" />
                            <asp:BoundField DataField="cuenta" HeaderText="Cuenta" />
                            <asp:BoundField DataField="rh" HeaderText="RH" />
                            <asp:BoundField DataField="deporte" HeaderText="Deporte" />
                            <asp:BoundField DataField="escolaridad" HeaderText="Escolaridad" />
                            <asp:BoundField DataField="profesion" HeaderText="Profesion" />
                            <asp:BoundField DataField="estudia" HeaderText="Estudia?" />
                            <asp:BoundField DataField="Semestre_Actual_U" HeaderText="Semestre Actual" />
                            <asp:BoundField DataField="obs" HeaderText="Observaciones" />
                            <asp:BoundField DataField="empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Turno" HeaderText="Turno" />
                            <asp:BoundField DataField="cargo" HeaderText="Cargo Interno" />
                            <asp:BoundField DataField="Cargo_Cliente" HeaderText="Cargo Cliente" />
                            <asp:BoundField DataField="Segmento" HeaderText="Segmento" />
                            <asp:BoundField DataField="salario" HeaderText="Salario" />
                            <asp:BoundField DataField="auxtransp" HeaderText="Aux. Transporte" />
                            <asp:BoundField DataField="bonificacion" HeaderText="Bonificacion" />
                            <asp:BoundField DataField="nombreproyecto" HeaderText="Proyecto" />
                            <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="area" HeaderText="Área" />
                            <asp:BoundField DataField="tipocontrato" HeaderText="Tipo Contrato" />
                            <asp:BoundField DataField="fcing" HeaderText="Fecha Ingreso" />
                            <asp:BoundField DataField="fcretiro" HeaderText="Fecha Retiro" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="carne" HeaderText="Carné" />
                            <asp:BoundField DataField="chaleco" HeaderText="chaleco" />
                            <asp:BoundField DataField="diadema" HeaderText="diadema" />
                            <asp:BoundField DataField="locker" HeaderText="locker" />
                            <asp:BoundField DataField="uniforme" HeaderText="Uniforme" />
                        </Columns>
                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </div>
                <div class="bordes" style="overflow:auto; min-height:0px; max-height: 1000px; width:100%;">
                    <asp:GridView ID="dtgnovedad" runat="server" AllowPaging="False"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True" Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idreg" HeaderText="ID" />
                            <asp:BoundField DataField="cod" HeaderText="Código" />
                            <asp:BoundField DataField="fcnovedad" HeaderText="Fecha Novedad" />
                            <asp:BoundField DataField="descripcioninasistencia" HeaderText="Tipo Novedad" />
                            <asp:BoundField DataField="dias" HeaderText="Dias Nov" />
                            <asp:BoundField DataField="horas" HeaderText="Horas Nov" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="repone" HeaderText="Repone" />
                            <asp:BoundField DataField="reportanom" HeaderText="Reporta Nom" />
                            <asp:BoundField DataField="desctipo" HeaderText="Tipificación" />
                            <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                            <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuarioreg" HeaderText="Usuario Reg" />
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
        </article>
    </form>
</body>
</html>
