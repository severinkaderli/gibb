<?php

namespace Core\Controller;

class PostController
{
    public function index($page = 1)
    {
        require_once(__ROOT__ . "Templates/index.view.php");
        return "You are on page $page";
    }

    public function show($postId = 1)
    {
        //require_once(__ROOT__ . "Templates/show.view.php");
        return "It works!";
    }
}