<?php

namespace Core\Routing;

use Closure;

/**
 * Core\Routing\Router
 *
 * This class handles all routings for the framework. Each route has a
 * method and a function, which is getting called when the route is invoked.
 *
 * @package Kuro\Routing
 * @author Severin Kaderli <severin.kaderli@gmail.com>
 */
class Router
{
    /**
     * This array holds all defined routes in the application.
     * @var array
     */
    private $routes = [];

    /**
     * The base path which is used as base for all routes.
     * @var string
     */
    private $basePath;

    /**
     * These are the allowed methods for routes.
     * @var array
     */
    private $allowedMethods = ["POST", "GET", "PUT", "PATCH", "DELETE"];

    /**
     * @return array
     */
    public function getRoutes()
    {
        return $this->routes;
    }

    /**
     * @param string $basePath
     */
    public function setBasePath($basePath)
    {
        $this->basePath = $basePath;
    }

    /**
     * @return string
     */
    public function getBasePath()
    {
        return $this->basePath;
    }

    /**
     * Define a new route.
     *
     * @param string $methods
     * @param string $route
     * @param mixed $callback
     *
     */
    public function addRoute($methods, $route, $callback)
    {
        $methods = explode("|", $methods);

        foreach ($methods as $method) {
            if (!in_array(strtoupper($method), $this->allowedMethods)) {
                //throw new MethodNotAllowedException($method);
            }
        }
        $this->routes[] = ["methods" => $methods, "route" => $route, "callback" => $callback];
    }

    /**
     * Define multiple routes using an array. The array should look
     * like this:
     *
     *
     * @param array $routes
     */
    public function addRoutes(array $routes) {
        foreach($routes as $route) {
            $this->addRoute($route[0], $route[1], $route[2]);
        }
    }

    /**
     * This function checks if the current request corresponds any defined
     * route. If there is a matching route the given callback is executed.
     *
     * @return array
     *
     */
    public function dispatch()
    {

        //Get the current request uri and method
        $requestUrl = $_SERVER["REQUEST_URI"];
        $requestMethod = $_SERVER["REQUEST_METHOD"];

        //Strip base path and query string from the request url
        $requestUrl = rtrim(str_replace($this->basePath, "", $requestUrl), "/");

        if ($strpos = strpos($requestUrl, "?") !== false) {
            $requestUrl = substr($requestUrl, 0, $strpos);
        }

        //Try to find a matching route
        foreach ($this->getRoutes() as $route) {

            //Check if there are any matching methods
            $matchMethod = false;
            foreach ($route["methods"] as $method) {
                if (strcasecmp($method, $requestMethod) === 0) {
                    $matchMethod = true;
                    break;
                }
            }

            if (!$matchMethod) {
                continue;
            }

            //Check if the a route matches the current route
            $matchRoute = false;
            $routePattern = preg_replace("/{[A-Za-z0-9]+}/", "(?P<parameter>[0-9]+)", $route["route"]);
            $routePattern = str_replace("/", '\/', $routePattern);
            $routePattern = "/^" . $routePattern . "$/";

            //Check the route and get extra parameter if available
            $routeParameter = [];
            if (preg_match($routePattern, $requestUrl, $routeParameter) === 1) {
                $matchRoute = true;
            }

            //Try to call the callback function
            if ($matchMethod && $matchRoute) {

                $returnArray = [];
                $returnArray["parameter"] = isset($routeParameter["parameter"]) ? $routeParameter["parameter"] : null;

                if ($route["callback"] instanceof Closure) {

                    $returnArray["type"] = "Closure";
                    $returnArray["function"] = $route["callback"];
                    return $returnArray;
                }

                //If the callback is a string try to call the right method
                if (is_string($route["callback"])) {

                    $returnArray["type"] = "Controller";

                    $controllerCallback = explode("@", $route["callback"]);
                    if (count($controllerCallback) !== 2) {
                        return ["type" => "error"];
                    }

                    //Get controller name and method from callback string
                    $controllerName = "Core\\Controller\\" . $controllerCallback[0];
                    $controllerMethod = $controllerCallback[1];

                    //Check if the controller exists
                    if (!class_exists($controllerName)) {
                        return ["type" => "error"];
                    }

                    //Check if the method exists
                    if (!method_exists($controllerName, $controllerMethod)) {
                        return ["type" => "error"];
                    }

                    $returnArray["controller"] = $controllerName;
                    $returnArray["method"] = $controllerMethod;

                    return $returnArray;
                }
            }
        }

        return ["type" => "Error"];
    }
}