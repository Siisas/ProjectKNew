<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsCredenciales.aspx.vb"
    Inherits="digitacion.ConsCredenciales" %>

<%@ Register Src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP Kamilion - Credenciales</title>
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/scripts.js"></script>
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
    <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="~/Css2/Kamilion.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <Control:Header ID="Header" runat="server" />
        <div id="Desp_Change_Pw" class="Desplegable">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="Form-Mini-Desp">
                        <div class="Subtitulos  text-center">
                            <strong>Cambiar Contraseña</strong>
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">
                                Contraseña Actual
                                <asp:RequiredFieldValidator ID="RFV_Txb_Pw_Actual" runat="server" Display="Dynamic" ControlToValidate="Txb_Pw_Actual" ToolTip="Ingrese la contraseña actual" ValidationGroup="VlG_Pw_Change">*</asp:RequiredFieldValidator>
                            </div>
                            <asp:TextBox ID="Txb_Pw_Actual" MaxLength="15" runat="server" CssClass="form-control Txb-Pw" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">
                                Nueva Contraseña
                                <asp:RequiredFieldValidator ID="RFV_Txb_New_Pw" ValidationGroup="VlG_Pw_Change" runat="server" Display="Dynamic" ControlToValidate="Txb_New_Pw">*</asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="REV_Txb_New_Pw" ValidationGroup="VlG_Pw_Change" runat="server" Display="Dynamic" ControlToValidate="Txb_New_Pw" ValidationExpression="^.{5,15}$">*</asp:RegularExpressionValidator>
                            </div>
                            <asp:TextBox ID="Txb_New_Pw" MaxLength="16" minlength="5" ToolTip="La nueva contraseña debe tener de 5 a 15 caracteres" runat="server" ShowMessageBox="false" placeholder="5 a 15 caracteres" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="input-group">
                            <div class="input-group-addon">
                                Confirmar Contraseña
                                <asp:RequiredFieldValidator ID="RFV_Txb_Check_Pw" ValidationGroup="VlG_Pw_Change" runat="server" Display="Dynamic" ControlToValidate="Txb_Check_Pw">*</asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CV_Txb_Check_Pw" runat="server" ValidationGroup="VlG_Pw_Change" Display="Dynamic" ControlToValidate="Txb_Check_Pw" ControlToCompare="Txb_New_Pw">*</asp:CompareValidator>
                            </div>
                            <asp:TextBox ID="Txb_Check_Pw" MaxLength="16" minlength="5" runat="server" CssClass="form-control" TextMode="Password" ToolTip="Confirme la nueva contraseña"></asp:TextBox>
                        </div>
                        <asp:Button runat="server" ID="Btn_Change_Pw_Ok" Text="Cambiar" ValidationGroup="VlG_Pw_Change" CssClass="Desplegar2 btn btn-primary" />
                        <button class="Desplegar btn btn-primary" type="button" onclick="PlegDes_Dinamico('#Desp_Change_Pw', 'slide', '', '', '');" >Cerrar</button>
                        <asp:Panel runat="server" Id="Pnl_Msg_Error_Pw">
                            <asp:Label ID="Lbl_Msg_Error_Pw" CssClass="alert Center" runat="server"></asp:Label>
                        </asp:Panel>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:panel runat="server"  id="Pnl_Alerta">
                    <asp:Label ID="Lbl_Alerta" runat="server"></asp:Label>
                </asp:panel>
                <article>
                    <section>
                        <div class="text-center Subtitulos">
                            Consulta Plataformas y Credenciales
                        </div>
                        <button class="btn btn-primary" type="button" onclick="PlegDes_Dinamico('#Desp_Change_Pw', 'slide', '', '', '');" value="Cambiar Pw CRM/ERP" >Cambiar Pw CRM/ERP</button>
                        <br/>
                        <br/>
                        <div class="bordes">
                            <asp:GridView ID="DtgVisualizar" runat="server" AllowPaging="True" CellPadding="4"
                                ForeColor="#333333" GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True" AutoGenerateColumns="False">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                <Columns>
                                    <asp:BoundField DataField="Fk_codnom" HeaderText="Usuario Crm" />
                                    <asp:BoundField DataField="Nombre" HeaderText="Plataforma" />
                                    <asp:BoundField DataField="Usuario_Plataforma" HeaderText="Usuario Plataforma" />
                                    <asp:BoundField DataField="Password_plataforma" HeaderText="Password Plataforma" />
                                    <asp:BoundField DataField="Estado_Plataforma" HeaderText="Estado Plataforma" />
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
                        <div class="text-center Subtitulos">
                            consultar Activos Asignados
                        </div>
                        <div class="bordes">
                            <asp:GridView ID="DtgVisualizarAct" runat="server" AllowPaging="True" CellPadding="4"
                                ForeColor="#333333" GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True" AutoGenerateColumns="False">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Underline="False" />
                                <Columns>
                                    <asp:BoundField DataField="sub_responsable" HeaderText="Usuario " />
                                    <asp:BoundField DataField="Nombre_Activo" HeaderText="Activo" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado Activo" />
                                    <asp:BoundField DataField="serial" HeaderText="Serial Activo" />
                                    <asp:BoundField DataField="Cod_Inventario_Activos" HeaderText="Cod inventario" />
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
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>

    </form>
</body>
</html>
