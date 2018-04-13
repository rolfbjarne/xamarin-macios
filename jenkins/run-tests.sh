#!/bin/bash -ex

cd "$(dirname "${BASH_SOURCE[0]}")"
cd ..

report_error ()
{
	printf "🔥 [Test run failed]($BUILD_URL/Test_Report/) 🔥\\n" >> $WORKSPACE/jenkins/pr-comments.md

	if test -f $WORKSPACE/tests/TestSummary.md; then
		printf "\\n" >> $WORKSPACE/jenkins/pr-comments.md
		cat $WORKSPACE/tests/TestSummary.md >> $WORKSPACE/jenkins/pr-comments.md
	fi

	touch $WORKSPACE/jenkins/failure-stamp
}
trap report_error ERR

export BUILD_REVISION=jenkins
cd $WORKSPACE
# Unlock
security default-keychain -s builder.keychain
security list-keychains -s builder.keychain
echo "Unlock keychain"
security unlock-keychain -p `cat ~/.config/keychain`
echo "Increase keychain unlock timeout"
security set-keychain-settings -lut 7200
security -v find-identity builder.keychain
# clean mono keypairs (used in tests)
rm -rf ~/.config/.mono/keypairs/

# Run tests
TARGET=$1
if test -z $TARGET; then
	TARGET=jenkins
fi
make -C tests $TARGET

printf "✅ [Test run succeeded]($BUILD_URL/Test_Report/)\\n" >> $WORKSPACE/jenkins/pr-comments.md

if test -f $WORKSPACE/jenkins/failure-stamp; then
	echo "Something went wrong:"
	cat $WORKSPACE/jenkins/pr-comments.md
	exit 1
fi
