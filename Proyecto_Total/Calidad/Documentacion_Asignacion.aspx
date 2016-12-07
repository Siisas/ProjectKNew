<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Documentacion_Asignacion.aspx.vb" Inherits="digitacion.Documentacion_Asignacion" %>
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
                <%--</tr>--%>
                <tr>
                    <td class="celdasder"></td>
                    <td class="celdascent">
                        <uc1:menu ID="menu1" runat="server" />
                    </td>
                    <td class="celdasder"></td>
                </tr>
                <tr>
                    <td class="celdasder"></td>
                    <td class="celdascent">Asignación  de Solicitudes</td>
                    <td class="celdasder"></td>
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
                                        Filtros De Consulta
                                    </center>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Numero De Solicitud</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txt_num_ticket0" runat="server" Width="171px" MaxLength="9"></asp:TextBox>

                                    <asp:CompareValidator ID="val_cod" runat="server"
                                        ControlToValidate="txt_num_ticket0" ErrorMessage="El caso debe ser numérico"
                                        Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                </td>
                                <td class="textotittabla">Estado</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drl_Tipo_documento" runat="server" Style="margin-top: 0px" Width="184px">
                                    </asp:DropDownList>
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
                                <td class="textotittabla">Fecha Resgistro Hasta</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="Txt_Fecha_fin" runat="server" MaxLength="10" placeholder="DD/MM/YYYY" Width="171px"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server"
                                        ControlToValidate="txt_Fecha_fin" ErrorMessage="La fecha de ingreso no es válida"
                                        Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Prioridad</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drl_prioridad" runat="server">
                                    </asp:DropDownList>
                                </td>
                                <td class="textotittabla">&nbsp;</td>
                                <td class="celdascons">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent">
                        <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass="EstiloBoton" />
                        <asp:Button ID="btn_buscar_todos" runat="server" Text="Buscar Todos" CssClass="EstiloBoton" />
                        <asp:Button ID="btn_Exportar" runat="server" Text="Exportar" />
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent"></td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder"></td>
                    <td class="celdascent">
                        <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                            <tr>
                                <td class="textotittabla">Numero Solicitud</td>
                                <td class="celdascons">
                                    <asp:Label ID="lbl_num_ticket" runat="server"></asp:Label>
                                </td>
                                <td class="textotittabla">Fecha Registro</td>
                                <td class="celdascons">
                                    <asp:Label ID="lbl_fecha_reg" runat="server"></asp:Label>
                                </td>
                            </tr>

                            <tr>
                                <td class="textotittabla">Comentario</td>
                                <td class="celdascons">
                                    <asp:Label ID="txt_comentario" runat="server"></asp:Label>

                                </td>
                                <td class="textotittabla">Prioridad</td>
                                <td class="celdascons">
                                    <asp:Label ID="lbl_prioridad" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Persona Solicita </td>
                                <td class="celdascons">
                                    <asp:Label ID="lbl_per_soli" runat="server"></asp:Label>
                                </td>
                                <td class="textotittabla">Tipo Documento</td>
                                <td class="celdascons">
                                    <asp:Label ID="lbl_tipo_documento" runat="server"></asp:Label>
                                </td>
                            </tr>

                            <tr>
                                <td class="textotittabla">Proceso </td>
                                <td class="celdascons">
                                    <asp:Label ID="lbl_proceso" runat="server"></asp:Label>
                                </td>
                                <td class="textotittabla">Estado</td>
                                <td class="celdascons">
                                    <asp:Label ID="lbl_estado" runat="server"></asp:Label>
                                </td>
                            </tr>

                        </table>
                    </td>
                    <td class="celdasder"></td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="celdascent"></td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder"></td>
                    <td class="celdascent">
                        <table border="1" cellpadding="1" cellspacing="1" class="Tamanio_Tabla">
                            <tr>
                                <td class="textotittabla" colspan="4">
                                    <center>
                                        Asignación De Solicitud De Documentos 
                                    </center>
                                </td>
                            </tr>
                            <tr>
                                <td class="textotittabla">Observación</td>
                                <td class="celdascons">
                                    <asp:TextBox ID="txt_obs" runat="server" MaxLength="99"
                                        Width="99%" Height="45px" TextMode="MultiLine"></asp:TextBox>
                                </td>
                                <td class="textotittabla">Auditor</td>
                                <td class="celdascons">
                                    <asp:DropDownList ID="drl_asignar" runat="server">
                                    </asp:DropDownList>
                                    <asp:Button ID="btn_guardar" runat="server" Text="Asignar" Visible="False" CssClass="EstiloBoton" />
                                </td>
                            </tr>
                        </table>
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
            <%-- <asp:Panel ID="Pn_contenedor1" runat="server">--%>
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
                                    <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" />
                                    <asp:BoundField DataField="Observacion" HeaderText="Observación" />
                                    <asp:BoundField DataField="Persona_Solicita" HeaderText="Persona Solicita" />
                                    <asp:BoundField DataField="Tipo_Documento" HeaderText="Tipo Documento" />
                                    <asp:BoundField DataField="Proceso" HeaderText="Proceso" />
                                    <asp:BoundField DataField="Sub_Proceso" HeaderText="Sub Proceso" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                    <asp:BoundField DataField="Fc_Fin" HeaderText="Fecha Fin" />
                                    <asp:BoundField DataField="Id_Usuario_Asignado" HeaderText="Auditor Asignado" />
                                    <asp:ButtonField CommandName="Seleccion" HeaderText="Asignar" ShowHeader="True" Text="Seleccionar" />
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
            <%--          </asp:Panel>--%>
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
            <%--  <asp:Panel ID="Pn_contenedor2" runat="server">--%>
                    <tr>
                        <td class="celdasder"></td>
                        <td class="celdascent">
                            <asp:UpdatePanel ID="UpdatePanle_Historial" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="dtg_historial" runat="server" AllowPaging="True"
                                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                        GridLines="None" PageSize="5" Width="100%" Style="font-size: x-small" EnableModelValidation="True">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="Id_Historial_Asignacion" HeaderText="Id" />
                                            <asp:BoundField DataField="Id_Solicitud_Documento" HeaderText="Solicitud" />
                                            <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario" />
                                            <asp:BoundField DataField="Fc_Reg" HeaderText="Fecha" />
                                            <asp:BoundField DataField="Observacion" HeaderText="Observación" />
                                            <asp:BoundField DataField="Id_Usuario_Asignado" HeaderText="Asgnado a" />
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
            <%--    </asp:Panel>--%>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server"
            ShowMessageBox="True" />
    </form>
</body>
</html>
