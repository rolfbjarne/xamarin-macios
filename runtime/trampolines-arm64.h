#ifndef __TRAMPOLINES_ARM64_H__
#define __TRAMPOLINES_ARM64_H__

#ifdef __cplusplus
extern "C" {
#endif

struct BigDouble {
	union {
		__int128 bits;
		long double d;
	};
};

struct CallState {
	uint64_t type;
	uint64_t sp;
	uint64_t x0;
	uint64_t x1;
	uint64_t x2;
	uint64_t x3;
	uint64_t x4;
	uint64_t x5;
	uint64_t x6;
	uint64_t x7;
	uint64_t x8;

	struct BigDouble q0;
	struct BigDouble q1;
	struct BigDouble q2;
	struct BigDouble q3;
	struct BigDouble q4;
	struct BigDouble q5;
	struct BigDouble q6;
	struct BigDouble q7;
};

struct ParamIterator {
	struct CallState *state;
	int ngrn; // Next General-purpose Register Number
	int nsrn; // Next SIMD and Floating-point Register Number
	uint8_t *nsaa; // Next stacked argument address.

	// computed values
	uint64_t *x;
	struct BigDouble *q;
};

void xamarin_arch_trampoline (struct CallState *state);

#ifdef __cplusplus
} /* extern "C" */
#endif

#endif /* __TRAMPOLINES_ARM64_H__ */

