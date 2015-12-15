<?php require_once(__ROOT__ . "Views/_header.php"); ?>

<h1>Registrieren</h1>
<form method="POST" action="register">
    <div class="form-group">
        <label for="username">Benutzername</label>
        <input type="text" name="username" id="username" class="form-control" required>
    </div>
    <div class="form-group">
        <label for="firstname">Vorname</label>
        <input type="text" name="firstname" id="firstname" class="form-control" required>
    </div>
    <div class="form-group">
        <label for="lastname">Nachname</label>
        <input type="text" name="lastname" id="lastname" class="form-control" required>
    </div>
    <div class="form-group">
        <label for="password">Passwort</label>
        <input type="password" name="password" id="password" class="form-control" required>
    </div>
    <div class="form-group">
        <label for="password_confirmation">Passwort bestätigen</label>
        <input type="password" name="password_confirmation" id="password_confirmation" class="form-control" required>
    </div>
    <div class="form-group">
        <input type="submit" name="registerSubmit" value="Registrieren" class="btn btn-default">
    </div>
</form>

<?php require_once(__ROOT__ . "Views/_footer.php"); ?>