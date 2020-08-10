// Compat.cs: might not be ideal but it eases code sharing with existing code during the initial implementation.
using System;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Linker.Steps;

using Xamarin.Linker;
using Xamarin.Utils;

namespace Xamarin.Bundler {
	public partial class Application {
		public LinkerConfiguration Configuration { get; private set; }

		public Application (LinkerConfiguration configuration, string[] arguments)
			: this (arguments)
		{
			this.Configuration = configuration;
		}

		public string ProductName {
			get {
				switch (Platform) {
				case ApplePlatform.iOS:
					return "Microsoft.iOS";
				case ApplePlatform.TVOS:
					return "Microsoft.tvOS";
				case ApplePlatform.WatchOS:
					return "Microsoft.watchOS";
				case ApplePlatform.MacOSX:
					return "Microsoft.macOS";
				default:
					throw ErrorHelper.CreateError (177, Errors.MX0177 /* "Unknown platform: {0}. This usually indicates a bug; please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new with a test case." */, Platform);
				}
			}
		}

		public Version SdkVersion {
			get { return Configuration.SdkVersion; }
		}

		public Version DeploymentTarget {
			get { return Configuration.DeploymentTarget; }
		}

		public bool IsSimulatorBuild {
			get { return Configuration.IsSimulatorBuild; }
		}

		public ApplePlatform Platform {
			get { return Configuration.Platform; }
		}

		public void SelectRegistrar ()
		{
			throw new NotImplementedException ();
		}
	}

	public partial class Driver {
		public static string NAME {
			get { return "xamarin-bundler"; }
		}

		public static string PRODUCT {
			get { throw new NotImplementedException (); }
		}

		public static string LOCAL_BUILD_DIR {
			get { throw new NotImplementedException (); }
		}

		public static string FRAMEWORK_LOCATION_VARIABLE {
			get { throw new NotImplementedException (); }
		}
	}

	public class DotNetLinkContext {
		public Mono.Linker.AnnotationStore Annotations {
			get {
				throw new NotImplementedException ();
			}
		}

		public AssemblyDefinition GetAssembly (string name)
		{
			throw new NotImplementedException ();
		}
	}
}

namespace Mono.Linker {
	public static class LinkContextExtensions {
		public static void LogMessage (this LinkContext context, string messsage)
		{
			throw new NotImplementedException ();
		}
		public static IEnumerable<AssemblyDefinition> GetAssemblies (this LinkContext context)
		{
			throw new NotImplementedException ();
		}
		public static Dictionary<IMetadataTokenProvider, object> GetCustomAnnotations (this AnnotationStore self, string name)
		{
			throw new NotImplementedException ();
		}
	}
}
