function get() {
    $.ajax({
        type: "GET",
        dataType: "jsonp",
        url: "/api/jobtitles",
        success: function (data) {
            alert(data);
        }
    });
}