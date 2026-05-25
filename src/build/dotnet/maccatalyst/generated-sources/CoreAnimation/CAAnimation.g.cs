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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreAnimation {
	/// <summary>Base class for animations.</summary><remarks><para>
	/// Layer-based animations are disabled by <see cref="T:UIKit.UIView" />s except within <see cref="T:UIKit.UIView" />
	/// animation blocks. Layer-based animations within such blocks ignore the blocks' duration and operate at their
	/// own specified duration, either the implicit default of 0.25 seconds or an explicit length. This is shown in
	/// the following example, in which the <see cref="T:UIKit.UIView" /> animation block's duration is 1.0, but in actuality,
	/// the layer-based implicit opacity animation ends in 0.25 seconds and the re-positioning runs for 10 seconds.
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// UIView.AnimateAsync(1.0, () => {
	/// 	imgView.Layer.Opacity = 0.0f;
	/// 
	/// 	var theAnim = CABasicAnimation.FromKeyPath("position");
	/// 	theAnim.From = NSObject.FromObject(firstPosition);
	/// 	theAnim.To =  NSObject.FromObject(secondPosition);
	/// 	theAnim.Duration = 10.0;
	/// 
	/// 	imgView.Layer.AddAnimation(theAnim, "AnimateFrame");
	/// });
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAAnimation_class/index.html">Apple documentation for <c>CAAnimation</c></related>
	[Register("CAAnimation", true)]
	public unsafe partial class CAAnimation : NSObject, ICAAction, ICAMediaTiming, INSCoding, INSCopying, INSMutableCopying, INSSecureCoding, global::SceneKit.ISCNAnimationProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CAAnimation");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CAAnimation" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CAAnimation () : base (NSObjectFlag.Empty)
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
		public CAAnimation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected CAAnimation (NSObjectFlag t) : base (t)
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
		protected internal CAAnimation (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <summary>Creates a new animation, you will use the derived classes static method instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CAAnimation CreateAnimation ()
		{
			CAAnimation ret;
			ret =  Runtime.GetNSObject<CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("animation")), false)!;
			return ret;
		}
		/// <param name="key"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>The default value used for the given object.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("defaultValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? DefaultValue (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("defaultValueForKey:"), nskey), false)!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>As part of key-value observing, indicates that the value represented by <paramref name="key" /> has changed.</summary><remarks>To be added.</remarks>
		[Export ("didChangeValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeValueForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didChangeValueForKey:"), nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("didChangeValueForKey:"), nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
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
		/// <param name="animation">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationWithSCNAnimation:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CAAnimation FromSCNAnimation (global::SceneKit.SCNAnimation animation)
		{
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			CAAnimation? ret;
			ret =  Runtime.GetNSObject<CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("animationWithSCNAnimation:"), animation__handle__), false)!;
			GC.KeepAlive (animation);
			return ret!;
		}
		/// <param name="zone">Zone to use to allocate this object, or null to use the default zone.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mutableCopyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject MutableCopy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("mutableCopyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("mutableCopyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="eventKey">To be added.</param><param name="obj">To be added.</param><param name="arguments"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("runActionForKey:object:arguments:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunAction (string eventKey, NSObject obj, NSDictionary? arguments)
		{
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var arguments__handle__ = arguments.GetHandle ();
			var nseventKey = CFString.CreateNative (eventKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("runActionForKey:object:arguments:"), nseventKey, obj__handle__, arguments__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("runActionForKey:object:arguments:"), nseventKey, obj__handle__, arguments__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
			GC.KeepAlive (arguments);
			CFString.ReleaseNative (nseventKey);
		}
		/// <param name="key"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Whether the value for the given key should be archived.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldArchiveValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldArchiveValueForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("shouldArchiveValueForKey:"), nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldArchiveValueForKey:"), nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		/// <param name="key">To be added.</param><summary>With key-value observing, indicates that the value associated with <paramref name="key" /> is about to change.</summary><remarks>To be added.</remarks>
		[Export ("willChangeValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeValueForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willChangeValueForKey:"), nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willChangeValueForKey:"), nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::SceneKit.SCNAnimationEvent[]? AnimationEvents {
			[Export ("animationEvents", ArgumentSemantic.Retain)]
			get {
				global::SceneKit.SCNAnimationEvent[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::SceneKit.SCNAnimationEvent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("animationEvents")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::SceneKit.SCNAnimationEvent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("animationEvents")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAnimationEvents:", ArgumentSemantic.Retain)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAnimationEvents:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAnimationEvents:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoReverses {
			[Export ("autoreverses")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoreverses"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("autoreverses"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoreverses:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoreverses:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAutoreverses:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double BeginTime {
			[Export ("beginTime")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("beginTime"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("beginTime"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBeginTime:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setBeginTime:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setBeginTime:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the CoreAnimation.CAAnimationDelegate model class which acts as the class delegate.</summary><value>The instance of the CoreAnimation.CAAnimationDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ICAAnimationDelegate Delegate {
			get {
				return (WeakDelegate as ICAAnimationDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
			[Export ("setDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setDuration:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setDuration:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nfloat FadeInDuration {
			[Export ("fadeInDuration")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("fadeInDuration"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("fadeInDuration"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFadeInDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setFadeInDuration:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setFadeInDuration:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nfloat FadeOutDuration {
			[Export ("fadeOutDuration")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("fadeOutDuration"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("fadeOutDuration"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFadeOutDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setFadeOutDuration:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setFadeOutDuration:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FillMode {
			[Export ("fillMode", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("fillMode")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("fillMode")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFillMode:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFillMode:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setFillMode:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
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
		/// <summary>Whether the animation is removed from the layer on completion.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemovedOnCompletion {
			[Export ("isRemovedOnCompletion")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRemovedOnCompletion"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isRemovedOnCompletion"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRemovedOnCompletion:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRemovedOnCompletion:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setRemovedOnCompletion:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float RepeatCount {
			[Export ("repeatCount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("repeatCount"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("repeatCount"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRepeatCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRepeatCount:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setRepeatCount:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double RepeatDuration {
			[Export ("repeatDuration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("repeatDuration"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("repeatDuration"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRepeatDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setRepeatDuration:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setRepeatDuration:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Speed {
			[Export ("speed")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("speed"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("speed"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSpeed:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setSpeed:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, Selector.GetHandle ("setSpeed:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimeOffset {
			[Export ("timeOffset")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("timeOffset"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("timeOffset"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTimeOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setTimeOffset:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setTimeOffset:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The timing function used to compute the animation.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CAMediaTimingFunction? TimingFunction {
			[Export ("timingFunction", ArgumentSemantic.Retain)]
			get {
				CAMediaTimingFunction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CAMediaTimingFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("timingFunction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CAMediaTimingFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("timingFunction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTimingFunction:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTimingFunction:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTimingFunction:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool UsesSceneTimeBase {
			[Export ("usesSceneTimeBase")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesSceneTimeBase"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("usesSceneTimeBase"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesSceneTimeBase:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUsesSceneTimeBase:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setUsesSceneTimeBase:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An object that can respond to the delegate protocol for this type</summary><value>The instance that will respond to events and data requests.</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Retain)]
			get {
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
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Retain)]
			set {
				UIApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (null, value, GetInternalEventDelegateType);
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
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationCubic;
		/// <summary>Represents the value associated with the constant kCAAnimationCubic</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAAnimationCubic",  "CoreAnimation")]
		public static NSString AnimationCubic {
			get {
				if (_AnimationCubic is null)
					_AnimationCubic = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAAnimationCubic")!;
				return _AnimationCubic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationCubicPaced;
		/// <summary>Represents the value associated with the constant kCAAnimationCubicPaced</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAAnimationCubicPaced",  "CoreAnimation")]
		public static NSString AnimationCubicPaced {
			get {
				if (_AnimationCubicPaced is null)
					_AnimationCubicPaced = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAAnimationCubicPaced")!;
				return _AnimationCubicPaced;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationDiscrete;
		/// <summary>Represents the value associated with the constant kCAAnimationDiscrete</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCAAnimationDiscrete",  "CoreAnimation")]
		public static NSString AnimationDiscrete {
			get {
				if (_AnimationDiscrete is null)
					_AnimationDiscrete = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAAnimationDiscrete")!;
				return _AnimationDiscrete;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationLinear;
		/// <summary>Represents the value associated with the constant kCAAnimationLinear</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAAnimationLinear",  "CoreAnimation")]
		public static NSString AnimationLinear {
			get {
				if (_AnimationLinear is null)
					_AnimationLinear = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAAnimationLinear")!;
				return _AnimationLinear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnimationPaced;
		/// <summary>Represents the value associated with the constant kCAAnimationPaced</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAAnimationPaced",  "CoreAnimation")]
		public static NSString AnimationPaced {
			get {
				if (_AnimationPaced is null)
					_AnimationPaced = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAAnimationPaced")!;
				return _AnimationPaced;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RotateModeAuto;
		/// <summary>Represents the value associated with the constant kCAAnimationRotateAuto</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAAnimationRotateAuto",  "CoreAnimation")]
		public static NSString RotateModeAuto {
			get {
				if (_RotateModeAuto is null)
					_RotateModeAuto = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAAnimationRotateAuto")!;
				return _RotateModeAuto;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RotateModeAutoReverse;
		/// <summary>Represents the value associated with the constant kCAAnimationRotateAutoReverse</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAAnimationRotateAutoReverse",  "CoreAnimation")]
		public static NSString RotateModeAutoReverse {
			get {
				if (_RotateModeAutoReverse is null)
					_RotateModeAutoReverse = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAAnimationRotateAutoReverse")!;
				return _RotateModeAutoReverse;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransitionFade;
		/// <summary>Represents the value associated with the constant kCATransitionFade</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransitionFade",  "CoreAnimation")]
		public static NSString TransitionFade {
			get {
				if (_TransitionFade is null)
					_TransitionFade = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransitionFade")!;
				return _TransitionFade;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransitionFromBottom;
		/// <summary>Represents the value associated with the constant kCATransitionFromBottom</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransitionFromBottom",  "CoreAnimation")]
		public static NSString TransitionFromBottom {
			get {
				if (_TransitionFromBottom is null)
					_TransitionFromBottom = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransitionFromBottom")!;
				return _TransitionFromBottom;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransitionFromLeft;
		/// <summary>Represents the value associated with the constant kCATransitionFromLeft</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransitionFromLeft",  "CoreAnimation")]
		public static NSString TransitionFromLeft {
			get {
				if (_TransitionFromLeft is null)
					_TransitionFromLeft = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransitionFromLeft")!;
				return _TransitionFromLeft;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransitionFromRight;
		/// <summary>Represents the value associated with the constant kCATransitionFromRight</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransitionFromRight",  "CoreAnimation")]
		public static NSString TransitionFromRight {
			get {
				if (_TransitionFromRight is null)
					_TransitionFromRight = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransitionFromRight")!;
				return _TransitionFromRight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransitionFromTop;
		/// <summary>Represents the value associated with the constant kCATransitionFromTop</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransitionFromTop",  "CoreAnimation")]
		public static NSString TransitionFromTop {
			get {
				if (_TransitionFromTop is null)
					_TransitionFromTop = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransitionFromTop")!;
				return _TransitionFromTop;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransitionMoveIn;
		/// <summary>Represents the value associated with the constant kCATransitionMoveIn</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransitionMoveIn",  "CoreAnimation")]
		public static NSString TransitionMoveIn {
			get {
				if (_TransitionMoveIn is null)
					_TransitionMoveIn = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransitionMoveIn")!;
				return _TransitionMoveIn;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransitionPush;
		/// <summary>Represents the value associated with the constant kCATransitionPush</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransitionPush",  "CoreAnimation")]
		public static NSString TransitionPush {
			get {
				if (_TransitionPush is null)
					_TransitionPush = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransitionPush")!;
				return _TransitionPush;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TransitionReveal;
		/// <summary>Represents the value associated with the constant kCATransitionReveal</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransitionReveal",  "CoreAnimation")]
		public static NSString TransitionReveal {
			get {
				if (_TransitionReveal is null)
					_TransitionReveal = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransitionReveal")!;
				return _TransitionReveal;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_CAAnimationDelegate); }
		}
		internal virtual _CAAnimationDelegate CreateInternalEventDelegateType ()
		{
			return (_CAAnimationDelegate)(new _CAAnimationDelegate());
		}
		internal _CAAnimationDelegate EnsureCAAnimationDelegate ()
		{
			if (WeakDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _CAAnimationDelegate;
			if (del is null){
				del = (_CAAnimationDelegate)CreateInternalEventDelegateType ();
				Delegate = (ICAAnimationDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _CAAnimationDelegate : NSObject, ICAAnimationDelegate { 
			public _CAAnimationDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_CAAnimationDelegate))]
			static _CAAnimationDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler? animationStarted;
			[Export ("animationDidStart:")]
			public void AnimationStarted (CAAnimation anim)
			{
				var handler = animationStarted;
				if (handler is not null){
					handler (anim, EventArgs.Empty);
				}
			}
			internal EventHandler<CAAnimationStateEventArgs>? animationStopped;
			[Export ("animationDidStop:finished:")]
			public void AnimationStopped (CAAnimation anim, bool finished)
			{
				var handler = animationStopped;
				if (handler is not null){
					var args = new CAAnimationStateEventArgs (finished);
					handler (anim, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler AnimationStarted {
			add { EnsureCAAnimationDelegate ()!.animationStarted += value; }
			remove { EnsureCAAnimationDelegate ()!.animationStarted -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<CAAnimationStateEventArgs> AnimationStopped {
			add { EnsureCAAnimationDelegate ()!.animationStopped += value; }
			remove { EnsureCAAnimationDelegate ()!.animationStopped -= value; }
		}
	} /* class CAAnimation */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class CAAnimationStateEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="CAAnimationStateEventArgs" /> with the specified event data.</summary>
		/// <param name="finished">The value for the <see cref="Finished" /> property.</param>
		public CAAnimationStateEventArgs (bool finished)
		{
			this.Finished = finished;
		}
		public bool Finished { get; set; }
	}
}
