function Chang_Panel() {
    PlegDes_Dinamico("#Pnl_Asig_Com", "slide", '', '', '');
    PlegDes_Dinamico("#Pnl_Componentes", "slide", '', '', '');
};
function Liberar_Com(Cod) {
    $_$('#Lbl_Msg_Confirm').html('Ingrese una observación y confirme la liberación del componente');
    PlegDes_Dinamico("#Desp_Confirm", "slide", '', '', '');
    $_$('#Txb_Observacion').show();
    $_$('#Drl_Estado_Com_Ac').hide();

    $_$('#RFV_Txb_Observacion').hide();
    $_$('#REV_Txb_Obs_Asignacion').hide();
    $_$('#RFV_Drl_Estado_Ac_txt').hide();

    $_$('#Btn_Confimr_Si').off('click').click(function () {
        if (Page_ClientValidate('VG_Observacion')) {
            PlegDes_Dinamico("#Desp_Loading", "show", "puff", 500, "");
            PlegDes_Dinamico("#Desp_Confirm", "slide", '', '', '');
            $_$.ajax({
                type: "POST",
                url: "Historial_Equipos.aspx/Liberar_Componente",
                data: JSON.stringify({ Cod: Cod, Observacion: document.getElementById('Txb_Observacion').value }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    if (response.d != null) {
                        $_$('#Pnl_Message').attr('class', 'alert alert-danger');
                        $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong>¡' + response.d);
                    } else {
                        $_$('#Pnl_Message').attr('class', 'alert alert-success');
                        $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-ok-circle"></span></strong> El componente se ha liberado correctamente');

                        if ($_$('#Grid_Equ_C').html() != "" && $_$('#Grid_Equ_C').is(':visible')) {
                            setTimeout('Consultar_Equipos()', 250);
                        };
                        if ($_$('#Grid_Com_C').html() != "" && $_$('#Grid_Com_C').is(':visible')) {
                            setTimeout('Consultar_Componentes()', 250);
                        };
                    }
                },
                error: function (result) {
                    $_$('#Pnl_Message').attr('class', 'alert alert-warning');
                    $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong> ¡' + result.statusText + '! ' + result.responseJSON.Message);
                }
            });
            PlegDes_Dinamico("#Desp_Loading", "show", "puff", 500, "");
        };
    });
    $_$('#Btn_Confimr_No').off('click').click(function () {
        PlegDes_Dinamico("#Desp_Confirm", "slide", '', '', '');
    });
};
function Actualizar_Com(Cod) {
    $_$('#Lbl_Msg_Confirm').html('Por favor elija un nuevo estado');
    PlegDes_Dinamico("#Desp_Confirm", "slide", '', '', '');
    $_$('#Drl_Estado_Com_Ac').show();
    $_$('#Txb_Observacion').hide();

    $_$('#RFV_Txb_Observacion').hide();
    $_$('#REV_Txb_Obs_Asignacion').hide();
    $_$('#RFV_Drl_Estado_Ac_txt').hide();

    $_$('#Btn_Confimr_Si').off('click').click(function () {
        if (Page_ClientValidate('VG_Actualizar_Com')) {
            PlegDes_Dinamico("#Desp_Loading", "show", "puff", 500, "");
            PlegDes_Dinamico("#Desp_Confirm", "slide", '', '', '');

            $_$.ajax({
                type: "POST",
                url: "Historial_Equipos.aspx/Actualizar_Componente",
                data: JSON.stringify({ Cod: Cod, Cod_Estado: $_$('#Drl_Estado_Com_Ac').val() }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    if (response.d != null) {
                        $_$('#Pnl_Message').attr('class', 'alert alert-danger');
                        $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong>¡' + response.d);
                    } else {
                        $_$('#Pnl_Message').attr('class', 'alert alert-success');
                        $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-ok-circle"></span></strong> El componente se ha actualizado correctamente');

                        if ($_$('#Grid_Equ_C').html() != "" && $_$('#Grid_Equ_C').is(':visible')) {
                            setTimeout('Consultar_Equipos()', 250);
                        };
                        if ($_$('#Grid_Com_C').html() != "" && $_$('#Grid_Com_C').is(':visible')) {
                            setTimeout('Consultar_Componentes()', 250);
                        };
                    }
                },
                error: function (result) {
                    $_$('#Pnl_Message').attr('class', 'alert alert-warning');
                    $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong> ¡' + result.statusText + '! ' + result.responseJSON.Message);
                }
            });
            PlegDes_Dinamico("#Desp_Loading", "show", "puff", 500, "");
        };
    });
    $_$('#Btn_Confimr_No').off('click').click(function () {
        PlegDes_Dinamico("#Desp_Confirm", "slide", '', '', '');
    });
};
function Consultar_Equipos() {
    $_$.ajax({
        type: "POST",
        url: "Historial_Equipos.aspx/Consultar_Equipos",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var Return = response.d;
            if (Return != null) {
                Data_Grid(Return)
            } else {
                $_$('#Pnl_Message').attr('class', 'alert alert-warning');
                $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong> Ya no hay equipos que coincidan con su criterio de búsqueda');
                $_$('#Grid_Equ_C').hide()
            };
        },
        error: function (result) {
            $_$('#Pnl_Message').attr('class', 'alert alert-warning');
            $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong> ¡' + result.statusText + '! ' + result.responseJSON.Message);
            $_$('#Grid_Equ_C').hide()
        }
    });
};
function Consultar_Componentes() {
    $_$.ajax({
        type: "POST",
        url: "Historial_Equipos.aspx/Consultar_Componentes",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.d != null) {
                Data_Grid(response.d);
            } else {
                $_$('#Pnl_Message').attr('class', 'alert alert-warning');
                $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong> No se encontraron más componentes que coincidan con su criterio de búsqueda!');
                $_$('#Grid_Com_C').hide()
            };
        },
        error: function (result) {
            $_$('#Pnl_Message').attr('class', 'alert alert-warning');
            $_$('#lblmsg').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong> ¡' + result.statusText + '! ' + result.responseJSON.Message);
            $_$('#Grid_Com_C').hide()
        }
    });
};
function Consultar_Componentes_Asign() {
    $_$.ajax({
        type: "POST",
        url: "Historial_Equipos.aspx/Consultar_Componentes_Asign",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.d != null) {
                Data_Grid(response.d);
            } else {
                $_$('#Pnl_Alert_Asign').attr('class', 'alert alert-warning');
                $_$('#Lbl_Alert_Asign').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong> No se encontraron más componentes que coincidan con su criterio de búsqueda!');
                $_$('#Grid_Com_Asig').hide()
            };
        },
        error: function (result) {
            $_$('#Pnl_Alert_Asign').attr('class', 'alert alert-warning');
            $_$('#Lbl_Alert_Asign').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong> ¡' + result.statusText + '! ' + result.responseJSON.Message);
            $_$('#Grid_Com_Asig').hide()
        }
    });
};
function Desp_Asignar_Com(Cod) {
    $_$('#Grid_Com_Asig').hide();
    PlegDes_Dinamico('#Desp_Asign_Componentes', 'slide', '', '', '');
    $_$('#Btn_Asig_Com').off('click').click(function () {
        /*Obtener datos de grid*/
        var RowsGrid = $_$('#Grid_Com_Asig').jqxGrid('getrows');
        /*Validar Grid*/
        if (RowsGrid && $_$('#Grid_Com_Asig').is(':visible')) {
            $_$('#Grid_Com_Asig').jqxGrid('clearfilters');
            var Seriales = new Array;
            /*Obtener serial componentes con check*/
            for (var i = 0; i < RowsGrid.length; i++) {
                if (RowsGrid[i].Check == true) {
                    Seriales.push(RowsGrid[i].Serial);
                };
            };
            /*validar check de componentes*/
            if (Seriales.length > 0) {
                $_$('#Lbl_Msg_Confirm').html('Ingrese una observación y confirme la asignación de los componentes');
                PlegDes_Dinamico("#Desp_Confirm", "slide", '', '', '');
                $_$('#Txb_Observacion').show();
                $_$('#Drl_Estado_Com_Ac').hide();
                $_$('#Btn_Confimr_Si').off('click').click(function () {
                    if (Page_ClientValidate('VG_Observacion')) {
                        PlegDes_Dinamico("#Desp_Loading", "show", "puff", 500, "");
                        $_$.ajax({
                            type: "POST",
                            url: "Historial_Equipos.aspx/Asignar_Componentes",
                            data: JSON.stringify({ Equipo: Cod, Componentes: Seriales, Observacion: document.getElementById('Txb_Observacion').value }),
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (response) {
                                if (response.d != null) {
                                    alert(JSON.stringify(response.d));
                                    $_$('#Pnl_Alert_Asign').attr('class', 'alert alert-danger');
                                    $_$('#Lbl_Alert_Asign').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong>¡' + response.d);
                                } else {
                                    $_$('#Pnl_Alert_Asign').attr('class', 'alert alert-success');
                                    $_$('#Lbl_Alert_Asign').html('<strong><span class="glyphicon glyphicon-ok-circle"></span></strong>Los componentes se han asignado correctamente');
                                    setTimeout('Consultar_Componentes_Asign()', 250);
                                    if ($_$('#Grid_Equ_C').html() != "" && $_$('#Grid_Equ_C').is(':visible')) {
                                        setTimeout('Consultar_Equipos()', 250);
                                    };
                                    if ($_$('#Grid_Com_C').html() != "" && $_$('#Grid_Com_C').is(':visible')) {
                                        setTimeout('Consultar_Componentes()', 250);
                                    };
                                }
                            },
                            error: function (result) {
                                $_$('#Pnl_Alert_Asign').attr('class', 'alert alert-danger');
                                $_$('#Lbl_Alert_Asign').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong>¡' + result.statusText + '! ' + result.responseJSON.Message);
                            }
                        });
                        PlegDes_Dinamico("#Desp_Loading", "show", "puff", 500, "");
                        PlegDes_Dinamico("#Desp_Confirm", "slide", '', '', '');
                    };
                });
                $_$('#Btn_Confimr_No').off('click').click(function () {
                    PlegDes_Dinamico("#Desp_Confirm", "slide", '', '', '');
                });
            } else {
                $_$('#Pnl_Alert_Asign').attr('class', 'alert alert-danger');
                $_$('#Lbl_Alert_Asign').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong>No ha seleccionado ningún componentes para asignar!');
            };
        } else {
            $_$('#Pnl_Alert_Asign').attr('class', 'alert alert-danger');
            $_$('#Lbl_Alert_Asign').html('<strong><span class="glyphicon glyphicon-warning-sign"></span></strong>Debe realizar un filtro y elegir los componentes a asignar!');
        };
    });
    $_$('#Btn_Cancel_Asig').off('click').click(function () {
        PlegDes_Dinamico('#Desp_Asign_Componentes', 'slide', '', '', '');
    });
};
