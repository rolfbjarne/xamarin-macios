using System.Diagnostics;
using System.Xml;

#nullable enable

namespace Xamarin.Tests {
	[TestFixture]
	public class Xtro {
		[Test]
		public void RunTest ()
		{
			var dir = "/Users/rolf/work/maccore/xharness/xamarin-macios/tests/xtro-sharpie";
			var args = new [] {
				"-C", dir,
				"report-dotnet/index.html",
				"-j", "8",
			};
			ExecutionHelper.Execute ("make", args);
			var report = Path.Combine (dir, "report-dotnet", "index.html");
			Console.WriteLine ($"Added {report} as attachment.");
			TestContext.AddTestAttachment (report, "HTML report");
		}
	}
}
