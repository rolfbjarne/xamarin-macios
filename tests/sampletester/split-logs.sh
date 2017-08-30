#!/bin/bash -ex

#
# the VSTS log is one giant file
# this script splits the giant log into one file per test, based on the following line:
# 2017-08-22T14:42:18.6015150Z => <test name>
#

if test -z "$1"; then
	echo "Need to pass the log file to process."
	exit 1
fi

LOG=$1

mkdir -p split
if [[ "$LOG" == *.zip ]]; then
	unzip -p "$LOG" 1_Build.txt | csplit -k -n 4 -f split/log - '/ => /' '{9999}'
else
	csplit -k -n 4 -f split/log "$LOG" '/ => /' '{9999}'
fi
