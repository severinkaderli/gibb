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
 
    protected $db;

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
    public function find($id) {
        $result = $this -> db -> getResult("SELECT * FROM posts WHERE id=:id", ["id" => $id]);
        foreach($result as $post) {
            $this->id = $post["id"];
            $this->title = $post["title"];
            $this->content = $post["content"];
            $this->fk_user_id = $post["fk_user_id"];
            $this->timestamp = $post["timestamp"];
        }

        return $this;
    }

    /**
     * Return all posts as an array
     *
     * @return array
     */
    public function getAll() {
        $result = [];
        $sqlResult = $this->db -> getResult("SELECT * FROM posts");

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