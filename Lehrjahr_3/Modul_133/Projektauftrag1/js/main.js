$(document).ready(function() {

	/**
	 * This function validates the given string with the given expression
	 *
	 * @param {string} expression
	 * @param {string} string
	 * @returns {boolean}
	 */
	function validate(expression, string) {
		var exp = new RegExp(expression);
		return exp.test(string);
	}

	/**
	 * The regular expression to validate a password.
	 */
	var PASSWORD_EXPRESSION = "/^[a-zA-Z0-9]{9,}$/i";

	/**
	 * The regular expression to validate an email address
	 */
	var EMAIL_EXPRESSION = "/^[a-zA-Z0-9-_\.]{3,}@{1}[a-zA-Z0-9-_\.]{3,}\.[a-z]{2,}$/i";

    /**
     * Object which holds messages for the different errors
     */
    var ERROR_MESSAGES = {
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

        //Array to hold the current error messages
        var errors = [];

        /**
         * Check if username is a valid email address using plain javascript
         */
        if(!validate(EMAIL_EXPRESSION, "test")) {
            errors.push(ERROR_MESSAGES.username);
        }

        /**
         * Check if the password is valid using a jquery selector
         */
        if(!validate(PASSWORD_EXPRESSION, "test")) {
            errors.push(ERROR_MESSAGES.password);
        }

        //Display errors/input
        console.log(errors);

        return false;
    });


    /**
     * Validate the register form
     */
    $('#registerForm').submit(function() {

        var errors = [];
        //Check username
        //Check password
        //Compare password
        //Check options
        //Check checkbox

    });
});