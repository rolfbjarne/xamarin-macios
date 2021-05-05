	.section	__TEXT,__text,regular,pure_instructions
	.build_version macos, 11, 0	sdk_version 11, 3
	.globl	_whatever                       ; -- Begin function whatever
	.p2align	2
_whatever:                              ; @whatever
	.cfi_startproc
; %bb.0:
	stp	x29, x30, [sp, #-16]!           ; 16-byte Folded Spill
	mov	x29, sp
	.cfi_def_cfa w29, 16
	.cfi_offset w30, -8
	.cfi_offset w29, -16
	bl	_objc_msgSend
Lloh0:
	adrp	x8, _xamarin_marshal_objectivec_exception_mode@GOTPAGE
Lloh1:
	ldr	x8, [x8, _xamarin_marshal_objectivec_exception_mode@GOTPAGEOFF]
Lloh2:
	ldr	w0, [x8]
	bl	_whatever2
	ldp	x29, x30, [sp], #16             ; 16-byte Folded Reload
	ret
	.loh AdrpLdrGotLdr	Lloh0, Lloh1, Lloh2
	.cfi_endproc
                                        ; -- End function
	.section	__DATA,__objc_imageinfo,regular,no_dead_strip
L_OBJC_IMAGE_INFO:
	.long	0
	.long	64

.subsections_via_symbols
