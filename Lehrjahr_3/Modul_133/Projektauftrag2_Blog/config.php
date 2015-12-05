<?php
/**
 * Starting the session
 */
session_start();

/**
 * Site related settings
 */
define("SITE_TITLE", "Blog");
define("SITE_AUTHOR", "Severin Kaderli");

/**
 * Time and local related settings
 */
define("LOCALE", "de_DE");
define("TIMEZONE", "Europe/Zurich");
define("DATE_FORMAT", "%d. %B %Y");

/**
 * Path related settings
 */
define("__ROOT__", __DIR__ . "/");
define("BASE_DIR", "http://" . dirname($_SERVER['SERVER_NAME'] . $_SERVER['PHP_SELF']));



setlocale (LC_ALL, LOCALE);
date_default_timezone_set(TIMEZONE);

//Todo: Create an autoloader for classes
require_once("./core/Database/DatabaseConnection.php");
require_once("./core/Model/Model.php");
require_once("./core/Model/Post.php");
require_once("./core/Model/User.php");
require_once("./core/Model/Comment.php");


DatabaseConnection::init(__ROOT__ . "Database/blog.db");