build:
	msbuild *.csproj /r /v:quiet /bl:msbuild.binlog /nologo

scnmatrix: build
	./bin/x86/Debug/xammac_tests.app/Contents/MacOS/xammac_tests --test MonoTouchFixtures.SceneKit.SCNMatrix4Test

all: build
	./bin/x86/Debug/xammac_tests.app/Contents/MacOS/xammac_tests
