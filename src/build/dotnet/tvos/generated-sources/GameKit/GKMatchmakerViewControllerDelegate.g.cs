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
namespace GameKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>GKMatchmakerViewControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKMatchmakerViewControllerDelegate", WrapperType = typeof (GKMatchmakerViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "matchmakerViewControllerWasCancelled:", ParameterType = new Type [] { typeof (GameKit.GKMatchmakerViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailWithError", Selector = "matchmakerViewController:didFailWithError:", ParameterType = new Type [] { typeof (GameKit.GKMatchmakerViewController), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFindMatch", Selector = "matchmakerViewController:didFindMatch:", ParameterType = new Type [] { typeof (GameKit.GKMatchmakerViewController), typeof (GameKit.GKMatch) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFindHostedPlayers", Selector = "matchmakerViewController:didFindHostedPlayers:", ParameterType = new Type [] { typeof (GameKit.GKMatchmakerViewController), typeof (GameKit.GKPlayer[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HostedPlayerDidAccept", Selector = "matchmakerViewController:hostedPlayerDidAccept:", ParameterType = new Type [] { typeof (GameKit.GKMatchmakerViewController), typeof (GameKit.GKPlayer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMatchProperties", Selector = "matchmakerViewController:getMatchPropertiesForRecipient:withCompletionHandler:", ParameterType = new Type [] { typeof (GameKit.GKMatchmakerViewController), typeof (GameKit.GKPlayer), typeof (global::System.Action<NSDictionary<NSString, NSObject>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V44) })]
	public partial interface IGKMatchmakerViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="viewController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("matchmakerViewControllerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (GKMatchmakerViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WasCancelled (IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewControllerWasCancelled:"), viewController__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
		}
		/// <param name="viewController">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("matchmakerViewController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailWithError (GKMatchmakerViewController viewController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailWithError (IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewController:didFailWithError:"), viewController__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (error);
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("matchmakerViewController:didFindMatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFindMatch (GKMatchmakerViewController viewController, GKMatch match)
		{
			_DidFindMatch (this, viewController, match);
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFindMatch (IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, GKMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewController:didFindMatch:"), viewController__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (match);
		}
		/// <param name="viewController">To be added.</param><param name="playerIDs">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("matchmakerViewController:didFindHostedPlayers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFindHostedPlayers (GKMatchmakerViewController viewController, GKPlayer[] playerIDs)
		{
			_DidFindHostedPlayers (this, viewController, playerIDs);
		}
		/// <param name="viewController">To be added.</param><param name="playerIDs">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFindHostedPlayers (IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, GKPlayer[] playerIDs)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (playerIDs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playerIDs));
			using var nsa_playerIDs = NSArray.FromNSObjects (playerIDs);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewController:didFindHostedPlayers:"), viewController__handle__, nsa_playerIDs.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
		}
		/// <param name="viewController">To be added.</param><param name="playerID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("matchmakerViewController:hostedPlayerDidAccept:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HostedPlayerDidAccept (GKMatchmakerViewController viewController, GKPlayer playerID)
		{
			_HostedPlayerDidAccept (this, viewController, playerID);
		}
		/// <param name="viewController">To be added.</param><param name="playerID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HostedPlayerDidAccept (IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, GKPlayer playerID)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var playerID__handle__ = playerID!.GetNonNullHandle (nameof (playerID));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewController:hostedPlayerDidAccept:"), viewController__handle__, playerID__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (playerID);
		}
		[global::Foundation.OptionalMember]
		[Export ("matchmakerViewController:getMatchPropertiesForRecipient:withCompletionHandler:")]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetMatchProperties (GKMatchmakerViewController viewController, GKPlayer recipient, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V44))]global::System.Action<NSDictionary<NSString, NSObject>> completionHandler)
		{
			_GetMatchProperties (this, viewController, recipient, completionHandler);
		}
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetMatchProperties (IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, GKPlayer recipient, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V44))]global::System.Action<NSDictionary<NSString, NSObject>> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var recipient__handle__ = recipient!.GetNonNullHandle (nameof (recipient));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V44.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewController:getMatchPropertiesForRecipient:withCompletionHandler:"), viewController__handle__, recipient__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (recipient);
		}
		[DynamicDependencyAttribute ("DidFailWithError(GameKit.GKMatchmakerViewController,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFindHostedPlayers(GameKit.GKMatchmakerViewController,GameKit.GKPlayer[])")]
		[DynamicDependencyAttribute ("DidFindMatch(GameKit.GKMatchmakerViewController,GameKit.GKMatch)")]
		[DynamicDependencyAttribute ("GetMatchProperties(GameKit.GKMatchmakerViewController,GameKit.GKPlayer,System.Action{Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject}})")]
		[DynamicDependencyAttribute ("HostedPlayerDidAccept(GameKit.GKMatchmakerViewController,GameKit.GKPlayer)")]
		[DynamicDependencyAttribute ("WasCancelled(GameKit.GKMatchmakerViewController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKMatchmakerViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKMatchmakerViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKMatchmakerViewControllerDelegate" /> interface to support all the methods from the GKMatchmakerViewControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKMatchmakerViewControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKMatchmakerViewControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKMatchmakerViewControllerDelegate_Extensions {
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFindMatch (this IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, GKMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewController:didFindMatch:"), viewController__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (match);
		}
		/// <param name="viewController">To be added.</param><param name="playerIDs">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFindHostedPlayers (this IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, GKPlayer[] playerIDs)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (playerIDs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playerIDs));
			using var nsa_playerIDs = NSArray.FromNSObjects (playerIDs);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewController:didFindHostedPlayers:"), viewController__handle__, nsa_playerIDs.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
		}
		/// <param name="viewController">To be added.</param><param name="playerID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HostedPlayerDidAccept (this IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, GKPlayer playerID)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var playerID__handle__ = playerID!.GetNonNullHandle (nameof (playerID));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewController:hostedPlayerDidAccept:"), viewController__handle__, playerID__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (playerID);
		}
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetMatchProperties (this IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, GKPlayer recipient, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V44))]global::System.Action<NSDictionary<NSString, NSObject>> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var recipient__handle__ = recipient!.GetNonNullHandle (nameof (recipient));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V44.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("matchmakerViewController:getMatchPropertiesForRecipient:withCompletionHandler:"), viewController__handle__, recipient__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (viewController);
			GC.KeepAlive (recipient);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKMatchmakerViewControllerDelegateWrapper : BaseWrapper, IGKMatchmakerViewControllerDelegate {
		public GKMatchmakerViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKMatchmakerViewControllerDelegateWrapper))]
		static GKMatchmakerViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="viewController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("matchmakerViewControllerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WasCancelled (GKMatchmakerViewController viewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("matchmakerViewControllerWasCancelled:"), viewController__handle__);
			GC.KeepAlive (viewController);
		}
		/// <param name="viewController">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("matchmakerViewController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFailWithError (GKMatchmakerViewController viewController, NSError error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("matchmakerViewController:didFailWithError:"), viewController__handle__, error__handle__);
			GC.KeepAlive (viewController);
			GC.KeepAlive (error);
		}
	}
}
namespace GameKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IGKMatchmakerViewControllerDelegate" /> (for the protocol <c>GKMatchmakerViewControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IGKMatchmakerViewControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__GameKit_GKMatchmakerViewControllerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class GKMatchmakerViewControllerDelegate : NSObject, IGKMatchmakerViewControllerDelegate {
		/// <summary>Creates a new <see cref="GKMatchmakerViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GKMatchmakerViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected GKMatchmakerViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal GKMatchmakerViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="viewController">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("matchmakerViewController:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailWithError (GKMatchmakerViewController viewController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><param name="playerIDs">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("matchmakerViewController:didFindHostedPlayers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFindHostedPlayers (GKMatchmakerViewController viewController, GKPlayer[] playerIDs)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("matchmakerViewController:didFindMatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFindMatch (GKMatchmakerViewController viewController, GKMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("matchmakerViewController:getMatchPropertiesForRecipient:withCompletionHandler:")]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetMatchProperties (GKMatchmakerViewController viewController, GKPlayer recipient, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V44))]global::System.Action<NSDictionary<NSString, NSObject>> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><param name="playerID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("matchmakerViewController:hostedPlayerDidAccept:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HostedPlayerDidAccept (GKMatchmakerViewController viewController, GKPlayer playerID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="viewController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("matchmakerViewControllerWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (GKMatchmakerViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GKMatchmakerViewControllerDelegate */
}
