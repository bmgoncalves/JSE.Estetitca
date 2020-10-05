$(document).ready(function () {

    AjaxUploadImagemProduto();
});

function AjaxUploadImagemProduto() {
    $(".img-upload2").click(function () {
        $(this).parent().parent().find(".input-file").click();
    });
        

    $(".input-file").change(function () {
        var Imagem = $(this).parent().find(".img-upload2");
        const file = $(this)[0].files[0];
        const fileReader = new FileReader();
        fileReader.onloadend = function () {
            Imagem.attr("src", fileReader.result)
        }
        fileReader.readAsDataURL(file)
    });
}

