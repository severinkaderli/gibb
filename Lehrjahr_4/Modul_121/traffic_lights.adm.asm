; Ampelsteuerung
	JMP	Start	; Skip the data table

; Daten
	DB	90 	; red/red
	DB	98	; red/red-orange
	DB	84	; red/green
	DB	8C	; red/green-orange
	DB	90	; red/red
	DB	D0	; red-orange/red
	DB	30	; green/red
	DB	70	; green-orange/red	

; Long delay
Long:
	MOV	CL,10
	CALL	60
	JMP	After

; Middle long delay
Middle:
	MOV	CL,5
	CALL	60
	JMP	After	

Start:
	MOV	BL,02	; Set BL to the start address of the data table

Loop:
	MOV	AL,[BL]	; Copy the data to AL
	OUT	01	; Output the port 01


	CMP	AL,84	; Long delay when green/red
	JZ	Long

	CMP	AL,30	; Middle long delay when red/green
	JZ	Middle

After:
	CMP	AL,70 	; Check if we are at the end of the data table
	JZ	Start 	; If yes we jump back to the start
	INC	BL 	; Else we increment to the next data table
	JMP 	Loop	; We jump to the next data table entry

; Procedure for delay
	ORG	60
	PUSHF

Wait:
	DEC	Cl
	JNZ	Wait
	
	POPF

	RET	

END