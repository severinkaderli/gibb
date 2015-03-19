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
	for row in reader:
		colnr = 1
		for col in row:
			if colnr == 1:
				if re.search('\d{1,}', col) is False:
					print("ZEILE FEHLERHAFT: " + str(col))
			if colnr == 2:
				if re.search('\w{2,}\s\w{2,}', col) is False:
					print("ZEILE FEHLERHAFT: " + str(col))
			if colnr == 3:
				if re.search('\w{2,}\s\w{1,}', col) is False:
					print("ZEILE FEHLERHAFT: " + str(col))
			if colnr == 4:
				if re.search('\d{4}\s\w{2,}', col) is False:
					print("ZEILE FEHLERHAFT: " + str(col))
			if colnr == 5:
				if re.search('\w{9,}', col) is False:
					print("ZEILE FEHLERHAFT: " + str(col))
			if colnr == 6:
				if re.search('\w{2,}\@\w{2,}\.\w{2,}', col) is False:
					print("ZEILE FEHLERHAFT: " + str(col))
			if colnr == 7:
				if re.search('\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}', col) is False:
					print("ZEILE FEHLERHAFT: " + str(col))
			if colnr == 8: 
				if re.search('\d{1,2}\.\d{1,2}\.\d{2,4}', col) is False:
					print("ZEILE FEHLERHAFT: " + str(col))
			colnr+=1
			