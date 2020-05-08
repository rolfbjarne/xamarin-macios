using System;
using System.IO;

using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Xamarin.Bundler {
	public partial class Assembly {
		public bool IsAOTCompiled;
		public string FullPath { get; private set; }
		public string FileName { get { return Path.GetFileName (FullPath); } }
		public AssemblyBuildTarget BuildTarget;
		public string BuildTargetName;
		public bool IsCodeShared;
		public bool IsBoundAssembly;

		public string Identity { get { return GetIdentity (FullPath); } }

		public string AssemblyName {
			get { return AssemblyDefinition.Name.Name; }
		}

		public static string GetIdentity (AssemblyDefinition ad)
		{
			return Path.GetFileNameWithoutExtension (ad.MainModule.FileName);
		}

		public static string GetIdentity (string path)
		{
			return Path.GetFileNameWithoutExtension (path);
		}

		public AssemblyDefinition AssemblyDefinition;

		public static Assembly Load (Task task, TaskItem asmitem)
		{
			Assembly asm;

			var key = "Assembly:" + asmitem.ItemSpec;
			var engine = task.BuildEngine4;
			asm = (Assembly) engine.GetRegisteredTaskObject (key, RegisteredTaskObjectLifetime.Build);

			if (asm == null) {
				asm = new Assembly ();
				asm.FullPath = Path.GetFullPath (asmitem.ItemSpec);

				// Share assembly loading with other code (CoreResolver.cs?)
				var parameters = new ReaderParameters ();
				parameters.InMemory = new FileInfo (asm.FullPath).Length < 1024 * 1024 * 100; // 100 MB.
				parameters.ReadSymbols = true;
				parameters.SymbolReaderProvider = new DefaultSymbolReaderProvider (throwIfNoSymbol: false);
				asm.AssemblyDefinition = AssemblyDefinition.ReadAssembly (asm.FullPath);


				asm.IsAOTCompiled = asmitem.GetMetadata ("IsAOTCompiled") == "true";
				var bt = asmitem.GetMetadata ("BuildTarget");
				if (Enum.TryParse<AssemblyBuildTarget> (bt, out var build_target))
					asm.BuildTarget = build_target;
				asm.BuildTargetName = asmitem.GetMetadata ("BuildTargetName");
				asm.IsCodeShared = asmitem.GetMetadata ("IsCodeShared") == "true";
				asm.IsBoundAssembly = asmitem.GetMetadata ("IsBoundAssembly") == "true";

				engine.RegisterTaskObject (key, asm, RegisteredTaskObjectLifetime.Build, false);
			}
			
			return asm;
		}
	}
}

