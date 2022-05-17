#!/bin/bash -ex

INPUT_DIR=$1
OUTPUT_FILE=$2
# mode is either pr or stable
GIST_FILE=$3
MODE=pr

rm -f "$OUTPUT_FILE"
rm -f "$GIST_FILE"

echo ":clipboard: [PR Build] API Diff :clipboard:" >> "$OUTPUT_FILE"
echo "" >> "$OUTPUT_FILE"
echo " # API diff (for current PR)" >> "$OUTPUT_FILE"
echo "" >> "$OUTPUT_FILE"
echo ":information_source: API Diff (from PR only) (please review changes)" >> "$OUTPUT_FILE"
echo "" >> "$OUTPUT_FILE"

echo "API diff:  [vsdrops](%VSDROPS_PREFIX%api-diff.html) [gist](%GIST_api-diff.html%)" >> "$OUTPUT_FILE"
echo "GIST_api-diff.html=api-diff.html" >> "$GIST_FILE"

echo "<details><summary>Xamarin</summary>" >> "$OUTPUT_FILE"

if [[ -n "$INCLUDE_IOS" ]]; then
	echo "* iOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/ios-api-diff.html) [gist](https://gist.github.com/03d3c08e35be2c575eead061399c3ae4)" >> "$OUTPUT_FILE"
fi
if [[ -n "$INCLUDE_MAC" ]]; then
	echo "* macOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/mac-api-diff.html) [gist](https://gist.github.com/2bb19408a6f9a99f4b29ded4b7321d3e)" >> "$OUTPUT_FILE"
fi
if [[ -n "$INCLUDE_TVOS" ]]; then
	echo "* tvOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/tvos-api-diff.html) [gist](https://gist.github.com/23468d9fdb8b9af5f010e7fc0c4af844)" >> "$OUTPUT_FILE"
fi
if [[ -n "$INCLUDE_WATCH" ]]; then
	echo "* watchOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/watchos-api-diff.html) [gist](https://gist.github.com/d3555eb5bd14ce73f529b3bef1f4bc1d)" >> "$OUTPUT_FILE"
fi
echo "</details>" >> "$OUTPUT_FILE"

<details><summary>.NET</summary>

* dotnet-iOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/dotnet/Microsoft.iOS.Ref/ref/net6.0/Microsoft.iOS-api-diff.html) [gist](https://gist.github.com/a9e05fe9d12fcd6c2a6ba1395c71438e)
* dotnet-macOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/dotnet/Microsoft.macOS.Ref/ref/net6.0/Microsoft.macOS-api-diff.html) [gist](https://gist.github.com/af44e7b4502e9c5d9ca7a593a3783312)
* dotnet-tvOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/dotnet/Microsoft.tvOS.Ref/ref/net6.0/Microsoft.TVOS-api-diff.html) [gist](https://gist.github.com/8239bb884236ad51e078d65361485d4a)
* dotnet-MacCatalyst [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/dotnet/Microsoft.MacCatalyst.Ref/ref/net6.0/Microsoft.MacCatalyst-api-diff.html) [gist](https://gist.github.com/19eac9afef0bd2edd95ac83f1a02d584)
</details>

<details><summary>Xamarin vs .NET</summary>

* dotnet-legacy-iOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/dotnet/legacy-diff/Microsoft.iOS.Ref/ref/net6.0/Microsoft.iOS-api-diff.html) [gist](https://gist.github.com/4c7ea40fb606ca8257a121cb7b384d9f)
* dotnet-legacy-macOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/dotnet/legacy-diff/Microsoft.macOS.Ref/ref/net6.0/Microsoft.macOS-api-diff.html) [gist](https://gist.github.com/1ce01cc88825046e339a6c339f4aa9ab)
* dotnet-legacy-tvOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/dotnet/legacy-diff/Microsoft.tvOS.Ref/ref/net6.0/Microsoft.TVOS-api-diff.html) [gist](https://gist.github.com/6bf33a6817aed042cadc05bf885cee4f)
</details>

<details><summary>iOS vs Mac Catalyst (.NET)</summary>

* dotnet-macCatiOS [vsdrops](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;/dotnet/iOS-MacCatalyst-diff/Microsoft.iOS.Ref/ref/net6.0/Microsoft.iOS.MacCatalyst-api-diff.html) [gist](https://gist.github.com/29c885c2761568938759b37aac88b126)
</details>


# Generator diff

:information_source: [Generator Diff](https://vsdrop.corp.microsoft.com/file/v1/xamarin-macios/device-tests/20220517.5/6163591/apigeneratordiff/;//generator-diff/index.html) (please review changes)


	[Pipeline](https://devdiv.visualstudio.com/DevDiv/_build/index?buildId=6163591&view=ms.vss-test-web.test-result-details) on Agent XAMBOT-1042.Monterey'
	Hash: [792fc864e8a008df159ba347fae49412ef65489e](https://github.com/xamarin/xamarin-macios/pull/15043/commits/792fc864e8a008df159ba347fae49412ef65489e)
