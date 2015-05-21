#!/usr/bin/python3.4
#
#SCRIPT: listmemoryinfo.py
#AUTHOR: Severin Kaderli
#PURPOSE: List mem info
#USAGE: ./listmemoryinfo.py
def getmemoryinfo():
	meminfo = open('/proc/meminfo', 'r')
	liste = meminfo.readlines()
	return liste