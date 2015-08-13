#!/usr/bin/python3.4
#
#SCRIPT: cpuinfo.py
#AUTHOR: Severin Kaderli
#PURPOSE: Show cpu info
#USAGE: ./cpuinfo.py

#Open file
cpuinfo = open('/proc/cpuinfo', 'r')

#Show file information
print(cpuinfo)

#Loop through file and print each line
for line in cpuinfo:
	print(line, end='')

#Read file
print(cpuinfo.read())

#Print first and second line
print(cpuinfo.readline())
print(cpuinfo.readline())

#Print the rest of the file
print(cpuinfo.readlines())