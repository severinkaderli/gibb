<?php

namespace Core\Model;

use Core\Database\DatabaseConnection;

/**
 * @author Severin Kaderli
 */
class Post extends Model
{
    public $id;
    public $title;
    public $content;
    public $fk_user_id;
    public $post_time;

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
    public static function find($id)
    {
        $result = DatabaseConnection::getResult("SELECT * FROM posts WHERE id=:id", ["id" => $id]);
        if (empty($result)) {
            return null;
        }
        $postObject = new Post();
        $postObject->id = $result[0]["id"];
        $postObject->title = $result[0]["title"];
        $postObject->content = $result[0]["content"];
        $postObject->fk_user_id = $result[0]["fk_user_id"];
        $postObject->post_time = $result[0]["post_time"];

        return $postObject;
    }

    /**
     * Return all posts as an array
     *
     * @return mixed
     */
    public static function getAll()
    {
        $result = [];
        $sqlResult = DatabaseConnection::getResult("SELECT * FROM posts ORDER BY id DESC");

        foreach ($sqlResult as $post) {
            $postObject = new Post();
            $postObject->id = $post["id"];
            $postObject->title = $post["title"];
            $postObject->content = $post["content"];
            $postObject->fk_user_id = $post["fk_user_id"];
            $postObject->post_time = $post["post_time"];

            $result[] = $postObject;
        }

        return $result;
    }

    /**
     * Return all posts by user id
     *
     * @return mixed
     */
    public static function getByUserId($userId)
    {
        $result = [];
        $sqlResult = DatabaseConnection::getResult("SELECT * FROM posts WHERE fk_user_id=:user_id", ["user_id" => $userId]);

        foreach ($sqlResult as $post) {
            $postObject = new Post();
            $postObject->id = $post["id"];
            $postObject->title = $post["title"];
            $postObject->content = $post["content"];
            $postObject->fk_user_id = $post["fk_user_id"];
            $postObject->post_time = $post["post_time"];

            $result[] = $postObject;
        }

        return $result;
    }

    public static function create(array $fields)
    {
        DatabaseConnection::insert("INSERT INTO posts(title, content, fk_user_id, post_time)
              VALUES(:title, :content, :user_id, :post_time)",
            ["title" => htmlentities($fields["title"]),
                "content" => htmlentities($fields["content"]),
                "user_id" => $_SESSION["user"]["id"],
                "post_time" => time()]);
    }

    public static function update($postId, array $fields)
    {
        DatabaseConnection::insert("UPDATE posts SET title=:title, content=:content WHERE id=:post_id",
            ["title" => htmlentities($fields["title"]),
                "content" => htmlentities($fields["content"]),
                "post_id" => $postId]);
    }

    public static function delete($postId) {
        DatabaseConnection::insert("DELETE FROM posts WHERE id=:post_id", ["post_id" => $postId]);
    }


}