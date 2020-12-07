var Id;
var controller;
var action;
var bodyMessage;
var area;


$('#deleteModal').on('shown.bs.modal', function () {
    $('#meuInput').trigger('focus')
});


$((function () {
    var url;
    var redirectUrl;
    var target;

    //$('body').append(`
    //        <div class="modal fade" id="deleteModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
    //        <div class="modal-dialog" role="document">
    //            <div class="modal-content">
    //            <div class="modal-header">
    //                <h4 class="modal-title" id="myModalLabel">Atenção!</h4>
    //                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
    //            </div>
    //            <div class="modal-body delete-modal-body">
    //                <h4 id="messageError">texto de retorno de erro </h4>
    //            </div>
    //            <div class="modal-footer">
    //                <button type="button" class="btn btn-default" data-dismiss="modal" id="cancel-delete">Cancel</button>
    //                <button type="button" class="btn btn-danger" id="confirm-delete"  onclick="executedelete()" >Delete</button>
    //            </div>
    //            </div>
    //        </div>
    //        </div>`);


    $('banana').append(`
            <div class="modal" id="deleteModal" tabindex="-1" role="dialog">
              <div class="modal-dialog" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title">Modal title</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                    </button>
                  </div>
                  <div class="modal-body">
                    <p>Modal body text goes here.</p>
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                  </div>
                </div>
              </div>
            </div>`);



    //Delete Action
    $(".delete").on('click', (e) => {
        e.preventDefault();

        target = e.target;
        Id = $(target).data('id');
        controller = $(target).data('controller');
        action = $(target).data('action');
        area = $(target).data('area');
        bodyMessage = $(target).data('body-message');
        redirectUrl = $(target).data('redirect-url');

        url = "/" + controller + "/" + action + "?Id=" + Id;
        $(".delete-modal-body").text(bodyMessage);
        $("#deleteModal").modal();
        //$("#deleteModal").modal('show');
        $("#messageError").hide();
    });

}()));

var executedelete = function () {

    var itemId = $("#hiddenItemId").val();
    var urlPadrao;

    if (area != "") {
        urlPadrao = "/" + area + "/" + controller + "/" + action + "/" + itemId;
    }
    else {
        urlPadrao = "/" + controller + "/" + action + "/" + itemId;
    }


    $(".delete-modal-body").text(bodyMessage);

    $("#loaderDiv").show();

    $.ajax({
        type: 'POST',
        url: urlPadrao,
        //url: "/" + controller + "/" + action + "/" + itemId,

        data: { ItemId: itemId },
        dataType: "json", contentType: "application/json; charset=utf-8",
        success: function (data) {
            if (data == "success") {
                $("#deleteModal").modal("hide");
                $("#row_" + itemId).remove();
            }
            else {
                $(".delete-modal-body").text(data.Message);
            }

        },
        error: function (xhr) {
            $(".delete-modal-body").text(xhr.responseText);
        }
    });

}

var confirmdelete = function (ItemId) {
    $("#hiddenItemId").val(ItemId);
}
