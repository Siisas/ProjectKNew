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


Partial Public Class FiltroSeleccion

    '''<summary>
    '''Control form1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents form1 As Global.System.Web.UI.HtmlControls.HtmlForm

    '''<summary>
    '''Control lblmsg.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblmsg As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control menu1.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents menu1 As Global.digitacion.menu

    '''<summary>
    '''Control lblmsg0.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblmsg0 As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lblusuario.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblusuario As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control lblnombreusu.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblnombreusu As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control RbtnNuevo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RbtnNuevo As Global.System.Web.UI.WebControls.RadioButton

    '''<summary>
    '''Control RbtAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents RbtAgregar As Global.System.Web.UI.WebControls.RadioButton

    '''<summary>
    '''Control BtnActualizarRegistro.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnActualizarRegistro As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control BtnRegresar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnRegresar As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Panel_RegistroNuevo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_RegistroNuevo As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control TxtCargo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCargo As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtObservacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtObservacion As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlEstado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEstado As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control TxtCantidadRequerida.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCantidadRequerida As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtFecha_Inicio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFecha_Inicio As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtMaxCandidatos.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtMaxCandidatos As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control BtnValidarProcesoSeleccion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnValidarProcesoSeleccion As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control BtnValidacion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnValidacion As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Panel_AgregarAspirantes.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Panel_AgregarAspirantes As Global.System.Web.UI.WebControls.Panel

    '''<summary>
    '''Control drlProcesoSeleccion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlProcesoSeleccion As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control BtnConsultaProcesoSeleccion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnConsultaProcesoSeleccion As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control BtnValidacionConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnValidacionConsulta As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control TxtCargoConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCargoConsulta As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtObservacionConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtObservacionConsulta As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlEstadoConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEstadoConsulta As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control TxtCantidadRequeridaConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCantidadRequeridaConsulta As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtFecha_Inicio_Consulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFecha_Inicio_Consulta As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtCantidadObtenidaConsulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCantidadObtenidaConsulta As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtFecha_Fin_Consulta.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFecha_Fin_Consulta As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlNivel.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlNivel As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control TxtCargoLabor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCargoLabor As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtTiempo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtTiempo As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlTiempo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlTiempo As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control BtnValidarFiltro.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnValidarFiltro As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control BtnGuardarProcesoSeleccion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnGuardarProcesoSeleccion As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control LblNumAspirantes.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblNumAspirantes As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control dtgAspirantes.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgAspirantes As Global.System.Web.UI.WebControls.GridView
End Class
