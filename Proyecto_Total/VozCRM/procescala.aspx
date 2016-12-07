<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="procescala.aspx.vb" Inherits="digitacion.procescala" %>
<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>

<!DOCTYPE html>
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
                        <section><h4></h4>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:CompareValidator ID="CompareValidator1" runat="server"
                                                ControlToValidate="txtcaso" ErrorMessage="El caso debe ser numérico"
                                                Operator="DataTypeCheck" Type="Double" Display="Dynamic">*</asp:CompareValidator>
                                            Caso:
                                        </div>
                                        <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                        <span runat="server" class="input-group-btn">
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                                        </span>
                                    </div>
                                   <asp:Label ID ="mensaje" runat ="server" ></asp:Label>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form"></div>
                            </div>
                            <div class="text-center Subtitulos">Registro de Escalamiento</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">CPD</div>
                                        <asp:TextBox ID="txtcpd" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Devolver</div>
                                        <asp:CheckBox ID="chkdev" runat="server" CssClass="form-control" />
                                    </div><h4></h4>
                                    <asp:Button ID="btnguardar" runat="server" Text="Guardar" CssClass="btn btn-primary" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Grupo Asignado</div>
                                        <asp:DropDownList ID="DrlGrupo_Asignado" AutoPostBack="True" CssClass="form-control" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Observación</div>
                                        <asp:TextBox ID="txtobs" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center Subtitulos">Informacion del Caso</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Campaña </div>
                                        <asp:Label ID="lblcampana" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Caso </div>
                                        <asp:Label ID="lblcaso" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Número Contacto </div>
                                        <asp:Label ID="lbltelcontacto" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo Falla </div>
                                        <asp:Label ID="lbltipof" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Departamento </div>
                                        <asp:Label ID="lbldpto" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Vereda Correg </div>
                                        <asp:Label ID="lblvereda" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Barrio </div>
                                        <asp:Label ID="lblbarrio" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Equipo </div>
                                        <asp:Label ID="lblequipo" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Más Lineas Reportadas </div>
                                        <asp:Label ID="lblmaslineas" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Canal Dilo </div>
                                        <asp:Label ID="LblCanal" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Call Remite </div>
                                        <asp:Label ID="LblCall_Remite" runat="server"  CssClass="form-control" />
                                        <asp:Label ID="LblValidacion" runat="server" CssClass="form-control " Visible ="false"  />

                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Min </div>
                                        <asp:Label ID="lblmin" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Contacto </div>
                                        <asp:Label ID="lblcliente" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">NIT / Cedula</div>
                                        <asp:Label ID="Lbl_N_Doc_Id" runat="server" CssClass="form-control" ></asp:Label>
                                    </div>

                                    <div class="input-group">
                                        <div class="input-group-addon">Tiempo falla </div>
                                        <asp:Label ID="lbltiempo" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Características Falla </div>
                                        <asp:Label ID="lblcaract" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Municipio </div>
                                        <asp:Label ID="lblmun" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Dirección </div>
                                        <asp:Label ID="lbldir" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tecnología </div>
                                        <asp:Label ID="lbltecnologia" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">APN </div>
                                        <asp:Label ID="lblapn" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Observación </div>
                                        <asp:TextBox ID="lblobs" runat="server" ReadOnly="true" CssClass="form-control" TextMode="MultiLine" />
                                    </div>
                                    
                                </div>
                            </div>
                            <div class="text-center Subtitulos">Validaciones servicio al cliente</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            La falla se presenta luego <br />
                                de que se construyera una <br />
                                edificación aledaña
                                        </div>
                                        <asp:Label ID="Lbl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            La falla se presenta luego <br />
                                de que se remodelara la <br />
                                estructura física del edificio
                                        </div>
                                        <asp:Label ID="Lbl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tipo de edificación donde <br />
                                se presenta la falla
                                        </div>
                                        <asp:Label ID="Lbl_Tipo_Edificacion_Donde_Presenta_Falla" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Validaciones de falla masiva</div>
                                        <asp:Label ID="Lbl_Validaciones_Falla_Masiva" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tecnología en la que se <br />
                                presenta la falla - 
                                Luego de pruebas
                                        </div>
                                        <asp:Label ID="Lbl_Tecnologia_Presenta_Falla_Luegodepruebas" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Validación de Coordenadas</div>
                                        <asp:Label ID="Lbl_Validacion_Coordenadas" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Línea no cuenta<br />
                                             con bloqueos de Internet</div>
                                        <asp:Label ID="Lbl_Linea_No_Cuenta_Bloqueos_Internet" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Línea no ha superado el <br />
                                limite de consumos
                                        </div>
                                        <asp:Label ID="Lbl_Linea_No_Superado_Limite_Consumos" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Línea Portada</div>
                                        <asp:Label ID="lblportada" runat="server" CssClass="form-control" />
                                    </div><h4></h4>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Línea no se encuentra <br />
                                enrutada por pagos
                                        </div>
                                        <asp:Label ID="Lbl_Linea_No_Encuentra_Enrutada_PorPagos" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">QoS</div>
                                        <asp:Label ID="lblqos" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">HLR / HSS</div>
                                        <asp:Label ID="Lbl_HLR_HSS" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            No existen cambios <br />
                                administrativos sobre la <br />
                                línea o cuenta maestra
                                        </div>
                                        <asp:Label ID="Lbl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Se realizan pruebas de <br />
                                SIMCARD en otro dispositivo <br />
                                (Persiste Falla)
                                        </div>
                                        <asp:Label ID="Lbl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Se forza la<br />
                                             red del dispositivo</div>
                                        <asp:Label ID="Lbl_Forza_Red_Dispositivo" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Se verifica o realiza <br />
                                configuración de APN
                                        </div>
                                        <asp:Label ID="Lbl_Verifica_Realiza_Configuración_APN" runat="server" CssClass="form-control" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Equipo se encuentra <br />
                                homologado por el operador
                                        </div>
                                        <asp:Label ID="Lbl_Equipo_Encuentra_Homologado_Operador" runat="server" CssClass="form-control" />

                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Se realiza conciliación <br />
                                sobre la línea
                                        </div>
                                        <asp:Label ID="Lbl_Realiza_Conciliacion_Sobre_linea" runat="server" CssClass="form-control" />
                                    </div>
                                </div>
                            </div>
                            <div class="Form">
                                <asp:Button ID="Btn_Exportar" runat="server" CssClass="btn btn-primary" Text="Exportar" />&nbsp&nbsp
                                <asp:Label ID="Lbl_Inf" runat="server"  Visible ="false" style="border-radius:5px; padding:6px 2px 6px 2px; border:1px solid #8F9E45" ForeColor ="#8F9E45"  />
                            </div>
                        </section>
                        <div class="Leyendas ">
                            <asp:Label ID="Label7" runat="server">Casos asignados pendientes: </asp:Label>
                            <asp:Label ID="lblcuenta" runat="server">0</asp:Label>
                        </div>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="campana" HeaderText="Campaña" />
                                    <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                                    <asp:BoundField DataField="idusuario" HeaderText="Agente Escala" />
                                    <asp:BoundField DataField="fc_ingreso" HeaderText="Fecha Ingreso" />
                                    <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="fcasignado" HeaderText="Fecha Asignado" />
                                </Columns>
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
                        <asp:PostBackTrigger ControlID="Btn_Exportar" />
                    </Triggers>
                </asp:UpdatePanel>               
            </article>
            <footer></footer>
        </form>
    </body>
</html>