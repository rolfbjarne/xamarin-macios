//
// UIEnums.cs:
//
// Copyright 2009-2011 Novell, Inc.
// Copyright 2011-2012, Xamarin Inc.
//
// Author:
//  Miguel de Icaza
//

using System;
using Foundation;
using ObjCRuntime;

namespace UIKit {

#if IOS
	public static class UIDeviceOrientationExtensions {
		public static bool IsPortrait (this UIDeviceOrientation orientation)
		{
			return orientation == UIDeviceOrientation.PortraitUpsideDown ||
				orientation == UIDeviceOrientation.Portrait;
		}

		public static bool IsLandscape (this UIDeviceOrientation orientation)
		{
			return orientation == UIDeviceOrientation.LandscapeRight || orientation == UIDeviceOrientation.LandscapeLeft;
		}

		public static bool IsFlat (this UIDeviceOrientation orientation)
		{
			return orientation == UIDeviceOrientation.FaceUp || orientation == UIDeviceOrientation.FaceDown;
		}
	}

	public static class UIInterfaceOrientationExtensions {
		public static bool IsPortrait (this UIInterfaceOrientation orientation)
		{
			return orientation == UIInterfaceOrientation.PortraitUpsideDown ||
				orientation == UIInterfaceOrientation.Portrait;
		}
		public static bool IsLandscape (this UIInterfaceOrientation orientation)
		{
			return orientation == UIInterfaceOrientation.LandscapeRight ||
				orientation == UIInterfaceOrientation.LandscapeLeft;
		}
	}
#endif // IOS

#if __MACCATALYST__
	public static class UIImageResizingModeExtensions {
		public static nint ToNative (UIImageResizingMode value)
		{
			// The values we have in managed code corresponds with the ARM64 values.
			if (!Runtime.IsARM64CallingConvention) {
				// Stretch and Tile are switched on x64 on Mac Catalyst
				switch (value) {
				case (UIImageResizingMode) 0:
					return 1;
				case (UIImageResizingMode) 1:
					return 0;
				}
			}
			return (nint) (long) value;
		}

		public static UIImageResizingMode ToManaged (nint value)
		{
			// The values we have in managed code corresponds with the ARM64 values.
			if (!Runtime.IsARM64CallingConvention) {
				// Stretch and Tile are switched on x64 on Mac Catalyst
				switch (value) {
				case 0:
					return (UIImageResizingMode) 1;
				case 1:
					return (UIImageResizingMode) 0;
				}
			}
			return (UIImageResizingMode) (long) value;
		}
	}

	public static class UITextAlignmentExtensions {
		public static nint ToNative (UITextAlignment value)
		{
			// The values we have in managed code corresponds with the ARM64 values.
			if (!Runtime.IsARM64CallingConvention) {
				// Center and Right are switched on x64 on Mac Catalyst
				switch (value) {
				case (UITextAlignment) 1:
					value = (UITextAlignment) 2;
					break;
				case (UITextAlignment) 2:
					value = (UITextAlignment) 1;
					break;
				}
			}
			return (nint) (long) value;
		}

		public static UITextAlignment ToManaged (nint value)
		{
			// The values we have in managed code corresponds with the ARM64 values.
			if (!Runtime.IsARM64CallingConvention) {
				// Center and Right are switched on x64 on Mac Catalyst
				switch (value) {
				case 1:
					value = (nint) 2;
					break;
				case 2:
					value = (nint) 1;
					break;
				}
			}
			return (UITextAlignment) (long) value;
		}
	}
#endif // __MACCATALYST__

#if __IOS__ && !__MACCATALYST__

	[Flags]
	[NoWatch, NoTV, NoMacCatalyst, iOS (18, 0)]
	internal static class UITextFormattingViewControllerTextAlignment_Extensions {
		public static NSSet<string> ToSet (this UITextFormattingViewControllerTextAlignment value)
		{
			throw new NotImplementedException ();
		}

		public static UITextFormattingViewControllerTextAlignment ToBits (this NSSet<NSString> collection)
		{
		// [Field ("UITextFormattingViewControllerTextAlignmentLeft")]
		// Left = 1,

		// [Field ("UITextFormattingViewControllerTextAlignmentCenter")]
		// Center = 2,

		// [Field ("UITextFormattingViewControllerTextAlignmentRight")]
		// Right = 4,

		// [Field ("UITextFormattingViewControllerTextAlignmentJustified")]
		// Justified = 8,

		// [Field ("UITextFormattingViewControllerTextAlignmentNatural")]
		// Natural = 16,
			throw new NotImplementedException ();
		}
	}

	[Flags]
	[NoWatch, NoTV, NoMacCatalyst, iOS (18, 0)]
	internal static class UITextFormattingViewControllerTextList_Extensions {
		public static NSSet<string> ToSet (this UITextFormattingViewControllerTextList value)
		{
			throw new NotImplementedException ();
		}

		public static UITextFormattingViewControllerTextList ToBits (this NSSet<NSString> collection)
		{
		// [Field ("UITextFormattingViewControllerTextListDisc")]
		// Disc = 1,

		// [Field ("UITextFormattingViewControllerTextListHyphen")]
		// Hyphen = 2,

		// [Field ("UITextFormattingViewControllerTextListDecimal")]
		// Decimal = 4,

		// [Field ("UITextFormattingViewControllerTextListOther")]
		// Other = 8,
			throw new NotImplementedException ();
		}
	}

	[Flags]
	[NoWatch, NoTV, NoMacCatalyst, iOS (18, 0)]
	internal static class UITextFormattingViewControllerHighlight_Extensions {
		public static NSSet<string> ToSet (this UITextFormattingViewControllerHighlight value)
		{
			throw new NotImplementedException ();
		}

		public static UITextFormattingViewControllerHighlight ToBits (this NSSet<NSString> collection)
		{
		// [DefaultEnumValue]
		// [Field ("UITextFormattingViewControllerHighlightDefault")]
		// Default = 1,

		// [Field ("UITextFormattingViewControllerHighlightPurple")]
		// Purple = 2,

		// [Field ("UITextFormattingViewControllerHighlightPink")]
		// Pink = 4,

		// [Field ("UITextFormattingViewControllerHighlightOrange")]
		// Orange = 8,

		// [Field ("UITextFormattingViewControllerHighlightMint")]
		// Mint = 16,

		// [Field ("UITextFormattingViewControllerHighlightBlue")]
		// Blue = 32,
			throw new NotImplementedException ();
		}
	}
#endif
}

