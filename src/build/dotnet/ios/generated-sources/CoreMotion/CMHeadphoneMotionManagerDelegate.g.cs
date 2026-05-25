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
namespace CoreMotion {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CMHeadphoneMotionManagerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos13.0")]
	[Protocol (Name = "CMHeadphoneMotionManagerDelegate", WrapperType = typeof (CMHeadphoneMotionManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidConnect", Selector = "headphoneMotionManagerDidConnect:", ParameterType = new Type [] { typeof (CMHeadphoneMotionManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDisconnect", Selector = "headphoneMotionManagerDidDisconnect:", ParameterType = new Type [] { typeof (CMHeadphoneMotionManager) }, ParameterByRef = new bool [] { false })]
	public partial interface ICMHeadphoneMotionManagerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("headphoneMotionManagerDidConnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnect (CMHeadphoneMotionManager manager)
		{
			_DidConnect (this, manager);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidConnect (ICMHeadphoneMotionManagerDelegate This, CMHeadphoneMotionManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("headphoneMotionManagerDidConnect:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		[global::Foundation.OptionalMember]
		[Export ("headphoneMotionManagerDidDisconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (CMHeadphoneMotionManager manager)
		{
			_DidDisconnect (this, manager);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDisconnect (ICMHeadphoneMotionManagerDelegate This, CMHeadphoneMotionManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("headphoneMotionManagerDidDisconnect:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		[DynamicDependencyAttribute ("DidConnect(CoreMotion.CMHeadphoneMotionManager)")]
		[DynamicDependencyAttribute ("DidDisconnect(CoreMotion.CMHeadphoneMotionManager)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CMHeadphoneMotionManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICMHeadphoneMotionManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICMHeadphoneMotionManagerDelegate" /> interface to support all the methods from the CMHeadphoneMotionManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICMHeadphoneMotionManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CMHeadphoneMotionManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CMHeadphoneMotionManagerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidConnect (this ICMHeadphoneMotionManagerDelegate This, CMHeadphoneMotionManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("headphoneMotionManagerDidConnect:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDisconnect (this ICMHeadphoneMotionManagerDelegate This, CMHeadphoneMotionManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("headphoneMotionManagerDidDisconnect:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CMHeadphoneMotionManagerDelegateWrapper : BaseWrapper, ICMHeadphoneMotionManagerDelegate {
		public CMHeadphoneMotionManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CMHeadphoneMotionManagerDelegateWrapper))]
		static CMHeadphoneMotionManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CoreMotion {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ICMHeadphoneMotionManagerDelegate" /> (for the protocol <c>CMHeadphoneMotionManagerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ICMHeadphoneMotionManagerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__CoreMotion_CMHeadphoneMotionManagerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos13.0")]
	public unsafe partial class CMHeadphoneMotionManagerDelegate : NSObject, ICMHeadphoneMotionManagerDelegate {
		/// <summary>Creates a new <see cref="CMHeadphoneMotionManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CMHeadphoneMotionManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected CMHeadphoneMotionManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal CMHeadphoneMotionManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("headphoneMotionManagerDidConnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnect (CMHeadphoneMotionManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("headphoneMotionManagerDidDisconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDisconnect (CMHeadphoneMotionManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CMHeadphoneMotionManagerDelegate */
}
