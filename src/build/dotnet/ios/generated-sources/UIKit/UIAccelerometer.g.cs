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
namespace UIKit {
	/// <summary>A class that encapsulates the onboard hardware accelerometer and generates <see cref="T:UIKit.UIAcceleration" /> objects.</summary><remarks><para>The application developer must always use the <see cref="P:UIKit.UIAccelerometer.SharedAccelerometer" /> property to access the onboard accelerometer. Data in the form of <see cref="T:UIKit.UIAcceleration" /> objects can then be read via the <see cref="UIKit.UIAccelerometer.Acceleration" /> event, which will fire every <see cref="P:UIKit.UIAccelerometer.UpdateInterval" /> seconds.</para><para>In the following example, taken from the "GLPaintGameView" sample, the <see cref="P:UIKit.UIAccelerometer.UpdateInterval" /> is set to 1/25th of a second and the <c>OnAcceleration</c> method is assigned to handle acceleration events. In the handler, the <see cref="UIKit.UIAccelerometerEventArgs" /> parameter is used to determine the specifics of acceleration:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //Configure and enable the accelerometer
	/// 			const int AccelerometerFrequency = 25;
	/// 			UIAccelerometer.SharedAccelerometer.UpdateInterval = 1.0f / AccelerometerFrequency;
	/// 			UIAccelerometer.SharedAccelerometer.Acceleration += OnAccelerated;
	/// 
	/// private void OnAccelerated (object sender, UIAccelerometerEventArgs e)
	/// 		{
	/// #if LINQ
	/// 			myAccelerometer = new[]{e.Acceleration.X, e.Acceleration.Y, e.Acceleration.Z}
	/// 				.Select((v, i) => v * FilteringFactor + myAccelerometer [i] * (1.0f - FilteringFactor))
	/// 				.ToArray ();
	/// #else
	/// 			myAccelerometer [0] = e.Acceleration.X * FilteringFactor + myAccelerometer [0] * (1.0 - FilteringFactor);
	/// 			myAccelerometer [1] = e.Acceleration.Y * FilteringFactor + myAccelerometer [1] * (1.0 - FilteringFactor);
	/// 			myAccelerometer [2] = e.Acceleration.Z * FilteringFactor + myAccelerometer [2] * (1.0 - FilteringFactor);
	/// #endif
	/// ... etc ...
	/// }
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIAccelerometer_Class/index.html">Apple documentation for <c>UIAccelerometer</c></related>
	[Register("UIAccelerometer", true)]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios5.0", "Use 'CoreMotion' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CoreMotion' instead.")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIAccelerometer : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIAccelerometer");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIAccelerometer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIAccelerometer () : base (NSObjectFlag.Empty)
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
		protected UIAccelerometer (NSObjectFlag t) : base (t)
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
		protected internal UIAccelerometer (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>An instance of the UIKit.IUIAccelerometerDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.IUIAccelerometerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIAccelerometerDelegate Delegate {
			get {
				return (WeakDelegate as IUIAccelerometerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIAccelerometer SharedAccelerometer {
			[Export ("sharedAccelerometer")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIAccelerometer? ret;
				ret =  Runtime.GetNSObject<UIAccelerometer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sharedAccelerometer")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double UpdateInterval {
			[Export ("updateInterval")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("updateInterval"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateInterval"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setUpdateInterval:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setUpdateInterval:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setUpdateInterval:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
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
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
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
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_UIAccelerometerDelegate); }
		}
		internal virtual _UIAccelerometerDelegate CreateInternalEventDelegateType ()
		{
			return (_UIAccelerometerDelegate)(new _UIAccelerometerDelegate());
		}
		internal _UIAccelerometerDelegate EnsureUIAccelerometerDelegate ()
		{
			if (WeakDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _UIAccelerometerDelegate;
			if (del is null){
				del = (_UIAccelerometerDelegate)CreateInternalEventDelegateType ();
				Delegate = (IUIAccelerometerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _UIAccelerometerDelegate : NSObject, IUIAccelerometerDelegate { 
			public _UIAccelerometerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_UIAccelerometerDelegate))]
			static _UIAccelerometerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<UIAccelerometerEventArgs>? didAccelerate;
			[Export ("accelerometer:didAccelerate:")]
			public void DidAccelerate (UIAccelerometer accelerometer, UIAcceleration acceleration)
			{
				var handler = didAccelerate;
				if (handler is not null){
					var args = new UIAccelerometerEventArgs (acceleration);
					handler (accelerometer, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>This event is raised when a new acceleration event is ready.</summary>
		/// <remarks>Use this event if you want to subscribe to notifications without having to create a UIAccelerometerDelegate class.</remarks>
		public event EventHandler<UIAccelerometerEventArgs> Acceleration {
			add { EnsureUIAccelerometerDelegate ()!.didAccelerate += value; }
			remove { EnsureUIAccelerometerDelegate ()!.didAccelerate -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class UIAccelerometer */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class UIAccelerometerEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="UIAccelerometerEventArgs" /> with the specified event data.</summary>
		/// <param name="acceleration">The value for the <see cref="Acceleration" /> property.</param>
		public UIAccelerometerEventArgs (UIAcceleration acceleration)
		{
			this.Acceleration = acceleration;
		}
		public UIAcceleration Acceleration { get; set; }
	}
}
