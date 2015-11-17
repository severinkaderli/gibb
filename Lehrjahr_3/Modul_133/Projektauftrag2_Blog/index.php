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
    /*TODO: Put this css in an external file*/
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
        <?php
            //GET BLOG POSTS
            $posts = $blog->getPosts();

            print_r($posts);
            foreach($posts as $post) {
                echo "<div class'post'>";
                    echo "<header class='post__header'>";
                        echo "<h1>" . $post["title"] . " <small>" . strftime("%d. %B %Y", $post["timestamp"]) . "</small></h1>";
                    echo "</header>";
                    echo "<div class='post__content'>";
                        echo $post["content"];
                    echo "</div>";
                echo "</div>";


            }
        ?>
        
        <?php 
            

            
        ?>
        <!-- Footer -->
        <footer>
            &copy;2015 - Severin Kaderli - <a href="https://github.com/severinkaderli">GitHub</a>
        </footer>
    </div> 
</body>
</html>