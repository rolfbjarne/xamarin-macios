using System;
using System.IO;
using System.Text;

using Xamarin.Tests;

namespace Xamarin
{
	class XHarnessTool : Tool, IDisposable
	{
#pragma warning disable 649
		public string Target;
		public string LogDirectory;
		public string Configuration;
		public string SdkRoot;
#pragma warning restore 649

		public string XHarnessPath {
			get {
				return Path.Combine (Xamarin.Tests.Configuration.SourceRoot, "tests", "xharness", "xharness.exe");
			}
		}

		protected override string ToolPath {
			get {
				return "mono";
			}
		}

		public int Run (string project_directory)
		{
			var sb = new StringBuilder ();
			sb.Append (MTouch.Quote (XHarnessPath));
			sb.Append (" --run ").Append (MTouch.Quote (project_directory));
			sb.Append (" --target ").Append (Target);

			if (SdkRoot == MTouchTool.None) {
				// do nothing
			} else if (!string.IsNullOrEmpty (SdkRoot)) {
				sb.Append (" --sdkroot ").Append (MTouch.Quote (SdkRoot));
			} else {
				sb.Append (" --sdkroot ").Append (MTouch.Quote (Xamarin.Tests.Configuration.xcode_root));
			}

			sb.Append (" --logdirectory ").Append (MTouch.Quote (LogDirectory));
			sb.Append (" --configuration ").Append (Configuration);
			sb.Append (" --verbose");
			return Execute (sb.ToString ());
		}

		public int Install (string project_file)
		{
			var sb = new StringBuilder ();
			sb.Append (MTouch.Quote (XHarnessPath));
			sb.Append (" --install ").Append (MTouch.Quote (project_file));
			sb.Append (" --target ").Append (Target);

			if (SdkRoot == MTouchTool.None) {
				// do nothing
			} else if (!string.IsNullOrEmpty (SdkRoot)) {
				sb.Append (" --sdkroot ").Append (MTouch.Quote (SdkRoot));
			} else {
				sb.Append (" --sdkroot ").Append (MTouch.Quote (Xamarin.Tests.Configuration.xcode_root));
			}

			sb.Append (" --logdirectory ").Append (MTouch.Quote (LogDirectory));
			sb.Append (" --configuration ").Append (Configuration);
			sb.Append (" --verbose");
			return Execute (sb.ToString ());
		}
		void IDisposable.Dispose ()
		{
		}
	}
}
