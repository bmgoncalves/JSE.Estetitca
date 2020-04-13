//<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js" />
//$(document).ready(function () {
//    $("#btnContato").click(function () {
//        $("#myAlert").alert('close');
//    });
//});

var btnEnviar = document.querySelector("#btnContato");


btnEnviar.addEventListener("click", function () {
    event.preventDefault();
    alert("Cliquei no botão enviar");
});

    