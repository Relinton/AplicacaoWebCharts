
$(document).ready(function () {
    $.ajax({
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: urlBase +'/ObterNavegadores',
        error: function () {
            alert("Ocorreu um erro ao consultar os dados");
        },
        success: function (data) {
            GraficoTorta(data);
        }
    })
});

function GraficoTorta(data) {
    Highcharts.chart('grafico-navegadores-pizza', {
        chart: {
            plotBackgroundColor: null,
            plotBorderWidth: null,
            plotShadow: false,
            type: 'pie'
        },
        title: {
            text: 'Navegadores mais utilizados em 2022'
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
            name: 'Navegadores',
            colorByPoint: true,
            data: data
        }]
    });
}

