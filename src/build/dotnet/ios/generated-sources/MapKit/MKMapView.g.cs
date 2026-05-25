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
	[Register("MKMapView", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MKMapView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MKMapView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MKMapView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MKMapView () : base (NSObjectFlag.Empty)
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
		public MKMapView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MKMapView (NSObjectFlag t) : base (t)
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
		protected internal MKMapView (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="frame">Frame used by the view, expressed in iOS points.</param><summary>Initializes the MKMapView with the specified frame.</summary><remarks><para>This constructor is used to programmatically create a new instance of MKMapView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para><para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para></remarks>
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKMapView (CGRect frame)
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
		[Export ("addAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotation (IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addAnnotation:"), annotation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addAnnotation:"), annotation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addAnnotations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnnotations (params IMKAnnotation[] annotations)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (annotations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (annotations));
			using var nsa_annotations = NSArray.FromNSObjects (annotations);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addAnnotations:"), nsa_annotations.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addAnnotations:"), nsa_annotations.Handle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlay (IMKOverlay overlay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addOverlay:"), overlay__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addOverlay:"), overlay__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addOverlay:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlay (IMKOverlay overlay, MKOverlayLevel level)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("addOverlay:level:"), overlay__handle__, (IntPtr) (long) level);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("addOverlay:level:"), overlay__handle__, (IntPtr) (long) level);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addOverlays:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlays (IMKOverlay[] overlays)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (overlays is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (overlays));
			using var nsa_overlays = NSArray.FromNSObjects (overlays);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addOverlays:"), nsa_overlays.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addOverlays:"), nsa_overlays.Handle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("addOverlays:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOverlays (IMKOverlay[] overlays, MKOverlayLevel level)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (overlays is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (overlays));
			using var nsa_overlays = NSArray.FromNSObjects (overlays);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("addOverlays:level:"), nsa_overlays.Handle, (IntPtr) (long) level);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("addOverlays:level:"), nsa_overlays.Handle, (IntPtr) (long) level);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("convertCoordinate:toPointToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, global::UIKit.UIView? toPointToView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toPointToView__handle__ = toPointToView.GetHandle ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D_NativeHandle (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, toPointToView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_NativeHandle (&__objc_super__, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, toPointToView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toPointToView);
			return ret!;
		}
		[Export ("convertPoint:toCoordinateFromView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D ConvertPoint (CGPoint point, global::UIKit.UIView? toCoordinateFromView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toCoordinateFromView__handle__ = toCoordinateFromView.GetHandle ();
			global::CoreLocation.CLLocationCoordinate2D ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, toCoordinateFromView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, toCoordinateFromView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toCoordinateFromView);
			return ret!;
		}
		[Export ("convertRect:toRegionFromView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKCoordinateRegion ConvertRect (CGRect rect, global::UIKit.UIView? toRegionFromView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toRegionFromView__handle__ = toRegionFromView.GetHandle ();
			MKCoordinateRegion ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toRegionFromView:"), rect, toRegionFromView__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("convertRect:toRegionFromView:"), rect, toRegionFromView__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:toRegionFromView:"), rect, toRegionFromView__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRect:toRegionFromView:"), rect, toRegionFromView__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (toRegionFromView);
			return ret!;
		}
		[Export ("convertRegion:toRectToView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRegion (MKCoordinateRegion region, global::UIKit.UIView? toRectToView)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var toRectToView__handle__ = toRectToView.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_MKCoordinateRegion_NativeHandle (this.Handle, Selector.GetHandle ("convertRegion:toRectToView:"), region, toRectToView__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_MKCoordinateRegion_NativeHandle (this.Handle, Selector.GetHandle ("convertRegion:toRectToView:"), region, toRectToView__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_MKCoordinateRegion_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRegion:toRectToView:"), region, toRectToView__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_MKCoordinateRegion_NativeHandle (&__objc_super__, Selector.GetHandle ("convertRegion:toRectToView:"), region, toRectToView__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (toRectToView);
			return ret!;
		}
		[Export ("dequeueReusableAnnotationViewWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKAnnotationView? DequeueReusableAnnotation (string withViewIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (withViewIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (withViewIdentifier));
			var nswithViewIdentifier = CFString.CreateNative (withViewIdentifier);
			MKAnnotationView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("dequeueReusableAnnotationViewWithIdentifier:"), nswithViewIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("dequeueReusableAnnotationViewWithIdentifier:"), nswithViewIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nswithViewIdentifier);
			return ret!;
		}
		[Export ("dequeueReusableAnnotationViewWithIdentifier:forAnnotation:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKAnnotationView DequeueReusableAnnotation (string identifier, IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			var nsidentifier = CFString.CreateNative (identifier);
			MKAnnotationView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("dequeueReusableAnnotationViewWithIdentifier:forAnnotation:"), nsidentifier, annotation__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("dequeueReusableAnnotationViewWithIdentifier:forAnnotation:"), nsidentifier, annotation__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("deselectAnnotation:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeselectAnnotation (IMKAnnotation? annotation, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var annotation__handle__ = annotation.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("deselectAnnotation:animated:"), annotation__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("deselectAnnotation:animated:"), annotation__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("exchangeOverlay:withOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExchangeOverlay (IMKOverlay overlay1, IMKOverlay overlay2)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay1__handle__ = overlay1!.GetNonNullHandle (nameof (overlay1));
			var overlay2__handle__ = overlay2!.GetNonNullHandle (nameof (overlay2));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("exchangeOverlay:withOverlay:"), overlay1__handle__, overlay2__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("exchangeOverlay:withOverlay:"), overlay1__handle__, overlay2__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay1);
			GC.KeepAlive (overlay2);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="index1">The index of the first overlay.</param><param name="index2">The index of the second overlay.</param><summary>Swaps the index positions of two overlays.</summary><remarks>Changing the index positions of the overlays will swap their z-order on the map.</remarks>
		[Export ("exchangeOverlayAtIndex:withOverlayAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExchangeOverlays (nint index1, nint index2)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("exchangeOverlayAtIndex:withOverlayAtIndex:"), index1, index2);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("exchangeOverlayAtIndex:withOverlayAtIndex:"), index1, index2);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("annotationsInMapRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet GetAnnotations (MKMapRect mapRect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_MKMapRect (this.Handle, Selector.GetHandle ("annotationsInMapRect:"), mapRect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_MKMapRect (&__objc_super__, Selector.GetHandle ("annotationsInMapRect:"), mapRect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="overlay">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertOverlay:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertOverlay (IMKOverlay overlay, nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("insertOverlay:atIndex:"), overlay__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("insertOverlay:atIndex:"), overlay__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="overlay">To be added.</param><param name="index">To be added.</param><param name="level">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertOverlay:atIndex:level:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertOverlay (IMKOverlay overlay, nuint index, MKOverlayLevel level)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("insertOverlay:atIndex:level:"), overlay__handle__, index, (IntPtr) (long) level);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("insertOverlay:atIndex:level:"), overlay__handle__, index, (IntPtr) (long) level);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("insertOverlay:aboveOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertOverlayAbove (IMKOverlay overlay, IMKOverlay sibling)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var sibling__handle__ = sibling!.GetNonNullHandle (nameof (sibling));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertOverlay:aboveOverlay:"), overlay__handle__, sibling__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("insertOverlay:aboveOverlay:"), overlay__handle__, sibling__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			GC.KeepAlive (sibling);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("insertOverlay:belowOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertOverlayBelow (IMKOverlay overlay, IMKOverlay sibling)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			var sibling__handle__ = sibling!.GetNonNullHandle (nameof (sibling));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertOverlay:belowOverlay:"), overlay__handle__, sibling__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("insertOverlay:belowOverlay:"), overlay__handle__, sibling__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			GC.KeepAlive (sibling);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("mapRectThatFits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapRect MapRectThatFits (MKMapRect mapRect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			MKMapRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_MKMapRect (this.Handle, Selector.GetHandle ("mapRectThatFits:"), mapRect);
				} else {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret_MKMapRect (this.Handle, Selector.GetHandle ("mapRectThatFits:"), mapRect);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_MKMapRect (&__objc_super__, Selector.GetHandle ("mapRectThatFits:"), mapRect);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_stret_MKMapRect (&__objc_super__, Selector.GetHandle ("mapRectThatFits:"), mapRect);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("mapRectThatFits:edgePadding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapRect MapRectThatFits (MKMapRect mapRect, global::UIKit.UIEdgeInsets edgePadding)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			MKMapRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_MKMapRect_UIEdgeInsets (this.Handle, Selector.GetHandle ("mapRectThatFits:edgePadding:"), mapRect, edgePadding);
				} else {
					ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret_MKMapRect_UIEdgeInsets (this.Handle, Selector.GetHandle ("mapRectThatFits:edgePadding:"), mapRect, edgePadding);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_MKMapRect_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("mapRectThatFits:edgePadding:"), mapRect, edgePadding);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_stret_MKMapRect_UIEdgeInsets (&__objc_super__, Selector.GetHandle ("mapRectThatFits:edgePadding:"), mapRect, edgePadding);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("overlaysInLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKOverlay[] OverlaysInLevel (MKOverlayLevel level)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IMKOverlay[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<IMKOverlay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("overlaysInLevel:"), (IntPtr) (long) level), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<IMKOverlay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("overlaysInLevel:"), (IntPtr) (long) level), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("regionThatFits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKCoordinateRegion RegionThatFits (MKCoordinateRegion region)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			MKCoordinateRegion ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_MKCoordinateRegion (this.Handle, Selector.GetHandle ("regionThatFits:"), region);
				} else {
					ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_stret_MKCoordinateRegion (this.Handle, Selector.GetHandle ("regionThatFits:"), region);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_MKCoordinateRegion (&__objc_super__, Selector.GetHandle ("regionThatFits:"), region);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_stret_MKCoordinateRegion (&__objc_super__, Selector.GetHandle ("regionThatFits:"), region);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("registerClass:forAnnotationViewWithReuseIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Register (Class? viewClass, string identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewClass__handle__ = viewClass.GetHandle ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("registerClass:forAnnotationViewWithReuseIdentifier:"), viewClass__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("registerClass:forAnnotationViewWithReuseIdentifier:"), viewClass__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (viewClass);
			CFString.ReleaseNative (nsidentifier);
		}
		/// <param name="viewType">To be added.</param><param name="identifier">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Register (global::System.Type? viewType, string identifier)
		{
			Register (viewType is null ? null : new Class (viewType), identifier);
		}
		[Export ("removeAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnnotation (IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeAnnotation:"), annotation__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeAnnotation:"), annotation__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeAnnotations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnnotations (params IMKAnnotation[] annotations)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (annotations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (annotations));
			using var nsa_annotations = NSArray.FromNSObjects (annotations);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeAnnotations:"), nsa_annotations.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeAnnotations:"), nsa_annotations.Handle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveOverlay (IMKOverlay overlay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeOverlay:"), overlay__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeOverlay:"), overlay__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("removeOverlays:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveOverlays (params IMKOverlay[] overlays)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (overlays is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (overlays));
			using var nsa_overlays = NSArray.FromNSObjects (overlays);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeOverlays:"), nsa_overlays.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeOverlays:"), nsa_overlays.Handle);
					GC.KeepAlive (this);
				}
			}
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("rendererForOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKOverlayRenderer? RendererForOverlay (IMKOverlay overlay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			MKOverlayRenderer? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MKOverlayRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("rendererForOverlay:"), overlay__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MKOverlayRenderer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("rendererForOverlay:"), overlay__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			return ret!;
		}
		[Export ("selectAnnotation:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectAnnotation (IMKAnnotation annotation, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("selectAnnotation:animated:"), annotation__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("selectAnnotation:animated:"), annotation__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		[Export ("setCamera:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCamera (MKMapCamera camera, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var camera__handle__ = camera!.GetNonNullHandle (nameof (camera));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("setCamera:animated:"), camera__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("setCamera:animated:"), camera__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (camera);
		}
		[Export ("setCameraBoundary:animated:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCameraBoundary (MKMapCameraBoundary? cameraBoundary, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var cameraBoundary__handle__ = cameraBoundary.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("setCameraBoundary:animated:"), cameraBoundary__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("setCameraBoundary:animated:"), cameraBoundary__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cameraBoundary);
		}
		[Export ("setCameraZoomRange:animated:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCameraZoomRange (MKMapCameraZoomRange? cameraZoomRange, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var cameraZoomRange__handle__ = cameraZoomRange.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("setCameraZoomRange:animated:"), cameraZoomRange__handle__, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("setCameraZoomRange:animated:"), cameraZoomRange__handle__, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (cameraZoomRange);
		}
		[Export ("setCenterCoordinate:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D_bool (this.Handle, Selector.GetHandle ("setCenterCoordinate:animated:"), coordinate, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_bool (&__objc_super__, Selector.GetHandle ("setCenterCoordinate:animated:"), coordinate, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setRegion:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRegion (MKCoordinateRegion region, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKCoordinateRegion_bool (this.Handle, Selector.GetHandle ("setRegion:animated:"), region, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKCoordinateRegion_bool (&__objc_super__, Selector.GetHandle ("setRegion:animated:"), region, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setUserTrackingMode:animated:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetUserTrackingMode (MKUserTrackingMode trackingMode, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_bool (this.Handle, Selector.GetHandle ("setUserTrackingMode:animated:"), (UIntPtr) (ulong) trackingMode, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_bool (&__objc_super__, Selector.GetHandle ("setUserTrackingMode:animated:"), (UIntPtr) (ulong) trackingMode, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setVisibleMapRect:edgePadding:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleMapRect (MKMapRect mapRect, global::UIKit.UIEdgeInsets edgePadding, bool animate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect_UIEdgeInsets_bool (this.Handle, Selector.GetHandle ("setVisibleMapRect:edgePadding:animated:"), mapRect, edgePadding, animate ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect_UIEdgeInsets_bool (&__objc_super__, Selector.GetHandle ("setVisibleMapRect:edgePadding:animated:"), mapRect, edgePadding, animate ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setVisibleMapRect:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleMapRect (MKMapRect mapRect, bool animate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect_bool (this.Handle, Selector.GetHandle ("setVisibleMapRect:animated:"), mapRect, animate ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect_bool (&__objc_super__, Selector.GetHandle ("setVisibleMapRect:animated:"), mapRect, animate ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("showAnnotations:animated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAnnotations (IMKAnnotation[] annotations, bool animated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (annotations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (annotations));
			using var nsa_annotations = NSArray.FromNSObjects (annotations);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("showAnnotations:animated:"), nsa_annotations.Handle, animated ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("showAnnotations:animated:"), nsa_annotations.Handle, animated ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("viewForAnnotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKAnnotationView? ViewForAnnotation (IMKAnnotation annotation)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var annotation__handle__ = annotation!.GetNonNullHandle (nameof (annotation));
			MKAnnotationView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewForAnnotation:"), annotation__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MKAnnotationView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("viewForAnnotation:"), annotation__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			return ret!;
		}
		[Export ("viewForOverlay:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MKOverlayRenderer.RendererForOverlay' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKOverlayView ViewForOverlay (IMKOverlay overlay)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var overlay__handle__ = overlay!.GetNonNullHandle (nameof (overlay));
			MKOverlayView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MKOverlayView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("viewForOverlay:"), overlay__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MKOverlayView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("viewForOverlay:"), overlay__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (overlay);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect AnnotationVisibleRect {
			[Export ("annotationVisibleRect")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("annotationVisibleRect"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("annotationVisibleRect"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("annotationVisibleRect"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("annotationVisibleRect"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKAnnotation[] Annotations {
			[Export ("annotations")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IMKAnnotation[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMKAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("annotations")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMKAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("annotations")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapCamera Camera {
			[Export ("camera", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKMapCamera? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKMapCamera> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("camera")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKMapCamera> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("camera")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCamera:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCamera:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCamera:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual MKMapCameraBoundary? CameraBoundary {
			[Export ("cameraBoundary", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKMapCameraBoundary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKMapCameraBoundary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("cameraBoundary")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKMapCameraBoundary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cameraBoundary")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCameraBoundary:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCameraBoundary:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCameraBoundary:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual MKMapCameraZoomRange? CameraZoomRange {
			[Export ("cameraZoomRange", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKMapCameraZoomRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKMapCameraZoomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("cameraZoomRange")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKMapCameraZoomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cameraZoomRange")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCameraZoomRange:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCameraZoomRange:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCameraZoomRange:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreLocation.CLLocationCoordinate2D CenterCoordinate {
			[Export ("centerCoordinate")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("centerCoordinate"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("centerCoordinate"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCenterCoordinate:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("setCenterCoordinate:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D (&__objc_super__, Selector.GetHandle ("setCenterCoordinate:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the MapKit.IMKMapViewDelegate model class which acts as the class delegate.</summary><value>The instance of the MapKit.IMKMapViewDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMKMapViewDelegate Delegate {
			get {
				return (WeakDelegate as IMKMapViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapType MapType {
			[Export ("mapType")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKMapType ret;
				if (IsDirectBinding) {
					ret = (MKMapType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mapType"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MKMapType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mapType"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMapType:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setMapType:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setMapType:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKOverlay[] Overlays {
			[Export ("overlays")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IMKOverlay[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMKOverlay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("overlays")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMKOverlay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("overlays")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual MKFeatureVisibility PitchButtonVisibility {
			[Export ("pitchButtonVisibility", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKFeatureVisibility ret;
				if (IsDirectBinding) {
					ret = (MKFeatureVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pitchButtonVisibility"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MKFeatureVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pitchButtonVisibility"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPitchButtonVisibility:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPitchButtonVisibility:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setPitchButtonVisibility:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the view uses the angle defined by the <see cref="P:MapKit.MKMapView.Camera" />.</summary><value>The default value is <see langword="true" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool PitchEnabled {
			[Export ("isPitchEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPitchEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isPitchEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPitchEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPitchEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setPitchEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual MKPointOfInterestFilter? PointOfInterestFilter {
			[Export ("pointOfInterestFilter", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKPointOfInterestFilter? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKPointOfInterestFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pointOfInterestFilter")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKPointOfInterestFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pointOfInterestFilter")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPointOfInterestFilter:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPointOfInterestFilter:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPointOfInterestFilter:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		public virtual MKMapConfiguration PreferredConfiguration {
			[Export ("preferredConfiguration", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKMapConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKMapConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredConfiguration")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKMapConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredConfiguration")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredConfiguration:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPreferredConfiguration:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPreferredConfiguration:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKCoordinateRegion Region {
			[Export ("region")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKCoordinateRegion ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend (this.Handle, Selector.GetHandle ("region"));
					} else {
						ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSend_stret (this.Handle, Selector.GetHandle ("region"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("region"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MKCoordinateRegion_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("region"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setRegion:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MKCoordinateRegion (this.Handle, Selector.GetHandle ("setRegion:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKCoordinateRegion (&__objc_super__, Selector.GetHandle ("setRegion:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the view uses the heading defined by the <see cref="P:MapKit.MKMapView.Camera" />.</summary><value>The default value is <see langword="true" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool RotateEnabled {
			[Export ("isRotateEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRotateEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isRotateEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRotateEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRotateEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setRotateEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Control if the map can be scrolled with a pan gesture.</summary><value></value><remarks>Only controls interactive scrolling. The region can be changed in code regardless of this property.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ScrollEnabled {
			[Export ("isScrollEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScrollEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isScrollEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setScrollEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setScrollEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		public virtual MKMapFeatureOptions SelectableMapFeatures {
			[Export ("selectableMapFeatures", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKMapFeatureOptions ret;
				if (IsDirectBinding) {
					ret = (MKMapFeatureOptions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectableMapFeatures"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MKMapFeatureOptions) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectableMapFeatures"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectableMapFeatures:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectableMapFeatures:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setSelectableMapFeatures:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMKAnnotation[] SelectedAnnotations {
			[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IMKAnnotation[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMKAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedAnnotations")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMKAnnotation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("selectedAnnotations")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSelectedAnnotations:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSelectedAnnotations:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setSelectedAnnotations:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsBuildings {
			[Export ("showsBuildings")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsBuildings"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsBuildings"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsBuildings:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsBuildings:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsBuildings:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool ShowsCompass {
			[Export ("showsCompass")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsCompass"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsCompass"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsCompass:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsCompass:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsCompass:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.15", "Use 'PointOfInterestFilter' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'PointOfInterestFilter' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'PointOfInterestFilter' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PointOfInterestFilter' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ShowsPointsOfInterest {
			[Export ("showsPointsOfInterest")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsPointsOfInterest"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsPointsOfInterest"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsPointsOfInterest:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsPointsOfInterest:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsPointsOfInterest:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ShowsScale {
			[Export ("showsScale")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsScale"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsScale"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsScale:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsScale:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsScale:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ShowsTraffic {
			[Export ("showsTraffic")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsTraffic"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsTraffic"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsTraffic:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsTraffic:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsTraffic:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsUserLocation {
			[Export ("showsUserLocation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsUserLocation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsUserLocation"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsUserLocation:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsUserLocation:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsUserLocation:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		public virtual bool ShowsUserTrackingButton {
			[Export ("showsUserTrackingButton")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsUserTrackingButton"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsUserTrackingButton"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsUserTrackingButton:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsUserTrackingButton:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsUserTrackingButton:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKUserLocation UserLocation {
			[Export ("userLocation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKUserLocation? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MKUserLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userLocation")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MKUserLocation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("userLocation")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns if the user's location is currently visible on the map.</summary><value></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserLocationVisible {
			[Export ("isUserLocationVisible")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUserLocationVisible"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isUserLocationVisible"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual MKUserTrackingMode UserTrackingMode {
			[Export ("userTrackingMode")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKUserTrackingMode ret;
				if (IsDirectBinding) {
					ret = (MKUserTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userTrackingMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MKUserTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("userTrackingMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserTrackingMode:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setUserTrackingMode:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setUserTrackingMode:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MKMapRect VisibleMapRect {
			[Export ("visibleMapRect")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				MKMapRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend (this.Handle, Selector.GetHandle ("visibleMapRect"));
					} else {
						ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("visibleMapRect"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("visibleMapRect"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MKMapRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("visibleMapRect"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setVisibleMapRect:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MKMapRect (this.Handle, Selector.GetHandle ("setVisibleMapRect:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MKMapRect (&__objc_super__, Selector.GetHandle ("setVisibleMapRect:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				UIApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		/// <summary>Controls if the user can zoom in and out of the map using a pinch gesture.</summary><value>Default is <see langword="true" />.</value><remarks>The default value of <see langword="true" /> allows zooming. This property only controls if the user can interactively zoom. It has no affect on zooming the map in code, which can be done by changing either the <see cref="P:MapKit.MKMapView.Region" /> or <see cref="P:MapKit.MKMapView.VisibleMapRect" /> properties.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ZoomEnabled {
			[Export ("isZoomEnabled")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZoomEnabled"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isZoomEnabled"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setZoomEnabled:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setZoomEnabled:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setZoomEnabled:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_MKMapViewDelegate); }
		}
		internal virtual _MKMapViewDelegate CreateInternalEventDelegateType ()
		{
			return (_MKMapViewDelegate)(new _MKMapViewDelegate());
		}
		internal _MKMapViewDelegate EnsureMKMapViewDelegate ()
		{
			if (WeakDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _MKMapViewDelegate;
			if (del is null){
				del = (_MKMapViewDelegate)CreateInternalEventDelegateType ();
				Delegate = (IMKMapViewDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _MKMapViewDelegate : NSObject, IMKMapViewDelegate { 
			public _MKMapViewDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_MKMapViewDelegate))]
			static _MKMapViewDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<MKMapViewAccessoryTappedEventArgs>? calloutAccessoryControlTapped;
			[Export ("mapView:annotationView:calloutAccessoryControlTapped:")]
			public void CalloutAccessoryControlTapped (MKMapView mapView, MKAnnotationView view, UIControl control)
			{
				var handler = calloutAccessoryControlTapped;
				if (handler is not null){
					var args = new MKMapViewAccessoryTappedEventArgs (view, control);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKMapViewDragStateEventArgs>? changedDragState;
			[Export ("mapView:annotationView:didChangeDragState:fromOldState:")]
			public void ChangedDragState (MKMapView mapView, MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
			{
				var handler = changedDragState;
				if (handler is not null){
					var args = new MKMapViewDragStateEventArgs (annotationView, newState, oldState);
					handler (mapView, args);
				}
			}
			internal MKCreateClusterAnnotation? createClusterAnnotation;
			[Export ("mapView:clusterAnnotationForMemberAnnotations:")]
			public MKClusterAnnotation CreateClusterAnnotation (MKMapView mapView, IMKAnnotation[] memberAnnotations)
			{
				var handler = createClusterAnnotation;
				if (handler is not null)
					return handler (mapView, memberAnnotations);
				return null!;
			}
			internal EventHandler<MKMapViewAnnotationEventArgs>? didAddAnnotationViews;
			[Export ("mapView:didAddAnnotationViews:")]
			public void DidAddAnnotationViews (MKMapView mapView, MKAnnotationView[] views)
			{
				var handler = didAddAnnotationViews;
				if (handler is not null){
					var args = new MKMapViewAnnotationEventArgs (views);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKDidAddOverlayRenderersEventArgs>? didAddOverlayRenderers;
			[Export ("mapView:didAddOverlayRenderers:")]
			public void DidAddOverlayRenderers (MKMapView mapView, MKOverlayRenderer[] renderers)
			{
				var handler = didAddOverlayRenderers;
				if (handler is not null){
					var args = new MKDidAddOverlayRenderersEventArgs (renderers);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKOverlayViewsEventArgs>? didAddOverlayViews;
			[Export ("mapView:didAddOverlayViews:")]
			public void DidAddOverlayViews (MKMapView mapView, MKOverlayView overlayViews)
			{
				var handler = didAddOverlayViews;
				if (handler is not null){
					var args = new MKOverlayViewsEventArgs (overlayViews);
					handler (mapView, args);
				}
			}
			internal EventHandler<MMapViewUserTrackingEventArgs>? didChangeUserTrackingMode;
			[Export ("mapView:didChangeUserTrackingMode:animated:")]
			public void DidChangeUserTrackingMode (MKMapView mapView, MKUserTrackingMode mode, bool animated)
			{
				var handler = didChangeUserTrackingMode;
				if (handler is not null){
					var args = new MMapViewUserTrackingEventArgs (mode, animated);
					handler (mapView, args);
				}
			}
			internal EventHandler? didChangeVisibleRegion;
			[Export ("mapViewDidChangeVisibleRegion:")]
			public void DidChangeVisibleRegion (MKMapView mapView)
			{
				var handler = didChangeVisibleRegion;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal EventHandler<MKAnnotationEventArgs>? didDeselectAnnotation;
			[Export ("mapView:didDeselectAnnotation:")]
			public void DidDeselectAnnotation (MKMapView mapView, IMKAnnotation annotation)
			{
				var handler = didDeselectAnnotation;
				if (handler is not null){
					var args = new MKAnnotationEventArgs (annotation);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKAnnotationViewEventArgs>? didDeselectAnnotationView;
			[Export ("mapView:didDeselectAnnotationView:")]
			public void DidDeselectAnnotationView (MKMapView mapView, MKAnnotationView view)
			{
				var handler = didDeselectAnnotationView;
				if (handler is not null){
					var args = new MKAnnotationViewEventArgs (view);
					handler (mapView, args);
				}
			}
			internal EventHandler<NSErrorEventArgs>? didFailToLocateUser;
			[Export ("mapView:didFailToLocateUserWithError:")]
			public void DidFailToLocateUser (MKMapView mapView, NSError error)
			{
				var handler = didFailToLocateUser;
				if (handler is not null){
					var args = new NSErrorEventArgs (error);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKDidFinishRenderingMapEventArgs>? didFinishRenderingMap;
			[Export ("mapViewDidFinishRenderingMap:fullyRendered:")]
			public void DidFinishRenderingMap (MKMapView mapView, bool fullyRendered)
			{
				var handler = didFinishRenderingMap;
				if (handler is not null){
					var args = new MKDidFinishRenderingMapEventArgs (fullyRendered);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKAnnotationEventArgs>? didSelectAnnotation;
			[Export ("mapView:didSelectAnnotation:")]
			public void DidSelectAnnotation (MKMapView mapView, IMKAnnotation annotation)
			{
				var handler = didSelectAnnotation;
				if (handler is not null){
					var args = new MKAnnotationEventArgs (annotation);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKAnnotationViewEventArgs>? didSelectAnnotationView;
			[Export ("mapView:didSelectAnnotationView:")]
			public void DidSelectAnnotationView (MKMapView mapView, MKAnnotationView view)
			{
				var handler = didSelectAnnotationView;
				if (handler is not null){
					var args = new MKAnnotationViewEventArgs (view);
					handler (mapView, args);
				}
			}
			internal EventHandler? didStopLocatingUser;
			[Export ("mapViewDidStopLocatingUser:")]
			public void DidStopLocatingUser (MKMapView mapView)
			{
				var handler = didStopLocatingUser;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal EventHandler<MKUserLocationEventArgs>? didUpdateUserLocation;
			[Export ("mapView:didUpdateUserLocation:")]
			public void DidUpdateUserLocation (MKMapView mapView, MKUserLocation userLocation)
			{
				var handler = didUpdateUserLocation;
				if (handler is not null){
					var args = new MKUserLocationEventArgs (userLocation);
					handler (mapView, args);
				}
			}
			internal MKMapViewDelegateGetSelectionAccessory? getSelectionAccessory;
			[Export ("mapView:selectionAccessoryForAnnotation:")]
			public MKSelectionAccessory? GetSelectionAccessory (MKMapView mapView, IMKAnnotation annotation)
			{
				var handler = getSelectionAccessory;
				if (handler is not null)
					return handler (mapView, annotation);
				return null!;
			}
			internal MKMapViewAnnotation? getViewForAnnotation;
			[Export ("mapView:viewForAnnotation:")]
			public MKAnnotationView? GetViewForAnnotation (MKMapView mapView, IMKAnnotation annotation)
			{
				var handler = getViewForAnnotation;
				if (handler is not null)
					return handler (mapView, annotation);
				return null!;
			}
			internal MKMapViewOverlay? getViewForOverlay;
			[Export ("mapView:viewForOverlay:")]
			public MKOverlayView GetViewForOverlay (MKMapView mapView, IMKOverlay overlay)
			{
				var handler = getViewForOverlay;
				if (handler is not null)
					return handler (mapView, overlay);
				return null!;
			}
			internal EventHandler<NSErrorEventArgs>? loadingMapFailed;
			[Export ("mapViewDidFailLoadingMap:withError:")]
			public void LoadingMapFailed (MKMapView mapView, NSError error)
			{
				var handler = loadingMapFailed;
				if (handler is not null){
					var args = new NSErrorEventArgs (error);
					handler (mapView, args);
				}
			}
			internal EventHandler? mapLoaded;
			[Export ("mapViewDidFinishLoadingMap:")]
			public void MapLoaded (MKMapView mapView)
			{
				var handler = mapLoaded;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal MKRendererForOverlayDelegate? overlayRenderer;
			[Export ("mapView:rendererForOverlay:")]
			public MKOverlayRenderer OverlayRenderer (MKMapView mapView, IMKOverlay overlay)
			{
				var handler = overlayRenderer;
				if (handler is not null)
					return handler (mapView, overlay);
				return null!;
			}
			internal EventHandler<MKMapViewChangeEventArgs>? regionChanged;
			[Export ("mapView:regionDidChangeAnimated:")]
			public void RegionChanged (MKMapView mapView, bool animated)
			{
				var handler = regionChanged;
				if (handler is not null){
					var args = new MKMapViewChangeEventArgs (animated);
					handler (mapView, args);
				}
			}
			internal EventHandler<MKMapViewChangeEventArgs>? regionWillChange;
			[Export ("mapView:regionWillChangeAnimated:")]
			public void RegionWillChange (MKMapView mapView, bool animated)
			{
				var handler = regionWillChange;
				if (handler is not null){
					var args = new MKMapViewChangeEventArgs (animated);
					handler (mapView, args);
				}
			}
			internal EventHandler? willStartLoadingMap;
			[Export ("mapViewWillStartLoadingMap:")]
			public void WillStartLoadingMap (MKMapView mapView)
			{
				var handler = willStartLoadingMap;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal EventHandler? willStartLocatingUser;
			[Export ("mapViewWillStartLocatingUser:")]
			public void WillStartLocatingUser (MKMapView mapView)
			{
				var handler = willStartLocatingUser;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
			internal EventHandler? willStartRenderingMap;
			[Export ("mapViewWillStartRenderingMap:")]
			public void WillStartRenderingMap (MKMapView mapView)
			{
				var handler = willStartRenderingMap;
				if (handler is not null){
					handler (mapView, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKMapViewAccessoryTappedEventArgs> CalloutAccessoryControlTapped {
			add { EnsureMKMapViewDelegate ()!.calloutAccessoryControlTapped += value; }
			remove { EnsureMKMapViewDelegate ()!.calloutAccessoryControlTapped -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKMapViewDragStateEventArgs> ChangedDragState {
			add { EnsureMKMapViewDelegate ()!.changedDragState += value; }
			remove { EnsureMKMapViewDelegate ()!.changedDragState -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public MKCreateClusterAnnotation? CreateClusterAnnotation {
			get { return EnsureMKMapViewDelegate ()!.createClusterAnnotation; }
			set { EnsureMKMapViewDelegate ()!.createClusterAnnotation = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKMapViewAnnotationEventArgs> DidAddAnnotationViews {
			add { EnsureMKMapViewDelegate ()!.didAddAnnotationViews += value; }
			remove { EnsureMKMapViewDelegate ()!.didAddAnnotationViews -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKDidAddOverlayRenderersEventArgs> DidAddOverlayRenderers {
			add { EnsureMKMapViewDelegate ()!.didAddOverlayRenderers += value; }
			remove { EnsureMKMapViewDelegate ()!.didAddOverlayRenderers -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKOverlayViewsEventArgs> DidAddOverlayViews {
			add { EnsureMKMapViewDelegate ()!.didAddOverlayViews += value; }
			remove { EnsureMKMapViewDelegate ()!.didAddOverlayViews -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MMapViewUserTrackingEventArgs> DidChangeUserTrackingMode {
			add { EnsureMKMapViewDelegate ()!.didChangeUserTrackingMode += value; }
			remove { EnsureMKMapViewDelegate ()!.didChangeUserTrackingMode -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler DidChangeVisibleRegion {
			add { EnsureMKMapViewDelegate ()!.didChangeVisibleRegion += value; }
			remove { EnsureMKMapViewDelegate ()!.didChangeVisibleRegion -= value; }
		}
		public event EventHandler<MKAnnotationEventArgs> DidDeselectAnnotation {
			add { EnsureMKMapViewDelegate ()!.didDeselectAnnotation += value; }
			remove { EnsureMKMapViewDelegate ()!.didDeselectAnnotation -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKAnnotationViewEventArgs> DidDeselectAnnotationView {
			add { EnsureMKMapViewDelegate ()!.didDeselectAnnotationView += value; }
			remove { EnsureMKMapViewDelegate ()!.didDeselectAnnotationView -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<NSErrorEventArgs> DidFailToLocateUser {
			add { EnsureMKMapViewDelegate ()!.didFailToLocateUser += value; }
			remove { EnsureMKMapViewDelegate ()!.didFailToLocateUser -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKDidFinishRenderingMapEventArgs> DidFinishRenderingMap {
			add { EnsureMKMapViewDelegate ()!.didFinishRenderingMap += value; }
			remove { EnsureMKMapViewDelegate ()!.didFinishRenderingMap -= value; }
		}
		public event EventHandler<MKAnnotationEventArgs> DidSelectAnnotation {
			add { EnsureMKMapViewDelegate ()!.didSelectAnnotation += value; }
			remove { EnsureMKMapViewDelegate ()!.didSelectAnnotation -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKAnnotationViewEventArgs> DidSelectAnnotationView {
			add { EnsureMKMapViewDelegate ()!.didSelectAnnotationView += value; }
			remove { EnsureMKMapViewDelegate ()!.didSelectAnnotationView -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidStopLocatingUser {
			add { EnsureMKMapViewDelegate ()!.didStopLocatingUser += value; }
			remove { EnsureMKMapViewDelegate ()!.didStopLocatingUser -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKUserLocationEventArgs> DidUpdateUserLocation {
			add { EnsureMKMapViewDelegate ()!.didUpdateUserLocation += value; }
			remove { EnsureMKMapViewDelegate ()!.didUpdateUserLocation -= value; }
		}
		public MKMapViewDelegateGetSelectionAccessory? GetSelectionAccessory {
			get { return EnsureMKMapViewDelegate ()!.getSelectionAccessory; }
			set { EnsureMKMapViewDelegate ()!.getSelectionAccessory = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public MKMapViewAnnotation? GetViewForAnnotation {
			get { return EnsureMKMapViewDelegate ()!.getViewForAnnotation; }
			set { EnsureMKMapViewDelegate ()!.getViewForAnnotation = value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public MKMapViewOverlay? GetViewForOverlay {
			get { return EnsureMKMapViewDelegate ()!.getViewForOverlay; }
			set { EnsureMKMapViewDelegate ()!.getViewForOverlay = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<NSErrorEventArgs> LoadingMapFailed {
			add { EnsureMKMapViewDelegate ()!.loadingMapFailed += value; }
			remove { EnsureMKMapViewDelegate ()!.loadingMapFailed -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler MapLoaded {
			add { EnsureMKMapViewDelegate ()!.mapLoaded += value; }
			remove { EnsureMKMapViewDelegate ()!.mapLoaded -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public MKRendererForOverlayDelegate? OverlayRenderer {
			get { return EnsureMKMapViewDelegate ()!.overlayRenderer; }
			set { EnsureMKMapViewDelegate ()!.overlayRenderer = value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKMapViewChangeEventArgs> RegionChanged {
			add { EnsureMKMapViewDelegate ()!.regionChanged += value; }
			remove { EnsureMKMapViewDelegate ()!.regionChanged -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<MKMapViewChangeEventArgs> RegionWillChange {
			add { EnsureMKMapViewDelegate ()!.regionWillChange += value; }
			remove { EnsureMKMapViewDelegate ()!.regionWillChange -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillStartLoadingMap {
			add { EnsureMKMapViewDelegate ()!.willStartLoadingMap += value; }
			remove { EnsureMKMapViewDelegate ()!.willStartLoadingMap -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillStartLocatingUser {
			add { EnsureMKMapViewDelegate ()!.willStartLocatingUser += value; }
			remove { EnsureMKMapViewDelegate ()!.willStartLocatingUser -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WillStartRenderingMap {
			add { EnsureMKMapViewDelegate ()!.willStartRenderingMap += value; }
			remove { EnsureMKMapViewDelegate ()!.willStartRenderingMap -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::MapKit.MKMapView" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::MapKit.MKMapView" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::MapKit.MKMapView.Appearance" /> property or by calling <see cref="global::MapKit.MKMapView.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class MKMapViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal MKMapViewAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::MapKit.MKMapView" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MapKit.MKMapView" />, they should use the <see cref="global::MapKit.MKMapView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new MKMapViewAppearance Appearance {
			get { return new MKMapViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKMapView.MKMapViewAppearance" /> for the subclass of <see cref="global::MapKit.MKMapView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::MapKit.MKMapView" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::MapKit.MKMapView.Appearance" /> property, or the <see cref="global::MapKit.MKMapView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = MKMapView.GetAppearance<MyMKMapViewSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKMapViewAppearance GetAppearance<T> () where T: MKMapView {
			return new MKMapViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::MapKit.MKMapView" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MapKit.MKMapView" />, they should use the <see cref="global::MapKit.MKMapView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKMapViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MKMapViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKMapView.MKMapViewAppearance" /> for <see cref="global::MapKit.MKMapView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MKMapView.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MapKit.MKMapView" />, they should use the <see cref="global::MapKit.MKMapView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKMapViewAppearance GetAppearance (UITraitCollection traits) {
			return new MKMapViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKMapView.MKMapViewAppearance" /> for <see cref="global::MapKit.MKMapView" />.</summary>
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
		///var myTheme = MKMapView.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MapKit.MKMapView" />, they should use the <see cref="global::MapKit.MKMapView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKMapViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MKMapViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKMapView.MKMapViewAppearance" /> for the subclass of <see cref="global::MapKit.MKMapView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::MapKit.MKMapView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::MapKit.MKMapView.Appearance" /> property, or the <see cref="global::MapKit.MKMapView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MKMapView.GetAppearance<MyMKMapViewSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKMapViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MKMapView {
			return new MKMapViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MapKit.MKMapView.MKMapViewAppearance" /> for the subclass of <see cref="global::MapKit.MKMapView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::MapKit.MKMapView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::MapKit.MKMapView.Appearance" /> property, or the <see cref="global::MapKit.MKMapView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MKMapView.GetAppearance<MyMKMapViewSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MKMapViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MKMapView{
			return new MKMapViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class MKMapView */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKAnnotationEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKAnnotationEventArgs" /> with the specified event data.</summary>
		/// <param name="annotation">The value for the <see cref="Annotation" /> property.</param>
		public MKAnnotationEventArgs (IMKAnnotation annotation)
		{
			this.Annotation = annotation;
		}
		public IMKAnnotation Annotation { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKAnnotationViewEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKAnnotationViewEventArgs" /> with the specified event data.</summary>
		/// <param name="view">The value for the <see cref="View" /> property.</param>
		public MKAnnotationViewEventArgs (MKAnnotationView view)
		{
			this.View = view;
		}
		public MKAnnotationView View { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKDidAddOverlayRenderersEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKDidAddOverlayRenderersEventArgs" /> with the specified event data.</summary>
		/// <param name="renderers">The value for the <see cref="Renderers" /> property.</param>
		public MKDidAddOverlayRenderersEventArgs (MKOverlayRenderer[] renderers)
		{
			this.Renderers = renderers;
		}
		public MKOverlayRenderer[] Renderers { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKDidFinishRenderingMapEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKDidFinishRenderingMapEventArgs" /> with the specified event data.</summary>
		/// <param name="fullyRendered">The value for the <see cref="FullyRendered" /> property.</param>
		public MKDidFinishRenderingMapEventArgs (bool fullyRendered)
		{
			this.FullyRendered = fullyRendered;
		}
		public bool FullyRendered { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKMapViewAccessoryTappedEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKMapViewAccessoryTappedEventArgs" /> with the specified event data.</summary>
		/// <param name="view">The value for the <see cref="View" /> property.</param>
		/// <param name="control">The value for the <see cref="Control" /> property.</param>
		public MKMapViewAccessoryTappedEventArgs (MKAnnotationView view, UIControl control)
		{
			this.Control = control;
			this.View = view;
		}
		public UIControl Control { get; set; }
		public MKAnnotationView View { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKMapViewAnnotationEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKMapViewAnnotationEventArgs" /> with the specified event data.</summary>
		/// <param name="views">The value for the <see cref="Views" /> property.</param>
		public MKMapViewAnnotationEventArgs (MKAnnotationView[] views)
		{
			this.Views = views;
		}
		public MKAnnotationView[] Views { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKMapViewChangeEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKMapViewChangeEventArgs" /> with the specified event data.</summary>
		/// <param name="animated">The value for the <see cref="Animated" /> property.</param>
		public MKMapViewChangeEventArgs (bool animated)
		{
			this.Animated = animated;
		}
		public bool Animated { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKMapViewDragStateEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKMapViewDragStateEventArgs" /> with the specified event data.</summary>
		/// <param name="annotationView">The value for the <see cref="AnnotationView" /> property.</param>
		/// <param name="newState">The value for the <see cref="NewState" /> property.</param>
		/// <param name="oldState">The value for the <see cref="OldState" /> property.</param>
		public MKMapViewDragStateEventArgs (MKAnnotationView annotationView, MKAnnotationViewDragState newState, MKAnnotationViewDragState oldState)
		{
			this.AnnotationView = annotationView;
			this.NewState = newState;
			this.OldState = oldState;
		}
		public MKAnnotationView AnnotationView { get; set; }
		public MKAnnotationViewDragState NewState { get; set; }
		public MKAnnotationViewDragState OldState { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKOverlayViewsEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKOverlayViewsEventArgs" /> with the specified event data.</summary>
		/// <param name="overlayViews">The value for the <see cref="OverlayViews" /> property.</param>
		public MKOverlayViewsEventArgs (MKOverlayView overlayViews)
		{
			this.OverlayViews = overlayViews;
		}
		public MKOverlayView OverlayViews { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MKUserLocationEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MKUserLocationEventArgs" /> with the specified event data.</summary>
		/// <param name="userLocation">The value for the <see cref="UserLocation" /> property.</param>
		public MKUserLocationEventArgs (MKUserLocation userLocation)
		{
			this.UserLocation = userLocation;
		}
		public MKUserLocation UserLocation { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class MMapViewUserTrackingEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="MMapViewUserTrackingEventArgs" /> with the specified event data.</summary>
		/// <param name="mode">The value for the <see cref="Mode" /> property.</param>
		/// <param name="animated">The value for the <see cref="Animated" /> property.</param>
		public MMapViewUserTrackingEventArgs (MKUserTrackingMode mode, bool animated)
		{
			this.Animated = animated;
			this.Mode = mode;
		}
		public bool Animated { get; set; }
		public MKUserTrackingMode Mode { get; set; }
	}
}
