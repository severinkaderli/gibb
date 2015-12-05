<?php
require_once("./config.php");

/**
 * Clear and destroy the session
 */
session_unset();
session_destroy();
header("Location: index.php");
exit();