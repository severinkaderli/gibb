#!/bin/bash
#
#SCRIPT: SQLTux.sh
#AUTHOR: Severin Kaderli
#PURPOSE: Creates a sqlite database and inserts all root, vm and tux users
#USAGE: ./SQLTux.sh

#Create database linuxusers.db
rm linuxusers.db

#Create database linuxusers.db and table LinuxBenutzer
sqlite3 linuxusers.db "CREATE TABLE LinuxBenutzer(id INTEGER PRIMARY KEY, username TEXT, uid INTEGER, gid INTEGER, home TEXT);"

#Get users from /etc/passwd and save it in a temp file
grep -iE "(tux|root|vm)" /etc/passwd >> /tmp/userlist

#Loop through each user and insert it in the db
while read line
do
	username=`echo -e "$line" | cut -d':' -f1`
	uid=`echo -e "$line" | cut -d':' -f3` 
	gid=`echo -e "$line" | cut -d':' -f4` 
	homefolder=`echo -e "$line" | cut -d':' -f10`

	echo "User $username added to table LinuxBenutzer!"

	sqlite3 linuxusers.db "INSERT INTO LinuxBenutzer(username, uid, gid, home) VALUES('$username', '$uid', '$gid', '$homefolder');"
done < /tmp/userlist

#Display the table
echo -e "Displaying table... LinuxBenutzer\n"
sqlite3 linuxusers.db "SELECT * FROM LinuxBenutzer"

#Remove the temp file
rm /tmp/userlist