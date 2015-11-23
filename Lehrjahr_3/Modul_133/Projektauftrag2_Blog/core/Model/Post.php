<?php

/**
* @author Severin Kaderli
*/
class Post extends Model
{
    public $id;
    public $title;
    public $content;
    public $fk_user_id;
    public $timestamp;

    public function __construct()
    {
       parent::__construct();
    }

    /**
     * Finds and returns an Post by its id
     *
     * @param int $id
     * @return mixed
     */
    public static function find($id) {
        $result = DatabaseConnection::getResult("SELECT * FROM posts WHERE id=:id", ["id" => $id]);
        if(empty($result)) {
            return null;
        }
        $postObject = new Post();
        $postObject->id = $result[0]["id"];
        $postObject->title = $result[0]["title"];
        $postObject->content = $result[0]["content"];
        $postObject->fk_user_id = $result[0]["fk_user_id"];
        $postObject->timestamp = $result[0]["timestamp"];

        return $postObject;
    }

    /**
     * Return all posts as an array
     *
     * @return mixed
     */
    public static function getAll() {
        $result = [];
        $sqlResult = DatabaseConnection::getResult("SELECT * FROM posts");

        foreach($sqlResult as $post) {
            $postObject = new Post();
            $postObject->id = $post["id"];
            $postObject->title = $post["title"];
            $postObject->content = $post["content"];
            $postObject->fk_user_id = $post["fk_user_id"];
            $postObject->timestamp = $post["timestamp"];

            $result[] = $postObject;
        }

        return $result;
    }


}