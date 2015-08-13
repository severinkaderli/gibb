#!/usr/bin/python3.4
#
#SCRIPT: EingabeValidierung.py
#AUTHOR: Severin Kaderli
#PURPOSE: Validates user input
#USAGE: ./EingabeValidierung.py 'Begriff'
import re
import sys

def validation(begriff):
	#Vorname & Name: 'Severin Kaderli'
	if re.search('\w{3,}\s\w{3,}', begriff):
		print('Name/Vorname')
	#Strasse und Hausnummer: 'Austrasse 23'
	elif re.search('\w{2,}\s\d{1,}', begriff):
		print('Strasse und Hausnummer')
	#PLZ und Ort: '3627 Heimberg'
	elif re.search('\d{4}\s\w{2,}', begriff):
		print('PLZ und Ort')
	#E-Mail: 'severin.kaderli@gmail.com'
	elif re.search('\w{2,}\@\w{2,}\.\w{2,}', begriff):
		print('E-Mail')
	#Geburtsdatum: 30.06.1995
	elif re.search('\d{2}\.\d{2}\.\d{4}', begriff):
		print('Geburtsdatum')
	#Kontonummer: CH6309000000250097798
	elif re.search('\w{2}\d{19}', begriff):
		print('Postkontonummer')
	else:
		print('Eingabe hat einen unbekannten Typ.')
		print()
		begriff = input('Bitte geben Sie einen neuen Begriff an: ')
		validation(begriff)

if len(sys.argv) < 2:
	print('Bitte geben Sie einen Parameter an!')
	sys.exit(0)

validation(sys.argv[1])