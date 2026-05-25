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
namespace HomeKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:HomeKit.HMHomeManager" /> objects, provides methods that can be overridden to react to <see cref="T:HomeKit.HMHome" />s being added, removed, or set as the primary home.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HomeKit/Reference/HMHomeManagerDelegate_Protocol/index.html">Apple documentation for <c>HMHomeManagerDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "HMHomeManagerDelegate", WrapperType = typeof (HMHomeManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateHomes", Selector = "homeManagerDidUpdateHomes:", ParameterType = new Type [] { typeof (HomeKit.HMHomeManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdatePrimaryHome", Selector = "homeManagerDidUpdatePrimaryHome:", ParameterType = new Type [] { typeof (HomeKit.HMHomeManager) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddHome", Selector = "homeManager:didAddHome:", ParameterType = new Type [] { typeof (HomeKit.HMHomeManager), typeof (HomeKit.HMHome) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveHome", Selector = "homeManager:didRemoveHome:", ParameterType = new Type [] { typeof (HomeKit.HMHomeManager), typeof (HomeKit.HMHome) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateAuthorizationStatus", Selector = "homeManager:didUpdateAuthorizationStatus:", ParameterType = new Type [] { typeof (HomeKit.HMHomeManager), typeof (HomeKit.HMHomeManagerAuthorizationStatus) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IHMHomeManagerDelegate : INativeObject, IDisposable
	{
		/// <param name="manager">To be added.</param><summary>A home in <paramref name="manager" /> was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("homeManagerDidUpdateHomes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateHomes (HMHomeManager manager)
		{
			_DidUpdateHomes (this, manager);
		}
		/// <param name="manager">To be added.</param><summary>A home in <paramref name="manager" /> was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateHomes (IHMHomeManagerDelegate This, HMHomeManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeManagerDidUpdateHomes:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">To be added.</param><summary>The primary home in <paramref name="manager" /> was updated.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("homeManagerDidUpdatePrimaryHome:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdatePrimaryHome (HMHomeManager manager)
		{
			_DidUpdatePrimaryHome (this, manager);
		}
		/// <param name="manager">To be added.</param><summary>The primary home in <paramref name="manager" /> was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdatePrimaryHome (IHMHomeManagerDelegate This, HMHomeManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeManagerDidUpdatePrimaryHome:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">To be added.</param><param name="home">To be added.</param><summary>The <paramref name="home" /> was added to <paramref name="manager" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("homeManager:didAddHome:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddHome (HMHomeManager manager, HMHome home)
		{
			_DidAddHome (this, manager, home);
		}
		/// <param name="manager">To be added.</param><param name="home">To be added.</param><summary>The <paramref name="home" /> was added to <paramref name="manager" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddHome (IHMHomeManagerDelegate This, HMHomeManager manager, HMHome home)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("homeManager:didAddHome:"), manager__handle__, home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (home);
		}
		/// <param name="manager">To be added.</param><param name="home">To be added.</param><summary>The <paramref name="home" /> was removed from <paramref name="manager" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("homeManager:didRemoveHome:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveHome (HMHomeManager manager, HMHome home)
		{
			_DidRemoveHome (this, manager, home);
		}
		/// <param name="manager">To be added.</param><param name="home">To be added.</param><summary>The <paramref name="home" /> was removed from <paramref name="manager" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemoveHome (IHMHomeManagerDelegate This, HMHomeManager manager, HMHome home)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("homeManager:didRemoveHome:"), manager__handle__, home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (home);
		}
		[global::Foundation.OptionalMember]
		[Export ("homeManager:didUpdateAuthorizationStatus:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAuthorizationStatus (HMHomeManager manager, HMHomeManagerAuthorizationStatus status)
		{
			_DidUpdateAuthorizationStatus (this, manager, status);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdateAuthorizationStatus (IHMHomeManagerDelegate This, HMHomeManager manager, HMHomeManagerAuthorizationStatus status)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("homeManager:didUpdateAuthorizationStatus:"), manager__handle__, (UIntPtr) (ulong) status);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		[DynamicDependencyAttribute ("DidAddHome(HomeKit.HMHomeManager,HomeKit.HMHome)")]
		[DynamicDependencyAttribute ("DidRemoveHome(HomeKit.HMHomeManager,HomeKit.HMHome)")]
		[DynamicDependencyAttribute ("DidUpdateAuthorizationStatus(HomeKit.HMHomeManager,HomeKit.HMHomeManagerAuthorizationStatus)")]
		[DynamicDependencyAttribute ("DidUpdateHomes(HomeKit.HMHomeManager)")]
		[DynamicDependencyAttribute ("DidUpdatePrimaryHome(HomeKit.HMHomeManager)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HMHomeManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IHMHomeManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IHMHomeManagerDelegate" /> interface to support all the methods from the HMHomeManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IHMHomeManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original HMHomeManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class HMHomeManagerDelegate_Extensions {
		/// <param name="manager">To be added.</param><summary>A home in <paramref name="manager" /> was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateHomes (this IHMHomeManagerDelegate This, HMHomeManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeManagerDidUpdateHomes:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">To be added.</param><summary>The primary home in <paramref name="manager" /> was updated.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdatePrimaryHome (this IHMHomeManagerDelegate This, HMHomeManager manager)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("homeManagerDidUpdatePrimaryHome:"), manager__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
		/// <param name="manager">To be added.</param><param name="home">To be added.</param><summary>The <paramref name="home" /> was added to <paramref name="manager" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddHome (this IHMHomeManagerDelegate This, HMHomeManager manager, HMHome home)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("homeManager:didAddHome:"), manager__handle__, home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (home);
		}
		/// <param name="manager">To be added.</param><param name="home">To be added.</param><summary>The <paramref name="home" /> was removed from <paramref name="manager" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemoveHome (this IHMHomeManagerDelegate This, HMHomeManager manager, HMHome home)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			var home__handle__ = home!.GetNonNullHandle (nameof (home));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("homeManager:didRemoveHome:"), manager__handle__, home__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
			GC.KeepAlive (home);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdateAuthorizationStatus (this IHMHomeManagerDelegate This, HMHomeManager manager, HMHomeManagerAuthorizationStatus status)
		{
			var manager__handle__ = manager!.GetNonNullHandle (nameof (manager));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("homeManager:didUpdateAuthorizationStatus:"), manager__handle__, (UIntPtr) (ulong) status);
			GC.KeepAlive (This);
			GC.KeepAlive (manager);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class HMHomeManagerDelegateWrapper : BaseWrapper, IHMHomeManagerDelegate {
		public HMHomeManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (HMHomeManagerDelegateWrapper))]
		static HMHomeManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace HomeKit {
	/// <summary>Delegate object for <see cref="T:HomeKit.HMHomeManager" /> objects, provides methods that can be overridden to react to <see cref="T:HomeKit.HMHome" />s being added, removed, or set as the primary home.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/HomeKit/Reference/HMHomeManagerDelegate_Protocol/index.html">Apple documentation for <c>HMHomeManagerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__HomeKit_HMHomeManagerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class HMHomeManagerDelegate : NSObject, IHMHomeManagerDelegate {
		/// <summary>Creates a new <see cref="HMHomeManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public HMHomeManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected HMHomeManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal HMHomeManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="manager">To be added.</param><param name="home">To be added.</param><summary>The <paramref name="home" /> was added to <paramref name="manager" />.</summary><remarks>To be added.</remarks>
		[Export ("homeManager:didAddHome:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddHome (HMHomeManager manager, HMHome home)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">To be added.</param><param name="home">To be added.</param><summary>The <paramref name="home" /> was removed from <paramref name="manager" />.</summary><remarks>To be added.</remarks>
		[Export ("homeManager:didRemoveHome:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemoveHome (HMHomeManager manager, HMHome home)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("homeManager:didUpdateAuthorizationStatus:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateAuthorizationStatus (HMHomeManager manager, HMHomeManagerAuthorizationStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">To be added.</param><summary>A home in <paramref name="manager" /> was updated.</summary><remarks>To be added.</remarks>
		[Export ("homeManagerDidUpdateHomes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdateHomes (HMHomeManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="manager">To be added.</param><summary>The primary home in <paramref name="manager" /> was updated.</summary><remarks>To be added.</remarks>
		[Export ("homeManagerDidUpdatePrimaryHome:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdatePrimaryHome (HMHomeManager manager)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class HMHomeManagerDelegate */
}
