<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Fallamasiva.aspx.vb" Inherits="digitacion.Fallamasiva" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Julian castañeda c1595	--%>
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
                        <div class="text-center Subtitulos">Guardar Falla Masiva</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Observación</div>
                                    <asp:TextBox ID="txtobs" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipificación</div>
                                    <asp:Label ID="lbltipificacion" runat="server" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Servicio Afectado</div>
                                    <asp:DropDownList ID="drlservicio" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Marca</div>
                                    <asp:DropDownList ID="drlmarca" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Diagnóstico</div>
                                    <asp:RadioButtonList ID="rdbron" runat="server" AutoPostBack="True"
                                        CssClass="form-control" RepeatDirection="Horizontal" Font-Size="XX-Small">
                                        <asp:ListItem Selected="True" Text="Error en Registro" />
                                        <asp:ListItem Text="Ajeno a Red Celular" />
                                        <asp:ListItem Text="Asociado Red Celular" />
                                    </asp:RadioButtonList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Departamento</div>
                                    <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" CssClass="form-control">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Barrio</div>
                                    <asp:TextBox ID="txtbarrio" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo Grupo</div>
                                    <asp:DropDownList ID="drlgrupo" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <br />
                                <asp:Button ID="btnguardar" runat="server" CssClass="btn btn-primary" Text="Guardar" />
                                <asp:CheckBox ID="chkinhab" runat="server" AutoPostBack="True" Text="Inhabilitar Todas" ForeColor="#B3C556" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Variable</div>
                                    <asp:Label ID="lblvariable" runat="server" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Cierre</div>
                                    <asp:Label ID="lblcierre" runat="server" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Percepción de Falla</div>
                                    <asp:DropDownList ID="drlpercep" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Condiciones de Uso</div>
                                    <asp:DropDownList ID="drlFtectolog" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>GSM</asp:ListItem>
                                        <asp:ListItem>3G</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Equipo<asp:Label ID="lblctrl" runat="server">0</asp:Label></div>
                                    <asp:DropDownList ID="drlequipo" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon"><asp:Label runat="server" ID="Diag"></asp:Label></div>
                                    <asp:DropDownList ID="drlvariable" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Municipio</div>
                                    <asp:DropDownList ID="drlmun" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipificación Llamada</div>
                                    <asp:DropDownList ID="drltipificacionll" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo Soporte</div>
                                    <asp:DropDownList ID="drltsoporte" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
<%--<%--	© 2016 Julian castañeda C1595	--%>