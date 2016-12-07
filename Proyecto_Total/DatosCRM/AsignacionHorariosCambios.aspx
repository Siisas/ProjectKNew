<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AsignacionHorariosCambios.aspx.vb" Inherits="digitacion.AsignacionHorariosCambios" %>

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
                    <asp:Panel ID="Pnl_Consulta" runat="server">
                        <section>
                            <div class="text-center Subtitulos">
                                Consulta De Horario Agentes
                            </div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Codigo</div>
                                        <asp:TextBox ID="TxtCod_Agente" runat="server" CssClass="form-control" MaxLength="11" TabIndex="1"></asp:TextBox>
                                    </div>
                                    <br />
                                    <asp:Button ID="BtnConsultar" Text="Consultar" CssClass="btn btn-primary" runat="server" />
                                    <br />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Fecha Registro
                                        <asp:CompareValidator ID="CompareValidator9" runat="server" ControlToValidate="TxtFecha_Ingreso_Consulta" ErrorMessage="Revise hora" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="TxtFecha_Ingreso_Consulta" runat="server" CssClass="form-control Fecha" MaxLength="10" placeholder="DD/MM/YYYY" TabIndex="2"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </asp:Panel>
                    <section>
                        <asp:Panel ID="Pnl_Registro" runat="server">
                            <div class="text-center Subtitulos">
                                Cambios de Horario
                            </div>
                            <div class="text-center Sub-Subtitulo">
                                Laboral y/o Descanso
                            </div>
                            <br />
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:Label ID="LblCod_Registro" Width="50%" runat="server" Visible="false" Text=""></asp:Label>
                                    <asp:Label ID="Lbl_Tipo_Horario" Width="50%" runat="server" Visible="false" Text=""></asp:Label>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Fecha Ingreso
                                        <asp:CompareValidator ID="CompareValidator1" runat="server"
                                            ControlToValidate="TxtFecha_Ingreso" ErrorMessage="Revise hora"
                                            Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="TxtFecha_Ingreso" Enabled="false" placeholder="DD/MM/YYYY" MaxLength="10" CssClass="form-control Fecha" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Ingreso Antigua</div>
                                        <asp:TextBox ID="Txt_Hora_Entrada_Antigua" Enabled="false" placeholder="DD/MM/YYYY" MaxLength="10" CssClass="form-control Fecha" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Ingreso</div>
                                        <asp:DropDownList ID="Drl_Hora_Ingreso" CssClass="form-control" Enabled="false" runat="server" AutoPostBack="True" TabIndex="3" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo De Horario</div>
                                        <asp:DropDownList ID="drlTipoHorario" CssClass="form-control" Enabled="false" runat="server" AutoPostBack="True" TabIndex="5"/>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Codigo</div>
                                        <asp:Label ID="LblCod_Agente" Style="background-color: inherit" CssClass="form-control" runat="server" Text=""></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Salida Antigua</div>
                                        <asp:TextBox ID="Txt_Hora_Salida_Antigua" Enabled="false" placeholder="DD/MM/YYYY" MaxLength="10" CssClass="form-control Fecha" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Salida</div>
                                        <asp:DropDownList ID="Drl_Hora_Salida" CssClass="form-control" Enabled="false" runat="server" AutoPostBack="True" TabIndex="4"/>
                                    </div>
                                    <div class="input-group">
                                        <asp:Label ID="Lbl_Jornada" runat="server" ForeColor="#8F9E45" Font-Size="Large" Font-Italic="true" Style="background-color: inherit; border: 1.5px solid #B3C556" CssClass="form-control" Font-Bold="True"></asp:Label>
                                        <span class="input-group-btn">
                                            <asp:Button ID="Btn_Buscar_Full_Horarios" runat="server" Text="Full Hrs" Enabled="false" CssClass="btn btn-primary" ToolTip="Este Boton Activa todos los Horarios Posibles Tanto para OPERACION o AREAS DE APOYO"  TabIndex="6"/>
                                            <asp:Button ID="Btn_Buscar_Horarios_Predeterminado" runat="server" Text="Hrs Predeterminados" Enabled="false" CssClass="btn btn-primary" ToolTip="Este Boton Activa Los Horarios Predeminados Para La OPERACION" TabIndex="7"/>
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </asp:Panel>
                           <asp:Panel ID="PnlSegmmento" Visible="false" runat="server">
                            <div class="text-center Sub-Subtitulo">
                                Segmento
                            </div>
                            <br />
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:Label ID="LblSegmento1" runat="server" Visible="false" Text=""></asp:Label>
                                    <div class="input-group">
                                        <div class="input-group-addon">Segmento Solicitado</div>
                                           <asp:DropDownList ID="DrlSegmento" CssClass="form-control" TabIndex="10" ToolTip="Si esta lista esta en - Seleccione - se tomara el valor predeterminado que esta al lado"  runat="server" AutoPostBack="True"></asp:DropDownList>
                                    </div> 
                                    </div>                                   
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Segmento Actual</div>
                                              <asp:label ID="LblSegmento" runat="server" CssClass="form-control"  TabIndex="8" Enabled="false" ></asp:label>
                                        </div>
                                    </div>  
                                </div>
                            <br />
                        </asp:Panel>
                        <asp:Panel ID="PnlAlmuerzo" Visible="false" runat="server">
                            <div class="text-center Sub-Subtitulo">
                                Almuerzo
                            </div>
                            <br />
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:Label ID="Lbl_Cod_Almuerzo" runat="server" Visible="false" Text=""></asp:Label>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Ingreso</div>
                                           <asp:DropDownList ID="DrlHora_Almuerzo_1" CssClass="form-control" TabIndex="10" ToolTip="Si esta lista esta en - Seleccione - se tomara el valor predeterminado que esta al lado"  runat="server" AutoPostBack="True"></asp:DropDownList>
                                        <%--<asp:TextBox ID="DrlHora_Almuerzo_1" runat="server" CssClass="form-control Hora" MaxLength="5" placeholder="HH:mm" TabIndex="8"></asp:TextBox>--%>
                                    </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Hora Salida</div>
                                            <asp:DropDownList ID="DrlHora_Almuerzo_2" CssClass="form-control" TabIndex="10" ToolTip="Si esta lista esta en - Seleccione - se tomara el valor predeterminado que esta al lado"  runat="server" AutoPostBack="True"></asp:DropDownList>
                                            <%--<asp:TextBox ID="Txt_Hora_Almuerzo_2" runat="server" CssClass="form-control Hora" MaxLength="5" placeholder="HH:mm" TabIndex="9"></asp:TextBox>--%>
                                        </div>
                                    </div>                               
                            </div>
                            <br />
                        </asp:Panel>
                        <asp:Panel ID="PnlBreak1" Visible="false" runat="server">
                            <div class="text-center Sub-Subtitulo">
                                Break 1
                            </div>
                            <br />
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:Label ID="Lbl_Cod_Break1" runat="server" Visible="false" Text=""></asp:Label>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Ingreso</div>
                                        <asp:DropDownList ID="Drl_Hora_Break1_1" CssClass="form-control" TabIndex="10" ToolTip="Si esta lista esta en - Seleccione - se tomara el valor predeterminado que esta al lado" Width="50%" runat="server" AutoPostBack="True"></asp:DropDownList>
                                        <asp:TextBox ID="Txt_Hora_Break1_1" runat="server"  Width="50%" CssClass="form-control" MaxLength="5" placeholder="HH:mm" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Salida</div>
                                        <asp:DropDownList ID="Drl_Hora_Break1_2" TabIndex="11"  CssClass="form-control" Enabled="false" Width="50%" runat="server" AutoPostBack="True"></asp:DropDownList>
                                        <asp:TextBox ID="Txt_Hora_Break1_2" runat="server" CssClass="form-control" Enabled="false" Width="50%" MaxLength="5" placeholder="HH:mm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </asp:Panel>
                        <asp:Panel ID="PnlBreak2" Visible="false" runat="server">
                            <div class="text-center Sub-Subtitulo">
                                Break 2
                            </div>
                            <br />
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:Label ID="Lbl_Cod_Break2" runat="server" Visible="false" Text=""></asp:Label>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Ingreso</div>
                                        <asp:DropDownList ID="Drl_Hora_Break2_1" CssClass="form-control" TabIndex="12" ToolTip="Si esta lista esta en - Seleccione - se tomara el valor predeterminado que esta al lado" runat="server" Width="50%" AutoPostBack="True"></asp:DropDownList>
                                        <asp:TextBox ID="Txt_Hora_Break2_1" runat="server" Enabled="false" CssClass="form-control" Width="50%" MaxLength="5" placeholder="HH:mm"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Salida</div>
                                        <asp:DropDownList ID="Drl_Hora_Break2_2" CssClass="form-control" TabIndex="13" Enabled="false" Width="50%" runat="server" AutoPostBack="True"></asp:DropDownList>
                                        <asp:TextBox ID="Txt_Hora_Break2_2" runat="server" CssClass="form-control" Width="50%" MaxLength="5" Enabled="false" placeholder="HH:mm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </asp:Panel>
                        <asp:Panel ID="PnlCapacitacion" Visible="false" runat="server">
                            <div class="text-center Sub-Subtitulo">
                                Capacitacion
                            </div>
                            <br />
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:Label ID="Lbl_Cod_Capacitacion" runat="server" Visible="False" Text=""></asp:Label>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Ingreso</div>
                                        <asp:TextBox ID="Txt_Hora_Capacitacion_1" runat="server" TabIndex="14" CssClass="form-control Hora" MaxLength="5" placeholder="HH:mm"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Salida</div>
                                        <asp:TextBox ID="Txt_Hora_Capacitacion_2" runat="server" CssClass="form-control Hora"  TabIndex="15" MaxLength="5" placeholder="HH:mm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </asp:Panel>
                        <asp:Panel ID="PnlPreTurno" Visible="false" runat="server">
                            <div class="text-center Sub-Subtitulo">
                                Pre - Turno
                            </div>
                            <br />
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:Label ID="Lbl_Cod_Pre_turno" Visible="false" runat="server" Text=""></asp:Label>
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Ingreso</div>
                                        <asp:TextBox ID="Txt_Pre_Turno_1" runat="server" Enabled="false"  TabIndex="16" CssClass="form-control Hora" MaxLength="5" placeholder="HH:mm"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Hora Salida</div>
                                        <asp:TextBox ID="Txt_Pre_Turno_2" runat="server" Enabled="false" TabIndex="17" CssClass="form-control Hora" MaxLength="5" placeholder="HH:mm"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </asp:Panel>
                        <div class="Form">
                            <div class="Cell-Form">
                                <asp:Button ID="BtnAprobar" Text="Guardar" CssClass="btn btn-primary" runat="server" />
                                <asp:Button ID="BtnSolicitar" Text="Solicitar" CssClass="btn btn-primary" runat="server" />
                                <asp:Button ID="BtnRechazar" Text="Rechazar" CssClass="btn btn-primary" runat="server" />
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                </div>
                            </div>
                        </div>
                    </section>
                    <asp:Panel ID="Pnl_DtgGeneral" runat="server">
                        <div class="Leyendas ">
                            <asp:Label runat="server">Cantidad de Agentes:</asp:Label>
                            <asp:Label ID="LblCuenta" runat="server">0</asp:Label>
                        </div>
                        <div class="bordes">
                            <asp:GridView ID="dtgGeneral" Visible="true" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True" PageSize="10">
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_Validacion_Horario" HeaderText="ID" />
                                    <asp:BoundField DataField="Id_Usuario" HeaderText="Id Usuario Registro" />
                                    <asp:BoundField DataField="Cod_Agente" HeaderText="Codigo Agente" />
                                    <asp:BoundField DataField="Fc_Ingreso" HeaderText="Ingreso" />
                                    <asp:BoundField DataField="Fc_Salida" HeaderText="Salida" />
                                    <asp:BoundField DataField="nombre" HeaderText="Tipo Horario" />                                    
                                    <asp:BoundField DataField="Tipo_Horario" HeaderText="Cod Tipo Horario" />
                                    <asp:BoundField DataField="segmento" HeaderText="Segmento" />
                                     
                                    <asp:ButtonField ButtonType="Link" ControlStyle-CssClass="btn btn-primary  glyphicon glyphicon-eye-open" ControlStyle-Height="25px" ControlStyle-Font-Size="12px" ControlStyle-Font-Strikeout="false" ItemStyle-HorizontalAlign="Right" ControlStyle-ForeColor="White" CommandName="Seleccione" />
                                </Columns>
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                            </asp:GridView>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="Pn_Solicitudes" runat="server" Visible="True">
                        <div class="Leyendas ">
                            <asp:Label ID="Label7" runat="server">Solicitudes de Supervisores: </asp:Label>
                            <asp:Label ID="LblCuenta2" runat="server">0</asp:Label>
                        </div>
                        <div class="bordes">
                            <asp:GridView ID="dtgGeneral2" Visible="true" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True" PageSize="40">
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Fecha Registro" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="Fecha Turno" HeaderText="Fecha Turno" />
                                    <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario Registro" />
                                    <asp:BoundField DataField="Cod_Agente" HeaderText="Codigo Agente" />
                                    <asp:BoundField DataField="Estado_Solicitud" HeaderText="Estado" />
                                    <asp:ButtonField ButtonType="Link" ControlStyle-CssClass="btn btn-primary  glyphicon glyphicon-eye-open" ControlStyle-Height="25px" ItemStyle-HorizontalAlign="Right" ControlStyle-Font-Size="12px" ControlStyle-Font-Strikeout="false" ControlStyle-ForeColor="White" CommandName="Seleccione" />
                                </Columns>
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                            </asp:GridView>
                        </div>
                        <asp:GridView ID="Dtg_Solicitudes" Visible="False" runat="server" AllowPaging="False"
                            AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333"
                            GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#8F9E45" />
                        </asp:GridView>
                    </asp:Panel>
                </article>
                <footer></footer>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
