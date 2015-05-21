#!/usr/bin/python3.4
#
#SCRIPT: DatenMigration.py
#AUTHOR: Severin Kaderli
#PURPOSE: Validates csv file
#USAGE: ./DatenMigration.py
import re
import csv

with open('Data1.csv', newline='') as f:
	reader = csv.reader(f, delimiter=';')
	rownr = 1
	for row in reader:
		colnr = 1
		for col in row:
			if colnr == 1:
				#Address Nr.
				if not re.search('^\d{1,}$', col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 2:
				#Vorname/Name
				if not re.search('^[a-zA-Z\'-]{1,}\s[a-zA-Z\'-]{1,}$', col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 3:
				#Strasse und Hausnummer
				if not re.search('^[a-zA-Z-öäü\'\s]{1,}(\s\d{1,}([a-z]{1,})?)$', col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 4:
				#PLZ und Ort
				if not re.search('^\d{4}\s\w{2,}$', col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 5:
				#Telefonnummer
				if not re.search('^[0-9\s\/-]{8,}$', col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 6:
				#E-Mail Adresse
				if not re.search('^\w{1,}\@\w{1,}\.\w{2,}$', col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 7:
				#IPv4 Adresse
				if not re.search('^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$', col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 8:
				#Datum
				if not re.search('\d{1,2}\.\d{1,2}\.\d{2,4}', col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			colnr+=1
		rownr+=1
			