using System;
using System.Collections.Generic;
using Mono.Linker.Steps;

using Xamarin.Bundler;

namespace Xamarin.Linker {
	public abstract class ConfigurationAwareStep : BaseStep {
		public LinkerConfiguration Configuration {
			get { return LinkerConfiguration.GetInstance (Context); }
		}

		protected void Report (List<Exception> exceptions)
		{
			// Figure out a better way to show problems.
			// There may only be warnings here.
			ErrorHelper.Show (exceptions);
		}
	}
}
