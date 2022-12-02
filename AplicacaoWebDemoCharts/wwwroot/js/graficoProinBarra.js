$(document).ready(function () {
    //Peticion a API
    $.ajax({
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: 'https://localhost:44339/Dashboard/ObterTodosParaProin',
        error: function () {
            alert("Ocorreu um erro ao consultar os dados");
        },
        success: function (data) {
            GraficaBarras(data);
        }
    })
});

function GraficaBarras(data) {
    Highcharts.chart('grafico-proin-barra', {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Percentual de Implantação PROIN por Unidade'
        },
        subtitle: {
            text: 'Fonte: <a href="http://en.wikipedia.org/wiki/List_of_cities_proper_by_population">Wikipedia</a>'
        },
        xAxis: {
            type: 'category',
            labels: {
                rotation: -45,
                style: {
                    fontSize: '13px',
                    fontFamily: 'Verdana, sans-serif'
                }
            }
        },
        yAxis: {
            min: 0,
            title: {
                text: 'Definição (porcentagem)'
            }
        },
        legend: {
            enabled: false
        },
        tooltip: {
            pointFormat: 'Programa de Integridade: <b>{point.y:.1f} porcento</b>'
        },
        series: [{
            name: 'Programa',
            data: data,
            dataLabels: {
                enabled: true,
                rotation: -90,
                color: '#FFFFFF',
                align: 'right',
                format: '{point.y:.1f}', // one decimal
                y: 10, // 10 pixels down from the top
                style: {
                    fontSize: '13px',
                    fontFamily: 'Verdana, sans-serif'
                }
            }
        }]
    });
}