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
	/// <summary>A node in the scene graph.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNNode_Class/index.html">Apple documentation for <c>SCNNode</c></related>
	[Register("SCNNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNNode : NSObject, INSCoding, INSCopying, INSSecureCoding, ISCNActionable, ISCNAnimatable, ISCNBoundingVolume, global::UIKit.IUIFocusEnvironment, global::UIKit.IUIFocusItem {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCNNode");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SCNNode" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCNNode () : base (NSObjectFlag.Empty)
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
		public SCNNode (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SCNNode (NSObjectFlag t) : base (t)
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
		protected internal SCNNode (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Adds <paramref name="scnAnimation" />, identified with the specified <paramref name="key" />.</summary><param name="scnAnimation">The animation to add.</param><param name="key">The animation key.</param><remarks><para>The following example shows how a rotation animation can be added to a <see cref="T:SceneKit.SCNGeometry" /> object:</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var animation = new CABasicAnimation ();
		/// animation.KeyPath = "rotation";
		/// var v = new SCNVector4 (1.0f, 1.0f, 0.0f, (float) (Math.PI * 2.0));
		/// animation.To = NSValue.FromVector (v);
		/// animation.Duration = 5.0f;
		/// animation.RepeatCount = float.MaxValue; //repeat forever
		/// animatableObject.AddAnimation (animation, (NSString) "rotation");
		/// ]]></code></example></remarks>
		[Export ("addAnimation:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnimation (ISCNAnimationProtocol scnAnimation, string? key)
		{
			var scnAnimation__handle__ = scnAnimation!.GetNonNullHandle (nameof (scnAnimation));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addAnimation:forKey:"), scnAnimation__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("addAnimation:forKey:"), scnAnimation__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (scnAnimation);
			CFString.ReleaseNative (nskey);
		}
		[Export ("addAnimationPlayer:forKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnimation (SCNAnimationPlayer player, NSString? key)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var key__handle__ = key.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addAnimationPlayer:forKey:"), player__handle__, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("addAnimationPlayer:forKey:"), player__handle__, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
			GC.KeepAlive (key);
		}
		[Export ("addAudioPlayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAudioPlayer (SCNAudioPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addAudioPlayer:"), player__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addAudioPlayer:"), player__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
		}
		[Export ("addChildNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddChildNode (SCNNode child)
		{
			var child__handle__ = child!.GetNonNullHandle (nameof (child));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addChildNode:"), child__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addChildNode:"), child__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (child);
		}
		[Export ("addParticleSystem:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddParticleSystem (SCNParticleSystem system)
		{
			var system__handle__ = system!.GetNonNullHandle (nameof (system));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addParticleSystem:"), system__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addParticleSystem:"), system__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (system);
		}
		[Export ("clone")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode Clone ()
		{
			SCNNode ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("clone")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("clone")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("convertPosition:fromNode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 ConvertPositionFromNode (SCNVector3 position, SCNNode? node)
		{
			var node__handle__ = node.GetHandle ();
			SCNVector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3_NativeHandle (this.Handle, Selector.GetHandle ("convertPosition:fromNode:"), position, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_SCNVector3_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPosition:fromNode:"), position, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret!;
		}
		[Export ("convertPosition:toNode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 ConvertPositionToNode (SCNVector3 position, SCNNode? node)
		{
			var node__handle__ = node.GetHandle ();
			SCNVector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3_NativeHandle (this.Handle, Selector.GetHandle ("convertPosition:toNode:"), position, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_SCNVector3_NativeHandle (&__objc_super__, Selector.GetHandle ("convertPosition:toNode:"), position, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret!;
		}
		[Export ("convertTransform:fromNode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMatrix4 ConvertTransformFromNode (SCNMatrix4 transform, SCNNode? node)
		{
			var node__handle__ = node.GetHandle ();
			SCNMatrix4 ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend_SCNMatrix4_NativeHandle (this.Handle, Selector.GetHandle ("convertTransform:fromNode:"), transform, node__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend_stret_SCNMatrix4_NativeHandle (this.Handle, Selector.GetHandle ("convertTransform:fromNode:"), transform, node__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper_SCNMatrix4_NativeHandle (&__objc_super__, Selector.GetHandle ("convertTransform:fromNode:"), transform, node__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper_stret_SCNMatrix4_NativeHandle (&__objc_super__, Selector.GetHandle ("convertTransform:fromNode:"), transform, node__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (node);
			return ret!;
		}
		[Export ("convertTransform:toNode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMatrix4 ConvertTransformToNode (SCNMatrix4 transform, SCNNode? node)
		{
			var node__handle__ = node.GetHandle ();
			SCNMatrix4 ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend_SCNMatrix4_NativeHandle (this.Handle, Selector.GetHandle ("convertTransform:toNode:"), transform, node__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend_stret_SCNMatrix4_NativeHandle (this.Handle, Selector.GetHandle ("convertTransform:toNode:"), transform, node__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper_SCNMatrix4_NativeHandle (&__objc_super__, Selector.GetHandle ("convertTransform:toNode:"), transform, node__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper_stret_SCNMatrix4_NativeHandle (&__objc_super__, Selector.GetHandle ("convertTransform:toNode:"), transform, node__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (node);
			return ret!;
		}
		[Export ("convertVector:fromNode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 ConvertVectorFromNode (SCNVector3 vector, SCNNode? node)
		{
			var node__handle__ = node.GetHandle ();
			SCNVector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3_NativeHandle (this.Handle, Selector.GetHandle ("convertVector:fromNode:"), vector, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_SCNVector3_NativeHandle (&__objc_super__, Selector.GetHandle ("convertVector:fromNode:"), vector, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret!;
		}
		[Export ("convertVector:toNode:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 ConvertVectorToNode (SCNVector3 vector, SCNNode? node)
		{
			var node__handle__ = node.GetHandle ();
			SCNVector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend_SCNVector3_NativeHandle (this.Handle, Selector.GetHandle ("convertVector:toNode:"), vector, node__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper_SCNVector3_NativeHandle (&__objc_super__, Selector.GetHandle ("convertVector:toNode:"), vector, node__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (node);
			return ret!;
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
		[Export ("node")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNNode Create ()
		{
			SCNNode ret;
			ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("node")), false)!;
			return ret;
		}
		/// <param name="hint">The focus movement hint.</param><summary>Called when a focus change may soon happen.</summary><remarks>To be added.</remarks>
		[Export ("didHintFocusMovement:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHintFocusMovement (global::UIKit.UIFocusMovementHint hint)
		{
			var hint__handle__ = hint!.GetNonNullHandle (nameof (hint));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didHintFocusMovement:"), hint__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("didHintFocusMovement:"), hint__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (hint);
		}
		/// <param name="context">Metadata for the focus change.</param><param name="coordinator">The <see cref="T:UIKit.UIFocusAnimationCoordinator" /> coordinating the focus-change animations.</param><summary>Delegate method called shortly after focus has changed to a new <see cref="T:UIKit.UIView" />.</summary><remarks>To be added.</remarks>
		[Export ("didUpdateFocusInContext:withAnimationCoordinator:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateFocus (global::UIKit.UIFocusUpdateContext context, global::UIKit.UIFocusAnimationCoordinator coordinator)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("didUpdateFocusInContext:withAnimationCoordinator:"), context__handle__, coordinator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			GC.KeepAlive (coordinator);
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
		[Export ("enumerateChildNodesUsingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateChildNodes ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCNNodeHandler))]SCNNodeHandler handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDSCNNodeHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("enumerateChildNodesUsingBlock:"), (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateChildNodesUsingBlock:"), (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateHierarchyUsingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateHierarchy ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCNNodeHandler))]SCNNodeHandler handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDSCNNodeHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("enumerateHierarchyUsingBlock:"), (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateHierarchyUsingBlock:"), (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("childNodeWithName:recursively:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode? FindChildNode (string childName, bool recursively)
		{
			if (childName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (childName));
			var nschildName = CFString.CreateNative (childName);
			SCNNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("childNodeWithName:recursively:"), nschildName, recursively ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("childNodeWithName:recursively:"), nschildName, recursively ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nschildName);
			return ret!;
		}
		[Export ("childNodesPassingTest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SCNNode[] FindNodes ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCNNodePredicate))]SCNNodePredicate predicate)
		{
			if (predicate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (predicate));
			using var block_predicate = Trampolines.SDSCNNodePredicate.CreateBlock (predicate);
			BlockLiteral *block_ptr_predicate = &block_predicate;
			SCNNode[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SCNNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("childNodesPassingTest:"), (IntPtr) block_ptr_predicate), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SCNNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("childNodesPassingTest:"), (IntPtr) block_ptr_predicate), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("flattenedClone")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode FlattenedClone ()
		{
			SCNNode ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("flattenedClone")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("flattenedClone")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("nodeWithGeometry:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNNode FromGeometry (SCNGeometry? geometry)
		{
			var geometry__handle__ = geometry.GetHandle ();
			SCNNode? ret;
			ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("nodeWithGeometry:"), geometry__handle__), false)!;
			GC.KeepAlive (geometry);
			return ret!;
		}
		[Export ("nodeWithMDLObject:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNNode FromModelObject (global::ModelIO.MDLObject mdlObject)
		{
			var mdlObject__handle__ = mdlObject!.GetNonNullHandle (nameof (mdlObject));
			SCNNode? ret;
			ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("nodeWithMDLObject:"), mdlObject__handle__), false)!;
			GC.KeepAlive (mdlObject);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("actionForKey:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNAction? GetAction (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			SCNAction? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("actionForKey:"), nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SCNAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("actionForKey:"), nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GetAnimationPlayer' instead.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreAnimation.CAAnimation? GetAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			global::CoreAnimation.CAAnimation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::CoreAnimation.CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("animationForKey:"), key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::CoreAnimation.CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("animationForKey:"), key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("animationKeys")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] GetAnimationKeys ()
		{
			NSString[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("animationKeys")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("animationKeys")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("animationPlayerForKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNAnimationPlayer? GetAnimationPlayer (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			SCNAnimationPlayer? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCNAnimationPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("animationPlayerForKey:"), key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SCNAnimationPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("animationPlayerForKey:"), key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("getBoundingBoxMin:max:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetBoundingBox (ref SCNVector3 min, ref SCNVector3 max)
		{
			fixed (SCNVector3* min__pointer = &min) {
			fixed (SCNVector3* max__pointer = &max) {
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (this.Handle, Selector.GetHandle ("getBoundingBoxMin:max:"), min__pointer, max__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_SCNVector3_ref_SCNVector3 (&__objc_super__, Selector.GetHandle ("getBoundingBoxMin:max:"), min__pointer, max__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
			}
			}
		}
		/// <param name="center">To be added.</param><param name="radius">To be added.</param><summary>Returns <see langword="true" />, and fills <paramref name="center" /> and <paramref name="radius" /> with the bounding sphere data, if the geometry object has volume. Otherwise, returns <see langword="false" /> and the parameters are undefined.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("getBoundingSphereCenter:radius:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetBoundingSphere (ref SCNVector3 center, ref nfloat radius)
		{
			fixed (SCNVector3* center__pointer = &center) {
			fixed (nfloat* radius__pointer = &radius) {
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_SCNVector3_ref_NFloat (this.Handle, Selector.GetHandle ("getBoundingSphereCenter:radius:"), center__pointer, radius__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_SCNVector3_ref_NFloat (&__objc_super__, Selector.GetHandle ("getBoundingSphereCenter:radius:"), center__pointer, radius__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
			}
			}
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("hasActions")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasActions ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasActions"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasActions"));
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("hitTestWithSegmentFromPoint:toPoint:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNHitTestResult[] HitTest (SCNVector3 pointA, SCNVector3 pointB, NSDictionary? options)
		{
			var options__handle__ = options.GetHandle ();
			SCNHitTestResult[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<SCNHitTestResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_SCNVector3_SCNVector3_NativeHandle (this.Handle, Selector.GetHandle ("hitTestWithSegmentFromPoint:toPoint:options:"), pointA, pointB, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<SCNHitTestResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_SCNVector3_SCNVector3_NativeHandle (&__objc_super__, Selector.GetHandle ("hitTestWithSegmentFromPoint:toPoint:options:"), pointA, pointB, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="pointA">To be added.</param><param name="pointB">To be added.</param><param name="options"><para>Strongly typed set of options to perform the hit-test detection.</para><para>This parameter can be <see langword="null" />.</para></param><summary>Returns an array of hit test results for descendant nodes that intersect with a line between <paramref name="pointA" /> and <paramref name="pointB" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNHitTestResult[] HitTest (SCNVector3 pointA, SCNVector3 pointB, SCNHitTestOptions? options)
		{
			return HitTest (pointA, pointB, options.GetDictionary ());
		}
		/// <param name="child">To be added.</param><param name="index">To be added.</param><summary>Inserts the provided <paramref name="child" /> node at the specified <paramref name="index" />.</summary><remarks>To be added.</remarks>
		[Export ("insertChildNode:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertChildNode (SCNNode child, nint index)
		{
			var child__handle__ = child!.GetNonNullHandle (nameof (child));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("insertChildNode:atIndex:"), child__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("insertChildNode:atIndex:"), child__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (child);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isAnimationForKeyPaused:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAnimationPaused (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isAnimationForKeyPaused:"), key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isAnimationForKeyPaused:"), key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret != 0;
		}
		[Export ("localRotateBy:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocalRotate (SCNQuaternion rotation)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_SCNQuaternion (this.Handle, Selector.GetHandle ("localRotateBy:"), rotation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNQuaternion (&__objc_super__, Selector.GetHandle ("localRotateBy:"), rotation);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("localTranslateBy:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LocalTranslate (SCNVector3 translation)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, Selector.GetHandle ("localTranslateBy:"), translation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, Selector.GetHandle ("localTranslateBy:"), translation);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("lookAt:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Look (SCNVector3 worldTarget)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, Selector.GetHandle ("lookAt:"), worldTarget);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, Selector.GetHandle ("lookAt:"), worldTarget);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("lookAt:up:localFront:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Look (SCNVector3 worldTarget, SCNVector3 worldUp, SCNVector3 localFront)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3_SCNVector3_SCNVector3 (this.Handle, Selector.GetHandle ("lookAt:up:localFront:"), worldTarget, worldUp, localFront);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3_SCNVector3_SCNVector3 (&__objc_super__, Selector.GetHandle ("lookAt:up:localFront:"), worldTarget, worldUp, localFront);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pauseAnimationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pauseAnimationForKey:"), key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("pauseAnimationForKey:"), key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeActionForKey:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAction (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeActionForKey:"), nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeActionForKey:"), nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAllActions")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllActions ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllActions"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllActions"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAllAnimations")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnimations ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllAnimations"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllAnimations"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllAnimationsWithBlendOutDuration:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnimationsWithBlendOutDuration (nfloat duration)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("removeAllAnimationsWithBlendOutDuration:"), duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("removeAllAnimationsWithBlendOutDuration:"), duration);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllAudioPlayers")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAudioPlayers ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllAudioPlayers"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllAudioPlayers"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllParticleSystems")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllParticleSystems ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllParticleSystems"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllParticleSystems"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeAnimationForKey:"), key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeAnimationForKey:"), key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		/// <param name="key">To be added.</param><param name="duration">To be added.</param><summary>Deprecated. Developers should use <see cref="M:SceneKit.SCNAnimatable.RemoveAnimationUsingBlendOutDuration(Foundation.NSString,System.Runtime.InteropServices.NFloat)" />.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:fadeOutDuration:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimation (NSString key, nfloat duration)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("removeAnimationForKey:fadeOutDuration:"), key__handle__, duration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, Selector.GetHandle ("removeAnimationForKey:fadeOutDuration:"), key__handle__, duration);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		/// <param name="key">The key for the animation to remove.</param><param name="blendOutDuration">The duration, in seconds, over which to blend the animation out.</param><summary>Removes the specified animation, blending it out over the specified duration.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:blendOutDuration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimationUsingBlendOutDuration (NSString key, nfloat blendOutDuration)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_nfloat (this.Handle, Selector.GetHandle ("removeAnimationForKey:blendOutDuration:"), key__handle__, blendOutDuration);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, Selector.GetHandle ("removeAnimationForKey:blendOutDuration:"), key__handle__, blendOutDuration);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		[Export ("removeAudioPlayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAudioPlayer (SCNAudioPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeAudioPlayer:"), player__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeAudioPlayer:"), player__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
		}
		[Export ("removeFromParentNode")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveFromParentNode ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeFromParentNode"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeFromParentNode"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeParticleSystem:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveParticleSystem (SCNParticleSystem system)
		{
			var system__handle__ = system!.GetNonNullHandle (nameof (system));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeParticleSystem:"), system__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeParticleSystem:"), system__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (system);
		}
		[Export ("replaceChildNode:with:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceChildNode (SCNNode child, SCNNode child2)
		{
			var child__handle__ = child!.GetNonNullHandle (nameof (child));
			var child2__handle__ = child2!.GetNonNullHandle (nameof (child2));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceChildNode:with:"), child__handle__, child2__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("replaceChildNode:with:"), child__handle__, child2__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (child);
			GC.KeepAlive (child2);
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resumeAnimationForKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumeAnimation (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("resumeAnimationForKey:"), key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("resumeAnimationForKey:"), key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		[Export ("rotateBy:aroundTarget:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Rotate (SCNQuaternion worldRotation, SCNVector3 worldTarget)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_SCNQuaternion_SCNVector3 (this.Handle, Selector.GetHandle ("rotateBy:aroundTarget:"), worldRotation, worldTarget);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNQuaternion_SCNVector3 (&__objc_super__, Selector.GetHandle ("rotateBy:aroundTarget:"), worldRotation, worldTarget);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="action">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("runAction:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunAction (SCNAction action)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("runAction:"), action__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("runAction:"), action__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
		}
		/// <param name="action">To be added.</param><param name="block"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("runAction:completionHandler:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunAction (SCNAction action, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? block)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			using var block_block = Trampolines.SDAction.CreateNullableBlock (block);
			BlockLiteral *block_ptr_block = null;
			if (block is not null)
				block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("runAction:completionHandler:"), action__handle__, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("runAction:completionHandler:"), action__handle__, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
		}
		/// <param name="action">To be added.</param><param name="key"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("runAction:forKey:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunAction (SCNAction action, string? key)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("runAction:forKey:"), action__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("runAction:forKey:"), action__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
			CFString.ReleaseNative (nskey);
		}
		/// <param name="action">To be added.</param><param name="key"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="block"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("runAction:forKey:completionHandler:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RunAction (SCNAction action, string? key, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? block)
		{
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var nskey = CFString.CreateNative (key);
			using var block_block = Trampolines.SDAction.CreateNullableBlock (block);
			BlockLiteral *block_ptr_block = null;
			if (block is not null)
				block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("runAction:forKey:completionHandler:"), action__handle__, nskey, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("runAction:forKey:completionHandler:"), action__handle__, nskey, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (action);
			CFString.ReleaseNative (nskey);
		}
		/// <param name="min">To be added.</param><param name="max">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setBoundingBoxMin:max:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetBoundingBox (ref SCNVector3 min, ref SCNVector3 max)
		{
			fixed (SCNVector3* min__pointer = &min) {
			fixed (SCNVector3* max__pointer = &max) {
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (this.Handle, Selector.GetHandle ("setBoundingBoxMin:max:"), min__pointer, max__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_ref_SCNVector3_ref_SCNVector3 (&__objc_super__, Selector.GetHandle ("setBoundingBoxMin:max:"), min__pointer, max__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
		}
		/// <summary>When <c>this</c> is the active focus environment, requests a focus update, which can potentially change the <see cref="UIKit.UIViewController.PreferredFocusedView" />. (See also <see cref="UIKit.UIViewController.UpdateFocusIfNeeded" />.)</summary><remarks>To be added.</remarks>
		[Export ("setNeedsFocusUpdate")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsFocusUpdate ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNeedsFocusUpdate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("setNeedsFocusUpdate"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="speed">To be added.</param><param name="key">To be added.</param><summary>Deprecated. Developers should use <see cref="P:SceneKit.SCNAnimationPlayer.Speed" />, instead.</summary><remarks>To be added.</remarks>
		[Export ("setSpeed:forAnimationKey:")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Speed' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSpeed (nfloat speed, NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_NativeHandle (this.Handle, Selector.GetHandle ("setSpeed:forAnimationKey:"), speed, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_NativeHandle (&__objc_super__, Selector.GetHandle ("setSpeed:forAnimationKey:"), speed, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		/// <param name="context">To be added.</param><summary>Called prior to the current object either losing or receiving focus. If either focus environment returns <see langword="false" />, the focus update is canceled.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shouldUpdateFocusInContext:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldUpdateFocus (global::UIKit.UIFocusUpdateContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("shouldUpdateFocusInContext:"), context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
			return ret != 0;
		}
		/// <summary>If any focus environment has a pending update, this method forces an immediate focus update. Unlike <see cref="UIKit.IUIFocusEnvironment.SetNeedsFocusUpdate" />, this method may be called by any <see cref="T:UIKit.IUIFocusEnvironment" />, whether it currently contains focus or not.</summary><remarks>To be added.</remarks>
		[Export ("updateFocusIfNeeded")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFocusIfNeeded ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateFocusIfNeeded"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("updateFocusIfNeeded"));
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string[] ActionKeys {
			[Export ("actionKeys")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("actionKeys")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("actionKeys")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNAudioPlayer[] AudioPlayers {
			[Export ("audioPlayers")]
			get {
				SCNAudioPlayer[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SCNAudioPlayer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("audioPlayers")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SCNAudioPlayer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("audioPlayers")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNCamera? Camera {
			[Export ("camera", ArgumentSemantic.Retain)]
			get {
				SCNCamera? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNCamera> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("camera")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNCamera> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("camera")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCamera:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool CanBecomeFocused {
			[Export ("canBecomeFocused")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canBecomeFocused"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("canBecomeFocused"));
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
		public virtual bool CastsShadow {
			[Export ("castsShadow")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("castsShadow"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("castsShadow"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCastsShadow:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCastsShadow:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setCastsShadow:"), value ? (byte) 1 : (byte) 0);
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
		public virtual nuint CategoryBitMask {
			[Export ("categoryBitMask")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("categoryBitMask"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("categoryBitMask"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCategoryBitMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setCategoryBitMask:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setCategoryBitMask:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode[] ChildNodes {
			[Export ("childNodes")]
			get {
				SCNNode[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SCNNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("childNodes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SCNNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("childNodes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNConstraint[]? Constraints {
			[Export ("constraints", ArgumentSemantic.Copy)]
			get {
				SCNConstraint[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SCNConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("constraints")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SCNConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("constraints")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setConstraints:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setConstraints:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setConstraints:"), nsa_value.GetHandle ());
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
		public virtual SCNVector3 EulerAngles {
			[Export ("eulerAngles")]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, Selector.GetHandle ("eulerAngles"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("eulerAngles"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setEulerAngles:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, Selector.GetHandle ("setEulerAngles:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, Selector.GetHandle ("setEulerAngles:"), value);
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
		public virtual global::CoreImage.CIFilter[]? Filters {
			[Export ("filters", ArgumentSemantic.Copy)]
			get {
				global::CoreImage.CIFilter[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::CoreImage.CIFilter>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("filters")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::CoreImage.CIFilter>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("filters")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFilters:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFilters:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setFilters:"), nsa_value.GetHandle ());
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
		public virtual SCNNodeFocusBehavior FocusBehavior {
			[Export ("focusBehavior", ArgumentSemantic.Assign)]
			get {
				SCNNodeFocusBehavior ret;
				if (IsDirectBinding) {
					ret = (SCNNodeFocusBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("focusBehavior"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNNodeFocusBehavior) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusBehavior"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFocusBehavior:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFocusBehavior:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setFocusBehavior:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual global::UIKit.UIFocusEffect? FocusEffect {
			[Export ("focusEffect", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIFocusEffect? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFocusEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusEffect")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIFocusEffect> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusEffect")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual string? FocusGroupIdentifier {
			[Export ("focusGroupIdentifier")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusGroupIdentifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusGroupIdentifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual global::UIKit.UIFocusGroupPriority FocusGroupPriority {
			[Export ("focusGroupPriority")]
			[UnsupportedOSPlatform ("tvos")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIFocusGroupPriority ret;
				if (IsDirectBinding) {
					ret = (UIFocusGroupPriority) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("focusGroupPriority"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIFocusGroupPriority) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusGroupPriority"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the container that manages focus information for child focus items.</summary><value>The container that manages focus information for child focus items.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::UIKit.IUIFocusItemContainer? FocusItemContainer {
			[Export ("focusItemContainer")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.IUIFocusItemContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::UIKit.IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("focusItemContainer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::UIKit.IUIFocusItemContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusItemContainer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[UnsupportedOSPlatform ("macos")]
		public virtual global::UIKit.UIFocusItemDeferralMode FocusItemDeferralMode {
			[Export ("focusItemDeferralMode")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIFocusItemDeferralMode ret;
				if (IsDirectBinding) {
					ret = (UIFocusItemDeferralMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("focusItemDeferralMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIFocusItemDeferralMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("focusItemDeferralMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Returns the frame in the reference coordinate space of the containing <see cref="T:UIKit.IUIFocusItemContainer" />.</summary><returns>The frame in the reference coordinate space of the containing <see cref="T:UIKit.IUIFocusItemContainer" />.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGRect Frame {
			[Export ("frame")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("frame"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("frame"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("frame"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("frame"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNGeometry? Geometry {
			[Export ("geometry", ArgumentSemantic.Retain)]
			get {
				SCNGeometry? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNGeometry> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("geometry")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNGeometry> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("geometry")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGeometry:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setGeometry:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setGeometry:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets a Boolean value that hides or shows the node's contents.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Hidden {
			[Export ("isHidden")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHidden"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isHidden"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidden:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setHidden:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		public virtual bool IsTransparentFocusItem {
			[Export ("isTransparentFocusItem")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTransparentFocusItem"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isTransparentFocusItem"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNLight? Light {
			[Export ("light", ArgumentSemantic.Retain)]
			get {
				SCNLight? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNLight> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("light")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNLight> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("light")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLight:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLight:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setLight:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static SCNVector3 LocalFront {
			[Export ("localFront")]
			get {
				SCNVector3 ret;
				ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (class_ptr, Selector.GetHandle ("localFront"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static SCNVector3 LocalRight {
			[Export ("localRight")]
			get {
				SCNVector3 ret;
				ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (class_ptr, Selector.GetHandle ("localRight"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static SCNVector3 LocalUp {
			[Export ("localUp")]
			get {
				SCNVector3 ret;
				ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (class_ptr, Selector.GetHandle ("localUp"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNMorpher? Morpher {
			[Export ("morpher", ArgumentSemantic.Retain)]
			get {
				SCNMorpher? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNMorpher> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("morpher")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNMorpher> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("morpher")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMorpher:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMorpher:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMorpher:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNMovabilityHint MovabilityHint {
			[Export ("movabilityHint", ArgumentSemantic.Assign)]
			get {
				SCNMovabilityHint ret;
				if (IsDirectBinding) {
					ret = (SCNMovabilityHint) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("movabilityHint"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SCNMovabilityHint) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("movabilityHint"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMovabilityHint:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMovabilityHint:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setMovabilityHint:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Name {
			[Export ("name", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("name")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setName:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setName:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Opacity {
			[Export ("opacity")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("opacity"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("opacity"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOpacity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setOpacity:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setOpacity:"), value);
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
		public virtual SCNQuaternion Orientation {
			[Export ("orientation")]
			get {
				SCNQuaternion ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNQuaternion_objc_msgSend (this.Handle, Selector.GetHandle ("orientation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNQuaternion_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("orientation"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOrientation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNQuaternion (this.Handle, Selector.GetHandle ("setOrientation:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNQuaternion (&__objc_super__, Selector.GetHandle ("setOrientation:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ParentFocusEnvironment_var;
		/// <summary>Gets the parent focus environment.</summary><value>The parent focus environment.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::UIKit.IUIFocusEnvironment? ParentFocusEnvironment {
			[Export ("parentFocusEnvironment", ArgumentSemantic.Weak)]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.IUIFocusEnvironment? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::UIKit.IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentFocusEnvironment")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::UIKit.IUIFocusEnvironment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("parentFocusEnvironment")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_ParentFocusEnvironment_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode? ParentNode {
			[Export ("parentNode")]
			get {
				SCNNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentNode")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("parentNode")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNParticleSystem[]? ParticleSystems {
			[Export ("particleSystems")]
			get {
				SCNParticleSystem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SCNParticleSystem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("particleSystems")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SCNParticleSystem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("particleSystems")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets a Boolean value that controls whether animations on the node's contents are paused.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNPhysicsBody? PhysicsBody {
			[Export ("physicsBody", ArgumentSemantic.Retain)]
			get {
				SCNPhysicsBody? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("physicsBody")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("physicsBody")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPhysicsBody:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPhysicsBody:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPhysicsBody:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNPhysicsField? PhysicsField {
			[Export ("physicsField", ArgumentSemantic.Retain)]
			get {
				SCNPhysicsField? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNPhysicsField> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("physicsField")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNPhysicsField> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("physicsField")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPhysicsField:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPhysicsField:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPhysicsField:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMatrix4 Pivot {
			[Export ("pivot")]
			get {
				SCNMatrix4 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend (this.Handle, Selector.GetHandle ("pivot"));
					} else {
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend_stret (this.Handle, Selector.GetHandle ("pivot"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pivot"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("pivot"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setPivot:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNMatrix4 (this.Handle, Selector.GetHandle ("setPivot:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNMatrix4 (&__objc_super__, Selector.GetHandle ("setPivot:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 Position {
			[Export ("position")]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, Selector.GetHandle ("position"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("position"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPosition:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, Selector.GetHandle ("setPosition:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, Selector.GetHandle ("setPosition:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the list of focus environments, ordered by priority, that the environment prefers when updating the focus.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::UIKit.IUIFocusEnvironment[] PreferredFocusEnvironments {
			[Export ("preferredFocusEnvironments", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.IUIFocusEnvironment[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IUIFocusEnvironment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFocusEnvironments")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_PreferredFocusedView_var;
		/// <summary>If not <see langword="null" />, indicates the child <see cref="T:UIKit.UIView" /> that should receive focus by default.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[ObsoletedOSPlatform ("tvos10.0", "Use 'PreferredFocusEnvironments' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'PreferredFocusEnvironments' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::UIKit.UIView? PreferredFocusedView {
			[Export ("preferredFocusedView", ArgumentSemantic.Weak)]
			[ObsoletedOSPlatform ("ios12.2", "Use 'PreferredFocusEnvironments' instead.")]
			[ObsoletedOSPlatform ("tvos12.2", "Use 'PreferredFocusEnvironments' instead.")]
			[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'PreferredFocusEnvironments' instead.")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredFocusedView")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredFocusedView")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_PreferredFocusedView_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNNode PresentationNode {
			[Export ("presentationNode")]
			get {
				SCNNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("presentationNode")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("presentationNode")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the rendering delegate for the node.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public ISCNNodeRendererDelegate RendererDelegate {
			get {
				return (WeakRendererDelegate as ISCNNodeRendererDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakRendererDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RenderingOrder {
			[Export ("renderingOrder")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("renderingOrder"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("renderingOrder"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRenderingOrder:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRenderingOrder:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setRenderingOrder:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector4 Rotation {
			[Export ("rotation")]
			get {
				SCNVector4 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNVector4_objc_msgSend (this.Handle, Selector.GetHandle ("rotation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector4_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rotation"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRotation:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector4 (this.Handle, Selector.GetHandle ("setRotation:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector4 (&__objc_super__, Selector.GetHandle ("setRotation:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNVector3 Scale {
			[Export ("scale")]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, Selector.GetHandle ("scale"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("scale"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, Selector.GetHandle ("setScale:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, Selector.GetHandle ("setScale:"), value);
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
		public virtual SCNSkinner? Skinner {
			[Export ("skinner", ArgumentSemantic.Retain)]
			get {
				SCNSkinner? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SCNSkinner> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("skinner")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SCNSkinner> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("skinner")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSkinner:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSkinner:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setSkinner:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMatrix4 Transform {
			[Export ("transform")]
			get {
				SCNMatrix4 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend (this.Handle, Selector.GetHandle ("transform"));
					} else {
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend_stret (this.Handle, Selector.GetHandle ("transform"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("transform"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("transform"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setTransform:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNMatrix4 (this.Handle, Selector.GetHandle ("setTransform:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNMatrix4 (&__objc_super__, Selector.GetHandle ("setTransform:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakRendererDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSObject? WeakRendererDelegate {
			[Export ("rendererDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rendererDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rendererDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakRendererDelegate_var = ret;
				return ret!;
			}
			[Export ("setRendererDelegate:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRendererDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setRendererDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakRendererDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNVector3 WorldFront {
			[Export ("worldFront")]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, Selector.GetHandle ("worldFront"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("worldFront"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SCNQuaternion WorldOrientation {
			[Export ("worldOrientation", ArgumentSemantic.Assign)]
			get {
				SCNQuaternion ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNQuaternion_objc_msgSend (this.Handle, Selector.GetHandle ("worldOrientation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNQuaternion_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("worldOrientation"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setWorldOrientation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNQuaternion (this.Handle, Selector.GetHandle ("setWorldOrientation:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNQuaternion (&__objc_super__, Selector.GetHandle ("setWorldOrientation:"), value);
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
		public virtual SCNVector3 WorldPosition {
			[Export ("worldPosition", ArgumentSemantic.Assign)]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, Selector.GetHandle ("worldPosition"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("worldPosition"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setWorldPosition:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNVector3 (this.Handle, Selector.GetHandle ("setWorldPosition:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNVector3 (&__objc_super__, Selector.GetHandle ("setWorldPosition:"), value);
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
		public virtual SCNVector3 WorldRight {
			[Export ("worldRight")]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, Selector.GetHandle ("worldRight"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("worldRight"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SCNMatrix4 WorldTransform {
			[Export ("worldTransform")]
			get {
				SCNMatrix4 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend (this.Handle, Selector.GetHandle ("worldTransform"));
					} else {
						ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSend_stret (this.Handle, Selector.GetHandle ("worldTransform"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("worldTransform"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.SCNMatrix4_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("worldTransform"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setWorldTransform:")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_SCNMatrix4 (this.Handle, Selector.GetHandle ("setWorldTransform:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_SCNMatrix4 (&__objc_super__, Selector.GetHandle ("setWorldTransform:"), value);
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
		public virtual SCNVector3 WorldUp {
			[Export ("worldUp")]
			get {
				SCNVector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSend (this.Handle, Selector.GetHandle ("worldUp"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.SCNVector3_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("worldUp"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ParentFocusEnvironment_var = null;
				__mt_PreferredFocusedView_var = null;
				__mt_WeakRendererDelegate_var = null;
			}
		}
	} /* class SCNNode */
}
