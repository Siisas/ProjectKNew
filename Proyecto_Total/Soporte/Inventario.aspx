<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Inventario.aspx.vb" Inherits="digitacion.Inventario" %>

<%@ Register src="~/Controles/Header.ascx" tagname="Header" tagprefix="Control" %>

<!DOCTYPE html>
<html>
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Kamilion CRM</title>
        <link rel="icon" href="~/favicon.ico" type="image/x-icon"/>              
        <link rel="shortcut icon" href="~/favicon.ico" type="image/x-icon"/>     
        <script type="text/javascript" src="../Css2/jquery.min.js"></script>
        <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
        <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
        <script type="text/javascript" src="../Css2/scripts.js"></script>
        <!--#########Estilos############-->
        <link type="text/css" rel="Stylesheet" href="~/Css2/Boot/css/bootstrap.min.css"/>   
        <link type="text/css" rel="Stylesheet" href="~/Css2/jquery-ui.css"/>   
        <link type="text/css" rel="Stylesheet" href="~/Css2/Kamilion.css"/>
         <script>
            /***********************************/
            /*Esto gestiona los 3 desplegables*/
            /*********************************/
            function Chang_Panel1() {
                PlegDes_Dinamico("#Pnl_Mas", "slide", '', '', '');
                if ($_$("#Ico_1").attr('class') == 'Icono glyphicon glyphicon-minus-sign') {
                    $_$("#Ico_1").attr('class', 'Icono glyphicon glyphicon-plus-sign')
                    $_$("#nose").text("Mas")
                } else {
                    $_$("#Ico_1").attr('class', 'Icono glyphicon glyphicon-minus-sign')
                    $_$("#nose").text("Menos")
                };
            };
         </script>
    </head>
    <body>
        <form runat="server">
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <Control:Header ID="Header" runat="server"/>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Panel id="Pnl_Message" runat="server">
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>

            <article>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                    <section>
                        <div class="text-center Subtitulos">Registros</div>
                        <div class="text-center Sub-Subtitulo">
                                       MODULO
                                   </div>
                        <div class="Form">
                            <div class="Cell-Form">
                                  <div class="input-group">
                                    <div class="input-group-addon">Letra</div>
                                    <asp:TextBox ID="TxtLetra" runat="server" CssClass="form-control" MaxLength="6"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Numero</div>
                                    <asp:TextBox ID="TxtNumero" CssClass="form-control" runat="server" MaxLength="4"></asp:TextBox>
                                </div>    
                                <asp:Button ID="BtnGuardarModulo" runat="server" CssClass="btn btn-primary" Text="Guardar" />                                
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                  <div class="input-group">
                                    <div class="input-group-addon">Modulo</div>
                                    <asp:Label ID="LblModulo" CssClass="form-control" runat="server"></asp:Label>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Adquisición</div>
                                    <asp:TextBox ID="Txt_Fc_Adq" CssClass="form-control Fecha" runat="server"></asp:TextBox>
                                </div>                                
                            </div>
                        </div>
                        </section>
                        </ContentTemplate>
                </asp:UpdatePanel>
                <section>
                    <div onclick="Chang_Panel1()" Style=" width:150px; margin-top:10px;  font-weight:bold; height:20px; border-radius:20px; text-align:center; border:1px solid #B3C556; background-color:#B3C556; color:white; border-bottom-left-radius: 0px; border-bottom-right-radius: 0px;">
                        <div ><span id="nose">Mas</span><span id="Ico_1" class="Icono glyphicon glyphicon-plus-sign" ></span></div>
                    </div>
                    <div class="Separator"></div>
                </section>
                        <asp:Panel ID="Pnl_Mas" runat="server" Style="display:none">
                            <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                       <section>
                           <div class="Form">
                               <div class="Cell-Form">
                                   <div class="text-center Sub-Subtitulo">
                                       MONITORES
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Marca</div>
                                       <asp:DropDownList Width="50%" ID="drlMarcaMonitor" CssClass="form-control" runat="server"
                                           AutoPostBack="True">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>AOC</asp:ListItem>
                                           <asp:ListItem>Compaq</asp:ListItem>
                                           <asp:ListItem>Dell</asp:ListItem>
                                           <asp:ListItem>Generico</asp:ListItem>
                                           <asp:ListItem>Genius</asp:ListItem>
                                           <asp:ListItem>Hewlett Packard (HP)</asp:ListItem>
                                           <asp:ListItem>Lenovo</asp:ListItem>
                                           <asp:ListItem>Microsoft</asp:ListItem>
                                           <asp:ListItem>Samsung</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox Width="50%" ID="TxtMarcaMonitor" CssClass="form-control" runat="server"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modelo</div>
                                       <asp:TextBox ID="TxtModeloMonitor" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial</div>
                                       <asp:TextBox ID="TxtSerialMonitor" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial Kamilion</div>
                                       <asp:TextBox ID="TxtSerialKamilionMonitor" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Empresa</div>
                                       <asp:DropDownList ID="drlEmpresaMonitor" Width="50%" CssClass="form-control" runat="server"
                                           AutoPostBack="True">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>DYNAMIC</asp:ListItem>
                                           <asp:ListItem>KAMILION</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox ID="TxtEmpresaMonitor" Width="50%" CssClass="form-control" runat="server"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modulo</div>
                                       <asp:DropDownList ID="drlModuloMonitor" CssClass="form-control" runat="server" />
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Fecha Adquisición</div>
                                       <asp:TextBox ID="txt_Fc_Adq_Monitor" CssClass="form-control Fecha" runat="server"></asp:TextBox>
                                   </div>
                                   <br />
                                   <asp:Button ID="BtnGuardarMonitor" CssClass="btn btn-primary" runat="server" Text="Guardar" />
                                   <br />
                                   <br />
                                   <div class="text-center Sub-Subtitulo">
                                       MOUSES
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Marca</div>
                                       <asp:DropDownList ID="drlMarcaMouse" Width="50%" CssClass="form-control" runat="server"
                                           AutoPostBack="True">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>AOC</asp:ListItem>
                                           <asp:ListItem>Compaq</asp:ListItem>
                                           <asp:ListItem>Dell</asp:ListItem>
                                           <asp:ListItem>Generico</asp:ListItem>
                                           <asp:ListItem>Genius</asp:ListItem>
                                           <asp:ListItem>Hewlett Packard (HP)</asp:ListItem>
                                           <asp:ListItem>Lenovo</asp:ListItem>
                                           <asp:ListItem>Microsoft</asp:ListItem>
                                           <asp:ListItem>Samsung</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox ID="TxtMarcaMouse" Width="50%" CssClass="form-control" runat="server"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modelo</div>
                                       <asp:TextBox ID="TxtModeloMouse" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial</div>
                                       <asp:TextBox ID="TxtSerialMouse" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial Kamilion</div>
                                       <asp:TextBox ID="TxtSerialKamilionMouse" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Empresa</div>
                                       <asp:DropDownList ID="drlEmpresaMouse" Width="50%" CssClass="form-control" runat="server"
                                           AutoPostBack="True">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>DYNAMIC</asp:ListItem>
                                           <asp:ListItem>KAMILION</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox ID="TxtEmpresaMouse" Width="50%" CssClass="form-control" runat="server"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modulo</div>
                                       <asp:DropDownList ID="drlModuloMouse" CssClass="form-control" runat="server" />
                                   </div>
                                      <div class="input-group">
                                       <div class="input-group-addon">Fecha Adquisición</div>
                                       <asp:TextBox ID="txt_Fc_Adq_Mouse" CssClass="form-control Fecha" runat="server"></asp:TextBox>
                                   </div>
                                   <br />
                                   <asp:Button ID="BtnGuardarMouse" CssClass="btn btn-primary" runat="server" Text="Guardar" />
                                   <br />
                                   <br />
                                   <div class="text-center Sub-Subtitulo">
                                       DISPOSITIVOS
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Dispositivo</div>
                                       <asp:DropDownList ID="drlDispositivo" runat="server" CssClass="form-control" AutoPostBack="True" />
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Marca</div>
                                       <asp:DropDownList Width="50%" ID="drlMarcaDisposivito" runat="server" AutoPostBack="True"
                                           CssClass="form-control">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>AOC</asp:ListItem>
                                           <asp:ListItem>Compaq</asp:ListItem>
                                           <asp:ListItem>Dell</asp:ListItem>
                                           <asp:ListItem>Generico</asp:ListItem>
                                           <asp:ListItem>Genius</asp:ListItem>
                                           <asp:ListItem>Hewlett Packard (HP)</asp:ListItem>
                                           <asp:ListItem>Lenovo</asp:ListItem>
                                           <asp:ListItem>Microsoft</asp:ListItem>
                                           <asp:ListItem>Samsung</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox ID="TxtMarcaDispositivo" runat="server" Width="50%" CssClass="form-control"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modelo</div>
                                       <asp:TextBox ID="TxtModeloDispositivo" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial</div>
                                       <asp:TextBox ID="TxtSerialDispositivo" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial Kamilion</div>
                                       <asp:TextBox ID="TxtSerialKamilionDispositivo" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Empresa</div>
                                       <asp:DropDownList Width="50%" ID="drlEmpresaDispositivo" CssClass="form-control"
                                           runat="server" AutoPostBack="True">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>DYNAMIC</asp:ListItem>
                                           <asp:ListItem>KAMILION</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox Width="50%" ID="TxtEmpresaDispositivo" CssClass="form-control" runat="server"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modulo</div>
                                       <asp:DropDownList ID="drlModuloDispositivo" CssClass="form-control" runat="server" />
                                   </div>
                                      <div class="input-group">
                                       <div class="input-group-addon">Fecha Adquisición</div>
                                       <asp:TextBox ID="txt_Fc_Adq_Dispositivo" CssClass="form-control Fecha" runat="server"></asp:TextBox>
                                   </div>
                                   <br />
                                   <asp:Button ID="BtnGuardarDispositivo" runat="server" CssClass="btn btn-primary" Text="Guardar" />

                               </div>
                               <div class="Space-Form"></div>
                               <div class="Cell-Form">
                                   <div class="text-center Sub-Subtitulo">
                                       TECLADO
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Marca</div>
                                       <asp:DropDownList ID="drlMarcaTeclado" Width="50%" CssClass="form-control" runat="server"
                                           AutoPostBack="True">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>AOC</asp:ListItem>
                                           <asp:ListItem>Compaq</asp:ListItem>
                                           <asp:ListItem>Dell</asp:ListItem>
                                           <asp:ListItem>Generico</asp:ListItem>
                                           <asp:ListItem>Genius</asp:ListItem>
                                           <asp:ListItem>Hewlett Packard (HP)</asp:ListItem>
                                           <asp:ListItem>Lenovo</asp:ListItem>
                                           <asp:ListItem>Microsoft</asp:ListItem>
                                           <asp:ListItem>Samsung</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox ID="TxtMarcaTeclado" Width="50%" CssClass="form-control" runat="server"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modelo</div>
                                       <asp:TextBox ID="TxtModeloTeclado" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial</div>
                                       <asp:TextBox ID="TxtSerialTeclado" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial Kamilion</div>
                                       <asp:TextBox ID="TxtSerialKamilionTeclado" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Empresa</div>
                                       <asp:DropDownList ID="drlEmpresaTeclado" Width="50%" CssClass="form-control" runat="server"
                                           AutoPostBack="True">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>DYNAMIC</asp:ListItem>
                                           <asp:ListItem>KAMILION</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox ID="TxtEmpresaTeclado" Width="50%" CssClass="form-control" runat="server"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modulo</div>
                                       <asp:DropDownList ID="drlModuloTeclado" CssClass="form-control" runat="server">
                                       </asp:DropDownList>
                                   </div>
                                      <div class="input-group">
                                       <div class="input-group-addon">Fecha Adquisición</div>
                                       <asp:TextBox ID="txt_Fc_Adq_Teclado" CssClass="form-control Fecha" runat="server"></asp:TextBox>
                                   </div>
                                   <br />
                                   <asp:Button ID="BtnGuardarTeclado" CssClass="btn btn-primary" runat="server" Text="Guardar" />
                                   <br />
                                   <br />
                                   <div class="text-center Sub-Subtitulo">
                                       TORRE
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Marca</div>
                                       <asp:DropDownList ID="drlMarcaTorre" Width="50%" CssClass="form-control" runat="server"
                                           AutoPostBack="True">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>AOC</asp:ListItem>
                                           <asp:ListItem>Compaq</asp:ListItem>
                                           <asp:ListItem>Dell</asp:ListItem>
                                           <asp:ListItem>Generico</asp:ListItem>
                                           <asp:ListItem>Genius</asp:ListItem>
                                           <asp:ListItem>Hewlett Packard (HP)</asp:ListItem>
                                           <asp:ListItem>Lenovo</asp:ListItem>
                                           <asp:ListItem>Microsoft</asp:ListItem>
                                           <asp:ListItem>Samsung</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox ID="TxtMarcaTorre" Width="50%" CssClass="form-control" runat="server"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modelo</div>
                                       <asp:TextBox ID="TxtModeloTorre" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial</div>
                                       <asp:TextBox ID="TxtSerialTorre" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Serial Kamilion</div>
                                       <asp:TextBox ID="TxtSerialKamilionTorre" CssClass="form-control" runat="server"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Empresa</div>
                                       <asp:DropDownList ID="drlEmpresaTorre" Width="50%" CssClass="form-control" runat="server"
                                           AutoPostBack="True">
                                           <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                           <asp:ListItem>DYNAMIC</asp:ListItem>
                                           <asp:ListItem>KAMILION</asp:ListItem>
                                           <asp:ListItem>Otro</asp:ListItem>
                                       </asp:DropDownList>
                                       <asp:TextBox ID="TxtEmpresaTorre" Width="50%" CssClass="form-control" runat="server"
                                           Enabled="False"></asp:TextBox>
                                   </div>
                                   <div class="input-group">
                                       <div class="input-group-addon">Modulo</div>
                                       <asp:DropDownList ID="drlModuloTorre" CssClass="form-control" runat="server" />
                                   </div>
                                      <div class="input-group">
                                       <div class="input-group-addon">Fecha Adquisición</div>
                                       <asp:TextBox ID="txt_Fc_Adq_Torre" CssClass="form-control Fecha" runat="server"></asp:TextBox>
                                   </div>
                                   <br />
                                   <asp:Button ID="BtnGuardarTorre" CssClass="btn btn-primary" runat="server" Text="Guardar" />
                                   <br />
                                   <br />
                               </div>
                           </div>
                       </section>
                    </ContentTemplate>
                            </asp:UpdatePanel>
                        </asp:Panel>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <section>
                            <div class="text-center Subtitulos">Consultas</div>
                            <div class="Form">
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnModulo" GroupName="Seleccion" runat="server" Text="Modulo" />
                                        </div>
                                        <asp:DropDownList ID="drlModuloConsultas" CssClass="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnMarca" GroupName="Seleccion" runat="server" Text="Marca" />
                                        </div>
                                        <asp:DropDownList ID="drlMarcaConsulta" Width="50%" CssClass="form-control" runat="server"
                                            AutoPostBack="True">
                                            <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            <asp:ListItem>AOC</asp:ListItem>
                                            <asp:ListItem>Compaq</asp:ListItem>
                                            <asp:ListItem>Dell</asp:ListItem>
                                            <asp:ListItem>Generico</asp:ListItem>
                                            <asp:ListItem>Genius</asp:ListItem>
                                            <asp:ListItem>Hewlett Packard (HP)</asp:ListItem>
                                            <asp:ListItem>Lenovo</asp:ListItem>
                                            <asp:ListItem>Microsoft</asp:ListItem>
                                            <asp:ListItem>Samsung</asp:ListItem>
                                            <asp:ListItem>Otro</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:TextBox ID="TxtMarcaConsulta" Width="50%" CssClass="form-control" runat="server"
                                            Enabled="False"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnModelo" GroupName="Seleccion" runat="server" Text="Modelo" />
                                        </div>
                                        <asp:TextBox ID="TxtModeloConsulta" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                     <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnFc_Adquisicion" GroupName="Seleccion" runat="server" Text="Fecha de Adquisición" />
                                        </div>
                                        <asp:TextBox ID="Txt_Consuta_Adquisicion" CssClass="form-control Fecha" runat="server"></asp:TextBox>
                                    </div>
                                    <asp:Button ID="BtnConsultaInventario" runat="server" CssClass="btn btn-primary" Text="Consultar" />
                                </div>
                                <div class="Space-Form"></div>
                                <div class="Cell-Form">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnSerial" GroupName="Seleccion" runat="server" Text="Serial" />
                                        </div>
                                        <asp:TextBox ID="TxtSerialConsulta" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnSerialKamilion" GroupName="Seleccion" runat="server" Text="Serial Kamilion" />
                                        </div>
                                        <asp:TextBox ID="TxtSerialKamilionConsulta" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            <asp:RadioButton ID="RdbtnEmpresa" GroupName="Seleccion" runat="server" Text="Empresa" />
                                        </div>
                                        <asp:DropDownList ID="drlEmpresaConsulta" Width="50%" CssClass="form-control" runat="server"
                                            AutoPostBack="True">
                                            <asp:ListItem Value="1">- Seleccione -</asp:ListItem>
                                            <asp:ListItem>DYNAMIC</asp:ListItem>
                                            <asp:ListItem>KAMILION</asp:ListItem>
                                            <asp:ListItem>Otro</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:TextBox ID="TxtEmpresaConsulta" Width="50%" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="Leyendas ">
                            <asp:Label ID="Label7" runat="server"> Numero de registros: </asp:Label>
                            <asp:Label ID="lblcantidad" runat="server">0</asp:Label>
                        </div>
                        <div class="bordes">
                            <asp:GridView ID="dtgConsultaMonitores" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="90" Width="100%"
                                Style="font-size: x-small" EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_Inventario" HeaderText="Código" />
                                    <asp:BoundField DataField="Dispositivo" HeaderText="Dispositivo" />
                                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                                    <asp:BoundField DataField="Serial" HeaderText="Serial" />
                                    <asp:BoundField DataField="Serial_Kamilion" HeaderText="Serial Kamilion" />
                                    <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                                    <asp:BoundField DataField="Fk_Id_Modulo" HeaderText="Modulo" />
                                    <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario Registra" />
                                    <asp:BoundField DataField="FcReg_Invent" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="Fc_Adquisicion" HeaderText="Fecha Adquisición" />
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
                </asp:UpdatePanel>
            </article>
            <footer></footer>
        </form>
    </body>
</html>
