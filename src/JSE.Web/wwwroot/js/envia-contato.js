var btnEnviar = document.querySelector("#btnContato");

btnEnviar.addEventListener("click", function () {
    event.preventDefault();
    var form = document.querySelector("#contatoForm");

    console.log(form.valid());

    var e = event;
    target = e.target;
    var nome = document.querySelector("#nome").value;
    var email = document.querySelector("#email").value;
    var telefone = document.querySelector("#telefone").value;
    var contatoWhatsapp = document.querySelector("#contatoWhatsapp").value;
    var mensagem = document.querySelector("#mensagem").value;

    var contato = {
        Id: "",
        Nome: nome,
        Email: email,
        Telefone: telefone,
        ContatoWhatsapp: contatoWhatsapp,
        Mensagem: mensagem
    }

    var url = "/" + $(target).data('controller') + "/" + $(target).data('action');
    var mensagem;

    $.ajax({
        type: "post",
        url: url,
        data: contato,
        datatype: "json",
        cache: false,
        success: function (data) {

            if (data == "OK") {
                ExibeAlerta("alert-success", mensagem);
                form.reset();                
            }
            else {
                ExibeAlerta("alert-danger", mensagem);
            }
        },
        error: function (xhr) {
            ExibeAlerta("alert-danger", mensagem);
        }
    });
});



function ExibeAlerta(tipo, mensagem) {

    var bodyDiv = $('.alertDiv');

    bodyDiv.empty();

    if (tipo == "alert-danger") {
        bodyDiv.append(`<div id="alert-box" class="alert alert-danger  alert-dismissible" role="alert">
            <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
            <div class="message-alert">
            <strong>Erro! </strong> Houve um erro no registro do seu contato, por favor, tente novamente mais tarde. 
            </div>
            </div>`);

    }
    else {
        bodyDiv.append(`<div id="alert-box" class="alert alert-success  alert-dismissible" role="alert">
            <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
            <div class="message-alert">
            <strong>Obrigado, </strong>em breve entraremos em contato :) 
            </div>
            </div>`);
    }


    bodyDiv.removeClass("invisivel");
    setTimeout(function () {
        bodyDiv.addClass("invisivel");
    }, 4000);

}