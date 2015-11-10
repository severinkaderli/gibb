<?php

class DatabaseConnection extends SQLite3
{
    function __construct($database)
    {
        $this->open($dtabase);
    }
}