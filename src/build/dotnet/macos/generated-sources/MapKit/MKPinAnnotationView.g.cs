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
	[Register("MKPinAnnotationView", true)]
	[ObsoletedOSPlatform ("macos13.0", "Use MKMarkerAnnotationView instead.")]
	[ObsoletedOSPlatform ("ios16.0", "Use MKMarkerAnnotationView instead.")]
	[ObsoletedOSPlatform ("maccatalyst16.0", "Use MKMarkerAnnotationView instead.")]
	[ObsoletedOSPlatform ("tvos16.0", "Use MKMarkerAnnotationView instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MKPinAnnotationView : MKAnnotationView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimatesDropX = "animatesDrop";
		static readonly NativeHandle selAnimatesDropXHandle = Selector.GetHandle ("animatesDrop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGreenPinColorX = "greenPinColor";
		static readonly NativeHandle selGreenPinColorXHandle = Selector.GetHandle ("greenPinColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAnnotation_ReuseIdentifier_X = "initWithAnnotation:reuseIdentifier:";
		static readonly NativeHandle selInitWithAnnotation_ReuseIdentifier_XHandle = Selector.GetHandle ("initWithAnnotation:reuseIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPinColorX = "pinColor";
		static readonly NativeHandle selPinColorXHandle = Selector.GetHandle ("pinColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPinTintColorX = "pinTintColor";
		static readonly NativeHandle selPinTintColorXHandle = Selector.GetHandle ("pinTintColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPurplePinColorX = "purplePinColor";
		static readonly NativeHandle selPurplePinColorXHandle = Selector.GetHandle ("purplePinColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRedPinColorX = "redPinColor";
		static readonly NativeHandle selRedPinColorXHandle = Selector.GetHandle ("redPinColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnimatesDrop_X = "setAnimatesDrop:";
		static readonly NativeHandle selSetAnimatesDrop_XHandle = Selector.GetHandle ("setAnimatesDrop:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPinColor_X = "setPinColor:";
		static readonly NativeHandle selSetPinColor_XHandle = Selector.GetHandle ("setPinColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPinTintColor_X = "setPinTintColor:";
		static readonly NativeHandle selSetPinTintColor_XHandle = Selector.GetHandle ("setPinTintColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MKPinAnnotationView");
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
		public MKPinAnnotationView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MKPinAnnotationView (NSObjectFlag t) : base (t)
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
		protected internal MKPinAnnotationView (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="frame">Frame used by the view, expressed in iOS points.</param><summary>Initializes the MKPinAnnotationView with the specified frame.</summary><remarks><para>This constructor is used to programmatically create a new instance of MKPinAnnotationView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para><para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para></remarks>
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKPinAnnotationView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithAnnotation:reuseIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKPinAnnotationView (IMKAnnotation? annotation, string? reuseIdentifier)
			: base (NSObjectFlag.Empty)
		{
			var annotation__handle__ = annotation.GetHandle ();
			var nsreuseIdentifier = CFString.CreateNative (reuseIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithAnnotation_ReuseIdentifier_XHandle, annotation__handle__, nsreuseIdentifier), "initWithAnnotation:reuseIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithAnnotation_ReuseIdentifier_XHandle, annotation__handle__, nsreuseIdentifier), "initWithAnnotation:reuseIdentifier:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (annotation);
			CFString.ReleaseNative (nsreuseIdentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AnimatesDrop {
			[Export ("animatesDrop")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAnimatesDropXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAnimatesDropXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAnimatesDrop:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAnimatesDrop_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAnimatesDrop_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos13.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("ios16.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("tvos16.0", "Use MKMarkerAnnotationView instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static global::AppKit.NSColor GreenPinColor {
			[Export ("greenPinColor")]
			get {
				global::AppKit.NSColor? ret;
				ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selGreenPinColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'PinTintColor' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'PinTintColor' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PinTintColor' instead.")]
		[ObsoletedOSPlatform ("tvos16.0", "Use MKMarkerAnnotationView instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual MKPinAnnotationColor PinColor {
			[Export ("pinColor")]
			get {
				MKPinAnnotationColor ret;
				if (IsDirectBinding) {
					ret = (MapKit.MKPinAnnotationColor) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPinColorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MapKit.MKPinAnnotationColor) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPinColorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPinColor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPinColor_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPinColor_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos13.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("ios16.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("tvos16.0", "Use MKMarkerAnnotationView instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::AppKit.NSColor? PinTintColor {
			[Export ("pinTintColor")]
			get {
				global::AppKit.NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPinTintColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPinTintColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPinTintColor:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPinTintColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPinTintColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos13.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("ios16.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("tvos16.0", "Use MKMarkerAnnotationView instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static global::AppKit.NSColor PurplePinColor {
			[Export ("purplePinColor")]
			get {
				global::AppKit.NSColor? ret;
				ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPurplePinColorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos13.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("ios16.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("maccatalyst16.0", "Use MKMarkerAnnotationView instead.")]
		[ObsoletedOSPlatform ("tvos16.0", "Use MKMarkerAnnotationView instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static global::AppKit.NSColor RedPinColor {
			[Export ("redPinColor")]
			get {
				global::AppKit.NSColor? ret;
				ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRedPinColorXHandle), false)!;
				return ret!;
			}
		}
	} /* class MKPinAnnotationView */
}
