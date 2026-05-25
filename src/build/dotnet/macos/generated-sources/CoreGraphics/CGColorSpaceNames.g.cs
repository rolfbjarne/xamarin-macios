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
namespace CoreGraphics {
	/// <summary>Provides string constants whose values are known color spaces.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class CGColorSpaceNames  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AcesCGLinear;
		/// <summary>Gets a string constant that identifies the AcesCGLinear color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceACESCGLinear",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AcesCGLinear {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AcesCGLinear is null)
					_AcesCGLinear = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceACESCGLinear")!;
				return _AcesCGLinear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdobeRGB1998;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Now accessible as AdobeRgb1998.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCGColorSpaceAdobeRGB1998",  "CoreGraphics")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString AdobeRGB1998 {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AdobeRGB1998 is null)
					_AdobeRGB1998 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceAdobeRGB1998")!;
				return _AdobeRGB1998;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AdobeRgb1998;
		/// <summary>Gets a string constant that identifies the AdobeRgb1998 color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceAdobeRGB1998",  "CoreGraphics")]
		public static NSString AdobeRgb1998 {
			get {
				if (_AdobeRgb1998 is null)
					_AdobeRgb1998 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceAdobeRGB1998")!;
				return _AdobeRgb1998;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoreMedia709;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceCoreMedia709'.</summary>
		[Field ("kCGColorSpaceCoreMedia709",  "CoreGraphics")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString CoreMedia709 {
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_CoreMedia709 is null)
					_CoreMedia709 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceCoreMedia709")!;
				return _CoreMedia709;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Dcip3;
		/// <summary>Gets a string constant that identifies the Dcip3 color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceDCIP3",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Dcip3 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Dcip3 is null)
					_Dcip3 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceDCIP3")!;
				return _Dcip3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayP3;
		/// <summary>Gets a string constant that identifies the DisplayP3 color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceDisplayP3",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DisplayP3 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DisplayP3 is null)
					_DisplayP3 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceDisplayP3")!;
				return _DisplayP3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayP3_Hlg;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceDisplayP3_HLG'.</summary>
		[Field ("kCGColorSpaceDisplayP3_HLG",  "CoreGraphics")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DisplayP3_Hlg {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DisplayP3_Hlg is null)
					_DisplayP3_Hlg = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceDisplayP3_HLG")!;
				return _DisplayP3_Hlg;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayP3_PQ;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceDisplayP3_PQ'.</summary>
		[Field ("kCGColorSpaceDisplayP3_PQ",  "CoreGraphics")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString DisplayP3_PQ {
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DisplayP3_PQ is null)
					_DisplayP3_PQ = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceDisplayP3_PQ")!;
				return _DisplayP3_PQ;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayP3_PQ_Eotf;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceDisplayP3_PQ_EOTF'.</summary>
		[Field ("kCGColorSpaceDisplayP3_PQ_EOTF",  "CoreGraphics")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[ObsoletedOSPlatform ("macos10.15.4")]
		[ObsoletedOSPlatform ("ios13.4")]
		[ObsoletedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("macos")]
		public static NSString DisplayP3_PQ_Eotf {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[ObsoletedOSPlatform ("macos10.15.4")]
			[ObsoletedOSPlatform ("ios13.4")]
			[ObsoletedOSPlatform ("tvos13.4")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_DisplayP3_PQ_Eotf is null)
					_DisplayP3_PQ_Eotf = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceDisplayP3_PQ_EOTF")!;
				return _DisplayP3_PQ_Eotf;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedDisplayP3;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceExtendedDisplayP3'.</summary>
		[Field ("kCGColorSpaceExtendedDisplayP3",  "CoreGraphics")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExtendedDisplayP3 {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExtendedDisplayP3 is null)
					_ExtendedDisplayP3 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedDisplayP3")!;
				return _ExtendedDisplayP3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedGray;
		/// <summary>Gets a string constant that identifies the ExtendedGray color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceExtendedGray",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExtendedGray {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExtendedGray is null)
					_ExtendedGray = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedGray")!;
				return _ExtendedGray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedItur_2020;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceExtendedITUR_2020'.</summary>
		[Field ("kCGColorSpaceExtendedITUR_2020",  "CoreGraphics")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExtendedItur_2020 {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExtendedItur_2020 is null)
					_ExtendedItur_2020 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedITUR_2020")!;
				return _ExtendedItur_2020;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedLinearDisplayP3;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceExtendedLinearDisplayP3'.</summary>
		[Field ("kCGColorSpaceExtendedLinearDisplayP3",  "CoreGraphics")]
		[SupportedOSPlatform ("ios12.3")]
		[SupportedOSPlatform ("tvos12.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExtendedLinearDisplayP3 {
			[SupportedOSPlatform ("ios12.3")]
			[SupportedOSPlatform ("tvos12.3")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExtendedLinearDisplayP3 is null)
					_ExtendedLinearDisplayP3 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedLinearDisplayP3")!;
				return _ExtendedLinearDisplayP3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedLinearGray;
		/// <summary>Gets a string constant that identifies the ExtendedLinearGray color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceExtendedLinearGray",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExtendedLinearGray {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExtendedLinearGray is null)
					_ExtendedLinearGray = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedLinearGray")!;
				return _ExtendedLinearGray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedLinearItur_2020;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceExtendedLinearITUR_2020'.</summary>
		[Field ("kCGColorSpaceExtendedLinearITUR_2020",  "CoreGraphics")]
		[SupportedOSPlatform ("ios12.3")]
		[SupportedOSPlatform ("tvos12.3")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExtendedLinearItur_2020 {
			[SupportedOSPlatform ("ios12.3")]
			[SupportedOSPlatform ("tvos12.3")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExtendedLinearItur_2020 is null)
					_ExtendedLinearItur_2020 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedLinearITUR_2020")!;
				return _ExtendedLinearItur_2020;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedLinearSrgb;
		/// <summary>Gets a string constant that identifies the ExtendedLinearSrgb color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceExtendedLinearSRGB",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExtendedLinearSrgb {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExtendedLinearSrgb is null)
					_ExtendedLinearSrgb = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedLinearSRGB")!;
				return _ExtendedLinearSrgb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedRange;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceExtendedRange'.</summary>
		[Field ("kCGColorSpaceExtendedRange",  "CoreGraphics")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExtendedRange {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExtendedRange is null)
					_ExtendedRange = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedRange")!;
				return _ExtendedRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExtendedSrgb;
		/// <summary>Gets a string constant that identifies the ExtendedSrgb color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceExtendedSRGB",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ExtendedSrgb {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ExtendedSrgb is null)
					_ExtendedSrgb = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceExtendedSRGB")!;
				return _ExtendedSrgb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericCMYK;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Now accessible as GenericCmyk.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCGColorSpaceGenericCMYK",  "CoreGraphics")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString GenericCMYK {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GenericCMYK is null)
					_GenericCMYK = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericCMYK")!;
				return _GenericCMYK;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericCmyk;
		/// <summary>Gets a string constant that identifies the GenericCmyk color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceGenericCMYK",  "CoreGraphics")]
		public static NSString GenericCmyk {
			get {
				if (_GenericCmyk is null)
					_GenericCmyk = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericCMYK")!;
				return _GenericCmyk;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericGray;
		/// <summary>Gets the name of the generic gray color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceGenericGray",  "CoreGraphics")]
		public static NSString GenericGray {
			get {
				if (_GenericGray is null)
					_GenericGray = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericGray")!;
				return _GenericGray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericGrayGamma2_2;
		/// <summary>Gets the name of the generic gray color space that has a gamma value of 2.2.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceGenericGrayGamma2_2",  "CoreGraphics")]
		public static NSString GenericGrayGamma2_2 {
			get {
				if (_GenericGrayGamma2_2 is null)
					_GenericGrayGamma2_2 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericGrayGamma2_2")!;
				return _GenericGrayGamma2_2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericLab;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceGenericLab",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString GenericLab {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_GenericLab is null)
					_GenericLab = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericLab")!;
				return _GenericLab;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericRGB;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Now accessible as GenericRgb.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCGColorSpaceGenericRGB",  "CoreGraphics")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString GenericRGB {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GenericRGB is null)
					_GenericRGB = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericRGB")!;
				return _GenericRGB;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericRGBLinear;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Now accessible as GenericRgb.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCGColorSpaceGenericRGBLinear",  "CoreGraphics")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString GenericRGBLinear {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_GenericRGBLinear is null)
					_GenericRGBLinear = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericRGBLinear")!;
				return _GenericRGBLinear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericRgb;
		/// <summary>Gets a string constant that identifies the GenericRgb color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceGenericRGB",  "CoreGraphics")]
		public static NSString GenericRgb {
			get {
				if (_GenericRgb is null)
					_GenericRgb = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericRGB")!;
				return _GenericRgb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericRgbLinear;
		/// <summary>Gets a string constant that identifies the GenericRgbLinear color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceGenericRGBLinear",  "CoreGraphics")]
		public static NSString GenericRgbLinear {
			get {
				if (_GenericRgbLinear is null)
					_GenericRgbLinear = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericRGBLinear")!;
				return _GenericRgbLinear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GenericXyz;
		/// <summary>Gets a string constant that identifies the GenericXyz color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceGenericXYZ",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString GenericXyz {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_GenericXyz is null)
					_GenericXyz = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceGenericXYZ")!;
				return _GenericXyz;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItuR_2020;
		/// <summary>Gets a string constant that identifies the ItuR_2020 color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceITUR_2020",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ItuR_2020 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ItuR_2020 is null)
					_ItuR_2020 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2020")!;
				return _ItuR_2020;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItuR_2020_sRgbGamma;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceITUR_2020_sRGBGamma'.</summary>
		[Field ("kCGColorSpaceITUR_2020_sRGBGamma",  "CoreGraphics")]
		[SupportedOSPlatform ("macos12.1")]
		[SupportedOSPlatform ("ios15.2")]
		[SupportedOSPlatform ("tvos15.2")]
		[SupportedOSPlatform ("maccatalyst15.2")]
		public static NSString ItuR_2020_sRgbGamma {
			[SupportedOSPlatform ("macos12.1")]
			[SupportedOSPlatform ("ios15.2")]
			[SupportedOSPlatform ("tvos15.2")]
			[SupportedOSPlatform ("maccatalyst15.2")]
			get {
				if (_ItuR_2020_sRgbGamma is null)
					_ItuR_2020_sRgbGamma = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2020_sRGBGamma")!;
				return _ItuR_2020_sRgbGamma;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItuR_709;
		/// <summary>Gets a string constant that identifies the ItuR_709 color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceITUR_709",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ItuR_709 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ItuR_709 is null)
					_ItuR_709 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_709")!;
				return _ItuR_709;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItuR_709_Hlg;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceITUR_709_HLG'.</summary>
		[Field ("kCGColorSpaceITUR_709_HLG",  "CoreGraphics")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString ItuR_709_Hlg {
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_ItuR_709_Hlg is null)
					_ItuR_709_Hlg = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_709_HLG")!;
				return _ItuR_709_Hlg;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ItuR_709_PQ;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceITUR_709_PQ'.</summary>
		[Field ("kCGColorSpaceITUR_709_PQ",  "CoreGraphics")]
		[SupportedOSPlatform ("macos12.1")]
		[SupportedOSPlatform ("ios15.2")]
		[SupportedOSPlatform ("tvos15.2")]
		[SupportedOSPlatform ("maccatalyst15.2")]
		public static NSString ItuR_709_PQ {
			[SupportedOSPlatform ("macos12.1")]
			[SupportedOSPlatform ("ios15.2")]
			[SupportedOSPlatform ("tvos15.2")]
			[SupportedOSPlatform ("maccatalyst15.2")]
			get {
				if (_ItuR_709_PQ is null)
					_ItuR_709_PQ = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_709_PQ")!;
				return _ItuR_709_PQ;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itur_2020_Hlg;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceITUR_2020_HLG'.</summary>
		[Field ("kCGColorSpaceITUR_2020_HLG",  "CoreGraphics")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'Itur_2100_PQ' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'Itur_2100_PQ' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'Itur_2100_PQ' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'Itur_2100_PQ' instead.")]
		[SupportedOSPlatform ("macos")]
		public static NSString Itur_2020_Hlg {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[ObsoletedOSPlatform ("macos11.0", "Use 'Itur_2100_PQ' instead.")]
			[ObsoletedOSPlatform ("ios14.0", "Use 'Itur_2100_PQ' instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use 'Itur_2100_PQ' instead.")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'Itur_2100_PQ' instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Itur_2020_Hlg is null)
					_Itur_2020_Hlg = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2020_HLG")!;
				return _Itur_2020_Hlg;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itur_2020_PQ;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceITUR_2020_PQ'.</summary>
		[Field ("kCGColorSpaceITUR_2020_PQ",  "CoreGraphics")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'Itur_2100_PQ' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'Itur_2100_PQ' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'Itur_2100_PQ' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'Itur_2100_PQ' instead.")]
		[SupportedOSPlatform ("macos")]
		public static NSString Itur_2020_PQ {
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			[ObsoletedOSPlatform ("macos11.0", "Use 'Itur_2100_PQ' instead.")]
			[ObsoletedOSPlatform ("ios14.0", "Use 'Itur_2100_PQ' instead.")]
			[ObsoletedOSPlatform ("tvos14.0", "Use 'Itur_2100_PQ' instead.")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'Itur_2100_PQ' instead.")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Itur_2020_PQ is null)
					_Itur_2020_PQ = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2020_PQ")!;
				return _Itur_2020_PQ;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itur_2020_PQ_Eotf;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceITUR_2020_PQ_EOTF'.</summary>
		[Field ("kCGColorSpaceITUR_2020_PQ_EOTF",  "CoreGraphics")]
		[ObsoletedOSPlatform ("macos10.15.4", "Use 'Itur_2100_PQ' instead.")]
		[ObsoletedOSPlatform ("ios13.4", "Use 'Itur_2100_PQ' instead.")]
		[ObsoletedOSPlatform ("tvos13.4", "Use 'Itur_2100_PQ' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Itur_2100_PQ' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Itur_2020_PQ_Eotf {
			[ObsoletedOSPlatform ("macos10.15.4", "Use 'Itur_2100_PQ' instead.")]
			[ObsoletedOSPlatform ("ios13.4", "Use 'Itur_2100_PQ' instead.")]
			[ObsoletedOSPlatform ("tvos13.4", "Use 'Itur_2100_PQ' instead.")]
			[SupportedOSPlatform ("maccatalyst")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Itur_2100_PQ' instead.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Itur_2020_PQ_Eotf is null)
					_Itur_2020_PQ_Eotf = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2020_PQ_EOTF")!;
				return _Itur_2020_PQ_Eotf;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itur_2100_Hlg;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceITUR_2100_HLG'.</summary>
		[Field ("kCGColorSpaceITUR_2100_HLG",  "CoreGraphics")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Itur_2100_Hlg {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Itur_2100_Hlg is null)
					_Itur_2100_Hlg = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2100_HLG")!;
				return _Itur_2100_Hlg;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Itur_2100_PQ;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceITUR_2100_PQ'.</summary>
		[Field ("kCGColorSpaceITUR_2100_PQ",  "CoreGraphics")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString Itur_2100_PQ {
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_Itur_2100_PQ is null)
					_Itur_2100_PQ = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceITUR_2100_PQ")!;
				return _Itur_2100_PQ;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinearDisplayP3;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceLinearDisplayP3'.</summary>
		[Field ("kCGColorSpaceLinearDisplayP3",  "CoreGraphics")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LinearDisplayP3 {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LinearDisplayP3 is null)
					_LinearDisplayP3 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceLinearDisplayP3")!;
				return _LinearDisplayP3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinearGray;
		/// <summary>Gets a string constant that identifies the LinearGray color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceLinearGray",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString LinearGray {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_LinearGray is null)
					_LinearGray = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceLinearGray")!;
				return _LinearGray;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinearItur_2020;
		/// <summary>Represents the value associated with the constant 'kCGColorSpaceLinearITUR_2020'.</summary>
		[Field ("kCGColorSpaceLinearITUR_2020",  "CoreGraphics")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString LinearItur_2020 {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_LinearItur_2020 is null)
					_LinearItur_2020 = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceLinearITUR_2020")!;
				return _LinearItur_2020;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LinearSrgb;
		/// <summary>Gets a string constant that identifies the LinearSrgb color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceLinearSRGB",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString LinearSrgb {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_LinearSrgb is null)
					_LinearSrgb = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceLinearSRGB")!;
				return _LinearSrgb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RommRgb;
		/// <summary>Gets a string constant that identifies the RommRgb color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceROMMRGB",  "CoreGraphics")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString RommRgb {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_RommRgb is null)
					_RommRgb = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceROMMRGB")!;
				return _RommRgb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SRGB;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Obsolete ("Now accessible as Srgb.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Field ("kCGColorSpaceSRGB",  "CoreGraphics")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString SRGB {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SRGB is null)
					_SRGB = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceSRGB")!;
				return _SRGB;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Srgb;
		/// <summary>Gets a string constant that identifies the Srgb color space.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCGColorSpaceSRGB",  "CoreGraphics")]
		public static NSString Srgb {
			get {
				if (_Srgb is null)
					_Srgb = Dlfcn.GetStringConstant (Libraries.CoreGraphics.Handle, "kCGColorSpaceSRGB")!;
				return _Srgb;
			}
		}
	} /* class CGColorSpaceNames */
}
