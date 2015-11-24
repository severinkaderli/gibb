<?php
    require_once("./config.php");  

    if(User::auth()) {
        header("Location: index.php");
        exit();
    }

    if(isset($_POST["loginSubmit"])) {

        $user = new User();
        $user -> username = $_POST["username"];
        $user -> password = $_POST["password"];
        $user->login();
    }

    require_once("./Views/header.php");
    require_once("./Views/login.view.php");
    require_once("./Views/footer.php");
?>
