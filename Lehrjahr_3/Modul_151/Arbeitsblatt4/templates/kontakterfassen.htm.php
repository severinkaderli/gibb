<form name="kontakt" action="<?php echo getValue("phpmodule"); ?>" method="post">
<table cellpadding="0" cellspacing="0">
  <tr>
    <td>
      <table class="kontakt" border="0" cellpadding="5" cellspacing="1">
        <tr>
          <td width="120"><span class="label">Nachname*</span></td>
          <td><input class="<?php echo getCssClass("nachname"); ?> standardWidth" type="text" name="nachname" value="<?php echo getHtmlValue("nachname"); ?>" maxlength="50"></td>
        </tr>
        <tr>
          <td><span class="label">Vorname</span></td>
		  <td><input class="<?php echo getCssClass("vorname"); ?> standardWidth" type="text" name="vorname" value="<?php echo getHtmlValue("vorname"); ?>" maxlength="50"></td>
        </tr>
        <tr>
          <td><span class="label">Strasse</span></td>
		  <td><input class="txt standardWidth" type="text" name="strasse" value="<?php echo getHtmlValue("strasse"); ?>" maxlength="100"></td>
        </tr>
        <tr>
        <tr>
          <td><span class="label">PLZ/Ort</span></td>
		  <td><?php echo getValue("droport"); ?></td>
        </tr>		
        <tr>		
          <td><span class="label">E-Mail*</span></td>
		  <td><input class="<?php echo getCssClass("email"); ?> standardWidth" type="text" name="email" value="<?php echo getHtmlValue("email"); ?>" maxlength="100"></td>
        </tr>
        <tr>
          <td><span class="label">Telefonnr.</span></td>
		  <td><input class="txt standardWidth" type="text" name="tel" value="<?php echo getHtmlValue("tel"); ?>" maxlength="20">
		  </td>
        </tr>
		<tr>
		  <td class="<?php echo getValue("css_class_meldung"); ?>" colspan="2">
			<?php echo getValue("meldung")."&nbsp;"; ?>
		  </td>
		</tr>
      </table>
	</td>
	<td width="50">
	</td>
	<td valign="top">
	  <table border="0" cellpadding="2" cellspacing="0">
	    <tr>
		  <td>
		    <input type="submit" name="speichern" value="speichern">
		  </td>
		</tr>	  
	  </table>
	</td>
  </tr>
</table>
</form>