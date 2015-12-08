<?php require_once(__ROOT__ . "Views/_header.php"); ?>
    <h1>Eintrag erstellen</h1>
    <form method="POST" action="post">
        <div class="form-group">
            <label for="title">Titel</label>
            <input type="text" name="title" id="title" class="form-control">
        </div>
        <div class="form-group">
            <label for="content">Inhalt</label>
            <textarea id='content' rows='5' name='content' class='form-control'></textarea>
        </div>
        <div class="form-group">
            <input type="submit" name="createPostSubmit" value="Eintrag erstellen" class="btn btn-default">
        </div>
    </form>
<?php require_once(__ROOT__ . "Views/_footer.php"); ?>