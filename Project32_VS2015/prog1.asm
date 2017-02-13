
.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword
.data 
A DWORD 30
B DWORD 20
Cee DWORD 10; it threw an error when I used the letter c, so i spelled it out
D DWORD 5
.code
main proc
	mov eax,A
	mov ebx,B
	mov ecx,Cee
	mov edx,D
	
	add eax,ebx
	add ecx,edx
	
	sub eax,ecx
	mov A,eax			

	invoke ExitProcess,0
main endp
end main