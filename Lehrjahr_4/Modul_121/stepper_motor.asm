	JMP	Start

Data:
	DB	01
	DB	03
	DB	02
	DB	06
	DB	04
	DB	0C
	DB	08
	DB	09

Start:
	NOT	CL	; Toggle the flag
	MOV 	BL,02

Loop:
	MOV 	AL, [BL]
	OUT	05

	CMP	CL,00 	; Check if flag is 00
	JZ	Half 	; If yes run the motor in half steps
	JMP	Full	; Else use full steps

Full:
	CMP	AL,08
	JZ	Start
	ADD	BL,2
	JMP	Loop

Half:
	CMP	AL,09
	JZ	Start
	INC	BL
	JMP	Loop
	

	END
