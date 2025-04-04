using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;

using Foundation;
using ObjCRuntime;

using NUnit.Framework;

namespace LinkAnyTest {
	// This test is included in both the LinkAll and LinkSdk projects for both iOS and macOS.
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class CommonLinkAnyTest {
		[Test]
		public void Blocks ()
		{
			int i = 0;
			string b = null;
			NSSet s = new NSSet ("a", "b", "c");
			s.Enumerate (delegate (NSObject obj, ref bool stop)
			{
				stop = i++ == 1;
				b = obj.ToString ();
			});
			// test behavior (we did not break anything)
			Assert.AreEqual ("b", b, "Stop");
			// test that BlockLiteral is fully preserved
			int size = Marshal.SizeOf (typeof (BlockLiteral)); // e.g. unused 'reserved' must not be removed
			Assert.AreEqual (IntPtr.Size == 8 ? 48 : 28, size, "BlockLiteral size");

		}

		[Test]
		public void CallerFilePath ()
		{
			Bug7114 ();
		}

		// https://bugzilla.xamarin.com/show_bug.cgi?id=7114
		public static void Bug7114 ([CallerFilePath] string filePath = null)
		{
			Assert.IsNotNull (filePath, "CallerFilePath");
		}

		[Test]
		public void AppContextGetData ()
		{
			// https://github.com/dotnet/runtime/issues/50290
			Assert.IsNotNull (AppContext.GetData ("APP_PATHS"), "APP_PATHS");
			Assert.IsNotNull (AppContext.GetData ("PINVOKE_OVERRIDE"), "PINVOKE_OVERRIDE");
		}

		[Test]
		public void BackingFieldInGenericType ()
		{
			// https://github.com/dotnet/linker/issues/3148
#if __MACOS__
			var view = new AppKit.NSView ();
#else
			var view = new UIKit.UIView ();
#endif
			GC.KeepAlive (view.HeightAnchor);
		}

		[Test]
		public void JsonSerializer_Serialize ()
		{
			var a = JsonSerializer.Serialize (42);
			Assert.AreEqual ("42", a, "serialized 42");

			var b = JsonSerializer.Serialize (new int [] { 42, 3, 14, 15 });
			Assert.AreEqual ("[42,3,14,15]", b, "serialized array");
		}

		[Test]
		public void JsonSerializer_Deserialize ()
		{
			var a = JsonSerializer.Deserialize<int> ("42");
			Assert.AreEqual (42, a, "deserialized 42");

			var b = JsonSerializer.Deserialize<int []> ("[42,3,14,15]");
			CollectionAssert.AreEqual (new int [] { 42, 3, 14, 15 }, b, "deserialized array");
		}

		/// ADDED FROM MAC

		[Test]
		public void AES ()
		{
			Assert.NotNull (Aes.Create (), "AES");
		}

		static bool waited;
		static bool requestError;
		static HttpStatusCode statusCode;

		void TimedWait (Task task)
		{
			var rv = task.Wait (TimeSpan.FromMinutes (1));
			if (rv)
				return;

			TestRuntime.IgnoreInCI ("This test times out randomly in CI due to bad network.");
			Assert.Fail ("Test timed out");
		}

		// http://blogs.msdn.com/b/csharpfaq/archive/2012/06/26/understanding-a-simple-async-program.aspx
		// ref: https://bugzilla.xamarin.com/show_bug.cgi?id=7114
		static async Task GetWebPageAsync ()
		{
			// do not use GetStringAsync, we are going to miss useful data, such as the resul code
			using (var client = new HttpClient ()) {
				HttpResponseMessage response = await client.GetAsync ("http://example.com");
				if (!response.IsSuccessStatusCode) {
					requestError = true;
					statusCode = response.StatusCode;
				} else {
					string content = await response.Content.ReadAsStringAsync ();
					waited = true;
					bool success = !String.IsNullOrEmpty (content);
					Assert.IsTrue (success, $"received {content.Length} bytes");
				}
			}
		}

		[Test]
		public void GetWebPageAsyncTest ()
		{
			var current_sc = SynchronizationContext.Current;
			try {
				// we do not want the async code to get back to the AppKit thread, hanging the process
				SynchronizationContext.SetSynchronizationContext (null);
				TimedWait (GetWebPageAsync ());
				if (requestError) {
					Assert.Inconclusive ($"Test cannot be trusted. Issues performing the request. Status code '{statusCode}'");
				} else {
					Assert.IsTrue (waited, "async/await worked");
				}
			} finally {
				SynchronizationContext.SetSynchronizationContext (current_sc);
			}
		}

		void WebClientTest (string [] urls)
		{
			var exceptions = new List<string> ();
			foreach (var url in urls) {
				try {
					var wc = new WebClient ();
					var data = wc.DownloadString (url);

					Assert.That (data, Is.Not.Empty, "Downloaded content");
					return; // one url succeeded, that's enough
				} catch (Exception e) {
					var msg = $"Url '{url}' failed: {e.ToString ()}";
					Console.WriteLine (msg); // If this keeps occurring locally for the same url, we might have to take it off the list of urls to test.
					exceptions.Add (msg);
				}
			}
			Assert.That (exceptions, Is.Empty, "At least one url should work");
		}

		[Test]
		public void WebClientTest_Http ()
		{
			WebClientTest (NetworkResources.HttpUrls);
		}

		[Test]
		public void WebClientTest_Https ()
		{
			WebClientTest (NetworkResources.HttpsUrls);
		}

		[Test]
		public void WebClientTest_Async ()
		{
			var current_sc = SynchronizationContext.Current;
			try {
				// we do not want the async code to get back to the AppKit thread, hanging the process
				SynchronizationContext.SetSynchronizationContext (null);

				string data = null;

				var exceptions = new List<string> ();
				foreach (var url in NetworkResources.HttpsUrls) {
					try {
						async Task GetWebPage (string url)
						{
							var wc = new WebClient ();
							var task = wc.DownloadStringTaskAsync (new Uri (url));
							data = await task;
						}

						TimedWait (GetWebPage (url));
						Assert.That (data, Is.Not.Empty, "Downloaded content");
						return; // one url succeeded, that's enough
					} catch (Exception e) {
						var msg = $"Url '{url}' failed: {e.ToString ()}";
						Console.WriteLine (msg); // If this keeps occurring locally for the same url, we might have to take it off the list of urls to test.
						exceptions.Add (msg);
					}
				}
				Assert.That (exceptions, Is.Empty, "At least one url should work");
			} finally {
				SynchronizationContext.SetSynchronizationContext (current_sc);

			}
		}
	}
}
