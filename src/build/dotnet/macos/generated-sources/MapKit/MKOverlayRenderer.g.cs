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
namespace MapKit {
	[Register("MKOverlayRenderer", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MKOverlayRenderer : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlphaX = "alpha";
		static readonly NativeHandle selAlphaXHandle = Selector.GetHandle ("alpha");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanDrawMapRect_ZoomScale_X = "canDrawMapRect:zoomScale:";
		static readonly NativeHandle selCanDrawMapRect_ZoomScale_XHandle = Selector.GetHandle ("canDrawMapRect:zoomScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentScaleFactorX = "contentScaleFactor";
		static readonly NativeHandle selContentScaleFactorXHandle = Selector.GetHandle ("contentScaleFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawMapRect_ZoomScale_InContext_X = "drawMapRect:zoomScale:inContext:";
		static readonly NativeHandle selDrawMapRect_ZoomScale_InContext_XHandle = Selector.GetHandle ("drawMapRect:zoomScale:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithOverlay_X = "initWithOverlay:";
		static readonly NativeHandle selInitWithOverlay_XHandle = Selector.GetHandle ("initWithOverlay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMapPointForPoint_X = "mapPointForPoint:";
		static readonly NativeHandle selMapPointForPoint_XHandle = Selector.GetHandle ("mapPointForPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMapRectForRect_X = "mapRectForRect:";
		static readonly NativeHandle selMapRectForRect_XHandle = Selector.GetHandle ("mapRectForRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOverlayX = "overlay";
		static readonly NativeHandle selOverlayXHandle = Selector.GetHandle ("overlay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointForMapPoint_X = "pointForMapPoint:";
		static readonly NativeHandle selPointForMapPoint_XHandle = Selector.GetHandle ("pointForMapPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRectForMapRect_X = "rectForMapRect:";
		static readonly NativeHandle selRectForMapRect_XHandle = Selector.GetHandle ("rectForMapRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlpha_X = "setAlpha:";
		static readonly NativeHandle selSetAlpha_XHandle = Selector.GetHandle ("setAlpha:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeedsDisplayX = "setNeedsDisplay";
		static readonly NativeHandle selSetNeedsDisplayXHandle = Selector.GetHandle ("setNeedsDisplay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeedsDisplayInMapRect_X = "setNeedsDisplayInMapRect:";
		static readonly NativeHandle selSetNeedsDisplayInMapRect_XHandle = Selector.GetHandle ("setNeedsDisplayInMapRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeedsDisplayInMapRect_ZoomScale_X = "setNeedsDisplayInMapRect:zoomScale:";
		static readonly NativeHandle selSetNeedsDisplayInMapRect_ZoomScale_XHandle = Selector.GetHandle ("setNeedsDisplayInMapRect:zoomScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MKOverlayRenderer");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MKOverlayRenderer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MKOverlayRenderer () : base (NSObjectFlag.Empty)
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
		protected MKOverlayRenderer (NSObjectFlag t) : base (t)
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
		protected internal MKOverlayRenderer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithOverlay:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKOverlayRenderer (IMKOverlay overlay)
			: base (NSObjectFlag.Empty)
		{
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithOverlay_XHandle, overlay__handle__), "initWithOverlay:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithOverlay_XHandle, overlay__handle__), "initWithOverlay:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
		}
		/// <param name="mapRect">To be added.</param><param name="zoomScale">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canDrawMapRect:zoomScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDrawMapRect (MKMapRect mapRect, nfloat zoomScale)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_MKMapRect_nfloat (this.Handle, selCanDrawMapRect_ZoomScale_XHandle, mapRect, zoomScale);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_MKMapRect_nfloat (&__objc_super__, selCanDrawMapRect_ZoomScale_XHandle, mapRect, zoomScale);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="mapRect">To be added.</param><param name="zoomScale">To be added.</param><param name="context">To be added.</param><summary>To be added.</summary><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("drawMapRect:zoomScale:inContext:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawMapRect (MKMapRect mapRect, nfloat zoomScale, CGContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect_nfloat_NativeHandle (this.Handle, selDrawMapRect_ZoomScale_InContext_XHandle, mapRect, zoomScale, context.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect_nfloat_NativeHandle (&__objc_super__, selDrawMapRect_ZoomScale_InContext_XHandle, mapRect, zoomScale, context.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		[Export ("mapPointForPoint:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapPoint MapPointForPoint (CGPoint point)
		{
			MKMapPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.MKMapPoint_objc_msgSend_CGPoint (this.Handle, selMapPointForPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.MKMapPoint_objc_msgSendSuper_CGPoint (&__objc_super__, selMapPointForPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("mapRectForRect:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapRect MapRectForRect (CGRect rect)
		{
			MKMapRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_CGRect (this.Handle, selMapRectForRect_XHandle, rect);
				} else {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret_CGRect (this.Handle, selMapRectForRect_XHandle, rect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_CGRect (&__objc_super__, selMapRectForRect_XHandle, rect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, selMapRectForRect_XHandle, rect);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("pointForMapPoint:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint PointForMapPoint (MKMapPoint mapPoint)
		{
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_MKMapPoint (this.Handle, selPointForMapPoint_XHandle, mapPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_MKMapPoint (&__objc_super__, selPointForMapPoint_XHandle, mapPoint);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("rectForMapRect:")]
		[ThreadSafe]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect RectForMapRect (MKMapRect mapRect)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_MKMapRect (this.Handle, selRectForMapRect_XHandle, mapRect);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_MKMapRect (this.Handle, selRectForMapRect_XHandle, mapRect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_MKMapRect (&__objc_super__, selRectForMapRect_XHandle, mapRect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_MKMapRect (&__objc_super__, selRectForMapRect_XHandle, mapRect);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("setNeedsDisplay")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplay ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetNeedsDisplayXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetNeedsDisplayXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setNeedsDisplayInMapRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplay (MKMapRect mapRect)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect (this.Handle, selSetNeedsDisplayInMapRect_XHandle, mapRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect (&__objc_super__, selSetNeedsDisplayInMapRect_XHandle, mapRect);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="mapRect">To be added.</param><param name="zoomScale">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setNeedsDisplayInMapRect:zoomScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplay (MKMapRect mapRect, nfloat zoomScale)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect_nfloat (this.Handle, selSetNeedsDisplayInMapRect_ZoomScale_XHandle, mapRect, zoomScale);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect_nfloat (&__objc_super__, selSetNeedsDisplayInMapRect_ZoomScale_XHandle, mapRect, zoomScale);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Alpha {
			[Export ("alpha")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selAlphaXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selAlphaXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetAlpha_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetAlpha_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ContentScaleFactor {
			[Export ("contentScaleFactor")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selContentScaleFactorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selContentScaleFactorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKOverlay Overlay {
			[Export ("overlay")]
			get {
				IMKOverlay? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMKOverlay> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOverlayXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMKOverlay> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOverlayXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MKOverlayRenderer */
}
