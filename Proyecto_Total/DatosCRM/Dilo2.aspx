<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Dilo2.aspx.vb" Inherits="digitacion.Dilo2" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>
<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
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
    <asp:ScriptManager runat="server">
    </asp:ScriptManager>
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
                                <div class="text-center TituloCRM">CONSULTA DE CASOS</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <asp:CompareValidator runat="server" ControlToValidate="txtcaso" Display="Dynamic" Operator="DataTypeCheck" ValidationGroup="VG_Consultar" Type="Double">El caso debe ser numérico</asp:CompareValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Caso</div>
                                            <asp:TextBox ID="txtcaso" CssClass="form-control" runat="server" />
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <asp:Button ID="Btn_Consultar" CssClass="btn btn-crm" Text="Buscar" ValidationGroup="VG_Consultar" runat="server" />                                        
                                        <asp:Label ID="lblescalamiento" runat="server" Style="color: #8F9E45; font-size: medium; font-style: italic"></asp:Label>
                                    </div>
                                </div>
                                <div class="Separator"></div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Reporte</div>
                                            <asp:Label runat="server" ID="lblfcreporte" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tel Contacto</div>
                                            <asp:Label runat="server" ID="lbltelcontacto" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Equipo</div>
                                            <asp:Label runat="server" ID="lblequipo" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipo Falla</div>
                                            <asp:Label runat="server" ID="lbltipofalla" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Mesa</div>
                                            <asp:Label runat="server" ID="lblmesa" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Barrio</div>
                                            <asp:Label runat="server" ID="lblbarrio" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Ingreso</div>
                                            <asp:Label runat="server" ID="Lblfc_ingreso" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                    <div class="input-group-addon">Canal</div>
                                    <asp:Label runat="server" ID="lbl_canal" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                </div>

                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Min</div>
                                            <asp:Label runat="server" ID="lblmin" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Cliente</div>
                                            <asp:Label runat="server" ID="lblcliente" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tecnología</div>
                                            <asp:Label runat="server" ID="lbltecnologia" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado</div>
                                            <asp:Label runat="server" ID="lblestado" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Solicitud</div>
                                            <asp:Label runat="server" ID="lblsolicitud" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Caso</div>
                                            <asp:Label runat="server" ID="lblcaso" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Numero Alterno</div>
                                            <asp:Label runat="server" ID="lblNumero_Alterno" CssClass="form-control" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                        </section>
                        <section>
                            <div class="text-center TituloCRM">REGISTRO DE SEGUIMIENTO</div>
                            <div class="Form">
                                <asp:Button Text="Guardar" ID="btnguardar" CssClass="btn btn-crm" ValidationGroup="VG_Registrar" runat="server" />
                            </div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Departamento</div>
                                        <asp:DropDownList ID="drldpto" TabIndex="6" CssClass="form-control" AutoPostBack="True" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Barrio</div>
                                        <asp:TextBox ID="txtbarrio" TabIndex="8" CssClass="form-control" runat="server" />
                                       <span class="input-group-btn">
                                            <asp:Button Text="Actualizar" ID="Btn_Act_Barrio" Visible="false" CssClass="btn btn-crm" runat="server" />
                                        </span>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Municipio</div>
                                        <asp:DropDownList ID="drlmun" TabIndex="7" CssClass="form-control" AutoPostBack="True" runat="server">
                                            <asp:ListItem Value="0" Text="- SELECCIONE -" />
                                        </asp:DropDownList>
                                        <span class="input-group-btn">
                                            <asp:Button Text="Actualizar" ID="Btn_Act_Mun" Visible="false" CssClass="btn btn-crm" runat="server" />
                                        </span>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Se comunica a linea alterna<asp:CompareValidator ID="CompareValidator3"  Display="Dynamic" runat="server" ControlToValidate="txtnumalt" ValidationGroup="VG_Registrar" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                        <asp:RegularExpressionValidator ID="telefono" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txtnumalt" ValidationGroup="VG_Registrar" Display="Dynamic" CssClass="textoError" /><asp:RadioButton ID="chkSi" TabIndex="9" runat="server" GroupName="Numero" Text="SI" AutoPostBack="true" /><asp:RadioButton ID="chkNo" TabIndex="10" runat="server" GroupName="Numero" Text="NO" AutoPostBack="true" /></div>
                                        <asp:TextBox ID="txtnumalt" runat="server" MaxLength="10" TabIndex="11" CssClass="form-control" Enabled="False" placeholder="Numero"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center Sub-TituloCRM">CATALOGO DE DIAGNOSTICO</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Línea de Servicio</div>
                                        <asp:DropDownList ID="drllinea" TabIndex="12" CssClass="form-control" AutoPostBack="true" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Solicitud / Tipo Falla</div>
                                        <asp:DropDownList ID="drlsolicitud" TabIndex="14" CssClass="form-control" AutoPostBack="true" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Segmento</div>
                                        <asp:DropDownList ID="drlSegmento" TabIndex="16" CssClass="form-control" AutoPostBack="true" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Servicio</div>
                                        <asp:DropDownList ID="drlservicio2" TabIndex="13" CssClass="form-control" AutoPostBack="true" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Modalidad</div>
                                        <asp:DropDownList ID="drlModalidad" TabIndex="15" CssClass="form-control" AutoPostBack="true" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Causa raiz</div>
                                        <asp:DropDownList ID="drlCausa_Raiz" TabIndex="17" CssClass="form-control" AutoPostBack="true" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="text-center Sub-TituloCRM">CATEGORIA DE CIERRE</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipificación Llamada</div>
                                        <asp:DropDownList ID="drltipificacionll" TabIndex="18" CssClass="form-control" AutoPostBack="true" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <asp:CompareValidator ID="CV_PQR" runat="server" ControlToValidate="TxtPQR" Display="Dynamic" ValidationGroup="VG_Registrar" Operator="DataTypeCheck" Type="Integer">El valor del PQR debe ser numerico</asp:CompareValidator>
                                    <div class="input-group">
                                        <div class="input-group-addon">PQR</div>
                                        <asp:Label ID="LblPQR" runat="server" Width="65%" Style="text-align: right;" CssClass="form-control"></asp:Label>
                                        <asp:TextBox ID="TxtPQR" runat="server" TabIndex="20" MaxLength="7" Width="35%" CssClass="form-control"></asp:TextBox>
                                    </div>
                                      <%--Justificación Seguimiento--%>
                                <asp:Panel ID="Panel_Justificacion" Visible="false" runat="server">
                                    <div class="input-group">
                                        <div class="input-group-addon">Justificación Seguimiento</div>
                                        <asp:DropDownList ID="Drl_justificacion_seguimiento" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                    </div>
                                </asp:Panel>
                                             <%--Estacion Base--%>
                                <asp:Panel ID="Pnl_Estacion" Visible="false" runat="server">
                                    <div class="input-group">
                                        <div class="input-group-addon">Estacion base</div>
                                        <asp:TextBox ID="txt_Estacion_base" TabIndex="8" CssClass="form-control" runat="server" />
                                    </div>
                                </asp:Panel>

                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Categoria de cierre</div>
                                        <asp:DropDownList ID="drlCategoriaCierre" TabIndex="19" CssClass="form-control" AutoPostBack="true" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo PQR</div>
                                        <asp:DropDownList ID="drlTipo_PQR" TabIndex="21" CssClass="form-control" AutoPostBack="true" runat="server">
                                            <asp:ListItem Value="0" Text="- Seleccione -" />
                                        </asp:DropDownList>
                                        <span class="input-group-btn">
                                            <asp:Button Text="Actualizar" ID="Btn_Act_PQR" Visible="false" CssClass="btn btn-crm" runat="server" />
                                        </span>
                                    </div>
                                          <%--Tipo Canal--%>
                                <asp:Panel ID="Pnl_Tipo_canal" Visible="false" runat="server">
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo Canal</div>
                                        <asp:DropDownList ID="drl_tipo_canal" TabIndex="21" CssClass="form-control" AutoPostBack="true" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </asp:Panel>

                                </div>
                            </div>
                            <asp:Panel ID="Pnl_Seguimiento" Visible="false" runat="server" >
                                <div class="text-center Sub-TituloCRM">SEGUIMIENTO</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Programacion</div>
                                            <asp:TextBox ID="txtfc_programado" TabIndex="22" runat="server" CssClass="form-control HoraFecha" MaxLength="18" placeholder="DD/MM/YYYY H:mm:ss"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Liberar Caso</div>
                                            <asp:DropDownList ID="drlLibera" TabIndex="23" CssClass="form-control" AutoPostBack="True" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Value="SI" Text="SI" />
                                                <asp:ListItem Value="NO" Text="NO" />                                  
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                            <div class="text-center Sub-TituloCRM">INCONSISTENCIA DISTRIBUIDOR</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--dEPTO DISTRIBUIDOR--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Departamento Distribuidor</div>
                                    <asp:DropDownList ID="drldpto_incon"  CssClass="form-control" AutoPostBack="True" runat="server">                                    
                                    </asp:DropDownList>
                                </div>
                                <%--Distribuidor--%>
                                     <div class="input-group">
                                    <div class="input-group-addon">Distribuidor</div>
                                    <asp:TextBox ID="Txt_Distribuidor"  CssClass="form-control" MaxLength="80" runat="server" />
                                    <span class="input-group-btn">
                                        <asp:Button Text="Actualizar" ID="Btn_Actualizar_Distribuidor" Visible="false" CssClass="btn btn-crm" runat="server" />
                                    </span>
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <%--Municipio distribuidor--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Municipio</div>
                                    <asp:DropDownList ID="drlmun_incon"  CssClass="form-control" AutoPostBack="True" runat="server">                                   
                                    </asp:DropDownList>
                                    <span class="input-group-btn">
                                        <asp:Button Text="Actualizar" ID="Btn_Actualizar_Mun_Distri" Visible="false" CssClass="btn btn-crm" runat="server" />
                                    </span>
                                </div>
                            </div>
                        </div>

                            <div class="text-center Sub-TituloCRM">OBSERVACION</div>
                            <div class="Form">
                                <asp:TextBox ID="txtobs" TabIndex="26" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                            </div>
                        </section>                        
                        <asp:Panel ID="pnservice" runat="server" Visible="False">
                            <section>
                                <div class="text-center TituloCRM">ESCALAMIENTO SERVICE</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Apn</div>
                                            <asp:DropDownList ID="drlapn" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">QoS</div>
                                            <asp:DropDownList ID="drlqos" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                <asp:Label ID="Lbl_Title" runat="server" /></div>
                                            <asp:DropDownList ID="drlvariable" CssClass="form-control" runat="server" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Imagen</div>
                                            <asp:FileUpload ID="FileDocumento" Width="100%" Height="50%" CssClass="btn btn-primary" runat="server" />
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Activación</div>
                                            <asp:TextBox ID="txtfcactivacion" CssClass="form-control Fecha" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" />
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Diagnostico</div>
                                            <asp:RadioButtonList ID="rdbron" CssClass="form-control" RepeatDirection="Horizontal" runat="server" AutoPostBack="True" Font-Size="XX-Small">
                                                <asp:ListItem Text="Error en Registro" Selected="True" />
                                                <asp:ListItem Text="Ajeno a Red Celular" />
                                                <asp:ListItem Text="Asociado Red Celular" />
                                            </asp:RadioButtonList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon"></div>
                                            <asp:Label ID="lblvariable" runat="server" CssClass="form-control" Font-Size="X-Small" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px;"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </section>
                        </asp:Panel>
                        <asp:Panel ID="PNEscalam" runat="server" Visible="False">
                            <section>
                                <div class="text-center TituloCRM">REGISTRO FALLA DE RED</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Persona Contacto</div>
                                            <asp:TextBox ID="txtFcontacto" CssClass="form-control" runat="server" />
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tiempo Falla</div>
                                            <asp:DropDownList ID="drlFtiempo" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Value="&lt;=15" Text="&lt;=15" />
                                                <asp:ListItem Value="&gt;15" Text="&gt;15" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Características de la Falla</div>
                                            <asp:DropDownList ID="drlFcaract" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Nombre Vereda o Corregimiento</div>
                                            <asp:TextBox ID="txtFciudad" CssClass="form-control" runat="server" />
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Dirección Falla</div>
                                            <asp:TextBox ID="txtFdirecc" CssClass="form-control" runat="server" />
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Marca</div>
                                            <asp:DropDownList ID="drlmarca" AutoPostBack="True" CssClass="form-control" runat="server">
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">APN</div>
                                            <asp:TextBox ID="txtapn" CssClass="form-control" runat="server" />
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Lineas con falla en la Ubicación Reportada</div>
                                            <asp:DropDownList ID="drlFlineasfalla" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Value="SI" Text="SI" />
                                                <asp:ListItem Value="NO" Text="NO" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Canal Dilo</div>
                                            <asp:DropDownList ID="DrlCanalDilo" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <%--número de identificación contacto--%>
                                        <asp:CompareValidator Id="CV_Txt_N_Doc_Id_CPD" Display="Dynamic" ControlToValidate="Txt_N_Doc_Id_CPD" Operator="DataTypeCheck" Type="Integer" ValidationGroup="VG_Registrar" runat="server" >El número de Nit/Cedula debe ser un número entero</asp:CompareValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">NIT / Cedula
                                                <asp:RequiredFieldValidator  Id="RFV_Txt_N_Doc_Id_CPD" ValidationGroup="VG_Registrar" Display="Dynamic" ControlToValidate="Txt_N_Doc_Id_CPD" runat="server" >*</asp:RequiredFieldValidator>
                                            </div>
                                            <asp:TextBox ID="Txt_N_Doc_Id_CPD" runat="server" CssClass="form-control" MaxLength="15"></asp:TextBox>
                                        </div>
                                        <asp:RegularExpressionValidator runat="server" ControlToValidate="txtFnum" ValidationGroup="VG_Registrar" Display="Dynamic" SetFocusOnError="True" ValidationExpression="^[0-9\s]{0,100}$">El Número Contacto debe ser numerico</asp:RegularExpressionValidator>
                                        <div class="input-group">
                                            <div class="input-group-addon">Número Contacto</div>
                                            <asp:TextBox ID="txtFnum" MaxLength="10" CssClass="form-control" runat="server" />
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Tipo Falla</div>
                                            <asp:TextBox ID="txtFtipofalla" CssClass="form-control" runat="server" />
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Línea Portada</div>
                                            <asp:DropDownList ID="drlFportada" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Text="FALSO" />
                                                <asp:ListItem Text="VERDADERO" />
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
                                            <div class="input-group-addon">Condiciones de Uso</div>
                                            <asp:DropDownList ID="drlFtectolog" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                                <asp:ListItem Text="GSM" />
                                                <asp:ListItem Text="3G" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Equipo&nbsp;&nbsp;<asp:Label ID="lblctrl" runat="server">0</asp:Label></div>
                                            <asp:DropDownList ID="drlequipo" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">QoS</div>
                                            <asp:DropDownList ID="Drl_Qos" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="0" Text="- Seleccione -" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">Observación Cliente</div>
                                            <asp:TextBox ID="txtfobs" TextMode="MultiLine" CssClass="form-control" runat="server" />
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
                        <section>
                            <div style="text-align:center;">
                                <div class="Separator"></div>
                                <h5><em>
                                    <asp:LinkButton ID="LinkButton3" runat="server" CssClass="linkbutton" ForeColor="#8F9E45">Reportar Inconsistencia</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButton4" runat="server" CssClass="linkbutton" ForeColor="#8F9E45" Visible="False">Ocultar Inconsistencia</asp:LinkButton>
                                </em></h5>
                            </div>
                            <asp:Panel ID="Pninc" runat="server" Visible="False">
                                <div class="text-center TituloCRM">REGISTRO DE INCONSISTENCIA</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <%--custcode--%>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Type="Decimal" ValidationGroup="VG_Reg_Inconsistencia" Display="Dynamic" runat="server" ControlToValidate="Txt_custcode" ValidationExpression="([0-9]|\.)*">El custcode debe ser numerico</asp:RegularExpressionValidator>
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
                                 <asp:Button Text="Guardar" ID="btnguardar0" ValidationGroup="VG_Reg_Inconsistencia" CssClass="btn btn-crm" runat="server" />
                                 <h4></h4>
                             </div>

                            </asp:Panel>
                        </section>
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID="btnguardar" />
                    </Triggers>
                </asp:UpdatePanel>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <h4><em style="color: #8F9E45">Casos Asignados: &nbsp;<asp:Label ID="lblcasos_asig" runat="server"></asp:Label>
                            &nbsp;&nbsp;</em></h4>
                        <div class="bordes">
                            <asp:GridView ID="dtgprog" runat="server" AllowPaging="True" CellPadding="4" EnableModelValidation="True" AutoGenerateColumns="true" ForeColor="#333333" GridLines="None" PageSize="5" Style="font-size: x-small" Width="100%">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" Font-Size="Small" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>
                        </div><br />
                        <h4><em style="color: #8F9E45">Consulta Seguimientos: </em>
                            <asp:Label ID="lblcuenta" runat="server" ForeColor="#8F9E45"></asp:Label>
                        </h4>
                        <div class="bordes">
                            <asp:GridView ID="dtggeneral" runat="server" AllowPaging="true" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None"  Width="100%" PageSize="10" 
                                Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="idcrmdilo" HeaderText="ID" />
                                    <asp:BoundField DataField="idcasodilo" HeaderText="Caso" />
                                    <asp:BoundField DataField="mesa" HeaderText="Mesa" />
                                    <asp:BoundField DataField="min" HeaderText="Min" />
                                    <asp:BoundField DataField="fcregistro" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                                    <asp:BoundField DataField="obs" HeaderText="Observación" />
                                    <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                                    <asp:BoundField DataField="incidente" HeaderText="Incidente" />
                                    <asp:BoundField DataField="estadoinc" HeaderText="Estado Incidente" />
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