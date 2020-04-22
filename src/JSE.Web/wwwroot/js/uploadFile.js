var input = document.getElementById('inputFiles'),
    filename = document.getElementById('file-name'),
    imgUpload = document.getElementById('blah'),
    imgPadrao = imgUpload.baseURI + "img/80x80.png",
    inputNomeCliente = document.getElementById('NomeCliente'),
    inputTelefone = document.getElementById('TelefoneCelular'),
    inputEmail = document.getElementById('Email'),
    inputMensagem = document.getElementById('Descricao');

var alertaErro = "alert-danger",
    alertWarning = "alert-warning",
    alertSuccess = "alert-success";

$(function () {

    $("#uploadBtn").click(function (evt) {
        evt.preventDefault();

        var mensagens = [];

        var fileupload = $("#inputFiles").get(0);
        var files = fileupload.files;
        var data = new FormData();

        for (var i = 0; i < files.length; i++) {
            data.append("files", files[i]);
        }

        var other_data = $('#formUpload').serializeArray();
        $.each(other_data, function (key, input) { //append other input value
            data.append(input.name, input.value);
        });

        $.ajax({
            type: "post",
            url: "/Home/Depoimento",
            contentType: false,
            processData: false,
            data: data,
            success: function (retorno) {
                mensagens.push(retorno.message);
                ExibeAlerta(alertSuccess, mensagens);

            },
            error: function () {
                mensagens.push("Erro ao tentar postar depoimento, por favor, tente novamente mais tarde.");
                ExibeAlerta(alertSuccess, mensagens);
            }
        });
    });
});


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

function ExibeAlerta(tipo, mensagens) {

    var ul = document.querySelector("#textoAlerta");
    var $modal = $('#modalDepoimentoForm');

    mensagens.forEach(function (erro) {
        var li = document.createElement("li");
        li.textContent = erro;
        ul.appendChild(li);
    });

    var alertBox = document.querySelector('#alertaDiv');
    alertBox.classList.add("invisivel");
    alertBox.classList.remove("invisivel");
    alertBox.classList.add(tipo);

    setTimeout(function () {
        alertBox.classList.add("invisivel");
        ul.innerHTML = "";

        //when hidden
        $modal.on('hidden.bs.modal', function (e) {
            return this.render(); //DOM destroyer
        });
        $modal.modal('hide'); //start hiding

    }, 5000);



}


//input.addEventListener('change', function () {
//    filename.textcontent = this.value;
//});




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