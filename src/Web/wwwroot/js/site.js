$(document).ready(function () {
    // Call the Usuarios Web API to set the user's name in _Sidebar.cshtml
    $.ajax({ url: "/usuario" }).then(function (data) {
        $(".usuario").text(data.name);
        $(".correo").text(data.email);
    });

});