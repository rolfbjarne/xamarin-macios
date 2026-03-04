using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.Build.Framework;

using Mono.Cecil;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	/// <summary>
	/// Scans trimmed assemblies to collect information that survived trimming.
	/// Designed to be extensible for collecting additional types of information in the future.
	/// See docs/code/native-symbols.md for an overview of native symbol handling.
	/// </summary>
	public class CollectPostILTrimInformation : XamarinTask {
		[Required]
		public ITaskItem [] TrimmedAssemblies { get; set; } = [];

		/// <summary>
		/// Output file listing the inlined dlfcn symbols that survived trimming.
		/// </summary>
		[Required]
		public string SurvivingNativeSymbolsFile { get; set; } = "";

		/// <summary>
		/// Directory for per-assembly cache files, to avoid re-scanning unchanged assemblies.
		/// </summary>
		[Required]
		public string CacheDirectory { get; set; } = "";

		public override bool Execute ()
		{
			CollectSurvivingNativeSymbols ();
			return !Log.HasLoggedErrors;
		}

		void CollectSurvivingNativeSymbols ()
		{
			Directory.CreateDirectory (CacheDirectory);

			// Scan trimmed assemblies for surviving P/Invoke methods, using per-assembly caching.
			var survivingSymbols = new HashSet<string> ();
			foreach (var item in TrimmedAssemblies) {
				var assemblyPath = item.ItemSpec;
				if (!File.Exists (assemblyPath))
					continue;

				var assemblyName = Path.GetFileNameWithoutExtension (assemblyPath);
				var cacheFile = Path.Combine (CacheDirectory, assemblyName + ".dlfcn-symbols.cache");

				string []? cachedSymbols = null;
				if (File.Exists (cacheFile) && File.GetLastWriteTimeUtc (cacheFile) >= File.GetLastWriteTimeUtc (assemblyPath)) {
					cachedSymbols = File.ReadAllLines (cacheFile);
					Log.LogMessage (MessageImportance.Low, "Using cached dlfcn symbols for {0}", assemblyName);
				}

				if (cachedSymbols is not null) {
					foreach (var sym in cachedSymbols) {
						if (sym.Length > 0)
							survivingSymbols.Add (sym);
					}
				} else {
					var assemblySymbols = new HashSet<string> ();
					CollectDlfcnSymbolsFromAssembly (assemblyPath, assemblySymbols);

					// Write per-assembly cache (sorted for stability).
					var sortedAssemblySymbols = assemblySymbols.OrderBy (s => s).ToArray ();
					File.WriteAllLines (cacheFile, sortedAssemblySymbols);

					foreach (var sym in assemblySymbols)
						survivingSymbols.Add (sym);
				}
			}

			// Write the combined results only if contents changed (sorted for stability).
			var sorted = survivingSymbols.OrderBy (s => s).ToArray ();

			if (File.Exists (SurvivingNativeSymbolsFile)) {
				var existing = File.ReadAllLines (SurvivingNativeSymbolsFile);
				if (existing.SequenceEqual (sorted))
					return;
			}

			var dir = Path.GetDirectoryName (SurvivingNativeSymbolsFile);
			if (!string.IsNullOrEmpty (dir))
				Directory.CreateDirectory (dir);
			File.WriteAllLines (SurvivingNativeSymbolsFile, sorted);
			Log.LogMessage (MessageImportance.Low, "Found {0} surviving inlined dlfcn symbols", survivingSymbols.Count);
		}

		static void CollectDlfcnSymbolsFromAssembly (string assemblyPath, HashSet<string> survivingSymbols)
		{
			const string prefix = "xamarin_Dlfcn_";
			const string suffix = "_Native";

			using var assembly = AssemblyDefinition.ReadAssembly (assemblyPath, new ReaderParameters { ReadSymbols = false });
			foreach (var module in assembly.Modules) {
				foreach (var type in module.Types) {
					if (!type.HasMethods)
						continue;
					foreach (var method in type.Methods) {
						if (!method.IsPInvokeImpl)
							continue;
						if (method.PInvokeInfo?.Module?.Name != "__Internal")
							continue;
						var name = method.Name;
						if (!name.StartsWith (prefix) || !name.EndsWith (suffix))
							continue;
						var symbolName = name.Substring (prefix.Length, name.Length - prefix.Length - suffix.Length);
						survivingSymbols.Add (symbolName);
					}
				}
			}
		}
	}
}
