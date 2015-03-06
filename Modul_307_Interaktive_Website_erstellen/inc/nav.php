				<nav>
					<ul>
						<li><a href="index.php">Mainpage</a></li>
						<li><a href="viewcategory.php">Kategorien</a></li>
						<li><a href="random.php">Random</a></li>
						<?php
							if(isset($_SESSION["user"]) && !empty($_SESSION["user"])) {
							
								if($_SESSION["user"]["logged_in"] == true) {
									echo "<li><a href='user.php'>User-Panel</a></li>";
									echo "<li><a href='logout.php'>Logout</a></li>";
									//echo "Eingeloggt als " . $_SESSION["user"]["username"];
								}
							} else {
								echo "<li><a href='login.php'>Login</a></li>";
								echo "<li><a href='register.php'>Registrieren</a></li>";
							}
						?>
						
					</ul>
					<div class="clearfix">
					</div>
				</nav>	
