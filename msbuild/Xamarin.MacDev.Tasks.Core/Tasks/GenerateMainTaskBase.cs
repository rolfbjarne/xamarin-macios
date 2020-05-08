using System;
using System.Text;

using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;
using Xamarin.Localization.MSBuild;
using Xamarin.Bundler;

namespace Xamarin.MacDev.Tasks {
	public abstract class GenerateMainTaskBase : XamarinTask {
		#region Input
		[Required]
		public string Abi { get; set; }

		[Required]
		public string Output { get; set; }

		[Required]
		public int Verbosity { get; set; }

		#endregion

		public override bool Execute ()
		{
			try {
				if (!Enum.TryParse<Abi> (Abi, out var abi)) {
					Log.LogError (57, MSBStrings.E0057 /* Invalid architectures: '{0}'. */, Abi);
					return false;
				}

				var app = new Application ();
				app.Platform = Platform;

				var mainGenerator = new MainGenerator ();
				mainGenerator.App = app;
				mainGenerator.Verbosity = Verbosity;
				mainGenerator.Abi = abi;
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

