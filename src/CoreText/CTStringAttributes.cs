// 
// CTStringAttributes.cs: Implements the managed CTStringAttributes
//
// Authors: Mono Team
//          Marek Safar (marek.safar@gmail.com)
//          Rolf Bjarne Kvinge <rolf@xamarin.com>
//     
// Copyright 2010 Novell, Inc
// Copyright 2012 - 2014 Xamarin Inc.
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

using System.Collections.Generic;

using CoreFoundation;
using CoreGraphics;

#if !MONOMAC
using UIKit;
#endif

namespace CoreText {

	#region CFAttributedStringRef AttributeKey Prototypes
	// defined as int32_t - System/Library/Frameworks/CoreText.framework/Headers/CTStringAttributes.h
	/// <summary>Specifies the style of an underline ornament.</summary>
	public enum CTUnderlineStyle : int {
		/// <summary>No underline.</summary>
		None = 0x00,
		/// <summary>A single underline.</summary>
		Single = 0x01,
		/// <summary>A thick underline.</summary>
		Thick = 0x02,
		/// <summary>A double underline.</summary>
		Double = 0x09,
	}

	// defined as int32_t - System/Library/Frameworks/CoreText.framework/Headers/CTStringAttributes.h
	/// <summary>An enumeration whose values specify options for <see cref="CoreText.CTUnderlineStyle" />s.</summary>
	public enum CTUnderlineStyleModifiers : int {
		/// <summary>A solid underline pattern.</summary>
		PatternSolid = 0x0000,
		/// <summary>A dotted underline pattern.</summary>
		PatternDot = 0x0100,
		/// <summary>A dashed underline pattern.</summary>
		PatternDash = 0x0200,
		/// <summary>A dash-dot underline pattern.</summary>
		PatternDashDot = 0x0300,
		/// <summary>A dash-dot-dot underline pattern.</summary>
		PatternDashDotDot = 0x0400,
	}

	/// <summary>An enumeration whose values specify the importance of ligatures in a <see cref="CoreText.CTStringAttributes" />.</summary>
	///     <altmember cref="CoreText.CTStringAttributes.LigatureFormation" />
	public enum CTLigatureFormation {
		/// <summary>Only essential ligatures are applied.</summary>
		Essential = 0,
		/// <summary>Standard ligatures are applied.</summary>
		Standard = 1,
		/// <summary>All available ligatures are applied.</summary>
		All = 2,
	}

	/// <summary>An enumeration whose values describe the style of super- and sub- -scripts.</summary>
	public enum CTSuperscriptStyle {
		/// <summary>Normal baseline text.</summary>
		None = 0,
		/// <summary>Superscript text.</summary>
		Superscript = 1,
		/// <summary>Subscript text.</summary>
		Subscript = -1,
	}
	#endregion

	/// <summary>Specifies the attributes of a <see cref="CoreText.CTRun" />.</summary>
	///     <altmember cref="CoreText.CTRun.GetAttributes" />
	///     <related type="sample" href="https://github.com/xamarin/ios-samples/tree/master/SimpleTextInput/">SimpleTextInput</related>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class CTStringAttributes {

	/// <summary>Initializes a new instance with an empty attributes dictionary.</summary>
		public CTStringAttributes ()
			: this (new NSMutableDictionary ())
		{
		}

		/// <param name="dictionary">The dictionary containing the string attributes.</param>
	/// <summary>Initializes a new instance from an existing attributes dictionary.</summary>
		public CTStringAttributes (NSDictionary dictionary)
		{
			if (dictionary is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dictionary));
			Dictionary = dictionary;
		}

	/// <summary>Gets the underlying dictionary of string attributes.</summary>
		public NSDictionary Dictionary { get; private set; }

	/// <summary>Gets or sets the font.</summary>
		public CTFont? Font {
			get {
				var h = CFDictionary.GetValue (Dictionary.Handle, CTStringAttributeKey.Font.GetHandle ());
				return h == IntPtr.Zero ? null : new CTFont (h, false);
			}
			set { Adapter.SetNativeValue (Dictionary, CTStringAttributeKey.Font!, value); }
		}

	/// <summary>Gets or sets the kerning adjustment.</summary>
		public bool ForegroundColorFromContext {
			get {
				return CFDictionary.GetBooleanValue (Dictionary.Handle,
						CTStringAttributeKey.ForegroundColorFromContext.GetHandle ());
			}
			set {
				Adapter.AssertWritable (Dictionary);
				CFMutableDictionary.SetValue (Dictionary.Handle,
						CTStringAttributeKey.ForegroundColorFromContext.GetHandle (), value);
			}
		}

		// Header says 'Value must be a CFNumberRef float' - System/Library/Frameworks/CoreText.framework/Headers/CTStringAttributes.h
	/// <summary>Gets or sets the foreground color.</summary>
		public float? KerningAdjustment {
			get { return Adapter.GetSingleValue (Dictionary, CTStringAttributeKey.KerningAdjustment); }
			set { Adapter.SetValue (Dictionary, CTStringAttributeKey.KerningAdjustment!, value); }
		}

		// Documentation says this must be 'CFNumber', doesn't specify exact type (but implies it's an integer value)
	/// <summary>Gets or sets the background color.</summary>
		public CTLigatureFormation? LigatureFormation {
			get {
				var value = Adapter.GetInt32Value (Dictionary, CTStringAttributeKey.LigatureFormation);
				return !value.HasValue ? null : (CTLigatureFormation?) value.Value;
			}
			set {
				Adapter.SetValue (Dictionary, CTStringAttributeKey.LigatureFormation!,
						value.HasValue ? (int?) value.Value : null);
			}
		}

	/// <summary>Gets or sets the paragraph style.</summary>
		public CGColor? ForegroundColor {
			get {
				var h = CFDictionary.GetValue (Dictionary.Handle, CTStringAttributeKey.ForegroundColor.GetHandle ());
				return h == IntPtr.Zero ? null : new CGColor (h, false);
			}
			set { Adapter.SetNativeValue (Dictionary, CTStringAttributeKey.ForegroundColor!, value); }
		}

	/// <summary>Gets or sets the stroke width.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public CGColor? BackgroundColor {
			get {
				var x = CTStringAttributeKey.BackgroundColor;
				if (x is not null) {
					var h = CFDictionary.GetValue (Dictionary.Handle, x.Handle);
					CGColor result = new CGColor (h, false);
					GC.KeepAlive (x);
					return result;
				} else {
					return null;
				}
			}
			set {
				var x = CTStringAttributeKey.BackgroundColor;
				if (x is not null)
					Adapter.SetNativeValue (Dictionary, x, value);
			}
		}

	/// <summary>Gets or sets the raw underline style value.</summary>
		public CTParagraphStyle? ParagraphStyle {
			get {
				var h = CFDictionary.GetValue (Dictionary.Handle, CTStringAttributeKey.ParagraphStyle.GetHandle ());
				return h == IntPtr.Zero ? null : new CTParagraphStyle (h, false);
			}
			set { Adapter.SetNativeValue (Dictionary, CTStringAttributeKey.ParagraphStyle!, value); }
		}

		// Documentation says this must be 'CFNumber', doesn't specify exact type (but implies it's a floating point value)
	/// <summary>Gets or sets the underline style.</summary>
		public float? StrokeWidth {
			get { return Adapter.GetSingleValue (Dictionary, CTStringAttributeKey.StrokeWidth); }
			set { Adapter.SetValue (Dictionary, CTStringAttributeKey.StrokeWidth!, value); }
		}

	/// <summary>Gets or sets the underline style modifiers.</summary>
		public CGColor? StrokeColor {
			get {
				var h = CFDictionary.GetValue (Dictionary.Handle, CTStringAttributeKey.StrokeColor.GetHandle ());
				return h == IntPtr.Zero ? null : new CGColor (h, false);
			}
			set { Adapter.SetNativeValue (Dictionary, CTStringAttributeKey.StrokeColor!, value); }
		}

		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public float? TrackingAdjustment {
			get { return Adapter.GetSingleValue (Dictionary, CTStringAttributeKey.TrackingAttributeName); }
			set { Adapter.SetValue (Dictionary, CTStringAttributeKey.TrackingAttributeName, value); }
		}

		// Documentation says this must be 'CFNumber', doesn't specify exact type
	/// <summary>Gets or sets the superscript style.</summary>
		public int? UnderlineStyleValue {
			get { return Adapter.GetInt32Value (Dictionary, CTStringAttributeKey.UnderlineStyle); }
			set { Adapter.SetValue (Dictionary, CTStringAttributeKey.UnderlineStyle!, value); }
		}

		const int UnderlineStyleMask = 0x000F;
		const int UnderlineStyleModifiersMask = 0x0700;

	/// <summary>Gets or sets the underline color.</summary>
		public CTUnderlineStyle? UnderlineStyle {
			get {
				var v = UnderlineStyleValue;
				return !v.HasValue ? null : (CTUnderlineStyle?) (v.Value & UnderlineStyleMask);
			}
			set {
				var m = UnderlineStyleModifiers;
				UnderlineStyleValue = Adapter.BitwiseOr (
						m.HasValue ? (int?) m.Value : null,
						value.HasValue ? (int?) value.Value : null);
			}
		}

	/// <summary>Gets or sets whether vertical glyph forms are used.</summary>
		public CTUnderlineStyleModifiers? UnderlineStyleModifiers {
			get {
				var v = UnderlineStyleValue;
				return !v.HasValue ? null : (CTUnderlineStyleModifiers?) (v.Value & UnderlineStyleModifiersMask);
			}
			set {
				var m = UnderlineStyleModifiers;
				UnderlineStyleValue = Adapter.BitwiseOr (
						m.HasValue ? (int?) m.Value : null,
						value.HasValue ? (int?) value.Value : null);
			}
		}

	/// <summary>Gets or sets the number of horizontal glyphs to set within a vertical glyph.</summary>
		public CTSuperscriptStyle? Superscript {
			get {
				var value = Adapter.GetInt32Value (Dictionary, CTStringAttributeKey.Superscript);
				return !value.HasValue ? null : (CTSuperscriptStyle?) value.Value;
			}
			set {
				Adapter.SetValue (Dictionary, CTStringAttributeKey.Superscript!,
						value.HasValue ? (int?) value.Value : null);
			}
		}

	/// <summary>Gets or sets the baseline offset.</summary>
		public CGColor? UnderlineColor {
			get {
				var h = CFDictionary.GetValue (Dictionary.Handle, CTStringAttributeKey.UnderlineColor.GetHandle ());
				return h == IntPtr.Zero ? null : new CGColor (h, false);
			}
			set { Adapter.SetNativeValue (Dictionary, CTStringAttributeKey.UnderlineColor!, value); }
		}

	/// <summary>Gets or sets the glyph info.</summary>
		public bool VerticalForms {
			get {
				return CFDictionary.GetBooleanValue (Dictionary.Handle,
						CTStringAttributeKey.VerticalForms.GetHandle ());
			}
			set {
				Adapter.AssertWritable (Dictionary);
				CFMutableDictionary.SetValue (Dictionary.Handle,
						CTStringAttributeKey.VerticalForms.GetHandle (), value);
			}
		}

	/// <summary>Gets or sets the character shape.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public int? HorizontalInVerticalForms {
			get {
				var x = CTStringAttributeKey.HorizontalInVerticalForms;
				return x is not null ? Adapter.GetInt32Value (Dictionary, x) : null;
			}
			set {
				var x = CTStringAttributeKey.HorizontalInVerticalForms;
				if (x is not null)
					Adapter.SetValue (Dictionary, x, value);
			}
		}

	/// <summary>Gets or sets the run delegate.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public float? BaselineOffset {
			get { return Adapter.GetSingleValue (Dictionary, CTStringAttributeKey.BaselineOffset); }
			set { Adapter.SetValue (Dictionary, CTStringAttributeKey.BaselineOffset!, value); }
		}

	/// <summary>Gets or sets the baseline class.</summary>
		public CTGlyphInfo? GlyphInfo {
			get {
				var h = CFDictionary.GetValue (Dictionary.Handle, CTStringAttributeKey.GlyphInfo.GetHandle ());
				return h == IntPtr.Zero ? null : new CTGlyphInfo (h, false);
			}
			set { Adapter.SetNativeValue (Dictionary, CTStringAttributeKey.GlyphInfo!, value); }
		}

	/// <summary>Gets or sets the stroke color.</summary>
		public int? CharacterShape {
			get { return Adapter.GetInt32Value (Dictionary, CTStringAttributeKey.CharacterShape); }
			set { Adapter.SetValue (Dictionary, CTStringAttributeKey.CharacterShape!, value); }
		}

	/// <summary>Gets or sets the ligature formation level.</summary>
		public CTRunDelegate? RunDelegate {
			get {
				var h = CFDictionary.GetValue (Dictionary.Handle, CTStringAttributeKey.RunDelegate.GetHandle ());
				return h == IntPtr.Zero ? null : new CTRunDelegate (h, false);
			}
			set { Adapter.SetNativeValue (Dictionary, CTStringAttributeKey.RunDelegate!, value); }
		}

	/// <summary>Sets baseline info for the specified baseline class and offset.</summary>
		public CTBaselineClass? BaselineClass {
			get {
				var value = CFDictionary.GetValue (Dictionary.Handle, CTStringAttributeKey.BaselineClass.GetHandle ());
				return value == IntPtr.Zero ? (CTBaselineClass?) null : CTBaselineClassID.FromHandle (value);
			}
			set {
				var ns_value = value is null ? null : CTBaselineClassID.ToNSString (value.Value);
				Adapter.SetNativeValue (Dictionary, CTStringAttributeKey.BaselineClass!, ns_value);
			}
		}

		/// <param name="baselineClass">The baseline class to set.</param>
		///         <param name="offset">The baseline offset value.</param>
	/// <summary>Sets the writing direction for the text.</summary>
		public void SetBaselineInfo (CTBaselineClass baselineClass, double offset)
		{
			SetBaseline (baselineClass, offset, CTStringAttributeKey.BaselineInfo);
		}

		/// <param name="baselineClass">The kind of baseline to set.</param>
		///         <param name="offset">The offset to alter.</param>
		///         <summary>Applies a baseline change.</summary>
		///         <remarks>
		///         </remarks>
		public void SetBaselineReferenceInfo (CTBaselineClass baselineClass, double offset)
		{
			SetBaseline (baselineClass, offset, CTStringAttributeKey.BaselineReferenceInfo);
		}

		void SetBaseline (CTBaselineClass baselineClass, double offset, NSString? infoKey)
		{
			var ptr = CFDictionary.GetValue (Dictionary.Handle, infoKey.GetHandle ());
			var dict = ptr == IntPtr.Zero ? new NSMutableDictionary () : new NSMutableDictionary (ptr);

			var key = CTBaselineClassID.ToNSString (baselineClass);
			Adapter.SetValue (dict, key!, new NSNumber (offset));

			if (ptr == IntPtr.Zero)
				Adapter.SetNativeValue (Dictionary, infoKey!, (INativeObject) dict);
		}

		// 'Value must be a CFArray of CFNumberRefs' - System/Library/Frameworks/CoreText.framework/Headers/CTStringAttributes.h
		/// <param name="writingDirections">The writing directions to set.</param>
	/// <summary>Gets or sets the stroke color.</summary>
		public void SetWritingDirection (params CTWritingDirection [] writingDirections)
		{
			var ptrs = new NativeHandle [writingDirections.Length];
			var numbers = new NSNumber [writingDirections.Length];
			for (int i = 0; i < writingDirections.Length; ++i) {
				numbers [i] = new NSNumber ((int) writingDirections [i]);
				ptrs [i] = numbers [i].Handle;
			}

			var array = CFArray.Create (ptrs);
			CFMutableDictionary.SetValue (Dictionary.Handle, CTStringAttributeKey.WritingDirection.GetHandle (), array);
			GC.KeepAlive (numbers); // make sure the numbers aren't freed until we're done with them
		}

		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
		// The attribute value must be an object conforming to the CTAdaptiveImageProviding protocol.
		public ICTAdaptiveImageProviding? AdaptiveImageProvider {
			get {
				var h = CFDictionary.GetValue (Dictionary.Handle, CTStringAttributeKey.AdaptiveImageProvider.GetHandle ());
				return Runtime.GetINativeObject<ICTAdaptiveImageProviding> (h, owns: false);
			}
			set {
				Adapter.SetNativeValue (Dictionary, CTStringAttributeKey.AdaptiveImageProvider!, value);
			}
		}
	}
}
