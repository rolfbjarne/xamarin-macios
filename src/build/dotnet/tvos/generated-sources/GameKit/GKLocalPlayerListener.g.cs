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
	/// <summary>This interface represents the Objective-C protocol <c>GKLocalPlayerListener</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKLocalPlayerListener", WrapperType = typeof (GKLocalPlayerListenerWrapper))]
	public partial interface IGKLocalPlayerListener : INativeObject, IDisposable, 
		GameKit.IGKChallengeListener
		, GameKit.IGKInviteEventListener
		, GameKit.IGKTurnBasedEventListener
	{
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKLocalPlayerListenerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKLocalPlayerListener ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKLocalPlayerListenerWrapper : BaseWrapper, IGKLocalPlayerListener {
		public GKLocalPlayerListenerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKLocalPlayerListenerWrapper))]
		static GKLocalPlayerListenerWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace GameKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IGKLocalPlayerListener" /> (for the protocol <c>GKLocalPlayerListener</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IGKLocalPlayerListener" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__GameKit_GKLocalPlayerListener", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKLocalPlayerListener : NSObject, IGKLocalPlayerListener, IGKChallengeListener, IGKInviteEventListener, IGKTurnBasedEventListener {
		/// <summary>Creates a new <see cref="GKLocalPlayerListener" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKLocalPlayerListener () : base (NSObjectFlag.Empty)
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
		protected GKLocalPlayerListener (NSObjectFlag t) : base (t)
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
		protected internal GKLocalPlayerListener (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="player">To be added.</param><param name="invite">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("player:didAcceptInvite:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAcceptInvite (GKPlayer player, GKInvite invite)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="challenge">To be added.</param><param name="friendPlayer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("player:didCompleteChallenge:issuedByFriend:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteChallenge (GKPlayer player, GKChallenge challenge, GKPlayer friendPlayer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("player:didReceiveChallenge:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveChallenge (GKPlayer player, GKChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="recipientPlayers">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("player:didRequestMatchWithRecipients:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRequestMatch (GKPlayer player, GKPlayer[] recipientPlayers)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="playersToInvite">To be added.</param><summary>Method that is called when <paramref name="player" /> requests a match with <paramref name="playersToInvite" />.</summary><remarks>To be added.</remarks>
		[Export ("player:didRequestMatchWithOtherPlayers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRequestMatchWithOtherPlayers (GKPlayer player, GKPlayer[] playersToInvite)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="challenge">To be added.</param><param name="friendPlayer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("player:issuedChallengeWasCompleted:byFriend:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IssuedChallengeWasCompleted (GKPlayer player, GKChallenge challenge, GKPlayer friendPlayer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="match" /> is ended.</summary><remarks>To be added.</remarks>
		[Export ("player:matchEnded:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MatchEnded (GKPlayer player, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after <paramref name="player" /> cancels the <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[Export ("player:receivedExchangeCancellation:forMatch:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedExchangeCancellation (GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="replies">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="exchange" /> with <paramref name="player" /> completes.</summary><remarks>To be added.</remarks>
		[Export ("player:receivedExchangeReplies:forCompletedExchange:forMatch:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedExchangeReplies (GKPlayer player, GKTurnBasedExchangeReply[] replies, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called when <paramref name="player" /> receives a request for an <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[Export ("player:receivedExchangeRequest:forMatch:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedExchangeRequest (GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><param name="becameActive">To be added.</param><summary>Method that is called to activate a turn for <paramref name="player" />.</summary><remarks>To be added.</remarks>
		[Export ("player:receivedTurnEventForMatch:didBecomeActive:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedTurnEvent (GKPlayer player, GKTurnBasedMatch match, bool becameActive)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="challenge">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("player:wantsToPlayChallenge:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WantsToPlayChallenge (GKPlayer player, GKChallenge challenge)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><summary>Method that is called after <paramref name="player" /> indicates that they desire to quit the match.</summary><remarks>To be added.</remarks>
		[Export ("player:wantsToQuitMatch:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WantsToQuitMatch (GKPlayer player, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GKLocalPlayerListener */
}
