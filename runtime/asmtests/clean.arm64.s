	.section	__TEXT,__text,regular,pure_instructions
	.build_version macos, 11, 0	sdk_version 11, 3
	.globl	_xamarin_dyn_objc_msgSend       ; -- Begin function xamarin_dyn_objc_msgSend
	.p2align	2
_xamarin_dyn_objc_msgSend:              ; @xamarin_dyn_objc_msgSend
Lfunc_begin2:
	.cfi_startproc
	.cfi_personality 155, ___objc_personality_v0
	.cfi_lsda 16, Lexception0
; %bb.0:
	stp	x20, x19, [sp, #-32]!           ; 16-byte Folded Spill
	stp	x29, x30, [sp, #16]             ; 16-byte Folded Spill
	add	x29, sp, #16                    ; =16
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	.cfi_offset w19, -24
	.cfi_offset w20, -32
Ltmp0:

	; calculate the amount of stack space we need
	sub sp, sp, #400

	; we need to preserve:
	;   x0-x9, x16, x19
	;   q0-q7

	stp  x0, x1, [sp, #0x10]
	stp  x2, x3, [sp, #0x20]
	stp  x4, x5, [sp, #0x30]
	stp  x6, x7, [sp, #0x40]
	stp  x8, x9, [sp, #0x50]
	stp x16,x19, [sp, #0x60]

	stp  q0, q1, [sp, #0x70]
	stp  q2, q3, [sp, #0x90]
	stp  q4, q5, [sp, #0xb0]
	stp  q6, q7, [sp, #0xd0]

	; figure out how much stack space we need
	bl	_xamarin_get_frame_length

	; x19 holds the amount of stack space we need
	mov	x19, x0

	; first align stack requirement to 16 bytes
	add x19, x19, #15
	lsr x19, x19, #4
	lsl x19, x19, #4

	; then make space for the arguments

	sub sp, sp, x19

	; copy arguments from old location in the stack to new location in the stack
    ; x2 will hold the amount of bytes left to copy. This will be a multiple of 8.
    ; x1 the current src location
    ; x0 the current dst location

    mov x2, x19       ; x2 = frame_length
    mov x1, x29       ; x1 = address of first argument we got
    sub x1, x1, #16   ;
    mov x0, sp        ; x0 = address of the bottom of the stack

L_start:
    cmp  x2, #0                ;
    b.eq L_end                 ; while (left != 0) {
    sub  x2, x2, #8            ;    len -= 8                 x2 -= 8
    ldr  x3, [x1, x2]          ;    tmp = src [len]          x3 = x1 [x2]
    str  x3, [x0, x2]          ;    dst [len] = tmp          x0 [x2] = x3
    b    L_start               ; }
L_end:


	; restore original input registers, except x19, which we're using
	ldp  x0, x1, [sp, #0x10]
	ldp  x2, x3, [sp, #0x20]
	ldp  x4, x5, [sp, #0x30]
	ldp  x6, x7, [sp, #0x40]
	ldp  x8, x9, [sp, #0x50]
	ldr x16,     [sp, #0x60]

	ldp  q0, q1, [sp, #0x70]
	ldp  q2, q3, [sp, #0x90]
	ldp  q4, q5, [sp, #0xb0]
	ldp  q6, q7, [sp, #0xd0]

	bl	_objc_msgSend

	; restore the stack to it's previous value
	add sp, sp, x19

	; now restore x19
	ldr x19,     [sp, #0x58]

	add sp, sp, #400

Lafterinvoke:
	ldp	x29, x30, [sp, #16]             ; 16-byte Folded Reload
	ldp	x20, x19, [sp], #32             ; 16-byte Folded Reload
	ret
Lcatchhandler:
	mov	x19, x0
	cmp	w1, #1                          ; =1
	b.ne	Lnomatchexception
	mov	x0, x19
	bl	_objc_begin_catch
Lcatchbegin:
	mov	w1, #0
	mov	x2, #0
	bl	_xamarin_process_nsexception_with_mode
Lcatchend:
	bl	_objc_end_catch
	b	Lafterinvoke
Lcatchcatchhandler:
	mov	x19, x0
	bl	_objc_end_catch
Lnomatchexception:
	mov	x0, x19
	bl	__Unwind_Resume
	brk	#0x1
Lfunc_end2:
	.cfi_endproc
	.section	__TEXT,__gcc_except_tab
	.p2align	2
GCC_except_table0:
Lexception0:
	.byte	255                             ; @LPStart Encoding = omit
	.byte	155                             ; @TType Encoding = indirect pcrel sdata4
	.uleb128 Lttbase0-Lttbaseref0
Lttbaseref0:
	.byte	1                               ; Call site Encoding = uleb128
	.uleb128 Lcst_end0-Lcst_begin0
Lcst_begin0:
	.uleb128 Ltmp0-Lfunc_begin2             ; >> Call Site 1 <<
	.uleb128 Lafterinvoke-Ltmp0                    ;   Call between Ltmp0 and Lafterinvoke
	.uleb128 Lcatchhandler-Lfunc_begin2             ;     jumps to Lcatchhandler
	.byte	3                               ;   On action: 2
	.uleb128 Lafterinvoke-Lfunc_begin2             ; >> Call Site 2 <<
	.uleb128 Lcatchbegin-Lafterinvoke                    ;   Call between Lafterinvoke and Lcatchbegin
	.byte	0                               ;     has no landing pad
	.byte	0                               ;   On action: cleanup
	.uleb128 Lcatchbegin-Lfunc_begin2             ; >> Call Site 3 <<
	.uleb128 Lcatchend-Lcatchbegin                    ;   Call between Lcatchbegin and Lcatchend
	.uleb128 Lcatchcatchhandler-Lfunc_begin2             ;     jumps to Lcatchcatchhandler
	.byte	0                               ;   On action: cleanup
	.uleb128 Lcatchend-Lfunc_begin2             ; >> Call Site 4 <<
	.uleb128 Lfunc_end2-Lcatchend               ;   Call between Lcatchend and Lfunc_end2
	.byte	0                               ;     has no landing pad
	.byte	0                               ;   On action: cleanup
Lcst_end0:
	.byte	0                               ; >> Action Record 1 <<
                                        ;   Cleanup
	.byte	0                               ;   No further actions
	.byte	1                               ; >> Action Record 2 <<
                                        ;   Catch TypeInfo 1
	.byte	125                             ;   Continue to action 1
	.p2align	2
                                        ; >> Catch TypeInfos <<
Ltmp8:                                  ; TypeInfo 1
	.long	_OBJC_EHTYPE_$_NSException@GOT-Ltmp8
Lttbase0:
	.p2align	2
                                        ; -- End function
	.section	__DATA,__objc_imageinfo,regular,no_dead_strip
L_OBJC_IMAGE_INFO:
	.long	0
	.long	64

.subsections_via_symbols
