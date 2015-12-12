<?php require_once(__ROOT__ . "Views/_header.php"); ?>
    <h1>Eintrag aktualisieren</h1>
    <form method="POST" action="post/<?php echo $this->post->id;?>/update">
        <div class="form-group">
            <label for="title">Titel</label>
            <input type="text" name="title" id="title" value="<?php echo $this->post->title; ?>" class="form-control">
        </div>
        <div class="form-group">
            <label for="content">Inhalt</label>
            <textarea id='content' rows='5' name='content' class='form-control'><?php echo $this->post->content;?></textarea>
        </div>
        <div class="form-group">
            <input type="submit" name="createPostSubmit" value="Eintrag aktualisieren" class="btn btn-default">
        </div>
    </form>
<?php require_once(__ROOT__ . "Views/_footer.php"); ?>