<?php
	//Start PHP-Session
	session_start();
    
    //Set locale to german
    setlocale(LC_ALL, 'de_DE');
	
	//Debugging
	error_reporting(E_ALL);
	
	//Constants for DB-Connection
	define("MYSQL_HOST", "localhost");
	define("MYSQL_USER", "root");
	define("MYSQL_PASS", "");
	define("MYSQL_DB", "modul307");
	
	//Rootdirectory of the script
	define("ROOTDIR", "/Modul307_Projekt/");
	
	//Include important files
	require_once("class/db.class.php");
	require_once("class/user.class.php");
	
	//Create db and user object
	$db = new db(MYSQL_HOST, MYSQL_USER, MYSQL_PASS, MYSQL_DB);
	$user = new User($db);
?>
