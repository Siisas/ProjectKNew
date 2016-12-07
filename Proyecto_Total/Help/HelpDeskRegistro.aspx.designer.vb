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


Partial Public Class HelpDeskRegistro
    
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
    '''Control RFV_Drl_Calificacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RFV_Drl_Calificacion As Global.System.Web.UI.WebControls.RequiredFieldValidator
    
    '''<summary>
    '''Control Drl_Calificacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Calificacion As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control REV_Txb_Observacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents REV_Txb_Observacion As Global.System.Web.UI.WebControls.RegularExpressionValidator
    
    '''<summary>
    '''Control RFV_Txb_Observacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RFV_Txb_Observacion As Global.System.Web.UI.WebControls.RequiredFieldValidator
    
    '''<summary>
    '''Control Txb_Observacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txb_Observacion As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control Btn_Calificar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Calificar As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnNuevoTicket.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnNuevoTicket As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control BtnConsultaTicket.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnConsultaTicket As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control PanelRegistro.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PanelRegistro As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control TxtTema.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtTema As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlPrioridad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlPrioridad As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control drlLetraModulo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlLetraModulo As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control drlArea.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlArea As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control BtnEnviar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnEnviar As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control txtObservacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtObservacion As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlCanal.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlCanal As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtNumeroModulo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtNumeroModulo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtPersona_Reporta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtPersona_Reporta As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control PanelConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PanelConsulta As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control CV_TxtFecha_Inicio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_TxtFecha_Inicio As Global.System.Web.UI.WebControls.CompareValidator
    
    '''<summary>
    '''Control TxtFecha_Inicio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFecha_Inicio As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control CV_TxtCodTicket.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_TxtCodTicket As Global.System.Web.UI.WebControls.CompareValidator
    
    '''<summary>
    '''Control TxtCodTicket.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCodTicket As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control btnConsultaCaso.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btnConsultaCaso As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control CV_TxtFecha_Ini.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_TxtFecha_Ini As Global.System.Web.UI.WebControls.CompareValidator
    
    '''<summary>
    '''Control TxtFecha_Fin.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFecha_Fin As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control PanelConsulta2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PanelConsulta2 As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control Label7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Label7 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control lblCuentaTicket.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblCuentaTicket As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control dtgTicket.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgTicket As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control Label1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Label1 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control lblCuentaProceso.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblCuentaProceso As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control dtgProceso.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgProceso As Global.System.Web.UI.WebControls.GridView
End Class
