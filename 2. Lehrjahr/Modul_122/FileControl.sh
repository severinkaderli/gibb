#/bin/bash

if test $# -ne 2
then
	echo "Sie müssen zwei Dateinamen angeben."
	echo "Usage: FileControl.sh File1 File2"
else
	if  [ ! -f $1 ]
	then
		 echo "Die Datei  $1 existiert nicht."
	else
		echo "Die Datei $1 existiert!"
	fi
fi