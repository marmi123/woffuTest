function get() {
    $.ajax({
        type: "GET",
        contentType: "application/json",
        dataType: 'json',
        url: "/api/jobtitles",
        success: function (data) {
            $('#tbJob').find("tr:gt(0)").remove();
            for (var i = 0; i < data.length; i++) {
                var row = data[i];
                $('#tbJob').append('<tr id="jobrow"><td>' + row.JobTitleId + '</td><td>' + row.Name + '</td><td>' + row.CompanyId + '</td></tr>');
            }
        }
    });
}
function getId() {
    $.ajax({
        type: "GET",
        contentType: "application/json",
        dataType: 'json',
        url: "/api/jobtitles?id=" + $('#GetId').val(),
        success: function (data) {
            alert(JSON.stringify(data));
        }
    });
}
function post() {

    var postData =
        "=" + $('#PostValue').val();

    $.ajax({
        type: "POST",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        data: postData,
        dataType: 'json',
        url: "/api/jobtitles",
        success: function (data) {
            get();
        }
    });
}
function put() {
    var putData =
        "=" + $('#PutValue').val();
    
    $.ajax({
        type: "PUT",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        data: putData,
        dataType: 'json',
        url: "/api/jobtitles?id=" + $('#PutId').val(),
        success: function (data) {
            get();
        }
    });
}
function remove() {   
    $.ajax({
        type: "DELETE",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",        
        dataType: 'json',
        url: "/api/jobtitles?id=" + $('#DeleteId').val(),
        success: function () {
            get();
        }
    });
}