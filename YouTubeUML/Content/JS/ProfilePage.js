function ProfilePage() {
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

    if (elements.usernameLabel.is(":visible")) {
        elements.uploadButton.show();
        elements.logOutButton.show();
    } else {
        elements.signInButton.show();
        elements.signOutButton.show();
    }

}