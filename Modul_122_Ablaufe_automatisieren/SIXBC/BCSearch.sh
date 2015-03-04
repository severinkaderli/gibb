#!/bin/bash
#
#SCRIPT: BCSeach.sh
#AUTHOR: Severin Kaderli
#PURPOSE: Search database after the specified terms
#USAGE: ./BCSearch.sh argument1 argument2 ... argumentN

dbfile=./SIX_Bankenstamm.db
table=Bankenstamm

#Check if there are any arguments
if [[ ${#} -lt 1 ]]; then
	echo "Bitte geben Sie mindestens einen Suchbegriff an!"
	exit
fi

#Get table attributes
sqlite3 $dbfile "PRAGMA table_info(${table});" > /tmp/attributeList
attributes=$(while read line; do
	attribute=$(echo "$line" | cut -d"|" -f2)
	echo -n "${attribute} "
done < /tmp/attributeList)

#Search file for matches and display them
for argument in $*; do
	result=""
	result="${result}$(for attribute in $attributes; do
		sqlite3 ${dbfile} "SELECT * FROM ${table} WHERE ${attribute} LIKE '%${argument}%';"
	done )"
	echo "$result"
done

#Remove tmp files
rm /tmp/attributeList