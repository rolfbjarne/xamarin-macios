#!/bin/bash -ex

if test -z "$BUILD_REVISION"; then
	echo "The variable BUILD_REVISION must be set to the hash to checkout."
	exit 1
fi

git fetch --all
git fetch --no-tags --progress origin +refs/pull/*:refs/remotes/origin/pr/*
git reset --hard "$BUILD_REVISION"

make reset
make git-clean-all
make print-versions
