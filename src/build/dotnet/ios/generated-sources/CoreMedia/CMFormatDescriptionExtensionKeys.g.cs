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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreMedia {
	public unsafe static partial class CMFormatDescriptionExtensionKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlphaChannelMode;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_AlphaChannelMode'.</summary>
		[Field ("kCMFormatDescriptionExtension_AlphaChannelMode",  "CoreMedia")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString AlphaChannelMode {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_AlphaChannelMode is null)
					_AlphaChannelMode = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_AlphaChannelMode")!;
				return _AlphaChannelMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlternativeTransferCharacteristics;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_AlternativeTransferCharacteristics'.</summary>
		[Field ("kCMFormatDescriptionExtension_AlternativeTransferCharacteristics",  "CoreMedia")]
		public static NSString AlternativeTransferCharacteristics {
			get {
				if (_AlternativeTransferCharacteristics is null)
					_AlternativeTransferCharacteristics = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_AlternativeTransferCharacteristics")!;
				return _AlternativeTransferCharacteristics;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AmbientViewingEnvironment;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_AmbientViewingEnvironment'.</summary>
		[Field ("kCMFormatDescriptionExtension_AmbientViewingEnvironment",  "CoreMedia")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString AmbientViewingEnvironment {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_AmbientViewingEnvironment is null)
					_AmbientViewingEnvironment = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_AmbientViewingEnvironment")!;
				return _AmbientViewingEnvironment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuxiliaryTypeInfo;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_AuxiliaryTypeInfo'.</summary>
		[Field ("kCMFormatDescriptionExtension_AuxiliaryTypeInfo",  "CoreMedia")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString AuxiliaryTypeInfo {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_AuxiliaryTypeInfo is null)
					_AuxiliaryTypeInfo = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_AuxiliaryTypeInfo")!;
				return _AuxiliaryTypeInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BitsPerComponent;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_BitsPerComponent'.</summary>
		[Field ("kCMFormatDescriptionExtension_BitsPerComponent",  "CoreMedia")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString BitsPerComponent {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_BitsPerComponent is null)
					_BitsPerComponent = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_BitsPerComponent")!;
				return _BitsPerComponent;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BytesPerRow;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_BytesPerRow'.</summary>
		[Field ("kCMFormatDescriptionExtension_BytesPerRow",  "CoreMedia")]
		public static NSString BytesPerRow {
			get {
				if (_BytesPerRow is null)
					_BytesPerRow = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_BytesPerRow")!;
				return _BytesPerRow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CameraCalibrationDataLensCollection;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_CameraCalibrationDataLensCollection'.</summary>
		[Field ("kCMFormatDescriptionExtension_CameraCalibrationDataLensCollection",  "CoreMedia")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString CameraCalibrationDataLensCollection {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_CameraCalibrationDataLensCollection is null)
					_CameraCalibrationDataLensCollection = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_CameraCalibrationDataLensCollection")!;
				return _CameraCalibrationDataLensCollection;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocationBottomField;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ChromaLocationBottomField'.</summary>
		[Field ("kCMFormatDescriptionExtension_ChromaLocationBottomField",  "CoreMedia")]
		public static NSString ChromaLocationBottomField {
			get {
				if (_ChromaLocationBottomField is null)
					_ChromaLocationBottomField = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ChromaLocationBottomField")!;
				return _ChromaLocationBottomField;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocationTopField;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ChromaLocationTopField'.</summary>
		[Field ("kCMFormatDescriptionExtension_ChromaLocationTopField",  "CoreMedia")]
		public static NSString ChromaLocationTopField {
			get {
				if (_ChromaLocationTopField is null)
					_ChromaLocationTopField = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ChromaLocationTopField")!;
				return _ChromaLocationTopField;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanAperture;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_CleanAperture'.</summary>
		[Field ("kCMFormatDescriptionExtension_CleanAperture",  "CoreMedia")]
		public static NSString CleanAperture {
			get {
				if (_CleanAperture is null)
					_CleanAperture = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_CleanAperture")!;
				return _CleanAperture;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorPrimaries;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ColorPrimaries'.</summary>
		[Field ("kCMFormatDescriptionExtension_ColorPrimaries",  "CoreMedia")]
		public static NSString ColorPrimaries {
			get {
				if (_ColorPrimaries is null)
					_ColorPrimaries = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ColorPrimaries")!;
				return _ColorPrimaries;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ConformsToMPEG2VideoProfile;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionConformsToMPEG2VideoProfile'.</summary>
		[Field ("kCMFormatDescriptionConformsToMPEG2VideoProfile",  "CoreMedia")]
		public static NSString ConformsToMPEG2VideoProfile {
			get {
				if (_ConformsToMPEG2VideoProfile is null)
					_ConformsToMPEG2VideoProfile = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionConformsToMPEG2VideoProfile")!;
				return _ConformsToMPEG2VideoProfile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContainsAlphaChannel;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ContainsAlphaChannel'.</summary>
		[Field ("kCMFormatDescriptionExtension_ContainsAlphaChannel",  "CoreMedia")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString ContainsAlphaChannel {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_ContainsAlphaChannel is null)
					_ContainsAlphaChannel = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ContainsAlphaChannel")!;
				return _ContainsAlphaChannel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentColorVolume;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ContentColorVolume'.</summary>
		[Field ("kCMFormatDescriptionExtension_ContentColorVolume",  "CoreMedia")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString ContentColorVolume {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_ContentColorVolume is null)
					_ContentColorVolume = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ContentColorVolume")!;
				return _ContentColorVolume;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentLightLevelInfo;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ContentLightLevelInfo'.</summary>
		[Field ("kCMFormatDescriptionExtension_ContentLightLevelInfo",  "CoreMedia")]
		public static NSString ContentLightLevelInfo {
			get {
				if (_ContentLightLevelInfo is null)
					_ContentLightLevelInfo = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ContentLightLevelInfo")!;
				return _ContentLightLevelInfo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Depth;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_Depth'.</summary>
		[Field ("kCMFormatDescriptionExtension_Depth",  "CoreMedia")]
		public static NSString Depth {
			get {
				if (_Depth is null)
					_Depth = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_Depth")!;
				return _Depth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldCount;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_FieldCount'.</summary>
		[Field ("kCMFormatDescriptionExtension_FieldCount",  "CoreMedia")]
		public static NSString FieldCount {
			get {
				if (_FieldCount is null)
					_FieldCount = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_FieldCount")!;
				return _FieldCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldDetail;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_FieldDetail'.</summary>
		[Field ("kCMFormatDescriptionExtension_FieldDetail",  "CoreMedia")]
		public static NSString FieldDetail {
			get {
				if (_FieldDetail is null)
					_FieldDetail = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_FieldDetail")!;
				return _FieldDetail;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FormatName;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_FormatName'.</summary>
		[Field ("kCMFormatDescriptionExtension_FormatName",  "CoreMedia")]
		public static NSString FormatName {
			get {
				if (_FormatName is null)
					_FormatName = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_FormatName")!;
				return _FormatName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FullRangeVideo;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_FullRangeVideo'.</summary>
		[Field ("kCMFormatDescriptionExtension_FullRangeVideo",  "CoreMedia")]
		public static NSString FullRangeVideo {
			get {
				if (_FullRangeVideo is null)
					_FullRangeVideo = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_FullRangeVideo")!;
				return _FullRangeVideo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GammaLevel;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_GammaLevel'.</summary>
		[Field ("kCMFormatDescriptionExtension_GammaLevel",  "CoreMedia")]
		public static NSString GammaLevel {
			get {
				if (_GammaLevel is null)
					_GammaLevel = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_GammaLevel")!;
				return _GammaLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasAdditionalViews;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_HasAdditionalViews'.</summary>
		[Field ("kCMFormatDescriptionExtension_HasAdditionalViews",  "CoreMedia")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString HasAdditionalViews {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_HasAdditionalViews is null)
					_HasAdditionalViews = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_HasAdditionalViews")!;
				return _HasAdditionalViews;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasLeftStereoEyeView;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_HasLeftStereoEyeView'.</summary>
		[Field ("kCMFormatDescriptionExtension_HasLeftStereoEyeView",  "CoreMedia")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString HasLeftStereoEyeView {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_HasLeftStereoEyeView is null)
					_HasLeftStereoEyeView = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_HasLeftStereoEyeView")!;
				return _HasLeftStereoEyeView;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HasRightStereoEyeView;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_HasRightStereoEyeView'.</summary>
		[Field ("kCMFormatDescriptionExtension_HasRightStereoEyeView",  "CoreMedia")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString HasRightStereoEyeView {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_HasRightStereoEyeView is null)
					_HasRightStereoEyeView = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_HasRightStereoEyeView")!;
				return _HasRightStereoEyeView;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HeroEye;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_HeroEye'.</summary>
		[Field ("kCMFormatDescriptionExtension_HeroEye",  "CoreMedia")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString HeroEye {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_HeroEye is null)
					_HeroEye = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_HeroEye")!;
				return _HeroEye;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalDisparityAdjustment;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_HorizontalDisparityAdjustment'.</summary>
		[Field ("kCMFormatDescriptionExtension_HorizontalDisparityAdjustment",  "CoreMedia")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString HorizontalDisparityAdjustment {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_HorizontalDisparityAdjustment is null)
					_HorizontalDisparityAdjustment = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_HorizontalDisparityAdjustment")!;
				return _HorizontalDisparityAdjustment;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HorizontalFieldOfView;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_HorizontalFieldOfView'.</summary>
		[Field ("kCMFormatDescriptionExtension_HorizontalFieldOfView",  "CoreMedia")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString HorizontalFieldOfView {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_HorizontalFieldOfView is null)
					_HorizontalFieldOfView = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_HorizontalFieldOfView")!;
				return _HorizontalFieldOfView;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ICCProfile;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ICCProfile'.</summary>
		[Field ("kCMFormatDescriptionExtension_ICCProfile",  "CoreMedia")]
		public static NSString ICCProfile {
			get {
				if (_ICCProfile is null)
					_ICCProfile = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ICCProfile")!;
				return _ICCProfile;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LogTransferFunction;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_LogTransferFunction'.</summary>
		[Field ("kCMFormatDescriptionExtension_LogTransferFunction",  "CoreMedia")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		public static NSString LogTransferFunction {
			[SupportedOSPlatform ("ios17.2")]
			[SupportedOSPlatform ("tvos17.2")]
			[SupportedOSPlatform ("macos14.2")]
			[SupportedOSPlatform ("maccatalyst17.2")]
			get {
				if (_LogTransferFunction is null)
					_LogTransferFunction = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_LogTransferFunction")!;
				return _LogTransferFunction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MasteringDisplayColorVolume;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_MasteringDisplayColorVolume'.</summary>
		[Field ("kCMFormatDescriptionExtension_MasteringDisplayColorVolume",  "CoreMedia")]
		public static NSString MasteringDisplayColorVolume {
			get {
				if (_MasteringDisplayColorVolume is null)
					_MasteringDisplayColorVolume = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_MasteringDisplayColorVolume")!;
				return _MasteringDisplayColorVolume;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MetadataKeyTable;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtensionKey_MetadataKeyTable'.</summary>
		[Field ("kCMFormatDescriptionExtensionKey_MetadataKeyTable",  "CoreMedia")]
		public static NSString MetadataKeyTable {
			get {
				if (_MetadataKeyTable is null)
					_MetadataKeyTable = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtensionKey_MetadataKeyTable")!;
				return _MetadataKeyTable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OriginalCompressionSettings;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_OriginalCompressionSettings'.</summary>
		[Field ("kCMFormatDescriptionExtension_OriginalCompressionSettings",  "CoreMedia")]
		public static NSString OriginalCompressionSettings {
			get {
				if (_OriginalCompressionSettings is null)
					_OriginalCompressionSettings = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_OriginalCompressionSettings")!;
				return _OriginalCompressionSettings;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatio;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_PixelAspectRatio'.</summary>
		[Field ("kCMFormatDescriptionExtension_PixelAspectRatio",  "CoreMedia")]
		public static NSString PixelAspectRatio {
			get {
				if (_PixelAspectRatio is null)
					_PixelAspectRatio = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_PixelAspectRatio")!;
				return _PixelAspectRatio;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProjectionKind;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ProjectionKind'.</summary>
		[Field ("kCMFormatDescriptionExtension_ProjectionKind",  "CoreMedia")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString ProjectionKind {
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_ProjectionKind is null)
					_ProjectionKind = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ProjectionKind")!;
				return _ProjectionKind;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProtectedContentOriginalFormat;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ProtectedContentOriginalFormat'.</summary>
		[Field ("kCMFormatDescriptionExtension_ProtectedContentOriginalFormat",  "CoreMedia")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString ProtectedContentOriginalFormat {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_ProtectedContentOriginalFormat is null)
					_ProtectedContentOriginalFormat = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ProtectedContentOriginalFormat")!;
				return _ProtectedContentOriginalFormat;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RevisionLevel;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_RevisionLevel'.</summary>
		[Field ("kCMFormatDescriptionExtension_RevisionLevel",  "CoreMedia")]
		public static NSString RevisionLevel {
			get {
				if (_RevisionLevel is null)
					_RevisionLevel = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_RevisionLevel")!;
				return _RevisionLevel;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SampleDescriptionExtensionAtoms;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_SampleDescriptionExtensionAtoms'.</summary>
		[Field ("kCMFormatDescriptionExtension_SampleDescriptionExtensionAtoms",  "CoreMedia")]
		public static NSString SampleDescriptionExtensionAtoms {
			get {
				if (_SampleDescriptionExtensionAtoms is null)
					_SampleDescriptionExtensionAtoms = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_SampleDescriptionExtensionAtoms")!;
				return _SampleDescriptionExtensionAtoms;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SpatialQuality;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_SpatialQuality'.</summary>
		[Field ("kCMFormatDescriptionExtension_SpatialQuality",  "CoreMedia")]
		public static NSString SpatialQuality {
			get {
				if (_SpatialQuality is null)
					_SpatialQuality = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_SpatialQuality")!;
				return _SpatialQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StereoCameraBaseline;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_StereoCameraBaseline'.</summary>
		[Field ("kCMFormatDescriptionExtension_StereoCameraBaseline",  "CoreMedia")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString StereoCameraBaseline {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_StereoCameraBaseline is null)
					_StereoCameraBaseline = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_StereoCameraBaseline")!;
				return _StereoCameraBaseline;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TemporalQuality;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_TemporalQuality'.</summary>
		[Field ("kCMFormatDescriptionExtension_TemporalQuality",  "CoreMedia")]
		public static NSString TemporalQuality {
			get {
				if (_TemporalQuality is null)
					_TemporalQuality = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_TemporalQuality")!;
				return _TemporalQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransferFunction;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_TransferFunction'.</summary>
		[Field ("kCMFormatDescriptionExtension_TransferFunction",  "CoreMedia")]
		public static NSString TransferFunction {
			get {
				if (_TransferFunction is null)
					_TransferFunction = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_TransferFunction")!;
				return _TransferFunction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Vendor;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_Vendor'.</summary>
		[Field ("kCMFormatDescriptionExtension_Vendor",  "CoreMedia")]
		public static NSString Vendor {
			get {
				if (_Vendor is null)
					_Vendor = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_Vendor")!;
				return _Vendor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerbatimISOSampleEntry;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_VerbatimISOSampleEntry'.</summary>
		[Field ("kCMFormatDescriptionExtension_VerbatimISOSampleEntry",  "CoreMedia")]
		public static NSString VerbatimISOSampleEntry {
			get {
				if (_VerbatimISOSampleEntry is null)
					_VerbatimISOSampleEntry = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_VerbatimISOSampleEntry")!;
				return _VerbatimISOSampleEntry;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerbatimImageDescription;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_VerbatimImageDescription'.</summary>
		[Field ("kCMFormatDescriptionExtension_VerbatimImageDescription",  "CoreMedia")]
		public static NSString VerbatimImageDescription {
			get {
				if (_VerbatimImageDescription is null)
					_VerbatimImageDescription = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_VerbatimImageDescription")!;
				return _VerbatimImageDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VerbatimSampleDescription;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_VerbatimSampleDescription'.</summary>
		[Field ("kCMFormatDescriptionExtension_VerbatimSampleDescription",  "CoreMedia")]
		public static NSString VerbatimSampleDescription {
			get {
				if (_VerbatimSampleDescription is null)
					_VerbatimSampleDescription = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_VerbatimSampleDescription")!;
				return _VerbatimSampleDescription;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Version;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_Version'.</summary>
		[Field ("kCMFormatDescriptionExtension_Version",  "CoreMedia")]
		public static NSString Version {
			get {
				if (_Version is null)
					_Version = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_Version")!;
				return _Version;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ViewPackingKind;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_ViewPackingKind'.</summary>
		[Field ("kCMFormatDescriptionExtension_ViewPackingKind",  "CoreMedia")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString ViewPackingKind {
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_ViewPackingKind is null)
					_ViewPackingKind = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_ViewPackingKind")!;
				return _ViewPackingKind;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YCbCrMatrix;
		/// <summary>Represents the value associated with the constant 'kCMFormatDescriptionExtension_YCbCrMatrix'.</summary>
		[Field ("kCMFormatDescriptionExtension_YCbCrMatrix",  "CoreMedia")]
		public static NSString YCbCrMatrix {
			get {
				if (_YCbCrMatrix is null)
					_YCbCrMatrix = Dlfcn.GetStringConstant (Libraries.CoreMedia.Handle, "kCMFormatDescriptionExtension_YCbCrMatrix")!;
				return _YCbCrMatrix;
			}
		}
	} /* class CMFormatDescriptionExtensionKeys */
}
