using System;

using Xamarin.MacDev.Tasks;
using Xamarin.MacDev;

namespace Xamarin.iOS.Tasks
{
	public abstract class DetectSdkLocationsTaskBase : DetectSdkLocationsCoreTaskBase
	{
		protected override IAppleSdkVersion GetDefaultSdkVersion ()
		{
			return AppleSdkVersion.UseDefault;
		}

		public override bool Execute ()
		{
			AppleSdkSettings.Init ();

			TargetArchitecture architectures;
			if (string.IsNullOrEmpty (TargetArchitectures) || !Enum.TryParse (TargetArchitectures, out architectures))
				architectures = TargetArchitecture.Default;

			if (!string.IsNullOrEmpty (IsDotNetSimulatorBuild)) {
				SdkIsSimulator = string.Equals (IsDotNetSimulatorBuild, "true", StringComparison.OrdinalIgnoreCase);
			} else {
				SdkIsSimulator = (architectures & (TargetArchitecture.i386 | TargetArchitecture.x86_64)) != 0;
			}

			return base.Execute ();
		}

		protected override string GetDefaultXamarinSdkRoot ()
		{
			return Sdks.XamIOS.SdkDir;
		}
	}
}
