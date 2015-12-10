<?php require_once(__ROOT__ . "Views/_header.php"); ?>

<table class="table table-striped">
    <thead>
        <tr>
            <th>Id</th>
            <th>Benutzername</th>
            <th>Rolle</th>
            <th>Befördern</th>
            <th>Löschen</th>
        </tr>
    </thead>
    <tbody>
<?php
foreach ($this->users as $user) {
    echo "<tr>";
        echo "<td>" . $user->id . "</td>";
        echo "<td>" . $user->username . "</td>";
        if($user->is_admin == 1) {
            echo "<td>Admin</td>";
        } else {
            echo "<td>Benutzer</td>";
        }

        if($user->is_admin == 0) {
            echo "<td><a href='user/" . $user->id . "/promote'><span class='glyphicon glyphicon-arrow-up'></span></a></td>";
        } else {
            echo "<td> - </td>";
        }

        if($user->id != $_SESSION["user"]["id"]) {
            echo "<td><a onclick='return confirm_delete()' href='user/" . $user->id . "/delete'><span class='glyphicon glyphicon-trash'></span></a></td>";
        } else {
            echo "<td> - </td>";
        }
    echo "</tr>";
}
?>
    </tbody>
</table>

<?php require_once(__ROOT__ . "Views/_footer.php"); ?>