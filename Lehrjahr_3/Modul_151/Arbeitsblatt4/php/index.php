<?php
session_start();
require("basic_functions.php");
require("config.php");
require("db_functions.php");
require("appl_functions.php");

// Dispatching: Die über den Parameter "id" definierte Funktion ausführen
$func = getId();
// Falls  die verlangte Funktion nicht in der Liste der akzeptierten Funktionen ist, Default-Seite laden
$flist = getValue("cfg_func_list");
if (!in_array($func, $flist)) $func = $flist[0];
// Aktive Funktion global speichern, da diese später noch verwendet wird
setValue("func", $func);
// Funktion aufrufen und Rückgabewert in "inhalt" speichern
setValue("inhalt", $func());

// Haupttemplate aufrufen, Ausgabe an Client (Browser) senden
echo runTemplate("../templates/index.htm.php");