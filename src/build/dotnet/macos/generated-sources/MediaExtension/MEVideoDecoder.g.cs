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
namespace MediaExtension {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MEVideoDecoder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "MEVideoDecoder", WrapperType = typeof (MEVideoDecoderWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DecodeFrame", Selector = "decodeFrameFromSampleBuffer:options:completionHandler:", ParameterType = new Type [] { typeof (CMSampleBuffer), typeof (MediaExtension.MEDecodeFrameOptions), typeof (MediaExtension.MEVideoDecoderDecodeFrameCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDMEVideoDecoderDecodeFrameCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanAcceptFormatDescription", Selector = "canAcceptFormatDescription:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CMFormatDescription) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProducesRawOutput", Selector = "producesRAWOutput", PropertyType = typeof (bool), GetterSelector = "producesRAWOutput", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ContentHasInterframeDependencies", Selector = "contentHasInterframeDependencies", PropertyType = typeof (bool), GetterSelector = "contentHasInterframeDependencies", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "RecommendedThreadCount", Selector = "recommendedThreadCount", PropertyType = typeof (IntPtr), GetterSelector = "recommendedThreadCount", SetterSelector = "setRecommendedThreadCount:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ActualThreadCount", Selector = "actualThreadCount", PropertyType = typeof (IntPtr), GetterSelector = "actualThreadCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportedPixelFormatsOrderedByQuality", Selector = "supportedPixelFormatsOrderedByQuality", PropertyType = typeof (NSNumber[]), GetterSelector = "supportedPixelFormatsOrderedByQuality", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ReducedResolution", Selector = "reducedResolution", PropertyType = typeof (CGSize), GetterSelector = "reducedResolution", SetterSelector = "setReducedResolution:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PixelFormatsWithReducedResolutionDecodeSupport", Selector = "pixelFormatsWithReducedResolutionDecodeSupport", PropertyType = typeof (NSNumber[]), GetterSelector = "pixelFormatsWithReducedResolutionDecodeSupport", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReadyForMoreMediaData", Selector = "readyForMoreMediaData", PropertyType = typeof (bool), GetterSelector = "isReadyForMoreMediaData", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMEVideoDecoder : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("decodeFrameFromSampleBuffer:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecodeFrame (global::CoreMedia.CMSampleBuffer sampleBuffer, MEDecodeFrameOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEVideoDecoderDecodeFrameCallback))]MEVideoDecoderDecodeFrameCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DecodeFrame (IMEVideoDecoder This, global::CoreMedia.CMSampleBuffer sampleBuffer, MEDecodeFrameOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEVideoDecoderDecodeFrameCallback))]MEVideoDecoderDecodeFrameCallback completionHandler)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMEVideoDecoderDecodeFrameCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("decodeFrameFromSampleBuffer:options:completionHandler:"), sampleBuffer.Handle, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (sampleBuffer);
			GC.KeepAlive (options);
		}
		[global::Foundation.OptionalMember]
		[Export ("canAcceptFormatDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAcceptFormatDescription (global::CoreMedia.CMFormatDescription formatDescription)
		{
			return _CanAcceptFormatDescription (this, formatDescription);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanAcceptFormatDescription (IMEVideoDecoder This, global::CoreMedia.CMFormatDescription formatDescription)
		{
			var formatDescription__handle__ = formatDescription!.GetNonNullHandle (nameof (formatDescription));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canAcceptFormatDescription:"), formatDescription.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (formatDescription);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ActualThreadCount")]
		[DynamicDependencyAttribute ("CanAcceptFormatDescription(CoreMedia.CMFormatDescription)")]
		[DynamicDependencyAttribute ("ContentHasInterframeDependencies")]
		[DynamicDependencyAttribute ("DecodeFrame(CoreMedia.CMSampleBuffer,MediaExtension.MEDecodeFrameOptions,MediaExtension.MEVideoDecoderDecodeFrameCallback)")]
		[DynamicDependencyAttribute ("PixelFormatsWithReducedResolutionDecodeSupport")]
		[DynamicDependencyAttribute ("ProducesRawOutput")]
		[DynamicDependencyAttribute ("ReadyForMoreMediaData")]
		[DynamicDependencyAttribute ("RecommendedThreadCount")]
		[DynamicDependencyAttribute ("ReducedResolution")]
		[DynamicDependencyAttribute ("SupportedPixelFormatsOrderedByQuality")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEVideoDecoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEVideoDecoder ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool ProducesRawOutput {
			[Export ("producesRAWOutput")]
			get {
				return _GetProducesRawOutput (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetProducesRawOutput (IMEVideoDecoder This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("producesRAWOutput"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool ContentHasInterframeDependencies {
			[Export ("contentHasInterframeDependencies")]
			get {
				return _GetContentHasInterframeDependencies (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetContentHasInterframeDependencies (IMEVideoDecoder This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("contentHasInterframeDependencies"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nint RecommendedThreadCount {
			[Export ("recommendedThreadCount")]
			get {
				return _GetRecommendedThreadCount (this);
			}
			[Export ("setRecommendedThreadCount:")]
			set {
				_SetRecommendedThreadCount (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetRecommendedThreadCount (IMEVideoDecoder This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("recommendedThreadCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRecommendedThreadCount (IMEVideoDecoder This, nint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setRecommendedThreadCount:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nint ActualThreadCount {
			[Export ("actualThreadCount")]
			get {
				return _GetActualThreadCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetActualThreadCount (IMEVideoDecoder This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("actualThreadCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSNumber[] SupportedPixelFormatsOrderedByQuality {
			[Export ("supportedPixelFormatsOrderedByQuality")]
			get {
				return _GetSupportedPixelFormatsOrderedByQuality (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber[] _GetSupportedPixelFormatsOrderedByQuality (IMEVideoDecoder This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedPixelFormatsOrderedByQuality")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual CGSize ReducedResolution {
			[Export ("reducedResolution", ArgumentSemantic.Assign)]
			get {
				return _GetReducedResolution (this);
			}
			[Export ("setReducedResolution:", ArgumentSemantic.Assign)]
			set {
				_SetReducedResolution (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetReducedResolution (IMEVideoDecoder This)
		{
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("reducedResolution"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReducedResolution (IMEVideoDecoder This, CGSize value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("setReducedResolution:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSNumber[] PixelFormatsWithReducedResolutionDecodeSupport {
			[Export ("pixelFormatsWithReducedResolutionDecodeSupport")]
			get {
				return _GetPixelFormatsWithReducedResolutionDecodeSupport (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber[] _GetPixelFormatsWithReducedResolutionDecodeSupport (IMEVideoDecoder This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pixelFormatsWithReducedResolutionDecodeSupport")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ReadyForMoreMediaData {
			[Export ("isReadyForMoreMediaData")]
			get {
				return _GetReadyForMoreMediaData (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetReadyForMoreMediaData (IMEVideoDecoder This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isReadyForMoreMediaData"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEVideoDecoderWrapper : BaseWrapper, IMEVideoDecoder {
		public MEVideoDecoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEVideoDecoderWrapper))]
		static MEVideoDecoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("decodeFrameFromSampleBuffer:options:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DecodeFrame (global::CoreMedia.CMSampleBuffer sampleBuffer, MEDecodeFrameOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEVideoDecoderDecodeFrameCallback))]MEVideoDecoderDecodeFrameCallback completionHandler)
		{
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMEVideoDecoderDecodeFrameCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("decodeFrameFromSampleBuffer:options:completionHandler:"), sampleBuffer.Handle, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (sampleBuffer);
			GC.KeepAlive (options);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ReadyForMoreMediaData {
			[Export ("isReadyForMoreMediaData")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReadyForMoreMediaData"));
				return ret != 0;
			}
		}
	}
}
