$(document).ready(function () {
    $("#seach-ticket").click(function () {
        searchTicketNumber();
    })

    $('#search-ticket-field').keypress(function (e) {
        if (e.which == 13) {
            searchTicketNumber();
        }
    });

    function searchTicketNumber() {
        var search_number = $("#seach-ticket").siblings("input")[0].value.trim();
        if (search_number == "") {
            $(".ticket-number").css("background-color", "");
            return $("#congrat").html("Congrats:");
        }
        var win_the_prize = false;

        $.each($(".ticket-number"), function (index, element) {
            var ticket_number = element.innerHTML
            if (Number(search_number) == ticket_number) {
                win_the_prize = true;
                var account = $("#ticket-" + ticket_number).closest("tr").find(".account").html();
                $("#congrat").html("Congrats: " + account + "^^! - " + ticket_number);
                $("#ticket-" + ticket_number).css("background-color", "yellow");
            } else {
                $("#ticket-" + ticket_number).css("background-color", "");
            }
        });
        if (!win_the_prize)
            $("#congrat").html("No one gets the prize :(");
    }
})