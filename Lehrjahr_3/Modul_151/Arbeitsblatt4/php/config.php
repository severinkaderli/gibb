<?php
/*
 *  @autor Michael Abplanalp
 *  @version Februar 2016
 *
 *  Dieses Modul definert alle Konfigurationsparameter und stellt die DB-Verbindung her
 */

// Default-CSS-Klasse zur Formatierung der Eingabefelder
setValue("cfg_css_class_normal", "txt");
// Klasse zur Formatierung der Eingabefelder, falls die Eingabeprüfung negativ ausfüllt
setValue("cfg_css_class_error", "err");
// Funktionen
setValue("cfg_func_list", array("kontakterfassen","kontaktliste"));
// Inhalt des Menus
setValue("cfg_menu_list", array("kontakterfassen"=>"Kontakte erfassen","kontaktliste"=>"Kontaktliste"));

// Datenbankverbindung herstellen
$db = mysqli_connect("localhost", "root", "", "kontakte");
if (!$db) die("Verbindungsfehler: ".mysqli_connect_error());
setValue("cfg_db", $db);
?>
