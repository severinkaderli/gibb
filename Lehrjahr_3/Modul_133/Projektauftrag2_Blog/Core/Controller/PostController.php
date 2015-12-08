<?php

namespace Core\Controller;

use Core\Routing\Redirect;
use Core\Model\Post;
use Core\Model\User;
use Core\Model\Comment;
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
        $view->render();
    }

    /**
     * Show a single post by postId.
     *
     * @param int $id
     * @return View
     */
    public function show($id)
    {
        /**
         * Check if the postId is valid and if a post with that id
         * exists. If no post can be found the user will be redirected to the
         * index page.
         */
        if (!is_numeric($id)) {
            Redirect::to("/");
        }
        $post = Post::find($id);
        if (is_null($post)) {
            Redirect::to("/");
        }

        /**
         * Get the user associatd with the blog post
         */
        $postUser = User::find($post->fk_user_id);

        /**
         * Get all comments of this blog post
         */
        $comments = Comment::getByPostId($post->id);

        /**
         * Assign variables to view and render it
         */
        $view = new View("posts.show");
        $view->assign("post", $post);
        $view->assign("postUser", $postUser);
        $view->assign("comments", $comments);
        $view->render();
    }

    public function create() {
        $view = new View("posts.create");
        $view->render();
    }

    public function store() {
        Post::create($_POST);
        Redirect::to("/");
    }

    public function edit($id) {
        //Check if user is allowed to delete the post
        $post = Post::find($id);
        if($_SESSION["user"]["id"] != $post->fk_user_id) {
            Redirect::to("/");
        }

        $view = new View("posts.edit");
        $view->assign("post", $post);
        $view->render();
    }

    public function update($id) {
        //Check if user is allowed to delete the post
        $post = Post::find($id);
        if($_SESSION["user"]["id"] != $post->fk_user_id) {
            Redirect::to("/");
        }
        Post::update($id, $_POST);
        Redirect::to("/");
    }

    public function delete($id){
        $post = Post::find($id);
        if($post->fk_user_id != $_SESSION["user"]["id"]) {
            Redirect::to("/");
        }
        Post::delete($id);
        Redirect::to("/");
    }
}