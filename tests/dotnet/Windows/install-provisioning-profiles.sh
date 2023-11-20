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

"$TOP/../maccore/tools/install-qa-provisioning-profiles.sh" -v
