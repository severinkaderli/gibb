<?php
namespace Core\Controller;

use Core\Routing\Redirect;
use Core\Model\Post;
use Core\Model\User;
use Core\Model\Comment;
use Core\View\View;

class UserController
{
    public function index() {
        if(!User::isAdmin()) {
            Redirect::to("/");
        }

        $users = User::getAll();
        $view = new View("users.index");
        $view->assign("users", $users);
        $view->render();
    }

    public function delete($id){
        if(!User::isAdmin()) {
            Redirect::to("/");
        }

        if($_SESSION["user"]["id"] == $id) {
            Redirect::to("/");
        }

        User::delete($id);
        Redirect::to("/users");
    }

    public function promote($id) {
        if(!User::isAdmin()) {
            Redirect::to("/");
        }

        User::promote($id);
        Redirect::tO("/users");
    }
}