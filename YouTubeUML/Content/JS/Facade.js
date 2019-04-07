function Facade() {

    var CallBackEnd = function (url, type, param, Callback) {
        $.ajax({
            type: type,
            url: url,
            data: param,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function () { console.log("m") },
            error: function (error) {
                console.log(error.responseText)
            }
        });
    }

    this.share = function () {

    }

    this.uploadVideo = function (fileName, filePath, fileSize, fileExtension) {
    }

    this.addComment = function (comment, videoId) {

    }

    this.likeVideo = function (videoId) {
        var data = "{ 'vid': '" + videoId + "'}"
        CallBackEnd("http://localhost/YouTubeUML/Home/LikeVideo", "POST", data, null)
    }

    this.dislikeVideo = function (videoId) {
        var data = "{ 'vid': '" + videoId + "'}"
        CallBackEnd("http://localhost/YouTubeUML/Home/DislikeVideo", "POST", data, null)
    }

    this.logAction = function (username, action) {

    }
};

var facade = new Facade();