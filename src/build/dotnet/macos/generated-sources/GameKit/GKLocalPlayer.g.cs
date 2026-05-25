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
	[Register("GKLocalPlayer", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKLocalPlayer : GKPlayer, IGKSavedGameListener {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthenticateHandlerX = "authenticateHandler";
		static readonly NativeHandle selAuthenticateHandlerXHandle = Selector.GetHandle ("authenticateHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthenticateWithCompletionHandler_X = "authenticateWithCompletionHandler:";
		static readonly NativeHandle selAuthenticateWithCompletionHandler_XHandle = Selector.GetHandle ("authenticateWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteSavedGamesWithName_CompletionHandler_X = "deleteSavedGamesWithName:completionHandler:";
		static readonly NativeHandle selDeleteSavedGamesWithName_CompletionHandler_XHandle = Selector.GetHandle ("deleteSavedGamesWithName:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchItemsForIdentityVerificationSignature_X = "fetchItemsForIdentityVerificationSignature:";
		static readonly NativeHandle selFetchItemsForIdentityVerificationSignature_XHandle = Selector.GetHandle ("fetchItemsForIdentityVerificationSignature:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchSavedGamesWithCompletionHandler_X = "fetchSavedGamesWithCompletionHandler:";
		static readonly NativeHandle selFetchSavedGamesWithCompletionHandler_XHandle = Selector.GetHandle ("fetchSavedGamesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFriendsX = "friends";
		static readonly NativeHandle selFriendsXHandle = Selector.GetHandle ("friends");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenerateIdentityVerificationSignatureWithCompletionHandler_X = "generateIdentityVerificationSignatureWithCompletionHandler:";
		static readonly NativeHandle selGenerateIdentityVerificationSignatureWithCompletionHandler_XHandle = Selector.GetHandle ("generateIdentityVerificationSignatureWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAuthenticatedX = "isAuthenticated";
		static readonly NativeHandle selIsAuthenticatedXHandle = Selector.GetHandle ("isAuthenticated");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsMultiplayerGamingRestrictedX = "isMultiplayerGamingRestricted";
		static readonly NativeHandle selIsMultiplayerGamingRestrictedXHandle = Selector.GetHandle ("isMultiplayerGamingRestricted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPersonalizedCommunicationRestrictedX = "isPersonalizedCommunicationRestricted";
		static readonly NativeHandle selIsPersonalizedCommunicationRestrictedXHandle = Selector.GetHandle ("isPersonalizedCommunicationRestricted");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPresentingFriendRequestViewControllerX = "isPresentingFriendRequestViewController";
		static readonly NativeHandle selIsPresentingFriendRequestViewControllerXHandle = Selector.GetHandle ("isPresentingFriendRequestViewController");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsUnderageX = "isUnderage";
		static readonly NativeHandle selIsUnderageXHandle = Selector.GetHandle ("isUnderage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadChallengableFriendsWithCompletionHandler_X = "loadChallengableFriendsWithCompletionHandler:";
		static readonly NativeHandle selLoadChallengableFriendsWithCompletionHandler_XHandle = Selector.GetHandle ("loadChallengableFriendsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadDefaultLeaderboardCategoryIDWithCompletionHandler_X = "loadDefaultLeaderboardCategoryIDWithCompletionHandler:";
		static readonly NativeHandle selLoadDefaultLeaderboardCategoryIDWithCompletionHandler_XHandle = Selector.GetHandle ("loadDefaultLeaderboardCategoryIDWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadDefaultLeaderboardIdentifierWithCompletionHandler_X = "loadDefaultLeaderboardIdentifierWithCompletionHandler:";
		static readonly NativeHandle selLoadDefaultLeaderboardIdentifierWithCompletionHandler_XHandle = Selector.GetHandle ("loadDefaultLeaderboardIdentifierWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFriendPlayersWithCompletionHandler_X = "loadFriendPlayersWithCompletionHandler:";
		static readonly NativeHandle selLoadFriendPlayersWithCompletionHandler_XHandle = Selector.GetHandle ("loadFriendPlayersWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFriends_X = "loadFriends:";
		static readonly NativeHandle selLoadFriends_XHandle = Selector.GetHandle ("loadFriends:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFriendsAuthorizationStatus_X = "loadFriendsAuthorizationStatus:";
		static readonly NativeHandle selLoadFriendsAuthorizationStatus_XHandle = Selector.GetHandle ("loadFriendsAuthorizationStatus:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFriendsWithCompletionHandler_X = "loadFriendsWithCompletionHandler:";
		static readonly NativeHandle selLoadFriendsWithCompletionHandler_XHandle = Selector.GetHandle ("loadFriendsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFriendsWithIdentifiers_CompletionHandler_X = "loadFriendsWithIdentifiers:completionHandler:";
		static readonly NativeHandle selLoadFriendsWithIdentifiers_CompletionHandler_XHandle = Selector.GetHandle ("loadFriendsWithIdentifiers:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadRecentPlayersWithCompletionHandler_X = "loadRecentPlayersWithCompletionHandler:";
		static readonly NativeHandle selLoadRecentPlayersWithCompletionHandler_XHandle = Selector.GetHandle ("loadRecentPlayersWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalX = "local";
		static readonly NativeHandle selLocalXHandle = Selector.GetHandle ("local");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalPlayerX = "localPlayer";
		static readonly NativeHandle selLocalPlayerXHandle = Selector.GetHandle ("localPlayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayer_DidModifySavedGame_X = "player:didModifySavedGame:";
		static readonly NativeHandle selPlayer_DidModifySavedGame_XHandle = Selector.GetHandle ("player:didModifySavedGame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayer_HasConflictingSavedGames_X = "player:hasConflictingSavedGames:";
		static readonly NativeHandle selPlayer_HasConflictingSavedGames_XHandle = Selector.GetHandle ("player:hasConflictingSavedGames:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentFriendRequestCreatorFromWindow_Error_X = "presentFriendRequestCreatorFromWindow:error:";
		static readonly NativeHandle selPresentFriendRequestCreatorFromWindow_Error_XHandle = Selector.GetHandle ("presentFriendRequestCreatorFromWindow:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterListener_X = "registerListener:";
		static readonly NativeHandle selRegisterListener_XHandle = Selector.GetHandle ("registerListener:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolveConflictingSavedGames_WithData_CompletionHandler_X = "resolveConflictingSavedGames:withData:completionHandler:";
		static readonly NativeHandle selResolveConflictingSavedGames_WithData_CompletionHandler_XHandle = Selector.GetHandle ("resolveConflictingSavedGames:withData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveGameData_WithName_CompletionHandler_X = "saveGameData:withName:completionHandler:";
		static readonly NativeHandle selSaveGameData_WithName_CompletionHandler_XHandle = Selector.GetHandle ("saveGameData:withName:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAuthenticateHandler_X = "setAuthenticateHandler:";
		static readonly NativeHandle selSetAuthenticateHandler_XHandle = Selector.GetHandle ("setAuthenticateHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultLeaderboardCategoryID_CompletionHandler_X = "setDefaultLeaderboardCategoryID:completionHandler:";
		static readonly NativeHandle selSetDefaultLeaderboardCategoryID_CompletionHandler_XHandle = Selector.GetHandle ("setDefaultLeaderboardCategoryID:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultLeaderboardIdentifier_CompletionHandler_X = "setDefaultLeaderboardIdentifier:completionHandler:";
		static readonly NativeHandle selSetDefaultLeaderboardIdentifier_CompletionHandler_XHandle = Selector.GetHandle ("setDefaultLeaderboardIdentifier:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnregisterAllListenersX = "unregisterAllListeners";
		static readonly NativeHandle selUnregisterAllListenersXHandle = Selector.GetHandle ("unregisterAllListeners");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnregisterListener_X = "unregisterListener:";
		static readonly NativeHandle selUnregisterListener_XHandle = Selector.GetHandle ("unregisterListener:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKLocalPlayer");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKLocalPlayer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKLocalPlayer () : base (NSObjectFlag.Empty)
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

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public GKLocalPlayer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected GKLocalPlayer (NSObjectFlag t) : base (t)
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
		protected internal GKLocalPlayer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("authenticateWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Set the 'AuthenticationHandler' instead.")]
		[ObsoletedOSPlatform ("macos10.8", "Set the 'AuthenticationHandler' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Set the 'AuthenticationHandler' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Authenticate ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? handler)
		{
			using var block_handler = Trampolines.SDActionArity1V16.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAuthenticateWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAuthenticateWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Developers should not use this deprecated method. Set the 'AuthenticationHandler' instead.</summary>
		/// <returns>A task that represents the asynchronous Authenticate operation</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Set the 'AuthenticationHandler' instead.")]
		[ObsoletedOSPlatform ("macos10.8", "Set the 'AuthenticationHandler' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Set the 'AuthenticationHandler' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task AuthenticateAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			Authenticate((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("deleteSavedGamesWithName:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteSavedGames (string name, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? handler)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			using var block_handler = Trampolines.SDActionArity1V16.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDeleteSavedGamesWithName_CompletionHandler_XHandle, nsname, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDeleteSavedGamesWithName_CompletionHandler_XHandle, nsname, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		/// <param name="player">To be added.</param><param name="savedGame">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("player:didModifySavedGame:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidModifySavedGame (GKPlayer player, GKSavedGame savedGame)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var savedGame__handle__ = savedGame!.GetNonNullHandle (nameof (savedGame));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPlayer_DidModifySavedGame_XHandle, player__handle__, savedGame__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPlayer_DidModifySavedGame_XHandle, player__handle__, savedGame__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
			GC.KeepAlive (savedGame);
		}
		[Export ("fetchItemsForIdentityVerificationSignature:")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchItemsForIdentityVerificationSignature ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKFetchItemsForIdentityVerificationSignatureCompletionHandler))]GKFetchItemsForIdentityVerificationSignatureCompletionHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDGKFetchItemsForIdentityVerificationSignatureCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFetchItemsForIdentityVerificationSignature_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFetchItemsForIdentityVerificationSignature_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKFetchItemsForIdentityVerificationSignature> FetchItemsForIdentityVerificationSignatureAsync ()
		{
			var tcs = new TaskCompletionSource<GKFetchItemsForIdentityVerificationSignature> ();
			FetchItemsForIdentityVerificationSignature((publicKeyUrl_, signature_, salt_, timestamp_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new GKFetchItemsForIdentityVerificationSignature (publicKeyUrl_!, signature_!, salt_!, timestamp_!));
			});
			return tcs.Task;
		}
		[Export ("fetchSavedGamesWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchSavedGames ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V89))]global::System.Action<GKSavedGame[], NSError>? handler)
		{
			using var block_handler = Trampolines.SDActionArity2V89.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFetchSavedGamesWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFetchSavedGamesWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("generateIdentityVerificationSignatureWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios13.4", "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
		[ObsoletedOSPlatform ("tvos13.4", "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
		[ObsoletedOSPlatform ("macos10.15.4", "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GenerateIdentityVerificationSignature ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKIdentityVerificationSignatureHandler))]GKIdentityVerificationSignatureHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDGKIdentityVerificationSignatureHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGenerateIdentityVerificationSignatureWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGenerateIdentityVerificationSignatureWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Creates and returns a signature for authenticating the local player on a third-party server. See remarks</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous GenerateIdentityVerificationSignature operation.   The value of the TResult parameter is of type GameKit.GKIdentityVerificationSignatureResult.  Holds the return values from the asynchronous method </para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios13.4", "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
		[ObsoletedOSPlatform ("tvos13.4", "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
		[ObsoletedOSPlatform ("macos10.15.4", "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKIdentityVerificationSignatureResult> GenerateIdentityVerificationSignatureAsync ()
		{
			var tcs = new TaskCompletionSource<GKIdentityVerificationSignatureResult> ();
			GenerateIdentityVerificationSignature((publicKeyUrl_, signature_, salt_, timestamp_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new GKIdentityVerificationSignatureResult (publicKeyUrl_!, signature_!, salt_!, timestamp_!));
			});
			return tcs.Task;
		}
		/// <param name="player">To be added.</param><param name="savedGames">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("player:hasConflictingSavedGames:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HasConflictingSavedGames (GKPlayer player, GKSavedGame[] savedGames)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (savedGames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (savedGames));
			using var nsa_savedGames = NSArray.FromNSObjects (savedGames);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPlayer_HasConflictingSavedGames_XHandle, player__handle__, nsa_savedGames.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPlayer_HasConflictingSavedGames_XHandle, player__handle__, nsa_savedGames.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
		}
		[Export ("loadChallengableFriendsWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadChallengeableFriends ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V83))]global::System.Action<GKPlayer[], NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity2V83.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadChallengableFriendsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadChallengableFriendsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKPlayer[]> LoadChallengeableFriendsAsync ()
		{
			var tcs = new TaskCompletionSource<GKPlayer[]> ();
			LoadChallengeableFriends((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadDefaultLeaderboardCategoryIDWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadDefaultLeaderboardCategoryID ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V70))]global::System.Action<string, NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity2V70.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadDefaultLeaderboardCategoryIDWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadDefaultLeaderboardCategoryIDWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously loads the local player's default leaderboard category identifier.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadDefaultLeaderboardCategoryID operation.  The value of the TResult parameter is of type System.Action&lt;System.String,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<string> LoadDefaultLeaderboardCategoryIDAsync ()
		{
			var tcs = new TaskCompletionSource<string> ();
			LoadDefaultLeaderboardCategoryID((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadDefaultLeaderboardIdentifierWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("macos26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("tvos26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("maccatalyst26.2", "No longer supported.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadDefaultLeaderboardIdentifier ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V70))]global::System.Action<string, NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity2V70.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadDefaultLeaderboardIdentifierWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadDefaultLeaderboardIdentifierWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously loads the local player's default leaderboard identifier.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadDefaultLeaderboardIdentifier operation.  The value of the TResult parameter is of type System.Action&lt;System.String,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("macos26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("tvos26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("maccatalyst26.2", "No longer supported.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<string> LoadDefaultLeaderboardIdentifierAsync ()
		{
			var tcs = new TaskCompletionSource<string> ();
			LoadDefaultLeaderboardIdentifier((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadFriendPlayersWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("tvos10.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadFriendPlayers ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V83))]global::System.Action<GKPlayer[], NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity2V83.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadFriendPlayersWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadFriendPlayersWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously loads an array of the local player's friends' identifiers.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadFriendPlayers operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKPlayer[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The LoadFriendPlayersAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("ios10.0")]
		[ObsoletedOSPlatform ("macos10.11")]
		[ObsoletedOSPlatform ("tvos10.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKPlayer[]> LoadFriendPlayersAsync ()
		{
			var tcs = new TaskCompletionSource<GKPlayer[]> ();
			LoadFriendPlayers((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadFriendsWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'LoadRecentPlayers' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'LoadRecentPlayers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LoadRecentPlayers' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadFriends ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKFriendsHandler))]GKFriendsHandler? handler)
		{
			using var block_handler = Trampolines.SDGKFriendsHandler.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadFriendsWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadFriendsWithCompletionHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously loads an array of the local player's friends' identifiers.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous LoadFriends operation.   The value of the TResult parameter is a GameKit.GKFriendsHandler.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'LoadRecentPlayers' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'LoadRecentPlayers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LoadRecentPlayers' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<string[]> LoadFriendsAsync ()
		{
			var tcs = new TaskCompletionSource<string[]> ();
			LoadFriends((friends_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (friends_!);
			});
			return tcs.Task;
		}
		[Export ("loadFriendsAuthorizationStatus:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadFriendsAuthorizationStatus ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V90))]global::System.Action<GKFriendsAuthorizationStatus, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V90.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadFriendsAuthorizationStatus_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadFriendsAuthorizationStatus_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKFriendsAuthorizationStatus> LoadFriendsAuthorizationStatusAsync ()
		{
			var tcs = new TaskCompletionSource<GKFriendsAuthorizationStatus> ();
			LoadFriendsAuthorizationStatus((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadFriends:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadFriendsList ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V83))]global::System.Action<GKPlayer[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V83.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadFriends_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadFriends_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKPlayer[]> LoadFriendsListAsync ()
		{
			var tcs = new TaskCompletionSource<GKPlayer[]> ();
			LoadFriendsList((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadFriendsWithIdentifiers:completionHandler:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadFriendsList (string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V83))]global::System.Action<GKPlayer[], NSError> completionHandler)
		{
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			using var block_completionHandler = Trampolines.SDActionArity2V83.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadFriendsWithIdentifiers_CompletionHandler_XHandle, nsa_identifiers.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadFriendsWithIdentifiers_CompletionHandler_XHandle, nsa_identifiers.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKPlayer[]> LoadFriendsListAsync (string[] identifiers)
		{
			var tcs = new TaskCompletionSource<GKPlayer[]> ();
			LoadFriendsList(identifiers, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadRecentPlayersWithCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadRecentPlayers ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V83))]global::System.Action<GKPlayer[], NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity2V83.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadRecentPlayersWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadRecentPlayersWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Loads the recent players.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadRecentPlayers operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKPlayer[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKPlayer[]> LoadRecentPlayersAsync ()
		{
			var tcs = new TaskCompletionSource<GKPlayer[]> ();
			LoadRecentPlayers((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("presentFriendRequestCreatorFromWindow:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool PresentFriendRequestCreator (global::AppKit.NSWindow? window, out NSError? error)
		{
			var window__handle__ = window.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selPresentFriendRequestCreatorFromWindow_Error_XHandle, window__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selPresentFriendRequestCreatorFromWindow_Error_XHandle, window__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (window);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("registerListener:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterListener (IGKLocalPlayerListener listener)
		{
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRegisterListener_XHandle, listener__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRegisterListener_XHandle, listener__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (listener);
		}
		[Export ("resolveConflictingSavedGames:withData:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveConflictingSavedGames (GKSavedGame[] conflictingSavedGames, NSData data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V89))]global::System.Action<GKSavedGame[], NSError>? handler)
		{
			if (conflictingSavedGames is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (conflictingSavedGames));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			using var nsa_conflictingSavedGames = NSArray.FromNSObjects (conflictingSavedGames);
			using var block_handler = Trampolines.SDActionArity2V89.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selResolveConflictingSavedGames_WithData_CompletionHandler_XHandle, nsa_conflictingSavedGames.Handle, data__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selResolveConflictingSavedGames_WithData_CompletionHandler_XHandle, nsa_conflictingSavedGames.Handle, data__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		[Export ("saveGameData:withName:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveGameData (NSData data, string name, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V91))]global::System.Action<GKSavedGame, NSError>? handler)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			using var block_handler = Trampolines.SDActionArity2V91.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSaveGameData_WithName_CompletionHandler_XHandle, data__handle__, nsname, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSaveGameData_WithName_CompletionHandler_XHandle, data__handle__, nsname, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nsname);
		}
		[Export ("setDefaultLeaderboardCategoryID:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'SetDefaultLeaderboardIdentifier' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'SetDefaultLeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetDefaultLeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetDefaultLeaderboardCategoryID (string? categoryID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			var nscategoryID = CFString.CreateNative (categoryID);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetDefaultLeaderboardCategoryID_CompletionHandler_XHandle, nscategoryID, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetDefaultLeaderboardCategoryID_CompletionHandler_XHandle, nscategoryID, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscategoryID);
		}
		/// <param name="categoryID">To be added.</param>
		/// <summary>Asynchronously sets the local player's default leaderboard category identifier.</summary>
		/// <returns>A task that represents the asynchronous SetDefaultLeaderboardCategoryID operation</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'SetDefaultLeaderboardIdentifier' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'SetDefaultLeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetDefaultLeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetDefaultLeaderboardCategoryIDAsync (string? categoryID)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetDefaultLeaderboardCategoryID(categoryID, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setDefaultLeaderboardIdentifier:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("macos26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("tvos26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("maccatalyst26.2", "No longer supported.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetDefaultLeaderboardIdentifier (string leaderboardIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (leaderboardIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leaderboardIdentifier));
			var nsleaderboardIdentifier = CFString.CreateNative (leaderboardIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetDefaultLeaderboardIdentifier_CompletionHandler_XHandle, nsleaderboardIdentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetDefaultLeaderboardIdentifier_CompletionHandler_XHandle, nsleaderboardIdentifier, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsleaderboardIdentifier);
		}
		/// <param name="leaderboardIdentifier">To be added.</param>
		/// <summary>Asynchronously sets the local player's default leaderboard identifier.</summary>
		/// <returns>A task that represents the asynchronous SetDefaultLeaderboardIdentifier operation</returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("macos26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("tvos26.2", "No longer supported.")]
		[ObsoletedOSPlatform ("maccatalyst26.2", "No longer supported.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SetDefaultLeaderboardIdentifierAsync (string leaderboardIdentifier)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetDefaultLeaderboardIdentifier(leaderboardIdentifier, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("unregisterAllListeners")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnregisterAllListeners ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUnregisterAllListenersXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUnregisterAllListenersXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unregisterListener:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnregisterListener (IGKLocalPlayerListener listener)
		{
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnregisterListener_XHandle, listener__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnregisterListener_XHandle, listener__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (listener);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public unsafe virtual global::System.Action<global::AppKit.NSViewController, NSError>? AuthenticateHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity2V92))]
			[Export ("authenticateHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAuthenticateHandlerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAuthenticateHandlerXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity2V92.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V92))]
			[Export ("setAuthenticateHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity2V92.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAuthenticateHandler_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAuthenticateHandler_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Current authentication state for the local player.</summary><value>True if the user has been authenticated, false otherwise.</value><remarks>
		/// 
		/// 	  This property changes as the application transitions from
		/// 	  background to foreground, so you should check the value of
		/// 	  this property on your handler and enable or disable features
		/// 	  that depend on it in your game.
		/// 
		/// 	</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Authenticated {
			[Export ("isAuthenticated")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAuthenticatedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAuthenticatedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'LoadFriendPlayers' instead and collect the friends from the invoked callback.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'LoadFriendPlayers' instead and collect the friends from the invoked callback.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LoadFriendPlayers' instead and collect the friends from the invoked callback.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string[]? Friends {
			[Export ("friends", ArgumentSemantic.Retain)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFriendsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFriendsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IsPresentingFriendRequestViewController {
			[Export ("isPresentingFriendRequestViewController")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPresentingFriendRequestViewControllerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPresentingFriendRequestViewControllerXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a value that tells whether the player is undreaged.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsUnderage {
			[Export ("isUnderage")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUnderageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsUnderageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static GKLocalPlayer Local {
			[Export ("local")]
			get {
				GKLocalPlayer? ret;
				ret =  Runtime.GetNSObject<GKLocalPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLocalXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKLocalPlayer LocalPlayer {
			[Export ("localPlayer")]
			get {
				GKLocalPlayer? ret;
				ret =  Runtime.GetNSObject<GKLocalPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLocalPlayerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool MultiplayerGamingRestricted {
			[Export ("isMultiplayerGamingRestricted")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsMultiplayerGamingRestrictedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsMultiplayerGamingRestrictedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool PersonalizedCommunicationRestricted {
			[Export ("isPersonalizedCommunicationRestricted")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPersonalizedCommunicationRestrictedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPersonalizedCommunicationRestrictedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AuthenticationDidChangeNotificationName;
		/// <summary>Notification constant for AuthenticationDidChangeNotificationName</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAuthenticationDidChangeNotificationName(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveAuthenticationDidChangeNotificationName(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = GKLocalPlayer.Notifications.ObserveAuthenticationDidChangeNotificationName ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, GKLocalPlayer.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = GKLocalPlayer.Notifications.ObserveAuthenticationDidChangeNotificationName (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     GKLocalPlayer.AuthenticationDidChangeNotificationNameNotification, (notification) => { Console.WriteLine ("Received the notification AuthenticationDidChangeNotificationName", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AuthenticationDidChangeNotificationName", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (GKLocalPlayer.AuthenticationDidChangeNotificationNameNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("GKPlayerAuthenticationDidChangeNotificationName",  "GameKit")]
		[Advice ("Use GKLocalPlayer.Notifications.ObserveAuthenticationDidChangeNotificationName helper method instead.")]
		public static NSString AuthenticationDidChangeNotificationName {
			get {
				if (_AuthenticationDidChangeNotificationName is null)
					_AuthenticationDidChangeNotificationName = Dlfcn.GetStringConstant (Libraries.GameKit.Handle, "GKPlayerAuthenticationDidChangeNotificationName")!;
				return _AuthenticationDidChangeNotificationName;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::GameKit.GKLocalPlayer" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::GameKit.GKLocalPlayer.AuthenticationDidChangeNotificationName" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::GameKit.GKLocalPlayer.AuthenticationDidChangeNotificationName" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = GKLocalPlayer.Notifications.ObserveAuthenticationDidChangeNotificationName ((notification) => {
			///   Console.WriteLine ("Observed AuthenticationDidChangeNotificationNameNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAuthenticationDidChangeNotificationName (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AuthenticationDidChangeNotificationName, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::GameKit.GKLocalPlayer.AuthenticationDidChangeNotificationName" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::GameKit.GKLocalPlayer.AuthenticationDidChangeNotificationName" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = GKLocalPlayer.Notifications.ObserveAuthenticationDidChangeNotificationName (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AuthenticationDidChangeNotificationNameNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAuthenticationDidChangeNotificationName (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AuthenticationDidChangeNotificationName, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class GKLocalPlayer */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class GKFetchItemsForIdentityVerificationSignature {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSUrl PublicKeyUrl { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSData Signature { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSData Salt { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public ulong Timestamp { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="publicKeyUrl">Result value from an asynchronous operation.</param>
		/// <param name="signature">Result value from an asynchronous operation.</param>
		/// <param name="salt">Result value from an asynchronous operation.</param>
		/// <param name="timestamp">Result value from an asynchronous operation.</param>
		public GKFetchItemsForIdentityVerificationSignature (NSUrl publicKeyUrl, NSData signature, NSData salt, ulong timestamp) {
			this.PublicKeyUrl = publicKeyUrl;
			this.Signature = signature;
			this.Salt = salt;
			this.Timestamp = timestamp;
			Initialize ();
		}
	}
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class GKIdentityVerificationSignatureResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSUrl PublicKeyUrl { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSData Signature { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSData Salt { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public ulong Timestamp { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="publicKeyUrl">Result value from an asynchronous operation.</param>
		/// <param name="signature">Result value from an asynchronous operation.</param>
		/// <param name="salt">Result value from an asynchronous operation.</param>
		/// <param name="timestamp">Result value from an asynchronous operation.</param>
		public GKIdentityVerificationSignatureResult (NSUrl publicKeyUrl, NSData signature, NSData salt, ulong timestamp) {
			this.PublicKeyUrl = publicKeyUrl;
			this.Signature = signature;
			this.Salt = salt;
			this.Timestamp = timestamp;
			Initialize ();
		}
	}
}
