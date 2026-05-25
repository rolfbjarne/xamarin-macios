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
namespace SpriteKit {
	/// <summary>Manages the physics for a <see cref="T:SpriteKit.SKScene" />.</summary><remarks><para>Every <see cref="T:SpriteKit.SKScene" /> has a <see cref="P:SpriteKit.SKScene.PhysicsWorld" /> property that holds a <see cref="T:SpriteKit.SKPhysicsWorld" /> object that manages the physics for that scene.</para><para>The <see cref="T:SpriteKit.SKPhysicsWorld" /> has several responsibilities:</para><para><list type="bullet"><item><term>Providing global values such as <see cref="P:SpriteKit.SKPhysicsWorld.Gravity" />.</term></item><item><term>Connecting <see cref="T:SpriteKit.SKPhysicsBody" />s with the <see cref="M:SpriteKit.SKPhysicsWorld.AddJoint(SpriteKit.SKPhysicsJoint)" /> method.</term></item><item><term>Raising events when <see cref="T:SpriteKit.SKPhysicsBody" /> begin or end contact with each other (see the <see cref="P:SpriteKit.SKPhysicsWorld.ContactDelegate" /> property and the <see cref="SpriteKit.SKPhysicsWorld.DidBeginContact" /> and <see cref="SpriteKit.SKPhysicsWorld.DidEndContact" /> methods).</term></item><item><term>Enumerating bodies that intersect geometry (<see cref="M:SpriteKit.SKPhysicsWorld.EnumerateBodies(CoreGraphics.CGPoint,CoreGraphics.CGPoint,SpriteKit.SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler)" /> and <see cref="M:SpriteKit.SKPhysicsWorld.GetBody(CoreGraphics.CGPoint,CoreGraphics.CGPoint)" /> methods).</term></item></list></para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsWorld_Ref/index.html">Apple documentation for <c>SKPhysicsWorld</c></related>
	[Register("SKPhysicsWorld", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKPhysicsWorld : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKPhysicsWorld");
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
		public SKPhysicsWorld (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SKPhysicsWorld (NSObjectFlag t) : base (t)
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
		protected internal SKPhysicsWorld (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addJoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddJoint (SKPhysicsJoint joint)
		{
			var joint__handle__ = joint!.GetNonNullHandle (nameof (joint));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addJoint:"), joint__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addJoint:"), joint__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (joint);
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
		[Export ("enumerateBodiesAtPoint:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateBodies (CGPoint point, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKPhysicsWorldBodiesEnumeratorHandler))]SKPhysicsWorldBodiesEnumeratorHandler enumeratorHandler)
		{
			if (enumeratorHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumeratorHandler));
			using var block_enumeratorHandler = Trampolines.SDSKPhysicsWorldBodiesEnumeratorHandler.CreateBlock (enumeratorHandler);
			BlockLiteral *block_ptr_enumeratorHandler = &block_enumeratorHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("enumerateBodiesAtPoint:usingBlock:"), point, (IntPtr) block_ptr_enumeratorHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateBodiesAtPoint:usingBlock:"), point, (IntPtr) block_ptr_enumeratorHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateBodiesInRect:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateBodies (CGRect rect, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKPhysicsWorldBodiesEnumeratorHandler))]SKPhysicsWorldBodiesEnumeratorHandler enumeratorHandler)
		{
			if (enumeratorHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumeratorHandler));
			using var block_enumeratorHandler = Trampolines.SDSKPhysicsWorldBodiesEnumeratorHandler.CreateBlock (enumeratorHandler);
			BlockLiteral *block_ptr_enumeratorHandler = &block_enumeratorHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("enumerateBodiesInRect:usingBlock:"), rect, (IntPtr) block_ptr_enumeratorHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateBodiesInRect:usingBlock:"), rect, (IntPtr) block_ptr_enumeratorHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateBodiesAlongRayStart:end:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateBodies (CGPoint start, CGPoint end, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler))]SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler enumeratorHandler)
		{
			if (enumeratorHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumeratorHandler));
			using var block_enumeratorHandler = Trampolines.SDSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler.CreateBlock (enumeratorHandler);
			BlockLiteral *block_ptr_enumeratorHandler = &block_enumeratorHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("enumerateBodiesAlongRayStart:end:usingBlock:"), start, end, (IntPtr) block_ptr_enumeratorHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateBodiesAlongRayStart:end:usingBlock:"), start, end, (IntPtr) block_ptr_enumeratorHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("bodyAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKPhysicsBody? GetBody (CGPoint point)
		{
			SKPhysicsBody ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("bodyAtPoint:"), point), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("bodyAtPoint:"), point), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("bodyInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKPhysicsBody? GetBody (CGRect rect)
		{
			SKPhysicsBody ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("bodyInRect:"), rect), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("bodyInRect:"), rect), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("bodyAlongRayStart:end:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKPhysicsBody? GetBody (CGPoint rayStart, CGPoint rayEnd)
		{
			SKPhysicsBody ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint_CGPoint (this.Handle, Selector.GetHandle ("bodyAlongRayStart:end:"), rayStart, rayEnd), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKPhysicsBody> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint_CGPoint (&__objc_super__, Selector.GetHandle ("bodyAlongRayStart:end:"), rayStart, rayEnd), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("removeAllJoints")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllJoints ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllJoints"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllJoints"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeJoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveJoint (SKPhysicsJoint joint)
		{
			var joint__handle__ = joint!.GetNonNullHandle (nameof (joint));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeJoint:"), joint__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeJoint:"), joint__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (joint);
		}
		[Export ("sampleFieldsAt:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 SampleFields (global::System.Numerics.Vector3 position)
		{
			global::System.Numerics.Vector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend_Vector3 (this.Handle, Selector.GetHandle ("sampleFieldsAt:"), position);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Vector3 (&__objc_super__, Selector.GetHandle ("sampleFieldsAt:"), position);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>A delegate object that can handle events relating to collisions between the physics bodies in the simulation.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ISKPhysicsContactDelegate ContactDelegate {
			get {
				return (WeakContactDelegate as ISKPhysicsContactDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakContactDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGVector Gravity {
			[Export ("gravity")]
			get {
				CGVector ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGVector_objc_msgSend (this.Handle, Selector.GetHandle ("gravity"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGVector_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("gravity"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGravity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGVector (this.Handle, Selector.GetHandle ("setGravity:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGVector (&__objc_super__, Selector.GetHandle ("setGravity:"), value);
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
		object? __mt_WeakContactDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakContactDelegate {
			[Export ("contactDelegate", ArgumentSemantic.Assign)]
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
			[Export ("setContactDelegate:", ArgumentSemantic.Assign)]
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
			get { return typeof (_SKPhysicsContactDelegate); }
		}
		internal virtual _SKPhysicsContactDelegate CreateInternalEventContactDelegateType ()
		{
			return (_SKPhysicsContactDelegate)(new _SKPhysicsContactDelegate());
		}
		internal _SKPhysicsContactDelegate EnsureSKPhysicsContactDelegate ()
		{
			if (WeakContactDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakContactDelegate, GetInternalEventContactDelegateType);
			var del = ContactDelegate as _SKPhysicsContactDelegate;
			if (del is null){
				del = (_SKPhysicsContactDelegate)CreateInternalEventContactDelegateType ();
				ContactDelegate = (ISKPhysicsContactDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _SKPhysicsContactDelegate : NSObject, ISKPhysicsContactDelegate { 
			public _SKPhysicsContactDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_SKPhysicsContactDelegate))]
			static _SKPhysicsContactDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler? didBeginContact;
			[Export ("didBeginContact:")]
			public void DidBeginContact (SKPhysicsContact contact)
			{
				var handler = didBeginContact;
				if (handler is not null){
					handler (contact, EventArgs.Empty);
				}
			}
			internal EventHandler? didEndContact;
			[Export ("didEndContact:")]
			public void DidEndContact (SKPhysicsContact contact)
			{
				var handler = didEndContact;
				if (handler is not null){
					handler (contact, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakContactDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidBeginContact {
			add { EnsureSKPhysicsContactDelegate ()!.didBeginContact += value; }
			remove { EnsureSKPhysicsContactDelegate ()!.didBeginContact -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakContactDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler DidEndContact {
			add { EnsureSKPhysicsContactDelegate ()!.didEndContact += value; }
			remove { EnsureSKPhysicsContactDelegate ()!.didEndContact -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakContactDelegate_var = null;
			}
		}
	} /* class SKPhysicsWorld */
}
