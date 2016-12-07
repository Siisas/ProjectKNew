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


Partial Public Class Inventario
    
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
    '''Control TxtLetra.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtLetra As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtNumero.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtNumero As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control BtnGuardarModulo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnGuardarModulo As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control LblModulo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblModulo As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control Txt_Fc_Adq.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_Fc_Adq As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control Pnl_Mas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Pnl_Mas As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''Control drlMarcaMonitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlMarcaMonitor As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtMarcaMonitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtMarcaMonitor As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtModeloMonitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtModeloMonitor As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialMonitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialMonitor As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialKamilionMonitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialKamilionMonitor As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlEmpresaMonitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEmpresaMonitor As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtEmpresaMonitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtEmpresaMonitor As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlModuloMonitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlModuloMonitor As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control txt_Fc_Adq_Monitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_Fc_Adq_Monitor As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control BtnGuardarMonitor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnGuardarMonitor As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control drlMarcaMouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlMarcaMouse As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtMarcaMouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtMarcaMouse As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtModeloMouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtModeloMouse As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialMouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialMouse As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialKamilionMouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialKamilionMouse As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlEmpresaMouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEmpresaMouse As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtEmpresaMouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtEmpresaMouse As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlModuloMouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlModuloMouse As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control txt_Fc_Adq_Mouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_Fc_Adq_Mouse As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control BtnGuardarMouse.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnGuardarMouse As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control drlDispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlDispositivo As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control drlMarcaDisposivito.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlMarcaDisposivito As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtMarcaDispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtMarcaDispositivo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtModeloDispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtModeloDispositivo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialDispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialDispositivo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialKamilionDispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialKamilionDispositivo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlEmpresaDispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEmpresaDispositivo As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtEmpresaDispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtEmpresaDispositivo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlModuloDispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlModuloDispositivo As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control txt_Fc_Adq_Dispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_Fc_Adq_Dispositivo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control BtnGuardarDispositivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnGuardarDispositivo As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control drlMarcaTeclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlMarcaTeclado As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtMarcaTeclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtMarcaTeclado As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtModeloTeclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtModeloTeclado As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialTeclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialTeclado As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialKamilionTeclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialKamilionTeclado As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlEmpresaTeclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEmpresaTeclado As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtEmpresaTeclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtEmpresaTeclado As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlModuloTeclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlModuloTeclado As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control txt_Fc_Adq_Teclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_Fc_Adq_Teclado As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control BtnGuardarTeclado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnGuardarTeclado As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control drlMarcaTorre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlMarcaTorre As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtMarcaTorre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtMarcaTorre As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtModeloTorre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtModeloTorre As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialTorre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialTorre As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control TxtSerialKamilionTorre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialKamilionTorre As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlEmpresaTorre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEmpresaTorre As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtEmpresaTorre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtEmpresaTorre As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control drlModuloTorre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlModuloTorre As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control txt_Fc_Adq_Torre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txt_Fc_Adq_Torre As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control BtnGuardarTorre.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnGuardarTorre As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control RdbtnModulo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RdbtnModulo As Global.System.Web.UI.WebControls.RadioButton
    
    '''<summary>
    '''Control drlModuloConsultas.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlModuloConsultas As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control RdbtnMarca.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RdbtnMarca As Global.System.Web.UI.WebControls.RadioButton
    
    '''<summary>
    '''Control drlMarcaConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlMarcaConsulta As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtMarcaConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtMarcaConsulta As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control RdbtnModelo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RdbtnModelo As Global.System.Web.UI.WebControls.RadioButton
    
    '''<summary>
    '''Control TxtModeloConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtModeloConsulta As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control RdbtnFc_Adquisicion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RdbtnFc_Adquisicion As Global.System.Web.UI.WebControls.RadioButton
    
    '''<summary>
    '''Control Txt_Consuta_Adquisicion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Txt_Consuta_Adquisicion As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control BtnConsultaInventario.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnConsultaInventario As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''Control RdbtnSerial.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RdbtnSerial As Global.System.Web.UI.WebControls.RadioButton
    
    '''<summary>
    '''Control TxtSerialConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialConsulta As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control RdbtnSerialKamilion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RdbtnSerialKamilion As Global.System.Web.UI.WebControls.RadioButton
    
    '''<summary>
    '''Control TxtSerialKamilionConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtSerialKamilionConsulta As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control RdbtnEmpresa.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RdbtnEmpresa As Global.System.Web.UI.WebControls.RadioButton
    
    '''<summary>
    '''Control drlEmpresaConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEmpresaConsulta As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''Control TxtEmpresaConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtEmpresaConsulta As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Control Label7.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Label7 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control lblcantidad.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblcantidad As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Control dtgConsultaMonitores.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgConsultaMonitores As Global.System.Web.UI.WebControls.GridView
End Class
