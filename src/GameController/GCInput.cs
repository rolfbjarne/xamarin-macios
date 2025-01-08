// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

#nullable enable

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace GameController {
	public partial class GCInput {
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[DllImport (Constants.GameControllerLibrary)]
		static extern IntPtr /* GCButtonElementName */ GCInputBackLeftButton (nint position);

		/// <summary>Get the name of the back left button on the controller for the specified position.</summary>
		/// <param name="position">Zero-based position of the button.</param>
		/// <returns>The name of the back left button on the controller for the specified position.</returns>
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public static GCInputButtonName? GetBackLeftButton (nint position)
		{
			var constant = GetBackLeftButtonName (position);
			if (constant is null)
				return null;
			return GCInputButtonNameExtensions.GetValue (constant);
		}

		/// <summary>Get the name of the back left button on the controller for the specified position.</summary>
		/// <param name="position">Zero-based position of the button.</param>
		/// <returns>The name of the back left button on the controller for the specified position.</returns>
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public static NSString? GetBackLeftButtonName (nint position)
		{
			return Runtime.GetNSObject<NSString> (GCInputBackLeftButton (position));
		}

		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[DllImport (Constants.GameControllerLibrary)]
		static extern IntPtr /* GCButtonElementName */ GCInputBackRightButton (nint position);

		/// <summary>Get the name of the back right button on the controller for the specified position.</summary>
		/// <param name="position">Zero-based position of the button.</param>
		/// <returns>The name of the back right button on the controller for the specified position.</returns>
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public static GCInputButtonName? GetBackRightButton (nint position)
		{
			var constant = GetBackRightButtonName (position);
			if (constant is null)
				return null;
			return GCInputButtonNameExtensions.GetValue (constant);
		}

		/// <summary>Get the name of the back right button on the controller for the specified position.</summary>
		/// <param name="position">Zero-based position of the button.</param>
		/// <returns>The name of the back rught button on the controller for the specified position.</returns>
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		public static NSString? GetBackRightButtonName (nint position)
		{
			return Runtime.GetNSObject<NSString> (GCInputBackRightButton (position));
		}

		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[DllImport (Constants.GameControllerLibrary)]
		static extern IntPtr /* GCButtonElementName */ GCInputArcadeButtonName (nint row, nint column);

		/// <summary>Get the name of the arcade button for the specified position.</summary>
		/// <param name="row">The row of the arcade button.</param>
		/// <param name="column">The column of the arcade button.</param>
		/// <returns>The name of the arcade button on the controller for the specified position.</returns>
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static GCInputButtonName? GetArcadeButton (nint row, nint column)
		{
			var constant = GetArcadeButtonName (row, column);
			if (constant is null)
				return null;
			return GCInputButtonNameExtensions.GetValue (constant);
		}

		/// <summary>Get the name of the arcade button for the specified position.</summary>
		/// <param name="row">The row of the arcade button.</param>
		/// <param name="column">The column of the arcade button.</param>
		/// <returns>The name of the arcade button on the controller for the specified position.</returns>
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString? GetArcadeButtonName (nint row, nint column)
		{
			return Runtime.GetNSObject<NSString> (GCInputArcadeButtonName (row, column));
		}
	}
}
