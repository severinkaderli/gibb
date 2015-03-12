#!/usr/bin/python3.4
#
#SCRIPT: systeminfo.py
#AUTHOR: Severin Kaderli
#PURPOSE: Show systeminformation
#USAGE: ./systeminfo.py
import listcpuinfo
import listmeminfo
import sys

#Get cpu info
cpu = listcpuinfo.getcpuinfo()
vendor = cpu[1]
model = cpu[4]
mhz = cpu[6]
cache = cpu[7]

#Get memory info
mem = listmeminfo.getmemoryinfo()
memTotal = mem[0]
memFree = mem[1]
buffers = mem[2]
cached = mem[3]

print('++++++++++++++++++++++')
print('Basic cpu information:')
print('++++++++++++++++++++++')
print(vendor+model+mhz+cache)

print('++++++++++++++++++++++')
print('Basic mem information:')
print('++++++++++++++++++++++')
print(memTotal+memFree+buffers+cached)

#Print arguments if available
if len(sys.argv) > 0:

	print('+++++++++++++++++++++++++')
	print('Extra System Information:')
	print('+++++++++++++++++++++++++')

	#Delete first element in sys.argv -> filename
	del sys.argv[0]

	for arg in sys.argv:
		print(arg)