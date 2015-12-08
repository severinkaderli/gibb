<?php
require_once("./config.php");

/**
 * This file is used to set up the bootstrapping using routes.
 */
$router = new Core\Routing\Router();
$router->setBasePath(str_replace("http://" . $_SERVER['SERVER_NAME'], "", BASE_DIR));

/**
 * Defined routes
 */
$router->addRoute("GET", "", "PostController@index");
$router->addRoute("GET", "/{page}", "PostController@index");
$router->addRoute("GET", "/post/{postId}", "PostController@show");

$router->addRoute("GET", "/logout", "AuthController@logout");
$router->addRoute("GET", "/login", "AuthController@showLogin");
$router->addRoute("POST", "/login", "AuthController@login");
$router->addRoute("GET", "/register", "AuthController@showRegister");
$router->addRoute("POST", "/register", "AuthController@register");

/**
 * Dispatching and call the matched method
 */
$match = $router->dispatch();

echo "<pre>";
var_dump($match);
echo "</pre>";
switch ($match["type"]) {
    case "Closure":
        $match["function"]();
        break;

    case "Controller":
        $controller = new $match["controller"]();
        if (is_null($match["parameter"])) {
            $controller->$match["method"]();
        } else {
            $controller->$match["method"]($match["parameter"]);
        }
        break;

    case "Error":
        echo "Page not found..." . $_SERVER["REQUEST_URI"];
        break;
}

