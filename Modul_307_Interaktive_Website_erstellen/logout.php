<?php

	//Include header
	require_once("inc/header.php");
	
	//Logout
	$user -> logout();
	
	//Redirect to login page
	header("Location: login.php");
?>
