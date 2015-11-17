<?php

define("LOCALE", "de_DE");    
define("TIMEZONE", "Europe/Zurich");
define("DATE_FORMAT", "%d. %B %Y");


setlocale (LC_ALL, LOCALE);
date_default_timezone_set(TIMEZONE);