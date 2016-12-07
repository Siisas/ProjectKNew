<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InventarioCambios.aspx.vb" Inherits="digitacion.InventarioCambios" %>

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
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <article>
                    <section>
                        <div class="text-center Subtitulos">
                            Liberar Dispositivos
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Dispositivo</div>
                                    <asp:DropDownList ID="drlDispositivoLib" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Módulo</div>
                                    <asp:DropDownList ID="drlModuloLib" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Serial</div>
                                    <asp:DropDownList ID="drlSerialLib" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Observación</div>
                                    <asp:TextBox ID="TxtObservacionLib" runat="server" MaxLength="50" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                </div>
                                <asp:Button ID="Btn_Liberar" Text="Liberar" CssClass="btn btn-primary" runat="server" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:DropDownList ID="drlEstadoLib" runat="server" CssClass="form-control">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Activo</asp:ListItem>
                                        <asp:ListItem>Inactivo</asp:ListItem>
                                        <asp:ListItem>Daño</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Empresa</div>
                                    <asp:DropDownList ID="drlEmpresaLib" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Serial Kamilion</div>
                                    <asp:DropDownList ID="drlSerialKamilionLib" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </section>
                    <section>
                        <div class="text-center Subtitulos">
                            Ingresar Dispositivo
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Módulo</div>
                                    <asp:DropDownList ID="drlModuloIng" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Marca</div>
                                    <asp:DropDownList ID="drlMarca" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Empresa</div>
                                    <asp:DropDownList ID="drlEmpresa" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Serial</div>
                                    <asp:DropDownList ID="drlSerial" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <asp:Button ID="Btn_Asignar" Text="Asignar" CssClass="btn btn-primary" runat="server" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Dispositivo</div>
                                    <asp:DropDownList ID="drlDispositivoIng" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Modelo</div>
                                    <asp:DropDownList ID="drlModelo" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Serial Kamilion</div>
                                    <asp:DropDownList ID="drlSerialKamilion" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Observación</div>
                                    <asp:TextBox ID="TxtObservacionIng" runat="server" MaxLength="50" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </section>
                    <section>
                        <div class="text-center Subtitulos">
                            Cambiar Estado Dispositivo
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Dispositivo 
                                    </div>
                                    <asp:DropDownList ID="drlDispositivoEstado" runat="server" AutoPostBack="True"  CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Módulo 
                                    </div>
                                    <asp:DropDownList ID="drlModuloEstado" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Modelo
                                    </div>
                                    <asp:DropDownList ID="drlModeloEstado" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Serial Kamilion
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlSerialKamilionEstado" runat="server" AutoPostBack="True" CssClass="form-control">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Observación
                                    </div>
                                    <asp:TextBox ID="TxtObservacionEstado" runat="server" MaxLength="50" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                </div>
                                <asp:Button ID="Btn_Cambiar_Estado" Text="Cambiar Estado" CssClass="btn btn-primary" runat="server" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:DropDownList ID="drlCambioEstado" runat="server" CssClass="form-control">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Activo</asp:ListItem>
                                        <asp:ListItem>Inactivo</asp:ListItem>
                                        <asp:ListItem>Daño</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Marca</div>
                                    <asp:DropDownList ID="drlMarcaEstado" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Empresa</div>
                                    <asp:DropDownList ID="drlEmpresaEstado" runat="server" AutoPostBack="True" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Serial</div>
                                    <asp:DropDownList ID="drlSerialEstado" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </section>
                    <section>
                        <div class="text-center Subtitulos">
                            Consultas
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Modulo</div>
                                    <asp:DropDownList ID="drlModuloConsultas" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Codigo Inventario</div>
                                    <asp:TextBox ID="TxtCodigoInventario" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado del dispositivo</div>
                                    <asp:DropDownList ID="drlCambioEstadoConsulta" runat="server" CssClass="form-control">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Activo</asp:ListItem>
                                        <asp:ListItem>Inactivo</asp:ListItem>
                                        <asp:ListItem>Daño</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <asp:Button ID="Btn_Consultar_Inventario" Text="Consultar" CssClass="btn btn-primary" runat="server" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Dispositivo</div>
                                    <asp:DropDownList ID="DDrlDispositivoC"  runat="server" CssClass="form-control" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Seria</div>
                                    <asp:TextBox ID="Txt_ConsSerial" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Seria Kamilion</div>
                                    <asp:TextBox ID="Txt_ConsSerialKami" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </section>
                    <asp:Panel ID="Pnl_1" Visible="false" runat="server">
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label runat="server">CONSULTAS INVENTARIO</asp:Label>
                            <asp:Label runat="server">Numero de registros:&nbsp;&nbsp;</asp:Label>
                            <asp:Label ID="lblcantidad" runat="server"></asp:Label>
                        </em></h4>
                        <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
                            <asp:GridView ID="dtggeneral1" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="40" Width="100%" Style="font-size: x-small; text-align: center;"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_Inventario" HeaderText="Código Inventario" />
                                    <asp:BoundField DataField="Dispositivo" HeaderText="Dispositivo" />
                                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                                    <asp:BoundField DataField="Serial" HeaderText="Serial" />
                                    <asp:BoundField DataField="Serial_Kamilion" HeaderText="Serial Kamilion" />
                                    <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                                    <asp:BoundField DataField="Fk_Id_Modulo" HeaderText="Modulo" />
                                    <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario Registra" />
                                    <asp:BoundField DataField="FcReg_Invent" HeaderText="Fecha Registro" />
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
                    </asp:Panel>
                    <asp:Panel ID="Pnl_2" Visible="false" runat="server">
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label runat="server">CONSULTAS DETALLE</asp:Label>
                            <asp:Label runat="server">Numero de registros:&nbsp;&nbsp;</asp:Label>
                            <asp:Label ID="LblCantidad2" runat="server"></asp:Label>
                        </em></h4>
                        <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
                            <asp:GridView ID="dtggeneral2" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="40" Width="100%" Style="font-size: x-small; text-align: center;"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_Inventario_detalle" HeaderText="Código Detalle" />
                                    <asp:BoundField DataField="Fk_Cod_Inventario" HeaderText="Codigo Inventario" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                    <asp:BoundField DataField="Fk_ID_Modulo" HeaderText="Modulo" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario Registra" />
                                    <asp:BoundField DataField="FecReg_InventD" HeaderText="Fecha Registro" />
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
                    </asp:Panel>
                    <br />
                </article>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="Btn_Consultar_Inventario" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
