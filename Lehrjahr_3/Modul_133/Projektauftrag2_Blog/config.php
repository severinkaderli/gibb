<?php
/**
 * Starting the session
 */
session_start();
session_regenerate_id();

/**
 * Debugging
 */
define("DEBUG", false);

if(DEBUG) {
    error_reporting(E_ALL);
} else {
    error_reporting(0);
}

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
define("DATE_FORMAT", "d. F Y");

/**
 * Path related settings
 */
define("__ROOT__", __DIR__ . "/");
define("BASE_DIR", "http://" . dirname($_SERVER['SERVER_NAME'] . $_SERVER['PHP_SELF']));


setlocale(LC_ALL, LOCALE);
date_default_timezone_set(TIMEZONE);

/**
 * Class autoloader
 * @param $class
 */
function classAutoload($class) {
    $class = implode("/", explode("\\", $class));
    require_once(__ROOT__ . $class . ".php");
}
spl_autoload_register("classAutoload");


Core\Database\DatabaseConnection::init(__ROOT__ . "Database/blog.db");