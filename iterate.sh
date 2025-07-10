#!/bin/bash -eu

set -o pipefail
IFS=$'\n\t'

source ~/bin/colors.sh

cd ~/work/dotnet/macios/appex-deduplicate-frameworks/macios

if [ -n "$(git status --porcelain --ignore-submodule)" ]; then
	echo "${RED}Working directory is not clean:${CLEAR}"
	git status --ignore-submodule | sed 's/^/    /'
	exit 1
fi

cb

cp _build/Microsoft.iOS.Ref.*/ref/net*/Microsoft.* ~/work/apidrop.visualstudio.com/binaries/dotnet-macios/*ios*/
cp _build/Microsoft.tvOS.Ref.*/ref/net*/Microsoft.* ~/work/apidrop.visualstudio.com/binaries/dotnet-macios/*tvos*/
cp _build/Microsoft.macOS.Ref.*/ref/net*/Microsoft.* ~/work/apidrop.visualstudio.com/binaries/dotnet-macios/*macos*/
cp _build/Microsoft.MacCatalyst.Ref.*/ref/net*/Microsoft.* ~/work/apidrop.visualstudio.com/binaries/dotnet-macios/*maccatalyst*/

cd ~/work/apidrop.visualstudio.com/binaries/dotnet-macios/
git add .
git commit -m "Add updated assemblies"
git push

echo "Run this pipeline: ${MAGENTA}https://apidrop.visualstudio.com/Content%20CI/_build?definitionId=8026${CLEAR}"
