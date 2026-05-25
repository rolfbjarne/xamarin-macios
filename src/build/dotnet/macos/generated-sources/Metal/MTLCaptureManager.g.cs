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
namespace Metal {
	/// <summary>Manages GPU captures for apps launched from Xcode.</summary>
	[Register("MTLCaptureManager", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MTLCaptureManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultCaptureScopeX = "defaultCaptureScope";
		static readonly NativeHandle selDefaultCaptureScopeXHandle = Selector.GetHandle ("defaultCaptureScope");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsCapturingX = "isCapturing";
		static readonly NativeHandle selIsCapturingXHandle = Selector.GetHandle ("isCapturing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewCaptureScopeWithCommandQueue_X = "newCaptureScopeWithCommandQueue:";
		static readonly NativeHandle selNewCaptureScopeWithCommandQueue_XHandle = Selector.GetHandle ("newCaptureScopeWithCommandQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewCaptureScopeWithDevice_X = "newCaptureScopeWithDevice:";
		static readonly NativeHandle selNewCaptureScopeWithDevice_XHandle = Selector.GetHandle ("newCaptureScopeWithDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewCaptureScopeWithMTL4CommandQueue_X = "newCaptureScopeWithMTL4CommandQueue:";
		static readonly NativeHandle selNewCaptureScopeWithMTL4CommandQueue_XHandle = Selector.GetHandle ("newCaptureScopeWithMTL4CommandQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultCaptureScope_X = "setDefaultCaptureScope:";
		static readonly NativeHandle selSetDefaultCaptureScope_XHandle = Selector.GetHandle ("setDefaultCaptureScope:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedCaptureManagerX = "sharedCaptureManager";
		static readonly NativeHandle selSharedCaptureManagerXHandle = Selector.GetHandle ("sharedCaptureManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartCaptureWithCommandQueue_X = "startCaptureWithCommandQueue:";
		static readonly NativeHandle selStartCaptureWithCommandQueue_XHandle = Selector.GetHandle ("startCaptureWithCommandQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartCaptureWithDescriptor_Error_X = "startCaptureWithDescriptor:error:";
		static readonly NativeHandle selStartCaptureWithDescriptor_Error_XHandle = Selector.GetHandle ("startCaptureWithDescriptor:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartCaptureWithDevice_X = "startCaptureWithDevice:";
		static readonly NativeHandle selStartCaptureWithDevice_XHandle = Selector.GetHandle ("startCaptureWithDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartCaptureWithScope_X = "startCaptureWithScope:";
		static readonly NativeHandle selStartCaptureWithScope_XHandle = Selector.GetHandle ("startCaptureWithScope:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopCaptureX = "stopCapture";
		static readonly NativeHandle selStopCaptureXHandle = Selector.GetHandle ("stopCapture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportsDestination_X = "supportsDestination:";
		static readonly NativeHandle selSupportsDestination_XHandle = Selector.GetHandle ("supportsDestination:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MTLCaptureManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected MTLCaptureManager (NSObjectFlag t) : base (t)
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
		protected internal MTLCaptureManager (NativeHandle handle) : base (handle)
		{
		}

		[Export ("newCaptureScopeWithDevice:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCaptureScope CreateNewCaptureScope (IMTLDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			IMTLCaptureScope? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMTLCaptureScope> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNewCaptureScopeWithDevice_XHandle, device__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMTLCaptureScope> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNewCaptureScopeWithDevice_XHandle, device__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			return ret!;
		}
		[Export ("newCaptureScopeWithCommandQueue:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCaptureScope CreateNewCaptureScope (IMTLCommandQueue commandQueue)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			IMTLCaptureScope? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMTLCaptureScope> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNewCaptureScopeWithCommandQueue_XHandle, commandQueue__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMTLCaptureScope> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNewCaptureScopeWithCommandQueue_XHandle, commandQueue__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandQueue);
			return ret!;
		}
		[Export ("newCaptureScopeWithMTL4CommandQueue:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCaptureScope CreateNewCaptureScope (IMTL4CommandQueue commandQueue)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			IMTLCaptureScope? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMTLCaptureScope> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selNewCaptureScopeWithMTL4CommandQueue_XHandle, commandQueue__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMTLCaptureScope> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selNewCaptureScopeWithMTL4CommandQueue_XHandle, commandQueue__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandQueue);
			return ret!;
		}
		[Export ("startCaptureWithDevice:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartCapture (IMTLDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartCaptureWithDevice_XHandle, device__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartCaptureWithDevice_XHandle, device__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		[Export ("startCaptureWithCommandQueue:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartCapture (IMTLCommandQueue commandQueue)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartCaptureWithCommandQueue_XHandle, commandQueue__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartCaptureWithCommandQueue_XHandle, commandQueue__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandQueue);
		}
		[Export ("startCaptureWithScope:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartCapture (IMTLCaptureScope captureScope)
		{
			var captureScope__handle__ = captureScope!.GetNonNullHandle (nameof (captureScope));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartCaptureWithScope_XHandle, captureScope__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartCaptureWithScope_XHandle, captureScope__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (captureScope);
		}
		[Export ("startCaptureWithDescriptor:error:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool StartCapture (MTLCaptureDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selStartCaptureWithDescriptor_Error_XHandle, descriptor__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selStartCaptureWithDescriptor_Error_XHandle, descriptor__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("stopCapture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopCapture ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopCaptureXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopCaptureXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("supportsDestination:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsDestination (MTLCaptureDestination destination)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSupportsDestination_XHandle, (IntPtr) (long) destination);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selSupportsDestination_XHandle, (IntPtr) (long) destination);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLCaptureScope? DefaultCaptureScope {
			[Export ("defaultCaptureScope", ArgumentSemantic.Retain)]
			get {
				IMTLCaptureScope? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMTLCaptureScope> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultCaptureScopeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMTLCaptureScope> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultCaptureScopeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDefaultCaptureScope:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDefaultCaptureScope_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDefaultCaptureScope_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCapturing {
			[Export ("isCapturing")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCapturingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsCapturingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLCaptureManager Shared {
			[Export ("sharedCaptureManager")]
			get {
				MTLCaptureManager? ret;
				ret =  Runtime.GetNSObject<MTLCaptureManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedCaptureManagerXHandle), false)!;
				return ret!;
			}
		}
	} /* class MTLCaptureManager */
}
