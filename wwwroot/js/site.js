// Consumir

errorFormulario = document.querySelector('.span_error'),


document.getElementById('makeRequestCard').onclick = function(){
    console.log("estamos en la función de tokenización");
    OpenPay.setId("merchant ID");
    OpenPay.setApiKey("Llave publica");
    OpenPay.setSandboxMode(true);   

    var status = OpenPay.getSandboxMode();
    console.log(status);

    OpenPay.token.extractFormAndCreate($('#formulario-tarjeta'),SuccessCallback, ErrorCallback);
}

function SuccessCallback(response) {
    alert('Operación exitosa');
    var content = '';
    var deviceSessionId = OpenPay.deviceData.setup();

    content += 'Id tarjeta: ' + response.data.id+ '';
    content += 'A nombre de: ' + response.data.card.holder_name + '';
    content += 'Marca de tarjeta usada: ' + response.data.brand + '';
    console.log(content);
    console.log(deviceSessionId);
    tokenizacion(response.data.id,deviceSessionId);
}
function ErrorCallback(response) {
    var content = '';
    document.getElementById("errorFormulario").classList.add("errorFormulario_true");   
    content += 'Estatus del error: ' + response.data.status + '';
    content += 'Error: ' + response.message + '';
    content += 'Descripción: ' + response.data.description + '';
    content += 'ID de la petición: ' + response.data.request_id + '';
    console.log(content);
    errorFormulario.textContent = content;

    setTimeout(function(){
        document.getElementById("errorFormulario").classList.remove("errorFormulario_true");
    }, 5000);

}

function tokenizacion(token,deviceSessionId) 
{

    $.ajax({
        type: "POST",
        url: "/Openpay/Openpaycard?token="+token+"&deviceSessionId="+deviceSessionId,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        traditional: true
    });
}