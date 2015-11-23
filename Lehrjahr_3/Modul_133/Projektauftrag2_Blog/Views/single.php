<?php 
	
	//Check if there's a post with this id
	$postId = $_GET["id"];
	if(!is_numeric($postId)) {
		header("Location: index.php");
		exit();
	}
	$post = Post::find($postId);
	if(is_null($post)) {
		header("Location: index.php");
		exit();
	}

	//Display the post
	echo "<div class='post'>";
		echo "<header class='post__header'>";
			echo "<h1>$post->title <small>" . strftime(DATE_FORMAT, $post->timestamp) . "</small></h1>";
		echo "</header>";

		echo "<div class='post__content'>";
			echo "<p>$post->content</p>";
		echo "</div>";
	echo "</div>";

	//Display comments
?>