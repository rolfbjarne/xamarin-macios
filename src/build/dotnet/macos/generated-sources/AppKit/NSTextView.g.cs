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
	[Register("NSTextView", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSTextView : NSText, INSAccessibilityElementProtocol, INSAccessibilityNavigableStaticText, INSAccessibilityStaticText, INSCandidateListTouchBarItemDelegate, INSColorChanging, INSDraggingSource, INSMenuItemValidation, INSTextContent, INSTextInput, INSTextInputClient, INSTextLayoutOrientationProvider, INSTouchBarDelegate, INSUserInterfaceValidations {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcceptableDragTypesX = "acceptableDragTypes";
		static readonly NativeHandle selAcceptableDragTypesXHandle = Selector.GetHandle ("acceptableDragTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcceptsGlyphInfoX = "acceptsGlyphInfo";
		static readonly NativeHandle selAcceptsGlyphInfoXHandle = Selector.GetHandle ("acceptsGlyphInfo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityAttributedStringForRange_X = "accessibilityAttributedStringForRange:";
		static readonly NativeHandle selAccessibilityAttributedStringForRange_XHandle = Selector.GetHandle ("accessibilityAttributedStringForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFrameX = "accessibilityFrame";
		static readonly NativeHandle selAccessibilityFrameXHandle = Selector.GetHandle ("accessibilityFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFrameForRange_X = "accessibilityFrameForRange:";
		static readonly NativeHandle selAccessibilityFrameForRange_XHandle = Selector.GetHandle ("accessibilityFrameForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIdentifierX = "accessibilityIdentifier";
		static readonly NativeHandle selAccessibilityIdentifierXHandle = Selector.GetHandle ("accessibilityIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLineForIndex_X = "accessibilityLineForIndex:";
		static readonly NativeHandle selAccessibilityLineForIndex_XHandle = Selector.GetHandle ("accessibilityLineForIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityParentX = "accessibilityParent";
		static readonly NativeHandle selAccessibilityParentXHandle = Selector.GetHandle ("accessibilityParent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRangeForLine_X = "accessibilityRangeForLine:";
		static readonly NativeHandle selAccessibilityRangeForLine_XHandle = Selector.GetHandle ("accessibilityRangeForLine:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityStringForRange_X = "accessibilityStringForRange:";
		static readonly NativeHandle selAccessibilityStringForRange_XHandle = Selector.GetHandle ("accessibilityStringForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityValueX = "accessibilityValue";
		static readonly NativeHandle selAccessibilityValueXHandle = Selector.GetHandle ("accessibilityValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleCharacterRangeX = "accessibilityVisibleCharacterRange";
		static readonly NativeHandle selAccessibilityVisibleCharacterRangeXHandle = Selector.GetHandle ("accessibilityVisibleCharacterRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignJustified_X = "alignJustified:";
		static readonly NativeHandle selAlignJustified_XHandle = Selector.GetHandle ("alignJustified:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowedInputSourceLocalesX = "allowedInputSourceLocales";
		static readonly NativeHandle selAllowedInputSourceLocalesXHandle = Selector.GetHandle ("allowedInputSourceLocales");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowedWritingToolsResultOptionsX = "allowedWritingToolsResultOptions";
		static readonly NativeHandle selAllowedWritingToolsResultOptionsXHandle = Selector.GetHandle ("allowedWritingToolsResultOptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsCharacterPickerTouchBarItemX = "allowsCharacterPickerTouchBarItem";
		static readonly NativeHandle selAllowsCharacterPickerTouchBarItemXHandle = Selector.GetHandle ("allowsCharacterPickerTouchBarItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsDocumentBackgroundColorChangeX = "allowsDocumentBackgroundColorChange";
		static readonly NativeHandle selAllowsDocumentBackgroundColorChangeXHandle = Selector.GetHandle ("allowsDocumentBackgroundColorChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsImageEditingX = "allowsImageEditing";
		static readonly NativeHandle selAllowsImageEditingXHandle = Selector.GetHandle ("allowsImageEditing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsUndoX = "allowsUndo";
		static readonly NativeHandle selAllowsUndoXHandle = Selector.GetHandle ("allowsUndo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringX = "attributedString";
		static readonly NativeHandle selAttributedStringXHandle = Selector.GetHandle ("attributedString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedSubstringForProposedRange_ActualRange_X = "attributedSubstringForProposedRange:actualRange:";
		static readonly NativeHandle selAttributedSubstringForProposedRange_ActualRange_XHandle = Selector.GetHandle ("attributedSubstringForProposedRange:actualRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedSubstringFromRange_X = "attributedSubstringFromRange:";
		static readonly NativeHandle selAttributedSubstringFromRange_XHandle = Selector.GetHandle ("attributedSubstringFromRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundColorX = "backgroundColor";
		static readonly NativeHandle selBackgroundColorXHandle = Selector.GetHandle ("backgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaselineDeltaForCharacterAtIndex_X = "baselineDeltaForCharacterAtIndex:";
		static readonly NativeHandle selBaselineDeltaForCharacterAtIndex_XHandle = Selector.GetHandle ("baselineDeltaForCharacterAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBreakUndoCoalescingX = "breakUndoCoalescing";
		static readonly NativeHandle selBreakUndoCoalescingXHandle = Selector.GetHandle ("breakUndoCoalescing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCandidateListTouchBarItemX = "candidateListTouchBarItem";
		static readonly NativeHandle selCandidateListTouchBarItemXHandle = Selector.GetHandle ("candidateListTouchBarItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCandidateListTouchBarItem_BeginSelectingCandidateAtIndex_X = "candidateListTouchBarItem:beginSelectingCandidateAtIndex:";
		static readonly NativeHandle selCandidateListTouchBarItem_BeginSelectingCandidateAtIndex_XHandle = Selector.GetHandle ("candidateListTouchBarItem:beginSelectingCandidateAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCandidateListTouchBarItem_ChangeSelectionFromCandidateAtIndex_ToIndex_X = "candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:";
		static readonly NativeHandle selCandidateListTouchBarItem_ChangeSelectionFromCandidateAtIndex_ToIndex_XHandle = Selector.GetHandle ("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCandidateListTouchBarItem_ChangedCandidateListVisibility_X = "candidateListTouchBarItem:changedCandidateListVisibility:";
		static readonly NativeHandle selCandidateListTouchBarItem_ChangedCandidateListVisibility_XHandle = Selector.GetHandle ("candidateListTouchBarItem:changedCandidateListVisibility:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCandidateListTouchBarItem_EndSelectingCandidateAtIndex_X = "candidateListTouchBarItem:endSelectingCandidateAtIndex:";
		static readonly NativeHandle selCandidateListTouchBarItem_EndSelectingCandidateAtIndex_XHandle = Selector.GetHandle ("candidateListTouchBarItem:endSelectingCandidateAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeAttributes_X = "changeAttributes:";
		static readonly NativeHandle selChangeAttributes_XHandle = Selector.GetHandle ("changeAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeColor_X = "changeColor:";
		static readonly NativeHandle selChangeColor_XHandle = Selector.GetHandle ("changeColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeDocumentBackgroundColor_X = "changeDocumentBackgroundColor:";
		static readonly NativeHandle selChangeDocumentBackgroundColor_XHandle = Selector.GetHandle ("changeDocumentBackgroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangeLayoutOrientation_X = "changeLayoutOrientation:";
		static readonly NativeHandle selChangeLayoutOrientation_XHandle = Selector.GetHandle ("changeLayoutOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterIndexForInsertionAtPoint_X = "characterIndexForInsertionAtPoint:";
		static readonly NativeHandle selCharacterIndexForInsertionAtPoint_XHandle = Selector.GetHandle ("characterIndexForInsertionAtPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterIndexForPoint_X = "characterIndexForPoint:";
		static readonly NativeHandle selCharacterIndexForPoint_XHandle = Selector.GetHandle ("characterIndexForPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckTextInDocument_X = "checkTextInDocument:";
		static readonly NativeHandle selCheckTextInDocument_XHandle = Selector.GetHandle ("checkTextInDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckTextInRange_Types_Options_X = "checkTextInRange:types:options:";
		static readonly NativeHandle selCheckTextInRange_Types_Options_XHandle = Selector.GetHandle ("checkTextInRange:types:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckTextInSelection_X = "checkTextInSelection:";
		static readonly NativeHandle selCheckTextInSelection_XHandle = Selector.GetHandle ("checkTextInSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCleanUpAfterDragOperationX = "cleanUpAfterDragOperation";
		static readonly NativeHandle selCleanUpAfterDragOperationXHandle = Selector.GetHandle ("cleanUpAfterDragOperation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClickedOnLink_AtIndex_X = "clickedOnLink:atIndex:";
		static readonly NativeHandle selClickedOnLink_AtIndex_XHandle = Selector.GetHandle ("clickedOnLink:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComplete_X = "complete:";
		static readonly NativeHandle selComplete_XHandle = Selector.GetHandle ("complete:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompletionsForPartialWordRange_IndexOfSelectedItem_X = "completionsForPartialWordRange:indexOfSelectedItem:";
		static readonly NativeHandle selCompletionsForPartialWordRange_IndexOfSelectedItem_XHandle = Selector.GetHandle ("completionsForPartialWordRange:indexOfSelectedItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentTypeX = "contentType";
		static readonly NativeHandle selContentTypeXHandle = Selector.GetHandle ("contentType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConversationIdentifierX = "conversationIdentifier";
		static readonly NativeHandle selConversationIdentifierXHandle = Selector.GetHandle ("conversationIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultParagraphStyleX = "defaultParagraphStyle";
		static readonly NativeHandle selDefaultParagraphStyleXHandle = Selector.GetHandle ("defaultParagraphStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChangeTextX = "didChangeText";
		static readonly NativeHandle selDidChangeTextXHandle = Selector.GetHandle ("didChangeText");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplaysLinkToolTipsX = "displaysLinkToolTips";
		static readonly NativeHandle selDisplaysLinkToolTipsXHandle = Selector.GetHandle ("displaysLinkToolTips");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentVisibleRectX = "documentVisibleRect";
		static readonly NativeHandle selDocumentVisibleRectXHandle = Selector.GetHandle ("documentVisibleRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDragImageForSelectionWithEvent_Origin_X = "dragImageForSelectionWithEvent:origin:";
		static readonly NativeHandle selDragImageForSelectionWithEvent_Origin_XHandle = Selector.GetHandle ("dragImageForSelectionWithEvent:origin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDragOperationForDraggingInfo_Type_X = "dragOperationForDraggingInfo:type:";
		static readonly NativeHandle selDragOperationForDraggingInfo_Type_XHandle = Selector.GetHandle ("dragOperationForDraggingInfo:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDragSelectionWithEvent_Offset_SlideBack_X = "dragSelectionWithEvent:offset:slideBack:";
		static readonly NativeHandle selDragSelectionWithEvent_Offset_SlideBack_XHandle = Selector.GetHandle ("dragSelectionWithEvent:offset:slideBack:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_BeganAt_X = "draggedImage:beganAt:";
		static readonly NativeHandle selDraggedImage_BeganAt_XHandle = Selector.GetHandle ("draggedImage:beganAt:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_EndedAt_Deposited_X = "draggedImage:endedAt:deposited:";
		static readonly NativeHandle selDraggedImage_EndedAt_Deposited_XHandle = Selector.GetHandle ("draggedImage:endedAt:deposited:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_EndedAt_Operation_X = "draggedImage:endedAt:operation:";
		static readonly NativeHandle selDraggedImage_EndedAt_Operation_XHandle = Selector.GetHandle ("draggedImage:endedAt:operation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggedImage_MovedTo_X = "draggedImage:movedTo:";
		static readonly NativeHandle selDraggedImage_MovedTo_XHandle = Selector.GetHandle ("draggedImage:movedTo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingSourceOperationMaskForLocal_X = "draggingSourceOperationMaskForLocal:";
		static readonly NativeHandle selDraggingSourceOperationMaskForLocal_XHandle = Selector.GetHandle ("draggingSourceOperationMaskForLocal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInsertionPointInRect_Color_TurnedOn_X = "drawInsertionPointInRect:color:turnedOn:";
		static readonly NativeHandle selDrawInsertionPointInRect_Color_TurnedOn_XHandle = Selector.GetHandle ("drawInsertionPointInRect:color:turnedOn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawTextHighlightBackgroundForTextRange_Origin_X = "drawTextHighlightBackgroundForTextRange:origin:";
		static readonly NativeHandle selDrawTextHighlightBackgroundForTextRange_Origin_XHandle = Selector.GetHandle ("drawTextHighlightBackgroundForTextRange:origin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawViewBackgroundInRect_X = "drawViewBackgroundInRect:";
		static readonly NativeHandle selDrawViewBackgroundInRect_XHandle = Selector.GetHandle ("drawViewBackgroundInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawsBackgroundX = "drawsBackground";
		static readonly NativeHandle selDrawsBackgroundXHandle = Selector.GetHandle ("drawsBackground");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawsVerticallyForCharacterAtIndex_X = "drawsVerticallyForCharacterAtIndex:";
		static readonly NativeHandle selDrawsVerticallyForCharacterAtIndex_XHandle = Selector.GetHandle ("drawsVerticallyForCharacterAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnabledTextCheckingTypesX = "enabledTextCheckingTypes";
		static readonly NativeHandle selEnabledTextCheckingTypesXHandle = Selector.GetHandle ("enabledTextCheckingTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFieldEditorX = "fieldEditor";
		static readonly NativeHandle selFieldEditorXHandle = Selector.GetHandle ("fieldEditor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstRectForCharacterRange_X = "firstRectForCharacterRange:";
		static readonly NativeHandle selFirstRectForCharacterRange_XHandle = Selector.GetHandle ("firstRectForCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstRectForCharacterRange_ActualRange_X = "firstRectForCharacterRange:actualRange:";
		static readonly NativeHandle selFirstRectForCharacterRange_ActualRange_XHandle = Selector.GetHandle ("firstRectForCharacterRange:actualRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFractionOfDistanceThroughGlyphForPoint_X = "fractionOfDistanceThroughGlyphForPoint:";
		static readonly NativeHandle selFractionOfDistanceThroughGlyphForPoint_XHandle = Selector.GetHandle ("fractionOfDistanceThroughGlyphForPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHandleTextCheckingResults_ForRange_Types_Options_Orthography_WordCount_X = "handleTextCheckingResults:forRange:types:options:orthography:wordCount:";
		static readonly NativeHandle selHandleTextCheckingResults_ForRange_Types_Options_Orthography_WordCount_XHandle = Selector.GetHandle ("handleTextCheckingResults:forRange:types:options:orthography:wordCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasMarkedTextX = "hasMarkedText";
		static readonly NativeHandle selHasMarkedTextXHandle = Selector.GetHandle ("hasMarkedText");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlight_X = "highlight:";
		static readonly NativeHandle selHighlight_XHandle = Selector.GetHandle ("highlight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIgnoreModifierKeysWhileDraggingX = "ignoreModifierKeysWhileDragging";
		static readonly NativeHandle selIgnoreModifierKeysWhileDraggingXHandle = Selector.GetHandle ("ignoreModifierKeysWhileDragging");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImportsGraphicsX = "importsGraphics";
		static readonly NativeHandle selImportsGraphicsXHandle = Selector.GetHandle ("importsGraphics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitUsingTextLayoutManager_X = "initUsingTextLayoutManager:";
		static readonly NativeHandle selInitUsingTextLayoutManager_XHandle = Selector.GetHandle ("initUsingTextLayoutManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_TextContainer_X = "initWithFrame:textContainer:";
		static readonly NativeHandle selInitWithFrame_TextContainer_XHandle = Selector.GetHandle ("initWithFrame:textContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInlinePredictionTypeX = "inlinePredictionType";
		static readonly NativeHandle selInlinePredictionTypeXHandle = Selector.GetHandle ("inlinePredictionType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertAdaptiveImageGlyph_ReplacementRange_X = "insertAdaptiveImageGlyph:replacementRange:";
		static readonly NativeHandle selInsertAdaptiveImageGlyph_ReplacementRange_XHandle = Selector.GetHandle ("insertAdaptiveImageGlyph:replacementRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertCompletion_ForPartialWordRange_Movement_IsFinal_X = "insertCompletion:forPartialWordRange:movement:isFinal:";
		static readonly NativeHandle selInsertCompletion_ForPartialWordRange_Movement_IsFinal_XHandle = Selector.GetHandle ("insertCompletion:forPartialWordRange:movement:isFinal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertText_X = "insertText:";
		static readonly NativeHandle selInsertText_XHandle = Selector.GetHandle ("insertText:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertText_ReplacementRange_X = "insertText:replacementRange:";
		static readonly NativeHandle selInsertText_ReplacementRange_XHandle = Selector.GetHandle ("insertText:replacementRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertionPointColorX = "insertionPointColor";
		static readonly NativeHandle selInsertionPointColorXHandle = Selector.GetHandle ("insertionPointColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateTextContainerOriginX = "invalidateTextContainerOrigin";
		static readonly NativeHandle selInvalidateTextContainerOriginXHandle = Selector.GetHandle ("invalidateTextContainerOrigin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityFocusedX = "isAccessibilityFocused";
		static readonly NativeHandle selIsAccessibilityFocusedXHandle = Selector.GetHandle ("isAccessibilityFocused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticDashSubstitutionEnabledX = "isAutomaticDashSubstitutionEnabled";
		static readonly NativeHandle selIsAutomaticDashSubstitutionEnabledXHandle = Selector.GetHandle ("isAutomaticDashSubstitutionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticDataDetectionEnabledX = "isAutomaticDataDetectionEnabled";
		static readonly NativeHandle selIsAutomaticDataDetectionEnabledXHandle = Selector.GetHandle ("isAutomaticDataDetectionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticLinkDetectionEnabledX = "isAutomaticLinkDetectionEnabled";
		static readonly NativeHandle selIsAutomaticLinkDetectionEnabledXHandle = Selector.GetHandle ("isAutomaticLinkDetectionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticQuoteSubstitutionEnabledX = "isAutomaticQuoteSubstitutionEnabled";
		static readonly NativeHandle selIsAutomaticQuoteSubstitutionEnabledXHandle = Selector.GetHandle ("isAutomaticQuoteSubstitutionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticSpellingCorrectionEnabledX = "isAutomaticSpellingCorrectionEnabled";
		static readonly NativeHandle selIsAutomaticSpellingCorrectionEnabledXHandle = Selector.GetHandle ("isAutomaticSpellingCorrectionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticTextCompletionEnabledX = "isAutomaticTextCompletionEnabled";
		static readonly NativeHandle selIsAutomaticTextCompletionEnabledXHandle = Selector.GetHandle ("isAutomaticTextCompletionEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAutomaticTextReplacementEnabledX = "isAutomaticTextReplacementEnabled";
		static readonly NativeHandle selIsAutomaticTextReplacementEnabledXHandle = Selector.GetHandle ("isAutomaticTextReplacementEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCoalescingUndoX = "isCoalescingUndo";
		static readonly NativeHandle selIsCoalescingUndoXHandle = Selector.GetHandle ("isCoalescingUndo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsContinuousSpellCheckingEnabledX = "isContinuousSpellCheckingEnabled";
		static readonly NativeHandle selIsContinuousSpellCheckingEnabledXHandle = Selector.GetHandle ("isContinuousSpellCheckingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEditableX = "isEditable";
		static readonly NativeHandle selIsEditableXHandle = Selector.GetHandle ("isEditable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFieldEditorX = "isFieldEditor";
		static readonly NativeHandle selIsFieldEditorXHandle = Selector.GetHandle ("isFieldEditor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsGrammarCheckingEnabledX = "isGrammarCheckingEnabled";
		static readonly NativeHandle selIsGrammarCheckingEnabledXHandle = Selector.GetHandle ("isGrammarCheckingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsIncrementalSearchingEnabledX = "isIncrementalSearchingEnabled";
		static readonly NativeHandle selIsIncrementalSearchingEnabledXHandle = Selector.GetHandle ("isIncrementalSearchingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRichTextX = "isRichText";
		static readonly NativeHandle selIsRichTextXHandle = Selector.GetHandle ("isRichText");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRulerVisibleX = "isRulerVisible";
		static readonly NativeHandle selIsRulerVisibleXHandle = Selector.GetHandle ("isRulerVisible");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSelectableX = "isSelectable";
		static readonly NativeHandle selIsSelectableXHandle = Selector.GetHandle ("isSelectable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsWritingToolsActiveX = "isWritingToolsActive";
		static readonly NativeHandle selIsWritingToolsActiveXHandle = Selector.GetHandle ("isWritingToolsActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutManagerX = "layoutManager";
		static readonly NativeHandle selLayoutManagerXHandle = Selector.GetHandle ("layoutManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutOrientationX = "layoutOrientation";
		static readonly NativeHandle selLayoutOrientationXHandle = Selector.GetHandle ("layoutOrientation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinkTextAttributesX = "linkTextAttributes";
		static readonly NativeHandle selLinkTextAttributesXHandle = Selector.GetHandle ("linkTextAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoosenKerning_X = "loosenKerning:";
		static readonly NativeHandle selLoosenKerning_XHandle = Selector.GetHandle ("loosenKerning:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLowerBaseline_X = "lowerBaseline:";
		static readonly NativeHandle selLowerBaseline_XHandle = Selector.GetHandle ("lowerBaseline:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMarkedRangeX = "markedRange";
		static readonly NativeHandle selMarkedRangeXHandle = Selector.GetHandle ("markedRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMarkedTextAttributesX = "markedTextAttributes";
		static readonly NativeHandle selMarkedTextAttributesXHandle = Selector.GetHandle ("markedTextAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMathExpressionCompletionTypeX = "mathExpressionCompletionType";
		static readonly NativeHandle selMathExpressionCompletionTypeXHandle = Selector.GetHandle ("mathExpressionCompletionType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNamesOfPromisedFilesDroppedAtDestination_X = "namesOfPromisedFilesDroppedAtDestination:";
		static readonly NativeHandle selNamesOfPromisedFilesDroppedAtDestination_XHandle = Selector.GetHandle ("namesOfPromisedFilesDroppedAtDestination:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontLinkPanel_X = "orderFrontLinkPanel:";
		static readonly NativeHandle selOrderFrontLinkPanel_XHandle = Selector.GetHandle ("orderFrontLinkPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontListPanel_X = "orderFrontListPanel:";
		static readonly NativeHandle selOrderFrontListPanel_XHandle = Selector.GetHandle ("orderFrontListPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontSpacingPanel_X = "orderFrontSpacingPanel:";
		static readonly NativeHandle selOrderFrontSpacingPanel_XHandle = Selector.GetHandle ("orderFrontSpacingPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontSubstitutionsPanel_X = "orderFrontSubstitutionsPanel:";
		static readonly NativeHandle selOrderFrontSubstitutionsPanel_XHandle = Selector.GetHandle ("orderFrontSubstitutionsPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderFrontTablePanel_X = "orderFrontTablePanel:";
		static readonly NativeHandle selOrderFrontTablePanel_XHandle = Selector.GetHandle ("orderFrontTablePanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutline_X = "outline:";
		static readonly NativeHandle selOutline_XHandle = Selector.GetHandle ("outline:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteAsPlainText_X = "pasteAsPlainText:";
		static readonly NativeHandle selPasteAsPlainText_XHandle = Selector.GetHandle ("pasteAsPlainText:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteAsRichText_X = "pasteAsRichText:";
		static readonly NativeHandle selPasteAsRichText_XHandle = Selector.GetHandle ("pasteAsRichText:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformFindPanelAction_X = "performFindPanelAction:";
		static readonly NativeHandle selPerformFindPanelAction_XHandle = Selector.GetHandle ("performFindPanelAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformValidatedReplacementInRange_WithAttributedString_X = "performValidatedReplacementInRange:withAttributedString:";
		static readonly NativeHandle selPerformValidatedReplacementInRange_WithAttributedString_XHandle = Selector.GetHandle ("performValidatedReplacementInRange:withAttributedString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredPasteboardTypeFromArray_RestrictedToTypesFromArray_X = "preferredPasteboardTypeFromArray:restrictedToTypesFromArray:";
		static readonly NativeHandle selPreferredPasteboardTypeFromArray_RestrictedToTypesFromArray_XHandle = Selector.GetHandle ("preferredPasteboardTypeFromArray:restrictedToTypesFromArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredTextAccessoryPlacementX = "preferredTextAccessoryPlacement";
		static readonly NativeHandle selPreferredTextAccessoryPlacementXHandle = Selector.GetHandle ("preferredTextAccessoryPlacement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuickLookPreviewableItemsInRanges_X = "quickLookPreviewableItemsInRanges:";
		static readonly NativeHandle selQuickLookPreviewableItemsInRanges_XHandle = Selector.GetHandle ("quickLookPreviewableItemsInRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRaiseBaseline_X = "raiseBaseline:";
		static readonly NativeHandle selRaiseBaseline_XHandle = Selector.GetHandle ("raiseBaseline:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeForUserCharacterAttributeChangeX = "rangeForUserCharacterAttributeChange";
		static readonly NativeHandle selRangeForUserCharacterAttributeChangeXHandle = Selector.GetHandle ("rangeForUserCharacterAttributeChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeForUserCompletionX = "rangeForUserCompletion";
		static readonly NativeHandle selRangeForUserCompletionXHandle = Selector.GetHandle ("rangeForUserCompletion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeForUserParagraphAttributeChangeX = "rangeForUserParagraphAttributeChange";
		static readonly NativeHandle selRangeForUserParagraphAttributeChangeXHandle = Selector.GetHandle ("rangeForUserParagraphAttributeChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeForUserTextChangeX = "rangeForUserTextChange";
		static readonly NativeHandle selRangeForUserTextChangeXHandle = Selector.GetHandle ("rangeForUserTextChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangesForUserCharacterAttributeChangeX = "rangesForUserCharacterAttributeChange";
		static readonly NativeHandle selRangesForUserCharacterAttributeChangeXHandle = Selector.GetHandle ("rangesForUserCharacterAttributeChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangesForUserParagraphAttributeChangeX = "rangesForUserParagraphAttributeChange";
		static readonly NativeHandle selRangesForUserParagraphAttributeChangeXHandle = Selector.GetHandle ("rangesForUserParagraphAttributeChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangesForUserTextChangeX = "rangesForUserTextChange";
		static readonly NativeHandle selRangesForUserTextChangeXHandle = Selector.GetHandle ("rangesForUserTextChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadSelectionFromPasteboard_X = "readSelectionFromPasteboard:";
		static readonly NativeHandle selReadSelectionFromPasteboard_XHandle = Selector.GetHandle ("readSelectionFromPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadSelectionFromPasteboard_Type_X = "readSelectionFromPasteboard:type:";
		static readonly NativeHandle selReadSelectionFromPasteboard_Type_XHandle = Selector.GetHandle ("readSelectionFromPasteboard:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadablePasteboardTypesX = "readablePasteboardTypes";
		static readonly NativeHandle selReadablePasteboardTypesXHandle = Selector.GetHandle ("readablePasteboardTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterForServicesX = "registerForServices";
		static readonly NativeHandle selRegisterForServicesXHandle = Selector.GetHandle ("registerForServices");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceTextContainer_X = "replaceTextContainer:";
		static readonly NativeHandle selReplaceTextContainer_XHandle = Selector.GetHandle ("replaceTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_DidAddMarker_X = "rulerView:didAddMarker:";
		static readonly NativeHandle selRulerView_DidAddMarker_XHandle = Selector.GetHandle ("rulerView:didAddMarker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_DidMoveMarker_X = "rulerView:didMoveMarker:";
		static readonly NativeHandle selRulerView_DidMoveMarker_XHandle = Selector.GetHandle ("rulerView:didMoveMarker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_DidRemoveMarker_X = "rulerView:didRemoveMarker:";
		static readonly NativeHandle selRulerView_DidRemoveMarker_XHandle = Selector.GetHandle ("rulerView:didRemoveMarker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_HandleMouseDown_X = "rulerView:handleMouseDown:";
		static readonly NativeHandle selRulerView_HandleMouseDown_XHandle = Selector.GetHandle ("rulerView:handleMouseDown:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_ShouldAddMarker_X = "rulerView:shouldAddMarker:";
		static readonly NativeHandle selRulerView_ShouldAddMarker_XHandle = Selector.GetHandle ("rulerView:shouldAddMarker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_ShouldMoveMarker_X = "rulerView:shouldMoveMarker:";
		static readonly NativeHandle selRulerView_ShouldMoveMarker_XHandle = Selector.GetHandle ("rulerView:shouldMoveMarker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_ShouldRemoveMarker_X = "rulerView:shouldRemoveMarker:";
		static readonly NativeHandle selRulerView_ShouldRemoveMarker_XHandle = Selector.GetHandle ("rulerView:shouldRemoveMarker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_WillAddMarker_AtLocation_X = "rulerView:willAddMarker:atLocation:";
		static readonly NativeHandle selRulerView_WillAddMarker_AtLocation_XHandle = Selector.GetHandle ("rulerView:willAddMarker:atLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRulerView_WillMoveMarker_ToLocation_X = "rulerView:willMoveMarker:toLocation:";
		static readonly NativeHandle selRulerView_WillMoveMarker_ToLocation_XHandle = Selector.GetHandle ("rulerView:willMoveMarker:toLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollableDocumentContentTextViewX = "scrollableDocumentContentTextView";
		static readonly NativeHandle selScrollableDocumentContentTextViewXHandle = Selector.GetHandle ("scrollableDocumentContentTextView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollablePlainDocumentContentTextViewX = "scrollablePlainDocumentContentTextView";
		static readonly NativeHandle selScrollablePlainDocumentContentTextViewXHandle = Selector.GetHandle ("scrollablePlainDocumentContentTextView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollableTextViewX = "scrollableTextView";
		static readonly NativeHandle selScrollableTextViewXHandle = Selector.GetHandle ("scrollableTextView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedRangeX = "selectedRange";
		static readonly NativeHandle selSelectedRangeXHandle = Selector.GetHandle ("selectedRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedRangesX = "selectedRanges";
		static readonly NativeHandle selSelectedRangesXHandle = Selector.GetHandle ("selectedRanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedTextAttributesX = "selectedTextAttributes";
		static readonly NativeHandle selSelectedTextAttributesXHandle = Selector.GetHandle ("selectedTextAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionAffinityX = "selectionAffinity";
		static readonly NativeHandle selSelectionAffinityXHandle = Selector.GetHandle ("selectionAffinity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionGranularityX = "selectionGranularity";
		static readonly NativeHandle selSelectionGranularityXHandle = Selector.GetHandle ("selectionGranularity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectionRangeForProposedRange_Granularity_X = "selectionRangeForProposedRange:granularity:";
		static readonly NativeHandle selSelectionRangeForProposedRange_Granularity_XHandle = Selector.GetHandle ("selectionRangeForProposedRange:granularity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAcceptsGlyphInfo_X = "setAcceptsGlyphInfo:";
		static readonly NativeHandle selSetAcceptsGlyphInfo_XHandle = Selector.GetHandle ("setAcceptsGlyphInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlignment_Range_X = "setAlignment:range:";
		static readonly NativeHandle selSetAlignment_Range_XHandle = Selector.GetHandle ("setAlignment:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowedInputSourceLocales_X = "setAllowedInputSourceLocales:";
		static readonly NativeHandle selSetAllowedInputSourceLocales_XHandle = Selector.GetHandle ("setAllowedInputSourceLocales:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowedWritingToolsResultOptions_X = "setAllowedWritingToolsResultOptions:";
		static readonly NativeHandle selSetAllowedWritingToolsResultOptions_XHandle = Selector.GetHandle ("setAllowedWritingToolsResultOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsCharacterPickerTouchBarItem_X = "setAllowsCharacterPickerTouchBarItem:";
		static readonly NativeHandle selSetAllowsCharacterPickerTouchBarItem_XHandle = Selector.GetHandle ("setAllowsCharacterPickerTouchBarItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsDocumentBackgroundColorChange_X = "setAllowsDocumentBackgroundColorChange:";
		static readonly NativeHandle selSetAllowsDocumentBackgroundColorChange_XHandle = Selector.GetHandle ("setAllowsDocumentBackgroundColorChange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsImageEditing_X = "setAllowsImageEditing:";
		static readonly NativeHandle selSetAllowsImageEditing_XHandle = Selector.GetHandle ("setAllowsImageEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsUndo_X = "setAllowsUndo:";
		static readonly NativeHandle selSetAllowsUndo_XHandle = Selector.GetHandle ("setAllowsUndo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticDashSubstitutionEnabled_X = "setAutomaticDashSubstitutionEnabled:";
		static readonly NativeHandle selSetAutomaticDashSubstitutionEnabled_XHandle = Selector.GetHandle ("setAutomaticDashSubstitutionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticDataDetectionEnabled_X = "setAutomaticDataDetectionEnabled:";
		static readonly NativeHandle selSetAutomaticDataDetectionEnabled_XHandle = Selector.GetHandle ("setAutomaticDataDetectionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticLinkDetectionEnabled_X = "setAutomaticLinkDetectionEnabled:";
		static readonly NativeHandle selSetAutomaticLinkDetectionEnabled_XHandle = Selector.GetHandle ("setAutomaticLinkDetectionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticQuoteSubstitutionEnabled_X = "setAutomaticQuoteSubstitutionEnabled:";
		static readonly NativeHandle selSetAutomaticQuoteSubstitutionEnabled_XHandle = Selector.GetHandle ("setAutomaticQuoteSubstitutionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticSpellingCorrectionEnabled_X = "setAutomaticSpellingCorrectionEnabled:";
		static readonly NativeHandle selSetAutomaticSpellingCorrectionEnabled_XHandle = Selector.GetHandle ("setAutomaticSpellingCorrectionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticTextCompletionEnabled_X = "setAutomaticTextCompletionEnabled:";
		static readonly NativeHandle selSetAutomaticTextCompletionEnabled_XHandle = Selector.GetHandle ("setAutomaticTextCompletionEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutomaticTextReplacementEnabled_X = "setAutomaticTextReplacementEnabled:";
		static readonly NativeHandle selSetAutomaticTextReplacementEnabled_XHandle = Selector.GetHandle ("setAutomaticTextReplacementEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundColor_X = "setBackgroundColor:";
		static readonly NativeHandle selSetBackgroundColor_XHandle = Selector.GetHandle ("setBackgroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBaseWritingDirection_Range_X = "setBaseWritingDirection:range:";
		static readonly NativeHandle selSetBaseWritingDirection_Range_XHandle = Selector.GetHandle ("setBaseWritingDirection:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConstrainedFrameSize_X = "setConstrainedFrameSize:";
		static readonly NativeHandle selSetConstrainedFrameSize_XHandle = Selector.GetHandle ("setConstrainedFrameSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentType_X = "setContentType:";
		static readonly NativeHandle selSetContentType_XHandle = Selector.GetHandle ("setContentType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContinuousSpellCheckingEnabled_X = "setContinuousSpellCheckingEnabled:";
		static readonly NativeHandle selSetContinuousSpellCheckingEnabled_XHandle = Selector.GetHandle ("setContinuousSpellCheckingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultParagraphStyle_X = "setDefaultParagraphStyle:";
		static readonly NativeHandle selSetDefaultParagraphStyle_XHandle = Selector.GetHandle ("setDefaultParagraphStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplaysLinkToolTips_X = "setDisplaysLinkToolTips:";
		static readonly NativeHandle selSetDisplaysLinkToolTips_XHandle = Selector.GetHandle ("setDisplaysLinkToolTips:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDrawsBackground_X = "setDrawsBackground:";
		static readonly NativeHandle selSetDrawsBackground_XHandle = Selector.GetHandle ("setDrawsBackground:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEditable_X = "setEditable:";
		static readonly NativeHandle selSetEditable_XHandle = Selector.GetHandle ("setEditable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnabledTextCheckingTypes_X = "setEnabledTextCheckingTypes:";
		static readonly NativeHandle selSetEnabledTextCheckingTypes_XHandle = Selector.GetHandle ("setEnabledTextCheckingTypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFieldEditor_X = "setFieldEditor:";
		static readonly NativeHandle selSetFieldEditor_XHandle = Selector.GetHandle ("setFieldEditor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGrammarCheckingEnabled_X = "setGrammarCheckingEnabled:";
		static readonly NativeHandle selSetGrammarCheckingEnabled_XHandle = Selector.GetHandle ("setGrammarCheckingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetImportsGraphics_X = "setImportsGraphics:";
		static readonly NativeHandle selSetImportsGraphics_XHandle = Selector.GetHandle ("setImportsGraphics:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIncrementalSearchingEnabled_X = "setIncrementalSearchingEnabled:";
		static readonly NativeHandle selSetIncrementalSearchingEnabled_XHandle = Selector.GetHandle ("setIncrementalSearchingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInlinePredictionType_X = "setInlinePredictionType:";
		static readonly NativeHandle selSetInlinePredictionType_XHandle = Selector.GetHandle ("setInlinePredictionType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInsertionPointColor_X = "setInsertionPointColor:";
		static readonly NativeHandle selSetInsertionPointColor_XHandle = Selector.GetHandle ("setInsertionPointColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLayoutOrientation_X = "setLayoutOrientation:";
		static readonly NativeHandle selSetLayoutOrientation_XHandle = Selector.GetHandle ("setLayoutOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLinkTextAttributes_X = "setLinkTextAttributes:";
		static readonly NativeHandle selSetLinkTextAttributes_XHandle = Selector.GetHandle ("setLinkTextAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMarkedText_SelectedRange_X = "setMarkedText:selectedRange:";
		static readonly NativeHandle selSetMarkedText_SelectedRange_XHandle = Selector.GetHandle ("setMarkedText:selectedRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMarkedText_SelectedRange_ReplacementRange_X = "setMarkedText:selectedRange:replacementRange:";
		static readonly NativeHandle selSetMarkedText_SelectedRange_ReplacementRange_XHandle = Selector.GetHandle ("setMarkedText:selectedRange:replacementRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMarkedTextAttributes_X = "setMarkedTextAttributes:";
		static readonly NativeHandle selSetMarkedTextAttributes_XHandle = Selector.GetHandle ("setMarkedTextAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMathExpressionCompletionType_X = "setMathExpressionCompletionType:";
		static readonly NativeHandle selSetMathExpressionCompletionType_XHandle = Selector.GetHandle ("setMathExpressionCompletionType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeedsDisplayInRect_AvoidAdditionalLayout_X = "setNeedsDisplayInRect:avoidAdditionalLayout:";
		static readonly NativeHandle selSetNeedsDisplayInRect_AvoidAdditionalLayout_XHandle = Selector.GetHandle ("setNeedsDisplayInRect:avoidAdditionalLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRichText_X = "setRichText:";
		static readonly NativeHandle selSetRichText_XHandle = Selector.GetHandle ("setRichText:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRulerVisible_X = "setRulerVisible:";
		static readonly NativeHandle selSetRulerVisible_XHandle = Selector.GetHandle ("setRulerVisible:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectable_X = "setSelectable:";
		static readonly NativeHandle selSetSelectable_XHandle = Selector.GetHandle ("setSelectable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedRange_X = "setSelectedRange:";
		static readonly NativeHandle selSetSelectedRange_XHandle = Selector.GetHandle ("setSelectedRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedRange_Affinity_StillSelecting_X = "setSelectedRange:affinity:stillSelecting:";
		static readonly NativeHandle selSetSelectedRange_Affinity_StillSelecting_XHandle = Selector.GetHandle ("setSelectedRange:affinity:stillSelecting:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedRanges_X = "setSelectedRanges:";
		static readonly NativeHandle selSetSelectedRanges_XHandle = Selector.GetHandle ("setSelectedRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedRanges_Affinity_StillSelecting_X = "setSelectedRanges:affinity:stillSelecting:";
		static readonly NativeHandle selSetSelectedRanges_Affinity_StillSelecting_XHandle = Selector.GetHandle ("setSelectedRanges:affinity:stillSelecting:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedTextAttributes_X = "setSelectedTextAttributes:";
		static readonly NativeHandle selSetSelectedTextAttributes_XHandle = Selector.GetHandle ("setSelectedTextAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectionGranularity_X = "setSelectionGranularity:";
		static readonly NativeHandle selSetSelectionGranularity_XHandle = Selector.GetHandle ("setSelectionGranularity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSmartInsertDeleteEnabled_X = "setSmartInsertDeleteEnabled:";
		static readonly NativeHandle selSetSmartInsertDeleteEnabled_XHandle = Selector.GetHandle ("setSmartInsertDeleteEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSpellingState_Range_X = "setSpellingState:range:";
		static readonly NativeHandle selSetSpellingState_Range_XHandle = Selector.GetHandle ("setSpellingState:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextContainer_X = "setTextContainer:";
		static readonly NativeHandle selSetTextContainer_XHandle = Selector.GetHandle ("setTextContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextContainerInset_X = "setTextContainerInset:";
		static readonly NativeHandle selSetTextContainerInset_XHandle = Selector.GetHandle ("setTextContainerInset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextHighlightAttributes_X = "setTextHighlightAttributes:";
		static readonly NativeHandle selSetTextHighlightAttributes_XHandle = Selector.GetHandle ("setTextHighlightAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTypingAttributes_X = "setTypingAttributes:";
		static readonly NativeHandle selSetTypingAttributes_XHandle = Selector.GetHandle ("setTypingAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesAdaptiveColorMappingForDarkAppearance_X = "setUsesAdaptiveColorMappingForDarkAppearance:";
		static readonly NativeHandle selSetUsesAdaptiveColorMappingForDarkAppearance_XHandle = Selector.GetHandle ("setUsesAdaptiveColorMappingForDarkAppearance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesFindBar_X = "setUsesFindBar:";
		static readonly NativeHandle selSetUsesFindBar_XHandle = Selector.GetHandle ("setUsesFindBar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesFindPanel_X = "setUsesFindPanel:";
		static readonly NativeHandle selSetUsesFindPanel_XHandle = Selector.GetHandle ("setUsesFindPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesFontPanel_X = "setUsesFontPanel:";
		static readonly NativeHandle selSetUsesFontPanel_XHandle = Selector.GetHandle ("setUsesFontPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesInspectorBar_X = "setUsesInspectorBar:";
		static readonly NativeHandle selSetUsesInspectorBar_XHandle = Selector.GetHandle ("setUsesInspectorBar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesRolloverButtonForSelection_X = "setUsesRolloverButtonForSelection:";
		static readonly NativeHandle selSetUsesRolloverButtonForSelection_XHandle = Selector.GetHandle ("setUsesRolloverButtonForSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesRuler_X = "setUsesRuler:";
		static readonly NativeHandle selSetUsesRuler_XHandle = Selector.GetHandle ("setUsesRuler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWritingToolsBehavior_X = "setWritingToolsBehavior:";
		static readonly NativeHandle selSetWritingToolsBehavior_XHandle = Selector.GetHandle ("setWritingToolsBehavior:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldChangeTextInRange_ReplacementString_X = "shouldChangeTextInRange:replacementString:";
		static readonly NativeHandle selShouldChangeTextInRange_ReplacementString_XHandle = Selector.GetHandle ("shouldChangeTextInRange:replacementString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldChangeTextInRanges_ReplacementStrings_X = "shouldChangeTextInRanges:replacementStrings:";
		static readonly NativeHandle selShouldChangeTextInRanges_ReplacementStrings_XHandle = Selector.GetHandle ("shouldChangeTextInRanges:replacementStrings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldDrawInsertionPointX = "shouldDrawInsertionPoint";
		static readonly NativeHandle selShouldDrawInsertionPointXHandle = Selector.GetHandle ("shouldDrawInsertionPoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowFindIndicatorForRange_X = "showFindIndicatorForRange:";
		static readonly NativeHandle selShowFindIndicatorForRange_XHandle = Selector.GetHandle ("showFindIndicatorForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSmartDeleteRangeForProposedRange_X = "smartDeleteRangeForProposedRange:";
		static readonly NativeHandle selSmartDeleteRangeForProposedRange_XHandle = Selector.GetHandle ("smartDeleteRangeForProposedRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSmartInsertAfterStringForString_ReplacingRange_X = "smartInsertAfterStringForString:replacingRange:";
		static readonly NativeHandle selSmartInsertAfterStringForString_ReplacingRange_XHandle = Selector.GetHandle ("smartInsertAfterStringForString:replacingRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSmartInsertBeforeStringForString_ReplacingRange_X = "smartInsertBeforeStringForString:replacingRange:";
		static readonly NativeHandle selSmartInsertBeforeStringForString_ReplacingRange_XHandle = Selector.GetHandle ("smartInsertBeforeStringForString:replacingRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSmartInsertDeleteEnabledX = "smartInsertDeleteEnabled";
		static readonly NativeHandle selSmartInsertDeleteEnabledXHandle = Selector.GetHandle ("smartInsertDeleteEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSmartInsertForString_ReplacingRange_BeforeString_AfterString_X = "smartInsertForString:replacingRange:beforeString:afterString:";
		static readonly NativeHandle selSmartInsertForString_ReplacingRange_BeforeString_AfterString_XHandle = Selector.GetHandle ("smartInsertForString:replacingRange:beforeString:afterString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpellCheckerDocumentTagX = "spellCheckerDocumentTag";
		static readonly NativeHandle selSpellCheckerDocumentTagXHandle = Selector.GetHandle ("spellCheckerDocumentTag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartSpeaking_X = "startSpeaking:";
		static readonly NativeHandle selStartSpeaking_XHandle = Selector.GetHandle ("startSpeaking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopSpeaking_X = "stopSpeaking:";
		static readonly NativeHandle selStopSpeaking_XHandle = Selector.GetHandle ("stopSpeaking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStronglyReferencesTextStorageX = "stronglyReferencesTextStorage";
		static readonly NativeHandle selStronglyReferencesTextStorageXHandle = Selector.GetHandle ("stronglyReferencesTextStorage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportsAdaptiveImageGlyphX = "supportsAdaptiveImageGlyph";
		static readonly NativeHandle selSupportsAdaptiveImageGlyphXHandle = Selector.GetHandle ("supportsAdaptiveImageGlyph");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainerX = "textContainer";
		static readonly NativeHandle selTextContainerXHandle = Selector.GetHandle ("textContainer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainerInsetX = "textContainerInset";
		static readonly NativeHandle selTextContainerInsetXHandle = Selector.GetHandle ("textContainerInset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContainerOriginX = "textContainerOrigin";
		static readonly NativeHandle selTextContainerOriginXHandle = Selector.GetHandle ("textContainerOrigin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContentStorageX = "textContentStorage";
		static readonly NativeHandle selTextContentStorageXHandle = Selector.GetHandle ("textContentStorage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextHighlightAttributesX = "textHighlightAttributes";
		static readonly NativeHandle selTextHighlightAttributesXHandle = Selector.GetHandle ("textHighlightAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextLayoutManagerX = "textLayoutManager";
		static readonly NativeHandle selTextLayoutManagerXHandle = Selector.GetHandle ("textLayoutManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextStorageX = "textStorage";
		static readonly NativeHandle selTextStorageXHandle = Selector.GetHandle ("textStorage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextViewUsingTextLayoutManager_X = "textViewUsingTextLayoutManager:";
		static readonly NativeHandle selTextViewUsingTextLayoutManager_XHandle = Selector.GetHandle ("textViewUsingTextLayoutManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTightenKerning_X = "tightenKerning:";
		static readonly NativeHandle selTightenKerning_XHandle = Selector.GetHandle ("tightenKerning:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleAutomaticDashSubstitution_X = "toggleAutomaticDashSubstitution:";
		static readonly NativeHandle selToggleAutomaticDashSubstitution_XHandle = Selector.GetHandle ("toggleAutomaticDashSubstitution:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleAutomaticDataDetection_X = "toggleAutomaticDataDetection:";
		static readonly NativeHandle selToggleAutomaticDataDetection_XHandle = Selector.GetHandle ("toggleAutomaticDataDetection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleAutomaticLinkDetection_X = "toggleAutomaticLinkDetection:";
		static readonly NativeHandle selToggleAutomaticLinkDetection_XHandle = Selector.GetHandle ("toggleAutomaticLinkDetection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleAutomaticQuoteSubstitution_X = "toggleAutomaticQuoteSubstitution:";
		static readonly NativeHandle selToggleAutomaticQuoteSubstitution_XHandle = Selector.GetHandle ("toggleAutomaticQuoteSubstitution:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleAutomaticSpellingCorrection_X = "toggleAutomaticSpellingCorrection:";
		static readonly NativeHandle selToggleAutomaticSpellingCorrection_XHandle = Selector.GetHandle ("toggleAutomaticSpellingCorrection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleAutomaticTextCompletion_X = "toggleAutomaticTextCompletion:";
		static readonly NativeHandle selToggleAutomaticTextCompletion_XHandle = Selector.GetHandle ("toggleAutomaticTextCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleAutomaticTextReplacement_X = "toggleAutomaticTextReplacement:";
		static readonly NativeHandle selToggleAutomaticTextReplacement_XHandle = Selector.GetHandle ("toggleAutomaticTextReplacement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleContinuousSpellChecking_X = "toggleContinuousSpellChecking:";
		static readonly NativeHandle selToggleContinuousSpellChecking_XHandle = Selector.GetHandle ("toggleContinuousSpellChecking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleGrammarChecking_X = "toggleGrammarChecking:";
		static readonly NativeHandle selToggleGrammarChecking_XHandle = Selector.GetHandle ("toggleGrammarChecking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleQuickLookPreviewPanel_X = "toggleQuickLookPreviewPanel:";
		static readonly NativeHandle selToggleQuickLookPreviewPanel_XHandle = Selector.GetHandle ("toggleQuickLookPreviewPanel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleSmartInsertDelete_X = "toggleSmartInsertDelete:";
		static readonly NativeHandle selToggleSmartInsertDelete_XHandle = Selector.GetHandle ("toggleSmartInsertDelete:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToggleTraditionalCharacterShape_X = "toggleTraditionalCharacterShape:";
		static readonly NativeHandle selToggleTraditionalCharacterShape_XHandle = Selector.GetHandle ("toggleTraditionalCharacterShape:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTouchBar_MakeItemForIdentifier_X = "touchBar:makeItemForIdentifier:";
		static readonly NativeHandle selTouchBar_MakeItemForIdentifier_XHandle = Selector.GetHandle ("touchBar:makeItemForIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTurnOffKerning_X = "turnOffKerning:";
		static readonly NativeHandle selTurnOffKerning_XHandle = Selector.GetHandle ("turnOffKerning:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTurnOffLigatures_X = "turnOffLigatures:";
		static readonly NativeHandle selTurnOffLigatures_XHandle = Selector.GetHandle ("turnOffLigatures:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypingAttributesX = "typingAttributes";
		static readonly NativeHandle selTypingAttributesXHandle = Selector.GetHandle ("typingAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnionRectInVisibleSelectedRangeX = "unionRectInVisibleSelectedRange";
		static readonly NativeHandle selUnionRectInVisibleSelectedRangeXHandle = Selector.GetHandle ("unionRectInVisibleSelectedRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnmarkTextX = "unmarkText";
		static readonly NativeHandle selUnmarkTextXHandle = Selector.GetHandle ("unmarkText");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateCandidatesX = "updateCandidates";
		static readonly NativeHandle selUpdateCandidatesXHandle = Selector.GetHandle ("updateCandidates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateDragTypeRegistrationX = "updateDragTypeRegistration";
		static readonly NativeHandle selUpdateDragTypeRegistrationXHandle = Selector.GetHandle ("updateDragTypeRegistration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateFontPanelX = "updateFontPanel";
		static readonly NativeHandle selUpdateFontPanelXHandle = Selector.GetHandle ("updateFontPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateInsertionPointStateAndRestartTimer_X = "updateInsertionPointStateAndRestartTimer:";
		static readonly NativeHandle selUpdateInsertionPointStateAndRestartTimer_XHandle = Selector.GetHandle ("updateInsertionPointStateAndRestartTimer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateQuickLookPreviewPanelX = "updateQuickLookPreviewPanel";
		static readonly NativeHandle selUpdateQuickLookPreviewPanelXHandle = Selector.GetHandle ("updateQuickLookPreviewPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateRulerX = "updateRuler";
		static readonly NativeHandle selUpdateRulerXHandle = Selector.GetHandle ("updateRuler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateTextTouchBarItemsX = "updateTextTouchBarItems";
		static readonly NativeHandle selUpdateTextTouchBarItemsXHandle = Selector.GetHandle ("updateTextTouchBarItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateTouchBarItemIdentifiersX = "updateTouchBarItemIdentifiers";
		static readonly NativeHandle selUpdateTouchBarItemIdentifiersXHandle = Selector.GetHandle ("updateTouchBarItemIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUseAllLigatures_X = "useAllLigatures:";
		static readonly NativeHandle selUseAllLigatures_XHandle = Selector.GetHandle ("useAllLigatures:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUseStandardKerning_X = "useStandardKerning:";
		static readonly NativeHandle selUseStandardKerning_XHandle = Selector.GetHandle ("useStandardKerning:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUseStandardLigatures_X = "useStandardLigatures:";
		static readonly NativeHandle selUseStandardLigatures_XHandle = Selector.GetHandle ("useStandardLigatures:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesAdaptiveColorMappingForDarkAppearanceX = "usesAdaptiveColorMappingForDarkAppearance";
		static readonly NativeHandle selUsesAdaptiveColorMappingForDarkAppearanceXHandle = Selector.GetHandle ("usesAdaptiveColorMappingForDarkAppearance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesFindBarX = "usesFindBar";
		static readonly NativeHandle selUsesFindBarXHandle = Selector.GetHandle ("usesFindBar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesFindPanelX = "usesFindPanel";
		static readonly NativeHandle selUsesFindPanelXHandle = Selector.GetHandle ("usesFindPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesFontPanelX = "usesFontPanel";
		static readonly NativeHandle selUsesFontPanelXHandle = Selector.GetHandle ("usesFontPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesInspectorBarX = "usesInspectorBar";
		static readonly NativeHandle selUsesInspectorBarXHandle = Selector.GetHandle ("usesInspectorBar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesRolloverButtonForSelectionX = "usesRolloverButtonForSelection";
		static readonly NativeHandle selUsesRolloverButtonForSelectionXHandle = Selector.GetHandle ("usesRolloverButtonForSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesRulerX = "usesRuler";
		static readonly NativeHandle selUsesRulerXHandle = Selector.GetHandle ("usesRuler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidAttributesForMarkedTextX = "validAttributesForMarkedText";
		static readonly NativeHandle selValidAttributesForMarkedTextXHandle = Selector.GetHandle ("validAttributesForMarkedText");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidRequestorForSendType_ReturnType_X = "validRequestorForSendType:returnType:";
		static readonly NativeHandle selValidRequestorForSendType_ReturnType_XHandle = Selector.GetHandle ("validRequestorForSendType:returnType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateMenuItem_X = "validateMenuItem:";
		static readonly NativeHandle selValidateMenuItem_XHandle = Selector.GetHandle ("validateMenuItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidateUserInterfaceItem_X = "validateUserInterfaceItem:";
		static readonly NativeHandle selValidateUserInterfaceItem_XHandle = Selector.GetHandle ("validateUserInterfaceItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowLevelX = "windowLevel";
		static readonly NativeHandle selWindowLevelXHandle = Selector.GetHandle ("windowLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritablePasteboardTypesX = "writablePasteboardTypes";
		static readonly NativeHandle selWritablePasteboardTypesXHandle = Selector.GetHandle ("writablePasteboardTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteSelectionToPasteboard_Type_X = "writeSelectionToPasteboard:type:";
		static readonly NativeHandle selWriteSelectionToPasteboard_Type_XHandle = Selector.GetHandle ("writeSelectionToPasteboard:type:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteSelectionToPasteboard_Types_X = "writeSelectionToPasteboard:types:";
		static readonly NativeHandle selWriteSelectionToPasteboard_Types_XHandle = Selector.GetHandle ("writeSelectionToPasteboard:types:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritingToolsBehaviorX = "writingToolsBehavior";
		static readonly NativeHandle selWritingToolsBehaviorXHandle = Selector.GetHandle ("writingToolsBehavior");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSTextView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSTextView () : base (NSObjectFlag.Empty)
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
		public NSTextView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSTextView (NSObjectFlag t) : base (t)
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
		protected internal NSTextView (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFrame:textContainer:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextView (CGRect frameRect, NSTextContainer? container)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var container__handle__ = container.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (this.Handle, selInitWithFrame_TextContainer_XHandle, frameRect, container__handle__), "initWithFrame:textContainer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selInitWithFrame_TextContainer_XHandle, frameRect, container__handle__), "initWithFrame:textContainer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextView (CGRect frameRect)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initUsingTextLayoutManager:")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextView (bool usingTextLayoutManager)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (this.Handle, selInitUsingTextLayoutManager_XHandle, usingTextLayoutManager ? (byte) 1 : (byte) 0), "initUsingTextLayoutManager:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool (&__objc_super__, selInitUsingTextLayoutManager_XHandle, usingTextLayoutManager ? (byte) 1 : (byte) 0), "initUsingTextLayoutManager:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("acceptableDragTypes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AcceptableDragTypes ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAcceptableDragTypesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAcceptableDragTypesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("alignJustified:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AlignJustified (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAlignJustified_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAlignJustified_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("candidateListTouchBarItem:beginSelectingCandidateAtIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginSelectingCandidate (NSCandidateListTouchBarItem anItem, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selCandidateListTouchBarItem_BeginSelectingCandidateAtIndex_XHandle, anItem__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selCandidateListTouchBarItem_BeginSelectingCandidateAtIndex_XHandle, anItem__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anItem);
		}
		[Export ("breakUndoCoalescing")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BreakUndoCoalescing ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selBreakUndoCoalescingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selBreakUndoCoalescingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("changeAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeAttributes (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selChangeAttributes_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeAttributes_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("changeColor:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeColor (NSColorPanel? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selChangeColor_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeColor_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("changeDocumentBackgroundColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeDocumentBackgroundColor (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selChangeDocumentBackgroundColor_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeDocumentBackgroundColor_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("changeLayoutOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeLayoutOrientation (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selChangeLayoutOrientation_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selChangeLayoutOrientation_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="anItem">To be added.</param><param name="previousIndex">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeSelectionFromCandidate (NSCandidateListTouchBarItem anItem, nint previousIndex, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, selCandidateListTouchBarItem_ChangeSelectionFromCandidateAtIndex_ToIndex_XHandle, anItem__handle__, previousIndex, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr (&__objc_super__, selCandidateListTouchBarItem_ChangeSelectionFromCandidateAtIndex_ToIndex_XHandle, anItem__handle__, previousIndex, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anItem);
		}
		/// <param name="anItem">To be added.</param><param name="isVisible">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("candidateListTouchBarItem:changedCandidateListVisibility:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangedCandidateListVisibility (NSCandidateListTouchBarItem anItem, bool isVisible)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selCandidateListTouchBarItem_ChangedCandidateListVisibility_XHandle, anItem__handle__, isVisible ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selCandidateListTouchBarItem_ChangedCandidateListVisibility_XHandle, anItem__handle__, isVisible ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anItem);
		}
		[Export ("characterIndexForInsertionAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint CharacterIndex (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, selCharacterIndexForInsertionAtPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selCharacterIndexForInsertionAtPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("checkTextInRange:types:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckText (NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_UInt64_NativeHandle (this.Handle, selCheckTextInRange_Types_Options_XHandle, range, (UInt64)checkingTypes, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_UInt64_NativeHandle (&__objc_super__, selCheckTextInRange_Types_Options_XHandle, range, (UInt64)checkingTypes, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
		}
		[Export ("checkTextInDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckTextInDocument (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCheckTextInDocument_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCheckTextInDocument_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("checkTextInSelection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckTextInSelection (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCheckTextInSelection_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCheckTextInSelection_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("cleanUpAfterDragOperation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CleanUpAfterDragOperation ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCleanUpAfterDragOperationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCleanUpAfterDragOperationXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("clickedOnLink:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClickedOnLink (NSObject link, nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var link__handle__ = link!.GetNonNullHandle (nameof (link));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selClickedOnLink_AtIndex_XHandle, link__handle__, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selClickedOnLink_AtIndex_XHandle, link__handle__, charIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (link);
		}
		[Export ("complete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Complete (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selComplete_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selComplete_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("completionsForPartialWordRange:indexOfSelectedItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual string[]? CompletionsForPartialWord (NSRange charRange, out nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (nint* index__pointer = &index) {
			index = default;
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_out_IntPtr (this.Handle, selCompletionsForPartialWordRange_IndexOfSelectedItem_XHandle, charRange, index__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_out_IntPtr (&__objc_super__, selCompletionsForPartialWordRange_IndexOfSelectedItem_XHandle, charRange, index__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		[Export ("textViewUsingTextLayoutManager:")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextView Create (bool usingTextLayoutManager)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextView ret;
			ret =  Runtime.GetNSObject<NSTextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, selTextViewUsingTextLayoutManager_XHandle, usingTextLayoutManager ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("fieldEditor")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextView CreateFieldEditor ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextView ret;
			ret =  Runtime.GetNSObject<NSTextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFieldEditorXHandle), false)!;
			return ret;
		}
		[Export ("scrollableDocumentContentTextView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSScrollView CreateScrollableDocumentContentTextView ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSScrollView ret;
			ret =  Runtime.GetNSObject<NSScrollView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selScrollableDocumentContentTextViewXHandle), false)!;
			return ret;
		}
		[Export ("scrollablePlainDocumentContentTextView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSScrollView CreateScrollablePlainDocumentContentTextView ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSScrollView ret;
			ret =  Runtime.GetNSObject<NSScrollView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selScrollablePlainDocumentContentTextViewXHandle), false)!;
			return ret;
		}
		[Export ("scrollableTextView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSScrollView CreateScrollableTextView ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSScrollView ret;
			ret =  Runtime.GetNSObject<NSScrollView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selScrollableTextViewXHandle), false)!;
			return ret;
		}
		[Export ("didChangeText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeText ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidChangeTextXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDidChangeTextXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("dragImageForSelectionWithEvent:origin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage? DragImage (NSEvent @event, CGPoint* origin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			if (origin is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (origin));
			NSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGPoint_ (this.Handle, selDragImageForSelectionWithEvent_Origin_XHandle, @event__handle__, origin), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGPoint_ (&__objc_super__, selDragImageForSelectionWithEvent_Origin_XHandle, @event__handle__, origin), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@event);
			return ret!;
		}
		[Export ("dragOperationForDraggingInfo:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation DragOperationForDraggingInfo (INSDraggingInfo dragInfo, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dragInfo__handle__ = dragInfo!.GetNonNullHandle (nameof (dragInfo));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			NSDragOperation ret;
			if (IsDirectBinding) {
				ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDragOperationForDraggingInfo_Type_XHandle, dragInfo__handle__, nstype);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDragOperationForDraggingInfo_Type_XHandle, dragInfo__handle__, nstype);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dragInfo);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("dragSelectionWithEvent:offset:slideBack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DragSelection (NSEvent @event, CGSize mouseOffset, bool slideBack)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGSize_bool (this.Handle, selDragSelectionWithEvent_Offset_SlideBack_XHandle, @event__handle__, mouseOffset, slideBack ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_CGSize_bool (&__objc_super__, selDragSelectionWithEvent_Offset_SlideBack_XHandle, @event__handle__, mouseOffset, slideBack ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@event);
			return ret != 0;
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:beganAt:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageBeganAt (NSImage image, CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (this.Handle, selDraggedImage_BeganAt_XHandle, image__handle__, screenPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, selDraggedImage_BeganAt_XHandle, image__handle__, screenPoint);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="deposited">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:endedAt:deposited:")]
		[ObsoletedOSPlatform ("macos10.1", "Use DraggedImageEndedAtOperation instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtDeposited (NSImage image, CGPoint screenPoint, bool deposited)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_bool (this.Handle, selDraggedImage_EndedAt_Deposited_XHandle, image__handle__, screenPoint, deposited ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint_bool (&__objc_super__, selDraggedImage_EndedAt_Deposited_XHandle, image__handle__, screenPoint, deposited ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><param name="operation">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:endedAt:operation:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageEndedAtOperation (NSImage image, CGPoint screenPoint, NSDragOperation operation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint_UIntPtr (this.Handle, selDraggedImage_EndedAt_Operation_XHandle, image__handle__, screenPoint, (UIntPtr) (ulong) operation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint_UIntPtr (&__objc_super__, selDraggedImage_EndedAt_Operation_XHandle, image__handle__, screenPoint, (UIntPtr) (ulong) operation);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image">To be added.</param><param name="screenPoint">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("draggedImage:movedTo:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DraggedImageMovedTo (NSImage image, CGPoint screenPoint)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (this.Handle, selDraggedImage_MovedTo_XHandle, image__handle__, screenPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, selDraggedImage_MovedTo_XHandle, image__handle__, screenPoint);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="flag">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("draggingSourceOperationMaskForLocal:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDragOperation DraggingSourceOperationMaskForLocal (bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSDragOperation ret;
			if (IsDirectBinding) {
				ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_bool (this.Handle, selDraggingSourceOperationMaskForLocal_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSDragOperation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_bool (&__objc_super__, selDraggingSourceOperationMaskForLocal_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("drawInsertionPointInRect:color:turnedOn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawInsertionPoint (CGRect rect, NSColor color, bool turnedOn)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_bool (this.Handle, selDrawInsertionPointInRect_Color_TurnedOn_XHandle, rect, color__handle__, turnedOn ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_bool (&__objc_super__, selDrawInsertionPointInRect_Color_TurnedOn_XHandle, rect, color__handle__, turnedOn ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
		}
		[Export ("drawTextHighlightBackgroundForTextRange:origin:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawTextHighlightBackground (NSTextRange textRange, CGPoint origin)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textRange__handle__ = textRange!.GetNonNullHandle (nameof (textRange));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_CGPoint (this.Handle, selDrawTextHighlightBackgroundForTextRange_Origin_XHandle, textRange__handle__, origin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_CGPoint (&__objc_super__, selDrawTextHighlightBackgroundForTextRange_Origin_XHandle, textRange__handle__, origin);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textRange);
		}
		[Export ("drawViewBackgroundInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawViewBackgroundInRect (CGRect rect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selDrawViewBackgroundInRect_XHandle, rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selDrawViewBackgroundInRect_XHandle, rect);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("drawsVerticallyForCharacterAtIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawsVertically (nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, selDrawsVerticallyForCharacterAtIndex_XHandle, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, selDrawsVerticallyForCharacterAtIndex_XHandle, charIndex);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="anItem">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("candidateListTouchBarItem:endSelectingCandidateAtIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndSelectingCandidate (NSCandidateListTouchBarItem anItem, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var anItem__handle__ = anItem!.GetNonNullHandle (nameof (anItem));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selCandidateListTouchBarItem_EndSelectingCandidateAtIndex_XHandle, anItem__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selCandidateListTouchBarItem_EndSelectingCandidateAtIndex_XHandle, anItem__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anItem);
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityAttributedStringForRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedString (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAttributedString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selAccessibilityAttributedStringForRange_XHandle, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selAccessibilityAttributedStringForRange_XHandle, range), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityFrameForRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAccessibilityFrame (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange (this.Handle, selAccessibilityFrameForRange_XHandle, range);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange (this.Handle, selAccessibilityFrameForRange_XHandle, range);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NSRange (&__objc_super__, selAccessibilityFrameForRange_XHandle, range);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NSRange (&__objc_super__, selAccessibilityFrameForRange_XHandle, range);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityLineForIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetAccessibilityLine (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selAccessibilityLineForIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selAccessibilityLineForIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="lineNumber">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityRangeForLine:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRangeForLine (nint lineNumber)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (this.Handle, selAccessibilityRangeForLine_XHandle, lineNumber);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_IntPtr (&__objc_super__, selAccessibilityRangeForLine_XHandle, lineNumber);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("accessibilityStringForRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityString (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selAccessibilityStringForRange_XHandle, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selAccessibilityStringForRange_XHandle, range), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("attributedSubstringForProposedRange:actualRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSAttributedString? GetAttributedSubstring (NSRange proposedRange, out NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualRange__pointer = &actualRange) {
			actualRange = default;
			NSAttributedString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_out_NSRange (this.Handle, selAttributedSubstringForProposedRange_ActualRange_XHandle, proposedRange, actualRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_out_NSRange (&__objc_super__, selAttributedSubstringForProposedRange_ActualRange_XHandle, proposedRange, actualRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attributedSubstringFromRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString GetAttributedSubstring (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAttributedString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selAttributedSubstringFromRange_XHandle, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selAttributedSubstringFromRange_XHandle, range), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="charIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("baselineDeltaForCharacterAtIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetBaselineDelta (nuint charIndex)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr (this.Handle, selBaselineDeltaForCharacterAtIndex_XHandle, charIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_UIntPtr (&__objc_super__, selBaselineDeltaForCharacterAtIndex_XHandle, charIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("characterIndexForPoint:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetCharacterIndex (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, selCharacterIndexForPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selCharacterIndexForPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("contentType")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString GetContentType ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentTypeXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentTypeXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("firstRectForCharacterRange:actualRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual CGRect GetFirstRect (NSRange characterRange, out NSRange actualRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (NSRange* actualRange__pointer = &actualRange) {
			actualRange = default;
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange_out_NSRange (this.Handle, selFirstRectForCharacterRange_ActualRange_XHandle, characterRange, actualRange__pointer);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange_out_NSRange (this.Handle, selFirstRectForCharacterRange_ActualRange_XHandle, characterRange, actualRange__pointer);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NSRange_out_NSRange (&__objc_super__, selFirstRectForCharacterRange_ActualRange_XHandle, characterRange, actualRange__pointer);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NSRange_out_NSRange (&__objc_super__, selFirstRectForCharacterRange_ActualRange_XHandle, characterRange, actualRange__pointer);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
			}
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("firstRectForCharacterRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFirstRectForCharacterRange (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange (this.Handle, selFirstRectForCharacterRange_XHandle, range);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange (this.Handle, selFirstRectForCharacterRange_XHandle, range);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NSRange (&__objc_super__, selFirstRectForCharacterRange_XHandle, range);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NSRange (&__objc_super__, selFirstRectForCharacterRange_XHandle, range);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="point">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fractionOfDistanceThroughGlyphForPoint:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetFractionOfDistanceThroughGlyph (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_CGPoint (this.Handle, selFractionOfDistanceThroughGlyphForPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_CGPoint (&__objc_super__, selFractionOfDistanceThroughGlyphForPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("preferredPasteboardTypeFromArray:restrictedToTypesFromArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetPreferredPasteboardType (string[] availableTypes, string[]? allowedTypes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (availableTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (availableTypes));
			using var nsa_availableTypes = NSArray.FromStrings (availableTypes);
			using var nsa_allowedTypes = NSArray.FromNullableStrings (allowedTypes);
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPreferredPasteboardTypeFromArray_RestrictedToTypesFromArray_XHandle, nsa_availableTypes.Handle, nsa_allowedTypes.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPreferredPasteboardTypeFromArray_RestrictedToTypesFromArray_XHandle, nsa_availableTypes.Handle, nsa_allowedTypes.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("handleTextCheckingResults:forRange:types:options:orthography:wordCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleTextChecking (NSTextCheckingResult[] results, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSOrthography orthography, nint wordCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (results is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (results));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var orthography__handle__ = orthography!.GetNonNullHandle (nameof (orthography));
			using var nsa_results = NSArray.FromNSObjects (results);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_UInt64_NativeHandle_NativeHandle_IntPtr (this.Handle, selHandleTextCheckingResults_ForRange_Types_Options_Orthography_WordCount_XHandle, nsa_results.Handle, range, (UInt64)checkingTypes, options__handle__, orthography__handle__, wordCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange_UInt64_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selHandleTextCheckingResults_ForRange_Types_Options_Orthography_WordCount_XHandle, nsa_results.Handle, range, (UInt64)checkingTypes, options__handle__, orthography__handle__, wordCount);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			GC.KeepAlive (orthography);
		}
		[Export ("highlight:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Highlight (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selHighlight_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selHighlight_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("insertAdaptiveImageGlyph:replacementRange:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertAdaptiveImageGlyph (NSAdaptiveImageGlyph adaptiveImageGlyph, NSRange replacementRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var adaptiveImageGlyph__handle__ = adaptiveImageGlyph!.GetNonNullHandle (nameof (adaptiveImageGlyph));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selInsertAdaptiveImageGlyph_ReplacementRange_XHandle, adaptiveImageGlyph__handle__, replacementRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selInsertAdaptiveImageGlyph_ReplacementRange_XHandle, adaptiveImageGlyph__handle__, replacementRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (adaptiveImageGlyph);
		}
		[Export ("insertCompletion:forPartialWordRange:movement:isFinal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertCompletion (string completion, NSRange partialWordCharRange, nint movement, bool isFinal)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nscompletion = CFString.CreateNative (completion);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_IntPtr_bool (this.Handle, selInsertCompletion_ForPartialWordRange_Movement_IsFinal_XHandle, nscompletion, partialWordCharRange, movement, isFinal ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange_IntPtr_bool (&__objc_super__, selInsertCompletion_ForPartialWordRange_Movement_IsFinal_XHandle, nscompletion, partialWordCharRange, movement, isFinal ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscompletion);
		}
		[Export ("insertText:replacementRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertText (NSObject text, NSRange replacementRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selInsertText_ReplacementRange_XHandle, text__handle__, replacementRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selInsertText_ReplacementRange_XHandle, text__handle__, replacementRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (text);
		}
		/// <param name="insertString">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertText:")]
		[ObsoletedOSPlatform ("macos10.6")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertText (NSObject insertString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var insertString__handle__ = insertString!.GetNonNullHandle (nameof (insertString));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selInsertText_XHandle, insertString__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selInsertText_XHandle, insertString__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (insertString);
		}
		[Export ("invalidateTextContainerOrigin")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateTextContainerOrigin ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvalidateTextContainerOriginXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selInvalidateTextContainerOriginXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("isCoalescingUndo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCoalescingUndo ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCoalescingUndoXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCoalescingUndoXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("loosenKerning:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoosenKerning (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoosenKerning_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoosenKerning_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("lowerBaseline:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LowerBaseline (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLowerBaseline_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLowerBaseline_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		/// <param name="touchBar">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("touchBar:makeItemForIdentifier:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTouchBarItem? MakeItem (NSTouchBar touchBar, string identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var touchBar__handle__ = touchBar!.GetNonNullHandle (nameof (touchBar));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			NSTouchBarItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTouchBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTouchBar_MakeItemForIdentifier_XHandle, touchBar__handle__, nsidentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTouchBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTouchBar_MakeItemForIdentifier_XHandle, touchBar__handle__, nsidentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (touchBar);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		/// <param name="dropDestination">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("namesOfPromisedFilesDroppedAtDestination:")]
		[ObsoletedOSPlatform ("macos10.13", "Use NSFilePromiseProvider objects instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] NamesOfPromisedFilesDroppedAtDestination (NSUrl dropDestination)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var dropDestination__handle__ = dropDestination!.GetNonNullHandle (nameof (dropDestination));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNamesOfPromisedFilesDroppedAtDestination_XHandle, dropDestination__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNamesOfPromisedFilesDroppedAtDestination_XHandle, dropDestination__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dropDestination);
			return ret!;
		}
		[Export ("orderFrontLinkPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OrderFrontLinkPanel (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOrderFrontLinkPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOrderFrontLinkPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("orderFrontListPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OrderFrontListPanel (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOrderFrontListPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOrderFrontListPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("orderFrontSpacingPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OrderFrontSpacingPanel (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOrderFrontSpacingPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOrderFrontSpacingPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("orderFrontSubstitutionsPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OrderFrontSubstitutionsPanel (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOrderFrontSubstitutionsPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOrderFrontSubstitutionsPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("orderFrontTablePanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OrderFrontTablePanel (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOrderFrontTablePanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOrderFrontTablePanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("outline:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Outline (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOutline_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOutline_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("pasteAsPlainText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PasteAsPlainText (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPasteAsPlainText_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteAsPlainText_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("pasteAsRichText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PasteAsRichText (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPasteAsRichText_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteAsRichText_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("performFindPanelAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformFindPanelAction (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformFindPanelAction_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformFindPanelAction_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("performValidatedReplacementInRange:withAttributedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PerformValidatedReplacement (NSRange range, NSAttributedString attributedString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributedString__handle__ = attributedString!.GetNonNullHandle (nameof (attributedString));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NSRange_NativeHandle (this.Handle, selPerformValidatedReplacementInRange_WithAttributedString_XHandle, range, attributedString__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, selPerformValidatedReplacementInRange_WithAttributedString_XHandle, range, attributedString__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributedString);
			return ret != 0;
		}
		[Export ("quickLookPreviewableItemsInRanges:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray QuickLookPreviewableItemsInRanges (NSArray ranges)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ranges__handle__ = ranges!.GetNonNullHandle (nameof (ranges));
			NSArray? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selQuickLookPreviewableItemsInRanges_XHandle, ranges__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selQuickLookPreviewableItemsInRanges_XHandle, ranges__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ranges);
			return ret!;
		}
		[Export ("raiseBaseline:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RaiseBaseline (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRaiseBaseline_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRaiseBaseline_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("rangeForUserCharacterAttributeChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange RangeForUserCharacterAttributeChange ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selRangeForUserCharacterAttributeChangeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selRangeForUserCharacterAttributeChangeXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("rangeForUserCompletion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange RangeForUserCompletion ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selRangeForUserCompletionXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selRangeForUserCompletionXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("rangeForUserParagraphAttributeChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange RangeForUserParagraphAttributeChange ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selRangeForUserParagraphAttributeChangeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selRangeForUserParagraphAttributeChangeXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("rangeForUserTextChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange RangeForUserTextChange ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selRangeForUserTextChangeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selRangeForUserTextChangeXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("rangesForUserCharacterAttributeChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray? RangesForUserCharacterAttributeChange ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSArray ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRangesForUserCharacterAttributeChangeXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRangesForUserCharacterAttributeChangeXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("rangesForUserParagraphAttributeChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray? RangesForUserParagraphAttributeChange ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSArray ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRangesForUserParagraphAttributeChangeXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRangesForUserParagraphAttributeChangeXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("rangesForUserTextChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray? RangesForUserTextChange ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSArray ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRangesForUserTextChangeXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRangesForUserTextChangeXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("readSelectionFromPasteboard:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ReadSelectionFromPasteboard (NSPasteboard pboard, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReadSelectionFromPasteboard_Type_XHandle, pboard__handle__, nstype);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReadSelectionFromPasteboard_Type_XHandle, pboard__handle__, nstype);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pboard);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		[Export ("readSelectionFromPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ReadSelectionFromPasteboard (NSPasteboard pboard)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selReadSelectionFromPasteboard_XHandle, pboard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selReadSelectionFromPasteboard_XHandle, pboard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		[Export ("readablePasteboardTypes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ReadablePasteboardTypes ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReadablePasteboardTypesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReadablePasteboardTypesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("registerForServices")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterForServices ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selRegisterForServicesXHandle);
		}
		[Export ("replaceTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceTextContainer (NSTextContainer newContainer)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var newContainer__handle__ = newContainer!.GetNonNullHandle (nameof (newContainer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReplaceTextContainer_XHandle, newContainer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReplaceTextContainer_XHandle, newContainer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newContainer);
		}
		[Export ("rulerView:didAddMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RulerViewDidAddMarker (NSRulerView ruler, NSRulerMarker marker)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRulerView_DidAddMarker_XHandle, ruler__handle__, marker__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRulerView_DidAddMarker_XHandle, ruler__handle__, marker__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ruler);
			GC.KeepAlive (marker);
		}
		[Export ("rulerView:didMoveMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RulerViewDidMoveMarker (NSRulerView ruler, NSRulerMarker marker)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRulerView_DidMoveMarker_XHandle, ruler__handle__, marker__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRulerView_DidMoveMarker_XHandle, ruler__handle__, marker__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ruler);
			GC.KeepAlive (marker);
		}
		[Export ("rulerView:didRemoveMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RulerViewDidRemoveMarker (NSRulerView ruler, NSRulerMarker marker)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRulerView_DidRemoveMarker_XHandle, ruler__handle__, marker__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRulerView_DidRemoveMarker_XHandle, ruler__handle__, marker__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ruler);
			GC.KeepAlive (marker);
		}
		[Export ("rulerView:handleMouseDown:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RulerViewHandleMouseDown (NSRulerView ruler, NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRulerView_HandleMouseDown_XHandle, ruler__handle__, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRulerView_HandleMouseDown_XHandle, ruler__handle__, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ruler);
			GC.KeepAlive (theEvent);
		}
		[Export ("rulerView:shouldAddMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RulerViewShouldAddMarker (NSRulerView ruler, NSRulerMarker marker)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRulerView_ShouldAddMarker_XHandle, ruler__handle__, marker__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRulerView_ShouldAddMarker_XHandle, ruler__handle__, marker__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ruler);
			GC.KeepAlive (marker);
			return ret != 0;
		}
		[Export ("rulerView:shouldMoveMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RulerViewShouldMoveMarker (NSRulerView ruler, NSRulerMarker marker)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRulerView_ShouldMoveMarker_XHandle, ruler__handle__, marker__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRulerView_ShouldMoveMarker_XHandle, ruler__handle__, marker__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ruler);
			GC.KeepAlive (marker);
			return ret != 0;
		}
		[Export ("rulerView:shouldRemoveMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RulerViewShouldRemoveMarker (NSRulerView ruler, NSRulerMarker marker)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRulerView_ShouldRemoveMarker_XHandle, ruler__handle__, marker__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRulerView_ShouldRemoveMarker_XHandle, ruler__handle__, marker__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ruler);
			GC.KeepAlive (marker);
			return ret != 0;
		}
		[Export ("rulerView:willAddMarker:atLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RulerViewWillAddMarker (NSRulerView ruler, NSRulerMarker marker, nfloat location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_nfloat (this.Handle, selRulerView_WillAddMarker_AtLocation_XHandle, ruler__handle__, marker__handle__, location);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_NativeHandle_nfloat (&__objc_super__, selRulerView_WillAddMarker_AtLocation_XHandle, ruler__handle__, marker__handle__, location);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ruler);
			GC.KeepAlive (marker);
			return ret!;
		}
		[Export ("rulerView:willMoveMarker:toLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RulerViewWillMoveMarker (NSRulerView ruler, NSRulerMarker marker, nfloat location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ruler__handle__ = ruler!.GetNonNullHandle (nameof (ruler));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle_NativeHandle_nfloat (this.Handle, selRulerView_WillMoveMarker_ToLocation_XHandle, ruler__handle__, marker__handle__, location);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle_NativeHandle_nfloat (&__objc_super__, selRulerView_WillMoveMarker_ToLocation_XHandle, ruler__handle__, marker__handle__, location);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ruler);
			GC.KeepAlive (marker);
			return ret!;
		}
		[Export ("selectionAffinity")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSelectionAffinity SelectionAffinity ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSSelectionAffinity ret;
			if (IsDirectBinding) {
				ret = (NSSelectionAffinity) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSelectionAffinityXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSSelectionAffinity) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSelectionAffinityXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("selectionRangeForProposedRange:granularity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange SelectionRange (NSRange proposedCharRange, NSSelectionGranularity granularity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_UIntPtr (this.Handle, selSelectionRangeForProposedRange_Granularity_XHandle, proposedCharRange, (UIntPtr) (ulong) granularity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange_UIntPtr (&__objc_super__, selSelectionRangeForProposedRange_Granularity_XHandle, proposedCharRange, (UIntPtr) (ulong) granularity);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("setAlignment:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAlignmentRange (NSTextAlignment alignment, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NSRange (this.Handle, selSetAlignment_Range_XHandle, (UIntPtr) NSTextAlignmentExtensions.ToNative (alignment), range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NSRange (&__objc_super__, selSetAlignment_Range_XHandle, (UIntPtr) NSTextAlignmentExtensions.ToNative (alignment), range);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setBaseWritingDirection:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBaseWritingDirection (NSWritingDirection writingDirection, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (this.Handle, selSetBaseWritingDirection_Range_XHandle, (IntPtr) (long) writingDirection, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NSRange (&__objc_super__, selSetBaseWritingDirection_Range_XHandle, (IntPtr) (long) writingDirection, range);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setConstrainedFrameSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetConstrainedFrameSize (CGSize desiredSize)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetConstrainedFrameSize_XHandle, desiredSize);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetConstrainedFrameSize_XHandle, desiredSize);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setContentType:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetContentType (NSString contentType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContentType_XHandle, contentType__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContentType_XHandle, contentType__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
		}
		[Export ("setLayoutOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLayoutOrientation (NSTextLayoutOrientation theOrientation)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLayoutOrientation_XHandle, (IntPtr) (long) theOrientation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetLayoutOrientation_XHandle, (IntPtr) (long) theOrientation);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setMarkedText:selectedRange:replacementRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMarkedText (NSObject text, NSRange selectedRange, NSRange replacementRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var text__handle__ = text!.GetNonNullHandle (nameof (text));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NSRange (this.Handle, selSetMarkedText_SelectedRange_ReplacementRange_XHandle, text__handle__, selectedRange, replacementRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange_NSRange (&__objc_super__, selSetMarkedText_SelectedRange_ReplacementRange_XHandle, text__handle__, selectedRange, replacementRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (text);
		}
		/// <param name="string">To be added.</param><param name="selRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setMarkedText:selectedRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMarkedText (NSObject @string, NSRange selRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var @string__handle__ = @string!.GetNonNullHandle (nameof (@string));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, selSetMarkedText_SelectedRange_XHandle, @string__handle__, selRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selSetMarkedText_SelectedRange_XHandle, @string__handle__, selRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@string);
		}
		[Export ("setNeedsDisplayInRect:avoidAdditionalLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplay (CGRect rect, bool avoidAdditionalLayout)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_bool (this.Handle, selSetNeedsDisplayInRect_AvoidAdditionalLayout_XHandle, rect, avoidAdditionalLayout ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_bool (&__objc_super__, selSetNeedsDisplayInRect_AvoidAdditionalLayout_XHandle, rect, avoidAdditionalLayout ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setSelectedRange:affinity:stillSelecting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelectedRange (NSRange charRange, NSSelectionAffinity affinity, bool stillSelectingFlag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_UIntPtr_bool (this.Handle, selSetSelectedRange_Affinity_StillSelecting_XHandle, charRange, (UIntPtr) (ulong) affinity, stillSelectingFlag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_UIntPtr_bool (&__objc_super__, selSetSelectedRange_Affinity_StillSelecting_XHandle, charRange, (UIntPtr) (ulong) affinity, stillSelectingFlag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setSelectedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelectedRange (NSRange charRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetSelectedRange_XHandle, charRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selSetSelectedRange_XHandle, charRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setSelectedRanges:affinity:stillSelecting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelectedRanges (NSArray ranges, NSSelectionAffinity affinity, bool stillSelectingFlag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var ranges__handle__ = ranges!.GetNonNullHandle (nameof (ranges));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_bool (this.Handle, selSetSelectedRanges_Affinity_StillSelecting_XHandle, ranges__handle__, (UIntPtr) (ulong) affinity, stillSelectingFlag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_bool (&__objc_super__, selSetSelectedRanges_Affinity_StillSelecting_XHandle, ranges__handle__, (UIntPtr) (ulong) affinity, stillSelectingFlag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ranges);
		}
		[Export ("setSpellingState:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSpellingState (nint value, NSRange charRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NSRange (this.Handle, selSetSpellingState_Range_XHandle, value, charRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NSRange (&__objc_super__, selSetSpellingState_Range_XHandle, value, charRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("shouldChangeTextInRanges:replacementStrings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (NSArray affectedRanges, string[]? replacementStrings)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var affectedRanges__handle__ = affectedRanges!.GetNonNullHandle (nameof (affectedRanges));
			using var nsa_replacementStrings = NSArray.FromNullableStrings (replacementStrings);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selShouldChangeTextInRanges_ReplacementStrings_XHandle, affectedRanges__handle__, nsa_replacementStrings.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selShouldChangeTextInRanges_ReplacementStrings_XHandle, affectedRanges__handle__, nsa_replacementStrings.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (affectedRanges);
			return ret != 0;
		}
		[Export ("shouldChangeTextInRange:replacementString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (NSRange affectedCharRange, string? replacementString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsreplacementString = CFString.CreateNative (replacementString);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NSRange_NativeHandle (this.Handle, selShouldChangeTextInRange_ReplacementString_XHandle, affectedCharRange, nsreplacementString);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, selShouldChangeTextInRange_ReplacementString_XHandle, affectedCharRange, nsreplacementString);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsreplacementString);
			return ret != 0;
		}
		[Export ("showFindIndicatorForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowFindIndicatorForRange (NSRange charRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selShowFindIndicatorForRange_XHandle, charRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selShowFindIndicatorForRange_XHandle, charRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("smartDeleteRangeForProposedRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange SmartDeleteRangeForProposedRange (NSRange proposedCharRange)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange (this.Handle, selSmartDeleteRangeForProposedRange_XHandle, proposedCharRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange (&__objc_super__, selSmartDeleteRangeForProposedRange_XHandle, proposedCharRange);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("smartInsertForString:replacingRange:beforeString:afterString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SmartInsert (string pasteString, NSRange charRangeToReplace, out string? beforeString, out string? afterString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (pasteString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteString));
			NativeHandle beforeStringValue = IntPtr.Zero;
			NativeHandle afterStringValue = IntPtr.Zero;
			var nspasteString = CFString.CreateNative (pasteString);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_ref_NativeHandle_ref_NativeHandle (this.Handle, selSmartInsertForString_ReplacingRange_BeforeString_AfterString_XHandle, nspasteString, charRangeToReplace, &beforeStringValue, &afterStringValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange_ref_NativeHandle_ref_NativeHandle (&__objc_super__, selSmartInsertForString_ReplacingRange_BeforeString_AfterString_XHandle, nspasteString, charRangeToReplace, &beforeStringValue, &afterStringValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspasteString);
			beforeString = CFString.FromHandle (beforeStringValue)!;
			afterString = CFString.FromHandle (afterStringValue)!;
		}
		[Export ("smartInsertAfterStringForString:replacingRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SmartInsertAfter (string pasteString, NSRange charRangeToReplace)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (pasteString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteString));
			var nspasteString = CFString.CreateNative (pasteString);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange (this.Handle, selSmartInsertAfterStringForString_ReplacingRange_XHandle, nspasteString, charRangeToReplace), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selSmartInsertAfterStringForString_ReplacingRange_XHandle, nspasteString, charRangeToReplace), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspasteString);
			return ret!;
		}
		[Export ("smartInsertBeforeStringForString:replacingRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SmartInsertBefore (string pasteString, NSRange charRangeToReplace)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (pasteString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteString));
			var nspasteString = CFString.CreateNative (pasteString);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NSRange (this.Handle, selSmartInsertBeforeStringForString_ReplacingRange_XHandle, nspasteString, charRangeToReplace), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, selSmartInsertBeforeStringForString_ReplacingRange_XHandle, nspasteString, charRangeToReplace), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspasteString);
			return ret!;
		}
		[Export ("spellCheckerDocumentTag")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SpellCheckerDocumentTag ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSpellCheckerDocumentTagXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSpellCheckerDocumentTagXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("startSpeaking:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartSpeaking (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartSpeaking_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartSpeaking_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("stopSpeaking:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopSpeaking (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStopSpeaking_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStopSpeaking_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("tightenKerning:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TightenKerning (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTightenKerning_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTightenKerning_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleAutomaticDashSubstitution:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleAutomaticDashSubstitution (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleAutomaticDashSubstitution_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleAutomaticDashSubstitution_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleAutomaticDataDetection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleAutomaticDataDetection (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleAutomaticDataDetection_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleAutomaticDataDetection_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleAutomaticLinkDetection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleAutomaticLinkDetection (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleAutomaticLinkDetection_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleAutomaticLinkDetection_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleAutomaticQuoteSubstitution:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleAutomaticQuoteSubstitution (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleAutomaticQuoteSubstitution_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleAutomaticQuoteSubstitution_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleAutomaticSpellingCorrection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleAutomaticSpellingCorrection (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleAutomaticSpellingCorrection_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleAutomaticSpellingCorrection_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleAutomaticTextCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleAutomaticTextCompletion (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleAutomaticTextCompletion_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleAutomaticTextCompletion_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleAutomaticTextReplacement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleAutomaticTextReplacement (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleAutomaticTextReplacement_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleAutomaticTextReplacement_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleContinuousSpellChecking:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleContinuousSpellChecking (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleContinuousSpellChecking_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleContinuousSpellChecking_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleGrammarChecking:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleGrammarChecking (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleGrammarChecking_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleGrammarChecking_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleQuickLookPreviewPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleQuickLookPreviewPanel (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleQuickLookPreviewPanel_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleQuickLookPreviewPanel_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleSmartInsertDelete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleSmartInsertDelete (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleSmartInsertDelete_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleSmartInsertDelete_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("toggleTraditionalCharacterShape:")]
		[ObsoletedOSPlatform ("macos10.11", "Use unicode characters via the character palette.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleTraditionalCharacterShape (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selToggleTraditionalCharacterShape_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selToggleTraditionalCharacterShape_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("turnOffKerning:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TurnOffKerning (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTurnOffKerning_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTurnOffKerning_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("turnOffLigatures:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TurnOffLigatures (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTurnOffLigatures_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTurnOffLigatures_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("unmarkText")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnmarkText ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUnmarkTextXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUnmarkTextXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateCandidates")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateCandidates ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateCandidatesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateCandidatesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateDragTypeRegistration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateDragTypeRegistration ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateDragTypeRegistrationXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateDragTypeRegistrationXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateFontPanel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFontPanel ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateFontPanelXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateFontPanelXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateInsertionPointStateAndRestartTimer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateInsertionPointStateAndRestartTimer (bool restartFlag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selUpdateInsertionPointStateAndRestartTimer_XHandle, restartFlag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selUpdateInsertionPointStateAndRestartTimer_XHandle, restartFlag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateQuickLookPreviewPanel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateQuickLookPreviewPanel ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateQuickLookPreviewPanelXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateQuickLookPreviewPanelXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateRuler")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateRuler ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateRulerXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateRulerXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateTextTouchBarItems")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateTextTouchBarItems ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateTextTouchBarItemsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateTextTouchBarItemsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("updateTouchBarItemIdentifiers")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateTouchBarItemIdentifiers ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateTouchBarItemIdentifiersXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateTouchBarItemIdentifiersXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("useAllLigatures:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseAllLigatures (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUseAllLigatures_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUseAllLigatures_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("useStandardKerning:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseStandardKerning (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUseStandardKerning_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUseStandardKerning_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("useStandardLigatures:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UseStandardLigatures (NSObject? sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUseStandardLigatures_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUseStandardLigatures_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("validRequestorForSendType:returnType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ValidRequestorForSendType (string? sendType, string? returnType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nssendType = CFString.CreateNative (sendType);
			var nsreturnType = CFString.CreateNative (returnType);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selValidRequestorForSendType_ReturnType_XHandle, nssendType, nsreturnType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selValidRequestorForSendType_ReturnType_XHandle, nssendType, nsreturnType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssendType);
			CFString.ReleaseNative (nsreturnType);
			return ret!;
		}
		/// <param name="menuItem">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateMenuItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateMenuItem (NSMenuItem menuItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menuItem__handle__ = menuItem!.GetNonNullHandle (nameof (menuItem));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selValidateMenuItem_XHandle, menuItem__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateMenuItem_XHandle, menuItem__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menuItem);
			return ret != 0;
		}
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("validateUserInterfaceItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ValidateUserInterfaceItem (INSValidatedUserInterfaceItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selValidateUserInterfaceItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selValidateUserInterfaceItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret != 0;
		}
		[Export ("writablePasteboardTypes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] WritablePasteboardTypes ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWritablePasteboardTypesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWritablePasteboardTypesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("writeSelectionToPasteboard:type:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteSelectionToPasteboard (NSPasteboard pboard, string type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWriteSelectionToPasteboard_Type_XHandle, pboard__handle__, nstype);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWriteSelectionToPasteboard_Type_XHandle, pboard__handle__, nstype);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pboard);
			CFString.ReleaseNative (nstype);
			return ret != 0;
		}
		[Export ("writeSelectionToPasteboard:types:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteSelectionToPasteboard (NSPasteboard pboard, string[] types)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var pboard__handle__ = pboard!.GetNonNullHandle (nameof (pboard));
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_types = NSArray.FromStrings (types);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWriteSelectionToPasteboard_Types_XHandle, pboard__handle__, nsa_types.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWriteSelectionToPasteboard_Types_XHandle, pboard__handle__, nsa_types.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pboard);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptsGlyphInfo {
			[Export ("acceptsGlyphInfo")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAcceptsGlyphInfoXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAcceptsGlyphInfoXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAcceptsGlyphInfo:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAcceptsGlyphInfo_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAcceptsGlyphInfo_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityFocused {
			[Export ("isAccessibilityFocused")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityFocusedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityFocusedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual CGRect AccessibilityFrame {
			[Export ("accessibilityFrame")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selAccessibilityFrameXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selAccessibilityFrameXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selAccessibilityFrameXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selAccessibilityFrameXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string AccessibilityIdentifier {
			[Export ("accessibilityIdentifier")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityParent {
			[Export ("accessibilityParent")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityParentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityParentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityValue {
			[Export ("accessibilityValue")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSRange AccessibilityVisibleCharacterRange {
			[Export ("accessibilityVisibleCharacterRange")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selAccessibilityVisibleCharacterRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleCharacterRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? AllowedInputSourceLocales {
			[Export ("allowedInputSourceLocales")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllowedInputSourceLocalesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllowedInputSourceLocalesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAllowedInputSourceLocales:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = NSArray.FromNullableStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAllowedInputSourceLocales_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAllowedInputSourceLocales_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSWritingToolsResultOptions AllowedWritingToolsResultOptions {
			[Export ("allowedWritingToolsResultOptions")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSWritingToolsResultOptions ret;
				if (IsDirectBinding) {
					ret = (NSWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAllowedWritingToolsResultOptionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSWritingToolsResultOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAllowedWritingToolsResultOptionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAllowedWritingToolsResultOptions:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetAllowedWritingToolsResultOptions_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetAllowedWritingToolsResultOptions_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsCharacterPickerTouchBarItem {
			[Export ("allowsCharacterPickerTouchBarItem")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCharacterPickerTouchBarItemXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsCharacterPickerTouchBarItemXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsCharacterPickerTouchBarItem:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsCharacterPickerTouchBarItem_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsCharacterPickerTouchBarItem_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsDocumentBackgroundColorChange {
			[Export ("allowsDocumentBackgroundColorChange")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsDocumentBackgroundColorChangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsDocumentBackgroundColorChangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsDocumentBackgroundColorChange:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsDocumentBackgroundColorChange_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsDocumentBackgroundColorChange_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsImageEditing {
			[Export ("allowsImageEditing")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsImageEditingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsImageEditingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsImageEditing:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsImageEditing_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsImageEditing_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsUndo {
			[Export ("allowsUndo")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsUndoXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsUndoXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsUndo:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsUndo_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsUndo_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSAttributedString AttributedString {
			[Export ("attributedString")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
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
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticDashSubstitutionEnabled {
			[Export ("isAutomaticDashSubstitutionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutomaticDashSubstitutionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutomaticDashSubstitutionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticDashSubstitutionEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticDashSubstitutionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticDashSubstitutionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticDataDetectionEnabled {
			[Export ("isAutomaticDataDetectionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutomaticDataDetectionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutomaticDataDetectionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticDataDetectionEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticDataDetectionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticDataDetectionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticLinkDetectionEnabled {
			[Export ("isAutomaticLinkDetectionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutomaticLinkDetectionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutomaticLinkDetectionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticLinkDetectionEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticLinkDetectionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticLinkDetectionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticQuoteSubstitutionEnabled {
			[Export ("isAutomaticQuoteSubstitutionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutomaticQuoteSubstitutionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutomaticQuoteSubstitutionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticQuoteSubstitutionEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticQuoteSubstitutionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticQuoteSubstitutionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticSpellingCorrectionEnabled {
			[Export ("isAutomaticSpellingCorrectionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutomaticSpellingCorrectionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutomaticSpellingCorrectionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticSpellingCorrectionEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticSpellingCorrectionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticSpellingCorrectionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticTextCompletionEnabled {
			[Export ("isAutomaticTextCompletionEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutomaticTextCompletionEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutomaticTextCompletionEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticTextCompletionEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticTextCompletionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticTextCompletionEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutomaticTextReplacementEnabled {
			[Export ("isAutomaticTextReplacementEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAutomaticTextReplacementEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAutomaticTextReplacementEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutomaticTextReplacementEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutomaticTextReplacementEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutomaticTextReplacementEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor BackgroundColor {
			[Export ("backgroundColor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackgroundColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackgroundColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundColor:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBackgroundColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBackgroundColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCandidateListTouchBarItem? CandidateListTouchBarItem {
			[Export ("candidateListTouchBarItem", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCandidateListTouchBarItem? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCandidateListTouchBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCandidateListTouchBarItemXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCandidateListTouchBarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCandidateListTouchBarItemXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContentType ContentType {
			get {
				return NSTextContentTypeExtensions.GetValue (GetContentType ()!);
			}
			set {
				SetContentType (value.GetConstant()!);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContinuousSpellCheckingEnabled {
			[Export ("isContinuousSpellCheckingEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsContinuousSpellCheckingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsContinuousSpellCheckingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setContinuousSpellCheckingEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetContinuousSpellCheckingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetContinuousSpellCheckingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual nint ConversationIdentifier {
			[Export ("conversationIdentifier")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selConversationIdentifierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selConversationIdentifierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSParagraphStyle? DefaultParagraphStyle {
			[Export ("defaultParagraphStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSParagraphStyle? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSParagraphStyle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultParagraphStyleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSParagraphStyle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultParagraphStyleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDefaultParagraphStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDefaultParagraphStyle_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDefaultParagraphStyle_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSTextViewDelegate Delegate {
			get {
				return (WeakDelegate as INSTextViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplaysLinkToolTips {
			[Export ("displaysLinkToolTips")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisplaysLinkToolTipsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDisplaysLinkToolTipsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDisplaysLinkToolTips:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisplaysLinkToolTips_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDisplaysLinkToolTips_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual CGRect DocumentVisibleRect {
			[Export ("documentVisibleRect")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selDocumentVisibleRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selDocumentVisibleRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selDocumentVisibleRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selDocumentVisibleRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawsBackground {
			[Export ("drawsBackground")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDrawsBackgroundXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDrawsBackgroundXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDrawsBackground:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDrawsBackground_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDrawsBackground_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Editable {
			[Export ("isEditable")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEditableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEditableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEditable:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEditable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEditable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingTypes EnabledTextCheckingTypes {
			[Export ("enabledTextCheckingTypes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextCheckingTypes ret;
				if (IsDirectBinding) {
					ret = (NSTextCheckingTypes) global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selEnabledTextCheckingTypesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTextCheckingTypes) global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selEnabledTextCheckingTypesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setEnabledTextCheckingTypes:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetEnabledTextCheckingTypes_XHandle, (UInt64)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetEnabledTextCheckingTypes_XHandle, (UInt64)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FieldEditor {
			[Export ("isFieldEditor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFieldEditorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFieldEditorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setFieldEditor:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetFieldEditor_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetFieldEditor_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GrammarCheckingEnabled {
			[Export ("isGrammarCheckingEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsGrammarCheckingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsGrammarCheckingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setGrammarCheckingEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetGrammarCheckingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetGrammarCheckingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool HasMarkedText {
			[Export ("hasMarkedText")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasMarkedTextXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasMarkedTextXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IgnoreModifierKeysWhileDragging {
			[Export ("ignoreModifierKeysWhileDragging")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIgnoreModifierKeysWhileDraggingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIgnoreModifierKeysWhileDraggingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ImportsGraphics {
			[Export ("importsGraphics")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selImportsGraphicsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selImportsGraphicsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setImportsGraphics:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetImportsGraphics_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetImportsGraphics_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSTextInputTraitType InlinePredictionType {
			[Export ("inlinePredictionType", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextInputTraitType ret;
				if (IsDirectBinding) {
					ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInlinePredictionTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selInlinePredictionTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInlinePredictionType:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetInlinePredictionType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetInlinePredictionType_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor? InsertionPointColor {
			[Export ("insertionPointColor")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInsertionPointColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInsertionPointColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInsertionPointColor:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInsertionPointColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInsertionPointColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsIncrementalSearchingEnabled {
			[Export ("isIncrementalSearchingEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsIncrementalSearchingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsIncrementalSearchingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setIncrementalSearchingEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIncrementalSearchingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetIncrementalSearchingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLayoutManager? LayoutManager {
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSTextLayoutOrientation LayoutOrientation {
			[Export ("layoutOrientation")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextLayoutOrientation ret;
				if (IsDirectBinding) {
					ret = (NSTextLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLayoutOrientationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTextLayoutOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selLayoutOrientationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? LinkTextAttributes {
			[Export ("linkTextAttributes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLinkTextAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLinkTextAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLinkTextAttributes:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLinkTextAttributes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLinkTextAttributes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSRange MarkedRange {
			[Export ("markedRange")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selMarkedRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selMarkedRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? MarkedTextAttributes {
			[Export ("markedTextAttributes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMarkedTextAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMarkedTextAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMarkedTextAttributes:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMarkedTextAttributes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMarkedTextAttributes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSTextInputTraitType MathExpressionCompletionType {
			[Export ("mathExpressionCompletionType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextInputTraitType ret;
				if (IsDirectBinding) {
					ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMathExpressionCompletionTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTextInputTraitType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMathExpressionCompletionTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMathExpressionCompletionType:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMathExpressionCompletionType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMathExpressionCompletionType_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSTextCursorAccessoryPlacement PreferredTextAccessoryPlacement {
			[Export ("preferredTextAccessoryPlacement")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextCursorAccessoryPlacement ret;
				if (IsDirectBinding) {
					ret = (NSTextCursorAccessoryPlacement) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPreferredTextAccessoryPlacementXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTextCursorAccessoryPlacement) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPreferredTextAccessoryPlacementXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RichText {
			[Export ("isRichText")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRichTextXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRichTextXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRichText:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRichText_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRichText_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RulerVisible {
			[Export ("isRulerVisible")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRulerVisibleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRulerVisibleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRulerVisible:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRulerVisible_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRulerVisible_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Selectable {
			[Export ("isSelectable")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSelectableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSelectableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSelectable:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSelectable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSelectable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray SelectedRanges {
			[Export ("selectedRanges", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedRangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedRangesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectedRanges:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSelectedRanges_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSelectedRanges_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary SelectedTextAttributes {
			[Export ("selectedTextAttributes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedTextAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedTextAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectedTextAttributes:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSelectedTextAttributes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSelectedTextAttributes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSelectionGranularity SelectionGranularity {
			[Export ("selectionGranularity")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSelectionGranularity ret;
				if (IsDirectBinding) {
					ret = (NSSelectionGranularity) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSelectionGranularityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSSelectionGranularity) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSelectionGranularityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectionGranularity:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetSelectionGranularity_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetSelectionGranularity_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDrawInsertionPoint {
			[Export ("shouldDrawInsertionPoint")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldDrawInsertionPointXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldDrawInsertionPointXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SmartInsertDeleteEnabled {
			[Export ("smartInsertDeleteEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSmartInsertDeleteEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSmartInsertDeleteEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSmartInsertDeleteEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSmartInsertDeleteEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSmartInsertDeleteEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StronglyReferencesTextStorage {
			[Export ("stronglyReferencesTextStorage")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selStronglyReferencesTextStorageXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual bool SupportsAdaptiveImageGlyph {
			[Export ("supportsAdaptiveImageGlyph")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos15.0")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSupportsAdaptiveImageGlyphXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSupportsAdaptiveImageGlyphXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContainer? TextContainer {
			[Export ("textContainer")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextContainerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextContainerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextContainer:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextContainer_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextContainer_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize TextContainerInset {
			[Export ("textContainerInset")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selTextContainerInsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selTextContainerInsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTextContainerInset:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetTextContainerInset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetTextContainerInset_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint TextContainerOrigin {
			[Export ("textContainerOrigin")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selTextContainerOriginXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selTextContainerOriginXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextContentStorage_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContentStorage? TextContentStorage {
			[Export ("textContentStorage", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextContentStorage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextContentStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextContentStorageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextContentStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextContentStorageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextContentStorage_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSDictionary<NSString, NSObject> TextHighlightAttributes {
			[Export ("textHighlightAttributes", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary<NSString, NSObject>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextHighlightAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextHighlightAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextHighlightAttributes:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextHighlightAttributes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextHighlightAttributes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextLayoutManager_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLayoutManager? TextLayoutManager {
			[Export ("textLayoutManager", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextLayoutManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextLayoutManagerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextLayoutManagerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextLayoutManager_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextStorage? TextStorage {
			[Export ("textStorage")]
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
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary TypingAttributes {
			[Export ("typingAttributes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTypingAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTypingAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTypingAttributes:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTypingAttributes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTypingAttributes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual CGRect UnionRectInVisibleSelectedRange {
			[Export ("unionRectInVisibleSelectedRange")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selUnionRectInVisibleSelectedRangeXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selUnionRectInVisibleSelectedRangeXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selUnionRectInVisibleSelectedRangeXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selUnionRectInVisibleSelectedRangeXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool UsesAdaptiveColorMappingForDarkAppearance {
			[Export ("usesAdaptiveColorMappingForDarkAppearance")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesAdaptiveColorMappingForDarkAppearanceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesAdaptiveColorMappingForDarkAppearanceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesAdaptiveColorMappingForDarkAppearance:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesAdaptiveColorMappingForDarkAppearance_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesAdaptiveColorMappingForDarkAppearance_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesFindBar {
			[Export ("usesFindBar")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesFindBarXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesFindBarXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesFindBar:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesFindBar_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesFindBar_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesFindPanel {
			[Export ("usesFindPanel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesFindPanelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesFindPanelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesFindPanel:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesFindPanel_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesFindPanel_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesFontPanel {
			[Export ("usesFontPanel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesFontPanelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesFontPanelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesFontPanel:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesFontPanel_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesFontPanel_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesInspectorBar {
			[Export ("usesInspectorBar")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesInspectorBarXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesInspectorBarXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesInspectorBar:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesInspectorBar_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesInspectorBar_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesRolloverButtonForSelection {
			[Export ("usesRolloverButtonForSelection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesRolloverButtonForSelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesRolloverButtonForSelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesRolloverButtonForSelection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesRolloverButtonForSelection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesRolloverButtonForSelection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesRuler {
			[Export ("usesRuler")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesRulerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesRulerXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesRuler:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesRuler_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesRuler_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSString[] ValidAttributesForMarkedText {
			[Export ("validAttributesForMarkedText")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selValidAttributesForMarkedTextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selValidAttributesForMarkedTextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
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
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
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
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSWindowLevel WindowLevel {
			[Export ("windowLevel")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSWindowLevel ret;
				if (IsDirectBinding) {
					ret = (NSWindowLevel) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWindowLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSWindowLevel) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selWindowLevelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual bool WritingToolsActive {
			[Export ("isWritingToolsActive")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsWritingToolsActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsWritingToolsActiveXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSWritingToolsBehavior WritingToolsBehavior {
			[Export ("writingToolsBehavior")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSWritingToolsBehavior ret;
				if (IsDirectBinding) {
					ret = (NSWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWritingToolsBehaviorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSWritingToolsBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selWritingToolsBehaviorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setWritingToolsBehavior:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetWritingToolsBehavior_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetWritingToolsBehavior_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeSelectionNotification;
		/// <summary>Notification constant for DidChangeSelection</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeSelection(NSObject,EventHandler{NSTextViewDidChangeSelectionEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeSelection(EventHandler{NSTextViewDidChangeSelectionEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSTextView.Notifications.ObserveDidChangeSelection ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSTextView.NSTextViewDidChangeSelectionEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSTextView.Notifications.ObserveDidChangeSelection (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSTextView.DidChangeSelectionNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeSelection", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeSelection", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSTextView.DidChangeSelectionNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSTextViewDidChangeSelectionNotification",  "AppKit")]
		[Advice ("Use NSTextView.Notifications.ObserveDidChangeSelection helper method instead.")]
		public static NSString DidChangeSelectionNotification {
			get {
				if (_DidChangeSelectionNotification is null)
					_DidChangeSelectionNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextViewDidChangeSelectionNotification")!;
				return _DidChangeSelectionNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeTypingAttributesNotification;
		/// <summary>Notification constant for DidChangeTypingAttributes</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeTypingAttributes(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeTypingAttributes(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSTextView.Notifications.ObserveDidChangeTypingAttributes ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSTextView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSTextView.Notifications.ObserveDidChangeTypingAttributes (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSTextView.DidChangeTypingAttributesNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeTypingAttributes", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeTypingAttributes", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSTextView.DidChangeTypingAttributesNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSTextViewDidChangeTypingAttributesNotification",  "AppKit")]
		[Advice ("Use NSTextView.Notifications.ObserveDidChangeTypingAttributes helper method instead.")]
		public static NSString DidChangeTypingAttributesNotification {
			get {
				if (_DidChangeTypingAttributesNotification is null)
					_DidChangeTypingAttributesNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextViewDidChangeTypingAttributesNotification")!;
				return _DidChangeTypingAttributesNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidSwitchToNSLayoutManagerNotification;
		/// <summary>Notification constant for DidSwitchToNSLayoutManager</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidSwitchToNSLayoutManager(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidSwitchToNSLayoutManager(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSTextView.Notifications.ObserveDidSwitchToNSLayoutManager ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSTextView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSTextView.Notifications.ObserveDidSwitchToNSLayoutManager (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSTextView.DidSwitchToNSLayoutManagerNotification, (notification) => { Console.WriteLine ("Received the notification DidSwitchToNSLayoutManager", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidSwitchToNSLayoutManager", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSTextView.DidSwitchToNSLayoutManagerNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSTextViewDidSwitchToNSLayoutManagerNotification",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSTextView.Notifications.ObserveDidSwitchToNSLayoutManager helper method instead.")]
		public static NSString DidSwitchToNSLayoutManagerNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DidSwitchToNSLayoutManagerNotification is null)
					_DidSwitchToNSLayoutManagerNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextViewDidSwitchToNSLayoutManagerNotification")!;
				return _DidSwitchToNSLayoutManagerNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillChangeNotifyingTextViewNotification;
		/// <summary>Notification constant for WillChangeNotifyingTextView</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillChangeNotifyingTextView(NSObject,EventHandler{NSTextViewWillChangeNotifyingTextViewEventArgs})" />
		///     or <see cref="Notifications.ObserveWillChangeNotifyingTextView(EventHandler{NSTextViewWillChangeNotifyingTextViewEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSTextView.Notifications.ObserveWillChangeNotifyingTextView ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSTextView.NSTextViewWillChangeNotifyingTextViewEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSTextView.Notifications.ObserveWillChangeNotifyingTextView (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSTextView.WillChangeNotifyingTextViewNotification, (notification) => { Console.WriteLine ("Received the notification WillChangeNotifyingTextView", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillChangeNotifyingTextView", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSTextView.WillChangeNotifyingTextViewNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSTextViewWillChangeNotifyingTextViewNotification",  "AppKit")]
		[Advice ("Use NSTextView.Notifications.ObserveWillChangeNotifyingTextView helper method instead.")]
		public static NSString WillChangeNotifyingTextViewNotification {
			get {
				if (_WillChangeNotifyingTextViewNotification is null)
					_WillChangeNotifyingTextViewNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextViewWillChangeNotifyingTextViewNotification")!;
				return _WillChangeNotifyingTextViewNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WillSwitchToNSLayoutManagerNotification;
		/// <summary>Notification constant for WillSwitchToNSLayoutManager</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWillSwitchToNSLayoutManager(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWillSwitchToNSLayoutManager(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSTextView.Notifications.ObserveWillSwitchToNSLayoutManager ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSTextView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSTextView.Notifications.ObserveWillSwitchToNSLayoutManager (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSTextView.WillSwitchToNSLayoutManagerNotification, (notification) => { Console.WriteLine ("Received the notification WillSwitchToNSLayoutManager", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WillSwitchToNSLayoutManager", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSTextView.WillSwitchToNSLayoutManagerNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSTextViewWillSwitchToNSLayoutManagerNotification",  "AppKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSTextView.Notifications.ObserveWillSwitchToNSLayoutManager helper method instead.")]
		public static NSString WillSwitchToNSLayoutManagerNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_WillSwitchToNSLayoutManagerNotification is null)
					_WillSwitchToNSLayoutManagerNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSTextViewWillSwitchToNSLayoutManagerNotification")!;
				return _WillSwitchToNSLayoutManagerNotification;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal override Type GetInternalEventDelegateType
		{
			get { return typeof (_NSTextViewDelegate); }
		}
		internal override _NSTextDelegate CreateInternalEventDelegateType ()
		{
			return (_NSTextDelegate)(new _NSTextViewDelegate());
		}
		internal _NSTextViewDelegate EnsureNSTextViewDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSTextViewDelegate;
			if (del is null){
				del = (_NSTextViewDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSTextViewDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSTextViewDelegate : _NSTextDelegate, INSTextViewDelegate { 
			public _NSTextViewDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSTextViewDelegate))]
			static _NSTextViewDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<NSTextViewClickedEventArgs>? cellClicked;
			[Export ("textView:clickedOnCell:inRect:atIndex:")]
			public void CellClicked (NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, UIntPtr charIndex)
			{
				var handler = cellClicked;
				if (handler is not null){
					var args = new NSTextViewClickedEventArgs (cell, cellFrame, charIndex);
					handler (textView, args);
				}
			}
			internal EventHandler<NSTextViewDoubleClickEventArgs>? cellDoubleClicked;
			[Export ("textView:doubleClickedOnCell:inRect:atIndex:")]
			public void CellDoubleClicked (NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, UIntPtr charIndex)
			{
				var handler = cellDoubleClicked;
				if (handler is not null){
					var args = new NSTextViewDoubleClickEventArgs (cell, cellFrame, charIndex);
					handler (textView, args);
				}
			}
			internal EventHandler? didChangeSelection;
			[Export ("textViewDidChangeSelection:")]
			public void DidChangeSelection (NSNotification notification)
			{
				var handler = didChangeSelection;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal EventHandler? didChangeTypingAttributes;
			[Export ("textViewDidChangeTypingAttributes:")]
			public void DidChangeTypingAttributes (NSNotification notification)
			{
				var handler = didChangeTypingAttributes;
				if (handler is not null){
					handler (notification, EventArgs.Empty);
				}
			}
			internal NSTextViewTextChecked? didCheckText;
			[Export ("textView:didCheckTextInRange:types:options:results:orthography:wordCount:")]
			public NSTextCheckingResult[] DidCheckText (NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, IntPtr wordCount)
			{
				var handler = didCheckText;
				if (handler is not null)
					return handler (view, range, checkingTypes, options, results, orthography, wordCount);
				return results!;
			}
			internal NSTextViewSelectorCommand? doCommandBySelector;
			[Export ("textView:doCommandBySelector:")]
			public bool DoCommandBySelector (NSTextView textView, Selector commandSelector)
			{
				var handler = doCommandBySelector;
				if (handler is not null)
					return handler (textView, commandSelector);
				return false!;
			}
			internal EventHandler<NSTextViewDraggedCellEventArgs>? draggedCell;
			[Export ("textView:draggedCell:inRect:event:atIndex:")]
			public void DraggedCell (NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theEvent, UIntPtr charIndex)
			{
				var handler = draggedCell;
				if (handler is not null){
					var args = new NSTextViewDraggedCellEventArgs (cell, rect, theEvent, charIndex);
					handler (view, args);
				}
			}
			internal NSTextViewGetCandidates? getCandidates;
			[Export ("textView:candidatesForSelectedRange:")]
			public NSObject[]? GetCandidates (NSTextView textView, NSRange selectedRange)
			{
				var handler = getCandidates;
				if (handler is not null)
					return handler (textView, selectedRange);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal NSTextViewCompletion? getCompletions;
			[Export ("textView:completions:forPartialWordRange:indexOfSelectedItem:")]
			public String[] GetCompletions (NSTextView textView, String[] words, NSRange charRange, ref IntPtr index)
			{
				var handler = getCompletions;
				if (handler is not null)
					return handler (textView, words, charRange, ref index);
				return null!;
			}
			internal NSTextViewTextCheckingResults? getTextCheckingCandidates;
			[Export ("textView:candidates:forSelectedRange:")]
			public NSTextCheckingResult[] GetTextCheckingCandidates (NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
			{
				var handler = getTextCheckingCandidates;
				if (handler is not null)
					return handler (textView, candidates, selectedRange);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal NSTextViewGetUndoManager? getUndoManager;
			[Export ("undoManagerForTextView:")]
			public NSUndoManager GetUndoManager (NSTextView view)
			{
				var handler = getUndoManager;
				if (handler is not null)
					return handler (view);
				return null!;
			}
			internal NSTextViewCellPosition? getWritablePasteboardTypes;
			[Export ("textView:writablePasteboardTypesForCell:atIndex:")]
			public String[] GetWritablePasteboardTypes (NSTextView view, NSTextAttachmentCell forCell, UIntPtr charIndex)
			{
				var handler = getWritablePasteboardTypes;
				if (handler is not null)
					return handler (view, forCell, charIndex);
				return null!;
			}
			internal NSTextViewRange? getWritingToolsIgnoredRangesInEnclosingRange;
			[Export ("textView:writingToolsIgnoredRangesInEnclosingRange:")]
			public NSValue[] GetWritingToolsIgnoredRangesInEnclosingRange (NSTextView textView, NSRange enclosingRange)
			{
				var handler = getWritingToolsIgnoredRangesInEnclosingRange;
				if (handler is not null)
					return handler (textView, enclosingRange);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal NSTextViewLink? linkClicked;
			[Export ("textView:clickedOnLink:atIndex:")]
			public bool LinkClicked (NSTextView textView, NSObject link, UIntPtr charIndex)
			{
				var handler = linkClicked;
				if (handler is not null)
					return handler (textView, link, charIndex);
				return false!;
			}
			internal NSTextViewEventMenu? menuForEvent;
			[Export ("textView:menu:forEvent:atIndex:")]
			public NSMenu MenuForEvent (NSTextView view, NSMenu menu, NSEvent theEvent, UIntPtr charIndex)
			{
				var handler = menuForEvent;
				if (handler is not null)
					return handler (view, menu, theEvent, charIndex);
				return menu!;
			}
			internal NSTextViewChangeText? shouldChangeTextInRange;
			[Export ("textView:shouldChangeTextInRange:replacementString:")]
			public bool ShouldChangeTextInRange (NSTextView textView, NSRange affectedCharRange, string replacementString)
			{
				var handler = shouldChangeTextInRange;
				if (handler is not null)
					return handler (textView, affectedCharRange, replacementString);
				return true!;
			}
			internal NSTextViewSelectionShouldChange? shouldChangeTextInRanges;
			[Export ("textView:shouldChangeTextInRanges:replacementStrings:")]
			public bool ShouldChangeTextInRanges (NSTextView textView, NSValue[] affectedRanges, String[] replacementStrings)
			{
				var handler = shouldChangeTextInRanges;
				if (handler is not null)
					return handler (textView, affectedRanges, replacementStrings);
				return true!;
			}
			internal NSTextViewTypeAttribute? shouldChangeTypingAttributes;
			[Export ("textView:shouldChangeTypingAttributes:toAttributes:")]
			public NSDictionary ShouldChangeTypingAttributes (NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
			{
				var handler = shouldChangeTypingAttributes;
				if (handler is not null)
					return handler (textView, oldTypingAttributes, newTypingAttributes);
				return newTypingAttributes!;
			}
			internal NSTextViewSelectCandidate? shouldSelectCandidates;
			[Export ("textView:shouldSelectCandidateAtIndex:")]
			public bool ShouldSelectCandidates (NSTextView textView, UIntPtr index)
			{
				var handler = shouldSelectCandidates;
				if (handler is not null)
					return handler (textView, index);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal NSTextViewSpellingQuery? shouldSetSpellingState;
			[Export ("textView:shouldSetSpellingState:range:")]
			public IntPtr ShouldSetSpellingState (NSTextView textView, IntPtr value, NSRange affectedCharRange)
			{
				var handler = shouldSetSpellingState;
				if (handler is not null)
					return handler (textView, value, affectedCharRange);
				return ((nint) (0));
			}
			internal NSTextViewUpdateTouchBarItemIdentifiers? shouldUpdateTouchBarItemIdentifiers;
			[Export ("textView:shouldUpdateTouchBarItemIdentifiers:")]
			public String[] ShouldUpdateTouchBarItemIdentifiers (NSTextView textView, String[] identifiers)
			{
				var handler = shouldUpdateTouchBarItemIdentifiers;
				if (handler is not null)
					return handler (textView, identifiers);
				throw new You_Should_Not_Call_base_In_This_Method ();
			}
			internal NSTextViewSelectionChange? willChangeSelection;
			[Export ("textView:willChangeSelectionFromCharacterRange:toCharacterRange:")]
			public NSRange WillChangeSelection (NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
			{
				var handler = willChangeSelection;
				if (handler is not null)
					return handler (textView, oldSelectedCharRange, newSelectedCharRange);
				return newSelectedCharRange!;
			}
			internal NSTextViewSelectionWillChange? willChangeSelectionFromRanges;
			[Export ("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:")]
			public NSValue[] WillChangeSelectionFromRanges (NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
			{
				var handler = willChangeSelectionFromRanges;
				if (handler is not null)
					return handler (textView, oldSelectedCharRanges, newSelectedCharRanges);
				return newSelectedCharRanges!;
			}
			internal NSTextViewOnTextCheck? willCheckText;
			[Export ("textView:willCheckTextInRange:options:types:")]
			public NSDictionary WillCheckText (NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
			{
				var handler = willCheckText;
				if (handler is not null)
					return handler (view, range, options, checkingTypes);
				return options!;
			}
			internal NSTextViewTooltip? willDisplayToolTip;
			[Export ("textView:willDisplayToolTip:forCharacterAtIndex:")]
			public string? WillDisplayToolTip (NSTextView textView, string tooltip, UIntPtr characterIndex)
			{
				var handler = willDisplayToolTip;
				if (handler is not null)
					return handler (textView, tooltip, characterIndex);
				return tooltip!;
			}
			internal NSTextViewCellPasteboard? writeCell;
			[Export ("textView:writeCell:atIndex:toPasteboard:type:")]
			public bool WriteCell (NSTextView view, NSTextAttachmentCell cell, UIntPtr charIndex, NSPasteboard pboard, string type)
			{
				var handler = writeCell;
				if (handler is not null)
					return handler (view, cell, charIndex, pboard, type);
				return true!;
			}
			internal EventHandler? writingToolsDidEnd;
			[Export ("textViewWritingToolsDidEnd:")]
			public void WritingToolsDidEnd (NSTextView textView)
			{
				var handler = writingToolsDidEnd;
				if (handler is not null){
					handler (textView, EventArgs.Empty);
				}
			}
			internal EventHandler? writingToolsWillBegin;
			[Export ("textViewWritingToolsWillBegin:")]
			public void WritingToolsWillBegin (NSTextView textView)
			{
				var handler = writingToolsWillBegin;
				if (handler is not null){
					handler (textView, EventArgs.Empty);
				}
			}
			static NativeHandle selGetCandidatesHandle = Selector.GetHandle ("textView:candidatesForSelectedRange:");
			static NativeHandle selGetTextCheckingCandidatesHandle = Selector.GetHandle ("textView:candidates:forSelectedRange:");
			static NativeHandle selGetWritingToolsIgnoredRangesInEnclosingRangeHandle = Selector.GetHandle ("textView:writingToolsIgnoredRangesInEnclosingRange:");
			static NativeHandle selShouldSelectCandidatesHandle = Selector.GetHandle ("textView:shouldSelectCandidateAtIndex:");
			static NativeHandle selShouldUpdateTouchBarItemIdentifiersHandle = Selector.GetHandle ("textView:shouldUpdateTouchBarItemIdentifiers:");
			static NativeHandle selRespondsToSelector = Selector.GetHandle ("respondsToSelector:");
			public override bool RespondsToSelector (Selector? sel)
			{
				if (sel is null)
					return false;
				NativeHandle selHandle = sel.Handle;
				if (selHandle.Equals (selGetCandidatesHandle))
					return getCandidates is not null;
				if (selHandle.Equals (selGetTextCheckingCandidatesHandle))
					return getTextCheckingCandidates is not null;
				if (selHandle.Equals (selGetWritingToolsIgnoredRangesInEnclosingRangeHandle))
					return getWritingToolsIgnoredRangesInEnclosingRange is not null;
				if (selHandle.Equals (selShouldSelectCandidatesHandle))
					return shouldSelectCandidates is not null;
				if (selHandle.Equals (selShouldUpdateTouchBarItemIdentifiersHandle))
					return shouldUpdateTouchBarItemIdentifiers is not null;
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					return global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selRespondsToSelector, selHandle) != 0;
				}
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSTextViewClickedEventArgs> CellClicked {
			add { EnsureNSTextViewDelegate ()!.cellClicked += value; }
			remove { EnsureNSTextViewDelegate ()!.cellClicked -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSTextViewDoubleClickEventArgs> CellDoubleClicked {
			add { EnsureNSTextViewDelegate ()!.cellDoubleClicked += value; }
			remove { EnsureNSTextViewDelegate ()!.cellDoubleClicked -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler DidChangeSelection {
			add { EnsureNSTextViewDelegate ()!.didChangeSelection += value; }
			remove { EnsureNSTextViewDelegate ()!.didChangeSelection -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler DidChangeTypingAttributes {
			add { EnsureNSTextViewDelegate ()!.didChangeTypingAttributes += value; }
			remove { EnsureNSTextViewDelegate ()!.didChangeTypingAttributes -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewTextChecked? DidCheckText {
			get { return EnsureNSTextViewDelegate ()!.didCheckText; }
			set { EnsureNSTextViewDelegate ()!.didCheckText = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewSelectorCommand? DoCommandBySelector {
			get { return EnsureNSTextViewDelegate ()!.doCommandBySelector; }
			set { EnsureNSTextViewDelegate ()!.doCommandBySelector = value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSTextViewDraggedCellEventArgs> DraggedCell {
			add { EnsureNSTextViewDelegate ()!.draggedCell += value; }
			remove { EnsureNSTextViewDelegate ()!.draggedCell -= value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewGetCandidates? GetCandidates {
			get { return EnsureNSTextViewDelegate ()!.getCandidates; }
			set { EnsureNSTextViewDelegate ()!.getCandidates = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewCompletion? GetCompletions {
			get { return EnsureNSTextViewDelegate ()!.getCompletions; }
			set { EnsureNSTextViewDelegate ()!.getCompletions = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewTextCheckingResults? GetTextCheckingCandidates {
			get { return EnsureNSTextViewDelegate ()!.getTextCheckingCandidates; }
			set { EnsureNSTextViewDelegate ()!.getTextCheckingCandidates = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewGetUndoManager? GetUndoManager {
			get { return EnsureNSTextViewDelegate ()!.getUndoManager; }
			set { EnsureNSTextViewDelegate ()!.getUndoManager = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewCellPosition? GetWritablePasteboardTypes {
			get { return EnsureNSTextViewDelegate ()!.getWritablePasteboardTypes; }
			set { EnsureNSTextViewDelegate ()!.getWritablePasteboardTypes = value; }
		}
		public NSTextViewRange? GetWritingToolsIgnoredRangesInEnclosingRange {
			get { return EnsureNSTextViewDelegate ()!.getWritingToolsIgnoredRangesInEnclosingRange; }
			set { EnsureNSTextViewDelegate ()!.getWritingToolsIgnoredRangesInEnclosingRange = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewLink? LinkClicked {
			get { return EnsureNSTextViewDelegate ()!.linkClicked; }
			set { EnsureNSTextViewDelegate ()!.linkClicked = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewEventMenu? MenuForEvent {
			get { return EnsureNSTextViewDelegate ()!.menuForEvent; }
			set { EnsureNSTextViewDelegate ()!.menuForEvent = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewChangeText? ShouldChangeTextInRange {
			get { return EnsureNSTextViewDelegate ()!.shouldChangeTextInRange; }
			set { EnsureNSTextViewDelegate ()!.shouldChangeTextInRange = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewSelectionShouldChange? ShouldChangeTextInRanges {
			get { return EnsureNSTextViewDelegate ()!.shouldChangeTextInRanges; }
			set { EnsureNSTextViewDelegate ()!.shouldChangeTextInRanges = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewTypeAttribute? ShouldChangeTypingAttributes {
			get { return EnsureNSTextViewDelegate ()!.shouldChangeTypingAttributes; }
			set { EnsureNSTextViewDelegate ()!.shouldChangeTypingAttributes = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewSelectCandidate? ShouldSelectCandidates {
			get { return EnsureNSTextViewDelegate ()!.shouldSelectCandidates; }
			set { EnsureNSTextViewDelegate ()!.shouldSelectCandidates = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewSpellingQuery? ShouldSetSpellingState {
			get { return EnsureNSTextViewDelegate ()!.shouldSetSpellingState; }
			set { EnsureNSTextViewDelegate ()!.shouldSetSpellingState = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewUpdateTouchBarItemIdentifiers? ShouldUpdateTouchBarItemIdentifiers {
			get { return EnsureNSTextViewDelegate ()!.shouldUpdateTouchBarItemIdentifiers; }
			set { EnsureNSTextViewDelegate ()!.shouldUpdateTouchBarItemIdentifiers = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewSelectionChange? WillChangeSelection {
			get { return EnsureNSTextViewDelegate ()!.willChangeSelection; }
			set { EnsureNSTextViewDelegate ()!.willChangeSelection = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewSelectionWillChange? WillChangeSelectionFromRanges {
			get { return EnsureNSTextViewDelegate ()!.willChangeSelectionFromRanges; }
			set { EnsureNSTextViewDelegate ()!.willChangeSelectionFromRanges = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewOnTextCheck? WillCheckText {
			get { return EnsureNSTextViewDelegate ()!.willCheckText; }
			set { EnsureNSTextViewDelegate ()!.willCheckText = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewTooltip? WillDisplayToolTip {
			get { return EnsureNSTextViewDelegate ()!.willDisplayToolTip; }
			set { EnsureNSTextViewDelegate ()!.willDisplayToolTip = value; }
		}
		/// <summary>To be added.</summary>
		/// <value>To be added.</value>
		/// <remarks>To be added.</remarks>
		public NSTextViewCellPasteboard? WriteCell {
			get { return EnsureNSTextViewDelegate ()!.writeCell; }
			set { EnsureNSTextViewDelegate ()!.writeCell = value; }
		}
		public event EventHandler WritingToolsDidEnd {
			add { EnsureNSTextViewDelegate ()!.writingToolsDidEnd += value; }
			remove { EnsureNSTextViewDelegate ()!.writingToolsDidEnd -= value; }
		}
		public event EventHandler WritingToolsWillBegin {
			add { EnsureNSTextViewDelegate ()!.writingToolsWillBegin += value; }
			remove { EnsureNSTextViewDelegate ()!.writingToolsWillBegin -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TextContentStorage_var = null;
				__mt_TextLayoutManager_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSTextView" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.DidChangeSelectionNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.DidChangeSelectionNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSTextView.Notifications.ObserveDidChangeSelection ((notification) => {
			///   Console.WriteLine ("Observed DidChangeSelectionNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeSelection (EventHandler<AppKit.NSTextViewDidChangeSelectionEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeSelectionNotification, notification => handler (null, new AppKit.NSTextViewDidChangeSelectionEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.DidChangeSelectionNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.DidChangeSelectionNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSTextView.Notifications.ObserveDidChangeSelection (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeSelectionNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeSelection (NSObject objectToObserve, EventHandler<AppKit.NSTextViewDidChangeSelectionEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeSelectionNotification, notification => handler (null, new AppKit.NSTextViewDidChangeSelectionEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.DidChangeTypingAttributesNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.DidChangeTypingAttributesNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSTextView.Notifications.ObserveDidChangeTypingAttributes ((notification) => {
			///   Console.WriteLine ("Observed DidChangeTypingAttributesNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeTypingAttributes (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeTypingAttributesNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.DidChangeTypingAttributesNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.DidChangeTypingAttributesNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSTextView.Notifications.ObserveDidChangeTypingAttributes (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeTypingAttributesNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeTypingAttributes (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeTypingAttributesNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.DidSwitchToNSLayoutManagerNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.DidSwitchToNSLayoutManagerNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSTextView.Notifications.ObserveDidSwitchToNSLayoutManager ((notification) => {
			///   Console.WriteLine ("Observed DidSwitchToNSLayoutManagerNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidSwitchToNSLayoutManager (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidSwitchToNSLayoutManagerNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.DidSwitchToNSLayoutManagerNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.DidSwitchToNSLayoutManagerNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSTextView.Notifications.ObserveDidSwitchToNSLayoutManager (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidSwitchToNSLayoutManagerNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidSwitchToNSLayoutManager (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidSwitchToNSLayoutManagerNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.WillChangeNotifyingTextViewNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.WillChangeNotifyingTextViewNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSTextView.Notifications.ObserveWillChangeNotifyingTextView ((notification) => {
			///   Console.WriteLine ("Observed WillChangeNotifyingTextViewNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillChangeNotifyingTextView (EventHandler<AppKit.NSTextViewWillChangeNotifyingTextViewEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillChangeNotifyingTextViewNotification, notification => handler (null, new AppKit.NSTextViewWillChangeNotifyingTextViewEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.WillChangeNotifyingTextViewNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.WillChangeNotifyingTextViewNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSTextView.Notifications.ObserveWillChangeNotifyingTextView (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillChangeNotifyingTextViewNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillChangeNotifyingTextView (NSObject objectToObserve, EventHandler<AppKit.NSTextViewWillChangeNotifyingTextViewEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillChangeNotifyingTextViewNotification, notification => handler (null, new AppKit.NSTextViewWillChangeNotifyingTextViewEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.WillSwitchToNSLayoutManagerNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.WillSwitchToNSLayoutManagerNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSTextView.Notifications.ObserveWillSwitchToNSLayoutManager ((notification) => {
			///   Console.WriteLine ("Observed WillSwitchToNSLayoutManagerNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillSwitchToNSLayoutManager (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillSwitchToNSLayoutManagerNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSTextView.WillSwitchToNSLayoutManagerNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSTextView.WillSwitchToNSLayoutManagerNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSTextView.Notifications.ObserveWillSwitchToNSLayoutManager (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WillSwitchToNSLayoutManagerNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWillSwitchToNSLayoutManager (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WillSwitchToNSLayoutManagerNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSTextView */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSTextViewClickedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSTextViewClickedEventArgs" /> with the specified event data.</summary>
		/// <param name="cell">The value for the <see cref="Cell" /> property.</param>
		/// <param name="cellFrame">The value for the <see cref="CellFrame" /> property.</param>
		/// <param name="charIndex">The value for the <see cref="CharIndex" /> property.</param>
		public NSTextViewClickedEventArgs (NSTextAttachmentCell cell, CGRect cellFrame, UIntPtr charIndex)
		{
			this.Cell = cell;
			this.CellFrame = cellFrame;
			this.CharIndex = charIndex;
		}
		public NSTextAttachmentCell Cell { get; set; }
		public CGRect CellFrame { get; set; }
		public UIntPtr CharIndex { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSTextViewDoubleClickEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSTextViewDoubleClickEventArgs" /> with the specified event data.</summary>
		/// <param name="cell">The value for the <see cref="Cell" /> property.</param>
		/// <param name="cellFrame">The value for the <see cref="CellFrame" /> property.</param>
		/// <param name="charIndex">The value for the <see cref="CharIndex" /> property.</param>
		public NSTextViewDoubleClickEventArgs (NSTextAttachmentCell cell, CGRect cellFrame, UIntPtr charIndex)
		{
			this.Cell = cell;
			this.CellFrame = cellFrame;
			this.CharIndex = charIndex;
		}
		public NSTextAttachmentCell Cell { get; set; }
		public CGRect CellFrame { get; set; }
		public UIntPtr CharIndex { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSTextViewDraggedCellEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSTextViewDraggedCellEventArgs" /> with the specified event data.</summary>
		/// <param name="cell">The value for the <see cref="Cell" /> property.</param>
		/// <param name="rect">The value for the <see cref="Rect" /> property.</param>
		/// <param name="theEvent">The value for the <see cref="TheEvent" /> property.</param>
		/// <param name="charIndex">The value for the <see cref="CharIndex" /> property.</param>
		public NSTextViewDraggedCellEventArgs (NSTextAttachmentCell cell, CGRect rect, NSEvent theEvent, UIntPtr charIndex)
		{
			this.Cell = cell;
			this.CharIndex = charIndex;
			this.Rect = rect;
			this.TheEvent = theEvent;
		}
		public NSTextAttachmentCell Cell { get; set; }
		public UIntPtr CharIndex { get; set; }
		public CGRect Rect { get; set; }
		public NSEvent TheEvent { get; set; }
	}
}
