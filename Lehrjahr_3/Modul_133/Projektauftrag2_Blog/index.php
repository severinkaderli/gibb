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
//Displaying of posts
$router->addRoute("GET", "", "PostController@index");
$router->addRoute("GET", "/{page}", "PostController@index");
$router->addRoute("GET", "/post/{postId}", "PostController@show");

//Authentication
$router->addRoute("GET", "/logout", "AuthController@logout");
$router->addRoute("GET", "/login", "AuthController@showLogin");
$router->addRoute("POST", "/login", "AuthController@login");
$router->addRoute("GET", "/register", "AuthController@showRegister");
$router->addRoute("POST", "/register", "AuthController@register");

//Creating, editing and deleting of posts
$router->addRoute("GET", "/create", "PostController@create");
$router->addRoute("POST", "/", "PostController@store");
$router->addRoute("GET", "/post/{postId}/edit", "PostController@edit");
$router->addRoute("POST", "/post/{postId}/update", "PostController@update");
$router->addRoute("POST", "/post/{postId}/delete", "PostController@delete");

//Comments
$router->addRoute("POST", "/post/{postId}/comment", "CommentController@store");
$router->addRoute("POST", "/comment/{commentId}/delete", "CommentController@delete");


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

