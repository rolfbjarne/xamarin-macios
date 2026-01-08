include ../shared.mk

startuphook:
	dotnet build -bl
	DOTNET_STARTUP_HOOKS=StartupHook ./bin/Debug/net10.0-maccatalyst/maccatalyst-arm64/MySimpleApp.app/Contents/MacOS/MySimpleApp
