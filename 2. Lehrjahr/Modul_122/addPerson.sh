#!/bin/bash
echo "Geben Sie ihren Namen ein (mit quit beenden):"
read name
while true; do
    if [ "$name" = "quit" ]; then
        echo "Exit add person"
	break
    else
	echo "$name" >> Phonelist
	echo "Geben Sie ihren Namen ein:"
	read name
    fi
done