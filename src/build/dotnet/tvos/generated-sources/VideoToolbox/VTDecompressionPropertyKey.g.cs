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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace VideoToolbox {
	/// <summary>A class that encapsulates keys necessary for decompression sessions. Used by <see cref="T:VideoToolbox.VTDecompressionProperties" /></summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class VTDecompressionPropertyKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AllowBitstreamToChangeFrameDimensions;
		/// <summary>Represents the value associated with the constant 'kVTDecompressionPropertyKey_AllowBitstreamToChangeFrameDimensions'.</summary>
		[Field ("kVTDecompressionPropertyKey_AllowBitstreamToChangeFrameDimensions",  "VideoToolbox")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("macos15.0")]
		public static NSString AllowBitstreamToChangeFrameDimensions {
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			[SupportedOSPlatform ("macos15.0")]
			get {
				if (_AllowBitstreamToChangeFrameDimensions is null)
					_AllowBitstreamToChangeFrameDimensions = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_AllowBitstreamToChangeFrameDimensions")!;
				return _AllowBitstreamToChangeFrameDimensions;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ContentHasInterframeDependencies;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_ContentHasInterframeDependencies",  "VideoToolbox")]
		public static NSString ContentHasInterframeDependencies {
			get {
				if (_ContentHasInterframeDependencies is null)
					_ContentHasInterframeDependencies = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ContentHasInterframeDependencies")!;
				return _ContentHasInterframeDependencies;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeinterlaceMode;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_DeinterlaceMode",  "VideoToolbox")]
		public static NSString DeinterlaceMode {
			get {
				if (_DeinterlaceMode is null)
					_DeinterlaceMode = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_DeinterlaceMode")!;
				return _DeinterlaceMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeinterlaceMode_Temporal;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_DeinterlaceMode_Temporal",  "VideoToolbox")]
		public static NSString DeinterlaceMode_Temporal {
			get {
				if (_DeinterlaceMode_Temporal is null)
					_DeinterlaceMode_Temporal = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_DeinterlaceMode_Temporal")!;
				return _DeinterlaceMode_Temporal;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DeinterlaceMode_VerticalFilter;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_DeinterlaceMode_VerticalFilter",  "VideoToolbox")]
		public static NSString DeinterlaceMode_VerticalFilter {
			get {
				if (_DeinterlaceMode_VerticalFilter is null)
					_DeinterlaceMode_VerticalFilter = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_DeinterlaceMode_VerticalFilter")!;
				return _DeinterlaceMode_VerticalFilter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldMode;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_FieldMode",  "VideoToolbox")]
		public static NSString FieldMode {
			get {
				if (_FieldMode is null)
					_FieldMode = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_FieldMode")!;
				return _FieldMode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldMode_BothFields;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_FieldMode_BothFields",  "VideoToolbox")]
		public static NSString FieldMode_BothFields {
			get {
				if (_FieldMode_BothFields is null)
					_FieldMode_BothFields = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_BothFields")!;
				return _FieldMode_BothFields;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldMode_BottomFieldOnly;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_FieldMode_BottomFieldOnly",  "VideoToolbox")]
		public static NSString FieldMode_BottomFieldOnly {
			get {
				if (_FieldMode_BottomFieldOnly is null)
					_FieldMode_BottomFieldOnly = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_BottomFieldOnly")!;
				return _FieldMode_BottomFieldOnly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldMode_DeinterlaceFields;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_FieldMode_DeinterlaceFields",  "VideoToolbox")]
		public static NSString FieldMode_DeinterlaceFields {
			get {
				if (_FieldMode_DeinterlaceFields is null)
					_FieldMode_DeinterlaceFields = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_DeinterlaceFields")!;
				return _FieldMode_DeinterlaceFields;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldMode_SingleField;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_FieldMode_SingleField",  "VideoToolbox")]
		public static NSString FieldMode_SingleField {
			get {
				if (_FieldMode_SingleField is null)
					_FieldMode_SingleField = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_SingleField")!;
				return _FieldMode_SingleField;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FieldMode_TopFieldOnly;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_FieldMode_TopFieldOnly",  "VideoToolbox")]
		public static NSString FieldMode_TopFieldOnly {
			get {
				if (_FieldMode_TopFieldOnly is null)
					_FieldMode_TopFieldOnly = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_TopFieldOnly")!;
				return _FieldMode_TopFieldOnly;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GeneratePerFrameHdrDisplayMetadata;
		/// <summary>Represents the value associated with the constant 'kVTDecompressionPropertyKey_GeneratePerFrameHDRDisplayMetadata'.</summary>
		[Field ("kVTDecompressionPropertyKey_GeneratePerFrameHDRDisplayMetadata",  "VideoToolbox")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public static NSString GeneratePerFrameHdrDisplayMetadata {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("macos14.0")]
			get {
				if (_GeneratePerFrameHdrDisplayMetadata is null)
					_GeneratePerFrameHdrDisplayMetadata = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_GeneratePerFrameHDRDisplayMetadata")!;
				return _GeneratePerFrameHdrDisplayMetadata;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaxOutputPresentationTimeStampOfFramesBeingDecoded;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_MaxOutputPresentationTimeStampOfFramesBeingDecoded",  "VideoToolbox")]
		public static NSString MaxOutputPresentationTimeStampOfFramesBeingDecoded {
			get {
				if (_MaxOutputPresentationTimeStampOfFramesBeingDecoded is null)
					_MaxOutputPresentationTimeStampOfFramesBeingDecoded = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_MaxOutputPresentationTimeStampOfFramesBeingDecoded")!;
				return _MaxOutputPresentationTimeStampOfFramesBeingDecoded;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MaximizePowerEfficiency;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_MaximizePowerEfficiency",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString MaximizePowerEfficiency {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_MaximizePowerEfficiency is null)
					_MaximizePowerEfficiency = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_MaximizePowerEfficiency")!;
				return _MaximizePowerEfficiency;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MinOutputPresentationTimeStampOfFramesBeingDecoded;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_MinOutputPresentationTimeStampOfFramesBeingDecoded",  "VideoToolbox")]
		public static NSString MinOutputPresentationTimeStampOfFramesBeingDecoded {
			get {
				if (_MinOutputPresentationTimeStampOfFramesBeingDecoded is null)
					_MinOutputPresentationTimeStampOfFramesBeingDecoded = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_MinOutputPresentationTimeStampOfFramesBeingDecoded")!;
				return _MinOutputPresentationTimeStampOfFramesBeingDecoded;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NumberOfFramesBeingDecoded;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_NumberOfFramesBeingDecoded",  "VideoToolbox")]
		public static NSString NumberOfFramesBeingDecoded {
			get {
				if (_NumberOfFramesBeingDecoded is null)
					_NumberOfFramesBeingDecoded = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_NumberOfFramesBeingDecoded")!;
				return _NumberOfFramesBeingDecoded;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OnlyTheseFrames;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_OnlyTheseFrames",  "VideoToolbox")]
		public static NSString OnlyTheseFrames {
			get {
				if (_OnlyTheseFrames is null)
					_OnlyTheseFrames = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_OnlyTheseFrames")!;
				return _OnlyTheseFrames;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OnlyTheseFrames_AllFrames;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_OnlyTheseFrames_AllFrames",  "VideoToolbox")]
		public static NSString OnlyTheseFrames_AllFrames {
			get {
				if (_OnlyTheseFrames_AllFrames is null)
					_OnlyTheseFrames_AllFrames = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_OnlyTheseFrames_AllFrames")!;
				return _OnlyTheseFrames_AllFrames;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OnlyTheseFrames_IFrames;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_OnlyTheseFrames_IFrames",  "VideoToolbox")]
		public static NSString OnlyTheseFrames_IFrames {
			get {
				if (_OnlyTheseFrames_IFrames is null)
					_OnlyTheseFrames_IFrames = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_OnlyTheseFrames_IFrames")!;
				return _OnlyTheseFrames_IFrames;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OnlyTheseFrames_KeyFrames;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_OnlyTheseFrames_KeyFrames",  "VideoToolbox")]
		public static NSString OnlyTheseFrames_KeyFrames {
			get {
				if (_OnlyTheseFrames_KeyFrames is null)
					_OnlyTheseFrames_KeyFrames = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_OnlyTheseFrames_KeyFrames")!;
				return _OnlyTheseFrames_KeyFrames;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OnlyTheseFrames_NonDroppableFrames;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_OnlyTheseFrames_NonDroppableFrames",  "VideoToolbox")]
		public static NSString OnlyTheseFrames_NonDroppableFrames {
			get {
				if (_OnlyTheseFrames_NonDroppableFrames is null)
					_OnlyTheseFrames_NonDroppableFrames = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_OnlyTheseFrames_NonDroppableFrames")!;
				return _OnlyTheseFrames_NonDroppableFrames;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutputPoolRequestedMinimumBufferCount;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_OutputPoolRequestedMinimumBufferCount",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OutputPoolRequestedMinimumBufferCount {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OutputPoolRequestedMinimumBufferCount is null)
					_OutputPoolRequestedMinimumBufferCount = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_OutputPoolRequestedMinimumBufferCount")!;
				return _OutputPoolRequestedMinimumBufferCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelBufferPool;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_PixelBufferPool",  "VideoToolbox")]
		public static NSString PixelBufferPool {
			get {
				if (_PixelBufferPool is null)
					_PixelBufferPool = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_PixelBufferPool")!;
				return _PixelBufferPool;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelBufferPoolIsShared;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_PixelBufferPoolIsShared",  "VideoToolbox")]
		public static NSString PixelBufferPoolIsShared {
			get {
				if (_PixelBufferPoolIsShared is null)
					_PixelBufferPoolIsShared = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_PixelBufferPoolIsShared")!;
				return _PixelBufferPoolIsShared;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelFormatsWithReducedResolutionSupport;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_PixelFormatsWithReducedResolutionSupport",  "VideoToolbox")]
		public static NSString PixelFormatsWithReducedResolutionSupport {
			get {
				if (_PixelFormatsWithReducedResolutionSupport is null)
					_PixelFormatsWithReducedResolutionSupport = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_PixelFormatsWithReducedResolutionSupport")!;
				return _PixelFormatsWithReducedResolutionSupport;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PixelTransferProperties;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_PixelTransferProperties",  "VideoToolbox")]
		public static NSString PixelTransferProperties {
			get {
				if (_PixelTransferProperties is null)
					_PixelTransferProperties = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_PixelTransferProperties")!;
				return _PixelTransferProperties;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PropagatePerFrameHdrDisplayMetadata;
		/// <summary>Represents the value associated with the constant 'kVTDecompressionPropertyKey_PropagatePerFrameHDRDisplayMetadata'.</summary>
		[Field ("kVTDecompressionPropertyKey_PropagatePerFrameHDRDisplayMetadata",  "VideoToolbox")]
		[SupportedOSPlatform ("ios14.1")]
		[SupportedOSPlatform ("tvos14.2")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString PropagatePerFrameHdrDisplayMetadata {
			[SupportedOSPlatform ("ios14.1")]
			[SupportedOSPlatform ("tvos14.2")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PropagatePerFrameHdrDisplayMetadata is null)
					_PropagatePerFrameHdrDisplayMetadata = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_PropagatePerFrameHDRDisplayMetadata")!;
				return _PropagatePerFrameHdrDisplayMetadata;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RealTime;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_RealTime",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString RealTime {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_RealTime is null)
					_RealTime = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_RealTime")!;
				return _RealTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReducedCoefficientDecode;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_ReducedCoefficientDecode",  "VideoToolbox")]
		public static NSString ReducedCoefficientDecode {
			get {
				if (_ReducedCoefficientDecode is null)
					_ReducedCoefficientDecode = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ReducedCoefficientDecode")!;
				return _ReducedCoefficientDecode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReducedFrameDelivery;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_ReducedFrameDelivery",  "VideoToolbox")]
		public static NSString ReducedFrameDelivery {
			get {
				if (_ReducedFrameDelivery is null)
					_ReducedFrameDelivery = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ReducedFrameDelivery")!;
				return _ReducedFrameDelivery;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ReducedResolutionDecode;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_ReducedResolutionDecode",  "VideoToolbox")]
		public static NSString ReducedResolutionDecode {
			get {
				if (_ReducedResolutionDecode is null)
					_ReducedResolutionDecode = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ReducedResolutionDecode")!;
				return _ReducedResolutionDecode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SuggestedQualityOfServiceTiers;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_SuggestedQualityOfServiceTiers",  "VideoToolbox")]
		public static NSString SuggestedQualityOfServiceTiers {
			get {
				if (_SuggestedQualityOfServiceTiers is null)
					_SuggestedQualityOfServiceTiers = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_SuggestedQualityOfServiceTiers")!;
				return _SuggestedQualityOfServiceTiers;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportedPixelFormatsOrderedByPerformance;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByPerformance",  "VideoToolbox")]
		public static NSString SupportedPixelFormatsOrderedByPerformance {
			get {
				if (_SupportedPixelFormatsOrderedByPerformance is null)
					_SupportedPixelFormatsOrderedByPerformance = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByPerformance")!;
				return _SupportedPixelFormatsOrderedByPerformance;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SupportedPixelFormatsOrderedByQuality;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByQuality",  "VideoToolbox")]
		public static NSString SupportedPixelFormatsOrderedByQuality {
			get {
				if (_SupportedPixelFormatsOrderedByQuality is null)
					_SupportedPixelFormatsOrderedByQuality = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByQuality")!;
				return _SupportedPixelFormatsOrderedByQuality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TemporalLevelLimit;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionProperty_TemporalLevelLimit",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TemporalLevelLimit {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TemporalLevelLimit is null)
					_TemporalLevelLimit = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_TemporalLevelLimit")!;
				return _TemporalLevelLimit;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThreadCount;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_ThreadCount",  "VideoToolbox")]
		public static NSString ThreadCount {
			get {
				if (_ThreadCount is null)
					_ThreadCount = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ThreadCount")!;
				return _ThreadCount;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UsingGpuRegistryId;
		/// <summary>Represents the value associated with the constant 'kVTDecompressionPropertyKey_UsingGPURegistryID'.</summary>
		[Field ("kVTDecompressionPropertyKey_UsingGPURegistryID",  "VideoToolbox")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString UsingGpuRegistryId {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_UsingGpuRegistryId is null)
					_UsingGpuRegistryId = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_UsingGPURegistryID")!;
				return _UsingGpuRegistryId;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UsingHardwareAcceleratedVideoDecoder;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kVTDecompressionPropertyKey_UsingHardwareAcceleratedVideoDecoder",  "VideoToolbox")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString UsingHardwareAcceleratedVideoDecoder {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_UsingHardwareAcceleratedVideoDecoder is null)
					_UsingHardwareAcceleratedVideoDecoder = Dlfcn.GetStringConstant (Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_UsingHardwareAcceleratedVideoDecoder")!;
				return _UsingHardwareAcceleratedVideoDecoder;
			}
		}
	} /* class VTDecompressionPropertyKey */
}
