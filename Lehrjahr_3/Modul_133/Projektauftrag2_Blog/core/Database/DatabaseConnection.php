<?php

namespace Core\Database;

/**
 * @author Severin Kaderli
 */
class DatabaseConnection extends \SQLite3
{

    private static $sqliteConnection;

    /**
     * Takes the name of a db file and tries to open it
     *
     * @param string $database
     */
    public static function init($database) {
        self::$sqliteConnection = new \SQLite3($database);
    }

    /**
     * @param string $query
     * @param array $parameter
     * @return array
     */
    public static function getResult($query, array $parameter = []) {
        $result = [];

        //Prepare the statement and bind values
        $stmt = self::$sqliteConnection->prepare($query);
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

    public static function insert($query, array $parameter = []) {
        //Prepare the statement and bind values
        $stmt = self::$sqliteConnection->prepare($query);
        foreach ($parameter as $parameter => $value) {
            $stmt -> bindValue($parameter, $value);
        }

        //Get result and return as an array
        $sqlResult = $stmt->execute();
    }

}