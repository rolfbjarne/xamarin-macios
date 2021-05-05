compare: test.arm64.o clean.arm64.o
	diff $^

test.arm64.s: test.mm Makefile
	clang -c $< -o$@ -arch arm64 -S -O -fverbose-asm

%.arm64.o: %.arm64.s
	clang -c $< -o$@ -arch arm64 -O

copy: test.arm64.s
	cp $< clean.arm64.s