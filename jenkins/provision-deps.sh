#!/bin/bash -ex

cd "$(dirname "${BASH_SOURCE[0]}")/.."
WORKSPACE=$(pwd)

report_error ()
{
	echo "🔥 [Provisioning failed]($BUILD_URL/console) 🔥" >> "$WORKSPACE/jenkins/pr-comments.md"
}
trap report_error ERR

env
./system-dependencies.sh --provision-all

echo "✅ [Provisioning succeeded]($BUILD_URL/console)" >> "$WORKSPACE/jenkins/pr-comments.md"
