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


Partial Public Class ConsultaBoldChat
    
    '''<summary>
    '''Control header.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents header As Global.digitacion.Header
    
    '''<summary>
    '''Control pnl_message.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents pnl_message As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control lblmsg.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblmsg As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control txtmin.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtmin As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control txtcliente.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtcliente As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control comparevalidator1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents comparevalidator1 As Global.System.Web.UI.WebControls.CompareValidator
    
    '''<summary>
    '''Control comparevalidator2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents comparevalidator2 As Global.System.Web.UI.WebControls.CompareValidator
    
    '''<summary>
    '''Control txtfecha_inicio_recepcion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtfecha_inicio_recepcion As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtFecha_Fin_Recepcion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFecha_Fin_Recepcion As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control Button1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Button1 As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control btnxls.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btnxls As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control txtcaso.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtcaso As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drltipificacionll.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drltipificacionll As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control CompareValidator5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CompareValidator5 As Global.System.Web.UI.WebControls.CompareValidator
    
    '''<summary>
    '''Control CompareValidator4.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents CompareValidator4 As Global.System.Web.UI.WebControls.CompareValidator
    
    '''<summary>
    '''Control txtfecha_inicio_gestion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtfecha_inicio_gestion As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtFecha_Fin_Gestion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFecha_Fin_Gestion As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control PanelDatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PanelDatos As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control LinkBtnDatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LinkBtnDatos As Global.System.Web.UI.WebControls.LinkButton
    
    '''<summary>
    '''Control lblCuentaDatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblCuentaDatos As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control PanelVoz.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PanelVoz As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control LinkBtnVoz.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LinkBtnVoz As Global.System.Web.UI.WebControls.LinkButton
    
    '''<summary>
    '''Control lblCuentaVoz.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblCuentaVoz As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control PanelGeneral.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PanelGeneral As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control LinkBtnInfBoldChat.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LinkBtnInfBoldChat As Global.System.Web.UI.WebControls.LinkButton
    
    '''<summary>
    '''Control lblcuenta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblcuenta As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LinkBtnSeguimientoDatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LinkBtnSeguimientoDatos As Global.System.Web.UI.WebControls.LinkButton
    
    '''<summary>
    '''Control lblcuenta0.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblcuenta0 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LinkBtnSeguimiento0.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LinkBtnSeguimiento0 As Global.System.Web.UI.WebControls.LinkButton
    
    '''<summary>
    '''Control lblcuenta1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblcuenta1 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control LinkBtnSeguimiento1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LinkBtnSeguimiento1 As Global.System.Web.UI.WebControls.LinkButton
    
    '''<summary>
    '''Control lblcuenta2.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblcuenta2 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control PnlBoldchat.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PnlBoldchat As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control dtgBoldChat.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgBoldChat As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PnlSegumientoDatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PnlSegumientoDatos As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control dtgSeguimientoDatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgSeguimientoDatos As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PnlSeguimientoVoz.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PnlSeguimientoVoz As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control dtgSeguimientoVoz.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgSeguimientoVoz As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PnlDtgInforme.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PnlDtgInforme As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control DtgInforme.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents DtgInforme As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PnlDatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PnlDatos As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control dtgDatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgDatos As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''Control PnlVoz.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents PnlVoz As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control dtgVoz.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgVoz As Global.System.Web.UI.WebControls.GridView
End Class
