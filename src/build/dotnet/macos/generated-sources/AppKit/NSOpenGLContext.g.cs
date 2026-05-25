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
namespace AppKit {
	[Register("NSOpenGLContext", true)]
	[ObsoletedOSPlatform ("macos10.14", "Use 'Metal' Framework instead.")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSOpenGLContext : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGLContextObjX = "CGLContextObj";
		static readonly NativeHandle selCGLContextObjXHandle = Selector.GetHandle ("CGLContextObj");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearCurrentContextX = "clearCurrentContext";
		static readonly NativeHandle selClearCurrentContextXHandle = Selector.GetHandle ("clearCurrentContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearDrawableX = "clearDrawable";
		static readonly NativeHandle selClearDrawableXHandle = Selector.GetHandle ("clearDrawable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyAttributesFromContext_WithMask_X = "copyAttributesFromContext:withMask:";
		static readonly NativeHandle selCopyAttributesFromContext_WithMask_XHandle = Selector.GetHandle ("copyAttributesFromContext:withMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateTexture_FromView_InternalFormat_X = "createTexture:fromView:internalFormat:";
		static readonly NativeHandle selCreateTexture_FromView_InternalFormat_XHandle = Selector.GetHandle ("createTexture:fromView:internalFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentContextX = "currentContext";
		static readonly NativeHandle selCurrentContextXHandle = Selector.GetHandle ("currentContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentVirtualScreenX = "currentVirtualScreen";
		static readonly NativeHandle selCurrentVirtualScreenXHandle = Selector.GetHandle ("currentVirtualScreen");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlushBufferX = "flushBuffer";
		static readonly NativeHandle selFlushBufferXHandle = Selector.GetHandle ("flushBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetValues_ForParameter_X = "getValues:forParameter:";
		static readonly NativeHandle selGetValues_ForParameter_XHandle = Selector.GetHandle ("getValues:forParameter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFormat_ShareContext_X = "initWithFormat:shareContext:";
		static readonly NativeHandle selInitWithFormat_ShareContext_XHandle = Selector.GetHandle ("initWithFormat:shareContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeCurrentContextX = "makeCurrentContext";
		static readonly NativeHandle selMakeCurrentContextXHandle = Selector.GetHandle ("makeCurrentContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelBufferX = "pixelBuffer";
		static readonly NativeHandle selPixelBufferXHandle = Selector.GetHandle ("pixelBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelBufferCubeMapFaceX = "pixelBufferCubeMapFace";
		static readonly NativeHandle selPixelBufferCubeMapFaceXHandle = Selector.GetHandle ("pixelBufferCubeMapFace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelBufferMipMapLevelX = "pixelBufferMipMapLevel";
		static readonly NativeHandle selPixelBufferMipMapLevelXHandle = Selector.GetHandle ("pixelBufferMipMapLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPixelFormatX = "pixelFormat";
		static readonly NativeHandle selPixelFormatXHandle = Selector.GetHandle ("pixelFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurrentVirtualScreen_X = "setCurrentVirtualScreen:";
		static readonly NativeHandle selSetCurrentVirtualScreen_XHandle = Selector.GetHandle ("setCurrentVirtualScreen:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFullScreenX = "setFullScreen";
		static readonly NativeHandle selSetFullScreenXHandle = Selector.GetHandle ("setFullScreen");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOffScreen_Width_Height_Rowbytes_X = "setOffScreen:width:height:rowbytes:";
		static readonly NativeHandle selSetOffScreen_Width_Height_Rowbytes_XHandle = Selector.GetHandle ("setOffScreen:width:height:rowbytes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPixelBuffer_CubeMapFace_MipMapLevel_CurrentVirtualScreen_X = "setPixelBuffer:cubeMapFace:mipMapLevel:currentVirtualScreen:";
		static readonly NativeHandle selSetPixelBuffer_CubeMapFace_MipMapLevel_CurrentVirtualScreen_XHandle = Selector.GetHandle ("setPixelBuffer:cubeMapFace:mipMapLevel:currentVirtualScreen:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextureImageToPixelBuffer_ColorBuffer_X = "setTextureImageToPixelBuffer:colorBuffer:";
		static readonly NativeHandle selSetTextureImageToPixelBuffer_ColorBuffer_XHandle = Selector.GetHandle ("setTextureImageToPixelBuffer:colorBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValues_ForParameter_X = "setValues:forParameter:";
		static readonly NativeHandle selSetValues_ForParameter_XHandle = Selector.GetHandle ("setValues:forParameter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetView_X = "setView:";
		static readonly NativeHandle selSetView_XHandle = Selector.GetHandle ("setView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateX = "update";
		static readonly NativeHandle selUpdateXHandle = Selector.GetHandle ("update");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewX = "view";
		static readonly NativeHandle selViewXHandle = Selector.GetHandle ("view");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSOpenGLContext");
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
		protected NSOpenGLContext (NSObjectFlag t) : base (t)
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
		protected internal NSOpenGLContext (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFormat:shareContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSOpenGLContext (NSOpenGLPixelFormat format, NSOpenGLContext? shareContext)
			: base (NSObjectFlag.Empty)
		{
			var format__handle__ = format!.GetNonNullHandle (nameof (format));
			var shareContext__handle__ = shareContext.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithFormat_ShareContext_XHandle, format__handle__, shareContext__handle__), "initWithFormat:shareContext:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithFormat_ShareContext_XHandle, format__handle__, shareContext__handle__), "initWithFormat:shareContext:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (format);
			GC.KeepAlive (shareContext);
		}
		[Export ("clearCurrentContext")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ClearCurrentContext ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selClearCurrentContextXHandle);
		}
		[Export ("clearDrawable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearDrawable ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClearDrawableXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selClearDrawableXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("copyAttributesFromContext:withMask:")]
		[ObsoletedOSPlatform ("macos10.8")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyAttributes (NSOpenGLContext context, uint mask)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32 (this.Handle, selCopyAttributesFromContext_WithMask_XHandle, context__handle__, mask);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt32 (&__objc_super__, selCopyAttributesFromContext_WithMask_XHandle, context__handle__, mask);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		[Export ("createTexture:fromView:internalFormat:")]
		[ObsoletedOSPlatform ("macos10.8")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CreateTexture (int targetIdentifier, NSView view, int format)
		{
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_int_NativeHandle_int (this.Handle, selCreateTexture_FromView_InternalFormat_XHandle, targetIdentifier, view__handle__, format);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int_NativeHandle_int (&__objc_super__, selCreateTexture_FromView_InternalFormat_XHandle, targetIdentifier, view__handle__, format);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
		}
		[Export ("flushBuffer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FlushBuffer ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFlushBufferXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFlushBufferXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("getValues:forParameter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetValues (nint vals, NSOpenGLContextParameter param)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, selGetValues_ForParameter_XHandle, vals, (UIntPtr) (ulong) param);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selGetValues_ForParameter_XHandle, vals, (UIntPtr) (ulong) param);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("makeCurrentContext")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MakeCurrentContext ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selMakeCurrentContextXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selMakeCurrentContextXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setFullScreen")]
		[ObsoletedOSPlatform ("macos10.7")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFullScreen ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetFullScreenXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetFullScreenXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setOffScreen:width:height:rowbytes:")]
		[ObsoletedOSPlatform ("macos10.7")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOffScreen (nint baseaddr, int width, int height, int rowbytes)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int_int_int (this.Handle, selSetOffScreen_Width_Height_Rowbytes_XHandle, baseaddr, width, height, rowbytes);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int_int_int (&__objc_super__, selSetOffScreen_Width_Height_Rowbytes_XHandle, baseaddr, width, height, rowbytes);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setPixelBuffer:cubeMapFace:mipMapLevel:currentVirtualScreen:")]
		[ObsoletedOSPlatform ("macos10.7")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPixelBuffer (NSOpenGLPixelBuffer pixelBuffer, NSGLTextureCubeMap face, int level, int screen)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32_int_int (this.Handle, selSetPixelBuffer_CubeMapFace_MipMapLevel_CurrentVirtualScreen_XHandle, pixelBuffer__handle__, (UInt32)face, level, screen);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt32_int_int (&__objc_super__, selSetPixelBuffer_CubeMapFace_MipMapLevel_CurrentVirtualScreen_XHandle, pixelBuffer__handle__, (UInt32)face, level, screen);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelBuffer);
		}
		[Export ("setTextureImageToPixelBuffer:colorBuffer:")]
		[ObsoletedOSPlatform ("macos10.7")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTextureImage (NSOpenGLPixelBuffer pixelBuffer, NSGLColorBuffer source)
		{
			var pixelBuffer__handle__ = pixelBuffer!.GetNonNullHandle (nameof (pixelBuffer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32 (this.Handle, selSetTextureImageToPixelBuffer_ColorBuffer_XHandle, pixelBuffer__handle__, (UInt32)source);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt32 (&__objc_super__, selSetTextureImageToPixelBuffer_ColorBuffer_XHandle, pixelBuffer__handle__, (UInt32)source);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pixelBuffer);
		}
		[Export ("setValues:forParameter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValues (nint vals, NSOpenGLContextParameter param)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, selSetValues_ForParameter_XHandle, vals, (UIntPtr) (ulong) param);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selSetValues_ForParameter_XHandle, vals, (UIntPtr) (ulong) param);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("update")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::OpenGL.CGLContext CGLContext {
			[Export ("CGLContextObj")]
			get {
				global::OpenGL.CGLContext ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::OpenGL.CGLContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCGLContextObjXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::OpenGL.CGLContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCGLContextObjXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSOpenGLContext CurrentContext {
			[Export ("currentContext")]
			get {
				NSOpenGLContext? ret;
				ret =  Runtime.GetNSObject<NSOpenGLContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCurrentContextXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int CurrentVirtualScreen {
			[Export ("currentVirtualScreen")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selCurrentVirtualScreenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selCurrentVirtualScreenXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCurrentVirtualScreen:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetCurrentVirtualScreen_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetCurrentVirtualScreen_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.7")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSOpenGLPixelBuffer PixelBuffer {
			[Export ("pixelBuffer")]
			get {
				NSOpenGLPixelBuffer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOpenGLPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPixelBufferXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSOpenGLPixelBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPixelBufferXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.7")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual int PixelBufferCubeMapFace {
			[Export ("pixelBufferCubeMapFace")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPixelBufferCubeMapFaceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selPixelBufferCubeMapFaceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.7")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual int PixelBufferMipMapLevel {
			[Export ("pixelBufferMipMapLevel")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPixelBufferMipMapLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selPixelBufferMipMapLevelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSOpenGLPixelFormat PixelFormat {
			[Export ("pixelFormat", ArgumentSemantic.Retain)]
			get {
				NSOpenGLPixelFormat? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOpenGLPixelFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPixelFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSOpenGLPixelFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPixelFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Use 'Metal' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSView View {
			[Export ("view")]
			get {
				NSView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setView:")]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetView_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetView_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class NSOpenGLContext */
}
