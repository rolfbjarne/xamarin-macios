﻿//
// PlatformFramework.cs
//
// Author: Jeffrey Stedfast <jeff@xamarin.com>
//
// Copyright (c) 2016 Xamarin Inc. (www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

using Xamarin.Utils;

namespace Xamarin.MacDev.Tasks
{
	public static class PlatformFrameworkHelper
	{
		public static ApplePlatform GetFramework (string targetFrameworkMoniker)
		{
			return TargetFramework.Parse (targetFrameworkMoniker).Platform;
		}

		public static string GetOperatingSystem (string targetFrameworkMoniker)
		{
			var framework = PlatformFrameworkHelper.GetFramework (targetFrameworkMoniker);
			switch (framework) {
			case ApplePlatform.WatchOS:
				return "watchos";
			case ApplePlatform.TVOS:
				return "tvos";
			case ApplePlatform.MacOSX:
				return "osx";
			case ApplePlatform.iOS:
				return "ios";
			default:
				throw new InvalidOperationException (string.Format ("Unknown target framework {0} for target framework moniker {1}.", framework, targetFrameworkMoniker));
			}
		}

		public static string GetMinimumOSVersionKey (ApplePlatform platform)
		{
			switch (platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.WatchOS:
				return ManifestKeys.MinimumOSVersion;
			case ApplePlatform.MacOSX:
				return ManifestKeys.LSMinimumSystemVersion;
			default:
				throw new InvalidOperationException ($"Invalid platform: {platform}");
			}
		}
	}
}
