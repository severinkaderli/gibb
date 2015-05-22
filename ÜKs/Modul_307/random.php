<?php

	//Include header
	require_once("inc/header.php");
	
	//Fetch a random image id from database
	$random = $db -> query("SELECT id FROM images
								ORDER BY rand()
									LIMIT 1");
									
	//Check if any images exist
	$numRows = count($random);
	
	if($numRows == 0) {
		
		//Redirect to index page when no images are available
		header("Location: index.php");
	} else {
		
		//Redirect to the random image
		$id = $random[0] -> id;
		header("Location: viewimage.php?id=" . $id);
	}
	
	
?>
