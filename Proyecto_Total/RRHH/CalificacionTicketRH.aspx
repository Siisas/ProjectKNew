<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CalificacionTicketRH.aspx.vb" Inherits="digitacion.CalificacionRH" %>

<%@ Register Src="~/Controles/Header.ascx" TagName="Header" TagPrefix="Control" %>
<!DOCTYPE html>
<%--	Ricar	--%>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kamilion Caféteria</title>
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
        <Control:Header ID="Header" runat="server" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Panel ID="Pnl_Message" runat="server">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <article>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <section>
                        <div class="text-center Subtitulos">Filtros de Consulta</div>
                        <div class="Form">
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Código</div>
                                    <asp:TextBox ID="TxtCodigoaa" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Persona Solicita</div>
                                    <asp:TextBox ID="TxtPersonaSolicita" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Fecha Registro</div>
                                    <asp:TextBox ID="TxtFechaInicio" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Área</div>
                                    <asp:TextBox ID="TxtArea" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Requerimientos</div>
                                    <asp:TextBox ID="Txt_Requerimientos" ReadOnly="true" CssClass="form-control" TextMode="MultiLine" runat="server" />
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Prioridad</div>
                                    <asp:TextBox ID="TxtPrioridad" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Área Gestión</div>
                                    <asp:TextBox ID="TxtAreaGestion" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Zona Gestión</div>
                                    <asp:TextBox ID="TxtZonaGestion" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Tema</div>
                                    <asp:TextBox ID="TxtTema" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </section>
                    <section>
                        <div class="text-center Subtitulos"></div>
                        <div class="Form">
                            <div class="Cell-Form">
                                 <div class="input-group">
                                    <div class="input-group-addon">Estado</div>
                                    <asp:DropDownList ID="Drl_Estado" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Calificación</div>
                                    <asp:DropDownList ID="Drl_Calificacion" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-addon">Observación</div>
                                    <asp:TextBox ID="TxtObservacion" CssClass="form-control" TextMode="MultiLine" runat="server" />
                                </div>
                            </div>
                            <div class="Space-Form"></div>
                            <div class="Cell-Form">
                                <div class="input-group">
                                    <div class="input-group-addon">Nivel de Satisfacción</div>
                                        <asp:DropDownList ID="Drl_NivelS" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>         
                                  <div class="input-group">
                                     <%--Aqui importante si el usuario no va a utilizar herramientas como el CRM, no es necesario asignarle la tarea a el=????--%> 
                                    <%-- Este dato es basico por q si se imprimer un formato este debe tener el nombre del usuario que va a firmar el recibido para 
                                        almacenar en su carpeta--%>
                                      <div class="input-group-addon">Asignar Usuario</div>
                                        <asp:DropDownList ID="Drl_Usuarios" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>                               
                            </div>                              
                        </div>
                        <asp:LinkButton ID="Btn_GuardarEstado" Font-Strikeout="false" CssClass="btn btn-primary" runat="server">
                                            <span class="glyphicon glyphicon-floppy-disk"></span> Guardar
                                        </asp:LinkButton>     
                          <asp:LinkButton ID="Btn_Regresar" Font-Strikeout="false" CssClass="btn btn-primary" runat="server">
                                            <span class="glyphicon glyphicon-arrow-left"></span> Volver
                                        </asp:LinkButton>     
                        <div class="bordes" style="overflow: auto; min-height: 0px; max-height: 1000px; width: 100%;">
                            <asp:GridView ID="Gtg_Productos" runat="server" CellPadding="4" ForeColor="#333333"
                                GridLines="None" Width="100%" Style="font-size: x-small"
                                EnableModelValidation="True">
                                <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                            </asp:GridView>                        
                        </div>
                    </section>
                </ContentTemplate>
            </asp:UpdatePanel>
        </article>
        <footer></footer>
    </form>
</body>
</html>
<%--	© 2016 Ricardo Lara C1842--%>