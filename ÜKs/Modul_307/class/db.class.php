<?php
	class db {
		
		/**
		 * mysql host
		 * 
		 * @var string
		 */
		private $db_host;
		
		/**
		 * mysql username
		 * 
		 * @var string
		 */
		private $db_user;
		
		/**
		 * mysql password
		 * 
		 * @var string
		 */
		private $db_password;
		
		/**
		 * mysql database
		 * 
		 * @var string
		 */
		private $db_database;
		
		/**
		 * The connection
		 * 
		 * @var object
		 */
		private $link;
		
		/**
		 * Connects to the mysql database
		 */
		public function connect() {
			
			//Connect to the database
			$this -> link = new mysqli($this -> db_host, $this -> db_user, $this -> db_password, $this -> db_database);
			
			//Check if any errors are occuring
			if($this -> link -> connect_errno > 0) {
				die("Error: [" .$this -> link -> connect_errno . "] " . $this -> link -> connect_error);
			}
			
			//Set default charset to utf-8
			$this -> link -> set_charset("utf8");	
		}	
		
		/**
		 * Processes a mysql query
		 * 
		 * @param string $query Query that should be processed
		 * 
		 * @return array
		 */
		public function query($query, $returnResult = true) {
			
			if($returnResult) {
				$results = array();
				$result = $this -> link -> query($query);
				while($row = $result -> fetch_object()) {
					$results[] = $row;
				}
				
				return $results;
			} else {
				
				$this -> link -> query($query);
				
				return false;
			}	
		}
		
		/**
		 * Filters a string to be used in a query
		 * 
		 * @param string $string String that should be filtered
		 * 
		 * @return string
		 */
		public function filter($string) {
			$string = $this -> link -> real_escape_string($string);
			
			return $string;
		}
		
		public function count($array) {
			$result = count($array);
			return $result;
		}
		
		/**
		 * @param string $db_host
		 * @param string $db_user
		 * @param string $db_password
		 * @param string $db_database
		 */
		public function __construct($db_host, $db_user, $db_password, $db_database) {
			$this -> db_host = $db_host;
			$this -> db_user = $db_user;
			$this -> db_password = $db_password;
			$this -> db_database = $db_database;
			
			$this -> connect();
		}
		
		/**
		 * Close the connection
		 */
		public function __destruct() {
			$this -> link -> close();
		}
	}
?>
