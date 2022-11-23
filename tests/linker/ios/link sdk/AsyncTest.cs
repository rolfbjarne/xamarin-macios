using System;
using System.Net.Http;
using System.Threading.Tasks;
using Foundation;
using NUnit.Framework;
using MonoTests.System.Net.Http;

namespace LinkSdk {

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class AsyncTests {

		public Task<string> LoadCategories ()
		{
			return Task.Run (async () => await (new HttpClient ()).GetStringAsync (NetworkResources.MicrosoftUrl));
		}

		[Test]
		public void Bug12221 ()
		{
#if __WATCHOS__
			Assert.Ignore ("WatchOS doesn't support BSD sockets, which our network stack currently requires.");
#endif
			try {
				LoadCategories ().GetAwaiter ().GetResult ();
			} catch (TaskCanceledException tce) {
				TestRuntime.IgnoreInCI ("Ignore any download timeouts");
				throw;
			} catch (HttpRequestException hre) {
				TestRuntime.IgnoreInCIIfForbidden (hre); // Ignore any 403 errors.
				throw;
			}
		}
	}
}
