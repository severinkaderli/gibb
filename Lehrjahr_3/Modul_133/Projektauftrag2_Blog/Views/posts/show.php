<?php

require_once(__ROOT__ . "Views/_header.php");

use Core\Model\User;
echo "<div class='post'>";
echo "<header class='post__header'>";
echo "<h1>".$this->post->title. "<br><small>" . date(DATE_FORMAT, $this->post->post_time) . " von ".$this->postUser->firstname." ".$this->postUser->lastname;
if (isset($_SESSION["user"]["id"])) {
    if ($post->fk_user_id == $_SESSION["user"]["id"]) {
        echo " <a onclick='return confirm_delete()' href='post/".$post->id."/delete'><span class='glyphicon glyphicon-trash' aria-hidden='true'></span></a> ";
        echo "<a href='post/".$post->id."/edit'><span class='glyphicon glyphicon-pencil' aria-hidden='true'></span></a> ";
    }
}
echo "</small></h1>";
echo "</header>";

echo "<div class='post__content'>";
echo "<p>". nl2br($this->post->content)."</p>";
echo "</div>";
echo "</div>";

//Display comments
echo "<h3>Kommentare</h3>";

if (is_null($this->comments)) {
    echo "<p>Keine Kommentare vorhanden</p>";
} else {

    foreach ($this->comments as $comment) {

        $user = User::find($comment->fk_user_id);
        echo "<div class='comment panel panel-default panel-body'>";
        echo "<header class='comment__header'>";
        echo "<p>Kommentar veröffentlicht von <i>$user->firstname $user->lastname</i>";
        if(isset($_SESSION["user"]["id"])){
            if($comment->fk_user_id == $_SESSION["user"]["id"]) {
                echo " <a onclick='return confirm_delete()'href='comment/".$comment->id."/delete'><span class='glyphicon glyphicon-trash' aria-hidden='true'></span></a></p>";
            }
        } else {
            echo "</p>";
        }
        echo "</header>";
        echo "<div class='comment_content'>";
        echo nl2br($comment->comment);
        echo "</div>";

        echo "</div>";

    }
}

//Only show add comment if logged in
echo "<h3>Kommentar verfassen</h3>";
if (User::auth() && $_SESSION["user"]["id"] != $this->post->fk_user_id) {

    echo "<form method='POST' action='post/" . $this->post->id . "/comment'>";
    echo "<div class='form-group'>";
    echo "<textarea id='comment' rows='5' name='comment' class='form-control'></textarea>";
    echo "</div>";
    echo "<div class='form-group'>";
    echo "<input type='submit' class='btn btn-default' value='Kommentar absenden'>";
    echo "</div>";
    echo "</form>";
} else {
    echo "<p>Sie müssen eingeloggt sein, um einen Kommentar zu verfassen und sie können nicht ihre eigenen Einträge kommentieren!</p>";
}

require_once(__ROOT__ . "Views/_footer.php");