using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.DotNet.XHarness.iOS.Shared;
using Microsoft.DotNet.XHarness.iOS.Shared.Execution;

using Xharness.TestTasks;

namespace Xharness.Jenkins.TestTasks {
	class DotNetBuildTask : MSBuildTask {

		public DotNetBuildTask (Jenkins jenkins, TestProject testProject, IProcessManager processManager) 
			: base (jenkins, testProject, processManager) { }

		protected override string ToolName => Jenkins.Harness.GetDotNetExecutable (Path.GetDirectoryName (ProjectFile));

		public override bool RestoreNugets => false; // 'dotnet build' will restore

		public override void SetEnvironmentVariables (Process process)
		{
			base.SetEnvironmentVariables (process);
			// modify those env vars that we do care about

			process.StartInfo.EnvironmentVariables.Remove ("MSBUILD_EXE_PATH");
			process.StartInfo.EnvironmentVariables.Remove ("MSBuildExtensionsPathFallbackPathsOverride");
			process.StartInfo.EnvironmentVariables.Remove ("MSBuildSDKsPath");
			process.StartInfo.EnvironmentVariables.Remove ("TargetFrameworkFallbackSearchPaths");
			process.StartInfo.EnvironmentVariables.Remove ("MSBuildExtensionsPathFallbackPathsOverride");
		}

		protected override void InitializeTool () =>
			buildToolTask = new DotNetBuild (
				msbuildPath: () => ToolName,
				processManager: ProcessManager,
				resourceManager: ResourceManager,
				eventLogger: this,
				envManager: this,
				errorKnowledgeBase: Jenkins.ErrorKnowledgeBase);

		public static void SetDotNetEnvironmentVariables (Dictionary<string, string> environment)
		{
			environment ["MSBUILD_EXE_PATH"] = null;
			environment ["MSBuildExtensionsPathFallbackPathsOverride"] = null;
			environment ["MSBuildSDKsPath"] = null;
			environment ["TargetFrameworkFallbackSearchPaths"] = null;
			environment ["MSBuildExtensionsPathFallbackPathsOverride"] = null;

			// This is a temporary variable to enable the .NET workload resolver, because it's opt-in for now.
			// Ref: https://github.com/dotnet/sdk/issues/13849
			environment ["MSBuildEnableWorkloadResolver"] = "true";
		}
	}
}
