<?php
require_once("./config.php");

if (User::auth()) {
    header("Location: index.php");
    exit();
}

//Process registering process
if (isset($_POST["registerSubmit"])) {

    die("stupid sthit");

    //Todo: Validation of user input and sanitation.
    $user = new User();
    $user->username = $_POST["username"];
    $user->firstname = $_POST["firstname"];
    $user->lastname = $_POST["lastname"];
    $user->password = $_POST["password"];
    $user->isAdmin = 0;

    $user->register();
    $user->login();
}

require_once(__ROOT__ . "Views/register.view.php");
