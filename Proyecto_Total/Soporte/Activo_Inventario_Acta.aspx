<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Activo_Inventario_Acta.aspx.vb" Inherits="digitacion.Activo_Inventario_Acta" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>

<!DOCTYPE html>
<%--	© 2016 Crisitan Duarte C1477	--%>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kamilion ERP</title>
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
        <asp:Panel runat="server" ID="paneltitulo">
            <Control:Header ID="Header" runat="server" />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Panel ID="Pnl_Message" runat="server">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </asp:Panel>
        <asp:Panel ID="Pnl_Article" Style="width: 80%; height: 100%; margin: 0px auto;" runat="server">
            <asp:Panel ID="Pnl_Section" Style="width: 75%; margin: 0px auto;" runat="server">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <table style="width: 100%;  color: #000000">
                            <tr>
                                <td class="style4">
                                    <table style="width: 100%; height: 100%" border="1">
                                        <tr>
                                            <td>
                                                <table style="width: 100%; height: 100%;">
                                                    <tr>
                                                        <td style="padding: 20px;">
                                                            <center><asp:Image ID="Image1" runat="server" Height="87px" ImageUrl="~/Css2/Imagenes/LOGO.png" BorderStyle="Dashed"/></center>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td>
                                                <table border="1" style="width: 100%; height: 100%; font-weight: bold; text-align: center;">
                                                    <tr>
                                                        <td colspan="1,8" class="style5">
                                                            <span style="color: rgb(0, 0, 0)">SISTEMA DE GESTION DE CALIDAD</span>
                                                        </td>
                                                        <td colspan="2">
                                                            <span style="color: rgb(0, 0, 0)">GTH-F-19</span>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <span style="color: rgb(0, 0, 0)">GESTION DE TALENTO HUMANO</span>
                                                        </td>
                                                        <td>
                                                            <span style="color: rgb(0, 0, 0)">Fecha de registro</span>
                                                        </td>
                                                        <td>
                                                            <span style="color: rgb(0, 0, 0)">Codigo</span>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td rowspan="2">
                                                            <span style="color: rgb(0, 0, 0)">ACTA DE ENTREGA-RECEPCION DE LOS ACTIVOS FIJOS Y BIENES CONTROLADOS</span>
                                                        </td>
                                                        <td rowspan="2">
                                                            <center style="font-weight: bold"><asp:Label ID="Lblfechareg" runat="server" Font-Size="Small" ForeColor="Black"  ></asp:Label>
                                                        </td>
                                                        <td rowspan="2">
                                                            <center style="font-weight: bold"><asp:Label ID="Lblcodacta" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table border="1" style="width: 100%; height: 100%">
                                        <tr>
                                            <td colspan="2">
                                                <center style="font-weight: bold;">DATOS DEL TRABAJADOR</center>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="">Trabajador:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                           
                                                <asp:Label ID="LblTrabaj" runat="server" ForeColor="Black" Style=""></asp:Label>
                                                <asp:DropDownList ID="drlTrabajador" runat="server" Height="19px" Width="224px" AutoPostBack="True"></asp:DropDownList>
                                            </td>
                                            <td style="">Cedula:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="LblCedula" runat="server" ForeColor="Black" Style=""></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="">Cargo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                                                                                                                
                                                <asp:Label ID="Lblcargo" runat="server" ForeColor="Black" Style=""></asp:Label>
                                            </td>
                                            <td style="">Fecha Asignacion:&nbsp;&nbsp;                          
                                                <asp:Label ID="LblfcAsig" runat="server" ForeColor="Black" Style=""></asp:Label>
                                                <asp:TextBox ID="txtfcreg" runat="server" placeholder="DD/MM/YYYY" Width="52%" CssClass="Fecha" MaxLength="10"></asp:TextBox>
                                                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtfcreg" ErrorMessage="Verifique la fecha" Type="Date" Operator="DataTypeCheck">*</asp:CompareValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="">Area:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                                                                                                                  
                                                <asp:Label ID="LblArea" runat="server" ForeColor="Black" Style=""></asp:Label>
                                                <asp:DropDownList ID="drlArea" runat="server">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="">Codigo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="LblCodigo" runat="server" ForeColor="Black" Style=""></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <p style="font-size: small">
                                                    Todo funcionario de Kamilion es responsable:<br />
                                                    - El debido uso y preservación de los siguientes activos.<br />
                                                    - La custodia.<br />
                                                    - Mantenimiento y reparación de los activos asignados (procedimiento).<br />
                                                    Los siguientes activos fijos se entregan en estado funcional y de uso exclusivamente para el desarrollo de sus labores.
                                                </p>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table border="1" style="width: 100%; height: 100%; text-align: center; font-size: Small;">
                                        <tr style="font-size: 13px; font-weight: bold;">
                                            <td style="width: 9%">SERIAL
                                            </td>
                                            <td style="width: 11%">NOMBRE DEL ACTIVO
                                            </td>
                                            <td style="width: 16%">DESCRIPCION
                                            </td>
                                            <td style="width: 5%">SEDE
                                            </td>
                                            <td>MOTIVO
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial1" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre1" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion1" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede1" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo1" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo1" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial2" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre2" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion2" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede2" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo2" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo2" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial3" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre3" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion3" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede3" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo3" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo3" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial4" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre4" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion4" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede4" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo4" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo4" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial5" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre5" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion5" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede5" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo5" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo5" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial6" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre6" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion6" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede6" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo6" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo6" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial7" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre7" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion7" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede7" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo7" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo7" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial8" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre8" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion8" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede8" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo8" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo8" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial9" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre9" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion9" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede9" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo9" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo9" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9%">
                                                <asp:Label ID="LblSerial10" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 9%">
                                                <asp:Label ID="Lblnombre10" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 16%">
                                                <asp:Label ID="Lbldescripcion10" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                                <asp:Label ID="Lblsede10" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                            </td>
                                            <td style="width: 18%">
                                                <asp:Label ID="LblMotivo10" runat="server" ForeColor="Black" Font-Size="Small"></asp:Label>
                                                <asp:TextBox ID="txtMotivo10" runat="server" Width="69%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="5">
                                                <center style="font-weight: bold;">CLAUSULAS DE COMPROMISO</center>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="5">
                                                <p style="text-align: left; font-size: x-small; font-weight: bold;">
                                                    • Como funcionario activo de Kamilion declaro que los activos relacionados en el presente documento están bajo mi responsabilidad, por lo cual les daré un uso adecuado al desempeño de mis funciones y a la destinación institucional prevista para cada uno de ellos.
                                                    <br />
                                                    • Me comprometo a informar oportunamente por alguna perdida, daño o mantenimiento a mi jefe inmediato o área administrativa, sobre cualquier desplazamiento, traslado temporal o definitivo de dichos activos mediante la tramitación de los formatos respectivos, y sobre cualquier situación que ponga en inminente riesgo los bienes relacionados.
                                                    <br />
                                                    • El área administrativa y auditoria en forma permanente estará haciendo seguimiento de los inventarios de activos fijos en las dependencias, áreas o responsables, previa coordinación con la misma.
                                                    <br />
                                                    • Este tipo de inventarios tiene como objeto determinar el CONTROL del buen manejo de los activos fijos por parte de cada responsable.
                                                </p>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table border="1" style="width: 100%; height: 100%;">
                                        <tr style="font-weight: bold; text-align: center;">
                                            <td>FIRMA DEL RESPONSABLE
                                            </td>
                                            <td>FIRMA DEL USUARIO
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <br />
                                                <br />
                                            </td>
                                            <td>
                                                <br />
                                                <br />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        <asp:Panel ID="PanelIMP" runat="server" Visible="False">
                            <a id="letrapeque" style="color: #B3C556; font-weight: bold" onclick="document.getElementById('letrapeque').style.display = 'none'; document.getElementById('Pnl_Article').style.width = '100%'; document.getElementById('Pnl_Section').style.width = '100%';  $('.celdasder').css('width', '1%'); $('center, td, span').css('font-size', '80%');">Presione antes de imprimir</a>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:Panel>
            <asp:Panel ID="Panelconsulta" runat="server">
                <section>
                    <div class="text-center Subtitulos">Filtros de Consulta</div>
                    <div class="Form">
                        <div class="Cell-Form">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbCodActa" runat="server" GroupName="seleccion" Text="Codigo de Acta" /></div>
                                <asp:TextBox ID="TxtcodActa" runat="server" CssClass="form-control" MaxLength="10" />
                            </div>
                            <h3></h3>
                            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn btn-primary" UseSubmitBehavior="False" />
                            <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar" />
                            <asp:Button ID="btnImprimir" runat="server" CssClass="btn btn-primary" Text="Imprimir" />
                            <asp:Button ID="btnNuevo" runat="server" CssClass="btn btn-primary" Text="Nuevo" />
                            <asp:Label ID="LblSerial" runat="server" Font-Size="Small" ForeColor="Black" Visible="false"></asp:Label>
                            <asp:Label ID="Lblnombre" runat="server" Font-Size="Small" ForeColor="Black" Visible="False"></asp:Label>
                            <asp:Label ID="Lbldescripcion" runat="server" Font-Size="Small" ForeColor="Black" Visible="False"></asp:Label>
                            <asp:Label ID="Lblsede" runat="server" Font-Size="Small" ForeColor="Black" Visible="False"></asp:Label>
                            <asp:Label ID="Lblcantidad" runat="server" Font-Size="Small" ForeColor="Black" Visible="False"></asp:Label>
                        </div>
                        <div class="Space-Form"></div>
                        <div class="Cell-Form">
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbCosusu" runat="server" GroupName="seleccion" Text="Codigo de Usuario" /></div>
                                <asp:TextBox ID="txtCodusu" runat="server" CssClass="form-control" MaxLength="10" />
                            </div>
                        </div>
                    </div>
                    <div class="bordes">
                        <asp:GridView ID="dtgactivos" runat="server" AllowPaging="True" PageSize="80" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" Style="font-size: x-small" EnableModelValidation="True" Visible="false">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" Font-Bold="true" />
                            <Columns>
                                <asp:BoundField DataField="serial" HeaderText="Serial" />
                                <asp:BoundField DataField="Nombre_activo" HeaderText="Activo" />
                                <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                                <asp:BoundField DataField="sede" HeaderText="Sede" />
                                <asp:BoundField DataField="sub_responsable" HeaderText="Responsable" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                    </div>
                </section>
            </asp:Panel>
        </asp:Panel>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Crisitan Duarte C1477	--%>