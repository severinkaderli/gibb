<!DOCTYPE html>
<html>
<head>
	<title>Aufgabe 7.1</title>
</head>
<body>
	<?php

		/**
		 * Aufgabe 1-4
		 */
		/*$datei1 = fopen("text.txt", "w");
		fwrite($datei1, "Hello World!");
		fclose($datei1);*/

		/**
		 * Aufgabe 5
		 */
		/*$datei1 = fopen("text.txt", "r");
		fseek($datei1, 10);
		echo fgetc($datei1);
		fclose($datei1);*/

		/**
		 * Aufgabe 6
		 */
		/*$datei1 = fopen("text.txt", "r");
		while (($line = fgets($datei1)) !== false) {
        	echo $line . "<br>";
   		}*/

   		/**
   		 * Aufgabe 7
   		 */
   		$vorname = $_POST["vorname"];
   		$nachname = $_POST["nachname"];
   		$jahrgang = $_POST["jahrgang"];
   		$datensatz = [$vorname, $nachname, $jahrgang];
   		$datensatz = implode("|", $datensatz);
   		$datensatz .= "\n";
   		$datei = fopen("text.txt", "a");
   		fwrite($datei, $datensatz);
   		fclose($datei);

   		$datei = fopen("text.txt", "r");
   		while (($line = fgets($datei)) !== false) {
   			$daten = explode("|", $line);
        	echo "Vorname: " . $daten[0] . ", Nachname: " . $daten[1] . ", Jahrgang: " . $daten[2] . "<br>";
   		}
   		fclose($datei);
	?>
</body>
</html>