#!/usr/bin/python3.4
#
#SCRIPT: integer.py
#AUTHOR: Severin Kaderli
#PURPOSE: Some calculations in python
#USAGE: ./integer.py

from math import sqrt

# String ausgeben
print("--------------------")
print("Hello Python!")
print("--------------------")

#Integer: Pythogaras
print("Integer:")
print("Pythagoras a^2+b^2=c^2")
a = 5
b = 6
quadrat = a**2 + b**2
c = float(sqrt(quadrat))
print("a=5, b=6, c="+str(c))

#Division
print("Division mit / und // Operator")
print(str(100-36/10))
print(str(100-36//10))