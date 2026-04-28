// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Microsoft.Build.Framework;

using Xamarin.Bundler;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	/// <summary>
	/// Performs post-trimming processing, generating native code only for symbols that survived trimming.
	/// See docs/code/native-symbols.md for an overview of native symbol handling.
	/// </summary>
	public class PostTrimmingProcessing : XamarinTask {
		[Required]
		public string Architecture { get; set; } = "";

		[Required]
		public string OutputDirectory { get; set; } = "";

		public ITaskItem [] ReferenceNativeSymbol { get; set; } = [];

		/// <summary>
		/// Files listing native symbols that survived trimming. Each file contains one symbol name per line.
		/// These can come from either ILTrim (CollectPostILTrimInformation) or NativeAOT
		/// (ComputeNativeAOTSurvivingNativeSymbols).
		/// </summary>
		public ITaskItem [] SurvivingNativeSymbolsFiles { get; set; } = [];

		/// <summary>
		/// Output native source files to be compiled and linked.
		/// </summary>
		[Output]
		public ITaskItem []? NativeSourceFiles { get; set; }

		/// <summary>
		/// Output list of ReferenceNativeSymbol items that were trimmed away and should be removed
		/// from the linker's -u flags to avoid linking symbols that are no longer needed.
		/// </summary>
		[Output]
		public ITaskItem []? TrimmedReferenceNativeSymbols { get; set; }

		HashSet<string>? ignoredSymbols;

		HashSet<string> IgnoredSymbols {
			get {
				if (ignoredSymbols is null) {
					ignoredSymbols = new HashSet<string> ();
					foreach (var rns in ReferenceNativeSymbol) {
						var nativeSymbol = rns.ItemSpec;
						var symbolMode = rns.GetMetadata ("SymbolMode");
						if (!string.Equals (symbolMode, "Ignore", StringComparison.OrdinalIgnoreCase))
							continue;
						var symbolType = rns.GetMetadata ("SymbolType").ToLowerInvariant ();
						switch (symbolMode) {
						case "objectivecclass":
							nativeSymbol = Symbol.ObjectiveCPrefix + nativeSymbol;
							break;
						case "function":
						case "field":
							break;
						default:
							Log.LogMessage (MessageImportance.Low, "Ignoring symbol '{0}' with unknown SymbolType '{1}'", nativeSymbol, symbolType);
							continue;
						}
						ignoredSymbols.Add (nativeSymbol);
					}
				}
				return ignoredSymbols;
			}
		}

		public override bool Execute ()
		{
			var items = new List<ITaskItem> ();

			var survivingSymbols = GenerateInlinedDlfcnNativeCode (items);

			NativeSourceFiles = items.ToArray ();

			// Compute which ReferenceNativeSymbol items are inlined dlfcn symbols that were trimmed away.
			if (survivingSymbols is not null) {
				const string prefix = "_xamarin_Dlfcn_";
				const string suffix = "_Native";
				var trimmedItems = new List<ITaskItem> ();
				foreach (var rns in ReferenceNativeSymbol) {
					var symbol = rns.ItemSpec;
					if (!symbol.StartsWith (prefix) || !symbol.EndsWith (suffix))
						continue;
					var fieldName = symbol.Substring (prefix.Length, symbol.Length - prefix.Length - suffix.Length);
					if (!survivingSymbols.Contains (fieldName)) {
						trimmedItems.Add (rns);
					}
				}
				TrimmedReferenceNativeSymbols = trimmedItems.ToArray ();
				if (TrimmedReferenceNativeSymbols.Length > 0)
					Log.LogMessage (MessageImportance.Low, "Removed {0} trimmed dlfcn symbols from ReferenceNativeSymbol", TrimmedReferenceNativeSymbols.Length);
			}

			return !Log.HasLoggedErrors;
		}

		HashSet<string>? GenerateInlinedDlfcnNativeCode (List<ITaskItem> items)
		{
			// Collect all surviving symbols from all input files.
			var survivingSymbols = new HashSet<string> ();
			foreach (var file in SurvivingNativeSymbolsFiles) {
				var path = file.ItemSpec;
				if (!File.Exists (path))
					continue;
				survivingSymbols.UnionWith (File.ReadAllLines (path));
			}

			var survivingButIgnoredSymbols = survivingSymbols.Intersect (IgnoredSymbols).ToList ();
			if (survivingButIgnoredSymbols.Count > 0) {
				Log.LogMessage (MessageImportance.Low, "The following symbols survived trimming but are marked as ignored:");
				foreach (var symbol in survivingButIgnoredSymbols)
					Log.LogMessage (MessageImportance.Low, "  {0}", symbol);
				survivingSymbols.ExceptWith (survivingButIgnoredSymbols);
			}

			if (survivingSymbols.Count == 0) {
				Log.LogMessage (MessageImportance.Low, "There were no surviving symbols that require inlined dlfcn native code.");
				return survivingSymbols;
			}

			Directory.CreateDirectory (OutputDirectory);
			var outputPath = Path.Combine (OutputDirectory, "inlined-dlfcn.c");

			var sb = new StringBuilder ();
			foreach (var field in survivingSymbols.Where (s => s.Length > 0).OrderBy (s => s)) {
				sb.AppendLine ($"extern void* {field};");
				sb.AppendLine ($"void* xamarin_Dlfcn_{field}_Native ();");
				sb.AppendLine ($"void* xamarin_Dlfcn_{field}_Native () {{ return &{field}; }}");
				sb.AppendLine ();
			}

			var content = sb.ToString ();
			if (File.Exists (outputPath) && File.ReadAllText (outputPath) == content) {
				Log.LogMessage (MessageImportance.Low, "Inlined dlfcn native code is up to date");
			} else {
				File.WriteAllText (outputPath, content);
				Log.LogMessage (MessageImportance.Low, "Generated inlined dlfcn native code with {0} symbols", survivingSymbols.Count);
			}

			var item = new Microsoft.Build.Utilities.TaskItem (outputPath);
			item.SetMetadata ("Arch", Architecture.ToLowerInvariant ());
			items.Add (item);
			return survivingSymbols;
		}
	}
}
