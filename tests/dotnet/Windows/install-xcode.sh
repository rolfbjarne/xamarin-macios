#!/bin/bash -eux

set -o pipefail
IFS=$'\n\t'

cd "$(dirname "${BASH_SOURCE[0]}")"

TOP=../../..
cd $TOP
TOP=$(pwd)

cd "$(dirname "${BASH_SOURCE[0]}")"

chmod +x "$TOP/create-make-config.sh"

make -C "$TOP/tools/devops" provision-xcode.csx

cat "$TOP/tools/devops/provision-xcode.csx" || true

chmod +x "$TOP/../maccore/tools/devops/provisionator.sh"

# dos2unix
perl -pi -e 's/\r\n|\n|\r/\n/g' "$TOP/../maccore/tools/devops/provisionator.sh"

if test -z "${AUTH_TOKEN_GITHUB_COM:-}"; then
	AUTH_TOKEN_GITHUB_COM=${1:-}
	shift
	if test -z "$AUTH_TOKEN_GITHUB_COM"; then
		echo "AUTH_TOKEN_GITHUB_COM not provided, neither in the environment, nor as an argument"
		exit 1
	fi
fi

if test -z "${BUILD_SOURCEVERSION:-}"; then
	BUILD_SOURCEVERSION=${1:-}
	shift
	if test -z "$BUILD_SOURCEVERSION"; then
		echo "BUILD_SOURCEVERSION not provided, neither in the environment, nor as an argument"
		exit 1
	fi
fi

export AUTH_TOKEN_GITHUB_COM
export BUILD_SOURCEVERSION

"$TOP/../maccore/tools/devops/provisionator.sh" "$TOP/tools/devops/provision-xcode.csx"