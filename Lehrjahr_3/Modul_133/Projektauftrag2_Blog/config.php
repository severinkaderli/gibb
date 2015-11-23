<?php

define("__ROOT__", "/");

/**
 * Time and local related settings
 */
define("LOCALE", "de_DE");    
define("TIMEZONE", "Europe/Zurich");
define("DATE_FORMAT", "%d. %B %Y");


setlocale (LC_ALL, LOCALE);
date_default_timezone_set(TIMEZONE);

require_once("./config.php");
require_once("./core/Database/DatabaseConnection.php");
require_once("./core/Model/Model.php");
require_once("./core/Model/Post.php");
require_once("./core/Model/User.php");


DatabaseConnection::init("./blog.db");