function onInsertGrid(e,controller) {

    $.post(window.origin + "/api/" + controller, e.data, function (data) {       
        window.location.reload();

    });

}

