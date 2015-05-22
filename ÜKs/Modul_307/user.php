<?php

	//Start session
	require_once("inc/header.php");
	
	
	//Redirect to login page if user is not logged in
	if($user -> logged_in() == false) {
		
		header("Location: login.php");
	}
	
	//Get user data
	$uid = $_SESSION["user"]["uid"];
	$userData = $db -> query("SELECT avatar FROM users WHERE uid='$uid'");
	$avatar = $userData[0] -> avatar;
	
	//Save a image to database
	if(isset($_GET["action"]) && $_GET["action"] == "save") {
	
		//Create variables
		$imagePath = "img/upload/";
		$target = $imagePath . $_FILES["upload"]["name"];
		$file = $_FILES['upload']['tmp_name'];
		$description = $db -> filter($_POST["description"]);
		$category = $db -> filter($_POST["category"]);
		
		//Check if category or description is empty
		if(empty($category) OR $category == "") {
			$_SESSION["msg"] = "Bitte wählen Sie eine Kategorie aus!";
			header("Location: user.php?action=upload");
			exit;
		}
		
		if(empty($description) || $description == "") {
			$_SESSION["msg"] = "Bitte beschreiben Sie das Bild!";
			header("Location: user.php?action=upload");
			exit;
		}
		
		$uid = $_SESSION["user"]["uid"];
		$cat = $db -> query("SELECT catid FROM categories WHERE category='$category'");
		if(count($cat) < 1) {
			
			//Insert new category
			$db -> query("INSERT INTO categories(category)
							VALUES('$category')", false);
		}
		
		$cat = $db -> query("SELECT catid FROM categories WHERE category='$category'");
		
		//Fetch category id
		$catId = $cat[0] -> catid;

		
		//Check if image is valid	
		if (file_exists($file)) {
		
			$imagesizedata = getimagesize($file);
			
			if ($imagesizedata === FALSE) {
			
					//File isn't a image
					$_SESSION["msg"] = "Bitte laden sie nur Bilder hoch!";
					header("Location: user.php?action=upload");
			} else{
					//Image is valid and ready to upload
					move_uploaded_file($_FILES["upload"]["tmp_name"], $target);
					
					//Insert into database
					$db -> query("INSERT INTO images(image, description, datetime, fk_uid, fk_catid)
									VALUES('$target', '$description', now(), '$uid', '$catId')", false);
					
					//Redirect to user page
					header("Location: user.php");
			}
		} else {
				//File not uploaded
				$_SESSION["msg"] = "Bitte laden Sie ein Bild hoch!";
				header("Location: user.php?action=upload");
		}		
	
	} elseif(isset($_GET["action"]) && $_GET["action"] == "delete" && isset($_GET["id"])) {
	
		//Delete an image
	
		//Create variables
		$imageId = $_GET["id"];
		
		//Get category id for later
		$category = $db -> query("SELECT image, fk_catid FROM images WHERE id='$imageId'");
		$catId = $category[0] -> fk_catid;
		$imagePath = $category[0] -> image;
		
		//Delete image from database
		$db -> query("DELETE FROM images WHERE id='$imageId'", false);
		
		//Delete image from server
		unlink($imagePath);
		
		//Check if category is still used
		$checkCategory = $db -> query("SELECT id FROM images WHERE fk_catid='$catId'");
		$num_rows = count($checkCategory);
		
		//Delete category if not used anymore
		if($num_rows == 0) {
			$db -> query("DELETE FROM categories WHERE catid='$catId'", false);
		}
		
		//Redirect to user page
		$_SESSION["msg"] = "Das Bild wurde erfolgreich gelöscht!";
		header("Location: user.php");
		exit;
		
	} elseif(isset($_GET["action"]) && $_GET["action"] == "update" && isset($_GET["id"])) {
		
		//Update a image
		
		//Create variables
		$imageId = $_GET["id"];
		$description = $db -> filter($_POST["description"]);
		$category = $db -> filter($_POST["category"]);
		
		//Check if category and description are set
		if(empty($category) || $category == "") {
			$_SESSION["msg"] = "Bitte wählen Sie eine Kategorie aus!";
			header("Location: user.php?action=edit&id=" . $imageId);
			exit;
		}
		
		if(empty($description) || $description == "") {
			$_SESSION["msg"] = "Bitte beschreiben Sie das Bild!";
			header("Location: user.php?action=edit&id=" . $imageId);
			exit;
		}
		
		//If category doesn't exist yet
		$cat = $db -> query("SELECT catid FROM categories WHERE category='$category'");
		if(count($cat) == 0) {
			
			//Insert new category
			$db -> query("INSERT INTO categories(category)
							VALUES('$category')", false);
		}
		
		$cat = $db -> query("SELECT catid FROM categories WHERE category='$category'");
		$catId = $cat[0] -> catid;
		
		//Get old category id for later
		$category = $db -> query("SELECT fk_catid FROM images WHERE id='$imageId'");
		$oldCatId = $category[0] -> fk_catid;
		
		//Update the image
		$db -> query("UPDATE images SET description='$description', fk_catid='$catId' WHERE id='$imageId'", false);
		
		//Check if category is still used
		$checkCategory = $db -> query("SELECT id FROM images WHERE fk_catid='$oldCatId'");
		$num_rows = count($checkCategory);
		
		//Delete category if not used anymore
		if($num_rows == 0) {
			$db -> query("DELETE FROM categories WHERE catid='$oldCatId'", false);
		}
		
		//Redirect to user page
		header("Location: user.php");
		
	} elseif(isset($_GET["changepassword"]) && $_GET["changepassword"] == "true") {
		
		//Define variables
		$oldPass = md5($_POST["oldpassword"]);
		$newPass1 = md5($_POST["newpassword1"]);
		$newPass2 = md5($_POST["newpassword2"]);
		
		//Get the old password from database
		$oldPassword = $db -> query("SELECT password FROM users WHERE uid='$uid'");
		
		if($oldPass == $oldPassword[0] -> password) {
			if($newPass1 == $newPass2) {
				
				//Change password
				$db -> query("UPDATE users SET password='$newPass1' WHERE uid='$uid'", false);
				
				//Redirect to user page
				$_SESSION["msg"] = "Das Passwort wurde erfolgreich geändert!";
				header("Location: user.php");
				exit;
				
			} else {
				
				//Passwords aren't the same
				$_SESSION["msg"] = "Die Passwörter stimmen nicht überein!";
				header("Location: user.php?action=changepassword");
				exit;
			}
		} else {
			
			//Old password isn't right
			$_SESSION["msg"] = "Das alte Passwort stimmt nicht!";
			header("Location: user.php?action=changepassword");
			exit;
			
		}
		
		
	} elseif(isset($_GET["changeavatar"]) && $_GET["changeavatar"] == "true") {
		
		//Change the avatar
		$imagePath = "img/avatars/";
		$target = $imagePath . $_FILES["avatarupload"]["name"];
		$file = $_FILES["avatarupload"]["tmp_name"];
		
		//Check if image is valid	
		if (file_exists($file)) {
		
			$imagesizedata = getimagesize($file);
			
			if ($imagesizedata === FALSE) {
			
					//File isn't a image
					//Set image to default one
					$imagePath = "img/assets/default_avatar.png";
					
					//Update database
					$db -> query("UPDATE users SET avatar='$imagePath' WHERE uid='$uid'", false);
					
					//Redirect to user page
					$_SESSION["msg"] = "Der Avatar wurde erfolgreich geändert!";
					header("Location: user.php");
					exit;
					
			} else{
					//Image is valid and ready to upload
					move_uploaded_file($file, $target);
					
					//Update database
					$db -> query("UPDATE users SET avatar='$target' WHERE uid='$uid'", false);
					
					//Redirect to user page
					$_SESSION["msg"] = "Der Avatar wurde erfolgreich geändert!";
					header("Location: user.php");
					exit;
			}
		} else {
			
			//Set image to default one
			$imagePath = "img/assets/default_avatar.png";
			
			//Update database
			$db -> query("UPDATE users SET avatar='$imagePath' WHERE uid='$uid'", false);
			
			//Redirect to user page
			$_SESSION["msg"] = "Der Avatar wurde erfolgreich geändert!";
			header("Location: user.php");
			exit;
		}
		
	} elseif(isset($_GET["changetext"]) && $_GET["changetext"] == "true") {
		
		//Define variables
		$newText = $db -> filter($_POST["usertext"]);
		
		//Write the new text in db
		$db -> query("UPDATE users SET description='$newText' WHERE uid='$uid'", false);
		
		//Redirect to user page
		$_SESSION["msg"] = "Der Profiltext wurde erfolgreich geändert!";
		header("Location: user.php");
		exit;
		
	} elseif(isset($_GET["action"]) && $_GET["action"] == "deleteuser") {
		
		//Save uid in a variable
		$uid = $_GET["id"];
		
		//Delete user
		$db -> query("DELETE FROM users WHERE uid='$uid'", false);
		
		//Delete user's images
		$db -> query("DELETE FROM images WHERE fk_uid='$uid'", false);
		
		//Delete user's comments
		$db -> query("DELETE FROM comments WHERE fk_uid='$uid'", false);
		
		//Redirect to user page
		$_SESSION["msg"] = "Benutzer wurde erfolgreich gelöscht";
		header("Location: user.php?action=manageusers");
		exit;
		
	} elseif(isset($_GET["changeemail"]) && $_GET["changeemail"] == "true") {
		
		//Define variables
		$oldMail = $_POST["oldemail"];
		$newMail = $_POST["newemail"];
		$uid = $_SESSION["user"]["uid"];
		
		//Get the old email from database
		$oldAddress = $db -> query("SELECT email FROM users WHERE uid='$uid'");
		
		if($oldMail == $oldAddress[0] -> email) {
				
			//Change e-mail
			$db -> query("UPDATE users SET email='$newMail' WHERE uid='$uid'", false);
			
			//Redirect to user page
			$_SESSION["msg"] = "Die E-Mail Adresse wurde erfolgreich geändert!";
			header("Location: user.php");
			exit;

		} else {
			
			//Old email isn't right
			$_SESSION["msg"] = "Die alte E-Mail Adresse stimmt nicht!";
			header("Location: user.php?action=changeemail");
			exit;
			
		}
	} elseif(isset($_GET["action"]) && $_GET["action"] == "demoteuser") { 
        
        $uid = $_GET["id"];
        
        //Change user level to 0
        $db -> query("UPDATE users SET is_admin=0
                           WHERE uid='$uid'", false);
                           
        $_SESSION["msg"] = "Der Benutzer wurde zu einem normalem Benutzer runtergestuft!";
		header("Location: user.php?action=manageusers");
		exit;
        
    } elseif(isset($_GET["action"]) && $_GET["action"] == "promoteuser") { 
        
        $uid = $_GET["id"];
        
        //Change user level to 1
        $db -> query("UPDATE users SET is_admin=1
                        WHERE uid='$uid'", false);
                        
        $_SESSION["msg"] = "Der Benutzer wurde zu einem Admin promoviert!";
		header("Location: user.php?action=manageusers");
		exit;
    }
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<title>Benutzer - <?php echo $_SESSION["user"]["username"]; ?></title>
		<link rel="stylesheet" type="text/css" href="css/style.css" />
		<script>
		//Confirmation dialog for deleting images
		function check(text) {
			return confirm(text);
		}	
		</script>
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
					<p>Wilkommen zurück,
						<br>
						<?php echo $_SESSION["user"]["username"];?>
					</p>
				</div>
				<div class="actions">
					<p>
						<a href="user.php">Bilderübersicht</a>
						<br>
						<a href="?action=upload">Bild hochladen</a>
					</p>
					<h3>Benutzeroptionen</h3>
					<p>
						<a href="?action=changepassword">Passwort ändern</a>
						<br>
						<a href="?action=changeemail">E-Mail ändern</a>
						<br>
						<a href="?action=changeavatar">Profilbild ändern</a>
						<br>
						<a href="?action=changetext">Profiltext ändern</a>
						<br>
					</p>
					<?php
					if($_SESSION["user"]["is_admin"] > 0) {
						
						echo "<h3>Adminoptionen</h3>";
						echo "<p>";
							echo "<a href='?action=manageusers'>Benutzerverwaltung</a>";
						echo "</p>";
					}
					?>
				</div>
			</article>	
			<article class="rightCol">
				<?php
					//Show images
					if(!isset($_GET["action"]) || (isset($_GET["action"]) && $_GET["action"] == "show")) {
						//Fetch the images
						$imageData = $db -> query("SELECT i.id, i.image, i.description, i.datetime, i.fk_catid, c.category FROM images AS i
														JOIN categories AS c ON c.catid=i.fk_catid
															WHERE fk_uid = '$uid'
																ORDER BY id DESC");
						if(isset($_SESSION["msg"]) && !empty($_SESSION["msg"])) {
							echo "<p class='errorbox'>" . $_SESSION["msg"] . "</p>";
							unset($_SESSION["msg"]);
						}
						
						foreach($imageData as $image) {
							echo "<div class='imageWrapper'>";
								echo "<div class='imageHeader'>";
									echo date("d. F Y H:i:s", strtotime($image -> datetime));
								echo "</div>";
								echo "<div class='categoryOverlay'>";
									echo "<a href='viewcategory.php?id=" . $image -> fk_catid . "'>#" . htmlentities($image -> category, ENT_QUOTES) . "</a>";
								echo "</div>";
								echo "<div class='image'>";
									echo "<img src='" . ROOTDIR . $image -> image . "' alt='' />";
									echo "<div class='imageDescription'>";
										echo "<p>" . $image -> description . "</p>";
									echo "</div>";
								echo "</div>";
								echo "<div class='toolbar'>";
									echo "<a href='" . $_SERVER["PHP_SELF"] . "?action=edit&amp;id=" . $image -> id . "'>Bearbeiten</a> <a href='" . $_SERVER["PHP_SELF"] . "?action=delete&amp;id=" . $image -> id . "' onclick='return check(\"Willst du das Bild wirklich löschen?\");'>Löschen</a>";
								echo "</div>";
							echo "</div>";
						}
					} elseif (isset($_GET["action"]) && $_GET["action"] == "upload") {
					
						//Show upload form
						echo "<h1>Bild hochladen</h1>";
						if(isset($_SESSION["msg"]) && !empty($_SESSION["msg"])) {
							echo "<p class='errorbox'>" . $_SESSION["msg"] . "</p>";
							unset($_SESSION["msg"]);
						}
						echo "<form action='" . $_SERVER["PHP_SELF"] . "?action=save' method='POST' enctype='multipart/form-data' />";
							echo "<p>";
								echo "<label for='upload'>Bild auswählen</label>";
								echo "<br>";
								echo "<input type='file' name='upload' id='upload' />";
							echo "</p>";
							echo "<p>";
								echo "<label for='description'>Beschreibung</label>";
								echo "<br>";
								echo "<textarea id='description' name='description'></textarea>";
							echo "</p>";
							echo "<p>";
								echo "<label for='category'>Kategorie</label>";
								echo "<br>";
								echo "<input type='text' name='category' id='category' list='catList' />";
								echo "<datalist id='catList'>";
									
									//Get categories
									$cats = $db -> query("SELECT catid, category FROM categories ORDER BY category ASC");
									foreach($cats as $cat) {
										echo "<option>" . $cat -> category . "</option>";
									}

								echo "</datalist>";
							echo "</p>";
							echo "<p>";
								echo "<input type='submit' value='Bild hochladen' />";
							echo "</p>";
						echo "</form>";
					} elseif (isset($_GET["action"]) && $_GET["action"] == "edit" && isset($_GET["id"])) {
					
						/***************/
						/*Edit an image*/
						/***************/
					
						//Create variables
						$id = $_GET["id"];
						
						//Get image data
						$image = $db -> query("SELECT i.image, i.description, c.category FROM images AS i
													JOIN categories AS c ON c.catid=i.fk_catid
														WHERE id='$id'");
					
						//Show upload form
						echo "<h1>Bild bearbeiten</h1>";
						if(isset($_SESSION["msg"]) && !empty($_SESSION["msg"])) {
							echo "<p class='errorbox'>" . $_SESSION["msg"] . "</p>";
							unset($_SESSION["msg"]);
						}
						echo "<form action='" . $_SERVER["PHP_SELF"] . "?action=update&amp;id=" . $id . "' method='POST' enctype='multipart/form-data' />";
							echo "<p>";
								echo "<img class='editimg' src='" . $image[0] -> image . "' alt='image' />";
							echo "</p>";
							echo "<p>";
								echo "<label for='description'>Beschreibung</label>";
								echo "<br>";
								echo "<textarea id='description' name='description'>" . $image[0] -> description . "</textarea>";
							echo "</p>";
							echo "<p>";
								echo "<label for='category'>Kategorie</label>";
								echo "<br>";
								echo "<input type='text' name='category' value='" . htmlentities($image[0] -> category, ENT_QUOTES) . "' id='category' list='catList' />";
								echo "<datalist id='catList'>";
									
									//Get categories
									$cats = $db -> query("SELECT catid, category FROM categories ORDER BY category ASC");
									foreach($cats as $cat) {
										echo "<option>" . $cat -> category . "</option>";
									}

								echo "</datalist>";
							echo "</p>";
							echo "<p>";
								echo "<input type='submit' value='Bild updaten' />";
							echo "</p>";
						echo "</form>";
					} elseif (isset($_GET["action"]) && $_GET["action"] == "changepassword") {
						
						echo "<h1>Passwort ändern</h1>";
						if(isset($_SESSION["msg"]) && !empty($_SESSION["msg"])) {
							echo "<p class='errorbox'>" . $_SESSION["msg"] . "</p>";
							unset($_SESSION["msg"]);
						}
						
						//Form for changing the password
						echo "<form method='POST' action='" . $_SERVER["PHP_SELF"] ."?changepassword=true' >";
							echo "<p>";
								echo "<label for='oldpassword'>Altes Passwort</label>";
								echo "<br>";
								echo "<input type='password' name='oldpassword' id='oldpassword' />";
							echo "</p>";
							echo "<p>";
								echo "<label for='newpassword1'>Neues Passwort</label>";
								echo "<br>";
								echo "<input type='password' name='newpassword1' id='newpassword1' />";
							echo "</p>";
							echo "<p>";
								echo "<label for='newpassword2'>Neues Passwort bestätigen</label>";
								echo "<br>";
								echo "<input type='password' name='newpassword2' id='newpassword2' />";
							echo "</p>";
							echo "<p>";
								echo "<input type='submit' value='Passwort ändern' />";
							echo "</p>";		
						echo "</form>";	
						
						
					}elseif (isset($_GET["action"]) && $_GET["action"] == "changeavatar") {
						
						echo "<h1>Profilbild ändern</h1>";
						
						//Show existing avatar
						$avatar = $db -> query("SELECT avatar FROM users WHERE uid='$uid'");
						$imagePath = $avatar[0] -> avatar;
						
						echo "<img class='useravatar' src='" . ROOTDIR . $imagePath . "' alt='Avatar' />";
						
						//Form for changing the avatar
						echo "<form method='POST' action='" . $_SERVER["PHP_SELF"] ."?changeavatar=true' enctype='multipart/form-data' >";
							echo "<p>";
								echo "<input type='file' name='avatarupload' id='avatarupload' />";
							echo "</p>";
							echo "<p>";
								echo "<input type='submit' value='Profilbild ändern' />";
							echo "</p>";		
						echo "</form>";	
						
						
					} elseif (isset($_GET["action"]) && $_GET["action"] == "changetext") {
						
						//Get old description
						$description = $db -> query("SELECT description FROM users WHERE uid='$uid'");
						$usertext = $description[0] -> description;
						
						//Form for changing the profile text
						echo "<h1>Profiltext ändern</h1>";
						echo "<form method='POST' action='" . $_SERVER["PHP_SELF"] ."?changetext=true' >";
							echo "<p>";
								echo "<textarea name='usertext' id='usertext'>" . $usertext . "</textarea>";
							echo "</p>";
							echo "<p>";
								echo "<input type='submit' value='Profiltext ändern' />";
							echo "</p>";		
						echo "</form>";	
	
					} elseif (isset($_GET["action"]) && $_GET["action"] == "manageusers") {
						
						if($_SESSION["user"]["is_admin"] < 1) {
							
							//Redirect to user page
							header("Location: user.php");
						}
                        if(isset($_SESSION["msg"]) && !empty($_SESSION["msg"])) {
							echo "<p class='errorbox'>" . $_SESSION["msg"] . "</p>";
							unset($_SESSION["msg"]);
						}
						//Manage users
						$users = $db -> query("SELECT uid, username, is_admin FROM users");
						echo "<h1>Benutzerverwaltung</h1>";
						echo "<table>";
                            echo "<tr>";
                                echo "<th>UID</th>";
                                echo "<th>Benutzername</th>";
                                echo "<th>Rang</th>";
                                echo "<th>Rang ändern</th>";
                                echo "<th>Löschen</th>";
                            echo "</tr>";
						
						foreach($users AS $user2) {
							echo "<tr>";
                                echo "<td>" . $user2 -> uid . "</td>";
								echo "<td>" . $user2 -> username . "</td>";
                                //If user is super admin
								if($_SESSION["user"]["is_admin"] == 2) {
									if($user2 -> uid != $_SESSION["user"]["uid"]) {
                                        if($user2 -> is_admin == 1) {
                                            echo "<td>Admin</td>";
                                            echo "<td><a href='?action=demoteuser&amp;id=" . $user2 -> uid ."'>Runterstufen</a></td>";
                                        } else {
                                            echo "<td>Normaler Benutzer</td>";
                                            echo "<td><a href='?action=promoteuser&amp;id=" . $user2 -> uid ."'>Hochstufen</a></td>";
                                            
                                        }
                                        
										echo "<td><a onclick='return check(\"Willst du diesen Benutzer wirklich löschen?\");'href='?action=deleteuser&amp;id=" . $user2 -> uid ."'>Löschen</a></td>";
									} else {
                                        echo "<td>Super Admin</td>";
                                        echo "<td></td>";
                                        echo "<td></td>";
                                    }
                                //If user is normal admin
								} elseif($_SESSION["user"]["is_admin"] == 1) {
                                    if($user2 -> uid != $_SESSION["user"]["uid"] && $user2 -> is_admin == 0) {
                                        if($user2 -> is_admin == 1) {
                                            echo "<td><a href='?action=demoteuser&amp;id=" . $user2 -> uid ."'>Runterstufen</a></td>";
                                        } else {
                                            echo "<td><a href='?action=promoteuser&amp;id=" . $user2 -> uid ."'>Hochstufen</a></td>";
                                        }
                                        echo "<td><a href='?action=deleteuser&amp;id=" . $user2 -> uid ."'>Löschen</a></td>";
                                    } else {
                                        echo "<td>Super Admin</td>";
                                        echo "<td></td>";
                                        echo "<td></td>";
                                    }
								} 
                                
								
							echo "</tr>";	
						}	
						echo "</table>";	
					} elseif (isset($_GET["action"]) && $_GET["action"] == "changeemail") {
						
						
						echo "<h1>E-Mail Adresse ändern</h1>";
						if(isset($_SESSION["msg"]) && !empty($_SESSION["msg"])) {
							echo "<p class='errorbox'>" . $_SESSION["msg"] . "</p>";
							unset($_SESSION["msg"]);
						}
						echo "<form method='POST' action='" . $_SERVER["PHP_SELF"] ."?changeemail=true' >";
							echo "<p>";
								echo "<label for='oldemail'>Alte E-Mail Adresse</label>";
								echo "<br>";
								echo "<input type='email' name='oldemail' id='oldemail' />";
							echo "</p>";
							echo "<p>";
								echo "<label for='newemail'>Neue E-Mail Adresse</label>";
								echo "<br>";
								echo "<input type='email' name='newemail' id='newemail' />";
							echo "</p>";	
							echo "<p>";
								echo "<input type='submit' value='E-Mail ändern' />";
							echo "</p>";	
						echo "</form>";	
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
