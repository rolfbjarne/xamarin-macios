using System;
using System.Collections.Generic;
using Mono.Linker.Steps;

using Xamarin.Bundler;
using Xamarin.Tuner;

namespace Xamarin.Linker {
	public abstract class ConfigurationAwareStep : BaseStep {
		public LinkerConfiguration Configuration {
			get { return LinkerConfiguration.GetInstance (Context); }
		}

		public DerivedLinkContext LinkContext {
			get { return Configuration.DerivedLinkContext; }
		}

		protected void Report (Exception exception)
		{
			ErrorHelper.Show (exception);
		}

		protected void Report (List<Exception> exceptions)
		{
			// Maybe there's a better way to show errors that integrates with the linker?
			// We can't just throw an exception or exit here, since there might be only warnings in the list of exceptions.
			ErrorHelper.Show (exceptions);
		}
	}
}
