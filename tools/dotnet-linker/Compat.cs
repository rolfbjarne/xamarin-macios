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

		public string GetProductName ()
		{
			switch (Platform) {
			case ApplePlatform.iOS:
			case ApplePlatform.TVOS:
			case ApplePlatform.WatchOS:
				return "Xamarin.iOS";
			case ApplePlatform.MacOSX:
				return "Xamarin.Mac";
			default:
				throw ErrorHelper.CreateError (177, Errors.MX0177 /* "Unknown platform: {0}. This usually indicates a bug; please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new with a test case." */, Platform);
			}
		}

		public string ProductName {
			get {
				return GetProductName ();
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


	namespace Mono.Linker {
		using System;
		using System.Collections.Generic;

		public class Pipeline {

			readonly List<IStep> _steps;

			public Pipeline ()
			{
				_steps = new List<IStep> ();
			}

			public void PrependStep (IStep step)
			{
				_steps.Insert (0, step);
			}

			public void AppendStep (IStep step)
			{
				_steps.Add (step);
			}

			public void AddStepBefore (Type target, IStep step)
			{
				for (int i = 0; i < _steps.Count; i++) {
					if (target.IsInstanceOfType (_steps [i])) {
						_steps.Insert (i, step);
						return;
					}
				}
				string msg = String.Format ("Step {0} could not be inserted before (not found) {1}", step, target);
				throw new InvalidOperationException (msg);
			}

			public void AddStepBefore (IStep target, IStep step)
			{
				for (int i = 0; i < _steps.Count; i++) {
					if (_steps [i] == target) {
						_steps.Insert (i, step);
						return;
					}
				}
			}

			public void ReplaceStep (Type target, IStep step)
			{
				AddStepBefore (target, step);
				RemoveStep (target);
			}

			public void AddStepAfter (Type target, IStep step)
			{
				for (int i = 0; i < _steps.Count; i++) {
					if (target.IsInstanceOfType (_steps [i])) {
						if (i == _steps.Count - 1)
							_steps.Add (step);
						else
							_steps.Insert (i + 1, step);
						return;
					}
				}
				string msg = String.Format ("Step {0} could not be inserted after (not found) {1}", step, target);
				throw new InvalidOperationException (msg);
			}

			public void AddStepAfter (IStep target, IStep step)
			{
				for (int i = 0; i < _steps.Count; i++) {
					if (_steps [i] == target) {
						if (i == _steps.Count - 1)
							_steps.Add (step);
						else
							_steps.Insert (i + 1, step);
						return;
					}
				}
			}

			public void RemoveStep (Type target)
			{
				for (int i = 0; i < _steps.Count; i++) {
					if (_steps [i].GetType () != target)
						continue;

					_steps.RemoveAt (i);
					break;
				}
			}

			public void Process (LinkContext context)
			{
				while (_steps.Count > 0) {
					IStep step = _steps [0];
					ProcessStep (context, step);
					_steps.Remove (step);
				}
			}

			protected virtual void ProcessStep (LinkContext context, IStep step)
			{
#if !NET
				context.Tracer.Push (step);
#endif
				step.Process (context);
#if !NET
				context.Tracer.Pop ();
#endif
			}

			public IStep [] GetSteps ()
			{
				return _steps.ToArray ();
			}

			public bool ContainsStep (Type type)
			{
				foreach (IStep step in _steps)
					if (step.GetType () == type)
						return true;

				return false;
			}
		}
	}

}