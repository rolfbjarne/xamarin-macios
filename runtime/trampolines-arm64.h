#ifndef __TRAMPOLINES_ARM64_H__
#define __TRAMPOLINES_ARM64_H__

#ifdef __cplusplus
extern "C" {
#endif

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

	long double q0;
	long double q1;
	long double q2;
	long double q3;
	long double q4;
	long double q5;
	long double q6;
	long double q7;

	// computed values
	uint64_t *x;
	long double *q;
};

struct ParamIterator {
	struct CallState *state;
	int ngrn; // Next General-purpose Register Number
	int nsrn; // Next SIMD and Floating-point Register Number
	uint8_t *nsaa; // Next stacked argument address.
};

void xamarin_arch_trampoline (struct CallState *state);

#ifdef __cplusplus
} /* extern "C" */
#endif

#endif /* __TRAMPOLINES_ARM64_H__ */

