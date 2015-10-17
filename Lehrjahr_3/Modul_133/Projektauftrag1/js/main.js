/**
 * Author: Severin Kaderli
 * Copyright: 2015
 */
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
        var output = "<strong>Es sind Fehler bei der Validierung aufgetreten:</strong><br>";
        for(var i = 0; i < errors.length; i++) {
            output += errors[i] + "<br>";
        }
        outputElement.html(output);
    }

    /**
     * The regular expression to validate a password.
     *
     * @type {RegExp}
     */
	var PASSWORD_EXPRESSION = /^[a-zA-Z\(\)\[\]\{\}\?!\$%&\/=\*\+~,\.;:<>\-_]{9,}$/i;

    /**
     * The regular expression to validate an email address
     *
     * @type {RegExp}
     */
	var EMAIL_EXPRESSION = /^[a-zA-Z0-9-_\.]{2,}@[a-zA-Z0-9-_\.]{2,}\.[a-z]{2,}$/i;

    /**
     * Object which holds messages for the different errors
     */
    var ERROR_MESSAGE = {
        username: "Der Benutzername muss eine valide E-Mail Adresse sein.",
        password: "Das Passwort entspricht nicht den Vorschriften.",
        comparePassword: "Die Passwörter stimmen nicht überein.",
        language: "Mindestens eine Sprache muss ausgewählt sein."
    };

    /**
     * Validate the login form
     */
    $('#loginForm').submit(function() {

		/**
		 * Check if form is in login or register mode
		 *  This will determine which inputs to validate
		 */
		var isLogin = $("#formChange").is(":checked");
		
		/**
		 * Array to hold the current validation errors 
		 */
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
         * using plain javascript. This is only needed in register mode
         */
        if(!isLogin) {
        	if(document.getElementById("password").value != document.getElementById("password_confirmation").value) {
           		errors.push(ERROR_MESSAGE.comparePassword);
        	}
        }
        
        /**
         * Check if atleast one language is selected
         * I'm looping through each checkbox to look if atleast one is checked
         * that way you can add more checkboxes in the future and the
         * validation will still work. I'm using jQuery here to check if
         * the checkbox is checked. This check is only needed in register mode.
         */
        if(!isLogin) {
        	var isChecked = false;

	        $("input[name='hobby']").each(function() {
	           if($(this).is(":checked")) {
	               isChecked = true;
	           }
	        });
	
	        if(!isChecked) {
	            errors.push(ERROR_MESSAGE.language);
	        }
        }
        
        /**
         * Either display errors if there are any or show the input of the user
         * if all inputs are valid.
         */
        $("#alertError").html("");
        $("#alertInput").html("");
        var output = "";
        if(errors.length > 0){
            displayError(errors, $("#alertError"));
        } else {
            output += "<strong>Ihre Eingaben:</strong><br>";
            output += "Benutzername: " + $("#username").val() + "<br>";
            output += "Passwort: ***************" + "<br>";
            
            //Only show certain inputs in register mode
            if(!isLogin) {
            	 output += "Geschlecht: " + $('input[type="radio"][name="gender"]:checked').val() + "<br>";

	            //Print out all selected languages
	            output += "Lieblingssprachen: ";
	            $("input[name='hobby']:checked").each(function() {
	               output += $(this).val() + ", ";
	            });
	            //Remove trailing comma
	            output = output.replace(/,\s*$/, "");

	            output += "<br>";
	            output += "Hobby: " + $("#hobby").val() + "<br>";
            }
           
            $("#alertInput").html(output);
        }

        return false;
    });

    /**
     * Ask user for confirmation before resetting all form data
     */
    $(".btnReset").click(function() {
       return confirm("Es werden alle Felder zurückgesetzt! Sind Sie sicher?");
    });
      
    /**
     * Change form mode between login and register 
     */
    $("#formChange").change(function() {
    	if($(this).is(":checked")) {
            $(".input--register").hide();
    	} else {
            $(".input--register").show();
    	}
    });
});
