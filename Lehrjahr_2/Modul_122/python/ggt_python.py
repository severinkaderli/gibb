#!/usr/bin/python3.4
#
#SCRIPT: ggt_python.py
#AUTHOR: Severin Kaderli
#PURPOSE: calculate ggt in python
#USAGE: ./ggt_python.py
a = input("Erste Zahl angeben: ")
b = input("Zweite Zahl angeben: ")

def ggt(a, b):
	while True:
		a, b = b, int(a) % int(b)
		yield int(a), int(b)
		if b == 0: break

g = ggt(a, b)

counter = 1
for x in g:
	print("Schritt " + str(counter) + " = " + str(x))
	counter+=1
print