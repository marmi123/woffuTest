var urlapi ="/api/v1/jobtitles"
function get(SeeResult = true) {
    $.ajax({
        type: "GET",
        contentType: "application/json",
        dataType: 'json',
        url: urlapi,
        success: function (data) {
            $('#tbJob').find("tr:gt(0)").remove();
            for (var i = 0; i < data.length; i++) {
                var row = data[i];
                $('#tbJob').append
                    ('<tr id="jobrow"><td>' + row.JobTitleId + '</td><td>' + row.Name + '</td><td>' + row.CompanyId + '</td></tr>');
                if (SeeResult===true)
                    $('#JsonResult').val(JSON.stringify(data));
            }
        }
    });
}
function getId() {
    $.ajax({
        type: "GET",
        contentType: "application/json",
        dataType: 'json',
        url: urlapi+"?id=" + $('#Id').val(),
        success: function (data) {
            $('#JsonResult').val(JSON.stringify(data));            
            $('#Id').val("");
        }
    });
}
function post() {
    var postData =
        "=" + $('#Value').val();

    $.ajax({
        type: "POST",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        data: postData,
        dataType: 'json',
        url: urlapi,
        success: function (data) {
            $('#Value').val("");
            get();            
        }
    });
}
function put() {
    var putData =
        "=" + $('#Value').val();
    $.ajax({
        type: "PUT",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",
        data: putData,
        dataType: 'json',
        url: urlapi+ "?id=" + $('#Id').val(),
        success: function (data) {
            $('#Id').val("");
            $('#Value').val("");
            get();
        }
    });
}
function remove() { 
    $.ajax({
        type: "DELETE",
        contentType: "application/x-www-form-urlencoded; charset=utf-8",        
        dataType: 'json',
        url: urlapi+"?id=" + $('#Id').val(),
        success: function () {
            $('#Id').val("");           
            get();
        }
    });
}