#if !__MACCATALYST__
using CoreFoundation;
using CoreGraphics;
using CoreAnimation;
using CoreText;

using CGGlyph = System.UInt16;

#nullable enable

namespace AppKit {
	public partial class NSFont {
		/// <param name="font">The Core Text font to convert.</param>
	/// <summary>Creates an <see cref="NSFont" /> from a Core Text <see cref="CTFont" />.</summary>
		public static NSFont? FromCTFont (CTFont? font)
		{
			if (font is null)
				return null;
			var result = new NSFont (font.Handle);
			GC.KeepAlive (font);
			return result;
		}

		/// <param name="glyphs">The array of glyphs to measure.</param>
	/// <summary>Gets the bounding rectangles for the specified glyphs.</summary>
		public unsafe CGRect [] GetBoundingRects (CGGlyph [] glyphs)
		{
			if (glyphs is null)
				throw new ArgumentNullException ("glyphs");
			if (glyphs.Length < 1)
				throw new ArgumentException ("glyphs array is empty");

			CGRect [] bounds = new CGRect [glyphs.Length];
			fixed (CGRect* boundsPtr = bounds) {
				fixed (CGGlyph* glyphsPtr = glyphs) {
					_GetBoundingRects ((IntPtr) boundsPtr, (IntPtr) glyphsPtr, (nuint) glyphs.Length);
				}
			}
			return bounds;
		}

		/// <param name="glyphs">The array of glyphs to measure.</param>
	/// <summary>Gets the advancement sizes for the specified glyphs.</summary>
		public unsafe CGSize [] GetAdvancements (CGGlyph [] glyphs)
		{
			if (glyphs is null)
				throw new ArgumentNullException ("glyphs");
			if (glyphs.Length < 1)
				throw new ArgumentException ("glyphs array is empty");

			CGSize [] advancements = new CGSize [glyphs.Length];
			fixed (CGSize* advancementsPtr = advancements) {
				fixed (CGGlyph* glyphsPtr = glyphs) {
					_GetAdvancements ((IntPtr) advancementsPtr, (IntPtr) glyphsPtr, (nuint) glyphs.Length);
				}
			}
			return advancements;
		}

		/// <param name="fontName">The PostScript name of the font.</param>
		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Creates a font with the specified name and size.</summary>
		public static NSFont? FromFontName (string fontName, nfloat fontSize)
		{
			var ptr = _FromFontName (fontName, fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontDescriptor">The font descriptor that specifies the font attributes.</param>
		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Creates a font matching the specified descriptor and size.</summary>
		public static NSFont? FromDescription (NSFontDescriptor fontDescriptor, nfloat fontSize)
		{
			var ptr = _FromDescription (fontDescriptor, fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontDescriptor">The font descriptor that specifies the font attributes.</param>
		///         <param name="textTransform">The text transform to apply.</param>
	/// <summary>Creates a font matching the specified descriptor and text transform.</summary>
		public static NSFont? FromDescription (NSFontDescriptor fontDescriptor, NSAffineTransform textTransform)
		{
			var ptr = _FromDescription (fontDescriptor, textTransform);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the user font of the specified size.</summary>
		public static NSFont? UserFontOfSize (nfloat fontSize)
		{
			var ptr = _UserFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the user fixed-pitch font of the specified size.</summary>
		public static NSFont? UserFixedPitchFontOfSize (nfloat fontSize)
		{
			var ptr = _UserFixedPitchFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the system font of the specified size.</summary>
		public static NSFont? SystemFontOfSize (nfloat fontSize)
		{
			var ptr = _SystemFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the bold system font of the specified size.</summary>
		public static NSFont? BoldSystemFontOfSize (nfloat fontSize)
		{
			var ptr = _BoldSystemFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the label font of the specified size.</summary>
		public static NSFont? LabelFontOfSize (nfloat fontSize)
		{
			var ptr = _LabelFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the title bar font of the specified size.</summary>
		public static NSFont? TitleBarFontOfSize (nfloat fontSize)
		{
			var ptr = _TitleBarFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the menu font of the specified size.</summary>
		public static NSFont? MenuFontOfSize (nfloat fontSize)
		{
			var ptr = _MenuFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the menu bar font of the specified size.</summary>
		public static NSFont? MenuBarFontOfSize (nfloat fontSize)
		{
			var ptr = _MenuBarFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the message font of the specified size.</summary>
		public static NSFont? MessageFontOfSize (nfloat fontSize)
		{
			var ptr = _MessageFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the palette font of the specified size.</summary>
		public static NSFont? PaletteFontOfSize (nfloat fontSize)
		{
			var ptr = _PaletteFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the tool tips font of the specified size.</summary>
		public static NSFont? ToolTipsFontOfSize (nfloat fontSize)
		{
			var ptr = _ToolTipsFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
	/// <summary>Returns the control content font of the specified size.</summary>
		public static NSFont? ControlContentFontOfSize (nfloat fontSize)
		{
			var ptr = _ControlContentFontOfSize (fontSize);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

	/// <summary>Gets the printer font corresponding to this font.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSFont? PrinterFont {
			get {
				var ptr = _PrinterFont;
				return ptr == IntPtr.Zero ? null : new NSFont (ptr);
			}
		}

	/// <summary>Gets the screen font corresponding to this font.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSFont? ScreenFont {
			get {
				var ptr = _ScreenFont;
				return ptr == IntPtr.Zero ? null : new NSFont (ptr);
			}
		}

		/// <param name="renderingMode">The font rendering mode.</param>
	/// <summary>Returns the screen font for the specified rendering mode.</summary>
		[SupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSFont? ScreenFontWithRenderingMode (NSFontRenderingMode renderingMode)
		{
			var ptr = _ScreenFontWithRenderingMode (renderingMode);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

	/// <summary>Returns the vertical version of this font.</summary>
		public virtual NSFont? GetVerticalFont ()
		{
			var ptr = _GetVerticalFont ();
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
		/// <param name="weight">The weight of the font.</param>
	/// <summary>Returns the system font with the specified size and weight.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSFont? SystemFontOfSize (nfloat fontSize, nfloat weight)
		{
			var ptr = _SystemFontOfSize (fontSize, weight);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		public static NSFont? SystemFontOfSize (nfloat fontSize, nfloat weight, nfloat width)
		{
			var ptr = _SystemFontOfSize (fontSize, weight, width);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		/// <param name="fontSize">The size of the font in points.</param>
		/// <param name="weight">The weight of the font.</param>
	/// <summary>Returns the monospaced digit system font with the specified size and weight.</summary>
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSFont? MonospacedDigitSystemFontOfSize (nfloat fontSize, nfloat weight)
		{
			var ptr = _MonospacedDigitSystemFontOfSize (fontSize, weight);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}

		public static NSFont? MonospacedSystemFont (nfloat fontSize, nfloat weight)
		{
			var ptr = _MonospacedSystemFont (fontSize, weight);
			return ptr == IntPtr.Zero ? null : new NSFont (ptr);
		}
	}
}
#endif // !__MACCATALYST__
