<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Activo_Inventario.aspx.vb" Inherits="digitacion.cambiestilo" %>


<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP Kamilion -Registro Inventario 
    </title>
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
    <script type="text/jscript">
        $(function () {
            $("#txtfcingn3").datepicker({ dateFormat: 'dd/mm/yy' }).val();
        });
    </script>
    <!-- Fin Script jQuery Datepicker --->
    <style type="text/css">
        ::-webkit-scrollbar {
            width: 14px;    
        }
        ::-webkit-scrollbar-button {
            background-color:#B3C556;
            border-radius: 5px;
	        background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%,
											          transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%,
											          transparent 75%,/*SD*/transparent)
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
	        background-image: -webkit-linear-gradient(45deg,rgba(255, 255, 255, .2) 25%,transparent 25%,
											          transparent 50%,rgba(255, 255, 255, .2) 50%,rgba(255, 255, 255, .2) 75%,
											          transparent 75%,/*SD*/transparent)
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
       ::-moz-selection {background: #B3C556;
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
            /*border: 1px solid black;*/
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

        .celdascent {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }



        .style2 {
            width: 100%;
        }
        /* .textotittabla
{
	font-family: Arial, Helvetica, sans-serif;
	font-size:small;
	color: #000042;
	font-weight: bold;
	background: #E2E8FA;
	width: 9%;
}*/

        .celdascons {
            width: 35%;
        }

        .celdascons {
            width: 35%;
        }

        .style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: Navy;
            font-weight: bold;
            width: 80%;
        }

        .style5 {
            width: 80%;
        }
       
        .linkbutton
        {
          color: #B3C556;
          text-decoration:none ;


        }
        .linkbutton:hover
        {
            color: #555555;
            text-decoration:solid;
            text-decoration-color: #fff; 
        }
        #form1 {
            height: 5px;
        }
       
        </style>
 </head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table style="width: 100%; height: 100%">
                <tr>
                    <td class="celdasder"></td>
                    <td class="celdascent">
                        <table style="width: 100%">
                            <tr>
                                <td align="left" style="width: 90%">
                                    <h1 class="text-center" style="font-family: FuenteKamilion"><span class="titulo" style="font-size: 110%">Kamilion Comunicaciones ERP</span></h1>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="celdasder"></td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="style4">
                        <uc1:menu ID="menu" runat="server" />
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="style4">
                        <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Registro  Inventario Activos</em></h4></asp:Label>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder"></td>
                    <td valign="top" class="style5">
                        <table class="style2">
                            <tr>
                                <td style="width: 30%">
                                    <asp:Label ID="lblusuario" runat="server"></asp:Label>
                                </td>
                                <td style="width: 70%">
                                    <asp:Label ID="lblnombreusu" runat="server"></asp:Label>
                                    &nbsp;&nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#009933"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label><asp:Label ID="LblSupervisor" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="celdasder"></td>
                </tr>
                <tr>
                    <td class="celdasder">&nbsp;</td>
                    <td class="style4">
                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                            <ContentTemplate>
                                <span class="alert alert-danger">
                                    <asp:Label ID="lblmsg" runat="server" Style="color: #843534"></asp:Label>
                                </span>
                                <br />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                    <td class="celdasder">&nbsp;</td>
                </tr>
                <tr>
                    <td class="celdasder">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" Style="color: #8F9E45" />
                    </td>
                    <td class="textotittabla">
                        <table cellpadding="1" cellspacing="1" width="100%">
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>
                                            <center>Registro Activos</center>
                                        </strong>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Clasificacion
                                            </div>
                                            <asp:DropDownList ID="drlclasificacion" runat="server" AutoPostBack="True" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Activo
                                            </div>
                                            <asp:DropDownList ID="drlNombreActivo" runat="server" CssClass="form-control">
                                                <asp:ListItem>- Seleccione -</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Serial
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                <ContentTemplate>
                                                    <asp:TextBox ID="TxtSerialActivo" runat="server" placeholder="152405XX0001" CssClass="form-control" MaxLength="12"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    <asp:RegularExpressionValidator ID="regularexpression8" runat="server" ControlToValidate="TxtSerialActivo" ErrorMessage="La estructura del serial es:PUC+sigla+0001" Operator="DataTypeCheck" Type="Double" ValidationExpression="(\d{6})(\D{2}\d{4})?">*</asp:RegularExpressionValidator>
                                </td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Sede
                                            </div>
                                            <asp:DropDownList ID="drlSedeActivo" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Zona
                                            </div>
                                            <asp:DropDownList ID="drlZonaActivo" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">



                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Marca
                                            </div>
                                            <asp:DropDownList ID="drlMarcaActivo" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>



                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Referencia
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                                                <ContentTemplate>
                                                    <asp:TextBox ID="TxtReferenciaActivo" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Descripcion
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                                <ContentTemplate>
                                                    <asp:TextBox ID="TxtDescripcionActivo" runat="server" CssClass="form-control"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Responsable
                                            </div>
                                            <asp:DropDownList ID="drlresponsable" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Usuario
                                            </div>
                                            <asp:DropDownList ID="drlsubResponsable" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>

                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Estado
                                            </div>

                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="drlEstadoActivo" runat="server" CssClass="form-control" AutoPostBack="True">
                                                    </asp:DropDownList>
                                                    <asp:Panel ID="Panel3" runat="server" Style="width: 100%" Visible="False">
                                                        <div>
                                                            <div class="input-group">
                                                                <div class="input-group-addon">
                                                                    N° Acta
                                                                </div>
                                                                <asp:TextBox ID="TxtN_Acta" runat="server" Width=" 100%" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </asp:Panel>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">
                                    <asp:RegularExpressionValidator ID="regularexpression9" runat="server" ControlToValidate="TxtN_Acta" Operator="DataTypeCheck" Type="Double" ValidationExpression="[0-9]*$" ErrorMessage="Campo numerico">*</asp:RegularExpressionValidator>
                                </td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">

                                    <asp:Button ID="btnRegistrarActivo" runat="server" Text="Registrar"
                                        CssClass="btn btn-primary" />

                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>
                                            <center>Carga Masiva Activos</center>
                                        </strong>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">

                                    <asp:FileUpload ID="FileUpload1" CssClass="btn btn-primary" Style="width: 98%" runat="server" />
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">

                                    <asp:Button ID="btnRegistrarActivo0" runat="server" CssClass="btn btn-primary" Text="Guardar" />

                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>
                                            <center>&nbsp;<strong>Nuevos Registros</center>
                                        </strong>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Nombre
                                            </div>
                                            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" MaxLength="30"></asp:TextBox>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 5%">
                                    <asp:RegularExpressionValidator ID="regularexpression7" runat="server" ControlToValidate="TxtNombre" Operator="DataTypeCheck" Type="Double" ValidationExpression="[a-ñ-zA-Ñ-Z ]*$">*</asp:RegularExpressionValidator>
                                </td>
                                <td style="width: 25%">

                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Pertenece
                                            </div>
                                            <asp:DropDownList ID="drlPertenece" runat="server" AutoPostBack="True" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>

                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2"></td>
                                <td class="auto-style3">

                                    <asp:Panel ID="Panel1" runat="server" Style="width: 100%" Visible="False">
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Clasificacion
                                            </div>
                                            <asp:DropDownList ID="drlclasificacion0" runat="server" CssClass="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </asp:Panel>

                                </td>
                                <td class="auto-style4"></td>
                                <td class="auto-style3">

                                    <asp:Button ID="btnRegistrarNuevo" runat="server" Text="Guardar"
                                        CssClass="btn btn-primary" />

                                </td>
                                <td class="auto-style2"></td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td colspan="3">
                                    <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                                        <strong>
                                            <center>Consultas</center>
                                        </strong>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">&nbsp;</td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                        &nbsp;</td>
                    <td style="width: 25%">

                        <div class="input-group">
                            <div class="input-group-addon">
                                <asp:RadioButton ID="RdbSeriall" runat="server" GroupName="seleccion" Text="Serial" />
                            </div>
                            <asp:TextBox ID="TxtSerialConsulta" runat="server" placeholder="152405XX0001" CssClass="form-control" MaxLength="12"></asp:TextBox>
                        </div>
                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbZona" runat="server" GroupName="seleccion" Text="Zona" />
                                </div>
                                <asp:DropDownList ID="drlZona" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </td>
                    <td style="width: 9%">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 9%">&nbsp;</td>

                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="Rdbresponsable" runat="server" GroupName="seleccion" Text="Responsable" />
                                </div>
                                <asp:DropDownList ID="drlresponsable0" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>

                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="Rdbcodres" runat="server" GroupName="seleccion" Text="Cod Responsable" />
                                </div>
                                <asp:DropDownList ID="drlcodresponsable" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </td>
                    <td style="width: 9%">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbClasificacion" runat="server" GroupName="seleccion" Text="Clasificacion" />
                                </div>
                                <asp:DropDownList ID="drlclasificacionconsulta" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbActivo" runat="server" GroupName="seleccion" Text="Activo" />
                                </div>
                                <asp:DropDownList ID="drlNombreActivo0" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </td>
                    <td style="width: 9%">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%">

                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="Rdbmarca" runat="server" GroupName="seleccion" Text="Marca" />
                                </div>
                                <asp:DropDownList ID="drlMarca" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>

                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    Referencia
                                </div>
                                <asp:DropDownList ID="drlReferencia" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </td>
                    <td style="width: 9%">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="Rdbsub_responsable" runat="server" GroupName="seleccion" Text="Usuario" />
                                </div>
                                <asp:DropDownList ID="drlsub_responsable" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>

                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbN_ActaC" runat="server" GroupName="seleccion" Text="N° Acta" />
                                </div>
                                <asp:TextBox ID="TxtN_ActaC" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                            </div>
                        </div>

                    </td>
                    <td style="width: 9%">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%">

                        <asp:Button ID="btnConsultarActivo" runat="server" Text="Buscar"
                            CssClass="btn btn-primary" />
                        &nbsp;<asp:Button ID="btnExportarActivo" runat="server" Text="Exportar"
                            CssClass="btn btn-primary" Visible="False" />

                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">&nbsp;</td>
                    <td style="width: 9%">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="5">
                        <h4><em style="color: #8F9E45">Numero Registros inventario :</em>
                            <asp:Label ID="LblN_Registros" runat="server" ForeColor="#8F9E45"></asp:Label></h4>
                        <div class="bordes">
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="dtgInvt" runat="server" AllowPaging="True"
                                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                                        GridLines="None" PageSize="40" Width="100%" Style="font-size: x-small"
                                        EnableModelValidation="True">
                                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                                        <Columns>
                                            <asp:BoundField DataField="cod_inventario_activos" HeaderText="Codigo inventario" />
                                            <asp:BoundField DataField="Nombre_activo" HeaderText="Activo" />
                                            <asp:BoundField DataField="serial" HeaderText="Serial" />
                                            <asp:BoundField DataField="sigla" HeaderText="Sigla" />
                                            <asp:BoundField DataField="marca" HeaderText="Marca" />
                                            <asp:BoundField DataField="referencia" HeaderText="Referencia" />
                                            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                                            <asp:BoundField DataField="sede" HeaderText="Sede" />
                                            <asp:BoundField DataField="responsable" HeaderText="Responsable" />
                                            <asp:BoundField DataField="Sub_responsable" HeaderText="Usuario" />
                                            <asp:BoundField DataField="usu_registra" HeaderText="Usu Registra" />
                                            <asp:BoundField DataField="fc_reg" HeaderText="Fecha Registro" />
                                            <asp:BoundField DataField="No_Acta_baja" HeaderText="N° Acta"></asp:BoundField>
                                        </Columns>
                                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                                    </asp:GridView>


                                    </div>
                        <asp:GridView ID="dtgxls" runat="server"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="cod_inventario_activos" HeaderText="Codigo inventario" />
                                <asp:BoundField DataField="Nombre_activo" HeaderText="Activo" />
                                <asp:BoundField DataField="serial" HeaderText="Serial" />
                                <asp:BoundField DataField="sigla" HeaderText="Sigla" />
                                <asp:BoundField DataField="referencia" HeaderText="Referencia" />
                                <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                                <asp:BoundField DataField="sede" HeaderText="Sede" />
                                <asp:BoundField DataField="estado" HeaderText="Estado" />
                                <asp:BoundField DataField="responsable" HeaderText="Responsable" />
                                <asp:BoundField DataField="usu_registra" HeaderText="Usu Registra" />
                                <asp:BoundField DataField="fc_reg" HeaderText="Fecha Registro" />
                                <asp:BoundField DataField="marca" HeaderText="Marca" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                                    <br />
                                    <br />
                                    <br />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                    </td>

                </tr>

                <tr>
                    <td colspan="5">&nbsp;</td>

                </tr>

                <tr>
                    <td colspan="5">&nbsp;</td>

                </tr>

            </table>
        </div>
    </form>
    <br />
    <br />

</body>
</html>
