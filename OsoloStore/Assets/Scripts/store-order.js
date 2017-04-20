$(document).ready(function () {
    $('.store-button--order-save').on('click', function () {
        $.get("/Order/Add")
        .done(function (data) {
            toastr.success('Order skapad');
        });
    });
});