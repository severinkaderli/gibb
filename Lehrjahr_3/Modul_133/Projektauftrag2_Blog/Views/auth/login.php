<?php require_once(__ROOT__ . "Views/_header.php"); ?>
    <h1>Login</h1>
    <form method="POST" action="login">
        <div class="form-group">
            <label for="username">Benutzername</label>
            <input type="text" name="username" id="username" class="form-control" required>
        </div>
        <div class="form-group">
            <label for="password">Passwort</label>
            <input type="password" name="password" id="password" class="form-control" required>
        </div>
        <div class="form-group">
            <input type="submit" name="loginSubmit" value="Login" class="btn btn-default">
        </div>
    </form>
<?php require_once(__ROOT__ . "Views/_footer.php"); ?>