; Ampelsteuerung
	JMP	Start	; Skip the data table

; Daten
	DB	FA	; 00
	DB	DF 	; 09
	DB	FF	; 08
	DB	8B	; 07
	DB	FD	; 06
	DB	DD	; 05
	DB	4F	; 04
	DB	9F	; 03
	DB	B7	; 02
	DB	0B	; 01
	DB	FB	; 00	


Start:
	MOV	BL,02	; Set BL to the start address of the data table

Loop:
	MOV	AL,[BL]	; Copy the data to AL
	OUT	02	; Output the port 01

	CMP	AL,FB 	; Check if we are at the end of the data table
	JZ	After	; If yes we jump back to the start
	INC	BL 	; Else we increment to the next data table
	JMP 	Loop	; We jump to the next data table entry

After:
	CALL	60
	JMP	Start


; Blink procedure
	ORG	60
	PUSHF
	PUSH	AL
	PUSH	BL
	MOV	BL,10
Blink:
	MOV	AL,00
	OUT	02
	MOV	AL,01
	OUT	02
	MOV	AL,FA
	OUT	02
	MOV	AL,FB
	OUT	02

	DEC	BL
	JNZ	Blink

	POP	BL
	POP	AL
	POPF	

	RET	

	END