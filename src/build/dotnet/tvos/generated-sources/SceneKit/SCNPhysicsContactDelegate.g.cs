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
	#pragma warning disable CS1573
	/// <summary>Delegate object functions responding to touches between <see cref="T:SceneKit.SCNPhysicsBody" /> objects..</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNPhysicsContactDelegate_Protocol/index.html">Apple documentation for <c>SCNPhysicsContactDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SCNPhysicsContactDelegate", WrapperType = typeof (SCNPhysicsContactDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginContact", Selector = "physicsWorld:didBeginContact:", ParameterType = new Type [] { typeof (SCNPhysicsWorld), typeof (SCNPhysicsContact) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateContact", Selector = "physicsWorld:didUpdateContact:", ParameterType = new Type [] { typeof (SCNPhysicsWorld), typeof (SCNPhysicsContact) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndContact", Selector = "physicsWorld:didEndContact:", ParameterType = new Type [] { typeof (SCNPhysicsWorld), typeof (SCNPhysicsContact) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISCNPhysicsContactDelegate : INativeObject, IDisposable
	{
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("physicsWorld:didBeginContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginContact (SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			_DidBeginContact (this, world, contact);
		}
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginContact (ISCNPhysicsContactDelegate This, SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			var world__handle__ = world!.GetNonNullHandle (nameof (world));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("physicsWorld:didBeginContact:"), world__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (world);
			GC.KeepAlive (contact);
		}
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("physicsWorld:didUpdateContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateContact (SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			_DidUpdateContact (this, world, contact);
		}
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateContact (ISCNPhysicsContactDelegate This, SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			var world__handle__ = world!.GetNonNullHandle (nameof (world));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("physicsWorld:didUpdateContact:"), world__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (world);
			GC.KeepAlive (contact);
		}
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("physicsWorld:didEndContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndContact (SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			_DidEndContact (this, world, contact);
		}
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndContact (ISCNPhysicsContactDelegate This, SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			var world__handle__ = world!.GetNonNullHandle (nameof (world));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("physicsWorld:didEndContact:"), world__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (world);
			GC.KeepAlive (contact);
		}
		[DynamicDependencyAttribute ("DidBeginContact(SceneKit.SCNPhysicsWorld,SceneKit.SCNPhysicsContact)")]
		[DynamicDependencyAttribute ("DidEndContact(SceneKit.SCNPhysicsWorld,SceneKit.SCNPhysicsContact)")]
		[DynamicDependencyAttribute ("DidUpdateContact(SceneKit.SCNPhysicsWorld,SceneKit.SCNPhysicsContact)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNPhysicsContactDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCNPhysicsContactDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISCNPhysicsContactDelegate" /> interface to support all the methods from the SCNPhysicsContactDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISCNPhysicsContactDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SCNPhysicsContactDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SCNPhysicsContactDelegate_Extensions {
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginContact (this ISCNPhysicsContactDelegate This, SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			var world__handle__ = world!.GetNonNullHandle (nameof (world));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("physicsWorld:didBeginContact:"), world__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (world);
			GC.KeepAlive (contact);
		}
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateContact (this ISCNPhysicsContactDelegate This, SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			var world__handle__ = world!.GetNonNullHandle (nameof (world));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("physicsWorld:didUpdateContact:"), world__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (world);
			GC.KeepAlive (contact);
		}
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndContact (this ISCNPhysicsContactDelegate This, SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			var world__handle__ = world!.GetNonNullHandle (nameof (world));
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("physicsWorld:didEndContact:"), world__handle__, contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (world);
			GC.KeepAlive (contact);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCNPhysicsContactDelegateWrapper : BaseWrapper, ISCNPhysicsContactDelegate {
		public SCNPhysicsContactDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNPhysicsContactDelegateWrapper))]
		static SCNPhysicsContactDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SceneKit {
	/// <summary>Delegate object functions responding to touches between <see cref="T:SceneKit.SCNPhysicsBody" /> objects..</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNPhysicsContactDelegate_Protocol/index.html">Apple documentation for <c>SCNPhysicsContactDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__SceneKit_SCNPhysicsContactDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNPhysicsContactDelegate : NSObject, ISCNPhysicsContactDelegate {
		/// <summary>Creates a new <see cref="SCNPhysicsContactDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCNPhysicsContactDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
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
		protected SCNPhysicsContactDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal SCNPhysicsContactDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("physicsWorld:didBeginContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginContact (SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("physicsWorld:didEndContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndContact (SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="world">To be added.</param><param name="contact">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("physicsWorld:didUpdateContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateContact (SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SCNPhysicsContactDelegate */
}
