#!/usr/bin/python3.4
#
#SCRIPT: validierung.py
#AUTHOR: Severin Kaderli
#PURPOSE: Class for validation
#USAGE: ./validierung.py
import re

class validate:
	def address(self, string):
		@staticmethod
		if not re.search('^\d{1,}$', string):
			return false
		else:
			return true
	def name(self, string):
		@staticmethod
		if not re.search('^[a-zA-Z\'-]{1,}\s[a-zA-Z\'-]{1,}$', string):
			return false
		else:
			return true
	def street(self, string):
		@staticmethod
		if not re.search('^[a-zA-Z-öäü\'\s]{1,}(\s\d{1,}([a-z]{1,})?)$', string):
			return false
		else:
			return true
	def place(self, string):
		@staticmethod
		if not re.search('^\d{4}\s\w{2,}$', string):
			return false
		else:
			return true
	def tel(self, string):
		@staticmethod
		if not re.search('^[0-9\s\/-]{8,}$', string):
			return false
		else:
			return true
	def email(self, string):
		@staticmethod
		if not re.search('^\w{1,}\@\w{1,}\.\w{2,}$', string):
			return false
		else:
			return true
	def ip4(self, string):
		@staticmethod
		if not re.search('^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$', string):
			return false
		else:
			return true
	def date(self, string):
		@staticmethod
		if not re.search('\d{1,2}\.\d{1,2}\.\d{2,4}', string):
			return false
		else:
			return true