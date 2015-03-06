<?php
	class user {
				
		protected $db;
		
		//Login
		public function login($username, $password, $useCookies = false) {
			$username = $this -> db -> filter($username);
			$password = md5($password);
			
			$checkUser = $this -> db -> query("SELECT uid, is_admin FROM users WHERE username='$username' AND password='$password'");
			
			$num_rows = count($checkUser);
			
			if($num_rows == 1) {
				
				//Success
				//Set cookie to remember login if neccesary
				if($useCookies) {
					
					setcookie("username", $username, time()+(3600*24*100));
					setcookie("password", $password, time()+(3600*24*100));
				}
				
				//Set Session Cookies
				$_SESSION["user"]["uid"] = $checkUser[0] -> uid;
				$_SESSION["user"]["username"] = $username;
				$_SESSION["user"]["is_admin"] = $checkUser[0] -> is_admin;
				$_SESSION["user"]["logged_in"] = true;
				
				return true;
				
			} else {
				
				//Fail
				return false;	
			}
		}
		
		
		// Check for cookies to login
		public function cookieLogin() {
				
			if(isset($_COOKIE["username"]) && isset($_COOKIE["password"])) {
				
				$username = $_COOKIE["username"];
				$password = $_COOKIE["password"];
				
				$checkUser = $this -> db -> query("SELECT uid, is_admin FROM users WHERE username='$username' AND password='$password'");
				
				$numRows = count($checkUser);
				
				if($numRows == 1) {		
					
					//Set cookie to remember login if neccesary
					setcookie("username", $username, time()+(3600*24*100));
					setcookie("password", $password, time()+(3600*24*100));
					
					//Set Session Cookies
					$_SESSION["user"]["uid"] = $checkUser[0] -> uid;
					$_SESSION["user"]["username"] = $username;
					$_SESSION["user"]["is_admin"] = $checkUser[0] -> is_admin;
					$_SESSION["user"]["logged_in"] = true;
					
					return true;
					
				} else {
					
					return false;
				}
				
			} else {
				
				return false;
			}
		}
		
		//Get login status
		public function logged_in() {
				
				if(isset($_SESSION["user"]["logged_in"])) {
					return $_SESSION["user"]["logged_in"];
				} else {
					return false;
				}
				
		}
		
		//Check if user exists
		public function exists($username) {
			
			$checkUser = $this -> db -> query("SELECT uid FROM users WHERE username='$username'");
			$numRows = count($checkUser);
			if($numRows == 0) {
				
				//User doesn't exist
				return false;
			} else {
			
				//User exists
				return true;
			}
		}
		
		//logout
		public function logout() {
				
				$_SESSION["user"]["logged_in"] = false;
				
				//Delete Session-Cookie
				if (ini_get("session.use_cookies")) {
					$params = session_get_cookie_params();
					setcookie(session_name(), '', time() - 42000,
						$params["path"], $params["domain"],
						$params["secure"], $params["httponly"]
					);
				}

				//Destroy Session
				session_unset();
				session_destroy();
				
				//Delete cookies
				setcookie("username","",time() - 3600);
				setcookie("password","",time() - 3600);
		}
			
		public function __construct($db) {
			$this -> db = $db;
			$this -> cookieLogin();
		}
			
	}
?>
