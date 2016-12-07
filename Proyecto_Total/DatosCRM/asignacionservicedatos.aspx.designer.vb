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


Partial Public Class asignacionservicedatos

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
    '''Control Lbl_Mensage.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Lbl_Mensage As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control Drl_Agent.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Agent As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control lblcantidadtot.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblcantidadtot As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control drl_causal_escalamiento_service.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drl_causal_escalamiento_service As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Btn_Cons_Cas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Cons_Cas As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Btn_Asig_Cas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Asig_Cas As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Btn_Expor_Cas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Expor_Cas As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control CV_Txb_Cod_Cas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_Txb_Cod_Cas As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control Txb_Cod_Cas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txb_Cod_Cas As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control CV_Txb_Num_Cas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_Txb_Num_Cas As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control Txb_Num_Cas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txb_Num_Cas As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control CV_Txb_Fech_Ini.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_Txb_Fech_Ini As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control Txb_Fech_Ini.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txb_Fech_Ini As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control CV_Txb_Fech_Fin.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_Txb_Fech_Fin As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control Txb_Fech_Fin.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txb_Fech_Fin As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control GV_Agen_Casos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GV_Agen_Casos As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control Pnl_Grid_Casos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Pnl_Grid_Casos As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control Label1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Label1 As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lblcantidad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblcantidad As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control dtggeneral.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtggeneral As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control RFV_Drl_Agent_Dev.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RFV_Drl_Agent_Dev As Global.System.Web.UI.WebControls.RequiredFieldValidator

    '''<summary>
    '''Control Drl_Agent_Dev.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Drl_Agent_Dev As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control Lbl_Cas_Dev.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Lbl_Cas_Dev As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control Btn_Cons_Cas_Dev.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Btn_Cons_Cas_Dev As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control CV_Txb_Num_Cas_Dev.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CV_Txb_Num_Cas_Dev As Global.System.Web.UI.WebControls.CompareValidator

    '''<summary>
    '''Control Txb_Num_Cas_Dev.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txb_Num_Cas_Dev As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Txb_Fech_Ini_Dev.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txb_Fech_Ini_Dev As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control Txb_Fech_Fin_Dev.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txb_Fech_Fin_Dev As Global.System.Web.UI.WebControls.TextBox
End Class
