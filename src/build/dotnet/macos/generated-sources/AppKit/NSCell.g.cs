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
	[Register("NSCell", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCell : NSObject, INSAccessibility, INSAccessibilityElementProtocol, INSCoding, INSCopying, INSUserInterfaceItemIdentification {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcceptsFirstResponderX = "acceptsFirstResponder";
		static readonly NativeHandle selAcceptsFirstResponderXHandle = Selector.GetHandle ("acceptsFirstResponder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityActionDescription_X = "accessibilityActionDescription:";
		static readonly NativeHandle selAccessibilityActionDescription_XHandle = Selector.GetHandle ("accessibilityActionDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityActionNamesX = "accessibilityActionNames";
		static readonly NativeHandle selAccessibilityActionNamesXHandle = Selector.GetHandle ("accessibilityActionNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityActivationPointX = "accessibilityActivationPoint";
		static readonly NativeHandle selAccessibilityActivationPointXHandle = Selector.GetHandle ("accessibilityActivationPoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityAllowedValuesX = "accessibilityAllowedValues";
		static readonly NativeHandle selAccessibilityAllowedValuesXHandle = Selector.GetHandle ("accessibilityAllowedValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityApplicationFocusedUIElementX = "accessibilityApplicationFocusedUIElement";
		static readonly NativeHandle selAccessibilityApplicationFocusedUIElementXHandle = Selector.GetHandle ("accessibilityApplicationFocusedUIElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityArrayAttributeCount_X = "accessibilityArrayAttributeCount:";
		static readonly NativeHandle selAccessibilityArrayAttributeCount_XHandle = Selector.GetHandle ("accessibilityArrayAttributeCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityArrayAttributeValues_Index_MaxCount_X = "accessibilityArrayAttributeValues:index:maxCount:";
		static readonly NativeHandle selAccessibilityArrayAttributeValues_Index_MaxCount_XHandle = Selector.GetHandle ("accessibilityArrayAttributeValues:index:maxCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityAttributeNamesX = "accessibilityAttributeNames";
		static readonly NativeHandle selAccessibilityAttributeNamesXHandle = Selector.GetHandle ("accessibilityAttributeNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityAttributeValue_X = "accessibilityAttributeValue:";
		static readonly NativeHandle selAccessibilityAttributeValue_XHandle = Selector.GetHandle ("accessibilityAttributeValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityAttributeValue_ForParameter_X = "accessibilityAttributeValue:forParameter:";
		static readonly NativeHandle selAccessibilityAttributeValue_ForParameter_XHandle = Selector.GetHandle ("accessibilityAttributeValue:forParameter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityAttributedStringForRange_X = "accessibilityAttributedStringForRange:";
		static readonly NativeHandle selAccessibilityAttributedStringForRange_XHandle = Selector.GetHandle ("accessibilityAttributedStringForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityAttributedUserInputLabelsX = "accessibilityAttributedUserInputLabels";
		static readonly NativeHandle selAccessibilityAttributedUserInputLabelsXHandle = Selector.GetHandle ("accessibilityAttributedUserInputLabels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityCancelButtonX = "accessibilityCancelButton";
		static readonly NativeHandle selAccessibilityCancelButtonXHandle = Selector.GetHandle ("accessibilityCancelButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityCellForColumn_Row_X = "accessibilityCellForColumn:row:";
		static readonly NativeHandle selAccessibilityCellForColumn_Row_XHandle = Selector.GetHandle ("accessibilityCellForColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityChildrenX = "accessibilityChildren";
		static readonly NativeHandle selAccessibilityChildrenXHandle = Selector.GetHandle ("accessibilityChildren");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityChildrenInNavigationOrderX = "accessibilityChildrenInNavigationOrder";
		static readonly NativeHandle selAccessibilityChildrenInNavigationOrderXHandle = Selector.GetHandle ("accessibilityChildrenInNavigationOrder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityClearButtonX = "accessibilityClearButton";
		static readonly NativeHandle selAccessibilityClearButtonXHandle = Selector.GetHandle ("accessibilityClearButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityCloseButtonX = "accessibilityCloseButton";
		static readonly NativeHandle selAccessibilityCloseButtonXHandle = Selector.GetHandle ("accessibilityCloseButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityColumnCountX = "accessibilityColumnCount";
		static readonly NativeHandle selAccessibilityColumnCountXHandle = Selector.GetHandle ("accessibilityColumnCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityColumnHeaderUIElementsX = "accessibilityColumnHeaderUIElements";
		static readonly NativeHandle selAccessibilityColumnHeaderUIElementsXHandle = Selector.GetHandle ("accessibilityColumnHeaderUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityColumnIndexRangeX = "accessibilityColumnIndexRange";
		static readonly NativeHandle selAccessibilityColumnIndexRangeXHandle = Selector.GetHandle ("accessibilityColumnIndexRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityColumnTitlesX = "accessibilityColumnTitles";
		static readonly NativeHandle selAccessibilityColumnTitlesXHandle = Selector.GetHandle ("accessibilityColumnTitles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityColumnsX = "accessibilityColumns";
		static readonly NativeHandle selAccessibilityColumnsXHandle = Selector.GetHandle ("accessibilityColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityContentsX = "accessibilityContents";
		static readonly NativeHandle selAccessibilityContentsXHandle = Selector.GetHandle ("accessibilityContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityCriticalValueX = "accessibilityCriticalValue";
		static readonly NativeHandle selAccessibilityCriticalValueXHandle = Selector.GetHandle ("accessibilityCriticalValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityCustomActionsX = "accessibilityCustomActions";
		static readonly NativeHandle selAccessibilityCustomActionsXHandle = Selector.GetHandle ("accessibilityCustomActions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityCustomRotorsX = "accessibilityCustomRotors";
		static readonly NativeHandle selAccessibilityCustomRotorsXHandle = Selector.GetHandle ("accessibilityCustomRotors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDecrementButtonX = "accessibilityDecrementButton";
		static readonly NativeHandle selAccessibilityDecrementButtonXHandle = Selector.GetHandle ("accessibilityDecrementButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDefaultButtonX = "accessibilityDefaultButton";
		static readonly NativeHandle selAccessibilityDefaultButtonXHandle = Selector.GetHandle ("accessibilityDefaultButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDisclosedByRowX = "accessibilityDisclosedByRow";
		static readonly NativeHandle selAccessibilityDisclosedByRowXHandle = Selector.GetHandle ("accessibilityDisclosedByRow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDisclosedRowsX = "accessibilityDisclosedRows";
		static readonly NativeHandle selAccessibilityDisclosedRowsXHandle = Selector.GetHandle ("accessibilityDisclosedRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDisclosureLevelX = "accessibilityDisclosureLevel";
		static readonly NativeHandle selAccessibilityDisclosureLevelXHandle = Selector.GetHandle ("accessibilityDisclosureLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityDocumentX = "accessibilityDocument";
		static readonly NativeHandle selAccessibilityDocumentXHandle = Selector.GetHandle ("accessibilityDocument");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityExtrasMenuBarX = "accessibilityExtrasMenuBar";
		static readonly NativeHandle selAccessibilityExtrasMenuBarXHandle = Selector.GetHandle ("accessibilityExtrasMenuBar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFilenameX = "accessibilityFilename";
		static readonly NativeHandle selAccessibilityFilenameXHandle = Selector.GetHandle ("accessibilityFilename");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFocusedUIElementX = "accessibilityFocusedUIElement";
		static readonly NativeHandle selAccessibilityFocusedUIElementXHandle = Selector.GetHandle ("accessibilityFocusedUIElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFocusedWindowX = "accessibilityFocusedWindow";
		static readonly NativeHandle selAccessibilityFocusedWindowXHandle = Selector.GetHandle ("accessibilityFocusedWindow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFrameX = "accessibilityFrame";
		static readonly NativeHandle selAccessibilityFrameXHandle = Selector.GetHandle ("accessibilityFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFrameForRange_X = "accessibilityFrameForRange:";
		static readonly NativeHandle selAccessibilityFrameForRange_XHandle = Selector.GetHandle ("accessibilityFrameForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityFullScreenButtonX = "accessibilityFullScreenButton";
		static readonly NativeHandle selAccessibilityFullScreenButtonXHandle = Selector.GetHandle ("accessibilityFullScreenButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityGrowAreaX = "accessibilityGrowArea";
		static readonly NativeHandle selAccessibilityGrowAreaXHandle = Selector.GetHandle ("accessibilityGrowArea");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityHandlesX = "accessibilityHandles";
		static readonly NativeHandle selAccessibilityHandlesXHandle = Selector.GetHandle ("accessibilityHandles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityHeaderX = "accessibilityHeader";
		static readonly NativeHandle selAccessibilityHeaderXHandle = Selector.GetHandle ("accessibilityHeader");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityHelpX = "accessibilityHelp";
		static readonly NativeHandle selAccessibilityHelpXHandle = Selector.GetHandle ("accessibilityHelp");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityHitTest_X = "accessibilityHitTest:";
		static readonly NativeHandle selAccessibilityHitTest_XHandle = Selector.GetHandle ("accessibilityHitTest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityHorizontalScrollBarX = "accessibilityHorizontalScrollBar";
		static readonly NativeHandle selAccessibilityHorizontalScrollBarXHandle = Selector.GetHandle ("accessibilityHorizontalScrollBar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityHorizontalUnitDescriptionX = "accessibilityHorizontalUnitDescription";
		static readonly NativeHandle selAccessibilityHorizontalUnitDescriptionXHandle = Selector.GetHandle ("accessibilityHorizontalUnitDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityHorizontalUnitsX = "accessibilityHorizontalUnits";
		static readonly NativeHandle selAccessibilityHorizontalUnitsXHandle = Selector.GetHandle ("accessibilityHorizontalUnits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIdentifierX = "accessibilityIdentifier";
		static readonly NativeHandle selAccessibilityIdentifierXHandle = Selector.GetHandle ("accessibilityIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIncrementButtonX = "accessibilityIncrementButton";
		static readonly NativeHandle selAccessibilityIncrementButtonXHandle = Selector.GetHandle ("accessibilityIncrementButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIndexX = "accessibilityIndex";
		static readonly NativeHandle selAccessibilityIndexXHandle = Selector.GetHandle ("accessibilityIndex");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIndexOfChild_X = "accessibilityIndexOfChild:";
		static readonly NativeHandle selAccessibilityIndexOfChild_XHandle = Selector.GetHandle ("accessibilityIndexOfChild:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityInsertionPointLineNumberX = "accessibilityInsertionPointLineNumber";
		static readonly NativeHandle selAccessibilityInsertionPointLineNumberXHandle = Selector.GetHandle ("accessibilityInsertionPointLineNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIsAttributeSettable_X = "accessibilityIsAttributeSettable:";
		static readonly NativeHandle selAccessibilityIsAttributeSettable_XHandle = Selector.GetHandle ("accessibilityIsAttributeSettable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIsIgnoredX = "accessibilityIsIgnored";
		static readonly NativeHandle selAccessibilityIsIgnoredXHandle = Selector.GetHandle ("accessibilityIsIgnored");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLabelX = "accessibilityLabel";
		static readonly NativeHandle selAccessibilityLabelXHandle = Selector.GetHandle ("accessibilityLabel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLabelUIElementsX = "accessibilityLabelUIElements";
		static readonly NativeHandle selAccessibilityLabelUIElementsXHandle = Selector.GetHandle ("accessibilityLabelUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLabelValueX = "accessibilityLabelValue";
		static readonly NativeHandle selAccessibilityLabelValueXHandle = Selector.GetHandle ("accessibilityLabelValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLayoutPointForScreenPoint_X = "accessibilityLayoutPointForScreenPoint:";
		static readonly NativeHandle selAccessibilityLayoutPointForScreenPoint_XHandle = Selector.GetHandle ("accessibilityLayoutPointForScreenPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLayoutSizeForScreenSize_X = "accessibilityLayoutSizeForScreenSize:";
		static readonly NativeHandle selAccessibilityLayoutSizeForScreenSize_XHandle = Selector.GetHandle ("accessibilityLayoutSizeForScreenSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLineForIndex_X = "accessibilityLineForIndex:";
		static readonly NativeHandle selAccessibilityLineForIndex_XHandle = Selector.GetHandle ("accessibilityLineForIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityLinkedUIElementsX = "accessibilityLinkedUIElements";
		static readonly NativeHandle selAccessibilityLinkedUIElementsXHandle = Selector.GetHandle ("accessibilityLinkedUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityMainWindowX = "accessibilityMainWindow";
		static readonly NativeHandle selAccessibilityMainWindowXHandle = Selector.GetHandle ("accessibilityMainWindow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityMarkerGroupUIElementX = "accessibilityMarkerGroupUIElement";
		static readonly NativeHandle selAccessibilityMarkerGroupUIElementXHandle = Selector.GetHandle ("accessibilityMarkerGroupUIElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityMarkerTypeDescriptionX = "accessibilityMarkerTypeDescription";
		static readonly NativeHandle selAccessibilityMarkerTypeDescriptionXHandle = Selector.GetHandle ("accessibilityMarkerTypeDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityMarkerUIElementsX = "accessibilityMarkerUIElements";
		static readonly NativeHandle selAccessibilityMarkerUIElementsXHandle = Selector.GetHandle ("accessibilityMarkerUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityMarkerValuesX = "accessibilityMarkerValues";
		static readonly NativeHandle selAccessibilityMarkerValuesXHandle = Selector.GetHandle ("accessibilityMarkerValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityMaxValueX = "accessibilityMaxValue";
		static readonly NativeHandle selAccessibilityMaxValueXHandle = Selector.GetHandle ("accessibilityMaxValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityMenuBarX = "accessibilityMenuBar";
		static readonly NativeHandle selAccessibilityMenuBarXHandle = Selector.GetHandle ("accessibilityMenuBar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityMinValueX = "accessibilityMinValue";
		static readonly NativeHandle selAccessibilityMinValueXHandle = Selector.GetHandle ("accessibilityMinValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityMinimizeButtonX = "accessibilityMinimizeButton";
		static readonly NativeHandle selAccessibilityMinimizeButtonXHandle = Selector.GetHandle ("accessibilityMinimizeButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityNextContentsX = "accessibilityNextContents";
		static readonly NativeHandle selAccessibilityNextContentsXHandle = Selector.GetHandle ("accessibilityNextContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityNotifiesWhenDestroyedX = "accessibilityNotifiesWhenDestroyed";
		static readonly NativeHandle selAccessibilityNotifiesWhenDestroyedXHandle = Selector.GetHandle ("accessibilityNotifiesWhenDestroyed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityNumberOfCharactersX = "accessibilityNumberOfCharacters";
		static readonly NativeHandle selAccessibilityNumberOfCharactersXHandle = Selector.GetHandle ("accessibilityNumberOfCharacters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityOrientationX = "accessibilityOrientation";
		static readonly NativeHandle selAccessibilityOrientationXHandle = Selector.GetHandle ("accessibilityOrientation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityOverflowButtonX = "accessibilityOverflowButton";
		static readonly NativeHandle selAccessibilityOverflowButtonXHandle = Selector.GetHandle ("accessibilityOverflowButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityParameterizedAttributeNamesX = "accessibilityParameterizedAttributeNames";
		static readonly NativeHandle selAccessibilityParameterizedAttributeNamesXHandle = Selector.GetHandle ("accessibilityParameterizedAttributeNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityParentX = "accessibilityParent";
		static readonly NativeHandle selAccessibilityParentXHandle = Selector.GetHandle ("accessibilityParent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformAction_X = "accessibilityPerformAction:";
		static readonly NativeHandle selAccessibilityPerformAction_XHandle = Selector.GetHandle ("accessibilityPerformAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformCancelX = "accessibilityPerformCancel";
		static readonly NativeHandle selAccessibilityPerformCancelXHandle = Selector.GetHandle ("accessibilityPerformCancel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformConfirmX = "accessibilityPerformConfirm";
		static readonly NativeHandle selAccessibilityPerformConfirmXHandle = Selector.GetHandle ("accessibilityPerformConfirm");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformDecrementX = "accessibilityPerformDecrement";
		static readonly NativeHandle selAccessibilityPerformDecrementXHandle = Selector.GetHandle ("accessibilityPerformDecrement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformDeleteX = "accessibilityPerformDelete";
		static readonly NativeHandle selAccessibilityPerformDeleteXHandle = Selector.GetHandle ("accessibilityPerformDelete");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformIncrementX = "accessibilityPerformIncrement";
		static readonly NativeHandle selAccessibilityPerformIncrementXHandle = Selector.GetHandle ("accessibilityPerformIncrement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformPickX = "accessibilityPerformPick";
		static readonly NativeHandle selAccessibilityPerformPickXHandle = Selector.GetHandle ("accessibilityPerformPick");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformPressX = "accessibilityPerformPress";
		static readonly NativeHandle selAccessibilityPerformPressXHandle = Selector.GetHandle ("accessibilityPerformPress");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformRaiseX = "accessibilityPerformRaise";
		static readonly NativeHandle selAccessibilityPerformRaiseXHandle = Selector.GetHandle ("accessibilityPerformRaise");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformShowAlternateUIX = "accessibilityPerformShowAlternateUI";
		static readonly NativeHandle selAccessibilityPerformShowAlternateUIXHandle = Selector.GetHandle ("accessibilityPerformShowAlternateUI");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformShowDefaultUIX = "accessibilityPerformShowDefaultUI";
		static readonly NativeHandle selAccessibilityPerformShowDefaultUIXHandle = Selector.GetHandle ("accessibilityPerformShowDefaultUI");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPerformShowMenuX = "accessibilityPerformShowMenu";
		static readonly NativeHandle selAccessibilityPerformShowMenuXHandle = Selector.GetHandle ("accessibilityPerformShowMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPlaceholderValueX = "accessibilityPlaceholderValue";
		static readonly NativeHandle selAccessibilityPlaceholderValueXHandle = Selector.GetHandle ("accessibilityPlaceholderValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityPreviousContentsX = "accessibilityPreviousContents";
		static readonly NativeHandle selAccessibilityPreviousContentsXHandle = Selector.GetHandle ("accessibilityPreviousContents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityProxyX = "accessibilityProxy";
		static readonly NativeHandle selAccessibilityProxyXHandle = Selector.GetHandle ("accessibilityProxy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRTFForRange_X = "accessibilityRTFForRange:";
		static readonly NativeHandle selAccessibilityRTFForRange_XHandle = Selector.GetHandle ("accessibilityRTFForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRangeForIndex_X = "accessibilityRangeForIndex:";
		static readonly NativeHandle selAccessibilityRangeForIndex_XHandle = Selector.GetHandle ("accessibilityRangeForIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRangeForLine_X = "accessibilityRangeForLine:";
		static readonly NativeHandle selAccessibilityRangeForLine_XHandle = Selector.GetHandle ("accessibilityRangeForLine:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRangeForPosition_X = "accessibilityRangeForPosition:";
		static readonly NativeHandle selAccessibilityRangeForPosition_XHandle = Selector.GetHandle ("accessibilityRangeForPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRoleX = "accessibilityRole";
		static readonly NativeHandle selAccessibilityRoleXHandle = Selector.GetHandle ("accessibilityRole");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRoleDescriptionX = "accessibilityRoleDescription";
		static readonly NativeHandle selAccessibilityRoleDescriptionXHandle = Selector.GetHandle ("accessibilityRoleDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRowCountX = "accessibilityRowCount";
		static readonly NativeHandle selAccessibilityRowCountXHandle = Selector.GetHandle ("accessibilityRowCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRowHeaderUIElementsX = "accessibilityRowHeaderUIElements";
		static readonly NativeHandle selAccessibilityRowHeaderUIElementsXHandle = Selector.GetHandle ("accessibilityRowHeaderUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRowIndexRangeX = "accessibilityRowIndexRange";
		static readonly NativeHandle selAccessibilityRowIndexRangeXHandle = Selector.GetHandle ("accessibilityRowIndexRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRowsX = "accessibilityRows";
		static readonly NativeHandle selAccessibilityRowsXHandle = Selector.GetHandle ("accessibilityRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityRulerMarkerTypeX = "accessibilityRulerMarkerType";
		static readonly NativeHandle selAccessibilityRulerMarkerTypeXHandle = Selector.GetHandle ("accessibilityRulerMarkerType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityScreenPointForLayoutPoint_X = "accessibilityScreenPointForLayoutPoint:";
		static readonly NativeHandle selAccessibilityScreenPointForLayoutPoint_XHandle = Selector.GetHandle ("accessibilityScreenPointForLayoutPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityScreenSizeForLayoutSize_X = "accessibilityScreenSizeForLayoutSize:";
		static readonly NativeHandle selAccessibilityScreenSizeForLayoutSize_XHandle = Selector.GetHandle ("accessibilityScreenSizeForLayoutSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySearchButtonX = "accessibilitySearchButton";
		static readonly NativeHandle selAccessibilitySearchButtonXHandle = Selector.GetHandle ("accessibilitySearchButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySearchMenuX = "accessibilitySearchMenu";
		static readonly NativeHandle selAccessibilitySearchMenuXHandle = Selector.GetHandle ("accessibilitySearchMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedCellsX = "accessibilitySelectedCells";
		static readonly NativeHandle selAccessibilitySelectedCellsXHandle = Selector.GetHandle ("accessibilitySelectedCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedChildrenX = "accessibilitySelectedChildren";
		static readonly NativeHandle selAccessibilitySelectedChildrenXHandle = Selector.GetHandle ("accessibilitySelectedChildren");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedColumnsX = "accessibilitySelectedColumns";
		static readonly NativeHandle selAccessibilitySelectedColumnsXHandle = Selector.GetHandle ("accessibilitySelectedColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedRowsX = "accessibilitySelectedRows";
		static readonly NativeHandle selAccessibilitySelectedRowsXHandle = Selector.GetHandle ("accessibilitySelectedRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedTextX = "accessibilitySelectedText";
		static readonly NativeHandle selAccessibilitySelectedTextXHandle = Selector.GetHandle ("accessibilitySelectedText");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedTextRangeX = "accessibilitySelectedTextRange";
		static readonly NativeHandle selAccessibilitySelectedTextRangeXHandle = Selector.GetHandle ("accessibilitySelectedTextRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySelectedTextRangesX = "accessibilitySelectedTextRanges";
		static readonly NativeHandle selAccessibilitySelectedTextRangesXHandle = Selector.GetHandle ("accessibilitySelectedTextRanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityServesAsTitleForUIElementsX = "accessibilityServesAsTitleForUIElements";
		static readonly NativeHandle selAccessibilityServesAsTitleForUIElementsXHandle = Selector.GetHandle ("accessibilityServesAsTitleForUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySetValue_ForAttribute_X = "accessibilitySetValue:forAttribute:";
		static readonly NativeHandle selAccessibilitySetValue_ForAttribute_XHandle = Selector.GetHandle ("accessibilitySetValue:forAttribute:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySharedCharacterRangeX = "accessibilitySharedCharacterRange";
		static readonly NativeHandle selAccessibilitySharedCharacterRangeXHandle = Selector.GetHandle ("accessibilitySharedCharacterRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySharedFocusElementsX = "accessibilitySharedFocusElements";
		static readonly NativeHandle selAccessibilitySharedFocusElementsXHandle = Selector.GetHandle ("accessibilitySharedFocusElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySharedTextUIElementsX = "accessibilitySharedTextUIElements";
		static readonly NativeHandle selAccessibilitySharedTextUIElementsXHandle = Selector.GetHandle ("accessibilitySharedTextUIElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityShownMenuX = "accessibilityShownMenu";
		static readonly NativeHandle selAccessibilityShownMenuXHandle = Selector.GetHandle ("accessibilityShownMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySortDirectionX = "accessibilitySortDirection";
		static readonly NativeHandle selAccessibilitySortDirectionXHandle = Selector.GetHandle ("accessibilitySortDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySplittersX = "accessibilitySplitters";
		static readonly NativeHandle selAccessibilitySplittersXHandle = Selector.GetHandle ("accessibilitySplitters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityStringForRange_X = "accessibilityStringForRange:";
		static readonly NativeHandle selAccessibilityStringForRange_XHandle = Selector.GetHandle ("accessibilityStringForRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityStyleRangeForIndex_X = "accessibilityStyleRangeForIndex:";
		static readonly NativeHandle selAccessibilityStyleRangeForIndex_XHandle = Selector.GetHandle ("accessibilityStyleRangeForIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilitySubroleX = "accessibilitySubrole";
		static readonly NativeHandle selAccessibilitySubroleXHandle = Selector.GetHandle ("accessibilitySubrole");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityTabsX = "accessibilityTabs";
		static readonly NativeHandle selAccessibilityTabsXHandle = Selector.GetHandle ("accessibilityTabs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityTitleX = "accessibilityTitle";
		static readonly NativeHandle selAccessibilityTitleXHandle = Selector.GetHandle ("accessibilityTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityTitleUIElementX = "accessibilityTitleUIElement";
		static readonly NativeHandle selAccessibilityTitleUIElementXHandle = Selector.GetHandle ("accessibilityTitleUIElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityToolbarButtonX = "accessibilityToolbarButton";
		static readonly NativeHandle selAccessibilityToolbarButtonXHandle = Selector.GetHandle ("accessibilityToolbarButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityTopLevelUIElementX = "accessibilityTopLevelUIElement";
		static readonly NativeHandle selAccessibilityTopLevelUIElementXHandle = Selector.GetHandle ("accessibilityTopLevelUIElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityURLX = "accessibilityURL";
		static readonly NativeHandle selAccessibilityURLXHandle = Selector.GetHandle ("accessibilityURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityUnitDescriptionX = "accessibilityUnitDescription";
		static readonly NativeHandle selAccessibilityUnitDescriptionXHandle = Selector.GetHandle ("accessibilityUnitDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityUnitsX = "accessibilityUnits";
		static readonly NativeHandle selAccessibilityUnitsXHandle = Selector.GetHandle ("accessibilityUnits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityUserInputLabelsX = "accessibilityUserInputLabels";
		static readonly NativeHandle selAccessibilityUserInputLabelsXHandle = Selector.GetHandle ("accessibilityUserInputLabels");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityValueX = "accessibilityValue";
		static readonly NativeHandle selAccessibilityValueXHandle = Selector.GetHandle ("accessibilityValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityValueDescriptionX = "accessibilityValueDescription";
		static readonly NativeHandle selAccessibilityValueDescriptionXHandle = Selector.GetHandle ("accessibilityValueDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVerticalScrollBarX = "accessibilityVerticalScrollBar";
		static readonly NativeHandle selAccessibilityVerticalScrollBarXHandle = Selector.GetHandle ("accessibilityVerticalScrollBar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVerticalUnitDescriptionX = "accessibilityVerticalUnitDescription";
		static readonly NativeHandle selAccessibilityVerticalUnitDescriptionXHandle = Selector.GetHandle ("accessibilityVerticalUnitDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVerticalUnitsX = "accessibilityVerticalUnits";
		static readonly NativeHandle selAccessibilityVerticalUnitsXHandle = Selector.GetHandle ("accessibilityVerticalUnits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleCellsX = "accessibilityVisibleCells";
		static readonly NativeHandle selAccessibilityVisibleCellsXHandle = Selector.GetHandle ("accessibilityVisibleCells");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleCharacterRangeX = "accessibilityVisibleCharacterRange";
		static readonly NativeHandle selAccessibilityVisibleCharacterRangeXHandle = Selector.GetHandle ("accessibilityVisibleCharacterRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleChildrenX = "accessibilityVisibleChildren";
		static readonly NativeHandle selAccessibilityVisibleChildrenXHandle = Selector.GetHandle ("accessibilityVisibleChildren");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleColumnsX = "accessibilityVisibleColumns";
		static readonly NativeHandle selAccessibilityVisibleColumnsXHandle = Selector.GetHandle ("accessibilityVisibleColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityVisibleRowsX = "accessibilityVisibleRows";
		static readonly NativeHandle selAccessibilityVisibleRowsXHandle = Selector.GetHandle ("accessibilityVisibleRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityWarningValueX = "accessibilityWarningValue";
		static readonly NativeHandle selAccessibilityWarningValueXHandle = Selector.GetHandle ("accessibilityWarningValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityWindowX = "accessibilityWindow";
		static readonly NativeHandle selAccessibilityWindowXHandle = Selector.GetHandle ("accessibilityWindow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityWindowsX = "accessibilityWindows";
		static readonly NativeHandle selAccessibilityWindowsXHandle = Selector.GetHandle ("accessibilityWindows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityZoomButtonX = "accessibilityZoomButton";
		static readonly NativeHandle selAccessibilityZoomButtonXHandle = Selector.GetHandle ("accessibilityZoomButton");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionX = "action";
		static readonly NativeHandle selActionXHandle = Selector.GetHandle ("action");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlignmentX = "alignment";
		static readonly NativeHandle selAlignmentXHandle = Selector.GetHandle ("alignment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsEditingTextAttributesX = "allowsEditingTextAttributes";
		static readonly NativeHandle selAllowsEditingTextAttributesXHandle = Selector.GetHandle ("allowsEditingTextAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsMixedStateX = "allowsMixedState";
		static readonly NativeHandle selAllowsMixedStateXHandle = Selector.GetHandle ("allowsMixedState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsUndoX = "allowsUndo";
		static readonly NativeHandle selAllowsUndoXHandle = Selector.GetHandle ("allowsUndo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringValueX = "attributedStringValue";
		static readonly NativeHandle selAttributedStringValueXHandle = Selector.GetHandle ("attributedStringValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundStyleX = "backgroundStyle";
		static readonly NativeHandle selBackgroundStyleXHandle = Selector.GetHandle ("backgroundStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseWritingDirectionX = "baseWritingDirection";
		static readonly NativeHandle selBaseWritingDirectionXHandle = Selector.GetHandle ("baseWritingDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalcDrawInfo_X = "calcDrawInfo:";
		static readonly NativeHandle selCalcDrawInfo_XHandle = Selector.GetHandle ("calcDrawInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellAttribute_X = "cellAttribute:";
		static readonly NativeHandle selCellAttribute_XHandle = Selector.GetHandle ("cellAttribute:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellSizeX = "cellSize";
		static readonly NativeHandle selCellSizeXHandle = Selector.GetHandle ("cellSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCellSizeForBounds_X = "cellSizeForBounds:";
		static readonly NativeHandle selCellSizeForBounds_XHandle = Selector.GetHandle ("cellSizeForBounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompare_X = "compare:";
		static readonly NativeHandle selCompare_XHandle = Selector.GetHandle ("compare:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContinueTracking_At_InView_X = "continueTracking:at:inView:";
		static readonly NativeHandle selContinueTracking_At_InView_XHandle = Selector.GetHandle ("continueTracking:at:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlSizeX = "controlSize";
		static readonly NativeHandle selControlSizeXHandle = Selector.GetHandle ("controlSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlTintX = "controlTint";
		static readonly NativeHandle selControlTintXHandle = Selector.GetHandle ("controlTint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlViewX = "controlView";
		static readonly NativeHandle selControlViewXHandle = Selector.GetHandle ("controlView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultFocusRingTypeX = "defaultFocusRingType";
		static readonly NativeHandle selDefaultFocusRingTypeXHandle = Selector.GetHandle ("defaultFocusRingType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultMenuX = "defaultMenu";
		static readonly NativeHandle selDefaultMenuXHandle = Selector.GetHandle ("defaultMenu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleValueX = "doubleValue";
		static readonly NativeHandle selDoubleValueXHandle = Selector.GetHandle ("doubleValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDraggingImageComponentsWithFrame_InView_X = "draggingImageComponentsWithFrame:inView:";
		static readonly NativeHandle selDraggingImageComponentsWithFrame_InView_XHandle = Selector.GetHandle ("draggingImageComponentsWithFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawFocusRingMaskWithFrame_InView_X = "drawFocusRingMaskWithFrame:inView:";
		static readonly NativeHandle selDrawFocusRingMaskWithFrame_InView_XHandle = Selector.GetHandle ("drawFocusRingMaskWithFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInteriorWithFrame_InView_X = "drawInteriorWithFrame:inView:";
		static readonly NativeHandle selDrawInteriorWithFrame_InView_XHandle = Selector.GetHandle ("drawInteriorWithFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithExpansionFrame_InView_X = "drawWithExpansionFrame:inView:";
		static readonly NativeHandle selDrawWithExpansionFrame_InView_XHandle = Selector.GetHandle ("drawWithExpansionFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawWithFrame_InView_X = "drawWithFrame:inView:";
		static readonly NativeHandle selDrawWithFrame_InView_XHandle = Selector.GetHandle ("drawWithFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawingRectForBounds_X = "drawingRectForBounds:";
		static readonly NativeHandle selDrawingRectForBounds_XHandle = Selector.GetHandle ("drawingRectForBounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEditWithFrame_InView_Editor_Delegate_Event_X = "editWithFrame:inView:editor:delegate:event:";
		static readonly NativeHandle selEditWithFrame_InView_Editor_Delegate_Event_XHandle = Selector.GetHandle ("editWithFrame:inView:editor:delegate:event:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndEditing_X = "endEditing:";
		static readonly NativeHandle selEndEditing_XHandle = Selector.GetHandle ("endEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpansionFrameWithFrame_InView_X = "expansionFrameWithFrame:inView:";
		static readonly NativeHandle selExpansionFrameWithFrame_InView_XHandle = Selector.GetHandle ("expansionFrameWithFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFieldEditorForView_X = "fieldEditorForView:";
		static readonly NativeHandle selFieldEditorForView_XHandle = Selector.GetHandle ("fieldEditorForView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloatValueX = "floatValue";
		static readonly NativeHandle selFloatValueXHandle = Selector.GetHandle ("floatValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocusRingMaskBoundsForFrame_InView_X = "focusRingMaskBoundsForFrame:inView:";
		static readonly NativeHandle selFocusRingMaskBoundsForFrame_InView_XHandle = Selector.GetHandle ("focusRingMaskBoundsForFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocusRingTypeX = "focusRingType";
		static readonly NativeHandle selFocusRingTypeXHandle = Selector.GetHandle ("focusRingType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontX = "font";
		static readonly NativeHandle selFontXHandle = Selector.GetHandle ("font");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormatterX = "formatter";
		static readonly NativeHandle selFormatterXHandle = Selector.GetHandle ("formatter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetPeriodicDelay_Interval_X = "getPeriodicDelay:interval:";
		static readonly NativeHandle selGetPeriodicDelay_Interval_XHandle = Selector.GetHandle ("getPeriodicDelay:interval:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasValidObjectValueX = "hasValidObjectValue";
		static readonly NativeHandle selHasValidObjectValueXHandle = Selector.GetHandle ("hasValidObjectValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlight_WithFrame_InView_X = "highlight:withFrame:inView:";
		static readonly NativeHandle selHighlight_WithFrame_InView_XHandle = Selector.GetHandle ("highlight:withFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlightColorWithFrame_InView_X = "highlightColorWithFrame:inView:";
		static readonly NativeHandle selHighlightColorWithFrame_InView_XHandle = Selector.GetHandle ("highlightColorWithFrame:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHitTestForEvent_InRect_OfView_X = "hitTestForEvent:inRect:ofView:";
		static readonly NativeHandle selHitTestForEvent_InRect_OfView_XHandle = Selector.GetHandle ("hitTestForEvent:inRect:ofView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierX = "identifier";
		static readonly NativeHandle selIdentifierXHandle = Selector.GetHandle ("identifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageX = "image";
		static readonly NativeHandle selImageXHandle = Selector.GetHandle ("image");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageRectForBounds_X = "imageRectForBounds:";
		static readonly NativeHandle selImageRectForBounds_XHandle = Selector.GetHandle ("imageRectForBounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImportsGraphicsX = "importsGraphics";
		static readonly NativeHandle selImportsGraphicsXHandle = Selector.GetHandle ("importsGraphics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitImageCell_X = "initImageCell:";
		static readonly NativeHandle selInitImageCell_XHandle = Selector.GetHandle ("initImageCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitTextCell_X = "initTextCell:";
		static readonly NativeHandle selInitTextCell_XHandle = Selector.GetHandle ("initTextCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntValueX = "intValue";
		static readonly NativeHandle selIntValueXHandle = Selector.GetHandle ("intValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntegerValueX = "integerValue";
		static readonly NativeHandle selIntegerValueXHandle = Selector.GetHandle ("integerValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInteriorBackgroundStyleX = "interiorBackgroundStyle";
		static readonly NativeHandle selInteriorBackgroundStyleXHandle = Selector.GetHandle ("interiorBackgroundStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityAlternateUIVisibleX = "isAccessibilityAlternateUIVisible";
		static readonly NativeHandle selIsAccessibilityAlternateUIVisibleXHandle = Selector.GetHandle ("isAccessibilityAlternateUIVisible");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityDisclosedX = "isAccessibilityDisclosed";
		static readonly NativeHandle selIsAccessibilityDisclosedXHandle = Selector.GetHandle ("isAccessibilityDisclosed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityEditedX = "isAccessibilityEdited";
		static readonly NativeHandle selIsAccessibilityEditedXHandle = Selector.GetHandle ("isAccessibilityEdited");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityElementX = "isAccessibilityElement";
		static readonly NativeHandle selIsAccessibilityElementXHandle = Selector.GetHandle ("isAccessibilityElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityEnabledX = "isAccessibilityEnabled";
		static readonly NativeHandle selIsAccessibilityEnabledXHandle = Selector.GetHandle ("isAccessibilityEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityExpandedX = "isAccessibilityExpanded";
		static readonly NativeHandle selIsAccessibilityExpandedXHandle = Selector.GetHandle ("isAccessibilityExpanded");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityFocusedX = "isAccessibilityFocused";
		static readonly NativeHandle selIsAccessibilityFocusedXHandle = Selector.GetHandle ("isAccessibilityFocused");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityFrontmostX = "isAccessibilityFrontmost";
		static readonly NativeHandle selIsAccessibilityFrontmostXHandle = Selector.GetHandle ("isAccessibilityFrontmost");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityHiddenX = "isAccessibilityHidden";
		static readonly NativeHandle selIsAccessibilityHiddenXHandle = Selector.GetHandle ("isAccessibilityHidden");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityMainX = "isAccessibilityMain";
		static readonly NativeHandle selIsAccessibilityMainXHandle = Selector.GetHandle ("isAccessibilityMain");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityMinimizedX = "isAccessibilityMinimized";
		static readonly NativeHandle selIsAccessibilityMinimizedXHandle = Selector.GetHandle ("isAccessibilityMinimized");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityModalX = "isAccessibilityModal";
		static readonly NativeHandle selIsAccessibilityModalXHandle = Selector.GetHandle ("isAccessibilityModal");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityOrderedByRowX = "isAccessibilityOrderedByRow";
		static readonly NativeHandle selIsAccessibilityOrderedByRowXHandle = Selector.GetHandle ("isAccessibilityOrderedByRow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityProtectedContentX = "isAccessibilityProtectedContent";
		static readonly NativeHandle selIsAccessibilityProtectedContentXHandle = Selector.GetHandle ("isAccessibilityProtectedContent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilityRequiredX = "isAccessibilityRequired";
		static readonly NativeHandle selIsAccessibilityRequiredXHandle = Selector.GetHandle ("isAccessibilityRequired");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilitySelectedX = "isAccessibilitySelected";
		static readonly NativeHandle selIsAccessibilitySelectedXHandle = Selector.GetHandle ("isAccessibilitySelected");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAccessibilitySelectorAllowed_X = "isAccessibilitySelectorAllowed:";
		static readonly NativeHandle selIsAccessibilitySelectorAllowed_XHandle = Selector.GetHandle ("isAccessibilitySelectorAllowed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBezeledX = "isBezeled";
		static readonly NativeHandle selIsBezeledXHandle = Selector.GetHandle ("isBezeled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsBorderedX = "isBordered";
		static readonly NativeHandle selIsBorderedXHandle = Selector.GetHandle ("isBordered");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsContinuousX = "isContinuous";
		static readonly NativeHandle selIsContinuousXHandle = Selector.GetHandle ("isContinuous");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEditableX = "isEditable";
		static readonly NativeHandle selIsEditableXHandle = Selector.GetHandle ("isEditable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEnabledX = "isEnabled";
		static readonly NativeHandle selIsEnabledXHandle = Selector.GetHandle ("isEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEntryAcceptable_X = "isEntryAcceptable:";
		static readonly NativeHandle selIsEntryAcceptable_XHandle = Selector.GetHandle ("isEntryAcceptable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHighlightedX = "isHighlighted";
		static readonly NativeHandle selIsHighlightedXHandle = Selector.GetHandle ("isHighlighted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsOpaqueX = "isOpaque";
		static readonly NativeHandle selIsOpaqueXHandle = Selector.GetHandle ("isOpaque");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsScrollableX = "isScrollable";
		static readonly NativeHandle selIsScrollableXHandle = Selector.GetHandle ("isScrollable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSelectableX = "isSelectable";
		static readonly NativeHandle selIsSelectableXHandle = Selector.GetHandle ("isSelectable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyEquivalentX = "keyEquivalent";
		static readonly NativeHandle selKeyEquivalentXHandle = Selector.GetHandle ("keyEquivalent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineBreakModeX = "lineBreakMode";
		static readonly NativeHandle selLineBreakModeXHandle = Selector.GetHandle ("lineBreakMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuX = "menu";
		static readonly NativeHandle selMenuXHandle = Selector.GetHandle ("menu");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuForEvent_InRect_OfView_X = "menuForEvent:inRect:ofView:";
		static readonly NativeHandle selMenuForEvent_InRect_OfView_XHandle = Selector.GetHandle ("menuForEvent:inRect:ofView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMnemonicX = "mnemonic";
		static readonly NativeHandle selMnemonicXHandle = Selector.GetHandle ("mnemonic");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMnemonicLocationX = "mnemonicLocation";
		static readonly NativeHandle selMnemonicLocationXHandle = Selector.GetHandle ("mnemonicLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseDownFlagsX = "mouseDownFlags";
		static readonly NativeHandle selMouseDownFlagsXHandle = Selector.GetHandle ("mouseDownFlags");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextStateX = "nextState";
		static readonly NativeHandle selNextStateXHandle = Selector.GetHandle ("nextState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectValueX = "objectValue";
		static readonly NativeHandle selObjectValueXHandle = Selector.GetHandle ("objectValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformClick_X = "performClick:";
		static readonly NativeHandle selPerformClick_XHandle = Selector.GetHandle ("performClick:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrefersTrackingUntilMouseUpX = "prefersTrackingUntilMouseUp";
		static readonly NativeHandle selPrefersTrackingUntilMouseUpXHandle = Selector.GetHandle ("prefersTrackingUntilMouseUp");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRefusesFirstResponderX = "refusesFirstResponder";
		static readonly NativeHandle selRefusesFirstResponderXHandle = Selector.GetHandle ("refusesFirstResponder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRepresentedObjectX = "representedObject";
		static readonly NativeHandle selRepresentedObjectXHandle = Selector.GetHandle ("representedObject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetCursorRect_InView_X = "resetCursorRect:inView:";
		static readonly NativeHandle selResetCursorRect_InView_XHandle = Selector.GetHandle ("resetCursorRect:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectWithFrame_InView_Editor_Delegate_Start_Length_X = "selectWithFrame:inView:editor:delegate:start:length:";
		static readonly NativeHandle selSelectWithFrame_InView_Editor_Delegate_Start_Length_XHandle = Selector.GetHandle ("selectWithFrame:inView:editor:delegate:start:length:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendActionOn_X = "sendActionOn:";
		static readonly NativeHandle selSendActionOn_XHandle = Selector.GetHandle ("sendActionOn:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendsActionOnEndEditingX = "sendsActionOnEndEditing";
		static readonly NativeHandle selSendsActionOnEndEditingXHandle = Selector.GetHandle ("sendsActionOnEndEditing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityActivationPoint_X = "setAccessibilityActivationPoint:";
		static readonly NativeHandle selSetAccessibilityActivationPoint_XHandle = Selector.GetHandle ("setAccessibilityActivationPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityAllowedValues_X = "setAccessibilityAllowedValues:";
		static readonly NativeHandle selSetAccessibilityAllowedValues_XHandle = Selector.GetHandle ("setAccessibilityAllowedValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityAlternateUIVisible_X = "setAccessibilityAlternateUIVisible:";
		static readonly NativeHandle selSetAccessibilityAlternateUIVisible_XHandle = Selector.GetHandle ("setAccessibilityAlternateUIVisible:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityApplicationFocusedUIElement_X = "setAccessibilityApplicationFocusedUIElement:";
		static readonly NativeHandle selSetAccessibilityApplicationFocusedUIElement_XHandle = Selector.GetHandle ("setAccessibilityApplicationFocusedUIElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityAttributedUserInputLabels_X = "setAccessibilityAttributedUserInputLabels:";
		static readonly NativeHandle selSetAccessibilityAttributedUserInputLabels_XHandle = Selector.GetHandle ("setAccessibilityAttributedUserInputLabels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityCancelButton_X = "setAccessibilityCancelButton:";
		static readonly NativeHandle selSetAccessibilityCancelButton_XHandle = Selector.GetHandle ("setAccessibilityCancelButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityChildren_X = "setAccessibilityChildren:";
		static readonly NativeHandle selSetAccessibilityChildren_XHandle = Selector.GetHandle ("setAccessibilityChildren:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityChildrenInNavigationOrder_X = "setAccessibilityChildrenInNavigationOrder:";
		static readonly NativeHandle selSetAccessibilityChildrenInNavigationOrder_XHandle = Selector.GetHandle ("setAccessibilityChildrenInNavigationOrder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityClearButton_X = "setAccessibilityClearButton:";
		static readonly NativeHandle selSetAccessibilityClearButton_XHandle = Selector.GetHandle ("setAccessibilityClearButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityCloseButton_X = "setAccessibilityCloseButton:";
		static readonly NativeHandle selSetAccessibilityCloseButton_XHandle = Selector.GetHandle ("setAccessibilityCloseButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityColumnCount_X = "setAccessibilityColumnCount:";
		static readonly NativeHandle selSetAccessibilityColumnCount_XHandle = Selector.GetHandle ("setAccessibilityColumnCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityColumnHeaderUIElements_X = "setAccessibilityColumnHeaderUIElements:";
		static readonly NativeHandle selSetAccessibilityColumnHeaderUIElements_XHandle = Selector.GetHandle ("setAccessibilityColumnHeaderUIElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityColumnIndexRange_X = "setAccessibilityColumnIndexRange:";
		static readonly NativeHandle selSetAccessibilityColumnIndexRange_XHandle = Selector.GetHandle ("setAccessibilityColumnIndexRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityColumnTitles_X = "setAccessibilityColumnTitles:";
		static readonly NativeHandle selSetAccessibilityColumnTitles_XHandle = Selector.GetHandle ("setAccessibilityColumnTitles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityColumns_X = "setAccessibilityColumns:";
		static readonly NativeHandle selSetAccessibilityColumns_XHandle = Selector.GetHandle ("setAccessibilityColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityContents_X = "setAccessibilityContents:";
		static readonly NativeHandle selSetAccessibilityContents_XHandle = Selector.GetHandle ("setAccessibilityContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityCriticalValue_X = "setAccessibilityCriticalValue:";
		static readonly NativeHandle selSetAccessibilityCriticalValue_XHandle = Selector.GetHandle ("setAccessibilityCriticalValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityCustomActions_X = "setAccessibilityCustomActions:";
		static readonly NativeHandle selSetAccessibilityCustomActions_XHandle = Selector.GetHandle ("setAccessibilityCustomActions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityCustomRotors_X = "setAccessibilityCustomRotors:";
		static readonly NativeHandle selSetAccessibilityCustomRotors_XHandle = Selector.GetHandle ("setAccessibilityCustomRotors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityDecrementButton_X = "setAccessibilityDecrementButton:";
		static readonly NativeHandle selSetAccessibilityDecrementButton_XHandle = Selector.GetHandle ("setAccessibilityDecrementButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityDefaultButton_X = "setAccessibilityDefaultButton:";
		static readonly NativeHandle selSetAccessibilityDefaultButton_XHandle = Selector.GetHandle ("setAccessibilityDefaultButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityDisclosed_X = "setAccessibilityDisclosed:";
		static readonly NativeHandle selSetAccessibilityDisclosed_XHandle = Selector.GetHandle ("setAccessibilityDisclosed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityDisclosedByRow_X = "setAccessibilityDisclosedByRow:";
		static readonly NativeHandle selSetAccessibilityDisclosedByRow_XHandle = Selector.GetHandle ("setAccessibilityDisclosedByRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityDisclosedRows_X = "setAccessibilityDisclosedRows:";
		static readonly NativeHandle selSetAccessibilityDisclosedRows_XHandle = Selector.GetHandle ("setAccessibilityDisclosedRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityDisclosureLevel_X = "setAccessibilityDisclosureLevel:";
		static readonly NativeHandle selSetAccessibilityDisclosureLevel_XHandle = Selector.GetHandle ("setAccessibilityDisclosureLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityDocument_X = "setAccessibilityDocument:";
		static readonly NativeHandle selSetAccessibilityDocument_XHandle = Selector.GetHandle ("setAccessibilityDocument:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityEdited_X = "setAccessibilityEdited:";
		static readonly NativeHandle selSetAccessibilityEdited_XHandle = Selector.GetHandle ("setAccessibilityEdited:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityElement_X = "setAccessibilityElement:";
		static readonly NativeHandle selSetAccessibilityElement_XHandle = Selector.GetHandle ("setAccessibilityElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityEnabled_X = "setAccessibilityEnabled:";
		static readonly NativeHandle selSetAccessibilityEnabled_XHandle = Selector.GetHandle ("setAccessibilityEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityExpanded_X = "setAccessibilityExpanded:";
		static readonly NativeHandle selSetAccessibilityExpanded_XHandle = Selector.GetHandle ("setAccessibilityExpanded:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityExtrasMenuBar_X = "setAccessibilityExtrasMenuBar:";
		static readonly NativeHandle selSetAccessibilityExtrasMenuBar_XHandle = Selector.GetHandle ("setAccessibilityExtrasMenuBar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityFilename_X = "setAccessibilityFilename:";
		static readonly NativeHandle selSetAccessibilityFilename_XHandle = Selector.GetHandle ("setAccessibilityFilename:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityFocused_X = "setAccessibilityFocused:";
		static readonly NativeHandle selSetAccessibilityFocused_XHandle = Selector.GetHandle ("setAccessibilityFocused:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityFocusedWindow_X = "setAccessibilityFocusedWindow:";
		static readonly NativeHandle selSetAccessibilityFocusedWindow_XHandle = Selector.GetHandle ("setAccessibilityFocusedWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityFrame_X = "setAccessibilityFrame:";
		static readonly NativeHandle selSetAccessibilityFrame_XHandle = Selector.GetHandle ("setAccessibilityFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityFrontmost_X = "setAccessibilityFrontmost:";
		static readonly NativeHandle selSetAccessibilityFrontmost_XHandle = Selector.GetHandle ("setAccessibilityFrontmost:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityFullScreenButton_X = "setAccessibilityFullScreenButton:";
		static readonly NativeHandle selSetAccessibilityFullScreenButton_XHandle = Selector.GetHandle ("setAccessibilityFullScreenButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityGrowArea_X = "setAccessibilityGrowArea:";
		static readonly NativeHandle selSetAccessibilityGrowArea_XHandle = Selector.GetHandle ("setAccessibilityGrowArea:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityHandles_X = "setAccessibilityHandles:";
		static readonly NativeHandle selSetAccessibilityHandles_XHandle = Selector.GetHandle ("setAccessibilityHandles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityHeader_X = "setAccessibilityHeader:";
		static readonly NativeHandle selSetAccessibilityHeader_XHandle = Selector.GetHandle ("setAccessibilityHeader:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityHelp_X = "setAccessibilityHelp:";
		static readonly NativeHandle selSetAccessibilityHelp_XHandle = Selector.GetHandle ("setAccessibilityHelp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityHidden_X = "setAccessibilityHidden:";
		static readonly NativeHandle selSetAccessibilityHidden_XHandle = Selector.GetHandle ("setAccessibilityHidden:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityHorizontalScrollBar_X = "setAccessibilityHorizontalScrollBar:";
		static readonly NativeHandle selSetAccessibilityHorizontalScrollBar_XHandle = Selector.GetHandle ("setAccessibilityHorizontalScrollBar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityHorizontalUnitDescription_X = "setAccessibilityHorizontalUnitDescription:";
		static readonly NativeHandle selSetAccessibilityHorizontalUnitDescription_XHandle = Selector.GetHandle ("setAccessibilityHorizontalUnitDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityHorizontalUnits_X = "setAccessibilityHorizontalUnits:";
		static readonly NativeHandle selSetAccessibilityHorizontalUnits_XHandle = Selector.GetHandle ("setAccessibilityHorizontalUnits:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityIdentifier_X = "setAccessibilityIdentifier:";
		static readonly NativeHandle selSetAccessibilityIdentifier_XHandle = Selector.GetHandle ("setAccessibilityIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityIncrementButton_X = "setAccessibilityIncrementButton:";
		static readonly NativeHandle selSetAccessibilityIncrementButton_XHandle = Selector.GetHandle ("setAccessibilityIncrementButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityIndex_X = "setAccessibilityIndex:";
		static readonly NativeHandle selSetAccessibilityIndex_XHandle = Selector.GetHandle ("setAccessibilityIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityInsertionPointLineNumber_X = "setAccessibilityInsertionPointLineNumber:";
		static readonly NativeHandle selSetAccessibilityInsertionPointLineNumber_XHandle = Selector.GetHandle ("setAccessibilityInsertionPointLineNumber:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityLabel_X = "setAccessibilityLabel:";
		static readonly NativeHandle selSetAccessibilityLabel_XHandle = Selector.GetHandle ("setAccessibilityLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityLabelUIElements_X = "setAccessibilityLabelUIElements:";
		static readonly NativeHandle selSetAccessibilityLabelUIElements_XHandle = Selector.GetHandle ("setAccessibilityLabelUIElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityLabelValue_X = "setAccessibilityLabelValue:";
		static readonly NativeHandle selSetAccessibilityLabelValue_XHandle = Selector.GetHandle ("setAccessibilityLabelValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityLinkedUIElements_X = "setAccessibilityLinkedUIElements:";
		static readonly NativeHandle selSetAccessibilityLinkedUIElements_XHandle = Selector.GetHandle ("setAccessibilityLinkedUIElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMain_X = "setAccessibilityMain:";
		static readonly NativeHandle selSetAccessibilityMain_XHandle = Selector.GetHandle ("setAccessibilityMain:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMainWindow_X = "setAccessibilityMainWindow:";
		static readonly NativeHandle selSetAccessibilityMainWindow_XHandle = Selector.GetHandle ("setAccessibilityMainWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMarkerGroupUIElement_X = "setAccessibilityMarkerGroupUIElement:";
		static readonly NativeHandle selSetAccessibilityMarkerGroupUIElement_XHandle = Selector.GetHandle ("setAccessibilityMarkerGroupUIElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMarkerTypeDescription_X = "setAccessibilityMarkerTypeDescription:";
		static readonly NativeHandle selSetAccessibilityMarkerTypeDescription_XHandle = Selector.GetHandle ("setAccessibilityMarkerTypeDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMarkerUIElements_X = "setAccessibilityMarkerUIElements:";
		static readonly NativeHandle selSetAccessibilityMarkerUIElements_XHandle = Selector.GetHandle ("setAccessibilityMarkerUIElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMarkerValues_X = "setAccessibilityMarkerValues:";
		static readonly NativeHandle selSetAccessibilityMarkerValues_XHandle = Selector.GetHandle ("setAccessibilityMarkerValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMaxValue_X = "setAccessibilityMaxValue:";
		static readonly NativeHandle selSetAccessibilityMaxValue_XHandle = Selector.GetHandle ("setAccessibilityMaxValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMenuBar_X = "setAccessibilityMenuBar:";
		static readonly NativeHandle selSetAccessibilityMenuBar_XHandle = Selector.GetHandle ("setAccessibilityMenuBar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMinValue_X = "setAccessibilityMinValue:";
		static readonly NativeHandle selSetAccessibilityMinValue_XHandle = Selector.GetHandle ("setAccessibilityMinValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMinimizeButton_X = "setAccessibilityMinimizeButton:";
		static readonly NativeHandle selSetAccessibilityMinimizeButton_XHandle = Selector.GetHandle ("setAccessibilityMinimizeButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityMinimized_X = "setAccessibilityMinimized:";
		static readonly NativeHandle selSetAccessibilityMinimized_XHandle = Selector.GetHandle ("setAccessibilityMinimized:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityModal_X = "setAccessibilityModal:";
		static readonly NativeHandle selSetAccessibilityModal_XHandle = Selector.GetHandle ("setAccessibilityModal:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityNextContents_X = "setAccessibilityNextContents:";
		static readonly NativeHandle selSetAccessibilityNextContents_XHandle = Selector.GetHandle ("setAccessibilityNextContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityNumberOfCharacters_X = "setAccessibilityNumberOfCharacters:";
		static readonly NativeHandle selSetAccessibilityNumberOfCharacters_XHandle = Selector.GetHandle ("setAccessibilityNumberOfCharacters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityOrderedByRow_X = "setAccessibilityOrderedByRow:";
		static readonly NativeHandle selSetAccessibilityOrderedByRow_XHandle = Selector.GetHandle ("setAccessibilityOrderedByRow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityOrientation_X = "setAccessibilityOrientation:";
		static readonly NativeHandle selSetAccessibilityOrientation_XHandle = Selector.GetHandle ("setAccessibilityOrientation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityOverflowButton_X = "setAccessibilityOverflowButton:";
		static readonly NativeHandle selSetAccessibilityOverflowButton_XHandle = Selector.GetHandle ("setAccessibilityOverflowButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityParent_X = "setAccessibilityParent:";
		static readonly NativeHandle selSetAccessibilityParent_XHandle = Selector.GetHandle ("setAccessibilityParent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityPlaceholderValue_X = "setAccessibilityPlaceholderValue:";
		static readonly NativeHandle selSetAccessibilityPlaceholderValue_XHandle = Selector.GetHandle ("setAccessibilityPlaceholderValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityPreviousContents_X = "setAccessibilityPreviousContents:";
		static readonly NativeHandle selSetAccessibilityPreviousContents_XHandle = Selector.GetHandle ("setAccessibilityPreviousContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityProtectedContent_X = "setAccessibilityProtectedContent:";
		static readonly NativeHandle selSetAccessibilityProtectedContent_XHandle = Selector.GetHandle ("setAccessibilityProtectedContent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityProxy_X = "setAccessibilityProxy:";
		static readonly NativeHandle selSetAccessibilityProxy_XHandle = Selector.GetHandle ("setAccessibilityProxy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityRequired_X = "setAccessibilityRequired:";
		static readonly NativeHandle selSetAccessibilityRequired_XHandle = Selector.GetHandle ("setAccessibilityRequired:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityRole_X = "setAccessibilityRole:";
		static readonly NativeHandle selSetAccessibilityRole_XHandle = Selector.GetHandle ("setAccessibilityRole:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityRoleDescription_X = "setAccessibilityRoleDescription:";
		static readonly NativeHandle selSetAccessibilityRoleDescription_XHandle = Selector.GetHandle ("setAccessibilityRoleDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityRowCount_X = "setAccessibilityRowCount:";
		static readonly NativeHandle selSetAccessibilityRowCount_XHandle = Selector.GetHandle ("setAccessibilityRowCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityRowHeaderUIElements_X = "setAccessibilityRowHeaderUIElements:";
		static readonly NativeHandle selSetAccessibilityRowHeaderUIElements_XHandle = Selector.GetHandle ("setAccessibilityRowHeaderUIElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityRowIndexRange_X = "setAccessibilityRowIndexRange:";
		static readonly NativeHandle selSetAccessibilityRowIndexRange_XHandle = Selector.GetHandle ("setAccessibilityRowIndexRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityRows_X = "setAccessibilityRows:";
		static readonly NativeHandle selSetAccessibilityRows_XHandle = Selector.GetHandle ("setAccessibilityRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityRulerMarkerType_X = "setAccessibilityRulerMarkerType:";
		static readonly NativeHandle selSetAccessibilityRulerMarkerType_XHandle = Selector.GetHandle ("setAccessibilityRulerMarkerType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySearchButton_X = "setAccessibilitySearchButton:";
		static readonly NativeHandle selSetAccessibilitySearchButton_XHandle = Selector.GetHandle ("setAccessibilitySearchButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySearchMenu_X = "setAccessibilitySearchMenu:";
		static readonly NativeHandle selSetAccessibilitySearchMenu_XHandle = Selector.GetHandle ("setAccessibilitySearchMenu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelected_X = "setAccessibilitySelected:";
		static readonly NativeHandle selSetAccessibilitySelected_XHandle = Selector.GetHandle ("setAccessibilitySelected:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelectedCells_X = "setAccessibilitySelectedCells:";
		static readonly NativeHandle selSetAccessibilitySelectedCells_XHandle = Selector.GetHandle ("setAccessibilitySelectedCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelectedChildren_X = "setAccessibilitySelectedChildren:";
		static readonly NativeHandle selSetAccessibilitySelectedChildren_XHandle = Selector.GetHandle ("setAccessibilitySelectedChildren:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelectedColumns_X = "setAccessibilitySelectedColumns:";
		static readonly NativeHandle selSetAccessibilitySelectedColumns_XHandle = Selector.GetHandle ("setAccessibilitySelectedColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelectedRows_X = "setAccessibilitySelectedRows:";
		static readonly NativeHandle selSetAccessibilitySelectedRows_XHandle = Selector.GetHandle ("setAccessibilitySelectedRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelectedText_X = "setAccessibilitySelectedText:";
		static readonly NativeHandle selSetAccessibilitySelectedText_XHandle = Selector.GetHandle ("setAccessibilitySelectedText:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelectedTextRange_X = "setAccessibilitySelectedTextRange:";
		static readonly NativeHandle selSetAccessibilitySelectedTextRange_XHandle = Selector.GetHandle ("setAccessibilitySelectedTextRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySelectedTextRanges_X = "setAccessibilitySelectedTextRanges:";
		static readonly NativeHandle selSetAccessibilitySelectedTextRanges_XHandle = Selector.GetHandle ("setAccessibilitySelectedTextRanges:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityServesAsTitleForUIElements_X = "setAccessibilityServesAsTitleForUIElements:";
		static readonly NativeHandle selSetAccessibilityServesAsTitleForUIElements_XHandle = Selector.GetHandle ("setAccessibilityServesAsTitleForUIElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySharedCharacterRange_X = "setAccessibilitySharedCharacterRange:";
		static readonly NativeHandle selSetAccessibilitySharedCharacterRange_XHandle = Selector.GetHandle ("setAccessibilitySharedCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySharedFocusElements_X = "setAccessibilitySharedFocusElements:";
		static readonly NativeHandle selSetAccessibilitySharedFocusElements_XHandle = Selector.GetHandle ("setAccessibilitySharedFocusElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySharedTextUIElements_X = "setAccessibilitySharedTextUIElements:";
		static readonly NativeHandle selSetAccessibilitySharedTextUIElements_XHandle = Selector.GetHandle ("setAccessibilitySharedTextUIElements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityShownMenu_X = "setAccessibilityShownMenu:";
		static readonly NativeHandle selSetAccessibilityShownMenu_XHandle = Selector.GetHandle ("setAccessibilityShownMenu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySortDirection_X = "setAccessibilitySortDirection:";
		static readonly NativeHandle selSetAccessibilitySortDirection_XHandle = Selector.GetHandle ("setAccessibilitySortDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySplitters_X = "setAccessibilitySplitters:";
		static readonly NativeHandle selSetAccessibilitySplitters_XHandle = Selector.GetHandle ("setAccessibilitySplitters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilitySubrole_X = "setAccessibilitySubrole:";
		static readonly NativeHandle selSetAccessibilitySubrole_XHandle = Selector.GetHandle ("setAccessibilitySubrole:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityTabs_X = "setAccessibilityTabs:";
		static readonly NativeHandle selSetAccessibilityTabs_XHandle = Selector.GetHandle ("setAccessibilityTabs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityTitle_X = "setAccessibilityTitle:";
		static readonly NativeHandle selSetAccessibilityTitle_XHandle = Selector.GetHandle ("setAccessibilityTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityTitleUIElement_X = "setAccessibilityTitleUIElement:";
		static readonly NativeHandle selSetAccessibilityTitleUIElement_XHandle = Selector.GetHandle ("setAccessibilityTitleUIElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityToolbarButton_X = "setAccessibilityToolbarButton:";
		static readonly NativeHandle selSetAccessibilityToolbarButton_XHandle = Selector.GetHandle ("setAccessibilityToolbarButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityTopLevelUIElement_X = "setAccessibilityTopLevelUIElement:";
		static readonly NativeHandle selSetAccessibilityTopLevelUIElement_XHandle = Selector.GetHandle ("setAccessibilityTopLevelUIElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityURL_X = "setAccessibilityURL:";
		static readonly NativeHandle selSetAccessibilityURL_XHandle = Selector.GetHandle ("setAccessibilityURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityUnitDescription_X = "setAccessibilityUnitDescription:";
		static readonly NativeHandle selSetAccessibilityUnitDescription_XHandle = Selector.GetHandle ("setAccessibilityUnitDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityUnits_X = "setAccessibilityUnits:";
		static readonly NativeHandle selSetAccessibilityUnits_XHandle = Selector.GetHandle ("setAccessibilityUnits:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityUserInputLabels_X = "setAccessibilityUserInputLabels:";
		static readonly NativeHandle selSetAccessibilityUserInputLabels_XHandle = Selector.GetHandle ("setAccessibilityUserInputLabels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityValue_X = "setAccessibilityValue:";
		static readonly NativeHandle selSetAccessibilityValue_XHandle = Selector.GetHandle ("setAccessibilityValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityValueDescription_X = "setAccessibilityValueDescription:";
		static readonly NativeHandle selSetAccessibilityValueDescription_XHandle = Selector.GetHandle ("setAccessibilityValueDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityVerticalScrollBar_X = "setAccessibilityVerticalScrollBar:";
		static readonly NativeHandle selSetAccessibilityVerticalScrollBar_XHandle = Selector.GetHandle ("setAccessibilityVerticalScrollBar:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityVerticalUnitDescription_X = "setAccessibilityVerticalUnitDescription:";
		static readonly NativeHandle selSetAccessibilityVerticalUnitDescription_XHandle = Selector.GetHandle ("setAccessibilityVerticalUnitDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityVerticalUnits_X = "setAccessibilityVerticalUnits:";
		static readonly NativeHandle selSetAccessibilityVerticalUnits_XHandle = Selector.GetHandle ("setAccessibilityVerticalUnits:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityVisibleCells_X = "setAccessibilityVisibleCells:";
		static readonly NativeHandle selSetAccessibilityVisibleCells_XHandle = Selector.GetHandle ("setAccessibilityVisibleCells:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityVisibleCharacterRange_X = "setAccessibilityVisibleCharacterRange:";
		static readonly NativeHandle selSetAccessibilityVisibleCharacterRange_XHandle = Selector.GetHandle ("setAccessibilityVisibleCharacterRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityVisibleChildren_X = "setAccessibilityVisibleChildren:";
		static readonly NativeHandle selSetAccessibilityVisibleChildren_XHandle = Selector.GetHandle ("setAccessibilityVisibleChildren:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityVisibleColumns_X = "setAccessibilityVisibleColumns:";
		static readonly NativeHandle selSetAccessibilityVisibleColumns_XHandle = Selector.GetHandle ("setAccessibilityVisibleColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityVisibleRows_X = "setAccessibilityVisibleRows:";
		static readonly NativeHandle selSetAccessibilityVisibleRows_XHandle = Selector.GetHandle ("setAccessibilityVisibleRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityWarningValue_X = "setAccessibilityWarningValue:";
		static readonly NativeHandle selSetAccessibilityWarningValue_XHandle = Selector.GetHandle ("setAccessibilityWarningValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityWindow_X = "setAccessibilityWindow:";
		static readonly NativeHandle selSetAccessibilityWindow_XHandle = Selector.GetHandle ("setAccessibilityWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityWindows_X = "setAccessibilityWindows:";
		static readonly NativeHandle selSetAccessibilityWindows_XHandle = Selector.GetHandle ("setAccessibilityWindows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityZoomButton_X = "setAccessibilityZoomButton:";
		static readonly NativeHandle selSetAccessibilityZoomButton_XHandle = Selector.GetHandle ("setAccessibilityZoomButton:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAction_X = "setAction:";
		static readonly NativeHandle selSetAction_XHandle = Selector.GetHandle ("setAction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlignment_X = "setAlignment:";
		static readonly NativeHandle selSetAlignment_XHandle = Selector.GetHandle ("setAlignment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsEditingTextAttributes_X = "setAllowsEditingTextAttributes:";
		static readonly NativeHandle selSetAllowsEditingTextAttributes_XHandle = Selector.GetHandle ("setAllowsEditingTextAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsMixedState_X = "setAllowsMixedState:";
		static readonly NativeHandle selSetAllowsMixedState_XHandle = Selector.GetHandle ("setAllowsMixedState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsUndo_X = "setAllowsUndo:";
		static readonly NativeHandle selSetAllowsUndo_XHandle = Selector.GetHandle ("setAllowsUndo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributedStringValue_X = "setAttributedStringValue:";
		static readonly NativeHandle selSetAttributedStringValue_XHandle = Selector.GetHandle ("setAttributedStringValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundStyle_X = "setBackgroundStyle:";
		static readonly NativeHandle selSetBackgroundStyle_XHandle = Selector.GetHandle ("setBackgroundStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBaseWritingDirection_X = "setBaseWritingDirection:";
		static readonly NativeHandle selSetBaseWritingDirection_XHandle = Selector.GetHandle ("setBaseWritingDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBezeled_X = "setBezeled:";
		static readonly NativeHandle selSetBezeled_XHandle = Selector.GetHandle ("setBezeled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBordered_X = "setBordered:";
		static readonly NativeHandle selSetBordered_XHandle = Selector.GetHandle ("setBordered:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCellAttribute_To_X = "setCellAttribute:to:";
		static readonly NativeHandle selSetCellAttribute_To_XHandle = Selector.GetHandle ("setCellAttribute:to:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContinuous_X = "setContinuous:";
		static readonly NativeHandle selSetContinuous_XHandle = Selector.GetHandle ("setContinuous:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlSize_X = "setControlSize:";
		static readonly NativeHandle selSetControlSize_XHandle = Selector.GetHandle ("setControlSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlTint_X = "setControlTint:";
		static readonly NativeHandle selSetControlTint_XHandle = Selector.GetHandle ("setControlTint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetControlView_X = "setControlView:";
		static readonly NativeHandle selSetControlView_XHandle = Selector.GetHandle ("setControlView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDoubleValue_X = "setDoubleValue:";
		static readonly NativeHandle selSetDoubleValue_XHandle = Selector.GetHandle ("setDoubleValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEditable_X = "setEditable:";
		static readonly NativeHandle selSetEditable_XHandle = Selector.GetHandle ("setEditable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnabled_X = "setEnabled:";
		static readonly NativeHandle selSetEnabled_XHandle = Selector.GetHandle ("setEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFloatValue_X = "setFloatValue:";
		static readonly NativeHandle selSetFloatValue_XHandle = Selector.GetHandle ("setFloatValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFocusRingType_X = "setFocusRingType:";
		static readonly NativeHandle selSetFocusRingType_XHandle = Selector.GetHandle ("setFocusRingType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFont_X = "setFont:";
		static readonly NativeHandle selSetFont_XHandle = Selector.GetHandle ("setFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFormatter_X = "setFormatter:";
		static readonly NativeHandle selSetFormatter_XHandle = Selector.GetHandle ("setFormatter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHighlighted_X = "setHighlighted:";
		static readonly NativeHandle selSetHighlighted_XHandle = Selector.GetHandle ("setHighlighted:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIdentifier_X = "setIdentifier:";
		static readonly NativeHandle selSetIdentifier_XHandle = Selector.GetHandle ("setIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetImage_X = "setImage:";
		static readonly NativeHandle selSetImage_XHandle = Selector.GetHandle ("setImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetImportsGraphics_X = "setImportsGraphics:";
		static readonly NativeHandle selSetImportsGraphics_XHandle = Selector.GetHandle ("setImportsGraphics:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIntValue_X = "setIntValue:";
		static readonly NativeHandle selSetIntValue_XHandle = Selector.GetHandle ("setIntValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIntegerValue_X = "setIntegerValue:";
		static readonly NativeHandle selSetIntegerValue_XHandle = Selector.GetHandle ("setIntegerValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineBreakMode_X = "setLineBreakMode:";
		static readonly NativeHandle selSetLineBreakMode_XHandle = Selector.GetHandle ("setLineBreakMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMenu_X = "setMenu:";
		static readonly NativeHandle selSetMenu_XHandle = Selector.GetHandle ("setMenu:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMnemonicLocation_X = "setMnemonicLocation:";
		static readonly NativeHandle selSetMnemonicLocation_XHandle = Selector.GetHandle ("setMnemonicLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNextStateX = "setNextState";
		static readonly NativeHandle selSetNextStateXHandle = Selector.GetHandle ("setNextState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObjectValue_X = "setObjectValue:";
		static readonly NativeHandle selSetObjectValue_XHandle = Selector.GetHandle ("setObjectValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRepresentedObject_X = "setRepresentedObject:";
		static readonly NativeHandle selSetRepresentedObject_XHandle = Selector.GetHandle ("setRepresentedObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScrollable_X = "setScrollable:";
		static readonly NativeHandle selSetScrollable_XHandle = Selector.GetHandle ("setScrollable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectable_X = "setSelectable:";
		static readonly NativeHandle selSetSelectable_XHandle = Selector.GetHandle ("setSelectable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSendsActionOnEndEditing_X = "setSendsActionOnEndEditing:";
		static readonly NativeHandle selSetSendsActionOnEndEditing_XHandle = Selector.GetHandle ("setSendsActionOnEndEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowsFirstResponder_X = "setShowsFirstResponder:";
		static readonly NativeHandle selSetShowsFirstResponder_XHandle = Selector.GetHandle ("setShowsFirstResponder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetState_X = "setState:";
		static readonly NativeHandle selSetState_XHandle = Selector.GetHandle ("setState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStringValue_X = "setStringValue:";
		static readonly NativeHandle selSetStringValue_XHandle = Selector.GetHandle ("setStringValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTag_X = "setTag:";
		static readonly NativeHandle selSetTag_XHandle = Selector.GetHandle ("setTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTarget_X = "setTarget:";
		static readonly NativeHandle selSetTarget_XHandle = Selector.GetHandle ("setTarget:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitleWithMnemonic_X = "setTitleWithMnemonic:";
		static readonly NativeHandle selSetTitleWithMnemonic_XHandle = Selector.GetHandle ("setTitleWithMnemonic:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTruncatesLastVisibleLine_X = "setTruncatesLastVisibleLine:";
		static readonly NativeHandle selSetTruncatesLastVisibleLine_XHandle = Selector.GetHandle ("setTruncatesLastVisibleLine:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetType_X = "setType:";
		static readonly NativeHandle selSetType_XHandle = Selector.GetHandle ("setType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUpFieldEditorAttributes_X = "setUpFieldEditorAttributes:";
		static readonly NativeHandle selSetUpFieldEditorAttributes_XHandle = Selector.GetHandle ("setUpFieldEditorAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserInterfaceLayoutDirection_X = "setUserInterfaceLayoutDirection:";
		static readonly NativeHandle selSetUserInterfaceLayoutDirection_XHandle = Selector.GetHandle ("setUserInterfaceLayoutDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesSingleLineMode_X = "setUsesSingleLineMode:";
		static readonly NativeHandle selSetUsesSingleLineMode_XHandle = Selector.GetHandle ("setUsesSingleLineMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWraps_X = "setWraps:";
		static readonly NativeHandle selSetWraps_XHandle = Selector.GetHandle ("setWraps:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowsFirstResponderX = "showsFirstResponder";
		static readonly NativeHandle selShowsFirstResponderXHandle = Selector.GetHandle ("showsFirstResponder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartTrackingAt_InView_X = "startTrackingAt:inView:";
		static readonly NativeHandle selStartTrackingAt_InView_XHandle = Selector.GetHandle ("startTrackingAt:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStateX = "state";
		static readonly NativeHandle selStateXHandle = Selector.GetHandle ("state");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopTracking_At_InView_MouseIsUp_X = "stopTracking:at:inView:mouseIsUp:";
		static readonly NativeHandle selStopTracking_At_InView_MouseIsUp_XHandle = Selector.GetHandle ("stopTracking:at:inView:mouseIsUp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringValueX = "stringValue";
		static readonly NativeHandle selStringValueXHandle = Selector.GetHandle ("stringValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagX = "tag";
		static readonly NativeHandle selTagXHandle = Selector.GetHandle ("tag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTakeDoubleValueFrom_X = "takeDoubleValueFrom:";
		static readonly NativeHandle selTakeDoubleValueFrom_XHandle = Selector.GetHandle ("takeDoubleValueFrom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTakeFloatValueFrom_X = "takeFloatValueFrom:";
		static readonly NativeHandle selTakeFloatValueFrom_XHandle = Selector.GetHandle ("takeFloatValueFrom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTakeIntValueFrom_X = "takeIntValueFrom:";
		static readonly NativeHandle selTakeIntValueFrom_XHandle = Selector.GetHandle ("takeIntValueFrom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTakeIntegerValueFrom_X = "takeIntegerValueFrom:";
		static readonly NativeHandle selTakeIntegerValueFrom_XHandle = Selector.GetHandle ("takeIntegerValueFrom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTakeObjectValueFrom_X = "takeObjectValueFrom:";
		static readonly NativeHandle selTakeObjectValueFrom_XHandle = Selector.GetHandle ("takeObjectValueFrom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTakeStringValueFrom_X = "takeStringValueFrom:";
		static readonly NativeHandle selTakeStringValueFrom_XHandle = Selector.GetHandle ("takeStringValueFrom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTargetX = "target";
		static readonly NativeHandle selTargetXHandle = Selector.GetHandle ("target");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleRectForBounds_X = "titleRectForBounds:";
		static readonly NativeHandle selTitleRectForBounds_XHandle = Selector.GetHandle ("titleRectForBounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackMouse_InRect_OfView_UntilMouseUp_X = "trackMouse:inRect:ofView:untilMouseUp:";
		static readonly NativeHandle selTrackMouse_InRect_OfView_UntilMouseUp_XHandle = Selector.GetHandle ("trackMouse:inRect:ofView:untilMouseUp:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTruncatesLastVisibleLineX = "truncatesLastVisibleLine";
		static readonly NativeHandle selTruncatesLastVisibleLineXHandle = Selector.GetHandle ("truncatesLastVisibleLine");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeX = "type";
		static readonly NativeHandle selTypeXHandle = Selector.GetHandle ("type");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInterfaceLayoutDirectionX = "userInterfaceLayoutDirection";
		static readonly NativeHandle selUserInterfaceLayoutDirectionXHandle = Selector.GetHandle ("userInterfaceLayoutDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesSingleLineModeX = "usesSingleLineMode";
		static readonly NativeHandle selUsesSingleLineModeXHandle = Selector.GetHandle ("usesSingleLineMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWantsNotificationForMarkedTextX = "wantsNotificationForMarkedText";
		static readonly NativeHandle selWantsNotificationForMarkedTextXHandle = Selector.GetHandle ("wantsNotificationForMarkedText");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWrapsX = "wraps";
		static readonly NativeHandle selWrapsXHandle = Selector.GetHandle ("wraps");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCell");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSCell" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCell () : base (NSObjectFlag.Empty)
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
		public NSCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSCell (NSObjectFlag t) : base (t)
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
		protected internal NSCell (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initTextCell:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCell (string aString)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitTextCell_XHandle, nsaString), "initTextCell:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitTextCell_XHandle, nsaString), "initTextCell:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaString);
		}
		[Export ("initImageCell:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCell (NSImage image)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitImageCell_XHandle, image__handle__), "initImageCell:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitImageCell_XHandle, image__handle__), "initImageCell:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		[Export ("acceptsFirstResponder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AcceptsFirstResponder ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAcceptsFirstResponderXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAcceptsFirstResponderXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformAction:")]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AccessibilityPerformAction (NSString action)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAccessibilityPerformAction_XHandle, action__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccessibilityPerformAction_XHandle, action__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
		}
		[Export ("accessibilityPerformCancel")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformCancel ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformCancelXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformCancelXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformConfirm")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformConfirm ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformConfirmXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformConfirmXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformDecrement")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformDecrement ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformDecrementXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformDecrementXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformDelete")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformDelete ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformDeleteXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformDeleteXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformIncrement")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformIncrement ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformIncrementXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformIncrementXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformPick")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformPick ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformPickXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformPickXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformPress")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformPress ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformPressXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformPressXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformRaise")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformRaise ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformRaiseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformRaiseXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformShowAlternateUI")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformShowAlternateUI ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformShowAlternateUIXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformShowAlternateUIXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformShowDefaultUI")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformShowDefaultUI ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformShowDefaultUIXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformShowDefaultUIXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilityPerformShowMenu")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformShowMenu ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityPerformShowMenuXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityPerformShowMenuXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("calcDrawInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalcDrawInfo (CGRect aRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selCalcDrawInfo_XHandle, aRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selCalcDrawInfo_XHandle, aRect);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("cellAttribute:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint CellAttribute (NSCellAttribute aParameter)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr (this.Handle, selCellAttribute_XHandle, (UIntPtr) (ulong) aParameter);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selCellAttribute_XHandle, (UIntPtr) (ulong) aParameter);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("cellSizeForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize CellSizeForBounds (CGRect bounds)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGRect (this.Handle, selCellSizeForBounds_XHandle, bounds);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_CGRect (&__objc_super__, selCellSizeForBounds_XHandle, bounds);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("compare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (NSObject otherCell)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var otherCell__handle__ = otherCell!.GetNonNullHandle (nameof (otherCell));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selCompare_XHandle, otherCell__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompare_XHandle, otherCell__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (otherCell);
			return ret!;
		}
		[Export ("continueTracking:at:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContinueTracking (CGPoint lastPoint, CGPoint currentPoint, NSView inView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView!.GetNonNullHandle (nameof (inView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint_CGPoint_NativeHandle (this.Handle, selContinueTracking_At_InView_XHandle, lastPoint, currentPoint, inView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGPoint_CGPoint_NativeHandle (&__objc_super__, selContinueTracking_At_InView_XHandle, lastPoint, currentPoint, inView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
			return ret != 0;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("drawFocusRingMaskWithFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawFocusRing (CGRect cellFrameMask, NSView inControlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inControlView__handle__ = inControlView!.GetNonNullHandle (nameof (inControlView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, selDrawFocusRingMaskWithFrame_InView_XHandle, cellFrameMask, inControlView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selDrawFocusRingMaskWithFrame_InView_XHandle, cellFrameMask, inControlView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inControlView);
		}
		[Export ("drawInteriorWithFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawInteriorWithFrame (CGRect cellFrame, NSView inView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView!.GetNonNullHandle (nameof (inView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, selDrawInteriorWithFrame_InView_XHandle, cellFrame, inView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selDrawInteriorWithFrame_InView_XHandle, cellFrame, inView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
		}
		[Export ("drawWithExpansionFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawWithExpansionFrame (CGRect cellFrame, NSView inView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView!.GetNonNullHandle (nameof (inView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, selDrawWithExpansionFrame_InView_XHandle, cellFrame, inView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selDrawWithExpansionFrame_InView_XHandle, cellFrame, inView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
		}
		[Export ("drawWithFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawWithFrame (CGRect cellFrame, NSView inView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView!.GetNonNullHandle (nameof (inView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, selDrawWithFrame_InView_XHandle, cellFrame, inView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selDrawWithFrame_InView_XHandle, cellFrame, inView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
		}
		[Export ("drawingRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect DrawingRectForBounds (CGRect theRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, selDrawingRectForBounds_XHandle, theRect);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, selDrawingRectForBounds_XHandle, theRect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, selDrawingRectForBounds_XHandle, theRect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, selDrawingRectForBounds_XHandle, theRect);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("editWithFrame:inView:editor:delegate:event:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EditWithFrame (CGRect aRect, NSView? inView, NSText? editor, NSObject? delegateObject, NSEvent theEvent)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView.GetHandle ();
			var editor__handle__ = editor.GetHandle ();
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEditWithFrame_InView_Editor_Delegate_Event_XHandle, aRect, inView__handle__, editor__handle__, delegateObject__handle__, theEvent__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEditWithFrame_InView_Editor_Delegate_Event_XHandle, aRect, inView__handle__, editor__handle__, delegateObject__handle__, theEvent__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
			GC.KeepAlive (editor);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (theEvent);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
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
		[Export ("endEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndEditing (NSText? textObj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textObj__handle__ = textObj.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEndEditing_XHandle, textObj__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEndEditing_XHandle, textObj__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textObj);
		}
		[Export ("expansionFrameWithFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ExpansionFrame (CGRect withFrame, NSView inView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView!.GetNonNullHandle (nameof (inView));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, selExpansionFrameWithFrame_InView_XHandle, withFrame, inView__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, selExpansionFrameWithFrame_InView_XHandle, withFrame, inView__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selExpansionFrameWithFrame_InView_XHandle, withFrame, inView__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, selExpansionFrameWithFrame_InView_XHandle, withFrame, inView__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (inView);
			return ret!;
		}
		[Export ("fieldEditorForView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextView FieldEditorForView (NSView aControlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var aControlView__handle__ = aControlView!.GetNonNullHandle (nameof (aControlView));
			NSTextView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFieldEditorForView_XHandle, aControlView__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFieldEditorForView_XHandle, aControlView__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aControlView);
			return ret!;
		}
		[Export ("draggingImageComponentsWithFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDraggingImageComponent[] GenerateDraggingImageComponents (CGRect frame, NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			NSDraggingImageComponent[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSDraggingImageComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (this.Handle, selDraggingImageComponentsWithFrame_InView_XHandle, frame, view__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSDraggingImageComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selDraggingImageComponentsWithFrame_InView_XHandle, frame, view__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("accessibilityActionDescription:")]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString GetAccessibilityActionDescription (NSString action)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAccessibilityActionDescription_XHandle, action__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccessibilityActionDescription_XHandle, action__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("accessibilityArrayAttributeCount:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetAccessibilityArrayAttributeCount (NSString attribute)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attribute__handle__ = attribute!.GetNonNullHandle (nameof (attribute));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (this.Handle, selAccessibilityArrayAttributeCount_XHandle, attribute__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccessibilityArrayAttributeCount_XHandle, attribute__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attribute);
			return ret!;
		}
		[Export ("accessibilityArrayAttributeValues:index:maxCount:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] GetAccessibilityArrayAttributeValues (NSString attribute, nuint index, nuint maxCount)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attribute__handle__ = attribute!.GetNonNullHandle (nameof (attribute));
			NSObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, selAccessibilityArrayAttributeValues_Index_MaxCount_XHandle, attribute__handle__, index, maxCount), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr (&__objc_super__, selAccessibilityArrayAttributeValues_Index_MaxCount_XHandle, attribute__handle__, index, maxCount), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attribute);
			return ret!;
		}
		[Export ("accessibilityAttributedStringForRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
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
		[Export ("accessibilityCellForColumn:row:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetAccessibilityCellForColumn (nint column, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, selAccessibilityCellForColumn_Row_XHandle, column, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selAccessibilityCellForColumn_Row_XHandle, column, row), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityFocusedUIElement")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetAccessibilityFocusedUIElement ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityFocusedUIElementXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityFocusedUIElementXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityFrameForRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
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
		[Export ("accessibilityHitTest:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetAccessibilityHitTest (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selAccessibilityHitTest_XHandle, point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selAccessibilityHitTest_XHandle, point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityIndexOfChild:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetAccessibilityIndexOfChild (NSObject child)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var child__handle__ = child!.GetNonNullHandle (nameof (child));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (this.Handle, selAccessibilityIndexOfChild_XHandle, child__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccessibilityIndexOfChild_XHandle, child__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (child);
			return ret!;
		}
		[Export ("accessibilityLayoutPointForScreenPoint:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetAccessibilityLayoutForScreen (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, selAccessibilityLayoutPointForScreenPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint (&__objc_super__, selAccessibilityLayoutPointForScreenPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityLayoutSizeForScreenSize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetAccessibilityLayoutForScreen (CGSize size)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, selAccessibilityLayoutSizeForScreenSize_XHandle, size);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_CGSize (&__objc_super__, selAccessibilityLayoutSizeForScreenSize_XHandle, size);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityLineForIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
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
		[Export ("accessibilityRangeForPosition:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRange (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_CGPoint (this.Handle, selAccessibilityRangeForPosition_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_CGPoint (&__objc_super__, selAccessibilityRangeForPosition_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityRangeForIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRange (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (this.Handle, selAccessibilityRangeForIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_IntPtr (&__objc_super__, selAccessibilityRangeForIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityRangeForLine:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRangeForLine (nint line)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (this.Handle, selAccessibilityRangeForLine_XHandle, line);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_IntPtr (&__objc_super__, selAccessibilityRangeForLine_XHandle, line);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityRTFForRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetAccessibilityRtf (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, selAccessibilityRTFForRange_XHandle, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, selAccessibilityRTFForRange_XHandle, range), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityScreenPointForLayoutPoint:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetAccessibilityScreenForLayout (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, selAccessibilityScreenPointForLayoutPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint (&__objc_super__, selAccessibilityScreenPointForLayoutPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityScreenSizeForLayoutSize:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetAccessibilityScreenForLayout (CGSize size)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, selAccessibilityScreenSizeForLayoutSize_XHandle, size);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_CGSize (&__objc_super__, selAccessibilityScreenSizeForLayoutSize_XHandle, size);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityStringForRange:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
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
		[Export ("accessibilityStyleRangeForIndex:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityStyleRange (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (this.Handle, selAccessibilityStyleRangeForIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_IntPtr (&__objc_super__, selAccessibilityStyleRangeForIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("accessibilityAttributeValue:")]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetAccessibilityValue (NSString attribute)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attribute__handle__ = attribute!.GetNonNullHandle (nameof (attribute));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAccessibilityAttributeValue_XHandle, attribute__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccessibilityAttributeValue_XHandle, attribute__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attribute);
			return ret!;
		}
		[Export ("accessibilityAttributeValue:forParameter:")]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetAccessibilityValue (NSString attribute, NSObject parameter)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attribute__handle__ = attribute!.GetNonNullHandle (nameof (attribute));
			var parameter__handle__ = parameter!.GetNonNullHandle (nameof (parameter));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAccessibilityAttributeValue_ForParameter_XHandle, attribute__handle__, parameter__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAccessibilityAttributeValue_ForParameter_XHandle, attribute__handle__, parameter__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attribute);
			GC.KeepAlive (parameter);
			return ret!;
		}
		[Export ("focusRingMaskBoundsForFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFocusRingMaskBounds (CGRect cellFrame, NSView controlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, selFocusRingMaskBoundsForFrame_InView_XHandle, cellFrame, controlView__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, selFocusRingMaskBoundsForFrame_InView_XHandle, cellFrame, controlView__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selFocusRingMaskBoundsForFrame_InView_XHandle, cellFrame, controlView__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, selFocusRingMaskBoundsForFrame_InView_XHandle, cellFrame, controlView__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (controlView);
			return ret!;
		}
		[Export ("getPeriodicDelay:interval:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetPeriodicDelay (ref float delay, ref float interval)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			fixed (float* delay__pointer = &delay) {
			fixed (float* interval__pointer = &interval) {
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_ref_Single_ref_Single (this.Handle, selGetPeriodicDelay_Interval_XHandle, delay__pointer, interval__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_ref_Single_ref_Single (&__objc_super__, selGetPeriodicDelay_Interval_XHandle, delay__pointer, interval__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
		}
		[Export ("highlight:withFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Highlight (bool highlight, CGRect withFrame, NSView inView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView!.GetNonNullHandle (nameof (inView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_CGRect_NativeHandle (this.Handle, selHighlight_WithFrame_InView_XHandle, highlight ? (byte) 1 : (byte) 0, withFrame, inView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_CGRect_NativeHandle (&__objc_super__, selHighlight_WithFrame_InView_XHandle, highlight ? (byte) 1 : (byte) 0, withFrame, inView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
		}
		[Export ("highlightColorWithFrame:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor? HighlightColor (CGRect cellFrame, NSView controlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			NSColor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle (this.Handle, selHighlightColorWithFrame_InView_XHandle, cellFrame, controlView__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selHighlightColorWithFrame_InView_XHandle, cellFrame, controlView__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (controlView);
			return ret!;
		}
		[Export ("hitTestForEvent:inRect:ofView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCellHit HitTest (NSEvent forEvent, CGRect inRect, NSView ofView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var forEvent__handle__ = forEvent!.GetNonNullHandle (nameof (forEvent));
			var ofView__handle__ = ofView!.GetNonNullHandle (nameof (ofView));
			NSCellHit ret;
			if (IsDirectBinding) {
				ret = (NSCellHit) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_CGRect_NativeHandle (this.Handle, selHitTestForEvent_InRect_OfView_XHandle, forEvent__handle__, inRect, ofView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSCellHit) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_CGRect_NativeHandle (&__objc_super__, selHitTestForEvent_InRect_OfView_XHandle, forEvent__handle__, inRect, ofView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forEvent);
			GC.KeepAlive (ofView);
			return ret!;
		}
		[Export ("imageRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ImageRectForBounds (CGRect theRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, selImageRectForBounds_XHandle, theRect);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, selImageRectForBounds_XHandle, theRect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, selImageRectForBounds_XHandle, theRect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, selImageRectForBounds_XHandle, theRect);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("accessibilityIsAttributeSettable:")]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAccessibilityAttributeSettable (NSString attribute)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attribute__handle__ = attribute!.GetNonNullHandle (nameof (attribute));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selAccessibilityIsAttributeSettable_XHandle, attribute__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selAccessibilityIsAttributeSettable_XHandle, attribute__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attribute);
			return ret != 0;
		}
		[Export ("isAccessibilitySelectorAllowed:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAccessibilitySelectorAllowed (Selector selector)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsAccessibilitySelectorAllowed_XHandle, selector.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsAccessibilitySelectorAllowed_XHandle, selector.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selector);
			return ret != 0;
		}
		[Export ("isEntryAcceptable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEntryAcceptable (string aString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEntryAcceptable_XHandle, nsaString);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEntryAcceptable_XHandle, nsaString);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaString);
			return ret != 0;
		}
		[Export ("menuForEvent:inRect:ofView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu MenuForEvent (NSEvent theEvent, CGRect cellFrame, NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			NSMenu? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGRect_NativeHandle (this.Handle, selMenuForEvent_InRect_OfView_XHandle, theEvent__handle__, cellFrame, view__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_CGRect_NativeHandle (&__objc_super__, selMenuForEvent_InRect_OfView_XHandle, theEvent__handle__, cellFrame, view__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("performClick:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformClick (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPerformClick_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformClick_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("refusesFirstResponder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RefusesFirstResponder ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRefusesFirstResponderXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRefusesFirstResponderXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("resetCursorRect:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetCursorRect (CGRect cellFrame, NSView inView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView!.GetNonNullHandle (nameof (inView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, selResetCursorRect_InView_XHandle, cellFrame, inView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selResetCursorRect_InView_XHandle, cellFrame, inView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
		}
		[Export ("selectWithFrame:inView:editor:delegate:start:length:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectWithFrame (CGRect aRect, NSView? inView, NSText? editor, NSObject? delegateObject, nint selStart, nint selLength)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView.GetHandle ();
			var editor__handle__ = editor.GetHandle ();
			var delegateObject__handle__ = delegateObject.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle_NativeHandle_NativeHandle_IntPtr_IntPtr (this.Handle, selSelectWithFrame_InView_Editor_Delegate_Start_Length_XHandle, aRect, inView__handle__, editor__handle__, delegateObject__handle__, selStart, selLength);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle_NativeHandle_NativeHandle_IntPtr_IntPtr (&__objc_super__, selSelectWithFrame_InView_Editor_Delegate_Start_Length_XHandle, aRect, inView__handle__, editor__handle__, delegateObject__handle__, selStart, selLength);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
			GC.KeepAlive (editor);
			GC.KeepAlive (delegateObject);
		}
		[Export ("sendActionOn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SendActionOn (NSEventType mask)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr (this.Handle, selSendActionOn_XHandle, (UIntPtr) (ulong) mask);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selSendActionOn_XHandle, (UIntPtr) (ulong) mask);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sendsActionOnEndEditing")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SendsActionOnEndEditing ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSendsActionOnEndEditingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSendsActionOnEndEditingXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("accessibilitySetValue:forAttribute:")]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAccessibilityValue (NSString attribute, NSObject value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attribute__handle__ = attribute!.GetNonNullHandle (nameof (attribute));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAccessibilitySetValue_ForAttribute_XHandle, attribute__handle__, value__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAccessibilitySetValue_ForAttribute_XHandle, attribute__handle__, value__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attribute);
			GC.KeepAlive (value);
		}
		[Export ("setCellAttribute:to:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCellAttribute (NSCellAttribute aParameter, nint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_IntPtr (this.Handle, selSetCellAttribute_To_XHandle, (UIntPtr) (ulong) aParameter, value);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, selSetCellAttribute_To_XHandle, (UIntPtr) (ulong) aParameter, value);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNextState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNextState ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetNextStateXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetNextStateXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="flag">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setSendsActionOnEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSendsActionOnEndEditing (bool flag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSendsActionOnEndEditing_XHandle, flag ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSendsActionOnEndEditing_XHandle, flag ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setTitleWithMnemonic:")]
		[ObsoletedOSPlatform ("macos10.8", "Mnemonic methods have typically not been used.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTitleWithMnemonic (string stringWithAmpersand)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (stringWithAmpersand is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringWithAmpersand));
			var nsstringWithAmpersand = CFString.CreateNative (stringWithAmpersand);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitleWithMnemonic_XHandle, nsstringWithAmpersand);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitleWithMnemonic_XHandle, nsstringWithAmpersand);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstringWithAmpersand);
		}
		[Export ("setUpFieldEditorAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSText SetUpFieldEditorAttributes (NSText textObj)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textObj__handle__ = textObj!.GetNonNullHandle (nameof (textObj));
			NSText? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSText> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSetUpFieldEditorAttributes_XHandle, textObj__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSText> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUpFieldEditorAttributes_XHandle, textObj__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textObj);
			return ret!;
		}
		[Export ("startTrackingAt:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StartTracking (CGPoint startPoint, NSView inView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView!.GetNonNullHandle (nameof (inView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint_NativeHandle (this.Handle, selStartTrackingAt_InView_XHandle, startPoint, inView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selStartTrackingAt_InView_XHandle, startPoint, inView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
			return ret != 0;
		}
		[Export ("stopTracking:at:inView:mouseIsUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopTracking (CGPoint lastPoint, CGPoint stopPoint, NSView inView, bool mouseIsUp)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var inView__handle__ = inView!.GetNonNullHandle (nameof (inView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint_NativeHandle_bool (this.Handle, selStopTracking_At_InView_MouseIsUp_XHandle, lastPoint, stopPoint, inView__handle__, mouseIsUp ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_NativeHandle_bool (&__objc_super__, selStopTracking_At_InView_MouseIsUp_XHandle, lastPoint, stopPoint, inView__handle__, mouseIsUp ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (inView);
		}
		[Export ("takeDoubleValueFrom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TakeDoubleValueFrom (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTakeDoubleValueFrom_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTakeDoubleValueFrom_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("takeFloatValueFrom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TakeFloatValueFrom (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTakeFloatValueFrom_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTakeFloatValueFrom_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("takeIntValueFrom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TakeIntValueFrom (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTakeIntValueFrom_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTakeIntValueFrom_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("takeIntegerValueFrom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TakeIntegerValueFrom (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTakeIntegerValueFrom_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTakeIntegerValueFrom_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("takeObjectValueFrom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TakeObjectValueFrom (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTakeObjectValueFrom_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTakeObjectValueFrom_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("takeStringValueFrom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TakeStringValueFrom (NSObject sender)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTakeStringValueFrom_XHandle, sender__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTakeStringValueFrom_XHandle, sender__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
		}
		[Export ("titleRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect TitleRectForBounds (CGRect theRect)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, selTitleRectForBounds_XHandle, theRect);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, selTitleRectForBounds_XHandle, theRect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, selTitleRectForBounds_XHandle, theRect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, selTitleRectForBounds_XHandle, theRect);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("trackMouse:inRect:ofView:untilMouseUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TrackMouse (NSEvent theEvent, CGRect cellFrame, NSView controlView, bool untilMouseUp)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CGRect_NativeHandle_bool (this.Handle, selTrackMouse_InRect_OfView_UntilMouseUp_XHandle, theEvent__handle__, cellFrame, controlView__handle__, untilMouseUp ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_CGRect_NativeHandle_bool (&__objc_super__, selTrackMouse_InRect_OfView_UntilMouseUp_XHandle, theEvent__handle__, cellFrame, controlView__handle__, untilMouseUp ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
			GC.KeepAlive (controlView);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSArray AccessibilityActionNames {
			[Export ("accessibilityActionNames")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos12.0", "Use the NSAccessibility protocol methods instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityActionNamesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityActionNamesXHandle), false)!;
						GC.KeepAlive (this);
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
		public virtual CGPoint AccessibilityActivationPoint {
			[Export ("accessibilityActivationPoint", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selAccessibilityActivationPointXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selAccessibilityActivationPointXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityActivationPoint:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetAccessibilityActivationPoint_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetAccessibilityActivationPoint_XHandle, value);
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
		public virtual NSNumber[]? AccessibilityAllowedValues {
			[Export ("accessibilityAllowedValues", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityAllowedValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityAllowedValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityAllowedValues:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityAllowedValues_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityAllowedValues_XHandle, nsa_value.GetHandle ());
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
		public virtual bool AccessibilityAlternateUIVisible {
			[Export ("isAccessibilityAlternateUIVisible")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityAlternateUIVisibleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityAlternateUIVisibleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityAlternateUIVisible:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityAlternateUIVisible_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityAlternateUIVisible_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSObject? AccessibilityApplicationFocusedUIElement {
			[Export ("accessibilityApplicationFocusedUIElement", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityApplicationFocusedUIElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityApplicationFocusedUIElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityApplicationFocusedUIElement:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityApplicationFocusedUIElement_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityApplicationFocusedUIElement_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSArray AccessibilityAttributeNames {
			[Export ("accessibilityAttributeNames")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos12.0", "Use the NSAccessibility protocol methods instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityAttributeNamesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityAttributeNamesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual NSAttributedString[] AccessibilityAttributedUserInputLabels {
			[Export ("accessibilityAttributedUserInputLabels", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAttributedString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityAttributedUserInputLabelsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityAttributedUserInputLabelsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityAttributedUserInputLabels:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos14.0")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityAttributedUserInputLabels_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityAttributedUserInputLabels_XHandle, nsa_value.Handle);
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
		public virtual NSObject? AccessibilityCancelButton {
			[Export ("accessibilityCancelButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityCancelButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityCancelButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityCancelButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityCancelButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityCancelButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[]? AccessibilityChildren {
			[Export ("accessibilityChildren", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityChildrenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityChildrenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityChildren:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityChildren_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityChildren_XHandle, nsa_value.GetHandle ());
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
		public virtual NSAccessibilityElement[]? AccessibilityChildrenInNavigationOrder {
			[Export ("accessibilityChildrenInNavigationOrder", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityElement[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSAccessibilityElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityChildrenInNavigationOrderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSAccessibilityElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityChildrenInNavigationOrderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityChildrenInNavigationOrder:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityChildrenInNavigationOrder_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityChildrenInNavigationOrder_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject? AccessibilityClearButton {
			[Export ("accessibilityClearButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityClearButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityClearButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityClearButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityClearButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityClearButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityCloseButton {
			[Export ("accessibilityCloseButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityCloseButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityCloseButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityCloseButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityCloseButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityCloseButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual nint AccessibilityColumnCount {
			[Export ("accessibilityColumnCount")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityColumnCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityColumnCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityColumnCount:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityColumnCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityColumnCount_XHandle, value);
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
		public virtual NSObject[]? AccessibilityColumnHeaderUIElements {
			[Export ("accessibilityColumnHeaderUIElements", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityColumnHeaderUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityColumnHeaderUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityColumnHeaderUIElements:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityColumnHeaderUIElements_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityColumnHeaderUIElements_XHandle, nsa_value.GetHandle ());
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
		public virtual NSRange AccessibilityColumnIndexRange {
			[Export ("accessibilityColumnIndexRange", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selAccessibilityColumnIndexRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selAccessibilityColumnIndexRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityColumnIndexRange:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetAccessibilityColumnIndexRange_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selSetAccessibilityColumnIndexRange_XHandle, value);
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
		public virtual NSObject[]? AccessibilityColumnTitles {
			[Export ("accessibilityColumnTitles", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityColumnTitlesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityColumnTitlesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityColumnTitles:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityColumnTitles_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityColumnTitles_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject[]? AccessibilityColumns {
			[Export ("accessibilityColumns", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityColumnsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityColumnsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityColumns:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityColumns_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityColumns_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject[]? AccessibilityContents {
			[Export ("accessibilityContents", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityContentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityContentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityContents:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityContents_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityContents_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject? AccessibilityCriticalValue {
			[Export ("accessibilityCriticalValue", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityCriticalValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityCriticalValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityCriticalValue:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityCriticalValue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityCriticalValue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSAccessibilityCustomAction[]? AccessibilityCustomActions {
			[Export ("accessibilityCustomActions", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityCustomAction[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSAccessibilityCustomAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityCustomActionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSAccessibilityCustomAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityCustomActionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityCustomActions:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityCustomActions_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityCustomActions_XHandle, nsa_value.GetHandle ());
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
		public virtual NSAccessibilityCustomRotor[] AccessibilityCustomRotors {
			[Export ("accessibilityCustomRotors", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityCustomRotor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSAccessibilityCustomRotor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityCustomRotorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSAccessibilityCustomRotor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityCustomRotorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityCustomRotors:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityCustomRotors_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityCustomRotors_XHandle, nsa_value.Handle);
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
		public virtual NSObject? AccessibilityDecrementButton {
			[Export ("accessibilityDecrementButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityDecrementButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityDecrementButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityDecrementButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityDecrementButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityDecrementButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityDefaultButton {
			[Export ("accessibilityDefaultButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityDefaultButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityDefaultButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityDefaultButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityDefaultButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityDefaultButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityDisclosed {
			[Export ("isAccessibilityDisclosed")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityDisclosedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityDisclosedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityDisclosed:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityDisclosed_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityDisclosed_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AccessibilityDisclosedByRow_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityDisclosedByRow {
			[Export ("accessibilityDisclosedByRow", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityDisclosedByRowXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityDisclosedByRowXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_AccessibilityDisclosedByRow_var = ret;
				return ret!;
			}
			[Export ("setAccessibilityDisclosedByRow:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityDisclosedByRow_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityDisclosedByRow_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_AccessibilityDisclosedByRow_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityDisclosedRows {
			[Export ("accessibilityDisclosedRows", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityDisclosedRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityDisclosedRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityDisclosedRows:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityDisclosedRows_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityDisclosedRows_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual nint AccessibilityDisclosureLevel {
			[Export ("accessibilityDisclosureLevel")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityDisclosureLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityDisclosureLevelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityDisclosureLevel:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityDisclosureLevel_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityDisclosureLevel_XHandle, value);
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
		public virtual string? AccessibilityDocument {
			[Export ("accessibilityDocument")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityDocumentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityDocumentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityDocument:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityDocument_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityDocument_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityEdited {
			[Export ("isAccessibilityEdited")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityEditedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityEditedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityEdited:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityEdited_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityEdited_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityElement {
			[Export ("isAccessibilityElement")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityElementXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityElementXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityElement:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityElement_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityElement_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityEnabled {
			[Export ("isAccessibilityEnabled")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityEnabled:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityExpanded {
			[Export ("isAccessibilityExpanded")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityExpandedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityExpandedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityExpanded:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityExpanded_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityExpanded_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AccessibilityExtrasMenuBar_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityExtrasMenuBar {
			[Export ("accessibilityExtrasMenuBar", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityExtrasMenuBarXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityExtrasMenuBarXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_AccessibilityExtrasMenuBar_var = ret;
				return ret!;
			}
			[Export ("setAccessibilityExtrasMenuBar:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityExtrasMenuBar_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityExtrasMenuBar_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_AccessibilityExtrasMenuBar_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityFilename {
			[Export ("accessibilityFilename")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityFilenameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityFilenameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityFilename:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityFilename_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityFilename_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
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
			[Export ("setAccessibilityFocused:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityFocused_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityFocused_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSObject? AccessibilityFocusedWindow {
			[Export ("accessibilityFocusedWindow", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityFocusedWindowXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityFocusedWindowXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityFocusedWindow:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityFocusedWindow_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityFocusedWindow_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual CGRect AccessibilityFrame {
			[Export ("accessibilityFrame", ArgumentSemantic.Assign)]
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
			[Export ("setAccessibilityFrame:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetAccessibilityFrame_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetAccessibilityFrame_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityFrontmost {
			[Export ("isAccessibilityFrontmost")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityFrontmostXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityFrontmostXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityFrontmost:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityFrontmost_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityFrontmost_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSObject? AccessibilityFullScreenButton {
			[Export ("accessibilityFullScreenButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityFullScreenButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityFullScreenButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityFullScreenButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityFullScreenButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityFullScreenButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityGrowArea {
			[Export ("accessibilityGrowArea", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityGrowAreaXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityGrowAreaXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityGrowArea:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityGrowArea_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityGrowArea_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[]? AccessibilityHandles {
			[Export ("accessibilityHandles", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityHandlesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityHandlesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityHandles:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityHandles_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityHandles_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject? AccessibilityHeader {
			[Export ("accessibilityHeader", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityHeaderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityHeaderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityHeader:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityHeader_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityHeader_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityHelp {
			[Export ("accessibilityHelp")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityHelpXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityHelpXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityHelp:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityHelp_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityHelp_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityHidden {
			[Export ("isAccessibilityHidden")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityHiddenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityHiddenXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityHidden:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityHidden_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityHidden_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSObject? AccessibilityHorizontalScrollBar {
			[Export ("accessibilityHorizontalScrollBar", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityHorizontalScrollBarXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityHorizontalScrollBarXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityHorizontalScrollBar:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityHorizontalScrollBar_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityHorizontalScrollBar_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityHorizontalUnitDescription {
			[Export ("accessibilityHorizontalUnitDescription")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityHorizontalUnitDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityHorizontalUnitDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityHorizontalUnitDescription:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityHorizontalUnitDescription_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityHorizontalUnitDescription_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSAccessibilityUnits AccessibilityHorizontalUnits {
			[Export ("accessibilityHorizontalUnits", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityUnits ret;
				if (IsDirectBinding) {
					ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityHorizontalUnitsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityHorizontalUnitsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityHorizontalUnits:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityHorizontalUnits_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityHorizontalUnits_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		#pragma warning disable CS8766
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityIdentifier {
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
			[Export ("setAccessibilityIdentifier:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		#pragma warning restore CS8766
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityIncrementButton {
			[Export ("accessibilityIncrementButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityIncrementButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityIncrementButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityIncrementButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityIncrementButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityIncrementButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual nint AccessibilityIndex {
			[Export ("accessibilityIndex")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityIndexXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityIndexXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityIndex:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityIndex_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityIndex_XHandle, value);
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
		public virtual nint AccessibilityInsertionPointLineNumber {
			[Export ("accessibilityInsertionPointLineNumber")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityInsertionPointLineNumberXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityInsertionPointLineNumberXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityInsertionPointLineNumber:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityInsertionPointLineNumber_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityInsertionPointLineNumber_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityIsIgnored {
			[Export ("accessibilityIsIgnored")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos12.0", "Use the NSAccessibility protocol methods instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityIsIgnoredXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityIsIgnoredXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityLabel {
			[Export ("accessibilityLabel")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityLabel:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityLabel_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityLabel_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[]? AccessibilityLabelUIElements {
			[Export ("accessibilityLabelUIElements", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityLabelUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityLabelUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityLabelUIElements:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityLabelUIElements_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityLabelUIElements_XHandle, nsa_value.GetHandle ());
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
		public virtual float AccessibilityLabelValue {
			[Export ("accessibilityLabelValue")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAccessibilityLabelValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selAccessibilityLabelValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityLabelValue:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAccessibilityLabelValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetAccessibilityLabelValue_XHandle, value);
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
		public virtual NSObject[]? AccessibilityLinkedUIElements {
			[Export ("accessibilityLinkedUIElements", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityLinkedUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityLinkedUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityLinkedUIElements:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityLinkedUIElements_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityLinkedUIElements_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityMain {
			[Export ("isAccessibilityMain")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityMainXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityMainXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityMain:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityMain_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityMain_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSObject? AccessibilityMainWindow {
			[Export ("accessibilityMainWindow", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityMainWindowXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityMainWindowXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityMainWindow:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityMainWindow_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityMainWindow_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityMarkerGroupUIElement {
			[Export ("accessibilityMarkerGroupUIElement", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityMarkerGroupUIElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityMarkerGroupUIElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityMarkerGroupUIElement:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityMarkerGroupUIElement_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityMarkerGroupUIElement_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityMarkerTypeDescription {
			[Export ("accessibilityMarkerTypeDescription")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityMarkerTypeDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityMarkerTypeDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityMarkerTypeDescription:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityMarkerTypeDescription_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityMarkerTypeDescription_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[]? AccessibilityMarkerUIElements {
			[Export ("accessibilityMarkerUIElements", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityMarkerUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityMarkerUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityMarkerUIElements:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityMarkerUIElements_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityMarkerUIElements_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject? AccessibilityMarkerValues {
			[Export ("accessibilityMarkerValues", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityMarkerValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityMarkerValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityMarkerValues:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityMarkerValues_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityMarkerValues_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityMaxValue {
			[Export ("accessibilityMaxValue", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityMaxValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityMaxValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityMaxValue:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityMaxValue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityMaxValue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AccessibilityMenuBar_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityMenuBar {
			[Export ("accessibilityMenuBar", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityMenuBarXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityMenuBarXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_AccessibilityMenuBar_var = ret;
				return ret!;
			}
			[Export ("setAccessibilityMenuBar:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityMenuBar_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityMenuBar_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_AccessibilityMenuBar_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityMinValue {
			[Export ("accessibilityMinValue", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityMinValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityMinValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityMinValue:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityMinValue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityMinValue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityMinimizeButton {
			[Export ("accessibilityMinimizeButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityMinimizeButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityMinimizeButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityMinimizeButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityMinimizeButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityMinimizeButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityMinimized {
			[Export ("isAccessibilityMinimized")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityMinimizedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityMinimizedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityMinimized:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityMinimized_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityMinimized_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityModal {
			[Export ("isAccessibilityModal")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityModalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityModalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityModal:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityModal_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityModal_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSObject[]? AccessibilityNextContents {
			[Export ("accessibilityNextContents", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityNextContentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityNextContentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityNextContents:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityNextContents_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityNextContents_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityNotifiesWhenDestroyed {
			[Export ("accessibilityNotifiesWhenDestroyed")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAccessibilityNotifiesWhenDestroyedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAccessibilityNotifiesWhenDestroyedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual nint AccessibilityNumberOfCharacters {
			[Export ("accessibilityNumberOfCharacters")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityNumberOfCharactersXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityNumberOfCharactersXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityNumberOfCharacters:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityNumberOfCharacters_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityNumberOfCharacters_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityOrderedByRow {
			[Export ("isAccessibilityOrderedByRow")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityOrderedByRowXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityOrderedByRowXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityOrderedByRow:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityOrderedByRow_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityOrderedByRow_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSAccessibilityOrientation AccessibilityOrientation {
			[Export ("accessibilityOrientation", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityOrientation ret;
				if (IsDirectBinding) {
					ret = (NSAccessibilityOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityOrientationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSAccessibilityOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityOrientationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityOrientation:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityOrientation_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityOrientation_XHandle, (IntPtr) (long) value);
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
		public virtual NSObject? AccessibilityOverflowButton {
			[Export ("accessibilityOverflowButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityOverflowButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityOverflowButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityOverflowButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityOverflowButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityOverflowButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.10", "Use the NSAccessibility protocol methods instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSArray AccessibilityParameterizedAttributeNames {
			[Export ("accessibilityParameterizedAttributeNames")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("macos12.0", "Use the NSAccessibility protocol methods instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityParameterizedAttributeNamesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityParameterizedAttributeNamesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AccessibilityParent_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityParent {
			[Export ("accessibilityParent", ArgumentSemantic.Weak)]
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
				MarkDirty ();
				__mt_AccessibilityParent_var = ret;
				return ret!;
			}
			[Export ("setAccessibilityParent:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityParent_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityParent_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_AccessibilityParent_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityPlaceholderValue {
			[Export ("accessibilityPlaceholderValue")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityPlaceholderValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityPlaceholderValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityPlaceholderValue:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityPlaceholderValue_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityPlaceholderValue_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[]? AccessibilityPreviousContents {
			[Export ("accessibilityPreviousContents", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityPreviousContentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityPreviousContentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityPreviousContents:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityPreviousContents_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityPreviousContents_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityProtectedContent {
			[Export ("isAccessibilityProtectedContent")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityProtectedContentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityProtectedContentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityProtectedContent:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityProtectedContent_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityProtectedContent_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSObject? AccessibilityProxy {
			[Export ("accessibilityProxy", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityProxyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityProxyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityProxy:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityProxy_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityProxy_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilityRequired {
			[Export ("isAccessibilityRequired")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilityRequiredXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilityRequiredXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityRequired:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilityRequired_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilityRequired_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual string? AccessibilityRole {
			[Export ("accessibilityRole")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityRoleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityRoleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityRole:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityRole_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityRole_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityRoleDescription {
			[Export ("accessibilityRoleDescription")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityRoleDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityRoleDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityRoleDescription:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityRoleDescription_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityRoleDescription_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual nint AccessibilityRowCount {
			[Export ("accessibilityRowCount")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityRowCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityRowCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityRowCount:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityRowCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityRowCount_XHandle, value);
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
		public virtual NSObject[]? AccessibilityRowHeaderUIElements {
			[Export ("accessibilityRowHeaderUIElements", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityRowHeaderUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityRowHeaderUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityRowHeaderUIElements:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityRowHeaderUIElements_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityRowHeaderUIElements_XHandle, nsa_value.GetHandle ());
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
		public virtual NSRange AccessibilityRowIndexRange {
			[Export ("accessibilityRowIndexRange", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selAccessibilityRowIndexRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selAccessibilityRowIndexRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityRowIndexRange:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetAccessibilityRowIndexRange_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selSetAccessibilityRowIndexRange_XHandle, value);
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
		public virtual NSObject[]? AccessibilityRows {
			[Export ("accessibilityRows", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityRows:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityRows_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityRows_XHandle, nsa_value.GetHandle ());
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
		public virtual NSAccessibilityRulerMarkerType AccessibilityRulerMarkerType {
			[Export ("accessibilityRulerMarkerType", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityRulerMarkerType ret;
				if (IsDirectBinding) {
					ret = (NSAccessibilityRulerMarkerType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityRulerMarkerTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSAccessibilityRulerMarkerType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityRulerMarkerTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityRulerMarkerType:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityRulerMarkerType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityRulerMarkerType_XHandle, (IntPtr) (long) value);
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
		public virtual NSObject? AccessibilitySearchButton {
			[Export ("accessibilitySearchButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySearchButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySearchButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySearchButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySearchButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySearchButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilitySearchMenu {
			[Export ("accessibilitySearchMenu", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySearchMenuXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySearchMenuXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySearchMenu:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySearchMenu_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySearchMenu_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool AccessibilitySelected {
			[Export ("isAccessibilitySelected")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAccessibilitySelectedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAccessibilitySelectedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilitySelected:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAccessibilitySelected_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAccessibilitySelected_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSObject[]? AccessibilitySelectedCells {
			[Export ("accessibilitySelectedCells", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedCellsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedCellsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySelectedCells:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySelectedCells_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySelectedCells_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject[]? AccessibilitySelectedChildren {
			[Export ("accessibilitySelectedChildren", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedChildrenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedChildrenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySelectedChildren:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySelectedChildren_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySelectedChildren_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject[]? AccessibilitySelectedColumns {
			[Export ("accessibilitySelectedColumns", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedColumnsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedColumnsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySelectedColumns:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySelectedColumns_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySelectedColumns_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject[]? AccessibilitySelectedRows {
			[Export ("accessibilitySelectedRows", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySelectedRows:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySelectedRows_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySelectedRows_XHandle, nsa_value.GetHandle ());
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
		public virtual string? AccessibilitySelectedText {
			[Export ("accessibilitySelectedText")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedTextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedTextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilitySelectedText:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySelectedText_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySelectedText_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSRange AccessibilitySelectedTextRange {
			[Export ("accessibilitySelectedTextRange", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selAccessibilitySelectedTextRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedTextRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilitySelectedTextRange:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetAccessibilitySelectedTextRange_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selSetAccessibilitySelectedTextRange_XHandle, value);
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
		public virtual NSValue[]? AccessibilitySelectedTextRanges {
			[Export ("accessibilitySelectedTextRanges", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSValue[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySelectedTextRangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySelectedTextRangesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySelectedTextRanges:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySelectedTextRanges_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySelectedTextRanges_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject[]? AccessibilityServesAsTitleForUIElements {
			[Export ("accessibilityServesAsTitleForUIElements", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityServesAsTitleForUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityServesAsTitleForUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityServesAsTitleForUIElements:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityServesAsTitleForUIElements_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityServesAsTitleForUIElements_XHandle, nsa_value.GetHandle ());
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
		public virtual NSRange AccessibilitySharedCharacterRange {
			[Export ("accessibilitySharedCharacterRange", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selAccessibilitySharedCharacterRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selAccessibilitySharedCharacterRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilitySharedCharacterRange:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetAccessibilitySharedCharacterRange_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selSetAccessibilitySharedCharacterRange_XHandle, value);
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
		public virtual NSObject[]? AccessibilitySharedFocusElements {
			[Export ("accessibilitySharedFocusElements", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySharedFocusElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySharedFocusElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySharedFocusElements:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySharedFocusElements_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySharedFocusElements_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject[]? AccessibilitySharedTextUIElements {
			[Export ("accessibilitySharedTextUIElements", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySharedTextUIElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySharedTextUIElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySharedTextUIElements:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySharedTextUIElements_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySharedTextUIElements_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject? AccessibilityShownMenu {
			[Export ("accessibilityShownMenu", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityShownMenuXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityShownMenuXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityShownMenu:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityShownMenu_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityShownMenu_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSAccessibilitySortDirection AccessibilitySortDirection {
			[Export ("accessibilitySortDirection", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilitySortDirection ret;
				if (IsDirectBinding) {
					ret = (NSAccessibilitySortDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilitySortDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSAccessibilitySortDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilitySortDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySortDirection:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilitySortDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilitySortDirection_XHandle, (IntPtr) (long) value);
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
		public virtual NSObject[]? AccessibilitySplitters {
			[Export ("accessibilitySplitters", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySplittersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySplittersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilitySplitters:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySplitters_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySplitters_XHandle, nsa_value.GetHandle ());
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
		public virtual string? AccessibilitySubrole {
			[Export ("accessibilitySubrole")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilitySubroleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilitySubroleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilitySubrole:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilitySubrole_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilitySubrole_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[]? AccessibilityTabs {
			[Export ("accessibilityTabs", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityTabsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityTabsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityTabs:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityTabs_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityTabs_XHandle, nsa_value.GetHandle ());
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
		public virtual string? AccessibilityTitle {
			[Export ("accessibilityTitle")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityTitle:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AccessibilityTitleUIElement_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityTitleUIElement {
			[Export ("accessibilityTitleUIElement", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityTitleUIElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityTitleUIElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_AccessibilityTitleUIElement_var = ret;
				return ret!;
			}
			[Export ("setAccessibilityTitleUIElement:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityTitleUIElement_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityTitleUIElement_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_AccessibilityTitleUIElement_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityToolbarButton {
			[Export ("accessibilityToolbarButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityToolbarButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityToolbarButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityToolbarButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityToolbarButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityToolbarButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AccessibilityTopLevelUIElement_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityTopLevelUIElement {
			[Export ("accessibilityTopLevelUIElement", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityTopLevelUIElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityTopLevelUIElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_AccessibilityTopLevelUIElement_var = ret;
				return ret!;
			}
			[Export ("setAccessibilityTopLevelUIElement:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityTopLevelUIElement_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityTopLevelUIElement_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_AccessibilityTopLevelUIElement_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityUnitDescription {
			[Export ("accessibilityUnitDescription")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityUnitDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityUnitDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityUnitDescription:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityUnitDescription_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityUnitDescription_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSAccessibilityUnits AccessibilityUnits {
			[Export ("accessibilityUnits", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityUnits ret;
				if (IsDirectBinding) {
					ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityUnitsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityUnitsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityUnits:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityUnits_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityUnits_XHandle, (IntPtr) (long) value);
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
		public virtual NSUrl? AccessibilityUrl {
			[Export ("accessibilityURL", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityURL:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityURL_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityURL_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual string[] AccessibilityUserInputLabels {
			[Export ("accessibilityUserInputLabels", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityUserInputLabelsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityUserInputLabelsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityUserInputLabels:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos14.0")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityUserInputLabels_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityUserInputLabels_XHandle, nsa_value.Handle);
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
		public virtual NSObject? AccessibilityValue {
			[Export ("accessibilityValue", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityValue:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityValue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityValue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityValueDescription {
			[Export ("accessibilityValueDescription")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityValueDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityValueDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityValueDescription:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityValueDescription_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityValueDescription_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityVerticalScrollBar {
			[Export ("accessibilityVerticalScrollBar", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVerticalScrollBarXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVerticalScrollBarXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityVerticalScrollBar:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityVerticalScrollBar_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityVerticalScrollBar_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual string? AccessibilityVerticalUnitDescription {
			[Export ("accessibilityVerticalUnitDescription")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVerticalUnitDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVerticalUnitDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityVerticalUnitDescription:")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityVerticalUnitDescription_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityVerticalUnitDescription_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSAccessibilityUnits AccessibilityVerticalUnits {
			[Export ("accessibilityVerticalUnits", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityUnits ret;
				if (IsDirectBinding) {
					ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessibilityVerticalUnitsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAccessibilityVerticalUnitsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityVerticalUnits:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessibilityVerticalUnits_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAccessibilityVerticalUnits_XHandle, (IntPtr) (long) value);
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
		public virtual NSObject[]? AccessibilityVisibleCells {
			[Export ("accessibilityVisibleCells", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleCellsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleCellsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityVisibleCells:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityVisibleCells_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityVisibleCells_XHandle, nsa_value.GetHandle ());
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
		public virtual NSRange AccessibilityVisibleCharacterRange {
			[Export ("accessibilityVisibleCharacterRange", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
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
			[Export ("setAccessibilityVisibleCharacterRange:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetAccessibilityVisibleCharacterRange_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selSetAccessibilityVisibleCharacterRange_XHandle, value);
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
		public virtual NSObject[]? AccessibilityVisibleChildren {
			[Export ("accessibilityVisibleChildren", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleChildrenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleChildrenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityVisibleChildren:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityVisibleChildren_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityVisibleChildren_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject[]? AccessibilityVisibleColumns {
			[Export ("accessibilityVisibleColumns", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleColumnsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleColumnsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityVisibleColumns:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityVisibleColumns_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityVisibleColumns_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject[]? AccessibilityVisibleRows {
			[Export ("accessibilityVisibleRows", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityVisibleRowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityVisibleRowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityVisibleRows:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityVisibleRows_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityVisibleRows_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject? AccessibilityWarningValue {
			[Export ("accessibilityWarningValue", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityWarningValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityWarningValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityWarningValue:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityWarningValue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityWarningValue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_AccessibilityWindow_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? AccessibilityWindow {
			[Export ("accessibilityWindow", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityWindowXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityWindowXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_AccessibilityWindow_var = ret;
				return ret!;
			}
			[Export ("setAccessibilityWindow:", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityWindow_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityWindow_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_AccessibilityWindow_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject[]? AccessibilityWindows {
			[Export ("accessibilityWindows", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityWindowsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityWindowsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityWindows:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityWindows_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityWindows_XHandle, nsa_value.GetHandle ());
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
		public virtual NSObject? AccessibilityZoomButton {
			[Export ("accessibilityZoomButton", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityZoomButtonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityZoomButtonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityZoomButton:", ArgumentSemantic.Retain)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityZoomButton_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityZoomButton_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Selector? Action {
			[Export ("action")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				Selector ret;
				if (IsDirectBinding) {
					ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Selector.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAction:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAction_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAction_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextAlignment Alignment {
			[Export ("alignment")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextAlignment ret;
				if (IsDirectBinding) {
					ret = NSTextAlignmentExtensions.ToManaged ((nuint) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAlignmentXHandle));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSTextAlignmentExtensions.ToManaged ((nuint) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAlignmentXHandle));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAlignment:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetAlignment_XHandle, (UIntPtr) NSTextAlignmentExtensions.ToNative (value));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetAlignment_XHandle, (UIntPtr) NSTextAlignmentExtensions.ToNative (value));
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsEditingTextAttributes {
			[Export ("allowsEditingTextAttributes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsEditingTextAttributesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsEditingTextAttributesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsEditingTextAttributes:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsEditingTextAttributes_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsEditingTextAttributes_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsMixedState {
			[Export ("allowsMixedState")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsMixedStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsMixedStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsMixedState:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsMixedState_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsMixedState_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSAttributedString AttributedStringValue {
			[Export ("attributedStringValue")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributedStringValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributedStringValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributedStringValue:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAttributedStringValue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttributedStringValue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSBackgroundStyle BackgroundStyle {
			[Export ("backgroundStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSBackgroundStyle ret;
				if (IsDirectBinding) {
					ret = (NSBackgroundStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSBackgroundStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBackgroundStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBackgroundStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWritingDirection BaseWritingDirection {
			[Export ("baseWritingDirection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSWritingDirection ret;
				if (IsDirectBinding) {
					ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBaseWritingDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSWritingDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBaseWritingDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBaseWritingDirection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBaseWritingDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBaseWritingDirection_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Bezeled {
			[Export ("isBezeled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBezeledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBezeledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBezeled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBezeled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetBezeled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Bordered {
			[Export ("isBordered")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsBorderedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsBorderedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setBordered:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBordered_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetBordered_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize CellSize {
			[Export ("cellSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selCellSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selCellSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCellType CellType {
			[Export ("type")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCellType ret;
				if (IsDirectBinding) {
					ret = (NSCellType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSCellType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setType:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetType_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetType_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSControlSize ControlSize {
			[Export ("controlSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSControlSize ret;
				if (IsDirectBinding) {
					ret = (NSControlSize) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selControlSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSControlSize) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selControlSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setControlSize:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetControlSize_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetControlSize_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "'ControlTint' property not honored on 10.14. For custom cells, use 'NSColor.ControlAccentColor'.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSControlTint ControlTint {
			[Export ("controlTint")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSControlTint ret;
				if (IsDirectBinding) {
					ret = (NSControlTint) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selControlTintXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSControlTint) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selControlTintXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setControlTint:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetControlTint_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetControlTint_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView ControlView {
			[Export ("controlView")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selControlViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selControlViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setControlView:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetControlView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetControlView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFocusRingType DefaultFocusRingType {
			[Export ("defaultFocusRingType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSFocusRingType ret;
				ret = (NSFocusRingType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selDefaultFocusRingTypeXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMenu? DefaultMenu {
			[Export ("defaultMenu")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSMenu? ret;
				ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultMenuXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DoubleValue {
			[Export ("doubleValue")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDoubleValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDoubleValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDoubleValue:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDoubleValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetDoubleValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FloatValue {
			[Export ("floatValue")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFloatValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFloatValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFloatValue:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFloatValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFloatValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFocusRingType FocusRingType {
			[Export ("focusRingType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSFocusRingType ret;
				if (IsDirectBinding) {
					ret = (NSFocusRingType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFocusRingTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSFocusRingType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFocusRingTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFocusRingType:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetFocusRingType_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetFocusRingType_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont Font {
			[Export ("font", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSFont? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFontXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFontXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFont:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFont_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFont_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFormatter? Formatter {
			[Export ("formatter", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSFormatter? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSFormatter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFormatterXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSFormatter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFormatterXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFormatter:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFormatter_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFormatter_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasValidObjectValue {
			[Export ("hasValidObjectValue")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasValidObjectValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasValidObjectValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Highlighted {
			[Export ("isHighlighted")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHighlightedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHighlightedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHighlighted:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHighlighted_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHighlighted_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIdentifier:", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage Image {
			[Export ("image", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setImage:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetImage_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetImage_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
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
		public virtual int IntValue {
			[Export ("intValue")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selIntValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selIntValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIntValue:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetIntValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetIntValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IntegerValue {
			[Export ("integerValue")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIntegerValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selIntegerValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIntegerValue:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIntegerValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetIntegerValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSBackgroundStyle InteriorBackgroundStyle {
			[Export ("interiorBackgroundStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSBackgroundStyle ret;
				if (IsDirectBinding) {
					ret = (NSBackgroundStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInteriorBackgroundStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSBackgroundStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selInteriorBackgroundStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsContinuous {
			[Export ("isContinuous")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsContinuousXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsContinuousXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setContinuous:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetContinuous_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetContinuous_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsOpaque {
			[Export ("isOpaque")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOpaqueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsOpaqueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string KeyEquivalent {
			[Export ("keyEquivalent")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeyEquivalentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeyEquivalentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLineBreakMode LineBreakMode {
			[Export ("lineBreakMode")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSLineBreakMode ret;
				if (IsDirectBinding) {
					ret = (NSLineBreakMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selLineBreakModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSLineBreakMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selLineBreakModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLineBreakMode:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetLineBreakMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetLineBreakMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu? Menu {
			[Export ("menu", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSMenu? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMenuXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMenuXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMenu:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMenu_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMenu_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.8", "Mnemonic methods have typically not been used.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string Mnemonic {
			[Export ("mnemonic")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMnemonicXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMnemonicXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.8", "Mnemonic methods have typically not been used.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual nint MnemonicLocation {
			[Export ("mnemonicLocation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMnemonicLocationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMnemonicLocationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMnemonicLocation:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMnemonicLocation_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMnemonicLocation_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MouseDownFlags {
			[Export ("mouseDownFlags")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMouseDownFlagsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMouseDownFlagsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NextState {
			[Export ("nextState")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNextStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNextStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ObjectValue {
			[Export ("objectValue", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selObjectValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selObjectValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setObjectValue:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetObjectValue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetObjectValue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PrefersTrackingUntilMouseUp {
			[Export ("prefersTrackingUntilMouseUp")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selPrefersTrackingUntilMouseUpXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject RepresentedObject {
			[Export ("representedObject", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRepresentedObjectXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRepresentedObjectXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRepresentedObject:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRepresentedObject_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRepresentedObject_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Scrollable {
			[Export ("isScrollable")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsScrollableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsScrollableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setScrollable:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetScrollable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetScrollable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		public virtual bool ShowsFirstResponder {
			[Export ("showsFirstResponder")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsFirstResponderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowsFirstResponderXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsFirstResponder:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsFirstResponder_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowsFirstResponder_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCellStateValue State {
			[Export ("state")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCellStateValue ret;
				if (IsDirectBinding) {
					ret = (NSCellStateValue) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSCellStateValue) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setState:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetState_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetState_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string StringValue {
			[Export ("stringValue")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setStringValue:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStringValue_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStringValue_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Tag {
			[Export ("tag")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTagXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTagXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTag:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTag_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetTag_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Target_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? Target {
			[Export ("target", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTargetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTargetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Target_var = ret;
				return ret!;
			}
			[Export ("setTarget:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTarget_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTarget_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Target_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TruncatesLastVisibleLine {
			[Export ("truncatesLastVisibleLine")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTruncatesLastVisibleLineXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selTruncatesLastVisibleLineXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTruncatesLastVisibleLine:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTruncatesLastVisibleLine_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetTruncatesLastVisibleLine_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUserInterfaceLayoutDirection UserInterfaceLayoutDirection {
			[Export ("userInterfaceLayoutDirection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUserInterfaceLayoutDirection ret;
				if (IsDirectBinding) {
					ret = (NSUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserInterfaceLayoutDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSUserInterfaceLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selUserInterfaceLayoutDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserInterfaceLayoutDirection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserInterfaceLayoutDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetUserInterfaceLayoutDirection_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesSingleLineMode {
			[Export ("usesSingleLineMode")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesSingleLineModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesSingleLineModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesSingleLineMode:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesSingleLineMode_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesSingleLineMode_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WantsNotificationForMarkedText {
			[Export ("wantsNotificationForMarkedText")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWantsNotificationForMarkedTextXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selWantsNotificationForMarkedTextXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Wraps {
			[Export ("wraps")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWrapsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selWrapsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setWraps:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetWraps_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetWraps_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnouncementRequestedNotification;
		/// <summary>Notification constant for AnnouncementRequested</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAnnouncementRequested(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveAnnouncementRequested(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveAnnouncementRequested ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveAnnouncementRequested (Callback);
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
		///     NSCell.AnnouncementRequestedNotification, (notification) => { Console.WriteLine ("Received the notification AnnouncementRequested", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AnnouncementRequested", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.AnnouncementRequestedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityAnnouncementRequestedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveAnnouncementRequested helper method instead.")]
		public static NSString AnnouncementRequestedNotification {
			get {
				if (_AnnouncementRequestedNotification is null)
					_AnnouncementRequestedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAnnouncementRequestedNotification")!;
				return _AnnouncementRequestedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationActivatedNotification;
		/// <summary>Notification constant for ApplicationActivated</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveApplicationActivated(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveApplicationActivated(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveApplicationActivated ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveApplicationActivated (Callback);
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
		///     NSCell.ApplicationActivatedNotification, (notification) => { Console.WriteLine ("Received the notification ApplicationActivated", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ApplicationActivated", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.ApplicationActivatedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityApplicationActivatedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveApplicationActivated helper method instead.")]
		public static NSString ApplicationActivatedNotification {
			get {
				if (_ApplicationActivatedNotification is null)
					_ApplicationActivatedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityApplicationActivatedNotification")!;
				return _ApplicationActivatedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationDeactivatedNotification;
		/// <summary>Notification constant for ApplicationDeactivated</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveApplicationDeactivated(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveApplicationDeactivated(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveApplicationDeactivated ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveApplicationDeactivated (Callback);
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
		///     NSCell.ApplicationDeactivatedNotification, (notification) => { Console.WriteLine ("Received the notification ApplicationDeactivated", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ApplicationDeactivated", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.ApplicationDeactivatedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityApplicationDeactivatedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveApplicationDeactivated helper method instead.")]
		public static NSString ApplicationDeactivatedNotification {
			get {
				if (_ApplicationDeactivatedNotification is null)
					_ApplicationDeactivatedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityApplicationDeactivatedNotification")!;
				return _ApplicationDeactivatedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationHiddenNotification;
		/// <summary>Notification constant for ApplicationHidden</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveApplicationHidden(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveApplicationHidden(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveApplicationHidden ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveApplicationHidden (Callback);
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
		///     NSCell.ApplicationHiddenNotification, (notification) => { Console.WriteLine ("Received the notification ApplicationHidden", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ApplicationHidden", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.ApplicationHiddenNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityApplicationHiddenNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveApplicationHidden helper method instead.")]
		public static NSString ApplicationHiddenNotification {
			get {
				if (_ApplicationHiddenNotification is null)
					_ApplicationHiddenNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityApplicationHiddenNotification")!;
				return _ApplicationHiddenNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ApplicationShownNotification;
		/// <summary>Notification constant for ApplicationShown</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveApplicationShown(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveApplicationShown(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveApplicationShown ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveApplicationShown (Callback);
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
		///     NSCell.ApplicationShownNotification, (notification) => { Console.WriteLine ("Received the notification ApplicationShown", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ApplicationShown", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.ApplicationShownNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityApplicationShownNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveApplicationShown helper method instead.")]
		public static NSString ApplicationShownNotification {
			get {
				if (_ApplicationShownNotification is null)
					_ApplicationShownNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityApplicationShownNotification")!;
				return _ApplicationShownNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AutocorrectionOccurredNotification;
		/// <summary>Notification constant for AutocorrectionOccurred</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAutocorrectionOccurred(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveAutocorrectionOccurred(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveAutocorrectionOccurred ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveAutocorrectionOccurred (Callback);
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
		///     NSCell.AutocorrectionOccurredNotification, (notification) => { Console.WriteLine ("Received the notification AutocorrectionOccurred", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AutocorrectionOccurred", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.AutocorrectionOccurredNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityAutocorrectionOccurredNotification",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[Advice ("Use NSCell.Notifications.ObserveAutocorrectionOccurred helper method instead.")]
		public static NSString AutocorrectionOccurredNotification {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_AutocorrectionOccurredNotification is null)
					_AutocorrectionOccurredNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityAutocorrectionOccurredNotification")!;
				return _AutocorrectionOccurredNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ControlTintChangedNotification;
		/// <summary>Notification constant for ControlTintChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveControlTintChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveControlTintChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveControlTintChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveControlTintChanged (Callback);
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
		///     NSCell.ControlTintChangedNotification, (notification) => { Console.WriteLine ("Received the notification ControlTintChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ControlTintChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.ControlTintChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSControlTintDidChangeNotification",  "AppKit")]
		[ObsoletedOSPlatform ("macos10.14", "Implement 'ViewDidChangeEffectiveAppearance' on NSView or observe 'NSApplication.EffectiveAppearance'.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use NSCell.Notifications.ObserveControlTintChanged helper method instead.")]
		public static NSString ControlTintChangedNotification {
			[ObsoletedOSPlatform ("macos10.14", "Implement 'ViewDidChangeEffectiveAppearance' on NSView or observe 'NSApplication.EffectiveAppearance'.")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ControlTintChangedNotification is null)
					_ControlTintChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSControlTintDidChangeNotification")!;
				return _ControlTintChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreatedNotification;
		/// <summary>Notification constant for Created</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveCreated(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveCreated(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveCreated ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveCreated (Callback);
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
		///     NSCell.CreatedNotification, (notification) => { Console.WriteLine ("Received the notification Created", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification Created", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.CreatedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityCreatedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveCreated helper method instead.")]
		public static NSString CreatedNotification {
			get {
				if (_CreatedNotification is null)
					_CreatedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityCreatedNotification")!;
				return _CreatedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DraggingDestinationDragAcceptedNotification;
		/// <summary>Notification constant for DraggingDestinationDragAccepted</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDraggingDestinationDragAccepted(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDraggingDestinationDragAccepted(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveDraggingDestinationDragAccepted ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveDraggingDestinationDragAccepted (Callback);
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
		///     NSCell.DraggingDestinationDragAcceptedNotification, (notification) => { Console.WriteLine ("Received the notification DraggingDestinationDragAccepted", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DraggingDestinationDragAccepted", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.DraggingDestinationDragAcceptedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityDraggingDestinationDragAcceptedNotification",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[Advice ("Use NSCell.Notifications.ObserveDraggingDestinationDragAccepted helper method instead.")]
		public static NSString DraggingDestinationDragAcceptedNotification {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_DraggingDestinationDragAcceptedNotification is null)
					_DraggingDestinationDragAcceptedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDraggingDestinationDragAcceptedNotification")!;
				return _DraggingDestinationDragAcceptedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DraggingDestinationDragNotAcceptedNotification;
		/// <summary>Notification constant for DraggingDestinationDragNotAccepted</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDraggingDestinationDragNotAccepted(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDraggingDestinationDragNotAccepted(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveDraggingDestinationDragNotAccepted ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveDraggingDestinationDragNotAccepted (Callback);
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
		///     NSCell.DraggingDestinationDragNotAcceptedNotification, (notification) => { Console.WriteLine ("Received the notification DraggingDestinationDragNotAccepted", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DraggingDestinationDragNotAccepted", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.DraggingDestinationDragNotAcceptedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityDraggingDestinationDragNotAcceptedNotification",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[Advice ("Use NSCell.Notifications.ObserveDraggingDestinationDragNotAccepted helper method instead.")]
		public static NSString DraggingDestinationDragNotAcceptedNotification {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_DraggingDestinationDragNotAcceptedNotification is null)
					_DraggingDestinationDragNotAcceptedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDraggingDestinationDragNotAcceptedNotification")!;
				return _DraggingDestinationDragNotAcceptedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DraggingDestinationDropAllowedNotification;
		/// <summary>Notification constant for DraggingDestinationDropAllowed</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDraggingDestinationDropAllowed(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDraggingDestinationDropAllowed(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveDraggingDestinationDropAllowed ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveDraggingDestinationDropAllowed (Callback);
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
		///     NSCell.DraggingDestinationDropAllowedNotification, (notification) => { Console.WriteLine ("Received the notification DraggingDestinationDropAllowed", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DraggingDestinationDropAllowed", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.DraggingDestinationDropAllowedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityDraggingDestinationDropAllowedNotification",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[Advice ("Use NSCell.Notifications.ObserveDraggingDestinationDropAllowed helper method instead.")]
		public static NSString DraggingDestinationDropAllowedNotification {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_DraggingDestinationDropAllowedNotification is null)
					_DraggingDestinationDropAllowedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDraggingDestinationDropAllowedNotification")!;
				return _DraggingDestinationDropAllowedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DraggingDestinationDropNotAllowedNotification;
		/// <summary>Notification constant for DraggingDestinationDropNotAllowed</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDraggingDestinationDropNotAllowed(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDraggingDestinationDropNotAllowed(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveDraggingDestinationDropNotAllowed ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveDraggingDestinationDropNotAllowed (Callback);
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
		///     NSCell.DraggingDestinationDropNotAllowedNotification, (notification) => { Console.WriteLine ("Received the notification DraggingDestinationDropNotAllowed", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DraggingDestinationDropNotAllowed", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.DraggingDestinationDropNotAllowedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityDraggingDestinationDropNotAllowedNotification",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[Advice ("Use NSCell.Notifications.ObserveDraggingDestinationDropNotAllowed helper method instead.")]
		public static NSString DraggingDestinationDropNotAllowedNotification {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_DraggingDestinationDropNotAllowedNotification is null)
					_DraggingDestinationDropNotAllowedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDraggingDestinationDropNotAllowedNotification")!;
				return _DraggingDestinationDropNotAllowedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DraggingSourceDragBeganNotification;
		/// <summary>Notification constant for DraggingSourceDragBegan</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDraggingSourceDragBegan(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDraggingSourceDragBegan(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveDraggingSourceDragBegan ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveDraggingSourceDragBegan (Callback);
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
		///     NSCell.DraggingSourceDragBeganNotification, (notification) => { Console.WriteLine ("Received the notification DraggingSourceDragBegan", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DraggingSourceDragBegan", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.DraggingSourceDragBeganNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityDraggingSourceDragBeganNotification",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[Advice ("Use NSCell.Notifications.ObserveDraggingSourceDragBegan helper method instead.")]
		public static NSString DraggingSourceDragBeganNotification {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_DraggingSourceDragBeganNotification is null)
					_DraggingSourceDragBeganNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDraggingSourceDragBeganNotification")!;
				return _DraggingSourceDragBeganNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DraggingSourceDragEndedNotification;
		/// <summary>Notification constant for DraggingSourceDragEnded</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDraggingSourceDragEnded(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDraggingSourceDragEnded(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveDraggingSourceDragEnded ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveDraggingSourceDragEnded (Callback);
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
		///     NSCell.DraggingSourceDragEndedNotification, (notification) => { Console.WriteLine ("Received the notification DraggingSourceDragEnded", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DraggingSourceDragEnded", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.DraggingSourceDragEndedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityDraggingSourceDragEndedNotification",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[Advice ("Use NSCell.Notifications.ObserveDraggingSourceDragEnded helper method instead.")]
		public static NSString DraggingSourceDragEndedNotification {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_DraggingSourceDragEndedNotification is null)
					_DraggingSourceDragEndedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDraggingSourceDragEndedNotification")!;
				return _DraggingSourceDragEndedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DrawerCreatedNotification;
		/// <summary>Notification constant for DrawerCreated</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDrawerCreated(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDrawerCreated(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveDrawerCreated ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveDrawerCreated (Callback);
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
		///     NSCell.DrawerCreatedNotification, (notification) => { Console.WriteLine ("Received the notification DrawerCreated", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DrawerCreated", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.DrawerCreatedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityDrawerCreatedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveDrawerCreated helper method instead.")]
		public static NSString DrawerCreatedNotification {
			get {
				if (_DrawerCreatedNotification is null)
					_DrawerCreatedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityDrawerCreatedNotification")!;
				return _DrawerCreatedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FocusedWindowChangedNotification;
		/// <summary>Notification constant for FocusedWindowChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveFocusedWindowChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveFocusedWindowChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveFocusedWindowChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveFocusedWindowChanged (Callback);
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
		///     NSCell.FocusedWindowChangedNotification, (notification) => { Console.WriteLine ("Received the notification FocusedWindowChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification FocusedWindowChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.FocusedWindowChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityFocusedWindowChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveFocusedWindowChanged helper method instead.")]
		public static NSString FocusedWindowChangedNotification {
			get {
				if (_FocusedWindowChangedNotification is null)
					_FocusedWindowChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFocusedWindowChangedNotification")!;
				return _FocusedWindowChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HelpTagCreatedNotification;
		/// <summary>Notification constant for HelpTagCreated</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveHelpTagCreated(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveHelpTagCreated(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveHelpTagCreated ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveHelpTagCreated (Callback);
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
		///     NSCell.HelpTagCreatedNotification, (notification) => { Console.WriteLine ("Received the notification HelpTagCreated", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification HelpTagCreated", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.HelpTagCreatedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityHelpTagCreatedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveHelpTagCreated helper method instead.")]
		public static NSString HelpTagCreatedNotification {
			get {
				if (_HelpTagCreatedNotification is null)
					_HelpTagCreatedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityHelpTagCreatedNotification")!;
				return _HelpTagCreatedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LayoutChangedNotification;
		/// <summary>Notification constant for LayoutChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveLayoutChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveLayoutChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveLayoutChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveLayoutChanged (Callback);
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
		///     NSCell.LayoutChangedNotification, (notification) => { Console.WriteLine ("Received the notification LayoutChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification LayoutChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.LayoutChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityLayoutChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveLayoutChanged helper method instead.")]
		public static NSString LayoutChangedNotification {
			get {
				if (_LayoutChangedNotification is null)
					_LayoutChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityLayoutChangedNotification")!;
				return _LayoutChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MainWindowChangedNotification;
		/// <summary>Notification constant for MainWindowChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveMainWindowChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveMainWindowChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveMainWindowChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveMainWindowChanged (Callback);
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
		///     NSCell.MainWindowChangedNotification, (notification) => { Console.WriteLine ("Received the notification MainWindowChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification MainWindowChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.MainWindowChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityMainWindowChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveMainWindowChanged helper method instead.")]
		public static NSString MainWindowChangedNotification {
			get {
				if (_MainWindowChangedNotification is null)
					_MainWindowChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMainWindowChangedNotification")!;
				return _MainWindowChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MovedNotification;
		/// <summary>Notification constant for Moved</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveMoved(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveMoved(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveMoved ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveMoved (Callback);
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
		///     NSCell.MovedNotification, (notification) => { Console.WriteLine ("Received the notification Moved", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification Moved", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.MovedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityMovedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveMoved helper method instead.")]
		public static NSString MovedNotification {
			get {
				if (_MovedNotification is null)
					_MovedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityMovedNotification")!;
				return _MovedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ResizedNotification;
		/// <summary>Notification constant for Resized</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveResized(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveResized(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveResized ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveResized (Callback);
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
		///     NSCell.ResizedNotification, (notification) => { Console.WriteLine ("Received the notification Resized", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification Resized", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.ResizedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityResizedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveResized helper method instead.")]
		public static NSString ResizedNotification {
			get {
				if (_ResizedNotification is null)
					_ResizedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityResizedNotification")!;
				return _ResizedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RowCollapsedNotification;
		/// <summary>Notification constant for RowCollapsed</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRowCollapsed(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveRowCollapsed(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveRowCollapsed ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveRowCollapsed (Callback);
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
		///     NSCell.RowCollapsedNotification, (notification) => { Console.WriteLine ("Received the notification RowCollapsed", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification RowCollapsed", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.RowCollapsedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityRowCollapsedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveRowCollapsed helper method instead.")]
		public static NSString RowCollapsedNotification {
			get {
				if (_RowCollapsedNotification is null)
					_RowCollapsedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRowCollapsedNotification")!;
				return _RowCollapsedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RowCountChangedNotification;
		/// <summary>Notification constant for RowCountChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRowCountChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveRowCountChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveRowCountChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveRowCountChanged (Callback);
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
		///     NSCell.RowCountChangedNotification, (notification) => { Console.WriteLine ("Received the notification RowCountChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification RowCountChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.RowCountChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityRowCountChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveRowCountChanged helper method instead.")]
		public static NSString RowCountChangedNotification {
			get {
				if (_RowCountChangedNotification is null)
					_RowCountChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRowCountChangedNotification")!;
				return _RowCountChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RowExpandedNotification;
		/// <summary>Notification constant for RowExpanded</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRowExpanded(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveRowExpanded(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveRowExpanded ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveRowExpanded (Callback);
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
		///     NSCell.RowExpandedNotification, (notification) => { Console.WriteLine ("Received the notification RowExpanded", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification RowExpanded", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.RowExpandedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityRowExpandedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveRowExpanded helper method instead.")]
		public static NSString RowExpandedNotification {
			get {
				if (_RowExpandedNotification is null)
					_RowExpandedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityRowExpandedNotification")!;
				return _RowExpandedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedCellsChangedNotification;
		/// <summary>Notification constant for SelectedCellsChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectedCellsChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectedCellsChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveSelectedCellsChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveSelectedCellsChanged (Callback);
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
		///     NSCell.SelectedCellsChangedNotification, (notification) => { Console.WriteLine ("Received the notification SelectedCellsChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectedCellsChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.SelectedCellsChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilitySelectedCellsChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveSelectedCellsChanged helper method instead.")]
		public static NSString SelectedCellsChangedNotification {
			get {
				if (_SelectedCellsChangedNotification is null)
					_SelectedCellsChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedCellsChangedNotification")!;
				return _SelectedCellsChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedChildrenChangedNotification;
		/// <summary>Notification constant for SelectedChildrenChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectedChildrenChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectedChildrenChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveSelectedChildrenChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveSelectedChildrenChanged (Callback);
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
		///     NSCell.SelectedChildrenChangedNotification, (notification) => { Console.WriteLine ("Received the notification SelectedChildrenChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectedChildrenChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.SelectedChildrenChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilitySelectedChildrenChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveSelectedChildrenChanged helper method instead.")]
		public static NSString SelectedChildrenChangedNotification {
			get {
				if (_SelectedChildrenChangedNotification is null)
					_SelectedChildrenChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenChangedNotification")!;
				return _SelectedChildrenChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedChildrenMovedNotification;
		/// <summary>Notification constant for SelectedChildrenMoved</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectedChildrenMoved(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectedChildrenMoved(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveSelectedChildrenMoved ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveSelectedChildrenMoved (Callback);
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
		///     NSCell.SelectedChildrenMovedNotification, (notification) => { Console.WriteLine ("Received the notification SelectedChildrenMoved", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectedChildrenMoved", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.SelectedChildrenMovedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilitySelectedChildrenMovedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveSelectedChildrenMoved helper method instead.")]
		public static NSString SelectedChildrenMovedNotification {
			get {
				if (_SelectedChildrenMovedNotification is null)
					_SelectedChildrenMovedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedChildrenMovedNotification")!;
				return _SelectedChildrenMovedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedColumnsChangedNotification;
		/// <summary>Notification constant for SelectedColumnsChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectedColumnsChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectedColumnsChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveSelectedColumnsChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveSelectedColumnsChanged (Callback);
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
		///     NSCell.SelectedColumnsChangedNotification, (notification) => { Console.WriteLine ("Received the notification SelectedColumnsChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectedColumnsChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.SelectedColumnsChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilitySelectedColumnsChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveSelectedColumnsChanged helper method instead.")]
		public static NSString SelectedColumnsChangedNotification {
			get {
				if (_SelectedColumnsChangedNotification is null)
					_SelectedColumnsChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedColumnsChangedNotification")!;
				return _SelectedColumnsChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedRowsChangedNotification;
		/// <summary>Notification constant for SelectedRowsChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectedRowsChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectedRowsChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveSelectedRowsChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveSelectedRowsChanged (Callback);
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
		///     NSCell.SelectedRowsChangedNotification, (notification) => { Console.WriteLine ("Received the notification SelectedRowsChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectedRowsChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.SelectedRowsChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilitySelectedRowsChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveSelectedRowsChanged helper method instead.")]
		public static NSString SelectedRowsChangedNotification {
			get {
				if (_SelectedRowsChangedNotification is null)
					_SelectedRowsChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedRowsChangedNotification")!;
				return _SelectedRowsChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SelectedTextChangedNotification;
		/// <summary>Notification constant for SelectedTextChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSelectedTextChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSelectedTextChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveSelectedTextChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveSelectedTextChanged (Callback);
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
		///     NSCell.SelectedTextChangedNotification, (notification) => { Console.WriteLine ("Received the notification SelectedTextChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SelectedTextChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.SelectedTextChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilitySelectedTextChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveSelectedTextChanged helper method instead.")]
		public static NSString SelectedTextChangedNotification {
			get {
				if (_SelectedTextChangedNotification is null)
					_SelectedTextChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySelectedTextChangedNotification")!;
				return _SelectedTextChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SheetCreatedNotification;
		/// <summary>Notification constant for SheetCreated</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSheetCreated(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSheetCreated(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveSheetCreated ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveSheetCreated (Callback);
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
		///     NSCell.SheetCreatedNotification, (notification) => { Console.WriteLine ("Received the notification SheetCreated", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SheetCreated", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.SheetCreatedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilitySheetCreatedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveSheetCreated helper method instead.")]
		public static NSString SheetCreatedNotification {
			get {
				if (_SheetCreatedNotification is null)
					_SheetCreatedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilitySheetCreatedNotification")!;
				return _SheetCreatedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextInputMarkingSessionBeganNotification;
		/// <summary>Notification constant for TextInputMarkingSessionBegan</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTextInputMarkingSessionBegan(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveTextInputMarkingSessionBegan(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveTextInputMarkingSessionBegan ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveTextInputMarkingSessionBegan (Callback);
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
		///     NSCell.TextInputMarkingSessionBeganNotification, (notification) => { Console.WriteLine ("Received the notification TextInputMarkingSessionBegan", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TextInputMarkingSessionBegan", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.TextInputMarkingSessionBeganNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityTextInputMarkingSessionBeganNotification",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[Advice ("Use NSCell.Notifications.ObserveTextInputMarkingSessionBegan helper method instead.")]
		public static NSString TextInputMarkingSessionBeganNotification {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_TextInputMarkingSessionBeganNotification is null)
					_TextInputMarkingSessionBeganNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextInputMarkingSessionBeganNotification")!;
				return _TextInputMarkingSessionBeganNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextInputMarkingSessionEndedNotification;
		/// <summary>Notification constant for TextInputMarkingSessionEnded</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTextInputMarkingSessionEnded(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveTextInputMarkingSessionEnded(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveTextInputMarkingSessionEnded ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveTextInputMarkingSessionEnded (Callback);
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
		///     NSCell.TextInputMarkingSessionEndedNotification, (notification) => { Console.WriteLine ("Received the notification TextInputMarkingSessionEnded", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TextInputMarkingSessionEnded", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.TextInputMarkingSessionEndedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityTextInputMarkingSessionEndedNotification",  "AppKit")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[Advice ("Use NSCell.Notifications.ObserveTextInputMarkingSessionEnded helper method instead.")]
		public static NSString TextInputMarkingSessionEndedNotification {
			[SupportedOSPlatform ("macos26.0")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_TextInputMarkingSessionEndedNotification is null)
					_TextInputMarkingSessionEndedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTextInputMarkingSessionEndedNotification")!;
				return _TextInputMarkingSessionEndedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TitleChangedNotification;
		/// <summary>Notification constant for TitleChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveTitleChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveTitleChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveTitleChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveTitleChanged (Callback);
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
		///     NSCell.TitleChangedNotification, (notification) => { Console.WriteLine ("Received the notification TitleChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification TitleChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.TitleChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityTitleChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveTitleChanged helper method instead.")]
		public static NSString TitleChangedNotification {
			get {
				if (_TitleChangedNotification is null)
					_TitleChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityTitleChangedNotification")!;
				return _TitleChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UIElementDestroyedNotification;
		/// <summary>Notification constant for UIElementDestroyed</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveUIElementDestroyed(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveUIElementDestroyed(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveUIElementDestroyed ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveUIElementDestroyed (Callback);
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
		///     NSCell.UIElementDestroyedNotification, (notification) => { Console.WriteLine ("Received the notification UIElementDestroyed", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification UIElementDestroyed", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.UIElementDestroyedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityUIElementDestroyedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveUIElementDestroyed helper method instead.")]
		public static NSString UIElementDestroyedNotification {
			get {
				if (_UIElementDestroyedNotification is null)
					_UIElementDestroyedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUIElementDestroyedNotification")!;
				return _UIElementDestroyedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UIElementFocusedChangedNotification;
		/// <summary>Notification constant for UIElementFocusedChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveUIElementFocusedChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveUIElementFocusedChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveUIElementFocusedChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveUIElementFocusedChanged (Callback);
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
		///     NSCell.UIElementFocusedChangedNotification, (notification) => { Console.WriteLine ("Received the notification UIElementFocusedChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification UIElementFocusedChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.UIElementFocusedChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityFocusedUIElementChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveUIElementFocusedChanged helper method instead.")]
		public static NSString UIElementFocusedChangedNotification {
			get {
				if (_UIElementFocusedChangedNotification is null)
					_UIElementFocusedChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityFocusedUIElementChangedNotification")!;
				return _UIElementFocusedChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnitsChangedNotification;
		/// <summary>Notification constant for UnitsChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveUnitsChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveUnitsChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveUnitsChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveUnitsChanged (Callback);
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
		///     NSCell.UnitsChangedNotification, (notification) => { Console.WriteLine ("Received the notification UnitsChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification UnitsChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.UnitsChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityUnitsChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveUnitsChanged helper method instead.")]
		public static NSString UnitsChangedNotification {
			get {
				if (_UnitsChangedNotification is null)
					_UnitsChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityUnitsChangedNotification")!;
				return _UnitsChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ValueChangedNotification;
		/// <summary>Notification constant for ValueChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveValueChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveValueChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveValueChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveValueChanged (Callback);
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
		///     NSCell.ValueChangedNotification, (notification) => { Console.WriteLine ("Received the notification ValueChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification ValueChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.ValueChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityValueChangedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveValueChanged helper method instead.")]
		public static NSString ValueChangedNotification {
			get {
				if (_ValueChangedNotification is null)
					_ValueChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityValueChangedNotification")!;
				return _ValueChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WindowCreatedNotification;
		/// <summary>Notification constant for WindowCreated</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWindowCreated(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWindowCreated(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveWindowCreated ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveWindowCreated (Callback);
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
		///     NSCell.WindowCreatedNotification, (notification) => { Console.WriteLine ("Received the notification WindowCreated", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WindowCreated", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.WindowCreatedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityWindowCreatedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveWindowCreated helper method instead.")]
		public static NSString WindowCreatedNotification {
			get {
				if (_WindowCreatedNotification is null)
					_WindowCreatedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWindowCreatedNotification")!;
				return _WindowCreatedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WindowDeminiaturizedNotification;
		/// <summary>Notification constant for WindowDeminiaturized</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWindowDeminiaturized(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWindowDeminiaturized(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveWindowDeminiaturized ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveWindowDeminiaturized (Callback);
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
		///     NSCell.WindowDeminiaturizedNotification, (notification) => { Console.WriteLine ("Received the notification WindowDeminiaturized", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WindowDeminiaturized", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.WindowDeminiaturizedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityWindowDeminiaturizedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveWindowDeminiaturized helper method instead.")]
		public static NSString WindowDeminiaturizedNotification {
			get {
				if (_WindowDeminiaturizedNotification is null)
					_WindowDeminiaturizedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWindowDeminiaturizedNotification")!;
				return _WindowDeminiaturizedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WindowMiniaturizedNotification;
		/// <summary>Notification constant for WindowMiniaturized</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWindowMiniaturized(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWindowMiniaturized(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveWindowMiniaturized ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveWindowMiniaturized (Callback);
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
		///     NSCell.WindowMiniaturizedNotification, (notification) => { Console.WriteLine ("Received the notification WindowMiniaturized", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WindowMiniaturized", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.WindowMiniaturizedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityWindowMiniaturizedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveWindowMiniaturized helper method instead.")]
		public static NSString WindowMiniaturizedNotification {
			get {
				if (_WindowMiniaturizedNotification is null)
					_WindowMiniaturizedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWindowMiniaturizedNotification")!;
				return _WindowMiniaturizedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WindowMovedNotification;
		/// <summary>Notification constant for WindowMoved</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWindowMoved(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWindowMoved(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveWindowMoved ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveWindowMoved (Callback);
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
		///     NSCell.WindowMovedNotification, (notification) => { Console.WriteLine ("Received the notification WindowMoved", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WindowMoved", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.WindowMovedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityWindowMovedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveWindowMoved helper method instead.")]
		public static NSString WindowMovedNotification {
			get {
				if (_WindowMovedNotification is null)
					_WindowMovedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWindowMovedNotification")!;
				return _WindowMovedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WindowResizedNotification;
		/// <summary>Notification constant for WindowResized</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWindowResized(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWindowResized(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCell.Notifications.ObserveWindowResized ((sender, args) => {
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
		/// void Callback (object sender, NSCell.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCell.Notifications.ObserveWindowResized (Callback);
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
		///     NSCell.WindowResizedNotification, (notification) => { Console.WriteLine ("Received the notification WindowResized", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WindowResized", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCell.WindowResizedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAccessibilityWindowResizedNotification",  "AppKit")]
		[Advice ("Use NSCell.Notifications.ObserveWindowResized helper method instead.")]
		public static NSString WindowResizedNotification {
			get {
				if (_WindowResizedNotification is null)
					_WindowResizedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAccessibilityWindowResizedNotification")!;
				return _WindowResizedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AccessibilityDisclosedByRow_var = null;
				__mt_AccessibilityExtrasMenuBar_var = null;
				__mt_AccessibilityMenuBar_var = null;
				__mt_AccessibilityParent_var = null;
				__mt_AccessibilityTitleUIElement_var = null;
				__mt_AccessibilityTopLevelUIElement_var = null;
				__mt_AccessibilityWindow_var = null;
				__mt_Target_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSCell" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.AnnouncementRequestedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.AnnouncementRequestedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveAnnouncementRequested ((notification) => {
			///   Console.WriteLine ("Observed AnnouncementRequestedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnnouncementRequested (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnouncementRequestedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.AnnouncementRequestedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.AnnouncementRequestedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveAnnouncementRequested (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AnnouncementRequestedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAnnouncementRequested (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnouncementRequestedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ApplicationActivatedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ApplicationActivatedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveApplicationActivated ((notification) => {
			///   Console.WriteLine ("Observed ApplicationActivatedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveApplicationActivated (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ApplicationActivatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ApplicationActivatedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ApplicationActivatedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveApplicationActivated (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ApplicationActivatedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveApplicationActivated (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ApplicationActivatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ApplicationDeactivatedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ApplicationDeactivatedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveApplicationDeactivated ((notification) => {
			///   Console.WriteLine ("Observed ApplicationDeactivatedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveApplicationDeactivated (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ApplicationDeactivatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ApplicationDeactivatedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ApplicationDeactivatedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveApplicationDeactivated (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ApplicationDeactivatedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveApplicationDeactivated (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ApplicationDeactivatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ApplicationHiddenNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ApplicationHiddenNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveApplicationHidden ((notification) => {
			///   Console.WriteLine ("Observed ApplicationHiddenNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveApplicationHidden (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ApplicationHiddenNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ApplicationHiddenNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ApplicationHiddenNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveApplicationHidden (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ApplicationHiddenNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveApplicationHidden (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ApplicationHiddenNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ApplicationShownNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ApplicationShownNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveApplicationShown ((notification) => {
			///   Console.WriteLine ("Observed ApplicationShownNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveApplicationShown (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ApplicationShownNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ApplicationShownNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ApplicationShownNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveApplicationShown (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ApplicationShownNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveApplicationShown (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ApplicationShownNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.AutocorrectionOccurredNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.AutocorrectionOccurredNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveAutocorrectionOccurred ((notification) => {
			///   Console.WriteLine ("Observed AutocorrectionOccurredNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAutocorrectionOccurred (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AutocorrectionOccurredNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.AutocorrectionOccurredNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.AutocorrectionOccurredNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveAutocorrectionOccurred (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AutocorrectionOccurredNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAutocorrectionOccurred (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AutocorrectionOccurredNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ControlTintChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ControlTintChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveControlTintChanged ((notification) => {
			///   Console.WriteLine ("Observed ControlTintChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveControlTintChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ControlTintChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ControlTintChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ControlTintChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveControlTintChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ControlTintChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveControlTintChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ControlTintChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.CreatedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.CreatedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveCreated ((notification) => {
			///   Console.WriteLine ("Observed CreatedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCreated (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.CreatedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.CreatedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveCreated (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed CreatedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCreated (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingDestinationDragAcceptedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingDestinationDragAcceptedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveDraggingDestinationDragAccepted ((notification) => {
			///   Console.WriteLine ("Observed DraggingDestinationDragAcceptedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingDestinationDragAccepted (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingDestinationDragAcceptedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingDestinationDragAcceptedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingDestinationDragAcceptedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveDraggingDestinationDragAccepted (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DraggingDestinationDragAcceptedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingDestinationDragAccepted (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingDestinationDragAcceptedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingDestinationDragNotAcceptedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingDestinationDragNotAcceptedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveDraggingDestinationDragNotAccepted ((notification) => {
			///   Console.WriteLine ("Observed DraggingDestinationDragNotAcceptedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingDestinationDragNotAccepted (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingDestinationDragNotAcceptedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingDestinationDragNotAcceptedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingDestinationDragNotAcceptedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveDraggingDestinationDragNotAccepted (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DraggingDestinationDragNotAcceptedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingDestinationDragNotAccepted (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingDestinationDragNotAcceptedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingDestinationDropAllowedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingDestinationDropAllowedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveDraggingDestinationDropAllowed ((notification) => {
			///   Console.WriteLine ("Observed DraggingDestinationDropAllowedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingDestinationDropAllowed (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingDestinationDropAllowedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingDestinationDropAllowedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingDestinationDropAllowedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveDraggingDestinationDropAllowed (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DraggingDestinationDropAllowedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingDestinationDropAllowed (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingDestinationDropAllowedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingDestinationDropNotAllowedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingDestinationDropNotAllowedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveDraggingDestinationDropNotAllowed ((notification) => {
			///   Console.WriteLine ("Observed DraggingDestinationDropNotAllowedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingDestinationDropNotAllowed (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingDestinationDropNotAllowedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingDestinationDropNotAllowedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingDestinationDropNotAllowedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveDraggingDestinationDropNotAllowed (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DraggingDestinationDropNotAllowedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingDestinationDropNotAllowed (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingDestinationDropNotAllowedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingSourceDragBeganNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingSourceDragBeganNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveDraggingSourceDragBegan ((notification) => {
			///   Console.WriteLine ("Observed DraggingSourceDragBeganNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingSourceDragBegan (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingSourceDragBeganNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingSourceDragBeganNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingSourceDragBeganNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveDraggingSourceDragBegan (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DraggingSourceDragBeganNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingSourceDragBegan (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingSourceDragBeganNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingSourceDragEndedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingSourceDragEndedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveDraggingSourceDragEnded ((notification) => {
			///   Console.WriteLine ("Observed DraggingSourceDragEndedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingSourceDragEnded (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingSourceDragEndedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DraggingSourceDragEndedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DraggingSourceDragEndedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveDraggingSourceDragEnded (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DraggingSourceDragEndedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDraggingSourceDragEnded (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DraggingSourceDragEndedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DrawerCreatedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DrawerCreatedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveDrawerCreated ((notification) => {
			///   Console.WriteLine ("Observed DrawerCreatedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDrawerCreated (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DrawerCreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.DrawerCreatedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.DrawerCreatedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveDrawerCreated (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DrawerCreatedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDrawerCreated (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DrawerCreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.FocusedWindowChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.FocusedWindowChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveFocusedWindowChanged ((notification) => {
			///   Console.WriteLine ("Observed FocusedWindowChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFocusedWindowChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FocusedWindowChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.FocusedWindowChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.FocusedWindowChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveFocusedWindowChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed FocusedWindowChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFocusedWindowChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FocusedWindowChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.HelpTagCreatedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.HelpTagCreatedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveHelpTagCreated ((notification) => {
			///   Console.WriteLine ("Observed HelpTagCreatedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveHelpTagCreated (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (HelpTagCreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.HelpTagCreatedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.HelpTagCreatedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveHelpTagCreated (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed HelpTagCreatedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveHelpTagCreated (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (HelpTagCreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.LayoutChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.LayoutChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveLayoutChanged ((notification) => {
			///   Console.WriteLine ("Observed LayoutChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveLayoutChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (LayoutChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.LayoutChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.LayoutChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveLayoutChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed LayoutChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveLayoutChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (LayoutChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.MainWindowChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.MainWindowChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveMainWindowChanged ((notification) => {
			///   Console.WriteLine ("Observed MainWindowChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMainWindowChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MainWindowChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.MainWindowChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.MainWindowChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveMainWindowChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed MainWindowChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMainWindowChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MainWindowChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.MovedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.MovedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveMoved ((notification) => {
			///   Console.WriteLine ("Observed MovedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMoved (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.MovedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.MovedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveMoved (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed MovedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveMoved (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ResizedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ResizedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveResized ((notification) => {
			///   Console.WriteLine ("Observed ResizedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveResized (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ResizedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ResizedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ResizedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveResized (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ResizedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveResized (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ResizedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.RowCollapsedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.RowCollapsedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveRowCollapsed ((notification) => {
			///   Console.WriteLine ("Observed RowCollapsedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRowCollapsed (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RowCollapsedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.RowCollapsedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.RowCollapsedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveRowCollapsed (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RowCollapsedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRowCollapsed (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RowCollapsedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.RowCountChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.RowCountChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveRowCountChanged ((notification) => {
			///   Console.WriteLine ("Observed RowCountChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRowCountChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RowCountChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.RowCountChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.RowCountChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveRowCountChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RowCountChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRowCountChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RowCountChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.RowExpandedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.RowExpandedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveRowExpanded ((notification) => {
			///   Console.WriteLine ("Observed RowExpandedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRowExpanded (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RowExpandedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.RowExpandedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.RowExpandedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveRowExpanded (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RowExpandedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRowExpanded (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RowExpandedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedCellsChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedCellsChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveSelectedCellsChanged ((notification) => {
			///   Console.WriteLine ("Observed SelectedCellsChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedCellsChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedCellsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedCellsChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedCellsChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveSelectedCellsChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectedCellsChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedCellsChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedCellsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedChildrenChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedChildrenChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveSelectedChildrenChanged ((notification) => {
			///   Console.WriteLine ("Observed SelectedChildrenChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedChildrenChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedChildrenChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedChildrenChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedChildrenChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveSelectedChildrenChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectedChildrenChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedChildrenChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedChildrenChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedChildrenMovedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedChildrenMovedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveSelectedChildrenMoved ((notification) => {
			///   Console.WriteLine ("Observed SelectedChildrenMovedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedChildrenMoved (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedChildrenMovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedChildrenMovedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedChildrenMovedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveSelectedChildrenMoved (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectedChildrenMovedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedChildrenMoved (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedChildrenMovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedColumnsChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedColumnsChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveSelectedColumnsChanged ((notification) => {
			///   Console.WriteLine ("Observed SelectedColumnsChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedColumnsChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedColumnsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedColumnsChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedColumnsChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveSelectedColumnsChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectedColumnsChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedColumnsChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedColumnsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedRowsChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedRowsChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveSelectedRowsChanged ((notification) => {
			///   Console.WriteLine ("Observed SelectedRowsChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedRowsChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedRowsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedRowsChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedRowsChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveSelectedRowsChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectedRowsChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedRowsChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedRowsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedTextChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedTextChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveSelectedTextChanged ((notification) => {
			///   Console.WriteLine ("Observed SelectedTextChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedTextChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedTextChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SelectedTextChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SelectedTextChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveSelectedTextChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SelectedTextChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSelectedTextChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SelectedTextChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SheetCreatedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SheetCreatedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveSheetCreated ((notification) => {
			///   Console.WriteLine ("Observed SheetCreatedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSheetCreated (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SheetCreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.SheetCreatedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.SheetCreatedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveSheetCreated (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SheetCreatedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSheetCreated (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SheetCreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.TextInputMarkingSessionBeganNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.TextInputMarkingSessionBeganNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveTextInputMarkingSessionBegan ((notification) => {
			///   Console.WriteLine ("Observed TextInputMarkingSessionBeganNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextInputMarkingSessionBegan (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextInputMarkingSessionBeganNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.TextInputMarkingSessionBeganNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.TextInputMarkingSessionBeganNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveTextInputMarkingSessionBegan (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TextInputMarkingSessionBeganNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextInputMarkingSessionBegan (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextInputMarkingSessionBeganNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.TextInputMarkingSessionEndedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.TextInputMarkingSessionEndedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveTextInputMarkingSessionEnded ((notification) => {
			///   Console.WriteLine ("Observed TextInputMarkingSessionEndedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextInputMarkingSessionEnded (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextInputMarkingSessionEndedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.TextInputMarkingSessionEndedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.TextInputMarkingSessionEndedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveTextInputMarkingSessionEnded (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TextInputMarkingSessionEndedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTextInputMarkingSessionEnded (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TextInputMarkingSessionEndedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.TitleChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.TitleChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveTitleChanged ((notification) => {
			///   Console.WriteLine ("Observed TitleChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTitleChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TitleChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.TitleChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.TitleChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveTitleChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed TitleChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveTitleChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (TitleChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.UIElementDestroyedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.UIElementDestroyedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveUIElementDestroyed ((notification) => {
			///   Console.WriteLine ("Observed UIElementDestroyedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUIElementDestroyed (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UIElementDestroyedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.UIElementDestroyedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.UIElementDestroyedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveUIElementDestroyed (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed UIElementDestroyedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUIElementDestroyed (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UIElementDestroyedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.UIElementFocusedChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.UIElementFocusedChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveUIElementFocusedChanged ((notification) => {
			///   Console.WriteLine ("Observed UIElementFocusedChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUIElementFocusedChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UIElementFocusedChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.UIElementFocusedChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.UIElementFocusedChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveUIElementFocusedChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed UIElementFocusedChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUIElementFocusedChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UIElementFocusedChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.UnitsChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.UnitsChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveUnitsChanged ((notification) => {
			///   Console.WriteLine ("Observed UnitsChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUnitsChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UnitsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.UnitsChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.UnitsChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveUnitsChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed UnitsChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveUnitsChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UnitsChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ValueChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ValueChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveValueChanged ((notification) => {
			///   Console.WriteLine ("Observed ValueChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveValueChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ValueChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.ValueChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.ValueChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveValueChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ValueChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveValueChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ValueChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowCreatedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowCreatedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveWindowCreated ((notification) => {
			///   Console.WriteLine ("Observed WindowCreatedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowCreated (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowCreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowCreatedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowCreatedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveWindowCreated (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WindowCreatedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowCreated (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowCreatedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowDeminiaturizedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowDeminiaturizedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveWindowDeminiaturized ((notification) => {
			///   Console.WriteLine ("Observed WindowDeminiaturizedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowDeminiaturized (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowDeminiaturizedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowDeminiaturizedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowDeminiaturizedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveWindowDeminiaturized (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WindowDeminiaturizedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowDeminiaturized (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowDeminiaturizedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowMiniaturizedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowMiniaturizedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveWindowMiniaturized ((notification) => {
			///   Console.WriteLine ("Observed WindowMiniaturizedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowMiniaturized (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowMiniaturizedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowMiniaturizedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowMiniaturizedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveWindowMiniaturized (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WindowMiniaturizedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowMiniaturized (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowMiniaturizedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowMovedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowMovedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveWindowMoved ((notification) => {
			///   Console.WriteLine ("Observed WindowMovedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowMoved (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowMovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowMovedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowMovedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveWindowMoved (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WindowMovedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowMoved (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowMovedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowResizedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowResizedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCell.Notifications.ObserveWindowResized ((notification) => {
			///   Console.WriteLine ("Observed WindowResizedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowResized (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowResizedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSCell.WindowResizedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSCell.WindowResizedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCell.Notifications.ObserveWindowResized (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WindowResizedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWindowResized (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WindowResizedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSCell */
}
