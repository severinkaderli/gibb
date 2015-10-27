<?php
	/**
	 * Aufgabe 1a
	 */
	$weekdays = ["Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag"];
	for($i = 0; $i < count($weekdays); $i++) {
		echo $weekdays[$i] . "<br>";
	}
	echo "<br>";

	/**
	 * Aufgabe 1b
	 */
	$weekdays2 = ["Mo" => "Montag", "Di" => "Dienstag", "Mi" => "Mittwoch", "Do" => "Donnerstag", "Fr" => "Freitag", "Sa" => "Samstag", "So" => "Sonntag"];

	/**
	 * Aufgabe 1c
	 */
	foreach($weekdays2 as $shortDay => $weekday) {
		echo $weekday . "<br>";
	}
?>