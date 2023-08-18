document.getElementById("form1").addEventListener("submit", function(event) {
    var name = document.getElementById("named").value;
    var email = document.getElementById("email").value;
    var message = document.getElementById("message").value;

    var errorMessage = "";
    if (name === "") {
        errorMessage += "Name is required.\n";
    } else if (!name.match(/^[a-zA-Zа-яА-Я]+$/)) {
        errorMessage += "Not correct name.\n";
    }

    if (email === "") {
        errorMessage += "Email is required.\n";
    }

    if (message === "") {
        errorMessage += "Message is required.\n";
    }

    if (errorMessage !== "") {
        alert(errorMessage);
        event.preventDefault();
    }
});
