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
	/// <summary>Delegate object that receives notifications when capturing photos with the <see cref="T:AVFoundation.AVCapturePhotoOutput" /> class.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/AVFoundation/AVCapturePhotoCaptureDelegate">Apple documentation for <c>AVCapturePhotoCaptureDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVCapturePhotoCaptureDelegate", WrapperType = typeof (AVCapturePhotoCaptureDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginCapture", Selector = "captureOutput:willBeginCaptureForResolvedSettings:", ParameterType = new Type [] { typeof (AVCapturePhotoOutput), typeof (AVCaptureResolvedPhotoSettings) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCapturePhoto", Selector = "captureOutput:willCapturePhotoForResolvedSettings:", ParameterType = new Type [] { typeof (AVCapturePhotoOutput), typeof (AVCaptureResolvedPhotoSettings) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCapturePhoto", Selector = "captureOutput:didCapturePhotoForResolvedSettings:", ParameterType = new Type [] { typeof (AVCapturePhotoOutput), typeof (AVCaptureResolvedPhotoSettings) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishProcessingPhoto", Selector = "captureOutput:didFinishProcessingPhoto:error:", ParameterType = new Type [] { typeof (AVCapturePhotoOutput), typeof (AVCapturePhoto), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishRecordingLivePhotoMovie", Selector = "captureOutput:didFinishRecordingLivePhotoMovieForEventualFileAtURL:resolvedSettings:", ParameterType = new Type [] { typeof (AVCapturePhotoOutput), typeof (NSUrl), typeof (AVCaptureResolvedPhotoSettings) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishProcessingLivePhotoMovie", Selector = "captureOutput:didFinishProcessingLivePhotoToMovieFileAtURL:duration:photoDisplayTime:resolvedSettings:error:", ParameterType = new Type [] { typeof (AVCapturePhotoOutput), typeof (NSUrl), typeof (CMTime), typeof (CMTime), typeof (AVCaptureResolvedPhotoSettings), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishCapture", Selector = "captureOutput:didFinishCaptureForResolvedSettings:error:", ParameterType = new Type [] { typeof (AVCapturePhotoOutput), typeof (AVCaptureResolvedPhotoSettings), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAVCapturePhotoCaptureDelegate : INativeObject, IDisposable
	{
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:willBeginCaptureForResolvedSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginCapture (AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			_WillBeginCapture (this, captureOutput, resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillBeginCapture (IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:willBeginCaptureForResolvedSettings:"), captureOutput__handle__, resolvedSettings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:willCapturePhotoForResolvedSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillCapturePhoto (AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			_WillCapturePhoto (this, captureOutput, resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillCapturePhoto (IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:willCapturePhotoForResolvedSettings:"), captureOutput__handle__, resolvedSettings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didCapturePhotoForResolvedSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCapturePhoto (AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			_DidCapturePhoto (this, captureOutput, resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCapturePhoto (IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didCapturePhotoForResolvedSettings:"), captureOutput__handle__, resolvedSettings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (resolvedSettings);
		}
		/// <param name="output">To be added.</param><param name="photo">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didFinishProcessingPhoto:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishProcessingPhoto (AVCapturePhotoOutput output, AVCapturePhoto photo, NSError? error)
		{
			_DidFinishProcessingPhoto (this, output, photo, error);
		}
		/// <param name="output">To be added.</param><param name="photo">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishProcessingPhoto (IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput output, AVCapturePhoto photo, NSError? error)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didFinishProcessingPhoto:error:"), output__handle__, photo__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (output);
			GC.KeepAlive (photo);
			GC.KeepAlive (error);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didFinishRecordingLivePhotoMovieForEventualFileAtURL:resolvedSettings:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishRecordingLivePhotoMovie (AVCapturePhotoOutput captureOutput, NSUrl outputFileUrl, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			_DidFinishRecordingLivePhotoMovie (this, captureOutput, outputFileUrl, resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishRecordingLivePhotoMovie (IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, NSUrl outputFileUrl, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didFinishRecordingLivePhotoMovieForEventualFileAtURL:resolvedSettings:"), captureOutput__handle__, outputFileUrl__handle__, resolvedSettings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
			GC.KeepAlive (resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="duration">To be added.</param><param name="photoDisplayTime">To be added.</param><param name="resolvedSettings">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didFinishProcessingLivePhotoToMovieFileAtURL:duration:photoDisplayTime:resolvedSettings:error:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishProcessingLivePhotoMovie (AVCapturePhotoOutput captureOutput, NSUrl outputFileUrl, global::CoreMedia.CMTime duration, global::CoreMedia.CMTime photoDisplayTime, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
		{
			_DidFinishProcessingLivePhotoMovie (this, captureOutput, outputFileUrl, duration, photoDisplayTime, resolvedSettings, error);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="duration">To be added.</param><param name="photoDisplayTime">To be added.</param><param name="resolvedSettings">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishProcessingLivePhotoMovie (IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, NSUrl outputFileUrl, global::CoreMedia.CMTime duration, global::CoreMedia.CMTime photoDisplayTime, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTime_CMTime_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didFinishProcessingLivePhotoToMovieFileAtURL:duration:photoDisplayTime:resolvedSettings:error:"), captureOutput__handle__, outputFileUrl__handle__, duration, photoDisplayTime, resolvedSettings__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
			GC.KeepAlive (resolvedSettings);
			GC.KeepAlive (error);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("captureOutput:didFinishCaptureForResolvedSettings:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishCapture (AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
		{
			_DidFinishCapture (this, captureOutput, resolvedSettings, error);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishCapture (IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didFinishCaptureForResolvedSettings:error:"), captureOutput__handle__, resolvedSettings__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (resolvedSettings);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidCapturePhoto(AVFoundation.AVCapturePhotoOutput,AVFoundation.AVCaptureResolvedPhotoSettings)")]
		[DynamicDependencyAttribute ("DidFinishCapture(AVFoundation.AVCapturePhotoOutput,AVFoundation.AVCaptureResolvedPhotoSettings,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinishProcessingLivePhotoMovie(AVFoundation.AVCapturePhotoOutput,Foundation.NSUrl,CoreMedia.CMTime,CoreMedia.CMTime,AVFoundation.AVCaptureResolvedPhotoSettings,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinishProcessingPhoto(AVFoundation.AVCapturePhotoOutput,AVFoundation.AVCapturePhoto,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFinishRecordingLivePhotoMovie(AVFoundation.AVCapturePhotoOutput,Foundation.NSUrl,AVFoundation.AVCaptureResolvedPhotoSettings)")]
		[DynamicDependencyAttribute ("WillBeginCapture(AVFoundation.AVCapturePhotoOutput,AVFoundation.AVCaptureResolvedPhotoSettings)")]
		[DynamicDependencyAttribute ("WillCapturePhoto(AVFoundation.AVCapturePhotoOutput,AVFoundation.AVCaptureResolvedPhotoSettings)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCapturePhotoCaptureDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVCapturePhotoCaptureDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVCapturePhotoCaptureDelegate" /> interface to support all the methods from the AVCapturePhotoCaptureDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVCapturePhotoCaptureDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVCapturePhotoCaptureDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVCapturePhotoCaptureDelegate_Extensions {
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillBeginCapture (this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:willBeginCaptureForResolvedSettings:"), captureOutput__handle__, resolvedSettings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillCapturePhoto (this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:willCapturePhotoForResolvedSettings:"), captureOutput__handle__, resolvedSettings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCapturePhoto (this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didCapturePhotoForResolvedSettings:"), captureOutput__handle__, resolvedSettings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (resolvedSettings);
		}
		/// <param name="output">To be added.</param><param name="photo">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishProcessingPhoto (this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput output, AVCapturePhoto photo, NSError? error)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			var photo__handle__ = photo!.GetNonNullHandle (nameof (photo));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didFinishProcessingPhoto:error:"), output__handle__, photo__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (output);
			GC.KeepAlive (photo);
			GC.KeepAlive (error);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishRecordingLivePhotoMovie (this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, NSUrl outputFileUrl, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didFinishRecordingLivePhotoMovieForEventualFileAtURL:resolvedSettings:"), captureOutput__handle__, outputFileUrl__handle__, resolvedSettings__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
			GC.KeepAlive (resolvedSettings);
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="duration">To be added.</param><param name="photoDisplayTime">To be added.</param><param name="resolvedSettings">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishProcessingLivePhotoMovie (this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, NSUrl outputFileUrl, global::CoreMedia.CMTime duration, global::CoreMedia.CMTime photoDisplayTime, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var outputFileUrl__handle__ = outputFileUrl!.GetNonNullHandle (nameof (outputFileUrl));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTime_CMTime_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didFinishProcessingLivePhotoToMovieFileAtURL:duration:photoDisplayTime:resolvedSettings:error:"), captureOutput__handle__, outputFileUrl__handle__, duration, photoDisplayTime, resolvedSettings__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (outputFileUrl);
			GC.KeepAlive (resolvedSettings);
			GC.KeepAlive (error);
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishCapture (this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
		{
			var captureOutput__handle__ = captureOutput!.GetNonNullHandle (nameof (captureOutput));
			var resolvedSettings__handle__ = resolvedSettings!.GetNonNullHandle (nameof (resolvedSettings));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("captureOutput:didFinishCaptureForResolvedSettings:error:"), captureOutput__handle__, resolvedSettings__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (captureOutput);
			GC.KeepAlive (resolvedSettings);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVCapturePhotoCaptureDelegateWrapper : BaseWrapper, IAVCapturePhotoCaptureDelegate {
		public AVCapturePhotoCaptureDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCapturePhotoCaptureDelegateWrapper))]
		static AVCapturePhotoCaptureDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>Delegate object that receives notifications when capturing photos with the <see cref="T:AVFoundation.AVCapturePhotoOutput" /> class.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/AVFoundation/AVCapturePhotoCaptureDelegate">Apple documentation for <c>AVCapturePhotoCaptureDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__AVFoundation_AVCapturePhotoCaptureDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVCapturePhotoCaptureDelegate : NSObject, IAVCapturePhotoCaptureDelegate {
		/// <summary>Creates a new <see cref="AVCapturePhotoCaptureDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVCapturePhotoCaptureDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
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
		protected AVCapturePhotoCaptureDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal AVCapturePhotoCaptureDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didCapturePhotoForResolvedSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCapturePhoto (AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didFinishCaptureForResolvedSettings:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishCapture (AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="duration">To be added.</param><param name="photoDisplayTime">To be added.</param><param name="resolvedSettings">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didFinishProcessingLivePhotoToMovieFileAtURL:duration:photoDisplayTime:resolvedSettings:error:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishProcessingLivePhotoMovie (AVCapturePhotoOutput captureOutput, NSUrl outputFileUrl, global::CoreMedia.CMTime duration, global::CoreMedia.CMTime photoDisplayTime, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="output">To be added.</param><param name="photo">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didFinishProcessingPhoto:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishProcessingPhoto (AVCapturePhotoOutput output, AVCapturePhoto photo, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="captureOutput">To be added.</param><param name="outputFileUrl">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:didFinishRecordingLivePhotoMovieForEventualFileAtURL:resolvedSettings:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishRecordingLivePhotoMovie (AVCapturePhotoOutput captureOutput, NSUrl outputFileUrl, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:willBeginCaptureForResolvedSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillBeginCapture (AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="captureOutput">To be added.</param><param name="resolvedSettings">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("captureOutput:willCapturePhotoForResolvedSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillCapturePhoto (AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVCapturePhotoCaptureDelegate */
}
