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
namespace CoreMedia {
	/// <summary>The keys for <see cref="T:CoreMedia.CMSampleBuffer" /> attachments.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class CMSampleBufferAttachmentSettings : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CMSampleBufferAttachmentSettings" /> with default (empty) values.</summary>
		public CMSampleBufferAttachmentSettings () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CMSampleBufferAttachmentSettings" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CMSampleBufferAttachmentSettings (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? PostNotificationWhenConsumed {
			get {
				return GetNSDictionary (CMSampleAttachmentKey.PostNotificationWhenConsumedKey!);
			}
			set {
				SetNativeValue (CMSampleAttachmentKey.PostNotificationWhenConsumedKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? ResumeOutput {
			get {
				return  GetBoolValue (CMSampleAttachmentKey.ResumeOutputKey!);
			}
			set {
				SetBooleanValue (CMSampleAttachmentKey.ResumeOutputKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? TransitionId {
			get {
				return  GetInt32Value (CMSampleAttachmentKey.TransitionIdKey!);
			}
			set {
				SetNumberValue (CMSampleAttachmentKey.TransitionIdKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? TrimDurationAtStart {
			get {
				return GetNSDictionary (CMSampleAttachmentKey.TrimDurationAtStartKey!);
			}
			set {
				SetNativeValue (CMSampleAttachmentKey.TrimDurationAtStartKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary? TrimDurationAtEnd {
			get {
				return GetNSDictionary (CMSampleAttachmentKey.TrimDurationAtEndKey!);
			}
			set {
				SetNativeValue (CMSampleAttachmentKey.TrimDurationAtEndKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public float? SpeedMultiplier {
			get {
				return  GetFloatValue (CMSampleAttachmentKey.SpeedMultiplierKey!);
			}
			set {
				SetNumberValue (CMSampleAttachmentKey.SpeedMultiplierKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSUrl? SampleReferenceUrl {
			get {
				return Dictionary [CMSampleAttachmentKey.SampleReferenceUrlKey!] as Foundation.NSUrl;
			}
			set {
				SetNativeValue (CMSampleAttachmentKey.SampleReferenceUrlKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public int? SampleReferenceByteOffset {
			get {
				return  GetInt32Value (CMSampleAttachmentKey.SampleReferenceByteOffsetKey!);
			}
			set {
				SetNumberValue (CMSampleAttachmentKey.SampleReferenceByteOffsetKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? GradualDecoderRefresh {
			get {
				return Dictionary [CMSampleAttachmentKey.GradualDecoderRefreshKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (CMSampleAttachmentKey.GradualDecoderRefreshKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public CMHevcTemporalLevelInfoSettings? HevcTemporalLevelInfo {
			get {
				return GetStrongDictionary<CMHevcTemporalLevelInfoSettings>(CMSampleAttachmentKey.HevcTemporalLevelInfoKey!, (dict) => new CMHevcTemporalLevelInfoSettings (dict));
			}
			set {
				SetNativeValue (CMSampleAttachmentKey.HevcTemporalLevelInfoKey!, value?.Dictionary);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? HevcTemporalSubLayerAccess {
			get {
				return  GetBoolValue (CMSampleAttachmentKey.HevcTemporalSubLayerAccessKey!);
			}
			set {
				SetBooleanValue (CMSampleAttachmentKey.HevcTemporalSubLayerAccessKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? HevcStepwiseTemporalSubLayerAccess {
			get {
				return  GetBoolValue (CMSampleAttachmentKey.HevcStepwiseTemporalSubLayerAccessKey!);
			}
			set {
				SetBooleanValue (CMSampleAttachmentKey.HevcStepwiseTemporalSubLayerAccessKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public int? HevcSyncSampleNalUnitType {
			get {
				return  GetInt32Value (CMSampleAttachmentKey.HevcSyncSampleNalUnitTypeKey!);
			}
			set {
				SetNumberValue (CMSampleAttachmentKey.HevcSyncSampleNalUnitTypeKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public NSData? CameraIntrinsicMatrix {
			get {
				return Dictionary [CMSampleAttachmentKey.CameraIntrinsicMatrixKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMSampleAttachmentKey.CameraIntrinsicMatrixKey!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public nint? AudioIndependentSampleDecoderRefreshCount {
			get {
				return  GetNIntValue (CMSampleAttachmentKey.AudioIndependentSampleDecoderRefreshCountKey!);
			}
			set {
				SetNumberValue (CMSampleAttachmentKey.AudioIndependentSampleDecoderRefreshCountKey!, value);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? ForceKeyFrame {
			get {
				return  GetBoolValue (CMSampleAttachmentKey.ForceKeyFrameKey!);
			}
			set {
				SetBooleanValue (CMSampleAttachmentKey.ForceKeyFrameKey!, value);
			}
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public NSData? Hdr10PlusPerFrameData {
			get {
				return Dictionary [CMSampleAttachmentKey.Hdr10PlusPerFrameDataKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (CMSampleAttachmentKey.Hdr10PlusPerFrameDataKey!, value);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos15.0")]
		public NSDictionary? PostDecodeProcessingMetadata {
			get {
				return GetNSDictionary (CMSampleAttachmentKey.PostDecodeProcessingMetadataKey!);
			}
			set {
				SetNativeValue (CMSampleAttachmentKey.PostDecodeProcessingMetadataKey!, value);
			}
		}
#endif
	}
}
