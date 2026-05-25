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
namespace SpriteKit {
	#pragma warning disable CS1573
	/// <summary>A delegate object for <see cref="T:SpriteKit.SKPhysicsWorld" /> that provides events when <see cref="T:SpriteKit.SKPhysicsBody" />s begin and end contact with each other.</summary><remarks><para>The following example reverses gravity when a <see cref="T:SpriteKit.SKPhysicsBody" /> named "Sphere" encounters one of the bodies named either "TopWall" or "BottomWall":</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// public override void DidBeginContact(SKPhysicsContact contact)
	/// {
	/// 	if(contact.BodyA.Node.Name == "Sphere" || contact.BodyB.Node.Name == "Sphere")
	/// 	{
	/// 		if(contact.BodyA.Node.Name == "BottomWall" || contact.BodyB.Node.Name == "BottomWall" || contact.BodyA.Node.Name == "TopWall" || contact.BodyB.Node.Name == "TopWall")
	/// 		{
	/// 			world.Gravity = new CGPoint(0, -world.Gravity.Y);
	/// 		}
	/// 	}
	/// }        
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsContactDelegate_Ref/index.html">Apple documentation for <c>SKPhysicsContactDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SKPhysicsContactDelegate", WrapperType = typeof (SKPhysicsContactDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginContact", Selector = "didBeginContact:", ParameterType = new Type [] { typeof (SKPhysicsContact) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndContact", Selector = "didEndContact:", ParameterType = new Type [] { typeof (SKPhysicsContact) }, ParameterByRef = new bool [] { false })]
	public partial interface ISKPhysicsContactDelegate : INativeObject, IDisposable
	{
		/// <param name="contact">To be added.</param><summary>Method that is called when contact is started.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didBeginContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginContact (SKPhysicsContact contact)
		{
			_DidBeginContact (this, contact);
		}
		/// <param name="contact">To be added.</param><summary>Method that is called when contact is started.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBeginContact (ISKPhysicsContactDelegate This, SKPhysicsContact contact)
		{
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didBeginContact:"), contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contact);
		}
		/// <param name="contact">To be added.</param><summary>Method that is called after contact ends.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didEndContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndContact (SKPhysicsContact contact)
		{
			_DidEndContact (this, contact);
		}
		/// <param name="contact">To be added.</param><summary>Method that is called after contact ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEndContact (ISKPhysicsContactDelegate This, SKPhysicsContact contact)
		{
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didEndContact:"), contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contact);
		}
		[DynamicDependencyAttribute ("DidBeginContact(SpriteKit.SKPhysicsContact)")]
		[DynamicDependencyAttribute ("DidEndContact(SpriteKit.SKPhysicsContact)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKPhysicsContactDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISKPhysicsContactDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISKPhysicsContactDelegate" /> interface to support all the methods from the SKPhysicsContactDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISKPhysicsContactDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SKPhysicsContactDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SKPhysicsContactDelegate_Extensions {
		/// <param name="contact">To be added.</param><summary>Method that is called when contact is started.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBeginContact (this ISKPhysicsContactDelegate This, SKPhysicsContact contact)
		{
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didBeginContact:"), contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contact);
		}
		/// <param name="contact">To be added.</param><summary>Method that is called after contact ends.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEndContact (this ISKPhysicsContactDelegate This, SKPhysicsContact contact)
		{
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didEndContact:"), contact__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contact);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SKPhysicsContactDelegateWrapper : BaseWrapper, ISKPhysicsContactDelegate {
		public SKPhysicsContactDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SKPhysicsContactDelegateWrapper))]
		static SKPhysicsContactDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SpriteKit {
	/// <summary>A delegate object for <see cref="T:SpriteKit.SKPhysicsWorld" /> that provides events when <see cref="T:SpriteKit.SKPhysicsBody" />s begin and end contact with each other.</summary><remarks><para>The following example reverses gravity when a <see cref="T:SpriteKit.SKPhysicsBody" /> named "Sphere" encounters one of the bodies named either "TopWall" or "BottomWall":</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// public override void DidBeginContact(SKPhysicsContact contact)
	/// {
	/// 	if(contact.BodyA.Node.Name == "Sphere" || contact.BodyB.Node.Name == "Sphere")
	/// 	{
	/// 		if(contact.BodyA.Node.Name == "BottomWall" || contact.BodyB.Node.Name == "BottomWall" || contact.BodyA.Node.Name == "TopWall" || contact.BodyB.Node.Name == "TopWall")
	/// 		{
	/// 			world.Gravity = new CGPoint(0, -world.Gravity.Y);
	/// 		}
	/// 	}
	/// }        
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKPhysicsContactDelegate_Ref/index.html">Apple documentation for <c>SKPhysicsContactDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__SpriteKit_SKPhysicsContactDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKPhysicsContactDelegate : NSObject, ISKPhysicsContactDelegate {
		/// <summary>Creates a new <see cref="SKPhysicsContactDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SKPhysicsContactDelegate () : base (NSObjectFlag.Empty)
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
		protected SKPhysicsContactDelegate (NSObjectFlag t) : base (t)
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
		protected internal SKPhysicsContactDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="contact">To be added.</param><summary>Method that is called when contact is started.</summary><remarks>To be added.</remarks>
		[Export ("didBeginContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBeginContact (SKPhysicsContact contact)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="contact">To be added.</param><summary>Method that is called after contact ends.</summary><remarks>To be added.</remarks>
		[Export ("didEndContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEndContact (SKPhysicsContact contact)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SKPhysicsContactDelegate */
}
