
#if defined(__arm64__)

#include <stdint.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>

#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>

#include "trampolines-internal.h"
#include "xamarin/runtime.h"
#include "runtime-internal.h"
#include "trampolines-arm64.h"

#define TRACE
#ifdef TRACE
#define LOGZ(...) fprintf (stderr, __VA_ARGS__);
#else
#define LOGZ(...) ;
#endif

/*
 * https://developer.apple.com/library/archive/documentation/Xcode/Conceptual/iPhoneOSABIReference/Articles/ARM64FunctionCallingConventions.html
 *
 * Standard arm64 calling convention:
 * Input:
 *   x0 - x7 (x8 too in some cases)
 *   q0 - q7 (simd/floating point)
 * Output:
 *   same as input
 *
 */

static guint32
create_mt_exception (char *msg)
{
	MonoException *ex = xamarin_create_exception (msg);
	xamarin_free (msg);
	return mono_gchandle_new ((MonoObject *) ex, FALSE);
}

static size_t
get_primitive_size (char type)
{
	switch (type) {
	case _C_ID: return sizeof (id);
	case _C_CLASS: return sizeof (Class);
	case _C_SEL: return sizeof (SEL);
	case _C_CHR: return sizeof (char);
	case _C_UCHR: return sizeof (unsigned char);
	case _C_SHT: return sizeof (short);
	case _C_USHT: return sizeof (unsigned short);
	case _C_INT: return sizeof (int);
	case _C_UINT: return sizeof (unsigned int);
	case _C_LNG: return sizeof (long);
	case _C_ULNG: return sizeof (unsigned long);
	case _C_LNG_LNG: return sizeof (long long);
	case _C_ULNG_LNG: return sizeof (unsigned long long);
	case _C_FLT: return sizeof (float);
	case _C_DBL: return sizeof (double);
	case _C_BOOL: return sizeof (BOOL);
	case _C_VOID: return 0;
	case _C_PTR: return sizeof (void *);
	case _C_CHARPTR: return sizeof (char *);
	default:
		return 0;
	}
}

#ifdef TRACE
static void
dump_state (struct CallState *state, id self, SEL sel, const char *prefix)
{
	fprintf (stderr, "%stype: %llu self: %p SEL: %s sp: 0x%llx x0: 0x%llx x1: 0x%llx x2: 0x%llx x3: 0x%llx x4: 0x%llx x5: 0x%llx x6: 0x%llx x7: 0x%llx x8: 0x%llx -- q0: %Lf q1: %Lf q2: %Lf q3: %Lf q4: %Lf q5: %Lf q6: %Lf q7: %Lf\n",
		prefix, state->type, self, sel_getName (sel), state->sp, state->x0, state->x1, state->x2, state->x3, state->x4, state->x5, state->x6, state->x7, state->x8,
		state->q0.d, state->q1.d, state->q2.d, state->q3.d, state->q4.d, state->q5.d, state->q6.d, state->q7.d);
}
#else
#define dump_state(...)
#endif

//const char* registers[] =  { "rdi", "rsi", "rdx", "rcx", "r8", "r9", "err"  };

static const char *
skip_type_name (const char *ptr)
{
	const char *t = ptr;
	do {
		if (*t == '=') {
			t++;
			return t;
		}
		t++;
	} while (*t != 0);

	return ptr;
}

static int
param_read_primitive (struct ParamIterator *it, const char **type_ptr, void *target, size_t total_size, guint32 *exception_gchandle)
{
	// COOP: does not access managed memory: any mode.
	char type = **type_ptr;

	switch (type) {
	case _C_FLT: {
		if (it->nsrn < 8) {
			if (target != NULL) {
				*(float *) target = *(float *) &it->q [it->nsrn];
				LOGZ ("     reading float at q%i into %p: %f\n", it->nsrn, target, *(float *) target);
			}
			it->nsrn++;
		} else {
			if (target != NULL) {
				*(float *) target = *(float *) it->nsaa;
				LOGZ ("     reading float at stack %p into %p: %f\n", it->nsaa, target, *(float *) target);
			}
			it->nsaa += 4;
		}
		return 4;
	}
	case _C_DBL: {
		if (it->nsrn < 8) {
			if (target != NULL) {
				*(double *) target = *(double *) &it->q [it->nsrn];
				LOGZ ("     reading double at q%i into %p: %f\n", it->nsrn, target, *(double *) target);
			}
			it->nsrn++;
		} else {
			if (target != NULL) {
				*(double *) target = *(double *) it->nsaa;
				LOGZ ("     reading dobule at stack %p into %p: %f\n", it->nsaa, target, *(double *) target);
			}
			it->nsaa += 8;
		}
		return 8;
	}
	case _C_PTR: { // ^
		// Need to skip what's pointed to
		int nesting = 0;
		do {
			(*type_ptr)++;
			if (**type_ptr == '{')
				nesting++;
			else if (**type_ptr == '}')
				nesting--;
		} while (**type_ptr != 0 && nesting > 0);
		// fallthrough
	}
	default: {
		size_t size = get_primitive_size (type);

		if (size == 0)
			return 0;

		uint8_t *ptr;
		bool read_register = it->ngrn < 8;

		if (read_register) {
			ptr = (uint8_t *) &it->x [it->ngrn];
			if (target != NULL) {
				LOGZ ("     reading primitive of size %i from x%i into %p: ",
					(int) size, it->ngrn, target);
			}
			it->ngrn++;
		} else {
			ptr = (uint8_t *) it->nsaa;
			if (target != NULL) {
				LOGZ ("     reading primitive of size %i from %p into %p: ",
					(int) size, ptr, target);
			}
			it->nsaa += size;
		}

		if (target == NULL)
			return size;

		switch (size) {
		case 8:
			*(uint64_t *) target = *(uint64_t *) ptr;
			LOGZ ("0x%llx = %llu\n", * (uint64_t *) target, * (uint64_t *) target);
			break;
		case 4:
			*(uint32_t *) target = *(uint32_t *) ptr;
			LOGZ ("0x%x = %u\n", * (uint32_t *) target, * (uint32_t *) target);
			break;
		case 2:
			*(uint16_t *) target = *(uint16_t *) ptr;
			LOGZ ("0x%x = %u\n", (int) * (uint32_t *) target, (int) * (uint32_t *) target);
			break;
		case 1:
			*(uint8_t *) target = *(uint8_t *) ptr;
			LOGZ ("0x%x = %u = '%c'\n", (int) * (uint8_t *) target, (int) * (uint8_t *) target, (char) * (uint8_t *) target);
			break;
		default:
			*exception_gchandle = create_mt_exception (xamarin_strdup_printf ("Xamarin.iOS: Cannot marshal parameter type %c (size: %i): invalid size.\n", type, (int) size));
			return 0;
		}

		return size;
	}
	}
}

static void
param_iter_next (enum IteratorAction action, void *context, const char *type, size_t size, void *target, guint32 *exception_gchandle)
{
	// COOP: does not access managed memory: any mode.
	struct ParamIterator *it = (struct ParamIterator *) context;

	if (action == IteratorStart) {
		it->ngrn = 2; // we already have two arguments: self + SEL
		it->nsrn = 0;
		it->nsaa = (uint8_t *) it->state->sp;
		it->x = &it->state->x0;
		it->q = &it->state->q0;
		LOGZ ("    initialized parameter iterator. next register: %i next fp register: %i next stack pointer: %p\n", it->ngrn, it->nsrn, it->nsaa);
		return;
	} else if (action == IteratorEnd) {
		return;
	}

	const char *t = type;
	uint8_t *targ = (uint8_t *) target;

	// target must be at least pointer sized, and we need to zero it out first.
	if (target != NULL)
		*(uint64_t *) target = 0;

	if (size > 16) {
		// passed on the stack
		if (target != NULL)
			memcpy (target, it->nsaa, size);
		// increment stack pointer
		it->nsaa += size;
		return;
	}

	// passed in registers (and on the stack if not enough registers)
	do {
		// skip over any struct names
		if (*t == '{') {
			do {
				t++;
				if (*t == '=') {
					t++;
					break;
				}
			} while (*t != 0);
		}

		if (*t == 0)
			break;

		int c = param_read_primitive (it, &t, targ, size, exception_gchandle);
		if (*exception_gchandle != 0)
			return;
		if (targ != NULL)
			targ += c;
	} while (*++t);
}

static void
marshal_return_value (void *context, const char *type, size_t size, void *vvalue, MonoType *mtype, bool retain, MonoMethod *method, MethodDescription *desc, guint32 *exception_gchandle)
{
	// COOP: accessing managed memory (as input), so must be in unsafe mode.
	MONO_ASSERT_GC_UNSAFE;

	MonoObject *value = (MonoObject *) vvalue;
	struct ParamIterator *it = (struct ParamIterator *) context;

	LOGZ ("     marshalling return value %p as %s\n", value, type);

	switch (type [0]) {
	case _C_FLT:
		// single floating point return value
		*(float*)&it->state->q0 = *(float *) mono_object_unbox (value);
		break;
	case _C_DBL:
		// double floating point return value
		*(double*)&it->state->q0 = *(double *) mono_object_unbox (value);
		break;
	case _C_STRUCT_B:
		/*
		 * Structures, this is ugly :|
		 *
		 * Fortunately we don't have to implement support for the full x86_64 ABI, since we don't need
		 * to support all the types. We only have to implement support for two classes of types:
		 * 
		 *   INTEGER: all variants of ints/uints/pointers. IOW anything that fits into a pointer-sized variable and isn't a floating point value.
		 *   FLOAT:   float, double.
		 * 
		 * To make things more interesting, struct fields are joined together until the reach 64-bit size,
		 * so for instance two int fields will be stuffed into one 64-bit INTEGER register. Same for floats,
		 * two floats will be put into one 64-bit FLOAT register. If there's a mix of floats
		 * and ints the ints win, so a float+int will be put into a 64-bit INTEGER register.
		 * There are also two registers available for each class:
		 * 
		 *   INTEGER: %rax and %rdi
		 *   FLOAT: %xmm0 and %xmm1
		 *
		 * Up to 2 registers (either both INTEGER, both FLOAT or a mix) can be used. This means that 
		 * structs up to 16 bytes can be (and are) passed in registers.
		 * 
		 * A few examples (d=double f=float i=int c=char):
		 * 
		 *	M(d);     // xmm0
		 *	M(dd);    // xmm0 + xmm1
		 *	M(ddd);   // stack
		 *	M(dddd);  // stack
		 *	M(i);     // eax
		 *	M(id);    // eax + xmm0
		 *	M(di);    // xmm0 + eax
		 *	M(ddi);   // stack
		 *	M(ii);    // rax
		 *	M(iii);   // rax + edx
		 *	M(iiii);  // rax + rdx
		 *	M(iiiii); // stack
		 *	M(idi);   // stack
		 *	M(iid);   // rax + xmm0
		 *	M(ll);    // rax + rdx
		 *	M(lll);   // stack
		 *	M(cccc);  // eax
		 *	M(ffff);  // xmm0 + xmm1
		 *  M(if_);   // rax
		 *  M(f);     // xmm0
		 *  M(iff);   // rax + xmm0 (if: rax, f: xmm0)
		 *  M(iiff);  // rax + xmm0
		 *  M(fi);    // rax
		 *
		 */

		if ((it->state->type & Tramp_Stret) == Tramp_Stret) {
			memcpy ((void *) it->state->x8, mono_object_unbox (value), size);
			break;
		}

		if (size > 8 && size <= 16) {
			*exception_gchandle = create_mt_exception (xamarin_strdup_printf ("Xamarin.iOS: Cannot marshal struct return type %s (size: %i)\n", type, (int) size));
			return;
			// uint64_t *i_ptr = &it->state->rax;
			// uint64_t *f_ptr = (uint64_t *) &it->state->xmm0;
			// uint64_t *reg_ptr = f_ptr;

			// void *unboxed = mono_object_unbox (value);

			// // read the struct into 2 64bit values.
			// uint64_t v[2];
			// v[0] = *(uint64_t *) unboxed;
			// // read as much as we can of the second value
			// unboxed = 1 + (uint64_t *) unboxed;
			// if (size == 16) {
			// 	v[1] = *(uint64_t *) unboxed;
			// } else if (size == 12) {
			// 	v[1] = *(uint32_t *) unboxed;
			// } else if (size == 10) {
			// 	v[1] = *(uint16_t *) unboxed;
			// } else if (size == 9) {
			// 	v[1] = *(uint8_t *) unboxed;
			// } else {
			// 	v[1] = 0; // theoretically impossible, but it silences static analysis, and if the real world proves the theory wrong, then we still get consistent behavior.
			// }
			// // figure out where to put the values.
			// const char *t = skip_type_name (type);
			// int acc = 0;
			// int stores = 0;

			// while (true) {
			// 	if (*t == 0) {
			// 		if (stores >= 2 && acc > 0) {
			// 			*exception_gchandle = create_mt_exception (xamarin_strdup_printf ("Xamarin.iOS: Cannot marshal return type %s (size: %i): more than 2 64-bit values found.\n", type, (int) size));
			// 			return;
			// 		} else if (stores < 2) {
			// 			*reg_ptr = v [stores];
			// 		}
			// 		break;
			// 	}
					
			// 	bool is_float = *t == _C_FLT || *t == _C_DBL;
			// 	int s = get_primitive_size (*t);

			// 	t++;

			// 	if (s == 0)
			// 		continue;

			// 	if (acc + s == 8) {
			// 		// We have exactly the amount of data we need for one register.
			// 		// Store the value and start over again.
			// 		reg_ptr = is_float ? reg_ptr : i_ptr;
			// 		acc = 0;
			// 	} else if (acc + s < 8) {
			// 		// We haven't filled up a register yet.
			// 		// Continue iterating.
			// 		reg_ptr = is_float ? reg_ptr : i_ptr;
			// 		acc += s;
			// 		// find next.
			// 		continue;
			// 	} else {
			// 		// We've overflown. Store the value and start over again,
			// 		// setting the current total to the size of the current type.
			// 		acc = s;
			// 	}

			// 	if (stores >= 2) {
			// 		*exception_gchandle = create_mt_exception (xamarin_strdup_printf ("Xamarin.iOS: Cannot marshal return type %s (size: %i): more than 2 64-bit values found.\n", type, (int) size));
			// 		return;
			// 	}

			// 	// Write the current value to the correct register.
			// 	*reg_ptr = v [stores++];
			// 	if (reg_ptr == f_ptr) {
			// 		f_ptr += 2; // xmm0/xmm1 are 128-bit wide (long double).
			// 	} else {
			// 		i_ptr++;
			// 	}

			// 	if (acc == s) {
			// 		// Overflown codepath from above.
			// 		reg_ptr = is_float ? f_ptr : i_ptr;
			// 	} else {
			// 		reg_ptr = f_ptr;
			// 	}

			// };
		} else if (size == 8) {
			type = skip_type_name (type);
			if (!strncmp (type, "ff}", 3) || !strncmp (type, "d}", 2)) {
				// the only two fully fp combinations are: ff and d
				memcpy (&it->state->q0, mono_object_unbox (value), 8);
			} else {
				// all other combinations would contain at least one INTEGER-class type.
				it->state->x8 = *(uint64_t *) mono_object_unbox (value);
			}
		} else if (size < 8) {
			memcpy (&it->state->x8, mono_object_unbox (value), size);
		} else {
			*exception_gchandle = create_mt_exception (xamarin_strdup_printf ("Xamarin.iOS: Cannot marshal struct return type %s (size: %i)\n", type, (int) size));
			return;
		}
		break;
	// For primitive types we get a pointer to the actual value
	case _C_BOOL: // signed char
	case _C_CHR:
	case _C_UCHR:
		it->state->x0 = *(uint8_t *) mono_object_unbox (value);
		break;
	case _C_SHT:
	case _C_USHT:
		it->state->x0 = *(uint16_t *) mono_object_unbox (value);
		break;
	case _C_INT:
	case _C_UINT:
		it->state->x0 = *(uint32_t *) mono_object_unbox (value);
		break;
	case _C_LNG:
	case _C_ULNG:
	case _C_LNG_LNG:
	case _C_ULNG_LNG:
		it->state->x0 = *(uint64_t *) mono_object_unbox (value);
		break;
	
	// For pointer types we get the value itself.
	case _C_CLASS:
	case _C_SEL:
	case _C_ID:
	case _C_CHARPTR:
	case _C_PTR:
		if (value == NULL) {
			it->state->x0 = 0;
			break;
		}

		it->state->x0 = (uint64_t) xamarin_marshal_return_value (mtype, type, value, retain, method, desc, exception_gchandle);
		break;
	case _C_VOID:
		break;
	case '|': // direct pointer value
	default:
		if (size == 8) {
			it->state->x0 = (uint64_t) value;
		} else {
			*exception_gchandle = create_mt_exception (xamarin_strdup_printf ("Xamarin.iOS: Cannot marshal return type %s (size: %i)\n", type, (int) size));
		}
		break;
	}
}

void
xamarin_arch_trampoline (struct CallState *state)
{
	// COOP: called from ObjC, and does not access managed memory.
	MONO_ASSERT_GC_SAFE;

	id self = (id) state->x0;
	SEL sel = (SEL) state->x1;
	dump_state (state, self, sel, "BEGIN: ");
	struct ParamIterator iter;
	iter.state = state;
	xamarin_invoke_trampoline ((enum TrampolineType) state->type, self, sel, param_iter_next, marshal_return_value, &iter);
	dump_state (state, self, sel, "END: ");
}

#endif /* __x86_64__ */