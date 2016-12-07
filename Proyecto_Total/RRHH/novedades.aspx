<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="novedades.aspx.vb" Inherits="digitacion.novedades" %>

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
                <article>
                    <section>
                        <div class="text-center Subtitulos">
                            Registro de Novedades
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Codigo 
                                    </div>
                                    <asp:TextBox ID="txtcod" MaxLength="10" TabIndex="1" CssClass="form-control" runat="server" />
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnvalidar" Text="Validar" TabIndex="2" CssClass="btn btn-primary" runat="server" />
                                    </span>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Nombre 
                                    </div>
                                    <asp:Label Style="background-color: inherit" TabIndex="4" ID="lblnombre" runat="server" CssClass="form-control" Width="85%" />
                                    <asp:Label Style="background-color: inherit" TabIndex="5" ID="lblred" runat="server" CssClass="form-control" Width="15%" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Mes Reportado 
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="lblmes" TabIndex="7" runat="server" CssClass="form-control" />
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Identificación</div>
                                    <asp:Label ID="LblDocumento" TabIndex="3" runat="server" CssClass="form-control" Enabled="false"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">ID modificar</div>
                                    <asp:TextBox ID="txtid" TabIndex="6" MaxLength="80" CssClass="form-control" runat="server" />
                                </div>
                                
                            </div>
                        </div>
                        <div class="Separator"></div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Novedad 
                                    <asp:CompareValidator ID="CompareValidator1" runat="server"
                                        ControlToValidate="txtfcnov" ErrorMessage="La fecha no es válida"
                                        Operator="DataTypeCheck" Type="Date" Display="Dynamic">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txtfcnov" TabIndex="9" MaxLength="10" CssClass="form-control Fecha" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Novedad
                                    </div>
                                    <asp:DropDownList ID="drltiponov" TabIndex="11" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tiempo
                                    </div>
                                    <div class="input-group-addon">
                                        Dias
                                    </div>
                                    <asp:TextBox ID="txtdia" MaxLength="5" TabIndex="13" CssClass="form-control" runat="server" />
                                    <div class="input-group-addon">
                                        Horas
                                     <asp:CompareValidator ID="Cvtxthora" runat="server" Display="Dynamic" ControlToValidate="txthora" ErrorMessage="usted necesita espesificar un numero" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txthora" MaxLength="5" TabIndex="14" CssClass="form-control" runat="server" />

                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Repone 
                                    </div>
                                    <asp:Label  TabIndex="16" Style="background-color: inherit" ID="Label2" runat="server" CssClass="form-control">
                                        <asp:RadioButtonList ID="rdbrepone" RepeatDirection="Horizontal" runat="server" Width="88px">
                                            <asp:ListItem>Si</asp:ListItem>
                                            <asp:ListItem>No</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Codigo 
                                    </div>
                                    <asp:TextBox ID="TxtCodigoMedicina"  TabIndex="18" runat="server" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-btn">
                                        <asp:Button ID="BtnConsultaCodMedico"  TabIndex="19" runat="server" Text="Consultar" CssClass="btn btn-primary" />
                                    </span>
                                </div>
                                <asp:Button ID="btnguardar"  TabIndex="21" Text="Guardar" CssClass="btn btn-primary" runat="server" />
                                  <asp:Button ID="btnactualiza" TabIndex="24" Text="Actualizar" CssClass="btn btn-primary" runat="server" visible="false" />
                                  <asp:Button ID="BtnCancelar" TabIndex="25" Text="Cancelar" CssClass="btn btn-primary" runat="server" visible="false" />
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                 <div class="input-group">
                                    <div class="input-group-addon">Diagnostico EPS</div>
                                    <asp:Label  TabIndex="10" Style="background-color: inherit" ID="LblDiagnostico" runat="server" CssClass="form-control" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tipo Novedad</div>
                                    <asp:DropDownList  TabIndex="12" ID="drltipificacion" CssClass="form-control" runat="server" AutoPostBack="True" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:TextBox ID="txtestado"  TabIndex="15" CssClass="form-control" runat="server" />
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Reporta Nomina</div>
                                    <asp:Label  TabIndex="17" Style="background-color: inherit" ID="Label3" runat="server" CssClass="form-control">
                                        <asp:RadioButtonList ID="rdbreporta" RepeatDirection="Horizontal" runat="server">
                                            <asp:ListItem>Si</asp:ListItem>
                                            <asp:ListItem>No</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Observaciones</div>
                                    <asp:TextBox ID="txtobs"  TabIndex="20" TextMode="MultiLine" CssClass="form-control" runat="server" />
                                </div>
                            </div>
                        </div>
                    </section>
                                    <section>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="text-center Subtitulos">
                                    Registro masivo
                                </div>
                                <div class="input-group">
                                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnregistroM" runat="server" Text="Registrar" CssClass="btn btn-primary" />
                                    </span>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="text-center Subtitulos">
                                    Historial Modificaciones Novedad
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Historial Nov. 
                                    </div>
                                    <asp:TextBox ID="txt_HistorialNov" TabIndex="21" runat="server" CssClass="form-control" ToolTip="Ingrese el Id de la novedad a consultar"></asp:TextBox>
                                    <span class="input-group-btn">
                                        <asp:Button ID="Btn_Historial" TabIndex="22" runat="server" Text="Consultar" CssClass="btn btn-primary" />
                                    </span>
                                </div>
                            </div>
                        </div>
                    </section>

                    <asp:Panel runat="server" Visible="false" ID="panel1">
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label ID="Label1" runat="server">Detalle Novedades por usuario:&nbsp;&nbsp;</asp:Label>
                            <asp:Label ID="Lblcuenta" runat="server"></asp:Label>
                        </em></h4>
                        <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 600px; width: 100%">
                            <asp:GridView ID="dtggeneral" runat="server"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="idreg" HeaderText="ID" />
                                    <asp:BoundField DataField="cod" HeaderText="Código" />
                                    <asp:BoundField DataField="fcnovedad" HeaderText="Fecha Novedad" />
                                    <asp:BoundField DataField="descripcioninasistencia" HeaderText="Tipo Novedad" />
                                    <asp:BoundField DataField="dias" HeaderText="Dias Nov" />
                                    <asp:BoundField DataField="horas" HeaderText="Horas Nov" />
                                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="repone" HeaderText="Repone" />
                                    <asp:BoundField DataField="reportanom" HeaderText="Reporta Nom" />
                                    <asp:BoundField DataField="desctipo" HeaderText="Tipificación" />
                                    <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                                    <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="idusuarioreg" HeaderText="Usuario Reg" />
                                    <asp:BoundField DataField="mesreporte" HeaderText="Mes Reportado" />
                                </Columns>
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div>
                    </asp:Panel>
                    <asp:Panel runat="server" Visible="false" ID="panel2">
                        <h4 style="color: #8F9E45;"><em>
                            <asp:Label ID="Label4" runat="server">Modificaciones realizadas:&nbsp;&nbsp;</asp:Label>
                            <asp:Label ID="Lbl_CantidadHis" runat="server"></asp:Label>
                        </em></h4>
                        <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 600px; width: 100%">
                            <asp:GridView ID="dtgHistorial" runat="server"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_Cambio" HeaderText="Cons" />
                                    <asp:BoundField DataField="Id_Novedad" HeaderText="Id Nov" />
                                    <asp:BoundField DataField="Codigo_Usuario" HeaderText="Cod Usuario" />
                                    <asp:BoundField DataField="Fc_Ing_Novedad" HeaderText="Fecha Novedad" />
                                    <asp:BoundField DataField="Tipo_Novedad" HeaderText="Tipo" />
                                    <asp:BoundField DataField="Dias_Novedad" HeaderText="Dias" />
                                    <asp:BoundField DataField="Horas_Novedad" HeaderText="Horas" />
                                    <asp:BoundField DataField="Repone" HeaderText="Repone" />
                                    <asp:BoundField DataField="Repone_Nomina" HeaderText="Repone Nom" />
                                    <asp:BoundField DataField="Tipificaciones" HeaderText="Tipificación" />
                                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                                    <asp:BoundField DataField="Fc_Registro_Cambio" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="usuario_registra_Cambio" HeaderText="Usuario Reg" />
                                    <asp:BoundField DataField="Mes_Reportado" HeaderText="Mes Reportado" />
                                </Columns>
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div>
                    </asp:Panel>

                </article>
                <footer></footer>
            </ContentTemplate>
             <Triggers>
                <asp:PostBackTrigger ControlID="btnregistroM" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
