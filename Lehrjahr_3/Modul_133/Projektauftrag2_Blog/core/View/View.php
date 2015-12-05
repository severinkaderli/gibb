<?php

namespace Core\View;

    class View {

        /**
         * Return a view
         *
         * @param $view
         */
        public function __construct($view)
        {
            return require_once(__ROOT__ . "Views/" . $view . ".php");
        }
    }