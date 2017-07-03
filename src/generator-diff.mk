.generated_copy = rsync -qavz --exclude=*.dll --exclude=*.exe --exclude=*.mdb --exclude=*.pdb '--exclude=*~.pmcs*' build generator-reference

generator-reference:
	rm -rf $@
	rm -rf src/build
	$(MAKE) all -j -d
	$(.generated_copy)
	cd $@ && git init . && git add --all && git commit -m init

generator-diff:
	if [ ! -d generator-reference/.git ]; then \
		echo "No generator reference built. Run 'make generator-reference' first."; \
		exit 1; \
	fi
	rm -rf generator-reference/*
	git clean -fxdq -e generator-reference
	$(MAKE) all -j -d
	$(.generated_copy)
	cd generator-reference && git diff . ':(exclude)**/*.pdb' ':(exclude)**/*.dll'

.PHONY: generator-reference generator-diff
