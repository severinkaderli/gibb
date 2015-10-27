<!DOCTYPE html>
<html>
<head>
	<title>Aufgabe 6.1 - Arrays</title>
</head>
<body>
	<?php
	/**
	 * Aufgabe 1a
	 */
	echo "<h1>Aufgabe 1a - Array</h1>";
	$weekdays = ["Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag"];
	for($i = 0; $i < count($weekdays); $i++) {
		echo $weekdays[$i] . "<br>";
	}

	/**
	 * Aufgabe 1b
	 */
	$weekdays2 = ["Mo" => "Montag", "Di" => "Dienstag", "Mi" => "Mittwoch", "Do" => "Donnerstag", "Fr" => "Freitag", "Sa" => "Samstag", "So" => "Sonntag"];

	/**
	 * Aufgabe 1c
	 */
	echo "<h1>Aufgabe 1b & 1c - Assoziativer Array</h1>";
	foreach($weekdays2 as $shortDay => $weekday) {
		echo $weekday . "<br>";
	}
?>
</body>
</html>

