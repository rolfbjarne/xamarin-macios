//
// CPNavigationAlert.cs
//
// Authors:
//	Alex Soto <alexsoto@microsoft.com>
//
// Copyright 2018 Microsoft Corporation. All rights reserved.
//

using System;
using Foundation;
using ObjCRuntime;

#if XAMCORE_2_0
namespace CarPlay {
	public partial class CPNavigationAlert {
		// Defined inside CPNavigationAlert.h
		// static NSTimeInterval const CPNavigationAlertMinimumDuration = 5;
		public const double MinimumDuration = 5;
	}
}
#endif // XAMCORE_2_0