<?php

	//Start session
	require_once("inc/header.php");
	
	
	//Redirect if already logged in
	if($user -> logged_in()) {
		
		//Redirect to user panel
		header("Location: user.php");
	}
	
	if($_SERVER["REQUEST_METHOD"] == "POST") {
		
		//Declare variables
		$email = $db -> filter($_POST["email"]);
		
		//Check if E-Mail exists in database
		$checkEmail = $db -> query("SELECT uid FROM users
										WHERE email='$email'");
		
		$numRows = count($checkEmail);
		
		if($numRows == 1) {
			
			//Create token
			$token = hash("MD5", microtime() . $email);
			
			//Delete old tokens
			$uid = $checkEmail[0] -> uid;
			$db -> query("DELETE FROM resettokens WHERE fk_uid='$uid'", false);
			
			//Write token in database
			$db -> query("INSERT INTO resettokens(fk_uid, token) VALUES('$uid', '$token')", false);
						
			//Send email
			$mailSubject = "Passwort zurücksetzen";
			
			$mailHeader = "MIME-Version: 1.0" . "\r\n";
			$mailHeader .= "Content-type: text/html; charset=utf-8" . "\r\n";
			$mailHeader .= "From: Severin Kaderli <no-reply@" . $_SERVER["SERVER_NAME"] . ">" . "\r\n";
			
			$mailMessage = "Klicken Sie auf den folgenden Link um ihr Passwort zurückzusetzen:<br> <a href='" . $_SERVER["SERVER_NAME"] . ROOTDIR .  "resetpass.php?token=" . $token ."'>" . $_SERVER["SERVER_NAME"] . ROOTDIR .  "resetpass.php?token=" . $token ."</a>";
			
			mail($email, $mailSubject, $mailMessage, $mailHeader);
		}
		
		$message = "Ein Link für das Zurücksetzen Ihres Passworts wurde an <b>" . $email .  "</b> geschickt.";
	}
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title>Passwort zur&uuml;cksetzen</title>
		<link rel="stylesheet" type="text/css" href="css/style.css" />
	</head>
	<body>
		<div class="wrapper">
			<div class="navWrapper">
				<?php
					require_once("inc/nav.php");
				?>
			</div>
			<article>
				<h1>Passwort zurücksetzen</h1>	
				<?php
					if(isset($message)) {
						echo "<p>" . $message ."</p>";
					} else {
						echo "<p>Geben Sie Ihre E-Mail Adressse ein, damit wir Ihnen einen Link zum Zurücksetzen des Passwortes zusenden können.</p>";?>
						<form action="<?php echo $_SERVER["PHP_SELF"]; ?>" method="POST">
					<p>
						<label for="email">E-Mail Adresse</label>
						<input type="email" id="email" name="email" />
					</p>
					<p>
						<input type="submit" value="Reset E-Mail senden" />
					</p>
				</form>
	
				<?php
					}
				?>
			</article>	
			<footer>
				<small>&copy;2014 - Severin Kaderli</small>
			</footer>
		</div>
	</body>
</html>
