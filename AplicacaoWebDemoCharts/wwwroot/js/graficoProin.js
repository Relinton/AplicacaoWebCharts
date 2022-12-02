$(document).ready(function () {
    $.ajax({
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: 'https://localhost:44339/Dashboard/ObterTodosParaProin',
        error: function () {
            alert("Ocorreu um erro ao consultar os dados");
        },
        success: function (data) {
            GraficoProin(data);
        }
    })
});

function GraficoProin(data) {
    Highcharts.chart('grafico-proin', {
        chart: {
            plotBackgroundColor: null,
            plotBorderWidth: null,
            plotShadow: false,
            type: 'pie'
        },
        title: {
            text: 'Percentual de Implantação PROIN por Unidade'
        },
        tooltip: {
            pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
        },
        accessibility: {
            point: {
                valueSuffix: '%'
            }
        },
        plotOptions: {
            pie: {
                allowPointSelect: true,
                cursor: 'pointer',
                dataLabels: {
                    enabled: false
                },
                showInLegend: true
            }
        },
        series: [{
            name: 'Programa',
            colorByPoint: true,
            data: data
        }]
    });
}

