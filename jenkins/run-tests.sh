#!/bin/bash -ex

cd "$(dirname "${BASH_SOURCE[0]}")"
cd ..
WORKSPACE=$(pwd)

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

TARGET=jenkins
PUBLISH_HTML_REPORT=
PRINT_HTML_REPORT_LINK=
while ! test -z $1; do
	case $1 in
		--target=*)
			TARGET=${1:9}
			shift
			;;
		--publish-html-report)
			PUBLISH_HTML_REPORT=1
			shift 1
			;;
		--print-html-report-link)
			PRINT_HTML_REPORT_LINK=1
			shift 1
			;;
		*)
			echo "Unknown argument: $1"
			exit 1
			;;
    esac
done

IS_PR=
if test -n "$ghprbPullId"; then
	IS_PR=1
	BRANCH_NAME="pr$ghprbPullId"
fi
if test -n "$PUBLISH_HTML_REPORT" -o -n "$PRINT_HTML_REPORT_LINK"; then
	if test -z "$BRANCH_NAME"; then
		echo "BRANCH_NAME is not set"
		exit 1
	fi
	if test -z "$BUILD_NUMBER"; then
		echo "BUILD_NUMBER is not set"
		exit 1
	fi
	P="jenkins/xamarin-macios/${BRANCH_NAME}/$(git log -1 --pretty=%H)/${BUILD_NUMBER}"

	echo "http://xamarin-storage/$P/jenkins-results/tests/index.html"
	if test -n "$PRINT_HTML_REPORT_LINK"; then
		# nothing else to do
		exit 0
	fi

	# Make sure the target directory exists
	ssh builder@xamarin-storage "mkdir -p /volume1/storage/$P"

	export TESTS_PERIODIC_COMMAND="--periodic-interval 10 --periodic-command rsync --periodic-command-arguments '-avz --chmod=+r -e ssh $WORKSPACE/jenkins-results builder@xamarin-storage:/volume1/storage/$P'"
fi

export BUILD_REVISION=jenkins

# Unlock
if ! test -f ~/Library/Keychains/builder.keychain-db; then
	echo "The 'builder' keychain is not available."
	exit 1
fi
security default-keychain -s builder.keychain
security list-keychains -s builder.keychain
echo "Unlock keychain"
security unlock-keychain -p `cat ~/.config/keychain`
echo "Increase keychain unlock timeout"
security set-keychain-settings -lut 7200
security -v find-identity builder.keychain

# Prevent dialogs from asking for permissions.
# http://stackoverflow.com/a/40039594/183422
security set-key-partition-list -S apple-tool:,apple: -s -k `cat ~/.config/keychain` builder.keychain

# clean mono keypairs (used in tests)
rm -rf ~/.config/.mono/keypairs/

# Run tests
RC=0
make -C tests $TARGET || RC=$?

# upload of the final html report
if test -n "$PUBLISH_HTML_REPORT"; then
	rsync -avz --chmod=+r -e ssh $WORKSPACE/jenkins-results builder@xamarin-storage:/volume1/storage/$P
fi

if [[ x$RC != x0 ]]; then
	exit $RC
fi

printf "✅ [Test run succeeded]($BUILD_URL/Test_Report/)\\n" >> $WORKSPACE/jenkins/pr-comments.md

if test -f $WORKSPACE/jenkins/failure-stamp; then
	echo "Something went wrong:"
	cat $WORKSPACE/jenkins/pr-comments.md
	exit 1
fi
