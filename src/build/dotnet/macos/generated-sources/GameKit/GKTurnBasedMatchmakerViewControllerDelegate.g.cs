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
namespace GameKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>GKTurnBasedMatchmakerViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKTurnBasedMatchmakerViewControllerDelegate", WrapperType = typeof (GKTurnBasedMatchmakerViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "turnBasedMatchmakerViewControllerWasCancelled:", ParameterType = new Type [] { typeof (GameKit.GKTurnBasedMatchmakerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "turnBasedMatchmakerViewController:didFailWithError:", ParameterType = new Type [] { typeof (GameKit.GKTurnBasedMatchmakerViewController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FoundMatch", Selector = "turnBasedMatchmakerViewController:didFindMatch:", ParameterType = new Type [] { typeof (GameKit.GKTurnBasedMatchmakerViewController), typeof (GameKit.GKTurnBasedMatch) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PlayerQuitForMatch", Selector = "turnBasedMatchmakerViewController:playerQuitForMatch:", ParameterType = new Type [] { typeof (GameKit.GKTurnBasedMatchmakerViewController), typeof (GameKit.GKTurnBasedMatch) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IGKTurnBasedMatchmakerViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="viewController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("turnBasedMatchmakerViewControllerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (GKTurnBasedMatchmakerViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WasCancelled (IGKTurnBasedMatchmakerViewControllerDelegate This, GKTurnBasedMatchmakerViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("turnBasedMatchmakerViewControllerWasCancelled:"), viewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
		}
		/// <param name="viewController">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("turnBasedMatchmakerViewController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedWithError (GKTurnBasedMatchmakerViewController viewController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedWithError (IGKTurnBasedMatchmakerViewControllerDelegate This, GKTurnBasedMatchmakerViewController viewController, NSError error)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("turnBasedMatchmakerViewController:didFailWithError:"), viewController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (error);
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("turnBasedMatchmakerViewController:didFindMatch:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FoundMatch (GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
		{
			_FoundMatch (this, viewController, match);
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FoundMatch (IGKTurnBasedMatchmakerViewControllerDelegate This, GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("turnBasedMatchmakerViewController:didFindMatch:"), viewController__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (match);
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("turnBasedMatchmakerViewController:playerQuitForMatch:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayerQuitForMatch (GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
		{
			_PlayerQuitForMatch (this, viewController, match);
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PlayerQuitForMatch (IGKTurnBasedMatchmakerViewControllerDelegate This, GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("turnBasedMatchmakerViewController:playerQuitForMatch:"), viewController__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (match);
		}
		[DynamicDependencyAttribute ("FailedWithError(GameKit.GKTurnBasedMatchmakerViewController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FoundMatch(GameKit.GKTurnBasedMatchmakerViewController,GameKit.GKTurnBasedMatch)")]
		[DynamicDependencyAttribute ("PlayerQuitForMatch(GameKit.GKTurnBasedMatchmakerViewController,GameKit.GKTurnBasedMatch)")]
		[DynamicDependencyAttribute ("WasCancelled(GameKit.GKTurnBasedMatchmakerViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKTurnBasedMatchmakerViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKTurnBasedMatchmakerViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKTurnBasedMatchmakerViewControllerDelegate" /> interface to support all the methods from the GKTurnBasedMatchmakerViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKTurnBasedMatchmakerViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKTurnBasedMatchmakerViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKTurnBasedMatchmakerViewControllerDelegate_Extensions {
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FoundMatch (this IGKTurnBasedMatchmakerViewControllerDelegate This, GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("turnBasedMatchmakerViewController:didFindMatch:"), viewController__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (match);
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PlayerQuitForMatch (this IGKTurnBasedMatchmakerViewControllerDelegate This, GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("turnBasedMatchmakerViewController:playerQuitForMatch:"), viewController__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (match);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKTurnBasedMatchmakerViewControllerDelegateWrapper : BaseWrapper, IGKTurnBasedMatchmakerViewControllerDelegate {
		public GKTurnBasedMatchmakerViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKTurnBasedMatchmakerViewControllerDelegateWrapper))]
		static GKTurnBasedMatchmakerViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="viewController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("turnBasedMatchmakerViewControllerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WasCancelled (GKTurnBasedMatchmakerViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("turnBasedMatchmakerViewControllerWasCancelled:"), viewController__handle__);
			GC.KeepAlive (viewController);
		}
		/// <param name="viewController">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("turnBasedMatchmakerViewController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FailedWithError (GKTurnBasedMatchmakerViewController viewController, NSError error)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("turnBasedMatchmakerViewController:didFailWithError:"), viewController__handle__, error__handle__);
			GC.KeepAlive (viewController);
			GC.KeepAlive (error);
		}
	}
}
namespace GameKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IGKTurnBasedMatchmakerViewControllerDelegate" /> (for the protocol <c>GKTurnBasedMatchmakerViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IGKTurnBasedMatchmakerViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__GameKit_GKTurnBasedMatchmakerViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class GKTurnBasedMatchmakerViewControllerDelegate : NSObject, IGKTurnBasedMatchmakerViewControllerDelegate {
		/// <summary>Creates a new <see cref="GKTurnBasedMatchmakerViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GKTurnBasedMatchmakerViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected GKTurnBasedMatchmakerViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal GKTurnBasedMatchmakerViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="viewController">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("turnBasedMatchmakerViewController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedWithError (GKTurnBasedMatchmakerViewController viewController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.</summary><remarks>To be added.</remarks>
		[Export ("turnBasedMatchmakerViewController:didFindMatch:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FoundMatch (GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("turnBasedMatchmakerViewController:playerQuitForMatch:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[ObsoletedOSPlatform ("macos10.11", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayerQuitForMatch (GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("turnBasedMatchmakerViewControllerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (GKTurnBasedMatchmakerViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GKTurnBasedMatchmakerViewControllerDelegate */
}
