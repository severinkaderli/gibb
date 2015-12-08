<?php

require_once(__ROOT__ . "Views/_header.php");

use Core\Model\User;
echo "<div class='post'>";
echo "<header class='post__header'>";
echo "<h1>".$this->post->title. "<br><small>" . strftime(DATE_FORMAT, $this->post->timestamp) . " von ".$this->postUser->firstname." ".$this->postUser->lastname."</small></h1>";
echo "</header>";

echo "<div class='post__content'>";
echo "<p>".$this->post->content."</p>";
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
        echo "<p>Kommentar veröffentlicht von $user->firstname $user->lastname</p>";
        echo "</header>";
        echo "<div class='comment_content'>";
        echo $comment->comment;
        echo "</div>";

        echo "</div>";

    }
}

//Only show add comment if logged in
echo "<h3>Kommentar verfassen</h3>";
if (User::auth()) {

    echo "<form method='POST' action='post/" . $this->post->id . "/comment'>";
    echo "<div class='form-group'>";
    echo "<textarea id='comment' rows='5' name='comment' class='form-control'></textarea>";
    echo "</div>";
    echo "<div class='form-group'>";
    echo "<input type='submit' class='btn btn-default' value='Kommentar absenden'>";
    echo "</div>";
    echo "</form>";
} else {
    echo "<p>Sie müssen eingeloggt sein, um einen Kommentar zu verfassen!</p>";
}

require_once(__ROOT__ . "Views/_footer.php");