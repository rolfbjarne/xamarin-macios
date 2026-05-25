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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreVideo {
	/// <summary>A <see cref="T:CoreVideo.CVBuffer" /> that stores image data.</summary>
	public unsafe partial class CVImageBuffer  {
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ColorPrimaries_DCI_P3 {
			get {
				return (CVImageBufferColorPrimaries.DciP3.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString ColorPrimaries_EBU_3213 {
			get {
				return (CVImageBufferColorPrimaries.Ebu3213.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ColorPrimaries_ITU_R_2020 {
			get {
				return (CVImageBufferColorPrimaries.ItuR2020.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString ColorPrimaries_ITU_R_709_2 {
			get {
				return (CVImageBufferColorPrimaries.ItuR709_2.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString ColorPrimaries_P22 {
			get {
				return (CVImageBufferColorPrimaries.P22.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ColorPrimaries_P3_D65 {
			get {
				return (CVImageBufferColorPrimaries.P3D65.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString ColorPrimaries_SMPTE_C {
			get {
				return (CVImageBufferColorPrimaries.SmpteC.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TransferFunction_ITU_R_2020 {
			get {
				return (CVImageBufferTransferFunction.ItuR2020.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TransferFunction_ITU_R_2100_HLG {
			get {
				return (CVImageBufferTransferFunction.ItuR2100Hlg.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString TransferFunction_ITU_R_709_2 {
			get {
				return (CVImageBufferTransferFunction.ItuR709_2.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString TransferFunction_SMPTE_240M_1995 {
			get {
				return (CVImageBufferTransferFunction.Smpte240M1995.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TransferFunction_SMPTE_ST_2084_PQ {
			get {
				return (CVImageBufferTransferFunction.SmpteST2084PQ.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TransferFunction_SMPTE_ST_428_1 {
			get {
				return (CVImageBufferTransferFunction.SmpteST428_1.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString TransferFunction_UseGamma {
			get {
				return (CVImageBufferTransferFunction.UseGamma.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TransferFunction_sRGB {
			get {
				return (CVImageBufferTransferFunction.SRgb.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString YCbCrMatrix_DCI_P3 {
			get {
				return (CVImageBufferYCbCrMatrix.DciP3.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString YCbCrMatrix_ITU_R_2020 {
			get {
				return (CVImageBufferYCbCrMatrix.ItuR2020.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString YCbCrMatrix_ITU_R_601_4 {
			get {
				return (CVImageBufferYCbCrMatrix.ItuR601_4.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString YCbCrMatrix_ITU_R_709_2 {
			get {
				return (CVImageBufferYCbCrMatrix.ItuR709_2.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString YCbCrMatrix_P3_D65 {
			get {
				return (CVImageBufferYCbCrMatrix.P3D65.GetConstant () as NSString)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString YCbCrMatrix_SMPTE_240M_1995 {
			get {
				return (CVImageBufferYCbCrMatrix.Smpte240M1995.GetConstant () as NSString)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlphaChannelIsOpaque;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferAlphaChannelIsOpaque",  "CoreVideo")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString AlphaChannelIsOpaque {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_AlphaChannelIsOpaque is null)
					_AlphaChannelIsOpaque = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferAlphaChannelIsOpaque")!;
				return _AlphaChannelIsOpaque;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AlphaChannelModeKey;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferAlphaChannelModeKey'.</summary>
		[Field ("kCVImageBufferAlphaChannelModeKey",  "CoreVideo")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AlphaChannelModeKey {
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AlphaChannelModeKey is null)
					_AlphaChannelModeKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferAlphaChannelModeKey")!;
				return _AlphaChannelModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AmbientViewingEnvironmentKey;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferAmbientViewingEnvironmentKey'.</summary>
		[Field ("kCVImageBufferAmbientViewingEnvironmentKey",  "CoreVideo")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString AmbientViewingEnvironmentKey {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_AmbientViewingEnvironmentKey is null)
					_AmbientViewingEnvironmentKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferAmbientViewingEnvironmentKey")!;
				return _AmbientViewingEnvironmentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CGColorSpaceKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferCGColorSpaceKey",  "CoreVideo")]
		public static NSString CGColorSpaceKey {
			get {
				if (_CGColorSpaceKey is null)
					_CGColorSpaceKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferCGColorSpaceKey")!;
				return _CGColorSpaceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocationBottomFieldKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaLocationBottomFieldKey",  "CoreVideo")]
		public static NSString ChromaLocationBottomFieldKey {
			get {
				if (_ChromaLocationBottomFieldKey is null)
					_ChromaLocationBottomFieldKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocationBottomFieldKey")!;
				return _ChromaLocationBottomFieldKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocationTopFieldKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaLocationTopFieldKey",  "CoreVideo")]
		public static NSString ChromaLocationTopFieldKey {
			get {
				if (_ChromaLocationTopFieldKey is null)
					_ChromaLocationTopFieldKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocationTopFieldKey")!;
				return _ChromaLocationTopFieldKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocation_Bottom;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaLocation_Bottom",  "CoreVideo")]
		public static NSString ChromaLocation_Bottom {
			get {
				if (_ChromaLocation_Bottom is null)
					_ChromaLocation_Bottom = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_Bottom")!;
				return _ChromaLocation_Bottom;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocation_BottomLeft;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaLocation_BottomLeft",  "CoreVideo")]
		public static NSString ChromaLocation_BottomLeft {
			get {
				if (_ChromaLocation_BottomLeft is null)
					_ChromaLocation_BottomLeft = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_BottomLeft")!;
				return _ChromaLocation_BottomLeft;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocation_Center;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaLocation_Center",  "CoreVideo")]
		public static NSString ChromaLocation_Center {
			get {
				if (_ChromaLocation_Center is null)
					_ChromaLocation_Center = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_Center")!;
				return _ChromaLocation_Center;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocation_DV420;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaLocation_DV420",  "CoreVideo")]
		public static NSString ChromaLocation_DV420 {
			get {
				if (_ChromaLocation_DV420 is null)
					_ChromaLocation_DV420 = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_DV420")!;
				return _ChromaLocation_DV420;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocation_Left;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaLocation_Left",  "CoreVideo")]
		public static NSString ChromaLocation_Left {
			get {
				if (_ChromaLocation_Left is null)
					_ChromaLocation_Left = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_Left")!;
				return _ChromaLocation_Left;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocation_Top;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaLocation_Top",  "CoreVideo")]
		public static NSString ChromaLocation_Top {
			get {
				if (_ChromaLocation_Top is null)
					_ChromaLocation_Top = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_Top")!;
				return _ChromaLocation_Top;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaLocation_TopLeft;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaLocation_TopLeft",  "CoreVideo")]
		public static NSString ChromaLocation_TopLeft {
			get {
				if (_ChromaLocation_TopLeft is null)
					_ChromaLocation_TopLeft = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaLocation_TopLeft")!;
				return _ChromaLocation_TopLeft;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaSubsamplingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaSubsamplingKey",  "CoreVideo")]
		public static NSString ChromaSubsamplingKey {
			get {
				if (_ChromaSubsamplingKey is null)
					_ChromaSubsamplingKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaSubsamplingKey")!;
				return _ChromaSubsamplingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaSubsampling_411;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaSubsampling_411",  "CoreVideo")]
		public static NSString ChromaSubsampling_411 {
			get {
				if (_ChromaSubsampling_411 is null)
					_ChromaSubsampling_411 = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaSubsampling_411")!;
				return _ChromaSubsampling_411;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaSubsampling_420;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaSubsampling_420",  "CoreVideo")]
		public static NSString ChromaSubsampling_420 {
			get {
				if (_ChromaSubsampling_420 is null)
					_ChromaSubsampling_420 = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaSubsampling_420")!;
				return _ChromaSubsampling_420;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChromaSubsampling_422;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferChromaSubsampling_422",  "CoreVideo")]
		public static NSString ChromaSubsampling_422 {
			get {
				if (_ChromaSubsampling_422 is null)
					_ChromaSubsampling_422 = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferChromaSubsampling_422")!;
				return _ChromaSubsampling_422;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureHeightKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferCleanApertureHeightKey",  "CoreVideo")]
		public static NSString CleanApertureHeightKey {
			get {
				if (_CleanApertureHeightKey is null)
					_CleanApertureHeightKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureHeightKey")!;
				return _CleanApertureHeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureHorizontalOffsetKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferCleanApertureHorizontalOffsetKey",  "CoreVideo")]
		public static NSString CleanApertureHorizontalOffsetKey {
			get {
				if (_CleanApertureHorizontalOffsetKey is null)
					_CleanApertureHorizontalOffsetKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureHorizontalOffsetKey")!;
				return _CleanApertureHorizontalOffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferCleanApertureKey",  "CoreVideo")]
		public static NSString CleanApertureKey {
			get {
				if (_CleanApertureKey is null)
					_CleanApertureKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureKey")!;
				return _CleanApertureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureVerticalOffsetKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferCleanApertureVerticalOffsetKey",  "CoreVideo")]
		public static NSString CleanApertureVerticalOffsetKey {
			get {
				if (_CleanApertureVerticalOffsetKey is null)
					_CleanApertureVerticalOffsetKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureVerticalOffsetKey")!;
				return _CleanApertureVerticalOffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleanApertureWidthKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferCleanApertureWidthKey",  "CoreVideo")]
		public static NSString CleanApertureWidthKey {
			get {
				if (_CleanApertureWidthKey is null)
					_CleanApertureWidthKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferCleanApertureWidthKey")!;
				return _CleanApertureWidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ColorPrimariesKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferColorPrimariesKey",  "CoreVideo")]
		public static NSString ColorPrimariesKey {
			get {
				if (_ColorPrimariesKey is null)
					_ColorPrimariesKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferColorPrimariesKey")!;
				return _ColorPrimariesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentLightLevelInfoKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferContentLightLevelInfoKey",  "CoreVideo")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ContentLightLevelInfoKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ContentLightLevelInfoKey is null)
					_ContentLightLevelInfoKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferContentLightLevelInfoKey")!;
				return _ContentLightLevelInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayDimensionsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferDisplayDimensionsKey",  "CoreVideo")]
		public static NSString DisplayDimensionsKey {
			get {
				if (_DisplayDimensionsKey is null)
					_DisplayDimensionsKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferDisplayDimensionsKey")!;
				return _DisplayDimensionsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayHeightKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferDisplayHeightKey",  "CoreVideo")]
		public static NSString DisplayHeightKey {
			get {
				if (_DisplayHeightKey is null)
					_DisplayHeightKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferDisplayHeightKey")!;
				return _DisplayHeightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayMaskRectangleKey;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferDisplayMaskRectangleKey'.</summary>
		[Field ("kCVImageBufferDisplayMaskRectangleKey",  "CoreVideo")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString DisplayMaskRectangleKey {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_DisplayMaskRectangleKey is null)
					_DisplayMaskRectangleKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferDisplayMaskRectangleKey")!;
				return _DisplayMaskRectangleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayMaskRectangleStereoLeftKey;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferDisplayMaskRectangleStereoLeftKey'.</summary>
		[Field ("kCVImageBufferDisplayMaskRectangleStereoLeftKey",  "CoreVideo")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString DisplayMaskRectangleStereoLeftKey {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_DisplayMaskRectangleStereoLeftKey is null)
					_DisplayMaskRectangleStereoLeftKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferDisplayMaskRectangleStereoLeftKey")!;
				return _DisplayMaskRectangleStereoLeftKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayMaskRectangleStereoRightKey;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferDisplayMaskRectangleStereoRightKey'.</summary>
		[Field ("kCVImageBufferDisplayMaskRectangleStereoRightKey",  "CoreVideo")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString DisplayMaskRectangleStereoRightKey {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_DisplayMaskRectangleStereoRightKey is null)
					_DisplayMaskRectangleStereoRightKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferDisplayMaskRectangleStereoRightKey")!;
				return _DisplayMaskRectangleStereoRightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisplayWidthKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferDisplayWidthKey",  "CoreVideo")]
		public static NSString DisplayWidthKey {
			get {
				if (_DisplayWidthKey is null)
					_DisplayWidthKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferDisplayWidthKey")!;
				return _DisplayWidthKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldCountKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferFieldCountKey",  "CoreVideo")]
		public static NSString FieldCountKey {
			get {
				if (_FieldCountKey is null)
					_FieldCountKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferFieldCountKey")!;
				return _FieldCountKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldDetailKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferFieldDetailKey",  "CoreVideo")]
		public static NSString FieldDetailKey {
			get {
				if (_FieldDetailKey is null)
					_FieldDetailKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailKey")!;
				return _FieldDetailKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldDetailSpatialFirstLineEarly;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferFieldDetailSpatialFirstLineEarly",  "CoreVideo")]
		public static NSString FieldDetailSpatialFirstLineEarly {
			get {
				if (_FieldDetailSpatialFirstLineEarly is null)
					_FieldDetailSpatialFirstLineEarly = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailSpatialFirstLineEarly")!;
				return _FieldDetailSpatialFirstLineEarly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldDetailSpatialFirstLineLate;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferFieldDetailSpatialFirstLineLate",  "CoreVideo")]
		public static NSString FieldDetailSpatialFirstLineLate {
			get {
				if (_FieldDetailSpatialFirstLineLate is null)
					_FieldDetailSpatialFirstLineLate = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailSpatialFirstLineLate")!;
				return _FieldDetailSpatialFirstLineLate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldDetailTemporalBottomFirst;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferFieldDetailTemporalBottomFirst",  "CoreVideo")]
		public static NSString FieldDetailTemporalBottomFirst {
			get {
				if (_FieldDetailTemporalBottomFirst is null)
					_FieldDetailTemporalBottomFirst = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailTemporalBottomFirst")!;
				return _FieldDetailTemporalBottomFirst;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldDetailTemporalTopFirst;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferFieldDetailTemporalTopFirst",  "CoreVideo")]
		public static NSString FieldDetailTemporalTopFirst {
			get {
				if (_FieldDetailTemporalTopFirst is null)
					_FieldDetailTemporalTopFirst = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferFieldDetailTemporalTopFirst")!;
				return _FieldDetailTemporalTopFirst;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GammaLevelKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferGammaLevelKey",  "CoreVideo")]
		public static NSString GammaLevelKey {
			get {
				if (_GammaLevelKey is null)
					_GammaLevelKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferGammaLevelKey")!;
				return _GammaLevelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LogTransferFunctionAppleLog2Key;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferLogTransferFunction_AppleLog2'.</summary>
		[Field ("kCVImageBufferLogTransferFunction_AppleLog2",  "CoreVideo")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public static NSString LogTransferFunctionAppleLog2Key {
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				if (_LogTransferFunctionAppleLog2Key is null)
					_LogTransferFunctionAppleLog2Key = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferLogTransferFunction_AppleLog2")!;
				return _LogTransferFunctionAppleLog2Key;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LogTransferFunctionAppleLogKey;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferLogTransferFunction_AppleLog'.</summary>
		[Field ("kCVImageBufferLogTransferFunction_AppleLog",  "CoreVideo")]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		public static NSString LogTransferFunctionAppleLogKey {
			[SupportedOSPlatform ("tvos17.2")]
			[SupportedOSPlatform ("macos14.2")]
			[SupportedOSPlatform ("ios17.2")]
			[SupportedOSPlatform ("maccatalyst17.2")]
			get {
				if (_LogTransferFunctionAppleLogKey is null)
					_LogTransferFunctionAppleLogKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferLogTransferFunction_AppleLog")!;
				return _LogTransferFunctionAppleLogKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LogTransferFunctionKey;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferLogTransferFunctionKey'.</summary>
		[Field ("kCVImageBufferLogTransferFunctionKey",  "CoreVideo")]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		public static NSString LogTransferFunctionKey {
			[SupportedOSPlatform ("tvos17.2")]
			[SupportedOSPlatform ("macos14.2")]
			[SupportedOSPlatform ("ios17.2")]
			[SupportedOSPlatform ("maccatalyst17.2")]
			get {
				if (_LogTransferFunctionKey is null)
					_LogTransferFunctionKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferLogTransferFunctionKey")!;
				return _LogTransferFunctionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MasteringDisplayColorVolumeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferMasteringDisplayColorVolumeKey",  "CoreVideo")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MasteringDisplayColorVolumeKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MasteringDisplayColorVolumeKey is null)
					_MasteringDisplayColorVolumeKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferMasteringDisplayColorVolumeKey")!;
				return _MasteringDisplayColorVolumeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MovieTimeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferMovieTimeKey",  "CoreVideo")]
		public static NSString MovieTimeKey {
			get {
				if (_MovieTimeKey is null)
					_MovieTimeKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferMovieTimeKey")!;
				return _MovieTimeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NonPropagatedAttachmentsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferNonPropagatedAttachmentsKey",  "CoreVideo")]
		public static NSString NonPropagatedAttachmentsKey {
			get {
				if (_NonPropagatedAttachmentsKey is null)
					_NonPropagatedAttachmentsKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferNonPropagatedAttachmentsKey")!;
				return _NonPropagatedAttachmentsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatioHorizontalSpacingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferPixelAspectRatioHorizontalSpacingKey",  "CoreVideo")]
		public static NSString PixelAspectRatioHorizontalSpacingKey {
			get {
				if (_PixelAspectRatioHorizontalSpacingKey is null)
					_PixelAspectRatioHorizontalSpacingKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferPixelAspectRatioHorizontalSpacingKey")!;
				return _PixelAspectRatioHorizontalSpacingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatioKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferPixelAspectRatioKey",  "CoreVideo")]
		public static NSString PixelAspectRatioKey {
			get {
				if (_PixelAspectRatioKey is null)
					_PixelAspectRatioKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferPixelAspectRatioKey")!;
				return _PixelAspectRatioKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelAspectRatioVerticalSpacingKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferPixelAspectRatioVerticalSpacingKey",  "CoreVideo")]
		public static NSString PixelAspectRatioVerticalSpacingKey {
			get {
				if (_PixelAspectRatioVerticalSpacingKey is null)
					_PixelAspectRatioVerticalSpacingKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferPixelAspectRatioVerticalSpacingKey")!;
				return _PixelAspectRatioVerticalSpacingKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreferredCleanApertureKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferPreferredCleanApertureKey",  "CoreVideo")]
		public static NSString PreferredCleanApertureKey {
			get {
				if (_PreferredCleanApertureKey is null)
					_PreferredCleanApertureKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferPreferredCleanApertureKey")!;
				return _PreferredCleanApertureKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PropagatedAttachmentsKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferPropagatedAttachmentsKey",  "CoreVideo")]
		public static NSString PropagatedAttachmentsKey {
			get {
				if (_PropagatedAttachmentsKey is null)
					_PropagatedAttachmentsKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferPropagatedAttachmentsKey")!;
				return _PropagatedAttachmentsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RegionOfInterestKey;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferRegionOfInterestKey'.</summary>
		[Field ("kCVImageBufferRegionOfInterestKey",  "CoreVideo")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString RegionOfInterestKey {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RegionOfInterestKey is null)
					_RegionOfInterestKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferRegionOfInterestKey")!;
				return _RegionOfInterestKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SceneIlluminationKey;
		/// <summary>Represents the value associated with the constant 'kCVImageBufferSceneIlluminationKey'.</summary>
		[Field ("kCVImageBufferSceneIlluminationKey",  "CoreVideo")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public static NSString SceneIlluminationKey {
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				if (_SceneIlluminationKey is null)
					_SceneIlluminationKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferSceneIlluminationKey")!;
				return _SceneIlluminationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeScaleKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferTimeScaleKey",  "CoreVideo")]
		public static NSString TimeScaleKey {
			get {
				if (_TimeScaleKey is null)
					_TimeScaleKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferTimeScaleKey")!;
				return _TimeScaleKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TimeValueKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVBufferTimeValueKey",  "CoreVideo")]
		public static NSString TimeValueKey {
			get {
				if (_TimeValueKey is null)
					_TimeValueKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVBufferTimeValueKey")!;
				return _TimeValueKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransferFunctionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferTransferFunctionKey",  "CoreVideo")]
		public static NSString TransferFunctionKey {
			get {
				if (_TransferFunctionKey is null)
					_TransferFunctionKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferTransferFunctionKey")!;
				return _TransferFunctionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _YCbCrMatrixKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCVImageBufferYCbCrMatrixKey",  "CoreVideo")]
		public static NSString YCbCrMatrixKey {
			get {
				if (_YCbCrMatrixKey is null)
					_YCbCrMatrixKey = Dlfcn.GetStringConstant (Libraries.CoreVideo.Handle, "kCVImageBufferYCbCrMatrixKey")!;
				return _YCbCrMatrixKey;
			}
		}
	} /* class CVImageBuffer */
}
