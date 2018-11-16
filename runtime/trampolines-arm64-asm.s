#
# store all parameters in a consistent way, and send it off to managed code.
# we need to store:
#   %rdi, %rsi, %rdx, %rcx, %r8, %r9
#   %xmm0-%xmm7
#   an unknown amount of stack space, but we can pass a pointer to the start of this area.
# in total we need 6*64bits registers + 8*128bits registers + 1*64bit ptr = 184 bytes.
# additionally we'll use %r11 to specify the type of trampoline was called, so 192 bytes.
#
#
# upon return we may need to write to:
#   %rax, %rdx 
#   %xmm0-%xmm1
#   (the spec says %st0 and %st1 are used to return 'long double' arguments, but we won't encounter those)
#

#if __arm64__

.subsections_via_symbols
.text

_xamarin_arm64_common_trampoline:
	mov x9, sp ;#Save sp to a temporary register
	sub sp, sp, #224 ;# allocate 224 bytes from the stack (stack must always be 16-byte aligned)

	# todo: verify alignment.
	stp x16, x9, [sp, #0x00]
	stp  x0, x1, [sp, #0x10]
	stp  x2, x3, [sp, #0x20]
	stp  x4, x5, [sp, #0x30]
	stp  x6, x7, [sp, #0x40]
	str  x8,     [sp, #0x50]

	stp  q0, q1, [sp, #0x60]
	stp  q2, q3, [sp, #0x80]
	stp  q4, q5, [sp, #0xa0]
	stp  q6, q7, [sp, #0xc0]

	mov x0, sp
	bl	_xamarin_arch_trampoline

	# get return value(s)

	;#FIXME return values

	ldp x16, x9, [sp, #0x00]
	ldp  x0, x1, [sp, #0x10]
	ldp  x2, x3, [sp, #0x20]
	ldp  x4, x5, [sp, #0x30]
	ldp  x6, x7, [sp, #0x40]
	ldr  x8,     [sp, #0x50]

	ldp  q0, q1, [sp, #0x60]
	ldp  q2, q3, [sp, #0x80]
	ldp  q4, q5, [sp, #0xa0]
	ldp  q6, q7, [sp, #0xc0]

	add sp, sp, #224 ;# deallocate 224 bytes from the stack

	ret

#
# trampolines
#

.globl _xamarin_trampoline
_xamarin_trampoline:
	mov	x16, #0x0
	b	_xamarin_arm64_common_trampoline

.globl _xamarin_static_trampoline
_xamarin_static_trampoline:
	mov	x16, #0x1
	b	_xamarin_arm64_common_trampoline

.globl _xamarin_ctor_trampoline
_xamarin_ctor_trampoline:
	mov	x16, #0x2
	b _xamarin_arm64_common_trampoline

.globl _xamarin_fpret_single_trampoline
_xamarin_fpret_single_trampoline:
	mov	x16, #0x4
	b _xamarin_arm64_common_trampoline

.globl _xamarin_static_fpret_single_trampoline
_xamarin_static_fpret_single_trampoline:
	mov	x16, #0x5
	b _xamarin_arm64_common_trampoline

.globl _xamarin_fpret_double_trampoline
_xamarin_fpret_double_trampoline:
	mov	x16, #0x8
	b _xamarin_arm64_common_trampoline

.globl _xamarin_static_fpret_double_trampoline
_xamarin_static_fpret_double_trampoline:
	mov	x16, #0x9
	b _xamarin_arm64_common_trampoline

.globl _xamarin_stret_trampoline
_xamarin_stret_trampoline:
	mov	x16, #0x10
	b _xamarin_arm64_common_trampoline

.globl _xamarin_static_stret_trampoline
_xamarin_static_stret_trampoline:
	mov	x16, #0x11
	b _xamarin_arm64_common_trampoline

.globl _xamarin_longret_trampoline
_xamarin_longret_trampoline:
	mov	x16, #0x20
	b _xamarin_arm64_common_trampoline

.globl _xamarin_static_longret_trampoline
_xamarin_static_longret_trampoline:
	mov	x16, #0x21
	b _xamarin_arm64_common_trampoline

# etc...

#endif
