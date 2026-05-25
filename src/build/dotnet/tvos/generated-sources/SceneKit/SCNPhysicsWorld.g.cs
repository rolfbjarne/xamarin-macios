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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace SceneKit {
	/// <summary>A physics simulation that models collisions and other physics-related properties in an SCNScene.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNPhysicsWorld_Class/index.html">Apple documentation for <c>SCNPhysicsWorld</c></related>
	[Register("SCNPhysicsWorld", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNPhysicsWorld : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCNPhysicsWorld");
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
		public SCNPhysicsWorld (NSCoder coder) : base (NSObjectFlag.Empty)
		{
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
		protected SCNPhysicsWorld (NSObjectFlag t) : base (t)
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
		protected internal SCNPhysicsWorld (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddBehavior (SCNPhysicsBehavior behavior)
		{
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addBehavior:"), behavior__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addBehavior:"), behavior__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (behavior);
		}
		[Export ("contactTestBetweenBody:andBody:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNPhysicsContact[] ContactTest (SCNPhysicsBody bodyA, SCNPhysicsBody bodyB, NSDictionary? options)
		{
			var bodyA__handle__ = bodyA!.GetNonNullHandle (nameof (bodyA));
			var bodyB__handle__ = bodyB!.GetNonNullHandle (nameof (bodyB));
			var options__handle__ = options.GetHandle ();
			SCNPhysicsContact[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SCNPhysicsContact>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("contactTestBetweenBody:andBody:options:"), bodyA__handle__, bodyB__handle__, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SCNPhysicsContact>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("contactTestBetweenBody:andBody:options:"), bodyA__handle__, bodyB__handle__, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bodyA);
			GC.KeepAlive (bodyB);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="bodyA">To be added.</param><param name="bodyB">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNPhysicsContact[] ContactTest (SCNPhysicsBody bodyA, SCNPhysicsBody bodyB, SCNPhysicsTest? options)
		{
			return ContactTest (bodyA, bodyB, options.GetDictionary ());
		}
		[Export ("contactTestWithBody:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNPhysicsContact[] ContactTest (SCNPhysicsBody body, NSDictionary? options)
		{
			var body__handle__ = body!.GetNonNullHandle (nameof (body));
			var options__handle__ = options.GetHandle ();
			SCNPhysicsContact[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SCNPhysicsContact>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("contactTestWithBody:options:"), body__handle__, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SCNPhysicsContact>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("contactTestWithBody:options:"), body__handle__, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (body);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="body">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNPhysicsContact[] ContactTest (SCNPhysicsBody body, SCNPhysicsTest? options)
		{
			return ContactTest (body, options.GetDictionary ());
		}
		[Export ("convexSweepTestWithShape:fromTransform:toTransform:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNPhysicsContact[] ConvexSweepTest (SCNPhysicsShape shape, SCNMatrix4 from, SCNMatrix4 to, NSDictionary? options)
		{
			var shape__handle__ = shape!.GetNonNullHandle (nameof (shape));
			var options__handle__ = options.GetHandle ();
			SCNPhysicsContact[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SCNPhysicsContact>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_SCNMatrix4_SCNMatrix4_NativeHandle (this.Handle, Selector.GetHandle ("convexSweepTestWithShape:fromTransform:toTransform:options:"), shape__handle__, from, to, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SCNPhysicsContact>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_SCNMatrix4_SCNMatrix4_NativeHandle (&__objc_super__, Selector.GetHandle ("convexSweepTestWithShape:fromTransform:toTransform:options:"), shape__handle__, from, to, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (shape);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="shape">To be added.</param><param name="from">To be added.</param><param name="to">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNPhysicsContact[] ConvexSweepTest (SCNPhysicsShape shape, SCNMatrix4 from, SCNMatrix4 to, SCNPhysicsTest? options)
		{
			return ConvexSweepTest (shape, from, to, options.GetDictionary ());
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("rayTestWithSegmentFromPoint:toPoint:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNHitTestResult[] RayTestWithSegmentFromPoint (SCNVector3 origin, SCNVector3 dest, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			SCNHitTestResult[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SCNHitTestResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SCNVector3_SCNVector3_NativeHandle (this.Handle, Selector.GetHandle ("rayTestWithSegmentFromPoint:toPoint:options:"), origin, dest, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SCNHitTestResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_SCNVector3_SCNVector3_NativeHandle (&__objc_super__, Selector.GetHandle ("rayTestWithSegmentFromPoint:toPoint:options:"), origin, dest, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="origin">To be added.</param><param name="dest">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNHitTestResult[] RayTestWithSegmentFromPoint (SCNVector3 origin, SCNVector3 dest, SCNPhysicsTest? options)
		{
			return RayTestWithSegmentFromPoint (origin, dest, options.GetDictionary ());
		}
		[Export ("removeAllBehaviors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllBehaviors ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllBehaviors"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllBehaviors"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeBehavior:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveBehavior (SCNPhysicsBehavior behavior)
		{
			var behavior__handle__ = behavior!.GetNonNullHandle (nameof (behavior));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeBehavior:"), behavior__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeBehavior:"), behavior__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (behavior);
		}
		[Export ("updateCollisionPairs")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateCollisionPairs ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateCollisionPairs"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateCollisionPairs"));
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNPhysicsBehavior[] AllBehaviors {
			[Export ("allBehaviors")]
			get {
				SCNPhysicsBehavior[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SCNPhysicsBehavior>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("allBehaviors")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SCNPhysicsBehavior>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allBehaviors")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISCNPhysicsContactDelegate ContactDelegate {
			get {
				return (WeakContactDelegate as ISCNPhysicsContactDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakContactDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 Gravity {
			[Export ("gravity")]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, Selector.GetHandle ("gravity"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("gravity"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGravity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, Selector.GetHandle ("setGravity:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, Selector.GetHandle ("setGravity:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Speed {
			[Export ("speed")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("speed"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("speed"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSpeed:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setSpeed:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setSpeed:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimeStep {
			[Export ("timeStep")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("timeStep"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("timeStep"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTimeStep:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setTimeStep:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setTimeStep:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakContactDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakContactDelegate {
			[Export ("contactDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("contactDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("contactDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakContactDelegate_var = ret;
				return ret!;
			}
			[Export ("setContactDelegate:", ArgumentSemantic.Weak)]
			set {
				UIApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakContactDelegate_var, value, GetInternalEventContactDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setContactDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setContactDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakContactDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventContactDelegateType
		{
			get { return typeof (_SCNPhysicsContactDelegate); }
		}
		internal virtual _SCNPhysicsContactDelegate CreateInternalEventContactDelegateType ()
		{
			return (_SCNPhysicsContactDelegate)(new _SCNPhysicsContactDelegate());
		}
		internal _SCNPhysicsContactDelegate EnsureSCNPhysicsContactDelegate ()
		{
			if (WeakContactDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakContactDelegate, GetInternalEventContactDelegateType);
			var del = ContactDelegate as _SCNPhysicsContactDelegate;
			if (del is null){
				del = (_SCNPhysicsContactDelegate)CreateInternalEventContactDelegateType ();
				ContactDelegate = (ISCNPhysicsContactDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _SCNPhysicsContactDelegate : NSObject, ISCNPhysicsContactDelegate { 
			public _SCNPhysicsContactDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_SCNPhysicsContactDelegate))]
			static _SCNPhysicsContactDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<SCNPhysicsContactEventArgs>? didBeginContact;
			[Export ("physicsWorld:didBeginContact:")]
			public void DidBeginContact (SCNPhysicsWorld world, SCNPhysicsContact contact)
			{
				var handler = didBeginContact;
				if (handler is not null){
					var args = new SCNPhysicsContactEventArgs (contact);
					handler (world, args);
				}
			}
			internal EventHandler<SCNPhysicsContactEventArgs>? didEndContact;
			[Export ("physicsWorld:didEndContact:")]
			public void DidEndContact (SCNPhysicsWorld world, SCNPhysicsContact contact)
			{
				var handler = didEndContact;
				if (handler is not null){
					var args = new SCNPhysicsContactEventArgs (contact);
					handler (world, args);
				}
			}
			internal EventHandler<SCNPhysicsContactEventArgs>? didUpdateContact;
			[Export ("physicsWorld:didUpdateContact:")]
			public void DidUpdateContact (SCNPhysicsWorld world, SCNPhysicsContact contact)
			{
				var handler = didUpdateContact;
				if (handler is not null){
					var args = new SCNPhysicsContactEventArgs (contact);
					handler (world, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakContactDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<SCNPhysicsContactEventArgs> DidBeginContact {
			add { EnsureSCNPhysicsContactDelegate ()!.didBeginContact += value; }
			remove { EnsureSCNPhysicsContactDelegate ()!.didBeginContact -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakContactDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<SCNPhysicsContactEventArgs> DidEndContact {
			add { EnsureSCNPhysicsContactDelegate ()!.didEndContact += value; }
			remove { EnsureSCNPhysicsContactDelegate ()!.didEndContact -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakContactDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<SCNPhysicsContactEventArgs> DidUpdateContact {
			add { EnsureSCNPhysicsContactDelegate ()!.didUpdateContact += value; }
			remove { EnsureSCNPhysicsContactDelegate ()!.didUpdateContact -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakContactDelegate_var = null;
			}
		}
	} /* class SCNPhysicsWorld */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class SCNPhysicsContactEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="SCNPhysicsContactEventArgs" /> with the specified event data.</summary>
		/// <param name="contact">The value for the <see cref="Contact" /> property.</param>
		public SCNPhysicsContactEventArgs (SCNPhysicsContact contact)
		{
			this.Contact = contact;
		}
		public SCNPhysicsContact Contact { get; set; }
	}
}
