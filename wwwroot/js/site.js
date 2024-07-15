function showInPopup(url, title) {
    $.ajax({
        type: "GET",
        url: url,
        beforeSend: function () {
            $("#loader").show();
        },
        success: function (res) {
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(title);
            $("#form-modal").modal('show');
        },
        complete: function () {
            $("#loader").hide();
        },
        error: function (err) {
            console.log("Error: ", err);
            $("#loader").hide();
        }
    });
}

function JQueryAjaxPost(form) {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            beforeSend: function () {
                $("#loader").show();
            },
            success: function (res) {
                if (res.isValid) {
                    $("#view-all").html(res.html);
                    $("#form-modal .modal-body").html('');
                    $("#form-modal .modal-title").html('');
                    $("#form-modal").modal('hide');
                    $.notify("Operation completed successfully!", "success"); // Notify success
                } else {
                    $("#form-modal .modal-body").html(res.html);
                    $.notify("Validation error!", "warn"); // Notify validation error
                }
            },
            complete: function () {
                $("#loader").hide();
            },
            error: function (err) {
                console.log("Error: ", err);
                $.notify("An error occurred!", "error"); // Notify error
                $("#loader").hide();
            }
        });
    } catch (e) {
        console.log(e);
        $("#loader").hide();
    }
    return false;
}
