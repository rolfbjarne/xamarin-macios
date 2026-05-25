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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>A base class for custom video compositors.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVVideoCompositing_Protocol/index.html">Apple documentation for <c>AVVideoCompositing</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVVideoCompositing", WrapperType = typeof (AVVideoCompositingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SourcePixelBufferAttributes", Selector = "sourcePixelBufferAttributes", ReturnType = typeof (NSDictionary))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequiredPixelBufferAttributesForRenderContext", Selector = "requiredPixelBufferAttributesForRenderContext", ReturnType = typeof (NSDictionary))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RenderContextChanged", Selector = "renderContextChanged:", ParameterType = new Type [] { typeof (AVVideoCompositionRenderContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartVideoCompositionRequest", Selector = "startVideoCompositionRequest:", ParameterType = new Type [] { typeof (AVAsynchronousVideoCompositionRequest) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelAllPendingVideoCompositionRequests", Selector = "cancelAllPendingVideoCompositionRequests")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnticipateRendering", Selector = "anticipateRenderingUsingHint:", ParameterType = new Type [] { typeof (AVVideoCompositionRenderHint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrerollForRendering", Selector = "prerollForRenderingUsingHint:", ParameterType = new Type [] { typeof (AVVideoCompositionRenderHint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportsWideColorSourceFrames", Selector = "supportsWideColorSourceFrames", PropertyType = typeof (bool), GetterSelector = "supportsWideColorSourceFrames", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportsHdrSourceFrames", Selector = "supportsHDRSourceFrames", PropertyType = typeof (bool), GetterSelector = "supportsHDRSourceFrames", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CanConformColorOfSourceFrames", Selector = "canConformColorOfSourceFrames", PropertyType = typeof (bool), GetterSelector = "canConformColorOfSourceFrames", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportsSourceTaggedBuffers", Selector = "supportsSourceTaggedBuffers", PropertyType = typeof (bool), GetterSelector = "supportsSourceTaggedBuffers", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IAVVideoCompositing : INativeObject, IDisposable
	{
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("sourcePixelBufferAttributes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? SourcePixelBufferAttributes ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary? _SourcePixelBufferAttributes (IAVVideoCompositing This)
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sourcePixelBufferAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("requiredPixelBufferAttributesForRenderContext")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary RequiredPixelBufferAttributesForRenderContext ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _RequiredPixelBufferAttributesForRenderContext (IAVVideoCompositing This)
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("requiredPixelBufferAttributesForRenderContext")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="newRenderContext">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("renderContextChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RenderContextChanged (AVVideoCompositionRenderContext newRenderContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="newRenderContext">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RenderContextChanged (IAVVideoCompositing This, AVVideoCompositionRenderContext newRenderContext)
		{
			var newRenderContext__handle__ = newRenderContext!.GetNonNullHandle (nameof (newRenderContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("renderContextChanged:"), newRenderContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (newRenderContext);
		}
		/// <param name="asyncVideoCompositionRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("startVideoCompositionRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartVideoCompositionRequest (AVAsynchronousVideoCompositionRequest asyncVideoCompositionRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="asyncVideoCompositionRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartVideoCompositionRequest (IAVVideoCompositing This, AVAsynchronousVideoCompositionRequest asyncVideoCompositionRequest)
		{
			var asyncVideoCompositionRequest__handle__ = asyncVideoCompositionRequest!.GetNonNullHandle (nameof (asyncVideoCompositionRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("startVideoCompositionRequest:"), asyncVideoCompositionRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (asyncVideoCompositionRequest);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("cancelAllPendingVideoCompositionRequests")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelAllPendingVideoCompositionRequests ()
		{
			_CancelAllPendingVideoCompositionRequests (this);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CancelAllPendingVideoCompositionRequests (IAVVideoCompositing This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("cancelAllPendingVideoCompositionRequests"));
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("anticipateRenderingUsingHint:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnticipateRendering (AVVideoCompositionRenderHint renderHint)
		{
			_AnticipateRendering (this, renderHint);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AnticipateRendering (IAVVideoCompositing This, AVVideoCompositionRenderHint renderHint)
		{
			var renderHint__handle__ = renderHint!.GetNonNullHandle (nameof (renderHint));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("anticipateRenderingUsingHint:"), renderHint__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderHint);
		}
		[global::Foundation.OptionalMember]
		[Export ("prerollForRenderingUsingHint:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrerollForRendering (AVVideoCompositionRenderHint renderHint)
		{
			_PrerollForRendering (this, renderHint);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PrerollForRendering (IAVVideoCompositing This, AVVideoCompositionRenderHint renderHint)
		{
			var renderHint__handle__ = renderHint!.GetNonNullHandle (nameof (renderHint));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("prerollForRenderingUsingHint:"), renderHint__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderHint);
		}
		[DynamicDependencyAttribute ("AnticipateRendering(AVFoundation.AVVideoCompositionRenderHint)")]
		[DynamicDependencyAttribute ("CancelAllPendingVideoCompositionRequests()")]
		[DynamicDependencyAttribute ("CanConformColorOfSourceFrames")]
		[DynamicDependencyAttribute ("PrerollForRendering(AVFoundation.AVVideoCompositionRenderHint)")]
		[DynamicDependencyAttribute ("RenderContextChanged(AVFoundation.AVVideoCompositionRenderContext)")]
		[DynamicDependencyAttribute ("RequiredPixelBufferAttributesForRenderContext()")]
		[DynamicDependencyAttribute ("SourcePixelBufferAttributes()")]
		[DynamicDependencyAttribute ("StartVideoCompositionRequest(AVFoundation.AVAsynchronousVideoCompositionRequest)")]
		[DynamicDependencyAttribute ("SupportsHdrSourceFrames")]
		[DynamicDependencyAttribute ("SupportsSourceTaggedBuffers")]
		[DynamicDependencyAttribute ("SupportsWideColorSourceFrames")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVVideoCompositingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVVideoCompositing ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.OptionalMember]
		public virtual bool SupportsWideColorSourceFrames {
			[Export ("supportsWideColorSourceFrames")]
			get {
				return _GetSupportsWideColorSourceFrames (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsWideColorSourceFrames (IAVVideoCompositing This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsWideColorSourceFrames"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual bool SupportsHdrSourceFrames {
			[Export ("supportsHDRSourceFrames")]
			get {
				return _GetSupportsHdrSourceFrames (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsHdrSourceFrames (IAVVideoCompositing This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsHDRSourceFrames"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual bool CanConformColorOfSourceFrames {
			[Export ("canConformColorOfSourceFrames")]
			get {
				return _GetCanConformColorOfSourceFrames (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetCanConformColorOfSourceFrames (IAVVideoCompositing This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canConformColorOfSourceFrames"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[global::Foundation.OptionalMember]
		public virtual bool SupportsSourceTaggedBuffers {
			[Export ("supportsSourceTaggedBuffers")]
			get {
				return _GetSupportsSourceTaggedBuffers (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsSourceTaggedBuffers (IAVVideoCompositing This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsSourceTaggedBuffers"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVVideoCompositing" /> interface to support all the methods from the AVVideoCompositing protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVVideoCompositing" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVVideoCompositing protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVVideoCompositing_Extensions {
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelAllPendingVideoCompositionRequests (this IAVVideoCompositing This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("cancelAllPendingVideoCompositionRequests"));
			GC.KeepAlive (This);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AnticipateRendering (this IAVVideoCompositing This, AVVideoCompositionRenderHint renderHint)
		{
			var renderHint__handle__ = renderHint!.GetNonNullHandle (nameof (renderHint));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("anticipateRenderingUsingHint:"), renderHint__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderHint);
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PrerollForRendering (this IAVVideoCompositing This, AVVideoCompositionRenderHint renderHint)
		{
			var renderHint__handle__ = renderHint!.GetNonNullHandle (nameof (renderHint));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("prerollForRenderingUsingHint:"), renderHint__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (renderHint);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsWideColorSourceFrames (this IAVVideoCompositing This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsWideColorSourceFrames"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsHdrSourceFrames (this IAVVideoCompositing This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsHDRSourceFrames"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetCanConformColorOfSourceFrames (this IAVVideoCompositing This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canConformColorOfSourceFrames"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsSourceTaggedBuffers (this IAVVideoCompositing This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsSourceTaggedBuffers"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVVideoCompositingWrapper : BaseWrapper, IAVVideoCompositing {
		public AVVideoCompositingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVVideoCompositingWrapper))]
		static AVVideoCompositingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sourcePixelBufferAttributes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary? SourcePixelBufferAttributes ()
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sourcePixelBufferAttributes")), false)!;
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("requiredPixelBufferAttributesForRenderContext")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary RequiredPixelBufferAttributesForRenderContext ()
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("requiredPixelBufferAttributesForRenderContext")), false)!;
			return ret;
		}
		/// <param name="newRenderContext">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("renderContextChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RenderContextChanged (AVVideoCompositionRenderContext newRenderContext)
		{
			var newRenderContext__handle__ = newRenderContext!.GetNonNullHandle (nameof (newRenderContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("renderContextChanged:"), newRenderContext__handle__);
			GC.KeepAlive (newRenderContext);
		}
		/// <param name="asyncVideoCompositionRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("startVideoCompositionRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartVideoCompositionRequest (AVAsynchronousVideoCompositionRequest asyncVideoCompositionRequest)
		{
			var asyncVideoCompositionRequest__handle__ = asyncVideoCompositionRequest!.GetNonNullHandle (nameof (asyncVideoCompositionRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("startVideoCompositionRequest:"), asyncVideoCompositionRequest__handle__);
			GC.KeepAlive (asyncVideoCompositionRequest);
		}
	}
}
namespace AVFoundation {
	/// <summary>A base class for custom video compositors.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AVFoundation/Reference/AVVideoCompositing_Protocol/index.html">Apple documentation for <c>AVVideoCompositing</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__AVFoundation_AVVideoCompositing", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class AVVideoCompositing : NSObject, IAVVideoCompositing {
		/// <summary>Creates a new <see cref="AVVideoCompositing" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVVideoCompositing () : base (NSObjectFlag.Empty)
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
		protected AVVideoCompositing (NSObjectFlag t) : base (t)
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
		protected internal AVVideoCompositing (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("anticipateRenderingUsingHint:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AnticipateRendering (AVVideoCompositionRenderHint renderHint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("cancelAllPendingVideoCompositionRequests")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelAllPendingVideoCompositionRequests ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("prerollForRenderingUsingHint:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrerollForRendering (AVVideoCompositionRenderHint renderHint)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="newRenderContext">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("renderContextChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RenderContextChanged (AVVideoCompositionRenderContext newRenderContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("requiredPixelBufferAttributesForRenderContext")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary RequiredPixelBufferAttributesForRenderContext ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("sourcePixelBufferAttributes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? SourcePixelBufferAttributes ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="asyncVideoCompositionRequest">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("startVideoCompositionRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartVideoCompositionRequest (AVAsynchronousVideoCompositionRequest asyncVideoCompositionRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool CanConformColorOfSourceFrames {
			[Export ("canConformColorOfSourceFrames")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool SupportsHdrSourceFrames {
			[Export ("supportsHDRSourceFrames")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual bool SupportsSourceTaggedBuffers {
			[Export ("supportsSourceTaggedBuffers")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool SupportsWideColorSourceFrames {
			[Export ("supportsWideColorSourceFrames")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class AVVideoCompositing */
}
