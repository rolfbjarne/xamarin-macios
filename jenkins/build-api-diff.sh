#!/bin/bash -e

cd "$(dirname "${BASH_SOURCE[0]}")/.."
WORKSPACE=$(pwd)

report_error ()
{
	printf "🔥 [Failed to create API Diff](%s/console) 🔥\\n" "$BUILD_URL" >> "$WORKSPACE/jenkins/pr-comments.md"
}
trap report_error ERR

export BUILD_REVISION=jenkins
make -j8 -C tools/apidiff jenkins-api-diff

URL_PREFIX=$(./jenkins/publish-results.sh | grep "^Url Prefix: " | sed 's/^Url Prefix: //')

printf "✅ [API Diff (from stable)](%s/api-diff/index.html)\\n" "$URL_PREFIX" >> "$WORKSPACE/jenkins/pr-comments.md"
