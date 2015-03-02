#!/bin/bash
#
#SCRIPT: saveLinuxUsers.sh
#AUTHOR: Severin Kaderli
#PURPOSE: Saves Linux users in a nice table
#USAGE: ./saveLinuxUsers

#Copy users file to temp folder
cp /etc/passwd /tmp/userlist

#Display headers of the table
echo -e "Benutzername\tKennwort\tUID\tGID\tKommentar\tHeimatverzeichnis\tLogin-Kommando" > myusers

#Loop through each line of the user file
while read line
do
	name=`echo -e "$line" | cut -d':' -f1` 
	pw=`echo -e "$line" | cut -d':' -f2` 
	uid=`echo -e "$line" | cut -d':' -f3` 
	gid=`echo -e "$line" | cut -d':' -f4` 
	kommentar=`echo -e "$line" | cut -d':' -f5-9` 
	path=`echo -e "$line" | cut -d':' -f10` 
	login=`echo -e "$line" | cut -d':' -f11` 

	echo -e "$name\t\t$pw\t$uid\t$gid\t$kommentar\t$path\t$login" >> myusers
done < /tmp/userlist

#Delete temp file
rm /tmp/userlist