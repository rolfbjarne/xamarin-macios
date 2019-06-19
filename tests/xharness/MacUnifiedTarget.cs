using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

using Xamarin;

namespace xharness
{
	public class MacUnifiedTarget : Target {
		public MacFlavors Flavor { get; private set; }
		public bool Modern => Flavor == MacFlavors.Modern;
		public bool System => Flavor == MacFlavors.System;
		public bool Full => Flavor == MacFlavors.Full;

		// Optional
		public MacBCLTestInfo BCLInfo { get; set; }
		bool IsBCL => BCLInfo != null;

		public MacUnifiedTarget (MacFlavors flavor)
		{
			Flavor = flavor;
		}

		protected override void CalculateName ()
		{
			base.CalculateName ();

			if (MonoNativeInfo != null)
				Name = Name + MonoNativeInfo.FlavorSuffix;
		}

		public override string Suffix {
			get {
				switch (Flavor) {
				case MacFlavors.Modern:
					return string.Empty;
				case MacFlavors.Full:
					return "-full";
				case MacFlavors.System:
					return "-system";
				default:
					throw new NotImplementedException ($"Suffix for {Flavor}");
				}
			}
		}

		public override string MakefileWhereSuffix {
			get {
				if (System)
					return "system";
				if (Full)
					return "full";
				return string.Empty;
			}
		}
			
		protected override string ProjectTypeGuids {
			get {
				return "{A3F8F2AB-B479-4A4A-A458-A89E7DC349F1};" + LanguageGuid;
			}
		}

		protected override string BindingsProjectTypeGuids {
			get {
				return "{810C163F-4746-4721-8B8E-88A3673A62EA}";
			}
		}

		protected override string TargetFrameworkIdentifier {
			get {
				return "Xamarin.Mac";
			}
		}

		protected override string Imports {
			get {
				return IsFSharp ? "Mac\\Xamarin.Mac.FSharp.targets" : "Mac\\Xamarin.Mac.CSharp.targets";
			}
		}

		protected override string BindingsImports {
			get {
				return "Mac\\Xamarin.Mac.ObjcBinding.CSharp";
			}
		}

		protected override string AdditionalDefines {
			get {
				var rv = "XAMCORE_2_0";

				if (Full)
					rv += ";XAMMAC_4_5";

				return rv;
			}
		}

		public override bool IsMultiArchitecture {
			get {
				return true;
			}
		}

		public override string Platform {
			get {
				return "mac";
			}
		}

		public string SimplifiedName {
			get {
				return Name.EndsWith ("-mac", StringComparison.Ordinal) ? Name.Substring (0, Name.Length - 4) : Name;
			}
		}

		public MonoNativeInfo MonoNativeInfo { get; set; }

		protected override bool FixProjectReference (string name, out string fixed_reference)
		{
			fixed_reference = null;
			switch (name) {
			case "GuiUnit_NET_4_5":
				if (Flavor == MacFlavors.Full || Flavor == MacFlavors.System)
					return false;
				fixed_reference = "GuiUnit_xammac_mobile";
				return true;
			case "GuiUnit_xammac_mobile":
				if (Flavor == MacFlavors.Modern)
					return false;
				fixed_reference = "GuiUnit_NET_4_5";
				return true;
			default:
				return base.FixProjectReference (name, out fixed_reference);
			}
		}
	
		public override string DefaultAssemblyReference { get { return "Xamarin.Mac"; } }

		public override IEnumerable<string> ReferenceToRemove { get { yield return "System.Drawing"; } }

		public override bool ShouldSetTargetFrameworkIdentifier { get { return Modern; } }

		public override Dictionary<string, string> NewPropertiesToAdd 
		{
			get 
			{
				var props = new Dictionary<string, string> ();


				if (System) {
					props.Add ("TargetFrameworkVersion", "v4.7.1");
					props.Add ("MonoBundlingExtraArgs", "--embed-mono=no");
				} else if (Modern)
				{
					props.Add ("TargetFrameworkVersion", "v2.0");
				}
				else
				{
					props.Add ("TargetFrameworkVersion", "v4.5");
					props.Add ("UseXamMacFullFramework", "true");
				}

				props.Add ("XamMacArch", "x86_64");
				return props;
			}
		}

		public override HashSet<string> PropertiesToRemove {
			get {
				if (!ShouldSetTargetFrameworkIdentifier)
					return new HashSet<string> { "TargetFrameworkIdentifier" };
				return null;
			}
		}

		protected override string GetMinimumOSVersion (string templateMinimumOSVersion)
		{
			if (MonoNativeInfo == null)
				return templateMinimumOSVersion;
			return MonoNativeHelper.GetMinimumOSVersion (DevicePlatform.macOS, MonoNativeInfo.Flavor);
		}

		protected override void ProcessProject ()
		{
			base.ProcessProject ();

			if (MonoNativeInfo == null)
				return;

			MonoNativeInfo.AddProjectDefines (inputProject);
			inputProject.AddAdditionalDefines ("MONO_NATIVE_MAC");

			XmlDocument info_plist = new XmlDocument ();
			var target_info_plist = Path.Combine (TargetDirectory, "Info" + Suffix + ".plist");
			info_plist.LoadWithoutNetworkAccess (Path.Combine (TargetDirectory, inputProject.GetInfoPListInclude ()));
			BundleIdentifier = info_plist.GetCFBundleIdentifier ();
			var plist_min_version = info_plist.GetPListStringValue ("LSMinimumSystemVersion");
			info_plist.SetPListStringValue ("LSMinimumSystemVersion", GetMinimumOSVersion (plist_min_version));

			Harness.Save (info_plist, target_info_plist);
		}
	}
}
