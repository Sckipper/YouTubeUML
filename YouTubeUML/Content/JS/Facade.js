function Facade() {

    var CallBackEnd = function (url, type, param, Callback) {
        $.ajax({
            type: type,
            url: url,
            data: param,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) { Callback(data) },
            error: function (error) {
                console.log(error.responseText);
                Callback(error);
            }
        });
    }

    this.share = function () {

    }

    this.uploadVideo = function (fileName, filePath, fileSize, fileExtension) {
    }

    this.addComment = function (videoId, commentMessage) {
        var data = "{ 'vid': '" + videoId + "', 'comment': '" + commentMessage.val() + "' , 'uid': '1' }";
        CallBackEnd("http://localhost/YouTubeUML/Home/addComment", "POST", data, function Callback(response) {
            commentMessage.val("");
        })
    }

    this.likeVideo = function (videoId) {
        var data = "{ 'vid': '" + videoId + "'}"
        CallBackEnd("http://localhost/YouTubeUML/Home/LikeVideo", "POST", data, null)
    }

    this.dislikeVideo = function (videoId) {
        var data = "{ 'vid': '" + videoId + "'}"
        CallBackEnd("http://localhost/YouTubeUML/Home/DislikeVideo", "POST", data, null)
    }

    this.getVideoLikes = function (videoId, likes) {
        var data = "{ 'vid': '" + videoId + "'}"
        CallBackEnd("http://localhost/YouTubeUML/Home/GetVideoLikes", "POST", data, function (response) {
            likes.html(response);
        })
    }

    this.getVideoDislikes = function (videoId, dislikes) {
        var data = "{ 'vid': '" + videoId + "'}"
        CallBackEnd("http://localhost/YouTubeUML/Home/GetVideoDislikes", "POST", data, function (response) {
            dislikes.html(response);
        })

    }

    this.getVideoComments = function (videoId, commentDiv) {
        var data = "{ 'vid': '" + videoId + "'}"
        CallBackEnd("http://localhost/YouTubeUML/Home/GetVideoComments", "POST", data, function (response) {
            for (var i = 0; i < response.length; i++) {
                $(commentDiv).find("p").html(response[i].Message)
                $(commentDiv).parent().append($(commentDiv)[0].outerHTML)
            }
        });
    }
};

var facade = new Facade();