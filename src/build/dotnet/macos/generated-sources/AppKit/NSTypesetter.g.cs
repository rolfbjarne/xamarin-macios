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
	[Register("NSTypesetter", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTypesetter : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionForControlCharacterAtIndex_X = "actionForControlCharacterAtIndex:";
		static readonly NativeHandle selActionForControlCharacterAtIndex_XHandle = Selector.GetHandle ("actionForControlCharacterAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringX = "attributedString";
		static readonly NativeHandle selAttributedStringXHandle = Selector.GetHandle ("attributedString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesForExtraLineFragmentX = "attributesForExtraLineFragment";
		static readonly NativeHandle selAttributesForExtraLineFragmentXHandle = Selector.GetHandle ("attributesForExtraLineFragment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaselineOffsetInLayoutManager_GlyphIndex_X = "baselineOffsetInLayoutManager:glyphIndex:";
		static readonly NativeHandle selBaselineOffsetInLayoutManager_GlyphIndex_XHandle = Selector.GetHandle ("baselineOffsetInLayoutManager:glyphIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginLineWithGlyphAtIndex_X = "beginLineWithGlyphAtIndex:";
		static readonly NativeHandle selBeginLineWithGlyphAtIndex_XHandle = Selector.GetHandle ("beginLineWithGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginParagraphX = "beginParagraph";
		static readonly NativeHandle selBeginParagraphXHandle = Selector.GetHandle ("beginParagraph");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBidiProcessingEnabledX = "bidiProcessingEnabled";
		static readonly NativeHandle selBidiProcessingEnabledXHandle = Selector.GetHandle ("bidiProcessingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_X = "boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:";
		static readonly NativeHandle selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle = Selector.GetHandle ("boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterRangeForGlyphRange_ActualGlyphRange_X = "characterRangeForGlyphRange:actualGlyphRange:";
		static readonly NativeHandle selCharacterRangeForGlyphRange_ActualGlyphRange_XHandle = Selector.GetHandle ("characterRangeForGlyphRange:actualGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentParagraphStyleX = "currentParagraphStyle";
		static readonly NativeHandle selCurrentParagraphStyleXHandle = Selector.GetHandle ("currentParagraphStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentTextContainerX = "currentTextContainer";
		static readonly NativeHandle selCurrentTextContainerXHandle = Selector.GetHandle ("currentTextContainer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultTypesetterBehaviorX = "defaultTypesetterBehavior";
		static readonly NativeHandle selDefaultTypesetterBehaviorXHandle = Selector.GetHandle ("defaultTypesetterBehavior");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteGlyphsInRange_X = "deleteGlyphsInRange:";
		static readonly NativeHandle selDeleteGlyphsInRange_XHandle = Selector.GetHandle ("deleteGlyphsInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndLineWithGlyphRange_X = "endLineWithGlyphRange:";
		static readonly NativeHandle selEndLineWithGlyphRange_XHandle = Selector.GetHandle ("endLineWithGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndParagraphX = "endParagraph";
		static readonly NativeHandle selEndParagraphXHandle = Selector.GetHandle ("endParagraph");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetGlyphsInRange_Glyphs_CharacterIndexes_GlyphInscriptions_ElasticBits_BidiLevels_X = "getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:";
		static readonly NativeHandle selGetGlyphsInRange_Glyphs_CharacterIndexes_GlyphInscriptions_ElasticBits_BidiLevels_XHandle = Selector.GetHandle ("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetLineFragmentRect_UsedRect_ForParagraphSeparatorGlyphRange_AtProposedOrigin_X = "getLineFragmentRect:usedRect:forParagraphSeparatorGlyphRange:atProposedOrigin:";
		static readonly NativeHandle selGetLineFragmentRect_UsedRect_ForParagraphSeparatorGlyphRange_AtProposedOrigin_XHandle = Selector.GetHandle ("getLineFragmentRect:usedRect:forParagraphSeparatorGlyphRange:atProposedOrigin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetLineFragmentRect_UsedRect_RemainingRect_ForStartingGlyphAtIndex_ProposedRect_LineSpacing_ParagraphSpacingBefore_ParagraphSpacingAfter_X = "getLineFragmentRect:usedRect:remainingRect:forStartingGlyphAtIndex:proposedRect:lineSpacing:paragraphSpacingBefore:paragraphSpacingAfter:";
		static readonly NativeHandle selGetLineFragmentRect_UsedRect_RemainingRect_ForStartingGlyphAtIndex_ProposedRect_LineSpacing_ParagraphSpacingBefore_ParagraphSpacingAfter_XHandle = Selector.GetHandle ("getLineFragmentRect:usedRect:remainingRect:forStartingGlyphAtIndex:proposedRect:lineSpacing:paragraphSpacingBefore:paragraphSpacingAfter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphRangeForCharacterRange_ActualCharacterRange_X = "glyphRangeForCharacterRange:actualCharacterRange:";
		static readonly NativeHandle selGlyphRangeForCharacterRange_ActualCharacterRange_XHandle = Selector.GetHandle ("glyphRangeForCharacterRange:actualCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHyphenCharacterForGlyphAtIndex_X = "hyphenCharacterForGlyphAtIndex:";
		static readonly NativeHandle selHyphenCharacterForGlyphAtIndex_XHandle = Selector.GetHandle ("hyphenCharacterForGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHyphenationFactorX = "hyphenationFactor";
		static readonly NativeHandle selHyphenationFactorXHandle = Selector.GetHandle ("hyphenationFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHyphenationFactorForGlyphAtIndex_X = "hyphenationFactorForGlyphAtIndex:";
		static readonly NativeHandle selHyphenationFactorForGlyphAtIndex_XHandle = Selector.GetHandle ("hyphenationFactorForGlyphAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertGlyph_AtGlyphIndex_CharacterIndex_X = "insertGlyph:atGlyphIndex:characterIndex:";
		static readonly NativeHandle selInsertGlyph_AtGlyphIndex_CharacterIndex_XHandle = Selector.GetHandle ("insertGlyph:atGlyphIndex:characterIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutCharactersInRange_ForLayoutManager_MaximumNumberOfLineFragments_X = "layoutCharactersInRange:forLayoutManager:maximumNumberOfLineFragments:";
		static readonly NativeHandle selLayoutCharactersInRange_ForLayoutManager_MaximumNumberOfLineFragments_XHandle = Selector.GetHandle ("layoutCharactersInRange:forLayoutManager:maximumNumberOfLineFragments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutGlyphsInLayoutManager_StartingAtGlyphIndex_MaxNumberOfLineFragments_NextGlyphIndex_X = "layoutGlyphsInLayoutManager:startingAtGlyphIndex:maxNumberOfLineFragments:nextGlyphIndex:";
		static readonly NativeHandle selLayoutGlyphsInLayoutManager_StartingAtGlyphIndex_MaxNumberOfLineFragments_NextGlyphIndex_XHandle = Selector.GetHandle ("layoutGlyphsInLayoutManager:startingAtGlyphIndex:maxNumberOfLineFragments:nextGlyphIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutManagerX = "layoutManager";
		static readonly NativeHandle selLayoutManagerXHandle = Selector.GetHandle ("layoutManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutParagraphAtPoint_X = "layoutParagraphAtPoint:";
		static readonly NativeHandle selLayoutParagraphAtPoint_XHandle = Selector.GetHandle ("layoutParagraphAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineFragmentPaddingX = "lineFragmentPadding";
		static readonly NativeHandle selLineFragmentPaddingXHandle = Selector.GetHandle ("lineFragmentPadding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_X = "lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:";
		static readonly NativeHandle selLineSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_XHandle = Selector.GetHandle ("lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphCharacterRangeX = "paragraphCharacterRange";
		static readonly NativeHandle selParagraphCharacterRangeXHandle = Selector.GetHandle ("paragraphCharacterRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphGlyphRangeX = "paragraphGlyphRange";
		static readonly NativeHandle selParagraphGlyphRangeXHandle = Selector.GetHandle ("paragraphGlyphRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphSeparatorCharacterRangeX = "paragraphSeparatorCharacterRange";
		static readonly NativeHandle selParagraphSeparatorCharacterRangeXHandle = Selector.GetHandle ("paragraphSeparatorCharacterRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphSeparatorGlyphRangeX = "paragraphSeparatorGlyphRange";
		static readonly NativeHandle selParagraphSeparatorGlyphRangeXHandle = Selector.GetHandle ("paragraphSeparatorGlyphRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_X = "paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:";
		static readonly NativeHandle selParagraphSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_XHandle = Selector.GetHandle ("paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphSpacingBeforeGlyphAtIndex_WithProposedLineFragmentRect_X = "paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:";
		static readonly NativeHandle selParagraphSpacingBeforeGlyphAtIndex_WithProposedLineFragmentRect_XHandle = Selector.GetHandle ("paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrintingAdjustmentInLayoutManager_ForNominallySpacedGlyphRange_PackedGlyphs_Count_X = "printingAdjustmentInLayoutManager:forNominallySpacedGlyphRange:packedGlyphs:count:";
		static readonly NativeHandle selPrintingAdjustmentInLayoutManager_ForNominallySpacedGlyphRange_PackedGlyphs_Count_XHandle = Selector.GetHandle ("printingAdjustmentInLayoutManager:forNominallySpacedGlyphRange:packedGlyphs:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttachmentSize_ForGlyphRange_X = "setAttachmentSize:forGlyphRange:";
		static readonly NativeHandle selSetAttachmentSize_ForGlyphRange_XHandle = Selector.GetHandle ("setAttachmentSize:forGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributedString_X = "setAttributedString:";
		static readonly NativeHandle selSetAttributedString_XHandle = Selector.GetHandle ("setAttributedString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBidiLevels_ForGlyphRange_X = "setBidiLevels:forGlyphRange:";
		static readonly NativeHandle selSetBidiLevels_ForGlyphRange_XHandle = Selector.GetHandle ("setBidiLevels:forGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBidiProcessingEnabled_X = "setBidiProcessingEnabled:";
		static readonly NativeHandle selSetBidiProcessingEnabled_XHandle = Selector.GetHandle ("setBidiProcessingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDrawsOutsideLineFragment_ForGlyphRange_X = "setDrawsOutsideLineFragment:forGlyphRange:";
		static readonly NativeHandle selSetDrawsOutsideLineFragment_ForGlyphRange_XHandle = Selector.GetHandle ("setDrawsOutsideLineFragment:forGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHardInvalidation_ForGlyphRange_X = "setHardInvalidation:forGlyphRange:";
		static readonly NativeHandle selSetHardInvalidation_ForGlyphRange_XHandle = Selector.GetHandle ("setHardInvalidation:forGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHyphenationFactor_X = "setHyphenationFactor:";
		static readonly NativeHandle selSetHyphenationFactor_XHandle = Selector.GetHandle ("setHyphenationFactor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineFragmentPadding_X = "setLineFragmentPadding:";
		static readonly NativeHandle selSetLineFragmentPadding_XHandle = Selector.GetHandle ("setLineFragmentPadding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_X = "setLineFragmentRect:forGlyphRange:usedRect:baselineOffset:";
		static readonly NativeHandle selSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_XHandle = Selector.GetHandle ("setLineFragmentRect:forGlyphRange:usedRect:baselineOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocation_WithAdvancements_ForStartOfGlyphRange_X = "setLocation:withAdvancements:forStartOfGlyphRange:";
		static readonly NativeHandle selSetLocation_WithAdvancements_ForStartOfGlyphRange_XHandle = Selector.GetHandle ("setLocation:withAdvancements:forStartOfGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNotShownAttribute_ForGlyphRange_X = "setNotShownAttribute:forGlyphRange:";
		static readonly NativeHandle selSetNotShownAttribute_ForGlyphRange_XHandle = Selector.GetHandle ("setNotShownAttribute:forGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParagraphGlyphRange_SeparatorGlyphRange_X = "setParagraphGlyphRange:separatorGlyphRange:";
		static readonly NativeHandle selSetParagraphGlyphRange_SeparatorGlyphRange_XHandle = Selector.GetHandle ("setParagraphGlyphRange:separatorGlyphRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTypesetterBehavior_X = "setTypesetterBehavior:";
		static readonly NativeHandle selSetTypesetterBehavior_XHandle = Selector.GetHandle ("setTypesetterBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesFontLeading_X = "setUsesFontLeading:";
		static readonly NativeHandle selSetUsesFontLeading_XHandle = Selector.GetHandle ("setUsesFontLeading:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedSystemTypesetterX = "sharedSystemTypesetter";
		static readonly NativeHandle selSharedSystemTypesetterXHandle = Selector.GetHandle ("sharedSystemTypesetter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedSystemTypesetterForBehavior_X = "sharedSystemTypesetterForBehavior:";
		static readonly NativeHandle selSharedSystemTypesetterForBehavior_XHandle = Selector.GetHandle ("sharedSystemTypesetterForBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldBreakLineByHyphenatingBeforeCharacterAtIndex_X = "shouldBreakLineByHyphenatingBeforeCharacterAtIndex:";
		static readonly NativeHandle selShouldBreakLineByHyphenatingBeforeCharacterAtIndex_XHandle = Selector.GetHandle ("shouldBreakLineByHyphenatingBeforeCharacterAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldBreakLineByWordBeforeCharacterAtIndex_X = "shouldBreakLineByWordBeforeCharacterAtIndex:";
		static readonly NativeHandle selShouldBreakLineByWordBeforeCharacterAtIndex_XHandle = Selector.GetHandle ("shouldBreakLineByWordBeforeCharacterAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubstituteFontForFont_X = "substituteFontForFont:";
		static readonly NativeHandle selSubstituteFontForFont_XHandle = Selector.GetHandle ("substituteFontForFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubstituteGlyphsInRange_WithGlyphs_X = "substituteGlyphsInRange:withGlyphs:";
		static readonly NativeHandle selSubstituteGlyphsInRange_WithGlyphs_XHandle = Selector.GetHandle ("substituteGlyphsInRange:withGlyphs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainersX = "textContainers";
		static readonly NativeHandle selTextContainersXHandle = Selector.GetHandle ("textContainers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextTabForGlyphLocation_WritingDirection_MaxLocation_X = "textTabForGlyphLocation:writingDirection:maxLocation:";
		static readonly NativeHandle selTextTabForGlyphLocation_WritingDirection_MaxLocation_XHandle = Selector.GetHandle ("textTabForGlyphLocation:writingDirection:maxLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypesetterBehaviorX = "typesetterBehavior";
		static readonly NativeHandle selTypesetterBehaviorXHandle = Selector.GetHandle ("typesetterBehavior");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesFontLeadingX = "usesFontLeading";
		static readonly NativeHandle selUsesFontLeadingXHandle = Selector.GetHandle ("usesFontLeading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_X = "willSetLineFragmentRect:forGlyphRange:usedRect:baselineOffset:";
		static readonly NativeHandle selWillSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_XHandle = Selector.GetHandle ("willSetLineFragmentRect:forGlyphRange:usedRect:baselineOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTypesetter");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSTypesetter" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTypesetter () : base (NSObjectFlag.Empty)
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
		protected NSTypesetter (NSObjectFlag t) : base (t)
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
		protected internal NSTypesetter (NativeHandle handle) : base (handle)
		{
		}

		[Export ("attributesForExtraLineFragment")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary AttributesForExtraLineFragment ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributesForExtraLineFragmentXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributesForExtraLineFragmentXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("beginLineWithGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginLine (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selBeginLineWithGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selBeginLineWithGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("beginParagraph")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginParagraph ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selBeginParagraphXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selBeginParagraphXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("deleteGlyphsInRange:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteGlyphs (NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selDeleteGlyphsInRange_XHandle, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selDeleteGlyphsInRange_XHandle, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("endLineWithGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndLine (NSRange lineGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selEndLineWithGlyphRange_XHandle, lineGlyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selEndLineWithGlyphRange_XHandle, lineGlyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("endParagraph")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndParagraph ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEndParagraphXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selEndParagraphXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("actionForControlCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTypesetterControlCharacterAction GetActionForControlCharacter (nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTypesetterControlCharacterAction ret;
			if (IsDirectBinding) {
				ret = (NSTypesetterControlCharacterAction) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selActionForControlCharacterAtIndex_XHandle, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSTypesetterControlCharacterAction) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selActionForControlCharacterAtIndex_XHandle, charIndex);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("baselineOffsetInLayoutManager:glyphIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetBaselineOffset (NSLayoutManager layoutManager, nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selBaselineOffsetInLayoutManager_GlyphIndex_XHandle, layoutManager__handle__, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selBaselineOffsetInLayoutManager_GlyphIndex_XHandle, layoutManager__handle__, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		[Export ("boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundingBoxForControlGlyph (nuint glyphIndex, NSTextContainer textContainer, CGRect proposedLineFragment, CGPoint glyphPosition, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_NativeHandle_CGRect_CGPoint_UIntPtr (this.Handle, selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle, glyphIndex, textContainer__handle__, proposedLineFragment, glyphPosition, charIndex);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_NativeHandle_CGRect_CGPoint_UIntPtr (this.Handle, selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle, glyphIndex, textContainer__handle__, proposedLineFragment, glyphPosition, charIndex);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr_NativeHandle_CGRect_CGPoint_UIntPtr (&__objc_super__, selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle, glyphIndex, textContainer__handle__, proposedLineFragment, glyphPosition, charIndex);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr_NativeHandle_CGRect_CGPoint_UIntPtr (&__objc_super__, selBoundingBoxForControlGlyphAtIndex_ForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_XHandle, glyphIndex, textContainer__handle__, proposedLineFragment, glyphPosition, charIndex);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[Export ("characterRangeForGlyphRange:actualGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSRange GetCharacterRangeForGlyphRange (NSRange glyphRange, out NSRange actualGlyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualGlyphRange__pointer = &actualGlyphRange) {
			actualGlyphRange = default;
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_out_NSRange (this.Handle, selCharacterRangeForGlyphRange_ActualGlyphRange_XHandle, glyphRange, actualGlyphRange__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange_out_NSRange (&__objc_super__, selCharacterRangeForGlyphRange_ActualGlyphRange_XHandle, glyphRange, actualGlyphRange__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		[Export ("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetGlyphsInRange (NSRange glyphsRange, nint glyphBuffer, nint charIndexBuffer, nint inscribeBuffer, nint elasticBuffer, nint bidiLevelBuffer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selGetGlyphsInRange_Glyphs_CharacterIndexes_GlyphInscriptions_ElasticBits_BidiLevels_XHandle, glyphsRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer, bidiLevelBuffer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (&__objc_super__, selGetGlyphsInRange_Glyphs_CharacterIndexes_GlyphInscriptions_ElasticBits_BidiLevels_XHandle, glyphsRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer, bidiLevelBuffer);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("printingAdjustmentInLayoutManager:forNominallySpacedGlyphRange:packedGlyphs:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize GetInterGlyphSpacing (NSLayoutManager layoutManager, NSRange nominallySpacedGlyphsRange, nint packedGlyphs, nuint packedGlyphsCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle_NSRange_IntPtr_UIntPtr (class_ptr, selPrintingAdjustmentInLayoutManager_ForNominallySpacedGlyphRange_PackedGlyphs_Count_XHandle, layoutManager__handle__, nominallySpacedGlyphsRange, packedGlyphs, packedGlyphsCount);
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		[Export ("getLineFragmentRect:usedRect:forParagraphSeparatorGlyphRange:atProposedOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetLineFragment (out CGRect lineFragmentRect, out CGRect lineFragmentUsedRect, NSRange paragraphSeparatorGlyphRange, CGPoint proposedOrigin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (CGRect* lineFragmentRect__pointer = &lineFragmentRect) {
			fixed (CGRect* lineFragmentUsedRect__pointer = &lineFragmentUsedRect) {
			lineFragmentRect = default;
			lineFragmentUsedRect = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_CGRect_out_CGRect_NSRange_CGPoint (this.Handle, selGetLineFragmentRect_UsedRect_ForParagraphSeparatorGlyphRange_AtProposedOrigin_XHandle, lineFragmentRect__pointer, lineFragmentUsedRect__pointer, paragraphSeparatorGlyphRange, proposedOrigin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_CGRect_out_CGRect_NSRange_CGPoint (&__objc_super__, selGetLineFragmentRect_UsedRect_ForParagraphSeparatorGlyphRange_AtProposedOrigin_XHandle, lineFragmentRect__pointer, lineFragmentUsedRect__pointer, paragraphSeparatorGlyphRange, proposedOrigin);
					GC.KeepAlive (this);
				}
			}
			}
			}
		}
		[Export ("getLineFragmentRect:usedRect:remainingRect:forStartingGlyphAtIndex:proposedRect:lineSpacing:paragraphSpacingBefore:paragraphSpacingAfter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetLineFragment (out CGRect lineFragment, out CGRect lineFragmentUsed, out CGRect remaining, nuint startingGlyphIndex, CGRect proposedRect, nfloat lineSpacing, nfloat paragraphSpacingBefore, nfloat paragraphSpacingAfter)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (CGRect* lineFragment__pointer = &lineFragment) {
			fixed (CGRect* lineFragmentUsed__pointer = &lineFragmentUsed) {
			fixed (CGRect* remaining__pointer = &remaining) {
			lineFragment = default;
			lineFragmentUsed = default;
			remaining = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_CGRect_out_CGRect_out_CGRect_UIntPtr_CGRect_nfloat_nfloat_nfloat (this.Handle, selGetLineFragmentRect_UsedRect_RemainingRect_ForStartingGlyphAtIndex_ProposedRect_LineSpacing_ParagraphSpacingBefore_ParagraphSpacingAfter_XHandle, lineFragment__pointer, lineFragmentUsed__pointer, remaining__pointer, startingGlyphIndex, proposedRect, lineSpacing, paragraphSpacingBefore, paragraphSpacingAfter);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_CGRect_out_CGRect_out_CGRect_UIntPtr_CGRect_nfloat_nfloat_nfloat (&__objc_super__, selGetLineFragmentRect_UsedRect_RemainingRect_ForStartingGlyphAtIndex_ProposedRect_LineSpacing_ParagraphSpacingBefore_ParagraphSpacingAfter_XHandle, lineFragment__pointer, lineFragmentUsed__pointer, remaining__pointer, startingGlyphIndex, proposedRect, lineSpacing, paragraphSpacingBefore, paragraphSpacingAfter);
					GC.KeepAlive (this);
				}
			}
			}
			}
			}
		}
		[Export ("lineSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetLineSpacingAfterGlyph (nuint glyphIndex, CGRect proposedLineFragmentRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr_CGRect (this.Handle, selLineSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_XHandle, glyphIndex, proposedLineFragmentRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_UIntPtr_CGRect (&__objc_super__, selLineSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_XHandle, glyphIndex, proposedLineFragmentRect);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("paragraphSpacingAfterGlyphAtIndex:withProposedLineFragmentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetParagraphSpacingAfterGlyph (nuint glyphIndex, CGRect proposedLineFragmentRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr_CGRect (this.Handle, selParagraphSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_XHandle, glyphIndex, proposedLineFragmentRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_UIntPtr_CGRect (&__objc_super__, selParagraphSpacingAfterGlyphAtIndex_WithProposedLineFragmentRect_XHandle, glyphIndex, proposedLineFragmentRect);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("paragraphSpacingBeforeGlyphAtIndex:withProposedLineFragmentRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetParagraphSpacingBeforeGlyph (nuint glyphIndex, CGRect proposedLineFragmentRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr_CGRect (this.Handle, selParagraphSpacingBeforeGlyphAtIndex_WithProposedLineFragmentRect_XHandle, glyphIndex, proposedLineFragmentRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_UIntPtr_CGRect (&__objc_super__, selParagraphSpacingBeforeGlyphAtIndex_WithProposedLineFragmentRect_XHandle, glyphIndex, proposedLineFragmentRect);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sharedSystemTypesetterForBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTypesetter GetSharedSystemTypesetter (NSTypesetterBehavior forBehavior)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTypesetter ret;
			ret =  Runtime.GetNSObject<NSTypesetter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selSharedSystemTypesetterForBehavior_XHandle, (IntPtr) (long) forBehavior), false)!;
			return ret;
		}
		[Export ("substituteFontForFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont GetSubstituteFont (NSFont originalFont)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var originalFont__handle__ = originalFont!.GetNonNullHandle (nameof (originalFont));
			NSFont? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSubstituteFontForFont_XHandle, originalFont__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSubstituteFontForFont_XHandle, originalFont__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (originalFont);
			return ret!;
		}
		[Export ("textTabForGlyphLocation:writingDirection:maxLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextTab GetTextTab (nfloat glyphLocation, NSWritingDirection direction, nfloat maxLocation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextTab ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextTab> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_IntPtr_nfloat (this.Handle, selTextTabForGlyphLocation_WritingDirection_MaxLocation_XHandle, glyphLocation, (IntPtr) (long) direction, maxLocation), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextTab> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_IntPtr_nfloat (&__objc_super__, selTextTabForGlyphLocation_WritingDirection_MaxLocation_XHandle, glyphLocation, (IntPtr) (long) direction, maxLocation), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("glyphRangeForCharacterRange:actualCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSRange GlyphRangeForCharacterRange (NSRange charRange, out NSRange actualCharRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualCharRange__pointer = &actualCharRange) {
			actualCharRange = default;
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_out_NSRange (this.Handle, selGlyphRangeForCharacterRange_ActualCharacterRange_XHandle, charRange, actualCharRange__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange_out_NSRange (&__objc_super__, selGlyphRangeForCharacterRange_ActualCharacterRange_XHandle, charRange, actualCharRange__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		[Export ("hyphenCharacterForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint HyphenCharacterForGlyph (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			uint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend_UIntPtr (this.Handle, selHyphenCharacterForGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_UIntPtr (&__objc_super__, selHyphenCharacterForGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("hyphenationFactorForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float HyphenationFactorForGlyph (nuint glyphIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_UIntPtr (this.Handle, selHyphenationFactorForGlyphAtIndex_XHandle, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_UIntPtr (&__objc_super__, selHyphenationFactorForGlyphAtIndex_XHandle, glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("insertGlyph:atGlyphIndex:characterIndex:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertGlyph (uint glyph, nuint glyphIndex, nuint characterIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32_UIntPtr_UIntPtr (this.Handle, selInsertGlyph_AtGlyphIndex_CharacterIndex_XHandle, glyph, glyphIndex, characterIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32_UIntPtr_UIntPtr (&__objc_super__, selInsertGlyph_AtGlyphIndex_CharacterIndex_XHandle, glyph, glyphIndex, characterIndex);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("layoutCharactersInRange:forLayoutManager:maximumNumberOfLineFragments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange LayoutCharacters (NSRange characterRange, NSLayoutManager layoutManager, nuint maxLineFragments)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_NativeHandle_UIntPtr (this.Handle, selLayoutCharactersInRange_ForLayoutManager_MaximumNumberOfLineFragments_XHandle, characterRange, layoutManager__handle__, maxLineFragments);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange_NativeHandle_UIntPtr (&__objc_super__, selLayoutCharactersInRange_ForLayoutManager_MaximumNumberOfLineFragments_XHandle, characterRange, layoutManager__handle__, maxLineFragments);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layoutManager);
			return ret!;
		}
		[Export ("layoutGlyphsInLayoutManager:startingAtGlyphIndex:maxNumberOfLineFragments:nextGlyphIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LayoutGlyphs (NSLayoutManager layoutManager, nuint startGlyphIndex, nuint maxLineFragments, out nuint nextGlyph)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutManager__handle__ = layoutManager!.GetNonNullHandle (nameof (layoutManager));
			fixed (nuint* nextGlyph__pointer = &nextGlyph) {
			nextGlyph = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_out_UIntPtr (this.Handle, selLayoutGlyphsInLayoutManager_StartingAtGlyphIndex_MaxNumberOfLineFragments_NextGlyphIndex_XHandle, layoutManager__handle__, startGlyphIndex, maxLineFragments, nextGlyph__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_out_UIntPtr (&__objc_super__, selLayoutGlyphsInLayoutManager_StartingAtGlyphIndex_MaxNumberOfLineFragments_NextGlyphIndex_XHandle, layoutManager__handle__, startGlyphIndex, maxLineFragments, nextGlyph__pointer);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layoutManager);
			}
		}
		[Export ("layoutParagraphAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual nuint LayoutParagraphAtPoint (ref CGPoint lineFragmentOrigin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (CGPoint* lineFragmentOrigin__pointer = &lineFragmentOrigin) {
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_ref_CGPoint (this.Handle, selLayoutParagraphAtPoint_XHandle, lineFragmentOrigin__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_ref_CGPoint (&__objc_super__, selLayoutParagraphAtPoint_XHandle, lineFragmentOrigin__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
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
		[Export ("setBidiLevels:forGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBidiLevels (nint levels, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (this.Handle, selSetBidiLevels_ForGlyphRange_XHandle, levels, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NSRange (&__objc_super__, selSetBidiLevels_ForGlyphRange_XHandle, levels, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setDrawsOutsideLineFragment:forGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDrawsOutsideLineFragment (bool flag, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NSRange (this.Handle, selSetDrawsOutsideLineFragment_ForGlyphRange_XHandle, flag ? (byte) 1 : (byte) 0, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NSRange (&__objc_super__, selSetDrawsOutsideLineFragment_ForGlyphRange_XHandle, flag ? (byte) 1 : (byte) 0, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setHardInvalidation:forGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetHardInvalidation (bool value, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NSRange (this.Handle, selSetHardInvalidation_ForGlyphRange_XHandle, value ? (byte) 1 : (byte) 0, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NSRange (&__objc_super__, selSetHardInvalidation_ForGlyphRange_XHandle, value ? (byte) 1 : (byte) 0, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setLineFragmentRect:forGlyphRange:usedRect:baselineOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLineFragment (CGRect fragmentRect, NSRange glyphRange, CGRect usedRect, nfloat baselineOffset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NSRange_CGRect_nfloat (this.Handle, selSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_XHandle, fragmentRect, glyphRange, usedRect, baselineOffset);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NSRange_CGRect_nfloat (&__objc_super__, selSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_XHandle, fragmentRect, glyphRange, usedRect, baselineOffset);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setLocation:withAdvancements:forStartOfGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLocation (CGPoint location, nint advancements, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_IntPtr_NSRange (this.Handle, selSetLocation_WithAdvancements_ForStartOfGlyphRange_XHandle, location, advancements, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_IntPtr_NSRange (&__objc_super__, selSetLocation_WithAdvancements_ForStartOfGlyphRange_XHandle, location, advancements, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNotShownAttribute:forGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNotShownAttribute (bool flag, NSRange glyphRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NSRange (this.Handle, selSetNotShownAttribute_ForGlyphRange_XHandle, flag ? (byte) 1 : (byte) 0, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NSRange (&__objc_super__, selSetNotShownAttribute_ForGlyphRange_XHandle, flag ? (byte) 1 : (byte) 0, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setParagraphGlyphRange:separatorGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetParagraphGlyphRange (NSRange paragraphRange, NSRange paragraphSeparatorRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NSRange (this.Handle, selSetParagraphGlyphRange_SeparatorGlyphRange_XHandle, paragraphRange, paragraphSeparatorRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_NSRange (&__objc_super__, selSetParagraphGlyphRange_SeparatorGlyphRange_XHandle, paragraphRange, paragraphSeparatorRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("shouldBreakLineByHyphenatingBeforeCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBreakLineByHyphenatingBeforeCharacter (nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, selShouldBreakLineByHyphenatingBeforeCharacterAtIndex_XHandle, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, selShouldBreakLineByHyphenatingBeforeCharacterAtIndex_XHandle, charIndex);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("shouldBreakLineByWordBeforeCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBreakLineByWordBeforeCharacter (nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, selShouldBreakLineByWordBeforeCharacterAtIndex_XHandle, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, selShouldBreakLineByWordBeforeCharacterAtIndex_XHandle, charIndex);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("substituteGlyphsInRange:withGlyphs:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SubstituteGlyphs (NSRange glyphRange, nint glyphs)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr (this.Handle, selSubstituteGlyphsInRange_WithGlyphs_XHandle, glyphRange, glyphs);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr (&__objc_super__, selSubstituteGlyphsInRange_WithGlyphs_XHandle, glyphRange, glyphs);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("willSetLineFragmentRect:forGlyphRange:usedRect:baselineOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WillSetLineFragment (ref CGRect lineRect, NSRange glyphRange, ref CGRect usedRect, ref nfloat baselineOffset)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (CGRect* lineRect__pointer = &lineRect) {
			fixed (CGRect* usedRect__pointer = &usedRect) {
			fixed (nfloat* baselineOffset__pointer = &baselineOffset) {
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_ref_CGRect_NSRange_ref_CGRect_ref_NFloat (this.Handle, selWillSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_XHandle, lineRect__pointer, glyphRange, usedRect__pointer, baselineOffset__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_ref_CGRect_NSRange_ref_CGRect_ref_NFloat (&__objc_super__, selWillSetLineFragmentRect_ForGlyphRange_UsedRect_BaselineOffset_XHandle, lineRect__pointer, glyphRange, usedRect__pointer, baselineOffset__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString AttributedString {
			[Export ("attributedString")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributedStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributedStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributedString:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAttributedString_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttributedString_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BidiProcessingEnabled {
			[Export ("bidiProcessingEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBidiProcessingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selBidiProcessingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBidiProcessingEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBidiProcessingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetBidiProcessingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSParagraphStyle CurrentParagraphStyle {
			[Export ("currentParagraphStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSParagraphStyle? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSParagraphStyle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentParagraphStyleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSParagraphStyle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentParagraphStyleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContainer CurrentTextContainer {
			[Export ("currentTextContainer")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentTextContainerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentTextContainerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTypesetterBehavior DefaultTypesetterBehavior {
			[Export ("defaultTypesetterBehavior")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTypesetterBehavior ret;
				ret = (NSTypesetterBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDefaultTypesetterBehaviorXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutManager LayoutManager {
			[Export ("layoutManager")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSLayoutManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLayoutManagerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLayoutManagerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LineFragmentPadding {
			[Export ("lineFragmentPadding")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selLineFragmentPaddingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selLineFragmentPaddingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLineFragmentPadding:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetLineFragmentPadding_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetLineFragmentPadding_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange ParagraphCharacterRange {
			[Export ("paragraphCharacterRange")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selParagraphCharacterRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selParagraphCharacterRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange ParagraphGlyphRange {
			[Export ("paragraphGlyphRange")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selParagraphGlyphRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selParagraphGlyphRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange ParagraphSeparatorCharacterRange {
			[Export ("paragraphSeparatorCharacterRange")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selParagraphSeparatorCharacterRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selParagraphSeparatorCharacterRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange ParagraphSeparatorGlyphRange {
			[Export ("paragraphSeparatorGlyphRange")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selParagraphSeparatorGlyphRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selParagraphSeparatorGlyphRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTypesetter SharedSystemTypesetter {
			[Export ("sharedSystemTypesetter")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTypesetter? ret;
				ret =  Runtime.GetNSObject<NSTypesetter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedSystemTypesetterXHandle), false)!;
				return ret!;
			}
		}
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
	} /* class NSTypesetter */
}
