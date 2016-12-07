<%@ Page Language="vb"  Debug="true" AutoEventWireup="false" CodeBehind="Activo_inventario_Cambio.aspx.vb" Inherits="digitacion.Cambio" %>

<%@ Register Src="~/Controles/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERP Kamilion - Activos inventario cambio
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
        .auto-style1 {
            width: 5%;
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
                        <asp:Label ID="Label1" runat="server" ForeColor="#8F9E45"><h4><em>Cambios  Inventario Activos </em></h4></asp:Label>
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
         <asp:Label ID="lblnombreusu" runat="server"></asp:Label> &nbsp;&nbsp;<asp:Label ID="LblPerfil" runat="server" Font-Size="X-Large" ForeColor="#009933"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LblSuperVisorTitulo" runat="server" Text="Supervisor: "></asp:Label><asp:Label ID="LblSupervisor" runat="server"></asp:Label>
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
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" style="color:#8F9E45"/>
                  </td>
                  <td class="textotittabla">
                     <table cellpadding="1" cellspacing="1" width="100%">
                         <tr>
                    <td style="width: 9%">&nbsp;</td>
                  <td colspan="3">
               <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
            <strong>
         <center>Cambios Activos</center>
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
                                                Codigo Inventario
                                            </div>
                                            <asp:Label ID="Lblcodigocambio" runat="server" CssClass="form-control" style="background-color: inherit"></asp:Label>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Serial
                                            </div>
                                            <asp:Label ID="Lblserialcambio" runat="server" CssClass="form-control" style="background-color: inherit"></asp:Label>
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
                                                Sede
                                            </div>
                                            <asp:DropDownList ID="DrlSede" runat="server" CssClass="form-control" Enabled="False">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    
                                </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%">


                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Zona
                                            </div>
                                            <asp:DropDownList ID="DrlZona" runat="server" CssClass="form-control" Enabled="False"></asp:DropDownList>
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
                                            <asp:DropDownList ID="drlresponsable" runat="server" CssClass="form-control" Enabled="False">
                                            </asp:DropDownList>
                                        </div>
                                    </div>

                                    </td>
                                <td style="width: 5%">&nbsp;</td>
                                <td style="width: 25%"><div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Usuario
                                            </div>
                                            <asp:DropDownList ID="DrlSubresponsable" runat="server" CssClass="form-control" Enabled="False">
                                            </asp:DropDownList>
                                        </div>
                                    </div></td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                            <tr>
                                <td style="width: 9%">&nbsp;</td>
                                <td style="width: 25%">
                                    <div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Descripcion
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                                <ContentTemplate>
                                                    <asp:TextBox ID="TxtDescripcionActivo" runat="server" CssClass="form-control" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
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
                                                Observacion
                                            </div>
                                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                <ContentTemplate>
                                                    <asp:TextBox ID="TxtObservacion" runat="server" CssClass="form-control" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 9%">&nbsp;</td>
                            </tr>

                          <tr>
                           <td style="width: 9%">&nbsp;</td>
                             <td style="width: 25%"><div>
                                        <div class="input-group">
                                            <div class="input-group-addon">
                                                Estado
                                            </div>
                                            <asp:DropDownList ID="DrlEstado3" runat="server" CssClass="form-control" Enabled="False" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </div>
                                    </div></td>
                               <td style="width: 5%">&nbsp;</td>
                              <td style="width: 25%">
                                   <asp:Panel ID="Panel1" runat="server" style="width: 100%" Visible="False"><div>
                                  <div>
                                      <div class="input-group">
                                          <div class="input-group-addon">
                                              N° Acta
                                          </div>
                                          <asp:TextBox ID="TxtN_Acta" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="10" ReadOnly="True"></asp:TextBox>
                                      </div>
                                  </div>
                                       </asp:Panel>
                              </td>
                           <td style="width: 9%">
                        <asp:RegularExpressionValidator ID="regularexpression9" runat="server" ControlToValidate="TxtN_Acta" Operator="DataTypeCheck" Type="Double" ValidationExpression="[0-9]*$" ErrorMessage="Campo numerico">*</asp:RegularExpressionValidator>
                              </td>
                         </tr>

                          <td style="width: 9%">
                           
                         </td>

                        </td>
                    <td style="width: 25%">

                        <asp:Button ID="BtCambiarEstado1" runat="server" Text="Cambiar"
                            CssClass="btn btn-primary" />

                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%"></td>
                    <td style="width: 9%">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%"></td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">&nbsp;</td>
                    <td style="width: 9%">&nbsp;</td>
                </tr>

                         <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td colspan="3">
                        <div class="text-center" style="background-color: #B3C556; color: white; border-radius: 5px; padding: 0.5px 0px 1px 0px">
                            <strong>
                                <center>Actualizacion Masiva</center>
                            </strong>
                        </div>
                    </td>
                    <td style="width: 9%">&nbsp;</td>
                         </tr>
                         <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%"></td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">&nbsp;</td>
                    <td style="width: 9%">&nbsp;</td>
                         </tr>
                         <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%">

                                           <asp:FileUpload ID="FileUpload1"  CssClass="btn btn-primary" style="width: 98%" runat="server" />
                    </td>
                    <td style="width: 5%">
                        &nbsp;</td>
                    <td style="width: 25%">
                                    
                                            <asp:Button ID="btnActualizar" runat="server" CssClass="btn btn-primary" Text="Actualizar" />
                                       
                    </td>
                    <td style="width: 9%">&nbsp;</td>
                         </tr>
                         <tr>
                        <td colspan="5">
                        <asp:GridView ID="dtgUpdate" runat="server"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True" Visible="False">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                             
                                <asp:BoundField DataField="cod_inventario_activos" HeaderText="Codigo inventario" />
                                <asp:BoundField DataField="estado" HeaderText="Estado" />
                                <asp:BoundField DataField="Sede" HeaderText="Sede" />
                                <asp:BoundField DataField="zona" HeaderText="Zona" />
                                <asp:BoundField DataField="Responsable" HeaderText="Responsable" />
                                <asp:BoundField DataField="Sub_Responsable" HeaderText="Usuario" />
                                <asp:BoundField DataField="No_Acta_Baja" HeaderText="N° Acta" />
                                <asp:BoundField DataField="fecha_cambio" HeaderText="Fecha Cambio" />
                                <asp:BoundField DataField="id_usuario" HeaderText="Usuario Reg " />
                                <asp:BoundField DataField="Observacion" HeaderText="Observacion" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"  />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                             </td>
                         </tr>
                         <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%"></td>
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
                    <td style="width: 25%">

                        <div class="input-group">
                            <div class="input-group-addon">
                                <asp:RadioButton ID="RdbSerial" runat="server" GroupName="seleccion" Text="Serial" />
                            </div>
                            <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                                <ContentTemplate>
                                    <asp:TextBox ID="TxtSerialConsulta" runat="server" placeholder = "152405XX0001" CssClass="form-control" MaxLength="12"></asp:TextBox>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </td>
                    <td style="width: 5%">
                        <asp:RegularExpressionValidator ID="regularexpression7" runat="server" ControlToValidate="TxtSerialConsulta" ErrorMessage="La estructura del serial es:PUC+sigla+0001" Operator="DataTypeCheck" Type="Double" ValidationExpression="(\d{6})(\D{2}\d{4})?">*</asp:RegularExpressionValidator>
                    </td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="RdbCod0" runat="server" GroupName="seleccion" Text="Cod Inventario" />
                                </div>
                                <asp:TextBox ID="txtCodInventario0" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
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
                                    <asp:RadioButton ID="RdbSede" runat="server" GroupName="seleccion" Text="Sede" />
                                </div>
                                <asp:DropDownList ID="DrlSede0" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>

                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">

                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <strong>Activo</strong>
                                </div>
                                <asp:DropDownList ID="DrlActivoC0" runat="server" CssClass="form-control">
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
                                    <asp:RadioButton ID="Rdbestado1" runat="server" GroupName="seleccion" Text="Estado" />
                                </div>
                                <asp:DropDownList ID="DrlEstadoC0" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>

                    </td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">
                        <div>
                            <div class="input-group">
                                <div class="input-group-addon">
                                    <asp:RadioButton ID="Rdbresponsable" runat="server" GroupName="seleccion" Text="Responsable" />
                                </div>
                                <asp:DropDownList ID="drlresponsable0" runat="server" CssClass="form-control">
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
                                    <asp:RadioButton ID="RdbN_Acta" runat="server" GroupName="seleccion" Text=" N° Acta" />
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
                               
                        <asp:Button ID="BtBuscarActivo0" runat="server" Text="Buscar"
                            CssClass="btn btn-primary" />
                                        &nbsp;<asp:Button ID="BtExportar" runat="server" Text="Exportar"
                            CssClass="btn btn-primary" Visible="False" />

                                        </td>
                               <td style="width: 5%">&nbsp;</td>
                              <td style="width: 25%">&nbsp;</td>
                           <td style="width: 9%">&nbsp;</td>
                         </tr>

                <tr>
                    <td style="width: 9%">&nbsp;</td>
                    <td style="width: 25%">

                        &nbsp;</td>
                    <td style="width: 5%">&nbsp;</td>
                    <td style="width: 25%">&nbsp;</td>
                   
                    <td style="width: 9%">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="5">
                        <h4><em style="color: #8F9E45">Numero&nbsp; de registros&nbsp; inventario :</em>
                            <asp:Label ID="LblN_Registros" runat="server" ForeColor="#8F9E45"></asp:Label></h4>
                        <div class="bordes">
                             
                        <asp:GridView ID="dtgInvt" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="40" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                             
                                <asp:ButtonField CommandName="Seleccione" HeaderText="Seleccione" Text="Seleccion" />
                             
                                <asp:BoundField DataField="cod_inventario_activos" HeaderText="Codigo inventario" />
                                <asp:BoundField DataField="serial" HeaderText="Serial" />
                                <asp:BoundField DataField="Nombre_Activo" HeaderText="Nombre activo" />
                                <asp:BoundField DataField="sigla" HeaderText="Sigla" />
                                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                                <asp:BoundField DataField="estado" HeaderText="Estado" />
                                <asp:BoundField DataField="No_Acta_baja" HeaderText="N° Acta" />
                                <asp:BoundField DataField="Sede" HeaderText="Sede" />
                                <asp:BoundField DataField="zona" HeaderText="Zona" />
                                <asp:BoundField DataField="Responsable" HeaderText="Responsable" />
                                <asp:BoundField DataField="Sub_Responsable" HeaderText="Usuario" />
                                <asp:BoundField DataField="usu_registra" HeaderText="Usuario  registra" />
                                <asp:BoundField DataField="fc_reg" HeaderText="Fecha registro" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"  />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                        <asp:GridView ID="dtgxls1" runat="server"
                            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                            GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                            EnableModelValidation="True">
                            <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                            <Columns>
                             
                                <asp:BoundField DataField="cod_inventario_activos" HeaderText="Codigo inventario" />
                                <asp:BoundField DataField="serial" HeaderText="Serial" />
                                <asp:BoundField DataField="Nombre_Activo" HeaderText="Nombre activo" />
                                <asp:BoundField DataField="sigla" HeaderText="Sigla" />
                                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                                <asp:BoundField DataField="estado" HeaderText="Estado" />
                                <asp:BoundField DataField="No_Acta_baja" HeaderText="N° Acta" />
                                <asp:BoundField DataField="Sede" HeaderText="Sede" />
                                <asp:BoundField DataField="zona" HeaderText="Zona" />
                                <asp:BoundField DataField="Responsable" HeaderText="Responsable" />
                                <asp:BoundField DataField="Sub_Responsable" HeaderText="Usuario" />
                                <asp:BoundField DataField="usu_registra" HeaderText="Usuario  registra" />
                                <asp:BoundField DataField="fc_reg" HeaderText="Fecha registro" />
                            </Columns>
                            <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"  />
                            <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                            <EditRowStyle BackColor="#999999" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                        </asp:GridView>
                                             
                   </div>
                       
                    </td>

                </tr>
              <tr>
                    <td colspan="5">
                         <h4><em style="color: #8F9E45">Numero&nbsp; de registros&nbsp; cambios inventario:</em>
                        <asp:Label ID="LblNregCambios" runat="server" ForeColor="#8F9E45"></asp:Label>
                    </h4>
                        <div class ="bordes">
                    <asp:GridView ID="dtgHistorial" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_inventario_Activos" HeaderText="Codigo inventario" />
                            <asp:BoundField DataField="serial" HeaderText="Serial" />
                            <asp:BoundField DataField="Nombre_activo" HeaderText="Activo" />
                            <asp:BoundField DataField="sedecambio" HeaderText="Sede" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="observacion_cambio" HeaderText="Observacion" />
                            <asp:BoundField DataField="responsable" HeaderText="Responsable" />
                            <asp:BoundField DataField="Sub_Responsable" HeaderText="Usuario" />
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario  Registra" />
                            <asp:BoundField DataField="Fecha_cambio" HeaderText="Fecha cambio" />
                        </Columns>
                        <FooterStyle BackColor="#B3C556" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#B3C556" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#B3C556" Font-Bold="False" ForeColor="White" Font-Size="Small" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#333333" />
                    </asp:GridView>
                    <asp:GridView ID="dtgxls2" runat="server"
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333"
                        GridLines="None" PageSize="80" Width="100%" Style="font-size: x-small"
                        EnableModelValidation="True">
                        <RowStyle BackColor="#EEF1D8" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField DataField="Cod_inventario_Activos" HeaderText="Codigo inventario" />
                            <asp:BoundField DataField="serial" HeaderText="Serial" />
                            <asp:BoundField DataField="Fecha_cambio" HeaderText="Fecha cambio" />
                            <asp:BoundField DataField="Nombre_activo" HeaderText="Activo" />
                            <asp:BoundField DataField="sedecambio" HeaderText="Sede" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="observacion_cambio" HeaderText="Observacion" />
                            <asp:BoundField DataField="responsable" HeaderText="Responsable" />
                            <asp:BoundField DataField="Id_Usuario" HeaderText="Usuario  Registra" />
                            <asp:BoundField DataField="Sub_Responsable" HeaderText="Usuario" />
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

                </tr>
                 </table>        
        </div>
     </form>
           <br />
          <br />
                        
</body>
</html>
