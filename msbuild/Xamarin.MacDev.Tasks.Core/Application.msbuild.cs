using System;
using System.Collections.Generic;
using ObjCRuntime;
using Xamarin.Utils;

namespace Xamarin.Bundler {
	public partial class Application {
		public RegistrarMode Registrar;
		public bool IsDefaultMarshalManagedExceptionMode;
		public MarshalManagedExceptionMode MarshalManagedExceptions;
		public MarshalObjectiveCExceptionMode MarshalObjectiveCExceptions;

		public bool EnableDebug;
		public bool EnableSGenConc;
		public bool DynamicRegistrationSupported;
		public ApplePlatform Platform;
		public string MonoGCParams;
		public Dictionary<string, string> EnvironmentVariables;
		public bool IsSimulatorBuild;
		public bool IsDeviceBuild;
		public bool HasFrameworksDirectory;
		public bool EnableProfiling;
		public bool UseInterpreter;
		public bool EnableLLVMOnlyBitCode;
		public MonoNativeMode MonoNativeMode;
		public bool? DebugTrack;
		public bool PackageManagedDebugSymbols;
		public bool IsWatchExtension;
		public bool IsExtension;
		public Version SdkVersion;
		public List<string> RootAssemblies;
		public AssemblyBuildTarget LibMonoNativeLinkMode;
		public string AssemblyName;
		public string GetLibNativeName ()
		{
			throw new NotImplementedException ();
		}

		public bool Embeddinator => false;
		public Application ()
		{
		}
	}
}

