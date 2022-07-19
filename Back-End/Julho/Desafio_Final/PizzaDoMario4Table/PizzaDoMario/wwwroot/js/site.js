// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//setInterval(() => {
//    var subTotal = document.getElementById('subTotal');
//    if (subTotal != null) {
//        var preco = document.getElementById('preco');
//        var quantidade = document.getElementById('quantidade');
//        if (preco.value != '' && quantidade.value != '') {
//            subTotal.value = parseInt(preco.value) * parseInt(quantidade.value);
//        }
//    }
//}, 500)

$(document).ready(function () {
    $('#tabela').DataTable();
});