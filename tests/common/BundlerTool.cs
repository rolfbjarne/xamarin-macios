using System;
using System.IO;
using System.Linq;
using System.Text;

using NUnit.Framework;

using Xamarin.Utils;

namespace Xamarin.Tests
{
	public enum LinkerOption
	{
		Unspecified,
		LinkAll,
		LinkSdk,
		DontLink,
	}

	// This class represents options/logic that is identical between mtouch and mmp
	abstract class BundlerTool : Tool
	{
		public const string None = "None";

#pragma warning disable 0649 // Field 'X' is never assigned to, and will always have its default value Y
		public string Cache;
		public LinkerOption Linker;
		public string [] Optimize;
		public Profile Profile;
		public string RootAssembly;
		public string SdkRoot;
		public int Verbosity;
#pragma warning restore 0649

		protected string GetVerbosity ()
		{
			if (Verbosity == 0) {
				return string.Empty;
			} else if (Verbosity > 0) {
				return new string ('-', Verbosity).Replace ("-", "-v ");
			} else {
				return new string ('-', -Verbosity).Replace ("-", "-q ");
			}
		}

		protected string ToolArguments {
			get {
				var sb = new StringBuilder ();
				BuildArguments (sb);
				return sb.ToString ();
			}
		}

		protected virtual void BuildArguments (StringBuilder sb)
		{
			switch (Linker) {
			case LinkerOption.LinkAll:
			case LinkerOption.Unspecified:
				break;
			case LinkerOption.DontLink:
				sb.Append (" --nolink");
				break;
			case LinkerOption.LinkSdk:
				sb.Append (" --linksdkonly");
				break;
			default:
				throw new NotImplementedException ();
			}

			if (Optimize != null) {
				foreach (var opt in Optimize)
					sb.Append (" --optimize:").Append (opt);
			}

			if (!string.IsNullOrEmpty (RootAssembly))
				sb.Append (" ").Append (StringUtils.Quote (RootAssembly));

			if (SdkRoot == None) {
				// do nothing
			} else if (!string.IsNullOrEmpty (SdkRoot)) {
				sb.Append (" --sdkroot ").Append (StringUtils.Quote (SdkRoot));
			} else {
				sb.Append (" --sdkroot ").Append (StringUtils.Quote (Configuration.xcode_root));
			}

		}

		public string CreateTemporaryDirectory ()
		{
			return Xamarin.Cache.CreateTemporaryDirectory ();
		}

		public void CreateTemporaryCacheDirectory ()
		{
			Cache = Path.Combine (CreateTemporaryDirectory (), "mtouch-test-cache");
			Directory.CreateDirectory (Cache);
		}

		public virtual int Execute ()
		{
			return Execute (ToolArguments, always_show_output: Verbosity > 0);
		}

		public virtual void AssertExecute (string message = null)
		{
			var rv = Execute ();
			if (rv == 0)
				return;
			var errors = Messages.Where ((v) => v.IsError).ToList ();
			Assert.Fail ($"Expected execution to succeed, but exit code was {rv}, and there were {errors.Count} error(s): {message}\n\t" +
				     string.Join ("\n\t", errors.Select ((v) => v.ToString ())));
		}

		public abstract void CreateTemporaryApp (Profile profile, string appName = "testApp", string code = null, string extraArg = "", string extraCode = null, string usings = null, bool use_csc = false);

		public static string CompileTestAppExecutable (string targetDirectory, string code = null, string extraArg = "", Profile profile = Profile.iOS, string appName = "testApp", string extraCode = null, string usings = null, bool use_csc = false)
		{
			if (code == null)
				code = "public class TestApp { static void Main () { System.Console.WriteLine (typeof (ObjCRuntime.Runtime).ToString ()); } }";
			if (usings != null)
				code = usings + "\n" + code;
			if (extraCode != null)
				code += extraCode;

			return CompileTestAppCode ("exe", targetDirectory, code, extraArg, profile, appName, use_csc);
		}

		public static string CompileTestAppLibrary (string targetDirectory, string code, string extraArg = null, Profile profile = Profile.iOS, string appName = "testApp")
		{
			return CompileTestAppCode ("library", targetDirectory, code, extraArg, profile, appName);
		}

		public static string CompileTestAppCode (string target, string targetDirectory, string code, string extraArg = "", Profile profile = Profile.iOS, string appName = "testApp", bool use_csc = false)
		{
			var ext = target == "exe" ? "exe" : "dll";
			var cs = Path.Combine (targetDirectory, "testApp.cs");
			var assembly = Path.Combine (targetDirectory, appName + "." + ext);
			var root_library = Configuration.GetBaseLibrary (profile);

			File.WriteAllText (cs, code);

			string output;
			StringBuilder args = new StringBuilder ();
			string fileName = Configuration.GetCompiler (profile, args, use_csc);
			args.AppendFormat ($" /noconfig /t:{target} /nologo /out:{StringUtils.Quote (assembly)} /r:{StringUtils.Quote (root_library)} {StringUtils.Quote (cs)} {extraArg}");
			if (ExecutionHelper.Execute (fileName, args.ToString (), out output) != 0) {
				Console.WriteLine ("{0} {1}", fileName, args);
				Console.WriteLine (output);
				throw new Exception (output);
			}

			return assembly;
		}
	}
}
