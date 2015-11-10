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

    /**
     * @return array
     */
    function getPosts() {
        $result = $this->db->query("SELECT * FROM posts");
        
        return $result->fetchArray(SQLITE3_ASSOC);
    }


}