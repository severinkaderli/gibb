<!DOCTYPE html>
<html>
<head>
    <base href="<?php echo BASE_DIR; ?>/">
    <meta charset="utf-8">
    <title><?php echo SITE_TITLE; ?> - <?php echo SITE_AUTHOR; ?></title>
    <!-- Styles -->
    <link rel="stylesheet" type="text/css" href="Assets/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="Assets/css/prism.css">
    <link rel="stylesheet" type="text/css" href="Assets/css/style.css">
    <!-- Scripts -->
    <script src="Assets/js/jquery-2.1.4.min.js"></script>
    <script src="Assets/js/bootstrap.min.js"></script>
    <script src="Assets/js/prism.js"></script>
</head>
<body>
<nav class="navbar navbar-inverse">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar"
                    aria-expanded="false">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="<?php echo BASE_DIR; ?>/"><?php echo SITE_TITLE; ?></a>
        </div>
        <div class="collapse navbar-collapse" id="navbar">
            <?php
            if (Core\Model\User::auth()) {
                echo "<p class='navbar-text'>Eingeloggt als " . $_SESSION['user']['username'] . "</p>";
            }
            ?>

            <ul class="nav navbar-nav">
                <li class="nav-divider"></li>
                <?php

                if (Core\Model\User::auth()) {
                    echo "<li><a href='create'>Eintrag erstellen</a></li>";
                    echo "<li><a href='logout'>Logout</a></li>";
                } else {
                    echo "<li><a href='login'>Login</a></li>";
                    echo "<li><a href='register'>Registrieren</a></li>";
                }
                ?>
            </ul>
        </div>
    </div>
</nav>

<div class="container">
    <!-- Main Content -->

	   