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
	[Register("NSColor", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSColor : NSObject, INSAccessibilityColor, INSCoding, INSCopying, INSPasteboardReading, INSPasteboardWriting, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGColorX = "CGColor";
		static readonly NativeHandle selCGColorXHandle = Selector.GetHandle ("CGColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityNameX = "accessibilityName";
		static readonly NativeHandle selAccessibilityNameXHandle = Selector.GetHandle ("accessibilityName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlphaComponentX = "alphaComponent";
		static readonly NativeHandle selAlphaComponentXHandle = Selector.GetHandle ("alphaComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlternateSelectedControlColorX = "alternateSelectedControlColor";
		static readonly NativeHandle selAlternateSelectedControlColorXHandle = Selector.GetHandle ("alternateSelectedControlColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlternateSelectedControlTextColorX = "alternateSelectedControlTextColor";
		static readonly NativeHandle selAlternateSelectedControlTextColorXHandle = Selector.GetHandle ("alternateSelectedControlTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlternatingContentBackgroundColorsX = "alternatingContentBackgroundColors";
		static readonly NativeHandle selAlternatingContentBackgroundColorsXHandle = Selector.GetHandle ("alternatingContentBackgroundColors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlackColorX = "blackColor";
		static readonly NativeHandle selBlackColorXHandle = Selector.GetHandle ("blackColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlackComponentX = "blackComponent";
		static readonly NativeHandle selBlackComponentXHandle = Selector.GetHandle ("blackComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlendedColorWithFraction_OfColor_X = "blendedColorWithFraction:ofColor:";
		static readonly NativeHandle selBlendedColorWithFraction_OfColor_XHandle = Selector.GetHandle ("blendedColorWithFraction:ofColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlueColorX = "blueColor";
		static readonly NativeHandle selBlueColorXHandle = Selector.GetHandle ("blueColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlueComponentX = "blueComponent";
		static readonly NativeHandle selBlueComponentXHandle = Selector.GetHandle ("blueComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBrightnessComponentX = "brightnessComponent";
		static readonly NativeHandle selBrightnessComponentXHandle = Selector.GetHandle ("brightnessComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBrownColorX = "brownColor";
		static readonly NativeHandle selBrownColorXHandle = Selector.GetHandle ("brownColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCatalogNameComponentX = "catalogNameComponent";
		static readonly NativeHandle selCatalogNameComponentXHandle = Selector.GetHandle ("catalogNameComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearColorX = "clearColor";
		static readonly NativeHandle selClearColorXHandle = Selector.GetHandle ("clearColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorByApplyingContentHeadroom_X = "colorByApplyingContentHeadroom:";
		static readonly NativeHandle selColorByApplyingContentHeadroom_XHandle = Selector.GetHandle ("colorByApplyingContentHeadroom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorForControlTint_X = "colorForControlTint:";
		static readonly NativeHandle selColorForControlTint_XHandle = Selector.GetHandle ("colorForControlTint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorFromPasteboard_X = "colorFromPasteboard:";
		static readonly NativeHandle selColorFromPasteboard_XHandle = Selector.GetHandle ("colorFromPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorNameComponentX = "colorNameComponent";
		static readonly NativeHandle selColorNameComponentXHandle = Selector.GetHandle ("colorNameComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorNamed_X = "colorNamed:";
		static readonly NativeHandle selColorNamed_XHandle = Selector.GetHandle ("colorNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorNamed_Bundle_X = "colorNamed:bundle:";
		static readonly NativeHandle selColorNamed_Bundle_XHandle = Selector.GetHandle ("colorNamed:bundle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorSpaceX = "colorSpace";
		static readonly NativeHandle selColorSpaceXHandle = Selector.GetHandle ("colorSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorSpaceNameX = "colorSpaceName";
		static readonly NativeHandle selColorSpaceNameXHandle = Selector.GetHandle ("colorSpaceName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorUsingColorSpace_X = "colorUsingColorSpace:";
		static readonly NativeHandle selColorUsingColorSpace_XHandle = Selector.GetHandle ("colorUsingColorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorUsingColorSpaceName_X = "colorUsingColorSpaceName:";
		static readonly NativeHandle selColorUsingColorSpaceName_XHandle = Selector.GetHandle ("colorUsingColorSpaceName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorUsingColorSpaceName_Device_X = "colorUsingColorSpaceName:device:";
		static readonly NativeHandle selColorUsingColorSpaceName_Device_XHandle = Selector.GetHandle ("colorUsingColorSpaceName:device:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorUsingType_X = "colorUsingType:";
		static readonly NativeHandle selColorUsingType_XHandle = Selector.GetHandle ("colorUsingType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithAlphaComponent_X = "colorWithAlphaComponent:";
		static readonly NativeHandle selColorWithAlphaComponent_XHandle = Selector.GetHandle ("colorWithAlphaComponent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithCGColor_X = "colorWithCGColor:";
		static readonly NativeHandle selColorWithCGColor_XHandle = Selector.GetHandle ("colorWithCGColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithCIColor_X = "colorWithCIColor:";
		static readonly NativeHandle selColorWithCIColor_XHandle = Selector.GetHandle ("colorWithCIColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithCalibratedHue_Saturation_Brightness_Alpha_X = "colorWithCalibratedHue:saturation:brightness:alpha:";
		static readonly NativeHandle selColorWithCalibratedHue_Saturation_Brightness_Alpha_XHandle = Selector.GetHandle ("colorWithCalibratedHue:saturation:brightness:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithCalibratedRed_Green_Blue_Alpha_X = "colorWithCalibratedRed:green:blue:alpha:";
		static readonly NativeHandle selColorWithCalibratedRed_Green_Blue_Alpha_XHandle = Selector.GetHandle ("colorWithCalibratedRed:green:blue:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithCalibratedWhite_Alpha_X = "colorWithCalibratedWhite:alpha:";
		static readonly NativeHandle selColorWithCalibratedWhite_Alpha_XHandle = Selector.GetHandle ("colorWithCalibratedWhite:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithCatalogName_ColorName_X = "colorWithCatalogName:colorName:";
		static readonly NativeHandle selColorWithCatalogName_ColorName_XHandle = Selector.GetHandle ("colorWithCatalogName:colorName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithColorSpace_Components_Count_X = "colorWithColorSpace:components:count:";
		static readonly NativeHandle selColorWithColorSpace_Components_Count_XHandle = Selector.GetHandle ("colorWithColorSpace:components:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithColorSpace_Hue_Saturation_Brightness_Alpha_X = "colorWithColorSpace:hue:saturation:brightness:alpha:";
		static readonly NativeHandle selColorWithColorSpace_Hue_Saturation_Brightness_Alpha_XHandle = Selector.GetHandle ("colorWithColorSpace:hue:saturation:brightness:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithDeviceCyan_Magenta_Yellow_Black_Alpha_X = "colorWithDeviceCyan:magenta:yellow:black:alpha:";
		static readonly NativeHandle selColorWithDeviceCyan_Magenta_Yellow_Black_Alpha_XHandle = Selector.GetHandle ("colorWithDeviceCyan:magenta:yellow:black:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithDeviceHue_Saturation_Brightness_Alpha_X = "colorWithDeviceHue:saturation:brightness:alpha:";
		static readonly NativeHandle selColorWithDeviceHue_Saturation_Brightness_Alpha_XHandle = Selector.GetHandle ("colorWithDeviceHue:saturation:brightness:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithDeviceRed_Green_Blue_Alpha_X = "colorWithDeviceRed:green:blue:alpha:";
		static readonly NativeHandle selColorWithDeviceRed_Green_Blue_Alpha_XHandle = Selector.GetHandle ("colorWithDeviceRed:green:blue:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithDeviceWhite_Alpha_X = "colorWithDeviceWhite:alpha:";
		static readonly NativeHandle selColorWithDeviceWhite_Alpha_XHandle = Selector.GetHandle ("colorWithDeviceWhite:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithDisplayP3Red_Green_Blue_Alpha_X = "colorWithDisplayP3Red:green:blue:alpha:";
		static readonly NativeHandle selColorWithDisplayP3Red_Green_Blue_Alpha_XHandle = Selector.GetHandle ("colorWithDisplayP3Red:green:blue:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithGenericGamma22White_Alpha_X = "colorWithGenericGamma22White:alpha:";
		static readonly NativeHandle selColorWithGenericGamma22White_Alpha_XHandle = Selector.GetHandle ("colorWithGenericGamma22White:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithHue_Saturation_Brightness_Alpha_X = "colorWithHue:saturation:brightness:alpha:";
		static readonly NativeHandle selColorWithHue_Saturation_Brightness_Alpha_XHandle = Selector.GetHandle ("colorWithHue:saturation:brightness:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithName_DynamicProvider_X = "colorWithName:dynamicProvider:";
		static readonly NativeHandle selColorWithName_DynamicProvider_XHandle = Selector.GetHandle ("colorWithName:dynamicProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithPatternImage_X = "colorWithPatternImage:";
		static readonly NativeHandle selColorWithPatternImage_XHandle = Selector.GetHandle ("colorWithPatternImage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithRed_Green_Blue_Alpha_X = "colorWithRed:green:blue:alpha:";
		static readonly NativeHandle selColorWithRed_Green_Blue_Alpha_XHandle = Selector.GetHandle ("colorWithRed:green:blue:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithRed_Green_Blue_Alpha_Exposure_X = "colorWithRed:green:blue:alpha:exposure:";
		static readonly NativeHandle selColorWithRed_Green_Blue_Alpha_Exposure_XHandle = Selector.GetHandle ("colorWithRed:green:blue:alpha:exposure:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithRed_Green_Blue_Alpha_LinearExposure_X = "colorWithRed:green:blue:alpha:linearExposure:";
		static readonly NativeHandle selColorWithRed_Green_Blue_Alpha_LinearExposure_XHandle = Selector.GetHandle ("colorWithRed:green:blue:alpha:linearExposure:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithSRGBRed_Green_Blue_Alpha_X = "colorWithSRGBRed:green:blue:alpha:";
		static readonly NativeHandle selColorWithSRGBRed_Green_Blue_Alpha_XHandle = Selector.GetHandle ("colorWithSRGBRed:green:blue:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithSystemEffect_X = "colorWithSystemEffect:";
		static readonly NativeHandle selColorWithSystemEffect_XHandle = Selector.GetHandle ("colorWithSystemEffect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorWithWhite_Alpha_X = "colorWithWhite:alpha:";
		static readonly NativeHandle selColorWithWhite_Alpha_XHandle = Selector.GetHandle ("colorWithWhite:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlAccentColorX = "controlAccentColor";
		static readonly NativeHandle selControlAccentColorXHandle = Selector.GetHandle ("controlAccentColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlAlternatingRowBackgroundColorsX = "controlAlternatingRowBackgroundColors";
		static readonly NativeHandle selControlAlternatingRowBackgroundColorsXHandle = Selector.GetHandle ("controlAlternatingRowBackgroundColors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlBackgroundColorX = "controlBackgroundColor";
		static readonly NativeHandle selControlBackgroundColorXHandle = Selector.GetHandle ("controlBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlColorX = "controlColor";
		static readonly NativeHandle selControlColorXHandle = Selector.GetHandle ("controlColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlDarkShadowColorX = "controlDarkShadowColor";
		static readonly NativeHandle selControlDarkShadowColorXHandle = Selector.GetHandle ("controlDarkShadowColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlHighlightColorX = "controlHighlightColor";
		static readonly NativeHandle selControlHighlightColorXHandle = Selector.GetHandle ("controlHighlightColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlLightHighlightColorX = "controlLightHighlightColor";
		static readonly NativeHandle selControlLightHighlightColorXHandle = Selector.GetHandle ("controlLightHighlightColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlShadowColorX = "controlShadowColor";
		static readonly NativeHandle selControlShadowColorXHandle = Selector.GetHandle ("controlShadowColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlTextColorX = "controlTextColor";
		static readonly NativeHandle selControlTextColorXHandle = Selector.GetHandle ("controlTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentControlTintX = "currentControlTint";
		static readonly NativeHandle selCurrentControlTintXHandle = Selector.GetHandle ("currentControlTint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCyanColorX = "cyanColor";
		static readonly NativeHandle selCyanColorXHandle = Selector.GetHandle ("cyanColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCyanComponentX = "cyanComponent";
		static readonly NativeHandle selCyanComponentXHandle = Selector.GetHandle ("cyanComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDarkGrayColorX = "darkGrayColor";
		static readonly NativeHandle selDarkGrayColorXHandle = Selector.GetHandle ("darkGrayColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisabledControlTextColorX = "disabledControlTextColor";
		static readonly NativeHandle selDisabledControlTextColorXHandle = Selector.GetHandle ("disabledControlTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawSwatchInRect_X = "drawSwatchInRect:";
		static readonly NativeHandle selDrawSwatchInRect_XHandle = Selector.GetHandle ("drawSwatchInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindHighlightColorX = "findHighlightColor";
		static readonly NativeHandle selFindHighlightColorXHandle = Selector.GetHandle ("findHighlightColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetComponents_X = "getComponents:";
		static readonly NativeHandle selGetComponents_XHandle = Selector.GetHandle ("getComponents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetCyan_Magenta_Yellow_Black_Alpha_X = "getCyan:magenta:yellow:black:alpha:";
		static readonly NativeHandle selGetCyan_Magenta_Yellow_Black_Alpha_XHandle = Selector.GetHandle ("getCyan:magenta:yellow:black:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetHue_Saturation_Brightness_Alpha_X = "getHue:saturation:brightness:alpha:";
		static readonly NativeHandle selGetHue_Saturation_Brightness_Alpha_XHandle = Selector.GetHandle ("getHue:saturation:brightness:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetRed_Green_Blue_Alpha_X = "getRed:green:blue:alpha:";
		static readonly NativeHandle selGetRed_Green_Blue_Alpha_XHandle = Selector.GetHandle ("getRed:green:blue:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetWhite_Alpha_X = "getWhite:alpha:";
		static readonly NativeHandle selGetWhite_Alpha_XHandle = Selector.GetHandle ("getWhite:alpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGrayColorX = "grayColor";
		static readonly NativeHandle selGrayColorXHandle = Selector.GetHandle ("grayColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGreenColorX = "greenColor";
		static readonly NativeHandle selGreenColorXHandle = Selector.GetHandle ("greenColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGreenComponentX = "greenComponent";
		static readonly NativeHandle selGreenComponentXHandle = Selector.GetHandle ("greenComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGridColorX = "gridColor";
		static readonly NativeHandle selGridColorXHandle = Selector.GetHandle ("gridColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeaderColorX = "headerColor";
		static readonly NativeHandle selHeaderColorXHandle = Selector.GetHandle ("headerColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeaderTextColorX = "headerTextColor";
		static readonly NativeHandle selHeaderTextColorXHandle = Selector.GetHandle ("headerTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlightColorX = "highlightColor";
		static readonly NativeHandle selHighlightColorXHandle = Selector.GetHandle ("highlightColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHighlightWithLevel_X = "highlightWithLevel:";
		static readonly NativeHandle selHighlightWithLevel_XHandle = Selector.GetHandle ("highlightWithLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHueComponentX = "hueComponent";
		static readonly NativeHandle selHueComponentXHandle = Selector.GetHandle ("hueComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIgnoresAlphaX = "ignoresAlpha";
		static readonly NativeHandle selIgnoresAlphaXHandle = Selector.GetHandle ("ignoresAlpha");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPasteboardPropertyList_OfType_X = "initWithPasteboardPropertyList:ofType:";
		static readonly NativeHandle selInitWithPasteboardPropertyList_OfType_XHandle = Selector.GetHandle ("initWithPasteboardPropertyList:ofType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyboardFocusIndicatorColorX = "keyboardFocusIndicatorColor";
		static readonly NativeHandle selKeyboardFocusIndicatorColorXHandle = Selector.GetHandle ("keyboardFocusIndicatorColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKnobColorX = "knobColor";
		static readonly NativeHandle selKnobColorXHandle = Selector.GetHandle ("knobColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelColorX = "labelColor";
		static readonly NativeHandle selLabelColorXHandle = Selector.GetHandle ("labelColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLightGrayColorX = "lightGrayColor";
		static readonly NativeHandle selLightGrayColorXHandle = Selector.GetHandle ("lightGrayColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinearExposureX = "linearExposure";
		static readonly NativeHandle selLinearExposureXHandle = Selector.GetHandle ("linearExposure");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinkColorX = "linkColor";
		static readonly NativeHandle selLinkColorXHandle = Selector.GetHandle ("linkColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedCatalogNameComponentX = "localizedCatalogNameComponent";
		static readonly NativeHandle selLocalizedCatalogNameComponentXHandle = Selector.GetHandle ("localizedCatalogNameComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedColorNameComponentX = "localizedColorNameComponent";
		static readonly NativeHandle selLocalizedColorNameComponentXHandle = Selector.GetHandle ("localizedColorNameComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMagentaColorX = "magentaColor";
		static readonly NativeHandle selMagentaColorXHandle = Selector.GetHandle ("magentaColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMagentaComponentX = "magentaComponent";
		static readonly NativeHandle selMagentaComponentXHandle = Selector.GetHandle ("magentaComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfComponentsX = "numberOfComponents";
		static readonly NativeHandle selNumberOfComponentsXHandle = Selector.GetHandle ("numberOfComponents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrangeColorX = "orangeColor";
		static readonly NativeHandle selOrangeColorXHandle = Selector.GetHandle ("orangeColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPasteboardPropertyListForType_X = "pasteboardPropertyListForType:";
		static readonly NativeHandle selPasteboardPropertyListForType_XHandle = Selector.GetHandle ("pasteboardPropertyListForType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPatternImageX = "patternImage";
		static readonly NativeHandle selPatternImageXHandle = Selector.GetHandle ("patternImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaceholderTextColorX = "placeholderTextColor";
		static readonly NativeHandle selPlaceholderTextColorXHandle = Selector.GetHandle ("placeholderTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPurpleColorX = "purpleColor";
		static readonly NativeHandle selPurpleColorXHandle = Selector.GetHandle ("purpleColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuaternaryLabelColorX = "quaternaryLabelColor";
		static readonly NativeHandle selQuaternaryLabelColorXHandle = Selector.GetHandle ("quaternaryLabelColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuaternarySystemFillColorX = "quaternarySystemFillColor";
		static readonly NativeHandle selQuaternarySystemFillColorXHandle = Selector.GetHandle ("quaternarySystemFillColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuinaryLabelColorX = "quinaryLabelColor";
		static readonly NativeHandle selQuinaryLabelColorXHandle = Selector.GetHandle ("quinaryLabelColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuinarySystemFillColorX = "quinarySystemFillColor";
		static readonly NativeHandle selQuinarySystemFillColorXHandle = Selector.GetHandle ("quinarySystemFillColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadableTypesForPasteboard_X = "readableTypesForPasteboard:";
		static readonly NativeHandle selReadableTypesForPasteboard_XHandle = Selector.GetHandle ("readableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadingOptionsForType_Pasteboard_X = "readingOptionsForType:pasteboard:";
		static readonly NativeHandle selReadingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("readingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRedColorX = "redColor";
		static readonly NativeHandle selRedColorXHandle = Selector.GetHandle ("redColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRedComponentX = "redComponent";
		static readonly NativeHandle selRedComponentXHandle = Selector.GetHandle ("redComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaturationComponentX = "saturationComponent";
		static readonly NativeHandle selSaturationComponentXHandle = Selector.GetHandle ("saturationComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollBarColorX = "scrollBarColor";
		static readonly NativeHandle selScrollBarColorXHandle = Selector.GetHandle ("scrollBarColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrubberTexturedBackgroundColorX = "scrubberTexturedBackgroundColor";
		static readonly NativeHandle selScrubberTexturedBackgroundColorXHandle = Selector.GetHandle ("scrubberTexturedBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondaryLabelColorX = "secondaryLabelColor";
		static readonly NativeHandle selSecondaryLabelColorXHandle = Selector.GetHandle ("secondaryLabelColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondarySelectedControlColorX = "secondarySelectedControlColor";
		static readonly NativeHandle selSecondarySelectedControlColorXHandle = Selector.GetHandle ("secondarySelectedControlColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSecondarySystemFillColorX = "secondarySystemFillColor";
		static readonly NativeHandle selSecondarySystemFillColorXHandle = Selector.GetHandle ("secondarySystemFillColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedContentBackgroundColorX = "selectedContentBackgroundColor";
		static readonly NativeHandle selSelectedContentBackgroundColorXHandle = Selector.GetHandle ("selectedContentBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedControlColorX = "selectedControlColor";
		static readonly NativeHandle selSelectedControlColorXHandle = Selector.GetHandle ("selectedControlColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedControlTextColorX = "selectedControlTextColor";
		static readonly NativeHandle selSelectedControlTextColorXHandle = Selector.GetHandle ("selectedControlTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedKnobColorX = "selectedKnobColor";
		static readonly NativeHandle selSelectedKnobColorXHandle = Selector.GetHandle ("selectedKnobColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedMenuItemColorX = "selectedMenuItemColor";
		static readonly NativeHandle selSelectedMenuItemColorXHandle = Selector.GetHandle ("selectedMenuItemColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedMenuItemTextColorX = "selectedMenuItemTextColor";
		static readonly NativeHandle selSelectedMenuItemTextColorXHandle = Selector.GetHandle ("selectedMenuItemTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedTextBackgroundColorX = "selectedTextBackgroundColor";
		static readonly NativeHandle selSelectedTextBackgroundColorXHandle = Selector.GetHandle ("selectedTextBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedTextColorX = "selectedTextColor";
		static readonly NativeHandle selSelectedTextColorXHandle = Selector.GetHandle ("selectedTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeparatorColorX = "separatorColor";
		static readonly NativeHandle selSeparatorColorXHandle = Selector.GetHandle ("separatorColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetX = "set";
		static readonly NativeHandle selSetXHandle = Selector.GetHandle ("set");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFillX = "setFill";
		static readonly NativeHandle selSetFillXHandle = Selector.GetHandle ("setFill");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIgnoresAlpha_X = "setIgnoresAlpha:";
		static readonly NativeHandle selSetIgnoresAlpha_XHandle = Selector.GetHandle ("setIgnoresAlpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrokeX = "setStroke";
		static readonly NativeHandle selSetStrokeXHandle = Selector.GetHandle ("setStroke");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShadowColorX = "shadowColor";
		static readonly NativeHandle selShadowColorXHandle = Selector.GetHandle ("shadowColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShadowWithLevel_X = "shadowWithLevel:";
		static readonly NativeHandle selShadowWithLevel_XHandle = Selector.GetHandle ("shadowWithLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandardDynamicRangeColorX = "standardDynamicRangeColor";
		static readonly NativeHandle selStandardDynamicRangeColorXHandle = Selector.GetHandle ("standardDynamicRangeColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemBlueColorX = "systemBlueColor";
		static readonly NativeHandle selSystemBlueColorXHandle = Selector.GetHandle ("systemBlueColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemBrownColorX = "systemBrownColor";
		static readonly NativeHandle selSystemBrownColorXHandle = Selector.GetHandle ("systemBrownColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemCyanColorX = "systemCyanColor";
		static readonly NativeHandle selSystemCyanColorXHandle = Selector.GetHandle ("systemCyanColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemFillColorX = "systemFillColor";
		static readonly NativeHandle selSystemFillColorXHandle = Selector.GetHandle ("systemFillColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemGrayColorX = "systemGrayColor";
		static readonly NativeHandle selSystemGrayColorXHandle = Selector.GetHandle ("systemGrayColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemGreenColorX = "systemGreenColor";
		static readonly NativeHandle selSystemGreenColorXHandle = Selector.GetHandle ("systemGreenColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemIndigoColorX = "systemIndigoColor";
		static readonly NativeHandle selSystemIndigoColorXHandle = Selector.GetHandle ("systemIndigoColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemMintColorX = "systemMintColor";
		static readonly NativeHandle selSystemMintColorXHandle = Selector.GetHandle ("systemMintColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemOrangeColorX = "systemOrangeColor";
		static readonly NativeHandle selSystemOrangeColorXHandle = Selector.GetHandle ("systemOrangeColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemPinkColorX = "systemPinkColor";
		static readonly NativeHandle selSystemPinkColorXHandle = Selector.GetHandle ("systemPinkColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemPurpleColorX = "systemPurpleColor";
		static readonly NativeHandle selSystemPurpleColorXHandle = Selector.GetHandle ("systemPurpleColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemRedColorX = "systemRedColor";
		static readonly NativeHandle selSystemRedColorXHandle = Selector.GetHandle ("systemRedColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemTealColorX = "systemTealColor";
		static readonly NativeHandle selSystemTealColorXHandle = Selector.GetHandle ("systemTealColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemYellowColorX = "systemYellowColor";
		static readonly NativeHandle selSystemYellowColorXHandle = Selector.GetHandle ("systemYellowColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTertiaryLabelColorX = "tertiaryLabelColor";
		static readonly NativeHandle selTertiaryLabelColorXHandle = Selector.GetHandle ("tertiaryLabelColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTertiarySystemFillColorX = "tertiarySystemFillColor";
		static readonly NativeHandle selTertiarySystemFillColorXHandle = Selector.GetHandle ("tertiarySystemFillColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextBackgroundColorX = "textBackgroundColor";
		static readonly NativeHandle selTextBackgroundColorXHandle = Selector.GetHandle ("textBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextColorX = "textColor";
		static readonly NativeHandle selTextColorXHandle = Selector.GetHandle ("textColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextInsertionPointColorX = "textInsertionPointColor";
		static readonly NativeHandle selTextInsertionPointColorXHandle = Selector.GetHandle ("textInsertionPointColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeX = "type";
		static readonly NativeHandle selTypeXHandle = Selector.GetHandle ("type");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnderPageBackgroundColorX = "underPageBackgroundColor";
		static readonly NativeHandle selUnderPageBackgroundColorXHandle = Selector.GetHandle ("underPageBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnemphasizedSelectedContentBackgroundColorX = "unemphasizedSelectedContentBackgroundColor";
		static readonly NativeHandle selUnemphasizedSelectedContentBackgroundColorXHandle = Selector.GetHandle ("unemphasizedSelectedContentBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnemphasizedSelectedTextBackgroundColorX = "unemphasizedSelectedTextBackgroundColor";
		static readonly NativeHandle selUnemphasizedSelectedTextBackgroundColorXHandle = Selector.GetHandle ("unemphasizedSelectedTextBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnemphasizedSelectedTextColorX = "unemphasizedSelectedTextColor";
		static readonly NativeHandle selUnemphasizedSelectedTextColorXHandle = Selector.GetHandle ("unemphasizedSelectedTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWhiteColorX = "whiteColor";
		static readonly NativeHandle selWhiteColorXHandle = Selector.GetHandle ("whiteColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWhiteComponentX = "whiteComponent";
		static readonly NativeHandle selWhiteComponentXHandle = Selector.GetHandle ("whiteComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowBackgroundColorX = "windowBackgroundColor";
		static readonly NativeHandle selWindowBackgroundColorXHandle = Selector.GetHandle ("windowBackgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowFrameColorX = "windowFrameColor";
		static readonly NativeHandle selWindowFrameColorXHandle = Selector.GetHandle ("windowFrameColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowFrameTextColorX = "windowFrameTextColor";
		static readonly NativeHandle selWindowFrameTextColorXHandle = Selector.GetHandle ("windowFrameTextColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypesForPasteboard_X = "writableTypesForPasteboard:";
		static readonly NativeHandle selWritableTypesForPasteboard_XHandle = Selector.GetHandle ("writableTypesForPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToPasteboard_X = "writeToPasteboard:";
		static readonly NativeHandle selWriteToPasteboard_XHandle = Selector.GetHandle ("writeToPasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritingOptionsForType_Pasteboard_X = "writingOptionsForType:pasteboard:";
		static readonly NativeHandle selWritingOptionsForType_Pasteboard_XHandle = Selector.GetHandle ("writingOptionsForType:pasteboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYellowColorX = "yellowColor";
		static readonly NativeHandle selYellowColorXHandle = Selector.GetHandle ("yellowColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYellowComponentX = "yellowComponent";
		static readonly NativeHandle selYellowComponentXHandle = Selector.GetHandle ("yellowComponent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSColor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public NSColor (NSCoder coder) : base (NSObjectFlag.Empty)
		{
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
		protected NSColor (NSObjectFlag t) : base (t)
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
		protected internal NSColor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("blendedColorWithFraction:ofColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor BlendedColor (nfloat fraction, NSColor color)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			NSColor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_NativeHandle (this.Handle, selBlendedColorWithFraction_OfColor_XHandle, fraction, color__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_NativeHandle (&__objc_super__, selBlendedColorWithFraction_OfColor_XHandle, fraction, color__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
			return ret!;
		}
		[Export ("colorWithAlphaComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor ColorWithAlphaComponent (nfloat alpha)
		{
			NSColor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (this.Handle, selColorWithAlphaComponent_XHandle, alpha), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat (&__objc_super__, selColorWithAlphaComponent_XHandle, alpha), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("controlAlternatingRowBackgroundColors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Use 'AlternatingContentBackgroundColors' instead.")]
		public static NSColor[] ControlAlternatingRowBackgroundColors ()
		{
			NSColor[] ret;
			ret = CFArray.ArrayFromHandle<NSColor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlAlternatingRowBackgroundColorsXHandle), false)!;
			return ret;
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
		[Export ("drawSwatchInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawSwatchInRect (CGRect rect)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selDrawSwatchInRect_XHandle, rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selDrawSwatchInRect_XHandle, rect);
					GC.KeepAlive (this);
				}
			}
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
		[Export ("colorWithCGColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromCGColor (CGColor cgColor)
		{
			var cgColor__handle__ = cgColor!.GetNonNullHandle (nameof (cgColor));
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selColorWithCGColor_XHandle, cgColor.Handle), false)!;
			GC.KeepAlive (cgColor);
			return ret!;
		}
		[Export ("colorWithCIColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromCIColor (global::CoreImage.CIColor color)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selColorWithCIColor_XHandle, color__handle__), false)!;
			GC.KeepAlive (color);
			return ret!;
		}
		[Export ("colorWithCalibratedHue:saturation:brightness:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromCalibratedHsba (nfloat hue, nfloat saturation, nfloat brightness, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithCalibratedHue_Saturation_Brightness_Alpha_XHandle, hue, saturation, brightness, alpha), false)!;
			return ret;
		}
		[Export ("colorWithCalibratedRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromCalibratedRgba (nfloat red, nfloat green, nfloat blue, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithCalibratedRed_Green_Blue_Alpha_XHandle, red, green, blue, alpha), false)!;
			return ret;
		}
		[Export ("colorWithCalibratedWhite:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromCalibratedWhite (nfloat white, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat (class_ptr, selColorWithCalibratedWhite_Alpha_XHandle, white, alpha), false)!;
			return ret;
		}
		[Export ("colorWithCatalogName:colorName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromCatalogName (string listName, string colorName)
		{
			if (listName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (listName));
			if (colorName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (colorName));
			var nslistName = CFString.CreateNative (listName);
			var nscolorName = CFString.CreateNative (colorName);
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selColorWithCatalogName_ColorName_XHandle, nslistName, nscolorName), false)!;
			CFString.ReleaseNative (nslistName);
			CFString.ReleaseNative (nscolorName);
			return ret!;
		}
		[Export ("colorWithColorSpace:hue:saturation:brightness:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromColor (NSColorSpace space, nfloat hue, nfloat saturation, nfloat brightness, nfloat alpha)
		{
			var space__handle__ = space!.GetNonNullHandle (nameof (space));
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithColorSpace_Hue_Saturation_Brightness_Alpha_XHandle, space__handle__, hue, saturation, brightness, alpha), false)!;
			GC.KeepAlive (space);
			return ret!;
		}
		[Export ("colorForControlTint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Use 'NSColor.ControlAccentColor' instead.")]
		public static NSColor FromControlTint (NSControlTint controlTint)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, selColorForControlTint_XHandle, (UIntPtr) (ulong) controlTint), false)!;
			return ret;
		}
		[Export ("colorWithDeviceCyan:magenta:yellow:black:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromDeviceCymka (nfloat cyan, nfloat magenta, nfloat yellow, nfloat black, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithDeviceCyan_Magenta_Yellow_Black_Alpha_XHandle, cyan, magenta, yellow, black, alpha), false)!;
			return ret;
		}
		[Export ("colorWithDeviceHue:saturation:brightness:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromDeviceHsba (nfloat hue, nfloat saturation, nfloat brightness, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithDeviceHue_Saturation_Brightness_Alpha_XHandle, hue, saturation, brightness, alpha), false)!;
			return ret;
		}
		[Export ("colorWithDeviceRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromDeviceRgba (nfloat red, nfloat green, nfloat blue, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithDeviceRed_Green_Blue_Alpha_XHandle, red, green, blue, alpha), false)!;
			return ret;
		}
		[Export ("colorWithDeviceWhite:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromDeviceWhite (nfloat white, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat (class_ptr, selColorWithDeviceWhite_Alpha_XHandle, white, alpha), false)!;
			return ret;
		}
		[Export ("colorWithDisplayP3Red:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromDisplayP3 (nfloat red, nfloat green, nfloat blue, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithDisplayP3Red_Green_Blue_Alpha_XHandle, red, green, blue, alpha), false)!;
			return ret;
		}
		[Export ("colorWithGenericGamma22White:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromGamma22White (nfloat white, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat (class_ptr, selColorWithGenericGamma22White_Alpha_XHandle, white, alpha), false)!;
			return ret;
		}
		[Export ("colorWithHue:saturation:brightness:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromHsba (nfloat hue, nfloat saturation, nfloat brightness, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithHue_Saturation_Brightness_Alpha_XHandle, hue, saturation, brightness, alpha), false)!;
			return ret;
		}
		[Export ("colorNamed:bundle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor? FromName (string name, NSBundle? bundle)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var bundle__handle__ = bundle.GetHandle ();
			var nsname = CFString.CreateNative (name);
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selColorNamed_Bundle_XHandle, nsname, bundle__handle__), false)!;
			GC.KeepAlive (bundle);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("colorNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor? FromName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selColorNamed_XHandle, nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("colorFromPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromPasteboard (NSPasteboard pasteBoard)
		{
			var pasteBoard__handle__ = pasteBoard!.GetNonNullHandle (nameof (pasteBoard));
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selColorFromPasteboard_XHandle, pasteBoard__handle__), false)!;
			GC.KeepAlive (pasteBoard);
			return ret!;
		}
		[Export ("colorWithPatternImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromPatternImage (NSImage image)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selColorWithPatternImage_XHandle, image__handle__), false)!;
			GC.KeepAlive (image);
			return ret!;
		}
		[Export ("colorWithRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromRgba (nfloat red, nfloat green, nfloat blue, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithRed_Green_Blue_Alpha_XHandle, red, green, blue, alpha), false)!;
			return ret;
		}
		[Export ("colorWithRed:green:blue:alpha:exposure:")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromRgbaExposure (nfloat red, nfloat green, nfloat blue, nfloat alpha, nfloat exposure)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithRed_Green_Blue_Alpha_Exposure_XHandle, red, green, blue, alpha, exposure), false)!;
			return ret;
		}
		[Export ("colorWithRed:green:blue:alpha:linearExposure:")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromRgbaLinearExposure (nfloat red, nfloat green, nfloat blue, nfloat alpha, nfloat linearExposure)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithRed_Green_Blue_Alpha_LinearExposure_XHandle, red, green, blue, alpha, linearExposure), false)!;
			return ret;
		}
		[Export ("colorWithSRGBRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromSrgb (nfloat red, nfloat green, nfloat blue, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_nfloat (class_ptr, selColorWithSRGBRed_Green_Blue_Alpha_XHandle, red, green, blue, alpha), false)!;
			return ret;
		}
		[Export ("colorWithSystemEffect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor FromSystemEffect (NSColorSystemEffect systemEffect)
		{
			NSColor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selColorWithSystemEffect_XHandle, (IntPtr) (long) systemEffect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selColorWithSystemEffect_XHandle, (IntPtr) (long) systemEffect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("colorWithWhite:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FromWhite (nfloat white, nfloat alpha)
		{
			NSColor ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat (class_ptr, selColorWithWhite_Alpha_XHandle, white, alpha), false)!;
			return ret;
		}
		[Export ("getCyan:magenta:yellow:black:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetCmyka (out nfloat cyan, out nfloat magenta, out nfloat yellow, out nfloat black, out nfloat alpha)
		{
			fixed (nfloat* cyan__pointer = &cyan) {
			fixed (nfloat* magenta__pointer = &magenta) {
			fixed (nfloat* yellow__pointer = &yellow) {
			fixed (nfloat* black__pointer = &black) {
			fixed (nfloat* alpha__pointer = &alpha) {
			cyan = default;
			magenta = default;
			yellow = default;
			black = default;
			alpha = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_NFloat_out_NFloat_out_NFloat_out_NFloat_out_NFloat (this.Handle, selGetCyan_Magenta_Yellow_Black_Alpha_XHandle, cyan__pointer, magenta__pointer, yellow__pointer, black__pointer, alpha__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_NFloat_out_NFloat_out_NFloat_out_NFloat_out_NFloat (&__objc_super__, selGetCyan_Magenta_Yellow_Black_Alpha_XHandle, cyan__pointer, magenta__pointer, yellow__pointer, black__pointer, alpha__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
			}
			}
			}
		}
		[Export ("colorUsingType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor? GetColor (NSColorType type)
		{
			NSColor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selColorUsingType_XHandle, (IntPtr) (long) type), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selColorUsingType_XHandle, (IntPtr) (long) type), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("colorWithName:dynamicProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSColor GetColor (string? colorName, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V1))]global::System.Func<global::AppKit.NSAppearance, NSColor> dynamicProvider)
		{
			if (dynamicProvider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dynamicProvider));
			var nscolorName = CFString.CreateNative (colorName);
			using var block_dynamicProvider = Trampolines.SDFuncArity2V1.CreateBlock (dynamicProvider);
			BlockLiteral *block_ptr_dynamicProvider = &block_dynamicProvider;
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selColorWithName_DynamicProvider_XHandle, nscolorName, (IntPtr) block_ptr_dynamicProvider), false)!;
			CFString.ReleaseNative (nscolorName);
			return ret!;
		}
		[Export ("colorByApplyingContentHeadroom:")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor GetColorByApplyingContentHeadroom (nfloat contentHeadroom)
		{
			NSColor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (this.Handle, selColorByApplyingContentHeadroom_XHandle, contentHeadroom), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat (&__objc_super__, selColorByApplyingContentHeadroom_XHandle, contentHeadroom), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("getHue:saturation:brightness:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetHsba (out nfloat hue, out nfloat saturation, out nfloat brightness, out nfloat alpha)
		{
			fixed (nfloat* hue__pointer = &hue) {
			fixed (nfloat* saturation__pointer = &saturation) {
			fixed (nfloat* brightness__pointer = &brightness) {
			fixed (nfloat* alpha__pointer = &alpha) {
			hue = default;
			saturation = default;
			brightness = default;
			alpha = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_NFloat_out_NFloat_out_NFloat_out_NFloat (this.Handle, selGetHue_Saturation_Brightness_Alpha_XHandle, hue__pointer, saturation__pointer, brightness__pointer, alpha__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_NFloat_out_NFloat_out_NFloat_out_NFloat (&__objc_super__, selGetHue_Saturation_Brightness_Alpha_XHandle, hue__pointer, saturation__pointer, brightness__pointer, alpha__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
			}
			}
		}
		/// <param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pasteboardPropertyListForType:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetPasteboardPropertyListForType (string type)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPasteboardPropertyListForType_XHandle, nstype), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPasteboardPropertyListForType_XHandle, nstype), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readableTypesForPasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetReadableTypesForPasteboard (NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selReadableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("readingOptionsForType:pasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPasteboardReadingOptions GetReadingOptionsForType (string type, NSPasteboard pasteboard)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			NSPasteboardReadingOptions ret;
			ret = (NSPasteboardReadingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selReadingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("getRed:green:blue:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetRgba (out nfloat red, out nfloat green, out nfloat blue, out nfloat alpha)
		{
			fixed (nfloat* red__pointer = &red) {
			fixed (nfloat* green__pointer = &green) {
			fixed (nfloat* blue__pointer = &blue) {
			fixed (nfloat* alpha__pointer = &alpha) {
			red = default;
			green = default;
			blue = default;
			alpha = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_NFloat_out_NFloat_out_NFloat_out_NFloat (this.Handle, selGetRed_Green_Blue_Alpha_XHandle, red__pointer, green__pointer, blue__pointer, alpha__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_NFloat_out_NFloat_out_NFloat_out_NFloat (&__objc_super__, selGetRed_Green_Blue_Alpha_XHandle, red__pointer, green__pointer, blue__pointer, alpha__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
			}
			}
		}
		[Export ("getWhite:alpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetWhiteAlpha (out nfloat white, out nfloat alpha)
		{
			fixed (nfloat* white__pointer = &white) {
			fixed (nfloat* alpha__pointer = &alpha) {
			white = default;
			alpha = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_NFloat_out_NFloat (this.Handle, selGetWhite_Alpha_XHandle, white__pointer, alpha__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_NFloat_out_NFloat (&__objc_super__, selGetWhite_Alpha_XHandle, white__pointer, alpha__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
		}
		/// <param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writableTypesForPasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetWritableTypesForPasteboard (NSPasteboard pasteboard)
		{
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selWritableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selWritableTypesForPasteboard_XHandle, pasteboard__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="pasteboard">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writingOptionsForType:pasteboard:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPasteboardWritingOptions GetWritingOptionsForType (string type, NSPasteboard pasteboard)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var pasteboard__handle__ = pasteboard!.GetNonNullHandle (nameof (pasteboard));
			var nstype = CFString.CreateNative (type);
			NSPasteboardWritingOptions ret;
			if (IsDirectBinding) {
				ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selWritingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSPasteboardWritingOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selWritingOptionsForType_Pasteboard_XHandle, nstype, pasteboard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteboard);
			CFString.ReleaseNative (nstype);
			return ret!;
		}
		[Export ("highlightWithLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor HighlightWithLevel (nfloat highlightLevel)
		{
			NSColor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (this.Handle, selHighlightWithLevel_XHandle, highlightLevel), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat (&__objc_super__, selHighlightWithLevel_XHandle, highlightLevel), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("set")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Set ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setFill")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFill ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetFillXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetFillXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setStroke")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetStroke ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetStrokeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetStrokeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("shadowWithLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor ShadowWithLevel (nfloat shadowLevel)
		{
			NSColor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (this.Handle, selShadowWithLevel_XHandle, shadowLevel), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat (&__objc_super__, selShadowWithLevel_XHandle, shadowLevel), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("colorUsingColorSpaceName:")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'GetColor' or 'UsingColorSpace' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor UsingColorSpace (string? colorSpaceName)
		{
			var nscolorSpaceName = CFString.CreateNative (colorSpaceName);
			NSColor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selColorUsingColorSpaceName_XHandle, nscolorSpaceName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selColorUsingColorSpaceName_XHandle, nscolorSpaceName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscolorSpaceName);
			return ret!;
		}
		[Export ("colorUsingColorSpaceName:device:")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'GetColor' or 'UsingColorSpace' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor UsingColorSpace (string? colorSpaceName, NSDictionary? deviceDescription)
		{
			var deviceDescription__handle__ = deviceDescription.GetHandle ();
			var nscolorSpaceName = CFString.CreateNative (colorSpaceName);
			NSColor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selColorUsingColorSpaceName_Device_XHandle, nscolorSpaceName, deviceDescription__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selColorUsingColorSpaceName_Device_XHandle, nscolorSpaceName, deviceDescription__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (deviceDescription);
			CFString.ReleaseNative (nscolorSpaceName);
			return ret!;
		}
		[Export ("colorUsingColorSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColor UsingColorSpace (NSColorSpace colorSpace)
		{
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			NSColor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selColorUsingColorSpace_XHandle, colorSpace__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selColorUsingColorSpace_XHandle, colorSpace__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		[Export ("writeToPasteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteToPasteboard (NSPasteboard pasteBoard)
		{
			var pasteBoard__handle__ = pasteBoard!.GetNonNullHandle (nameof (pasteBoard));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selWriteToPasteboard_XHandle, pasteBoard__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selWriteToPasteboard_XHandle, pasteBoard__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pasteBoard);
		}
		[Export ("colorWithColorSpace:components:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSColor _FromColorSpace (NSColorSpace space, nint components, nint numberOfComponents)
		{
			var space__handle__ = space!.GetNonNullHandle (nameof (space));
			NSColor? ret;
			ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (class_ptr, selColorWithColorSpace_Components_Count_XHandle, space__handle__, components, numberOfComponents), false)!;
			GC.KeepAlive (space);
			return ret!;
		}
		[Export ("getComponents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _GetComponents (nint components)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selGetComponents_XHandle, components);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selGetComponents_XHandle, components);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string AccessibilityName {
			[Export ("accessibilityName")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat AlphaComponent {
			[Export ("alphaComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selAlphaComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selAlphaComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos", "Use 'SelectedContentBackgroundColor' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor AlternateSelectedControl {
			[Export ("alternateSelectedControlColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAlternateSelectedControlColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor AlternateSelectedControlText {
			[Export ("alternateSelectedControlTextColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAlternateSelectedControlTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor[] AlternatingContentBackgroundColors {
			[Export ("alternatingContentBackgroundColors", ArgumentSemantic.Retain)]
			get {
				NSColor[]? ret;
				ret = CFArray.ArrayFromHandle<NSColor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAlternatingContentBackgroundColorsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Black {
			[Export ("blackColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selBlackColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat BlackComponent {
			[Export ("blackComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selBlackComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selBlackComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Blue {
			[Export ("blueColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selBlueColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat BlueComponent {
			[Export ("blueComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selBlueComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selBlueComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat BrightnessComponent {
			[Export ("brightnessComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selBrightnessComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selBrightnessComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Brown {
			[Export ("brownColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selBrownColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGColor CGColor {
			[Export ("CGColor")]
			get {
				CGColor ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCGColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCGColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual string CatalogNameComponent {
			[Export ("catalogNameComponent")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCatalogNameComponentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCatalogNameComponentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Clear {
			[Export ("clearColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selClearColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual string ColorNameComponent {
			[Export ("colorNameComponent")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorNameComponentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorNameComponentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual NSColorSpace ColorSpace {
			[Export ("colorSpace")]
			get {
				NSColorSpace? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorSpaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSColorSpace> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorSpaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Use 'Type' and 'NSColorType' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string ColorSpaceName {
			[Export ("colorSpaceName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorSpaceNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorSpaceNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint ComponentCount {
			[Export ("numberOfComponents")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfComponentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfComponentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Control {
			[Export ("controlColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor ControlAccent {
			[Export ("controlAccentColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlAccentColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor ControlBackground {
			[Export ("controlBackgroundColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlBackgroundColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use a context specific color such as 'SeparatorColor'.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor ControlDarkShadow {
			[Export ("controlDarkShadowColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlDarkShadowColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use a context specific color such as 'SeparatorColor'.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor ControlHighlight {
			[Export ("controlHighlightColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlHighlightColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use a context specific color such as 'SeparatorColor'.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor ControlLightHighlight {
			[Export ("controlLightHighlightColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlLightHighlightColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use a context specific color such as 'SeparatorColor'.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor ControlShadow {
			[Export ("controlShadowColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlShadowColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor ControlText {
			[Export ("controlTextColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSControlTint CurrentControlTint {
			[Export ("currentControlTint")]
			get {
				NSControlTint ret;
				ret = (NSControlTint) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selCurrentControlTintXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Cyan {
			[Export ("cyanColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCyanColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat CyanComponent {
			[Export ("cyanComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selCyanComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selCyanComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor DarkGray {
			[Export ("darkGrayColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDarkGrayColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor DisabledControlText {
			[Export ("disabledControlTextColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDisabledControlTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor FindHighlight {
			[Export ("findHighlightColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFindHighlightColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Gray {
			[Export ("grayColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGrayColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Green {
			[Export ("greenColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGreenColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GreenComponent {
			[Export ("greenComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selGreenComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selGreenComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Grid {
			[Export ("gridColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGridColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSVisualEffectMaterial.Title' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor Header {
			[Export ("headerColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHeaderColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor HeaderText {
			[Export ("headerTextColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHeaderTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Highlight {
			[Export ("highlightColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHighlightColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat HueComponent {
			[Export ("hueComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selHueComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selHueComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IgnoresAlpha {
			[Export ("ignoresAlpha")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIgnoresAlphaXHandle);
				return ret != 0;
			}
			[Export ("setIgnoresAlpha:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetIgnoresAlpha_XHandle, value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor KeyboardFocusIndicator {
			[Export ("keyboardFocusIndicatorColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selKeyboardFocusIndicatorColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSScroller' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor Knob {
			[Export ("knobColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selKnobColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Label {
			[Export ("labelColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLabelColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor LightGray {
			[Export ("lightGrayColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLightGrayColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual nfloat LinearExposure {
			[Export ("linearExposure")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selLinearExposureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selLinearExposureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Link {
			[Export ("linkColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLinkColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual string LocalizedCatalogNameComponent {
			[Export ("localizedCatalogNameComponent")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedCatalogNameComponentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedCatalogNameComponentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual string LocalizedColorNameComponent {
			[Export ("localizedColorNameComponent")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedColorNameComponentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedColorNameComponentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Magenta {
			[Export ("magentaColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMagentaColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MagentaComponent {
			[Export ("magentaComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selMagentaComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selMagentaComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Orange {
			[Export ("orangeColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selOrangeColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual NSImage PatternImage {
			[Export ("patternImage")]
			get {
				NSImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPatternImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPatternImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor PlaceholderText {
			[Export ("placeholderTextColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPlaceholderTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Purple {
			[Export ("purpleColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPurpleColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor QuaternaryLabel {
			[Export ("quaternaryLabelColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selQuaternaryLabelColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSColor QuaternarySystemFill {
			[Export ("quaternarySystemFillColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selQuaternarySystemFillColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSColor QuinaryLabel {
			[Export ("quinaryLabelColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selQuinaryLabelColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSColor QuinarySystemFill {
			[Export ("quinarySystemFillColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selQuinarySystemFillColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Red {
			[Export ("redColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRedColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RedComponent {
			[Export ("redComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selRedComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selRedComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat SaturationComponent {
			[Export ("saturationComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selSaturationComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selSaturationComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSScroller' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor ScrollBar {
			[Export ("scrollBarColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selScrollBarColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor ScrubberTexturedBackground {
			[Export ("scrubberTexturedBackgroundColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selScrubberTexturedBackgroundColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SecondaryLabel {
			[Export ("secondaryLabelColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSecondaryLabelColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos", "Use 'SelectedContentBackgroundColor' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor SecondarySelectedControl {
			[Export ("secondarySelectedControlColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSecondarySelectedControlColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSColor SecondarySystemFill {
			[Export ("secondarySystemFillColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSecondarySystemFillColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SelectedContentBackground {
			[Export ("selectedContentBackgroundColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSelectedContentBackgroundColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SelectedControl {
			[Export ("selectedControlColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSelectedControlColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SelectedControlText {
			[Export ("selectedControlTextColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSelectedControlTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSScroller' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor SelectedKnob {
			[Export ("selectedKnobColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSelectedKnobColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSVisualEffectMaterial.Title' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor SelectedMenuItem {
			[Export ("selectedMenuItemColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSelectedMenuItemColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SelectedMenuItemText {
			[Export ("selectedMenuItemTextColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSelectedMenuItemTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SelectedText {
			[Export ("selectedTextColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSelectedTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SelectedTextBackground {
			[Export ("selectedTextBackgroundColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSelectedTextBackgroundColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Separator {
			[Export ("separatorColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSeparatorColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Shadow {
			[Export ("shadowColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selShadowColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual NSColor StandardDynamicRangeColor {
			[Export ("standardDynamicRangeColor", ArgumentSemantic.Copy)]
			get {
				NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStandardDynamicRangeColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStandardDynamicRangeColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemBlue {
			[Export ("systemBlueColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemBlueColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemBrown {
			[Export ("systemBrownColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemBrownColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemCyan {
			[Export ("systemCyanColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemCyanColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSColor SystemFill {
			[Export ("systemFillColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemFillColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemGray {
			[Export ("systemGrayColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemGrayColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemGreen {
			[Export ("systemGreenColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemGreenColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemIndigo {
			[Export ("systemIndigoColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemIndigoColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemMint {
			[Export ("systemMintColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemMintColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemOrange {
			[Export ("systemOrangeColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemOrangeColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemPink {
			[Export ("systemPinkColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemPinkColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemPurple {
			[Export ("systemPurpleColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemPurpleColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemRed {
			[Export ("systemRedColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemRedColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemTeal {
			[Export ("systemTealColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemTealColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor SystemYellow {
			[Export ("systemYellowColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemYellowColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor TertiaryLabel {
			[Export ("tertiaryLabelColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTertiaryLabelColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSColor TertiarySystemFill {
			[Export ("tertiarySystemFillColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTertiarySystemFillColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Text {
			[Export ("textColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor TextBackground {
			[Export ("textBackgroundColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTextBackgroundColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public static NSColor TextInsertionPoint {
			[Export ("textInsertionPointColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selTextInsertionPointColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColorType Type {
			[Export ("type")]
			get {
				NSColorType ret;
				if (IsDirectBinding) {
					ret = (NSColorType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSColorType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor UnderPageBackground {
			[Export ("underPageBackgroundColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selUnderPageBackgroundColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor UnemphasizedSelectedContentBackground {
			[Export ("unemphasizedSelectedContentBackgroundColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selUnemphasizedSelectedContentBackgroundColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor UnemphasizedSelectedText {
			[Export ("unemphasizedSelectedTextColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selUnemphasizedSelectedTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor UnemphasizedSelectedTextBackground {
			[Export ("unemphasizedSelectedTextBackgroundColor", ArgumentSemantic.Retain)]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selUnemphasizedSelectedTextBackgroundColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor White {
			[Export ("whiteColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWhiteColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat WhiteComponent {
			[Export ("whiteComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selWhiteComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selWhiteComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor WindowBackground {
			[Export ("windowBackgroundColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWindowBackgroundColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos11.0", "Use 'NSVisualEffectMaterial.Title' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSColor WindowFrame {
			[Export ("windowFrameColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWindowFrameColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor WindowFrameText {
			[Export ("windowFrameTextColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWindowFrameTextColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSColor Yellow {
			[Export ("yellowColor")]
			get {
				NSColor? ret;
				ret =  Runtime.GetNSObject<NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selYellowColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat YellowComponent {
			[Export ("yellowComponent")]
			get {
				IntPtr exception_gchandle = IntPtr.Zero;
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSend_exception (this.Handle, selYellowComponentXHandle, &exception_gchandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_nfloat_objc_msgSendSuper_exception (&__objc_super__, selYellowComponentXHandle, &exception_gchandle);
						GC.KeepAlive (this);
					}
				}
				Runtime.ThrowException (exception_gchandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SystemColorsChanged;
		/// <summary>Notification constant for SystemColorsChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveSystemColorsChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveSystemColorsChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSColor.Notifications.ObserveSystemColorsChanged ((sender, args) => {
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
		/// void Callback (object sender, NSColor.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSColor.Notifications.ObserveSystemColorsChanged (Callback);
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
		///     NSColor.SystemColorsChangedNotification, (notification) => { Console.WriteLine ("Received the notification SystemColorsChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification SystemColorsChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSColor.SystemColorsChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSSystemColorsDidChangeNotification",  "AppKit")]
		[Advice ("Use NSColor.Notifications.ObserveSystemColorsChanged helper method instead.")]
		public static NSString SystemColorsChanged {
			get {
				if (_SystemColorsChanged is null)
					_SystemColorsChanged = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSSystemColorsDidChangeNotification")!;
				return _SystemColorsChanged;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSColor" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSColor.SystemColorsChanged" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSColor.SystemColorsChanged" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSColor.Notifications.ObserveSystemColorsChanged ((notification) => {
			///   Console.WriteLine ("Observed SystemColorsChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSystemColorsChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SystemColorsChanged, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSColor.SystemColorsChanged" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSColor.SystemColorsChanged" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSColor.Notifications.ObserveSystemColorsChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed SystemColorsChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveSystemColorsChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SystemColorsChanged, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSColor */
}
