$(document).ready(function () {
    $("#new-ticket").click(function () {
        $("<div class='form-group'> <label class='control-label'>Ticket number: </label> <div style='display: flex'> <input name='ticketNumbers' class='form-control' /> <button type='button' class='btn btn-danger delete-ticket'>Delete</button> </div> </div>").insertBefore("#form-group-btn");
    });

    $(".delete-ticket").click(function () {
        $(this).closest(".form-group").remove();
    })
});