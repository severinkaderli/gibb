<?php

namespace Core\Controller;

use Core\Routing\Redirect;
use Core\Model\Post;
use Core\Model\User;
use Core\Model\Comment;
use Core\View\View;

class AuthController
{

    public function showLogin()
    {
        if (User::auth()) {
            Redirect::to("/");
        }
        $view = new View("auth.login");
        $view->render();
    }

    public function login()
    {
        if (User::auth()) {
            Redirect::to("/");
        }

        if (isset($_POST["loginSubmit"])) {
            $user = new User();
            $user->username = $_POST["username"];
            $user->password = $_POST["password"];
            $user->login();
            Redirect::to("/");
        }
    }

    public function showRegister()
    {
        if (User::auth()) {
            Redirect::to("/");
        }

        $view = new View("auth.register");
        $view->render();
    }

    public function register()
    {
        if (User::auth()) {
            Redirect::to("/");
        }

        if (isset($_POST["registerSubmit"])) {

            //Todo: Validation of user input and sanitation.
            $user = new User();
            $user->username = $_POST["username"];
            $user->firstname = $_POST["firstname"];
            $user->lastname = $_POST["lastname"];
            $user->password = $_POST["password"];
            $user->isAdmin = 0;

            $user->register();
            $user->login();
        }
    }

    public function logout()
    {
        session_unset();
        session_destroy();
        Redirect::to("/");
    }
}