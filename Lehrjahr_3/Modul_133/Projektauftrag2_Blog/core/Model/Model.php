<?php
/**
* @author Severin Kaderli
*/
abstract class Model
{

    protected $db;

    public function __construct() {
        //TODO: Use constant for the db file
        $this->db = new DatabaseConnection("./blog.db");
    }

    abstract protected function find($id);
    abstract protected function getAll();
}