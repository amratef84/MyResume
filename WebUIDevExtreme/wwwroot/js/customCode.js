function onInsertGrid(e,controller) {
    console.log(e);
    console.log(controller);
    var values = JSON.stringify(e.data)
    console.log(values);
    console.log(window);
    console.log(window.URL);
    $.post(window.origin + "/api/" + controller, e.data);
   // var deferred = $.Deferred();
   //return $.ajax({
   //     url: window.origin+"/api/" + controller,
   //     method: "POST",
   //     data: values
   // })
   //     .done(deferred.resolve)
   //     .fail(function (e) {
   //         deferred.reject("Insertion failed");
   //     });
   // console.log(values);
   // return deferred.promise();
}

