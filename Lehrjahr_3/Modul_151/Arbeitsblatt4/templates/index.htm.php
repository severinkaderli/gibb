<!DOCTYPE html>
<html lang="de">
<head>
	<meta charset="utf-8"/>
	<link rel="stylesheet" type="text/css" href="../css/styles.css"/>
	<script src="../js/jscript.js" type="text/javascript"></script>
	<title>Kontakteverwaltung</title>
</head>

<body>
  <div align="center">
	<table width="1004" align="center" cellpadding="0" cellspacing="0">
	  <tr>
		<td id="topimg" width="1004" height="100" colspan="2"></td>
	  </tr>
	  <tr>
		<td class="nav" width="200" align="center" valign="top">
          <?php getMenu(getValue("cfg_menu_list"), "Hauptmenü"); ?>
		</td>	
		<td class="content" width="804" valign="top" align="left">
          <table width="100%" cellpadding="5" cellspacing="0">
            <tr><td> <?php echo getValue("inhalt"); ?> </td></tr>
          </table>
        </td>
	  </tr>
	  <tr>
        <td colspan="2">
          <table class="bottom" width="100%" cellpadding="0" cellspacing="0">
            <tr height="5">
              <td id="bottomimg" height="15" align="center">
                <span class="wb10">&copy; Copyright IET-gibb</span>
			  </td>
            </tr>
          </table>
        </td>
	  </tr>
	</table>
  </div>
</body>
</html>
