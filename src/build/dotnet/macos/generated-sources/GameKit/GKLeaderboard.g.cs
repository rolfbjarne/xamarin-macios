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
	[Register("GKLeaderboard", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKLeaderboard : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivityIdentifierX = "activityIdentifier";
		static readonly NativeHandle selActivityIdentifierXHandle = Selector.GetHandle ("activityIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivityPropertiesX = "activityProperties";
		static readonly NativeHandle selActivityPropertiesXHandle = Selector.GetHandle ("activityProperties");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseLeaderboardIDX = "baseLeaderboardID";
		static readonly NativeHandle selBaseLeaderboardIDXHandle = Selector.GetHandle ("baseLeaderboardID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCategoryX = "category";
		static readonly NativeHandle selCategoryXHandle = Selector.GetHandle ("category");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupIdentifierX = "groupIdentifier";
		static readonly NativeHandle selGroupIdentifierXHandle = Selector.GetHandle ("groupIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierX = "identifier";
		static readonly NativeHandle selIdentifierXHandle = Selector.GetHandle ("identifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPlayerIDs_X = "initWithPlayerIDs:";
		static readonly NativeHandle selInitWithPlayerIDs_XHandle = Selector.GetHandle ("initWithPlayerIDs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPlayers_X = "initWithPlayers:";
		static readonly NativeHandle selInitWithPlayers_XHandle = Selector.GetHandle ("initWithPlayers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHiddenX = "isHidden";
		static readonly NativeHandle selIsHiddenXHandle = Selector.GetHandle ("isHidden");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLoadingX = "isLoading";
		static readonly NativeHandle selIsLoadingXHandle = Selector.GetHandle ("isLoading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeaderboardDescriptionX = "leaderboardDescription";
		static readonly NativeHandle selLeaderboardDescriptionXHandle = Selector.GetHandle ("leaderboardDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadCategoriesWithCompletionHandler_X = "loadCategoriesWithCompletionHandler:";
		static readonly NativeHandle selLoadCategoriesWithCompletionHandler_XHandle = Selector.GetHandle ("loadCategoriesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadEntriesForPlayerScope_TimeScope_Range_CompletionHandler_X = "loadEntriesForPlayerScope:timeScope:range:completionHandler:";
		static readonly NativeHandle selLoadEntriesForPlayerScope_TimeScope_Range_CompletionHandler_XHandle = Selector.GetHandle ("loadEntriesForPlayerScope:timeScope:range:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadEntriesForPlayers_TimeScope_CompletionHandler_X = "loadEntriesForPlayers:timeScope:completionHandler:";
		static readonly NativeHandle selLoadEntriesForPlayers_TimeScope_CompletionHandler_XHandle = Selector.GetHandle ("loadEntriesForPlayers:timeScope:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadImageWithCompletionHandler_X = "loadImageWithCompletionHandler:";
		static readonly NativeHandle selLoadImageWithCompletionHandler_XHandle = Selector.GetHandle ("loadImageWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadLeaderboardsWithCompletionHandler_X = "loadLeaderboardsWithCompletionHandler:";
		static readonly NativeHandle selLoadLeaderboardsWithCompletionHandler_XHandle = Selector.GetHandle ("loadLeaderboardsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadLeaderboardsWithIDs_CompletionHandler_X = "loadLeaderboardsWithIDs:completionHandler:";
		static readonly NativeHandle selLoadLeaderboardsWithIDs_CompletionHandler_XHandle = Selector.GetHandle ("loadLeaderboardsWithIDs:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadPreviousOccurrenceWithCompletionHandler_X = "loadPreviousOccurrenceWithCompletionHandler:";
		static readonly NativeHandle selLoadPreviousOccurrenceWithCompletionHandler_XHandle = Selector.GetHandle ("loadPreviousOccurrenceWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadScoresWithCompletionHandler_X = "loadScoresWithCompletionHandler:";
		static readonly NativeHandle selLoadScoresWithCompletionHandler_XHandle = Selector.GetHandle ("loadScoresWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalPlayerScoreX = "localPlayerScore";
		static readonly NativeHandle selLocalPlayerScoreXHandle = Selector.GetHandle ("localPlayerScore");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxRangeX = "maxRange";
		static readonly NativeHandle selMaxRangeXHandle = Selector.GetHandle ("maxRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextStartDateX = "nextStartDate";
		static readonly NativeHandle selNextStartDateXHandle = Selector.GetHandle ("nextStartDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlayerScopeX = "playerScope";
		static readonly NativeHandle selPlayerScopeXHandle = Selector.GetHandle ("playerScope");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeX = "range";
		static readonly NativeHandle selRangeXHandle = Selector.GetHandle ("range");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReleaseStateX = "releaseState";
		static readonly NativeHandle selReleaseStateXHandle = Selector.GetHandle ("releaseState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScoresX = "scores";
		static readonly NativeHandle selScoresXHandle = Selector.GetHandle ("scores");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCategory_X = "setCategory:";
		static readonly NativeHandle selSetCategory_XHandle = Selector.GetHandle ("setCategory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultLeaderboard_WithCompletionHandler_X = "setDefaultLeaderboard:withCompletionHandler:";
		static readonly NativeHandle selSetDefaultLeaderboard_WithCompletionHandler_XHandle = Selector.GetHandle ("setDefaultLeaderboard:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIdentifier_X = "setIdentifier:";
		static readonly NativeHandle selSetIdentifier_XHandle = Selector.GetHandle ("setIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPlayerScope_X = "setPlayerScope:";
		static readonly NativeHandle selSetPlayerScope_XHandle = Selector.GetHandle ("setPlayerScope:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRange_X = "setRange:";
		static readonly NativeHandle selSetRange_XHandle = Selector.GetHandle ("setRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimeScope_X = "setTimeScope:";
		static readonly NativeHandle selSetTimeScope_XHandle = Selector.GetHandle ("setTimeScope:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartDateX = "startDate";
		static readonly NativeHandle selStartDateXHandle = Selector.GetHandle ("startDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubmitScore_Context_Player_CompletionHandler_X = "submitScore:context:player:completionHandler:";
		static readonly NativeHandle selSubmitScore_Context_Player_CompletionHandler_XHandle = Selector.GetHandle ("submitScore:context:player:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubmitScore_Context_Player_LeaderboardIDs_CompletionHandler_X = "submitScore:context:player:leaderboardIDs:completionHandler:";
		static readonly NativeHandle selSubmitScore_Context_Player_LeaderboardIDs_CompletionHandler_XHandle = Selector.GetHandle ("submitScore:context:player:leaderboardIDs:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeScopeX = "timeScope";
		static readonly NativeHandle selTimeScopeXHandle = Selector.GetHandle ("timeScope");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeX = "type";
		static readonly NativeHandle selTypeXHandle = Selector.GetHandle ("type");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKLeaderboard");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected GKLeaderboard (NSObjectFlag t) : base (t)
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
		protected internal GKLeaderboard (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadLeaderboards' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadLeaderboards' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadLeaderboards' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadLeaderboards' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKLeaderboard ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithPlayerIDs:")]
		[ObsoletedOSPlatform ("ios8.0", "Use '.ctor (GKPlayer [] players)' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use '.ctor (GKPlayer [] players)' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use '.ctor (GKPlayer [] players)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use '.ctor (GKPlayer [] players)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKLeaderboard (string[]? players)
			: base (NSObjectFlag.Empty)
		{
			using var nsa_players = NSArray.FromNullableStrings (players);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithPlayerIDs_XHandle, nsa_players.GetHandle ()), "initWithPlayerIDs:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithPlayerIDs_XHandle, nsa_players.GetHandle ()), "initWithPlayerIDs:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithPlayers:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKLeaderboard (GKPlayer[] players)
			: base (NSObjectFlag.Empty)
		{
			if (players is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (players));
			using var nsa_players = NSArray.FromNSObjects (players);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithPlayers_XHandle, nsa_players.Handle), "initWithPlayers:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithPlayers_XHandle, nsa_players.Handle), "initWithPlayers:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("loadCategoriesWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'LoadLeaderboards' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'LoadLeaderboards' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LoadLeaderboards' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadCategories ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKCategoryHandler))]GKCategoryHandler? categoryHandler)
		{
			using var block_categoryHandler = Trampolines.SDGKCategoryHandler.CreateNullableBlock (categoryHandler);
			BlockLiteral *block_ptr_categoryHandler = null;
			if (categoryHandler is not null)
				block_ptr_categoryHandler = &block_categoryHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selLoadCategoriesWithCompletionHandler_XHandle, (IntPtr) block_ptr_categoryHandler);
		}
		/// <summary>Deprecated.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous LoadCategories operation.   The value of the TResult parameter is of type GameKit.GKCategoryResult.  Category and title results from the asynchronous  method.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'LoadLeaderboards' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'LoadLeaderboards' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LoadLeaderboards' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<GKCategoryResult> LoadCategoriesAsync ()
		{
			var tcs = new TaskCompletionSource<GKCategoryResult> ();
			LoadCategories((categories_, titles_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new GKCategoryResult (categories_!, titles_!));
			});
			return tcs.Task;
		}
		[Export ("loadEntriesForPlayerScope:timeScope:range:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadEntries (GKLeaderboardPlayerScope playerScope, GKLeaderboardTimeScope timeScope, NSRange range, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKEntriesForPlayerScopeHandler))]GKEntriesForPlayerScopeHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDGKEntriesForPlayerScopeHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange_NativeHandle (this.Handle, selLoadEntriesForPlayerScope_TimeScope_Range_CompletionHandler_XHandle, (IntPtr) (long) playerScope, (IntPtr) (long) timeScope, range, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_NSRange_NativeHandle (&__objc_super__, selLoadEntriesForPlayerScope_TimeScope_Range_CompletionHandler_XHandle, (IntPtr) (long) playerScope, (IntPtr) (long) timeScope, range, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKEntriesForPlayerScopeResult> LoadEntriesAsync (GKLeaderboardPlayerScope playerScope, GKLeaderboardTimeScope timeScope, NSRange range)
		{
			var tcs = new TaskCompletionSource<GKEntriesForPlayerScopeResult> ();
			LoadEntries(playerScope, timeScope, range, (localPlayerEntry_, entries_, totalPlayerCount_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new GKEntriesForPlayerScopeResult (localPlayerEntry_!, entries_!, totalPlayerCount_!));
			});
			return tcs.Task;
		}
		[Export ("loadEntriesForPlayers:timeScope:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadEntries (GKPlayer[] players, GKLeaderboardTimeScope timeScope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKEntriesForPlayersHandler))]GKEntriesForPlayersHandler completionHandler)
		{
			if (players is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (players));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_players = NSArray.FromNSObjects (players);
			using var block_completionHandler = Trampolines.SDGKEntriesForPlayersHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, selLoadEntriesForPlayers_TimeScope_CompletionHandler_XHandle, nsa_players.Handle, (IntPtr) (long) timeScope, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selLoadEntriesForPlayers_TimeScope_CompletionHandler_XHandle, nsa_players.Handle, (IntPtr) (long) timeScope, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKEntriesForPlayersResult> LoadEntriesAsync (GKPlayer[] players, GKLeaderboardTimeScope timeScope)
		{
			var tcs = new TaskCompletionSource<GKEntriesForPlayersResult> ();
			LoadEntries(players, timeScope, (localPlayerEntry_, entries_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new GKEntriesForPlayersResult (localPlayerEntry_!, entries_!));
			});
			return tcs.Task;
		}
		[Export ("loadImageWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadImage ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKImageLoadedHandler))]GKImageLoadedHandler? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDGKImageLoadedHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadImageWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadImageWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Loads the leaderboard image asynchronously.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous LoadImage operation.  The result is of type System.Threading.Tasks.Task&lt;AppKit.NSImage&gt; on MacOS and System.Threading.Tasks.Task&lt;UIKit.UIImage&gt; on iOS.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The LoadImageAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<global::AppKit.NSImage> LoadImageAsync ()
		{
			var tcs = new TaskCompletionSource<global::AppKit.NSImage> ();
			LoadImage((image_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (image_!);
			});
			return tcs.Task;
		}
		[Export ("loadLeaderboardsWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadLeaderBoards(string[] leaderboardIDs, GKLeaderboardsHandler completionHandler)' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadLeaderBoards(string[] leaderboardIDs, GKLeaderboardsHandler completionHandler)' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadLeaderBoards(string[] leaderboardIDs, GKLeaderboardsHandler completionHandler)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadLeaderBoards(string[] leaderboardIDs, GKLeaderboardsHandler completionHandler)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadLeaderboards ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V88))]global::System.Action<GKLeaderboard[], NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity2V88.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selLoadLeaderboardsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		/// <summary>Retrieves the list of leaderboards that have been configured for your application.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadLeaderboards operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKLeaderboard[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadLeaderBoards(string[] leaderboardIDs, GKLeaderboardsHandler completionHandler)' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadLeaderBoards(string[] leaderboardIDs, GKLeaderboardsHandler completionHandler)' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadLeaderBoards(string[] leaderboardIDs, GKLeaderboardsHandler completionHandler)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadLeaderBoards(string[] leaderboardIDs, GKLeaderboardsHandler completionHandler)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<GKLeaderboard[]> LoadLeaderboardsAsync ()
		{
			var tcs = new TaskCompletionSource<GKLeaderboard[]> ();
			LoadLeaderboards((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadLeaderboardsWithIDs:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadLeaderboards (string[]? leaderboardIds, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKLeaderboardsHandler))]GKLeaderboardsHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_leaderboardIds = NSArray.FromNullableStrings (leaderboardIds);
			using var block_completionHandler = Trampolines.SDGKLeaderboardsHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selLoadLeaderboardsWithIDs_CompletionHandler_XHandle, nsa_leaderboardIds.GetHandle (), (IntPtr) block_ptr_completionHandler);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<GKLeaderboard[]> LoadLeaderboardsAsync (string[]? leaderboardIds)
		{
			var tcs = new TaskCompletionSource<GKLeaderboard[]> ();
			LoadLeaderboards(leaderboardIds, (leaderboards_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (leaderboards_!);
			});
			return tcs.Task;
		}
		[Export ("loadPreviousOccurrenceWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadPreviousOccurrence ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKLeaderboardsHandler))]GKLeaderboardsHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDGKLeaderboardsHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadPreviousOccurrenceWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadPreviousOccurrenceWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKLeaderboard[]> LoadPreviousOccurrenceAsync ()
		{
			var tcs = new TaskCompletionSource<GKLeaderboard[]> ();
			LoadPreviousOccurrence((leaderboards_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (leaderboards_!);
			});
			return tcs.Task;
		}
		[Export ("loadScoresWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadScores ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKScoresLoadedHandler))]GKScoresLoadedHandler? scoresLoadedHandler)
		{
			using var block_scoresLoadedHandler = Trampolines.SDGKScoresLoadedHandler.CreateNullableBlock (scoresLoadedHandler);
			BlockLiteral *block_ptr_scoresLoadedHandler = null;
			if (scoresLoadedHandler is not null)
				block_ptr_scoresLoadedHandler = &block_scoresLoadedHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadScoresWithCompletionHandler_XHandle, (IntPtr) block_ptr_scoresLoadedHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadScoresWithCompletionHandler_XHandle, (IntPtr) block_ptr_scoresLoadedHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously loads scores from the Game Center.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous LoadScores operation.   The value of the TResult parameter is a GameKit.GKScoresLoadedHandler.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKScore[]> LoadScoresAsync ()
		{
			var tcs = new TaskCompletionSource<GKScore[]> ();
			LoadScores((scoreArray_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (scoreArray_!);
			});
			return tcs.Task;
		}
		[Export ("setDefaultLeaderboard:withCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetDefaultLeaderboard (string? leaderboardIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? notificationHandler)
		{
			var nsleaderboardIdentifier = CFString.CreateNative (leaderboardIdentifier);
			using var block_notificationHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (notificationHandler);
			BlockLiteral *block_ptr_notificationHandler = null;
			if (notificationHandler is not null)
				block_ptr_notificationHandler = &block_notificationHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selSetDefaultLeaderboard_WithCompletionHandler_XHandle, nsleaderboardIdentifier, (IntPtr) block_ptr_notificationHandler);
			CFString.ReleaseNative (nsleaderboardIdentifier);
		}
		/// <param name="leaderboardIdentifier">To be added.</param>
		/// <summary>Deprecated.</summary>
		/// <returns>A task that represents the asynchronous SetDefaultLeaderboard operation</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task SetDefaultLeaderboardAsync (string? leaderboardIdentifier)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SetDefaultLeaderboard(leaderboardIdentifier, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("submitScore:context:player:leaderboardIDs:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SubmitScore (nint score, nuint context, GKPlayer player, string[] leaderboardIds, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (leaderboardIds is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leaderboardIds));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_leaderboardIds = NSArray.FromStrings (leaderboardIds);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_NativeHandle_NativeHandle_NativeHandle (class_ptr, selSubmitScore_Context_Player_LeaderboardIDs_CompletionHandler_XHandle, score, context, player__handle__, nsa_leaderboardIds.Handle, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (player);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task SubmitScoreAsync (nint score, nuint context, GKPlayer player, string[] leaderboardIds)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SubmitScore(score, context, player, leaderboardIds, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("submitScore:context:player:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SubmitScore (nint score, nuint context, GKPlayer player, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_NativeHandle_NativeHandle (this.Handle, selSubmitScore_Context_Player_CompletionHandler_XHandle, score, context, player__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, selSubmitScore_Context_Player_CompletionHandler_XHandle, score, context, player__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SubmitScoreAsync (nint score, nuint context, GKPlayer player)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SubmitScore(score, context, player, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual string ActivityIdentifier {
			[Export ("activityIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActivityIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActivityIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual NSDictionary<NSString, NSString> ActivityProperties {
			[Export ("activityProperties", ArgumentSemantic.Retain)]
			get {
				NSDictionary<NSString, NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActivityPropertiesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActivityPropertiesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string BaseLeaderboardId {
			[Export ("baseLeaderboardID", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBaseLeaderboardIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBaseLeaderboardIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'Identifier' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'Identifier' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Identifier' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string? Category {
			[Export ("category", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCategoryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCategoryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCategory:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCategory_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCategory_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual double Duration {
			[Export ("duration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GroupIdentifier {
			[Export ("groupIdentifier", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroupIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroupIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIdentifier:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual bool IsHidden {
			[Export ("isHidden")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHiddenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHiddenXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the leaderboard is currently retrieving scores.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool IsLoading {
			[Export ("isLoading")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLoadingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLoadingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual string LeaderboardDescription {
			[Export ("leaderboardDescription")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeaderboardDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeaderboardDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual GKScore? LocalPlayerScore {
			[Export ("localPlayerScore", ArgumentSemantic.Retain)]
			get {
				GKScore? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GKScore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalPlayerScoreXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GKScore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalPlayerScoreXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual nint MaxRange {
			[Export ("maxRange", ArgumentSemantic.Assign)]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMaxRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMaxRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSDate? NextStartDate {
			[Export ("nextStartDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNextStartDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNextStartDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual GKLeaderboardPlayerScope PlayerScope {
			[Export ("playerScope", ArgumentSemantic.Assign)]
			get {
				GKLeaderboardPlayerScope ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKLeaderboardPlayerScope) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPlayerScopeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKLeaderboardPlayerScope) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPlayerScopeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPlayerScope:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetPlayerScope_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetPlayerScope_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSRange Range {
			[Export ("range", ArgumentSemantic.Assign)]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRange:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selSetRange_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selSetRange_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual GKReleaseState ReleaseState {
			[Export ("releaseState", ArgumentSemantic.Assign)]
			get {
				GKReleaseState ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKReleaseState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selReleaseStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKReleaseState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selReleaseStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual GKScore[]? Scores {
			[Export ("scores", ArgumentSemantic.Retain)]
			get {
				GKScore[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKScore>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selScoresXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKScore>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selScoresXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSDate? StartDate {
			[Export ("startDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStartDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStartDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'LoadEntries' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'LoadEntries' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual GKLeaderboardTimeScope TimeScope {
			[Export ("timeScope", ArgumentSemantic.Assign)]
			get {
				GKLeaderboardTimeScope ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKLeaderboardTimeScope) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTimeScopeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKLeaderboardTimeScope) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTimeScopeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTimeScope:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTimeScope_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetTimeScope_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("title", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual GKLeaderboardType Type {
			[Export ("type")]
			get {
				GKLeaderboardType ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKLeaderboardType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKLeaderboardType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class GKLeaderboard */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class GKCategoryResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public string[] Categories { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public string[] Titles { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="categories">Result value from an asynchronous operation.</param>
		/// <param name="titles">Result value from an asynchronous operation.</param>
		public GKCategoryResult (string[] categories, string[] titles) {
			this.Categories = categories;
			this.Titles = titles;
			Initialize ();
		}
	}
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class GKEntriesForPlayerScopeResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public GKLeaderboardEntry LocalPlayerEntry { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public GKLeaderboardEntry[] Entries { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public nint TotalPlayerCount { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="localPlayerEntry">Result value from an asynchronous operation.</param>
		/// <param name="entries">Result value from an asynchronous operation.</param>
		/// <param name="totalPlayerCount">Result value from an asynchronous operation.</param>
		public GKEntriesForPlayerScopeResult (GKLeaderboardEntry localPlayerEntry, GKLeaderboardEntry[] entries, nint totalPlayerCount) {
			this.LocalPlayerEntry = localPlayerEntry;
			this.Entries = entries;
			this.TotalPlayerCount = totalPlayerCount;
			Initialize ();
		}
	}
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class GKEntriesForPlayersResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public GKLeaderboardEntry LocalPlayerEntry { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public GKLeaderboardEntry[] Entries { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="localPlayerEntry">Result value from an asynchronous operation.</param>
		/// <param name="entries">Result value from an asynchronous operation.</param>
		public GKEntriesForPlayersResult (GKLeaderboardEntry localPlayerEntry, GKLeaderboardEntry[] entries) {
			this.LocalPlayerEntry = localPlayerEntry;
			this.Entries = entries;
			Initialize ();
		}
	}
}
