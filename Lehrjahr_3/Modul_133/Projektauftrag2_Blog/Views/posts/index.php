<?php
require_once(__ROOT__ . "Views/_header.php");

foreach ($this->posts as $post) {
    $postUser = Core\Model\User::find($post->fk_user_id);
    echo "<div class='post'>";
    echo "<header class='post__header'>";
    echo "<h1><a href='post/" . $post->id . "'>".$post->title. "</a><br><small>" . date(DATE_FORMAT, $post->post_time) . " von ".$postUser->firstname." ".$postUser->lastname;
    if (isset($_SESSION["user"]["id"])) {
        if ($post->fk_user_id == $_SESSION["user"]["id"]) {
            echo " <a onclick='return confirm_delete()' href='post/".$post->id."/delete'><span class='glyphicon glyphicon-trash' aria-hidden='true'></span></a> ";
            echo "<a href='post/".$post->id."/edit'><span class='glyphicon glyphicon-pencil' aria-hidden='true'></span></a> ";
        }
    }
    echo "</small></h1>";
    echo "</header>";

    echo "<div class='post__content'>";
    echo "<p>" . nl2br($post->content) . "</p>";
    echo "</div>";
    echo "</div>";
}

require_once(__ROOT__ . "Views/_footer.php");