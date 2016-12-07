<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Historial_Equipos.aspx.vb" Inherits="digitacion.Historial_Equipos" %>
<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Kamilion ERP</title>
    <link rel="icon" href="~/favicon.ico" type="image/x-icon"/>              
    <link rel="shortcut icon" href="~/favicon.ico" type="image/x-icon"/>     
    <%--Jquery--%>
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <!--jqwidgets-->
    <script type="text/javascript" src="../Css2/jqwidgets/jqwidgets/jqx-all.js"></script>
    <%--Scripts--%>    
    <script type="text/javascript" src="../Css2/scripts.js"></script>
    <script type="text/javascript" src="Historial_Equipos.aspx.js"></script>
    <!--#########Estilos############-->
    <link type="text/css" rel="Stylesheet" href="~/Css2/Boot/css/bootstrap.min.css"/>   
    <link type="text/css" rel="Stylesheet" href="~/Css2/jquery-ui.css"/>   
    <link type="text/css" rel="stylesheet" href="~/Css2/jqwidgets/jqwidgets/styles/jqx.base.css"/>
    <link type="text/css" rel="Stylesheet" href="~/Css2/Kamilion.css"/>
</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <div class="Desplegable" id="Desp_Asign_Componentes">
            <article>
                <section>
                    <div class="text-center Subtitulos">
                        Filtrar Consulta de Componentes
                    </div>
                    <div class="Form">
                        <div class="Cell-Form">
                            <asp:UpdatePanel runat="server">
                                <ContentTemplate>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tipo
                                        </div>
                                        <asp:DropDownList ID="Drl_Tipo_Com_Asig" runat="server" CssClass="form-control" TabIndex="40"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Referencia
                                        </div>
                                        <asp:TextBox ID="Txb_Referencia_Com_Asig" runat="server" CssClass="form-control" TabIndex="42" ></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial
                                        </div>
                                        <asp:TextBox ID="Txb_Serial_Com_Asig" runat="server" CssClass="form-control" TabIndex="44" ></asp:TextBox>
                                    </div>
                                    <asp:Button ID="Btn_Consultar_Com_Asig" runat="server" CssClass="btn btn-primary Desplegar_Loading" Text="Consultar" TabIndex="46"/>
                                    <asp:Button ID="Btn_Clear_Com_Con_Asig" runat="server" CssClass="btn btn-primary" Text="Limpiar" TabIndex="47"/>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                        <div class="Space-Form"></div>
                        <div class="Cell-Form">
                            <asp:UpdatePanel runat="server">
                                <ContentTemplate>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Fabricante
                                        </div>
                                        <asp:DropDownList ID="Drl_Fabricante_Com_Asig" runat="server" CssClass="form-control" TabIndex="41"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Capacidad
                                        </div>
                                        <asp:DropDownList ID="Drl_Capacidad_Com_Asig" runat="server" CssClass="form-control" TabIndex="43"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Estado
                                        </div>
                                        <asp:DropDownList ID="Drl_Estado_Com_Asig" runat="server" CssClass="form-control" TabIndex="45"></asp:DropDownList>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <button id="Btn_Asig_Com" type="button"  class="btn btn-primary" tabindex="48">Asignar</button>                            
                            <button type="button" id="Btn_Cancel_Asig" class="btn btn-primary" tabindex="49">Cancelar</button>
                        </div>
                    </div>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:Panel id="Pnl_Alert_Asign" runat="server">
                                <asp:Label ID="Lbl_Alert_Asign" runat="server"></asp:Label>
                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div id="Grid_Com_Asig"  class="Grid_Js"></div>
                </section>
            </article>
        </div>
        <div id="Desp_Confirm" class="Desplegable">
            <div class="Dialog-Confirm">
                <div class="text-center Subtitulos">
                    <span class='glyphicon glyphicon-warning-sign'></span> ADVERTENCIA!
                </div>
                <asp:Label ID="Lbl_Msg_Confirm" runat ="server" ></asp:Label>
                <asp:RequiredFieldValidator runat="server" ID="RFV_Txb_Observacion" ValidationGroup="VG_Observacion" Display="Dynamic" ControlToValidate="Txb_Observacion">¡Observación obligatoria!</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ID="REV_Txb_Obs_Asignacion" ValidationGroup="VG_Observacion" Display="Dynamic" ControlToValidate="Txb_Observacion" ValidationExpression="^.{5,100}$">¡De 5 a 100 Caracteres! </asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator runat="server" ID="RFV_Drl_Estado_Ac_txt" ValidationGroup="VG_Actualizar_Com" Display="Dynamic" InitialValue="0" ControlToValidate="Drl_Estado_Com_Ac">¡No ha elegido ningun estado!</asp:RequiredFieldValidator>
                <asp:TextBox ID="Txb_Observacion" runat="server" TextMode="MultiLine" placeholder="Por favor ingrese un observación" CssClass="form-control" ></asp:TextBox>
                <asp:DropDownList runat="server" CssClass="form-control" ID="Drl_Estado_Com_Ac" style="width:90%; margin:auto"></asp:DropDownList>
                <div>
                    <button type="button" id="Btn_Confimr_Si" class="btn btn-primary">Continuar</button>
                    <button type="button" id="Btn_Confimr_No" class="btn btn-primary">Cancelar</button>
                </div>
            </div>
        </div>
        <div id="Desp_Loading" class="Desplegable"></div>
        <Control:Header ID="Header" runat="server" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Panel id="Pnl_Message" runat="server">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel runat="server" >
            <ContentTemplate>
                <article>
                    <section>
                        <asp:Button runat="server" OnClientClick="Chang_Panel()" ID="Btn_Change_Form" CssClass="btn btn-primary" Style="padding-bottom:20px; padding-top:0px; font-weight:bold; height:20px; border-radius:20px; border-bottom-left-radius: 0px; border-bottom-right-radius: 0px; margin-bottom:-20px;" Text="Cambiar Formulario"/>
                    </section>
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Panel ID="Pnl_Componentes" runat="server" >
            <article>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <section>
                                <div class="text-center Subtitulos">
                                    Registrar Componentes
                                </div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipo
                                                <asp:requiredfieldvalidator id="RFV_Drl_Tipo_Com_R" runat="server" Display="Dynamic" ValidationGroup="VG_Registrar_Com" ControlToValidate ="Drl_Tipo_Com_R" InitialValue="0" >*</asp:requiredfieldvalidator>
                                            </div>
                                            <asp:DropDownList ID="Drl_Tipo_Com_R" runat="server" CssClass="form-control" TabIndex="10"></asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Referencia
                                                <asp:RequiredFieldValidator runat="server" Id="RFV_Txb_Referencia_Com_R" ValidationGroup="VG_Registrar_Com"  Display="Dynamic" ControlToValidate="Txb_Referencia_Com_R">*</asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator id="REV_Txb_Referencia_Com_R" ValidationGroup="VG_Registrar_Com" runat="server" Display="Dynamic" ControlToValidate="Txb_Referencia_Com_R" ValidationExpression="^.{1,20}$">*</asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="Txb_Referencia_Com_R" runat="server" MaxLength="21" CssClass="form-control" placeholder="Ingrese la referencia del componente con 1 a 20 Caracteres" TabIndex="12"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Serial
                                                <asp:RequiredFieldValidator runat="server" Id="RFV_Txb_Codigo_Com_R" ValidationGroup="VG_Registrar_Com"  Display="Dynamic" ControlToValidate="Txb_Serial_Com_R">*</asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator id="REV_Txb_Serial_Com_R" ValidationGroup="VG_Registrar_Com" runat="server" Display="Dynamic" ControlToValidate="Txb_Serial_Com_R" ValidationExpression="^.{5,20}$">*</asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="Txb_Serial_Com_R" runat="server" CssClass="form-control" TabIndex="14" placeholder="Ingrese el serial identificador del componente 5 a 20 caracteres" ></asp:TextBox>
                                        </div>
                                        <asp:Button ID="Btn_Registrar" runat="server" ValidationGroup="VG_Registrar_Com" CssClass="btn btn-primary Desplegar_Loading" Text="Registrar" TabIndex="16"/>
                                        <asp:Button ID="Btn_Clear_Com_Reg" runat="server"  CssClass="btn btn-primary" Text="Limpiar" TabIndex="17"/>
                                        <div class="input-group Inport ">
                                            <div class="input-group-addon">
                                                Carga masiva
                                            </div>
                                            <div class="input-group-addon input-group-addon-file">
                                                <span class="btn btn-primary btn-file">
                                                    <asp:Label runat="server">Selecciona un archivo xls</asp:Label><asp:FileUpload ID="File_Excel_Com" CssClass="file" runat="server" />
                                                    <asp:RequiredFieldValidator runat="server" Id="RFV_File_Excel_Com" ValidationGroup="VG_Registrar_Masiv_Com"  Display="Dynamic" ControlToValidate="File_Excel_Com">*</asp:RequiredFieldValidator>
                                                </span>
                                            </div>
                                            <asp:Button ID="Btn_Carga_File_Com" Text="Cargar xls" CssClass="btn-primary form-control Desplegar_Loading" ValidationGroup="VG_Registrar_Masiv_Com" runat="server" />
                                        </div>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Fabricante
                                                <asp:requiredfieldvalidator id="RFV_Fabricante_Com_R" runat="server" Display="Dynamic" ValidationGroup="VG_Registrar_Com" ControlToValidate ="Drl_Fabricante_Com_R" InitialValue="0" >*</asp:requiredfieldvalidator>
                                            </div>
                                            <asp:DropDownList ID="Drl_Fabricante_Com_R" runat="server" CssClass="form-control" TabIndex="11">
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Capacidad
                                                <asp:RequiredFieldValidator runat="server" Id="RFV_Txb_Capacidad_Com_R" ValidationGroup="VG_Registrar_Com"  Display="Dynamic" ControlToValidate="Txb_Capacidad_Com_R">*</asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator id="REV_Txb_Capacidad_Com_R" ValidationGroup="VG_Registrar_Com" runat="server" Display="Dynamic" ControlToValidate="Txb_Capacidad_Com_R" ValidationExpression="^.{1,15}$">*</asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="Txb_Capacidad_Com_R" runat="server" MaxLength="50" CssClass="form-control" placeholder="Ingrese la capacidad técnica del componente con 1 a 15 caracteres" TabIndex="13"></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Descripción
                                                <asp:requiredfieldvalidator id="RFV_Txb_Descripcion_Com_R" ValidationGroup="VG_Registrar_Com" runat="server" Display="Dynamic" ControlToValidate="Txb_Descripcion_Com_R">*</asp:requiredfieldvalidator>
                                                <asp:RegularExpressionValidator id="REV_Txb_Descripcion_Com_R" ValidationGroup="VG_Registrar_Com" runat="server" Display="Dynamic" ControlToValidate="Txb_Descripcion_Com_R" ValidationExpression="^.{5,50}$">*</asp:RegularExpressionValidator>
                                            </div>
                                            <asp:TextBox ID="Txb_Descripcion_Com_R" runat="server" CssClass="form-control" TextMode="MultiLine" TabIndex="15" placeholder="ingrese la descripción del componente con una longitud de 5 a 50 caracteres"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="text-center Subtitulos">
                                    Filtrar Consulta de Componentes
                                </div>
                                <div class="Form">
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Tipo
                                            </div>
                                            <asp:DropDownList ID="Drl_Tipo_Com_C" runat="server" CssClass="form-control" TabIndex="20"></asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Referencia
                                            </div>
                                            <asp:TextBox ID="Txb_Referencia_Com_C" runat="server" CssClass="form-control" TabIndex="22" ></asp:TextBox>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Serial
                                            </div>
                                            <asp:TextBox ID="Txb_Serial_Com_C" runat="server" CssClass="form-control" TabIndex="24" ></asp:TextBox>
                                        </div>
                                        <asp:Button ID="Btn_Consultar_Com" runat="server" ValidationGroup="VG_Consultar_Com" CssClass="btn btn-primary Desplegar_Loading" Text="Consultar" TabIndex="26"/>
                                        <asp:Button ID="Btn_Clear_Com_Con" runat="server"  CssClass="btn btn-primary" Text="Limpiar" TabIndex="27"/>
                                    </div>
                                    <div class="Space-Form"></div>
                                    <div class="Cell-Form">
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Fabricante
                                            </div>
                                            <asp:DropDownList ID="Drl_Fabricante_Com_C" runat="server" CssClass="form-control" TabIndex="21">
                                            </asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Capacidad
                                            </div>
                                            <asp:DropDownList ID="Drl_Capacidad_Com_C" runat="server" CssClass="form-control" TabIndex="23"></asp:DropDownList>
                                        </div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Estado
                                            </div>
                                            <asp:DropDownList ID="Drl_Estado_Com_C" runat="server" CssClass="form-control" TabIndex="25"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </section>
                    </ContentTemplate>
                    <Triggers>
                        <asp:PostBackTrigger ControlID ="Btn_Carga_File_Com" /> 
                    </Triggers>
                </asp:UpdatePanel>
                <div id="Grid_Com_C" class="Grid_Js"></div>
            </article>
        </asp:Panel>
        <asp:Panel ID="Pnl_Asig_Com" runat="server" Style="display:none">
            <article>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <section>
                            <div class="text-center Subtitulos">
                                Filtrar Consulta de Equipos
                            </div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Tipo
                                        </div>
                                        <asp:DropDownList ID="Drl_Tipo_Equ_C" runat="server" CssClass="form-control" TabIndex="30"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Referencia
                                        </div>
                                        <asp:TextBox ID="Txb_Referencia_Equ_C" runat="server" MaxLength="21" CssClass="form-control" placeholder="Ingrese la referencia del equipo" TabIndex="32"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial
                                        </div>
                                        <asp:TextBox ID="Txb_Serial_Equ_C" runat="server" TabIndex="34" CssClass="form-control" placeholder="Ingrese el serial identificador del equipo" ></asp:TextBox>
                                    </div>
                                    <asp:Button ID="Btn_Consultar_Equ" runat="server" ValidationGroup="VG_Consultar_Equ" CssClass="btn btn-primary Desplegar_Loading" Text="Consultar" TabIndex="37"/>
                                    <asp:Button ID="Btn_Clear_Equ_Con" runat="server"  CssClass="btn btn-primary" Text="Limpiar" TabIndex="38"/>
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Fabricante
                                        </div>
                                        <asp:DropDownList ID="Drl_Fabricante_Equ_C" runat="server" CssClass="form-control" TabIndex="31"></asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Serial K
                                        </div>
                                        <asp:TextBox ID="Txb_SerialK_Equ_C" runat="server" MaxLength="50" CssClass="form-control" placeholder="Ingrese el serial Kamilion del equipo " TabIndex="33"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Empresa
                                        </div>
                                        <asp:TextBox ID="Txb_Empresa_Equ_C" runat="server" CssClass="form-control" TabIndex="35" placeholder="Ingrese la empresa del equipo"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Estado
                                        </div>
                                        <asp:DropDownList ID="Drl_Estado_Equ_C" runat="server" CssClass="form-control" TabIndex="36"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </ContentTemplate>
                </asp:UpdatePanel>      
                <div id="Grid_Equ_C" class="Grid_Js"></div>
            </article>
        </asp:Panel>
    </form>
</body>
</html>

