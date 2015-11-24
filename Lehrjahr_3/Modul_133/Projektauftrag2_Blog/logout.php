<?php 
    require_once("./config.php");
    
    //Clearing sessions and return to the main page
    session_unset();
    session_destroy();
    header("Location: index.php");
    exit();

?>