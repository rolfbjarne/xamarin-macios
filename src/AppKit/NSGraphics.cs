//
// Copyright 2010, Novell, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if !__MACCATALYST__

using System.ComponentModel;

using CoreGraphics;

#nullable enable

namespace AppKit {
	/// <summary>Provides low-level graphics utility functions for AppKit drawing.</summary>
	[SupportedOSPlatform ("macos")]
	public static class NSGraphics {
		/// <summary>The white color value (1.0).</summary>
		public static readonly float White = 1;
		/// <summary>The black color value (0.0).</summary>
		public static readonly float Black = 0;
		/// <summary>The light gray color value (2/3).</summary>
		public static readonly float LightGray = (float) 2 / 3.0f;
		/// <summary>The dark gray color value (1/3).</summary>
		public static readonly float DarkGray = (float) 1 / 3.0f;

		[DllImport (Constants.AppKitLibrary)]
		extern unsafe static NSWindowDepth NSBestDepth (IntPtr colorspaceHandle, nint bitsPerSample, nint bitsPerPixel, byte planar, byte* exactMatch);

#if !XAMCORE_5_0
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Obsolete ("Call 'GetBestDepth' instead.")]
		public static NSWindowDepth BestDepth (NSString colorspace, nint bitsPerSample, nint bitsPerPixel, bool planar, ref bool exactMatch)
		{
			if (colorspace is null)
				throw new ArgumentNullException (nameof (colorspace));

			var exactMatchValue = (byte) (exactMatch ? 1 : 0);
			NSWindowDepth rv;
			unsafe {
				rv = NSBestDepth (colorspace.Handle, bitsPerSample, bitsPerPixel, (byte) (planar ? 1 : 0), &exactMatchValue);
				GC.KeepAlive (colorspace);
			}
			exactMatch = exactMatchValue != 0;
			return rv;
		}
#endif

		public static NSWindowDepth GetBestDepth (NSString colorspace, nint bitsPerSample, nint bitsPerPixel, bool planar, out bool exactMatch)
		{
			if (colorspace is null)
				throw new ArgumentNullException (nameof (colorspace));

			byte exactMatchValue = 0;
			NSWindowDepth rv;
			unsafe {
				rv = NSBestDepth (colorspace.Handle, bitsPerSample, bitsPerPixel, (byte) (planar ? 1 : 0), &exactMatchValue);
				GC.KeepAlive (colorspace);
			}
			exactMatch = exactMatchValue != 0;
			return rv;
		}

		[DllImport (Constants.AppKitLibrary)]
		extern static byte NSPlanarFromDepth (NSWindowDepth depth);

		/// <param name="depth">The window depth.</param>
	/// <summary>Returns whether the specified depth is planar.</summary>
		public static bool PlanarFromDepth (NSWindowDepth depth)
		{
			return NSPlanarFromDepth (depth) != 0;
		}

		[DllImport (Constants.AppKitLibrary)]
		extern static IntPtr NSColorSpaceFromDepth (NSWindowDepth depth);

		/// <param name="depth">The window depth.</param>
	/// <summary>Returns the color space name for the specified depth.</summary>
		public static NSString ColorSpaceFromDepth (NSWindowDepth depth)
		{
			return new NSString (NSColorSpaceFromDepth (depth));
		}

		/// <param name="depth">The window depth.</param>
	/// <summary>Returns the bits per sample for the specified depth.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSBitsPerSampleFromDepth")]
		public extern static nint BitsPerSampleFromDepth (NSWindowDepth depth);

		/// <param name="depth">The window depth.</param>
	/// <summary>Returns the bits per pixel for the specified depth.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSBitsPerPixelFromDepth")]
		public extern static nint BitsPerPixelFromDepth (NSWindowDepth depth);

		[DllImport (Constants.AppKitLibrary)]
		extern static nint NSNumberOfColorComponents (IntPtr str);

		/// <param name="colorspaceName">The color space name.</param>
	/// <summary>Returns the number of color components for the specified color space.</summary>
		public static nint NumberOfColorComponents (NSString colorspaceName)
		{
			if (colorspaceName is null)
				throw new ArgumentNullException ("colorspaceName");
			nint result = NSNumberOfColorComponents (colorspaceName.Handle);
			GC.KeepAlive (colorspaceName);
			return result;
		}

		[DllImport (Constants.AppKitLibrary)]
		extern static IntPtr NSAvailableWindowDepths ();

		/// <summary>Gets the available window depths.</summary>
		public static NSWindowDepth [] AvailableWindowDepths {
			get {
				IntPtr depPtr = NSAvailableWindowDepths ();
				int count;

				for (count = 0; Marshal.ReadInt32 (depPtr, count) != 0; count++)
					;

				var ret = new NSWindowDepth [count];
				for (int i = 0; i < count; count++) {
					// NSWindowDepth: int
					ret [i] = (NSWindowDepth) Marshal.ReadInt32 (depPtr, i);
				}

				return ret;

			}
		}

		/// <param name="rect">The rectangle to draw.</param>
	/// <summary>Fills a rectangle using the specified compositing operation.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSRectFill")]
		public extern static void RectFill (CGRect rect);

		[DllImport (Constants.AppKitLibrary)]
		extern static void NSRectFillUsingOperation (CGRect rect, nuint op);
		/// <param name="rect">The rectangle to draw.</param>
		///         <param name="op">The compositing operation.</param>
	/// <summary>Fills a list of rectangles with the current color.</summary>
		public static void RectFill (CGRect rect, NSCompositingOperation op)
		{
			NSRectFillUsingOperation (rect, (nuint) (ulong) op);
		}

		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSRectFillList")]
		unsafe extern static void RectFillList (CGRect* rects, nint count);

		/// <param name="rects">The rectangles to fill.</param>
	/// <summary>Sets the clipping path to the specified rectangle.</summary>
		public static void RectFill (CGRect [] rects)
		{
			if (rects is null)
				throw new ArgumentNullException ("rects");
			unsafe {
				fixed (CGRect* ptr = rects)
					RectFillList (ptr, rects.Length);
			}
		}

		/// <param name="rect">The rectangle to draw.</param>
	/// <summary>Draws a frame around the specified rectangle.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSRectClip")]
		public extern static void RectClip (CGRect rect);

		/// <param name="rect">The rectangle to draw.</param>
	/// <summary>Fills the specified rectangle with the current color.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSFrameRect")]
		public extern static void FrameRect (CGRect rect);

		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSFrameRectWithWidth")]
		public extern static void FrameRect (CGRect rect, nfloat frameWidth);

		// Bad naming, added the overload above
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSFrameRectWithWidth")]
		public extern static void FrameRectWithWidth (CGRect rect, nfloat frameWidth);

		[DllImport (Constants.AppKitLibrary)]
		extern static void NSFrameRectWithWidthUsingOperation (CGRect rect, nfloat frameWidth, nuint operation);
		public static void FrameRect (CGRect rect, nfloat frameWidth, NSCompositingOperation operation)
		{
			NSFrameRectWithWidthUsingOperation (rect, frameWidth, (nuint) (ulong) operation);
		}

		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'NSCursor.DisappearingItemCursor' instead.")]
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSShowAnimationEffect")]
		extern static void NSShowAnimationEffect (nuint animationEffect, CGPoint centerLocation, CGSize size, NativeHandle animationDelegate, NativeHandle didEndSelector, IntPtr contextInfo);

		/// <param name="animationEffect">The animation effect to show.</param>
		///         <param name="centerLocation">The center point of the animation.</param>
		///         <param name="size">The size of the animation.</param>
		///         <param name="animationDelegate">The delegate to notify when the animation ends.</param>
		///         <param name="didEndSelector">The selector to invoke when the animation ends.</param>
		///         <param name="contextInfo">Context information passed to the callback.</param>
	/// <summary>Shows the specified animation effect at the given location.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'NSCursor.DisappearingItemCursor' instead.")]
		public static void ShowAnimationEffect (NSAnimationEffect animationEffect, CGPoint centerLocation, CGSize size, NSObject animationDelegate, Selector didEndSelector, IntPtr contextInfo)
		{
			NSShowAnimationEffect ((nuint) (ulong) animationEffect, centerLocation, size, animationDelegate.GetHandle (), didEndSelector.Handle, contextInfo);
			GC.KeepAlive (animationDelegate);
			GC.KeepAlive (didEndSelector);
		}

		/// <param name="animationEffect">The animation effect to show.</param>
		///         <param name="centerLocation">The center point of the animation.</param>
		///         <param name="size">The size of the animation.</param>
		///         <param name="endedCallback">The action to invoke when the animation ends.</param>
	/// <summary>Shows the specified animation effect and invokes the callback when done.</summary>
		public static void ShowAnimationEffect (NSAnimationEffect animationEffect, CGPoint centerLocation, CGSize size, Action endedCallback)
		{
			var d = new NSAsyncActionDispatcher (endedCallback);
			ShowAnimationEffect (animationEffect, centerLocation, size, d, NSActionDispatcher.Selector, IntPtr.Zero);
			GC.KeepAlive (d);
		}

		/// <param name="placement">The focus ring placement.</param>
	/// <summary>Sets the style of the focus ring.</summary>
		public static void SetFocusRingStyle (NSFocusRingPlacement placement)
		{
			SetFocusRingStyle ((nuint) (ulong) placement);
		}

		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSSetFocusRingStyle")]
		extern static void SetFocusRingStyle (nuint placement);

		/// <param name="aRect">The rectangle.</param>
		///         <param name="clipRect">The clipping rectangle.</param>
	/// <summary>Draws a white bezel border.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSDrawWhiteBezel")]
		public extern static void DrawWhiteBezel (CGRect aRect, CGRect clipRect);

		/// <param name="aRect">The rectangle.</param>
		///         <param name="clipRect">The clipping rectangle.</param>
	/// <summary>Draws a light bezel border.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSDrawLightBezel")]
		public extern static void DrawLightBezel (CGRect aRect, CGRect clipRect);

		/// <param name="aRect">The rectangle.</param>
		///         <param name="clipRect">The clipping rectangle.</param>
	/// <summary>Draws a gray bezel border.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSDrawGrayBezel")]
		public extern static void DrawGrayBezel (CGRect aRect, CGRect clipRect);

		/// <param name="aRect">The rectangle.</param>
		///         <param name="clipRect">The clipping rectangle.</param>
	/// <summary>Draws a dark bezel border.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSDrawDarkBezel")]
		public extern static void DrawDarkBezel (CGRect aRect, CGRect clipRect);

		/// <param name="aRect">The rectangle.</param>
		///         <param name="clipRect">The clipping rectangle.</param>
	/// <summary>Draws a groove border.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSDrawGroove")]
		public extern static void DrawGroove (CGRect aRect, CGRect clipRect);

		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSDrawTiledRects")]
		unsafe extern static CGRect DrawTiledRects (CGRect aRect, CGRect clipRect, NSRectEdge* sides, nfloat* grays, nint count);

		public static CGRect DrawTiledRects (CGRect aRect, CGRect clipRect, NSRectEdge [] sides, nfloat [] grays)
		{
			if (sides is null)
				throw new ArgumentNullException ("sides");
			if (grays is null)
				throw new ArgumentNullException ("grays");
			if (sides.Length != grays.Length)
				throw new ArgumentOutOfRangeException ("grays", "Both array parameters must have the same length");
			unsafe {
				fixed (NSRectEdge* ptr = sides)
				fixed (nfloat* ptr2 = grays)
					return DrawTiledRects (aRect, clipRect, ptr, ptr2, sides.Length);
			}
		}

		/// <param name="aRect">The rectangle.</param>
	/// <summary>Fills the specified rectangle with the window background color.</summary>
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSDrawWindowBackground")]
		public extern static void DrawWindowBackground (CGRect aRect);

		/// <summary>Disables screen updates temporarily.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.11", "Not usually necessary, 'NSAnimationContext.RunAnimation' can be used instead and not suffer from performance issues.")]
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSDisableScreenUpdates")]
		public extern static void DisableScreenUpdates ();

		/// <summary>Disables screen updates temporarily.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.11", "Not usually necessary, 'NSAnimationContext.RunAnimation' can be used instead and not suffer from performance issues.")]
		[DllImport (Constants.AppKitLibrary, EntryPoint = "NSEnableScreenUpdates")]
		public extern static void EnableScreenUpdates ();

	}
}
#endif // !__MACCATALYST__
