#!/bin/bash -e

cd "$(dirname "${BASH_SOURCE[0]}")/.."
WORKSPACE=$(pwd)

report_error ()
{
	printf "🔥 [Failed to compare API and create generator diff](%s/console) 🔥\\n" "$BUILD_URL" >> "$WORKSPACE/jenkins/pr-comments.md"
	touch "$WORKSPACE/jenkins/failure-stamp"
	exit 0
}
trap report_error ERR

# SC2154: ghprbPullId is referenced but not assigned.
# shellcheck disable=SC2154
if test -n "$ghprbPullId"; then
	if ./jenkins/fetch-pr-labels.sh --check=skip-api-comparison; then
		printf "❎ Skipped API comparison because the PR has the label 'skip-api-comparison'\\n" >> "$WORKSPACE/jenkins/pr-comments.md"
		exit 0
	fi
fi

if test -z "$ghprbPullId"; then
	BASE=HEAD
else
	BASE="origin/pr/$ghprbPullId/merge"
fi

if ! git rev-parse "$BASE" >/dev/null 2>&1; then
	echo "Can't compare API and create generator diff because the pull request has conflicts that must be resolved first (the branch '$BASE' doesn't exist)."
	printf "🔥 [Failed to compare API and create generator diff because the pull request has conflicts that must be resolved first](%s/console) 🔥\\n" "$BUILD_URL" >> "$WORKSPACE/jenkins/pr-comments.md"
	exit 0
fi

./tools/compare-commits.sh --base="$BASE^1"

mkdir -p jenkins-results/apicomparison

cp -R tools/comparison/apidiff/diff jenkins-results/apicomparison/
cp    tools/comparison/apidiff/*.html jenkins-results/apicomparison/
cp -R tools/comparison/generator-diff jenkins-results/generator-diff

if [[ "x$1" == "x--publish" ]]; then
	URL_PREFIX=$(./jenkins/publish-results.sh | grep "^Url Prefix: " | sed 's/^Url Prefix: //')
	URL_API="$URL_PREFIX/apicomparison/index.html"
	URL_GENERATOR="$URL_PREFIX/generator-diff/index.html"
else
	URL_API="$BUILD_URL/API_20diff_20_28PR_20only_29"
	URL_GENERATOR="$BUILD_URL/Generator_20Diff"
fi

printf "✅ [API Diff (from PR only)](%s)\\n" "$URL_API" >> "$WORKSPACE/jenkins/pr-comments.md"
printf "✅ [Generator Diff](%s)\\n" "$URL_GENERATOR" >> "$WORKSPACE/jenkins/pr-comments.md"
