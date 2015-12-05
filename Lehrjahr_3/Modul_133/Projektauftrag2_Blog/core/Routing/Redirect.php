<?php
    namespace Core\Routing;

    class Redirect {

        /**
         * @param $route Route to redirect to
         */
        public static function to($route) {
            $route = rtrim($route, "/");
            header("Location: " . BASE_DIR . $route);
            exit();
        }
    }