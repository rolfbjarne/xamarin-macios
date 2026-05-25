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
namespace GameKit {
	#pragma warning disable CS1573
	/// <summary>A delegate object that is allows fine-grained response to <see cref="T:GameKit.GKTurnBasedEventHandler" /> events.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameKit/Reference/GKTurnBasedEventHandlerDelegate_Ref/index.html">Apple documentation for <c>GKTurnBasedEventHandlerDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
	[ObsoletedOSPlatform ("macos10.10", "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "GKTurnBasedEventHandlerDelegate", WrapperType = typeof (GKTurnBasedEventHandlerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleInviteFromGameCenter", Selector = "handleInviteFromGameCenter:", ParameterType = new Type [] { typeof (NSString[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleTurnEventForMatch", Selector = "handleTurnEventForMatch:", ParameterType = new Type [] { typeof (GameKit.GKTurnBasedMatch) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleMatchEnded", Selector = "handleMatchEnded:", ParameterType = new Type [] { typeof (GameKit.GKTurnBasedMatch) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleTurnEvent", Selector = "handleTurnEventForMatch:didBecomeActive:", ParameterType = new Type [] { typeof (GameKit.GKTurnBasedMatch), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IGKTurnBasedEventHandlerDelegate : INativeObject, IDisposable
	{
		/// <param name="playersToInvite">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleInviteFromGameCenter:")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleInviteFromGameCenter (NSString[] playersToInvite)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="playersToInvite">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleInviteFromGameCenter (IGKTurnBasedEventHandlerDelegate This, NSString[] playersToInvite)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (playersToInvite is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playersToInvite));
			using var nsa_playersToInvite = NSArray.FromNSObjects (playersToInvite);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("handleInviteFromGameCenter:"), nsa_playersToInvite.Handle);
			GC.KeepAlive (This);
		}
		/// <param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("handleTurnEventForMatch:")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'HandleTurnEvent' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'HandleTurnEvent' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HandleTurnEvent' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleTurnEventForMatch (GKTurnBasedMatch match)
		{
			_HandleTurnEventForMatch (this, match);
		}
		/// <param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios7.0", "Use 'HandleTurnEvent' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'HandleTurnEvent' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HandleTurnEvent' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleTurnEventForMatch (IGKTurnBasedEventHandlerDelegate This, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("handleTurnEventForMatch:"), match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
		}
		/// <param name="match">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("handleMatchEnded:")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleMatchEnded (GKTurnBasedMatch match)
		{
			_HandleMatchEnded (this, match);
		}
		/// <param name="match">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleMatchEnded (IGKTurnBasedEventHandlerDelegate This, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("handleMatchEnded:"), match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
		}
		/// <param name="match">To be added.</param><param name="activated">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleTurnEventForMatch:didBecomeActive:")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleTurnEvent (GKTurnBasedMatch match, bool activated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="match">To be added.</param><param name="activated">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleTurnEvent (IGKTurnBasedEventHandlerDelegate This, GKTurnBasedMatch match, bool activated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("handleTurnEventForMatch:didBecomeActive:"), match__handle__, activated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
		}
		[DynamicDependencyAttribute ("HandleInviteFromGameCenter(Foundation.NSString[])")]
		[DynamicDependencyAttribute ("HandleMatchEnded(GameKit.GKTurnBasedMatch)")]
		[DynamicDependencyAttribute ("HandleTurnEvent(GameKit.GKTurnBasedMatch,System.Boolean)")]
		[DynamicDependencyAttribute ("HandleTurnEventForMatch(GameKit.GKTurnBasedMatch)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKTurnBasedEventHandlerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKTurnBasedEventHandlerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKTurnBasedEventHandlerDelegate" /> interface to support all the methods from the GKTurnBasedEventHandlerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKTurnBasedEventHandlerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKTurnBasedEventHandlerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKTurnBasedEventHandlerDelegate_Extensions {
		/// <param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios7.0", "Use 'HandleTurnEvent' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'HandleTurnEvent' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HandleTurnEvent' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleTurnEventForMatch (this IGKTurnBasedEventHandlerDelegate This, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("handleTurnEventForMatch:"), match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
		}
		/// <param name="match">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleMatchEnded (this IGKTurnBasedEventHandlerDelegate This, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("handleMatchEnded:"), match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKTurnBasedEventHandlerDelegateWrapper : BaseWrapper, IGKTurnBasedEventHandlerDelegate {
		public GKTurnBasedEventHandlerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKTurnBasedEventHandlerDelegateWrapper))]
		static GKTurnBasedEventHandlerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="playersToInvite">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[Export ("handleInviteFromGameCenter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HandleInviteFromGameCenter (NSString[] playersToInvite)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (playersToInvite is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playersToInvite));
			using var nsa_playersToInvite = NSArray.FromNSObjects (playersToInvite);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("handleInviteFromGameCenter:"), nsa_playersToInvite.Handle);
		}
		/// <param name="match">To be added.</param><param name="activated">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("handleTurnEventForMatch:didBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HandleTurnEvent (GKTurnBasedMatch match, bool activated)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("handleTurnEventForMatch:didBecomeActive:"), match__handle__, activated ? (byte) 1 : (byte) 0);
			GC.KeepAlive (match);
		}
	}
}
namespace GameKit {
	/// <summary>A delegate object that is allows fine-grained response to <see cref="T:GameKit.GKTurnBasedEventHandler" /> events.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameKit/Reference/GKTurnBasedEventHandlerDelegate_Ref/index.html">Apple documentation for <c>GKTurnBasedEventHandlerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__GameKit_GKTurnBasedEventHandlerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
	[ObsoletedOSPlatform ("macos10.10", "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class GKTurnBasedEventHandlerDelegate : NSObject, IGKTurnBasedEventHandlerDelegate {
		/// <summary>Creates a new <see cref="GKTurnBasedEventHandlerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GKTurnBasedEventHandlerDelegate () : base (NSObjectFlag.Empty)
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
		protected GKTurnBasedEventHandlerDelegate (NSObjectFlag t) : base (t)
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
		protected internal GKTurnBasedEventHandlerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="playersToInvite">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[Export ("handleInviteFromGameCenter:")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleInviteFromGameCenter (NSString[] playersToInvite)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="match">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[Export ("handleMatchEnded:")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleMatchEnded (GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="match">To be added.</param><param name="activated">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("handleTurnEventForMatch:didBecomeActive:")]
		[ObsoletedOSPlatform ("ios6.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleTurnEvent (GKTurnBasedMatch match, bool activated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="match">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("handleTurnEventForMatch:")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'HandleTurnEvent' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'HandleTurnEvent' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'HandleTurnEvent' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleTurnEventForMatch (GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GKTurnBasedEventHandlerDelegate */
}
