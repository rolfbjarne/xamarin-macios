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
	/// <summary>This interface represents the Objective-C protocol <c>GKMatchDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKMatchDelegate", WrapperType = typeof (GKMatchDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Failed", Selector = "match:didFailWithError:", ParameterType = new Type [] { typeof (GameKit.GKMatch), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DataReceivedFromPlayer", Selector = "match:didReceiveData:fromRemotePlayer:", ParameterType = new Type [] { typeof (GameKit.GKMatch), typeof (NSData), typeof (GameKit.GKPlayer) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StateChangedForPlayer", Selector = "match:player:didChangeConnectionState:", ParameterType = new Type [] { typeof (GameKit.GKMatch), typeof (GameKit.GKPlayer), typeof (GameKit.GKPlayerConnectionState) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReinviteDisconnectedPlayer", Selector = "match:shouldReinviteDisconnectedPlayer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (GameKit.GKMatch), typeof (GameKit.GKPlayer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DataReceivedForRecipient", Selector = "match:didReceiveData:forRecipient:fromRemotePlayer:", ParameterType = new Type [] { typeof (GameKit.GKMatch), typeof (NSData), typeof (GameKit.GKPlayer), typeof (GameKit.GKPlayer) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IGKMatchDelegate : INativeObject, IDisposable
	{
		/// <param name="match">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when a match cannot connect to any of the players.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("match:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Failed (GKMatch match, NSError? error)
		{
			_Failed (this, match, error);
		}
		/// <param name="match">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when a match cannot connect to any of the players.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Failed (IGKMatchDelegate This, GKMatch match, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("match:didFailWithError:"), match__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (error);
		}
		/// <param name="match">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>Method that is called when data is received from a player.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("match:didReceiveData:fromRemotePlayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DataReceivedFromPlayer (GKMatch match, NSData data, GKPlayer player)
		{
			_DataReceivedFromPlayer (this, match, data, player);
		}
		/// <param name="match">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>Method that is called when data is received from a player.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DataReceivedFromPlayer (IGKMatchDelegate This, GKMatch match, NSData data, GKPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("match:didReceiveData:fromRemotePlayer:"), match__handle__, data__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (data);
			GC.KeepAlive (player);
		}
		/// <param name="match">To be added.</param><param name="player">To be added.</param><param name="state">To be added.</param><summary>Method that is called when a player's connection state changes.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("match:player:didChangeConnectionState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StateChangedForPlayer (GKMatch match, GKPlayer player, GKPlayerConnectionState state)
		{
			_StateChangedForPlayer (this, match, player, state);
		}
		/// <param name="match">To be added.</param><param name="player">To be added.</param><param name="state">To be added.</param><summary>Method that is called when a player's connection state changes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StateChangedForPlayer (IGKMatchDelegate This, GKMatch match, GKPlayer player, GKPlayerConnectionState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("match:player:didChangeConnectionState:"), match__handle__, player__handle__, (IntPtr) (long) state);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (player);
		}
		/// <param name="match">To be added.</param><param name="player">To be added.</param><summary>Method that is called when a player is disconnected from a two-player match.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("match:shouldReinviteDisconnectedPlayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReinviteDisconnectedPlayer (GKMatch match, GKPlayer player)
		{
			return _ShouldReinviteDisconnectedPlayer (this, match, player);
		}
		/// <param name="match">To be added.</param><param name="player">To be added.</param><summary>Method that is called when a player is disconnected from a two-player match.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReinviteDisconnectedPlayer (IGKMatchDelegate This, GKMatch match, GKPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("match:shouldReinviteDisconnectedPlayer:"), match__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (player);
			return ret != 0;
		}
		/// <param name="match">To be added.</param><param name="data">To be added.</param><param name="recipient">To be added.</param><param name="player">To be added.</param><summary>Method that is called when the <paramref name="recipient" /> receives data from another <paramref name="player" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("match:didReceiveData:forRecipient:fromRemotePlayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DataReceivedForRecipient (GKMatch match, NSData data, GKPlayer recipient, GKPlayer player)
		{
			_DataReceivedForRecipient (this, match, data, recipient, player);
		}
		/// <param name="match">To be added.</param><param name="data">To be added.</param><param name="recipient">To be added.</param><param name="player">To be added.</param><summary>Method that is called when the <paramref name="recipient" /> receives data from another <paramref name="player" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DataReceivedForRecipient (IGKMatchDelegate This, GKMatch match, NSData data, GKPlayer recipient, GKPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var recipient__handle__ = recipient!.GetNonNullHandle (nameof (recipient));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("match:didReceiveData:forRecipient:fromRemotePlayer:"), match__handle__, data__handle__, recipient__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (data);
			GC.KeepAlive (recipient);
			GC.KeepAlive (player);
		}
		[DynamicDependencyAttribute ("DataReceivedForRecipient(GameKit.GKMatch,Foundation.NSData,GameKit.GKPlayer,GameKit.GKPlayer)")]
		[DynamicDependencyAttribute ("DataReceivedFromPlayer(GameKit.GKMatch,Foundation.NSData,GameKit.GKPlayer)")]
		[DynamicDependencyAttribute ("Failed(GameKit.GKMatch,Foundation.NSError)")]
		[DynamicDependencyAttribute ("ShouldReinviteDisconnectedPlayer(GameKit.GKMatch,GameKit.GKPlayer)")]
		[DynamicDependencyAttribute ("StateChangedForPlayer(GameKit.GKMatch,GameKit.GKPlayer,GameKit.GKPlayerConnectionState)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKMatchDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKMatchDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKMatchDelegate" /> interface to support all the methods from the GKMatchDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKMatchDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKMatchDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKMatchDelegate_Extensions {
		/// <param name="match">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when a match cannot connect to any of the players.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Failed (this IGKMatchDelegate This, GKMatch match, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("match:didFailWithError:"), match__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (error);
		}
		/// <param name="match">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>Method that is called when data is received from a player.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DataReceivedFromPlayer (this IGKMatchDelegate This, GKMatch match, NSData data, GKPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("match:didReceiveData:fromRemotePlayer:"), match__handle__, data__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (data);
			GC.KeepAlive (player);
		}
		/// <param name="match">To be added.</param><param name="player">To be added.</param><param name="state">To be added.</param><summary>Method that is called when a player's connection state changes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StateChangedForPlayer (this IGKMatchDelegate This, GKMatch match, GKPlayer player, GKPlayerConnectionState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("match:player:didChangeConnectionState:"), match__handle__, player__handle__, (IntPtr) (long) state);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (player);
		}
		/// <param name="match">To be added.</param><param name="player">To be added.</param><summary>Method that is called when a player is disconnected from a two-player match.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReinviteDisconnectedPlayer (this IGKMatchDelegate This, GKMatch match, GKPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("match:shouldReinviteDisconnectedPlayer:"), match__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (player);
			return ret != 0;
		}
		/// <param name="match">To be added.</param><param name="data">To be added.</param><param name="recipient">To be added.</param><param name="player">To be added.</param><summary>Method that is called when the <paramref name="recipient" /> receives data from another <paramref name="player" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DataReceivedForRecipient (this IGKMatchDelegate This, GKMatch match, NSData data, GKPlayer recipient, GKPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var recipient__handle__ = recipient!.GetNonNullHandle (nameof (recipient));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("match:didReceiveData:forRecipient:fromRemotePlayer:"), match__handle__, data__handle__, recipient__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (match);
			GC.KeepAlive (data);
			GC.KeepAlive (recipient);
			GC.KeepAlive (player);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKMatchDelegateWrapper : BaseWrapper, IGKMatchDelegate {
		public GKMatchDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKMatchDelegateWrapper))]
		static GKMatchDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace GameKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IGKMatchDelegate" /> (for the protocol <c>GKMatchDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IGKMatchDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__GameKit_GKMatchDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKMatchDelegate : NSObject, IGKMatchDelegate {
		/// <summary>Creates a new <see cref="GKMatchDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKMatchDelegate () : base (NSObjectFlag.Empty)
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
		protected GKMatchDelegate (NSObjectFlag t) : base (t)
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
		protected internal GKMatchDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="match">To be added.</param><param name="data">To be added.</param><param name="recipient">To be added.</param><param name="player">To be added.</param><summary>Method that is called when the <paramref name="recipient" /> receives data from another <paramref name="player" />.</summary><remarks>To be added.</remarks>
		[Export ("match:didReceiveData:forRecipient:fromRemotePlayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DataReceivedForRecipient (GKMatch match, NSData data, GKPlayer recipient, GKPlayer player)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="match">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>Method that is called when data is received from a player.</summary><remarks>To be added.</remarks>
		[Export ("match:didReceiveData:fromRemotePlayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DataReceivedFromPlayer (GKMatch match, NSData data, GKPlayer player)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="match">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Method that is called when a match cannot connect to any of the players.</summary><remarks>To be added.</remarks>
		[Export ("match:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Failed (GKMatch match, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="match">To be added.</param><param name="player">To be added.</param><summary>Method that is called when a player is disconnected from a two-player match.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("match:shouldReinviteDisconnectedPlayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReinviteDisconnectedPlayer (GKMatch match, GKPlayer player)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="match">To be added.</param><param name="player">To be added.</param><param name="state">To be added.</param><summary>Method that is called when a player's connection state changes.</summary><remarks>To be added.</remarks>
		[Export ("match:player:didChangeConnectionState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StateChangedForPlayer (GKMatch match, GKPlayer player, GKPlayerConnectionState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GKMatchDelegate */
}
