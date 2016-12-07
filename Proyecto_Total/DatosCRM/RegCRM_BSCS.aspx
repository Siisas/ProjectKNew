<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegCRM_BSCS.aspx.vb" Inherits="digitacion.RegCRM_BSCS" %>
<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>
<!DOCTYPE html>
<%--    © 2016 Crisitan Duarte C1477    --%>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kamilion CRM BSCS</title>
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
                        <%--------------CONSULTA CASO------------%>
                        <div class="text-center TituloCRM">CONSULTA DE CASO</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Caso   
                                            <asp:CompareValidator ID="CompareValidator2" runat="server"
                                                ControlToValidate="txtcaso" ErrorMessage="El caso debe ser un valor numérico"
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-btn">
                                        <asp:Button ID="Button1" runat="server" Text="Buscar" ValidationGroup="VG_Registrar" CssClass="btn btn-crm" />
                                    </span>
                                </div>
                            </div>
                            <%--CELDA DEL CENTRO--%>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                            </div>
                        </div>
                        <asp:Panel ID="Panel_consulta" runat="server" Visible="true">
                            <div class="Form">
                                <div class="Cell-Form">
                                    <%--MIN--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">MIN </div>
                                        <asp:Label ID="lblmin" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--CLIENTE--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Nombre </div>
                                        <asp:Label ID="lblcliente" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--EQUIPO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Equipo </div>
                                        <asp:Label ID="lblequipo" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--DEPARTAMENTO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Departamento Falla </div>
                                        <asp:Label ID="lbllugar" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--ESTADO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado </div>
                                        <asp:Label ID="lblestado" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--ES FALLATEC--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Es Fallatec </div>
                                        <asp:Label ID="lblfallatec" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--OBSERVACION *611--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Observacion *611 </div>
                                        <asp:Label ID="lblobs611" runat="server" Style="background-color: inherit; overflow: auto; height: auto; min-height: 35px; max-height: 100px" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <%--CASO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Caso </div>
                                        <asp:Label ID="lblcaso" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--DOCUMENTO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Documento </div>
                                        <asp:Label ID="lbldocumento" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--PLAN--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Plan </div>
                                        <asp:Label ID="lblplan" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--USUARIO ASIGNADO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Usuario asignado </div>
                                        <asp:Label ID="lblemail" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--NUMERO ALTERNO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Numero Alterno</div>
                                        <asp:Label ID="lblnumeroaler" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>
                                    <%--FECHA INGRESO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Ingreso </div>
                                        <asp:Label ID="Lblfc_ingreso" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                    </div>

                                </div>
                            </div>
                        </asp:Panel>
                        <div class="Form">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="Dtg_Control_Bscs" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                        GridLines="None" PageSize="5" Width="100%" Style="font-size: x-small"
                                        EnableModelValidation="True">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                        <%--------------------FALLA MASIVA--------------%>
                        <div class="text-center Sub-TituloCRM">FALLA MASIVA ACTIVA</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <%--OBS FALLA MASIVA--%>
                                <div class="input-group">
                                    <div class="input-group-addon">Descripción </div>
                                    <asp:Label ID="lblobsmasiva" runat="server" Style="background-color: inherit" CssClass="form-control" Enable="False"></asp:Label>
                                </div>
                            </div>
                            <%--CELDA DEL CENTRO--%>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <%--SOCIAR FALLA MASIVA--%>
                                <div class="input-group" style="text-align: left">
                                    <div class="input-group-addon">Asociar </div>
                                    <asp:CheckBox ID="chkmasiva" runat="server" AutoPostBack="True" CssClass="form-control" />
                                </div>
                            </div>
                        </div>
                        <%-------------------REGISTRO-----------%>
                        <asp:Panel ID="Panel_registro" runat="server" Visible="true">
                            <%----------------------GEORREFERENCIACION--------------%>
                            <div class="text-center TituloCRM">REGISTRO</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <asp:Button ID="btnguardar" runat="server" Text="Guardar" CssClass=" btn btn-crm" ValidationGroup="Crear" />
                                    </div>
                                </div>
                                <%--CELDA DEL CENTRO--%>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form"></div>
                            </div>
                            <div class="Form">
                                <div class="Cell-Form">
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
                                    <asp:UpdatePanel ID="UpdatePanel_Departamento" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Departamento</div>
                                                <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--BARRIO--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Barrio" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Barrio</div>
                                                <asp:TextBox ID="txtbarrio" runat="server" CssClass="form-control"></asp:TextBox>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="Btn_Habilita_Barrio" runat="server" Text="Actualizar" Visible="false" CssClass="btn btn-crm" />
                                                </span>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--CONDICIONES DE USO--%>
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    Condiciones de uso 
                                                </div>
                                                <asp:DropDownList ID="drlFtectolog" runat="server" CssClass="form-control">
                                                    <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>GSM</asp:ListItem>
                                                    <asp:ListItem>3G</asp:ListItem>
                                                </asp:DropDownList>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="Btn_Habilita_Tecnologia" runat="server" Text="Actualizar" CssClass="btn btn-crm" Visible="false" />
                                                </span>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <%--CELDA DEL CENTRO--%>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <%--EQUIPO--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Equipo" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    Equipo
                                                </div>
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
                                                <asp:DropDownList ID="drlmun" runat="server" CssClass="form-control"></asp:DropDownList>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="Btn_Habilita_Municipio" runat="server" Text="Actualizar" Visible="false" CssClass="btn btn-crm" />
                                                </span>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--FECHA ULTIMA CAIDA--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Fc_Utilma_Caida" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    Fecha Ultima Caida
                                                    <asp:CompareValidator ID="CompareValidator9" runat="server" ControlToValidate="txtultimc"
                                                        ErrorMessage="La fecha de última caida no es correcto" Operator="DataTypeCheck"
                                                        Type="Date">*</asp:CompareValidator>
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
                                                    <asp:RegularExpressionValidator ID="telefono" runat="server" ErrorMessage="*" ValidationExpression="^[\w \# \. \: \- \s]{10,200}$" ControlToValidate="txtnumalt" ValidationGroup="VG_Registrar" Display="Dynamic" CssClass="textoError" />
                                                </div>
                                                <div class="form-control" style="width: 100%">
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
                                </div>
                            </div>
                            <%------------------DIAGNOSTICO--------------%>
                            <div class="text-center Sub-TituloCRM">DIAGNOSTICO</div>
                            <div class="Form">
                                <div class="Cell-Form">

                                    <%--LINEA DE SERVICIO--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Linea_Servicio" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Linea de Servicio</div>
                                                <asp:DropDownList ID="drllinea" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--SOLICITUD--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Solicitud_Tipo_Falla" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Solicitud / Tipo Falla</div>
                                                <asp:DropDownList ID="drlsolicitud" runat="server" CssClass="form-control" AutoPostBack="True">
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--SEGMENTO--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Segmento" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Segmento</div>
                                                <asp:DropDownList ID="drlSegmento" runat="server" AutoPostBack="True" CssClass="form-control">
                                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <%--SEERVICIO--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Servicio" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Servicio</div>
                                                <asp:DropDownList ID="drlservicio2" runat="server" AutoPostBack="True" CssClass="form-control">
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--MODALIDAD--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Modalidad</div>
                                        <asp:DropDownList ID="drlModalidad" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <%--CAUSA RAIZ--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Causa_Raiz" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Causa raiz</div>
                                                <asp:DropDownList ID="drlCausa_Raiz" runat="server" CssClass="form-control" AutoPostBack="true">
                                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                            <%------------------CIERRE LLAMADA-----------%>
                            <div class="text-center Sub-TituloCRM">CIERRE LLAMADA</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <%--ESTADO CASO--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Estado Caso</div>
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="drltipificacionll" runat="server" AutoPostBack="True" CssClass="form-control"></asp:DropDownList>
                                                <br />
                                                <asp:DropDownList ID="DrlTipollamada" runat="server" AutoPostBack="True" CssClass="form-control" Visible="false">
                                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Campaña</asp:ListItem>
                                                    <asp:ListItem>Soporte</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>

                                    </div>
                                    <%--PQR--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Tipo_Grupo" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    PQR
                                                    <asp:CompareValidator ID="CV_PQR" runat="server" ControlToValidate="TxtPQR"
                                                        ErrorMessage="El valor del PQR debe ser numerico" Operator="DataTypeCheck"
                                                        Type="Integer">*</asp:CompareValidator>
                                                </div>
                                                <asp:Label ID="LblPQR" runat="server" CssClass="form-control" Width="60%"></asp:Label>
                                                <asp:TextBox ID="TxtPQR" runat="server" MaxLength="7" CssClass="form-control" Width="40%"></asp:TextBox>

                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--ACTUALIZACION CMC--%>
                                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Actualización por CMC</div>
                                                <asp:DropDownList ID="Drl_Actualizacion_CMC" runat="server" AutoPostBack="True" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>Si</asp:ListItem>
                                                    <asp:ListItem>No</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--CAUSA RAIZ CMC--%>
                                    <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Causa Raíz Registro de Línea</div>
                                                <asp:DropDownList ID="Drl_Causa_Raiz_Linea" runat="server" CssClass="form-control" Enabled="false" AutoPostBack="True"></asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                      <%--Justificación Seguimiento--%>
                                <asp:Panel ID="Panel_Justificacion" Visible="false" runat="server">
                                    <div class="input-group">
                                        <div class="input-group-addon">Justificación Seguimiento</div>
                                        <asp:DropDownList ID="Drl_justificacion_seguimiento" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                    </div>
                                </asp:Panel>

                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <%--CATEGORIA CIERRE--%>
                                    <asp:UpdatePanel ID="UpdatePanel_Categoria_Cierre_1" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Categoria de cierre</div>
                                                <asp:DropDownList ID="drlCategoriaCierre" runat="server" AutoPostBack="True"
                                                    CssClass="form-control">
                                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--TIPO PQR--%>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo PQR</div>
                                        <asp:DropDownList ID="drlTipo_PQR" runat="server" CssClass="form-control"></asp:DropDownList>
                                        <span class="input-group-btn">
                                            <asp:Button ID="Btn_Habilita_PQR" runat="server" Text="Actualizar" Visible="False" CssClass="btn btn-crm" />
                                        </span>
                                    </div>
                                    <%--novedad CMC--%>

                                    <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">El estado de la Línea después de CMC</div>
                                                <asp:DropDownList ID="Drl_Linea_CMC" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--ESTADO CMC--%>
                                    <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Novedad CMC</div>
                                                <asp:DropDownList ID="Drl_Novedad_CMC" runat="server" CssClass="form-control" Enabled="false" AutoPostBack="True"></asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                            <%--------------SEGUIMIENTO--------------%>
                            <asp:Panel ID="Panel_seguimiento" runat="server" Visible="false">
                                <div class="text-center Sub-TituloCRM">SEGUIMIENTO</div>
                                <div class="Form">
                                    <%--FECHA PROGRAMADA--%>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Programacion </div>
                                            <asp:TextBox ID="txtfcprog" runat="server" MaxLength="20" placeholder="DD/MM/YYYY H:MM:SS" CssClass="form-control HoraFecha"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <%--LIBERAR CASO--%>
                                        <div class="input-group">
                                            <div class="input-group-addon">Liberar Caso</div>
                                            <asp:DropDownList ID="DrlLibera" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                            <%------------------ENCUESTA-----------------%>
                            <div class="text-center Sub-TituloCRM">ENCUESTA</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <%--ATENCION 611*--%>
                                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Satisfecha atención *611</div>
                                                <asp:DropDownList ID="drl611" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>SI</asp:ListItem>
                                                    <asp:ListItem>NO</asp:ListItem>
                                                    <asp:ListItem>NS/NR</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--INCONSISTENCIA 611--%>
                                    <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Inconsistencia atencion *611</div>
                                                <asp:DropDownList ID="drlinconsistencia" runat="server" AutoPostBack="True" Enabled="true" CssClass="form-control">
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <%--OBSERVACION 611--%>
                                    <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Percepción de servicio</div>
                                                <asp:TextBox ID="TxtPercep_Serv" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <%--OBS INCONSISTENCIA--%>
                                    <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                        <ContentTemplate>
                                            <div class="input-group">
                                                <div class="input-group-addon">Observacion de inconsistencia</div>
                                                <asp:TextBox ID="txtobsincon" runat="server" TextMode="MultiLine" AutoPostBack="true" CssClass="form-control" Enabled="false"></asp:TextBox>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                            <%-----------------OBSERVACION---------------%>
                            <div class="text-center Sub-TituloCRM">OBSERVACIÓN</div>
                            <div class="Form">
                                <asp:TextBox ID="txtobs" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox></center>
                            </div>
                        </asp:Panel>

                        <%--ESCALAMIENTO A FALLA DE RED--%>
                        <asp:Panel ID="PNEscalam" runat="server" Visible="false">
                            <div class="text-center TituloCRM">REGISTRO FALLA DE RED</div>
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
                            <div class="text-center Sub-TituloCRM">VALIDACIONES SERVIVIO AL CLIENTE</div>
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
                                <asp:Panel ID="pnservice" runat="server" Visible="false">
                                    <div class="text-center TituloCRM">ESCALAMIENTO SERVICE</div>
                                    <div class="Form">
                                        <div class="Cell-Form">
                                            <%--Causal de Escalamiento a Informática--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">Causal de Escalamiento</div>
                                                <asp:DropDownList ID="drl_causal_escalamiento_service" runat="server" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
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
                                            <%--Archivo--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">Archivo</div>
                                                <asp:FileUpload ID="FileDocumento" runat="server" CssClass="btn btn-crm" />
                                            </div>
                                        </div>
                                        <div class="Space-Form"></div>
                                        <div class="Cell-Form">
                                            <%--APN--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">APN</div>
                                                <asp:DropDownList ID="drlapn" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                            <%--Fecha activacion--%>
                                            <div class="input-group">
                                                <div class="input-group-addon">
                                                    <asp:Label ID="lbl_Fecha_Act_Ciclo" runat="server">Fecha Activacion</asp:Label>
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

                                        </div>
                                    </div>
                                </asp:Panel>

                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <div class="text-center Subtitulos"></div>
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
                        <%--REGISTRO INCONSISTENCIA--%>
                               <asp:Panel ID="Pninc" runat="server" Visible="False">
                                <div class="text-center TituloCRM">REGISTRO DE INCONSISTENCIA</div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <%--custcode--%>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Type="Decimal" Display="Dynamic" runat="server" ValidationGroup="VG_Reg_Inconsistencia" ControlToValidate="Txt_custcode" ValidationExpression="([0-9]|\.)*">El custcode debe ser numerico</asp:RegularExpressionValidator>
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
                                            <asp:DropDownList ID="drlincons" CssClass="form-control" runat="server">
                                                <asp:ListItem Value="1" Text="- Seleccione -" />
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
                                 <asp:Button Text="Guardar" ID="btnguardar0" CssClass="btn btn-crm" ValidationGroup="VG_Reg_Inconsistencia" runat="server" />
                                 <h4></h4>
                             </div>

                            </asp:Panel>
                    </section>

                    <%-------asignados--------%>
                    <section class="DataGrids">
                        <asp:Panel ID="PanelCasosAsignados" runat="server">
                            <asp:UpdatePanel ID="UpdatePanelCasosProgramados" runat="server">
                                <ContentTemplate>
                                    <h4 style="color: #8F9E45;"><em>Casos Asignados: 
                                        <asp:Label ID="LblCuentaAsignados" runat="server">0</asp:Label>
                                    </em></h4>
                                    <div class="bordes">
                                        <asp:GridView ID="dtgasig" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333"
                                            GridLines="None" PageSize="5" Width="100%" Style="font-size: x-small"
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
                        </asp:Panel>
                        <br />
                    </section>
                    <%--------gestiones--------%>
                    <section class="DataGrids"></section>
                    <asp:Panel ID="PanelCasos" runat="server">
                        <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                            <ContentTemplate>
                                <h4 style="color: #8F9E45;"><em>
                                    <asp:LinkButton ID="lnk1" runat="server" Style="color: #8F9E45">Ver Seguimiento</asp:LinkButton>
                                    &nbsp;
                                        <asp:Label ID="lblcuenta" runat="server">0</asp:Label>
                                    &nbsp;&nbsp;&nbsp;
                                        <asp:LinkButton ID="LinkButton2" runat="server" Style="color: #8F9E45">Ver Casos Asociados</asp:LinkButton>
                                    &nbsp;
                                        <asp:Label ID="lblcuenta1" runat="server">0</asp:Label>
                                </em></h4>
                                <div class="bordes">
                                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                        CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="80" Width="100%"
                                        Style="font-size: x-small">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="idcrm" HeaderText="ID" />
                                            <asp:BoundField DataField="cas_id" HeaderText="Caso" />
                                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Registro" />
                                            <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                                            <asp:BoundField DataField="obs" HeaderText="Observación" />
                                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                                            <asp:BoundField DataField="fcprogram" HeaderText="Fecha Programación" />
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
                                <asp:PostBackTrigger ControlID="btnguardar" />
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
