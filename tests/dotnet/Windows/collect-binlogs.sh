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
	rm -f ~/remote_build_testing/windows-remote-logs.zip
	zip -9r ~/remote_build_testing/windows-remote-logs.zip -@ < files.txt
else
	touch ~/remote_build_testing/windows-remote-logs.zip
	echo "No binlogs found"
fi

if ls ~/Library/Logs/Xamarin.Messaging-* >& /dev/null ; then
	zip -9r ~/remote_build_testing/windows-remote-logs.zip ~/Library/Logs/Xamarin.Messaging-*
else
	echo "No logs in ~/Library/Logs/Xamarin.Messaging"
fi
