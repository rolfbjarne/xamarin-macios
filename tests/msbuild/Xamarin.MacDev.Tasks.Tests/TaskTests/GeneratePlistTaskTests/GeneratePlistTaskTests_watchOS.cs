﻿using NUnit.Framework;
using Xamarin.MacDev;

namespace Xamarin.iOS.Tasks
{
	[TestFixture]
	public abstract class GeneratePlistTaskTests_watchOS: GeneratePlistTaskTests_Core
	{
		public override void ConfigureTask ()
		{
			base.ConfigureTask ();
			Task.DefaultSdkVersion = IPhoneSdks.Watch.GetClosestInstalledSdk (IPhoneSdkVersion.V2_0, true).ToString ();
			Task.TargetFrameworkMoniker = "Xamarin.WatchOS,v1.0";
		}
	}
}

