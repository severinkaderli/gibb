<?php

	//Start session
	require_once("inc/header.php");
	
	
	//Redirect if already logged in
	if($user -> logged_in()) {
		
		//Redirect to user panel
		header("Location: user.php");
	}
	
	$tokenValid = 0;
	
	//Show form for change password
	if(!isset($_GET["changePass"]) && isset($_GET["token"])) {
		
		//Create variables
		$token = $db -> filter($_GET["token"]);
		$tokenValid = 0;
		
		//Check if token is valid
		$checkToken = $db -> query("SELECT id FROM resettokens WHERE token='$token'");	
		$numRows = count($checkToken);
		
		//If token is valid
		if($numRows == 1) {
			
			$message = "Geben Sie nun Ihr neues gewünschtes Passwort ein.";
			$tokenValid = 1;
			
		} else {
			
			$message = "Der Link ist nicht mehr gültig. Bitte fordern Sie <a href='forgotpass.php'>hier</a> einen neuen an.";
			$tokenValid = 0;
		}

	}
	
	//Change password
	if($_SERVER["REQUEST_METHOD"] == "POST" && isset($_GET["changePass"]) && $_GET["changePass"] == "true") {
		
		//Create variables
		$token = $db -> filter($_GET["token"]);
		$tokenValid = 0;
		$password = md5($_POST["password"]);
		$newPassword = md5($_POST["newPassword"]);
		
		//Check if both entered passwords are the same
		if($password == $newPassword) {
			
			//Get uID
			$getUid = $db -> query("SELECT fk_uid FROM resettokens WHERE token='$token'");
			$uid = $getUid[0] -> fk_uid;
			
			//Save new password
			$db -> query("UPDATE users SET password='$password' WHERE uid='$uid'", false);
			
			//Delete token from database
			$db -> query("DELETE FROM resettokens WHERE token='$token'", false);
			
			//Set message
			$message = "Ihr Passwort wurde erfolgreich geändert. Sie können sich nun <a href='login.php'>hier</a> anmelden.";
		} else {
			
			//Message if passwords didn't match
			$_SESSION["msg"] = "Die Passwörter stimmen nicht überein!";
			header("Location: resetpass.php?token=" . $token);
			exit;
		}
		
				
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
					//Display message
					if(isset($message)) {
						echo "<p>" . $message ."</p>";
					} else {
						echo "<p>Der Link ist nicht mehr gültig. Bitte fordern Sie <a href='forgotpass.php'>hier</a> einen neuen an.";
					}
					
					//Display form
					if($tokenValid == 1) {
						echo "<form action='" . $_SERVER["PHP_SELF"] . "?changePass=true&amp;token=" .  $token . "' method='POST'>";
							echo "<p>";
								echo"<label for='password'>Neues Passwort</label>";
								echo "<br>";
								echo "<input type='password' id='password' name='password' />";
							echo "</p>";
							echo "<p>";
								echo"<label for='newPassword'>Passwort bestätigen</label>";
								echo "<br>";
								echo "<input type='password' id='newPassword' name='newPassword' />";
							echo "</p>";
							echo "<p>";
								echo "<input type='submit' value='Passwort ändern' />";
							echo "</p>";
						echo "</form>";			
					}
				?>
			</article>	
			<footer>
				<small>&copy;2014 - Severin Kaderli</small>
			</footer>
		</div>
	</body>
</html>
