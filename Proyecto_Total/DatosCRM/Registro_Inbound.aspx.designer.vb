'------------------------------------------------------------------------------
' <generado automáticamente>
'     Este código fue generado por una herramienta.
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código. 
' </generado automáticamente>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class Registro_Inbound

    '''<summary>
    '''Control Header.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Header As Global.digitacion.Header

    '''<summary>
    '''Control Pnl_Message.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Pnl_Message As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control lblmsg.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblmsg As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txtcaso.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtcaso As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Span1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Span1 As Global.System.Web.UI.HtmlControls.HtmlGenericControl

    '''<summary>
    '''Control btn_buscar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_buscar As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Btn_caso_nuevo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_caso_nuevo As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Btn_Llamada_Corta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Llamada_Corta As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Panel_consulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_consulta As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control lbl_caso.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_caso As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_min_alterno.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_min_alterno As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_usuario_registra.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_usuario_registra As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_estado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_estado As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lbl_fecha_ingreso.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_fecha_ingreso As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control Panel_registro.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_registro As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control btn_guardar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_guardar As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Btn_rechazar_inb.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_rechazar_inb As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control RegularExpressionValidator1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RegularExpressionValidator1 As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''Control UpdatePanel9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel9 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control txt_IDAVAYA.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_IDAVAYA As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control UpdatePanel5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel5 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control txt_min.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_min As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control UpdatePanel_Marca.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Marca As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlmarca.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlmarca As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_Departamento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Departamento As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drldpto.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drldpto As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_Barrio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Barrio As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control txtbarrio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtbarrio As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control UpdatePanel_Condiciones_uso.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Condiciones_uso As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlFtectolog.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlFtectolog As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Btn_Habilita_Tecnologia.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Habilita_Tecnologia As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control UpdatePanel_campaña.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_campaña As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlcampaña.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlcampaña As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel6 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control Drl_Falla.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Falla As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel8.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel8 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control txt_nombre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_nombre As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control UpdatePanel18.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel18 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control txt_usu_reporta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_usu_reporta As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control UpdatePanel_Equipo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Equipo As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlequipo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlequipo As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Btn_Habilita_Equipo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Habilita_Equipo As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control UpdatePanel_Municipio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Municipio As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlmun.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlmun As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Btn_Habilita_Municipio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Habilita_Municipio As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control UpdatePanel_Fc_Utilma_Caida.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Fc_Utilma_Caida As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control CompareValidator9.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CompareValidator9 As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control txtultimc.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtultimc As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlfranja.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlfranja As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Btn_Habilita_Fc_Utl_Caida.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Habilita_Fc_Utl_Caida As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control UpdatePanel4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel4 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control CompareValidator1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CompareValidator1 As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control telefono.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents telefono As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''Control chkSi.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents chkSi As Global.System.Web.UI.WebControls.RadioButton

    '''<summary>
    '''Control chkNo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents chkNo As Global.System.Web.UI.WebControls.RadioButton

    '''<summary>
    '''Control txtnumalt.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtnumalt As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control UpdatePanel3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel3 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control CHKSD.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CHKSD As Global.System.Web.UI.WebControls.CheckBox

    '''<summary>
    '''Control txt_SD.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_SD As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Pnl_Fecha_Hora_Reg.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Pnl_Fecha_Hora_Reg As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control REV_Txt_Fecha_Hora_Reg.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents REV_Txt_Fecha_Hora_Reg As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''Control RFV_Txt_Fecha_Hora_Reg.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RFV_Txt_Fecha_Hora_Reg As Global.System.Web.UI.WebControls.RequiredFieldValidator

    '''<summary>
    '''Control Txt_Fecha_Hora_Reg.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_Fecha_Hora_Reg As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Panel_Rechazado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_Rechazado As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control CompareValidator4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CompareValidator4 As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control RegularExpressionValidator6.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RegularExpressionValidator6 As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''Control UpdatePanel14.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel14 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control txt_formato_recha.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_formato_recha As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control txt_fecha_Ult_Ges.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_fecha_Ult_Ges As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drl_nivel.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drl_nivel As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control drl_tipificacion_recha.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drl_tipificacion_recha As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control txt_fecha_caso_recha.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_fecha_caso_recha As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control txt_custcode_r.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_custcode_r As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drl_UbicacionCall.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drl_UbicacionCall As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control drl_inconsistencia_recha.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drl_inconsistencia_recha As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_Linea_Servicio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Linea_Servicio As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drllinea.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drllinea As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_Solicitud_Tipo_Falla.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Solicitud_Tipo_Falla As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlsolicitud.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlsolicitud As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_Segmento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Segmento As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlSegmento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlSegmento As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel10.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel10 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlservicio2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlservicio2 As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control drlModalidad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlModalidad As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_Causa_Raiz.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Causa_Raiz As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlCausa_Raiz.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlCausa_Raiz As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_Estado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Estado As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drltipificacionll.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drltipificacionll As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_PQR.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_PQR As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control CV_PQR.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_PQR As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control LblPQR.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblPQR As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control TxtPQR.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtPQR As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control lbl_formato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lbl_formato As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control RequiredFieldValidator1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RequiredFieldValidator1 As Global.System.Web.UI.WebControls.RequiredFieldValidator

    '''<summary>
    '''Control CompareValidator2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CompareValidator2 As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control RegularExpressionValidator3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RegularExpressionValidator3 As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''Control UpdatePanel13.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel13 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control txt_formato.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_formato As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control UpdatePanel_Categoria_Cierre_1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Categoria_Cierre_1 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlCategoriaCierre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlCategoriaCierre As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel17.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel17 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlTipo_PQR.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlTipo_PQR As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Btn_Habilita_PQR.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Habilita_PQR As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Panel_Justificacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_Justificacion As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control Drl_justificacion_seguimiento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_justificacion_seguimiento As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Panel_seguimiento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_seguimiento As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control txtfcprog.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtfcprog As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control UpdatePanel_inconsistencia.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_inconsistencia As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlinconsistencia.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlinconsistencia As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_obs_inconsistencia.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_obs_inconsistencia As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control txtobsincon.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtobsincon As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control txtobs.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtobs As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Panel_Falla_red.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_Falla_red As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control txtFcontacto.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtFcontacto As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlFtiempo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlFtiempo As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control drlFcaract.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlFcaract As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control txtFciudad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtFciudad As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control txtFdirecc.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtFdirecc As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Drl_Qos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Qos As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control txtfobs.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtfobs As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control CV_Txt_N_Doc_Id_CPD.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_Txt_N_Doc_Id_CPD As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control RFV_Txt_N_Doc_Id_CPD.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RFV_Txt_N_Doc_Id_CPD As Global.System.Web.UI.WebControls.RequiredFieldValidator

    '''<summary>
    '''Control Txt_N_Doc_Id_CPD.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_N_Doc_Id_CPD As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control txtFnum.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtFnum As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control txtFtipofalla.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtFtipofalla As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlFportada.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlFportada As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control rdbvc.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents rdbvc As Global.System.Web.UI.WebControls.RadioButtonList

    '''<summary>
    '''Control txtapn.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtapn As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlFlineasfalla.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlFlineasfalla As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Falla_Presenta_Luego_Construyera_Edificacion_Aledania As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel7 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control Drl_Tipo_Edificacion_Donde_Presenta_Falla_1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Tipo_Edificacion_Donde_Presenta_Falla_1 As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Tipo_Edificacion_Donde_Presenta_Falla_2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Tipo_Edificacion_Donde_Presenta_Falla_2 As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Tecnologia_Presenta_Falla_Luegodepruebas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Tecnologia_Presenta_Falla_Luegodepruebas As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Linea_No_Cuenta_Bloqueos_Internet.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Linea_No_Cuenta_Bloqueos_Internet As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Linea_No_Encuentra_Enrutada_PorPagos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Linea_No_Encuentra_Enrutada_PorPagos As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_No_Existen_Cambios_Administrativos_Sobre_Linea_Cuenta_Maestra As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Split_Billing.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Split_Billing As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Forza_Red_Dispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Forza_Red_Dispositivo As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Equipo_Encuentra_Homologado_Operador.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Equipo_Encuentra_Homologado_Operador As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Falla_Presenta_Luego_Remodelara_Estructura_Fisica_Edificio As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Validaciones_Falla_Masiva.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Validaciones_Falla_Masiva As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Txt_Validacion_Coordenadas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_Validacion_Coordenadas As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Drl_Linea_No_Superado_Limite_Consumos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Linea_No_Superado_Limite_Consumos As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_HLR_HSS.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_HLR_HSS As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Realizan_Pruebas_SIMCARD_OtroDispositivo_PersisteFalla As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Verifica_Realiza_Configuración_APN.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Verifica_Realiza_Configuración_APN As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Drl_Realiza_Conciliacion_Sobre_linea.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Realiza_Conciliacion_Sobre_linea As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel12.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel12 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control Panel_Service.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_Service As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control drlapn.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlapn As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control UpdatePanel_Variable_Diagnostico_2_drl.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Variable_Diagnostico_2_drl As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control drlvariable.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlvariable As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control drlqos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlqos As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control CompareValidator_fcactivacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CompareValidator_fcactivacion As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control txtfcactivacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtfcactivacion As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control UpdatePanel_Variable_Diagnostico_3_Lbl.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel_Variable_Diagnostico_3_Lbl As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control lblvariable.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblvariable As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control FileDocumento.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents FileDocumento As Global.System.Web.UI.WebControls.FileUpload

    '''<summary>
    '''Control Pnl_Llamada_Corta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Pnl_Llamada_Corta As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control RegularExpressionValidator5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RegularExpressionValidator5 As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''Control UpdatePanel11.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel11 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control Txt_Id_Avaya_Ll_Co.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_Id_Avaya_Ll_Co As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Pnl_Txt_Caso_ll_co.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Pnl_Txt_Caso_ll_co As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control CompareValidator3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CompareValidator3 As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control RegularExpressionValidator2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RegularExpressionValidator2 As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''Control Txt_Caso_ll_co.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_Caso_ll_co As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drl_ubicacion_call_ll_co.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drl_ubicacion_call_ll_co As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Btn_Guardar_Ll_Co.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Guardar_Ll_Co As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Drl_Tipo_llamada_ll_co.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Tipo_llamada_ll_co As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Txt_Obs_Ll_Co.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_Obs_Ll_Co As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control LinkButton3.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LinkButton3 As Global.System.Web.UI.WebControls.LinkButton

    '''<summary>
    '''Control LinkButton4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LinkButton4 As Global.System.Web.UI.WebControls.LinkButton

    '''<summary>
    '''Control Panel_inconsistencia.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_inconsistencia As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control RegularExpressionValidator4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RegularExpressionValidator4 As Global.System.Web.UI.WebControls.RegularExpressionValidator

    '''<summary>
    '''Control Txt_custcode.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_custcode As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlinconsglobal.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlinconsglobal As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control drlnivel.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlnivel As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Txt_usuario_reporta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_usuario_reporta As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlincons.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlincons As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control drl_ubicacion_call.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drl_ubicacion_call As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control txtobsinc.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtobsinc As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control btn_guarda_inc.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btn_guarda_inc As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Lbl_Cantidad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Lbl_Cantidad As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control Dtg_Asignados.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Dtg_Asignados As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control PanelCasos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PanelCasos As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control UpdatePanel15.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents UpdatePanel15 As Global.System.Web.UI.UpdatePanel

    '''<summary>
    '''Control dtggeneral.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtggeneral As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control dtgcoincidentes.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgcoincidentes As Global.System.Web.UI.WebControls.GridView
End Class
