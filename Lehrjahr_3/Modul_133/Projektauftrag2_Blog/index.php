<?php
    require_once("./class/DatabaseConnection.php");
    require_once("./class/Blog.php");
    $db = new DatabaseConnection("./blog.db");
    $blog = new Blog($db);
?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title></title>
    <!-- Stylesheets -->
    <link rel="stylesheet" type="text/css" href="./css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="./css/prism.css">

    <!-- Scripts -->
    <script src="./js/bootstrap.min.js"></script>
    <script src="./js/prism.js"></script>
    <style>
    .container {
        max-width: 960px;
    }
    </style>
</head>
<body>
    <div class="container">
        <div class="page-header">
            <h1>Severin Kaderli <small>Blog</small></h1>
        </div>
        <!-- Blog posts -->
        <div class="post">
            <header class="post__header">
                <h1>Posttitel <small>10. November 2015</small></h1>
            </header>
            <div class="post__content">

            </div>
        </div>
        <?php 
            

            //TODO: Test code for stuff
            $sqlResult = $db->query("SELECT username, firstname, lastname FROM users");
            var_dump($sqlResult->fetchArray(SQLITE3_ASSOC));
        ?>
        <!-- Footer -->
        <footer>
            &copy;2015 - Severin Kaderli - <a href="https://github.com/severinkaderli">GitHub</a>
        </footer>
    </div> 
</body>
</html>