function TakeName() {
    let username = prompt("Please enter your name!");

    let message = "Hello, " + username + ", your name has ";

    if (username.length > 5) {
        message += "more than ";
    } else if (username.length < 5) {
        message += "less than ";
    } else {
        message += "exactly ";
    }

    message += "5 characters.";

    alert(message);
}