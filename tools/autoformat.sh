#!/bin/bash -ex

# Go to the top level directory
cd "$(git rev-parse --show-toplevel)"
SRC_DIR=$(pwd)

# Go one directory up, to avoid any global.json in xamarin-macios
cd ..

# Start formatting!
dotnet format "$SRC_DIR/tools/xibuild/xibuild.csproj"
dotnet format whitespace "$SRC_DIR/tests/cecil-tests/cecil-tests.csproj"
dotnet format whitespace "$SRC_DIR/tests/dotnet/UnitTests/DotNetUnitTests.csproj"
dotnet format whitespace "$SRC_DIR/msbuild/Messaging/Xamarin.Messaging.Build/Xamarin.Messaging.Build.csproj"
dotnet format whitespace "$SRC_DIR/msbuild/Xamarin.Localization.MSBuild/Xamarin.Localization.MSBuild.csproj"
dotnet format whitespace "$SRC_DIR/msbuild/Xamarin.Mac.Tasks/Xamarin.Mac.Tasks.csproj"
dotnet format whitespace "$SRC_DIR/msbuild/Xamarin.MacDev.Tasks/Xamarin.MacDev.Tasks.csproj"
dotnet format whitespace "$SRC_DIR/msbuild/Xamarin.iOS.Tasks.Windows/Xamarin.iOS.Tasks.Windows.csproj"
dotnet format whitespace "$SRC_DIR/msbuild/Xamarin.iOS.Tasks/Xamarin.iOS.Tasks.csproj"
dotnet format whitespace "$SRC_DIR/src/bgen/bgen.csproj"
dotnet format whitespace "$SRC_DIR/tools/dotnet-linker/dotnet-linker.csproj"
dotnet format whitespace "$SRC_DIR/tools/mmp/mmp.csproj"
dotnet format whitespace "$SRC_DIR/tools/mtouch/mtouch.csproj"
dotnet format whitespace "$SRC_DIR/tests/xharness/xharness.sln"
dotnet format whitespace "$SRC_DIR/tools/siminstaller/siminstaller.csproj"
dotnet format whitespace "$SRC_DIR/tests/introspection/dotnet/iOS/introspection.csproj"
dotnet format whitespace "$SRC_DIR/tests/introspection/dotnet/MacCatalyst/introspection.csproj"
dotnet format whitespace "$SRC_DIR/tests/introspection/dotnet/macOS/introspection.csproj"
dotnet format whitespace "$SRC_DIR/tests/introspection/dotnet/tvOS/introspection.csproj"
dotnet format whitespace "$SRC_DIR/tests/introspection/iOS/introspection-ios.csproj"
dotnet format whitespace "$SRC_DIR/tests/introspection/Mac/introspection-mac.csproj"
dotnet format whitespace "$SRC_DIR/tests/xtro-sharpie/xtro-sharpie.csproj"
dotnet format whitespace "$SRC_DIR/tests/xtro-sharpie/u2ignore/u2ignore.csproj"
dotnet format whitespace "$SRC_DIR/tests/xtro-sharpie/u2todo/u2todo.csproj"
dotnet format whitespace "$SRC_DIR/tests/xtro-sharpie/xtro-report/xtro-report.csproj"
dotnet format whitespace "$SRC_DIR/tests/xtro-sharpie/xtro-sanity/xtro-sanity.csproj"

dotnet format whitespace --folder "$SRC_DIR/src/Accelerate"
dotnet format whitespace --folder "$SRC_DIR/src/Accessibility"
dotnet format whitespace --folder "$SRC_DIR/src/Accounts"
dotnet format whitespace --folder "$SRC_DIR/src/AddressBook"
dotnet format whitespace --folder "$SRC_DIR/src/AddressBookUI"
dotnet format whitespace --folder "$SRC_DIR/src/AdSupport/"
dotnet format whitespace --folder "$SRC_DIR/src/AppKit/"
dotnet format whitespace --folder "$SRC_DIR/src/ARKit/"
dotnet format whitespace --folder "$SRC_DIR/src/AssetsLibrary/"
dotnet format whitespace --folder "$SRC_DIR/src/AudioToolbox/"
dotnet format whitespace --folder "$SRC_DIR/src/AudioUnit/"
dotnet format whitespace --folder "$SRC_DIR/src/AuthenticationServices/"
dotnet format whitespace --folder "$SRC_DIR/src/AVFoundation/"
dotnet format whitespace --folder "$SRC_DIR/src/AVKit/"
dotnet format whitespace --folder "$SRC_DIR/src/BackgroundTasks/"
dotnet format whitespace --folder "$SRC_DIR/src/BusinessChat/"
dotnet format whitespace --folder "$SRC_DIR/src/CFNetwork/"
dotnet format whitespace --folder "$SRC_DIR/src/CarPlay/"
dotnet format whitespace --folder "$SRC_DIR/src/Chip/"
dotnet format whitespace --folder "$SRC_DIR/src/ClockKit/"
dotnet format whitespace --folder "$SRC_DIR/src/CloudKit/"
dotnet format whitespace --folder "$SRC_DIR/src/Compression/"
dotnet format whitespace --folder "$SRC_DIR/src/Contacts/"
dotnet format whitespace --folder "$SRC_DIR/src/CoreAnimation/"
dotnet format whitespace --folder "$SRC_DIR/src/CoreBluetooth/"
dotnet format whitespace --folder "$SRC_DIR/src/CoreData/"

# dotnet format "$SRC_DIR/[...]"
# add more projects here...

cd "$SRC_DIR"
