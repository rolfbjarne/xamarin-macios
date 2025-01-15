//
// SKReceiptProperty.cs: strongly typed dictionary for options in StoreKit
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2013 Xamarin Inc.
//

#nullable enable

using ObjCRuntime;
using Foundation;
using CoreFoundation;
using StoreKit;

#if !MONOMAC
using UIKit;
#endif
using System;

namespace StoreKit {
	[ObsoletedOSPlatform ("ios18.0")]
	[ObsoletedOSPlatform ("maccatalyst18.0")]
	[ObsoletedOSPlatform ("macos15.0")]
	[ObsoletedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("tvos12.2")]
	public partial class SKReceiptProperties : DictionaryContainer {
#if !COREBUILD
		public SKReceiptProperties ()
			: base (new NSMutableDictionary ())
		{
		}

		public SKReceiptProperties (NSDictionary dictionary)
			: base (dictionary)
		{
		}

		public bool IsExpired {
			get {
				return GetInt32Value (_SKReceiptProperty.IsExpired) != 0;
			}
			set {
				SetNumberValue (_SKReceiptProperty.IsExpired, value ? 1 : 0);
			}
		}

		public bool IsRevoked {
			get {
				return GetInt32Value (_SKReceiptProperty.IsRevoked) != 0;
			}
			set {
				SetNumberValue (_SKReceiptProperty.IsRevoked, value ? 1 : 0);
			}
		}

		public bool IsVolumePurchase {
			get {
				return GetInt32Value (_SKReceiptProperty.IsVolumePurchase) != 0;
			}
			set {
				SetNumberValue (_SKReceiptProperty.IsVolumePurchase, value ? 1 : 0);
			}
		}
#endif

	}
}
