
        $("#S_contact").inputmask("9999-9999999");
            $('#Course_id').selectpicker();
            loadData();

            $("#btnSubmit").click(function () {
                AddUpdate();
                Reset();
            });

            $("#btnReset").click(function () {
        Reset();
            });


function loadData() {
    $.ajax({
        url: "/Student/GetByID",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: { S_id: null },
        async: false,
        success: function (result) {
            if ($.fn.DataTable.isDataTable('#Tblstudent')) {
                $('#Tblstudent').DataTable().destroy();
            }

            $('#Tblstudent tbody').empty();
            $('#Tblstudent').dataTable({
                //'ordering': false,
                //'paging': false,
                data: result,
                columns: [
                    { 'data': 'S_id' },
                    { 'data': 'S_name' },
                    { 'data': 'Course_name' },
                    { 'data': 'Class_name' },
                    { 'data': 'S_contact' },

                    {
                        'render': function (data, type, row) {
                            return '<a href="#" onclick="Edit(' + row.S_id + ')">Edit</a> | <a href="#" onclick="Delele(' + row.S_id + ')">Delete</a>'

                        },
                    }
                ]
            });
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function AddUpdate() {
    //var res = validate();
    //if (res == false) {
    //    return false;
    //}
    var adObj = {
        S_id: $('#S_id').val(),
        S_name: $('#S_name').val(),
        Course_id: $("#Course_id").val(),
        Class_id: $('#Class_id').val(),
        S_contact: $('#S_contact').val()
    };
    $.ajax({
        url: "/Student/SaveStudent",
        data: JSON.stringify(adObj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            loadData();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function Edit(ID) {
    $.ajax({
        url: "/Student/GetByID",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: { S_id: ID },
        async: false,
        success: function (result) {
            debugger
            if (result.length > 0) {
                var returnResult = result[0];
                returnResult.ClassName
                $('#S_id').val(returnResult.S_id);
                $('#S_name').val(returnResult.S_name);
                $('#Course_id').selectpicker('val', returnResult.Course_id.split(','));
                $("#Class_id").val(returnResult.Class_id);
                $('#S_contact').val(returnResult.S_contact);
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function Delele(ID) {
    var ans = confirm("Are you sure you want to delete this Record?");
    if (ans) {
        $.ajax({
            url: "/Student/Delete/" + ID,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                loadData();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}

function Reset() {
    $('#S_id').val("0");
    $('#S_name').val("");
    $('#Course_id').selectpicker('val', "");
    $("#Class_id").prop('selectedIndex', 0);
    $('#S_contact').val("");
}
