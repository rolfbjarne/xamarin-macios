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
	/// <summary>Listens for events in turn-based games.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameKit/Reference/GKTurnBasedEventListener_Ref/index.html">Apple documentation for <c>GKTurnBasedEventListener</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKTurnBasedEventListener", WrapperType = typeof (GKTurnBasedEventListenerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestMatchWithPlayers", Selector = "player:didRequestMatchWithPlayers:", ParameterType = new Type [] { typeof (GameKit.GKPlayer), typeof (String[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedTurnEvent", Selector = "player:receivedTurnEventForMatch:didBecomeActive:", ParameterType = new Type [] { typeof (GameKit.GKPlayer), typeof (GameKit.GKTurnBasedMatch), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MatchEnded", Selector = "player:matchEnded:", ParameterType = new Type [] { typeof (GameKit.GKPlayer), typeof (GameKit.GKTurnBasedMatch) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedExchangeRequest", Selector = "player:receivedExchangeRequest:forMatch:", ParameterType = new Type [] { typeof (GameKit.GKPlayer), typeof (GameKit.GKTurnBasedExchange), typeof (GameKit.GKTurnBasedMatch) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedExchangeCancellation", Selector = "player:receivedExchangeCancellation:forMatch:", ParameterType = new Type [] { typeof (GameKit.GKPlayer), typeof (GameKit.GKTurnBasedExchange), typeof (GameKit.GKTurnBasedMatch) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedExchangeReplies", Selector = "player:receivedExchangeReplies:forCompletedExchange:forMatch:", ParameterType = new Type [] { typeof (GameKit.GKPlayer), typeof (GameKit.GKTurnBasedExchangeReply[]), typeof (GameKit.GKTurnBasedExchange), typeof (GameKit.GKTurnBasedMatch) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRequestMatchWithOtherPlayers", Selector = "player:didRequestMatchWithOtherPlayers:", ParameterType = new Type [] { typeof (GameKit.GKPlayer), typeof (GameKit.GKPlayer[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WantsToQuitMatch", Selector = "player:wantsToQuitMatch:", ParameterType = new Type [] { typeof (GameKit.GKPlayer), typeof (GameKit.GKTurnBasedMatch) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IGKTurnBasedEventListener : INativeObject, IDisposable
	{
		/// <param name="player">To be added.</param><param name="playerIDsToInvite">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidRequestMatchWithOtherPlayers' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("player:didRequestMatchWithPlayers:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidRequestMatchWithOtherPlayers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidRequestMatchWithOtherPlayers' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRequestMatchWithPlayers (GKPlayer player, string[] playerIDsToInvite)
		{
			_DidRequestMatchWithPlayers (this, player, playerIDsToInvite);
		}
		/// <param name="player">To be added.</param><param name="playerIDsToInvite">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidRequestMatchWithOtherPlayers' instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidRequestMatchWithOtherPlayers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidRequestMatchWithOtherPlayers' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRequestMatchWithPlayers (IGKTurnBasedEventListener This, GKPlayer player, string[] playerIDsToInvite)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (playerIDsToInvite is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playerIDsToInvite));
			using var nsa_playerIDsToInvite = NSArray.FromStrings (playerIDsToInvite);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:didRequestMatchWithPlayers:"), player__handle__, nsa_playerIDsToInvite.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><param name="becameActive">To be added.</param><summary>Method that is called to activate a turn for <paramref name="player" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("player:receivedTurnEventForMatch:didBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedTurnEvent (GKPlayer player, GKTurnBasedMatch match, bool becameActive)
		{
			_ReceivedTurnEvent (this, player, match, becameActive);
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><param name="becameActive">To be added.</param><summary>Method that is called to activate a turn for <paramref name="player" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedTurnEvent (IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedMatch match, bool becameActive)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("player:receivedTurnEventForMatch:didBecomeActive:"), player__handle__, match__handle__, becameActive ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="match" /> is ended.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("player:matchEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MatchEnded (GKPlayer player, GKTurnBasedMatch match)
		{
			_MatchEnded (this, player, match);
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="match" /> is ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MatchEnded (IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:matchEnded:"), player__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called when <paramref name="player" /> receives a request for an <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("player:receivedExchangeRequest:forMatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedExchangeRequest (GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			_ReceivedExchangeRequest (this, player, exchange, match);
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called when <paramref name="player" /> receives a request for an <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedExchangeRequest (IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var exchange__handle__ = exchange!.GetNonNullHandle (nameof (exchange));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:receivedExchangeRequest:forMatch:"), player__handle__, exchange__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (exchange);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after <paramref name="player" /> cancels the <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("player:receivedExchangeCancellation:forMatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedExchangeCancellation (GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			_ReceivedExchangeCancellation (this, player, exchange, match);
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after <paramref name="player" /> cancels the <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedExchangeCancellation (IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var exchange__handle__ = exchange!.GetNonNullHandle (nameof (exchange));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:receivedExchangeCancellation:forMatch:"), player__handle__, exchange__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (exchange);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="replies">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="exchange" /> with <paramref name="player" /> completes.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("player:receivedExchangeReplies:forCompletedExchange:forMatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedExchangeReplies (GKPlayer player, GKTurnBasedExchangeReply[] replies, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			_ReceivedExchangeReplies (this, player, replies, exchange, match);
		}
		/// <param name="player">To be added.</param><param name="replies">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="exchange" /> with <paramref name="player" /> completes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedExchangeReplies (IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedExchangeReply[] replies, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (replies is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replies));
			var exchange__handle__ = exchange!.GetNonNullHandle (nameof (exchange));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			using var nsa_replies = NSArray.FromNSObjects (replies);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:receivedExchangeReplies:forCompletedExchange:forMatch:"), player__handle__, nsa_replies.Handle, exchange__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (exchange);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="playersToInvite">To be added.</param><summary>Method that is called when <paramref name="player" /> requests a match with <paramref name="playersToInvite" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("player:didRequestMatchWithOtherPlayers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRequestMatchWithOtherPlayers (GKPlayer player, GKPlayer[] playersToInvite)
		{
			_DidRequestMatchWithOtherPlayers (this, player, playersToInvite);
		}
		/// <param name="player">To be added.</param><param name="playersToInvite">To be added.</param><summary>Method that is called when <paramref name="player" /> requests a match with <paramref name="playersToInvite" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRequestMatchWithOtherPlayers (IGKTurnBasedEventListener This, GKPlayer player, GKPlayer[] playersToInvite)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (playersToInvite is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playersToInvite));
			using var nsa_playersToInvite = NSArray.FromNSObjects (playersToInvite);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:didRequestMatchWithOtherPlayers:"), player__handle__, nsa_playersToInvite.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><summary>Method that is called after <paramref name="player" /> indicates that they desire to quit the match.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("player:wantsToQuitMatch:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WantsToQuitMatch (GKPlayer player, GKTurnBasedMatch match)
		{
			_WantsToQuitMatch (this, player, match);
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><summary>Method that is called after <paramref name="player" /> indicates that they desire to quit the match.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WantsToQuitMatch (IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:wantsToQuitMatch:"), player__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (match);
		}
		[DynamicDependencyAttribute ("DidRequestMatchWithOtherPlayers(GameKit.GKPlayer,GameKit.GKPlayer[])")]
		[DynamicDependencyAttribute ("DidRequestMatchWithPlayers(GameKit.GKPlayer,System.String[])")]
		[DynamicDependencyAttribute ("MatchEnded(GameKit.GKPlayer,GameKit.GKTurnBasedMatch)")]
		[DynamicDependencyAttribute ("ReceivedExchangeCancellation(GameKit.GKPlayer,GameKit.GKTurnBasedExchange,GameKit.GKTurnBasedMatch)")]
		[DynamicDependencyAttribute ("ReceivedExchangeReplies(GameKit.GKPlayer,GameKit.GKTurnBasedExchangeReply[],GameKit.GKTurnBasedExchange,GameKit.GKTurnBasedMatch)")]
		[DynamicDependencyAttribute ("ReceivedExchangeRequest(GameKit.GKPlayer,GameKit.GKTurnBasedExchange,GameKit.GKTurnBasedMatch)")]
		[DynamicDependencyAttribute ("ReceivedTurnEvent(GameKit.GKPlayer,GameKit.GKTurnBasedMatch,System.Boolean)")]
		[DynamicDependencyAttribute ("WantsToQuitMatch(GameKit.GKPlayer,GameKit.GKTurnBasedMatch)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKTurnBasedEventListenerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKTurnBasedEventListener ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKTurnBasedEventListener" /> interface to support all the methods from the GKTurnBasedEventListener protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKTurnBasedEventListener" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKTurnBasedEventListener protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKTurnBasedEventListener_Extensions {
		/// <param name="player">To be added.</param><param name="playerIDsToInvite">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidRequestMatchWithOtherPlayers' instead.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidRequestMatchWithOtherPlayers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidRequestMatchWithOtherPlayers' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRequestMatchWithPlayers (this IGKTurnBasedEventListener This, GKPlayer player, string[] playerIDsToInvite)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (playerIDsToInvite is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playerIDsToInvite));
			using var nsa_playerIDsToInvite = NSArray.FromStrings (playerIDsToInvite);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:didRequestMatchWithPlayers:"), player__handle__, nsa_playerIDsToInvite.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><param name="becameActive">To be added.</param><summary>Method that is called to activate a turn for <paramref name="player" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedTurnEvent (this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedMatch match, bool becameActive)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("player:receivedTurnEventForMatch:didBecomeActive:"), player__handle__, match__handle__, becameActive ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="match" /> is ended.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MatchEnded (this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:matchEnded:"), player__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called when <paramref name="player" /> receives a request for an <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedExchangeRequest (this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var exchange__handle__ = exchange!.GetNonNullHandle (nameof (exchange));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:receivedExchangeRequest:forMatch:"), player__handle__, exchange__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (exchange);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after <paramref name="player" /> cancels the <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedExchangeCancellation (this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var exchange__handle__ = exchange!.GetNonNullHandle (nameof (exchange));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:receivedExchangeCancellation:forMatch:"), player__handle__, exchange__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (exchange);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="replies">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="exchange" /> with <paramref name="player" /> completes.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedExchangeReplies (this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedExchangeReply[] replies, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (replies is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replies));
			var exchange__handle__ = exchange!.GetNonNullHandle (nameof (exchange));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			using var nsa_replies = NSArray.FromNSObjects (replies);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:receivedExchangeReplies:forCompletedExchange:forMatch:"), player__handle__, nsa_replies.Handle, exchange__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (exchange);
			GC.KeepAlive (match);
		}
		/// <param name="player">To be added.</param><param name="playersToInvite">To be added.</param><summary>Method that is called when <paramref name="player" /> requests a match with <paramref name="playersToInvite" />.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRequestMatchWithOtherPlayers (this IGKTurnBasedEventListener This, GKPlayer player, GKPlayer[] playersToInvite)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (playersToInvite is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playersToInvite));
			using var nsa_playersToInvite = NSArray.FromNSObjects (playersToInvite);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:didRequestMatchWithOtherPlayers:"), player__handle__, nsa_playersToInvite.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><summary>Method that is called after <paramref name="player" /> indicates that they desire to quit the match.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WantsToQuitMatch (this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("player:wantsToQuitMatch:"), player__handle__, match__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			GC.KeepAlive (match);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKTurnBasedEventListenerWrapper : BaseWrapper, IGKTurnBasedEventListener {
		public GKTurnBasedEventListenerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKTurnBasedEventListenerWrapper))]
		static GKTurnBasedEventListenerWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace GameKit {
	/// <summary>Listens for events in turn-based games.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameKit/Reference/GKTurnBasedEventListener_Ref/index.html">Apple documentation for <c>GKTurnBasedEventListener</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__GameKit_GKTurnBasedEventListener", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKTurnBasedEventListener : NSObject, IGKTurnBasedEventListener {
		/// <summary>Creates a new <see cref="GKTurnBasedEventListener" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKTurnBasedEventListener () : base (NSObjectFlag.Empty)
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
		protected GKTurnBasedEventListener (NSObjectFlag t) : base (t)
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
		protected internal GKTurnBasedEventListener (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
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
		/// <param name="player">To be added.</param><param name="playerIDsToInvite">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'DidRequestMatchWithOtherPlayers' instead.</summary><remarks>To be added.</remarks>
		[Export ("player:didRequestMatchWithPlayers:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'DidRequestMatchWithOtherPlayers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'DidRequestMatchWithOtherPlayers' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRequestMatchWithPlayers (GKPlayer player, string[] playerIDsToInvite)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="match" /> is ended.</summary><remarks>To be added.</remarks>
		[Export ("player:matchEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MatchEnded (GKPlayer player, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after <paramref name="player" /> cancels the <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[Export ("player:receivedExchangeCancellation:forMatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedExchangeCancellation (GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="replies">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called after the <paramref name="exchange" /> with <paramref name="player" /> completes.</summary><remarks>To be added.</remarks>
		[Export ("player:receivedExchangeReplies:forCompletedExchange:forMatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedExchangeReplies (GKPlayer player, GKTurnBasedExchangeReply[] replies, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="exchange">To be added.</param><param name="match">To be added.</param><summary>Method that is called when <paramref name="player" /> receives a request for an <paramref name="exchange" />.</summary><remarks>To be added.</remarks>
		[Export ("player:receivedExchangeRequest:forMatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedExchangeRequest (GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><param name="match">To be added.</param><param name="becameActive">To be added.</param><summary>Method that is called to activate a turn for <paramref name="player" />.</summary><remarks>To be added.</remarks>
		[Export ("player:receivedTurnEventForMatch:didBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedTurnEvent (GKPlayer player, GKTurnBasedMatch match, bool becameActive)
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
	} /* class GKTurnBasedEventListener */
}
