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
namespace SceneKit {
	/// <summary>Performs actions on a <see cref="T:SceneKit.SCNNode" />, including changes to appearance, geometry, animations, or arbitrary functions.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNAction_Class/index.html">Apple documentation for <c>SCNAction</c></related>
	[Register("SCNAction", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNAction : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCNAction");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SCNAction" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCNAction () : base (NSObjectFlag.Empty)
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
		public SCNAction (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SCNAction (NSObjectFlag t) : base (t)
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
		protected internal SCNAction (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("customActionWithDuration:actionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNAction CustomAction (double seconds, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCNActionNodeWithElapsedTimeHandler))]SCNActionNodeWithElapsedTimeHandler handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDSCNActionNodeWithElapsedTimeHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_NativeHandle (class_ptr, Selector.GetHandle ("customActionWithDuration:actionBlock:"), seconds, (IntPtr) block_ptr_handler), false)!;
			return ret;
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
		[Export ("fadeInWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction FadeIn (double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, Selector.GetHandle ("fadeInWithDuration:"), durationInSeconds), false)!;
			return ret;
		}
		/// <param name="factor">To be added.</param><param name="durationInSeconds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fadeOpacityBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction FadeOpacityBy (nfloat factor, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("fadeOpacityBy:duration:"), factor, durationInSeconds), false)!;
			return ret;
		}
		/// <param name="opacity">To be added.</param><param name="durationInSeconds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fadeOpacityTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction FadeOpacityTo (nfloat opacity, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("fadeOpacityTo:duration:"), opacity, durationInSeconds), false)!;
			return ret;
		}
		[Export ("fadeOutWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction FadeOut (double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, Selector.GetHandle ("fadeOutWithDuration:"), durationInSeconds), false)!;
			return ret;
		}
		[Export ("javaScriptActionWithScript:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction FromJavascript (string script, double seconds)
		{
			if (script is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (script));
			var nsscript = CFString.CreateNative (script);
			SCNAction? ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, Selector.GetHandle ("javaScriptActionWithScript:duration:"), nsscript, seconds), false)!;
			CFString.ReleaseNative (nsscript);
			return ret!;
		}
		[Export ("group:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction Group (SCNAction[] actions)
		{
			if (actions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actions));
			using var nsa_actions = NSArray.FromNSObjects (actions);
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("group:"), nsa_actions.Handle), false)!;
			return ret;
		}
		[Export ("hide")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction Hide ()
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("hide")), false)!;
			return ret;
		}
		/// <param name="deltaX">To be added.</param><param name="deltaY">To be added.</param><param name="deltaZ">To be added.</param><param name="durationInSeconds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("moveByX:y:z:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction MoveBy (nfloat deltaX, nfloat deltaY, nfloat deltaZ, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_Double (class_ptr, Selector.GetHandle ("moveByX:y:z:duration:"), deltaX, deltaY, deltaZ, durationInSeconds), false)!;
			return ret;
		}
		[Export ("moveBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction MoveBy (SCNVector3 delta, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SCNVector3_Double (class_ptr, Selector.GetHandle ("moveBy:duration:"), delta, durationInSeconds), false)!;
			return ret;
		}
		[Export ("moveTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction MoveTo (SCNVector3 location, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SCNVector3_Double (class_ptr, Selector.GetHandle ("moveTo:duration:"), location, durationInSeconds), false)!;
			return ret;
		}
		[Export ("playAudioSource:waitForCompletion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction PlayAudioSource (SCNAudioSource source, bool wait)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			SCNAction? ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, Selector.GetHandle ("playAudioSource:waitForCompletion:"), source__handle__, wait ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("removeFromParentNode")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction RemoveFromParentNode ()
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("removeFromParentNode")), false)!;
			return ret;
		}
		/// <param name="action">To be added.</param><param name="count">To be added.</param><summary>Creates an action that repeats <paramref name="action" /> for <paramref name="count" /> number of times.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("repeatAction:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction RepeatAction (SCNAction action, nuint count)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			SCNAction? ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (class_ptr, Selector.GetHandle ("repeatAction:count:"), action__handle__, count), false)!;
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("repeatActionForever:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction RepeatActionForever (SCNAction action)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			SCNAction? ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("repeatActionForever:"), action__handle__), false)!;
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("reversedAction")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNAction ReversedAction ()
		{
			SCNAction ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reversedAction")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reversedAction")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="xAngle">To be added.</param><param name="yAngle">To be added.</param><param name="zAngle">To be added.</param><param name="durationInSeconds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateByX:y:z:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction RotateBy (nfloat xAngle, nfloat yAngle, nfloat zAngle, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_Double (class_ptr, Selector.GetHandle ("rotateByX:y:z:duration:"), xAngle, yAngle, zAngle, durationInSeconds), false)!;
			return ret;
		}
		/// <param name="angle">To be added.</param><param name="axis">To be added.</param><param name="durationInSeconds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateByAngle:aroundAxis:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction RotateBy (nfloat angle, SCNVector3 axis, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_SCNVector3_Double (class_ptr, Selector.GetHandle ("rotateByAngle:aroundAxis:duration:"), angle, axis, durationInSeconds), false)!;
			return ret;
		}
		/// <param name="xAngle">To be added.</param><param name="yAngle">To be added.</param><param name="zAngle">To be added.</param><param name="durationInSeconds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateToX:y:z:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction RotateTo (nfloat xAngle, nfloat yAngle, nfloat zAngle, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_Double (class_ptr, Selector.GetHandle ("rotateToX:y:z:duration:"), xAngle, yAngle, zAngle, durationInSeconds), false)!;
			return ret;
		}
		/// <param name="xAngle">To be added.</param><param name="yAngle">To be added.</param><param name="zAngle">To be added.</param><param name="durationInSeconds">To be added.</param><param name="shortestUnitArc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateToX:y:z:duration:shortestUnitArc:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction RotateTo (nfloat xAngle, nfloat yAngle, nfloat zAngle, double durationInSeconds, bool shortestUnitArc)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_nfloat_Double_bool (class_ptr, Selector.GetHandle ("rotateToX:y:z:duration:shortestUnitArc:"), xAngle, yAngle, zAngle, durationInSeconds, shortestUnitArc ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("rotateToAxisAngle:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction RotateTo (SCNVector4 axisAngle, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SCNVector4_Double (class_ptr, Selector.GetHandle ("rotateToAxisAngle:duration:"), axisAngle, durationInSeconds), false)!;
			return ret;
		}
		[Export ("runBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNAction Run ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V250))]global::System.Action<SCNNode> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V250.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("runBlock:"), (IntPtr) block_ptr_handler), false)!;
			return ret;
		}
		[Export ("runBlock:queue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNAction Run ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V250))]global::System.Action<SCNNode> handler, global::CoreFoundation.DispatchQueue queue)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			using var block_handler = Trampolines.SDActionArity1V250.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			SCNAction? ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("runBlock:queue:"), (IntPtr) block_ptr_handler, queue.Handle), false)!;
			GC.KeepAlive (queue);
			return ret!;
		}
		/// <param name="scale">To be added.</param><param name="durationInSeconds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction ScaleBy (nfloat scale, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("scaleBy:duration:"), scale, durationInSeconds), false)!;
			return ret;
		}
		/// <param name="scale">To be added.</param><param name="durationInSeconds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction ScaleTo (nfloat scale, double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("scaleTo:duration:"), scale, durationInSeconds), false)!;
			return ret;
		}
		[Export ("sequence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction Sequence (SCNAction[] actions)
		{
			if (actions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actions));
			using var nsa_actions = NSArray.FromNSObjects (actions);
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("sequence:"), nsa_actions.Handle), false)!;
			return ret;
		}
		[Export ("unhide")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction Unhide ()
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("unhide")), false)!;
			return ret;
		}
		[Export ("waitForDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction Wait (double durationInSeconds)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, Selector.GetHandle ("waitForDuration:"), durationInSeconds), false)!;
			return ret;
		}
		[Export ("waitForDuration:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNAction Wait (double durationInSeconds, double durationRange)
		{
			SCNAction ret;
			ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_Double (class_ptr, Selector.GetHandle ("waitForDuration:withRange:"), durationInSeconds, durationRange), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DurationInSeconds {
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
		/// <summary>Sets the function that transforms the times at which actions occur.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::System.Func<float, float>? TimingFunction {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDFuncArity2V7))]
			[Export ("timingFunction", ArgumentSemantic.Assign)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("timingFunction"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("timingFunction"));
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDFuncArity2V7.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V7))]
			[Export ("setTimingFunction:", ArgumentSemantic.Assign)]
			set {
				using var block_value = Trampolines.SDFuncArity2V7.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTimingFunction:"), (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTimingFunction:"), (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNActionTimingMode TimingMode {
			[Export ("timingMode")]
			get {
				SCNActionTimingMode ret;
				if (IsDirectBinding) {
					ret = (SCNActionTimingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("timingMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNActionTimingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("timingMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTimingMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTimingMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setTimingMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class SCNAction */
}
