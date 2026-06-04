//
// BusinessChat bindings
//
// Authors:
//     Manuel de la Peña <mandel@microsoft.com>
//
// Copyright 2017 Microsoft Inc. All rights reserved.
//
using System.ComponentModel;

#if MONOMAC
using AppKit;
using UIControl = AppKit.NSControl;
#else
using UIKit;
#endif

namespace BusinessChat {

	[Deprecated (PlatformName.MacOSX, 13, 1)]
	[Deprecated (PlatformName.iOS, 16, 2)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 16, 2)]
	[BaseType (typeof (UIControl))]
	[DisableDefaultCtor]
	interface BCChatButton {
		/// <param name="style">The style.</param>
		/// <summary>Creates a new chat button with the specified style.</summary>
		[Export ("initWithStyle:")]
		[DesignatedInitializer]
		NativeHandle Constructor (BCChatButtonStyle style);
	}


	[Deprecated (PlatformName.MacOSX, 13, 1)]
	[Deprecated (PlatformName.iOS, 16, 2)]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 16, 2)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface BCChatAction {

		/// <param name="businessIdentifier">The business identifier.</param>
		/// <param name="intentParameters">The intent parameters for the transcript.</param>
		/// <summary>Opens the Business Chat transcript for the specified business.</summary>
		[Static]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("openTranscript:intentParameters:")]
		void OpenTranscript (string businessIdentifier, NSDictionary<NSString, NSString> intentParameters);
	}
}
