<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Registro_Inbound.aspx.vb" Inherits="digitacion.Registro_Inbound" %>
<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>
<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kamilion CRM INBOUND</title>
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
                        <div class="text-center Subtitulos">CRM INBOUND</div>
                           <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Caso 
                                        <asp:CompareValidator runat="server" ControlToValidate="txtcaso" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="VG_Consultar" />
                                    </div>
                                    <asp:TextBox ID="txtcaso" MaxLength="25" CssClass="form-control" runat="server" />
                                    <span id="Span1" runat="server" class="input-group-btn">
                                        <asp:Button ID="btn_buscar" runat="server" Text="Buscar" ValidationGroup="VG_Consultar" CssClass=" btn btn-primary" />
                                    </span>
                                </div>
                            </div>
                            <%--CELDA DEL CENTRO--%>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <asp:Button ID="Btn_caso_nuevo" runat="server" Text="Caso nuevo" CssClass=" btn btn-primary" />
                                <%--<asp:Button ID="btn_rechazar" runat="server" Text="Rechazar Caso" CssClass=" btn btn-primary" />--%>
                                <asp:Button ID="Btn_Llamada_Corta" runat="server" Text="Llamada Corta" CssClass=" btn btn-primary" />
                            </div>
                        </div>
                      <asp:Panel ID="Panel_consulta" runat="server" Visible="false">
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--Caso--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Caso</div>
                                    <asp:Label runat="server" ID="lbl_caso" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                </div>     
                                <%--Numero Alterno--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Min Alterno</div>
                                    <asp:Label runat="server" ID="lbl_min_alterno" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                </div>
                                <%--usuario registra--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Usuario Registra</div>
                                    <asp:Label runat="server" ID="lbl_usuario_registra" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                </div>    
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <%--Estado--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:Label runat="server" ID="lbl_estado" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                </div>    
                                <%--Fecha ingreso--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha ingreso</div>
                                    <asp:Label runat="server" ID="lbl_fecha_ingreso" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                </div>                           
                            </div>
                        </div>
                          </asp:Panel>

                        <asp:Panel ID="Panel_registro" runat="server" Visible="false">
                        <div class="text-center Subtitulos">REGISTRO INBOUND</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">                                    
                                  <asp:Button ID="btn_guardar" runat="server" Text="Guardar" ValidationGroup="VG_Registrar" CssClass="btn btn-primary"/>
                                </div>
                            </div>
                            <%--CELDA DEL CENTRO--%>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <asp:Button ID="Btn_rechazar_inb" runat="server" Text="Rechazar"  ValidationGroup="VG_Rechazar" CssClass=" btn btn-primary" />
                            </div>
                        </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--ID Avaya--%>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ID AVAYA
                                         <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_IDAVAYA" Display="Dynamic" ValidationGroup="VG_Registrar" ErrorMessage="*" />
                                        <asp:CompareValidator runat="server" ControlToValidate="txt_IDAVAYA" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="VG_Registrar" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{20,200}$" ControlToValidate="txt_IDAVAYA" Display="Dynamic" ValidationGroup="VG_Registrar" />
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="txt_IDAVAYA" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--Numero--%>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Min
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_min" Display="Dynamic" ValidationGroup="VG_Registrar" ErrorMessage="*" CssClass="textoError"  />
                                        <asp:RegularExpressionValidator runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txt_min" Display="Dynamic" ValidationGroup="VG_Registrar" />
                                        <asp:CompareValidator runat="server" ControlToValidate="txt_min" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="VG_Registrar" />
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="txt_min" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>


                                <%--MARCA--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Marca</div>
                                    <asp:UpdatePanel ID="UpdatePanel_Marca" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlmarca" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--DEPARTAMENTO--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Departamento</div>
                                    <asp:UpdatePanel ID="UpdatePanel_Departamento" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--BARRIO--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Barrio</div>
                                    <asp:UpdatePanel ID="UpdatePanel_Barrio" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="txtbarrio" runat="server" CssClass="form-control"></asp:TextBox>

                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--CONDICIONES DE USO--%>
                                <asp:UpdatePanel ID="UpdatePanel_Condiciones_uso" runat="server">
                                    <ContentTemplate>
                                        <div class="input-group">
                                            <div class="input-group-addon">Condiciones de uso</div>
                                            <asp:DropDownList ID="drlFtectolog" runat="server" CssClass="form-control"></asp:DropDownList>
                                            <span class="input-group-btn">
                                                <asp:Button ID="Btn_Habilita_Tecnologia" runat="server" Text="Actualizar" CssClass="btn btn-crm" Visible="false" />
                                            </span>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <%--CAMPAÑA--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Campaña</div>
                                    <asp:UpdatePanel ID="UpdatePanel_campaña" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlcampaña" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--FALLA--%>
                                <div class="input-group">
                                    <div class="input-group-addon">FALLA</div>
                                    <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="Drl_Falla" runat="server" AutoPostBack="True" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SAAM TRIARA</asp:ListItem>
                                                <asp:ListItem>CICLO FACTURACION</asp:ListItem>
                                                <asp:ListItem>HSS_BUCARAMANGA</asp:ListItem>
                                                <asp:ListItem>OTRO</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                            <%--CELDA DEL CENTRO--%>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <%--Nombre--%>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Nombre
                                         <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_nombre" Display="Dynamic" ValidationGroup="VG_Registrar" ErrorMessage="*" />
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control" MaxLength="150"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>                              
                                  <%--Usuario reporta--%>
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Usuario reporta *611
                                         <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_usu_reporta" Display="Dynamic" ValidationGroup="VG_Registrar" ErrorMessage="*" />
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="txt_usu_reporta" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                        <%--EQUIPO--%>
                                <asp:UpdatePanel ID="UpdatePanel_Equipo" runat="server">
                                    <ContentTemplate>
                                        <div class="input-group">
                                            <div class="input-group-addon">Equipo</div>
                                            <asp:DropDownList ID="drlequipo" runat="server" CssClass="form-control"></asp:DropDownList>
                                            <span class="input-group-btn">
                                                <asp:Button ID="Btn_Habilita_Equipo" runat="server" Text="Actualizar" Visible="false" CssClass="btn btn-crm" />
                                            </span>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <%--MUNICIPIO--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Municipio" runat="server">
                                        <ContentTemplate>
                                <div class="input-group">
                                    <div class="input-group-addon">Municipio</div>
                                            <asp:DropDownList ID="drlmun" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                              <span class="input-group-btn">
                                                <asp:Button ID="Btn_Habilita_Municipio" runat="server" Text="Actualizar" CssClass="btn btn-crm" Visible="false" />
                                            </span>
                                </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                <%--FECHA ULTIMA CAIDA--%>
                                <asp:UpdatePanel ID="UpdatePanel_Fc_Utilma_Caida" runat="server">
                                    <ContentTemplate>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Fecha ultima caida
                                        <asp:CompareValidator ID="CompareValidator9" runat="server" ControlToValidate="txtultimc" ErrorMessage="*" Operator="DataTypeCheck" Type="Date" />
                                            </div>
                                            <asp:TextBox ID="txtultimc" runat="server" placeholder="DD/MM/YYYY" MaxLength="10" CssClass="form-control Fecha" Style="max-width: 50%"></asp:TextBox>
                                            <asp:DropDownList ID="drlfranja" runat="server" CssClass="form-control" Style="max-width: 50%">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>Mañana</asp:ListItem>
                                                <asp:ListItem>Tarde</asp:ListItem>
                                                <asp:ListItem>Noche</asp:ListItem>
                                            </asp:DropDownList>
                                            <span class="input-group-btn">
                                                <asp:Button ID="Btn_Habilita_Fc_Utl_Caida" runat="server" Text="Actualizar" Visible="False" CssClass="btn btn-crm" />
                                            </span>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <%--LINEA ALTERNA--%>
                                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                    <ContentTemplate>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Linea alterna
                                        <asp:CompareValidator ID="CompareValidator1" Display="Dynamic" runat="server" ControlToValidate="txtnumalt" ValidationGroup="VG_Registrar" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                                <asp:RegularExpressionValidator ID="telefono" runat="server" ErrorMessage="*" ValidationGroup="VG_Registrar" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txtnumalt" Display="Dynamic" CssClass="textoError" />
                                            </div>
                                            <div class="form-control" style="width: 100%; text-align: center">
                                                <asp:RadioButton ID="chkSi" runat="server" GroupName="Numero" Text="SI" AutoPostBack="true" />
                                                <asp:RadioButton ID="chkNo" runat="server" GroupName="Numero" Text="NO" AutoPostBack="true" />
                                            </div>
                                            <div class="input-group-addon" style="width: 2px;"></div>
                                            <div style="width: 100%">
                                                <asp:TextBox ID="txtnumalt" runat="server" MaxLength="10" Visible="false" placeholder="Numero" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                  <%--Falla SGSC--%>
                                      <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                          <ContentTemplate>
                                              <div class="input-group">
                                                  <span class="input-group-addon">FALLA SGSC
                                                    <asp:CheckBox ID="CHKSD" runat="server" AutoPostBack="true" />
                                                  </span>
                                                  <asp:TextBox ID="txt_SD" runat="server" CssClass="form-control" MaxLength="9" placeholder="SD0000000" Enabled="false"></asp:TextBox>
                                              </div>
                                              <%--Fecha Ingreso--%>
                                            <asp:Panel runat="server" ID="Pnl_Fecha_Hora_Reg" class="input-group" Visible="false">
                                                <div class="input-group-addon">
                                                    Fecha y hora registro 
                                                        <asp:RegularExpressionValidator ID="REV_Txt_Fecha_Hora_Reg" runat="server" ControlToValidate="Txt_Fecha_Hora_Reg" Display="Dynamic" ValidationGroup="VG_Registrar" ValidationExpression="^(0?[1-9]|[12][0-9]|3[0-1])[/](0?[1-9]|1[0-2])[/]\d\d\d\d (0?[0-9]|1[0-9]|2[0-3]):(0?[1-9]|[1-5][0-9])$">*</asp:RegularExpressionValidator>
                                                    <asp:RequiredFieldValidator runat="server" ID="RFV_Txt_Fecha_Hora_Reg" ControlToValidate="Txt_Fecha_Hora_Reg" Display="Dynamic" ValidationGroup="VG_Registrar">*</asp:RequiredFieldValidator>
                                                </div>
                                                <asp:TextBox ID="Txt_Fecha_Hora_Reg" runat="server" CssClass="form-control HoraFecha" placeholder="DD/MM/YYYY HH:mm"></asp:TextBox>
                                            </asp:Panel>
                                          </ContentTemplate>
                                      </asp:UpdatePanel>

                            </div>
                        </div>      
                        <asp:Panel ID="Panel_Rechazado" runat="server" Visible="false">
                            <div class="text-center Subtitulos">CASO RECHAZADO</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <%--cASO RECHAZADO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Caso rechazado LATCOM/COS                                        
                                        <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="txt_formato_recha" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="VG_Rechazar" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{8,200}$" ControlToValidate="txt_formato_recha" Display="Dynamic" ValidationGroup="VG_Rechazar"/>
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_formato_recha" runat="server" CssClass="form-control" MaxLength="8"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <%--FECHA ULTIOMA GESTION--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Ultima Gestion</div>
                                        <asp:TextBox ID="txt_fecha_Ult_Ges" runat="server" MaxLength="20" placeholder="DD/MM/YYYY H:MM:SS" CssClass="form-control HoraFecha"></asp:TextBox>
                                    </div>
                                    <%--Nivel--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Nivel</div>
                                        <asp:DropDownList ID="drl_nivel" CssClass="form-control" runat="server" AutoPostBack="True" Enabled="false">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                            <asp:ListItem Text="Call" />
                                            <asp:ListItem Text="Operacion" />
                                            <asp:ListItem Text="Call/Operac" />
                                        </asp:DropDownList>
                                    </div>
                                        <%--tipificacion--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipificación</div>
                                        <asp:DropDownList ID="drl_tipificacion_recha" CssClass="form-control" runat="server" AutoPostBack="True" Enabled="false">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <%--FECHA CASO RECHAZADO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Caso Rechazado</div>
                                        <asp:TextBox ID="txt_fecha_caso_recha" runat="server" MaxLength="20" placeholder="DD/MM/YYYY H:MM:SS" CssClass="form-control HoraFecha"></asp:TextBox>
                                    </div>
                                    <%--custcode--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Custcode</div>
                                        <asp:TextBox ID="txt_custcode_r" CssClass="form-control" runat="server" MaxLength="15" />
                                    </div>
                                    <%--Ubicacion call--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Ubicacion Call Center</div>
                                        <asp:DropDownList ID="drl_UbicacionCall" CssClass="form-control" runat="server" AutoPostBack="True" Enabled="true">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                        <%--Tipo inconsistencia--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo Inconsistencia</div>
                                        <asp:DropDownList ID="drl_inconsistencia_recha" CssClass="form-control" runat="server" Enabled="false">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                        <div class="text-center Subtitulos">DIAGNOSTICO</div>
                        <div class="Form">
                            <div class="Cell-Form">

                                <%--LINEA DE SERVICIO--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Linea de servicio</div>
                                    <asp:UpdatePanel ID="UpdatePanel_Linea_Servicio" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drllinea" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--SOLICITUD / TIPO FALLA--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Solicitud / Tipo Falla</div>
                                    <asp:UpdatePanel ID="UpdatePanel_Solicitud_Tipo_Falla" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlsolicitud" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                  <%--SEGMENTO--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Segmento</div>
                                    <asp:UpdatePanel ID="UpdatePanel_Segmento" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlSegmento" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">

                                <%--SERVICIO--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Servicio</div>
                                    <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlservicio2" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--MODALIDAD--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Modalidad</div>
                                    <asp:DropDownList ID="drlModalidad" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                   <%--CAUSA RAIZ--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Causa raiz</div>
                                    <asp:UpdatePanel ID="UpdatePanel_Causa_Raiz" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlCausa_Raiz" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                        </div>
                        <div class="text-center Subtitulos">CIERRE DE LLAMADA</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--ESTADO CASO--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:UpdatePanel ID="UpdatePanel_Estado" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drltipificacionll" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--PQR--%>
                                <asp:UpdatePanel ID="UpdatePanel_PQR" runat="server">
                                    <ContentTemplate>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                PQR
                                        <asp:CompareValidator ID="CV_PQR" runat="server" ControlToValidate="TxtPQR" ErrorMessage="*" Operator="DataTypeCheck" Type="Integer" />
                                            </div>
                                            <asp:Label ID="LblPQR" runat="server" CssClass="form-control" Width="60%"></asp:Label>
                                            <asp:TextBox ID="TxtPQR" runat="server" MaxLength="7" CssClass="form-control" Width="40%"></asp:TextBox>

                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                      <%--Formato--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                           <asp:Label runat="server" ID="lbl_formato"  Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px">Caso</asp:Label>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_formato" Display="Dynamic" ValidationGroup="VG_Registrar" ErrorMessage="*" />
                                            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txt_formato" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="VG_Registrar" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{8,200}$" ControlToValidate="txt_formato" Display="Dynamic" ValidationGroup="VG_Registrar" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_formato" runat="server" CssClass="form-control" MaxLength="8"></asp:TextBox>                                                
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <%--CATEGORIA CIERRE--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Categoria cierre</div>
                                    <asp:UpdatePanel ID="UpdatePanel_Categoria_Cierre_1" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlCategoriaCierre" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--TIPO PQR--%>
                                <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                                    <ContentTemplate>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipo PQR</div>
                                            <asp:DropDownList ID="drlTipo_PQR" runat="server" CssClass="form-control"></asp:DropDownList>
                                            <span class="input-group-btn">
                                                <asp:Button ID="Btn_Habilita_PQR" runat="server" Text="Actualizar" Visible="False" CssClass="btn btn-primary" />
                                            </span>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                   <%--Justificación Seguimiento--%>
                                    <asp:UpdatePanel ID="Panel_Justificacion" runat="server" Visible="false">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Justificación Seguimiento</div>
                                                <asp:DropDownList ID="Drl_justificacion_seguimiento" runat="server" CssClass="form-control"></asp:DropDownList>                                             
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>

                              
                            </div>
                        </div>                        
                        <asp:Panel ID="Panel_seguimiento" runat="server" Visible="false">
                        <div class="text-center Subtitulos">SEGUIMIENTO</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--FECHA PROGRAMACION--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha programacion</div>
                                    <asp:TextBox ID="txtfcprog" runat="server" MaxLength="20" placeholder="DD/MM/YYYY H:MM:SS" CssClass="form-control HoraFecha"></asp:TextBox>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                            </div>
                        </div>
                        </asp:Panel>
                        <div class="text-center Subtitulos">ENCUESTA</div>
                        <div class="Form">
                            <div class="Cell-Form">                        
                                <%--INCONSISTENCIA--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Inconsistencia atencion *611</div>
                                    <asp:UpdatePanel ID="UpdatePanel_inconsistencia" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlinconsistencia" runat="server" AutoPostBack="True" Enabled="true" CssClass="form-control">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">                               
                                <%--OBSERVACION--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Observacion de inconsistencia</div>
                                    <asp:UpdatePanel ID="UpdatePanel_obs_inconsistencia" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="txtobsincon" runat="server" TextMode="MultiLine" AutoPostBack="true" CssClass="form-control" Enabled="false"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                        </div>
                        <div class="text-center Subtitulos">OBSERVACIÓN</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--OBSERVACION--%>
                                <asp:TextBox ID="txtobs" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox></center>
                            </div>
                        </div>
                        </asp:Panel>

                        <%--ESCALAMIENTO A FALLA DE RED--%>
                        <asp:Panel ID="Panel_Falla_red" runat="server" Visible="false">
                            <div class="text-center Subtitulos">REGISTRO FALLA DE RED</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <%--PERSONA CONTACTO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Persona Contacto</div>
                                        <asp:TextBox ID="txtFcontacto" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <%--TIEMPO FALLA--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tiempo Falla</div>
                                        <asp:DropDownList ID="drlFtiempo" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="&lt;=30">&lt;=30</asp:ListItem>
                                            <asp:ListItem Value="&gt;30">&gt;30</asp:ListItem>
                                            <asp:ListItem>NS/NR</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <%--CARACTERISTICAS FALLA--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Características de la Falla</div>
                                        <asp:DropDownList ID="drlFcaract" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                    </div>
                                    <%--NOMBRE VEREDA--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Nombre Vereda o Corregimiento</div>
                                        <asp:TextBox ID="txtFciudad" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <%--DIRECCION--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Dirección Falla</div>
                                        <asp:TextBox ID="txtFdirecc" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <%--QOS--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">QoS</div>
                                        <asp:DropDownList ID="Drl_Qos" runat="server" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <%--OBSERVACION--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Observación Cliente</div>
                                        <asp:TextBox ID="txtfobs" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <%--número de identificación contacto--%>
                                    <asp:CompareValidator Id="CV_Txt_N_Doc_Id_CPD" Display="Dynamic" ControlToValidate="Txt_N_Doc_Id_CPD" Operator="DataTypeCheck" Type="Integer" ValidationGroup="VG_Registrar" runat="server" >El número de Nit/Cedula debe ser un número entero</asp:CompareValidator>
                                    <div class="input-group">
                                        <div class="input-group-addon">NIT / Cedula
                                            <asp:RequiredFieldValidator  Id="RFV_Txt_N_Doc_Id_CPD" Display="Dynamic" ValidationGroup="VG_Registrar" ControlToValidate="Txt_N_Doc_Id_CPD" runat="server" >*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:TextBox ID="Txt_N_Doc_Id_CPD" runat="server" CssClass="form-control" MaxLength="15"></asp:TextBox>
                                    </div>
                                    <%--NUMERO CONTACTO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Número Contacto</div>
                                        <asp:TextBox ID="txtFnum" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                    </div>
                                    <%--TIPO FALLA--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo Falla</div>
                                        <asp:TextBox ID="txtFtipofalla" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <%--LINEA PORTADA--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Línea Portada</div>
                                        <asp:DropDownList ID="drlFportada" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                            <asp:ListItem>FALSO</asp:ListItem>
                                            <asp:ListItem>VERDADERO</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <%--TIPO LUGAR--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo Lugar</div>
                                        <asp:RadioButtonList ID="rdbvc" runat="server" Font-Size="XX-Small" CssClass="form-control" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="VRD">Vereda</asp:ListItem>
                                            <asp:ListItem Value="CRG">Corregimiento</asp:ListItem>
                                            <asp:ListItem Value="INS">Inspección</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                    <%--APN--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">APN</div>
                                        <asp:TextBox ID="txtapn" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <%--FALLA UBICACION--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Lineas con falla en la Ubicación Reportada</div>
                                        <asp:DropDownList ID="drlFlineasfalla" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                            <asp:ListItem>SI</asp:ListItem>
                                            <asp:ListItem>NO</asp:ListItem>
                                            <asp:ListItem>NS/NR</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center Subtitulos">VALIDACIONES SERVIVIO AL CLIENTE</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            La falla se presenta luego de que se<br />
                                            construyera una edificación aledaña
                                        </div>
                                        <asp:DropDownList Style="height: 40px" ID="Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania"
                                            runat="server" CssClass="form-control">
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
                                        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_1"
                                                    runat="server" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                                <br />
                                                <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_2" runat="server"
                                                    CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tecnología en la que se presenta la<br />
                                            falla - Luego de pruebas
                                        </div>
                                        <asp:DropDownList ID="Drl_Tecnologia_Presenta_Falla_Luegodepruebas"
                                            runat="server" Height="40px" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Línea no cuenta con bloqueos de Internet</div>
                                        <asp:DropDownList ID="Drl_Linea_No_Cuenta_Bloqueos_Internet" runat="server" Height="40px" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Línea no se encuentra enrutada por pagos</div>
                                        <asp:DropDownList ID="Drl_Linea_No_Encuentra_Enrutada_PorPagos" runat="server" Height="40px" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            No existen cambios administrativos
                                            <br />
                                            sobre la línea o cuenta maestra
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra"
                                                    runat="server" AutoPostBack="True" Height="40px" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem Value="FALSO"></asp:ListItem>
                                                    <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                                </asp:DropDownList>
                                                <br />
                                                <asp:DropDownList ID="Drl_Split_Billing" runat="server" Height="40px"
                                                    Visible="False" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Se forza la red del dispositivo</div>
                                        <asp:DropDownList ID="Drl_Forza_Red_Dispositivo" runat="server" Height="40px" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Equipo se encuentra homologado por el operador</div>
                                        <asp:DropDownList ID="Drl_Equipo_Encuentra_Homologado_Operador" runat="server" Height="40px" CssClass="form-control">
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
                                            La falla se presenta luego de que se<br />
                                            remodelara la estructura física del edificio
                                        </div>
                                        <asp:DropDownList ID="Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio"
                                            runat="server" CssClass="form-control" Height="40px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Validaciones de falla masiva</div>
                                        <asp:DropDownList ID="Drl_Validaciones_Falla_Masiva" runat="server"
                                            CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Validación de Coordenadas</div>
                                        <asp:TextBox ID="Txt_Validacion_Coordenadas" runat="server" MaxLength="20" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Línea no ha superado el limite de consumos</div>
                                        <asp:DropDownList ID="Drl_Linea_No_Superado_Limite_Consumos" runat="server" Height="40px" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">HLR / HSS</div>
                                        <asp:DropDownList ID="Drl_HLR_HSS" runat="server" Height="40px" CssClass="form-control">
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
                                        <asp:DropDownList ID="Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla" runat="server" Height="40px" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Se verifica o realiza configuración de APN</div>
                                        <asp:DropDownList ID="Drl_Verifica_Realiza_Configuración_APN" runat="server" Height="40px" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Se realiza conciliación sobre la línea</div>
                                        <asp:DropDownList ID="Drl_Realiza_Conciliacion_Sobre_linea" runat="server" Height="40px" CssClass="form-control">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                        <%--ESCALAMIENTO SERVICE--%>
                        <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                            <ContentTemplate>
                                <asp:Panel ID="Panel_Service" runat="server" Visible="false">
                                    <div class="text-center Subtitulos">ESCALAMIENTO SERVICE</div>
                                    <div class="Form">
                                        <div class="Cell-Form">
                                            <%--APN--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">APN</div>
                                                <asp:DropDownList ID="drlapn" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>

                                            <%--ERROR EN REGISTRO--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">Error en registro</div>
                                                <asp:UpdatePanel ID="UpdatePanel_Variable_Diagnostico_2_drl" runat="server">
                                                    <ContentTemplate>
                                                        <asp:DropDownList ID="drlvariable" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </div>
                                            <%--QOS--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">Qos</div>
                                                <asp:DropDownList ID="drlqos" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="Space-Form"></div>
                                        <div class="Cell-Form">
                                            <%--Fecha activacion--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    Fecha Activación
                                    <asp:CompareValidator ID="CompareValidator_fcactivacion" runat="server" ControlToValidate="txtfcactivacion" ErrorMessage="*" Operator="DataTypeCheck" Type="Date" />
                                                </div>
                                                <asp:TextBox ID="txtfcactivacion" runat="server" placeholder="DD/MM/YYYY" MaxLength="10" CssClass="form-control Fecha"></asp:TextBox>
                                            </div>
                                            <%--DESCRIPCION ERROR EN REGISTRO--%>
                                            <div class="input-group">
                                                <div class="input-group-addon"></div>
                                                <asp:UpdatePanel ID="UpdatePanel_Variable_Diagnostico_3_Lbl" runat="server">
                                                    <ContentTemplate>
                                                        <asp:Label ID="lblvariable" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px; font-size: x-small" CssClass="form-control" Enable="False"></asp:Label>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </div>
                                            <%--Archivo--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">Archivo</div>
                                                <asp:FileUpload ID="FileDocumento" runat="server" CssClass="btn btn-crm" />
                                            </div>
                                        </div>
                                    </div>
                                </asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <div class="text-center Subtitulos"></div>
                    </section>
                    <%--Rechazados--%>
                    <%--<section>
                        <asp:Panel ID="Panel_rechazados" runat="server" Visible="false">
                            <div class="text-center Subtitulos">REGISTRO INCONSISTENCIA *611</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <asp:Button Text="Guardar" ID="btn_guarda_recha" CssClass="btn btn-primary" runat="server" ValidationGroup="VG_Rechazar"/>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                </div>
                            </div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Min
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_min_recha" Display="Dynamic" ValidationGroup="VG_Rechazar" ErrorMessage="*" CssClass="textoError" />
                                            <asp:RegularExpressionValidator runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txt_min_recha" Display="Dynamic" ValidationGroup="VG_Rechazar" />
                                            <asp:CompareValidator runat="server" ControlToValidate="txt_min_recha" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="VG_Rechazar" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_min_recha" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Usuario Reporta *611</div>
                                        <asp:TextBox ID="txt_usu_report_recha" CssClass="form-control" runat="server" MaxLength="10"/>
                                    </div>
                                
                                    <div class="input-group">
                                        <div class="input-group-addon">Nivel</div>
                                        <asp:DropDownList ID="drl_nivel_recha" CssClass="form-control" runat="server" AutoPostBack="True" Enabled="false">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                            <asp:ListItem Text="Call" />
                                            <asp:ListItem Text="Operacion" />
                                            <asp:ListItem Text="Call/Operac" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipificación</div>
                                        <asp:DropDownList ID="drl_tipificacion_recha" CssClass="form-control" runat="server" AutoPostBack="True" Enabled="false">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            ID AVAYA
                                         <asp:RequiredFieldValidator runat="server" ControlToValidate="txt_avaya_recha" Display="Dynamic" ValidationGroup="VG_Rechazar" ErrorMessage="*" />
                                            <asp:CompareValidator runat="server" ControlToValidate="txt_avaya_recha" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="VG_Rechazar" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{20,200}$" ControlToValidate="txt_avaya_recha" Display="Dynamic" ValidationGroup="VG_Rechazar" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="txt_avaya_recha" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Ubicacion Call Center</div>
                                        <asp:DropDownList ID="drl_ubicacion_call_recha" CssClass="form-control" runat="server" AutoPostBack="True" Enabled="true">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Custcode</div>
                                        <asp:TextBox ID="txt_custcode_recha" CssClass="form-control" runat="server" MaxLength="15"/>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo Inconsistencia</div>
                                        <asp:DropDownList ID="drl_inconsistencia_recha" CssClass="form-control" runat="server" Enabled="false">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                              
                                </div>
                            </div>
                              <div class="text-center Subtitulos">OBSERVACIÓN</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <asp:TextBox ID="txt_obs_recha" TextMode="MultiLine" CssClass="form-control" runat="server" />
                            </div>
                        </div>
                        </asp:Panel>
                    </section>--%>
                    <section>
                        <asp:Panel ID="Pnl_Llamada_Corta" Visible="false" runat="server">
                            <div class="text-center Subtitulos">Llamada Corta</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            ID AVAYA
                                         <asp:RequiredFieldValidator runat="server" ControlToValidate="Txt_Id_Avaya_Ll_Co" Display="Dynamic" ValidationGroup="VG_Rechazar" ErrorMessage="*" />
                                            <asp:CompareValidator runat="server" ControlToValidate="Txt_Id_Avaya_Ll_Co" ErrorMessage="*" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="VG_Rechazar" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{20,200}$" ControlToValidate="Txt_Id_Avaya_Ll_Co" Display="Dynamic" ValidationGroup="VG_Rechazar" />
                                        </div>
                                        <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="Txt_Id_Avaya_Ll_Co" TabIndex="1" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                    <asp:Panel ID="Pnl_Txt_Caso_ll_co" Visible="false" runat="server">
                                        <div class="input-group">
                                            <div class="input-group-addon">Caso
                                                <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="Txt_Caso_ll_co" Operator="DataTypeCheck" Type="Double" Display="Dynamic" ValidationGroup="Ll_CO" >*</asp:CompareValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ValidationExpression="^[\w \# \. \: \- \s]{8,200}$" ControlToValidate="Txt_Caso_ll_co" Display="Dynamic" ValidationGroup="Ll_CO">*</asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="Txt_Caso_ll_co" TabIndex="3" MaxLength="8" CssClass="form-control" runat="server"/>
                                        </div>
                                    </asp:Panel>

                                    <div class="input-group">
                                        <div class="input-group-addon">Ubicacion Call Center</div>
                                        <asp:DropDownList ID="drl_ubicacion_call_ll_co" TabIndex="3" CssClass="form-control" runat="server" AutoPostBack="True" Enabled="true">
                                            <asp:ListItem Value="1" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div><h3></h3>
                                    <asp:Button ID="Btn_Guardar_Ll_Co" TabIndex="5" CssClass="btn btn-primary" Text="Guardar" runat="server" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo de Llamada</div>
                                        <asp:DropDownList ID="Drl_Tipo_llamada_ll_co" TabIndex="2" CssClass="form-control" runat="server" AutoPostBack="True" Enabled="true">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Observacion</div>
                                        <asp:TextBox ID="Txt_Obs_Ll_Co" TextMode="MultiLine" TabIndex="4" CssClass="form-control" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                    </section>
                    <section>
                        <div class="Form">
                            <h5 style="color: #8F9E45; text-align: center"><em>
                                <asp:LinkButton ID="LinkButton3" runat="server" Style="color: #8F9E45">Reportar Inconsistencia</asp:LinkButton>
                                <asp:LinkButton ID="LinkButton4" runat="server" Visible="False" Style="color: #8F9E45">Ocultar Inconsistencia</asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;
                            </em>
                            </h5>
                        </div>
                    </section>
                    <section>
                        <asp:Panel ID="Panel_inconsistencia" runat="server" Visible="false">
                          <div class="text-center TituloCRM">REGISTRO DE INCONSISTENCIA</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <%--custcode--%>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" Type="Decimal" Display="Dynamic" runat="server" ValidationGroup="VG_Reg_Inconistencia" ControlToValidate="Txt_custcode" ValidationExpression="([0-9]|\.)*">El custcode debe ser numerico</asp:RegularExpressionValidator>
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
                                 <asp:Button Text="Guardar" ID="btn_guarda_inc" CssClass="btn btn-crm" runat="server" ValidationGroup="VG_Reg_Inconistencia" />
                                 <h4></h4>
                             </div>

                        </asp:Panel>
                    </section>
                    <section class="DataGrids">
                    <div class="Leyendas">
                            <asp:Label ID="Lbl_Cantidad" runat="server" /></div>
                        <div class="bordes">
                            <asp:GridView ID="Dtg_Asignados" runat="server" AllowPaging="True" PageSize="5" AutoGenerateColumns="True" PagerSettings-NextPageImageUrl="../Css2/Imagenes/flecha.png" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div><br />

                    </section>
                    <asp:Panel ID="PanelCasos" runat="server">
                        <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                            <ContentTemplate>
                                <h4 style="color: #8F9E45;"><em>
                               
                                </em></h4>
                                <div class="bordes">
                                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                        CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="80" Width="100%"
                                        Style="font-size: x-small">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="id_crm" HeaderText="ID" />
                                            <asp:BoundField DataField="Caso" HeaderText="Caso" />
                                            <asp:BoundField DataField="Min" HeaderText="Min" />
                                            <asp:BoundField DataField="Fec_registro" HeaderText="Fecha Registro" />
                                            <asp:BoundField DataField="usuario" HeaderText="Agente" />
                                            <asp:BoundField DataField="Observacion" HeaderText="Observación" />                                            
                                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                                            <asp:BoundField DataField="fec_programado" HeaderText="Fecha Programación" />
                                        </Columns>
                                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                                </div>
                                <div class="bordes">
                                    <asp:GridView ID="dtgcoincidentes" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                        CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="80" Width="100%"
                                        Style="font-size: x-small" Visible="False">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                                            <asp:BoundField DataField="min_ac" HeaderText="MIN" />
                                            <asp:BoundField DataField="estado" HeaderText="Estado" />
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
                                <asp:PostBackTrigger ControlID="btn_guardar" />
                            </Triggers>
                        </asp:UpdatePanel>

                    </asp:Panel>
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>
        <footer></footer>
    </form>
</body>
</html>
