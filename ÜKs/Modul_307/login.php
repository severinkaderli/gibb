<?php

	//Start session
	require_once("inc/header.php");
	
	
	//Redirect if already logged in
	if($user -> logged_in()) {
		
		//Redirect to user page
		header("Location: user.php");
	}
	
	if($_SERVER["REQUEST_METHOD"] == "POST") {
		
		if(isset($_POST["useCookies"]) && $_POST["useCookies"] == 1)
		
			$checkLogin = $user -> login($_POST["username"], $_POST["password"], $_POST["useCookies"]);
			
		else {
			
			$checkLogin = $user -> login($_POST["username"], $_POST["password"]);
		}
		
		if($checkLogin) {
			
			//Redirect to user page
			header("Location: user.php");
			
		} else {
			
			//User credentials aren't correct
			$_SESSION["msg"] = "Benutzername und/oder Passwort ist nicht korrekt!";
		}
	}
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title>Login</title>
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
				<h1>Login</h1>
				<?php
					if(isset($_SESSION["msg"]) && !empty($_SESSION["msg"])) {
						echo "<p class='errorbox'>" . $_SESSION["msg"] . "</p>";
						unset($_SESSION["msg"]);
					}
					
				?>
				<form action="<?php echo $_SERVER["PHP_SELF"]; ?>" method="POST">
					<p>
						<label for="username">Benutzername:</label>
						<br />
						<input type="text" id="username" name="username" />
					</p>
					<p>
						<label for="password">Passwort:</label>
						<br />
						<input type="password" id="password" name="password" />
					</p>
					<p>		
						<input type="checkbox" value="1" id="useCookies" name="useCookies" />
						<label for="useCookies">Eingeloggt bleiben:</label>
					</p>
					<p>
						<input type="submit" value="Einloggen" />
					</p>
					<p>
						<a href="forgotpass.php">Passwort vergessen?</a>
					</p>
				</form>
			</article>
			<footer>
				<small>&copy;2014 - Severin Kaderli</small>
			</footer>
		</div>
	</body>
</html>
