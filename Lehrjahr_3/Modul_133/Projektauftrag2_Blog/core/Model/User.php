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
     * Finds and returns an User by its id
     *
     * @param int $id
     * @return User
     */
    public static function find($id) {
        $result = DatabaseConnection::getResult("SELECT * FROM users WHERE id=:id", ["id" => $id]);
        var_dump($result);

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


}