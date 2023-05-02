function onInsertGrid(e) {
    console.log(e);
    var values = JSON.stringify(e.data)
    console.log(values);
    $.ajax({
        url: "/api/Addresses/Create",
        dataType: "json",
        data: values,
        type: "POST"
    });
}