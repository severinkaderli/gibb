<?php
    require_once("./config.php");

    //Process registering process
    if(isset($_POST["registerSubmit"])) {

        //Todo: Validation of user input and sanitation.
        $user = new User();
        $user -> username = $_POST["username"];
        $user -> firstname = $_POST["firstname"];
        $user -> lastname = $_POST["lastname"];
        $user -> password = $_POST["password"];
        $user -> isAdmin = 0;

        $user->register();
        $user->login();
    }

    require_once("./Views/header.php");
    require_once("./Views/register.view.php");
    require_once("./Views/footer.php");
