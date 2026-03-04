using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Microsoft.Build.Framework;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	/// <summary>
	/// Performs post-trimming processing, generating native code only for symbols that survived trimming.
	/// See docs/code/native-symbols.md for an overview of native symbol handling.
	/// </summary>
	public class PostTrimmingProcessing : XamarinTask {
		/// <summary>
		/// Files listing native symbols that survived trimming. Each file contains one symbol name per line.
		/// These can come from either ILTrim (CollectPostILTrimInformation) or NativeAOT
		/// (ComputeNativeAOTSurvivingNativeSymbols).
		/// </summary>
		public ITaskItem [] SurvivingNativeSymbolsFiles { get; set; } = [];

		[Required]
		public string OutputDirectory { get; set; } = "";

		[Required]
		public string Architecture { get; set; } = "";

		/// <summary>
		/// Output native source files to be compiled and linked.
		/// </summary>
		[Output]
		public ITaskItem []? NativeSourceFiles { get; set; }

		public override bool Execute ()
		{
			var items = new List<ITaskItem> ();

			GenerateInlinedDlfcnNativeCode (items);

			NativeSourceFiles = items.ToArray ();
			return !Log.HasLoggedErrors;
		}

		void GenerateInlinedDlfcnNativeCode (List<ITaskItem> items)
		{
			// Collect all surviving symbols from all input files.
			var survivingSymbols = new HashSet<string> ();
			foreach (var file in SurvivingNativeSymbolsFiles) {
				var path = file.ItemSpec;
				if (!File.Exists (path))
					continue;
				foreach (var line in File.ReadAllLines (path)) {
					if (line.Length > 0)
						survivingSymbols.Add (line);
				}
			}

			if (survivingSymbols.Count == 0)
				return;

			Directory.CreateDirectory (OutputDirectory);
			var outputPath = Path.Combine (OutputDirectory, "inlined-dlfcn.c");

			var sb = new StringBuilder ();
			foreach (var field in survivingSymbols.OrderBy (s => s)) {
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
		}
	}
}
