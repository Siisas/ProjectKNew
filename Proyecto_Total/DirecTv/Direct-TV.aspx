<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Direct-TV.aspx.vb" Inherits="digitacion.Direct_TV" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
    <title>ERP Kamilion - DirecTv </title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/jscript">
        $(function () {
            $("#txtultimc").datepicker({ dateFormat: 'dd/mm/yy' }).val();
            $("#txtfcprog").datepicker({ dateFormat: 'dd/mm/yy' }).val();
            $("#TxtFecha_Activacion").datepicker({ dateFormat: 'dd/mm/yy' }).val();
            $("#txtfcactivacion").datepicker({ dateFormat: 'dd/mm/yy' }).val();
        });
    </script>
    <!-- Fin Script jQuery Datepicker --->
    <style type="text/css">
        .celdasder
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
        }
        .celdascent
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }
        .titulo
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            color: navy;
        }
        .Tamanio_Tabla
        {
            width: 100%;
            height: 100%;
        }
        .textotittabla
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            background: #E2E8FA;
            width: 15%;
        }
        .celdascons
        {
            width: 35%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table style="width: 100%; height: 100%">
        <tr>
            <td class="celdasder">
            </td>
            <td class="celdascent">
                <table style="border-style: outset; border-width: 1px; width: 100%">
                    <tr>
                        <td align="center" class="titulo">
                            Kamilion Comunicaciones ERP
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Label ID="lblmsg" runat="server" Style="color: #FF3300"></asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
            </td>
            <td class="celdascent">
                <uc1:menu ID="menu1" runat="server" />
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Label ID="lblmsg0" runat="server" Style="font-size: medium; font-style: italic">DirecTv</asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <table style="width: 100%; height: 100%">
                    <tr>
                        <td style="width: 33%">
                            <asp:Label ID="lblusuario" runat="server" Font-Names="Times New Roman" ForeColor="Black"></asp:Label>
                        </td>
                        <td style="width: 33%">
                            <asp:Label ID="lblnombreusu" runat="server" Font-Names="Times New Roman" ForeColor="Black"></asp:Label>
                            &nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#0000CC"
                                Font-Names="Times New Roman"></asp:Label>
                        </td>
                        <td style="width: 34%">
                            <asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: " Font-Names="Times New Roman"
                                ForeColor="Black"></asp:Label>
                            <asp:Label ID="LblSupervisor" runat="server" Font-Names="Times New Roman" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;</td>
            <td class="celdascent">            
                            <table frame="border" style="padding: inherit; visibility: visible; width:30%" >
                                <tr>
                                    <td class="textotittabla">
                                        Recargar&nbsp; formulario
                                        <asp:Button ID="BtnNuevo" runat="server" Text="Nuevo" />
                                        &nbsp;
                                        <asp:Button ID="BtnAgregarCliente" runat="server" Text="Agregar Cliente" />
                                    </td>
                                </tr>
                            </table>
            </td>
            <td class="celdasder">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">            
                <asp:UpdatePanel ID="UpdatePanel_LblTipoLlamada" runat="server">
                <ContentTemplate>
                Tipo de llamada:
                <asp:Label ID="LblTipoLlamada" runat="server"></asp:Label>
                </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Panel ID="PanelCliente" runat="server" Visible="False">
                    <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                        <tr>
                            <td class="textotittabla">
                                Nombre
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtGuardarNomCliente" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="textotittabla">
                                Telefono
                            </td>
                            <td class="celdascons">
                                <asp:TextBox ID="TxtGuardarTelCliente" runat="server" Width="95%" MaxLength="11"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator10" runat="server" ControlToValidate="TxtTelefonoReferido"
                                    ErrorMessage="Verifique el telefono del referido" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">
                                <asp:Button ID="BtnAgregar_Cliente" runat="server" Text="Agregar" />
                            </td>
                            <td class="celdascons">
                                &nbsp;
                            </td>
                            <td class="textotittabla">
                                &nbsp;
                            </td>
                            <td class="celdascons">
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                Información del usuario:
                <asp:Label ID="LblIdDirectTvCliente" runat="server" Visible="False"></asp:Label>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                    <tr>
                        <td class="textotittabla">
                            Nombre del Cliente
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="LblNombreCliente" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Id Cliente
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="LblIdCliente" runat="server"></asp:Label>
                            <asp:TextBox ID="TxtIdCliente" runat="server"></asp:TextBox>
                            &nbsp;<asp:Button ID="BtnIdCliente" runat="server" Text="Buscar" />                            
                                        <asp:UpdatePanel ID="UpdatePanel_Btns_Inicio" runat="server">
                                        <ContentTemplate>
                            &nbsp;<asp:Button ID="BtnIn" runat="server" Text="In-Bound" />
                            &nbsp;<asp:Button ID="BtnOut" runat="server" Text="Out-Bound" />
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Cedula del Cliente
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtCedula" runat="server" Width="95%" MaxLength="10"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator6" runat="server" ControlToValidate="TxtCedula"
                                ErrorMessage="Verifique la cedula" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                        </td>
                        <td class="textotittabla">
                            Lugar de expedicion
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="DrlLugarExpedicion" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Fecha de nacimiento
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtFcNacimiento" runat="server" Width="95%" placeholder="DD/MM/YYYY"
                                MaxLength="10"></asp:TextBox>
                        </td>
                        <td class="textotittabla">
                            Telefono 1
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtTelefonoCliente" runat="server" Width="95%" MaxLength="10"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Telefono 2
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtTelefonoCliente0" runat="server" Width="95%" MaxLength="10"></asp:TextBox>
                        </td>
                        <td class="textotittabla">
                            Celular
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtCelularCliente" runat="server" Width="95%" MaxLength="10"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Correo Electronico
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtCorreo" runat="server" Width="95%"></asp:TextBox>
                        </td>
                        <td class="textotittabla">
                            Dirección
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtDireccion" runat="server" Width="95%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Ciudad
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="DrlCiudad" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            Como se entero?
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="DrlComoSeEntero" runat="server">
                            </asp:DropDownList>
                            &nbsp;<asp:TextBox ID="TxtComoSeEntero" runat="server" Width="75%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Venta
                        </td>
                        <td class="celdascons">                        
                                        <asp:UpdatePanel ID="UpdatePanel_DrlVenta" runat="server">
                                        <ContentTemplate>
                            <asp:DropDownList ID="DrlVenta" runat="server" AutoPostBack="True">
                                <asp:ListItem Selected="True">Seleccione</asp:ListItem>
                                <asp:ListItem Value="False">No</asp:ListItem>
                                <asp:ListItem Value="True">Si</asp:ListItem>
                            </asp:DropDownList>
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                        </td>
                        <td class="textotittabla">
                            Tipificación
                        </td>
                        <td class="celdascons">                          
                                        <asp:UpdatePanel ID="UpdatePanel_Tipificacion" runat="server">
                                        <ContentTemplate>
                            <asp:DropDownList ID="DrlTipificacion" runat="server" AutoPostBack="True">
                            </asp:DropDownList>  
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                            &nbsp;<asp:Label ID="LblTipificacion" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Fecha y hora de Programación de llamada
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtFechaProg" runat="server" placeholder="DD/MM/YYYY" Width="90px"
                                MaxLength="10"></asp:TextBox>
                            &nbsp;<asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TxtFechaProg"
                                ErrorMessage="Ingrese una fecha Valida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            <asp:TextBox ID="TxtHoraProg" runat="server" placeholder="Hora" Width="30px" MaxLength="2"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="TxtHoraProg"
                                ErrorMessage="Ingrese una Hora Valida" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                            :
                            <asp:TextBox ID="TxtMinProg" runat="server" placeholder="Min" Width="30px" MaxLength="2"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="TxtMinProg"
                                ErrorMessage="Ingrese un valor de minutos valido" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                            &nbsp;<asp:Label ID="LblFcProgramacion" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Contacto Ilocalizado por
                        </td>
                        <td class="celdascons">
                                        <asp:UpdatePanel ID="UpdatePanel_Drl_Ilozaliza_Por" runat="server">
                                        <ContentTemplate>
                                            <asp:Panel ID="Panel_Drl_Ilozaliza_Por" runat="server" Visible="False">
                            <asp:DropDownList ID="Drl_Ilozaliza_Por" runat="server">
                            </asp:DropDownList>
                                            </asp:Panel>
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Localidad</td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtLocalidad" runat="server" Width="95%"></asp:TextBox>
                        </td>
                        <td class="textotittabla">
                            Estrato</td>
                        <td class="celdascons">
                            <asp:DropDownList ID="DrlEstrato" runat="server">
                                <asp:ListItem Selected="True">- Seleccione -</asp:ListItem>
                                <asp:ListItem Value="1">1</asp:ListItem>
                                <asp:ListItem Value="2">2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Observacion de la llamada
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtObservacion" runat="server" TextMode="MultiLine" Width="95%"></asp:TextBox>
                        </td>
                        <td class="textotittabla">
                            Numero Caso:
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="LblIdCaso" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Nombre Contacto
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtNombreContacto" runat="server" Width="95%"></asp:TextBox>
                        </td>
                        <td class="textotittabla">
                            Telefono Contacto
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtTelefonoContacto" runat="server" Width="95%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Operador</td>
                        <td class="celdascons">
                            <asp:DropDownList ID="Drl_Operador" runat="server">
                            </asp:DropDownList>  
                                        </td>
                        <td class="textotittabla">
                            &nbsp;</td>
                        <td class="celdascons">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                Información de Referente
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                    <tr>
                        <td class="textotittabla">
                            Nombre del referente
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="LblNombreReferente" runat="server"></asp:Label>
                        </td>
                        <td class="textotittabla">
                            Id del Referente
                        </td>
                        <td class="celdascons">
                            <asp:Label ID="LblIdReferente" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                Información de Gestión
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                    <tr>
                        <td class="textotittabla">
                            Numero Contrato
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtNumeroContrato" runat="server"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator9" runat="server" ControlToValidate="TxtNumeroContrato"
                                ErrorMessage="Ingrese solo numeros" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                        </td>
                        <td class="textotittabla">
                            Cod. Factura Codensa
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtCodCodensa" runat="server"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator8" runat="server" ControlToValidate="TxtCodCodensa"
                                ErrorMessage="Ingrese solo numeros" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            Tipo de Plan
                        </td>
                        <td class="celdascons">
                            <asp:DropDownList ID="DrlTipoPlan" runat="server" AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                        <td class="textotittabla">
                            Descripcion del plan
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtDescripcionPlan" runat="server" TextMode="MultiLine" Width="95%"
                                ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            IBS
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtIBS" runat="server" MaxLength="10"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator7" runat="server" ControlToValidate="txtIBS"
                                ErrorMessage="El IBS debe ser numérico" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                        </td>
                        <td class="textotittabla">
                            Ventas asociadas
                        </td>
                        <td class="celdascons">
                            <asp:Button ID="BtnVentas" runat="server" Text="Agregar Venta" />
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla" colspan="4">
                            <asp:GridView ID="dtgVentas" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small;
                                text-align: center;" EnableModelValidation="True">
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Tipo_Plan" HeaderText="Tipo de Plan" />
                                    <asp:BoundField DataField="Desc_Plan" HeaderText="Descripción" />
                                </Columns>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            </asp:GridView>
                            <br />
                            <asp:GridView ID="dtgVerVentas" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small;
                                text-align: center;" EnableModelValidation="True">
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Tipo_Plan" HeaderText="Tipo de Plan" />
                                    <asp:BoundField DataField="Desc_Plan" HeaderText="Descripción" />
                                </Columns>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                Referidos:
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
            </td>
            <td class="auto-style2">
                <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                    <tr>
                        <td class="textotittabla">
                            Nombre
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtNombreReferido" runat="server" Width="95%"></asp:TextBox>
                        </td>
                        <td class="textotittabla">
                            Telefono
                        </td>
                        <td class="celdascons">
                            <asp:TextBox ID="TxtTelefonoReferido" runat="server" Width="95%" MaxLength="11"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator5" runat="server" ControlToValidate="TxtTelefonoReferido"
                                ErrorMessage="Verifique el telefono del referido" Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="textotittabla">
                            <asp:Button ID="BtnAgregar_Referidos" runat="server" Text="Agregar" />
                        </td>
                        <td class="celdascons">
                            &nbsp;
                        </td>
                        <td class="textotittabla">
                            &nbsp;
                        </td>
                        <td class="celdascons">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="celdascent" colspan="4">
                            <asp:GridView ID="dtgReferidos" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small;
                                text-align: center;" EnableModelValidation="True">
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Nombre_Referido" HeaderText="Nombre Referido" />
                                    <asp:BoundField DataField="Telefono_Referido" HeaderText="Telefono Referido" />
                                </Columns>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            </asp:GridView>
                            <br />
                            <asp:GridView ID="dtgReferidosVista" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small;
                                text-align: center;" EnableModelValidation="True">
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Nom_Referido" HeaderText="Nombre Referido" />
                                    <asp:BoundField DataField="Id_Referido" HeaderText="Telefono Referido" />
                                </Columns>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="celdasder">
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                &nbsp;
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" style="width: 68px" />
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                &nbsp;
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="celdasder">
                &nbsp;
            </td>
            <td class="celdascent">
                <asp:GridView ID="dtgCasos" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small;
                    text-align: center;" EnableModelValidation="True" PageSize="5">
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="Id_Agente" HeaderText="Id Agente" />
                        <asp:BoundField DataField="Fc_Registro" HeaderText="Fecha Registro" />
                        <asp:BoundField DataField="Tipificacion" HeaderText="Tipificacion" />
                        <asp:BoundField DataField="Fc_Hr_Programacion" HeaderText="Hora Programacion" />
                        <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                        <asp:BoundField DataField="Numero_Contrato" HeaderText="Numero Contrato" />
                        <asp:BoundField DataField="Cod_Factura_Codensa" HeaderText="Codigo Factura Codensa" />
                        <asp:BoundField DataField="IBS" HeaderText="IBS" />
                        <asp:BoundField DataField="TipoLlamada" HeaderText="Tipo Llamada" />
                    </Columns>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
            </td>
            <td class="celdasder">
                &nbsp;
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
