function GetData() {
   
    $.ajax({
        url: "/api/course/",
        cache: false,
        success: function (data) {

            for (var x = 0; x < data.length; x++ ) {
                $("#results").append("<li>" + (data[x])  + "</li");
            }

        }
    });
   
}