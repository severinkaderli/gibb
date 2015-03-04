#!/bin/bash
#
#SCRIPT: BCtoSQL.sh
#AUTHOR: Severin Kaderli
#PURPOSE: Import CSV into sqlite database 
#USAGE: ./BCtoSQL.sh

dbfile=./SIX_Bankenstamm.db
table=Bankenstamm
csvfile=./SIX_BankenstammCH.csv
override=false

#Check if file exists and ask to override
if [[ -e ${dbfile} ]]; then
	echo "${dbfile} ist bereits vorhanden. Möchten Sie das File überschreiben? (y/n)"
	read answer
	if [[ "$answer" != "n" ]] || [[ "$answer"  != "N" ]]; then
		rm ${dbfile}
		override=true
	fi
else
	override=true
fi

#Table creation
if [[ "$override" = true  ]]; then
	attributes="$( head -n 1 ${csvfile} | iconv -f iso-8859-1 -t utf-8 | tr ";" "\n" | while read attribute
	do
		#Remove special characters and turn everything lowercase
		sanedAttribute="$( echo "${attribute}" | grep -o [a-zA-Z] | tr "[:upper:]" "[:lower:]" | tr -d "\n" )"
		type="TEXT"
		echo -n "${sanedAttribute} ${type}, "
	done )"

	#Remove last comma and create database
	attributes="$( echo "${attributes}" | rev | cut -c 3- | rev )"
	sqlite3 $dbfile "CREATE TABLE ${table} (${attributes});"
fi

#Clean data and import it to the database
tail -n +2 ${csvfile} | iconv -f iso-8859-1 -t utf-8 | while read line
do
	tuple="$( echo "${line}" | tr ";" "\n" | while read value
	do
        echo -n "\"$( echo -n "${value}" | sed 's/"/""/g' )\""
        echo -n ","
	done )"
	tuple="$( echo "${tuple}" | rev | cut -c 2- | rev )"

	sqlite3 $dbfile "INSERT INTO ${table} VALUES(${tuple});"
done