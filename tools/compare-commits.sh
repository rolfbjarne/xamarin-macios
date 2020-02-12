#!/bin/bash -e

BASE_HASH=
COMP_HASH=HEAD
WORKING_DIR=

WHITE=$(tput setaf 7 2>/dev/null || true)
BLUE=$(tput setaf 6 2>/dev/null || true)
RED=$(tput setaf 9 2>/dev/null || true)
CLEAR=$(tput sgr0 2>/dev/null || true)

# Clone files on High Sierra, instead of copying them. Much faster.

CP="cp"
if df -t apfs / >/dev/null 2>&1; then
	CP="cp -c"
fi

function report_error_line ()
{
	echo "$@"
	if test -n "$FAILURE_FILE"; then
		# remove color codes when writing to failure file
		# shellcheck disable=SC2001
		echo "$@" | sed $'s,\x1b\\[[0-9;]*[a-zA-Z],,g' >> "$FAILURE_FILE"
	fi
}

function show_help ()
{
	echo "$(basename "$0"): Compare the managed API and generate a diff for the generated code between the currently built assemblies and a specific hash."
	echo "Usage is: $(basename "$0") --base=[TREEISH] [options]"
	echo "   -h, -?, --help          Displays the help"
	echo "   -b, --base=[TREEISH]    The treeish to compare the currently built assemblies against."
	#not quite implemented yet# echo "   -c, --compare=[TREEISH] Optional, if specified use this hash to build the 'after' assemblies for the comparison."
	echo ""
	printf "${BLUE} WARNING: This tool will temporarily change the current HEAD of your git checkout.${CLEAR}\\n"
	printf "${BLUE} WARNING: The tool will try to restore the current HEAD when done (or if cancelled), but this is not guaranteed.${CLEAR}\\n"
	echo ""
}

ORIGINAL_ARGS=("$@")
FAILURE_FILE=
while ! test -z "$1"; do
	case "$1" in
		--help|-\?|-h)
			show_help
			exit 0
			;;
		--base=*|-b=*)
			BASE_HASH="${1#*=}"
			shift
			;;
		--base|-b)
			BASE_HASH="$2"
			shift 2
			;;
		--compare=*|-c=*)
			COMP_HASH="${1#*=}"
			shift
			;;
		--compare|-c)
			COMP_HASH="$2"
			shift 2
			;;
		--impl-working-dir=*)
			WORKING_DIR="${1#*=}"
			shift
			;;
		--failure-file=*)
			FAILURE_FILE="${1#*=}"
			shift
			;;
		--failure-file)
			FAILURE_FILE="$2"
			shift 2
			;;
		*)
			echo "Error: Unknown argument: $1"
			exit 1
			;;
	esac
done

if test -z "$BASE_HASH"; then
	report_error_line "${RED}Error: It's required to specify the hash to compare against (--base=HASH).${CLEAR}"
	exit 1
fi

ROOT_DIR=$(git rev-parse --show-toplevel)

# We'll checkout another hash, which may not have this script, and executing a script that is deleted
# sounds like a bad idea. So copy the scripts to /tmp and execute it from there
if test -z "$WORKING_DIR"; then
	$CP "$ROOT_DIR/tools/compare-commits.sh" "$ROOT_DIR/tools/diff-to-html" "$TMPDIR/"
	exec "$TMPDIR/$(basename "$0")" "${ORIGINAL_ARGS[@]}" "--impl-working-dir=$(pwd)"
	exit $?
fi
cd "$WORKING_DIR"

# Go to the root directory of the git repo, so that we don't run into any surprises with paths.
# Also make ROOT_DIR an absolute path.
cd "$ROOT_DIR"
ROOT_DIR=$(pwd)

# Only show colors locally. The normal "has-controlling-terminal" doesn't work, because
# we always capture the output to indent it (thus the git processes never have a controlling
# terminal)
if test -z "$BUILD_REVISION"; then
	GIT_COLOR=--color=always
	GIT_COLOR_P="-c color.status=always"
fi

if [ -n "$(git status --porcelain --ignore-submodule)" ]; then
	report_error_line "${RED}** Error: Working directory isn't clean:${CLEAR}"
	git $GIT_COLOR_P status --ignore-submodule | sed 's/^/    /' | while read line; do report_error_line "$line"; done
	exit 1
fi

echo "Comparing the changes between $WHITE$BASE_HASH$CLEAR and $WHITE$COMP_HASH$CLEAR:"
git log "$BASE_HASH..$COMP_HASH" --oneline $GIT_COLOR | sed 's/^/    /'

# Resolve any treeish hash value (for instance HEAD^4) to the unique (MD5) hash
COMP_HASH=$(git log -1 --pretty=%H "$COMP_HASH")
BASE_HASH=$(git log -1 --pretty=%H "$BASE_HASH")

# Save the current branch/hash
CURRENT_BRANCH=$(git symbolic-ref --short HEAD 2>/dev/null || true)
CURRENT_HASH=$(git log -1 --pretty=%H)

GENERATOR_DIFF_FILE=
APIDIFF_FILE=

HASH_RESTORED=
function restore_hash ()
{
	if test -n "$HASH_RESTORED"; then
		echo "Previous hash/branch already restored."
	elif test -z "$CURRENT_BRANCH"; then
		echo "Restoring the previous hash ${BLUE}${CURRENT_HASH}${CLEAR} (there was no previous branch; probably because HEAD was detached)"
		git checkout --force "$CURRENT_HASH"
		echo "Previous hash restored successfully."
	else
		echo "Restoring the previous branch ${BLUE}$CURRENT_BRANCH${CLEAR}..."
		git checkout --quiet --force "$CURRENT_BRANCH"
		git reset --hard "$CURRENT_HASH"
		echo "Previous branch restored successfully."
	fi
	HASH_RESTORED=1
}

function upon_exit ()
{
	restore_hash

	if ! test -z "$GENERATOR_DIFF_FILE"; then
		echo "Generator diff: $GENERATOR_DIFF_FILE"
	fi
	if ! test -z "$APIDIFF_FILE"; then
		echo "API diff: $APIDIFF_FILE"
	fi
}

trap upon_exit EXIT

OUTPUT_SUBDIR=tools/comparison
OUTPUT_DIR=$ROOT_DIR/$OUTPUT_SUBDIR

rm -Rf "$OUTPUT_DIR"

# Create fake destination directories in $OUTPUT_DIR
# We will build in src/ setting DESTDIR to these destination directories, but the
# build in src/ depends on a few files installed from builds/, so copy those files
# from the normal destination directories.
echo "${BLUE}Preparing temporary output directory...${CLEAR}"
mkdir -p "$OUTPUT_DIR/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/git/lib/mono"
mkdir -p "$OUTPUT_DIR/_mac-build/Library/Frameworks/Xamarin.Mac.framework/Versions/git/lib/mono"
mkdir -p "$OUTPUT_DIR/project-files"

ln -s git "$OUTPUT_DIR/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/Current"
ln -s git "$OUTPUT_DIR/_mac-build/Library/Frameworks/Xamarin.Mac.framework/Versions/Current"

for dir in Xamarin.iOS Xamarin.TVOS Xamarin.WatchOS; do
	$CP -R "$ROOT_DIR/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/git/lib/mono/$dir" "$OUTPUT_DIR/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/git/lib/mono"
done

for dir in Xamarin.Mac 4.5; do
	$CP -R "$ROOT_DIR/_mac-build/Library/Frameworks/Xamarin.Mac.framework/Versions/git/lib/mono/$dir" "$OUTPUT_DIR/_mac-build/Library/Frameworks/Xamarin.Mac.framework/Versions/git/lib/mono"
done

if test -z "$CURRENT_BRANCH"; then
	echo "${BLUE}Current hash: ${WHITE}$(git log -1 --pretty="%h: %s")${BLUE} (detached)${CLEAR}"
else
	echo "${BLUE}Current branch: ${WHITE}$CURRENT_BRANCH${BLUE} (${WHITE}$(git log -1 --pretty="%h: %s")${BLUE})${CLEAR}"
fi
echo "${BLUE}Checking out ${WHITE}$(git log -1 --pretty="%h: %s" "$BASE_HASH")${CLEAR}...${CLEAR}"
git checkout --quiet --force --detach "$BASE_HASH"

# To ensure that our logic below doesn't modify files it shouldn't, we create a stamp
# file, and compare the timestamps of all the files that shouldn't be modified to this
# file's timestamp.
touch "$OUTPUT_DIR/stamp"

echo "${BLUE}Building src/...${CLEAR}"
if ! make -C "$ROOT_DIR/src" BUILD_DIR=../tools/comparison/build PROJECT_DIR="$OUTPUT_DIR/project-files" "IOS_DESTDIR=$OUTPUT_DIR/_ios-build" "MAC_DESTDIR=$OUTPUT_DIR/_mac-build" -j8; then
	EC=$?
	report_error_line "${RED}Failed to build src/${CLEAR}"
	exit "$EC"
fi

#
# API diff
#
#   First we calculate the apidiff references for the hash we're comparing against
#   Then we restore the original hash, and finally we calculate the api diff.
#

# Calculate apidiff references according to the temporary build
echo "${BLUE}Updating apidiff references...${CLEAR}"
if ! make update-refs -C "$ROOT_DIR/tools/apidiff" -j8 APIDIFF_DIR="$OUTPUT_DIR/apidiff" IOS_DESTDIR="$OUTPUT_DIR/_ios-build" MAC_DESTDIR="$OUTPUT_DIR/_mac-build"; then
	EC=$?
	report_error_line "${RED}Failed to update apidiff references${CLEAR}"
	exit "$EC"
fi

# 
# Generator diff
#

# We make a copy of the generated source code to compare against,
# so that we can remove files we don't want to compare without
# affecting that build.
$CP -R "$ROOT_DIR/src/build" "$OUTPUT_DIR/build-new"
cd "$OUTPUT_DIR"
find build build-new '(' -name '*.dll' -or -name '*.pdb' -or -name 'generated-sources' -or -name 'generated_sources' -or -name '*.exe' -or -name '*.rsp' -or -name 'AssemblyInfo.cs' -or -name 'Constants.cs' -or -name 'generator.csproj.*' ')' -delete
mkdir -p "$OUTPUT_DIR/generator-diff"
GENERATOR_DIFF_FILE="$OUTPUT_DIR/generator-diff/index.html"
git diff --no-index build build-new > "$OUTPUT_DIR/generator-diff/generator.diff" || true
"$TMPDIR/diff-to-html" "$OUTPUT_DIR/generator-diff/generator.diff" "$GENERATOR_DIFF_FILE"

# Check if any files in the normal output paths were modified (there should be none)
MODIFIED_FILES=$(find \
	"$ROOT_DIR/_ios-build" \
	"$ROOT_DIR/_mac-build" \
	"$ROOT_DIR/src" \
	"$ROOT_DIR/tools/apidiff" \
	-type f \
	-newer "$OUTPUT_DIR/stamp")

if test -n "$MODIFIED_FILES"; then
	# If this list files, it means something's wrong with the build process
	# (the logic to build/work in a different directory is incomplete/broken)
	report_error_line "${RED}** Error: The following files were modified, and they shouldn't have been:${CLEAR}"
	echo "$MODIFIED_FILES" | sed 's/^/    /' | while read line; do report_error_line "$line"; done
	exit 1
fi

restore_hash

# Now compare the current build against those references
echo "${BLUE}Running apidiff...${CLEAR}"
APIDIFF_FILE=$OUTPUT_DIR/apidiff/api-diff.html
if ! make all-local -C "$ROOT_DIR/tools/apidiff" -j8 APIDIFF_DIR="$OUTPUT_DIR/apidiff"; then
	EC=$?
	report_error_line "${RED}Failed to run apidiff${CLEAR}"
	exit "$EC"
fi
