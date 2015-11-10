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
    function __construct($database)
    {
        $this->open($database);
    }

}