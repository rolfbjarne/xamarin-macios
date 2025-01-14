//
// INIntentResolutionResult Generic variant
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2016 Xamarin Inc. All rights reserved.
//

using System;
using Foundation;
using ObjCRuntime;

#nullable enable

namespace Intents {

	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst15.0")]
	[Register ("INIntentResolutionResult", SkipRegistration = true)]
	public sealed partial class INIntentResolutionResult<ObjectType> : INIntentResolutionResult
		where ObjectType : class, INativeObject {
		internal INIntentResolutionResult (NativeHandle handle) : base (handle)
		{
		}
	}

	public partial class INIntentResolutionResult {

		public static INIntentResolutionResult NeedsValue {
			get {
				throw new NotImplementedException ("All subclasses of INIntentResolutionResult must re-implement this property");
			}
		}

		public static INIntentResolutionResult NotRequired {
			get {
				throw new NotImplementedException ("All subclasses of INIntentResolutionResult must re-implement this property");
			}
		}

		public static INIntentResolutionResult Unsupported {
			get {
				throw new NotImplementedException ("All subclasses of INIntentResolutionResult must re-implement this property");
			}
		}

		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		public static INIntentResolutionResult GetUnsupported (nint reason) => throw new NotImplementedException ("All subclasses of INIntentResolutionResult must re-implement this method");

		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		public static INIntentResolutionResult GetConfirmationRequired (NSObject itemToConfirm, nint reason) => throw new NotImplementedException ("All subclasses of INIntentResolutionResult must re-implement this method");

	}
}
