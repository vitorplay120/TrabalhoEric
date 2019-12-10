var mdusa = {


    serverCall: function (url, data, complete) {

        let formdata = new FormData();

        if (!(data instanceof FormData)) {
            data = data.split('&');
            for (var i = 0; i < data.length; i++) {
                if (data[i] != "") {
                    let nomevalor = data[i].split('=');
                    if (nomevalor.length > 1) {
                        formdata.append(nomevalor[0], nomevalor[1]);
                    }
                }
            }
        } else {
            formdata = data;
        }
        //    var content = "";
        //    data.append("isAjax", "true");
        //    data.forEach(function (value, key) {
        //        if (content != "") content += "&";
        //        content += key + "=" + value;
        //    })
        //    data = content;
        //} else {
        //    data = "isAjax=true&" + data
        //}

        formdata.append("isAjax", "true");

        var Loading = $(".guardarLoading");
        Loading.show();

        $.ajax({
            url: url,
            data: formdata,
            processData: false,
            contentType: false,
            type: 'POST',



            //success: function (msg) {

            //    complete(msg, true);
            //    aplicarMascaras();
            //    Loading.hide();

            //},
            //fail: function (xhr, status, error) {

            //    console.log(xhr);
            //    if (xhr.status == 401) {
            //        window.location.reload(true);
            //        return;
            //    }
            //    complete(xhr.responseText, false);

            //},


        }).done(function (msg) {

            complete(msg, true);
            aplicarMascaras();
            Loading.hide();

        }).fail(function (xhr, status, error) {

            console.log(xhr);
            if (xhr.status == 401) {
                window.location.reload(true);
                return;
            }
            complete(xhr.responseText, false);

        }).always(function () {

            Loading.hide();

        });



    }



}