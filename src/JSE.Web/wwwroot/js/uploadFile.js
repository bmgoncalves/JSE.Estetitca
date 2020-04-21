var input = document.getElementById('input-file'),
    filename = document.getElementById('file-name'),
    imgUpload = document.getElementById('blah'),
    imgPadrao = imgUpload.baseURI + "img/80x80.png",
    inputNomeCliente = document.getElementById('NomeCliente'),
    inputTelefone = document.getElementById('TelefoneCelular'),
    inputEmail = document.getElementById('Email'),
    inputMensagem = document.getElementById('Descricao');

function initImage() {
    if (input.files) {
        var filesAmount = input.files.length;

        $(imgUpload).empty(); // remove as imagens antigas
        for (i = 0; i < filesAmount; i++) {
            var reader = new FileReader();
            reader.onload = function (event) {
                $($.parseHTML('<img>')).attr('src', event.target.result)
                    .appendTo(imgUpload);
            }
            reader.readAsDataURL(input.files[i]);
        }
    }
    //Limpar campos
    input.value = "";
    inputNomeCliente.value = "";
    inputTelefone.value = "";
    inputEmail.value = "";
    inputMensagem.value = "";
    imgUpload.currentSrc = imgUpload.baseURI + "img/80x80.png";
    imgUpload.src = imgUpload.baseURI + "img/80x80.png";
}

input.addEventListener('change', function () {
    filename.textcontent = this.value;
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#blah')
                .attr('src', imgPadrao); //Limpar memoria com imagem padrao


            $('#blah')
                .attr('src', e.target.result);
        };

        reader.readAsDataURL(input.files[0]);

    }
}