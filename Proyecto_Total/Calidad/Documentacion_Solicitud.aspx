<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Documentacion_Solicitud.aspx.vb" Inherits="digitacion.Documentacion_Solicitud_Documentos" %>
<%@ Register Src="../menu.ascx" TagName="menu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>   
  <link type="text/css"rel="stylesheet" href="../Css2/FormStyle.css" />  
  <!-- Inicio Script jQuery Datepicker --->
  <link type="text/css"rel="stylesheet" href="../Css2/jquery-ui.css" />   
  <script type="text/javascript" src="../Css2/jquery.min.js"></script>
  <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
  <script type="text/jscript">
      $(function () {
          $("#TxtFecha_Recepcion").datepicker();
          $('#TxtFecha_Recepcion').datepicker('option', { dateFormat: 'dd/mm/yy' });
        $("#Txt_Fecha_Inicio").datepicker({ dateFormat: 'dd/mm/yy' }).val();
        $("#Txt_Fecha_fin").datepicker({ dateFormat: 'dd/mm/yy' }).val(); 
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
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <asp:Label ID="lblmsg" runat="server" Style="color: #FF3300"></asp:Label>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">
                    <uc1:menu ID="menu1" runat="server" />
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">Registro de Solicitudes</td>
                <td class="celdasder">&nbsp;</td>
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
                <td class="celdasder"></td>
                <td class="celdascent">&nbsp;</td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder"></td>
                <td class="celdascent">


                    <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center>
                                    Enviar Una Solicitud
                                    
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Tipo De Solicitud</td>
                            <td class="celdascons">

                                <asp:DropDownList ID="drl_Tipo_solicitud" runat="server"></asp:DropDownList>

                            </td>
                            <td class="textotittabla">Persona Que Solicita</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txt_Persona_soli" runat="server" MaxLength="60" Width="267px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Tipo De Documento</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drl_Tipo_documento" runat="server" Style="margin-top: 0px" Width="207px">
                                </asp:DropDownList>
                            </td>
                            <td class="textotittabla">Prioridad</td>
                            <td class="celdascons">
                                <asp:DropDownList ID="drl_prioridad" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Proceso</td>
                            <td class="celdascons">
                                <asp:UpdatePanel ID="UpdatePanel_drl1" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="drl_Proceso" runat="server" AutoPostBack="True">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                            <td class="textotittabla">Sub-proceso</td>
                            <td class="celdascons">
                                <asp:UpdatePanel ID="UpdatePanel_drl2" runat="server">
                                    <ContentTemplate>
                                        <asp:DropDownList ID="drl_Sub_proceso" runat="server">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Observacion</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txtObservacion" runat="server" MaxLength="99"
                                    Width="99%" Height="45px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                            <td class="textotittabla"></td>
                            <td class="celdascons">&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder"></td>
            </tr>
            <%----------------------------------------------------------------------%>
            <tr>
                <td class="celdasder"></td>
                <td class="celdascent">
                    <asp:ImageButton ID="btn_Guardar_solicitud" runat="server" Height="57px"
                        ImageUrl="~/Css2/Imagenes/Nuevo.png" Width="60px"
                        AlternateText="Guardar" title="Guardar" />
                </td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder"></td>
                <td class="celdascent">
                    <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                        <tr>
                            <td class="textotittabla" colspan="4">
                                <center>
                                    Consultas
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Numero De Solicitud</td>
                            <td class="celdascons">
                                <asp:TextBox ID="txt_id_soli" runat="server" MaxLength="9" Width="171px"></asp:TextBox>
                                <asp:CompareValidator ID="val_cod" runat="server"
                                    ControlToValidate="txt_id_soli" ErrorMessage="El caso debe ser numérico"
                                    Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                            </td>

                            <td class="textotittabla">Mis Solicitudes</td>
                            <td class="celdascons">
                                <asp:CheckBox ID="CheckBoxTicket" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="textotittabla">Fecha Registro Desde</td>
                            <td class="celdascons">
                                <asp:TextBox ID="Txt_Fecha_Inicio" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" Width="171px"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidato3" runat="server"
                                    ControlToValidate="Txt_Fecha_Inicio" ErrorMessage="La fecha de ingreso no es válida"
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                            <td class="textotittabla">Fecha Registro Hasta</td>
                            <td class="celdascons">
                                <asp:TextBox ID="Txt_Fecha_fin" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" Width="171px"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server"
                                    ControlToValidate="txt_Fecha_fin" ErrorMessage="La fecha de ingreso no es válida"
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder"></td>
                <td class="celdascent">

                    <asp:ImageButton ID="btn_buscar" runat="server" Height="57px"
                        ImageUrl="~/Css2/Imagenes/Consulta.png" Width="60px"
                        AlternateText="Consultar" title="Consultar" />
                    <br />
                    <asp:Button ID="btn_Exportar" runat="server" Text="Exportar" />
                </td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;</td>
                <td class="celdascent">Consulta Solicitudes: 
                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                </td>
                <td class="celdasder">&nbsp;</td>
            </tr>
            <asp:Panel ID="Pn_contenedor1" runat="server">
                <tr>
                    <td class="celdasder"></td>
                    <td class="celdascent">


                        <asp:GridView ID="dtgConsultas" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="20" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="Id_Solicitud_Documento" HeaderText="Solicitud" />
                                <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha Registro" />

                                <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                <asp:BoundField DataField="Persona_Solicita" HeaderText="Persona Solicita" />
                                <asp:BoundField DataField="Tipo_Documento" HeaderText="Tipo Documento" />
                                <asp:BoundField DataField="Proceso" HeaderText="Proceso" />
                                <asp:BoundField DataField="Sub_Proceso" HeaderText="Sub Proceso" />
                                <asp:BoundField DataField="Estado" HeaderText="Estado" />

                                <asp:ButtonField CommandName="Seleccion" HeaderText="Ver" ShowHeader="True" Text="Seleccionar" />

                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        </asp:GridView>
                    </td>
                    <td class="celdasder"></td>
                </tr>
            </asp:Panel>
            <tr>
                <td class="celdasder"></td>
                <td style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: medium;"
                    valign="top" class="celdascent">&nbsp;</td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder"></td>
                <td class="celdascent">Consulta Seguimientos: 
                    <asp:Label ID="lblcuenta2" runat="server"></asp:Label>
                </td>
                <td class="celdasder"></td>
            </tr>
            <asp:Panel ID="Pn_contenedor2" runat="server">
                <tr>
                    <td class="celdasder"></td>
                    <td class="celdascent">
                  <asp:UpdatePanel ID="UpdatePanle_Historial" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="dtg_historial" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="8" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="Id_Historial_Respuesta" HeaderText="Id" />
                                        <asp:BoundField DataField="Id_Solicitud_Documento" HeaderText="Solicitud" />
                                        <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario" />
                                        <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha" />
                                        <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                        <asp:BoundField DataField="Complejidad" HeaderText="Complejidad" />
                                        <asp:BoundField DataField="Tipo_Documento" HeaderText="Tipo Documento" />
                                    </Columns>
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" Wrap="True" />
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>

                    </td>
                    <td class="celdasder"></td>
                </tr>
            </asp:Panel>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server"
            ShowMessageBox="True" />
    </form>
</body>
</html>
