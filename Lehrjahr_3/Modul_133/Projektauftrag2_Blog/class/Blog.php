<?php

/**
* 
* @author Severin Kaderli
*/
class Blog
{
    /**
     * @var $db
     */
    private $db;

    /**
     * @param DatabaseConnection $db
     */
    function __construct(DatabaseConnection $db)
    {
        $this->db = $db;
    }

    function getPosts() {
        return $this->db->query("SELECT * FROM posts")->fetchArray(SQLITE3_ASSOC);
    }


}