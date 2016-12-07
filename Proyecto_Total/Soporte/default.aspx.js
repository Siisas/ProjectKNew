/*###############Secciónn Gráficos#################*/
function Order_Graphics_Date(Data) {
    var Input_Data = JSON.parse(Data);
    var Output_Data = {
        Mes: {
            Categorias: []
            , Datos_Pc: {
                Efectivos: []
                , Tocados: []
                , "Prom_ET": []
                , Atencion: []
                , Gestion: []
                , Solucion: []
                , Cierre: []
                , Calidad: []
                , Adh: []
                , Cumplimiento: []
            }
            , Datos: {
                Atencion: []
                , Gestion: []
                , Solucion: []
                , Cierre: []
            }
            , Total_Datos: {
            }
        },
        Dia: {}
    };
    if (Input_Data[0].length > 0) {
        for (var i = 0 ; i < Input_Data[0].length; i++) {
            Output_Data.Mes.Categorias.push(Input_Data[0][i]['Fecha']);
            Output_Data.Mes.Datos_Pc.Efectivos.push(Input_Data[0][i]['Pc_Efectivos']);
            Output_Data.Mes.Datos_Pc.Tocados.push(Input_Data[0][i]['Pc_Tocado']);
            Output_Data.Mes.Datos_Pc.Prom_ET.push((Input_Data[0][i]['Pc_Efectivos'] + Input_Data[0][i]['Pc_Tocado']) / 2);
            Output_Data.Mes.Datos_Pc.Atencion.push(Input_Data[0][i]['Pc_Atencion']);
            Output_Data.Mes.Datos_Pc.Gestion.push(Input_Data[0][i]['Pc_Gestion']);
            Output_Data.Mes.Datos_Pc.Solucion.push(Input_Data[0][i]['Pc_Solucion']);
            Output_Data.Mes.Datos_Pc.Cierre.push(Input_Data[0][i]['Pc_Cierre']);
            Output_Data.Mes.Datos_Pc.Calidad.push(Input_Data[0][i]['Calidad']);
            Output_Data.Mes.Datos_Pc.Adh.push(Input_Data[0][i]['Adh_Pc']);
            Output_Data.Mes.Datos_Pc.Cumplimiento.push(Input_Data[0][i]['Cumplimiento']);
            Output_Data.Mes.Datos.Atencion.push(Input_Data[0][i]['Atencion']);
            Output_Data.Mes.Datos.Gestion.push(Input_Data[0][i]['Gestion']);
            Output_Data.Mes.Datos.Solucion.push(Input_Data[0][i]['Solucion']);
            Output_Data.Mes.Datos.Cierre.push(Input_Data[0][i]['Cierre']);
            Output_Data.Dia[Input_Data[0][i].Fecha] = { Bandeja: [], Efectivo: [], Tocado: [], Pc_Efectivo: [], Pc_Tocado: [], Rank: Input_Data[0][i].Rank, Total_Efec: Input_Data[0][i].Efectivos, Total_Toc: Input_Data[0][i].Tocados };
        };
        Output_Data.Mes.Total_Datos = Input_Data[1][0];
        for (var i = 0 ; i < Input_Data[2].length; i++) {
            Output_Data.Dia[Input_Data[2][i].Fecha].Bandeja.push(Input_Data[2][i].Bandeja + '<br> Efectivos: ' + Input_Data[2][i].Efectivos + '<br> Tocados: ' + Input_Data[2][i].Tocados);
            Output_Data.Dia[Input_Data[2][i].Fecha].Efectivo.push(Input_Data[2][i].Efectivos);
            Output_Data.Dia[Input_Data[2][i].Fecha].Tocado.push(Input_Data[2][i].Tocados);
            Output_Data.Dia[Input_Data[2][i].Fecha].Pc_Efectivo.push(Input_Data[2][i].Pc_Efectivos);
            Output_Data.Dia[Input_Data[2][i].Fecha].Pc_Tocado.push(Input_Data[2][i].Pc_Tocados);
        };
    };
    Indicators_Graphics(Output_Data);
};
function Indicators_Graphics(Data) {
    if (Data.Mes.Categorias.length > 0) {
        var Data_Pie_02 = { type: 'pie' };
        var Data_Pie_03 = { type: 'pie' };
        if (Data.Mes.Total_Datos.Calidad) {
            Data_Pie_02 = {
                type: 'pie',
                name: "Calidad",
                allowPointSelect: false,
                size: '3%',
                center: ['55%', '-3%'],
                endAngle: ((Data.Mes.Total_Datos.Calidad) / 100) * 360,
                dataLabels: { enabled: false },
                data: [
                    {
                        name: "Calidad",
                        y: Data.Mes.Total_Datos.Calidad,
                        color: Highcharts.getOptions().colors[4],
                    }
                ],
            };
            Data_Pie_03 = {
                type: 'pie',
                name: 'Promedio',
                size: '10%',
                innerSize: '65%',
                endAngle: ((Data.Mes.Total_Datos.Calidad) / 100) * 360,
                dataLabels: {
                    color: '#fff',
                    distance: 10,
                    //rotation:-5,
                    style: { fontSize: "11px" }
                },
                center: ['55%', '-3%'],
                data: [
                    {
                        "name": "Atención: " + Data.Mes.Total_Datos.Atencion.toFixed(2),
                        "y": Data.Mes.Total_Datos.Pc_Atencion,
                    },
                    {
                        "name": "Gestión: " + Data.Mes.Total_Datos.Gestion.toFixed(2),
                        "y": Data.Mes.Total_Datos.Pc_Gestion,
                    },
                    {
                        "name": "Solución: " + Data.Mes.Total_Datos.Solucion.toFixed(2),
                        "y": Data.Mes.Total_Datos.Pc_Solucion,
                    },
                    {
                        "name": "Cierre: " + Data.Mes.Total_Datos.Cierre.toFixed(2),
                        "y": Data.Mes.Total_Datos.Pc_Cierre,
                    }
                ]
            };
        };
        var Type = 'spline';
        var options3d = { enabled: false, };
        if (Data.Mes.Categorias.length <= 4) {
            Type = 'column';
            $_$('#Container_Graficos').width('50%');
            options3d = {
                enabled: true,
                alpha: 5,
                beta: 25,
            };
        };
        $_$('#Container_Graficos').highcharts({
            chart: {
                type: '',
                backgroundColor: '#EEE',
                options3d: options3d,
            },
            title: {
                text: 'Indicadores del mes actual',
                style: {
                    fontWeight: 'bold',
                    fontFamily: 'FuenteKamilion',
                    color: '#B3C556',
                    textShadow: '-2px -2px 1px #000',
                    fontSize: '25px'
                },
            },
            labels: {
                items: [
                    {
                        html: 'Puesto: ' + Data.Mes.Total_Datos.Rank,
                        style: {
                            left: '20%',
                            top: '0px',
                            fontSize: '18px'
                        }
                    }
                ]
            },
            tooltip: {
                valueSuffix: ' %',
                valueDecimals: 2,
                shared: true
            },
            plotOptions: {
                pie: {
                    allowPointSelect: true,
                    depth: 10,
                },
                series: {
                    point: {
                        events: {
                            click: function (e) {
                                if (this.series.type != 'pie') {
                                    if ($_$('.' + this.category).length > 0) {
                                        hs.close(
                                            $_$('.' + this.category).this
                                        );
                                        $_$('.' + this.category).remove();
                                    };
                                    hs.htmlExpand(null, {
                                        pageOrigin: {
                                            x: e.pageX || e.clientX,
                                            y: e.pageY || e.clientY
                                        },
                                        wrapperClassName: 'Wrapper-' + this.category,
                                        headingText: '<span style="font-family: FuenteKamilion; font-size: 125%; color: #B3C556; text-shadow:-1px -1px 0.5px #000; text-align: center;">Productividad del día ' + this.category + '</span>',
                                        maincontentText: '<table class="' + this.category + '" style="width:100%; height:450px;"></table>',
                                    });
                                    Graficar_Dia(this.category);
                                };
                            },
                        },
                    },
                },
            },
            xAxis: {
                categories: Data.Mes.Categorias,
            },
            series: [
                    {
                        type: 'column',
                        name: 'Calidad',
                        data: Data.Mes.Datos_Pc.Calidad,
                        color: Highcharts.getOptions().colors[4],
                    },
                    {
                        type: 'column',
                        name: 'Atención',
                        data: Data.Mes.Datos_Pc.Atencion,
                        color: Highcharts.getOptions().colors[0],
                    },
                    {
                        type: 'column',
                        name: 'Gestión',
                        data: Data.Mes.Datos_Pc.Gestion,
                        color: Highcharts.getOptions().colors[1],
                    },
                    {
                        type: 'column',
                        name: 'Solución',
                        data: Data.Mes.Datos_Pc.Solucion,
                        color: Highcharts.getOptions().colors[2],
                    },
                    {
                        type: 'column',
                        name: 'Cierre',
                        data: Data.Mes.Datos_Pc.Cierre,
                        color: Highcharts.getOptions().colors[3],
                    },
                    {
                        type: Type,
                        name: 'Efectivos',
                        data: Data.Mes.Datos_Pc.Efectivos,
                        color: '#B3C556',
                    },
                    {
                        type: Type,
                        name: 'Tocados',
                        data: Data.Mes.Datos_Pc.Tocados,
                        color: Highcharts.getOptions().colors[1],
                    },
                    {
                        type: Type,
                        name: 'Promedio Efectivos & Tocados',
                        data: Data.Mes.Datos_Pc.Prom_ET,
                        color: "#827C51",
                    },
                    {
                        type: Type,
                        name: 'Adherencia',
                        data: Data.Mes.Datos_Pc.Adh,
                        color: Highcharts.getOptions().colors[5],
                    },
                    {
                        type: Type,
                        name: 'Cumplimiento',
                        data: Data.Mes.Datos_Pc.Cumplimiento
                    },
                    {
                        type: 'pie',
                        name: 'Promedio',
                        size: '10%',
                        innerSize: '65%',
                        dataLabels: { enabled: false },
                        endAngle: ((((Data.Mes.Total_Datos.Pc_Efectivos + Data.Mes.Total_Datos.Pc_Tocado) * 100) / (Data.Mes.Total_Datos.Pc_Efectivos + Data.Mes.Total_Datos.Pc_Tocado + (Data.Mes.Total_Datos.Adh_Pc * 2))) / 100) * 360,
                        center: ['85%', '0%'],
                        data: [
                                {
                                    name: "Efectivos",
                                    y: Data.Mes.Total_Datos.Pc_Efectivos,
                                    color: '#B3C556'
                                },
                                {
                                    name: "Tocados",
                                    y: Data.Mes.Total_Datos.Pc_Tocado,
                                    color: Highcharts.getOptions().colors[1]
                                }
                        ]
                    },
                    {
                        type: 'pie',
                        name: 'Promedio',
                        allowPointSelect: false,
                        size: '3%',
                        center: ['85%', '0%'],
                        data: [
                            {
                                name: "Efectivo & Tocado",
                                y: (Data.Mes.Total_Datos.Pc_Tocado + Data.Mes.Total_Datos.Pc_Efectivos) / 2,
                                color: "#827C51",
                            },
                            {
                                name: "Adherencia",
                                y: Data.Mes.Total_Datos.Adh_Pc,
                                color: Highcharts.getOptions().colors[5],
                            },
                        ],
                        dataLabels: {
                            color: '#fff',
                            distance: 15,
                            rotatiín: 5,
                            style: { fontSize: "11px" }
                        }
                    },
                Data_Pie_03,
                Data_Pie_02
            ]
        });
    };
    function Graficar_Dia(Container) {
        $_$("." + Container).highcharts({
            chart: {
                type: 'column',
                options3d: {
                    enabled: true,
                    alpha: 5,
                    beta: 25,
                },
            },
            xAxis: {
                categories: Data.Dia[Container].Bandeja
            },
            labels: {
                items: [
                    {
                        html: 'Total Efectivos:' + Data.Dia[Container].Total_Efec,
                        style: {
                            left: '0%',
                            top: '-10%',
                        }
                    },
                    {
                        html: 'Total Tocados:' + Data.Dia[Container].Total_Toc,
                        style: {
                            left: '0%',
                            top: '5%',
                        }
                    }
                ]
            },
            title: {
                text: 'Puesto: ' + Data.Dia[Container].Rank,
                style: {
                    fontSize: '15px'
                }
            },
            tooltip: {
                valueSuffix: ' %',
                valueDecimals: 2,
            },
            series: [
                {
                    color: '#B3C556',
                    type: 'column',
                    name: 'Efectivos',
                    data: Data.Dia[Container].Pc_Efectivo,
                },
                {
                    type: 'column',
                    name: 'Tocados',
                    data: Data.Dia[Container].Pc_Tocado,
                    color: Highcharts.getOptions().colors[1],
                },
            ]
        });
    };
};

