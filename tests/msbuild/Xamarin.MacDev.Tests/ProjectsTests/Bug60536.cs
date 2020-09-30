using System;
using System.IO;
using System.Linq;
using System.Collections;

using NUnit.Framework;

namespace Xamarin.iOS.Tasks
{
	[TestFixture]
	public class Bug60536 : ProjectTest
	{
		public Bug60536 ()
			: base (null, "iPhoneSimulator", "Debug")
		{
		}

		[Test]
		public void TestACToolTaskCatchesJsonException ()
		{
			var mtouchPaths = SetupProjectPaths ("Bug60536");
			var csproj = mtouchPaths.ProjectCSProjPath;

			MonoTouchProject = mtouchPaths;
			Engine.ProjectCollection.SetGlobalProperty("Platform", Platform);
			Engine.ProjectCollection.SetGlobalProperty("Configuration", Config);

			RunTarget (mtouchPaths, "Clean");
			Assert.IsFalse (Directory.Exists (AppBundlePath), "App bundle exists after cleanup: {0} ", AppBundlePath);
			Assert.IsFalse (Directory.Exists (AppBundlePath + ".dSYM"), "App bundle .dSYM exists after cleanup: {0} ", AppBundlePath + ".dSYM");
			Assert.IsFalse (Directory.Exists (AppBundlePath + ".mSYM"), "App bundle .mSYM exists after cleanup: {0} ", AppBundlePath + ".mSYM");

			var baseDir = Path.GetDirectoryName (csproj);
			var objDir = Path.Combine (baseDir, "obj", Platform, Config);
			var binDir = Path.Combine (baseDir, "bin", Platform, Config);

			if (Directory.Exists (objDir)) {
				var path = Directory.EnumerateFiles (objDir, "*.*", SearchOption.AllDirectories).FirstOrDefault ();
				Assert.IsNull (path, "File not cleaned: {0}", path);
			}

			if (Directory.Exists (binDir)) {
				var path = Directory.EnumerateFiles (binDir, "*.*", SearchOption.AllDirectories).FirstOrDefault ();
				Assert.IsNull (path, "File not cleaned: {0}", path);
			}

			RunTarget (MonoTouchProject, "Build", 1);
			if (Engine.Logger.ErrorEvents.Count != 1) {
				string messages = string.Empty;
				if (Engine.Logger.ErrorEvents.Count > 0)
					messages = "\n\t" + string.Join ("\n\t", Engine.Logger.ErrorEvents.Select ((v) => v.Message).ToArray ());
				Assert.AreEqual (1, Engine.Logger.ErrorEvents.Count, "#RunTarget-ErrorCount" + messages);
			}

			var expectedFile = Path.Combine ("obj", Platform, Config, "actool", "cloned-assets", "Assets.xcassets", "AppIcon.appiconset", "Contents.json");
			Assert.AreEqual (expectedFile, Engine.Logger.ErrorEvents[0].File, "File");
			Assert.AreEqual (197, Engine.Logger.ErrorEvents[0].LineNumber, "LineNumber");
			Assert.AreEqual (4, Engine.Logger.ErrorEvents[0].ColumnNumber, "ColumnNumber");
			Assert.AreEqual (197, Engine.Logger.ErrorEvents[0].EndLineNumber, "EndLineNumber");
			Assert.AreEqual (4, Engine.Logger.ErrorEvents[0].EndColumnNumber, "EndColumnNumber");
			Assert.AreEqual ("']' is invalid without a matching open. LineNumber: 196 | BytePositionInLine: 3.", Engine.Logger.ErrorEvents[0].Message, "Message");
		}
	}
}
