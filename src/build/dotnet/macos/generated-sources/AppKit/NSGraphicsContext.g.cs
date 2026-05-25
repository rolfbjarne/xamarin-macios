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
	[Register("NSGraphicsContext", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSGraphicsContext : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGContextX = "CGContext";
		static readonly NativeHandle selCGContextXHandle = Selector.GetHandle ("CGContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCIContextX = "CIContext";
		static readonly NativeHandle selCIContextXHandle = Selector.GetHandle ("CIContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesX = "attributes";
		static readonly NativeHandle selAttributesXHandle = Selector.GetHandle ("attributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorRenderingIntentX = "colorRenderingIntent";
		static readonly NativeHandle selColorRenderingIntentXHandle = Selector.GetHandle ("colorRenderingIntent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompositingOperationX = "compositingOperation";
		static readonly NativeHandle selCompositingOperationXHandle = Selector.GetHandle ("compositingOperation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentContextX = "currentContext";
		static readonly NativeHandle selCurrentContextXHandle = Selector.GetHandle ("currentContext");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentContextDrawingToScreenX = "currentContextDrawingToScreen";
		static readonly NativeHandle selCurrentContextDrawingToScreenXHandle = Selector.GetHandle ("currentContextDrawingToScreen");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlushGraphicsX = "flushGraphics";
		static readonly NativeHandle selFlushGraphicsXHandle = Selector.GetHandle ("flushGraphics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphicsContextWithAttributes_X = "graphicsContextWithAttributes:";
		static readonly NativeHandle selGraphicsContextWithAttributes_XHandle = Selector.GetHandle ("graphicsContextWithAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphicsContextWithBitmapImageRep_X = "graphicsContextWithBitmapImageRep:";
		static readonly NativeHandle selGraphicsContextWithBitmapImageRep_XHandle = Selector.GetHandle ("graphicsContextWithBitmapImageRep:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphicsContextWithCGContext_Flipped_X = "graphicsContextWithCGContext:flipped:";
		static readonly NativeHandle selGraphicsContextWithCGContext_Flipped_XHandle = Selector.GetHandle ("graphicsContextWithCGContext:flipped:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphicsContextWithGraphicsPort_Flipped_X = "graphicsContextWithGraphicsPort:flipped:";
		static readonly NativeHandle selGraphicsContextWithGraphicsPort_Flipped_XHandle = Selector.GetHandle ("graphicsContextWithGraphicsPort:flipped:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphicsContextWithWindow_X = "graphicsContextWithWindow:";
		static readonly NativeHandle selGraphicsContextWithWindow_XHandle = Selector.GetHandle ("graphicsContextWithWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGraphicsPortX = "graphicsPort";
		static readonly NativeHandle selGraphicsPortXHandle = Selector.GetHandle ("graphicsPort");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageInterpolationX = "imageInterpolation";
		static readonly NativeHandle selImageInterpolationXHandle = Selector.GetHandle ("imageInterpolation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDrawingToScreenX = "isDrawingToScreen";
		static readonly NativeHandle selIsDrawingToScreenXHandle = Selector.GetHandle ("isDrawingToScreen");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFlippedX = "isFlipped";
		static readonly NativeHandle selIsFlippedXHandle = Selector.GetHandle ("isFlipped");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPatternPhaseX = "patternPhase";
		static readonly NativeHandle selPatternPhaseXHandle = Selector.GetHandle ("patternPhase");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRestoreGraphicsStateX = "restoreGraphicsState";
		static readonly NativeHandle selRestoreGraphicsStateXHandle = Selector.GetHandle ("restoreGraphicsState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveGraphicsStateX = "saveGraphicsState";
		static readonly NativeHandle selSaveGraphicsStateXHandle = Selector.GetHandle ("saveGraphicsState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorRenderingIntent_X = "setColorRenderingIntent:";
		static readonly NativeHandle selSetColorRenderingIntent_XHandle = Selector.GetHandle ("setColorRenderingIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCompositingOperation_X = "setCompositingOperation:";
		static readonly NativeHandle selSetCompositingOperation_XHandle = Selector.GetHandle ("setCompositingOperation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurrentContext_X = "setCurrentContext:";
		static readonly NativeHandle selSetCurrentContext_XHandle = Selector.GetHandle ("setCurrentContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGraphicsState_X = "setGraphicsState:";
		static readonly NativeHandle selSetGraphicsState_XHandle = Selector.GetHandle ("setGraphicsState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetImageInterpolation_X = "setImageInterpolation:";
		static readonly NativeHandle selSetImageInterpolation_XHandle = Selector.GetHandle ("setImageInterpolation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPatternPhase_X = "setPatternPhase:";
		static readonly NativeHandle selSetPatternPhase_XHandle = Selector.GetHandle ("setPatternPhase:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldAntialias_X = "setShouldAntialias:";
		static readonly NativeHandle selSetShouldAntialias_XHandle = Selector.GetHandle ("setShouldAntialias:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldAntialiasX = "shouldAntialias";
		static readonly NativeHandle selShouldAntialiasXHandle = Selector.GetHandle ("shouldAntialias");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSGraphicsContext");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSGraphicsContext" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSGraphicsContext () : base (NSObjectFlag.Empty)
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
		protected NSGraphicsContext (NSObjectFlag t) : base (t)
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
		protected internal NSGraphicsContext (NativeHandle handle) : base (handle)
		{
		}

		[Export ("flushGraphics")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FlushGraphics ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFlushGraphicsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFlushGraphicsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("graphicsContextWithAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSGraphicsContext FromAttributes (NSDictionary attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			NSGraphicsContext? ret;
			ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selGraphicsContextWithAttributes_XHandle, attributes__handle__), false)!;
			GC.KeepAlive (attributes);
			return ret!;
		}
		[Export ("graphicsContextWithBitmapImageRep:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSGraphicsContext FromBitmap (NSBitmapImageRep bitmapRep)
		{
			var bitmapRep__handle__ = bitmapRep!.GetNonNullHandle (nameof (bitmapRep));
			NSGraphicsContext? ret;
			ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selGraphicsContextWithBitmapImageRep_XHandle, bitmapRep__handle__), false)!;
			GC.KeepAlive (bitmapRep);
			return ret!;
		}
		[Export ("graphicsContextWithCGContext:flipped:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSGraphicsContext FromCGContext (CGContext graphicsPort, bool initialFlippedState)
		{
			var graphicsPort__handle__ = graphicsPort!.GetNonNullHandle (nameof (graphicsPort));
			NSGraphicsContext? ret;
			ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, selGraphicsContextWithCGContext_Flipped_XHandle, graphicsPort.Handle, initialFlippedState ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (graphicsPort);
			return ret!;
		}
		[Export ("graphicsContextWithGraphicsPort:flipped:")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'FromCGContext' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSGraphicsContext FromGraphicsPort (nint graphicsPort, bool initialFlippedState)
		{
			NSGraphicsContext ret;
			ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_bool (class_ptr, selGraphicsContextWithGraphicsPort_Flipped_XHandle, graphicsPort, initialFlippedState ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("graphicsContextWithWindow:")]
		[ObsoletedOSPlatform ("macos15.0", "Add NSView instances to display content in a window.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSGraphicsContext FromWindow (NSWindow window)
		{
			var window__handle__ = window!.GetNonNullHandle (nameof (window));
			NSGraphicsContext? ret;
			ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selGraphicsContextWithWindow_XHandle, window__handle__), false)!;
			GC.KeepAlive (window);
			return ret!;
		}
		[Export ("restoreGraphicsState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void GlobalRestoreGraphicsState ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selRestoreGraphicsStateXHandle);
		}
		[Export ("saveGraphicsState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void GlobalSaveGraphicsState ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selSaveGraphicsStateXHandle);
		}
		[Export ("restoreGraphicsState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RestoreGraphicsState ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRestoreGraphicsStateXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRestoreGraphicsStateXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("saveGraphicsState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveGraphicsState ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSaveGraphicsStateXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSaveGraphicsStateXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setGraphicsState:")]
		[ObsoletedOSPlatform ("macos10.10", "This method has no effect.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetGraphicsState (nint gState)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetGraphicsState_XHandle, gState);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Attributes {
			[Export ("attributes")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGContext CGContext {
			[Export ("CGContext")]
			get {
				CGContext ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCGContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCGContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreImage.CIContext CIContext {
			[Export ("CIContext")]
			get {
				global::CoreImage.CIContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreImage.CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCIContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::CoreImage.CIContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCIContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSColorRenderingIntent ColorRenderingIntent {
			[Export ("colorRenderingIntent")]
			get {
				NSColorRenderingIntent ret;
				if (IsDirectBinding) {
					ret = (NSColorRenderingIntent) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorRenderingIntentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSColorRenderingIntent) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selColorRenderingIntentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColorRenderingIntent:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColorRenderingIntent_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetColorRenderingIntent_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComposite CompositingOperation {
			[Export ("compositingOperation")]
			get {
				NSComposite ret;
				if (IsDirectBinding) {
					ret = (NSComposite) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCompositingOperationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSComposite) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCompositingOperationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCompositingOperation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetCompositingOperation_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetCompositingOperation_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSGraphicsContext? CurrentContext {
			[Export ("currentContext")]
			get {
				NSGraphicsContext? ret;
				ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCurrentContextXHandle), false)!;
				return ret!;
			}
			[Export ("setCurrentContext:")]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetCurrentContext_XHandle, value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.14", "Use 'CGContext' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual nint GraphicsPortHandle {
			[Export ("graphicsPort")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGraphicsPortXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selGraphicsPortXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImageInterpolation ImageInterpolation {
			[Export ("imageInterpolation")]
			get {
				NSImageInterpolation ret;
				if (IsDirectBinding) {
					ret = (NSImageInterpolation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selImageInterpolationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSImageInterpolation) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selImageInterpolationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setImageInterpolation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetImageInterpolation_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetImageInterpolation_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCurrentContextDrawingToScreen {
			[Export ("currentContextDrawingToScreen")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selCurrentContextDrawingToScreenXHandle);
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDrawingToScreen {
			[Export ("isDrawingToScreen")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDrawingToScreenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDrawingToScreenXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFlipped {
			[Export ("isFlipped")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFlippedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFlippedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint PatternPhase {
			[Export ("patternPhase")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selPatternPhaseXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selPatternPhaseXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPatternPhase:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetPatternPhase_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetPatternPhase_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldAntialias {
			[Export ("shouldAntialias")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldAntialiasXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldAntialiasXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldAntialias:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldAntialias_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldAntialias_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSGraphicsContext */
}
