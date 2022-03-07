#!/bin/bash -eux

make git-clean-all
mai
make run-unit-tests -C tests/dotnet
make -C tests test-ios-tasks
