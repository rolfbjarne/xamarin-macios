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
namespace MetalPerformanceShaders {
	[Register("MPSSVGF", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSSvgf : MPSKernel, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSSVGF");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MPSSvgf (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected MPSSvgf (NSObjectFlag t) : base (t)
		{
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
		protected internal MPSSvgf (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDevice:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSSvgf (global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithDevice:"), device__handle__), "initWithDevice:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithDevice:"), device__handle__), "initWithDevice:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		[Export ("initWithCoder:device:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSSvgf (NSCoder aDecoder, global::Metal.IMTLDevice device)
			: base (NSObjectFlag.Empty)
		{
			var aDecoder__handle__ = aDecoder!.GetNonNullHandle (nameof (aDecoder));
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithCoder:device:"), aDecoder__handle__, device__handle__), "initWithCoder:device:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCoder:device:"), aDecoder__handle__, device__handle__), "initWithCoder:device:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aDecoder);
			GC.KeepAlive (device);
		}
		[Export ("copyWithZone:device:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSSvgf Copy (NSZone? zone, global::Metal.IMTLDevice? device)
		{
			var zone__handle__ = zone.GetHandle ();
			var device__handle__ = device.GetHandle ();
			MPSSvgf? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSSvgf> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSSvgf> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:device:"), zone__handle__, device__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			GC.KeepAlive (device);
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (NSCoder coder)
		{
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), coder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), coder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}
		[Export ("encodeBilateralFilterToCommandBuffer:stepDistance:sourceTexture:destinationTexture:depthNormalTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeBilateralFilter (global::Metal.IMTLCommandBuffer commandBuffer, nuint stepDistance, global::Metal.IMTLTexture sourceTexture, global::Metal.IMTLTexture destinationTexture, global::Metal.IMTLTexture depthNormalTexture)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			var depthNormalTexture__handle__ = depthNormalTexture!.GetNonNullHandle (nameof (depthNormalTexture));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeBilateralFilterToCommandBuffer:stepDistance:sourceTexture:destinationTexture:depthNormalTexture:"), commandBuffer__handle__, stepDistance, sourceTexture__handle__, destinationTexture__handle__, depthNormalTexture__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeBilateralFilterToCommandBuffer:stepDistance:sourceTexture:destinationTexture:depthNormalTexture:"), commandBuffer__handle__, stepDistance, sourceTexture__handle__, destinationTexture__handle__, depthNormalTexture__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
			GC.KeepAlive (depthNormalTexture);
		}
		[Export ("encodeBilateralFilterToCommandBuffer:stepDistance:sourceTexture:destinationTexture:sourceTexture2:destinationTexture2:depthNormalTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeBilateralFilter (global::Metal.IMTLCommandBuffer commandBuffer, nuint stepDistance, global::Metal.IMTLTexture sourceTexture, global::Metal.IMTLTexture destinationTexture, global::Metal.IMTLTexture? sourceTexture2, global::Metal.IMTLTexture? destinationTexture2, global::Metal.IMTLTexture depthNormalTexture)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			var sourceTexture2__handle__ = sourceTexture2.GetHandle ();
			var destinationTexture2__handle__ = destinationTexture2.GetHandle ();
			var depthNormalTexture__handle__ = depthNormalTexture!.GetNonNullHandle (nameof (depthNormalTexture));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeBilateralFilterToCommandBuffer:stepDistance:sourceTexture:destinationTexture:sourceTexture2:destinationTexture2:depthNormalTexture:"), commandBuffer__handle__, stepDistance, sourceTexture__handle__, destinationTexture__handle__, sourceTexture2__handle__, destinationTexture2__handle__, depthNormalTexture__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeBilateralFilterToCommandBuffer:stepDistance:sourceTexture:destinationTexture:sourceTexture2:destinationTexture2:depthNormalTexture:"), commandBuffer__handle__, stepDistance, sourceTexture__handle__, destinationTexture__handle__, sourceTexture2__handle__, destinationTexture2__handle__, depthNormalTexture__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
			GC.KeepAlive (sourceTexture2);
			GC.KeepAlive (destinationTexture2);
			GC.KeepAlive (depthNormalTexture);
		}
		[Export ("encodeReprojectionToCommandBuffer:sourceTexture:previousTexture:destinationTexture:previousLuminanceMomentsTexture:destinationLuminanceMomentsTexture:previousFrameCountTexture:destinationFrameCountTexture:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeReprojection (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture sourceTexture, global::Metal.IMTLTexture previousTexture, global::Metal.IMTLTexture destinationTexture, global::Metal.IMTLTexture previousLuminanceMomentsTexture, global::Metal.IMTLTexture destinationLuminanceMomentsTexture, global::Metal.IMTLTexture previousFrameCountTexture, global::Metal.IMTLTexture destinationFrameCountTexture, global::Metal.IMTLTexture? motionVectorTexture, global::Metal.IMTLTexture? depthNormalTexture, global::Metal.IMTLTexture? previousDepthNormalTexture)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var previousTexture__handle__ = previousTexture!.GetNonNullHandle (nameof (previousTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			var previousLuminanceMomentsTexture__handle__ = previousLuminanceMomentsTexture!.GetNonNullHandle (nameof (previousLuminanceMomentsTexture));
			var destinationLuminanceMomentsTexture__handle__ = destinationLuminanceMomentsTexture!.GetNonNullHandle (nameof (destinationLuminanceMomentsTexture));
			var previousFrameCountTexture__handle__ = previousFrameCountTexture!.GetNonNullHandle (nameof (previousFrameCountTexture));
			var destinationFrameCountTexture__handle__ = destinationFrameCountTexture!.GetNonNullHandle (nameof (destinationFrameCountTexture));
			var motionVectorTexture__handle__ = motionVectorTexture.GetHandle ();
			var depthNormalTexture__handle__ = depthNormalTexture.GetHandle ();
			var previousDepthNormalTexture__handle__ = previousDepthNormalTexture.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeReprojectionToCommandBuffer:sourceTexture:previousTexture:destinationTexture:previousLuminanceMomentsTexture:destinationLuminanceMomentsTexture:previousFrameCountTexture:destinationFrameCountTexture:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:"), commandBuffer__handle__, sourceTexture__handle__, previousTexture__handle__, destinationTexture__handle__, previousLuminanceMomentsTexture__handle__, destinationLuminanceMomentsTexture__handle__, previousFrameCountTexture__handle__, destinationFrameCountTexture__handle__, motionVectorTexture__handle__, depthNormalTexture__handle__, previousDepthNormalTexture__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeReprojectionToCommandBuffer:sourceTexture:previousTexture:destinationTexture:previousLuminanceMomentsTexture:destinationLuminanceMomentsTexture:previousFrameCountTexture:destinationFrameCountTexture:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:"), commandBuffer__handle__, sourceTexture__handle__, previousTexture__handle__, destinationTexture__handle__, previousLuminanceMomentsTexture__handle__, destinationLuminanceMomentsTexture__handle__, previousFrameCountTexture__handle__, destinationFrameCountTexture__handle__, motionVectorTexture__handle__, depthNormalTexture__handle__, previousDepthNormalTexture__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (previousTexture);
			GC.KeepAlive (destinationTexture);
			GC.KeepAlive (previousLuminanceMomentsTexture);
			GC.KeepAlive (destinationLuminanceMomentsTexture);
			GC.KeepAlive (previousFrameCountTexture);
			GC.KeepAlive (destinationFrameCountTexture);
			GC.KeepAlive (motionVectorTexture);
			GC.KeepAlive (depthNormalTexture);
			GC.KeepAlive (previousDepthNormalTexture);
		}
		[Export ("encodeReprojectionToCommandBuffer:sourceTexture:previousTexture:destinationTexture:previousLuminanceMomentsTexture:destinationLuminanceMomentsTexture:sourceTexture2:previousTexture2:destinationTexture2:previousLuminanceMomentsTexture2:destinationLuminanceMomentsTexture2:previousFrameCountTexture:destinationFrameCountTexture:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeReprojection (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture sourceTexture, global::Metal.IMTLTexture previousTexture, global::Metal.IMTLTexture destinationTexture, global::Metal.IMTLTexture previousLuminanceMomentsTexture, global::Metal.IMTLTexture destinationLuminanceMomentsTexture, global::Metal.IMTLTexture? sourceTexture2, global::Metal.IMTLTexture? previousTexture2, global::Metal.IMTLTexture? destinationTexture2, global::Metal.IMTLTexture? previousLuminanceMomentsTexture2, global::Metal.IMTLTexture? destinationLuminanceMomentsTexture2, global::Metal.IMTLTexture previousFrameCountTexture, global::Metal.IMTLTexture destinationFrameCountTexture, global::Metal.IMTLTexture? motionVectorTexture, global::Metal.IMTLTexture? depthNormalTexture, global::Metal.IMTLTexture? previousDepthNormalTexture)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var previousTexture__handle__ = previousTexture!.GetNonNullHandle (nameof (previousTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			var previousLuminanceMomentsTexture__handle__ = previousLuminanceMomentsTexture!.GetNonNullHandle (nameof (previousLuminanceMomentsTexture));
			var destinationLuminanceMomentsTexture__handle__ = destinationLuminanceMomentsTexture!.GetNonNullHandle (nameof (destinationLuminanceMomentsTexture));
			var sourceTexture2__handle__ = sourceTexture2.GetHandle ();
			var previousTexture2__handle__ = previousTexture2.GetHandle ();
			var destinationTexture2__handle__ = destinationTexture2.GetHandle ();
			var previousLuminanceMomentsTexture2__handle__ = previousLuminanceMomentsTexture2.GetHandle ();
			var destinationLuminanceMomentsTexture2__handle__ = destinationLuminanceMomentsTexture2.GetHandle ();
			var previousFrameCountTexture__handle__ = previousFrameCountTexture!.GetNonNullHandle (nameof (previousFrameCountTexture));
			var destinationFrameCountTexture__handle__ = destinationFrameCountTexture!.GetNonNullHandle (nameof (destinationFrameCountTexture));
			var motionVectorTexture__handle__ = motionVectorTexture.GetHandle ();
			var depthNormalTexture__handle__ = depthNormalTexture.GetHandle ();
			var previousDepthNormalTexture__handle__ = previousDepthNormalTexture.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeReprojectionToCommandBuffer:sourceTexture:previousTexture:destinationTexture:previousLuminanceMomentsTexture:destinationLuminanceMomentsTexture:sourceTexture2:previousTexture2:destinationTexture2:previousLuminanceMomentsTexture2:destinationLuminanceMomentsTexture2:previousFrameCountTexture:destinationFrameCountTexture:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:"), commandBuffer__handle__, sourceTexture__handle__, previousTexture__handle__, destinationTexture__handle__, previousLuminanceMomentsTexture__handle__, destinationLuminanceMomentsTexture__handle__, sourceTexture2__handle__, previousTexture2__handle__, destinationTexture2__handle__, previousLuminanceMomentsTexture2__handle__, destinationLuminanceMomentsTexture2__handle__, previousFrameCountTexture__handle__, destinationFrameCountTexture__handle__, motionVectorTexture__handle__, depthNormalTexture__handle__, previousDepthNormalTexture__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeReprojectionToCommandBuffer:sourceTexture:previousTexture:destinationTexture:previousLuminanceMomentsTexture:destinationLuminanceMomentsTexture:sourceTexture2:previousTexture2:destinationTexture2:previousLuminanceMomentsTexture2:destinationLuminanceMomentsTexture2:previousFrameCountTexture:destinationFrameCountTexture:motionVectorTexture:depthNormalTexture:previousDepthNormalTexture:"), commandBuffer__handle__, sourceTexture__handle__, previousTexture__handle__, destinationTexture__handle__, previousLuminanceMomentsTexture__handle__, destinationLuminanceMomentsTexture__handle__, sourceTexture2__handle__, previousTexture2__handle__, destinationTexture2__handle__, previousLuminanceMomentsTexture2__handle__, destinationLuminanceMomentsTexture2__handle__, previousFrameCountTexture__handle__, destinationFrameCountTexture__handle__, motionVectorTexture__handle__, depthNormalTexture__handle__, previousDepthNormalTexture__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (previousTexture);
			GC.KeepAlive (destinationTexture);
			GC.KeepAlive (previousLuminanceMomentsTexture);
			GC.KeepAlive (destinationLuminanceMomentsTexture);
			GC.KeepAlive (sourceTexture2);
			GC.KeepAlive (previousTexture2);
			GC.KeepAlive (destinationTexture2);
			GC.KeepAlive (previousLuminanceMomentsTexture2);
			GC.KeepAlive (destinationLuminanceMomentsTexture2);
			GC.KeepAlive (previousFrameCountTexture);
			GC.KeepAlive (destinationFrameCountTexture);
			GC.KeepAlive (motionVectorTexture);
			GC.KeepAlive (depthNormalTexture);
			GC.KeepAlive (previousDepthNormalTexture);
		}
		[Export ("encodeVarianceEstimationToCommandBuffer:sourceTexture:luminanceMomentsTexture:destinationTexture:frameCountTexture:depthNormalTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeVarianceEstimation (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture sourceTexture, global::Metal.IMTLTexture luminanceMomentsTexture, global::Metal.IMTLTexture destinationTexture, global::Metal.IMTLTexture frameCountTexture, global::Metal.IMTLTexture? depthNormalTexture)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var luminanceMomentsTexture__handle__ = luminanceMomentsTexture!.GetNonNullHandle (nameof (luminanceMomentsTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			var frameCountTexture__handle__ = frameCountTexture!.GetNonNullHandle (nameof (frameCountTexture));
			var depthNormalTexture__handle__ = depthNormalTexture.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeVarianceEstimationToCommandBuffer:sourceTexture:luminanceMomentsTexture:destinationTexture:frameCountTexture:depthNormalTexture:"), commandBuffer__handle__, sourceTexture__handle__, luminanceMomentsTexture__handle__, destinationTexture__handle__, frameCountTexture__handle__, depthNormalTexture__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeVarianceEstimationToCommandBuffer:sourceTexture:luminanceMomentsTexture:destinationTexture:frameCountTexture:depthNormalTexture:"), commandBuffer__handle__, sourceTexture__handle__, luminanceMomentsTexture__handle__, destinationTexture__handle__, frameCountTexture__handle__, depthNormalTexture__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (luminanceMomentsTexture);
			GC.KeepAlive (destinationTexture);
			GC.KeepAlive (frameCountTexture);
			GC.KeepAlive (depthNormalTexture);
		}
		[Export ("encodeVarianceEstimationToCommandBuffer:sourceTexture:luminanceMomentsTexture:destinationTexture:sourceTexture2:luminanceMomentsTexture2:destinationTexture2:frameCountTexture:depthNormalTexture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeVarianceEstimation (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.IMTLTexture sourceTexture, global::Metal.IMTLTexture luminanceMomentsTexture, global::Metal.IMTLTexture destinationTexture, global::Metal.IMTLTexture? sourceTexture2, global::Metal.IMTLTexture? luminanceMomentsTexture2, global::Metal.IMTLTexture? destinationTexture2, global::Metal.IMTLTexture frameCountTexture, global::Metal.IMTLTexture? depthNormalTexture)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var luminanceMomentsTexture__handle__ = luminanceMomentsTexture!.GetNonNullHandle (nameof (luminanceMomentsTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			var sourceTexture2__handle__ = sourceTexture2.GetHandle ();
			var luminanceMomentsTexture2__handle__ = luminanceMomentsTexture2.GetHandle ();
			var destinationTexture2__handle__ = destinationTexture2.GetHandle ();
			var frameCountTexture__handle__ = frameCountTexture!.GetNonNullHandle (nameof (frameCountTexture));
			var depthNormalTexture__handle__ = depthNormalTexture.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("encodeVarianceEstimationToCommandBuffer:sourceTexture:luminanceMomentsTexture:destinationTexture:sourceTexture2:luminanceMomentsTexture2:destinationTexture2:frameCountTexture:depthNormalTexture:"), commandBuffer__handle__, sourceTexture__handle__, luminanceMomentsTexture__handle__, destinationTexture__handle__, sourceTexture2__handle__, luminanceMomentsTexture2__handle__, destinationTexture2__handle__, frameCountTexture__handle__, depthNormalTexture__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeVarianceEstimationToCommandBuffer:sourceTexture:luminanceMomentsTexture:destinationTexture:sourceTexture2:luminanceMomentsTexture2:destinationTexture2:frameCountTexture:depthNormalTexture:"), commandBuffer__handle__, sourceTexture__handle__, luminanceMomentsTexture__handle__, destinationTexture__handle__, sourceTexture2__handle__, luminanceMomentsTexture2__handle__, destinationTexture2__handle__, frameCountTexture__handle__, depthNormalTexture__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (luminanceMomentsTexture);
			GC.KeepAlive (destinationTexture);
			GC.KeepAlive (sourceTexture2);
			GC.KeepAlive (luminanceMomentsTexture2);
			GC.KeepAlive (destinationTexture2);
			GC.KeepAlive (frameCountTexture);
			GC.KeepAlive (depthNormalTexture);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint BilateralFilterRadius {
			[Export ("bilateralFilterRadius")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bilateralFilterRadius"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bilateralFilterRadius"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBilateralFilterRadius:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setBilateralFilterRadius:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setBilateralFilterRadius:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float BilateralFilterSigma {
			[Export ("bilateralFilterSigma")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("bilateralFilterSigma"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bilateralFilterSigma"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBilateralFilterSigma:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setBilateralFilterSigma:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setBilateralFilterSigma:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ChannelCount {
			[Export ("channelCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("channelCount"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("channelCount"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setChannelCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setChannelCount:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setChannelCount:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ChannelCount2 {
			[Export ("channelCount2")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("channelCount2"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("channelCount2"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setChannelCount2:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setChannelCount2:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setChannelCount2:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float DepthWeight {
			[Export ("depthWeight")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("depthWeight"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("depthWeight"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDepthWeight:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setDepthWeight:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setDepthWeight:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float LuminanceWeight {
			[Export ("luminanceWeight")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("luminanceWeight"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("luminanceWeight"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLuminanceWeight:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setLuminanceWeight:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setLuminanceWeight:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MinimumFramesForVarianceEstimation {
			[Export ("minimumFramesForVarianceEstimation")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("minimumFramesForVarianceEstimation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("minimumFramesForVarianceEstimation"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumFramesForVarianceEstimation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setMinimumFramesForVarianceEstimation:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setMinimumFramesForVarianceEstimation:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float NormalWeight {
			[Export ("normalWeight")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("normalWeight"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("normalWeight"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNormalWeight:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setNormalWeight:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setNormalWeight:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ReprojectionThreshold {
			[Export ("reprojectionThreshold")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("reprojectionThreshold"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reprojectionThreshold"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setReprojectionThreshold:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setReprojectionThreshold:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setReprojectionThreshold:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float TemporalReprojectionBlendFactor {
			[Export ("temporalReprojectionBlendFactor")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("temporalReprojectionBlendFactor"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("temporalReprojectionBlendFactor"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTemporalReprojectionBlendFactor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setTemporalReprojectionBlendFactor:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setTemporalReprojectionBlendFactor:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSTemporalWeighting TemporalWeighting {
			[Export ("temporalWeighting", ArgumentSemantic.Assign)]
			get {
				MPSTemporalWeighting ret;
				if (IsDirectBinding) {
					ret = (MetalPerformanceShaders.MPSTemporalWeighting) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("temporalWeighting"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MetalPerformanceShaders.MPSTemporalWeighting) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("temporalWeighting"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTemporalWeighting:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setTemporalWeighting:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setTemporalWeighting:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint VarianceEstimationRadius {
			[Export ("varianceEstimationRadius")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("varianceEstimationRadius"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("varianceEstimationRadius"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVarianceEstimationRadius:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setVarianceEstimationRadius:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setVarianceEstimationRadius:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float VarianceEstimationSigma {
			[Export ("varianceEstimationSigma")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("varianceEstimationSigma"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("varianceEstimationSigma"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVarianceEstimationSigma:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setVarianceEstimationSigma:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setVarianceEstimationSigma:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint VariancePrefilterRadius {
			[Export ("variancePrefilterRadius")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("variancePrefilterRadius"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("variancePrefilterRadius"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVariancePrefilterRadius:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setVariancePrefilterRadius:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setVariancePrefilterRadius:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float VariancePrefilterSigma {
			[Export ("variancePrefilterSigma")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("variancePrefilterSigma"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("variancePrefilterSigma"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVariancePrefilterSigma:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setVariancePrefilterSigma:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setVariancePrefilterSigma:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MPSSvgf */
}
