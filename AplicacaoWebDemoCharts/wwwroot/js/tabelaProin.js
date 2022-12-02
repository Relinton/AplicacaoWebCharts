$(document).ready(function () {
    //Chama o método ObterTodosParaProin que vai retornar o JSON
    $.getJSON("/Dashboard/ObterTodosProinParaGraficoDeBarra",
        function (json) {
            var tr;
            //Anexa cada linha na tabela HTML
            for (var i = 0; i < json.length; i++) {
                tr = $('<tr/>');
                tr.append("<td>" + json[i].secretaria + "</td>");
                tr.append("<td>" + json[i].adesaoDesignacao + "</td>");
                tr.append("<td>" + json[i].elaboracaoValidacao + "</td>");
                tr.append("<td>" + json[i].gestaoRiscos + "</td>");
                tr.append("<td>" + json[i].monitoramento + "</td>");
                tr.append("<td>" + json[i].porcentagem + "</td>");
                tr.append("<td>" + json[i].dataAdesao + "</td>");
                tr.append("<td>" + json[i].dataRegistro + "</td>");
                $('table').append(tr);
            }
        });
});