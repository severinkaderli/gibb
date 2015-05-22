<?php

	//Start session
	require_once("inc/header.php");
	
	
	//Redirect if already logged in
	if($user -> logged_in()) {
		
		//Redirect to user panel
		header("Location: user.php");
	}
	
	//Change password
	if($_SERVER["REQUEST_METHOD"] == "POST" && isset($_GET["register"]) && $_GET["register"] == "true") {
		
		//Define variables
		$username = $db -> filter($_POST["username"]);
		$email = $db -> filter($_POST["email"]);
		$password = md5($_POST["password"]);
		$password2 = md5($_POST["password2"]);
		$captcha = $_POST["captcha"];
		
		//Check if captcha is valid
		if($captcha == $_SESSION["captcha"]) {
			
			//Check if the user exists already
			if(!$user -> exists($username)) {
				
				//Check if the passwords match
				if($password == $password2) {
					
					//Default avatar
					$avatar = "img/assets/default_avatar.png";
					
					//Insert User Into database
					$db -> query("INSERT INTO users(username, password, email, is_admin, avatar)
									VALUES('$username', '$password', '$email', 0, '$avatar')", false);
									
					//Redirect to login page
					header("Location: login.php");
					
				} else {
					
					//Passwords don't match
					$_SESSION["msg"] = "Passwörter stimmen nicht überein";
				}
				
			} else {
				
				//User exists already
				$_SESSION["msg"] = "Dieser Benutzername existiert bereits!";
			}
			
		} else {
			
			//Wrong captcha
			$_SESSION["msg"] = "Der Sicherheitscode ist fehlerhaft!";
		}		
	}		
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title>Registrieren</title>
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
				<h1>Registrieren</h1>	
				<?php	
					if(isset($_SESSION["msg"]) && !empty($_SESSION["msg"])) {
						echo "<p class='errorbox'>" . $_SESSION["msg"] . "</p>";
						unset($_SESSION["msg"]);
					}
					
					//Display form for registration
					echo "<form action='" . $_SERVER["PHP_SELF"] . "?register=true' method='POST'>";
						echo "<p>";
							echo"<label for='username'>Benutzername</label>";
							echo "<br>";
							echo "<input type='text' id='username' name='username' />";
						echo "</p>";
						echo "<p>";
							echo"<label for='email'>E-Mail Adresse</label>";
							echo "<br>";
							echo "<input type='email' id='email' name='email' />";
						echo "</p>";
						echo "<p>";
							echo"<label for='password'>Passwort</label>";
							echo "<br>";
							echo "<input type='password' id='password' name='password' />";
						echo "</p>";
						echo "<p>";
							echo"<label for='password2'>Passwort bestätigen</label>";
							echo "<br>";
							echo "<input type='password' id='password2' name='password2' />";
						echo "</p>";
						echo "<p>";
							echo "<img src='captcha.php' class='captcha' alt='captcha' />";
							echo "<br>";
							echo "<input type='text' name='captcha' />";
						echo "</p>";
						echo "<p>";
							echo "<input type='submit' value='Registrieren' />";
						echo "</p>";
					echo "</form>";		
				?>
			</article>	
			<footer>
				<small>&copy;2014 - Severin Kaderli</small>
			</footer>
		</div>
	</body>
</html>
