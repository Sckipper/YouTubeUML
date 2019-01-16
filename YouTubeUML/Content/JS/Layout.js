function Layout() {
    var elements = {
        uploadButton: $("#uploadButton"),
        signInButton: $("#signIn"),
        signOutButton: $("#signUp"),
        logOutButton: $("#logOutButton"),
        loginButton: $("#Login"),
        username: $("#usernameInput"),
        password: $("#passwordInput"),
        usernameLabel: $("#usernameLabel")
    }

    elements.logOutButton.click(function () {

    });

    if (elements.usernameLabel.is(":visible")) {
        elements.uploadButton.show();
        elements.logOutButton.show();
    } else {
        elements.signInButton.show();
        elements.signOutButton.show();
    }

}

var layout = new Layout();