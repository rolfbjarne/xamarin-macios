#!/bin/bash -ex

BASE_HASH=
COMP_HASH=HEAD
WORKING_DIR=

WHITE=$(tput setaf 7 2>/dev/null || true)
BLUE=$(tput setaf 6 2>/dev/null || true)
RED=$(tput setaf 9 2>/dev/null || true)
CLEAR=$(tput sgr0 2>/dev/null || true)

# Clone files on High Sierra, instead of copying them. Much faster.

CP="cp"

ROOT_DIR=$(git rev-parse --show-toplevel)

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

OUTPUT_SUBDIR=tools/comparison
OUTPUT_DIR=$ROOT_DIR/$OUTPUT_SUBDIR

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

for dir in 2.1 Xamarin.iOS Xamarin.TVOS Xamarin.WatchOS; do
        $CP -R "$ROOT_DIR/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/git/lib/mono/$dir" "$OUTPUT_DIR/_ios-build/Library/Frameworks/Xamarin.iOS.framework/Versions/git/lib/mono"
done

for dir in Xamarin.Mac 4.5; do
        $CP -R "$ROOT_DIR/_mac-build/Library/Frameworks/Xamarin.Mac.framework/Versions/git/lib/mono/$dir" "$OUTPUT_DIR/_mac-build/Library/Frameworks/Xamarin.Mac.framework/Versions/git/lib/mono"
done

echo "${BLUE}Building src/...${CLEAR}"

make -C "$ROOT_DIR/src" BUILD_DIR=../tools/comparison/build PROJECT_DIR="$OUTPUT_DIR/project-files" "IOS_DESTDIR=$OUTPUT_DIR/_ios-build" "MAC_DESTDIR=$OUTPUT_DIR/_mac-build" -j8 all-ios
