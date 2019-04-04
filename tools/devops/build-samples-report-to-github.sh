#!/bin/bash -ex

env | sort

STEPS="$*"

EMOJII="✅"
GH_STATE=success
FILE=commit-comment.md
AZURE_BUILD_URL="${SYSTEM_COLLECTIONURI}/${SYSTEM_TEAMPROJECT}/_build/results?buildId=${BUILD_BUILDID}"

for STEP in $STEPS; do
  STEPNAME=JOBRESULT$(echo "$STEP" | tr '[:lower:]' '[:upper:]' | sed -e 's/|//' -e 's/-//')
  STEPSTATUS=${!STEPNAME}
  if [[ "$STEPSTATUS" == "Succeeded" ]]; then
    STEPEMOJII="✅"
  else
    STEPEMOJII="❌"
    EMOJII="❌"
    GH_STATE=failure
  fi
  echo "* $STEPEMOJII $STEPNAME: $STEPSTATUS" >> "$FILE"
done

echo "$EMOJII Status for '$BUILD_DEFINITIONNAME': $GH_STATE. [View results]($AZURE_BUILD_URL)\n" | cat - "$FILE" > "$FILE.tmp"
mv "$FILE.tmp" "$FILE"

./jenkins/add-commit-comment.sh "--token=$(github-pat)" "--hash=$(Build.SourceVersion)" "--file=$FILE"
./jenkins/add-commit-status.sh "--token=$(github-pat)" "--hash=$(Build.SourceVersion)" "--state=$GH_STATE" --target-url="$AZURE_BUILD_URL" --description="$GH_STATE" --context="$BUILD_DEFINITIONNAME"
rm -f "$FILE" 