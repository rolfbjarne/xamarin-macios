TOP=../..

include $(TOP)/Make.config

bin/Debug/nunit-xml-to-html.exe: $(wildcard *.cs)
	msbuild
	touch $@

run:

test: bin/Debug/nunit-xml-to-html.exe
	mono --debug $< Test.xml > test-tmp.html
	curl -s -H "Content-Type: text/html; charset=utf-8" --data-binary @test-tmp.html https://validator.w3.org/nu/?out=text > $@.output
	@if ! grep --color=never "The document validates according to the specified schema(s)." $@.output; then cat $@.output; exit 1; fi