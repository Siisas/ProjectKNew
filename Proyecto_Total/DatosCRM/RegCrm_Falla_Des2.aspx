<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegCrm_Falla_Des2.aspx.vb" Inherits="digitacion.RegCrm_Falla_Des2" %>
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
                        <section>
                            <div class="text-center TituloCRM">CONSULTA DE CASOS</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <asp:CompareValidator runat="server" ControlToValidate="txtcaso" Display="Dynamic" ValidationGroup="VG_Consultar" Operator="DataTypeCheck" Type="Double">El caso debe ser numérico</asp:CompareValidator>
                                    <div class="input-group">
                                        <div class="input-group-addon">Caso</div>
                                        <asp:TextBox ID="txtcaso" CssClass="form-control" runat="server" />
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <asp:Button ID="BtnBuscar" CssClass="btn btn-crm" Text="Buscar" runat="server" ValidationGroup="VG_Consultar"/>
                                    <asp:Button ID="BtnNuevo_caso" CssClass="btn btn-crm" Text="Nuevo Caso" Visible="false" runat="server" />
                                    <asp:Label ID="LblEscalamiento" runat="server" Style="color: #8F9E45; font-size: medium; font-style: italic"></asp:Label>
                                </div>
                            </div>
                            <div class="Separator"></div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">MIN</div>
                                        <asp:Label runat="server" ID="lblmin" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Caso Claro</div>
                                        <asp:Label runat="server" ID="LblCasoClaro" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Nombre</div>
                                        <asp:Label runat="server" ID="lblcliente" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Bandeja</div>
                                        <asp:Label runat="server" ID="lblBandeja" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Departamento Falla</div>
                                        <asp:Label runat="server" ID="lbllugar" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Numero Alterno</div>
                                        <asp:Label runat="server" ID="lblNumero_Alterno" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado Bandeja</div>
                                        <asp:Label runat="server" ID="lblestado" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado Nivel 3</div>
                                        <asp:Label runat="server" ID="lblestadon3" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Caso</div>
                                        <asp:Label runat="server" ID="lblcaso" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Call Remite</div>
                                        <asp:Label runat="server" ID="LblCall_Remite" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Documento</div>
                                        <asp:Label runat="server" ID="lbldocumento" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Plan</div>
                                        <asp:Label runat="server" ID="lblplan" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Observación *611</div>
                                        <asp:Label runat="server" ID="lblobs611" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 80px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Ingreso</div>
                                        <asp:Label runat="server" ID="Lblfc_ingreso" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Ingreso Nivel 3</div>
                                        <asp:Label runat="server" ID="lblfcingn3" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </section>
                        <section>
                            <div class="text-center TituloCRM">REGISTRO DE SEGUIMIENTO</div>
                            <div class="Form">
                                <asp:Button Text="Guardar" ID="Btn_Guardar" ValidationGroup="VG_Registrar" CssClass="btn btn-crm" runat="server" />
                            </div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Marca</div>
                                        <asp:DropDownList ID="drlmarca" TabIndex="1" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Departamento</div>
                                        <asp:DropDownList ID="drldpto" TabIndex="3" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Se comunica a linea alterna
                                            <asp:CompareValidator ID="CompareValidator3" Display="Dynamic" runat="server" ControlToValidate="txtnumalt" ValidationGroup="VG_Registrar" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                            <asp:RegularExpressionValidator ID="telefono" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txtnumalt" ValidationGroup="VG_Registrar" Display="Dynamic" CssClass="textoError" /><asp:RadioButton ID="chkSi" runat="server" TabIndex="5" GroupName="Numero" Text="SI" AutoPostBack="true" /><asp:RadioButton ID="chkNo" TabIndex="6" runat="server" GroupName="Numero" Text="NO" AutoPostBack="true" /></div>
                                        <asp:TextBox ID="txtnumalt" TabIndex="7" runat="server" MaxLength="10" CssClass="form-control" Enabled="False" placeholder="Numero"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Equipo</div>
                                        <asp:DropDownList ID="drlequipo" TabIndex="2" runat="server" CssClass="form-control">
                                            <asp:ListItem Text="- Seleccione -" />
                                        </asp:DropDownList>
                                        <span id="Span3" runat="server" class="input-group-btn">
                                            <asp:Button ID="Btn_act_equipo" runat="server" Visible="false" Text="Actualizar" CssClass="btn btn-crm" />
                                        </span>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Municipio</div>
                                        <asp:DropDownList ID="drlmun" TabIndex="4" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="0" Text="- SELECCIONE -" />
                                        </asp:DropDownList>
                                        <span id="Span2" runat="server" class="input-group-btn">
                                            <asp:Button ID="Btn_act_municipio" runat="server" Visible="false" Text="Actualizar" CssClass="btn btn-crm" />
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center Sub-TituloCRM">TIPO CLIENTE</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Intensión de Desactivación por falla en</div>
                                        <asp:DropDownList ID="drlIntension_Des_Por_Fallaen" TabIndex="8" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo pqr adicional</div>
                                        <asp:DropDownList ID="drlTipo_Pqr_Adicional" TabIndex="10" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>    
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo de proceso de la línea</div>
                                        <asp:DropDownList ID="drlTipo_Proceso_Linea" TabIndex="9" runat="server" CssClass="form-control"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Aplica fidelizacion</div>
                                        <asp:DropDownList ID="drlAplica_Fidelizacion" TabIndex="11" runat="server" CssClass="form-control">
                                            <asp:ListItem Text="- Seleccione -" />
                                            <asp:ListItem Text="SI" />
                                            <asp:ListItem Text="NO" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center Sub-TituloCRM">CATALOGO DE DIAGNOSTICO</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Línea de Servicio</div>
                                        <asp:DropDownList ID="drllinea" TabIndex="12" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Solicitud / Tipo Falla</div>
                                        <asp:DropDownList ID="drlsolicitud" TabIndex="14" runat="server" AutoPostBack="true" CssClass="form-control">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Segmento</div>
                                        <asp:DropDownList ID="drlSegmento" TabIndex="16" runat="server" AutoPostBack="True" CssClass="form-control">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Servicio</div>
                                        <asp:DropDownList ID="drlservicio2" TabIndex="13" runat="server" CssClass="form-control" AutoPostBack="True">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo linea</div>
                                        <asp:DropDownList ID="drltipolinea" TabIndex="15" runat="server" CssClass="form-control">
                                            <asp:ListItem Text="- Seleccione -" />
                                            <asp:ListItem Text="Pospago" />
                                            <asp:ListItem Text="Prepago" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Causa raiz</div>
                                        <asp:DropDownList ID="drlCausa_Raiz" TabIndex="17" runat="server" AutoPostBack="true" CssClass="form-control">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center Sub-TituloCRM">CATEGORIA DE CIERRE</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipificación Llamada N3</div>
                                        <asp:DropDownList ID="drltipificacionll" TabIndex="18" runat="server" AutoPostBack="true" CssClass="form-control">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">PQR<asp:CompareValidator ID="CV_PQR" runat="server" ControlToValidate="TxtPQR" ErrorMessage="El valor del PQR debe ser numerico" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator></div>
                                        <asp:Label ID="LblPQR" runat="server" Width="60%" Style="text-align: right;" CssClass="form-control">
                                        </asp:Label><asp:TextBox ID="TxtPQR" TabIndex="20" runat="server" MaxLength="7" Width="40%" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Se realizo contacto</div>
                                        <asp:RadioButtonList ID="Rdb_Contacto" TabIndex="22" runat="server" CssClass="form-control" Style="list-style-type: upper-alpha;" RepeatDirection="Horizontal" Enabled="false">
                                            <asp:ListItem Value="SI">SI</asp:ListItem>
                                            <asp:ListItem Value="NO">NO</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Categoria de cierre</div>
                                        <asp:DropDownList ID="drlCategoriaCierre" TabIndex="19" runat="server" AutoPostBack="True" CssClass="form-control">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo PQR</div>
                                        <asp:DropDownList ID="drlTipo_PQR" runat="server" TabIndex="21" CssClass="form-control"></asp:DropDownList>
                                        <span class="input-group-btn">
                                            <asp:Button Text="Actualizar" ID="Btn_Act_PQR" Visible="false" CssClass="btn btn-crm" runat="server" />
                                        </span>
                                    </div>
                                       <%--Justificación Seguimiento--%>
                                <asp:Panel ID="Panel_Justificacion" Visible="false" runat="server">
                                    <div class="input-group">
                                        <div class="input-group-addon">Justificación Seguimiento</div>
                                        <asp:DropDownList ID="Drl_justificacion_seguimiento" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                    </div>
                                </asp:Panel>
                                </div>
                            </div>
                            <asp:Panel ID="Pnl_Seguimiento" Visible="false" runat="server">
                                <div class="text-center Sub-TituloCRM">SEGUIMIENTO</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Programacion</div>
                                            <asp:TextBox ID="txtfc_programado" TabIndex="23" runat="server" CssClass="form-control HoraFecha" MaxLength="18" placeholder="DD/MM/YYYY H:mm:ss"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Liberar Caso</div>
                                            <asp:DropDownList ID="drlLibera" TabIndex="24" runat="server" AutoPostBack="True" CssClass="form-control">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Text="SI" />
                                                <asp:ListItem Text="NO" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                            <div class="text-center Sub-TituloCRM">OBSERVACION</div>
                            <div class="Form">
                                <asp:TextBox ID="txtobs" TabIndex="25" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                            </div>
                        </section>
                     <asp:Panel ID="Pnl_Esc_Service" runat="server" Visible="False">
                            <section>
                                <div class="text-center TituloCRM">ESCALAMIENTO SERVICE</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                            <%--Causal de Escalamiento a Informática--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">Causal de Escalamiento</div>
                                                <asp:DropDownList ID="drl_causal_escalamiento_service" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                            </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Apn</div>
                                            <asp:DropDownList ID="drlapn" TabIndex="26" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Error en Registro</div>
                                            <asp:DropDownList ID="drlvariableCatalogo" TabIndex="30" runat="server" AutoPostBack="True" CssClass="form-control">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">QoS</div>
                                            <asp:DropDownList ID="drlqos" TabIndex="28" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <asp:CompareValidator runat="server" ControlToValidate="txtfcactivacion" Display="Dynamic"  ValidationGroup="VG_Registrar"  Operator="DataTypeCheck" Type="Date">La fecha de activacion no es válida</asp:CompareValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon"><asp:Label ID="lbl_Fecha_Act_Ciclo" runat="server" >Fecha Activacion</asp:Label></div>
                                            <asp:TextBox ID="txtfcactivacion" TabIndex="27" runat="server" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" MaxLength="10"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Imagen</div>
                                            <asp:FileUpload ID="FileDocumento" Width="100%" Height="50%" CssClass="btn btn-primary" runat="server" />
                                        </div>
                                        <div class="input-group ">
                                            <div class="input-group-addon"></div>
                                            <asp:Label ID="lblvariable1" runat="server" CssClass="form-control" Font-Size="X-Small" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px;"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                        </section>
                        </asp:Panel>

                        <asp:Panel ID="Pnfallared" runat="server" Visible="False">
                            <section>
                                <div class="text-center TituloCRM">REGISTRO FALLA DE RED</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Condiciones de Uso</div>
                                            <asp:DropDownList ID="drlFtectolog" runat="server" CssClass="form-control">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>GSM</asp:ListItem>
                                                <asp:ListItem>3G</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Persona Contacto</div>
                                            <asp:TextBox ID="txtFcontacto" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tiempo Falla</div>
                                            <asp:DropDownList ID="drlFtiempo" runat="server" CssClass="form-control">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="&lt;=30">&lt;=30</asp:ListItem>
                                                <asp:ListItem Value="&gt;30">&gt;30</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Características de la Falla </div>
                                            <asp:DropDownList ID="drlFcaract" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Nombre Vereda o Corregimiento</div>
                                            <asp:TextBox ID="txtFciudad" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Dirección Falla</div>
                                            <asp:TextBox ID="txtFdirecc" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">QoS</div>
                                            <asp:DropDownList ID="Drl_Qos" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Observación Cliente</div>
                                            <asp:TextBox ID="txtfobs" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Barrio</div>
                                            <asp:TextBox ID="txtbarrio" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <asp:CompareValidator Id="CV_Txt_N_Doc_Id_CPD" Display="Dynamic" ControlToValidate="Txt_N_Doc_Id_CPD" Operator="DataTypeCheck" Type="Integer" ValidationGroup="VG_Registrar" runat="server" >El número de Nit/Cedula debe ser un número entero</asp:CompareValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">NIT / Cedula
                                                <asp:RequiredFieldValidator  Id="RFV_Txt_N_Doc_Id_CPD" Display="Dynamic"  ValidationGroup="VG_Registrar"  ControlToValidate="Txt_N_Doc_Id_CPD" runat="server" >*</asp:RequiredFieldValidator>
                                            </div>
                                            <asp:TextBox ID="Txt_N_Doc_Id_CPD" runat="server" CssClass="form-control" MaxLength="15"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Número Contacto</div>
                                            <asp:TextBox ID="txtFnum" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipo Falla</div>
                                            <asp:TextBox ID="txtFtipofalla" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Línea Portada</div>
                                            <asp:DropDownList ID="drlFportada" runat="server" CssClass="form-control">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>FALSO</asp:ListItem>
                                                <asp:ListItem>VERDADERO</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipo Lugar</div>
                                            <asp:RadioButtonList ID="rdbvc" CssClass="form-control" runat="server" RepeatDirection="Horizontal" Font-Size="XX-Small">
                                                <asp:ListItem Value="VRD">Vereda</asp:ListItem>
                                                <asp:ListItem Value="CRG">Corregimiento</asp:ListItem>
                                                <asp:ListItem Value="INS">Inspección</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">APN</div>
                                            <asp:TextBox ID="txtapn" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Lineas con falla<br />
                                                en la Ubicación Reportada
                                            </div>
                                            <asp:DropDownList ID="drlFlineasfalla" runat="server" CssClass="form-control" Height="45px">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="text-center Sub-TituloCRM">VALIDACIONES SERVICIO AL CLIENTE</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                La falla se presenta luego de que se
                                                <br />
                                                construyera una edificación aledaña
                                            </div>
                                            <asp:DropDownList Style="height: 42px;" ID="Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipo de edificación donde<br />
                                                se presenta la falla
                                            </div>
                                            <asp:UpdatePanel runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_1" runat="server" CssClass="form-control">
                                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_2" runat="server" CssClass="form-control">
                                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tecnología en la que se presenta<br />
                                                la falla - Luego de pruebas
                                            </div>
                                            <asp:DropDownList Style="height: 42px;" ID="Drl_Tecnologia_Presenta_Falla_Luegodepruebas" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Línea no cuenta con
                                                 <br />
                                                bloqueos de Internet
                                            </div>
                                            <asp:DropDownList Style="height: 42px;" ID="Drl_Linea_No_Cuenta_Bloqueos_Internet" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Línea no se encuentra
                                                <br />
                                                enrutada por pagos 
                                            </div>
                                            <asp:DropDownList Style="height: 42px;" ID="Drl_Linea_No_Encuentra_Enrutada_PorPagos" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                No existen cambios administrativos<br />
                                                sobre la línea o cuenta maestra
                                            </div>
                                            <asp:UpdatePanel runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList Style="height: 42px;" ID="Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra" runat="server" AutoPostBack="True" CssClass="form-control">
                                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                                        <asp:ListItem Value="FALSO"></asp:ListItem>
                                                        <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                                    </asp:DropDownList>
                                                    <br />
                                                    <asp:DropDownList ID="Drl_Split_Billing" runat="server" CssClass="form-control" Visible="false">
                                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Se forza la red del dispositivo  </div>
                                            <asp:DropDownList ID="Drl_Forza_Red_Dispositivo" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Equipo se encuentra<br />
                                                homologado por el operador
                                            </div>
                                            <asp:DropDownList Style="height: 42px;" ID="Drl_Equipo_Encuentra_Homologado_Operador" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                La falla se presenta luego de que se
                                                <br />
                                                remodelara la estructura física del edificio
                                            </div>
                                            <asp:DropDownList Style="height: 42px;" ID="Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Validaciones de falla masiva  </div>
                                            <asp:DropDownList ID="Drl_Validaciones_Falla_Masiva" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Validación de Coordenadas  </div>
                                            <asp:TextBox ID="Txt_Validacion_Coordenadas" runat="server" MaxLength="20" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Línea no ha superado el
                                                <br />
                                                limite de consumos
                                            </div>
                                            <asp:DropDownList Style="height: 42px;" ID="Drl_Linea_No_Superado_Limite_Consumos" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">HLR / HSS  </div>
                                            <asp:DropDownList ID="Drl_HLR_HSS" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Se realizan pruebas de SIMCARD<br />
                                                en otro dispositivo (Persiste Falla)
                                            </div>
                                            <asp:DropDownList Style="height: 42px;" ID="Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Se verifica o realiza configuración de APN </div>
                                            <asp:DropDownList ID="Drl_Verifica_Realiza_Configuración_APN" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Se realiza conciliación<br />
                                                sobre la línea 
                                            </div>
                                            <asp:DropDownList Style="height: 42px;" ID="Drl_Realiza_Conciliacion_Sobre_linea" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="FALSO"></asp:ListItem>
                                                <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </section>
                        </asp:Panel>
                        <asp:Panel ID="pnnuevo" runat="server" Visible="False">
                            <section>
                                <div class="text-center TituloCRM">NUEVO REGISTRO DESACTIVACION</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <asp:CompareValidator runat="server" ControlToValidate="txtminnv" Display="Dynamic"  ValidationGroup="VG_Registrar"  Operator="DataTypeCheck" Type="Double">El min es numérico sin espacios ni caracteres</asp:CompareValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Min</div>
                                            <asp:TextBox ID="txtminnv" TabIndex="31" runat="server" MaxLength="10" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Nombre  </div>
                                            <asp:TextBox ID="txtnombrenv" TabIndex="33" runat="server" MaxLength="60" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Ingeniero Remite  </div>
                                            <asp:TextBox ID="TxtIngRemite" TabIndex="35" runat="server" MaxLength="60" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipo  </div>
                                            <asp:RadioButtonList ID="rdbtipoinb" TabIndex="37" runat="server" Font-Size="XX-Small" Style="color: #8F9E45" Height="70px" CssClass="form-control">
                                                <asp:ListItem>Corporativo</asp:ListItem>
                                                <asp:ListItem>Fidelización</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </div>
                                        <h4></h4>
                                        <asp:Button ID="Btn_Nuevo_Regist_Inb" TabIndex="38" runat="server" Text="Guardar" CssClass="btn btn-crm" />
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Plan</div>
                                            <asp:TextBox ID="txtplannv" runat="server" TabIndex="32" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <asp:CompareValidator runat="server" ControlToValidate="txtidentifnv" Display="Dynamic"  ValidationGroup="VG_Registrar"  Operator="DataTypeCheck" Type="Double">La identificación es numérica sin espacios ni caracteres</asp:CompareValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Identificacion</div>
                                            <asp:TextBox ID="txtidentifnv" runat="server" TabIndex="34" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <asp:CompareValidator runat="server" ControlToValidate="TxtCasoNuevo" Display="Dynamic"  ValidationGroup="VG_Registrar"  Operator="DataTypeCheck" Type="Double">El caso debe ser numérico</asp:CompareValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Caso</div>
                                            <asp:TextBox ID="TxtCasoNuevo" runat="server" TabIndex="36" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                        </section>
                        </asp:Panel>
                        <section>
                            <div style="text-align: center;">
                                <div class="Separator"></div>
                                <h5><em>
                                    <asp:LinkButton ID="LinkBtn_Inconsistencia" runat="server" CssClass="linkbutton" ForeColor="#8F9E45">Reportar Inconsistencia</asp:LinkButton>
                                    <asp:LinkButton ID="LinkBtn_Oculta_Inconsistencia" runat="server" CssClass="linkbutton" ForeColor="#8F9E45" Visible="False">Ocultar Inconsistencia</asp:LinkButton>
                                </em></h5>
                            </div>
                           <asp:Panel ID="Pninc" runat="server" Visible="False">
                                <div class="text-center TituloCRM">REGISTRO DE INCONSISTENCIA</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <%--custcode--%>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Type="Decimal" Display="Dynamic" ValidationGroup="Vg_Reg_Insconsistencia" runat="server" ControlToValidate="Txt_custcode" ValidationExpression="([0-9]|\.)*">El custcode debe ser numerico</asp:RegularExpressionValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Custcode</div>
                                            <asp:TextBox ID="Txt_custcode" CssClass="form-control" runat="server" />
                                        </div>
                                        <%--Tipificacion--%>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipificación</div>
                                            <asp:DropDownList ID="drlinconsglobal" CssClass="form-control" runat="server" AutoPostBack="True" >
                                                <asp:ListItem Value="1" Text="- Seleccione -"/>
                                            </asp:DropDownList>
                                        </div>
                                              <%--nivel--%>
                                          <div class="input-group">
                                            <div class="input-group-addon">Nivel</div>
                                            <asp:DropDownList ID="drlnivel" CssClass="form-control" runat="server" AutoPostBack="True" >
                                                <asp:ListItem Value="0" Text="- Seleccione -"/>
                                                <asp:ListItem Text="Call"/>
                                                <asp:ListItem Text="Operacion"/>
                                                <asp:ListItem Text="Call/Operac"/>
                                            </asp:DropDownList>
                                        </div>                           
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <%--usuario reporta--%>
                                        <div class="input-group">
                                            <div class="input-group-addon">Usuario Reporta</div>
                                            <asp:TextBox ID="Txt_usuario_reporta" CssClass="form-control" runat="server" />
                                        </div>
                                        <%--tipo inconsistencia--%>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipo Inconsistencia</div>
                                            <asp:DropDownList ID="drlincons" CssClass="form-control" runat="server" >
                                                <asp:ListItem Value="1" Text="- Seleccione -"/>
                                            </asp:DropDownList>
                                        </div>
                                                  <%--Ubicacion call--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Ubicacion Call Center</div>
                                        <asp:DropDownList ID="drl_ubicacion_call" CssClass="form-control" runat="server" AutoPostBack="True" Enabled="true">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>   
                                  
                                    </div>
                                </div>
                             <div class="Form">
                                 <%--observacion--%>
                                 <div class="input-group">
                                     <div class="input-group-addon">Observación Inconsistencia</div>
                                     <asp:TextBox ID="txtobsinc" TextMode="MultiLine" CssClass="form-control" runat="server" />
                                 </div>
                                 <asp:Button Text="Guardar" ID="Btn_Guardar_Inconsistencia" CssClass="btn btn-crm" ValidationGroup="Vg_Reg_Insconsistencia" runat="server" />
                                 <h4></h4>
                             </div>

                            </asp:Panel>
                        </section>
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="Btn_Guardar" />
                    </Triggers>
                </asp:UpdatePanel>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <h4><em style="color: #8F9E45">Casos Asignados: &nbsp;<asp:Label ID="lblcasos_asig" runat="server"></asp:Label>
                            &nbsp;&nbsp;</em></h4>
                        <div class="bordes">
                            <asp:GridView ID="dtgprog" runat="server" AllowPaging="True" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" PageSize="5" Style="font-size: x-small" Width="100%">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" Font-Size="Small" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div>
                        <br />
                        <h4><em style="color: #8F9E45">Consulta Seguimientos :</em>
                            <asp:Label ID="lblcuenta" runat="server" ForeColor="#8F9E45"></asp:Label>
                        </h4>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="80" Width="100%"
                                Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Id_CRM_Falla_Desactivacion_D_V" HeaderText="ID" />
                                    <asp:BoundField DataField="Id_Bandeja_Falla_Desactivacion_D_V" HeaderText="Caso" />
                                    <asp:BoundField DataField="Id_Caso" HeaderText="Caso Claro" />
                                    <asp:BoundField DataField="Min" HeaderText="Min" />
                                    <asp:BoundField DataField="Fc_Reg_Ges" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="Id_Usuario" HeaderText="Agente" />
                                    <asp:BoundField DataField="obs" HeaderText="Observación" />
                                    <asp:BoundField DataField="Tipificacion" HeaderText="Tipificación" />
                                    <asp:BoundField DataField="Falla_Red" HeaderText="Escalamiento" />
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
                </asp:UpdatePanel>
            </article>
            <footer></footer>
        </form>
    </body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>