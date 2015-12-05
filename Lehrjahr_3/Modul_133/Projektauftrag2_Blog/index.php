<?php
require_once("./config.php");

$router = new Core\Routing\Router();
$router->setBasePath(str_replace("http://" . $_SERVER['SERVER_NAME'], "", BASE_DIR));

$router->addRoute("GET", "/", "Core\\Controller\\PostController@index");
$router->addRoute("GET", "/{page}", "Core\\Controller\\PostController@show");

$match = $router->dispatch();



echo "<pre>";
var_dump($match);
echo "</pre>";

switch($match["type"]) {
    case "Closure":
        $match["function"]();
        break;

    case "Controller":
        $controller = new $match["controller"]();
        echo $controller->$match["method"]();
        break;

    case "Error":
        echo $match["error"];
        break;
}
require_once(__ROOT__ . "Templates/index.view.php");
