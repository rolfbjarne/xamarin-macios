//
// EventKitUIBundle C# bindings
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2017 Xamarin Inc. All rights reserved.
//

#nullable enable

namespace EventKitUI {
	/// <summary>Provides access to the EventKit UI framework bundle.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	public static class EKUIBundle {

		[DllImport (Constants.EventKitUILibrary)]
		static extern IntPtr EventKitUIBundle ();

		/// <summary>Gets the EventKit UI framework bundle.</summary>
		public static NSBundle? UIBundle {
			get {
				return Runtime.GetNSObject<NSBundle> (EventKitUIBundle ());
			}
		}
	}
}
