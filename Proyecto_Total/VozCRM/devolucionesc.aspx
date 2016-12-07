<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="devolucionesc.aspx.vb" Inherits="digitacion.devolucionesc" %>
<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
<html>
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Kamilion ERP</title>
        <link rel="icon" href="~/favicon.ico" type="image/x-icon"/>              
        <link rel="shortcut icon" href="~/favicon.ico" type="image/x-icon"/>     
        <script type="text/javascript" src="../Css2/jquery.min.js"></script>
        <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
        <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
        <script type="text/javascript" src="../Css2/scripts.js"></script>
        <!--#########Estilos############-->
        <link type="text/css" rel="Stylesheet" href="~/Css2/Boot/css/bootstrap.min.css"/>   
        <link type="text/css" rel="Stylesheet" href="~/Css2/jquery-ui.css"/>   
        <link type="text/css" rel="Stylesheet" href="~/Css2/Kamilion.css"/>
    </head>
    <body>
        <form runat="server">
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <Control:Header ID="Header" runat="server"/>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Panel id="Pnl_Message" runat="server">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
            <article>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                    <section>
                        <div class="text-center Subtitulos">Consulta de Casos</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcaso" Display="Dynamic" Operator="DataTypeCheck" Type="Double">El caso debe ser numérico</asp:CompareValidator>
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:TextBox ID="txtcaso" CssClass="form-control" runat="server" />
                                    <span class="input-group-btn">
                                        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Buscar" />
                                    </span>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form"></div>
                        </div>
                        <div class="text-center Subtitulos">Registro de Falla de Red</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Campaña</div>
                                    <asp:Label ID="lblcampana" CssClass="form-control" runat="server"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Número Contacto</div>
                                    <asp:TextBox ID="txtFnum" CssClass="form-control" runat="server" MaxLength="10"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Equipo</div>
                                    <asp:DropDownList ID="drlequipo" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo Falla</div>
                                    <asp:TextBox ID="txtFtipofalla" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Línea Portada</div>
                                    <asp:DropDownList ID="drlFportada" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Municipio</div>
                                    <asp:DropDownList ID="drlmun" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nombre Vereda o Corregimiento</div>
                                    <asp:TextBox ID="txtFciudad" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Dirección Falla</div>
                                    <asp:TextBox ID="txtFdirecc" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">APN</div>
                                    <asp:TextBox ID="txtapn" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Lineas con falla en la Ubicación Reportada</div>
                                    <asp:DropDownList ID="drlFlineasfalla" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Observación Cliente</div>
                                    <asp:TextBox ID="txtfobs" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                                </div><h3></h3>
                                <asp:Button ID="btnguardar0" runat="server" CssClass="btn btn-primary" Text="Guardar" />
                                <asp:Button ID="BtnExportar" runat="server" CssClass="btn btn-primary" Text="Exportar" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Anula Falla de Red</div>
                                    <asp:CheckBox ID="chkanula" CssClass="form-control" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Persona Contacto</div>
                                    <asp:TextBox ID="txtFcontacto" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Marca</div>
                                    <asp:DropDownList ID="drlmarca" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tiempo Falla</div>
                                    <asp:DropDownList ID="drlFtiempo" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="&lt;=30">&lt;=30</asp:ListItem>
                                        <asp:ListItem Value="&gt;30">&gt;30</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Características de la Falla</div>
                                    <asp:DropDownList ID="drlFcaract" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Departamento</div>
                                    <asp:DropDownList ID="drldpto" CssClass="form-control" runat="server" AutoPostBack="True">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Barrio</div>
                                    <asp:TextBox ID="txtbarrio" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo Lugar</div>
                                    <asp:RadioButtonList ID="rdbvc" CssClass="form-control" RepeatDirection="Horizontal" runat="server" Font-Size="XX-Small">
                                        <asp:ListItem Value="VRD" Text="Vereda" />
                                        <asp:ListItem Value="CRG" Text="Corregimiento" />
                                        <asp:ListItem Value="INS" Text="Inspección" />
                                    </asp:RadioButtonList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tecnología</div>
                                    <asp:DropDownList ID="drlFtectolog" CssClass="form-control" runat="server">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>GSM</asp:ListItem>
                                        <asp:ListItem>3G</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Qos</div>
                                    <asp:TextBox ID="txtqos" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div><br />
                    </section>
                    <div class="Leyendas"> 
                        <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                    </div>
                    <div class="bordes">
                        <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" PageSize="80" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                            <Columns>
                                <asp:BoundField DataField="campana" HeaderText="Campaña" />
                                <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                                <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="idusuario" HeaderText="Agente Escala" />
                                <asp:BoundField DataField="fcasignado" HeaderText="Fecha Asignado" />
                                <asp:BoundField DataField="obscpd" HeaderText="Observación Devolución" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                    </div> 
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="BtnExportar" />
                    </Triggers>
                </asp:UpdatePanel>
            </article>
            <footer></footer>
        </form>
    </body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>