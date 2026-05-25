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
namespace SpriteKit {
	/// <summary>Modifies properties on a <see cref="T:SpriteKit.SKNode" />, often animating the changes. Sometimes reversible.</summary><remarks><para>Application developers use the static methods of <see cref="T:SpriteKit.SKAction" /> to create actions that can be applied to the <see cref="T:SpriteKit.SKNode" />s of a <see cref="T:SpriteKit.SKScene" />. Generally, animations are animated.</para><para>The <see cref="M:SpriteKit.SKAction.Group(SpriteKit.SKAction[])" />, <see cref="M:SpriteKit.SKAction.RepeatAction(SpriteKit.SKAction,System.UIntPtr)" /> and <see cref="M:SpriteKit.SKAction.RepeatActionForever(SpriteKit.SKAction)" />, and <see cref="M:SpriteKit.SKAction.Sequence(SpriteKit.SKAction[])" /> methods are composite actions that take, as parameters, children <see cref="T:SpriteKit.SKAction" />s. </para><para>Once a <see cref="T:SpriteKit.SKAction" /> is created, application developers run it with the <see cref="SpriteKit.SKNode.RunActionAsync(SpriteKit.SKAction)" /> method, as shown in this example:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var actions = SKAction.Group(
	/// 	new SKAction[] {
	/// 		SKAction.MoveBy(new CGVector(10, 10), 1),
	/// 		SKAction.FadeAlphaTo(0.3f, 1),
	/// 		SKAction.ScaleBy(0.8f, 1)
	/// });
	/// 
	/// b.Node.RunAction(actions);          
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKAction_Ref/index.html">Apple documentation for <c>SKAction</c></related>
	[Register("SKAction", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKAction : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKAction");
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
		public SKAction (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SKAction (NSObjectFlag t) : base (t)
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
		protected internal SKAction (NativeHandle handle) : base (handle)
		{
		}

		[Export ("animateWithWarps:times:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Animate (SKWarpGeometry[] warps, NSNumber[] times)
		{
			if (warps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (warps));
			if (times is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (times));
			using var nsa_warps = NSArray.FromNSObjects (warps);
			using var nsa_times = NSArray.FromNSObjects (times);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("animateWithWarps:times:"), nsa_warps.Handle, nsa_times.Handle), false)!;
			return ret;
		}
		[Export ("animateWithWarps:times:restore:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Animate (SKWarpGeometry[] warps, NSNumber[] times, bool restore)
		{
			if (warps is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (warps));
			if (times is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (times));
			using var nsa_warps = NSArray.FromNSObjects (warps);
			using var nsa_times = NSArray.FromNSObjects (times);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("animateWithWarps:times:restore:"), nsa_warps.Handle, nsa_times.Handle, restore ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("animateWithNormalTextures:timePerFrame:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction AnimateWithNormalTextures (SKTexture[] textures, double secondsPerFrame)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, Selector.GetHandle ("animateWithNormalTextures:timePerFrame:"), nsa_textures.Handle, secondsPerFrame), false)!;
			return ret;
		}
		[Export ("animateWithNormalTextures:timePerFrame:resize:restore:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction AnimateWithNormalTextures (SKTexture[] textures, double secondsPerFrame, bool resize, bool restore)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_bool_bool (class_ptr, Selector.GetHandle ("animateWithNormalTextures:timePerFrame:resize:restore:"), nsa_textures.Handle, secondsPerFrame, resize ? (byte) 1 : (byte) 0, restore ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("animateWithTextures:timePerFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction AnimateWithTextures (SKTexture[] textures, double sec)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, Selector.GetHandle ("animateWithTextures:timePerFrame:"), nsa_textures.Handle, sec), false)!;
			return ret;
		}
		[Export ("animateWithTextures:timePerFrame:resize:restore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction AnimateWithTextures (SKTexture[] textures, double sec, bool resize, bool restore)
		{
			if (textures is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textures));
			using var nsa_textures = NSArray.FromNSObjects (textures);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_bool_bool (class_ptr, Selector.GetHandle ("animateWithTextures:timePerFrame:resize:restore:"), nsa_textures.Handle, sec, resize ? (byte) 1 : (byte) 0, restore ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		/// <param name="color">To be added.</param><param name="colorBlendFactor">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorizeWithColor:colorBlendFactor:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ColorizeWithColor (global::UIKit.UIColor color, nfloat colorBlendFactor, double sec)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat_Double (class_ptr, Selector.GetHandle ("colorizeWithColor:colorBlendFactor:duration:"), color__handle__, colorBlendFactor, sec), false)!;
			GC.KeepAlive (color);
			return ret!;
		}
		/// <param name="colorBlendFactor">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("colorizeWithColorBlendFactor:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ColorizeWithColorBlendFactor (nfloat colorBlendFactor, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("colorizeWithColorBlendFactor:duration:"), colorBlendFactor, sec), false)!;
			return ret;
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
		[Export ("actionNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Create (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("actionNamed:"), nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("actionNamed:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Create (string name, double duration)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, Selector.GetHandle ("actionNamed:duration:"), nsname, duration), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("actionNamed:fromURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Create (string name, NSUrl url)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("actionNamed:fromURL:"), nsname, url__handle__), false)!;
			GC.KeepAlive (url);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("actionNamed:fromURL:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? Create (string name, NSUrl url, double duration)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_Double (class_ptr, Selector.GetHandle ("actionNamed:fromURL:duration:"), nsname, url__handle__, duration), false)!;
			GC.KeepAlive (url);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="impulse">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applyAngularImpulse:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyAngularImpulse (nfloat impulse, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("applyAngularImpulse:duration:"), impulse, duration), false)!;
			return ret;
		}
		[Export ("applyForce:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyForce (CGVector force, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_Double (class_ptr, Selector.GetHandle ("applyForce:duration:"), force, duration), false)!;
			return ret;
		}
		[Export ("applyForce:atPoint:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyForce (CGVector force, CGPoint point, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_CGPoint_Double (class_ptr, Selector.GetHandle ("applyForce:atPoint:duration:"), force, point, duration), false)!;
			return ret;
		}
		[Export ("applyImpulse:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyImpulse (CGVector impulse, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_Double (class_ptr, Selector.GetHandle ("applyImpulse:duration:"), impulse, duration), false)!;
			return ret;
		}
		[Export ("applyImpulse:atPoint:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyImpulse (CGVector impulse, CGPoint point, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_CGPoint_Double (class_ptr, Selector.GetHandle ("applyImpulse:atPoint:duration:"), impulse, point, duration), false)!;
			return ret;
		}
		/// <param name="torque">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applyTorque:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateApplyTorque (nfloat torque, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("applyTorque:duration:"), torque, duration), false)!;
			return ret;
		}
		[Export ("changeChargeBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeChargeBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeChargeBy:duration:"), by, duration), false)!;
			return ret;
		}
		[Export ("changeChargeTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeChargeTo (float newCharge, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeChargeTo:duration:"), newCharge, duration), false)!;
			return ret;
		}
		[Export ("changeMassBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeMassBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeMassBy:duration:"), by, duration), false)!;
			return ret;
		}
		[Export ("changeMassTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeMassTo (float newMass, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeMassTo:duration:"), newMass, duration), false)!;
			return ret;
		}
		[Export ("changeObstructionBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeObstructionBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeObstructionBy:duration:"), by, duration), false)!;
			return ret;
		}
		[Export ("changeObstructionTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeObstructionTo (float target, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeObstructionTo:duration:"), target, duration), false)!;
			return ret;
		}
		[Export ("changeOcclusionBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeOcclusionBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeOcclusionBy:duration:"), by, duration), false)!;
			return ret;
		}
		[Export ("changeOcclusionTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeOcclusionTo (float target, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeOcclusionTo:duration:"), target, duration), false)!;
			return ret;
		}
		[Export ("changePlaybackRateTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangePlaybackRate (float playbackRate, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changePlaybackRateTo:duration:"), playbackRate, duration), false)!;
			return ret;
		}
		[Export ("changePlaybackRateBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangePlaybackRateBy (float playbackRate, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changePlaybackRateBy:duration:"), playbackRate, duration), false)!;
			return ret;
		}
		[Export ("changeReverbBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeReverbBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeReverbBy:duration:"), by, duration), false)!;
			return ret;
		}
		[Export ("changeReverbTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeReverbTo (float target, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeReverbTo:duration:"), target, duration), false)!;
			return ret;
		}
		[Export ("changeVolumeTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeVolume (float newVolume, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeVolumeTo:duration:"), newVolume, duration), false)!;
			return ret;
		}
		[Export ("changeVolumeBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateChangeVolumeBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("changeVolumeBy:duration:"), by, duration), false)!;
			return ret;
		}
		[Export ("pause")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreatePause ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("pause")), false)!;
			return ret;
		}
		[Export ("play")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreatePlay ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("play")), false)!;
			return ret;
		}
		[Export ("stereoPanBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateStereoPanBy (float by, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("stereoPanBy:duration:"), by, duration), false)!;
			return ret;
		}
		[Export ("stereoPanTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateStereoPanTo (float target, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("stereoPanTo:duration:"), target, duration), false)!;
			return ret;
		}
		[Export ("stop")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction CreateStop ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("stop")), false)!;
			return ret;
		}
		[Export ("customActionWithDuration:actionBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKAction CustomActionWithDuration (double seconds, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKActionDurationHandler))]SKActionDurationHandler actionHandler)
		{
			if (actionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actionHandler));
			using var block_actionHandler = Trampolines.SDSKActionDurationHandler.CreateBlock (actionHandler);
			BlockLiteral *block_ptr_actionHandler = &block_actionHandler;
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_NativeHandle (class_ptr, Selector.GetHandle ("customActionWithDuration:actionBlock:"), seconds, (IntPtr) block_ptr_actionHandler), false)!;
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
		/// <param name="factor">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fadeAlphaBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FadeAlphaBy (nfloat factor, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("fadeAlphaBy:duration:"), factor, sec), false)!;
			return ret;
		}
		/// <param name="alpha">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fadeAlphaTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FadeAlphaTo (nfloat alpha, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("fadeAlphaTo:duration:"), alpha, sec), false)!;
			return ret;
		}
		[Export ("fadeInWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FadeInWithDuration (double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, Selector.GetHandle ("fadeInWithDuration:"), sec), false)!;
			return ret;
		}
		[Export ("fadeOutWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FadeOutWithDuration (double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, Selector.GetHandle ("fadeOutWithDuration:"), sec), false)!;
			return ret;
		}
		[Export ("falloffBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FalloffBy (float to, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("falloffBy:duration:"), to, duration), false)!;
			return ret;
		}
		[Export ("falloffTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FalloffTo (float falloff, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("falloffTo:duration:"), falloff, sec), false)!;
			return ret;
		}
		[Export ("followPath:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FollowPath (CGPath path, double sec)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, Selector.GetHandle ("followPath:duration:"), path.Handle, sec), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		[Export ("followPath:asOffset:orientToPath:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FollowPath (CGPath path, bool offset, bool orient, double sec)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_bool_Double (class_ptr, Selector.GetHandle ("followPath:asOffset:orientToPath:duration:"), path.Handle, offset ? (byte) 1 : (byte) 0, orient ? (byte) 1 : (byte) 0, sec), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		/// <param name="path">To be added.</param><param name="speed">To be added.</param><summary>Creates an action that moves the <see cref="T:SpriteKit.SKNode" /> on which it is run over the <paramref name="path" />, at the specified <paramref name="speed" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("followPath:speed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FollowPath (CGPath path, nfloat speed)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (class_ptr, Selector.GetHandle ("followPath:speed:"), path.Handle, speed), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		/// <param name="path">To be added.</param><param name="offset">To be added.</param><param name="orient">To be added.</param><param name="speed">To be added.</param><summary>Creates an action that moves the <see cref="T:SpriteKit.SKNode" /> on which it is run over the <paramref name="path" />, with the specified offset, orientation, and speed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("followPath:asOffset:orientToPath:speed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction FollowPath (CGPath path, bool offset, bool orient, nfloat speed)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_bool_nfloat (class_ptr, Selector.GetHandle ("followPath:asOffset:orientToPath:speed:"), path.Handle, offset ? (byte) 1 : (byte) 0, orient ? (byte) 1 : (byte) 0, speed), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		[Export ("group:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction Group (params SKAction[] actions)
		{
			if (actions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actions));
			using var nsa_actions = NSArray.FromNSObjects (actions);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("group:"), nsa_actions.Handle), false)!;
			return ret;
		}
		[Export ("hide")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction Hide ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("hide")), false)!;
			return ret;
		}
		/// <param name="deltaX">To be added.</param><param name="deltaY">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("moveByX:y:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveBy (nfloat deltaX, nfloat deltaY, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, Selector.GetHandle ("moveByX:y:duration:"), deltaX, deltaY, sec), false)!;
			return ret;
		}
		[Export ("moveBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveBy (CGVector delta, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGVector_Double (class_ptr, Selector.GetHandle ("moveBy:duration:"), delta, duration), false)!;
			return ret;
		}
		[Export ("moveTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveTo (CGPoint location, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_Double (class_ptr, Selector.GetHandle ("moveTo:duration:"), location, sec), false)!;
			return ret;
		}
		/// <param name="x">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("moveToX:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveToX (nfloat x, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("moveToX:duration:"), x, sec), false)!;
			return ret;
		}
		/// <param name="y">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("moveToY:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction MoveToY (nfloat y, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("moveToY:duration:"), y, sec), false)!;
			return ret;
		}
		[Export ("performSelector:onTarget:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction PerformSelector (Selector selector, NSObject target)
		{
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("performSelector:onTarget:"), selector.Handle, target__handle__), false)!;
			GC.KeepAlive (selector);
			GC.KeepAlive (target);
			return ret!;
		}
		[Export ("playSoundFileNamed:waitForCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction PlaySoundFileNamed (string soundFile, bool wait)
		{
			if (soundFile is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (soundFile));
			var nssoundFile = CFString.CreateNative (soundFile);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, Selector.GetHandle ("playSoundFileNamed:waitForCompletion:"), nssoundFile, wait ? (byte) 1 : (byte) 0), false)!;
			CFString.ReleaseNative (nssoundFile);
			return ret!;
		}
		[Export ("reachTo:rootNode:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ReachTo (CGPoint position, SKNode rootNode, double secs)
		{
			var rootNode__handle__ = rootNode!.GetNonNullHandle (nameof (rootNode));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle_Double (class_ptr, Selector.GetHandle ("reachTo:rootNode:duration:"), position, rootNode__handle__, secs), false)!;
			GC.KeepAlive (rootNode);
			return ret!;
		}
		/// <param name="position">To be added.</param><param name="rootNode">To be added.</param><param name="velocity">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("reachTo:rootNode:velocity:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ReachTo (CGPoint position, SKNode rootNode, nfloat velocity)
		{
			var rootNode__handle__ = rootNode!.GetNonNullHandle (nameof (rootNode));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_NativeHandle_nfloat (class_ptr, Selector.GetHandle ("reachTo:rootNode:velocity:"), position, rootNode__handle__, velocity), false)!;
			GC.KeepAlive (rootNode);
			return ret!;
		}
		[Export ("reachToNode:rootNode:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ReachToNode (SKNode node, SKNode rootNode, double sec)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var rootNode__handle__ = rootNode!.GetNonNullHandle (nameof (rootNode));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_Double (class_ptr, Selector.GetHandle ("reachToNode:rootNode:duration:"), node__handle__, rootNode__handle__, sec), false)!;
			GC.KeepAlive (node);
			GC.KeepAlive (rootNode);
			return ret!;
		}
		/// <param name="node">To be added.</param><param name="rootNode">To be added.</param><param name="velocity">To be added.</param><summary>Creates an action that moves the node to which it is applied by rotating it, along with all nodes between it and <paramref name="rootNode" />, so that it is closer to <paramref name="node" />, in a way that moves the node at the speed that is specified by <paramref name="velocity" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("reachToNode:rootNode:velocity:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ReachToNode (SKNode node, SKNode rootNode, nfloat velocity)
		{
			var node__handle__ = node!.GetNonNullHandle (nameof (node));
			var rootNode__handle__ = rootNode!.GetNonNullHandle (nameof (rootNode));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_nfloat (class_ptr, Selector.GetHandle ("reachToNode:rootNode:velocity:"), node__handle__, rootNode__handle__, velocity), false)!;
			GC.KeepAlive (node);
			GC.KeepAlive (rootNode);
			return ret!;
		}
		[Export ("removeFromParent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RemoveFromParent ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("removeFromParent")), false)!;
			return ret;
		}
		/// <param name="action">To be added.</param><param name="count">To be added.</param><summary>Creates an action that repeats <paramref name="action" /> a specified number of times on the node on which it is run.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("repeatAction:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RepeatAction (SKAction action, nuint count)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (class_ptr, Selector.GetHandle ("repeatAction:count:"), action__handle__, count), false)!;
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("repeatActionForever:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RepeatActionForever (SKAction action)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("repeatActionForever:"), action__handle__), false)!;
			GC.KeepAlive (action);
			return ret!;
		}
		/// <param name="width">To be added.</param><param name="height">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resizeByWidth:height:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ResizeByWidth (nfloat width, nfloat height, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, Selector.GetHandle ("resizeByWidth:height:duration:"), width, height, duration), false)!;
			return ret;
		}
		/// <param name="width">To be added.</param><param name="height">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resizeToWidth:height:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ResizeTo (nfloat width, nfloat height, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, Selector.GetHandle ("resizeToWidth:height:duration:"), width, height, duration), false)!;
			return ret;
		}
		/// <param name="height">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resizeToHeight:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ResizeToHeight (nfloat height, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("resizeToHeight:duration:"), height, duration), false)!;
			return ret;
		}
		/// <param name="width">To be added.</param><param name="duration">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resizeToWidth:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ResizeToWidth (nfloat width, double duration)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("resizeToWidth:duration:"), width, duration), false)!;
			return ret;
		}
		/// <param name="radians">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateByAngle:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RotateByAngle (nfloat radians, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("rotateByAngle:duration:"), radians, sec), false)!;
			return ret;
		}
		/// <param name="radians">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateToAngle:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RotateToAngle (nfloat radians, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("rotateToAngle:duration:"), radians, sec), false)!;
			return ret;
		}
		/// <param name="radians">To be added.</param><param name="sec">To be added.</param><param name="shortedUnitArc">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rotateToAngle:duration:shortestUnitArc:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RotateToAngle (nfloat radians, double sec, bool shortedUnitArc)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double_bool (class_ptr, Selector.GetHandle ("rotateToAngle:duration:shortestUnitArc:"), radians, sec, shortedUnitArc ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("runBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKAction Run ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDAction.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("runBlock:"), (IntPtr) block_ptr_block), false)!;
			return ret;
		}
		[Export ("runBlock:queue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKAction Run ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block, global::CoreFoundation.DispatchQueue queue)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			var queue__handle__ = queue!.GetNonNullHandle (nameof (queue));
			using var block_block = Trampolines.SDAction.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("runBlock:queue:"), (IntPtr) block_ptr_block, queue.Handle), false)!;
			GC.KeepAlive (queue);
			return ret!;
		}
		[Export ("runAction:onChildWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction RunAction (SKAction action, string name)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("runAction:onChildWithName:"), action__handle__, nsname), false)!;
			GC.KeepAlive (action);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="scale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleBy (nfloat scale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("scaleBy:duration:"), scale, sec), false)!;
			return ret;
		}
		/// <param name="xScale">To be added.</param><param name="yScale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleXBy:y:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleBy (nfloat xScale, nfloat yScale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, Selector.GetHandle ("scaleXBy:y:duration:"), xScale, yScale, sec), false)!;
			return ret;
		}
		/// <param name="scale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleTo (nfloat scale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("scaleTo:duration:"), scale, sec), false)!;
			return ret;
		}
		/// <param name="xScale">To be added.</param><param name="yScale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleXTo:y:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleTo (nfloat xScale, nfloat yScale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_nfloat_Double (class_ptr, Selector.GetHandle ("scaleXTo:y:duration:"), xScale, yScale, sec), false)!;
			return ret;
		}
		[Export ("scaleToSize:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleTo (CGSize size, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_Double (class_ptr, Selector.GetHandle ("scaleToSize:duration:"), size, sec), false)!;
			return ret;
		}
		/// <param name="scale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleXTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleXTo (nfloat scale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("scaleXTo:duration:"), scale, sec), false)!;
			return ret;
		}
		/// <param name="scale">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("scaleYTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction ScaleYTo (nfloat scale, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("scaleYTo:duration:"), scale, sec), false)!;
			return ret;
		}
		[Export ("sequence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction Sequence (params SKAction[] actions)
		{
			if (actions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actions));
			using var nsa_actions = NSArray.FromNSObjects (actions);
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("sequence:"), nsa_actions.Handle), false)!;
			return ret;
		}
		[Export ("setNormalTexture:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SetNormalTexture (SKTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setNormalTexture:"), texture__handle__), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		[Export ("setNormalTexture:resize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SetNormalTexture (SKTexture texture, bool resize)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, Selector.GetHandle ("setNormalTexture:resize:"), texture__handle__, resize ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		[Export ("setTexture:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SetTexture (SKTexture texture)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setTexture:"), texture__handle__), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		[Export ("setTexture:resize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SetTexture (SKTexture texture, bool resize)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, Selector.GetHandle ("setTexture:resize:"), texture__handle__, resize ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (texture);
			return ret!;
		}
		/// <param name="speed">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("speedBy:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SpeedBy (nfloat speed, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("speedBy:duration:"), speed, sec), false)!;
			return ret;
		}
		/// <param name="speed">To be added.</param><param name="sec">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("speedTo:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction SpeedTo (nfloat speed, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_Double (class_ptr, Selector.GetHandle ("speedTo:duration:"), speed, sec), false)!;
			return ret;
		}
		[Export ("strengthBy:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction StrengthBy (float strength, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("strengthBy:duration:"), strength, sec), false)!;
			return ret;
		}
		[Export ("strengthTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction StrengthTo (float strength, double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_Double (class_ptr, Selector.GetHandle ("strengthTo:duration:"), strength, sec), false)!;
			return ret;
		}
		[Export ("unhide")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction Unhide ()
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("unhide")), false)!;
			return ret;
		}
		[Export ("waitForDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction WaitForDuration (double sec)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, Selector.GetHandle ("waitForDuration:"), sec), false)!;
			return ret;
		}
		[Export ("waitForDuration:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction WaitForDuration (double sec, double durationRange)
		{
			SKAction ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_Double (class_ptr, Selector.GetHandle ("waitForDuration:withRange:"), sec, durationRange), false)!;
			return ret;
		}
		[Export ("warpTo:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKAction? WarpTo (SKWarpGeometry warp, double duration)
		{
			var warp__handle__ = warp!.GetNonNullHandle (nameof (warp));
			SKAction? ret;
			ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, Selector.GetHandle ("warpTo:duration:"), warp__handle__, duration), false)!;
			GC.KeepAlive (warp);
			return ret!;
		}
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKAction ReversedAction {
			[Export ("reversedAction")]
			get {
				SKAction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reversedAction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reversedAction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public unsafe SKActionTimingFunction? TimingFunction {
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
				return global::ObjCRuntime.Trampolines.NIDSKActionTimingFunction.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKActionTimingFunction))]
			set {
				using var block_value = Trampolines.SDSKActionTimingFunction.CreateNullableBlock (value);
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
		/// <summary>Sets the function that transforms the times at which actions occur.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use 'TimingFunction' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public unsafe virtual SKActionTimingFunction2? TimingFunction2 {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDSKActionTimingFunction2))]
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
				return global::ObjCRuntime.Trampolines.NIDSKActionTimingFunction2.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKActionTimingFunction2))]
			[Export ("setTimingFunction:", ArgumentSemantic.Assign)]
			set {
				using var block_value = Trampolines.SDSKActionTimingFunction2.CreateNullableBlock (value);
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
		public virtual SKActionTimingMode TimingMode {
			[Export ("timingMode")]
			get {
				SKActionTimingMode ret;
				if (IsDirectBinding) {
					ret = (SKActionTimingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("timingMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SKActionTimingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("timingMode"));
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
	} /* class SKAction */
}
