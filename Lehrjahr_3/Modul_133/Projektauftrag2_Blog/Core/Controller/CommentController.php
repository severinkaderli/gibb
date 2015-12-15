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
        $post = Post::find($postId);
        if($post->fk_user_id == $_SESSION["user"]["id"]) {
            Redirect::to("/post/$postId");
        }

        Comment::create($postId, $_POST);
        Redirect::to("/post/$postId");
    }

    public function delete($id){
        $comment = Comment::find($id);
        if($comment->fk_user_id != $_SESSION["user"]["id"]) {
            Redirect::to("/");
        }
        $postId = $comment->fk_post_id;
        Comment::delete($id);
        Redirect::to("/post/" . $postId);
    }
}