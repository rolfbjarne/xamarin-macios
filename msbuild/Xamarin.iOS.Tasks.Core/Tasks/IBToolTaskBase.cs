using System;
using System.Collections.Generic;

using Xamarin.MacDev;

namespace Xamarin.iOS.Tasks {
	public abstract class IBToolTaskBase : Xamarin.MacDev.Tasks.IBToolTaskBase
	{
		protected override bool AutoActivateCustomFonts {
			get { return true; }
		}
	}
}
