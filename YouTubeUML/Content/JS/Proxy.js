function Proxy() {

    $.ajax({
        accepts: {
            mycustomtype: 'application/x-some-custom-type'
        },

        // Instructions for how to deserialize a `mycustomtype`
        converters: {
            'text mycustomtype': function (result) {
                // Do Stuff
                return newresult;
            }
        },

        // Expect a `mycustomtype` back from server
        dataType: 'mycustomtype'
    });

    this.login = function (username, password) {

    }

    this.signOut = function () {

    }

    this.register = function (username, password, email, userRole) {

    }

    this.share = function () {

    }

    this.uploadVideo = function (fileName, filePath, fileSize, fileExtension) {
    }

    this.getVideo = function (videoId) {

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

proxy = Proxy();