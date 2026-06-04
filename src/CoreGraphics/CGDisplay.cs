#nullable enable

#if MONOMAC || __MACCATALYST__

namespace CoreGraphics {
	/// <summary>Options for display capture operations.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum CGCaptureOptions : uint {
		/// <summary>No special capture behavior.</summary>
		None = 0,
		/// <summary>Do not fill the display with a solid color after capture.</summary>
		NoFill = 1 << 0,
	}

	/// <summary>Provides methods for querying and controlling displays.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public static class CGDisplay {
#if !COREBUILD
		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern uint CGMainDisplayID ();

	/// <summary>Gets the identifier of the main display.</summary>
		public static int MainDisplayID {
			get {
				return (int) CGMainDisplayID ();
			}
		}

	/// <summary>Gets the Core Foundation type identifier for display modes.</summary>
		[DllImport (Constants.CoreGraphicsLibrary, EntryPoint = "CGDisplayModeGetTypeID")]
		public static extern nint GetTypeID ();

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern CGRect CGDisplayBounds (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Gets the bounding rectangle of the specified display.</summary>
		public static CGRect GetBounds (int display)
		{
			return CGDisplayBounds ((uint) display);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern nuint CGDisplayPixelsWide (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Gets the width in pixels of the specified display.</summary>
		public static nint GetWidth (int display)
		{
			return (nint) CGDisplayPixelsWide ((uint) display);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern nuint CGDisplayPixelsHigh (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Gets the height in pixels of the specified display.</summary>
		public static nint GetHeight (int display)
		{
			return (nint) CGDisplayPixelsHigh ((uint) display);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern int CGSetDisplayTransferByFormula (uint display, float redMin, float redMax, float redGamma, float greenMin, float greenMax, float greenGamma, float blueMin, float blueMax, float blueGamma);

		/// <param name="display">The display identifier.</param>
		///         <param name="redMin">The minimum red value.</param>
		///         <param name="redMax">The maximum red value.</param>
		///         <param name="redGamma">The red gamma value.</param>
		///         <param name="greenMin">The minimum green value.</param>
		///         <param name="greenMax">The maximum green value.</param>
		///         <param name="greenGamma">The green gamma value.</param>
		///         <param name="blueMin">The minimum blue value.</param>
		///         <param name="blueMax">The maximum blue value.</param>
		///         <param name="blueGamma">The blue gamma value.</param>
	/// <summary>Sets the display transfer (gamma) by formula for the specified display.</summary>
		public static int SetDisplayTransfer (int display, float redMin, float redMax, float redGamma, float greenMin, float greenMax, float greenGamma, float blueMin, float blueMax, float blueGamma)
		{
			return CGSetDisplayTransferByFormula ((uint) display, redMin, redMax, redGamma, greenMin, greenMax, greenGamma, blueMin, blueMax, blueGamma);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern uint CGDisplayGammaTableCapacity (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Gets the number of entries in the gamma table for the specified display.</summary>
		public static int GetGammaTableCapacity (int display)
		{
			return (int) CGDisplayGammaTableCapacity ((uint) display);
		}

	/// <summary>Restores the color settings to the user's ColorSync profile.</summary>
		[DllImport (Constants.CoreGraphicsLibrary, EntryPoint = "CGDisplayRestoreColorSyncSettings")]
		public static extern void RestoreColorSyncSettings ();

		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.9")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern byte CGDisplayIsCaptured (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Returns whether the specified display has been captured.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.9")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		public static bool IsCaptured (int display)
		{
			return CGDisplayIsCaptured ((uint) display) != 0;
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern int CGDisplayCapture (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Captures the specified display for exclusive use.</summary>
		public static int Capture (int display)
		{
			return CGDisplayCapture ((uint) display);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern int CGDisplayCaptureWithOptions (uint display, CGCaptureOptions options);

		/// <param name="display">The display identifier.</param>
		///         <param name="options">The capture options.</param>
	/// <summary>Captures the specified display with the given options.</summary>
		public static int Capture (int display, CGCaptureOptions options)
		{
			return CGDisplayCaptureWithOptions ((uint) display, options);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern int CGDisplayRelease (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Releases a captured display.</summary>
		public static int Release (int display)
		{
			return CGDisplayRelease ((uint) display);
		}

	/// <summary>Captures all displays for exclusive use.</summary>
		[DllImport (Constants.CoreGraphicsLibrary, EntryPoint = "CGCaptureAllDisplays")]
		public static extern int CaptureAllDisplays ();

		[DllImport (Constants.CoreGraphicsLibrary, EntryPoint = "CGCaptureAllDisplaysWithOptions")]
		static extern int CaptureAllDisplays (CGCaptureOptions options);


	/// <summary>Releases all captured displays.</summary>
		[DllImport (Constants.CoreGraphicsLibrary, EntryPoint = "CGReleaseAllDisplays")]
		public static extern int ReleaseAllDisplays ();

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern int CGDisplayHideCursor (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Hides the cursor on the specified display.</summary>
		public static int HideCursor (int display)
		{
			return CGDisplayHideCursor ((uint) display);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern int CGDisplayShowCursor (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Shows the cursor on the specified display.</summary>
		public static int ShowCursor (int display)
		{
			return CGDisplayShowCursor ((uint) display);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern int CGDisplayMoveCursorToPoint (uint display, CGPoint point);

		/// <param name="display">The display identifier.</param>
		///         <param name="point">The point to move the cursor to.</param>
	/// <summary>Moves the cursor to the specified point on the display.</summary>
		public static int MoveCursor (int display, CGPoint point)
		{
			return CGDisplayMoveCursorToPoint ((uint) display, point);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern uint CGDisplayIDToOpenGLDisplayMask (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Gets the OpenGL display mask for the specified display.</summary>
		public static int GetOpenGLDisplayMask (int display)
		{
			return (int) CGDisplayIDToOpenGLDisplayMask ((uint) display);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern uint CGOpenGLDisplayMaskToDisplayID (uint mask);

		/// <param name="displayMask">The OpenGL display mask.</param>
	/// <summary>Gets the display identifier for the specified OpenGL display mask.</summary>
		public static int GetDisplayID (int displayMask)
		{
			return (int) CGOpenGLDisplayMaskToDisplayID ((uint) displayMask);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern uint CGShieldingWindowID (uint display);

		/// <param name="display">The display identifier.</param>
	/// <summary>Gets the window identifier of the shielding window for the specified display.</summary>
		public static int GetShieldingWindowID (int display)
		{
			return (int) CGShieldingWindowID ((uint) display);
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		static extern int CGShieldingWindowLevel ();

	/// <summary>Gets the window level of the shielding window.</summary>
		public static int ShieldingWindowLevel {
			get { return CGShieldingWindowLevel (); }
		}

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static IntPtr CGDisplayCopyDisplayMode (uint display);

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static void CGDisplayModeRelease (IntPtr mode);

		[DllImport (Constants.CoreGraphicsLibrary)]
		extern static double CGDisplayModeGetRefreshRate (IntPtr mode);

		/// <summary>Get the refresh rate for the specified display.</summary>
		/// <param name="display">The identifier for the display.</param>
		/// <returns>The display rate, in hertz, of the specified display, or <see langword="null" /> in case of failure.</returns>
		public static double? GetRefreshRate (int display)
		{
			var mode = CGDisplayCopyDisplayMode ((uint) display);
			if (mode == IntPtr.Zero)
				return null;
			var refreshRate = CGDisplayModeGetRefreshRate (mode);
			CGDisplayModeRelease (mode);
			return refreshRate;
		}
#endif
	}
}
#endif
