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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVCapturePhotoFileDataRepresentationCustomizer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "AVCapturePhotoFileDataRepresentationCustomizer", WrapperType = typeof (AVCapturePhotoFileDataRepresentationCustomizerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetReplacementMetadata", Selector = "replacementMetadataForPhoto:", ReturnType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), ParameterType = new Type [] { typeof (AVCapturePhoto) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetReplacementEmbeddedThumbnail", Selector = "replacementEmbeddedThumbnailPixelBufferWithPhotoFormat:forPhoto:", ReturnType = typeof (CVPixelBuffer), ParameterType = new Type [] { typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (AVCapturePhoto) }, ParameterByRef = new bool [] { true, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetReplacementDepthData", Selector = "replacementDepthDataForPhoto:", ReturnType = typeof (AVDepthData), ParameterType = new Type [] { typeof (AVCapturePhoto) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetReplacementPortraitEffectsMatte", Selector = "replacementPortraitEffectsMatteForPhoto:", ReturnType = typeof (AVPortraitEffectsMatte), ParameterType = new Type [] { typeof (AVCapturePhoto) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetReplacementSemanticSegmentationMatte", Selector = "replacementSemanticSegmentationMatteOfType:forPhoto:", ReturnType = typeof (AVSemanticSegmentationMatte), ParameterType = new Type [] { typeof (NSString), typeof (AVCapturePhoto) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetReplacementAppleProRawCompressionSettings", Selector = "replacementAppleProRAWCompressionSettingsForPhoto:defaultSettings:maximumBitDepth:", ReturnType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), ParameterType = new Type [] { typeof (AVCapturePhoto), typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAVCapturePhotoFileDataRepresentationCustomizer : INativeObject, IDisposable
	{
		/// <param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("replacementMetadataForPhoto:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject>? GetReplacementMetadata (AVCapturePhoto photo)
		{
			return _GetReplacementMetadata (this, photo);
		}
		/// <param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSObject>? _GetReplacementMetadata (IAVCapturePhotoFileDataRepresentationCustomizer This, AVCapturePhoto photo)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("replacementMetadataForPhoto:"), photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			return ret!;
		}
		/// <param name="replacementEmbeddedThumbnailPhotoFormatOut">To be added.</param><param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("replacementEmbeddedThumbnailPixelBufferWithPhotoFormat:forPhoto:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::CoreVideo.CVPixelBuffer? GetReplacementEmbeddedThumbnail (out NSDictionary<NSString, NSObject>? replacementEmbeddedThumbnailPhotoFormatOut, AVCapturePhoto photo)
		{
			return _GetReplacementEmbeddedThumbnail (this, out replacementEmbeddedThumbnailPhotoFormatOut, photo);
		}
		/// <param name="replacementEmbeddedThumbnailPhotoFormatOut">To be added.</param><param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static global::CoreVideo.CVPixelBuffer? _GetReplacementEmbeddedThumbnail (IAVCapturePhotoFileDataRepresentationCustomizer This, out NSDictionary<NSString, NSObject>? replacementEmbeddedThumbnailPhotoFormatOut, AVCapturePhoto photo)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			NativeHandle replacementEmbeddedThumbnailPhotoFormatOutValue = IntPtr.Zero;
			global::CoreVideo.CVPixelBuffer? ret;
			ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replacementEmbeddedThumbnailPixelBufferWithPhotoFormat:forPhoto:"), &replacementEmbeddedThumbnailPhotoFormatOutValue, photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			replacementEmbeddedThumbnailPhotoFormatOut = Runtime.GetNSObject<global::Foundation.NSDictionary<NSString, NSObject>> (replacementEmbeddedThumbnailPhotoFormatOutValue)!;
			return ret!;
		}
		/// <param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("replacementDepthDataForPhoto:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVDepthData? GetReplacementDepthData (AVCapturePhoto photo)
		{
			return _GetReplacementDepthData (this, photo);
		}
		/// <param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AVDepthData? _GetReplacementDepthData (IAVCapturePhotoFileDataRepresentationCustomizer This, AVCapturePhoto photo)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			AVDepthData? ret;
			ret =  Runtime.GetNSObject<AVDepthData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("replacementDepthDataForPhoto:"), photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			return ret!;
		}
		/// <param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("replacementPortraitEffectsMatteForPhoto:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVPortraitEffectsMatte? GetReplacementPortraitEffectsMatte (AVCapturePhoto photo)
		{
			return _GetReplacementPortraitEffectsMatte (this, photo);
		}
		/// <param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AVPortraitEffectsMatte? _GetReplacementPortraitEffectsMatte (IAVCapturePhotoFileDataRepresentationCustomizer This, AVCapturePhoto photo)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			AVPortraitEffectsMatte? ret;
			ret =  Runtime.GetNSObject<AVPortraitEffectsMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("replacementPortraitEffectsMatteForPhoto:"), photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("replacementSemanticSegmentationMatteOfType:forPhoto:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVSemanticSegmentationMatte? GetReplacementSemanticSegmentationMatte (NSString semanticSegmentationMatteType, AVCapturePhoto photo)
		{
			return _GetReplacementSemanticSegmentationMatte (this, semanticSegmentationMatteType, photo);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AVSemanticSegmentationMatte? _GetReplacementSemanticSegmentationMatte (IAVCapturePhotoFileDataRepresentationCustomizer This, NSString semanticSegmentationMatteType, AVCapturePhoto photo)
		{
			var semanticSegmentationMatteType__handle__ = semanticSegmentationMatteType!.GetNonNullHandle (nameof (semanticSegmentationMatteType));
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			AVSemanticSegmentationMatte? ret;
			ret =  Runtime.GetNSObject<AVSemanticSegmentationMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replacementSemanticSegmentationMatteOfType:forPhoto:"), semanticSegmentationMatteType__handle__, photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (semanticSegmentationMatteType);
			GC.KeepAlive (photo);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("replacementAppleProRAWCompressionSettingsForPhoto:defaultSettings:maximumBitDepth:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSObject> GetReplacementAppleProRawCompressionSettings (AVCapturePhoto photo, NSDictionary<NSString, NSObject> defaultSettings, nint maximumBitDepth)
		{
			return _GetReplacementAppleProRawCompressionSettings (this, photo, defaultSettings, maximumBitDepth);
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSObject> _GetReplacementAppleProRawCompressionSettings (IAVCapturePhotoFileDataRepresentationCustomizer This, AVCapturePhoto photo, NSDictionary<NSString, NSObject> defaultSettings, nint maximumBitDepth)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			var defaultSettings__handle__ = defaultSettings!.GetNonNullHandle (nameof (defaultSettings));
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("replacementAppleProRAWCompressionSettingsForPhoto:defaultSettings:maximumBitDepth:"), photo__handle__, defaultSettings__handle__, maximumBitDepth), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			GC.KeepAlive (defaultSettings);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetReplacementAppleProRawCompressionSettings(AVFoundation.AVCapturePhoto,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject},System.IntPtr)")]
		[DynamicDependencyAttribute ("GetReplacementDepthData(AVFoundation.AVCapturePhoto)")]
		[DynamicDependencyAttribute ("GetReplacementEmbeddedThumbnail(Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject}@,AVFoundation.AVCapturePhoto)")]
		[DynamicDependencyAttribute ("GetReplacementMetadata(AVFoundation.AVCapturePhoto)")]
		[DynamicDependencyAttribute ("GetReplacementPortraitEffectsMatte(AVFoundation.AVCapturePhoto)")]
		[DynamicDependencyAttribute ("GetReplacementSemanticSegmentationMatte(Foundation.NSString,AVFoundation.AVCapturePhoto)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCapturePhotoFileDataRepresentationCustomizerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVCapturePhotoFileDataRepresentationCustomizer ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVCapturePhotoFileDataRepresentationCustomizer" /> interface to support all the methods from the AVCapturePhotoFileDataRepresentationCustomizer protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVCapturePhotoFileDataRepresentationCustomizer" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVCapturePhotoFileDataRepresentationCustomizer protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVCapturePhotoFileDataRepresentationCustomizer_Extensions {
		/// <param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSObject>? GetReplacementMetadata (this IAVCapturePhotoFileDataRepresentationCustomizer This, AVCapturePhoto photo)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("replacementMetadataForPhoto:"), photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			return ret!;
		}
		/// <param name="replacementEmbeddedThumbnailPhotoFormatOut">To be added.</param><param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static global::CoreVideo.CVPixelBuffer? GetReplacementEmbeddedThumbnail (this IAVCapturePhotoFileDataRepresentationCustomizer This, out NSDictionary<NSString, NSObject>? replacementEmbeddedThumbnailPhotoFormatOut, AVCapturePhoto photo)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			NativeHandle replacementEmbeddedThumbnailPhotoFormatOutValue = IntPtr.Zero;
			global::CoreVideo.CVPixelBuffer? ret;
			ret = Runtime.GetINativeObject<CVPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replacementEmbeddedThumbnailPixelBufferWithPhotoFormat:forPhoto:"), &replacementEmbeddedThumbnailPhotoFormatOutValue, photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			replacementEmbeddedThumbnailPhotoFormatOut = Runtime.GetNSObject<global::Foundation.NSDictionary<NSString, NSObject>> (replacementEmbeddedThumbnailPhotoFormatOutValue)!;
			return ret!;
		}
		/// <param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVDepthData? GetReplacementDepthData (this IAVCapturePhotoFileDataRepresentationCustomizer This, AVCapturePhoto photo)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			AVDepthData? ret;
			ret =  Runtime.GetNSObject<AVDepthData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("replacementDepthDataForPhoto:"), photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			return ret!;
		}
		/// <param name="photo">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVPortraitEffectsMatte? GetReplacementPortraitEffectsMatte (this IAVCapturePhotoFileDataRepresentationCustomizer This, AVCapturePhoto photo)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			AVPortraitEffectsMatte? ret;
			ret =  Runtime.GetNSObject<AVPortraitEffectsMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("replacementPortraitEffectsMatteForPhoto:"), photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVSemanticSegmentationMatte? GetReplacementSemanticSegmentationMatte (this IAVCapturePhotoFileDataRepresentationCustomizer This, NSString semanticSegmentationMatteType, AVCapturePhoto photo)
		{
			var semanticSegmentationMatteType__handle__ = semanticSegmentationMatteType!.GetNonNullHandle (nameof (semanticSegmentationMatteType));
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			AVSemanticSegmentationMatte? ret;
			ret =  Runtime.GetNSObject<AVSemanticSegmentationMatte> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replacementSemanticSegmentationMatteOfType:forPhoto:"), semanticSegmentationMatteType__handle__, photo__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (semanticSegmentationMatteType);
			GC.KeepAlive (photo);
			return ret!;
		}
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.3")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSObject> GetReplacementAppleProRawCompressionSettings (this IAVCapturePhotoFileDataRepresentationCustomizer This, AVCapturePhoto photo, NSDictionary<NSString, NSObject> defaultSettings, nint maximumBitDepth)
		{
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			var defaultSettings__handle__ = defaultSettings!.GetNonNullHandle (nameof (defaultSettings));
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("replacementAppleProRAWCompressionSettingsForPhoto:defaultSettings:maximumBitDepth:"), photo__handle__, defaultSettings__handle__, maximumBitDepth), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (photo);
			GC.KeepAlive (defaultSettings);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVCapturePhotoFileDataRepresentationCustomizerWrapper : BaseWrapper, IAVCapturePhotoFileDataRepresentationCustomizer {
		public AVCapturePhotoFileDataRepresentationCustomizerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCapturePhotoFileDataRepresentationCustomizerWrapper))]
		static AVCapturePhotoFileDataRepresentationCustomizerWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
