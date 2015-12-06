<?php

namespace Core\Controller;

use Core\Routing\Redirect;
use Core\Model\Post;
use Core\View\View;

class PostController
{
    /**
     * Renders a listing of all blog posts. Only posts of the current page
     * are shown.
     *
     * @param int $page
     */
    public function index($page = 1)
    {
        //Todo: Manage page handling
        $view = new View("posts.index");
        $view->assign("posts", Post::getAll());
        echo $view->render();
    }

    /**
     * Show a single post by postId.
     *
     * @param $postId
     * @return View
     */
    public function show($postId)
    {
        $view = new View("posts.show");
        return new View("show");
    }
}