var btnEnviar = document.getElementById("btnContato");
var alertaErro = "alert-danger";
var alertWarning = "alert-warning";
var alertSuccess = "alert-success";


btnEnviar.addEventListener("click", function () {
    event.preventDefault();

    var retorno = validaForm();
    var mensagens = [];

    if (!retorno) {
        return;
    }

    var form = document.getElementById("contatoForm");
    var e = event;
    target = e.target;
    var nome = document.getElementById("nome").value;
    var email = document.getElementById("email").value;
    var telefone = document.getElementById("telefone").value;
    var contatoWhatsapp = document.getElementById("contatoWhatsapp").value;
    var mensagem = document.getElementById("mensagem").value;

    var contato = {
        Id: "0",
        Nome: nome,
        Mensagem: mensagem,
        Email: email,
        Telefone: telefone,
        ContatoWhatsapp: contatoWhatsapp,
        DataHora: Date.now(),
        Pendente: true
    }

    var url = "/" + $(target).data('controller') + "/" + $(target).data('action');

    $.ajax({
        type: "post",
        url: url,
        data: contato,
        datatype: "json",
        cache: false,
        success: function (data) {

            if (data == "OK") {
                mensagens.push("Obrigado, em breve entraremos em contato :)");
                ExibeAlertaContato(alertSuccess, mensagens);
                form.reset();
            }
            else if (data == "ErroModelo") {
                mensagens.push("Por favor, verifique se todos os campos do formulário foram preenchidos corretamente.");

                ExibeAlertaContato(alertaErro, mensagens);
            }
            else {
                mensagens.push("Houve um erro no registro do seu contato, por favor, tente novamente mais tarde");
                ExibeAlertaContato(alertaErro, mensagens);
            }
        },
        error: function (xhr) {
            ExibeAlertaContato(alertaErro, "");
        }
    });
});


function ExibeAlertaContato(tipo, mensagens) {

    var ul = document.getElementById("textoAlerta");

    mensagens.forEach(function (erro) {
        console.log(erro);
        var li = document.createElement("li");
        li.textContent = erro;
        ul.appendChild(li);
    });

    var alertBox = document.getElementById('alertaDiv');
    alertBox.classList.add("invisivel");
    alertBox.classList.remove("invisivel");
    alertBox.classList.add(tipo);

    setTimeout(function () {
        alertBox.classList.add("invisivel");
        ul.innerHTML = "";
    }, 5000);
}

function validaForm() {
    var Nome = document.getElementById('nome').value;
    var Email = document.getElementById('email').value;
    var Telefone = document.getElementById('telefone').value;
    var Mensagem = document.getElementById('mensagem').value;
    var padraoEmail = /[A-Z0-9._%+-]+@[A-Z0-9.-]+.[A-Z]{2,4}/igm;
    var padraoTel = /\+\d{2}\s\(\d{2}\)\s\d{4,5}-?\d{4}/g;


    var errors = [];
    if (Nome == "") {
        errors.push("Por favor, informe o nome.");
    }

    if (Email == "" || !padraoEmail.test(Email)) {
        errors.push("Por favor, informe um e-mail válido.");
    }

    //if (Telefone == "" || !padraoTel.test(Telefone)) {
    //    errors.push("Por favor, informe Telefone válido. Ex. ()");
    //}

    //if (Telefone == "" || !isNaN(Telefone)) {
    if (Telefone == "") {
        errors.push("Por favor, informe Telefone válido. Ex. (11)9-1234-5678");
    }

    if (Mensagem == "") {
        errors.push("Por favor, informe a mensagem que deseja nos enviar");
    }

    if (errors.length) {
        ExibeAlertaContato(alertaErro, errors);
        return false;
    }
    else {
        return true;
    }

};