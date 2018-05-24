#!/bin/bash -ex

cd "$(dirname "${BASH_SOURCE[0]}")/.."
WORKSPACE=$(pwd)

report_error ()
{
	printf "🔥 [Test run failed](%s/tests/index.html) 🔥\\n" "$URL_PREFIX" >> "$WORKSPACE/jenkins/pr-comments.md"

	if test -f "$WORKSPACE/tests/TestSummary.md"; then
		printf "\\n" >> "$WORKSPACE/jenkins/pr-comments.md"
		cat "$WORKSPACE/tests/TestSummary.md" >> "$WORKSPACE/jenkins/pr-comments.md"
	fi

	touch "$WORKSPACE/jenkins/failure-stamp"
}
trap report_error ERR

TARGET=jenkins
while ! test -z "$1"; do
	case "$1" in
		--target=*)
			TARGET="${1:9}"
			shift
			;;
		*)
			echo "Unknown argument: $1"
			exit 1
			;;
    esac
done

PUBLISH_OUTPUT=$(./jenkins/publish-results.sh)
URL_PREFIX=$(echo "$PUBLISH_OUTPUT" | grep "^Url Prefix: " | sed 's/^Url Prefix: //')
TESTS_PERIODIC_COMMAND=$(echo "$PUBLISH_OUTPUT" | grep "^Periodic Command: " | sed 's/^Periodic Command: //')
export TESTS_PERIODIC_COMMAND


export BUILD_REVISION=jenkins

# Unlock
KEYCHAIN=xamarin-macios
if ! test -f ~/Library/Keychains/$KEYCHAIN.keychain-db; then
	echo "The '$KEYCHAIN' keychain is not available."
	exit 1
fi
security default-keychain -s $KEYCHAIN.keychain
security list-keychains -s $KEYCHAIN.keychain
echo "Unlock keychain"
security unlock-keychain -p "$(cat ~/.config/$KEYCHAIN-keychain)"
echo "Increase keychain unlock timeout"
security set-keychain-settings -lut 7200
security -v find-identity $KEYCHAIN.keychain

# Prevent dialogs from asking for permissions.
# http://stackoverflow.com/a/40039594/183422
# Discard output since there can be a *lot* of it.
security set-key-partition-list -S apple-tool:,apple: -s -k "$(cat ~/.config/$KEYCHAIN-keychain)" $KEYCHAIN.keychain >/dev/null 2>&1

# clean mono keypairs (used in tests)
rm -rf ~/.config/.mono/keypairs/

# Run tests
RC=0
make -C tests "$TARGET" || RC=$?

# upload of the final html report
./jenkins/publish-results.sh

if [[ x$RC != x0 ]]; then
	report_error
	exit $RC
fi

printf "✅ [Test run succeeded](%s/tests/index.html)\\n" "$URL_PREFIX" >> "$WORKSPACE/jenkins/pr-comments.md"

if test -f "$WORKSPACE/jenkins/failure-stamp"; then
	echo "Something went wrong:"
	cat "$WORKSPACE/jenkins/pr-comments.md"
	exit 1
fi
