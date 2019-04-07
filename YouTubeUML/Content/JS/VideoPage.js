var VideoPage = function() {
    var elements = {
        likeButton: $("#likeButton"),
        dislikeButton: $("#dislikeButton"),
        videoId: $("#videoId")
    }

    elements.likeButton.click(function () {
        facade.likeVideo(elements.videoId.attr("data"))
        elements.likeButton.html(Number(elements.likeButton.html()) + 1)
    });

    elements.dislikeButton.click(function () {
        facade.dislikeVideo(elements.videoId.attr("data"))
        elements.dislikeButton.html(Number(elements.dislikeButton.html()) + 1)
    });

}

var vp = new VideoPage();