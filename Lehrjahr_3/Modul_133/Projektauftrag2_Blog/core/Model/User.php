<?php

/**
* @author Severin Kaderli
*/
class User extends Model
{
    public $id;
    public $username;
    public $password;
    public $firstname;
    public $lastname;
    public $isAdmin;

    public function __construct()
    {
       parent::__construct();
    }

    /**
     * Checks whether a user is logged in or not
     *
     * @return bool
     */
    public static function auth() {

    	if(isset($_SESSION["user"]["logged_in"]) && $_SESSION["user"]["logged_in"] === true) {
    		return true;
    	}

    	return false;
    }

    /**
     * Try to login with a user
     *
     * @return bool
     */
    public function login() {

    	$checkUser = User::getByUsername($this->username);
    	if(password_verify($this->password, $checkUser->password)) {


    		$_SESSION["user"]["logged_in"] = true;
    		$_SESSION["user"]["id"] = $checkUser->id;
    		$_SESSION["user"]["username"] = $this->username;

    		return true;
    	}
    	

    	return false;
    }

    /**
     * Save the user data in db
     */
    public function register() {

        if(User::exists($this->username)) {
            //show message or something
            header("Location: register.php");
            exit();
        }

    	DatabaseConnection::getResult("INSERT INTO users(username, password, firstname, lastname, isAdmin) VALUES(:username, :password, :firstname, :lastname, 0)",
    									["username" => $this->username,
    									"password" => password_hash($this->password, PASSWORD_BCRYPT),
    									"firstname" => $this->firstname,
    									"lastname" => $this->lastname]);
    }

    /**
     * Finds and returns an User by its id
     *
     * @param int $id
     * @return User
     */
    public static function find($id) {
        $result = DatabaseConnection::getResult("SELECT * FROM users WHERE id=:id", ["id" => $id]);

        $userObject = new User();
        $userObject->id = $result[0]["id"];
        $userObject->username = $result[0]["username"];
        $userObject->password = $result[0]["password"];
        $userObject->firstname = $result[0]["firstname"];
        $userObject->lastname = $result[0]["lastname"];
        $userObject->isAdmin = $result[0]["isAdmin"];

        return $userObject;
    }

    /**
     * Return all users as an array
     *
     * @return array
     */
    public static function getAll() {
        $result = [];
        $sqlResult = DatabaseConnection::getResult("SELECT * FROM users");

        foreach($sqlResult as $user) {
            $userObject = new User();
	        $userObject->id = $result["id"];
	        $userObject->username = $result["username"];
	        $userObject->password = $result["password"];
	        $userObject->firstname = $result["firstname"];
	        $userObject->lastname = $result["lastname"];
	        $userObject->isAdmin = $result["isAdmin"];

            $result[] = $userObject;
        }

        return $result;
    }

    /**
     * Return an user by its username
     *
     * @param string $username
     * @return User
     */
    public static function getByUsername($username) {
    	$result = DatabaseConnection::getResult("SELECT * FROM users WHERE username=:username", ["username" => $username]);

    	$userObject = new User();
        $userObject->id = $result[0]["id"];
        $userObject->username = $result[0]["username"];
        $userObject->password = $result[0]["password"];
        $userObject->firstname = $result[0]["firstname"];
        $userObject->lastname = $result[0]["lastname"];
        $userObject->isAdmin = $result[0]["isAdmin"];

        return $userObject;
    }

    /**
     * Checks if an user already exists
     *
     * @param string $username
     * @return bool
     */
    public static function exists($username) {

        $result = DatabaseConnection::getResult("SELECT * FROM users WHERE username=:username", ["username" => $username]);

        if(!empty($result)) {
            return true;
        }

        return false;
    }


}