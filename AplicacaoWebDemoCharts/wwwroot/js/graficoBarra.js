$(document).ready(function () {
    //Peticion a API
    $.ajax({
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: urlBase + '/ObterNavegadoresParaGraficoDeBarra',
        error: function () {
            alert("Ocorreu um erro ao consultar os dados");
        },
        success: function (data) {
            GraficaBarras(data);
        }
    })
});

function GraficaBarras(data) {
    Highcharts.chart('grafico-navegadores-barra', {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Navegadores mais utilizados em 2022'
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
                text: 'Cantidad (millions)'
            }
        },
        legend: {
            enabled: false
        },
        tooltip: {
            pointFormat: 'Navegadores mais utilizados em 2022: <b>{point.y:.1f} millions</b>'
        },
        series: [{
            name: 'Navegadores',
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