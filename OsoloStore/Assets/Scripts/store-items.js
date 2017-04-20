$(document).ready(function () {
    $('.store-button--get-items').on('click', function () {
        var url = '/Item/Get';
        $('#store-item-list').load(url);
    });

    $(document).on('click', '.store-button--add-item', function () {
        $('#store-item-list--status').show();
        var _itemId = $(this).data('item-id');
        $.post("/Basket/Add", { id: _itemId })
        .done(function (data) {
            $('#store-item-list--status').hide();
            toastr.success('Tillagd i varukorgen');
        });
    });
});