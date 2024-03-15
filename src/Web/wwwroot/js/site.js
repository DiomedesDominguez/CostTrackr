$(document).ready(function () {
    // Call the Usuario internal Web API to set the user's name in _Sidebar.cshtml
    $.ajax({ url: "usuario" }).then(function (data) {
        // Tal vez deba de usar otro tipo de identificador para los campos del sidebar, problema para el Diomedes del futuro
        $(".usuario").text(data.name);
        $(".correo").text(data.email);
    });

});