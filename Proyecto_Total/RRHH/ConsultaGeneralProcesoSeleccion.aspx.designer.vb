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


Partial Public Class ConsultaGeneralProcesoSeleccion

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
    '''Control TxtCod_Proceso_Seleccion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtCod_Proceso_Seleccion As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlEstadoProcesoSeleccion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEstadoProcesoSeleccion As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control TxtFecha_Inicio.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFecha_Inicio As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtFecha_Fin.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFecha_Fin As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control BtnConsultarProcesoSeleccion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnConsultarProcesoSeleccion As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control LblCantidadProcesosSeleccion.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblCantidadProcesosSeleccion As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control dtgGeneral.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgGeneral As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control TxtId_Aspirante.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtId_Aspirante As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control drlEstado.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlEstado As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control drlAlgunProceso.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents drlAlgunProceso As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control BtnConsultaAspirante.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnConsultaAspirante As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control btnxls.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents btnxls As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control LblCantidadAspirantes.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblCantidadAspirantes As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control dtgAspirantes.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgAspirantes As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control LblCantidadEstudios.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblCantidadEstudios As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control dtgEstudios.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgEstudios As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control LblCantidadExpeLaboral.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblCantidadExpeLaboral As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control dtgExperienciaLab.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgExperienciaLab As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control LblCantidadProcesosAspirante.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents LblCantidadProcesosAspirante As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control dtgProcesosAspirante.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents dtgProcesosAspirante As Global.System.Web.UI.WebControls.GridView
End Class
