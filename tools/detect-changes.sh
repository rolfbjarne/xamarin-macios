#!/bin/bash -eux

set -o pipefail
IFS=$'\n\t'


# Change detection:
#
# * Changes in current PR/commit (if a PR/CI) - api + generator
# * Changes vs stable - api
# * Changes between different assemblies (Xamarin vs .NET, Microsoft.iOS vs Microsoft.MacCatalyst)
#

function show_help ()
{
	echo "$(basename "$0"): Detect changes in the current commit vs stable and vs another commit"
	echo "Usage is: $(basename "$0") --base=[TREEISH] [options]"
	echo "   -h, -?, --help               Displays the help."
	echo "   -b, --base=[HASH]            The hash to compare the currently built assemblies against. The default is the previous commit (HEAD^)."
	echo "   --pull-request=[NUMBER]      The pull request to compare against. This assumes that: a) the current hash is the tip of the pull request b) --base has not been specified."  I
	echo "   --keep-build                 Don't remove the cloned & built working copy of the other hash once done."
	echo "   --use-existing-build         Use an existing build (kept with --keep-build) instead of building it again."
	echo "   --skip-commit-comparison     Don't do the generator diff."
	echo "   --skip-stable-api-comparison Don't do the api diff"
	echo ""
}

# Go to the root directory of the git repo, so that we don't run into any surprises with paths.
# Also make ROOT_DIR an absolute path.
ROOT_DIR=$(git rev-parse --show-toplevel)
cd "$ROOT_DIR"
ROOT_DIR=$(pwd)