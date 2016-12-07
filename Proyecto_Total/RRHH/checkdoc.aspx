<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="checkdoc.aspx.vb" Inherits="digitacion.checkdoc" %>

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
        <article>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <section>
                        <div class="text-center Subtitulos">Información Base Ingreso</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Documento<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtdocumento" ErrorMessage="Campo Númerico" ValidationExpression="[0-9]*">*</asp:RegularExpressionValidator></div>
                                    <asp:TextBox ID="txtdocumento" runat="server" CssClass="form-control" TabIndex ="1"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo Documental</div>
                                    <asp:DropDownList ID="drltipodoc" runat="server" CssClass="form-control" TabIndex ="2"></asp:DropDownList>
                                </div>
                                <input id="File1" runat="server" name="File1" class="btn btn-primary" type="file" TabIndex ="4" />
                                <br />
                                <asp:Button ID="btnguardar" runat="server" CssClass="btn btn-primary" Text="Guardar" TabIndex ="5"/>
                                </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Observación</div>
                                    <asp:TextBox ID="txtobs" runat="server" CssClass="form-control" TextMode="MultiLine" TabIndex ="3"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                         <div class="bordes">
                            <asp:GridView ID="dtggeneral" Visible="true" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True" PageSize="80">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Documento">
                                        <ItemTemplate>
                                            <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.rutadoc")%>' NavigateUrl='<%#DataBinder.Eval(Container, "DataItem.rutadoc", "~/RRHH/data_check/{0}")%>' Target='_blank'></asp:HyperLink>
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
                    </section>
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID ="File1" />
                </Triggers>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>