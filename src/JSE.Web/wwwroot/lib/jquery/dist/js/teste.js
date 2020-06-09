﻿var input = document.querySelector("#inputFiles");
var filename = document.querySelector("#file-name");
var inputServicoId = document.querySelector("#servicoId");
var valServicoId = "";

input.addEventListener('change', function () {
    filename.textcontent = this.value;
});

$(document).ready(function () {
    valServicoId = inputServicoId.value;
    $.ajax({
        type: "GET",
        url: "/Admin/Galeria/ListaServicos",
        data: { userId: Id },
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (dados) {
            var html_code = '<option value = "-1"> Selecione o serviço</option>';
            $(dados).each(function (i) {
                html_code += '<option value="' + dados[i].servicoId + '">' + dados[i].nomeServico + '</option>';
            });

            $('#servicoCB').html(html_code);
            setSelectBoxById();
        },
        error: function (response) {
            alert('Erro ao carregar serviços');
        }
    });
});


function setSelectBoxById() {
    var i;
    var ddl = document.getElementById('servicoCB');

    if (inputServicoId.value == '-1') {
        return;
    }

    for (i = 0; i < ddl.options.length; i++) {
        if (ddl.options[i].value == inputServicoId.value) {
            ddl.selectedIndex = ddl.options[i].index;
        }
    }
}

$(document).on('change', '#servicoCB', function () {
    //inputServicoId.val($(this).children("option:selected").val());
    inputServicoId.value = $(this).children("option:selected").val();
});