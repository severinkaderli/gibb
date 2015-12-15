<?php

namespace Core\Model;

use Core\Database\DatabaseConnection;

/**
* @author Severin Kaderli
*/
class Comment extends Model
{
    public $id;
    public $comment;
    public $fk_post_id;
    public $fk_user_id;

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
        $result = DatabaseConnection::getResult("SELECT * FROM comments WHERE id=:id", ["id" => $id]);
        if(empty($result)) {
            return null;
        }
        $commentObject = new Comment();
        $commentObject->id = $result[0]["id"];
        $commentObject->comment = $result[0]["comment"];
        $commentObject->fk_post_id = $result[0]["fk_post_id"];
        $commentObject->fk_user_id = $result[0]["fk_user_id"];

        return $commentObject;
    }

    /**
     * Return all posts as an array
     *
     * @return mixed
     */
    public static function getAll() {
        $result = [];
        $sqlResult = DatabaseConnection::getResult("SELECT * FROM comments");

        foreach($sqlResult as $comment) {
            $commentObject = new Comment();
            $commentObject->id = $comment["id"];
            $commentObject->comment = $comment["comment"];
            $commentObject->fk_post_id = $comment["fk_post_id"];
            $commentObject->fk_user_id = $comment["fk_user_id"];

            $result[] = $commentObject;
        }

        return $result;
    }

    /**
     * Return all posts by user id as an array
     *
     * @return mixed
     */
    public static function getByUserId($userId) {
        $result = [];
        $sqlResult = DatabaseConnection::getResult("SELECT * FROM comments WHERE fk_user_id=:user_id", ["user_id" => $userId]);

        foreach($sqlResult as $comment) {
            $commentObject = new Comment();
            $commentObject->id = $comment["id"];
            $commentObject->comment = $comment["comment"];
            $commentObject->fk_post_id = $comment["fk_post_id"];
            $commentObject->fk_user_id = $comment["fk_user_id"];

            $result[] = $commentObject;
        }

        return $result;
    }

    public static function create($postId, array $fields) {
        DatabaseConnection::insert("INSERT INTO comments(comment, fk_post_id, fk_user_id) VALUES(:comment, :post_id, :user_id)", ["comment" => htmlentities($fields["comment"]), "post_id" => $postId, "user_id" => $_SESSION["user"]["id"]]);
    }

    public static function delete($commentId) {
        DatabaseConnection::insert("DELETE FROM comments WHERE id=:comment_id", ["comment_id" => $commentId]);
    }

    /**
     * Return comments by post id
     *
     * @param int $postId
     * @return mixed
     */
    public static function getByPostId($postId) {
        $result = [];
        $sqlResult = DatabaseConnection::getResult("SELECT * FROM comments WHERE fk_post_id=:postId", ["postId" => $postId]);

        foreach($sqlResult as $comment) {
            $commentObject = new Comment();
            $commentObject->id = $comment["id"];
            $commentObject->comment = $comment["comment"];
            $commentObject->fk_post_id = $comment["fk_post_id"];
            $commentObject->fk_user_id = $comment["fk_user_id"];

            $result[] = $commentObject;
        }

        return $result;
    }

}