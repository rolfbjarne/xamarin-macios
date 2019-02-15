#
# store all parameters in a consistent way, and send it off to managed code.
# we need to store:
#   x0-x9, x16
#   q0-q7
#   x29, x30 (for the stack frame)
#   an unknown amount of stack space, but we can pass a pointer to the start of this area.
# in total we need 11*64bits registers + 8*128bits registers + 2*64bits register = 232 bytes.
# the 128 bit registers need to be 16-byte aligned, so there's a register-sized padding before the qX registers, thus total 240 bytes.
#
# upon return we may need to write to:
#   x0, x1
#   q0, q1, q2, q3
#

#if __arm64__

.subsections_via_symbols
.text
.align 2
_xamarin_arm64_common_trampoline:
	mov x9, sp ;#Save sp to a temporary register
	sub sp, sp, #240 ;# allocate 224 bytes from the stack (stack must always be 16-byte aligned) + 16 bytes for the stack frame

	# Create stack frame
	stp x29, x30, [sp, #0x00]
	mov x29, sp

	stp x16, x9, [sp, #0x10]
	stp  x0, x1, [sp, #0x20]
	stp  x2, x3, [sp, #0x30]
	stp  x4, x5, [sp, #0x40]
	stp  x6, x7, [sp, #0x50]
	str  x8,     [sp, #0x60]

	stp  q0, q1, [sp, #0x70]
	stp  q2, q3, [sp, #0x90]
	stp  q4, q5, [sp, #0xb0]
	stp  q6, q7, [sp, #0xd0]

	add x0, sp, #0x10
	bl	_xamarin_arch_trampoline

	# get return value(s)

	ldp x16, x9, [sp, #0x10]
	ldp  x0, x1, [sp, #0x20]
	ldp  x2, x3, [sp, #0x30]
	ldp  x4, x5, [sp, #0x40]
	ldp  x6, x7, [sp, #0x50]
	ldr  x8,     [sp, #0x60]

	ldp  q0, q1, [sp, #0x70]
	ldp  q2, q3, [sp, #0x90]
	ldp  q4, q5, [sp, #0xb0]
	ldp  q6, q7, [sp, #0xd0]

	ldp	x29, x30, [sp, #0x00]
	add sp, sp, #240 ;# deallocate 224 bytes from the stack + 16 bytes for stack frame

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
