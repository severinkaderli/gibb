<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title><?php echo SITE_TITLE; ?> - <?php echo SITE_AUTHOR; ?></title>
	<!-- Styles -->
	<link rel="stylesheet" type="text/css" href="./css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="./css/prism.css">
	<link rel="stylesheet" type="text/css" href="./css/style.css">
	<!-- Scripts -->
	<script src="./js/bootstrap.min.js"></script>
	<script src="./js/prism.js"></script>
</head>
<body>
	<nav class="navbar navbar-default">
		<div class="container">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false">
				<span class="icon-bar"></span>
				<span class="icon-bar"></span>
				<span class="icon-bar"></span>
				</button>
				<a class="navbar-brand" href="#"><?php echo SITE_TITLE; ?></a>
			</div>
			<div class="collapse navbar-collapse" id="navbar">
				<ul class="nav navbar-nav">
					<li class="active"><a href="#">Link</a></li>
				</ul>
			</div>
		</div>
	</nav>

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