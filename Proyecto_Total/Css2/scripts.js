var $_$ = jQuery.noConflict();
if ($_$.datepicker) {
    $_$.datepicker.regional['es-CO'] = {
        "Name": "es-CO",
        "closeText": "Cerrar",
        "prevText": "Atras",
        "nextText": "Adelante",
        "currentText": "Hoy",
        "monthNames": ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", ""],
        "monthNamesShort": ["Ene", "Feb", "Mar", "Abr", "May", "Jn", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic", ""],
        "dayNames": ["Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"],
        "dayNamesShort": ["Dom", "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb"],
        "dayNamesMin": ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sá"],
        "dateFormat": "dd/mm/yy",
        "firstDay": 0,
        "isRTL": false
    };
    $_$.datepicker.setDefaults($_$.datepicker.regional['es-CO']);
};

    function pageLoad(sender, args) {
    	try {
                    /*Sección que gestiona los inputs file*/
            $_$('.input-group .lbl-input-file').val('');
            $_$(document).on('change', ':file', function() {
                var input = $_$(this),
                    numFiles = input.get(0).files ? input.get(0).files.length : 1,
                    label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
                input.trigger('fileselect', [numFiles, label]);
            });
            $_$(':file').on('fileselect', function(event, numFiles, label) {
                var input = $_$(this).parents('.input-group').find(':text'),
                    log = numFiles > 1 ? numFiles + ' files selected' : label;

                if( input.length ) {
                    input.val(log);
                }
            });
            /*****************************************/ 

            
	        if ($_$('.Fecha').length) {
	         	$_$(".Fecha").datepicker({
	                changeMonth: true,
	                changeYear: true,
	                dateFormat: 'dd/mm/yy',
	                showAnim: "show"
	         	}).val();
	      	};
	      	if ($_$('.Hora').length) {
	         	$_$(".Hora").timepicker({
	                timeFormat: 'hh:mm',
	                showAnim: "show"
	         	});
	    	};
	        if ($_$('.HoraFecha').length) {
	            $_$('.HoraFecha').datetimepicker({
	           		changeMonth: true,
	                changeYear: true,
	                dateFormat: 'dd/mm/yy',
	                timeFormat: 'hh:mm',
	                showAnim: "show"
	         	});
	      	};
            if ($_$('.HoraSegundo').length) {
	            $_$('.HoraSegundo').timepicker({
	                timeFormat: 'hh:mm:ss',
	                showAnim: "show",
                    showSecond: true
	            });
	        };

	        //validar desplegables
	        if ($_$('.Desplegable').length) {
	     		Pleg_Esc();
	     		if ($_$('#Desp_Loading')) {
	        		$_$('.Desplegar_Loading').off('click').click(function () {
	           			try{
	              			var ValidationGroup = $_$(this).attr('onclick').split('(')[2].split(',')[3].replace(/"/gi, '').trim()
	                  		if (Page_ClientValidate(ValidationGroup)) {
	                  			Despleg_Loading();
	              			}
	           			}catch (ex) {
	           				if($_$(this).attr('ValidationGroup')){
           						var ValidationGroup = $_$(this).attr('ValidationGroup')
		                  		if (Page_ClientValidate(ValidationGroup)) {
		                  			Despleg_Loading();
		              			}	
           					}else{
           						Despleg_Loading();
           					}
       					}
	            	});
	         	};
	         	if ($_$('#Desp_Calif').length) {
	             	$_$('#Plegar_Form_Calif').off('click').click(function () {
	                 	PlegDes_Dinamico("#Desp_Calif", "slide", '', '', '');
	         		});
	     		};
	        };
	        /*ajustar tamaño de cajas de texto*/
	        for (var i = 0; i < $_$('.input-group > .input-group-addon').length; i++) {
	            if($_$('.input-group:eq('+i+') > .input-group-addon:eq(0)').height() > 20){
	                $_$('.input-group:eq('+i+') > .form-control').height($_$('.input-group:eq('+i+') > .input-group-addon:eq(0)').height());
	            }
	        };
	        try {
	            LocalpageLoad(sender, args);
	        }catch (ex) {
	        };
        }catch (ex) {
        	$_$('#Pnl_Message').attr('class', 'alert alert-danger');
            $_$('#Lbl_Mensage').html('<span class="glyphicon glyphicon-remove-sign"></span> ' + ex.message);      
        };
    };
/*###############Seccion plegable#################*/
    function PlegDes_Dinamico(Tool, Efect, SubEfect, Duration, Aliv) {
        if (Efect == 'show') {
            if ($_$(Tool).is(':visible')) {
                $_$(Tool).hide(SubEfect, Duration, Aliv);
            } else {
                $_$(Tool).show(SubEfect, Duration, Aliv);
            };
        };
        if (Efect == 'slide') {
            if ($_$(Tool).is(':visible')) {
                $_$(Tool).slideUp(Duration, Aliv);
            } else {
                $_$(Tool).slideDown(Duration, Aliv);
            };
        };
    };
    function Pleg_Esc() {
     	$_$(document).bind('keydown', function (e) {
         	if (e.which == 27) {
            	if ($_$("#Desp_Loading").is(":visible")) {
                   	Pleg_Loading();
            	}else{
                   	if ($_$(".Desplegable").is(":visible")) {
                      	$_$(".Desplegable").hide();
                   	}
            	}
         	}
  		});
    };
    function Pleg_Loading(){
		$_$("#Desp_Loading").hide("puff", 500);
	};
	function Despleg_Loading(){
		$_$("#Desp_Loading").show("puff", 500);
	};
/*###########Sección de grid###############*/
/*###########Sección de grid###############*/
    function Data_Grid(Input_Data) {
        try{
            /*download('json consulta.txt', JSON.stringify(Input_Data))*/
            $_$(Input_Data.Grid.Config.Container).show();
            /*rectificado datetie*/
            for (var i = Input_Data.Grid.Data.length - 1; i >= 0; i--) {
                for (var item in Input_Data.Grid.Data[i]) {
                    if (RegExp('^(/Date\(\))').test(Input_Data.Grid.Data[i][item])){
                        //quitar barras y convertir a datetime
                        Input_Data.Grid.Data[i][item] = new Date(Number(Input_Data.Grid.Data[i][item].replace(/\/Date\((-?\d+)\)\//,/$1/).replace(/\//gi,''))).format('dd/MM/yyyy HH:mm:ss');
                    };
                };
            };

            /*renderizado de columnas*/
            for (var i = Input_Data.Grid.Format.Columns.length - 1; i >= 0; i--) {
                if (!Input_Data.Grid.Format.Columns[i].columntype) {
                    Input_Data.Grid.Format.Columns[i].cellsrenderer = function (row, column, value) {return '<span Class="Cell-Grid">' + value + '</span>'};
                };
            };
              /*generar herramientas*/
            function Gerenate_Tool(i, Grid){
                if (Input_Data[Grid].Format.Columns[i].type=='button' ) {
                    var Event = Input_Data[Grid].Format.Columns[i].onclick;
                    var TextTool = Input_Data[Grid].Format.Columns[i].textool;
                    Input_Data[Grid].Format.Columns[i].createwidget =  function (row, column, value, htmlElement) {
                        var Val_Prin = $_$(value).html();
                        if (!Val_Prin) {
                            Val_Prin = value
                        };
                        $_$(htmlElement).addClass('btn btn-primary');
                        $_$(htmlElement).css('font-weight', 'bold');
                        $_$(htmlElement).attr('onclick', Event+"('"+Val_Prin+"')");
                        $_$(htmlElement).html(TextTool);
                    };
                    Input_Data[Grid].Format.Columns[i].initwidget = function (row, column, value, htmlElement) {
                        $_$(htmlElement).attr("onclick", Event+"('"+value+"')");
                    };
                }
            };
            var Width = '100%';
            var Heigth = 61;
            if (Input_Data.Grid.Config.ShowFilter) {
                Heigth = 91;
            };
            if (Input_Data.Grid.Data.length <= 3) {
                Heigth = Heigth + 25
            };
            /*Datos de data grid secundario*/
            var Rowdetails = false;
            if (Input_Data.Sub_Grid) {

                            /*rectificado datetie*/
                for (var i = Input_Data.Sub_Grid.Data.length - 1; i >= 0; i--) {
                    for (var item in Input_Data.Sub_Grid.Data[i]) {
                        if (RegExp('^(/Date\(\))').test(Input_Data.Sub_Grid.Data[i][item])) {
                            //quitar barras y convertir a datetime
                            Input_Data.Sub_Grid.Data[i][item] = new Date(Number(Input_Data.Sub_Grid.Data[i][item].replace(/\/Date\((-?\d+)\)\//, /$1/).replace(/\//gi, ''))).format('dd/MM/yyyy HH:mm:ss');
                        };
                    };
                };

                /*Ajustar altura de tabla principal*/
                Heigth = 271;
                for (var i = 0; i < Input_Data.Grid.Data.length-7; i++) {
                    if (Heigth<Input_Data.Grid.Config.MaxHeigth) {
                        Heigth= Heigth+30;
                    };
                };
                /*###############*/
                Rowdetails = true;
                /*Renderizado de columnas de grid secundario*/
                for (var i = Input_Data.Sub_Grid.Format.Columns.length - 1; i >= 0; i--) {
                    Input_Data.Sub_Grid.Format.Columns[i].cellsrenderer = function (row, column, value) {return '<span Class="Cell-SubGrid">' + value + '</span>'};
                };
                /*herramientas de lelección grid anidado*/
                for (var i = 0; i < Input_Data.Sub_Grid.Format.Columns.length; i++) {
                    if (Input_Data.Sub_Grid.Format.Columns[i].onclick) {
                        Gerenate_Tool(i, 'Sub_Grid')
                    }
                }
            }else{
                for (var i = 0; i < Input_Data.Grid.Data.length -1; i++) {
                    if (Heigth < Input_Data.Grid.Config.MaxHeigth) {
                        Heigth = Heigth+30;
                    }
                };
            };
            /*herramientas de selección grid principal*/
            for (var i = 0; i < Input_Data.Grid.Format.Columns.length; i++) {
                if (Input_Data.Grid.Format.Columns[i].onclick) {
                    Gerenate_Tool(i, 'Grid')
                }
            };
            /*Funcion para crear detalles de grid*/
            var Sub_Grid = function (index, parentElement, gridElement, record) {
                /*###Capturar Grid###*/
                var grid = $_$($_$(parentElement).children()[0]);
                var Sub_Data = [];
                for (var m = 0; m < Input_Data.Sub_Grid.Data.length; m++) {
                    if (record[Input_Data.Grid.Format.Keys.Primary].toString() == Input_Data.Sub_Grid.Data[m][Input_Data.Sub_Grid.Format.Keys.Foreign].toString()){
                        Sub_Data.push(Input_Data.Sub_Grid.Data[m]);
                    }
                };
                /*#######Preparar sub datos##########*/
                if (grid != null) {
                    var SubSource = { 
                        datafields: Input_Data.Sub_Grid.Format.Datafields,
                        id: Input_Data.Sub_Grid.Format.Keys.Primary,
                        localdata: Sub_Data
                    };
                    var SubDataAdapter = new $_$.jqx.dataAdapter(SubSource);
                    grid.jqxGrid({
                        source: SubDataAdapter, 
                        width: '90%', 
                        height: 181,
                        columnsresize: true,
                        filterable: Input_Data.Sub_Grid.Config.Filterable,
                        showfilterrow: Input_Data.Sub_Grid.Config.ShowFilter,
                        selectionmode: 'multiplecellsextended',
                        sortable: true,
                        editable: Input_Data.Sub_Grid.Config.Editable,
                        columns: Input_Data.Sub_Grid.Format.Columns,
                        rowsheight: 30,
                    });
                };
            };
            /*######Generar Datagrid Principal######*/
            var Source = {
                datafields: Input_Data.Grid.Format.Datafields,
                localdata: Input_Data.Grid.Data,
                datatype: "array",
                id: Input_Data.Grid.Format.Keys.Primary,
            };
            var DataAdapter = new $_$.jqx.dataAdapter(Source);
            $_$(Input_Data.Grid.Config.Container).jqxGrid({
                width: '100%',
                height: Heigth,
                columnsresize: true,
                selectionmode: 'multiplecellsextended',
                sortable: true,
                editable: Input_Data.Grid.Config.Editable,
                filterable: Input_Data.Grid.Config.Filterable,
                rowsheight: 30,
                showfilterrow: Input_Data.Grid.Config.ShowFilter,
                source: DataAdapter,
                columns: Input_Data.Grid.Format.Columns,
                rowdetails: Rowdetails,
                initrowdetails: Sub_Grid,
                rowdetailstemplate: {
                    rowdetails: "<div id='grid' style='margin: 0 Auto; border: 2px solid #B3C556;'></div>", 
                    rowdetailsheight: 185, 
                    rowdetailshidden: true 
                },
            });
            //$_$(Input_Data.Grid.Config.Container).jqxWindow();
            
            $_$(Input_Data.Grid.Config.Container).css('z-index', 2);
        }catch (ex){
            throw ex
        };
    };

function download(filename, text) {
    var element = document.createElement('a');
    element.setAttribute('href', 'data:text/plain;charset=utf-8,' + encodeURIComponent(text));
    element.setAttribute('download', filename);
    element.style.display = 'none';
    document.body.appendChild(element);
    element.click();
    document.body.removeChild(element);
}

/*********GESTIONA LOS PANELES DESPLEGABLES************/
function GridViewSI(ID) {
    $_$(ID).attr("class", "panel_desplegable2");
};
function GridViewNO(ID) {
    $_$(ID).attr("class", "panel_desplegable");
};
function GridViewPOINT(ID) {
    $_$(ID).css("animation", "bounce 2000ms  ease-out");
};
function GridViewNOPOINT(ID) {
    $_$(ID).css("animation", "none");
}
/******************************************************/
