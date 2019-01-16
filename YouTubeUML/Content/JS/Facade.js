function Facade() {

    var CallBackEnd = function (url, type, param, Callback) {

        console.log("mere")
        $.ajax({
            type: type,
            url: url,
            data: param ,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: Callback,
            error: Callback
        }).done(function (msg) {
            alert("Data Saved: " + msg);
        });
    }

    //CallBackEnd("http://localhost/YouTubeUML/Home/LogOut","GET", "", null)

    this.share = function () {

    }

    this.uploadVideo = function (fileName, filePath, fileSize, fileExtension) {
    }

    this.addComment = function (comment, videoId) {

    }

    this.likeVideo = function (videoId) {

    }

    this.dislikeVideo = function (videoId) {

    }

    this.logAction = function (username, action) {

    }
};

var facade = new Facade();