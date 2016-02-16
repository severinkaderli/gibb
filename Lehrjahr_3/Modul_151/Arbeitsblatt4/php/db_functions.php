<?php
/*
 *  @autor Michael Abplanalp
 *  @version Februar 2016
 *
 *  Dieses Modul beinhaltet sämtliche Datenbankfunktionen.
 *  Die Funktionen formulieren die SQL-Anweisungen und rufen dann die Funktionen
 *  sqlQuery() und sqlSelect() aus dem Modul basic_functions.php auf.
 */

/*
 * Datenbankfunktionen zur Tabelle orte
 */
function db_insert_ort($params) {
	$sql = "insert into orte (plz, ort)
			values ('".$params['plz']."','".escapeSpecialChars($params['ort'])."')";
	sqlQuery($sql);
}

function db_select_orte() {
	$sql = "select * from orte order by ort, plz";
	return sqlSelect($sql);
}

function db_delete_ort($oid) {
    if (isCleanNumber($kid)) sqlQuery("delete from orte where oid=".$oid);
	sqlQuery($sql);
}

/*
 * Datenbankfunktionen zur Tabelle kontakte
 */
function db_insert_kontakt($oid, $params) {
    $sql = "insert into kontakte (nachname, vorname, strasse, oid, email, tel)
            values ('".escapeSpecialChars($params['nachname'])."','".escapeSpecialChars($params['vorname'])."',
					'".escapeSpecialChars($params['strasse'])."',".$oid.",
					'".escapeSpecialChars($params['email'])."','".escapeSpecialChars($params['tel'])."')";
    sqlQuery($sql);
}

function db_select_kontakte() {
	$sql = "select k.kid, k.nachname, k.vorname, k.strasse, o.plz, o.ort, k.email, k.tel
			from kontakte k
			left join orte o on o.oid = k.oid
			order by nachname, vorname";
	return sqlSelect($sql);
}

function db_delete_kontakt($kid) {
    if (isCleanNumber($kid)) sqlQuery("delete from kontakte where kid=".$kid);
}
?>