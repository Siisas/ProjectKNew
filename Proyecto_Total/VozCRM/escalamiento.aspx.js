function LocalpageLoad(sender, args) {
    try{
        $_$("#Btn_Change_Form").off('click').click(function(){
            PlegDes_Dinamico("#Pnl_Asig_Cas", "slide", '', '', '');
            PlegDes_Dinamico("#Pnl_Asig_Cas_Dev", "slide", '', '', '');
        })
        $_$('#Btn_Asignar_Casos_Devueltos').click(function () {
            if (Page_ClientValidate("VG_Asig_Cas_Dev")) {
                setTimeout("Asignar_Casos_Dev();", 500);
            };
        });
        $_$('#RBtn_Select_All_Cas_Dev').click(function(){
            $_$('#Grid_Cas_Dev').jqxGrid('clearfilters');
            setTimeout("Check_All_Grid('#Grid_Cas_Dev', true);", 250);
        })
        $_$('#RBtn_Select_Nothing_Cas_Dev').click(function(){   
            $_$('#Grid_Cas_Dev').jqxGrid('clearfilters');
            setTimeout("Check_All_Grid('#Grid_Cas_Dev', false);", 250);
        })
    }catch (ex) {
        $_$('#Pnl_Message').attr('class', 'alert alert-danger');
        $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-danger-sign"></span> ' + ex.message);
    };
};
function Asignar_Casos_Dev() {
    try{
        //Obtener datos de grid
        var RowsGrid = $_$('#Grid_Cas_Dev').jqxGrid('getrows');
        //Validar Grid
        if (RowsGrid && $_$('#Grid_Cas_Dev').is(':visible')) {
            $_$('#Grid_Cas_Dev').jqxGrid('clearfilters');
            var Casos = new Array;
            //Obtener serial componentes con check
            for (var i = 0; i < RowsGrid.length; i++) {
                if (RowsGrid[i].Check == true) {
                    Casos.push(RowsGrid[i].Id_Caso);
                };
            };
            //validar check de componentes
            if (Casos.length > 0) {
                $_$.ajax({
                    async:false,
                    type: "POST",
                    url: "escalamiento.aspx/Asignar_Casos_Devueltos",
                    data: JSON.stringify({ Casos: Casos, Id_Usuario: $_$('#Drl_Agent_Dev').val() }),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        try{
                            if (response.d != null) {
                                $_$('#Pnl_Message').attr('class', 'alert alert-warning');
                                $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-warning-sign"></span> ¡' + response.d);
                            } else {
                                $_$('#Pnl_Message').attr('class', 'alert alert-success');
                                $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-ok-circle"></span> Los casos se han asignado correctamente');
                                $_$('#Grid_Cas_Dev').hide();
                                $_$('#Div_Count_Cas_Dev').hide();
                                //Consultar_Agententes_Asignados_Dev();
                                Contar_Casos_Devueltos();
                                Consultar_Casos_Devueltos();
                            }
                        }catch (ex){
                            throw ex
                        };
                    },
                    error: function (result) {
                        throw {message:result.statusText + '! ' + result.responseJSON.Message}
                    }
                });
            } else {
                $_$('#Pnl_Message').attr('class', 'alert alert-warning');
                $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-warning-sign"></span> No ha marcado ningún caso para asignar!');
                Pleg_Loading();
            };
        } else {
            $_$('#Pnl_Message').attr('class', 'alert alert-warning');
            $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-warning-sign"></span> Debe realizar un filtro y marcar los casos a asignar!');
            Pleg_Loading();
        };
    }catch (ex) {
        $_$('#Pnl_Message').attr('class', 'alert alert-danger');
        $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-remove-sign"></span> ' + ex.message);
    }finally{
        Pleg_Loading();
    };
};
/*function Consultar_Agententes_Asignados_Dev(){
    try{
        $_$.ajax({
            async:true,
            type: "POST",
            url: "escalamiento.aspx/Json_Consulta_Agentes_Asignados_Dev",
            data: "{}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (Agent) {
                if (typeof Agent.d == 'object') {
                    Data_Grid(Agent.d);
                }else{
                    $_$('#Grid_Agen_Dev').hide();
                };
            },
            error: function (Agent_result) {
                $_$('#Grid_Agen_Dev').hide();
                $_$('#Pnl_Message').attr('class', 'alert alert-danger');
                $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-remove-sign"></span> ' + Agent_result.statusText + '! ' + Agent_result.responseJSON.Message);
            }
        });
    }catch (ex) {
        throw ex
        $_$('#Grid_Agen_Dev').hide();
    };
};*/
function Contar_Casos_Devueltos(){
    try{
        $_$.ajax({
            async:true,
            type: "POST",
            url: "escalamiento.aspx/Contar_Casos_Devuelos",
            data: "{}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (Count) {
                $_$('#Lbl_Cas_Dev').html(Count.d);
            },
            error: function (result_Count) {
                $_$('#Lbl_Cas_Dev').html('');
                $_$('#Pnl_Message').attr('class', 'alert alert-danger');
                $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-remove-sign"></span> ' + result_Count.statusText + '! ' + result_Count.responseJSON.Message);
            }
        });
    }catch (ex) {
        $_$('#Lbl_Cas_Dev').html('');
        throw ex
    };
};
function Consultar_Casos_Devueltos(){
    try{
        $_$('#Div_Count_Cas_Dev').hide();
        $_$('#Span_Count_Cas_Dev').html('');
        $_$.ajax({
            async:false,
            type: "POST",
            url: "escalamiento.aspx/Json_Consulta_Casos_Devueltos",
            data: "{}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (Cons) {
                if (Cons.d != null) {
                    if (typeof Cons.d == 'object') {
                        Data_Grid(Cons.d);
                        $_$('#Span_Count_Cas_Dev').html(Cons.d.Grid.Data.length);
                        $_$('#Div_Count_Cas_Dev').show();
                    }else{
                        $_$('#Pnl_Message').attr('class', 'alert alert-warning');
                        $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-warning-sign"></span> ¡' + Cons.d);
                        $_$('#Grid_Cas_Dev').hide();
                    };
                }else{
                    $_$('#Pnl_Message').attr('class', 'alert alert-warning');
                    $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-warning-sign"></span> ¡Tras la asignación no se han podido consultar más casos que corespondan con su criterio de búsqueda');
                    $_$('#Grid_Cas_Dev').hide();
                };
            },
            error: function (result_Cons) {
                $_$('#Grid_Cas_Dev').hide();
                throw {message:result_Cons.statusText + '! ' + result_Cons.responseJSON.Message}
            }
        });
    }catch (ex) {
        $_$('#Grid_Cas_Dev').hide();
        throw ex
    };
};
function Check_All_Grid(Grid, Bool){
    try{
        var Rows = $_$(Grid).jqxGrid('getrows');
        if (Rows && $_$(Grid).is(':visible') ) {
            if (Rows.length <= 100) {
                var Grid = $_$(Grid).jqxGrid();
                for (var i = 0; i < Rows.length; i++) {
                    Grid.jqxGrid('setcellvalue', i, 'Check', Bool);
                };
            }else{
                $_$('#Pnl_Message').attr('class', 'alert alert-warning');
                $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-warning-sign"></span> No es posible usar la selección masiva con más de 100 casos!');    
            };
        }else{
            $_$('#Pnl_Message').attr('class', 'alert alert-warning');
            $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-warning-sign"></span> Debe realizar un filtro de consulta para poder elegir casos!');
        };
    }catch (ex) {
        $_$('#Pnl_Message').attr('class', 'alert alert-danger');
        $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-danger-sign"></span> ' + ex.message);
    }finally{
        Pleg_Loading();
    };
};