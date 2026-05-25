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
namespace CoreAnimation {
	/// <summary>Synchronization object between your animations and the display refresh.</summary><remarks><para>
	/// 	The display link object is a timer that can be used to
	/// 	synchronize your drawing with the screen refresh rate.  Once
	/// 	you create your CADisplayLink, you need to add it to a runloop
	/// 	by using the <see cref="M:CoreAnimation.CADisplayLink.AddToRunLoop(Foundation.NSRunLoop,Foundation.NSString)" />
	/// 	method.
	/// 
	/// </para><para>
	/// 	Using the display link ensures that your application will not
	/// 	suffer from display glitches like screen tearing and micro-stuttering. 
	/// </para><para>
	/// 	You can pause the display link by setting the <see cref="P:CoreAnimation.CADisplayLink.Paused" />
	/// 	property.  And you can remove your display link from any
	/// 	registered run loops by calling the <see cref="M:CoreAnimation.CADisplayLink.Invalidate" />
	/// 	method.
	/// 
	/// </para><para>
	/// 	By default the timer is triggered sixty times per second.  If
	/// 	your application does not need this level of precision, set
	/// 	the FrameInterval property to skip one or more updates.  For
	/// 	example, setting FrameInterval to two, would invoke your
	/// 	target method thirty times per second.
	/// 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// GLKView myGlView;
	/// 
	/// void Setup ()
	/// {
	/// CADisplayLink displayLink = CADisplayLink.Create (Display);
	/// displayLink.AddToRunLoop (NSRunLoop.Main, NSRunLoop.UITrackingRunLoopMode); 
	/// }
	/// 
	/// void Display ()
	/// {
	/// myGLView.Display ();
	/// }
	/// 
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/QuartzCore/Reference/CADisplayLink_ClassRef/index.html">Apple documentation for <c>CADisplayLink</c></related>
	[Register("CADisplayLink", true)]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CADisplayLink : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CADisplayLink");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CADisplayLink" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CADisplayLink () : base (NSObjectFlag.Empty)
		{
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
		protected CADisplayLink (NSObjectFlag t) : base (t)
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
		protected internal CADisplayLink (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="runloop">The runloop on which to run.</param><param name="mode">Modes in which the timer will be invoked, one of the various NSString constants in <see cref="T:Foundation.NSRunLoop" />.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Trigger timer events on the specified runloop for the specified modes (weakly typed parameters).</summary><remarks><para>You should use the strongly typed version if possible, as it prevents common errors.</para><para>
		/// 	    The mode parameter will determine when the event is sent.
		/// 	    The NSRunLoop.NSDefaultRunLoopMode is not delivered during
		/// 	    UI tracking events (like scrolling in a UIScrollbar).  For
		/// 	    getting those kinds of events use
		/// 	    NSRunLoop.UITrackingRunLoopMode.  Or use
		/// 	    NSRunLoop.NSRunLoopCommonModes which covers both cases.
		/// 
		/// 	  </para></remarks>
		[Export ("addToRunLoop:forMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddToRunLoop (NSRunLoop runloop, NSString mode)
		{
			var runloop__handle__ = runloop!.GetNonNullHandle (nameof (runloop));
			var mode__handle__ = mode!.GetNonNullHandle (nameof (mode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addToRunLoop:forMode:"), runloop__handle__, mode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("addToRunLoop:forMode:"), runloop__handle__, mode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (runloop);
			GC.KeepAlive (mode);
		}
		/// <param name="runloop">The runloop on which to run.</param><param name="mode">Modes in which the timer will be invoked.</param><summary>Trigger timer events on the specified runloop for the specified modes.</summary><remarks><para>The mode parameter will determine when the event is sent. The NSRunLoop.NSDefaultRunLoopMode is not delivered during UI tracking events (like scrolling in a UIScrollbar). For getting those kinds of events use NSRunLoop.UITrackingRunLoopMode. Or use NSRunLoop.NSRunLoopCommonModes which covers both cases.  	  </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddToRunLoop (NSRunLoop runloop, NSRunLoopMode mode)
		{
			AddToRunLoop (runloop, mode.GetConstant ()!);
		}
		/// <param name="target">Target object to invoke the selector on.</param><param name="sel">Selector to invoke.</param><summary>Objective-C style registration of the method to be invoked every time the display is about to be updated.</summary><returns>The DisplayLink object that will invoke the specified method on each screen update.</returns><remarks><para>
		/// 	    With C# you can use the Create overload that takes a NSAction as it can be used with lambdas.
		/// 	  </para><para>
		/// 	    Once you create the display link, you must add the handler to the runloop.
		/// 	  </para></remarks>
		[Export ("displayLinkWithTarget:selector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CADisplayLink Create (NSObject target, Selector sel)
		{
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var sel__handle__ = sel!.GetNonNullHandle (nameof (sel));
			CADisplayLink? ret;
			ret =  Runtime.GetNSObject<CADisplayLink> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("displayLinkWithTarget:selector:"), target__handle__, sel.Handle), false)!;
			GC.KeepAlive (target);
			GC.KeepAlive (sel);
			return ret!;
		}
		/// <summary>Terminates the connection between CoreAnimation and your code.     This removes the CADisplayLink from all run loops.</summary><remarks>To be added.</remarks>
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invalidate ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("invalidate"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="runloop">The run loop from which to remove the display link.</param><param name="mode"><para>The mode of the run loop.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Removes the display link from the provided run loop when in the specified mode.</summary><remarks>To be added.</remarks>
		[Export ("removeFromRunLoop:forMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveFromRunLoop (NSRunLoop runloop, NSString mode)
		{
			var runloop__handle__ = runloop!.GetNonNullHandle (nameof (runloop));
			var mode__handle__ = mode!.GetNonNullHandle (nameof (mode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("removeFromRunLoop:forMode:"), runloop__handle__, mode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("removeFromRunLoop:forMode:"), runloop__handle__, mode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (runloop);
			GC.KeepAlive (mode);
		}
		/// <param name="runloop">The run loop from which to remove the display link.</param><param name="mode">The mode of the run loop.</param><summary>Removes the display link from the provided run loop when in the specified mode.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveFromRunLoop (NSRunLoop runloop, NSRunLoopMode mode)
		{
			RemoveFromRunLoop (runloop, mode.GetConstant ()!);
		}
		/// <summary>The time between screen refreshes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Duration {
			[Export ("duration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("duration"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("duration"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Developers should not use this deprecated property. Developers should use 'PreferredFramesPerSecond' property.</summary><value>To be added.</value><remarks><para>
		/// 	    The default value is one, which means that your code is
		/// 	    invoked once each time that a screen refresh will take
		/// 	    place.  If you set this value to two, then your method will
		/// 	    only be invoked half the time (once every two frames) and so
		/// 	    on.
		/// 	  </para><para>
		/// 	    In general, you should not skip frames.  If your software
		/// 	    can not keep up with the frame rate, it is better to
		/// 	    increase the frame interval and deliver a consistent set
		/// 	    of updates.
		/// 	  </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios10.0", "Use 'PreferredFramesPerSecond' property.")]
		[UnsupportedOSPlatform ("tvos10.0", "Use 'PreferredFramesPerSecond' property.")]
		[UnsupportedOSPlatform ("maccatalyst13.1", "Use 'PreferredFramesPerSecond' property.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nint FrameInterval {
			[Export ("frameInterval")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("frameInterval"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("frameInterval"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFrameInterval:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFrameInterval:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setFrameInterval:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the notifications between the animation loop and your code are suspended.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Paused {
			[Export ("isPaused")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPaused"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isPaused"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPaused:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPaused:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setPaused:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos14.0")]
		public virtual CAFrameRateRange PreferredFrameRateRange {
			[Export ("preferredFrameRateRange", ArgumentSemantic.Assign)]
			get {
				CAFrameRateRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CAFrameRateRange_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFrameRateRange"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CAFrameRateRange_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFrameRateRange"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredFrameRateRange:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CAFrameRateRange (this.Handle, Selector.GetHandle ("setPreferredFrameRateRange:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CAFrameRateRange (&__objc_super__, Selector.GetHandle ("setPreferredFrameRateRange:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the preferred display rate.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios15.0", "Use 'PreferredFrameRateRange' property.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'PreferredFrameRateRange' property.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'PreferredFrameRateRange' property.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual nint PreferredFramesPerSecond {
			[Export ("preferredFramesPerSecond")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFramesPerSecond"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFramesPerSecond"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPreferredFramesPerSecond:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPreferredFramesPerSecond:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setPreferredFramesPerSecond:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the time stamp for the desired time to start displaying the target of the display link.</summary><value>The time stamp for the desired time to start displaying the target of the display link.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("tvos")]
		public virtual double TargetTimestamp {
			[Export ("targetTimestamp")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("targetTimestamp"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("targetTimestamp"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Timestamp for the last frame displayed.</summary><value></value><remarks><para>Developers can this value to compute which date should be displayed next.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Timestamp {
			[Export ("timestamp")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("timestamp"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("timestamp"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class CADisplayLink */
}
