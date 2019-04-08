var VideoPage = function() {
    var elements = {
        likeButton: $("#likeButton"),
        dislikeButton: $("#dislikeButton"),
        videoId: $("#videoId"),
        addComment: $("#addComment"),
        commentMessage: $("#commentMessage"),
        commentDiv: $(".commentDiv")
    }

    facade.getVideoLikes(elements.videoId.attr("data"), elements.likeButton);
    facade.getVideoDislikes(elements.videoId.attr("data"), elements.dislikeButton);
    facade.getVideoComments(elements.videoId.attr("data"), elements.commentDiv);

    elements.likeButton.click(function () {
        facade.likeVideo(elements.videoId.attr("data"))
        elements.likeButton.html(Number(elements.likeButton.html()) + 1)
    });

    elements.dislikeButton.click(function () {
        facade.dislikeVideo(elements.videoId.attr("data"))
        elements.dislikeButton.html(Number(elements.dislikeButton.html()) + 1)
    });

    elements.addComment.click(function () {
        facade.addComment(elements.videoId.attr("data"), elements.commentMessage);
        document.location.reload(true);
    });
}

var vp = new VideoPage();