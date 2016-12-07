<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegCrm_Poll.aspx.vb" Inherits="digitacion.RegCrm_Poll" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <%--© CDRR--%>
    <title>ERP Kamilion - Registro CRM Poll</title>
    <link rel="icon" href="../favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="../favicon.ico" type="image/x-icon" />
    <%--Colocar como comentario para ver correctamente la vista diseño--%>
    <link href="../Css2/Boot/css/bootstrap.min.css" rel="Stylesheet" />
    <link type="text/css" rel="stylesheet" href="../Css2/maquetacion.css" />
    <%------------------------------------------------------------------%>
    <!-- Inicio Script jQuery Datepicker --->
    <link type="text/css" rel="stylesheet" href="../Css2/jquery-ui.css" />
    <script type="text/javascript" src="../Css2/jquery.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui.min.js"></script>
    <script type="text/javascript" src="../Css2/jquery-ui-timepiker.js"></script>
     
<script type="text/jscript">
    var $_$ = jQuery.noConflict();
    function pageLoad() {
        $_$('#Txt_hora').timepicker({ timeFormat: 'hh:mm' }).val();
        $_$("#txtfcingn3").datepicker({ dateFormat: 'dd/mm/yy' }).val();
    }
</script>
    <!-- Fin Script jQuery Datepicker --->
    <style type="text/css">
        ::-webkit-scrollbar {
            width: 14px;
        }

        ::-webkit-scrollbar-button {
            background-color: #B3C556;
            border-radius: 5px;
            background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%, transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%, transparent 75%, /*SD*/ transparent);
        }

            ::-webkit-scrollbar-button:hover {
                background-color: #EEEEEE;
            }

            ::-webkit-scrollbar-button:active {
                background: #aeaeb5;
            }

        ::-webkit-scrollbar-thumb {
            background-color: #B3C556;
            border-radius: 12px;
            background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%, transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%, transparent 75%, /*SD*/ transparent);
        }

            ::-webkit-scrollbar-thumb:hover {
                background-color: #EEEEEE;
            }

            ::-webkit-scrollbar-thumb:active {
                background: #aeaeb5;
            }

        *::selection {
            background: #B3C556;
            color: #fff;
        }

        ::-moz-selection {
            background: #B3C556;
            color: #fff;
        }

        @font-face {
            font-family: FuenteKamilion;
            src: url(../Css2/Boot/fonts/NEUROPOL.ttf);
        }

        body {
            background-color: #eee;
        }

        .titulo {
            transition: 2s ease;
            color: #B3C556;
            text-shadow: -2px -2px 1px #000;
        }

            .titulo:hover {
                color: #B3C556;
                text-shadow: -2px -2px 1px #fff;
            }

        .bordes {
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            overflow: hidden;
        }

        .celdasder {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: Navy;
            font-weight: bold;
            width: 10%;
        }

        .celdascent_Bootstrap {
            width: 80%;
        }

        .Tamanio_Tabla {
            width: 100%;
            height: 100%;
        }

        .linkbutton {
            color: #B3C556;
            text-decoration: none;
        }

            .linkbutton:hover {
                color: #555555;
                text-decoration: solid;
                text-decoration-color: #fff;
            }
        /*Tamaños Internos de un TD*/
        .td_Mitad {
            width: 5%;
        }

        .td_Mitad {
            width: 5%;
        }

        .td_Intermedio {
            /*width: 25%;*/
            width: 34%;
        }
        /*.td_Externo
        {
            width: 9%;
        }*/
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <table style="width: 100%; height: 100%">
            <tr>
                <td class="celdasder"></td>
                <td class="celdascent_Bootstrap">
                    <table style="width: 100%">
                        <tr>
                            <td align="left" style="width: 100%">
                                <h1 class="text-center" style="font-family: FuenteKamilion">
                                    <span class="titulo" style="font-size: 110%">Kamilion Comunicaciones ERP</span></h1>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent_Bootstrap">
                    <uc1:menu ID="menu" runat="server" />
                </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent_Bootstrap">
                    <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Registro CRM Encuestas de percepcion del servicio </em></h4></asp:Label>
                </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
            <tr>
                <td class="celdasder"></td>
                <td class="celdascent_Bootstrap">
                    <table class="Tamanio_Tabla">
                        <tr>
                            <td style="width: 30%">
                                <asp:Label ID="lblusuario" runat="server"></asp:Label>
                            </td>
                            <td style="width: 70%">
                                <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                                &nbsp;&nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#009933"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label
                                    ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label><asp:Label
                                        ID="LblSupervisor" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="celdasder"></td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent_Bootstrap">
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <span class="alert alert-danger">
                                <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
                            </span>
                         
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
             <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent_Bootstrap">
              </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
            <tr>
                <td class="celdasder">
                    <%--  <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                    Style="color: #8F9E45" />--%>
                </td>
                <td class="celdascent_Bootstrap">
                    <table cellpadding="1" cellspacing="1" width="100%">
                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="form-group">
                                    <div class="input-group">
                                        <div class="input-group-addon">
                                            Caso<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcaso"
                                                ErrorMessage="El caso debe ser numérico" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                        </div>
                                        <asp:TextBox ID="txtcaso" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="form-group">
                                    <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" />
                                </div>
                            </td>
                            <%--   <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                          
                            <td class="td_Intermedio">&nbsp;
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">&nbsp;
                            </td>
                         
                        </tr>
                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>&nbsp;</strong>
                                </div>
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td colspan="3">&nbsp;
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                            <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        MIN
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="lblmin" runat="server" CssClass="form-control"
                                        Enable="False"></asp:Label>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Caso
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="lblcaso" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                            </td>
                            <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                            <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Nombre
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="lblcliente" runat="server" CssClass="form-control"
                                        Enable="False"></asp:Label>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Grupo
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="lblgrupo" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                            </td>
                            <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Departamento</div>
                                    <asp:Label Style="background-color: inherit" ID="Lbldepartamento" runat="server" CssClass="form-control" Enable="False"></asp:Label>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Municipio
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="Lblmunicipio" runat="server" CssClass="form-control"></asp:Label>
                                </div>
                               
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                      
                        <tr>
                            <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                 <div class="input-group">
                                  <div class="input-group-addon">
                                       Tipo de Linea
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="Lbltipolinea" runat="server" CssClass="form-control"
                                        Enable="False"></asp:Label>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                 <div class="input-group">
                                    <div class="input-group-addon">
                                        Fecha Ingreso
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="Lblfc_ingreso" runat="server" CssClass="form-control"></asp:Label>
                                </div> 
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                            <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Estado Bandeja
                                    </div>
                                    <asp:Label Style="background-color: inherit" ID="lblestado" runat="server" CssClass="form-control"
                                        Enable="False"></asp:Label>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                              
                                  
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                       
                        <tr>
                            <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td colspan="3">
                                <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                    <strong>&nbsp;</strong>
                                </div>
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <h4>
                                    <em style="color: #8F9E45">Registro de Encuesta&nbsp;&nbsp;&nbsp;</em>
                                    <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" Visible="False" CssClass="btn btn-primary" /></h4>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">&nbsp;
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipificación Llamada
                                    </div>
                                     <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                     <ContentTemplate>
                                    <asp:DropDownList ID="drltipificacionll" runat="server" CssClass="form-control" AutoPostBack="True">
                                    </asp:DropDownList>
                                        
                               </ContentTemplate>
                               </asp:UpdatePanel> 
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo Encuesta
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel_Tipo_Encuesta" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="DrlTipo_Encuesta" runat="server" CssClass="form-control" AutoPostBack="True">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem>Corta</asp:ListItem>
                                                <asp:ListItem>Larga</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
<%--                            <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>

                          <tr>
  
                               <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                       Fecha Programado
                                             <asp:CompareValidator ID="CompareValidator2" runat="server"
                                                 ControlToValidate="txtfcingn3" ErrorMessage="La fecha de ingreso no es válida"
                                                 Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                                    </div>
                                     <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                     <ContentTemplate>
                              <asp:TextBox ID="txtfcingn3" runat="server" CssClass="form-control"
                              placeholder="DD/MM/YYYY" Enabled ="false" MaxLength="10"></asp:TextBox>
                                     
                               </ContentTemplate>
                               </asp:UpdatePanel> 
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                      Hora Programado
                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txt_hora"
                                                    ErrorMessage="el numero debe ser mayor a cero" ValidationExpression="^[:\0-9]*$">*</asp:RegularExpressionValidator>
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                        <ContentTemplate>
                                            <asp:TextBox ID="Txt_hora" runat="server" Enabled ="false"  CssClass="form-control" placeholder="HH:MM"  MaxLength="10"></asp:TextBox>
                                            <%--<asp:TextBox ID="Txt_minutos" runat="server" Enabled ="false" CssClass="form-control" Width="50px" placeholder="MM" MaxLength="2"></asp:TextBox>--%>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
       </tr>







                         <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                       Motivos de culminacion 
                                    </div>
                                    
     <asp:UpdatePanel ID="UpdatePanel16" runat="server">
     <ContentTemplate>

                                    <asp:DropDownList ID="Drl_motivos_culminacion" enabled = "false" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
               </ContentTemplate>
         </asp:UpdatePanel> 
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                     Observacion
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                        <ContentTemplate>
                                             <asp:TextBox ID="Txt_Obs" CssClass="form-control" TextMode ="MultiLine"  Enabled="false"  runat="server"></asp:TextBox>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
                            <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>



                        <tr>
                            <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Genero
                                    </div>
                                    
     <asp:UpdatePanel ID="UpdatePanel17" runat="server">
     <ContentTemplate>



                                    <asp:DropDownList ID="DrlGenero" runat="server" CssClass="form-control">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>Femenino</asp:ListItem>
                                        <asp:ListItem>Masculino</asp:ListItem>
                                    </asp:DropDownList>
                </ContentTemplate>
         </asp:UpdatePanel> 
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Titular de la linea
                                    </div>

                                    
     <asp:UpdatePanel ID="UpdatePanel18" runat="server">
     <ContentTemplate>

                                    <asp:DropDownList ID="DrlTitular_Linea" runat="server" CssClass="form-control">
                                        <asp:ListItem>- Seleccione -</asp:ListItem>
                                        <asp:ListItem>No</asp:ListItem>
                                        <asp:ListItem>Si</asp:ListItem>
                                    </asp:DropDownList>
           </ContentTemplate>
         </asp:UpdatePanel> 

                                </div>
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                       <tr>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Tipo linea
                                    </div>

                                    <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="drlTipo_Cliente" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                                <asp:ListItem>Pospago</asp:ListItem>
                                                <asp:ListItem>Prepago</asp:ListItem>
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>

                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Intencion Del Usuario
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                                        <ContentTemplate>
                                            <asp:DropDownList ID="Drl_Intension_Del_Usuario" Enabled="false" runat="server"
                                                CssClass="form-control">
                                            </asp:DropDownList>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>
                       </tr>

                        <tr>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ¿Ha navegado por internet y/o
                                        <br />
                                        en redes sociales utilizando
                                        <br />
                                        los datos de su celular en los
                                        <br />
                                        últimos 15 días?
                                    </div>
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            <div style="background-color: inherit; overflow-y: auto; height: 70px" class="form-control">
                                                <asp:DropDownList ID="drlInternet_Redes_sociales" runat="server" CssClass="form-control">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>No</asp:ListItem>
                                                    <asp:ListItem>NS/NR</asp:ListItem>
                                                    <asp:ListItem>Si</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </td>

                            <td class="td_Mitad"></td>
                            <td class="td_Intermedio">&nbsp;
                            </td>
                        </tr>

                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ¿Ha tenido alguna dificultad
                                        <br />
                                        al usar el servicio de datos
                                        <br />
                                        en los últimos 15 días?
                                    </div>
                                    <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="DrlDificultad_Usar_Servicio_Datos" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>No</asp:ListItem>
                                                    <asp:ListItem>NS/NR</asp:ListItem>
                                                    <asp:ListItem>Si</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ¿Ha tenido alguna dificultad
                                        <br />
                                        al usar el servicio de voz
                                        <br />
                                        en los últimos 15 días?
                                    </div>
                                    <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                            <ContentTemplate>

                                                <asp:DropDownList ID="DrlDificultad_Usar_Servicio_Voz" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                    <asp:ListItem>No</asp:ListItem>
                                                    <asp:ListItem>NS/NR</asp:ListItem>
                                                    <asp:ListItem>Si</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Si el cliente ha tenido                         alguna dificultad Datos
                                    </div>
                                   <%-- <div style="background-color: inherit; " class="form-control">--%>
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>

                                                <asp:DropDownList ID="DrlHa_Tenido_Dificultad_Datos" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                              <%--  </div>--%>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Si el cliente ha tenido alguna dificultad Voz
                                    </div>
                                    <%--<div style="background-color: inherit; " class="form-control">--%>
                                        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                            <ContentTemplate>


                                                <asp:DropDownList ID="DrlHa_Tenido_Dificultad_Voz" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem>- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>

                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                             <%--   </div>--%>
                            </td>
                            <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>







                        <tr>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ¿Cual?
                                    </div>
                                 <%--<div style="background-color: inherit;"  class="form-control">--%>
                                        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="Txt_Cual_1" CssClass="form-control" Enabled="false" MaxLength="20" runat="server"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                               <%--</div>--%>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ¿Cual?
                                    </div>
                             
                                        <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="Txt_cual_2" CssClass="form-control" Enabled="false" MaxLength="20" runat="server"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                            
                            </td>
                        </tr>






                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ¿De las dificultades manifestadas
                                        <br />
                                        anteriormente, cuál es la más
                                        <br />
                                        molesta para usted - Datos?
                                    </div>
                                    <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                            <ContentTemplate>


                                                <asp:DropDownList ID="DrlCual_Es_Mas_Molesta_Datos" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>

                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ¿De las dificultades manifestadas
                                        <br />
                                        anteriormente, cuál es la más
                                        <br />
                                        molesta para usted - Voz?
                                    </div>
                                    <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="DrlCual_Es_Mas_Molesta_Voz" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                            <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>







                        <tr>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ¿Cual?
                                    </div>
                                  
                                        <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="Txt_Cual_3" CssClass="form-control" MaxLength="20" Enabled="false" runat="server"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                               
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        ¿Cual?
                                    </div>
                                   <%-- <div style="background-color: inherit;"  class="form-control">--%>
                                        <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="Txt_Cual_4" CssClass="form-control" Enabled="false" MaxLength="20" runat="server"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                        <%--        </div>--%>
                            </td>
                        </tr>









                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        En estos 7 días ¿como percibe<br />
                                        la calidad del servicio con respecto<br />
                                        a la semana anterior - Datos?
                                    </div>
                                    <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                             <asp:UpdatePanel ID="UpdatePanel20" runat="server">
     <ContentTemplate>

                                        <asp:DropDownList ID="DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Datos"
                                            runat="server" CssClass="form-control">
                                            <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="Mejor">Mejor</asp:ListItem>
                                            <asp:ListItem Value="Peor">Peor</asp:ListItem>
                                            <asp:ListItem Value="Igual">Igual</asp:ListItem>
                                        </asp:DropDownList>
         
  </ContentTemplate>
         </asp:UpdatePanel> 
                                    </div>
                                </div>
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        En estos 7 días ¿como percibe<br />
                                        la calidad del servicio con respecto<br />
                                        a la semana anterior - Voz?
                                    </div>
                                    <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                        

     <asp:UpdatePanel ID="UpdatePanel21" runat="server">
     <ContentTemplate>


                                        <asp:DropDownList ID="DrlComo_Percibe_Calidad_Servicio_Contra_SemanaAnterior_Voz"
                                            runat="server" CssClass="form-control">
                                            <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                            <asp:ListItem Value="Mejor">Mejor</asp:ListItem>
                                            <asp:ListItem Value="Peor">Peor</asp:ListItem>
                                            <asp:ListItem Value="Igual">Igual</asp:ListItem>
                                        </asp:DropDownList>

         
  </ContentTemplate>
         </asp:UpdatePanel> 


                                    </div>
                                </div>
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <%-- Fin Encuesta Corta --%>                    <%-- Inicio Encuesta laga --%>
                        <tr>
                            <td colspan="5">
                                <asp:UpdatePanel ID="UpdatePanel_Poll_Long" runat="server">
                                    <ContentTemplate>
                                        <asp:Panel ID="Panel_Poll_Long" runat="server" Visible="false">
                                            <table cellpadding="1" cellspacing="1" width="100%">
                                                <tr>
                                                    <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td colspan="3">
                                                        <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                                            <center><strong>NPS</strong></center>
                                                        </div>
                                                    </td>
                                                    <%--<td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%-- <td class="td_Externo">
                                </td>--%>
                                                    <td colspan="3" style="width: 55%">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Utilizando una escala de 0 a 10, donde 0 significa nada probable y 10 significa
                                            totalmente
                                            <br />
                                                                probable, ¿qué tan probable es que usted recomiende contratar los servicios de Claro
                                            a una
                                            <br />
                                                                persona amiga o conocida?
                                                            </div>
                                                            <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                                                <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                                                    <ContentTemplate>


                                                                        <asp:DropDownList ID="DrlRecomienda_Contratar_Servicios_Claro_AmigaConocida" runat="server"
                                                                            CssClass="form-control" AutoPostBack="True">
                                                                            <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                            <asp:ListItem Value="1">1</asp:ListItem>
                                                                            <asp:ListItem Value="2">2</asp:ListItem>
                                                                            <asp:ListItem Value="3">3</asp:ListItem>
                                                                            <asp:ListItem Value="4">4</asp:ListItem>
                                                                            <asp:ListItem Value="5">5</asp:ListItem>
                                                                            <asp:ListItem Value="6">6</asp:ListItem>
                                                                            <asp:ListItem Value="7">7</asp:ListItem>
                                                                            <asp:ListItem Value="8">8</asp:ListItem>
                                                                            <asp:ListItem Value="9">9</asp:ListItem>
                                                                            <asp:ListItem Value="10">10</asp:ListItem>
                                                                            <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                        </asp:DropDownList>

                                                                    </ContentTemplate>
                                                                </asp:UpdatePanel>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>


                                                <asp:Panel ID="Pnl_P1B" Visible="false" runat="server">
                                                    <tr>

                                                        <%--<td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                        <td colspan="2">
                                                            <div class="text-center" style="color: #8F9E45; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                                                <em>
                                                                    <strong>

                                                                        <%--<asp:Label ID="Label2" runat="server" Text="Label">--%>
                                            ¿Cuáles son las principales razones por las que usted considera que no es muy probable que recomiende a una persona amiga o conocida contratar los servicios de
                                            Claro? (ESPONTÁNEA, HASTA TRES RESPUESTAS).
                                           <%-- </asp:Label>--%>
                                                                    </strong>
                                                                </em>
                                                            </div>
                                                        </td>
                                                        <%--<td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    </tr>
                                                    <tr>
                                                        <%--<td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                        <td class="td_Intermedio">
                                                            <div class="input-group">
                                                                <div class="input-group-addon">
                                                                    No probable
                                                                </div>
                                                                <asp:DropDownList ID="Drl_Razones_Pricipales_No_Recomiende_Servicio" runat="server"
                                                                    CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </td>
                                                        <td class="td_Mitad">&nbsp;
                                                        </td>
                                                        <td class="td_Intermedio">
                                                            <div class="input-group">
                                                                <div class="input-group-addon">
                                                                    Opciones elegidas
                                                                </div>
                                                                <asp:UpdatePanel ID="UpdatePanel_Opciones_No_Probale" runat="server">
                                                                    <ContentTemplate>
                                                                        <div style="background-color: inherit; overflow-y: auto; height: 80px" class="form-control">
                                                                            <asp:Label ID="LblNo_Probable_Valor1" runat="server" Visible="false"></asp:Label>
                                                                            <asp:Label ID="LblNo_Probable1" runat="server"></asp:Label><br />
                                                                            <asp:Label ID="LblNo_Probable_Valor2" runat="server" Visible="false"></asp:Label>
                                                                            <asp:Label ID="LblNo_Probable2" runat="server"></asp:Label><br />
                                                                            <asp:Label ID="LblNo_Probable_Valor3" runat="server" Visible="false"></asp:Label>
                                                                            <asp:Label ID="LblNo_Probable3" runat="server"></asp:Label>
                                                                        </div>
                                                                    </ContentTemplate>
                                                                </asp:UpdatePanel>
                                                            </div>
                                                        </td>
                                                        <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    </tr>
                                                    <tr>
                                                        <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                        <td class="td_Intermedio">
                                                            <asp:UpdatePanel ID="UpdatePanel_BtnAgregar_No_Probable" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:Button ID="BtnAgregar_No_Probable" runat="server" Text="Agregar" CssClass="btn btn-primary" />
                                                                </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td class="td_Mitad">&nbsp;
                                                        </td>
                                                        <td class="td_Intermedio">
                                                            <asp:UpdatePanel ID="UpdatePanel_BtnRegresar_No_Probable" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:Button ID="BtnRegresar_No_Probable" runat="server" Text="Regresar - undo" CssClass="btn btn-primary"
                                                                        Visible="false" />
                                                                </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    </tr>
                                                </asp:Panel>



                                                <asp:Panel ID="pnl_P1C" Visible="false" runat="server">

                                                    <tr>
                                                        <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                        <td colspan="3">
                                                            <div class="text-center" style="color: #8F9E45; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                                                <strong>
                                                                    <em>¿Cuáles son las principales razones por las que usted considera que es muy probable
                                            o totalmente probable que recomiende a una persona amiga o conocida contratar los
                                            servicios de Claro? (TIPIFIQUE SOLO LOS COMENTARIOS ESPONTÁNEOS, HASTA TRES RESPUESTAS).
                                                                </strong>
                                                                </em>
                                                            </div>
                                                        </td>
                                                        <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    </tr>
                                                    <tr>
                                                        <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                        <td class="td_Intermedio">
                                                            <div class="input-group">
                                                                <div class="input-group-addon">
                                                                    Si probable
                                                                </div>
                                                                <asp:DropDownList ID="Drl_Razones_Pricipales_Si_Recomiende_Servicio" runat="server"
                                                                    CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </td>
                                                        <td class="td_Mitad">&nbsp;
                                                        </td>
                                                        <td class="td_Intermedio">
                                                            <div class="input-group">
                                                                <div class="input-group-addon">
                                                                    Opciones elegidas
                                                                </div>
                                                                <asp:UpdatePanel ID="UpdatePanel_Opciones_Si_Probale" runat="server">
                                                                    <ContentTemplate>
                                                                        <div style="background-color: inherit; overflow-y: auto; height: 80px" class="form-control">
                                                                            <asp:Label ID="LblSi_Probable_Valor1" runat="server" Visible="false"></asp:Label>
                                                                            <asp:Label ID="LblSi_Probable1" runat="server"></asp:Label><br />
                                                                            <asp:Label ID="LblSi_Probable_Valor2" runat="server" Visible="false"></asp:Label>
                                                                            <asp:Label ID="LblSi_Probable2" runat="server"></asp:Label><br />
                                                                            <asp:Label ID="LblSi_Probable_Valor3" runat="server" Visible="false"></asp:Label>
                                                                            <asp:Label ID="LblSi_Probable3" runat="server"></asp:Label>
                                                                        </div>
                                                                    </ContentTemplate>
                                                                </asp:UpdatePanel>
                                                            </div>
                                                        </td>
                                                        <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    </tr>
                                                    <tr>
                                                        <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                        <td class="td_Intermedio">
                                                            <asp:UpdatePanel ID="UpdatePanel_BtnAgregar_Si_Probable" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:Button ID="BtnAgregar_Si_Probable" runat="server" Text="Agregar" CssClass="btn btn-primary" />
                                                                </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <td class="td_Mitad">&nbsp;
                                                        </td>
                                                        <td class="td_Intermedio">
                                                            <asp:UpdatePanel ID="UpdatePanel_BtnRegresar_Si_Probable" runat="server">
                                                                <ContentTemplate>
                                                                    <asp:Button ID="BtnRegresar_Si_Probable" runat="server" Text="Regresar - undo" CssClass="btn btn-primary"
                                                                        Visible="false" />
                                                                </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                        </td>
                                                        <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    </tr>

                                                </asp:Panel>

                                                <tr>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td class="td_Intermedio">&nbsp;
                                                    </td>
                                                    <td class="td_Mitad">&nbsp;
                                                    </td>
                                                    <td class="td_Intermedio">&nbsp;
                                                    </td>
                                                    <%--<td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%--<td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td colspan="3">
                                                        <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                                            <center><strong>SERVICIO: VOZ</strong>  </center>
                                                        </div>
                                                    </td>
                                                    <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>



                                                    <td colspan="3" style="width: 55%">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                6. Utilizando una escala de 1 a 10, donde 1 significa extremadamente insatisfecho(a)
                                            y 10
                                            <br />
                                                                significa extremadamente satisfecho(a), ¿Qué tan satisfecho está con el servicio
                                            de VOZ de Claro?
                                                            </div>
                                                            <div style="background-color: inherit; height: 45px" class="form-control">
                                                                <asp:DropDownList ID="DrlQue_Tan_Satisfecho_Con_Servicio_Voz" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                El establecimiento de llamadas
                                            <br />
                                                                (es decir, que no es necesario
                                            <br />
                                                                volver a marcar o esperar un tiempo
                                            <br />
                                                                largo para que se inicie la llamada)
                                                            </div>
                                                            <div style="background-color: inherit; overflow-y: auto; height: 80px" class="form-control">
                                                                <asp:DropDownList ID="DrlEstablecimiento_Llamadas" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td class="td_Mitad">&nbsp;
                                                    </td>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Continuidad de las llamadas (es
                                            <br />
                                                                decir, que puede terminar y colgar
                                            <br />
                                                                sin que la llamada se caiga)
                                                            </div>
                                                            <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                                                <asp:DropDownList ID="DrlContinuidad_Llamadas" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%--<td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Claridad de las llamadas (es
                                            <br />
                                                                decir, es fácil entender a la
                                            <br />
                                                                otra persona sin interferencias
                                            <br />
                                                                de ruido, eco o momentos mudos)
                                                            </div>
                                                            <div style="background-color: inherit; overflow-y: auto; height: 80px" class="form-control">
                                                                <asp:DropDownList ID="DrlClaridad_Llamadas" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td class="td_Mitad">&nbsp;
                                                    </td>
                                                    <td class="td_Intermedio">&nbsp;
                                                    </td>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td colspan="3">
                                                        <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                                            <center><strong>SERVICIO: DATOS</strong> </center>
                                                        </div>
                                                    </td>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%--<td class="td_Externo">
                                </td>--%>
                                                    <td colspan="3" style="width: 55%">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                10. Utilizando una escala de 1 a 10, donde 1 significa extremadamente insatisfecho(a)
                                            y 10
                                            <br />
                                                                significa extremadamente satisfecho(a), ¿Qué tan satisfecho está con el servicio
                                            de DATOS de Claro?
                                                            </div>
                                                            <div style="background-color: inherit; height: 45px" class="form-control">
                                                                <asp:DropDownList ID="DrlQue_Tan_Satisfecho_Con_Servicio_Datos" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <%--<td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                La accesibilidad del servicio de
                                            <br />
                                                                datos, es decir, puede abrir páginas
                                            <br />
                                                                de Internet cuando lo necesita
                                                            </div>
                                                            <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                                                <asp:DropDownList ID="DrlAccesibilidad_Servicio_Datos" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td class="td_Mitad">&nbsp;
                                                    </td>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                La capacidad de retención del servicio
                                            <br />
                                                                de datos, es decir, la conexión de datos
                                            <br />
                                                                no se cae mientras se usa y no es
                                            <br />
                                                                necesario volver a conectarse
                                                            </div>
                                                            <div style="background-color: inherit; overflow-y: auto; height: 80px" class="form-control">
                                                                <asp:DropDownList ID="DrlCapacidad_Retencion_Servicio_Datos" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                La velocidad de navegación del servicio
                                            <br />
                                                                de datos, es decir, que puede usar el
                                            <br />
                                                                servicio tan rápido como lo permite el
                                            <br />
                                                                equipo, sin lentitud y sin que el equipo
                                            <br />
                                                                deje de responder.
                                                            </div>
                                                            <div style="background-color: inherit; overflow-y: auto; height: 90px" class="form-control">
                                                                <asp:DropDownList ID="DrlVelocidad_Navegacion_Servicio_Datos" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td class="td_Mitad">&nbsp;
                                                    </td>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                El envío y recepción de los
                                            <br />
                                                                correos electrónicos
                                                            </div>
                                                            <div style="background-color: inherit; height: 45px" class="form-control">
                                                                <asp:DropDownList ID="DrlEnvio_Recepcion_Correos_Electronicos" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <%--   <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                El envío y recepción de mensajes
                                            <br />
                                                                a través de whatsapp, twitter,
                                            <br />
                                                                facebook o line
                                                            </div>
                                                            <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                                                <asp:DropDownList ID="DrlEnvio_Recepcion_Mensajes_ATraves_Whatsapp_Twitter_Facebook_Line"
                                                                    runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td class="td_Mitad">&nbsp;
                                                    </td>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                Subir y descargar imágenes o videos
                                            <br />
                                                                a través de youtube, instagram,
                                            <br />
                                                                snapchat y otras redes sociales
                                                            </div>
                                                            <div style="background-color: inherit; overflow-y: auto; height: 60px" class="form-control">
                                                                <asp:DropDownList ID="DrlSubir_Descargar_Imagenes_Videos_ATraves_Youtube_Instagram_Snapchat_Otras_Redes_Sociales"
                                                                    runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                                <tr>
                                                    <%-- <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                    <td class="td_Intermedio">
                                                        <div class="input-group">
                                                            <div class="input-group-addon">
                                                                El tiempo de espera para abrir
                                            <br />
                                                                su página favorita de internet.
                                                            </div>
                                                            <div style="background-color: inherit; height: 45px" class="form-control">
                                                                <asp:DropDownList ID="DrlTiempo_Espera_Para_Abrir_Pagina_Favorita_Internet" runat="server"
                                                                    CssClass="form-control">
                                                                    <asp:ListItem Value="- Seleccione -">- Seleccione -</asp:ListItem>
                                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                                    <asp:ListItem Value="0">NS/NR</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td class="td_Mitad">&nbsp;
                                                    </td>
                                                    <td class="td_Intermedio">&nbsp;
                                                    </td>
                                                    <%--  <td class="td_Externo">
                                    &nbsp;
                                </td>--%>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <%-- Fin Encuetas Larga --%>
                        <tr>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">&nbsp;
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">&nbsp;
                            </td>
                            <%-- <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                        <tr>
                            <%--  <td class="td_Externo">
                            &nbsp;
                        </td>--%>
                            <td class="td_Intermedio">&nbsp;
                            </td>
                            <td class="td_Mitad">&nbsp;
                            </td>
                            <td class="td_Intermedio">&nbsp;
                            </td>
                            <%--<td class="td_Externo">
                            &nbsp;
                        </td>--%>
                        </tr>
                    </table>
                </td>
                <td class="celdasder">
                    <%-- <asp:GridView ID="dtgprog" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5" Width="62%"
                    Style="font-size: x-small">
                    <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="Id_Caso" HeaderText="Caso" />
                        <asp:BoundField DataField="min_ac" HeaderText="Min" />
                        <asp:BoundField DataField="FC_REG_ASIGNA" HeaderText="Fecha Asignado" />
                    </Columns>
                    <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                </asp:GridView>--%>
                </td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent_Bootstrap">
                    <h4><em style="color: #8F9E45">Consulta Seguimientos :</em>
                        <asp:Label ID="lblcuenta" runat="server" ForeColor="#8F9E45"></asp:Label></h4>
                </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent_Bootstrap">
                    <div class="bordes">
                        <asp:GridView ID="dtggeneral" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="80" Width="100%"
                            Style="font-size: x-small" EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="Id_CRM_Falla_Desactivacion_D_V" HeaderText="ID" />
                                <asp:BoundField DataField="Id_Bandeja_Falla_Desactivacion_D_V" HeaderText="Caso" />
                                <asp:BoundField DataField="Id_Caso" HeaderText="Caso Claro" />
                                <asp:BoundField DataField="Min" HeaderText="Min" />
                                <asp:BoundField DataField="Fc_Reg_Ges" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="Id_Usuario" HeaderText="Agente" />
                                <asp:BoundField DataField="obs" HeaderText="Observación" />
                                <asp:BoundField DataField="Tipo_Soporte" HeaderText="Tipo Soporte" />
                                <asp:BoundField DataField="Tipificacion" HeaderText="Tipificación" />
                                <asp:BoundField DataField="Falla_Red" HeaderText="Falla de Red" />
                                <asp:BoundField DataField="Fc_Programado" HeaderText="Fecha Programado" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                    </div>
                </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
            <tr>
                <td class="celdasder">&nbsp;
                </td>
                <td class="celdascent_Bootstrap">&nbsp;
                </td>
                <td class="celdasder">&nbsp;
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
