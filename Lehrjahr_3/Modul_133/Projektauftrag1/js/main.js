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
     * This function prints the array of errors to the given output element
     *
     * @param {Array} errors
     * @param outputElement | jQuery Selector of the output element
     */
    function displayError(errors, outputElement) {
        var output = "<strong>Es sind Fehler aufgetreten:</strong><br>";
        errors.forEach(function(value) {
            output += value + "<br>";
        });
        outputElement.html(output);
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
    //TODO: Adjust some of the messages
    var ERROR_MESSAGE = {
        username: "Der Benutzername ist keine valide E-Mail Adresse",
        password: "Das Passwort entspricht nicht den Vorschriften!",
        comparePassword: "Die Passwörter stimmen nicht überein.",
        gender: "Mindestens ein Geschlecht muss ausgewählt sein.",
        language: "Mindestens eine Sprache muss ausgewählt sein."
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
            displayError(errors, $("#loginError"));
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

        /**
         * Check if the confirmation password is the same as the first one
         * using plain javascript
         */
        if(document.getElementById("password").value != document.getElementById("password_confirmation").value) {
            errors.push(ERROR_MESSAGE.comparePassword);
        }

        /**
         * Check if atleast one gender is selected, normally the HTML5 required
         * attribute should be enough for this, but this is for cases where HTML5
         * is not supported.
         */
        if(!$("#male").is(":checked") && !$("#female").is(":checked")) {
            errors.push(ERROR_MESSAGE.gender);
        }

        /**
         * Check if atleast one language is selected
         * I'm looping through each checkbox to look if atleat one it's checked
         * that way you can add more checkboxes in the future and the
         * validation will still work.
         */
        var isChecked = false;

        $(".check").each(function() {
           if($(this).is(":checked")) {
               isChecked = true;
           }
        });

        if(!isChecked) {
            errors.push(ERROR_MESSAGE.language);
        }

        /**
         * Either display errors if there are any or show the input of the user
         */
        $("#registerError").html("");
        $("#registerInput").html("");
        var output = "";
        if(errors.length > 0){
            displayError(errors, $("#registernError"));
        } else {
            output += "<strong>Ihre Eingaben:</strong><br>";
            output += "Benutzername: " + $("#username").val() + "<br>";
            output += "Passwort: ***************" + "<br>";
            output += "Geschlecht: " + $('input[type="radio"][name="gender"]:checked').val() + "<br>";
            output += "Lieblingssprachen: " + "<br>";
            output += "Hobby: " + $("#hobby").val() + "<br>";
            $("#registerInput").html(output);
        }

        return false;
    });

    /**
     * Display a user confirm when a user presses on one of the rest buttons
     */
    $(".btnReset").click(function() {
        //TODO: Adjust this message
       return confirm("Sind sie Sicher?");
    });
});