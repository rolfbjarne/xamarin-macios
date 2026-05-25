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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSAccessibility</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSAccessibility", WrapperType = typeof (NSAccessibilityWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLayoutForScreen", Selector = "accessibilityLayoutPointForScreenPoint:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLayoutForScreen", Selector = "accessibilityLayoutSizeForScreenSize:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (CGSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityScreenForLayout", Selector = "accessibilityScreenPointForLayoutPoint:", ReturnType = typeof (CGPoint), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityScreenForLayout", Selector = "accessibilityScreenSizeForLayoutSize:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (CGSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityCellForColumn", Selector = "accessibilityCellForColumn:row:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityAttributedString", Selector = "accessibilityAttributedStringForRange:", ReturnType = typeof (NSAttributedString), ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRangeForLine", Selector = "accessibilityRangeForLine:", ReturnType = typeof (NSRange), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityString", Selector = "accessibilityStringForRange:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRange", Selector = "accessibilityRangeForPosition:", ReturnType = typeof (NSRange), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRange", Selector = "accessibilityRangeForIndex:", ReturnType = typeof (NSRange), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityFrame", Selector = "accessibilityFrameForRange:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRtf", Selector = "accessibilityRTFForRange:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityStyleRange", Selector = "accessibilityStyleRangeForIndex:", ReturnType = typeof (NSRange), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLine", Selector = "accessibilityLineForIndex:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformCancel", Selector = "accessibilityPerformCancel", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformConfirm", Selector = "accessibilityPerformConfirm", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformDecrement", Selector = "accessibilityPerformDecrement", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformDelete", Selector = "accessibilityPerformDelete", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformIncrement", Selector = "accessibilityPerformIncrement", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformPick", Selector = "accessibilityPerformPick", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformPress", Selector = "accessibilityPerformPress", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformRaise", Selector = "accessibilityPerformRaise", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformShowAlternateUI", Selector = "accessibilityPerformShowAlternateUI", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformShowDefaultUI", Selector = "accessibilityPerformShowDefaultUI", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AccessibilityPerformShowMenu", Selector = "accessibilityPerformShowMenu", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsAccessibilitySelectorAllowed", Selector = "isAccessibilitySelectorAllowed:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (Selector) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFrame", Selector = "accessibilityFrame", PropertyType = typeof (CGRect), GetterSelector = "accessibilityFrame", SetterSelector = "setAccessibilityFrame:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityIdentifier", Selector = "accessibilityIdentifier", PropertyType = typeof (string), GetterSelector = "accessibilityIdentifier", SetterSelector = "setAccessibilityIdentifier:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityParent", Selector = "accessibilityParent", PropertyType = typeof (NSObject), GetterSelector = "accessibilityParent", SetterSelector = "setAccessibilityParent:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFocused", Selector = "accessibilityFocused", PropertyType = typeof (bool), GetterSelector = "isAccessibilityFocused", SetterSelector = "setAccessibilityFocused:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityElement", Selector = "accessibilityElement", PropertyType = typeof (bool), GetterSelector = "isAccessibilityElement", SetterSelector = "setAccessibilityElement:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityActivationPoint", Selector = "accessibilityActivationPoint", PropertyType = typeof (CGPoint), GetterSelector = "accessibilityActivationPoint", SetterSelector = "setAccessibilityActivationPoint:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityTopLevelUIElement", Selector = "accessibilityTopLevelUIElement", PropertyType = typeof (NSObject), GetterSelector = "accessibilityTopLevelUIElement", SetterSelector = "setAccessibilityTopLevelUIElement:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityUrl", Selector = "accessibilityURL", PropertyType = typeof (NSUrl), GetterSelector = "accessibilityURL", SetterSelector = "setAccessibilityURL:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityValue", Selector = "accessibilityValue", PropertyType = typeof (NSObject), GetterSelector = "accessibilityValue", SetterSelector = "setAccessibilityValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityValueDescription", Selector = "accessibilityValueDescription", PropertyType = typeof (string), GetterSelector = "accessibilityValueDescription", SetterSelector = "setAccessibilityValueDescription:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleChildren", Selector = "accessibilityVisibleChildren", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityVisibleChildren", SetterSelector = "setAccessibilityVisibleChildren:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySubrole", Selector = "accessibilitySubrole", PropertyType = typeof (string), GetterSelector = "accessibilitySubrole", SetterSelector = "setAccessibilitySubrole:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityTitle", Selector = "accessibilityTitle", PropertyType = typeof (string), GetterSelector = "accessibilityTitle", SetterSelector = "setAccessibilityTitle:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityTitleUIElement", Selector = "accessibilityTitleUIElement", PropertyType = typeof (NSObject), GetterSelector = "accessibilityTitleUIElement", SetterSelector = "setAccessibilityTitleUIElement:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityNextContents", Selector = "accessibilityNextContents", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityNextContents", SetterSelector = "setAccessibilityNextContents:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityOrientation", Selector = "accessibilityOrientation", PropertyType = typeof (NSAccessibilityOrientation), GetterSelector = "accessibilityOrientation", SetterSelector = "setAccessibilityOrientation:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityOverflowButton", Selector = "accessibilityOverflowButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityOverflowButton", SetterSelector = "setAccessibilityOverflowButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityPlaceholderValue", Selector = "accessibilityPlaceholderValue", PropertyType = typeof (string), GetterSelector = "accessibilityPlaceholderValue", SetterSelector = "setAccessibilityPlaceholderValue:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityPreviousContents", Selector = "accessibilityPreviousContents", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityPreviousContents", SetterSelector = "setAccessibilityPreviousContents:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRole", Selector = "accessibilityRole", PropertyType = typeof (string), GetterSelector = "accessibilityRole", SetterSelector = "setAccessibilityRole:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRoleDescription", Selector = "accessibilityRoleDescription", PropertyType = typeof (string), GetterSelector = "accessibilityRoleDescription", SetterSelector = "setAccessibilityRoleDescription:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySearchButton", Selector = "accessibilitySearchButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilitySearchButton", SetterSelector = "setAccessibilitySearchButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySearchMenu", Selector = "accessibilitySearchMenu", PropertyType = typeof (NSObject), GetterSelector = "accessibilitySearchMenu", SetterSelector = "setAccessibilitySearchMenu:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelected", Selector = "accessibilitySelected", PropertyType = typeof (bool), GetterSelector = "isAccessibilitySelected", SetterSelector = "setAccessibilitySelected:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedChildren", Selector = "accessibilitySelectedChildren", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySelectedChildren", SetterSelector = "setAccessibilitySelectedChildren:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityServesAsTitleForUIElements", Selector = "accessibilityServesAsTitleForUIElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityServesAsTitleForUIElements", SetterSelector = "setAccessibilityServesAsTitleForUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityShownMenu", Selector = "accessibilityShownMenu", PropertyType = typeof (NSObject), GetterSelector = "accessibilityShownMenu", SetterSelector = "setAccessibilityShownMenu:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMinValue", Selector = "accessibilityMinValue", PropertyType = typeof (NSObject), GetterSelector = "accessibilityMinValue", SetterSelector = "setAccessibilityMinValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMaxValue", Selector = "accessibilityMaxValue", PropertyType = typeof (NSObject), GetterSelector = "accessibilityMaxValue", SetterSelector = "setAccessibilityMaxValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLinkedUIElements", Selector = "accessibilityLinkedUIElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityLinkedUIElements", SetterSelector = "setAccessibilityLinkedUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityWindow", Selector = "accessibilityWindow", PropertyType = typeof (NSObject), GetterSelector = "accessibilityWindow", SetterSelector = "setAccessibilityWindow:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHelp", Selector = "accessibilityHelp", PropertyType = typeof (string), GetterSelector = "accessibilityHelp", SetterSelector = "setAccessibilityHelp:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFilename", Selector = "accessibilityFilename", PropertyType = typeof (string), GetterSelector = "accessibilityFilename", SetterSelector = "setAccessibilityFilename:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityExpanded", Selector = "accessibilityExpanded", PropertyType = typeof (bool), GetterSelector = "isAccessibilityExpanded", SetterSelector = "setAccessibilityExpanded:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityEdited", Selector = "accessibilityEdited", PropertyType = typeof (bool), GetterSelector = "isAccessibilityEdited", SetterSelector = "setAccessibilityEdited:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityEnabled", Selector = "accessibilityEnabled", PropertyType = typeof (bool), GetterSelector = "isAccessibilityEnabled", SetterSelector = "setAccessibilityEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityChildren", Selector = "accessibilityChildren", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityChildren", SetterSelector = "setAccessibilityChildren:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityClearButton", Selector = "accessibilityClearButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityClearButton", SetterSelector = "setAccessibilityClearButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityCancelButton", Selector = "accessibilityCancelButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityCancelButton", SetterSelector = "setAccessibilityCancelButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityProtectedContent", Selector = "accessibilityProtectedContent", PropertyType = typeof (bool), GetterSelector = "isAccessibilityProtectedContent", SetterSelector = "setAccessibilityProtectedContent:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityContents", Selector = "accessibilityContents", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityContents", SetterSelector = "setAccessibilityContents:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabel", Selector = "accessibilityLabel", PropertyType = typeof (string), GetterSelector = "accessibilityLabel", SetterSelector = "setAccessibilityLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityAlternateUIVisible", Selector = "accessibilityAlternateUIVisible", PropertyType = typeof (bool), GetterSelector = "isAccessibilityAlternateUIVisible", SetterSelector = "setAccessibilityAlternateUIVisible:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySharedFocusElements", Selector = "accessibilitySharedFocusElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySharedFocusElements", SetterSelector = "setAccessibilitySharedFocusElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityApplicationFocusedUIElement", Selector = "accessibilityApplicationFocusedUIElement", PropertyType = typeof (NSObject), GetterSelector = "accessibilityApplicationFocusedUIElement", SetterSelector = "setAccessibilityApplicationFocusedUIElement:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMainWindow", Selector = "accessibilityMainWindow", PropertyType = typeof (NSObject), GetterSelector = "accessibilityMainWindow", SetterSelector = "setAccessibilityMainWindow:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHidden", Selector = "accessibilityHidden", PropertyType = typeof (bool), GetterSelector = "isAccessibilityHidden", SetterSelector = "setAccessibilityHidden:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFrontmost", Selector = "accessibilityFrontmost", PropertyType = typeof (bool), GetterSelector = "isAccessibilityFrontmost", SetterSelector = "setAccessibilityFrontmost:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFocusedWindow", Selector = "accessibilityFocusedWindow", PropertyType = typeof (NSObject), GetterSelector = "accessibilityFocusedWindow", SetterSelector = "setAccessibilityFocusedWindow:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityWindows", Selector = "accessibilityWindows", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityWindows", SetterSelector = "setAccessibilityWindows:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityExtrasMenuBar", Selector = "accessibilityExtrasMenuBar", PropertyType = typeof (NSObject), GetterSelector = "accessibilityExtrasMenuBar", SetterSelector = "setAccessibilityExtrasMenuBar:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMenuBar", Selector = "accessibilityMenuBar", PropertyType = typeof (NSObject), GetterSelector = "accessibilityMenuBar", SetterSelector = "setAccessibilityMenuBar:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnTitles", Selector = "accessibilityColumnTitles", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityColumnTitles", SetterSelector = "setAccessibilityColumnTitles:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityOrderedByRow", Selector = "accessibilityOrderedByRow", PropertyType = typeof (bool), GetterSelector = "isAccessibilityOrderedByRow", SetterSelector = "setAccessibilityOrderedByRow:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHorizontalUnits", Selector = "accessibilityHorizontalUnits", PropertyType = typeof (NSAccessibilityUnits), GetterSelector = "accessibilityHorizontalUnits", SetterSelector = "setAccessibilityHorizontalUnits:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVerticalUnits", Selector = "accessibilityVerticalUnits", PropertyType = typeof (NSAccessibilityUnits), GetterSelector = "accessibilityVerticalUnits", SetterSelector = "setAccessibilityVerticalUnits:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHorizontalUnitDescription", Selector = "accessibilityHorizontalUnitDescription", PropertyType = typeof (string), GetterSelector = "accessibilityHorizontalUnitDescription", SetterSelector = "setAccessibilityHorizontalUnitDescription:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVerticalUnitDescription", Selector = "accessibilityVerticalUnitDescription", PropertyType = typeof (string), GetterSelector = "accessibilityVerticalUnitDescription", SetterSelector = "setAccessibilityVerticalUnitDescription:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHandles", Selector = "accessibilityHandles", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityHandles", SetterSelector = "setAccessibilityHandles:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityWarningValue", Selector = "accessibilityWarningValue", PropertyType = typeof (NSObject), GetterSelector = "accessibilityWarningValue", SetterSelector = "setAccessibilityWarningValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityCriticalValue", Selector = "accessibilityCriticalValue", PropertyType = typeof (NSObject), GetterSelector = "accessibilityCriticalValue", SetterSelector = "setAccessibilityCriticalValue:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosed", Selector = "accessibilityDisclosed", PropertyType = typeof (bool), GetterSelector = "isAccessibilityDisclosed", SetterSelector = "setAccessibilityDisclosed:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosedByRow", Selector = "accessibilityDisclosedByRow", PropertyType = typeof (NSObject), GetterSelector = "accessibilityDisclosedByRow", SetterSelector = "setAccessibilityDisclosedByRow:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosedRows", Selector = "accessibilityDisclosedRows", PropertyType = typeof (NSObject), GetterSelector = "accessibilityDisclosedRows", SetterSelector = "setAccessibilityDisclosedRows:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDisclosureLevel", Selector = "accessibilityDisclosureLevel", PropertyType = typeof (IntPtr), GetterSelector = "accessibilityDisclosureLevel", SetterSelector = "setAccessibilityDisclosureLevel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMarkerUIElements", Selector = "accessibilityMarkerUIElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityMarkerUIElements", SetterSelector = "setAccessibilityMarkerUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMarkerValues", Selector = "accessibilityMarkerValues", PropertyType = typeof (NSObject), GetterSelector = "accessibilityMarkerValues", SetterSelector = "setAccessibilityMarkerValues:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMarkerGroupUIElement", Selector = "accessibilityMarkerGroupUIElement", PropertyType = typeof (NSObject), GetterSelector = "accessibilityMarkerGroupUIElement", SetterSelector = "setAccessibilityMarkerGroupUIElement:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityUnits", Selector = "accessibilityUnits", PropertyType = typeof (NSAccessibilityUnits), GetterSelector = "accessibilityUnits", SetterSelector = "setAccessibilityUnits:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityUnitDescription", Selector = "accessibilityUnitDescription", PropertyType = typeof (string), GetterSelector = "accessibilityUnitDescription", SetterSelector = "setAccessibilityUnitDescription:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRulerMarkerType", Selector = "accessibilityRulerMarkerType", PropertyType = typeof (NSAccessibilityRulerMarkerType), GetterSelector = "accessibilityRulerMarkerType", SetterSelector = "setAccessibilityRulerMarkerType:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMarkerTypeDescription", Selector = "accessibilityMarkerTypeDescription", PropertyType = typeof (string), GetterSelector = "accessibilityMarkerTypeDescription", SetterSelector = "setAccessibilityMarkerTypeDescription:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHorizontalScrollBar", Selector = "accessibilityHorizontalScrollBar", PropertyType = typeof (NSObject), GetterSelector = "accessibilityHorizontalScrollBar", SetterSelector = "setAccessibilityHorizontalScrollBar:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVerticalScrollBar", Selector = "accessibilityVerticalScrollBar", PropertyType = typeof (NSObject), GetterSelector = "accessibilityVerticalScrollBar", SetterSelector = "setAccessibilityVerticalScrollBar:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityAllowedValues", Selector = "accessibilityAllowedValues", PropertyType = typeof (NSNumber[]), GetterSelector = "accessibilityAllowedValues", SetterSelector = "setAccessibilityAllowedValues:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabelUIElements", Selector = "accessibilityLabelUIElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityLabelUIElements", SetterSelector = "setAccessibilityLabelUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityLabelValue", Selector = "accessibilityLabelValue", PropertyType = typeof (float), GetterSelector = "accessibilityLabelValue", SetterSelector = "setAccessibilityLabelValue:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySplitters", Selector = "accessibilitySplitters", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySplitters", SetterSelector = "setAccessibilitySplitters:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDecrementButton", Selector = "accessibilityDecrementButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityDecrementButton", SetterSelector = "setAccessibilityDecrementButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityIncrementButton", Selector = "accessibilityIncrementButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityIncrementButton", SetterSelector = "setAccessibilityIncrementButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityTabs", Selector = "accessibilityTabs", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityTabs", SetterSelector = "setAccessibilityTabs:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityHeader", Selector = "accessibilityHeader", PropertyType = typeof (NSObject), GetterSelector = "accessibilityHeader", SetterSelector = "setAccessibilityHeader:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnCount", Selector = "accessibilityColumnCount", PropertyType = typeof (IntPtr), GetterSelector = "accessibilityColumnCount", SetterSelector = "setAccessibilityColumnCount:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRowCount", Selector = "accessibilityRowCount", PropertyType = typeof (IntPtr), GetterSelector = "accessibilityRowCount", SetterSelector = "setAccessibilityRowCount:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityIndex", Selector = "accessibilityIndex", PropertyType = typeof (IntPtr), GetterSelector = "accessibilityIndex", SetterSelector = "setAccessibilityIndex:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumns", Selector = "accessibilityColumns", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityColumns", SetterSelector = "setAccessibilityColumns:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRows", Selector = "accessibilityRows", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityRows", SetterSelector = "setAccessibilityRows:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleRows", Selector = "accessibilityVisibleRows", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityVisibleRows", SetterSelector = "setAccessibilityVisibleRows:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedRows", Selector = "accessibilitySelectedRows", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySelectedRows", SetterSelector = "setAccessibilitySelectedRows:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleColumns", Selector = "accessibilityVisibleColumns", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityVisibleColumns", SetterSelector = "setAccessibilityVisibleColumns:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedColumns", Selector = "accessibilitySelectedColumns", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySelectedColumns", SetterSelector = "setAccessibilitySelectedColumns:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySortDirection", Selector = "accessibilitySortDirection", PropertyType = typeof (NSAccessibilitySortDirection), GetterSelector = "accessibilitySortDirection", SetterSelector = "setAccessibilitySortDirection:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRowHeaderUIElements", Selector = "accessibilityRowHeaderUIElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityRowHeaderUIElements", SetterSelector = "setAccessibilityRowHeaderUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedCells", Selector = "accessibilitySelectedCells", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySelectedCells", SetterSelector = "setAccessibilitySelectedCells:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleCells", Selector = "accessibilityVisibleCells", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityVisibleCells", SetterSelector = "setAccessibilityVisibleCells:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnHeaderUIElements", Selector = "accessibilityColumnHeaderUIElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilityColumnHeaderUIElements", SetterSelector = "setAccessibilityColumnHeaderUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRowIndexRange", Selector = "accessibilityRowIndexRange", PropertyType = typeof (NSRange), GetterSelector = "accessibilityRowIndexRange", SetterSelector = "setAccessibilityRowIndexRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityColumnIndexRange", Selector = "accessibilityColumnIndexRange", PropertyType = typeof (NSRange), GetterSelector = "accessibilityColumnIndexRange", SetterSelector = "setAccessibilityColumnIndexRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityInsertionPointLineNumber", Selector = "accessibilityInsertionPointLineNumber", PropertyType = typeof (IntPtr), GetterSelector = "accessibilityInsertionPointLineNumber", SetterSelector = "setAccessibilityInsertionPointLineNumber:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySharedCharacterRange", Selector = "accessibilitySharedCharacterRange", PropertyType = typeof (NSRange), GetterSelector = "accessibilitySharedCharacterRange", SetterSelector = "setAccessibilitySharedCharacterRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySharedTextUIElements", Selector = "accessibilitySharedTextUIElements", PropertyType = typeof (NSObject[]), GetterSelector = "accessibilitySharedTextUIElements", SetterSelector = "setAccessibilitySharedTextUIElements:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityVisibleCharacterRange", Selector = "accessibilityVisibleCharacterRange", PropertyType = typeof (NSRange), GetterSelector = "accessibilityVisibleCharacterRange", SetterSelector = "setAccessibilityVisibleCharacterRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityNumberOfCharacters", Selector = "accessibilityNumberOfCharacters", PropertyType = typeof (IntPtr), GetterSelector = "accessibilityNumberOfCharacters", SetterSelector = "setAccessibilityNumberOfCharacters:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedText", Selector = "accessibilitySelectedText", PropertyType = typeof (string), GetterSelector = "accessibilitySelectedText", SetterSelector = "setAccessibilitySelectedText:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedTextRange", Selector = "accessibilitySelectedTextRange", PropertyType = typeof (NSRange), GetterSelector = "accessibilitySelectedTextRange", SetterSelector = "setAccessibilitySelectedTextRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilitySelectedTextRanges", Selector = "accessibilitySelectedTextRanges", PropertyType = typeof (NSValue[]), GetterSelector = "accessibilitySelectedTextRanges", SetterSelector = "setAccessibilitySelectedTextRanges:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityToolbarButton", Selector = "accessibilityToolbarButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityToolbarButton", SetterSelector = "setAccessibilityToolbarButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityModal", Selector = "accessibilityModal", PropertyType = typeof (bool), GetterSelector = "isAccessibilityModal", SetterSelector = "setAccessibilityModal:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityProxy", Selector = "accessibilityProxy", PropertyType = typeof (NSObject), GetterSelector = "accessibilityProxy", SetterSelector = "setAccessibilityProxy:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMain", Selector = "accessibilityMain", PropertyType = typeof (bool), GetterSelector = "isAccessibilityMain", SetterSelector = "setAccessibilityMain:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityFullScreenButton", Selector = "accessibilityFullScreenButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityFullScreenButton", SetterSelector = "setAccessibilityFullScreenButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityGrowArea", Selector = "accessibilityGrowArea", PropertyType = typeof (NSObject), GetterSelector = "accessibilityGrowArea", SetterSelector = "setAccessibilityGrowArea:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDocument", Selector = "accessibilityDocument", PropertyType = typeof (string), GetterSelector = "accessibilityDocument", SetterSelector = "setAccessibilityDocument:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityDefaultButton", Selector = "accessibilityDefaultButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityDefaultButton", SetterSelector = "setAccessibilityDefaultButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityCloseButton", Selector = "accessibilityCloseButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityCloseButton", SetterSelector = "setAccessibilityCloseButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityZoomButton", Selector = "accessibilityZoomButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityZoomButton", SetterSelector = "setAccessibilityZoomButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMinimizeButton", Selector = "accessibilityMinimizeButton", PropertyType = typeof (NSObject), GetterSelector = "accessibilityMinimizeButton", SetterSelector = "setAccessibilityMinimizeButton:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMinimized", Selector = "accessibilityMinimized", PropertyType = typeof (bool), GetterSelector = "isAccessibilityMinimized", SetterSelector = "setAccessibilityMinimized:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityRequired", Selector = "accessibilityRequired", PropertyType = typeof (bool), GetterSelector = "isAccessibilityRequired", SetterSelector = "setAccessibilityRequired:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityChildrenInNavigationOrder", Selector = "accessibilityChildrenInNavigationOrder", PropertyType = typeof (NSAccessibilityElement[]), GetterSelector = "accessibilityChildrenInNavigationOrder", SetterSelector = "setAccessibilityChildrenInNavigationOrder:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityCustomRotors", Selector = "accessibilityCustomRotors", PropertyType = typeof (NSAccessibilityCustomRotor[]), GetterSelector = "accessibilityCustomRotors", SetterSelector = "setAccessibilityCustomRotors:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityCustomActions", Selector = "accessibilityCustomActions", PropertyType = typeof (NSAccessibilityCustomAction[]), GetterSelector = "accessibilityCustomActions", SetterSelector = "setAccessibilityCustomActions:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityUserInputLabels", Selector = "accessibilityUserInputLabels", PropertyType = typeof (String[]), GetterSelector = "accessibilityUserInputLabels", SetterSelector = "setAccessibilityUserInputLabels:", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccessibilityAttributedUserInputLabels", Selector = "accessibilityAttributedUserInputLabels", PropertyType = typeof (NSAttributedString[]), GetterSelector = "accessibilityAttributedUserInputLabels", SetterSelector = "setAccessibilityAttributedUserInputLabels:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface INSAccessibility : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("accessibilityLayoutPointForScreenPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetAccessibilityLayoutForScreen (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetAccessibilityLayoutForScreen (INSAccessibility This, CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("accessibilityLayoutPointForScreenPoint:"), point);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityLayoutSizeForScreenSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetAccessibilityLayoutForScreen (CGSize size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetAccessibilityLayoutForScreen (INSAccessibility This, CGSize size)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("accessibilityLayoutSizeForScreenSize:"), size);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityScreenPointForLayoutPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetAccessibilityScreenForLayout (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetAccessibilityScreenForLayout (INSAccessibility This, CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("accessibilityScreenPointForLayoutPoint:"), point);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityScreenSizeForLayoutSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetAccessibilityScreenForLayout (CGSize size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetAccessibilityScreenForLayout (INSAccessibility This, CGSize size)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("accessibilityScreenSizeForLayoutSize:"), size);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityCellForColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetAccessibilityCellForColumn (nint column, nint row)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetAccessibilityCellForColumn (INSAccessibility This, nint column, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("accessibilityCellForColumn:row:"), column, row), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityAttributedStringForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetAccessibilityAttributedString (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString? _GetAccessibilityAttributedString (INSAccessibility This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("accessibilityAttributedStringForRange:"), range), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityRangeForLine:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRangeForLine (nint line)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityRangeForLine (INSAccessibility This, nint line)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityRangeForLine:"), line);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityStringForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityString (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetAccessibilityString (INSAccessibility This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("accessibilityStringForRange:"), range), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityRangeForPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRange (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityRange (INSAccessibility This, CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("accessibilityRangeForPosition:"), point);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityRangeForIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRange (nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityRange (INSAccessibility This, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityRangeForIndex:"), index);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityFrameForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAccessibilityFrame (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetAccessibilityFrame (INSAccessibility This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("accessibilityFrameForRange:"), range);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange (This.Handle, Selector.GetHandle ("accessibilityFrameForRange:"), range);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityRTFForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetAccessibilityRtf (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData? _GetAccessibilityRtf (INSAccessibility This, NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("accessibilityRTFForRange:"), range), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityStyleRangeForIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityStyleRange (nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityStyleRange (INSAccessibility This, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityStyleRangeForIndex:"), index);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityLineForIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetAccessibilityLine (nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityLine (INSAccessibility This, nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityLineForIndex:"), index);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformCancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformCancel ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformCancel (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformCancel"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformConfirm")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformConfirm ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformConfirm (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformConfirm"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformDecrement")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformDecrement ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformDecrement (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformDecrement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformDelete")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformDelete ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformDelete (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformDelete"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformIncrement")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformIncrement ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformIncrement (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformIncrement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformPick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformPick ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformPick (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformPick"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformPress")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformPress ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformPress (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformPress"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformRaise")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformRaise ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformRaise (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformRaise"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformShowAlternateUI")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformShowAlternateUI ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformShowAlternateUI (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformShowAlternateUI"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformShowDefaultUI")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformShowDefaultUI ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformShowDefaultUI (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformShowDefaultUI"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPerformShowMenu")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityPerformShowMenu ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AccessibilityPerformShowMenu (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPerformShowMenu"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("isAccessibilitySelectorAllowed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAccessibilitySelectorAllowed (Selector selector)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsAccessibilitySelectorAllowed (INSAccessibility This, Selector selector)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isAccessibilitySelectorAllowed:"), selector.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (selector);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("AccessibilityActivationPoint")]
		[DynamicDependencyAttribute ("AccessibilityAllowedValues")]
		[DynamicDependencyAttribute ("AccessibilityAlternateUIVisible")]
		[DynamicDependencyAttribute ("AccessibilityApplicationFocusedUIElement")]
		[DynamicDependencyAttribute ("AccessibilityAttributedUserInputLabels")]
		[DynamicDependencyAttribute ("AccessibilityCancelButton")]
		[DynamicDependencyAttribute ("AccessibilityChildren")]
		[DynamicDependencyAttribute ("AccessibilityChildrenInNavigationOrder")]
		[DynamicDependencyAttribute ("AccessibilityClearButton")]
		[DynamicDependencyAttribute ("AccessibilityCloseButton")]
		[DynamicDependencyAttribute ("AccessibilityColumnCount")]
		[DynamicDependencyAttribute ("AccessibilityColumnHeaderUIElements")]
		[DynamicDependencyAttribute ("AccessibilityColumnIndexRange")]
		[DynamicDependencyAttribute ("AccessibilityColumns")]
		[DynamicDependencyAttribute ("AccessibilityColumnTitles")]
		[DynamicDependencyAttribute ("AccessibilityContents")]
		[DynamicDependencyAttribute ("AccessibilityCriticalValue")]
		[DynamicDependencyAttribute ("AccessibilityCustomActions")]
		[DynamicDependencyAttribute ("AccessibilityCustomRotors")]
		[DynamicDependencyAttribute ("AccessibilityDecrementButton")]
		[DynamicDependencyAttribute ("AccessibilityDefaultButton")]
		[DynamicDependencyAttribute ("AccessibilityDisclosed")]
		[DynamicDependencyAttribute ("AccessibilityDisclosedByRow")]
		[DynamicDependencyAttribute ("AccessibilityDisclosedRows")]
		[DynamicDependencyAttribute ("AccessibilityDisclosureLevel")]
		[DynamicDependencyAttribute ("AccessibilityDocument")]
		[DynamicDependencyAttribute ("AccessibilityEdited")]
		[DynamicDependencyAttribute ("AccessibilityElement")]
		[DynamicDependencyAttribute ("AccessibilityEnabled")]
		[DynamicDependencyAttribute ("AccessibilityExpanded")]
		[DynamicDependencyAttribute ("AccessibilityExtrasMenuBar")]
		[DynamicDependencyAttribute ("AccessibilityFilename")]
		[DynamicDependencyAttribute ("AccessibilityFocused")]
		[DynamicDependencyAttribute ("AccessibilityFocusedWindow")]
		[DynamicDependencyAttribute ("AccessibilityFrame")]
		[DynamicDependencyAttribute ("AccessibilityFrontmost")]
		[DynamicDependencyAttribute ("AccessibilityFullScreenButton")]
		[DynamicDependencyAttribute ("AccessibilityGrowArea")]
		[DynamicDependencyAttribute ("AccessibilityHandles")]
		[DynamicDependencyAttribute ("AccessibilityHeader")]
		[DynamicDependencyAttribute ("AccessibilityHelp")]
		[DynamicDependencyAttribute ("AccessibilityHidden")]
		[DynamicDependencyAttribute ("AccessibilityHorizontalScrollBar")]
		[DynamicDependencyAttribute ("AccessibilityHorizontalUnitDescription")]
		[DynamicDependencyAttribute ("AccessibilityHorizontalUnits")]
		[DynamicDependencyAttribute ("AccessibilityIdentifier")]
		[DynamicDependencyAttribute ("AccessibilityIncrementButton")]
		[DynamicDependencyAttribute ("AccessibilityIndex")]
		[DynamicDependencyAttribute ("AccessibilityInsertionPointLineNumber")]
		[DynamicDependencyAttribute ("AccessibilityLabel")]
		[DynamicDependencyAttribute ("AccessibilityLabelUIElements")]
		[DynamicDependencyAttribute ("AccessibilityLabelValue")]
		[DynamicDependencyAttribute ("AccessibilityLinkedUIElements")]
		[DynamicDependencyAttribute ("AccessibilityMain")]
		[DynamicDependencyAttribute ("AccessibilityMainWindow")]
		[DynamicDependencyAttribute ("AccessibilityMarkerGroupUIElement")]
		[DynamicDependencyAttribute ("AccessibilityMarkerTypeDescription")]
		[DynamicDependencyAttribute ("AccessibilityMarkerUIElements")]
		[DynamicDependencyAttribute ("AccessibilityMarkerValues")]
		[DynamicDependencyAttribute ("AccessibilityMaxValue")]
		[DynamicDependencyAttribute ("AccessibilityMenuBar")]
		[DynamicDependencyAttribute ("AccessibilityMinimizeButton")]
		[DynamicDependencyAttribute ("AccessibilityMinimized")]
		[DynamicDependencyAttribute ("AccessibilityMinValue")]
		[DynamicDependencyAttribute ("AccessibilityModal")]
		[DynamicDependencyAttribute ("AccessibilityNextContents")]
		[DynamicDependencyAttribute ("AccessibilityNumberOfCharacters")]
		[DynamicDependencyAttribute ("AccessibilityOrderedByRow")]
		[DynamicDependencyAttribute ("AccessibilityOrientation")]
		[DynamicDependencyAttribute ("AccessibilityOverflowButton")]
		[DynamicDependencyAttribute ("AccessibilityParent")]
		[DynamicDependencyAttribute ("AccessibilityPerformCancel()")]
		[DynamicDependencyAttribute ("AccessibilityPerformConfirm()")]
		[DynamicDependencyAttribute ("AccessibilityPerformDecrement()")]
		[DynamicDependencyAttribute ("AccessibilityPerformDelete()")]
		[DynamicDependencyAttribute ("AccessibilityPerformIncrement()")]
		[DynamicDependencyAttribute ("AccessibilityPerformPick()")]
		[DynamicDependencyAttribute ("AccessibilityPerformPress()")]
		[DynamicDependencyAttribute ("AccessibilityPerformRaise()")]
		[DynamicDependencyAttribute ("AccessibilityPerformShowAlternateUI()")]
		[DynamicDependencyAttribute ("AccessibilityPerformShowDefaultUI()")]
		[DynamicDependencyAttribute ("AccessibilityPerformShowMenu()")]
		[DynamicDependencyAttribute ("AccessibilityPlaceholderValue")]
		[DynamicDependencyAttribute ("AccessibilityPreviousContents")]
		[DynamicDependencyAttribute ("AccessibilityProtectedContent")]
		[DynamicDependencyAttribute ("AccessibilityProxy")]
		[DynamicDependencyAttribute ("AccessibilityRequired")]
		[DynamicDependencyAttribute ("AccessibilityRole")]
		[DynamicDependencyAttribute ("AccessibilityRoleDescription")]
		[DynamicDependencyAttribute ("AccessibilityRowCount")]
		[DynamicDependencyAttribute ("AccessibilityRowHeaderUIElements")]
		[DynamicDependencyAttribute ("AccessibilityRowIndexRange")]
		[DynamicDependencyAttribute ("AccessibilityRows")]
		[DynamicDependencyAttribute ("AccessibilityRulerMarkerType")]
		[DynamicDependencyAttribute ("AccessibilitySearchButton")]
		[DynamicDependencyAttribute ("AccessibilitySearchMenu")]
		[DynamicDependencyAttribute ("AccessibilitySelected")]
		[DynamicDependencyAttribute ("AccessibilitySelectedCells")]
		[DynamicDependencyAttribute ("AccessibilitySelectedChildren")]
		[DynamicDependencyAttribute ("AccessibilitySelectedColumns")]
		[DynamicDependencyAttribute ("AccessibilitySelectedRows")]
		[DynamicDependencyAttribute ("AccessibilitySelectedText")]
		[DynamicDependencyAttribute ("AccessibilitySelectedTextRange")]
		[DynamicDependencyAttribute ("AccessibilitySelectedTextRanges")]
		[DynamicDependencyAttribute ("AccessibilityServesAsTitleForUIElements")]
		[DynamicDependencyAttribute ("AccessibilitySharedCharacterRange")]
		[DynamicDependencyAttribute ("AccessibilitySharedFocusElements")]
		[DynamicDependencyAttribute ("AccessibilitySharedTextUIElements")]
		[DynamicDependencyAttribute ("AccessibilityShownMenu")]
		[DynamicDependencyAttribute ("AccessibilitySortDirection")]
		[DynamicDependencyAttribute ("AccessibilitySplitters")]
		[DynamicDependencyAttribute ("AccessibilitySubrole")]
		[DynamicDependencyAttribute ("AccessibilityTabs")]
		[DynamicDependencyAttribute ("AccessibilityTitle")]
		[DynamicDependencyAttribute ("AccessibilityTitleUIElement")]
		[DynamicDependencyAttribute ("AccessibilityToolbarButton")]
		[DynamicDependencyAttribute ("AccessibilityTopLevelUIElement")]
		[DynamicDependencyAttribute ("AccessibilityUnitDescription")]
		[DynamicDependencyAttribute ("AccessibilityUnits")]
		[DynamicDependencyAttribute ("AccessibilityUrl")]
		[DynamicDependencyAttribute ("AccessibilityUserInputLabels")]
		[DynamicDependencyAttribute ("AccessibilityValue")]
		[DynamicDependencyAttribute ("AccessibilityValueDescription")]
		[DynamicDependencyAttribute ("AccessibilityVerticalScrollBar")]
		[DynamicDependencyAttribute ("AccessibilityVerticalUnitDescription")]
		[DynamicDependencyAttribute ("AccessibilityVerticalUnits")]
		[DynamicDependencyAttribute ("AccessibilityVisibleCells")]
		[DynamicDependencyAttribute ("AccessibilityVisibleCharacterRange")]
		[DynamicDependencyAttribute ("AccessibilityVisibleChildren")]
		[DynamicDependencyAttribute ("AccessibilityVisibleColumns")]
		[DynamicDependencyAttribute ("AccessibilityVisibleRows")]
		[DynamicDependencyAttribute ("AccessibilityWarningValue")]
		[DynamicDependencyAttribute ("AccessibilityWindow")]
		[DynamicDependencyAttribute ("AccessibilityWindows")]
		[DynamicDependencyAttribute ("AccessibilityZoomButton")]
		[DynamicDependencyAttribute ("GetAccessibilityAttributedString(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GetAccessibilityCellForColumn(System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityFrame(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GetAccessibilityLayoutForScreen(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetAccessibilityLayoutForScreen(CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute ("GetAccessibilityLine(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityRange(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetAccessibilityRange(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityRangeForLine(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityRtf(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GetAccessibilityScreenForLayout(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetAccessibilityScreenForLayout(CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute ("GetAccessibilityString(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GetAccessibilityStyleRange(System.IntPtr)")]
		[DynamicDependencyAttribute ("IsAccessibilitySelectorAllowed(ObjCRuntime.Selector)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSAccessibility ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGRect AccessibilityFrame {
			[Export ("accessibilityFrame", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityFrame (this);
			}
			[Export ("setAccessibilityFrame:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityFrame (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetAccessibilityFrame (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityFrame"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("accessibilityFrame"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityFrame (INSAccessibility This, CGRect value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("setAccessibilityFrame:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityIdentifier {
			[Export ("accessibilityIdentifier")]
			get {
				return _GetAccessibilityIdentifier (this);
			}
			[Export ("setAccessibilityIdentifier:")]
			set {
				_SetAccessibilityIdentifier (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityIdentifier (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityIdentifier (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityIdentifier:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityParent {
			[Export ("accessibilityParent", ArgumentSemantic.Weak)]
			get {
				return _GetAccessibilityParent (this);
			}
			[Export ("setAccessibilityParent:", ArgumentSemantic.Weak)]
			set {
				_SetAccessibilityParent (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityParent (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityParent")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityParent (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityParent:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityFocused {
			[Export ("isAccessibilityFocused")]
			get {
				return _GetAccessibilityFocused (this);
			}
			[Export ("setAccessibilityFocused:")]
			set {
				_SetAccessibilityFocused (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityFocused (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityFocused"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityFocused (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityFocused:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityElement {
			[Export ("isAccessibilityElement")]
			get {
				return _GetAccessibilityElement (this);
			}
			[Export ("setAccessibilityElement:")]
			set {
				_SetAccessibilityElement (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityElement (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityElement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityElement (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityElement:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual CGPoint AccessibilityActivationPoint {
			[Export ("accessibilityActivationPoint", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityActivationPoint (this);
			}
			[Export ("setAccessibilityActivationPoint:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityActivationPoint (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGPoint _GetAccessibilityActivationPoint (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityActivationPoint"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityActivationPoint (INSAccessibility This, CGPoint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("setAccessibilityActivationPoint:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityTopLevelUIElement {
			[Export ("accessibilityTopLevelUIElement", ArgumentSemantic.Weak)]
			get {
				return _GetAccessibilityTopLevelUIElement (this);
			}
			[Export ("setAccessibilityTopLevelUIElement:", ArgumentSemantic.Weak)]
			set {
				_SetAccessibilityTopLevelUIElement (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityTopLevelUIElement (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityTopLevelUIElement")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityTopLevelUIElement (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityTopLevelUIElement:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSUrl? AccessibilityUrl {
			[Export ("accessibilityURL", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityUrl (this);
			}
			[Export ("setAccessibilityURL:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityUrl (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrl _GetAccessibilityUrl (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSUrl ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityURL")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityUrl (INSAccessibility This, NSUrl? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityURL:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityValue {
			[Export ("accessibilityValue", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityValue (this);
			}
			[Export ("setAccessibilityValue:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityValue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityValue (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityValue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityValue (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityValue:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityValueDescription {
			[Export ("accessibilityValueDescription")]
			get {
				return _GetAccessibilityValueDescription (this);
			}
			[Export ("setAccessibilityValueDescription:")]
			set {
				_SetAccessibilityValueDescription (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityValueDescription (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityValueDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityValueDescription (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityValueDescription:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityVisibleChildren {
			[Export ("accessibilityVisibleChildren", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityVisibleChildren (this);
			}
			[Export ("setAccessibilityVisibleChildren:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityVisibleChildren (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityVisibleChildren (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleChildren")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityVisibleChildren (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityVisibleChildren:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilitySubrole {
			[Export ("accessibilitySubrole")]
			get {
				return _GetAccessibilitySubrole (this);
			}
			[Export ("setAccessibilitySubrole:")]
			set {
				_SetAccessibilitySubrole (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilitySubrole (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySubrole")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySubrole (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySubrole:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityTitle {
			[Export ("accessibilityTitle")]
			get {
				return _GetAccessibilityTitle (this);
			}
			[Export ("setAccessibilityTitle:")]
			set {
				_SetAccessibilityTitle (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityTitle (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityTitle")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityTitle (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityTitle:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityTitleUIElement {
			[Export ("accessibilityTitleUIElement", ArgumentSemantic.Weak)]
			get {
				return _GetAccessibilityTitleUIElement (this);
			}
			[Export ("setAccessibilityTitleUIElement:", ArgumentSemantic.Weak)]
			set {
				_SetAccessibilityTitleUIElement (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityTitleUIElement (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityTitleUIElement")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityTitleUIElement (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityTitleUIElement:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityNextContents {
			[Export ("accessibilityNextContents", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityNextContents (this);
			}
			[Export ("setAccessibilityNextContents:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityNextContents (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityNextContents (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityNextContents")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityNextContents (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityNextContents:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAccessibilityOrientation AccessibilityOrientation {
			[Export ("accessibilityOrientation", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityOrientation (this);
			}
			[Export ("setAccessibilityOrientation:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityOrientation (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilityOrientation _GetAccessibilityOrientation (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAccessibilityOrientation ret;
			ret = (NSAccessibilityOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityOrientation"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityOrientation (INSAccessibility This, NSAccessibilityOrientation value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityOrientation:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityOverflowButton {
			[Export ("accessibilityOverflowButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityOverflowButton (this);
			}
			[Export ("setAccessibilityOverflowButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityOverflowButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityOverflowButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityOverflowButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityOverflowButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityOverflowButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityPlaceholderValue {
			[Export ("accessibilityPlaceholderValue")]
			get {
				return _GetAccessibilityPlaceholderValue (this);
			}
			[Export ("setAccessibilityPlaceholderValue:")]
			set {
				_SetAccessibilityPlaceholderValue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityPlaceholderValue (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPlaceholderValue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityPlaceholderValue (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityPlaceholderValue:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityPreviousContents {
			[Export ("accessibilityPreviousContents", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityPreviousContents (this);
			}
			[Export ("setAccessibilityPreviousContents:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityPreviousContents (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityPreviousContents (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityPreviousContents")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityPreviousContents (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityPreviousContents:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityRole {
			[Export ("accessibilityRole")]
			get {
				return _GetAccessibilityRole (this);
			}
			[Export ("setAccessibilityRole:")]
			set {
				_SetAccessibilityRole (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityRole (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRole")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityRole (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityRole:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityRoleDescription {
			[Export ("accessibilityRoleDescription")]
			get {
				return _GetAccessibilityRoleDescription (this);
			}
			[Export ("setAccessibilityRoleDescription:")]
			set {
				_SetAccessibilityRoleDescription (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityRoleDescription (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRoleDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityRoleDescription (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityRoleDescription:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilitySearchButton {
			[Export ("accessibilitySearchButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilitySearchButton (this);
			}
			[Export ("setAccessibilitySearchButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilitySearchButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilitySearchButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySearchButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySearchButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySearchButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilitySearchMenu {
			[Export ("accessibilitySearchMenu", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilitySearchMenu (this);
			}
			[Export ("setAccessibilitySearchMenu:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilitySearchMenu (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilitySearchMenu (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySearchMenu")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySearchMenu (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySearchMenu:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilitySelected {
			[Export ("isAccessibilitySelected")]
			get {
				return _GetAccessibilitySelected (this);
			}
			[Export ("setAccessibilitySelected:")]
			set {
				_SetAccessibilitySelected (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilitySelected (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilitySelected"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySelected (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilitySelected:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilitySelectedChildren {
			[Export ("accessibilitySelectedChildren", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilitySelectedChildren (this);
			}
			[Export ("setAccessibilitySelectedChildren:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilitySelectedChildren (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySelectedChildren (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedChildren")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySelectedChildren (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySelectedChildren:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityServesAsTitleForUIElements {
			[Export ("accessibilityServesAsTitleForUIElements", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityServesAsTitleForUIElements (this);
			}
			[Export ("setAccessibilityServesAsTitleForUIElements:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityServesAsTitleForUIElements (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityServesAsTitleForUIElements (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityServesAsTitleForUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityServesAsTitleForUIElements (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityServesAsTitleForUIElements:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityShownMenu {
			[Export ("accessibilityShownMenu", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityShownMenu (this);
			}
			[Export ("setAccessibilityShownMenu:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityShownMenu (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityShownMenu (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityShownMenu")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityShownMenu (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityShownMenu:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityMinValue {
			[Export ("accessibilityMinValue", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityMinValue (this);
			}
			[Export ("setAccessibilityMinValue:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityMinValue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityMinValue (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMinValue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMinValue (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityMinValue:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityMaxValue {
			[Export ("accessibilityMaxValue", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityMaxValue (this);
			}
			[Export ("setAccessibilityMaxValue:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityMaxValue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityMaxValue (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMaxValue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMaxValue (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityMaxValue:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityLinkedUIElements {
			[Export ("accessibilityLinkedUIElements", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityLinkedUIElements (this);
			}
			[Export ("setAccessibilityLinkedUIElements:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityLinkedUIElements (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityLinkedUIElements (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityLinkedUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityLinkedUIElements (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityLinkedUIElements:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityWindow {
			[Export ("accessibilityWindow", ArgumentSemantic.Weak)]
			get {
				return _GetAccessibilityWindow (this);
			}
			[Export ("setAccessibilityWindow:", ArgumentSemantic.Weak)]
			set {
				_SetAccessibilityWindow (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityWindow (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityWindow")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityWindow (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityWindow:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityHelp {
			[Export ("accessibilityHelp")]
			get {
				return _GetAccessibilityHelp (this);
			}
			[Export ("setAccessibilityHelp:")]
			set {
				_SetAccessibilityHelp (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityHelp (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityHelp")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityHelp (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityHelp:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityFilename {
			[Export ("accessibilityFilename")]
			get {
				return _GetAccessibilityFilename (this);
			}
			[Export ("setAccessibilityFilename:")]
			set {
				_SetAccessibilityFilename (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityFilename (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityFilename")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityFilename (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityFilename:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityExpanded {
			[Export ("isAccessibilityExpanded")]
			get {
				return _GetAccessibilityExpanded (this);
			}
			[Export ("setAccessibilityExpanded:")]
			set {
				_SetAccessibilityExpanded (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityExpanded (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityExpanded"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityExpanded (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityExpanded:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityEdited {
			[Export ("isAccessibilityEdited")]
			get {
				return _GetAccessibilityEdited (this);
			}
			[Export ("setAccessibilityEdited:")]
			set {
				_SetAccessibilityEdited (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityEdited (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityEdited"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityEdited (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityEdited:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityEnabled {
			[Export ("isAccessibilityEnabled")]
			get {
				return _GetAccessibilityEnabled (this);
			}
			[Export ("setAccessibilityEnabled:")]
			set {
				_SetAccessibilityEnabled (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityEnabled (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityEnabled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityEnabled (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityEnabled:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityChildren {
			[Export ("accessibilityChildren", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityChildren (this);
			}
			[Export ("setAccessibilityChildren:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityChildren (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityChildren (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityChildren")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityChildren (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityChildren:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityClearButton {
			[Export ("accessibilityClearButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityClearButton (this);
			}
			[Export ("setAccessibilityClearButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityClearButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityClearButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityClearButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityClearButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityClearButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityCancelButton {
			[Export ("accessibilityCancelButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityCancelButton (this);
			}
			[Export ("setAccessibilityCancelButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityCancelButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityCancelButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityCancelButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityCancelButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityCancelButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityProtectedContent {
			[Export ("isAccessibilityProtectedContent")]
			get {
				return _GetAccessibilityProtectedContent (this);
			}
			[Export ("setAccessibilityProtectedContent:")]
			set {
				_SetAccessibilityProtectedContent (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityProtectedContent (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityProtectedContent"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityProtectedContent (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityProtectedContent:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityContents {
			[Export ("accessibilityContents", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityContents (this);
			}
			[Export ("setAccessibilityContents:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityContents (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityContents (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityContents")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityContents (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityContents:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityLabel {
			[Export ("accessibilityLabel")]
			get {
				return _GetAccessibilityLabel (this);
			}
			[Export ("setAccessibilityLabel:")]
			set {
				_SetAccessibilityLabel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityLabel (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityLabel")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityLabel (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityLabel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityAlternateUIVisible {
			[Export ("isAccessibilityAlternateUIVisible")]
			get {
				return _GetAccessibilityAlternateUIVisible (this);
			}
			[Export ("setAccessibilityAlternateUIVisible:")]
			set {
				_SetAccessibilityAlternateUIVisible (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityAlternateUIVisible (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityAlternateUIVisible"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityAlternateUIVisible (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityAlternateUIVisible:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilitySharedFocusElements {
			[Export ("accessibilitySharedFocusElements", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilitySharedFocusElements (this);
			}
			[Export ("setAccessibilitySharedFocusElements:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilitySharedFocusElements (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySharedFocusElements (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySharedFocusElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySharedFocusElements (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySharedFocusElements:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityApplicationFocusedUIElement {
			[Export ("accessibilityApplicationFocusedUIElement", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityApplicationFocusedUIElement (this);
			}
			[Export ("setAccessibilityApplicationFocusedUIElement:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityApplicationFocusedUIElement (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityApplicationFocusedUIElement (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityApplicationFocusedUIElement")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityApplicationFocusedUIElement (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityApplicationFocusedUIElement:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityMainWindow {
			[Export ("accessibilityMainWindow", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityMainWindow (this);
			}
			[Export ("setAccessibilityMainWindow:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityMainWindow (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityMainWindow (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMainWindow")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMainWindow (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityMainWindow:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityHidden {
			[Export ("isAccessibilityHidden")]
			get {
				return _GetAccessibilityHidden (this);
			}
			[Export ("setAccessibilityHidden:")]
			set {
				_SetAccessibilityHidden (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityHidden (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityHidden"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityHidden (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityHidden:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityFrontmost {
			[Export ("isAccessibilityFrontmost")]
			get {
				return _GetAccessibilityFrontmost (this);
			}
			[Export ("setAccessibilityFrontmost:")]
			set {
				_SetAccessibilityFrontmost (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityFrontmost (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityFrontmost"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityFrontmost (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityFrontmost:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityFocusedWindow {
			[Export ("accessibilityFocusedWindow", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityFocusedWindow (this);
			}
			[Export ("setAccessibilityFocusedWindow:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityFocusedWindow (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityFocusedWindow (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityFocusedWindow")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityFocusedWindow (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityFocusedWindow:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityWindows {
			[Export ("accessibilityWindows", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityWindows (this);
			}
			[Export ("setAccessibilityWindows:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityWindows (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityWindows (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityWindows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityWindows (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityWindows:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityExtrasMenuBar {
			[Export ("accessibilityExtrasMenuBar", ArgumentSemantic.Weak)]
			get {
				return _GetAccessibilityExtrasMenuBar (this);
			}
			[Export ("setAccessibilityExtrasMenuBar:", ArgumentSemantic.Weak)]
			set {
				_SetAccessibilityExtrasMenuBar (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityExtrasMenuBar (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityExtrasMenuBar")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityExtrasMenuBar (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityExtrasMenuBar:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityMenuBar {
			[Export ("accessibilityMenuBar", ArgumentSemantic.Weak)]
			get {
				return _GetAccessibilityMenuBar (this);
			}
			[Export ("setAccessibilityMenuBar:", ArgumentSemantic.Weak)]
			set {
				_SetAccessibilityMenuBar (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityMenuBar (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMenuBar")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMenuBar (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityMenuBar:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityColumnTitles {
			[Export ("accessibilityColumnTitles", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityColumnTitles (this);
			}
			[Export ("setAccessibilityColumnTitles:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityColumnTitles (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityColumnTitles (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumnTitles")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityColumnTitles (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityColumnTitles:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityOrderedByRow {
			[Export ("isAccessibilityOrderedByRow")]
			get {
				return _GetAccessibilityOrderedByRow (this);
			}
			[Export ("setAccessibilityOrderedByRow:")]
			set {
				_SetAccessibilityOrderedByRow (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityOrderedByRow (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityOrderedByRow"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityOrderedByRow (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityOrderedByRow:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAccessibilityUnits AccessibilityHorizontalUnits {
			[Export ("accessibilityHorizontalUnits", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityHorizontalUnits (this);
			}
			[Export ("setAccessibilityHorizontalUnits:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityHorizontalUnits (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilityUnits _GetAccessibilityHorizontalUnits (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAccessibilityUnits ret;
			ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityHorizontalUnits"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityHorizontalUnits (INSAccessibility This, NSAccessibilityUnits value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityHorizontalUnits:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAccessibilityUnits AccessibilityVerticalUnits {
			[Export ("accessibilityVerticalUnits", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityVerticalUnits (this);
			}
			[Export ("setAccessibilityVerticalUnits:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityVerticalUnits (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilityUnits _GetAccessibilityVerticalUnits (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAccessibilityUnits ret;
			ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVerticalUnits"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityVerticalUnits (INSAccessibility This, NSAccessibilityUnits value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityVerticalUnits:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityHorizontalUnitDescription {
			[Export ("accessibilityHorizontalUnitDescription")]
			get {
				return _GetAccessibilityHorizontalUnitDescription (this);
			}
			[Export ("setAccessibilityHorizontalUnitDescription:")]
			set {
				_SetAccessibilityHorizontalUnitDescription (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityHorizontalUnitDescription (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityHorizontalUnitDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityHorizontalUnitDescription (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityHorizontalUnitDescription:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityVerticalUnitDescription {
			[Export ("accessibilityVerticalUnitDescription")]
			get {
				return _GetAccessibilityVerticalUnitDescription (this);
			}
			[Export ("setAccessibilityVerticalUnitDescription:")]
			set {
				_SetAccessibilityVerticalUnitDescription (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityVerticalUnitDescription (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVerticalUnitDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityVerticalUnitDescription (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityVerticalUnitDescription:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityHandles {
			[Export ("accessibilityHandles", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityHandles (this);
			}
			[Export ("setAccessibilityHandles:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityHandles (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityHandles (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityHandles")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityHandles (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityHandles:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityWarningValue {
			[Export ("accessibilityWarningValue", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityWarningValue (this);
			}
			[Export ("setAccessibilityWarningValue:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityWarningValue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityWarningValue (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityWarningValue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityWarningValue (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityWarningValue:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityCriticalValue {
			[Export ("accessibilityCriticalValue", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityCriticalValue (this);
			}
			[Export ("setAccessibilityCriticalValue:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityCriticalValue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityCriticalValue (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityCriticalValue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityCriticalValue (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityCriticalValue:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityDisclosed {
			[Export ("isAccessibilityDisclosed")]
			get {
				return _GetAccessibilityDisclosed (this);
			}
			[Export ("setAccessibilityDisclosed:")]
			set {
				_SetAccessibilityDisclosed (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityDisclosed (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityDisclosed"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityDisclosed (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityDisclosed:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityDisclosedByRow {
			[Export ("accessibilityDisclosedByRow", ArgumentSemantic.Weak)]
			get {
				return _GetAccessibilityDisclosedByRow (this);
			}
			[Export ("setAccessibilityDisclosedByRow:", ArgumentSemantic.Weak)]
			set {
				_SetAccessibilityDisclosedByRow (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityDisclosedByRow (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityDisclosedByRow")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityDisclosedByRow (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityDisclosedByRow:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityDisclosedRows {
			[Export ("accessibilityDisclosedRows", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityDisclosedRows (this);
			}
			[Export ("setAccessibilityDisclosedRows:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityDisclosedRows (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityDisclosedRows (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityDisclosedRows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityDisclosedRows (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityDisclosedRows:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint AccessibilityDisclosureLevel {
			[Export ("accessibilityDisclosureLevel")]
			get {
				return _GetAccessibilityDisclosureLevel (this);
			}
			[Export ("setAccessibilityDisclosureLevel:")]
			set {
				_SetAccessibilityDisclosureLevel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityDisclosureLevel (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityDisclosureLevel"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityDisclosureLevel (INSAccessibility This, nint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityDisclosureLevel:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityMarkerUIElements {
			[Export ("accessibilityMarkerUIElements", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityMarkerUIElements (this);
			}
			[Export ("setAccessibilityMarkerUIElements:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityMarkerUIElements (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityMarkerUIElements (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMarkerUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMarkerUIElements (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityMarkerUIElements:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityMarkerValues {
			[Export ("accessibilityMarkerValues", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityMarkerValues (this);
			}
			[Export ("setAccessibilityMarkerValues:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityMarkerValues (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityMarkerValues (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMarkerValues")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMarkerValues (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityMarkerValues:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityMarkerGroupUIElement {
			[Export ("accessibilityMarkerGroupUIElement", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityMarkerGroupUIElement (this);
			}
			[Export ("setAccessibilityMarkerGroupUIElement:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityMarkerGroupUIElement (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityMarkerGroupUIElement (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMarkerGroupUIElement")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMarkerGroupUIElement (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityMarkerGroupUIElement:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAccessibilityUnits AccessibilityUnits {
			[Export ("accessibilityUnits", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityUnits (this);
			}
			[Export ("setAccessibilityUnits:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityUnits (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilityUnits _GetAccessibilityUnits (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAccessibilityUnits ret;
			ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityUnits"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityUnits (INSAccessibility This, NSAccessibilityUnits value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityUnits:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityUnitDescription {
			[Export ("accessibilityUnitDescription")]
			get {
				return _GetAccessibilityUnitDescription (this);
			}
			[Export ("setAccessibilityUnitDescription:")]
			set {
				_SetAccessibilityUnitDescription (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityUnitDescription (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityUnitDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityUnitDescription (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityUnitDescription:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAccessibilityRulerMarkerType AccessibilityRulerMarkerType {
			[Export ("accessibilityRulerMarkerType", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityRulerMarkerType (this);
			}
			[Export ("setAccessibilityRulerMarkerType:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityRulerMarkerType (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilityRulerMarkerType _GetAccessibilityRulerMarkerType (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAccessibilityRulerMarkerType ret;
			ret = (NSAccessibilityRulerMarkerType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRulerMarkerType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityRulerMarkerType (INSAccessibility This, NSAccessibilityRulerMarkerType value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityRulerMarkerType:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityMarkerTypeDescription {
			[Export ("accessibilityMarkerTypeDescription")]
			get {
				return _GetAccessibilityMarkerTypeDescription (this);
			}
			[Export ("setAccessibilityMarkerTypeDescription:")]
			set {
				_SetAccessibilityMarkerTypeDescription (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityMarkerTypeDescription (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMarkerTypeDescription")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMarkerTypeDescription (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityMarkerTypeDescription:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityHorizontalScrollBar {
			[Export ("accessibilityHorizontalScrollBar", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityHorizontalScrollBar (this);
			}
			[Export ("setAccessibilityHorizontalScrollBar:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityHorizontalScrollBar (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityHorizontalScrollBar (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityHorizontalScrollBar")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityHorizontalScrollBar (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityHorizontalScrollBar:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityVerticalScrollBar {
			[Export ("accessibilityVerticalScrollBar", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityVerticalScrollBar (this);
			}
			[Export ("setAccessibilityVerticalScrollBar:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityVerticalScrollBar (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityVerticalScrollBar (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVerticalScrollBar")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityVerticalScrollBar (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityVerticalScrollBar:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSNumber[]? AccessibilityAllowedValues {
			[Export ("accessibilityAllowedValues", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityAllowedValues (this);
			}
			[Export ("setAccessibilityAllowedValues:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityAllowedValues (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber[] _GetAccessibilityAllowedValues (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityAllowedValues")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityAllowedValues (INSAccessibility This, NSNumber[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityAllowedValues:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityLabelUIElements {
			[Export ("accessibilityLabelUIElements", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityLabelUIElements (this);
			}
			[Export ("setAccessibilityLabelUIElements:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityLabelUIElements (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityLabelUIElements (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityLabelUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityLabelUIElements (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityLabelUIElements:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float AccessibilityLabelValue {
			[Export ("accessibilityLabelValue")]
			get {
				return _GetAccessibilityLabelValue (this);
			}
			[Export ("setAccessibilityLabelValue:")]
			set {
				_SetAccessibilityLabelValue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetAccessibilityLabelValue (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityLabelValue"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityLabelValue (INSAccessibility This, float value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setAccessibilityLabelValue:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilitySplitters {
			[Export ("accessibilitySplitters", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilitySplitters (this);
			}
			[Export ("setAccessibilitySplitters:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilitySplitters (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySplitters (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySplitters")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySplitters (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySplitters:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityDecrementButton {
			[Export ("accessibilityDecrementButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityDecrementButton (this);
			}
			[Export ("setAccessibilityDecrementButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityDecrementButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityDecrementButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityDecrementButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityDecrementButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityDecrementButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityIncrementButton {
			[Export ("accessibilityIncrementButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityIncrementButton (this);
			}
			[Export ("setAccessibilityIncrementButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityIncrementButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityIncrementButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityIncrementButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityIncrementButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityIncrementButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityTabs {
			[Export ("accessibilityTabs", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityTabs (this);
			}
			[Export ("setAccessibilityTabs:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityTabs (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityTabs (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityTabs")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityTabs (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityTabs:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityHeader {
			[Export ("accessibilityHeader", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityHeader (this);
			}
			[Export ("setAccessibilityHeader:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityHeader (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityHeader (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityHeader")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityHeader (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityHeader:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint AccessibilityColumnCount {
			[Export ("accessibilityColumnCount")]
			get {
				return _GetAccessibilityColumnCount (this);
			}
			[Export ("setAccessibilityColumnCount:")]
			set {
				_SetAccessibilityColumnCount (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityColumnCount (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumnCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityColumnCount (INSAccessibility This, nint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityColumnCount:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint AccessibilityRowCount {
			[Export ("accessibilityRowCount")]
			get {
				return _GetAccessibilityRowCount (this);
			}
			[Export ("setAccessibilityRowCount:")]
			set {
				_SetAccessibilityRowCount (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityRowCount (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRowCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityRowCount (INSAccessibility This, nint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityRowCount:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint AccessibilityIndex {
			[Export ("accessibilityIndex")]
			get {
				return _GetAccessibilityIndex (this);
			}
			[Export ("setAccessibilityIndex:")]
			set {
				_SetAccessibilityIndex (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityIndex (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityIndex"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityIndex (INSAccessibility This, nint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityIndex:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityColumns {
			[Export ("accessibilityColumns", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityColumns (this);
			}
			[Export ("setAccessibilityColumns:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityColumns (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityColumns (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumns")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityColumns (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityColumns:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityRows {
			[Export ("accessibilityRows", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityRows (this);
			}
			[Export ("setAccessibilityRows:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityRows (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityRows (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityRows (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityRows:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityVisibleRows {
			[Export ("accessibilityVisibleRows", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityVisibleRows (this);
			}
			[Export ("setAccessibilityVisibleRows:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityVisibleRows (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityVisibleRows (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleRows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityVisibleRows (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityVisibleRows:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilitySelectedRows {
			[Export ("accessibilitySelectedRows", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilitySelectedRows (this);
			}
			[Export ("setAccessibilitySelectedRows:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilitySelectedRows (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySelectedRows (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedRows")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySelectedRows (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySelectedRows:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityVisibleColumns {
			[Export ("accessibilityVisibleColumns", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityVisibleColumns (this);
			}
			[Export ("setAccessibilityVisibleColumns:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityVisibleColumns (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityVisibleColumns (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleColumns")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityVisibleColumns (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityVisibleColumns:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilitySelectedColumns {
			[Export ("accessibilitySelectedColumns", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilitySelectedColumns (this);
			}
			[Export ("setAccessibilitySelectedColumns:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilitySelectedColumns (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySelectedColumns (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedColumns")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySelectedColumns (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySelectedColumns:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAccessibilitySortDirection AccessibilitySortDirection {
			[Export ("accessibilitySortDirection", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilitySortDirection (this);
			}
			[Export ("setAccessibilitySortDirection:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilitySortDirection (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilitySortDirection _GetAccessibilitySortDirection (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAccessibilitySortDirection ret;
			ret = (NSAccessibilitySortDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySortDirection"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySortDirection (INSAccessibility This, NSAccessibilitySortDirection value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilitySortDirection:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityRowHeaderUIElements {
			[Export ("accessibilityRowHeaderUIElements", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityRowHeaderUIElements (this);
			}
			[Export ("setAccessibilityRowHeaderUIElements:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityRowHeaderUIElements (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityRowHeaderUIElements (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRowHeaderUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityRowHeaderUIElements (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityRowHeaderUIElements:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilitySelectedCells {
			[Export ("accessibilitySelectedCells", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilitySelectedCells (this);
			}
			[Export ("setAccessibilitySelectedCells:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilitySelectedCells (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySelectedCells (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedCells")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySelectedCells (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySelectedCells:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityVisibleCells {
			[Export ("accessibilityVisibleCells", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityVisibleCells (this);
			}
			[Export ("setAccessibilityVisibleCells:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityVisibleCells (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityVisibleCells (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleCells")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityVisibleCells (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityVisibleCells:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilityColumnHeaderUIElements {
			[Export ("accessibilityColumnHeaderUIElements", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityColumnHeaderUIElements (this);
			}
			[Export ("setAccessibilityColumnHeaderUIElements:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityColumnHeaderUIElements (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilityColumnHeaderUIElements (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumnHeaderUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityColumnHeaderUIElements (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityColumnHeaderUIElements:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSRange AccessibilityRowIndexRange {
			[Export ("accessibilityRowIndexRange", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityRowIndexRange (this);
			}
			[Export ("setAccessibilityRowIndexRange:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityRowIndexRange (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityRowIndexRange (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityRowIndexRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityRowIndexRange (INSAccessibility This, NSRange value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("setAccessibilityRowIndexRange:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSRange AccessibilityColumnIndexRange {
			[Export ("accessibilityColumnIndexRange", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityColumnIndexRange (this);
			}
			[Export ("setAccessibilityColumnIndexRange:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityColumnIndexRange (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityColumnIndexRange (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityColumnIndexRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityColumnIndexRange (INSAccessibility This, NSRange value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("setAccessibilityColumnIndexRange:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint AccessibilityInsertionPointLineNumber {
			[Export ("accessibilityInsertionPointLineNumber")]
			get {
				return _GetAccessibilityInsertionPointLineNumber (this);
			}
			[Export ("setAccessibilityInsertionPointLineNumber:")]
			set {
				_SetAccessibilityInsertionPointLineNumber (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityInsertionPointLineNumber (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityInsertionPointLineNumber"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityInsertionPointLineNumber (INSAccessibility This, nint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityInsertionPointLineNumber:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSRange AccessibilitySharedCharacterRange {
			[Export ("accessibilitySharedCharacterRange", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilitySharedCharacterRange (this);
			}
			[Export ("setAccessibilitySharedCharacterRange:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilitySharedCharacterRange (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilitySharedCharacterRange (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySharedCharacterRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySharedCharacterRange (INSAccessibility This, NSRange value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("setAccessibilitySharedCharacterRange:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject[]? AccessibilitySharedTextUIElements {
			[Export ("accessibilitySharedTextUIElements", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilitySharedTextUIElements (this);
			}
			[Export ("setAccessibilitySharedTextUIElements:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilitySharedTextUIElements (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject[] _GetAccessibilitySharedTextUIElements (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject[] ret;
			ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySharedTextUIElements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySharedTextUIElements (INSAccessibility This, NSObject[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySharedTextUIElements:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSRange AccessibilityVisibleCharacterRange {
			[Export ("accessibilityVisibleCharacterRange", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityVisibleCharacterRange (this);
			}
			[Export ("setAccessibilityVisibleCharacterRange:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityVisibleCharacterRange (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityVisibleCharacterRange (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityVisibleCharacterRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityVisibleCharacterRange (INSAccessibility This, NSRange value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("setAccessibilityVisibleCharacterRange:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint AccessibilityNumberOfCharacters {
			[Export ("accessibilityNumberOfCharacters")]
			get {
				return _GetAccessibilityNumberOfCharacters (this);
			}
			[Export ("setAccessibilityNumberOfCharacters:")]
			set {
				_SetAccessibilityNumberOfCharacters (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetAccessibilityNumberOfCharacters (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityNumberOfCharacters"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityNumberOfCharacters (INSAccessibility This, nint value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityNumberOfCharacters:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilitySelectedText {
			[Export ("accessibilitySelectedText")]
			get {
				return _GetAccessibilitySelectedText (this);
			}
			[Export ("setAccessibilitySelectedText:")]
			set {
				_SetAccessibilitySelectedText (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilitySelectedText (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedText")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySelectedText (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySelectedText:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSRange AccessibilitySelectedTextRange {
			[Export ("accessibilitySelectedTextRange", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilitySelectedTextRange (this);
			}
			[Export ("setAccessibilitySelectedTextRange:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilitySelectedTextRange (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilitySelectedTextRange (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedTextRange"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySelectedTextRange (INSAccessibility This, NSRange value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("setAccessibilitySelectedTextRange:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSValue[]? AccessibilitySelectedTextRanges {
			[Export ("accessibilitySelectedTextRanges", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilitySelectedTextRanges (this);
			}
			[Export ("setAccessibilitySelectedTextRanges:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilitySelectedTextRanges (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSValue[] _GetAccessibilitySelectedTextRanges (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSValue[] ret;
			ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilitySelectedTextRanges")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilitySelectedTextRanges (INSAccessibility This, NSValue[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilitySelectedTextRanges:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityToolbarButton {
			[Export ("accessibilityToolbarButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityToolbarButton (this);
			}
			[Export ("setAccessibilityToolbarButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityToolbarButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityToolbarButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityToolbarButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityToolbarButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityToolbarButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityModal {
			[Export ("isAccessibilityModal")]
			get {
				return _GetAccessibilityModal (this);
			}
			[Export ("setAccessibilityModal:")]
			set {
				_SetAccessibilityModal (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityModal (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityModal"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityModal (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityModal:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityProxy {
			[Export ("accessibilityProxy", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityProxy (this);
			}
			[Export ("setAccessibilityProxy:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityProxy (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityProxy (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityProxy")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityProxy (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityProxy:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityMain {
			[Export ("isAccessibilityMain")]
			get {
				return _GetAccessibilityMain (this);
			}
			[Export ("setAccessibilityMain:")]
			set {
				_SetAccessibilityMain (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityMain (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityMain"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMain (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityMain:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityFullScreenButton {
			[Export ("accessibilityFullScreenButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityFullScreenButton (this);
			}
			[Export ("setAccessibilityFullScreenButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityFullScreenButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityFullScreenButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityFullScreenButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityFullScreenButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityFullScreenButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityGrowArea {
			[Export ("accessibilityGrowArea", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityGrowArea (this);
			}
			[Export ("setAccessibilityGrowArea:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityGrowArea (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityGrowArea (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityGrowArea")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityGrowArea (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityGrowArea:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? AccessibilityDocument {
			[Export ("accessibilityDocument")]
			get {
				return _GetAccessibilityDocument (this);
			}
			[Export ("setAccessibilityDocument:")]
			set {
				_SetAccessibilityDocument (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAccessibilityDocument (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityDocument")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityDocument (INSAccessibility This, string? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityDocument:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityDefaultButton {
			[Export ("accessibilityDefaultButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityDefaultButton (this);
			}
			[Export ("setAccessibilityDefaultButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityDefaultButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityDefaultButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityDefaultButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityDefaultButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityDefaultButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityCloseButton {
			[Export ("accessibilityCloseButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityCloseButton (this);
			}
			[Export ("setAccessibilityCloseButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityCloseButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityCloseButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityCloseButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityCloseButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityCloseButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityZoomButton {
			[Export ("accessibilityZoomButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityZoomButton (this);
			}
			[Export ("setAccessibilityZoomButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityZoomButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityZoomButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityZoomButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityZoomButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityZoomButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? AccessibilityMinimizeButton {
			[Export ("accessibilityMinimizeButton", ArgumentSemantic.Retain)]
			get {
				return _GetAccessibilityMinimizeButton (this);
			}
			[Export ("setAccessibilityMinimizeButton:", ArgumentSemantic.Retain)]
			set {
				_SetAccessibilityMinimizeButton (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetAccessibilityMinimizeButton (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMinimizeButton")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMinimizeButton (INSAccessibility This, NSObject? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityMinimizeButton:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityMinimized {
			[Export ("isAccessibilityMinimized")]
			get {
				return _GetAccessibilityMinimized (this);
			}
			[Export ("setAccessibilityMinimized:")]
			set {
				_SetAccessibilityMinimized (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityMinimized (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityMinimized"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityMinimized (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityMinimized:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AccessibilityRequired {
			[Export ("isAccessibilityRequired")]
			get {
				return _GetAccessibilityRequired (this);
			}
			[Export ("setAccessibilityRequired:")]
			set {
				_SetAccessibilityRequired (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAccessibilityRequired (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAccessibilityRequired"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityRequired (INSAccessibility This, bool value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAccessibilityRequired:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAccessibilityElement[]? AccessibilityChildrenInNavigationOrder {
			[Export ("accessibilityChildrenInNavigationOrder", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityChildrenInNavigationOrder (this);
			}
			[Export ("setAccessibilityChildrenInNavigationOrder:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityChildrenInNavigationOrder (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilityElement[] _GetAccessibilityChildrenInNavigationOrder (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAccessibilityElement[] ret;
			ret = CFArray.ArrayFromHandle<NSAccessibilityElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityChildrenInNavigationOrder")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityChildrenInNavigationOrder (INSAccessibility This, NSAccessibilityElement[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityChildrenInNavigationOrder:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAccessibilityCustomRotor[] AccessibilityCustomRotors {
			[Export ("accessibilityCustomRotors", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityCustomRotors (this);
			}
			[Export ("setAccessibilityCustomRotors:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityCustomRotors (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilityCustomRotor[] _GetAccessibilityCustomRotors (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAccessibilityCustomRotor[] ret;
			ret = CFArray.ArrayFromHandle<NSAccessibilityCustomRotor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityCustomRotors")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityCustomRotors (INSAccessibility This, NSAccessibilityCustomRotor[] value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var nsa_value = NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityCustomRotors:"), nsa_value.Handle);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSAccessibilityCustomAction[]? AccessibilityCustomActions {
			[Export ("accessibilityCustomActions", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityCustomActions (this);
			}
			[Export ("setAccessibilityCustomActions:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityCustomActions (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAccessibilityCustomAction[] _GetAccessibilityCustomActions (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAccessibilityCustomAction[] ret;
			ret = CFArray.ArrayFromHandle<NSAccessibilityCustomAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityCustomActions")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityCustomActions (INSAccessibility This, NSAccessibilityCustomAction[]? value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityCustomActions:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual string[] AccessibilityUserInputLabels {
			[Export ("accessibilityUserInputLabels", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityUserInputLabels (this);
			}
			[Export ("setAccessibilityUserInputLabels:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityUserInputLabels (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetAccessibilityUserInputLabels (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityUserInputLabels")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityUserInputLabels (INSAccessibility This, string[] value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var nsa_value = NSArray.FromStrings (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityUserInputLabels:"), nsa_value.Handle);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual NSAttributedString[] AccessibilityAttributedUserInputLabels {
			[Export ("accessibilityAttributedUserInputLabels", ArgumentSemantic.Copy)]
			get {
				return _GetAccessibilityAttributedUserInputLabels (this);
			}
			[Export ("setAccessibilityAttributedUserInputLabels:", ArgumentSemantic.Copy)]
			set {
				_SetAccessibilityAttributedUserInputLabels (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSAttributedString[] _GetAccessibilityAttributedUserInputLabels (INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAttributedString[] ret;
			ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityAttributedUserInputLabels")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityAttributedUserInputLabels (INSAccessibility This, NSAttributedString[] value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var nsa_value = NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityAttributedUserInputLabels:"), nsa_value.Handle);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSAccessibility" /> interface to support all the methods from the NSAccessibility protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSAccessibility" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSAccessibility protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSAccessibility_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetAccessibilityUserInputLabels (this INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityUserInputLabels")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityUserInputLabels (this INSAccessibility This, string[] value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var nsa_value = NSArray.FromStrings (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityUserInputLabels:"), nsa_value.Handle);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString[] GetAccessibilityAttributedUserInputLabels (this INSAccessibility This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAttributedString[] ret;
			ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityAttributedUserInputLabels")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAccessibilityAttributedUserInputLabels (this INSAccessibility This, NSAttributedString[] value)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var nsa_value = NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAccessibilityAttributedUserInputLabels:"), nsa_value.Handle);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSAccessibilityWrapper : BaseWrapper, INSAccessibility {
		public NSAccessibilityWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSAccessibilityWrapper))]
		static NSAccessibilityWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("accessibilityLayoutPointForScreenPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint GetAccessibilityLayoutForScreen (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("accessibilityLayoutPointForScreenPoint:"), point);
			return ret;
		}
		[Export ("accessibilityLayoutSizeForScreenSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize GetAccessibilityLayoutForScreen (CGSize size)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("accessibilityLayoutSizeForScreenSize:"), size);
			return ret;
		}
		[Export ("accessibilityScreenPointForLayoutPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint GetAccessibilityScreenForLayout (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGPoint ret;
			ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("accessibilityScreenPointForLayoutPoint:"), point);
			return ret;
		}
		[Export ("accessibilityScreenSizeForLayoutSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize GetAccessibilityScreenForLayout (CGSize size)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("accessibilityScreenSizeForLayoutSize:"), size);
			return ret;
		}
		[Export ("accessibilityCellForColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? GetAccessibilityCellForColumn (nint column, nint row)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("accessibilityCellForColumn:row:"), column, row), false)!;
			return ret;
		}
		[Export ("accessibilityAttributedStringForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAttributedString? GetAccessibilityAttributedString (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSAttributedString ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("accessibilityAttributedStringForRange:"), range), false)!;
			return ret;
		}
		[Export ("accessibilityRangeForLine:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetAccessibilityRangeForLine (nint line)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("accessibilityRangeForLine:"), line);
			return ret;
		}
		[Export ("accessibilityStringForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? GetAccessibilityString (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("accessibilityStringForRange:"), range), false)!;
			return ret;
		}
		[Export ("accessibilityRangeForPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetAccessibilityRange (CGPoint point)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("accessibilityRangeForPosition:"), point);
			return ret;
		}
		[Export ("accessibilityRangeForIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetAccessibilityRange (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("accessibilityRangeForIndex:"), index);
			return ret;
		}
		[Export ("accessibilityFrameForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetAccessibilityFrame (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("accessibilityFrameForRange:"), range);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange (this.Handle, Selector.GetHandle ("accessibilityFrameForRange:"), range);
			}
			return ret!;
		}
		[Export ("accessibilityRTFForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData? GetAccessibilityRtf (NSRange range)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("accessibilityRTFForRange:"), range), false)!;
			return ret;
		}
		[Export ("accessibilityStyleRangeForIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetAccessibilityStyleRange (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("accessibilityStyleRangeForIndex:"), index);
			return ret;
		}
		[Export ("accessibilityLineForIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetAccessibilityLine (nint index)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("accessibilityLineForIndex:"), index);
			return ret;
		}
		[Export ("accessibilityPerformCancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformCancel ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformCancel"));
			return ret != 0;
		}
		[Export ("accessibilityPerformConfirm")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformConfirm ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformConfirm"));
			return ret != 0;
		}
		[Export ("accessibilityPerformDecrement")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformDecrement ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformDecrement"));
			return ret != 0;
		}
		[Export ("accessibilityPerformDelete")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformDelete ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformDelete"));
			return ret != 0;
		}
		[Export ("accessibilityPerformIncrement")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformIncrement ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformIncrement"));
			return ret != 0;
		}
		[Export ("accessibilityPerformPick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformPick ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformPick"));
			return ret != 0;
		}
		[Export ("accessibilityPerformPress")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformPress ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformPress"));
			return ret != 0;
		}
		[Export ("accessibilityPerformRaise")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformRaise ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformRaise"));
			return ret != 0;
		}
		[Export ("accessibilityPerformShowAlternateUI")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformShowAlternateUI ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformShowAlternateUI"));
			return ret != 0;
		}
		[Export ("accessibilityPerformShowDefaultUI")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformShowDefaultUI ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformShowDefaultUI"));
			return ret != 0;
		}
		[Export ("accessibilityPerformShowMenu")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityPerformShowMenu ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPerformShowMenu"));
			return ret != 0;
		}
		[Export ("isAccessibilitySelectorAllowed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsAccessibilitySelectorAllowed (Selector selector)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isAccessibilitySelectorAllowed:"), selector.Handle);
			GC.KeepAlive (selector);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect AccessibilityFrame {
			[Export ("accessibilityFrame", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityFrame"));
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("accessibilityFrame"));
				}
				return ret!;
			}
			[Export ("setAccessibilityFrame:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setAccessibilityFrame:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityIdentifier {
			[Export ("accessibilityIdentifier")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityIdentifier")), false)!;
				return ret;
			}
			[Export ("setAccessibilityIdentifier:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityIdentifier:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityParent {
			[Export ("accessibilityParent", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityParent")), false)!;
				return ret;
			}
			[Export ("setAccessibilityParent:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityParent:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityFocused {
			[Export ("isAccessibilityFocused")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityFocused"));
				return ret != 0;
			}
			[Export ("setAccessibilityFocused:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityFocused:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityElement {
			[Export ("isAccessibilityElement")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityElement"));
				return ret != 0;
			}
			[Export ("setAccessibilityElement:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityElement:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGPoint AccessibilityActivationPoint {
			[Export ("accessibilityActivationPoint", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityActivationPoint"));
				return ret;
			}
			[Export ("setAccessibilityActivationPoint:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setAccessibilityActivationPoint:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityTopLevelUIElement {
			[Export ("accessibilityTopLevelUIElement", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTopLevelUIElement")), false)!;
				return ret;
			}
			[Export ("setAccessibilityTopLevelUIElement:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityTopLevelUIElement:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUrl? AccessibilityUrl {
			[Export ("accessibilityURL", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl ret;
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityURL")), false)!;
				return ret;
			}
			[Export ("setAccessibilityURL:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityURL:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityValue {
			[Export ("accessibilityValue", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityValue")), false)!;
				return ret;
			}
			[Export ("setAccessibilityValue:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityValue:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityValueDescription {
			[Export ("accessibilityValueDescription")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityValueDescription")), false)!;
				return ret;
			}
			[Export ("setAccessibilityValueDescription:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityValueDescription:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityVisibleChildren {
			[Export ("accessibilityVisibleChildren", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityVisibleChildren")), false)!;
				return ret;
			}
			[Export ("setAccessibilityVisibleChildren:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityVisibleChildren:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilitySubrole {
			[Export ("accessibilitySubrole")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySubrole")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySubrole:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySubrole:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityTitle {
			[Export ("accessibilityTitle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTitle")), false)!;
				return ret;
			}
			[Export ("setAccessibilityTitle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityTitle:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityTitleUIElement {
			[Export ("accessibilityTitleUIElement", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTitleUIElement")), false)!;
				return ret;
			}
			[Export ("setAccessibilityTitleUIElement:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityTitleUIElement:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityNextContents {
			[Export ("accessibilityNextContents", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityNextContents")), false)!;
				return ret;
			}
			[Export ("setAccessibilityNextContents:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityNextContents:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilityOrientation AccessibilityOrientation {
			[Export ("accessibilityOrientation", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityOrientation ret;
				ret = (NSAccessibilityOrientation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityOrientation"));
				return ret!;
			}
			[Export ("setAccessibilityOrientation:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityOrientation:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityOverflowButton {
			[Export ("accessibilityOverflowButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityOverflowButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityOverflowButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityOverflowButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityPlaceholderValue {
			[Export ("accessibilityPlaceholderValue")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPlaceholderValue")), false)!;
				return ret;
			}
			[Export ("setAccessibilityPlaceholderValue:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityPlaceholderValue:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityPreviousContents {
			[Export ("accessibilityPreviousContents", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPreviousContents")), false)!;
				return ret;
			}
			[Export ("setAccessibilityPreviousContents:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityPreviousContents:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityRole {
			[Export ("accessibilityRole")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRole")), false)!;
				return ret;
			}
			[Export ("setAccessibilityRole:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityRole:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityRoleDescription {
			[Export ("accessibilityRoleDescription")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRoleDescription")), false)!;
				return ret;
			}
			[Export ("setAccessibilityRoleDescription:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityRoleDescription:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilitySearchButton {
			[Export ("accessibilitySearchButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySearchButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySearchButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySearchButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilitySearchMenu {
			[Export ("accessibilitySearchMenu", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySearchMenu")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySearchMenu:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySearchMenu:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilitySelected {
			[Export ("isAccessibilitySelected")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilitySelected"));
				return ret != 0;
			}
			[Export ("setAccessibilitySelected:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilitySelected:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilitySelectedChildren {
			[Export ("accessibilitySelectedChildren", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySelectedChildren")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySelectedChildren:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySelectedChildren:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityServesAsTitleForUIElements {
			[Export ("accessibilityServesAsTitleForUIElements", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityServesAsTitleForUIElements")), false)!;
				return ret;
			}
			[Export ("setAccessibilityServesAsTitleForUIElements:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityServesAsTitleForUIElements:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityShownMenu {
			[Export ("accessibilityShownMenu", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityShownMenu")), false)!;
				return ret;
			}
			[Export ("setAccessibilityShownMenu:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityShownMenu:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityMinValue {
			[Export ("accessibilityMinValue", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMinValue")), false)!;
				return ret;
			}
			[Export ("setAccessibilityMinValue:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityMinValue:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityMaxValue {
			[Export ("accessibilityMaxValue", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMaxValue")), false)!;
				return ret;
			}
			[Export ("setAccessibilityMaxValue:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityMaxValue:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityLinkedUIElements {
			[Export ("accessibilityLinkedUIElements", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityLinkedUIElements")), false)!;
				return ret;
			}
			[Export ("setAccessibilityLinkedUIElements:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityLinkedUIElements:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityWindow {
			[Export ("accessibilityWindow", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityWindow")), false)!;
				return ret;
			}
			[Export ("setAccessibilityWindow:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityWindow:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityHelp {
			[Export ("accessibilityHelp")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityHelp")), false)!;
				return ret;
			}
			[Export ("setAccessibilityHelp:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityHelp:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityFilename {
			[Export ("accessibilityFilename")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityFilename")), false)!;
				return ret;
			}
			[Export ("setAccessibilityFilename:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityFilename:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityExpanded {
			[Export ("isAccessibilityExpanded")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityExpanded"));
				return ret != 0;
			}
			[Export ("setAccessibilityExpanded:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityExpanded:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityEdited {
			[Export ("isAccessibilityEdited")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityEdited"));
				return ret != 0;
			}
			[Export ("setAccessibilityEdited:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityEdited:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityEnabled {
			[Export ("isAccessibilityEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityEnabled"));
				return ret != 0;
			}
			[Export ("setAccessibilityEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityEnabled:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityChildren {
			[Export ("accessibilityChildren", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityChildren")), false)!;
				return ret;
			}
			[Export ("setAccessibilityChildren:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityChildren:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityClearButton {
			[Export ("accessibilityClearButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityClearButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityClearButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityClearButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityCancelButton {
			[Export ("accessibilityCancelButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityCancelButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityCancelButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityCancelButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityProtectedContent {
			[Export ("isAccessibilityProtectedContent")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityProtectedContent"));
				return ret != 0;
			}
			[Export ("setAccessibilityProtectedContent:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityProtectedContent:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityContents {
			[Export ("accessibilityContents", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityContents")), false)!;
				return ret;
			}
			[Export ("setAccessibilityContents:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityContents:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityLabel {
			[Export ("accessibilityLabel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityLabel")), false)!;
				return ret;
			}
			[Export ("setAccessibilityLabel:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityAlternateUIVisible {
			[Export ("isAccessibilityAlternateUIVisible")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityAlternateUIVisible"));
				return ret != 0;
			}
			[Export ("setAccessibilityAlternateUIVisible:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityAlternateUIVisible:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilitySharedFocusElements {
			[Export ("accessibilitySharedFocusElements", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySharedFocusElements")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySharedFocusElements:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySharedFocusElements:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityApplicationFocusedUIElement {
			[Export ("accessibilityApplicationFocusedUIElement", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityApplicationFocusedUIElement")), false)!;
				return ret;
			}
			[Export ("setAccessibilityApplicationFocusedUIElement:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityApplicationFocusedUIElement:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityMainWindow {
			[Export ("accessibilityMainWindow", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMainWindow")), false)!;
				return ret;
			}
			[Export ("setAccessibilityMainWindow:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityMainWindow:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityHidden {
			[Export ("isAccessibilityHidden")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityHidden"));
				return ret != 0;
			}
			[Export ("setAccessibilityHidden:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityHidden:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityFrontmost {
			[Export ("isAccessibilityFrontmost")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityFrontmost"));
				return ret != 0;
			}
			[Export ("setAccessibilityFrontmost:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityFrontmost:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityFocusedWindow {
			[Export ("accessibilityFocusedWindow", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityFocusedWindow")), false)!;
				return ret;
			}
			[Export ("setAccessibilityFocusedWindow:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityFocusedWindow:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityWindows {
			[Export ("accessibilityWindows", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityWindows")), false)!;
				return ret;
			}
			[Export ("setAccessibilityWindows:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityWindows:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityExtrasMenuBar {
			[Export ("accessibilityExtrasMenuBar", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityExtrasMenuBar")), false)!;
				return ret;
			}
			[Export ("setAccessibilityExtrasMenuBar:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityExtrasMenuBar:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityMenuBar {
			[Export ("accessibilityMenuBar", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMenuBar")), false)!;
				return ret;
			}
			[Export ("setAccessibilityMenuBar:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityMenuBar:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityColumnTitles {
			[Export ("accessibilityColumnTitles", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityColumnTitles")), false)!;
				return ret;
			}
			[Export ("setAccessibilityColumnTitles:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityColumnTitles:"), nsa_value.GetHandle ());
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityOrderedByRow {
			[Export ("isAccessibilityOrderedByRow")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityOrderedByRow"));
				return ret != 0;
			}
			[Export ("setAccessibilityOrderedByRow:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityOrderedByRow:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilityUnits AccessibilityHorizontalUnits {
			[Export ("accessibilityHorizontalUnits", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityUnits ret;
				ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityHorizontalUnits"));
				return ret!;
			}
			[Export ("setAccessibilityHorizontalUnits:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityHorizontalUnits:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilityUnits AccessibilityVerticalUnits {
			[Export ("accessibilityVerticalUnits", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityUnits ret;
				ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityVerticalUnits"));
				return ret!;
			}
			[Export ("setAccessibilityVerticalUnits:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityVerticalUnits:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityHorizontalUnitDescription {
			[Export ("accessibilityHorizontalUnitDescription")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityHorizontalUnitDescription")), false)!;
				return ret;
			}
			[Export ("setAccessibilityHorizontalUnitDescription:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityHorizontalUnitDescription:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityVerticalUnitDescription {
			[Export ("accessibilityVerticalUnitDescription")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityVerticalUnitDescription")), false)!;
				return ret;
			}
			[Export ("setAccessibilityVerticalUnitDescription:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityVerticalUnitDescription:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityHandles {
			[Export ("accessibilityHandles", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityHandles")), false)!;
				return ret;
			}
			[Export ("setAccessibilityHandles:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityHandles:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityWarningValue {
			[Export ("accessibilityWarningValue", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityWarningValue")), false)!;
				return ret;
			}
			[Export ("setAccessibilityWarningValue:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityWarningValue:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityCriticalValue {
			[Export ("accessibilityCriticalValue", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityCriticalValue")), false)!;
				return ret;
			}
			[Export ("setAccessibilityCriticalValue:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityCriticalValue:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityDisclosed {
			[Export ("isAccessibilityDisclosed")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityDisclosed"));
				return ret != 0;
			}
			[Export ("setAccessibilityDisclosed:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityDisclosed:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityDisclosedByRow {
			[Export ("accessibilityDisclosedByRow", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityDisclosedByRow")), false)!;
				return ret;
			}
			[Export ("setAccessibilityDisclosedByRow:", ArgumentSemantic.Weak)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityDisclosedByRow:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityDisclosedRows {
			[Export ("accessibilityDisclosedRows", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityDisclosedRows")), false)!;
				return ret;
			}
			[Export ("setAccessibilityDisclosedRows:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityDisclosedRows:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint AccessibilityDisclosureLevel {
			[Export ("accessibilityDisclosureLevel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityDisclosureLevel"));
				return ret;
			}
			[Export ("setAccessibilityDisclosureLevel:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityDisclosureLevel:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityMarkerUIElements {
			[Export ("accessibilityMarkerUIElements", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMarkerUIElements")), false)!;
				return ret;
			}
			[Export ("setAccessibilityMarkerUIElements:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityMarkerUIElements:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityMarkerValues {
			[Export ("accessibilityMarkerValues", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMarkerValues")), false)!;
				return ret;
			}
			[Export ("setAccessibilityMarkerValues:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityMarkerValues:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityMarkerGroupUIElement {
			[Export ("accessibilityMarkerGroupUIElement", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMarkerGroupUIElement")), false)!;
				return ret;
			}
			[Export ("setAccessibilityMarkerGroupUIElement:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityMarkerGroupUIElement:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilityUnits AccessibilityUnits {
			[Export ("accessibilityUnits", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityUnits ret;
				ret = (NSAccessibilityUnits) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityUnits"));
				return ret!;
			}
			[Export ("setAccessibilityUnits:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityUnits:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityUnitDescription {
			[Export ("accessibilityUnitDescription")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityUnitDescription")), false)!;
				return ret;
			}
			[Export ("setAccessibilityUnitDescription:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityUnitDescription:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilityRulerMarkerType AccessibilityRulerMarkerType {
			[Export ("accessibilityRulerMarkerType", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityRulerMarkerType ret;
				ret = (NSAccessibilityRulerMarkerType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRulerMarkerType"));
				return ret!;
			}
			[Export ("setAccessibilityRulerMarkerType:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityRulerMarkerType:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityMarkerTypeDescription {
			[Export ("accessibilityMarkerTypeDescription")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMarkerTypeDescription")), false)!;
				return ret;
			}
			[Export ("setAccessibilityMarkerTypeDescription:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityMarkerTypeDescription:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityHorizontalScrollBar {
			[Export ("accessibilityHorizontalScrollBar", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityHorizontalScrollBar")), false)!;
				return ret;
			}
			[Export ("setAccessibilityHorizontalScrollBar:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityHorizontalScrollBar:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityVerticalScrollBar {
			[Export ("accessibilityVerticalScrollBar", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityVerticalScrollBar")), false)!;
				return ret;
			}
			[Export ("setAccessibilityVerticalScrollBar:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityVerticalScrollBar:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber[]? AccessibilityAllowedValues {
			[Export ("accessibilityAllowedValues", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSNumber[] ret;
				ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityAllowedValues")), false)!;
				return ret;
			}
			[Export ("setAccessibilityAllowedValues:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityAllowedValues:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityLabelUIElements {
			[Export ("accessibilityLabelUIElements", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityLabelUIElements")), false)!;
				return ret;
			}
			[Export ("setAccessibilityLabelUIElements:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityLabelUIElements:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float AccessibilityLabelValue {
			[Export ("accessibilityLabelValue")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityLabelValue"));
				return ret;
			}
			[Export ("setAccessibilityLabelValue:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setAccessibilityLabelValue:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilitySplitters {
			[Export ("accessibilitySplitters", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySplitters")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySplitters:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySplitters:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityDecrementButton {
			[Export ("accessibilityDecrementButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityDecrementButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityDecrementButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityDecrementButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityIncrementButton {
			[Export ("accessibilityIncrementButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityIncrementButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityIncrementButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityIncrementButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityTabs {
			[Export ("accessibilityTabs", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTabs")), false)!;
				return ret;
			}
			[Export ("setAccessibilityTabs:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityTabs:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityHeader {
			[Export ("accessibilityHeader", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityHeader")), false)!;
				return ret;
			}
			[Export ("setAccessibilityHeader:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityHeader:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint AccessibilityColumnCount {
			[Export ("accessibilityColumnCount")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityColumnCount"));
				return ret;
			}
			[Export ("setAccessibilityColumnCount:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityColumnCount:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint AccessibilityRowCount {
			[Export ("accessibilityRowCount")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRowCount"));
				return ret;
			}
			[Export ("setAccessibilityRowCount:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityRowCount:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint AccessibilityIndex {
			[Export ("accessibilityIndex")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityIndex"));
				return ret;
			}
			[Export ("setAccessibilityIndex:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityIndex:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityColumns {
			[Export ("accessibilityColumns", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityColumns")), false)!;
				return ret;
			}
			[Export ("setAccessibilityColumns:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityColumns:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityRows {
			[Export ("accessibilityRows", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRows")), false)!;
				return ret;
			}
			[Export ("setAccessibilityRows:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityRows:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityVisibleRows {
			[Export ("accessibilityVisibleRows", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityVisibleRows")), false)!;
				return ret;
			}
			[Export ("setAccessibilityVisibleRows:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityVisibleRows:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilitySelectedRows {
			[Export ("accessibilitySelectedRows", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySelectedRows")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySelectedRows:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySelectedRows:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityVisibleColumns {
			[Export ("accessibilityVisibleColumns", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityVisibleColumns")), false)!;
				return ret;
			}
			[Export ("setAccessibilityVisibleColumns:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityVisibleColumns:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilitySelectedColumns {
			[Export ("accessibilitySelectedColumns", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySelectedColumns")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySelectedColumns:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySelectedColumns:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilitySortDirection AccessibilitySortDirection {
			[Export ("accessibilitySortDirection", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilitySortDirection ret;
				ret = (NSAccessibilitySortDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySortDirection"));
				return ret!;
			}
			[Export ("setAccessibilitySortDirection:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilitySortDirection:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityRowHeaderUIElements {
			[Export ("accessibilityRowHeaderUIElements", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRowHeaderUIElements")), false)!;
				return ret;
			}
			[Export ("setAccessibilityRowHeaderUIElements:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityRowHeaderUIElements:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilitySelectedCells {
			[Export ("accessibilitySelectedCells", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySelectedCells")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySelectedCells:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySelectedCells:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityVisibleCells {
			[Export ("accessibilityVisibleCells", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityVisibleCells")), false)!;
				return ret;
			}
			[Export ("setAccessibilityVisibleCells:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityVisibleCells:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilityColumnHeaderUIElements {
			[Export ("accessibilityColumnHeaderUIElements", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityColumnHeaderUIElements")), false)!;
				return ret;
			}
			[Export ("setAccessibilityColumnHeaderUIElements:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityColumnHeaderUIElements:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange AccessibilityRowIndexRange {
			[Export ("accessibilityRowIndexRange", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRowIndexRange"));
				return ret;
			}
			[Export ("setAccessibilityRowIndexRange:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("setAccessibilityRowIndexRange:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange AccessibilityColumnIndexRange {
			[Export ("accessibilityColumnIndexRange", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityColumnIndexRange"));
				return ret;
			}
			[Export ("setAccessibilityColumnIndexRange:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("setAccessibilityColumnIndexRange:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint AccessibilityInsertionPointLineNumber {
			[Export ("accessibilityInsertionPointLineNumber")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityInsertionPointLineNumber"));
				return ret;
			}
			[Export ("setAccessibilityInsertionPointLineNumber:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityInsertionPointLineNumber:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange AccessibilitySharedCharacterRange {
			[Export ("accessibilitySharedCharacterRange", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySharedCharacterRange"));
				return ret;
			}
			[Export ("setAccessibilitySharedCharacterRange:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("setAccessibilitySharedCharacterRange:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject[]? AccessibilitySharedTextUIElements {
			[Export ("accessibilitySharedTextUIElements", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[] ret;
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySharedTextUIElements")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySharedTextUIElements:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySharedTextUIElements:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange AccessibilityVisibleCharacterRange {
			[Export ("accessibilityVisibleCharacterRange", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityVisibleCharacterRange"));
				return ret;
			}
			[Export ("setAccessibilityVisibleCharacterRange:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("setAccessibilityVisibleCharacterRange:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint AccessibilityNumberOfCharacters {
			[Export ("accessibilityNumberOfCharacters")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityNumberOfCharacters"));
				return ret;
			}
			[Export ("setAccessibilityNumberOfCharacters:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityNumberOfCharacters:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilitySelectedText {
			[Export ("accessibilitySelectedText")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySelectedText")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySelectedText:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySelectedText:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange AccessibilitySelectedTextRange {
			[Export ("accessibilitySelectedTextRange", ArgumentSemantic.Assign)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSRange ret;
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySelectedTextRange"));
				return ret;
			}
			[Export ("setAccessibilitySelectedTextRange:", ArgumentSemantic.Assign)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("setAccessibilitySelectedTextRange:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSValue[]? AccessibilitySelectedTextRanges {
			[Export ("accessibilitySelectedTextRanges", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSValue[] ret;
				ret = CFArray.ArrayFromHandle<NSValue>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilitySelectedTextRanges")), false)!;
				return ret;
			}
			[Export ("setAccessibilitySelectedTextRanges:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilitySelectedTextRanges:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityToolbarButton {
			[Export ("accessibilityToolbarButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityToolbarButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityToolbarButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityToolbarButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityModal {
			[Export ("isAccessibilityModal")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityModal"));
				return ret != 0;
			}
			[Export ("setAccessibilityModal:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityModal:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityProxy {
			[Export ("accessibilityProxy", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityProxy")), false)!;
				return ret;
			}
			[Export ("setAccessibilityProxy:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityProxy:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityMain {
			[Export ("isAccessibilityMain")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityMain"));
				return ret != 0;
			}
			[Export ("setAccessibilityMain:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityMain:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityFullScreenButton {
			[Export ("accessibilityFullScreenButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityFullScreenButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityFullScreenButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityFullScreenButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityGrowArea {
			[Export ("accessibilityGrowArea", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityGrowArea")), false)!;
				return ret;
			}
			[Export ("setAccessibilityGrowArea:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityGrowArea:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? AccessibilityDocument {
			[Export ("accessibilityDocument")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityDocument")), false)!;
				return ret;
			}
			[Export ("setAccessibilityDocument:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityDocument:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityDefaultButton {
			[Export ("accessibilityDefaultButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityDefaultButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityDefaultButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityDefaultButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityCloseButton {
			[Export ("accessibilityCloseButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityCloseButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityCloseButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityCloseButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityZoomButton {
			[Export ("accessibilityZoomButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityZoomButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityZoomButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityZoomButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? AccessibilityMinimizeButton {
			[Export ("accessibilityMinimizeButton", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMinimizeButton")), false)!;
				return ret;
			}
			[Export ("setAccessibilityMinimizeButton:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityMinimizeButton:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityMinimized {
			[Export ("isAccessibilityMinimized")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityMinimized"));
				return ret != 0;
			}
			[Export ("setAccessibilityMinimized:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityMinimized:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AccessibilityRequired {
			[Export ("isAccessibilityRequired")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityRequired"));
				return ret != 0;
			}
			[Export ("setAccessibilityRequired:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityRequired:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilityElement[]? AccessibilityChildrenInNavigationOrder {
			[Export ("accessibilityChildrenInNavigationOrder", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityElement[] ret;
				ret = CFArray.ArrayFromHandle<NSAccessibilityElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityChildrenInNavigationOrder")), false)!;
				return ret;
			}
			[Export ("setAccessibilityChildrenInNavigationOrder:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityChildrenInNavigationOrder:"), nsa_value.GetHandle ());
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilityCustomRotor[] AccessibilityCustomRotors {
			[Export ("accessibilityCustomRotors", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityCustomRotor[] ret;
				ret = CFArray.ArrayFromHandle<NSAccessibilityCustomRotor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityCustomRotors")), false)!;
				return ret;
			}
			[Export ("setAccessibilityCustomRotors:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityCustomRotors:"), nsa_value.Handle);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAccessibilityCustomAction[]? AccessibilityCustomActions {
			[Export ("accessibilityCustomActions", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAccessibilityCustomAction[] ret;
				ret = CFArray.ArrayFromHandle<NSAccessibilityCustomAction>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityCustomActions")), false)!;
				return ret;
			}
			[Export ("setAccessibilityCustomActions:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityCustomActions:"), nsa_value.GetHandle ());
			}
		}
	}
}
