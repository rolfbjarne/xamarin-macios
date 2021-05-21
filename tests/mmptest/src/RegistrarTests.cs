using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using Xamarin.Tests;

namespace Xamarin.MMP.Tests
{
	[TestFixture]
	public class RegistrarTests
	{
		[TestCase (false, "x86_64")]
		[TestCase (true, "x86_64")]
		public void SmokeTest (bool full, string arch)
		{
			if (!PlatformHelpers.CheckSystemVersion (10, 11))
				return;

			MMPTests.RunMMPTest (tmpDir => {
				// First in 64-bit
				TI.UnifiedTestConfig test = new TI.UnifiedTestConfig (tmpDir) {
					CSProjConfig = $"<MonoBundlingExtraArgs>--registrar=static</MonoBundlingExtraArgs><XamMacArch>{arch}</XamMacArch>",
					XM45 = full
				};
				var output = TI.TestUnifiedExecutable (test).RunOutput;

				Assert.IsTrue (!output.Contains ("Could not register the assembly"), "Could not register the assembly errors found:\n" + output);
			});
		}

		[TestCase (false, "x86_64")]
		[TestCase (true, "x86_64")]
		public void DirectoryContainsSpaces (bool full, string arch)
		{
			if (!PlatformHelpers.CheckSystemVersion (10, 11))
				return;

			MMPTests.RunMMPTest (tmpDir => {
				TI.UnifiedTestConfig test = new TI.UnifiedTestConfig (tmpDir) {
					CSProjConfig = $"<MonoBundlingExtraArgs>--registrar=static</MonoBundlingExtraArgs><XamMacArch>{arch}</XamMacArch>",
					XM45 = full
				};
			}, "test withSpace");
		}

		[Test]
		public void VeryManyRegisteredAssemblies ()
		{
			MMPTests.RunMMPTest (tmpDir => {

				var assemblies = 200;

				var xm = Configuration.XamarinMacMobileDll;
				var csc = "/Library/Frameworks/Mono.framework/Commands/csc";

				Parallel.ForEach (Enumerable.Range (0, assemblies), (number) => {
					var cs = $"public class C{number} : Foundation.NSObject {{}}";
					var fn = Path.Combine (tmpDir, $"C{number}.cs");
					File.WriteAllText (fn, cs);
					var args = new string [] {
						fn,
						"-target:library",
						"-out:" + Path.Combine (tmpDir, $"C{number}.dll"),
						"-r:" + xm,
					};
					TI.RunAndAssert (csc, args);
				});

				var testCode = new StringBuilder ();
				for (var i = 0; i < assemblies; i++)
					testCode.AppendLine ($"\t\tSystem.Console.WriteLine (new C{i} ().Handle);");

				var references = new StringBuilder ();
				for (var i = 0; i < assemblies; i++)
					references.Append ($"\t\t<Reference Include=\"C{i}\"><HintPath>{Path.Combine (tmpDir, $"C{i}.dll")}</HintPath></Reference>\n");

				var test = new TI.UnifiedTestConfig (tmpDir) {
					CSProjConfig = "<MonoBundlingExtraArgs>--registrar=static --optimize:remove-dynamic-registrar</MonoBundlingExtraArgs>\n<LinkMode>Full</LinkMode>",
					References = references.ToString (),
					TestCode = testCode.ToString (),
				};
				TI.TestUnifiedExecutable (test);
			});

		}
	}
}
