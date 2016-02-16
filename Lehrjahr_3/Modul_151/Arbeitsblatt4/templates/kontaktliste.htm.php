<table class="liste" width="100%" cellspacing="1">
  <tr>
	<th></th>
	<th>Name</th>
	<th>Vorname</th>
	<th>Strasse</th>
	<th>PLZ</th>
	<th>Ort</th>
	<th>E-Mail</th>
	<th>Tel.nr.</th>
  </tr>
  <?php
	foreach(getValue("data") as $row) {
	  echo "<tr>
			<td><a href='".getValue('phpmodule')."&kid=".$row['kid']."'>
			<img src=\"../images/delete.png\" border=\"no\" onclick=\"return confdel();\"></a></td>
			<td>".htmlTextAufbereiten($row['nachname'])."</td>
			<td>".htmlTextAufbereiten($row['vorname'])."</td>
			<td>".htmlTextAufbereiten($row['strasse'])."</td>
			<td>".$row['plz']."</td>
			<td>".htmlTextAufbereiten($row['ort'])."</td>
			<td>".htmlTextAufbereiten($row['email'])."</td>
			<td>".htmlTextAufbereiten($row['tel'])."</td>
			</tr>\n";
	}
  ?>
  <tr>
	<td class="<?php echo getValue("css_class_meldung"); ?>" colspan="8">
	  <?php echo getValue("meldung")."&nbsp;"; ?>
	</td>
  </tr>
</table>