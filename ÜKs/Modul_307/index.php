<?php

	//Include the header
	require_once("inc/header.php");
	
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title>Index</title>
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
					$imageData = $db -> query("SELECT * FROM images ORDER BY id DESC");
					foreach($imageData as $image) {
						echo "<div class='imagewrapper'>";
							echo "<a href='" . ROOTDIR . "viewimage.php?id=" . $image -> id . "'><img src='" . ROOTDIR . $image -> image . "' alt='bild' /></a>";
						echo "</div>";
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
