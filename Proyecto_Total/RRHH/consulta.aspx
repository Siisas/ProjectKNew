<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consulta.aspx.vb" Inherits="digitacion.consulta" %>
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
                            <asp:TextBox ID="txtcodigo" TabIndex="1" MaxLength="7" CssClass="form-control" runat="server" />
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">
                                Nombre 
                            </div>
                            <asp:TextBox ID="txtnombre" TabIndex="3" CssClass="form-control" runat="server" />
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">
                                Estado
                            </div>
                            <asp:DropDownList ID="drlestado" TabIndex="5" CssClass="form-control" runat="server">
                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                <asp:ListItem Value="A">Activo</asp:ListItem>
                                <asp:ListItem Value="I">Inactivo</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="Space-Form"></div>
                    <div class="Cell-Form">
                        <div class="input-group">
                            <div class="input-group-addon">Documento</div>
                            <asp:TextBox ID="txtdocumento" TabIndex="2" MaxLength="15" CssClass="form-control" runat="server" />
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">Apellido</div>
                            <asp:TextBox ID="txtapellido" TabIndex="4" CssClass="form-control" runat="server" />
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">Area</div>
                            <asp:DropDownList ID="drlarea" TabIndex="6" CssClass="form-control" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                </div>
            </section>
            <section>
                <div class="text-center Subtitulos">
                    Filtro Para Memorando
                </div>
                <div class="Form">
                    <div class="Cell-Form">
                        <div class="input-group">
                            <div class="input-group-addon">Fecha Inicio</div>
                            <asp:TextBox ID="TxtFechaInicio" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" CssClass="form-control Fecha"></asp:TextBox>
                        </div>
                    </div>
                    <div class="Space-Form"></div>
                    <div class="Cell-Form">
                        <div class="input-group">
                            <div class="input-group-addon">Fecha Fin</div>
                            <asp:TextBox ID="TxtFechaFin" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" CssClass="form-control Fecha"></asp:TextBox>
                        </div>
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
                <div class="Form">
                    <div class="Cell-Form">
                        <div class="input-group">
                            <br />
                            <asp:Button ID="btnconsultar" CssClass="btn btn-primary" runat="server" Text="Consultar" />&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="btnxls" CssClass="btn btn-primary" runat="server" Text="Exportar" />
                        </div>
                    </div>
                    <div class="Space-Form"></div>
                    <div class="Cell-Form">
                    </div>
                </div>
                <br />
            </section>            
            <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 600px; width: 100%">
                <asp:GridView ID="dtgcheck" runat="server" AllowPaging="True"
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                    EnableModelValidation="True">
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
            <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
                <asp:GridView ID="dtgHistoricoDisciplinario" runat="server" AllowPaging="False"
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                    GridLines="None" Width="100%" Style="font-size: x-small"
                    EnableModelValidation="True" Visible="False">
                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="Documento" HeaderText="Documento" />
                        <asp:BoundField DataField="Grupo" HeaderText="Grupo" />
                        <asp:BoundField DataField="Código" HeaderText="Código" />
                        <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                        <asp:BoundField DataField="Disciplinario" HeaderText="Disciplinario" />
                        <asp:BoundField DataField="Descripción" HeaderText="Descripción" />
                        <asp:BoundField DataField="Usuario_Registra" HeaderText="Usuario Registra" />
                        <asp:BoundField DataField="Fecha_Registra" HeaderText="Fecha Registra" />
                    </Columns>
                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                </asp:GridView>
            </div>
            <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
                <asp:GridView ID="dtghistorico" runat="server" AllowPaging="False"
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                    GridLines="None" Width="100%" Style="font-size: x-small"
                    EnableModelValidation="True" Visible="False">
                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="idactualizacion" HeaderText="ID" />
                        <asp:BoundField DataField="tipoactualizacion" HeaderText="Actualización" />
                        <asp:BoundField DataField="descripcionact" HeaderText="Descripción" />
                        <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                        <asp:BoundField DataField="idusuario" HeaderText="Usuario Registro" />
                        <asp:BoundField DataField="Comp_Mejora" HeaderText="Compromiso de Mejora" />
                    </Columns>
                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                </asp:GridView>
            </div>
            <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
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
                        <asp:BoundField DataField="documento" HeaderText="Documento" />
                        <asp:BoundField DataField="Tipo_Doc" HeaderText="Tipo Doc" />
                        <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                        <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                        <asp:BoundField DataField="Pais_Nacionalidad" HeaderText="Nacionalidad" />
                        <asp:BoundField DataField="Pais_Nacimiento" HeaderText="Pais de Nacimiento" />
                        <asp:BoundField DataField="Estado_Nacimiento" HeaderText="Estado de Nacimiento" />
                        <asp:BoundField DataField="Ciudad_Nacimiento" HeaderText="Ciudad de Nacimiento" />
                        <asp:BoundField DataField="codigo" HeaderText="Código" />
                        <asp:BoundField DataField="Usuario_Plataforma" HeaderText="Usuario de Red" />
                        <asp:BoundField DataField="epsdes" HeaderText="EPS" />
                        <asp:BoundField DataField="pensiondes" HeaderText="FPS" />
                        <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                        <asp:BoundField DataField="telefono" HeaderText="Télefono" />
                        <asp:BoundField DataField="fcnac" HeaderText="Fecha Nacimiento" />
                        <asp:BoundField DataField="email" HeaderText="E-mail" />
                        <asp:BoundField DataField="genero" HeaderText="Género" />
                        <asp:BoundField DataField="estadocivil" HeaderText="Estado Civil" />
                        <asp:BoundField DataField="hijos" HeaderText="No. Hijos" />
                        <asp:BoundField DataField="rh" HeaderText="RH" />
                        <asp:BoundField DataField="escolaridad" HeaderText="Escolaridad" />
                        <asp:BoundField DataField="profesion" HeaderText="Profesion" />
                        <asp:BoundField DataField="estudia" HeaderText="Estudia?" />
                        <asp:BoundField DataField="Semestre_Actual_U" HeaderText="Semestre Actual" />
                        <asp:BoundField DataField="obs" HeaderText="Observaciones" />
                        <asp:BoundField DataField="empresa" HeaderText="Empresa" />
                        <asp:BoundField DataField="Turno" HeaderText="Turno" />
                        <asp:BoundField DataField="grupo" HeaderText="Grupo" />
                        <asp:BoundField DataField="cargo" HeaderText="Cargo Interno" />
                        <asp:BoundField DataField="Cargo_Cliente" HeaderText="Cargo Cliente" />
                        <asp:BoundField DataField="Segmento" HeaderText="Segmento" />
                        <asp:BoundField DataField="Descanso" HeaderText="Descanso" />
                        <asp:BoundField DataField="Jefe_Inmediato" HeaderText="Jefe Inmediato" />
                        <asp:BoundField DataField="Aclaracion" HeaderText="Aclaración" />
                        <asp:BoundField DataField="nombreproyecto" HeaderText="Operación" />
                        <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                        <asp:BoundField DataField="area" HeaderText="Área" />
                        <asp:BoundField DataField="tipocontrato" HeaderText="Tipo Contrato" />
                        <asp:BoundField DataField="fcing" HeaderText="Fecha Ingreso" />
                        <asp:BoundField DataField="fcretiro" HeaderText="Fecha Retiro" />
                        <asp:BoundField DataField="estado" HeaderText="Estado" />
                        <asp:BoundField DataField="obs" HeaderText="Observacion" />
                        <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                        <asp:BoundField DataField="carne" HeaderText="Carné" />
                        <asp:BoundField DataField="chaleco" HeaderText="Chaleco" />
                        <asp:BoundField DataField="diadema" HeaderText="Diadema" />
                        <asp:BoundField DataField="locker" HeaderText="Locker" />
                        <asp:BoundField DataField="uniforme" HeaderText="Uniforme" />
                        <asp:BoundField DataField="Pers_Contac_Emerg" HeaderText="Contacto de emergencia" />
                        <asp:BoundField DataField="Tel_Contac_Emerg" HeaderText="Telefono de emergencia" />
                        <asp:BoundField DataField="Medicamentos" HeaderText="Medicamentos" />
                        <asp:BoundField DataField="Ant_Pers_Salud" HeaderText="Antecedentes de Salud" />
                        <asp:BoundField DataField="Fecha_Inicio_Operacion" HeaderText="Inicio Operacion" />
                    </Columns>
                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                </asp:GridView>
            </div>
            <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
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
            <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
                <asp:GridView ID="dtgUsuarios" runat="server" AllowPaging="False"
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                    GridLines="None" Width="100%" Style="font-size: x-small"
                    EnableModelValidation="True" Visible="False">
                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                        <asp:BoundField DataField="Documento" HeaderText="Documento" />
                        <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                        <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                        <asp:BoundField DataField="email" HeaderText="Email" />
                        <asp:BoundField DataField="Extension" HeaderText="Extension" />
                        <asp:BoundField DataField="Usu_CRM" HeaderText="Usu CRM" />
                        <asp:BoundField DataField="Usu_Spark" HeaderText="Usu Spark" />
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
            <br />
        </article>
    </form>
</body>
</html>
