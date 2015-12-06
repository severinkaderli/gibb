<?php

namespace Core\Controller;

use Core\Routing\Redirect;
use Core\Model\Post;
use Core\Model\User;
use Core\Model\Comment;
use Core\View\View;

class AuthController
{

    public function showLogin() {
        $view = new View("auth.login");
        echo $view->render();
    }

    public function login() {

    }

    public function showRegister() {
        $view = new View("auth.register");
        echo $view->render();
    }

    public function register() {

    }

    public function logout() {
        session_unset();
        session_destroy();
        Redirect::to("/");
    }
}