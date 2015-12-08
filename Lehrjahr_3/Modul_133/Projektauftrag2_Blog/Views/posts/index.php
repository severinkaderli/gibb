<?php
    require_once(__ROOT__ . "Views/_header.php");

	foreach($posts as $post) {
		echo "<div class='post'>";
			echo "<header class='post__header'>";
				echo "<h1><a href='post/$post->id'>$post->title</a> <small>" . strftime(DATE_FORMAT, $post->timestamp) . "</small></h1>";
			echo "</header>";

			echo "<div class='post__content'>";
				echo "<p>$post->content</p>";
			echo "</div>";
		echo "</div>";	
	}

    require_once(__ROOT__ . "Views/_footer.php");