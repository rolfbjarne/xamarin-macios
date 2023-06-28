using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

using Xamarin.Localization.MSBuild;
using Xamarin.Messaging.Build.Client;
using Xamarin.Utils;

using Mono.Cecil;

#nullable enable

namespace Xamarin.MacDev.Tasks {
	public class AOTUpdateTimestamps : XamarinTask, ITaskCallback, ICancelableTask {
		[Required]
		public ITaskItem [] Assemblies { get; set; } = Array.Empty<ITaskItem> ();

		#region Output
		[Output]
		public ITaskItem []? TouchedFiles { get; set; }

		#endregion

		public override bool Execute ()
		{
			if (ShouldExecuteRemotely ())
				return new TaskRunner (SessionId, BuildEngine4).RunAsync (this).Result;

			Process ();

			return !Log.HasLoggedErrors;
		}

		class Info {
			public ITaskItem Assembly;
			public FileInfo FileInfo;
			public HashSet<string>? AssemblyReferences;
			public bool Marked;
			public bool IsUpToDate;

			public Info (ITaskItem assembly, FileInfo info)
			{
				this.Assembly = assembly;
				this.FileInfo = info;
			}

			HashSet<string> LoadAssemblyReferences ()
			{
				if (AssemblyReferences is not null)
					return AssemblyReferences;
				AssemblyReferences = new HashSet<string> ();

				using var ad = AssemblyDefinition.ReadAssembly (Assembly.ItemSpec, new ReaderParameters { ReadingMode = ReadingMode.Deferred });
				foreach (var ar in ad.MainModule.AssemblyReferences) {
					AssemblyReferences.Add (ar.Name);
				}

				return AssemblyReferences;
			}

			public bool ReferencesAssembly (Info info)
			{
				var assemblyReferences = LoadAssemblyReferences ();

				var name = Path.GetFileNameWithoutExtension (info.Assembly.ItemSpec);
				return assemblyReferences.Contains (name);
			}
		}

		void Process ()
		{
			var markAll = false;
			var processed = new Info [Assemblies.Length];

			for (var i = 0; i < Assemblies.Length; i++) {
				var asm = Assemblies [i];
				var finfo = new FileInfo (asm.ItemSpec);
				processed [i] = new Info (asm, finfo);

				if (!finfo.Exists) {
					Log.LogWarning ("The assembly {0} does not exist, could not update timestamps", asm.ItemSpec);
					markAll = true;
					continue;
				}

				var objectFile = asm.GetMetadata ("ObjectFile");
				var llvmFile = asm.GetMetadata ("LLVMFile");
				FileInfo objectFileInfo;
				FileInfo? llvmFileInfo = null;

				// ObjectFile is required
				if (string.IsNullOrEmpty (objectFile)) {
					Log.LogWarning ("The assembly {0} does not provide an 'ObjectFile' metadata, could not update timestamps", asm.ItemSpec);
					markAll = true;
					continue;
				}
				objectFileInfo = new FileInfo (objectFile);
				var isUpToDate = IsUpToDate (finfo, objectFileInfo);

				// LLVMFile is optional
				if (!string.IsNullOrEmpty (llvmFile)) {
					llvmFileInfo = new FileInfo (llvmFile);
					isUpToDate &= IsUpToDate (finfo, llvmFileInfo);
				}

				processed [i].IsUpToDate = isUpToDate;
			}

			foreach (var info in processed) {
				if (markAll) {
					info.Marked = true;
				} else if (!info.IsUpToDate) {
					MarkAssembly (processed, info);
				}
			}

			var timestamp = DateTime.UtcNow;
			foreach (var info in processed) {
				if (!info.Marked)
					continue;
				if (!info.FileInfo.Exists)
					continue;
				info.FileInfo.LastWriteTimeUtc = timestamp;
				Log.LogMessage (MessageImportance.Low, $"Updated timestamp of {info.Assembly.ItemSpec} to {timestamp}");
			}
		}

		bool IsUpToDate (FileInfo input, FileInfo output)
		{
			if (!output.Exists)
				return false;
			return input.LastWriteTimeUtc <= output.LastWriteTimeUtc;
		}

		void MarkAssembly (Info [] infos, Info info)
		{
			Log.LogMessage (MessageImportance.Low, $"MarkAssembly ({info.Assembly.ItemSpec}) Marked: {info.Marked}");
			if (info.Marked)
				return;

			info.Marked = true;
			for (var i = 0; i < infos.Length; i++) {
				if (info == infos [i])
					continue;
				if (infos [i].Marked)
					continue;

				var references = infos [i].ReferencesAssembly (info);
				if (references) {
					Log.LogMessage (MessageImportance.Low, $"MarkAssembly ({info.Assembly.ItemSpec}) Marking {infos [i].Assembly.ItemSpec}");
					MarkAssembly (infos, infos [i]);
				} else {
					Log.LogMessage (MessageImportance.Low, $"The assembly '{infos [i].Assembly.ItemSpec}' does not reference '{info.Assembly.ItemSpec}'. References: {string.Join (", ", infos [i].AssemblyReferences)}");
				}
			}
		}

		public bool ShouldCopyToBuildServer (ITaskItem item) => false;

		public bool ShouldCreateOutputFile (ITaskItem item) => true;

		public IEnumerable<ITaskItem> GetAdditionalItemsToBeCopied () => Array.Empty<ITaskItem> ();

		public void Cancel ()
		{
			if (ShouldExecuteRemotely ())
				BuildConnection.CancelAsync (BuildEngine4).Wait ();
		}
	}
}
