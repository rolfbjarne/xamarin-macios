using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using NUnit.Framework;

using Xamarin.MacDev;
using Xamarin.Tests;

namespace Xamarin.iOS.Tasks
{
	[TestFixture ("iPhone", "Debug")]
	[TestFixture ("iPhone", "Release")]
	[TestFixture ("iPhoneSimulator", "Debug")]
	[TestFixture ("iPhoneSimulator", "Release")]
	public class CodesignAppBundle : ProjectTest
	{
		readonly string config;

		public CodesignAppBundle (string platform, string configuration) : base (platform)
		{
			config = configuration;
		}

		static bool IsCodesigned (string path)
		{
			var psi = new ProcessStartInfo ("/usr/bin/codesign");
			var args = new CommandLineArgumentBuilder ();

			args.Add ("--verify");
			args.AddQuoted (path);

			psi.Arguments = args.ToString ();

			var process = Process.Start (psi);
			process.WaitForExit ();

			return process.ExitCode == 0;
		}

		void AssertProperlyCodesigned (bool expected, string message = "")
		{
			foreach (var dylib in Directory.EnumerateFiles (AppBundlePath, "*.dylib", SearchOption.AllDirectories))
				Assert.AreEqual (expected, IsCodesigned (dylib), "{0} is not properly codesigned. {1}", dylib, message);

			foreach (var appex in Directory.EnumerateDirectories (AppBundlePath, "*.appex", SearchOption.AllDirectories))
				Assert.AreEqual (expected, IsCodesigned (appex), "{0} is not properly codesigned. {1}", appex, message);

			var watchDir = Path.Combine (AppBundlePath, "Watch");
			if (Directory.Exists (watchDir)) {
				foreach (var watchApp in Directory.EnumerateDirectories (watchDir, "*.app", SearchOption.TopDirectoryOnly))
					Assert.AreEqual (expected, IsCodesigned (watchApp), "{0} is not properly codesigned. {1}", watchApp, message);
			}
		}

		void AssertModifiedFiles (Dictionary<string, DateTime> captured, IEnumerable<string> expected_modifications, string message)
		{
			AssertModifiedFiles (captured, expected_modifications, message, out _);
		}

		void AssertModifiedFiles (Dictionary<string, DateTime> captured, IEnumerable<string> expected_modifications, string message, out Dictionary<string, DateTime> currentTimestamps)
		{
			var actualModifications = CompareTimestamps (captured, out currentTimestamps);
			var expectedModifications = new HashSet<string> (expected_modifications);
			var expectedPatterns = expectedModifications.Where ((v) => v.IndexOfAny (new char[] { '*', '?' }) > 0);
			var onlyExpected = expectedModifications.Except (actualModifications).Except (expectedPatterns); // Skip pattern-based expected files
			var onlyActual = actualModifications.Except (expectedModifications);
			var sb = new System.Text.StringBuilder ();
			foreach (var f in onlyExpected)
				sb.AppendLine ($"Expected '{f}' to be modified, but it wasn't.");
			foreach (var f in onlyActual) {
				if (expectedPatterns.Any ((v) => Regex.IsMatch (f, v)))
					continue;
				sb.AppendLine ($"Did not expect '{f}' to be modified.");
			}
			Assert.IsEmpty (sb.ToString (), message ?? "Modified files");
		}

		void AssertNoModifiedFiles (Dictionary<string, DateTime> captured)
		{
			AssertNoModifiedFiles (captured, out _);
		}

		void AssertNoModifiedFiles (Dictionary<string, DateTime> captured, out Dictionary<string, DateTime> currentTimestamps)
		{
			Assert.That (CompareTimestamps (captured, out currentTimestamps), Is.Empty, "No modified files");
		}

		void AssertNoModifiedFiles (DateTime timestamp, string path = null)
		{
			var files = Directory.EnumerateFiles (path ?? AppBundlePath, "*.*", SearchOption.TopDirectoryOnly);
			var failures = new List<string> ();
			foreach (var file in files) {
				var newTimestamp = GetLastModified (file);
				if (newTimestamp <= timestamp)
					continue;

				failures.Add ($"{file} was modified (current timestamp: {newTimestamp}, expected <= {timestamp}");
			}
			Assert.IsEmpty (failures, "No modified files");
		}


		Dictionary<string, DateTime> CaptureTimestamps ()
		{
			var rv = new Dictionary<string, DateTime> ();
			// We look for everything in the directory that contains the app bundle,
			// so that we detect changes to dSYMs as well.
			foreach (var file in Directory.EnumerateFiles (Path.GetDirectoryName (AppBundlePath), "*", SearchOption.AllDirectories))
				rv.Add (file, new FileInfo (file).LastWriteTimeUtc);
			return rv;
		}

		HashSet<string> CompareTimestamps (Dictionary<string, DateTime> list)
		{
			return CompareTimestamps (list, out _);
		}

		const string timestamp_format = "yyyy/MM/dd HH:mm:ss:fffffff";
		HashSet<string> CompareTimestamps (Dictionary<string, DateTime> list, out Dictionary<string, DateTime> currentTimestamps)
		{
			currentTimestamps = CaptureTimestamps ();
			var rv = new HashSet<string> ();
			Console.WriteLine ($"Comparing timestamps for {AppBundlePath}");
			foreach (var a in currentTimestamps) {
				if (list.ContainsKey (a.Key))
					continue;
				Console.WriteLine ($"    Added: {a.Key} with timestamp {a.Value.ToString (timestamp_format)}.");
				rv.Add (a.Key);
			}
			foreach (var r in list) {
				if (currentTimestamps.ContainsKey (r.Key))
					continue;
				Console.WriteLine ($"    Removed: {r.Key} with timestamp {r.Value.ToString (timestamp_format)}.");
				rv.Add (r.Key);
			}
			foreach (var f in list.Keys) {
				var current = currentTimestamps[f];
				var previous = list[f];
				if (current == previous)
					continue;

				Console.WriteLine ($"    Updated: {f} from {previous.ToString (timestamp_format)} to {current.ToString (timestamp_format)} (diff: {(current - previous).TotalSeconds}s)");
				rv.Add (f);
			}
			if (rv.Count > 0) {
				Console.WriteLine ($"Comparison complete, {rv.Count} files were not up-to-date.");
			} else {
				Console.WriteLine ("Comparison complete, all files were up-to-date.");
			}
			return rv;
		}

		void RebuildAssertModifications (Dictionary<string, DateTime> captured, string project, bool expectedCodesignResults, IEnumerable<string> expected_modifications, out Dictionary<string, DateTime> currentTimestamps, string message)
		{
			EnsureFilestampChange ();

			Console.WriteLine ($"Rebuilding... {message}");
			LS (captured);
			BuildProject (project, Platform, config, clean: false);

			AssertProperlyCodesigned (expectedCodesignResults, message);
			AssertModifiedFiles (captured, expected_modifications, message, out currentTimestamps);

			LS (currentTimestamps);
		}

		void LS (Dictionary<string, DateTime> timestamps)
		{
			if (timestamps == null)
				timestamps = CaptureTimestamps ();
			Console.WriteLine ($"Listing current files:");
			foreach (var kvp in timestamps.OrderBy ((v) => v.Value)) {
				Console.WriteLine ($"    {kvp.Value.ToString (timestamp_format)}: {kvp.Key}");
			}

		}

		void ExecuteWithFileAddedToBuild (string variable, Action action)
		{
			ExecuteWithFileAddedToBuild (new string[] { variable }, action);
		}

		void ExecuteWithFileAddedToBuild (IList<string> variables, Action action)
		{
			var tmpfiles = variables.Select ((v) => {
				var rv = CreateTempFile (Guid.NewGuid ().ToString () + ".cs");
				File.WriteAllText (rv, "public class HeyYou {}");
				return rv;
			}).ToArray ();
			try {
				// set Engine.ProjectCollection.SetGlobalProperty for the in-proc build
				// and an environment variable for the out-of-proc build
				for (var i = 0; i < tmpfiles.Length; i++) {
					Engine.ProjectCollection.SetGlobalProperty (variables [i], tmpfiles [i]);
					Environment.SetEnvironmentVariable (variables [i], tmpfiles [i]);
				}
				action ();
			} finally {
				for (var i = 0; i < tmpfiles.Length; i++) {
					File.Delete (tmpfiles[i]);
					Engine.ProjectCollection.RemoveGlobalProperty (variables [i]);
					Environment.SetEnvironmentVariable (variables [i], null);
				}
			}
		}

		[Test]
		[TestCase ("MyTabbedApplication")]
		[TestCase ("MyWatch2Container")]
		[TestCase ("MyExtensionContainer")]
		public void RebuildNoChanges (string project)
		{
			bool expectedCodesignResults = Platform != "iPhoneSimulator";

			BuildProject (project, Platform, config, clean: true);
			AssertProperlyCodesigned (expectedCodesignResults);

			var captured = CaptureTimestamps ();
			EnsureFilestampChange ();

			// Rebuild w/ no changes
			Console.WriteLine ("Rebuilding...");
			LS (captured);
			BuildProject (project, Platform, config, clean: false);

			AssertProperlyCodesigned (expectedCodesignResults);
			AssertNoModifiedFiles (captured);
		}

		[Test]
		public void CodesignAfterModifyingAppExtensionTest ()
		{
			var expectedCodesignResults = Platform != "iPhoneSimulator";

			BuildProject ("MyTabbedApplication", Platform, config, clean: true);
			AssertProperlyCodesigned (expectedCodesignResults);

			var captured = CaptureTimestamps ();
			EnsureFilestampChange ();

			ExecuteWithFileAddedToBuild ("MyActionExtension_ExtraCompileInclude", () => {
				var expectedModifications = new List<string> {
					$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app/PlugIns/MyActionExtension.appex/MyActionExtension.dll",
					$"../MyTabbedApplication/bin/{Platform}/{config}/mtouch.stamp",
				};
				if (config == "Debug") {
					expectedModifications.AddRange (new[] {
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app/PlugIns/MyActionExtension.appex/MyActionExtension.pdb",
					});
				}
				if (Platform == "iPhone") {
					expectedModifications.AddRange (new[] {
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app/MyTabbedApplication",
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app/_CodeSignature/CodeResources",
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app/PlugIns/MyActionExtension.appex/MyActionExtension",
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app/PlugIns/MyActionExtension.appex/_CodeSignature/CodeResources",
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app/PlugIns/MyActionExtension.appex/MyActionExtension.aotdata.arm64",
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app/PlugIns/MyActionExtension.appex/MyActionExtension.aotdata.armv7",
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app.dSYM/Contents/Info.plist",
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyActionExtension.appex.dSYM/Contents/Info.plist",
						$"../MyTabbedApplication/bin/{Platform}/{config}/MyActionExtension.appex.dSYM/Contents/Resources/DWARF/MyActionExtension",
					});
					if (config == "Release") {
						expectedModifications.AddRange (new[] {
							$"../MyTabbedApplication/bin/{Platform}/{config}/MyTabbedApplication.app.mSYM/.*",
						});
					}
				}

				RebuildAssertModifications (captured, "MyTabbedApplication", expectedCodesignResults, expectedModifications.ToArray (), out captured, "Rebuild 1");
			});
		}

		[Test]
		public void CodesignAfterModifyingWatchApp2Test ()
		{
			var expectedCodesignResults = Platform != "iPhoneSimulator";

			BuildProject ("MyWatch2Container", Platform, config, clean: true);
			AssertProperlyCodesigned (expectedCodesignResults);

			var captured = CaptureTimestamps ();
			EnsureFilestampChange ();

			ExecuteWithFileAddedToBuild ("MyWatchKit2Extension_ExtraCompileInclude", () => {
				var expectedModifications = new List<string> {
					$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/Watch/MyWatchApp2.app/PlugIns/MyWatchKit2Extension.appex/MyWatchKit2Extension.dll",
				};
				if (config == "Debug") {
					expectedModifications.AddRange (new[] {
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/Watch/MyWatchApp2.app/PlugIns/MyWatchKit2Extension.appex/MyWatchKit2Extension.pdb",
					});
				}
				if (Platform == "iPhone") {
					expectedModifications.AddRange (new[] {
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/MyWatch2Container",
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/_CodeSignature/CodeResources",
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/Watch/MyWatchApp2.app/MyWatchApp2",
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/Watch/MyWatchApp2.app/_CodeSignature/CodeResources",
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/Watch/MyWatchApp2.app/PlugIns/MyWatchKit2Extension.appex/MyWatchKit2Extension",
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/Watch/MyWatchApp2.app/PlugIns/MyWatchKit2Extension.appex/MyWatchKit2Extension.aotdata.armv7k",
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/Watch/MyWatchApp2.app/PlugIns/MyWatchKit2Extension.appex/_CodeSignature/CodeResources",
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/Watch/MyWatchApp2.app/PlugIns/MyWatchKit2Extension.appex/PlugIns/MyWatchKit2IntentsExtension.appex/MyWatchKit2IntentsExtension",
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app/Watch/MyWatchApp2.app/PlugIns/MyWatchKit2Extension.appex/PlugIns/MyWatchKit2IntentsExtension.appex/_CodeSignature/CodeResources",
						$"../MyWatch2Container/bin/{Platform}/{config}/MyWatch2Container.app.dSYM/Contents/Info.plist",
					});
				}
				RebuildAssertModifications (captured, "MyWatch2Container", expectedCodesignResults, expectedModifications.ToArray (), out captured, "Rebuild 1");
			});
		}

		[Test]
		public void CodesignAfterModifyingAppExtensionTest2 ()
		{
			var expectedCodesignResults = Platform != "iPhoneSimulator";
			var project = "MyExtensionContainer";
			var extension1 = "MySharedLinksExtension";
			var extension2 = "MySpotlightIndexExtension";
			var addedFiles = new List<string> ();

			// Initial build
			BuildProject (project, Platform, config, clean: true);
			AssertProperlyCodesigned (expectedCodesignResults, "First build");

			var captured = CaptureTimestamps ();

			// Add a file to one extension's build
			addedFiles.Add ($"{extension1}_ExtraCompileInclude");
			ExecuteWithFileAddedToBuild (addedFiles, () => {
				var expectedModifications = new List<string> {
					$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/{extension1}.dll",
					$"../{project}/bin/{Platform}/{config}/mtouch.stamp",
				};
				if (config == "Debug") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/{extension1}.pdb",
					});
				}
				if (Platform == "iPhone") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/{project}.app/{project}",
						$"../{project}/bin/{Platform}/{config}/{project}.app/_CodeSignature/CodeResources",
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/{extension1}",
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/_CodeSignature/CodeResources",
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/{extension1}.aotdata.arm64",
						//?$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/{extension1}.aotdata.armv7",
						$"../{project}/bin/{Platform}/{config}/{project}.app.dSYM/Contents/Info.plist",
						$"../{project}/bin/{Platform}/{config}/{extension1}.appex.dSYM/Contents/Info.plist",
						$"../{project}/bin/{Platform}/{config}/{extension1}.appex.dSYM/Contents/Resources/DWARF/{extension1}",
					});
					if (config == "Debug") {
						expectedModifications.AddRange (new[] {
							$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/lib{extension1}.dll.dylib",
						});
					} else {
						expectedModifications.AddRange (new[] {
							$"../{project}/bin/{Platform}/{config}/{project}.app.mSYM/.*",
						});
					}
				}
				RebuildAssertModifications (captured, project, expectedCodesignResults, expectedModifications, out captured, "Rebuild extension 1");

				// Rebuild again with no changes
				expectedModifications.Clear ();

				if (Platform == "iPhoneSimulator") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/mtouch.stamp", // This is a bug somewhere: nothing should have changed. Still, it's a fairly benign problem, since the .app isn't affected.
					});
				}
				RebuildAssertModifications (captured, project, expectedCodesignResults, expectedModifications, out captured, "Rebuild extension 1 twice");
			});

			// Add a file to the other extension's build
			addedFiles.Add ($"{extension2}_ExtraCompileInclude");
			ExecuteWithFileAddedToBuild (addedFiles, () => {
				var expectedModifications = new List<string> {
					$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension2}.appex/{extension2}.dll",
					$"../{project}/bin/{Platform}/{config}/mtouch.stamp",
				};
				if (config == "Debug") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension2}.appex/{extension2}.pdb",
					});
				}
				if (Platform == "iPhone") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/{project}.app/{project}",
						$"../{project}/bin/{Platform}/{config}/{project}.app/_CodeSignature/CodeResources",
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension2}.appex/{extension2}",
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension2}.appex/_CodeSignature/CodeResources",
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension2}.appex/{extension2}.aotdata.arm64",
						//?$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension2}.appex/{extension2}.aotdata.armv7",
						$"../{project}/bin/{Platform}/{config}/{project}.app.dSYM/Contents/Info.plist",
						$"../{project}/bin/{Platform}/{config}/{extension2}.appex.dSYM/Contents/Info.plist",
						$"../{project}/bin/{Platform}/{config}/{extension2}.appex.dSYM/Contents/Resources/DWARF/{extension2}",
					});
					if (config == "Debug") {
						expectedModifications.AddRange (new[] {
							$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension2}.appex/lib{extension2}.dll.dylib",
						});
					} else {
						expectedModifications.AddRange (new[] {
							$"../{project}/bin/{Platform}/{config}/{project}.app.mSYM/manifest.xml",
						});
					}
				}
				RebuildAssertModifications (captured, project, expectedCodesignResults, expectedModifications, out captured, "Rebuild extension 2");

				// Rebuild again with no changes
				expectedModifications.Clear ();
				//if (Platform == "iPhoneSimulator") {
					expectedModifications.AddRange (new [] {
						$"../{project}/bin/{Platform}/{config}/mtouch.stamp", // This is a bug somewhere: nothing should have changed. Still, it's a fairly benign problem, since the .app isn't affected.
					});
				if (Platform == "iPhone" && config == "Release") {
					expectedModifications.AddRange (new [] {
						$"../{project}/bin/{Platform}/{config}/{project}.app.mSYM/manifest.xml",
					});
				}
				//}
				RebuildAssertModifications (captured, project, expectedCodesignResults, expectedModifications, out captured, "Rebuild extension 2 twice");
			});

			// Add a file to the main project's build. None of the extensions should change.
			addedFiles.Add ($"{project}_ExtraCompileInclude");
			ExecuteWithFileAddedToBuild (addedFiles, () => {
				var expectedModifications = new List<string> {
					$"../{project}/bin/{Platform}/{config}/{project}.exe",
					$"../{project}/bin/{Platform}/{config}/{project}.app/{project}.exe",
					$"../{project}/bin/{Platform}/{config}/mtouch.stamp",
					$"../{project}/bin/{Platform}/{config}/{project}.pdb",
				};
				if (config == "Debug") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/{project}.app/{project}.pdb",
					});
				}
				if (Platform == "iPhone") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/{project}.app/{project}",
						$"../{project}/bin/{Platform}/{config}/{project}.app/_CodeSignature/CodeResources",
						$"../{project}/bin/{Platform}/{config}/{project}.app/{project}.aotdata.armv7",
						$"../{project}/bin/{Platform}/{config}/{project}.app/{project}.aotdata.arm64",
						$"../{project}/bin/{Platform}/{config}/{project}.app.dSYM/Contents/Info.plist",
						$"../{project}/bin/{Platform}/{config}/{project}.app.dSYM/Contents/Resources/DWARF/{project}",
					});
					if (config == "Release") {
						expectedModifications.AddRange (new[] {
							$"../{project}/bin/{Platform}/{config}/{project}.app.mSYM/.*",
						});
					}
				}
				RebuildAssertModifications (captured, project, expectedCodesignResults, expectedModifications, out captured, "Rebuild container 1");

				// Rebuild again with no changes
				expectedModifications = new List<string> {
					// This is a bug somewhere: nothing should change this time.
					$"../{project}/bin/{Platform}/{config}/mtouch.stamp",
				};
				if (Platform == "iPhone" && config == "Release") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/{project}.app.mSYM/.*",
					});
				}
				RebuildAssertModifications (captured, project, expectedCodesignResults, expectedModifications, out captured, "Rebuild container 1 twice");
			});

			// Touch an extension's Info.plist
			Touch (Path.Combine (Configuration.RootPath, "msbuild", "tests", extension1, "Info.plist"));
			ExecuteWithFileAddedToBuild (addedFiles, () => {
				var expectedModifications = new List<string> {
					$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/Info.plist",
					$"../{project}/bin/{Platform}/{config}/mtouch.stamp",
					$"../{project}/bin/{Platform}/{config}/{project}.exe", // why was this modified?
					$"../{project}/bin/{Platform}/{config}/{project}.pdb", // why was this modified?
				};
				if (Platform == "iPhone") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/{project}.app/{project}",
						$"../{project}/bin/{Platform}/{config}/{project}.app/_CodeSignature/CodeResources",
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/Info.plist",
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/_CodeSignature/CodeResources",
						$"../{project}/bin/{Platform}/{config}/{project}.app/PlugIns/{extension1}.appex/{extension1}",
						$"../{project}/bin/{Platform}/{config}/{project}.app.dSYM/Contents/Info.plist",
						$"../{project}/bin/{Platform}/{config}/{extension1}.appex.dSYM/Contents/Info.plist",
						$"../{project}/bin/{Platform}/{config}/{extension1}.appex.dSYM/Contents/Resources/DWARF/{extension1}",
					});
					if (config == "Release") {
						expectedModifications.AddRange (new[] {
							$"../{project}/bin/{Platform}/{config}/{project}.app.mSYM/.*",
						});
					}
				}

				RebuildAssertModifications (captured, project, expectedCodesignResults, expectedModifications, out captured, "Rebuild extension 3");

				expectedModifications = new List<string> {
					$"../{project}/bin/{Platform}/{config}/mtouch.stamp", // This is a bug somewhere: nothing should have changed. Still, it's a fairly benign problem, since the .app isn't affected.
				};
				if (Platform == "iPhone" && config == "Release") {
					expectedModifications.AddRange (new[] {
						$"../{project}/bin/{Platform}/{config}/{project}.app.mSYM/.*",
					});
				}
				RebuildAssertModifications (captured, project, expectedCodesignResults, expectedModifications, out captured, "Rebuild extension 3 twice");
			});
		}

	}
}
