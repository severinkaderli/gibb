#!/usr/bin/python3.4
#
#SCRIPT: fib_rek.py
#AUTHOR: Severin Kaderli
#PURPOSE: Calculates Fibonacci sequence
#USAGE: ./fib_rek.py
number = input("Anzahl Zahlen: ")

def fibonacci(n):
	if n <= 2:
		return 1
	else:
		return fibonacci(n-1) + fibonacci(n-2)

for i in range(1, int(number)+1):
	print("fib(" + str(i) + ") = " + str(int(fibonacci(i))))