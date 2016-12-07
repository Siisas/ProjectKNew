<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Dilo_inbound.aspx.vb" Inherits="digitacion.Dilo_inbound" %>

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
                        <div class="text-center TituloCRM">CRM INBOUND DILO</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Caso
                             <asp:CompareValidator runat="server" ControlToValidate="txtcaso" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" />
                                    </div>
                                    <asp:TextBox ID="txtcaso" MaxLength="25" CssClass="form-control" runat="server" />
                                    <span id="Span1" runat="server" class="input-group-btn">
                                        <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass="btn btn-crm" />
                                    </span>
                                </div>
                            </div>
                            <%--CELDA DEL CENTRO--%>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <asp:Button ID="Btn_caso_nuevo" runat="server" Text="Caso nuevo" CssClass="btn btn-crm" />
                            </div>
                        </div>
                    </section>
                    <section>
                        <asp:Panel ID="Panel_seguimiento" runat="server" Visible="false">
                            <div class="text-center TituloCRM">REGISTRO DE SEGUIMIENTO</div>
                            <div class="Form">
                                <asp:Button Text="Guardar" ID="btnguardar" CssClass="btn btn-crm" runat="server" ValidationGroup="Crear" Enabled="false" />
                            </div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <%--ID Avaya--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            ID AVAYA
                                         <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_IDAVAYA" Display="Dynamic" ValidationGroup="Crear" ErrorMessage="*" />
                                            <asp:CompareValidator runat="server" ControlToValidate="txt_IDAVAYA" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="Crear" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{20,200}$" ControlToValidate="txt_IDAVAYA" Display="Dynamic" ValidationGroup="Crear" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_IDAVAYA" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--Numero--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Min
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_min" Display="Dynamic" ValidationGroup="Crear" ErrorMessage="*" CssClass="textoError" />
                                            <asp:RegularExpressionValidator runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txt_min" Display="Dynamic" ValidationGroup="Crear" />
                                            <asp:CompareValidator runat="server" ControlToValidate="txt_min" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="Crear" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_min" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>


                                    <%--MARCA--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Marca</div>
                                        <asp:UpdatePanel ID="UpdatePanel_Marca" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drlmarca" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--DEPARTAMENTO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Departamento</div>
                                        <asp:UpdatePanel ID="UpdatePanel_Departamento" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--BARRIO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Barrio</div>
                                        <asp:UpdatePanel ID="UpdatePanel_Barrio" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txtbarrio" runat="server" CssClass="form-control"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--ZONA--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Zona</div>
                                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drl_zona" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Rural</asp:ListItem>
                                                    <asp:ListItem>Urbana</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--CONDICIONES DE USO--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Condiciones_uso" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Condiciones de uso</div>
                                                <asp:DropDownList ID="drlFtectolog" runat="server" CssClass="form-control"></asp:DropDownList>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="Btn_Habilita_Tecnologia" runat="server" Text="Actualizar" CssClass="btn btn-crm" Visible="false" />
                                                </span>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--Formato--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:Label runat="server" ID="lbl_formato" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px">Caso</asp:Label>
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_formato" Display="Dynamic" ValidationGroup="Crear" ErrorMessage="*" />
                                            <asp:CompareValidator runat="server" ControlToValidate="txt_formato" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="Crear" />
                                            <asp:RegularExpressionValidator runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{8,200}$" ControlToValidate="txt_formato" Display="Dynamic" ValidationGroup="Crear" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_formato" runat="server" CssClass="form-control" MaxLength="8"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--Canal--%>
                                      <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Canal</div>
                                                <asp:DropDownList ID="drl_canal" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>                           
                                </div>
                                <%--CELDA DEL CENTRO--%>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <%--Nombre--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Nombre
                                         <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_nombre" Display="Dynamic" ValidationGroup="Crear" ErrorMessage="*" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control" MaxLength="150"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--Red de Distribucion--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Red de Distribucion
                                         <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_red_distribucion" Display="Dynamic" ValidationGroup="Crear" ErrorMessage="*" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_red_distribucion" runat="server" CssClass="form-control" MaxLength="80"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--EQUIPO--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Equipo" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Equipo</div>
                                                <asp:DropDownList ID="drlequipo" runat="server" CssClass="form-control"></asp:DropDownList>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="Btn_Habilita_Equipo" runat="server" Text="Actualizar" Visible="false" CssClass="btn btn-crm" />
                                                </span>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--MUNICIPIO--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Municipio" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Municipio</div>
                                                <asp:DropDownList ID="drlmun" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="Btn_Habilita_Municipio" runat="server" Text="Actualizar" CssClass="btn btn-crm" Visible="false" />
                                                </span>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--DIRECCION--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Direccion</div>
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_direccion" runat="server" CssClass="form-control"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--LINEA ALTERNA--%>
                                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    Linea alterna
                                                    <asp:CompareValidator ID="CompareValidator1" Display="Dynamic" runat="server" ControlToValidate="txtnumalt" ValidationGroup="VG_Registrar" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                                    <asp:RegularExpressionValidator ID="telefono" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txtnumalt" Display="Dynamic" CssClass="textoError" />
                                                </div>
                                                <div class="form-control" style="width: 100%; text-align: center">
                                                    <asp:RadioButton ID="chkSi" runat="server" GroupName="Numero" Text="SI" AutoPostBack="true" />
                                                    <asp:RadioButton ID="chkNo" runat="server" GroupName="Numero" Text="NO" AutoPostBack="true" />
                                                </div>
                                                <div class="input-group-addon" style="width: 2px;"></div>
                                                <div style="width: 100%">
                                                    <asp:TextBox ID="txtnumalt" runat="server" MaxLength="10" Visible="false" placeholder="Numero" CssClass="form-control"></asp:TextBox>
                                                </div>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--Falla SGSC--%>
                                    <asp:UpdatePanel runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <span class="input-group-addon">FALLA SGSC
                                                    <asp:CheckBox ID="CHKSD" runat="server" AutoPostBack="true" />
                                                </span>
                                                <asp:TextBox ID="txt_SD" runat="server" CssClass="form-control" MaxLength="9" placeholder="SD0000000" Enabled="false"></asp:TextBox>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--MESA--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Mesa</div>
                                        <asp:UpdatePanel ID="UpdatePanel_campaña" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drl_mesa" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Datos</asp:ListItem>
                                                    <asp:ListItem>Voz</asp:ListItem>
                                                    <asp:ListItem>Voz y Datos</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>   
                                                  
                                </div>
                            </div>
                            <div class="text-center TituloCRM">OBSERVACIÓN</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <%--OBSERVACION--%>
                                    <asp:TextBox ID="txtobs" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox></center>
                                </div>
                            </div>
                        </asp:Panel>
                    </section>
                    <asp:UpdatePanel runat="server" ID="Panel_consulta" Visible="false">
                        <ContentTemplate>
                            <div class="text-center TituloCRM">Consulta</div>
                                <div class="bordes" style="overflow:auto; min-height:0px; width:100%;">
                            <asp:GridView ID="DtgGeneral" runat="server" AllowPaging="True" PageSize="80" AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="150%" Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
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
                            <asp:PostBackTrigger ControlID="btnguardar" />
                        </Triggers>
                    </asp:UpdatePanel>
                </article>
            </ContentTemplate>

        </asp:UpdatePanel>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>