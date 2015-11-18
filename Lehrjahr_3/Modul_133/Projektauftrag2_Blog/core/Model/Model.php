<?php
/**
* @author Severin Kaderli
*/
abstract class Model
{


    public function __construct() {}

    abstract protected static function find($id);
    abstract protected static function getAll();
}