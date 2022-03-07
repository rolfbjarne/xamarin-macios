#!/bin/bash -eux

make git-clean-all
maiq
make -C tests test-ios-tasks
make run-unit-tests -C tests/dotnet
