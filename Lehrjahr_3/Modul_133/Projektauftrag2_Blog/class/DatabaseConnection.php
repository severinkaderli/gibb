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
     * @param string $query
     * @return array
     */
    public function getResult($query) {
        $result = [];
        $tmpResult = $this->query($query);
        while($res = $tmpResult->fetchArray(SQLITE3_ASSOC)){
            $result[] = $res;
        }

        return $result;
    }

}