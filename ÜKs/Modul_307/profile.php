<?php

	//Start session
	require_once("inc/header.php");
	
	//Get id
	if(isset($_GET["id"]) && !empty($_GET["id"])) {
		
		$uid = $_GET["id"];
	} else {
	
		//Redirect to index page
		header("Location: index.php");
	}
	
	//Get user data
	$userData = $db -> query("SELECT username, description, avatar FROM users
								WHERE uid='$uid'");
	$username = $userData[0] -> username;
	$description = $userData[0] -> description;
	$avatar = $userData[0] -> avatar;
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title><?php echo $username; ?></title>
		<link rel="stylesheet" type="text/css" href="css/style.css" />
	</head>
	<body>
		<div class="wrapper">
			<div class="navWrapper">
				<?php
					require_once("inc/nav.php");
				?>
			</div>
			<article class="leftCol">
				<div class="avatar">
					<?php
						echo "<img class='avatarPic' src='" . ROOTDIR . $avatar . "' alt='Avatar' />";
					?>
				</div>
				<div class="description">
					<p>
						<?php echo $username;?>
					</p>
				</div>
				<div class="actions">
					<p>
						<?php echo $description; ?>
					</p>
				</div>
			</article>	
			<article class="rightCol">
				<?php
					
					//Fetch the images
					$imageData = $db -> query("SELECT i.id, i.image, i.datetime, i.description, i.fk_catid, c.category FROM images AS i
													JOIN categories AS c ON i.fk_catid=c.catid
														WHERE i.fk_uid = '$uid'
															ORDER BY id DESC");
					
					foreach($imageData as $image) {
						echo "<div class='imageWrapper'>";
							echo "<div class='imageHeader'>";
								echo date("d. F Y H:i:s", strtotime($image -> datetime));
							echo "</div>";
							echo "<div class='categoryOverlay'>";
								echo "<a href='viewcategory.php?id=" . $image -> fk_catid . "'>#" . $image -> category . "</a>";
							echo "</div>";
							echo "<div class='image'>";
								echo "<a href='viewimage.php?id=" . $image -> id . "'>";
									echo "<img src='" . ROOTDIR . $image -> image . "' alt='' />";
								echo "</a>";
								echo "<div class='imageDescription'>";
									echo "<p>" . $image -> description . "</p>";
								echo "</div>";
							echo "</div>";
						echo "</div>";
					}
				?>
			</article>
			<div class="clearfix">
			</div>
			<footer>
				<small>&copy;2014 - Severin Kaderli</small>
			</footer>
		</div>
	</body>
</html>
