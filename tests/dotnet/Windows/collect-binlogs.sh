#!/bin/bash -eux

set -o pipefail
#IFS=$'\n\t'

cd "$(dirname "${BASH_SOURCE[0]}")"

DIRS=("$1" "$2")
rm -f files.txt
for dir in "$@"; do
	echo $dir
	for file in $(git --git-dir $dir/.git ls-files -o '*.binlog'); do
		echo "$dir/$file" >> files.txt
	done
done

if test -f files.txt; then
	mkdir -p ~/remote_build_testing/
	rm -f ~/remote_build_testing/windows-remote-binlogs.zip
	zip -9r ~/remote_build_testing/windows-remote-binlogs.zip -@ < files.txt
else
	touch ~/remote_build_testing/windows-remote-binlogs.zip
	echo "No binlogs found"
fi

