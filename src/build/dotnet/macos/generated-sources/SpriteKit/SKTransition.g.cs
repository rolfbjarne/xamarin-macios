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
namespace SpriteKit {
	/// <summary>Transitions that can be used between <see cref="T:SpriteKit.SKScene" />s. Used with the <see cref="M:SpriteKit.SKView.PresentScene(SpriteKit.SKScene,SpriteKit.SKTransition)" /> method.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKTransition_Ref/index.html">Apple documentation for <c>SKTransition</c></related>
	[Register("SKTransition", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKTransition : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCrossFadeWithDuration_X = "crossFadeWithDuration:";
		static readonly NativeHandle selCrossFadeWithDuration_XHandle = Selector.GetHandle ("crossFadeWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoorsCloseHorizontalWithDuration_X = "doorsCloseHorizontalWithDuration:";
		static readonly NativeHandle selDoorsCloseHorizontalWithDuration_XHandle = Selector.GetHandle ("doorsCloseHorizontalWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoorsCloseVerticalWithDuration_X = "doorsCloseVerticalWithDuration:";
		static readonly NativeHandle selDoorsCloseVerticalWithDuration_XHandle = Selector.GetHandle ("doorsCloseVerticalWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoorsOpenHorizontalWithDuration_X = "doorsOpenHorizontalWithDuration:";
		static readonly NativeHandle selDoorsOpenHorizontalWithDuration_XHandle = Selector.GetHandle ("doorsOpenHorizontalWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoorsOpenVerticalWithDuration_X = "doorsOpenVerticalWithDuration:";
		static readonly NativeHandle selDoorsOpenVerticalWithDuration_XHandle = Selector.GetHandle ("doorsOpenVerticalWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoorwayWithDuration_X = "doorwayWithDuration:";
		static readonly NativeHandle selDoorwayWithDuration_XHandle = Selector.GetHandle ("doorwayWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFadeWithColor_Duration_X = "fadeWithColor:duration:";
		static readonly NativeHandle selFadeWithColor_Duration_XHandle = Selector.GetHandle ("fadeWithColor:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFadeWithDuration_X = "fadeWithDuration:";
		static readonly NativeHandle selFadeWithDuration_XHandle = Selector.GetHandle ("fadeWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlipHorizontalWithDuration_X = "flipHorizontalWithDuration:";
		static readonly NativeHandle selFlipHorizontalWithDuration_XHandle = Selector.GetHandle ("flipHorizontalWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlipVerticalWithDuration_X = "flipVerticalWithDuration:";
		static readonly NativeHandle selFlipVerticalWithDuration_XHandle = Selector.GetHandle ("flipVerticalWithDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveInWithDirection_Duration_X = "moveInWithDirection:duration:";
		static readonly NativeHandle selMoveInWithDirection_Duration_XHandle = Selector.GetHandle ("moveInWithDirection:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPausesIncomingSceneX = "pausesIncomingScene";
		static readonly NativeHandle selPausesIncomingSceneXHandle = Selector.GetHandle ("pausesIncomingScene");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPausesOutgoingSceneX = "pausesOutgoingScene";
		static readonly NativeHandle selPausesOutgoingSceneXHandle = Selector.GetHandle ("pausesOutgoingScene");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPushWithDirection_Duration_X = "pushWithDirection:duration:";
		static readonly NativeHandle selPushWithDirection_Duration_XHandle = Selector.GetHandle ("pushWithDirection:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRevealWithDirection_Duration_X = "revealWithDirection:duration:";
		static readonly NativeHandle selRevealWithDirection_Duration_XHandle = Selector.GetHandle ("revealWithDirection:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPausesIncomingScene_X = "setPausesIncomingScene:";
		static readonly NativeHandle selSetPausesIncomingScene_XHandle = Selector.GetHandle ("setPausesIncomingScene:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPausesOutgoingScene_X = "setPausesOutgoingScene:";
		static readonly NativeHandle selSetPausesOutgoingScene_XHandle = Selector.GetHandle ("setPausesOutgoingScene:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransitionWithCIFilter_Duration_X = "transitionWithCIFilter:duration:";
		static readonly NativeHandle selTransitionWithCIFilter_Duration_XHandle = Selector.GetHandle ("transitionWithCIFilter:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKTransition");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected SKTransition (NSObjectFlag t) : base (t)
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
		protected internal SKTransition (NativeHandle handle) : base (handle)
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("crossFadeWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition CrossFadeWithDuration (double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selCrossFadeWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("doorsCloseHorizontalWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition DoorsCloseHorizontalWithDuration (double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selDoorsCloseHorizontalWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("doorsCloseVerticalWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition DoorsCloseVerticalWithDuration (double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selDoorsCloseVerticalWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("doorsOpenHorizontalWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition DoorsOpenHorizontalWithDuration (double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selDoorsOpenHorizontalWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("doorsOpenVerticalWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition DoorsOpenVerticalWithDuration (double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selDoorsOpenVerticalWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("doorwayWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition DoorwayWithDuration (double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selDoorwayWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("fadeWithColor:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition FadeWithColor (global::AppKit.NSColor color, double sec)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			SKTransition? ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selFadeWithColor_Duration_XHandle, color__handle__, sec), false)!;
			GC.KeepAlive (color);
			return ret!;
		}
		[Export ("fadeWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition FadeWithDuration (double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selFadeWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("flipHorizontalWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition FlipHorizontalWithDuration (double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selFlipHorizontalWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("flipVerticalWithDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition FlipVerticalWithDuration (double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selFlipVerticalWithDuration_XHandle, sec), false)!;
			return ret;
		}
		[Export ("moveInWithDirection:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition MoveInWithDirection (SKTransitionDirection direction, double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_Double (class_ptr, selMoveInWithDirection_Duration_XHandle, (IntPtr) (long) direction, sec), false)!;
			return ret;
		}
		[Export ("pushWithDirection:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition PushWithDirection (SKTransitionDirection direction, double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_Double (class_ptr, selPushWithDirection_Duration_XHandle, (IntPtr) (long) direction, sec), false)!;
			return ret;
		}
		[Export ("revealWithDirection:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition RevealWithDirection (SKTransitionDirection direction, double sec)
		{
			SKTransition ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_Double (class_ptr, selRevealWithDirection_Duration_XHandle, (IntPtr) (long) direction, sec), false)!;
			return ret;
		}
		[Export ("transitionWithCIFilter:duration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTransition TransitionWithCIFilter (global::CoreImage.CIFilter filter, double sec)
		{
			var filter__handle__ = filter!.GetNonNullHandle (nameof (filter));
			SKTransition? ret;
			ret =  Runtime.GetNSObject<SKTransition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selTransitionWithCIFilter_Duration_XHandle, filter__handle__, sec), false)!;
			GC.KeepAlive (filter);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PausesIncomingScene {
			[Export ("pausesIncomingScene")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPausesIncomingSceneXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPausesIncomingSceneXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPausesIncomingScene:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPausesIncomingScene_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPausesIncomingScene_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PausesOutgoingScene {
			[Export ("pausesOutgoingScene")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPausesOutgoingSceneXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPausesOutgoingSceneXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPausesOutgoingScene:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPausesOutgoingScene_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPausesOutgoingScene_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class SKTransition */
}
