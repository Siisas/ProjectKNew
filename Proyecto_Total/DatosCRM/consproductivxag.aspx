<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consproductivxag.aspx.vb" Inherits="digitacion.consproductivxag" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP Kamilion - Consulta Productividad</title>
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
    <script type="text/jscript">
        var $_$ = jQuery.noConflict();
        function pageLoad() {
            $_$(".Fecha").datepicker({}).val();
        }
    </script>
    <!-- Fin Script jQuery Datepicker --->
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
     <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="../Css2/Maquetacion.css" />
    
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <header>
                    <h1 class="text-center" style="font-family: FuenteKamilion">
                        <span style="font-size: 110%">Kamilion Comunicaciones ERP</span>
                    </h1>
                </header>
                <nav>
                    <center>
                        <uc1:menu ID="menu" runat="server" />
                    </center>
                </nav>
                <article>
                    <section class="profile">
                        <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Consulta Productividad Datos</em></h4></asp:Label>
                    </section>
                    <section class="profile">
                        <asp:Label ID="lblusuario" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblcod" Style="margin-right: 3%" runat="server"></asp:Label>
                        <asp:Label ID="lblnombreusu" Style="margin-right: 6%" runat="server"></asp:Label>
                        <asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#8F9E45"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label>&nbsp;&nbsp;
                        <asp:Label ID="LblSupervisor" runat="server"></asp:Label>
                    </section>
                    <section class="profile" style="width:60%">
                        <span class="alert alert-danger" id="Alert_error" runat="server">
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </span>
                    </section>
                </article>
                <article>
                    <%-- Seccion de Registro --%>
                    <%-------------------------%>
                    <section>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="3" style="width: 100%"><span id="Alert_correcto" runat="server" class="alert alert-success">
                                        <asp:Label ID="Label2" text="Se debe filtrar el rango de fechas deseado no superior a 30 días calendario"  runat="server"></asp:Label>
                                        </span></td>



                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo">
                                            <strong>Filtro</strong>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                  <tr>
                                    <td style="width: 25%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Gestion

                                                 <asp:CompareValidator ID="CompareValidator3" runat="server" 
                                    ControlToValidate="txtfcdesden3" 
                                    ErrorMessage="El formato de Fecha desde no es correcta" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>

                                            </div>
                                                                  

                                           <asp:TextBox ID="txtfcdesden3" CssClass="form-control Fecha" runat="server"></asp:TextBox>
         
                                        </div>
                                    </td>
                                    <td style="width: 5%"></td>
                                    <td style="width: 25%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Fecha Gestion

                                                 <asp:CompareValidator ID="CompareValidator4" runat="server" 
                                    ControlToValidate="txtfchastan3" 
                                    ErrorMessage="El formato de Fecha hasta no es correcta" 
                                    Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>

                                            </div>
                                             <asp:TextBox ID="txtfchastan3" CssClass="form-control Fecha"  runat="server"></asp:TextBox>
                               
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 25%">
                                        <div class="input-group">
                                            <div class="input-group-addon">Estado Caso</div>
                                           
                                        <asp:DropDownList ID="drlestado" runat="server"  CssClass="form-control">
                                    <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                    <asp:ListItem>SI</asp:ListItem>
                                    <asp:ListItem>NO</asp:ListItem>
                                    <asp:ListItem>NS/NR</asp:ListItem>
                                </asp:DropDownList>
                                            
                                             </div>
                                    </td>
                                    <td style="width: 5%"></td>
                                    <td style="width: 25%">
                                       
                                    </td>
                                </tr>
                              
                              
                              
                                <tr>
                                    <td colspan="3" style="width: 100%; text-align:left;">
                                        <h4>
                                      <%--  <asp:Button ID="Button1" Text="Buscar" CssClass="btn btn-primary" runat="server" />--%>

                                        <asp:ImageButton ID="Button1" runat="server" Height="57px"
                        ImageUrl="~/Css2/Imagenes/Consulta.png" Width="60px"
                        AlternateText="Consultar" title="Consultar"  />       
                                     

                                   </h4>
                                    </td>
                                </tr>
                               
                            </table>
                    </section>
                    <%--- Seccion de Consulta ---%>
                    <%---------------------------%>
                  
                    <%--- Seccion de Grids ---%>
                    <%---------------------------%>
                    <section class="DataGrids">
                        <asp:Panel ID="Pnl_Dtg_Desarrollos" Visible="true" runat="server">
                            <h4 style="color: #8F9E45;"><em>
                                <asp:Label runat="server">Consulta Nivel3:&nbsp;&nbsp;</asp:Label>
                                <asp:Label ID="lblcuenta" runat="server"></asp:Label>
                            </em></h4>
                            <div class="bordes">
                                <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True"
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" PageSize="70" Width="100%" Style="font-size: x-small"
                                    EnableModelValidation="True">
                                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                    <Columns>
                                       <asp:BoundField DataField="idcrm" HeaderText="ID" />
                            <asp:BoundField DataField="idcaso" HeaderText="Caso" />
                            <asp:BoundField DataField="fcreg" HeaderText="Fecha Gestión" />
                            <asp:BoundField DataField="idusuario" HeaderText="Agente" />
                            <asp:BoundField DataField="tipificacion" HeaderText="Tipificación" />
                                    </Columns>
                                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                </asp:GridView>
                            </div>
                        </asp:Panel>
                        <br />
                    </section>
                </article>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>

