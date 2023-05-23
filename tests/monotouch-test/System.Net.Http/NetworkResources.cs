using System;
using System.Net;
using Foundation;

namespace MonoTests.System.Net.Http {
	[Preserve (AllMembers = true)]
	public static class NetworkResources {
		public static string MicrosoftUrl => "https://www.microsoft.com";
		public static Uri MicrosoftUri => new Uri (MicrosoftUrl);
		public static string MicrosoftHttpUrl => "http://www.microsoft.com";
		public static string XamarinUrl => "https://dotnet.microsoft.com/apps/xamarin";
		public static string XamarinHttpUrl => "http://dotnet.microsoft.com/apps/xamarin";
		public static Uri XamarinUri => new Uri (XamarinUrl);
		public static string StatsUrl => "https://api.imgur.com/2/stats";

		public static string [] HttpsUrls => new [] {
			MicrosoftUrl,
			XamarinUrl,
			Httpbin.Url,
		};

		public static string [] HttpUrls => new [] {
			MicrosoftHttpUrl,
			XamarinHttpUrl,
			Httpbin.HttpUrl,
		};

		// Robots urls, useful when we want to get a small file
		public static string MicrosoftRobotsUrl => "https://www.microsoft.com/robots.txt";
		public static string XamarinRobotsUrl => "https://www.xamarin.com/robots.txt";
		public static string BingRobotsUrl => "http://www.bing.com/robots.txt";
		public static string XboxRobotsUrl => "https://www.xbox.com/robots.txt";
		public static string MSNRobotsUrl => "https://www.msn.com/robots.txt";
		public static string VisualStudioRobotsUrl => "https://visualstudio.microsoft.com/robots.txt";

		public static string [] RobotsUrls => new [] {
			MicrosoftRobotsUrl,
			XamarinRobotsUrl,
			BingRobotsUrl,
			XboxRobotsUrl,
			MSNRobotsUrl,
			VisualStudioRobotsUrl,
		};

		public static class Httpbin {
			public static string Url { get { global::NUnit.Framework.Assert.Ignore ("httpbin is probably down"); return string.Empty; } }
			public static Uri Uri => new Uri ($"{Url}");
			public static string DeleteUrl => $"{Url}/delete";
			public static string GetUrl => $"{Url}/get";
			public static string PatchUrl => $"{Url}/patch";
			public static string PostUrl => $"{Url}/post";
			public static string PutUrl => $"{Url}/put";
			public static string CookiesUrl => $"{Url}/cookies";
			public static string HttpUrl { get { global::NUnit.Framework.Assert.Ignore ("httpbin is probably down"); return string.Empty; } }


			public static string GetAbsoluteRedirectUrl (int count) => $"{Url}/absolute-redirect/{count}";
			public static string GetRedirectUrl (int count) => $"{Url}/redirect/{count}";
			public static string GetRelativeRedirectUrl (int count) => $"{Url}/relative-redirect/{count}";
			public static string GetStatusCodeUrl (HttpStatusCode status) => $"{HttpUrl}/status/{(int) status}";
			public static string GetSetCookieUrl (string cookie, string value) => $"{Url}/cookies/set?{cookie}={value}";
			public static string GetBasicAuthUrl (string username, string password) => $"{Url}/basic-auth/{username}/{password}";

		}
	}
}
