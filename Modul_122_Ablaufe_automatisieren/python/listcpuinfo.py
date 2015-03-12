#!/usr/bin/python3.4
#
#SCRIPT: listcpuinfo.py
#AUTHOR: Severin Kaderli
#PURPOSE: List cpu info
#USAGE: ./listcpuinfo.py
def getcpuinfo():
	cpuinfo = open('/proc/cpuinfo', 'r')
	liste = cpuinfo.readlines()
	return liste