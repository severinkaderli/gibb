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

	$postUser = User::find($post->fk_user_id);

	//Display the post
	echo "<div class='post'>";
		echo "<header class='post__header'>";
			echo "<h1>$post->title<br><small>" . strftime(DATE_FORMAT, $post->timestamp) . " von $postUser->firstname $postUser->lastname</small></h1>";
		echo "</header>";

		echo "<div class='post__content'>";
			echo "<p>$post->content</p>";
		echo "</div>";
	echo "</div>";

	//Display comments
	echo "<h3>Kommentare</h3>";
	$comments = Comment::getByPostId($post->id);
	if(is_null($comments)) {
		echo "<p>Keine Kommentare vorhanden</p>";
	} else {

		foreach($comments as $comment) {

			$user = User::find($comment->fk_user_id);

			echo "<div class='comment panel panel-default panel-body'>";
				echo "<header class='comment__header'>";
					echo "<p>Kommentar veröffentlicht von $user->firstname $user->lastname</p>"; 
				echo "</header>";
				echo "<div class='comment_content'>";
					echo $comment->comment;
				echo "</div>";

			echo "</div>";
			
		}
	}

	//Only show add comment if logged in
	echo "<h3>Kommentar verfassen</h3>";
	if(User::auth()) {
		
		echo "<form method='POST' action=''>";
			echo "<div class='form-group'>";
				echo "<textarea id='comment' rows='5' name='comment' class='form-control'></textarea>";
			echo "</div>";
			echo "<div class='form-group'>";
				echo "<input type='submit' class='btn btn-default' value='Kommentar absenden'>";
			echo "</div>";
		echo "</form>";
	} else {
		echo "<p>Sie müssen eingeloggt sein, um einen Kommentar zu verfassen!</p>";
	}
?>