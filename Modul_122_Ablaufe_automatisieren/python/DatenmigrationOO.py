#!/usr/bin/python3.4
#
#SCRIPT: DatenMigrationOO.py
#AUTHOR: Severin Kaderli
#PURPOSE: Validates csv file
#USAGE: ./DatenMigrationOO.py
import validierung
import csv

validator = validierung.Validator()

with open('Data1.csv', newline='') as f:
	reader = csv.reader(f, delimiter=';')
	rownr = 1
	for row in reader:
		colnr = 1
		for col in row:
			if colnr == 1:
				#Address Nr.
				if not validator.address(col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 2:
				#Vorname/Name
				if not validator.name(col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 3:
				#Strasse und Hausnummer
				if not validator.street(col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 4:
				#PLZ und Ort
				if not validator.place(col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 5:
				#Telefonnummer
				if not validator.tel(col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 6:
				#E-Mail Adresse
				if not validator.email(col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 7:
				#IPv4 Adresse
				if not validator.ip4(col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			if colnr == 8:
				#Datum
				if not validator.date(col):
					print("FEHLER: Zeile " + str(rownr) + ", Spalte " + str(colnr) + ": " + str(col))
			colnr+=1
		rownr+=1