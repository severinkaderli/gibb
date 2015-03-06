<?php
	//Start session
	session_start();

	//Delete old captcha
	unset($_SESSION['captcha']);

	//Characters for captcha
	$chars = "abcdefghiklmnpqrstuvwxy123456789";

	//Number of characters in captcha
	$numChars = 6;
	$captchacode = "";

	//Create captcha
	for($i = 0; $i < $numChars; $i++){
		
	  $captchacode .= substr($chars, (rand()%(strlen($chars))), 1);    
	}

	//Write it in session
	$_SESSION['captcha'] = $captchacode;

	//Change content type to image
	header('Content-type: image/jpg');

	//Create image from background
	$img = ImageCreateFromJPEG('img/assets/captcha_back.jpg');

	//Create color
	$color = ImageColorAllocate($img, rand(0, 55), rand(0, 55), rand(0, 55));

	//Font for image
	$ttf = "fonts/arial.ttf";

	//font size
	$size = 18;

	//angle of the font
	$angle = rand(0, 5);

	//Position of text
	$x = rand(5, 20);
	$y = 24;

	//Create text
	imagettftext($img, $size, $angle, $x, $y, $color, $ttf, $captchacode);

	//Display final image
	imagejpeg($img);

	//Delete Image from memory
	imagedestroy($img);
?>
