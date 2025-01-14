
//
// Copyright 2019 Microsoft Corp
//
// Authors:
//   Manuel de la Pena mandel@microsoft.com 
//
using Foundation;
using ObjCRuntime;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

#nullable enable

namespace AVFoundation {

	public partial class AVContentKeyResponse {

		public static AVContentKeyResponse Create (NSData fairPlayStreamingKeyResponseData) => Create (fairPlayStreamingKeyResponseData, AVContentKeyResponseDataType.FairPlayStreamingKeyResponseData);

		public static AVContentKeyResponse Create (NSData data, AVContentKeyResponseDataType dataType = AVContentKeyResponseDataType.FairPlayStreamingKeyResponseData)
		{
			switch (dataType) {
#pragma warning disable CA1416 // This call site is reachable on: 'ios' 12.2 and later, 'maccatalyst' 12.2 and later, 'macOS/OSX' 12.0 and later, 'tvos' 12.2 and later. 'AVContentKeyResponseDataType.AuthorizationTokenData' is only supported on: 'ios' 13.0 and later, 'tvos' 13.0 and later.
			case AVContentKeyResponseDataType.AuthorizationTokenData:
				return AVContentKeyResponse._InitWithAuthorizationToken (data);
#pragma warning restore CA1416
			default:
				return AVContentKeyResponse._InitWithFairPlayStreamingKeyResponseData (data);
			}
		}
	}
}
