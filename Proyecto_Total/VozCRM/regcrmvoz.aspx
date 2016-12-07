<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="regcrmvoz.aspx.vb" Inherits="digitacion.regcrm1" %>

<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">        
        .celdasder {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
        }

        .celdascent {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }

        .titulo {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            color: navy;
        }

        .Tamanio_Tabla {
            width: 100%;
            height: 100%;
        }

        .textotittabla {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000042;
            font-weight: bold;
            background: #E2E8FA;
            width: 15%;
        }

        .celdascons {
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
                <td class="celdasder"></td>
                <td class="celdascent">
                    <table style="border-style: outset; border-width: 1px; width: 100%">
                        <tr>
                            <td align="center" class="titulo">Kamilion Comunicaciones ERP
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg" runat="server" Style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
            <tr>
                <td class="celdasder"></td>
                <td class="celdascent">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg0" runat="server" Style="font-size: medium; font-style: italic">Registro CRM-VOZ</asp:Label>
                </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
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
                <td class="celdasder">&nbsp;
                </td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent">
                    <table style="width: 100%; height: 100%">
                        <tr>
                            <td style="width: 10%" bgcolor="#CCCCFF">
                                <table style="width: 100%; height: 100%; border-color: White" border="1">
                                    <tr>
                                        <td>Caso:
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width: 40%">
                                <table style="width: 100%; height: 100%; border-style: outset; border-width: 1px">
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="txtcaso" runat="server" Width="138px"></asp:TextBox>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server"
                                                ControlToValidate="txtcaso" ErrorMessage="El caso debe ser numérico"
                                                Operator="DataTypeCheck" Type="Double">*</asp:CompareValidator>
                                            <asp:Button ID="Button1" runat="server" Text="Buscar" style="height: 26px" />

                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width: 50%">
                                <asp:Label ID="lblasig" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
            <tr>
                <td class="celdasder">

                    <asp:GridView ID="dtgprog" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="5" Width="62%" Style="font-size: x-small">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="fcprog" HeaderText="Fecha de llamada" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                        <tr>
                            <td class="textotittabla">MIN</td>
                            <td class="celdascons">
                                <asp:Label ID="lblmin" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">Caso</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcaso" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Nombre</td>
                            <td class="celdascons">
                                <asp:Label ID="lblcliente" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">Documento</td>
                            <td class="celdascons">
                                <asp:Label ID="lbldocumento" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Equipo</td>
                            <td class="celdascons">
                                <asp:Label ID="lblequipo" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">Observación *611</td>
                            <td class="celdascons">
                                <asp:Label ID="lblobs611" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Estado</td>
                            <td class="celdascons">
                                <asp:Label ID="lblestado" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">Mesa</td>
                            <td class="celdascons">
                                <asp:Label ID="lblmesa" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Es Fallatec</td>
                            <td class="celdascons">
                                <asp:Label ID="lblfallatec" runat="server"></asp:Label>
                            </td>
                            <td class="textotittabla">Fecha Ingreso</td>
                            <td class="celdascons">
                                <asp:Label ID="Lblfc_ingreso" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                    <asp:GridView ID="dtgasig" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="5" Width="138%" Style="font-size: x-small">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="fcasignadoseg" HeaderText="Fecha Asignado" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <asp:Button ID="btnguardar" runat="server" Style="height: 26px" Text="Guardar" />
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <asp:Panel ID="pndiagnostico" runat="server">
                        <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                            <tr>
                                <td class="textotittabla" colspan="4">
                                    <center>
                                        GEORREFERENCIACIÓN</center>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Condición de Uso</td>
                                <td class="celdascons">
                                     <asp:UpdatePanel ID="UPFtectolog" runat="server">
                                        <ContentTemplate>
                                     <asp:DropDownList ID="drlFtectolog" runat="server" Height="22px" Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>GSM</asp:ListItem>
                                        <asp:ListItem>3G</asp:ListItem>
                                    </asp:DropDownList>
                                      <asp:Button ID="Btn_Habilita_Tecnologia" runat="server" Text="Actualizar" Visible="False" />
                                            </ContentTemplate> </asp:UpdatePanel> 
                                </td>

                                <td class="textotittabla">Fecha Ultima Caida</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtultimc" runat="server"></asp:TextBox>
                                    <asp:DropDownList ID="drlfranja" runat="server" Height="22px" Width="129px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Mañana</asp:ListItem>
                                        <asp:ListItem>Tarde</asp:ListItem>
                                        <asp:ListItem>Noche</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:CompareValidator ID="CompareValidator5" runat="server"
                                        ControlToValidate="txtultimc"
                                        ErrorMessage="La fecha de última caida o es correcto" Operator="DataTypeCheck"
                                        Type="Date">*</asp:CompareValidator>
                                    <asp:Button ID="Btn_Habilita_Fc_Utl_Caida" runat="server" Text="Actualizar" Visible="False" />
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Marca</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPMarca" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlmarca" runat="server" AutoPostBack="True"
                                                Height="22px" Width="322px">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">Equipo</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPEquipo" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlequipo" runat="server" Height="22px" Width="322px">
                                            </asp:DropDownList>
                                            <asp:Button ID="Btn_Habilita_Equipo" runat="server" Text="Actualizar" Visible="False" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>

                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Departamento</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPDepartamento" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drldpto" runat="server" AutoPostBack="True" Height="22px"
                                                Width="322px">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">Municipio</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPMunicipio" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlmun" runat="server" Height="22px" Width="322px">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:Button ID="Btn_Habilita_Municipio" runat="server" Text="Actualizar" Visible="False" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Localidad</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPLocalidad" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drllocalidad" runat="server" AutoPostBack="True"
                                                Height="22px" Width="322px">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">Barrio</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlbarrio" runat="server" AutoPostBack="True"
                                                Height="22px" Width="322px">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:Button ID="Btn_Habilita_Barrio" runat="server" Text="Actualizar" Visible="False" />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla" colspan="4">
                                    <center>
                                        VOZ DEL CLIENTE</center>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Tipo PQR</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlTipo_PQR" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">&nbsp;</td>
                                <td class="celdascons">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Tipo Cliente</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlTipo_Cliente" runat="server" Height="22px"
                                        Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">Modalidad</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlModalidad" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Línea de Servicio</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPLinea" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drllinea" runat="server" AutoPostBack="True"
                                                Height="22px" Width="322px">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">Servicio</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPServicio2" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlservicio2" runat="server" AutoPostBack="True"
                                                Height="22px" Width="322px">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Subservicio</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPsubservicio" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlsubservicio" runat="server" AutoPostBack="True"
                                                Height="22px" Width="322px">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">Solicitud / Tipo Falla</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPsolicitud" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlsolicitud" runat="server" Height="22px" Width="322px">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla" colspan="4">
                                    <center>CATALOGO DE DIAGNOSTICO</center>

                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Servicio Afectado</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPServicio" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlservicio" runat="server" Height="22px" Width="322px"
                                                AutoPostBack="True">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla"></td>
                                <td class="celdascons"></td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Percepción de Falla</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPPercep" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlpercep" runat="server" Height="22px" Width="322px"
                                                AutoPostBack="True">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">
                                    <asp:UpdatePanel ID="UPTipificacion" runat="server">
                                        <ContentTemplate>
                                            <asp:Label ID="lbltipificacion" runat="server" Font-Size="XX-Small"></asp:Label>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="celdascons"></td>
                            </tr>



                            <tr>
                                <td class="textotittabla">Segmento</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPSegmento" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlSegmento" runat="server" Height="22px" Width="322px"
                                                AutoPostBack="True">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">Elemento</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPElemento" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlElemento" runat="server" Height="22px" Width="322px"
                                                AutoPostBack="True">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Tipo de falla</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPTipoFalla" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlTipo_De_Falla" runat="server" Height="22px"
                                                Width="322px" AutoPostBack="True">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">Causa raiz</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPCausa_Rai" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlCausa_Raiz" runat="server" Height="22px" Width="322px">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Variables de Diagnóstico</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UpErroRegistro" runat="server">
                                        <ContentTemplate>
                                            <asp:RadioButtonList ID="rdbron" runat="server" AutoPostBack="True"
                                                Font-Size="XX-Small">
                                                <asp:ListItem Selected="True">Error en Registro</asp:ListItem>
                                                <asp:ListItem>Ajeno a Red Celular</asp:ListItem>
                                                <asp:ListItem>Asociado Red Celular</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">
                                    <asp:UpdatePanel ID="UPVariableL" runat="server">
                                        <ContentTemplate>
                                            <asp:Label ID="lblvariable" runat="server" Font-Size="XX-Small"></asp:Label>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPVariable" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlvariable" runat="server" Height="22px" Width="322px"
                                                AutoPostBack="True">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <br />
                                </td>
                            </tr>

                            <tr>
                                <td class="textotittabla">Numero Alterno</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtnumalt" runat="server" MaxLength="10" Width="136px"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator3" runat="server"
                                        ControlToValidate="txtnumalt"
                                        ErrorMessage="El número alterno debe ser numérico" Operator="DataTypeCheck"
                                        Type="Double">*</asp:CompareValidator>
                                    <asp:Label ID="lblred" runat="server"></asp:Label>
                                    <asp:Label ID="lblctrl" runat="server">0</asp:Label>
                                </td>
                                <td class="textotittabla">Barrio</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPBarrio2" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="txtbarrio" runat="server" Width="310px"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla" colspan="4">
                                    <center>
                                        SEGUIMIENTO</center>

                                </td>
                            </tr>
                           <tr>
                                <td class="textotittabla">Se brindó Solución</td>
                                <td class="celdascons">
                                    <asp:CheckBox ID="chksolucion" runat="server" Text="Si" />
                                </td>
                                <td class="textotittabla">Solicita ajuste</td>
                                <td class="celdascons">
                                    <asp:CheckBox ID="chkajuste" runat="server" Text="Si" />
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Monto Ajustar</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtmonto" runat="server" MaxLength="10" Width="136px"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator4" runat="server"
                                        ControlToValidate="txtmonto"
                                        ErrorMessage="El monto a ajustar debe ser numérico" Operator="DataTypeCheck"
                                        Type="Double">*</asp:CompareValidator>
                                </td>
                                <td class="textotittabla">Estado Fallatec</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlfallatec" runat="server" Height="22px" Width="129px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>CERRADO</asp:ListItem>
                                        <asp:ListItem>ILOCALIZABLE</asp:ListItem>
                                        <asp:ListItem>ESCALADO</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Desactivación</td>
                                <td class="celdascons">
                                    <asp:RadioButton ID="RdBtnBaja" runat="server" GroupName="Desactivacion"
                                        Text="Baja" />
                                    <br />
                                    <asp:RadioButton ID="RdBtnUpgrade" runat="server" GroupName="Desactivacion"
                                        Text="Upgrade" />
                                    <br />
                                    <asp:Button ID="BtnDesactivacion" runat="server" Text="Ninguno" />
                                </td>
                                <td class="textotittabla">&nbsp;</td>
                                <td class="celdascons">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Crear Formato</td>
                                <td class="celdascons">
                                    <asp:CheckBox ID="chknvoformato" runat="server" />
                                </td>
                                <td class="textotittabla">Mesa</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlmesa" runat="server" Height="22px" Width="129px">
                                        <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>C&GVoz</asp:ListItem>
                                        <asp:ListItem>Datos</asp:ListItem>
                                        <asp:ListItem>BSCS</asp:ListItem>
                                        <asp:ListItem>Otra</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla" colspan="4">
                                    <center>
                                        CIERRE DE LLAMADA</center>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Tipificación Llamada</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPTipificacionll" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drltipificacionll" runat="server" AutoPostBack="True"
                                                Height="22px" Width="322px">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">Tipo Cierre</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPTsoporte" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drltsoporte" runat="server" Height="22px" Width="322px">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">
                                    Fecha programado&nbsp;
                                </td>
                                <td class="celdascons">
                                    <asp:TextBox ID="TxtFcProgramado" runat="server" placeholder="DD/MM/YYYY" MaxLength="10"></asp:TextBox>
                                </td>
                                <td class="textotittabla">
                                    Hora
                                </td>
                                <td class="celdascons">
                                    <asp:Panel ID="PanelFc_Llamada" runat="server">
                                        <asp:TextBox ID="TxtHora_Llamada" runat="server" placeholder="HH" Width="24px" MaxLength="2"></asp:TextBox>
                                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TxtHora_Llamada"
                                            ErrorMessage="Verifique el formato de la hora de la llamada" Operator="DataTypeCheck"
                                            Type="Integer">*</asp:CompareValidator>
                                        :<asp:TextBox ID="TxtMinuto_Llamada" runat="server" placeholder="MM" Width="24px"
                                            MaxLength="2"></asp:TextBox>
                                        <asp:CompareValidator ID="CompareValidator6" runat="server" ControlToValidate="TxtMinuto_Llamada"
                                            ErrorMessage="Verifique el formato del minuto de la llamada" Operator="DataTypeCheck"
                                            Type="Integer">*</asp:CompareValidator>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Categoria de cierre</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPCategoria" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlCategoriaCierre" runat="server" AutoPostBack="True"
                                                Height="22px" Width="322px">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">
                                    <asp:UpdatePanel ID="UpCategoriaC" runat="server">
                                        <ContentTemplate>
                                            <asp:Label ID="LblCategoriaCierre" runat="server" Font-Size="XX-Small"></asp:Label>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="celdascons">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Tipo de Grupo</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPGrupo" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlgrupo" runat="server" AutoPostBack="True"
                                                Height="22px" Width="322px">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="textotittabla">Tipo Soporte</td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPSoporte" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlsoporte" runat="server" Height="22px" Width="322px"
                                                AutoPostBack="True">
                                                <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                                <asp:ListItem>SI</asp:ListItem>
                                                <asp:ListItem>NO</asp:ListItem>
                                                <asp:ListItem>NS/NR</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                            </tr>

                            <tr>
                                <td class="textotittabla">PQR
                                </td>
                                <td class="celdascons">
                                    <asp:UpdatePanel ID="UPPqr" runat="server">
                                        <ContentTemplate>
                                    <asp:Label ID="LblPQR" runat="server"></asp:Label><asp:TextBox ID="TxtPQR" runat="server"
                                        MaxLength="7" Width="55px"></asp:TextBox>

                                    <asp:CompareValidator ID="CV_PQR" runat="server" ControlToValidate="TxtPQR" ErrorMessage="El valor del PQR debe ser numerico"
                                        Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                    <asp:Button ID="Btn_Habilita_PQR" runat="server" Text="Actualizar" Visible="False" />
                                            </ContentTemplate></asp:UpdatePanel>

                                </td>
                                <td class="textotittabla">
                                    <asp:UpdatePanel ID="UPCierre" runat="server">
                                        <ContentTemplate>
                                            <asp:Label ID="lblcierre" runat="server" Font-Size="XX-Small"></asp:Label>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
                                <td class="celdascons">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla" colspan="4">
                                    <center>
                                        ENCUESTAS</center>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Se Instalo App Nx Monitor
                                </td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlIntalaApp" runat="server">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">Motivo</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlMotivo" runat="server">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Informa  Instalar Nx Monitor en otro Momento</asp:ListItem>
                                        <asp:ListItem>No le interesa instalar</asp:ListItem>
                                        <asp:ListItem>Prefiere que lo llamen despues para asesoria de instalacion</asp:ListItem>
                                        <asp:ListItem>Otras causas</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Encuesta *611</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drl611" runat="server" Height="22px" Width="129px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">&nbsp;
                                </td>
                                <td class="celdascons">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla" colspan="4">
                                    <center>
                                        OBSERVACIÓN</center>
                                </td>
                            </tr>
                            <tr>
                                <td class="celdascons" colspan="4">
                                    <center>
                                        <asp:TextBox ID="txtobs" runat="server" Height="45px" TextMode="MultiLine" Width="99%"></asp:TextBox></center>
                                </td>
                            </tr>

                        </table>
                    </asp:Panel>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <asp:LinkButton ID="LinkButton5" runat="server">Reportar Inconsistencia</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton6" runat="server">Ocultar Inconsistencia</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton3" runat="server">Adicionar Falla de Red</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server">Ocultar Falla Red</asp:LinkButton>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <asp:Panel ID="Panel1" runat="server" Visible="False">
                        <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                            <tr>
                                <td class="textotittabla">
                                    <asp:Button ID="btnguardar0" runat="server" Style="height: 26px"
                                        Text="Guardar" />
                                </td>
                                <td>Registro de Falla de Red</td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Persona Contacto</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFcontacto" runat="server" Width="278px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">Número Contacto</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFnum" runat="server" Width="136px" MaxLength="10"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Tiempo Falla</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFtiempo" runat="server" Height="22px" Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem Value="&lt;=30">&lt;=30</asp:ListItem>
                                        <asp:ListItem Value="&gt;30">&gt;30</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">Tipo Falla</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFtipofalla" runat="server" Width="285px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Características de la Falla</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFcaract" runat="server" Height="22px" Width="302px">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">Línea Portada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFportada" runat="server" Height="22px" Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>FALSO</asp:ListItem>
                                    <asp:ListItem>VERDADERO</asp:ListItem>

                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Nombre Vereda o Corregimiento</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFciudad" runat="server" Width="279px"></asp:TextBox>
                                </td>
                                <td class="textotittabla">Tipo Lugar</td>
                                <td class="celdascons">
                                    <asp:RadioButtonList ID="rdbvc" runat="server" Font-Size="XX-Small"
                                        Width="219px">
                                        <asp:ListItem Value="VRD">Vereda</asp:ListItem>
                                        <asp:ListItem Value="CRG">Corregimiento</asp:ListItem>
                                        <asp:ListItem Value="INS">Inspección</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Dirección Falla</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtFdirecc" runat="server" Width="279px"></asp:TextBox>
                                </td>
                               <td class="textotittabla">Qos</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="Drl_Qos" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                    </asp:DropDownList>
                                </td>

                            </tr>
                            <tr>
                                <td class="textotittabla">Lineas con falla en la Ubicación Reportada</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlFlineasfalla" runat="server" Height="22px"
                                        Width="130px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">Observación Cliente</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtfobs" runat="server" Height="45px" TextMode="MultiLine"
                                        Width="99%"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                    <td class="textotittabla" colspan="4">
                                        <center>
                                            Validaciones servicio al cliente</center>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="textotittabla">
                                        La falla se presenta luego de que se construyera una edificación aledaña
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania"
                                            runat="server" Height="22px" Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="textotittabla">
                                        La falla se presenta luego de que se remodelara la estructura física del edificio
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio"
                                            runat="server" Height="22px" Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="textotittabla">
                                        Tipo de edificación donde se presenta la falla
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_1" runat="server"
                                            Height="22px" Width="200px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="Drl_Tipo_Edificacion_Donde_Presenta_Falla_2" runat="server"
                                            Height="22px" Width="100px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="textotittabla">
                                        Validaciones de falla masiva
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Validaciones_Falla_Masiva" runat="server" Height="22px"
                                            Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="textotittabla">
                                        Tecnología en la que se presenta la falla - Luego de pruebas
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Tecnologia_Presenta_Falla_Luegodepruebas" runat="server"
                                            Height="22px" Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="textotittabla">
                                        Validación de Coordenadas
                                    </td>
                                    <td class="celdascons">
                                        <asp:TextBox ID="Txt_Validacion_Coordenadas" runat="server" MaxLength="20" Width="279px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="textotittabla">
                                        Línea no cuenta con bloqueos de Internet
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Linea_No_Cuenta_Bloqueos_Internet" runat="server" Height="22px"
                                            Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="textotittabla">
                                        Línea no ha superado el limite de consumos
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Linea_No_Superado_Limite_Consumos" runat="server" Height="22px"
                                            Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="textotittabla">
                                        Línea no se encuentra enrutada por pagos
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Linea_No_Encuentra_Enrutada_PorPagos" runat="server" Height="22px"
                                            Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="textotittabla">
                                        HLR / HSS
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_HLR_HSS" runat="server" Height="22px" Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="textotittabla">
                                        No existen cambios administrativos sobre la línea o cuenta maestra
                                    </td>
                                    <td class="celdascons">
                                        <asp:UpdatePanel ID="UpdatePanel_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra"
                                            runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra"
                                                    runat="server" AutoPostBack="True" Height="22px" Width="322px">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem Value="FALSO"></asp:ListItem>
                                                    <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                                </asp:DropDownList>
                                                <br />
                                                <asp:DropDownList ID="Drl_Split_Billing" runat="server" Height="22px" Visible="False"
                                                    Width="322px">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </td>
                                    <td class="textotittabla">
                                        Se realizan pruebas de SIMCARD en otro dispositivo (Persiste Falla)
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla"
                                            runat="server" Height="22px" Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="textotittabla">
                                        Se forza la red del dispositivo
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Forza_Red_Dispositivo" runat="server" Height="22px" Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="textotittabla">
                                        Se verifica o realiza configuración de APN
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Verifica_Realiza_Configuración_APN" runat="server" Height="22px"
                                            Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="textotittabla">
                                        Equipo se encuentra homologado por el operador
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Equipo_Encuentra_Homologado_Operador" runat="server" Height="22px"
                                            Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="textotittabla">
                                        Se realiza conciliación sobre la línea
                                    </td>
                                    <td class="celdascons">
                                        <asp:DropDownList ID="Drl_Realiza_Conciliacion_Sobre_linea" runat="server" Height="22px"
                                            Width="322px">
                                            <asp:ListItem>- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="FALSO"></asp:ListItem>
                                            <asp:ListItem Value="VERDADERO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>

                        </table>
                    </asp:Panel>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <asp:Panel ID="Pninc" runat="server" Visible="False">
                        <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                            <tr>
                                <td class="textotittabla">
                                    <asp:Button ID="btnguardar1" runat="server" Text="Guardar" Width="68px" />
                                </td>
                                <td class="celdascons">
                                    &nbsp;Registro de Inconsistencia
                                </td>
                                <td class="textotittabla">
                                    Cuenta Financiera
                                </td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txt_registro_numerico" runat="server" Width="136px" MaxLength="12"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_registro_numerico"
                                        ErrorMessage="el numero debe ser positivo" ValidationExpression="^[0-9]*$">*</asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Tipificacion</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlinconsglobal" runat="server" AutoPostBack="True"
                                        Height="22px" Width="322px">
                                        <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>SI</asp:ListItem>
                                        <asp:ListItem>NO</asp:ListItem>
                                        <asp:ListItem>NS/NR</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">Tipo Inconsistencia</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlincons" runat="server" Height="22px" Width="322px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Nivel</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drlnivel" runat="server" Height="22px" Width="322px">
                                        <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Call</asp:ListItem>
                                        <asp:ListItem>Operacion</asp:ListItem>
                                        <asp:ListItem>Call/Operac</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">Observación Inconsistencia</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txtobsinc" runat="server" Height="45px" TextMode="MultiLine"
                                        Width="99%"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">&nbsp;</td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <asp:LinkButton ID="lnk1" runat="server">Ver Seguimiento</asp:LinkButton>
                    &nbsp; 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server">Ver Casos Asociados</asp:LinkButton>
                    &nbsp; 
                    <asp:Label ID="lblcuenta1" runat="server"></asp:Label>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="idcrm" HeaderText="ID" />
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="min_ac" HeaderText="Min" />
                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Registro" />
                            <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                            <asp:BoundField DataField="obs" HeaderText="Observación" />
                            <asp:BoundField DataField="destiposoporte" HeaderText="Tipo Soporte" />
                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                            <asp:BoundField DataField="Fc_Program" HeaderText="Fecha Programado" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <asp:GridView ID="dtgcoincidentes" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                        Visible="False">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="bandeja" HeaderText="Bandeja" />
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="min_ac" HeaderText="MIN" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="bandeja" HeaderText="Mesa" />
                        </Columns>
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
