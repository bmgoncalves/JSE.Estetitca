$(document).ready(function () {
    $(".btn-excluir").click(function (e) {
        var resultado = confirm("Tem certeza que deseja realizar esta operação?");

        if (resultado == false) {
            e.preventDefault();
        }
    });

    TriggerAlertClose();

   // $('.dinheiro').mask('000.000.000.000.000,00', { reverse: true });

    //AjaxUploadImagemProduto();
});

function TriggerAlertClose() {
    window.setTimeout(function () {
        $(".alert").fadeTo(1000, 0).slideUp(1000, function () {
            $(this).remove();
        });
    }, 5000);
}