
var $_$ = jQuery.noConflict();
/*###############Sección plegable#################*/
function Desplegar() {
    $_$("#Desplegable").show();
};
function PlegDespleg_sli() {
    if ($_$("#Desplegable").is(":visible")) {
        $_$("#Desplegable").slideUp()
    } else {
        $_$("#Desplegable").slideDown()
    }
};
function Plegar() {
    if ($_$("#Desplegable").is(":visible")) {
        $_$("#Desplegable").slideUp()
    }
};
/*##################################################*/
/*###################Sección Load###################*/
function pageLoad() {
    $_$('.form-control-fecha').datepicker({ dateFormat: 'dd/mm/yy' }).val();
    $_$('.Desplegar').click(function () { PlegDespleg_sli() });
    //Plegar con tecla Esc
    $_$().bind('keydown', function (e) {
        if (e.which == 27) {
            if ($_$("#Desplegable").is(":visible")) {
                $_$("#Desplegable").slideUp()
            }
        }
    });
}
/*##################################################*/

