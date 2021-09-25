$(function () {

    $("#btn1").click(function(){
        alert('toque el btn');
    });
    $("#BtnEliminar").click(function () {
        console.log("asda");
        $('#MyModal').modal('show');
        $('#TituloModal').text('Eliminar esto');
        $('#Texto').html('<strong>Esta seguro que sea eliminar?</strong>');
        $('#BtnAceptar').text('Aceptar');
        $('#BtnCancelar').text('Cancelar');
    });
    $("#BtnCancelar").click(function () {
        console.log("BtnCancelar");

        $('#MyModal').modal('hide');
    });
    $("#BtnAceptar").click(function () {
        console.log("BtnAceptar");
        $('#MyModal').modal('hide');
    });
    // aca falta que me tire el id del producto para poder hacer la baja o lo que quiera. 
    $("#BtnId").click(function () {
        var idtr = $(this).attr('Codigo');
        console.log(idtr);
        
    });
    
});