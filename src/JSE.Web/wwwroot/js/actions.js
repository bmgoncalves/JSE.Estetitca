﻿$(document).ready(function () {
    $(".btn-excluir").click(function (e) {
        var resultado = confirm("Tem certeza que deseja realizar esta operação?");

        if (resultado == false) {
            e.preventDefault();
        }
    });
   // $('.dinheiro').mask('000.000.000.000.000,00', { reverse: true });

    //AjaxUploadImagemProduto();
});