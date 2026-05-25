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
namespace CoreAnimation {
	[Register("CAOpenGLLayer", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("macos10.14", "Use 'CAMetalLayer' instead.")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CAOpenGLLayer : CALayer {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_X = "canDrawInCGLContext:pixelFormat:forLayerTime:displayTime:";
		static readonly NativeHandle selCanDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_XHandle = Selector.GetHandle ("canDrawInCGLContext:pixelFormat:forLayerTime:displayTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyCGLContextForPixelFormat_X = "copyCGLContextForPixelFormat:";
		static readonly NativeHandle selCopyCGLContextForPixelFormat_XHandle = Selector.GetHandle ("copyCGLContextForPixelFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyCGLPixelFormatForDisplayMask_X = "copyCGLPixelFormatForDisplayMask:";
		static readonly NativeHandle selCopyCGLPixelFormatForDisplayMask_XHandle = Selector.GetHandle ("copyCGLPixelFormatForDisplayMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_X = "drawInCGLContext:pixelFormat:forLayerTime:displayTime:";
		static readonly NativeHandle selDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_XHandle = Selector.GetHandle ("drawInCGLContext:pixelFormat:forLayerTime:displayTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAsynchronousX = "isAsynchronous";
		static readonly NativeHandle selIsAsynchronousXHandle = Selector.GetHandle ("isAsynchronous");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayerX = "layer";
		static readonly NativeHandle selLayerXHandle = Selector.GetHandle ("layer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReleaseCGLContext_X = "releaseCGLContext:";
		static readonly NativeHandle selReleaseCGLContext_XHandle = Selector.GetHandle ("releaseCGLContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReleaseCGLPixelFormat_X = "releaseCGLPixelFormat:";
		static readonly NativeHandle selReleaseCGLPixelFormat_XHandle = Selector.GetHandle ("releaseCGLPixelFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAsynchronous_X = "setAsynchronous:";
		static readonly NativeHandle selSetAsynchronous_XHandle = Selector.GetHandle ("setAsynchronous:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CAOpenGLLayer");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CAOpenGLLayer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CAOpenGLLayer () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

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
		public CAOpenGLLayer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected CAOpenGLLayer (NSObjectFlag t) : base (t)
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
		protected internal CAOpenGLLayer (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="glContext">To be added.</param><param name="pixelFormat">To be added.</param><param name="timeInterval">To be added.</param><param name="timeStamp">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canDrawInCGLContext:pixelFormat:forLayerTime:displayTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool CanDrawInCGLContext (global::OpenGL.CGLContext glContext, global::OpenGL.CGLPixelFormat pixelFormat, double timeInterval, ref global::CoreVideo.CVTimeStamp timeStamp)
		{
			var glContext__handle__ = glContext!.GetNonNullHandle (nameof (glContext));
			var pixelFormat__handle__ = pixelFormat!.GetNonNullHandle (nameof (pixelFormat));
			fixed (global::CoreVideo.CVTimeStamp* timeStamp__pointer = &timeStamp) {
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_Double_ref_CVTimeStamp (this.Handle, selCanDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_XHandle, glContext.Handle, pixelFormat.Handle, timeInterval, timeStamp__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_Double_ref_CVTimeStamp (&__objc_super__, selCanDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_XHandle, glContext.Handle, pixelFormat.Handle, timeInterval, timeStamp__pointer);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (glContext);
			GC.KeepAlive (pixelFormat);
			return ret != 0;
			}
		}
		/// <param name="mask">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("copyCGLPixelFormatForDisplayMask:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::OpenGL.CGLPixelFormat CopyCGLPixelFormatForDisplayMask (uint mask)
		{
			global::OpenGL.CGLPixelFormat? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::OpenGL.CGLPixelFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (this.Handle, selCopyCGLPixelFormatForDisplayMask_XHandle, mask), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::OpenGL.CGLPixelFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt32 (&__objc_super__, selCopyCGLPixelFormatForDisplayMask_XHandle, mask), true)!;
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		/// <param name="pixelFormat">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("copyCGLContextForPixelFormat:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::OpenGL.CGLContext CopyContext (global::OpenGL.CGLPixelFormat pixelFormat)
		{
			var pixelFormat__handle__ = pixelFormat!.GetNonNullHandle (nameof (pixelFormat));
			global::OpenGL.CGLContext? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::OpenGL.CGLContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyCGLContextForPixelFormat_XHandle, pixelFormat.Handle), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::OpenGL.CGLContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyCGLContextForPixelFormat_XHandle, pixelFormat.Handle), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelFormat);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static CALayer Create ()
		{
			CALayer ret;
			ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLayerXHandle), false)!;
			return ret;
		}
		/// <param name="glContext">To be added.</param><param name="pixelFormat">To be added.</param><param name="timeInterval">To be added.</param><param name="timeStamp">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawInCGLContext:pixelFormat:forLayerTime:displayTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DrawInCGLContext (global::OpenGL.CGLContext glContext, global::OpenGL.CGLPixelFormat pixelFormat, double timeInterval, ref global::CoreVideo.CVTimeStamp timeStamp)
		{
			var glContext__handle__ = glContext!.GetNonNullHandle (nameof (glContext));
			var pixelFormat__handle__ = pixelFormat!.GetNonNullHandle (nameof (pixelFormat));
			fixed (global::CoreVideo.CVTimeStamp* timeStamp__pointer = &timeStamp) {
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_ref_CVTimeStamp (this.Handle, selDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_XHandle, glContext.Handle, pixelFormat.Handle, timeInterval, timeStamp__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_Double_ref_CVTimeStamp (&__objc_super__, selDrawInCGLContext_PixelFormat_ForLayerTime_DisplayTime_XHandle, glContext.Handle, pixelFormat.Handle, timeInterval, timeStamp__pointer);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (glContext);
			GC.KeepAlive (pixelFormat);
			}
		}
		/// <param name="pixelFormat">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("releaseCGLPixelFormat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Release (global::OpenGL.CGLPixelFormat pixelFormat)
		{
			var pixelFormat__handle__ = pixelFormat!.GetNonNullHandle (nameof (pixelFormat));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReleaseCGLPixelFormat_XHandle, pixelFormat.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReleaseCGLPixelFormat_XHandle, pixelFormat.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelFormat);
		}
		/// <param name="glContext">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("releaseCGLContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Release (global::OpenGL.CGLContext glContext)
		{
			var glContext__handle__ = glContext!.GetNonNullHandle (nameof (glContext));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReleaseCGLContext_XHandle, glContext.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReleaseCGLContext_XHandle, glContext.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (glContext);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Asynchronous {
			[Export ("isAsynchronous")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAsynchronousXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAsynchronousXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAsynchronous:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAsynchronous_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAsynchronous_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class CAOpenGLLayer */
}
