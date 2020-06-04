//
// NSStringAttributes.cs: strongly typed AppKit-specific NSAttributedString attributes
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2013 Xamarin Inc

using System;

using ObjCRuntime;
using CoreFoundation;
using Foundation;

namespace AppKit
{
	public partial class NSStringAttributes : DictionaryContainer
	{
		static internal NSDictionary ToDictionary (
			NSFont font,
			NSColor foregroundColor,
			NSColor backgroundColor,
			NSColor strokeColor,
			NSColor underlineColor,
			NSColor strikethroughColor,
			NSUnderlineStyle underlineStyle,
			NSUnderlineStyle strikethroughStyle,
			NSParagraphStyle paragraphStyle,
			float strokeWidth,
			NSShadow shadow,
			NSUrl link,
			bool superscript,
			NSTextAttachment attachment,
			NSLigatureType ligature,
			float baselineOffset,
			float kerningAdjustment,
			float obliqueness,
			float expansion,
			NSCursor cursor,
			string toolTip,
			int characterShape,
			NSGlyphInfo glyphInfo,
			NSArray writingDirection,
			bool markedClauseSegment,
			NSTextLayoutOrientation verticalGlyphForm,
			NSTextAlternatives textAlternatives,
			NSSpellingState spellingState)
		{
			var attr = new NSStringAttributes ();

			if (font != null){
				attr.Font = font;
			}

			if (paragraphStyle != null) {
				attr.ParagraphStyle = paragraphStyle;
			}

			if (foregroundColor != null) {
				attr.ForegroundColor = foregroundColor;
			}

			if (underlineStyle != NSUnderlineStyle.None) {
				attr.UnderlineStyle = (int?)underlineStyle;
			}

			if (superscript) {
				attr.Superscript = true;
			}

			if (backgroundColor != null) {
				attr.BackgroundColor = backgroundColor;
			}

			if (attachment != null) {
				attr.Attachment = attachment;
			}

			if (ligature != NSLigatureType.Default) {
				attr.Ligature = ligature;
			}

			if (baselineOffset != 0) {
				attr.BaselineOffset = baselineOffset;
			}

			if (kerningAdjustment != 0) {
				attr.KerningAdjustment = kerningAdjustment;
			}

			if (link != null) {
				attr.Link = link;
			}

			if (strokeWidth != 0) {
				attr.StrokeWidth = strokeWidth;
			}

			if (strokeColor != null) {
				attr.StrokeColor = strokeColor;
			}

			if (underlineColor != null) {
				attr.UnderlineColor = underlineColor;
			}

			if (strikethroughStyle != NSUnderlineStyle.None) {
				attr.StrikethroughStyle = (int?)strikethroughStyle;
			}

			if (strikethroughColor != null) {
				attr.StrikethroughColor = strikethroughColor;
			}

			if (shadow != null) {
				attr.Shadow = shadow;
			}

			if (obliqueness != 0) {
				attr.Obliqueness = obliqueness;
			}

			if (expansion != 0) {
				attr.Expansion = expansion;
			}

			if (cursor != null) {
				attr.Cursor = cursor;
			}

			if (toolTip != null) {
				attr.ToolTip = toolTip;
			}

			if (characterShape != 0) {
				attr.CharacterShape = 0;
			}

			if (glyphInfo != null) {
				attr.GlyphInfo = glyphInfo;
			}

			if (writingDirection != null) {
				attr.WritingDirection = writingDirection;
			}

			if (markedClauseSegment) {
				attr.MarkedClauseSegment = true;
			}

			if (verticalGlyphForm != NSTextLayoutOrientation.Horizontal) {
				attr.VerticalGlyphForm = verticalGlyphForm;
			}

			if (textAlternatives != null) {
				attr.TextAlternatives = textAlternatives;
			}

			if (spellingState != NSSpellingState.None) {
				attr.SpellingState = spellingState;
			}

			var dict = attr.Dictionary;
			return dict.Count == 0 ? null : dict;
		}

		public NSStringAttributes () : base (new NSMutableDictionary ())
		{
		}

		public NSStringAttributes (NSDictionary dictionary) : base (dictionary)
		{
		}

		IntPtr Get (NSString key)
		{
			return CFDictionary.GetValue (Dictionary.Handle, key.Handle);
		}

		T Get<T> (NSString key, Func<IntPtr, T> ctor)
		{
			var handle = Get (key);
			if (handle == IntPtr.Zero) {
				return default (T);
			}

			return ctor (handle);
		}

		bool? GetBool (NSString key)
		{
			var value = GetInt32Value (key);
			return value == null ? null : (bool?)(value.Value != 0);
		}
		
		void Set (NSString key, bool? value)
		{
			SetNumberValue (key, value == null ? null : (int?)(value.Value ? 1 : 0));
		}

		int SetUnderlineStyle (NSString attr, NSUnderlineStyle style,
			NSUnderlinePattern pattern, bool byWord)
		{
			var value = (int)style | (int)pattern;
			if (byWord) {
				value |= (int) NSAttributedString.UnderlineByWordMaskAttributeName;
			}

			SetNumberValue (attr, value);
			return value;
		}

		public NSUrl LinkUrl {
			get { return Link as NSUrl; }
			set { Link = value; }
		}

		public NSString LinkString {
			get { return Link as NSString; }
			set { Link = value; }
		}

		public NSFont Font {
			get { return Get (NSStringAttributeKey.Font, handle => new NSFont (handle)); }
			set { SetNativeValue (NSStringAttributeKey.Font, value); }
		}

		public NSParagraphStyle ParagraphStyle {
			get { return Get (NSStringAttributeKey.ParagraphStyle, handle => new NSParagraphStyle (handle)); }
			set { SetNativeValue (NSStringAttributeKey.ParagraphStyle, value); }
		}

		public NSColor ForegroundColor {
			get { return Get (NSStringAttributeKey.ForegroundColor, handle => new NSColor (handle)); }
			set { SetNativeValue (NSStringAttributeKey.ForegroundColor, value); }
		}

		public int? UnderlineStyle {
			get { return GetInt32Value (NSStringAttributeKey.UnderlineStyle); }
			set { SetNumberValue (NSStringAttributeKey.UnderlineStyle, value); }
		}

		public int SetUnderlineStyle (NSUnderlineStyle style = NSUnderlineStyle.None,
			NSUnderlinePattern pattern = NSUnderlinePattern.Solid, bool byWord = false)
		{
			return SetUnderlineStyle (NSStringAttributeKey.UnderlineStyle, style, pattern, byWord);
		}

		public bool? Superscript {
			get { return GetBool (NSStringAttributeKey.Superscript); }
			set { Set (NSStringAttributeKey.Superscript, value); }
		}

		public NSColor BackgroundColor {
			get { return Get (NSStringAttributeKey.BackgroundColor, handle => new NSColor (handle)); }
			set { SetNativeValue (NSStringAttributeKey.BackgroundColor, value); }
		}

		public NSTextAttachment Attachment {
			get { return Get (NSStringAttributeKey.Attachment, handle => new NSTextAttachment (handle)); }
			set { SetNativeValue (NSStringAttributeKey.Attachment, value); }
		}

		public NSLigatureType? Ligature {
			get { return (NSLigatureType?)GetInt32Value (NSStringAttributeKey.Ligature); }
			set { SetNumberValue (NSStringAttributeKey.Ligature, (int?)value); }
		}

		public float? BaselineOffset {
			get { return GetFloatValue (NSStringAttributeKey.BaselineOffset); }
			set { SetNumberValue (NSStringAttributeKey.BaselineOffset, value); }
		}

		public float? KerningAdjustment {
			get { return GetFloatValue (NSStringAttributeKey.KerningAdjustment); }
			set { SetNumberValue (NSStringAttributeKey.KerningAdjustment, value); }
		}

		NSObject Link {
			get {
				var handle = Get (NSStringAttributeKey.Link);
				return handle == IntPtr.Zero ? null : Runtime.GetNSObject (handle);
			}

			set { SetNativeValue (NSStringAttributeKey.Link, value); }
		}

		public float? StrokeWidth {
			get { return GetFloatValue (NSStringAttributeKey.StrokeWidth); }
			set { SetNumberValue (NSStringAttributeKey.StrokeWidth, value); }
		}

		public NSColor StrokeColor {
			get { return Get (NSStringAttributeKey.StrokeColor, handle => new NSColor (handle)); }
			set { SetNativeValue (NSStringAttributeKey.StrokeColor, value); }
		}

		public NSColor UnderlineColor {
			get { return Get (NSStringAttributeKey.UnderlineColor, handle => new NSColor (handle)); }
			set { SetNativeValue (NSStringAttributeKey.UnderlineColor, value); }
		}

		public int? StrikethroughStyle {
			get { return GetInt32Value (NSStringAttributeKey.StrikethroughStyle); }
			set { SetNumberValue (NSStringAttributeKey.StrikethroughStyle, value); }
		}

		public int SetStrikethroughStyle (NSUnderlineStyle style = NSUnderlineStyle.None,
			NSUnderlinePattern pattern = NSUnderlinePattern.Solid, bool byWord = false)
		{
			return SetUnderlineStyle (NSStringAttributeKey.StrikethroughStyle, style, pattern, byWord);
		}

		public NSColor StrikethroughColor {
			get { return Get (NSStringAttributeKey.StrikethroughColor, handle => new NSColor (handle)); }
			set { SetNativeValue (NSStringAttributeKey.StrikethroughColor, value); }
		}

		public NSShadow Shadow {
			get { return Get (NSStringAttributeKey.Shadow, handle => new NSShadow (handle)); }
			set { SetNativeValue (NSStringAttributeKey.Shadow, value); }
		}

		public float? Obliqueness {
			get { return GetFloatValue (NSStringAttributeKey.Obliqueness); }
			set { SetNumberValue (NSStringAttributeKey.Obliqueness, value); }
		}

		public float? Expansion {
			get { return GetFloatValue (NSStringAttributeKey.Expansion); }
			set { SetNumberValue (NSStringAttributeKey.Expansion, value); }
		}

		public NSCursor Cursor {
			get { return Get (NSStringAttributeKey.Cursor, handle => new NSCursor (handle)); }
			set { SetNativeValue (NSStringAttributeKey.Cursor, value); }
		}

		public string ToolTip {
			get { return Get (NSStringAttributeKey.ToolTip, handle => new NSString (handle)); }
			set { SetNativeValue (NSStringAttributeKey.ToolTip, new NSString (value)); }
		}

		public int? CharacterShape {
			get { return GetInt32Value (NSStringAttributeKey.CharacterShape); }
			set { SetNumberValue (NSStringAttributeKey.CharacterShape, value); }
		}

		public NSGlyphInfo GlyphInfo {
			get { return Get (NSStringAttributeKey.GlyphInfo, handle => new NSGlyphInfo (handle)); }
			set { SetNativeValue (NSStringAttributeKey.GlyphInfo, value); }
		}

		public NSArray WritingDirection {
			get { return Get (NSStringAttributeKey.WritingDirection, handle => new NSArray (handle)); }
			set { SetNativeValue (NSStringAttributeKey.GlyphInfo, value); }
		}

		public bool? MarkedClauseSegment {
			get { return GetBool (NSStringAttributeKey.MarkedClauseSegment); }
			set { Set (NSStringAttributeKey.MarkedClauseSegment, value); }
		}

		public NSTextLayoutOrientation? VerticalGlyphForm {
			get { return (NSTextLayoutOrientation?)GetInt32Value (NSStringAttributeKey.VerticalGlyphForm); }
			set { SetNumberValue (NSStringAttributeKey.VerticalGlyphForm, (int?)value); }
		}

		public NSTextAlternatives TextAlternatives {
			get { return Get (NSStringAttributeKey.TextAlternatives, handle => new NSTextAlternatives (handle)); }
			set { SetNativeValue (NSStringAttributeKey.TextAlternatives, value); }
		}

		public NSSpellingState? SpellingState {
			get { return (NSSpellingState?)GetInt32Value (NSStringAttributeKey.SpellingState); }
			set { SetNumberValue (NSStringAttributeKey.SpellingState, (int?)value); }
		}
	}
}
