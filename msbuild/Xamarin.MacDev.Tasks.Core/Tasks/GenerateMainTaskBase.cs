using System;
using System.Text;

using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;
using Xamarin.Localization.MSBuild;
using Xamarin.Bundler;

namespace Xamarin.MacDev.Tasks {
	public abstract class GenerateMainTaskBase : XamarinTask {
		
		public override bool Execute ()
		{
			try {
				var app = new Application ();
				app.Platform = Platform;

				var mainGenerator = new MainGenerator ();
				mainGenerator.App = app;
				mainGenerator.Verbosity = 0; // CHECK: can we figure this out?
				mainGenerator.Abi = Abi.i386; // FIXME: prop
				mainGenerator.Assemblies = null; // FIXME
				mainGenerator.RegistrationMethods = null; // FIXME
				mainGenerator.Output = null; // 

				mainGenerator.Generate ();

			} catch (ProductException pe) {
				Log.LogError (7069, null, MSBStrings.E7069 /* Failed to generate the main method: {0 */, pe.Message);
			}

			return true;
		}
	}
}

