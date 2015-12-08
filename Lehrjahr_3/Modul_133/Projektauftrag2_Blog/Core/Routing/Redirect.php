<?php
    namespace Core\Routing;

    class Redirect {

        /**
         * @param string $route
         */
        public static function to($route) {
            $route = rtrim($route, "/");
            header("Location: " . BASE_DIR . $route);
            exit();
        }
    }