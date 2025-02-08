;
; Bright boost for pictures
; Author: Oskar Hamerla
; Semester 5
; 2024 / 2025
;
; DLL implemented in assembly that brights up the pixels
; This method takes every byte that represents R, G, B and adds values to them
;


.code
BrightenColorsAsm proc
    mov r10, rdx            ; Initial byte index
    xor rdx, rdx            ; Clear rdx for division
    mov rax, r8             ; Total bytes to process
    div r9                  ; Divide by row stride
    mov r11, rax            ; Store number of rows

    ; Prepare XMM2 with constant value 127 for all bytes
    mov rax, 127
    movd xmm2, eax
    pxor xmm3, xmm3        ; Clear XMM3 for zero comparison
    pshufb xmm2, xmm3      ; Broadcast 127 to all bytes in XMM2

loop1:
    dec r11
    cmp r11, 0
    jl end_loop1
    mov r13, r9

loop2:
    sub r13, 16
    cmp r13, 0
    jl end_loop2

    ; Load 16 bytes of image data
    movdqu xmm1, [rcx + r10]
    
    ; Add 127 to all bytes simultaneously
    paddusb xmm1, xmm2     ; Packed add with unsigned saturation
    
    ; Store result back
    movdqu [rcx + r10], xmm1
    
    add r10, 16
    jmp loop2

end_loop2:
    add r10, rdx
    jmp loop1

end_loop1:
    ret
BrightenColorsAsm endp
end