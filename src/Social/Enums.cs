//
// Enums.cs: Enumerations for the Social framework
//
// Authors:
//    Miguel de Icaza (miguel@xamarin.com)
//
// Copyright 2012-2014 Xamarin Inc
//

namespace Social {

	// NSInteger -> SLRequest.h
	/// <summary>The HTTP verb associated with a social service request.</summary>
	[Native]
	public enum SLRequestMethod : long {
		/// <summary>Indicates get.</summary>
		Get,
		/// <summary>Indicates post.</summary>
		Post,
		/// <summary>Indicates delete.</summary>
		Delete,
		/// <summary>Indicates put.</summary>
		Put,
	}

	// NSInteger -> SLComposeViewController.h
	/// <summary>An enumeration whose values specify whether composition in a <see cref="Social.SLComposeViewController" /> was completed or cancelled.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	public enum SLComposeViewControllerResult : long {
		/// <summary>Indicates cancelled.</summary>
		Cancelled,
		/// <summary>Indicates done.</summary>
		Done,
	}
}
