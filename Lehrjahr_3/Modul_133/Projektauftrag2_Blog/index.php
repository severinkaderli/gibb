<?php
    require_once("./config.php");
?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title></title>
    <!-- Stylesheets -->
    <link rel="stylesheet" type="text/css" href="./css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="./css/prism.css">
    <link rel="stylesheet" type="text/css" href="./css/style.css">

    <!-- Scripts -->
    <script src="./js/bootstrap.min.js"></script>
    <script src="./js/prism.js"></script>
</head>
<body>
    <div class="container">
        <div class="page-header">
            <h1>Severin Kaderli <small>Blog</small></h1>
        </div>
        <!-- Blog posts -->
        <?php
            
            
            $posts = User::find(1);
            echo "<pre>";
                print_r($posts);
            echo "</pre>";
        ?>
        <!-- Footer -->
        <footer id="footer">
            &copy;2015 - Severin Kaderli - <a href="https://github.com/severinkaderli">GitHub</a>
        </footer>
    </div> 
</body>
</html>