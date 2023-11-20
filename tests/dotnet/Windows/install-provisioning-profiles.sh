#!/bin/bash -eux

set -o pipefail
IFS=$'\n\t'

cd "$(dirname "${BASH_SOURCE[0]}")"

TOP=../../..
cd $TOP
TOP=$(pwd)

cd "$(dirname "${BASH_SOURCE[0]}")"


chmod +x "$TOP/../maccore/tools/install-qa-provisioning-profiles.sh"

# dos2unix
perl -pi -e 's/\r\n|\n|\r/\n/g' "$TOP/../maccore/tools/install-qa-provisioning-profiles.sh"
perl -pi -e 's/\r\n|\n|\r/\n/g' "$TOP/../maccore/tools/provisioning-profiles/provisionator.sh"

if test -z "${AUTH_TOKEN_GITHUB_COM:-}"; then
	AUTH_TOKEN_GITHUB_COM=${1:-}
	shift
	if test -z "$AUTH_TOKEN_GITHUB_COM"; then
		echo "AUTH_TOKEN_GITHUB_COM not provided, neither in the environment, nor as an argument"
		exit 1
	fi
fi

export AUTH_TOKEN_GITHUB_COM

"$TOP/../maccore/tools/install-qa-provisioning-profiles.sh" -v
