#!/bin/bash -eux

cd "$(dirname "${BASH_SOURCE[0]}")"

exec ./rolf.sh --skip-clean
