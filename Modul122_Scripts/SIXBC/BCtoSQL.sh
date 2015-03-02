#!/bin/bash
#
#SCRIPT: BCtoSQL.sh
#AUTHOR: Severin Kaderli
#PURPOSE: 
#USAGE: ./BCtoSQL.sh

rm SIX_Bankenstamm.db
cp SIX_Bankenstamm.bak.db SIX_Bankenstamm.db
sqlite3 SIX_Bankenstamm.db "TRUNCATE TABLE bankenstamm"

#Loop through each user and insert it in the db
attributes=('id' 'BCNr' 'IBAN' 'PZ' 'BCNR_IID' 'Landcode' 'Postkonto_in' 'Postkonto_out' 'SWIFT' 'Email' 'Mutationsdatum' 'Hauptsitz' 'BC-Art' 'Bank' 'SIC' 'euro-sic' 'Sprache' 'Beschreibung' 'Domizil' 'Postadresse' 'PLZ' 'Ort' 'Telefon' 'Fax')

n=1
while read line
do
	if [[ n -gt 1 ]]; then
		for (( i = 1; i <= 24; i++ )); do
			field[$i]=`echo -e "$line" | cut -d ';' -f$i`
			if [[ ${field[$i]} == "" ]]; then
				field[$i]="NULL"
			fi
			if [[ i -eq 1 ]]; then
				sqlite3 SIX_Bankenstamm.db "INSERT INTO bankenstamm(\"${attributes[$i]}\") VALUES(\"${field[$i]}\");"
			else
				sqlite3 SIX_Bankenstamm.db "UPDATE bankenstamm SET \"${attributes[$i-1]}\"=\"${field[$i]}\" WHERE id=\"${field[1]}\";"
			fi
		done		
	fi
	n=$((n+1))
done < SIX_BankenstammCH.csv

echo -e "Script is finished!"