<!DOCTYPE html>
<html>
<head>
	<title>Aufgabe 6.1 - Formular</title>
</head>
<body>
	<?php
	echo "Name: " . $_POST["txtBenutzername"] . "<br>";
	echo "Vorname: " . $_POST["txtBenutzervorname"] . "<br>";
	echo "Adresse: " . $_POST["txtBenutzeradresse"] . "<br>";
	echo "Passwort: " . $_POST["txtPasswort"] . "<br>";
?>
</body>
</html>

