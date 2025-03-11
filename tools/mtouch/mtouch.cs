// Copyright 2009, Novell, Inc.
// Copyright 2011-2013 Xamarin Inc. All rights reserved.
//
// Authors:
//   Miguel de Icaza
//   Geoff Norton
//   Jb Evain
//   Sebastien Pouliot
//

using Mono.Options;

using Xamarin.Linker;
using Xamarin.Utils;

namespace Xamarin.Bundler {
	public partial class Driver {
		internal const string NAME = "mtouch";

		static int Main2 (string [] args)
		{
			ErrorHelper.Platform = ApplePlatform.iOS;

			var app = new Application ();
			var os = new OptionSet ();
			ParseOptions (app, os, args);

			ValidateXcode (app, false, false);

			app.InitializeCommon ();
			app.RunRegistrar ();

			return 0;
		}
	}
}
