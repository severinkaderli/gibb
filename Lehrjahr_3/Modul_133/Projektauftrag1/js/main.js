$(document).ready(function() {

	/**
	 * Validates a string with a regex pattern
	 * 
	 * @param regExp a RegExp-Object
	 * @param string The string to validate
	 * @return bool
	 */
	function validate(regExp, string) {
		if(!regExp.test(string)) {
			return false;
		}
		return true;
	}

	//Validate the form on submit
	$('#loginForm').submit(function() {
		
		//Array for error messages
		var errors = [];
		//TODO: Print messages out nicely
		console.log('submitted');
		
		
		//Check if username is a valid email address using a standard js selector
		//Fix the regex
		if(!validate(new RegExp(/^[a-zA-Z0-9-_\.]{3,}@{1}[a-zA-Z0-9-_\.]{3,}\.[a-z]{2,}$/i), document.getElementById('username').value)) {
			errors.push('Der Benutzername muss eine gültige E-Mail Adresse sein!');
		}

		//Check if password is valid using a jquery selector ()[]{}?!$%&/=*+~,.;:<>-_
		//TODO: Fix the regex
		if(!validate(new RegExp(/^[a-zA-Z0-9]{9,}$/i), $('#password').val())) {
			errors.push('Das Passwort entspricht nicht den Vorschriften (Min. 9 Zeichen lang, min. 1 Grossbuchstabe, min. 1 Kleinbuchstabe und min. 1 Sonderzeichen)');
		}

		//Check if passwords match using plain javascript
		if(document.getElementById('password').value != document.getElementById('password_confirmation').value) {
			errors.push('Die Passwörter stimmen nicht überein');
		}

		//Check checkboxes using jQuery


		//Either display all errors or alls inputs if valid
		if(errors.length > 0) {
			var errorText = "";
			errors.forEach(function(element, index) {
				errorText += errors[index] + "<br>";
			});
			$("#errors").html(errorText);
			$("#errors").show();
		} else {
			console.log('good job');
			$("#errors").hide();
		}
		return false;
	});

	//Message with reset button
	$('#btnReset').click(function() {
		return confirm('Möchten Sie wirklich alle Informationen zurücksetzen?');
	});
});