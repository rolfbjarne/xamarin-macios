// 
// CTFrame.cs: Implements the managed CTFrame
//
// Authors: Mono Team
//     
// Copyright 2010 Novell, Inc
// Copyright 2011, 2012 Xamarin Inc
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

	/// <summary>An enumeration whose values can be used as flags with the <see cref="CoreText.CTFrameAttributes.Progression" /> property.</summary>
	///     <remarks>Specifies the line-stacking behavior of a frame. <see cref="CoreText.CTFrameProgression.RightToLeft" /> stacks lines left-to-right when used with vertical text, <see cref="CoreText.CTFrameProgression.TopToBottom" /> stacks lines top-to-bottom for horizontal text.</remarks>
	[Flags]
	public enum CTFrameProgression : uint {
		/// <summary>Indicates top to bottom.</summary>
		TopToBottom = 0,
		/// <summary>Indicates right to left.</summary>
		RightToLeft = 1,
		LeftToRight = 2,
	}

	/// <summary>An enumeration whose values specify the fill rule used by a <see cref="CoreText.CTFrame" />.</summary>
	public enum CTFramePathFillRule {
		/// <summary>Indicates even odd.</summary>
		EvenOdd,
		/// <summary>Indicates winding number.</summary>
		WindingNumber,
	}

	/// <summary>Encapsulates the attributes used in the creation of a <see cref="CoreText.CTFrame" />.</summary>
	///     <altmember cref="CoreText.CTFrameAttributeKey" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFrameAttributes {

		/// <summary>Creates a new <see cref="CTFrameAttributes" /> instance.</summary>
		public CTFrameAttributes ()
			: this (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary.</param>
		///         <summary>Creates a new <see cref="CTFrameAttributes" /> instance.</summary>
		public CTFrameAttributes (NSDictionary dictionary)
		{
			if (dictionary is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dictionary));
			Dictionary = dictionary;
		}

		/// <summary>Gets or sets the dictionary.</summary>
		public NSDictionary Dictionary { get; private set; }

		/// <summary>Gets or sets the progression.</summary>
		public CTFrameProgression? Progression {
			get {
				var value = Adapter.GetUInt32Value (Dictionary, CTFrameAttributeKey.Progression);
				return !value.HasValue ? null : (CTFrameProgression?) value.Value;
			}
			set {
				Adapter.SetValue (Dictionary, CTFrameAttributeKey.Progression!,
						value.HasValue ? (uint?) value.Value : null);
			}
		}
	}

	internal static class CTFrameAttributesExtensions {
		public static IntPtr GetHandle (this CTFrameAttributes? self)
		{
			if (self is null)
				return IntPtr.Zero;
			return self.Dictionary.GetHandle ();
		}
	}

	/// <summary>A rectangular area containing lines of text.</summary>
	///     <related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/SimpleTextInput/">SimpleTextInput</related>
	///     <altmember cref="CoreText.CTLine" />
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTFrame : NativeObject {
		[Preserve (Conditional = true)]
		internal CTFrame (NativeHandle handle, bool owns)
			: base (handle, owns, verify: true)
		{
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static NSRange CTFrameGetStringRange (IntPtr handle);
		[DllImport (Constants.CoreTextLibrary)]
		extern static NSRange CTFrameGetVisibleStringRange (IntPtr handle);

		/// <summary>Gets string range.</summary>
		public NSRange GetStringRange ()
		{
			return CTFrameGetStringRange (Handle);
		}

		/// <summary>Gets visible string range.</summary>
		public NSRange GetVisibleStringRange ()
		{
			return CTFrameGetVisibleStringRange (Handle);
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static IntPtr CTFrameGetPath (IntPtr handle);

		/// <summary>Gets path.</summary>
		public CGPath? GetPath ()
		{
			IntPtr h = CTFrameGetPath (Handle);
			return h == IntPtr.Zero ? null : new CGPath (h, false);
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static IntPtr CTFrameGetFrameAttributes (IntPtr handle);

		/// <summary>Gets frame attributes.</summary>
		public CTFrameAttributes? GetFrameAttributes ()
		{
			var attrs = Runtime.GetNSObject<NSDictionary> (CTFrameGetFrameAttributes (Handle));
			return attrs is null ? null : new CTFrameAttributes (attrs);
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static IntPtr CTFrameGetLines (IntPtr handle);

		/// <summary>To be added.</summary>
		public CTLine [] GetLines ()
		{
			var cfArrayRef = CTFrameGetLines (Handle);
			if (cfArrayRef == IntPtr.Zero)
				return Array.Empty<CTLine> ();

			return NSArray.ArrayFromHandleFunc<CTLine> (cfArrayRef, (p) => {
				// We need to take a ref, since we dispose it later.
				return new CTLine (p, false);
			})!;
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static void CTFrameGetLineOrigins (IntPtr handle, NSRange range, [Out] CGPoint [] origins);
		/// <param name="range">The range.</param>
		///         <param name="origins">The origins.</param>
		///         <summary>Gets line origins.</summary>
		public void GetLineOrigins (NSRange range, CGPoint [] origins)
		{
			if (origins is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (origins));
			if (range.Length != 0 && origins.Length < range.Length)
				throw new ArgumentException ("origins must contain at least range.Length elements.", nameof (origins));
			else if (origins.Length < CFArray.GetCount (CTFrameGetLines (Handle)))
				throw new ArgumentException ("origins must contain at least GetLines().Length elements.", nameof (origins));
			CTFrameGetLineOrigins (Handle, range, origins);
		}

		[DllImport (Constants.CoreTextLibrary)]
		extern static void CTFrameDraw (IntPtr handle, IntPtr context);

		/// <param name="ctx">The ctx.</param>
		///         <summary>Draw.</summary>
		public void Draw (CGContext ctx)
		{
			if (ctx is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ctx));

			CTFrameDraw (Handle, ctx.Handle);
			GC.KeepAlive (ctx);
		}
	}
}
