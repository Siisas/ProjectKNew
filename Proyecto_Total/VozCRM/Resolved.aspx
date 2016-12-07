<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Resolved.aspx.vb" Inherits="digitacion.Resolved" %>
<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
<html>
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Kamilion CRM</title>
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
        <script>
            /***********************************/
            /*Esto gestiona los 3 desplegables*/
            /*********************************/
            function Chang_Panel1() {
                PlegDes_Dinamico("#Pnl_Consulta", "slide", '', '', '');
                if ($_$("#Ico_1").attr('class') == 'Icono glyphicon glyphicon-minus-sign') {
                    $_$("#Ico_1").attr('class', 'Icono glyphicon glyphicon-plus-sign')
                } else {
                    $_$("#Ico_1").attr('class', 'Icono glyphicon glyphicon-minus-sign')
                };
            };
            function Chang_Panel3() {
                PlegDes_Dinamico("#Pnl_Registro", "slide", '', '', '');
                if ($_$("#Ico_3").attr('class') == 'Icono glyphicon glyphicon-minus-sign') {
                    $_$("#Ico_3").attr('class', 'Icono glyphicon glyphicon-plus-sign')
                } else {
                    $_$("#Ico_3").attr('class', 'Icono glyphicon glyphicon-minus-sign')
                };
            };
            /***************************************/
            /**************************************/
        </script>
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
                <section>
                        <br />       
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>  
                   <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Caso<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcaso" ErrorMessage="El caso debe ser numérico" Operator="DataTypeCheck" Type="Double" Display="Dynamic">*</asp:CompareValidator></div>
                                            <asp:TextBox ID="txtcaso" TabIndex="1" MaxLength="15" CssClass="form-control" runat="server" />
                                            <span id="Span1" runat="server" class="input-group-btn">
                                                <asp:Button ID="Button1" TabIndex="2" runat="server" Text="Buscar" CssClass=" btn btn-primary" />
                                            </span>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form"></div>
                                </div>
</ContentTemplate>
</asp:UpdatePanel>
                    <div onclick="Chang_Panel3()" class="text-center Subtitulos">
                        <div>Cierre CPD<span id="Ico_3" class="Icono glyphicon glyphicon-minus-sign"></span></div>
                    </div>
                    <asp:Panel ID="Pnl_Registro" runat="server">
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <asp:Panel ID="Pnl_Gestion" runat="server" Visible="true">
                                    <div class="Form">
                                        <div class="Cell-Form">
                                            <div class="input-group">
                                                <div class="input-group-addon">Estado CPD</div>
                                                <asp:DropDownList ID="drlestadocpd" TabIndex="13" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                            </div>
                                            <div class="input-group">
                                                <div class="input-group-addon">Estado Fallatec</div>
                                                <asp:DropDownList ID="drlfallatec" TabIndex="15" runat="server" CssClass="form-control">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>CERRADO</asp:ListItem>
                                                    <asp:ListItem>ESCALADO</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="input-group">
                                                <div class="input-group-addon">Categoria Cierre</div>
                                                <asp:DropDownList ID="drlCategoria" TabIndex="17" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="Space-Form"></div>
                                        <div class="Cell-Form">
                                            <div class="input-group">
                                                <div class="input-group-addon">Observación</div>
                                                <asp:TextBox ID="txtobs" TabIndex="14" runat="server" CssClass="form-control" MaxLength="10" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                            <div class="input-group">
                                                <div class="input-group-addon">Fallatec</div>
                                                <asp:Label ID="lblfallatec" TabIndex="16" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enabled="False" />
                                            </div>
                                        </div>
                                    </div>
                                </asp:Panel>
                                <asp:Panel ID="Pnl_remedy" runat="server" Visible="false">
                                    <div class="Form">
                                        <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado Remedy</div>
                                            <asp:DropDownList ID="drl_estado_remedy" TabIndex="18" runat="server" CssClass="form-control" AutoPostBack="True">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>Cerrado</asp:ListItem>
                                                <asp:ListItem>Pendiente</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        </div>
                                        <div class="Space-Form"></div>
                                        <div class="Cell-Form"></div>
                                    </div>
                                </asp:Panel>
                                <br />
                                <asp:Panel ID="Pnl_Cierre" runat="server" Visible="false">
                                    <div class="Form">
                                        <div class="Cell-Form">
                                            <div class="input-group">
                                                <div class="input-group-addon">Respuesta</div>
                                                <asp:DropDownList ID="drlrespuesta" TabIndex="19" runat="server" CssClass="form-control">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="input-group">
                                                <div class="input-group-addon">Estado cliente</div>
                                                <asp:DropDownList ID="drlestado_cliente" TabIndex="21" runat="server" CssClass="form-control">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Satisfecho con respuesta</asp:ListItem>
                                                    <asp:ListItem>Insatisfecho con respuesta</asp:ListItem>
                                                    <asp:ListItem>Posible desactivacion</asp:ListItem>
                                                    <asp:ListItem>No es Posible contacto con el Cliente</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="input-group">
                                                <div class="input-group-addon">CPD's Mismo Min - Misma Zona</div>
                                                <asp:DropDownList ID="drlmis_zona" TabIndex="23" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>SI</asp:ListItem>
                                                    <asp:ListItem>NO</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="Space-Form"></div>
                                        <div class="Cell-Form">
                                            <div class="input-group">
                                                <div class="input-group-addon">Se soluciono falla</div>
                                                <asp:DropDownList ID="drlSoluciono_falla" TabIndex="20" runat="server" CssClass="form-control">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>SI</asp:ListItem>
                                                    <asp:ListItem>NO</asp:ListItem>
                                                    <asp:ListItem>Cliente Portado</asp:ListItem>
                                                    <asp:ListItem>No es Posible contacto con el Cliente</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="input-group">
                                                <div class="input-group-addon">Cliente en la misma ubicacion falla</div>
                                                <asp:DropDownList ID="drlubicacion_falla" TabIndex="22" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>SI</asp:ListItem>
                                                    <asp:ListItem>NO</asp:ListItem>
                                                    <asp:ListItem>No definida - No es Posible contacto con el Cliente</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <asp:Panel ID="Pnl_drlcantidad" Visible="false" runat="server">
                                                <div class="input-group">
                                                    <div class="input-group-addon">
                                                        <asp:Label ID="lblcuantos" runat="server" Text="Cuantos"></asp:Label>
                                                    </div>
                                                    <asp:DropDownList ID="drlcantidad" TabIndex="24" runat="server" CssClass="form-control" AutoPostBack="True">
                                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                        <asp:ListItem>1</asp:ListItem>
                                                        <asp:ListItem>2</asp:ListItem>
                                                        <asp:ListItem>3</asp:ListItem>
                                                        <asp:ListItem>4</asp:ListItem>
                                                        <asp:ListItem>5</asp:ListItem>
                                                        <asp:ListItem>6</asp:ListItem>
                                                        <asp:ListItem>7</asp:ListItem>
                                                        <asp:ListItem>8</asp:ListItem>
                                                        <asp:ListItem>9</asp:ListItem>
                                                        <asp:ListItem>10</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </asp:Panel>
                                        </div>
                                    </div>
                                </asp:Panel>
                                <asp:Button ID="btnguardar" TabIndex="25" runat="server" Text="Guardar" CssClass=" btn btn-primary" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </asp:Panel>
                </section>
                <section>
                    <div onclick="Chang_Panel1()" class="text-center Subtitulos">
                        <div>Consulta de casos<span id="Ico_1" class="Icono glyphicon glyphicon-minus-sign"></span></div>
                    </div>
                    <asp:Panel ID="Pnl_Consulta" runat="server">
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>                             
                                <br />
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Caso</div>
                                            <asp:Label ID="lblcaso" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Numero Contacto</div>
                                            <asp:Label ID="lbltelcontacto" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipo de falla</div>
                                            <asp:Label ID="lbltipof" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tecnología</div>
                                            <asp:Label ID="lbltecnologia" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">APN</div>
                                            <asp:Label ID="lblapn" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado CPD</div>
                                            <asp:Label ID="lblestadocpd" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">CPD</div>
                                            <asp:Label ID="lblCPD" runat="server" CssClass="form-control" Enable="False" style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Validación de Coordenadas</div>
                                            <asp:Label ID="Lbl_Validacion_Coordenadas" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enabled="False" />
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Contacto</div>
                                            <asp:Label ID="lblcliente" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">   
                                            <div class="input-group-addon">NIT / Cedula</div>
                                            <asp:Label ID="Lbl_N_Doc_Id" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>

                                        <div class="input-group">
                                            <div class="input-group-addon">Tiempo de falla</div>
                                            <asp:Label ID="lbltiempo" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Caracteristicas Falla</div>
                                            <asp:Label ID="lblcaract" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Campaña</div>
                                            <asp:Label ID="lblcampana" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Equipo</div>
                                            <asp:Label ID="lblequipo" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado Remedy</div>
                                            <asp:Label ID="lblEstado_remedy" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                        </div>
                                        
                                    </div>
                                </div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Departamento</div>
                                            <asp:DropDownList ID="drldpto" TabIndex="4" runat="server" CssClass="form-control" AutoPostBack="True" Enabled="false"></asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Barrio</div>
                                            <asp:TextBox ID="txtbarrio" TabIndex="7" runat="server" CssClass="form-control" Text="" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Direccion</div>
                                            <asp:TextBox ID="txtdir" TabIndex="10" runat="server" CssClass="form-control" Text="" Enabled="false"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Observación</div>
                                            <asp:TextBox ID="lblobs" TabIndex="11" runat="server" CssClass="form-control" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Municipio</div>
                                            <asp:DropDownList ID="drlmun" TabIndex="5" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList>
                                            <span class="input-group-btn" style="border-radius: 5px;">
                                                <asp:Button ID="btnactualizaDepar" TabIndex="6" runat="server" CssClass="btn btn-primary" Text="Actualizar" />
                                            </span>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Vereda</div>
                                            <asp:TextBox ID="txtvereda" TabIndex="8" runat="server" CssClass="form-control" Text="" Enabled="false"></asp:TextBox>
                                            <span class="input-group-btn" style="border-radius: 5px;">
                                                <asp:Button ID="btnActualizadireccion" TabIndex="9" runat="server" CssClass="btn btn-primary" Text="Actualizar" />
                                            </span>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Más Lineas Reportadas</div>
                                            <asp:Label ID="lblmaslineas" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enabled="False" />
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Respuesta</div>
                                            <asp:TextBox ID="Lbl_Respuesta" TabIndex="12" runat="server" CssClass="form-control" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <br />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </asp:Panel>
                </section>
                <asp:UpdatePanel runat="server">
                <ContentTemplate>
                <h4 style="color: #8F9E45;"><em>
                        <asp:Label ID="Label2" runat="server">Casos Asignados Resolved y SAP:&nbsp;&nbsp;</asp:Label>
                        <asp:Label ID="Lbl_Cuenta2" runat="server"></asp:Label>
                </em></h4>
                <div class="bordes">
                    <asp:GridView ID="dtggeneral2" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="id_Control_Escalados_SD_CPD" HeaderText="ID" />
                            <asp:BoundField DataField="caso" HeaderText="Caso" />
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Supervisor que Asigno" />
                            <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Asignacion" />
                            <asp:BoundField DataField="estadocpd" HeaderText="Estado" />
                            <asp:BoundField DataField="estado_remedy" HeaderText="Estado Remedy" />
                            <asp:ButtonField CommandName="Seleccion" HeaderText="Seleccionar" ShowHeader="True" Text="Seleccionar" />
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
                <h4 style="color: #8F9E45;"><em>
                        <asp:Label ID="Lbl_Cuenta3" runat="server"></asp:Label>
                </em></h4>
                <div class="bordes">
                    <asp:GridView ID="Dtg_Gestiones" runat="server" AllowPaging="True"
                        AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True">
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
                </asp:UpdatePanel>
            </article>
            <footer></footer>
        </form>
    </body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>