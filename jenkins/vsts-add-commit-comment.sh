#!/bin/bash -ex

cd "$(dirname "${BASH_SOURCE[0]}")/.."

TOKEN=
START=
while ! test -z "$1"; do
	case "$1" in
		--token=*)
			TOKEN="${1:8}"
			shift
			;;
		--token)
			TOKEN="$2"
			shift 2
			;;
		--start)
			START=1
			shift
			;;
		*)
			echo "Unknown argument: $1"
			exit 1
			;;
    esac
done

if test -z "$TOKEN"; then
	echo "The GitHub token is required (--token=<TOKEN>)"
	exit 1
fi

P=$(cat tmp.p)

# Add a GitHub comment to the commit we're testing
MESSAGE_FILE=commit-message.txt
cleanup ()
{
	rm -f "$MESSAGE_FILE"
}
trap cleanup ERR
trap cleanup EXIT

if test -n "$START"; then
	printf "Started device tests\\n\\n" > "$MESSAGE_FILE"
else
	printf "Completed device tests\\n\\n" > "$MESSAGE_FILE"
fi
printf "[Html Report](http://xamarin-storage/%s/jenkins-results/tests/index.html)\\n" "$P" >> "$MESSAGE_FILE"
printf "[VSTS](%s)\\n\\n" "${SYSTEM_TEAMFOUNDATIONCOLLECTIONURI}${SYSTEM_TEAMPROJECT}/_build/index?buildId=${BUILD_BUILDID}" >> "$MESSAGE_FILE"

if test -z "$START"; then
	FILE=$PWD/tests/TestSummary.md
	if ! test -f "$FILE"; then
		printf "Tests failed catastrophically (no summary found)\\n" >> "$MESSAGE_FILE"
	else
		cat "$FILE" >> "$MESSAGE_FILE"
	fi
fi

./jenkins/add-commit-comment.sh --token="$TOKEN" --file="$MESSAGE_FILE" "--hash=$BUILD_REVISION"
