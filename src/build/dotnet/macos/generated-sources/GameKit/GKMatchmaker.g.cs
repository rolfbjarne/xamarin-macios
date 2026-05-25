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
	[Register("GKMatchmaker", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKMatchmaker : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddPlayersToMatch_MatchRequest_CompletionHandler_X = "addPlayersToMatch:matchRequest:completionHandler:";
		static readonly NativeHandle selAddPlayersToMatch_MatchRequest_CompletionHandler_XHandle = Selector.GetHandle ("addPlayersToMatch:matchRequest:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelX = "cancel";
		static readonly NativeHandle selCancelXHandle = Selector.GetHandle ("cancel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelInviteToPlayer_X = "cancelInviteToPlayer:";
		static readonly NativeHandle selCancelInviteToPlayer_XHandle = Selector.GetHandle ("cancelInviteToPlayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelPendingInviteToPlayer_X = "cancelPendingInviteToPlayer:";
		static readonly NativeHandle selCancelPendingInviteToPlayer_XHandle = Selector.GetHandle ("cancelPendingInviteToPlayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindMatchForRequest_WithCompletionHandler_X = "findMatchForRequest:withCompletionHandler:";
		static readonly NativeHandle selFindMatchForRequest_WithCompletionHandler_XHandle = Selector.GetHandle ("findMatchForRequest:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindMatchedPlayers_WithCompletionHandler_X = "findMatchedPlayers:withCompletionHandler:";
		static readonly NativeHandle selFindMatchedPlayers_WithCompletionHandler_XHandle = Selector.GetHandle ("findMatchedPlayers:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindPlayersForHostedMatchRequest_WithCompletionHandler_X = "findPlayersForHostedMatchRequest:withCompletionHandler:";
		static readonly NativeHandle selFindPlayersForHostedMatchRequest_WithCompletionHandler_XHandle = Selector.GetHandle ("findPlayersForHostedMatchRequest:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindPlayersForHostedRequest_WithCompletionHandler_X = "findPlayersForHostedRequest:withCompletionHandler:";
		static readonly NativeHandle selFindPlayersForHostedRequest_WithCompletionHandler_XHandle = Selector.GetHandle ("findPlayersForHostedRequest:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishMatchmakingForMatch_X = "finishMatchmakingForMatch:";
		static readonly NativeHandle selFinishMatchmakingForMatch_XHandle = Selector.GetHandle ("finishMatchmakingForMatch:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInviteHandlerX = "inviteHandler";
		static readonly NativeHandle selInviteHandlerXHandle = Selector.GetHandle ("inviteHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchForInvite_CompletionHandler_X = "matchForInvite:completionHandler:";
		static readonly NativeHandle selMatchForInvite_CompletionHandler_XHandle = Selector.GetHandle ("matchForInvite:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryActivityWithCompletionHandler_X = "queryActivityWithCompletionHandler:";
		static readonly NativeHandle selQueryActivityWithCompletionHandler_XHandle = Selector.GetHandle ("queryActivityWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryPlayerGroupActivity_WithCompletionHandler_X = "queryPlayerGroupActivity:withCompletionHandler:";
		static readonly NativeHandle selQueryPlayerGroupActivity_WithCompletionHandler_XHandle = Selector.GetHandle ("queryPlayerGroupActivity:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryQueueActivity_WithCompletionHandler_X = "queryQueueActivity:withCompletionHandler:";
		static readonly NativeHandle selQueryQueueActivity_WithCompletionHandler_XHandle = Selector.GetHandle ("queryQueueActivity:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInviteHandler_X = "setInviteHandler:";
		static readonly NativeHandle selSetInviteHandler_XHandle = Selector.GetHandle ("setInviteHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedMatchmakerX = "sharedMatchmaker";
		static readonly NativeHandle selSharedMatchmakerXHandle = Selector.GetHandle ("sharedMatchmaker");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartBrowsingForNearbyPlayersWithHandler_X = "startBrowsingForNearbyPlayersWithHandler:";
		static readonly NativeHandle selStartBrowsingForNearbyPlayersWithHandler_XHandle = Selector.GetHandle ("startBrowsingForNearbyPlayersWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartBrowsingForNearbyPlayersWithReachableHandler_X = "startBrowsingForNearbyPlayersWithReachableHandler:";
		static readonly NativeHandle selStartBrowsingForNearbyPlayersWithReachableHandler_XHandle = Selector.GetHandle ("startBrowsingForNearbyPlayersWithReachableHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartGroupActivityWithPlayerHandler_X = "startGroupActivityWithPlayerHandler:";
		static readonly NativeHandle selStartGroupActivityWithPlayerHandler_XHandle = Selector.GetHandle ("startGroupActivityWithPlayerHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopBrowsingForNearbyPlayersX = "stopBrowsingForNearbyPlayers";
		static readonly NativeHandle selStopBrowsingForNearbyPlayersXHandle = Selector.GetHandle ("stopBrowsingForNearbyPlayers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopGroupActivityX = "stopGroupActivity";
		static readonly NativeHandle selStopGroupActivityXHandle = Selector.GetHandle ("stopGroupActivity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKMatchmaker");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKMatchmaker" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKMatchmaker () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
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
		protected GKMatchmaker (NSObjectFlag t) : base (t)
		{
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
		protected internal GKMatchmaker (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addPlayersToMatch:matchRequest:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddPlayers (GKMatch toMatch, GKMatchRequest matchRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			var toMatch__handle__ = toMatch!.GetNonNullHandle (nameof (toMatch));
			var matchRequest__handle__ = matchRequest!.GetNonNullHandle (nameof (matchRequest));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAddPlayersToMatch_MatchRequest_CompletionHandler_XHandle, toMatch__handle__, matchRequest__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAddPlayersToMatch_MatchRequest_CompletionHandler_XHandle, toMatch__handle__, matchRequest__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toMatch);
			GC.KeepAlive (matchRequest);
		}
		/// <param name="toMatch">To be added.</param>
		/// <param name="matchRequest">To be added.</param>
		/// <summary>Adds the players in the match request to the match.</summary>
		/// <returns>A task that represents the asynchronous AddPlayers operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task AddPlayersAsync (GKMatch toMatch, GKMatchRequest matchRequest)
		{
			var tcs = new TaskCompletionSource<bool> ();
			AddPlayers(toMatch, matchRequest, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("cancel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCancelXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("cancelInviteToPlayer:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'CancelPendingInvite' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'CancelPendingInvite' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CancelPendingInvite' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelInvite (string playerID)
		{
			if (playerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playerID));
			var nsplayerID = CFString.CreateNative (playerID);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCancelInviteToPlayer_XHandle, nsplayerID);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCancelInviteToPlayer_XHandle, nsplayerID);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsplayerID);
		}
		[Export ("cancelPendingInviteToPlayer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelPendingInvite (GKPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCancelPendingInviteToPlayer_XHandle, player__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCancelPendingInviteToPlayer_XHandle, player__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
		}
		[Export ("findMatchForRequest:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindMatch (GKMatchRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKNotificationMatch))]GKNotificationMatch? matchHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			using var block_matchHandler = Trampolines.SDGKNotificationMatch.CreateNullableBlock (matchHandler);
			BlockLiteral *block_ptr_matchHandler = null;
			if (matchHandler is not null)
				block_ptr_matchHandler = &block_matchHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFindMatchForRequest_WithCompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_matchHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFindMatchForRequest_WithCompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_matchHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		/// <param name="request">To be added.</param>
		/// <summary>Finds players for a peer-to-peer match.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous FindMatch operation.   The value of the TResult parameter is a GameKit.GKNotificationMatch.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKMatch> FindMatchAsync (GKMatchRequest request)
		{
			var tcs = new TaskCompletionSource<GKMatch> ();
			FindMatch(request, (match_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (match_!);
			});
			return tcs.Task;
		}
		[Export ("findMatchedPlayers:withCompletionHandler:")]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindMatchedPlayers (GKMatchRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V96))]global::System.Action<GKMatchedPlayers, NSError> completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V96.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFindMatchedPlayers_WithCompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFindMatchedPlayers_WithCompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKMatchedPlayers> FindMatchedPlayersAsync (GKMatchRequest request)
		{
			var tcs = new TaskCompletionSource<GKMatchedPlayers> ();
			FindMatchedPlayers(request, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("findPlayersForHostedMatchRequest:withCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'FindPlayersForHostedRequest' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'FindPlayersForHostedRequest' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'FindPlayersForHostedRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindPlayers (GKMatchRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKFriendsHandler))]GKFriendsHandler? playerHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			using var block_playerHandler = Trampolines.SDGKFriendsHandler.CreateNullableBlock (playerHandler);
			BlockLiteral *block_ptr_playerHandler = null;
			if (playerHandler is not null)
				block_ptr_playerHandler = &block_playerHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFindPlayersForHostedMatchRequest_WithCompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_playerHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFindPlayersForHostedMatchRequest_WithCompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_playerHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		/// <param name="request">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous FindPlayers operation.   The value of the TResult parameter is a GameKit.GKFriendsHandler.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'FindPlayersForHostedRequest' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'FindPlayersForHostedRequest' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'FindPlayersForHostedRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<string[]> FindPlayersAsync (GKMatchRequest request)
		{
			var tcs = new TaskCompletionSource<string[]> ();
			FindPlayers(request, (friends_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (friends_!);
			});
			return tcs.Task;
		}
		[Export ("findPlayersForHostedRequest:withCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindPlayersForHostedRequest (GKMatchRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V83))]global::System.Action<GKPlayer[], NSError>? completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			using var block_completionHandler = Trampolines.SDActionArity2V83.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFindPlayersForHostedRequest_WithCompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFindPlayersForHostedRequest_WithCompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		/// <param name="request">To be added.</param>
		/// <summary>Finds players for a hosted match request.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FindPlayersForHostedRequest operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKPlayer[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The FindPlayersForHostedRequestAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKPlayer[]> FindPlayersForHostedRequestAsync (GKMatchRequest request)
		{
			var tcs = new TaskCompletionSource<GKPlayer[]> ();
			FindPlayersForHostedRequest(request, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("finishMatchmakingForMatch:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishMatchmaking (GKMatch match)
		{
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFinishMatchmakingForMatch_XHandle, match__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFinishMatchmakingForMatch_XHandle, match__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (match);
		}
		[Export ("matchForInvite:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Match (GKInvite invite, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V93))]global::System.Action<GKMatch, NSError>? completionHandler)
		{
			var invite__handle__ = invite!.GetNonNullHandle (nameof (invite));
			using var block_completionHandler = Trampolines.SDActionArity2V93.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMatchForInvite_CompletionHandler_XHandle, invite__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMatchForInvite_CompletionHandler_XHandle, invite__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (invite);
		}
		/// <param name="invite">To be added.</param>
		/// <summary>Creates a match for the specified invitation.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous Match operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKMatch,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKMatch> MatchAsync (GKInvite invite)
		{
			var tcs = new TaskCompletionSource<GKMatch> ();
			Match(invite, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("queryActivityWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void QueryActivity ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKQueryHandler))]GKQueryHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDGKQueryHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selQueryActivityWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selQueryActivityWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Queries for activity in all player groups.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous QueryActivity operation.   The value of the TResult parameter is a GameKit.GKQueryHandler.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<nint> QueryActivityAsync ()
		{
			var tcs = new TaskCompletionSource<nint> ();
			QueryActivity((activity_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (activity_!);
			});
			return tcs.Task;
		}
		/// <param name="playerGroup">To be added.</param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("queryPlayerGroupActivity:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void QueryPlayerGroupActivity (nint playerGroup, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKQueryHandler))]GKQueryHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDGKQueryHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selQueryPlayerGroupActivity_WithCompletionHandler_XHandle, playerGroup, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selQueryPlayerGroupActivity_WithCompletionHandler_XHandle, playerGroup, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="playerGroup">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous QueryPlayerGroupActivity operation.   The value of the TResult parameter is a GameKit.GKQueryHandler.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<nint> QueryPlayerGroupActivityAsync (nint playerGroup)
		{
			var tcs = new TaskCompletionSource<nint> ();
			QueryPlayerGroupActivity(playerGroup, (activity_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (activity_!);
			});
			return tcs.Task;
		}
		[Export ("queryQueueActivity:withCompletionHandler:")]
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void QueryQueueActivity (string queueName, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V97))]global::System.Action<nint, NSError>? completionHandler)
		{
			if (queueName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queueName));
			var nsqueueName = CFString.CreateNative (queueName);
			using var block_completionHandler = Trampolines.SDActionArity2V97.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selQueryQueueActivity_WithCompletionHandler_XHandle, nsqueueName, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selQueryQueueActivity_WithCompletionHandler_XHandle, nsqueueName, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsqueueName);
		}
		[SupportedOSPlatform ("tvos17.2")]
		[SupportedOSPlatform ("macos14.2")]
		[SupportedOSPlatform ("ios17.2")]
		[SupportedOSPlatform ("maccatalyst17.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<nint> QueryQueueActivityAsync (string queueName)
		{
			var tcs = new TaskCompletionSource<nint> ();
			QueryQueueActivity(queueName, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("startBrowsingForNearbyPlayersWithReachableHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'StartBrowsingForNearbyPlayers(Action<GKPlayer, bool> handler)' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'StartBrowsingForNearbyPlayers(Action<GKPlayer, bool> handler)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'StartBrowsingForNearbyPlayers(Action<GKPlayer, bool> handler)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartBrowsingForNearbyPlayers ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V98))]global::System.Action<string, bool>? reachableHandler)
		{
			using var block_reachableHandler = Trampolines.SDActionArity2V98.CreateNullableBlock (reachableHandler);
			BlockLiteral *block_ptr_reachableHandler = null;
			if (reachableHandler is not null)
				block_ptr_reachableHandler = &block_reachableHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartBrowsingForNearbyPlayersWithReachableHandler_XHandle, (IntPtr) block_ptr_reachableHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartBrowsingForNearbyPlayersWithReachableHandler_XHandle, (IntPtr) block_ptr_reachableHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("startBrowsingForNearbyPlayersWithHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartBrowsingForNearbyPlayers ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V99))]global::System.Action<GKPlayer, bool>? handler)
		{
			using var block_handler = Trampolines.SDActionArity2V99.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartBrowsingForNearbyPlayersWithHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartBrowsingForNearbyPlayersWithHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("startGroupActivityWithPlayerHandler:")]
		[SupportedOSPlatform ("macos13.1")]
		[SupportedOSPlatform ("ios16.2")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartGroupActivity ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V64))]global::System.Action<GKPlayer> handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDActionArity1V64.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selStartGroupActivityWithPlayerHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartGroupActivityWithPlayerHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopBrowsingForNearbyPlayers")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopBrowsingForNearbyPlayers ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopBrowsingForNearbyPlayersXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopBrowsingForNearbyPlayersXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stopGroupActivity")]
		[SupportedOSPlatform ("macos13.1")]
		[SupportedOSPlatform ("ios16.2")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst16.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopGroupActivity ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopGroupActivityXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopGroupActivityXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKInviteEventListenerProtocol'.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKInviteEventListenerProtocol'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKInviteEventListenerProtocol'.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public unsafe virtual GKInviteHandler? InviteHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDGKInviteHandler))]
			[Export ("inviteHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInviteHandlerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInviteHandlerXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDGKInviteHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKInviteHandler))]
			[Export ("setInviteHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDGKInviteHandler.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInviteHandler_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInviteHandler_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKMatchmaker SharedMatchmaker {
			[Export ("sharedMatchmaker")]
			get {
				GKMatchmaker? ret;
				ret =  Runtime.GetNSObject<GKMatchmaker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedMatchmakerXHandle), false)!;
				return ret!;
			}
		}
	} /* class GKMatchmaker */
}
