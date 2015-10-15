$(document).ready(function() {

	/**
	 * This function validates the given string with the given expression
	 *
	 * @param {RegExp} expression
	 * @param {string} string
	 * @returns {boolean}
	 */
	function validate(expression, string) {
		var exp = new RegExp(expression);
		return exp.test(string);
	}

    /**
     * The regular expression to validate a password.
     *
     * @type {RegExp}
     */
	var PASSWORD_EXPRESSION = /^[a-zA-Z0-9]{9,}$/i;

    /**
     * The regular expression to validate an email address
     *
     * @type {RegExp}
     */
	var EMAIL_EXPRESSION = /^[a-zA-Z0-9-_\.]{3,}@{1}[a-zA-Z0-9-_\.]{3,}\.[a-z]{2,}$/i;

    /**
     * Object which holds messages for the different errors
     */
    var ERROR_MESSAGE = {
        username: "Der Benutzername ist keine valide E-Mail Adresse",
        password: "Das Passwort entspricht nicht den Vorschriften!",
        comparePassword: "Die Passwörter stimmen nicht überein.",
        options: "Mindest eine Option muss ausgewählt sein.",
        checkbox: "Mindestens eine Checkbox muss angekreuzt sein."
    };

    /**
     * Validate the login form
     */
    $('#loginForm').submit(function() {

        var errors = [];

        /**
         * Check if username is a valid email address using plain javascript
         */
        if(!validate(EMAIL_EXPRESSION, document.getElementById("loginUsername").value)) {
            errors.push(ERROR_MESSAGE.username);
        }

        /**
         * Check if the password is valid using a jQuery selector
         */
        if(!validate(PASSWORD_EXPRESSION, $('#loginPassword').val())) {
            errors.push(ERROR_MESSAGE.password);
        }

        /**
         * Either display errors if there are any or show the input of the user
         */
        $("#loginError").html("");
        $("#loginInput").html("");
        var output = "";
        if(errors.length > 0){
            output += "<strong>Es sind Fehler aufgetreten:</strong><br>";
            errors.forEach(function(value) {
                output += value + "<br>";
            });
            $("#loginError").html(output);
        } else {
            output += "<strong>Ihre Eingaben:</strong><br>";
            output += "Benutzername: " + $("#loginUsername").val() + "<br>";
            output += "Passwort: ***************";
            $("#loginInput").html(output);
        }

        return false;
    });

    /**
     * Validate the register form
     */
    $('#registerForm').submit(function() {

        var errors = [];

        /**
         * Check if username is a valid email address using plain javascript
         */
        if(!validate(EMAIL_EXPRESSION, document.getElementById("username").value)) {
            errors.push(ERROR_MESSAGE.username);
        }

        /**
         * Check if the password is valid using a jQuery selector
         */
        if(!validate(PASSWORD_EXPRESSION, $('#password').val())) {
            errors.push(ERROR_MESSAGE.password);
        }


        //Compare password
        //Check options
        //Check checkbox

    });


    /**
     * Display a user confirm when a user presses on one of the rest buttons
     */
    $(".btnReset").click(function() {
       return confirm("Sind sie Sicher?");
    });
});