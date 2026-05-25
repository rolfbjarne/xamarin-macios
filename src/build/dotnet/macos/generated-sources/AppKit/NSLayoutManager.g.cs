//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	/// <summary>Responsible for layout of text stored in a <see cref="T:AppKit.NSTextStorage" /> object.</summary><remarks><para>iOS 7 introduced "Text Kit," a broad set of APIs and modifications of existing classes, built on <see cref="N:CoreText" />, that greatly expands the typographical flexibility of iOS.</para><para>
	/// The <see cref="P:AppKit.NSLayoutManager.TextStorage" /> property holds a reference to a <see cref="T:AppKit.NSTextStorage" /> object,
	/// that holds a potentially large amount of styled text. The <see cref="P:AppKit.NSLayoutManager.TextContainers" /> property holds
	/// an ordered array of <see cref="T:AppKit.NSTextContainer" /> objects in which it lays out text. The <see cref="T:AppKit.NSTextContainer" />s, in turn, hold references to
	/// <see cref="T:AppKit.NSTextView" /> objects, which actually display the text.
	/// </para></remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/uikit/nslayoutmanager">Apple documentation for <c>NSLayoutManager</c></related>
	[Register("NSLayoutManager", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSLayoutManager : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGGlyphAtIndex_X = "CGGlyphAtIndex:";
		static readonly NativeHandle selCGGlyphAtIndex_XHandle = Selector.GetHandle ("CGGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGGlyphAtIndex_IsValidIndex_X = "CGGlyphAtIndex:isValidIndex:";
		static readonly NativeHandle selCGGlyphAtIndex_IsValidIndex_XHandle = Selector.GetHandle ("CGGlyphAtIndex:isValidIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTemporaryAttribute_Value_ForCharacterRange_X = "addTemporaryAttribute:value:forCharacterRange:";
		static readonly NativeHandle selAddTemporaryAttribute_Value_ForCharacterRange_XHandle = Selector.GetHandle ("addTemporaryAttribute:value:forCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTemporaryAttributes_ForCharacterRange_X = "addTemporaryAttributes:forCharacterRange:";
		static readonly NativeHandle selAddTemporaryAttributes_ForCharacterRange_XHandle = Selector.GetHandle ("addTemporaryAttributes:forCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTextContainer_X = "addTextContainer:";
		static readonly NativeHandle selAddTextContainer_XHandle = Selector.GetHandle ("addTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsNonContiguousLayoutX = "allowsNonContiguousLayout";
		static readonly NativeHandle selAllowsNonContiguousLayoutXHandle = Selector.GetHandle ("allowsNonContiguousLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttachmentSizeForGlyphAtIndex_X = "attachmentSizeForGlyphAtIndex:";
		static readonly NativeHandle selAttachmentSizeForGlyphAtIndex_XHandle = Selector.GetHandle ("attachmentSizeForGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundLayoutEnabledX = "backgroundLayoutEnabled";
		static readonly NativeHandle selBackgroundLayoutEnabledXHandle = Selector.GetHandle ("backgroundLayoutEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingRectForGlyphRange_InTextContainer_X = "boundingRectForGlyphRange:inTextContainer:";
		static readonly NativeHandle selBoundingRectForGlyphRange_InTextContainer_XHandle = Selector.GetHandle ("boundingRectForGlyphRange:inTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundsRectForTextBlock_AtIndex_EffectiveRange_X = "boundsRectForTextBlock:atIndex:effectiveRange:";
		static readonly NativeHandle selBoundsRectForTextBlock_AtIndex_EffectiveRange_XHandle = Selector.GetHandle ("boundsRectForTextBlock:atIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundsRectForTextBlock_GlyphRange_X = "boundsRectForTextBlock:glyphRange:";
		static readonly NativeHandle selBoundsRectForTextBlock_GlyphRange_XHandle = Selector.GetHandle ("boundsRectForTextBlock:glyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterIndexForGlyphAtIndex_X = "characterIndexForGlyphAtIndex:";
		static readonly NativeHandle selCharacterIndexForGlyphAtIndex_XHandle = Selector.GetHandle ("characterIndexForGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_X = "characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:";
		static readonly NativeHandle selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_XHandle = Selector.GetHandle ("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterRangeForGlyphRange_ActualGlyphRange_X = "characterRangeForGlyphRange:actualGlyphRange:";
		static readonly NativeHandle selCharacterRangeForGlyphRange_ActualGlyphRange_XHandle = Selector.GetHandle ("characterRangeForGlyphRange:actualGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultAttachmentScalingX = "defaultAttachmentScaling";
		static readonly NativeHandle selDefaultAttachmentScalingXHandle = Selector.GetHandle ("defaultAttachmentScaling");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultBaselineOffsetForFont_X = "defaultBaselineOffsetForFont:";
		static readonly NativeHandle selDefaultBaselineOffsetForFont_XHandle = Selector.GetHandle ("defaultBaselineOffsetForFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultLineHeightForFont_X = "defaultLineHeightForFont:";
		static readonly NativeHandle selDefaultLineHeightForFont_XHandle = Selector.GetHandle ("defaultLineHeightForFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawBackgroundForGlyphRange_AtPoint_X = "drawBackgroundForGlyphRange:atPoint:";
		static readonly NativeHandle selDrawBackgroundForGlyphRange_AtPoint_XHandle = Selector.GetHandle ("drawBackgroundForGlyphRange:atPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawGlyphsForGlyphRange_AtPoint_X = "drawGlyphsForGlyphRange:atPoint:";
		static readonly NativeHandle selDrawGlyphsForGlyphRange_AtPoint_XHandle = Selector.GetHandle ("drawGlyphsForGlyphRange:atPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawStrikethroughForGlyphRange_StrikethroughType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_X = "drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:";
		static readonly NativeHandle selDrawStrikethroughForGlyphRange_StrikethroughType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle = Selector.GetHandle ("drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawUnderlineForGlyphRange_UnderlineType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_X = "drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:";
		static readonly NativeHandle selDrawUnderlineForGlyphRange_UnderlineType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle = Selector.GetHandle ("drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawsOutsideLineFragmentForGlyphAtIndex_X = "drawsOutsideLineFragmentForGlyphAtIndex:";
		static readonly NativeHandle selDrawsOutsideLineFragmentForGlyphAtIndex_XHandle = Selector.GetHandle ("drawsOutsideLineFragmentForGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureGlyphsForCharacterRange_X = "ensureGlyphsForCharacterRange:";
		static readonly NativeHandle selEnsureGlyphsForCharacterRange_XHandle = Selector.GetHandle ("ensureGlyphsForCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureGlyphsForGlyphRange_X = "ensureGlyphsForGlyphRange:";
		static readonly NativeHandle selEnsureGlyphsForGlyphRange_XHandle = Selector.GetHandle ("ensureGlyphsForGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureLayoutForBoundingRect_InTextContainer_X = "ensureLayoutForBoundingRect:inTextContainer:";
		static readonly NativeHandle selEnsureLayoutForBoundingRect_InTextContainer_XHandle = Selector.GetHandle ("ensureLayoutForBoundingRect:inTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureLayoutForCharacterRange_X = "ensureLayoutForCharacterRange:";
		static readonly NativeHandle selEnsureLayoutForCharacterRange_XHandle = Selector.GetHandle ("ensureLayoutForCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureLayoutForGlyphRange_X = "ensureLayoutForGlyphRange:";
		static readonly NativeHandle selEnsureLayoutForGlyphRange_XHandle = Selector.GetHandle ("ensureLayoutForGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnsureLayoutForTextContainer_X = "ensureLayoutForTextContainer:";
		static readonly NativeHandle selEnsureLayoutForTextContainer_XHandle = Selector.GetHandle ("ensureLayoutForTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateEnclosingRectsForGlyphRange_WithinSelectedGlyphRange_InTextContainer_UsingBlock_X = "enumerateEnclosingRectsForGlyphRange:withinSelectedGlyphRange:inTextContainer:usingBlock:";
		static readonly NativeHandle selEnumerateEnclosingRectsForGlyphRange_WithinSelectedGlyphRange_InTextContainer_UsingBlock_XHandle = Selector.GetHandle ("enumerateEnclosingRectsForGlyphRange:withinSelectedGlyphRange:inTextContainer:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateLineFragmentsForGlyphRange_UsingBlock_X = "enumerateLineFragmentsForGlyphRange:usingBlock:";
		static readonly NativeHandle selEnumerateLineFragmentsForGlyphRange_UsingBlock_XHandle = Selector.GetHandle ("enumerateLineFragmentsForGlyphRange:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtraLineFragmentRectX = "extraLineFragmentRect";
		static readonly NativeHandle selExtraLineFragmentRectXHandle = Selector.GetHandle ("extraLineFragmentRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtraLineFragmentTextContainerX = "extraLineFragmentTextContainer";
		static readonly NativeHandle selExtraLineFragmentTextContainerXHandle = Selector.GetHandle ("extraLineFragmentTextContainer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExtraLineFragmentUsedRectX = "extraLineFragmentUsedRect";
		static readonly NativeHandle selExtraLineFragmentUsedRectXHandle = Selector.GetHandle ("extraLineFragmentUsedRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFillBackgroundRectArray_Count_ForCharacterRange_Color_X = "fillBackgroundRectArray:count:forCharacterRange:color:";
		static readonly NativeHandle selFillBackgroundRectArray_Count_ForCharacterRange_Color_XHandle = Selector.GetHandle ("fillBackgroundRectArray:count:forCharacterRange:color:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstUnlaidCharacterIndexX = "firstUnlaidCharacterIndex";
		static readonly NativeHandle selFirstUnlaidCharacterIndexXHandle = Selector.GetHandle ("firstUnlaidCharacterIndex");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstUnlaidGlyphIndexX = "firstUnlaidGlyphIndex";
		static readonly NativeHandle selFirstUnlaidGlyphIndexXHandle = Selector.GetHandle ("firstUnlaidGlyphIndex");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFractionOfDistanceThroughGlyphForPoint_InTextContainer_X = "fractionOfDistanceThroughGlyphForPoint:inTextContainer:";
		static readonly NativeHandle selFractionOfDistanceThroughGlyphForPoint_InTextContainer_XHandle = Selector.GetHandle ("fractionOfDistanceThroughGlyphForPoint:inTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetFirstUnlaidCharacterIndex_GlyphIndex_X = "getFirstUnlaidCharacterIndex:glyphIndex:";
		static readonly NativeHandle selGetFirstUnlaidCharacterIndex_GlyphIndex_XHandle = Selector.GetHandle ("getFirstUnlaidCharacterIndex:glyphIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetGlyphsInRange_Glyphs_Properties_CharacterIndexes_BidiLevels_X = "getGlyphsInRange:glyphs:properties:characterIndexes:bidiLevels:";
		static readonly NativeHandle selGetGlyphsInRange_Glyphs_Properties_CharacterIndexes_BidiLevels_XHandle = Selector.GetHandle ("getGlyphsInRange:glyphs:properties:characterIndexes:bidiLevels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetLineFragmentInsertionPointsForCharacterAtIndex_AlternatePositions_InDisplayOrder_Positions_CharacterIndexes_X = "getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:";
		static readonly NativeHandle selGetLineFragmentInsertionPointsForCharacterAtIndex_AlternatePositions_InDisplayOrder_Positions_CharacterIndexes_XHandle = Selector.GetHandle ("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphAtIndex_X = "glyphAtIndex:";
		static readonly NativeHandle selGlyphAtIndex_XHandle = Selector.GetHandle ("glyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphAtIndex_IsValidIndex_X = "glyphAtIndex:isValidIndex:";
		static readonly NativeHandle selGlyphAtIndex_IsValidIndex_XHandle = Selector.GetHandle ("glyphAtIndex:isValidIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphGeneratorX = "glyphGenerator";
		static readonly NativeHandle selGlyphGeneratorXHandle = Selector.GetHandle ("glyphGenerator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphIndexForCharacterAtIndex_X = "glyphIndexForCharacterAtIndex:";
		static readonly NativeHandle selGlyphIndexForCharacterAtIndex_XHandle = Selector.GetHandle ("glyphIndexForCharacterAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphIndexForPoint_InTextContainer_X = "glyphIndexForPoint:inTextContainer:";
		static readonly NativeHandle selGlyphIndexForPoint_InTextContainer_XHandle = Selector.GetHandle ("glyphIndexForPoint:inTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphIndexForPoint_InTextContainer_FractionOfDistanceThroughGlyph_X = "glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:";
		static readonly NativeHandle selGlyphIndexForPoint_InTextContainer_FractionOfDistanceThroughGlyph_XHandle = Selector.GetHandle ("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphRangeForBoundingRect_InTextContainer_X = "glyphRangeForBoundingRect:inTextContainer:";
		static readonly NativeHandle selGlyphRangeForBoundingRect_InTextContainer_XHandle = Selector.GetHandle ("glyphRangeForBoundingRect:inTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphRangeForBoundingRectWithoutAdditionalLayout_InTextContainer_X = "glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:";
		static readonly NativeHandle selGlyphRangeForBoundingRectWithoutAdditionalLayout_InTextContainer_XHandle = Selector.GetHandle ("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphRangeForCharacterRange_ActualCharacterRange_X = "glyphRangeForCharacterRange:actualCharacterRange:";
		static readonly NativeHandle selGlyphRangeForCharacterRange_ActualCharacterRange_XHandle = Selector.GetHandle ("glyphRangeForCharacterRange:actualCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphRangeForTextContainer_X = "glyphRangeForTextContainer:";
		static readonly NativeHandle selGlyphRangeForTextContainer_XHandle = Selector.GetHandle ("glyphRangeForTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasNonContiguousLayoutX = "hasNonContiguousLayout";
		static readonly NativeHandle selHasNonContiguousLayoutXHandle = Selector.GetHandle ("hasNonContiguousLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHyphenationFactorX = "hyphenationFactor";
		static readonly NativeHandle selHyphenationFactorXHandle = Selector.GetHandle ("hyphenationFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertTextContainer_AtIndex_X = "insertTextContainer:atIndex:";
		static readonly NativeHandle selInsertTextContainer_AtIndex_XHandle = Selector.GetHandle ("insertTextContainer:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateDisplayForCharacterRange_X = "invalidateDisplayForCharacterRange:";
		static readonly NativeHandle selInvalidateDisplayForCharacterRange_XHandle = Selector.GetHandle ("invalidateDisplayForCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateDisplayForGlyphRange_X = "invalidateDisplayForGlyphRange:";
		static readonly NativeHandle selInvalidateDisplayForGlyphRange_XHandle = Selector.GetHandle ("invalidateDisplayForGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_X = "invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:";
		static readonly NativeHandle selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_XHandle = Selector.GetHandle ("invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateLayoutForCharacterRange_ActualCharacterRange_X = "invalidateLayoutForCharacterRange:actualCharacterRange:";
		static readonly NativeHandle selInvalidateLayoutForCharacterRange_ActualCharacterRange_XHandle = Selector.GetHandle ("invalidateLayoutForCharacterRange:actualCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsValidGlyphIndex_X = "isValidGlyphIndex:";
		static readonly NativeHandle selIsValidGlyphIndex_XHandle = Selector.GetHandle ("isValidGlyphIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutRectForTextBlock_AtIndex_EffectiveRange_X = "layoutRectForTextBlock:atIndex:effectiveRange:";
		static readonly NativeHandle selLayoutRectForTextBlock_AtIndex_EffectiveRange_XHandle = Selector.GetHandle ("layoutRectForTextBlock:atIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutRectForTextBlock_GlyphRange_X = "layoutRectForTextBlock:glyphRange:";
		static readonly NativeHandle selLayoutRectForTextBlock_GlyphRange_XHandle = Selector.GetHandle ("layoutRectForTextBlock:glyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLimitsLayoutForSuspiciousContentsX = "limitsLayoutForSuspiciousContents";
		static readonly NativeHandle selLimitsLayoutForSuspiciousContentsXHandle = Selector.GetHandle ("limitsLayoutForSuspiciousContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineFragmentRectForGlyphAtIndex_EffectiveRange_X = "lineFragmentRectForGlyphAtIndex:effectiveRange:";
		static readonly NativeHandle selLineFragmentRectForGlyphAtIndex_EffectiveRange_XHandle = Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_X = "lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:";
		static readonly NativeHandle selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle = Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_X = "lineFragmentUsedRectForGlyphAtIndex:effectiveRange:";
		static readonly NativeHandle selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_XHandle = Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_X = "lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:";
		static readonly NativeHandle selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle = Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationForGlyphAtIndex_X = "locationForGlyphAtIndex:";
		static readonly NativeHandle selLocationForGlyphAtIndex_XHandle = Selector.GetHandle ("locationForGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotShownAttributeForGlyphAtIndex_X = "notShownAttributeForGlyphAtIndex:";
		static readonly NativeHandle selNotShownAttributeForGlyphAtIndex_XHandle = Selector.GetHandle ("notShownAttributeForGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfGlyphsX = "numberOfGlyphs";
		static readonly NativeHandle selNumberOfGlyphsXHandle = Selector.GetHandle ("numberOfGlyphs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProcessEditingForTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_X = "processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:";
		static readonly NativeHandle selProcessEditingForTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_XHandle = Selector.GetHandle ("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertyForGlyphAtIndex_X = "propertyForGlyphAtIndex:";
		static readonly NativeHandle selPropertyForGlyphAtIndex_XHandle = Selector.GetHandle ("propertyForGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeOfNominallySpacedGlyphsContainingIndex_X = "rangeOfNominallySpacedGlyphsContainingIndex:";
		static readonly NativeHandle selRangeOfNominallySpacedGlyphsContainingIndex_XHandle = Selector.GetHandle ("rangeOfNominallySpacedGlyphsContainingIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRectArrayForGlyphRange_WithinSelectedGlyphRange_InTextContainer_RectCount_X = "rectArrayForGlyphRange:withinSelectedGlyphRange:inTextContainer:rectCount:";
		static readonly NativeHandle selRectArrayForGlyphRange_WithinSelectedGlyphRange_InTextContainer_RectCount_XHandle = Selector.GetHandle ("rectArrayForGlyphRange:withinSelectedGlyphRange:inTextContainer:rectCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTemporaryAttribute_ForCharacterRange_X = "removeTemporaryAttribute:forCharacterRange:";
		static readonly NativeHandle selRemoveTemporaryAttribute_ForCharacterRange_XHandle = Selector.GetHandle ("removeTemporaryAttribute:forCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveTextContainerAtIndex_X = "removeTextContainerAtIndex:";
		static readonly NativeHandle selRemoveTextContainerAtIndex_XHandle = Selector.GetHandle ("removeTextContainerAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsNonContiguousLayout_X = "setAllowsNonContiguousLayout:";
		static readonly NativeHandle selSetAllowsNonContiguousLayout_XHandle = Selector.GetHandle ("setAllowsNonContiguousLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttachmentSize_ForGlyphRange_X = "setAttachmentSize:forGlyphRange:";
		static readonly NativeHandle selSetAttachmentSize_ForGlyphRange_XHandle = Selector.GetHandle ("setAttachmentSize:forGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundLayoutEnabled_X = "setBackgroundLayoutEnabled:";
		static readonly NativeHandle selSetBackgroundLayoutEnabled_XHandle = Selector.GetHandle ("setBackgroundLayoutEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBoundsRect_ForTextBlock_GlyphRange_X = "setBoundsRect:forTextBlock:glyphRange:";
		static readonly NativeHandle selSetBoundsRect_ForTextBlock_GlyphRange_XHandle = Selector.GetHandle ("setBoundsRect:forTextBlock:glyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultAttachmentScaling_X = "setDefaultAttachmentScaling:";
		static readonly NativeHandle selSetDefaultAttachmentScaling_XHandle = Selector.GetHandle ("setDefaultAttachmentScaling:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDrawsOutsideLineFragment_ForGlyphAtIndex_X = "setDrawsOutsideLineFragment:forGlyphAtIndex:";
		static readonly NativeHandle selSetDrawsOutsideLineFragment_ForGlyphAtIndex_XHandle = Selector.GetHandle ("setDrawsOutsideLineFragment:forGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExtraLineFragmentRect_UsedRect_TextContainer_X = "setExtraLineFragmentRect:usedRect:textContainer:";
		static readonly NativeHandle selSetExtraLineFragmentRect_UsedRect_TextContainer_XHandle = Selector.GetHandle ("setExtraLineFragmentRect:usedRect:textContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGlyphGenerator_X = "setGlyphGenerator:";
		static readonly NativeHandle selSetGlyphGenerator_XHandle = Selector.GetHandle ("setGlyphGenerator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGlyphs_Properties_CharacterIndexes_Font_ForGlyphRange_X = "setGlyphs:properties:characterIndexes:font:forGlyphRange:";
		static readonly NativeHandle selSetGlyphs_Properties_CharacterIndexes_Font_ForGlyphRange_XHandle = Selector.GetHandle ("setGlyphs:properties:characterIndexes:font:forGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHyphenationFactor_X = "setHyphenationFactor:";
		static readonly NativeHandle selSetHyphenationFactor_XHandle = Selector.GetHandle ("setHyphenationFactor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLayoutRect_ForTextBlock_GlyphRange_X = "setLayoutRect:forTextBlock:glyphRange:";
		static readonly NativeHandle selSetLayoutRect_ForTextBlock_GlyphRange_XHandle = Selector.GetHandle ("setLayoutRect:forTextBlock:glyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLimitsLayoutForSuspiciousContents_X = "setLimitsLayoutForSuspiciousContents:";
		static readonly NativeHandle selSetLimitsLayoutForSuspiciousContents_XHandle = Selector.GetHandle ("setLimitsLayoutForSuspiciousContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineFragmentRect_ForGlyphRange_UsedRect_X = "setLineFragmentRect:forGlyphRange:usedRect:";
		static readonly NativeHandle selSetLineFragmentRect_ForGlyphRange_UsedRect_XHandle = Selector.GetHandle ("setLineFragmentRect:forGlyphRange:usedRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocation_ForStartOfGlyphRange_X = "setLocation:forStartOfGlyphRange:";
		static readonly NativeHandle selSetLocation_ForStartOfGlyphRange_XHandle = Selector.GetHandle ("setLocation:forStartOfGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNotShownAttribute_ForGlyphAtIndex_X = "setNotShownAttribute:forGlyphAtIndex:";
		static readonly NativeHandle selSetNotShownAttribute_ForGlyphAtIndex_XHandle = Selector.GetHandle ("setNotShownAttribute:forGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsControlCharacters_X = "setShowsControlCharacters:";
		static readonly NativeHandle selSetShowsControlCharacters_XHandle = Selector.GetHandle ("setShowsControlCharacters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsInvisibleCharacters_X = "setShowsInvisibleCharacters:";
		static readonly NativeHandle selSetShowsInvisibleCharacters_XHandle = Selector.GetHandle ("setShowsInvisibleCharacters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTemporaryAttributes_ForCharacterRange_X = "setTemporaryAttributes:forCharacterRange:";
		static readonly NativeHandle selSetTemporaryAttributes_ForCharacterRange_XHandle = Selector.GetHandle ("setTemporaryAttributes:forCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextContainer_ForGlyphRange_X = "setTextContainer:forGlyphRange:";
		static readonly NativeHandle selSetTextContainer_ForGlyphRange_XHandle = Selector.GetHandle ("setTextContainer:forGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextStorage_X = "setTextStorage:";
		static readonly NativeHandle selSetTextStorage_XHandle = Selector.GetHandle ("setTextStorage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTypesetter_X = "setTypesetter:";
		static readonly NativeHandle selSetTypesetter_XHandle = Selector.GetHandle ("setTypesetter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTypesetterBehavior_X = "setTypesetterBehavior:";
		static readonly NativeHandle selSetTypesetterBehavior_XHandle = Selector.GetHandle ("setTypesetterBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesDefaultHyphenation_X = "setUsesDefaultHyphenation:";
		static readonly NativeHandle selSetUsesDefaultHyphenation_XHandle = Selector.GetHandle ("setUsesDefaultHyphenation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesFontLeading_X = "setUsesFontLeading:";
		static readonly NativeHandle selSetUsesFontLeading_XHandle = Selector.GetHandle ("setUsesFontLeading:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesScreenFonts_X = "setUsesScreenFonts:";
		static readonly NativeHandle selSetUsesScreenFonts_XHandle = Selector.GetHandle ("setUsesScreenFonts:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowAttachmentCell_InRect_CharacterIndex_X = "showAttachmentCell:inRect:characterIndex:";
		static readonly NativeHandle selShowAttachmentCell_InRect_CharacterIndex_XHandle = Selector.GetHandle ("showAttachmentCell:inRect:characterIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowCGGlyphs_Positions_Count_Font_Matrix_Attributes_InContext_X = "showCGGlyphs:positions:count:font:matrix:attributes:inContext:";
		static readonly NativeHandle selShowCGGlyphs_Positions_Count_Font_Matrix_Attributes_InContext_XHandle = Selector.GetHandle ("showCGGlyphs:positions:count:font:matrix:attributes:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowCGGlyphs_Positions_Count_Font_TextMatrix_Attributes_InContext_X = "showCGGlyphs:positions:count:font:textMatrix:attributes:inContext:";
		static readonly NativeHandle selShowCGGlyphs_Positions_Count_Font_TextMatrix_Attributes_InContext_XHandle = Selector.GetHandle ("showCGGlyphs:positions:count:font:textMatrix:attributes:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsControlCharactersX = "showsControlCharacters";
		static readonly NativeHandle selShowsControlCharactersXHandle = Selector.GetHandle ("showsControlCharacters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsInvisibleCharactersX = "showsInvisibleCharacters";
		static readonly NativeHandle selShowsInvisibleCharactersXHandle = Selector.GetHandle ("showsInvisibleCharacters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrikethroughGlyphRange_StrikethroughType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_X = "strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:";
		static readonly NativeHandle selStrikethroughGlyphRange_StrikethroughType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle = Selector.GetHandle ("strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryAttribute_AtCharacterIndex_EffectiveRange_X = "temporaryAttribute:atCharacterIndex:effectiveRange:";
		static readonly NativeHandle selTemporaryAttribute_AtCharacterIndex_EffectiveRange_XHandle = Selector.GetHandle ("temporaryAttribute:atCharacterIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_X = "temporaryAttribute:atCharacterIndex:longestEffectiveRange:inRange:";
		static readonly NativeHandle selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_XHandle = Selector.GetHandle ("temporaryAttribute:atCharacterIndex:longestEffectiveRange:inRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryAttributesAtCharacterIndex_EffectiveRange_X = "temporaryAttributesAtCharacterIndex:effectiveRange:";
		static readonly NativeHandle selTemporaryAttributesAtCharacterIndex_EffectiveRange_XHandle = Selector.GetHandle ("temporaryAttributesAtCharacterIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_X = "temporaryAttributesAtCharacterIndex:longestEffectiveRange:inRange:";
		static readonly NativeHandle selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_XHandle = Selector.GetHandle ("temporaryAttributesAtCharacterIndex:longestEffectiveRange:inRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainerChangedGeometry_X = "textContainerChangedGeometry:";
		static readonly NativeHandle selTextContainerChangedGeometry_XHandle = Selector.GetHandle ("textContainerChangedGeometry:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainerChangedTextView_X = "textContainerChangedTextView:";
		static readonly NativeHandle selTextContainerChangedTextView_XHandle = Selector.GetHandle ("textContainerChangedTextView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainerForGlyphAtIndex_EffectiveRange_X = "textContainerForGlyphAtIndex:effectiveRange:";
		static readonly NativeHandle selTextContainerForGlyphAtIndex_EffectiveRange_XHandle = Selector.GetHandle ("textContainerForGlyphAtIndex:effectiveRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_X = "textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:";
		static readonly NativeHandle selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle = Selector.GetHandle ("textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainersX = "textContainers";
		static readonly NativeHandle selTextContainersXHandle = Selector.GetHandle ("textContainers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextStorageX = "textStorage";
		static readonly NativeHandle selTextStorageXHandle = Selector.GetHandle ("textStorage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTruncatedGlyphRangeInLineFragmentForGlyphAtIndex_X = "truncatedGlyphRangeInLineFragmentForGlyphAtIndex:";
		static readonly NativeHandle selTruncatedGlyphRangeInLineFragmentForGlyphAtIndex_XHandle = Selector.GetHandle ("truncatedGlyphRangeInLineFragmentForGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypesetterX = "typesetter";
		static readonly NativeHandle selTypesetterXHandle = Selector.GetHandle ("typesetter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypesetterBehaviorX = "typesetterBehavior";
		static readonly NativeHandle selTypesetterBehaviorXHandle = Selector.GetHandle ("typesetterBehavior");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnderlineGlyphRange_UnderlineType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_X = "underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:";
		static readonly NativeHandle selUnderlineGlyphRange_UnderlineType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle = Selector.GetHandle ("underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsedRectForTextContainer_X = "usedRectForTextContainer:";
		static readonly NativeHandle selUsedRectForTextContainer_XHandle = Selector.GetHandle ("usedRectForTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesDefaultHyphenationX = "usesDefaultHyphenation";
		static readonly NativeHandle selUsesDefaultHyphenationXHandle = Selector.GetHandle ("usesDefaultHyphenation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesFontLeadingX = "usesFontLeading";
		static readonly NativeHandle selUsesFontLeadingXHandle = Selector.GetHandle ("usesFontLeading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesScreenFontsX = "usesScreenFonts";
		static readonly NativeHandle selUsesScreenFontsXHandle = Selector.GetHandle ("usesScreenFonts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSLayoutManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSLayoutManager" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSLayoutManager () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public NSLayoutManager (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NSLayoutManager (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NSLayoutManager (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addTemporaryAttribute:value:forCharacterRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTemporaryAttribute (NSString attributeName, NSObject value, NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributeName__handle__ = attributeName!.GetNonNullHandle (nameof (attributeName));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NSRange (this.Handle, selAddTemporaryAttribute_Value_ForCharacterRange_XHandle, attributeName__handle__, value__handle__, characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NSRange (&__objc_super__, selAddTemporaryAttribute_Value_ForCharacterRange_XHandle, attributeName__handle__, value__handle__, characterRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributeName);
			GC.KeepAlive (value);
		}
		/// <param name="attributeName">To be added.</param><param name="value">To be added.</param><param name="characterRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddTemporaryAttribute (string attributeName, NSObject value, NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (attributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attributeName));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nsattributeName = CFString.CreateNative (attributeName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NSRange (this.Handle, selAddTemporaryAttribute_Value_ForCharacterRange_XHandle, nsattributeName, value__handle__, characterRange);
			GC.KeepAlive (value);
			CFString.ReleaseNative (nsattributeName);
		}
		[Export ("addTemporaryAttributes:forCharacterRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTemporaryAttributes (NSDictionary<NSString, NSObject> attributes, NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selAddTemporaryAttributes_ForCharacterRange_XHandle, attributes__handle__, characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selAddTemporaryAttributes_ForCharacterRange_XHandle, attributes__handle__, characterRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
		}
		/// <summary>Appends a <see cref="T:AppKit.NSTextContainer" /> to the <see cref="P:AppKit.NSLayoutManager.TextContainers" /> property.</summary><param name="container">An <see cref="T:AppKit.NSTextContainer" /> to be appended to the <see cref="P:AppKit.NSLayoutManager.TextContainers" /> property.</param><altmember cref="M:AppKit.NSLayoutManager.InsertTextContainer(AppKit.NSTextContainer,System.IntPtr)" />
		[Export ("addTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTextContainer (NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddTextContainer_XHandle, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddTextContainer_XHandle, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Draws background marks for the given glyph range.</summary><param name="glyphsToShow">To be added.</param><param name="origin">To be added.</param><remarks><para>Background marks include text background color, highlighting, and table backgrounds and borders. Application developers can override this function in subclasses to fully customize background drawing.</para><para><paramref name="glyphsToShow" /> must specify glyphs within a single <see cref="T:AppKit.NSTextContainer" />.</para></remarks>
		[Export ("drawBackgroundForGlyphRange:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawBackground (NSRange glyphsToShow, CGPoint origin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_CGPoint (this.Handle, selDrawBackgroundForGlyphRange_AtPoint_XHandle, glyphsToShow, origin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_CGPoint (&__objc_super__, selDrawBackgroundForGlyphRange_AtPoint_XHandle, glyphsToShow, origin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Draws the specified glyph range.</summary><param name="glyphsToShow">To be added.</param><param name="origin">To be added.</param><remarks><para>This method causes glyph generation and layout, if needed.</para><para><paramref name="glyphsToShow" /> must specify glyphs within a single <see cref="T:AppKit.NSTextContainer" />.</para></remarks>
		[Export ("drawGlyphsForGlyphRange:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawGlyphs (NSRange glyphsToShow, CGPoint origin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_CGPoint (this.Handle, selDrawGlyphsForGlyphRange_AtPoint_XHandle, glyphsToShow, origin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_CGPoint (&__objc_super__, selDrawGlyphsForGlyphRange_AtPoint_XHandle, glyphsToShow, origin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="glyphRange">The range of glyphs to be struck through.</param><param name="strikethroughVal">The drawing style of the strikethrough (for instance, dashed or solid).</param><param name="baselineOffset">Distance above the baseline to draw the strikethrough.</param><param name="lineRect">The line fragment rectangle containing <paramref name="glyphRange" />.</param><param name="lineGlyphRange">All glyphs within <paramref name="lineRect" />.</param><param name="containerOrigin">The origin of the <paramref name="lineRect" /> objects containing <see cref="T:AppKit.NSTextContainer" />.</param><summary>Draws a strikethrough line through the glyphs in <paramref name="glyphRange" />.</summary><remarks><para>Developers should generally use the simpler <see cref="M:AppKit.NSLayoutManager.Strikethrough(Foundation.NSRange,Foundation.NSUnderlineStyle,CoreGraphics.CGRect,Foundation.NSRange,CoreGraphics.CGPoint)" /> method.</para></remarks>
		[Export ("drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawStrikethrough (NSRange glyphRange, NSUnderlineStyle strikethroughVal, nfloat baselineOffset, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_nfloat_CGRect_NSRange_CGPoint (this.Handle, selDrawStrikethroughForGlyphRange_StrikethroughType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle, glyphRange, (IntPtr) (long) strikethroughVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_nfloat_CGRect_NSRange_CGPoint (&__objc_super__, selDrawStrikethroughForGlyphRange_StrikethroughType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle, glyphRange, (IntPtr) (long) strikethroughVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Underlines the glyphs in <paramref name="glyphRange" />.</summary><param name="glyphRange">The range of glyphs to be underlined.</param><param name="underlineVal">The drawing style of the underline.</param><param name="baselineOffset">The distance from the baseline to draw the underline.</param><param name="lineRect">The line fragment rectangle containing <paramref name="glyphRange" />.</param><param name="lineGlyphRange">All glyphs within <paramref name="lineRect" />.</param><param name="containerOrigin">The origin of the <paramref name="lineRect" /> objects containing <see cref="T:AppKit.NSTextContainer" />.</param><remarks><para>Developers should generally use the simpler <see cref="M:AppKit.NSLayoutManager.Underline(Foundation.NSRange,Foundation.NSUnderlineStyle,CoreGraphics.CGRect,Foundation.NSRange,CoreGraphics.CGPoint)" /> method.</para></remarks>
		[Export ("drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawUnderline (NSRange glyphRange, NSUnderlineStyle underlineVal, nfloat baselineOffset, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_nfloat_CGRect_NSRange_CGPoint (this.Handle, selDrawUnderlineForGlyphRange_UnderlineType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle, glyphRange, (IntPtr) (long) underlineVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_nfloat_CGRect_NSRange_CGPoint (&__objc_super__, selDrawUnderlineForGlyphRange_UnderlineType_BaselineOffset_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle, glyphRange, (IntPtr) (long) underlineVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="glyphIndex">To be added.</param><summary>Returns <see langword="true" /> if the specified glyph draws outside of its line fragment rectangle.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("drawsOutsideLineFragmentForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawsOutsideLineFragmentForGlyph (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, selDrawsOutsideLineFragmentForGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, selDrawsOutsideLineFragmentForGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <summary>Forces the <see cref="T:AppKit.NSLayoutManager" /> to generate glyphs for the specified characters, if it has not already done so.</summary><param name="characterRange">To be added.</param><remarks><para>The <see cref="T:AppKit.NSLayoutManager" /> may calculate glyphs for a range larger than the <paramref name="characterRange" />. If <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureGlyphsForCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureGlyphsForCharacterRange (NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selEnsureGlyphsForCharacterRange_XHandle, characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selEnsureGlyphsForCharacterRange_XHandle, characterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Forces the <see cref="T:AppKit.NSLayoutManager" /> to generate glyphs for the specified glyph range, if it has not already done so.</summary><param name="glyphRange">To be added.</param><remarks><para>The <see cref="T:AppKit.NSLayoutManager" /> may calculate glyphs for a range larger than the <paramref name="glyphRange" />. If <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureGlyphsForGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureGlyphsForGlyphRange (NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selEnsureGlyphsForGlyphRange_XHandle, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selEnsureGlyphsForGlyphRange_XHandle, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Forces the layout manager to perform layout on <paramref name="bounds" /> within <paramref name="container" />.</summary><param name="bounds">To be added.</param><param name="container">To be added.</param><remarks><para>The layout manager may lay out areas larger than <paramref name="bounds" />.</para></remarks>
		[Export ("ensureLayoutForBoundingRect:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayoutForBoundingRect (CGRect bounds, NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, selEnsureLayoutForBoundingRect_InTextContainer_XHandle, bounds, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selEnsureLayoutForBoundingRect_InTextContainer_XHandle, bounds, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Forces the <see cref="T:AppKit.NSLayoutManager" /> to layout the specified characters, if it has not already done so.</summary><param name="characterRange">To be added.</param><remarks><para>The <see cref="T:AppKit.NSLayoutManager" /> may layout an area larger than the <paramref name="characterRange" />. If <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureLayoutForCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayoutForCharacterRange (NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selEnsureLayoutForCharacterRange_XHandle, characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selEnsureLayoutForCharacterRange_XHandle, characterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Forces the <see cref="T:AppKit.NSLayoutManager" /> to layout the specified glyphs, if it has not already done so.</summary><param name="glyphRange">To be added.</param><remarks><para>The <see cref="T:AppKit.NSLayoutManager" /> may layout a larger range than the specified <paramref name="glyphRange" />. If <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureLayoutForGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayoutForGlyphRange (NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selEnsureLayoutForGlyphRange_XHandle, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selEnsureLayoutForGlyphRange_XHandle, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Forces the <see cref="T:AppKit.NSLayoutManager" /> to layout the specified <see cref="T:AppKit.NSTextContainer" />, if it has not already done so.</summary><param name="container">To be added.</param><remarks><para>The <see cref="T:AppKit.NSLayoutManager" /> may layout more than the specified <paramref name="container" />. If <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureLayoutForTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayoutForTextContainer (NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEnsureLayoutForTextContainer_XHandle, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEnsureLayoutForTextContainer_XHandle, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Enumerates the enclosing rectangles for the specified glyph range.</summary><param name="glyphRange">To be added.</param><param name="selectedRange">To be added.</param><param name="textContainer">To be added.</param><param name="callback">To be added.</param><remarks>To be added.</remarks>
		[Export ("enumerateEnclosingRectsForGlyphRange:withinSelectedGlyphRange:inTextContainer:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateEnclosingRects (NSRange glyphRange, NSRange selectedRange, NSTextContainer textContainer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextLayoutEnumerateEnclosingRects))]NSTextLayoutEnumerateEnclosingRects callback)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSTextLayoutEnumerateEnclosingRects.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NSRange_NativeHandle_NativeHandle (this.Handle, selEnumerateEnclosingRectsForGlyphRange_WithinSelectedGlyphRange_InTextContainer_UsingBlock_XHandle, glyphRange, selectedRange, textContainer__handle__, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_NSRange_NativeHandle_NativeHandle (&__objc_super__, selEnumerateEnclosingRectsForGlyphRange_WithinSelectedGlyphRange_InTextContainer_UsingBlock_XHandle, glyphRange, selectedRange, textContainer__handle__, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textContainer);
		}
		/// <summary>Enumerate the line fragments intersecting with the specified glyph range.|Enumerate the line fragments intersecting with the specified glyph rane.</summary><param name="glyphRange">To be added.</param><param name="callback">To be added.</param><remarks>To be added.</remarks>
		[Export ("enumerateLineFragmentsForGlyphRange:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateLineFragments (NSRange glyphRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextLayoutEnumerateLineFragments))]NSTextLayoutEnumerateLineFragments callback)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSTextLayoutEnumerateLineFragments.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle (this.Handle, selEnumerateLineFragmentsForGlyphRange_UsingBlock_XHandle, glyphRange, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, selEnumerateLineFragmentsForGlyphRange_UsingBlock_XHandle, glyphRange, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("fillBackgroundRectArray:count:forCharacterRange:color:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"This method should never be called, only overridden.")]
		protected virtual void FillBackground (nint rectArray, nuint rectCount, NSRange characterRange, NSColor color)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_NSRange_NativeHandle (this.Handle, selFillBackgroundRectArray_Count_ForCharacterRange_Color_XHandle, rectArray, rectCount, characterRange, color__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_NSRange_NativeHandle (&__objc_super__, selFillBackgroundRectArray_Count_ForCharacterRange_Color_XHandle, rectArray, rectCount, characterRange, color__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
		}
		/// <param name="glyphIndex">To be added.</param><summary>The size of the attachment cell associated with the glyph at the specified index</summary><returns>The size of attachment cell at the glyph at <paramref name="glyphIndex" />. Returns {-1.0f, -1.0f} if there is no attachment at the specified glyph.</returns><remarks>To be added.</remarks>
		[Export ("attachmentSizeForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetAttachmentSizeForGlyph (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_UIntPtr (this.Handle, selAttachmentSizeForGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_UIntPtr (&__objc_super__, selAttachmentSizeForGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphRange">To be added.</param><param name="container">To be added.</param><summary>The bounding rectangle, in container coordinates, for the glyphs in the specified range.</summary><returns>To be added.</returns><remarks><para>The returned <see cref="T:CoreGraphics.CGRect" /> includes the area needed for all marks associated with the glyphs, including the area needed for glyphs that draw outside of their line fragment rectangle and for marks such as underlining.</para></remarks>
		[Export ("boundingRectForGlyphRange:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundingRect (NSRange glyphRange, NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange_NativeHandle (this.Handle, selBoundingRectForGlyphRange_InTextContainer_XHandle, glyphRange, container__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange_NativeHandle (this.Handle, selBoundingRectForGlyphRange_InTextContainer_XHandle, glyphRange, container__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, selBoundingRectForGlyphRange_InTextContainer_XHandle, glyphRange, container__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NSRange_NativeHandle (&__objc_super__, selBoundingRectForGlyphRange_InTextContainer_XHandle, glyphRange, container__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		[Export ("boundsRectForTextBlock:glyphRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundsRect (NSTextBlock block, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NSRange (this.Handle, selBoundsRectForTextBlock_GlyphRange_XHandle, block__handle__, glyphRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NSRange (this.Handle, selBoundsRectForTextBlock_GlyphRange_XHandle, block__handle__, glyphRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selBoundsRectForTextBlock_GlyphRange_XHandle, block__handle__, glyphRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_NSRange (&__objc_super__, selBoundsRectForTextBlock_GlyphRange_XHandle, block__handle__, glyphRange);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (block);
			return ret!;
		}
		[Export ("boundsRectForTextBlock:atIndex:effectiveRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetBoundsRect (NSTextBlock block, nuint glyphIndex, nint effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, selBoundsRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_UIntPtr_IntPtr (this.Handle, selBoundsRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selBoundsRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selBoundsRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (block);
			return ret!;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetBoundsRect (NSTextBlock block, nuint glyphIndex)
		{
			return GetBoundsRect (block, glyphIndex, IntPtr.Zero);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetBoundsRect (NSTextBlock block, nuint glyphIndex, out NSRange effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_UIntPtr_out_NSRange (this.Handle, selBoundsRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange__pointer);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_UIntPtr_out_NSRange (this.Handle, selBoundsRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange__pointer);
			}
			GC.KeepAlive (block);
			return ret!;
			}
		}
		/// <summary>The index of the first character associated with the glyph at the specified index.</summary><param name="glyphIndex">To be added.</param><returns>To be added.</returns><remarks><para>If <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, calling this method will result in generating all glyphs up to and including <paramref name="glyphIndex" />.</para></remarks>
		[Export ("characterIndexForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetCharacterIndex (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selCharacterIndexForGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selCharacterIndexForGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual nuint GetCharacterIndex (CGPoint point, NSTextContainer container, nint fractionOfDistanceBetweenInsertionPoints)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint_NativeHandle_IntPtr (this.Handle, selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_XHandle, point, container__handle__, fractionOfDistanceBetweenInsertionPoints);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint_NativeHandle_IntPtr (&__objc_super__, selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_XHandle, point, container__handle__, fractionOfDistanceBetweenInsertionPoints);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="container">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetCharacterIndex (CGPoint point, NSTextContainer container)
		{
			return GetCharacterIndex (point, container, IntPtr.Zero);
		}
		/// <param name="point">To be added.</param><param name="container">To be added.</param><param name="fractionOfDistanceBetweenInsertionPoints">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe nuint GetCharacterIndex (CGPoint point, NSTextContainer container, out nfloat fractionOfDistanceBetweenInsertionPoints)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			fixed (nfloat* fractionOfDistanceBetweenInsertionPoints__pointer = &fractionOfDistanceBetweenInsertionPoints) {
			fractionOfDistanceBetweenInsertionPoints = default;
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint_NativeHandle_out_NFloat (this.Handle, selCharacterIndexForPoint_InTextContainer_FractionOfDistanceBetweenInsertionPoints_XHandle, point, container__handle__, fractionOfDistanceBetweenInsertionPoints__pointer);
			GC.KeepAlive (container);
			return ret!;
			}
		}
		/// <param name="glyphRange">To be added.</param><param name="actualGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("characterRangeForGlyphRange:actualGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSRange GetCharacterRange (NSRange glyphRange, nint actualGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_IntPtr (this.Handle, selCharacterRangeForGlyphRange_ActualGlyphRange_XHandle, glyphRange, actualGlyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange_IntPtr (&__objc_super__, selCharacterRangeForGlyphRange_ActualGlyphRange_XHandle, glyphRange, actualGlyphRange);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetCharacterRange (NSRange glyphRange)
		{
			return GetCharacterRange (glyphRange, IntPtr.Zero);
		}
		/// <param name="glyphRange">To be added.</param><param name="actualGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSRange GetCharacterRange (NSRange glyphRange, out NSRange actualGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualGlyphRange__pointer = &actualGlyphRange) {
			actualGlyphRange = default;
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_out_NSRange (this.Handle, selCharacterRangeForGlyphRange_ActualGlyphRange_XHandle, glyphRange, actualGlyphRange__pointer);
			return ret;
			}
		}
		[Export ("defaultBaselineOffsetForFont:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetDefaultBaselineOffset (NSFont font)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (this.Handle, selDefaultBaselineOffsetForFont_XHandle, font__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle (&__objc_super__, selDefaultBaselineOffsetForFont_XHandle, font__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
			return ret!;
		}
		[Export ("defaultLineHeightForFont:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetDefaultLineHeight (NSFont font)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (this.Handle, selDefaultLineHeightForFont_XHandle, font__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle (&__objc_super__, selDefaultLineHeightForFont_XHandle, font__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
			return ret!;
		}
		/// <summary>The indices of the first character and glyph that are not laid out.</summary><param name="characterIndex">To be added.</param><param name="glyphIndex">To be added.</param><remarks><para>Application developers should be aware that <paramref name="characterIndex" /> and <paramref name="glyphIndex" /> may be <see langword="null" /> if the text is fully laid out.</para></remarks>
		[Export ("getFirstUnlaidCharacterIndex:glyphIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetFirstUnlaidCharacterIndex (out nuint characterIndex, out nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (nuint* characterIndex__pointer = &characterIndex) {
			fixed (nuint* glyphIndex__pointer = &glyphIndex) {
			characterIndex = default;
			glyphIndex = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_UIntPtr_out_UIntPtr (this.Handle, selGetFirstUnlaidCharacterIndex_GlyphIndex_XHandle, characterIndex__pointer, glyphIndex__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_UIntPtr_out_UIntPtr (&__objc_super__, selGetFirstUnlaidCharacterIndex_GlyphIndex_XHandle, characterIndex__pointer, glyphIndex__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
		}
		/// <summary>Developers should call <see cref="M:AppKit.NSLayoutManager.GetGlyphIndex(CoreGraphics.CGPoint,AppKit.NSTextContainer)" /> rather than this primitive function.</summary><param name="point">To be added.</param><param name="container">To be added.</param><returns>To be added.</returns><remarks><para>This method is <c>public</c> for overriding purposes but is not intended for developers to call.</para></remarks>
		[Export ("fractionOfDistanceThroughGlyphForPoint:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetFractionOfDistanceThroughGlyph (CGPoint point, NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_CGPoint_NativeHandle (this.Handle, selFractionOfDistanceThroughGlyphForPoint_InTextContainer_XHandle, point, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selFractionOfDistanceThroughGlyphForPoint_InTextContainer_XHandle, point, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><param name="isValidIndex">To be added.</param><summary>Retrieves the glyph as <paramref name="glyphIndex" />, setting <paramref name="isValidIndex" /> to <see langword="true" /> if the index is valid.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("CGGlyphAtIndex:isValidIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual ushort GetGlyph (nuint glyphIndex, out bool isValidIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (bool* isValidIndex__pointer = &isValidIndex) {
			isValidIndex = default;
			ushort ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSend_UIntPtr_out_Boolean (this.Handle, selCGGlyphAtIndex_IsValidIndex_XHandle, glyphIndex, (byte*) isValidIndex__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper_UIntPtr_out_Boolean (&__objc_super__, selCGGlyphAtIndex_IsValidIndex_XHandle, glyphIndex, (byte*) isValidIndex__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		/// <param name="glyphIndex">To be added.</param><summary>Retrieves the glyph at <paramref name="glyphIndex" />.</summary><returns>To be added.</returns><remarks><para>Calling this method generates all glyphs up to and including the glyph at <paramref name="glyphIndex" />.</para></remarks>
		[Export ("CGGlyphAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ushort GetGlyph (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			ushort ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSend_UIntPtr (this.Handle, selCGGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper_UIntPtr (&__objc_super__, selCGGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>The glyph index for the character at the specified index.</summary><param name="characterIndex">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphIndexForCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetGlyphIndex (nuint characterIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selGlyphIndexForCharacterAtIndex_XHandle, characterIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selGlyphIndexForCharacterAtIndex_XHandle, characterIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>The glyph index for the glyph at <paramref name="point" />, in the <paramref name="container" /> object's coordinate system.</summary><param name="point">To be added.</param><param name="container">To be added.</param><param name="fractionOfDistanceThroughGlyph">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual nuint GetGlyphIndex (CGPoint point, NSTextContainer container, out nfloat fractionOfDistanceThroughGlyph)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			fixed (nfloat* fractionOfDistanceThroughGlyph__pointer = &fractionOfDistanceThroughGlyph) {
			fractionOfDistanceThroughGlyph = default;
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint_NativeHandle_out_NFloat (this.Handle, selGlyphIndexForPoint_InTextContainer_FractionOfDistanceThroughGlyph_XHandle, point, container__handle__, fractionOfDistanceThroughGlyph__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint_NativeHandle_out_NFloat (&__objc_super__, selGlyphIndexForPoint_InTextContainer_FractionOfDistanceThroughGlyph_XHandle, point, container__handle__, fractionOfDistanceThroughGlyph__pointer);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
			}
		}
		/// <summary>Developers should call <see cref="M:AppKit.NSLayoutManager.GetGlyphIndex(CoreGraphics.CGPoint,AppKit.NSTextContainer,System.Runtime.InteropServices.NFloat@)" /> rather than this primitive method.</summary><param name="point">To be added.</param><param name="container">To be added.</param><returns>To be added.</returns><remarks><para>This method is public for overriding purposes. Developers should call <see cref="M:AppKit.NSLayoutManager.GetGlyphIndex(CoreGraphics.CGPoint,AppKit.NSTextContainer,System.Runtime.InteropServices.NFloat@)" />  rather than this primitive method.</para></remarks>
		[Export ("glyphIndexForPoint:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetGlyphIndex (CGPoint point, NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint_NativeHandle (this.Handle, selGlyphIndexForPoint_InTextContainer_XHandle, point, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selGlyphIndexForPoint_InTextContainer_XHandle, point, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="characterRange">To be added.</param><param name="actualCharacterRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphRangeForCharacterRange:actualCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSRange GetGlyphRange (NSRange characterRange, nint actualCharacterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_IntPtr (this.Handle, selGlyphRangeForCharacterRange_ActualCharacterRange_XHandle, characterRange, actualCharacterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange_IntPtr (&__objc_super__, selGlyphRangeForCharacterRange_ActualCharacterRange_XHandle, characterRange, actualCharacterRange);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="characterRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetGlyphRange (NSRange characterRange)
		{
			return GetGlyphRange (characterRange, IntPtr.Zero);
		}
		/// <param name="characterRange">To be added.</param><param name="actualCharacterRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSRange GetGlyphRange (NSRange characterRange, out NSRange actualCharacterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualCharacterRange__pointer = &actualCharacterRange) {
			actualCharacterRange = default;
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_out_NSRange (this.Handle, selGlyphRangeForCharacterRange_ActualCharacterRange_XHandle, characterRange, actualCharacterRange__pointer);
			return ret;
			}
		}
		/// <summary>The range of glyph indices contained in the specified <see cref="T:AppKit.NSTextContainer" />.</summary><param name="container">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphRangeForTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetGlyphRange (NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle (this.Handle, selGlyphRangeForTextContainer_XHandle, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle (&__objc_super__, selGlyphRangeForTextContainer_XHandle, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="bounds">To be added.</param><param name="container">To be added.</param><summary>Returns the range of glyph indices that are at least partially in the <paramref name="bounds" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphRangeForBoundingRect:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetGlyphRangeForBoundingRect (CGRect bounds, NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_CGRect_NativeHandle (this.Handle, selGlyphRangeForBoundingRect_InTextContainer_XHandle, bounds, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selGlyphRangeForBoundingRect_InTextContainer_XHandle, bounds, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="bounds">To be added.</param><param name="container">To be added.</param><summary>Returns the range of glyph indices that are at least partially in the <paramref name="bounds" /> without glyph production or layout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetGlyphRangeForBoundingRectWithoutAdditionalLayout (CGRect bounds, NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_CGRect_NativeHandle (this.Handle, selGlyphRangeForBoundingRectWithoutAdditionalLayout_InTextContainer_XHandle, bounds, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selGlyphRangeForBoundingRectWithoutAdditionalLayout_InTextContainer_XHandle, bounds, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="glyphRange">To be added.</param><param name="glyphBuffer">To be added.</param><param name="properties">To be added.</param><param name="characterIndexBuffer">To be added.</param><param name="bidiLevelBuffer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("getGlyphsInRange:glyphs:properties:characterIndexes:bidiLevels:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual nuint GetGlyphs (NSRange glyphRange, nint glyphBuffer, nint properties, nint characterIndexBuffer, nint bidiLevelBuffer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selGetGlyphsInRange_Glyphs_Properties_CharacterIndexes_BidiLevels_XHandle, glyphRange, glyphBuffer, properties, characterIndexBuffer, bidiLevelBuffer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr (&__objc_super__, selGetGlyphsInRange_Glyphs_Properties_CharacterIndexes_BidiLevels_XHandle, glyphRange, glyphBuffer, properties, characterIndexBuffer, bidiLevelBuffer);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("layoutRectForTextBlock:glyphRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetLayoutRect (NSTextBlock block, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NSRange (this.Handle, selLayoutRectForTextBlock_GlyphRange_XHandle, block__handle__, glyphRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NSRange (this.Handle, selLayoutRectForTextBlock_GlyphRange_XHandle, block__handle__, glyphRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selLayoutRectForTextBlock_GlyphRange_XHandle, block__handle__, glyphRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_NSRange (&__objc_super__, selLayoutRectForTextBlock_GlyphRange_XHandle, block__handle__, glyphRange);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (block);
			return ret!;
		}
		[Export ("layoutRectForTextBlock:atIndex:effectiveRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetLayoutRect (NSTextBlock block, nuint glyphIndex, nint effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, selLayoutRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_UIntPtr_IntPtr (this.Handle, selLayoutRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selLayoutRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selLayoutRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (block);
			return ret!;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetLayoutRect (NSTextBlock block, nuint glyphIndex)
		{
			return GetLayoutRect (block, glyphIndex, IntPtr.Zero);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetLayoutRect (NSTextBlock block, nuint glyphIndex, out NSRange effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_UIntPtr_out_NSRange (this.Handle, selLayoutRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange__pointer);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_UIntPtr_out_NSRange (this.Handle, selLayoutRectForTextBlock_AtIndex_EffectiveRange_XHandle, block__handle__, glyphIndex, effectiveGlyphRange__pointer);
			}
			GC.KeepAlive (block);
			return ret!;
			}
		}
		[Export ("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual nuint GetLineFragmentInsertionPoints (nuint characterIndex, bool alternatePositions, bool inDisplayOrder, nint positions, nint characterIndexes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr_bool_bool_IntPtr_IntPtr (this.Handle, selGetLineFragmentInsertionPointsForCharacterAtIndex_AlternatePositions_InDisplayOrder_Positions_CharacterIndexes_XHandle, characterIndex, alternatePositions ? (byte) 1 : (byte) 0, inDisplayOrder ? (byte) 1 : (byte) 0, positions, characterIndexes);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr_bool_bool_IntPtr_IntPtr (&__objc_super__, selGetLineFragmentInsertionPointsForCharacterAtIndex_AlternatePositions_InDisplayOrder_Positions_CharacterIndexes_XHandle, characterIndex, alternatePositions ? (byte) 1 : (byte) 0, inDisplayOrder ? (byte) 1 : (byte) 0, positions, characterIndexes);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("lineFragmentRectForGlyphAtIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetLineFragmentRect (nuint glyphIndex, nint effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_IntPtr (this.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_IntPtr (this.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, selLineFragmentRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr_IntPtr (&__objc_super__, selLineFragmentRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetLineFragmentRect (nuint glyphIndex)
		{
			return GetLineFragmentRect (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">To be added.</param><param name="effectiveGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetLineFragmentRect (nuint glyphIndex, out NSRange effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_out_NSRange (this.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange__pointer);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_out_NSRange (this.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange__pointer);
			}
			return ret!;
			}
		}
		[Export ("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetLineFragmentRect (nuint glyphIndex, nint effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_IntPtr_bool (this.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_IntPtr_bool (this.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr_IntPtr_bool (&__objc_super__, selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr_IntPtr_bool (&__objc_super__, selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><param name="withoutAdditionalLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetLineFragmentRect (nuint glyphIndex, bool withoutAdditionalLayout)
		{
			return GetLineFragmentRect (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">The index of the glyph for which the rect is requested.</param><param name="effectiveGlyphRange">If not <see langword="null" />, the range of all glyphs in the line fragment.</param><param name="withoutAdditionalLayout">If <see langword="true" />, glyph generation and layout are not performed.</param><summary>Gets the line fragment <see cref="T:CoreGraphics.CGRect" /> containing the glyph at <paramref name="glyphIndex" />, with the option of not triggering layout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetLineFragmentRect (nuint glyphIndex, out NSRange effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_out_NSRange_bool (this.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_out_NSRange_bool (this.Handle, selLineFragmentRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
			}
			return ret!;
			}
		}
		[Export ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetLineFragmentUsedRect (nuint glyphIndex, nint effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_IntPtr (this.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_IntPtr (this.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr_IntPtr (&__objc_super__, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetLineFragmentUsedRect (nuint glyphIndex)
		{
			return GetLineFragmentUsedRect (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">To be added.</param><param name="effectiveGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetLineFragmentUsedRect (nuint glyphIndex, out NSRange effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_out_NSRange (this.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange__pointer);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_out_NSRange (this.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange__pointer);
			}
			return ret!;
			}
		}
		[Export ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetLineFragmentUsedRect (nuint glyphIndex, nint effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_IntPtr_bool (this.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_IntPtr_bool (this.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr_IntPtr_bool (&__objc_super__, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr_IntPtr_bool (&__objc_super__, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><param name="withoutAdditionalLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetLineFragmentUsedRect (nuint glyphIndex, bool withoutAdditionalLayout)
		{
			return GetLineFragmentUsedRect (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">The index of the glyph for which the rect is requested.</param><param name="effectiveGlyphRange">If not <see langword="null" />, the range of all glyphs in the line fragment.</param><param name="withoutAdditionalLayout">If <see langword="true" />, glyph generation and layout are not performed.</param><summary>Gets the usage <see cref="T:CoreGraphics.CGRect" /> containing the glyph at <paramref name="glyphIndex" />, with the option of not triggering layout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetLineFragmentUsedRect (nuint glyphIndex, out NSRange effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_out_NSRange_bool (this.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_out_NSRange_bool (this.Handle, selLineFragmentUsedRectForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
			}
			return ret!;
			}
		}
		/// <param name="glyphIndex">To be added.</param><summary>The location of the glyph at the specified index, relative to the containing line fragment's origin.</summary><returns>To be added.</returns><remarks><para>This method will layout and generate glyphs for the line fragment containing the glyph at <paramref name="glyphIndex" />.</para></remarks>
		[Export ("locationForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetLocationForGlyph (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_UIntPtr (this.Handle, selLocationForGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_UIntPtr (&__objc_super__, selLocationForGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("propertyForGlyphAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGlyphProperty GetProperty (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSGlyphProperty ret;
			if (IsDirectBinding) {
				ret = (NSGlyphProperty) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr (this.Handle, selPropertyForGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSGlyphProperty) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selPropertyForGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><summary>The largest range of glyphs surrounding the glyph at the specified index that can be displayed using only advancement, not pairwise kerning or other adjustments.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rangeOfNominallySpacedGlyphsContainingIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetRangeOfNominallySpacedGlyphsContainingIndex (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr (this.Handle, selRangeOfNominallySpacedGlyphsContainingIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr (&__objc_super__, selRangeOfNominallySpacedGlyphsContainingIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("rectArrayForGlyphRange:withinSelectedGlyphRange:inTextContainer:rectCount:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual nint GetRectArray (NSRange glyphRange, NSRange selectedGlyphRange, nint textContainerHandle, out nuint rectCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (nuint* rectCount__pointer = &rectCount) {
			rectCount = default;
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NSRange_NSRange_IntPtr_out_UIntPtr (this.Handle, selRectArrayForGlyphRange_WithinSelectedGlyphRange_InTextContainer_RectCount_XHandle, glyphRange, selectedGlyphRange, textContainerHandle, rectCount__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NSRange_NSRange_IntPtr_out_UIntPtr (&__objc_super__, selRectArrayForGlyphRange_WithinSelectedGlyphRange_InTextContainer_RectCount_XHandle, glyphRange, selectedGlyphRange, textContainerHandle, rectCount__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		[Export ("temporaryAttribute:atCharacterIndex:effectiveRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSObject GetTemporaryAttribute (NSString attributeName, nuint characterIndex, nint effectiveRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributeName__handle__ = attributeName!.GetNonNullHandle (nameof (attributeName));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, selTemporaryAttribute_AtCharacterIndex_EffectiveRange_XHandle, attributeName__handle__, characterIndex, effectiveRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selTemporaryAttribute_AtCharacterIndex_EffectiveRange_XHandle, attributeName__handle__, characterIndex, effectiveRange), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributeName);
			return ret!;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject GetTemporaryAttribute (NSString attributeName, nuint characterIndex)
		{
			return GetTemporaryAttribute (attributeName, characterIndex, IntPtr.Zero);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSObject GetTemporaryAttribute (NSString attributeName, nuint characterIndex, out NSRange effectiveRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributeName__handle__ = attributeName!.GetNonNullHandle (nameof (attributeName));
			fixed (NSRange* effectiveRange__pointer = &effectiveRange) {
			effectiveRange = default;
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_out_NSRange (this.Handle, selTemporaryAttribute_AtCharacterIndex_EffectiveRange_XHandle, attributeName__handle__, characterIndex, effectiveRange__pointer), false)!;
			GC.KeepAlive (attributeName);
			return ret!;
			}
		}
		[Export ("temporaryAttribute:atCharacterIndex:longestEffectiveRange:inRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSObject GetTemporaryAttribute (NSString attributeName, nuint characterIndex, nint longestEffectiveRange, NSRange rangeLimit)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributeName__handle__ = attributeName!.GetNonNullHandle (nameof (attributeName));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr_NSRange (this.Handle, selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_XHandle, attributeName__handle__, characterIndex, longestEffectiveRange, rangeLimit), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr_NSRange (&__objc_super__, selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_XHandle, attributeName__handle__, characterIndex, longestEffectiveRange, rangeLimit), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributeName);
			return ret!;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject GetTemporaryAttribute (NSString attributeName, nuint characterIndex, NSRange rangeLimit)
		{
			return GetTemporaryAttribute (attributeName, characterIndex, IntPtr.Zero, rangeLimit);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSObject GetTemporaryAttribute (NSString attributeName, nuint characterIndex, out NSRange longestEffectiveRange, NSRange rangeLimit)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributeName__handle__ = attributeName!.GetNonNullHandle (nameof (attributeName));
			fixed (NSRange* longestEffectiveRange__pointer = &longestEffectiveRange) {
			longestEffectiveRange = default;
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_out_NSRange_NSRange (this.Handle, selTemporaryAttribute_AtCharacterIndex_LongestEffectiveRange_InRange_XHandle, attributeName__handle__, characterIndex, longestEffectiveRange__pointer, rangeLimit), false)!;
			GC.KeepAlive (attributeName);
			return ret!;
			}
		}
		[Export ("temporaryAttributesAtCharacterIndex:effectiveRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSDictionary<NSString, NSObject> GetTemporaryAttributes (nuint characterIndex, nint effectiveCharacterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDictionary<NSString, NSObject> ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (this.Handle, selTemporaryAttributesAtCharacterIndex_EffectiveRange_XHandle, characterIndex, effectiveCharacterRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, selTemporaryAttributesAtCharacterIndex_EffectiveRange_XHandle, characterIndex, effectiveCharacterRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSObject> GetTemporaryAttributes (nuint characterIndex)
		{
			return GetTemporaryAttributes (characterIndex, IntPtr.Zero);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSDictionary<NSString, NSObject> GetTemporaryAttributes (nuint characterIndex, out NSRange effectiveCharacterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveCharacterRange__pointer = &effectiveCharacterRange) {
			effectiveCharacterRange = default;
			NSDictionary<NSString, NSObject> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange (this.Handle, selTemporaryAttributesAtCharacterIndex_EffectiveRange_XHandle, characterIndex, effectiveCharacterRange__pointer), false)!;
			return ret;
			}
		}
		[Export ("temporaryAttributesAtCharacterIndex:longestEffectiveRange:inRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSDictionary<NSString, NSObject> GetTemporaryAttributes (nuint characterIndex, nint longestEffectiveRange, NSRange rangeLimit)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDictionary<NSString, NSObject> ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_NSRange (this.Handle, selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_XHandle, characterIndex, longestEffectiveRange, rangeLimit), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_NSRange (&__objc_super__, selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_XHandle, characterIndex, longestEffectiveRange, rangeLimit), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSObject> GetTemporaryAttributes (nuint characterIndex, NSRange rangeLimit)
		{
			return GetTemporaryAttributes (characterIndex, IntPtr.Zero, rangeLimit);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSDictionary<NSString, NSObject> GetTemporaryAttributes (nuint characterIndex, out NSRange longestEffectiveRange, NSRange rangeLimit)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* longestEffectiveRange__pointer = &longestEffectiveRange) {
			longestEffectiveRange = default;
			NSDictionary<NSString, NSObject> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange_NSRange (this.Handle, selTemporaryAttributesAtCharacterIndex_LongestEffectiveRange_InRange_XHandle, characterIndex, longestEffectiveRange__pointer, rangeLimit), false)!;
			return ret;
			}
		}
		[Export ("textContainerForGlyphAtIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSTextContainer? GetTextContainer (nuint glyphIndex, nint effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextContainer ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (this.Handle, selTextContainerForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, selTextContainerForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextContainer? GetTextContainer (nuint glyphIndex)
		{
			return GetTextContainer (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">To be added.</param><param name="effectiveGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSTextContainer? GetTextContainer (nuint glyphIndex, out NSRange effectiveGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			NSTextContainer ret;
			ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange (this.Handle, selTextContainerForGlyphAtIndex_EffectiveRange_XHandle, glyphIndex, effectiveGlyphRange__pointer), false)!;
			return ret;
			}
		}
		[Export ("textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSTextContainer? GetTextContainer (nuint glyphIndex, nint effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextContainer ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_bool (this.Handle, selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_bool (&__objc_super__, selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphIndex">To be added.</param><param name="flag">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextContainer? GetTextContainer (nuint glyphIndex, bool flag)
		{
			return GetTextContainer (glyphIndex, IntPtr.Zero, flag);
		}
		/// <summary>Gets the <see cref="T:AppKit.NSTextContainer" /> containing the glyph at <paramref name="glyphIndex" />, with the option of not triggering layout.</summary><param name="glyphIndex">The index of the glyph for which the rect is requested.</param><param name="effectiveGlyphRange">If not <see langword="null" />, the range of all glyphs in the line fragment.</param><param name="withoutAdditionalLayout">If <see langword="true" />, glyph generation and layout are not performed.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSTextContainer? GetTextContainer (nuint glyphIndex, out NSRange effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			NSTextContainer ret;
			ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange_bool (this.Handle, selTextContainerForGlyphAtIndex_EffectiveRange_WithoutAdditionalLayout_XHandle, glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0), false)!;
			return ret;
			}
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("truncatedGlyphRangeInLineFragmentForGlyphAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetTruncatedGlyphRangeInLineFragment (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr (this.Handle, selTruncatedGlyphRangeInLineFragmentForGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr (&__objc_super__, selTruncatedGlyphRangeInLineFragmentForGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>The bounding rectangle in the <see cref="T:AppKit.NSTextContainer" />'s coordinates of the laid out glyphs in the <see cref="T:AppKit.NSTextContainer" />.</summary><param name="container">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("usedRectForTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetUsedRect (NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, selUsedRectForTextContainer_XHandle, container__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, selUsedRectForTextContainer_XHandle, container__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, selUsedRectForTextContainer_XHandle, container__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, selUsedRectForTextContainer_XHandle, container__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <summary>Developers should use <see cref="M:AppKit.NSLayoutManager.GetGlyph(System.UIntPtr,System.Boolean@)" /> rather than this deprecated method.</summary><param name="glyphIndex">To be added.</param><param name="isValidIndex">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphAtIndex:isValidIndex:")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GetCGGlyph' instead).")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetGlyph' instead.")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual uint GlyphAtIndex (nuint glyphIndex, ref bool isValidIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (bool* isValidIndex__pointer = &isValidIndex) {
			uint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend_UIntPtr_ref_Boolean (this.Handle, selGlyphAtIndex_IsValidIndex_XHandle, glyphIndex, (byte*) isValidIndex__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UIntPtr_ref_Boolean (&__objc_super__, selGlyphAtIndex_IsValidIndex_XHandle, glyphIndex, (byte*) isValidIndex__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		/// <summary>Developers should not use this deprecated method. Developers should use <see cref="M:AppKit.NSLayoutManager.GetGlyph(System.UIntPtr,System.Boolean@)" /> instead.</summary><param name="glyphIndex">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphAtIndex:")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GetCGGlyph' instead).")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetGlyph' instead.")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint GlyphAtIndex (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			uint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend_UIntPtr (this.Handle, selGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UIntPtr (&__objc_super__, selGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Inserts the specified <see cref="T:AppKit.NSTextContainer" /> into <see cref="P:AppKit.NSLayoutManager.TextContainers" /> at the specified <paramref name="index" />.</summary><param name="container">To be added.</param><param name="index">To be added.</param><altmember cref="M:AppKit.NSLayoutManager.AddTextContainer(AppKit.NSTextContainer)" />
		[Export ("insertTextContainer:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertTextContainer (NSTextContainer container, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertTextContainer_AtIndex_XHandle, container__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertTextContainer_AtIndex_XHandle, container__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Invalidates the display for the given character range.</summary><param name="characterRange">To be added.</param><remarks><para>This method does not automatically trigger layout.</para></remarks>
		[Export ("invalidateDisplayForCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateDisplayForCharacterRange (NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selInvalidateDisplayForCharacterRange_XHandle, characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selInvalidateDisplayForCharacterRange_XHandle, characterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Invalidates the display for the given glyph range.</summary><param name="glyphRange">To be added.</param><remarks><para>This method does not automatically trigger layout.</para></remarks>
		[Export ("invalidateDisplayForGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateDisplayForGlyphRange (NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selInvalidateDisplayForGlyphRange_XHandle, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selInvalidateDisplayForGlyphRange_XHandle, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual void InvalidateGlyphs (NSRange characterRange, nint delta, nint actualCharacterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_IntPtr (this.Handle, selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_XHandle, characterRange, delta, actualCharacterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_IntPtr (&__objc_super__, selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_XHandle, characterRange, delta, actualCharacterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="characterRange">To be added.</param><param name="delta">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateGlyphs (NSRange characterRange, nint delta)
		{
			InvalidateGlyphs (characterRange, delta, IntPtr.Zero);
		}
		/// <summary>Invalidates the glyphs in the <paramref name="characterRange" />.</summary><param name="characterRange">To be added.</param><param name="delta">To be added.</param><param name="actualCharacterRange">To be added.</param><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void InvalidateGlyphs (NSRange characterRange, nint delta, out NSRange actualCharacterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualCharacterRange__pointer = &actualCharacterRange) {
			actualCharacterRange = default;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_out_NSRange (this.Handle, selInvalidateGlyphsForCharacterRange_ChangeInLength_ActualCharacterRange_XHandle, characterRange, delta, actualCharacterRange__pointer);
			}
		}
		[Export ("invalidateLayoutForCharacterRange:actualCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual void InvalidateLayout (NSRange characterRange, nint actualCharacterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr (this.Handle, selInvalidateLayoutForCharacterRange_ActualCharacterRange_XHandle, characterRange, actualCharacterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr (&__objc_super__, selInvalidateLayoutForCharacterRange_ActualCharacterRange_XHandle, characterRange, actualCharacterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="characterRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateLayout (NSRange characterRange)
		{
			InvalidateLayout (characterRange, IntPtr.Zero);
		}
		/// <summary>Invalidates the layout for the specified character range. Does not automatically trigger re-layout.</summary><param name="actualCharacterRange">If not <see langword="null" />, on output holds the actual range invalidated.</param><remarks><para>This method does not trigger either glyph generation or layout. Application developers will not normally need to call this method.</para></remarks><param name="characterRange">To be added.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void InvalidateLayout (NSRange characterRange, out NSRange actualCharacterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualCharacterRange__pointer = &actualCharacterRange) {
			actualCharacterRange = default;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_out_NSRange (this.Handle, selInvalidateLayoutForCharacterRange_ActualCharacterRange_XHandle, characterRange, actualCharacterRange__pointer);
			}
		}
		/// <summary>Whether the glyph at the specified index is shown.</summary><param name="glyphIndex">To be added.</param><returns>To be added.</returns><remarks><para>Glyphs such as tabs and newlines are not typically shown, but effect layout. Spaces are considered shown, as they "show" a characteristic displacement.</para><para>This method will cause layout up to the specified index. If <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="true" />, the layout will be confined to the containing line fragment.</para></remarks>
		[Export ("notShownAttributeForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsNotShownAttributeForGlyph (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, selNotShownAttributeForGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, selNotShownAttributeForGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>Whether the <paramref name="glyphIndex" /> specifies a valid glyph.</summary><param name="glyphIndex">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isValidGlyphIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsValidGlyph (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, selIsValidGlyphIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, selIsValidGlyphIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="textStorage">To be added.</param><param name="editMask">To be added.</param><param name="newCharacterRange">To be added.</param><param name="delta">To be added.</param><param name="invalidatedCharacterRange">To be added.</param><summary>Notifies the <see cref="T:AppKit.NSLayoutManager" /> of an edit action.</summary><remarks>To be added.</remarks>
		[Export ("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProcessEditing (NSTextStorage textStorage, NSTextStorageEditActions editMask, NSRange newCharacterRange, nint delta, NSRange invalidatedCharacterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NSRange_IntPtr_NSRange (this.Handle, selProcessEditingForTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_XHandle, textStorage__handle__, (UIntPtr) (ulong) editMask, newCharacterRange, delta, invalidatedCharacterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange_IntPtr_NSRange (&__objc_super__, selProcessEditingForTextStorage_Edited_Range_ChangeInLength_InvalidatedRange_XHandle, textStorage__handle__, (UIntPtr) (ulong) editMask, newCharacterRange, delta, invalidatedCharacterRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textStorage);
		}
		[Export ("removeTemporaryAttribute:forCharacterRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTemporaryAttribute (NSString attributeName, NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributeName__handle__ = attributeName!.GetNonNullHandle (nameof (attributeName));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selRemoveTemporaryAttribute_ForCharacterRange_XHandle, attributeName__handle__, characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selRemoveTemporaryAttribute_ForCharacterRange_XHandle, attributeName__handle__, characterRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributeName);
		}
		/// <param name="attributeName">To be added.</param><param name="characterRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveTemporaryAttribute (string attributeName, NSRange characterRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (attributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attributeName));
			var nsattributeName = CFString.CreateNative (attributeName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selRemoveTemporaryAttribute_ForCharacterRange_XHandle, nsattributeName, characterRange);
			CFString.ReleaseNative (nsattributeName);
		}
		/// <summary>Removes the specified <see cref="T:AppKit.NSTextContainer" /> from the <see cref="P:AppKit.NSLayoutManager.TextContainers" /> array. Invalidates layout as necessary.</summary><param name="index">To be added.</param><remarks>To be added.</remarks>
		[Export ("removeTextContainerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTextContainer (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveTextContainerAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selRemoveTextContainerAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Sets the size for the glyph to draw within the <paramref name="glyphRange" />.</summary><param name="attachmentSize">To be added.</param><param name="glyphRange">To be added.</param><remarks>To be added.</remarks>
		[Export ("setAttachmentSize:forGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttachmentSize (CGSize attachmentSize, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize_NSRange (this.Handle, selSetAttachmentSize_ForGlyphRange_XHandle, attachmentSize, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize_NSRange (&__objc_super__, selSetAttachmentSize_ForGlyphRange_XHandle, attachmentSize, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setBoundsRect:forTextBlock:glyphRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBoundsRect (CGRect boundsRect, NSTextBlock forTextBlock, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var forTextBlock__handle__ = forTextBlock!.GetNonNullHandle (nameof (forTextBlock));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_NSRange (this.Handle, selSetBoundsRect_ForTextBlock_GlyphRange_XHandle, boundsRect, forTextBlock__handle__, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_NSRange (&__objc_super__, selSetBoundsRect_ForTextBlock_GlyphRange_XHandle, boundsRect, forTextBlock__handle__, glyphRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forTextBlock);
		}
		/// <summary>Specifies whether the glyph at the specified index draws outside the bounds of its line segment.</summary><param name="flag">To be added.</param><param name="glyphIndex">To be added.</param><remarks><para>This method is generally only called by custom typesetters.</para></remarks>
		[Export ("setDrawsOutsideLineFragment:forGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDrawsOutsideLineFragment (bool flag, nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_UIntPtr (this.Handle, selSetDrawsOutsideLineFragment_ForGlyphAtIndex_XHandle, flag ? (byte) 1 : (byte) 0, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_UIntPtr (&__objc_super__, selSetDrawsOutsideLineFragment_ForGlyphAtIndex_XHandle, flag ? (byte) 1 : (byte) 0, glyphIndex);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Sets the details for the extra line fragment required when the text back is either totally empty or ends with a hard line break.</summary><param name="fragmentRect">To be added.</param><param name="usedRect">To be added.</param><param name="container">To be added.</param><remarks><para>Developers should only call this method when implementing custom typesetting.</para></remarks>
		[Export ("setExtraLineFragmentRect:usedRect:textContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetExtraLineFragment (CGRect fragmentRect, CGRect usedRect, NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_CGRect_NativeHandle (this.Handle, selSetExtraLineFragmentRect_UsedRect_TextContainer_XHandle, fragmentRect, usedRect, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_CGRect_NativeHandle (&__objc_super__, selSetExtraLineFragmentRect_UsedRect_TextContainer_XHandle, fragmentRect, usedRect, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <param name="glyphs">To be added.</param><param name="properties">To be added.</param><param name="characterIndexes">To be added.</param><param name="font">To be added.</param><param name="glyphRange">To be added.</param><summary>Specifies the initial glyphs and glyph properties for the specified character range.</summary><remarks>To be added.</remarks>
		[Export ("setGlyphs:properties:characterIndexes:font:forGlyphRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetGlyphs (nint glyphs, nint properties, nint characterIndexes, NSFont font, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NativeHandle_NSRange (this.Handle, selSetGlyphs_Properties_CharacterIndexes_Font_ForGlyphRange_XHandle, glyphs, properties, characterIndexes, font__handle__, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_NativeHandle_NSRange (&__objc_super__, selSetGlyphs_Properties_CharacterIndexes_Font_ForGlyphRange_XHandle, glyphs, properties, characterIndexes, font__handle__, glyphRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
		}
		[Export ("setLayoutRect:forTextBlock:glyphRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLayoutRect (CGRect layoutRect, NSTextBlock forTextBlock, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var forTextBlock__handle__ = forTextBlock!.GetNonNullHandle (nameof (forTextBlock));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_NSRange (this.Handle, selSetLayoutRect_ForTextBlock_GlyphRange_XHandle, layoutRect, forTextBlock__handle__, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_NSRange (&__objc_super__, selSetLayoutRect_ForTextBlock_GlyphRange_XHandle, layoutRect, forTextBlock__handle__, glyphRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forTextBlock);
		}
		/// <summary>Associated the line fragment with bounds <paramref name="fragmentRect" /> with the glyphs in <paramref name="glyphRange" />.</summary><param name="fragmentRect">To be added.</param><param name="glyphRange">To be added.</param><param name="usedRect">To be added.</param><remarks>To be added.</remarks>
		[Export ("setLineFragmentRect:forGlyphRange:usedRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLineFragment (CGRect fragmentRect, NSRange glyphRange, CGRect usedRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NSRange_CGRect (this.Handle, selSetLineFragmentRect_ForGlyphRange_UsedRect_XHandle, fragmentRect, glyphRange, usedRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NSRange_CGRect (&__objc_super__, selSetLineFragmentRect_ForGlyphRange_UsedRect_XHandle, fragmentRect, glyphRange, usedRect);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Sets the <paramref name="location" /> for the first glyph in <paramref name="forStartOfGlyphRange" />.</summary><param name="location">To be added.</param><param name="forStartOfGlyphRange">To be added.</param><remarks>To be added.</remarks>
		[Export ("setLocation:forStartOfGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLocation (CGPoint location, NSRange forStartOfGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NSRange (this.Handle, selSetLocation_ForStartOfGlyphRange_XHandle, location, forStartOfGlyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_NSRange (&__objc_super__, selSetLocation_ForStartOfGlyphRange_XHandle, location, forStartOfGlyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Specifies that the glyph at the specified index should be marked as not shown.</summary><param name="flag">To be added.</param><param name="glyphIndex">To be added.</param><remarks><para>This method is generally only called by custom typesetters.</para></remarks>
		[Export ("setNotShownAttribute:forGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNotShownAttribute (bool flag, nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_UIntPtr (this.Handle, selSetNotShownAttribute_ForGlyphAtIndex_XHandle, flag ? (byte) 1 : (byte) 0, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_UIntPtr (&__objc_super__, selSetNotShownAttribute_ForGlyphAtIndex_XHandle, flag ? (byte) 1 : (byte) 0, glyphIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setTemporaryAttributes:forCharacterRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTemporaryAttributes (NSDictionary attrs, NSRange charRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attrs__handle__ = attrs!.GetNonNullHandle (nameof (attrs));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selSetTemporaryAttributes_ForCharacterRange_XHandle, attrs__handle__, charRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selSetTemporaryAttributes_ForCharacterRange_XHandle, attrs__handle__, charRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attrs);
		}
		/// <summary>Sets the NSTextContainer for the specified glyph range.</summary><param name="container">To be added.</param><param name="glyphRange">To be added.</param><remarks>To be added.</remarks>
		[Export ("setTextContainer:forGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTextContainer (NSTextContainer container, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selSetTextContainer_ForGlyphRange_XHandle, container__handle__, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selSetTextContainer_ForGlyphRange_XHandle, container__handle__, glyphRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		[Export ("showAttachmentCell:inRect:characterIndex:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAttachmentCell (NSCell cell, CGRect rect, nuint characterIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var cell__handle__ = cell!.GetNonNullHandle (nameof (cell));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGRect_UIntPtr (this.Handle, selShowAttachmentCell_InRect_CharacterIndex_XHandle, cell__handle__, rect, characterIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGRect_UIntPtr (&__objc_super__, selShowAttachmentCell_InRect_CharacterIndex_XHandle, cell__handle__, rect, characterIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cell);
		}
		[Export ("showCGGlyphs:positions:count:font:matrix:attributes:inContext:")]
		[ObsoletedOSPlatform ("macos10.15", "Use the overload that takes 'nint glyphCount' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the overload that takes 'nint glyphCount' instead.")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual void ShowGlyphs (nint glyphs, nint positions, nuint glyphCount, NSFont font, CGAffineTransform textMatrix, NSDictionary attributes, CGContext graphicsContext)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var graphicsContext__handle__ = graphicsContext!.GetNonNullHandle (nameof (graphicsContext));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UIntPtr_NativeHandle_CGAffineTransform_NativeHandle_NativeHandle (this.Handle, selShowCGGlyphs_Positions_Count_Font_Matrix_Attributes_InContext_XHandle, glyphs, positions, glyphCount, font__handle__, textMatrix, attributes__handle__, graphicsContext.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UIntPtr_NativeHandle_CGAffineTransform_NativeHandle_NativeHandle (&__objc_super__, selShowCGGlyphs_Positions_Count_Font_Matrix_Attributes_InContext_XHandle, glyphs, positions, glyphCount, font__handle__, textMatrix, attributes__handle__, graphicsContext.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
			GC.KeepAlive (attributes);
			GC.KeepAlive (graphicsContext);
		}
		[Export ("showCGGlyphs:positions:count:font:textMatrix:attributes:inContext:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual void ShowGlyphs (nint glyphs, nint positions, nint glyphCount, NSFont font, CGAffineTransform textMatrix, NSDictionary attributes, CGContext graphicsContext)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var graphicsContext__handle__ = graphicsContext!.GetNonNullHandle (nameof (graphicsContext));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NativeHandle_CGAffineTransform_NativeHandle_NativeHandle (this.Handle, selShowCGGlyphs_Positions_Count_Font_TextMatrix_Attributes_InContext_XHandle, glyphs, positions, glyphCount, font__handle__, textMatrix, attributes__handle__, graphicsContext.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_NativeHandle_CGAffineTransform_NativeHandle_NativeHandle (&__objc_super__, selShowCGGlyphs_Positions_Count_Font_TextMatrix_Attributes_InContext_XHandle, glyphs, positions, glyphCount, font__handle__, textMatrix, attributes__handle__, graphicsContext.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
			GC.KeepAlive (attributes);
			GC.KeepAlive (graphicsContext);
		}
		/// <summary>Draws a strikethrough through the glyphs at <paramref name="glyphRange" />.</summary><param name="glyphRange">To be added.</param><param name="strikethroughVal">To be added.</param><param name="lineRect">To be added.</param><param name="lineGlyphRange">To be added.</param><param name="containerOrigin">To be added.</param><remarks>To be added.</remarks>
		[Export ("strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Strikethrough (NSRange glyphRange, NSUnderlineStyle strikethroughVal, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_CGRect_NSRange_CGPoint (this.Handle, selStrikethroughGlyphRange_StrikethroughType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle, glyphRange, (IntPtr) (long) strikethroughVal, lineRect, lineGlyphRange, containerOrigin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_CGRect_NSRange_CGPoint (&__objc_super__, selStrikethroughGlyphRange_StrikethroughType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle, glyphRange, (IntPtr) (long) strikethroughVal, lineRect, lineGlyphRange, containerOrigin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Invalidates the layout information and glyphs for the specified <see cref="T:AppKit.NSTextContainer" /> and any following.</summary><param name="container">To be added.</param><remarks><para>Application developers will typically not need to call this method unless they have subclassed <see cref="T:AppKit.NSTextContainer" /> (for example, creating a <see cref="T:AppKit.NSTextContainer" /> subclass that changes shape to accommodate placed graphics).</para></remarks>
		[Export ("textContainerChangedGeometry:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextContainerChangedGeometry (NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTextContainerChangedGeometry_XHandle, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextContainerChangedGeometry_XHandle, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		[Export ("textContainerChangedTextView:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextContainerChangedTextView (NSTextContainer container)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTextContainerChangedTextView_XHandle, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTextContainerChangedTextView_XHandle, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Underlines the glyphs in <paramref name="glyphRange" />.</summary><param name="glyphRange">To be added.</param><param name="underlineVal">To be added.</param><param name="lineRect">To be added.</param><param name="lineGlyphRange">To be added.</param><param name="containerOrigin">To be added.</param><remarks>To be added.</remarks>
		[Export ("underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Underline (NSRange glyphRange, NSUnderlineStyle underlineVal, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_CGRect_NSRange_CGPoint (this.Handle, selUnderlineGlyphRange_UnderlineType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle, glyphRange, (IntPtr) (long) underlineVal, lineRect, lineGlyphRange, containerOrigin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_CGRect_NSRange_CGPoint (&__objc_super__, selUnderlineGlyphRange_UnderlineType_LineFragmentRect_LineFragmentGlyphRange_ContainerOrigin_XHandle, glyphRange, (IntPtr) (long) underlineVal, lineRect, lineGlyphRange, containerOrigin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Whether layout can be done for a portion of the document without laying-out being recalculated from the beginning.</summary><value>The default value is <see langword="false" />.</value><remarks><para>Setting this value to <see langword="true" /> allows the <see cref="T:AppKit.NSLayoutManager" /> to perform noncontiguous layout. In large documents, this can significantly increase performance, since the layout does not need to performed from the beginning of the document.</para><para>Application developers can use the <c>EnsureLayout...</c> methods with noncontiguous methods to confirm that particular portions of the text are being laid out properly.</para><para>The <see cref="T:AppKit.NSLayoutManager" /> is instantiated with its <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> property set to <see langword="true" />.</para></remarks><altmember cref="P:AppKit.NSLayoutManager.HasNonContiguousLayout" /><altmember cref="M:AppKit.NSLayoutManager.EnsureGlyphsForCharacterRange(Foundation.NSRange)" /><altmember cref="M:AppKit.NSLayoutManager.EnsureGlyphsForGlyphRange(Foundation.NSRange)" /><altmember cref="M:AppKit.NSLayoutManager.EnsureLayoutForCharacterRange(Foundation.NSRange)" /><altmember cref="M:AppKit.NSLayoutManager.EnsureLayoutForGlyphRange(Foundation.NSRange)" /><altmember cref="M:AppKit.NSLayoutManager.EnsureLayoutForTextContainer(AppKit.NSTextContainer)" /><altmember cref="M:AppKit.NSLayoutManager.EnsureLayoutForBoundingRect(CoreGraphics.CGRect,AppKit.NSTextContainer)" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsNonContiguousLayout {
			[Export ("allowsNonContiguousLayout")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsNonContiguousLayoutXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsNonContiguousLayoutXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsNonContiguousLayout:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsNonContiguousLayout_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsNonContiguousLayout_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool BackgroundLayoutEnabled {
			[Export ("backgroundLayoutEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBackgroundLayoutEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selBackgroundLayoutEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBackgroundLayoutEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBackgroundLayoutEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetBackgroundLayoutEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSImageScaling DefaultAttachmentScaling {
			[Export ("defaultAttachmentScaling")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSImageScaling ret;
				if (IsDirectBinding) {
					ret = (NSImageScaling) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDefaultAttachmentScalingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSImageScaling) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDefaultAttachmentScalingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDefaultAttachmentScaling:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetDefaultAttachmentScaling_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetDefaultAttachmentScaling_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the UIKit.INSLayoutManagerDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.INSLayoutManagerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSLayoutManagerDelegate Delegate {
			get {
				return (WeakDelegate as INSLayoutManagerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>The <see cref="T:CoreGraphics.CGRect" /> needed for the insertion point.</summary><value>Returns the rectangle defining the extra line fragment for the insertion point or {0,0,0,0} if there is no such retangle.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ExtraLineFragmentRect {
			[Export ("extraLineFragmentRect")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selExtraLineFragmentRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selExtraLineFragmentRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selExtraLineFragmentRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selExtraLineFragmentRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>The <see cref="T:AppKit.NSTextContainer" /> containing the <see cref="P:AppKit.NSLayoutManager.ExtraLineFragmentRect" />.</summary><value>Returns <see langword="null" /> if the <see cref="P:AppKit.NSLayoutManager.ExtraLineFragmentRect" /> does not exist (is {0,0,0,0}).</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContainer ExtraLineFragmentTextContainer {
			[Export ("extraLineFragmentTextContainer")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExtraLineFragmentTextContainerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExtraLineFragmentTextContainerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The rectangle enclosing the insertion point.</summary><value>Twice the <see cref="P:AppKit.NSTextContainer.LineFragmentPadding" />, with the insertion point in the middle.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ExtraLineFragmentUsedRect {
			[Export ("extraLineFragmentUsedRect")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selExtraLineFragmentUsedRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selExtraLineFragmentUsedRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selExtraLineFragmentUsedRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selExtraLineFragmentUsedRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>The index of the first character that has not been laid out.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint FirstUnlaidCharacterIndex {
			[Export ("firstUnlaidCharacterIndex")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFirstUnlaidCharacterIndexXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFirstUnlaidCharacterIndexXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The index of the first glyph that has not been laid out.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint FirstUnlaidGlyphIndex {
			[Export ("firstUnlaidGlyphIndex")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFirstUnlaidGlyphIndexXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFirstUnlaidGlyphIndexXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.11")]
		[SupportedOSPlatform ("macos")]
		public virtual NSGlyphGenerator GlyphGenerator {
			[Export ("glyphGenerator", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSGlyphGenerator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSGlyphGenerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGlyphGeneratorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSGlyphGenerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGlyphGeneratorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGlyphGenerator:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGlyphGenerator_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGlyphGenerator_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Whether the <see cref="T:AppKit.NSLayoutManager" /> currently contains any areas of noncontiguous layout.</summary><remarks><para>Even if <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="true" />, this method may return <see langword="false" />, for instance, if layout is complete.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasNonContiguousLayout {
			[Export ("hasNonContiguousLayout")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasNonContiguousLayoutXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasNonContiguousLayoutXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>The hyphenation threshold.</summary><value>A value in the range 0 to 1. 0 indicates hyphenation is off, 1.0 causes hyphenation to always be attempted.</value><remarks><para>Application developers should prefer to set this value to 0.0, because hyphenation is slow and consumes memory.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.15", "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual float HyphenationFactor {
			[Export ("hyphenationFactor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selHyphenationFactorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selHyphenationFactorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHyphenationFactor:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetHyphenationFactor_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetHyphenationFactor_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool LimitsLayoutForSuspiciousContents {
			[Export ("limitsLayoutForSuspiciousContents")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLimitsLayoutForSuspiciousContentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selLimitsLayoutForSuspiciousContentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setLimitsLayoutForSuspiciousContents:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLimitsLayoutForSuspiciousContents_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetLimitsLayoutForSuspiciousContents_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The number of glyphs in the <see cref="T:AppKit.NSLayoutManager" />.</summary><value>To be added.</value><remarks><para>If <see cref="P:AppKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, this method will force glyph generation for all characters.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfGlyphs {
			[Export ("numberOfGlyphs")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfGlyphsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfGlyphsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Specifies whether control characters should be shown or not.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsControlCharacters {
			[Export ("showsControlCharacters")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsControlCharactersXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsControlCharactersXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsControlCharacters:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsControlCharacters_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsControlCharacters_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Specifies whether normally-invisible characters such as whitespace should have visible glyphs.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsInvisibleCharacters {
			[Export ("showsInvisibleCharacters")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsInvisibleCharactersXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsInvisibleCharactersXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsInvisibleCharacters:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsInvisibleCharacters_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsInvisibleCharacters_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An array of <see cref="T:AppKit.NSTextContainer" />s that model the geometric layout of a document.</summary><remarks><para>The <see cref="T:AppKit.NSLayoutManager" /> lays out the text in its <see cref="P:AppKit.NSLayoutManager.TextStorage" /> property in the <see cref="T:AppKit.NSTextContainer" />s of this property, starting with the <see cref="T:AppKit.NSTextContainer" /> at index 0. </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContainer[] TextContainers {
			[Export ("textContainers")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextContainer[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTextContainer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextContainersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTextContainer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextContainersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextStorage_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextStorage? TextStorage {
			[Export ("textStorage", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextStorage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextStorageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextStorageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextStorage_var = ret;
				return ret!;
			}
			[Export ("setTextStorage:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextStorage_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextStorage_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_TextStorage_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSTypesetter Typesetter {
			[Export ("typesetter", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTypesetter? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTypesetter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTypesetterXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTypesetter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTypesetterXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTypesetter:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTypesetter_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTypesetter_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSTypesetterBehavior TypesetterBehavior {
			[Export ("typesetterBehavior")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTypesetterBehavior ret;
				if (IsDirectBinding) {
					ret = (NSTypesetterBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTypesetterBehaviorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTypesetterBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTypesetterBehaviorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTypesetterBehavior:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTypesetterBehavior_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetTypesetterBehavior_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public virtual bool UsesDefaultHyphenation {
			[Export ("usesDefaultHyphenation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesDefaultHyphenationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesDefaultHyphenationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesDefaultHyphenation:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesDefaultHyphenation_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesDefaultHyphenation_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the <see cref="T:AppKit.NSLayoutManager" /> should use the leading provided in the font.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesFontLeading {
			[Export ("usesFontLeading")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesFontLeadingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesFontLeadingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesFontLeading:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesFontLeading_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesFontLeading_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.11")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool UsesScreenFonts {
			[Export ("usesScreenFonts")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesScreenFontsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesScreenFontsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesScreenFonts:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesScreenFonts_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesScreenFonts_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TextStorage_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSLayoutManager */
}
