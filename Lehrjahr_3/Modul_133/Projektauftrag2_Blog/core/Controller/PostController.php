<?php

namespace Core\Controller;

use Core\Routing\Redirect;
use Core\Model\Post;
use Core\View\View;

class PostController
{
    public function index($page = 1)
    {
        return new View("index");
    }

    public function show($postId)
    {
        if (!is_numeric($postId)) {
            Redirect::to("/");
        }
        $post = Post::find($postId);
        if (is_null($post)) {

            Redirect::to("/");

        }
        return new View("show");
    }
}