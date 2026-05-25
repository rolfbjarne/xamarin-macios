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
namespace MapKit {
	/// <summary>The visual representation of a <see cref="T:MapKit.MKOverlay" />. <see cref="T:MapKit.MKOverlayRenderer" /> should be used instead of this class in apps targeting iOS 7 and later.</summary><remarks><para>Application developers targeting iOS 7 and later should prefer to use <see cref="T:MapKit.MKOverlayRenderer" />. That class has higher performance and places overlays beneath labels.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MapKit/Reference/MKOverlayView_class/index.html">Apple documentation for <c>MKOverlayView</c></related>
	[Register("MKOverlayView", true)]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Use 'MKOverlayRenderer' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MKOverlayRenderer' instead.")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class MKOverlayView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MKOverlayView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MKOverlayView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MKOverlayView () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		public MKOverlayView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected MKOverlayView (NSObjectFlag t) : base (t)
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
		protected internal MKOverlayView (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="frame">Frame used by the view, expressed in iOS points.</param><summary>Initializes the MKOverlayView with the specified frame.</summary><remarks><para>This constructor is used to programmatically create a new instance of MKOverlayView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para><para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para></remarks>
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKOverlayView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithOverlay:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKOverlayView (IMKOverlay overlay)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithOverlay:"), overlay__handle__), "initWithOverlay:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithOverlay:"), overlay__handle__), "initWithOverlay:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
		}
		/// <param name="mapRect">A <see cref="T:MapKit.MKMapRect" /> representing the area to potentially be drawn.</param><param name="zoomScale">The current scale factor.</param><summary>Returns <see langword="true" /> if the <see cref="T:MapKit.MKOverlayView" /> has the data it needs to draw properly.</summary><returns>The default value is <see langword="true" />.</returns><remarks><para>Application developers can override this method so that it returns <see langword="false" /> until the <see cref="T:MapKit.MKOverlayView" /> has all the data it needs in order to render properly. For instance, a weather overlay might return <see langword="false" /> until it has downloaded meteorological data.</para><para>If application developers return <see langword="false" /> from this method, they must subsequently call <see cref="M:MapKit.MKOverlayView.SetNeedsDisplay(MapKit.MKMapRect,System.Runtime.InteropServices.NFloat)" /> when they have received the data and performed the calculations needed to make this function return <see langword="true" />.</para></remarks>
		[Export ("canDrawMapRect:zoomScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDrawMapRect (MKMapRect mapRect, nfloat zoomScale)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_MKMapRect_nfloat (this.Handle, Selector.GetHandle ("canDrawMapRect:zoomScale:"), mapRect, zoomScale);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_MKMapRect_nfloat (&__objc_super__, Selector.GetHandle ("canDrawMapRect:zoomScale:"), mapRect, zoomScale);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect_nfloat_NativeHandle (this.Handle, Selector.GetHandle ("drawMapRect:zoomScale:inContext:"), mapRect, zoomScale, context.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect_nfloat_NativeHandle (&__objc_super__, Selector.GetHandle ("drawMapRect:zoomScale:inContext:"), mapRect, zoomScale, context.Handle);
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
				ret = global::ObjCRuntime.Messaging.MKMapPoint_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("mapPointForPoint:"), point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.MKMapPoint_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("mapPointForPoint:"), point);
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
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("mapRectForRect:"), rect);
				} else {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("mapRectForRect:"), rect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("mapRectForRect:"), rect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("mapRectForRect:"), rect);
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
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_MKMapPoint (this.Handle, Selector.GetHandle ("pointForMapPoint:"), mapPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_MKMapPoint (&__objc_super__, Selector.GetHandle ("pointForMapPoint:"), mapPoint);
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
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_MKMapRect (this.Handle, Selector.GetHandle ("rectForMapRect:"), mapRect);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_MKMapRect (this.Handle, Selector.GetHandle ("rectForMapRect:"), mapRect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_MKMapRect (&__objc_super__, Selector.GetHandle ("rectForMapRect:"), mapRect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_MKMapRect (&__objc_super__, Selector.GetHandle ("rectForMapRect:"), mapRect);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("setNeedsDisplayInMapRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplay (MKMapRect mapRect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect (this.Handle, Selector.GetHandle ("setNeedsDisplayInMapRect:"), mapRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect (&__objc_super__, Selector.GetHandle ("setNeedsDisplayInMapRect:"), mapRect);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="mapRect">The <see cref="T:MapKit.MKMapRect" /> to invalidate.</param><param name="zoomScale">The zoom scale to invalidate.</param><summary>Invalidates the view in the specified <paramref name="mapRect" /> at the specified <paramref name="zoomScale" />.</summary><remarks>To be added.</remarks>
		[Export ("setNeedsDisplayInMapRect:zoomScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplay (MKMapRect mapRect, nfloat zoomScale)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect_nfloat (this.Handle, Selector.GetHandle ("setNeedsDisplayInMapRect:zoomScale:"), mapRect, zoomScale);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect_nfloat (&__objc_super__, Selector.GetHandle ("setNeedsDisplayInMapRect:zoomScale:"), mapRect, zoomScale);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKOverlay Overlay {
			[Export ("overlay")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IMKOverlay? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMKOverlay> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("overlay")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMKOverlay> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("overlay")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::MapKit.MKOverlayView" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::MapKit.MKOverlayView" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::MapKit.MKOverlayView.Appearance" /> property or by calling <see cref="global::MapKit.MKOverlayView.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class MKOverlayViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal MKOverlayViewAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::MapKit.MKOverlayView" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MapKit.MKOverlayView" />, they should use the <see cref="global::MapKit.MKOverlayView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new MKOverlayViewAppearance Appearance {
			get { return new MKOverlayViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKOverlayView.MKOverlayViewAppearance" /> for the subclass of <see cref="global::MapKit.MKOverlayView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::MapKit.MKOverlayView" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::MapKit.MKOverlayView.Appearance" /> property, or the <see cref="global::MapKit.MKOverlayView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = MKOverlayView.GetAppearance<MyMKOverlayViewSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKOverlayViewAppearance GetAppearance<T> () where T: MKOverlayView {
			return new MKOverlayViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::MapKit.MKOverlayView" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MapKit.MKOverlayView" />, they should use the <see cref="global::MapKit.MKOverlayView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKOverlayViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MKOverlayViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKOverlayView.MKOverlayViewAppearance" /> for <see cref="global::MapKit.MKOverlayView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MKOverlayView.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MapKit.MKOverlayView" />, they should use the <see cref="global::MapKit.MKOverlayView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKOverlayViewAppearance GetAppearance (UITraitCollection traits) {
			return new MKOverlayViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKOverlayView.MKOverlayViewAppearance" /> for <see cref="global::MapKit.MKOverlayView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MKOverlayView.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MapKit.MKOverlayView" />, they should use the <see cref="global::MapKit.MKOverlayView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKOverlayViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MKOverlayViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKOverlayView.MKOverlayViewAppearance" /> for the subclass of <see cref="global::MapKit.MKOverlayView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::MapKit.MKOverlayView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::MapKit.MKOverlayView.Appearance" /> property, or the <see cref="global::MapKit.MKOverlayView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MKOverlayView.GetAppearance<MyMKOverlayViewSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKOverlayViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MKOverlayView {
			return new MKOverlayViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKOverlayView.MKOverlayViewAppearance" /> for the subclass of <see cref="global::MapKit.MKOverlayView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::MapKit.MKOverlayView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::MapKit.MKOverlayView.Appearance" /> property, or the <see cref="global::MapKit.MKOverlayView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MKOverlayView.GetAppearance<MyMKOverlayViewSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKOverlayViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MKOverlayView{
			return new MKOverlayViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class MKOverlayView */
}
