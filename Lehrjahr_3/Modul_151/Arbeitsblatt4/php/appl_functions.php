<?php
/*
 *  @autor Miichael Abplanalp
 *  @version Februar 2016
 *
 *  Dieses Modul beinhaltet Funktionen, welche die Anwendungslogik implementieren.
 */

/*
 * Gibt die entsprechende CSS-Klasse aus einem assiziativen Array (key: Name Eingabefeld) zurück
 * @param   $name       Name des Eingabefeldes
 */
function getCssClass($name) {
  global $css_classes;
  if (isset($css_classes[$name])) return $css_classes[$name];
  else return getValue("cfg_css_class_normal");
}

/*
 * Beinhaltet die Anwendungslogik zur Verwaltung des Kontaktformulars
 */
function kontakterfassen() {
  // Der Schaltknopf "speichern" wurde betätigt
  if (isset($_REQUEST['speichern'])) {
	$fehlermeldung = checkInput();
	// Wenn ein Fehler aufgetreten ist
    if (strlen($fehlermeldung) > 0) {
	  setValue("css_class_meldung", "fehler");
	  setValue("meldung", $fehlermeldung);
      setValues($_REQUEST);
	  setValue("droport", dropOrt($_REQUEST['oid']));
	// Wenn alles ok
    } else {
	  db_insert_kontakt(getRequest("oid", "Null"), $_REQUEST);
	  setValue("css_class_meldung", "meldung");
	  setValue("meldung", "Kontakt erfolgreich eingefügt.");
	  setValue("droport", dropOrt());
	}
  // Das Formular wird zum Erfassen eines neuen Kontaktes aufgerufen
  } else setValue("droport", dropOrt());
  // Template abfüllen und Resultat zurückgeben
  setValue("phpmodule", $_SERVER['PHP_SELF']."?id=".__FUNCTION__ );
  return runTemplate( "../templates/kontakterfassen.htm.php" );
}

/*
 * Beinhaltet die Anwendungslogik zur Ausgabe der Kontaktliste
 */
function kontaktliste() {
  // Übergebener Eintrag in DB löschen
  if (isset($_REQUEST['kid'])) {
	db_delete_kontakt($_REQUEST['kid']);
	setValue("css_class_meldung", "meldung");
	setValue("meldung", "Kontakt erfolgreich gelöscht.");
  }
  // Alle Daten (Kontakte) aus der DB lesen und der Variablen "data" zuweisen
  setValue("data", db_select_kontakte());
  // Falls Daten vorhanden sind, Template ausführen und Resultat zurückgeben
  if (is_array(getValue("data"))) {
	setValue("phpmodule", $_SERVER['PHP_SELF']."?id=".__FUNCTION__);
	return runTemplate("../templates/kontaktliste.htm.php");
  } else {
	return "Liste ist leer...";
  }
}

/*
 * Erstellt das Listenfeld Orte
 * @param       $data       Assoziativer Array mit den Werten
 * ram          $sel        Wert, welcher vorselektiert werden soll
 */
function dropOrt($sel="") {
  $data = db_select_orte();
  $drop = "<select name='oid' class='standardWidth'>";
  $drop .= "<option></option>";
  if (count($data)) {
	foreach ($data as $row) {
	  $selected = "";
	  if ($row['oid'] == $sel) $selected = "selected";
	  $drop .= "<option value='".$row['oid']."' $selected>".$row['ort']." ".$row['plz']."</option>";
	}
  }
  $drop .= "</select>";
  return $drop;
}

/*
 * Funktion zur Eingabeprüfung
 */
function checkInput() {
  global $css_classes;
  $fehlermeldung = "";

  if (!checkEmpty($_REQUEST['nachname'],3)) {
	$css_classes['nachname'] = getValue("cfg_css_class_error");
	$fehlermeldung .= "Nachname mind. 3 Zeichen. ";
  }
  if (!checkEmail($_REQUEST['email'])) {
	$css_classes['email'] = getValue("cfg_css_class_error");
	$fehlermeldung .= "Falsches Format E-Mail. ";
  }
  return $fehlermeldung;
}
?>