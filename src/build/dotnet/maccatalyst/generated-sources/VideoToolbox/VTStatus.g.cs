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
namespace VideoToolbox {
	/// <summary>Possible VideoToolbox API errors.</summary>
	public enum VTStatus : int {
		/// <summary>To be added.</summary>
		Ok = 0,
		/// <summary>To be added.</summary>
		PropertyNotSupported = -12900,
		/// <summary>To be added.</summary>
		PropertyReadOnly = -12901,
		/// <summary>To be added.</summary>
		Parameter = -12902,
		/// <summary>To be added.</summary>
		InvalidSession = -12903,
		/// <summary>To be added.</summary>
		AllocationFailed = -12904,
		/// <summary>To be added.</summary>
		PixelTransferNotSupported = -12905,
		/// <summary>To be added.</summary>
		CouldNotFindVideoDecoder = -12906,
		/// <summary>To be added.</summary>
		CouldNotCreateInstance = -12907,
		/// <summary>To be added.</summary>
		CouldNotFindVideoEncoder = -12908,
		/// <summary>To be added.</summary>
		VideoDecoderBadData = -12909,
		/// <summary>To be added.</summary>
		VideoDecoderUnsupportedDataFormat = -12910,
		/// <summary>To be added.</summary>
		VideoDecoderMalfunction = -12911,
		/// <summary>To be added.</summary>
		VideoEncoderMalfunction = -12912,
		/// <summary>To be added.</summary>
		VideoDecoderNotAvailableNow = -12913,
		/// <summary>To be added.</summary>
		[Obsolete ("Use PixelRotationNotSupported enum value instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		ImageRotationNotSupported = -12914,
		PixelRotationNotSupported = -12914,
		/// <summary>To be added.</summary>
		VideoEncoderNotAvailableNow = -12915,
		/// <summary>To be added.</summary>
		FormatDescriptionChangeNotSupported = -12916,
		/// <summary>To be added.</summary>
		InsufficientSourceColorData = -12917,
		/// <summary>To be added.</summary>
		CouldNotCreateColorCorrectionData = -12918,
		/// <summary>To be added.</summary>
		ColorSyncTransformConvertFailed = -12919,
		/// <summary>To be added.</summary>
		VideoDecoderAuthorization = -12210,
		/// <summary>To be added.</summary>
		VideoEncoderAuthorization = -12211,
		/// <summary>To be added.</summary>
		ColorCorrectionPixelTransferFailed = -12212,
		/// <summary>To be added.</summary>
		MultiPassStorageIdentifierMismatch = -12913,
		/// <summary>To be added.</summary>
		MultiPassStorageInvalid = -12214,
		/// <summary>To be added.</summary>
		FrameSiloInvalidTimeStamp = -12215,
		/// <summary>To be added.</summary>
		FrameSiloInvalidTimeRange = -12216,
		/// <summary>To be added.</summary>
		CouldNotFindTemporalFilter = -12217,
		/// <summary>To be added.</summary>
		PixelTransferNotPermitted = -12218,
		/// <summary>To be added.</summary>
		ColorCorrectionImageRotationFailed = -12219,
		/// <summary>To be added.</summary>
		VideoDecoderRemoved = -17690,
		SessionMalfunction = -17691,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		DecoderNeedsRosetta = -17692,
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		EncoderNeedsRosetta = -17693,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		VideoDecoderReferenceMissing = -17694,
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("macos")]
		VideoDecoderCallbackMessaging = -17695,
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		VideoDecoderUnknownErr = -17696,
		ExtensionDisabledErr = -17697,
		VideoEncoderMVHEVCVideoLayerIDsMismatchErr = -17698,
		CouldNotOutputTaggedBufferGroupErr = -17699,
		CouldNotFindExtensionErr = -19510,
		ExtensionConflictErr = -19511,
		VideoEncoderAutoWhiteBalanceNotLockedErr = -19512,
	}
}
