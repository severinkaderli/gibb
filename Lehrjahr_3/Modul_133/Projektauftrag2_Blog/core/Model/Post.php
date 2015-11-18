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
     * @return Post
     */
    public static function find($id) {
        $result = DatabaseConnection::getResult("SELECT * FROM posts WHERE id=:id", ["id" => $id]);
        foreach($result as $post) {
            $object = new Post();
            $object->id = $post["id"];
            $object->title = $post["title"];
            $object->content = $post["content"];
            $object->fk_user_id = $post["fk_user_id"];
            $object->timestamp = $post["timestamp"];
        }

        return $object;
    }

    /**
     * Return all posts as an array
     *
     * @return array
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