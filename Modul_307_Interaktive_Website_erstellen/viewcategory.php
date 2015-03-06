<?php

	//Include header
	require_once("inc/header.php");
	
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title>Kategorien</title>
		<link rel="stylesheet" type="text/css" href="css/style.css" />
	</head>
	<body>
		<div class="wrapper">
			<div class="navWrapper">
				<?php
					require_once("inc/nav.php");
				?>
			</div>
			<article class="index">
				<?php
					if(isset($_GET["id"]) && is_numeric($_GET["id"]) && $_GET["id"] != 0) {
						$catId = $_GET["id"];
						$imageData = $db -> query("SELECT i.id, i.image, c.category FROM images AS i 
													JOIN categories AS c
														ON c.catid = i.fk_catid
															WHERE i.fk_catid='$catId' 
																ORDER BY i.id DESC");
						echo "<h1>" . $imageData[0] -> category . "</h1>";
						foreach($imageData as $image) {
							echo "<div class='imagewrapper'>";
								echo "<a href='" . ROOTDIR . "viewimage.php?id=" . $image -> id . "'><img src='" . ROOTDIR . $image -> image . "' alt='bild' /></a>";
							echo "</div>";
						}
					} else {
						
						//List the categories
						$categories = $db -> query("SELECT catid, category FROM categories");
						echo "<h1>Kategorien</h1>";
						foreach($categories as $category) {
							echo "<a href='viewcategory.php?id=" . $category -> catid ."'>" . $category -> category . "</a>";
							echo "<br>";
						}
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
