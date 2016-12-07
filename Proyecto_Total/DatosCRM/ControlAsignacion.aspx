<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ControlAsignacion.aspx.vb" Inherits="digitacion.ControlAsignacion" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Control Operacion</title>
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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <header>
                    <h1 class="text-center" style="font-family: FuenteKamilion">
                        <span  style="font-size: 110%">Kamilion Comunicaciones ERP</span>
                    </h1>
                </header>
    <nav>
            <center>
                 <uc1:menu ID="menu" runat="server" />
                 </center>
                </nav>
    <article>
                    <section class="profile">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblmsg0" runat="server" ForeColor="#8F9E45"><h4><em>Control Operacion</em></h4></asp:Label>
                    </section>
                    <section class="profile">
                        <asp:Label ID="lblusuario" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblcod" Style="margin-right: 3%" runat="server"></asp:Label>
                        <asp:Label ID="lblnombreusu" Style="margin-right: 6%" runat="server"></asp:Label>
                        <asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#8F9E45"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label>&nbsp;&nbsp;
                        <asp:Label ID="LblSupervisor" runat="server"></asp:Label>
                    </section>
                    <section class="profile">
                        <span style="width=100%" class="alert alert-danger">
                            <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
                        </span>
                        <span style="width=100%" class="alert alert-success">
                            <asp:Label ID="lblmsgg" runat="server" Style="color: #6a865f"></asp:Label>
                        </span>
                    </section>
                </article>
    <article>
                        <section>
                            <table style="width:100%">
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                 <%--Control asistencia--%>
                                 <tr>
                                    <td colspan="3" style="width: 100%">
                                        <div class="Titulo">
                                            <strong>Control Operacion</strong>
                                        
                                        </div>
                                    </td>
                                </tr>

                                 <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                     <td style="width: 25%">
                                     <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                         <div class="input-group">
                                            <div class="input-group-addon">Estado</div>
                                            <asp:DropDownList ID="DrlEstado" runat="server" CssClass="form-control" AutoPostBack="true">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </td>
                                    <td style="width: 5%"></td>
                                    <td style="width: 25%">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                    
                                    <asp:Panel runat="server" ID="PnlProgramado" Visible="false">
                                     <div class="input-group" >
                                            <div class="input-group-addon">Estado Programado</div>
                                            <asp:DropDownList ID="DrlProgramado" runat="server" CssClass="form-control" Visible = "true">
                                                <asp:ListItem Value="0">- Seleccione -</asp:ListItem>
                                                <asp:ListItem Value="1">CADUCADO</asp:ListItem>
                                                <asp:ListItem Value="2">VIGENTE</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        </asp:Panel>
                                        </ContentTemplate>                                                                       
                                    </asp:UpdatePanel>
                                    </td>
                                </tr>
                                 <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width: 25%; text-align:left">
                                           <asp:Button ID="BtnBusca" runat="server" CssClass="btn btn-primary" Text="Consultar" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Btnexportar" runat="server" Text="Exportar Excel" CssClass="btn btn-primary" />
                                    </td>
                                    <td style="width: 5%"></td>
                                    <td style="width: 25%"></td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                    <h4 style="color: #8F9E45; text-align:left;"><em>
                                    <asp:Label ID="Lblcampaña" runat="server"></asp:Label>
                                    
                                </em></h4>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="width: 100%">
                                    <section class="DataGrids">
                       <asp:Panel ID="Panel1" Visible="true" runat="server">
                              
                                
                           <div class="bordes">
                                <asp:GridView ID="DtgControl" runat="server" 
                                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                                    GridLines="None" Width="100%" Style="font-size: x-small; text-align:center;" 
                                    EnableModelValidation="True" PageSize="5000" Font-Size="Large">                           
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" HorizontalAlign="Left" />                                
                                         <EmptyDataRowStyle HorizontalAlign="Right" />                                
                                         <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Left" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" 
                                            Font-Size="Small" HorizontalAlign="Left" />
                                        <Columns>
                                            <asp:BoundField DataField="Ingeniero" HeaderText="Ingeniero" runat="server">                                            
                                            <ItemStyle Height="20%" />
                                            </asp:BoundField>

                                            <asp:ButtonField DataTextField="DATOS" HeaderText="DATOS"  CommandName="DATOS" 
                                                runat="server">                                           
                                            <ItemStyle Height="16%" />
                                            </asp:ButtonField>

                                            <asp:ButtonField DataTextField="DESACTIVACION" HeaderText="DESAC" 
                                                CommandName="DESAC"  runat="server">                                            
                                            <ItemStyle Height="5%" />
                                            </asp:ButtonField>

                                            <asp:ButtonField DataTextField="DILO" HeaderText="DILO" CommandName="DILO" 
                                                runat="server">                                          
                                            <ItemStyle Height="16%" />
                                            </asp:ButtonField>

                                            <asp:ButtonField DataTextField="BSCS" HeaderText="BSCS" CommandName = "BSCS" 
                                                runat="server">                                          
                                            <ItemStyle Height="16%" />
                                            </asp:ButtonField>

                                            <asp:ButtonField DataTextField="TSF - PQR" HeaderText="TSF - PQR" CommandName= "TSF" 
                                                runat="server">                                          
                                            <ItemStyle Height="16%" />
                                            </asp:ButtonField>
                                            <asp:ButtonField DataTextField="TOTAL" HeaderText="TOTAL" CommandName= "TOTAL" 
                                                runat="server">                                          
                                            <ItemStyle Height="16%" />
                                            </asp:ButtonField>

                                        </Columns>
                                        <EditRowStyle BackColor="#999999" HorizontalAlign="Right" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333"
                                            HorizontalAlign="Left" />
                                    </asp:GridView>
                                </div>
                               
                        </asp:Panel><br />
                     
                    </section>                                   
                                    
                                    </td>
                                </tr>

                            
                                <tr>
                                    <td colspan="3" style="width: 100%">&nbsp;</td>
                                </tr>
                            </table>
                        </section>
<section class="DataGrids">
                       <asp:Panel ID="Pnl_busqueda" Visible="true" runat="server">
                                <h4 style="color: #8F9E45; text-align:left;"><em>
                                    <asp:Label ID="Label1" runat="server">Registros:&nbsp;</asp:Label>
                                    <asp:Label ID="lblcuenta" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                     <asp:Button ID="BtnExportar2" runat="server" Text="Exportar Excel" CssClass="btn btn-primary" />
                                </em></h4>
                                <div style="overflow:auto; width:100%; height: 500px">
                           <div class="bordes">
                                <asp:GridView ID="dtggeneral" runat="server" AllowPaging="false" 
                                    AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333" 
                                    GridLines="None" Width="100%" Style="font-size: x-small" 
                                    EnableModelValidation="True" PageSize="5000">                           
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                
                                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>
                                </div>
                                </div>
                        </asp:Panel><br />
                     
                    </section>
                </article>
    </form>
</body>
</html>
