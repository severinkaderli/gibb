#!/usr/bin/python3.4
#
#SCRIPT: strings.py
#AUTHOR: Severin Kaderli
#PURPOSE: Some fun with strings
#USAGE: ./strings.py

#String ausgeben
ausgabe = "Python lernen!"
print(ausgabe)
print("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX")

#Strings sind in Python indexiert
print(ausgabe[0])
print(ausgabe[5] + " " + ausgabe[3])

#Letztes Zeichen eines Strings bestimmen mit len()
letztes_zeichen = len(ausgabe)-1
print(ausgabe[letztes_zeichen])
print("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX")

#String mit while durchlaufen
i = 0
s = ""
while i <= int(letztes_zeichen):
	s = s + ausgabe[i]
	print(s)
	i=i+1
print("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")