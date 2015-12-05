<?php
require_once("./config.php");

/**
 * This file is used to set up the bootstrapping using routes.
 */
$router = new Core\Routing\Router();
$router->setBasePath(str_replace("http://" . $_SERVER['SERVER_NAME'], "", BASE_DIR));

$router->addRoute("GET", "", "PostController@index");
$router->addRoute("GET", "/{page}", "PostController@index");
$router->addRoute("GET", "/post/{postId}", "PostController@show");

$router->addRoute("GET", "/test", function() {
    return "test";
});

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
        if(is_null($match["parameter"])) {
            echo $controller->$match["method"]();
        } else {
            echo $controller->$match["method"]($match["parameter"]);
        }

        break;

    case "Error":
        echo $match["error"];
        break;
}

