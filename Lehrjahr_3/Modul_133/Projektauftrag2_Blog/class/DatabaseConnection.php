<?php

/**
 * @author Severin Kaderli
 */
class DatabaseConnection extends SQLite3
{
    /**
     * Takes the name of a db file and tries to open it
     *
     * @param string $database
     */
    public function __construct($database)
    {
        $this->open($database);
    }

    /**
     * Get the result of a query.
     *
     * @param string $query
     * @return array
     */
    public function getResult($query) {

    	//Sanitize query for sequrity reasons
    	//stuff with $query..

    	//CALL query functon of parent class
    	parent::query($query);

    	return [];
    }

}