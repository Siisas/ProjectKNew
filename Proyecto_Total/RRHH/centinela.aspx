<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="centinela.aspx.vb" Inherits="digitacion.centinela" %>

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
        <div id="Desp_General" class="Desplegable">
            <div class="Dialog-Confirm">
                <div class="text-center Subtitulos">
                    <strong>ADVERTENCIA</strong>
                </div>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Label ForeColor="White" ID="Lbl_Msgdesp" runat="server" />
                        <div>
                            <asp:Button runat="server" ID="Btn_Si" Text="SI" CssClass=" btn btn-primary" />
                            <input type="button" id="Btn_No" value="NO" onclick="PlegDes_Dinamico('#Desp_General', 'slide', '', '', '');" class="btn btn-primary" />
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
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
                        <br />
                        <div class="input-group">
                            <asp:LinkButton ID="LinkButtoncentinela" ForeColor="#8F9E45" runat="server" CssClass="linkbutton">Centinela</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;         
                        <asp:LinkButton ID="LinkButtonbreak" ForeColor="#8F9E45" runat="server" CssClass="linkbutton">Break</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="LinkButtonalmuerzo" ForeColor="#8F9E45" runat="server" CssClass="linkbutton">Almuerzo</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="LinkButtoncapacitacion" ForeColor="#8F9E45" runat="server" CssClass="linkbutton">Capacitación</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="LinkButtonpreturno" ForeColor="#8F9E45" runat="server" CssClass="linkbutton">Pre-turno</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="LinkButtonocultar" ForeColor="#8F9E45" runat="server" CssClass="linkbutton">Ocultar</asp:LinkButton>
                        </div>
                        <br />
                    </section>
                    <asp:Panel ID="Pnbreaks" runat="server" Visible="false">
                        <section>
                            <div class="input-group">
                                <asp:LinkButton ID="LinkButtonbreak1" ForeColor="#8F9E45" runat="server" CssClass="linkbutton">Break 1&nbsp;&nbsp;&nbsp;</asp:LinkButton>
                                <asp:LinkButton ID="LinkButtonbreak2" ForeColor="#8F9E45" runat="server" CssClass="linkbutton">Break 2</asp:LinkButton>
                            </div>
                        </section>
                    </asp:Panel>
                    <asp:Panel ID="Pncentinela" runat="server" Visible="TRUE">
                        <section>
                            <h4 style="color: #8F9E45;"><em>
                                <asp:Label ID="Label1" runat="server">Registro de Entrada y Salida Centinela:&nbsp;&nbsp;</asp:Label>
                            </em></h4>
                            <h4>
                                <asp:Button ID="BtnGuardar" runat="server" Text="Registrar" CssClass="btn btn-primary" /></h4>
                            <h4><em style="color: #8F9E45">&nbsp;Ultimos 30 registros</em></h4>
                            <div class="bordes">
                                <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="idcent" HeaderText="ID" />
                                        <asp:BoundField DataField="idusuario" HeaderText="Código" />
                                        <asp:BoundField DataField="fcingreso" HeaderText="Fecha Ingreso" />
                                        <asp:BoundField DataField="fcsalida" HeaderText="Fecha Salida" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                            <div class="Leyendas ">
                                <asp:Label ID="Label2" runat="server">Registros de Malla de turno:</asp:Label>
                                <asp:Label ID="LblCuenta" runat="server" ForeColor="#8F9E45"></asp:Label>
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="dtgMallaTurno" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Cod_Validacion_Horario" HeaderText="ID Registro" />
                                        <asp:BoundField DataField="Cod_Agente" HeaderText="Código" />
                                        <asp:BoundField DataField="Fc_Ingreso" HeaderText="Fecha Ingreso" />
                                        <asp:BoundField DataField="Fc_Salida" HeaderText="Fecha Salida" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Tipo" />
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
                    </asp:Panel>
                    <asp:Panel ID="Pnbreak" runat="server" Visible="false">
                        <section>
                            <h4 style="color: #8F9E45;"><em>
                                <asp:Label ID="Lblbreak" runat="server">Registro de Entrada y Salida Break:&nbsp;&nbsp;</asp:Label>
                            </em></h4>
                            <h4>
                                <asp:Button ID="Btnregistrarbreak" runat="server" Text="Registrar" CssClass="btn btn-primary" /></h4>
                            <h4><em style="color: #8F9E45">&nbsp;Ultimos 30 registros</em></h4>
                            <div class="bordes">
                                <asp:GridView ID="Dtgbreak" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="2000" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="idcent" HeaderText="ID" />
                                        <asp:BoundField DataField="idusuario" HeaderText="Código" />
                                        <asp:BoundField DataField="fcingreso" HeaderText="Break 1 Salida" />
                                        <asp:BoundField DataField="fcsalida" HeaderText="Break 1 Entrada" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                            <div class="Leyendas ">
                                <asp:Label ID="Label4" runat="server">Registros de Malla de turno:</asp:Label>
                                <asp:Label ID="Lblcuentamallabreak" runat="server" ForeColor="#8F9E45"></asp:Label>
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="Dtgmallaturnobreak" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Cod_Validacion_Horario" HeaderText="ID Registro" />
                                        <asp:BoundField DataField="Cod_Agente" HeaderText="Código" />
                                        <asp:BoundField DataField="Fc_Ingreso" HeaderText="Fecha Ingreso" />
                                        <asp:BoundField DataField="Fc_Salida" HeaderText="Fecha Salida" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Tipo" />
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
                    </asp:Panel>
                    <asp:Panel ID="Pnalmuerzo" runat="server" Visible="false">
                        <section>
                            <h4 style="color: #8F9E45;"><em>
                                <asp:Label ID="Lblalmuerzo" runat="server">Registro de Entrada y Salida Almuerzo:&nbsp;&nbsp;</asp:Label>
                            </em></h4>
                            <h4>
                                <asp:Button ID="Btnregistraralmuerzo" runat="server" Text="Registrar" CssClass="btn btn-primary" /></h4>
                            <h4><em style="color: #8F9E45">&nbsp;Ultimos 30 registros</em></h4>
                            <div class="bordes">
                                <asp:GridView ID="Dtgalmuerzo" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="idcent" HeaderText="ID" />
                                        <asp:BoundField DataField="idusuario" HeaderText="Código" />
                                        <asp:BoundField DataField="fcingreso" HeaderText="Salida Almuerzo" />
                                        <asp:BoundField DataField="fcsalida" HeaderText="Entrada Almuerzo" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                            <div class="Leyendas ">
                                <asp:Label ID="Label6" runat="server">Registros de Malla de turno:</asp:Label>
                                <asp:Label ID="Llblcuentamallaalmuerzo" runat="server" ForeColor="#8F9E45"></asp:Label>
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="Dtgmallaturnoalmuerzo" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Cod_Validacion_Horario" HeaderText="ID Registro" />
                                        <asp:BoundField DataField="Cod_Agente" HeaderText="Código" />
                                        <asp:BoundField DataField="Fc_Ingreso" HeaderText="Fecha Ingreso" />
                                        <asp:BoundField DataField="Fc_Salida" HeaderText="Fecha Salida" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Tipo" />
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
                    </asp:Panel>
                    <asp:Panel ID="Pncapacitación" runat="server" Visible="false">
                        <section>
                            <h4 style="color: #8F9E45;"><em>
                                <asp:Label ID="Lblcapacitacion" runat="server">Registro de Entrada y Salida Capacitación:&nbsp;&nbsp;</asp:Label>
                            </em></h4>
                            <h4>
                                <asp:Button ID="Btnregistrarcapacitacion" runat="server" Text="Registrar" CssClass="btn btn-primary" /></h4>
                            <h4><em style="color: #8F9E45">&nbsp;Ultimos 30 registros</em></h4>
                            <div class="bordes">
                                <asp:GridView ID="Dtgcapacitacion" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="idcent" HeaderText="ID" />
                                        <asp:BoundField DataField="idusuario" HeaderText="Código" />
                                        <asp:BoundField DataField="fcingreso" HeaderText="Entrada Capacitación" />
                                        <asp:BoundField DataField="fcsalida" HeaderText="Salida Capacitación" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                            <div class="Leyendas ">
                                <asp:Label ID="Label9" runat="server">Registros de Malla de turno:</asp:Label>
                                <asp:Label ID="lblcuentamallacapacitacion" runat="server" ForeColor="#8F9E45"></asp:Label>
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="Dtgmallaturnocapacitacion" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Cod_Validacion_Horario" HeaderText="ID Registro" />
                                        <asp:BoundField DataField="Cod_Agente" HeaderText="Código" />
                                        <asp:BoundField DataField="Fc_Ingreso" HeaderText="Fecha Ingreso" />
                                        <asp:BoundField DataField="Fc_Salida" HeaderText="Fecha Salida" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Tipo" />
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
                    </asp:Panel>
                    <asp:Panel ID="Pnpreturno" runat="server" Visible="false">
                        <section>
                            <h4 style="color: #8F9E45;"><em>
                                <asp:Label ID="Lblpreturno" runat="server">Registro de Entrada y Salida Pre-turno:&nbsp;&nbsp;</asp:Label>
                            </em></h4>
                            <h4>
                                <asp:Button ID="Btnregistrarpreturno" runat="server" Text="Registrar" CssClass="btn btn-primary" /></h4>
                            <h4><em style="color: #8F9E45">&nbsp;Ultimos 30 registros</em></h4>
                            <div class="bordes">
                                <asp:GridView ID="Dtgpreturno" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="idcent" HeaderText="ID" />
                                        <asp:BoundField DataField="idusuario" HeaderText="Código" />
                                        <asp:BoundField DataField="fcingreso" HeaderText="Entrada Pre-turno" />
                                        <asp:BoundField DataField="fcsalida" HeaderText="Salida pre-turno" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                            <div class="Leyendas">
                                <asp:Label ID="Label11" runat="server">Registros de Malla de turno:</asp:Label>
                                <asp:Label ID="lblcuentamallapreturno" runat="server" ForeColor="#8F9E45"></asp:Label>
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="dtgmallaturnopreturno" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Cod_Validacion_Horario" HeaderText="ID Registro" />
                                        <asp:BoundField DataField="Cod_Agente" HeaderText="Código" />
                                        <asp:BoundField DataField="Fc_Ingreso" HeaderText="Fecha Ingreso" />
                                        <asp:BoundField DataField="Fc_Salida" HeaderText="Fecha Salida" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Tipo" />
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
                    </asp:Panel>
                    <asp:Panel ID="Pnbreak2" runat="server" Visible="False">
                        <section>
                            <h4 style="color: #8F9E45;"><em>
                                <asp:Label ID="Lblbreak2" runat="server">Registro de Entrada y Salida Break 2:&nbsp;&nbsp;</asp:Label>
                            </em></h4>
                            <h4>
                                <asp:Button ID="Btnbreakdosregistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" /></h4>
                            <h4><em style="color: #8F9E45">&nbsp;Ultimos 30 registros</em></h4>
                            <div class="bordes">
                                <asp:GridView ID="dtgbreak2" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="idcent" HeaderText="ID" />
                                        <asp:BoundField DataField="idusuario" HeaderText="Código" />
                                        <asp:BoundField DataField="fcingreso" HeaderText="Break 2 Salida" />
                                        <asp:BoundField DataField="fcsalida" HeaderText="Break 2 Entrada" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                            <div class="Leyendas">
                                <asp:Label ID="Label15" runat="server">Registros de Malla de turno:</asp:Label>
                                <asp:Label ID="Lblcuentamallabreakdos" runat="server" ForeColor="#8F9E45"></asp:Label>
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="Dtgmallaturnobreakdos" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="30" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Cod_Validacion_Horario" HeaderText="ID Registro" />
                                        <asp:BoundField DataField="Cod_Agente" HeaderText="Código" />
                                        <asp:BoundField DataField="Fc_Ingreso" HeaderText="Fecha Ingreso" />
                                        <asp:BoundField DataField="Fc_Salida" HeaderText="Fecha Salida" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Tipo" />
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
                    </asp:Panel>                        
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>