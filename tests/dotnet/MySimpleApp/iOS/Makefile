include ../shared.mk

nativeaot:
	$(DOTNET) build /bl:$@.binlog *.csproj /p:RuntimeIdentifier=ios-arm64 /p:PublishAot=true
