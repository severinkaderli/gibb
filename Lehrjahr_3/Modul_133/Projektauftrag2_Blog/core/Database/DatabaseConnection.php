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
     *
     * TODO: Adding parameterized requests to prevent SQLInjection
     * TODO: Delete this method if its not needed
     * @param string $query
     * @return mixed
     */
    public function query($query) {
        return parent::query($query);
    }

    /**
     * @param string $query
     * @param array $parameter
     * @return array
     */
    public function getResult($query, array $parameter = []) {
        $result = [];

        //Prepare the statement and bind values
        $stmt = $this->prepare($query);
        foreach ($parameter as $parameter => $value) {
            $stmt -> bindValue($parameter, $value);
        }

        //Get result and return as an array
        $sqlResult = $stmt->execute();
        while($tmpResult = $sqlResult->fetchArray(SQLITE3_ASSOC)){ 
            $result[] = $tmpResult; 
        } 
        return $result;
    }

}