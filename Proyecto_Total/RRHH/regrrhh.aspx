<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="regrrhh.aspx.vb" Inherits="digitacion.regrrhh" %>
<%@ Register Src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link rel="icon" href="favicon.ico" type="image/x-icon"/>
    <title>ERP Kamilion</title>
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/javascript" src="../Css2/scripts.js"></script>
    <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="../Css2/Kamilion.css" />
</head>
<body>
    <form id="form1" runat="server">
        <Control:Header ID="Header" runat="server" />
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Panel runat="server"  ID="Pnl_Alerta">
                    <asp:Label ID="Lbl_Alerta" runat="server"></asp:Label>
                </asp:Panel>
                <article>
                    <section>
                        <div class="Subtitulos text-center">Datos Personales</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">TI 
                                        <asp:RequiredFieldValidator Id="RFV_Drl_TI" ControlToValidate="Drl_TI" Display="Dynamic" InitialValue="0" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:DropDownList ID="Drl_TI"  CssClass="form-control" runat="server"></asp:DropDownList>
                                    <div class="input-group-addon">N° I
                                        <asp:RequiredFieldValidator Id="RFV_txtdocumento" ControlToValidate="txtdocumento" Display="Dynamic" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                        <asp:RequiredFieldValidator Id="RFV_txtdocumento_Ext" ControlToValidate="txtdocumento" Display="Dynamic" ValidationGroup="VG_Act_Ext" runat="server">*</asp:RequiredFieldValidator>
                                        <asp:RequiredFieldValidator Id="RFV_txtdocumento_Cons" ControlToValidate="txtdocumento" Display="Dynamic" ValidationGroup="VG_Cons" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:TextBox ID="txtdocumento"  CssClass="form-control" runat="server" ></asp:TextBox>
                                    <div class="input-group-btn">
                                        <asp:LinkButton runat="server" ID="Btn_Consultar" Font-Strikeout="false" ValidationGroup="VG_Cons" class="btn btn-primary Desplegar_Loading">
                                            <span class="glyphicon glyphicon-search"></span> Buscar
                                        </asp:LinkButton>
                                    </div>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nombres 
                                        <asp:RequiredFieldValidator Id="RFV_txtnombres" ControlToValidate="txtnombres" Display="Dynamic" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:TextBox ID="txtnombres" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">EPS 
                                        <asp:RequiredFieldValidator Id="RFV_drleps" ControlToValidate="drleps" Display="Dynamic" InitialValue="0" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:DropDownList ID="drleps" CssClass="form-control" runat="server"></asp:DropDownList>
                                    <div class="input-group-addon">FPS 
                                        <asp:RequiredFieldValidator Id="RFV_drlfps" ControlToValidate="drlfps" Display="Dynamic" InitialValue="0" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:DropDownList ID="drlfps" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Dirección</div>
                                    <asp:TextBox ID="txtdireccion" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nacionalidad 
                                        <asp:RequiredFieldValidator Id="RFV_Drl_Nacionalidad" ControlToValidate="Drl_Nacionalidad" Display="Dynamic" InitialValue="0" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:DropDownList ID="Drl_Nacionalidad" CssClass="form-control" AutoPostBack="true" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Nacimiento 
                                        <asp:RequiredFieldValidator Id="RFV_txtfcnac" ControlToValidate="txtfcnac" Display="Dynamic" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                        <asp:CompareValidator Id="CV_txtfcnac" ControlToValidate="txtfcnac" Display="Dynamic" ValidationGroup="VG_Rec_Act" Operator="DataTypeCheck" Type="Date" runat="server" >*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txtfcnac" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Genero 
                                        <asp:RequiredFieldValidator Id="RFV_drlgenero" ControlToValidate="drlgenero" Display="Dynamic" ValidationGroup="VG_Rec_Act" InitialValue="0" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:DropDownList ID="drlgenero" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">N° Hijos 
                                        <asp:CompareValidator Id="CV_txtnhijos" ControlToValidate="txtnhijos" Display="Dynamic" ValidationGroup="VG_Rec_Act" Operator="DataTypeCheck" Type="Integer" runat="server" >*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox ID="txtnhijos" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Nivel de Escolaridad 
                                        <asp:RequiredFieldValidator Id="RFV_Drl_Nivel_Academico" ControlToValidate="Drl_Nivel_Academico" Display="Dynamic" ValidationGroup="VG_Rec_Act" InitialValue="0" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:DropDownList ID="Drl_Nivel_Academico" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estudia 
                                        <asp:RequiredFieldValidator Id="RFV_rbtestudia" ControlToValidate="rbtestudia" Display="Dynamic" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:RadioButtonList ID="rbtestudia" RepeatDirection="Horizontal" Width="110px" AutoPostBack="true" CssClass="form-control " runat="server">
                                        <asp:ListItem Text="SI" />
                                        <asp:ListItem Text="NO" />
                                    </asp:RadioButtonList>
                                    <div class="input-group-addon">Semestre 
                                        <asp:RequiredFieldValidator Id="RFV_Txt_Semestre_Actual_U" ControlToValidate="Txt_Semestre_Actual_U" Display="Dynamic" ValidationGroup="VG_Rec_Act" Enabled="false" runat="server">*</asp:RequiredFieldValidator>
                                        <asp:CompareValidator Id="CV_Txt_Semestre_Actual_U" ControlToValidate="Txt_Semestre_Actual_U" Display="Dynamic" ValidationGroup="VG_Rec_Act" Operator="DataTypeCheck" Type="Integer" runat="server" >*</asp:CompareValidator>
                                    </div>
                                    <asp:TextBox runat="server"  ID="Txt_Semestre_Actual_U" Enabled="false" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Descanso</div>
                                    <asp:DropDownList ID="drlDescanso" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Ubicacion</div>
                                    <asp:TextBox ID="TxtUbicacion" CssClass="form-control" runat="server" />
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Código 
                                        <asp:RequiredFieldValidator Id="RFV_txtcodigo" ControlToValidate="txtcodigo" Display="Dynamic" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:TextBox ID="txtcodigo" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Apellidos 
                                        <asp:RequiredFieldValidator Id="RF_txtapellidos" ControlToValidate="txtapellidos" Display="Dynamic" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:TextBox ID="txtapellidos" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Teléfono 
                                        <asp:RegularExpressionValidator Id="CFV_txttelefono" ValidationExpression="^([0-9\-]{7,18})?$" Display="Dynamic"  ControlToValidate="txttelefono" runat="server">*</asp:RegularExpressionValidator>
                                    </div>
                                    <asp:TextBox ID="txttelefono" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-multi">
                                        Lugar de Nacimiento
                                        <div class="input-group">
                                            <div class="input-group-addon">Pais 
                                                <asp:RequiredFieldValidator Id="RFV_Drl_Pais_Nacimiento" ControlToValidate="Drl_Pais_Nacimiento" Display="Dynamic" InitialValue="0" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                            </div>
                                            <asp:DropDownList ID="Drl_Pais_Nacimiento" CssClass="form-control" AutoPostBack="true" runat="server"></asp:DropDownList>
                                            <div class="input-group-addon">Estado 
                                                <asp:RequiredFieldValidator Id="RFV_Drl_Estado_Nacimiento" ControlToValidate="Drl_Estado_Nacimiento" Display="Dynamic" InitialValue="0" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                            </div>
                                            <asp:DropDownList ID="Drl_Estado_Nacimiento" CssClass="form-control" AutoPostBack="true" runat="server"></asp:DropDownList>
                                            <div class="input-group-addon">Ciudad 
                                                <asp:RequiredFieldValidator Id="RFV_Drl_Ciudad_Nacimiento" ControlToValidate="Drl_Ciudad_Nacimiento" Display="Dynamic" InitialValue="0" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                            </div>
                                            <asp:DropDownList ID="Drl_Ciudad_Nacimiento" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">E-Mail 
                                        <asp:RegularExpressionValidator ID="REV_txtemail" runat="server" Display="Dynamic" ValidationGroup="VG_Rec_Act" ControlToValidate="txtemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                                    </div>
                                    <asp:TextBox ID="txtemail" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Estado Civil 
                                        <asp:RequiredFieldValidator Id="RFV_Drl_Estado_Civil" ControlToValidate="Drl_Estado_Civil" Display="Dynamic" ValidationGroup="VG_Rec_Act" InitialValue="0" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:DropDownList ID="Drl_Estado_Civil" CssClass="form-control" runat="server">                                    </asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">RH 
                                        <asp:RequiredFieldValidator Id="RFV_txtrh" ControlToValidate="txtrh" Display="Dynamic" ValidationGroup="VG_Rec_Act" runat="server">*</asp:RequiredFieldValidator>
                                    </div>
                                    <asp:TextBox ID="txtrh" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Profesión</div>
                                    <asp:TextBox ID="txtprofesion" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Observaciones</div>
                                    <asp:TextBox ID="txtobs" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                <div class="input-group-addon">Fotográfia</div>
                                    <input type="text" class="form-control lbl-input-file" disabled="disabled">
                                    <label class="input-group-btn">
                                        <span class="btn btn-primary">
                                            <span class="glyphicon glyphicon-open"> </span>
                                            Explorar 
                                            <asp:FileUpload ID="File_Fotografia" CssClass="file" runat="server" style="display: none;"/>
                                        </span>
                                    </label>
                                </div>
                            </div>
                        </div>
                        <asp:Panel runat="server" ID="Pnl_Datos_Laborales">
                            <div class="Subtitulos text-center ">Datos Laborales</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Área 
                                            <asp:RequiredFieldValidator Id="RFV_drlarea" ControlToValidate="drlarea" Display="Dynamic" InitialValue="0" runat="server" ValidationGroup="VG_Rec_Act">*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:DropDownList ID="drlarea" CssClass="form-control" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Cargo Interno</div>
                                        <asp:TextBox ID="txtcargo" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Proyecto 
                                            <asp:RequiredFieldValidator Id="RFV_drlproyecto" ControlToValidate="drlproyecto" Display="Dynamic" InitialValue="0" runat="server" ValidationGroup="VG_Rec_Act">*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:DropDownList ID="drlproyecto" CssClass="form-control" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Tipo Contrato 
                                            <asp:RequiredFieldValidator Id="RFV_Drl_Tipo_Contrato" ControlToValidate="Drl_Tipo_Contrato" Display="Dynamic" InitialValue="0" runat="server" ValidationGroup="VG_Rec_Act">*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:DropDownList ID="Drl_Tipo_Contrato" CssClass="form-control" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Auxilio Transporte 
                                            <asp:CompareValidator Id="CV_txtauxtransp" ControlToValidate="txtauxtransp" Display="Dynamic" ValidationGroup="VG_Rec_Act" Operator="DataTypeCheck" Type="Integer" runat="server" >*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="txtauxtransp" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha de Ingreso 
                                            <asp:CompareValidator ID="CV_txtfcing" runat="server" ControlToValidate="txtfcing" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="txtfcing" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha Inicio Operacion 
                                            <asp:CompareValidator ID="CV_TxtFechaIng" runat="server" ControlToValidate="TxtFechaIng" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="TxtFechaIng" runat="server" CssClass="form-control Fecha" placeholder="DD/MM/YYYY" MaxLength="80"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Empresa 
                                            <asp:RequiredFieldValidator Id="RFV_drlempresa" ControlToValidate="drlempresa" Display="Dynamic" InitialValue="0" runat="server" ValidationGroup="VG_Rec_Act">*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:DropDownList ID="drlempresa" CssClass="form-control" runat="server"/>
                                    </div>
                                    <asp:LinkButton runat="server" ID="Btn_Registrar" Font-Strikeout="false" ValidationGroup="VG_Rec_Act" class="btn btn-primary">
                                        <span class="glyphicon glyphicon-saved"></span> Guardar
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="Btn_Actualizar" Font-Strikeout="false" class="btn btn-primary">
                                        <span class="glyphicon glyphicon-edit"></span> Actualizar
                                    </asp:LinkButton>
                                    <asp:LinkButton runat="server" ID="Btn_Carga_Masiva" Font-Strikeout="false" class="btn btn-primary">
                                        <span class="glyphicon glyphicon-saved"></span> Carga Masiva
                                    </asp:LinkButton>
                                    
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Jefe Inmediato</div>
                                        <asp:DropDownList ID="drlJefe_Inmediato" CssClass="form-control" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Cargo Cliente</div>
                                        <asp:TextBox ID="TxtCargo_Cliente" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Segmento</div>
                                        <asp:TextBox ID="TxtSegmento" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Salario 
                                            <asp:CompareValidator Id="CV_txtsalario" ControlToValidate="txtsalario" Display="Dynamic" ValidationGroup="VG_Rec_Act" Operator="DataTypeCheck" Type="Integer" runat="server" >*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="txtsalario" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Bonificaciones 
                                            <asp:CompareValidator ID="CV_txtbonificacion" runat="server" ControlToValidate="txtbonificacion" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="txtbonificacion" CssClass="form-control" runat="server"/>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Fecha de Retiro 
                                            <asp:CompareValidator ID="CV_txtfcretiro" runat="server" ControlToValidate="txtfcretiro" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="txtfcretiro" placeholder="DD/MM/YYYY" CssClass="form-control Fecha" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Turno 
                                            <asp:RequiredFieldValidator Id="RFV_Drl_Turno" ControlToValidate="Drl_Turno" Display="Dynamic" InitialValue="0" runat="server" ValidationGroup="VG_Rec_Act">*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:DropDownList ID="Drl_Turno" CssClass="form-control" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Registro Masivo</div>
                                        <input type="text" class="form-control lbl-input-file" disabled="disabled">
                                        <label class="input-group-btn">
                                            <span class="btn btn-primary">
                                                <span class="glyphicon glyphicon-open"> </span>
                                                Explorar 
                                                <asp:FileUpload ID="File_Carga_Masiva" CssClass="file" runat="server" style="display: none;"/>
                                            </span>
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                        <asp:Panel ID="Pnl_Datos_Extras" runat="server">
                            <div class="Subtitulos text-center">Datos Extras</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Teléfono en caso de emergencia 
                                            <asp:RegularExpressionValidator ValidationExpression="^[0-9]{0,13}$" Display="Dynamic"  ControlToValidate="Txt_Tel_Contac_Emerg" ValidationGroup="VG_Act_Ext" runat="server">*</asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RFV_Txt_Tel_Contac_Emerg" ControlToValidate="Txt_Tel_Contac_Emerg" Display="Dynamic" ValidationGroup="VG_Act_Ext" runat="server" >*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:TextBox ID="Txt_Tel_Contac_Emerg" MaxLength="13" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">Antecedentes personales de salud 
                                            <asp:RequiredFieldValidator ID="RFV_Txt_Ant_Salud" ControlToValidate="Txt_Ant_Salud" Display="Dynamic" ValidationGroup="VG_Act_Ext" runat="server" >*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:TextBox ID="Txt_Ant_Salud" CssClass="form-control" TextMode="MultiLine" runat="server" />
                                    </div>
                                    <asp:LinkButton runat="server" ID="Btn_Act_Dat_Ext" Font-Strikeout="false" ValidationGroup="VG_Act_Ext" class="btn btn-primary Desplegar_Loading">
                                        <span class="glyphicon glyphicon-edit"></span> Actualizar
                                    </asp:LinkButton>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">Persona en caso de emergencia 
                                            <asp:RequiredFieldValidator ID="RFV_Txt_Contac_Emerg" ControlToValidate="Txt_Contac_Emerg" Display="Dynamic" ValidationGroup="VG_Act_Ext" runat="server" >*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:TextBox ID="Txt_Contac_Emerg" MaxLength="50" CssClass="form-control" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">¿Toma medicamentos?
                                            <asp:RequiredFieldValidator ID="RFV_Drl_Medicamentos" ControlToValidate="Drl_Medicamentos" Display="Dynamic" InitialValue="0" ValidationGroup="VG_Act_Ext" runat="server" >*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:DropDownList ID="Drl_Medicamentos" CssClass="form-control" AutoPostBack="true" runat="server"/>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">¿Cuales Medicamentos?
                                            <asp:RequiredFieldValidator ID="RFV_Txt_Obs_Medicamentos" ControlToValidate="Txt_Obs_Medicamentos" Display="Dynamic" ValidationGroup="VG_Act_Ext" Enabled="false" runat="server" >*</asp:RequiredFieldValidator>
                                        </div>
                                        <asp:TextBox ID="Txt_Obs_Medicamentos" CssClass="form-control" TextMode="MultiLine" runat="server" Enabled="false" />
                                    </div>
                                </div>
                            </div>
                        </asp:Panel>
                    </section>
                </article>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID = "Btn_Registrar"/>
                <asp:PostBackTrigger  ControlID = "Btn_Actualizar"/>
                <asp:PostBackTrigger  ControlID = "Btn_Carga_Masiva"/>
            </Triggers>
        </asp:UpdatePanel>
        <footer></footer>
    </form>
</body>
</html>