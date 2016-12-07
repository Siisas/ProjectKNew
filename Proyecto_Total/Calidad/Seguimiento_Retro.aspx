<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Seguimiento_Retro.aspx.vb" Inherits="digitacion.Seguimiento_Retro" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
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
        <div id="Rechazados" class="Desplegable">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <section>
                        <div class="Form-Mini-Desp" style="width: 70%">
                          
                            <div class="text-center Subtitulos">HOMOLOGAR RETROALIMENTACION</div>
                              <asp:Panel runat="server" ID="Pnl_mensaje" Width="100%">
                                <asp:Label runat="server" ID="lbl_mensaje"></asp:Label>
                            </asp:Panel>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <%--ID Auditoria--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Id Auditoria</div>
                                        <asp:Label runat="server" ID="lbl_id_auditoria" CssClass="form-control" Style="background-color: rgba(238, 238, 238, 10); overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <%--Fecha_audoria--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha_auditoria</div>
                                        <asp:Label runat="server" ID="lbl_fc_aud" CssClass="form-control" Style="background-color: rgba(238, 238, 238, 10); overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <%--Observacion--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Observacion</div>
                                        <asp:TextBox runat="server" ID="txt_obs" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <%--ingeniero--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Ingeniero</div>
                                        <asp:Label runat="server" ID="Lbl_ingeniero" CssClass="form-control" Style="background-color: rgba(238, 238, 238, 10); overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <%--Tipo--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo</div>
                                        <asp:DropDownList ID="drl_tipo_recha" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                    </div>

                                </div>
                            </div>

                            <asp:Button ID="Btn_rechaza" runat="server" Text="Homologar" CssClass=" btn btn-primary" />
                            <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" CssClass=" btn btn-primary" />
                        </div>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

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
                        <div class="text-center Subtitulos">CONSULTA AUDITORIA</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--AUDITOR--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Auditor</div>
                                    <asp:DropDownList ID="Drl_auditor" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <%--Campaña--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Campaña</div>
                                    <asp:DropDownList ID="drl_campaña" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <%--Criticidad--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Criticidad</div>
                                    <asp:DropDownList ID="drl_criticidad" runat="server" AutoPostBack="True" CssClass="form-control">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Critico</asp:ListItem>
                                        <asp:ListItem>Urgente</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass=" btn btn-primary" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <%--ING--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Ingeniero</div>
                                    <asp:DropDownList ID="Drl_ing" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <%--Estado--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:DropDownList ID="drl_estado" runat="server" AutoPostBack="True" CssClass="form-control">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Caducado</asp:ListItem>
                                        <asp:ListItem>Vigente</asp:ListItem>
                                        <asp:ListItem>Realizado</asp:ListItem>
                                        <asp:ListItem>HOMOLOGADA</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <%--Fechas--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Fechas</div>
                                    <asp:TextBox ID="Txt_Fc_Ini" runat="server" MaxLength="10" Placeholder="DD/MM/YYYY" CssClass="form-control Fecha" />
                                    <div class="input-group-addon">-</div>
                                    <asp:TextBox ID="Txt_Fc_Fin" runat="server" MaxLength="10" Placeholder="DD/MM/YYYY" CssClass="form-control Fecha" />
                                </div>
                            </div>
                        </div>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
            <section class="DataGrids">
            </section>
            <asp:Panel ID="PanelGestiones" runat="server">
                <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                    <ContentTemplate>
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label ID="Lbl_seguimiento" runat="server"></asp:Label>&nbsp;&nbsp;
                            <asp:Button ID="btn_exportar" runat="server" Text="Exportar" CssClass=" btn btn-primary" Visible="false" />
                        </em></h4>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="300" Width="100%"
                                Style="font-size: x-small" EnableModelValidation="True" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="Id Aud" HeaderText="Id Aud"></asp:BoundField>
                                    <asp:BoundField DataField="Fecha Aud" HeaderText="Fecha Aud"></asp:BoundField>
                                    <asp:BoundField DataField="Fecha Llamada" HeaderText="Fecha Llamada"></asp:BoundField>
                                    <asp:BoundField DataField="Auditor" HeaderText="Auditor"></asp:BoundField>
                                    <asp:BoundField DataField="Codigo Ing" HeaderText="Codigo Ing"></asp:BoundField>
                                    <asp:BoundField DataField="Ingeniero" HeaderText="Ingeniero"></asp:BoundField>
                                    <asp:BoundField DataField="Caso" HeaderText="Caso"></asp:BoundField>
                                    <asp:BoundField DataField="Campa&#241;a" HeaderText="Campa&#241;a"></asp:BoundField>
                                    <asp:BoundField DataField="Calificacion" HeaderText="Calificacion"></asp:BoundField>
                                    <asp:BoundField DataField="Criticidad" HeaderText="Criticidad"></asp:BoundField>
                                    <asp:BoundField DataField="Tiempo" HeaderText="Tiempo"></asp:BoundField>
                                    <asp:BoundField DataField="Estado" HeaderText="Estado"></asp:BoundField>
                                    <asp:ButtonField ItemStyle-Width="6%" ButtonType="Link" ControlStyle-CssClass="btn btn-primary  glyphicon glyphicon-eye-open Desplegar" ControlStyle-Height="25px" ControlStyle-Font-Size="12px" ControlStyle-ForeColor="White" CommandName="Seleccionar" HeaderText="Editar" />
                                </Columns>

                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div>
                        <div class="bordes">
                                 <asp:GridView ID="dtggeneral2" runat="server" AllowPaging="True"
                                     CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="300" Width="100%"
                                     Style="font-size: x-small" EnableModelValidation="True" Visible="false">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
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
                        <asp:PostBackTrigger ControlID="btn_exportar" />
                    </Triggers>
                </asp:UpdatePanel>
            </asp:Panel>
            <br />
        </article>
        <footer></footer>
    </form>
</body>
</html>
