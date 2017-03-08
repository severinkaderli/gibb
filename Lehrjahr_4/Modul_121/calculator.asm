	CLO			; Close unwanted windows.
	MOV	BL,C0

Input:
	IN	00		; Wait for key press - Store it in AL.
	MOV	[BL],AL
	INC	BL
	
	CMP	BL,C3
	JZ	Eval

	CMP	AL,0D		; Was it the Enter key? (ASCII 0D)
	JNZ	Input		; No - jump back.  Yes - end.
	JMP	End

Eval:
	MOV	DL,[C1]
	MOV	AL,00
	PUSH	AL
	POP	CL
	CMP	DL,2B		; If operation is + jump to add
	JZ	Add

Add:
	MOV	DL,[C0]
	SUB	DL,30
	ADD	CL,DL
	MOV	DL,[C2]
	SUB	DL,30
	ADD	CL,DL	
	JMP	Display

Display:
	MOV	DL,20
	MOV	[C3],DL
	MOV	DL,3D
	MOV	[C4],DL
	MOV	DL,20
	MOV	[C5],DL
	ADD	CL,30
	PUSH	CL
	POP	DL
	MOV	[C6],DL

End:
	END


