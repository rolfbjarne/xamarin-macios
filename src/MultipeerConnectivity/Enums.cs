//
// Enums.cs: enums for MultipeerConnectivity
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//   Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013-2014, 2016 Xamarin, Inc.

using ObjCRuntime;

namespace MultipeerConnectivity {

	// NSInteger -> MCSession.h
	[Native]
	public enum MCSessionSendDataMode : long {
		Reliable,
		Unreliable
	}

	// NSInteger -> MCSession.h
	[Native]
	public enum MCSessionState : long {
		NotConnected,
		Connecting,
		Connected
	}

	// NSInteger -> MCSession.h
	[Native]
	public enum MCEncryptionPreference : long {
		Optional = 0,
		Required = 1,
		None = 2
	}

	// NSInteger -> MCError.h
	[Native ("MCErrorCode")]
	[ErrorDomain ("MCErrorDomain")]
	public enum MCError : long {
		Unknown,
		NotConnected,
		InvalidParameter,
		Unsupported,
		TimedOut,
		Cancelled,
		Unavailable
	}
}
