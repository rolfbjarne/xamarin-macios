#!/bin/bash -eux

set -o pipefail
IFS=$'\n\t'

# Clean up some logs.

# I've seen machines with more than 1gb of Xamarin.Messaging logs, so clean that up.
if du -hs ~/Library/Logs/Xamarin.Messaging-*; then
	rm -rf ~/Library/Logs/Xamarin.Messaging-*
fi
