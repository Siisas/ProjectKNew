<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Asignaciones.aspx.vb" Inherits="digitacion.Asignaciones" %>
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
                    <section><br />
                        <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px;">
                            <center>
                                <div class="btn-group btn-group-justified">
                                    <div class="btn-group">
                                        <asp:Button ID="Btn_Panel_Datos" CssClass="btn btn-primary Desplegar_Loading" Text="DATOS" runat="server" />
                                    </div>
                                    <div class="btn-group">
                                        <asp:Button ID="Btn_Panel_BSCS" CssClass="btn btn-primary Desplegar_Loading" Text="BSCS" runat="server" />
                                    </div>
                                    <div class="btn-group">
                                        <asp:Button ID="Btn_Panel_Dilo" CssClass="btn btn-primary Desplegar_Loading" Text="DILO" runat="server" />
                                    </div>
                                    <div class="btn-group">
                                        <asp:Button ID="Btn_Panel_Desact" CssClass="btn btn-primary Desplegar_Loading" Text="DESACTIVACION" runat="server" />
                                    </div>
                                    <div class="btn-group">
                                        <asp:Button ID="Btn_Panel_Inbound" CssClass="btn btn-primary Desplegar_Loading" Text="INBOUND" runat="server" />
                                    </div>
                                </div>
                            </center>
                        </div>
                        <div class="text-center Subtitulos">Asignacion de Agentes</div>
                        <asp:Label id="Lbl_Validacion" Visible="false" runat="server" />
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Agentes</div>
                                    <asp:DropDownList ID="Drl_Agentes" CssClass="form-control" runat="server"></asp:DropDownList>
                                    <span class="input-group-btn">
                                        <asp:Button ID="Btn_Agregar" CssClass="btn btn-primary" Text="Agregar" runat="server" />
                                    </span>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form"></div>
                        </div><br />
                        <div class="Form">
                            <div class="bordes">
                                <asp:GridView ID="DtgCarritoVen" runat="server" AllowPaging="false" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                    <Columns>
                                        <asp:BoundField DataField="Codigo" HeaderText="Usuario" />
                                        <asp:BoundField DataField="Agente" HeaderText="Nombre" />
                                        <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-primary" ControlStyle-Height="25px" ControlStyle-Font-Size="10px" CommandName="Delete" Text="Quitar" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </div>
                    </section>
                    <section>
                    <%--/****************************************************************************************/
                        /***************************************PANEL DE DATOS***********************************/
                        /****************************************************************************************/--%>
                        <asp:Panel ID="Pnl_Datos" Visible="true" runat="server">
                            <div class="text-center Subtitulos">Asignacion de Casos Datos</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group" style="text-align: center;">
                                        <div class="input-group-addon">Sin Asignar</div>
                                        <asp:Label Width="33.3%"  Enabled="true" CssClass="form-control" runat="server">&nbsp;&nbsp;&nbsp;Manual&nbsp;&nbsp;&nbsp;
                                            <asp:RadioButton ID="Chk_Man_Datos" Checked="true" AutoPostBack="true" GroupName="Check1" runat="server" />
                                        </asp:Label>
                                        <asp:Label Text="Reincidente" Width="33.3%"  Enabled="true" CssClass="form-control" runat="server">
                                            <asp:RadioButton ID="Chk_Rein_Datos" GroupName="Check1" AutoPostBack="true" runat="server" />
                                        </asp:Label>
                                        <asp:Label Text="Seguimiento" Width="33.3%"  Enabled="true" CssClass="form-control" runat="server">
                                            <asp:RadioButton ID="Chk_Segui_Datos" GroupName="Check1" AutoPostBack="true" runat="server" />
                                        </asp:Label>
                                        <br />
                                        <b><em><asp:Label ID="Lbl_Casos_Datos" Enabled="false" Width="33.3%" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                        <b><em><asp:Label ID="Lbl_Rein_Datos" Enabled="false" Width="33.3%" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                        <b><em><asp:Label ID="Lbl_Segui_Datos" Enabled="false" Width="33.3%" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Programados Sin Asignar</div>
                                        <b><em>
                                            <asp:Label ID="Lbl_Vig_Datos" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Black" CssClass="form-control" ></asp:Label>
                                            <asp:Label ID="Lbl_Cad_Datos" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Red" CssClass="form-control" ></asp:Label>                                                    
                                            <asp:Label ID="Lbl_Prog_Datos" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45" CssClass="form-control" ></asp:Label>
                                        </em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Bandeja</div>
                                        <asp:DropDownList ID="Drl_Bandeja_Datos" Enabled="true" CssClass="form-control" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                            <asp:ListItem Value="1" Text="Datos" />
                                            <asp:ListItem Value="2" Text="PQR" />
                                            <asp:ListItem Value="3" Text="Sin Formato" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado</div>
                                        <asp:DropDownList ID="Drl_Estado_Datos" Enabled="true" AutoPostBack="true" CssClass="form-control" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                            <asp:ListItem Value="1" Text="Abierto" />
                                            <asp:ListItem Value="2" Text="Gestionado" />
                                            <asp:ListItem Value="3" Text="No Contactado" />
                                            <asp:ListItem Value="4" Text="Programado" />
                                            <asp:ListItem Value="5" Text="Seguimiento" />
                                            <asp:ListItem Value="6" Text="Buzon" />
                                        </asp:DropDownList>
                                    </div>
                                    <asp:Panel ID="Pnl_Est_Prog" Visible="false" runat="server">
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado Programado</div>
                                            <asp:DropDownList ID="Drl_Estado_Programado" Enabled="true" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Value="1" Text="Caducado" />
                                                <asp:ListItem Value="2" Text="Vigente" />
                                            </asp:DropDownList>
                                        </div>
                                    </asp:Panel>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos a Asignar</div>
                                        <asp:TextBox ID="Txt_Casos_Datos" Enabled="true" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos Individual</div>
                                        <asp:TextBox ID="Txt_Caso_Ind_Datos" Enabled="true" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fechas</div>
                                        <asp:TextBox ID="Txt_Fc_Ini_Datos" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                        <div class="input-group-addon">-</div>
                                        <asp:TextBox ID="Txt_Fc_Fin_Datos" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                    </div><h3></h3>
                                    <asp:Button Text="Buscar" ID="Btn_Buscar_Datos" Enabled="true" CssClass="btn btn-primary Desplegar_Loading" runat="server" />&nbsp;
                                    <asp:Button Text="Asignar" ID="Btn_Asignar_Datos" Enabled="false" CssClass="btn btn-primary Desplegar_Loading" runat="server" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <h4><em><asp:Label ID="lblUsuDatos" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45"></asp:Label></em></h4>
                                    <div class="bordes" style="">
                                        <asp:GridView ID="Dtg_Estad_Datos" runat="server" AllowPaging="True" AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="10" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                            <div class="Leyendas">
                                <asp:Label ID="Lbl_Cuenta_Datos" Font-Bold="false" ForeColor="#8F9E45" runat="server" />
                            </div>
                            <div class="bordes" style="overflow: auto; width: 100%; height: 300px;">
                                <asp:GridView ID="Dtg_Casos_Datos" runat="server" AllowPaging="false" AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </asp:Panel>
                    <%--/****************************************************************************************/
                        /***************************************PANEL DE BSCS************************************/
                        /****************************************************************************************/--%>
                        <asp:Panel ID="Pnl_BSCS" Visible="False" runat="server">
                            <div class="text-center Subtitulos">Asignacion de Casos BSCS</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group" style="text-align: center;">
                                        <div class="input-group-addon">Sin Asignar</div>
                                        <asp:Label Width="33.3%"  Enabled="true" CssClass="form-control" runat="server">&nbsp;&nbsp;&nbsp;Manual&nbsp;&nbsp;&nbsp;
                                            <asp:RadioButton ID="Chk_Man_BSCS" Checked="true" AutoPostBack="true" GroupName="Check1" runat="server" />
                                        </asp:Label>
                                        <asp:Label Text="Reincidente" Width="33.3%"  Enabled="true" CssClass="form-control" runat="server">
                                            <asp:RadioButton ID="Chk_Rein_BSCS" GroupName="Check1" AutoPostBack="true" runat="server" />
                                        </asp:Label>
                                        <asp:Label Text="Seguimiento" Width="33.3%"  Enabled="true" CssClass="form-control" runat="server">
                                            <asp:RadioButton ID="Chk_Segui_BSCS" GroupName="Check1" AutoPostBack="true" runat="server" />
                                        </asp:Label>
                                        <br />
                                        <b><em><asp:Label ID="Lbl_Casos_BSCS" Enabled="false" Width="33.3%" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                        <b><em><asp:Label ID="Lbl_Rein_BSCS" Enabled="false" Width="33.3%" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                        <b><em><asp:Label ID="Lbl_Segui_BSCS" Enabled="false" Width="33.3%" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Programados Sin Asignar</div>
                                        <b><em>
                                            <asp:Label ID="Lbl_Vig_BSCS" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Black" CssClass="form-control" ></asp:Label>
                                            <asp:Label ID="Lbl_Cad_BSCS" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Red" CssClass="form-control" ></asp:Label>                                                    
                                            <asp:Label ID="Lbl_Prog_BSCS" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45" CssClass="form-control" ></asp:Label>
                                        </em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado</div>
                                        <asp:DropDownList ID="Drl_Estado_BSCS" Enabled="true" AutoPostBack="true" CssClass="form-control" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                            <asp:ListItem Value="1" Text="Abierto" />
                                            <asp:ListItem Value="2" Text="Gestionado" />
                                            <asp:ListItem Value="3" Text="No Contactado" />
                                            <asp:ListItem Value="4" Text="Programado" />
                                            <asp:ListItem Value="5" Text="Seguimiento" />
                                            <asp:ListItem Value="6" Text="Buzon" />
                                        </asp:DropDownList>
                                    </div>
                                    <asp:Panel ID="Pnl_Est_Prog_BSCS" Visible="false" runat="server">
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado Programado</div>
                                            <asp:DropDownList ID="Drl_Estado_Programado_BSCS" Enabled="true" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Value="1" Text="Caducado" />
                                                <asp:ListItem Value="2" Text="Vigente" />
                                            </asp:DropDownList>
                                        </div>
                                    </asp:Panel>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos a Asignar</div>
                                        <asp:TextBox ID="Txt_Casos_BSCS" Enabled="true" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos Individual</div>
                                        <asp:TextBox ID="Txt_Caso_Ind_BSCS" Enabled="true" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fechas</div>
                                        <asp:TextBox ID="Txt_Fc_Ini_BSCS" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                        <div class="input-group-addon">-</div>
                                        <asp:TextBox ID="Txt_Fc_Fin_BSCS" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                    </div><h3></h3>
                                    <asp:Button Text="Buscar" ID="Btn_Buscar_BSCS" Enabled="true" CssClass="btn btn-primary Desplegar_Loading" runat="server" />&nbsp;
                                    <asp:Button Text="Asignar" ID="Btn_Asignar_BSCS" Enabled="false" CssClass="btn btn-primary Desplegar_Loading" runat="server" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <h4><em><asp:Label ID="lblUsuBSCS" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45"></asp:Label></em></h4>
                                    <div class="bordes" style="">
                                        <asp:GridView ID="Dtg_Estad_BSCS" runat="server" AllowPaging="True" AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="10" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                            <div class="Leyendas">
                                <asp:Label ID="Lbl_Cuenta_BSCS" Font-Bold="false" ForeColor="#8F9E45" runat="server" />
                            </div>
                            <div class="bordes" style="overflow: auto; width: 100%; height: 300px;">
                                <asp:GridView ID="Dtg_Casos_BSCS" runat="server" AllowPaging="false" AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </asp:Panel>
                    <%--/****************************************************************************************/
                        /***************************************PANEL DE DILO************************************/
                        /****************************************************************************************/--%>
                        <asp:Panel ID="Pnl_Dilo" Visible="false" runat="server">
                            <div class="text-center Subtitulos">Asignacion de Casos Dilo</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos Sin Asignar</div>
                                        <b><em><asp:Label ID="Lbl_Casos_Dilo" Enabled="false" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Programados Sin Asignar</div>
                                        <b><em>
                                            <asp:Label ID="Lbl_Vig_Dilo" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Black" CssClass="form-control" ></asp:Label>
                                            <asp:Label ID="Lbl_Cad_Dilo" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Red" CssClass="form-control" ></asp:Label>                                                    
                                            <asp:Label ID="Lbl_Prog_Dilo" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45" CssClass="form-control" ></asp:Label>
                                        </em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado</div>
                                        <asp:DropDownList ID="Drl_Estado_Dilo" Enabled="true" AutoPostBack="true" CssClass="form-control" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                            <asp:ListItem Value="1" Text="Abierto" />
                                            <asp:ListItem Value="2" Text="Gestionado" />
                                            <asp:ListItem Value="3" Text="No Contactado" />
                                            <asp:ListItem Value="4" Text="Programado" />
                                            <asp:ListItem Value="5" Text="Seguimiento" />
                                        </asp:DropDownList>
                                    </div>
                                    <asp:Panel ID="Pnl_Est_Prog_Dilo" Visible="false" runat="server">
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado Programado</div>
                                            <asp:DropDownList ID="Drl_Estado_Programado_Dilo" Enabled="true" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Value="1" Text="Caducado" />
                                                <asp:ListItem Value="2" Text="Vigente" />
                                            </asp:DropDownList>
                                        </div>
                                    </asp:Panel>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos a Asignar</div>
                                        <asp:TextBox ID="Txt_Casos_Dilo" Enabled="true" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos Individual</div>
                                        <asp:TextBox ID="Txt_Caso_Ind_Dilo" Enabled="true" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fechas</div>
                                        <asp:TextBox ID="Txt_Fc_Ini_Dilo" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                        <div class="input-group-addon">-</div>
                                        <asp:TextBox ID="Txt_Fc_Fin_Dilo" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                    </div><h3></h3>
                                    <asp:Button Text="Buscar" ID="Btn_Buscar_Dilo" Enabled="true" CssClass="btn btn-primary Desplegar_Loading" runat="server" />&nbsp;
                                    <asp:Button Text="Asignar" ID="Btn_Asignar_Dilo" Enabled="false" CssClass="btn btn-primary Desplegar_Loading" runat="server" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="Leyendas">
                                        <asp:Label ID="lblusuDilo" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45"></asp:Label>
                                    </div>
                                    <div class="bordes" style="">
                                        <asp:GridView ID="Dtg_Estad_Dilo" runat="server" AllowPaging="True" AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="10" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                            <div class="Leyendas">
                                <asp:Label ID="Lbl_Cuenta_Dilo" Font-Bold="false" ForeColor="#8F9E45" runat="server" />
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="Dtg_Casos_Dilo" runat="server" AllowPaging="false" AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </asp:Panel>
                    <%--/****************************************************************************************/
                        /**********************************PANEL DE DESACTIVACION********************************/
                        /****************************************************************************************/--%>
                        <asp:Panel ID="Pnl_Desact" Visible="false" runat="server">
                            <div class="text-center Subtitulos">Asignacion de Casos Desactivacion</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group" style="text-align: center;">
                                        <div class="input-group-addon">Sin Asignar</div>
                                        <asp:Label Width="33.3%" Enabled="true" CssClass="form-control" runat="server">&nbsp;&nbsp;&nbsp;Manual&nbsp;&nbsp;&nbsp;
                                            <asp:RadioButton ID="Chk_Man_Desact" Checked="true" GroupName="Check" AutoPostBack="true" runat="server" />
                                        </asp:Label>
                                        <asp:Label Text="Reincidente" Width="33.3%" Enabled="true" CssClass="form-control" runat="server">
                                            <asp:RadioButton ID="Chk_Rein_Desact" GroupName="Check" AutoPostBack="true" runat="server" />
                                        </asp:Label>
                                        <asp:Label Text="Seguimiento" Width="33.3%" Enabled="true" CssClass="form-control" runat="server">
                                            <asp:RadioButton ID="Chk_Segui_Desact" GroupName="Check" AutoPostBack="true" runat="server" />
                                        </asp:Label>
                                        <br />
                                        <b><em><asp:Label ID="Lbl_Casos_Desact" Enabled="false" Width="33.3%" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                        <b><em><asp:Label ID="Lbl_Rein_Desact" Enabled="false" Width="33.3%" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                        <b><em><asp:Label ID="Lbl_Segui_Desact" Enabled="false" Width="33.3%" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Programados Sin Asignar</div>
                                        <b><em>
                                            <asp:Label ID="Lbl_Vig_Desact" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Black" CssClass="form-control"></asp:Label>
                                            <asp:Label ID="Lbl_Cad_Desact" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Red" CssClass="form-control"></asp:Label>
                                            <asp:Label ID="Lbl_Prog_Desact" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45" CssClass="form-control"></asp:Label>
                                        </em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado</div>
                                        <asp:DropDownList ID="Drl_Estado_Desact" Enabled="True" AutoPostBack="true" CssClass="form-control" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                            <asp:ListItem Value="1" Text="Abierto" />
                                            <asp:ListItem Value="2" Text="Gestionado" />
                                            <asp:ListItem Value="3" Text="No Contactado" />
                                            <asp:ListItem Value="4" Text="Programado" />
                                            <asp:ListItem Value="5" Text="Seguimiento" />
                                        </asp:DropDownList>
                                    </div>
                                    <asp:Panel ID="Pnl_Est_Prog_Desact" Visible="false" runat="server">
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado Programado</div>
                                            <asp:DropDownList ID="Drl_Estado_Programado_Desact" Enabled="true" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Value="1" Text="Caducado" />
                                                <asp:ListItem Value="2" Text="Vigente" />
                                            </asp:DropDownList>
                                        </div>
                                    </asp:Panel>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos a Asignar</div>
                                        <asp:TextBox ID="Txt_Casos_Desact" Enabled="True" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos Individual</div>
                                        <asp:TextBox ID="Txt_Caso_Ind_Desact" Enabled="True" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fechas</div>
                                        <asp:TextBox ID="Txt_Fc_Ini_Desact" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                        <div class="input-group-addon">-</div>
                                        <asp:TextBox ID="Txt_Fc_Fin_Desact" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                    </div>
                                    <h3></h3>
                                    <asp:Button Text="Buscar" ID="Btn_Buscar_Desact" Enabled="True" CssClass="btn btn-primary Desplegar_Loading" runat="server" />&nbsp;
                                    <asp:Button Text="Asignar" ID="Btn_Asignar_Desact" Enabled="false" CssClass="btn btn-primary Desplegar_Loading" runat="server" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="Leyendas">
                                            <asp:Label ID="lblusuDesac" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45"></asp:Label>
                                    </div>
                                    <div class="bordes">
                                        <asp:GridView ID="Dtg_Estad_Desact" runat="server" AllowPaging="True" AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="10" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                            <div class="Leyendas">
                                <asp:Label ID="Lbl_Cuenta_Desact" Font-Bold="false" ForeColor="#8F9E45" runat="server" />
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="Dtg_Casos_Desact" runat="server" AllowPaging="false" AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </asp:Panel>
                    <%--/****************************************************************************************/
                        /**************************************PANEL DE INBOUND**********************************/
                        /****************************************************************************************/--%>
                        <asp:Panel ID="Pnl_Inbound" Visible="false" runat="server">
                            <div class="text-center Subtitulos">Asignacion de Casos Inbound</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos Sin Asignar</div>
                                        <b><em><asp:Label ID="Lbl_Casos_Inbound" Enabled="false" Font-Size="17px" ForeColor="#8F9E45" CssClass="form-control" runat="server"></asp:Label></em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Programados Sin Asignar</div>
                                        <b><em>
                                            <asp:Label ID="Lbl_Vig_Inbound" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Black" CssClass="form-control" ></asp:Label>
                                            <asp:Label ID="Lbl_Cad_Inbound" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="Red" CssClass="form-control" ></asp:Label>                                                    
                                            <asp:Label ID="Lbl_Prog_Inbound" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45" CssClass="form-control" ></asp:Label>
                                        </em></b>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado</div>
                                        <asp:DropDownList ID="Drl_Estado_Inbound" Enabled="true" AutoPostBack="true" CssClass="form-control" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                            <asp:ListItem Value="1" Text="Abierto" />
                                            <asp:ListItem Value="2" Text="Gestionado" />
                                            <asp:ListItem Value="3" Text="No Contactado" />
                                            <asp:ListItem Value="4" Text="Programado" />
                                            <asp:ListItem Value="5" Text="Seguimiento" />
                                        </asp:DropDownList>
                                    </div>
                                    <asp:Panel ID="Pnl_Est_Prog_Inbound" Visible="false" runat="server">
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado Programado</div>
                                            <asp:DropDownList ID="Drl_Estado_Programado_Inbound" Enabled="true" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Value="1" Text="Caducado" />
                                                <asp:ListItem Value="2" Text="Vigente" />
                                            </asp:DropDownList>
                                        </div>
                                    </asp:Panel>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos a Asignar</div>
                                        <asp:TextBox ID="Txt_Casos_Inbound" Enabled="true" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Casos Individual</div>
                                        <asp:TextBox ID="Txt_Caso_Ind_Inbound" Enabled="true" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fechas</div>
                                        <asp:TextBox ID="Txt_Fc_Ini_Inbound" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                        <div class="input-group-addon">-</div>
                                        <asp:TextBox ID="Txt_Fc_Fin_Inbound" Enabled="true" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" Width="100%" runat="server" />
                                    </div><h3></h3>
                                    <asp:Button Text="Buscar" ID="Btn_Buscar_Inbound" Enabled="true" CssClass="btn btn-primary Desplegar_Loading" runat="server" />&nbsp;
                                    <asp:Button Text="Asignar" ID="Btn_Asignar_Inbound" Enabled="false" CssClass="btn btn-primary Desplegar_Loading" runat="server" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="Leyendas">
                                        <asp:Label ID="lblusuInbound" Width="33.3%" runat="server" Enabled="false" Font-Size="15px" ForeColor="#8F9E45"></asp:Label>
                                    </div>
                                    <div class="bordes" style="">
                                        <asp:GridView ID="Dtg_Estad_Inbound" runat="server" AllowPaging="True" AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="10" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                            <div class="Leyendas">
                                <asp:Label ID="Lbl_Cuenta_Inbound" Font-Bold="false" ForeColor="#8F9E45" runat="server" />
                            </div>
                            <div class="bordes">
                                <asp:GridView ID="Dtg_Casos_Inbound" runat="server" AllowPaging="false" AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </asp:Panel>
                    <%--/****************************************************************************************/--%>
                    </section>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </article>
            <footer></footer>
        </form>
    </body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>