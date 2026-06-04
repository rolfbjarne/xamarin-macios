// 
// CTRun.cs: Implements the managed CTFrame
//
// Authors: Mono Team
//          Rolf Bjarne Kvinge <rolf@xamarin.com>
//     
// Copyright 2010 Novell, Inc
// Copyright 2014 Xamarin Inc (http://www.xamarin.com)
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

#nullable enable

using CoreFoundation;
using CoreGraphics;

namespace CoreText {

	// defined as uint32_t - System/Library/Frameworks/CoreText.framework/Headers/CTRun.h
	/// <summary>An enumeration whose values describe the <see cref="CoreText.CTRun.Status" /> of a <see cref="CoreText.CTRun" />.</summary>
	public enum CTRunStatus {
		/// <summary>Indicates no status.</summary>
		NoStatus = 0,
		/// <summary>Indicates right to left.</summary>
		RightToLeft = (1 << 0),
		/// <summary>Indicates non monotonic.</summary>
		NonMonotonic = (1 << 1),
		/// <summary>Indicates has non identity matrix.</summary>
		HasNonIdentityMatrix = (1 << 2),
	}

	/// <summary>A glyph run. That is, a series of consecutive glyphs with the same attributes and direction.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTRun : NativeObject {
		[Preserve (Conditional = true)]
		internal CTRun (NativeHandle handle, bool owns)
			: base (handle, owns, true)
		{
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static void CTRunDraw (IntPtr h, IntPtr context, NSRange range);
		/// <param name="context">The context to use.</param>
		///         <param name="range">The range.</param>
		/// <summary>Draws the glyphs in the specified range to the given graphics context.</summary>
		public void Draw (CGContext context, NSRange range)
		{
			CTRunDraw (Handle, context.Handle, range);
			GC.KeepAlive (context);
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static void CTRunGetAdvances (IntPtr h, NSRange range, [In, Out] CGSize []? buffer);
		/// <param name="range">The range.</param>
		///         <param name="buffer">The buffer.</param>
		/// <summary>Gets the advance widths for glyphs in the specified range.</summary>
		public CGSize [] GetAdvances (NSRange range, CGSize []? buffer)
		{
			buffer = GetBuffer (range, buffer);

			CTRunGetAdvances (Handle, range, buffer);

			return buffer;
		}

		T [] GetBuffer<T> (NSRange range, T []? buffer)
		{
			var glyphCount = GlyphCount;

			if (buffer is not null && range.Length != 0 && buffer.Length < range.Length)
				throw new ArgumentException ("buffer.Length must be >= range.Length.", nameof (buffer));
			if (buffer is not null && range.Length == 0 && buffer.Length < glyphCount)
				throw new ArgumentException ("buffer.Length must be >= GlyphCount.", nameof (buffer));

			return buffer ?? new T [range.Length == 0 ? glyphCount : range.Length];
		}

		/// <param name="range">The range.</param>
		/// <summary>Gets the advance widths for glyphs in the specified range.</summary>
		public CGSize [] GetAdvances (NSRange range)
		{
			return GetAdvances (range, null);
		}

	/// <summary>Gets the advance widths for all glyphs in the run.</summary>
		public CGSize [] GetAdvances ()
		{
			return GetAdvances (new NSRange (0, 0), null);
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static IntPtr CTRunGetAttributes (IntPtr handle);

	/// <summary>Gets the string attributes for this run.</summary>
		public CTStringAttributes? GetAttributes ()
		{
			var d = Runtime.GetNSObject<NSDictionary> (CTRunGetAttributes (Handle));
			return d is null ? null : new CTStringAttributes (d);
		}


		[DllImport (Constants.CoreTextLibrary)]
		extern static nint CTRunGetGlyphCount (IntPtr handle);
	/// <summary>Gets the number of glyphs in this run.</summary>
		public nint GlyphCount {
			get {
				return CTRunGetGlyphCount (Handle);
			}
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static void CTRunGetGlyphs (IntPtr h, NSRange range, [In, Out] ushort []? buffer);
		/// <param name="range">The range.</param>
		///         <param name="buffer">The buffer.</param>
		/// <summary>Gets the glyph IDs for glyphs in the specified range.</summary>
		public ushort [] GetGlyphs (NSRange range, ushort []? buffer)
		{
			buffer = GetBuffer (range, buffer);

			CTRunGetGlyphs (Handle, range, buffer);

			return buffer;
		}

		/// <param name="range">The range.</param>
		/// <summary>Gets the glyph IDs for glyphs in the specified range.</summary>
		public ushort [] GetGlyphs (NSRange range)
		{
			return GetGlyphs (range, null);
		}

	/// <summary>Gets the glyph IDs for all glyphs in the run.</summary>
		public ushort [] GetGlyphs ()
		{
			return GetGlyphs (new NSRange (0, 0), null);
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static CGRect CTRunGetImageBounds (IntPtr h, IntPtr context, NSRange range);
		/// <param name="context">The context to use.</param>
		///         <param name="range">The range.</param>
		/// <summary>Gets the bounding rectangle for the glyphs in the specified range.</summary>
		public CGRect GetImageBounds (CGContext context, NSRange range)
		{
			CGRect bounds = CTRunGetImageBounds (Handle, context.Handle, range);
			GC.KeepAlive (context);
			return bounds;
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static void CTRunGetPositions (IntPtr h, NSRange range, [In, Out] CGPoint []? buffer);
		/// <param name="range">The range.</param>
		///         <param name="buffer">The buffer.</param>
		/// <summary>Gets the glyph positions in the specified range.</summary>
		public CGPoint [] GetPositions (NSRange range, CGPoint []? buffer)
		{
			buffer = GetBuffer (range, buffer);

			CTRunGetPositions (Handle, range, buffer);

			return buffer;
		}

		/// <param name="range">The range.</param>
		/// <summary>Gets the glyph positions in the specified range.</summary>
		public CGPoint [] GetPositions (NSRange range)
		{
			return GetPositions (range, null);
		}

	/// <summary>Gets the positions for all glyphs in the run.</summary>
		public CGPoint [] GetPositions ()
		{
			return GetPositions (new NSRange (0, 0), null);
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static CTRunStatus CTRunGetStatus (IntPtr handle);
	/// <summary>Gets the status flags for this run.</summary>
		public CTRunStatus Status {
			get {
				return CTRunGetStatus (Handle);
			}
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static void CTRunGetStringIndices (IntPtr h, NSRange range, [In, Out] nint /* CFIndex */ []? buffer);
		public nint [] GetStringIndices (NSRange range, nint []? buffer)
		{
			buffer = GetBuffer (range, buffer);

			CTRunGetStringIndices (Handle, range, buffer);

			return buffer;
		}

		/// <param name="range">The range.</param>
		/// <summary>Gets the string indices for glyphs in the specified range.</summary>
		public nint [] GetStringIndices (NSRange range)
		{
			return GetStringIndices (range, null);
		}

	/// <summary>Gets the string indices for all glyphs in the run.</summary>
		public nint [] GetStringIndices ()
		{
			return GetStringIndices (new NSRange (0, 0), null);
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static NSRange CTRunGetStringRange (IntPtr handle);
	/// <summary>Gets the range of characters that this run covers in the original string.</summary>
		public NSRange StringRange {
			get {
				return CTRunGetStringRange (Handle);
			}
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static CGAffineTransform CTRunGetTextMatrix (IntPtr handle);
	/// <summary>Gets the text matrix for this run.</summary>
		public CGAffineTransform TextMatrix {
			get {
				return CTRunGetTextMatrix (Handle);
			}
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static double CTRunGetTypographicBounds (IntPtr h, NSRange range, out nfloat ascent, out nfloat descent, out nfloat leading);

		[DllImport (Constants.CoreTextLibrary)]
		extern static double CTRunGetTypographicBounds (IntPtr h, NSRange range, IntPtr ascent, IntPtr descent, IntPtr leading);
		public double GetTypographicBounds (NSRange range, out nfloat ascent, out nfloat descent, out nfloat leading)
		{
			return CTRunGetTypographicBounds (Handle, range, out ascent, out descent, out leading);
		}

	/// <summary>Gets the typographic bounds (ascent, descent, and leading) for all glyphs in the run.</summary>
		public double GetTypographicBounds ()
		{
			NSRange range = new NSRange () { Location = 0, Length = 0 };
			return CTRunGetTypographicBounds (Handle, range, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
		}

		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.CoreTextLibrary)]
		static extern void CTRunGetBaseAdvancesAndOrigins (/* CTRunRef */ IntPtr runRef, /* CFRange */ NSRange range, CGSize [] advancesBuffer, CGPoint [] originsBuffer);

		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public void GetBaseAdvancesAndOrigins (NSRange range, out CGSize [] advancesBuffer, out CGPoint [] originsBuffer)
		{
			advancesBuffer = GetBuffer<CGSize> (range, null);
			originsBuffer = GetBuffer<CGPoint> (range, null);
			CTRunGetBaseAdvancesAndOrigins (Handle, range, advancesBuffer, originsBuffer);
		}
	}
}
