$('#btnContato').click(function () {
    event.preventDefault();

    var telefone = $("#telefone").val().replace('-','');

    var contato = {
        ContatoId: null,
        Nome: $("#nome").val(),
        Mensagem: $("#mensagem").val(),
        Email: $("#email").val(),
        Telefone: telefone.replace("-",""),
        ContatoWhatsapp: $("#contatoWhatsapp").val(),
        DataHora: $.now,        
        Pendente: true
    }

    var retorno = validaForm(contato);

    if (!retorno) {
        return;
    }

    //TESTE URL
    var url = "";
    if (document.baseURI.endsWith("/")) {
        url = document.baseURI + "Home/RegistraContato";
    }
    else {
        url = document.baseURI + "/Home/RegistraContato";
    }
        

    $.ajax({
        type: "get",
        url: url,        
        data: contato,
        datatype: "json",
        cache: false,
        success: function (data) {
            if (data == "OK") {
                alert("Contato enviado com sucesso!");
                
                $("#contatoForm").each(function () {
                    this.reset();
                });
            }
            else {
                alert("Não foi possivel enviar o contato, tente novamente mais tarde.");
            }
        }
    });

});

function validaForm(contato) {

    var padraoEmail = /[A-Z0-9._%+-]+@[A-Z0-9.-]+.[A-Z]{2,4}/igm;

    var errors = [];

    if (contato.Nome == "") {
        errors.push("Por favor, informe o nome.");
    }

    if (contato.Email == "" || !padraoEmail.test(contato.Email)) {
        errors.push("Por favor, informe um e-mail válido.");
    }

    if (contato.Telefone == "") {
        errors.push("Por favor, informe Telefone válido. Ex. (11)9-1234-5678");
    }

    if (contato.Mensagem == "") {
        errors.push("Por favor, informe a mensagem que deseja nos enviar");
    }

    if (errors.length) {
        ExibeAlertaContato(errors);
        return false;
    }
    else {
        return true;
    }

};


function ExibeAlertaContato(mensagens) {

    var erros = "";
    
    $.each(mensagens, function (key, value) {
        if (erros == "") {
            erros = value;
        }
        else {
            erros += "\n" + value;
        }
    });

    if (erros != "") {
        alert(erros);
    }
    else {
        alert("Contato enviado com sucesso!");
    }
}