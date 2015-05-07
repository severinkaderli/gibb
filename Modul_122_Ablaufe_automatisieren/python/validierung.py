#!/usr/bin/python3.4
#
#SCRIPT: validierung.py
#AUTHOR: Severin Kaderli
#PURPOSE: Class for validation
#USAGE: ./validierung.py
import re

class Validator:
	def address(self, string):
		if not re.search('^\d{1,}$', string):
			return False
		else:
			return True
	def name(self, string):
		if not re.search('^[a-zA-Z\'-]{1,}\s[a-zA-Z\'-]{1,}$', string):
			return False
		else:
			return True
	def street(self, string):
		if not re.search('^[a-zA-Z-öäü\'\s]{1,}(\s\d{1,}([a-z]{1,})?)$', string):
			return False
		else:
			return True
	def place(self, string):
		if not re.search('^\d{4,6}\s\w{2,}$', string):
			return False
		else:
			return True
	def tel(self, string):
		if not re.search('^\+?[0-9\s\/-]{8,}$', string):
			return False
		else:
			return True
	def email(self, string):
		if not re.search('^[0-9a-zA-Z-\.\_]{1,}\@\w{1,}\.\w{2,}$', string):
			return False
		else:
			return True
	def ip4(self, string):
		if not re.search('^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$', string):
			return False
		else:
			return True
	def date(self, string):
		if not re.search('\d{1,2}\.\d{1,2}\.\d{2,4}', string):
			return False
		else:
			return True