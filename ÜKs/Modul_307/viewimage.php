<?php

	//Include header
	require_once("inc/header.php");
	
	//Insert the comment into datebase
	if(isset($_GET["action"]) && $_GET["action"] == "comment") {
	
		$comment = $db -> filter($_POST["commentbox"]);
		$id = $_GET["id"];
		$uid = $_SESSION["user"]["uid"];
		
		//Insert into database
		$db -> query("INSERT INTO comments(fk_id, fk_uid, content, datetime) VALUES('$id', '$uid', '$comment', now())", false);
		
		//Redirect
		$_SESSION["msg"] = "Der Kommentar wurde erfolgreich verfasst!";
		header("Location: viewimage.php?id=" . $id);
		exit;
	}
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title>Bild</title>
		<link rel="stylesheet" type="text/css" href="css/style.css" />
	</head>
	<body>
		<div class="wrapper">
			<div class="navWrapper">
				<?php
					require_once("inc/nav.php");
				?>
			</div>
			<article>
				<?php
					if(isset($_GET["id"]) && is_numeric($_GET["id"]) && $_GET["id"] != 0) {
						$id = $_GET["id"];
						$imageData = $db -> query("SELECT i.image, i.description, i.datetime, u.username, u.uid, u.avatar, c.catid, c.category FROM images AS i 
														JOIN users AS u ON u.uid=i.fk_uid
															JOIN categories AS c ON c.catid=i.fk_catid
																WHERE i.id='$id'");
						foreach($imageData as $image) {
						
							//Image and next/previous arrows
							echo "<div class='fullimg'>";
								echo "<img src='" . ROOTDIR . $image -> image . "' alt='bild' />";
								
								$result = $db -> query("SELECT id FROM images WHERE id < '$id' ORDER BY id DESC LIMIT 1");
								$num = $db -> count($result);
								foreach($result as $row) {
									$prevId = $row -> id;
								}
								
								if($num > 0) {
									echo "<a href='viewimage.php?id=" . $prevId . "'>";
										echo "<div class='leftarrow'>";
										echo "</div>";
									echo "</a>";
								}
								
								$result = $db -> query("SELECT id FROM images WHERE id > '$id' ORDER BY id ASC LIMIT 1");
								$num = $db -> count($result);
								foreach($result as $row) {
									$nextId = $row -> id;
								}
								
								
								if($num > 0) {
									echo "<a href='viewimage.php?id=" . $nextId . "'>";
										echo "<div class='rightarrow'>";
										echo "</div>";
									echo "</a>";
								}
								
								
								
							echo "</div>";
							
							//Description and user avatar
							echo "<div class='imgdetail'>";
								echo "<div class='useravatar'>";
									echo "<img class='avatarPic' src='" . ROOTDIR . $image -> avatar . "' alt='Avatar' />";
								echo "</div>";
								echo "<div class='imgdescription'>";
									echo "<div class='imgheader'>";
										echo "Bild hochgeladen von <a href='profile.php?id=" . $image -> uid . "'>" . $image -> username . "</a> am " . date("d. F Y", strtotime($image -> datetime)) . " um " .  date("H:i:s", strtotime($image -> datetime)) . " in <a href='viewcategory.php?id=" . $image -> catid . "'>" . $image -> category . "</a>";
									echo "</div>";
									echo "<p>" . $image -> description . "</p>";
								echo "</div>";
								echo "<div class='clearfix'>";
								echo "</div>";
							echo "</div>";
							
							//Comments
							echo "<div class='comments'>";
								echo "<h2>Kommentare</h2>";
								if(isset($_SESSION["msg"]) && !empty($_SESSION["msg"])) {
									echo "<p class='errorbox'>" . $_SESSION["msg"] . "</p>";
									unset($_SESSION["msg"]);
								}
								
								$comments = $db -> query("SELECT c.cid, c.fk_id, c.fk_uid, c.answerId, c.content, c.datetime, u.uid, u.username, u.avatar FROM comments AS c
															JOIN users AS u
																ON u.uid=c.fk_uid
																	WHERE c.fk_id = '$id' AND c.answerId=0
																		ORDER BY c.cid ASC");
								foreach($comments as $comment) {
									echo "<div class='commentwrapper'>";
										echo "<div class='userimg'>";
											echo "<img class='avatarPic' src='" . ROOTDIR . $comment -> avatar . "' alt='Avatar' />";
										echo "</div>";
										echo "<div class='comment'>";
											echo "<div class='commentheader'>";
												echo "Kommentar von <a href='profile.php?id=" . $comment -> uid . "'>" . $comment -> username . "</a> am " . date("d. F Y", strtotime($comment -> datetime)) . " um " .  date("H:i:s", strtotime($comment -> datetime));
											echo "</div>";
											echo "<p>" . $comment -> content . "</p>";							
										echo "</div>";
										echo "<div class='clearfix'>";
										echo "</div>";
									echo "</div>";
								}
								
								if($user -> logged_in()) {
									
									//Form for comments
									echo "<form action='" . $_SERVER["PHP_SELF"] . "?id=" . $_GET["id"] . "&amp;action=comment' method='POST'>";
										echo "<p>";
											echo "<label for='commentbox'></label>";
											echo "<textarea name='commentbox' id='commentbox'></textarea>";
										echo "</p>";
										echo "<p>";
											echo "<input type='submit' value='Kommentieren'";
										echo "</p>";
									
									echo "</form>";
								
								} else {
									echo "<p>Bitte <a href='login.php'>melde</a> dich an, um einen Kommentar zu verfassen.</p>";
								}
								
							echo "</div>";
						}
					} else {
						
						//Redirect to mainpage
						header("Location: index.php");
					}
					
				?>
				<div class="clearfix">
				</div>
			</article>	
			<footer>
				<small>&copy;2014 - Severin Kaderli</small>
			</footer>
		</div>
	</body>
</html>
