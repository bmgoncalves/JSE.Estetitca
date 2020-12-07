$(document).ready(function () {
    $(".btn-excluir").click(function (e) {
        var resultado = confirm("Tem certeza que deseja realizar esta operação?");

        if (resultado == false) {
            e.preventDefault();
        }
    });

    TriggerAlertClose();

    $('.dinheiro').mask('000.000.000.000.000,00', { reverse: true });
    $('.celphone').mask('00-0-0000-0000', { reverse: true });
    $('.phone').mask('0000-0000', { reverse: true });
    $('.cep').mask('00000-000', { reverse: true });
    $('.cnpj').mask('99.999.999/9999-99');

    //AjaxUploadImagemProduto();
});

function TriggerAlertClose() {
    window.setTimeout(function () {
        $(".alert").fadeTo(1000, 0).slideUp(1000, function () {
            $(this).remove();
        });
    }, 5000);
}