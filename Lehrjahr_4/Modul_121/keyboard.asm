	CLO			; Close unwanted windows.
	MOV	BL,C0
Input:
	IN	00		; Wait for key press - Store it in AL.
	MOV	[BL],AL
	CMP	BL,FF
	JZ	Clear
	INC	BL

	CMP	AL,0D		; Was it the Enter key? (ASCII 0D)
	JNZ	Input		; No - jump back.  Yes - end.

Clear:
	CALL	30
	MOV	BL,C0
	JMP	Input

; Clear display
	ORG	30
	PUSHF
	PUSH	BL
	MOV	BL,C0
	MOV	AL,20
Loop:
	MOV	[BL],AL
	INC	BL
	JNZ	Loop
	
	POP	BL
	POPF
	RET

END


