﻿//
// MmpTask.cs
//
// Author:
//   Aaron Bockover <abock@xamarin.com>
//
// Copyright 2014 Xamarin Inc.

using System;
using System.IO;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.MacDev.Tasks;
using Xamarin.MacDev;
using Xamarin.Utils;

namespace Xamarin.Mac.Tasks
{
	public class MmpTaskBase : BundlerToolTaskBase
	{
		protected override string ToolName {
			get { return "mmp"; }
		}

		public bool IsXPCService { get; set; }

		public bool UseXamMacFullFramework { get; set; }

		public string ApplicationName { get; set; }
		public string Architecture { get; set; }

		public string AotMode { get; set; }
		public bool HybridAOT { get; set; }
		public string ExplicitAotAssemblies { get; set; }

		[Output]
		public ITaskItem[] NativeLibraries { get; set; }

		protected override bool ValidateParameters ()
		{
			XamMacArch arch;

			return Enum.TryParse (Architecture, true, out arch);
		}

		protected override string GenerateCommandLineCommands ()
		{
			var args = GenerateCommandLineArguments ();

			if (!string.IsNullOrEmpty (OutputPath))
				args.AddQuotedLine ("/output:" + Path.GetFullPath (OutputPath));

			if (!string.IsNullOrEmpty (ApplicationName))
				args.AddQuotedLine ("/name:" + ApplicationName);

			if (TargetFrameworkIdentifier == "Xamarin.Mac")
				args.AddLine ("/profile:Xamarin.Mac,Version=v2.0,Profile=Mobile");
			else if (UseXamMacFullFramework)
				args.AddLine ($"/profile:Xamarin.Mac,Version={TargetFrameworkVersion},Profile=Full");
			else
				args.AddLine ($"/profile:Xamarin.Mac,Version={TargetFrameworkVersion},Profile=System");

			XamMacArch arch;
			if (!Enum.TryParse (Architecture, true, out arch))
				arch = XamMacArch.Default;

			if (arch == XamMacArch.Default)
				arch = XamMacArch.x86_64;

			if (arch.HasFlag (XamMacArch.i386))
				args.AddLine ("/arch:i386");

			if (arch.HasFlag (XamMacArch.x86_64))
				args.AddLine ("/arch:x86_64");

			if (AppManifest != null) {
				try {
					var plist = PDictionary.FromFile (AppManifest.ItemSpec);

					PString v;
					string minimumDeploymentTarget;

					if (!plist.TryGetValue (ManifestKeys.LSMinimumSystemVersion, out v) || string.IsNullOrEmpty (v.Value))
						minimumDeploymentTarget = SdkVersion;
					else
						minimumDeploymentTarget = v.Value;

					args.AddLine (string.Format("/minos={0}", minimumDeploymentTarget));
				}
				catch (Exception ex) {
					Log.LogWarning (null, null, null, AppManifest.ItemSpec, 0, 0, 0, 0, "Error loading '{0}': {1}", AppManifest.ItemSpec, ex.Message);
				}
			}

			switch ((LinkMode ?? string.Empty).ToLower ()) {
			case "full":
				break;
			case "sdkonly":
				args.AddLine ("/linksdkonly");
				break;
			case "platform":
				args.AddLine ("/linkplatform");
				break;
			default:
				args.AddLine ("/nolink");
				break;
			}

			if (!string.IsNullOrEmpty (AotMode) && AotMode != "None") {
				var aot = $"--aot:{AotMode.ToLower ()}";
				if (HybridAOT)
					aot += "|hybrid";

				if (!string.IsNullOrEmpty (ExplicitAotAssemblies))
					aot += $",{ExplicitAotAssemblies}";

				args.AddLine (aot);
			}

			if (References != null) {
				foreach (var asm in References)
					args.AddQuotedLine ("/assembly:" + Path.GetFullPath (asm.ItemSpec));
			}

			if (NativeReferences != null) {
				foreach (var nr in NativeReferences)
					args.AddQuotedLine ("/native-reference:" + Path.GetFullPath (nr.ItemSpec));
			}
				
			if (IsAppExtension)
				args.AddQuotedLine ("/extension");
			if (IsXPCService)
				args.AddQuotedLine ("/xpc");

			return CreateResponseFile (args, ExtraArgs == null ? null : CommandLineArgumentBuilder.Parse (ExtraArgs));
		}

		string GetMonoBundleDirName ()
		{
			if (!string.IsNullOrEmpty (ExtraArgs)) {
				var args = CommandLineArgumentBuilder.Parse (ExtraArgs);

				for (int i = 0; i < args.Length; i++) {
					string arg;

					if (string.IsNullOrEmpty (args[i]))
						continue;

					if (args[i][0] == '/') {
						arg = args[i].Substring (1);
					} else if (args[i][0] == '-') {
						if (args[i].Length >= 2 && args[i][1] == '-')
							arg = args[i].Substring (2);
						else
							arg = args[i].Substring (1);
					} else {
						continue;
					}

					if (arg.StartsWith ("custom_bundle_name:", StringComparison.Ordinal) ||
					    arg.StartsWith ("custom_bundle_name=", StringComparison.Ordinal))
						return arg.Substring ("custom_bundle_name=".Length);

					if (arg == "custom_bundle_name" && i + 1 < args.Length)
						return args[i + 1];
				}
			}

			return "MonoBundle";
		}

		public override bool Execute ()
		{
			if (!base.Execute ())
				return false;

			var monoBundleDir = Path.Combine (AppBundleDir, "Contents", GetMonoBundleDirName ());

			try {
				var nativeLibrariesPath = Directory.EnumerateFiles (monoBundleDir, "*.dylib", SearchOption.AllDirectories);
				var nativeLibraryItems = new List<ITaskItem> ();

				foreach (var nativeLibrary in nativeLibrariesPath) {
					nativeLibraryItems.Add (new TaskItem (nativeLibrary));
				}

				NativeLibraries = nativeLibraryItems.ToArray ();
			} catch (Exception ex) {
				Log.LogError (null, null, null, AppBundleDir, 0, 0, 0, 0, "Could not get native libraries: {0}", ex.Message);
				return false;
			}

			return !Log.HasLoggedErrors;
		}

		protected override void LogEventsFromTextOutput (string singleLine, MessageImportance messageImportance)
		{
			try { // We first try to use the base logic, which shows up nicely in XS.
				base.LogEventsFromTextOutput (singleLine, messageImportance);
			}
			catch { // But when that fails, just output the message to the command line and XS will output it raw
				Log.LogMessage (messageImportance, "{0}", singleLine);
			}
		}
	}
}
