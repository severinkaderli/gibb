<?php
namespace Core\Controller;

use Core\Routing\Redirect;
use Core\Model\Post;
use Core\Model\User;
use Core\Model\Comment;
use Core\View\View;

class CommentController
{
    public function store($postId) {
        Comment::create($postId, $_POST);
        Redirect::to("/post/$postId");
    }
}