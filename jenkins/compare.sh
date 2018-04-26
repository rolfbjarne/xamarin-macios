#!/bin/bash -e

printf "⚠️ [Skipped comparing API and creating generator diff] ⚠\\n" >> $WORKSPACE/jenkins/pr-comments.md
exit 0

report_error ()
{
	printf "🔥 [Failed to compare API and create generator diff]($BUILD_URL/console) 🔥\\n" >> $WORKSPACE/jenkins/pr-comments.md
	touch $WORKSPACE/jenkins/failure-stamp
}
trap report_error ERR

cd $WORKSPACE

BASE=origin/pr/$ghprbPullId/merge
if ! git rev-parse $BASE >/dev/null 2>&1; then
	echo "Can't compare API and create generator diff because the pull request has conflicts that must be resolved first (the branch '$BASE' doesn't exist)."
	printf "🔥 [Failed to compare API and create generator diff because the pull request has conflicts that must be resolved first]($BUILD_URL/console) 🔥\\n" >> $WORKSPACE/jenkins/pr-comments.md
	exit 0
fi

./tools/compare-commits.sh --base=$BASE^1

mkdir -p jenkins-results/apicomparison

cp -R tools/comparison/apidiff/diff jenkins-results/apicomparison/
cp    tools/comparison/apidiff/*.html jenkins-results/apicomparison/
cp -R tools/comparison/generator-diff jenkins-results/generator-diff

printf "✅ [API Diff (from PR only)]($BUILD_URL/API_diff_(PR_only))\\n" >> $WORKSPACE/jenkins/pr-comments.md
printf "✅ [Generator Diff]($BUILD_URL/Generator_Diff)\\n" >> $WORKSPACE/jenkins/pr-comments.md
